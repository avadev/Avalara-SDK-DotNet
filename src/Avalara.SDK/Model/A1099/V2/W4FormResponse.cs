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
    /// W4FormResponse
    /// </summary>
    [DataContract(Name = "W4FormResponse")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class W4FormResponse : W9FormBaseResponse, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="W4FormResponse" /> class.
        /// </summary>
        /// <param name="employeeFirstName">The first name of the employee..</param>
        /// <param name="employeeMiddleName">The middle name of the employee..</param>
        /// <param name="employeeLastName">The last name of the employee..</param>
        /// <param name="employeeNameSuffix">The name suffix of the employee..</param>
        /// <param name="tinType">The type of TIN provided..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="address">The address of the employee..</param>
        /// <param name="city">The city of residence of the employee..</param>
        /// <param name="state">The state of residence of the employee..</param>
        /// <param name="zip">The ZIP code of residence of the employee..</param>
        /// <param name="maritalStatus">The marital status of the employee..</param>
        /// <param name="lastNameDiffers">Indicates whether the last name differs from prior records..</param>
        /// <param name="numAllowances">The number of allowances claimed by the employee..</param>
        /// <param name="otherDependents">The number of dependents other than allowances..</param>
        /// <param name="nonJobIncome">The amount of non-job income..</param>
        /// <param name="deductions">The amount of deductions claimed..</param>
        /// <param name="additionalWithheld">The additional amount withheld..</param>
        /// <param name="exemptFromWithholding">Indicates whether the employee is exempt from withholding..</param>
        /// <param name="officeCode">The office code associated with the form..</param>
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
        /// <param name="type">The type of the response object. (default to &quot;W4FormResponse&quot;).</param>
        public W4FormResponse(string employeeFirstName = default(string), string employeeMiddleName = default(string), string employeeLastName = default(string), string employeeNameSuffix = default(string), string tinType = default(string), string tin = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string maritalStatus = default(string), bool lastNameDiffers = default(bool), int? numAllowances = default(int?), int? otherDependents = default(int?), float? nonJobIncome = default(float?), float? deductions = default(float?), float? additionalWithheld = default(float?), bool exemptFromWithholding = default(bool), string officeCode = default(string), string id = default(string), string entryStatus = default(string), DateTime? entryStatusDate = default(DateTime?), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool archived = default(bool), string signature = default(string), DateTime? signedDate = default(DateTime?), DateTime? eDeliveryConsentedAt = default(DateTime?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string type = @"W4FormResponse") : base(id, entryStatus, entryStatusDate, referenceId, companyId, displayName, email, archived, signature, signedDate, eDeliveryConsentedAt, createdAt, updatedAt, type)
        {
            this.EmployeeFirstName = employeeFirstName;
            this.EmployeeMiddleName = employeeMiddleName;
            this.EmployeeLastName = employeeLastName;
            this.EmployeeNameSuffix = employeeNameSuffix;
            this.TinType = tinType;
            this.Tin = tin;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.MaritalStatus = maritalStatus;
            this.LastNameDiffers = lastNameDiffers;
            this.NumAllowances = numAllowances;
            this.OtherDependents = otherDependents;
            this.NonJobIncome = nonJobIncome;
            this.Deductions = deductions;
            this.AdditionalWithheld = additionalWithheld;
            this.ExemptFromWithholding = exemptFromWithholding;
            this.OfficeCode = officeCode;
        }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        /// <value>The first name of the employee.</value>
        /// <example>Jane</example>
        [DataMember(Name = "employeeFirstName", EmitDefaultValue = false)]
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
        [DataMember(Name = "employeeLastName", EmitDefaultValue = false)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// The name suffix of the employee.
        /// </summary>
        /// <value>The name suffix of the employee.</value>
        /// <example>Jr.</example>
        [DataMember(Name = "employeeNameSuffix", EmitDefaultValue = true)]
        public string EmployeeNameSuffix { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        /// <example>SSN</example>
        [DataMember(Name = "tinType", EmitDefaultValue = false)]
        public string TinType { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        /// <example>123-45-6789</example>
        [DataMember(Name = "tin", EmitDefaultValue = false)]
        public string Tin { get; set; }

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
        public bool LastNameDiffers { get; set; }

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
        public float? NonJobIncome { get; set; }

        /// <summary>
        /// The amount of deductions claimed.
        /// </summary>
        /// <value>The amount of deductions claimed.</value>
        /// <example>2000</example>
        [DataMember(Name = "deductions", EmitDefaultValue = true)]
        public float? Deductions { get; set; }

        /// <summary>
        /// The additional amount withheld.
        /// </summary>
        /// <value>The additional amount withheld.</value>
        /// <example>150</example>
        [DataMember(Name = "additionalWithheld", EmitDefaultValue = true)]
        public float? AdditionalWithheld { get; set; }

        /// <summary>
        /// Indicates whether the employee is exempt from withholding.
        /// </summary>
        /// <value>Indicates whether the employee is exempt from withholding.</value>
        /// <example>false</example>
        [DataMember(Name = "exemptFromWithholding", EmitDefaultValue = true)]
        public bool ExemptFromWithholding { get; set; }

        /// <summary>
        /// The office code associated with the form.
        /// </summary>
        /// <value>The office code associated with the form.</value>
        /// <example>OC12345</example>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W4FormResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeMiddleName: ").Append(EmployeeMiddleName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  EmployeeNameSuffix: ").Append(EmployeeNameSuffix).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  LastNameDiffers: ").Append(LastNameDiffers).Append("\n");
            sb.Append("  NumAllowances: ").Append(NumAllowances).Append("\n");
            sb.Append("  OtherDependents: ").Append(OtherDependents).Append("\n");
            sb.Append("  NonJobIncome: ").Append(NonJobIncome).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  AdditionalWithheld: ").Append(AdditionalWithheld).Append("\n");
            sb.Append("  ExemptFromWithholding: ").Append(ExemptFromWithholding).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
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
