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
    /// JobModelDataOneOfUpsert
    /// </summary>
    [DataContract(Name = "JobModel_data_oneOf_upsert")]
    public partial class JobModelDataOneOfUpsert : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobModelDataOneOfUpsert" /> class.
        /// </summary>
        /// <param name="importedCount">Current tally of forms successfully imported..</param>
        /// <param name="okCount">Current tally of forms ready to schedule with IRS and/or State..</param>
        /// <param name="missingEmailCount">Current tally of forms without an email..</param>
        /// <param name="errorCount">Current tally of forms with one or more errors that cannot be scheduled for IRS or State..</param>
        public JobModelDataOneOfUpsert(int importedCount = default(int), int? okCount = default(int?), int? missingEmailCount = default(int?), int? errorCount = default(int?))
        {
            this.ImportedCount = importedCount;
            this.OkCount = okCount;
            this.MissingEmailCount = missingEmailCount;
            this.ErrorCount = errorCount;
        }

        /// <summary>
        /// Current tally of forms successfully imported.
        /// </summary>
        /// <value>Current tally of forms successfully imported.</value>
        /// <example>0</example>
        [DataMember(Name = "importedCount", EmitDefaultValue = false)]
        public int ImportedCount { get; set; }

        /// <summary>
        /// Current tally of forms ready to schedule with IRS and/or State.
        /// </summary>
        /// <value>Current tally of forms ready to schedule with IRS and/or State.</value>
        [DataMember(Name = "okCount", EmitDefaultValue = true)]
        public int? OkCount { get; set; }

        /// <summary>
        /// Current tally of forms without an email.
        /// </summary>
        /// <value>Current tally of forms without an email.</value>
        [DataMember(Name = "missingEmailCount", EmitDefaultValue = true)]
        public int? MissingEmailCount { get; set; }

        /// <summary>
        /// Current tally of forms with one or more errors that cannot be scheduled for IRS or State.
        /// </summary>
        /// <value>Current tally of forms with one or more errors that cannot be scheduled for IRS or State.</value>
        [DataMember(Name = "errorCount", EmitDefaultValue = true)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobModelDataOneOfUpsert {\n");
            sb.Append("  ImportedCount: ").Append(ImportedCount).Append("\n");
            sb.Append("  OkCount: ").Append(OkCount).Append("\n");
            sb.Append("  MissingEmailCount: ").Append(MissingEmailCount).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
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
