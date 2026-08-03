# Avalara.SDK.Model.A1099.V2.IssuerRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessName** | **string** | Business name. Required when the recipient of the form is a business; should only be used for businesses. | 
**BusinessName2** | **string** | Business name line 2. Should only be used for businesses. Use either this or &#39;transferAgentName&#39;. | [optional] 
**Name** | **string** | Legal name. Not the DBA name. Deprecated alias for &#39;businessName&#39;. | [optional] 
**DbaName** | **string** | Doing Business As (DBA) name or continuation of a long legal name. Deprecated alias for &#39;businessName2&#39;. Use either this or &#39;transferAgentName&#39;. | [optional] 
**TinType** | **string** | Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number | [optional] 
**FirstName** | **string** | First name. Required when the recipient of the form is an individual; should only be used for individuals. | [optional] 
**MiddleName** | **string** | Middle name. Should only be used for individuals. | [optional] 
**LastName** | **string** | Last name. Required when the recipient of the form is an individual; should only be used for individuals. | [optional] 
**Suffix** | **string** | Suffix name. Should only be used for individuals. | [optional] 
**Tin** | **string** | Federal Tax Identification Number (TIN). | [optional] 
**ReferenceId** | **string** | Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces. | [optional] 
**Telephone** | **string** | Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries. | 
**TaxYear** | **int?** | Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4. It&#39;s only required on creation, and cannot be modified on update. | 
**CountryCode** | **string** | Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address. | 
**Email** | **string** | Contact email address. For recipient inquiries. Phone will be used on communications if you don&#39;t specify an email | [optional] 
**Address** | **string** | Address. | 
**City** | **string** | City. | 
**State** | **string** | Two-letter US state or Canadian province code (required for US/CA addresses). | 
**Zip** | **string** | ZIP/postal code. | 
**ForeignProvince** | **string** | Province or region for non-US/CA addresses. | [optional] 
**TransferAgentName** | **string** | Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;. | [optional] 
**LastFiling** | **bool?** | Indicates if this is the issuer&#39;s final year filing. | 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

