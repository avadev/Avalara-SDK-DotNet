/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara E-Invoicing API
 *
 * An API that supports sending data for an E-Invoicing compliance use-case.
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

namespace Avalara.SDK.Model.EInvoicing.V1
{
/// <summary>
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="line1">Address line 1.</param>
        /// <param name="line2">Address line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">State.</param>
        /// <param name="country">Country (ISO 3166) (required).</param>
        /// <param name="postalCode">Postal code.</param>
        public Address(string line1 = default(string), string line2 = default(string), string city = default(string), string state = default(string), string country = default(string), string postalCode = default(string))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for Address and cannot be null");
            }
            this.Country = country;
            this.Line1 = line1;
            this.Line2 = line2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// Address line 1
        /// </summary>
        /// <value>Address line 1</value>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <value>Address line 2</value>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Country (ISO 3166)
        /// </summary>
        /// <value>Country (ISO 3166)</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            // Line1 (string) maxLength
            if (this.Line1 != null && this.Line1.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Line1, length must be less than 250.", new [] { "Line1" });
            }

            // Line2 (string) maxLength
            if (this.Line2 != null && this.Line2.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Line2, length must be less than 250.", new [] { "Line2" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 250)
            {
                yield return new ValidationResult("Invalid value for City, length must be less than 250.", new [] { "City" });
            }

            // State (string) maxLength
            if (this.State != null && this.State.Length > 250)
            {
                yield return new ValidationResult("Invalid value for State, length must be less than 250.", new [] { "State" });
            }

            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Country, length must be less than 250.", new [] { "Country" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 250)
            {
                yield return new ValidationResult("Invalid value for PostalCode, length must be less than 250.", new [] { "PostalCode" });
            }

            yield break;
        }
    }
}
