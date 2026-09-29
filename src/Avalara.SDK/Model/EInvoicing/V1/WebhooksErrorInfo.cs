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
    /// Information about the error encountered
    /// </summary>
    [DataContract(Name = "WebhooksErrorInfo")]
    public partial class WebhooksErrorInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksErrorInfo" /> class.
        /// </summary>
        /// <param name="title">An identifying name for the error..</param>
        /// <param name="status">A conanoical error status..</param>
        /// <param name="detail">A detailed description of the error type..</param>
        /// <param name="instance">A detailed description of the specific error ocurrance..</param>
        public WebhooksErrorInfo(string title = default(string), string status = default(string), string detail = default(string), string instance = default(string))
        {
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.Instance = instance;
        }

        /// <summary>
        /// An identifying name for the error.
        /// </summary>
        /// <value>An identifying name for the error.</value>
        /// <example>CustomException</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// A conanoical error status.
        /// </summary>
        /// <value>A conanoical error status.</value>
        /// <example>Error</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// A detailed description of the error type.
        /// </summary>
        /// <value>A detailed description of the error type.</value>
        /// <example>Customized error detail message.</example>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// A detailed description of the specific error ocurrance.
        /// </summary>
        /// <value>A detailed description of the specific error ocurrance.</value>
        /// <example>more details</example>
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksErrorInfo {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
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
