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
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        IDictionary<string, string> ApiKey { get; }

        /// <summary>
        /// Gets the API key prefix.
        /// </summary>
        /// <value>API key prefix.</value>
        IDictionary<string, string> ApiKeyPrefix { get; }

       /// <summary>
        /// GetBasePath used to get the base path based on the environment, region, and microservice
        /// </summary>
        string GetBasePath(AvalaraMicroservice microservice = AvalaraMicroservice.None);
        /// <summary>
        /// Base Path of the test environment.
        /// </summary>
        string TestBasePath { set; get; }
        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time format.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default headers.
        /// </summary>
        /// <value>Default headers.</value>
        IDictionary<string, string> DefaultHeaders { get; }

        /// <summary>
        /// Gets the temp folder path.
        /// </summary>
        /// <value>Temp folder path.</value>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>Username.</value>
        string Username { set; get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>Password.</value>
        string Password { set; get; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);

        /// <summary>
        /// Gets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        X509CertificateCollection ClientCertificates { get; }
        /// <summary>
        /// Gets or sets the AvalaraEnvironment
        /// </summary>
        /// <value>AvalaraEnvironment(Enum)</value>
        AvalaraEnvironment? Environment { get; }

        /// <summary>
        /// Gets the application name.
        /// </summary>
        /// <value>AppName.</value>
        string AppName { get; }

        /// <summary>
        /// Gets the application version.
        /// </summary>
        /// <value>AppVersion.</value>
        string AppVersion { get; }
        /// <summary>
        /// Gets the machine name.
        /// </summary>
        /// <value>MachineName.</value>
        string MachineName { get; }

        /// <summary>
        /// Token Server URL for oAuth2 flow
        /// </summary>
        string TokenURL { get; set; }

        /// <summary>
        /// Device Authorization URL for oAuth2 flow
        /// </summary>
        string DeviceAuthorizationURL { get; set; }

        /// <summary>
        /// Open ID Connect URL
        /// </summary>
        string OpenIdConnectURL { get; }
        /// <summary>
        /// Token Server URL for Test system for oAuth2 flow
        /// </summary>
        string TestTokenURL { set; get; }
        /// <summary>
        /// Device Authorization URL for Test system for oAuth2 flow
        /// </summary>
        string TestDeviceAuthorizationURL { set; get; }
        /// <summary>
        /// ClientID for oAuth2 flow
        /// </summary>
        [Obsolete("Client-credentials authentication is not supported; API calls must set Configuration.BearerToken instead. ClientID is retained only for the device-code flow via Avalara.SDK.Auth.OAuthHelper.")]
        string ClientID { get; set; }
        /// <summary>
        /// ClientSecret for oAuth2 flow
        /// </summary>
        [Obsolete("Client-credentials authentication is not supported; API calls must set Configuration.BearerToken instead.")]
        string ClientSecret { get; set; }
        /// <summary>
        /// Bearer Token from Avalara Identity for oAuth2 flow
        /// </summary>
        string BearerToken { get; set; }
        /// <summary>
        /// List of Scopes
        /// </summary>
        List<string> RequiredScopes { get; set; }
        /// <summary>
        /// The Instance of HttpClient
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        /// The Instance of HttpClient
        /// </summary>
        HttpClientHandler HttpClientHandler { get; }

        /// <summary>
        /// Delegate used to refresh the token when a 401 or 403 Response comes from an API call.
        /// </summary>
        RefreshTokenDelegate RefreshTokenDelegate { get; set; }
    }
}
