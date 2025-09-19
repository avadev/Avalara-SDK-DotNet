

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
    /// Represents the Request object for the GetMandateDataInputFields API
    /// </summary>
    public class GetMandateDataInputFieldsRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// The unique ID for the mandate that was returned in the GET /einvoicing/mandates response body
        /// </summary>
        public string MandateId { get; set; }
        /// <summary>
        /// Select the documentType for which you wish to view the data-input-fields (You may obtain the supported documentTypes from the GET /mandates endpoint)
        /// </summary>
        public string DocumentType { get; set; }
        /// <summary>
        /// Select the document version of the documentType (You may obtain the supported documentVersion from the GET /mandates endpoint)
        /// </summary>
        public string DocumentVersion { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetMandates API
    /// </summary>
    public class GetMandatesRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint.
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; and &lt;code&gt;contains&lt;/code&gt;. Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering.
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
        /// When set to true, the count of the collection is also returned in the response body.
        /// </summary>
        public bool? Count { get; set; }
        /// <summary>
        /// When set to true, only the count of the collection is returned
        /// </summary>
        public bool? CountOnly { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMandatesApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns document field information for a country mandate, a selected document type, and its version
        /// </summary>
        /// <remarks>
        /// This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET &lt;code&gt;/mandates&lt;/code&gt; endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the &#x60;documentType&#x60; and &#x60;documentVersion&#x60; query parameters to retrieve the input fields for a particular document type and document version.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>List&lt;MandateDataInputField&gt;</returns>
        List<MandateDataInputField> GetMandateDataInputFields(GetMandateDataInputFieldsRequestSdk requestParameters);

        /// <summary>
        /// List country mandates that are supported by the Avalara E-Invoicing platform
        /// </summary>
        /// <remarks>
        /// This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>MandatesResponse</returns>
        MandatesResponse GetMandates(GetMandatesRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMandatesApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns document field information for a country mandate, a selected document type, and its version
        /// </summary>
        /// <remarks>
        /// This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET &lt;code&gt;/mandates&lt;/code&gt; endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the &#x60;documentType&#x60; and &#x60;documentVersion&#x60; query parameters to retrieve the input fields for a particular document type and document version.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MandateDataInputField&gt;</returns>
        System.Threading.Tasks.Task<List<MandateDataInputField>> GetMandateDataInputFieldsAsync(GetMandateDataInputFieldsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List country mandates that are supported by the Avalara E-Invoicing platform
        /// </summary>
        /// <remarks>
        /// This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MandatesResponse</returns>
        System.Threading.Tasks.Task<MandatesResponse> GetMandatesAsync(GetMandatesRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MandatesApi : IMandatesApiSync, IMandatesApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatesApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public MandatesApi(Avalara.SDK.Client.IApiClient client)
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
        /// Returns document field information for a country mandate, a selected document type, and its version This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET &lt;code&gt;/mandates&lt;/code&gt; endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the &#x60;documentType&#x60; and &#x60;documentVersion&#x60; query parameters to retrieve the input fields for a particular document type and document version.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>List&lt;MandateDataInputField&gt;</returns>
        public List<MandateDataInputField> GetMandateDataInputFields(GetMandateDataInputFieldsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<List<MandateDataInputField>> localVarResponse = GetMandateDataInputFieldsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns document field information for a country mandate, a selected document type, and its version This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET &lt;code&gt;/mandates&lt;/code&gt; endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the &#x60;documentType&#x60; and &#x60;documentVersion&#x60; query parameters to retrieve the input fields for a particular document type and document version.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of List&lt;MandateDataInputField&gt;</returns>
        private Avalara.SDK.Client.ApiResponse<List<MandateDataInputField>> GetMandateDataInputFieldsWithHttpInfo(GetMandateDataInputFieldsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling MandatesApi->GetMandateDataInputFields");

            // verify the required parameter 'MandateId' is set
            if (requestParameters.MandateId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.MandateId' when calling MandatesApi->GetMandateDataInputFields");

            // verify the required parameter 'DocumentType' is set
            if (requestParameters.DocumentType == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentType' when calling MandatesApi->GetMandateDataInputFields");

            // verify the required parameter 'DocumentVersion' is set
            if (requestParameters.DocumentVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentVersion' when calling MandatesApi->GetMandateDataInputFields");

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

            localVarRequestOptions.PathParameters.Add("mandateId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.MandateId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", requestParameters.DocumentType));
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", requestParameters.DocumentVersion));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<MandateDataInputField>>("/einvoicing/mandates/{mandateId}/data-input-fields", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMandateDataInputFields", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns document field information for a country mandate, a selected document type, and its version This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET &lt;code&gt;/mandates&lt;/code&gt; endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the &#x60;documentType&#x60; and &#x60;documentVersion&#x60; query parameters to retrieve the input fields for a particular document type and document version.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MandateDataInputField&gt;</returns>
        public async System.Threading.Tasks.Task<List<MandateDataInputField>> GetMandateDataInputFieldsAsync(GetMandateDataInputFieldsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<List<MandateDataInputField>> localVarResponse = await GetMandateDataInputFieldsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns document field information for a country mandate, a selected document type, and its version This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET &lt;code&gt;/mandates&lt;/code&gt; endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the &#x60;documentType&#x60; and &#x60;documentVersion&#x60; query parameters to retrieve the input fields for a particular document type and document version.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;MandateDataInputField&gt;)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<List<MandateDataInputField>>> GetMandateDataInputFieldsWithHttpInfoAsync(GetMandateDataInputFieldsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling MandatesApi->GetMandateDataInputFields");

            // verify the required parameter 'requestParameters.MandateId' is set
            if (requestParameters.MandateId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.MandateId' when calling MandatesApi->GetMandateDataInputFields");

            // verify the required parameter 'requestParameters.DocumentType' is set
            if (requestParameters.DocumentType == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentType' when calling MandatesApi->GetMandateDataInputFields");

            // verify the required parameter 'requestParameters.DocumentVersion' is set
            if (requestParameters.DocumentVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.DocumentVersion' when calling MandatesApi->GetMandateDataInputFields");


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

            localVarRequestOptions.PathParameters.Add("mandateId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.MandateId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", requestParameters.DocumentType));
            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", requestParameters.DocumentVersion));
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<List<MandateDataInputField>>("/einvoicing/mandates/{mandateId}/data-input-fields", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMandateDataInputFields", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List country mandates that are supported by the Avalara E-Invoicing platform This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>MandatesResponse</returns>
        public MandatesResponse GetMandates(GetMandatesRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<MandatesResponse> localVarResponse = GetMandatesWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List country mandates that are supported by the Avalara E-Invoicing platform This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of MandatesResponse</returns>
        private Avalara.SDK.Client.ApiResponse<MandatesResponse> GetMandatesWithHttpInfo(GetMandatesRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling MandatesApi->GetMandates");

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
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MandatesResponse>("/einvoicing/mandates", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMandates", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List country mandates that are supported by the Avalara E-Invoicing platform This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MandatesResponse</returns>
        public async System.Threading.Tasks.Task<MandatesResponse> GetMandatesAsync(GetMandatesRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<MandatesResponse> localVarResponse = await GetMandatesWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List country mandates that are supported by the Avalara E-Invoicing platform This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MandatesResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<MandatesResponse>> GetMandatesWithHttpInfoAsync(GetMandatesRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling MandatesApi->GetMandates");


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
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<MandatesResponse>("/einvoicing/mandates", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMandates", localVarResponse);
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
