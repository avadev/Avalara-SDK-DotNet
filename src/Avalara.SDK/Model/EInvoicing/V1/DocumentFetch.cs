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
    /// DocumentFetch
    /// </summary>
    [DataContract(Name = "documentFetch")]
    public partial class DocumentFetch : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFetch" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this document that can be used for status checking and file downloads. This is a UID created by the Avalara E-Invoicing platform..</param>
        /// <param name="status">Status of the document.</param>
        /// <param name="eventDateTime">The date and time when the inbound document was accepted by the Avalara E-Invoicing Platform.</param>
        public DocumentFetch(string id = default(string), string status = default(string), string eventDateTime = default(string))
        {
            this.Id = id;
            this.Status = status;
            this.EventDateTime = eventDateTime;
        }

        /// <summary>
        /// Unique ID for this document that can be used for status checking and file downloads. This is a UID created by the Avalara E-Invoicing platform.
        /// </summary>
        /// <value>Unique ID for this document that can be used for status checking and file downloads. This is a UID created by the Avalara E-Invoicing platform.</value>
        /// <example>52f60401-44d0-4667-ad47-4afe519abb53</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Status of the document
        /// </summary>
        /// <value>Status of the document</value>
        /// <example>Accepted</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The date and time when the inbound document was accepted by the Avalara E-Invoicing Platform
        /// </summary>
        /// <value>The date and time when the inbound document was accepted by the Avalara E-Invoicing Platform</value>
        /// <example>2024-05-27T14:20:07:723</example>
        [DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
        public string EventDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentFetch {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
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
