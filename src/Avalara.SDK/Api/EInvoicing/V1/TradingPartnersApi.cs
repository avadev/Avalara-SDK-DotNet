

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Avalara.SDK.Api.EInvoicing.V1
{
    /// <summary>
    /// Represents the Request object for the BatchSearchParticipants API
    /// </summary>
    public class BatchSearchParticipantsRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.3";
        /// <summary>
        /// The human readable name given to this batch search.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The email address of the user to whom the batch search completion notification must go to.
        /// </summary>
        public string NotificationEmail { get; set; }
        /// <summary>
        /// CSV file containing search parameters.
        /// </summary>
        public FileParameter File { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the DownloadBatchSearchReport API
    /// </summary>
    public class DownloadBatchSearchReportRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.3";
        /// <summary>
        /// The ID of the batch search whose report is to be downloaded.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetBatchSearchDetail API
    /// </summary>
    public class GetBatchSearchDetailRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.3";
        /// <summary>
        /// The ID of the batch search that was submitted earlier.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the ListBatchSearches API
    /// </summary>
    public class ListBatchSearchesRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.3";
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; .The parameters supported is &lt;code&gt;name&lt;/code&gt;.    Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided parameters.
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// When set to true, the count of the collection is included as @recordSetCount in the response body.
        /// </summary>
        public bool? Count { get; set; }
        /// <summary>
        /// The number of items to include in the result.
        /// </summary>
        public decimal? Top { get; set; }
        /// <summary>
        /// If nonzero, skip this number of results before returning data. Used with &lt;code&gt;$top&lt;/code&gt; to provide pagination for large datasets.
        /// </summary>
        public string Skip { get; set; }
        /// <summary>
        /// The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space.
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the SearchParticipants API
    /// </summary>
    public class SearchParticipantsRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.3";
        /// <summary>
        /// Search by value supports logical AND and OR. Refer to [https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview#search](https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview#search) for more information on search. Search will be done over &lt;code&gt;name&lt;/code&gt; and &lt;code&gt;identifier&lt;/code&gt; parameters only.
        /// </summary>
        public string Search { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// When set to true, the count of the collection is included as @recordSetCount in the response body.
        /// </summary>
        public bool? Count { get; set; }
        /// <summary>
        /// Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; .The parameters supported are &lt;code&gt;network&lt;/code&gt;, &lt;code&gt;country&lt;/code&gt;, &lt;code&gt;documentType&lt;/code&gt;, &lt;code&gt;idType&lt;/code&gt;.          Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided parameters.
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// The number of items to include in the result.
        /// </summary>
        public decimal? Top { get; set; }
        /// <summary>
        /// If nonzero, skip this number of results before returning data. Used with &lt;code&gt;$top&lt;/code&gt; to provide pagination for large datasets.
        /// </summary>
        public string Skip { get; set; }
        /// <summary>
        /// The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space.
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITradingPartnersApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates a batch search and performs a batch search in the directory for participants in the background.
        /// </summary>
        /// <remarks>
        /// Handles batch search requests by uploading a file containing search parameters.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>BatchSearchParticipants202Response</returns>
        BatchSearchParticipants202Response BatchSearchParticipants(BatchSearchParticipantsRequestSdk requestParameters);

        /// <summary>
        /// Download batch search results in a csv file.
        /// </summary>
        /// <remarks>
        /// Downloads the report for a specific batch search using the batch search ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FileParameter</returns>
        FileParameter DownloadBatchSearchReport(DownloadBatchSearchReportRequestSdk requestParameters);

        /// <summary>
        /// Get the batch search details for a given id.
        /// </summary>
        /// <remarks>
        /// This endpoint provides a detailed information for a specific batch search based on a given ID. It is ideal for tracking the progress of a previously initiated batch search operation.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>BatchSearch</returns>
        BatchSearch GetBatchSearchDetail(GetBatchSearchDetailRequestSdk requestParameters);

        /// <summary>
        /// List all batch searches that were previously submitted.
        /// </summary>
        /// <remarks>
        /// This endpoint provides a way to retrieve a comprehensive list of all batch search operations that have been previously submitted. This endpoint returns details about each batch search, such as their id, status, created date and associated metadata, allowing users to easily view past batch search requests. It&#39;s particularly useful for tracking the progress of a previously initiated batch search operations.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>BatchSearchListResponse</returns>
        BatchSearchListResponse ListBatchSearches(ListBatchSearchesRequestSdk requestParameters);

        /// <summary>
        /// Returns a list of participants matching the input query.
        /// </summary>
        /// <remarks>
        /// This endpoint provides a list of trading partners that match a specified input query. The search is performed based on various filters, search text, and other relevant parameters.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DirectorySearchResponse</returns>
        DirectorySearchResponse SearchParticipants(SearchParticipantsRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITradingPartnersApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Creates a batch search and performs a batch search in the directory for participants in the background.
        /// </summary>
        /// <remarks>
        /// Handles batch search requests by uploading a file containing search parameters.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchSearchParticipants202Response</returns>
        System.Threading.Tasks.Task<BatchSearchParticipants202Response> BatchSearchParticipantsAsync(BatchSearchParticipantsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Download batch search results in a csv file.
        /// </summary>
        /// <remarks>
        /// Downloads the report for a specific batch search using the batch search ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> DownloadBatchSearchReportAsync(DownloadBatchSearchReportRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the batch search details for a given id.
        /// </summary>
        /// <remarks>
        /// This endpoint provides a detailed information for a specific batch search based on a given ID. It is ideal for tracking the progress of a previously initiated batch search operation.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchSearch</returns>
        System.Threading.Tasks.Task<BatchSearch> GetBatchSearchDetailAsync(GetBatchSearchDetailRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all batch searches that were previously submitted.
        /// </summary>
        /// <remarks>
        /// This endpoint provides a way to retrieve a comprehensive list of all batch search operations that have been previously submitted. This endpoint returns details about each batch search, such as their id, status, created date and associated metadata, allowing users to easily view past batch search requests. It&#39;s particularly useful for tracking the progress of a previously initiated batch search operations.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchSearchListResponse</returns>
        System.Threading.Tasks.Task<BatchSearchListResponse> ListBatchSearchesAsync(ListBatchSearchesRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns a list of participants matching the input query.
        /// </summary>
        /// <remarks>
        /// This endpoint provides a list of trading partners that match a specified input query. The search is performed based on various filters, search text, and other relevant parameters.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DirectorySearchResponse</returns>
        System.Threading.Tasks.Task<DirectorySearchResponse> SearchParticipantsAsync(SearchParticipantsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TradingPartnersApi : ITradingPartnersApiSync, ITradingPartnersApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingPartnersApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public TradingPartnersApi(Avalara.SDK.Client.IApiClient client)
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
        /// Creates a batch search and performs a batch search in the directory for participants in the background. Handles batch search requests by uploading a file containing search parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>BatchSearchParticipants202Response</returns>
        public BatchSearchParticipants202Response BatchSearchParticipants(BatchSearchParticipantsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<BatchSearchParticipants202Response> localVarResponse = BatchSearchParticipantsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a batch search and performs a batch search in the directory for participants in the background. Handles batch search requests by uploading a file containing search parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of BatchSearchParticipants202Response</returns>
        private Avalara.SDK.Client.ApiResponse<BatchSearchParticipants202Response> BatchSearchParticipantsWithHttpInfo(BatchSearchParticipantsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->BatchSearchParticipants");

            // verify the required parameter 'Name' is set
            if (requestParameters.Name == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Name' when calling TradingPartnersApi->BatchSearchParticipants");

            // verify the required parameter 'NotificationEmail' is set
            if (requestParameters.NotificationEmail == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.NotificationEmail' when calling TradingPartnersApi->BatchSearchParticipants");

            // verify the required parameter 'File' is set
            if (requestParameters.File == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.File' when calling TradingPartnersApi->BatchSearchParticipants");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "name", requestParameters.Name));
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "notificationEmail", requestParameters.NotificationEmail));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            localVarRequestOptions.FileParameters.Add("file", requestParameters.File);

            // make the HTTP request
            var localVarResponse = this.Client.Post<BatchSearchParticipants202Response>("/einvoicing/trading-partners/batch-searches", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BatchSearchParticipants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Creates a batch search and performs a batch search in the directory for participants in the background. Handles batch search requests by uploading a file containing search parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchSearchParticipants202Response</returns>
        public async System.Threading.Tasks.Task<BatchSearchParticipants202Response> BatchSearchParticipantsAsync(BatchSearchParticipantsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<BatchSearchParticipants202Response> localVarResponse = await BatchSearchParticipantsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a batch search and performs a batch search in the directory for participants in the background. Handles batch search requests by uploading a file containing search parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchSearchParticipants202Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<BatchSearchParticipants202Response>> BatchSearchParticipantsWithHttpInfoAsync(BatchSearchParticipantsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->BatchSearchParticipants");

            // verify the required parameter 'requestParameters.Name' is set
            if (requestParameters.Name == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Name' when calling TradingPartnersApi->BatchSearchParticipants");

            // verify the required parameter 'requestParameters.NotificationEmail' is set
            if (requestParameters.NotificationEmail == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.NotificationEmail' when calling TradingPartnersApi->BatchSearchParticipants");

            // verify the required parameter 'requestParameters.File' is set
            if (requestParameters.File == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.File' when calling TradingPartnersApi->BatchSearchParticipants");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "name", requestParameters.Name));
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "notificationEmail", requestParameters.NotificationEmail));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            localVarRequestOptions.FileParameters.Add("file", requestParameters.File);

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<BatchSearchParticipants202Response>("/einvoicing/trading-partners/batch-searches", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BatchSearchParticipants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Download batch search results in a csv file. Downloads the report for a specific batch search using the batch search ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FileParameter</returns>
        public FileParameter DownloadBatchSearchReport(DownloadBatchSearchReportRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FileParameter> localVarResponse = DownloadBatchSearchReportWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Download batch search results in a csv file. Downloads the report for a specific batch search using the batch search ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FileParameter</returns>
        private Avalara.SDK.Client.ApiResponse<FileParameter> DownloadBatchSearchReportWithHttpInfo(DownloadBatchSearchReportRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->DownloadBatchSearchReport");

            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling TradingPartnersApi->DownloadBatchSearchReport");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/csv",
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileParameter>("/einvoicing/trading-partners/batch-searches/{id}/$download-results", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadBatchSearchReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Download batch search results in a csv file. Downloads the report for a specific batch search using the batch search ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> DownloadBatchSearchReportAsync(DownloadBatchSearchReportRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FileParameter> localVarResponse = await DownloadBatchSearchReportWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Download batch search results in a csv file. Downloads the report for a specific batch search using the batch search ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FileParameter>> DownloadBatchSearchReportWithHttpInfoAsync(DownloadBatchSearchReportRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->DownloadBatchSearchReport");

            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling TradingPartnersApi->DownloadBatchSearchReport");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/csv",
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<FileParameter>("/einvoicing/trading-partners/batch-searches/{id}/$download-results", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadBatchSearchReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the batch search details for a given id. This endpoint provides a detailed information for a specific batch search based on a given ID. It is ideal for tracking the progress of a previously initiated batch search operation.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>BatchSearch</returns>
        public BatchSearch GetBatchSearchDetail(GetBatchSearchDetailRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<BatchSearch> localVarResponse = GetBatchSearchDetailWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the batch search details for a given id. This endpoint provides a detailed information for a specific batch search based on a given ID. It is ideal for tracking the progress of a previously initiated batch search operation.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of BatchSearch</returns>
        private Avalara.SDK.Client.ApiResponse<BatchSearch> GetBatchSearchDetailWithHttpInfo(GetBatchSearchDetailRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->GetBatchSearchDetail");

            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling TradingPartnersApi->GetBatchSearchDetail");

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

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<BatchSearch>("/einvoicing/trading-partners/batch-searches/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBatchSearchDetail", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the batch search details for a given id. This endpoint provides a detailed information for a specific batch search based on a given ID. It is ideal for tracking the progress of a previously initiated batch search operation.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchSearch</returns>
        public async System.Threading.Tasks.Task<BatchSearch> GetBatchSearchDetailAsync(GetBatchSearchDetailRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<BatchSearch> localVarResponse = await GetBatchSearchDetailWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the batch search details for a given id. This endpoint provides a detailed information for a specific batch search based on a given ID. It is ideal for tracking the progress of a previously initiated batch search operation.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchSearch)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<BatchSearch>> GetBatchSearchDetailWithHttpInfoAsync(GetBatchSearchDetailRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->GetBatchSearchDetail");

            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling TradingPartnersApi->GetBatchSearchDetail");


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

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<BatchSearch>("/einvoicing/trading-partners/batch-searches/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBatchSearchDetail", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all batch searches that were previously submitted. This endpoint provides a way to retrieve a comprehensive list of all batch search operations that have been previously submitted. This endpoint returns details about each batch search, such as their id, status, created date and associated metadata, allowing users to easily view past batch search requests. It&#39;s particularly useful for tracking the progress of a previously initiated batch search operations.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>BatchSearchListResponse</returns>
        public BatchSearchListResponse ListBatchSearches(ListBatchSearchesRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<BatchSearchListResponse> localVarResponse = ListBatchSearchesWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all batch searches that were previously submitted. This endpoint provides a way to retrieve a comprehensive list of all batch search operations that have been previously submitted. This endpoint returns details about each batch search, such as their id, status, created date and associated metadata, allowing users to easily view past batch search requests. It&#39;s particularly useful for tracking the progress of a previously initiated batch search operations.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of BatchSearchListResponse</returns>
        private Avalara.SDK.Client.ApiResponse<BatchSearchListResponse> ListBatchSearchesWithHttpInfo(ListBatchSearchesRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->ListBatchSearches");

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
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<BatchSearchListResponse>("/einvoicing/trading-partners/batch-searches", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListBatchSearches", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all batch searches that were previously submitted. This endpoint provides a way to retrieve a comprehensive list of all batch search operations that have been previously submitted. This endpoint returns details about each batch search, such as their id, status, created date and associated metadata, allowing users to easily view past batch search requests. It&#39;s particularly useful for tracking the progress of a previously initiated batch search operations.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BatchSearchListResponse</returns>
        public async System.Threading.Tasks.Task<BatchSearchListResponse> ListBatchSearchesAsync(ListBatchSearchesRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<BatchSearchListResponse> localVarResponse = await ListBatchSearchesWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all batch searches that were previously submitted. This endpoint provides a way to retrieve a comprehensive list of all batch search operations that have been previously submitted. This endpoint returns details about each batch search, such as their id, status, created date and associated metadata, allowing users to easily view past batch search requests. It&#39;s particularly useful for tracking the progress of a previously initiated batch search operations.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BatchSearchListResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<BatchSearchListResponse>> ListBatchSearchesWithHttpInfoAsync(ListBatchSearchesRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->ListBatchSearches");


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
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<BatchSearchListResponse>("/einvoicing/trading-partners/batch-searches", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListBatchSearches", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of participants matching the input query. This endpoint provides a list of trading partners that match a specified input query. The search is performed based on various filters, search text, and other relevant parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DirectorySearchResponse</returns>
        public DirectorySearchResponse SearchParticipants(SearchParticipantsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<DirectorySearchResponse> localVarResponse = SearchParticipantsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of participants matching the input query. This endpoint provides a list of trading partners that match a specified input query. The search is performed based on various filters, search text, and other relevant parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of DirectorySearchResponse</returns>
        private Avalara.SDK.Client.ApiResponse<DirectorySearchResponse> SearchParticipantsWithHttpInfo(SearchParticipantsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->SearchParticipants");

            // verify the required parameter 'Search' is set
            if (requestParameters.Search == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Search' when calling TradingPartnersApi->SearchParticipants");

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

            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$search", requestParameters.Search));
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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DirectorySearchResponse>("/einvoicing/trading-partners", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchParticipants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of participants matching the input query. This endpoint provides a list of trading partners that match a specified input query. The search is performed based on various filters, search text, and other relevant parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DirectorySearchResponse</returns>
        public async System.Threading.Tasks.Task<DirectorySearchResponse> SearchParticipantsAsync(SearchParticipantsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DirectorySearchResponse> localVarResponse = await SearchParticipantsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of participants matching the input query. This endpoint provides a list of trading partners that match a specified input query. The search is performed based on various filters, search text, and other relevant parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DirectorySearchResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DirectorySearchResponse>> SearchParticipantsWithHttpInfoAsync(SearchParticipantsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TradingPartnersApi->SearchParticipants");

            // verify the required parameter 'requestParameters.Search' is set
            if (requestParameters.Search == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Search' when calling TradingPartnersApi->SearchParticipants");


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

            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$search", requestParameters.Search));
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
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<DirectorySearchResponse>("/einvoicing/trading-partners", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SearchParticipants", localVarResponse);
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
            this.Client.SdkVersion = "25.7.2";
        }
        
    }

    
}
