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
    /// W9FormDataModel
    /// </summary>
    [DataContract(Name = "W9FormDataModel")]
    public partial class W9FormDataModel : IValidatableObject
    {
        /// <summary>
        /// Type of the form, always W9 for this model.
        /// </summary>
        /// <value>Type of the form, always W9 for this model.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum W9 for value: w9
            /// </summary>
            [EnumMember(Value = "w9")]
            W9 = 1,

            /// <summary>
            /// Enum W4 for value: w4
            /// </summary>
            [EnumMember(Value = "w4")]
            W4 = 2,

            /// <summary>
            /// Enum W8imy for value: w8imy
            /// </summary>
            [EnumMember(Value = "w8imy")]
            W8imy = 3,

            /// <summary>
            /// Enum W8ben for value: w8ben
            /// </summary>
            [EnumMember(Value = "w8ben")]
            W8ben = 4,

            /// <summary>
            /// Enum W8bene for value: w8bene
            /// </summary>
            [EnumMember(Value = "w8bene")]
            W8bene = 5
        }


        /// <summary>
        /// Type of the form, always W9 for this model.
        /// </summary>
        /// <value>Type of the form, always W9 for this model.</value>
        /// <example>w9</example>
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
        /// Initializes a new instance of the <see cref="W9FormDataModel" /> class.
        /// </summary>
        /// <param name="tinMatchStatus">The status of the TIN match..</param>
        /// <param name="signature">The signature itself.</param>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="businessClassification">The classification of the business..</param>
        /// <param name="businessName">The name of the business associated with the form..</param>
        /// <param name="businessOther">businessOther.</param>
        /// <param name="exemptPayeeCode">exemptPayeeCode.</param>
        /// <param name="exemptFatcaCode">exemptFatcaCode.</param>
        /// <param name="typeOfTin">The type of TIN provided..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="address">The address of the individual or entity..</param>
        /// <param name="city">The city of the address..</param>
        /// <param name="state">The state of the address..</param>
        /// <param name="zip">The ZIP code of the address..</param>
        /// <param name="accountNumber">The account number associated with the form..</param>
        /// <param name="foreignCountryIndicator">Indicates whether the individual or entity is in a foreign country..</param>
        /// <param name="foreignAddress">The foreign address of the individual or entity..</param>
        /// <param name="backupWithholding">Indicates whether backup withholding applies..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="is1099able">is1099able.</param>
        /// <param name="foreignPartnerOwnerOrBeneficiary">Indicates whether the individual is a foreign partner, owner, or beneficiary..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="id">id.</param>
        /// <param name="entryStatus">entryStatus.</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="entryStatusDate">entryStatusDate.</param>
        /// <param name="pdfJson">pdfJson.</param>
        /// <param name="pdfVersion">pdfVersion.</param>
        /// <param name="requestToken">requestToken.</param>
        /// <param name="mobile">mobile.</param>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="platform">platform.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="ancestorId">ancestorId.</param>
        public W9FormDataModel(string tinMatchStatus = default(string), string signature = default(string), DateTime? signedDate = default(DateTime?), string name = default(string), string businessClassification = default(string), string businessName = default(string), string businessOther = default(string), string exemptPayeeCode = default(string), string exemptFatcaCode = default(string), string typeOfTin = default(string), string tin = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string accountNumber = default(string), bool? foreignCountryIndicator = default(bool?), string foreignAddress = default(string), bool? backupWithholding = default(bool?), DateTime? eDeliveryConsentedAt = default(DateTime?), bool? is1099able = default(bool?), bool? foreignPartnerOwnerOrBeneficiary = default(bool?), DateTime? createdAt = default(DateTime?), string id = default(string), string entryStatus = default(string), DateTime? updatedAt = default(DateTime?), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool? archived = default(bool?), DateTime? entryStatusDate = default(DateTime?), string pdfJson = default(string), string pdfVersion = default(string), string requestToken = default(string), bool? mobile = default(bool?), string appVersion = default(string), string platform = default(string), string osVersion = default(string), string ancestorId = default(string))
        {
            this.TinMatchStatus = tinMatchStatus;
            this.Signature = signature;
            this.SignedDate = signedDate;
            this.Name = name;
            this.BusinessClassification = businessClassification;
            this.BusinessName = businessName;
            this.BusinessOther = businessOther;
            this.ExemptPayeeCode = exemptPayeeCode;
            this.ExemptFatcaCode = exemptFatcaCode;
            this.TypeOfTin = typeOfTin;
            this.Tin = tin;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.AccountNumber = accountNumber;
            this.ForeignCountryIndicator = foreignCountryIndicator;
            this.ForeignAddress = foreignAddress;
            this.BackupWithholding = backupWithholding;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.Is1099able = is1099able;
            this.ForeignPartnerOwnerOrBeneficiary = foreignPartnerOwnerOrBeneficiary;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.EntryStatus = entryStatus;
            this.UpdatedAt = updatedAt;
            this.ReferenceId = referenceId;
            this.CompanyId = companyId;
            this.DisplayName = displayName;
            this.Email = email;
            this.Archived = archived;
            this.EntryStatusDate = entryStatusDate;
            this.PdfJson = pdfJson;
            this.PdfVersion = pdfVersion;
            this.RequestToken = requestToken;
            this.Mobile = mobile;
            this.AppVersion = appVersion;
            this.Platform = platform;
            this.OsVersion = osVersion;
            this.AncestorId = ancestorId;
        }

        /// <summary>
        /// The status of the TIN match.
        /// </summary>
        /// <value>The status of the TIN match.</value>
        /// <example>Match</example>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public string TinMatchStatus { get; set; }

        /// <summary>
        /// The signature itself
        /// </summary>
        /// <value>The signature itself</value>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

        /// <summary>
        /// The date the form was signed.
        /// </summary>
        /// <value>The date the form was signed.</value>
        /// <example>2022-04-29T15:19:42Z</example>
        [DataMember(Name = "signedDate", EmitDefaultValue = true)]
        public DateTime? SignedDate { get; set; }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>John Doe</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The classification of the business.
        /// </summary>
        /// <value>The classification of the business.</value>
        /// <example>LLC</example>
        [DataMember(Name = "businessClassification", EmitDefaultValue = true)]
        public string BusinessClassification { get; set; }

        /// <summary>
        /// The name of the business associated with the form.
        /// </summary>
        /// <value>The name of the business associated with the form.</value>
        /// <example>Doe Enterprises</example>
        [DataMember(Name = "businessName", EmitDefaultValue = true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets BusinessOther
        /// </summary>
        [DataMember(Name = "businessOther", EmitDefaultValue = true)]
        public string BusinessOther { get; set; }

        /// <summary>
        /// Gets or Sets ExemptPayeeCode
        /// </summary>
        [DataMember(Name = "exemptPayeeCode", EmitDefaultValue = true)]
        public string ExemptPayeeCode { get; set; }

        /// <summary>
        /// Gets or Sets ExemptFatcaCode
        /// </summary>
        [DataMember(Name = "exemptFatcaCode", EmitDefaultValue = true)]
        public string ExemptFatcaCode { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        /// <example>EIN</example>
        [DataMember(Name = "typeOfTin", EmitDefaultValue = true)]
        public string TypeOfTin { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        /// <example>12-3456789</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The address of the individual or entity.
        /// </summary>
        /// <value>The address of the individual or entity.</value>
        /// <example>123 Main St</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        /// <value>The city of the address.</value>
        /// <example>Anytown</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>The state of the address.</value>
        /// <example>CA</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The ZIP code of the address.
        /// </summary>
        /// <value>The ZIP code of the address.</value>
        /// <example>90210</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// The account number associated with the form.
        /// </summary>
        /// <value>The account number associated with the form.</value>
        /// <example>ACC123456</example>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Indicates whether the individual or entity is in a foreign country.
        /// </summary>
        /// <value>Indicates whether the individual or entity is in a foreign country.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignCountryIndicator", EmitDefaultValue = true)]
        public bool? ForeignCountryIndicator { get; set; }

        /// <summary>
        /// The foreign address of the individual or entity.
        /// </summary>
        /// <value>The foreign address of the individual or entity.</value>
        [DataMember(Name = "foreignAddress", EmitDefaultValue = true)]
        public string ForeignAddress { get; set; }

        /// <summary>
        /// Indicates whether backup withholding applies.
        /// </summary>
        /// <value>Indicates whether backup withholding applies.</value>
        /// <example>false</example>
        [DataMember(Name = "backupWithholding", EmitDefaultValue = true)]
        public bool? BackupWithholding { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        /// <example>2022-04-29T15:19:42Z</example>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// Gets or Sets Is1099able
        /// </summary>
        [DataMember(Name = "is1099able", EmitDefaultValue = true)]
        public bool? Is1099able { get; set; }

        /// <summary>
        /// Indicates whether the individual is a foreign partner, owner, or beneficiary.
        /// </summary>
        /// <value>Indicates whether the individual is a foreign partner, owner, or beneficiary.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignPartnerOwnerOrBeneficiary", EmitDefaultValue = true)]
        public bool? ForeignPartnerOwnerOrBeneficiary { get; set; }

        /// <summary>
        /// The creation date of the form.
        /// </summary>
        /// <value>The creation date of the form.</value>
        /// <example>2022-04-29T15:19:42Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntryStatus
        /// </summary>
        [DataMember(Name = "entryStatus", EmitDefaultValue = true)]
        public string EntryStatus { get; set; }

        /// <summary>
        /// The last updated date of the form.
        /// </summary>
        /// <value>The last updated date of the form.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A reference identifier for the form.
        /// </summary>
        /// <value>A reference identifier for the form.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The ID of the associated company.
        /// </summary>
        /// <value>The ID of the associated company.</value>
        [DataMember(Name = "companyId", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The display name associated with the form.
        /// </summary>
        /// <value>The display name associated with the form.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the form is archived.
        /// </summary>
        /// <value>Indicates whether the form is archived.</value>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool? Archived { get; set; }

        /// <summary>
        /// Gets or Sets EntryStatusDate
        /// </summary>
        [DataMember(Name = "entryStatusDate", EmitDefaultValue = true)]
        public DateTime? EntryStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets PdfJson
        /// </summary>
        [DataMember(Name = "pdfJson", EmitDefaultValue = true)]
        public string PdfJson { get; set; }

        /// <summary>
        /// Gets or Sets PdfVersion
        /// </summary>
        [DataMember(Name = "pdfVersion", EmitDefaultValue = true)]
        public string PdfVersion { get; set; }

        /// <summary>
        /// Gets or Sets RequestToken
        /// </summary>
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>
        [DataMember(Name = "mobile", EmitDefaultValue = true)]
        public bool? Mobile { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name = "appVersion", EmitDefaultValue = true)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = true)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets AncestorId
        /// </summary>
        [DataMember(Name = "ancestorId", EmitDefaultValue = true)]
        public string AncestorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W9FormDataModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignedDate: ").Append(SignedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BusinessClassification: ").Append(BusinessClassification).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessOther: ").Append(BusinessOther).Append("\n");
            sb.Append("  ExemptPayeeCode: ").Append(ExemptPayeeCode).Append("\n");
            sb.Append("  ExemptFatcaCode: ").Append(ExemptFatcaCode).Append("\n");
            sb.Append("  TypeOfTin: ").Append(TypeOfTin).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ForeignCountryIndicator: ").Append(ForeignCountryIndicator).Append("\n");
            sb.Append("  ForeignAddress: ").Append(ForeignAddress).Append("\n");
            sb.Append("  BackupWithholding: ").Append(BackupWithholding).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
            sb.Append("  Is1099able: ").Append(Is1099able).Append("\n");
            sb.Append("  ForeignPartnerOwnerOrBeneficiary: ").Append(ForeignPartnerOwnerOrBeneficiary).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryStatus: ").Append(EntryStatus).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  EntryStatusDate: ").Append(EntryStatusDate).Append("\n");
            sb.Append("  PdfJson: ").Append(PdfJson).Append("\n");
            sb.Append("  PdfVersion: ").Append(PdfVersion).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  AncestorId: ").Append(AncestorId).Append("\n");
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
