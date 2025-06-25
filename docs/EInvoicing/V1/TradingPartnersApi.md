# Avalara.SDK.Api.EInvoicing.V1.TradingPartnersApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchSearchParticipants**](TradingPartnersApi.md#batchsearchparticipants) | **POST** /trading-partners/batch-searches | Creates a batch search and performs a batch search in the directory for participants in the background.
[**DownloadBatchSearchReport**](TradingPartnersApi.md#downloadbatchsearchreport) | **GET** /trading-partners/batch-searches/{id}/$download-results | Download batch search results in a csv file.
[**GetBatchSearchDetail**](TradingPartnersApi.md#getbatchsearchdetail) | **GET** /trading-partners/batch-searches/{id} | Get the batch search details for a given id.
[**ListBatchSearches**](TradingPartnersApi.md#listbatchsearches) | **GET** /trading-partners/batch-searches | List all batch searches that were previously submitted.
[**SearchParticipants**](TradingPartnersApi.md#searchparticipants) | **GET** /trading-partners | Returns a list of participants matching the input query.


<a name="batchsearchparticipants"></a>
# **BatchSearchParticipants**
> void BatchSearchParticipants (BatchSearchParticipantsRequest requestParameters)

Creates a batch search and performs a batch search in the directory for participants in the background.

Handles batch search requests by uploading a file containing search parameters.

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
    public class BatchSearchParticipantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new BatchSearchParticipantsRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.Name = Automotive Companies in London Search;  // string | The human readable name given to this batch search.
            requestParameters.NotificationEmail = user@example.com;  // string | The email address of the user to whom the batch search completion notification must go to.
            requestParameters.File = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | CSV file containing search parameters.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\" (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 

            try
            {
                // Creates a batch search and performs a batch search in the directory for participants in the background.
                apiInstance.BatchSearchParticipants(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.BatchSearchParticipants: " + e.Message );
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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **Name** | **string**| The human readable name given to this batch search. | 
 **NotificationEmail** | **string**| The email address of the user to whom the batch search completion notification must go to. | 
 **File** | **FileParameter****FileParameter**| CSV file containing search parameters. | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot; | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Batch search file accepted for processing the search. |  * X-Correlation-Id -  <br>  |
| **400** | Invalid request |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="downloadbatchsearchreport"></a>
# **DownloadBatchSearchReport**
> FileParameter DownloadBatchSearchReport (DownloadBatchSearchReportRequest requestParameters)

Download batch search results in a csv file.

Downloads the report for a specific batch search using the batch search ID.

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
    public class DownloadBatchSearchReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new DownloadBatchSearchReportRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.Id = 2f5ea4b5-4dae-445a-b3e4-9f65a61eaa99;  // string | The ID of the batch search whose report is to be downloaded.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\" (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 

            try
            {
                // Download batch search results in a csv file.
                FileParameter result = apiInstance.DownloadBatchSearchReport(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.DownloadBatchSearchReport: " + e.Message );
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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **Id** | **string**| The ID of the batch search whose report is to be downloaded. | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot; | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful report download |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **404** | Report not found |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getbatchsearchdetail"></a>
# **GetBatchSearchDetail**
> BatchSearch GetBatchSearchDetail (GetBatchSearchDetailRequest requestParameters)

Get the batch search details for a given id.

Get the batch search details for a given id.

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
    public class GetBatchSearchDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new GetBatchSearchDetailRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.Id = 2f5ea4b5-4dae-445a-b3e4-9f65a61eaa99;  // string | The ID of the batch search that was submitted earlier.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\" (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 

            try
            {
                // Get the batch search details for a given id.
                BatchSearch result = apiInstance.GetBatchSearchDetail(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.GetBatchSearchDetail: " + e.Message );
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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **Id** | **string**| The ID of the batch search that was submitted earlier. | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot; | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 

### Return type

[**BatchSearch**](BatchSearch.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get the batch search details for a given id. |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listbatchsearches"></a>
# **ListBatchSearches**
> BatchSearchListResponse ListBatchSearches (ListBatchSearchesRequest requestParameters)

List all batch searches that were previously submitted.

Retrieves all batch searches performed by the user.

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
    public class ListBatchSearchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new ListBatchSearchesRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\" (optional) 
            requestParameters.Filter = name eq 'Batch_Search_Import_V4';  // string | Filter by field name and value. This filter only supports <code>eq</code> .The parameters supported is <code>name</code>.    Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided parameters. (optional) 
            requestParameters.Count = true;  // bool? | When set to true, the count of the collection is included as @recordSetCount in the response body. (optional) 
            requestParameters.Top = 10;  // string | If nonzero, return no more than this number of results. Used with <code>$skip</code> to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 200 records. (optional) 
            requestParameters.Skip = 10;  // string | If nonzero, skip this number of results before returning data. Used with <code>$top</code> to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = name desc;  // string | The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 

            try
            {
                // List all batch searches that were previously submitted.
                BatchSearchListResponse result = apiInstance.ListBatchSearches(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.ListBatchSearches: " + e.Message );
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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot; | [optional] 
 **Filter** | **string**| Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; .The parameters supported is &lt;code&gt;name&lt;/code&gt;.    Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided parameters. | [optional] 
 **Count** | **bool?**| When set to true, the count of the collection is included as @recordSetCount in the response body. | [optional] 
 **Top** | **string**| If nonzero, return no more than this number of results. Used with &lt;code&gt;$skip&lt;/code&gt; to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 200 records. | [optional] 
 **Skip** | **string**| If nonzero, skip this number of results before returning data. Used with &lt;code&gt;$top&lt;/code&gt; to provide pagination for large datasets. | [optional] 
 **OrderBy** | **string**| The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 

### Return type

[**BatchSearchListResponse**](BatchSearchListResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of batch searches |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="searchparticipants"></a>
# **SearchParticipants**
> DirectorySearchResponse SearchParticipants (SearchParticipantsRequest requestParameters)

Returns a list of participants matching the input query.

Returns a list of participants matching the input query.

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
    public class SearchParticipantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new SearchParticipantsRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.Search = Acme and 7726627177 or BMW;  // string | Search by value supports logical AND and OR. Refer to [https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview#search](https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview#search) for more information on search. Search will be done over <code>name</code> and <code>identifier</code> parameters only.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\" (optional) 
            requestParameters.Count = true;  // bool? | When set to true, the count of the collection is included as @recordSetCount in the response body. (optional) 
            requestParameters.Filter = network eq 'Peppol' and country eq 'Australia';  // string | Filter by field name and value. This filter only supports <code>eq</code> .The parameters supported are <code>network</code>, <code>country</code>, <code>documentType</code>, <code>idType</code>.          Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided parameters. (optional) 
            requestParameters.Top = 10;  // string | If nonzero, return no more than this number of results. Used with <code>$skip</code> to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 200 records. (optional) 
            requestParameters.Skip = 10;  // string | If nonzero, skip this number of results before returning data. Used with <code>$top</code> to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = name desc;  // string | The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 

            try
            {
                // Returns a list of participants matching the input query.
                DirectorySearchResponse result = apiInstance.SearchParticipants(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.SearchParticipants: " + e.Message );
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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **Search** | **string**| Search by value supports logical AND and OR. Refer to [https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview#search](https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview#search) for more information on search. Search will be done over &lt;code&gt;name&lt;/code&gt; and &lt;code&gt;identifier&lt;/code&gt; parameters only. | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot; | [optional] 
 **Count** | **bool?**| When set to true, the count of the collection is included as @recordSetCount in the response body. | [optional] 
 **Filter** | **string**| Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; .The parameters supported are &lt;code&gt;network&lt;/code&gt;, &lt;code&gt;country&lt;/code&gt;, &lt;code&gt;documentType&lt;/code&gt;, &lt;code&gt;idType&lt;/code&gt;.          Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. Filtering will be done over the provided parameters. | [optional] 
 **Top** | **string**| If nonzero, return no more than this number of results. Used with &lt;code&gt;$skip&lt;/code&gt; to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 200 records. | [optional] 
 **Skip** | **string**| If nonzero, skip this number of results before returning data. Used with &lt;code&gt;$top&lt;/code&gt; to provide pagination for large datasets. | [optional] 
 **OrderBy** | **string**| The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 

### Return type

[**DirectorySearchResponse**](DirectorySearchResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Correlation-Id -  <br>  |
| **400** | Bad request |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

