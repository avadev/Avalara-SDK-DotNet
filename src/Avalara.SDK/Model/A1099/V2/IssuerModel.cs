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
    /// IssuerModel
    /// </summary>
    [DataContract(Name = "IssuerModel")]
    public partial class IssuerModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssuerModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerModel" /> class.
        /// </summary>
        /// <param name="name">Legal name, not DBA (required).</param>
        /// <param name="nameDba">Optional DBA name or continuation of a long legal name.</param>
        /// <param name="tin">Tax identification number.</param>
        /// <param name="referenceId">Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces..</param>
        /// <param name="telephone">Telephone number (required).</param>
        /// <param name="taxYear">Tax year (required).</param>
        /// <param name="shippingCountryCode">If there is a transfer agent, use the shipping address of the transfer agent..</param>
        /// <param name="email">Email address.</param>
        /// <param name="address">Shipping address (required).</param>
        /// <param name="city">City (required).</param>
        /// <param name="state">State.</param>
        /// <param name="zip">Zip code (required).</param>
        /// <param name="foreignProvince">Foreign province.</param>
        public IssuerModel(string name = default(string), string nameDba = default(string), string tin = default(string), string referenceId = default(string), string telephone = default(string), int taxYear = default(int), string shippingCountryCode = default(string), string email = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IssuerModel and cannot be null");
            }
            this.Name = name;
            // to ensure "telephone" is required (not null)
            if (telephone == null)
            {
                throw new ArgumentNullException("telephone is a required property for IssuerModel and cannot be null");
            }
            this.Telephone = telephone;
            this.TaxYear = taxYear;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for IssuerModel and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for IssuerModel and cannot be null");
            }
            this.City = city;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for IssuerModel and cannot be null");
            }
            this.Zip = zip;
            this.NameDba = nameDba;
            this.Tin = tin;
            this.ReferenceId = referenceId;
            this.ShippingCountryCode = shippingCountryCode;
            this.Email = email;
            this.State = state;
            this.ForeignProvince = foreignProvince;
        }

        /// <summary>
        /// Legal name, not DBA
        /// </summary>
        /// <value>Legal name, not DBA</value>
        /// <example>Acme Corp</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Optional DBA name or continuation of a long legal name
        /// </summary>
        /// <value>Optional DBA name or continuation of a long legal name</value>
        [DataMember(Name = "nameDba", EmitDefaultValue = true)]
        public string NameDba { get; set; }

        /// <summary>
        /// Tax identification number
        /// </summary>
        /// <value>Tax identification number</value>
        /// <example>23-8234555</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.
        /// </summary>
        /// <value>Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Telephone number
        /// </summary>
        /// <value>Telephone number</value>
        /// <example>520-555-1234</example>
        [DataMember(Name = "telephone", IsRequired = true, EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Tax year
        /// </summary>
        /// <value>Tax year</value>
        /// <example>2023</example>
        [DataMember(Name = "taxYear", IsRequired = true, EmitDefaultValue = true)]
        public int TaxYear { get; set; }

        /// <summary>
        /// If there is a transfer agent, use the shipping address of the transfer agent.
        /// </summary>
        /// <value>If there is a transfer agent, use the shipping address of the transfer agent.</value>
        /// <example>US</example>
        [DataMember(Name = "shippingCountryCode", EmitDefaultValue = true)]
        public string ShippingCountryCode { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        /// <example>roadrunner@acmecorp.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        /// <value>Shipping address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /// <example>Tucson</example>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
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
        /// <example>85701-0001</example>
        [DataMember(Name = "zip", IsRequired = true, EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Foreign province
        /// </summary>
        /// <value>Foreign province</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Unique identifier set when the record is created
        /// </summary>
        /// <value>Unique identifier set when the record is created</value>
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
        /// id or the manager_id of the user to whom this issuer belongs to
        /// </summary>
        /// <value>id or the manager_id of the user to whom this issuer belongs to</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; private set; }

        /// <summary>
        /// Returns false as UserId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserId()
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
            sb.Append("class IssuerModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameDba: ").Append(NameDba).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ShippingCountryCode: ").Append(ShippingCountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 40)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 40.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // NameDba (string) maxLength
            if (this.NameDba != null && this.NameDba.Length > 40)
            {
                yield return new ValidationResult("Invalid value for NameDba, length must be less than 40.", new [] { "NameDba" });
            }

            // ReferenceId (string) maxLength
            if (this.ReferenceId != null && this.ReferenceId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ReferenceId, length must be less than 50.", new [] { "ReferenceId" });
            }

            if (this.ReferenceId != null) {
                // ReferenceId (string) pattern
                Regex regexReferenceId = new Regex(@"[a-z\d\-_ ]*", RegexOptions.CultureInvariant);
                if (!regexReferenceId.Match(this.ReferenceId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceId, must match a pattern of " + regexReferenceId, new [] { "ReferenceId" });
                }
            }

            // Telephone (string) minLength
            if (this.Telephone != null && this.Telephone.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Telephone, length must be greater than 1.", new [] { "Telephone" });
            }

            if (this.Email != null) {
                // Email (string) pattern
                Regex regexEmail = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,3}){1,2}", RegexOptions.CultureInvariant);
                if (!regexEmail.Match(this.Email).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, must match a pattern of " + regexEmail, new [] { "Email" });
                }
            }

            // Address (string) maxLength
            if (this.Address != null && this.Address.Length > 60)
            {
                yield return new ValidationResult("Invalid value for Address, length must be less than 60.", new [] { "Address" });
            }

            // Address (string) minLength
            if (this.Address != null && this.Address.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Address, length must be greater than 1.", new [] { "Address" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 40)
            {
                yield return new ValidationResult("Invalid value for City, length must be less than 40.", new [] { "City" });
            }

            // City (string) minLength
            if (this.City != null && this.City.Length < 1)
            {
                yield return new ValidationResult("Invalid value for City, length must be greater than 1.", new [] { "City" });
            }

            // Zip (string) minLength
            if (this.Zip != null && this.Zip.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Zip, length must be greater than 1.", new [] { "Zip" });
            }

            // ForeignProvince (string) maxLength
            if (this.ForeignProvince != null && this.ForeignProvince.Length > 40)
            {
                yield return new ValidationResult("Invalid value for ForeignProvince, length must be less than 40.", new [] { "ForeignProvince" });
            }

            yield break;
        }
    }
}
