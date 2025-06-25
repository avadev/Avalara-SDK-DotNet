# Avalara.SDK.Api.A1099.V2.Class1099IssuersApi

All URIs are relative to *https://api.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIssuer**](Class1099IssuersApi.md#createissuer) | **POST** /1099/issuers | Create a new issuer
[**DeleteIssuer**](Class1099IssuersApi.md#deleteissuer) | **DELETE** /1099/issuers/{issuerId} | Delete an issuer
[**GetIssuer**](Class1099IssuersApi.md#getissuer) | **GET** /1099/issuers/{issuerId} | Get a single issuer
[**ListIssuers**](Class1099IssuersApi.md#listissuers) | **GET** /1099/issuers | List issuers
[**UpdateIssuer**](Class1099IssuersApi.md#updateissuer) | **PUT** /1099/issuers/{issuerId} | Update an issuer


<a name="createissuer"></a>
# **CreateIssuer**
> IssuerModel CreateIssuer (CreateIssuerRequest requestParameters)

Create a new issuer

Create a new issuer

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
    public class CreateIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new CreateIssuerRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 
            requestParameters.IssuerModel = new IssuerModel(); // IssuerModel | The issuer to create (optional) 

            try
            {
                // Create a new issuer
                IssuerModel result = apiInstance.CreateIssuer(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.CreateIssuer: " + e.Message );
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
 **IssuerModel** | [**IssuerModel**](IssuerModel.md)| The issuer to create | [optional] 

### Return type

[**IssuerModel**](IssuerModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created issuer |  * Location - The location of the created W9 Company <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deleteissuer"></a>
# **DeleteIssuer**
> void DeleteIssuer (DeleteIssuerRequest requestParameters)

Delete an issuer

Delete a single issuer by id

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
    public class DeleteIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new DeleteIssuerRequest();
            requestParameters.IssuerId = "issuerId_example";  // string | Id of the issuer to delete
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Delete an issuer
                apiInstance.DeleteIssuer(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.DeleteIssuer: " + e.Message );
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
 **IssuerId** | **string**| Id of the issuer to delete | 
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
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
| **204** | Empty response |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getissuer"></a>
# **GetIssuer**
> IssuerModel GetIssuer (GetIssuerRequest requestParameters)

Get a single issuer

Get a single issuer by id

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
    public class GetIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new GetIssuerRequest();
            requestParameters.IssuerId = "issuerId_example";  // string | 
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // Get a single issuer
                IssuerModel result = apiInstance.GetIssuer(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.GetIssuer: " + e.Message );
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
 **IssuerId** | **string**|  | 
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**IssuerModel**](IssuerModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Single issuer |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listissuers"></a>
# **ListIssuers**
> IssuerModelPaginatedQueryResultModel ListIssuers (ListIssuersRequest requestParameters)

List issuers

List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear

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
    public class ListIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new ListIssuersRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = referenceId eq '100089';  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>.  Filterable: name, nameDba, referenceId, taxYear  (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = "\"false\"";  // bool? | Set true to request count of complete collection in response. (optional)  (default to "false")
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 

            try
            {
                // List issuers
                IssuerModelPaginatedQueryResultModel result = apiInstance.ListIssuers(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.ListIssuers: " + e.Message );
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
 **Filter** | **string**| A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.  Filterable: name, nameDba, referenceId, taxYear  | [optional] 
 **Top** | **int?**| If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] [default to 10]
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] [default to 0]
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| Set true to request count of complete collection in response. | [optional] [default to &quot;false&quot;]
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 

### Return type

[**IssuerModelPaginatedQueryResultModel**](IssuerModelPaginatedQueryResultModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of issuers |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updateissuer"></a>
# **UpdateIssuer**
> void UpdateIssuer (UpdateIssuerRequest requestParameters)

Update an issuer

Update an existing issuer by id

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
    public class UpdateIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new UpdateIssuerRequest();
            requestParameters.IssuerId = "issuerId_example";  // string | Id of the issuer to Update
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 
            requestParameters.IssuerModel = new IssuerModel(); // IssuerModel | The issuer to update (optional) 

            try
            {
                // Update an issuer
                apiInstance.UpdateIssuer(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.UpdateIssuer: " + e.Message );
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
 **IssuerId** | **string**| Id of the issuer to Update | 
 **AvalaraVersion** | **string**| API version | [default to &quot;2.0.0&quot;]
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). | [optional] 
 **IssuerModel** | [**IssuerModel**](IssuerModel.md)| The issuer to update | [optional] 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issuer updated |  -  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |
| **404** | Not Found |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

