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
    /// W9FormRequest
    /// </summary>
    [DataContract(Name = "W9FormRequest")]
    public partial class W9FormRequest : IValidatableObject
    {
        /// <summary>
        /// The form type (always \&quot;w9\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w9\&quot; for this model).</value>
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
        /// The form type (always \&quot;w9\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w9\&quot; for this model).</value>
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
        /// The classification of the business.  Available values:  - Individual: Individual/sole proprietor  - C Corporation: C Corporation  - S Corporation: S Corporation  - Partnership: Partnership  - Trust/estate: Trust/estate  - LLC-C: Limited liability company (C Corporation)  - LLC-S: Limited liability company (S Corporation)  - LLC-P: Limited liability company (Partnership)  - Other: Other (requires BusinessOther field to be populated)
        /// </summary>
        /// <value>The classification of the business.  Available values:  - Individual: Individual/sole proprietor  - C Corporation: C Corporation  - S Corporation: S Corporation  - Partnership: Partnership  - Trust/estate: Trust/estate  - LLC-C: Limited liability company (C Corporation)  - LLC-S: Limited liability company (S Corporation)  - LLC-P: Limited liability company (Partnership)  - Other: Other (requires BusinessOther field to be populated)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BusinessClassificationEnum
        {
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 1,

            /// <summary>
            /// Enum CCorporation for value: CCorporation
            /// </summary>
            [EnumMember(Value = "CCorporation")]
            CCorporation = 2,

            /// <summary>
            /// Enum SCorporation for value: SCorporation
            /// </summary>
            [EnumMember(Value = "SCorporation")]
            SCorporation = 3,

            /// <summary>
            /// Enum Partnership for value: Partnership
            /// </summary>
            [EnumMember(Value = "Partnership")]
            Partnership = 4,

            /// <summary>
            /// Enum TrustEstate for value: TrustEstate
            /// </summary>
            [EnumMember(Value = "TrustEstate")]
            TrustEstate = 5,

            /// <summary>
            /// Enum LlcC for value: LlcC
            /// </summary>
            [EnumMember(Value = "LlcC")]
            LlcC = 6,

            /// <summary>
            /// Enum LlcS for value: LlcS
            /// </summary>
            [EnumMember(Value = "LlcS")]
            LlcS = 7,

            /// <summary>
            /// Enum LlcP for value: LlcP
            /// </summary>
            [EnumMember(Value = "LlcP")]
            LlcP = 8,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 9
        }


        /// <summary>
        /// The classification of the business.  Available values:  - Individual: Individual/sole proprietor  - C Corporation: C Corporation  - S Corporation: S Corporation  - Partnership: Partnership  - Trust/estate: Trust/estate  - LLC-C: Limited liability company (C Corporation)  - LLC-S: Limited liability company (S Corporation)  - LLC-P: Limited liability company (Partnership)  - Other: Other (requires BusinessOther field to be populated)
        /// </summary>
        /// <value>The classification of the business.  Available values:  - Individual: Individual/sole proprietor  - C Corporation: C Corporation  - S Corporation: S Corporation  - Partnership: Partnership  - Trust/estate: Trust/estate  - LLC-C: Limited liability company (C Corporation)  - LLC-S: Limited liability company (S Corporation)  - LLC-P: Limited liability company (Partnership)  - Other: Other (requires BusinessOther field to be populated)</value>
        [DataMember(Name = "businessClassification", IsRequired = true, EmitDefaultValue = true)]
        public BusinessClassificationEnum BusinessClassification { get; set; }
        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>The state of the address.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 1,

            /// <summary>
            /// Enum AE for value: AE
            /// </summary>
            [EnumMember(Value = "AE")]
            AE = 2,

            /// <summary>
            /// Enum AK for value: AK
            /// </summary>
            [EnumMember(Value = "AK")]
            AK = 3,

            /// <summary>
            /// Enum AL for value: AL
            /// </summary>
            [EnumMember(Value = "AL")]
            AL = 4,

            /// <summary>
            /// Enum AP for value: AP
            /// </summary>
            [EnumMember(Value = "AP")]
            AP = 5,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 6,

            /// <summary>
            /// Enum AS for value: AS
            /// </summary>
            [EnumMember(Value = "AS")]
            AS = 7,

            /// <summary>
            /// Enum AZ for value: AZ
            /// </summary>
            [EnumMember(Value = "AZ")]
            AZ = 8,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 9,

            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            [EnumMember(Value = "CO")]
            CO = 10,

            /// <summary>
            /// Enum CT for value: CT
            /// </summary>
            [EnumMember(Value = "CT")]
            CT = 11,

            /// <summary>
            /// Enum DC for value: DC
            /// </summary>
            [EnumMember(Value = "DC")]
            DC = 12,

            /// <summary>
            /// Enum DE for value: DE
            /// </summary>
            [EnumMember(Value = "DE")]
            DE = 13,

            /// <summary>
            /// Enum FL for value: FL
            /// </summary>
            [EnumMember(Value = "FL")]
            FL = 14,

            /// <summary>
            /// Enum FM for value: FM
            /// </summary>
            [EnumMember(Value = "FM")]
            FM = 15,

            /// <summary>
            /// Enum GA for value: GA
            /// </summary>
            [EnumMember(Value = "GA")]
            GA = 16,

            /// <summary>
            /// Enum GU for value: GU
            /// </summary>
            [EnumMember(Value = "GU")]
            GU = 17,

            /// <summary>
            /// Enum HI for value: HI
            /// </summary>
            [EnumMember(Value = "HI")]
            HI = 18,

            /// <summary>
            /// Enum IA for value: IA
            /// </summary>
            [EnumMember(Value = "IA")]
            IA = 19,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 20,

            /// <summary>
            /// Enum IL for value: IL
            /// </summary>
            [EnumMember(Value = "IL")]
            IL = 21,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 22,

            /// <summary>
            /// Enum KS for value: KS
            /// </summary>
            [EnumMember(Value = "KS")]
            KS = 23,

            /// <summary>
            /// Enum KY for value: KY
            /// </summary>
            [EnumMember(Value = "KY")]
            KY = 24,

            /// <summary>
            /// Enum LA for value: LA
            /// </summary>
            [EnumMember(Value = "LA")]
            LA = 25,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 26,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 27,

            /// <summary>
            /// Enum ME for value: ME
            /// </summary>
            [EnumMember(Value = "ME")]
            ME = 28,

            /// <summary>
            /// Enum MH for value: MH
            /// </summary>
            [EnumMember(Value = "MH")]
            MH = 29,

            /// <summary>
            /// Enum MI for value: MI
            /// </summary>
            [EnumMember(Value = "MI")]
            MI = 30,

            /// <summary>
            /// Enum MN for value: MN
            /// </summary>
            [EnumMember(Value = "MN")]
            MN = 31,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 32,

            /// <summary>
            /// Enum MP for value: MP
            /// </summary>
            [EnumMember(Value = "MP")]
            MP = 33,

            /// <summary>
            /// Enum MS for value: MS
            /// </summary>
            [EnumMember(Value = "MS")]
            MS = 34,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 35,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 36,

            /// <summary>
            /// Enum ND for value: ND
            /// </summary>
            [EnumMember(Value = "ND")]
            ND = 37,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 38,

            /// <summary>
            /// Enum NH for value: NH
            /// </summary>
            [EnumMember(Value = "NH")]
            NH = 39,

            /// <summary>
            /// Enum NJ for value: NJ
            /// </summary>
            [EnumMember(Value = "NJ")]
            NJ = 40,

            /// <summary>
            /// Enum NM for value: NM
            /// </summary>
            [EnumMember(Value = "NM")]
            NM = 41,

            /// <summary>
            /// Enum NV for value: NV
            /// </summary>
            [EnumMember(Value = "NV")]
            NV = 42,

            /// <summary>
            /// Enum NY for value: NY
            /// </summary>
            [EnumMember(Value = "NY")]
            NY = 43,

            /// <summary>
            /// Enum OH for value: OH
            /// </summary>
            [EnumMember(Value = "OH")]
            OH = 44,

            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 45,

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            [EnumMember(Value = "OR")]
            OR = 46,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 47,

            /// <summary>
            /// Enum PR for value: PR
            /// </summary>
            [EnumMember(Value = "PR")]
            PR = 48,

            /// <summary>
            /// Enum PW for value: PW
            /// </summary>
            [EnumMember(Value = "PW")]
            PW = 49,

            /// <summary>
            /// Enum RI for value: RI
            /// </summary>
            [EnumMember(Value = "RI")]
            RI = 50,

            /// <summary>
            /// Enum SC for value: SC
            /// </summary>
            [EnumMember(Value = "SC")]
            SC = 51,

            /// <summary>
            /// Enum SD for value: SD
            /// </summary>
            [EnumMember(Value = "SD")]
            SD = 52,

            /// <summary>
            /// Enum TN for value: TN
            /// </summary>
            [EnumMember(Value = "TN")]
            TN = 53,

            /// <summary>
            /// Enum TX for value: TX
            /// </summary>
            [EnumMember(Value = "TX")]
            TX = 54,

            /// <summary>
            /// Enum UT for value: UT
            /// </summary>
            [EnumMember(Value = "UT")]
            UT = 55,

            /// <summary>
            /// Enum VA for value: VA
            /// </summary>
            [EnumMember(Value = "VA")]
            VA = 56,

            /// <summary>
            /// Enum VI for value: VI
            /// </summary>
            [EnumMember(Value = "VI")]
            VI = 57,

            /// <summary>
            /// Enum VT for value: VT
            /// </summary>
            [EnumMember(Value = "VT")]
            VT = 58,

            /// <summary>
            /// Enum WA for value: WA
            /// </summary>
            [EnumMember(Value = "WA")]
            WA = 59,

            /// <summary>
            /// Enum WI for value: WI
            /// </summary>
            [EnumMember(Value = "WI")]
            WI = 60,

            /// <summary>
            /// Enum WV for value: WV
            /// </summary>
            [EnumMember(Value = "WV")]
            WV = 61,

            /// <summary>
            /// Enum WY for value: WY
            /// </summary>
            [EnumMember(Value = "WY")]
            WY = 62
        }


        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>The state of the address.</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected W9FormRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the individual or entity associated with the form. (required).</param>
        /// <param name="businessName">The name of the business associated with the form..</param>
        /// <param name="businessClassification">The classification of the business.  Available values:  - Individual: Individual/sole proprietor  - C Corporation: C Corporation  - S Corporation: S Corporation  - Partnership: Partnership  - Trust/estate: Trust/estate  - LLC-C: Limited liability company (C Corporation)  - LLC-S: Limited liability company (S Corporation)  - LLC-P: Limited liability company (Partnership)  - Other: Other (requires BusinessOther field to be populated) (required).</param>
        /// <param name="businessOther">The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;..</param>
        /// <param name="foreignPartnerOwnerOrBeneficiary">Indicates whether the individual is a foreign partner, owner, or beneficiary..</param>
        /// <param name="exemptPayeeCode">The exempt payee code. Allowed values (1–13):  - 1 — Organization exempt under §501(a) or IRA; custodial account under §403(b)(7)  - 2 — U.S. government or its agencies/instrumentalities  - 3 — U.S. state, DC, U.S. territory/possession, or their political subdivisions/agencies/instrumentalities  - 4 — Foreign government or its political subdivisions/agencies/instrumentalities  - 5 — Corporation  - 6 — Dealer in securities or commodities required to register in the U.S., DC, or U.S. territory/possession  - 7 — Futures commission merchant registered with the CFTC  - 8 — Real estate investment trust (REIT)  - 9 — Entity registered at all times during the tax year under the Investment Company Act of 1940  - 10 — Common trust fund operated by a bank under §584(a)  - 11 — Financial institution (see §581)  - 12 — Broker (nominee/custodian)  - 13 — Trust exempt under §664 or described in §4947.</param>
        /// <param name="exemptFatcaCode">The exemption from FATCA reporting code. Allowed values (A–M):  - A — Tax‑exempt organization under §501(a) or IRA (§7701(a)(37))  - B — U.S. government or any of its agencies/instrumentalities  - C — U.S. state, DC, territory/possession, or their political subdivisions/instrumentalities  - D — Corporation whose stock is regularly traded on an established securities market  - E — Corporation that is a member of the same expanded affiliated group as a D corporation  - F — Registered dealer in securities/commodities/derivatives  - G — REIT (Real Estate Investment Trust)  - H — Regulated investment company (§851) or entity registered all year under the Investment Company Act of 1940  - I — Common trust fund (§584(a))  - J — Bank (§581)  - K — Broker  - L — Charitable remainder trust (§664) or trust described in §4947(a)(1)  - M — Trust under §403(b) plan or §457(g) plan.</param>
        /// <param name="foreignCountryIndicator">Indicates whether the individual or entity is in a foreign country..</param>
        /// <param name="address">The address of the individual or entity. (required).</param>
        /// <param name="foreignAddress">The foreign address of the individual or entity..</param>
        /// <param name="city">The city of the address. (required).</param>
        /// <param name="state">The state of the address. (required).</param>
        /// <param name="zip">The ZIP code of the address. (required).</param>
        /// <param name="accountNumber">The account number associated with the form..</param>
        /// <param name="tinType">Tax Identification Number (TIN) type. SSN/ITIN (for individuals) and EIN (for businesses). (required).</param>
        /// <param name="tin">The taxpayer identification number (TIN). (required).</param>
        /// <param name="backupWithholding">Indicates whether backup withholding applies..</param>
        /// <param name="is1099able">Indicates whether the individual or entity should be issued a 1099 form..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="companyId">The ID of the associated company. Required when creating a form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        public W9FormRequest(string name = default(string), string businessName = default(string), BusinessClassificationEnum businessClassification = default(BusinessClassificationEnum), string businessOther = default(string), bool foreignPartnerOwnerOrBeneficiary = default(bool), string exemptPayeeCode = default(string), string exemptFatcaCode = default(string), bool foreignCountryIndicator = default(bool), string address = default(string), string foreignAddress = default(string), string city = default(string), StateEnum state = default(StateEnum), string zip = default(string), string accountNumber = default(string), string tinType = default(string), string tin = default(string), bool backupWithholding = default(bool), bool is1099able = default(bool), DateTime? eDeliveryConsentedAt = default(DateTime?), string signature = default(string), string companyId = default(string), string referenceId = default(string), string email = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for W9FormRequest and cannot be null");
            }
            this.Name = name;
            this.BusinessClassification = businessClassification;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for W9FormRequest and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for W9FormRequest and cannot be null");
            }
            this.City = city;
            this.State = state;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for W9FormRequest and cannot be null");
            }
            this.Zip = zip;
            // to ensure "tinType" is required (not null)
            if (tinType == null)
            {
                throw new ArgumentNullException("tinType is a required property for W9FormRequest and cannot be null");
            }
            this.TinType = tinType;
            // to ensure "tin" is required (not null)
            if (tin == null)
            {
                throw new ArgumentNullException("tin is a required property for W9FormRequest and cannot be null");
            }
            this.Tin = tin;
            this.BusinessName = businessName;
            this.BusinessOther = businessOther;
            this.ForeignPartnerOwnerOrBeneficiary = foreignPartnerOwnerOrBeneficiary;
            this.ExemptPayeeCode = exemptPayeeCode;
            this.ExemptFatcaCode = exemptFatcaCode;
            this.ForeignCountryIndicator = foreignCountryIndicator;
            this.ForeignAddress = foreignAddress;
            this.AccountNumber = accountNumber;
            this.BackupWithholding = backupWithholding;
            this.Is1099able = is1099able;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.Signature = signature;
            this.CompanyId = companyId;
            this.ReferenceId = referenceId;
            this.Email = email;
        }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the business associated with the form.
        /// </summary>
        /// <value>The name of the business associated with the form.</value>
        [DataMember(Name = "businessName", EmitDefaultValue = true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;.
        /// </summary>
        /// <value>The classification description when \&quot;businessClassification\&quot; is \&quot;Other\&quot;.</value>
        [DataMember(Name = "businessOther", EmitDefaultValue = true)]
        public string BusinessOther { get; set; }

        /// <summary>
        /// Indicates whether the individual is a foreign partner, owner, or beneficiary.
        /// </summary>
        /// <value>Indicates whether the individual is a foreign partner, owner, or beneficiary.</value>
        [DataMember(Name = "foreignPartnerOwnerOrBeneficiary", EmitDefaultValue = true)]
        public bool ForeignPartnerOwnerOrBeneficiary { get; set; }

        /// <summary>
        /// The exempt payee code. Allowed values (1–13):  - 1 — Organization exempt under §501(a) or IRA; custodial account under §403(b)(7)  - 2 — U.S. government or its agencies/instrumentalities  - 3 — U.S. state, DC, U.S. territory/possession, or their political subdivisions/agencies/instrumentalities  - 4 — Foreign government or its political subdivisions/agencies/instrumentalities  - 5 — Corporation  - 6 — Dealer in securities or commodities required to register in the U.S., DC, or U.S. territory/possession  - 7 — Futures commission merchant registered with the CFTC  - 8 — Real estate investment trust (REIT)  - 9 — Entity registered at all times during the tax year under the Investment Company Act of 1940  - 10 — Common trust fund operated by a bank under §584(a)  - 11 — Financial institution (see §581)  - 12 — Broker (nominee/custodian)  - 13 — Trust exempt under §664 or described in §4947
        /// </summary>
        /// <value>The exempt payee code. Allowed values (1–13):  - 1 — Organization exempt under §501(a) or IRA; custodial account under §403(b)(7)  - 2 — U.S. government or its agencies/instrumentalities  - 3 — U.S. state, DC, U.S. territory/possession, or their political subdivisions/agencies/instrumentalities  - 4 — Foreign government or its political subdivisions/agencies/instrumentalities  - 5 — Corporation  - 6 — Dealer in securities or commodities required to register in the U.S., DC, or U.S. territory/possession  - 7 — Futures commission merchant registered with the CFTC  - 8 — Real estate investment trust (REIT)  - 9 — Entity registered at all times during the tax year under the Investment Company Act of 1940  - 10 — Common trust fund operated by a bank under §584(a)  - 11 — Financial institution (see §581)  - 12 — Broker (nominee/custodian)  - 13 — Trust exempt under §664 or described in §4947</value>
        [DataMember(Name = "exemptPayeeCode", EmitDefaultValue = true)]
        public string ExemptPayeeCode { get; set; }

        /// <summary>
        /// The exemption from FATCA reporting code. Allowed values (A–M):  - A — Tax‑exempt organization under §501(a) or IRA (§7701(a)(37))  - B — U.S. government or any of its agencies/instrumentalities  - C — U.S. state, DC, territory/possession, or their political subdivisions/instrumentalities  - D — Corporation whose stock is regularly traded on an established securities market  - E — Corporation that is a member of the same expanded affiliated group as a D corporation  - F — Registered dealer in securities/commodities/derivatives  - G — REIT (Real Estate Investment Trust)  - H — Regulated investment company (§851) or entity registered all year under the Investment Company Act of 1940  - I — Common trust fund (§584(a))  - J — Bank (§581)  - K — Broker  - L — Charitable remainder trust (§664) or trust described in §4947(a)(1)  - M — Trust under §403(b) plan or §457(g) plan
        /// </summary>
        /// <value>The exemption from FATCA reporting code. Allowed values (A–M):  - A — Tax‑exempt organization under §501(a) or IRA (§7701(a)(37))  - B — U.S. government or any of its agencies/instrumentalities  - C — U.S. state, DC, territory/possession, or their political subdivisions/instrumentalities  - D — Corporation whose stock is regularly traded on an established securities market  - E — Corporation that is a member of the same expanded affiliated group as a D corporation  - F — Registered dealer in securities/commodities/derivatives  - G — REIT (Real Estate Investment Trust)  - H — Regulated investment company (§851) or entity registered all year under the Investment Company Act of 1940  - I — Common trust fund (§584(a))  - J — Bank (§581)  - K — Broker  - L — Charitable remainder trust (§664) or trust described in §4947(a)(1)  - M — Trust under §403(b) plan or §457(g) plan</value>
        [DataMember(Name = "exemptFatcaCode", EmitDefaultValue = true)]
        public string ExemptFatcaCode { get; set; }

        /// <summary>
        /// Indicates whether the individual or entity is in a foreign country.
        /// </summary>
        /// <value>Indicates whether the individual or entity is in a foreign country.</value>
        [DataMember(Name = "foreignCountryIndicator", EmitDefaultValue = true)]
        public bool ForeignCountryIndicator { get; set; }

        /// <summary>
        /// The address of the individual or entity.
        /// </summary>
        /// <value>The address of the individual or entity.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The foreign address of the individual or entity.
        /// </summary>
        /// <value>The foreign address of the individual or entity.</value>
        [DataMember(Name = "foreignAddress", EmitDefaultValue = true)]
        public string ForeignAddress { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        /// <value>The city of the address.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The ZIP code of the address.
        /// </summary>
        /// <value>The ZIP code of the address.</value>
        [DataMember(Name = "zip", IsRequired = true, EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// The account number associated with the form.
        /// </summary>
        /// <value>The account number associated with the form.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Tax Identification Number (TIN) type. SSN/ITIN (for individuals) and EIN (for businesses).
        /// </summary>
        /// <value>Tax Identification Number (TIN) type. SSN/ITIN (for individuals) and EIN (for businesses).</value>
        [DataMember(Name = "tinType", IsRequired = true, EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        [DataMember(Name = "tin", IsRequired = true, EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Indicates whether backup withholding applies.
        /// </summary>
        /// <value>Indicates whether backup withholding applies.</value>
        [DataMember(Name = "backupWithholding", EmitDefaultValue = true)]
        public bool BackupWithholding { get; set; }

        /// <summary>
        /// Indicates whether the individual or entity should be issued a 1099 form.
        /// </summary>
        /// <value>Indicates whether the individual or entity should be issued a 1099 form.</value>
        [DataMember(Name = "is1099able", EmitDefaultValue = true)]
        public bool Is1099able { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// The signature of the form.
        /// </summary>
        /// <value>The signature of the form.</value>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

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
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W9FormRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessClassification: ").Append(BusinessClassification).Append("\n");
            sb.Append("  BusinessOther: ").Append(BusinessOther).Append("\n");
            sb.Append("  ForeignPartnerOwnerOrBeneficiary: ").Append(ForeignPartnerOwnerOrBeneficiary).Append("\n");
            sb.Append("  ExemptPayeeCode: ").Append(ExemptPayeeCode).Append("\n");
            sb.Append("  ExemptFatcaCode: ").Append(ExemptFatcaCode).Append("\n");
            sb.Append("  ForeignCountryIndicator: ").Append(ForeignCountryIndicator).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ForeignAddress: ").Append(ForeignAddress).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BackupWithholding: ").Append(BackupWithholding).Append("\n");
            sb.Append("  Is1099able: ").Append(Is1099able).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
