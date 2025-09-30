

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
    public class BulkUpsert1099FormsRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// defaults to false. If true, it will NOT change the DB. It will just return a report of what would&#39;ve have been changed in the DB
        /// </summary>
        public bool? DryRun { get; set; }
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Form1099ListRequest Form1099ListRequest { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Create1099Form API
    /// </summary>
    public class Create1099FormRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Get1099Form200Response Get1099Form200Response { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Delete1099Form API
    /// </summary>
    public class Delete1099FormRequestSdk {
        /// <summary>
        /// The unique identifier of the desired form to delete.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Get1099Form API
    /// </summary>
    public class Get1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Get1099FormPdf API
    /// </summary>
    public class Get1099FormPdfRequestSdk {
        /// <summary>
        /// The ID of the form
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Optional boolean that if set indicates that the form should be marked as having been successfully edelivered
        /// </summary>
        public bool? MarkEdelivered { get; set; }
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the List1099Forms API
    /// </summary>
    public class List1099FormsRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// A filter statement to identify specific records to retrieve.  For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets.
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
        /// If true, return the global count of elements in the collection.
        /// </summary>
        public bool? Count { get; set; }
        /// <summary>
        /// If true, return ONLY the global count of elements in the collection.  It only applies when count&#x3D;true.
        /// </summary>
        public bool? CountOnly { get; set; }
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Update1099Form API
    /// </summary>
    public class Update1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Get1099Form200Response Get1099Form200Response { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IForms1099ApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create or update multiple 1099/1095/W2/1042S forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to create or update multiple 1099/1095/W2/1042S forms.  Maximum of 5000 forms can be processed in a single bulk request.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>JobResponse</returns>
        JobResponse BulkUpsert1099Forms(BulkUpsert1099FormsRequestSdk requestParameters);

        /// <summary>
        /// Create a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Create a 1099/1095/W2/1042S form.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        Get1099Form200Response Create1099Form(Create1099FormRequestSdk requestParameters);

        /// <summary>
        /// Delete a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Delete a 1099/1095/W2/1042S form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void Delete1099Form(Delete1099FormRequestSdk requestParameters);

        /// <summary>
        /// Retrieve a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Retrieve a 1099/1095/W2/1042S form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        Get1099Form200Response Get1099Form(Get1099FormRequestSdk requestParameters);

        /// <summary>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FileParameter</returns>
        FileParameter Get1099FormPdf(Get1099FormPdfRequestSdk requestParameters);

        /// <summary>
        /// List 1099/1095/W2/1042S forms
        /// </summary>
        /// <remarks>
        /// List 1099/1095/W2/1042S forms.                Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.                Supported filtering fields are as follows:                - issuerId  - issuerReferenceId  - taxYear  - addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified  - createdAt  - edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted  - email  - federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held  - recipientName  - mailStatus - possible values are: sent, unscheduled, pending, delivered  - referenceId  - tinMatchStatus - possible values are: none, pending, matched, failed  - type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC  - updatedAt  - validity - possible values are: true, false                For more information on filtering, see &lt;see href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/see&gt;.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>PaginatedQueryResultModelForm1099Base</returns>
        PaginatedQueryResultModelForm1099Base List1099Forms(List1099FormsRequestSdk requestParameters);

        /// <summary>
        /// Update a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Update a 1099/1095/W2/1042S form.    **Date Update Rules:**    Possible to update scheduled dates (same validation rules apply).  Cannot change from scheduled to unscheduled status - must delete form and create new one.  If dates are between current date and blackout period, scheduled to that date.  If dates are in past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        Get1099Form200Response Update1099Form(Update1099FormRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IForms1099ApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create or update multiple 1099/1095/W2/1042S forms
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to create or update multiple 1099/1095/W2/1042S forms.  Maximum of 5000 forms can be processed in a single bulk request.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JobResponse</returns>
        System.Threading.Tasks.Task<JobResponse> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Create a 1099/1095/W2/1042S form.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        System.Threading.Tasks.Task<Get1099Form200Response> Create1099FormAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Delete a 1099/1095/W2/1042S form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Retrieve a 1099/1095/W2/1042S form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        System.Threading.Tasks.Task<Get1099Form200Response> Get1099FormAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> Get1099FormPdfAsync(Get1099FormPdfRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List 1099/1095/W2/1042S forms
        /// </summary>
        /// <remarks>
        /// List 1099/1095/W2/1042S forms.                Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.                Supported filtering fields are as follows:                - issuerId  - issuerReferenceId  - taxYear  - addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified  - createdAt  - edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted  - email  - federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held  - recipientName  - mailStatus - possible values are: sent, unscheduled, pending, delivered  - referenceId  - tinMatchStatus - possible values are: none, pending, matched, failed  - type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC  - updatedAt  - validity - possible values are: true, false                For more information on filtering, see &lt;see href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/see&gt;.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedQueryResultModelForm1099Base</returns>
        System.Threading.Tasks.Task<PaginatedQueryResultModelForm1099Base> List1099FormsAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update a 1099/1095/W2/1042S form
        /// </summary>
        /// <remarks>
        /// Update a 1099/1095/W2/1042S form.    **Date Update Rules:**    Possible to update scheduled dates (same validation rules apply).  Cannot change from scheduled to unscheduled status - must delete form and create new one.  If dates are between current date and blackout period, scheduled to that date.  If dates are in past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        System.Threading.Tasks.Task<Get1099Form200Response> Update1099FormAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Forms1099Api : IForms1099ApiSync, IForms1099ApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Forms1099Api"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public Forms1099Api(Avalara.SDK.Client.IApiClient client)
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
        /// Create or update multiple 1099/1095/W2/1042S forms This endpoint allows you to create or update multiple 1099/1095/W2/1042S forms.  Maximum of 5000 forms can be processed in a single bulk request.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>JobResponse</returns>
        public JobResponse BulkUpsert1099Forms(BulkUpsert1099FormsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<JobResponse> localVarResponse = BulkUpsert1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create or update multiple 1099/1095/W2/1042S forms This endpoint allows you to create or update multiple 1099/1095/W2/1042S forms.  Maximum of 5000 forms can be processed in a single bulk request.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of JobResponse</returns>
        private Avalara.SDK.Client.ApiResponse<JobResponse> BulkUpsert1099FormsWithHttpInfo(BulkUpsert1099FormsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->BulkUpsert1099Forms");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.DryRun != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "dryRun", requestParameters.DryRun));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.Form1099ListRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<JobResponse>("/1099/forms/$bulk-upsert", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create or update multiple 1099/1095/W2/1042S forms This endpoint allows you to create or update multiple 1099/1095/W2/1042S forms.  Maximum of 5000 forms can be processed in a single bulk request.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JobResponse</returns>
        public async System.Threading.Tasks.Task<JobResponse> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<JobResponse> localVarResponse = await BulkUpsert1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create or update multiple 1099/1095/W2/1042S forms This endpoint allows you to create or update multiple 1099/1095/W2/1042S forms.  Maximum of 5000 forms can be processed in a single bulk request.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<JobResponse>> BulkUpsert1099FormsWithHttpInfoAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->BulkUpsert1099Forms");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.DryRun != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "dryRun", requestParameters.DryRun));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.Form1099ListRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<JobResponse>("/1099/forms/$bulk-upsert", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a 1099/1095/W2/1042S form Create a 1099/1095/W2/1042S form.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        public Get1099Form200Response Create1099Form(Create1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = Create1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a 1099/1095/W2/1042S form Create a 1099/1095/W2/1042S form.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Get1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Get1099Form200Response> Create1099FormWithHttpInfo(Create1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Create1099Form");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.Get1099Form200Response;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Get1099Form200Response>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a 1099/1095/W2/1042S form Create a 1099/1095/W2/1042S form.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Get1099Form200Response> Create1099FormAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = await Create1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a 1099/1095/W2/1042S form Create a 1099/1095/W2/1042S form.    **Date Scheduling Rules:**    If federalEfileDate, stateEfileDate, or recipientEdeliveryDate are between current date and beginning of blackout period, scheduled to that date.  If dates are in the past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.  Set dates to null to leave unscheduled.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Get1099Form200Response>> Create1099FormWithHttpInfoAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Create1099Form");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.Get1099Form200Response;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Get1099Form200Response>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a 1099/1095/W2/1042S form Delete a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void Delete1099Form(Delete1099FormRequestSdk requestParameters)
        {
            Delete1099FormWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Delete a 1099/1095/W2/1042S form Delete a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> Delete1099FormWithHttpInfo(Delete1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Delete1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Delete1099Form");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a 1099/1095/W2/1042S form Delete a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await Delete1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a 1099/1095/W2/1042S form Delete a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> Delete1099FormWithHttpInfoAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Delete1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Delete1099Form");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a 1099/1095/W2/1042S form Retrieve a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        public Get1099Form200Response Get1099Form(Get1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = Get1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a 1099/1095/W2/1042S form Retrieve a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Get1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Get1099Form200Response> Get1099FormWithHttpInfo(Get1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099Form");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Get1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a 1099/1095/W2/1042S form Retrieve a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Get1099Form200Response> Get1099FormAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = await Get1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a 1099/1095/W2/1042S form Retrieve a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Get1099Form200Response>> Get1099FormWithHttpInfoAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099Form");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Get1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form Retrieve the PDF file for a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FileParameter</returns>
        public FileParameter Get1099FormPdf(Get1099FormPdfRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FileParameter> localVarResponse = Get1099FormPdfWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form Retrieve the PDF file for a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FileParameter</returns>
        private Avalara.SDK.Client.ApiResponse<FileParameter> Get1099FormPdfWithHttpInfo(Get1099FormPdfRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099FormPdf");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099FormPdf");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/pdf",
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            if (requestParameters.MarkEdelivered != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "markEdelivered", requestParameters.MarkEdelivered));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileParameter>("/1099/forms/{id}/pdf", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099FormPdf", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form Retrieve the PDF file for a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> Get1099FormPdfAsync(Get1099FormPdfRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FileParameter> localVarResponse = await Get1099FormPdfWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the PDF file for a 1099/1095/W2/1042S form Retrieve the PDF file for a 1099/1095/W2/1042S form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FileParameter>> Get1099FormPdfWithHttpInfoAsync(Get1099FormPdfRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099FormPdf");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099FormPdf");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/pdf",
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            if (requestParameters.MarkEdelivered != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "markEdelivered", requestParameters.MarkEdelivered));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<FileParameter>("/1099/forms/{id}/pdf", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099FormPdf", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List 1099/1095/W2/1042S forms List 1099/1095/W2/1042S forms.                Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.                Supported filtering fields are as follows:                - issuerId  - issuerReferenceId  - taxYear  - addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified  - createdAt  - edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted  - email  - federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held  - recipientName  - mailStatus - possible values are: sent, unscheduled, pending, delivered  - referenceId  - tinMatchStatus - possible values are: none, pending, matched, failed  - type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC  - updatedAt  - validity - possible values are: true, false                For more information on filtering, see &lt;see href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/see&gt;.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>PaginatedQueryResultModelForm1099Base</returns>
        public PaginatedQueryResultModelForm1099Base List1099Forms(List1099FormsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<PaginatedQueryResultModelForm1099Base> localVarResponse = List1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List 1099/1095/W2/1042S forms List 1099/1095/W2/1042S forms.                Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.                Supported filtering fields are as follows:                - issuerId  - issuerReferenceId  - taxYear  - addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified  - createdAt  - edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted  - email  - federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held  - recipientName  - mailStatus - possible values are: sent, unscheduled, pending, delivered  - referenceId  - tinMatchStatus - possible values are: none, pending, matched, failed  - type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC  - updatedAt  - validity - possible values are: true, false                For more information on filtering, see &lt;see href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/see&gt;.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of PaginatedQueryResultModelForm1099Base</returns>
        private Avalara.SDK.Client.ApiResponse<PaginatedQueryResultModelForm1099Base> List1099FormsWithHttpInfo(List1099FormsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->List1099Forms");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

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
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", requestParameters.CountOnly));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaginatedQueryResultModelForm1099Base>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List 1099/1095/W2/1042S forms List 1099/1095/W2/1042S forms.                Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.                Supported filtering fields are as follows:                - issuerId  - issuerReferenceId  - taxYear  - addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified  - createdAt  - edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted  - email  - federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held  - recipientName  - mailStatus - possible values are: sent, unscheduled, pending, delivered  - referenceId  - tinMatchStatus - possible values are: none, pending, matched, failed  - type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC  - updatedAt  - validity - possible values are: true, false                For more information on filtering, see &lt;see href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/see&gt;.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedQueryResultModelForm1099Base</returns>
        public async System.Threading.Tasks.Task<PaginatedQueryResultModelForm1099Base> List1099FormsAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<PaginatedQueryResultModelForm1099Base> localVarResponse = await List1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List 1099/1095/W2/1042S forms List 1099/1095/W2/1042S forms.                Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.                Supported filtering fields are as follows:                - issuerId  - issuerReferenceId  - taxYear  - addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified  - createdAt  - edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted  - email  - federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held  - recipientName  - mailStatus - possible values are: sent, unscheduled, pending, delivered  - referenceId  - tinMatchStatus - possible values are: none, pending, matched, failed  - type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC  - updatedAt  - validity - possible values are: true, false                For more information on filtering, see &lt;see href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/see&gt;.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedQueryResultModelForm1099Base)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<PaginatedQueryResultModelForm1099Base>> List1099FormsWithHttpInfoAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->List1099Forms");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

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
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", requestParameters.CountOnly));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<PaginatedQueryResultModelForm1099Base>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a 1099/1095/W2/1042S form Update a 1099/1095/W2/1042S form.    **Date Update Rules:**    Possible to update scheduled dates (same validation rules apply).  Cannot change from scheduled to unscheduled status - must delete form and create new one.  If dates are between current date and blackout period, scheduled to that date.  If dates are in past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        public Get1099Form200Response Update1099Form(Update1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = Update1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a 1099/1095/W2/1042S form Update a 1099/1095/W2/1042S form.    **Date Update Rules:**    Possible to update scheduled dates (same validation rules apply).  Cannot change from scheduled to unscheduled status - must delete form and create new one.  If dates are between current date and blackout period, scheduled to that date.  If dates are in past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Get1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Get1099Form200Response> Update1099FormWithHttpInfo(Update1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Update1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Update1099Form");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.Get1099Form200Response;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Get1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a 1099/1095/W2/1042S form Update a 1099/1095/W2/1042S form.    **Date Update Rules:**    Possible to update scheduled dates (same validation rules apply).  Cannot change from scheduled to unscheduled status - must delete form and create new one.  If dates are between current date and blackout period, scheduled to that date.  If dates are in past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Get1099Form200Response> Update1099FormAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = await Update1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a 1099/1095/W2/1042S form Update a 1099/1095/W2/1042S form.    **Date Update Rules:**    Possible to update scheduled dates (same validation rules apply).  Cannot change from scheduled to unscheduled status - must delete form and create new one.  If dates are between current date and blackout period, scheduled to that date.  If dates are in past or blackout period, scheduled to next available date.  For blackout period information, see https://www.track1099.com/info/IRS_info.  StateEfileDate must be on or after federalEfileDate.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Get1099Form200Response>> Update1099FormWithHttpInfoAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Update1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Update1099Form");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.Get1099Form200Response;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Get1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

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
            this.Client.SdkVersion = "25.10.0";
        }
        
    }

    
}
