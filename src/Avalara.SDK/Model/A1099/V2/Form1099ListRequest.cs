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
    /// Form1099ListRequest
    /// </summary>
    [DataContract(Name = "Form1099ListRequest")]
    public partial class Form1099ListRequest : IValidatableObject
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
            Form1095B = 6,

            /// <summary>
            /// Enum Form1042S for value: Form1042S
            /// </summary>
            [EnumMember(Value = "Form1042S")]
            Form1042S = 7,

            /// <summary>
            /// Enum Form1095C for value: Form1095C
            /// </summary>
            [EnumMember(Value = "Form1095C")]
            Form1095C = 8,

            /// <summary>
            /// Enum Form1099Int for value: Form1099Int
            /// </summary>
            [EnumMember(Value = "Form1099Int")]
            Form1099Int = 9
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListRequest" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="forms">forms.</param>
        public Form1099ListRequest(TypeEnum? type = default(TypeEnum?), List<Get1099Form200Response> forms = default(List<Get1099Form200Response>))
        {
            this.Type = type;
            this.Forms = forms;
        }

        /// <summary>
        /// Gets or Sets Forms
        /// </summary>
        [DataMember(Name = "forms", EmitDefaultValue = false)]
        public List<Get1099Form200Response> Forms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099ListRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
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
