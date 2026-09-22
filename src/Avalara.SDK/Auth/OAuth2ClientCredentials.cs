using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Avalara.SDK.Client;
using Avalara.SDK.Model;
using Newtonsoft.Json;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// This class supports Client Crendetials OAuth2 grant type
    /// </summary>
    [Obsolete("Client-credentials authentication is not supported; API calls must set Configuration.BearerToken instead.")]
    public class OAuth2ClientCredentials : IOAuth
    {
        private const string GRANT_TYPE = "client_credentials";
        /// <summary>
        /// Constructor to initiate Client Crendetials OAuth2 flow
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="requiredScopes"></param>
        public OAuth2ClientCredentials(IReadableConfiguration configuration, string requiredScopes = default(string))
        {
            this.Configuration = configuration;
            this.TokenURL = configuration.TokenURL;
#pragma warning disable CS0618
            this.ClientID = configuration.ClientID;
            this.ClientSecret = configuration.ClientSecret;
#pragma warning restore CS0618
            this.RequiredScopes = requiredScopes;
            
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
        /// Other Properties to be used for authentication
        /// </summary>
        public Dictionary<string, string> ParameterCollection { get; set; }
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
                if (ClientSecret.IsNullorEmpty())
                {
                    throw new ArgumentException("Client Secret is not set in the configuration");
                }
                if (RequiredScopes.IsNullorEmpty())
                {
                    throw new ArgumentException("Scope cannot be empty");
                }

                var request = new HttpRequestMessage(HttpMethod.Post, TokenURL);
                var formParams = new Dictionary<string, string> { { "client_id", ClientID }, { "grant_type", GRANT_TYPE }, { "client_secret", ClientSecret }, { "scope", string.Join(" ", RequiredScopes) } };
                request.Content = new FormUrlEncodedContent(formParams);

                var response = Configuration.HttpClient.SendAsync(request).GetAwaiter().GetResult();
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                int statusCode = (int)response.StatusCode;
                if (statusCode>199  && statusCode < 300)
                {
                    Token tokenObj = JsonConvert.DeserializeObject<Token>(content);
                    return new TokenResponse()
                    {
                        AccessToken = tokenObj.access_token,
                        ExpiryTime = tokenObj.expires_in,
                        RefreshToken = tokenObj.refresh_token,
                        TokenType = tokenObj.token_type,
                        ExpiryDateTime = DateTime.Now.AddSeconds(tokenObj.expires_in)
                    };
                }
                else
                {
                    HttpClientError errorObj = JsonConvert.DeserializeObject<HttpClientError>(content);
                    throw new Exception(errorObj.errorSummary);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
