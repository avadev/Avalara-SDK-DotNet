

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
    /// Represents the Request object for the CreateWebhookSubscription API
    /// </summary>
    public class CreateWebhookSubscriptionRequestSdk {
        /// <summary>
        /// The version of the API to use, e.g., \&quot;1.4\&quot;.
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// 
        /// </summary>
        public SubscriptionRegistration SubscriptionRegistration { get; set; }
        /// <summary>
        /// A unique identifier for tracking the request and its response
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// Client application identification
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the DeleteWebhookSubscription API
    /// </summary>
    public class DeleteWebhookSubscriptionRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string SubscriptionId { get; set; }
        /// <summary>
        /// The version of the API to use, e.g., \&quot;1.4\&quot;.
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// A unique identifier for tracking the request and its response
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// Client application identification
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the GetWebhookSubscription API
    /// </summary>
    public class GetWebhookSubscriptionRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string SubscriptionId { get; set; }
        /// <summary>
        /// The version of the API to use, e.g., \&quot;1.4\&quot;.
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// A unique identifier for tracking the request and its response
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// Client application identification
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the ListWebhookSubscriptions API
    /// </summary>
    public class ListWebhookSubscriptionsRequestSdk {
        /// <summary>
        /// The version of the API to use, e.g., \&quot;1.4\&quot;.
        /// </summary>
        public string? AvalaraVersion { get; set; } = "1.4";
        /// <summary>
        /// A unique identifier for tracking the request and its response
        /// </summary>
        public string XCorrelationID { get; set; }
        /// <summary>
        /// Client application identification
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// The number of items to include in the result.
        /// </summary>
        public int? Top { get; set; }
        /// <summary>
        /// The number of items to skip in the result.
        /// </summary>
        public int? Skip { get; set; }
        /// <summary>
        /// Whether to include the total count of records in the result.
        /// </summary>
        public bool? Count { get; set; }
        /// <summary>
        /// Whether to return only the count of records, without the list of records.
        /// </summary>
        public bool? CountOnly { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a subscription to events
        /// </summary>
        /// <remarks>
        /// Create a subscription to events exposed by registered systems.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse CreateWebhookSubscription(CreateWebhookSubscriptionRequestSdk requestParameters);

        /// <summary>
        /// Unsubscribe from events
        /// </summary>
        /// <remarks>
        /// Remove a subscription from the webhooks dispatch service. All events and subscriptions are also deleted.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void DeleteWebhookSubscription(DeleteWebhookSubscriptionRequestSdk requestParameters);

        /// <summary>
        /// Get details of a subscription
        /// </summary>
        /// <remarks>
        /// Retrieve details of a specific subscription.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SubscriptionDetail</returns>
        SubscriptionDetail GetWebhookSubscription(GetWebhookSubscriptionRequestSdk requestParameters);

        /// <summary>
        /// List all subscriptions
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all subscriptions.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SubscriptionListResponse</returns>
        SubscriptionListResponse ListWebhookSubscriptions(ListWebhookSubscriptionsRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a subscription to events
        /// </summary>
        /// <remarks>
        /// Create a subscription to events exposed by registered systems.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> CreateWebhookSubscriptionAsync(CreateWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Unsubscribe from events
        /// </summary>
        /// <remarks>
        /// Remove a subscription from the webhooks dispatch service. All events and subscriptions are also deleted.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWebhookSubscriptionAsync(DeleteWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get details of a subscription
        /// </summary>
        /// <remarks>
        /// Retrieve details of a specific subscription.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionDetail</returns>
        System.Threading.Tasks.Task<SubscriptionDetail> GetWebhookSubscriptionAsync(GetWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all subscriptions
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all subscriptions.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionListResponse</returns>
        System.Threading.Tasks.Task<SubscriptionListResponse> ListWebhookSubscriptionsAsync(ListWebhookSubscriptionsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionsApi : ISubscriptionsApiSync, ISubscriptionsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public SubscriptionsApi(Avalara.SDK.Client.IApiClient client)
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
        /// Create a subscription to events Create a subscription to events exposed by registered systems.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse CreateWebhookSubscription(CreateWebhookSubscriptionRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<SuccessResponse> localVarResponse = CreateWebhookSubscriptionWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a subscription to events Create a subscription to events exposed by registered systems.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        private Avalara.SDK.Client.ApiResponse<SuccessResponse> CreateWebhookSubscriptionWithHttpInfo(CreateWebhookSubscriptionRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->CreateWebhookSubscription");

            // verify the required parameter 'SubscriptionRegistration' is set
            if (requestParameters.SubscriptionRegistration == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.SubscriptionRegistration' when calling SubscriptionsApi->CreateWebhookSubscription");

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
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.SubscriptionRegistration;

            // make the HTTP request
            var localVarResponse = this.Client.Post<SuccessResponse>("/einvoicing/webhooks/subscriptions", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateWebhookSubscription", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a subscription to events Create a subscription to events exposed by registered systems.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> CreateWebhookSubscriptionAsync(CreateWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<SuccessResponse> localVarResponse = await CreateWebhookSubscriptionWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a subscription to events Create a subscription to events exposed by registered systems.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<SuccessResponse>> CreateWebhookSubscriptionWithHttpInfoAsync(CreateWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->CreateWebhookSubscription");

            // verify the required parameter 'requestParameters.SubscriptionRegistration' is set
            if (requestParameters.SubscriptionRegistration == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.SubscriptionRegistration' when calling SubscriptionsApi->CreateWebhookSubscription");


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
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.SubscriptionRegistration;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<SuccessResponse>("/einvoicing/webhooks/subscriptions", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateWebhookSubscription", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unsubscribe from events Remove a subscription from the webhooks dispatch service. All events and subscriptions are also deleted.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void DeleteWebhookSubscription(DeleteWebhookSubscriptionRequestSdk requestParameters)
        {
            DeleteWebhookSubscriptionWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Unsubscribe from events Remove a subscription from the webhooks dispatch service. All events and subscriptions are also deleted.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeleteWebhookSubscriptionWithHttpInfo(DeleteWebhookSubscriptionRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'SubscriptionId' is set
            if (requestParameters.SubscriptionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.SubscriptionId' when calling SubscriptionsApi->DeleteWebhookSubscription");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->DeleteWebhookSubscription");

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

            localVarRequestOptions.PathParameters.Add("subscription-id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.SubscriptionId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/einvoicing/webhooks/subscriptions/{subscription-id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteWebhookSubscription", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unsubscribe from events Remove a subscription from the webhooks dispatch service. All events and subscriptions are also deleted.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWebhookSubscriptionAsync(DeleteWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteWebhookSubscriptionWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unsubscribe from events Remove a subscription from the webhooks dispatch service. All events and subscriptions are also deleted.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeleteWebhookSubscriptionWithHttpInfoAsync(DeleteWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.SubscriptionId' is set
            if (requestParameters.SubscriptionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.SubscriptionId' when calling SubscriptionsApi->DeleteWebhookSubscription");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->DeleteWebhookSubscription");


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

            localVarRequestOptions.PathParameters.Add("subscription-id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.SubscriptionId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/einvoicing/webhooks/subscriptions/{subscription-id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteWebhookSubscription", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get details of a subscription Retrieve details of a specific subscription.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SubscriptionDetail</returns>
        public SubscriptionDetail GetWebhookSubscription(GetWebhookSubscriptionRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<SubscriptionDetail> localVarResponse = GetWebhookSubscriptionWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get details of a subscription Retrieve details of a specific subscription.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of SubscriptionDetail</returns>
        private Avalara.SDK.Client.ApiResponse<SubscriptionDetail> GetWebhookSubscriptionWithHttpInfo(GetWebhookSubscriptionRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'SubscriptionId' is set
            if (requestParameters.SubscriptionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.SubscriptionId' when calling SubscriptionsApi->GetWebhookSubscription");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->GetWebhookSubscription");

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

            localVarRequestOptions.PathParameters.Add("subscription-id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.SubscriptionId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SubscriptionDetail>("/einvoicing/webhooks/subscriptions/{subscription-id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWebhookSubscription", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get details of a subscription Retrieve details of a specific subscription.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionDetail</returns>
        public async System.Threading.Tasks.Task<SubscriptionDetail> GetWebhookSubscriptionAsync(GetWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<SubscriptionDetail> localVarResponse = await GetWebhookSubscriptionWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get details of a subscription Retrieve details of a specific subscription.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionDetail)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<SubscriptionDetail>> GetWebhookSubscriptionWithHttpInfoAsync(GetWebhookSubscriptionRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.SubscriptionId' is set
            if (requestParameters.SubscriptionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.SubscriptionId' when calling SubscriptionsApi->GetWebhookSubscription");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->GetWebhookSubscription");


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

            localVarRequestOptions.PathParameters.Add("subscription-id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.SubscriptionId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<SubscriptionDetail>("/einvoicing/webhooks/subscriptions/{subscription-id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWebhookSubscription", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all subscriptions Retrieve a list of all subscriptions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>SubscriptionListResponse</returns>
        public SubscriptionListResponse ListWebhookSubscriptions(ListWebhookSubscriptionsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<SubscriptionListResponse> localVarResponse = ListWebhookSubscriptionsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all subscriptions Retrieve a list of all subscriptions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of SubscriptionListResponse</returns>
        private Avalara.SDK.Client.ApiResponse<SubscriptionListResponse> ListWebhookSubscriptionsWithHttpInfo(ListWebhookSubscriptionsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->ListWebhookSubscriptions");

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
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", requestParameters.CountOnly));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SubscriptionListResponse>("/einvoicing/webhooks/subscriptions", localVarRequestOptions, requiredScopes, AvalaraMicroservice.EInvoicing);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListWebhookSubscriptions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all subscriptions Retrieve a list of all subscriptions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SubscriptionListResponse</returns>
        public async System.Threading.Tasks.Task<SubscriptionListResponse> ListWebhookSubscriptionsAsync(ListWebhookSubscriptionsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<SubscriptionListResponse> localVarResponse = await ListWebhookSubscriptionsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all subscriptions Retrieve a list of all subscriptions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SubscriptionListResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<SubscriptionListResponse>> ListWebhookSubscriptionsWithHttpInfoAsync(ListWebhookSubscriptionsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling SubscriptionsApi->ListWebhookSubscriptions");


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
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            if (requestParameters.CountOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", requestParameters.CountOnly));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationID != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-ID", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationID)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<SubscriptionListResponse>("/einvoicing/webhooks/subscriptions", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.EInvoicing).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListWebhookSubscriptions", localVarResponse);
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
