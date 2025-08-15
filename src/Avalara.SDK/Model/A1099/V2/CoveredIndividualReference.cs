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
    /// CoveredIndividualReference
    /// </summary>
    [DataContract(Name = "CoveredIndividualReference")]
    public partial class CoveredIndividualReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividualReference" /> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="nameSuffix">nameSuffix.</param>
        /// <param name="tin">tin.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="coveredMonth0">coveredMonth0.</param>
        /// <param name="coveredMonth1">coveredMonth1.</param>
        /// <param name="coveredMonth2">coveredMonth2.</param>
        /// <param name="coveredMonth3">coveredMonth3.</param>
        /// <param name="coveredMonth4">coveredMonth4.</param>
        /// <param name="coveredMonth5">coveredMonth5.</param>
        /// <param name="coveredMonth6">coveredMonth6.</param>
        /// <param name="coveredMonth7">coveredMonth7.</param>
        /// <param name="coveredMonth8">coveredMonth8.</param>
        /// <param name="coveredMonth9">coveredMonth9.</param>
        /// <param name="coveredMonth10">coveredMonth10.</param>
        /// <param name="coveredMonth11">coveredMonth11.</param>
        /// <param name="coveredMonth12">coveredMonth12.</param>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        public CoveredIndividualReference(string firstName = default(string), string middleName = default(string), string lastName = default(string), string nameSuffix = default(string), string tin = default(string), DateTime? birthDate = default(DateTime?), bool coveredMonth0 = default(bool), bool coveredMonth1 = default(bool), bool coveredMonth2 = default(bool), bool coveredMonth3 = default(bool), bool coveredMonth4 = default(bool), bool coveredMonth5 = default(bool), bool coveredMonth6 = default(bool), bool coveredMonth7 = default(bool), bool coveredMonth8 = default(bool), bool coveredMonth9 = default(bool), bool coveredMonth10 = default(bool), bool coveredMonth11 = default(bool), bool coveredMonth12 = default(bool), string id = default(string), string type = default(string))
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.NameSuffix = nameSuffix;
            this.Tin = tin;
            this.BirthDate = birthDate;
            this.CoveredMonth0 = coveredMonth0;
            this.CoveredMonth1 = coveredMonth1;
            this.CoveredMonth2 = coveredMonth2;
            this.CoveredMonth3 = coveredMonth3;
            this.CoveredMonth4 = coveredMonth4;
            this.CoveredMonth5 = coveredMonth5;
            this.CoveredMonth6 = coveredMonth6;
            this.CoveredMonth7 = coveredMonth7;
            this.CoveredMonth8 = coveredMonth8;
            this.CoveredMonth9 = coveredMonth9;
            this.CoveredMonth10 = coveredMonth10;
            this.CoveredMonth11 = coveredMonth11;
            this.CoveredMonth12 = coveredMonth12;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets NameSuffix
        /// </summary>
        [DataMember(Name = "nameSuffix", EmitDefaultValue = true)]
        public string NameSuffix { get; set; }

        /// <summary>
        /// Gets or Sets Tin
        /// </summary>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = true)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth0
        /// </summary>
        [DataMember(Name = "coveredMonth0", EmitDefaultValue = true)]
        public bool CoveredMonth0 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth1
        /// </summary>
        [DataMember(Name = "coveredMonth1", EmitDefaultValue = true)]
        public bool CoveredMonth1 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth2
        /// </summary>
        [DataMember(Name = "coveredMonth2", EmitDefaultValue = true)]
        public bool CoveredMonth2 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth3
        /// </summary>
        [DataMember(Name = "coveredMonth3", EmitDefaultValue = true)]
        public bool CoveredMonth3 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth4
        /// </summary>
        [DataMember(Name = "coveredMonth4", EmitDefaultValue = true)]
        public bool CoveredMonth4 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth5
        /// </summary>
        [DataMember(Name = "coveredMonth5", EmitDefaultValue = true)]
        public bool CoveredMonth5 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth6
        /// </summary>
        [DataMember(Name = "coveredMonth6", EmitDefaultValue = true)]
        public bool CoveredMonth6 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth7
        /// </summary>
        [DataMember(Name = "coveredMonth7", EmitDefaultValue = true)]
        public bool CoveredMonth7 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth8
        /// </summary>
        [DataMember(Name = "coveredMonth8", EmitDefaultValue = true)]
        public bool CoveredMonth8 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth9
        /// </summary>
        [DataMember(Name = "coveredMonth9", EmitDefaultValue = true)]
        public bool CoveredMonth9 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth10
        /// </summary>
        [DataMember(Name = "coveredMonth10", EmitDefaultValue = true)]
        public bool CoveredMonth10 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth11
        /// </summary>
        [DataMember(Name = "coveredMonth11", EmitDefaultValue = true)]
        public bool CoveredMonth11 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonth12
        /// </summary>
        [DataMember(Name = "coveredMonth12", EmitDefaultValue = true)]
        public bool CoveredMonth12 { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoveredIndividualReference {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NameSuffix: ").Append(NameSuffix).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  CoveredMonth0: ").Append(CoveredMonth0).Append("\n");
            sb.Append("  CoveredMonth1: ").Append(CoveredMonth1).Append("\n");
            sb.Append("  CoveredMonth2: ").Append(CoveredMonth2).Append("\n");
            sb.Append("  CoveredMonth3: ").Append(CoveredMonth3).Append("\n");
            sb.Append("  CoveredMonth4: ").Append(CoveredMonth4).Append("\n");
            sb.Append("  CoveredMonth5: ").Append(CoveredMonth5).Append("\n");
            sb.Append("  CoveredMonth6: ").Append(CoveredMonth6).Append("\n");
            sb.Append("  CoveredMonth7: ").Append(CoveredMonth7).Append("\n");
            sb.Append("  CoveredMonth8: ").Append(CoveredMonth8).Append("\n");
            sb.Append("  CoveredMonth9: ").Append(CoveredMonth9).Append("\n");
            sb.Append("  CoveredMonth10: ").Append(CoveredMonth10).Append("\n");
            sb.Append("  CoveredMonth11: ").Append(CoveredMonth11).Append("\n");
            sb.Append("  CoveredMonth12: ").Append(CoveredMonth12).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
