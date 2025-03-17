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
 * This is the API specification for Avalara's Track 1099 service, based on the OpenAPI 3.0 standard. The API allows users to manage and track 1099 tax forms efficiently. This is the specification for the Avalara 1099 & W9 API. Some overall notes about the API:  - The API generally follows the [JSON:API](https://jsonapi.org/) specification. - Authentication is done by including an API **Bearer** token in the **Authorization** header (API tokens can be generated from your [profile page](https://www.track1099.com/api_tokens) when logged into the application). - The maximum request size allowed is **100MB**.  [Find out more about Avalara](https://www.avalara.com)
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

namespace Avalara.SDK.Model.Track1099.V2
{
/// <summary>
    /// FormRequestModel
    /// </summary>
    [DataContract(Name = "FormRequestModel")]
    public partial class FormRequestModel : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FormRequest for value: FormRequest
            /// </summary>
            [EnumMember(Value = "FormRequest")]
            FormRequest = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// \&quot;W9\&quot; is currently the only supported value
        /// </summary>
        /// <value>\&quot;W9\&quot; is currently the only supported value</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormTypeEnum
        {
            /// <summary>
            /// Enum W9 for value: W9
            /// </summary>
            [EnumMember(Value = "W9")]
            W9 = 1
        }


        /// <summary>
        /// \&quot;W9\&quot; is currently the only supported value
        /// </summary>
        /// <value>\&quot;W9\&quot; is currently the only supported value</value>
        /// <example>0</example>
        [DataMember(Name = "formType", EmitDefaultValue = false)]
        public FormTypeEnum? FormType { get; set; }
        /// <summary>
        /// Result of IRS TIN match query for name and TIN in the last signed form, null if signed_at is null
        /// </summary>
        /// <value>Result of IRS TIN match query for name and TIN in the last signed form, null if signed_at is null</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TinMatchStatusEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Matched for value: Matched
            /// </summary>
            [EnumMember(Value = "Matched")]
            Matched = 2
        }


        /// <summary>
        /// Result of IRS TIN match query for name and TIN in the last signed form, null if signed_at is null
        /// </summary>
        /// <value>Result of IRS TIN match query for name and TIN in the last signed form, null if signed_at is null</value>
        /// <example>1</example>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = false)]
        public TinMatchStatusEnum? TinMatchStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRequestModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="formType">\&quot;W9\&quot; is currently the only supported value.</param>
        /// <param name="companyId">Track1099&#39;s ID of your company, found in the W-9 UI.</param>
        /// <param name="companyName">Name of your company, set in the W-9 UI.</param>
        /// <param name="companyEmail">Contact email of your company, set in the W-9 UI.</param>
        /// <param name="referenceId">Your internal identifier for the vendor from whom you are requesting a form.</param>
        /// <param name="signedAt">The timestamp this vendor (identified by your ReferenceId) last signed a complete W-9, null if you did not include a ReferenceId or the vendor has not yet signed a W-9 in Track1099.</param>
        /// <param name="tinMatchStatus">Result of IRS TIN match query for name and TIN in the last signed form, null if signed_at is null.</param>
        /// <param name="expiresAt">Timestamp when this FormRequest will expire, ttl (or 3600) seconds from creation.</param>
        /// <param name="signedPdf">URL of PDF representation of just-signed form, otherwise null. Integrations may use this value to offer a \&quot;download for your records\&quot; function after a vendor completes and signs a form. Link expires at the same time as this FormRequest. Treat the format of this URL as opaque and expect it to change in the future..</param>
        public FormRequestModel(string id = default(string), TypeEnum? type = default(TypeEnum?), FormTypeEnum? formType = default(FormTypeEnum?), int companyId = default(int), string companyName = default(string), string companyEmail = default(string), string referenceId = default(string), DateTime signedAt = default(DateTime), TinMatchStatusEnum? tinMatchStatus = default(TinMatchStatusEnum?), DateTime expiresAt = default(DateTime), string signedPdf = default(string))
        {
            this.Id = id;
            this.Type = type;
            this.FormType = formType;
            this.CompanyId = companyId;
            this.CompanyName = companyName;
            this.CompanyEmail = companyEmail;
            this.ReferenceId = referenceId;
            this.SignedAt = signedAt;
            this.TinMatchStatus = tinMatchStatus;
            this.ExpiresAt = expiresAt;
            this.SignedPdf = signedPdf;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>d0d09a2f-619e-4e9d-aae4-3311d9e0c67c</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Track1099&#39;s ID of your company, found in the W-9 UI
        /// </summary>
        /// <value>Track1099&#39;s ID of your company, found in the W-9 UI</value>
        /// <example>2345678</example>
        [DataMember(Name = "companyId", EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// Name of your company, set in the W-9 UI
        /// </summary>
        /// <value>Name of your company, set in the W-9 UI</value>
        /// <example>ACME Corp</example>
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Contact email of your company, set in the W-9 UI
        /// </summary>
        /// <value>Contact email of your company, set in the W-9 UI</value>
        /// <example>roadrunner@acmecorp.com</example>
        [DataMember(Name = "companyEmail", EmitDefaultValue = true)]
        public string CompanyEmail { get; set; }

        /// <summary>
        /// Your internal identifier for the vendor from whom you are requesting a form
        /// </summary>
        /// <value>Your internal identifier for the vendor from whom you are requesting a form</value>
        /// <example>SE-02453450</example>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The timestamp this vendor (identified by your ReferenceId) last signed a complete W-9, null if you did not include a ReferenceId or the vendor has not yet signed a W-9 in Track1099
        /// </summary>
        /// <value>The timestamp this vendor (identified by your ReferenceId) last signed a complete W-9, null if you did not include a ReferenceId or the vendor has not yet signed a W-9 in Track1099</value>
        /// <example>2022-04-29T15:19:42Z</example>
        [DataMember(Name = "signedAt", EmitDefaultValue = false)]
        public DateTime SignedAt { get; set; }

        /// <summary>
        /// Timestamp when this FormRequest will expire, ttl (or 3600) seconds from creation
        /// </summary>
        /// <value>Timestamp when this FormRequest will expire, ttl (or 3600) seconds from creation</value>
        /// <example>2022-04-29T15:19:42Z</example>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// URL of PDF representation of just-signed form, otherwise null. Integrations may use this value to offer a \&quot;download for your records\&quot; function after a vendor completes and signs a form. Link expires at the same time as this FormRequest. Treat the format of this URL as opaque and expect it to change in the future.
        /// </summary>
        /// <value>URL of PDF representation of just-signed form, otherwise null. Integrations may use this value to offer a \&quot;download for your records\&quot; function after a vendor completes and signs a form. Link expires at the same time as this FormRequest. Treat the format of this URL as opaque and expect it to change in the future.</value>
        [DataMember(Name = "signedPdf", EmitDefaultValue = true)]
        public string SignedPdf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FormRequestModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FormType: ").Append(FormType).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyEmail: ").Append(CompanyEmail).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  SignedAt: ").Append(SignedAt).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  SignedPdf: ").Append(SignedPdf).Append("\n");
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
