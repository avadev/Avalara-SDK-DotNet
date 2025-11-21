

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
    /// Represents the Request object for the TaxIdentifierSchemaByCountry API
    /// </summary>
    public class TaxIdentifierSchemaByCountryRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used.
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// The two-letter ISO-3166 country code for which the schema should be retrieved.
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;.
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// Specifies whether to return the request or response schema.
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the ValidateTaxIdentifier API
    /// </summary>
    public class ValidateTaxIdentifierRequestSdk {
        /// <summary>
        /// The HTTP Header meant to specify the version of the API intended to be used.
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// 
        /// </summary>
        public TaxIdentifierRequest TaxIdentifierRequest { get; set; }
        /// <summary>
        /// You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;.
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The caller can use this as an identifier to use as a correlation id to trace the call.
        /// </summary>
        public string XCorrelationID { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxIdentifiersApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the tax identifier request &amp; response schema for a specific country.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country&#39;s requirements. This can include both standard fields and any additional parameters required by the respective country&#39;s tax authority.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>TaxIdentifierSchemaByCountry200Response</returns>
        TaxIdentifierSchemaByCountry200Response TaxIdentifierSchemaByCountry(TaxIdentifierSchemaByCountryRequestSdk requestParameters);

        /// <summary>
        /// Validates a tax identifier.
        /// </summary>
        /// <remarks>
        /// This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>TaxIdentifierResponse</returns>
        TaxIdentifierResponse ValidateTaxIdentifier(ValidateTaxIdentifierRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxIdentifiersApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns the tax identifier request &amp; response schema for a specific country.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country&#39;s requirements. This can include both standard fields and any additional parameters required by the respective country&#39;s tax authority.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TaxIdentifierSchemaByCountry200Response</returns>
        System.Threading.Tasks.Task<TaxIdentifierSchemaByCountry200Response> TaxIdentifierSchemaByCountryAsync(TaxIdentifierSchemaByCountryRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Validates a tax identifier.
        /// </summary>
        /// <remarks>
        /// This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TaxIdentifierResponse</returns>
        System.Threading.Tasks.Task<TaxIdentifierResponse> ValidateTaxIdentifierAsync(ValidateTaxIdentifierRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaxIdentifiersApi : ITaxIdentifiersApiSync, ITaxIdentifiersApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxIdentifiersApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public TaxIdentifiersApi(Avalara.SDK.Client.IApiClient client)
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
        /// Returns the tax identifier request &amp; response schema for a specific country. This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country&#39;s requirements. This can include both standard fields and any additional parameters required by the respective country&#39;s tax authority.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>TaxIdentifierSchemaByCountry200Response</returns>
        public TaxIdentifierSchemaByCountry200Response TaxIdentifierSchemaByCountry(TaxIdentifierSchemaByCountryRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<TaxIdentifierSchemaByCountry200Response> localVarResponse = TaxIdentifierSchemaByCountryWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the tax identifier request &amp; response schema for a specific country. This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country&#39;s requirements. This can include both standard fields and any additional parameters required by the respective country&#39;s tax authority.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of TaxIdentifierSchemaByCountry200Response</returns>
        private Avalara.SDK.Client.ApiResponse<TaxIdentifierSchemaByCountry200Response> TaxIdentifierSchemaByCountryWithHttpInfo(TaxIdentifierSchemaByCountryRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TaxIdentifiersApi->TaxIdentifierSchemaByCountry");

            // verify the required parameter 'CountryCode' is set
            if (requestParameters.CountryCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.CountryCode' when calling TaxIdentifiersApi->TaxIdentifierSchemaByCountry");

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

            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countryCode", requestParameters.CountryCode));
            if (requestParameters.Type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "type", requestParameters.Type));
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
            var localVarResponse = this.Client.Get<TaxIdentifierSchemaByCountry200Response>("/einvoicing/tax-identifiers/schema", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TaxIdentifierSchemaByCountry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the tax identifier request &amp; response schema for a specific country. This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country&#39;s requirements. This can include both standard fields and any additional parameters required by the respective country&#39;s tax authority.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TaxIdentifierSchemaByCountry200Response</returns>
        public async System.Threading.Tasks.Task<TaxIdentifierSchemaByCountry200Response> TaxIdentifierSchemaByCountryAsync(TaxIdentifierSchemaByCountryRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<TaxIdentifierSchemaByCountry200Response> localVarResponse = await TaxIdentifierSchemaByCountryWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the tax identifier request &amp; response schema for a specific country. This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country&#39;s requirements. This can include both standard fields and any additional parameters required by the respective country&#39;s tax authority.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TaxIdentifierSchemaByCountry200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<TaxIdentifierSchemaByCountry200Response>> TaxIdentifierSchemaByCountryWithHttpInfoAsync(TaxIdentifierSchemaByCountryRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TaxIdentifiersApi->TaxIdentifierSchemaByCountry");

            // verify the required parameter 'requestParameters.CountryCode' is set
            if (requestParameters.CountryCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.CountryCode' when calling TaxIdentifiersApi->TaxIdentifierSchemaByCountry");


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

            localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countryCode", requestParameters.CountryCode));
            if (requestParameters.Type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "type", requestParameters.Type));
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
			var localVarResponse = await this.Client.GetAsync<TaxIdentifierSchemaByCountry200Response>("/einvoicing/tax-identifiers/schema", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TaxIdentifierSchemaByCountry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Validates a tax identifier. This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>TaxIdentifierResponse</returns>
        public TaxIdentifierResponse ValidateTaxIdentifier(ValidateTaxIdentifierRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<TaxIdentifierResponse> localVarResponse = ValidateTaxIdentifierWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validates a tax identifier. This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of TaxIdentifierResponse</returns>
        private Avalara.SDK.Client.ApiResponse<TaxIdentifierResponse> ValidateTaxIdentifierWithHttpInfo(ValidateTaxIdentifierRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TaxIdentifiersApi->ValidateTaxIdentifier");

            // verify the required parameter 'TaxIdentifierRequest' is set
            if (requestParameters.TaxIdentifierRequest == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.TaxIdentifierRequest' when calling TaxIdentifiersApi->ValidateTaxIdentifier");

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
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.TaxIdentifierRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<TaxIdentifierResponse>("/einvoicing/tax-identifiers/validate", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateTaxIdentifier", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Validates a tax identifier. This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TaxIdentifierResponse</returns>
        public async System.Threading.Tasks.Task<TaxIdentifierResponse> ValidateTaxIdentifierAsync(ValidateTaxIdentifierRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<TaxIdentifierResponse> localVarResponse = await ValidateTaxIdentifierWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validates a tax identifier. This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TaxIdentifierResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<TaxIdentifierResponse>> ValidateTaxIdentifierWithHttpInfoAsync(ValidateTaxIdentifierRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling TaxIdentifiersApi->ValidateTaxIdentifier");

            // verify the required parameter 'requestParameters.TaxIdentifierRequest' is set
            if (requestParameters.TaxIdentifierRequest == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.TaxIdentifierRequest' when calling TaxIdentifiersApi->ValidateTaxIdentifier");


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
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.TaxIdentifierRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<TaxIdentifierResponse>("/einvoicing/tax-identifiers/validate", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateTaxIdentifier", localVarResponse);
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
            this.Client.SdkVersion = "25.11.2";
        }
        
    }

    
}
