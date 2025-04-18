# Avalara.SDK.Model.A1099.V2.W9FormDataModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the form, always W9 for this model. | [optional] [readonly] 
**TinMatchStatus** | **string** | The status of the TIN match. | [optional] 
**Signature** | **string** | The signature itself | [optional] 
**SignedDate** | **DateTime?** | The date the form was signed. | [optional] 
**Name** | **string** | The name of the individual or entity associated with the form. | [optional] 
**BusinessClassification** | **string** | The classification of the business. | [optional] 
**BusinessName** | **string** | The name of the business associated with the form. | [optional] 
**BusinessOther** | **string** |  | [optional] 
**ExemptPayeeCode** | **string** |  | [optional] 
**ExemptFatcaCode** | **string** |  | [optional] 
**TypeOfTin** | **string** | The type of TIN provided. | [optional] 
**Tin** | **string** | The taxpayer identification number (TIN). | [optional] 
**Address** | **string** | The address of the individual or entity. | [optional] 
**City** | **string** | The city of the address. | [optional] 
**State** | **string** | The state of the address. | [optional] 
**Zip** | **string** | The ZIP code of the address. | [optional] 
**AccountNumber** | **string** | The account number associated with the form. | [optional] 
**ForeignCountryIndicator** | **bool?** | Indicates whether the individual or entity is in a foreign country. | [optional] 
**ForeignAddress** | **string** | The foreign address of the individual or entity. | [optional] 
**BackupWithholding** | **bool?** | Indicates whether backup withholding applies. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**Is1099able** | **bool?** |  | [optional] 
**ForeignPartnerOwnerOrBeneficiary** | **bool?** | Indicates whether the individual is a foreign partner, owner, or beneficiary. | [optional] 
**CreatedAt** | **DateTime?** | The creation date of the form. | [optional] 
**Id** | **string** |  | [optional] 
**EntryStatus** | **string** |  | [optional] 
**UpdatedAt** | **DateTime?** | The last updated date of the form. | [optional] 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. | [optional] 
**DisplayName** | **string** | The display name associated with the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 
**Archived** | **bool?** | Indicates whether the form is archived. | [optional] 
**EntryStatusDate** | **DateTime?** |  | [optional] 
**PdfJson** | **string** |  | [optional] 
**PdfVersion** | **string** |  | [optional] 
**RequestToken** | **string** |  | [optional] 
**Mobile** | **bool?** |  | [optional] 
**AppVersion** | **string** |  | [optional] 
**Platform** | **string** |  | [optional] 
**OsVersion** | **string** |  | [optional] 
**AncestorId** | **string** |  | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

