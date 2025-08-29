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
    /// Intermediary or flow-through entity information for tax forms
    /// </summary>
    [DataContract(Name = "IntermediaryOrFlowThrough")]
    public partial class IntermediaryOrFlowThrough : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntermediaryOrFlowThrough" /> class.
        /// </summary>
        /// <param name="ein">EIN (Employer Identification Number) of the intermediary or flow-through entity.</param>
        /// <param name="chap3StatusCode">Chapter 3 status code for the intermediary or flow-through entity.</param>
        /// <param name="chap4StatusCode">Chapter 4 status code for the intermediary or flow-through entity.</param>
        /// <param name="name">Name of the intermediary or flow-through entity.</param>
        /// <param name="giin">GIIN (Global Intermediary Identification Number) of the intermediary or flow-through entity.</param>
        /// <param name="countryCode">Country code for the intermediary or flow-through entity.</param>
        /// <param name="foreignTin">Foreign TIN of the intermediary or flow-through entity.</param>
        /// <param name="address">Address of the intermediary or flow-through entity.</param>
        /// <param name="city">City of the intermediary or flow-through entity.</param>
        /// <param name="state">State of the intermediary or flow-through entity.</param>
        /// <param name="zip">Zip code of the intermediary or flow-through entity.</param>
        public IntermediaryOrFlowThrough(string ein = default(string), string chap3StatusCode = default(string), string chap4StatusCode = default(string), string name = default(string), string giin = default(string), string countryCode = default(string), string foreignTin = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string))
        {
            this.Ein = ein;
            this.Chap3StatusCode = chap3StatusCode;
            this.Chap4StatusCode = chap4StatusCode;
            this.Name = name;
            this.Giin = giin;
            this.CountryCode = countryCode;
            this.ForeignTin = foreignTin;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        /// <summary>
        /// EIN (Employer Identification Number) of the intermediary or flow-through entity
        /// </summary>
        /// <value>EIN (Employer Identification Number) of the intermediary or flow-through entity</value>
        [DataMember(Name = "ein", EmitDefaultValue = true)]
        public string Ein { get; set; }

        /// <summary>
        /// Chapter 3 status code for the intermediary or flow-through entity
        /// </summary>
        /// <value>Chapter 3 status code for the intermediary or flow-through entity</value>
        [DataMember(Name = "chap3StatusCode", EmitDefaultValue = true)]
        public string Chap3StatusCode { get; set; }

        /// <summary>
        /// Chapter 4 status code for the intermediary or flow-through entity
        /// </summary>
        /// <value>Chapter 4 status code for the intermediary or flow-through entity</value>
        [DataMember(Name = "chap4StatusCode", EmitDefaultValue = true)]
        public string Chap4StatusCode { get; set; }

        /// <summary>
        /// Name of the intermediary or flow-through entity
        /// </summary>
        /// <value>Name of the intermediary or flow-through entity</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// GIIN (Global Intermediary Identification Number) of the intermediary or flow-through entity
        /// </summary>
        /// <value>GIIN (Global Intermediary Identification Number) of the intermediary or flow-through entity</value>
        [DataMember(Name = "giin", EmitDefaultValue = true)]
        public string Giin { get; set; }

        /// <summary>
        /// Country code for the intermediary or flow-through entity
        /// </summary>
        /// <value>Country code for the intermediary or flow-through entity</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Foreign TIN of the intermediary or flow-through entity
        /// </summary>
        /// <value>Foreign TIN of the intermediary or flow-through entity</value>
        [DataMember(Name = "foreignTin", EmitDefaultValue = true)]
        public string ForeignTin { get; set; }

        /// <summary>
        /// Address of the intermediary or flow-through entity
        /// </summary>
        /// <value>Address of the intermediary or flow-through entity</value>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// City of the intermediary or flow-through entity
        /// </summary>
        /// <value>City of the intermediary or flow-through entity</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State of the intermediary or flow-through entity
        /// </summary>
        /// <value>State of the intermediary or flow-through entity</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip code of the intermediary or flow-through entity
        /// </summary>
        /// <value>Zip code of the intermediary or flow-through entity</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntermediaryOrFlowThrough {\n");
            sb.Append("  Ein: ").Append(Ein).Append("\n");
            sb.Append("  Chap3StatusCode: ").Append(Chap3StatusCode).Append("\n");
            sb.Append("  Chap4StatusCode: ").Append(Chap4StatusCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Giin: ").Append(Giin).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
