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
    /// Form 1099-B: Proceeds From Broker and Barter Exchange Transactions                The recipient is the customer and the issuer is the broker or barter exchange. Each form reports one sale.                *Required:* &#x60;applicableCheckboxOnForm8949&#x60;, &#x60;descriptionOfProperty&#x60;, &#x60;proceeds&#x60; (which can be zero or negative) and  &#x60;proceedsReportedToIrs&#x60;. &#x60;typeOfGainOrLoss&#x60; is required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                &#x60;dateSoldOrDisposed&#x60; must fall in the tax year. &#x60;dateAcquired&#x60; can&#39;t be after the tax year or before January 1 of the  year 50 years before the current filing year, whatever the form&#39;s tax year. &#x60;costOrOtherBasis&#x60;,  &#x60;washSaleLossDisallowed&#x60; and &#x60;federalIncomeTaxWithheld&#x60; can&#39;t be negative; the other amounts can.  &#x60;federalIncomeTaxWithheld&#x60; must be less than &#x60;proceeds&#x60; (zero when &#x60;proceeds&#x60; is zero or negative), and can&#39;t be more  than 24% of the other amounts on the form combined, not counting state and local withholding.                &#x60;stateAndLocalWithholding&#x60; carries &#x60;state&#x60;, &#x60;stateId&#x60;, &#x60;stateTaxWithheld&#x60;, &#x60;locality&#x60;, &#x60;localityId&#x60; and  &#x60;localTaxWithheld&#x60;. &#x60;state&#x60; and &#x60;stateId&#x60; are required when &#x60;stateTaxWithheld&#x60; has an amount. Form 1099-B has no state  or local income fields, so &#x60;stateIncome&#x60; and &#x60;localIncome&#x60; are discarded and read back as &#x60;null&#x60;.
    /// </summary>
    [DataContract(Name = "Form1099B")]
    public partial class Form1099B : IValidatableObject
    {
        /// <summary>
        /// Applicable checkbox on Form 8949.                * &#x60;A&#x60; - Short-term transaction, basis reported to the IRS  * &#x60;B&#x60; - Short-term transaction, basis not reported to the IRS  * &#x60;D&#x60; - Long-term transaction, basis reported to the IRS  * &#x60;E&#x60; - Long-term transaction, basis not reported to the IRS  * &#x60;X&#x60; - Basis not reported to the IRS and the holding period is unknown
        /// </summary>
        /// <value>Applicable checkbox on Form 8949.                * &#x60;A&#x60; - Short-term transaction, basis reported to the IRS  * &#x60;B&#x60; - Short-term transaction, basis not reported to the IRS  * &#x60;D&#x60; - Long-term transaction, basis reported to the IRS  * &#x60;E&#x60; - Long-term transaction, basis not reported to the IRS  * &#x60;X&#x60; - Basis not reported to the IRS and the holding period is unknown</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicableCheckboxOnForm8949Enum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum B for value: B
            /// </summary>
            [EnumMember(Value = "B")]
            B = 2,

            /// <summary>
            /// Enum D for value: D
            /// </summary>
            [EnumMember(Value = "D")]
            D = 3,

            /// <summary>
            /// Enum E for value: E
            /// </summary>
            [EnumMember(Value = "E")]
            E = 4,

            /// <summary>
            /// Enum X for value: X
            /// </summary>
            [EnumMember(Value = "X")]
            X = 5
        }


        /// <summary>
        /// Applicable checkbox on Form 8949.                * &#x60;A&#x60; - Short-term transaction, basis reported to the IRS  * &#x60;B&#x60; - Short-term transaction, basis not reported to the IRS  * &#x60;D&#x60; - Long-term transaction, basis reported to the IRS  * &#x60;E&#x60; - Long-term transaction, basis not reported to the IRS  * &#x60;X&#x60; - Basis not reported to the IRS and the holding period is unknown
        /// </summary>
        /// <value>Applicable checkbox on Form 8949.                * &#x60;A&#x60; - Short-term transaction, basis reported to the IRS  * &#x60;B&#x60; - Short-term transaction, basis not reported to the IRS  * &#x60;D&#x60; - Long-term transaction, basis reported to the IRS  * &#x60;E&#x60; - Long-term transaction, basis not reported to the IRS  * &#x60;X&#x60; - Basis not reported to the IRS and the holding period is unknown</value>
        [DataMember(Name = "applicableCheckboxOnForm8949", IsRequired = true, EmitDefaultValue = true)]
        public ApplicableCheckboxOnForm8949Enum ApplicableCheckboxOnForm8949 { get; set; }
        /// <summary>
        /// Type of gain or loss. Required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                * &#x60;SHORT_TERM&#x60; - Short-term gain or loss  * &#x60;LONG_TERM&#x60; - Long-term gain or loss  * &#x60;ORDINARY_SHORT_TERM&#x60; - Ordinary, short-term  * &#x60;ORDINARY_LONG_TERM&#x60; - Ordinary, long-term
        /// </summary>
        /// <value>Type of gain or loss. Required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                * &#x60;SHORT_TERM&#x60; - Short-term gain or loss  * &#x60;LONG_TERM&#x60; - Long-term gain or loss  * &#x60;ORDINARY_SHORT_TERM&#x60; - Ordinary, short-term  * &#x60;ORDINARY_LONG_TERM&#x60; - Ordinary, long-term</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeOfGainOrLossEnum
        {
            /// <summary>
            /// Enum SHORTTERM for value: SHORT_TERM
            /// </summary>
            [EnumMember(Value = "SHORT_TERM")]
            SHORTTERM = 1,

            /// <summary>
            /// Enum LONGTERM for value: LONG_TERM
            /// </summary>
            [EnumMember(Value = "LONG_TERM")]
            LONGTERM = 2,

            /// <summary>
            /// Enum ORDINARYSHORTTERM for value: ORDINARY_SHORT_TERM
            /// </summary>
            [EnumMember(Value = "ORDINARY_SHORT_TERM")]
            ORDINARYSHORTTERM = 3,

            /// <summary>
            /// Enum ORDINARYLONGTERM for value: ORDINARY_LONG_TERM
            /// </summary>
            [EnumMember(Value = "ORDINARY_LONG_TERM")]
            ORDINARYLONGTERM = 4
        }


        /// <summary>
        /// Type of gain or loss. Required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                * &#x60;SHORT_TERM&#x60; - Short-term gain or loss  * &#x60;LONG_TERM&#x60; - Long-term gain or loss  * &#x60;ORDINARY_SHORT_TERM&#x60; - Ordinary, short-term  * &#x60;ORDINARY_LONG_TERM&#x60; - Ordinary, long-term
        /// </summary>
        /// <value>Type of gain or loss. Required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                * &#x60;SHORT_TERM&#x60; - Short-term gain or loss  * &#x60;LONG_TERM&#x60; - Long-term gain or loss  * &#x60;ORDINARY_SHORT_TERM&#x60; - Ordinary, short-term  * &#x60;ORDINARY_LONG_TERM&#x60; - Ordinary, long-term</value>
        [DataMember(Name = "typeOfGainOrLoss", EmitDefaultValue = true)]
        public TypeOfGainOrLossEnum? TypeOfGainOrLoss { get; set; }
        /// <summary>
        /// Source of the proceeds, if they are from collectibles or a Qualified Opportunity Fund.                * &#x60;COLLECTIBLES&#x60; - Collectibles  * &#x60;QOF&#x60; - Qualified Opportunity Fund (QOF)
        /// </summary>
        /// <value>Source of the proceeds, if they are from collectibles or a Qualified Opportunity Fund.                * &#x60;COLLECTIBLES&#x60; - Collectibles  * &#x60;QOF&#x60; - Qualified Opportunity Fund (QOF)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProceedsFromEnum
        {
            /// <summary>
            /// Enum COLLECTIBLES for value: COLLECTIBLES
            /// </summary>
            [EnumMember(Value = "COLLECTIBLES")]
            COLLECTIBLES = 1,

            /// <summary>
            /// Enum QOF for value: QOF
            /// </summary>
            [EnumMember(Value = "QOF")]
            QOF = 2
        }


        /// <summary>
        /// Source of the proceeds, if they are from collectibles or a Qualified Opportunity Fund.                * &#x60;COLLECTIBLES&#x60; - Collectibles  * &#x60;QOF&#x60; - Qualified Opportunity Fund (QOF)
        /// </summary>
        /// <value>Source of the proceeds, if they are from collectibles or a Qualified Opportunity Fund.                * &#x60;COLLECTIBLES&#x60; - Collectibles  * &#x60;QOF&#x60; - Qualified Opportunity Fund (QOF)</value>
        [DataMember(Name = "proceedsFrom", EmitDefaultValue = true)]
        public ProceedsFromEnum? ProceedsFrom { get; set; }
        /// <summary>
        /// Whether gross or net proceeds are reported to the IRS.                * &#x60;GROSS&#x60; - Gross proceeds  * &#x60;NET&#x60; - Net proceeds
        /// </summary>
        /// <value>Whether gross or net proceeds are reported to the IRS.                * &#x60;GROSS&#x60; - Gross proceeds  * &#x60;NET&#x60; - Net proceeds</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProceedsReportedToIrsEnum
        {
            /// <summary>
            /// Enum GROSS for value: GROSS
            /// </summary>
            [EnumMember(Value = "GROSS")]
            GROSS = 1,

            /// <summary>
            /// Enum NET for value: NET
            /// </summary>
            [EnumMember(Value = "NET")]
            NET = 2
        }


        /// <summary>
        /// Whether gross or net proceeds are reported to the IRS.                * &#x60;GROSS&#x60; - Gross proceeds  * &#x60;NET&#x60; - Net proceeds
        /// </summary>
        /// <value>Whether gross or net proceeds are reported to the IRS.                * &#x60;GROSS&#x60; - Gross proceeds  * &#x60;NET&#x60; - Net proceeds</value>
        [DataMember(Name = "proceedsReportedToIrs", IsRequired = true, EmitDefaultValue = true)]
        public ProceedsReportedToIrsEnum ProceedsReportedToIrs { get; set; }
        /// <summary>
        /// Form type.
        /// </summary>
        /// <value>Form type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum _1042S for value: 1042-S
            /// </summary>
            [EnumMember(Value = "1042-S")]
            _1042S = 1,

            /// <summary>
            /// Enum _1095B for value: 1095-B
            /// </summary>
            [EnumMember(Value = "1095-B")]
            _1095B = 2,

            /// <summary>
            /// Enum _1095C for value: 1095-C
            /// </summary>
            [EnumMember(Value = "1095-C")]
            _1095C = 3,

            /// <summary>
            /// Enum _1098 for value: 1098
            /// </summary>
            [EnumMember(Value = "1098")]
            _1098 = 4,

            /// <summary>
            /// Enum _1098E for value: 1098-E
            /// </summary>
            [EnumMember(Value = "1098-E")]
            _1098E = 5,

            /// <summary>
            /// Enum _1098T for value: 1098-T
            /// </summary>
            [EnumMember(Value = "1098-T")]
            _1098T = 6,

            /// <summary>
            /// Enum _1099B for value: 1099-B
            /// </summary>
            [EnumMember(Value = "1099-B")]
            _1099B = 7,

            /// <summary>
            /// Enum _1099C for value: 1099-C
            /// </summary>
            [EnumMember(Value = "1099-C")]
            _1099C = 8,

            /// <summary>
            /// Enum _1099DIV for value: 1099-DIV
            /// </summary>
            [EnumMember(Value = "1099-DIV")]
            _1099DIV = 9,

            /// <summary>
            /// Enum _1099G for value: 1099-G
            /// </summary>
            [EnumMember(Value = "1099-G")]
            _1099G = 10,

            /// <summary>
            /// Enum _1099INT for value: 1099-INT
            /// </summary>
            [EnumMember(Value = "1099-INT")]
            _1099INT = 11,

            /// <summary>
            /// Enum _1099K for value: 1099-K
            /// </summary>
            [EnumMember(Value = "1099-K")]
            _1099K = 12,

            /// <summary>
            /// Enum _1099MISC for value: 1099-MISC
            /// </summary>
            [EnumMember(Value = "1099-MISC")]
            _1099MISC = 13,

            /// <summary>
            /// Enum _1099NEC for value: 1099-NEC
            /// </summary>
            [EnumMember(Value = "1099-NEC")]
            _1099NEC = 14,

            /// <summary>
            /// Enum _1099PATR for value: 1099-PATR
            /// </summary>
            [EnumMember(Value = "1099-PATR")]
            _1099PATR = 15,

            /// <summary>
            /// Enum _1099R for value: 1099-R
            /// </summary>
            [EnumMember(Value = "1099-R")]
            _1099R = 16,

            /// <summary>
            /// Enum _1099S for value: 1099-S
            /// </summary>
            [EnumMember(Value = "1099-S")]
            _1099S = 17,

            /// <summary>
            /// Enum _1099SA for value: 1099-SA
            /// </summary>
            [EnumMember(Value = "1099-SA")]
            _1099SA = 18,

            /// <summary>
            /// Enum _5498 for value: 5498
            /// </summary>
            [EnumMember(Value = "5498")]
            _5498 = 19,

            /// <summary>
            /// Enum W2 for value: W-2
            /// </summary>
            [EnumMember(Value = "W-2")]
            W2 = 20,

            /// <summary>
            /// Enum W2G for value: W-2G
            /// </summary>
            [EnumMember(Value = "W-2G")]
            W2G = 21
        }


        /// <summary>
        /// Form type.
        /// </summary>
        /// <value>Form type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TinTypeEnum
        {
            /// <summary>
            /// Enum EIN for value: EIN
            /// </summary>
            [EnumMember(Value = "EIN")]
            EIN = 1,

            /// <summary>
            /// Enum SSN for value: SSN
            /// </summary>
            [EnumMember(Value = "SSN")]
            SSN = 2,

            /// <summary>
            /// Enum ITIN for value: ITIN
            /// </summary>
            [EnumMember(Value = "ITIN")]
            ITIN = 3,

            /// <summary>
            /// Enum ATIN for value: ATIN
            /// </summary>
            [EnumMember(Value = "ATIN")]
            ATIN = 4,

            /// <summary>
            /// Enum INDIVIDUAL for value: INDIVIDUAL
            /// </summary>
            [EnumMember(Value = "INDIVIDUAL")]
            INDIVIDUAL = 5,

            /// <summary>
            /// Enum BUSINESS for value: BUSINESS
            /// </summary>
            [EnumMember(Value = "BUSINESS")]
            BUSINESS = 6,

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 7
        }


        /// <summary>
        /// Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number</value>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099B" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099B()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099B" /> class.
        /// </summary>
        /// <param name="applicableCheckboxOnForm8949">Applicable checkbox on Form 8949.                * &#x60;A&#x60; - Short-term transaction, basis reported to the IRS  * &#x60;B&#x60; - Short-term transaction, basis not reported to the IRS  * &#x60;D&#x60; - Long-term transaction, basis reported to the IRS  * &#x60;E&#x60; - Long-term transaction, basis not reported to the IRS  * &#x60;X&#x60; - Basis not reported to the IRS and the holding period is unknown (required).</param>
        /// <param name="cusipNumber">CUSIP number (up to 13 letters or digits).</param>
        /// <param name="descriptionOfProperty">Description of property, such as the number of shares and the name of the stock (required).</param>
        /// <param name="dateAcquired">Date acquired. Can&#39;t be after the tax year or before January 1 of the year 50 years before the current  filing year (for example, 1975-01-01 when filing for 2025), whatever the form&#39;s tax year..</param>
        /// <param name="dateSoldOrDisposed">Date sold or disposed. Must fall in the tax year..</param>
        /// <param name="proceeds">Proceeds. Can be zero, or negative for a loss. (required).</param>
        /// <param name="costOrOtherBasis">Cost or other basis.</param>
        /// <param name="accruedMarketDiscount">Accrued market discount.</param>
        /// <param name="washSaleLossDisallowed">Wash sale loss disallowed.</param>
        /// <param name="typeOfGainOrLoss">Type of gain or loss. Required unless &#x60;noncoveredSecurity&#x60; is &#x60;true&#x60;.                * &#x60;SHORT_TERM&#x60; - Short-term gain or loss  * &#x60;LONG_TERM&#x60; - Long-term gain or loss  * &#x60;ORDINARY_SHORT_TERM&#x60; - Ordinary, short-term  * &#x60;ORDINARY_LONG_TERM&#x60; - Ordinary, long-term.</param>
        /// <param name="proceedsFrom">Source of the proceeds, if they are from collectibles or a Qualified Opportunity Fund.                * &#x60;COLLECTIBLES&#x60; - Collectibles  * &#x60;QOF&#x60; - Qualified Opportunity Fund (QOF).</param>
        /// <param name="federalIncomeTaxWithheld">Federal income tax withheld. Must be less than &#x60;proceeds&#x60; (zero when &#x60;proceeds&#x60; is zero or negative), and can&#39;t be  more than 24% of the other amounts on the form combined, not counting state and local withholding..</param>
        /// <param name="noncoveredSecurity">If checked, the security is noncovered.</param>
        /// <param name="proceedsReportedToIrs">Whether gross or net proceeds are reported to the IRS.                * &#x60;GROSS&#x60; - Gross proceeds  * &#x60;NET&#x60; - Net proceeds (required).</param>
        /// <param name="lossNotAllowed">If checked, the loss is not allowed based on the amount in &#x60;proceeds&#x60;.</param>
        /// <param name="profitOrLossRealizedOnClosedContracts">Profit or (loss) realized in the tax year on closed contracts.</param>
        /// <param name="unrealizedProfitOrLossOnOpenContractsPriorYear">Unrealized profit or (loss) on open contracts at the end of the prior tax year.</param>
        /// <param name="unrealizedProfitOrLossOnOpenContractsCurrentYear">Unrealized profit or (loss) on open contracts at the end of the tax year.</param>
        /// <param name="aggregateProfitOrLossOnContracts">Aggregate profit or (loss) on contracts.</param>
        /// <param name="basisReportedToIrs">If checked, the basis is reported to the IRS. Only takes effect when &#x60;noncoveredSecurity&#x60; is also checked:  otherwise it isn&#39;t sent to the IRS, and changing it doesn&#39;t trigger a correction..</param>
        /// <param name="bartering">Bartering.</param>
        /// <param name="fatcaFilingRequirement">FATCA filing requirement.</param>
        /// <param name="type">Form type. (required).</param>
        /// <param name="issuerId">Issuer ID - only required when creating forms.</param>
        /// <param name="issuerReferenceId">Issuer Reference ID - only required when creating forms via $bulk-upsert.</param>
        /// <param name="issuerTin">Issuer TIN - readonly.</param>
        /// <param name="taxYear">Tax Year - only required when creating forms via $bulk-upsert.</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient..</param>
        /// <param name="tin">Recipient&#39;s Federal Tax Identification Number (TIN)..</param>
        /// <param name="recipientName">DEPRECATED: Use &#x60;businessName&#x60; for businesses; use &#x60;firstName&#x60;, &#x60;middleName&#x60;, &#x60;lastName&#x60;, and &#x60;suffixName&#x60; for individuals..</param>
        /// <param name="address">Address. (required).</param>
        /// <param name="address2">Address line 2..</param>
        /// <param name="city">City. (required).</param>
        /// <param name="state">Two-letter US state or Canadian province code (required for US/CA addresses)..</param>
        /// <param name="zip">ZIP/postal code..</param>
        /// <param name="email">Recipient&#39;s Contact email address..</param>
        /// <param name="nonUsProvince">Province or region for non-US/CA addresses..</param>
        /// <param name="countryCode">Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. (required).</param>
        /// <param name="federalEfileDate">Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEfileDate">Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="recipientEdeliveryDate">Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        /// <param name="tinType">Recipient classification.  The platform is transitioning from tax identifier classifications to recipient entity classifications. New values represent recipient entity types and should be preferred. Deprecated values represent identifier formats and remain supported for backward compatibility only.  Available values: - INDIVIDUAL: Recipient is an individual - BUSINESS: Recipient is a business - UNKNOWN: Recipient classification is unknown - EIN: (Deprecated - use BUSINESS) Employer Identification Number - SSN: (Deprecated - use INDIVIDUAL) Social Security Number - ITIN: (Deprecated - use INDIVIDUAL) Individual Taxpayer Identification Number - ATIN: (Deprecated - use INDIVIDUAL) Adoption Taxpayer Identification Number.</param>
        /// <param name="businessName">Business name. Required when the recipient of the form is a business; should only be used for businesses..</param>
        /// <param name="businessName2">Business name line 2. Should only be used for businesses..</param>
        /// <param name="firstName">First name. Required when the recipient of the form is an individual; should only be used for individuals..</param>
        /// <param name="middleName">Middle name. Should only be used for individuals..</param>
        /// <param name="lastName">Last name. Required when the recipient of the form is an individual; should only be used for individuals..</param>
        /// <param name="suffixName">Suffix name. Should only be used for individuals..</param>
        /// <param name="recipientSecondName">DEPRECATED: Use &#x60;businessName2&#x60; instead..</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="officeCode">Office code.</param>
        /// <param name="noTin">No TIN indicator.</param>
        /// <param name="secondTinNotice">Second TIN notice.</param>
        public Form1099B(ApplicableCheckboxOnForm8949Enum applicableCheckboxOnForm8949 = default(ApplicableCheckboxOnForm8949Enum), string cusipNumber = default(string), string descriptionOfProperty = default(string), DateTime? dateAcquired = default(DateTime?), DateTime? dateSoldOrDisposed = default(DateTime?), double? proceeds = default(double?), double? costOrOtherBasis = default(double?), double? accruedMarketDiscount = default(double?), double? washSaleLossDisallowed = default(double?), TypeOfGainOrLossEnum? typeOfGainOrLoss = default(TypeOfGainOrLossEnum?), ProceedsFromEnum? proceedsFrom = default(ProceedsFromEnum?), double? federalIncomeTaxWithheld = default(double?), bool? noncoveredSecurity = default(bool?), ProceedsReportedToIrsEnum proceedsReportedToIrs = default(ProceedsReportedToIrsEnum), bool? lossNotAllowed = default(bool?), double? profitOrLossRealizedOnClosedContracts = default(double?), double? unrealizedProfitOrLossOnOpenContractsPriorYear = default(double?), double? unrealizedProfitOrLossOnOpenContractsCurrentYear = default(double?), double? aggregateProfitOrLossOnContracts = default(double?), bool? basisReportedToIrs = default(bool?), double? bartering = default(double?), bool? fatcaFilingRequirement = default(bool?), TypeEnum type = default(TypeEnum), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int? taxYear = default(int?), string referenceId = default(string), string tin = default(string), string recipientName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string nonUsProvince = default(string), string countryCode = default(string), DateTime? federalEfileDate = default(DateTime?), bool? postalMail = default(bool?), DateTime? stateEfileDate = default(DateTime?), DateTime? recipientEdeliveryDate = default(DateTime?), bool? tinMatch = default(bool?), bool? addressVerification = default(bool?), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding), TinTypeEnum? tinType = default(TinTypeEnum?), string businessName = default(string), string businessName2 = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string), string suffixName = default(string), string recipientSecondName = default(string), string accountNumber = default(string), string officeCode = default(string), bool? noTin = default(bool?), bool? secondTinNotice = default(bool?))
        {
            this.ApplicableCheckboxOnForm8949 = applicableCheckboxOnForm8949;
            // to ensure "descriptionOfProperty" is required (not null)
            if (descriptionOfProperty == null)
            {
                throw new ArgumentNullException("descriptionOfProperty is a required property for Form1099B and cannot be null");
            }
            this.DescriptionOfProperty = descriptionOfProperty;
            // to ensure "proceeds" is required (not null)
            if (proceeds == null)
            {
                throw new ArgumentNullException("proceeds is a required property for Form1099B and cannot be null");
            }
            this.Proceeds = proceeds;
            this.ProceedsReportedToIrs = proceedsReportedToIrs;
            this.Type = type;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Form1099B and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Form1099B and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1099B and cannot be null");
            }
            this.CountryCode = countryCode;
            this.CusipNumber = cusipNumber;
            this.DateAcquired = dateAcquired;
            this.DateSoldOrDisposed = dateSoldOrDisposed;
            this.CostOrOtherBasis = costOrOtherBasis;
            this.AccruedMarketDiscount = accruedMarketDiscount;
            this.WashSaleLossDisallowed = washSaleLossDisallowed;
            this.TypeOfGainOrLoss = typeOfGainOrLoss;
            this.ProceedsFrom = proceedsFrom;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.NoncoveredSecurity = noncoveredSecurity;
            this.LossNotAllowed = lossNotAllowed;
            this.ProfitOrLossRealizedOnClosedContracts = profitOrLossRealizedOnClosedContracts;
            this.UnrealizedProfitOrLossOnOpenContractsPriorYear = unrealizedProfitOrLossOnOpenContractsPriorYear;
            this.UnrealizedProfitOrLossOnOpenContractsCurrentYear = unrealizedProfitOrLossOnOpenContractsCurrentYear;
            this.AggregateProfitOrLossOnContracts = aggregateProfitOrLossOnContracts;
            this.BasisReportedToIrs = basisReportedToIrs;
            this.Bartering = bartering;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Tin = tin;
            this.RecipientName = recipientName;
            this.Address2 = address2;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.NonUsProvince = nonUsProvince;
            this.FederalEfileDate = federalEfileDate;
            this.PostalMail = postalMail;
            this.StateEfileDate = stateEfileDate;
            this.RecipientEdeliveryDate = recipientEdeliveryDate;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.TinType = tinType;
            this.BusinessName = businessName;
            this.BusinessName2 = businessName2;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SuffixName = suffixName;
            this.RecipientSecondName = recipientSecondName;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.NoTin = noTin;
            this.SecondTinNotice = secondTinNotice;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// CUSIP number (up to 13 letters or digits)
        /// </summary>
        /// <value>CUSIP number (up to 13 letters or digits)</value>
        [DataMember(Name = "cusipNumber", EmitDefaultValue = true)]
        public string CusipNumber { get; set; }

        /// <summary>
        /// Description of property, such as the number of shares and the name of the stock
        /// </summary>
        /// <value>Description of property, such as the number of shares and the name of the stock</value>
        [DataMember(Name = "descriptionOfProperty", IsRequired = true, EmitDefaultValue = true)]
        public string DescriptionOfProperty { get; set; }

        /// <summary>
        /// Date acquired. Can&#39;t be after the tax year or before January 1 of the year 50 years before the current  filing year (for example, 1975-01-01 when filing for 2025), whatever the form&#39;s tax year.
        /// </summary>
        /// <value>Date acquired. Can&#39;t be after the tax year or before January 1 of the year 50 years before the current  filing year (for example, 1975-01-01 when filing for 2025), whatever the form&#39;s tax year.</value>
        [DataMember(Name = "dateAcquired", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateAcquired { get; set; }

        /// <summary>
        /// Date sold or disposed. Must fall in the tax year.
        /// </summary>
        /// <value>Date sold or disposed. Must fall in the tax year.</value>
        [DataMember(Name = "dateSoldOrDisposed", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateSoldOrDisposed { get; set; }

        /// <summary>
        /// Proceeds. Can be zero, or negative for a loss.
        /// </summary>
        /// <value>Proceeds. Can be zero, or negative for a loss.</value>
        [DataMember(Name = "proceeds", IsRequired = true, EmitDefaultValue = true)]
        public double? Proceeds { get; set; }

        /// <summary>
        /// Cost or other basis
        /// </summary>
        /// <value>Cost or other basis</value>
        [DataMember(Name = "costOrOtherBasis", EmitDefaultValue = true)]
        public double? CostOrOtherBasis { get; set; }

        /// <summary>
        /// Accrued market discount
        /// </summary>
        /// <value>Accrued market discount</value>
        [DataMember(Name = "accruedMarketDiscount", EmitDefaultValue = true)]
        public double? AccruedMarketDiscount { get; set; }

        /// <summary>
        /// Wash sale loss disallowed
        /// </summary>
        /// <value>Wash sale loss disallowed</value>
        [DataMember(Name = "washSaleLossDisallowed", EmitDefaultValue = true)]
        public double? WashSaleLossDisallowed { get; set; }

        /// <summary>
        /// Federal income tax withheld. Must be less than &#x60;proceeds&#x60; (zero when &#x60;proceeds&#x60; is zero or negative), and can&#39;t be  more than 24% of the other amounts on the form combined, not counting state and local withholding.
        /// </summary>
        /// <value>Federal income tax withheld. Must be less than &#x60;proceeds&#x60; (zero when &#x60;proceeds&#x60; is zero or negative), and can&#39;t be  more than 24% of the other amounts on the form combined, not counting state and local withholding.</value>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// If checked, the security is noncovered
        /// </summary>
        /// <value>If checked, the security is noncovered</value>
        [DataMember(Name = "noncoveredSecurity", EmitDefaultValue = true)]
        public bool? NoncoveredSecurity { get; set; }

        /// <summary>
        /// If checked, the loss is not allowed based on the amount in &#x60;proceeds&#x60;
        /// </summary>
        /// <value>If checked, the loss is not allowed based on the amount in &#x60;proceeds&#x60;</value>
        [DataMember(Name = "lossNotAllowed", EmitDefaultValue = true)]
        public bool? LossNotAllowed { get; set; }

        /// <summary>
        /// Profit or (loss) realized in the tax year on closed contracts
        /// </summary>
        /// <value>Profit or (loss) realized in the tax year on closed contracts</value>
        [DataMember(Name = "profitOrLossRealizedOnClosedContracts", EmitDefaultValue = true)]
        public double? ProfitOrLossRealizedOnClosedContracts { get; set; }

        /// <summary>
        /// Unrealized profit or (loss) on open contracts at the end of the prior tax year
        /// </summary>
        /// <value>Unrealized profit or (loss) on open contracts at the end of the prior tax year</value>
        [DataMember(Name = "unrealizedProfitOrLossOnOpenContractsPriorYear", EmitDefaultValue = true)]
        public double? UnrealizedProfitOrLossOnOpenContractsPriorYear { get; set; }

        /// <summary>
        /// Unrealized profit or (loss) on open contracts at the end of the tax year
        /// </summary>
        /// <value>Unrealized profit or (loss) on open contracts at the end of the tax year</value>
        [DataMember(Name = "unrealizedProfitOrLossOnOpenContractsCurrentYear", EmitDefaultValue = true)]
        public double? UnrealizedProfitOrLossOnOpenContractsCurrentYear { get; set; }

        /// <summary>
        /// Aggregate profit or (loss) on contracts
        /// </summary>
        /// <value>Aggregate profit or (loss) on contracts</value>
        [DataMember(Name = "aggregateProfitOrLossOnContracts", EmitDefaultValue = true)]
        public double? AggregateProfitOrLossOnContracts { get; set; }

        /// <summary>
        /// If checked, the basis is reported to the IRS. Only takes effect when &#x60;noncoveredSecurity&#x60; is also checked:  otherwise it isn&#39;t sent to the IRS, and changing it doesn&#39;t trigger a correction.
        /// </summary>
        /// <value>If checked, the basis is reported to the IRS. Only takes effect when &#x60;noncoveredSecurity&#x60; is also checked:  otherwise it isn&#39;t sent to the IRS, and changing it doesn&#39;t trigger a correction.</value>
        [DataMember(Name = "basisReportedToIrs", EmitDefaultValue = true)]
        public bool? BasisReportedToIrs { get; set; }

        /// <summary>
        /// Bartering
        /// </summary>
        /// <value>Bartering</value>
        [DataMember(Name = "bartering", EmitDefaultValue = true)]
        public double? Bartering { get; set; }

        /// <summary>
        /// FATCA filing requirement
        /// </summary>
        /// <value>FATCA filing requirement</value>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool? FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Form ID. Unique identifier set when the record is created.
        /// </summary>
        /// <value>Form ID. Unique identifier set when the record is created.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Issuer ID - only required when creating forms
        /// </summary>
        /// <value>Issuer ID - only required when creating forms</value>
        [DataMember(Name = "issuerId", EmitDefaultValue = true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Issuer Reference ID - only required when creating forms via $bulk-upsert
        /// </summary>
        /// <value>Issuer Reference ID - only required when creating forms via $bulk-upsert</value>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN - readonly
        /// </summary>
        /// <value>Issuer TIN - readonly</value>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax Year - only required when creating forms via $bulk-upsert
        /// </summary>
        /// <value>Tax Year - only required when creating forms via $bulk-upsert</value>
        [DataMember(Name = "taxYear", EmitDefaultValue = true)]
        public int? TaxYear { get; set; }

        /// <summary>
        /// Internal reference ID. Never shown to any agency or recipient.
        /// </summary>
        /// <value>Internal reference ID. Never shown to any agency or recipient.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Recipient&#39;s Federal Tax Identification Number (TIN).
        /// </summary>
        /// <value>Recipient&#39;s Federal Tax Identification Number (TIN).</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// DEPRECATED: Use &#x60;businessName&#x60; for businesses; use &#x60;firstName&#x60;, &#x60;middleName&#x60;, &#x60;lastName&#x60;, and &#x60;suffixName&#x60; for individuals.
        /// </summary>
        /// <value>DEPRECATED: Use &#x60;businessName&#x60; for businesses; use &#x60;firstName&#x60;, &#x60;middleName&#x60;, &#x60;lastName&#x60;, and &#x60;suffixName&#x60; for individuals.</value>
        [DataMember(Name = "recipientName", EmitDefaultValue = true)]
        [Obsolete]
        public string RecipientName { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        /// <value>Address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Address line 2.
        /// </summary>
        /// <value>Address line 2.</value>
        [DataMember(Name = "address2", EmitDefaultValue = true)]
        public string Address2 { get; set; }

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
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// ZIP/postal code.
        /// </summary>
        /// <value>ZIP/postal code.</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Recipient&#39;s Contact email address.
        /// </summary>
        /// <value>Recipient&#39;s Contact email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Province or region for non-US/CA addresses.
        /// </summary>
        /// <value>Province or region for non-US/CA addresses.</value>
        [DataMember(Name = "nonUsProvince", EmitDefaultValue = true)]
        public string NonUsProvince { get; set; }

        /// <summary>
        /// Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes.
        /// </summary>
        /// <value>Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.
        /// </summary>
        /// <value>Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.</value>
        [DataMember(Name = "federalEfileDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? FederalEfileDate { get; set; }

        /// <summary>
        /// Boolean indicating that postal mailing to the recipient should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that postal mailing to the recipient should be scheduled for this form</value>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool? PostalMail { get; set; }

        /// <summary>
        /// Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.
        /// </summary>
        /// <value>Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.</value>
        [DataMember(Name = "stateEfileDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StateEfileDate { get; set; }

        /// <summary>
        /// Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.
        /// </summary>
        /// <value>Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled.</value>
        [DataMember(Name = "recipientEdeliveryDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RecipientEdeliveryDate { get; set; }

        /// <summary>
        /// Boolean indicating that TIN Matching should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that TIN Matching should be scheduled for this form</value>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool? TinMatch { get; set; }

        /// <summary>
        /// Boolean indicating that address verification should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification should be scheduled for this form</value>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool? AddressVerification { get; set; }

        /// <summary>
        /// State and local withholding information
        /// </summary>
        /// <value>State and local withholding information</value>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholding StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)  When the form&#39;s most recent IRIS filing was rejected or accepted with errors, &#x60;errors&#x60; lists what the IRS reported.
        /// </summary>
        /// <value>Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)  When the form&#39;s most recent IRIS filing was rejected or accepted with errors, &#x60;errors&#x60; lists what the IRS reported.</value>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = true)]
        public FederalEfileStatusDetail FederalEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as FederalEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFederalEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// State e-file status.  Available values:  - unscheduled: Form has not been scheduled for state e-filing  - scheduled: Form is scheduled for state e-filing  - airlocked: Form is in process of being uploaded to the state  - sent: Form has been sent to the state  - rejected: Form was rejected by the state  - accepted: Form was accepted by the state  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlocked: Correction is in process of being uploaded to the state  - corrected_sent: Correction has been sent to the state  - corrected_rejected: Correction was rejected by the state  - corrected_accepted: Correction was accepted by the state
        /// </summary>
        /// <value>State e-file status.  Available values:  - unscheduled: Form has not been scheduled for state e-filing  - scheduled: Form is scheduled for state e-filing  - airlocked: Form is in process of being uploaded to the state  - sent: Form has been sent to the state  - rejected: Form was rejected by the state  - accepted: Form was accepted by the state  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlocked: Correction is in process of being uploaded to the state  - corrected_sent: Correction has been sent to the state  - corrected_rejected: Correction was rejected by the state  - corrected_accepted: Correction was accepted by the state</value>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public List<StateEfileStatusDetail> StateEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as StateEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStateEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// Postal mail to recipient status.  Available values:  - unscheduled: Postal mail has not been scheduled  - pending: Postal mail is pending to be sent  - sent: Postal mail has been sent  - delivered: Postal mail has been delivered
        /// </summary>
        /// <value>Postal mail to recipient status.  Available values:  - unscheduled: Postal mail has not been scheduled  - pending: Postal mail is pending to be sent  - sent: Postal mail has been sent  - delivered: Postal mail has been delivered</value>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail PostalMailStatus { get; private set; }

        /// <summary>
        /// Returns false as PostalMailStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostalMailStatus()
        {
            return false;
        }
        /// <summary>
        /// TIN Match status.  Available values:  - none: TIN matching has not been performed  - pending: TIN matching request is pending  - matched: Name/TIN combination matches IRS records  - unknown: TIN is missing, invalid, or request contains errors  - rejected: Name/TIN combination does not match IRS records or TIN not currently issued
        /// </summary>
        /// <value>TIN Match status.  Available values:  - none: TIN matching has not been performed  - pending: TIN matching request is pending  - matched: Name/TIN combination matches IRS records  - unknown: TIN is missing, invalid, or request contains errors  - rejected: Name/TIN combination does not match IRS records or TIN not currently issued</value>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail TinMatchStatus { get; private set; }

        /// <summary>
        /// Returns false as TinMatchStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTinMatchStatus()
        {
            return false;
        }
        /// <summary>
        /// Address verification status.  Available values:  - unknown: Address verification has not been checked  - pending: Address verification is in progress  - failed: Address verification failed  - incomplete: Address verification is incomplete  - unchanged: User declined address changes  - verified: Address has been verified and accepted
        /// </summary>
        /// <value>Address verification status.  Available values:  - unknown: Address verification has not been checked  - pending: Address verification is in progress  - failed: Address verification failed  - incomplete: Address verification is incomplete  - unchanged: User declined address changes  - verified: Address has been verified and accepted</value>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail AddressVerificationStatus { get; private set; }

        /// <summary>
        /// Returns false as AddressVerificationStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressVerificationStatus()
        {
            return false;
        }
        /// <summary>
        /// EDelivery status.  Available values:  - unscheduled: E-delivery has not been scheduled  - scheduled: E-delivery is scheduled to be sent  - sent: E-delivery has been sent to recipient  - bounced: E-delivery bounced back (invalid email)  - refused: E-delivery was refused by recipient  - bad_verify: E-delivery failed verification  - accepted: E-delivery was accepted by recipient  - bad_verify_limit: E-delivery failed verification limit reached  - second_delivery: Second e-delivery attempt  - undelivered: E-delivery is undelivered (temporary state allowing resend)
        /// </summary>
        /// <value>EDelivery status.  Available values:  - unscheduled: E-delivery has not been scheduled  - scheduled: E-delivery is scheduled to be sent  - sent: E-delivery has been sent to recipient  - bounced: E-delivery bounced back (invalid email)  - refused: E-delivery was refused by recipient  - bad_verify: E-delivery failed verification  - accepted: E-delivery was accepted by recipient  - bad_verify_limit: E-delivery failed verification limit reached  - second_delivery: Second e-delivery attempt  - undelivered: E-delivery is undelivered (temporary state allowing resend)</value>
        [DataMember(Name = "eDeliveryStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail EDeliveryStatus { get; private set; }

        /// <summary>
        /// Returns false as EDeliveryStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEDeliveryStatus()
        {
            return false;
        }
        /// <summary>
        /// Validation errors
        /// </summary>
        /// <value>Validation errors</value>
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
        /// Date time when the record was created.
        /// </summary>
        /// <value>Date time when the record was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Date time when the record was last updated.
        /// </summary>
        /// <value>Date time when the record was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Business name. Required when the recipient of the form is a business; should only be used for businesses.
        /// </summary>
        /// <value>Business name. Required when the recipient of the form is a business; should only be used for businesses.</value>
        [DataMember(Name = "businessName", EmitDefaultValue = true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Business name line 2. Should only be used for businesses.
        /// </summary>
        /// <value>Business name line 2. Should only be used for businesses.</value>
        [DataMember(Name = "businessName2", EmitDefaultValue = true)]
        public string BusinessName2 { get; set; }

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
        [DataMember(Name = "suffixName", EmitDefaultValue = true)]
        public string SuffixName { get; set; }

        /// <summary>
        /// DEPRECATED: Use &#x60;businessName2&#x60; instead.
        /// </summary>
        /// <value>DEPRECATED: Use &#x60;businessName2&#x60; instead.</value>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        [Obsolete]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        /// <value>Account number</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Office code
        /// </summary>
        /// <value>Office code</value>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// No TIN indicator
        /// </summary>
        /// <value>No TIN indicator</value>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool? NoTin { get; set; }

        /// <summary>
        /// Second TIN notice
        /// </summary>
        /// <value>Second TIN notice</value>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool? SecondTinNotice { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099B {\n");
            sb.Append("  ApplicableCheckboxOnForm8949: ").Append(ApplicableCheckboxOnForm8949).Append("\n");
            sb.Append("  CusipNumber: ").Append(CusipNumber).Append("\n");
            sb.Append("  DescriptionOfProperty: ").Append(DescriptionOfProperty).Append("\n");
            sb.Append("  DateAcquired: ").Append(DateAcquired).Append("\n");
            sb.Append("  DateSoldOrDisposed: ").Append(DateSoldOrDisposed).Append("\n");
            sb.Append("  Proceeds: ").Append(Proceeds).Append("\n");
            sb.Append("  CostOrOtherBasis: ").Append(CostOrOtherBasis).Append("\n");
            sb.Append("  AccruedMarketDiscount: ").Append(AccruedMarketDiscount).Append("\n");
            sb.Append("  WashSaleLossDisallowed: ").Append(WashSaleLossDisallowed).Append("\n");
            sb.Append("  TypeOfGainOrLoss: ").Append(TypeOfGainOrLoss).Append("\n");
            sb.Append("  ProceedsFrom: ").Append(ProceedsFrom).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  NoncoveredSecurity: ").Append(NoncoveredSecurity).Append("\n");
            sb.Append("  ProceedsReportedToIrs: ").Append(ProceedsReportedToIrs).Append("\n");
            sb.Append("  LossNotAllowed: ").Append(LossNotAllowed).Append("\n");
            sb.Append("  ProfitOrLossRealizedOnClosedContracts: ").Append(ProfitOrLossRealizedOnClosedContracts).Append("\n");
            sb.Append("  UnrealizedProfitOrLossOnOpenContractsPriorYear: ").Append(UnrealizedProfitOrLossOnOpenContractsPriorYear).Append("\n");
            sb.Append("  UnrealizedProfitOrLossOnOpenContractsCurrentYear: ").Append(UnrealizedProfitOrLossOnOpenContractsCurrentYear).Append("\n");
            sb.Append("  AggregateProfitOrLossOnContracts: ").Append(AggregateProfitOrLossOnContracts).Append("\n");
            sb.Append("  BasisReportedToIrs: ").Append(BasisReportedToIrs).Append("\n");
            sb.Append("  Bartering: ").Append(Bartering).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NonUsProvince: ").Append(NonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FederalEfileDate: ").Append(FederalEfileDate).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEfileDate: ").Append(StateEfileDate).Append("\n");
            sb.Append("  RecipientEdeliveryDate: ").Append(RecipientEdeliveryDate).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  EDeliveryStatus: ").Append(EDeliveryStatus).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessName2: ").Append(BusinessName2).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  SuffixName: ").Append(SuffixName).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
