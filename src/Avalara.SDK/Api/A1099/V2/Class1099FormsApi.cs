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
    /// Represents the Request object for the BulkUpsert1099Forms API
    /// </summary>
    public class BulkUpsert1099FormsRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public BulkUpsert1099FormsRequest () {
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
        /// A request payload containing the details of the 1099 form to upsert.
        /// </summary>
        public BulkUpsert1099FormsRequest BulkUpsert1099FormsRequest { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Call1099FormsPost API
    /// </summary>
    public class Call1099FormsPostRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public Call1099FormsPostRequest () {
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
        /// A request payload containing the details of the 1099 form to create.
        /// </summary>
        public Form1099OneOf Form1099OneOf { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Delete1099Form API
    /// </summary>
    public class Delete1099FormRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public Delete1099FormRequest () {
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
        /// The unique identifier of the form to delete.
        /// </summary>
        public string FormId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Download1099FormPDF API
    /// </summary>
    public class Download1099FormPDFRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public Download1099FormPDFRequest () {
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
        /// A request payload containing parameters to filter forms.
        /// </summary>
        public InitiateDownloadInputModel InitiateDownloadInputModel { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Get1099Form API
    /// </summary>
    public class Get1099FormRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public Get1099FormRequest () {
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
        /// The unique identifier of the form to retrieve.
        /// </summary>
        public string FormId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the List1099Forms API
    /// </summary>
    public class List1099FormsRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public List1099FormsRequest () {
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
        /// A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.  Filterable: issuerReferenceId, taxYear, federalEfile, federalEfileStatus, postalMail, postalMailStatus, stateEfile, stateEfileStatus, tinMatch, tinMatchStatus, addressVerification, addressVerificationStatus, referenceId, city, state, zip 
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
    }

    /// <summary>
    /// Represents the Request object for the Update1099Form API
    /// </summary>
    public class Update1099FormRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public Update1099FormRequest () {
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
        /// A request payload containing the updated details of the 1099 form.
        /// </summary>
        public Form1099OneOf Form1099OneOf { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/).
        /// </summary>
        public string XAvalaraClient { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass1099FormsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create/Update 1099 forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>JobModel</returns>
        JobModel BulkUpsert1099Forms(BulkUpsert1099FormsRequest requestParameters);

        /// <summary>
        /// Create a new 1099 form
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to create a new 1099 form. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099OneOf</returns>
        Form1099OneOf Call1099FormsPost(Call1099FormsPostRequest requestParameters);

        /// <summary>
        /// Delete a 1099 form
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a &#x60;204 No Content&#x60; status. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void Delete1099Form(Delete1099FormRequest requestParameters);

        /// <summary>
        /// Submit a download job to retrieve PDF forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the &#x60;GET /jobs/{jobId}&#x60; endpoint. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>InititateDownloadOutputModel</returns>
        InititateDownloadOutputModel Download1099FormPDF(Download1099FormPDFRequest requestParameters);

        /// <summary>
        /// Get a single 1099 form
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099OneOf</returns>
        Form1099OneOf Get1099Form(Get1099FormRequest requestParameters);

        /// <summary>
        /// List 1099 forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>List1099Forms200Response</returns>
        List1099Forms200Response List1099Forms(List1099FormsRequest requestParameters);

        /// <summary>
        /// Update an existing form.
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099OneOf</returns>
        Form1099OneOf Update1099Form(Update1099FormRequest requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass1099FormsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create/Update 1099 forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JobModel</returns>
        System.Threading.Tasks.Task<JobModel> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a new 1099 form
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to create a new 1099 form. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099OneOf</returns>
        System.Threading.Tasks.Task<Form1099OneOf> Call1099FormsPostAsync(Call1099FormsPostRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a 1099 form
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a &#x60;204 No Content&#x60; status. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Submit a download job to retrieve PDF forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the &#x60;GET /jobs/{jobId}&#x60; endpoint. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InititateDownloadOutputModel</returns>
        System.Threading.Tasks.Task<InititateDownloadOutputModel> Download1099FormPDFAsync(Download1099FormPDFRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a single 1099 form
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099OneOf</returns>
        System.Threading.Tasks.Task<Form1099OneOf> Get1099FormAsync(Get1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List 1099 forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List1099Forms200Response</returns>
        System.Threading.Tasks.Task<List1099Forms200Response> List1099FormsAsync(List1099FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update an existing form.
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099OneOf</returns>
        System.Threading.Tasks.Task<Form1099OneOf> Update1099FormAsync(Update1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Class1099FormsApi : IClass1099FormsApiSync, IClass1099FormsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1099FormsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public Class1099FormsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Create/Update 1099 forms This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>JobModel</returns>
        public JobModel BulkUpsert1099Forms(BulkUpsert1099FormsRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<JobModel> localVarResponse = BulkUpsert1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create/Update 1099 forms This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of JobModel</returns>
        private Avalara.SDK.Client.ApiResponse<JobModel> BulkUpsert1099FormsWithHttpInfo(BulkUpsert1099FormsRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->BulkUpsert1099Forms");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->BulkUpsert1099Forms");

            // verify the required parameter 'BulkUpsert1099FormsRequest' is set
            if (requestParameters.BulkUpsert1099FormsRequest == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.BulkUpsert1099FormsRequest' when calling Class1099FormsApi->BulkUpsert1099Forms");

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
            localVarRequestOptions.Data = requestParameters.BulkUpsert1099FormsRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<JobModel>("/1099/forms/$bulk", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create/Update 1099 forms This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JobModel</returns>
        public async System.Threading.Tasks.Task<JobModel> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<JobModel> localVarResponse = await BulkUpsert1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create/Update 1099 forms This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JobModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<JobModel>> BulkUpsert1099FormsWithHttpInfoAsync(BulkUpsert1099FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->BulkUpsert1099Forms");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->BulkUpsert1099Forms");

            // verify the required parameter 'requestParameters.BulkUpsert1099FormsRequest' is set
            if (requestParameters.BulkUpsert1099FormsRequest == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.BulkUpsert1099FormsRequest' when calling Class1099FormsApi->BulkUpsert1099Forms");


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
            localVarRequestOptions.Data = requestParameters.BulkUpsert1099FormsRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<JobModel>("/1099/forms/$bulk", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new 1099 form This endpoint allows users to create a new 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099OneOf</returns>
        public Form1099OneOf Call1099FormsPost(Call1099FormsPostRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Form1099OneOf> localVarResponse = Call1099FormsPostWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new 1099 form This endpoint allows users to create a new 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Form1099OneOf</returns>
        private Avalara.SDK.Client.ApiResponse<Form1099OneOf> Call1099FormsPostWithHttpInfo(Call1099FormsPostRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Call1099FormsPost");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Call1099FormsPost");

            // verify the required parameter 'Form1099OneOf' is set
            if (requestParameters.Form1099OneOf == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Form1099OneOf' when calling Class1099FormsApi->Call1099FormsPost");

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
            localVarRequestOptions.Data = requestParameters.Form1099OneOf;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Form1099OneOf>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Call1099FormsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new 1099 form This endpoint allows users to create a new 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099OneOf</returns>
        public async System.Threading.Tasks.Task<Form1099OneOf> Call1099FormsPostAsync(Call1099FormsPostRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Form1099OneOf> localVarResponse = await Call1099FormsPostWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new 1099 form This endpoint allows users to create a new 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Form1099OneOf)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Form1099OneOf>> Call1099FormsPostWithHttpInfoAsync(Call1099FormsPostRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Call1099FormsPost");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Call1099FormsPost");

            // verify the required parameter 'requestParameters.Form1099OneOf' is set
            if (requestParameters.Form1099OneOf == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Form1099OneOf' when calling Class1099FormsApi->Call1099FormsPost");


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
            localVarRequestOptions.Data = requestParameters.Form1099OneOf;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Form1099OneOf>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Call1099FormsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a 1099 form This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a &#x60;204 No Content&#x60; status. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void Delete1099Form(Delete1099FormRequest requestParameters)
        {
            Delete1099FormWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Delete a 1099 form This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a &#x60;204 No Content&#x60; status. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> Delete1099FormWithHttpInfo(Delete1099FormRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'FormId' is set
            if (requestParameters.FormId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormId' when calling Class1099FormsApi->Delete1099Form");

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
            var localVarResponse = this.Client.Delete<Object>("/1099/forms/{formId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a 1099 form This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a &#x60;204 No Content&#x60; status. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await Delete1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a 1099 form This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a &#x60;204 No Content&#x60; status. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> Delete1099FormWithHttpInfoAsync(Delete1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'requestParameters.FormId' is set
            if (requestParameters.FormId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormId' when calling Class1099FormsApi->Delete1099Form");


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
			var localVarResponse = await this.Client.DeleteAsync<Object>("/1099/forms/{formId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit a download job to retrieve PDF forms This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the &#x60;GET /jobs/{jobId}&#x60; endpoint. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>InititateDownloadOutputModel</returns>
        public InititateDownloadOutputModel Download1099FormPDF(Download1099FormPDFRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<InititateDownloadOutputModel> localVarResponse = Download1099FormPDFWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a download job to retrieve PDF forms This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the &#x60;GET /jobs/{jobId}&#x60; endpoint. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of InititateDownloadOutputModel</returns>
        private Avalara.SDK.Client.ApiResponse<InititateDownloadOutputModel> Download1099FormPDFWithHttpInfo(Download1099FormPDFRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Download1099FormPDF");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Download1099FormPDF");

            // verify the required parameter 'InitiateDownloadInputModel' is set
            if (requestParameters.InitiateDownloadInputModel == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.InitiateDownloadInputModel' when calling Class1099FormsApi->Download1099FormPDF");

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
            localVarRequestOptions.Data = requestParameters.InitiateDownloadInputModel;

            // make the HTTP request
            var localVarResponse = this.Client.Post<InititateDownloadOutputModel>("/1099/forms/$initiate-download", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Download1099FormPDF", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit a download job to retrieve PDF forms This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the &#x60;GET /jobs/{jobId}&#x60; endpoint. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InititateDownloadOutputModel</returns>
        public async System.Threading.Tasks.Task<InititateDownloadOutputModel> Download1099FormPDFAsync(Download1099FormPDFRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<InititateDownloadOutputModel> localVarResponse = await Download1099FormPDFWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a download job to retrieve PDF forms This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the &#x60;GET /jobs/{jobId}&#x60; endpoint. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InititateDownloadOutputModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<InititateDownloadOutputModel>> Download1099FormPDFWithHttpInfoAsync(Download1099FormPDFRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Download1099FormPDF");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Download1099FormPDF");

            // verify the required parameter 'requestParameters.InitiateDownloadInputModel' is set
            if (requestParameters.InitiateDownloadInputModel == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.InitiateDownloadInputModel' when calling Class1099FormsApi->Download1099FormPDF");


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
            localVarRequestOptions.Data = requestParameters.InitiateDownloadInputModel;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<InititateDownloadOutputModel>("/1099/forms/$initiate-download", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Download1099FormPDF", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a single 1099 form This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099OneOf</returns>
        public Form1099OneOf Get1099Form(Get1099FormRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Form1099OneOf> localVarResponse = Get1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single 1099 form This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Form1099OneOf</returns>
        private Avalara.SDK.Client.ApiResponse<Form1099OneOf> Get1099FormWithHttpInfo(Get1099FormRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'FormId' is set
            if (requestParameters.FormId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormId' when calling Class1099FormsApi->Get1099Form");

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
            var localVarResponse = this.Client.Get<Form1099OneOf>("/1099/forms/{formId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a single 1099 form This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099OneOf</returns>
        public async System.Threading.Tasks.Task<Form1099OneOf> Get1099FormAsync(Get1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Form1099OneOf> localVarResponse = await Get1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single 1099 form This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Form1099OneOf)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Form1099OneOf>> Get1099FormWithHttpInfoAsync(Get1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'requestParameters.FormId' is set
            if (requestParameters.FormId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FormId' when calling Class1099FormsApi->Get1099Form");


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
			var localVarResponse = await this.Client.GetAsync<Form1099OneOf>("/1099/forms/{formId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List 1099 forms This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>List1099Forms200Response</returns>
        public List1099Forms200Response List1099Forms(List1099FormsRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<List1099Forms200Response> localVarResponse = List1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List 1099 forms This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of List1099Forms200Response</returns>
        private Avalara.SDK.Client.ApiResponse<List1099Forms200Response> List1099FormsWithHttpInfo(List1099FormsRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->List1099Forms");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->List1099Forms");

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
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.HeaderParameters.Add("count", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Count)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List1099Forms200Response>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List 1099 forms This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List1099Forms200Response</returns>
        public async System.Threading.Tasks.Task<List1099Forms200Response> List1099FormsAsync(List1099FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<List1099Forms200Response> localVarResponse = await List1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List 1099 forms This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List1099Forms200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<List1099Forms200Response>> List1099FormsWithHttpInfoAsync(List1099FormsRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->List1099Forms");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->List1099Forms");


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
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.HeaderParameters.Add("count", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Count)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<List1099Forms200Response>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing form. This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099OneOf</returns>
        public Form1099OneOf Update1099Form(Update1099FormRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Form1099OneOf> localVarResponse = Update1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing form. This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Form1099OneOf</returns>
        private Avalara.SDK.Client.ApiResponse<Form1099OneOf> Update1099FormWithHttpInfo(Update1099FormRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'Form1099OneOf' is set
            if (requestParameters.Form1099OneOf == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Form1099OneOf' when calling Class1099FormsApi->Update1099Form");

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
            localVarRequestOptions.Data = requestParameters.Form1099OneOf;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Form1099OneOf>("/1099/forms/{formId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing form. This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099OneOf</returns>
        public async System.Threading.Tasks.Task<Form1099OneOf> Update1099FormAsync(Update1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Form1099OneOf> localVarResponse = await Update1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing form. This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Form1099OneOf)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Form1099OneOf>> Update1099FormWithHttpInfoAsync(Update1099FormRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'requestParameters.Form1099OneOf' is set
            if (requestParameters.Form1099OneOf == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Form1099OneOf' when calling Class1099FormsApi->Update1099Form");


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
            localVarRequestOptions.Data = requestParameters.Form1099OneOf;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Form1099OneOf>("/1099/forms/{formId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
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
            this.Client.SdkVersion = "25.3.3";
        }
        
    }

    
}
