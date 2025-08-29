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
 * ## 🔐 Authentication  Generate a **license key** from: *[Avalara Portal](https://www.avalara.com/us/en/signin.html) → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// StateAndLocalWithholding
    /// </summary>
    [DataContract(Name = "StateAndLocalWithholding")]
    public partial class StateAndLocalWithholding : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateAndLocalWithholding" /> class.
        /// </summary>
        /// <param name="stateTaxWithheld">Amount of state tax that was withheld.</param>
        /// <param name="state">US state.</param>
        /// <param name="stateIdNumber">State ID number of the entity issuing the form.</param>
        /// <param name="stateIncome">Amount of state income.</param>
        /// <param name="localTaxWithheld">Amount of local tax that was withheld.</param>
        /// <param name="locality">Locality name.</param>
        /// <param name="localityIdNumber">Locality ID number of the entity issuing the form.</param>
        /// <param name="localIncome">Amount of local income.</param>
        public StateAndLocalWithholding(double? stateTaxWithheld = default(double?), string state = default(string), string stateIdNumber = default(string), double? stateIncome = default(double?), double? localTaxWithheld = default(double?), string locality = default(string), string localityIdNumber = default(string), double? localIncome = default(double?))
        {
            this.StateTaxWithheld = stateTaxWithheld;
            this.State = state;
            this.StateIdNumber = stateIdNumber;
            this.StateIncome = stateIncome;
            this.LocalTaxWithheld = localTaxWithheld;
            this.Locality = locality;
            this.LocalityIdNumber = localityIdNumber;
            this.LocalIncome = localIncome;
        }

        /// <summary>
        /// Amount of state tax that was withheld
        /// </summary>
        /// <value>Amount of state tax that was withheld</value>
        [DataMember(Name = "stateTaxWithheld", EmitDefaultValue = true)]
        public double? StateTaxWithheld { get; set; }

        /// <summary>
        /// US state
        /// </summary>
        /// <value>US state</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// State ID number of the entity issuing the form
        /// </summary>
        /// <value>State ID number of the entity issuing the form</value>
        [DataMember(Name = "stateIdNumber", EmitDefaultValue = true)]
        public string StateIdNumber { get; set; }

        /// <summary>
        /// Amount of state income
        /// </summary>
        /// <value>Amount of state income</value>
        [DataMember(Name = "stateIncome", EmitDefaultValue = true)]
        public double? StateIncome { get; set; }

        /// <summary>
        /// Amount of local tax that was withheld
        /// </summary>
        /// <value>Amount of local tax that was withheld</value>
        [DataMember(Name = "localTaxWithheld", EmitDefaultValue = true)]
        public double? LocalTaxWithheld { get; set; }

        /// <summary>
        /// Locality name
        /// </summary>
        /// <value>Locality name</value>
        [DataMember(Name = "locality", EmitDefaultValue = true)]
        public string Locality { get; set; }

        /// <summary>
        /// Locality ID number of the entity issuing the form
        /// </summary>
        /// <value>Locality ID number of the entity issuing the form</value>
        [DataMember(Name = "localityIdNumber", EmitDefaultValue = true)]
        public string LocalityIdNumber { get; set; }

        /// <summary>
        /// Amount of local income
        /// </summary>
        /// <value>Amount of local income</value>
        [DataMember(Name = "localIncome", EmitDefaultValue = true)]
        public double? LocalIncome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateAndLocalWithholding {\n");
            sb.Append("  StateTaxWithheld: ").Append(StateTaxWithheld).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateIdNumber: ").Append(StateIdNumber).Append("\n");
            sb.Append("  StateIncome: ").Append(StateIncome).Append("\n");
            sb.Append("  LocalTaxWithheld: ").Append(LocalTaxWithheld).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  LocalityIdNumber: ").Append(LocalityIdNumber).Append("\n");
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
