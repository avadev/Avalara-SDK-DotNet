# Avalara.SDK.Api.A1099.V2.FormsW9Api

All URIs are relative to *https://api.sbx.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAndSendW9FormEmail**](FormsW9Api.md#createandsendw9formemail) | **POST** /w9/forms/$create-and-send-email | Create a minimal W9/W4/W8 form and sends the e-mail request
[**CreateW9Form**](FormsW9Api.md#createw9form) | **POST** /w9/forms | Create a W9/W4/W8 form
[**DeleteW9Form**](FormsW9Api.md#deletew9form) | **DELETE** /w9/forms/{id} | Delete a W9/W4/W8 form
[**GetW9Form**](FormsW9Api.md#getw9form) | **GET** /w9/forms/{id} | Retrieve a W9/W4/W8 form
[**GetW9FormPdf**](FormsW9Api.md#getw9formpdf) | **GET** /w9/forms/{id}/pdf | Download the PDF for a W9/W4/W8 form.
[**ListW9Forms**](FormsW9Api.md#listw9forms) | **GET** /w9/forms | List W9/W4/W8 forms
[**SendW9FormEmail**](FormsW9Api.md#sendw9formemail) | **POST** /w9/forms/{id}/$send-email | Send an email to the vendor/payee requesting they fill out a W9/W4/W8 form
[**UpdateW9Form**](FormsW9Api.md#updatew9form) | **PUT** /w9/forms/{id} | Update a W9/W4/W8 form
[**UploadW9Files**](FormsW9Api.md#uploadw9files) | **POST** /w9/forms/{id}/attachment | Replace the PDF file for a W9/W4/W8 form


<a name="createandsendw9formemail"></a>
# **CreateAndSendW9FormEmail**
> CreateW9Form201Response CreateAndSendW9FormEmail (CreateAndSendW9FormEmailRequestSdk requestParameters)

Create a minimal W9/W4/W8 form and sends the e-mail request

Create a minimal W9/W4/W8 form and sends the e-mail request.

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
    public class CreateAndSendW9FormEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new CreateAndSendW9FormEmailRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = c38d2382-701f-45cd-a8f6-1266dffa2568;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.CreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(); // CreateAndSendW9FormEmailRequest | Form to be created (optional) 

            try
            {
                // Create a minimal W9/W4/W8 form and sends the e-mail request
                CreateW9Form201Response result = apiInstance.CreateAndSendW9FormEmail(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.CreateAndSendW9FormEmail: " + e.Message );
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
 **CreateAndSendW9FormEmailRequest** | [**CreateAndSendW9FormEmailRequest**](CreateAndSendW9FormEmailRequest.md)| Form to be created | [optional] 

### Return type

[**CreateW9Form201Response**](CreateW9Form201Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created W9/W4/W8 form |  -  |
| **400** | Bad request (e.g. Unknown form type: W10\&quot;) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="createw9form"></a>
# **CreateW9Form**
> CreateW9Form201Response CreateW9Form (CreateW9FormRequestSdk requestParameters)

Create a W9/W4/W8 form

Create a W9/W4/W8 form.

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
    public class CreateW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new CreateW9FormRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = b9de84ae-a81f-4bea-8e20-636f527a793a;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.CreateW9FormRequest = new CreateW9FormRequest(); // CreateW9FormRequest | Form to be created (optional) 

            try
            {
                // Create a W9/W4/W8 form
                CreateW9Form201Response result = apiInstance.CreateW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.CreateW9Form: " + e.Message );
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
 **CreateW9FormRequest** | [**CreateW9FormRequest**](CreateW9FormRequest.md)| Form to be created | [optional] 

### Return type

[**CreateW9Form201Response**](CreateW9Form201Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created W9/W4/W8 form |  -  |
| **400** | Bad request (e.g., missing required field) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deletew9form"></a>
# **DeleteW9Form**
> void DeleteW9Form (DeleteW9FormRequestSdk requestParameters)

Delete a W9/W4/W8 form

Delete a W9/W4/W8 form.

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
    public class DeleteW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new DeleteW9FormRequestSdk();
            requestParameters.Id = "id_example";  // string | ID of the form to delete
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 7c3b1d91-24b2-4837-81f3-53dfee39af27;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Delete a W9/W4/W8 form
                apiInstance.DeleteW9Form(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.DeleteW9Form: " + e.Message );
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
 **Id** | **string**| ID of the form to delete | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Empty response |  -  |
| **401** | Authentication failed |  -  |
| **404** | W9/W4/W8 form not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getw9form"></a>
# **GetW9Form**
> CreateW9Form201Response GetW9Form (GetW9FormRequestSdk requestParameters)

Retrieve a W9/W4/W8 form

Retrieve a W9/W4/W8 form.

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
    public class GetW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new GetW9FormRequestSdk();
            requestParameters.Id = "id_example";  // string | ID of the form
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 762f55d1-2a73-4d5b-bf72-8cfe3eeb88a2;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Retrieve a W9/W4/W8 form
                CreateW9Form201Response result = apiInstance.GetW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.GetW9Form: " + e.Message );
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
 **Id** | **string**| ID of the form | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**CreateW9Form201Response**](CreateW9Form201Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | W9/W4/W8 form with id |  -  |
| **401** | Authentication failed |  -  |
| **404** | W9/W4/W8 form not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getw9formpdf"></a>
# **GetW9FormPdf**
> FileParameter GetW9FormPdf (GetW9FormPdfRequestSdk requestParameters)

Download the PDF for a W9/W4/W8 form.

Returns the PDF file for a W9/W4/W8 form.

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
    public class GetW9FormPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new GetW9FormPdfRequestSdk();
            requestParameters.Id = "id_example";  // string | Id of the form
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 89d3ec3b-0f67-45c9-a2ca-4962052f518c;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Download the PDF for a W9/W4/W8 form.
                FileParameter result = apiInstance.GetW9FormPdf(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.GetW9FormPdf: " + e.Message );
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
 **Id** | **string**| Id of the form | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listw9forms"></a>
# **ListW9Forms**
> PaginatedQueryResultModelW9FormBaseResponse ListW9Forms (ListW9FormsRequestSdk requestParameters)

List W9/W4/W8 forms

List W9/W4/W8 forms. Filterable/Sortable fields are: \"companyId\", \"type\", \"displayName\", \"entryStatus\", \"email\", \"archived\" and \"referenceId\".

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
    public class ListW9FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new ListW9FormsRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve.  For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 56;  // int? | If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. (optional) 
            requestParameters.Skip = 56;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | If true, return the global count of elements in the collection. (optional) 
            requestParameters.CountOnly = true;  // bool? | If true, return ONLY the global count of elements in the collection.  It only applies when count=true. (optional) 
            requestParameters.XCorrelationId = ce3e18ce-6c27-4e4d-8d1f-86e3c4edb2f8;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // List W9/W4/W8 forms
                PaginatedQueryResultModelW9FormBaseResponse result = apiInstance.ListW9Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.ListW9Forms: " + e.Message );
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
 **Filter** | **string**| A filter statement to identify specific records to retrieve.  For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;. | [optional] 
 **Top** | **int?**| If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. | [optional] 
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] 
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| If true, return the global count of elements in the collection. | [optional] 
 **CountOnly** | **bool?**| If true, return ONLY the global count of elements in the collection.  It only applies when count&#x3D;true. | [optional] 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**PaginatedQueryResultModelW9FormBaseResponse**](PaginatedQueryResultModelW9FormBaseResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="sendw9formemail"></a>
# **SendW9FormEmail**
> CreateW9Form201Response SendW9FormEmail (SendW9FormEmailRequestSdk requestParameters)

Send an email to the vendor/payee requesting they fill out a W9/W4/W8 form

Send an email to the vendor/payee requesting they fill out a W9/W4/W8 form.  If the form is not in 'Requested' status, it will either use an existing descendant form  in 'Requested' status or create a new minimal form and send the email request.

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
    public class SendW9FormEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new SendW9FormEmailRequestSdk();
            requestParameters.Id = "id_example";  // string | The ID of the W9/W4/W8 form.
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 0984d2ea-40e7-4c14-8df6-4fb38d7b58bf;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Send an email to the vendor/payee requesting they fill out a W9/W4/W8 form
                CreateW9Form201Response result = apiInstance.SendW9FormEmail(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.SendW9FormEmail: " + e.Message );
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
 **Id** | **string**| The ID of the W9/W4/W8 form. | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**CreateW9Form201Response**](CreateW9Form201Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email sent using existing form (form was already in &#39;Requested&#39; status or descendant found) |  -  |
| **201** | Email sent using newly created minimal form |  -  |
| **400** | Bad request (e.g., missing vendor e-mail) |  -  |
| **401** | Authentication failed |  -  |
| **404** | W9/W4/W8 form not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updatew9form"></a>
# **UpdateW9Form**
> CreateW9Form201Response UpdateW9Form (UpdateW9FormRequestSdk requestParameters)

Update a W9/W4/W8 form

Update a W9/W4/W8 form.

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
    public class UpdateW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new UpdateW9FormRequestSdk();
            requestParameters.Id = "id_example";  // string | ID of the form to update
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = a9ecdca0-c53b-475a-b5b2-2bab07d1a4ae;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.CreateW9FormRequest = new CreateW9FormRequest(); // CreateW9FormRequest | Form to be updated (optional) 

            try
            {
                // Update a W9/W4/W8 form
                CreateW9Form201Response result = apiInstance.UpdateW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.UpdateW9Form: " + e.Message );
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
 **Id** | **string**| ID of the form to update | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 
 **CreateW9FormRequest** | [**CreateW9FormRequest**](CreateW9FormRequest.md)| Form to be updated | [optional] 

### Return type

[**CreateW9Form201Response**](CreateW9Form201Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated W9/W4/W8 form |  -  |
| **400** | Bad request (e.g., missing required field) |  -  |
| **401** | Authentication failed |  -  |
| **404** | W9/W4/W8 form not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="uploadw9files"></a>
# **UploadW9Files**
> void UploadW9Files (UploadW9FilesRequestSdk requestParameters)

Replace the PDF file for a W9/W4/W8 form

Replaces the PDF file for a W9/W4/W8 form.

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
    public class UploadW9FilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormsW9Api(apiClient);
            var requestParameters = new UploadW9FilesRequestSdk();
            requestParameters.Id = "id_example";  // string | Id of the form
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = e92920ea-0dfb-498f-a01c-b883102a2868;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.File = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Replace the PDF file for a W9/W4/W8 form
                apiInstance.UploadW9Files(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormsW9Api.UploadW9Files: " + e.Message );
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
 **Id** | **string**| Id of the form | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 
 **File** | **FileParameter****FileParameter**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request (e.g., only .pdf files are allowed.) |  -  |
| **401** | Authentication failed |  -  |
| **404** | W9/W4/W8 form not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

