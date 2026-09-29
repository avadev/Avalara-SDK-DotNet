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
    /// Extension
    /// </summary>
    [DataContract(Name = "Extension")]
    public partial class Extension : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Extension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Extension" /> class.
        /// </summary>
        /// <param name="key">Name of the custom attribute. (required).</param>
        /// <param name="values">Array of string values associated with the custom attribute. (required).</param>
        public Extension(string key = default(string), List<string> values = default(List<string>))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for Extension and cannot be null");
            }
            this.Key = key;
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new ArgumentNullException("values is a required property for Extension and cannot be null");
            }
            this.Values = values;
        }

        /// <summary>
        /// Name of the custom attribute.
        /// </summary>
        /// <value>Name of the custom attribute.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Array of string values associated with the custom attribute.
        /// </summary>
        /// <value>Array of string values associated with the custom attribute.</value>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Extension {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Key, length must be less than 250.", new [] { "Key" });
            }

            yield break;
        }
    }
}
