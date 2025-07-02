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
    /// Form1099R
    /// </summary>
    [DataContract(Name = "Form1099R")]
    public partial class Form1099R : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099R" /> class.
        /// </summary>
        /// <param name="grossDistributions">grossDistributions.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxableAmountNotDetermined">taxableAmountNotDetermined.</param>
        /// <param name="totalDistributionIndicator">totalDistributionIndicator.</param>
        /// <param name="capitalGain">capitalGain.</param>
        /// <param name="fedIncomeTaxWithheld">fedIncomeTaxWithheld.</param>
        /// <param name="employeeContributions">employeeContributions.</param>
        /// <param name="netUnrealizedAppreciation">netUnrealizedAppreciation.</param>
        /// <param name="distributionCodeRequired">distributionCodeRequired.</param>
        /// <param name="distributionCodeOptional">distributionCodeOptional.</param>
        /// <param name="iraSepSimpleIndicator">iraSepSimpleIndicator.</param>
        /// <param name="totalIraSepSimpleDistribution">totalIraSepSimpleDistribution.</param>
        /// <param name="other">other.</param>
        /// <param name="otherPercent">otherPercent.</param>
        /// <param name="percentageTotalDistribution">percentageTotalDistribution.</param>
        /// <param name="totalEmployeeContributions">totalEmployeeContributions.</param>
        /// <param name="amountAllocableToIrr">amountAllocableToIrr.</param>
        /// <param name="firstYearDesignatedRothContrib">firstYearDesignatedRothContrib.</param>
        /// <param name="fatcaRequirementIndicator">fatcaRequirementIndicator.</param>
        /// <param name="dateOfPayment">dateOfPayment.</param>
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
        public Form1099R(double? grossDistributions = default(double?), double? taxableAmount = default(double?), bool? taxableAmountNotDetermined = default(bool?), bool? totalDistributionIndicator = default(bool?), double? capitalGain = default(double?), double? fedIncomeTaxWithheld = default(double?), double? employeeContributions = default(double?), double? netUnrealizedAppreciation = default(double?), string distributionCodeRequired = default(string), string distributionCodeOptional = default(string), bool? iraSepSimpleIndicator = default(bool?), double? totalIraSepSimpleDistribution = default(double?), double? other = default(double?), string otherPercent = default(string), string percentageTotalDistribution = default(string), double? totalEmployeeContributions = default(double?), double? amountAllocableToIrr = default(double?), string firstYearDesignatedRothContrib = default(string), bool? fatcaRequirementIndicator = default(bool?), string dateOfPayment = default(string), string id = default(string), string type = default(string), int issuerId = default(int), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), Form1099StatusDetail federalEfileStatus = default(Form1099StatusDetail), bool stateEfile = default(bool), List<StateEfileStatusDetail> stateEfileStatus = default(List<StateEfileStatusDetail>), bool postalMail = default(bool), Form1099StatusDetail postalMailStatus = default(Form1099StatusDetail), bool tinMatch = default(bool), Form1099StatusDetail tinMatchStatus = default(Form1099StatusDetail), bool addressVerification = default(bool), Form1099StatusDetail addressVerificationStatus = default(Form1099StatusDetail), string referenceId = default(string), string email = default(string), string tinType = default(string), string tin = default(string), string recipientName = default(string), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string countryCode = default(string), List<ValidationError> validationErrors = default(List<ValidationError>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding))
        {
            this.GrossDistributions = grossDistributions;
            this.TaxableAmount = taxableAmount;
            this.TaxableAmountNotDetermined = taxableAmountNotDetermined;
            this.TotalDistributionIndicator = totalDistributionIndicator;
            this.CapitalGain = capitalGain;
            this.FedIncomeTaxWithheld = fedIncomeTaxWithheld;
            this.EmployeeContributions = employeeContributions;
            this.NetUnrealizedAppreciation = netUnrealizedAppreciation;
            this.DistributionCodeRequired = distributionCodeRequired;
            this.DistributionCodeOptional = distributionCodeOptional;
            this.IraSepSimpleIndicator = iraSepSimpleIndicator;
            this.TotalIraSepSimpleDistribution = totalIraSepSimpleDistribution;
            this.Other = other;
            this.OtherPercent = otherPercent;
            this.PercentageTotalDistribution = percentageTotalDistribution;
            this.TotalEmployeeContributions = totalEmployeeContributions;
            this.AmountAllocableToIrr = amountAllocableToIrr;
            this.FirstYearDesignatedRothContrib = firstYearDesignatedRothContrib;
            this.FatcaRequirementIndicator = fatcaRequirementIndicator;
            this.DateOfPayment = dateOfPayment;
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
        /// Gets or Sets GrossDistributions
        /// </summary>
        [DataMember(Name = "grossDistributions", EmitDefaultValue = true)]
        public double? GrossDistributions { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name = "taxableAmount", EmitDefaultValue = true)]
        public double? TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmountNotDetermined
        /// </summary>
        [DataMember(Name = "taxableAmountNotDetermined", EmitDefaultValue = true)]
        public bool? TaxableAmountNotDetermined { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistributionIndicator
        /// </summary>
        [DataMember(Name = "totalDistributionIndicator", EmitDefaultValue = true)]
        public bool? TotalDistributionIndicator { get; set; }

        /// <summary>
        /// Gets or Sets CapitalGain
        /// </summary>
        [DataMember(Name = "capitalGain", EmitDefaultValue = true)]
        public double? CapitalGain { get; set; }

        /// <summary>
        /// Gets or Sets FedIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "fedIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FedIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeContributions
        /// </summary>
        [DataMember(Name = "employeeContributions", EmitDefaultValue = true)]
        public double? EmployeeContributions { get; set; }

        /// <summary>
        /// Gets or Sets NetUnrealizedAppreciation
        /// </summary>
        [DataMember(Name = "netUnrealizedAppreciation", EmitDefaultValue = true)]
        public double? NetUnrealizedAppreciation { get; set; }

        /// <summary>
        /// Gets or Sets DistributionCodeRequired
        /// </summary>
        [DataMember(Name = "distributionCodeRequired", EmitDefaultValue = true)]
        public string DistributionCodeRequired { get; set; }

        /// <summary>
        /// Gets or Sets DistributionCodeOptional
        /// </summary>
        [DataMember(Name = "distributionCodeOptional", EmitDefaultValue = true)]
        public string DistributionCodeOptional { get; set; }

        /// <summary>
        /// Gets or Sets IraSepSimpleIndicator
        /// </summary>
        [DataMember(Name = "iraSepSimpleIndicator", EmitDefaultValue = true)]
        public bool? IraSepSimpleIndicator { get; set; }

        /// <summary>
        /// Gets or Sets TotalIraSepSimpleDistribution
        /// </summary>
        [DataMember(Name = "totalIraSepSimpleDistribution", EmitDefaultValue = true)]
        public double? TotalIraSepSimpleDistribution { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name = "other", EmitDefaultValue = true)]
        public double? Other { get; set; }

        /// <summary>
        /// Gets or Sets OtherPercent
        /// </summary>
        [DataMember(Name = "otherPercent", EmitDefaultValue = true)]
        public string OtherPercent { get; set; }

        /// <summary>
        /// Gets or Sets PercentageTotalDistribution
        /// </summary>
        [DataMember(Name = "percentageTotalDistribution", EmitDefaultValue = true)]
        public string PercentageTotalDistribution { get; set; }

        /// <summary>
        /// Gets or Sets TotalEmployeeContributions
        /// </summary>
        [DataMember(Name = "totalEmployeeContributions", EmitDefaultValue = true)]
        public double? TotalEmployeeContributions { get; set; }

        /// <summary>
        /// Gets or Sets AmountAllocableToIrr
        /// </summary>
        [DataMember(Name = "amountAllocableToIrr", EmitDefaultValue = true)]
        public double? AmountAllocableToIrr { get; set; }

        /// <summary>
        /// Gets or Sets FirstYearDesignatedRothContrib
        /// </summary>
        [DataMember(Name = "firstYearDesignatedRothContrib", EmitDefaultValue = true)]
        public string FirstYearDesignatedRothContrib { get; set; }

        /// <summary>
        /// Gets or Sets FatcaRequirementIndicator
        /// </summary>
        [DataMember(Name = "fatcaRequirementIndicator", EmitDefaultValue = true)]
        public bool? FatcaRequirementIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DateOfPayment
        /// </summary>
        [DataMember(Name = "dateOfPayment", EmitDefaultValue = true)]
        public string DateOfPayment { get; set; }

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
            sb.Append("class Form1099R {\n");
            sb.Append("  GrossDistributions: ").Append(GrossDistributions).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxableAmountNotDetermined: ").Append(TaxableAmountNotDetermined).Append("\n");
            sb.Append("  TotalDistributionIndicator: ").Append(TotalDistributionIndicator).Append("\n");
            sb.Append("  CapitalGain: ").Append(CapitalGain).Append("\n");
            sb.Append("  FedIncomeTaxWithheld: ").Append(FedIncomeTaxWithheld).Append("\n");
            sb.Append("  EmployeeContributions: ").Append(EmployeeContributions).Append("\n");
            sb.Append("  NetUnrealizedAppreciation: ").Append(NetUnrealizedAppreciation).Append("\n");
            sb.Append("  DistributionCodeRequired: ").Append(DistributionCodeRequired).Append("\n");
            sb.Append("  DistributionCodeOptional: ").Append(DistributionCodeOptional).Append("\n");
            sb.Append("  IraSepSimpleIndicator: ").Append(IraSepSimpleIndicator).Append("\n");
            sb.Append("  TotalIraSepSimpleDistribution: ").Append(TotalIraSepSimpleDistribution).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  OtherPercent: ").Append(OtherPercent).Append("\n");
            sb.Append("  PercentageTotalDistribution: ").Append(PercentageTotalDistribution).Append("\n");
            sb.Append("  TotalEmployeeContributions: ").Append(TotalEmployeeContributions).Append("\n");
            sb.Append("  AmountAllocableToIrr: ").Append(AmountAllocableToIrr).Append("\n");
            sb.Append("  FirstYearDesignatedRothContrib: ").Append(FirstYearDesignatedRothContrib).Append("\n");
            sb.Append("  FatcaRequirementIndicator: ").Append(FatcaRequirementIndicator).Append("\n");
            sb.Append("  DateOfPayment: ").Append(DateOfPayment).Append("\n");
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
