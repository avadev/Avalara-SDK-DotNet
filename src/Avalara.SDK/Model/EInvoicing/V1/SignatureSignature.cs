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
    /// SignatureSignature
    /// </summary>
    [DataContract(Name = "Signature_signature")]
    public partial class SignatureSignature : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Hmac for value: hmac
            /// </summary>
            [EnumMember(Value = "hmac")]
            Hmac = 2
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>none</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// HMAC algorithm for authentication
        /// </summary>
        /// <value>HMAC algorithm for authentication</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            /// <summary>
            /// Enum Sha256 for value: sha256
            /// </summary>
            [EnumMember(Value = "sha256")]
            Sha256 = 1,

            /// <summary>
            /// Enum Sha384 for value: sha384
            /// </summary>
            [EnumMember(Value = "sha384")]
            Sha384 = 2,

            /// <summary>
            /// Enum Sha512 for value: sha512
            /// </summary>
            [EnumMember(Value = "sha512")]
            Sha512 = 3
        }


        /// <summary>
        /// HMAC algorithm for authentication
        /// </summary>
        /// <value>HMAC algorithm for authentication</value>
        [DataMember(Name = "algorithm", IsRequired = true, EmitDefaultValue = true)]
        public AlgorithmEnum Algorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureSignature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureSignature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureSignature" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="key">HMAC key for authentication (required).</param>
        /// <param name="algorithm">HMAC algorithm for authentication (required).</param>
        public SignatureSignature(TypeEnum type = default(TypeEnum), string key = default(string), AlgorithmEnum algorithm = default(AlgorithmEnum))
        {
            this.Type = type;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for SignatureSignature and cannot be null");
            }
            this.Key = key;
            this.Algorithm = algorithm;
        }

        /// <summary>
        /// HMAC key for authentication
        /// </summary>
        /// <value>HMAC key for authentication</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureSignature {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
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
