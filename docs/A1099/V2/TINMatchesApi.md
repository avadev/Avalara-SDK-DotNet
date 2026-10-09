# Avalara.SDK.Api.A1099.V2.TINMatchesApi

All URIs are relative to *https://api.sbx.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBulkTinMatch**](TINMatchesApi.md#getbulktinmatch) | **GET** /tin-matches/$bulk/{id} | Get bulk TIN match details
[**GetBulkTinMatchResults**](TINMatchesApi.md#getbulktinmatchresults) | **GET** /tin-matches/$bulk/{id}/results | List bulk TIN match results
[**PerformRealTimeTinMatch**](TINMatchesApi.md#performrealtimetinmatch) | **POST** /tin-matches/$real-time | Perform real time TIN Match
[**SubmitBulkTinMatch**](TINMatchesApi.md#submitbulktinmatch) | **POST** /tin-matches/$bulk | Submit bulk TIN match


<a name="getbulktinmatch"></a>
# **GetBulkTinMatch**
> BulkTinMatchResponse GetBulkTinMatch (GetBulkTinMatchRequestSdk requestParameters)

Get bulk TIN match details

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
    public class GetBulkTinMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TINMatchesApi(apiClient);
            var requestParameters = new GetBulkTinMatchRequestSdk();
            requestParameters.Id = "id_example";  // string | The bulk ID
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 77d79db6-e884-4ef0-a76d-0c10c41f5993;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Get bulk TIN match details
                BulkTinMatchResponse result = apiInstance.GetBulkTinMatch(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TINMatchesApi.GetBulkTinMatch: " + e.Message );
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
 **Id** | **string**| The bulk ID | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**BulkTinMatchResponse**](BulkTinMatchResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bulk TIN match details |  -  |
| **401** | Authentication failed |  -  |
| **404** | Bulk not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getbulktinmatchresults"></a>
# **GetBulkTinMatchResults**
> PaginatedQueryResultModelBulkTinMatchResultItemResponse GetBulkTinMatchResults (GetBulkTinMatchResultsRequestSdk requestParameters)

List bulk TIN match results

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
    public class GetBulkTinMatchResultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TINMatchesApi(apiClient);
            var requestParameters = new GetBulkTinMatchResultsRequestSdk();
            requestParameters.Id = "id_example";  // string | The bulk ID
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve.  For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 56;  // int? | If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. (optional) 
            requestParameters.Skip = 56;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | If true, return the global count of elements in the collection. (optional) 
            requestParameters.CountOnly = true;  // bool? | If true, return ONLY the global count of elements in the collection.  It only applies when count=true. (optional) 
            requestParameters.XCorrelationId = 8bd78a31-95dc-4091-9f0e-fd0647ecc6f5;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // List bulk TIN match results
                PaginatedQueryResultModelBulkTinMatchResultItemResponse result = apiInstance.GetBulkTinMatchResults(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TINMatchesApi.GetBulkTinMatchResults: " + e.Message );
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
 **Id** | **string**| The bulk ID | 
 **AvalaraVersion** | **string**| API version | 
 **Filter** | **string**| A filter statement to identify specific records to retrieve.  For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;. | [optional] 
 **Top** | **int?**| If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. | [optional] 
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] 
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| If true, return the global count of elements in the collection. | [optional] 
 **CountOnly** | **bool?**| If true, return ONLY the global count of elements in the collection.  It only applies when count&#x3D;true. | [optional] 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**PaginatedQueryResultModelBulkTinMatchResultItemResponse**](PaginatedQueryResultModelBulkTinMatchResultItemResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of TIN match responses |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |
| **404** | Bulk not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

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
            requestParameters.XCorrelationId = 7f2a23f6-59ed-4fb9-95fd-7937e99952f5;  // string | Unique correlation Id in a GUID format (optional) 
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

<a name="submitbulktinmatch"></a>
# **SubmitBulkTinMatch**
> BulkTinMatchAcceptedResponse SubmitBulkTinMatch (SubmitBulkTinMatchRequestSdk requestParameters)

Submit bulk TIN match

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
    public class SubmitBulkTinMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TINMatchesApi(apiClient);
            var requestParameters = new SubmitBulkTinMatchRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 88b0e4e3-1fd9-437c-9744-753f89dfef9f;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.BulkTinMatchRequest = new BulkTinMatchRequest(); // BulkTinMatchRequest | Required TIN collection to perform bulk TIN match (optional) 

            try
            {
                // Submit bulk TIN match
                BulkTinMatchAcceptedResponse result = apiInstance.SubmitBulkTinMatch(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TINMatchesApi.SubmitBulkTinMatch: " + e.Message );
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
 **BulkTinMatchRequest** | [**BulkTinMatchRequest**](BulkTinMatchRequest.md)| Required TIN collection to perform bulk TIN match | [optional] 

### Return type

[**BulkTinMatchAcceptedResponse**](BulkTinMatchAcceptedResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted submission, indicating it will be processed later and where to get results from |  -  |
| **400** | Bad request (e.g. invalid field values) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

