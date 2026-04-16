/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara E-Invoicing API
 *
 * An API that supports sending data for an E-Invoicing compliance use-case.
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

namespace Avalara.SDK.Model.EInvoicing.V1
{
/// <summary>
    /// Represents a single code entry in a code list version
    /// </summary>
    [DataContract(Name = "CodeListValue")]
    public partial class CodeListValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeListValue" /> class.
        /// </summary>
        /// <param name="code">The actual code value used in documents or systems. This is typically what appears in the e-invoice payload, such as a numeric or alphanumeric code from the official code list..</param>
        /// <param name="value">Human-readable label or name for the code, localized according to the locale field of the version..</param>
        /// <param name="description">Detailed explanation of what the code represents, localized according to the locale field of the version..</param>
        public CodeListValue(string code = default(string), string value = default(string), string description = default(string))
        {
            this.Code = code;
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// The actual code value used in documents or systems. This is typically what appears in the e-invoice payload, such as a numeric or alphanumeric code from the official code list.
        /// </summary>
        /// <value>The actual code value used in documents or systems. This is typically what appears in the e-invoice payload, such as a numeric or alphanumeric code from the official code list.</value>
        /// <example>380</example>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Human-readable label or name for the code, localized according to the locale field of the version.
        /// </summary>
        /// <value>Human-readable label or name for the code, localized according to the locale field of the version.</value>
        /// <example>Commercial Invoice</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Detailed explanation of what the code represents, localized according to the locale field of the version.
        /// </summary>
        /// <value>Detailed explanation of what the code represents, localized according to the locale field of the version.</value>
        /// <example>Commercial Invoice Type</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeListValue {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
