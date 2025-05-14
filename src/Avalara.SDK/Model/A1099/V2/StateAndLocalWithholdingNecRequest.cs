/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 & W-9 API Definition
 *
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// StateAndLocalWithholdingNecRequest
    /// </summary>
    [DataContract(Name = "StateAndLocalWithholdingNecRequest")]
    public partial class StateAndLocalWithholdingNecRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateAndLocalWithholdingNecRequest" /> class.
        /// </summary>
        /// <param name="stateTaxWithheld">stateTaxWithheld.</param>
        /// <param name="state">state.</param>
        /// <param name="payerStateNumber">payerStateNumber.</param>
        /// <param name="stateIncome">stateIncome.</param>
        /// <param name="localTaxWithheld">localTaxWithheld.</param>
        /// <param name="locality">locality.</param>
        /// <param name="localIncome">localIncome.</param>
        public StateAndLocalWithholdingNecRequest(double stateTaxWithheld = default(double), string state = default(string), string payerStateNumber = default(string), double stateIncome = default(double), double localTaxWithheld = default(double), string locality = default(string), double localIncome = default(double))
        {
            this.StateTaxWithheld = stateTaxWithheld;
            this.State = state;
            this.PayerStateNumber = payerStateNumber;
            this.StateIncome = stateIncome;
            this.LocalTaxWithheld = localTaxWithheld;
            this.Locality = locality;
            this.LocalIncome = localIncome;
        }

        /// <summary>
        /// Gets or Sets StateTaxWithheld
        /// </summary>
        [DataMember(Name = "stateTaxWithheld", EmitDefaultValue = false)]
        public double StateTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PayerStateNumber
        /// </summary>
        [DataMember(Name = "payerStateNumber", EmitDefaultValue = false)]
        public string PayerStateNumber { get; set; }

        /// <summary>
        /// Gets or Sets StateIncome
        /// </summary>
        [DataMember(Name = "stateIncome", EmitDefaultValue = false)]
        public double StateIncome { get; set; }

        /// <summary>
        /// Gets or Sets LocalTaxWithheld
        /// </summary>
        [DataMember(Name = "localTaxWithheld", EmitDefaultValue = false)]
        public double LocalTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name = "locality", EmitDefaultValue = false)]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or Sets LocalIncome
        /// </summary>
        [DataMember(Name = "localIncome", EmitDefaultValue = false)]
        public double LocalIncome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateAndLocalWithholdingNecRequest {\n");
            sb.Append("  StateTaxWithheld: ").Append(StateTaxWithheld).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PayerStateNumber: ").Append(PayerStateNumber).Append("\n");
            sb.Append("  StateIncome: ").Append(StateIncome).Append("\n");
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
