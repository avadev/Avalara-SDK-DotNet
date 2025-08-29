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
    /// Primary withholding agent information for tax forms
    /// </summary>
    [DataContract(Name = "PrimaryWithholdingAgent")]
    public partial class PrimaryWithholdingAgent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryWithholdingAgent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrimaryWithholdingAgent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryWithholdingAgent" /> class.
        /// </summary>
        /// <param name="name">Name of the primary withholding agent (required).</param>
        /// <param name="ein">EIN (Employer Identification Number) of the primary withholding agent. (required).</param>
        public PrimaryWithholdingAgent(string name = default(string), string ein = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PrimaryWithholdingAgent and cannot be null");
            }
            this.Name = name;
            // to ensure "ein" is required (not null)
            if (ein == null)
            {
                throw new ArgumentNullException("ein is a required property for PrimaryWithholdingAgent and cannot be null");
            }
            this.Ein = ein;
        }

        /// <summary>
        /// Name of the primary withholding agent
        /// </summary>
        /// <value>Name of the primary withholding agent</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// EIN (Employer Identification Number) of the primary withholding agent.
        /// </summary>
        /// <value>EIN (Employer Identification Number) of the primary withholding agent.</value>
        [DataMember(Name = "ein", IsRequired = true, EmitDefaultValue = true)]
        public string Ein { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrimaryWithholdingAgent {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ein: ").Append(Ein).Append("\n");
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
