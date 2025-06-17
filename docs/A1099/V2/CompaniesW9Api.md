# Avalara.SDK.Api.A1099.V2.CompaniesW9Api

All URIs are relative to *https://api-ava1099.eta.sbx.us-east-1.aws.avalara.io/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCompany**](CompaniesW9Api.md#createcompany) | **POST** /w9/companies | Creates a new company
[**DeleteCompany**](CompaniesW9Api.md#deletecompany) | **DELETE** /w9/companies/{id} | Deletes a company
[**GetCompanies**](CompaniesW9Api.md#getcompanies) | **GET** /w9/companies | List companies
[**GetCompany**](CompaniesW9Api.md#getcompany) | **GET** /w9/companies/{id} | Retrieve a company
[**UpdateCompany**](CompaniesW9Api.md#updatecompany) | **PUT** /w9/companies/{id} | Update a company


<a name="createcompany"></a>
# **CreateCompany**
> CompanyResponseModel CreateCompany (CreateCompanyRequestSdk requestParameters)

Creates a new company

Creates a new company

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
    public class CreateCompanyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CompaniesW9Api(apiClient);
            var requestParameters = new CreateCompanyRequestSdk();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 893ccb52-18e2-44e7-997f-a5ff9b64d107;  // string | Unique correlation Id in a GUID format
            requestParameters.CompanyCreateUpdateRequestModel = new CompanyCreateUpdateRequestModel(); // CompanyCreateUpdateRequestModel | The company to create (optional) 

            try
            {
                // Creates a new company
                CompanyResponseModel result = apiInstance.CreateCompany(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesW9Api.CreateCompany: " + e.Message );
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
 **CompanyCreateUpdateRequestModel** | [**CompanyCreateUpdateRequestModel**](CompanyCreateUpdateRequestModel.md)| The company to create | [optional] 

### Return type

[**CompanyResponseModel**](CompanyResponseModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created company |  -  |
| **400** | Bad request (e.g., model validation failed) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deletecompany"></a>
# **DeleteCompany**
> void DeleteCompany (DeleteCompanyRequestSdk requestParameters)

Deletes a company

Deletes a company

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
    public class DeleteCompanyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CompaniesW9Api(apiClient);
            var requestParameters = new DeleteCompanyRequestSdk();
            requestParameters.Id = "id_example";  // string | The company to delete
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 55075aff-e4ba-419d-be13-8fc2b0f5fbf2;  // string | Unique correlation Id in a GUID format

            try
            {
                // Deletes a company
                apiInstance.DeleteCompany(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesW9Api.DeleteCompany: " + e.Message );
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
 **Id** | **string**| The company to delete | 
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
| **204** | Company deleted |  -  |
| **401** | Authentication failed. |  -  |
| **404** | Company was not found or your user does not have to permission to delete it. |  -  |
| **409** | Company can&#39;t be deleted since it still have forms associated with it. |  -  |
| **500** | An error happened while attempting to delete the company. |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getcompanies"></a>
# **GetCompanies**
> PaginatedQueryResultModelCompanyResponse GetCompanies (GetCompaniesRequestSdk requestParameters)

List companies

List existing companies. Filterable/Sortable fields are: \"name\", \"referenceId\", \"group.name\", \"createdAt\" and \"updatedAt\".

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
    public class GetCompaniesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CompaniesW9Api(apiClient);
            var requestParameters = new GetCompaniesRequestSdk();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 9299848a-bed7-4a09-903a-348e2f730ed3;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve.  For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 56;  // int? | If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. (optional) 
            requestParameters.Skip = 56;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional) 
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | If true, return the global count of elements in the collection. (optional) 
            requestParameters.CountOnly = true;  // bool? | If true, return ONLY the global count of elements in the collection.  It only applies when count=true. (optional) 

            try
            {
                // List companies
                PaginatedQueryResultModelCompanyResponse result = apiInstance.GetCompanies(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesW9Api.GetCompanies: " + e.Message );
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
 **Filter** | **string**| A filter statement to identify specific records to retrieve.  For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;. | [optional] 
 **Top** | **int?**| If zero or greater than 1000, return at most 1000 results.  Otherwise, return this number of results.  Used with skip to provide pagination for large datasets. | [optional] 
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] 
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| If true, return the global count of elements in the collection. | [optional] 
 **CountOnly** | **bool?**| If true, return ONLY the global count of elements in the collection.  It only applies when count&#x3D;true. | [optional] 

### Return type

[**PaginatedQueryResultModelCompanyResponse**](PaginatedQueryResultModelCompanyResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of companies |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getcompany"></a>
# **GetCompany**
> CompanyResponse GetCompany (GetCompanyRequestSdk requestParameters)

Retrieve a company

Retrieve an existing company

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
    public class GetCompanyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CompaniesW9Api(apiClient);
            var requestParameters = new GetCompanyRequestSdk();
            requestParameters.Id = "id_example";  // string | Id of the company
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = eb716a59-0f88-4d4b-b3fb-51b174abe535;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieve a company
                CompanyResponse result = apiInstance.GetCompany(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesW9Api.GetCompany: " + e.Message );
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
 **Id** | **string**| Id of the company | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**CompanyResponse**](CompanyResponse.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Single company |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **404** | Company not found |  -  |
| **500** | Server Error |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updatecompany"></a>
# **UpdateCompany**
> CompanyResponseModel UpdateCompany (UpdateCompanyRequestSdk requestParameters)

Update a company

Update a company

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
    public class UpdateCompanyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new CompaniesW9Api(apiClient);
            var requestParameters = new UpdateCompanyRequestSdk();
            requestParameters.Id = "id_example";  // string | The ID of the company to update
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 8ab738df-cd36-48be-8adb-92f01a2c741e;  // string | Unique correlation Id in a GUID format
            requestParameters.CompanyCreateUpdateRequestModel = new CompanyCreateUpdateRequestModel(); // CompanyCreateUpdateRequestModel | The updated company data (optional) 

            try
            {
                // Update a company
                CompanyResponseModel result = apiInstance.UpdateCompany(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesW9Api.UpdateCompany: " + e.Message );
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
 **Id** | **string**| The ID of the company to update | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **CompanyCreateUpdateRequestModel** | [**CompanyCreateUpdateRequestModel**](CompanyCreateUpdateRequestModel.md)| The updated company data | [optional] 

### Return type

[**CompanyResponseModel**](CompanyResponseModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated company |  -  |
| **400** | Bad request (e.g., model validation failed) |  -  |
| **401** | Authentication failed |  -  |
| **404** | Company not found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

