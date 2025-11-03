# Avalara.SDK.Api.A1099.V2.Issuers1099Api

All URIs are relative to *https://api.sbx.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIssuer**](Issuers1099Api.md#createissuer) | **POST** /1099/issuers | Create an issuer
[**DeleteIssuer**](Issuers1099Api.md#deleteissuer) | **DELETE** /1099/issuers/{id} | Delete an issuer
[**GetIssuer**](Issuers1099Api.md#getissuer) | **GET** /1099/issuers/{id} | Retrieve an issuer
[**GetIssuers**](Issuers1099Api.md#getissuers) | **GET** /1099/issuers | List issuers
[**UpdateIssuer**](Issuers1099Api.md#updateissuer) | **PUT** /1099/issuers/{id} | Update an issuer


<a name="createissuer"></a>
# **CreateIssuer**
> IssuerResponse CreateIssuer (CreateIssuerRequestSdk requestParameters)

Create an issuer

Create an issuer (also known as a Payer).

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
            
            var apiInstance = new Issuers1099Api(apiClient);
            var requestParameters = new CreateIssuerRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 8783a532-9268-4e0b-a0ff-44de4f71b537;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.IssuerRequest = new IssuerRequest(); // IssuerRequest | The issuer to create (optional) 

            try
            {
                // Create an issuer
                IssuerResponse result = apiInstance.CreateIssuer(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Issuers1099Api.CreateIssuer: " + e.Message );
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
 **IssuerRequest** | [**IssuerRequest**](IssuerRequest.md)| The issuer to create | [optional] 

### Return type

[**IssuerResponse**](IssuerResponse.md)

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

<a name="deleteissuer"></a>
# **DeleteIssuer**
> void DeleteIssuer (DeleteIssuerRequestSdk requestParameters)

Delete an issuer

Delete an issuer (also known as a Payer).

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
            
            var apiInstance = new Issuers1099Api(apiClient);
            var requestParameters = new DeleteIssuerRequestSdk();
            requestParameters.Id = "id_example";  // string | Id of the issuer to delete
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 5d63e7f2-9ded-4877-b46c-d4a9deaf226d;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Delete an issuer
                apiInstance.DeleteIssuer(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Issuers1099Api.DeleteIssuer: " + e.Message );
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
 **Id** | **string**| Id of the issuer to delete | 
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
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getissuer"></a>
# **GetIssuer**
> IssuerResponse GetIssuer (GetIssuerRequestSdk requestParameters)

Retrieve an issuer

Retrieve an issuer (also known as a Payer).

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
            
            var apiInstance = new Issuers1099Api(apiClient);
            var requestParameters = new GetIssuerRequestSdk();
            requestParameters.Id = "id_example";  // string | Id of the issuer to retrieve
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = d4b90233-dbcb-43a4-bbf7-d4c5d4e8ea6f;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Retrieve an issuer
                IssuerResponse result = apiInstance.GetIssuer(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Issuers1099Api.GetIssuer: " + e.Message );
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
 **Id** | **string**| Id of the issuer to retrieve | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**IssuerResponse**](IssuerResponse.md)

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

<a name="getissuers"></a>
# **GetIssuers**
> PaginatedQueryResultModelIssuerResponse GetIssuers (GetIssuersRequestSdk requestParameters)

List issuers

List issuers (also known as Payers). Filterable fields are name, referenceId and taxYear.

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
    public class GetIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Issuers1099Api(apiClient);
            var requestParameters = new GetIssuersRequestSdk();
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.Filter = taxYear eq 2025;  // string | A filter statement to identify specific records to retrieve.  For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 56;  // int? | If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. (optional) 
            requestParameters.Skip = 56;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | If true, return the global count of elements in the collection. (optional) 
            requestParameters.CountOnly = true;  // bool? | If true, return ONLY the global count of elements in the collection.  It only applies when count=true. (optional) 
            requestParameters.XCorrelationId = 67f66334-e4f2-4d38-aca7-47de8ea93dc0;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // List issuers
                PaginatedQueryResultModelIssuerResponse result = apiInstance.GetIssuers(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Issuers1099Api.GetIssuers: " + e.Message );
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

[**PaginatedQueryResultModelIssuerResponse**](PaginatedQueryResultModelIssuerResponse.md)

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updateissuer"></a>
# **UpdateIssuer**
> void UpdateIssuer (UpdateIssuerRequestSdk requestParameters)

Update an issuer

Update an issuer (also known as a Payer).

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
            
            var apiInstance = new Issuers1099Api(apiClient);
            var requestParameters = new UpdateIssuerRequestSdk();
            requestParameters.Id = "id_example";  // string | Id of the issuer to update
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 88269912-43b9-460b-b285-28c036924f06;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.IssuerRequest = new IssuerRequest(); // IssuerRequest | The issuer to update (optional) 

            try
            {
                // Update an issuer
                apiInstance.UpdateIssuer(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Issuers1099Api.UpdateIssuer: " + e.Message );
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
 **Id** | **string**| Id of the issuer to update | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 
 **IssuerRequest** | [**IssuerRequest**](IssuerRequest.md)| The issuer to update | [optional] 

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

