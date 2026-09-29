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
    /// BatchSearchParticipants202Response
    /// </summary>
    [DataContract(Name = "BatchSearchParticipants_202_response")]
    public partial class BatchSearchParticipants202Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSearchParticipants202Response" /> class.
        /// </summary>
        /// <param name="id">The unique ID of the batch search..</param>
        /// <param name="status">Status of the batch search..</param>
        /// <param name="message">A message indicating that the batch search request has been accepted..</param>
        public BatchSearchParticipants202Response(string id = default(string), string status = default(string), string message = default(string))
        {
            this.Id = id;
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// The unique ID of the batch search.
        /// </summary>
        /// <value>The unique ID of the batch search.</value>
        /// <example>2f5ea4b5-4dae-445a-b3e4-9f65a61eaa99</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Status of the batch search.
        /// </summary>
        /// <value>Status of the batch search.</value>
        /// <example>Accepted for processing</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// A message indicating that the batch search request has been accepted.
        /// </summary>
        /// <value>A message indicating that the batch search request has been accepted.</value>
        /// <example>File uploaded successfully, you will be notified once the search results are ready.</example>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchSearchParticipants202Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
