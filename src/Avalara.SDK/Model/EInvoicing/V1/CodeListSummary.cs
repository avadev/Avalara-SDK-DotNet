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
    /// Displays a summary of information about a code list
    /// </summary>
    [DataContract(Name = "CodeListSummary")]
    public partial class CodeListSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeListSummary" /> class.
        /// </summary>
        /// <param name="countryCode">Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction this code list applies to..</param>
        /// <param name="codeListId">System-generated unique identifier of the code list definition. Typically a UUID used to reference this code list internally or via APIs..</param>
        /// <param name="codeListName">Human-readable name of the code list, usually describing what the codes represent (for example, document types, tax categories, currencies)..</param>
        /// <param name="description">Textual description of the code list, including what it is used for and whether it represents a global standard (e.g., UN/CEFACT, ISO, EN16931) or a jurisdiction-specific/local extension of that standard..</param>
        /// <param name="standard">Identifier of the underlying standard or authoritative source for this code list. This may be a formal code list name (e.g., UNCL1001), a standard reference (e.g., EN16931), or an internal standard identifier..</param>
        /// <param name="versions">Array of versioned definitions of this code list for the given jurisdiction. Each entry represents a version that is valid for a specific effective/sunset date range, optionally per locale..</param>
        public CodeListSummary(string countryCode = default(string), string codeListId = default(string), string codeListName = default(string), string description = default(string), string standard = default(string), List<CodeListVersion> versions = default(List<CodeListVersion>))
        {
            this.CountryCode = countryCode;
            this.CodeListId = codeListId;
            this.CodeListName = codeListName;
            this.Description = description;
            this.Standard = standard;
            this.Versions = versions;
        }

        /// <summary>
        /// Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction this code list applies to.
        /// </summary>
        /// <value>Two-letter ISO 3166-1 alpha-2 country code indicating the jurisdiction this code list applies to.</value>
        /// <example>FR</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// System-generated unique identifier of the code list definition. Typically a UUID used to reference this code list internally or via APIs.
        /// </summary>
        /// <value>System-generated unique identifier of the code list definition. Typically a UUID used to reference this code list internally or via APIs.</value>
        /// <example>ab123343-3432-423c-ac3f-53453scs9999</example>
        [DataMember(Name = "codeListId", EmitDefaultValue = false)]
        public string CodeListId { get; set; }

        /// <summary>
        /// Human-readable name of the code list, usually describing what the codes represent (for example, document types, tax categories, currencies).
        /// </summary>
        /// <value>Human-readable name of the code list, usually describing what the codes represent (for example, document types, tax categories, currencies).</value>
        /// <example>DocumentType</example>
        [DataMember(Name = "codeListName", EmitDefaultValue = false)]
        public string CodeListName { get; set; }

        /// <summary>
        /// Textual description of the code list, including what it is used for and whether it represents a global standard (e.g., UN/CEFACT, ISO, EN16931) or a jurisdiction-specific/local extension of that standard.
        /// </summary>
        /// <value>Textual description of the code list, including what it is used for and whether it represents a global standard (e.g., UN/CEFACT, ISO, EN16931) or a jurisdiction-specific/local extension of that standard.</value>
        /// <example>Code list of document type identifiers for France, based on UN/CEFACT document type codes, with national (local) extensions where applicable.</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Identifier of the underlying standard or authoritative source for this code list. This may be a formal code list name (e.g., UNCL1001), a standard reference (e.g., EN16931), or an internal standard identifier.
        /// </summary>
        /// <value>Identifier of the underlying standard or authoritative source for this code list. This may be a formal code list name (e.g., UNCL1001), a standard reference (e.g., EN16931), or an internal standard identifier.</value>
        /// <example>UNCL1001</example>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        public string Standard { get; set; }

        /// <summary>
        /// Array of versioned definitions of this code list for the given jurisdiction. Each entry represents a version that is valid for a specific effective/sunset date range, optionally per locale.
        /// </summary>
        /// <value>Array of versioned definitions of this code list for the given jurisdiction. Each entry represents a version that is valid for a specific effective/sunset date range, optionally per locale.</value>
        [DataMember(Name = "versions", EmitDefaultValue = false)]
        public List<CodeListVersion> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeListSummary {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CodeListId: ").Append(CodeListId).Append("\n");
            sb.Append("  CodeListName: ").Append(CodeListName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
