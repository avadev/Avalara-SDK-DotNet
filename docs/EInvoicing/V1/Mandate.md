# Avalara.SDK.Model.EInvoicing.V1.Mandate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MandateId** | **string** | The &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). Keep in mind the following when specifying a &#x60;mandateId&#x60;. - A country can have multiple mandate types (B2C, B2B, B2G). - A entity/company can opt in for multiple mandates. - A &#x60;mandateId&#x60; is the combination of country + mandate type + network/regulation. | [optional] 
**CountryMandate** | **string** | **[LEGACY]** This field is retained for backward compatibility. It is recommended to use &#x60;mandateId&#x60; instead. The &#x60;countryMandate&#x60; similar to the &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL).  | [optional] 
**CountryCode** | **string** | Country code | [optional] 
**Description** | **string** | Mandate description | [optional] 
**SupportedByELRAPI** | **bool** | Indicates whether this mandate supported by the ELR API | [optional] 
**MandateFormat** | **string** | Mandate format | [optional] 
**EInvoicingFlow** | **string** | The type of e-invoicing flow for this mandate | [optional] 
**EInvoicingFlowDocumentationLink** | **string** | Link to the documentation for this mandate&#39;s e-invoicing flow | [optional] 
**GetInvoiceAvailableMediaType** | **List&lt;string&gt;** | List of available media types for downloading invoices for this mandate | [optional] 
**SupportsInboundDigitalDocument** | **string** | Indicates whether this mandate supports inbound digital documents | [optional] 
**InputDataFormats** | [**List&lt;InputDataFormats&gt;**](InputDataFormats.md) | Format and version used when inputting the data | [optional] 
**OutputDataFormats** | [**List&lt;OutputDataFormats&gt;**](OutputDataFormats.md) | Lists the supported output document formats for the country mandate. For countries where specifying an output document format is required (e.g., France), this array will contain the applicable formats. For other countries where output format selection is not necessary, the array will be empty. | [optional] 
**WorkflowIds** | [**List&lt;WorkflowIds&gt;**](WorkflowIds.md) | Workflow ID list | [optional] 
**SupportedDocumentStatuses** | [**List&lt;SupportedDocumentStatuses&gt;**](SupportedDocumentStatuses.md) | List of document statuses defined by the mandate. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

