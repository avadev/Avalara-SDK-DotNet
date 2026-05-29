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
 * ## Authentication  #### Step 1: Generate API Credentials  Generate a *client ID* and *client secret* from your [Avalara1099 account](https://sbx.track1099.com/api_tokens): *Your Profile → API*.  #### Step 2: Get an Identity Token  Send a `POST` request to the **Identity Token URL** with your *client ID* and *client secret* from Step 1 as form-encoded parameters:  ```http POST https://identity.avalara.com/connect/token Content-Type: application/x-www-form-urlencoded  grant_type=client_credentials client_id=<your client ID> client_secret=<your client secret> ```  **Body parameters** - `grant_type` — Always `client_credentials` - `client_id` — Your *client ID* from Step 1 - `client_secret` — Your *client secret* from Step 1  **Successful response**  ```json {   \"access_token\": \"eyJhbGci...\",   \"expires_in\": 3600,   \"token_type\": \"Bearer\" } ```  Use the `access_token` as a bearer token in the `Authorization` header on every A1099 API request:  ```http Authorization: Bearer <access_token> ```  - --  For more on authenticating requests, see the [A1099 authentication guide](https://developer.avalara.com/1099-and-w-9/kny2997001535374/).  - --  ## Environments  #### Production - **Avalara 1099 API URL:** [`https://api.avalara.com/avalara1099`](https://api.avalara.com/avalara1099) - **Identity Token URL:** [`https://identity.avalara.com/connect/token`](https://identity.avalara.com/connect/token)  #### Sandbox - **Avalara 1099 API URL:** [`https://api.sbx.avalara.com/avalara1099`](https://api.sbx.avalara.com/avalara1099) - **Identity Token URL:** [`https://ai-sbx.avlr.sh/connect/token`](https://ai-sbx.avlr.sh/connect/token)  - --  ## API & SDK Documentation  [Avalara 1099 API Reference](https://developer.avalara.com/api-reference/avalara1099/avalara1099/)  [Avalara SDKs](https://developer.avalara.com/sdk/)  [Swagger](https://api.avalara.com/avalara1099/swagger/index.html?api-version=2.0)
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
        /// <param name="stateId">State ID of the entity issuing the form.</param>
        /// <param name="stateIncome">Amount of state income.</param>
        /// <param name="localTaxWithheld">Amount of local tax that was withheld.</param>
        /// <param name="locality">Locality name.</param>
        /// <param name="localityId">Locality ID of the entity issuing the form.</param>
        /// <param name="localIncome">Amount of local income.</param>
        public StateAndLocalWithholding(double? stateTaxWithheld = default(double?), string state = default(string), string stateId = default(string), double? stateIncome = default(double?), double? localTaxWithheld = default(double?), string locality = default(string), string localityId = default(string), double? localIncome = default(double?))
        {
            this.StateTaxWithheld = stateTaxWithheld;
            this.State = state;
            this.StateId = stateId;
            this.StateIncome = stateIncome;
            this.LocalTaxWithheld = localTaxWithheld;
            this.Locality = locality;
            this.LocalityId = localityId;
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
        /// State ID of the entity issuing the form
        /// </summary>
        /// <value>State ID of the entity issuing the form</value>
        [DataMember(Name = "stateId", EmitDefaultValue = true)]
        public string StateId { get; set; }

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
        /// Locality ID of the entity issuing the form
        /// </summary>
        /// <value>Locality ID of the entity issuing the form</value>
        [DataMember(Name = "localityId", EmitDefaultValue = true)]
        public string LocalityId { get; set; }

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
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  StateIncome: ").Append(StateIncome).Append("\n");
            sb.Append("  LocalTaxWithheld: ").Append(LocalTaxWithheld).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  LocalityId: ").Append(LocalityId).Append("\n");
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
