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
    /// CreateTradingPartnersBatch200ResponseValueInner
    /// </summary>
    [DataContract(Name = "CreateTradingPartnersBatch_200_response_value_inner")]
    public partial class CreateTradingPartnersBatch200ResponseValueInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTradingPartnersBatch200ResponseValueInner" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the created trading partner..</param>
        /// <param name="index">Index number of the trading partner..</param>
        /// <param name="message">A success message for the specific created record..</param>
        public CreateTradingPartnersBatch200ResponseValueInner(string id = default(string), int index = default(int), string message = default(string))
        {
            this.Id = id;
            this.Index = index;
            this.Message = message;
        }

        /// <summary>
        /// The unique identifier of the created trading partner.
        /// </summary>
        /// <value>The unique identifier of the created trading partner.</value>
        /// <example>ec0c06dffe6166c47fccbb3e6d391920e68c333d84f2510d4df2</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Index number of the trading partner.
        /// </summary>
        /// <value>Index number of the trading partner.</value>
        /// <example>0</example>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// A success message for the specific created record.
        /// </summary>
        /// <value>A success message for the specific created record.</value>
        /// <example>Trading partner &#39;Pineapple Labs ltd&#39; created successfully.</example>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTradingPartnersBatch200ResponseValueInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
