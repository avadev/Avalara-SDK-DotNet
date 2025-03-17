# Avalara.SDK - the Unified C# library for next gen Avalara services.

Unified SDK consists of services on top of which the Avalara Compliance Cloud platform is built. These services are foundational and provide functionality such as einvoicing.

<a name="frameworks-supported"></a>

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6

<a name="dependencies"></a>

## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [Polly](https://www.nuget.org/packages/Polly/) - 7.2.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

<a name="getting-started"></a>

## Getting Started

```csharp
using System;

using Avalara.SDK.Client;
using Avalara.SDK.Helpers;
using Avalara.SDK.Api.EInvoicing.V1;
using System.Threading.Tasks;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration configuration = new Configuration
            {
                Environment = AvalaraEnvironment.Sandbox,
                BearerToken = Environment.GetEnvironmentVariable("BEARER_TOKEN"), // Your Bearer token to connect to Avalara
                AppName = "Test",
                AppVersion = "1.0",
                MachineName = "LocalBox"
            };

            ApiClient apiClient = new ApiClient(configuration);

            var mandatesApi = new MandatesApi(apiClient);
            var requestParameters = new GetMandatesRequest();
            requestParameters.XAvalaraClient = "\"Swagger UI; 22.7.0; Custom; 1.0\"";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional)  (default to "Swagger UI; 22.7.0; Custom; 1.0")

            try
            {
                // Retrieve the list of Mandates
                var response = await mandatesApi.GetMandatesAsync(requestParameters);
                Debug.WriteLine(response);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressesApi.ResolveAddressPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

<a name="documentation-for-Track1099-V2-api-endpoints"></a>
### Track1099 V2 API Documentation

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizedAPIRequestsApi* | [**AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet**](docs/Track1099/V2/AuthorizedAPIRequestsApi.md#authorizedapirequestsauthorizedapirequestidexecuteget) | **GET** /authorized-api-requests/{authorizedApiRequestId}/$execute | Execute URL for downloads
*AuthorizedAPIRequestsApi* | [**AuthorizedApiRequestsAuthorizedApiRequestIdGet**](docs/Track1099/V2/AuthorizedAPIRequestsApi.md#authorizedapirequestsauthorizedapirequestidget) | **GET** /authorized-api-requests/{authorizedApiRequestId} | Retrieve URL for downloads
*AuthorizedAPIRequestsApi* | [**AuthorizedApiRequestsPost**](docs/Track1099/V2/AuthorizedAPIRequestsApi.md#authorizedapirequestspost) | **POST** /authorized-api-requests | Create URL for downloads
*Class1099IssuersApi* | [**Call1099IssuersGet**](docs/Track1099/V2/Class1099IssuersApi.md#call1099issuersget) | **GET** /1099/issuers | List issuers
*Class1099IssuersApi* | [**Call1099IssuersIssuerIdDelete**](docs/Track1099/V2/Class1099IssuersApi.md#call1099issuersissueriddelete) | **DELETE** /1099/issuers/{issuerId} | Delete an issuer
*Class1099IssuersApi* | [**Call1099IssuersIssuerIdGet**](docs/Track1099/V2/Class1099IssuersApi.md#call1099issuersissueridget) | **GET** /1099/issuers/{issuerId} | Get a single issuer
*Class1099IssuersApi* | [**Call1099IssuersIssuerIdPut**](docs/Track1099/V2/Class1099IssuersApi.md#call1099issuersissueridput) | **PUT** /1099/issuers/{issuerId} | Update an issuer
*Class1099IssuersApi* | [**Call1099IssuersPost**](docs/Track1099/V2/Class1099IssuersApi.md#call1099issuerspost) | **POST** /1099/issuers | Create a new issuer
*FormRequestsApi* | [**FormRequestsFormRequestIdGet**](docs/Track1099/V2/FormRequestsApi.md#formrequestsformrequestidget) | **GET** /form-requests/{formRequestId} | Get form request
*W4W8W9FormsApi* | [**W9FormsFormIdGet**](docs/Track1099/V2/W4W8W9FormsApi.md#w9formsformidget) | **GET** /w9/forms/{formId} | Retrieve a W9/W8/W4 form
*W4W8W9FormsApi* | [**W9FormsGet**](docs/Track1099/V2/W4W8W9FormsApi.md#w9formsget) | **GET** /w9/forms | List W9/W4/W8 forms.
*W4W8W9FormsApi* | [**W9FormsPost**](docs/Track1099/V2/W4W8W9FormsApi.md#w9formspost) | **POST** /w9/forms | Create a new W9/W8/W4 form
*W9CompaniesApi* | [**W9CompaniesPost**](docs/Track1099/V2/W9CompaniesApi.md#w9companiespost) | **POST** /w9/companies | Creates a new company

<a name="documentation-for-models"></a>
## Documentation for Models

<a name="documentation-for-Track1099-V2-models"></a>
### Track1099 V2 Model Documentation

 - [Model.Track1099.V2.AuthorizedApiRequestModel](docs/Track1099/V2/AuthorizedApiRequestModel.md)
 - [Model.Track1099.V2.AuthorizedApiRequestV2DataModel](docs/Track1099/V2/AuthorizedApiRequestV2DataModel.md)
 - [Model.Track1099.V2.BaseFormDataModel](docs/Track1099/V2/BaseFormDataModel.md)
 - [Model.Track1099.V2.CompanyModel](docs/Track1099/V2/CompanyModel.md)
 - [Model.Track1099.V2.ErrorModel](docs/Track1099/V2/ErrorModel.md)
 - [Model.Track1099.V2.FormRequestModel](docs/Track1099/V2/FormRequestModel.md)
 - [Model.Track1099.V2.HttpValidationProblemDetails](docs/Track1099/V2/HttpValidationProblemDetails.md)
 - [Model.Track1099.V2.IssuerModel](docs/Track1099/V2/IssuerModel.md)
 - [Model.Track1099.V2.IssuerModelPaginatedQueryResultModel](docs/Track1099/V2/IssuerModelPaginatedQueryResultModel.md)
 - [Model.Track1099.V2.Model1099IssuersIssuerIdGet400Response](docs/Track1099/V2/Model1099IssuersIssuerIdGet400Response.md)
 - [Model.Track1099.V2.PaginatedQueryResultModel1](docs/Track1099/V2/PaginatedQueryResultModel1.md)
 - [Model.Track1099.V2.PaginatedW9FormsModel](docs/Track1099/V2/PaginatedW9FormsModel.md)
 - [Model.Track1099.V2.ProblemDetails](docs/Track1099/V2/ProblemDetails.md)
 - [Model.Track1099.V2.W4FormDataModel](docs/Track1099/V2/W4FormDataModel.md)
 - [Model.Track1099.V2.W8BenFormDataModel](docs/Track1099/V2/W8BenFormDataModel.md)
 - [Model.Track1099.V2.W8BeneFormDataModel](docs/Track1099/V2/W8BeneFormDataModel.md)
 - [Model.Track1099.V2.W8ImyFormDataModel](docs/Track1099/V2/W8ImyFormDataModel.md)
 - [Model.Track1099.V2.W9FormDataModel](docs/Track1099/V2/W9FormDataModel.md)
 - [Model.Track1099.V2.W9FormsPostRequest](docs/Track1099/V2/W9FormsPostRequest.md)
