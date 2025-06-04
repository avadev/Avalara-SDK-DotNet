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
    /// AuthorizedApiRequestModel
    /// </summary>
    [DataContract(Name = "AuthorizedApiRequestModel")]
    public partial class AuthorizedApiRequestModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedApiRequestModel" /> class.
        /// </summary>
        /// <param name="path">The path and query of the API request you want to pre-authorize.</param>
        /// <param name="ttl">Seconds until this AuthorizedApiRequest should expire, 3600 if omitted; values greater than 86400 will not be honored.</param>
        public AuthorizedApiRequestModel(string path = default(string), int ttl = default(int))
        {
            this.Path = path;
            this.Ttl = ttl;
        }

        /// <summary>
        /// The path and query of the API request you want to pre-authorize
        /// </summary>
        /// <value>The path and query of the API request you want to pre-authorize</value>
        /// <example>form-pdf?filter[form_type_eq]&#x3D;1099-NEC&amp;filter[reference_id_eq]&#x3D;SE-02453450&amp;filter[tax_year_eq]&#x3D;2023</example>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Seconds until this AuthorizedApiRequest should expire, 3600 if omitted; values greater than 86400 will not be honored
        /// </summary>
        /// <value>Seconds until this AuthorizedApiRequest should expire, 3600 if omitted; values greater than 86400 will not be honored</value>
        /// <example>3600</example>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizedApiRequestModel {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
