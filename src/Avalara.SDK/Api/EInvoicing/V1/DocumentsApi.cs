

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
    /// Represents the Request object for the DownloadDocument API
    /// </summary>
    public class DownloadDocumentRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// This header indicates the MIME type of the document
        /// </summary>
        public string Accept { get; set; }
        /// <summary>
        /// The unique ID for this document that was returned in the POST /einvoicing/document response body
        /// </summary>
        public string DocumentId { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the FetchDocuments API
    /// </summary>
    public class FetchDocumentsRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// 
        /// </summary>
        public FetchDocumentsRequest FetchDocumentsRequest { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetDocumentList API
    /// </summary>
    public class GetDocumentListRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Start date of documents to return. This defaults to the previous month.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// End date of documents to return. This defaults to the current date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Optionally filter by document direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;
        /// </summary>
        public string Flow { get; set; }
        /// <summary>
        /// When set to true, the count of the collection is also returned in the response body
        /// </summary>
        public string Count { get; set; }
        /// <summary>
        /// When set to true, only the count of the collection is returned
        /// </summary>
        public string CountOnly { get; set; }
        /// <summary>
        /// Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; . Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided startDate and endDate. If no startDate or endDate is provided, defaults will be assumed.
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
    }

    /// <summary>
    /// Represents the Request object for the GetDocumentStatus API
    /// </summary>
    public class GetDocumentStatusRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// The unique ID for this document that was returned in the POST /einvoicing/documents response body
        /// </summary>
        public string DocumentId { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the SubmitDocument API
    /// </summary>
    public class SubmitDocumentRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// 
        /// </summary>
        public SubmitDocumentMetadata Metadata { get; set; }
        /// <summary>
        /// The document to be submitted, as indicated by the metadata fields &#39;dataFormat&#39; and &#39;dataFormatVersion&#39;
        /// </summary>
        public Object Data { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a copy of the document
        /// </summary>
        /// <remarks>
        /// When the document is available, use this endpoint to download it as text, XML, or PDF. The output format needs to be specified in the Accept header, and it will vary depending on the mandate. If the file has not yet been created, then status code 404 (not found) is returned.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FileParameter</returns>
        FileParameter DownloadDocument(DownloadDocumentRequestSdk requestParameters);

        /// <summary>
        /// Fetch the inbound document from a tax authority
        /// </summary>
        /// <remarks>
        /// This API allows you to retrieve an inbound document. Pass key-value pairs as parameters in the request, such as the confirmation number, supplier number, and buyer VAT number.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentFetch</returns>
        DocumentFetch FetchDocuments(FetchDocumentsRequestSdk requestParameters);

        /// <summary>
        /// Returns a summary of documents for a date range
        /// </summary>
        /// <remarks>
        /// Get a list of documents on the Avalara E-Invoicing platform that have a processing date within the specified date range.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentListResponse</returns>
        DocumentListResponse GetDocumentList(GetDocumentListRequestSdk requestParameters);

        /// <summary>
        /// Checks the status of a document
        /// </summary>
        /// <remarks>
        /// Using the unique ID from POST /einvoicing/documents response body, request the current status of a document.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentStatusResponse</returns>
        DocumentStatusResponse GetDocumentStatus(GetDocumentStatusRequestSdk requestParameters);

        /// <summary>
        /// Submits a document to Avalara E-Invoicing API
        /// </summary>
        /// <remarks>
        /// When a UBL document is sent to this endpoint, it generates a document in the required format as mandated by the specified country. Additionally, it initiates the workflow to transmit the generated document to the relevant tax authority, if necessary.&lt;br&gt;&lt;br&gt;The response from the endpoint contains a unique document ID, which can be used to request the status of the document and verify if it was successfully accepted at the destination.&lt;br&gt;&lt;br&gt;Furthermore, the unique ID enables the download of a copy of the generated document for reference purposes.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentSubmitResponse</returns>
        DocumentSubmitResponse SubmitDocument(SubmitDocumentRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns a copy of the document
        /// </summary>
        /// <remarks>
        /// When the document is available, use this endpoint to download it as text, XML, or PDF. The output format needs to be specified in the Accept header, and it will vary depending on the mandate. If the file has not yet been created, then status code 404 (not found) is returned.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> DownloadDocumentAsync(DownloadDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fetch the inbound document from a tax authority
        /// </summary>
        /// <remarks>
        /// This API allows you to retrieve an inbound document. Pass key-value pairs as parameters in the request, such as the confirmation number, supplier number, and buyer VAT number.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentFetch</returns>
        System.Threading.Tasks.Task<DocumentFetch> FetchDocumentsAsync(FetchDocumentsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns a summary of documents for a date range
        /// </summary>
        /// <remarks>
        /// Get a list of documents on the Avalara E-Invoicing platform that have a processing date within the specified date range.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentListResponse</returns>
        System.Threading.Tasks.Task<DocumentListResponse> GetDocumentListAsync(GetDocumentListRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Checks the status of a document
        /// </summary>
        /// <remarks>
        /// Using the unique ID from POST /einvoicing/documents response body, request the current status of a document.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentStatusResponse</returns>
        System.Threading.Tasks.Task<DocumentStatusResponse> GetDocumentStatusAsync(GetDocumentStatusRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Submits a document to Avalara E-Invoicing API
        /// </summary>
        /// <remarks>
        /// When a UBL document is sent to this endpoint, it generates a document in the required format as mandated by the specified country. Additionally, it initiates the workflow to transmit the generated document to the relevant tax authority, if necessary.&lt;br&gt;&lt;br&gt;The response from the endpoint contains a unique document ID, which can be used to request the status of the document and verify if it was successfully accepted at the destination.&lt;br&gt;&lt;br&gt;Furthermore, the unique ID enables the download of a copy of the generated document for reference purposes.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentSubmitResponse</returns>
        System.Threading.Tasks.Task<DocumentSubmitResponse> SubmitDocumentAsync(SubmitDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocumentsApi : IDocumentsApiSync, IDocumentsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public DocumentsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Returns a copy of the document When the document is available, use this endpoint to download it as text, XML, or PDF. The output format needs to be specified in the Accept header, and it will vary depending on the mandate. If the file has not yet been created, then status code 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FileParameter</returns>
        public FileParameter DownloadDocument(DownloadDocumentRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FileParameter> localVarResponse = DownloadDocumentWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a copy of the document When the document is available, use this endpoint to download it as text, XML, or PDF. The output format needs to be specified in the Accept header, and it will vary depending on the mandate. If the file has not yet been created, then status code 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FileParameter</returns>
        private Avalara.SDK.Client.ApiResponse<FileParameter> DownloadDocumentWithHttpInfo(DownloadDocumentRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->DownloadDocument");

            // verify the required parameter 'Accept' is set
            if (requestParameters.Accept == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Accept' when calling DocumentsApi->DownloadDocument");

            // verify the required parameter 'DocumentId' is set
            if (requestParameters.DocumentId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentId' when calling DocumentsApi->DownloadDocument");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/pdf",
                "application/xml",
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("documentId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.DocumentId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("Accept", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Accept)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileParameter>("/einvoicing/documents/{documentId}/$download", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadDocument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a copy of the document When the document is available, use this endpoint to download it as text, XML, or PDF. The output format needs to be specified in the Accept header, and it will vary depending on the mandate. If the file has not yet been created, then status code 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> DownloadDocumentAsync(DownloadDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FileParameter> localVarResponse = await DownloadDocumentWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a copy of the document When the document is available, use this endpoint to download it as text, XML, or PDF. The output format needs to be specified in the Accept header, and it will vary depending on the mandate. If the file has not yet been created, then status code 404 (not found) is returned.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FileParameter>> DownloadDocumentWithHttpInfoAsync(DownloadDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->DownloadDocument");

            // verify the required parameter 'requestParameters.Accept' is set
            if (requestParameters.Accept == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Accept' when calling DocumentsApi->DownloadDocument");

            // verify the required parameter 'requestParameters.DocumentId' is set
            if (requestParameters.DocumentId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentId' when calling DocumentsApi->DownloadDocument");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/pdf",
                "application/xml",
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("documentId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.DocumentId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("Accept", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Accept)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<FileParameter>("/einvoicing/documents/{documentId}/$download", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadDocument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch the inbound document from a tax authority This API allows you to retrieve an inbound document. Pass key-value pairs as parameters in the request, such as the confirmation number, supplier number, and buyer VAT number.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentFetch</returns>
        public DocumentFetch FetchDocuments(FetchDocumentsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<DocumentFetch> localVarResponse = FetchDocumentsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch the inbound document from a tax authority This API allows you to retrieve an inbound document. Pass key-value pairs as parameters in the request, such as the confirmation number, supplier number, and buyer VAT number.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of DocumentFetch</returns>
        private Avalara.SDK.Client.ApiResponse<DocumentFetch> FetchDocumentsWithHttpInfo(FetchDocumentsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->FetchDocuments");

            // verify the required parameter 'FetchDocumentsRequest' is set
            if (requestParameters.FetchDocumentsRequest == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FetchDocumentsRequest' when calling DocumentsApi->FetchDocuments");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.FetchDocumentsRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<DocumentFetch>("/einvoicing/documents/$fetch", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchDocuments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch the inbound document from a tax authority This API allows you to retrieve an inbound document. Pass key-value pairs as parameters in the request, such as the confirmation number, supplier number, and buyer VAT number.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentFetch</returns>
        public async System.Threading.Tasks.Task<DocumentFetch> FetchDocumentsAsync(FetchDocumentsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DocumentFetch> localVarResponse = await FetchDocumentsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch the inbound document from a tax authority This API allows you to retrieve an inbound document. Pass key-value pairs as parameters in the request, such as the confirmation number, supplier number, and buyer VAT number.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentFetch)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DocumentFetch>> FetchDocumentsWithHttpInfoAsync(FetchDocumentsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->FetchDocuments");

            // verify the required parameter 'requestParameters.FetchDocumentsRequest' is set
            if (requestParameters.FetchDocumentsRequest == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.FetchDocumentsRequest' when calling DocumentsApi->FetchDocuments");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.FetchDocumentsRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<DocumentFetch>("/einvoicing/documents/$fetch", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchDocuments", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a summary of documents for a date range Get a list of documents on the Avalara E-Invoicing platform that have a processing date within the specified date range.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentListResponse</returns>
        public DocumentListResponse GetDocumentList(GetDocumentListRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<DocumentListResponse> localVarResponse = GetDocumentListWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summary of documents for a date range Get a list of documents on the Avalara E-Invoicing platform that have a processing date within the specified date range.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of DocumentListResponse</returns>
        private Avalara.SDK.Client.ApiResponse<DocumentListResponse> GetDocumentListWithHttpInfo(GetDocumentListRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->GetDocumentList");

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

            if (requestParameters.StartDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "startDate", requestParameters.StartDate));
            }
            if (requestParameters.EndDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "endDate", requestParameters.EndDate));
            }
            if (requestParameters.Flow != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "flow", requestParameters.Flow));
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$countOnly", requestParameters.CountOnly));
            }
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
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DocumentListResponse>("/einvoicing/documents", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDocumentList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a summary of documents for a date range Get a list of documents on the Avalara E-Invoicing platform that have a processing date within the specified date range.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentListResponse</returns>
        public async System.Threading.Tasks.Task<DocumentListResponse> GetDocumentListAsync(GetDocumentListRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DocumentListResponse> localVarResponse = await GetDocumentListWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summary of documents for a date range Get a list of documents on the Avalara E-Invoicing platform that have a processing date within the specified date range.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentListResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DocumentListResponse>> GetDocumentListWithHttpInfoAsync(GetDocumentListRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->GetDocumentList");


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

            if (requestParameters.StartDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "startDate", requestParameters.StartDate));
            }
            if (requestParameters.EndDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "endDate", requestParameters.EndDate));
            }
            if (requestParameters.Flow != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "flow", requestParameters.Flow));
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$countOnly", requestParameters.CountOnly));
            }
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
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<DocumentListResponse>("/einvoicing/documents", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDocumentList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Checks the status of a document Using the unique ID from POST /einvoicing/documents response body, request the current status of a document.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentStatusResponse</returns>
        public DocumentStatusResponse GetDocumentStatus(GetDocumentStatusRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<DocumentStatusResponse> localVarResponse = GetDocumentStatusWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Checks the status of a document Using the unique ID from POST /einvoicing/documents response body, request the current status of a document.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of DocumentStatusResponse</returns>
        private Avalara.SDK.Client.ApiResponse<DocumentStatusResponse> GetDocumentStatusWithHttpInfo(GetDocumentStatusRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->GetDocumentStatus");

            // verify the required parameter 'DocumentId' is set
            if (requestParameters.DocumentId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentId' when calling DocumentsApi->GetDocumentStatus");

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

            localVarRequestOptions.PathParameters.Add("documentId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.DocumentId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DocumentStatusResponse>("/einvoicing/documents/{documentId}/status", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDocumentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Checks the status of a document Using the unique ID from POST /einvoicing/documents response body, request the current status of a document.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentStatusResponse</returns>
        public async System.Threading.Tasks.Task<DocumentStatusResponse> GetDocumentStatusAsync(GetDocumentStatusRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DocumentStatusResponse> localVarResponse = await GetDocumentStatusWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Checks the status of a document Using the unique ID from POST /einvoicing/documents response body, request the current status of a document.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentStatusResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DocumentStatusResponse>> GetDocumentStatusWithHttpInfoAsync(GetDocumentStatusRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->GetDocumentStatus");

            // verify the required parameter 'requestParameters.DocumentId' is set
            if (requestParameters.DocumentId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentId' when calling DocumentsApi->GetDocumentStatus");


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

            localVarRequestOptions.PathParameters.Add("documentId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.DocumentId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<DocumentStatusResponse>("/einvoicing/documents/{documentId}/status", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDocumentStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submits a document to Avalara E-Invoicing API When a UBL document is sent to this endpoint, it generates a document in the required format as mandated by the specified country. Additionally, it initiates the workflow to transmit the generated document to the relevant tax authority, if necessary.&lt;br&gt;&lt;br&gt;The response from the endpoint contains a unique document ID, which can be used to request the status of the document and verify if it was successfully accepted at the destination.&lt;br&gt;&lt;br&gt;Furthermore, the unique ID enables the download of a copy of the generated document for reference purposes.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DocumentSubmitResponse</returns>
        public DocumentSubmitResponse SubmitDocument(SubmitDocumentRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<DocumentSubmitResponse> localVarResponse = SubmitDocumentWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a document to Avalara E-Invoicing API When a UBL document is sent to this endpoint, it generates a document in the required format as mandated by the specified country. Additionally, it initiates the workflow to transmit the generated document to the relevant tax authority, if necessary.&lt;br&gt;&lt;br&gt;The response from the endpoint contains a unique document ID, which can be used to request the status of the document and verify if it was successfully accepted at the destination.&lt;br&gt;&lt;br&gt;Furthermore, the unique ID enables the download of a copy of the generated document for reference purposes.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of DocumentSubmitResponse</returns>
        private Avalara.SDK.Client.ApiResponse<DocumentSubmitResponse> SubmitDocumentWithHttpInfo(SubmitDocumentRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->SubmitDocument");

            // verify the required parameter 'Metadata' is set
            if (requestParameters.Metadata == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Metadata' when calling DocumentsApi->SubmitDocument");

            // verify the required parameter 'Data' is set
            if (requestParameters.Data == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Data' when calling DocumentsApi->SubmitDocument");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.FormParameters.Add("metadata", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Metadata)); // form parameter
            localVarRequestOptions.FormParameters.Add("data", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Data)); // form parameter

            // make the HTTP request
            var localVarResponse = this.Client.Post<DocumentSubmitResponse>("/einvoicing/documents", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubmitDocument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submits a document to Avalara E-Invoicing API When a UBL document is sent to this endpoint, it generates a document in the required format as mandated by the specified country. Additionally, it initiates the workflow to transmit the generated document to the relevant tax authority, if necessary.&lt;br&gt;&lt;br&gt;The response from the endpoint contains a unique document ID, which can be used to request the status of the document and verify if it was successfully accepted at the destination.&lt;br&gt;&lt;br&gt;Furthermore, the unique ID enables the download of a copy of the generated document for reference purposes.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentSubmitResponse</returns>
        public async System.Threading.Tasks.Task<DocumentSubmitResponse> SubmitDocumentAsync(SubmitDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DocumentSubmitResponse> localVarResponse = await SubmitDocumentWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a document to Avalara E-Invoicing API When a UBL document is sent to this endpoint, it generates a document in the required format as mandated by the specified country. Additionally, it initiates the workflow to transmit the generated document to the relevant tax authority, if necessary.&lt;br&gt;&lt;br&gt;The response from the endpoint contains a unique document ID, which can be used to request the status of the document and verify if it was successfully accepted at the destination.&lt;br&gt;&lt;br&gt;Furthermore, the unique ID enables the download of a copy of the generated document for reference purposes.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentSubmitResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DocumentSubmitResponse>> SubmitDocumentWithHttpInfoAsync(SubmitDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DocumentsApi->SubmitDocument");

            // verify the required parameter 'requestParameters.Metadata' is set
            if (requestParameters.Metadata == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Metadata' when calling DocumentsApi->SubmitDocument");

            // verify the required parameter 'requestParameters.Data' is set
            if (requestParameters.Data == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Data' when calling DocumentsApi->SubmitDocument");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/xml"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.FormParameters.Add("metadata", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Metadata)); // form parameter
            localVarRequestOptions.FormParameters.Add("data", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Data)); // form parameter

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<DocumentSubmitResponse>("/einvoicing/documents", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubmitDocument", localVarResponse);
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
            this.Client.SdkVersion = "25.9.0";
        }
        
    }

    
}
