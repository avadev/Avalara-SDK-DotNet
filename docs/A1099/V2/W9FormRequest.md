# Avalara.SDK.Model.A1099.V2.W9FormRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The form type (always \&quot;w9\&quot; for this model). | [optional] [readonly] 
**Name** | **string** | The name of the individual or entity associated with the form. | [optional] 
**BusinessName** | **string** | The name of the business associated with the form. | [optional] 
**BusinessClassification** | **string** | The classification of the business. | [optional] 
**BusinessOther** | **string** | The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;. | [optional] 
**ForeignPartnerOwnerOrBeneficiary** | **bool** | Indicates whether the individual is a foreign partner, owner, or beneficiary. | [optional] 
**ExemptPayeeCode** | **string** | The exempt payee code. | [optional] 
**ExemptFatcaCode** | **string** | The exemption from FATCA reporting code. | [optional] 
**ForeignCountryIndicator** | **bool** | Indicates whether the individual or entity is in a foreign country. | [optional] 
**Address** | **string** | The address of the individual or entity. | [optional] 
**ForeignAddress** | **string** | The foreign address of the individual or entity. | [optional] 
**City** | **string** | The city of the address. | [optional] 
**State** | **string** | The state of the address. | [optional] 
**Zip** | **string** | The ZIP code of the address. | [optional] 
**AccountNumber** | **string** | The account number associated with the form. | [optional] 
**TinType** | **string** | The type of TIN provided. | [optional] 
**Tin** | **string** | The taxpayer identification number (TIN). | [optional] 
**BackupWithholding** | **bool** | Indicates whether backup withholding applies. | [optional] 
**Is1099able** | **bool** | Indicates whether the individual or entity should be issued a 1099 form. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**Signature** | **string** | The signature of the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. | 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

