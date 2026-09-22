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
 * > **Note:** You must have an active Avalara 1099 & W-9 subscription to authenticate and use these APIs. If you don't have a subscription, please contact our [Sales team](https://www.avalara.com/us/en/products/1099/request-a-demo.html).  ## Authentication  The Avalara 1099 & W-9 API uses **Bearer Token Authentication**. To authenticate, acquire a bearer token using a **Client ID** and **Client Secret** that you generate in the Avalara 1099 & W-9 web application.  The sample cURL commands below use **production** URLs. For **sandbox**, replace them with the sandbox URLs listed in the Sandbox Environment table.  ### Option 1 — Client ID and Client Secret (recommended)  **Step 1: Create API credentials in the Avalara 1099 & W-9 web app**  For a full walkthrough, see the [Avalara 1099 & W-9 integration guide](https://developer.avalara.com/products/avalara-1099-and-w9/integration-guides/1099-and-w-9/siu2796410674799/).  > **Note:** To enable credential creation you must first enter a valid company address in **Account Settings > Account** and enable two-factor authentication in **Account Settings > Security**.  1. In Avalara 1099 & W-9, open **Account Settings** (gear icon, top-right of any page) and select **API**. 2. Click **Create new credentials** (a valid company address and 2FA are required). 3. Copy your **Client Id** and **Client Secret** securely — they will not be shown again after you leave the screen.  **Step 2: Request a bearer token**  ```bash curl -X POST 'https://identity.avalara.com/connect/token' \\   - -header 'Content-Type: application/x-www-form-urlencoded' \\   - -data-urlencode 'grant_type=client_credentials' \\   - -data-urlencode 'client_id={{client_id}}' \\   - -data-urlencode 'client_secret={{client_secret}}' ```  ### Option 2 — Account ID and License Key  If your organization already uses other Avalara products (AvaTax, CertCapture) and has access to the logged-in area of Avalara.com, you can generate the bearer token using your **Account ID** and **License Key**.  > **Note:** If you already have a license key for other Avalara products you can reuse it. Generating a new key will reset any previously created key.  1. Log in to Avalara.com. 2. Go to **Settings → License and API Keys**. 3. Click **Generate New Key**. 4. Note your **Account ID** from the Account menu.  ```bash curl -X POST 'https://identity.avalara.com/connect/token' \\   - -header 'Content-Type: application/x-www-form-urlencoded' \\   - -data-urlencode 'grant_type=client_credentials' \\   - -data-urlencode 'client_id={{accountId}}' \\   - -data-urlencode 'client_secret={{licenseKey}}' ```  ### Using and renewing the bearer token  Include the token in the `Authorization` header on every request:  ```http Authorization: Bearer {access_token} ```  Tokens expire after the number of seconds in the `expires_in` field of the token response. Your integration must renew the token before it expires.  **Example token response**  ```json {   \"access_token\": \"eyJhbGciOiJIUzI1NiIsInR5cCI...\",   \"expires_in\": 3600,   \"token_type\": \"Bearer\",   \"scope\": \"avatax_api iam-ds\" } ```  ### Sandbox Environment  Use the same steps as production, replacing the base URLs:  | Purpose | Production | Sandbox | | - -- | - -- | - -- | | Account & License Key management (web) | `https://www.avalara.com` | `https://sandbox.admin.avalara.com` | | Account & License Key management (API) | `https://rest.avatax.com` | `https://sandbox-rest.avatax.com` | | Token generation | `https://identity.avalara.com` | `https://ai-sbx.avlr.sh` |  ## Environments  #### Production - **Avalara 1099 API URL:** [`https://api.avalara.com/avalara1099`](https://api.avalara.com/avalara1099) - **Identity Token URL:** [`https://identity.avalara.com/connect/token`](https://identity.avalara.com/connect/token)  #### Sandbox - **Avalara 1099 API URL:** [`https://api.sbx.avalara.com/avalara1099`](https://api.sbx.avalara.com/avalara1099) - **Identity Token URL:** [`https://ai-sbx.avlr.sh/connect/token`](https://ai-sbx.avlr.sh/connect/token)  - --  ## API & SDK Documentation  [Avalara 1099 API Reference](https://developer.avalara.com/api-reference/avalara1099/avalara1099/)  [Avalara SDKs](https://developer.avalara.com/sdk/)  [Swagger](https://api.avalara.com/avalara1099/swagger/index.html?api-version=2.0)
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
        /// Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-PATR&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; 
        /// </summary>
        /// <value>Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-PATR&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; </value>
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
            /// Enum _1099PATR for value: 1099-PATR
            /// </summary>
            [EnumMember(Value = "1099-PATR")]
            _1099PATR = 9,

            /// <summary>
            /// Enum _1099R for value: 1099-R
            /// </summary>
            [EnumMember(Value = "1099-R")]
            _1099R = 10,

            /// <summary>
            /// Enum W2 for value: W-2
            /// </summary>
            [EnumMember(Value = "W-2")]
            W2 = 11
        }


        /// <summary>
        /// Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-PATR&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; 
        /// </summary>
        /// <value>Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-PATR&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; </value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListRequest" /> class.
        /// </summary>
        /// <param name="type">Available form types: * &#x60;1042-S&#x60; * &#x60;1095-B&#x60; * &#x60;1095-C&#x60; * &#x60;1099-DIV&#x60; * &#x60;1099-INT&#x60; * &#x60;1099-K&#x60; * &#x60;1099-MISC&#x60; * &#x60;1099-NEC&#x60; * &#x60;1099-PATR&#x60; * &#x60;1099-R&#x60; * &#x60;W-2&#x60; .</param>
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
