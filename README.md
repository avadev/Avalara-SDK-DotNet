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

<a name="documentation-for-EInvoicing-V1-api-endpoints"></a>
### EInvoicing V1 API Documentation

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CodeListsApi* | [**GetCodeList**](docs/EInvoicing/V1/CodeListsApi.md#getcodelist) | **GET** /codelists/{codelistId} | Retrieves a code list by ID for a specific country
*CodeListsApi* | [**GetCodeListList**](docs/EInvoicing/V1/CodeListsApi.md#getcodelistlist) | **GET** /codelists | Returns a list of code lists for a specific country
*DataInputFieldsApi* | [**GetDataInputFields**](docs/EInvoicing/V1/DataInputFieldsApi.md#getdatainputfields) | **GET** /data-input-fields | Returns the optionality of document fields for different country mandates
*DocumentsApi* | [**DownloadDocument**](docs/EInvoicing/V1/DocumentsApi.md#downloaddocument) | **GET** /documents/{documentId}/$download | Returns a copy of the document
*DocumentsApi* | [**FetchDocuments**](docs/EInvoicing/V1/DocumentsApi.md#fetchdocuments) | **POST** /documents/$fetch | Fetch the inbound document from a tax authority
*DocumentsApi* | [**GetDocumentList**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentlist) | **GET** /documents | Returns a summary of documents for a date range
*DocumentsApi* | [**GetDocumentStatus**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentstatus) | **GET** /documents/{documentId}/status | Checks the status of a document
*DocumentsApi* | [**SubmitDocument**](docs/EInvoicing/V1/DocumentsApi.md#submitdocument) | **POST** /documents | Submits a document to Avalara E-Invoicing API
*InteropApi* | [**SubmitInteropDocument**](docs/EInvoicing/V1/InteropApi.md#submitinteropdocument) | **POST** /interop/documents | Submit a document
*MandatesApi* | [**GetMandateDataInputFields**](docs/EInvoicing/V1/MandatesApi.md#getmandatedatainputfields) | **GET** /mandates/{mandateId}/data-input-fields | Returns document field information for a country mandate, a selected document type, and its version
*MandatesApi* | [**GetMandates**](docs/EInvoicing/V1/MandatesApi.md#getmandates) | **GET** /mandates | List country mandates that are supported by the Avalara E-Invoicing platform
*ReportsApi* | [**DownloadReport**](docs/EInvoicing/V1/ReportsApi.md#downloadreport) | **GET** /reports/{reportId}/$download | Returns a pre-signed download URL for a report
*ReportsApi* | [**GetReportById**](docs/EInvoicing/V1/ReportsApi.md#getreportbyid) | **GET** /reports/{reportId}/status | Retrieves a report by its unique ID
*ReportsApi* | [**GetReports**](docs/EInvoicing/V1/ReportsApi.md#getreports) | **GET** /reports | Returns a list of reports
*SubscriptionsApi* | [**CreateWebhookSubscription**](docs/EInvoicing/V1/SubscriptionsApi.md#createwebhooksubscription) | **POST** /webhooks/subscriptions | Create a subscription to events
*SubscriptionsApi* | [**DeleteWebhookSubscription**](docs/EInvoicing/V1/SubscriptionsApi.md#deletewebhooksubscription) | **DELETE** /webhooks/subscriptions/{subscriptionId} | Unsubscribe from events
*SubscriptionsApi* | [**GetWebhookSubscription**](docs/EInvoicing/V1/SubscriptionsApi.md#getwebhooksubscription) | **GET** /webhooks/subscriptions/{subscriptionId} | Get details of a subscription
*SubscriptionsApi* | [**ListWebhookSubscriptions**](docs/EInvoicing/V1/SubscriptionsApi.md#listwebhooksubscriptions) | **GET** /webhooks/subscriptions | List all subscriptions
*TaxIdentifiersApi* | [**TaxIdentifierSchemaByCountry**](docs/EInvoicing/V1/TaxIdentifiersApi.md#taxidentifierschemabycountry) | **GET** /tax-identifiers/schema | Returns the tax identifier request and response schema for a specific country.
*TaxIdentifiersApi* | [**ValidateTaxIdentifier**](docs/EInvoicing/V1/TaxIdentifiersApi.md#validatetaxidentifier) | **POST** /tax-identifiers/validate | Validates a tax identifier.
*TradingPartnersApi* | [**BatchSearchParticipants**](docs/EInvoicing/V1/TradingPartnersApi.md#batchsearchparticipants) | **POST** /trading-partners/batch-searches | Handles batch search requests by uploading a file containing search parameters.
*TradingPartnersApi* | [**CreateTradingPartner**](docs/EInvoicing/V1/TradingPartnersApi.md#createtradingpartner) | **POST** /trading-partners | Creates a new trading partner.
*TradingPartnersApi* | [**CreateTradingPartnersBatch**](docs/EInvoicing/V1/TradingPartnersApi.md#createtradingpartnersbatch) | **POST** /trading-partners/batch | Creates a batch of multiple trading partners.
*TradingPartnersApi* | [**DeleteTradingPartner**](docs/EInvoicing/V1/TradingPartnersApi.md#deletetradingpartner) | **DELETE** /trading-partners/{id} | Deletes a trading partner using ID.
*TradingPartnersApi* | [**DownloadBatchSearchReport**](docs/EInvoicing/V1/TradingPartnersApi.md#downloadbatchsearchreport) | **GET** /trading-partners/batch-searches/{id}/$download-results | Downloads batch search results in a csv file.
*TradingPartnersApi* | [**GetBatchSearchDetail**](docs/EInvoicing/V1/TradingPartnersApi.md#getbatchsearchdetail) | **GET** /trading-partners/batch-searches/{id} | Returns the batch search details using ID.
*TradingPartnersApi* | [**ListBatchSearches**](docs/EInvoicing/V1/TradingPartnersApi.md#listbatchsearches) | **GET** /trading-partners/batch-searches | Lists all batch searches that were previously submitted.
*TradingPartnersApi* | [**SearchParticipants**](docs/EInvoicing/V1/TradingPartnersApi.md#searchparticipants) | **GET** /trading-partners | Returns a list of participants matching the input query.
*TradingPartnersApi* | [**UpdateTradingPartner**](docs/EInvoicing/V1/TradingPartnersApi.md#updatetradingpartner) | **PUT** /trading-partners/{id} | Updates a trading partner using ID.

<a name="documentation-for-models"></a>
## Documentation for Models

<a name="documentation-for-EInvoicing-V1-models"></a>
### EInvoicing V1 Model Documentation

 - [Model.EInvoicing.V1.Address](docs/EInvoicing/V1/Address.md)
 - [Model.EInvoicing.V1.BadDownloadRequest](docs/EInvoicing/V1/BadDownloadRequest.md)
 - [Model.EInvoicing.V1.BadRequest](docs/EInvoicing/V1/BadRequest.md)
 - [Model.EInvoicing.V1.BatchErrorDetail](docs/EInvoicing/V1/BatchErrorDetail.md)
 - [Model.EInvoicing.V1.BatchSearch](docs/EInvoicing/V1/BatchSearch.md)
 - [Model.EInvoicing.V1.BatchSearchListResponse](docs/EInvoicing/V1/BatchSearchListResponse.md)
 - [Model.EInvoicing.V1.BatchSearchParticipants202Response](docs/EInvoicing/V1/BatchSearchParticipants202Response.md)
 - [Model.EInvoicing.V1.CodeListListResponse](docs/EInvoicing/V1/CodeListListResponse.md)
 - [Model.EInvoicing.V1.CodeListResponse](docs/EInvoicing/V1/CodeListResponse.md)
 - [Model.EInvoicing.V1.CodeListSummary](docs/EInvoicing/V1/CodeListSummary.md)
 - [Model.EInvoicing.V1.CodeListValue](docs/EInvoicing/V1/CodeListValue.md)
 - [Model.EInvoicing.V1.CodeListVersion](docs/EInvoicing/V1/CodeListVersion.md)
 - [Model.EInvoicing.V1.ConditionalForField](docs/EInvoicing/V1/ConditionalForField.md)
 - [Model.EInvoicing.V1.Consents](docs/EInvoicing/V1/Consents.md)
 - [Model.EInvoicing.V1.CreateTradingPartner201Response](docs/EInvoicing/V1/CreateTradingPartner201Response.md)
 - [Model.EInvoicing.V1.CreateTradingPartnersBatch200Response](docs/EInvoicing/V1/CreateTradingPartnersBatch200Response.md)
 - [Model.EInvoicing.V1.CreateTradingPartnersBatch200ResponseValueInner](docs/EInvoicing/V1/CreateTradingPartnersBatch200ResponseValueInner.md)
 - [Model.EInvoicing.V1.CreateTradingPartnersBatchRequest](docs/EInvoicing/V1/CreateTradingPartnersBatchRequest.md)
 - [Model.EInvoicing.V1.DataInputField](docs/EInvoicing/V1/DataInputField.md)
 - [Model.EInvoicing.V1.DataInputFieldNotUsedFor](docs/EInvoicing/V1/DataInputFieldNotUsedFor.md)
 - [Model.EInvoicing.V1.DataInputFieldOptionalFor](docs/EInvoicing/V1/DataInputFieldOptionalFor.md)
 - [Model.EInvoicing.V1.DataInputFieldRequiredFor](docs/EInvoicing/V1/DataInputFieldRequiredFor.md)
 - [Model.EInvoicing.V1.DataInputFieldsResponse](docs/EInvoicing/V1/DataInputFieldsResponse.md)
 - [Model.EInvoicing.V1.DocumentFetch](docs/EInvoicing/V1/DocumentFetch.md)
 - [Model.EInvoicing.V1.DocumentListResponse](docs/EInvoicing/V1/DocumentListResponse.md)
 - [Model.EInvoicing.V1.DocumentStatusResponse](docs/EInvoicing/V1/DocumentStatusResponse.md)
 - [Model.EInvoicing.V1.DocumentSubmissionError](docs/EInvoicing/V1/DocumentSubmissionError.md)
 - [Model.EInvoicing.V1.DocumentSubmitResponse](docs/EInvoicing/V1/DocumentSubmitResponse.md)
 - [Model.EInvoicing.V1.DocumentSummary](docs/EInvoicing/V1/DocumentSummary.md)
 - [Model.EInvoicing.V1.ErrorResponse](docs/EInvoicing/V1/ErrorResponse.md)
 - [Model.EInvoicing.V1.EventId](docs/EInvoicing/V1/EventId.md)
 - [Model.EInvoicing.V1.EventMessage](docs/EInvoicing/V1/EventMessage.md)
 - [Model.EInvoicing.V1.EventPayload](docs/EInvoicing/V1/EventPayload.md)
 - [Model.EInvoicing.V1.EventSubscription](docs/EInvoicing/V1/EventSubscription.md)
 - [Model.EInvoicing.V1.Extension](docs/EInvoicing/V1/Extension.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequest](docs/EInvoicing/V1/FetchDocumentsRequest.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequestDataInner](docs/EInvoicing/V1/FetchDocumentsRequestDataInner.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequestMetadata](docs/EInvoicing/V1/FetchDocumentsRequestMetadata.md)
 - [Model.EInvoicing.V1.ForbiddenError](docs/EInvoicing/V1/ForbiddenError.md)
 - [Model.EInvoicing.V1.HmacSignature](docs/EInvoicing/V1/HmacSignature.md)
 - [Model.EInvoicing.V1.HmacSignatureValue](docs/EInvoicing/V1/HmacSignatureValue.md)
 - [Model.EInvoicing.V1.Id](docs/EInvoicing/V1/Id.md)
 - [Model.EInvoicing.V1.Identifier](docs/EInvoicing/V1/Identifier.md)
 - [Model.EInvoicing.V1.InputDataFormats](docs/EInvoicing/V1/InputDataFormats.md)
 - [Model.EInvoicing.V1.InternalServerError](docs/EInvoicing/V1/InternalServerError.md)
 - [Model.EInvoicing.V1.Mandate](docs/EInvoicing/V1/Mandate.md)
 - [Model.EInvoicing.V1.MandateDataInputField](docs/EInvoicing/V1/MandateDataInputField.md)
 - [Model.EInvoicing.V1.MandateDataInputFieldNamespace](docs/EInvoicing/V1/MandateDataInputFieldNamespace.md)
 - [Model.EInvoicing.V1.MandatesResponse](docs/EInvoicing/V1/MandatesResponse.md)
 - [Model.EInvoicing.V1.NotFoundError](docs/EInvoicing/V1/NotFoundError.md)
 - [Model.EInvoicing.V1.NotUsedForField](docs/EInvoicing/V1/NotUsedForField.md)
 - [Model.EInvoicing.V1.OutputDataFormats](docs/EInvoicing/V1/OutputDataFormats.md)
 - [Model.EInvoicing.V1.Pagination](docs/EInvoicing/V1/Pagination.md)
 - [Model.EInvoicing.V1.ReportDownloadResponse](docs/EInvoicing/V1/ReportDownloadResponse.md)
 - [Model.EInvoicing.V1.ReportItem](docs/EInvoicing/V1/ReportItem.md)
 - [Model.EInvoicing.V1.ReportListResponse](docs/EInvoicing/V1/ReportListResponse.md)
 - [Model.EInvoicing.V1.RequiredWhenField](docs/EInvoicing/V1/RequiredWhenField.md)
 - [Model.EInvoicing.V1.SearchParticipants200Response](docs/EInvoicing/V1/SearchParticipants200Response.md)
 - [Model.EInvoicing.V1.Signature](docs/EInvoicing/V1/Signature.md)
 - [Model.EInvoicing.V1.SignatureSignature](docs/EInvoicing/V1/SignatureSignature.md)
 - [Model.EInvoicing.V1.SignatureValue](docs/EInvoicing/V1/SignatureValue.md)
 - [Model.EInvoicing.V1.SignatureValueSignature](docs/EInvoicing/V1/SignatureValueSignature.md)
 - [Model.EInvoicing.V1.StatusEvent](docs/EInvoicing/V1/StatusEvent.md)
 - [Model.EInvoicing.V1.SubmitDocumentMetadata](docs/EInvoicing/V1/SubmitDocumentMetadata.md)
 - [Model.EInvoicing.V1.SubmitInteropDocument202Response](docs/EInvoicing/V1/SubmitInteropDocument202Response.md)
 - [Model.EInvoicing.V1.SubscriptionCommon](docs/EInvoicing/V1/SubscriptionCommon.md)
 - [Model.EInvoicing.V1.SubscriptionDetail](docs/EInvoicing/V1/SubscriptionDetail.md)
 - [Model.EInvoicing.V1.SubscriptionListResponse](docs/EInvoicing/V1/SubscriptionListResponse.md)
 - [Model.EInvoicing.V1.SubscriptionRegistration](docs/EInvoicing/V1/SubscriptionRegistration.md)
 - [Model.EInvoicing.V1.SuccessResponse](docs/EInvoicing/V1/SuccessResponse.md)
 - [Model.EInvoicing.V1.SupportedDocumentStatuses](docs/EInvoicing/V1/SupportedDocumentStatuses.md)
 - [Model.EInvoicing.V1.SupportedDocumentTypes](docs/EInvoicing/V1/SupportedDocumentTypes.md)
 - [Model.EInvoicing.V1.TaxIdentifierRequest](docs/EInvoicing/V1/TaxIdentifierRequest.md)
 - [Model.EInvoicing.V1.TaxIdentifierResponse](docs/EInvoicing/V1/TaxIdentifierResponse.md)
 - [Model.EInvoicing.V1.TaxIdentifierResponseValue](docs/EInvoicing/V1/TaxIdentifierResponseValue.md)
 - [Model.EInvoicing.V1.TaxIdentifierSchemaByCountry200Response](docs/EInvoicing/V1/TaxIdentifierSchemaByCountry200Response.md)
 - [Model.EInvoicing.V1.TradingPartner](docs/EInvoicing/V1/TradingPartner.md)
 - [Model.EInvoicing.V1.UpdateTradingPartner200Response](docs/EInvoicing/V1/UpdateTradingPartner200Response.md)
 - [Model.EInvoicing.V1.ValidationError](docs/EInvoicing/V1/ValidationError.md)
 - [Model.EInvoicing.V1.WebhookInvocation](docs/EInvoicing/V1/WebhookInvocation.md)
 - [Model.EInvoicing.V1.WebhooksErrorInfo](docs/EInvoicing/V1/WebhooksErrorInfo.md)
 - [Model.EInvoicing.V1.WebhooksErrorResponse](docs/EInvoicing/V1/WebhooksErrorResponse.md)
 - [Model.EInvoicing.V1.WorkflowIds](docs/EInvoicing/V1/WorkflowIds.md)
