# Avalara.SDK.Model.EInvoicing.V1.TaxIdentifierRequest
Represents a request to validate company’s tax identifier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryCode** | **string** | The two-letter ISO-3166 country code of the tax identifier. | 
**IdentifierType** | **string** | Type of the identifier. | 
**Identifier** | **string** | The tax identifier of the company. | 
**Extensions** | **Object** | Optional field for adding additional details required by specific tax authorities. Refer to the GET /tax-identifiers/schema API endpoint for the full request structure for a given country. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

