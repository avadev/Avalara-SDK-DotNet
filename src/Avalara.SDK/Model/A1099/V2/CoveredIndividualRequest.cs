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
    /// CoveredIndividualRequest
    /// </summary>
    [DataContract(Name = "CoveredIndividualRequest")]
    public partial class CoveredIndividualRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividualRequest" /> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="nameSuffix">nameSuffix.</param>
        /// <param name="tin">tin.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="coveredMonthIndicator0">coveredMonthIndicator0.</param>
        /// <param name="coveredMonthIndicator1">coveredMonthIndicator1.</param>
        /// <param name="coveredMonthIndicator2">coveredMonthIndicator2.</param>
        /// <param name="coveredMonthIndicator3">coveredMonthIndicator3.</param>
        /// <param name="coveredMonthIndicator4">coveredMonthIndicator4.</param>
        /// <param name="coveredMonthIndicator5">coveredMonthIndicator5.</param>
        /// <param name="coveredMonthIndicator6">coveredMonthIndicator6.</param>
        /// <param name="coveredMonthIndicator7">coveredMonthIndicator7.</param>
        /// <param name="coveredMonthIndicator8">coveredMonthIndicator8.</param>
        /// <param name="coveredMonthIndicator9">coveredMonthIndicator9.</param>
        /// <param name="coveredMonthIndicator10">coveredMonthIndicator10.</param>
        /// <param name="coveredMonthIndicator11">coveredMonthIndicator11.</param>
        /// <param name="coveredMonthIndicator12">coveredMonthIndicator12.</param>
        public CoveredIndividualRequest(string firstName = default(string), string middleName = default(string), string lastName = default(string), string nameSuffix = default(string), string tin = default(string), DateTime? birthDate = default(DateTime?), bool coveredMonthIndicator0 = default(bool), bool coveredMonthIndicator1 = default(bool), bool coveredMonthIndicator2 = default(bool), bool coveredMonthIndicator3 = default(bool), bool coveredMonthIndicator4 = default(bool), bool coveredMonthIndicator5 = default(bool), bool coveredMonthIndicator6 = default(bool), bool coveredMonthIndicator7 = default(bool), bool coveredMonthIndicator8 = default(bool), bool coveredMonthIndicator9 = default(bool), bool coveredMonthIndicator10 = default(bool), bool coveredMonthIndicator11 = default(bool), bool coveredMonthIndicator12 = default(bool))
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.NameSuffix = nameSuffix;
            this.Tin = tin;
            this.BirthDate = birthDate;
            this.CoveredMonthIndicator0 = coveredMonthIndicator0;
            this.CoveredMonthIndicator1 = coveredMonthIndicator1;
            this.CoveredMonthIndicator2 = coveredMonthIndicator2;
            this.CoveredMonthIndicator3 = coveredMonthIndicator3;
            this.CoveredMonthIndicator4 = coveredMonthIndicator4;
            this.CoveredMonthIndicator5 = coveredMonthIndicator5;
            this.CoveredMonthIndicator6 = coveredMonthIndicator6;
            this.CoveredMonthIndicator7 = coveredMonthIndicator7;
            this.CoveredMonthIndicator8 = coveredMonthIndicator8;
            this.CoveredMonthIndicator9 = coveredMonthIndicator9;
            this.CoveredMonthIndicator10 = coveredMonthIndicator10;
            this.CoveredMonthIndicator11 = coveredMonthIndicator11;
            this.CoveredMonthIndicator12 = coveredMonthIndicator12;
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
        /// Gets or Sets CoveredMonthIndicator0
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator0", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator0 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator1
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator1", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator1 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator2
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator2", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator2 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator3
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator3", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator3 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator4
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator4", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator4 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator5
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator5", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator5 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator6
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator6", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator6 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator7
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator7", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator7 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator8
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator8", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator8 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator9
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator9", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator9 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator10
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator10", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator10 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator11
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator11", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator11 { get; set; }

        /// <summary>
        /// Gets or Sets CoveredMonthIndicator12
        /// </summary>
        [DataMember(Name = "coveredMonthIndicator12", EmitDefaultValue = true)]
        public bool CoveredMonthIndicator12 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoveredIndividualRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NameSuffix: ").Append(NameSuffix).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  CoveredMonthIndicator0: ").Append(CoveredMonthIndicator0).Append("\n");
            sb.Append("  CoveredMonthIndicator1: ").Append(CoveredMonthIndicator1).Append("\n");
            sb.Append("  CoveredMonthIndicator2: ").Append(CoveredMonthIndicator2).Append("\n");
            sb.Append("  CoveredMonthIndicator3: ").Append(CoveredMonthIndicator3).Append("\n");
            sb.Append("  CoveredMonthIndicator4: ").Append(CoveredMonthIndicator4).Append("\n");
            sb.Append("  CoveredMonthIndicator5: ").Append(CoveredMonthIndicator5).Append("\n");
            sb.Append("  CoveredMonthIndicator6: ").Append(CoveredMonthIndicator6).Append("\n");
            sb.Append("  CoveredMonthIndicator7: ").Append(CoveredMonthIndicator7).Append("\n");
            sb.Append("  CoveredMonthIndicator8: ").Append(CoveredMonthIndicator8).Append("\n");
            sb.Append("  CoveredMonthIndicator9: ").Append(CoveredMonthIndicator9).Append("\n");
            sb.Append("  CoveredMonthIndicator10: ").Append(CoveredMonthIndicator10).Append("\n");
            sb.Append("  CoveredMonthIndicator11: ").Append(CoveredMonthIndicator11).Append("\n");
            sb.Append("  CoveredMonthIndicator12: ").Append(CoveredMonthIndicator12).Append("\n");
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
