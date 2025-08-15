# Avalara.SDK.Model.A1099.V2.Form1099DivListItemResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalOrdinaryDividends** | **double?** | Total ordinary dividends | [optional] 
**QualifiedDividends** | **double?** | Qualified dividends | [optional] 
**TotalCapitalGainDistributions** | **double?** | Total capital gain distributions | [optional] 
**UnrecapturedSection1250Gain** | **double?** | Unrecaptured Section 1250 gain | [optional] 
**Section1202Gain** | **double?** | Section 1202 gain | [optional] 
**CollectiblesGain** | **double?** | Collectibles (28%) gain | [optional] 
**Section897OrdinaryDividends** | **double?** | Section 897 ordinary dividends | [optional] 
**Section897CapitalGain** | **double?** | Section 897 capital gain | [optional] 
**NondividendDistributions** | **double?** | Nondividend distributions | [optional] 
**FederalIncomeTaxWithheld** | **double?** | Federal income tax withheld | [optional] 
**Section199ADividends** | **double?** | Section 199A dividends | [optional] 
**InvestmentExpenses** | **double?** | Investment expenses | [optional] 
**ForeignTaxPaid** | **double?** | Foreign tax paid | [optional] 
**ForeignCountryOrUSPossession** | **string** | Foreign country or U.S. possession | [optional] 
**CashLiquidationDistributions** | **double?** | Cash liquidation distributions | [optional] 
**NoncashLiquidationDistributions** | **double?** | Noncash liquidation distributions | [optional] 
**ExemptInterestDividends** | **double?** | Exempt-interest dividends | [optional] 
**SpecifiedPrivateActivityBondInterestDividends** | **double?** | Specified private activity bond interest dividends | [optional] 
**FatcaFilingRequirement** | **bool?** | FATCA filing requirement | [optional] 
**Id** | **string** | ID of the form | [readonly] 
**Type** | **string** | Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC | 
**IssuerId** | **int** | Issuer ID | 
**IssuerReferenceId** | **string** | Issuer Reference ID | [optional] 
**IssuerTin** | **string** | Issuer TIN | [optional] 
**TaxYear** | **int** | Tax year | [optional] 
**FederalEfile** | **bool** | Boolean indicating that federal e-filing has been scheduled for this form | 
**FederalEfileStatus** | [**StatusDetail**](StatusDetail.md) | Federal e-file status | [optional] [readonly] 
**StateEfile** | **bool** | Boolean indicating that state e-filing has been scheduled for this form | 
**StateEfileStatus** | [**List&lt;StateEfileStatusDetailResponse&gt;**](StateEfileStatusDetailResponse.md) | State e-file status | [optional] [readonly] 
**PostalMail** | **bool** | Boolean indicating that postal mailing to the recipient has been scheduled for this form | 
**PostalMailStatus** | [**StatusDetail**](StatusDetail.md) | Postal mail to recipient status | [optional] [readonly] 
**TinMatch** | **bool** | Boolean indicating that TIN Matching has been scheduled for this form | 
**TinMatchStatus** | [**StatusDetail**](StatusDetail.md) | TIN Match status | [optional] [readonly] 
**AddressVerification** | **bool** | Boolean indicating that address verification has been scheduled for this form | 
**AddressVerificationStatus** | [**StatusDetail**](StatusDetail.md) | Address verification status | [optional] [readonly] 
**EDeliveryStatus** | [**StatusDetail**](StatusDetail.md) | EDelivery status | [optional] [readonly] 
**ReferenceId** | **string** | Reference ID | [optional] 
**Email** | **string** | Recipient email address | [optional] 
**TinType** | **string** | Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN | [optional] 
**Tin** | **string** | Recipient Tax ID Number | [optional] 
**NoTin** | **bool** | Indicates whether the recipient has no TIN | [optional] 
**SecondTinNotice** | **bool?** | Second Tin Notice | [optional] 
**RecipientName** | **string** | Recipient name | [optional] 
**RecipientSecondName** | **string** | Recipient second name | [optional] 
**Address** | **string** | Address | [optional] 
**Address2** | **string** | Address line 2 | [optional] 
**City** | **string** | City | [optional] 
**State** | **string** | US state | [optional] 
**Zip** | **string** | Zip/postal code | [optional] 
**NonUsProvince** | **string** | Foreign province | [optional] 
**CountryCode** | **string** | Country code, as defined at https://www.irs.gov/e-file-providers/country-codes | [optional] 
**AccountNumber** | **string** | Account Number | [optional] 
**OfficeCode** | **string** | Office Code | [optional] 
**ValidationErrors** | [**List&lt;ValidationErrorResponse&gt;**](ValidationErrorResponse.md) | Validation errors | [optional] [readonly] 
**CreatedAt** | **DateTime** | Creation time | [optional] [readonly] 
**UpdatedAt** | **DateTime** | Update time | [optional] [readonly] 
**StateAndLocalWithholding** | [**StateAndLocalWithholdingResponse**](StateAndLocalWithholdingResponse.md) |  | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

