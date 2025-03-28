# Avalara.SDK.Api.A1099.V2.W4W8W9FormsApi

All URIs are relative to *https://api.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateW9Form**](W4W8W9FormsApi.md#createw9form) | **POST** /w9/forms | Create a new W9/W8/W4 form
[**GetW9Form**](W4W8W9FormsApi.md#getw9form) | **GET** /w9/forms/{formId} | Retrieve a W9/W8/W4 form
[**GetW9Forms**](W4W8W9FormsApi.md#getw9forms) | **GET** /w9/forms | List W9/W4/W8 forms.
[**W9FormRequestsFormRequestIdGet**](W4W8W9FormsApi.md#w9formrequestsformrequestidget) | **GET** /w9/form-requests/{formRequestId} | Get form request TODO-I Don&#39;t think this API should exist and instead we need &#x60;POST /w9/{id}/request&#x60;.


<a name="createw9form"></a>
# **CreateW9Form**
> W9FormDataModelsOneOf CreateW9Form (CreateW9FormRequest requestParameters)

Create a new W9/W8/W4 form

Creates a new W4, W8-BEN, W8-BEN-E W8-IMY or W9 form

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
            
            var apiInstance = new W4W8W9FormsApi(apiClient);
            var requestParameters = new CreateW9FormRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 
            requestParameters.W9FormDataModelsOneOf = new W9FormDataModelsOneOf(); // W9FormDataModelsOneOf | Form to be created (optional) 

            try
            {
                // Create a new W9/W8/W4 form
                W9FormDataModelsOneOf result = apiInstance.CreateW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W4W8W9FormsApi.CreateW9Form: " + e.Message );
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
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 
 **W9FormDataModelsOneOf** | [**W9FormDataModelsOneOf**](W9FormDataModelsOneOf.md)| Form to be created | [optional] 

### Return type

[**W9FormDataModelsOneOf**](W9FormDataModelsOneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created W9/W8/W4 form |  * Location - The location of the created W9 Company <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getw9form"></a>
# **GetW9Form**
> GetW9Form200Response GetW9Form (GetW9FormRequest requestParameters)

Retrieve a W9/W8/W4 form

Retreive a single W9/W8/W4 form by id

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
            
            var apiInstance = new W4W8W9FormsApi(apiClient);
            var requestParameters = new GetW9FormRequest();
            requestParameters.FormId = "formId_example";  // string | Unique id of the form
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Retrieve a W9/W8/W4 form
                GetW9Form200Response result = apiInstance.GetW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W4W8W9FormsApi.GetW9Form: " + e.Message );
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
 **FormId** | **string**| Unique id of the form | 
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**GetW9Form200Response**](GetW9Form200Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | W9/W8/W4 form with id |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getw9forms"></a>
# **GetW9Forms**
> PaginatedW9FormsModel GetW9Forms (GetW9FormsRequest requestParameters)

List W9/W4/W8 forms.

List all W4, W8-BEN, W8-BEN-E W8-IMY and W9 forms in a single list.

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
    public class GetW9FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W4W8W9FormsApi(apiClient);
            var requestParameters = new GetW9FormsRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = referenceId eq 'REF56789';  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>.  Filterable: referenceId, companyId, archived, ancestorId  (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = "\"false\"";  // bool? | Set true to request count of complete collection in response. (optional)  (default to "false")
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // List W9/W4/W8 forms.
                PaginatedW9FormsModel result = apiInstance.GetW9Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W4W8W9FormsApi.GetW9Forms: " + e.Message );
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
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **Filter** | **string**| A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.  Filterable: referenceId, companyId, archived, ancestorId  | [optional] 
 **Top** | **int?**| If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] [default to 10]
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] [default to 0]
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| Set true to request count of complete collection in response. | [optional] [default to &quot;false&quot;]
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**PaginatedW9FormsModel**](PaginatedW9FormsModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of forms |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="w9formrequestsformrequestidget"></a>
# **W9FormRequestsFormRequestIdGet**
> FormRequestModel W9FormRequestsFormRequestIdGet (W9FormRequestsFormRequestIdGetRequest requestParameters)

Get form request TODO-I Don't think this API should exist and instead we need `POST /w9/{id}/request`.

Retrieve a form request again after creation. Previously-valid form requests will be Not Found after `expiresAt`

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
    public class W9FormRequestsFormRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W4W8W9FormsApi(apiClient);
            var requestParameters = new W9FormRequestsFormRequestIdGetRequest();
            requestParameters.FormRequestId = "formRequestId_example";  // string | Id assigned during creation of the form request
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Get form request TODO-I Don't think this API should exist and instead we need `POST /w9/{id}/request`.
                FormRequestModel result = apiInstance.W9FormRequestsFormRequestIdGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W4W8W9FormsApi.W9FormRequestsFormRequestIdGet: " + e.Message );
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
 **FormRequestId** | **string**| Id assigned during creation of the form request | 
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**FormRequestModel**](FormRequestModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

