using System;
using System.Collections.Generic;
using System.Net.Http;
using Avalara.SDK.Client;
using Avalara.SDK.Model;
using Newtonsoft.Json;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// This class supports Client Crendetials OAuth2 grant type
    /// </summary>
    public class OAuth2DeviceCode : IOAuth
    {
        private const string GRANT_TYPE = "urn:ietf:params:oauth:grant-type:device_code";
        /// <summary>
        /// Constructor to initiate Client Crendetials OAuth2 flow
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="requiredScopes"></param>
        /// <param name="deviceAuthorizationCode"></param>
        public OAuth2DeviceCode(IReadableConfiguration configuration,
            string requiredScopes = default(string), string deviceAuthorizationCode = default(string))
        {
            this.Configuration = configuration;
            this.DeviceAuthorizationURL = configuration.DeviceAuthorizationURL;
            this.TokenURL = configuration.TokenURL;
#pragma warning disable CS0618 // device-code flow legitimately uses ClientID
            this.ClientID = configuration.ClientID;
#pragma warning restore CS0618
            this.RequiredScopes = requiredScopes;
            this.DeviceAuthorizationCode = deviceAuthorizationCode;
        }

        /// <summary>
        /// Configuration object used for HttpClient
        /// </summary>
        public IReadableConfiguration Configuration { get; set; }
        /// <summary>
        /// Authorization Server URL for oAuth2 flow
        /// </summary>
        public string AuthorizationURL { get; set; }
        /// <summary>
        /// Token Server URL for oAuth2 flow
        /// </summary>
        public string DeviceAuthorizationURL { get; set; }
        /// <summary>
        /// Token Server URL for oAuth2 flow
        /// </summary>
        public string TokenURL { get; set; }
        /// <summary>
        /// ClientID for oAuth2 flow
        /// </summary>
        public string ClientID { get; set; }
        /// <summary>
        /// ClientSecret for oAuth2 flow
        /// </summary>
        public string ClientSecret { get; set; }
        /// <summary>
        /// List of RequiredScopes
        /// </summary>
        public string RequiredScopes { get; set; }
        /// <summary>
        /// Device Authorization Code returned in the first step of the Device Code Flow.
        /// </summary>
        public string DeviceAuthorizationCode { get; set; }
        /// <summary>
        /// Other Properties to be used for authentication
        /// </summary>
        public Dictionary<string, string> ParameterCollection { get; set; }

        /// <summary>
        /// Method Return the access token
        /// </summary>
        public DeviceAuthorizationResponse GetDeviceAuthorizationCode()
        {
            try
            {
                if (ClientID.IsNullorEmpty())
                {
                    throw new ArgumentException("Client ID is not set in the configuration");
                }
                if (DeviceAuthorizationURL.IsNullorEmpty())
                {
                    throw new ArgumentException("Device Authorization URL is not set in the configuration");
                }
                if (RequiredScopes.IsNullorEmpty())
                {
                    throw new ArgumentException("Scope cannot be empty");
                }

                var request = new HttpRequestMessage(HttpMethod.Post, DeviceAuthorizationURL);
                var formParams = new Dictionary<string, string> { { "client_id", ClientID }, { "scope", string.Join(" ", RequiredScopes) } };
                request.Content = new FormUrlEncodedContent(formParams);

                var response = Configuration.HttpClient.SendAsync(request).GetAwaiter().GetResult();
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                int statusCode = (int)response.StatusCode;
                if (statusCode > 199 && statusCode < 300)
                {
                    DeviceAuthorization deviceAuthorization = JsonConvert.DeserializeObject<DeviceAuthorization>(content);
                    return new DeviceAuthorizationResponse(){ 
                        DeviceCode = deviceAuthorization.device_code,
                        UserCode = deviceAuthorization.user_code,
                        Expiry = deviceAuthorization.expires_in,
                        Interval = deviceAuthorization.interval,
                        VerificationUrl = deviceAuthorization.verification_uri,
                        VerificationUrlComplete = deviceAuthorization.verification_uri_complete
                    };
                }
                else
                {
                    HttpClientError errorObj = JsonConvert.DeserializeObject<HttpClientError>(content);
                    throw new Exception(errorObj.errorSummary);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method Return the access token
        /// </summary>
        public TokenResponse GetAccessToken()
        {
            try
            {
                if (TokenURL.IsNullorEmpty())
                {
                    throw new ArgumentException("Token URL is not set in the configuration");
                }
                if (ClientID.IsNullorEmpty())
                {
                    throw new ArgumentException("Client ID is not set in the configuration");
                }
                if (DeviceAuthorizationCode.IsNullorEmpty())
                {
                    throw new ArgumentException("DeviceAuthorizationCode must be passed in as a parameter.");
                }

                var request = new HttpRequestMessage(HttpMethod.Post, TokenURL);
                var formParams = new Dictionary<string, string> { { "client_id", ClientID }, { "grant_type", GRANT_TYPE }, { "device_code", DeviceAuthorizationCode } };
                request.Content = new FormUrlEncodedContent(formParams);

                var response = Configuration.HttpClient.SendAsync(request).GetAwaiter().GetResult();
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                int statusCode = (int)response.StatusCode;
                if (statusCode > 199 && statusCode < 300)
                {
                    Token tokenObj = JsonConvert.DeserializeObject<Token>(content);
                    return new TokenResponse()
                    {
                        AccessToken = tokenObj.access_token,
                        ExpiryTime = tokenObj.expires_in,
                        RefreshToken = tokenObj.refresh_token,
                        TokenType = tokenObj.token_type,
                        HttpStatusCode = (int)response.StatusCode,
                        IdToken = tokenObj.id_token
                    };
                }
                else
                {
                    IdentityError errorObj = JsonConvert.DeserializeObject<IdentityError>(content);
                    return new TokenResponse()
                    {
                        ErrorMessage = errorObj.Error,
                        HttpStatusCode = (int)response.StatusCode
                    };
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}