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
 * > **Note:** You must have an active Avalara 1099 & W-9 subscription to authenticate and use these APIs. If you don't have a subscription, please contact our [Sales team](https://www.avalara.com/us/en/products/1099/request-a-demo.html).  ## Authentication  The Avalara 1099 & W-9 API uses **Bearer Token Authentication**. To authenticate, acquire a bearer token using a **Client ID** and **Client Secret** that you generate in the Avalara 1099 & W-9 web application.  The sample cURL commands below use **production** URLs. For **sandbox**, replace them with the sandbox URLs listed in the Sandbox Environment table.  ### Option 1 — Client ID and Client Secret (recommended)  **Step 1: Create API credentials in the Avalara 1099 & W-9 web app**  For a full walkthrough, see the [Avalara 1099 & W-9 integration guide](https://developer.avalara.com/products/avalara-1099-and-w9/integration-guides/1099-and-w-9/siu2796410674799/).  > **Note:** To enable credential creation you must first enter a valid company address in **Account Settings > Account** and enable two-factor authentication in **Account Settings > Security**.  1. In Avalara 1099 & W-9, open **Account Settings** (gear icon, top-right of any page) and select **API**. 2. Click **Create new credentials** (a valid company address and 2FA are required). 3. Copy your **Client Id** and **Client Secret** securely — they will not be shown again after you leave the screen.  **Step 2: Request a bearer token**  ```bash curl -X POST 'https://identity.avalara.com/connect/token' \\   - -header 'Content-Type: application/x-www-form-urlencoded' \\   - -data-urlencode 'grant_type=client_credentials' \\   - -data-urlencode 'client_id={{client_id}}' \\   - -data-urlencode 'client_secret={{client_secret}}' ```  ### Option 2 — Account ID and License Key  If your organization already uses other Avalara products (AvaTax, CertCapture) and has access to the logged-in area of Avalara.com, you can generate the bearer token using your **Account ID** and **License Key**.  > **Note:** If you already have a license key for other Avalara products you can reuse it. Generating a new key will reset any previously created key.  1. Log in to Avalara.com. 2. Go to **Settings → License and API Keys**. 3. Click **Generate New Key**. 4. Note your **Account ID** from the Account menu.  ```bash curl -X POST 'https://identity.avalara.com/connect/token' \\   - -header 'Content-Type: application/x-www-form-urlencoded' \\   - -data-urlencode 'grant_type=client_credentials' \\   - -data-urlencode 'client_id={{accountId}}' \\   - -data-urlencode 'client_secret={{licenseKey}}' ```  ### Using and renewing the bearer token  Include the token in the `Authorization` header on every request:  ```http Authorization: Bearer {access_token} ```  Tokens expire after the number of seconds in the `expires_in` field of the token response. Your integration must renew the token before it expires.  **Example token response**  ```json {   \"access_token\": \"eyJhbGciOiJIUzI1NiIsInR5cCI...\",   \"expires_in\": 3600,   \"token_type\": \"Bearer\",   \"scope\": \"avatax_api iam-ds\" } ```  ### Sandbox Environment  Use the same steps as production, replacing the base URLs:  | Purpose | Production | Sandbox | | - -- | - -- | - -- | | Account & License Key management (web) | `https://www.avalara.com` | `https://sandbox.admin.avalara.com` | | Account & License Key management (API) | `https://rest.avatax.com` | `https://sandbox-rest.avatax.com` | | Token generation | `https://identity.avalara.com` | `https://ai-sbx.avlr.sh` |  ## Environments  #### Production - **Avalara 1099 API URL:** [`https://api.avalara.com/avalara1099`](https://api.avalara.com/avalara1099) - **Identity Token URL:** [`https://identity.avalara.com/connect/token`](https://identity.avalara.com/connect/token)  #### Sandbox - **Avalara 1099 API URL:** [`https://api.sbx.avalara.com/avalara1099`](https://api.sbx.avalara.com/avalara1099) - **Identity Token URL:** [`https://ai-sbx.avlr.sh/connect/token`](https://ai-sbx.avlr.sh/connect/token)  - --  ## API & SDK Documentation  [Avalara 1099 API Reference](https://developer.avalara.com/api-reference/avalara1099/avalara1099/)  [Avalara SDKs](https://developer.avalara.com/sdk/)  [Swagger](https://api.avalara.com/avalara1099/swagger/index.html?api-version=2.0)
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
    /// IssuerWriteResponse
    /// </summary>
    [DataContract(Name = "IssuerWriteResponse")]
    public partial class IssuerWriteResponse : IValidatableObject
    {
        /// <summary>
        /// Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TinTypeEnum
        {
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,

            /// <summary>
            /// Enum INDIVIDUAL for value: INDIVIDUAL
            /// </summary>
            [EnumMember(Value = "INDIVIDUAL")]
            INDIVIDUAL,

            /// <summary>
            /// Enum BUSINESS for value: BUSINESS
            /// </summary>
            [EnumMember(Value = "BUSINESS")]
            BUSINESS
        }


        /// <summary>
        /// Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number</value>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerWriteResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssuerWriteResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerWriteResponse" /> class.
        /// </summary>
        /// <param name="businessName">Business name. Required when the recipient of the form is a business; should only be used for businesses. (required).</param>
        /// <param name="businessName2">Business name line 2. Should only be used for businesses. Use either this or &#39;transferAgentName&#39;..</param>
        /// <param name="name">Legal name. Not the DBA name. Deprecated alias for &#39;businessName&#39;..</param>
        /// <param name="dbaName">Doing Business As (DBA) name or continuation of a long legal name. Deprecated alias for &#39;businessName2&#39;. Use either this or &#39;transferAgentName&#39;..</param>
        /// <param name="tinType">Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number.</param>
        /// <param name="firstName">First name. Required when the recipient of the form is an individual; should only be used for individuals..</param>
        /// <param name="middleName">Middle name. Should only be used for individuals..</param>
        /// <param name="lastName">Last name. Required when the recipient of the form is an individual; should only be used for individuals..</param>
        /// <param name="suffix">Suffix name. Should only be used for individuals..</param>
        /// <param name="tin">Federal Tax Identification Number (TIN)..</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces..</param>
        /// <param name="telephone">Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries. (required).</param>
        /// <param name="taxYear">Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4. It&#39;s only required on creation, and cannot be modified on update. (required).</param>
        /// <param name="countryCode">Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address. (required).</param>
        /// <param name="email">Contact email address. For recipient inquiries. Phone will be used on communications if you don&#39;t specify an email.</param>
        /// <param name="address">Address. (required).</param>
        /// <param name="city">City. (required).</param>
        /// <param name="state">Two-letter US state or Canadian province code (required for US/CA addresses). (required).</param>
        /// <param name="zip">ZIP/postal code. (required).</param>
        /// <param name="foreignProvince">Province or region for non-US/CA addresses..</param>
        /// <param name="transferAgentName">Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;..</param>
        /// <param name="lastFiling">Indicates if this is the issuer&#39;s final year filing. (required).</param>
        /// <param name="id">Unique identifier set when the record is created..</param>
        /// <param name="createdAt">Date time when the record was created..</param>
        /// <param name="updatedAt">Date time when the record was last updated..</param>
        public IssuerWriteResponse(string businessName = default(string), string businessName2 = default(string), string name = default(string), string dbaName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string firstName = default(string), string middleName = default(string), string lastName = default(string), string suffix = default(string), string tin = default(string), string referenceId = default(string), string telephone = default(string), int? taxYear = default(int?), string countryCode = default(string), string email = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string transferAgentName = default(string), bool? lastFiling = default(bool?), string id = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "businessName" is required (not null)
            if (businessName == null)
            {
                throw new ArgumentNullException("businessName is a required property for IssuerWriteResponse and cannot be null");
            }
            this.BusinessName = businessName;
            // to ensure "telephone" is required (not null)
            if (telephone == null)
            {
                throw new ArgumentNullException("telephone is a required property for IssuerWriteResponse and cannot be null");
            }
            this.Telephone = telephone;
            // to ensure "taxYear" is required (not null)
            if (taxYear == null)
            {
                throw new ArgumentNullException("taxYear is a required property for IssuerWriteResponse and cannot be null");
            }
            this.TaxYear = taxYear;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for IssuerWriteResponse and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for IssuerWriteResponse and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for IssuerWriteResponse and cannot be null");
            }
            this.City = city;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for IssuerWriteResponse and cannot be null");
            }
            this.State = state;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for IssuerWriteResponse and cannot be null");
            }
            this.Zip = zip;
            // to ensure "lastFiling" is required (not null)
            if (lastFiling == null)
            {
                throw new ArgumentNullException("lastFiling is a required property for IssuerWriteResponse and cannot be null");
            }
            this.LastFiling = lastFiling;
            this.BusinessName2 = businessName2;
            this.Name = name;
            this.DbaName = dbaName;
            this.TinType = tinType;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Suffix = suffix;
            this.Tin = tin;
            this.ReferenceId = referenceId;
            this.Email = email;
            this.ForeignProvince = foreignProvince;
            this.TransferAgentName = transferAgentName;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Business name. Required when the recipient of the form is a business; should only be used for businesses.
        /// </summary>
        /// <value>Business name. Required when the recipient of the form is a business; should only be used for businesses.</value>
        [DataMember(Name = "businessName", IsRequired = true, EmitDefaultValue = true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Business name line 2. Should only be used for businesses. Use either this or &#39;transferAgentName&#39;.
        /// </summary>
        /// <value>Business name line 2. Should only be used for businesses. Use either this or &#39;transferAgentName&#39;.</value>
        [DataMember(Name = "businessName2", EmitDefaultValue = true)]
        public string BusinessName2 { get; set; }

        /// <summary>
        /// Legal name. Not the DBA name. Deprecated alias for &#39;businessName&#39;.
        /// </summary>
        /// <value>Legal name. Not the DBA name. Deprecated alias for &#39;businessName&#39;.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        [Obsolete]
        public string Name { get; set; }

        /// <summary>
        /// Doing Business As (DBA) name or continuation of a long legal name. Deprecated alias for &#39;businessName2&#39;. Use either this or &#39;transferAgentName&#39;.
        /// </summary>
        /// <value>Doing Business As (DBA) name or continuation of a long legal name. Deprecated alias for &#39;businessName2&#39;. Use either this or &#39;transferAgentName&#39;.</value>
        [DataMember(Name = "dbaName", EmitDefaultValue = true)]
        [Obsolete]
        public string DbaName { get; set; }

        /// <summary>
        /// First name. Required when the recipient of the form is an individual; should only be used for individuals.
        /// </summary>
        /// <value>First name. Required when the recipient of the form is an individual; should only be used for individuals.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name. Should only be used for individuals.
        /// </summary>
        /// <value>Middle name. Should only be used for individuals.</value>
        [DataMember(Name = "middleName", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Last name. Required when the recipient of the form is an individual; should only be used for individuals.
        /// </summary>
        /// <value>Last name. Required when the recipient of the form is an individual; should only be used for individuals.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Suffix name. Should only be used for individuals.
        /// </summary>
        /// <value>Suffix name. Should only be used for individuals.</value>
        [DataMember(Name = "suffix", EmitDefaultValue = true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Federal Tax Identification Number (TIN).
        /// </summary>
        /// <value>Federal Tax Identification Number (TIN).</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces.
        /// </summary>
        /// <value>Internal reference ID. Never shown to any agency or recipient. If present, it will prefix download filenames. Allowed characters: letters, numbers, dashes, underscores, and spaces.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries.
        /// </summary>
        /// <value>Contact phone number (must contain at least 10 digits, max 15 characters). For recipient inquiries.</value>
        [DataMember(Name = "telephone", IsRequired = true, EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4. It&#39;s only required on creation, and cannot be modified on update.
        /// </summary>
        /// <value>Tax year for which the forms are being filed (e.g., 2024). Must be within current tax year and current tax year - 4. It&#39;s only required on creation, and cannot be modified on update.</value>
        [DataMember(Name = "taxYear", IsRequired = true, EmitDefaultValue = true)]
        public int? TaxYear { get; set; }

        /// <summary>
        /// Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address.
        /// </summary>
        /// <value>Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. If there is a transfer agent, use the transfer agent&#39;s shipping address.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Contact email address. For recipient inquiries. Phone will be used on communications if you don&#39;t specify an email
        /// </summary>
        /// <value>Contact email address. For recipient inquiries. Phone will be used on communications if you don&#39;t specify an email</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        /// <value>Address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Two-letter US state or Canadian province code (required for US/CA addresses).
        /// </summary>
        /// <value>Two-letter US state or Canadian province code (required for US/CA addresses).</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// ZIP/postal code.
        /// </summary>
        /// <value>ZIP/postal code.</value>
        [DataMember(Name = "zip", IsRequired = true, EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Province or region for non-US/CA addresses.
        /// </summary>
        /// <value>Province or region for non-US/CA addresses.</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;.
        /// </summary>
        /// <value>Name of the transfer agent, if applicable — optional; use either this or &#39;dbaName&#39;.</value>
        [DataMember(Name = "transferAgentName", EmitDefaultValue = true)]
        public string TransferAgentName { get; set; }

        /// <summary>
        /// Indicates if this is the issuer&#39;s final year filing.
        /// </summary>
        /// <value>Indicates if this is the issuer&#39;s final year filing.</value>
        [DataMember(Name = "lastFiling", IsRequired = true, EmitDefaultValue = true)]
        public bool? LastFiling { get; set; }

        /// <summary>
        /// Unique identifier set when the record is created.
        /// </summary>
        /// <value>Unique identifier set when the record is created.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Date time when the record was created.
        /// </summary>
        /// <value>Date time when the record was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date time when the record was last updated.
        /// </summary>
        /// <value>Date time when the record was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Field-level validation errors. Populated when a POST or PUT request violated business rules  but the issuer was still persisted. Each entry identifies the affected field and the issue.  Empty array when the payload was fully valid.
        /// </summary>
        /// <value>Field-level validation errors. Populated when a POST or PUT request violated business rules  but the issuer was still persisted. Each entry identifies the affected field and the issue.  Empty array when the payload was fully valid.</value>
        [DataMember(Name = "validationErrors", EmitDefaultValue = true)]
        public List<ValidationError> ValidationErrors { get; private set; }

        /// <summary>
        /// Returns false as ValidationErrors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationErrors()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuerWriteResponse {\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessName2: ").Append(BusinessName2).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DbaName: ").Append(DbaName).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  TransferAgentName: ").Append(TransferAgentName).Append("\n");
            sb.Append("  LastFiling: ").Append(LastFiling).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
