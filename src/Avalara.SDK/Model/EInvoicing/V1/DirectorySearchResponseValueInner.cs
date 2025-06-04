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
    /// DirectorySearchResponseValueInner
    /// </summary>
    [DataContract(Name = "DirectorySearchResponse_value_inner")]
    public partial class DirectorySearchResponseValueInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySearchResponseValueInner" /> class.
        /// </summary>
        /// <param name="id">Avalara unique ID of the participant in the directory..</param>
        /// <param name="name">Name of the participant (typically, the name of the business entity)..</param>
        /// <param name="network">The network where the participant is present..</param>
        /// <param name="registrationDate">Registration date of the participant if available.</param>
        /// <param name="identifiers">identifiers.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="supportedDocumentTypes">supportedDocumentTypes.</param>
        public DirectorySearchResponseValueInner(string id = default(string), string name = default(string), string network = default(string), DateTime registrationDate = default(DateTime), List<DirectorySearchResponseValueInnerIdentifiersInner> identifiers = default(List<DirectorySearchResponseValueInnerIdentifiersInner>), List<DirectorySearchResponseValueInnerAddressesInner> addresses = default(List<DirectorySearchResponseValueInnerAddressesInner>), List<DirectorySearchResponseValueInnerSupportedDocumentTypesInner> supportedDocumentTypes = default(List<DirectorySearchResponseValueInnerSupportedDocumentTypesInner>))
        {
            this.Id = id;
            this.Name = name;
            this.Network = network;
            this.RegistrationDate = registrationDate;
            this.Identifiers = identifiers;
            this.Addresses = addresses;
            this.SupportedDocumentTypes = supportedDocumentTypes;
        }

        /// <summary>
        /// Avalara unique ID of the participant in the directory.
        /// </summary>
        /// <value>Avalara unique ID of the participant in the directory.</value>
        /// <example>2a27ee0cf5bcb6165ab891503652343419a8fc5fe6b406299c47d7b44aa8548c</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the participant (typically, the name of the business entity).
        /// </summary>
        /// <value>Name of the participant (typically, the name of the business entity).</value>
        /// <example>Pineapple Labs ltd</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The network where the participant is present.
        /// </summary>
        /// <value>The network where the participant is present.</value>
        /// <example>Peppol</example>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Registration date of the participant if available
        /// </summary>
        /// <value>Registration date of the participant if available</value>
        [DataMember(Name = "registrationDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets Identifiers
        /// </summary>
        [DataMember(Name = "identifiers", EmitDefaultValue = false)]
        public List<DirectorySearchResponseValueInnerIdentifiersInner> Identifiers { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<DirectorySearchResponseValueInnerAddressesInner> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets SupportedDocumentTypes
        /// </summary>
        [DataMember(Name = "supportedDocumentTypes", EmitDefaultValue = false)]
        public List<DirectorySearchResponseValueInnerSupportedDocumentTypesInner> SupportedDocumentTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DirectorySearchResponseValueInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  SupportedDocumentTypes: ").Append(SupportedDocumentTypes).Append("\n");
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
