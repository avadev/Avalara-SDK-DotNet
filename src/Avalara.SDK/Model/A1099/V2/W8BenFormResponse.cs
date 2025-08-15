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
 * ## 🔐 Authentication  Generate a **license key** from: *[Avalara Portal](https://www.avalara.com/us/en/signin.html) → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// W8BenFormResponse
    /// </summary>
    [DataContract(Name = "W8BenFormResponse")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class W8BenFormResponse : W9FormBaseResponse, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="W8BenFormResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="citizenshipCountry">The country of citizenship..</param>
        /// <param name="residenceAddress">The residential address of the individual or entity..</param>
        /// <param name="residenceCity">The city of residence..</param>
        /// <param name="residenceState">The state of residence..</param>
        /// <param name="residenceZip">The ZIP code of the residence..</param>
        /// <param name="residenceCountry">The country of residence..</param>
        /// <param name="residenceIsMailing">Indicates whether the residence address is the mailing address..</param>
        /// <param name="mailingAddress">The mailing address..</param>
        /// <param name="mailingCity">The city of the mailing address..</param>
        /// <param name="mailingState">The state of the mailing address..</param>
        /// <param name="mailingZip">The ZIP code of the mailing address..</param>
        /// <param name="mailingCountry">The country of the mailing address..</param>
        /// <param name="tinType">The type of TIN provided..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="foreignTinNotRequired">Indicates whether a foreign TIN is not required..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="birthday">The birthday of the individual associated with the form..</param>
        /// <param name="treatyCountry">The country for which the treaty applies..</param>
        /// <param name="treatyArticle">The specific article of the treaty being claimed..</param>
        /// <param name="treatyReasons">The reasons for claiming treaty benefits..</param>
        /// <param name="withholdingRate">The withholding rate applied as per the treaty..</param>
        /// <param name="incomeType">The type of income covered by the treaty..</param>
        /// <param name="signerName">The name of the signer of the form..</param>
        /// <param name="signerCapacity">The capacity in which the signer is signing the form..</param>
        /// <param name="id">The unique identifier for the form..</param>
        /// <param name="entryStatus">The form status..</param>
        /// <param name="entryStatusDate">The timestamp for the latest status update..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="type">The type of the response object. (default to &quot;W8BenFormResponse&quot;).</param>
        public W8BenFormResponse(string name = default(string), string citizenshipCountry = default(string), string residenceAddress = default(string), string residenceCity = default(string), string residenceState = default(string), string residenceZip = default(string), string residenceCountry = default(string), bool residenceIsMailing = default(bool), string mailingAddress = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingZip = default(string), string mailingCountry = default(string), string tinType = default(string), string tin = default(string), bool foreignTinNotRequired = default(bool), string foreignTin = default(string), string referenceNumber = default(string), DateTime? birthday = default(DateTime?), string treatyCountry = default(string), string treatyArticle = default(string), string treatyReasons = default(string), string withholdingRate = default(string), string incomeType = default(string), string signerName = default(string), string signerCapacity = default(string), string id = default(string), string entryStatus = default(string), DateTime? entryStatusDate = default(DateTime?), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool archived = default(bool), string signature = default(string), DateTime? signedDate = default(DateTime?), DateTime? eDeliveryConsentedAt = default(DateTime?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string type = @"W8BenFormResponse") : base(id, entryStatus, entryStatusDate, referenceId, companyId, displayName, email, archived, signature, signedDate, eDeliveryConsentedAt, createdAt, updatedAt, type)
        {
            this.Name = name;
            this.CitizenshipCountry = citizenshipCountry;
            this.ResidenceAddress = residenceAddress;
            this.ResidenceCity = residenceCity;
            this.ResidenceState = residenceState;
            this.ResidenceZip = residenceZip;
            this.ResidenceCountry = residenceCountry;
            this.ResidenceIsMailing = residenceIsMailing;
            this.MailingAddress = mailingAddress;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingZip = mailingZip;
            this.MailingCountry = mailingCountry;
            this.TinType = tinType;
            this.Tin = tin;
            this.ForeignTinNotRequired = foreignTinNotRequired;
            this.ForeignTin = foreignTin;
            this.ReferenceNumber = referenceNumber;
            this.Birthday = birthday;
            this.TreatyCountry = treatyCountry;
            this.TreatyArticle = treatyArticle;
            this.TreatyReasons = treatyReasons;
            this.WithholdingRate = withholdingRate;
            this.IncomeType = incomeType;
            this.SignerName = signerName;
            this.SignerCapacity = signerCapacity;
        }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>International Trading Co.</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The country of citizenship.
        /// </summary>
        /// <value>The country of citizenship.</value>
        /// <example>US</example>
        [DataMember(Name = "citizenshipCountry", EmitDefaultValue = false)]
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        /// <example>789 Global St</example>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = false)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        /// <example>Capital City</example>
        [DataMember(Name = "residenceCity", EmitDefaultValue = false)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The state of residence.
        /// </summary>
        /// <value>The state of residence.</value>
        /// <example>DC</example>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// The ZIP code of the residence.
        /// </summary>
        /// <value>The ZIP code of the residence.</value>
        /// <example>20001</example>
        [DataMember(Name = "residenceZip", EmitDefaultValue = false)]
        public string ResidenceZip { get; set; }

        /// <summary>
        /// The country of residence.
        /// </summary>
        /// <value>The country of residence.</value>
        /// <example>US</example>
        [DataMember(Name = "residenceCountry", EmitDefaultValue = false)]
        public string ResidenceCountry { get; set; }

        /// <summary>
        /// Indicates whether the residence address is the mailing address.
        /// </summary>
        /// <value>Indicates whether the residence address is the mailing address.</value>
        /// <example>false</example>
        [DataMember(Name = "residenceIsMailing", EmitDefaultValue = true)]
        public bool ResidenceIsMailing { get; set; }

        /// <summary>
        /// The mailing address.
        /// </summary>
        /// <value>The mailing address.</value>
        /// <example>P.O. Box 456</example>
        [DataMember(Name = "mailingAddress", EmitDefaultValue = true)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// The city of the mailing address.
        /// </summary>
        /// <value>The city of the mailing address.</value>
        /// <example>Capital City</example>
        [DataMember(Name = "mailingCity", EmitDefaultValue = true)]
        public string MailingCity { get; set; }

        /// <summary>
        /// The state of the mailing address.
        /// </summary>
        /// <value>The state of the mailing address.</value>
        /// <example>DC</example>
        [DataMember(Name = "mailingState", EmitDefaultValue = true)]
        public string MailingState { get; set; }

        /// <summary>
        /// The ZIP code of the mailing address.
        /// </summary>
        /// <value>The ZIP code of the mailing address.</value>
        /// <example>20002</example>
        [DataMember(Name = "mailingZip", EmitDefaultValue = true)]
        public string MailingZip { get; set; }

        /// <summary>
        /// The country of the mailing address.
        /// </summary>
        /// <value>The country of the mailing address.</value>
        /// <example>USA</example>
        [DataMember(Name = "mailingCountry", EmitDefaultValue = true)]
        public string MailingCountry { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        /// <example>SSN</example>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        /// <example>123-45-6789</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Indicates whether a foreign TIN is not required.
        /// </summary>
        /// <value>Indicates whether a foreign TIN is not required.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignTinNotRequired", EmitDefaultValue = true)]
        public bool ForeignTinNotRequired { get; set; }

        /// <summary>
        /// The foreign taxpayer identification number (TIN).
        /// </summary>
        /// <value>The foreign taxpayer identification number (TIN).</value>
        /// <example>FTIN56789</example>
        [DataMember(Name = "foreignTin", EmitDefaultValue = true)]
        public string ForeignTin { get; set; }

        /// <summary>
        /// A reference number for the form.
        /// </summary>
        /// <value>A reference number for the form.</value>
        /// <example>W8BEN12345</example>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The birthday of the individual associated with the form.
        /// </summary>
        /// <value>The birthday of the individual associated with the form.</value>
        /// <example>Mon Oct 01 17:00:00 PDT 1990</example>
        [DataMember(Name = "birthday", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// The country for which the treaty applies.
        /// </summary>
        /// <value>The country for which the treaty applies.</value>
        /// <example>CA</example>
        [DataMember(Name = "treatyCountry", EmitDefaultValue = false)]
        public string TreatyCountry { get; set; }

        /// <summary>
        /// The specific article of the treaty being claimed.
        /// </summary>
        /// <value>The specific article of the treaty being claimed.</value>
        /// <example>Article 12</example>
        [DataMember(Name = "treatyArticle", EmitDefaultValue = true)]
        public string TreatyArticle { get; set; }

        /// <summary>
        /// The reasons for claiming treaty benefits.
        /// </summary>
        /// <value>The reasons for claiming treaty benefits.</value>
        /// <example>Reduced withholding</example>
        [DataMember(Name = "treatyReasons", EmitDefaultValue = true)]
        public string TreatyReasons { get; set; }

        /// <summary>
        /// The withholding rate applied as per the treaty.
        /// </summary>
        /// <value>The withholding rate applied as per the treaty.</value>
        /// <example>15%</example>
        [DataMember(Name = "withholdingRate", EmitDefaultValue = true)]
        public string WithholdingRate { get; set; }

        /// <summary>
        /// The type of income covered by the treaty.
        /// </summary>
        /// <value>The type of income covered by the treaty.</value>
        /// <example>Dividend</example>
        [DataMember(Name = "incomeType", EmitDefaultValue = true)]
        public string IncomeType { get; set; }

        /// <summary>
        /// The name of the signer of the form.
        /// </summary>
        /// <value>The name of the signer of the form.</value>
        /// <example>Alice Johnson</example>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// The capacity in which the signer is signing the form.
        /// </summary>
        /// <value>The capacity in which the signer is signing the form.</value>
        /// <example>Authorized Representative</example>
        [DataMember(Name = "signerCapacity", EmitDefaultValue = true)]
        public string SignerCapacity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W8BenFormResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
            sb.Append("  ResidenceCity: ").Append(ResidenceCity).Append("\n");
            sb.Append("  ResidenceState: ").Append(ResidenceState).Append("\n");
            sb.Append("  ResidenceZip: ").Append(ResidenceZip).Append("\n");
            sb.Append("  ResidenceCountry: ").Append(ResidenceCountry).Append("\n");
            sb.Append("  ResidenceIsMailing: ").Append(ResidenceIsMailing).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  MailingCity: ").Append(MailingCity).Append("\n");
            sb.Append("  MailingState: ").Append(MailingState).Append("\n");
            sb.Append("  MailingZip: ").Append(MailingZip).Append("\n");
            sb.Append("  MailingCountry: ").Append(MailingCountry).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ForeignTinNotRequired: ").Append(ForeignTinNotRequired).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  TreatyCountry: ").Append(TreatyCountry).Append("\n");
            sb.Append("  TreatyArticle: ").Append(TreatyArticle).Append("\n");
            sb.Append("  TreatyReasons: ").Append(TreatyReasons).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  IncomeType: ").Append(IncomeType).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  SignerCapacity: ").Append(SignerCapacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }
}
