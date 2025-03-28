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
    /// Represents the Request object for the CreateIssuer API
    /// </summary>
    public class CreateIssuerRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public CreateIssuerRequest () {
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
        /// The issuer to create
        /// </summary>
        public IssuerModel IssuerModel { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the DeleteIssuer API
    /// </summary>
    public class DeleteIssuerRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public DeleteIssuerRequest () {
        }
        /// <summary>
        /// Id of the issuer to delete
        /// </summary>
        public string IssuerId { get; set; }
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
    /// Represents the Request object for the GetIssuer API
    /// </summary>
    public class GetIssuerRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public GetIssuerRequest () {
        }
        /// <summary>
        /// 
        /// </summary>
        public string IssuerId { get; set; }
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
    /// Represents the Request object for the ListIssuers API
    /// </summary>
    public class ListIssuersRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public ListIssuersRequest () {
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
        /// A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.  Filterable: name, nameDba, referenceId, taxYear 
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
    /// Represents the Request object for the UpdateIssuer API
    /// </summary>
    public class UpdateIssuerRequest {
        /// <summary>
        /// Constructor for the Request object
        /// </summary>
        public UpdateIssuerRequest () {
        }
        /// <summary>
        /// Id of the issuer to Update
        /// </summary>
        public string IssuerId { get; set; }
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
        /// The issuer to update
        /// </summary>
        public IssuerModel IssuerModel { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass1099IssuersApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new issuer
        /// </summary>
        /// <remarks>
        /// Create a new issuer
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>IssuerModel</returns>
        IssuerModel CreateIssuer(CreateIssuerRequest requestParameters);

        /// <summary>
        /// Delete an issuer
        /// </summary>
        /// <remarks>
        /// Delete a single issuer by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void DeleteIssuer(DeleteIssuerRequest requestParameters);

        /// <summary>
        /// Get a single issuer
        /// </summary>
        /// <remarks>
        /// Get a single issuer by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>IssuerModel</returns>
        IssuerModel GetIssuer(GetIssuerRequest requestParameters);

        /// <summary>
        /// List issuers
        /// </summary>
        /// <remarks>
        /// List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>IssuerModelPaginatedQueryResultModel</returns>
        IssuerModelPaginatedQueryResultModel ListIssuers(ListIssuersRequest requestParameters);

        /// <summary>
        /// Update an issuer
        /// </summary>
        /// <remarks>
        /// Update an existing issuer by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void UpdateIssuer(UpdateIssuerRequest requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass1099IssuersApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new issuer
        /// </summary>
        /// <remarks>
        /// Create a new issuer
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IssuerModel</returns>
        System.Threading.Tasks.Task<IssuerModel> CreateIssuerAsync(CreateIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete an issuer
        /// </summary>
        /// <remarks>
        /// Delete a single issuer by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteIssuerAsync(DeleteIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a single issuer
        /// </summary>
        /// <remarks>
        /// Get a single issuer by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IssuerModel</returns>
        System.Threading.Tasks.Task<IssuerModel> GetIssuerAsync(GetIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List issuers
        /// </summary>
        /// <remarks>
        /// List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IssuerModelPaginatedQueryResultModel</returns>
        System.Threading.Tasks.Task<IssuerModelPaginatedQueryResultModel> ListIssuersAsync(ListIssuersRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update an issuer
        /// </summary>
        /// <remarks>
        /// Update an existing issuer by id
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateIssuerAsync(UpdateIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Class1099IssuersApi : IClass1099IssuersApiSync, IClass1099IssuersApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1099IssuersApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public Class1099IssuersApi(Avalara.SDK.Client.IApiClient client)
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
        /// Create a new issuer Create a new issuer
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>IssuerModel</returns>
        public IssuerModel CreateIssuer(CreateIssuerRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<IssuerModel> localVarResponse = CreateIssuerWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new issuer Create a new issuer
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of IssuerModel</returns>
        private Avalara.SDK.Client.ApiResponse<IssuerModel> CreateIssuerWithHttpInfo(CreateIssuerRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->CreateIssuer");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->CreateIssuer");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "application/*+json"
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
            localVarRequestOptions.Data = requestParameters.IssuerModel;

            // make the HTTP request
            var localVarResponse = this.Client.Post<IssuerModel>("/1099/issuers", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new issuer Create a new issuer
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IssuerModel</returns>
        public async System.Threading.Tasks.Task<IssuerModel> CreateIssuerAsync(CreateIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<IssuerModel> localVarResponse = await CreateIssuerWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new issuer Create a new issuer
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IssuerModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<IssuerModel>> CreateIssuerWithHttpInfoAsync(CreateIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->CreateIssuer");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->CreateIssuer");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "application/*+json"
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
            localVarRequestOptions.Data = requestParameters.IssuerModel;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<IssuerModel>("/1099/issuers", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an issuer Delete a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void DeleteIssuer(DeleteIssuerRequest requestParameters)
        {
            DeleteIssuerWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Delete an issuer Delete a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeleteIssuerWithHttpInfo(DeleteIssuerRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'IssuerId' is set
            if (requestParameters.IssuerId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.IssuerId' when calling Class1099IssuersApi->DeleteIssuer");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->DeleteIssuer");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->DeleteIssuer");

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

            localVarRequestOptions.PathParameters.Add("issuerId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.IssuerId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/1099/issuers/{issuerId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an issuer Delete a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteIssuerAsync(DeleteIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteIssuerWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete an issuer Delete a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeleteIssuerWithHttpInfoAsync(DeleteIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.IssuerId' is set
            if (requestParameters.IssuerId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.IssuerId' when calling Class1099IssuersApi->DeleteIssuer");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->DeleteIssuer");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->DeleteIssuer");


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

            localVarRequestOptions.PathParameters.Add("issuerId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.IssuerId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/1099/issuers/{issuerId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a single issuer Get a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>IssuerModel</returns>
        public IssuerModel GetIssuer(GetIssuerRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<IssuerModel> localVarResponse = GetIssuerWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single issuer Get a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of IssuerModel</returns>
        private Avalara.SDK.Client.ApiResponse<IssuerModel> GetIssuerWithHttpInfo(GetIssuerRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'IssuerId' is set
            if (requestParameters.IssuerId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.IssuerId' when calling Class1099IssuersApi->GetIssuer");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->GetIssuer");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->GetIssuer");

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

            localVarRequestOptions.PathParameters.Add("issuerId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.IssuerId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<IssuerModel>("/1099/issuers/{issuerId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a single issuer Get a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IssuerModel</returns>
        public async System.Threading.Tasks.Task<IssuerModel> GetIssuerAsync(GetIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<IssuerModel> localVarResponse = await GetIssuerWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a single issuer Get a single issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IssuerModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<IssuerModel>> GetIssuerWithHttpInfoAsync(GetIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.IssuerId' is set
            if (requestParameters.IssuerId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.IssuerId' when calling Class1099IssuersApi->GetIssuer");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->GetIssuer");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->GetIssuer");


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

            localVarRequestOptions.PathParameters.Add("issuerId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.IssuerId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<IssuerModel>("/1099/issuers/{issuerId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List issuers List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>IssuerModelPaginatedQueryResultModel</returns>
        public IssuerModelPaginatedQueryResultModel ListIssuers(ListIssuersRequest requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<IssuerModelPaginatedQueryResultModel> localVarResponse = ListIssuersWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List issuers List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of IssuerModelPaginatedQueryResultModel</returns>
        private Avalara.SDK.Client.ApiResponse<IssuerModelPaginatedQueryResultModel> ListIssuersWithHttpInfo(ListIssuersRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->ListIssuers");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->ListIssuers");

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
            var localVarResponse = this.Client.Get<IssuerModelPaginatedQueryResultModel>("/1099/issuers", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListIssuers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List issuers List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IssuerModelPaginatedQueryResultModel</returns>
        public async System.Threading.Tasks.Task<IssuerModelPaginatedQueryResultModel> ListIssuersAsync(ListIssuersRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<IssuerModelPaginatedQueryResultModel> localVarResponse = await ListIssuersWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List issuers List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IssuerModelPaginatedQueryResultModel)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<IssuerModelPaginatedQueryResultModel>> ListIssuersWithHttpInfoAsync(ListIssuersRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->ListIssuers");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->ListIssuers");


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
			var localVarResponse = await this.Client.GetAsync<IssuerModelPaginatedQueryResultModel>("/1099/issuers", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListIssuers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an issuer Update an existing issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void UpdateIssuer(UpdateIssuerRequest requestParameters)
        {
            UpdateIssuerWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Update an issuer Update an existing issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> UpdateIssuerWithHttpInfo(UpdateIssuerRequest requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'IssuerId' is set
            if (requestParameters.IssuerId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.IssuerId' when calling Class1099IssuersApi->UpdateIssuer");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->UpdateIssuer");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->UpdateIssuer");

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

            localVarRequestOptions.PathParameters.Add("issuerId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.IssuerId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.IssuerModel;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/1099/issuers/{issuerId}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateIssuer", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an issuer Update an existing issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateIssuerAsync(UpdateIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await UpdateIssuerWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update an issuer Update an existing issuer by id
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> UpdateIssuerWithHttpInfoAsync(UpdateIssuerRequest requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.IssuerId' is set
            if (requestParameters.IssuerId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.IssuerId' when calling Class1099IssuersApi->UpdateIssuer");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099IssuersApi->UpdateIssuer");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099IssuersApi->UpdateIssuer");


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

            localVarRequestOptions.PathParameters.Add("issuerId", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.IssuerId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.IssuerModel;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/1099/issuers/{issuerId}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateIssuer", localVarResponse);
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
