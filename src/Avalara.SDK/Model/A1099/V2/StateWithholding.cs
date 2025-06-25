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
    /// StateWithholding
    /// </summary>
    [DataContract(Name = "stateWithholding")]
    public partial class StateWithholding : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateWithholding" /> class.
        /// </summary>
        /// <param name="taxWithheld">The amount of state tax withheld, if any..</param>
        /// <param name="state">The state associated with the withholding..</param>
        /// <param name="payerStateNo">The payer&#39;s state number..</param>
        /// <param name="income">The state income reported..</param>
        /// <param name="localTaxWithheld">The local tax withheld reported..</param>
        /// <param name="locality">The locality reported..</param>
        /// <param name="localIncome">The local income reported..</param>
        public StateWithholding(double? taxWithheld = default(double?), string state = default(string), string payerStateNo = default(string), double? income = default(double?), double? localTaxWithheld = default(double?), string locality = default(string), double? localIncome = default(double?))
        {
            this.TaxWithheld = taxWithheld;
            this.State = state;
            this.PayerStateNo = payerStateNo;
            this.Income = income;
            this.LocalTaxWithheld = localTaxWithheld;
            this.Locality = locality;
            this.LocalIncome = localIncome;
        }

        /// <summary>
        /// The amount of state tax withheld, if any.
        /// </summary>
        /// <value>The amount of state tax withheld, if any.</value>
        [DataMember(Name = "taxWithheld", EmitDefaultValue = true)]
        public double? TaxWithheld { get; set; }

        /// <summary>
        /// The state associated with the withholding.
        /// </summary>
        /// <value>The state associated with the withholding.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The payer&#39;s state number.
        /// </summary>
        /// <value>The payer&#39;s state number.</value>
        [DataMember(Name = "payerStateNo", EmitDefaultValue = true)]
        public string PayerStateNo { get; set; }

        /// <summary>
        /// The state income reported.
        /// </summary>
        /// <value>The state income reported.</value>
        [DataMember(Name = "income", EmitDefaultValue = true)]
        public double? Income { get; set; }

        /// <summary>
        /// The local tax withheld reported.
        /// </summary>
        /// <value>The local tax withheld reported.</value>
        [DataMember(Name = "localTaxWithheld", EmitDefaultValue = true)]
        public double? LocalTaxWithheld { get; set; }

        /// <summary>
        /// The locality reported.
        /// </summary>
        /// <value>The locality reported.</value>
        [DataMember(Name = "locality", EmitDefaultValue = true)]
        public string Locality { get; set; }

        /// <summary>
        /// The local income reported.
        /// </summary>
        /// <value>The local income reported.</value>
        [DataMember(Name = "localIncome", EmitDefaultValue = true)]
        public double? LocalIncome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateWithholding {\n");
            sb.Append("  TaxWithheld: ").Append(TaxWithheld).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PayerStateNo: ").Append(PayerStateNo).Append("\n");
            sb.Append("  Income: ").Append(Income).Append("\n");
            sb.Append("  LocalTaxWithheld: ").Append(LocalTaxWithheld).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  LocalIncome: ").Append(LocalIncome).Append("\n");
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
