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
    /// Form1099KResponse
    /// </summary>
    [DataContract(Name = "Form1099KResponse")]
    public partial class Form1099KResponse : IValidatableObject
    {
        /// <summary>
        /// Defines FilerType
        /// </summary>
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
        /// Gets or Sets FilerType
        /// </summary>
        /// <example>PSE</example>
        [DataMember(Name = "filerType", EmitDefaultValue = false)]
        public FilerTypeEnum? FilerType { get; set; }
        /// <summary>
        /// Defines PaymentType
        /// </summary>
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
        /// Gets or Sets PaymentType
        /// </summary>
        /// <example>MerchantPaymentCard</example>
        [DataMember(Name = "paymentType", EmitDefaultValue = false)]
        public PaymentTypeEnum? PaymentType { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum _1099NEC for value: 1099-NEC
            /// </summary>
            [EnumMember(Value = "1099-NEC")]
            _1099NEC = 1,

            /// <summary>
            /// Enum _1099MISC for value: 1099-MISC
            /// </summary>
            [EnumMember(Value = "1099-MISC")]
            _1099MISC = 2,

            /// <summary>
            /// Enum _1099DIV for value: 1099-DIV
            /// </summary>
            [EnumMember(Value = "1099-DIV")]
            _1099DIV = 3,

            /// <summary>
            /// Enum _1099R for value: 1099-R
            /// </summary>
            [EnumMember(Value = "1099-R")]
            _1099R = 4,

            /// <summary>
            /// Enum _1099K for value: 1099-K
            /// </summary>
            [EnumMember(Value = "1099-K")]
            _1099K = 5,

            /// <summary>
            /// Enum _1095B for value: 1095-B
            /// </summary>
            [EnumMember(Value = "1095-B")]
            _1095B = 6,

            /// <summary>
            /// Enum _1042S for value: 1042-S
            /// </summary>
            [EnumMember(Value = "1042-S")]
            _1042S = 7,

            /// <summary>
            /// Enum _1095C for value: 1095-C
            /// </summary>
            [EnumMember(Value = "1095-C")]
            _1095C = 8,

            /// <summary>
            /// Enum _1099INT for value: 1099-INT
            /// </summary>
            [EnumMember(Value = "1099-INT")]
            _1099INT = 9
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>1099-NEC</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Defines TinType
        /// </summary>
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
        /// Gets or Sets TinType
        /// </summary>
        /// <example>EIN</example>
        [DataMember(Name = "tinType", EmitDefaultValue = false)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099KResponse" /> class.
        /// </summary>
        /// <param name="filerType">filerType.</param>
        /// <param name="paymentType">paymentType.</param>
        /// <param name="paymentSettlementEntityNamePhoneNumber">paymentSettlementEntityNamePhoneNumber.</param>
        /// <param name="grossAmountPaymentCard">grossAmountPaymentCard.</param>
        /// <param name="cardNotPresentTransactions">cardNotPresentTransactions.</param>
        /// <param name="merchantCategoryCode">merchantCategoryCode.</param>
        /// <param name="paymentTransactionNumber">paymentTransactionNumber.</param>
        /// <param name="federalIncomeTaxWithheld">federalIncomeTaxWithheld.</param>
        /// <param name="january">january.</param>
        /// <param name="february">february.</param>
        /// <param name="march">march.</param>
        /// <param name="april">april.</param>
        /// <param name="may">may.</param>
        /// <param name="june">june.</param>
        /// <param name="july">july.</param>
        /// <param name="august">august.</param>
        /// <param name="sept">sept.</param>
        /// <param name="october">october.</param>
        /// <param name="november">november.</param>
        /// <param name="december">december.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        /// <param name="tinType">tinType.</param>
        /// <param name="id">id.</param>
        /// <param name="issuerId">issuerId.</param>
        /// <param name="issuerReferenceId">issuerReferenceId.</param>
        /// <param name="issuerTin">issuerTin.</param>
        /// <param name="taxYear">taxYear.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="recipientName">recipientName.</param>
        /// <param name="recipientTin">recipientTin.</param>
        /// <param name="recipientSecondName">recipientSecondName.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="email">email.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="officeCode">officeCode.</param>
        /// <param name="nonUsProvince">nonUsProvince.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="federalEFile">federalEFile.</param>
        /// <param name="postalMail">postalMail.</param>
        /// <param name="stateEFile">stateEFile.</param>
        /// <param name="tinMatch">tinMatch.</param>
        /// <param name="noTin">noTin.</param>
        /// <param name="secondTinNotice">secondTinNotice.</param>
        /// <param name="addressVerification">addressVerification.</param>
        /// <param name="federalEfileStatus">federalEfileStatus.</param>
        /// <param name="eDeliveryStatus">eDeliveryStatus.</param>
        /// <param name="stateEfileStatus">stateEfileStatus.</param>
        /// <param name="postalMailStatus">postalMailStatus.</param>
        /// <param name="tinMatchStatus">tinMatchStatus.</param>
        /// <param name="addressVerificationStatus">addressVerificationStatus.</param>
        /// <param name="validationErrors">validationErrors.</param>
        public Form1099KResponse(FilerTypeEnum? filerType = default(FilerTypeEnum?), PaymentTypeEnum? paymentType = default(PaymentTypeEnum?), string paymentSettlementEntityNamePhoneNumber = default(string), double grossAmountPaymentCard = default(double), double? cardNotPresentTransactions = default(double?), string merchantCategoryCode = default(string), double paymentTransactionNumber = default(double), double? federalIncomeTaxWithheld = default(double?), double? january = default(double?), double? february = default(double?), double? march = default(double?), double? april = default(double?), double? may = default(double?), double? june = default(double?), double? july = default(double?), double? august = default(double?), double? sept = default(double?), double? october = default(double?), double? november = default(double?), double? december = default(double?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), StateAndLocalWithholdingResponse stateAndLocalWithholding = default(StateAndLocalWithholdingResponse), TinTypeEnum? tinType = default(TinTypeEnum?), string id = default(string), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), string referenceId = default(string), string recipientName = default(string), string recipientTin = default(string), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool noTin = default(bool), bool secondTinNotice = default(bool), bool addressVerification = default(bool), StatusDetail federalEfileStatus = default(StatusDetail), StatusDetail eDeliveryStatus = default(StatusDetail), List<StateEfileStatusDetailResponse> stateEfileStatus = default(List<StateEfileStatusDetailResponse>), StatusDetail postalMailStatus = default(StatusDetail), StatusDetail tinMatchStatus = default(StatusDetail), StatusDetail addressVerificationStatus = default(StatusDetail), List<ValidationErrorResponse> validationErrors = default(List<ValidationErrorResponse>))
        {
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
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.TinType = tinType;
            this.Id = id;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.RecipientName = recipientName;
            this.RecipientTin = recipientTin;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.NonUsProvince = nonUsProvince;
            this.CountryCode = countryCode;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.NoTin = noTin;
            this.SecondTinNotice = secondTinNotice;
            this.AddressVerification = addressVerification;
            this.FederalEfileStatus = federalEfileStatus;
            this.EDeliveryStatus = eDeliveryStatus;
            this.StateEfileStatus = stateEfileStatus;
            this.PostalMailStatus = postalMailStatus;
            this.TinMatchStatus = tinMatchStatus;
            this.AddressVerificationStatus = addressVerificationStatus;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Gets or Sets PaymentSettlementEntityNamePhoneNumber
        /// </summary>
        [DataMember(Name = "paymentSettlementEntityNamePhoneNumber", EmitDefaultValue = true)]
        public string PaymentSettlementEntityNamePhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets GrossAmountPaymentCard
        /// </summary>
        [DataMember(Name = "grossAmountPaymentCard", EmitDefaultValue = false)]
        public double GrossAmountPaymentCard { get; set; }

        /// <summary>
        /// Gets or Sets CardNotPresentTransactions
        /// </summary>
        [DataMember(Name = "cardNotPresentTransactions", EmitDefaultValue = true)]
        public double? CardNotPresentTransactions { get; set; }

        /// <summary>
        /// Gets or Sets MerchantCategoryCode
        /// </summary>
        [DataMember(Name = "merchantCategoryCode", EmitDefaultValue = true)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTransactionNumber
        /// </summary>
        [DataMember(Name = "paymentTransactionNumber", EmitDefaultValue = false)]
        public double PaymentTransactionNumber { get; set; }

        /// <summary>
        /// Gets or Sets FederalIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets January
        /// </summary>
        [DataMember(Name = "january", EmitDefaultValue = true)]
        public double? January { get; set; }

        /// <summary>
        /// Gets or Sets February
        /// </summary>
        [DataMember(Name = "february", EmitDefaultValue = true)]
        public double? February { get; set; }

        /// <summary>
        /// Gets or Sets March
        /// </summary>
        [DataMember(Name = "march", EmitDefaultValue = true)]
        public double? March { get; set; }

        /// <summary>
        /// Gets or Sets April
        /// </summary>
        [DataMember(Name = "april", EmitDefaultValue = true)]
        public double? April { get; set; }

        /// <summary>
        /// Gets or Sets May
        /// </summary>
        [DataMember(Name = "may", EmitDefaultValue = true)]
        public double? May { get; set; }

        /// <summary>
        /// Gets or Sets June
        /// </summary>
        [DataMember(Name = "june", EmitDefaultValue = true)]
        public double? June { get; set; }

        /// <summary>
        /// Gets or Sets July
        /// </summary>
        [DataMember(Name = "july", EmitDefaultValue = true)]
        public double? July { get; set; }

        /// <summary>
        /// Gets or Sets August
        /// </summary>
        [DataMember(Name = "august", EmitDefaultValue = true)]
        public double? August { get; set; }

        /// <summary>
        /// Gets or Sets Sept
        /// </summary>
        [DataMember(Name = "sept", EmitDefaultValue = true)]
        public double? Sept { get; set; }

        /// <summary>
        /// Gets or Sets October
        /// </summary>
        [DataMember(Name = "october", EmitDefaultValue = true)]
        public double? October { get; set; }

        /// <summary>
        /// Gets or Sets November
        /// </summary>
        [DataMember(Name = "november", EmitDefaultValue = true)]
        public double? November { get; set; }

        /// <summary>
        /// Gets or Sets December
        /// </summary>
        [DataMember(Name = "december", EmitDefaultValue = true)]
        public double? December { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets StateAndLocalWithholding
        /// </summary>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = false)]
        public StateAndLocalWithholdingResponse StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IssuerId
        /// </summary>
        [DataMember(Name = "issuerId", EmitDefaultValue = false)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerReferenceId
        /// </summary>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = false)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerTin
        /// </summary>
        [DataMember(Name = "issuerTin", EmitDefaultValue = false)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Gets or Sets TaxYear
        /// </summary>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets RecipientName
        /// </summary>
        [DataMember(Name = "recipientName", EmitDefaultValue = false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or Sets RecipientTin
        /// </summary>
        [DataMember(Name = "recipientTin", EmitDefaultValue = false)]
        public string RecipientTin { get; set; }

        /// <summary>
        /// Gets or Sets RecipientSecondName
        /// </summary>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = false)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets OfficeCode
        /// </summary>
        [DataMember(Name = "officeCode", EmitDefaultValue = false)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Gets or Sets NonUsProvince
        /// </summary>
        [DataMember(Name = "nonUsProvince", EmitDefaultValue = false)]
        public string NonUsProvince { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets FederalEFile
        /// </summary>
        [DataMember(Name = "federalEFile", EmitDefaultValue = true)]
        public bool FederalEFile { get; set; }

        /// <summary>
        /// Gets or Sets PostalMail
        /// </summary>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Gets or Sets StateEFile
        /// </summary>
        [DataMember(Name = "stateEFile", EmitDefaultValue = true)]
        public bool StateEFile { get; set; }

        /// <summary>
        /// Gets or Sets TinMatch
        /// </summary>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// Gets or Sets NoTin
        /// </summary>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool NoTin { get; set; }

        /// <summary>
        /// Gets or Sets SecondTinNotice
        /// </summary>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool SecondTinNotice { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerification
        /// </summary>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Gets or Sets FederalEfileStatus
        /// </summary>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = true)]
        public StatusDetail FederalEfileStatus { get; set; }

        /// <summary>
        /// Gets or Sets EDeliveryStatus
        /// </summary>
        [DataMember(Name = "eDeliveryStatus", EmitDefaultValue = true)]
        public StatusDetail EDeliveryStatus { get; set; }

        /// <summary>
        /// Gets or Sets StateEfileStatus
        /// </summary>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public List<StateEfileStatusDetailResponse> StateEfileStatus { get; set; }

        /// <summary>
        /// Gets or Sets PostalMailStatus
        /// </summary>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public StatusDetail PostalMailStatus { get; set; }

        /// <summary>
        /// Gets or Sets TinMatchStatus
        /// </summary>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public StatusDetail TinMatchStatus { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerificationStatus
        /// </summary>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public StatusDetail AddressVerificationStatus { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name = "validationErrors", EmitDefaultValue = true)]
        public List<ValidationErrorResponse> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099KResponse {\n");
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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientTin: ").Append(RecipientTin).Append("\n");
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
            sb.Append("  FederalEFile: ").Append(FederalEFile).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEFile: ").Append(StateEFile).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  EDeliveryStatus: ").Append(EDeliveryStatus).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
