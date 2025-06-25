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
    /// W-4 Form
    /// </summary>
    [DataContract(Name = "W4FormDataModel")]
    public partial class W4FormDataModel : IValidatableObject
    {
        /// <summary>
        /// Type of the form, always W4 for this model.
        /// </summary>
        /// <value>Type of the form, always W4 for this model.</value>
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
        /// Type of the form, always W4 for this model.
        /// </summary>
        /// <value>Type of the form, always W4 for this model.</value>
        /// <example>w4</example>
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
        /// Initializes a new instance of the <see cref="W4FormDataModel" /> class.
        /// </summary>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="employeeFirstName">The first name of the employee..</param>
        /// <param name="employeeMiddleName">The middle name of the employee..</param>
        /// <param name="employeeLastName">The last name of the employee..</param>
        /// <param name="employeeNameSuffix">The name suffix of the employee..</param>
        /// <param name="address">The address of the employee..</param>
        /// <param name="city">The city of residence of the employee..</param>
        /// <param name="state">The state of residence of the employee..</param>
        /// <param name="zip">The ZIP code of residence of the employee..</param>
        /// <param name="typeOfTin">The type of TIN provided..</param>
        /// <param name="tin">The taxpayer identification number (TIN) of the employee..</param>
        /// <param name="maritalStatus">The marital status of the employee..</param>
        /// <param name="lastNameDiffers">Indicates whether the last name differs from prior records..</param>
        /// <param name="numAllowances">The number of allowances claimed by the employee..</param>
        /// <param name="otherDependents">The number of dependents other than allowances..</param>
        /// <param name="nonJobIncome">The amount of non-job income..</param>
        /// <param name="deductions">The amount of deductions claimed..</param>
        /// <param name="additionalWithheld">The additional amount withheld..</param>
        /// <param name="exemptFromWithholding">Indicates whether the employee is exempt from withholding..</param>
        /// <param name="officeCode">The office code associated with the form..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
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
        /// <param name="signature">signature.</param>
        /// <param name="mobile">mobile.</param>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="platform">platform.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="ancestorId">ancestorId.</param>
        public W4FormDataModel(DateTime? signedDate = default(DateTime?), DateTime? createdAt = default(DateTime?), string employeeFirstName = default(string), string employeeMiddleName = default(string), string employeeLastName = default(string), string employeeNameSuffix = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string typeOfTin = default(string), string tin = default(string), string maritalStatus = default(string), bool? lastNameDiffers = default(bool?), int? numAllowances = default(int?), int? otherDependents = default(int?), double? nonJobIncome = default(double?), double? deductions = default(double?), double? additionalWithheld = default(double?), bool? exemptFromWithholding = default(bool?), string officeCode = default(string), DateTime? eDeliveryConsentedAt = default(DateTime?), string id = default(string), string entryStatus = default(string), DateTime? updatedAt = default(DateTime?), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool? archived = default(bool?), DateTime? entryStatusDate = default(DateTime?), string pdfJson = default(string), string pdfVersion = default(string), string requestToken = default(string), string signature = default(string), bool? mobile = default(bool?), string appVersion = default(string), string platform = default(string), string osVersion = default(string), string ancestorId = default(string))
        {
            this.SignedDate = signedDate;
            this.CreatedAt = createdAt;
            this.EmployeeFirstName = employeeFirstName;
            this.EmployeeMiddleName = employeeMiddleName;
            this.EmployeeLastName = employeeLastName;
            this.EmployeeNameSuffix = employeeNameSuffix;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.TypeOfTin = typeOfTin;
            this.Tin = tin;
            this.MaritalStatus = maritalStatus;
            this.LastNameDiffers = lastNameDiffers;
            this.NumAllowances = numAllowances;
            this.OtherDependents = otherDependents;
            this.NonJobIncome = nonJobIncome;
            this.Deductions = deductions;
            this.AdditionalWithheld = additionalWithheld;
            this.ExemptFromWithholding = exemptFromWithholding;
            this.OfficeCode = officeCode;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
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
            this.Signature = signature;
            this.Mobile = mobile;
            this.AppVersion = appVersion;
            this.Platform = platform;
            this.OsVersion = osVersion;
            this.AncestorId = ancestorId;
        }

        /// <summary>
        /// The date the form was signed.
        /// </summary>
        /// <value>The date the form was signed.</value>
        /// <example>2022-04-29T00:00Z</example>
        [DataMember(Name = "signedDate", EmitDefaultValue = true)]
        public DateTime? SignedDate { get; set; }

        /// <summary>
        /// The creation date of the form.
        /// </summary>
        /// <value>The creation date of the form.</value>
        /// <example>2022-04-29T10:15Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        /// <value>The first name of the employee.</value>
        /// <example>Jane</example>
        [DataMember(Name = "employeeFirstName", EmitDefaultValue = true)]
        public string EmployeeFirstName { get; set; }

        /// <summary>
        /// The middle name of the employee.
        /// </summary>
        /// <value>The middle name of the employee.</value>
        /// <example>A.</example>
        [DataMember(Name = "employeeMiddleName", EmitDefaultValue = true)]
        public string EmployeeMiddleName { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        /// <value>The last name of the employee.</value>
        /// <example>Smith</example>
        [DataMember(Name = "employeeLastName", EmitDefaultValue = true)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// The name suffix of the employee.
        /// </summary>
        /// <value>The name suffix of the employee.</value>
        /// <example>Jr.</example>
        [DataMember(Name = "employeeNameSuffix", EmitDefaultValue = true)]
        public string EmployeeNameSuffix { get; set; }

        /// <summary>
        /// The address of the employee.
        /// </summary>
        /// <value>The address of the employee.</value>
        /// <example>456 Elm St</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The city of residence of the employee.
        /// </summary>
        /// <value>The city of residence of the employee.</value>
        /// <example>Springfield</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The state of residence of the employee.
        /// </summary>
        /// <value>The state of residence of the employee.</value>
        /// <example>IL</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The ZIP code of residence of the employee.
        /// </summary>
        /// <value>The ZIP code of residence of the employee.</value>
        /// <example>62704</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        [DataMember(Name = "typeOfTin", EmitDefaultValue = true)]
        public string TypeOfTin { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN) of the employee.
        /// </summary>
        /// <value>The taxpayer identification number (TIN) of the employee.</value>
        /// <example>98-7654321</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The marital status of the employee.
        /// </summary>
        /// <value>The marital status of the employee.</value>
        /// <example>Married</example>
        [DataMember(Name = "maritalStatus", EmitDefaultValue = true)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Indicates whether the last name differs from prior records.
        /// </summary>
        /// <value>Indicates whether the last name differs from prior records.</value>
        /// <example>false</example>
        [DataMember(Name = "lastNameDiffers", EmitDefaultValue = true)]
        public bool? LastNameDiffers { get; set; }

        /// <summary>
        /// The number of allowances claimed by the employee.
        /// </summary>
        /// <value>The number of allowances claimed by the employee.</value>
        /// <example>3</example>
        [DataMember(Name = "numAllowances", EmitDefaultValue = true)]
        public int? NumAllowances { get; set; }

        /// <summary>
        /// The number of dependents other than allowances.
        /// </summary>
        /// <value>The number of dependents other than allowances.</value>
        /// <example>1</example>
        [DataMember(Name = "otherDependents", EmitDefaultValue = true)]
        public int? OtherDependents { get; set; }

        /// <summary>
        /// The amount of non-job income.
        /// </summary>
        /// <value>The amount of non-job income.</value>
        /// <example>5000</example>
        [DataMember(Name = "nonJobIncome", EmitDefaultValue = true)]
        public double? NonJobIncome { get; set; }

        /// <summary>
        /// The amount of deductions claimed.
        /// </summary>
        /// <value>The amount of deductions claimed.</value>
        /// <example>2000</example>
        [DataMember(Name = "deductions", EmitDefaultValue = true)]
        public double? Deductions { get; set; }

        /// <summary>
        /// The additional amount withheld.
        /// </summary>
        /// <value>The additional amount withheld.</value>
        /// <example>150</example>
        [DataMember(Name = "additionalWithheld", EmitDefaultValue = true)]
        public double? AdditionalWithheld { get; set; }

        /// <summary>
        /// Indicates whether the employee is exempt from withholding.
        /// </summary>
        /// <value>Indicates whether the employee is exempt from withholding.</value>
        /// <example>false</example>
        [DataMember(Name = "exemptFromWithholding", EmitDefaultValue = true)]
        public bool? ExemptFromWithholding { get; set; }

        /// <summary>
        /// The office code associated with the form.
        /// </summary>
        /// <value>The office code associated with the form.</value>
        /// <example>OC12345</example>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        /// <example>2022-04-29T15:00Z</example>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

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
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

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
            sb.Append("class W4FormDataModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SignedDate: ").Append(SignedDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeMiddleName: ").Append(EmployeeMiddleName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  EmployeeNameSuffix: ").Append(EmployeeNameSuffix).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  TypeOfTin: ").Append(TypeOfTin).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  LastNameDiffers: ").Append(LastNameDiffers).Append("\n");
            sb.Append("  NumAllowances: ").Append(NumAllowances).Append("\n");
            sb.Append("  OtherDependents: ").Append(OtherDependents).Append("\n");
            sb.Append("  NonJobIncome: ").Append(NonJobIncome).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  AdditionalWithheld: ").Append(AdditionalWithheld).Append("\n");
            sb.Append("  ExemptFromWithholding: ").Append(ExemptFromWithholding).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
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
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
