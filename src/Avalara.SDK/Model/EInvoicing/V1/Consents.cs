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
    /// Consents
    /// </summary>
    [DataContract(Name = "Consents")]
    public partial class Consents : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Consents" /> class.
        /// </summary>
        /// <param name="listInAvalaraDirectory">Indicates whether the trading partner consents to being listed in the directory. If not provided in the payload, its value will default to true. (default to true).</param>
        public Consents(bool listInAvalaraDirectory = true)
        {
            this.ListInAvalaraDirectory = listInAvalaraDirectory;
        }

        /// <summary>
        /// Indicates whether the trading partner consents to being listed in the directory. If not provided in the payload, its value will default to true.
        /// </summary>
        /// <value>Indicates whether the trading partner consents to being listed in the directory. If not provided in the payload, its value will default to true.</value>
        [DataMember(Name = "listInAvalaraDirectory", EmitDefaultValue = true)]
        public bool ListInAvalaraDirectory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Consents {\n");
            sb.Append("  ListInAvalaraDirectory: ").Append(ListInAvalaraDirectory).Append("\n");
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
