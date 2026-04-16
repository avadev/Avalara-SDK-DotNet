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
    /// Displays a summary of information about the document
    /// </summary>
    [DataContract(Name = "DocumentSummary")]
    public partial class DocumentSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSummary" /> class.
        /// </summary>
        /// <param name="id">The unique ID for this document.</param>
        /// <param name="companyId">Unique identifier that represents the company within the system..</param>
        /// <param name="processDateTime">The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="status">The Document status.</param>
        /// <param name="businessStatus">Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation..</param>
        /// <param name="supplierName">The name of the supplier in the transaction.</param>
        /// <param name="customerName">The name of the customer in the transaction.</param>
        /// <param name="documentType">The document type.</param>
        /// <param name="documentVersion">The document version.</param>
        /// <param name="documentNumber">The document number.</param>
        /// <param name="documentDate">The document issue date.</param>
        /// <param name="flow">The document direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;.</param>
        /// <param name="countryCode">The two-letter ISO-3166 country code for the country where the document is being submitted.</param>
        /// <param name="countryMandate">The e-invoicing mandate for the specified country.</param>
        /// <param name="varInterface">The interface where the document is sent.</param>
        /// <param name="receiver">The document recipient based on the interface.</param>
        /// <param name="events">Array of status events associated with this document. Events are included in each document in the response only when the query parameter $include&#x3D;events is passed; otherwise the events array is not populated..</param>
        /// <param name="createdAt">The date and time when the document was created in the system, displayed in ISO 8601 format with timezone.</param>
        /// <param name="lastUpdatedAt">The date and time when the document was last updated in the system, displayed in ISO 8601 format with timezone.</param>
        public DocumentSummary(string id = default(string), string companyId = default(string), string processDateTime = default(string), string status = default(string), string businessStatus = default(string), string supplierName = default(string), string customerName = default(string), string documentType = default(string), string documentVersion = default(string), string documentNumber = default(string), string documentDate = default(string), string flow = default(string), string countryCode = default(string), string countryMandate = default(string), string varInterface = default(string), string receiver = default(string), List<StatusEvent> events = default(List<StatusEvent>), string createdAt = default(string), string lastUpdatedAt = default(string))
        {
            this.Id = id;
            this.CompanyId = companyId;
            this.ProcessDateTime = processDateTime;
            this.Status = status;
            this.BusinessStatus = businessStatus;
            this.SupplierName = supplierName;
            this.CustomerName = customerName;
            this.DocumentType = documentType;
            this.DocumentVersion = documentVersion;
            this.DocumentNumber = documentNumber;
            this.DocumentDate = documentDate;
            this.Flow = flow;
            this.CountryCode = countryCode;
            this.CountryMandate = countryMandate;
            this.Interface = varInterface;
            this.Receiver = receiver;
            this.Events = events;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// The unique ID for this document
        /// </summary>
        /// <value>The unique ID for this document</value>
        /// <example>52f60401-44d0-4667-ad47-4afe519abb53</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier that represents the company within the system.
        /// </summary>
        /// <value>Unique identifier that represents the company within the system.</value>
        /// <example>a5869a7b-4d5d-4ec1-9b29-fd272aa58ab2</example>
        [DataMember(Name = "companyId", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss</value>
        /// <example>2022-01-09T12:36:02</example>
        [DataMember(Name = "processDateTime", EmitDefaultValue = false)]
        public string ProcessDateTime { get; set; }

        /// <summary>
        /// The Document status
        /// </summary>
        /// <value>The Document status</value>
        /// <example>Complete</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation.
        /// </summary>
        /// <value>Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation.</value>
        /// <example>Approved</example>
        [DataMember(Name = "businessStatus", EmitDefaultValue = false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The name of the supplier in the transaction
        /// </summary>
        /// <value>The name of the supplier in the transaction</value>
        /// <example>Inposia GmbH</example>
        [DataMember(Name = "supplierName", EmitDefaultValue = false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// The name of the customer in the transaction
        /// </summary>
        /// <value>The name of the customer in the transaction</value>
        /// <example>Avalara Inc.</example>
        [DataMember(Name = "customerName", EmitDefaultValue = false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// The document type
        /// </summary>
        /// <value>The document type</value>
        /// <example>ubl-invoice</example>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// The document version
        /// </summary>
        /// <value>The document version</value>
        /// <example>2.1</example>
        [DataMember(Name = "documentVersion", EmitDefaultValue = false)]
        public string DocumentVersion { get; set; }

        /// <summary>
        /// The document number
        /// </summary>
        /// <value>The document number</value>
        /// <example>8042091758</example>
        [DataMember(Name = "documentNumber", EmitDefaultValue = false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// The document issue date
        /// </summary>
        /// <value>The document issue date</value>
        /// <example>2022-01-09</example>
        [DataMember(Name = "documentDate", EmitDefaultValue = false)]
        public string DocumentDate { get; set; }

        /// <summary>
        /// The document direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;
        /// </summary>
        /// <value>The document direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;</value>
        /// <example>out</example>
        [DataMember(Name = "flow", EmitDefaultValue = false)]
        public string Flow { get; set; }

        /// <summary>
        /// The two-letter ISO-3166 country code for the country where the document is being submitted
        /// </summary>
        /// <value>The two-letter ISO-3166 country code for the country where the document is being submitted</value>
        /// <example>DE</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The e-invoicing mandate for the specified country
        /// </summary>
        /// <value>The e-invoicing mandate for the specified country</value>
        /// <example>DE-B2G-XRECHNUNG</example>
        [DataMember(Name = "countryMandate", EmitDefaultValue = false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// The interface where the document is sent
        /// </summary>
        /// <value>The interface where the document is sent</value>
        /// <example>PEPPOL</example>
        [DataMember(Name = "interface", EmitDefaultValue = false)]
        public string Interface { get; set; }

        /// <summary>
        /// The document recipient based on the interface
        /// </summary>
        /// <value>The document recipient based on the interface</value>
        /// <example>9930:AVALARATEST</example>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public string Receiver { get; set; }

        /// <summary>
        /// Array of status events associated with this document. Events are included in each document in the response only when the query parameter $include&#x3D;events is passed; otherwise the events array is not populated.
        /// </summary>
        /// <value>Array of status events associated with this document. Events are included in each document in the response only when the query parameter $include&#x3D;events is passed; otherwise the events array is not populated.</value>
        [DataMember(Name = "events", EmitDefaultValue = true)]
        public List<StatusEvent> Events { get; set; }

        /// <summary>
        /// The date and time when the document was created in the system, displayed in ISO 8601 format with timezone
        /// </summary>
        /// <value>The date and time when the document was created in the system, displayed in ISO 8601 format with timezone</value>
        /// <example>2025-01-09T12:36:02.000Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the document was last updated in the system, displayed in ISO 8601 format with timezone
        /// </summary>
        /// <value>The date and time when the document was last updated in the system, displayed in ISO 8601 format with timezone</value>
        /// <example>2025-01-09T14:22:15.000Z</example>
        [DataMember(Name = "lastUpdatedAt", EmitDefaultValue = false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ProcessDateTime: ").Append(ProcessDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BusinessStatus: ").Append(BusinessStatus).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
            sb.Append("  Interface: ").Append(Interface).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
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
