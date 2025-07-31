# Avalara.SDK.Model.A1099.V2.Form1095BRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeFirstName** | **string** | Employee&#39;s first name | [optional] 
**EmployeeMiddleName** | **string** | Employee&#39;s middle name | [optional] 
**EmployeeLastName** | **string** | Employee&#39;s last name | [optional] 
**EmployeeNameSuffix** | **string** | Employee&#39;s name suffix | [optional] 
**EmployeeDateOfBirth** | **DateTime?** | Employee&#39;s date of birth | [optional] 
**OriginOfHealthCoverageCode** | **string** | Origin of health coverage code | [optional] 
**CoveredIndividuals** | [**List&lt;CoveredIndividualRequest&gt;**](CoveredIndividualRequest.md) | Covered individuals information | [optional] 
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

