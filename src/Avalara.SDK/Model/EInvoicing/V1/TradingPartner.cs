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
    /// Represents a participant in the Avalara directory.
    /// </summary>
    [DataContract(Name = "TradingPartner")]
    public partial class TradingPartner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingPartner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TradingPartner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingPartner" /> class.
        /// </summary>
        /// <param name="name">Name of the participant (typically, the name of the business entity). (required).</param>
        /// <param name="registrationDate">Registration date of the participant if available..</param>
        /// <param name="identifiers">A list of identifiers associated with the trading partner. Each identifier should consistently include the fields name, and value to maintain clarity and ensure consistent structure across entries. When creating or updating a trading partner, the attribute &#39;name&#39; must be agreed upon with Avalara to ensure consistency. Failing to adhere to the agreed values will result in a validation error. Further, when creating or updating a trading partner, the value provided for the attribute &#39;displayName&#39; will be ignored and instead retrieved from the standard set of display names maintained. (required).</param>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="supportedDocumentTypes">A list of document types supported by the trading partner for exchange. Each document type identifier value must match the standard list maintained by Avalara, which includes Peppol and other public network document type identifier schemes and values, as well as any approved partner-specific identifiers. The &#39;value&#39; field must exactly match an entry from the provided document identifier list. Any attempt to submit unsupported document types will result in a validation error. Further, when creating or updating a trading partner, the value provided for the attributes &#39;name&#39; and &#39;supportedByAvalara&#39; will be ignored. (required).</param>
        /// <param name="consents">consents.</param>
        /// <param name="extensions">Optional array used to carry additional metadata or configuration values that may be required by specific networks. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error..</param>
        public TradingPartner(string name = default(string), string registrationDate = default(string), List<Identifier> identifiers = default(List<Identifier>), List<Address> addresses = default(List<Address>), List<SupportedDocumentTypes> supportedDocumentTypes = default(List<SupportedDocumentTypes>), Consents consents = default(Consents), List<Extension> extensions = default(List<Extension>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TradingPartner and cannot be null");
            }
            this.Name = name;
            // to ensure "identifiers" is required (not null)
            if (identifiers == null)
            {
                throw new ArgumentNullException("identifiers is a required property for TradingPartner and cannot be null");
            }
            this.Identifiers = identifiers;
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new ArgumentNullException("addresses is a required property for TradingPartner and cannot be null");
            }
            this.Addresses = addresses;
            // to ensure "supportedDocumentTypes" is required (not null)
            if (supportedDocumentTypes == null)
            {
                throw new ArgumentNullException("supportedDocumentTypes is a required property for TradingPartner and cannot be null");
            }
            this.SupportedDocumentTypes = supportedDocumentTypes;
            this.RegistrationDate = registrationDate;
            this.Consents = consents;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Avalara unique ID of the participant in the directory.
        /// </summary>
        /// <value>Avalara unique ID of the participant in the directory.</value>
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
        /// Name of the participant (typically, the name of the business entity).
        /// </summary>
        /// <value>Name of the participant (typically, the name of the business entity).</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The network where the participant is present. When creating or updating a trading partner, the value provided for the attribute &#39;network&#39; will be ignored.
        /// </summary>
        /// <value>The network where the participant is present. When creating or updating a trading partner, the value provided for the attribute &#39;network&#39; will be ignored.</value>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; private set; }

        /// <summary>
        /// Returns false as Network should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNetwork()
        {
            return false;
        }
        /// <summary>
        /// Registration date of the participant if available.
        /// </summary>
        /// <value>Registration date of the participant if available.</value>
        [DataMember(Name = "registrationDate", EmitDefaultValue = false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// A list of identifiers associated with the trading partner. Each identifier should consistently include the fields name, and value to maintain clarity and ensure consistent structure across entries. When creating or updating a trading partner, the attribute &#39;name&#39; must be agreed upon with Avalara to ensure consistency. Failing to adhere to the agreed values will result in a validation error. Further, when creating or updating a trading partner, the value provided for the attribute &#39;displayName&#39; will be ignored and instead retrieved from the standard set of display names maintained.
        /// </summary>
        /// <value>A list of identifiers associated with the trading partner. Each identifier should consistently include the fields name, and value to maintain clarity and ensure consistent structure across entries. When creating or updating a trading partner, the attribute &#39;name&#39; must be agreed upon with Avalara to ensure consistency. Failing to adhere to the agreed values will result in a validation error. Further, when creating or updating a trading partner, the value provided for the attribute &#39;displayName&#39; will be ignored and instead retrieved from the standard set of display names maintained.</value>
        [DataMember(Name = "identifiers", IsRequired = true, EmitDefaultValue = true)]
        public List<Identifier> Identifiers { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = true)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// A list of document types supported by the trading partner for exchange. Each document type identifier value must match the standard list maintained by Avalara, which includes Peppol and other public network document type identifier schemes and values, as well as any approved partner-specific identifiers. The &#39;value&#39; field must exactly match an entry from the provided document identifier list. Any attempt to submit unsupported document types will result in a validation error. Further, when creating or updating a trading partner, the value provided for the attributes &#39;name&#39; and &#39;supportedByAvalara&#39; will be ignored.
        /// </summary>
        /// <value>A list of document types supported by the trading partner for exchange. Each document type identifier value must match the standard list maintained by Avalara, which includes Peppol and other public network document type identifier schemes and values, as well as any approved partner-specific identifiers. The &#39;value&#39; field must exactly match an entry from the provided document identifier list. Any attempt to submit unsupported document types will result in a validation error. Further, when creating or updating a trading partner, the value provided for the attributes &#39;name&#39; and &#39;supportedByAvalara&#39; will be ignored.</value>
        [DataMember(Name = "supportedDocumentTypes", IsRequired = true, EmitDefaultValue = true)]
        public List<SupportedDocumentTypes> SupportedDocumentTypes { get; set; }

        /// <summary>
        /// Gets or Sets Consents
        /// </summary>
        [DataMember(Name = "consents", EmitDefaultValue = false)]
        public Consents Consents { get; set; }

        /// <summary>
        /// Optional array used to carry additional metadata or configuration values that may be required by specific networks. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error.
        /// </summary>
        /// <value>Optional array used to carry additional metadata or configuration values that may be required by specific networks. When creating or updating a trading partner, the keys provided in the &#39;extensions&#39; attribute must be selected from a predefined list of supported extensions. Using any unsupported keys will result in a validation error.</value>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradingPartner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  SupportedDocumentTypes: ").Append(SupportedDocumentTypes).Append("\n");
            sb.Append("  Consents: ").Append(Consents).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
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
            if (this.Name != null && this.Name.Length > 250)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 250.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 3)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            yield break;
        }
    }
}
