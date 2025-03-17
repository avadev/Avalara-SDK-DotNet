/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 API Definition
 *
 * This is the API specification for Avalara's Track 1099 service, based on the OpenAPI 3.0 standard. The API allows users to manage and track 1099 tax forms efficiently. This is the specification for the Avalara 1099 & W9 API. Some overall notes about the API:  - The API generally follows the [JSON:API](https://jsonapi.org/) specification. - Authentication is done by including an API **Bearer** token in the **Authorization** header (API tokens can be generated from your [profile page](https://www.track1099.com/api_tokens) when logged into the application). - The maximum request size allowed is **100MB**.  [Find out more about Avalara](https://www.avalara.com)
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Avalara.SDK.Api.Track1099.V2
{
    /// <summary>
    /// Represents the Request object for the AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet API
    /// </summary>
    public class AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest () {
        }
        /// <summary>
        /// 
        /// </summary>
        public string AuthorizedApiRequestId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string R { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the AuthorizedApiRequestsAuthorizedApiRequestIdGet API
    /// </summary>
    public class AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest () {
        }
        /// <summary>
        /// 
        /// </summary>
        public string AuthorizedApiRequestId { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the AuthorizedApiRequestsPost API
    /// </summary>
    public class AuthorizedApiRequestsPostRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public AuthorizedApiRequestsPostRequest () {
        }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AuthorizedApiRequestModel AuthorizedApiRequestModel { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizedAPIRequestsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Execute URL for downloads
        /// </summary>
        /// <remarks>
        /// Execute the URL you created
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet(AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters);

        /// <summary>
        /// Retrieve URL for downloads
        /// </summary>
        /// <remarks>
        /// Retrieve the URL you created
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>AuthorizedApiRequestV2DataModel</returns>
        AuthorizedApiRequestV2DataModel AuthorizedApiRequestsAuthorizedApiRequestIdGet(AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters);

        /// <summary>
        /// Create URL for downloads
        /// </summary>
        /// <remarks>
        /// Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>AuthorizedApiRequestV2DataModel</returns>
        AuthorizedApiRequestV2DataModel AuthorizedApiRequestsPost(AuthorizedApiRequestsPostRequest requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizedAPIRequestsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Execute URL for downloads
        /// </summary>
        /// <remarks>
        /// Execute the URL you created
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetAsync(AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve URL for downloads
        /// </summary>
        /// <remarks>
        /// Retrieve the URL you created
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorizedApiRequestV2DataModel</returns>
        System.Threading.Tasks.Task<AuthorizedApiRequestV2DataModel> AuthorizedApiRequestsAuthorizedApiRequestIdGetAsync(AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create URL for downloads
        /// </summary>
        /// <remarks>
        /// Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorizedApiRequestV2DataModel</returns>
        System.Threading.Tasks.Task<AuthorizedApiRequestV2DataModel> AuthorizedApiRequestsPostAsync(AuthorizedApiRequestsPostRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizedAPIRequestsApi : IAuthorizedAPIRequestsApiSync, IAuthorizedAPIRequestsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedAPIRequestsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public AuthorizedAPIRequestsApi(Avalara.SDK.Client.IApiClient client)
        {
             SetConfiguration(client);
             this.ExceptionFactory = Avalara.SDK.Client.Configuration.DefaultExceptionFactory;
        }       

        /// <summary>
        /// The client for accessing this underlying API.
        /// </summary>
        private Avalara.SDK.Client.IInternalApiClient Client { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        private Avalara.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Execute URL for downloads Execute the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet(AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters)
        {
            AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Execute URL for downloads Execute the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetWithHttpInfo(AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AuthorizedApiRequestId' is set
            if (requestParameters.AuthorizedApiRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AuthorizedApiRequestId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            // verify the required parameter 'R' is set
            if (requestParameters.R == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.R' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("authorizedApiRequestId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AuthorizedApiRequestId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "r", requestParameters.R));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/authorized-api-requests/{authorizedApiRequestId}/$execute", localVarRequestOptions, requiredScopes, AvalaraMicroservice.Track1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Execute URL for downloads Execute the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetAsync(AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Execute URL for downloads Execute the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetWithHttpInfoAsync(AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AuthorizedApiRequestId' is set
            if (requestParameters.AuthorizedApiRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AuthorizedApiRequestId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            // verify the required parameter 'requestParameters.R' is set
            if (requestParameters.R == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.R' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("authorizedApiRequestId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AuthorizedApiRequestId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "r", requestParameters.R));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Object>("/authorized-api-requests/{authorizedApiRequestId}/$execute", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.Track1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve URL for downloads Retrieve the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>AuthorizedApiRequestV2DataModel</returns>
        public AuthorizedApiRequestV2DataModel AuthorizedApiRequestsAuthorizedApiRequestIdGet(AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel> localVarResponse = AuthorizedApiRequestsAuthorizedApiRequestIdGetWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve URL for downloads Retrieve the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of AuthorizedApiRequestV2DataModel</returns>
        private Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel> AuthorizedApiRequestsAuthorizedApiRequestIdGetWithHttpInfo(AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AuthorizedApiRequestId' is set
            if (requestParameters.AuthorizedApiRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AuthorizedApiRequestId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdGet");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdGet");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdGet");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("authorizedApiRequestId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AuthorizedApiRequestId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
            var localVarResponse = this.Client.Get<AuthorizedApiRequestV2DataModel>("/authorized-api-requests/{authorizedApiRequestId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.Track1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthorizedApiRequestsAuthorizedApiRequestIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve URL for downloads Retrieve the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorizedApiRequestV2DataModel</returns>
        public async System.Threading.Tasks.Task<AuthorizedApiRequestV2DataModel> AuthorizedApiRequestsAuthorizedApiRequestIdGetAsync(AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel> localVarResponse = await AuthorizedApiRequestsAuthorizedApiRequestIdGetWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve URL for downloads Retrieve the URL you created
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthorizedApiRequestV2DataModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel>> AuthorizedApiRequestsAuthorizedApiRequestIdGetWithHttpInfoAsync(AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AuthorizedApiRequestId' is set
            if (requestParameters.AuthorizedApiRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AuthorizedApiRequestId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdGet");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdGet");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsAuthorizedApiRequestIdGet");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("authorizedApiRequestId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AuthorizedApiRequestId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<AuthorizedApiRequestV2DataModel>("/authorized-api-requests/{authorizedApiRequestId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.Track1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthorizedApiRequestsAuthorizedApiRequestIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create URL for downloads Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>AuthorizedApiRequestV2DataModel</returns>
        public AuthorizedApiRequestV2DataModel AuthorizedApiRequestsPost(AuthorizedApiRequestsPostRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel> localVarResponse = AuthorizedApiRequestsPostWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create URL for downloads Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of AuthorizedApiRequestV2DataModel</returns>
        private Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel> AuthorizedApiRequestsPostWithHttpInfo(AuthorizedApiRequestsPostRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsPost");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsPost");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.AuthorizedApiRequestModel;

            // make the HTTP request
            var localVarResponse = this.Client.Post<AuthorizedApiRequestV2DataModel>("/authorized-api-requests", localVarRequestOptions, requiredScopes, AvalaraMicroservice.Track1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthorizedApiRequestsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create URL for downloads Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorizedApiRequestV2DataModel</returns>
        public async System.Threading.Tasks.Task<AuthorizedApiRequestV2DataModel> AuthorizedApiRequestsPostAsync(AuthorizedApiRequestsPostRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel> localVarResponse = await AuthorizedApiRequestsPostWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create URL for downloads Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthorizedApiRequestV2DataModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<AuthorizedApiRequestV2DataModel>> AuthorizedApiRequestsPostWithHttpInfoAsync(AuthorizedApiRequestsPostRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsPost");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling AuthorizedAPIRequestsApi->AuthorizedApiRequestsPost");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.AuthorizedApiRequestModel;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<AuthorizedApiRequestV2DataModel>("/authorized-api-requests", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.Track1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthorizedApiRequestsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the configuration object in APIClient
        /// </summary>        
        private void SetConfiguration(IApiClient client)
        {
            if (client == null) throw new ArgumentNullException("ApiClient");
            if (client.Configuration == null) throw new ArgumentNullException("ApiClient.Configuration");

            this.Client = (IInternalApiClient)client;
            this.Client.SdkVersion = "25.3.0";
        }
        
    }

    
}
