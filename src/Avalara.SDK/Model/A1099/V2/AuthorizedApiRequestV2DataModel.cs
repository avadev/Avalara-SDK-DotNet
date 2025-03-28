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
    /// Describes a one-time-use URL that, when accessed, executes the API request specified in path using the account and credentials you used to create this AuthorizedApiRequest
    /// </summary>
    [DataContract(Name = "AuthorizedApiRequestV2DataModel")]
    public partial class AuthorizedApiRequestV2DataModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedApiRequestV2DataModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="path">The path and query of the API request you want to pre-authorize.</param>
        /// <param name="expiresAt">Timestamp when this AuthorizedApiRequest will expire, ttl (or 3600) seconds from creation.</param>
        public AuthorizedApiRequestV2DataModel(string id = default(string), string path = default(string), string expiresAt = default(string))
        {
            this.Id = id;
            this.Path = path;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>d0d09a2f-619e-4e9d-aae4-3311d9e0c67c</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The path and query of the API request you want to pre-authorize
        /// </summary>
        /// <value>The path and query of the API request you want to pre-authorize</value>
        /// <example>form-pdf?filter[form_type_eq]&#x3D;1099-NEC&amp;filter[reference_id_eq]&#x3D;SE-02453450&amp;filter[tax_year_eq]&#x3D;2024</example>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Timestamp when this AuthorizedApiRequest will expire, ttl (or 3600) seconds from creation
        /// </summary>
        /// <value>Timestamp when this AuthorizedApiRequest will expire, ttl (or 3600) seconds from creation</value>
        /// <example>2022-04-29T15:19:42.995-04:00</example>
        [DataMember(Name = "expiresAt", EmitDefaultValue = true)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizedApiRequestV2DataModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
