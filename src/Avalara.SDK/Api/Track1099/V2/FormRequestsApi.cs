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
    /// Represents the Request object for the FormRequestsFormRequestIdGet API
    /// </summary>
    public class FormRequestsFormRequestIdGetRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public FormRequestsFormRequestIdGetRequest () {
        }
        /// <summary>
        /// 
        /// </summary>
        public string FormRequestId { get; set; }
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
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFormRequestsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Get form request
        /// </summary>
        /// <remarks>
        /// Create a W-9, W-8BEN or W-8BEN-E form request for the given &#x60;company_id&#x60; (ID of a company in the W-9 section of the Track1099 app) and your internal &#x60;reference_id&#x60; for the vendor. &#x60;reference_id&#x60; is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormRequestModel</returns>
        FormRequestModel FormRequestsFormRequestIdGet(FormRequestsFormRequestIdGetRequest requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFormRequestsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get form request
        /// </summary>
        /// <remarks>
        /// Create a W-9, W-8BEN or W-8BEN-E form request for the given &#x60;company_id&#x60; (ID of a company in the W-9 section of the Track1099 app) and your internal &#x60;reference_id&#x60; for the vendor. &#x60;reference_id&#x60; is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormRequestModel</returns>
        System.Threading.Tasks.Task<FormRequestModel> FormRequestsFormRequestIdGetAsync(FormRequestsFormRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FormRequestsApi : IFormRequestsApiSync, IFormRequestsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRequestsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public FormRequestsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Get form request Create a W-9, W-8BEN or W-8BEN-E form request for the given &#x60;company_id&#x60; (ID of a company in the W-9 section of the Track1099 app) and your internal &#x60;reference_id&#x60; for the vendor. &#x60;reference_id&#x60; is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormRequestModel</returns>
        public FormRequestModel FormRequestsFormRequestIdGet(FormRequestsFormRequestIdGetRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FormRequestModel> localVarResponse = FormRequestsFormRequestIdGetWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form request Create a W-9, W-8BEN or W-8BEN-E form request for the given &#x60;company_id&#x60; (ID of a company in the W-9 section of the Track1099 app) and your internal &#x60;reference_id&#x60; for the vendor. &#x60;reference_id&#x60; is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FormRequestModel</returns>
        private Avalara.SDK.Client.ApiResponse<FormRequestModel> FormRequestsFormRequestIdGetWithHttpInfo(FormRequestsFormRequestIdGetRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'FormRequestId' is set
            if (requestParameters.FormRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormRequestId' when calling FormRequestsApi->FormRequestsFormRequestIdGet");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling FormRequestsApi->FormRequestsFormRequestIdGet");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling FormRequestsApi->FormRequestsFormRequestIdGet");

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

            localVarRequestOptions.PathParameters.Add("formRequestId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.FormRequestId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
            var localVarResponse = this.Client.Get<FormRequestModel>("/form-requests/{formRequestId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.Track1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FormRequestsFormRequestIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form request Create a W-9, W-8BEN or W-8BEN-E form request for the given &#x60;company_id&#x60; (ID of a company in the W-9 section of the Track1099 app) and your internal &#x60;reference_id&#x60; for the vendor. &#x60;reference_id&#x60; is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormRequestModel</returns>
        public async System.Threading.Tasks.Task<FormRequestModel> FormRequestsFormRequestIdGetAsync(FormRequestsFormRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FormRequestModel> localVarResponse = await FormRequestsFormRequestIdGetWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form request Create a W-9, W-8BEN or W-8BEN-E form request for the given &#x60;company_id&#x60; (ID of a company in the W-9 section of the Track1099 app) and your internal &#x60;reference_id&#x60; for the vendor. &#x60;reference_id&#x60; is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FormRequestModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FormRequestModel>> FormRequestsFormRequestIdGetWithHttpInfoAsync(FormRequestsFormRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.FormRequestId' is set
            if (requestParameters.FormRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormRequestId' when calling FormRequestsApi->FormRequestsFormRequestIdGet");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling FormRequestsApi->FormRequestsFormRequestIdGet");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling FormRequestsApi->FormRequestsFormRequestIdGet");


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

            localVarRequestOptions.PathParameters.Add("formRequestId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.FormRequestId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<FormRequestModel>("/form-requests/{formRequestId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.Track1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FormRequestsFormRequestIdGet", localVarResponse);
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
