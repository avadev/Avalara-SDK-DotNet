# Avalara.SDK.Api.EInvoicing.V1.SubscriptionsApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhookSubscription**](SubscriptionsApi.md#createwebhooksubscription) | **POST** /webhooks/subscriptions | Create a subscription to events
[**DeleteWebhookSubscription**](SubscriptionsApi.md#deletewebhooksubscription) | **DELETE** /webhooks/subscriptions/{subscriptionId} | Unsubscribe from events
[**GetWebhookSubscription**](SubscriptionsApi.md#getwebhooksubscription) | **GET** /webhooks/subscriptions/{subscriptionId} | Get details of a subscription
[**ListWebhookSubscriptions**](SubscriptionsApi.md#listwebhooksubscriptions) | **GET** /webhooks/subscriptions | List all subscriptions


<a name="createwebhooksubscription"></a>
# **CreateWebhookSubscription**
> SuccessResponse CreateWebhookSubscription (CreateWebhookSubscriptionRequestSdk requestParameters)

Create a subscription to events

Create a new webhook subscription and return the created subscription details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class CreateWebhookSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new SubscriptionsApi(apiClient);
            var requestParameters = new CreateWebhookSubscriptionRequestSdk();
            requestParameters.AvalaraVersion = "avalaraVersion_example";  // string | The version of the API to use, e.g., \"1.6\".
            requestParameters.SubscriptionRegistration = new SubscriptionRegistration(); // SubscriptionRegistration | 
            requestParameters.XCorrelationID = "xCorrelationID_example";  // string | A unique identifier for tracking the request and its response (optional) 
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Client application identification (optional) 

            try
            {
                // Create a subscription to events
                SuccessResponse result = apiInstance.CreateWebhookSubscription(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateWebhookSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AvalaraVersion** | **string**| The version of the API to use, e.g., \&quot;1.6\&quot;. | 
 **SubscriptionRegistration** | [**SubscriptionRegistration**](SubscriptionRegistration.md)|  | 
 **XCorrelationID** | **string**| A unique identifier for tracking the request and its response | [optional] 
 **XAvalaraClient** | **string**| Client application identification | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Subscription created successfully. Returns the created SubscriptionDetail object. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **400** | Bad request. The request payload is invalid or contains missing required fields. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **403** | Forbidden. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deletewebhooksubscription"></a>
# **DeleteWebhookSubscription**
> void DeleteWebhookSubscription (DeleteWebhookSubscriptionRequestSdk requestParameters)

Unsubscribe from events

Delete the specified webhook subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class DeleteWebhookSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new SubscriptionsApi(apiClient);
            var requestParameters = new DeleteWebhookSubscriptionRequestSdk();
            requestParameters.SubscriptionId = "subscriptionId_example";  // string | Unique identifier of the subscription.
            requestParameters.AvalaraVersion = "avalaraVersion_example";  // string | The version of the API to use, e.g., \"1.6\".
            requestParameters.XCorrelationID = "xCorrelationID_example";  // string | A unique identifier for tracking the request and its response (optional) 
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Client application identification (optional) 

            try
            {
                // Unsubscribe from events
                apiInstance.DeleteWebhookSubscription(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DeleteWebhookSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SubscriptionId** | **string**| Unique identifier of the subscription. | 
 **AvalaraVersion** | **string**| The version of the API to use, e.g., \&quot;1.6\&quot;. | 
 **XCorrelationID** | **string**| A unique identifier for tracking the request and its response | [optional] 
 **XAvalaraClient** | **string**| Client application identification | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Subscription deleted successfully. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **403** | Forbidden. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **404** | Subscription not found for the specified subscriptionId. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getwebhooksubscription"></a>
# **GetWebhookSubscription**
> SubscriptionDetail GetWebhookSubscription (GetWebhookSubscriptionRequestSdk requestParameters)

Get details of a subscription

Retrieve details of a specific subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class GetWebhookSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new SubscriptionsApi(apiClient);
            var requestParameters = new GetWebhookSubscriptionRequestSdk();
            requestParameters.SubscriptionId = "subscriptionId_example";  // string | Unique identifier of the subscription.
            requestParameters.AvalaraVersion = "avalaraVersion_example";  // string | The version of the API to use, e.g., \"1.6\".
            requestParameters.XCorrelationID = "xCorrelationID_example";  // string | A unique identifier for tracking the request and its response (optional) 
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Client application identification (optional) 

            try
            {
                // Get details of a subscription
                SubscriptionDetail result = apiInstance.GetWebhookSubscription(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetWebhookSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SubscriptionId** | **string**| Unique identifier of the subscription. | 
 **AvalaraVersion** | **string**| The version of the API to use, e.g., \&quot;1.6\&quot;. | 
 **XCorrelationID** | **string**| A unique identifier for tracking the request and its response | [optional] 
 **XAvalaraClient** | **string**| Client application identification | [optional] 

### Return type

[**SubscriptionDetail**](SubscriptionDetail.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the SubscriptionDetail object for the specified subscriptionId. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **403** | Forbidden. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **404** | Subscription not found for the specified subscriptionId. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listwebhooksubscriptions"></a>
# **ListWebhookSubscriptions**
> SubscriptionListResponse ListWebhookSubscriptions (ListWebhookSubscriptionsRequestSdk requestParameters)

List all subscriptions

Retrieve a list of webhook subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class ListWebhookSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new SubscriptionsApi(apiClient);
            var requestParameters = new ListWebhookSubscriptionsRequestSdk();
            requestParameters.AvalaraVersion = "avalaraVersion_example";  // string | The version of the API to use, e.g., \"1.6\".
            requestParameters.XCorrelationID = "xCorrelationID_example";  // string | A unique identifier for tracking the request and its response (optional) 
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Client application identification (optional) 
            requestParameters.Top = 56;  // int? | The number of items to include in the result. (optional) 
            requestParameters.Skip = 56;  // int? | The number of items to skip in the result. (optional) 
            requestParameters.Count = true;  // bool? | Whether to include the total count of records in the result. (optional) 
            requestParameters.CountOnly = true;  // bool? | Whether to return only the count of records, without the list of records. (optional) 

            try
            {
                // List all subscriptions
                SubscriptionListResponse result = apiInstance.ListWebhookSubscriptions(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ListWebhookSubscriptions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AvalaraVersion** | **string**| The version of the API to use, e.g., \&quot;1.6\&quot;. | 
 **XCorrelationID** | **string**| A unique identifier for tracking the request and its response | [optional] 
 **XAvalaraClient** | **string**| Client application identification | [optional] 
 **Top** | **int?**| The number of items to include in the result. | [optional] 
 **Skip** | **int?**| The number of items to skip in the result. | [optional] 
 **Count** | **bool?**| Whether to include the total count of records in the result. | [optional] 
 **CountOnly** | **bool?**| Whether to return only the count of records, without the list of records. | [optional] 

### Return type

[**SubscriptionListResponse**](SubscriptionListResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of webhook subscriptions in a SubscriptionListResponse object. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **403** | Forbidden. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |
| **500** | Internal server error. |  * X-Correlation-ID - Correlation ID from the request, or a new one if not provided in request <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

