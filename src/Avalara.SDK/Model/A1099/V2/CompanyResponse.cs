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
    /// CompanyResponse
    /// </summary>
    [DataContract(Name = "CompanyResponse")]
    public partial class CompanyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="name">name.</param>
        /// <param name="dbaName">dbaName.</param>
        /// <param name="address">address.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="foreignProvince">foreignProvince.</param>
        /// <param name="zip">zip.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="email">email.</param>
        /// <param name="telephone">telephone.</param>
        /// <param name="tin">tin.</param>
        /// <param name="doTinMatch">doTinMatch.</param>
        /// <param name="resendRequests">resendRequests.</param>
        /// <param name="resendIntervalDays">resendIntervalDays.</param>
        /// <param name="maxReminderAttempts">maxReminderAttempts.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public CompanyResponse(string id = default(string), string referenceId = default(string), string groupName = default(string), string name = default(string), string dbaName = default(string), string address = default(string), string city = default(string), string state = default(string), string foreignProvince = default(string), string zip = default(string), string countryCode = default(string), string email = default(string), string telephone = default(string), string tin = default(string), bool? doTinMatch = default(bool?), bool? resendRequests = default(bool?), int? resendIntervalDays = default(int?), int? maxReminderAttempts = default(int?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            this.Id = id;
            this.ReferenceId = referenceId;
            this.GroupName = groupName;
            this.Name = name;
            this.DbaName = dbaName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ForeignProvince = foreignProvince;
            this.Zip = zip;
            this.CountryCode = countryCode;
            this.Email = email;
            this.Telephone = telephone;
            this.Tin = tin;
            this.DoTinMatch = doTinMatch;
            this.ResendRequests = resendRequests;
            this.ResendIntervalDays = resendIntervalDays;
            this.MaxReminderAttempts = maxReminderAttempts;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DbaName
        /// </summary>
        [DataMember(Name = "dbaName", EmitDefaultValue = true)]
        public string DbaName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets ForeignProvince
        /// </summary>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name = "telephone", EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets Tin
        /// </summary>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Gets or Sets DoTinMatch
        /// </summary>
        [DataMember(Name = "doTinMatch", EmitDefaultValue = true)]
        public bool? DoTinMatch { get; set; }

        /// <summary>
        /// Gets or Sets ResendRequests
        /// </summary>
        [DataMember(Name = "resendRequests", EmitDefaultValue = true)]
        public bool? ResendRequests { get; set; }

        /// <summary>
        /// Gets or Sets ResendIntervalDays
        /// </summary>
        [DataMember(Name = "resendIntervalDays", EmitDefaultValue = true)]
        public int? ResendIntervalDays { get; set; }

        /// <summary>
        /// Gets or Sets MaxReminderAttempts
        /// </summary>
        [DataMember(Name = "maxReminderAttempts", EmitDefaultValue = true)]
        public int? MaxReminderAttempts { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DbaName: ").Append(DbaName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  DoTinMatch: ").Append(DoTinMatch).Append("\n");
            sb.Append("  ResendRequests: ").Append(ResendRequests).Append("\n");
            sb.Append("  ResendIntervalDays: ").Append(ResendIntervalDays).Append("\n");
            sb.Append("  MaxReminderAttempts: ").Append(MaxReminderAttempts).Append("\n");
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
