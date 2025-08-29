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
    /// Form 1042-S: Foreign Person&#39;s U.S. Source Income Subject to Withholding
    /// </summary>
    [DataContract(Name = "Form1042S")]
    public partial class Form1042S : IValidatableObject
    {
        /// <summary>
        /// Defines TinType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TinTypeEnum
        {
            /// <summary>
            /// Enum Empty for value: Empty
            /// </summary>
            [EnumMember(Value = "Empty")]
            Empty = 1,

            /// <summary>
            /// Enum EIN for value: EIN
            /// </summary>
            [EnumMember(Value = "EIN")]
            EIN = 2,

            /// <summary>
            /// Enum SSN for value: SSN
            /// </summary>
            [EnumMember(Value = "SSN")]
            SSN = 3,

            /// <summary>
            /// Enum ITIN for value: ITIN
            /// </summary>
            [EnumMember(Value = "ITIN")]
            ITIN = 4,

            /// <summary>
            /// Enum ATIN for value: ATIN
            /// </summary>
            [EnumMember(Value = "ATIN")]
            ATIN = 5
        }


        /// <summary>
        /// Gets or Sets TinType
        /// </summary>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public TinTypeEnum? TinType { get; set; }

        /// <summary>
        /// Returns false as TinType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTinType()
        {
            return false;
        }
        /// <summary>
        /// Limitation on Benefits (LOB) code for tax treaty purposes.  Available values:  - 01: Individual (Deprecated - valid only for tax years prior to 2019)  - 02: Government - contracting state/political subdivision/local authority  - 03: Tax exempt pension trust/Pension fund  - 04: Tax exempt/Charitable organization  - 05: Publicly-traded corporation  - 06: Subsidiary of publicly-traded corporation  - 07: Company that meets the ownership and base erosion test  - 08: Company that meets the derivative benefits test  - 09: Company with an item of income that meets the active trade or business test  - 10: Discretionary determination  - 11: Other  - 12: No LOB article in treaty
        /// </summary>
        /// <value>Limitation on Benefits (LOB) code for tax treaty purposes.  Available values:  - 01: Individual (Deprecated - valid only for tax years prior to 2019)  - 02: Government - contracting state/political subdivision/local authority  - 03: Tax exempt pension trust/Pension fund  - 04: Tax exempt/Charitable organization  - 05: Publicly-traded corporation  - 06: Subsidiary of publicly-traded corporation  - 07: Company that meets the ownership and base erosion test  - 08: Company that meets the derivative benefits test  - 09: Company with an item of income that meets the active trade or business test  - 10: Discretionary determination  - 11: Other  - 12: No LOB article in treaty</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LobCodeEnum
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
            _12 = 12
        }


        /// <summary>
        /// Limitation on Benefits (LOB) code for tax treaty purposes.  Available values:  - 01: Individual (Deprecated - valid only for tax years prior to 2019)  - 02: Government - contracting state/political subdivision/local authority  - 03: Tax exempt pension trust/Pension fund  - 04: Tax exempt/Charitable organization  - 05: Publicly-traded corporation  - 06: Subsidiary of publicly-traded corporation  - 07: Company that meets the ownership and base erosion test  - 08: Company that meets the derivative benefits test  - 09: Company with an item of income that meets the active trade or business test  - 10: Discretionary determination  - 11: Other  - 12: No LOB article in treaty
        /// </summary>
        /// <value>Limitation on Benefits (LOB) code for tax treaty purposes.  Available values:  - 01: Individual (Deprecated - valid only for tax years prior to 2019)  - 02: Government - contracting state/political subdivision/local authority  - 03: Tax exempt pension trust/Pension fund  - 04: Tax exempt/Charitable organization  - 05: Publicly-traded corporation  - 06: Subsidiary of publicly-traded corporation  - 07: Company that meets the ownership and base erosion test  - 08: Company that meets the derivative benefits test  - 09: Company with an item of income that meets the active trade or business test  - 10: Discretionary determination  - 11: Other  - 12: No LOB article in treaty</value>
        [DataMember(Name = "lobCode", EmitDefaultValue = true)]
        public LobCodeEnum? LobCode { get; set; }
        /// <summary>
        /// Income code.  Available values:    Interest:  - 01: Interest paid by US obligors - general  - 02: Interest paid on real property mortgages  - 03: Interest paid to controlling foreign corporations  - 04: Interest paid by foreign corporations  - 05: Interest on tax-free covenant bonds  - 22: Interest paid on deposit with a foreign branch of a domestic corporation or partnership  - 29: Deposit interest  - 30: Original issue discount (OID)  - 31: Short-term OID  - 33: Substitute payment - interest  - 51: Interest paid on certain actively traded or publicly offered securities(1)  - 54: Substitute payments - interest from certain actively traded or publicly offered securities(1)    Dividend:  - 06: Dividends paid by U.S. corporations - general  - 07: Dividends qualifying for direct dividend rate  - 08: Dividends paid by foreign corporations  - 34: Substitute payment - dividends  - 40: Other dividend equivalents under IRC section 871(m) (formerly 871(l))  - 52: Dividends paid on certain actively traded or publicly offered securities(1)  - 53: Substitute payments - dividends from certain actively traded or publicly offered securities(1)  - 56: Dividend equivalents under IRC section 871(m) as a result of applying the combined transaction rules    Other:  - 09: Capital gains  - 10: Industrial royalties  - 11: Motion picture or television copyright royalties  - 12: Other royalties (for example, copyright, software, broadcasting, endorsement payments)  - 13: Royalties paid on certain publicly offered securities(1)  - 14: Real property income and natural resources royalties  - 15: Pensions, annuities, alimony, and/or insurance premiums  - 16: Scholarship or fellowship grants  - 17: Compensation for independent personal services(2)  - 18: Compensation for dependent personal services(2)  - 19: Compensation for teaching(2)  - 20: Compensation during studying and training(2)  - 23: Other income  - 24: Qualified investment entity (QIE) distributions of capital gains  - 25: Trust distributions subject to IRC section 1445  - 26: Unsevered growing crops and timber distributions by a trust subject to IRC section 1445  - 27: Publicly traded partnership distributions subject to IRC section 1446  - 28: Gambling winnings(3)  - 32: Notional principal contract income(4)  - 35: Substitute payment - other  - 36: Capital gains distributions  - 37: Return of capital  - 38: Eligible deferred compensation items subject to IRC section 877A(d)(1)  - 39: Distributions from a nongrantor trust subject to IRC section 877A(f)(1)  - 41: Guarantee of indebtedness  - 42: Earnings as an artist or athlete - no central withholding agreement(5)  - 43: Earnings as an artist or athlete - central withholding agreement(5)  - 44: Specified Federal procurement payments  - 50: Income previously reported under escrow procedure(6)  - 55: Taxable death benefits on life insurance contracts  - 57: Amount realized under IRC section 1446(f)  - 58: Publicly traded partnership distributions-undetermined
        /// </summary>
        /// <value>Income code.  Available values:    Interest:  - 01: Interest paid by US obligors - general  - 02: Interest paid on real property mortgages  - 03: Interest paid to controlling foreign corporations  - 04: Interest paid by foreign corporations  - 05: Interest on tax-free covenant bonds  - 22: Interest paid on deposit with a foreign branch of a domestic corporation or partnership  - 29: Deposit interest  - 30: Original issue discount (OID)  - 31: Short-term OID  - 33: Substitute payment - interest  - 51: Interest paid on certain actively traded or publicly offered securities(1)  - 54: Substitute payments - interest from certain actively traded or publicly offered securities(1)    Dividend:  - 06: Dividends paid by U.S. corporations - general  - 07: Dividends qualifying for direct dividend rate  - 08: Dividends paid by foreign corporations  - 34: Substitute payment - dividends  - 40: Other dividend equivalents under IRC section 871(m) (formerly 871(l))  - 52: Dividends paid on certain actively traded or publicly offered securities(1)  - 53: Substitute payments - dividends from certain actively traded or publicly offered securities(1)  - 56: Dividend equivalents under IRC section 871(m) as a result of applying the combined transaction rules    Other:  - 09: Capital gains  - 10: Industrial royalties  - 11: Motion picture or television copyright royalties  - 12: Other royalties (for example, copyright, software, broadcasting, endorsement payments)  - 13: Royalties paid on certain publicly offered securities(1)  - 14: Real property income and natural resources royalties  - 15: Pensions, annuities, alimony, and/or insurance premiums  - 16: Scholarship or fellowship grants  - 17: Compensation for independent personal services(2)  - 18: Compensation for dependent personal services(2)  - 19: Compensation for teaching(2)  - 20: Compensation during studying and training(2)  - 23: Other income  - 24: Qualified investment entity (QIE) distributions of capital gains  - 25: Trust distributions subject to IRC section 1445  - 26: Unsevered growing crops and timber distributions by a trust subject to IRC section 1445  - 27: Publicly traded partnership distributions subject to IRC section 1446  - 28: Gambling winnings(3)  - 32: Notional principal contract income(4)  - 35: Substitute payment - other  - 36: Capital gains distributions  - 37: Return of capital  - 38: Eligible deferred compensation items subject to IRC section 877A(d)(1)  - 39: Distributions from a nongrantor trust subject to IRC section 877A(f)(1)  - 41: Guarantee of indebtedness  - 42: Earnings as an artist or athlete - no central withholding agreement(5)  - 43: Earnings as an artist or athlete - central withholding agreement(5)  - 44: Specified Federal procurement payments  - 50: Income previously reported under escrow procedure(6)  - 55: Taxable death benefits on life insurance contracts  - 57: Amount realized under IRC section 1446(f)  - 58: Publicly traded partnership distributions-undetermined</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IncomeCodeEnum
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
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 6,

            /// <summary>
            /// Enum _29 for value: 29
            /// </summary>
            [EnumMember(Value = "29")]
            _29 = 7,

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30 = 8,

            /// <summary>
            /// Enum _31 for value: 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31 = 9,

            /// <summary>
            /// Enum _33 for value: 33
            /// </summary>
            [EnumMember(Value = "33")]
            _33 = 10,

            /// <summary>
            /// Enum _51 for value: 51
            /// </summary>
            [EnumMember(Value = "51")]
            _51 = 11,

            /// <summary>
            /// Enum _54 for value: 54
            /// </summary>
            [EnumMember(Value = "54")]
            _54 = 12,

            /// <summary>
            /// Enum _06 for value: 06
            /// </summary>
            [EnumMember(Value = "06")]
            _06 = 13,

            /// <summary>
            /// Enum _07 for value: 07
            /// </summary>
            [EnumMember(Value = "07")]
            _07 = 14,

            /// <summary>
            /// Enum _08 for value: 08
            /// </summary>
            [EnumMember(Value = "08")]
            _08 = 15,

            /// <summary>
            /// Enum _34 for value: 34
            /// </summary>
            [EnumMember(Value = "34")]
            _34 = 16,

            /// <summary>
            /// Enum _40 for value: 40
            /// </summary>
            [EnumMember(Value = "40")]
            _40 = 17,

            /// <summary>
            /// Enum _52 for value: 52
            /// </summary>
            [EnumMember(Value = "52")]
            _52 = 18,

            /// <summary>
            /// Enum _53 for value: 53
            /// </summary>
            [EnumMember(Value = "53")]
            _53 = 19,

            /// <summary>
            /// Enum _56 for value: 56
            /// </summary>
            [EnumMember(Value = "56")]
            _56 = 20,

            /// <summary>
            /// Enum _09 for value: 09
            /// </summary>
            [EnumMember(Value = "09")]
            _09 = 21,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 22,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 23,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 24,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 25,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 26,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 27,

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16 = 28,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 29,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 30,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 31,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 32,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 33,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 34,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 35,

            /// <summary>
            /// Enum _26 for value: 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26 = 36,

            /// <summary>
            /// Enum _27 for value: 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27 = 37,

            /// <summary>
            /// Enum _28 for value: 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28 = 38,

            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            [EnumMember(Value = "32")]
            _32 = 39,

            /// <summary>
            /// Enum _35 for value: 35
            /// </summary>
            [EnumMember(Value = "35")]
            _35 = 40,

            /// <summary>
            /// Enum _36 for value: 36
            /// </summary>
            [EnumMember(Value = "36")]
            _36 = 41,

            /// <summary>
            /// Enum _37 for value: 37
            /// </summary>
            [EnumMember(Value = "37")]
            _37 = 42,

            /// <summary>
            /// Enum _38 for value: 38
            /// </summary>
            [EnumMember(Value = "38")]
            _38 = 43,

            /// <summary>
            /// Enum _39 for value: 39
            /// </summary>
            [EnumMember(Value = "39")]
            _39 = 44,

            /// <summary>
            /// Enum _41 for value: 41
            /// </summary>
            [EnumMember(Value = "41")]
            _41 = 45,

            /// <summary>
            /// Enum _42 for value: 42
            /// </summary>
            [EnumMember(Value = "42")]
            _42 = 46,

            /// <summary>
            /// Enum _43 for value: 43
            /// </summary>
            [EnumMember(Value = "43")]
            _43 = 47,

            /// <summary>
            /// Enum _44 for value: 44
            /// </summary>
            [EnumMember(Value = "44")]
            _44 = 48,

            /// <summary>
            /// Enum _50 for value: 50
            /// </summary>
            [EnumMember(Value = "50")]
            _50 = 49,

            /// <summary>
            /// Enum _55 for value: 55
            /// </summary>
            [EnumMember(Value = "55")]
            _55 = 50,

            /// <summary>
            /// Enum _57 for value: 57
            /// </summary>
            [EnumMember(Value = "57")]
            _57 = 51,

            /// <summary>
            /// Enum _58 for value: 58
            /// </summary>
            [EnumMember(Value = "58")]
            _58 = 52
        }


        /// <summary>
        /// Income code.  Available values:    Interest:  - 01: Interest paid by US obligors - general  - 02: Interest paid on real property mortgages  - 03: Interest paid to controlling foreign corporations  - 04: Interest paid by foreign corporations  - 05: Interest on tax-free covenant bonds  - 22: Interest paid on deposit with a foreign branch of a domestic corporation or partnership  - 29: Deposit interest  - 30: Original issue discount (OID)  - 31: Short-term OID  - 33: Substitute payment - interest  - 51: Interest paid on certain actively traded or publicly offered securities(1)  - 54: Substitute payments - interest from certain actively traded or publicly offered securities(1)    Dividend:  - 06: Dividends paid by U.S. corporations - general  - 07: Dividends qualifying for direct dividend rate  - 08: Dividends paid by foreign corporations  - 34: Substitute payment - dividends  - 40: Other dividend equivalents under IRC section 871(m) (formerly 871(l))  - 52: Dividends paid on certain actively traded or publicly offered securities(1)  - 53: Substitute payments - dividends from certain actively traded or publicly offered securities(1)  - 56: Dividend equivalents under IRC section 871(m) as a result of applying the combined transaction rules    Other:  - 09: Capital gains  - 10: Industrial royalties  - 11: Motion picture or television copyright royalties  - 12: Other royalties (for example, copyright, software, broadcasting, endorsement payments)  - 13: Royalties paid on certain publicly offered securities(1)  - 14: Real property income and natural resources royalties  - 15: Pensions, annuities, alimony, and/or insurance premiums  - 16: Scholarship or fellowship grants  - 17: Compensation for independent personal services(2)  - 18: Compensation for dependent personal services(2)  - 19: Compensation for teaching(2)  - 20: Compensation during studying and training(2)  - 23: Other income  - 24: Qualified investment entity (QIE) distributions of capital gains  - 25: Trust distributions subject to IRC section 1445  - 26: Unsevered growing crops and timber distributions by a trust subject to IRC section 1445  - 27: Publicly traded partnership distributions subject to IRC section 1446  - 28: Gambling winnings(3)  - 32: Notional principal contract income(4)  - 35: Substitute payment - other  - 36: Capital gains distributions  - 37: Return of capital  - 38: Eligible deferred compensation items subject to IRC section 877A(d)(1)  - 39: Distributions from a nongrantor trust subject to IRC section 877A(f)(1)  - 41: Guarantee of indebtedness  - 42: Earnings as an artist or athlete - no central withholding agreement(5)  - 43: Earnings as an artist or athlete - central withholding agreement(5)  - 44: Specified Federal procurement payments  - 50: Income previously reported under escrow procedure(6)  - 55: Taxable death benefits on life insurance contracts  - 57: Amount realized under IRC section 1446(f)  - 58: Publicly traded partnership distributions-undetermined
        /// </summary>
        /// <value>Income code.  Available values:    Interest:  - 01: Interest paid by US obligors - general  - 02: Interest paid on real property mortgages  - 03: Interest paid to controlling foreign corporations  - 04: Interest paid by foreign corporations  - 05: Interest on tax-free covenant bonds  - 22: Interest paid on deposit with a foreign branch of a domestic corporation or partnership  - 29: Deposit interest  - 30: Original issue discount (OID)  - 31: Short-term OID  - 33: Substitute payment - interest  - 51: Interest paid on certain actively traded or publicly offered securities(1)  - 54: Substitute payments - interest from certain actively traded or publicly offered securities(1)    Dividend:  - 06: Dividends paid by U.S. corporations - general  - 07: Dividends qualifying for direct dividend rate  - 08: Dividends paid by foreign corporations  - 34: Substitute payment - dividends  - 40: Other dividend equivalents under IRC section 871(m) (formerly 871(l))  - 52: Dividends paid on certain actively traded or publicly offered securities(1)  - 53: Substitute payments - dividends from certain actively traded or publicly offered securities(1)  - 56: Dividend equivalents under IRC section 871(m) as a result of applying the combined transaction rules    Other:  - 09: Capital gains  - 10: Industrial royalties  - 11: Motion picture or television copyright royalties  - 12: Other royalties (for example, copyright, software, broadcasting, endorsement payments)  - 13: Royalties paid on certain publicly offered securities(1)  - 14: Real property income and natural resources royalties  - 15: Pensions, annuities, alimony, and/or insurance premiums  - 16: Scholarship or fellowship grants  - 17: Compensation for independent personal services(2)  - 18: Compensation for dependent personal services(2)  - 19: Compensation for teaching(2)  - 20: Compensation during studying and training(2)  - 23: Other income  - 24: Qualified investment entity (QIE) distributions of capital gains  - 25: Trust distributions subject to IRC section 1445  - 26: Unsevered growing crops and timber distributions by a trust subject to IRC section 1445  - 27: Publicly traded partnership distributions subject to IRC section 1446  - 28: Gambling winnings(3)  - 32: Notional principal contract income(4)  - 35: Substitute payment - other  - 36: Capital gains distributions  - 37: Return of capital  - 38: Eligible deferred compensation items subject to IRC section 877A(d)(1)  - 39: Distributions from a nongrantor trust subject to IRC section 877A(f)(1)  - 41: Guarantee of indebtedness  - 42: Earnings as an artist or athlete - no central withholding agreement(5)  - 43: Earnings as an artist or athlete - central withholding agreement(5)  - 44: Specified Federal procurement payments  - 50: Income previously reported under escrow procedure(6)  - 55: Taxable death benefits on life insurance contracts  - 57: Amount realized under IRC section 1446(f)  - 58: Publicly traded partnership distributions-undetermined</value>
        [DataMember(Name = "incomeCode", IsRequired = true, EmitDefaultValue = true)]
        public IncomeCodeEnum IncomeCode { get; set; }
        /// <summary>
        /// Withholding indicator  Available values:  - 3: Chapter 3  - 4: Chapter 4
        /// </summary>
        /// <value>Withholding indicator  Available values:  - 3: Chapter 3  - 4: Chapter 4</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WithholdingIndicatorEnum
        {
            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 1,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 2
        }


        /// <summary>
        /// Withholding indicator  Available values:  - 3: Chapter 3  - 4: Chapter 4
        /// </summary>
        /// <value>Withholding indicator  Available values:  - 3: Chapter 3  - 4: Chapter 4</value>
        [DataMember(Name = "withholdingIndicator", IsRequired = true, EmitDefaultValue = true)]
        public WithholdingIndicatorEnum WithholdingIndicator { get; set; }
        /// <summary>
        /// Exemption code (Chapter 3). Required if WithholdingIndicator is 3 (Chapter 3). Required when using TaxRateChap3.  Available values:  - Empty: Tax rate is due to backup withholding  - 00: Not exempt  - 01: Effectively connected income  - 02: Exempt under IRC (other than portfolio interest)  - 03: Income is not from US sources  - 04: Exempt under tax treaty  - 05: Portfolio interest exempt under IRC  - 06: QI that assumes primary withholding responsibility  - 07: WFP or WFT  - 08: U.S. branch treated as U.S. Person  - 09: Territory FI treated as U.S. Person  - 10: QI represents that income is exempt  - 11: QSL that assumes primary withholding responsibility  - 12: Payee subjected to chapter 4 withholding  - 22: QDD that assumes primary withholding responsibility  - 23: Exempt under section 897(l)  - 24: Exempt under section 892
        /// </summary>
        /// <value>Exemption code (Chapter 3). Required if WithholdingIndicator is 3 (Chapter 3). Required when using TaxRateChap3.  Available values:  - Empty: Tax rate is due to backup withholding  - 00: Not exempt  - 01: Effectively connected income  - 02: Exempt under IRC (other than portfolio interest)  - 03: Income is not from US sources  - 04: Exempt under tax treaty  - 05: Portfolio interest exempt under IRC  - 06: QI that assumes primary withholding responsibility  - 07: WFP or WFT  - 08: U.S. branch treated as U.S. Person  - 09: Territory FI treated as U.S. Person  - 10: QI represents that income is exempt  - 11: QSL that assumes primary withholding responsibility  - 12: Payee subjected to chapter 4 withholding  - 22: QDD that assumes primary withholding responsibility  - 23: Exempt under section 897(l)  - 24: Exempt under section 892</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExemptionCodeChap3Enum
        {
            /// <summary>
            /// Enum _00 for value: 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00 = 1,

            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 2,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 3,

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
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 14,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 15,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 16
        }


        /// <summary>
        /// Exemption code (Chapter 3). Required if WithholdingIndicator is 3 (Chapter 3). Required when using TaxRateChap3.  Available values:  - Empty: Tax rate is due to backup withholding  - 00: Not exempt  - 01: Effectively connected income  - 02: Exempt under IRC (other than portfolio interest)  - 03: Income is not from US sources  - 04: Exempt under tax treaty  - 05: Portfolio interest exempt under IRC  - 06: QI that assumes primary withholding responsibility  - 07: WFP or WFT  - 08: U.S. branch treated as U.S. Person  - 09: Territory FI treated as U.S. Person  - 10: QI represents that income is exempt  - 11: QSL that assumes primary withholding responsibility  - 12: Payee subjected to chapter 4 withholding  - 22: QDD that assumes primary withholding responsibility  - 23: Exempt under section 897(l)  - 24: Exempt under section 892
        /// </summary>
        /// <value>Exemption code (Chapter 3). Required if WithholdingIndicator is 3 (Chapter 3). Required when using TaxRateChap3.  Available values:  - Empty: Tax rate is due to backup withholding  - 00: Not exempt  - 01: Effectively connected income  - 02: Exempt under IRC (other than portfolio interest)  - 03: Income is not from US sources  - 04: Exempt under tax treaty  - 05: Portfolio interest exempt under IRC  - 06: QI that assumes primary withholding responsibility  - 07: WFP or WFT  - 08: U.S. branch treated as U.S. Person  - 09: Territory FI treated as U.S. Person  - 10: QI represents that income is exempt  - 11: QSL that assumes primary withholding responsibility  - 12: Payee subjected to chapter 4 withholding  - 22: QDD that assumes primary withholding responsibility  - 23: Exempt under section 897(l)  - 24: Exempt under section 892</value>
        [DataMember(Name = "exemptionCodeChap3", EmitDefaultValue = true)]
        public ExemptionCodeChap3Enum? ExemptionCodeChap3 { get; set; }
        /// <summary>
        /// Exemption code (Chapter 4). Required if WithholdingIndicator is 4 (Chapter 4).  Available values:  - 00: Not exempt  - 13: Grandfathered payment  - 14: Effectively connected income  - 15: Payee not subject to chapter 4 withholding  - 16: Excluded nonfinancial payment  - 17: Foreign Entity that assumes primary withholding responsibility  - 18: U.S. Payees - of participating FFI or registered deemed - compliant FFI  - 19: Exempt from withholding under IGA(6)  - 20: Dormant account(7)  - 21: Other - payment not subject to chapter 4 withholding
        /// </summary>
        /// <value>Exemption code (Chapter 4). Required if WithholdingIndicator is 4 (Chapter 4).  Available values:  - 00: Not exempt  - 13: Grandfathered payment  - 14: Effectively connected income  - 15: Payee not subject to chapter 4 withholding  - 16: Excluded nonfinancial payment  - 17: Foreign Entity that assumes primary withholding responsibility  - 18: U.S. Payees - of participating FFI or registered deemed - compliant FFI  - 19: Exempt from withholding under IGA(6)  - 20: Dormant account(7)  - 21: Other - payment not subject to chapter 4 withholding</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExemptionCodeChap4Enum
        {
            /// <summary>
            /// Enum _00 for value: 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00 = 1,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 2,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 3,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 4,

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16 = 5,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 6,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 7,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 8,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 9,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 10
        }


        /// <summary>
        /// Exemption code (Chapter 4). Required if WithholdingIndicator is 4 (Chapter 4).  Available values:  - 00: Not exempt  - 13: Grandfathered payment  - 14: Effectively connected income  - 15: Payee not subject to chapter 4 withholding  - 16: Excluded nonfinancial payment  - 17: Foreign Entity that assumes primary withholding responsibility  - 18: U.S. Payees - of participating FFI or registered deemed - compliant FFI  - 19: Exempt from withholding under IGA(6)  - 20: Dormant account(7)  - 21: Other - payment not subject to chapter 4 withholding
        /// </summary>
        /// <value>Exemption code (Chapter 4). Required if WithholdingIndicator is 4 (Chapter 4).  Available values:  - 00: Not exempt  - 13: Grandfathered payment  - 14: Effectively connected income  - 15: Payee not subject to chapter 4 withholding  - 16: Excluded nonfinancial payment  - 17: Foreign Entity that assumes primary withholding responsibility  - 18: U.S. Payees - of participating FFI or registered deemed - compliant FFI  - 19: Exempt from withholding under IGA(6)  - 20: Dormant account(7)  - 21: Other - payment not subject to chapter 4 withholding</value>
        [DataMember(Name = "exemptionCodeChap4", EmitDefaultValue = true)]
        public ExemptionCodeChap4Enum? ExemptionCodeChap4 { get; set; }
        /// <summary>
        /// Tax rate (Chapter 3) - Required if WithholdingIndicator is 3 (Chapter 3).  Available values:  - 00.00: 0.00%  - 02.00: 2.00%  - 04.00: 4.00%  - 04.90: 4.90%  - 04.95: 4.95%  - 05.00: 5.00%  - 07.00: 7.00%  - 08.00: 8.00%  - 10.00: 10.00%  - 12.00: 12.00%  - 12.50: 12.50%  - 14.00: 14.00%  - 15.00: 15.00%  - 17.50: 17.50%  - 20.00: 20.00%  - 21.00: 21.00%  - 24.00: 24.00%  - 25.00: 25.00%  - 27.50: 27.50%  - 28.00: 28.00%  - 30.00: 30.00%  - 37.00: 37.00%
        /// </summary>
        /// <value>Tax rate (Chapter 3) - Required if WithholdingIndicator is 3 (Chapter 3).  Available values:  - 00.00: 0.00%  - 02.00: 2.00%  - 04.00: 4.00%  - 04.90: 4.90%  - 04.95: 4.95%  - 05.00: 5.00%  - 07.00: 7.00%  - 08.00: 8.00%  - 10.00: 10.00%  - 12.00: 12.00%  - 12.50: 12.50%  - 14.00: 14.00%  - 15.00: 15.00%  - 17.50: 17.50%  - 20.00: 20.00%  - 21.00: 21.00%  - 24.00: 24.00%  - 25.00: 25.00%  - 27.50: 27.50%  - 28.00: 28.00%  - 30.00: 30.00%  - 37.00: 37.00%</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxRateChap3Enum
        {
            /// <summary>
            /// Enum _0000 for value: 00.00
            /// </summary>
            [EnumMember(Value = "00.00")]
            _0000 = 1,

            /// <summary>
            /// Enum _0200 for value: 02.00
            /// </summary>
            [EnumMember(Value = "02.00")]
            _0200 = 2,

            /// <summary>
            /// Enum _0400 for value: 04.00
            /// </summary>
            [EnumMember(Value = "04.00")]
            _0400 = 3,

            /// <summary>
            /// Enum _0490 for value: 04.90
            /// </summary>
            [EnumMember(Value = "04.90")]
            _0490 = 4,

            /// <summary>
            /// Enum _0495 for value: 04.95
            /// </summary>
            [EnumMember(Value = "04.95")]
            _0495 = 5,

            /// <summary>
            /// Enum _0500 for value: 05.00
            /// </summary>
            [EnumMember(Value = "05.00")]
            _0500 = 6,

            /// <summary>
            /// Enum _0700 for value: 07.00
            /// </summary>
            [EnumMember(Value = "07.00")]
            _0700 = 7,

            /// <summary>
            /// Enum _0800 for value: 08.00
            /// </summary>
            [EnumMember(Value = "08.00")]
            _0800 = 8,

            /// <summary>
            /// Enum _1000 for value: 10.00
            /// </summary>
            [EnumMember(Value = "10.00")]
            _1000 = 9,

            /// <summary>
            /// Enum _1200 for value: 12.00
            /// </summary>
            [EnumMember(Value = "12.00")]
            _1200 = 10,

            /// <summary>
            /// Enum _1250 for value: 12.50
            /// </summary>
            [EnumMember(Value = "12.50")]
            _1250 = 11,

            /// <summary>
            /// Enum _1400 for value: 14.00
            /// </summary>
            [EnumMember(Value = "14.00")]
            _1400 = 12,

            /// <summary>
            /// Enum _1500 for value: 15.00
            /// </summary>
            [EnumMember(Value = "15.00")]
            _1500 = 13,

            /// <summary>
            /// Enum _1750 for value: 17.50
            /// </summary>
            [EnumMember(Value = "17.50")]
            _1750 = 14,

            /// <summary>
            /// Enum _2000 for value: 20.00
            /// </summary>
            [EnumMember(Value = "20.00")]
            _2000 = 15,

            /// <summary>
            /// Enum _2100 for value: 21.00
            /// </summary>
            [EnumMember(Value = "21.00")]
            _2100 = 16,

            /// <summary>
            /// Enum _2400 for value: 24.00
            /// </summary>
            [EnumMember(Value = "24.00")]
            _2400 = 17,

            /// <summary>
            /// Enum _2500 for value: 25.00
            /// </summary>
            [EnumMember(Value = "25.00")]
            _2500 = 18,

            /// <summary>
            /// Enum _2750 for value: 27.50
            /// </summary>
            [EnumMember(Value = "27.50")]
            _2750 = 19,

            /// <summary>
            /// Enum _2800 for value: 28.00
            /// </summary>
            [EnumMember(Value = "28.00")]
            _2800 = 20,

            /// <summary>
            /// Enum _3000 for value: 30.00
            /// </summary>
            [EnumMember(Value = "30.00")]
            _3000 = 21,

            /// <summary>
            /// Enum _3700 for value: 37.00
            /// </summary>
            [EnumMember(Value = "37.00")]
            _3700 = 22
        }


        /// <summary>
        /// Tax rate (Chapter 3) - Required if WithholdingIndicator is 3 (Chapter 3).  Available values:  - 00.00: 0.00%  - 02.00: 2.00%  - 04.00: 4.00%  - 04.90: 4.90%  - 04.95: 4.95%  - 05.00: 5.00%  - 07.00: 7.00%  - 08.00: 8.00%  - 10.00: 10.00%  - 12.00: 12.00%  - 12.50: 12.50%  - 14.00: 14.00%  - 15.00: 15.00%  - 17.50: 17.50%  - 20.00: 20.00%  - 21.00: 21.00%  - 24.00: 24.00%  - 25.00: 25.00%  - 27.50: 27.50%  - 28.00: 28.00%  - 30.00: 30.00%  - 37.00: 37.00%
        /// </summary>
        /// <value>Tax rate (Chapter 3) - Required if WithholdingIndicator is 3 (Chapter 3).  Available values:  - 00.00: 0.00%  - 02.00: 2.00%  - 04.00: 4.00%  - 04.90: 4.90%  - 04.95: 4.95%  - 05.00: 5.00%  - 07.00: 7.00%  - 08.00: 8.00%  - 10.00: 10.00%  - 12.00: 12.00%  - 12.50: 12.50%  - 14.00: 14.00%  - 15.00: 15.00%  - 17.50: 17.50%  - 20.00: 20.00%  - 21.00: 21.00%  - 24.00: 24.00%  - 25.00: 25.00%  - 27.50: 27.50%  - 28.00: 28.00%  - 30.00: 30.00%  - 37.00: 37.00%</value>
        [DataMember(Name = "taxRateChap3", EmitDefaultValue = true)]
        public TaxRateChap3Enum? TaxRateChap3 { get; set; }
        /// <summary>
        /// Chapter 3 status code - Required if WithholdingIndicator is 3 (Chapter 3)  Available values:  - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020)  - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020)  - 03: Territory FI - treated as U.S. Person  - 04: Territory FI - not treated as U.S. Person  - 05: U.S. branch - treated as U.S. Person  - 06: U.S. branch - not treated as U.S. Person  - 07: U.S. branch - ECI presumption applied  - 08: Partnership other than Withholding Foreign Partnership  - 09: Withholding Foreign Partnership  - 10: Trust other than Withholding Foreign Trust  - 11: Withholding Foreign Trust  - 12: Qualified Intermediary  - 13: Qualified Securities Lender - Qualified Intermediary  - 14: Qualified Securities Lender - Other  - 15: Corporation  - 16: Individual  - 17: Estate  - 18: Private Foundation  - 19: Government or International Organization  - 20: Tax Exempt Organization (Section 501(c) entities)  - 21: Unknown Recipient  - 22: Artist or Athlete  - 23: Pension  - 24: Foreign Central Bank of Issue  - 25: Nonqualified Intermediary  - 26: Hybrid entity making Treaty Claim  - 27: Withholding Rate Pool - General  - 28: Withholding Rate Pool - Exempt Organization  - 29: PAI Withholding Rate Pool - General  - 30: PAI Withholding Rate Pool - Exempt Organization  - 31: Agency Withholding Rate Pool - General  - 32: Agency Withholding Rate Pool - Exempt Organization  - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020)  - 35: Qualified Derivatives Dealer  - 36: Foreign Government - Integral Part  - 37: Foreign Government - Controlled Entity  - 38: Publicly Traded Partnership  - 39: Disclosing Qualified Intermediary
        /// </summary>
        /// <value>Chapter 3 status code - Required if WithholdingIndicator is 3 (Chapter 3)  Available values:  - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020)  - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020)  - 03: Territory FI - treated as U.S. Person  - 04: Territory FI - not treated as U.S. Person  - 05: U.S. branch - treated as U.S. Person  - 06: U.S. branch - not treated as U.S. Person  - 07: U.S. branch - ECI presumption applied  - 08: Partnership other than Withholding Foreign Partnership  - 09: Withholding Foreign Partnership  - 10: Trust other than Withholding Foreign Trust  - 11: Withholding Foreign Trust  - 12: Qualified Intermediary  - 13: Qualified Securities Lender - Qualified Intermediary  - 14: Qualified Securities Lender - Other  - 15: Corporation  - 16: Individual  - 17: Estate  - 18: Private Foundation  - 19: Government or International Organization  - 20: Tax Exempt Organization (Section 501(c) entities)  - 21: Unknown Recipient  - 22: Artist or Athlete  - 23: Pension  - 24: Foreign Central Bank of Issue  - 25: Nonqualified Intermediary  - 26: Hybrid entity making Treaty Claim  - 27: Withholding Rate Pool - General  - 28: Withholding Rate Pool - Exempt Organization  - 29: PAI Withholding Rate Pool - General  - 30: PAI Withholding Rate Pool - Exempt Organization  - 31: Agency Withholding Rate Pool - General  - 32: Agency Withholding Rate Pool - Exempt Organization  - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020)  - 35: Qualified Derivatives Dealer  - 36: Foreign Government - Integral Part  - 37: Foreign Government - Controlled Entity  - 38: Publicly Traded Partnership  - 39: Disclosing Qualified Intermediary</value>
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
        /// Chapter 3 status code - Required if WithholdingIndicator is 3 (Chapter 3)  Available values:  - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020)  - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020)  - 03: Territory FI - treated as U.S. Person  - 04: Territory FI - not treated as U.S. Person  - 05: U.S. branch - treated as U.S. Person  - 06: U.S. branch - not treated as U.S. Person  - 07: U.S. branch - ECI presumption applied  - 08: Partnership other than Withholding Foreign Partnership  - 09: Withholding Foreign Partnership  - 10: Trust other than Withholding Foreign Trust  - 11: Withholding Foreign Trust  - 12: Qualified Intermediary  - 13: Qualified Securities Lender - Qualified Intermediary  - 14: Qualified Securities Lender - Other  - 15: Corporation  - 16: Individual  - 17: Estate  - 18: Private Foundation  - 19: Government or International Organization  - 20: Tax Exempt Organization (Section 501(c) entities)  - 21: Unknown Recipient  - 22: Artist or Athlete  - 23: Pension  - 24: Foreign Central Bank of Issue  - 25: Nonqualified Intermediary  - 26: Hybrid entity making Treaty Claim  - 27: Withholding Rate Pool - General  - 28: Withholding Rate Pool - Exempt Organization  - 29: PAI Withholding Rate Pool - General  - 30: PAI Withholding Rate Pool - Exempt Organization  - 31: Agency Withholding Rate Pool - General  - 32: Agency Withholding Rate Pool - Exempt Organization  - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020)  - 35: Qualified Derivatives Dealer  - 36: Foreign Government - Integral Part  - 37: Foreign Government - Controlled Entity  - 38: Publicly Traded Partnership  - 39: Disclosing Qualified Intermediary
        /// </summary>
        /// <value>Chapter 3 status code - Required if WithholdingIndicator is 3 (Chapter 3)  Available values:  - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020)  - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020)  - 03: Territory FI - treated as U.S. Person  - 04: Territory FI - not treated as U.S. Person  - 05: U.S. branch - treated as U.S. Person  - 06: U.S. branch - not treated as U.S. Person  - 07: U.S. branch - ECI presumption applied  - 08: Partnership other than Withholding Foreign Partnership  - 09: Withholding Foreign Partnership  - 10: Trust other than Withholding Foreign Trust  - 11: Withholding Foreign Trust  - 12: Qualified Intermediary  - 13: Qualified Securities Lender - Qualified Intermediary  - 14: Qualified Securities Lender - Other  - 15: Corporation  - 16: Individual  - 17: Estate  - 18: Private Foundation  - 19: Government or International Organization  - 20: Tax Exempt Organization (Section 501(c) entities)  - 21: Unknown Recipient  - 22: Artist or Athlete  - 23: Pension  - 24: Foreign Central Bank of Issue  - 25: Nonqualified Intermediary  - 26: Hybrid entity making Treaty Claim  - 27: Withholding Rate Pool - General  - 28: Withholding Rate Pool - Exempt Organization  - 29: PAI Withholding Rate Pool - General  - 30: PAI Withholding Rate Pool - Exempt Organization  - 31: Agency Withholding Rate Pool - General  - 32: Agency Withholding Rate Pool - Exempt Organization  - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020)  - 35: Qualified Derivatives Dealer  - 36: Foreign Government - Integral Part  - 37: Foreign Government - Controlled Entity  - 38: Publicly Traded Partnership  - 39: Disclosing Qualified Intermediary</value>
        [DataMember(Name = "chap3StatusCode", EmitDefaultValue = true)]
        public Chap3StatusCodeEnum? Chap3StatusCode { get; set; }
        /// <summary>
        /// Chapter 4 status code. Required if WithholdingIndicator is 4 (Chapter 4). Required if email is specified, must fill either this or RecipientForeignTin.  Available values:  - 01: U.S. Withholding Agent - FI  - 02: U.S. Withholding Agent - Other  - 03: Territory FI - not treated as U.S. Person  - 04: Territory FI - treated as U.S. Person  - 05: Participating FFI - Other  - 06: Participating FFI - Reporting Model 2 FFI  - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI  - 08: Registered Deemed - Compliant FFI-Sponsored Entity  - 09: Registered Deemed - Compliant FFI-Other  - 10: Certified Deemed - Compliant FFI-Other  - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts  - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank  - 13: Certified Deemed - Compliant FFI-Sponsored Entity  - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager  - 15: Nonparticipating FFI  - 16: Owner-Documented FFI  - 17: U.S. Branch - treated as U.S. person  - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471)  - 19: Passive NFFE identifying Substantial U.S. Owners  - 20: Passive NFFE with no Substantial U.S. Owners  - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE  - 22: Active NFFE  - 23: Individual  - 24: Section 501(c) Entities  - 25: Excepted Territory NFFE  - 26: Excepted NFFE - Other  - 27: Exempt Beneficial Owner  - 28: Entity Wholly Owned by Exempt Beneficial Owners  - 29: Unknown Recipient  - 30: Recalcitrant Account Holder  - 31: Nonreporting IGA FFI  - 32: Direct reporting NFFE  - 33: U.S. reportable account  - 34: Non-consenting U.S. account  - 35: Sponsored direct reporting NFFE  - 36: Excepted Inter-affiliate FFI  - 37: Undocumented Preexisting Obligation  - 38: U.S. Branch - ECI presumption applied  - 39: Account Holder of Excluded Financial Account  - 40: Passive NFFE reported by FFI  - 41: NFFE subject to 1472 withholding  - 42: Recalcitrant Pool - No U.S. Indicia  - 43: Recalcitrant Pool - U.S. Indicia  - 44: Recalcitrant Pool - Dormant Account  - 45: Recalcitrant Pool - U.S. Persons  - 46: Recalcitrant Pool - Passive NFFEs  - 47: Nonparticipating FFI Pool  - 48: U.S. Payees Pool  - 49: QI - Recalcitrant Pool-General  - 50: U.S. Withholding Agent-Foreign branch of FI
        /// </summary>
        /// <value>Chapter 4 status code. Required if WithholdingIndicator is 4 (Chapter 4). Required if email is specified, must fill either this or RecipientForeignTin.  Available values:  - 01: U.S. Withholding Agent - FI  - 02: U.S. Withholding Agent - Other  - 03: Territory FI - not treated as U.S. Person  - 04: Territory FI - treated as U.S. Person  - 05: Participating FFI - Other  - 06: Participating FFI - Reporting Model 2 FFI  - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI  - 08: Registered Deemed - Compliant FFI-Sponsored Entity  - 09: Registered Deemed - Compliant FFI-Other  - 10: Certified Deemed - Compliant FFI-Other  - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts  - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank  - 13: Certified Deemed - Compliant FFI-Sponsored Entity  - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager  - 15: Nonparticipating FFI  - 16: Owner-Documented FFI  - 17: U.S. Branch - treated as U.S. person  - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471)  - 19: Passive NFFE identifying Substantial U.S. Owners  - 20: Passive NFFE with no Substantial U.S. Owners  - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE  - 22: Active NFFE  - 23: Individual  - 24: Section 501(c) Entities  - 25: Excepted Territory NFFE  - 26: Excepted NFFE - Other  - 27: Exempt Beneficial Owner  - 28: Entity Wholly Owned by Exempt Beneficial Owners  - 29: Unknown Recipient  - 30: Recalcitrant Account Holder  - 31: Nonreporting IGA FFI  - 32: Direct reporting NFFE  - 33: U.S. reportable account  - 34: Non-consenting U.S. account  - 35: Sponsored direct reporting NFFE  - 36: Excepted Inter-affiliate FFI  - 37: Undocumented Preexisting Obligation  - 38: U.S. Branch - ECI presumption applied  - 39: Account Holder of Excluded Financial Account  - 40: Passive NFFE reported by FFI  - 41: NFFE subject to 1472 withholding  - 42: Recalcitrant Pool - No U.S. Indicia  - 43: Recalcitrant Pool - U.S. Indicia  - 44: Recalcitrant Pool - Dormant Account  - 45: Recalcitrant Pool - U.S. Persons  - 46: Recalcitrant Pool - Passive NFFEs  - 47: Nonparticipating FFI Pool  - 48: U.S. Payees Pool  - 49: QI - Recalcitrant Pool-General  - 50: U.S. Withholding Agent-Foreign branch of FI</value>
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
        /// Chapter 4 status code. Required if WithholdingIndicator is 4 (Chapter 4). Required if email is specified, must fill either this or RecipientForeignTin.  Available values:  - 01: U.S. Withholding Agent - FI  - 02: U.S. Withholding Agent - Other  - 03: Territory FI - not treated as U.S. Person  - 04: Territory FI - treated as U.S. Person  - 05: Participating FFI - Other  - 06: Participating FFI - Reporting Model 2 FFI  - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI  - 08: Registered Deemed - Compliant FFI-Sponsored Entity  - 09: Registered Deemed - Compliant FFI-Other  - 10: Certified Deemed - Compliant FFI-Other  - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts  - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank  - 13: Certified Deemed - Compliant FFI-Sponsored Entity  - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager  - 15: Nonparticipating FFI  - 16: Owner-Documented FFI  - 17: U.S. Branch - treated as U.S. person  - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471)  - 19: Passive NFFE identifying Substantial U.S. Owners  - 20: Passive NFFE with no Substantial U.S. Owners  - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE  - 22: Active NFFE  - 23: Individual  - 24: Section 501(c) Entities  - 25: Excepted Territory NFFE  - 26: Excepted NFFE - Other  - 27: Exempt Beneficial Owner  - 28: Entity Wholly Owned by Exempt Beneficial Owners  - 29: Unknown Recipient  - 30: Recalcitrant Account Holder  - 31: Nonreporting IGA FFI  - 32: Direct reporting NFFE  - 33: U.S. reportable account  - 34: Non-consenting U.S. account  - 35: Sponsored direct reporting NFFE  - 36: Excepted Inter-affiliate FFI  - 37: Undocumented Preexisting Obligation  - 38: U.S. Branch - ECI presumption applied  - 39: Account Holder of Excluded Financial Account  - 40: Passive NFFE reported by FFI  - 41: NFFE subject to 1472 withholding  - 42: Recalcitrant Pool - No U.S. Indicia  - 43: Recalcitrant Pool - U.S. Indicia  - 44: Recalcitrant Pool - Dormant Account  - 45: Recalcitrant Pool - U.S. Persons  - 46: Recalcitrant Pool - Passive NFFEs  - 47: Nonparticipating FFI Pool  - 48: U.S. Payees Pool  - 49: QI - Recalcitrant Pool-General  - 50: U.S. Withholding Agent-Foreign branch of FI
        /// </summary>
        /// <value>Chapter 4 status code. Required if WithholdingIndicator is 4 (Chapter 4). Required if email is specified, must fill either this or RecipientForeignTin.  Available values:  - 01: U.S. Withholding Agent - FI  - 02: U.S. Withholding Agent - Other  - 03: Territory FI - not treated as U.S. Person  - 04: Territory FI - treated as U.S. Person  - 05: Participating FFI - Other  - 06: Participating FFI - Reporting Model 2 FFI  - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI  - 08: Registered Deemed - Compliant FFI-Sponsored Entity  - 09: Registered Deemed - Compliant FFI-Other  - 10: Certified Deemed - Compliant FFI-Other  - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts  - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank  - 13: Certified Deemed - Compliant FFI-Sponsored Entity  - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager  - 15: Nonparticipating FFI  - 16: Owner-Documented FFI  - 17: U.S. Branch - treated as U.S. person  - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471)  - 19: Passive NFFE identifying Substantial U.S. Owners  - 20: Passive NFFE with no Substantial U.S. Owners  - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE  - 22: Active NFFE  - 23: Individual  - 24: Section 501(c) Entities  - 25: Excepted Territory NFFE  - 26: Excepted NFFE - Other  - 27: Exempt Beneficial Owner  - 28: Entity Wholly Owned by Exempt Beneficial Owners  - 29: Unknown Recipient  - 30: Recalcitrant Account Holder  - 31: Nonreporting IGA FFI  - 32: Direct reporting NFFE  - 33: U.S. reportable account  - 34: Non-consenting U.S. account  - 35: Sponsored direct reporting NFFE  - 36: Excepted Inter-affiliate FFI  - 37: Undocumented Preexisting Obligation  - 38: U.S. Branch - ECI presumption applied  - 39: Account Holder of Excluded Financial Account  - 40: Passive NFFE reported by FFI  - 41: NFFE subject to 1472 withholding  - 42: Recalcitrant Pool - No U.S. Indicia  - 43: Recalcitrant Pool - U.S. Indicia  - 44: Recalcitrant Pool - Dormant Account  - 45: Recalcitrant Pool - U.S. Persons  - 46: Recalcitrant Pool - Passive NFFEs  - 47: Nonparticipating FFI Pool  - 48: U.S. Payees Pool  - 49: QI - Recalcitrant Pool-General  - 50: U.S. Withholding Agent-Foreign branch of FI</value>
        [DataMember(Name = "chap4StatusCode", EmitDefaultValue = true)]
        public Chap4StatusCodeEnum? Chap4StatusCode { get; set; }
        /// <summary>
        /// Form type
        /// </summary>
        /// <value>Form type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum _1099NEC for value: 1099-NEC
            /// </summary>
            [EnumMember(Value = "1099-NEC")]
            _1099NEC = 1,

            /// <summary>
            /// Enum _1099MISC for value: 1099-MISC
            /// </summary>
            [EnumMember(Value = "1099-MISC")]
            _1099MISC = 2,

            /// <summary>
            /// Enum _1099DIV for value: 1099-DIV
            /// </summary>
            [EnumMember(Value = "1099-DIV")]
            _1099DIV = 3,

            /// <summary>
            /// Enum _1099R for value: 1099-R
            /// </summary>
            [EnumMember(Value = "1099-R")]
            _1099R = 4,

            /// <summary>
            /// Enum _1099K for value: 1099-K
            /// </summary>
            [EnumMember(Value = "1099-K")]
            _1099K = 5,

            /// <summary>
            /// Enum _1095B for value: 1095-B
            /// </summary>
            [EnumMember(Value = "1095-B")]
            _1095B = 6,

            /// <summary>
            /// Enum _1042S for value: 1042-S
            /// </summary>
            [EnumMember(Value = "1042-S")]
            _1042S = 7,

            /// <summary>
            /// Enum _1095C for value: 1095-C
            /// </summary>
            [EnumMember(Value = "1095-C")]
            _1095C = 8,

            /// <summary>
            /// Enum _1099INT for value: 1099-INT
            /// </summary>
            [EnumMember(Value = "1099-INT")]
            _1099INT = 9
        }


        /// <summary>
        /// Form type
        /// </summary>
        /// <value>Form type</value>
        /// <example>1099-NEC</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1042S" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1042S() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1042S" /> class.
        /// </summary>
        /// <param name="uniqueFormId">Unique form identifier (required).</param>
        /// <param name="recipientDateOfBirth">Recipient&#39;s date of birth.</param>
        /// <param name="recipientGiin">Recipient&#39;s Global Intermediary Identification Number (GIIN). A valid GIIN looks like &#39;XXXXXX.XXXXX.XX.XXX&#39;..</param>
        /// <param name="recipientForeignTin">Recipient&#39;s foreign TIN. Required if email is specified, must fill either this or Chap3StatusCode..</param>
        /// <param name="lobCode">Limitation on Benefits (LOB) code for tax treaty purposes.  Available values:  - 01: Individual (Deprecated - valid only for tax years prior to 2019)  - 02: Government - contracting state/political subdivision/local authority  - 03: Tax exempt pension trust/Pension fund  - 04: Tax exempt/Charitable organization  - 05: Publicly-traded corporation  - 06: Subsidiary of publicly-traded corporation  - 07: Company that meets the ownership and base erosion test  - 08: Company that meets the derivative benefits test  - 09: Company with an item of income that meets the active trade or business test  - 10: Discretionary determination  - 11: Other  - 12: No LOB article in treaty.</param>
        /// <param name="incomeCode">Income code.  Available values:    Interest:  - 01: Interest paid by US obligors - general  - 02: Interest paid on real property mortgages  - 03: Interest paid to controlling foreign corporations  - 04: Interest paid by foreign corporations  - 05: Interest on tax-free covenant bonds  - 22: Interest paid on deposit with a foreign branch of a domestic corporation or partnership  - 29: Deposit interest  - 30: Original issue discount (OID)  - 31: Short-term OID  - 33: Substitute payment - interest  - 51: Interest paid on certain actively traded or publicly offered securities(1)  - 54: Substitute payments - interest from certain actively traded or publicly offered securities(1)    Dividend:  - 06: Dividends paid by U.S. corporations - general  - 07: Dividends qualifying for direct dividend rate  - 08: Dividends paid by foreign corporations  - 34: Substitute payment - dividends  - 40: Other dividend equivalents under IRC section 871(m) (formerly 871(l))  - 52: Dividends paid on certain actively traded or publicly offered securities(1)  - 53: Substitute payments - dividends from certain actively traded or publicly offered securities(1)  - 56: Dividend equivalents under IRC section 871(m) as a result of applying the combined transaction rules    Other:  - 09: Capital gains  - 10: Industrial royalties  - 11: Motion picture or television copyright royalties  - 12: Other royalties (for example, copyright, software, broadcasting, endorsement payments)  - 13: Royalties paid on certain publicly offered securities(1)  - 14: Real property income and natural resources royalties  - 15: Pensions, annuities, alimony, and/or insurance premiums  - 16: Scholarship or fellowship grants  - 17: Compensation for independent personal services(2)  - 18: Compensation for dependent personal services(2)  - 19: Compensation for teaching(2)  - 20: Compensation during studying and training(2)  - 23: Other income  - 24: Qualified investment entity (QIE) distributions of capital gains  - 25: Trust distributions subject to IRC section 1445  - 26: Unsevered growing crops and timber distributions by a trust subject to IRC section 1445  - 27: Publicly traded partnership distributions subject to IRC section 1446  - 28: Gambling winnings(3)  - 32: Notional principal contract income(4)  - 35: Substitute payment - other  - 36: Capital gains distributions  - 37: Return of capital  - 38: Eligible deferred compensation items subject to IRC section 877A(d)(1)  - 39: Distributions from a nongrantor trust subject to IRC section 877A(f)(1)  - 41: Guarantee of indebtedness  - 42: Earnings as an artist or athlete - no central withholding agreement(5)  - 43: Earnings as an artist or athlete - central withholding agreement(5)  - 44: Specified Federal procurement payments  - 50: Income previously reported under escrow procedure(6)  - 55: Taxable death benefits on life insurance contracts  - 57: Amount realized under IRC section 1446(f)  - 58: Publicly traded partnership distributions-undetermined (required).</param>
        /// <param name="grossIncome">Gross income (required).</param>
        /// <param name="withholdingIndicator">Withholding indicator  Available values:  - 3: Chapter 3  - 4: Chapter 4 (required).</param>
        /// <param name="taxCountryCode">Country code (required).</param>
        /// <param name="exemptionCodeChap3">Exemption code (Chapter 3). Required if WithholdingIndicator is 3 (Chapter 3). Required when using TaxRateChap3.  Available values:  - Empty: Tax rate is due to backup withholding  - 00: Not exempt  - 01: Effectively connected income  - 02: Exempt under IRC (other than portfolio interest)  - 03: Income is not from US sources  - 04: Exempt under tax treaty  - 05: Portfolio interest exempt under IRC  - 06: QI that assumes primary withholding responsibility  - 07: WFP or WFT  - 08: U.S. branch treated as U.S. Person  - 09: Territory FI treated as U.S. Person  - 10: QI represents that income is exempt  - 11: QSL that assumes primary withholding responsibility  - 12: Payee subjected to chapter 4 withholding  - 22: QDD that assumes primary withholding responsibility  - 23: Exempt under section 897(l)  - 24: Exempt under section 892.</param>
        /// <param name="exemptionCodeChap4">Exemption code (Chapter 4). Required if WithholdingIndicator is 4 (Chapter 4).  Available values:  - 00: Not exempt  - 13: Grandfathered payment  - 14: Effectively connected income  - 15: Payee not subject to chapter 4 withholding  - 16: Excluded nonfinancial payment  - 17: Foreign Entity that assumes primary withholding responsibility  - 18: U.S. Payees - of participating FFI or registered deemed - compliant FFI  - 19: Exempt from withholding under IGA(6)  - 20: Dormant account(7)  - 21: Other - payment not subject to chapter 4 withholding.</param>
        /// <param name="taxRateChap3">Tax rate (Chapter 3) - Required if WithholdingIndicator is 3 (Chapter 3).  Available values:  - 00.00: 0.00%  - 02.00: 2.00%  - 04.00: 4.00%  - 04.90: 4.90%  - 04.95: 4.95%  - 05.00: 5.00%  - 07.00: 7.00%  - 08.00: 8.00%  - 10.00: 10.00%  - 12.00: 12.00%  - 12.50: 12.50%  - 14.00: 14.00%  - 15.00: 15.00%  - 17.50: 17.50%  - 20.00: 20.00%  - 21.00: 21.00%  - 24.00: 24.00%  - 25.00: 25.00%  - 27.50: 27.50%  - 28.00: 28.00%  - 30.00: 30.00%  - 37.00: 37.00%.</param>
        /// <param name="withholdingAllowance">Withholding allowance.</param>
        /// <param name="federalTaxWithheld">Federal tax withheld.</param>
        /// <param name="taxNotDepositedIndicator">Tax not deposited indicator.</param>
        /// <param name="academicIndicator">Academic indicator.</param>
        /// <param name="taxWithheldOtherAgents">Tax withheld by other agents.</param>
        /// <param name="amountRepaid">Amount repaid to recipient.</param>
        /// <param name="taxPaidAgent">Tax paid by withholding agent.</param>
        /// <param name="chap3StatusCode">Chapter 3 status code - Required if WithholdingIndicator is 3 (Chapter 3)  Available values:  - 01: U.S. Withholding Agent - FI (Deprecated - valid only for tax years prior to 2020)  - 02: U.S. Withholding Agent - Other (Deprecated - valid only for tax years prior to 2020)  - 03: Territory FI - treated as U.S. Person  - 04: Territory FI - not treated as U.S. Person  - 05: U.S. branch - treated as U.S. Person  - 06: U.S. branch - not treated as U.S. Person  - 07: U.S. branch - ECI presumption applied  - 08: Partnership other than Withholding Foreign Partnership  - 09: Withholding Foreign Partnership  - 10: Trust other than Withholding Foreign Trust  - 11: Withholding Foreign Trust  - 12: Qualified Intermediary  - 13: Qualified Securities Lender - Qualified Intermediary  - 14: Qualified Securities Lender - Other  - 15: Corporation  - 16: Individual  - 17: Estate  - 18: Private Foundation  - 19: Government or International Organization  - 20: Tax Exempt Organization (Section 501(c) entities)  - 21: Unknown Recipient  - 22: Artist or Athlete  - 23: Pension  - 24: Foreign Central Bank of Issue  - 25: Nonqualified Intermediary  - 26: Hybrid entity making Treaty Claim  - 27: Withholding Rate Pool - General  - 28: Withholding Rate Pool - Exempt Organization  - 29: PAI Withholding Rate Pool - General  - 30: PAI Withholding Rate Pool - Exempt Organization  - 31: Agency Withholding Rate Pool - General  - 32: Agency Withholding Rate Pool - Exempt Organization  - 34: U.S. Withholding Agent-Foreign branch of FI (Deprecated - valid only for tax years prior to 2020)  - 35: Qualified Derivatives Dealer  - 36: Foreign Government - Integral Part  - 37: Foreign Government - Controlled Entity  - 38: Publicly Traded Partnership  - 39: Disclosing Qualified Intermediary.</param>
        /// <param name="chap4StatusCode">Chapter 4 status code. Required if WithholdingIndicator is 4 (Chapter 4). Required if email is specified, must fill either this or RecipientForeignTin.  Available values:  - 01: U.S. Withholding Agent - FI  - 02: U.S. Withholding Agent - Other  - 03: Territory FI - not treated as U.S. Person  - 04: Territory FI - treated as U.S. Person  - 05: Participating FFI - Other  - 06: Participating FFI - Reporting Model 2 FFI  - 07: Registered Deemed - Compliant FFI-Reporting Model 1 FFI  - 08: Registered Deemed - Compliant FFI-Sponsored Entity  - 09: Registered Deemed - Compliant FFI-Other  - 10: Certified Deemed - Compliant FFI-Other  - 11: Certified Deemed - Compliant FFI-FFI with Low Value Accounts  - 12: Certified Deemed - Compliant FFI-Non-Registering Local Bank  - 13: Certified Deemed - Compliant FFI-Sponsored Entity  - 14: Certified Deemed - Compliant FFI-Investment Advisor or Investment Manager  - 15: Nonparticipating FFI  - 16: Owner-Documented FFI  - 17: U.S. Branch - treated as U.S. person  - 18: U.S. Branch - not treated as U.S. person (reporting under section 1471)  - 19: Passive NFFE identifying Substantial U.S. Owners  - 20: Passive NFFE with no Substantial U.S. Owners  - 21: Publicly Traded NFFE or Affiliate of Publicly Traded NFFE  - 22: Active NFFE  - 23: Individual  - 24: Section 501(c) Entities  - 25: Excepted Territory NFFE  - 26: Excepted NFFE - Other  - 27: Exempt Beneficial Owner  - 28: Entity Wholly Owned by Exempt Beneficial Owners  - 29: Unknown Recipient  - 30: Recalcitrant Account Holder  - 31: Nonreporting IGA FFI  - 32: Direct reporting NFFE  - 33: U.S. reportable account  - 34: Non-consenting U.S. account  - 35: Sponsored direct reporting NFFE  - 36: Excepted Inter-affiliate FFI  - 37: Undocumented Preexisting Obligation  - 38: U.S. Branch - ECI presumption applied  - 39: Account Holder of Excluded Financial Account  - 40: Passive NFFE reported by FFI  - 41: NFFE subject to 1472 withholding  - 42: Recalcitrant Pool - No U.S. Indicia  - 43: Recalcitrant Pool - U.S. Indicia  - 44: Recalcitrant Pool - Dormant Account  - 45: Recalcitrant Pool - U.S. Persons  - 46: Recalcitrant Pool - Passive NFFEs  - 47: Nonparticipating FFI Pool  - 48: U.S. Payees Pool  - 49: QI - Recalcitrant Pool-General  - 50: U.S. Withholding Agent-Foreign branch of FI.</param>
        /// <param name="primaryWithholdingAgent">Primary withholding agent information.</param>
        /// <param name="intermediaryOrFlowThrough">Intermediary or flow-through entity information.</param>
        /// <param name="type">Form type (required).</param>
        /// <param name="issuerId">Issuer ID - only required when creating forms.</param>
        /// <param name="issuerReferenceId">Issuer Reference ID - only required when creating forms.</param>
        /// <param name="issuerTin">Issuer TIN - readonly.</param>
        /// <param name="taxYear">Tax Year - only required when creating forms.</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient..</param>
        /// <param name="tin">Recipient&#39;s Federal Tax Identification Number (TIN)..</param>
        /// <param name="recipientName">Recipient name (required).</param>
        /// <param name="tinType">Type of TIN (Tax ID Number).</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address. (required).</param>
        /// <param name="address2">Address line 2..</param>
        /// <param name="city">City. (required).</param>
        /// <param name="state">Two-letter US state or Canadian province code (required for US/CA addresses)..</param>
        /// <param name="zip">ZIP/postal code..</param>
        /// <param name="email">Recipient&#39;s Contact email address..</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="officeCode">Office code.</param>
        /// <param name="nonUsProvince">Province or region for non-US/CA addresses..</param>
        /// <param name="countryCode">Two-letter IRS country code (e.g., &#39;US&#39;, &#39;CA&#39;), as defined at https://www.irs.gov/e-file-providers/country-codes. (required).</param>
        /// <param name="federalEfileDate">Date when federal e-filing should be scheduled for this form.</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEfileDate">Date when state e-filing should be scheduled for this form.</param>
        /// <param name="recipientEdeliveryDate">Date when recipient e-delivery should be scheduled for this form.</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="noTin">No TIN indicator.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        /// <param name="secondTinNotice">Second TIN notice.</param>
        public Form1042S(string uniqueFormId = default(string), DateTime? recipientDateOfBirth = default(DateTime?), string recipientGiin = default(string), string recipientForeignTin = default(string), LobCodeEnum? lobCode = default(LobCodeEnum?), IncomeCodeEnum incomeCode = default(IncomeCodeEnum), double? grossIncome = default(double?), WithholdingIndicatorEnum withholdingIndicator = default(WithholdingIndicatorEnum), string taxCountryCode = default(string), ExemptionCodeChap3Enum? exemptionCodeChap3 = default(ExemptionCodeChap3Enum?), ExemptionCodeChap4Enum? exemptionCodeChap4 = default(ExemptionCodeChap4Enum?), TaxRateChap3Enum? taxRateChap3 = default(TaxRateChap3Enum?), double? withholdingAllowance = default(double?), double? federalTaxWithheld = default(double?), bool? taxNotDepositedIndicator = default(bool?), bool? academicIndicator = default(bool?), double? taxWithheldOtherAgents = default(double?), double? amountRepaid = default(double?), double? taxPaidAgent = default(double?), Chap3StatusCodeEnum? chap3StatusCode = default(Chap3StatusCodeEnum?), Chap4StatusCodeEnum? chap4StatusCode = default(Chap4StatusCodeEnum?), PrimaryWithholdingAgent primaryWithholdingAgent = default(PrimaryWithholdingAgent), IntermediaryOrFlowThrough intermediaryOrFlowThrough = default(IntermediaryOrFlowThrough), TypeEnum type = default(TypeEnum), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int? taxYear = default(int?), string referenceId = default(string), string tin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), DateTime? federalEfileDate = default(DateTime?), bool? postalMail = default(bool?), DateTime? stateEfileDate = default(DateTime?), DateTime? recipientEdeliveryDate = default(DateTime?), bool? tinMatch = default(bool?), bool? noTin = default(bool?), bool? addressVerification = default(bool?), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding), bool secondTinNotice = default(bool))
        {
            // to ensure "uniqueFormId" is required (not null)
            if (uniqueFormId == null)
            {
                throw new ArgumentNullException("uniqueFormId is a required property for Form1042S and cannot be null");
            }
            this.UniqueFormId = uniqueFormId;
            this.IncomeCode = incomeCode;
            // to ensure "grossIncome" is required (not null)
            if (grossIncome == null)
            {
                throw new ArgumentNullException("grossIncome is a required property for Form1042S and cannot be null");
            }
            this.GrossIncome = grossIncome;
            this.WithholdingIndicator = withholdingIndicator;
            // to ensure "taxCountryCode" is required (not null)
            if (taxCountryCode == null)
            {
                throw new ArgumentNullException("taxCountryCode is a required property for Form1042S and cannot be null");
            }
            this.TaxCountryCode = taxCountryCode;
            this.Type = type;
            // to ensure "recipientName" is required (not null)
            if (recipientName == null)
            {
                throw new ArgumentNullException("recipientName is a required property for Form1042S and cannot be null");
            }
            this.RecipientName = recipientName;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Form1042S and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Form1042S and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1042S and cannot be null");
            }
            this.CountryCode = countryCode;
            this.RecipientDateOfBirth = recipientDateOfBirth;
            this.RecipientGiin = recipientGiin;
            this.RecipientForeignTin = recipientForeignTin;
            this.LobCode = lobCode;
            this.ExemptionCodeChap3 = exemptionCodeChap3;
            this.ExemptionCodeChap4 = exemptionCodeChap4;
            this.TaxRateChap3 = taxRateChap3;
            this.WithholdingAllowance = withholdingAllowance;
            this.FederalTaxWithheld = federalTaxWithheld;
            this.TaxNotDepositedIndicator = taxNotDepositedIndicator;
            this.AcademicIndicator = academicIndicator;
            this.TaxWithheldOtherAgents = taxWithheldOtherAgents;
            this.AmountRepaid = amountRepaid;
            this.TaxPaidAgent = taxPaidAgent;
            this.Chap3StatusCode = chap3StatusCode;
            this.Chap4StatusCode = chap4StatusCode;
            this.PrimaryWithholdingAgent = primaryWithholdingAgent;
            this.IntermediaryOrFlowThrough = intermediaryOrFlowThrough;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Tin = tin;
            this.RecipientSecondName = recipientSecondName;
            this.Address2 = address2;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.NonUsProvince = nonUsProvince;
            this.FederalEfileDate = federalEfileDate;
            this.PostalMail = postalMail;
            this.StateEfileDate = stateEfileDate;
            this.RecipientEdeliveryDate = recipientEdeliveryDate;
            this.TinMatch = tinMatch;
            this.NoTin = noTin;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.SecondTinNotice = secondTinNotice;
        }

        /// <summary>
        /// Unique form identifier
        /// </summary>
        /// <value>Unique form identifier</value>
        [DataMember(Name = "uniqueFormId", IsRequired = true, EmitDefaultValue = true)]
        public string UniqueFormId { get; set; }

        /// <summary>
        /// Recipient&#39;s date of birth
        /// </summary>
        /// <value>Recipient&#39;s date of birth</value>
        [DataMember(Name = "recipientDateOfBirth", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RecipientDateOfBirth { get; set; }

        /// <summary>
        /// Recipient&#39;s Global Intermediary Identification Number (GIIN). A valid GIIN looks like &#39;XXXXXX.XXXXX.XX.XXX&#39;.
        /// </summary>
        /// <value>Recipient&#39;s Global Intermediary Identification Number (GIIN). A valid GIIN looks like &#39;XXXXXX.XXXXX.XX.XXX&#39;.</value>
        [DataMember(Name = "recipientGiin", EmitDefaultValue = true)]
        public string RecipientGiin { get; set; }

        /// <summary>
        /// Recipient&#39;s foreign TIN. Required if email is specified, must fill either this or Chap3StatusCode.
        /// </summary>
        /// <value>Recipient&#39;s foreign TIN. Required if email is specified, must fill either this or Chap3StatusCode.</value>
        [DataMember(Name = "recipientForeignTin", EmitDefaultValue = true)]
        public string RecipientForeignTin { get; set; }

        /// <summary>
        /// Gross income
        /// </summary>
        /// <value>Gross income</value>
        [DataMember(Name = "grossIncome", IsRequired = true, EmitDefaultValue = true)]
        public double? GrossIncome { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name = "taxCountryCode", IsRequired = true, EmitDefaultValue = true)]
        public string TaxCountryCode { get; set; }

        /// <summary>
        /// Withholding allowance
        /// </summary>
        /// <value>Withholding allowance</value>
        [DataMember(Name = "withholdingAllowance", EmitDefaultValue = true)]
        public double? WithholdingAllowance { get; set; }

        /// <summary>
        /// Federal tax withheld
        /// </summary>
        /// <value>Federal tax withheld</value>
        [DataMember(Name = "federalTaxWithheld", EmitDefaultValue = true)]
        public double? FederalTaxWithheld { get; set; }

        /// <summary>
        /// Tax not deposited indicator
        /// </summary>
        /// <value>Tax not deposited indicator</value>
        [DataMember(Name = "taxNotDepositedIndicator", EmitDefaultValue = true)]
        public bool? TaxNotDepositedIndicator { get; set; }

        /// <summary>
        /// Academic indicator
        /// </summary>
        /// <value>Academic indicator</value>
        [DataMember(Name = "academicIndicator", EmitDefaultValue = true)]
        public bool? AcademicIndicator { get; set; }

        /// <summary>
        /// Tax withheld by other agents
        /// </summary>
        /// <value>Tax withheld by other agents</value>
        [DataMember(Name = "taxWithheldOtherAgents", EmitDefaultValue = true)]
        public double? TaxWithheldOtherAgents { get; set; }

        /// <summary>
        /// Amount repaid to recipient
        /// </summary>
        /// <value>Amount repaid to recipient</value>
        [DataMember(Name = "amountRepaid", EmitDefaultValue = true)]
        public double? AmountRepaid { get; set; }

        /// <summary>
        /// Tax paid by withholding agent
        /// </summary>
        /// <value>Tax paid by withholding agent</value>
        [DataMember(Name = "taxPaidAgent", EmitDefaultValue = true)]
        public double? TaxPaidAgent { get; set; }

        /// <summary>
        /// Primary withholding agent information
        /// </summary>
        /// <value>Primary withholding agent information</value>
        [DataMember(Name = "primaryWithholdingAgent", EmitDefaultValue = true)]
        public PrimaryWithholdingAgent PrimaryWithholdingAgent { get; set; }

        /// <summary>
        /// Intermediary or flow-through entity information
        /// </summary>
        /// <value>Intermediary or flow-through entity information</value>
        [DataMember(Name = "intermediaryOrFlowThrough", EmitDefaultValue = true)]
        public IntermediaryOrFlowThrough IntermediaryOrFlowThrough { get; set; }

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
        /// Issuer Reference ID - only required when creating forms
        /// </summary>
        /// <value>Issuer Reference ID - only required when creating forms</value>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN - readonly
        /// </summary>
        /// <value>Issuer TIN - readonly</value>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax Year - only required when creating forms
        /// </summary>
        /// <value>Tax Year - only required when creating forms</value>
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
        /// Recipient name
        /// </summary>
        /// <value>Recipient name</value>
        [DataMember(Name = "recipientName", IsRequired = true, EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Recipient second name
        /// </summary>
        /// <value>Recipient second name</value>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

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
        /// Date when federal e-filing should be scheduled for this form
        /// </summary>
        /// <value>Date when federal e-filing should be scheduled for this form</value>
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
        /// Date when state e-filing should be scheduled for this form
        /// </summary>
        /// <value>Date when state e-filing should be scheduled for this form</value>
        [DataMember(Name = "stateEfileDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StateEfileDate { get; set; }

        /// <summary>
        /// Date when recipient e-delivery should be scheduled for this form
        /// </summary>
        /// <value>Date when recipient e-delivery should be scheduled for this form</value>
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
        /// No TIN indicator
        /// </summary>
        /// <value>No TIN indicator</value>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool? NoTin { get; set; }

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
        /// Second TIN notice
        /// </summary>
        /// <value>Second TIN notice</value>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool SecondTinNotice { get; set; }

        /// <summary>
        /// Federal e-file status
        /// </summary>
        /// <value>Federal e-file status</value>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = true)]
        public Form1099StatusDetail FederalEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as FederalEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFederalEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// State e-file status
        /// </summary>
        /// <value>State e-file status</value>
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
        /// Postal mail to recipient status
        /// </summary>
        /// <value>Postal mail to recipient status</value>
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
        /// TIN Match status
        /// </summary>
        /// <value>TIN Match status</value>
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
        /// Address verification status
        /// </summary>
        /// <value>Address verification status</value>
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
        /// EDelivery status
        /// </summary>
        /// <value>EDelivery status</value>
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
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

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
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
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
            sb.Append("class Form1042S {\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  UniqueFormId: ").Append(UniqueFormId).Append("\n");
            sb.Append("  RecipientDateOfBirth: ").Append(RecipientDateOfBirth).Append("\n");
            sb.Append("  RecipientGiin: ").Append(RecipientGiin).Append("\n");
            sb.Append("  RecipientForeignTin: ").Append(RecipientForeignTin).Append("\n");
            sb.Append("  LobCode: ").Append(LobCode).Append("\n");
            sb.Append("  IncomeCode: ").Append(IncomeCode).Append("\n");
            sb.Append("  GrossIncome: ").Append(GrossIncome).Append("\n");
            sb.Append("  WithholdingIndicator: ").Append(WithholdingIndicator).Append("\n");
            sb.Append("  TaxCountryCode: ").Append(TaxCountryCode).Append("\n");
            sb.Append("  ExemptionCodeChap3: ").Append(ExemptionCodeChap3).Append("\n");
            sb.Append("  ExemptionCodeChap4: ").Append(ExemptionCodeChap4).Append("\n");
            sb.Append("  TaxRateChap3: ").Append(TaxRateChap3).Append("\n");
            sb.Append("  WithholdingAllowance: ").Append(WithholdingAllowance).Append("\n");
            sb.Append("  FederalTaxWithheld: ").Append(FederalTaxWithheld).Append("\n");
            sb.Append("  TaxNotDepositedIndicator: ").Append(TaxNotDepositedIndicator).Append("\n");
            sb.Append("  AcademicIndicator: ").Append(AcademicIndicator).Append("\n");
            sb.Append("  TaxWithheldOtherAgents: ").Append(TaxWithheldOtherAgents).Append("\n");
            sb.Append("  AmountRepaid: ").Append(AmountRepaid).Append("\n");
            sb.Append("  TaxPaidAgent: ").Append(TaxPaidAgent).Append("\n");
            sb.Append("  Chap3StatusCode: ").Append(Chap3StatusCode).Append("\n");
            sb.Append("  Chap4StatusCode: ").Append(Chap4StatusCode).Append("\n");
            sb.Append("  PrimaryWithholdingAgent: ").Append(PrimaryWithholdingAgent).Append("\n");
            sb.Append("  IntermediaryOrFlowThrough: ").Append(IntermediaryOrFlowThrough).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  NonUsProvince: ").Append(NonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FederalEfileDate: ").Append(FederalEfileDate).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEfileDate: ").Append(StateEfileDate).Append("\n");
            sb.Append("  RecipientEdeliveryDate: ").Append(RecipientEdeliveryDate).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  EDeliveryStatus: ").Append(EDeliveryStatus).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
