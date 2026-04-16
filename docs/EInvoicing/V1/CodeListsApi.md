# Avalara.SDK.Api.EInvoicing.V1.CodeListsApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCodeList**](CodeListsApi.md#getcodelist) | **GET** /codelists/{codelistId} | Retrieves a code list by ID for a specific country
[**GetCodeListList**](CodeListsApi.md#getcodelistlist) | **GET** /codelists | Returns a list of code lists for a specific country


<a name="getcodelist"></a>
# **GetCodeList**
> CodeListResponse GetCodeList (GetCodeListRequestSdk requestParameters)

Retrieves a code list by ID for a specific country

A Code List is a controlled set of predefined, standardized values used to populate specific fields in electronic documents (such as e-invoices). Each code has a stable, machine-readable identifier and a human-readable description. Code Lists are typically based on global standards (e.g., UN/CEFACT, ISO, EN16931) and may include jurisdiction-specific extensions or restrictions.<br><br>Code Lists are versioned, and each version may have defined effective and sunset dates to ensure that the correct set of allowable values is applied according to regulatory or jurisdictional requirements.<br><br>By default, the API returns only non-expired code list versions (versions where the sunset date has not passed). To retrieve expired versions or filter by specific date ranges, use the <code>effectiveDate</code> and <code>sunsetDate</code> query parameters.

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
    public class GetCodeListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CodeListsApi(apiClient);
            var requestParameters = new GetCodeListRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.CodelistId = ab123343-3432-423c-ac3f-53453scs9999;  // string | System-generated unique identifier of the code list definition. Typically a UUID used to reference this code list internally or via APIs.
            requestParameters.CountryCode = FR;  // string | Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction this code list applies to.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.EffectiveDate = Tue Dec 31 16:00:00 PST 2024;  // DateTime? | Filter code list versions by effective date. Returns versions that are effective on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, defaults to the current date. sunsetDate is required when effectiveDate is provided. (optional) 
            requestParameters.SunsetDate = Wed Dec 30 16:00:00 PST 2026;  // DateTime? | Filter code list versions by sunset date. Returns versions that have not yet sunset on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, only non-expired versions are returned. (optional) 

            try
            {
                // Retrieves a code list by ID for a specific country
                CodeListResponse result = apiInstance.GetCodeList(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CodeListsApi.GetCodeList: " + e.Message );
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
 **CodelistId** | **string**| System-generated unique identifier of the code list definition. Typically a UUID used to reference this code list internally or via APIs. | 
 **CountryCode** | **string**| Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction this code list applies to. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **EffectiveDate** | **DateTime?**| Filter code list versions by effective date. Returns versions that are effective on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, defaults to the current date. sunsetDate is required when effectiveDate is provided. | [optional] 
 **SunsetDate** | **DateTime?**| Filter code list versions by sunset date. Returns versions that have not yet sunset on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, only non-expired versions are returned. | [optional] 

### Return type

[**CodeListResponse**](CodeListResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |
| **404** | Code list not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getcodelistlist"></a>
# **GetCodeListList**
> CodeListListResponse GetCodeListList (GetCodeListListRequestSdk requestParameters)

Returns a list of code lists for a specific country

Get a list of code lists on the Avalara E-Invoicing platform for the specified country. By default, the API returns only non-expired code lists (code lists where the sunset date has not passed). To retrieve expired code lists or filter by specific date ranges, use the <code>effectiveDate</code> and <code>sunsetDate</code> query parameters.<br><br>A Code List is a controlled set of predefined, standardized values used to populate specific fields in electronic documents (such as e-invoices). Each code has a stable, machine-readable identifier and a human-readable description. Code Lists are typically based on global standards (e.g., UN/CEFACT, ISO, EN16931) and may include jurisdiction-specific extensions or restrictions.

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
    public class GetCodeListListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CodeListsApi(apiClient);
            var requestParameters = new GetCodeListListRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.CountryCode = FR;  // string | Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction for which code lists should be returned.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.EffectiveDate = Tue Dec 31 16:00:00 PST 2024;  // DateTime? | Filter code lists by effective date. Returns code lists that are effective on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, defaults to the current date. sunsetDate is required when effectiveDate is provided. (optional) 
            requestParameters.SunsetDate = Wed Dec 30 16:00:00 PST 2026;  // DateTime? | Filter code lists by sunset date. Returns code lists that have not yet sunset on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, only non-expired code lists are returned. (optional) 
            requestParameters.Count = true;  // string | When set to true, the response body also includes the count of items in the collection. (optional) 
            requestParameters.CountOnly = false;  // string | When set to true, the response returns only the count of items in the collection. (optional) 
            requestParameters.Top = 56;  // int? | The number of items to include in the result. (optional) 
            requestParameters.Skip = 56;  // int? | The number of items to skip in the result. (optional) 

            try
            {
                // Returns a list of code lists for a specific country
                CodeListListResponse result = apiInstance.GetCodeListList(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CodeListsApi.GetCodeListList: " + e.Message );
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
 **CountryCode** | **string**| Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction for which code lists should be returned. | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **EffectiveDate** | **DateTime?**| Filter code lists by effective date. Returns code lists that are effective on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, defaults to the current date. sunsetDate is required when effectiveDate is provided. | [optional] 
 **SunsetDate** | **DateTime?**| Filter code lists by sunset date. Returns code lists that have not yet sunset on or before this date. Format: YYYY-MM-DD (ISO 8601). If not specified, only non-expired code lists are returned. | [optional] 
 **Count** | **string**| When set to true, the response body also includes the count of items in the collection. | [optional] 
 **CountOnly** | **string**| When set to true, the response returns only the count of items in the collection. | [optional] 
 **Top** | **int?**| The number of items to include in the result. | [optional] 
 **Skip** | **int?**| The number of items to skip in the result. | [optional] 

### Return type

[**CodeListListResponse**](CodeListListResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

