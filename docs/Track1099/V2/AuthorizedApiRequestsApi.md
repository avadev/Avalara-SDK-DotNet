# Avalara.SDK.Api.Track1099.V2.AuthorizedAPIRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet**](AuthorizedAPIRequestsApi.md#authorizedapirequestsauthorizedapirequestidexecuteget) | **GET** /authorized-api-requests/{authorizedApiRequestId}/$execute | Execute URL for downloads
[**AuthorizedApiRequestsAuthorizedApiRequestIdGet**](AuthorizedAPIRequestsApi.md#authorizedapirequestsauthorizedapirequestidget) | **GET** /authorized-api-requests/{authorizedApiRequestId} | Retrieve URL for downloads
[**AuthorizedApiRequestsPost**](AuthorizedAPIRequestsApi.md#authorizedapirequestspost) | **POST** /authorized-api-requests | Create URL for downloads


<a name="authorizedapirequestsauthorizedapirequestidexecuteget"></a>
# **AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet**
> void AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet (AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters)

Execute URL for downloads

Execute the URL you created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new AuthorizedAPIRequestsApi(apiClient);
            var requestParameters = new AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest();
            requestParameters.AuthorizedApiRequestId = "authorizedApiRequestId_example";  // string | 
            requestParameters.R = "r_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format

            try
            {
                // Execute URL for downloads
                apiInstance.AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedAPIRequestsApi.AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet: " + e.Message );
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
 **AuthorizedApiRequestId** | **string**|  | 
 **R** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="authorizedapirequestsauthorizedapirequestidget"></a>
# **AuthorizedApiRequestsAuthorizedApiRequestIdGet**
> AuthorizedApiRequestV2DataModel AuthorizedApiRequestsAuthorizedApiRequestIdGet (AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters)

Retrieve URL for downloads

Retrieve the URL you created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class AuthorizedApiRequestsAuthorizedApiRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new AuthorizedAPIRequestsApi(apiClient);
            var requestParameters = new AuthorizedApiRequestsAuthorizedApiRequestIdGetRequest();
            requestParameters.AuthorizedApiRequestId = "authorizedApiRequestId_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieve URL for downloads
                AuthorizedApiRequestV2DataModel result = apiInstance.AuthorizedApiRequestsAuthorizedApiRequestIdGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedAPIRequestsApi.AuthorizedApiRequestsAuthorizedApiRequestIdGet: " + e.Message );
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
 **AuthorizedApiRequestId** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**AuthorizedApiRequestV2DataModel**](AuthorizedApiRequestV2DataModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="authorizedapirequestspost"></a>
# **AuthorizedApiRequestsPost**
> AuthorizedApiRequestV2DataModel AuthorizedApiRequestsPost (AuthorizedApiRequestsPostRequest requestParameters)

Create URL for downloads

Create a URL that can be used to download forms. It will be valid until the given Time To Live (TTL) has passed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class AuthorizedApiRequestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new AuthorizedAPIRequestsApi(apiClient);
            var requestParameters = new AuthorizedApiRequestsPostRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.AuthorizedApiRequestModel = new AuthorizedApiRequestModel(); // AuthorizedApiRequestModel |  (optional) 

            try
            {
                // Create URL for downloads
                AuthorizedApiRequestV2DataModel result = apiInstance.AuthorizedApiRequestsPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedAPIRequestsApi.AuthorizedApiRequestsPost: " + e.Message );
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
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **AuthorizedApiRequestModel** | [**AuthorizedApiRequestModel**](AuthorizedApiRequestModel.md)|  | [optional] 

### Return type

[**AuthorizedApiRequestV2DataModel**](AuthorizedApiRequestV2DataModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

