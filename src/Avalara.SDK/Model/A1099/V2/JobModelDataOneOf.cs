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
    /// JobModelDataOneOf
    /// </summary>
    [DataContract(Name = "JobModel_data_oneOf")]
    public partial class JobModelDataOneOf : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobModelDataOneOf" /> class.
        /// </summary>
        /// <param name="upsert">upsert.</param>
        /// <param name="bulkDownload">bulkDownload.</param>
        public JobModelDataOneOf(JobModelDataOneOfUpsert upsert = default(JobModelDataOneOfUpsert), JobModelDataOneOfBulkDownload bulkDownload = default(JobModelDataOneOfBulkDownload))
        {
            this.Upsert = upsert;
            this.BulkDownload = bulkDownload;
        }

        /// <summary>
        /// Gets or Sets Upsert
        /// </summary>
        [DataMember(Name = "upsert", EmitDefaultValue = false)]
        public JobModelDataOneOfUpsert Upsert { get; set; }

        /// <summary>
        /// Gets or Sets BulkDownload
        /// </summary>
        [DataMember(Name = "bulkDownload", EmitDefaultValue = false)]
        public JobModelDataOneOfBulkDownload BulkDownload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobModelDataOneOf {\n");
            sb.Append("  Upsert: ").Append(Upsert).Append("\n");
            sb.Append("  BulkDownload: ").Append(BulkDownload).Append("\n");
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
