# Avalara.SDK.Model.A1099.V2.Form1095B
Form 1095-B: Health Coverage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeFirstName** | **string** | Employee&#39;s first name | 
**EmployeeMiddleName** | **string** | Employee&#39;s middle name | [optional] 
**EmployeeLastName** | **string** | Employee&#39;s last name | 
**EmployeeNameSuffix** | **string** | Employee&#39;s name suffix | [optional] 
**EmployeeDateOfBirth** | **DateTime?** | Employee&#39;s date of birth | [optional] 
**OriginOfHealthCoverageCode** | **string** | Origin of health coverage code  Available values:  - A: Small Business Health Options Program (SHOP)  - B: Employer-sponsored coverage  - C: Government-sponsored program  - D: Individual market insurance  - E: Multiemployer plan  - F: Other designated minimum essential coverage  - G: Employer-sponsored coverage that is an individual coverage HRA (valid for tax years 2020 and later) | 
**CoveredIndividuals** | [**List&lt;CoveredIndividual&gt;**](CoveredIndividual.md) | Covered individuals information - At least one month of coverage must be entered if it&#39;s not a correction. | [optional] 
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

