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
    /// W4FormMinimalRequest
    /// </summary>
    [DataContract(Name = "W4FormMinimalRequest")]
    public partial class W4FormMinimalRequest : IValidatableObject
    {
        /// <summary>
        /// The form type (always \&quot;w4\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w4\&quot; for this model).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum W4 for value: W4
            /// </summary>
            [EnumMember(Value = "W4")]
            W4 = 1,

            /// <summary>
            /// Enum W8Ben for value: W8Ben
            /// </summary>
            [EnumMember(Value = "W8Ben")]
            W8Ben = 2,

            /// <summary>
            /// Enum W8BenE for value: W8BenE
            /// </summary>
            [EnumMember(Value = "W8BenE")]
            W8BenE = 3,

            /// <summary>
            /// Enum W8Imy for value: W8Imy
            /// </summary>
            [EnumMember(Value = "W8Imy")]
            W8Imy = 4,

            /// <summary>
            /// Enum W9 for value: W9
            /// </summary>
            [EnumMember(Value = "W9")]
            W9 = 5
        }


        /// <summary>
        /// The form type (always \&quot;w4\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w4\&quot; for this model).</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="W4FormMinimalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected W4FormMinimalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="W4FormMinimalRequest" /> class.
        /// </summary>
        /// <param name="email">The email address of the individual associated with the form. (required).</param>
        /// <param name="employeeFirstName">The first name of the employee. (required).</param>
        /// <param name="employeeLastName">The last name of the employee. (required).</param>
        /// <param name="officeCode">The office code associated with the form..</param>
        /// <param name="companyId">The ID of the associated company. Required when creating a form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        public W4FormMinimalRequest(string email = default(string), string employeeFirstName = default(string), string employeeLastName = default(string), string officeCode = default(string), string companyId = default(string), string referenceId = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for W4FormMinimalRequest and cannot be null");
            }
            this.Email = email;
            // to ensure "employeeFirstName" is required (not null)
            if (employeeFirstName == null)
            {
                throw new ArgumentNullException("employeeFirstName is a required property for W4FormMinimalRequest and cannot be null");
            }
            this.EmployeeFirstName = employeeFirstName;
            // to ensure "employeeLastName" is required (not null)
            if (employeeLastName == null)
            {
                throw new ArgumentNullException("employeeLastName is a required property for W4FormMinimalRequest and cannot be null");
            }
            this.EmployeeLastName = employeeLastName;
            this.OfficeCode = officeCode;
            this.CompanyId = companyId;
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        /// <value>The first name of the employee.</value>
        [DataMember(Name = "employeeFirstName", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeFirstName { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        /// <value>The last name of the employee.</value>
        [DataMember(Name = "employeeLastName", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// The office code associated with the form.
        /// </summary>
        /// <value>The office code associated with the form.</value>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// The ID of the associated company. Required when creating a form.
        /// </summary>
        /// <value>The ID of the associated company. Required when creating a form.</value>
        [DataMember(Name = "companyId", EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// A reference identifier for the form.
        /// </summary>
        /// <value>A reference identifier for the form.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W4FormMinimalRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Email, length must be greater than 1.", new [] { "Email" });
            }

            // EmployeeFirstName (string) minLength
            if (this.EmployeeFirstName != null && this.EmployeeFirstName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for EmployeeFirstName, length must be greater than 1.", new [] { "EmployeeFirstName" });
            }

            // EmployeeLastName (string) minLength
            if (this.EmployeeLastName != null && this.EmployeeLastName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for EmployeeLastName, length must be greater than 1.", new [] { "EmployeeLastName" });
            }

            yield break;
        }
    }
}
