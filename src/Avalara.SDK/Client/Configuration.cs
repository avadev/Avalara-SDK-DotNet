/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using Avalara.SDK.Auth;
using Avalara.SDK.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// Represents an environment for Avalara
    /// </summary>
    public enum AvalaraEnvironment
    {
        /// <summary>
        /// Represents the sandbox environment, https://sandbox-rest.avatax.com
        /// </summary>
        Sandbox = 0,

        /// <summary>
        /// Represents the production environment, https://rest.avatax.com
        /// </summary>
        Production = 1,
        /// <summary>
        /// Represents Test environment - User need to configure TestBasePath and TestTokenUrl (for OAuth2)
        /// </summary>
        Test = 2,
        /// <summary>
        /// Represents the QA environment
        /// </summary>
        QA = 3,
        /// <summary>
        /// Represents the DEV environment
        /// </summary>
        DEV = 4
    }
    /// <summary>
    /// Represents which Microservice in Wfaas is being called
    /// </summary>
    public enum AvalaraMicroservice
    {
        /// <summary>
        /// Represents the E-Invoicing service
        /// </summary>
        EInvoicing = 0,
        /// <summary>
        /// Represents the Track1099 service
        /// </summary>
        A1099 = 1,
        /// <summary>
        /// Represents when no microservice is specified
        /// </summary>
        None = 99,
    }
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Official URL of AvaTax (Dev)
        /// </summary>
        private static readonly string AVALARA_DEV_URL = "https://superapi.dev.avalara.io";
        /// <summary>
        /// Official URL of AvaTax (QA)
        /// </summary>
        private static readonly string AVALARA_QA_URL = "https://superapi.qa.avalara.io";
        /// <summary>
        /// Official URL of AvaTax (Sandbox)
        /// </summary>
        private static readonly string AVALARA_SANDBOX_URL = "https://api.sbx.avalara.com";

        /// <summary>
        /// Official URL of AvaTax (Production)
        /// </summary>
        private static readonly string AVALARA_PRODUCTION_URL = "https://api.avalara.com";
        /// <summary>
        /// Official URL of AvaTax (Dev)
        /// </summary>
        private static readonly string TRACK1099_SERVICE_DEV_URL = "https://api-ava1099.gamma.dev.us-west-2.aws.avalara.io";
        /// <summary>
        /// Official URL of AvaTax (QA)
        /// </summary>
        private static readonly string TRACK1099_SERVICE_QA_URL = "https://api-ava1099.edge.qa.us-east-1.aws.avalara.io";
        /// <summary>
        /// Official URL of AvaTax (Sandbox)
        /// </summary>
        private static readonly string TRACK1099_SERVICE_SBX_URL = "https://api.sbx.avalara.com/avalara1099";

        /// <summary>
        /// Official URL of AvaTax (Production)
        /// </summary>
        private static readonly string TRACK1099_SERVICE_PRD_URL = "https://api.avalara.com/avalara1099";
        /// <summary>
        /// Official OIDC disdcovery document URL of Sandbox Avalara identity Server 
        /// </summary>
        private static readonly string OPENID_CONNECT_URL_QA = "https://ai-awsfqa.avlr.sh/.well-known/openid-configuration";
        /// <summary>
        /// Official OIDC disdcovery document URL of Sandbox Avalara identity Server 
        /// </summary>
        private static readonly string OPENID_CONNECT_URL_SBX = "https://ai-sbx.avlr.sh/.well-known/openid-configuration";
        /// <summary>
        /// Official OIDC disdcovery document URL of Production Avalara identity Server 
        /// </summary>
        private static readonly string OPENID_CONNECT_URL_PRD = "https://identity.avalara.com/.well-known/openid-configuration";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;
            if (status == 0 || status >= 400)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.RawContent),
                    response.RawContent, response.Headers);
            }
            return null;
        };

        #endregion Static Members

        #region Private Members

        /// <summary>
        /// Defines the base path of the target API server.
        /// Example: http://localhost:3000/v1/
        /// </summary>
        private string _basePath;

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// This is the key and value comprising the "secret" for accessing an API.
        /// </summary>
        /// <value>The API key.</value>
        private IDictionary<string, string> _apiKey;

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        private IDictionary<string, string> _apiKeyPrefix;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();
        private string _tokenURL = default(string);
        private string _clientId = default(string);
        private readonly HttpClientHandler _httpClientHandler;
        private readonly HttpClient _httpClient;
        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration()
        {
            DefaultHeaders = new ConcurrentDictionary<string, string>();
            ApiKey = new ConcurrentDictionary<string, string>();
            ApiKeyPrefix = new ConcurrentDictionary<string, string>();

            _httpClientHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpClientHandler, true);

            // Setting Timeout has side effects (forces ApiClient creation).
            Timeout = 100000;
        }

        #endregion Constructors

        #region Properties
        /// <summary>
        /// GetBasePath used to get the base path based on the environment, region, and microservice
        /// </summary>
        public string GetBasePath(AvalaraMicroservice microservice)
        {
            switch (microservice)
            {
                case AvalaraMicroservice.EInvoicing:
                    return this.Environment switch
                    {
                        AvalaraEnvironment.Production => AVALARA_PRODUCTION_URL,
                        AvalaraEnvironment.QA => AVALARA_QA_URL,
                        AvalaraEnvironment.Sandbox => AVALARA_SANDBOX_URL,
                        AvalaraEnvironment.DEV => AVALARA_DEV_URL,
                        AvalaraEnvironment.Test => TestBasePath,
                        _ => throw new ApiException(500, "Invalid Environment"),
                    };
                case AvalaraMicroservice.A1099:
                    return this.Environment switch
                    {
                        AvalaraEnvironment.Production => TRACK1099_SERVICE_PRD_URL,
                        AvalaraEnvironment.QA => TRACK1099_SERVICE_QA_URL,
                        AvalaraEnvironment.Sandbox => TRACK1099_SERVICE_SBX_URL,
                        AvalaraEnvironment.DEV => TRACK1099_SERVICE_DEV_URL,
                        AvalaraEnvironment.Test => TestBasePath,
                        _ => throw new ApiException(500, "Invalid Environment"),
                    };
                default:
                    throw new ApiException(500, "Invalid Microservice");
            }
        }
        /// <summary>
        /// Base Path of the test environment.
        /// </summary>
        public string TestBasePath { set; get; }

        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public IDictionary<string, string> DefaultHeaders { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public int Timeout { get; set; }
        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the AvalaraEnvironment
        /// </summary>
        /// <value>AvalaraEnvironment(Enum)</value>
        public AvalaraEnvironment? Environment { get; set; }

        /// <summary>
        /// Gets the application name.
        /// </summary>
        /// <value>AppName.</value>
        public string AppName { get; set; }
        /// <summary>
        /// Gets the application version.
        /// </summary>
        /// <value>AppVersion.</value>
        public string AppVersion { get; set; }
        /// <summary>
        /// Gets the machine name.
        /// </summary>
        /// <value>MachineName.</value>
        public string MachineName { get; set; }
        /// <summary>
        /// Token Server URL for oAuth2 flow. Should be set only for Other Envrionment
        /// </summary>
        public string OpenIdConnectURL
        {
            get
            {
                switch (this.Environment)
                {
                    case AvalaraEnvironment.Production:
                        _tokenURL = OPENID_CONNECT_URL_PRD;
                        break;
                    case AvalaraEnvironment.Sandbox:
                        _tokenURL = OPENID_CONNECT_URL_SBX;
                        break;
                    case AvalaraEnvironment.QA:
                        _tokenURL = OPENID_CONNECT_URL_QA;
                        break;
                    default:
                        break;
                }
                return _tokenURL;
            }
        }

        /// <summary>
        /// Token URL for oAuth2 flow
        /// </summary>
        public string TokenURL { get; set; }

        /// <summary>
        /// Device Authorization URL for oAuth2 flow
        /// </summary>
        public string DeviceAuthorizationURL { get; set; }

        /// <summary>
        /// Token Server URL for Test system for oAuth2 flow
        /// </summary>
        public string TestTokenURL { set; get; }

        /// <summary>
        /// Device Authorization URL for Test system for oAuth2 flow
        /// </summary>
        public string TestDeviceAuthorizationURL { set; get; }
        /// <summary>
        /// ClientID for oAuth2 flow
        /// </summary>
        public string ClientID
        {
            get
            {
                return _clientId;
            }
            set
            {
                _clientId = value;
                PopulateTokenURLFromOpenIdConnect();
            }
        }
        /// <summary>
        /// ClientSecret for oAuth2 flow
        /// </summary>
        public string ClientSecret { get; set; }
        /// <summary>
        /// Bearer Token from Avalara Identity for oAuth2 flow
        /// </summary>
        public string BearerToken { get; set; }
        /// <summary>
        /// List of RequiredScopes
        /// </summary>
        public List<string> RequiredScopes { get; set; }
        /// <summary>
        /// Other Properties to be used for authentication
        /// </summary>
        public Dictionary<string, string> ParameterCollection { get; set; }
        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            string apiKeyValue;
            ApiKey.TryGetValue(apiKeyIdentifier, out apiKeyValue);
            string apiKeyPrefix;
            if (ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out apiKeyPrefix))
            {
                return apiKeyPrefix + " " + apiKeyValue;
            }

            return apiKeyValue;
        }

        /// <summary>
        /// Gets or sets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        public X509CertificateCollection ClientCertificates { get; set; }
        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        ///
        /// Whatever you set here will be prepended to the value defined in AddApiKey.
        ///
        /// An example invocation here might be:
        /// <example>
        /// ApiKeyPrefix["Authorization"] = "Bearer";
        /// </example>
        /// … where ApiKey["Authorization"] would then be used to set the value of your bearer token.
        ///
        /// <remarks>
        /// OAuth2 workflows should set tokens via AccessToken.
        /// </remarks>
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public virtual IDictionary<string, string> ApiKeyPrefix
        {
            get { return _apiKeyPrefix; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKeyPrefix collection may not be null.");
                }
                _apiKeyPrefix = value;
            }
        }

        /// <summary>
        /// Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public virtual IDictionary<string, string> ApiKey
        {
            get { return _apiKey; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("ApiKey collection may not be null.");
                }
                _apiKey = value;
            }
        }

        /// <summary>
        /// Populates the Token and Device Authorization endpoints from the OIDC Discovery document
        /// for the current environment selected.
        /// </summary>
        public void PopulateTokenURLFromOpenIdConnect()
        {
            if (this.ClientID != null)
            {
                if (this.Environment == AvalaraEnvironment.Test)
                {
                    this.TokenURL = this.TestTokenURL;
                    this.DeviceAuthorizationURL = this.DeviceAuthorizationURL;
                }
                else
                {
                    var oauthUrls = FetchTokenURLFromOpenIdConnect();
                    this.TokenURL = oauthUrls.TokenEndpoint;
                    this.DeviceAuthorizationURL = oauthUrls.DeviceAuthorizationEndpoint;
                }
            }
        }

        /// <summary>
        /// HttpClient instance to be used for all network requests.
        /// </summary>
        public HttpClient HttpClient
        {
            get { return _httpClient; }
        }

        /// <summary>
        /// HttpClient instance to be used for all network requests.
        /// </summary>
        public HttpClientHandler HttpClientHandler
        {
            get { return _httpClientHandler; }
        }

        private OpenIdConnectURLs FetchTokenURLFromOpenIdConnect()
        {
            var response = _httpClient.GetAsync(OpenIdConnectURL).GetAwaiter().GetResult();
            var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult(); // raw content as string 
            int statusCode = (int)response.StatusCode;
            if (statusCode > 199 && statusCode < 300)
            {
                OpenIdConnectURLs tokenObj = JsonConvert.DeserializeObject<OpenIdConnectURLs>(content);
                return tokenObj;
            }
            else
            {
                HttpClientError errorObj = JsonConvert.DeserializeObject<HttpClientError>(content);
                throw new Exception(errorObj.errorSummary);
            }
        }

        /// <summary>
        /// RefreshTokenDelegate to be executed when a 401/403 is returned, which returns a new bearer token, SDK will automatically set it.
        /// </summary>
        public RefreshTokenDelegate RefreshTokenDelegate { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Add Api Key Header.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        /// <returns></returns>
        public void AddApiKey(string key, string value)
        {
            ApiKey[key] = value;
        }

        /// <summary>
        /// Sets the API key prefix.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        public void AddApiKeyPrefix(string key, string value)
        {
            ApiKeyPrefix[key] = value;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        #endregion Methods

        #region Static Members
        /// <summary>
        /// Merge configurations.
        /// </summary>
        /// <param name="first">First configuration.</param>
        /// <param name="second">Second configuration.</param>
        /// <return>Merged configuration.</return>
        internal static IReadableConfiguration MergeConfigurations(IReadableConfiguration first, IReadableConfiguration second)
        {
            if (second == null) return first ?? GlobalConfiguration.Instance;

            Dictionary<string, string> apiKey = first.ApiKey.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> apiKeyPrefix = first.ApiKeyPrefix.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> defaultHeaders = first.DefaultHeaders.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in second.ApiKey) apiKey[kvp.Key] = kvp.Value;
            foreach (var kvp in second.ApiKeyPrefix) apiKeyPrefix[kvp.Key] = kvp.Value;
            foreach (var kvp in second.DefaultHeaders) defaultHeaders[kvp.Key] = kvp.Value;

            var config = new Configuration
            {
                ApiKey = apiKey,
                ApiKeyPrefix = apiKeyPrefix,
                DefaultHeaders = defaultHeaders,
                Timeout = second.Timeout,
                Username = second.Username ?? first.Username,
                Password = second.Password ?? first.Password,
                TestBasePath = second.TestBasePath ?? first.TestBasePath,
                TempFolderPath = second.TempFolderPath ?? first.TempFolderPath,
                DateTimeFormat = second.DateTimeFormat ?? first.DateTimeFormat,
                Environment = second.Environment ?? first.Environment,
                AppName = second.AppName ?? first.AppName,
                AppVersion = second.AppVersion ?? first.AppVersion,
                MachineName = second.MachineName ?? first.MachineName,
                TestTokenURL = second.TestTokenURL ?? first.TestTokenURL,
                ClientID = second.ClientID ?? first.ClientID,
                ClientSecret = second.ClientSecret ?? first.ClientSecret,
                BearerToken = second.BearerToken ?? first.BearerToken,
                RequiredScopes = second.RequiredScopes ?? first.RequiredScopes,
                RefreshTokenDelegate = second.RefreshTokenDelegate ?? first.RefreshTokenDelegate
            };
            return config;
        }
        #endregion Static Members
    }


}

