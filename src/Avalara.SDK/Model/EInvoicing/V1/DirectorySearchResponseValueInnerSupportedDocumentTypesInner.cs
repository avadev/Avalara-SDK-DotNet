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
    /// DirectorySearchResponseValueInnerSupportedDocumentTypesInner
    /// </summary>
    [DataContract(Name = "DirectorySearchResponse_value_inner_supportedDocumentTypes_inner")]
    public partial class DirectorySearchResponseValueInnerSupportedDocumentTypesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySearchResponseValueInnerSupportedDocumentTypesInner" /> class.
        /// </summary>
        /// <param name="name">Document type name..</param>
        /// <param name="value">Document type identifier..</param>
        /// <param name="supportedByTradingPartner">Does trading partner support receiving this document type.</param>
        /// <param name="supportedByAvalara">Does avalara support exchanging this document type.</param>
        public DirectorySearchResponseValueInnerSupportedDocumentTypesInner(string name = default(string), string value = default(string), bool supportedByTradingPartner = default(bool), bool supportedByAvalara = default(bool))
        {
            this.Name = name;
            this.Value = value;
            this.SupportedByTradingPartner = supportedByTradingPartner;
            this.SupportedByAvalara = supportedByAvalara;
        }

        /// <summary>
        /// Document type name.
        /// </summary>
        /// <value>Document type name.</value>
        /// <example>Peppol BIS Billing UBL Invoice V3</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Document type identifier.
        /// </summary>
        /// <value>Document type identifier.</value>
        /// <example>busdox-docid-qns::urn:oasis:names:specification:ubl:schema:xsd:Invoice-2::Invoice##urn:cen.eu:en16931:2017#compliant#urn:fdc:peppol.eu:2017:poacc:billing:3.0::2.1</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Does trading partner support receiving this document type
        /// </summary>
        /// <value>Does trading partner support receiving this document type</value>
        /// <example>true</example>
        [DataMember(Name = "supportedByTradingPartner", EmitDefaultValue = true)]
        public bool SupportedByTradingPartner { get; set; }

        /// <summary>
        /// Does avalara support exchanging this document type
        /// </summary>
        /// <value>Does avalara support exchanging this document type</value>
        /// <example>true</example>
        [DataMember(Name = "supportedByAvalara", EmitDefaultValue = true)]
        public bool SupportedByAvalara { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DirectorySearchResponseValueInnerSupportedDocumentTypesInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SupportedByTradingPartner: ").Append(SupportedByTradingPartner).Append("\n");
            sb.Append("  SupportedByAvalara: ").Append(SupportedByAvalara).Append("\n");
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
