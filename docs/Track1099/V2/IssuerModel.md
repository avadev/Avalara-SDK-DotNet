# Avalara.SDK.Model.Track1099.V2.IssuerModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Legal name, not DBA | 
**NameDba** | **string** | Optional DBA name or continuation of a long legal name | [optional] 
**Tin** | **string** | Tax identification number | [optional] 
**ReferenceId** | **string** | Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces. | [optional] 
**Telephone** | **string** | Telephone number | 
**TaxYear** | **int** | Tax year | 
**ShippingCountryCode** | **string** | If there is a transfer agent, use the shipping address of the transfer agent. | [optional] 
**Email** | **string** | Email address | [optional] 
**Address** | **string** | Shipping address | 
**City** | **string** | City | 
**State** | **string** | State | [optional] 
**Zip** | **string** | Zip code | 
**ForeignProvince** | **string** | Foreign province | [optional] 
**Id** | **long** | Unique identifier set when the record is created | [optional] [readonly] 
**CreatedAt** | **DateTime** | Date time when the issuer was created | [optional] [readonly] 
**UpdatedAt** | **DateTime** | Date time when the issuer was updated | [optional] [readonly] 
**UserId** | **long** | id or the manager_id of the user to whom this issuer belongs to | [optional] [readonly] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

