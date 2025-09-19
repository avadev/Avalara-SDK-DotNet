# Avalara.SDK.Model.A1099.V2.W8BenFormResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The form type (always \&quot;W8Ben\&quot; for this model). | [optional] [readonly] 
**Name** | **string** | The name of the individual or entity associated with the form. | [optional] 
**CitizenshipCountry** | **string** | The country of citizenship. | [optional] 
**ResidenceAddress** | **string** | The residential address of the individual or entity. | [optional] 
**ResidenceCity** | **string** | The city of residence. | [optional] 
**ResidenceState** | **string** | The state of residence. | [optional] 
**ResidenceZip** | **string** | The ZIP code of the residence. | [optional] 
**ResidenceCountry** | **string** | The country of residence. | [optional] 
**ResidenceIsMailing** | **bool** | Indicates whether the residence address is the mailing address. | [optional] 
**MailingAddress** | **string** | The mailing address. | [optional] 
**MailingCity** | **string** | The city of the mailing address. | [optional] 
**MailingState** | **string** | The state of the mailing address. | [optional] 
**MailingZip** | **string** | The ZIP code of the mailing address. | [optional] 
**MailingCountry** | **string** | The country of the mailing address. | [optional] 
**TinType** | **string** | Tax Identification Number (TIN) type. | [optional] 
**Tin** | **string** | The taxpayer identification number (TIN). | [optional] 
**ForeignTinNotRequired** | **bool** | Indicates whether a foreign TIN is not required. | [optional] 
**ForeignTin** | **string** | The foreign taxpayer identification number (TIN). | [optional] 
**ReferenceNumber** | **string** | A reference number for the form. | [optional] 
**Birthday** | **DateTime?** | The birthday of the individual associated with the form. | [optional] 
**TreatyCountry** | **string** | The country for which the treaty applies. | [optional] 
**TreatyArticle** | **string** | The specific article of the treaty being claimed. | [optional] 
**TreatyReasons** | **string** | The reasons for claiming treaty benefits. | [optional] 
**WithholdingRate** | **string** | The withholding rate applied as per the treaty. | [optional] 
**IncomeType** | **string** | The type of income covered by the treaty. | [optional] 
**SignerName** | **string** | The name of the signer of the form. | [optional] 
**SignerCapacity** | **string** | The capacity in which the signer is signing the form. | [optional] 
**Id** | **string** | The unique identifier for the form. | [optional] 
**EntryStatus** | [**EntryStatusResponse**](EntryStatusResponse.md) | The entry status information for the form. | [optional] 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. | [optional] 
**DisplayName** | **string** | The display name associated with the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 
**Archived** | **bool** | Indicates whether the form is archived. | [optional] 
**AncestorId** | **string** | Form ID of previous version. | [optional] 
**Signature** | **string** | The signature of the form. | [optional] 
**SignedDate** | **DateTime?** | The date the form was signed. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**CreatedAt** | **DateTime** | The creation date of the form. | [optional] 
**UpdatedAt** | **DateTime** | The last updated date of the form. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

