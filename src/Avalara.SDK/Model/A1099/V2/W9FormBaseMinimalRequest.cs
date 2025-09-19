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
    /// W9FormBaseMinimalRequest
    /// </summary>
    [DataContract(Name = "W9FormBaseMinimalRequest")]
    public partial class W9FormBaseMinimalRequest : IValidatableObject
    {
        /// <summary>
        /// The form type.
        /// </summary>
        /// <value>The form type.</value>
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
        /// The form type.
        /// </summary>
        /// <value>The form type.</value>
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
        /// Initializes a new instance of the <see cref="W9FormBaseMinimalRequest" /> class.
        /// </summary>
        /// <param name="companyId">The ID of the associated company. Required when creating a form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        public W9FormBaseMinimalRequest(string companyId = default(string), string referenceId = default(string), string email = default(string))
        {
            this.CompanyId = companyId;
            this.ReferenceId = referenceId;
            this.Email = email;
        }

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
            sb.Append("class W9FormBaseMinimalRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
