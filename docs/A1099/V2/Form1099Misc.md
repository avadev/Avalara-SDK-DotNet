# Avalara.SDK.Model.A1099.V2.Form1099Misc
Form 1099-MISC: Miscellaneous Income    *At least one of the following amounts must be provided:*   Rents, Royalties, Other income, Fishing boat proceeds, Medical and health care payments,  Substitute payments in lieu of dividends or interest, Crop insurance proceeds, Gross proceeds paid to an attorney,  Fish purchased for resale, Section 409A deferrals, Excess golden parachute payments, Nonqualified deferred compensation,  Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rents** | **double?** | Rents | [optional] 
**Royalties** | **double?** | Royalties | [optional] 
**OtherIncome** | **double?** | Other income | [optional] 
**FederalIncomeTaxWithheld** | **double?** | Federal income tax withheld | [optional] 
**FishingBoatProceeds** | **double?** | Fishing boat proceeds | [optional] 
**MedicalAndHealthCarePayments** | **double?** | Medical and health care payments | [optional] 
**DirectSalesIndicator** | **bool?** | Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale | [optional] 
**SubstitutePayments** | **double?** | Substitute payments in lieu of dividends or interest | [optional] 
**CropInsuranceProceeds** | **double?** | Crop insurance proceeds | [optional] 
**GrossProceedsPaidToAttorney** | **double?** | Gross proceeds paid to an attorney | [optional] 
**FishPurchasedForResale** | **double?** | Fish purchased for resale | [optional] 
**Section409ADeferrals** | **double?** | Section 409A deferrals | [optional] 
**ExcessGoldenParachutePayments** | **double?** | (Legacy field) Excess golden parachute payments | [optional] 
**NonqualifiedDeferredCompensation** | **double?** | Nonqualified deferred compensation | [optional] 
**FatcaFilingRequirement** | **bool?** | FATCA filing requirement. | [optional] 
**Type** | **string** | Form type. | 
**Id** | **string** | Form ID. Unique identifier set when the record is created. | [optional] [readonly] 
**IssuerId** | **string** | Issuer ID - only required when creating forms | [optional] 
**IssuerReferenceId** | **string** | Issuer Reference ID - only required when creating forms via $bulk-upsert | [optional] 
**IssuerTin** | **string** | Issuer TIN - readonly | [optional] 
**TaxYear** | **int?** | Tax Year - only required when creating forms via $bulk-upsert | [optional] 
**ReferenceId** | **string** | Internal reference ID. Never shown to any agency or recipient. | [optional] 
**Tin** | **string** | Recipient&#39;s Federal Tax Identification Number (TIN). | [optional] 
**RecipientName** | **string** | Recipient name | 
**TinType** | **string** | Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number | [optional] 
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
**FederalEfileDate** | **DateTime?** | Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled. | [optional] 
**PostalMail** | **bool?** | Boolean indicating that postal mailing to the recipient should be scheduled for this form | [optional] 
**StateEfileDate** | **DateTime?** | Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled. | [optional] 
**RecipientEdeliveryDate** | **DateTime?** | Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled. | [optional] 
**TinMatch** | **bool?** | Boolean indicating that TIN Matching should be scheduled for this form | [optional] 
**NoTin** | **bool?** | No TIN indicator | [optional] 
**AddressVerification** | **bool?** | Boolean indicating that address verification should be scheduled for this form | [optional] 
**StateAndLocalWithholding** | [**StateAndLocalWithholding**](StateAndLocalWithholding.md) | State and local withholding information | [optional] 
**SecondTinNotice** | **bool?** | Second TIN notice | [optional] 
**FederalEfileStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states) | [optional] [readonly] 
**StateEfileStatus** | [**List&lt;StateEfileStatusDetail&gt;**](StateEfileStatusDetail.md) | State e-file status.  Available values:  - unscheduled: Form has not been scheduled for state e-filing  - scheduled: Form is scheduled for state e-filing  - airlocked: Form is in process of being uploaded to the state  - sent: Form has been sent to the state  - rejected: Form was rejected by the state  - accepted: Form was accepted by the state  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlocked: Correction is in process of being uploaded to the state  - corrected_sent: Correction has been sent to the state  - corrected_rejected: Correction was rejected by the state  - corrected_accepted: Correction was accepted by the state | [optional] [readonly] 
**PostalMailStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Postal mail to recipient status.  Available values:  - unscheduled: Postal mail has not been scheduled  - pending: Postal mail is pending to be sent  - sent: Postal mail has been sent  - delivered: Postal mail has been delivered | [optional] [readonly] 
**TinMatchStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | TIN Match status.  Available values:  - none: TIN matching has not been performed  - pending: TIN matching request is pending  - matched: Name/TIN combination matches IRS records  - unknown: TIN is missing, invalid, or request contains errors  - rejected: Name/TIN combination does not match IRS records or TIN not currently issued | [optional] [readonly] 
**AddressVerificationStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | Address verification status.  Available values:  - unknown: Address verification has not been checked  - pending: Address verification is in progress  - failed: Address verification failed  - incomplete: Address verification is incomplete  - unchanged: User declined address changes  - verified: Address has been verified and accepted | [optional] [readonly] 
**EDeliveryStatus** | [**Form1099StatusDetail**](Form1099StatusDetail.md) | EDelivery status.  Available values:  - unscheduled: E-delivery has not been scheduled  - scheduled: E-delivery is scheduled to be sent  - sent: E-delivery has been sent to recipient  - bounced: E-delivery bounced back (invalid email)  - refused: E-delivery was refused by recipient  - bad_verify: E-delivery failed verification  - accepted: E-delivery was accepted by recipient  - bad_verify_limit: E-delivery failed verification limit reached  - second_delivery: Second e-delivery attempt  - undelivered: E-delivery is undelivered (temporary state allowing resend) | [optional] [readonly] 
**ValidationErrors** | [**List&lt;ValidationError&gt;**](ValidationError.md) | Validation errors | [optional] [readonly] 
**CreatedAt** | **DateTime** | Date time when the record was created. | [optional] [readonly] 
**UpdatedAt** | **DateTime** | Date time when the record was last updated. | [optional] [readonly] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

