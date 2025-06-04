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
 * ## Authentication Use **username/password** or **generate a license** key from: Avalara Portal → Settings → License and API Keys  More info on authentication: [Avalara Authentication Methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  Validate your credentials here: [Test Credentials](https://developer.avalara.com/avatax/test-credentials/)  ## API & SDK Docs [Avalara (C#/.NET) SDK on GitHub](https://github.com/avadev/Avalara-SDK-DotNet/tree/main#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples for 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
using Avalara.SDK.Model.A1099.V2;

namespace Avalara.SDK.Api.A1099.V2
{
    /// <summary>
    /// Represents the Request object for the CreateW9Form API
    /// </summary>
    public class CreateW9FormRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public CreateW9FormRequest () {
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
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Form to be created
        /// </summary>
        public W9FormDataModelsOneOf W9FormDataModelsOneOf { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetW9Form API
    /// </summary>
    public class GetW9FormRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public GetW9FormRequest () {
        }
        /// <summary>
        /// Unique id of the form
        /// </summary>
        public string FormId { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetW9Forms API
    /// </summary>
    public class GetW9FormsRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public GetW9FormsRequest () {
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
        /// A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.  Filterable: referenceId, companyId, archived, ancestorId 
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records.
        /// </summary>
        public int? Top { get; set; }
        /// <summary>
        /// If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets.
        /// </summary>
        public int? Skip { get; set; }
        /// <summary>
        /// A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC.
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// Set true to request count of complete collection in response.
        /// </summary>
        public bool? Count { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the W9FormRequestsFormRequestIdGet API
    /// </summary>
    public class W9FormRequestsFormRequestIdGetRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public W9FormRequestsFormRequestIdGetRequest () {
        }
        /// <summary>
        /// Id assigned during creation of the form request
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
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IW4W8W9FormsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new W9/W8/W4 form
        /// </summary>
        /// <remarks>
        /// Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>W9FormDataModelsOneOf</returns>
        W9FormDataModelsOneOf CreateW9Form(CreateW9FormRequest requestParameters);

        /// <summary>
        /// Retrieve a W9/W8/W4 form
        /// </summary>
        /// <remarks>
        /// Retreive a single W9/W8/W4 form by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>GetW9Form200Response</returns>
        GetW9Form200Response GetW9Form(GetW9FormRequest requestParameters);

        /// <summary>
        /// List W9/W4/W8 forms.
        /// </summary>
        /// <remarks>
        /// List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>PaginatedW9FormsModel</returns>
        PaginatedW9FormsModel GetW9Forms(GetW9FormsRequest requestParameters);

        /// <summary>
        /// Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;.
        /// </summary>
        /// <remarks>
        /// Retrieve a form request again after creation. Previously-valid form requests will be Not Found after &#x60;expiresAt&#x60;
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormRequestModel</returns>
        FormRequestModel W9FormRequestsFormRequestIdGet(W9FormRequestsFormRequestIdGetRequest requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IW4W8W9FormsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new W9/W8/W4 form
        /// </summary>
        /// <remarks>
        /// Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of W9FormDataModelsOneOf</returns>
        System.Threading.Tasks.Task<W9FormDataModelsOneOf> CreateW9FormAsync(CreateW9FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a W9/W8/W4 form
        /// </summary>
        /// <remarks>
        /// Retreive a single W9/W8/W4 form by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetW9Form200Response</returns>
        System.Threading.Tasks.Task<GetW9Form200Response> GetW9FormAsync(GetW9FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List W9/W4/W8 forms.
        /// </summary>
        /// <remarks>
        /// List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedW9FormsModel</returns>
        System.Threading.Tasks.Task<PaginatedW9FormsModel> GetW9FormsAsync(GetW9FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;.
        /// </summary>
        /// <remarks>
        /// Retrieve a form request again after creation. Previously-valid form requests will be Not Found after &#x60;expiresAt&#x60;
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormRequestModel</returns>
        System.Threading.Tasks.Task<FormRequestModel> W9FormRequestsFormRequestIdGetAsync(W9FormRequestsFormRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class W4W8W9FormsApi : IW4W8W9FormsApiSync, IW4W8W9FormsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="W4W8W9FormsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public W4W8W9FormsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Create a new W9/W8/W4 form Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>W9FormDataModelsOneOf</returns>
        public W9FormDataModelsOneOf CreateW9Form(CreateW9FormRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<W9FormDataModelsOneOf> localVarResponse = CreateW9FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new W9/W8/W4 form Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of W9FormDataModelsOneOf</returns>
        private Avalara.SDK.Client.ApiResponse<W9FormDataModelsOneOf> CreateW9FormWithHttpInfo(CreateW9FormRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->CreateW9Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->CreateW9Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.W9FormDataModelsOneOf;

            // make the HTTP request
            var localVarResponse = this.Client.Post<W9FormDataModelsOneOf>("/w9/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateW9Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new W9/W8/W4 form Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of W9FormDataModelsOneOf</returns>
        public async System.Threading.Tasks.Task<W9FormDataModelsOneOf> CreateW9FormAsync(CreateW9FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<W9FormDataModelsOneOf> localVarResponse = await CreateW9FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new W9/W8/W4 form Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (W9FormDataModelsOneOf)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<W9FormDataModelsOneOf>> CreateW9FormWithHttpInfoAsync(CreateW9FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->CreateW9Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->CreateW9Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.W9FormDataModelsOneOf;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<W9FormDataModelsOneOf>("/w9/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateW9Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a W9/W8/W4 form Retreive a single W9/W8/W4 form by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>GetW9Form200Response</returns>
        public GetW9Form200Response GetW9Form(GetW9FormRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<GetW9Form200Response> localVarResponse = GetW9FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a W9/W8/W4 form Retreive a single W9/W8/W4 form by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of GetW9Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<GetW9Form200Response> GetW9FormWithHttpInfo(GetW9FormRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'FormId' is set
            if (requestParameters.FormId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormId' when calling W4W8W9FormsApi->GetW9Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->GetW9Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->GetW9Form");

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

            localVarRequestOptions.PathParameters.Add("formId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.FormId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetW9Form200Response>("/w9/forms/{formId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetW9Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a W9/W8/W4 form Retreive a single W9/W8/W4 form by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetW9Form200Response</returns>
        public async System.Threading.Tasks.Task<GetW9Form200Response> GetW9FormAsync(GetW9FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<GetW9Form200Response> localVarResponse = await GetW9FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a W9/W8/W4 form Retreive a single W9/W8/W4 form by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetW9Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<GetW9Form200Response>> GetW9FormWithHttpInfoAsync(GetW9FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.FormId' is set
            if (requestParameters.FormId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormId' when calling W4W8W9FormsApi->GetW9Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->GetW9Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->GetW9Form");


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

            localVarRequestOptions.PathParameters.Add("formId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.FormId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<GetW9Form200Response>("/w9/forms/{formId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetW9Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List W9/W4/W8 forms. List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>PaginatedW9FormsModel</returns>
        public PaginatedW9FormsModel GetW9Forms(GetW9FormsRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<PaginatedW9FormsModel> localVarResponse = GetW9FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List W9/W4/W8 forms. List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of PaginatedW9FormsModel</returns>
        private Avalara.SDK.Client.ApiResponse<PaginatedW9FormsModel> GetW9FormsWithHttpInfo(GetW9FormsRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->GetW9Forms");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->GetW9Forms");

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

            if (requestParameters.Filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", requestParameters.Filter));
            }
            if (requestParameters.Top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", requestParameters.Top));
            }
            if (requestParameters.Skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", requestParameters.Skip));
            }
            if (requestParameters.OrderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", requestParameters.OrderBy));
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.HeaderParameters.Add("count", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Count)); // header parameter
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaginatedW9FormsModel>("/w9/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetW9Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List W9/W4/W8 forms. List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedW9FormsModel</returns>
        public async System.Threading.Tasks.Task<PaginatedW9FormsModel> GetW9FormsAsync(GetW9FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<PaginatedW9FormsModel> localVarResponse = await GetW9FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List W9/W4/W8 forms. List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedW9FormsModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<PaginatedW9FormsModel>> GetW9FormsWithHttpInfoAsync(GetW9FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->GetW9Forms");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->GetW9Forms");


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

            if (requestParameters.Filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", requestParameters.Filter));
            }
            if (requestParameters.Top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", requestParameters.Top));
            }
            if (requestParameters.Skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", requestParameters.Skip));
            }
            if (requestParameters.OrderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", requestParameters.OrderBy));
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.HeaderParameters.Add("count", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Count)); // header parameter
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<PaginatedW9FormsModel>("/w9/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetW9Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;. Retrieve a form request again after creation. Previously-valid form requests will be Not Found after &#x60;expiresAt&#x60;
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormRequestModel</returns>
        public FormRequestModel W9FormRequestsFormRequestIdGet(W9FormRequestsFormRequestIdGetRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FormRequestModel> localVarResponse = W9FormRequestsFormRequestIdGetWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;. Retrieve a form request again after creation. Previously-valid form requests will be Not Found after &#x60;expiresAt&#x60;
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FormRequestModel</returns>
        private Avalara.SDK.Client.ApiResponse<FormRequestModel> W9FormRequestsFormRequestIdGetWithHttpInfo(W9FormRequestsFormRequestIdGetRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'FormRequestId' is set
            if (requestParameters.FormRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormRequestId' when calling W4W8W9FormsApi->W9FormRequestsFormRequestIdGet");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->W9FormRequestsFormRequestIdGet");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->W9FormRequestsFormRequestIdGet");

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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<FormRequestModel>("/w9/form-requests/{formRequestId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("W9FormRequestsFormRequestIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;. Retrieve a form request again after creation. Previously-valid form requests will be Not Found after &#x60;expiresAt&#x60;
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormRequestModel</returns>
        public async System.Threading.Tasks.Task<FormRequestModel> W9FormRequestsFormRequestIdGetAsync(W9FormRequestsFormRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FormRequestModel> localVarResponse = await W9FormRequestsFormRequestIdGetWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;. Retrieve a form request again after creation. Previously-valid form requests will be Not Found after &#x60;expiresAt&#x60;
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FormRequestModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FormRequestModel>> W9FormRequestsFormRequestIdGetWithHttpInfoAsync(W9FormRequestsFormRequestIdGetRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.FormRequestId' is set
            if (requestParameters.FormRequestId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormRequestId' when calling W4W8W9FormsApi->W9FormRequestsFormRequestIdGet");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling W4W8W9FormsApi->W9FormRequestsFormRequestIdGet");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling W4W8W9FormsApi->W9FormRequestsFormRequestIdGet");


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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<FormRequestModel>("/w9/form-requests/{formRequestId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("W9FormRequestsFormRequestIdGet", localVarResponse);
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
            this.Client.SdkVersion = "25.5.4";
        }
        
    }

    
}
