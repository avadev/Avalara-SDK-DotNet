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
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// W9FormResponse
    /// </summary>
    [DataContract(Name = "W9FormResponse")]
    public partial class W9FormResponse : IValidatableObject
    {
        /// <summary>
        /// The form type (always \&quot;W9\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;W9\&quot; for this model).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum W4 for value: W4
            /// </summary>
            [EnumMember(Value = "W4")]
            W4 = 1,

            /// <summary>
            /// Enum W8Ben for value: W8Ben
            /// </summary>
            [EnumMember(Value = "W8Ben")]
            W8Ben = 2,

            /// <summary>
            /// Enum W8BenE for value: W8BenE
            /// </summary>
            [EnumMember(Value = "W8BenE")]
            W8BenE = 3,

            /// <summary>
            /// Enum W8Imy for value: W8Imy
            /// </summary>
            [EnumMember(Value = "W8Imy")]
            W8Imy = 4,

            /// <summary>
            /// Enum W9 for value: W9
            /// </summary>
            [EnumMember(Value = "W9")]
            W9 = 5
        }


        /// <summary>
        /// The form type (always \&quot;W9\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;W9\&quot; for this model).</value>
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
        /// Initializes a new instance of the <see cref="W9FormResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="businessName">The name of the business associated with the form..</param>
        /// <param name="businessClassification">The classification of the business..</param>
        /// <param name="businessOther">The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;..</param>
        /// <param name="foreignPartnerOwnerOrBeneficiary">Indicates whether the individual is a foreign partner, owner, or beneficiary..</param>
        /// <param name="exemptPayeeCode">The exempt payee code..</param>
        /// <param name="exemptFatcaCode">The exemption from FATCA reporting code..</param>
        /// <param name="foreignCountryIndicator">Indicates whether the individual or entity is in a foreign country..</param>
        /// <param name="address">The address of the individual or entity..</param>
        /// <param name="foreignAddress">The foreign address of the individual or entity..</param>
        /// <param name="city">The city of the address..</param>
        /// <param name="state">The state of the address..</param>
        /// <param name="zip">The ZIP code of the address..</param>
        /// <param name="accountNumber">The account number associated with the form..</param>
        /// <param name="tinType">Tax Identification Number (TIN) type..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="backupWithholding">Indicates whether backup withholding applies..</param>
        /// <param name="is1099able">Indicates whether the individual or entity should be issued a 1099 form..</param>
        /// <param name="tinMatchStatus">The TIN Match status from IRS..</param>
        /// <param name="id">The unique identifier for the form..</param>
        /// <param name="entryStatus">The entry status information for the form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="ancestorId">Form ID of previous version..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        public W9FormResponse(string name = default(string), string businessName = default(string), string businessClassification = default(string), string businessOther = default(string), bool foreignPartnerOwnerOrBeneficiary = default(bool), string exemptPayeeCode = default(string), string exemptFatcaCode = default(string), bool foreignCountryIndicator = default(bool), string address = default(string), string foreignAddress = default(string), string city = default(string), string state = default(string), string zip = default(string), string accountNumber = default(string), string tinType = default(string), string tin = default(string), bool backupWithholding = default(bool), bool is1099able = default(bool), TinMatchStatusResponse tinMatchStatus = default(TinMatchStatusResponse), string id = default(string), EntryStatusResponse entryStatus = default(EntryStatusResponse), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool archived = default(bool), string ancestorId = default(string), string signature = default(string), DateTime? signedDate = default(DateTime?), DateTime? eDeliveryConsentedAt = default(DateTime?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Name = name;
            this.BusinessName = businessName;
            this.BusinessClassification = businessClassification;
            this.BusinessOther = businessOther;
            this.ForeignPartnerOwnerOrBeneficiary = foreignPartnerOwnerOrBeneficiary;
            this.ExemptPayeeCode = exemptPayeeCode;
            this.ExemptFatcaCode = exemptFatcaCode;
            this.ForeignCountryIndicator = foreignCountryIndicator;
            this.Address = address;
            this.ForeignAddress = foreignAddress;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.AccountNumber = accountNumber;
            this.TinType = tinType;
            this.Tin = tin;
            this.BackupWithholding = backupWithholding;
            this.Is1099able = is1099able;
            this.TinMatchStatus = tinMatchStatus;
            this.Id = id;
            this.EntryStatus = entryStatus;
            this.ReferenceId = referenceId;
            this.CompanyId = companyId;
            this.DisplayName = displayName;
            this.Email = email;
            this.Archived = archived;
            this.AncestorId = ancestorId;
            this.Signature = signature;
            this.SignedDate = signedDate;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the business associated with the form.
        /// </summary>
        /// <value>The name of the business associated with the form.</value>
        [DataMember(Name = "businessName", EmitDefaultValue = true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// The classification of the business.
        /// </summary>
        /// <value>The classification of the business.</value>
        [DataMember(Name = "businessClassification", EmitDefaultValue = false)]
        public string BusinessClassification { get; set; }

        /// <summary>
        /// The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;.
        /// </summary>
        /// <value>The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;.</value>
        [DataMember(Name = "businessOther", EmitDefaultValue = true)]
        public string BusinessOther { get; set; }

        /// <summary>
        /// Indicates whether the individual is a foreign partner, owner, or beneficiary.
        /// </summary>
        /// <value>Indicates whether the individual is a foreign partner, owner, or beneficiary.</value>
        [DataMember(Name = "foreignPartnerOwnerOrBeneficiary", EmitDefaultValue = true)]
        public bool ForeignPartnerOwnerOrBeneficiary { get; set; }

        /// <summary>
        /// The exempt payee code.
        /// </summary>
        /// <value>The exempt payee code.</value>
        [DataMember(Name = "exemptPayeeCode", EmitDefaultValue = true)]
        public string ExemptPayeeCode { get; set; }

        /// <summary>
        /// The exemption from FATCA reporting code.
        /// </summary>
        /// <value>The exemption from FATCA reporting code.</value>
        [DataMember(Name = "exemptFatcaCode", EmitDefaultValue = true)]
        public string ExemptFatcaCode { get; set; }

        /// <summary>
        /// Indicates whether the individual or entity is in a foreign country.
        /// </summary>
        /// <value>Indicates whether the individual or entity is in a foreign country.</value>
        [DataMember(Name = "foreignCountryIndicator", EmitDefaultValue = true)]
        public bool ForeignCountryIndicator { get; set; }

        /// <summary>
        /// The address of the individual or entity.
        /// </summary>
        /// <value>The address of the individual or entity.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// The foreign address of the individual or entity.
        /// </summary>
        /// <value>The foreign address of the individual or entity.</value>
        [DataMember(Name = "foreignAddress", EmitDefaultValue = true)]
        public string ForeignAddress { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        /// <value>The city of the address.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>The state of the address.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The ZIP code of the address.
        /// </summary>
        /// <value>The ZIP code of the address.</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// The account number associated with the form.
        /// </summary>
        /// <value>The account number associated with the form.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Tax Identification Number (TIN) type.
        /// </summary>
        /// <value>Tax Identification Number (TIN) type.</value>
        [DataMember(Name = "tinType", EmitDefaultValue = false)]
        public string TinType { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        [DataMember(Name = "tin", EmitDefaultValue = false)]
        public string Tin { get; set; }

        /// <summary>
        /// Indicates whether backup withholding applies.
        /// </summary>
        /// <value>Indicates whether backup withholding applies.</value>
        [DataMember(Name = "backupWithholding", EmitDefaultValue = true)]
        public bool BackupWithholding { get; set; }

        /// <summary>
        /// Indicates whether the individual or entity should be issued a 1099 form.
        /// </summary>
        /// <value>Indicates whether the individual or entity should be issued a 1099 form.</value>
        [DataMember(Name = "is1099able", EmitDefaultValue = true)]
        public bool Is1099able { get; set; }

        /// <summary>
        /// The TIN Match status from IRS.
        /// </summary>
        /// <value>The TIN Match status from IRS.</value>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = false)]
        public TinMatchStatusResponse TinMatchStatus { get; set; }

        /// <summary>
        /// The unique identifier for the form.
        /// </summary>
        /// <value>The unique identifier for the form.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The entry status information for the form.
        /// </summary>
        /// <value>The entry status information for the form.</value>
        [DataMember(Name = "entryStatus", EmitDefaultValue = false)]
        public EntryStatusResponse EntryStatus { get; set; }

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
        [DataMember(Name = "companyId", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The display name associated with the form.
        /// </summary>
        /// <value>The display name associated with the form.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
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
        public bool Archived { get; set; }

        /// <summary>
        /// Form ID of previous version.
        /// </summary>
        /// <value>Form ID of previous version.</value>
        [DataMember(Name = "ancestorId", EmitDefaultValue = true)]
        public string AncestorId { get; set; }

        /// <summary>
        /// The signature of the form.
        /// </summary>
        /// <value>The signature of the form.</value>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

        /// <summary>
        /// The date the form was signed.
        /// </summary>
        /// <value>The date the form was signed.</value>
        [DataMember(Name = "signedDate", EmitDefaultValue = true)]
        public DateTime? SignedDate { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// The creation date of the form.
        /// </summary>
        /// <value>The creation date of the form.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last updated date of the form.
        /// </summary>
        /// <value>The last updated date of the form.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W9FormResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessClassification: ").Append(BusinessClassification).Append("\n");
            sb.Append("  BusinessOther: ").Append(BusinessOther).Append("\n");
            sb.Append("  ForeignPartnerOwnerOrBeneficiary: ").Append(ForeignPartnerOwnerOrBeneficiary).Append("\n");
            sb.Append("  ExemptPayeeCode: ").Append(ExemptPayeeCode).Append("\n");
            sb.Append("  ExemptFatcaCode: ").Append(ExemptFatcaCode).Append("\n");
            sb.Append("  ForeignCountryIndicator: ").Append(ForeignCountryIndicator).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ForeignAddress: ").Append(ForeignAddress).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BackupWithholding: ").Append(BackupWithholding).Append("\n");
            sb.Append("  Is1099able: ").Append(Is1099able).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryStatus: ").Append(EntryStatus).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  AncestorId: ").Append(AncestorId).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignedDate: ").Append(SignedDate).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
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
