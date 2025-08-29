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
    /// IssuerResponse
    /// </summary>
    [DataContract(Name = "IssuerResponse")]
    public partial class IssuerResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssuerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerResponse" /> class.
        /// </summary>
        /// <param name="id">Unique identifier set when the record is created..</param>
        /// <param name="createdAt">Date time when the record was created..</param>
        /// <param name="updatedAt">Date time when the record was last updated..</param>
        /// <param name="name">Legal name. Not the DBA name. (required).</param>
        /// <param name="dbaName">Doing Business As (DBA) name or continuation of a long legal name. Use either this or &#39;transferAgentName&#39;..</param>
        /// <param name="tin">Federal Tax Identification Number (TIN)..</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces..</param>
        /// <param name="telephone">Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries. (required).</param>
        /// <param name="taxYear">Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4. (required).</param>
        /// <param name="countryCode">Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address..</param>
        /// <param name="email">Contact email address. For recipient inquiries. (required).</param>
        /// <param name="address">Address. (required).</param>
        /// <param name="city">City. (required).</param>
        /// <param name="state">Two-letter US state or Canadian province code (required for US/CA addresses). (required).</param>
        /// <param name="zip">ZIP/postal code. (required).</param>
        /// <param name="foreignProvince">Province or region for non-US/CA addresses..</param>
        /// <param name="transferAgentName">Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;..</param>
        /// <param name="lastFiling">Indicates if this is the issuer&#39;s final year filing. (required).</param>
        public IssuerResponse(string id = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string name = default(string), string dbaName = default(string), string tin = default(string), string referenceId = default(string), string telephone = default(string), int? taxYear = default(int?), string countryCode = default(string), string email = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string transferAgentName = default(string), bool? lastFiling = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IssuerResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "telephone" is required (not null)
            if (telephone == null)
            {
                throw new ArgumentNullException("telephone is a required property for IssuerResponse and cannot be null");
            }
            this.Telephone = telephone;
            // to ensure "taxYear" is required (not null)
            if (taxYear == null)
            {
                throw new ArgumentNullException("taxYear is a required property for IssuerResponse and cannot be null");
            }
            this.TaxYear = taxYear;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for IssuerResponse and cannot be null");
            }
            this.Email = email;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for IssuerResponse and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for IssuerResponse and cannot be null");
            }
            this.City = city;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for IssuerResponse and cannot be null");
            }
            this.State = state;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for IssuerResponse and cannot be null");
            }
            this.Zip = zip;
            // to ensure "lastFiling" is required (not null)
            if (lastFiling == null)
            {
                throw new ArgumentNullException("lastFiling is a required property for IssuerResponse and cannot be null");
            }
            this.LastFiling = lastFiling;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DbaName = dbaName;
            this.Tin = tin;
            this.ReferenceId = referenceId;
            this.CountryCode = countryCode;
            this.ForeignProvince = foreignProvince;
            this.TransferAgentName = transferAgentName;
        }

        /// <summary>
        /// Unique identifier set when the record is created.
        /// </summary>
        /// <value>Unique identifier set when the record is created.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Date time when the record was created.
        /// </summary>
        /// <value>Date time when the record was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date time when the record was last updated.
        /// </summary>
        /// <value>Date time when the record was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Legal name. Not the DBA name.
        /// </summary>
        /// <value>Legal name. Not the DBA name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Doing Business As (DBA) name or continuation of a long legal name. Use either this or &#39;transferAgentName&#39;.
        /// </summary>
        /// <value>Doing Business As (DBA) name or continuation of a long legal name. Use either this or &#39;transferAgentName&#39;.</value>
        [DataMember(Name = "dbaName", EmitDefaultValue = true)]
        public string DbaName { get; set; }

        /// <summary>
        /// Federal Tax Identification Number (TIN).
        /// </summary>
        /// <value>Federal Tax Identification Number (TIN).</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces.
        /// </summary>
        /// <value>Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries.
        /// </summary>
        /// <value>Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries.</value>
        [DataMember(Name = "telephone", IsRequired = true, EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4.
        /// </summary>
        /// <value>Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4.</value>
        [DataMember(Name = "taxYear", IsRequired = true, EmitDefaultValue = true)]
        public int? TaxYear { get; set; }

        /// <summary>
        /// Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address.
        /// </summary>
        /// <value>Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Contact email address. For recipient inquiries.
        /// </summary>
        /// <value>Contact email address. For recipient inquiries.</value>
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
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// ZIP/postal code.
        /// </summary>
        /// <value>ZIP/postal code.</value>
        [DataMember(Name = "zip", IsRequired = true, EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Province or region for non-US/CA addresses.
        /// </summary>
        /// <value>Province or region for non-US/CA addresses.</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;.
        /// </summary>
        /// <value>Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;.</value>
        [DataMember(Name = "transferAgentName", EmitDefaultValue = true)]
        public string TransferAgentName { get; set; }

        /// <summary>
        /// Indicates if this is the issuer&#39;s final year filing.
        /// </summary>
        /// <value>Indicates if this is the issuer&#39;s final year filing.</value>
        [DataMember(Name = "lastFiling", IsRequired = true, EmitDefaultValue = true)]
        public bool? LastFiling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuerResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DbaName: ").Append(DbaName).Append("\n");
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
