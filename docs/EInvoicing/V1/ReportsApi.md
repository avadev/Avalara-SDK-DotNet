# Avalara.SDK.Api.EInvoicing.V1.ReportsApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadReport**](ReportsApi.md#downloadreport) | **GET** /reports/{reportId}/$download | Returns a pre-signed download URL for a report
[**GetReportById**](ReportsApi.md#getreportbyid) | **GET** /reports/{reportId}/status | Retrieves a report by its unique ID
[**GetReports**](ReportsApi.md#getreports) | **GET** /reports | Returns a list of reports


<a name="downloadreport"></a>
# **DownloadReport**
> ReportDownloadResponse DownloadReport (DownloadReportRequestSdk requestParameters)

Returns a pre-signed download URL for a report

Returns a pre-signed URL to download the report file when it is available. If the report has not yet been generated, a 404 (not found) is returned.

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
    public class DownloadReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new ReportsApi(apiClient);
            var requestParameters = new DownloadReportRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.ReportId = "reportId_example";  // string | The unique ID for this report as returned in a GET /reports response.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Returns a pre-signed download URL for a report
                ReportDownloadResponse result = apiInstance.DownloadReport(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportsApi.DownloadReport: " + e.Message );
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **ReportId** | **string**| The unique ID for this report as returned in a GET /reports response. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**ReportDownloadResponse**](ReportDownloadResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a pre-signed URL to download the report. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |
| **404** | Report not found or not yet available for download. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getreportbyid"></a>
# **GetReportById**
> ReportItem GetReportById (GetReportByIdRequestSdk requestParameters)

Retrieves a report by its unique ID

Retrieves a specific report by its unique identifier. Returns complete report details including metadata, status, and associated information.

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
    public class GetReportByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new ReportsApi(apiClient);
            var requestParameters = new GetReportByIdRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.ReportId = "reportId_example";  // string | The unique ID for this report as returned in a GET /reports response.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Retrieves a report by its unique ID
                ReportItem result = apiInstance.GetReportById(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportById: " + e.Message );
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **ReportId** | **string**| The unique ID for this report as returned in a GET /reports response. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**ReportItem**](ReportItem.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Report found and returned successfully. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |
| **404** | Report not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getreports"></a>
# **GetReports**
> ReportListResponse GetReports (GetReportsRequestSdk requestParameters)

Returns a list of reports

Retrieves all reports with optional filtering, paging, and sorting. Results are filtered by tenant. Supports OData-style filtering using the $filter parameter. Use $top and $skip for paging; when more results exist, the response includes @nextLink to fetch the next page. Default sort order is by report generation date (descending).

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
    public class GetReportsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new ReportsApi(apiClient);
            var requestParameters = new GetReportsRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 
            requestParameters.Filter = status eq 'COMPLETED';  // string | OData-style filter expression. Supports operators: eq, ne, gt, ge, lt, le, like, ilike, contains. Examples: status eq 'COMPLETED', reportGenerateDate gt '2025-11-01', transactionIds contains 'TXN-2025-001' (optional) 
            requestParameters.Top = 56;  // int? | The number of items to include in the result. (optional) 
            requestParameters.Skip = 56;  // int? | The number of items to skip in the result. (optional) 
            requestParameters.Count = true;  // string | When set to true, the response body also includes the count of items in the collection. (optional) 
            requestParameters.CountOnly = false;  // string | When set to true, the response returns only the count of items in the collection. (optional) 
            requestParameters.Orderby = reportGenerateDate desc;  // string | OData-style orderby expression. Format: 'field asc' or 'field desc'. Default: reportGenerateDate desc (optional)  (default to "reportGenerateDate desc")

            try
            {
                // Returns a list of reports
                ReportListResponse result = apiInstance.GetReports(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReports: " + e.Message );
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 
 **Filter** | **string**| OData-style filter expression. Supports operators: eq, ne, gt, ge, lt, le, like, ilike, contains. Examples: status eq &#39;COMPLETED&#39;, reportGenerateDate gt &#39;2025-11-01&#39;, transactionIds contains &#39;TXN-2025-001&#39; | [optional] 
 **Top** | **int?**| The number of items to include in the result. | [optional] 
 **Skip** | **int?**| The number of items to skip in the result. | [optional] 
 **Count** | **string**| When set to true, the response body also includes the count of items in the collection. | [optional] 
 **CountOnly** | **string**| When set to true, the response returns only the count of items in the collection. | [optional] 
 **Orderby** | **string**| OData-style orderby expression. Format: &#39;field asc&#39; or &#39;field desc&#39;. Default: reportGenerateDate desc | [optional] [default to &quot;reportGenerateDate desc&quot;]

### Return type

[**ReportListResponse**](ReportListResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reports retrieved successfully. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

