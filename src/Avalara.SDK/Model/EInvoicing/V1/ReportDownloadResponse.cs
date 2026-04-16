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
    /// Returns a pre-signed URL to download the report file.
    /// </summary>
    [DataContract(Name = "ReportDownloadResponse")]
    public partial class ReportDownloadResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDownloadResponse" /> class.
        /// </summary>
        /// <param name="reportId">The unique identifier of the report..</param>
        /// <param name="downloadUrl">A pre-signed URL to download the report file. This URL is time-limited..</param>
        public ReportDownloadResponse(string reportId = default(string), string downloadUrl = default(string))
        {
            this.ReportId = reportId;
            this.DownloadUrl = downloadUrl;
        }

        /// <summary>
        /// The unique identifier of the report.
        /// </summary>
        /// <value>The unique identifier of the report.</value>
        /// <example>ef96f5c1-2626-4efe-897d-b5d93fb8424b</example>
        [DataMember(Name = "reportId", EmitDefaultValue = false)]
        public string ReportId { get; set; }

        /// <summary>
        /// A pre-signed URL to download the report file. This URL is time-limited.
        /// </summary>
        /// <value>A pre-signed URL to download the report file. This URL is time-limited.</value>
        /// <example>https://storage.example.com/reports/ef96f5c1-2626-4efe-897d-b5d93fb8424b?signature&#x3D;xyz</example>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportDownloadResponse {\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
