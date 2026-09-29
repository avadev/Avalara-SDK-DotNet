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
    /// TaxIdentifierResponseValue
    /// </summary>
    [DataContract(Name = "TaxIdentifierResponse_value")]
    public partial class TaxIdentifierResponseValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxIdentifierResponseValue" /> class.
        /// </summary>
        /// <param name="identifierType">Type of the identifier..</param>
        /// <param name="identifier">The tax identifier of the company..</param>
        /// <param name="extensions">Optional field containing additional company-related information such as companyName, companyAddress, blockListed, tradeName, and taxPayerType. It may also include other details specific to the given tax authority. Refer to the GET /tax-identifiers/schema API endpoint for the full response structure for a given country..</param>
        public TaxIdentifierResponseValue(string identifierType = default(string), string identifier = default(string), Object extensions = default(Object))
        {
            this.IdentifierType = identifierType;
            this.Identifier = identifier;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Type of the identifier.
        /// </summary>
        /// <value>Type of the identifier.</value>
        [DataMember(Name = "identifierType", EmitDefaultValue = false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// The tax identifier of the company.
        /// </summary>
        /// <value>The tax identifier of the company.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Optional field containing additional company-related information such as companyName, companyAddress, blockListed, tradeName, and taxPayerType. It may also include other details specific to the given tax authority. Refer to the GET /tax-identifiers/schema API endpoint for the full response structure for a given country.
        /// </summary>
        /// <value>Optional field containing additional company-related information such as companyName, companyAddress, blockListed, tradeName, and taxPayerType. It may also include other details specific to the given tax authority. Refer to the GET /tax-identifiers/schema API endpoint for the full response structure for a given country.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public Object Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxIdentifierResponseValue {\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
            yield break;
        }
    }
}
