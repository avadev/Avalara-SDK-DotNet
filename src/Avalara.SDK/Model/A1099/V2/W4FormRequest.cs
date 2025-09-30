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
    /// W4FormRequest
    /// </summary>
    [DataContract(Name = "W4FormRequest")]
    public partial class W4FormRequest : IValidatableObject
    {
        /// <summary>
        /// The form type (always \&quot;w4\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w4\&quot; for this model).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum W4 for value: W4
            /// </summary>
            [EnumMember(Value = "W4")]
            W4 = 1,

            /// <summary>
            /// Enum W8Ben for value: W8Ben
            /// </summary>
            [EnumMember(Value = "W8Ben")]
            W8Ben = 2,

            /// <summary>
            /// Enum W8BenE for value: W8BenE
            /// </summary>
            [EnumMember(Value = "W8BenE")]
            W8BenE = 3,

            /// <summary>
            /// Enum W8Imy for value: W8Imy
            /// </summary>
            [EnumMember(Value = "W8Imy")]
            W8Imy = 4,

            /// <summary>
            /// Enum W9 for value: W9
            /// </summary>
            [EnumMember(Value = "W9")]
            W9 = 5
        }


        /// <summary>
        /// The form type (always \&quot;w4\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w4\&quot; for this model).</value>
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
        /// The state of residence of the employee. Required unless exempt.
        /// </summary>
        /// <value>The state of residence of the employee. Required unless exempt.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 1,

            /// <summary>
            /// Enum AE for value: AE
            /// </summary>
            [EnumMember(Value = "AE")]
            AE = 2,

            /// <summary>
            /// Enum AK for value: AK
            /// </summary>
            [EnumMember(Value = "AK")]
            AK = 3,

            /// <summary>
            /// Enum AL for value: AL
            /// </summary>
            [EnumMember(Value = "AL")]
            AL = 4,

            /// <summary>
            /// Enum AP for value: AP
            /// </summary>
            [EnumMember(Value = "AP")]
            AP = 5,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 6,

            /// <summary>
            /// Enum AS for value: AS
            /// </summary>
            [EnumMember(Value = "AS")]
            AS = 7,

            /// <summary>
            /// Enum AZ for value: AZ
            /// </summary>
            [EnumMember(Value = "AZ")]
            AZ = 8,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 9,

            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            [EnumMember(Value = "CO")]
            CO = 10,

            /// <summary>
            /// Enum CT for value: CT
            /// </summary>
            [EnumMember(Value = "CT")]
            CT = 11,

            /// <summary>
            /// Enum DC for value: DC
            /// </summary>
            [EnumMember(Value = "DC")]
            DC = 12,

            /// <summary>
            /// Enum DE for value: DE
            /// </summary>
            [EnumMember(Value = "DE")]
            DE = 13,

            /// <summary>
            /// Enum FL for value: FL
            /// </summary>
            [EnumMember(Value = "FL")]
            FL = 14,

            /// <summary>
            /// Enum FM for value: FM
            /// </summary>
            [EnumMember(Value = "FM")]
            FM = 15,

            /// <summary>
            /// Enum GA for value: GA
            /// </summary>
            [EnumMember(Value = "GA")]
            GA = 16,

            /// <summary>
            /// Enum GU for value: GU
            /// </summary>
            [EnumMember(Value = "GU")]
            GU = 17,

            /// <summary>
            /// Enum HI for value: HI
            /// </summary>
            [EnumMember(Value = "HI")]
            HI = 18,

            /// <summary>
            /// Enum IA for value: IA
            /// </summary>
            [EnumMember(Value = "IA")]
            IA = 19,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 20,

            /// <summary>
            /// Enum IL for value: IL
            /// </summary>
            [EnumMember(Value = "IL")]
            IL = 21,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 22,

            /// <summary>
            /// Enum KS for value: KS
            /// </summary>
            [EnumMember(Value = "KS")]
            KS = 23,

            /// <summary>
            /// Enum KY for value: KY
            /// </summary>
            [EnumMember(Value = "KY")]
            KY = 24,

            /// <summary>
            /// Enum LA for value: LA
            /// </summary>
            [EnumMember(Value = "LA")]
            LA = 25,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 26,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 27,

            /// <summary>
            /// Enum ME for value: ME
            /// </summary>
            [EnumMember(Value = "ME")]
            ME = 28,

            /// <summary>
            /// Enum MH for value: MH
            /// </summary>
            [EnumMember(Value = "MH")]
            MH = 29,

            /// <summary>
            /// Enum MI for value: MI
            /// </summary>
            [EnumMember(Value = "MI")]
            MI = 30,

            /// <summary>
            /// Enum MN for value: MN
            /// </summary>
            [EnumMember(Value = "MN")]
            MN = 31,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 32,

            /// <summary>
            /// Enum MP for value: MP
            /// </summary>
            [EnumMember(Value = "MP")]
            MP = 33,

            /// <summary>
            /// Enum MS for value: MS
            /// </summary>
            [EnumMember(Value = "MS")]
            MS = 34,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 35,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 36,

            /// <summary>
            /// Enum ND for value: ND
            /// </summary>
            [EnumMember(Value = "ND")]
            ND = 37,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 38,

            /// <summary>
            /// Enum NH for value: NH
            /// </summary>
            [EnumMember(Value = "NH")]
            NH = 39,

            /// <summary>
            /// Enum NJ for value: NJ
            /// </summary>
            [EnumMember(Value = "NJ")]
            NJ = 40,

            /// <summary>
            /// Enum NM for value: NM
            /// </summary>
            [EnumMember(Value = "NM")]
            NM = 41,

            /// <summary>
            /// Enum NV for value: NV
            /// </summary>
            [EnumMember(Value = "NV")]
            NV = 42,

            /// <summary>
            /// Enum NY for value: NY
            /// </summary>
            [EnumMember(Value = "NY")]
            NY = 43,

            /// <summary>
            /// Enum OH for value: OH
            /// </summary>
            [EnumMember(Value = "OH")]
            OH = 44,

            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 45,

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            [EnumMember(Value = "OR")]
            OR = 46,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 47,

            /// <summary>
            /// Enum PR for value: PR
            /// </summary>
            [EnumMember(Value = "PR")]
            PR = 48,

            /// <summary>
            /// Enum PW for value: PW
            /// </summary>
            [EnumMember(Value = "PW")]
            PW = 49,

            /// <summary>
            /// Enum RI for value: RI
            /// </summary>
            [EnumMember(Value = "RI")]
            RI = 50,

            /// <summary>
            /// Enum SC for value: SC
            /// </summary>
            [EnumMember(Value = "SC")]
            SC = 51,

            /// <summary>
            /// Enum SD for value: SD
            /// </summary>
            [EnumMember(Value = "SD")]
            SD = 52,

            /// <summary>
            /// Enum TN for value: TN
            /// </summary>
            [EnumMember(Value = "TN")]
            TN = 53,

            /// <summary>
            /// Enum TX for value: TX
            /// </summary>
            [EnumMember(Value = "TX")]
            TX = 54,

            /// <summary>
            /// Enum UT for value: UT
            /// </summary>
            [EnumMember(Value = "UT")]
            UT = 55,

            /// <summary>
            /// Enum VA for value: VA
            /// </summary>
            [EnumMember(Value = "VA")]
            VA = 56,

            /// <summary>
            /// Enum VI for value: VI
            /// </summary>
            [EnumMember(Value = "VI")]
            VI = 57,

            /// <summary>
            /// Enum VT for value: VT
            /// </summary>
            [EnumMember(Value = "VT")]
            VT = 58,

            /// <summary>
            /// Enum WA for value: WA
            /// </summary>
            [EnumMember(Value = "WA")]
            WA = 59,

            /// <summary>
            /// Enum WI for value: WI
            /// </summary>
            [EnumMember(Value = "WI")]
            WI = 60,

            /// <summary>
            /// Enum WV for value: WV
            /// </summary>
            [EnumMember(Value = "WV")]
            WV = 61,

            /// <summary>
            /// Enum WY for value: WY
            /// </summary>
            [EnumMember(Value = "WY")]
            WY = 62
        }


        /// <summary>
        /// The state of residence of the employee. Required unless exempt.
        /// </summary>
        /// <value>The state of residence of the employee. Required unless exempt.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The marital status of the employee. Required unless exempt.  Available values:  - Single: Single or Married filing separately  - Married: Married filing jointly or qualifying surviving spouse  - MarriedBut: Head of household. Check only if you&#39;re unmarried and pay more than half the costs of keeping up a home for yourself and a qualifying individual.
        /// </summary>
        /// <value>The marital status of the employee. Required unless exempt.  Available values:  - Single: Single or Married filing separately  - Married: Married filing jointly or qualifying surviving spouse  - MarriedBut: Head of household. Check only if you&#39;re unmarried and pay more than half the costs of keeping up a home for yourself and a qualifying individual.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MaritalStatusEnum
        {
            /// <summary>
            /// Enum Single for value: Single
            /// </summary>
            [EnumMember(Value = "Single")]
            Single = 1,

            /// <summary>
            /// Enum Married for value: Married
            /// </summary>
            [EnumMember(Value = "Married")]
            Married = 2,

            /// <summary>
            /// Enum MarriedBut for value: MarriedBut
            /// </summary>
            [EnumMember(Value = "MarriedBut")]
            MarriedBut = 3
        }


        /// <summary>
        /// The marital status of the employee. Required unless exempt.  Available values:  - Single: Single or Married filing separately  - Married: Married filing jointly or qualifying surviving spouse  - MarriedBut: Head of household. Check only if you&#39;re unmarried and pay more than half the costs of keeping up a home for yourself and a qualifying individual.
        /// </summary>
        /// <value>The marital status of the employee. Required unless exempt.  Available values:  - Single: Single or Married filing separately  - Married: Married filing jointly or qualifying surviving spouse  - MarriedBut: Head of household. Check only if you&#39;re unmarried and pay more than half the costs of keeping up a home for yourself and a qualifying individual.</value>
        [DataMember(Name = "maritalStatus", EmitDefaultValue = true)]
        public MaritalStatusEnum? MaritalStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="W4FormRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected W4FormRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="W4FormRequest" /> class.
        /// </summary>
        /// <param name="employeeFirstName">The first name of the employee. (required).</param>
        /// <param name="employeeMiddleName">The middle name of the employee..</param>
        /// <param name="employeeLastName">The last name of the employee. (required).</param>
        /// <param name="employeeNameSuffix">The name suffix of the employee..</param>
        /// <param name="tinType">Tax Identification Number (TIN) type. (required).</param>
        /// <param name="tin">The taxpayer identification number (TIN). (required).</param>
        /// <param name="address">The address of the employee. Required unless exempt..</param>
        /// <param name="city">The city of residence of the employee. Required unless exempt..</param>
        /// <param name="state">The state of residence of the employee. Required unless exempt..</param>
        /// <param name="zip">The ZIP code of residence of the employee. Required unless exempt..</param>
        /// <param name="maritalStatus">The marital status of the employee. Required unless exempt.  Available values:  - Single: Single or Married filing separately  - Married: Married filing jointly or qualifying surviving spouse  - MarriedBut: Head of household. Check only if you&#39;re unmarried and pay more than half the costs of keeping up a home for yourself and a qualifying individual..</param>
        /// <param name="lastNameDiffers">Indicates whether the last name differs from prior records..</param>
        /// <param name="numAllowances">The number of allowances claimed by the employee..</param>
        /// <param name="otherDependents">The number of dependents other than allowances..</param>
        /// <param name="nonJobIncome">The amount of non-job income..</param>
        /// <param name="deductions">The amount of deductions claimed..</param>
        /// <param name="additionalWithheld">The additional amount withheld..</param>
        /// <param name="exemptFromWithholding">Indicates whether the employee is exempt from withholding..</param>
        /// <param name="officeCode">The office code associated with the form..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="companyId">The ID of the associated company. Required when creating a form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        public W4FormRequest(string employeeFirstName = default(string), string employeeMiddleName = default(string), string employeeLastName = default(string), string employeeNameSuffix = default(string), string tinType = default(string), string tin = default(string), string address = default(string), string city = default(string), StateEnum? state = default(StateEnum?), string zip = default(string), MaritalStatusEnum? maritalStatus = default(MaritalStatusEnum?), bool lastNameDiffers = default(bool), int? numAllowances = default(int?), int? otherDependents = default(int?), float? nonJobIncome = default(float?), float? deductions = default(float?), float? additionalWithheld = default(float?), bool exemptFromWithholding = default(bool), string officeCode = default(string), DateTime? eDeliveryConsentedAt = default(DateTime?), string signature = default(string), string companyId = default(string), string referenceId = default(string), string email = default(string))
        {
            // to ensure "employeeFirstName" is required (not null)
            if (employeeFirstName == null)
            {
                throw new ArgumentNullException("employeeFirstName is a required property for W4FormRequest and cannot be null");
            }
            this.EmployeeFirstName = employeeFirstName;
            // to ensure "employeeLastName" is required (not null)
            if (employeeLastName == null)
            {
                throw new ArgumentNullException("employeeLastName is a required property for W4FormRequest and cannot be null");
            }
            this.EmployeeLastName = employeeLastName;
            // to ensure "tinType" is required (not null)
            if (tinType == null)
            {
                throw new ArgumentNullException("tinType is a required property for W4FormRequest and cannot be null");
            }
            this.TinType = tinType;
            // to ensure "tin" is required (not null)
            if (tin == null)
            {
                throw new ArgumentNullException("tin is a required property for W4FormRequest and cannot be null");
            }
            this.Tin = tin;
            this.EmployeeMiddleName = employeeMiddleName;
            this.EmployeeNameSuffix = employeeNameSuffix;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.MaritalStatus = maritalStatus;
            this.LastNameDiffers = lastNameDiffers;
            this.NumAllowances = numAllowances;
            this.OtherDependents = otherDependents;
            this.NonJobIncome = nonJobIncome;
            this.Deductions = deductions;
            this.AdditionalWithheld = additionalWithheld;
            this.ExemptFromWithholding = exemptFromWithholding;
            this.OfficeCode = officeCode;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.Signature = signature;
            this.CompanyId = companyId;
            this.ReferenceId = referenceId;
            this.Email = email;
        }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        /// <value>The first name of the employee.</value>
        [DataMember(Name = "employeeFirstName", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeFirstName { get; set; }

        /// <summary>
        /// The middle name of the employee.
        /// </summary>
        /// <value>The middle name of the employee.</value>
        [DataMember(Name = "employeeMiddleName", EmitDefaultValue = true)]
        public string EmployeeMiddleName { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        /// <value>The last name of the employee.</value>
        [DataMember(Name = "employeeLastName", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// The name suffix of the employee.
        /// </summary>
        /// <value>The name suffix of the employee.</value>
        [DataMember(Name = "employeeNameSuffix", EmitDefaultValue = true)]
        public string EmployeeNameSuffix { get; set; }

        /// <summary>
        /// Tax Identification Number (TIN) type.
        /// </summary>
        /// <value>Tax Identification Number (TIN) type.</value>
        [DataMember(Name = "tinType", IsRequired = true, EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        [DataMember(Name = "tin", IsRequired = true, EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The address of the employee. Required unless exempt.
        /// </summary>
        /// <value>The address of the employee. Required unless exempt.</value>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The city of residence of the employee. Required unless exempt.
        /// </summary>
        /// <value>The city of residence of the employee. Required unless exempt.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The ZIP code of residence of the employee. Required unless exempt.
        /// </summary>
        /// <value>The ZIP code of residence of the employee. Required unless exempt.</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Indicates whether the last name differs from prior records.
        /// </summary>
        /// <value>Indicates whether the last name differs from prior records.</value>
        [DataMember(Name = "lastNameDiffers", EmitDefaultValue = true)]
        public bool LastNameDiffers { get; set; }

        /// <summary>
        /// The number of allowances claimed by the employee.
        /// </summary>
        /// <value>The number of allowances claimed by the employee.</value>
        [DataMember(Name = "numAllowances", EmitDefaultValue = true)]
        public int? NumAllowances { get; set; }

        /// <summary>
        /// The number of dependents other than allowances.
        /// </summary>
        /// <value>The number of dependents other than allowances.</value>
        [DataMember(Name = "otherDependents", EmitDefaultValue = true)]
        public int? OtherDependents { get; set; }

        /// <summary>
        /// The amount of non-job income.
        /// </summary>
        /// <value>The amount of non-job income.</value>
        [DataMember(Name = "nonJobIncome", EmitDefaultValue = true)]
        public float? NonJobIncome { get; set; }

        /// <summary>
        /// The amount of deductions claimed.
        /// </summary>
        /// <value>The amount of deductions claimed.</value>
        [DataMember(Name = "deductions", EmitDefaultValue = true)]
        public float? Deductions { get; set; }

        /// <summary>
        /// The additional amount withheld.
        /// </summary>
        /// <value>The additional amount withheld.</value>
        [DataMember(Name = "additionalWithheld", EmitDefaultValue = true)]
        public float? AdditionalWithheld { get; set; }

        /// <summary>
        /// Indicates whether the employee is exempt from withholding.
        /// </summary>
        /// <value>Indicates whether the employee is exempt from withholding.</value>
        [DataMember(Name = "exemptFromWithholding", EmitDefaultValue = true)]
        public bool ExemptFromWithholding { get; set; }

        /// <summary>
        /// The office code associated with the form.
        /// </summary>
        /// <value>The office code associated with the form.</value>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// The signature of the form.
        /// </summary>
        /// <value>The signature of the form.</value>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

        /// <summary>
        /// The ID of the associated company. Required when creating a form.
        /// </summary>
        /// <value>The ID of the associated company. Required when creating a form.</value>
        [DataMember(Name = "companyId", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// A reference identifier for the form.
        /// </summary>
        /// <value>A reference identifier for the form.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W4FormRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeMiddleName: ").Append(EmployeeMiddleName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  EmployeeNameSuffix: ").Append(EmployeeNameSuffix).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  LastNameDiffers: ").Append(LastNameDiffers).Append("\n");
            sb.Append("  NumAllowances: ").Append(NumAllowances).Append("\n");
            sb.Append("  OtherDependents: ").Append(OtherDependents).Append("\n");
            sb.Append("  NonJobIncome: ").Append(NonJobIncome).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  AdditionalWithheld: ").Append(AdditionalWithheld).Append("\n");
            sb.Append("  ExemptFromWithholding: ").Append(ExemptFromWithholding).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
