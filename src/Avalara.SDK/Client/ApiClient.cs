/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * foundation
 *
 * Platform foundation consists of services on top of which the Avalara Compliance Cloud platform is built. These services are foundational and provide functionality such as common organization, tenant and user management for the rest of the compliance platform.
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @version    2.4.41
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;
using System.Net.Http;
using System.Net.Http.Headers;
using Polly;
using Avalara.SDK.Auth;
using System.Runtime.CompilerServices;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// To Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
    /// </summary>
    internal class CustomJsonCodec
    {
        private readonly IReadableConfiguration _configuration;
        private static readonly string _contentType = "application/json";
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(IReadableConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        /// <summary>
        /// Serialize the object into a JSON string.
        /// </summary>
        /// <param name="obj">Object to be serialized.</param>
        /// <returns>A JSON string.</returns>
        public string Serialize(object obj)
        {
            if (obj != null && obj is Avalara.SDK.Model.EInvoicing.V1.AbstractOpenAPISchema)
            {
                // the object to be serialized is an oneOf/anyOf schema
                return ((Avalara.SDK.Model.EInvoicing.V1.AbstractOpenAPISchema)obj).ToJson();
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _serializerSettings);
            }
        }

        public async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            var result = (T)await Deserialize(response, typeof(T));
            return result;
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal async Task<object> Deserialize(HttpResponseMessage response, Type type)
        {
            IList<string> headers = response.Headers.Select(x => x.Key + "=" + x.Value).ToList();

            if (type == typeof(byte[])) // return byte array
            {
                return await response.Content.ReadAsByteArrayAsync();
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                var bytes = await response.Content.ReadAsByteArrayAsync();
                if (headers != null)
                {
                    var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : _configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(bytes);
                return stream;
            }

            if (type == typeof(FileParameter)) // return a FileParameter object for binary file responses
            {
                var bytes = await response.Content.ReadAsByteArrayAsync();

                string fileName = "downloaded_file";
                var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                foreach (var header in headers)
                {
                    var match = regex.Match(header.ToString());
                    if (match.Success)
                    {
                        fileName = ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                        break;
                    }
                }

                string contentType = "application/octet-stream";
                if (response.Content.Headers.ContentType != null)
                {
                    contentType = response.Content.Headers.ContentType.ToString();
                }

                var stream = new MemoryStream(bytes);
                return new FileParameter(fileName, contentType, stream);
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(await response.Content.ReadAsStringAsync(), null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(await response.Content.ReadAsStringAsync(), type);
            }

            // at this point, it must be a model (json)
            try
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject(responseContent, type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public string ContentType
        {
            get { return _contentType; }
            set { throw new InvalidOperationException("Not allowed to set content type."); }
        }
    }
    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementations),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    /// <remarks>
    /// The Dispose method will manage the HttpClient lifecycle when not passed by constructor.
    /// </remarks>
    public partial class ApiClient : IInternalApiClient
    {
        /// <summary>
        /// The standard client header for AvaTax API calls
        /// </summary>
        private static readonly string AVALARA_CLIENT_HEADER = "X-Avalara-Client";

        /// <summary>
        /// Version of the SDK being used
        /// </summary>
        private string sdkVersion;

        /// <summary>
        /// SDKVersion property - Cannot be set by user
        /// </summary>
        string IInternalApiClient.SdkVersion
        {
            get { return this.sdkVersion; }
            set { this.sdkVersion = value; }
        }

        /// <summary>
        /// The standard configuration object
        /// </summary>
        public IReadableConfiguration Configuration { get; }
        /// <summary>
        /// SDKVersion property - Connot be set by user
        /// </summary>
        internal string SdkVersion;

        private IOAuth OAuthObj;
        private Hashtable hashScopeTable;

        /// <summary>
        /// Specifies the settings on a <see cref="JsonSerializer" /> object.
        /// These settings can be adjusted to accommodate custom serialization rules.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Initializes a new instance of the ApiClient />
        /// </summary>
        /// <param name="config"></param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(IReadableConfiguration config)
        {
            this.Configuration = Avalara.SDK.Client.Configuration.MergeConfigurations(
                Avalara.SDK.Client.GlobalConfiguration.Instance,
                config
            );

            hashScopeTable = new Hashtable();
            CheckConfiguration();
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            Configuration.HttpClient.Dispose();
        }

        /// Prepares multipart/form-data content
        HttpContent PrepareMultipartFormDataContent(RequestOptions options)
        {
            string boundary = "---------" + Guid.NewGuid().ToString().ToUpperInvariant();
            var multipartContent = new MultipartFormDataContent(boundary);
            foreach (var formParameter in options.FormParameters)
            {
                multipartContent.Add(new StringContent(formParameter.Value), formParameter.Key);
            }

            if (options.FileParameters != null && options.FileParameters.Count > 0)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    foreach (var file in fileParam.Value)
                    {
                        var content = new StreamContent(file.Content);
                        content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
                        multipartContent.Add(content, fileParam.Key, file.Name);
                    }
                }
            }
            return multipartContent;
        }

        /// <summary>
        /// Provides all logic for constructing a new HttpRequestMessage.
        /// At this point, all information for querying the service is known. Here, it is simply
        /// mapped into the a HttpRequestMessage.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>[private] A new HttpRequestMessage instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private HttpRequestMessage NewRequest(
            HttpMethod method,
            string path,
            RequestOptions options,
            AvalaraMicroservice microservice)
        {
            CheckConfiguration();
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");

            string sdkClientHeader = String.Format("{0}; {1}; {2}; {3}; {4}", Configuration.AppName, Configuration.AppVersion,
                "CSharpRestClient", ((IInternalApiClient)this).SdkVersion, Configuration.MachineName);

            WebRequestPathBuilder builder = new WebRequestPathBuilder(Configuration.GetBasePath(microservice), path);

            builder.AddPathParameters(options.PathParameters);

            builder.AddQueryParameters(options.QueryParameters);

            HttpRequestMessage request = new HttpRequestMessage(method, builder.GetFullUri());

            // Always set X-Avalara-SDK-Client to SDK info
            request.Headers.Add("X-Avalara-SDK-Client", sdkClientHeader);

            // If X-Avalara-Client is null/empty, set it to SDK info as well
            if (!options.HeaderParameters.TryGetValue(AVALARA_CLIENT_HEADER, out var avalaraClientValue) ||
                String.IsNullOrWhiteSpace(avalaraClientValue.FirstOrDefault()))
            {
                request.Headers.Add(AVALARA_CLIENT_HEADER, sdkClientHeader);
            }

            if (Configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in Configuration.DefaultHeaders)
                {
                    request.Headers.Add(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        // Todo make content headers actually content headers
                        request.Headers.TryAddWithoutValidation(headerParam.Key, value);
                    }
                }
            }

            List<Tuple<HttpContent, string, string>> contentList = new List<Tuple<HttpContent, string, string>>();

            string contentType = null;
            if (options.HeaderParameters != null && options.HeaderParameters.ContainsKey("Content-Type"))
            {
                var contentTypes = options.HeaderParameters["Content-Type"];
                contentType = contentTypes.FirstOrDefault();
            }

            if (contentType == "multipart/form-data")
            {
                request.Content = PrepareMultipartFormDataContent(options);
            }
            else if (contentType == "application/x-www-form-urlencoded")
            {
                request.Content = new FormUrlEncodedContent(options.FormParameters);
            }
            else
            {
                if (options.Data != null)
                {
                    if (options.Data is FileParameter fp)
                    {
                        contentType = contentType ?? "application/octet-stream";

                        var streamContent = new StreamContent(fp.Content);
                        streamContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                        request.Content = streamContent;
                    }
                    else
                    {
                        var serializer = new CustomJsonCodec(SerializerSettings, Configuration);
                        request.Content = new StringContent(serializer.Serialize(options.Data), new UTF8Encoding(),
                            "application/json");
                    }
                }
            }



            // TODO provide an alternative that allows cookies per request instead of per API client
            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                request.Properties["CookieContainer"] = options.Cookies;
            }

            return request;
        }

        private void InterceptRequest(HttpRequestMessage req, string requiredScopes)
        {
            if (!string.IsNullOrEmpty(this.Configuration.BearerToken))
            {
                req.Headers.Add("Authorization", "Bearer " + this.Configuration.BearerToken);
            }
            //OAuth2 flow
            else if (!this.Configuration.ClientID.IsNullorEmpty() && !this.Configuration.ClientSecret.IsNullorEmpty())
            {
                var accessKey = GetOAuthAccessToken(requiredScopes);
                if (accessKey == null)
                {
                    UpdateOAuthAccessToken(requiredScopes);
                    accessKey = GetOAuthAccessToken(requiredScopes);
                }
                req.Headers.Add("Authorization", "Bearer " + accessKey.AccessToken);
            }
            // authentication (BasicAuth) required
            else if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                req.Headers.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

        }
        partial void InterceptResponse(HttpRequestMessage req, HttpResponseMessage response);

        private async Task<ApiResponse<T>> ToApiResponse<T>(HttpResponseMessage response, object responseData, Uri uri)
        {
            T result = (T)responseData;
            string rawContent = await response.Content.ReadAsStringAsync();

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ReasonPhrase,
                Cookies = new List<Cookie>()
            };

            // process response headers, e.g. Access-Control-Allow-Methods
            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            // process response content headers, e.g. Content-Type
            if (response.Content.Headers != null)
            {
                foreach (var responseHeader in response.Content.Headers)
                {
                    transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (Configuration.HttpClientHandler != null && response != null)
            {
                try
                {
                    foreach (Cookie cookie in Configuration.HttpClientHandler.CookieContainer.GetCookies(uri))
                    {
                        transformed.Cookies.Add(cookie);
                    }
                }
                catch (PlatformNotSupportedException) { }
            }

            return transformed;
        }

        private ApiResponse<T> Exec<T>(HttpRequestMessage req, string requiredScopes)
        {
            return ExecAsync<T>(req, requiredScopes).GetAwaiter().GetResult();
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(HttpRequestMessage req,
            string requiredScopes,
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var deserializer = new CustomJsonCodec(SerializerSettings, Configuration);

            var finalToken = cancellationToken;

            if (Configuration.Timeout > 0)
            {
                var tokenSource = new CancellationTokenSource(Configuration.Timeout);
                finalToken = CancellationTokenSource.CreateLinkedTokenSource(finalToken, tokenSource.Token).Token;
            }

            if (Configuration.ClientCertificates != null)
            {
                if (Configuration.HttpClientHandler == null) throw new InvalidOperationException("Configuration `ClientCertificates` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
                Configuration.HttpClientHandler.ClientCertificates.AddRange(Configuration.ClientCertificates);
            }

            var cookieContainer = req.Properties.ContainsKey("CookieContainer") ? req.Properties["CookieContainer"] as List<Cookie> : null;

            if (cookieContainer != null)
            {
                if (Configuration.HttpClientHandler == null) throw new InvalidOperationException("Request property `CookieContainer` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
                foreach (var cookie in cookieContainer)
                {
                    Configuration.HttpClientHandler.CookieContainer.Add(cookie);
                }
            }

            InterceptRequest(req, requiredScopes);

            HttpResponseMessage response;
            if (RetryConfiguration.AsyncRetryPolicy != null)
            {
                var policy = RetryConfiguration.AsyncRetryPolicy;
                var policyResult = await policy
                    .ExecuteAndCaptureAsync(() => Configuration.HttpClient.SendAsync(req, cancellationToken))
                    .ConfigureAwait(false);
                response = (policyResult.Outcome == OutcomeType.Successful) ?
                    policyResult.Result : new HttpResponseMessage()
                    {
                        ReasonPhrase = policyResult.FinalException.ToString(),
                        RequestMessage = req
                    };
            }
            else
            {
                response = await Configuration.HttpClient.SendAsync(req, cancellationToken).ConfigureAwait(false);
            }

            if (response != null && (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden))
            {
                if (!this.Configuration.ClientID.IsNullorEmpty()) //OAuth2 is configured
                {
                    string authHeader = Convert.ToString(req.Headers.First(x => x.Key == "Authorization").Value);
                    if (!authHeader.IsNullorEmpty())
                    {
                        string[] authValues = authHeader.Split(' ');
                        if (authValues.Length == 2)
                        {
                            UpdateOAuthAccessToken(requiredScopes, authValues[1]);
                            string accessToken = GetOAuthAccessToken(requiredScopes).AccessToken;
                            req.Headers.Add("Authorization", "Bearer " + accessToken);
                            response = await Configuration.HttpClient.SendAsync(req, cancellationToken).ConfigureAwait(false);
                        }
                    }
                }
                else if (this.Configuration.RefreshTokenDelegate != null)
                {
                    // Execute injected delegate to get a new access token
                    string accessToken = await this.Configuration.RefreshTokenDelegate();

                    // Clone the request or create a new one with the same properties
                    var newRequest = new HttpRequestMessage(req.Method, req.RequestUri)
                    {
                        Content = req.Content != null ? await CloneHttpContent(req.Content) : null
                    };

                    foreach (var header in req.Headers)
                    {
                        newRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }

                    // Update config instance with new access token
                    this.Configuration.BearerToken = accessToken;

                    // Remove old and add new Authorization header
                    newRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    // Send the cloned request
                    response = await Configuration.HttpClient.SendAsync(newRequest, cancellationToken).ConfigureAwait(false);
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                return await ToApiResponse<T>(response, default(T), req.RequestUri);
            }

            object responseData = await deserializer.Deserialize<T>(response);

            // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
            if (typeof(Avalara.SDK.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
            {
                responseData = (T)typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
            }
            else if (typeof(T).Name == "Stream") // for binary response
            {
                responseData = (T)(object)await response.Content.ReadAsStreamAsync();
            }

            InterceptResponse(req, response);

            return await ToApiResponse<T>(response, responseData, req.RequestUri);
        }

        private static async Task<HttpContent> CloneHttpContent(HttpContent originalContent)
        {
            var memStream = new MemoryStream();
            await originalContent.CopyToAsync(memStream).ConfigureAwait(false);
            memStream.Position = 0;

            var newContent = new StreamContent(memStream);
            foreach (var header in originalContent.Headers)
            {
                newContent.Headers.Add(header.Key, header.Value);
            }

            return newContent;
        }

        private void CheckConfiguration()
        {
            if (Configuration == null)
                throw new ArgumentException("configuration cannot be empty");

            if (Configuration.Environment == null)
                throw new ArgumentException("Environment is not set in the configuration");
            if (Configuration.Environment == AvalaraEnvironment.Test)
            {
                if (string.IsNullOrEmpty(Configuration.TestBasePath))
                    throw new ArgumentException("TestBasePath is required for Test Environment");

                if (string.IsNullOrEmpty(Configuration.TestTokenURL))
                    throw new ArgumentException("TestTokenURL is required for Test Environment");
            }

        }

        private TokenResponse GetOAuthAccessToken(string requiredScopes)
        {
            var scopes = StandardizeScopes(requiredScopes);
            if (this.hashScopeTable.ContainsKey(scopes))
            {
                var accessToken = (TokenResponse)hashScopeTable[scopes];
                var expirationTime = DateTime.Now.AddMinutes(5);
                if (expirationTime < accessToken.ExpiryDateTime)
                {
                    return accessToken;
                }
            }
            return null;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void UpdateOAuthAccessToken(string requiredScopes, string access_token = default(string))
        {
            var scopes = StandardizeScopes(requiredScopes);
            if (GetOAuthAccessToken(scopes) == null ||
                GetOAuthAccessToken(scopes).AccessToken.Equals(access_token))
            {
                if (this.OAuthObj == null)
                {
                    OAuthObj = new Auth.OAuth2ClientCredentials(Configuration, scopes);
                }
                var accessToken = this.OAuthObj.GetAccessToken();
                if (this.hashScopeTable.ContainsKey(scopes))
                {
                    this.hashScopeTable[scopes] = accessToken;
                }
                else
                {
                    this.hashScopeTable.Add(scopes, accessToken);
                }
            }

        }
        private string StandardizeScopes(string scopes)
        {
            string[] scopeArray = scopes.Split(' ');
            Array.Sort(scopeArray);
            return String.Join(" ", scopeArray);
        }

        #region IAsynchronousClient
        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options, microservice), requiredScopes, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options, microservice), requiredScopes, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PUT request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options, microservice), requiredScopes, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP DELETE request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options, microservice), requiredScopes, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP HEAD request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options, microservice), requiredScopes, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP OPTION request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options, microservice), requiredScopes, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PATCH request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return ExecAsync<T>(NewRequest(new HttpMethod("PATCH"), path, options, microservice), requiredScopes, cancellationToken);
        }
        #endregion IAsynchronousClient

        #region ISynchronousClient
        /// <summary>
        /// Make a HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(HttpMethod.Get, path, options, microservice), requiredScopes);
        }

        /// <summary>
        /// Make a HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(HttpMethod.Post, path, options, microservice), requiredScopes);
        }

        /// <summary>
        /// Make a HTTP PUT request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Put<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(HttpMethod.Put, path, options, microservice), requiredScopes);
        }

        /// <summary>
        /// Make a HTTP DELETE request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(HttpMethod.Delete, path, options, microservice), requiredScopes);
        }

        /// <summary>
        /// Make a HTTP HEAD request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Head<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(HttpMethod.Head, path, options, microservice), requiredScopes);
        }

        /// <summary>
        /// Make a HTTP OPTION request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Options<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(HttpMethod.Options, path, options, microservice), requiredScopes);
        }

        /// <summary>
        /// Make a HTTP PATCH request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">OAuth scopes required for the request.</param>
        /// <param name="microservice">A per-request microservice enum to determine which backend to route the request to.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Patch<T>(string path, RequestOptions options, string requiredScopes = default(string), AvalaraMicroservice microservice = AvalaraMicroservice.None)
        {
            return Exec<T>(NewRequest(new HttpMethod("PATCH"), path, options, microservice), requiredScopes);
        }
        #endregion ISynchronousClient
    }
}
