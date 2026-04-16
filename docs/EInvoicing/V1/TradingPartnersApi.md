# Avalara.SDK.Api.EInvoicing.V1.TradingPartnersApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchSearchParticipants**](TradingPartnersApi.md#batchsearchparticipants) | **POST** /trading-partners/batch-searches | Handles batch search requests by uploading a file containing search parameters.
[**CreateTradingPartner**](TradingPartnersApi.md#createtradingpartner) | **POST** /trading-partners | Creates a new trading partner.
[**CreateTradingPartnersBatch**](TradingPartnersApi.md#createtradingpartnersbatch) | **POST** /trading-partners/batch | Creates a batch of multiple trading partners.
[**DeleteTradingPartner**](TradingPartnersApi.md#deletetradingpartner) | **DELETE** /trading-partners/{id} | Deletes a trading partner using ID.
[**DownloadBatchSearchReport**](TradingPartnersApi.md#downloadbatchsearchreport) | **GET** /trading-partners/batch-searches/{id}/$download-results | Downloads batch search results in a csv file.
[**GetBatchSearchDetail**](TradingPartnersApi.md#getbatchsearchdetail) | **GET** /trading-partners/batch-searches/{id} | Returns the batch search details using ID.
[**ListBatchSearches**](TradingPartnersApi.md#listbatchsearches) | **GET** /trading-partners/batch-searches | Lists all batch searches that were previously submitted.
[**SearchParticipants**](TradingPartnersApi.md#searchparticipants) | **GET** /trading-partners | Returns a list of participants matching the input query.
[**UpdateTradingPartner**](TradingPartnersApi.md#updatetradingpartner) | **PUT** /trading-partners/{id} | Updates a trading partner using ID.


<a name="batchsearchparticipants"></a>
# **BatchSearchParticipants**
> BatchSearchParticipants202Response BatchSearchParticipants (BatchSearchParticipantsRequestSdk requestParameters)

Handles batch search requests by uploading a file containing search parameters.

This endpoint creates a batch search and performs a batch search in the directory for participants in the background.

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
            var requestParameters = new BatchSearchParticipantsRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.Name = Automotive Companies in London Search;  // string | A human-readable name for the batch search.
            requestParameters.NotificationEmail = user@example.com;  // string | The email address to which a notification will be sent once the batch search is complete.
            requestParameters.File = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | CSV file containing search parameters.  Input Constraints: - Maximum file size: 1 MB - File Header: Must be less than 500 KB - Total number of lines (including header): Must be 101 or fewer
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Handles batch search requests by uploading a file containing search parameters.
                BatchSearchParticipants202Response result = apiInstance.BatchSearchParticipants(requestParameters);
                Debug.WriteLine(result);
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **Name** | **string**| A human-readable name for the batch search. | 
 **NotificationEmail** | **string**| The email address to which a notification will be sent once the batch search is complete. | 
 **File** | **FileParameter****FileParameter**| CSV file containing search parameters.  Input Constraints: - Maximum file size: 1 MB - File Header: Must be less than 500 KB - Total number of lines (including header): Must be 101 or fewer | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**BatchSearchParticipants202Response**](BatchSearchParticipants202Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Batch search file accepted for processing the search. |  * X-Correlation-ID -  <br>  |
| **400** | Invalid request |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="createtradingpartner"></a>
# **CreateTradingPartner**
> CreateTradingPartner201Response CreateTradingPartner (CreateTradingPartnerRequestSdk requestParameters)

Creates a new trading partner.

This endpoint creates a new trading partner with the provided details. The request body must include the necessary information as defined in the `TradingPartner` schema.

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
    public class CreateTradingPartnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new CreateTradingPartnerRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.TradingPartner = new TradingPartner(); // TradingPartner | 
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Creates a new trading partner.
                CreateTradingPartner201Response result = apiInstance.CreateTradingPartner(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.CreateTradingPartner: " + e.Message );
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
 **TradingPartner** | [**TradingPartner**](TradingPartner.md)|  | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**CreateTradingPartner201Response**](CreateTradingPartner201Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The trading partner has been successfully created. |  * X-Correlation-ID -  <br>  |
| **400** | Bad request |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden. |  * X-Correlation-ID -  <br>  |
| **409** | Conflict |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="createtradingpartnersbatch"></a>
# **CreateTradingPartnersBatch**
> CreateTradingPartnersBatch200Response CreateTradingPartnersBatch (CreateTradingPartnersBatchRequestSdk requestParameters)

Creates a batch of multiple trading partners.

This endpoint creates multiple trading partners in a single batch request. It accepts an array of trading partners and processes them synchronously. Supports a maximum of 100 records or a 1 MB request payload.

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
    public class CreateTradingPartnersBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new CreateTradingPartnersBatchRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.CreateTradingPartnersBatchRequest = new CreateTradingPartnersBatchRequest(); // CreateTradingPartnersBatchRequest | 
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Creates a batch of multiple trading partners.
                CreateTradingPartnersBatch200Response result = apiInstance.CreateTradingPartnersBatch(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.CreateTradingPartnersBatch: " + e.Message );
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
 **CreateTradingPartnersBatchRequest** | [**CreateTradingPartnersBatchRequest**](CreateTradingPartnersBatchRequest.md)|  | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**CreateTradingPartnersBatch200Response**](CreateTradingPartnersBatch200Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch processing completed. Returns a list of created trading partners. |  * X-Correlation-ID -  <br>  |
| **400** | Bad request |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden. |  * X-Correlation-ID -  <br>  |
| **409** | Conflict |  * X-Correlation-ID -  <br>  |
| **413** | ContentTooLarge |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deletetradingpartner"></a>
# **DeleteTradingPartner**
> void DeleteTradingPartner (DeleteTradingPartnerRequestSdk requestParameters)

Deletes a trading partner using ID.

This endpoint deletes an existing trading partner identified by the provided ID.

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
    public class DeleteTradingPartnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new DeleteTradingPartnerRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.Id = "id_example";  // string | Unique identifier of the trading partner.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Deletes a trading partner using ID.
                apiInstance.DeleteTradingPartner(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.DeleteTradingPartner: " + e.Message );
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
 **Id** | **string**| Unique identifier of the trading partner. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

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
| **204** | Trading partner deleted successfully. |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden |  * X-Correlation-ID -  <br>  |
| **404** | NotFound |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="downloadbatchsearchreport"></a>
# **DownloadBatchSearchReport**
> FileParameter DownloadBatchSearchReport (DownloadBatchSearchReportRequestSdk requestParameters)

Downloads batch search results in a csv file.

This endpoint downloads the report for a specific batch search using the batch search ID. It returns a CSV file containing up to 1,000 query results.

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
            var requestParameters = new DownloadBatchSearchReportRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.Id = 2f5ea4b5-4dae-445a-b3e4-9f65a61eaa99;  // string | Unique identifier of the batch search for which to download the report.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Downloads batch search results in a csv file.
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **Id** | **string**| Unique identifier of the batch search for which to download the report. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

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
| **200** | Successful report download. Returns a CSV file containing up to 1,000 query results. |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden. |  * X-Correlation-ID -  <br>  |
| **404** | Report not found |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getbatchsearchdetail"></a>
# **GetBatchSearchDetail**
> BatchSearch GetBatchSearchDetail (GetBatchSearchDetailRequestSdk requestParameters)

Returns the batch search details using ID.

This endpoint returns detailed information for a specific batch search using the provided ID. It is useful for tracking the status and progress of a previously initiated batch search operation.

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
            var requestParameters = new GetBatchSearchDetailRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.Id = 2f5ea4b5-4dae-445a-b3e4-9f65a61eaa99;  // string | Unique identifier of the batch search.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Returns the batch search details using ID.
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **Id** | **string**| Unique identifier of the batch search. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

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
| **200** | Returns the batch search details for the specified ID. |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden |  * X-Correlation-ID -  <br>  |
| **404** | Report not found |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listbatchsearches"></a>
# **ListBatchSearches**
> BatchSearchListResponse ListBatchSearches (ListBatchSearchesRequestSdk requestParameters)

Lists all batch searches that were previously submitted.

This endpoint retrieves a list of all batch search operations that have been previously submitted. It returns details such as the batch search ID, status, creation date, and associated metadata. It is useful for tracking the progress of a previously initiated batch search operations.

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
            var requestParameters = new ListBatchSearchesRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.Filter = name eq 'Batch_Search_Import_V4';  // string | Filters the results by field name. Only the eq operator and the name field are supported. For more information, refer to the Avalara filtering guide. (optional) 
            requestParameters.Count = true;  // bool? | When set to <code>true</code>, returns the total count of matching records included as <code>@recordSetCount</code> in the response body. (optional) 
            requestParameters.Top = 56;  // int? | The number of items to include in the result. (optional) 
            requestParameters.Skip = 56;  // int? | The number of items to skip in the result. (optional) 
            requestParameters.OrderBy = name desc;  // string | The <code>$orderBy</code> query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Lists all batch searches that were previously submitted.
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **Filter** | **string**| Filters the results by field name. Only the eq operator and the name field are supported. For more information, refer to the Avalara filtering guide. | [optional] 
 **Count** | **bool?**| When set to &lt;code&gt;true&lt;/code&gt;, returns the total count of matching records included as &lt;code&gt;@recordSetCount&lt;/code&gt; in the response body. | [optional] 
 **Top** | **int?**| The number of items to include in the result. | [optional] 
 **Skip** | **int?**| The number of items to skip in the result. | [optional] 
 **OrderBy** | **string**| The &lt;code&gt;$orderBy&lt;/code&gt; query parameter specifies the field and sorting direction for ordering the result set. The value is a string that combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

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
| **200** | Returns a collection of batch searches. |  * X-Correlation-ID -  <br>  |
| **400** | Bad request |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="searchparticipants"></a>
# **SearchParticipants**
> SearchParticipants200Response SearchParticipants (SearchParticipantsRequestSdk requestParameters)

Returns a list of participants matching the input query.

This endpoint retrieves a list of trading partners that match the specified search criteria. It supports filtering, search text, and other relevant query parameters to narrow down the results.

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
            var requestParameters = new SearchParticipantsRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.Search = Acme AND 7726627177 OR BMW;  // string | Search by value supports logical AND and OR operators (case-sensitive). Search is performed only over the name and identifier value fields. For more information, refer to the OData query options overview documentation.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.Count = true;  // bool? | When set to true, returns the total count of matching records included as @recordSetCount in the response body. (optional) 
            requestParameters.Filter = network eq 'Peppol' and country eq 'Australia';  // string | Filters the results using the eq operator. Supported fields include network, country, documentType, and idType. For more information, refer to the Avalara filtering guide. (optional) 
            requestParameters.Top = 56;  // int? | The number of items to include in the result. (optional) 
            requestParameters.Skip = 56;  // int? | The number of items to skip in the result. (optional) 
            requestParameters.OrderBy = name desc;  // string | The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Returns a list of participants matching the input query.
                SearchParticipants200Response result = apiInstance.SearchParticipants(requestParameters);
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
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **Search** | **string**| Search by value supports logical AND and OR operators (case-sensitive). Search is performed only over the name and identifier value fields. For more information, refer to the OData query options overview documentation. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **Count** | **bool?**| When set to true, returns the total count of matching records included as @recordSetCount in the response body. | [optional] 
 **Filter** | **string**| Filters the results using the eq operator. Supported fields include network, country, documentType, and idType. For more information, refer to the Avalara filtering guide. | [optional] 
 **Top** | **int?**| The number of items to include in the result. | [optional] 
 **Skip** | **int?**| The number of items to skip in the result. | [optional] 
 **OrderBy** | **string**| The $orderBy query parameter specifies the field and sorting direction for ordering the result set. The value combines a field name and a sorting direction (asc for ascending or desc for descending), separated by a space. | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**SearchParticipants200Response**](SearchParticipants200Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a collection of trading partners matching the specified search criteria. |  * X-Correlation-ID -  <br>  |
| **400** | Bad request. |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden. |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updatetradingpartner"></a>
# **UpdateTradingPartner**
> UpdateTradingPartner200Response UpdateTradingPartner (UpdateTradingPartnerRequestSdk requestParameters)

Updates a trading partner using ID.

This endpoint updates the details of an existing trading partner specified by the provided ID. It performs a full update, and the request body must include all required fields.

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
    public class UpdateTradingPartnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TradingPartnersApi(apiClient);
            var requestParameters = new UpdateTradingPartnerRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.Id = "id_example";  // string | Unique identifier of the trading partner.
            requestParameters.TradingPartner = new TradingPartner(); // TradingPartner | 
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 

            try
            {
                // Updates a trading partner using ID.
                UpdateTradingPartner200Response result = apiInstance.UpdateTradingPartner(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingPartnersApi.UpdateTradingPartner: " + e.Message );
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
 **Id** | **string**| Unique identifier of the trading partner. | 
 **TradingPartner** | [**TradingPartner**](TradingPartner.md)|  | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 

### Return type

[**UpdateTradingPartner200Response**](UpdateTradingPartner200Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The trading partner has been successfully created. |  -  |
| **400** | Bad request |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden |  * X-Correlation-ID -  <br>  |
| **404** | NotFound |  * X-Correlation-ID -  <br>  |
| **409** | Conflict |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

