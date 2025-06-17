# Avalara.SDK.Model.A1099.V2.IssuerResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier set when the record is created | [optional] [readonly] 
**Name** | **string** | Legal name, not DBA | [optional] 
**NameDba** | **string** | Optional DBA name or continuation of a long legal name | [optional] 
**Tin** | **string** | Tax identification number | [optional] 
**ReferenceId** | **string** | Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces. | [optional] 
**Telephone** | **string** | Telephone number | [optional] 
**TaxYear** | **int?** | Tax year | [optional] 
**CountryCode** | **string** | If there is a transfer agent, use the address of the transfer agent. | [optional] 
**Email** | **string** | Email address | [optional] 
**Address** | **string** | Address | [optional] 
**City** | **string** | City | [optional] 
**State** | **string** | State | [optional] 
**Zip** | **string** | Zip code | [optional] 
**ForeignProvince** | **string** | Foreign province | [optional] 
**TransferAgentName** | **string** | Transfer Agent&#39;s Name | [optional] 
**LastFiling** | **bool** | Last year of filing for this payer | [optional] 
**CreatedAt** | **DateTime** | Date time when the issuer was created | [optional] [readonly] 
**UpdatedAt** | **DateTime** | Date time when the issuer was updated | [optional] [readonly] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

