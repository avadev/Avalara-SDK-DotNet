# Avalara.SDK.Api.Track1099.V2.Class1099IssuersApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Call1099IssuersGet**](Class1099IssuersApi.md#call1099issuersget) | **GET** /1099/issuers | List issuers
[**Call1099IssuersIssuerIdDelete**](Class1099IssuersApi.md#call1099issuersissueriddelete) | **DELETE** /1099/issuers/{issuerId} | Delete an issuer
[**Call1099IssuersIssuerIdGet**](Class1099IssuersApi.md#call1099issuersissueridget) | **GET** /1099/issuers/{issuerId} | Get a single issuer
[**Call1099IssuersIssuerIdPut**](Class1099IssuersApi.md#call1099issuersissueridput) | **PUT** /1099/issuers/{issuerId} | Update an issuer
[**Call1099IssuersPost**](Class1099IssuersApi.md#call1099issuerspost) | **POST** /1099/issuers | Create a new issuer


<a name="call1099issuersget"></a>
# **Call1099IssuersGet**
> IssuerModelPaginatedQueryResultModel Call1099IssuersGet (Call1099IssuersGetRequest requestParameters)

List issuers

List existing issuers for a given tax year. Filterable fields are name, referenceId and taxYear

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class Call1099IssuersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new Call1099IssuersGetRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.Sort = "sort_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 

            try
            {
                // List issuers
                IssuerModelPaginatedQueryResultModel result = apiInstance.Call1099IssuersGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.Call1099IssuersGet: " + e.Message );
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
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **Filter** | **string**| A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;. | [optional] 
 **Top** | **int?**| If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] [default to 10]
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] [default to 0]
 **Sort** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 

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
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="call1099issuersissueriddelete"></a>
# **Call1099IssuersIssuerIdDelete**
> void Call1099IssuersIssuerIdDelete (Call1099IssuersIssuerIdDeleteRequest requestParameters)

Delete an issuer

Delete a single issuer by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class Call1099IssuersIssuerIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new Call1099IssuersIssuerIdDeleteRequest();
            requestParameters.IssuerId = 789L;  // long | Id of the issuer to delete
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format

            try
            {
                // Delete an issuer
                apiInstance.Call1099IssuersIssuerIdDelete(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.Call1099IssuersIssuerIdDelete: " + e.Message );
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
 **IssuerId** | **long**| Id of the issuer to delete | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

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
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="call1099issuersissueridget"></a>
# **Call1099IssuersIssuerIdGet**
> IssuerModel Call1099IssuersIssuerIdGet (Call1099IssuersIssuerIdGetRequest requestParameters)

Get a single issuer

Get a single issuer by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class Call1099IssuersIssuerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new Call1099IssuersIssuerIdGetRequest();
            requestParameters.IssuerId = 789L;  // long | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format

            try
            {
                // Get a single issuer
                IssuerModel result = apiInstance.Call1099IssuersIssuerIdGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.Call1099IssuersIssuerIdGet: " + e.Message );
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
 **IssuerId** | **long**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

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
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="call1099issuersissueridput"></a>
# **Call1099IssuersIssuerIdPut**
> void Call1099IssuersIssuerIdPut (Call1099IssuersIssuerIdPutRequest requestParameters)

Update an issuer

Update an existing issuer by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class Call1099IssuersIssuerIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new Call1099IssuersIssuerIdPutRequest();
            requestParameters.IssuerId = 789L;  // long | Id of the issuer to Update
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.IssuerModel = new IssuerModel(); // IssuerModel | The issuer to update (optional) 

            try
            {
                // Update an issuer
                apiInstance.Call1099IssuersIssuerIdPut(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.Call1099IssuersIssuerIdPut: " + e.Message );
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
 **IssuerId** | **long**| Id of the issuer to Update | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **IssuerModel** | [**IssuerModel**](IssuerModel.md)| The issuer to update | [optional] 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issuer updated |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Unauthorized |  -  |
| **404** | Resource Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="call1099issuerspost"></a>
# **Call1099IssuersPost**
> IssuerModel Call1099IssuersPost (Call1099IssuersPostRequest requestParameters)

Create a new issuer

Create a new issuer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class Call1099IssuersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new Call1099IssuersPostRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.IssuerModel = new IssuerModel(); // IssuerModel | The issuer to create (optional) 

            try
            {
                // Create a new issuer
                IssuerModel result = apiInstance.Call1099IssuersPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.Call1099IssuersPost: " + e.Message );
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
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **IssuerModel** | [**IssuerModel**](IssuerModel.md)| The issuer to create | [optional] 

### Return type

[**IssuerModel**](IssuerModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created issuer |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

