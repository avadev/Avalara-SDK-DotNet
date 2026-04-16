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
    /// Identifier
    /// </summary>
    [DataContract(Name = "Identifier")]
    public partial class Identifier : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Identifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier" /> class.
        /// </summary>
        /// <param name="name">Identifier name (e.g., Peppol Participant ID). (required).</param>
        /// <param name="displayName">Display name of the identifier..</param>
        /// <param name="value">Value of the identifier. (required).</param>
        /// <param name="extensions">Optional array used to carry additional metadata or configuration values for the identifier..</param>
        public Identifier(string name = default(string), string displayName = default(string), string value = default(string), List<Extension> extensions = default(List<Extension>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Identifier and cannot be null");
            }
            this.Name = name;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for Identifier and cannot be null");
            }
            this.Value = value;
            this.DisplayName = displayName;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Identifier name (e.g., Peppol Participant ID).
        /// </summary>
        /// <value>Identifier name (e.g., Peppol Participant ID).</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Display name of the identifier.
        /// </summary>
        /// <value>Display name of the identifier.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Value of the identifier.
        /// </summary>
        /// <value>Value of the identifier.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Optional array used to carry additional metadata or configuration values for the identifier.
        /// </summary>
        /// <value>Optional array used to carry additional metadata or configuration values for the identifier.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Identifier {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 250.", new [] { "Name" });
            }

            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 250)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 250.", new [] { "DisplayName" });
            }

            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Value, length must be less than 250.", new [] { "Value" });
            }

            yield break;
        }
    }
}
