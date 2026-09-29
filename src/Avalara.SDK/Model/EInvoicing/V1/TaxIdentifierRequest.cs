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
    /// Represents a request to validate company’s tax identifier.
    /// </summary>
    [DataContract(Name = "TaxIdentifierRequest")]
    public partial class TaxIdentifierRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxIdentifierRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxIdentifierRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxIdentifierRequest" /> class.
        /// </summary>
        /// <param name="countryCode">The two-letter ISO-3166 country code of the tax identifier. (required).</param>
        /// <param name="identifierType">Type of the identifier. (required).</param>
        /// <param name="identifier">The tax identifier of the company. (required).</param>
        /// <param name="extensions">Optional field for adding additional details required by specific tax authorities. Refer to the GET /tax-identifiers/schema API endpoint for the full request structure for a given country..</param>
        public TaxIdentifierRequest(string countryCode = default(string), string identifierType = default(string), string identifier = default(string), Object extensions = default(Object))
        {
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for TaxIdentifierRequest and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "identifierType" is required (not null)
            if (identifierType == null)
            {
                throw new ArgumentNullException("identifierType is a required property for TaxIdentifierRequest and cannot be null");
            }
            this.IdentifierType = identifierType;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for TaxIdentifierRequest and cannot be null");
            }
            this.Identifier = identifier;
            this.Extensions = extensions;
        }

        /// <summary>
        /// The two-letter ISO-3166 country code of the tax identifier.
        /// </summary>
        /// <value>The two-letter ISO-3166 country code of the tax identifier.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Type of the identifier.
        /// </summary>
        /// <value>Type of the identifier.</value>
        [DataMember(Name = "identifierType", IsRequired = true, EmitDefaultValue = true)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// The tax identifier of the company.
        /// </summary>
        /// <value>The tax identifier of the company.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Optional field for adding additional details required by specific tax authorities. Refer to the GET /tax-identifiers/schema API endpoint for the full request structure for a given country.
        /// </summary>
        /// <value>Optional field for adding additional details required by specific tax authorities. Refer to the GET /tax-identifiers/schema API endpoint for the full request structure for a given country.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public Object Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxIdentifierRequest {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if (this.CountryCode != null && this.CountryCode.Length < 2)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be greater than 2.", new [] { "CountryCode" });
            }

            // IdentifierType (string) maxLength
            if (this.IdentifierType != null && this.IdentifierType.Length > 100)
            {
                yield return new ValidationResult("Invalid value for IdentifierType, length must be less than 100.", new [] { "IdentifierType" });
            }

            // Identifier (string) maxLength
            if (this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            yield break;
        }
    }
}
