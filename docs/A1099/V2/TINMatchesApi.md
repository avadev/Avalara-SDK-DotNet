# Avalara.SDK.Api.A1099.V2.TINMatchesApi

All URIs are relative to *https://api.sbx.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PerformRealTimeTinMatch**](TINMatchesApi.md#performrealtimetinmatch) | **POST** /tin-matches/$real-time | Perform real time TIN Match


<a name="performrealtimetinmatch"></a>
# **PerformRealTimeTinMatch**
> RealTimeTinMatchResponse PerformRealTimeTinMatch (PerformRealTimeTinMatchRequestSdk requestParameters)

Perform real time TIN Match

Perform real time TIN Match.

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
    public class PerformRealTimeTinMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TINMatchesApi(apiClient);
            var requestParameters = new PerformRealTimeTinMatchRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = a4f97e62-2087-4274-b92f-39377f73fb20;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.RealTimeTinMatchRequest = new RealTimeTinMatchRequest(); // RealTimeTinMatchRequest | Required data to perform TIN match (optional) 

            try
            {
                // Perform real time TIN Match
                RealTimeTinMatchResponse result = apiInstance.PerformRealTimeTinMatch(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TINMatchesApi.PerformRealTimeTinMatch: " + e.Message );
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
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 
 **RealTimeTinMatchRequest** | [**RealTimeTinMatchRequest**](RealTimeTinMatchRequest.md)| Required data to perform TIN match | [optional] 

### Return type

[**RealTimeTinMatchResponse**](RealTimeTinMatchResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TIN match result (matched or rejected) |  -  |
| **400** | Bad request (e.g. invalid field values) |  -  |
| **401** | Authentication failed |  -  |
| **429** | Usage limit exceeded (10,000 successful calls per 24 hours) |  -  |
| **403** | Authorization failed (lack of permissions or product not purchased) |  -  |
| **503** | IRS Service is not available. Client should retry later. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

