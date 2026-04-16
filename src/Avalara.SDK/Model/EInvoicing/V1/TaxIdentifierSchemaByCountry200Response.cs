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
    /// TaxIdentifierSchemaByCountry200Response
    /// </summary>
    [DataContract(Name = "TaxIdentifierSchemaByCountry_200_response")]
    public partial class TaxIdentifierSchemaByCountry200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxIdentifierSchemaByCountry200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxIdentifierSchemaByCountry200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxIdentifierSchemaByCountry200Response" /> class.
        /// </summary>
        /// <param name="countryCode">The two-letter ISO-3166 country code of the tax identifier. (required).</param>
        /// <param name="schemaType">The type of schema returned: \&quot;request\&quot; or \&quot;response\&quot;. (required).</param>
        /// <param name="schema">The JSON Schema definition, following Draft-07 specification, used to validate tax identifier data. (required).</param>
        public TaxIdentifierSchemaByCountry200Response(string countryCode = default(string), string schemaType = default(string), Object schema = default(Object))
        {
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for TaxIdentifierSchemaByCountry200Response and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "schemaType" is required (not null)
            if (schemaType == null)
            {
                throw new ArgumentNullException("schemaType is a required property for TaxIdentifierSchemaByCountry200Response and cannot be null");
            }
            this.SchemaType = schemaType;
            // to ensure "schema" is required (not null)
            if (schema == null)
            {
                throw new ArgumentNullException("schema is a required property for TaxIdentifierSchemaByCountry200Response and cannot be null");
            }
            this.Schema = schema;
        }

        /// <summary>
        /// The two-letter ISO-3166 country code of the tax identifier.
        /// </summary>
        /// <value>The two-letter ISO-3166 country code of the tax identifier.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The type of schema returned: \&quot;request\&quot; or \&quot;response\&quot;.
        /// </summary>
        /// <value>The type of schema returned: \&quot;request\&quot; or \&quot;response\&quot;.</value>
        [DataMember(Name = "schemaType", IsRequired = true, EmitDefaultValue = true)]
        public string SchemaType { get; set; }

        /// <summary>
        /// The JSON Schema definition, following Draft-07 specification, used to validate tax identifier data.
        /// </summary>
        /// <value>The JSON Schema definition, following Draft-07 specification, used to validate tax identifier data.</value>
        [DataMember(Name = "schema", IsRequired = true, EmitDefaultValue = true)]
        public Object Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxIdentifierSchemaByCountry200Response {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  SchemaType: ").Append(SchemaType).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
