/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 & W-9 API Definition
 *
 * ## Authentication  #### Step 1: Generate API Credentials  Generate a *client ID* and *client secret* from your [Avalara1099 account](https://sbx.track1099.com/api_tokens): *Your Profile → API*.  #### Step 2: Get an Identity Token  Send a `POST` request to the **Identity Token URL** with your *client ID* and *client secret* from Step 1 as form-encoded parameters:  ```http POST https://identity.avalara.com/connect/token Content-Type: application/x-www-form-urlencoded  grant_type=client_credentials client_id=<your client ID> client_secret=<your client secret> ```  **Body parameters** - `grant_type` — Always `client_credentials` - `client_id` — Your *client ID* from Step 1 - `client_secret` — Your *client secret* from Step 1  **Successful response**  ```json {   \"access_token\": \"eyJhbGci...\",   \"expires_in\": 3600,   \"token_type\": \"Bearer\" } ```  Use the `access_token` as a bearer token in the `Authorization` header on every A1099 API request:  ```http Authorization: Bearer <access_token> ```  - --  For more on authenticating requests, see the [A1099 authentication guide](https://developer.avalara.com/1099-and-w-9/kny2997001535374/).  - --  ## Environments  #### Production - **Avalara 1099 API URL:** [`https://api.avalara.com/avalara1099`](https://api.avalara.com/avalara1099) - **Identity Token URL:** [`https://identity.avalara.com/connect/token`](https://identity.avalara.com/connect/token)  #### Sandbox - **Avalara 1099 API URL:** [`https://api.sbx.avalara.com/avalara1099`](https://api.sbx.avalara.com/avalara1099) - **Identity Token URL:** [`https://ai-sbx.avlr.sh/connect/token`](https://ai-sbx.avlr.sh/connect/token)  - --  ## API & SDK Documentation  [Avalara 1099 API Reference](https://developer.avalara.com/api-reference/avalara1099/avalara1099/)  [Avalara SDKs](https://developer.avalara.com/sdk/)  [Swagger](https://api.avalara.com/avalara1099/swagger/index.html?api-version=2.0)
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
    /// Form1099ListRequest
    /// </summary>
    [DataContract(Name = "Form1099ListRequest")]
    public partial class Form1099ListRequest : IValidatableObject
    {
        /// <summary>
        /// Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; 
        /// </summary>
        /// <value>Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum _1042S for value: 1042-S
            /// </summary>
            [EnumMember(Value = "1042-S")]
            _1042S = 1,

            /// <summary>
            /// Enum _1095B for value: 1095-B
            /// </summary>
            [EnumMember(Value = "1095-B")]
            _1095B = 2,

            /// <summary>
            /// Enum _1095C for value: 1095-C
            /// </summary>
            [EnumMember(Value = "1095-C")]
            _1095C = 3,

            /// <summary>
            /// Enum _1099DIV for value: 1099-DIV
            /// </summary>
            [EnumMember(Value = "1099-DIV")]
            _1099DIV = 4,

            /// <summary>
            /// Enum _1099INT for value: 1099-INT
            /// </summary>
            [EnumMember(Value = "1099-INT")]
            _1099INT = 5,

            /// <summary>
            /// Enum _1099K for value: 1099-K
            /// </summary>
            [EnumMember(Value = "1099-K")]
            _1099K = 6,

            /// <summary>
            /// Enum _1099MISC for value: 1099-MISC
            /// </summary>
            [EnumMember(Value = "1099-MISC")]
            _1099MISC = 7,

            /// <summary>
            /// Enum _1099NEC for value: 1099-NEC
            /// </summary>
            [EnumMember(Value = "1099-NEC")]
            _1099NEC = 8,

            /// <summary>
            /// Enum _1099R for value: 1099-R
            /// </summary>
            [EnumMember(Value = "1099-R")]
            _1099R = 9,

            /// <summary>
            /// Enum W2 for value: W-2
            /// </summary>
            [EnumMember(Value = "W-2")]
            W2 = 10
        }


        /// <summary>
        /// Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; 
        /// </summary>
        /// <value>Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; </value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListRequest" /> class.
        /// </summary>
        /// <param name="type">Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; .</param>
        /// <param name="forms">forms.</param>
        public Form1099ListRequest(TypeEnum? type = default(TypeEnum?), List<Get1099Form200Response> forms = default(List<Get1099Form200Response>))
        {
            this.Type = type;
            this.Forms = forms;
        }

        /// <summary>
        /// Gets or Sets Forms
        /// </summary>
        [DataMember(Name = "forms", EmitDefaultValue = false)]
        public List<Get1099Form200Response> Forms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099ListRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
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
