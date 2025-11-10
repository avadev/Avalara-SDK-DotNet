/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 & W-9 API Definition
 *
 * ## 🔐 Authentication  Generate a **license key** from: *[Avalara Portal](https://www.avalara.com/us/en/signin.html) → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// Form 1099-K: Payment Card and Third Party Network Transactions
    /// </summary>
    [DataContract(Name = "Form1099K")]
    public partial class Form1099K : IValidatableObject
    {
        /// <summary>
        /// Filer type for tax reporting purposes.  Available values:  - PSE: Payment Settlement Entity  - EPF: Electronic Payment Facilitator or other third party
        /// </summary>
        /// <value>Filer type for tax reporting purposes.  Available values:  - PSE: Payment Settlement Entity  - EPF: Electronic Payment Facilitator or other third party</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FilerTypeEnum
        {
            /// <summary>
            /// Enum PSE for value: PSE
            /// </summary>
            [EnumMember(Value = "PSE")]
            PSE = 1,

            /// <summary>
            /// Enum EPF for value: EPF
            /// </summary>
            [EnumMember(Value = "EPF")]
            EPF = 2
        }


        /// <summary>
        /// Filer type for tax reporting purposes.  Available values:  - PSE: Payment Settlement Entity  - EPF: Electronic Payment Facilitator or other third party
        /// </summary>
        /// <value>Filer type for tax reporting purposes.  Available values:  - PSE: Payment Settlement Entity  - EPF: Electronic Payment Facilitator or other third party</value>
        [DataMember(Name = "filerType", IsRequired = true, EmitDefaultValue = true)]
        public FilerTypeEnum FilerType { get; set; }
        /// <summary>
        /// Payment type for transaction classification.  Available values:  - PaymentCard: Payment card transactions  - ThirdPartyNetwork: Third party network transactions
        /// </summary>
        /// <value>Payment type for transaction classification.  Available values:  - PaymentCard: Payment card transactions  - ThirdPartyNetwork: Third party network transactions</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum PaymentCard for value: PaymentCard
            /// </summary>
            [EnumMember(Value = "PaymentCard")]
            PaymentCard = 1,

            /// <summary>
            /// Enum ThirdPartyNetwork for value: ThirdPartyNetwork
            /// </summary>
            [EnumMember(Value = "ThirdPartyNetwork")]
            ThirdPartyNetwork = 2
        }


        /// <summary>
        /// Payment type for transaction classification.  Available values:  - PaymentCard: Payment card transactions  - ThirdPartyNetwork: Third party network transactions
        /// </summary>
        /// <value>Payment type for transaction classification.  Available values:  - PaymentCard: Payment card transactions  - ThirdPartyNetwork: Third party network transactions</value>
        [DataMember(Name = "paymentType", IsRequired = true, EmitDefaultValue = true)]
        public PaymentTypeEnum PaymentType { get; set; }
        /// <summary>
        /// Form type.
        /// </summary>
        /// <value>Form type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum _1042S for value: 1042-S
            /// </summary>
            [EnumMember(Value = "1042-S")]
            _1042S = 1,

            /// <summary>
            /// Enum _1095B for value: 1095-B
            /// </summary>
            [EnumMember(Value = "1095-B")]
            _1095B = 2,

            /// <summary>
            /// Enum _1095C for value: 1095-C
            /// </summary>
            [EnumMember(Value = "1095-C")]
            _1095C = 3,

            /// <summary>
            /// Enum _1099DIV for value: 1099-DIV
            /// </summary>
            [EnumMember(Value = "1099-DIV")]
            _1099DIV = 4,

            /// <summary>
            /// Enum _1099INT for value: 1099-INT
            /// </summary>
            [EnumMember(Value = "1099-INT")]
            _1099INT = 5,

            /// <summary>
            /// Enum _1099K for value: 1099-K
            /// </summary>
            [EnumMember(Value = "1099-K")]
            _1099K = 6,

            /// <summary>
            /// Enum _1099MISC for value: 1099-MISC
            /// </summary>
            [EnumMember(Value = "1099-MISC")]
            _1099MISC = 7,

            /// <summary>
            /// Enum _1099NEC for value: 1099-NEC
            /// </summary>
            [EnumMember(Value = "1099-NEC")]
            _1099NEC = 8,

            /// <summary>
            /// Enum _1099R for value: 1099-R
            /// </summary>
            [EnumMember(Value = "1099-R")]
            _1099R = 9
        }


        /// <summary>
        /// Form type.
        /// </summary>
        /// <value>Form type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TinTypeEnum
        {
            /// <summary>
            /// Enum EIN for value: EIN
            /// </summary>
            [EnumMember(Value = "EIN")]
            EIN = 1,

            /// <summary>
            /// Enum SSN for value: SSN
            /// </summary>
            [EnumMember(Value = "SSN")]
            SSN = 2,

            /// <summary>
            /// Enum ITIN for value: ITIN
            /// </summary>
            [EnumMember(Value = "ITIN")]
            ITIN = 3,

            /// <summary>
            /// Enum ATIN for value: ATIN
            /// </summary>
            [EnumMember(Value = "ATIN")]
            ATIN = 4
        }


        /// <summary>
        /// Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number</value>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099K" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099K() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099K" /> class.
        /// </summary>
        /// <param name="filerType">Filer type for tax reporting purposes.  Available values:  - PSE: Payment Settlement Entity  - EPF: Electronic Payment Facilitator or other third party (required).</param>
        /// <param name="paymentType">Payment type for transaction classification.  Available values:  - PaymentCard: Payment card transactions  - ThirdPartyNetwork: Third party network transactions (required).</param>
        /// <param name="paymentSettlementEntityNamePhoneNumber">Payment settlement entity name and phone number, if different from Filer&#39;s.</param>
        /// <param name="grossAmountPaymentCard">Gross amount of payment card/third party network transactions. This value must equal the total of all monthly payment amounts (January through December). (required).</param>
        /// <param name="cardNotPresentTransactions">Card not present transactions.</param>
        /// <param name="merchantCategoryCode">Merchant category code (4 numbers).</param>
        /// <param name="paymentTransactionNumber">Number of payment transactions (required).</param>
        /// <param name="federalIncomeTaxWithheld">Federal income tax withheld.</param>
        /// <param name="january">January gross payments.</param>
        /// <param name="february">February gross payments.</param>
        /// <param name="march">March gross payments.</param>
        /// <param name="april">April gross payments.</param>
        /// <param name="may">May gross payments.</param>
        /// <param name="june">June gross payments.</param>
        /// <param name="july">July gross payments.</param>
        /// <param name="august">August gross payments.</param>
        /// <param name="september">September gross payments.</param>
        /// <param name="october">October gross payments.</param>
        /// <param name="november">November gross payments.</param>
        /// <param name="december">December gross payments.</param>
        /// <param name="type">Form type. (required).</param>
        /// <param name="issuerId">Issuer ID - only required when creating forms.</param>
        /// <param name="issuerReferenceId">Issuer Reference ID - only required when creating forms via $bulk-upsert.</param>
        /// <param name="issuerTin">Issuer TIN - readonly.</param>
        /// <param name="taxYear">Tax Year - only required when creating forms via $bulk-upsert.</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient..</param>
        /// <param name="tin">Recipient&#39;s Federal Tax Identification Number (TIN)..</param>
        /// <param name="recipientName">Recipient name (required).</param>
        /// <param name="tinType">Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address. (required).</param>
        /// <param name="address2">Address line 2..</param>
        /// <param name="city">City. (required).</param>
        /// <param name="state">Two-letter US state or Canadian province code (required for US/CA addresses)..</param>
        /// <param name="zip">ZIP/postal code..</param>
        /// <param name="email">Recipient&#39;s Contact email address..</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="officeCode">Office code.</param>
        /// <param name="nonUsProvince">Province or region for non-US/CA addresses..</param>
        /// <param name="countryCode">Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. (required).</param>
        /// <param name="federalEfileDate">Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEfileDate">Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="recipientEdeliveryDate">Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="noTin">No TIN indicator.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        /// <param name="secondTinNotice">Second TIN notice.</param>
        public Form1099K(FilerTypeEnum filerType = default(FilerTypeEnum), PaymentTypeEnum paymentType = default(PaymentTypeEnum), string paymentSettlementEntityNamePhoneNumber = default(string), double? grossAmountPaymentCard = default(double?), double? cardNotPresentTransactions = default(double?), string merchantCategoryCode = default(string), double? paymentTransactionNumber = default(double?), double? federalIncomeTaxWithheld = default(double?), double? january = default(double?), double? february = default(double?), double? march = default(double?), double? april = default(double?), double? may = default(double?), double? june = default(double?), double? july = default(double?), double? august = default(double?), double? september = default(double?), double? october = default(double?), double? november = default(double?), double? december = default(double?), TypeEnum type = default(TypeEnum), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int? taxYear = default(int?), string referenceId = default(string), string tin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), DateTime? federalEfileDate = default(DateTime?), bool? postalMail = default(bool?), DateTime? stateEfileDate = default(DateTime?), DateTime? recipientEdeliveryDate = default(DateTime?), bool? tinMatch = default(bool?), bool? noTin = default(bool?), bool? addressVerification = default(bool?), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding), bool? secondTinNotice = default(bool?))
        {
            this.FilerType = filerType;
            this.PaymentType = paymentType;
            // to ensure "grossAmountPaymentCard" is required (not null)
            if (grossAmountPaymentCard == null)
            {
                throw new ArgumentNullException("grossAmountPaymentCard is a required property for Form1099K and cannot be null");
            }
            this.GrossAmountPaymentCard = grossAmountPaymentCard;
            // to ensure "paymentTransactionNumber" is required (not null)
            if (paymentTransactionNumber == null)
            {
                throw new ArgumentNullException("paymentTransactionNumber is a required property for Form1099K and cannot be null");
            }
            this.PaymentTransactionNumber = paymentTransactionNumber;
            this.Type = type;
            // to ensure "recipientName" is required (not null)
            if (recipientName == null)
            {
                throw new ArgumentNullException("recipientName is a required property for Form1099K and cannot be null");
            }
            this.RecipientName = recipientName;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Form1099K and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Form1099K and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1099K and cannot be null");
            }
            this.CountryCode = countryCode;
            this.PaymentSettlementEntityNamePhoneNumber = paymentSettlementEntityNamePhoneNumber;
            this.CardNotPresentTransactions = cardNotPresentTransactions;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.January = january;
            this.February = february;
            this.March = march;
            this.April = april;
            this.May = may;
            this.June = june;
            this.July = july;
            this.August = august;
            this.September = september;
            this.October = october;
            this.November = november;
            this.December = december;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Tin = tin;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.Address2 = address2;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.NonUsProvince = nonUsProvince;
            this.FederalEfileDate = federalEfileDate;
            this.PostalMail = postalMail;
            this.StateEfileDate = stateEfileDate;
            this.RecipientEdeliveryDate = recipientEdeliveryDate;
            this.TinMatch = tinMatch;
            this.NoTin = noTin;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.SecondTinNotice = secondTinNotice;
        }

        /// <summary>
        /// Payment settlement entity name and phone number, if different from Filer&#39;s
        /// </summary>
        /// <value>Payment settlement entity name and phone number, if different from Filer&#39;s</value>
        [DataMember(Name = "paymentSettlementEntityNamePhoneNumber", EmitDefaultValue = true)]
        public string PaymentSettlementEntityNamePhoneNumber { get; set; }

        /// <summary>
        /// Gross amount of payment card/third party network transactions. This value must equal the total of all monthly payment amounts (January through December).
        /// </summary>
        /// <value>Gross amount of payment card/third party network transactions. This value must equal the total of all monthly payment amounts (January through December).</value>
        [DataMember(Name = "grossAmountPaymentCard", IsRequired = true, EmitDefaultValue = true)]
        public double? GrossAmountPaymentCard { get; set; }

        /// <summary>
        /// Card not present transactions
        /// </summary>
        /// <value>Card not present transactions</value>
        [DataMember(Name = "cardNotPresentTransactions", EmitDefaultValue = true)]
        public double? CardNotPresentTransactions { get; set; }

        /// <summary>
        /// Merchant category code (4 numbers)
        /// </summary>
        /// <value>Merchant category code (4 numbers)</value>
        [DataMember(Name = "merchantCategoryCode", EmitDefaultValue = true)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Number of payment transactions
        /// </summary>
        /// <value>Number of payment transactions</value>
        [DataMember(Name = "paymentTransactionNumber", IsRequired = true, EmitDefaultValue = true)]
        public double? PaymentTransactionNumber { get; set; }

        /// <summary>
        /// Federal income tax withheld
        /// </summary>
        /// <value>Federal income tax withheld</value>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// January gross payments
        /// </summary>
        /// <value>January gross payments</value>
        [DataMember(Name = "january", EmitDefaultValue = true)]
        public double? January { get; set; }

        /// <summary>
        /// February gross payments
        /// </summary>
        /// <value>February gross payments</value>
        [DataMember(Name = "february", EmitDefaultValue = true)]
        public double? February { get; set; }

        /// <summary>
        /// March gross payments
        /// </summary>
        /// <value>March gross payments</value>
        [DataMember(Name = "march", EmitDefaultValue = true)]
        public double? March { get; set; }

        /// <summary>
        /// April gross payments
        /// </summary>
        /// <value>April gross payments</value>
        [DataMember(Name = "april", EmitDefaultValue = true)]
        public double? April { get; set; }

        /// <summary>
        /// May gross payments
        /// </summary>
        /// <value>May gross payments</value>
        [DataMember(Name = "may", EmitDefaultValue = true)]
        public double? May { get; set; }

        /// <summary>
        /// June gross payments
        /// </summary>
        /// <value>June gross payments</value>
        [DataMember(Name = "june", EmitDefaultValue = true)]
        public double? June { get; set; }

        /// <summary>
        /// July gross payments
        /// </summary>
        /// <value>July gross payments</value>
        [DataMember(Name = "july", EmitDefaultValue = true)]
        public double? July { get; set; }

        /// <summary>
        /// August gross payments
        /// </summary>
        /// <value>August gross payments</value>
        [DataMember(Name = "august", EmitDefaultValue = true)]
        public double? August { get; set; }

        /// <summary>
        /// September gross payments
        /// </summary>
        /// <value>September gross payments</value>
        [DataMember(Name = "september", EmitDefaultValue = true)]
        public double? September { get; set; }

        /// <summary>
        /// October gross payments
        /// </summary>
        /// <value>October gross payments</value>
        [DataMember(Name = "october", EmitDefaultValue = true)]
        public double? October { get; set; }

        /// <summary>
        /// November gross payments
        /// </summary>
        /// <value>November gross payments</value>
        [DataMember(Name = "november", EmitDefaultValue = true)]
        public double? November { get; set; }

        /// <summary>
        /// December gross payments
        /// </summary>
        /// <value>December gross payments</value>
        [DataMember(Name = "december", EmitDefaultValue = true)]
        public double? December { get; set; }

        /// <summary>
        /// Form ID. Unique identifier set when the record is created.
        /// </summary>
        /// <value>Form ID. Unique identifier set when the record is created.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Issuer ID - only required when creating forms
        /// </summary>
        /// <value>Issuer ID - only required when creating forms</value>
        [DataMember(Name = "issuerId", EmitDefaultValue = true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Issuer Reference ID - only required when creating forms via $bulk-upsert
        /// </summary>
        /// <value>Issuer Reference ID - only required when creating forms via $bulk-upsert</value>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN - readonly
        /// </summary>
        /// <value>Issuer TIN - readonly</value>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax Year - only required when creating forms via $bulk-upsert
        /// </summary>
        /// <value>Tax Year - only required when creating forms via $bulk-upsert</value>
        [DataMember(Name = "taxYear", EmitDefaultValue = true)]
        public int? TaxYear { get; set; }

        /// <summary>
        /// Internal reference ID. Never shown to any agency or recipient.
        /// </summary>
        /// <value>Internal reference ID. Never shown to any agency or recipient.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Recipient&#39;s Federal Tax Identification Number (TIN).
        /// </summary>
        /// <value>Recipient&#39;s Federal Tax Identification Number (TIN).</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        /// <value>Recipient name</value>
        [DataMember(Name = "recipientName", IsRequired = true, EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Recipient second name
        /// </summary>
        /// <value>Recipient second name</value>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        /// <value>Address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Address line 2.
        /// </summary>
        /// <value>Address line 2.</value>
        [DataMember(Name = "address2", EmitDefaultValue = true)]
        public string Address2 { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Two-letter US state or Canadian province code (required for US/CA addresses).
        /// </summary>
        /// <value>Two-letter US state or Canadian province code (required for US/CA addresses).</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// ZIP/postal code.
        /// </summary>
        /// <value>ZIP/postal code.</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Recipient&#39;s Contact email address.
        /// </summary>
        /// <value>Recipient&#39;s Contact email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        /// <value>Account number</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Office code
        /// </summary>
        /// <value>Office code</value>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Province or region for non-US/CA addresses.
        /// </summary>
        /// <value>Province or region for non-US/CA addresses.</value>
        [DataMember(Name = "nonUsProvince", EmitDefaultValue = true)]
        public string NonUsProvince { get; set; }

        /// <summary>
        /// Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes.
        /// </summary>
        /// <value>Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.
        /// </summary>
        /// <value>Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.</value>
        [DataMember(Name = "federalEfileDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? FederalEfileDate { get; set; }

        /// <summary>
        /// Boolean indicating that postal mailing to the recipient should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that postal mailing to the recipient should be scheduled for this form</value>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool? PostalMail { get; set; }

        /// <summary>
        /// Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.
        /// </summary>
        /// <value>Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.</value>
        [DataMember(Name = "stateEfileDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StateEfileDate { get; set; }

        /// <summary>
        /// Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.
        /// </summary>
        /// <value>Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.</value>
        [DataMember(Name = "recipientEdeliveryDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RecipientEdeliveryDate { get; set; }

        /// <summary>
        /// Boolean indicating that TIN Matching should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that TIN Matching should be scheduled for this form</value>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool? TinMatch { get; set; }

        /// <summary>
        /// No TIN indicator
        /// </summary>
        /// <value>No TIN indicator</value>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool? NoTin { get; set; }

        /// <summary>
        /// Boolean indicating that address verification should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification should be scheduled for this form</value>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool? AddressVerification { get; set; }

        /// <summary>
        /// State and local withholding information
        /// </summary>
        /// <value>State and local withholding information</value>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholding StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Second TIN notice
        /// </summary>
        /// <value>Second TIN notice</value>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool? SecondTinNotice { get; set; }

        /// <summary>
        /// Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)
        /// </summary>
        /// <value>Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)</value>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail FederalEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as FederalEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFederalEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// State e-file status.  Available values:  - unscheduled: Form has not been scheduled for state e-filing  - scheduled: Form is scheduled for state e-filing  - airlocked: Form is in process of being uploaded to the state  - sent: Form has been sent to the state  - rejected: Form was rejected by the state  - accepted: Form was accepted by the state  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlocked: Correction is in process of being uploaded to the state  - corrected_sent: Correction has been sent to the state  - corrected_rejected: Correction was rejected by the state  - corrected_accepted: Correction was accepted by the state
        /// </summary>
        /// <value>State e-file status.  Available values:  - unscheduled: Form has not been scheduled for state e-filing  - scheduled: Form is scheduled for state e-filing  - airlocked: Form is in process of being uploaded to the state  - sent: Form has been sent to the state  - rejected: Form was rejected by the state  - accepted: Form was accepted by the state  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlocked: Correction is in process of being uploaded to the state  - corrected_sent: Correction has been sent to the state  - corrected_rejected: Correction was rejected by the state  - corrected_accepted: Correction was accepted by the state</value>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public List<StateEfileStatusDetail> StateEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as StateEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStateEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// Postal mail to recipient status.  Available values:  - unscheduled: Postal mail has not been scheduled  - pending: Postal mail is pending to be sent  - sent: Postal mail has been sent  - delivered: Postal mail has been delivered
        /// </summary>
        /// <value>Postal mail to recipient status.  Available values:  - unscheduled: Postal mail has not been scheduled  - pending: Postal mail is pending to be sent  - sent: Postal mail has been sent  - delivered: Postal mail has been delivered</value>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail PostalMailStatus { get; private set; }

        /// <summary>
        /// Returns false as PostalMailStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostalMailStatus()
        {
            return false;
        }
        /// <summary>
        /// TIN Match status.  Available values:  - none: TIN matching has not been performed  - pending: TIN matching request is pending  - matched: Name/TIN combination matches IRS records  - unknown: TIN is missing, invalid, or request contains errors  - rejected: Name/TIN combination does not match IRS records or TIN not currently issued
        /// </summary>
        /// <value>TIN Match status.  Available values:  - none: TIN matching has not been performed  - pending: TIN matching request is pending  - matched: Name/TIN combination matches IRS records  - unknown: TIN is missing, invalid, or request contains errors  - rejected: Name/TIN combination does not match IRS records or TIN not currently issued</value>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail TinMatchStatus { get; private set; }

        /// <summary>
        /// Returns false as TinMatchStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTinMatchStatus()
        {
            return false;
        }
        /// <summary>
        /// Address verification status.  Available values:  - unknown: Address verification has not been checked  - pending: Address verification is in progress  - failed: Address verification failed  - incomplete: Address verification is incomplete  - unchanged: User declined address changes  - verified: Address has been verified and accepted
        /// </summary>
        /// <value>Address verification status.  Available values:  - unknown: Address verification has not been checked  - pending: Address verification is in progress  - failed: Address verification failed  - incomplete: Address verification is incomplete  - unchanged: User declined address changes  - verified: Address has been verified and accepted</value>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail AddressVerificationStatus { get; private set; }

        /// <summary>
        /// Returns false as AddressVerificationStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressVerificationStatus()
        {
            return false;
        }
        /// <summary>
        /// EDelivery status.  Available values:  - unscheduled: E-delivery has not been scheduled  - scheduled: E-delivery is scheduled to be sent  - sent: E-delivery has been sent to recipient  - bounced: E-delivery bounced back (invalid email)  - refused: E-delivery was refused by recipient  - bad_verify: E-delivery failed verification  - accepted: E-delivery was accepted by recipient  - bad_verify_limit: E-delivery failed verification limit reached  - second_delivery: Second e-delivery attempt  - undelivered: E-delivery is undelivered (temporary state allowing resend)
        /// </summary>
        /// <value>EDelivery status.  Available values:  - unscheduled: E-delivery has not been scheduled  - scheduled: E-delivery is scheduled to be sent  - sent: E-delivery has been sent to recipient  - bounced: E-delivery bounced back (invalid email)  - refused: E-delivery was refused by recipient  - bad_verify: E-delivery failed verification  - accepted: E-delivery was accepted by recipient  - bad_verify_limit: E-delivery failed verification limit reached  - second_delivery: Second e-delivery attempt  - undelivered: E-delivery is undelivered (temporary state allowing resend)</value>
        [DataMember(Name = "eDeliveryStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail EDeliveryStatus { get; private set; }

        /// <summary>
        /// Returns false as EDeliveryStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEDeliveryStatus()
        {
            return false;
        }
        /// <summary>
        /// Validation errors
        /// </summary>
        /// <value>Validation errors</value>
        [DataMember(Name = "validationErrors", EmitDefaultValue = true)]
        public List<ValidationError> ValidationErrors { get; private set; }

        /// <summary>
        /// Returns false as ValidationErrors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationErrors()
        {
            return false;
        }
        /// <summary>
        /// Date time when the record was created.
        /// </summary>
        /// <value>Date time when the record was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Date time when the record was last updated.
        /// </summary>
        /// <value>Date time when the record was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099K {\n");
            sb.Append("  FilerType: ").Append(FilerType).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PaymentSettlementEntityNamePhoneNumber: ").Append(PaymentSettlementEntityNamePhoneNumber).Append("\n");
            sb.Append("  GrossAmountPaymentCard: ").Append(GrossAmountPaymentCard).Append("\n");
            sb.Append("  CardNotPresentTransactions: ").Append(CardNotPresentTransactions).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  PaymentTransactionNumber: ").Append(PaymentTransactionNumber).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  January: ").Append(January).Append("\n");
            sb.Append("  February: ").Append(February).Append("\n");
            sb.Append("  March: ").Append(March).Append("\n");
            sb.Append("  April: ").Append(April).Append("\n");
            sb.Append("  May: ").Append(May).Append("\n");
            sb.Append("  June: ").Append(June).Append("\n");
            sb.Append("  July: ").Append(July).Append("\n");
            sb.Append("  August: ").Append(August).Append("\n");
            sb.Append("  September: ").Append(September).Append("\n");
            sb.Append("  October: ").Append(October).Append("\n");
            sb.Append("  November: ").Append(November).Append("\n");
            sb.Append("  December: ").Append(December).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  NonUsProvince: ").Append(NonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FederalEfileDate: ").Append(FederalEfileDate).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEfileDate: ").Append(StateEfileDate).Append("\n");
            sb.Append("  RecipientEdeliveryDate: ").Append(RecipientEdeliveryDate).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  EDeliveryStatus: ").Append(EDeliveryStatus).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
