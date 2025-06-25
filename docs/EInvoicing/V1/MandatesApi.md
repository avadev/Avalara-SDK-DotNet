# Avalara.SDK.Api.EInvoicing.V1.MandatesApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMandateDataInputFields**](MandatesApi.md#getmandatedatainputfields) | **GET** /mandates/{mandateId}/data-input-fields | Returns document field information for a country mandate, a selected document type, and its version
[**GetMandates**](MandatesApi.md#getmandates) | **GET** /mandates | List country mandates that are supported by the Avalara E-Invoicing platform


<a name="getmandatedatainputfields"></a>
# **GetMandateDataInputFields**
> List&lt;MandateDataInputField&gt; GetMandateDataInputFields (GetMandateDataInputFieldsRequest requestParameters)

Returns document field information for a country mandate, a selected document type, and its version

This endpoint provides document field details and the optionality of fields (required, conditional, optional) of different documents supported by the country mandate. Use the GET <code>/mandates</code> endpoint to retrieve all available country mandates, their supported document types and supported versions. You can use the `documentType` and `documentVersion` query parameters to retrieve the input fields for a particular document type and document version.

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
    public class GetMandateDataInputFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new MandatesApi(apiClient);
            var requestParameters = new GetMandateDataInputFieldsRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.MandateId = AD-B2G-PEPPOL;  // string | The unique ID for the mandate that was returned in the GET /einvoicing/mandates response body
            requestParameters.DocumentType = ubl-invoice;  // string | Select the documentType for which you wish to view the data-input-fields (You may obtain the supported documentTypes from the GET /mandates endpoint)
            requestParameters.DocumentVersion = 2.1;  // string | Select the document version of the documentType (You may obtain the supported documentVersion from the GET /mandates endpoint)
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint. (optional) 

            try
            {
                // Returns document field information for a country mandate, a selected document type, and its version
                List<MandateDataInputField> result = apiInstance.GetMandateDataInputFields(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MandatesApi.GetMandateDataInputFields: " + e.Message );
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
 **MandateId** | **string**| The unique ID for the mandate that was returned in the GET /einvoicing/mandates response body | 
 **DocumentType** | **string**| Select the documentType for which you wish to view the data-input-fields (You may obtain the supported documentTypes from the GET /mandates endpoint) | 
 **DocumentVersion** | **string**| Select the document version of the documentType (You may obtain the supported documentVersion from the GET /mandates endpoint) | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint. | [optional] 

### Return type

[**List&lt;MandateDataInputField&gt;**](MandateDataInputField.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getmandates"></a>
# **GetMandates**
> MandatesResponse GetMandates (GetMandatesRequest requestParameters)

List country mandates that are supported by the Avalara E-Invoicing platform

This endpoint offers a list of country mandates supported by the Avalara E-Invoicing API.

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
    public class GetMandatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new MandatesApi(apiClient);
            var requestParameters = new GetMandatesRequest();
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a fingerprint. (optional) 
            requestParameters.Filter = countryMandate eq DE-B2G-PEPPOL;  // string | Filter by field name and value. This filter only supports <code>eq</code> and <code>contains</code>. Refer to [https://developer.avalara.com/avatax/filtering-in-rest/](https://developer.avalara.com/avatax/filtering-in-rest/) for more information on filtering. (optional) 
            requestParameters.Top = 10;  // decimal? | If nonzero, return no more than this number of results. Used with <code>$skip</code> to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional) 
            requestParameters.Skip = 10;  // decimal? | If nonzero, skip this number of results before returning data. Used with <code>$top</code> to provide pagination for large datasets. (optional) 
            requestParameters.Count = true;  // bool? | When set to true, the count of the collection is also returned in the response body. (optional) 
            requestParameters.CountOnly = true;  // bool? | When set to true, only the count of the collection is returned (optional) 

            try
            {
                // List country mandates that are supported by the Avalara E-Invoicing platform
                MandatesResponse result = apiInstance.GetMandates(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MandatesApi.GetMandates: " + e.Message );
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
 **Count** | **bool?**| When set to true, the count of the collection is also returned in the response body. | [optional] 
 **CountOnly** | **bool?**| When set to true, only the count of the collection is returned | [optional] 

### Return type

[**MandatesResponse**](MandatesResponse.md)

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
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

