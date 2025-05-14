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
    /// Form1099Misc
    /// </summary>
    [DataContract(Name = "Form1099Misc")]
    public partial class Form1099Misc : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099Misc" /> class.
        /// </summary>
        /// <param name="rents">rents.</param>
        /// <param name="royalties">royalties.</param>
        /// <param name="otherIncome">otherIncome.</param>
        /// <param name="fedIncomeTaxWithheld">fedIncomeTaxWithheld.</param>
        /// <param name="fishingBoatProceeds">fishingBoatProceeds.</param>
        /// <param name="medicalAndHealthCare">medicalAndHealthCare.</param>
        /// <param name="nonemployeeCompensation">nonemployeeCompensation.</param>
        /// <param name="substitutePayments">substitutePayments.</param>
        /// <param name="directSalesIndicator">directSalesIndicator.</param>
        /// <param name="cropInsuranceProceeds">cropInsuranceProceeds.</param>
        /// <param name="excessGoldenParachute">excessGoldenParachute.</param>
        /// <param name="grossAmountPaidAttorney">grossAmountPaidAttorney.</param>
        /// <param name="section409ADeferrals">section409ADeferrals.</param>
        /// <param name="section409AIncome">section409AIncome.</param>
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
        /// <param name="typeOfTin">typeOfTin.</param>
        /// <param name="tin">tin.</param>
        /// <param name="firstPayeeName">firstPayeeName.</param>
        /// <param name="secondPayeeName">secondPayeeName.</param>
        /// <param name="address">address.</param>
        /// <param name="addressRecipientSecond">addressRecipientSecond.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="foreignProvince">foreignProvince.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="validationErrors">validationErrors.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1099Misc(double? rents = default(double?), double? royalties = default(double?), double? otherIncome = default(double?), double? fedIncomeTaxWithheld = default(double?), double? fishingBoatProceeds = default(double?), double? medicalAndHealthCare = default(double?), double? nonemployeeCompensation = default(double?), double? substitutePayments = default(double?), bool directSalesIndicator = default(bool), double? cropInsuranceProceeds = default(double?), double? excessGoldenParachute = default(double?), double? grossAmountPaidAttorney = default(double?), double? section409ADeferrals = default(double?), double? section409AIncome = default(double?), string id = default(string), string type = default(string), int issuerId = default(int), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), Form1099StatusDetail federalEfileStatus = default(Form1099StatusDetail), bool stateEfile = default(bool), List<StateEfileStatusDetail> stateEfileStatus = default(List<StateEfileStatusDetail>), bool postalMail = default(bool), Form1099StatusDetail postalMailStatus = default(Form1099StatusDetail), bool tinMatch = default(bool), Form1099StatusDetail tinMatchStatus = default(Form1099StatusDetail), bool addressVerification = default(bool), Form1099StatusDetail addressVerificationStatus = default(Form1099StatusDetail), string referenceId = default(string), string email = default(string), string typeOfTin = default(string), string tin = default(string), string firstPayeeName = default(string), string secondPayeeName = default(string), string address = default(string), string addressRecipientSecond = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string countryCode = default(string), List<ValidationError> validationErrors = default(List<ValidationError>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding))
        {
            this.Rents = rents;
            this.Royalties = royalties;
            this.OtherIncome = otherIncome;
            this.FedIncomeTaxWithheld = fedIncomeTaxWithheld;
            this.FishingBoatProceeds = fishingBoatProceeds;
            this.MedicalAndHealthCare = medicalAndHealthCare;
            this.NonemployeeCompensation = nonemployeeCompensation;
            this.SubstitutePayments = substitutePayments;
            this.DirectSalesIndicator = directSalesIndicator;
            this.CropInsuranceProceeds = cropInsuranceProceeds;
            this.ExcessGoldenParachute = excessGoldenParachute;
            this.GrossAmountPaidAttorney = grossAmountPaidAttorney;
            this.Section409ADeferrals = section409ADeferrals;
            this.Section409AIncome = section409AIncome;
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
            this.TypeOfTin = typeOfTin;
            this.Tin = tin;
            this.FirstPayeeName = firstPayeeName;
            this.SecondPayeeName = secondPayeeName;
            this.Address = address;
            this.AddressRecipientSecond = addressRecipientSecond;
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
        /// Gets or Sets Rents
        /// </summary>
        [DataMember(Name = "rents", EmitDefaultValue = true)]
        public double? Rents { get; set; }

        /// <summary>
        /// Gets or Sets Royalties
        /// </summary>
        [DataMember(Name = "royalties", EmitDefaultValue = true)]
        public double? Royalties { get; set; }

        /// <summary>
        /// Gets or Sets OtherIncome
        /// </summary>
        [DataMember(Name = "otherIncome", EmitDefaultValue = true)]
        public double? OtherIncome { get; set; }

        /// <summary>
        /// Gets or Sets FedIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "fedIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FedIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets FishingBoatProceeds
        /// </summary>
        [DataMember(Name = "fishingBoatProceeds", EmitDefaultValue = true)]
        public double? FishingBoatProceeds { get; set; }

        /// <summary>
        /// Gets or Sets MedicalAndHealthCare
        /// </summary>
        [DataMember(Name = "medicalAndHealthCare", EmitDefaultValue = true)]
        public double? MedicalAndHealthCare { get; set; }

        /// <summary>
        /// Gets or Sets NonemployeeCompensation
        /// </summary>
        [DataMember(Name = "nonemployeeCompensation", EmitDefaultValue = true)]
        public double? NonemployeeCompensation { get; set; }

        /// <summary>
        /// Gets or Sets SubstitutePayments
        /// </summary>
        [DataMember(Name = "substitutePayments", EmitDefaultValue = true)]
        public double? SubstitutePayments { get; set; }

        /// <summary>
        /// Gets or Sets DirectSalesIndicator
        /// </summary>
        [DataMember(Name = "directSalesIndicator", EmitDefaultValue = true)]
        public bool DirectSalesIndicator { get; set; }

        /// <summary>
        /// Gets or Sets CropInsuranceProceeds
        /// </summary>
        [DataMember(Name = "cropInsuranceProceeds", EmitDefaultValue = true)]
        public double? CropInsuranceProceeds { get; set; }

        /// <summary>
        /// Gets or Sets ExcessGoldenParachute
        /// </summary>
        [DataMember(Name = "excessGoldenParachute", EmitDefaultValue = true)]
        public double? ExcessGoldenParachute { get; set; }

        /// <summary>
        /// Gets or Sets GrossAmountPaidAttorney
        /// </summary>
        [DataMember(Name = "grossAmountPaidAttorney", EmitDefaultValue = true)]
        public double? GrossAmountPaidAttorney { get; set; }

        /// <summary>
        /// Gets or Sets Section409ADeferrals
        /// </summary>
        [DataMember(Name = "section409ADeferrals", EmitDefaultValue = true)]
        public double? Section409ADeferrals { get; set; }

        /// <summary>
        /// Gets or Sets Section409AIncome
        /// </summary>
        [DataMember(Name = "section409AIncome", EmitDefaultValue = true)]
        public double? Section409AIncome { get; set; }

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
        /// Gets or Sets TypeOfTin
        /// </summary>
        [DataMember(Name = "typeOfTin", EmitDefaultValue = true)]
        public string TypeOfTin { get; set; }

        /// <summary>
        /// Gets or Sets Tin
        /// </summary>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Gets or Sets FirstPayeeName
        /// </summary>
        [DataMember(Name = "firstPayeeName", EmitDefaultValue = true)]
        public string FirstPayeeName { get; set; }

        /// <summary>
        /// Gets or Sets SecondPayeeName
        /// </summary>
        [DataMember(Name = "secondPayeeName", EmitDefaultValue = true)]
        public string SecondPayeeName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AddressRecipientSecond
        /// </summary>
        [DataMember(Name = "addressRecipientSecond", EmitDefaultValue = true)]
        public string AddressRecipientSecond { get; set; }

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
            sb.Append("class Form1099Misc {\n");
            sb.Append("  Rents: ").Append(Rents).Append("\n");
            sb.Append("  Royalties: ").Append(Royalties).Append("\n");
            sb.Append("  OtherIncome: ").Append(OtherIncome).Append("\n");
            sb.Append("  FedIncomeTaxWithheld: ").Append(FedIncomeTaxWithheld).Append("\n");
            sb.Append("  FishingBoatProceeds: ").Append(FishingBoatProceeds).Append("\n");
            sb.Append("  MedicalAndHealthCare: ").Append(MedicalAndHealthCare).Append("\n");
            sb.Append("  NonemployeeCompensation: ").Append(NonemployeeCompensation).Append("\n");
            sb.Append("  SubstitutePayments: ").Append(SubstitutePayments).Append("\n");
            sb.Append("  DirectSalesIndicator: ").Append(DirectSalesIndicator).Append("\n");
            sb.Append("  CropInsuranceProceeds: ").Append(CropInsuranceProceeds).Append("\n");
            sb.Append("  ExcessGoldenParachute: ").Append(ExcessGoldenParachute).Append("\n");
            sb.Append("  GrossAmountPaidAttorney: ").Append(GrossAmountPaidAttorney).Append("\n");
            sb.Append("  Section409ADeferrals: ").Append(Section409ADeferrals).Append("\n");
            sb.Append("  Section409AIncome: ").Append(Section409AIncome).Append("\n");
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
            sb.Append("  TypeOfTin: ").Append(TypeOfTin).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  FirstPayeeName: ").Append(FirstPayeeName).Append("\n");
            sb.Append("  SecondPayeeName: ").Append(SecondPayeeName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressRecipientSecond: ").Append(AddressRecipientSecond).Append("\n");
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
