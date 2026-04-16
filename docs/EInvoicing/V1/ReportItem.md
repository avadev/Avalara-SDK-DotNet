# Avalara.SDK.Model.EInvoicing.V1.ReportItem
Represents a single report with full details including metadata and associated transaction IDs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReportId** | **string** | The unique ID for this report. | [optional] 
**JobId** | **string** | The unique ID of the job that generated this report. | [optional] 
**ReportGenerateDate** | **DateTime** | The date and time when the report was generated. | [optional] 
**ReportFrom** | **DateTime?** | The start date of the reporting period. | [optional] 
**ReportTo** | **DateTime?** | The end date of the reporting period. | [optional] 
**CountryCode** | **string** | The two-letter ISO-3166 country code for which this report was generated. | [optional] 
**CountryMandate** | **string** | The e-invoicing mandate for the specified country. | [optional] 
**DocumentType** | **string** | The type of document covered by this report. | [optional] 
**DocumentSubType** | **string** | The sub-type of the document. | [optional] 
**ReportReference** | **string** | An internal reference path for the report. | [optional] 
**ReportName** | **string** | The name of the report file. | [optional] 
**Status** | **string** | The current status of the report. Possible values include: PENDING, PROCESSING, COMPLETED, FAILED, SENT_TO_PPF, ERROR. | [optional] 
**ReportFormatMimetypes** | **string** | The MIME type of the report file. | [optional] 
**TenantId** | **string** | The tenant identifier associated with this report. | [optional] 
**TaName** | **string** | The name of the tax authority for this report. | [optional] 
**TaxInvoiceAmount** | **decimal?** | The total invoice amount covered by this report. | [optional] 
**TotalTaxAmount** | **decimal?** | The total tax amount covered by this report. | [optional] 
**Metadata** | **Object** | Additional report metadata (free-form JSON). Contents vary by country mandate. | [optional] 
**TransactionIds** | **List&lt;string&gt;** | List of transaction IDs associated with this report. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

