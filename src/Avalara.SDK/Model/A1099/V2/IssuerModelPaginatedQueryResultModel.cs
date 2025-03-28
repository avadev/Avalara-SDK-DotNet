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
    /// Generic paginated model to wrap query response data
    /// </summary>
    [DataContract(Name = "IssuerModelPaginatedQueryResultModel")]
    public partial class IssuerModelPaginatedQueryResultModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerModelPaginatedQueryResultModel" /> class.
        /// </summary>
        /// <param name="recordsetCount">recordsetCount.</param>
        /// <param name="value">value.</param>
        /// <param name="nextLink">nextLink.</param>
        public IssuerModelPaginatedQueryResultModel(int recordsetCount = default(int), List<IssuerModel> value = default(List<IssuerModel>), string nextLink = default(string))
        {
            this.RecordsetCount = recordsetCount;
            this.Value = value;
            this.NextLink = nextLink;
        }

        /// <summary>
        /// Gets or Sets RecordsetCount
        /// </summary>
        [DataMember(Name = "@recordsetCount", EmitDefaultValue = false)]
        public int RecordsetCount { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        /// <example>[{&quot;name&quot;:&quot;Acme Corp&quot;,&quot;nameDba&quot;:&quot;&quot;,&quot;tin&quot;:&quot;23-8234555&quot;,&quot;referenceId&quot;:&quot;&quot;,&quot;telephone&quot;:&quot;520-555-1234&quot;,&quot;taxYear&quot;:2023,&quot;shippingCountryCode&quot;:&quot;US&quot;,&quot;email&quot;:&quot;roadrunner@acmecorp.com&quot;,&quot;address&quot;:&quot;1234 Meep Meep Blvd&quot;,&quot;city&quot;:&quot;Tucson&quot;,&quot;state&quot;:&quot;AZ&quot;,&quot;zip&quot;:&quot;85701-0001&quot;,&quot;foreignProvince&quot;:null,&quot;id&quot;:0,&quot;createdAt&quot;:&quot;0001-01-01T00:00:00&quot;,&quot;updatedAt&quot;:&quot;0001-01-01T00:00:00&quot;,&quot;userId&quot;:0}]</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<IssuerModel> Value { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name = "@nextLink", EmitDefaultValue = true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuerModelPaginatedQueryResultModel {\n");
            sb.Append("  RecordsetCount: ").Append(RecordsetCount).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
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
