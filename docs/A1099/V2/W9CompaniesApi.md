# Avalara.SDK.Api.A1099.V2.W9CompaniesApi

All URIs are relative to *https://api.avalara.com/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateW9Company**](W9CompaniesApi.md#createw9company) | **POST** /w9/companies | Creates a new company


<a name="createw9company"></a>
# **CreateW9Company**
> CompanyModel CreateW9Company (CreateW9CompanyRequest requestParameters)

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
    public class CreateW9CompanyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9CompaniesApi(apiClient);
            var requestParameters = new CreateW9CompanyRequest();
            requestParameters.AvalaraVersion = "\"2.0.0\"";  // string | API version (default to "2.0.0")
            requestParameters.XCorrelationId = 0a232c3b-386d-40f9-84c8-4967b32e0d39;  // string | Unique correlation Id in a GUID format
            requestParameters.XAvalaraClient = "xAvalaraClient_example";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/). (optional) 
            requestParameters.CompanyModel = new CompanyModel(); // CompanyModel | The company to create (optional) 

            try
            {
                // Creates a new company
                CompanyModel result = apiInstance.CreateW9Company(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9CompaniesApi.CreateW9Company: " + e.Message );
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
 **CompanyModel** | [**CompanyModel**](CompanyModel.md)| The company to create | [optional] 

### Return type

[**CompanyModel**](CompanyModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created company |  * Location - The location of the created W9 Company <br>  |
| **400** | Bad Request |  * X-Correlation-Id -  <br>  |
| **401** | Authentication failed |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

