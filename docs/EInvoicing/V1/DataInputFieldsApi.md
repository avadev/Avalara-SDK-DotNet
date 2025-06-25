# Avalara.SDK.Api.EInvoicing.V1.DataInputFieldsApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataInputFields**](DataInputFieldsApi.md#getdatainputfields) | **GET** /data-input-fields | Returns the optionality of document fields for different country mandates


<a name="getdatainputfields"></a>
# **GetDataInputFields**
> DataInputFieldsResponse GetDataInputFields (GetDataInputFieldsRequest requestParameters)

Returns the optionality of document fields for different country mandates

This endpoint provides a list of required, conditional, and optional fields for each country mandate. You can use the <code>mandates</code> endpoint to retrieve all available country mandates. You can use the $filter query parameter to retrieve fields for a particular mandate

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
            var requestParameters = new GetDataInputFieldsRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint. (optional) 
            requestParameters.Filter = requiredFor/countryMandate eq AU-B2G-PEPPOL;  // string | Filter by field name and value. This filter only supports <code>eq</code> and <code>contains</code>. Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. (optional) 
            requestParameters.Top = 10;  // decimal? | If nonzero, return no more than this number of results. Used with <code>$skip</code> to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional) 
            requestParameters.Skip = 10;  // decimal? | If nonzero, skip this number of results before returning data. Used with <code>$top</code> to provide pagination for large datasets. (optional) 
            requestParameters.Count = true;  // bool? | When set to true, the count of the collection is also returned in the response body (optional) 
            requestParameters.CountOnly = true;  // bool? | When set to true, only the count of the collection is returned (optional) 

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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint. | [optional] 
 **Filter** | **string**| Filter by field name and value. This filter only supports &lt;code&gt;eq&lt;/code&gt; and &lt;code&gt;contains&lt;/code&gt;. Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. | [optional] 
 **Top** | **decimal?**| If nonzero, return no more than this number of results. Used with &lt;code&gt;$skip&lt;/code&gt; to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] 
 **Skip** | **decimal?**| If nonzero, skip this number of results before returning data. Used with &lt;code&gt;$top&lt;/code&gt; to provide pagination for large datasets. | [optional] 
 **Count** | **bool?**| When set to true, the count of the collection is also returned in the response body | [optional] 
 **CountOnly** | **bool?**| When set to true, only the count of the collection is returned | [optional] 

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
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

