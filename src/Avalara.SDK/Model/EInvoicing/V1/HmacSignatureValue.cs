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
    /// Contains the HMAC algorithm and the resulting signature value used for verifying message integrity.
    /// </summary>
    [DataContract(Name = "HmacSignatureValue")]
    public partial class HmacSignatureValue : IValidatableObject
    {
        /// <summary>
        /// The algorithm used to create the signature.
        /// </summary>
        /// <value>The algorithm used to create the signature.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            /// <summary>
            /// Enum Sha256 for value: sha256
            /// </summary>
            [EnumMember(Value = "sha256")]
            Sha256 = 1
        }


        /// <summary>
        /// The algorithm used to create the signature.
        /// </summary>
        /// <value>The algorithm used to create the signature.</value>
        /// <example>sha256</example>
        [DataMember(Name = "algorithm", IsRequired = true, EmitDefaultValue = true)]
        public AlgorithmEnum Algorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HmacSignatureValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HmacSignatureValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HmacSignatureValue" /> class.
        /// </summary>
        /// <param name="algorithm">The algorithm used to create the signature. (required).</param>
        /// <param name="value">Signature of the message. (required).</param>
        public HmacSignatureValue(AlgorithmEnum algorithm = default(AlgorithmEnum), string value = default(string))
        {
            this.Algorithm = algorithm;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for HmacSignatureValue and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Signature of the message.
        /// </summary>
        /// <value>Signature of the message.</value>
        /// <example>your-secret-key</example>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HmacSignatureValue {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
