# Avalara.SDK.Api.A1099.V2.Class1099FormsApi

All URIs are relative to *https://api.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkUpsert1099Forms**](Class1099FormsApi.md#bulkupsert1099forms) | **POST** /1099/forms/$bulk | Create/Update 1099 forms
[**Call1099FormsPost**](Class1099FormsApi.md#call1099formspost) | **POST** /1099/forms | Create a new 1099 form
[**Delete1099Form**](Class1099FormsApi.md#delete1099form) | **DELETE** /1099/forms/{formId} | Delete a 1099 form
[**Download1099FormPDF**](Class1099FormsApi.md#download1099formpdf) | **POST** /1099/forms/$initiate-download | Submit a download job to retrieve PDF forms
[**Get1099Form**](Class1099FormsApi.md#get1099form) | **GET** /1099/forms/{formId} | Get a single 1099 form
[**List1099Forms**](Class1099FormsApi.md#list1099forms) | **GET** /1099/forms | List 1099 forms
[**Update1099Form**](Class1099FormsApi.md#update1099form) | **PUT** /1099/forms/{formId} | Update an existing form.


<a name="bulkupsert1099forms"></a>
# **BulkUpsert1099Forms**
> JobModel BulkUpsert1099Forms (BulkUpsert1099FormsRequest requestParameters)

Create/Update 1099 forms

This endpoint allows users to bulk create/update (aka upsert) 1099 forms. The maximum request size allowed is **100MB**. 

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
    public class BulkUpsert1099FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new BulkUpsert1099FormsRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.BulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(); // BulkUpsert1099FormsRequest | A request payload containing the details of the 1099 form to upsert.
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Create/Update 1099 forms
                JobModel result = apiInstance.BulkUpsert1099Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.BulkUpsert1099Forms: " + e.Message );
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
 **BulkUpsert1099FormsRequest** | [**BulkUpsert1099FormsRequest**](BulkUpsert1099FormsRequest.md)| A request payload containing the details of the 1099 form to upsert. | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**JobModel**](JobModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully upserted the 1099 form. |  * X-Correlation-Id -  <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **409** | Conflict |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="call1099formspost"></a>
# **Call1099FormsPost**
> Form1099OneOf Call1099FormsPost (Call1099FormsPostRequest requestParameters)

Create a new 1099 form

This endpoint allows users to create a new 1099 form. 

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
    public class Call1099FormsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Call1099FormsPostRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.Form1099OneOf = new Form1099OneOf(); // Form1099OneOf | A request payload containing the details of the 1099 form to create.
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Create a new 1099 form
                Form1099OneOf result = apiInstance.Call1099FormsPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Call1099FormsPost: " + e.Message );
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
 **Form1099OneOf** | [**Form1099OneOf**](Form1099OneOf.md)| A request payload containing the details of the 1099 form to create. | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**Form1099OneOf**](Form1099OneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created the 1099 form. |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **409** | Conflict |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="delete1099form"></a>
# **Delete1099Form**
> void Delete1099Form (Delete1099FormRequest requestParameters)

Delete a 1099 form

This endpoint allows users to delete a single 1099 form by its unique identifier. If the form is successfully deleted, the response will return a `204 No Content` status. 

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
    public class Delete1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Delete1099FormRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.FormId = "formId_example";  // string | The unique identifier of the form to delete.
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Delete a 1099 form
                apiInstance.Delete1099Form(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Delete1099Form: " + e.Message );
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
 **FormId** | **string**| The unique identifier of the form to delete. | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

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
| **204** | No Content. The form was successfully deleted. |  * X-Correlation-Id -  <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="download1099formpdf"></a>
# **Download1099FormPDF**
> InititateDownloadOutputModel Download1099FormPDF (Download1099FormPDFRequest requestParameters)

Submit a download job to retrieve PDF forms

This endpoint allows users to initiate a download job for 1099 forms. The request body specifies the parameters for filtering the forms to be included in the download. Once the job is created, the response returns a job ID, which can be used to check the status of the download. The download job processes the requested forms asynchronously. Users can retrieve the job status and obtain the download URL using the `GET /jobs/{jobId}` endpoint. 

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
    public class Download1099FormPDFExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Download1099FormPDFRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.InitiateDownloadInputModel = new InitiateDownloadInputModel(); // InitiateDownloadInputModel | A request payload containing parameters to filter forms.
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Submit a download job to retrieve PDF forms
                InititateDownloadOutputModel result = apiInstance.Download1099FormPDF(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Download1099FormPDF: " + e.Message );
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
 **InitiateDownloadInputModel** | [**InitiateDownloadInputModel**](InitiateDownloadInputModel.md)| A request payload containing parameters to filter forms. | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**InititateDownloadOutputModel**](InititateDownloadOutputModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created the download job. |  * X-Correlation-Id -  <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="get1099form"></a>
# **Get1099Form**
> Form1099OneOf Get1099Form (Get1099FormRequest requestParameters)

Get a single 1099 form

This endpoint allows users to retrieve the details of a single 1099 form by its unique identifier. The response will include the type of form requested. 

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
    public class Get1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Get1099FormRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.FormId = form_1234567890;  // string | The unique identifier of the form to retrieve.
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Get a single 1099 form
                Form1099OneOf result = apiInstance.Get1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Get1099Form: " + e.Message );
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
 **FormId** | **string**| The unique identifier of the form to retrieve. | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**Form1099OneOf**](Form1099OneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-Correlation-Id -  <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="list1099forms"></a>
# **List1099Forms**
> List1099Forms200Response List1099Forms (List1099FormsRequest requestParameters)

List 1099 forms

This endpoint allows users to retrieve a list of 1099 forms. Users can apply filters, pagination, and sorting to narrow down the results based on their needs. The response will include details for each form, such as recipient information, filing statuses, and payment amounts. 

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
    public class List1099FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new List1099FormsRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 
            requestParameters.Filter = issuerReferenceId eq 'C-935801';  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>.  Filterable: issuerReferenceId, taxYear, federalEfile, federalEfileStatus, postalMail, postalMailStatus, stateEfile, stateEfileStatus, tinMatch, tinMatchStatus, addressVerification, addressVerificationStatus, referenceId, city, state, zip  (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = "\"false\"";  // bool? | Set true to request count of complete collection in response. (optional)  (default to "false")

            try
            {
                // List 1099 forms
                List1099Forms200Response result = apiInstance.List1099Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.List1099Forms: " + e.Message );
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
 **Filter** | **string**| A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.  Filterable: issuerReferenceId, taxYear, federalEfile, federalEfileStatus, postalMail, postalMailStatus, stateEfile, stateEfileStatus, tinMatch, tinMatchStatus, addressVerification, addressVerificationStatus, referenceId, city, state, zip  | [optional] 
 **Top** | **int?**| If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] [default to 10]
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] [default to 0]
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| Set true to request count of complete collection in response. | [optional] [default to &quot;false&quot;]

### Return type

[**List1099Forms200Response**](List1099Forms200Response.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * X-Correlation-Id -  <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **409** | Conflict |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="update1099form"></a>
# **Update1099Form**
> Form1099OneOf Update1099Form (Update1099FormRequest requestParameters)

Update an existing form.

This endpoint allows users to update the details of a single 1099 form by its unique identifier. The payload should include the updated details for the form. 

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
    public class Update1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Update1099FormRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.Form1099OneOf = new Form1099OneOf(); // Form1099OneOf | A request payload containing the updated details of the 1099 form.
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Update an existing form.
                Form1099OneOf result = apiInstance.Update1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Update1099Form: " + e.Message );
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
 **Form1099OneOf** | [**Form1099OneOf**](Form1099OneOf.md)| A request payload containing the updated details of the 1099 form. | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**Form1099OneOf**](Form1099OneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. The 1099 form was successfully updated. |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

