# Avalara.SDK.Api.EInvoicing.V1.InteropApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitInteropDocument**](InteropApi.md#submitinteropdocument) | **POST** /interop/documents | Submit a document


<a name="submitinteropdocument"></a>
# **SubmitInteropDocument**
> SubmitInteropDocument202Response SubmitInteropDocument (SubmitInteropDocumentRequestSdk requestParameters)

Submit a document

Upload documents on behalf of interoperability partners and submit them to trading partners through the Avalara platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class SubmitInteropDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new InteropApi(apiClient);
            var requestParameters = new SubmitInteropDocumentRequestSdk();
            requestParameters.DocumentType = "ubl-invoice-2.1";  // string | Type of the document being uploaded. Partners will be configured in Avalara system to send only certain types of documents.
            requestParameters.InterchangeType = "FI-B2B-TIEKE";  // string | Type of interchange (codes in Avalara system that uniquely identifies a type of interchange). Partners will be configured in Avalara system to send documents belonging to certain types of interchanges.
            requestParameters.AvalaraVersion = 1.6;  // string | Header that specifies the API version to use (for example \"1.6\").
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | Optional header for a client identifier string used for diagnostics (for example \"Fingerprint\"). (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | Optional correlation identifier provided by the caller to trace the call (for example \"f3f0d19a-01a1-4748-8a58-f000d0424f43\"). (optional) 
            requestParameters.FileName = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | The file to be uploaded (e.g., UBL XML, CII XML). (optional) 

            try
            {
                // Submit a document
                SubmitInteropDocument202Response result = apiInstance.SubmitInteropDocument(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InteropApi.SubmitInteropDocument: " + e.Message );
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
 **DocumentType** | **string**| Type of the document being uploaded. Partners will be configured in Avalara system to send only certain types of documents. | 
 **InterchangeType** | **string**| Type of interchange (codes in Avalara system that uniquely identifies a type of interchange). Partners will be configured in Avalara system to send documents belonging to certain types of interchanges. | 
 **AvalaraVersion** | **string**| Header that specifies the API version to use (for example \&quot;1.6\&quot;). | 
 **XAvalaraClient** | **string**| Optional header for a client identifier string used for diagnostics (for example \&quot;Fingerprint\&quot;). | [optional] 
 **XCorrelationID** | **string**| Optional correlation identifier provided by the caller to trace the call (for example \&quot;f3f0d19a-01a1-4748-8a58-f000d0424f43\&quot;). | [optional] 
 **FileName** | **FileParameter****FileParameter**| The file to be uploaded (e.g., UBL XML, CII XML). | [optional] 

### Return type

[**SubmitInteropDocument202Response**](SubmitInteropDocument202Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Document accepted for processing. Returns the interchange ID and acceptance message. This is a transport acknowledgment; processing occurs asynchronously. |  * X-Correlation-ID -  <br>  |
| **400** | Bad request. The request is invalid or contains missing or incorrect parameters. |  * X-Correlation-ID -  <br>  |
| **401** | Unauthorized. |  * X-Correlation-ID -  <br>  |
| **403** | Forbidden. |  * X-Correlation-ID -  <br>  |
| **500** | Internal server error. |  * X-Correlation-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

