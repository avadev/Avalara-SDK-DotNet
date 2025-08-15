# Avalara.SDK.Model.A1099.V2.W9FormResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the form. | [optional] 
**EntryStatus** | **string** | The form status. | [optional] 
**EntryStatusDate** | **DateTime?** | The timestamp for the latest status update. | [optional] 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. | [optional] 
**DisplayName** | **string** | The display name associated with the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 
**Archived** | **bool** | Indicates whether the form is archived. | [optional] 
**Signature** | **string** | The signature of the form. | [optional] 
**SignedDate** | **DateTime?** | The date the form was signed. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**CreatedAt** | **DateTime** | The creation date of the form. | [optional] 
**UpdatedAt** | **DateTime** | The last updated date of the form. | [optional] 
**Type** | **string** | The type of the response object. | [optional] 
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
**TinMatchStatus** | [**TinMatchStatusResponse**](TinMatchStatusResponse.md) | The TIN Match status from IRS. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

