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
    /// SubscriptionRegistration
    /// </summary>
    [DataContract(Name = "SubscriptionRegistration")]
    public partial class SubscriptionRegistration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRegistration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionRegistration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRegistration" /> class.
        /// </summary>
        /// <param name="description">Description of the subscription.</param>
        /// <param name="notificationUrl">The URL of the webhook endpoint to which event messages will be delivered (required).</param>
        /// <param name="signature">signature (required).</param>
        /// <param name="events">events (required).</param>
        public SubscriptionRegistration(string description = default(string), string notificationUrl = default(string), SignatureSignature signature = default(SignatureSignature), List<EventSubscription> events = default(List<EventSubscription>))
        {
            // to ensure "notificationUrl" is required (not null)
            if (notificationUrl == null)
            {
                throw new ArgumentNullException("notificationUrl is a required property for SubscriptionRegistration and cannot be null");
            }
            this.NotificationUrl = notificationUrl;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for SubscriptionRegistration and cannot be null");
            }
            this.Signature = signature;
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for SubscriptionRegistration and cannot be null");
            }
            this.Events = events;
            this.Description = description;
        }

        /// <summary>
        /// Description of the subscription
        /// </summary>
        /// <value>Description of the subscription</value>
        /// <example>Basic webhook configuration without signature</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint to which event messages will be delivered
        /// </summary>
        /// <value>The URL of the webhook endpoint to which event messages will be delivered</value>
        /// <example>https://webhook.example.com/notifications</example>
        [DataMember(Name = "notificationUrl", IsRequired = true, EmitDefaultValue = true)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public SignatureSignature Signature { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<EventSubscription> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionRegistration {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
