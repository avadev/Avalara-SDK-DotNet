

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
    /// Represents the Request object for the DownloadReport API
    /// </summary>
    public class DownloadReportRequestSdk {
        /// <summary>
        /// Header that specifies the API version to use (for example \&quot;1.6\&quot;).
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.6";
        /// <summary>
        /// The unique ID for this report as returned in a GET /reports response.
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;).
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;).
        /// </summary>
        public string XCorrelationID { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetReportById API
    /// </summary>
    public class GetReportByIdRequestSdk {
        /// <summary>
        /// Header that specifies the API version to use (for example \&quot;1.6\&quot;).
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.6";
        /// <summary>
        /// The unique ID for this report as returned in a GET /reports response.
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;).
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;).
        /// </summary>
        public string XCorrelationID { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetReports API
    /// </summary>
    public class GetReportsRequestSdk {
        /// <summary>
        /// Header that specifies the API version to use (for example \&quot;1.6\&quot;).
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.6";
        /// <summary>
        /// Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;).
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;).
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// OData-style filter expression. Supports operators: eq, ne, gt, ge, lt, le, like, ilike, contains. Examples: status eq &#39;COMPLETED&#39;, reportGenerateDate gt &#39;2025-11-01&#39;, transactionIds contains &#39;TXN-2025-001&#39;
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// The number of items to include in the result.
        /// </summary>
        public int? Top { get; set; }
        /// <summary>
        /// The number of items to skip in the result.
        /// </summary>
        public int? Skip { get; set; }
        /// <summary>
        /// When set to true, the response body also includes the count of items in the collection.
        /// </summary>
        public string Count { get; set; }
        /// <summary>
        /// When set to true, the response returns only the count of items in the collection.
        /// </summary>
        public string CountOnly { get; set; }
        /// <summary>
        /// OData-style orderby expression. Format: &#39;field asc&#39; or &#39;field desc&#39;. Default: reportGenerateDate desc
        /// </summary>
        public string Orderby { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a pre-signed download URL for a report
        /// </summary>
        /// <remarks>
        /// Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ReportDownloadResponse</returns>
        ReportDownloadResponse DownloadReport(DownloadReportRequestSdk requestParameters);

        /// <summary>
        /// Retrieves a report by its unique ID
        /// </summary>
        /// <remarks>
        /// Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ReportItem</returns>
        ReportItem GetReportById(GetReportByIdRequestSdk requestParameters);

        /// <summary>
        /// Returns a list of reports
        /// </summary>
        /// <remarks>
        /// Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ReportListResponse</returns>
        ReportListResponse GetReports(GetReportsRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns a pre-signed download URL for a report
        /// </summary>
        /// <remarks>
        /// Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportDownloadResponse</returns>
        System.Threading.Tasks.Task<ReportDownloadResponse> DownloadReportAsync(DownloadReportRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves a report by its unique ID
        /// </summary>
        /// <remarks>
        /// Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportItem</returns>
        System.Threading.Tasks.Task<ReportItem> GetReportByIdAsync(GetReportByIdRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns a list of reports
        /// </summary>
        /// <remarks>
        /// Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportListResponse</returns>
        System.Threading.Tasks.Task<ReportListResponse> GetReportsAsync(GetReportsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportsApi : IReportsApiSync, IReportsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public ReportsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Returns a pre-signed download URL for a report Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ReportDownloadResponse</returns>
        public ReportDownloadResponse DownloadReport(DownloadReportRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<ReportDownloadResponse> localVarResponse = DownloadReportWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a pre-signed download URL for a report Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of ReportDownloadResponse</returns>
        private Avalara.SDK.Client.ApiResponse<ReportDownloadResponse> DownloadReportWithHttpInfo(DownloadReportRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling ReportsApi->DownloadReport");

            // verify the required parameter 'ReportId' is set
            if (requestParameters.ReportId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.ReportId' when calling ReportsApi->DownloadReport");

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

            localVarRequestOptions.PathParameters.Add("reportId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.ReportId)); // path parameter
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
            var localVarResponse = this.Client.Get<ReportDownloadResponse>("/einvoicing/reports/{reportId}/$download", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a pre-signed download URL for a report Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportDownloadResponse</returns>
        public async System.Threading.Tasks.Task<ReportDownloadResponse> DownloadReportAsync(DownloadReportRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<ReportDownloadResponse> localVarResponse = await DownloadReportWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a pre-signed download URL for a report Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportDownloadResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<ReportDownloadResponse>> DownloadReportWithHttpInfoAsync(DownloadReportRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling ReportsApi->DownloadReport");

            // verify the required parameter 'requestParameters.ReportId' is set
            if (requestParameters.ReportId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.ReportId' when calling ReportsApi->DownloadReport");


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

            localVarRequestOptions.PathParameters.Add("reportId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.ReportId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<ReportDownloadResponse>("/einvoicing/reports/{reportId}/$download", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a report by its unique ID Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ReportItem</returns>
        public ReportItem GetReportById(GetReportByIdRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<ReportItem> localVarResponse = GetReportByIdWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a report by its unique ID Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of ReportItem</returns>
        private Avalara.SDK.Client.ApiResponse<ReportItem> GetReportByIdWithHttpInfo(GetReportByIdRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling ReportsApi->GetReportById");

            // verify the required parameter 'ReportId' is set
            if (requestParameters.ReportId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.ReportId' when calling ReportsApi->GetReportById");

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

            localVarRequestOptions.PathParameters.Add("reportId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.ReportId)); // path parameter
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
            var localVarResponse = this.Client.Get<ReportItem>("/einvoicing/reports/{reportId}/status", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReportById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a report by its unique ID Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportItem</returns>
        public async System.Threading.Tasks.Task<ReportItem> GetReportByIdAsync(GetReportByIdRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<ReportItem> localVarResponse = await GetReportByIdWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a report by its unique ID Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportItem)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<ReportItem>> GetReportByIdWithHttpInfoAsync(GetReportByIdRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling ReportsApi->GetReportById");

            // verify the required parameter 'requestParameters.ReportId' is set
            if (requestParameters.ReportId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.ReportId' when calling ReportsApi->GetReportById");


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

            localVarRequestOptions.PathParameters.Add("reportId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.ReportId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<ReportItem>("/einvoicing/reports/{reportId}/status", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReportById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of reports Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ReportListResponse</returns>
        public ReportListResponse GetReports(GetReportsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<ReportListResponse> localVarResponse = GetReportsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of reports Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of ReportListResponse</returns>
        private Avalara.SDK.Client.ApiResponse<ReportListResponse> GetReportsWithHttpInfo(GetReportsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling ReportsApi->GetReports");

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
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$countOnly", requestParameters.CountOnly));
            }
            if (requestParameters.Orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderby", requestParameters.Orderby));
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
            var localVarResponse = this.Client.Get<ReportListResponse>("/einvoicing/reports", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReports", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of reports Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportListResponse</returns>
        public async System.Threading.Tasks.Task<ReportListResponse> GetReportsAsync(GetReportsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<ReportListResponse> localVarResponse = await GetReportsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of reports Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportListResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<ReportListResponse>> GetReportsWithHttpInfoAsync(GetReportsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling ReportsApi->GetReports");


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
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$countOnly", requestParameters.CountOnly));
            }
            if (requestParameters.Orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderby", requestParameters.Orderby));
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
			var localVarResponse = await this.Client.GetAsync<ReportListResponse>("/einvoicing/reports", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReports", localVarResponse);
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
            this.Client.SdkVersion = "26.4.0";
        }
        
    }

    
}
