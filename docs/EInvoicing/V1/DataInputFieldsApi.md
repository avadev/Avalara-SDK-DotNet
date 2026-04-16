# Avalara.SDK.Api.EInvoicing.V1.DataInputFieldsApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataInputFields**](DataInputFieldsApi.md#getdatainputfields) | **GET** /data-input-fields | Returns the optionality of document fields for different country mandates


<a name="getdatainputfields"></a>
# **GetDataInputFields**
> DataInputFieldsResponse GetDataInputFields (GetDataInputFieldsRequestSdk requestParameters)

Returns the optionality of document fields for different country mandates

This endpoint returns a list of required, conditional, and optional fields for each country mandate. Use the mandates endpoint to retrieve all available country mandates. Use the $filter query parameter to retrieve fields for a specific mandate.

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
    public class GetDataInputFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new DataInputFieldsApi(apiClient);
            var requestParameters = new GetDataInputFieldsRequestSdk();
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.Filter = requiredFor/countryMandate eq AU-B2G-PEPPOL;  // string | Filter by field name and value. This filter supports only eq and contains. For more information, refer to the Avalara filtering guide. (optional) 
            requestParameters.Top = 56;  // int? | The number of items to include in the result. (optional) 
            requestParameters.Skip = 56;  // int? | The number of items to skip in the result. (optional) 
            requestParameters.Count = true;  // bool? | When set to true, the response body also includes the count of items in the collection. (optional) 
            requestParameters.CountOnly = true;  // bool? | When set to true, the response returns only the count of items in the collection. (optional) 

            try
            {
                // Returns the optionality of document fields for different country mandates
                DataInputFieldsResponse result = apiInstance.GetDataInputFields(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataInputFieldsApi.GetDataInputFields: " + e.Message );
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
 **Filter** | **string**| Filter by field name and value. This filter supports only eq and contains. For more information, refer to the Avalara filtering guide. | [optional] 
 **Top** | **int?**| The number of items to include in the result. | [optional] 
 **Skip** | **int?**| The number of items to skip in the result. | [optional] 
 **Count** | **bool?**| When set to true, the response body also includes the count of items in the collection. | [optional] 
 **CountOnly** | **bool?**| When set to true, the response returns only the count of items in the collection. | [optional] 

### Return type

[**DataInputFieldsResponse**](DataInputFieldsResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a DataInputFieldsResponse object containing the data input fields and their optionality for the requested mandate. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

