# Avalara.SDK.Api.A1099.V2.Issuers1099Api

All URIs are relative to *https://api.sbx.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIssuer**](Issuers1099Api.md#createissuer) | **POST** /1099/issuers | Create an issuer
[**DeleteIssuer**](Issuers1099Api.md#deleteissuer) | **DELETE** /1099/issuers/{id} | Delete an issuer
[**GetIssuer**](Issuers1099Api.md#getissuer) | **GET** /1099/issuers/{id} | Retrieve an issuer
[**GetIssuers**](Issuers1099Api.md#getissuers) | **GET** /1099/issuers | List issuers
[**ResubmitRejectedForms**](Issuers1099Api.md#resubmitrejectedforms) | **POST** /1099/issuers/{issuerId}/$resubmit-rejected-forms | Request a replacement submission for an issuer&#39;s rejected forms
[**UpdateIssuer**](Issuers1099Api.md#updateissuer) | **PUT** /1099/issuers/{id} | Update an issuer


<a name="createissuer"></a>
# **CreateIssuer**
> IssuerWriteResponse CreateIssuer (CreateIssuerRequestSdk requestParameters)

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
            requestParameters.XCorrelationId = 4b4a71df-d704-4441-938e-77ebd499ffc0;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.IssuerRequest = new IssuerRequest(); // IssuerRequest | The issuer to create (optional) 

            try
            {
                // Create an issuer
                IssuerWriteResponse result = apiInstance.CreateIssuer(requestParameters);
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

[**IssuerWriteResponse**](IssuerWriteResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **503** | Server Error |  -  |
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
            requestParameters.XCorrelationId = a41f3692-5fd3-467e-bd69-b6519ff72bf1;  // string | Unique correlation Id in a GUID format (optional) 
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
| **503** | Server Error |  -  |
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
            requestParameters.XCorrelationId = d0af6ce1-a2e1-4962-8a8e-e2d10defb317;  // string | Unique correlation Id in a GUID format (optional) 
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
| **503** | Server Error |  -  |
| **200** | Single issuer |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getissuers"></a>
# **GetIssuers**
> PaginatedQueryResultModelIssuerResponse GetIssuers (GetIssuersRequestSdk requestParameters)

List issuers

List issuers (also known as Payers).  Filterable fields are businessName, businessName2, referenceId, taxYear, firstName, lastName, createdAt and updatedAt.                \"createdAt\" and \"updatedAt\" accept ISO 8601 values and are stored in UTC. Values without an offset are treated as UTC,  and a date-only value means midnight (00:00:00) of that day.                Examples:  <ul><li>Issuers updated on a given day (2026-09-03): updatedAt ge '2026-09-03' and updatedAt lt '2026-09-04'</li></ul><ul><li>Issuers updated since a given moment (UTC): updatedAt ge '2026-09-03T15:49:35Z'</li></ul><ul><li>Issuers updated within an interval, with a time zone offset:    updatedAt ge '2026-09-03T08:00:00-05:00' and updatedAt le '2026-09-03T18:00:00-05:00'</li></ul>

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
            requestParameters.Filter = taxYear eq 2026;  // string | A filter statement to identify specific records to retrieve.  For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 56;  // int? | If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. (optional) 
            requestParameters.Skip = 56;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | If true, return the global count of elements in the collection. (optional) 
            requestParameters.CountOnly = true;  // bool? | If true, return ONLY the global count of elements in the collection.  It only applies when count=true. (optional) 
            requestParameters.XCorrelationId = b0506838-51c7-442d-b969-853bea835e21;  // string | Unique correlation Id in a GUID format (optional) 
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
| **503** | Server Error |  -  |
| **200** | List of issuers |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="resubmitrejectedforms"></a>
# **ResubmitRejectedForms**
> ResubmitRejectedFormsResponse ResubmitRejectedForms (ResubmitRejectedFormsRequestSdk requestParameters)

Request a replacement submission for an issuer's rejected forms

Mirrors the UI's \"Resubmit Rejected Forms\" action: schedules a replacement submission for every one  of the issuer's forms currently in Rejected or RejectedWithErrors status, in a single action. There  is no per-form or per-submission selection. This call only schedules the resubmission — actual  transmission to the IRS remains asynchronous and batch-driven.

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
    public class ResubmitRejectedFormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Issuers1099Api(apiClient);
            var requestParameters = new ResubmitRejectedFormsRequestSdk();
            requestParameters.IssuerId = 789L;  // long | Id of the issuer whose rejected forms should be resubmitted
            requestParameters.AvalaraVersion = 2.0.0;  // string | API version
            requestParameters.XCorrelationId = 35fd001d-2c7f-467f-bd35-3120d85a8317;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 

            try
            {
                // Request a replacement submission for an issuer's rejected forms
                ResubmitRejectedFormsResponse result = apiInstance.ResubmitRejectedForms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Issuers1099Api.ResubmitRejectedForms: " + e.Message );
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
 **IssuerId** | **long**| Id of the issuer whose rejected forms should be resubmitted | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | [optional] 
 **XAvalaraClient** | **string**| Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . | [optional] 

### Return type

[**ResubmitRejectedFormsResponse**](ResubmitRejectedFormsResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **503** | Server Error |  -  |
| **200** | Rejected forms scheduled for replacement submission |  -  |
| **401** | Authentication failed |  -  |
| **403** | Caller does not have access to this issuer |  -  |
| **404** | Issuer has no forms in Rejected or RejectedWithErrors status |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updateissuer"></a>
# **UpdateIssuer**
> IssuerWriteResponse UpdateIssuer (UpdateIssuerRequestSdk requestParameters)

Update an issuer

Update an issuer (also known as a Payer). When the payload violates field-level business rules, the issuer is still persisted and the response body includes a `validationErrors[]` array describing each violation.

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
            requestParameters.XCorrelationId = 37538a0f-462a-4a58-83c1-b0c8c959f75f;  // string | Unique correlation Id in a GUID format (optional) 
            requestParameters.XAvalaraClient = Swagger UI; 22.1.0;  // string | Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional) 
            requestParameters.IssuerRequest = new IssuerRequest(); // IssuerRequest | The issuer to update (optional) 

            try
            {
                // Update an issuer
                IssuerWriteResponse result = apiInstance.UpdateIssuer(requestParameters);
                Debug.WriteLine(result);
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

[**IssuerWriteResponse**](IssuerWriteResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **503** | Server Error |  -  |
| **200** | Issuer updated. Body may contain &#x60;validationErrors[]&#x60; when business rules failed. |  -  |
| **400** | Invalid id format, malformed JSON, or identity change rejected for an issuer with scheduled Forms 1099 (TIN, TIN type, or name are immutable in that case). |  -  |
| **401** | Unauthorized |  -  |
| **403** | Caller does not have access to this issuer. |  -  |
| **404** | Issuer not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

