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
    /// CompanyModel
    /// </summary>
    [DataContract(Name = "CompanyModel")]
    public partial class CompanyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyModel" /> class.
        /// </summary>
        /// <param name="id">Company ID.</param>
        /// <param name="userId">User ID associated with the company.</param>
        /// <param name="name">Legal company name.</param>
        /// <param name="email">Company email address.</param>
        /// <param name="shippingAddress">Shipping address.</param>
        /// <param name="city">City.</param>
        /// <param name="state">State code.</param>
        /// <param name="zip">ZIP/Postal code.</param>
        /// <param name="telephone">Phone number.</param>
        /// <param name="tin">Tax identification number.</param>
        /// <param name="dbaName">DBA (Doing Business As) name.</param>
        /// <param name="accountId">Account ID associated with the company.</param>
        /// <param name="referenceId">Optional identifier for reference.</param>
        /// <param name="doTinMatch">Flag indicating whether to perform TIN matching.</param>
        /// <param name="groupName">Group Name associated with the company.</param>
        /// <param name="foreignProvince">Foreign province for non-US addresses.</param>
        /// <param name="shippingCountryCode">Shipping country code.</param>
        /// <param name="resendRequests">Flag indicating whether to resend requests.</param>
        /// <param name="resendIntervalDays">Interval in days for resending requests.</param>
        /// <param name="maxReminderAttempts">Maximum number of reminder attempts.</param>
        /// <param name="createdAt">Record creation timestamp.</param>
        /// <param name="updatedAt">Record last update timestamp.</param>
        public CompanyModel(long id = default(long), long userId = default(long), string name = default(string), string email = default(string), string shippingAddress = default(string), string city = default(string), string state = default(string), string zip = default(string), string telephone = default(string), string tin = default(string), string dbaName = default(string), long accountId = default(long), string referenceId = default(string), bool doTinMatch = default(bool), string groupName = default(string), string foreignProvince = default(string), string shippingCountryCode = default(string), bool resendRequests = default(bool), int? resendIntervalDays = default(int?), int? maxReminderAttempts = default(int?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.UserId = userId;
            this.Name = name;
            this.Email = email;
            this.ShippingAddress = shippingAddress;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Telephone = telephone;
            this.Tin = tin;
            this.DbaName = dbaName;
            this.AccountId = accountId;
            this.ReferenceId = referenceId;
            this.DoTinMatch = doTinMatch;
            this.GroupName = groupName;
            this.ForeignProvince = foreignProvince;
            this.ShippingCountryCode = shippingCountryCode;
            this.ResendRequests = resendRequests;
            this.ResendIntervalDays = resendIntervalDays;
            this.MaxReminderAttempts = maxReminderAttempts;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Company ID
        /// </summary>
        /// <value>Company ID</value>
        /// <example>0</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// User ID associated with the company
        /// </summary>
        /// <value>User ID associated with the company</value>
        /// <example>0</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public long UserId { get; set; }

        /// <summary>
        /// Legal company name
        /// </summary>
        /// <value>Legal company name</value>
        /// <example>Example Corp</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Company email address
        /// </summary>
        /// <value>Company email address</value>
        /// <example>contact@examplecorp.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        /// <value>Shipping address</value>
        /// <example>123 Business Ave</example>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = true)]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /// <example>Phoenix</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State code
        /// </summary>
        /// <value>State code</value>
        /// <example>AZ</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// ZIP/Postal code
        /// </summary>
        /// <value>ZIP/Postal code</value>
        /// <example>85001-1234</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        /// <example>602-555-0123</example>
        [DataMember(Name = "telephone", EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Tax identification number
        /// </summary>
        /// <value>Tax identification number</value>
        /// <example>12-3456789</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// DBA (Doing Business As) name
        /// </summary>
        /// <value>DBA (Doing Business As) name</value>
        [DataMember(Name = "dbaName", EmitDefaultValue = true)]
        public string DbaName { get; set; }

        /// <summary>
        /// Account ID associated with the company
        /// </summary>
        /// <value>Account ID associated with the company</value>
        /// <example>0</example>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public long AccountId { get; set; }

        /// <summary>
        /// Optional identifier for reference
        /// </summary>
        /// <value>Optional identifier for reference</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Flag indicating whether to perform TIN matching
        /// </summary>
        /// <value>Flag indicating whether to perform TIN matching</value>
        /// <example>false</example>
        [DataMember(Name = "doTinMatch", EmitDefaultValue = true)]
        public bool DoTinMatch { get; set; }

        /// <summary>
        /// Group Name associated with the company
        /// </summary>
        /// <value>Group Name associated with the company</value>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Foreign province for non-US addresses
        /// </summary>
        /// <value>Foreign province for non-US addresses</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Shipping country code
        /// </summary>
        /// <value>Shipping country code</value>
        /// <example>US</example>
        [DataMember(Name = "shippingCountryCode", EmitDefaultValue = true)]
        public string ShippingCountryCode { get; set; }

        /// <summary>
        /// Flag indicating whether to resend requests
        /// </summary>
        /// <value>Flag indicating whether to resend requests</value>
        /// <example>false</example>
        [DataMember(Name = "resendRequests", EmitDefaultValue = true)]
        public bool ResendRequests { get; set; }

        /// <summary>
        /// Interval in days for resending requests
        /// </summary>
        /// <value>Interval in days for resending requests</value>
        [DataMember(Name = "resendIntervalDays", EmitDefaultValue = true)]
        public int? ResendIntervalDays { get; set; }

        /// <summary>
        /// Maximum number of reminder attempts
        /// </summary>
        /// <value>Maximum number of reminder attempts</value>
        [DataMember(Name = "maxReminderAttempts", EmitDefaultValue = true)]
        public int? MaxReminderAttempts { get; set; }

        /// <summary>
        /// Record creation timestamp
        /// </summary>
        /// <value>Record creation timestamp</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Record last update timestamp
        /// </summary>
        /// <value>Record last update timestamp</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  DbaName: ").Append(DbaName).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  DoTinMatch: ").Append(DoTinMatch).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  ShippingCountryCode: ").Append(ShippingCountryCode).Append("\n");
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
