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
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// Form1099K
    /// </summary>
    [DataContract(Name = "Form1099K")]
    public partial class Form1099K : IValidatableObject
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
        /// Initializes a new instance of the <see cref="Form1099K" /> class.
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
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="issuerId">issuerId.</param>
        /// <param name="issuerReferenceId">issuerReferenceId.</param>
        /// <param name="issuerTin">issuerTin.</param>
        /// <param name="taxYear">taxYear.</param>
        /// <param name="federalEfile">federalEfile.</param>
        /// <param name="federalEfileStatus">federalEfileStatus.</param>
        /// <param name="stateEfile">stateEfile.</param>
        /// <param name="stateEfileStatus">stateEfileStatus.</param>
        /// <param name="postalMail">postalMail.</param>
        /// <param name="postalMailStatus">postalMailStatus.</param>
        /// <param name="tinMatch">tinMatch.</param>
        /// <param name="tinMatchStatus">tinMatchStatus.</param>
        /// <param name="addressVerification">addressVerification.</param>
        /// <param name="addressVerificationStatus">addressVerificationStatus.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="email">email.</param>
        /// <param name="tinType">tinType.</param>
        /// <param name="tin">tin.</param>
        /// <param name="recipientName">recipientName.</param>
        /// <param name="recipientSecondName">recipientSecondName.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="foreignProvince">foreignProvince.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="validationErrors">validationErrors.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1099K(FilerTypeEnum? filerType = default(FilerTypeEnum?), PaymentTypeEnum? paymentType = default(PaymentTypeEnum?), string paymentSettlementEntityNamePhoneNumber = default(string), double grossAmountPaymentCard = default(double), double? cardNotPresentTransactions = default(double?), string merchantCategoryCode = default(string), double paymentTransactionNumber = default(double), double? federalIncomeTaxWithheld = default(double?), double? january = default(double?), double? february = default(double?), double? march = default(double?), double? april = default(double?), double? may = default(double?), double? june = default(double?), double? july = default(double?), double? august = default(double?), double? sept = default(double?), double? october = default(double?), double? november = default(double?), double? december = default(double?), string id = default(string), string type = default(string), int issuerId = default(int), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), Form1099StatusDetail federalEfileStatus = default(Form1099StatusDetail), bool stateEfile = default(bool), List<StateEfileStatusDetail> stateEfileStatus = default(List<StateEfileStatusDetail>), bool postalMail = default(bool), Form1099StatusDetail postalMailStatus = default(Form1099StatusDetail), bool tinMatch = default(bool), Form1099StatusDetail tinMatchStatus = default(Form1099StatusDetail), bool addressVerification = default(bool), Form1099StatusDetail addressVerificationStatus = default(Form1099StatusDetail), string referenceId = default(string), string email = default(string), string tinType = default(string), string tin = default(string), string recipientName = default(string), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string countryCode = default(string), List<ValidationError> validationErrors = default(List<ValidationError>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding))
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
            this.Id = id;
            this.Type = type;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.FederalEfile = federalEfile;
            this.FederalEfileStatus = federalEfileStatus;
            this.StateEfile = stateEfile;
            this.StateEfileStatus = stateEfileStatus;
            this.PostalMail = postalMail;
            this.PostalMailStatus = postalMailStatus;
            this.TinMatch = tinMatch;
            this.TinMatchStatus = tinMatchStatus;
            this.AddressVerification = addressVerification;
            this.AddressVerificationStatus = addressVerificationStatus;
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
            this.ValidationErrors = validationErrors;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IssuerId
        /// </summary>
        [DataMember(Name = "issuerId", EmitDefaultValue = false)]
        public int IssuerId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerReferenceId
        /// </summary>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerTin
        /// </summary>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Gets or Sets TaxYear
        /// </summary>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Gets or Sets FederalEfile
        /// </summary>
        [DataMember(Name = "federalEfile", EmitDefaultValue = true)]
        public bool FederalEfile { get; set; }

        /// <summary>
        /// Gets or Sets FederalEfileStatus
        /// </summary>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = false)]
        public Form1099StatusDetail FederalEfileStatus { get; set; }

        /// <summary>
        /// Gets or Sets StateEfile
        /// </summary>
        [DataMember(Name = "stateEfile", EmitDefaultValue = true)]
        public bool StateEfile { get; set; }

        /// <summary>
        /// Gets or Sets StateEfileStatus
        /// </summary>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public List<StateEfileStatusDetail> StateEfileStatus { get; set; }

        /// <summary>
        /// Gets or Sets PostalMail
        /// </summary>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Gets or Sets PostalMailStatus
        /// </summary>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail PostalMailStatus { get; set; }

        /// <summary>
        /// Gets or Sets TinMatch
        /// </summary>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// Gets or Sets TinMatchStatus
        /// </summary>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail TinMatchStatus { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerification
        /// </summary>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerificationStatus
        /// </summary>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail AddressVerificationStatus { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets TinType
        /// </summary>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// Gets or Sets Tin
        /// </summary>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Gets or Sets RecipientName
        /// </summary>
        [DataMember(Name = "recipientName", EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or Sets RecipientSecondName
        /// </summary>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = true)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets ForeignProvince
        /// </summary>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name = "validationErrors", EmitDefaultValue = true)]
        public List<ValidationError> ValidationErrors { get; set; }

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
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholding StateAndLocalWithholding { get; set; }

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
            yield break;
        }
    }
}
