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
    /// Resource data model for inititating a download job for 1099 forms.
    /// </summary>
    [DataContract(Name = "InitiateDownloadInputModel")]
    public partial class InitiateDownloadInputModel : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Form1099nec for value: form1099nec
            /// </summary>
            [EnumMember(Value = "form1099nec")]
            Form1099nec = 1,

            /// <summary>
            /// Enum Form1099misc for value: form1099misc
            /// </summary>
            [EnumMember(Value = "form1099misc")]
            Form1099misc = 2
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>form1099nec</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Defines PostalMailStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PostalMailStatusEnum
        {
            /// <summary>
            /// Enum Unscheduled for value: unscheduled
            /// </summary>
            [EnumMember(Value = "unscheduled")]
            Unscheduled = 1,

            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled = 2,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 3,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 4
        }


        /// <summary>
        /// Gets or Sets PostalMailStatus
        /// </summary>
        /// <example>delivered</example>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = false)]
        public PostalMailStatusEnum? PostalMailStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateDownloadInputModel" /> class.
        /// </summary>
        /// <param name="issuerId">The ID of the issuer..</param>
        /// <param name="issuerReferenceId">A unique reference ID of the issuer.</param>
        /// <param name="taxYear">The tax year for the form..</param>
        /// <param name="referenceId">Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces..</param>
        /// <param name="federalEfileStatus">federalEfileStatus.</param>
        /// <param name="postalMailStatus">postalMailStatus.</param>
        /// <param name="stateEfileStatus">stateEfileStatus.</param>
        /// <param name="tinMatchStatus">tinMatchStatus.</param>
        /// <param name="addressVerificationStatus">addressVerificationStatus.</param>
        /// <param name="recipientName">Legal name of the recipient.</param>
        /// <param name="recipientEmail">The email address of the recipient..</param>
        /// <param name="recipientFederalIdNo">The federal ID number of the recipient..</param>
        public InitiateDownloadInputModel(string issuerId = default(string), string issuerReferenceId = default(string), int taxYear = default(int), string referenceId = default(string), Form1099BaseModelFederalEfileStatus federalEfileStatus = default(Form1099BaseModelFederalEfileStatus), PostalMailStatusEnum? postalMailStatus = default(PostalMailStatusEnum?), InitiateDownloadInputModelStateEfileStatus stateEfileStatus = default(InitiateDownloadInputModelStateEfileStatus), TinMatchStatus tinMatchStatus = default(TinMatchStatus), AddressVerificationStatus addressVerificationStatus = default(AddressVerificationStatus), string recipientName = default(string), string recipientEmail = default(string), string recipientFederalIdNo = default(string))
        {
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.FederalEfileStatus = federalEfileStatus;
            this.PostalMailStatus = postalMailStatus;
            this.StateEfileStatus = stateEfileStatus;
            this.TinMatchStatus = tinMatchStatus;
            this.AddressVerificationStatus = addressVerificationStatus;
            this.RecipientName = recipientName;
            this.RecipientEmail = recipientEmail;
            this.RecipientFederalIdNo = recipientFederalIdNo;
        }

        /// <summary>
        /// The ID of the issuer.
        /// </summary>
        /// <value>The ID of the issuer.</value>
        [DataMember(Name = "issuerId", EmitDefaultValue = false)]
        public string IssuerId { get; set; }

        /// <summary>
        /// A unique reference ID of the issuer
        /// </summary>
        /// <value>A unique reference ID of the issuer</value>
        /// <example>C-935801</example>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = false)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// The tax year for the form.
        /// </summary>
        /// <value>The tax year for the form.</value>
        /// <example>2024</example>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.
        /// </summary>
        /// <value>Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.</value>
        /// <example>B-10001</example>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets FederalEfileStatus
        /// </summary>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = true)]
        public Form1099BaseModelFederalEfileStatus FederalEfileStatus { get; set; }

        /// <summary>
        /// Gets or Sets StateEfileStatus
        /// </summary>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public InitiateDownloadInputModelStateEfileStatus StateEfileStatus { get; set; }

        /// <summary>
        /// Gets or Sets TinMatchStatus
        /// </summary>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public TinMatchStatus TinMatchStatus { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerificationStatus
        /// </summary>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public AddressVerificationStatus AddressVerificationStatus { get; set; }

        /// <summary>
        /// Legal name of the recipient
        /// </summary>
        /// <value>Legal name of the recipient</value>
        /// <example>Jane Smith</example>
        [DataMember(Name = "recipientName", EmitDefaultValue = false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// The email address of the recipient.
        /// </summary>
        /// <value>The email address of the recipient.</value>
        /// <example>corey.green@example.com</example>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = false)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// The federal ID number of the recipient.
        /// </summary>
        /// <value>The federal ID number of the recipient.</value>
        /// <example>555-55-2222</example>
        [DataMember(Name = "recipientFederalIdNo", EmitDefaultValue = false)]
        public string RecipientFederalIdNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InitiateDownloadInputModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  RecipientFederalIdNo: ").Append(RecipientFederalIdNo).Append("\n");
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
            // IssuerReferenceId (string) maxLength
            if (this.IssuerReferenceId != null && this.IssuerReferenceId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for IssuerReferenceId, length must be less than 50.", new [] { "IssuerReferenceId" });
            }

            if (this.IssuerReferenceId != null) {
                // IssuerReferenceId (string) pattern
                Regex regexIssuerReferenceId = new Regex(@"[a-z\d\-_ ]*", RegexOptions.CultureInvariant);
                if (!regexIssuerReferenceId.Match(this.IssuerReferenceId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerReferenceId, must match a pattern of " + regexIssuerReferenceId, new [] { "IssuerReferenceId" });
                }
            }

            // ReferenceId (string) maxLength
            if (this.ReferenceId != null && this.ReferenceId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ReferenceId, length must be less than 50.", new [] { "ReferenceId" });
            }

            if (this.ReferenceId != null) {
                // ReferenceId (string) pattern
                Regex regexReferenceId = new Regex(@"[a-z\d\-_ ]*", RegexOptions.CultureInvariant);
                if (!regexReferenceId.Match(this.ReferenceId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceId, must match a pattern of " + regexReferenceId, new [] { "ReferenceId" });
                }
            }

            // RecipientName (string) maxLength
            if (this.RecipientName != null && this.RecipientName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for RecipientName, length must be less than 40.", new [] { "RecipientName" });
            }

            // RecipientName (string) minLength
            if (this.RecipientName != null && this.RecipientName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for RecipientName, length must be greater than 1.", new [] { "RecipientName" });
            }

            if (this.RecipientEmail != null) {
                // RecipientEmail (string) pattern
                Regex regexRecipientEmail = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,3}){1,2}", RegexOptions.CultureInvariant);
                if (!regexRecipientEmail.Match(this.RecipientEmail).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientEmail, must match a pattern of " + regexRecipientEmail, new [] { "RecipientEmail" });
                }
            }

            yield break;
        }
    }
}
