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
    /// Mandate
    /// </summary>
    [DataContract(Name = "Mandate")]
    public partial class Mandate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mandate" /> class.
        /// </summary>
        /// <param name="mandateId">The &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). Keep in mind the following when specifying a &#x60;mandateId&#x60;. - A country can have multiple mandate types (B2C, B2B, B2G). - A entity/company can opt in for multiple mandates. - A &#x60;mandateId&#x60; is the combination of country + mandate type + network/regulation..</param>
        /// <param name="countryMandate">**[LEGACY]** This field is retained for backward compatibility. It is recommended to use &#x60;mandateId&#x60; instead. The &#x60;countryMandate&#x60; similar to the &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). .</param>
        /// <param name="countryCode">Country code.</param>
        /// <param name="description">Mandate description.</param>
        /// <param name="supportedByELRAPI">Indicates whether this mandate supported by the ELR API.</param>
        /// <param name="mandateFormat">Mandate format.</param>
        /// <param name="eInvoicingFlow">The type of e-invoicing flow for this mandate.</param>
        /// <param name="eInvoicingFlowDocumentationLink">Link to the documentation for this mandate&#39;s e-invoicing flow.</param>
        /// <param name="getInvoiceAvailableMediaType">List of available media types for downloading invoices for this mandate.</param>
        /// <param name="supportsInboundDigitalDocument">Indicates whether this mandate supports inbound digital documents.</param>
        /// <param name="inputDataFormats">Format and version used when inputting the data.</param>
        /// <param name="outputDataFormats">Lists the supported output document formats for the country mandate. For countries where specifying an output document format is required (e.g., France), this array will contain the applicable formats. For other countries where output format selection is not necessary, the array will be empty..</param>
        /// <param name="workflowIds">Workflow ID list.</param>
        /// <param name="supportedDocumentStatuses">List of document statuses defined by the mandate..</param>
        public Mandate(string mandateId = default(string), string countryMandate = default(string), string countryCode = default(string), string description = default(string), bool supportedByELRAPI = default(bool), string mandateFormat = default(string), string eInvoicingFlow = default(string), string eInvoicingFlowDocumentationLink = default(string), List<string> getInvoiceAvailableMediaType = default(List<string>), string supportsInboundDigitalDocument = default(string), List<InputDataFormats> inputDataFormats = default(List<InputDataFormats>), List<OutputDataFormats> outputDataFormats = default(List<OutputDataFormats>), List<WorkflowIds> workflowIds = default(List<WorkflowIds>), List<SupportedDocumentStatuses> supportedDocumentStatuses = default(List<SupportedDocumentStatuses>))
        {
            this.MandateId = mandateId;
            this.CountryMandate = countryMandate;
            this.CountryCode = countryCode;
            this.Description = description;
            this.SupportedByELRAPI = supportedByELRAPI;
            this.MandateFormat = mandateFormat;
            this.EInvoicingFlow = eInvoicingFlow;
            this.EInvoicingFlowDocumentationLink = eInvoicingFlowDocumentationLink;
            this.GetInvoiceAvailableMediaType = getInvoiceAvailableMediaType;
            this.SupportsInboundDigitalDocument = supportsInboundDigitalDocument;
            this.InputDataFormats = inputDataFormats;
            this.OutputDataFormats = outputDataFormats;
            this.WorkflowIds = workflowIds;
            this.SupportedDocumentStatuses = supportedDocumentStatuses;
        }

        /// <summary>
        /// The &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). Keep in mind the following when specifying a &#x60;mandateId&#x60;. - A country can have multiple mandate types (B2C, B2B, B2G). - A entity/company can opt in for multiple mandates. - A &#x60;mandateId&#x60; is the combination of country + mandate type + network/regulation.
        /// </summary>
        /// <value>The &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). Keep in mind the following when specifying a &#x60;mandateId&#x60;. - A country can have multiple mandate types (B2C, B2B, B2G). - A entity/company can opt in for multiple mandates. - A &#x60;mandateId&#x60; is the combination of country + mandate type + network/regulation.</value>
        /// <example>AU-B2G-PEPPOL</example>
        [DataMember(Name = "mandateId", EmitDefaultValue = false)]
        public string MandateId { get; set; }

        /// <summary>
        /// **[LEGACY]** This field is retained for backward compatibility. It is recommended to use &#x60;mandateId&#x60; instead. The &#x60;countryMandate&#x60; similar to the &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). 
        /// </summary>
        /// <value>**[LEGACY]** This field is retained for backward compatibility. It is recommended to use &#x60;mandateId&#x60; instead. The &#x60;countryMandate&#x60; similar to the &#x60;mandateId&#x60; is comprised of the country code, mandate type, and the network or regulation type (for example, AU-B2G-PEPPOL). </value>
        /// <example>AU-B2G-PEPPOL</example>
        [DataMember(Name = "countryMandate", EmitDefaultValue = false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        /// <example>AU</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Mandate description
        /// </summary>
        /// <value>Mandate description</value>
        /// <example>The mandate supporting B2G eInvoicing in Australia. This function will create a Peppol BIS 3.0 file and sends the invoice to the related recipient via the Peppol network</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether this mandate supported by the ELR API
        /// </summary>
        /// <value>Indicates whether this mandate supported by the ELR API</value>
        /// <example>true</example>
        [DataMember(Name = "supportedByELRAPI", EmitDefaultValue = true)]
        public bool SupportedByELRAPI { get; set; }

        /// <summary>
        /// Mandate format
        /// </summary>
        /// <value>Mandate format</value>
        /// <example>xml</example>
        [DataMember(Name = "mandateFormat", EmitDefaultValue = false)]
        public string MandateFormat { get; set; }

        /// <summary>
        /// The type of e-invoicing flow for this mandate
        /// </summary>
        /// <value>The type of e-invoicing flow for this mandate</value>
        /// <example>Network</example>
        [DataMember(Name = "eInvoicingFlow", EmitDefaultValue = false)]
        public string EInvoicingFlow { get; set; }

        /// <summary>
        /// Link to the documentation for this mandate&#39;s e-invoicing flow
        /// </summary>
        /// <value>Link to the documentation for this mandate&#39;s e-invoicing flow</value>
        /// <example>https://documentation.example.com/flows/pt-b2c-pdf</example>
        [DataMember(Name = "eInvoicingFlowDocumentationLink", EmitDefaultValue = false)]
        public string EInvoicingFlowDocumentationLink { get; set; }

        /// <summary>
        /// List of available media types for downloading invoices for this mandate
        /// </summary>
        /// <value>List of available media types for downloading invoices for this mandate</value>
        /// <example>[&quot;application/pdf&quot;,&quot;application/xml&quot;]</example>
        [DataMember(Name = "getInvoiceAvailableMediaType", EmitDefaultValue = false)]
        public List<string> GetInvoiceAvailableMediaType { get; set; }

        /// <summary>
        /// Indicates whether this mandate supports inbound digital documents
        /// </summary>
        /// <value>Indicates whether this mandate supports inbound digital documents</value>
        /// <example>TRUE</example>
        [DataMember(Name = "supportsInboundDigitalDocument", EmitDefaultValue = false)]
        public string SupportsInboundDigitalDocument { get; set; }

        /// <summary>
        /// Format and version used when inputting the data
        /// </summary>
        /// <value>Format and version used when inputting the data</value>
        [DataMember(Name = "inputDataFormats", EmitDefaultValue = false)]
        public List<InputDataFormats> InputDataFormats { get; set; }

        /// <summary>
        /// Lists the supported output document formats for the country mandate. For countries where specifying an output document format is required (e.g., France), this array will contain the applicable formats. For other countries where output format selection is not necessary, the array will be empty.
        /// </summary>
        /// <value>Lists the supported output document formats for the country mandate. For countries where specifying an output document format is required (e.g., France), this array will contain the applicable formats. For other countries where output format selection is not necessary, the array will be empty.</value>
        [DataMember(Name = "outputDataFormats", EmitDefaultValue = false)]
        public List<OutputDataFormats> OutputDataFormats { get; set; }

        /// <summary>
        /// Workflow ID list
        /// </summary>
        /// <value>Workflow ID list</value>
        [DataMember(Name = "workflowIds", EmitDefaultValue = false)]
        public List<WorkflowIds> WorkflowIds { get; set; }

        /// <summary>
        /// List of document statuses defined by the mandate.
        /// </summary>
        /// <value>List of document statuses defined by the mandate.</value>
        /// <example>[{&quot;status&quot;:&quot;Approved&quot;,&quot;description&quot;:&quot;Approved by buyer(C4)&quot;},{&quot;status&quot;:&quot;Fully Paid&quot;,&quot;description&quot;:&quot;Payment transmitted to Seller fully from Buyer&quot;},{&quot;status&quot;:&quot;Taken Charge&quot;,&quot;description&quot;:&quot;Document has been taken in charge by the recipient (C4)&quot;}]</example>
        [DataMember(Name = "supportedDocumentStatuses", EmitDefaultValue = false)]
        public List<SupportedDocumentStatuses> SupportedDocumentStatuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Mandate {\n");
            sb.Append("  MandateId: ").Append(MandateId).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SupportedByELRAPI: ").Append(SupportedByELRAPI).Append("\n");
            sb.Append("  MandateFormat: ").Append(MandateFormat).Append("\n");
            sb.Append("  EInvoicingFlow: ").Append(EInvoicingFlow).Append("\n");
            sb.Append("  EInvoicingFlowDocumentationLink: ").Append(EInvoicingFlowDocumentationLink).Append("\n");
            sb.Append("  GetInvoiceAvailableMediaType: ").Append(GetInvoiceAvailableMediaType).Append("\n");
            sb.Append("  SupportsInboundDigitalDocument: ").Append(SupportsInboundDigitalDocument).Append("\n");
            sb.Append("  InputDataFormats: ").Append(InputDataFormats).Append("\n");
            sb.Append("  OutputDataFormats: ").Append(OutputDataFormats).Append("\n");
            sb.Append("  WorkflowIds: ").Append(WorkflowIds).Append("\n");
            sb.Append("  SupportedDocumentStatuses: ").Append(SupportedDocumentStatuses).Append("\n");
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
