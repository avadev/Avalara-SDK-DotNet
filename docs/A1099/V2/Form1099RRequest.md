# Avalara.SDK.Model.A1099.V2.Form1099RRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrossDistribution** | **double** | Gross distribution | [optional] 
**TaxableAmount** | **double** | Taxable amount | [optional] 
**TaxableAmountNotDetermined** | **bool** | Taxable amount not determined | [optional] 
**TotalDistributionDetermined** | **bool** | Total distribution | [optional] 
**CapitalGain** | **double** | Capital gain (included in Box 2a) | [optional] 
**FederalIncomeTaxWithheld** | **double** | Federal income tax withheld | [optional] 
**EmployeeContributionsOrDesignatedRothOrInsurancePremiums** | **double** | Employee contributions/Designated Roth contributions or insurance premiums | [optional] 
**NetUnrealizedAppreciationInEmployerSecurities** | **double** | Net unrealized appreciation in employer&#39;s securities | [optional] 
**DistributionCode** | **string** | Distribution code | [optional] 
**SecondDistributionCode** | **string** | Second distribution code | [optional] 
**IraSepSimple** | **bool** | IRA/SEP/SIMPLE | [optional] 
**TraditionalIraSepSimpleOrRothConversionAmount** | **double** | Traditional IRA/SEP/SIMPLE or Roth conversion amount | [optional] 
**OtherAmount** | **double** | Other amount | [optional] 
**OtherPercentage** | **string** | Other percentage | [optional] 
**TotalDistributionPercentage** | **string** | Total distribution percentage | [optional] 
**TotalEmployeeContributions** | **double** | Total employee contributions | [optional] 
**AmountAllocableToIrrWithin5Years** | **double** | Amount allocable to IRR within 5 years | [optional] 
**FirstYearOfDesignatedRothContribution** | **string** | First year of designated Roth contribution | [optional] 
**FatcaFilingRequirement** | **bool** | FATCA filing requirement | [optional] 
**DateOfPayment** | **DateTime** | Date of payment | [optional] 
**Type** | **string** |  | [optional] 
**IssuerId** | **string** | Issuer ID | [optional] 
**ReferenceId** | **string** | Reference ID | [optional] 
**RecipientTin** | **string** | Recipient Tax ID Number | [optional] 
**RecipientName** | **string** | Recipient name | [optional] 
**TinType** | **string** | Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN | [optional] 
**RecipientSecondName** | **string** | Recipient second name | [optional] 
**Address** | **string** | Address | 
**Address2** | **string** | Address line 2 | [optional] 
**City** | **string** | City | 
**State** | **string** | US state. Required if CountryCode is \&quot;US\&quot;. | [optional] 
**Zip** | **string** | Zip/postal code | [optional] 
**Email** | **string** | Recipient email address | [optional] 
**AccountNumber** | **string** | Account number | [optional] 
**OfficeCode** | **string** | Office code | [optional] 
**NonUsProvince** | **string** | Foreign province | [optional] 
**CountryCode** | **string** | Country code, as defined at https://www.irs.gov/e-file-providers/country-codes | 
**FederalEFile** | **bool** | Boolean indicating that federal e-filing should be scheduled for this form | [optional] 
**PostalMail** | **bool** | Boolean indicating that postal mailing to the recipient should be scheduled for this form | [optional] 
**StateEFile** | **bool** | Boolean indicating that state e-filing should be scheduled for this form | [optional] 
**TinMatch** | **bool** | Boolean indicating that TIN Matching should be scheduled for this form | [optional] 
**NoTin** | **bool** | Indicates whether the recipient has no TIN | [optional] 
**SecondTinNotice** | **bool?** | Second TIN notice in three years | [optional] 
**AddressVerification** | **bool** | Boolean indicating that address verification should be scheduled for this form | [optional] 
**StateAndLocalWithholding** | [**StateAndLocalWithholdingRequest**](StateAndLocalWithholdingRequest.md) | State and local withholding information | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

