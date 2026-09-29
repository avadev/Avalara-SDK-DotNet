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
    /// CreateTradingPartnersBatch200Response
    /// </summary>
    [DataContract(Name = "CreateTradingPartnersBatch_200_response")]
    public partial class CreateTradingPartnersBatch200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTradingPartnersBatch200Response" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">A message indicating the result of the batch operation..</param>
        /// <param name="value">A list of trading partners successfully created..</param>
        public CreateTradingPartnersBatch200Response(string status = default(string), string message = default(string), List<CreateTradingPartnersBatch200ResponseValueInner> value = default(List<CreateTradingPartnersBatch200ResponseValueInner>))
        {
            this.Status = status;
            this.Message = message;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>Complete</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// A message indicating the result of the batch operation.
        /// </summary>
        /// <value>A message indicating the result of the batch operation.</value>
        /// <example>Batch created successfully.</example>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// A list of trading partners successfully created.
        /// </summary>
        /// <value>A list of trading partners successfully created.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<CreateTradingPartnersBatch200ResponseValueInner> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTradingPartnersBatch200Response {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
