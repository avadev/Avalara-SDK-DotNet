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
    /// Intermediary or flow-through entity information for tax forms
    /// </summary>
    [DataContract(Name = "IntermediaryOrFlowThrough")]
    public partial class IntermediaryOrFlowThrough : IValidatableObject
    {
        /// <summary>
        /// Chapter 3 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020) - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020) - 03: Territory FI - treated as U.S. Person - 04: Territory FI - not treated as U.S. Person - 05: U.S. branch - treated as U.S. Person - 06: U.S. branch - not treated as U.S. Person - 07: U.S. branch - ECI presumption applied - 08: Partnership other than Withholding Foreign Partnership - 09: Withholding Foreign Partnership - 10: Trust other than Withholding Foreign Trust - 11: Withholding Foreign Trust - 12: Qualified Intermediary - 13: Qualified Securities Lender - Qualified Intermediary - 14: Qualified Securities Lender - Other - 15: Corporation - 16: Individual - 17: Estate - 18: Private Foundation - 19: Government or International Organization - 20: Tax Exempt Organization (Section 501(c) entities) - 21: Unknown Recipient - 22: Artist or Athlete - 23: Pension - 24: Foreign Central Bank of Issue - 25: Nonqualified Intermediary - 26: Hybrid entity making Treaty Claim - 27: Withholding Rate Pool - General - 28: Withholding Rate Pool - Exempt Organization - 29: PAI Withholding Rate Pool - General - 30: PAI Withholding Rate Pool - Exempt Organization - 31: Agency Withholding Rate Pool - General - 32: Agency Withholding Rate Pool - Exempt Organization - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020) - 35: Qualified Derivatives Dealer - 36: Foreign Government - Integral Part - 37: Foreign Government - Controlled Entity - 38: Publicly Traded Partnership - 39: Disclosing Qualified Intermediary
        /// </summary>
        /// <value>Chapter 3 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020) - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020) - 03: Territory FI - treated as U.S. Person - 04: Territory FI - not treated as U.S. Person - 05: U.S. branch - treated as U.S. Person - 06: U.S. branch - not treated as U.S. Person - 07: U.S. branch - ECI presumption applied - 08: Partnership other than Withholding Foreign Partnership - 09: Withholding Foreign Partnership - 10: Trust other than Withholding Foreign Trust - 11: Withholding Foreign Trust - 12: Qualified Intermediary - 13: Qualified Securities Lender - Qualified Intermediary - 14: Qualified Securities Lender - Other - 15: Corporation - 16: Individual - 17: Estate - 18: Private Foundation - 19: Government or International Organization - 20: Tax Exempt Organization (Section 501(c) entities) - 21: Unknown Recipient - 22: Artist or Athlete - 23: Pension - 24: Foreign Central Bank of Issue - 25: Nonqualified Intermediary - 26: Hybrid entity making Treaty Claim - 27: Withholding Rate Pool - General - 28: Withholding Rate Pool - Exempt Organization - 29: PAI Withholding Rate Pool - General - 30: PAI Withholding Rate Pool - Exempt Organization - 31: Agency Withholding Rate Pool - General - 32: Agency Withholding Rate Pool - Exempt Organization - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020) - 35: Qualified Derivatives Dealer - 36: Foreign Government - Integral Part - 37: Foreign Government - Controlled Entity - 38: Publicly Traded Partnership - 39: Disclosing Qualified Intermediary</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Chap3StatusCodeEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _34 for value: 34
            /// </summary>
            [EnumMember(Value = "34")]
            _34 = 3,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 4,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 5,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 6,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 7,

            /// <summary>
            /// Enum _07 for value: 07
            /// </summary>
            [EnumMember(Value = "07")]
            _07 = 8,

            /// <summary>
            /// Enum _08 for value: 08
            /// </summary>
            [EnumMember(Value = "08")]
            _08 = 9,

            /// <summary>
            /// Enum _09 for value: 09
            /// </summary>
            [EnumMember(Value = "09")]
            _09 = 10,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 11,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 12,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 13,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 14,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 15,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 16,

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16 = 17,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 18,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 19,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 20,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 21,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 22,

            /// <summary>
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 23,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 24,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 25,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 26,

            /// <summary>
            /// Enum _26 for value: 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26 = 27,

            /// <summary>
            /// Enum _27 for value: 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27 = 28,

            /// <summary>
            /// Enum _28 for value: 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28 = 29,

            /// <summary>
            /// Enum _29 for value: 29
            /// </summary>
            [EnumMember(Value = "29")]
            _29 = 30,

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30 = 31,

            /// <summary>
            /// Enum _31 for value: 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31 = 32,

            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            [EnumMember(Value = "32")]
            _32 = 33,

            /// <summary>
            /// Enum _35 for value: 35
            /// </summary>
            [EnumMember(Value = "35")]
            _35 = 34,

            /// <summary>
            /// Enum _36 for value: 36
            /// </summary>
            [EnumMember(Value = "36")]
            _36 = 35,

            /// <summary>
            /// Enum _37 for value: 37
            /// </summary>
            [EnumMember(Value = "37")]
            _37 = 36,

            /// <summary>
            /// Enum _38 for value: 38
            /// </summary>
            [EnumMember(Value = "38")]
            _38 = 37,

            /// <summary>
            /// Enum _39 for value: 39
            /// </summary>
            [EnumMember(Value = "39")]
            _39 = 38
        }


        /// <summary>
        /// Chapter 3 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020) - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020) - 03: Territory FI - treated as U.S. Person - 04: Territory FI - not treated as U.S. Person - 05: U.S. branch - treated as U.S. Person - 06: U.S. branch - not treated as U.S. Person - 07: U.S. branch - ECI presumption applied - 08: Partnership other than Withholding Foreign Partnership - 09: Withholding Foreign Partnership - 10: Trust other than Withholding Foreign Trust - 11: Withholding Foreign Trust - 12: Qualified Intermediary - 13: Qualified Securities Lender - Qualified Intermediary - 14: Qualified Securities Lender - Other - 15: Corporation - 16: Individual - 17: Estate - 18: Private Foundation - 19: Government or International Organization - 20: Tax Exempt Organization (Section 501(c) entities) - 21: Unknown Recipient - 22: Artist or Athlete - 23: Pension - 24: Foreign Central Bank of Issue - 25: Nonqualified Intermediary - 26: Hybrid entity making Treaty Claim - 27: Withholding Rate Pool - General - 28: Withholding Rate Pool - Exempt Organization - 29: PAI Withholding Rate Pool - General - 30: PAI Withholding Rate Pool - Exempt Organization - 31: Agency Withholding Rate Pool - General - 32: Agency Withholding Rate Pool - Exempt Organization - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020) - 35: Qualified Derivatives Dealer - 36: Foreign Government - Integral Part - 37: Foreign Government - Controlled Entity - 38: Publicly Traded Partnership - 39: Disclosing Qualified Intermediary
        /// </summary>
        /// <value>Chapter 3 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020) - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020) - 03: Territory FI - treated as U.S. Person - 04: Territory FI - not treated as U.S. Person - 05: U.S. branch - treated as U.S. Person - 06: U.S. branch - not treated as U.S. Person - 07: U.S. branch - ECI presumption applied - 08: Partnership other than Withholding Foreign Partnership - 09: Withholding Foreign Partnership - 10: Trust other than Withholding Foreign Trust - 11: Withholding Foreign Trust - 12: Qualified Intermediary - 13: Qualified Securities Lender - Qualified Intermediary - 14: Qualified Securities Lender - Other - 15: Corporation - 16: Individual - 17: Estate - 18: Private Foundation - 19: Government or International Organization - 20: Tax Exempt Organization (Section 501(c) entities) - 21: Unknown Recipient - 22: Artist or Athlete - 23: Pension - 24: Foreign Central Bank of Issue - 25: Nonqualified Intermediary - 26: Hybrid entity making Treaty Claim - 27: Withholding Rate Pool - General - 28: Withholding Rate Pool - Exempt Organization - 29: PAI Withholding Rate Pool - General - 30: PAI Withholding Rate Pool - Exempt Organization - 31: Agency Withholding Rate Pool - General - 32: Agency Withholding Rate Pool - Exempt Organization - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020) - 35: Qualified Derivatives Dealer - 36: Foreign Government - Integral Part - 37: Foreign Government - Controlled Entity - 38: Publicly Traded Partnership - 39: Disclosing Qualified Intermediary</value>
        [DataMember(Name = "chap3StatusCode", EmitDefaultValue = true)]
        public Chap3StatusCodeEnum? Chap3StatusCode { get; set; }
        /// <summary>
        /// Chapter 4 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI - 02: U.S. Withholding Agent - Other - 03: Territory FI - not treated as U.S. Person - 04: Territory FI - treated as U.S. Person - 05: Participating FFI - Other - 06: Participating FFI - Reporting Model 2 FFI - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI - 08: Registered Deemed - Compliant FFI-Sponsored Entity - 09: Registered Deemed - Compliant FFI-Other - 10: Certified Deemed - Compliant FFI-Other - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank - 13: Certified Deemed - Compliant FFI-Sponsored Entity - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager - 15: Nonparticipating FFI - 16: Owner-Documented FFI - 17: U.S. Branch - treated as U.S. person - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471) - 19: Passive NFFE identifying Substantial U.S. Owners - 20: Passive NFFE with no Substantial U.S. Owners - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE - 22: Active NFFE - 23: Individual - 24: Section 501(c) Entities - 25: Excepted Territory NFFE - 26: Excepted NFFE - Other - 27: Exempt Beneficial Owner - 28: Entity Wholly Owned by Exempt Beneficial Owners - 29: Unknown Recipient - 30: Recalcitrant Account Holder - 31: Nonreporting IGA FFI - 32: Direct reporting NFFE - 33: U.S. reportable account - 34: Non-consenting U.S. account - 35: Sponsored direct reporting NFFE - 36: Excepted Inter-affiliate FFI - 37: Undocumented Preexisting Obligation - 38: U.S. Branch - ECI presumption applied - 39: Account Holder of Excluded Financial Account - 40: Passive NFFE reported by FFI - 41: NFFE subject to 1472 withholding - 42: Recalcitrant Pool - No U.S. Indicia - 43: Recalcitrant Pool - U.S. Indicia - 44: Recalcitrant Pool - Dormant Account - 45: Recalcitrant Pool - U.S. Persons - 46: Recalcitrant Pool - Passive NFFEs - 47: Nonparticipating FFI Pool - 48: U.S. Payees Pool - 49: QI - Recalcitrant Pool-General - 50: U.S. Withholding Agent-Foreign branch of FI
        /// </summary>
        /// <value>Chapter 4 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI - 02: U.S. Withholding Agent - Other - 03: Territory FI - not treated as U.S. Person - 04: Territory FI - treated as U.S. Person - 05: Participating FFI - Other - 06: Participating FFI - Reporting Model 2 FFI - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI - 08: Registered Deemed - Compliant FFI-Sponsored Entity - 09: Registered Deemed - Compliant FFI-Other - 10: Certified Deemed - Compliant FFI-Other - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank - 13: Certified Deemed - Compliant FFI-Sponsored Entity - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager - 15: Nonparticipating FFI - 16: Owner-Documented FFI - 17: U.S. Branch - treated as U.S. person - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471) - 19: Passive NFFE identifying Substantial U.S. Owners - 20: Passive NFFE with no Substantial U.S. Owners - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE - 22: Active NFFE - 23: Individual - 24: Section 501(c) Entities - 25: Excepted Territory NFFE - 26: Excepted NFFE - Other - 27: Exempt Beneficial Owner - 28: Entity Wholly Owned by Exempt Beneficial Owners - 29: Unknown Recipient - 30: Recalcitrant Account Holder - 31: Nonreporting IGA FFI - 32: Direct reporting NFFE - 33: U.S. reportable account - 34: Non-consenting U.S. account - 35: Sponsored direct reporting NFFE - 36: Excepted Inter-affiliate FFI - 37: Undocumented Preexisting Obligation - 38: U.S. Branch - ECI presumption applied - 39: Account Holder of Excluded Financial Account - 40: Passive NFFE reported by FFI - 41: NFFE subject to 1472 withholding - 42: Recalcitrant Pool - No U.S. Indicia - 43: Recalcitrant Pool - U.S. Indicia - 44: Recalcitrant Pool - Dormant Account - 45: Recalcitrant Pool - U.S. Persons - 46: Recalcitrant Pool - Passive NFFEs - 47: Nonparticipating FFI Pool - 48: U.S. Payees Pool - 49: QI - Recalcitrant Pool-General - 50: U.S. Withholding Agent-Foreign branch of FI</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Chap4StatusCodeEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 6,

            /// <summary>
            /// Enum _07 for value: 07
            /// </summary>
            [EnumMember(Value = "07")]
            _07 = 7,

            /// <summary>
            /// Enum _08 for value: 08
            /// </summary>
            [EnumMember(Value = "08")]
            _08 = 8,

            /// <summary>
            /// Enum _09 for value: 09
            /// </summary>
            [EnumMember(Value = "09")]
            _09 = 9,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 10,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 11,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 12,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 13,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 14,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 15,

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16 = 16,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 17,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 18,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 19,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 20,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 21,

            /// <summary>
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 22,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 23,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 24,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 25,

            /// <summary>
            /// Enum _26 for value: 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26 = 26,

            /// <summary>
            /// Enum _27 for value: 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27 = 27,

            /// <summary>
            /// Enum _28 for value: 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28 = 28,

            /// <summary>
            /// Enum _29 for value: 29
            /// </summary>
            [EnumMember(Value = "29")]
            _29 = 29,

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30 = 30,

            /// <summary>
            /// Enum _31 for value: 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31 = 31,

            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            [EnumMember(Value = "32")]
            _32 = 32,

            /// <summary>
            /// Enum _33 for value: 33
            /// </summary>
            [EnumMember(Value = "33")]
            _33 = 33,

            /// <summary>
            /// Enum _34 for value: 34
            /// </summary>
            [EnumMember(Value = "34")]
            _34 = 34,

            /// <summary>
            /// Enum _35 for value: 35
            /// </summary>
            [EnumMember(Value = "35")]
            _35 = 35,

            /// <summary>
            /// Enum _36 for value: 36
            /// </summary>
            [EnumMember(Value = "36")]
            _36 = 36,

            /// <summary>
            /// Enum _37 for value: 37
            /// </summary>
            [EnumMember(Value = "37")]
            _37 = 37,

            /// <summary>
            /// Enum _38 for value: 38
            /// </summary>
            [EnumMember(Value = "38")]
            _38 = 38,

            /// <summary>
            /// Enum _39 for value: 39
            /// </summary>
            [EnumMember(Value = "39")]
            _39 = 39,

            /// <summary>
            /// Enum _40 for value: 40
            /// </summary>
            [EnumMember(Value = "40")]
            _40 = 40,

            /// <summary>
            /// Enum _41 for value: 41
            /// </summary>
            [EnumMember(Value = "41")]
            _41 = 41,

            /// <summary>
            /// Enum _42 for value: 42
            /// </summary>
            [EnumMember(Value = "42")]
            _42 = 42,

            /// <summary>
            /// Enum _43 for value: 43
            /// </summary>
            [EnumMember(Value = "43")]
            _43 = 43,

            /// <summary>
            /// Enum _44 for value: 44
            /// </summary>
            [EnumMember(Value = "44")]
            _44 = 44,

            /// <summary>
            /// Enum _45 for value: 45
            /// </summary>
            [EnumMember(Value = "45")]
            _45 = 45,

            /// <summary>
            /// Enum _46 for value: 46
            /// </summary>
            [EnumMember(Value = "46")]
            _46 = 46,

            /// <summary>
            /// Enum _47 for value: 47
            /// </summary>
            [EnumMember(Value = "47")]
            _47 = 47,

            /// <summary>
            /// Enum _48 for value: 48
            /// </summary>
            [EnumMember(Value = "48")]
            _48 = 48,

            /// <summary>
            /// Enum _49 for value: 49
            /// </summary>
            [EnumMember(Value = "49")]
            _49 = 49,

            /// <summary>
            /// Enum _50 for value: 50
            /// </summary>
            [EnumMember(Value = "50")]
            _50 = 50
        }


        /// <summary>
        /// Chapter 4 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI - 02: U.S. Withholding Agent - Other - 03: Territory FI - not treated as U.S. Person - 04: Territory FI - treated as U.S. Person - 05: Participating FFI - Other - 06: Participating FFI - Reporting Model 2 FFI - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI - 08: Registered Deemed - Compliant FFI-Sponsored Entity - 09: Registered Deemed - Compliant FFI-Other - 10: Certified Deemed - Compliant FFI-Other - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank - 13: Certified Deemed - Compliant FFI-Sponsored Entity - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager - 15: Nonparticipating FFI - 16: Owner-Documented FFI - 17: U.S. Branch - treated as U.S. person - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471) - 19: Passive NFFE identifying Substantial U.S. Owners - 20: Passive NFFE with no Substantial U.S. Owners - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE - 22: Active NFFE - 23: Individual - 24: Section 501(c) Entities - 25: Excepted Territory NFFE - 26: Excepted NFFE - Other - 27: Exempt Beneficial Owner - 28: Entity Wholly Owned by Exempt Beneficial Owners - 29: Unknown Recipient - 30: Recalcitrant Account Holder - 31: Nonreporting IGA FFI - 32: Direct reporting NFFE - 33: U.S. reportable account - 34: Non-consenting U.S. account - 35: Sponsored direct reporting NFFE - 36: Excepted Inter-affiliate FFI - 37: Undocumented Preexisting Obligation - 38: U.S. Branch - ECI presumption applied - 39: Account Holder of Excluded Financial Account - 40: Passive NFFE reported by FFI - 41: NFFE subject to 1472 withholding - 42: Recalcitrant Pool - No U.S. Indicia - 43: Recalcitrant Pool - U.S. Indicia - 44: Recalcitrant Pool - Dormant Account - 45: Recalcitrant Pool - U.S. Persons - 46: Recalcitrant Pool - Passive NFFEs - 47: Nonparticipating FFI Pool - 48: U.S. Payees Pool - 49: QI - Recalcitrant Pool-General - 50: U.S. Withholding Agent-Foreign branch of FI
        /// </summary>
        /// <value>Chapter 4 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI - 02: U.S. Withholding Agent - Other - 03: Territory FI - not treated as U.S. Person - 04: Territory FI - treated as U.S. Person - 05: Participating FFI - Other - 06: Participating FFI - Reporting Model 2 FFI - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI - 08: Registered Deemed - Compliant FFI-Sponsored Entity - 09: Registered Deemed - Compliant FFI-Other - 10: Certified Deemed - Compliant FFI-Other - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank - 13: Certified Deemed - Compliant FFI-Sponsored Entity - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager - 15: Nonparticipating FFI - 16: Owner-Documented FFI - 17: U.S. Branch - treated as U.S. person - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471) - 19: Passive NFFE identifying Substantial U.S. Owners - 20: Passive NFFE with no Substantial U.S. Owners - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE - 22: Active NFFE - 23: Individual - 24: Section 501(c) Entities - 25: Excepted Territory NFFE - 26: Excepted NFFE - Other - 27: Exempt Beneficial Owner - 28: Entity Wholly Owned by Exempt Beneficial Owners - 29: Unknown Recipient - 30: Recalcitrant Account Holder - 31: Nonreporting IGA FFI - 32: Direct reporting NFFE - 33: U.S. reportable account - 34: Non-consenting U.S. account - 35: Sponsored direct reporting NFFE - 36: Excepted Inter-affiliate FFI - 37: Undocumented Preexisting Obligation - 38: U.S. Branch - ECI presumption applied - 39: Account Holder of Excluded Financial Account - 40: Passive NFFE reported by FFI - 41: NFFE subject to 1472 withholding - 42: Recalcitrant Pool - No U.S. Indicia - 43: Recalcitrant Pool - U.S. Indicia - 44: Recalcitrant Pool - Dormant Account - 45: Recalcitrant Pool - U.S. Persons - 46: Recalcitrant Pool - Passive NFFEs - 47: Nonparticipating FFI Pool - 48: U.S. Payees Pool - 49: QI - Recalcitrant Pool-General - 50: U.S. Withholding Agent-Foreign branch of FI</value>
        [DataMember(Name = "chap4StatusCode", EmitDefaultValue = true)]
        public Chap4StatusCodeEnum? Chap4StatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntermediaryOrFlowThrough" /> class.
        /// </summary>
        /// <param name="ein">EIN (Employer Identification Number) of the intermediary or flow-through entity.</param>
        /// <param name="chap3StatusCode">Chapter 3 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020) - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020) - 03: Territory FI - treated as U.S. Person - 04: Territory FI - not treated as U.S. Person - 05: U.S. branch - treated as U.S. Person - 06: U.S. branch - not treated as U.S. Person - 07: U.S. branch - ECI presumption applied - 08: Partnership other than Withholding Foreign Partnership - 09: Withholding Foreign Partnership - 10: Trust other than Withholding Foreign Trust - 11: Withholding Foreign Trust - 12: Qualified Intermediary - 13: Qualified Securities Lender - Qualified Intermediary - 14: Qualified Securities Lender - Other - 15: Corporation - 16: Individual - 17: Estate - 18: Private Foundation - 19: Government or International Organization - 20: Tax Exempt Organization (Section 501(c) entities) - 21: Unknown Recipient - 22: Artist or Athlete - 23: Pension - 24: Foreign Central Bank of Issue - 25: Nonqualified Intermediary - 26: Hybrid entity making Treaty Claim - 27: Withholding Rate Pool - General - 28: Withholding Rate Pool - Exempt Organization - 29: PAI Withholding Rate Pool - General - 30: PAI Withholding Rate Pool - Exempt Organization - 31: Agency Withholding Rate Pool - General - 32: Agency Withholding Rate Pool - Exempt Organization - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020) - 35: Qualified Derivatives Dealer - 36: Foreign Government - Integral Part - 37: Foreign Government - Controlled Entity - 38: Publicly Traded Partnership - 39: Disclosing Qualified Intermediary.</param>
        /// <param name="chap4StatusCode">Chapter 4 status code for the intermediary or flow-through entity. Available values: - 01: U.S. Withholding Agent - FI - 02: U.S. Withholding Agent - Other - 03: Territory FI - not treated as U.S. Person - 04: Territory FI - treated as U.S. Person - 05: Participating FFI - Other - 06: Participating FFI - Reporting Model 2 FFI - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI - 08: Registered Deemed - Compliant FFI-Sponsored Entity - 09: Registered Deemed - Compliant FFI-Other - 10: Certified Deemed - Compliant FFI-Other - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank - 13: Certified Deemed - Compliant FFI-Sponsored Entity - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager - 15: Nonparticipating FFI - 16: Owner-Documented FFI - 17: U.S. Branch - treated as U.S. person - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471) - 19: Passive NFFE identifying Substantial U.S. Owners - 20: Passive NFFE with no Substantial U.S. Owners - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE - 22: Active NFFE - 23: Individual - 24: Section 501(c) Entities - 25: Excepted Territory NFFE - 26: Excepted NFFE - Other - 27: Exempt Beneficial Owner - 28: Entity Wholly Owned by Exempt Beneficial Owners - 29: Unknown Recipient - 30: Recalcitrant Account Holder - 31: Nonreporting IGA FFI - 32: Direct reporting NFFE - 33: U.S. reportable account - 34: Non-consenting U.S. account - 35: Sponsored direct reporting NFFE - 36: Excepted Inter-affiliate FFI - 37: Undocumented Preexisting Obligation - 38: U.S. Branch - ECI presumption applied - 39: Account Holder of Excluded Financial Account - 40: Passive NFFE reported by FFI - 41: NFFE subject to 1472 withholding - 42: Recalcitrant Pool - No U.S. Indicia - 43: Recalcitrant Pool - U.S. Indicia - 44: Recalcitrant Pool - Dormant Account - 45: Recalcitrant Pool - U.S. Persons - 46: Recalcitrant Pool - Passive NFFEs - 47: Nonparticipating FFI Pool - 48: U.S. Payees Pool - 49: QI - Recalcitrant Pool-General - 50: U.S. Withholding Agent-Foreign branch of FI.</param>
        /// <param name="name">Name of the intermediary or flow-through entity.</param>
        /// <param name="giin">GIIN (Global Intermediary Identification Number) of the intermediary or flow-through entity.</param>
        /// <param name="countryCode">Country code for the intermediary or flow-through entity.</param>
        /// <param name="foreignTin">Foreign TIN of the intermediary or flow-through entity.</param>
        /// <param name="address">Address of the intermediary or flow-through entity.</param>
        /// <param name="city">City of the intermediary or flow-through entity.</param>
        /// <param name="state">State of the intermediary or flow-through entity.</param>
        /// <param name="zip">Zip code of the intermediary or flow-through entity.</param>
        public IntermediaryOrFlowThrough(string ein = default(string), Chap3StatusCodeEnum? chap3StatusCode = default(Chap3StatusCodeEnum?), Chap4StatusCodeEnum? chap4StatusCode = default(Chap4StatusCodeEnum?), string name = default(string), string giin = default(string), string countryCode = default(string), string foreignTin = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string))
        {
            this.Ein = ein;
            this.Chap3StatusCode = chap3StatusCode;
            this.Chap4StatusCode = chap4StatusCode;
            this.Name = name;
            this.Giin = giin;
            this.CountryCode = countryCode;
            this.ForeignTin = foreignTin;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        /// <summary>
        /// EIN (Employer Identification Number) of the intermediary or flow-through entity
        /// </summary>
        /// <value>EIN (Employer Identification Number) of the intermediary or flow-through entity</value>
        [DataMember(Name = "ein", EmitDefaultValue = true)]
        public string Ein { get; set; }

        /// <summary>
        /// Name of the intermediary or flow-through entity
        /// </summary>
        /// <value>Name of the intermediary or flow-through entity</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// GIIN (Global Intermediary Identification Number) of the intermediary or flow-through entity
        /// </summary>
        /// <value>GIIN (Global Intermediary Identification Number) of the intermediary or flow-through entity</value>
        [DataMember(Name = "giin", EmitDefaultValue = true)]
        public string Giin { get; set; }

        /// <summary>
        /// Country code for the intermediary or flow-through entity
        /// </summary>
        /// <value>Country code for the intermediary or flow-through entity</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Foreign TIN of the intermediary or flow-through entity
        /// </summary>
        /// <value>Foreign TIN of the intermediary or flow-through entity</value>
        [DataMember(Name = "foreignTin", EmitDefaultValue = true)]
        public string ForeignTin { get; set; }

        /// <summary>
        /// Address of the intermediary or flow-through entity
        /// </summary>
        /// <value>Address of the intermediary or flow-through entity</value>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// City of the intermediary or flow-through entity
        /// </summary>
        /// <value>City of the intermediary or flow-through entity</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State of the intermediary or flow-through entity
        /// </summary>
        /// <value>State of the intermediary or flow-through entity</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip code of the intermediary or flow-through entity
        /// </summary>
        /// <value>Zip code of the intermediary or flow-through entity</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntermediaryOrFlowThrough {\n");
            sb.Append("  Ein: ").Append(Ein).Append("\n");
            sb.Append("  Chap3StatusCode: ").Append(Chap3StatusCode).Append("\n");
            sb.Append("  Chap4StatusCode: ").Append(Chap4StatusCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Giin: ").Append(Giin).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
