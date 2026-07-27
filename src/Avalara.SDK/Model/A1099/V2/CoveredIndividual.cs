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
    /// Covered individual information for health coverage forms
    /// </summary>
    [DataContract(Name = "CoveredIndividual")]
    public partial class CoveredIndividual : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividual" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoveredIndividual() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividual" /> class.
        /// </summary>
        /// <param name="firstName">Covered individual&#39;s first name (required).</param>
        /// <param name="middleName">Covered individual&#39;s middle name.</param>
        /// <param name="lastName">Covered individual&#39;s last name (required).</param>
        /// <param name="nameSuffix">Covered individual&#39;s name suffix.</param>
        /// <param name="tin">Covered individual&#39;s Federal Tax Identification Number (TIN).. SSN or ITIN. Required unless unavailable..</param>
        /// <param name="birthDate">Covered individual&#39;s date of birth - Required when SSN is missing..</param>
        /// <param name="coveredJanuary">Coverage indicator for January.</param>
        /// <param name="coveredFebruary">Coverage indicator for February.</param>
        /// <param name="coveredMarch">Coverage indicator for March.</param>
        /// <param name="coveredApril">Coverage indicator for April.</param>
        /// <param name="coveredMay">Coverage indicator for May.</param>
        /// <param name="coveredJune">Coverage indicator for June.</param>
        /// <param name="coveredJuly">Coverage indicator for July.</param>
        /// <param name="coveredAugust">Coverage indicator for August.</param>
        /// <param name="coveredSeptember">Coverage indicator for September.</param>
        /// <param name="coveredOctober">Coverage indicator for October.</param>
        /// <param name="coveredNovember">Coverage indicator for November.</param>
        /// <param name="coveredDecember">Coverage indicator for December.</param>
        public CoveredIndividual(string firstName = default(string), string middleName = default(string), string lastName = default(string), string nameSuffix = default(string), string tin = default(string), DateTime? birthDate = default(DateTime?), bool? coveredJanuary = default(bool?), bool? coveredFebruary = default(bool?), bool? coveredMarch = default(bool?), bool? coveredApril = default(bool?), bool? coveredMay = default(bool?), bool? coveredJune = default(bool?), bool? coveredJuly = default(bool?), bool? coveredAugust = default(bool?), bool? coveredSeptember = default(bool?), bool? coveredOctober = default(bool?), bool? coveredNovember = default(bool?), bool? coveredDecember = default(bool?))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for CoveredIndividual and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for CoveredIndividual and cannot be null");
            }
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.NameSuffix = nameSuffix;
            this.Tin = tin;
            this.BirthDate = birthDate;
            this.CoveredJanuary = coveredJanuary;
            this.CoveredFebruary = coveredFebruary;
            this.CoveredMarch = coveredMarch;
            this.CoveredApril = coveredApril;
            this.CoveredMay = coveredMay;
            this.CoveredJune = coveredJune;
            this.CoveredJuly = coveredJuly;
            this.CoveredAugust = coveredAugust;
            this.CoveredSeptember = coveredSeptember;
            this.CoveredOctober = coveredOctober;
            this.CoveredNovember = coveredNovember;
            this.CoveredDecember = coveredDecember;
        }

        /// <summary>
        /// Covered individual&#39;s ID
        /// </summary>
        /// <value>Covered individual&#39;s ID</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Covered individual&#39;s first name
        /// </summary>
        /// <value>Covered individual&#39;s first name</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Covered individual&#39;s middle name
        /// </summary>
        /// <value>Covered individual&#39;s middle name</value>
        [DataMember(Name = "middleName", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Covered individual&#39;s last name
        /// </summary>
        /// <value>Covered individual&#39;s last name</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Covered individual&#39;s name suffix
        /// </summary>
        /// <value>Covered individual&#39;s name suffix</value>
        [DataMember(Name = "nameSuffix", EmitDefaultValue = true)]
        public string NameSuffix { get; set; }

        /// <summary>
        /// Covered individual&#39;s Federal Tax Identification Number (TIN).. SSN or ITIN. Required unless unavailable.
        /// </summary>
        /// <value>Covered individual&#39;s Federal Tax Identification Number (TIN).. SSN or ITIN. Required unless unavailable.</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Covered individual&#39;s date of birth - Required when SSN is missing.
        /// </summary>
        /// <value>Covered individual&#39;s date of birth - Required when SSN is missing.</value>
        [DataMember(Name = "birthDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Coverage indicator for January
        /// </summary>
        /// <value>Coverage indicator for January</value>
        [DataMember(Name = "coveredJanuary", EmitDefaultValue = true)]
        public bool? CoveredJanuary { get; set; }

        /// <summary>
        /// Coverage indicator for February
        /// </summary>
        /// <value>Coverage indicator for February</value>
        [DataMember(Name = "coveredFebruary", EmitDefaultValue = true)]
        public bool? CoveredFebruary { get; set; }

        /// <summary>
        /// Coverage indicator for March
        /// </summary>
        /// <value>Coverage indicator for March</value>
        [DataMember(Name = "coveredMarch", EmitDefaultValue = true)]
        public bool? CoveredMarch { get; set; }

        /// <summary>
        /// Coverage indicator for April
        /// </summary>
        /// <value>Coverage indicator for April</value>
        [DataMember(Name = "coveredApril", EmitDefaultValue = true)]
        public bool? CoveredApril { get; set; }

        /// <summary>
        /// Coverage indicator for May
        /// </summary>
        /// <value>Coverage indicator for May</value>
        [DataMember(Name = "coveredMay", EmitDefaultValue = true)]
        public bool? CoveredMay { get; set; }

        /// <summary>
        /// Coverage indicator for June
        /// </summary>
        /// <value>Coverage indicator for June</value>
        [DataMember(Name = "coveredJune", EmitDefaultValue = true)]
        public bool? CoveredJune { get; set; }

        /// <summary>
        /// Coverage indicator for July
        /// </summary>
        /// <value>Coverage indicator for July</value>
        [DataMember(Name = "coveredJuly", EmitDefaultValue = true)]
        public bool? CoveredJuly { get; set; }

        /// <summary>
        /// Coverage indicator for August
        /// </summary>
        /// <value>Coverage indicator for August</value>
        [DataMember(Name = "coveredAugust", EmitDefaultValue = true)]
        public bool? CoveredAugust { get; set; }

        /// <summary>
        /// Coverage indicator for September
        /// </summary>
        /// <value>Coverage indicator for September</value>
        [DataMember(Name = "coveredSeptember", EmitDefaultValue = true)]
        public bool? CoveredSeptember { get; set; }

        /// <summary>
        /// Coverage indicator for October
        /// </summary>
        /// <value>Coverage indicator for October</value>
        [DataMember(Name = "coveredOctober", EmitDefaultValue = true)]
        public bool? CoveredOctober { get; set; }

        /// <summary>
        /// Coverage indicator for November
        /// </summary>
        /// <value>Coverage indicator for November</value>
        [DataMember(Name = "coveredNovember", EmitDefaultValue = true)]
        public bool? CoveredNovember { get; set; }

        /// <summary>
        /// Coverage indicator for December
        /// </summary>
        /// <value>Coverage indicator for December</value>
        [DataMember(Name = "coveredDecember", EmitDefaultValue = true)]
        public bool? CoveredDecember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoveredIndividual {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NameSuffix: ").Append(NameSuffix).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  CoveredJanuary: ").Append(CoveredJanuary).Append("\n");
            sb.Append("  CoveredFebruary: ").Append(CoveredFebruary).Append("\n");
            sb.Append("  CoveredMarch: ").Append(CoveredMarch).Append("\n");
            sb.Append("  CoveredApril: ").Append(CoveredApril).Append("\n");
            sb.Append("  CoveredMay: ").Append(CoveredMay).Append("\n");
            sb.Append("  CoveredJune: ").Append(CoveredJune).Append("\n");
            sb.Append("  CoveredJuly: ").Append(CoveredJuly).Append("\n");
            sb.Append("  CoveredAugust: ").Append(CoveredAugust).Append("\n");
            sb.Append("  CoveredSeptember: ").Append(CoveredSeptember).Append("\n");
            sb.Append("  CoveredOctober: ").Append(CoveredOctober).Append("\n");
            sb.Append("  CoveredNovember: ").Append(CoveredNovember).Append("\n");
            sb.Append("  CoveredDecember: ").Append(CoveredDecember).Append("\n");
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
