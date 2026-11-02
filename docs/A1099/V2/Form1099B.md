# Avalara.SDK.Model.A1099.V2.Form1099B
Form 1099-B: Proceeds From Broker and Barter Exchange Transactions                The recipient is the customer and the issuer is the broker or barter exchange. Each form reports one sale.                *Required:* `applicableCheckboxOnForm8949`, `descriptionOfProperty`, `proceeds` (which can be zero or negative) and  `proceedsReportedToIrs`. `typeOfGainOrLoss` is required unless `noncoveredSecurity` is `true`.                `dateSoldOrDisposed` must fall in the tax year. `dateAcquired` can't be after the tax year or before January 1 of the  year 50 years before the current filing year, whatever the form's tax year. `costOrOtherBasis`,  `washSaleLossDisallowed` and `federalIncomeTaxWithheld` can't be negative; the other amounts can.  `federalIncomeTaxWithheld` must be less than `proceeds` (zero when `proceeds` is zero or negative), and can't be more  than 24% of the other amounts on the form combined, not counting state and local withholding.                `stateAndLocalWithholding` carries `state`, `stateId`, `stateTaxWithheld`, `locality`, `localityId` and  `localTaxWithheld`. `state` and `stateId` are required when `stateTaxWithheld` has an amount. Form 1099-B has no state  or local income fields, so `stateIncome` and `localIncome` are discarded and read back as `null`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicableCheckboxOnForm8949** | **string** | Applicable checkbox on Form 8949.                * &#x60;A&#x60; - Short-term transaction, basis reported to the IRS  * &#x60;B&#x60; - Short-term transaction, basis not reported to the IRS  * &#x60;D&#x60; - Long-term transaction, basis reported to the IRS  * &#x60;E&#x60; - Long-term transaction, basis not reported to the IRS  * &#x60;X&#x60; - Basis not reported to the IRS and the holding period is unknown | 
**CusipNumber** | **string** | CUSIP number (up to 13 letters or digits) | [optional] 
**DescriptionOfProperty** | **string** | Description of property, such as the number of shares and the name of the stock | 
**DateAcquired** | **DateTime?** | Date acquired. Can&#39;t be after the tax year or before January 1 of the year 50 years before the current  filing year (for example, 1975-01-01 when filing for 2025), whatever the form&#39;s tax year. | [optional] 
**DateSoldOrDisposed** | **DateTime?** | Date sold or disposed. Must fall in the tax year. | [optional] 
**Proceeds** | **double?** | Proceeds. Can be zero, or negative for a loss. | 
**CostOrOtherBasis** | **double?** | Cost or other basis | [optional] 
**AccruedMarketDiscount** | **double?** | Accrued market discount | [optional] 
**WashSaleLossDisallowed** | **double?** | Wash sale loss disallowed | [optional] 
**TypeOfGainOrLoss** | **string** | Type of gain or loss. Required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                * &#x60;SHORT_TERM&#x60; - Short-term gain or loss  * &#x60;LONG_TERM&#x60; - Long-term gain or loss  * &#x60;ORDINARY_SHORT_TERM&#x60; - Ordinary, short-term  * &#x60;ORDINARY_LONG_TERM&#x60; - Ordinary, long-term | [optional] 
**ProceedsFrom** | **string** | Source of the proceeds, if they are from collectibles or a Qualified Opportunity Fund.                * &#x60;COLLECTIBLES&#x60; - Collectibles  * &#x60;QOF&#x60; - Qualified Opportunity Fund (QOF) | [optional] 
**FederalIncomeTaxWithheld** | **double?** | Federal income tax withheld. Must be less than &#x60;proceeds&#x60; (zero when &#x60;proceeds&#x60; is zero or negative), and can&#39;t be  more than 24% of the other amounts on the form combined, not counting state and local withholding. | [optional] 
**NoncoveredSecurity** | **bool?** | If checked, the security is noncovered | [optional] 
**ProceedsReportedToIrs** | **string** | Whether gross or net proceeds are reported to the IRS.                * &#x60;GROSS&#x60; - Gross proceeds  * &#x60;NET&#x60; - Net proceeds | 
**LossNotAllowed** | **bool?** | If checked, the loss is not allowed based on the amount in &#x60;proceeds&#x60; | [optional] 
**ProfitOrLossRealizedOnClosedContracts** | **double?** | Profit or (loss) realized in the tax year on closed contracts | [optional] 
**UnrealizedProfitOrLossOnOpenContractsPriorYear** | **double?** | Unrealized profit or (loss) on open contracts at the end of the prior tax year | [optional] 
**UnrealizedProfitOrLossOnOpenContractsCurrentYear** | **double?** | Unrealized profit or (loss) on open contracts at the end of the tax year | [optional] 
**AggregateProfitOrLossOnContracts** | **double?** | Aggregate profit or (loss) on contracts | [optional] 
**BasisReportedToIrs** | **bool?** | If checked, the basis is reported to the IRS. Only takes effect when &#x60;noncoveredSecurity&#x60; is also checked:  otherwise it isn&#39;t sent to the IRS, and changing it doesn&#39;t trigger a correction. | [optional] 
**Bartering** | **double?** | Bartering | [optional] 
**FatcaFilingRequirement** | **bool?** | FATCA filing requirement | [optional] 
**Type** | **string** | Form type. | 
**Id** | **string** | Form ID. Unique identifier set when the record is created. | [optional] [readonly] 
**IssuerId** | **string** | Issuer ID - only required when creating forms | [optional] 
**IssuerReferenceId** | **string** | Issuer Reference ID - only required when creating forms via $bulk-upsert | [optional] 
**IssuerTin** | **string** | Issuer TIN - readonly | [optional] 
**TaxYear** | **int?** | Tax Year - only required when creating forms via $bulk-upsert | [optional] 
**ReferenceId** | **string** | Internal reference ID. Never shown to any agency or recipient. | [optional] 
**Tin** | **string** | Recipient&#39;s Federal Tax Identification Number (TIN). | [optional] 
**RecipientName** | **string** | DEPRECATED: Use &#x60;businessName&#x60; for businesses; use &#x60;firstName&#x60;, &#x60;middleName&#x60;, &#x60;lastName&#x60;, and &#x60;suffixName&#x60; for individuals. | [optional] 
**Address** | **string** | Address. | 
**Address2** | **string** | Address line 2. | [optional] 
**City** | **string** | City. | 
**State** | **string** | Two-letter US state or Canadian province code (required for US/CA addresses). | [optional] 
**Zip** | **string** | ZIP/postal code. | [optional] 
**Email** | **string** | Recipient&#39;s Contact email address. | [optional] 
**NonUsProvince** | **string** | Province or region for non-US/CA addresses. | [optional] 
**CountryCode** | **string** | Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. | 
**FederalEfileDate** | **DateTime?** | Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled. | [optional] 
**PostalMail** | **bool?** | Boolean indicating that postal mailing to the recipient should be scheduled for this form | [optional] 
**StateEfileDate** | **DateTime?** | Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled. | [optional] 
**RecipientEdeliveryDate** | **DateTime?** | Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled. | [optional] 
**TinMatch** | **bool?** | Boolean indicating that TIN Matching should be scheduled for this form | [optional] 
**AddressVerification** | **bool?** | Boolean indicating that address verification should be scheduled for this form | [optional] 
**StateAndLocalWithholding** | [**StateAndLocalWithholding**](StateAndLocalWithholding.md) | State and local withholding information | [optional] 
**FederalEfileStatus** | [**FederalEfileStatusDetail**](FederalEfileStatusDetail.md) | Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)  When the form&#39;s most recent IRIS filing was rejected or accepted with errors, &#x60;errors&#x60; lists what the IRS reported. | [optional] [readonly] 
**StateEfileStatus** | [**List&lt;StateEfileStatusDetail&gt;**](StateEfileStatusDetail.md) | State e-file status.  Available values:  - unscheduled: Form has not been scheduled for state e-filing  - scheduled: Form is scheduled for state e-filing  - airlocked: Form is in process of being uploaded to the state  - sent: Form has been sent to the state  - rejected: Form was rejected by the state  - accepted: Form was accepted by the state  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlocked: Correction is in process of being uploaded to the state  - corrected_sent: Correction has been sent to the state  - corrected_rejected: Correction was rejected by the state  - corrected_accepted: Correction was accepted by the state | [optional] [readonly] 
**PostalMailStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Postal mail to recipient status.  Available values:  - unscheduled: Postal mail has not been scheduled  - pending: Postal mail is pending to be sent  - sent: Postal mail has been sent  - delivered: Postal mail has been delivered | [optional] [readonly] 
**TinMatchStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | TIN Match status.  Available values:  - none: TIN matching has not been performed  - pending: TIN matching request is pending  - matched: Name/TIN combination matches IRS records  - unknown: TIN is missing, invalid, or request contains errors  - rejected: Name/TIN combination does not match IRS records or TIN not currently issued | [optional] [readonly] 
**AddressVerificationStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Address verification status.  Available values:  - unknown: Address verification has not been checked  - pending: Address verification is in progress  - failed: Address verification failed  - incomplete: Address verification is incomplete  - unchanged: User declined address changes  - verified: Address has been verified and accepted | [optional] [readonly] 
**EDeliveryStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | EDelivery status.  Available values:  - unscheduled: E-delivery has not been scheduled  - scheduled: E-delivery is scheduled to be sent  - sent: E-delivery has been sent to recipient  - bounced: E-delivery bounced back (invalid email)  - refused: E-delivery was refused by recipient  - bad_verify: E-delivery failed verification  - accepted: E-delivery was accepted by recipient  - bad_verify_limit: E-delivery failed verification limit reached  - second_delivery: Second e-delivery attempt  - undelivered: E-delivery is undelivered (temporary state allowing resend) | [optional] [readonly] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Validation errors | [optional] [readonly] 
**CreatedAt** | **DateTime?** | Date time when the record was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | Date time when the record was last updated. | [optional] [readonly] 
**TinType** | **string** | Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number | [optional] 
**BusinessName** | **string** | Business name. Required when the recipient of the form is a business; should only be used for businesses. | [optional] 
**BusinessName2** | **string** | Business name line 2. Should only be used for businesses. | [optional] 
**FirstName** | **string** | First name. Required when the recipient of the form is an individual; should only be used for individuals. | [optional] 
**MiddleName** | **string** | Middle name. Should only be used for individuals. | [optional] 
**LastName** | **string** | Last name. Required when the recipient of the form is an individual; should only be used for individuals. | [optional] 
**SuffixName** | **string** | Suffix name. Should only be used for individuals. | [optional] 
**RecipientSecondName** | **string** | DEPRECATED: Use &#x60;businessName2&#x60; instead. | [optional] 
**AccountNumber** | **string** | Account number | [optional] 
**OfficeCode** | **string** | Office code | [optional] 
**NoTin** | **bool?** | No TIN indicator | [optional] 
**SecondTinNotice** | **bool?** | Second TIN notice | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

