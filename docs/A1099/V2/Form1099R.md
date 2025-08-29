# Avalara.SDK.Model.A1099.V2.Form1099R
Form 1099-R: Distributions From Pensions, Annuities, Retirement or Profit-Sharing Plans, IRAs, Insurance Contracts, etc.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrossDistribution** | **double?** | Gross distribution | [optional] 
**TaxableAmount** | **double?** | Taxable amount | [optional] 
**TaxableAmountNotDetermined** | **bool?** | Taxable amount not determined | [optional] 
**TotalDistributionDetermined** | **bool?** | Total distribution | [optional] 
**CapitalGain** | **double?** | Capital gain (included in Box 2a) | [optional] 
**FederalIncomeTaxWithheld** | **double?** | Federal income tax withheld | [optional] 
**EmployeeContributionsOrDesignatedRothOrInsurancePremiums** | **double?** | Employee contributions/Designated Roth contributions or insurance premiums | [optional] 
**NetUnrealizedAppreciationInEmployerSecurities** | **double?** | Net unrealized appreciation in employer&#39;s securities | [optional] 
**DistributionCode** | **string** | Distribution code | [optional] 
**SecondDistributionCode** | **string** | Second distribution code | [optional] 
**IraSepSimple** | **bool?** | IRA/SEP/SIMPLE | [optional] 
**TraditionalIraSepSimpleOrRothConversionAmount** | **double?** | Traditional IRA/SEP/SIMPLE or Roth conversion amount | [optional] 
**OtherAmount** | **double?** | Other amount | [optional] 
**OtherPercentage** | **string** | Other percentage | [optional] 
**TotalDistributionPercentage** | **string** | Total distribution percentage | [optional] 
**TotalEmployeeContributions** | **double?** | Total employee contributions | [optional] 
**AmountAllocableToIrrWithin5Years** | **double?** | Amount allocable to IRR within 5 years | [optional] 
**FirstYearOfDesignatedRothContribution** | **string** | First year of designated Roth contribution | [optional] 
**DateOfPayment** | **DateTime?** | Date of payment | [optional] 
**FatcaFilingRequirement** | **bool?** | FATCA filing requirement | [optional] 
**Type** | **string** | Form type | 
**Id** | **string** | Form ID. Unique identifier set when the record is created. | [optional] [readonly] 
**IssuerId** | **string** | Issuer ID - only required when creating forms | [optional] 
**IssuerReferenceId** | **string** | Issuer Reference ID - only required when creating forms | [optional] 
**IssuerTin** | **string** | Issuer TIN - readonly | [optional] 
**TaxYear** | **int?** | Tax Year - only required when creating forms | [optional] 
**ReferenceId** | **string** | Internal reference ID. Never shown to any agency or recipient. | [optional] 
**Tin** | **string** | Recipient&#39;s Federal Tax Identification Number (TIN). | [optional] 
**RecipientName** | **string** | Recipient name | 
**TinType** | **string** | Type of TIN (Tax ID Number) | [optional] 
**RecipientSecondName** | **string** | Recipient second name | [optional] 
**Address** | **string** | Address. | 
**Address2** | **string** | Address line 2. | [optional] 
**City** | **string** | City. | 
**State** | **string** | Two-letter US state or Canadian province code (required for US/CA addresses). | [optional] 
**Zip** | **string** | ZIP/postal code. | [optional] 
**Email** | **string** | Recipient&#39;s Contact email address. | [optional] 
**AccountNumber** | **string** | Account number | [optional] 
**OfficeCode** | **string** | Office code | [optional] 
**NonUsProvince** | **string** | Province or region for non-US/CA addresses. | [optional] 
**CountryCode** | **string** | Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. | 
**FederalEfileDate** | **DateTime?** | Date when federal e-filing should be scheduled for this form | [optional] 
**PostalMail** | **bool?** | Boolean indicating that postal mailing to the recipient should be scheduled for this form | [optional] 
**StateEfileDate** | **DateTime?** | Date when state e-filing should be scheduled for this form | [optional] 
**RecipientEdeliveryDate** | **DateTime?** | Date when recipient e-delivery should be scheduled for this form | [optional] 
**TinMatch** | **bool?** | Boolean indicating that TIN Matching should be scheduled for this form | [optional] 
**NoTin** | **bool?** | No TIN indicator | [optional] 
**AddressVerification** | **bool?** | Boolean indicating that address verification should be scheduled for this form | [optional] 
**StateAndLocalWithholding** | [**StateAndLocalWithholding**](StateAndLocalWithholding.md) | State and local withholding information | [optional] 
**SecondTinNotice** | **bool** | Second TIN notice | [optional] 
**FederalEfileStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Federal e-file status | [optional] [readonly] 
**StateEfileStatus** | [**List&lt;StateEfileStatusDetail&gt;**](StateEfileStatusDetail.md) | State e-file status | [optional] [readonly] 
**PostalMailStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Postal mail to recipient status | [optional] [readonly] 
**TinMatchStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | TIN Match status | [optional] [readonly] 
**AddressVerificationStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Address verification status | [optional] [readonly] 
**EDeliveryStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | EDelivery status | [optional] [readonly] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Validation errors | [optional] [readonly] 
**CreatedAt** | **DateTime** | Date time when the record was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime** | Date time when the record was last updated. | [optional] [readonly] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

