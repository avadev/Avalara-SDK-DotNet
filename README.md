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
*DataInputFieldsApi* | [**GetDataInputFields**](docs/EInvoicing/V1/DataInputFieldsApi.md#getdatainputfields) | **GET** /data-input-fields | Returns the optionality of document fields for different country mandates
*DocumentsApi* | [**DownloadDocument**](docs/EInvoicing/V1/DocumentsApi.md#downloaddocument) | **GET** /documents/{documentId}/$download | Returns a copy of the document
*DocumentsApi* | [**FetchDocuments**](docs/EInvoicing/V1/DocumentsApi.md#fetchdocuments) | **POST** /documents/$fetch | Fetch the inbound document from a tax authority
*DocumentsApi* | [**GetDocumentList**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentlist) | **GET** /documents | Returns a summary of documents for a date range
*DocumentsApi* | [**GetDocumentStatus**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentstatus) | **GET** /documents/{documentId}/status | Checks the status of a document
*DocumentsApi* | [**SubmitDocument**](docs/EInvoicing/V1/DocumentsApi.md#submitdocument) | **POST** /documents | Submits a document to Avalara E-Invoicing API
*InteropApi* | [**SubmitInteropDocument**](docs/EInvoicing/V1/InteropApi.md#submitinteropdocument) | **POST** /interop/documents | Submit a document
*MandatesApi* | [**GetMandateDataInputFields**](docs/EInvoicing/V1/MandatesApi.md#getmandatedatainputfields) | **GET** /mandates/{mandateId}/data-input-fields | Returns document field information for a country mandate, a selected document type, and its version
*MandatesApi* | [**GetMandates**](docs/EInvoicing/V1/MandatesApi.md#getmandates) | **GET** /mandates | List country mandates that are supported by the Avalara E-Invoicing platform
*SubscriptionsApi* | [**CreateWebhookSubscription**](docs/EInvoicing/V1/SubscriptionsApi.md#createwebhooksubscription) | **POST** /webhooks/subscriptions | Create a subscription to events
*SubscriptionsApi* | [**DeleteWebhookSubscription**](docs/EInvoicing/V1/SubscriptionsApi.md#deletewebhooksubscription) | **DELETE** /webhooks/subscriptions/{subscription-id} | Unsubscribe from events
*SubscriptionsApi* | [**GetWebhookSubscription**](docs/EInvoicing/V1/SubscriptionsApi.md#getwebhooksubscription) | **GET** /webhooks/subscriptions/{subscription-id} | Get details of a subscription
*SubscriptionsApi* | [**ListWebhookSubscriptions**](docs/EInvoicing/V1/SubscriptionsApi.md#listwebhooksubscriptions) | **GET** /webhooks/subscriptions | List all subscriptions
*TradingPartnersApi* | [**BatchSearchParticipants**](docs/EInvoicing/V1/TradingPartnersApi.md#batchsearchparticipants) | **POST** /trading-partners/batch-searches | Creates a batch search and performs a batch search in the directory for participants in the background.
*TradingPartnersApi* | [**DownloadBatchSearchReport**](docs/EInvoicing/V1/TradingPartnersApi.md#downloadbatchsearchreport) | **GET** /trading-partners/batch-searches/{id}/$download-results | Download batch search results in a csv file.
*TradingPartnersApi* | [**GetBatchSearchDetail**](docs/EInvoicing/V1/TradingPartnersApi.md#getbatchsearchdetail) | **GET** /trading-partners/batch-searches/{id} | Get the batch search details for a given id.
*TradingPartnersApi* | [**ListBatchSearches**](docs/EInvoicing/V1/TradingPartnersApi.md#listbatchsearches) | **GET** /trading-partners/batch-searches | List all batch searches that were previously submitted.
*TradingPartnersApi* | [**SearchParticipants**](docs/EInvoicing/V1/TradingPartnersApi.md#searchparticipants) | **GET** /trading-partners | Returns a list of participants matching the input query.

<a name="documentation-for-A1099-V2-api-endpoints"></a>
### A1099 V2 API Documentation

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CompaniesW9Api* | [**CreateCompany**](docs/A1099/V2/CompaniesW9Api.md#createcompany) | **POST** /w9/companies | Creates a new company
*CompaniesW9Api* | [**DeleteCompany**](docs/A1099/V2/CompaniesW9Api.md#deletecompany) | **DELETE** /w9/companies/{id} | Deletes a company
*CompaniesW9Api* | [**GetCompanies**](docs/A1099/V2/CompaniesW9Api.md#getcompanies) | **GET** /w9/companies | List companies
*CompaniesW9Api* | [**GetCompany**](docs/A1099/V2/CompaniesW9Api.md#getcompany) | **GET** /w9/companies/{id} | Retrieve a company
*CompaniesW9Api* | [**UpdateCompany**](docs/A1099/V2/CompaniesW9Api.md#updatecompany) | **PUT** /w9/companies/{id} | Update a company
*Forms1099Api* | [**BulkUpsert1099Forms**](docs/A1099/V2/Forms1099Api.md#bulkupsert1099forms) | **POST** /1099/forms/$bulk-upsert | Creates or updates multiple 1099 forms.
*Forms1099Api* | [**Create1099Form**](docs/A1099/V2/Forms1099Api.md#create1099form) | **POST** /1099/forms | Creates a 1099 form.
*Forms1099Api* | [**Delete1099Form**](docs/A1099/V2/Forms1099Api.md#delete1099form) | **DELETE** /1099/forms/{id} | Deletes a 1099 form.
*Forms1099Api* | [**Get1099Form**](docs/A1099/V2/Forms1099Api.md#get1099form) | **GET** /1099/forms/{id} | Retrieves a 1099 form.
*Forms1099Api* | [**Get1099FormPdf**](docs/A1099/V2/Forms1099Api.md#get1099formpdf) | **GET** /1099/forms/{id}/pdf | Retrieves the PDF file for a single 1099 by form id.
*Forms1099Api* | [**List1099Forms**](docs/A1099/V2/Forms1099Api.md#list1099forms) | **GET** /1099/forms | Retrieves a list of 1099 forms based on query parameters.
*Forms1099Api* | [**Update1099Form**](docs/A1099/V2/Forms1099Api.md#update1099form) | **PUT** /1099/forms/{id} | Updates a 1099 form.
*FormsW9Api* | [**CreateW9Form**](docs/A1099/V2/FormsW9Api.md#createw9form) | **POST** /w9/forms | Create a W9/W4/W8 form
*FormsW9Api* | [**DeleteW9Form**](docs/A1099/V2/FormsW9Api.md#deletew9form) | **DELETE** /w9/forms/{id} | Delete a form
*FormsW9Api* | [**GetW9Form**](docs/A1099/V2/FormsW9Api.md#getw9form) | **GET** /w9/forms/{id} | Retrieve a W9/W4/W8 form
*FormsW9Api* | [**ListW9Forms**](docs/A1099/V2/FormsW9Api.md#listw9forms) | **GET** /w9/forms | List W9/W4/W8 forms.
*FormsW9Api* | [**SendW9FormEmail**](docs/A1099/V2/FormsW9Api.md#sendw9formemail) | **POST** /w9/forms/{id}/$send-email | Sends a W9 email request to a vendor/payee
*FormsW9Api* | [**UpdateW9Form**](docs/A1099/V2/FormsW9Api.md#updatew9form) | **PUT** /w9/forms/{id} | Update a W9/W4/W8 form
*FormsW9Api* | [**UploadW9Files**](docs/A1099/V2/FormsW9Api.md#uploadw9files) | **PUT** /w9/forms/{id}/attachment | Upload files for a W9/W4/W8 form
*Issuers1099Api* | [**CreateIssuer**](docs/A1099/V2/Issuers1099Api.md#createissuer) | **POST** /1099/issuers | Create an issuer
*Issuers1099Api* | [**DeleteIssuer**](docs/A1099/V2/Issuers1099Api.md#deleteissuer) | **DELETE** /1099/issuers/{id} | Delete an issuer
*Issuers1099Api* | [**GetIssuer**](docs/A1099/V2/Issuers1099Api.md#getissuer) | **GET** /1099/issuers/{id} | Get an issuer
*Issuers1099Api* | [**GetIssuers**](docs/A1099/V2/Issuers1099Api.md#getissuers) | **GET** /1099/issuers | List issuers
*Issuers1099Api* | [**UpdateIssuer**](docs/A1099/V2/Issuers1099Api.md#updateissuer) | **PUT** /1099/issuers/{id} | Update an issuer
*Jobs1099Api* | [**GetJob**](docs/A1099/V2/Jobs1099Api.md#getjob) | **GET** /1099/jobs/{id} | Retrieves information about the job

<a name="documentation-for-models"></a>
## Documentation for Models

<a name="documentation-for-EInvoicing-V1-models"></a>
### EInvoicing V1 Model Documentation

 - [Model.EInvoicing.V1.BadDownloadRequest](docs/EInvoicing/V1/BadDownloadRequest.md)
 - [Model.EInvoicing.V1.BadRequest](docs/EInvoicing/V1/BadRequest.md)
 - [Model.EInvoicing.V1.BatchSearch](docs/EInvoicing/V1/BatchSearch.md)
 - [Model.EInvoicing.V1.BatchSearchListResponse](docs/EInvoicing/V1/BatchSearchListResponse.md)
 - [Model.EInvoicing.V1.BatchSearchParticipants202Response](docs/EInvoicing/V1/BatchSearchParticipants202Response.md)
 - [Model.EInvoicing.V1.ConditionalForField](docs/EInvoicing/V1/ConditionalForField.md)
 - [Model.EInvoicing.V1.DataInputField](docs/EInvoicing/V1/DataInputField.md)
 - [Model.EInvoicing.V1.DataInputFieldNotUsedFor](docs/EInvoicing/V1/DataInputFieldNotUsedFor.md)
 - [Model.EInvoicing.V1.DataInputFieldOptionalFor](docs/EInvoicing/V1/DataInputFieldOptionalFor.md)
 - [Model.EInvoicing.V1.DataInputFieldRequiredFor](docs/EInvoicing/V1/DataInputFieldRequiredFor.md)
 - [Model.EInvoicing.V1.DataInputFieldsResponse](docs/EInvoicing/V1/DataInputFieldsResponse.md)
 - [Model.EInvoicing.V1.DirectorySearchResponse](docs/EInvoicing/V1/DirectorySearchResponse.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInner](docs/EInvoicing/V1/DirectorySearchResponseValueInner.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInnerAddressesInner](docs/EInvoicing/V1/DirectorySearchResponseValueInnerAddressesInner.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInnerIdentifiersInner](docs/EInvoicing/V1/DirectorySearchResponseValueInnerIdentifiersInner.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInnerSupportedDocumentTypesInner](docs/EInvoicing/V1/DirectorySearchResponseValueInnerSupportedDocumentTypesInner.md)
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
 - [Model.EInvoicing.V1.FetchDocumentsRequest](docs/EInvoicing/V1/FetchDocumentsRequest.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequestDataInner](docs/EInvoicing/V1/FetchDocumentsRequestDataInner.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequestMetadata](docs/EInvoicing/V1/FetchDocumentsRequestMetadata.md)
 - [Model.EInvoicing.V1.ForbiddenError](docs/EInvoicing/V1/ForbiddenError.md)
 - [Model.EInvoicing.V1.HmacSignature](docs/EInvoicing/V1/HmacSignature.md)
 - [Model.EInvoicing.V1.HmacSignatureValue](docs/EInvoicing/V1/HmacSignatureValue.md)
 - [Model.EInvoicing.V1.Id](docs/EInvoicing/V1/Id.md)
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
 - [Model.EInvoicing.V1.RequiredWhenField](docs/EInvoicing/V1/RequiredWhenField.md)
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
 - [Model.EInvoicing.V1.WebhookInvocation](docs/EInvoicing/V1/WebhookInvocation.md)
 - [Model.EInvoicing.V1.WebhooksErrorInfo](docs/EInvoicing/V1/WebhooksErrorInfo.md)
 - [Model.EInvoicing.V1.WebhooksErrorResponse](docs/EInvoicing/V1/WebhooksErrorResponse.md)
 - [Model.EInvoicing.V1.WorkflowIds](docs/EInvoicing/V1/WorkflowIds.md)


<a name="documentation-for-A1099-V2-models"></a>
### A1099 V2 Model Documentation

 - [Model.A1099.V2.Attribute](docs/A1099/V2/Attribute.md)
 - [Model.A1099.V2.AuthorizedApiRequestModel](docs/A1099/V2/AuthorizedApiRequestModel.md)
 - [Model.A1099.V2.AuthorizedApiRequestV2DataModel](docs/A1099/V2/AuthorizedApiRequestV2DataModel.md)
 - [Model.A1099.V2.BaseCompanyModel](docs/A1099/V2/BaseCompanyModel.md)
 - [Model.A1099.V2.BaseFormListRequest](docs/A1099/V2/BaseFormListRequest.md)
 - [Model.A1099.V2.BulkUpsert1099FormsRequest](docs/A1099/V2/BulkUpsert1099FormsRequest.md)
 - [Model.A1099.V2.CompanyCreateUpdateRequestModel](docs/A1099/V2/CompanyCreateUpdateRequestModel.md)
 - [Model.A1099.V2.CompanyModel](docs/A1099/V2/CompanyModel.md)
 - [Model.A1099.V2.CompanyResponse](docs/A1099/V2/CompanyResponse.md)
 - [Model.A1099.V2.CompanyResponseModel](docs/A1099/V2/CompanyResponseModel.md)
 - [Model.A1099.V2.CoveredIndividualReference](docs/A1099/V2/CoveredIndividualReference.md)
 - [Model.A1099.V2.CoveredIndividualRequest](docs/A1099/V2/CoveredIndividualRequest.md)
 - [Model.A1099.V2.Data](docs/A1099/V2/Data.md)
 - [Model.A1099.V2.ErrorModel](docs/A1099/V2/ErrorModel.md)
 - [Model.A1099.V2.ErrorResponse](docs/A1099/V2/ErrorResponse.md)
 - [Model.A1099.V2.ErrorResponseErrorsInner](docs/A1099/V2/ErrorResponseErrorsInner.md)
 - [Model.A1099.V2.Form1095B](docs/A1099/V2/Form1095B.md)
 - [Model.A1099.V2.Form1095BList](docs/A1099/V2/Form1095BList.md)
 - [Model.A1099.V2.Form1095BListItem](docs/A1099/V2/Form1095BListItem.md)
 - [Model.A1099.V2.Form1095BRequest](docs/A1099/V2/Form1095BRequest.md)
 - [Model.A1099.V2.Form1099Base](docs/A1099/V2/Form1099Base.md)
 - [Model.A1099.V2.Form1099DivList](docs/A1099/V2/Form1099DivList.md)
 - [Model.A1099.V2.Form1099DivListItem](docs/A1099/V2/Form1099DivListItem.md)
 - [Model.A1099.V2.Form1099DivRequest](docs/A1099/V2/Form1099DivRequest.md)
 - [Model.A1099.V2.Form1099DivResponse](docs/A1099/V2/Form1099DivResponse.md)
 - [Model.A1099.V2.Form1099K](docs/A1099/V2/Form1099K.md)
 - [Model.A1099.V2.Form1099KList](docs/A1099/V2/Form1099KList.md)
 - [Model.A1099.V2.Form1099KListItem](docs/A1099/V2/Form1099KListItem.md)
 - [Model.A1099.V2.Form1099KRequest](docs/A1099/V2/Form1099KRequest.md)
 - [Model.A1099.V2.Form1099List](docs/A1099/V2/Form1099List.md)
 - [Model.A1099.V2.Form1099Misc](docs/A1099/V2/Form1099Misc.md)
 - [Model.A1099.V2.Form1099MiscList](docs/A1099/V2/Form1099MiscList.md)
 - [Model.A1099.V2.Form1099MiscListItem](docs/A1099/V2/Form1099MiscListItem.md)
 - [Model.A1099.V2.Form1099MiscRequest](docs/A1099/V2/Form1099MiscRequest.md)
 - [Model.A1099.V2.Form1099MiscResponse](docs/A1099/V2/Form1099MiscResponse.md)
 - [Model.A1099.V2.Form1099Nec](docs/A1099/V2/Form1099Nec.md)
 - [Model.A1099.V2.Form1099NecList](docs/A1099/V2/Form1099NecList.md)
 - [Model.A1099.V2.Form1099NecListItem](docs/A1099/V2/Form1099NecListItem.md)
 - [Model.A1099.V2.Form1099NecRequest](docs/A1099/V2/Form1099NecRequest.md)
 - [Model.A1099.V2.Form1099NecResponse](docs/A1099/V2/Form1099NecResponse.md)
 - [Model.A1099.V2.Form1099ProccessResult](docs/A1099/V2/Form1099ProccessResult.md)
 - [Model.A1099.V2.Form1099R](docs/A1099/V2/Form1099R.md)
 - [Model.A1099.V2.Form1099RList](docs/A1099/V2/Form1099RList.md)
 - [Model.A1099.V2.Form1099RListItem](docs/A1099/V2/Form1099RListItem.md)
 - [Model.A1099.V2.Form1099RRequest](docs/A1099/V2/Form1099RRequest.md)
 - [Model.A1099.V2.Form1099StatusDetail](docs/A1099/V2/Form1099StatusDetail.md)
 - [Model.A1099.V2.FormRequestBase](docs/A1099/V2/FormRequestBase.md)
 - [Model.A1099.V2.FormRequestCsvBase](docs/A1099/V2/FormRequestCsvBase.md)
 - [Model.A1099.V2.FormResponseBase](docs/A1099/V2/FormResponseBase.md)
 - [Model.A1099.V2.FormSingleRequestBase](docs/A1099/V2/FormSingleRequestBase.md)
 - [Model.A1099.V2.Get1099Form200Response](docs/A1099/V2/Get1099Form200Response.md)
 - [Model.A1099.V2.HttpValidationProblemDetails](docs/A1099/V2/HttpValidationProblemDetails.md)
 - [Model.A1099.V2.ICreateForm1099Request](docs/A1099/V2/ICreateForm1099Request.md)
 - [Model.A1099.V2.IUpdateForm1099Request](docs/A1099/V2/IUpdateForm1099Request.md)
 - [Model.A1099.V2.IW9FormDataModelsOneOf](docs/A1099/V2/IW9FormDataModelsOneOf.md)
 - [Model.A1099.V2.IncludedBase](docs/A1099/V2/IncludedBase.md)
 - [Model.A1099.V2.IssuerCommand](docs/A1099/V2/IssuerCommand.md)
 - [Model.A1099.V2.IssuerResponse](docs/A1099/V2/IssuerResponse.md)
 - [Model.A1099.V2.JobResult](docs/A1099/V2/JobResult.md)
 - [Model.A1099.V2.Link](docs/A1099/V2/Link.md)
 - [Model.A1099.V2.PaginatedQueryResultModel](docs/A1099/V2/PaginatedQueryResultModel.md)
 - [Model.A1099.V2.PaginatedQueryResultModelCompanyResponse](docs/A1099/V2/PaginatedQueryResultModelCompanyResponse.md)
 - [Model.A1099.V2.PaginatedQueryResultModelIssuerResponse](docs/A1099/V2/PaginatedQueryResultModelIssuerResponse.md)
 - [Model.A1099.V2.PaginatedW9FormsModel](docs/A1099/V2/PaginatedW9FormsModel.md)
 - [Model.A1099.V2.ProblemDetails](docs/A1099/V2/ProblemDetails.md)
 - [Model.A1099.V2.StateAndLocalWithholding](docs/A1099/V2/StateAndLocalWithholding.md)
 - [Model.A1099.V2.StateAndLocalWithholdingRequest](docs/A1099/V2/StateAndLocalWithholdingRequest.md)
 - [Model.A1099.V2.StateAndLocalWithholdingResponse](docs/A1099/V2/StateAndLocalWithholdingResponse.md)
 - [Model.A1099.V2.StateEfileStatusDetail](docs/A1099/V2/StateEfileStatusDetail.md)
 - [Model.A1099.V2.StateEfileStatusDetailApp](docs/A1099/V2/StateEfileStatusDetailApp.md)
 - [Model.A1099.V2.StatusDetail](docs/A1099/V2/StatusDetail.md)
 - [Model.A1099.V2.SubstantialUsOwnerResponse](docs/A1099/V2/SubstantialUsOwnerResponse.md)
 - [Model.A1099.V2.Update1099Form200Response](docs/A1099/V2/Update1099Form200Response.md)
 - [Model.A1099.V2.ValidationError](docs/A1099/V2/ValidationError.md)
 - [Model.A1099.V2.ValidationErrorApp](docs/A1099/V2/ValidationErrorApp.md)
 - [Model.A1099.V2.W4FormDataModel](docs/A1099/V2/W4FormDataModel.md)
 - [Model.A1099.V2.W4FormResponse](docs/A1099/V2/W4FormResponse.md)
 - [Model.A1099.V2.W8BenEFormResponse](docs/A1099/V2/W8BenEFormResponse.md)
 - [Model.A1099.V2.W8BenESubstantialUsOwnerDataModel](docs/A1099/V2/W8BenESubstantialUsOwnerDataModel.md)
 - [Model.A1099.V2.W8BenFormDataModel](docs/A1099/V2/W8BenFormDataModel.md)
 - [Model.A1099.V2.W8BenFormResponse](docs/A1099/V2/W8BenFormResponse.md)
 - [Model.A1099.V2.W8BeneFormDataModel](docs/A1099/V2/W8BeneFormDataModel.md)
 - [Model.A1099.V2.W8ImyFormDataModel](docs/A1099/V2/W8ImyFormDataModel.md)
 - [Model.A1099.V2.W8ImyFormResponse](docs/A1099/V2/W8ImyFormResponse.md)
 - [Model.A1099.V2.W9FormBaseResponse](docs/A1099/V2/W9FormBaseResponse.md)
 - [Model.A1099.V2.W9FormDataModel](docs/A1099/V2/W9FormDataModel.md)
 - [Model.A1099.V2.W9FormResponse](docs/A1099/V2/W9FormResponse.md)
