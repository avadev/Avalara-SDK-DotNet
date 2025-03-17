# Avalara.SDK.Api.Track1099.V2.W9CompaniesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**W9CompaniesPost**](W9CompaniesApi.md#w9companiespost) | **POST** /w9/companies | Creates a new company


<a name="w9companiespost"></a>
# **W9CompaniesPost**
> CompanyModel W9CompaniesPost (W9CompaniesPostRequest requestParameters)

Creates a new company

Creates a new company

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
    public class W9CompaniesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9CompaniesApi(apiClient);
            var requestParameters = new W9CompaniesPostRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.CompanyModel = new CompanyModel(); // CompanyModel | The company to create (optional) 

            try
            {
                // Creates a new company
                CompanyModel result = apiInstance.W9CompaniesPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9CompaniesApi.W9CompaniesPost: " + e.Message );
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
 **CompanyModel** | [**CompanyModel**](CompanyModel.md)| The company to create | [optional] 

### Return type

[**CompanyModel**](CompanyModel.md)

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

