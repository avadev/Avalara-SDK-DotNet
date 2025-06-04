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
    /// Schema for batch search list
    /// </summary>
    [DataContract(Name = "BatchSearchListResponse")]
    public partial class BatchSearchListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSearchListResponse" /> class.
        /// </summary>
        /// <param name="recordSetCount">The count of records in the result set.</param>
        /// <param name="nextLink">Next Link.</param>
        /// <param name="value">value.</param>
        public BatchSearchListResponse(int recordSetCount = default(int), string nextLink = default(string), List<BatchSearch> value = default(List<BatchSearch>))
        {
            this.RecordSetCount = recordSetCount;
            this.NextLink = nextLink;
            this.Value = value;
        }

        /// <summary>
        /// The count of records in the result set
        /// </summary>
        /// <value>The count of records in the result set</value>
        /// <example>500</example>
        [DataMember(Name = "@recordSetCount", EmitDefaultValue = false)]
        public int RecordSetCount { get; set; }

        /// <summary>
        /// Next Link
        /// </summary>
        /// <value>Next Link</value>
        /// <example>TODO</example>
        [DataMember(Name = "@nextLink", EmitDefaultValue = false)]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<BatchSearch> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchSearchListResponse {\n");
            sb.Append("  RecordSetCount: ").Append(RecordSetCount).Append("\n");
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
