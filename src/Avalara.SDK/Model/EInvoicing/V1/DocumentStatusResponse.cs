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
    /// Returns the current document ID and status
    /// </summary>
    [DataContract(Name = "DocumentStatusResponse")]
    public partial class DocumentStatusResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStatusResponse" /> class.
        /// </summary>
        /// <param name="id">The unique ID for this document.</param>
        /// <param name="status">Document status. See the &#x60;supportedDocumentStatuses&#x60; field in the GET /mandates response for full status definitions..</param>
        /// <param name="businessStatus">Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation..</param>
        /// <param name="events">events.</param>
        public DocumentStatusResponse(string id = default(string), string status = default(string), string businessStatus = default(string), List<StatusEvent> events = default(List<StatusEvent>))
        {
            this.Id = id;
            this.Status = status;
            this.BusinessStatus = businessStatus;
            this.Events = events;
        }

        /// <summary>
        /// The unique ID for this document
        /// </summary>
        /// <value>The unique ID for this document</value>
        /// <example>52f60401-44d0-4667-ad47-4afe519abb53</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Document status. See the &#x60;supportedDocumentStatuses&#x60; field in the GET /mandates response for full status definitions.
        /// </summary>
        /// <value>Document status. See the &#x60;supportedDocumentStatuses&#x60; field in the GET /mandates response for full status definitions.</value>
        /// <example>Fully Paid</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation.
        /// </summary>
        /// <value>Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation.</value>
        /// <example>Approved</example>
        [DataMember(Name = "businessStatus", EmitDefaultValue = false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<StatusEvent> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentStatusResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BusinessStatus: ").Append(BusinessStatus).Append("\n");
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
