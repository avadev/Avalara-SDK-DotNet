/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 API Definition
 *
 * ## Authentication Use **username/password** or **generate a license** key from: Avalara Portal → Settings → License and API Keys  More info on authentication: [Avalara Authentication Methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  Validate your credentials here: [Test Credentials](https://developer.avalara.com/avatax/test-credentials/)  ## API & SDK Docs [Avalara (C#/.NET) SDK on GitHub](https://github.com/avadev/Avalara-SDK-DotNet/tree/main#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples for 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// List1099Forms200Response
    /// </summary>
    [DataContract(Name = "List1099Forms_200_response")]
    public partial class List1099Forms200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="List1099Forms200Response" /> class.
        /// </summary>
        /// <param name="recordsetCount">recordsetCount.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="value">value.</param>
        public List1099Forms200Response(decimal recordsetCount = default(decimal), string nextLink = default(string), List<Form1099OneOf> value = default(List<Form1099OneOf>))
        {
            this.RecordsetCount = recordsetCount;
            this.NextLink = nextLink;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets RecordsetCount
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "@recordsetCount", EmitDefaultValue = false)]
        public decimal RecordsetCount { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        /// <example>https://api.avalara.com/track1099/v2/1099/issuers?filter&#x3D;&#39;taxYear eq 2024&#39;&amp;$top&#x3D;10&amp;$skip&#x3D;1&amp;$orderBy&#x3D;name&quot;</example>
        [DataMember(Name = "@nextLink", EmitDefaultValue = false)]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public List<Form1099OneOf> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class List1099Forms200Response {\n");
            sb.Append("  RecordsetCount: ").Append(RecordsetCount).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
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
