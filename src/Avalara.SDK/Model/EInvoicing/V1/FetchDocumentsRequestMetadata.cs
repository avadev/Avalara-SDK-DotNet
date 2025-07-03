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
    /// FetchDocumentsRequestMetadata
    /// </summary>
    [DataContract(Name = "FetchDocuments_request_metadata")]
    public partial class FetchDocumentsRequestMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchDocumentsRequestMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FetchDocumentsRequestMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchDocumentsRequestMetadata" /> class.
        /// </summary>
        /// <param name="workflowId">Specifies a unique ID for this workflow. (required).</param>
        /// <param name="dataFormat">Specifies the data format for this workflow (required).</param>
        /// <param name="dataFormatVersion">Specifies the data format version number (required).</param>
        /// <param name="outputDataFormat">Specifies the format of the output document to be generated for the recipient. This format should be chosen based on the recipient&#39;s preferences or requirements as defined by applicable e-invoicing regulations. When not specified for mandates that don&#39;t require a specific output format, the system will use the default format defined for that mandate. (required).</param>
        /// <param name="outputDataFormatVersion">Specifies the version of the selected output document format (required).</param>
        /// <param name="countryCode">The two-letter ISO-3166 country code for the country for which document is being retrieved (required).</param>
        /// <param name="countryMandate">The e-invoicing mandate for the specified country (required).</param>
        public FetchDocumentsRequestMetadata(string workflowId = default(string), string dataFormat = default(string), decimal dataFormatVersion = default(decimal), string outputDataFormat = default(string), decimal outputDataFormatVersion = default(decimal), string countryCode = default(string), string countryMandate = default(string))
        {
            // to ensure "workflowId" is required (not null)
            if (workflowId == null)
            {
                throw new ArgumentNullException("workflowId is a required property for FetchDocumentsRequestMetadata and cannot be null");
            }
            this.WorkflowId = workflowId;
            // to ensure "dataFormat" is required (not null)
            if (dataFormat == null)
            {
                throw new ArgumentNullException("dataFormat is a required property for FetchDocumentsRequestMetadata and cannot be null");
            }
            this.DataFormat = dataFormat;
            this.DataFormatVersion = dataFormatVersion;
            // to ensure "outputDataFormat" is required (not null)
            if (outputDataFormat == null)
            {
                throw new ArgumentNullException("outputDataFormat is a required property for FetchDocumentsRequestMetadata and cannot be null");
            }
            this.OutputDataFormat = outputDataFormat;
            this.OutputDataFormatVersion = outputDataFormatVersion;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for FetchDocumentsRequestMetadata and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "countryMandate" is required (not null)
            if (countryMandate == null)
            {
                throw new ArgumentNullException("countryMandate is a required property for FetchDocumentsRequestMetadata and cannot be null");
            }
            this.CountryMandate = countryMandate;
        }

        /// <summary>
        /// Specifies a unique ID for this workflow.
        /// </summary>
        /// <value>Specifies a unique ID for this workflow.</value>
        /// <example>partner-einvoicing</example>
        [DataMember(Name = "workflowId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Specifies the data format for this workflow
        /// </summary>
        /// <value>Specifies the data format for this workflow</value>
        /// <example>ubl-invoice</example>
        [DataMember(Name = "dataFormat", IsRequired = true, EmitDefaultValue = true)]
        public string DataFormat { get; set; }

        /// <summary>
        /// Specifies the data format version number
        /// </summary>
        /// <value>Specifies the data format version number</value>
        /// <example>2.1</example>
        [DataMember(Name = "dataFormatVersion", IsRequired = true, EmitDefaultValue = true)]
        public decimal DataFormatVersion { get; set; }

        /// <summary>
        /// Specifies the format of the output document to be generated for the recipient. This format should be chosen based on the recipient&#39;s preferences or requirements as defined by applicable e-invoicing regulations. When not specified for mandates that don&#39;t require a specific output format, the system will use the default format defined for that mandate.
        /// </summary>
        /// <value>Specifies the format of the output document to be generated for the recipient. This format should be chosen based on the recipient&#39;s preferences or requirements as defined by applicable e-invoicing regulations. When not specified for mandates that don&#39;t require a specific output format, the system will use the default format defined for that mandate.</value>
        /// <example>ubl-invoice</example>
        [DataMember(Name = "outputDataFormat", IsRequired = true, EmitDefaultValue = true)]
        public string OutputDataFormat { get; set; }

        /// <summary>
        /// Specifies the version of the selected output document format
        /// </summary>
        /// <value>Specifies the version of the selected output document format</value>
        /// <example>2.1</example>
        [DataMember(Name = "outputDataFormatVersion", IsRequired = true, EmitDefaultValue = true)]
        public decimal OutputDataFormatVersion { get; set; }

        /// <summary>
        /// The two-letter ISO-3166 country code for the country for which document is being retrieved
        /// </summary>
        /// <value>The two-letter ISO-3166 country code for the country for which document is being retrieved</value>
        /// <example>IL</example>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The e-invoicing mandate for the specified country
        /// </summary>
        /// <value>The e-invoicing mandate for the specified country</value>
        /// <example>IL-B2B-CLEARANCE</example>
        [DataMember(Name = "countryMandate", IsRequired = true, EmitDefaultValue = true)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FetchDocumentsRequestMetadata {\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  DataFormat: ").Append(DataFormat).Append("\n");
            sb.Append("  DataFormatVersion: ").Append(DataFormatVersion).Append("\n");
            sb.Append("  OutputDataFormat: ").Append(OutputDataFormat).Append("\n");
            sb.Append("  OutputDataFormatVersion: ").Append(OutputDataFormatVersion).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
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
