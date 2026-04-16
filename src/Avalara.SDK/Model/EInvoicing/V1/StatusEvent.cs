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
    /// Displays when a status event occurred
    /// </summary>
    [DataContract(Name = "StatusEvent")]
    public partial class StatusEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusEvent" /> class.
        /// </summary>
        /// <param name="eventDateTime">The date and time when the status event occurred, displayed in the format YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="message">A message describing the status event.</param>
        /// <param name="responseKey"> The type of number or acknowledgement returned by the tax authority (if applicable). For example, it could be an identification key, acknowledgement code, or any other relevant identifier..</param>
        /// <param name="responseValue">The corresponding value associated with the response key. This value is provided by the tax authority in response to the event..</param>
        /// <param name="category">Represents the functional area or process stage where the status event occurred. Useful for grouping related events such as document processing, transmission, or validation..</param>
        public StatusEvent(string eventDateTime = default(string), string message = default(string), string responseKey = default(string), string responseValue = default(string), string category = default(string))
        {
            this.EventDateTime = eventDateTime;
            this.Message = message;
            this.ResponseKey = responseKey;
            this.ResponseValue = responseValue;
            this.Category = category;
        }

        /// <summary>
        /// The date and time when the status event occurred, displayed in the format YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The date and time when the status event occurred, displayed in the format YYYY-MM-DDThh:mm:ss</value>
        /// <example>2025-11-06T10:42:33Z</example>
        [DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
        public string EventDateTime { get; set; }

        /// <summary>
        /// A message describing the status event
        /// </summary>
        /// <value>A message describing the status event</value>
        /// <example>E-Invoice sent to SDI</example>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        ///  The type of number or acknowledgement returned by the tax authority (if applicable). For example, it could be an identification key, acknowledgement code, or any other relevant identifier.
        /// </summary>
        /// <value> The type of number or acknowledgement returned by the tax authority (if applicable). For example, it could be an identification key, acknowledgement code, or any other relevant identifier.</value>
        /// <example>IdentificativoSdI</example>
        [DataMember(Name = "responseKey", EmitDefaultValue = true)]
        public string ResponseKey { get; set; }

        /// <summary>
        /// The corresponding value associated with the response key. This value is provided by the tax authority in response to the event.
        /// </summary>
        /// <value>The corresponding value associated with the response key. This value is provided by the tax authority in response to the event.</value>
        /// <example>2865701</example>
        [DataMember(Name = "responseValue", EmitDefaultValue = true)]
        public string ResponseValue { get; set; }

        /// <summary>
        /// Represents the functional area or process stage where the status event occurred. Useful for grouping related events such as document processing, transmission, or validation.
        /// </summary>
        /// <value>Represents the functional area or process stage where the status event occurred. Useful for grouping related events such as document processing, transmission, or validation.</value>
        /// <example>DocumentProcessing</example>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatusEvent {\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ResponseKey: ").Append(ResponseKey).Append("\n");
            sb.Append("  ResponseValue: ").Append(ResponseValue).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
