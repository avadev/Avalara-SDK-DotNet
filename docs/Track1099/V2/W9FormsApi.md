# Avalara.SDK.Api.Track1099.V2.W9FormsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiW9FormsGet**](W9FormsApi.md#apiw9formsget) | **GET** /api/w9/forms | 


<a name="apiw9formsget"></a>
# **ApiW9FormsGet**
> List&lt;ApiW9FormsGet200ResponseInner&gt; ApiW9FormsGet (ApiW9FormsGetRequest requestParameters)



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
    public class ApiW9FormsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new ApiW9FormsGetRequest();

            try
            {
                List<ApiW9FormsGet200ResponseInner> result = apiInstance.ApiW9FormsGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.ApiW9FormsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ApiW9FormsGet200ResponseInner&gt;**](ApiW9FormsGet200ResponseInner.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

