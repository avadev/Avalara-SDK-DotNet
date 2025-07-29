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
    /// Form1099KListItemResponse
    /// </summary>
    [DataContract(Name = "Form1099KListItemResponse")]
    public partial class Form1099KListItemResponse : IValidatableObject
    {
        /// <summary>
        /// Filer type (PSE or EPF)
        /// </summary>
        /// <value>Filer type (PSE or EPF)</value>
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
            EPF = 2,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 3
        }


        /// <summary>
        /// Filer type (PSE or EPF)
        /// </summary>
        /// <value>Filer type (PSE or EPF)</value>
        /// <example>0</example>
        [DataMember(Name = "filerType", EmitDefaultValue = false)]
        public FilerTypeEnum? FilerType { get; set; }
        /// <summary>
        /// Payment type (payment card or third party network)
        /// </summary>
        /// <value>Payment type (payment card or third party network)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum MerchantPaymentCard for value: MerchantPaymentCard
            /// </summary>
            [EnumMember(Value = "MerchantPaymentCard")]
            MerchantPaymentCard = 1,

            /// <summary>
            /// Enum ThirdPartyNetwork for value: ThirdPartyNetwork
            /// </summary>
            [EnumMember(Value = "ThirdPartyNetwork")]
            ThirdPartyNetwork = 2
        }


        /// <summary>
        /// Payment type (payment card or third party network)
        /// </summary>
        /// <value>Payment type (payment card or third party network)</value>
        /// <example>0</example>
        [DataMember(Name = "paymentType", EmitDefaultValue = false)]
        public PaymentTypeEnum? PaymentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099KListItemResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099KListItemResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099KListItemResponse" /> class.
        /// </summary>
        /// <param name="filerType">Filer type (PSE or EPF).</param>
        /// <param name="paymentType">Payment type (payment card or third party network).</param>
        /// <param name="paymentSettlementEntityNamePhoneNumber">Payment settlement entity name and phone number.</param>
        /// <param name="grossAmountPaymentCard">Gross amount of payment card/third party network transactions.</param>
        /// <param name="cardNotPresentTransactions">Card not present transactions.</param>
        /// <param name="merchantCategoryCode">Merchant category code.</param>
        /// <param name="paymentTransactionNumber">Number of payment transactions.</param>
        /// <param name="federalIncomeTaxWithheld">Federal income tax withheld.</param>
        /// <param name="january">January gross payments.</param>
        /// <param name="february">February gross payments.</param>
        /// <param name="march">March gross payments.</param>
        /// <param name="april">April gross payments.</param>
        /// <param name="may">May gross payments.</param>
        /// <param name="june">June gross payments.</param>
        /// <param name="july">July gross payments.</param>
        /// <param name="august">August gross payments.</param>
        /// <param name="sept">September gross payments.</param>
        /// <param name="october">October gross payments.</param>
        /// <param name="november">November gross payments.</param>
        /// <param name="december">December gross payments.</param>
        /// <param name="type">Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC (required).</param>
        /// <param name="issuerId">Issuer ID (required).</param>
        /// <param name="issuerReferenceId">Issuer Reference ID.</param>
        /// <param name="issuerTin">Issuer TIN.</param>
        /// <param name="taxYear">Tax year.</param>
        /// <param name="federalEfile">Boolean indicating that federal e-filing has been scheduled for this form (required).</param>
        /// <param name="stateEfile">Boolean indicating that state e-filing has been scheduled for this form (required).</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient has been scheduled for this form (required).</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching has been scheduled for this form (required).</param>
        /// <param name="addressVerification">Boolean indicating that address verification has been scheduled for this form (required).</param>
        /// <param name="referenceId">Reference ID.</param>
        /// <param name="email">Recipient email address.</param>
        /// <param name="tinType">Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN.</param>
        /// <param name="tin">Recipient Tax ID Number.</param>
        /// <param name="recipientName">Recipient name.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address.</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">US state.</param>
        /// <param name="zip">Zip/postal code.</param>
        /// <param name="foreignProvince">Foreign province.</param>
        /// <param name="countryCode">Country code, as defined at https://www.irs.gov/e-file-providers/country-codes.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1099KListItemResponse(FilerTypeEnum? filerType = default(FilerTypeEnum?), PaymentTypeEnum? paymentType = default(PaymentTypeEnum?), string paymentSettlementEntityNamePhoneNumber = default(string), double grossAmountPaymentCard = default(double), double? cardNotPresentTransactions = default(double?), string merchantCategoryCode = default(string), double paymentTransactionNumber = default(double), double? federalIncomeTaxWithheld = default(double?), double? january = default(double?), double? february = default(double?), double? march = default(double?), double? april = default(double?), double? may = default(double?), double? june = default(double?), double? july = default(double?), double? august = default(double?), double? sept = default(double?), double? october = default(double?), double? november = default(double?), double? december = default(double?), string type = default(string), int issuerId = default(int), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), bool stateEfile = default(bool), bool postalMail = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), string referenceId = default(string), string email = default(string), string tinType = default(string), string tin = default(string), string recipientName = default(string), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string countryCode = default(string), StateAndLocalWithholdingResponse stateAndLocalWithholding = default(StateAndLocalWithholdingResponse))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Form1099KListItemResponse and cannot be null");
            }
            this.Type = type;
            this.IssuerId = issuerId;
            this.FederalEfile = federalEfile;
            this.StateEfile = stateEfile;
            this.PostalMail = postalMail;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.FilerType = filerType;
            this.PaymentType = paymentType;
            this.PaymentSettlementEntityNamePhoneNumber = paymentSettlementEntityNamePhoneNumber;
            this.GrossAmountPaymentCard = grossAmountPaymentCard;
            this.CardNotPresentTransactions = cardNotPresentTransactions;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.PaymentTransactionNumber = paymentTransactionNumber;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.January = january;
            this.February = february;
            this.March = march;
            this.April = april;
            this.May = may;
            this.June = june;
            this.July = july;
            this.August = august;
            this.Sept = sept;
            this.October = october;
            this.November = november;
            this.December = december;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Email = email;
            this.TinType = tinType;
            this.Tin = tin;
            this.RecipientName = recipientName;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.ForeignProvince = foreignProvince;
            this.CountryCode = countryCode;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Payment settlement entity name and phone number
        /// </summary>
        /// <value>Payment settlement entity name and phone number</value>
        [DataMember(Name = "paymentSettlementEntityNamePhoneNumber", EmitDefaultValue = true)]
        public string PaymentSettlementEntityNamePhoneNumber { get; set; }

        /// <summary>
        /// Gross amount of payment card/third party network transactions
        /// </summary>
        /// <value>Gross amount of payment card/third party network transactions</value>
        /// <example>0</example>
        [DataMember(Name = "grossAmountPaymentCard", EmitDefaultValue = false)]
        public double GrossAmountPaymentCard { get; set; }

        /// <summary>
        /// Card not present transactions
        /// </summary>
        /// <value>Card not present transactions</value>
        [DataMember(Name = "cardNotPresentTransactions", EmitDefaultValue = true)]
        public double? CardNotPresentTransactions { get; set; }

        /// <summary>
        /// Merchant category code
        /// </summary>
        /// <value>Merchant category code</value>
        [DataMember(Name = "merchantCategoryCode", EmitDefaultValue = true)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Number of payment transactions
        /// </summary>
        /// <value>Number of payment transactions</value>
        /// <example>0</example>
        [DataMember(Name = "paymentTransactionNumber", EmitDefaultValue = false)]
        public double PaymentTransactionNumber { get; set; }

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
        [DataMember(Name = "sept", EmitDefaultValue = true)]
        public double? Sept { get; set; }

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
        /// ID of the form
        /// </summary>
        /// <value>ID of the form</value>
        /// <example>123456789</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
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
        /// Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC
        /// </summary>
        /// <value>Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC</value>
        /// <example>1099-NEC</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Issuer ID
        /// </summary>
        /// <value>Issuer ID</value>
        /// <example>987654321</example>
        [DataMember(Name = "issuerId", IsRequired = true, EmitDefaultValue = true)]
        public int IssuerId { get; set; }

        /// <summary>
        /// Issuer Reference ID
        /// </summary>
        /// <value>Issuer Reference ID</value>
        /// <example>R-3898734</example>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN
        /// </summary>
        /// <value>Issuer TIN</value>
        /// <example>59-387274</example>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax year
        /// </summary>
        /// <value>Tax year</value>
        /// <example>2024</example>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Boolean indicating that federal e-filing has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that federal e-filing has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "federalEfile", IsRequired = true, EmitDefaultValue = true)]
        public bool FederalEfile { get; set; }

        /// <summary>
        /// Federal e-file status
        /// </summary>
        /// <value>Federal e-file status</value>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = false)]
        public Form1099StatusDetailResponse FederalEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as FederalEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFederalEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that state e-filing has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that state e-filing has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "stateEfile", IsRequired = true, EmitDefaultValue = true)]
        public bool StateEfile { get; set; }

        /// <summary>
        /// State e-file status
        /// </summary>
        /// <value>State e-file status</value>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public List<StateEfileStatusDetailResponse> StateEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as StateEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStateEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that postal mailing to the recipient has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that postal mailing to the recipient has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "postalMail", IsRequired = true, EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Postal mail to recipient status
        /// </summary>
        /// <value>Postal mail to recipient status</value>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public Form1099StatusDetailResponse PostalMailStatus { get; private set; }

        /// <summary>
        /// Returns false as PostalMailStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostalMailStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that TIN Matching has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that TIN Matching has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "tinMatch", IsRequired = true, EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// TIN Match status
        /// </summary>
        /// <value>TIN Match status</value>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public Form1099StatusDetailResponse TinMatchStatus { get; private set; }

        /// <summary>
        /// Returns false as TinMatchStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTinMatchStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that address verification has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "addressVerification", IsRequired = true, EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Address verification status
        /// </summary>
        /// <value>Address verification status</value>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public Form1099StatusDetailResponse AddressVerificationStatus { get; private set; }

        /// <summary>
        /// Returns false as AddressVerificationStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressVerificationStatus()
        {
            return false;
        }
        /// <summary>
        /// Reference ID
        /// </summary>
        /// <value>Reference ID</value>
        /// <example>1891810-9819891</example>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        /// <value>Recipient email address</value>
        /// <example>roadrunner@acmecorp.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN
        /// </summary>
        /// <value>Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN</value>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// Recipient Tax ID Number
        /// </summary>
        /// <value>Recipient Tax ID Number</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        /// <value>Recipient name</value>
        [DataMember(Name = "recipientName", EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Recipient second name
        /// </summary>
        /// <value>Recipient second name</value>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        /// <example>1234 Meep Meep Blvd</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <value>Address line 2</value>
        [DataMember(Name = "address2", EmitDefaultValue = true)]
        public string Address2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /// <example>Tucson</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// US state
        /// </summary>
        /// <value>US state</value>
        /// <example>AZ</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code
        /// </summary>
        /// <value>Zip/postal code</value>
        /// <example>35004</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Foreign province
        /// </summary>
        /// <value>Foreign province</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Country code, as defined at https://www.irs.gov/e-file-providers/country-codes
        /// </summary>
        /// <value>Country code, as defined at https://www.irs.gov/e-file-providers/country-codes</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Validation errors
        /// </summary>
        /// <value>Validation errors</value>
        [DataMember(Name = "validationErrors", EmitDefaultValue = true)]
        public List<ValidationErrorResponse> ValidationErrors { get; private set; }

        /// <summary>
        /// Returns false as ValidationErrors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationErrors()
        {
            return false;
        }
        /// <summary>
        /// Creation time
        /// </summary>
        /// <value>Creation time</value>
        /// <example>2025-07-29T15:37:04.970443200Z</example>
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
        /// Update time
        /// </summary>
        /// <value>Update time</value>
        /// <example>2025-07-29T15:37:04.970443700Z</example>
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
        /// Gets or Sets StateAndLocalWithholding
        /// </summary>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholdingResponse StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099KListItemResponse {\n");
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
            sb.Append("  Sept: ").Append(Sept).Append("\n");
            sb.Append("  October: ").Append(October).Append("\n");
            sb.Append("  November: ").Append(November).Append("\n");
            sb.Append("  December: ").Append(December).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  FederalEfile: ").Append(FederalEfile).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  StateEfile: ").Append(StateEfile).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
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
            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }
}
