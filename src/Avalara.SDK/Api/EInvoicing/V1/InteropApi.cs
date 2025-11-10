

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
    /// Represents the Request object for the SubmitInteropDocument API
    /// </summary>
    public class SubmitInteropDocumentRequestSdk {
        /// <summary>
        /// Type of the document being uploaded. Partners will be configured in Avalara system to send only certain types of documents.
        /// </summary>
        public string DocumentType { get; set; }
        /// <summary>
        /// Type of interchange (codes in Avalara system that uniquely identifies a type of interchange). Partners will be configured in Avalara system to send documents belonging to certain types of interchanges.
        /// </summary>
        public string InterchangeType { get; set; }
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// The file to be uploaded (e.g., UBL XML, CII XML).
        /// </summary>
        public FileParameter FileName { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInteropApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Submit a document
        /// </summary>
        /// <remarks>
        /// This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SubmitInteropDocument202Response</returns>
        SubmitInteropDocument202Response SubmitInteropDocument(SubmitInteropDocumentRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInteropApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Submit a document
        /// </summary>
        /// <remarks>
        /// This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubmitInteropDocument202Response</returns>
        System.Threading.Tasks.Task<SubmitInteropDocument202Response> SubmitInteropDocumentAsync(SubmitInteropDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InteropApi : IInteropApiSync, IInteropApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="InteropApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public InteropApi(Avalara.SDK.Client.IApiClient client)
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
        /// Submit a document This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SubmitInteropDocument202Response</returns>
        public SubmitInteropDocument202Response SubmitInteropDocument(SubmitInteropDocumentRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<SubmitInteropDocument202Response> localVarResponse = SubmitInteropDocumentWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a document This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of SubmitInteropDocument202Response</returns>
        private Avalara.SDK.Client.ApiResponse<SubmitInteropDocument202Response> SubmitInteropDocumentWithHttpInfo(SubmitInteropDocumentRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'DocumentType' is set
            if (requestParameters.DocumentType == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentType' when calling InteropApi->SubmitInteropDocument");

            // verify the required parameter 'InterchangeType' is set
            if (requestParameters.InterchangeType == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.InterchangeType' when calling InteropApi->SubmitInteropDocument");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling InteropApi->SubmitInteropDocument");

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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", requestParameters.DocumentType));
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "interchangeType", requestParameters.InterchangeType));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.FileName != null)
            {
                localVarRequestOptions.FileParameters.Add("fileName", requestParameters.FileName);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SubmitInteropDocument202Response>("/einvoicing/interop/documents", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubmitInteropDocument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit a document This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubmitInteropDocument202Response</returns>
        public async System.Threading.Tasks.Task<SubmitInteropDocument202Response> SubmitInteropDocumentAsync(SubmitInteropDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<SubmitInteropDocument202Response> localVarResponse = await SubmitInteropDocumentWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a document This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubmitInteropDocument202Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<SubmitInteropDocument202Response>> SubmitInteropDocumentWithHttpInfoAsync(SubmitInteropDocumentRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.DocumentType' is set
            if (requestParameters.DocumentType == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentType' when calling InteropApi->SubmitInteropDocument");

            // verify the required parameter 'requestParameters.InterchangeType' is set
            if (requestParameters.InterchangeType == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.InterchangeType' when calling InteropApi->SubmitInteropDocument");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling InteropApi->SubmitInteropDocument");


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
            if (localVarAccept != null && !localVarRequestOptions.HeaderParameters.ContainsKey("Accept")) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", requestParameters.DocumentType));
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "interchangeType", requestParameters.InterchangeType));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.FileName != null)
            {
                localVarRequestOptions.FileParameters.Add("fileName", requestParameters.FileName);
            }

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<SubmitInteropDocument202Response>("/einvoicing/interop/documents", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SubmitInteropDocument", localVarResponse);
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
            this.Client.SdkVersion = "25.11.1";
        }
        
    }

    
}
