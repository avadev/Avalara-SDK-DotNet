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
    /// EventMessage
    /// </summary>
    [DataContract(Name = "EventMessage")]
    public partial class EventMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventMessage" /> class.
        /// </summary>
        /// <param name="message">Event-specific information (required).</param>
        /// <param name="signature">signature (required).</param>
        /// <param name="tenantId">Tenant ID of the event (required).</param>
        /// <param name="correlationId">The correlation ID used by Avalara to aid in tracing through to provenance of this event massage..</param>
        /// <param name="systemCode">The Avalara registered code for the system. See &lt;a href&#x3D;\&quot;https://avalara.atlassian.net/wiki/spaces/AIM/pages/637250338966/Taxonomy+Avalara+Systems\&quot;&gt;Taxonomy&amp;#58; Avalara Systems&lt;/a&gt; (required).</param>
        /// <param name="eventName">Type of the event (required).</param>
        /// <param name="eventVersion">Version of the included payload..</param>
        /// <param name="receiptTimestamp">Timestamp when the event was received by the dispatch service..</param>
        public EventMessage(Object message = default(Object), SignatureValueSignature signature = default(SignatureValueSignature), string tenantId = default(string), string correlationId = default(string), string systemCode = default(string), string eventName = default(string), string eventVersion = default(string), DateTime receiptTimestamp = default(DateTime))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for EventMessage and cannot be null");
            }
            this.Message = message;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for EventMessage and cannot be null");
            }
            this.Signature = signature;
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for EventMessage and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "systemCode" is required (not null)
            if (systemCode == null)
            {
                throw new ArgumentNullException("systemCode is a required property for EventMessage and cannot be null");
            }
            this.SystemCode = systemCode;
            // to ensure "eventName" is required (not null)
            if (eventName == null)
            {
                throw new ArgumentNullException("eventName is a required property for EventMessage and cannot be null");
            }
            this.EventName = eventName;
            this.CorrelationId = correlationId;
            this.EventVersion = eventVersion;
            this.ReceiptTimestamp = receiptTimestamp;
        }

        /// <summary>
        /// Event-specific information
        /// </summary>
        /// <value>Event-specific information</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public Object Message { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public SignatureValueSignature Signature { get; set; }

        /// <summary>
        /// Tenant ID of the event
        /// </summary>
        /// <value>Tenant ID of the event</value>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The correlation ID used by Avalara to aid in tracing through to provenance of this event massage.
        /// </summary>
        /// <value>The correlation ID used by Avalara to aid in tracing through to provenance of this event massage.</value>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// The Avalara registered code for the system. See &lt;a href&#x3D;\&quot;https://avalara.atlassian.net/wiki/spaces/AIM/pages/637250338966/Taxonomy+Avalara+Systems\&quot;&gt;Taxonomy&amp;#58; Avalara Systems&lt;/a&gt;
        /// </summary>
        /// <value>The Avalara registered code for the system. See &lt;a href&#x3D;\&quot;https://avalara.atlassian.net/wiki/spaces/AIM/pages/637250338966/Taxonomy+Avalara+Systems\&quot;&gt;Taxonomy&amp;#58; Avalara Systems&lt;/a&gt;</value>
        [DataMember(Name = "systemCode", IsRequired = true, EmitDefaultValue = true)]
        public string SystemCode { get; set; }

        /// <summary>
        /// Type of the event
        /// </summary>
        /// <value>Type of the event</value>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = true)]
        public string EventName { get; set; }

        /// <summary>
        /// Version of the included payload.
        /// </summary>
        /// <value>Version of the included payload.</value>
        [DataMember(Name = "eventVersion", EmitDefaultValue = false)]
        public string EventVersion { get; set; }

        /// <summary>
        /// Timestamp when the event was received by the dispatch service.
        /// </summary>
        /// <value>Timestamp when the event was received by the dispatch service.</value>
        [DataMember(Name = "receiptTimestamp", EmitDefaultValue = false)]
        public DateTime ReceiptTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventMessage {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  SystemCode: ").Append(SystemCode).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventVersion: ").Append(EventVersion).Append("\n");
            sb.Append("  ReceiptTimestamp: ").Append(ReceiptTimestamp).Append("\n");
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
