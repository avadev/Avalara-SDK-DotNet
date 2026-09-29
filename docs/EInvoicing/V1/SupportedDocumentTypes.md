# Avalara.SDK.Model.EInvoicing.V1.SupportedDocumentTypes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Document type name. | [optional] 
**Value** | **string** | Document type value. | 
**SupportedByTradingPartner** | **bool** | Does trading partner support receiving this document type. | 
**SupportedByAvalara** | **bool** | Does avalara support exchanging this document type. | [optional] 
**Extensions** | [**List&lt;Extension&gt;**](Extension.md) | Optional array used to carry additional metadata or configuration values that may be required by specific document types. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

