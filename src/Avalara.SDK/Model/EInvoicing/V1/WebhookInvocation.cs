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
    /// WebhookInvocation
    /// </summary>
    [DataContract(Name = "WebhookInvocation")]
    public partial class WebhookInvocation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInvocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookInvocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInvocation" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of this specific resource. (required).</param>
        /// <param name="retryCount">The number of invocation attempts..</param>
        /// <param name="retryMax">The maximum retries that may be attempted in total..</param>
        /// <param name="invocationTimestamp">Initial timestamp of the first invocation attempt. (required).</param>
        /// <param name="retryTimestamp">Timestamp of this invocation attempt..</param>
        /// <param name="items">Array of events being delivered in the webhook (required).</param>
        public WebhookInvocation(Guid id = default(Guid), int retryCount = default(int), int retryMax = default(int), DateTime invocationTimestamp = default(DateTime), DateTime retryTimestamp = default(DateTime), List<EventMessage> items = default(List<EventMessage>))
        {
            this.Id = id;
            this.InvocationTimestamp = invocationTimestamp;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for WebhookInvocation and cannot be null");
            }
            this.Items = items;
            this.RetryCount = retryCount;
            this.RetryMax = retryMax;
            this.RetryTimestamp = retryTimestamp;
        }

        /// <summary>
        /// Unique identifier of this specific resource.
        /// </summary>
        /// <value>Unique identifier of this specific resource.</value>
        /// <example>0147b6a4-3b40-49d4-8762-575c903bd609</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The number of invocation attempts.
        /// </summary>
        /// <value>The number of invocation attempts.</value>
        [DataMember(Name = "retryCount", EmitDefaultValue = false)]
        public int RetryCount { get; set; }

        /// <summary>
        /// The maximum retries that may be attempted in total.
        /// </summary>
        /// <value>The maximum retries that may be attempted in total.</value>
        [DataMember(Name = "retryMax", EmitDefaultValue = false)]
        public int RetryMax { get; set; }

        /// <summary>
        /// Initial timestamp of the first invocation attempt.
        /// </summary>
        /// <value>Initial timestamp of the first invocation attempt.</value>
        [DataMember(Name = "invocationTimestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime InvocationTimestamp { get; set; }

        /// <summary>
        /// Timestamp of this invocation attempt.
        /// </summary>
        /// <value>Timestamp of this invocation attempt.</value>
        [DataMember(Name = "retryTimestamp", EmitDefaultValue = false)]
        public DateTime RetryTimestamp { get; set; }

        /// <summary>
        /// Array of events being delivered in the webhook
        /// </summary>
        /// <value>Array of events being delivered in the webhook</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<EventMessage> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookInvocation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  RetryMax: ").Append(RetryMax).Append("\n");
            sb.Append("  InvocationTimestamp: ").Append(InvocationTimestamp).Append("\n");
            sb.Append("  RetryTimestamp: ").Append(RetryTimestamp).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
