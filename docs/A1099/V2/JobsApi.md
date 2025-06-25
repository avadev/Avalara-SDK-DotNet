# Avalara.SDK.Api.A1099.V2.JobsApi

All URIs are relative to *https://api.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJob**](JobsApi.md#getjob) | **GET** /jobs/{jobId} | Get status of an existing job


<a name="getjob"></a>
# **GetJob**
> JobModel GetJob (GetJobRequest requestParameters)

Get status of an existing job

Check the status and results of a job. Multiple job types exist. Check \"Schema\" in the 200 response below for all possibilities.

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
            var requestParameters = new GetJobRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.JobId = "jobId_example";  // string | id received when a job was submitted
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Get status of an existing job
                JobModel result = apiInstance.GetJob(requestParameters);
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
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **JobId** | **string**| id received when a job was submitted | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**JobModel**](JobModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. Returns the status of the job being tracked or the result, if the job is completed. |  * X-Correlation-Id -  <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |
| **429** | Too many requests |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

