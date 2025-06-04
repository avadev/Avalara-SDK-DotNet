# Avalara.SDK.Model.A1099.V2.InitiateDownloadInputModel
Resource data model for inititating a download job for 1099 forms.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] 
**IssuerId** | **string** | The ID of the issuer. | [optional] 
**IssuerReferenceId** | **string** | A unique reference ID of the issuer | [optional] 
**TaxYear** | **int** | The tax year for the form. | [optional] 
**ReferenceId** | **string** | Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces. | [optional] 
**FederalEfileStatus** | [**Form1099BaseModelFederalEfileStatus**](Form1099BaseModelFederalEfileStatus.md) |  | [optional] 
**PostalMailStatus** | **string** |  | [optional] 
**StateEfileStatus** | [**InitiateDownloadInputModelStateEfileStatus**](InitiateDownloadInputModelStateEfileStatus.md) |  | [optional] 
**TinMatchStatus** | [**TinMatchStatus**](TinMatchStatus.md) |  | [optional] 
**AddressVerificationStatus** | [**AddressVerificationStatus**](AddressVerificationStatus.md) |  | [optional] 
**RecipientName** | **string** | Legal name of the recipient | [optional] 
**RecipientEmail** | **string** | The email address of the recipient. | [optional] 
**RecipientFederalIdNo** | **string** | The federal ID number of the recipient. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

