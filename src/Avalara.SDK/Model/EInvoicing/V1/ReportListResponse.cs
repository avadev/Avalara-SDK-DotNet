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
    /// Returns the requested list of reports matching the query parameters.
    /// </summary>
    [DataContract(Name = "ReportListResponse")]
    public partial class ReportListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportListResponse" /> class.
        /// </summary>
        /// <param name="recordsetCount">Count of reports matching the filter for the given query. Present when the request includes $count&#x3D;true..</param>
        /// <param name="nextLink">URL to retrieve the next page of results when more items match the query. Omitted or null when there is no next page..</param>
        /// <param name="value">Array of reports matching the query parameters. (required).</param>
        public ReportListResponse(string recordsetCount = default(string), string nextLink = default(string), List<ReportItem> value = default(List<ReportItem>))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ReportListResponse and cannot be null");
            }
            this.Value = value;
            this.RecordsetCount = recordsetCount;
            this.NextLink = nextLink;
        }

        /// <summary>
        /// Count of reports matching the filter for the given query. Present when the request includes $count&#x3D;true.
        /// </summary>
        /// <value>Count of reports matching the filter for the given query. Present when the request includes $count&#x3D;true.</value>
        /// <example>1</example>
        [DataMember(Name = "@recordsetCount", EmitDefaultValue = false)]
        public string RecordsetCount { get; set; }

        /// <summary>
        /// URL to retrieve the next page of results when more items match the query. Omitted or null when there is no next page.
        /// </summary>
        /// <value>URL to retrieve the next page of results when more items match the query. Omitted or null when there is no next page.</value>
        [DataMember(Name = "@nextLink", EmitDefaultValue = true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Array of reports matching the query parameters.
        /// </summary>
        /// <value>Array of reports matching the query parameters.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public List<ReportItem> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportListResponse {\n");
            sb.Append("  RecordsetCount: ").Append(RecordsetCount).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
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
