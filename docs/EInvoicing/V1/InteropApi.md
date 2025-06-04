# Avalara.SDK.Api.EInvoicing.V1.InteropApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubmitInteropDocument**](InteropApi.md#submitinteropdocument) | **POST** /interop/documents | Submit a document


<a name="submitinteropdocument"></a>
# **SubmitInteropDocument**
> SubmitInteropDocument202Response SubmitInteropDocument (SubmitInteropDocumentRequest requestParameters)

Submit a document

This API used by the interoperability partners to submit a document to  their trading partners in Avalara on behalf of their customers. 

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
            var requestParameters = new SubmitInteropDocumentRequest();
            requestParameters.DocumentType = "ubl-invoice-2.1";  // string | Type of the document being uploaded. Partners will be configured in Avalara system to send only certain types of documents.
            requestParameters.InterchangeType = "FI-B2B";  // string | Type of interchange (codes in Avalara system that uniquely identifies a type of interchange). Partners will be configured in Avalara system to send documents belonging to certain types of interchanges.
            requestParameters.AvalaraVersion = 1.2;  // string | The HTTP Header meant to specify the version of the API intended to be used
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\" (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 
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
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot; | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 
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
| **202** | Document Accepted. This doesn&#39;t mean it is processed. This is just a transport ack. |  * X-Correlation-ID -  <br>  |
| **400** | Bad/Invalid Request. |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

