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
    /// Represents a versioned definition of a code list for a specific jurisdiction and date range
    /// </summary>
    [DataContract(Name = "CodeListVersion")]
    public partial class CodeListVersion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeListVersion" /> class.
        /// </summary>
        /// <param name="versionReasons">List of free-text reasons explaining why this version of the code list exists (for example, initial introduction, regulatory update, addition/deprecation of codes). Useful for audit and change tracking..</param>
        /// <param name="jurisEffectiveDate">Date from which this version of the code list becomes legally or operationally effective in the jurisdiction. Typically corresponds to a go-live, mandate, or release date..</param>
        /// <param name="jurisSunsetDate">Date after which this version of the code list must no longer be used in the jurisdiction. Use a far-future date (e.g., 9999-12-31) when the sunset is not yet known..</param>
        /// <param name="locale">Language–region locale identifier indicating the language and regional variant for descriptions in this version of the code list. Follows BCP-47 format such as en-US, fr-FR, de-DE..</param>
        /// <param name="values">Array of code entries defined in this version of the code list. Each entry contains the machine-readable code value and its human-readable description in the given locale..</param>
        public CodeListVersion(List<string> versionReasons = default(List<string>), DateTime jurisEffectiveDate = default(DateTime), DateTime jurisSunsetDate = default(DateTime), string locale = default(string), List<CodeListValue> values = default(List<CodeListValue>))
        {
            this.VersionReasons = versionReasons;
            this.JurisEffectiveDate = jurisEffectiveDate;
            this.JurisSunsetDate = jurisSunsetDate;
            this.Locale = locale;
            this.Values = values;
        }

        /// <summary>
        /// List of free-text reasons explaining why this version of the code list exists (for example, initial introduction, regulatory update, addition/deprecation of codes). Useful for audit and change tracking.
        /// </summary>
        /// <value>List of free-text reasons explaining why this version of the code list exists (for example, initial introduction, regulatory update, addition/deprecation of codes). Useful for audit and change tracking.</value>
        /// <example>[&quot;Initial adoption of EN16931 document type codes&quot;,&quot;Alignment with French e-invoicing mandate 2026&quot;]</example>
        [DataMember(Name = "versionReasons", EmitDefaultValue = false)]
        public List<string> VersionReasons { get; set; }

        /// <summary>
        /// Date from which this version of the code list becomes legally or operationally effective in the jurisdiction. Typically corresponds to a go-live, mandate, or release date.
        /// </summary>
        /// <value>Date from which this version of the code list becomes legally or operationally effective in the jurisdiction. Typically corresponds to a go-live, mandate, or release date.</value>
        /// <example>Tue Dec 31 16:00:00 PST 2024</example>
        [DataMember(Name = "jurisEffectiveDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime JurisEffectiveDate { get; set; }

        /// <summary>
        /// Date after which this version of the code list must no longer be used in the jurisdiction. Use a far-future date (e.g., 9999-12-31) when the sunset is not yet known.
        /// </summary>
        /// <value>Date after which this version of the code list must no longer be used in the jurisdiction. Use a far-future date (e.g., 9999-12-31) when the sunset is not yet known.</value>
        /// <example>Thu Dec 30 16:00:00 PST 9999</example>
        [DataMember(Name = "jurisSunsetDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime JurisSunsetDate { get; set; }

        /// <summary>
        /// Language–region locale identifier indicating the language and regional variant for descriptions in this version of the code list. Follows BCP-47 format such as en-US, fr-FR, de-DE.
        /// </summary>
        /// <value>Language–region locale identifier indicating the language and regional variant for descriptions in this version of the code list. Follows BCP-47 format such as en-US, fr-FR, de-DE.</value>
        /// <example>fr-FR</example>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Array of code entries defined in this version of the code list. Each entry contains the machine-readable code value and its human-readable description in the given locale.
        /// </summary>
        /// <value>Array of code entries defined in this version of the code list. Each entry contains the machine-readable code value and its human-readable description in the given locale.</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<CodeListValue> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CodeListVersion {\n");
            sb.Append("  VersionReasons: ").Append(VersionReasons).Append("\n");
            sb.Append("  JurisEffectiveDate: ").Append(JurisEffectiveDate).Append("\n");
            sb.Append("  JurisSunsetDate: ").Append(JurisSunsetDate).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            yield break;
        }
    }
}
