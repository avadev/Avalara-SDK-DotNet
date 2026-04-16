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
    /// Represents a single report with full details including metadata and associated transaction IDs.
    /// </summary>
    [DataContract(Name = "ReportItem")]
    public partial class ReportItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportItem" /> class.
        /// </summary>
        /// <param name="reportId">The unique ID for this report..</param>
        /// <param name="jobId">The unique ID of the job that generated this report..</param>
        /// <param name="reportGenerateDate">The date and time when the report was generated..</param>
        /// <param name="reportFrom">The start date of the reporting period..</param>
        /// <param name="reportTo">The end date of the reporting period..</param>
        /// <param name="countryCode">The two-letter ISO-3166 country code for which this report was generated..</param>
        /// <param name="countryMandate">The e-invoicing mandate for the specified country..</param>
        /// <param name="documentType">The type of document covered by this report..</param>
        /// <param name="documentSubType">The sub-type of the document..</param>
        /// <param name="reportReference">An internal reference path for the report..</param>
        /// <param name="reportName">The name of the report file..</param>
        /// <param name="status">The current status of the report. Possible values include: PENDING, PROCESSING, COMPLETED, FAILED, SENT_TO_PPF, ERROR..</param>
        /// <param name="reportFormatMimetypes">The MIME type of the report file..</param>
        /// <param name="tenantId">The tenant identifier associated with this report..</param>
        /// <param name="taName">The name of the tax authority for this report..</param>
        /// <param name="taxInvoiceAmount">The total invoice amount covered by this report..</param>
        /// <param name="totalTaxAmount">The total tax amount covered by this report..</param>
        /// <param name="metadata">Additional report metadata (free-form JSON). Contents vary by country mandate..</param>
        /// <param name="transactionIds">List of transaction IDs associated with this report..</param>
        public ReportItem(string reportId = default(string), string jobId = default(string), DateTime reportGenerateDate = default(DateTime), DateTime? reportFrom = default(DateTime?), DateTime? reportTo = default(DateTime?), string countryCode = default(string), string countryMandate = default(string), string documentType = default(string), string documentSubType = default(string), string reportReference = default(string), string reportName = default(string), string status = default(string), string reportFormatMimetypes = default(string), string tenantId = default(string), string taName = default(string), decimal? taxInvoiceAmount = default(decimal?), decimal? totalTaxAmount = default(decimal?), Object metadata = default(Object), List<string> transactionIds = default(List<string>))
        {
            this.ReportId = reportId;
            this.JobId = jobId;
            this.ReportGenerateDate = reportGenerateDate;
            this.ReportFrom = reportFrom;
            this.ReportTo = reportTo;
            this.CountryCode = countryCode;
            this.CountryMandate = countryMandate;
            this.DocumentType = documentType;
            this.DocumentSubType = documentSubType;
            this.ReportReference = reportReference;
            this.ReportName = reportName;
            this.Status = status;
            this.ReportFormatMimetypes = reportFormatMimetypes;
            this.TenantId = tenantId;
            this.TaName = taName;
            this.TaxInvoiceAmount = taxInvoiceAmount;
            this.TotalTaxAmount = totalTaxAmount;
            this.Metadata = metadata;
            this.TransactionIds = transactionIds;
        }

        /// <summary>
        /// The unique ID for this report.
        /// </summary>
        /// <value>The unique ID for this report.</value>
        /// <example>bd82c787-c163-44f1-a784-c45a6c6ded61</example>
        [DataMember(Name = "reportId", EmitDefaultValue = false)]
        public string ReportId { get; set; }

        /// <summary>
        /// The unique ID of the job that generated this report.
        /// </summary>
        /// <value>The unique ID of the job that generated this report.</value>
        /// <example>db8914ce-fbf4-3d60-96d7-95a6464eec43</example>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// The date and time when the report was generated.
        /// </summary>
        /// <value>The date and time when the report was generated.</value>
        /// <example>2026-03-02T12:40:14.529894Z</example>
        [DataMember(Name = "reportGenerateDate", EmitDefaultValue = false)]
        public DateTime ReportGenerateDate { get; set; }

        /// <summary>
        /// The start date of the reporting period.
        /// </summary>
        /// <value>The start date of the reporting period.</value>
        /// <example>Sat Jan 31 16:00:00 PST 2026</example>
        [DataMember(Name = "reportFrom", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ReportFrom { get; set; }

        /// <summary>
        /// The end date of the reporting period.
        /// </summary>
        /// <value>The end date of the reporting period.</value>
        /// <example>Fri Feb 27 16:00:00 PST 2026</example>
        [DataMember(Name = "reportTo", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ReportTo { get; set; }

        /// <summary>
        /// The two-letter ISO-3166 country code for which this report was generated.
        /// </summary>
        /// <value>The two-letter ISO-3166 country code for which this report was generated.</value>
        /// <example>FR</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The e-invoicing mandate for the specified country.
        /// </summary>
        /// <value>The e-invoicing mandate for the specified country.</value>
        /// <example>FR-B2B-REPORTING</example>
        [DataMember(Name = "countryMandate", EmitDefaultValue = false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// The type of document covered by this report.
        /// </summary>
        /// <value>The type of document covered by this report.</value>
        /// <example>TAX_REPORT</example>
        [DataMember(Name = "documentType", EmitDefaultValue = true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// The sub-type of the document.
        /// </summary>
        /// <value>The sub-type of the document.</value>
        /// <example>MONTHLY_SALES_TAX</example>
        [DataMember(Name = "documentSubType", EmitDefaultValue = true)]
        public string DocumentSubType { get; set; }

        /// <summary>
        /// An internal reference path for the report.
        /// </summary>
        /// <value>An internal reference path for the report.</value>
        /// <example>/document-exchange/pv/tr-consolidated-reports/fc63d180/output/fc63d180.xml</example>
        [DataMember(Name = "reportReference", EmitDefaultValue = true)]
        public string ReportReference { get; set; }

        /// <summary>
        /// The name of the report file.
        /// </summary>
        /// <value>The name of the report file.</value>
        /// <example>FFE1025A_PPF070_PPF0702026000000000000002</example>
        [DataMember(Name = "reportName", EmitDefaultValue = false)]
        public string ReportName { get; set; }

        /// <summary>
        /// The current status of the report. Possible values include: PENDING, PROCESSING, COMPLETED, FAILED, SENT_TO_PPF, ERROR.
        /// </summary>
        /// <value>The current status of the report. Possible values include: PENDING, PROCESSING, COMPLETED, FAILED, SENT_TO_PPF, ERROR.</value>
        /// <example>SENT_TO_PPF</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The MIME type of the report file.
        /// </summary>
        /// <value>The MIME type of the report file.</value>
        /// <example>application/xml</example>
        [DataMember(Name = "reportFormatMimetypes", EmitDefaultValue = false)]
        public string ReportFormatMimetypes { get; set; }

        /// <summary>
        /// The tenant identifier associated with this report.
        /// </summary>
        /// <value>The tenant identifier associated with this report.</value>
        /// <example>64e46c39b55286c29d5b1693</example>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The name of the tax authority for this report.
        /// </summary>
        /// <value>The name of the tax authority for this report.</value>
        /// <example>DGFiP</example>
        [DataMember(Name = "taName", EmitDefaultValue = false)]
        public string TaName { get; set; }

        /// <summary>
        /// The total invoice amount covered by this report.
        /// </summary>
        /// <value>The total invoice amount covered by this report.</value>
        /// <example>210.0</example>
        [DataMember(Name = "taxInvoiceAmount", EmitDefaultValue = true)]
        public decimal? TaxInvoiceAmount { get; set; }

        /// <summary>
        /// The total tax amount covered by this report.
        /// </summary>
        /// <value>The total tax amount covered by this report.</value>
        /// <example>0.0</example>
        [DataMember(Name = "totalTaxAmount", EmitDefaultValue = true)]
        public decimal? TotalTaxAmount { get; set; }

        /// <summary>
        /// Additional report metadata (free-form JSON). Contents vary by country mandate.
        /// </summary>
        /// <value>Additional report metadata (free-form JSON). Contents vary by country mandate.</value>
        /// <example>{&quot;source&quot;:&quot;ERP&quot;,&quot;issuerId&quot;:&quot;100000009&quot;,&quot;typeCode&quot;:&quot;IN&quot;,&quot;xsdValid&quot;:true,&quot;isInitial&quot;:true,&quot;reportCode&quot;:&quot;2026000000000000002&quot;,&quot;reportType&quot;:&quot;B2B_PURCHASE&quot;,&quot;validationTraceId&quot;:&quot;4029daef-315d-4e20-bb7b-2b2f7b5445ac&quot;}</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// List of transaction IDs associated with this report.
        /// </summary>
        /// <value>List of transaction IDs associated with this report.</value>
        /// <example>[&quot;4555746c-98d1-4509-92fd-f677eee18040&quot;]</example>
        [DataMember(Name = "transactionIds", EmitDefaultValue = false)]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportItem {\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ReportGenerateDate: ").Append(ReportGenerateDate).Append("\n");
            sb.Append("  ReportFrom: ").Append(ReportFrom).Append("\n");
            sb.Append("  ReportTo: ").Append(ReportTo).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DocumentSubType: ").Append(DocumentSubType).Append("\n");
            sb.Append("  ReportReference: ").Append(ReportReference).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReportFormatMimetypes: ").Append(ReportFormatMimetypes).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TaName: ").Append(TaName).Append("\n");
            sb.Append("  TaxInvoiceAmount: ").Append(TaxInvoiceAmount).Append("\n");
            sb.Append("  TotalTaxAmount: ").Append(TotalTaxAmount).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
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
