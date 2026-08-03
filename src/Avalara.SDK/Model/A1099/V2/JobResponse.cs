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
    /// Response model for job operations
    /// </summary>
    [DataContract(Name = "JobResponse")]
    public partial class JobResponse : IValidatableObject
    {
        /// <summary>
        /// Current status of the job (e.g., Success, Failed, InProgress)
        /// </summary>
        /// <value>Current status of the job (e.g., Success, Failed, InProgress)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 1,

            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 2,

            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 3
        }


        /// <summary>
        /// Current status of the job (e.g., Success, Failed, InProgress)
        /// </summary>
        /// <value>Current status of the job (e.g., Success, Failed, InProgress)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobResponse" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for the job.</param>
        /// <param name="type">Job type identifier. Will always be \&quot;update_job\&quot; for bulk upsert operations.</param>
        /// <param name="status">Current status of the job (e.g., Success, Failed, InProgress).</param>
        /// <param name="errorMessage">Error message if the job failed, null otherwise.</param>
        /// <param name="totalProcessed">Total number of forms processed. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="totalRows">Total number of forms in the request. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="updatedValid">Number of forms updated and valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="updatedNoEmail">Number of forms updated and valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="updatedInvalid">Number of forms updated but invalid for e-filing. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="skippedDuplicate">Number of forms skipped because they would have updated a record already updated once in the request. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="skippedInvalid">Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing, or because you do not have permission to update forms that have been scheduled. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="skippedMultipleMatches">Number of forms skipped because they matched multiple forms. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="notFound">Number of forms skipped because no matching form or issuer could be found. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="createdInvalid">Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="createdNoEmail">Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="createdValid">Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available.</param>
        /// <param name="dryRun">Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them..</param>
        /// <param name="upsert">Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order: Form ID, Form Reference ID and tax year, Form TIN and tax year..</param>
        /// <param name="link">Link to access the job details.</param>
        /// <param name="processedForms">List of processed forms returned when bulk-upsert processes ≤1000 records. Same format as GET /1099/forms response. Only available in bulk-upsert endpoint responses..</param>
        public JobResponse(string id = default(string), string type = default(string), StatusEnum? status = default(StatusEnum?), string errorMessage = default(string), int totalProcessed = default(int), int totalRows = default(int), int updatedValid = default(int), int updatedNoEmail = default(int), int updatedInvalid = default(int), int skippedDuplicate = default(int), int skippedInvalid = default(int), int skippedMultipleMatches = default(int), int notFound = default(int), int createdInvalid = default(int), int createdNoEmail = default(int), int createdValid = default(int), bool dryRun = default(bool), bool upsert = default(bool), string link = default(string), List<Get1099Form200Response> processedForms = default(List<Get1099Form200Response>))
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.TotalProcessed = totalProcessed;
            this.TotalRows = totalRows;
            this.UpdatedValid = updatedValid;
            this.UpdatedNoEmail = updatedNoEmail;
            this.UpdatedInvalid = updatedInvalid;
            this.SkippedDuplicate = skippedDuplicate;
            this.SkippedInvalid = skippedInvalid;
            this.SkippedMultipleMatches = skippedMultipleMatches;
            this.NotFound = notFound;
            this.CreatedInvalid = createdInvalid;
            this.CreatedNoEmail = createdNoEmail;
            this.CreatedValid = createdValid;
            this.DryRun = dryRun;
            this.Upsert = upsert;
            this.Link = link;
            this.ProcessedForms = processedForms;
        }

        /// <summary>
        /// Unique identifier for the job
        /// </summary>
        /// <value>Unique identifier for the job</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Job type identifier. Will always be \&quot;update_job\&quot; for bulk upsert operations
        /// </summary>
        /// <value>Job type identifier. Will always be \&quot;update_job\&quot; for bulk upsert operations</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Error message if the job failed, null otherwise
        /// </summary>
        /// <value>Error message if the job failed, null otherwise</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Total number of forms processed. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Total number of forms processed. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "totalProcessed", EmitDefaultValue = false)]
        public int TotalProcessed { get; set; }

        /// <summary>
        /// Total number of forms in the request. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Total number of forms in the request. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "totalRows", EmitDefaultValue = false)]
        public int TotalRows { get; set; }

        /// <summary>
        /// Number of forms updated and valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms updated and valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "updatedValid", EmitDefaultValue = false)]
        public int UpdatedValid { get; set; }

        /// <summary>
        /// Number of forms updated and valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms updated and valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "updatedNoEmail", EmitDefaultValue = false)]
        public int UpdatedNoEmail { get; set; }

        /// <summary>
        /// Number of forms updated but invalid for e-filing. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms updated but invalid for e-filing. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "updatedInvalid", EmitDefaultValue = false)]
        public int UpdatedInvalid { get; set; }

        /// <summary>
        /// Number of forms skipped because they would have updated a record already updated once in the request. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms skipped because they would have updated a record already updated once in the request. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "skippedDuplicate", EmitDefaultValue = false)]
        public int SkippedDuplicate { get; set; }

        /// <summary>
        /// Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing, or because you do not have permission to update forms that have been scheduled. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing, or because you do not have permission to update forms that have been scheduled. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "skippedInvalid", EmitDefaultValue = false)]
        public int SkippedInvalid { get; set; }

        /// <summary>
        /// Number of forms skipped because they matched multiple forms. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms skipped because they matched multiple forms. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "skippedMultipleMatches", EmitDefaultValue = false)]
        public int SkippedMultipleMatches { get; set; }

        /// <summary>
        /// Number of forms skipped because no matching form or issuer could be found. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of forms skipped because no matching form or issuer could be found. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "notFound", EmitDefaultValue = false)]
        public int NotFound { get; set; }

        /// <summary>
        /// Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "createdInvalid", EmitDefaultValue = false)]
        public int CreatedInvalid { get; set; }

        /// <summary>
        /// Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "createdNoEmail", EmitDefaultValue = false)]
        public int CreatedNoEmail { get; set; }

        /// <summary>
        /// Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available
        /// </summary>
        /// <value>Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available</value>
        [DataMember(Name = "createdValid", EmitDefaultValue = false)]
        public int CreatedValid { get; set; }

        /// <summary>
        /// Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them.
        /// </summary>
        /// <value>Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them.</value>
        [DataMember(Name = "dryRun", EmitDefaultValue = true)]
        public bool DryRun { get; set; }

        /// <summary>
        /// Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order: Form ID, Form Reference ID and tax year, Form TIN and tax year.
        /// </summary>
        /// <value>Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order: Form ID, Form Reference ID and tax year, Form TIN and tax year.</value>
        [DataMember(Name = "upsert", EmitDefaultValue = true)]
        public bool Upsert { get; set; }

        /// <summary>
        /// Link to access the job details
        /// </summary>
        /// <value>Link to access the job details</value>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// List of processed forms returned when bulk-upsert processes ≤1000 records. Same format as GET /1099/forms response. Only available in bulk-upsert endpoint responses.
        /// </summary>
        /// <value>List of processed forms returned when bulk-upsert processes ≤1000 records. Same format as GET /1099/forms response. Only available in bulk-upsert endpoint responses.</value>
        [DataMember(Name = "processedForms", EmitDefaultValue = true)]
        public List<Get1099Form200Response> ProcessedForms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  TotalProcessed: ").Append(TotalProcessed).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  UpdatedValid: ").Append(UpdatedValid).Append("\n");
            sb.Append("  UpdatedNoEmail: ").Append(UpdatedNoEmail).Append("\n");
            sb.Append("  UpdatedInvalid: ").Append(UpdatedInvalid).Append("\n");
            sb.Append("  SkippedDuplicate: ").Append(SkippedDuplicate).Append("\n");
            sb.Append("  SkippedInvalid: ").Append(SkippedInvalid).Append("\n");
            sb.Append("  SkippedMultipleMatches: ").Append(SkippedMultipleMatches).Append("\n");
            sb.Append("  NotFound: ").Append(NotFound).Append("\n");
            sb.Append("  CreatedInvalid: ").Append(CreatedInvalid).Append("\n");
            sb.Append("  CreatedNoEmail: ").Append(CreatedNoEmail).Append("\n");
            sb.Append("  CreatedValid: ").Append(CreatedValid).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  Upsert: ").Append(Upsert).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  ProcessedForms: ").Append(ProcessedForms).Append("\n");
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
