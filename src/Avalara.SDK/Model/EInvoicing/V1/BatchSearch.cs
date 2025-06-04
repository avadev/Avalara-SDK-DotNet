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
    /// BatchSearch
    /// </summary>
    [DataContract(Name = "BatchSearch")]
    public partial class BatchSearch : IValidatableObject
    {
        /// <summary>
        /// Status of the batch search
        /// </summary>
        /// <value>Status of the batch search</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 1,

            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3,

            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 4
        }


        /// <summary>
        /// Status of the batch search
        /// </summary>
        /// <value>Status of the batch search</value>
        /// <example>Accepted</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSearch" /> class.
        /// </summary>
        /// <param name="id">ID of the batch search.</param>
        /// <param name="name">Name of the batch report.</param>
        /// <param name="createdBy">Email of the user who created the batch search.</param>
        /// <param name="created">Timestamp when the batch search was created.</param>
        /// <param name="lastModified">Timestamp when the batch search was created.</param>
        /// <param name="status">Status of the batch search.</param>
        /// <param name="error">error.</param>
        public BatchSearch(string id = default(string), string name = default(string), string createdBy = default(string), DateTime created = default(DateTime), DateTime lastModified = default(DateTime), StatusEnum? status = default(StatusEnum?), ErrorResponse error = default(ErrorResponse))
        {
            this.Id = id;
            this.Name = name;
            this.CreatedBy = createdBy;
            this.Created = created;
            this.LastModified = lastModified;
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// ID of the batch search
        /// </summary>
        /// <value>ID of the batch search</value>
        /// <example>2f5ea4b5-4dae-445a-b3e4-9f65a61eaa99</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the batch report
        /// </summary>
        /// <value>Name of the batch report</value>
        /// <example>Batch Search Report 1</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Email of the user who created the batch search
        /// </summary>
        /// <value>Email of the user who created the batch search</value>
        /// <example>user@example.com</example>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Timestamp when the batch search was created
        /// </summary>
        /// <value>Timestamp when the batch search was created</value>
        /// <example>2024-08-01T12:34:56Z</example>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Timestamp when the batch search was created
        /// </summary>
        /// <value>Timestamp when the batch search was created</value>
        /// <example>2024-08-01T12:34:56Z</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchSearch {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
