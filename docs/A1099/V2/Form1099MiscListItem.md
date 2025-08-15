# Avalara.SDK.Model.A1099.V2.Form1099MiscListItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rents** | **double** | Rents | [optional] 
**Royalties** | **double** | Royalties | [optional] 
**OtherIncome** | **double** | Other income | [optional] 
**FedIncomeTaxWithheld** | **double** | Federal income tax withheld | [optional] 
**FishingBoatProceeds** | **double** | Fishing boat proceeds | [optional] 
**MedicalAndHealthCarePayments** | **double** | Medical and health care payments | [optional] 
**DirectSalesIndicator** | **bool** | Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale | [optional] 
**SubstitutePayments** | **double** | Substitute payments in lieu of dividends or interest | [optional] 
**CropInsuranceProceeds** | **double** | Crop insurance proceeds | [optional] 
**GrossProceedsPaidToAttorney** | **double** | Gross proceeds paid to an attorney | [optional] 
**FishPurchasedForResale** | **double** | Fish purchased for resale | [optional] 
**Section409ADeferrals** | **double** | Section 409A deferrals | [optional] 
**FatcaFilingRequirement** | **bool** | FATCA filing requirement | [optional] 
**ExcessGoldenParachutePayments** | **double** | (Legacy field) Excess golden parachute payments | [optional] 
**NonqualifiedDeferredCompensation** | **double** | Nonqualified deferred compensation | [optional] 
**IssuerReferenceId** | **string** | Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required. | [optional] 
**IssuerTin** | **string** | Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required. | [optional] 
**TaxYear** | **int** | Tax year | 
**IssuerId** | **string** | Issuer ID | [optional] 
**ReferenceId** | **string** | Reference ID | [optional] 
**RecipientTin** | **string** | Recipient Tax ID Number | [optional] 
**RecipientName** | **string** | Recipient name | [optional] 
**TinType** | **string** | Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN | [optional] 
**RecipientSecondName** | **string** | Recipient second name | [optional] 
**Address** | **string** | Address | [optional] 
**Address2** | **string** | Address line 2 | [optional] 
**City** | **string** | City | [optional] 
**State** | **string** | US state. Required if CountryCode is \&quot;US\&quot;. | [optional] 
**Zip** | **string** | Zip/postal code | [optional] 
**Email** | **string** | Recipient email address | [optional] 
**AccountNumber** | **string** | Account number | [optional] 
**OfficeCode** | **string** | Office code | [optional] 
**NonUsProvince** | **string** | Foreign province | [optional] 
**CountryCode** | **string** | Country code, as defined at https://www.irs.gov/e-file-providers/country-codes | [optional] 
**FederalEFile** | **bool** | Boolean indicating that federal e-filing should be scheduled for this form | [optional] 
**PostalMail** | **bool** | Boolean indicating that postal mailing to the recipient should be scheduled for this form | [optional] 
**StateEFile** | **bool** | Boolean indicating that state e-filing should be scheduled for this form | [optional] 
**TinMatch** | **bool** | Boolean indicating that TIN Matching should be scheduled for this form | [optional] 
**NoTin** | **bool** | Indicates whether the recipient has no TIN | [optional] 
**SecondTinNotice** | **bool?** | Second TIN notice in three years | [optional] 
**AddressVerification** | **bool** | Boolean indicating that address verification should be scheduled for this form | [optional] 
**StateAndLocalWithholding** | [**StateAndLocalWithholdingRequest**](StateAndLocalWithholdingRequest.md) | State and local withholding information | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

