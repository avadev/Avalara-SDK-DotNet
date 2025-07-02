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
    /// Form1099DivRequest
    /// </summary>
    [DataContract(Name = "Form1099DivRequest")]
    public partial class Form1099DivRequest : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Form1099Nec for value: Form1099Nec
            /// </summary>
            [EnumMember(Value = "Form1099Nec")]
            Form1099Nec = 1,

            /// <summary>
            /// Enum Form1099Misc for value: Form1099Misc
            /// </summary>
            [EnumMember(Value = "Form1099Misc")]
            Form1099Misc = 2,

            /// <summary>
            /// Enum Form1099Div for value: Form1099Div
            /// </summary>
            [EnumMember(Value = "Form1099Div")]
            Form1099Div = 3,

            /// <summary>
            /// Enum Form1099R for value: Form1099R
            /// </summary>
            [EnumMember(Value = "Form1099R")]
            Form1099R = 4,

            /// <summary>
            /// Enum Form1099K for value: Form1099K
            /// </summary>
            [EnumMember(Value = "Form1099K")]
            Form1099K = 5,

            /// <summary>
            /// Enum Form1095B for value: Form1095B
            /// </summary>
            [EnumMember(Value = "Form1095B")]
            Form1095B = 6
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>Form1099Nec</example>
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
        /// Initializes a new instance of the <see cref="Form1099DivRequest" /> class.
        /// </summary>
        /// <param name="totalOrdinaryDividends">totalOrdinaryDividends.</param>
        /// <param name="qualifiedDividends">qualifiedDividends.</param>
        /// <param name="totalCapitalGainDistr">totalCapitalGainDistr.</param>
        /// <param name="unrecapSec1250Gain">unrecapSec1250Gain.</param>
        /// <param name="section1202Gain">section1202Gain.</param>
        /// <param name="collectiblesGain">collectiblesGain.</param>
        /// <param name="section897OrdinaryDividends">section897OrdinaryDividends.</param>
        /// <param name="section897CapitalGain">section897CapitalGain.</param>
        /// <param name="nondividendDistributions">nondividendDistributions.</param>
        /// <param name="federalIncomeTaxWithheld">federalIncomeTaxWithheld.</param>
        /// <param name="section199ADividends">section199ADividends.</param>
        /// <param name="investmentExpenses">investmentExpenses.</param>
        /// <param name="foreignTaxPaid">foreignTaxPaid.</param>
        /// <param name="foreignCountryOrUSPossession">foreignCountryOrUSPossession.</param>
        /// <param name="cashLiquidationDistributions">cashLiquidationDistributions.</param>
        /// <param name="noncashLiquidationDistributions">noncashLiquidationDistributions.</param>
        /// <param name="exemptInterestDividends">exemptInterestDividends.</param>
        /// <param name="specifiedPrivateActivityBondInterestDividends">specifiedPrivateActivityBondInterestDividends.</param>
        /// <param name="fatcaFilingRequirement">fatcaFilingRequirement.</param>
        /// <param name="issuerId">issuerId.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="recipientName">recipientName.</param>
        /// <param name="recipientTin">recipientTin.</param>
        /// <param name="tinType">tinType.</param>
        /// <param name="recipientSecondName">recipientSecondName.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="recipientEmail">recipientEmail.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="officeCode">officeCode.</param>
        /// <param name="recipientNonUsProvince">recipientNonUsProvince.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="federalEFile">federalEFile.</param>
        /// <param name="postalMail">postalMail.</param>
        /// <param name="stateEFile">stateEFile.</param>
        /// <param name="tinMatch">tinMatch.</param>
        /// <param name="addressVerification">addressVerification.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1099DivRequest(string totalOrdinaryDividends = default(string), string qualifiedDividends = default(string), string totalCapitalGainDistr = default(string), string unrecapSec1250Gain = default(string), string section1202Gain = default(string), string collectiblesGain = default(string), string section897OrdinaryDividends = default(string), string section897CapitalGain = default(string), string nondividendDistributions = default(string), string federalIncomeTaxWithheld = default(string), string section199ADividends = default(string), string investmentExpenses = default(string), string foreignTaxPaid = default(string), string foreignCountryOrUSPossession = default(string), string cashLiquidationDistributions = default(string), string noncashLiquidationDistributions = default(string), string exemptInterestDividends = default(string), string specifiedPrivateActivityBondInterestDividends = default(string), string fatcaFilingRequirement = default(string), string issuerId = default(string), string referenceId = default(string), string recipientName = default(string), string recipientTin = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string recipientEmail = default(string), string accountNumber = default(string), string officeCode = default(string), string recipientNonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
            this.TotalOrdinaryDividends = totalOrdinaryDividends;
            this.QualifiedDividends = qualifiedDividends;
            this.TotalCapitalGainDistr = totalCapitalGainDistr;
            this.UnrecapSec1250Gain = unrecapSec1250Gain;
            this.Section1202Gain = section1202Gain;
            this.CollectiblesGain = collectiblesGain;
            this.Section897OrdinaryDividends = section897OrdinaryDividends;
            this.Section897CapitalGain = section897CapitalGain;
            this.NondividendDistributions = nondividendDistributions;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.Section199ADividends = section199ADividends;
            this.InvestmentExpenses = investmentExpenses;
            this.ForeignTaxPaid = foreignTaxPaid;
            this.ForeignCountryOrUSPossession = foreignCountryOrUSPossession;
            this.CashLiquidationDistributions = cashLiquidationDistributions;
            this.NoncashLiquidationDistributions = noncashLiquidationDistributions;
            this.ExemptInterestDividends = exemptInterestDividends;
            this.SpecifiedPrivateActivityBondInterestDividends = specifiedPrivateActivityBondInterestDividends;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.IssuerId = issuerId;
            this.ReferenceId = referenceId;
            this.RecipientName = recipientName;
            this.RecipientTin = recipientTin;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.RecipientEmail = recipientEmail;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.RecipientNonUsProvince = recipientNonUsProvince;
            this.CountryCode = countryCode;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Gets or Sets TotalOrdinaryDividends
        /// </summary>
        [DataMember(Name = "totalOrdinaryDividends", EmitDefaultValue = false)]
        public string TotalOrdinaryDividends { get; set; }

        /// <summary>
        /// Gets or Sets QualifiedDividends
        /// </summary>
        [DataMember(Name = "qualifiedDividends", EmitDefaultValue = false)]
        public string QualifiedDividends { get; set; }

        /// <summary>
        /// Gets or Sets TotalCapitalGainDistr
        /// </summary>
        [DataMember(Name = "totalCapitalGainDistr", EmitDefaultValue = false)]
        public string TotalCapitalGainDistr { get; set; }

        /// <summary>
        /// Gets or Sets UnrecapSec1250Gain
        /// </summary>
        [DataMember(Name = "unrecapSec1250Gain", EmitDefaultValue = false)]
        public string UnrecapSec1250Gain { get; set; }

        /// <summary>
        /// Gets or Sets Section1202Gain
        /// </summary>
        [DataMember(Name = "section1202Gain", EmitDefaultValue = false)]
        public string Section1202Gain { get; set; }

        /// <summary>
        /// Gets or Sets CollectiblesGain
        /// </summary>
        [DataMember(Name = "collectiblesGain", EmitDefaultValue = false)]
        public string CollectiblesGain { get; set; }

        /// <summary>
        /// Gets or Sets Section897OrdinaryDividends
        /// </summary>
        [DataMember(Name = "section897OrdinaryDividends", EmitDefaultValue = false)]
        public string Section897OrdinaryDividends { get; set; }

        /// <summary>
        /// Gets or Sets Section897CapitalGain
        /// </summary>
        [DataMember(Name = "section897CapitalGain", EmitDefaultValue = false)]
        public string Section897CapitalGain { get; set; }

        /// <summary>
        /// Gets or Sets NondividendDistributions
        /// </summary>
        [DataMember(Name = "nondividendDistributions", EmitDefaultValue = false)]
        public string NondividendDistributions { get; set; }

        /// <summary>
        /// Gets or Sets FederalIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = false)]
        public string FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets Section199ADividends
        /// </summary>
        [DataMember(Name = "section199ADividends", EmitDefaultValue = false)]
        public string Section199ADividends { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentExpenses
        /// </summary>
        [DataMember(Name = "investmentExpenses", EmitDefaultValue = false)]
        public string InvestmentExpenses { get; set; }

        /// <summary>
        /// Gets or Sets ForeignTaxPaid
        /// </summary>
        [DataMember(Name = "foreignTaxPaid", EmitDefaultValue = false)]
        public string ForeignTaxPaid { get; set; }

        /// <summary>
        /// Gets or Sets ForeignCountryOrUSPossession
        /// </summary>
        [DataMember(Name = "foreignCountryOrUSPossession", EmitDefaultValue = false)]
        public string ForeignCountryOrUSPossession { get; set; }

        /// <summary>
        /// Gets or Sets CashLiquidationDistributions
        /// </summary>
        [DataMember(Name = "cashLiquidationDistributions", EmitDefaultValue = false)]
        public string CashLiquidationDistributions { get; set; }

        /// <summary>
        /// Gets or Sets NoncashLiquidationDistributions
        /// </summary>
        [DataMember(Name = "noncashLiquidationDistributions", EmitDefaultValue = false)]
        public string NoncashLiquidationDistributions { get; set; }

        /// <summary>
        /// Gets or Sets ExemptInterestDividends
        /// </summary>
        [DataMember(Name = "exemptInterestDividends", EmitDefaultValue = false)]
        public string ExemptInterestDividends { get; set; }

        /// <summary>
        /// Gets or Sets SpecifiedPrivateActivityBondInterestDividends
        /// </summary>
        [DataMember(Name = "specifiedPrivateActivityBondInterestDividends", EmitDefaultValue = false)]
        public string SpecifiedPrivateActivityBondInterestDividends { get; set; }

        /// <summary>
        /// Gets or Sets FatcaFilingRequirement
        /// </summary>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = false)]
        public string FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Gets or Sets IssuerId
        /// </summary>
        [DataMember(Name = "issuerId", EmitDefaultValue = true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets RecipientName
        /// </summary>
        [DataMember(Name = "recipientName", EmitDefaultValue = true)]
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
        [DataMember(Name = "address2", EmitDefaultValue = true)]
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
        /// Gets or Sets RecipientEmail
        /// </summary>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = true)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets OfficeCode
        /// </summary>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Gets or Sets RecipientNonUsProvince
        /// </summary>
        [DataMember(Name = "recipientNonUsProvince", EmitDefaultValue = true)]
        public string RecipientNonUsProvince { get; set; }

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
        /// Gets or Sets AddressVerification
        /// </summary>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Gets or Sets StateAndLocalWithholding
        /// </summary>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = false)]
        public StateAndLocalWithholdingRequest StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099DivRequest {\n");
            sb.Append("  TotalOrdinaryDividends: ").Append(TotalOrdinaryDividends).Append("\n");
            sb.Append("  QualifiedDividends: ").Append(QualifiedDividends).Append("\n");
            sb.Append("  TotalCapitalGainDistr: ").Append(TotalCapitalGainDistr).Append("\n");
            sb.Append("  UnrecapSec1250Gain: ").Append(UnrecapSec1250Gain).Append("\n");
            sb.Append("  Section1202Gain: ").Append(Section1202Gain).Append("\n");
            sb.Append("  CollectiblesGain: ").Append(CollectiblesGain).Append("\n");
            sb.Append("  Section897OrdinaryDividends: ").Append(Section897OrdinaryDividends).Append("\n");
            sb.Append("  Section897CapitalGain: ").Append(Section897CapitalGain).Append("\n");
            sb.Append("  NondividendDistributions: ").Append(NondividendDistributions).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  Section199ADividends: ").Append(Section199ADividends).Append("\n");
            sb.Append("  InvestmentExpenses: ").Append(InvestmentExpenses).Append("\n");
            sb.Append("  ForeignTaxPaid: ").Append(ForeignTaxPaid).Append("\n");
            sb.Append("  ForeignCountryOrUSPossession: ").Append(ForeignCountryOrUSPossession).Append("\n");
            sb.Append("  CashLiquidationDistributions: ").Append(CashLiquidationDistributions).Append("\n");
            sb.Append("  NoncashLiquidationDistributions: ").Append(NoncashLiquidationDistributions).Append("\n");
            sb.Append("  ExemptInterestDividends: ").Append(ExemptInterestDividends).Append("\n");
            sb.Append("  SpecifiedPrivateActivityBondInterestDividends: ").Append(SpecifiedPrivateActivityBondInterestDividends).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientTin: ").Append(RecipientTin).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  RecipientNonUsProvince: ").Append(RecipientNonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FederalEFile: ").Append(FederalEFile).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEFile: ").Append(StateEFile).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
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
