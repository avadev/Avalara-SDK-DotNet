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
    /// SupportedDocumentTypes
    /// </summary>
    [DataContract(Name = "SupportedDocumentTypes")]
    public partial class SupportedDocumentTypes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDocumentTypes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedDocumentTypes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDocumentTypes" /> class.
        /// </summary>
        /// <param name="name">Document type name..</param>
        /// <param name="value">Document type value. (required).</param>
        /// <param name="supportedByTradingPartner">Does trading partner support receiving this document type. (required).</param>
        /// <param name="supportedByAvalara">Does avalara support exchanging this document type..</param>
        /// <param name="extensions">Optional array used to carry additional metadata or configuration values that may be required by specific document types. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error..</param>
        public SupportedDocumentTypes(string name = default(string), string value = default(string), bool supportedByTradingPartner = default(bool), bool supportedByAvalara = default(bool), List<Extension> extensions = default(List<Extension>))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for SupportedDocumentTypes and cannot be null");
            }
            this.Value = value;
            this.SupportedByTradingPartner = supportedByTradingPartner;
            this.Name = name;
            this.SupportedByAvalara = supportedByAvalara;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Document type name.
        /// </summary>
        /// <value>Document type name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Document type value.
        /// </summary>
        /// <value>Document type value.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Does trading partner support receiving this document type.
        /// </summary>
        /// <value>Does trading partner support receiving this document type.</value>
        [DataMember(Name = "supportedByTradingPartner", IsRequired = true, EmitDefaultValue = true)]
        public bool SupportedByTradingPartner { get; set; }

        /// <summary>
        /// Does avalara support exchanging this document type.
        /// </summary>
        /// <value>Does avalara support exchanging this document type.</value>
        [DataMember(Name = "supportedByAvalara", EmitDefaultValue = true)]
        public bool SupportedByAvalara { get; set; }

        /// <summary>
        /// Optional array used to carry additional metadata or configuration values that may be required by specific document types. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error.
        /// </summary>
        /// <value>Optional array used to carry additional metadata or configuration values that may be required by specific document types. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedDocumentTypes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SupportedByTradingPartner: ").Append(SupportedByTradingPartner).Append("\n");
            sb.Append("  SupportedByAvalara: ").Append(SupportedByAvalara).Append("\n");
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

            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Value, length must be less than 500.", new [] { "Value" });
            }

            yield break;
        }
    }
}
