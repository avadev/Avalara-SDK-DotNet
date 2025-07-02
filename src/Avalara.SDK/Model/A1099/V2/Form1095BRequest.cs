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
    /// Form1095BRequest
    /// </summary>
    [DataContract(Name = "Form1095BRequest")]
    public partial class Form1095BRequest : IValidatableObject
    {
        /// <summary>
        /// Defines OriginOfHealthCoverageCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OriginOfHealthCoverageCodeEnum
        {
            /// <summary>
            /// Enum SmallBusinessHealthOptionsProgram for value: SmallBusinessHealthOptionsProgram
            /// </summary>
            [EnumMember(Value = "SmallBusinessHealthOptionsProgram")]
            SmallBusinessHealthOptionsProgram = 1,

            /// <summary>
            /// Enum EmployerSponsored for value: EmployerSponsored
            /// </summary>
            [EnumMember(Value = "EmployerSponsored")]
            EmployerSponsored = 2,

            /// <summary>
            /// Enum GovernmentSponsored for value: GovernmentSponsored
            /// </summary>
            [EnumMember(Value = "GovernmentSponsored")]
            GovernmentSponsored = 3,

            /// <summary>
            /// Enum IndividualMarket for value: IndividualMarket
            /// </summary>
            [EnumMember(Value = "IndividualMarket")]
            IndividualMarket = 4,

            /// <summary>
            /// Enum MultiemployerPlan for value: MultiemployerPlan
            /// </summary>
            [EnumMember(Value = "MultiemployerPlan")]
            MultiemployerPlan = 5,

            /// <summary>
            /// Enum OtherDesignatedMinimumEssentialCoverage for value: OtherDesignatedMinimumEssentialCoverage
            /// </summary>
            [EnumMember(Value = "OtherDesignatedMinimumEssentialCoverage")]
            OtherDesignatedMinimumEssentialCoverage = 6,

            /// <summary>
            /// Enum EmployerSponsoredIndividualHra for value: EmployerSponsoredIndividualHra
            /// </summary>
            [EnumMember(Value = "EmployerSponsoredIndividualHra")]
            EmployerSponsoredIndividualHra = 7
        }


        /// <summary>
        /// Gets or Sets OriginOfHealthCoverageCode
        /// </summary>
        /// <example>SmallBusinessHealthOptionsProgram</example>
        [DataMember(Name = "originOfHealthCoverageCode", EmitDefaultValue = false)]
        public OriginOfHealthCoverageCodeEnum? OriginOfHealthCoverageCode { get; set; }
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
        /// Initializes a new instance of the <see cref="Form1095BRequest" /> class.
        /// </summary>
        /// <param name="employeeFirstName">employeeFirstName.</param>
        /// <param name="employeeMiddleName">employeeMiddleName.</param>
        /// <param name="employeeLastName">employeeLastName.</param>
        /// <param name="employeeNameSuffix">employeeNameSuffix.</param>
        /// <param name="employeeDateOfBirth">employeeDateOfBirth.</param>
        /// <param name="originOfHealthCoverageCode">originOfHealthCoverageCode.</param>
        /// <param name="coveredIndividuals">coveredIndividuals.</param>
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
        public Form1095BRequest(string employeeFirstName = default(string), string employeeMiddleName = default(string), string employeeLastName = default(string), string employeeNameSuffix = default(string), DateTime? employeeDateOfBirth = default(DateTime?), OriginOfHealthCoverageCodeEnum? originOfHealthCoverageCode = default(OriginOfHealthCoverageCodeEnum?), List<CoveredIndividualRequest> coveredIndividuals = default(List<CoveredIndividualRequest>), string issuerId = default(string), string referenceId = default(string), string recipientName = default(string), string recipientTin = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string recipientEmail = default(string), string accountNumber = default(string), string officeCode = default(string), string recipientNonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
            this.EmployeeFirstName = employeeFirstName;
            this.EmployeeMiddleName = employeeMiddleName;
            this.EmployeeLastName = employeeLastName;
            this.EmployeeNameSuffix = employeeNameSuffix;
            this.EmployeeDateOfBirth = employeeDateOfBirth;
            this.OriginOfHealthCoverageCode = originOfHealthCoverageCode;
            this.CoveredIndividuals = coveredIndividuals;
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
        /// Gets or Sets EmployeeFirstName
        /// </summary>
        [DataMember(Name = "employeeFirstName", EmitDefaultValue = false)]
        public string EmployeeFirstName { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeMiddleName
        /// </summary>
        [DataMember(Name = "employeeMiddleName", EmitDefaultValue = true)]
        public string EmployeeMiddleName { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeLastName
        /// </summary>
        [DataMember(Name = "employeeLastName", EmitDefaultValue = false)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeNameSuffix
        /// </summary>
        [DataMember(Name = "employeeNameSuffix", EmitDefaultValue = true)]
        public string EmployeeNameSuffix { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeDateOfBirth
        /// </summary>
        [DataMember(Name = "employeeDateOfBirth", EmitDefaultValue = true)]
        public DateTime? EmployeeDateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets CoveredIndividuals
        /// </summary>
        [DataMember(Name = "coveredIndividuals", EmitDefaultValue = false)]
        public List<CoveredIndividualRequest> CoveredIndividuals { get; set; }

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
            sb.Append("class Form1095BRequest {\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeMiddleName: ").Append(EmployeeMiddleName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  EmployeeNameSuffix: ").Append(EmployeeNameSuffix).Append("\n");
            sb.Append("  EmployeeDateOfBirth: ").Append(EmployeeDateOfBirth).Append("\n");
            sb.Append("  OriginOfHealthCoverageCode: ").Append(OriginOfHealthCoverageCode).Append("\n");
            sb.Append("  CoveredIndividuals: ").Append(CoveredIndividuals).Append("\n");
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
