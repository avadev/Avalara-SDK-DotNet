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
    /// SubscriptionListResponse
    /// </summary>
    [DataContract(Name = "SubscriptionListResponse")]
    public partial class SubscriptionListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionListResponse" /> class.
        /// </summary>
        /// <param name="recordsetCount">The total count of records in the dataset..</param>
        /// <param name="nextLink">The URL to the next page of results..</param>
        /// <param name="value">The list of subscriptions..</param>
        public SubscriptionListResponse(int recordsetCount = default(int), string nextLink = default(string), List<SubscriptionDetail> value = default(List<SubscriptionDetail>))
        {
            this.RecordsetCount = recordsetCount;
            this.NextLink = nextLink;
            this.Value = value;
        }

        /// <summary>
        /// The total count of records in the dataset.
        /// </summary>
        /// <value>The total count of records in the dataset.</value>
        [DataMember(Name = "recordsetCount", EmitDefaultValue = false)]
        public int RecordsetCount { get; set; }

        /// <summary>
        /// The URL to the next page of results.
        /// </summary>
        /// <value>The URL to the next page of results.</value>
        [DataMember(Name = "@nextLink", EmitDefaultValue = false)]
        public string NextLink { get; set; }

        /// <summary>
        /// The list of subscriptions.
        /// </summary>
        /// <value>The list of subscriptions.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<SubscriptionDetail> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionListResponse {\n");
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
