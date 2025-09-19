# Avalara.SDK.Api.A1099.V2.JobsApi

All URIs are relative to *https://api.sbx.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJob**](JobsApi.md#getjob) | **GET** /jobs/{id} | Retrieves information about the job


<a name="getjob"></a>
# **GetJob**
> JobResponse GetJob (GetJobRequestSdk requestParameters)

Retrieves information about the job

Retrieves information about the job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class GetJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new JobsApi(apiClient);
            var requestParameters = new GetJobRequestSdk();
            requestParameters.Id = "id_example";  // string | Job id obtained from other API responses, like `/1099/bulk-upsert`.
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = af6414fe-0bd6-4ddb-91bb-43108aa78fa5;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Retrieves information about the job
                JobResponse result = apiInstance.GetJob(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetJob: " + e.Message );
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
 **Id** | **string**| Job id obtained from other API responses, like &#x60;/1099/bulk-upsert&#x60;. | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**JobResponse**](JobResponse.md)

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

