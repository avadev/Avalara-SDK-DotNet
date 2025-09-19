# Avalara.SDK.Model.A1099.V2.CompanyBase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Legal name. Not the DBA name. | 
**DbaName** | **string** | Doing Business As (DBA) name or continuation of a long legal name. | [optional] 
**Email** | **string** | Contact email address. For inquiries by vendors/employees. | 
**Address** | **string** | Address. | 
**City** | **string** | City. | 
**State** | **string** | Two-letter US state or Canadian province code (required for US/CA addresses). | [optional] 
**Zip** | **string** | ZIP/postal code. | 
**Telephone** | **string** | Contact phone number (must contain at least 10 digits, max 15 characters). | 
**Tin** | **string** | Federal Tax Identification Number (TIN). EIN/Tax ID (required for US companies). | 
**ReferenceId** | **string** | Internal reference ID. Never shown to any agency or recipient. | [optional] 
**DoTinMatch** | **bool?** | Indicates whether the company authorizes IRS TIN matching. | [optional] 
**GroupName** | **string** | Group name for organizing companies (creates or finds group by name). | [optional] 
**ForeignProvince** | **string** | Province or region for non-US/CA addresses. | [optional] 
**CountryCode** | **string** | Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. | 
**ResendRequests** | **bool?** | Boolean to enable automatic reminder emails (default: false). | [optional] 
**ResendIntervalDays** | **int?** | Days between reminder emails (7-365, required if resendRequests is true). | [optional] 
**MaxReminderAttempts** | **int?** | Maximum number of reminder attempts (1-52, required if resendRequests is true). | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

