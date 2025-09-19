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
    /// CompanyRequest
    /// </summary>
    [DataContract(Name = "CompanyRequest")]
    public partial class CompanyRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRequest" /> class.
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
        public CompanyRequest(string name = default(string), string dbaName = default(string), string email = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string telephone = default(string), string tin = default(string), string referenceId = default(string), bool? doTinMatch = default(bool?), string groupName = default(string), string foreignProvince = default(string), string countryCode = default(string), bool? resendRequests = default(bool?), int? resendIntervalDays = default(int?), int? maxReminderAttempts = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CompanyRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for CompanyRequest and cannot be null");
            }
            this.Email = email;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CompanyRequest and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for CompanyRequest and cannot be null");
            }
            this.City = city;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for CompanyRequest and cannot be null");
            }
            this.Zip = zip;
            // to ensure "telephone" is required (not null)
            if (telephone == null)
            {
                throw new ArgumentNullException("telephone is a required property for CompanyRequest and cannot be null");
            }
            this.Telephone = telephone;
            // to ensure "tin" is required (not null)
            if (tin == null)
            {
                throw new ArgumentNullException("tin is a required property for CompanyRequest and cannot be null");
            }
            this.Tin = tin;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for CompanyRequest and cannot be null");
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyRequest {\n");
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
