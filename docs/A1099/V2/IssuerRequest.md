# Avalara.SDK.Model.A1099.V2.IssuerRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Legal name. Not the DBA name. | 
**DbaName** | **string** | Doing Business As (DBA) name or continuation of a long legal name. Use either this or &#39;transferAgentName&#39;. | [optional] 
**Tin** | **string** | Federal Tax Identification Number (TIN). | [optional] 
**ReferenceId** | **string** | Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces. | [optional] 
**Telephone** | **string** | Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries. | 
**TaxYear** | **int?** | Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4. | 
**CountryCode** | **string** | Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address. | [optional] 
**Email** | **string** | Contact email address. For recipient inquiries. | 
**Address** | **string** | Address. | 
**City** | **string** | City. | 
**State** | **string** | Two-letter US state or Canadian province code (required for US/CA addresses). | 
**Zip** | **string** | ZIP/postal code. | 
**ForeignProvince** | **string** | Province or region for non-US/CA addresses. | [optional] 
**TransferAgentName** | **string** | Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;. | [optional] 
**LastFiling** | **bool?** | Indicates if this is the issuer&#39;s final year filing. | 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

