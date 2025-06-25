# Avalara.SDK.Model.A1099.V2.Form1099OneOf
1099 form

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [readonly] 
**NonemployeeCompensation** | **double** | The non-employee compensation reported in box 1. | [optional] 
**ForResale** | **string** | Indicates whether the payment is for resale purposes. | [optional] 
**FederalIncomeTaxWithheld** | **double?** | The amount of federal income tax withheld, if any. | [optional] 
**StateWithholding** | [**StateWithholding**](StateWithholding.md) |  | [optional] 
**IssuerId** | **string** | The ID of the issuer. | 
**IssuerReferenceId** | **string** | Unique reference ID of the issuer | [optional] 
**IssuerTin** | **string** | The Taxpayer Identification Number of the issuer. | [optional] 
**TaxYear** | **int** | The tax year for the form in the format CCYY | [optional] 
**FederalEfile** | **bool** | When upserting, this declares whether or not to federal e-file this form. | [optional] 
**FederalEfileStatus** | [**Form1099BaseModelFederalEfileStatus**](Form1099BaseModelFederalEfileStatus.md) |  | [optional] 
**PostalMail** | **bool** | When upserting, this declares whether or not to postal mail this form to the recipient. | [optional] 
**PostalMailStatus** | [**Form1099BaseModelPostalMailStatus**](Form1099BaseModelPostalMailStatus.md) |  | [optional] 
**StateEfile** | **bool** | When upserting, this declares whether or not to state e-file this form. | [optional] 
**StateEfileStatuses** | [**List&lt;StateEfileStatusesInner&gt;**](StateEfileStatusesInner.md) | The status of state e-filing. ONLY USED ON RESPONSES. | [optional] 
**TinMatch** | **bool** | When upserting this declares whether or not to TIN match this form. | [optional] 
**TinMatchStatus** | [**TinMatchStatus**](TinMatchStatus.md) |  | [optional] 
**AddressVerification** | **bool** | When upserting, this declares whether or not to perform address verification for this form. | [optional] 
**AddressVerificationStatus** | [**AddressVerificationStatus**](AddressVerificationStatus.md) |  | [optional] 
**ReferenceId** | **string** | Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces. | 
**RecipientName** | **string** | Legal name of the recipient | 
**FederalIdType** | **string** | The type of federal ID provided by the recipient. | [optional] 
**RecipientFederalIdNo** | **string** | The federal ID number of the recipient. | 
**RecipientSecondName** | **string** | The second name of the recipient, if applicable. | [optional] 
**StreetAddress** | **string** | The street address of the recipient. | [optional] 
**StreetAddressLine2** | **string** | The second line of the street address, if applicable. | [optional] 
**City** | **string** | The city of the recipient. | [optional] 
**State** | **string** | The state of the recipient. | 
**Zip** | **string** | The ZIP code of the recipient. | 
**ForeignProvince** | **string** | The foreign province, if applicable. | [optional] 
**CountryCode** | **string** | The country code of the recipient. | 
**RecipientEmail** | **string** | The email address of the recipient. | [optional] 
**AcctNo** | **string** | The account number associated with the form. | [optional] 
**OfficeCode** | **string** | The office code associated with the form. | [optional] 
**Rents** | **double** | Amount of rents. | [optional] 
**Royalties** | **double** | Amount of royalties. | [optional] 
**OtherIncome** | **double** | Amount of other income. | [optional] 
**FedIncomeTaxWithheld** | **double** | Amount of federal income tax withheld. | [optional] 
**FishingBoatProceeds** | **double** | Proceeds from fishing boats. | [optional] 
**MedicalAndHealthCare** | **double** | Amount of medical and healthcare payments. | [optional] 
**SubstitutePayments** | **double** | Amount of substitute payments. | [optional] 
**CropInsuranceProceeds** | **double** | Crop insurance proceeds. | [optional] 
**GrossProceedsPaidToAnAttorney** | **double** | Gross proceeds paid to an attorney. | [optional] 
**FishPurchasedForResale** | **double** | Amount of fish purchased for resale. | [optional] 
**Section409aDeferrals** | **double?** | Section 409A deferrals. | [optional] 
**FatcaFilingReqt** | **string** | FATCA filing requirement indicator. | [optional] 
**ExcessGoldenParachutePayments** | **double** | Excess golden parachute payments. | [optional] 
**NonqualifiedDeferredCompensation** | **double?** | Nonqualified deferred compensation. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

