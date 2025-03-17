# Avalara.SDK.Api.Track1099.V2.FormRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FormRequestsFormRequestIdGet**](FormRequestsApi.md#formrequestsformrequestidget) | **GET** /form-requests/{formRequestId} | Get form request


<a name="formrequestsformrequestidget"></a>
# **FormRequestsFormRequestIdGet**
> FormRequestModel FormRequestsFormRequestIdGet (FormRequestsFormRequestIdGetRequest requestParameters)

Get form request

Create a W-9, W-8BEN or W-8BEN-E form request for the given `company_id` (ID of a company in the W-9 section of the Track1099 app) and your internal `reference_id` for the vendor. `reference_id` is opaque to Track1099 but should be meaningful to you. If provided, it must uniquely identify (to you) the person or company from whom you are requesting the form.

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
    public class FormRequestsFormRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormRequestsApi(apiClient);
            var requestParameters = new FormRequestsFormRequestIdGetRequest();
            requestParameters.FormRequestId = "formRequestId_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format

            try
            {
                // Get form request
                FormRequestModel result = apiInstance.FormRequestsFormRequestIdGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormRequestsApi.FormRequestsFormRequestIdGet: " + e.Message );
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
 **FormRequestId** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**FormRequestModel**](FormRequestModel.md)

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

