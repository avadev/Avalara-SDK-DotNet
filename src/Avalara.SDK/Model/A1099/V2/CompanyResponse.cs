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
    /// CompanyResponse
    /// </summary>
    [DataContract(Name = "CompanyResponse")]
    public partial class CompanyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        /// <param name="name">Legal name. Not the DBA name. (required).</param>
        /// <param name="dbaName">Doing Business As (DBA) name or continuation of a long legal name..</param>
        /// <param name="email">Contact email address. For inquiries by vendors/employees. (required).</param>
        /// <param name="address">Address. (required).</param>
        /// <param name="city">City. (required).</param>
        /// <param name="state">Two-letter US state or Canadian province code (required for US/CA addresses)..</param>
        /// <param name="zip">ZIP/postal code. (required).</param>
        /// <param name="telephone">Contact phone number (must contain at least 10 digits, max 15 characters). (required).</param>
        /// <param name="tin">Federal Tax Identification Number (TIN). EIN/Tax ID (required for US companies). (required).</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient..</param>
        /// <param name="doTinMatch">Indicates whether the company authorizes IRS TIN matching..</param>
        /// <param name="groupName">Group name for organizing companies (creates or finds group by name)..</param>
        /// <param name="foreignProvince">Province or region for non-US/CA addresses..</param>
        /// <param name="countryCode">Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. (required).</param>
        /// <param name="resendRequests">Boolean to enable automatic reminder emails (default: false)..</param>
        /// <param name="resendIntervalDays">Days between reminder emails (7-365, required if resendRequests is true)..</param>
        /// <param name="maxReminderAttempts">Maximum number of reminder attempts (1-52, required if resendRequests is true)..</param>
        /// <param name="id">Unique identifier set when the record is created..</param>
        /// <param name="createdAt">Date time when the record was created..</param>
        /// <param name="updatedAt">Date time when the record was last updated..</param>
        public CompanyResponse(string name = default(string), string dbaName = default(string), string email = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string telephone = default(string), string tin = default(string), string referenceId = default(string), bool? doTinMatch = default(bool?), string groupName = default(string), string foreignProvince = default(string), string countryCode = default(string), bool? resendRequests = default(bool?), int? resendIntervalDays = default(int?), int? maxReminderAttempts = default(int?), string id = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CompanyResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for CompanyResponse and cannot be null");
            }
            this.Email = email;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CompanyResponse and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for CompanyResponse and cannot be null");
            }
            this.City = city;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for CompanyResponse and cannot be null");
            }
            this.Zip = zip;
            // to ensure "telephone" is required (not null)
            if (telephone == null)
            {
                throw new ArgumentNullException("telephone is a required property for CompanyResponse and cannot be null");
            }
            this.Telephone = telephone;
            // to ensure "tin" is required (not null)
            if (tin == null)
            {
                throw new ArgumentNullException("tin is a required property for CompanyResponse and cannot be null");
            }
            this.Tin = tin;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for CompanyResponse and cannot be null");
            }
            this.CountryCode = countryCode;
            this.DbaName = dbaName;
            this.State = state;
            this.ReferenceId = referenceId;
            this.DoTinMatch = doTinMatch;
            this.GroupName = groupName;
            this.ForeignProvince = foreignProvince;
            this.ResendRequests = resendRequests;
            this.ResendIntervalDays = resendIntervalDays;
            this.MaxReminderAttempts = maxReminderAttempts;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Legal name. Not the DBA name.
        /// </summary>
        /// <value>Legal name. Not the DBA name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Doing Business As (DBA) name or continuation of a long legal name.
        /// </summary>
        /// <value>Doing Business As (DBA) name or continuation of a long legal name.</value>
        [DataMember(Name = "dbaName", EmitDefaultValue = true)]
        public string DbaName { get; set; }

        /// <summary>
        /// Contact email address. For inquiries by vendors/employees.
        /// </summary>
        /// <value>Contact email address. For inquiries by vendors/employees.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        /// <value>Address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Two-letter US state or Canadian province code (required for US/CA addresses).
        /// </summary>
        /// <value>Two-letter US state or Canadian province code (required for US/CA addresses).</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// ZIP/postal code.
        /// </summary>
        /// <value>ZIP/postal code.</value>
        [DataMember(Name = "zip", IsRequired = true, EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Contact phone number (must contain at least 10 digits, max 15 characters).
        /// </summary>
        /// <value>Contact phone number (must contain at least 10 digits, max 15 characters).</value>
        [DataMember(Name = "telephone", IsRequired = true, EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Federal Tax Identification Number (TIN). EIN/Tax ID (required for US companies).
        /// </summary>
        /// <value>Federal Tax Identification Number (TIN). EIN/Tax ID (required for US companies).</value>
        [DataMember(Name = "tin", IsRequired = true, EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Internal reference ID. Never shown to any agency or recipient.
        /// </summary>
        /// <value>Internal reference ID. Never shown to any agency or recipient.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Indicates whether the company authorizes IRS TIN matching.
        /// </summary>
        /// <value>Indicates whether the company authorizes IRS TIN matching.</value>
        [DataMember(Name = "doTinMatch", EmitDefaultValue = true)]
        public bool? DoTinMatch { get; set; }

        /// <summary>
        /// Group name for organizing companies (creates or finds group by name).
        /// </summary>
        /// <value>Group name for organizing companies (creates or finds group by name).</value>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Province or region for non-US/CA addresses.
        /// </summary>
        /// <value>Province or region for non-US/CA addresses.</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes.
        /// </summary>
        /// <value>Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Boolean to enable automatic reminder emails (default: false).
        /// </summary>
        /// <value>Boolean to enable automatic reminder emails (default: false).</value>
        [DataMember(Name = "resendRequests", EmitDefaultValue = true)]
        public bool? ResendRequests { get; set; }

        /// <summary>
        /// Days between reminder emails (7-365, required if resendRequests is true).
        /// </summary>
        /// <value>Days between reminder emails (7-365, required if resendRequests is true).</value>
        [DataMember(Name = "resendIntervalDays", EmitDefaultValue = true)]
        public int? ResendIntervalDays { get; set; }

        /// <summary>
        /// Maximum number of reminder attempts (1-52, required if resendRequests is true).
        /// </summary>
        /// <value>Maximum number of reminder attempts (1-52, required if resendRequests is true).</value>
        [DataMember(Name = "maxReminderAttempts", EmitDefaultValue = true)]
        public int? MaxReminderAttempts { get; set; }

        /// <summary>
        /// Unique identifier set when the record is created.
        /// </summary>
        /// <value>Unique identifier set when the record is created.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Date time when the record was created.
        /// </summary>
        /// <value>Date time when the record was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date time when the record was last updated.
        /// </summary>
        /// <value>Date time when the record was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DbaName: ").Append(DbaName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  DoTinMatch: ").Append(DoTinMatch).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ResendRequests: ").Append(ResendRequests).Append("\n");
            sb.Append("  ResendIntervalDays: ").Append(ResendIntervalDays).Append("\n");
            sb.Append("  MaxReminderAttempts: ").Append(MaxReminderAttempts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
