

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
    /// Represents the Request object for the GetDataInputFields API
    /// </summary>
    public class GetDataInputFieldsRequestSdk {
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
        /// When set to true, the count of the collection is also returned in the response body
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
    public interface IDataInputFieldsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the optionality of document fields for different country mandates
        /// </summary>
        /// <remarks>
        /// This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the &lt;code&gt;mandates&lt;/code&gt; endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DataInputFieldsResponse</returns>
        DataInputFieldsResponse GetDataInputFields(GetDataInputFieldsRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataInputFieldsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns the optionality of document fields for different country mandates
        /// </summary>
        /// <remarks>
        /// This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the &lt;code&gt;mandates&lt;/code&gt; endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataInputFieldsResponse</returns>
        System.Threading.Tasks.Task<DataInputFieldsResponse> GetDataInputFieldsAsync(GetDataInputFieldsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataInputFieldsApi : IDataInputFieldsApiSync, IDataInputFieldsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="DataInputFieldsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public DataInputFieldsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Returns the optionality of document fields for different country mandates This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the &lt;code&gt;mandates&lt;/code&gt; endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>DataInputFieldsResponse</returns>
        public DataInputFieldsResponse GetDataInputFields(GetDataInputFieldsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<DataInputFieldsResponse> localVarResponse = GetDataInputFieldsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the optionality of document fields for different country mandates This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the &lt;code&gt;mandates&lt;/code&gt; endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of DataInputFieldsResponse</returns>
        private Avalara.SDK.Client.ApiResponse<DataInputFieldsResponse> GetDataInputFieldsWithHttpInfo(GetDataInputFieldsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DataInputFieldsApi->GetDataInputFields");

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
            var localVarResponse = this.Client.Get<DataInputFieldsResponse>("/einvoicing/data-input-fields", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataInputFields", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the optionality of document fields for different country mandates This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the &lt;code&gt;mandates&lt;/code&gt; endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataInputFieldsResponse</returns>
        public async System.Threading.Tasks.Task<DataInputFieldsResponse> GetDataInputFieldsAsync(GetDataInputFieldsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DataInputFieldsResponse> localVarResponse = await GetDataInputFieldsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the optionality of document fields for different country mandates This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the &lt;code&gt;mandates&lt;/code&gt; endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataInputFieldsResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DataInputFieldsResponse>> GetDataInputFieldsWithHttpInfoAsync(GetDataInputFieldsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling DataInputFieldsApi->GetDataInputFields");


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
			var localVarResponse = await this.Client.GetAsync<DataInputFieldsResponse>("/einvoicing/data-input-fields", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataInputFields", localVarResponse);
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
            this.Client.SdkVersion = "25.8.2";
        }
        
    }

    
}
