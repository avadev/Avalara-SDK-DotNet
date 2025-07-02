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
    /// IssuerResponse
    /// </summary>
    [DataContract(Name = "IssuerResponse")]
    public partial class IssuerResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerResponse" /> class.
        /// </summary>
        /// <param name="name">Legal name, not DBA.</param>
        /// <param name="nameDba">Optional DBA name or continuation of a long legal name.</param>
        /// <param name="tin">Tax identification number.</param>
        /// <param name="referenceId">Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces..</param>
        /// <param name="telephone">Telephone number.</param>
        /// <param name="taxYear">Tax year.</param>
        /// <param name="countryCode">If there is a transfer agent, use the address of the transfer agent..</param>
        /// <param name="email">Email address.</param>
        /// <param name="address">Address.</param>
        /// <param name="city">City.</param>
        /// <param name="state">State.</param>
        /// <param name="zip">Zip code.</param>
        /// <param name="foreignProvince">Foreign province.</param>
        /// <param name="transferAgentName">Transfer Agent&#39;s Name.</param>
        /// <param name="lastFiling">Last year of filing for this payer.</param>
        public IssuerResponse(string name = default(string), string nameDba = default(string), string tin = default(string), string referenceId = default(string), string telephone = default(string), int? taxYear = default(int?), string countryCode = default(string), string email = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string transferAgentName = default(string), bool lastFiling = default(bool))
        {
            this.Name = name;
            this.NameDba = nameDba;
            this.Tin = tin;
            this.ReferenceId = referenceId;
            this.Telephone = telephone;
            this.TaxYear = taxYear;
            this.CountryCode = countryCode;
            this.Email = email;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.ForeignProvince = foreignProvince;
            this.TransferAgentName = transferAgentName;
            this.LastFiling = lastFiling;
        }

        /// <summary>
        /// Unique identifier set when the record is created
        /// </summary>
        /// <value>Unique identifier set when the record is created</value>
        /// <example>0</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Legal name, not DBA
        /// </summary>
        /// <value>Legal name, not DBA</value>
        /// <example>Acme Corp</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Optional DBA name or continuation of a long legal name
        /// </summary>
        /// <value>Optional DBA name or continuation of a long legal name</value>
        /// <example>Second Name Corp</example>
        [DataMember(Name = "nameDba", EmitDefaultValue = false)]
        public string NameDba { get; set; }

        /// <summary>
        /// Tax identification number
        /// </summary>
        /// <value>Tax identification number</value>
        /// <example>23-8234555</example>
        [DataMember(Name = "tin", EmitDefaultValue = false)]
        public string Tin { get; set; }

        /// <summary>
        /// Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.
        /// </summary>
        /// <value>Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.</value>
        /// <example>1891810-9819891</example>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Telephone number
        /// </summary>
        /// <value>Telephone number</value>
        /// <example>520-555-1234</example>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Tax year
        /// </summary>
        /// <value>Tax year</value>
        /// <example>2024</example>
        [DataMember(Name = "taxYear", EmitDefaultValue = true)]
        public int? TaxYear { get; set; }

        /// <summary>
        /// If there is a transfer agent, use the address of the transfer agent.
        /// </summary>
        /// <value>If there is a transfer agent, use the address of the transfer agent.</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        /// <example>roadrunner@acmecorp.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        /// <example>1234 Meep Meep Blvd</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /// <example>Tucson</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        /// <example>AZ</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        /// <value>Zip code</value>
        /// <example>35004</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Foreign province
        /// </summary>
        /// <value>Foreign province</value>
        /// <example>1981981</example>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Transfer Agent&#39;s Name
        /// </summary>
        /// <value>Transfer Agent&#39;s Name</value>
        /// <example>test</example>
        [DataMember(Name = "transferAgentName", EmitDefaultValue = true)]
        public string TransferAgentName { get; set; }

        /// <summary>
        /// Last year of filing for this payer
        /// </summary>
        /// <value>Last year of filing for this payer</value>
        /// <example>false</example>
        [DataMember(Name = "lastFiling", EmitDefaultValue = true)]
        public bool LastFiling { get; set; }

        /// <summary>
        /// Date time when the issuer was created
        /// </summary>
        /// <value>Date time when the issuer was created</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Date time when the issuer was updated
        /// </summary>
        /// <value>Date time when the issuer was updated</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuerResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameDba: ").Append(NameDba).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  TransferAgentName: ").Append(TransferAgentName).Append("\n");
            sb.Append("  LastFiling: ").Append(LastFiling).Append("\n");
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
