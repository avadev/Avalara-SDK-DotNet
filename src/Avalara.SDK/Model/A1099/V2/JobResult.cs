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
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// JobResult
    /// </summary>
    [DataContract(Name = "JobResult")]
    public partial class JobResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobResult" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="dryRun">dryRun.</param>
        /// <param name="upsert">upsert.</param>
        /// <param name="status">status.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="totalProcessed">totalProcessed.</param>
        /// <param name="totalRows">totalRows.</param>
        /// <param name="updatedValid">updatedValid.</param>
        /// <param name="updatedNoEmail">updatedNoEmail.</param>
        /// <param name="updatedInvalid">updatedInvalid.</param>
        /// <param name="skippedDuplicate">skippedDuplicate.</param>
        /// <param name="skippedInvalid">skippedInvalid.</param>
        /// <param name="skippedMultipleMatches">skippedMultipleMatches.</param>
        /// <param name="notFound">notFound.</param>
        /// <param name="createdInvalid">createdInvalid.</param>
        /// <param name="createdNoEmail">createdNoEmail.</param>
        /// <param name="createdValid">createdValid.</param>
        public JobResult(string id = default(string), string type = default(string), bool dryRun = default(bool), bool upsert = default(bool), string status = default(string), string errorMessage = default(string), int totalProcessed = default(int), int totalRows = default(int), int updatedValid = default(int), int updatedNoEmail = default(int), int updatedInvalid = default(int), int skippedDuplicate = default(int), int skippedInvalid = default(int), int skippedMultipleMatches = default(int), int notFound = default(int), int createdInvalid = default(int), int createdNoEmail = default(int), int createdValid = default(int))
        {
            this.Id = id;
            this.Type = type;
            this.DryRun = dryRun;
            this.Upsert = upsert;
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
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DryRun
        /// </summary>
        [DataMember(Name = "dryRun", EmitDefaultValue = true)]
        public bool DryRun { get; set; }

        /// <summary>
        /// Gets or Sets Upsert
        /// </summary>
        [DataMember(Name = "upsert", EmitDefaultValue = true)]
        public bool Upsert { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets TotalProcessed
        /// </summary>
        [DataMember(Name = "totalProcessed", EmitDefaultValue = false)]
        public int TotalProcessed { get; set; }

        /// <summary>
        /// Gets or Sets TotalRows
        /// </summary>
        [DataMember(Name = "totalRows", EmitDefaultValue = false)]
        public int TotalRows { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedValid
        /// </summary>
        [DataMember(Name = "updatedValid", EmitDefaultValue = false)]
        public int UpdatedValid { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedNoEmail
        /// </summary>
        [DataMember(Name = "updatedNoEmail", EmitDefaultValue = false)]
        public int UpdatedNoEmail { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedInvalid
        /// </summary>
        [DataMember(Name = "updatedInvalid", EmitDefaultValue = false)]
        public int UpdatedInvalid { get; set; }

        /// <summary>
        /// Gets or Sets SkippedDuplicate
        /// </summary>
        [DataMember(Name = "skippedDuplicate", EmitDefaultValue = false)]
        public int SkippedDuplicate { get; set; }

        /// <summary>
        /// Gets or Sets SkippedInvalid
        /// </summary>
        [DataMember(Name = "skippedInvalid", EmitDefaultValue = false)]
        public int SkippedInvalid { get; set; }

        /// <summary>
        /// Gets or Sets SkippedMultipleMatches
        /// </summary>
        [DataMember(Name = "skippedMultipleMatches", EmitDefaultValue = false)]
        public int SkippedMultipleMatches { get; set; }

        /// <summary>
        /// Gets or Sets NotFound
        /// </summary>
        [DataMember(Name = "notFound", EmitDefaultValue = false)]
        public int NotFound { get; set; }

        /// <summary>
        /// Gets or Sets CreatedInvalid
        /// </summary>
        [DataMember(Name = "createdInvalid", EmitDefaultValue = false)]
        public int CreatedInvalid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedNoEmail
        /// </summary>
        [DataMember(Name = "createdNoEmail", EmitDefaultValue = false)]
        public int CreatedNoEmail { get; set; }

        /// <summary>
        /// Gets or Sets CreatedValid
        /// </summary>
        [DataMember(Name = "createdValid", EmitDefaultValue = false)]
        public int CreatedValid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  Upsert: ").Append(Upsert).Append("\n");
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
