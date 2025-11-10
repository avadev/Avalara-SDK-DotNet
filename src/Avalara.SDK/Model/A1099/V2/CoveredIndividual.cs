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
    /// Covered individual information for health coverage forms
    /// </summary>
    [DataContract(Name = "CoveredIndividual")]
    public partial class CoveredIndividual : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividual" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoveredIndividual() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividual" /> class.
        /// </summary>
        /// <param name="firstName">Covered individual&#39;s first name (required).</param>
        /// <param name="middleName">Covered individual&#39;s middle name.</param>
        /// <param name="lastName">Covered individual&#39;s last name (required).</param>
        /// <param name="nameSuffix">Covered individual&#39;s name suffix.</param>
        /// <param name="tin">Covered individual&#39;s Federal Tax Identification Number (TIN).. SSN or ITIN. Required unless unavailable..</param>
        /// <param name="birthDate">Covered individual&#39;s date of birth - Required when SSN is missing..</param>
        /// <param name="coveredJanuary">Coverage indicator for January.</param>
        /// <param name="coveredFebruary">Coverage indicator for February.</param>
        /// <param name="coveredMarch">Coverage indicator for March.</param>
        /// <param name="coveredApril">Coverage indicator for April.</param>
        /// <param name="coveredMay">Coverage indicator for May.</param>
        /// <param name="coveredJune">Coverage indicator for June.</param>
        /// <param name="coveredJuly">Coverage indicator for July.</param>
        /// <param name="coveredAugust">Coverage indicator for August.</param>
        /// <param name="coveredSeptember">Coverage indicator for September.</param>
        /// <param name="coveredOctober">Coverage indicator for October.</param>
        /// <param name="coveredNovember">Coverage indicator for November.</param>
        /// <param name="coveredDecember">Coverage indicator for December.</param>
        public CoveredIndividual(string firstName = default(string), string middleName = default(string), string lastName = default(string), string nameSuffix = default(string), string tin = default(string), DateTime? birthDate = default(DateTime?), bool? coveredJanuary = default(bool?), bool? coveredFebruary = default(bool?), bool? coveredMarch = default(bool?), bool? coveredApril = default(bool?), bool? coveredMay = default(bool?), bool? coveredJune = default(bool?), bool? coveredJuly = default(bool?), bool? coveredAugust = default(bool?), bool? coveredSeptember = default(bool?), bool? coveredOctober = default(bool?), bool? coveredNovember = default(bool?), bool? coveredDecember = default(bool?))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for CoveredIndividual and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for CoveredIndividual and cannot be null");
            }
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.NameSuffix = nameSuffix;
            this.Tin = tin;
            this.BirthDate = birthDate;
            this.CoveredJanuary = coveredJanuary;
            this.CoveredFebruary = coveredFebruary;
            this.CoveredMarch = coveredMarch;
            this.CoveredApril = coveredApril;
            this.CoveredMay = coveredMay;
            this.CoveredJune = coveredJune;
            this.CoveredJuly = coveredJuly;
            this.CoveredAugust = coveredAugust;
            this.CoveredSeptember = coveredSeptember;
            this.CoveredOctober = coveredOctober;
            this.CoveredNovember = coveredNovember;
            this.CoveredDecember = coveredDecember;
        }

        /// <summary>
        /// Covered individual&#39;s ID
        /// </summary>
        /// <value>Covered individual&#39;s ID</value>
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
        /// Covered individual&#39;s first name
        /// </summary>
        /// <value>Covered individual&#39;s first name</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Covered individual&#39;s middle name
        /// </summary>
        /// <value>Covered individual&#39;s middle name</value>
        [DataMember(Name = "middleName", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Covered individual&#39;s last name
        /// </summary>
        /// <value>Covered individual&#39;s last name</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Covered individual&#39;s name suffix
        /// </summary>
        /// <value>Covered individual&#39;s name suffix</value>
        [DataMember(Name = "nameSuffix", EmitDefaultValue = true)]
        public string NameSuffix { get; set; }

        /// <summary>
        /// Covered individual&#39;s Federal Tax Identification Number (TIN).. SSN or ITIN. Required unless unavailable.
        /// </summary>
        /// <value>Covered individual&#39;s Federal Tax Identification Number (TIN).. SSN or ITIN. Required unless unavailable.</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Covered individual&#39;s date of birth - Required when SSN is missing.
        /// </summary>
        /// <value>Covered individual&#39;s date of birth - Required when SSN is missing.</value>
        [DataMember(Name = "birthDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Coverage indicator for January
        /// </summary>
        /// <value>Coverage indicator for January</value>
        [DataMember(Name = "coveredJanuary", EmitDefaultValue = true)]
        public bool? CoveredJanuary { get; set; }

        /// <summary>
        /// Coverage indicator for February
        /// </summary>
        /// <value>Coverage indicator for February</value>
        [DataMember(Name = "coveredFebruary", EmitDefaultValue = true)]
        public bool? CoveredFebruary { get; set; }

        /// <summary>
        /// Coverage indicator for March
        /// </summary>
        /// <value>Coverage indicator for March</value>
        [DataMember(Name = "coveredMarch", EmitDefaultValue = true)]
        public bool? CoveredMarch { get; set; }

        /// <summary>
        /// Coverage indicator for April
        /// </summary>
        /// <value>Coverage indicator for April</value>
        [DataMember(Name = "coveredApril", EmitDefaultValue = true)]
        public bool? CoveredApril { get; set; }

        /// <summary>
        /// Coverage indicator for May
        /// </summary>
        /// <value>Coverage indicator for May</value>
        [DataMember(Name = "coveredMay", EmitDefaultValue = true)]
        public bool? CoveredMay { get; set; }

        /// <summary>
        /// Coverage indicator for June
        /// </summary>
        /// <value>Coverage indicator for June</value>
        [DataMember(Name = "coveredJune", EmitDefaultValue = true)]
        public bool? CoveredJune { get; set; }

        /// <summary>
        /// Coverage indicator for July
        /// </summary>
        /// <value>Coverage indicator for July</value>
        [DataMember(Name = "coveredJuly", EmitDefaultValue = true)]
        public bool? CoveredJuly { get; set; }

        /// <summary>
        /// Coverage indicator for August
        /// </summary>
        /// <value>Coverage indicator for August</value>
        [DataMember(Name = "coveredAugust", EmitDefaultValue = true)]
        public bool? CoveredAugust { get; set; }

        /// <summary>
        /// Coverage indicator for September
        /// </summary>
        /// <value>Coverage indicator for September</value>
        [DataMember(Name = "coveredSeptember", EmitDefaultValue = true)]
        public bool? CoveredSeptember { get; set; }

        /// <summary>
        /// Coverage indicator for October
        /// </summary>
        /// <value>Coverage indicator for October</value>
        [DataMember(Name = "coveredOctober", EmitDefaultValue = true)]
        public bool? CoveredOctober { get; set; }

        /// <summary>
        /// Coverage indicator for November
        /// </summary>
        /// <value>Coverage indicator for November</value>
        [DataMember(Name = "coveredNovember", EmitDefaultValue = true)]
        public bool? CoveredNovember { get; set; }

        /// <summary>
        /// Coverage indicator for December
        /// </summary>
        /// <value>Coverage indicator for December</value>
        [DataMember(Name = "coveredDecember", EmitDefaultValue = true)]
        public bool? CoveredDecember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoveredIndividual {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NameSuffix: ").Append(NameSuffix).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  CoveredJanuary: ").Append(CoveredJanuary).Append("\n");
            sb.Append("  CoveredFebruary: ").Append(CoveredFebruary).Append("\n");
            sb.Append("  CoveredMarch: ").Append(CoveredMarch).Append("\n");
            sb.Append("  CoveredApril: ").Append(CoveredApril).Append("\n");
            sb.Append("  CoveredMay: ").Append(CoveredMay).Append("\n");
            sb.Append("  CoveredJune: ").Append(CoveredJune).Append("\n");
            sb.Append("  CoveredJuly: ").Append(CoveredJuly).Append("\n");
            sb.Append("  CoveredAugust: ").Append(CoveredAugust).Append("\n");
            sb.Append("  CoveredSeptember: ").Append(CoveredSeptember).Append("\n");
            sb.Append("  CoveredOctober: ").Append(CoveredOctober).Append("\n");
            sb.Append("  CoveredNovember: ").Append(CoveredNovember).Append("\n");
            sb.Append("  CoveredDecember: ").Append(CoveredDecember).Append("\n");
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
