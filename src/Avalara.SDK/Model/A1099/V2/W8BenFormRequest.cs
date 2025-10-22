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
    /// W8BenFormRequest
    /// </summary>
    [DataContract(Name = "W8BenFormRequest")]
    public partial class W8BenFormRequest : IValidatableObject
    {
        /// <summary>
        /// The form type (always \&quot;w8ben\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w8ben\&quot; for this model).</value>
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
        /// The form type (always \&quot;w8ben\&quot; for this model).
        /// </summary>
        /// <value>The form type (always \&quot;w8ben\&quot; for this model).</value>
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
        /// The country of citizenship.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country of citizenship.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CitizenshipCountryEnum
        {
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 1,

            /// <summary>
            /// Enum AF for value: AF
            /// </summary>
            [EnumMember(Value = "AF")]
            AF = 2,

            /// <summary>
            /// Enum AX for value: AX
            /// </summary>
            [EnumMember(Value = "AX")]
            AX = 3,

            /// <summary>
            /// Enum AL for value: AL
            /// </summary>
            [EnumMember(Value = "AL")]
            AL = 4,

            /// <summary>
            /// Enum AG for value: AG
            /// </summary>
            [EnumMember(Value = "AG")]
            AG = 5,

            /// <summary>
            /// Enum AQ for value: AQ
            /// </summary>
            [EnumMember(Value = "AQ")]
            AQ = 6,

            /// <summary>
            /// Enum AN for value: AN
            /// </summary>
            [EnumMember(Value = "AN")]
            AN = 7,

            /// <summary>
            /// Enum AO for value: AO
            /// </summary>
            [EnumMember(Value = "AO")]
            AO = 8,

            /// <summary>
            /// Enum AV for value: AV
            /// </summary>
            [EnumMember(Value = "AV")]
            AV = 9,

            /// <summary>
            /// Enum AY for value: AY
            /// </summary>
            [EnumMember(Value = "AY")]
            AY = 10,

            /// <summary>
            /// Enum AC for value: AC
            /// </summary>
            [EnumMember(Value = "AC")]
            AC = 11,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 12,

            /// <summary>
            /// Enum AM for value: AM
            /// </summary>
            [EnumMember(Value = "AM")]
            AM = 13,

            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 14,

            /// <summary>
            /// Enum AT for value: AT
            /// </summary>
            [EnumMember(Value = "AT")]
            AT = 15,

            /// <summary>
            /// Enum AS for value: AS
            /// </summary>
            [EnumMember(Value = "AS")]
            AS = 16,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 17,

            /// <summary>
            /// Enum AJ for value: AJ
            /// </summary>
            [EnumMember(Value = "AJ")]
            AJ = 18,

            /// <summary>
            /// Enum BF for value: BF
            /// </summary>
            [EnumMember(Value = "BF")]
            BF = 19,

            /// <summary>
            /// Enum BA for value: BA
            /// </summary>
            [EnumMember(Value = "BA")]
            BA = 20,

            /// <summary>
            /// Enum FQ for value: FQ
            /// </summary>
            [EnumMember(Value = "FQ")]
            FQ = 21,

            /// <summary>
            /// Enum BG for value: BG
            /// </summary>
            [EnumMember(Value = "BG")]
            BG = 22,

            /// <summary>
            /// Enum BB for value: BB
            /// </summary>
            [EnumMember(Value = "BB")]
            BB = 23,

            /// <summary>
            /// Enum BO for value: BO
            /// </summary>
            [EnumMember(Value = "BO")]
            BO = 24,

            /// <summary>
            /// Enum BE for value: BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BE = 25,

            /// <summary>
            /// Enum BH for value: BH
            /// </summary>
            [EnumMember(Value = "BH")]
            BH = 26,

            /// <summary>
            /// Enum BN for value: BN
            /// </summary>
            [EnumMember(Value = "BN")]
            BN = 27,

            /// <summary>
            /// Enum BD for value: BD
            /// </summary>
            [EnumMember(Value = "BD")]
            BD = 28,

            /// <summary>
            /// Enum BT for value: BT
            /// </summary>
            [EnumMember(Value = "BT")]
            BT = 29,

            /// <summary>
            /// Enum BL for value: BL
            /// </summary>
            [EnumMember(Value = "BL")]
            BL = 30,

            /// <summary>
            /// Enum BK for value: BK
            /// </summary>
            [EnumMember(Value = "BK")]
            BK = 31,

            /// <summary>
            /// Enum BC for value: BC
            /// </summary>
            [EnumMember(Value = "BC")]
            BC = 32,

            /// <summary>
            /// Enum BV for value: BV
            /// </summary>
            [EnumMember(Value = "BV")]
            BV = 33,

            /// <summary>
            /// Enum BR for value: BR
            /// </summary>
            [EnumMember(Value = "BR")]
            BR = 34,

            /// <summary>
            /// Enum IO for value: IO
            /// </summary>
            [EnumMember(Value = "IO")]
            IO = 35,

            /// <summary>
            /// Enum VI for value: VI
            /// </summary>
            [EnumMember(Value = "VI")]
            VI = 36,

            /// <summary>
            /// Enum BX for value: BX
            /// </summary>
            [EnumMember(Value = "BX")]
            BX = 37,

            /// <summary>
            /// Enum BU for value: BU
            /// </summary>
            [EnumMember(Value = "BU")]
            BU = 38,

            /// <summary>
            /// Enum UV for value: UV
            /// </summary>
            [EnumMember(Value = "UV")]
            UV = 39,

            /// <summary>
            /// Enum BM for value: BM
            /// </summary>
            [EnumMember(Value = "BM")]
            BM = 40,

            /// <summary>
            /// Enum BY for value: BY
            /// </summary>
            [EnumMember(Value = "BY")]
            BY = 41,

            /// <summary>
            /// Enum CB for value: CB
            /// </summary>
            [EnumMember(Value = "CB")]
            CB = 42,

            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 43,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 44,

            /// <summary>
            /// Enum CV for value: CV
            /// </summary>
            [EnumMember(Value = "CV")]
            CV = 45,

            /// <summary>
            /// Enum CJ for value: CJ
            /// </summary>
            [EnumMember(Value = "CJ")]
            CJ = 46,

            /// <summary>
            /// Enum CT for value: CT
            /// </summary>
            [EnumMember(Value = "CT")]
            CT = 47,

            /// <summary>
            /// Enum CD for value: CD
            /// </summary>
            [EnumMember(Value = "CD")]
            CD = 48,

            /// <summary>
            /// Enum CI for value: CI
            /// </summary>
            [EnumMember(Value = "CI")]
            CI = 49,

            /// <summary>
            /// Enum CH for value: CH
            /// </summary>
            [EnumMember(Value = "CH")]
            CH = 50,

            /// <summary>
            /// Enum KT for value: KT
            /// </summary>
            [EnumMember(Value = "KT")]
            KT = 51,

            /// <summary>
            /// Enum IP for value: IP
            /// </summary>
            [EnumMember(Value = "IP")]
            IP = 52,

            /// <summary>
            /// Enum CK for value: CK
            /// </summary>
            [EnumMember(Value = "CK")]
            CK = 53,

            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            [EnumMember(Value = "CO")]
            CO = 54,

            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            [EnumMember(Value = "CN")]
            CN = 55,

            /// <summary>
            /// Enum CF for value: CF
            /// </summary>
            [EnumMember(Value = "CF")]
            CF = 56,

            /// <summary>
            /// Enum CG for value: CG
            /// </summary>
            [EnumMember(Value = "CG")]
            CG = 57,

            /// <summary>
            /// Enum CW for value: CW
            /// </summary>
            [EnumMember(Value = "CW")]
            CW = 58,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 59,

            /// <summary>
            /// Enum CS for value: CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CS = 60,

            /// <summary>
            /// Enum IV for value: IV
            /// </summary>
            [EnumMember(Value = "IV")]
            IV = 61,

            /// <summary>
            /// Enum HR for value: HR
            /// </summary>
            [EnumMember(Value = "HR")]
            HR = 62,

            /// <summary>
            /// Enum CU for value: CU
            /// </summary>
            [EnumMember(Value = "CU")]
            CU = 63,

            /// <summary>
            /// Enum UC for value: UC
            /// </summary>
            [EnumMember(Value = "UC")]
            UC = 64,

            /// <summary>
            /// Enum CY for value: CY
            /// </summary>
            [EnumMember(Value = "CY")]
            CY = 65,

            /// <summary>
            /// Enum EZ for value: EZ
            /// </summary>
            [EnumMember(Value = "EZ")]
            EZ = 66,

            /// <summary>
            /// Enum DA for value: DA
            /// </summary>
            [EnumMember(Value = "DA")]
            DA = 67,

            /// <summary>
            /// Enum DX for value: DX
            /// </summary>
            [EnumMember(Value = "DX")]
            DX = 68,

            /// <summary>
            /// Enum DJ for value: DJ
            /// </summary>
            [EnumMember(Value = "DJ")]
            DJ = 69,

            /// <summary>
            /// Enum DO for value: DO
            /// </summary>
            [EnumMember(Value = "DO")]
            DO = 70,

            /// <summary>
            /// Enum DR for value: DR
            /// </summary>
            [EnumMember(Value = "DR")]
            DR = 71,

            /// <summary>
            /// Enum TT for value: TT
            /// </summary>
            [EnumMember(Value = "TT")]
            TT = 72,

            /// <summary>
            /// Enum EC for value: EC
            /// </summary>
            [EnumMember(Value = "EC")]
            EC = 73,

            /// <summary>
            /// Enum EG for value: EG
            /// </summary>
            [EnumMember(Value = "EG")]
            EG = 74,

            /// <summary>
            /// Enum ES for value: ES
            /// </summary>
            [EnumMember(Value = "ES")]
            ES = 75,

            /// <summary>
            /// Enum EK for value: EK
            /// </summary>
            [EnumMember(Value = "EK")]
            EK = 76,

            /// <summary>
            /// Enum ER for value: ER
            /// </summary>
            [EnumMember(Value = "ER")]
            ER = 77,

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            [EnumMember(Value = "EN")]
            EN = 78,

            /// <summary>
            /// Enum ET for value: ET
            /// </summary>
            [EnumMember(Value = "ET")]
            ET = 79,

            /// <summary>
            /// Enum FK for value: FK
            /// </summary>
            [EnumMember(Value = "FK")]
            FK = 80,

            /// <summary>
            /// Enum FO for value: FO
            /// </summary>
            [EnumMember(Value = "FO")]
            FO = 81,

            /// <summary>
            /// Enum FM for value: FM
            /// </summary>
            [EnumMember(Value = "FM")]
            FM = 82,

            /// <summary>
            /// Enum FJ for value: FJ
            /// </summary>
            [EnumMember(Value = "FJ")]
            FJ = 83,

            /// <summary>
            /// Enum FI for value: FI
            /// </summary>
            [EnumMember(Value = "FI")]
            FI = 84,

            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 85,

            /// <summary>
            /// Enum FP for value: FP
            /// </summary>
            [EnumMember(Value = "FP")]
            FP = 86,

            /// <summary>
            /// Enum FS for value: FS
            /// </summary>
            [EnumMember(Value = "FS")]
            FS = 87,

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 88,

            /// <summary>
            /// Enum GA for value: GA
            /// </summary>
            [EnumMember(Value = "GA")]
            GA = 89,

            /// <summary>
            /// Enum GG for value: GG
            /// </summary>
            [EnumMember(Value = "GG")]
            GG = 90,

            /// <summary>
            /// Enum GM for value: GM
            /// </summary>
            [EnumMember(Value = "GM")]
            GM = 91,

            /// <summary>
            /// Enum GH for value: GH
            /// </summary>
            [EnumMember(Value = "GH")]
            GH = 92,

            /// <summary>
            /// Enum GI for value: GI
            /// </summary>
            [EnumMember(Value = "GI")]
            GI = 93,

            /// <summary>
            /// Enum GR for value: GR
            /// </summary>
            [EnumMember(Value = "GR")]
            GR = 94,

            /// <summary>
            /// Enum GL for value: GL
            /// </summary>
            [EnumMember(Value = "GL")]
            GL = 95,

            /// <summary>
            /// Enum GJ for value: GJ
            /// </summary>
            [EnumMember(Value = "GJ")]
            GJ = 96,

            /// <summary>
            /// Enum GQ for value: GQ
            /// </summary>
            [EnumMember(Value = "GQ")]
            GQ = 97,

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            [EnumMember(Value = "GT")]
            GT = 98,

            /// <summary>
            /// Enum GK for value: GK
            /// </summary>
            [EnumMember(Value = "GK")]
            GK = 99,

            /// <summary>
            /// Enum GV for value: GV
            /// </summary>
            [EnumMember(Value = "GV")]
            GV = 100,

            /// <summary>
            /// Enum PU for value: PU
            /// </summary>
            [EnumMember(Value = "PU")]
            PU = 101,

            /// <summary>
            /// Enum GY for value: GY
            /// </summary>
            [EnumMember(Value = "GY")]
            GY = 102,

            /// <summary>
            /// Enum HA for value: HA
            /// </summary>
            [EnumMember(Value = "HA")]
            HA = 103,

            /// <summary>
            /// Enum HM for value: HM
            /// </summary>
            [EnumMember(Value = "HM")]
            HM = 104,

            /// <summary>
            /// Enum VT for value: VT
            /// </summary>
            [EnumMember(Value = "VT")]
            VT = 105,

            /// <summary>
            /// Enum HO for value: HO
            /// </summary>
            [EnumMember(Value = "HO")]
            HO = 106,

            /// <summary>
            /// Enum HK for value: HK
            /// </summary>
            [EnumMember(Value = "HK")]
            HK = 107,

            /// <summary>
            /// Enum HQ for value: HQ
            /// </summary>
            [EnumMember(Value = "HQ")]
            HQ = 108,

            /// <summary>
            /// Enum HU for value: HU
            /// </summary>
            [EnumMember(Value = "HU")]
            HU = 109,

            /// <summary>
            /// Enum IC for value: IC
            /// </summary>
            [EnumMember(Value = "IC")]
            IC = 110,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 111,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 112,

            /// <summary>
            /// Enum IR for value: IR
            /// </summary>
            [EnumMember(Value = "IR")]
            IR = 113,

            /// <summary>
            /// Enum IZ for value: IZ
            /// </summary>
            [EnumMember(Value = "IZ")]
            IZ = 114,

            /// <summary>
            /// Enum EI for value: EI
            /// </summary>
            [EnumMember(Value = "EI")]
            EI = 115,

            /// <summary>
            /// Enum IS for value: IS
            /// </summary>
            [EnumMember(Value = "IS")]
            IS = 116,

            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 117,

            /// <summary>
            /// Enum JM for value: JM
            /// </summary>
            [EnumMember(Value = "JM")]
            JM = 118,

            /// <summary>
            /// Enum JN for value: JN
            /// </summary>
            [EnumMember(Value = "JN")]
            JN = 119,

            /// <summary>
            /// Enum JA for value: JA
            /// </summary>
            [EnumMember(Value = "JA")]
            JA = 120,

            /// <summary>
            /// Enum DQ for value: DQ
            /// </summary>
            [EnumMember(Value = "DQ")]
            DQ = 121,

            /// <summary>
            /// Enum JE for value: JE
            /// </summary>
            [EnumMember(Value = "JE")]
            JE = 122,

            /// <summary>
            /// Enum JQ for value: JQ
            /// </summary>
            [EnumMember(Value = "JQ")]
            JQ = 123,

            /// <summary>
            /// Enum JO for value: JO
            /// </summary>
            [EnumMember(Value = "JO")]
            JO = 124,

            /// <summary>
            /// Enum KZ for value: KZ
            /// </summary>
            [EnumMember(Value = "KZ")]
            KZ = 125,

            /// <summary>
            /// Enum KE for value: KE
            /// </summary>
            [EnumMember(Value = "KE")]
            KE = 126,

            /// <summary>
            /// Enum KQ for value: KQ
            /// </summary>
            [EnumMember(Value = "KQ")]
            KQ = 127,

            /// <summary>
            /// Enum KR for value: KR
            /// </summary>
            [EnumMember(Value = "KR")]
            KR = 128,

            /// <summary>
            /// Enum KN for value: KN
            /// </summary>
            [EnumMember(Value = "KN")]
            KN = 129,

            /// <summary>
            /// Enum KS for value: KS
            /// </summary>
            [EnumMember(Value = "KS")]
            KS = 130,

            /// <summary>
            /// Enum KV for value: KV
            /// </summary>
            [EnumMember(Value = "KV")]
            KV = 131,

            /// <summary>
            /// Enum KU for value: KU
            /// </summary>
            [EnumMember(Value = "KU")]
            KU = 132,

            /// <summary>
            /// Enum KG for value: KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KG = 133,

            /// <summary>
            /// Enum LA for value: LA
            /// </summary>
            [EnumMember(Value = "LA")]
            LA = 134,

            /// <summary>
            /// Enum LG for value: LG
            /// </summary>
            [EnumMember(Value = "LG")]
            LG = 135,

            /// <summary>
            /// Enum LE for value: LE
            /// </summary>
            [EnumMember(Value = "LE")]
            LE = 136,

            /// <summary>
            /// Enum LT for value: LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LT = 137,

            /// <summary>
            /// Enum LI for value: LI
            /// </summary>
            [EnumMember(Value = "LI")]
            LI = 138,

            /// <summary>
            /// Enum LY for value: LY
            /// </summary>
            [EnumMember(Value = "LY")]
            LY = 139,

            /// <summary>
            /// Enum LS for value: LS
            /// </summary>
            [EnumMember(Value = "LS")]
            LS = 140,

            /// <summary>
            /// Enum LH for value: LH
            /// </summary>
            [EnumMember(Value = "LH")]
            LH = 141,

            /// <summary>
            /// Enum LU for value: LU
            /// </summary>
            [EnumMember(Value = "LU")]
            LU = 142,

            /// <summary>
            /// Enum MC for value: MC
            /// </summary>
            [EnumMember(Value = "MC")]
            MC = 143,

            /// <summary>
            /// Enum MK for value: MK
            /// </summary>
            [EnumMember(Value = "MK")]
            MK = 144,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 145,

            /// <summary>
            /// Enum MI for value: MI
            /// </summary>
            [EnumMember(Value = "MI")]
            MI = 146,

            /// <summary>
            /// Enum MY for value: MY
            /// </summary>
            [EnumMember(Value = "MY")]
            MY = 147,

            /// <summary>
            /// Enum MV for value: MV
            /// </summary>
            [EnumMember(Value = "MV")]
            MV = 148,

            /// <summary>
            /// Enum ML for value: ML
            /// </summary>
            [EnumMember(Value = "ML")]
            ML = 149,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 150,

            /// <summary>
            /// Enum IM for value: IM
            /// </summary>
            [EnumMember(Value = "IM")]
            IM = 151,

            /// <summary>
            /// Enum RM for value: RM
            /// </summary>
            [EnumMember(Value = "RM")]
            RM = 152,

            /// <summary>
            /// Enum MR for value: MR
            /// </summary>
            [EnumMember(Value = "MR")]
            MR = 153,

            /// <summary>
            /// Enum MP for value: MP
            /// </summary>
            [EnumMember(Value = "MP")]
            MP = 154,

            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 155,

            /// <summary>
            /// Enum MQ for value: MQ
            /// </summary>
            [EnumMember(Value = "MQ")]
            MQ = 156,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 157,

            /// <summary>
            /// Enum MN for value: MN
            /// </summary>
            [EnumMember(Value = "MN")]
            MN = 158,

            /// <summary>
            /// Enum MG for value: MG
            /// </summary>
            [EnumMember(Value = "MG")]
            MG = 159,

            /// <summary>
            /// Enum MJ for value: MJ
            /// </summary>
            [EnumMember(Value = "MJ")]
            MJ = 160,

            /// <summary>
            /// Enum MH for value: MH
            /// </summary>
            [EnumMember(Value = "MH")]
            MH = 161,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 162,

            /// <summary>
            /// Enum MZ for value: MZ
            /// </summary>
            [EnumMember(Value = "MZ")]
            MZ = 163,

            /// <summary>
            /// Enum WA for value: WA
            /// </summary>
            [EnumMember(Value = "WA")]
            WA = 164,

            /// <summary>
            /// Enum NR for value: NR
            /// </summary>
            [EnumMember(Value = "NR")]
            NR = 165,

            /// <summary>
            /// Enum BQ for value: BQ
            /// </summary>
            [EnumMember(Value = "BQ")]
            BQ = 166,

            /// <summary>
            /// Enum NP for value: NP
            /// </summary>
            [EnumMember(Value = "NP")]
            NP = 167,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 168,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 169,

            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 170,

            /// <summary>
            /// Enum NU for value: NU
            /// </summary>
            [EnumMember(Value = "NU")]
            NU = 171,

            /// <summary>
            /// Enum NG for value: NG
            /// </summary>
            [EnumMember(Value = "NG")]
            NG = 172,

            /// <summary>
            /// Enum NI for value: NI
            /// </summary>
            [EnumMember(Value = "NI")]
            NI = 173,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 174,

            /// <summary>
            /// Enum NF for value: NF
            /// </summary>
            [EnumMember(Value = "NF")]
            NF = 175,

            /// <summary>
            /// Enum CQ for value: CQ
            /// </summary>
            [EnumMember(Value = "CQ")]
            CQ = 176,

            /// <summary>
            /// Enum NO for value: NO
            /// </summary>
            [EnumMember(Value = "NO")]
            NO = 177,

            /// <summary>
            /// Enum MU for value: MU
            /// </summary>
            [EnumMember(Value = "MU")]
            MU = 178,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 179,

            /// <summary>
            /// Enum PK for value: PK
            /// </summary>
            [EnumMember(Value = "PK")]
            PK = 180,

            /// <summary>
            /// Enum PS for value: PS
            /// </summary>
            [EnumMember(Value = "PS")]
            PS = 181,

            /// <summary>
            /// Enum LQ for value: LQ
            /// </summary>
            [EnumMember(Value = "LQ")]
            LQ = 182,

            /// <summary>
            /// Enum PM for value: PM
            /// </summary>
            [EnumMember(Value = "PM")]
            PM = 183,

            /// <summary>
            /// Enum PP for value: PP
            /// </summary>
            [EnumMember(Value = "PP")]
            PP = 184,

            /// <summary>
            /// Enum PF for value: PF
            /// </summary>
            [EnumMember(Value = "PF")]
            PF = 185,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 186,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 187,

            /// <summary>
            /// Enum RP for value: RP
            /// </summary>
            [EnumMember(Value = "RP")]
            RP = 188,

            /// <summary>
            /// Enum PC for value: PC
            /// </summary>
            [EnumMember(Value = "PC")]
            PC = 189,

            /// <summary>
            /// Enum PL for value: PL
            /// </summary>
            [EnumMember(Value = "PL")]
            PL = 190,

            /// <summary>
            /// Enum PO for value: PO
            /// </summary>
            [EnumMember(Value = "PO")]
            PO = 191,

            /// <summary>
            /// Enum RQ for value: RQ
            /// </summary>
            [EnumMember(Value = "RQ")]
            RQ = 192,

            /// <summary>
            /// Enum QA for value: QA
            /// </summary>
            [EnumMember(Value = "QA")]
            QA = 193,

            /// <summary>
            /// Enum RO for value: RO
            /// </summary>
            [EnumMember(Value = "RO")]
            RO = 194,

            /// <summary>
            /// Enum RS for value: RS
            /// </summary>
            [EnumMember(Value = "RS")]
            RS = 195,

            /// <summary>
            /// Enum RW for value: RW
            /// </summary>
            [EnumMember(Value = "RW")]
            RW = 196,

            /// <summary>
            /// Enum TB for value: TB
            /// </summary>
            [EnumMember(Value = "TB")]
            TB = 197,

            /// <summary>
            /// Enum RN for value: RN
            /// </summary>
            [EnumMember(Value = "RN")]
            RN = 198,

            /// <summary>
            /// Enum WS for value: WS
            /// </summary>
            [EnumMember(Value = "WS")]
            WS = 199,

            /// <summary>
            /// Enum SM for value: SM
            /// </summary>
            [EnumMember(Value = "SM")]
            SM = 200,

            /// <summary>
            /// Enum TP for value: TP
            /// </summary>
            [EnumMember(Value = "TP")]
            TP = 201,

            /// <summary>
            /// Enum SA for value: SA
            /// </summary>
            [EnumMember(Value = "SA")]
            SA = 202,

            /// <summary>
            /// Enum SG for value: SG
            /// </summary>
            [EnumMember(Value = "SG")]
            SG = 203,

            /// <summary>
            /// Enum RI for value: RI
            /// </summary>
            [EnumMember(Value = "RI")]
            RI = 204,

            /// <summary>
            /// Enum SE for value: SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SE = 205,

            /// <summary>
            /// Enum SL for value: SL
            /// </summary>
            [EnumMember(Value = "SL")]
            SL = 206,

            /// <summary>
            /// Enum SN for value: SN
            /// </summary>
            [EnumMember(Value = "SN")]
            SN = 207,

            /// <summary>
            /// Enum NN for value: NN
            /// </summary>
            [EnumMember(Value = "NN")]
            NN = 208,

            /// <summary>
            /// Enum LO for value: LO
            /// </summary>
            [EnumMember(Value = "LO")]
            LO = 209,

            /// <summary>
            /// Enum SI for value: SI
            /// </summary>
            [EnumMember(Value = "SI")]
            SI = 210,

            /// <summary>
            /// Enum BP for value: BP
            /// </summary>
            [EnumMember(Value = "BP")]
            BP = 211,

            /// <summary>
            /// Enum SO for value: SO
            /// </summary>
            [EnumMember(Value = "SO")]
            SO = 212,

            /// <summary>
            /// Enum SF for value: SF
            /// </summary>
            [EnumMember(Value = "SF")]
            SF = 213,

            /// <summary>
            /// Enum SX for value: SX
            /// </summary>
            [EnumMember(Value = "SX")]
            SX = 214,

            /// <summary>
            /// Enum SP for value: SP
            /// </summary>
            [EnumMember(Value = "SP")]
            SP = 215,

            /// <summary>
            /// Enum PG for value: PG
            /// </summary>
            [EnumMember(Value = "PG")]
            PG = 216,

            /// <summary>
            /// Enum CE for value: CE
            /// </summary>
            [EnumMember(Value = "CE")]
            CE = 217,

            /// <summary>
            /// Enum SH for value: SH
            /// </summary>
            [EnumMember(Value = "SH")]
            SH = 218,

            /// <summary>
            /// Enum SC for value: SC
            /// </summary>
            [EnumMember(Value = "SC")]
            SC = 219,

            /// <summary>
            /// Enum ST for value: ST
            /// </summary>
            [EnumMember(Value = "ST")]
            ST = 220,

            /// <summary>
            /// Enum SB for value: SB
            /// </summary>
            [EnumMember(Value = "SB")]
            SB = 221,

            /// <summary>
            /// Enum VC for value: VC
            /// </summary>
            [EnumMember(Value = "VC")]
            VC = 222,

            /// <summary>
            /// Enum SU for value: SU
            /// </summary>
            [EnumMember(Value = "SU")]
            SU = 223,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 224,

            /// <summary>
            /// Enum SV for value: SV
            /// </summary>
            [EnumMember(Value = "SV")]
            SV = 225,

            /// <summary>
            /// Enum WZ for value: WZ
            /// </summary>
            [EnumMember(Value = "WZ")]
            WZ = 226,

            /// <summary>
            /// Enum SW for value: SW
            /// </summary>
            [EnumMember(Value = "SW")]
            SW = 227,

            /// <summary>
            /// Enum SZ for value: SZ
            /// </summary>
            [EnumMember(Value = "SZ")]
            SZ = 228,

            /// <summary>
            /// Enum SY for value: SY
            /// </summary>
            [EnumMember(Value = "SY")]
            SY = 229,

            /// <summary>
            /// Enum TW for value: TW
            /// </summary>
            [EnumMember(Value = "TW")]
            TW = 230,

            /// <summary>
            /// Enum TI for value: TI
            /// </summary>
            [EnumMember(Value = "TI")]
            TI = 231,

            /// <summary>
            /// Enum TZ for value: TZ
            /// </summary>
            [EnumMember(Value = "TZ")]
            TZ = 232,

            /// <summary>
            /// Enum TH for value: TH
            /// </summary>
            [EnumMember(Value = "TH")]
            TH = 233,

            /// <summary>
            /// Enum TO for value: TO
            /// </summary>
            [EnumMember(Value = "TO")]
            TO = 234,

            /// <summary>
            /// Enum TL for value: TL
            /// </summary>
            [EnumMember(Value = "TL")]
            TL = 235,

            /// <summary>
            /// Enum TN for value: TN
            /// </summary>
            [EnumMember(Value = "TN")]
            TN = 236,

            /// <summary>
            /// Enum TD for value: TD
            /// </summary>
            [EnumMember(Value = "TD")]
            TD = 237,

            /// <summary>
            /// Enum TS for value: TS
            /// </summary>
            [EnumMember(Value = "TS")]
            TS = 238,

            /// <summary>
            /// Enum TU for value: TU
            /// </summary>
            [EnumMember(Value = "TU")]
            TU = 239,

            /// <summary>
            /// Enum TX for value: TX
            /// </summary>
            [EnumMember(Value = "TX")]
            TX = 240,

            /// <summary>
            /// Enum TK for value: TK
            /// </summary>
            [EnumMember(Value = "TK")]
            TK = 241,

            /// <summary>
            /// Enum TV for value: TV
            /// </summary>
            [EnumMember(Value = "TV")]
            TV = 242,

            /// <summary>
            /// Enum UG for value: UG
            /// </summary>
            [EnumMember(Value = "UG")]
            UG = 243,

            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            [EnumMember(Value = "UP")]
            UP = 244,

            /// <summary>
            /// Enum AE for value: AE
            /// </summary>
            [EnumMember(Value = "AE")]
            AE = 245,

            /// <summary>
            /// Enum UK for value: UK
            /// </summary>
            [EnumMember(Value = "UK")]
            UK = 246,

            /// <summary>
            /// Enum UY for value: UY
            /// </summary>
            [EnumMember(Value = "UY")]
            UY = 247,

            /// <summary>
            /// Enum UZ for value: UZ
            /// </summary>
            [EnumMember(Value = "UZ")]
            UZ = 248,

            /// <summary>
            /// Enum NH for value: NH
            /// </summary>
            [EnumMember(Value = "NH")]
            NH = 249,

            /// <summary>
            /// Enum VE for value: VE
            /// </summary>
            [EnumMember(Value = "VE")]
            VE = 250,

            /// <summary>
            /// Enum VM for value: VM
            /// </summary>
            [EnumMember(Value = "VM")]
            VM = 251,

            /// <summary>
            /// Enum VQ for value: VQ
            /// </summary>
            [EnumMember(Value = "VQ")]
            VQ = 252,

            /// <summary>
            /// Enum WQ for value: WQ
            /// </summary>
            [EnumMember(Value = "WQ")]
            WQ = 253,

            /// <summary>
            /// Enum WF for value: WF
            /// </summary>
            [EnumMember(Value = "WF")]
            WF = 254,

            /// <summary>
            /// Enum WI for value: WI
            /// </summary>
            [EnumMember(Value = "WI")]
            WI = 255,

            /// <summary>
            /// Enum YM for value: YM
            /// </summary>
            [EnumMember(Value = "YM")]
            YM = 256,

            /// <summary>
            /// Enum ZA for value: ZA
            /// </summary>
            [EnumMember(Value = "ZA")]
            ZA = 257,

            /// <summary>
            /// Enum ZI for value: ZI
            /// </summary>
            [EnumMember(Value = "ZI")]
            ZI = 258
        }


        /// <summary>
        /// The country of citizenship.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country of citizenship.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [DataMember(Name = "citizenshipCountry", IsRequired = true, EmitDefaultValue = true)]
        public CitizenshipCountryEnum CitizenshipCountry { get; set; }
        /// <summary>
        /// The state of residence. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)
        /// </summary>
        /// <value>The state of residence. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResidenceStateEnum
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
            WY = 62,

            /// <summary>
            /// Enum AB for value: AB
            /// </summary>
            [EnumMember(Value = "AB")]
            AB = 63,

            /// <summary>
            /// Enum BC for value: BC
            /// </summary>
            [EnumMember(Value = "BC")]
            BC = 64,

            /// <summary>
            /// Enum MB for value: MB
            /// </summary>
            [EnumMember(Value = "MB")]
            MB = 65,

            /// <summary>
            /// Enum NB for value: NB
            /// </summary>
            [EnumMember(Value = "NB")]
            NB = 66,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 67,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 68,

            /// <summary>
            /// Enum NT for value: NT
            /// </summary>
            [EnumMember(Value = "NT")]
            NT = 69,

            /// <summary>
            /// Enum NU for value: NU
            /// </summary>
            [EnumMember(Value = "NU")]
            NU = 70,

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            [EnumMember(Value = "ON")]
            ON = 71,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 72,

            /// <summary>
            /// Enum QC for value: QC
            /// </summary>
            [EnumMember(Value = "QC")]
            QC = 73,

            /// <summary>
            /// Enum SK for value: SK
            /// </summary>
            [EnumMember(Value = "SK")]
            SK = 74,

            /// <summary>
            /// Enum YT for value: YT
            /// </summary>
            [EnumMember(Value = "YT")]
            YT = 75
        }


        /// <summary>
        /// The state of residence. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)
        /// </summary>
        /// <value>The state of residence. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)</value>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public ResidenceStateEnum? ResidenceState { get; set; }
        /// <summary>
        /// The country of residence.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country of residence.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResidenceCountryEnum
        {
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 1,

            /// <summary>
            /// Enum AF for value: AF
            /// </summary>
            [EnumMember(Value = "AF")]
            AF = 2,

            /// <summary>
            /// Enum AX for value: AX
            /// </summary>
            [EnumMember(Value = "AX")]
            AX = 3,

            /// <summary>
            /// Enum AL for value: AL
            /// </summary>
            [EnumMember(Value = "AL")]
            AL = 4,

            /// <summary>
            /// Enum AG for value: AG
            /// </summary>
            [EnumMember(Value = "AG")]
            AG = 5,

            /// <summary>
            /// Enum AQ for value: AQ
            /// </summary>
            [EnumMember(Value = "AQ")]
            AQ = 6,

            /// <summary>
            /// Enum AN for value: AN
            /// </summary>
            [EnumMember(Value = "AN")]
            AN = 7,

            /// <summary>
            /// Enum AO for value: AO
            /// </summary>
            [EnumMember(Value = "AO")]
            AO = 8,

            /// <summary>
            /// Enum AV for value: AV
            /// </summary>
            [EnumMember(Value = "AV")]
            AV = 9,

            /// <summary>
            /// Enum AY for value: AY
            /// </summary>
            [EnumMember(Value = "AY")]
            AY = 10,

            /// <summary>
            /// Enum AC for value: AC
            /// </summary>
            [EnumMember(Value = "AC")]
            AC = 11,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 12,

            /// <summary>
            /// Enum AM for value: AM
            /// </summary>
            [EnumMember(Value = "AM")]
            AM = 13,

            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 14,

            /// <summary>
            /// Enum AT for value: AT
            /// </summary>
            [EnumMember(Value = "AT")]
            AT = 15,

            /// <summary>
            /// Enum AS for value: AS
            /// </summary>
            [EnumMember(Value = "AS")]
            AS = 16,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 17,

            /// <summary>
            /// Enum AJ for value: AJ
            /// </summary>
            [EnumMember(Value = "AJ")]
            AJ = 18,

            /// <summary>
            /// Enum BF for value: BF
            /// </summary>
            [EnumMember(Value = "BF")]
            BF = 19,

            /// <summary>
            /// Enum BA for value: BA
            /// </summary>
            [EnumMember(Value = "BA")]
            BA = 20,

            /// <summary>
            /// Enum FQ for value: FQ
            /// </summary>
            [EnumMember(Value = "FQ")]
            FQ = 21,

            /// <summary>
            /// Enum BG for value: BG
            /// </summary>
            [EnumMember(Value = "BG")]
            BG = 22,

            /// <summary>
            /// Enum BB for value: BB
            /// </summary>
            [EnumMember(Value = "BB")]
            BB = 23,

            /// <summary>
            /// Enum BO for value: BO
            /// </summary>
            [EnumMember(Value = "BO")]
            BO = 24,

            /// <summary>
            /// Enum BE for value: BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BE = 25,

            /// <summary>
            /// Enum BH for value: BH
            /// </summary>
            [EnumMember(Value = "BH")]
            BH = 26,

            /// <summary>
            /// Enum BN for value: BN
            /// </summary>
            [EnumMember(Value = "BN")]
            BN = 27,

            /// <summary>
            /// Enum BD for value: BD
            /// </summary>
            [EnumMember(Value = "BD")]
            BD = 28,

            /// <summary>
            /// Enum BT for value: BT
            /// </summary>
            [EnumMember(Value = "BT")]
            BT = 29,

            /// <summary>
            /// Enum BL for value: BL
            /// </summary>
            [EnumMember(Value = "BL")]
            BL = 30,

            /// <summary>
            /// Enum BK for value: BK
            /// </summary>
            [EnumMember(Value = "BK")]
            BK = 31,

            /// <summary>
            /// Enum BC for value: BC
            /// </summary>
            [EnumMember(Value = "BC")]
            BC = 32,

            /// <summary>
            /// Enum BV for value: BV
            /// </summary>
            [EnumMember(Value = "BV")]
            BV = 33,

            /// <summary>
            /// Enum BR for value: BR
            /// </summary>
            [EnumMember(Value = "BR")]
            BR = 34,

            /// <summary>
            /// Enum IO for value: IO
            /// </summary>
            [EnumMember(Value = "IO")]
            IO = 35,

            /// <summary>
            /// Enum VI for value: VI
            /// </summary>
            [EnumMember(Value = "VI")]
            VI = 36,

            /// <summary>
            /// Enum BX for value: BX
            /// </summary>
            [EnumMember(Value = "BX")]
            BX = 37,

            /// <summary>
            /// Enum BU for value: BU
            /// </summary>
            [EnumMember(Value = "BU")]
            BU = 38,

            /// <summary>
            /// Enum UV for value: UV
            /// </summary>
            [EnumMember(Value = "UV")]
            UV = 39,

            /// <summary>
            /// Enum BM for value: BM
            /// </summary>
            [EnumMember(Value = "BM")]
            BM = 40,

            /// <summary>
            /// Enum BY for value: BY
            /// </summary>
            [EnumMember(Value = "BY")]
            BY = 41,

            /// <summary>
            /// Enum CB for value: CB
            /// </summary>
            [EnumMember(Value = "CB")]
            CB = 42,

            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 43,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 44,

            /// <summary>
            /// Enum CV for value: CV
            /// </summary>
            [EnumMember(Value = "CV")]
            CV = 45,

            /// <summary>
            /// Enum CJ for value: CJ
            /// </summary>
            [EnumMember(Value = "CJ")]
            CJ = 46,

            /// <summary>
            /// Enum CT for value: CT
            /// </summary>
            [EnumMember(Value = "CT")]
            CT = 47,

            /// <summary>
            /// Enum CD for value: CD
            /// </summary>
            [EnumMember(Value = "CD")]
            CD = 48,

            /// <summary>
            /// Enum CI for value: CI
            /// </summary>
            [EnumMember(Value = "CI")]
            CI = 49,

            /// <summary>
            /// Enum CH for value: CH
            /// </summary>
            [EnumMember(Value = "CH")]
            CH = 50,

            /// <summary>
            /// Enum KT for value: KT
            /// </summary>
            [EnumMember(Value = "KT")]
            KT = 51,

            /// <summary>
            /// Enum IP for value: IP
            /// </summary>
            [EnumMember(Value = "IP")]
            IP = 52,

            /// <summary>
            /// Enum CK for value: CK
            /// </summary>
            [EnumMember(Value = "CK")]
            CK = 53,

            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            [EnumMember(Value = "CO")]
            CO = 54,

            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            [EnumMember(Value = "CN")]
            CN = 55,

            /// <summary>
            /// Enum CF for value: CF
            /// </summary>
            [EnumMember(Value = "CF")]
            CF = 56,

            /// <summary>
            /// Enum CG for value: CG
            /// </summary>
            [EnumMember(Value = "CG")]
            CG = 57,

            /// <summary>
            /// Enum CW for value: CW
            /// </summary>
            [EnumMember(Value = "CW")]
            CW = 58,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 59,

            /// <summary>
            /// Enum CS for value: CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CS = 60,

            /// <summary>
            /// Enum IV for value: IV
            /// </summary>
            [EnumMember(Value = "IV")]
            IV = 61,

            /// <summary>
            /// Enum HR for value: HR
            /// </summary>
            [EnumMember(Value = "HR")]
            HR = 62,

            /// <summary>
            /// Enum CU for value: CU
            /// </summary>
            [EnumMember(Value = "CU")]
            CU = 63,

            /// <summary>
            /// Enum UC for value: UC
            /// </summary>
            [EnumMember(Value = "UC")]
            UC = 64,

            /// <summary>
            /// Enum CY for value: CY
            /// </summary>
            [EnumMember(Value = "CY")]
            CY = 65,

            /// <summary>
            /// Enum EZ for value: EZ
            /// </summary>
            [EnumMember(Value = "EZ")]
            EZ = 66,

            /// <summary>
            /// Enum DA for value: DA
            /// </summary>
            [EnumMember(Value = "DA")]
            DA = 67,

            /// <summary>
            /// Enum DX for value: DX
            /// </summary>
            [EnumMember(Value = "DX")]
            DX = 68,

            /// <summary>
            /// Enum DJ for value: DJ
            /// </summary>
            [EnumMember(Value = "DJ")]
            DJ = 69,

            /// <summary>
            /// Enum DO for value: DO
            /// </summary>
            [EnumMember(Value = "DO")]
            DO = 70,

            /// <summary>
            /// Enum DR for value: DR
            /// </summary>
            [EnumMember(Value = "DR")]
            DR = 71,

            /// <summary>
            /// Enum TT for value: TT
            /// </summary>
            [EnumMember(Value = "TT")]
            TT = 72,

            /// <summary>
            /// Enum EC for value: EC
            /// </summary>
            [EnumMember(Value = "EC")]
            EC = 73,

            /// <summary>
            /// Enum EG for value: EG
            /// </summary>
            [EnumMember(Value = "EG")]
            EG = 74,

            /// <summary>
            /// Enum ES for value: ES
            /// </summary>
            [EnumMember(Value = "ES")]
            ES = 75,

            /// <summary>
            /// Enum EK for value: EK
            /// </summary>
            [EnumMember(Value = "EK")]
            EK = 76,

            /// <summary>
            /// Enum ER for value: ER
            /// </summary>
            [EnumMember(Value = "ER")]
            ER = 77,

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            [EnumMember(Value = "EN")]
            EN = 78,

            /// <summary>
            /// Enum ET for value: ET
            /// </summary>
            [EnumMember(Value = "ET")]
            ET = 79,

            /// <summary>
            /// Enum FK for value: FK
            /// </summary>
            [EnumMember(Value = "FK")]
            FK = 80,

            /// <summary>
            /// Enum FO for value: FO
            /// </summary>
            [EnumMember(Value = "FO")]
            FO = 81,

            /// <summary>
            /// Enum FM for value: FM
            /// </summary>
            [EnumMember(Value = "FM")]
            FM = 82,

            /// <summary>
            /// Enum FJ for value: FJ
            /// </summary>
            [EnumMember(Value = "FJ")]
            FJ = 83,

            /// <summary>
            /// Enum FI for value: FI
            /// </summary>
            [EnumMember(Value = "FI")]
            FI = 84,

            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 85,

            /// <summary>
            /// Enum FP for value: FP
            /// </summary>
            [EnumMember(Value = "FP")]
            FP = 86,

            /// <summary>
            /// Enum FS for value: FS
            /// </summary>
            [EnumMember(Value = "FS")]
            FS = 87,

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 88,

            /// <summary>
            /// Enum GA for value: GA
            /// </summary>
            [EnumMember(Value = "GA")]
            GA = 89,

            /// <summary>
            /// Enum GG for value: GG
            /// </summary>
            [EnumMember(Value = "GG")]
            GG = 90,

            /// <summary>
            /// Enum GM for value: GM
            /// </summary>
            [EnumMember(Value = "GM")]
            GM = 91,

            /// <summary>
            /// Enum GH for value: GH
            /// </summary>
            [EnumMember(Value = "GH")]
            GH = 92,

            /// <summary>
            /// Enum GI for value: GI
            /// </summary>
            [EnumMember(Value = "GI")]
            GI = 93,

            /// <summary>
            /// Enum GR for value: GR
            /// </summary>
            [EnumMember(Value = "GR")]
            GR = 94,

            /// <summary>
            /// Enum GL for value: GL
            /// </summary>
            [EnumMember(Value = "GL")]
            GL = 95,

            /// <summary>
            /// Enum GJ for value: GJ
            /// </summary>
            [EnumMember(Value = "GJ")]
            GJ = 96,

            /// <summary>
            /// Enum GQ for value: GQ
            /// </summary>
            [EnumMember(Value = "GQ")]
            GQ = 97,

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            [EnumMember(Value = "GT")]
            GT = 98,

            /// <summary>
            /// Enum GK for value: GK
            /// </summary>
            [EnumMember(Value = "GK")]
            GK = 99,

            /// <summary>
            /// Enum GV for value: GV
            /// </summary>
            [EnumMember(Value = "GV")]
            GV = 100,

            /// <summary>
            /// Enum PU for value: PU
            /// </summary>
            [EnumMember(Value = "PU")]
            PU = 101,

            /// <summary>
            /// Enum GY for value: GY
            /// </summary>
            [EnumMember(Value = "GY")]
            GY = 102,

            /// <summary>
            /// Enum HA for value: HA
            /// </summary>
            [EnumMember(Value = "HA")]
            HA = 103,

            /// <summary>
            /// Enum HM for value: HM
            /// </summary>
            [EnumMember(Value = "HM")]
            HM = 104,

            /// <summary>
            /// Enum VT for value: VT
            /// </summary>
            [EnumMember(Value = "VT")]
            VT = 105,

            /// <summary>
            /// Enum HO for value: HO
            /// </summary>
            [EnumMember(Value = "HO")]
            HO = 106,

            /// <summary>
            /// Enum HK for value: HK
            /// </summary>
            [EnumMember(Value = "HK")]
            HK = 107,

            /// <summary>
            /// Enum HQ for value: HQ
            /// </summary>
            [EnumMember(Value = "HQ")]
            HQ = 108,

            /// <summary>
            /// Enum HU for value: HU
            /// </summary>
            [EnumMember(Value = "HU")]
            HU = 109,

            /// <summary>
            /// Enum IC for value: IC
            /// </summary>
            [EnumMember(Value = "IC")]
            IC = 110,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 111,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 112,

            /// <summary>
            /// Enum IR for value: IR
            /// </summary>
            [EnumMember(Value = "IR")]
            IR = 113,

            /// <summary>
            /// Enum IZ for value: IZ
            /// </summary>
            [EnumMember(Value = "IZ")]
            IZ = 114,

            /// <summary>
            /// Enum EI for value: EI
            /// </summary>
            [EnumMember(Value = "EI")]
            EI = 115,

            /// <summary>
            /// Enum IS for value: IS
            /// </summary>
            [EnumMember(Value = "IS")]
            IS = 116,

            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 117,

            /// <summary>
            /// Enum JM for value: JM
            /// </summary>
            [EnumMember(Value = "JM")]
            JM = 118,

            /// <summary>
            /// Enum JN for value: JN
            /// </summary>
            [EnumMember(Value = "JN")]
            JN = 119,

            /// <summary>
            /// Enum JA for value: JA
            /// </summary>
            [EnumMember(Value = "JA")]
            JA = 120,

            /// <summary>
            /// Enum DQ for value: DQ
            /// </summary>
            [EnumMember(Value = "DQ")]
            DQ = 121,

            /// <summary>
            /// Enum JE for value: JE
            /// </summary>
            [EnumMember(Value = "JE")]
            JE = 122,

            /// <summary>
            /// Enum JQ for value: JQ
            /// </summary>
            [EnumMember(Value = "JQ")]
            JQ = 123,

            /// <summary>
            /// Enum JO for value: JO
            /// </summary>
            [EnumMember(Value = "JO")]
            JO = 124,

            /// <summary>
            /// Enum KZ for value: KZ
            /// </summary>
            [EnumMember(Value = "KZ")]
            KZ = 125,

            /// <summary>
            /// Enum KE for value: KE
            /// </summary>
            [EnumMember(Value = "KE")]
            KE = 126,

            /// <summary>
            /// Enum KQ for value: KQ
            /// </summary>
            [EnumMember(Value = "KQ")]
            KQ = 127,

            /// <summary>
            /// Enum KR for value: KR
            /// </summary>
            [EnumMember(Value = "KR")]
            KR = 128,

            /// <summary>
            /// Enum KN for value: KN
            /// </summary>
            [EnumMember(Value = "KN")]
            KN = 129,

            /// <summary>
            /// Enum KS for value: KS
            /// </summary>
            [EnumMember(Value = "KS")]
            KS = 130,

            /// <summary>
            /// Enum KV for value: KV
            /// </summary>
            [EnumMember(Value = "KV")]
            KV = 131,

            /// <summary>
            /// Enum KU for value: KU
            /// </summary>
            [EnumMember(Value = "KU")]
            KU = 132,

            /// <summary>
            /// Enum KG for value: KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KG = 133,

            /// <summary>
            /// Enum LA for value: LA
            /// </summary>
            [EnumMember(Value = "LA")]
            LA = 134,

            /// <summary>
            /// Enum LG for value: LG
            /// </summary>
            [EnumMember(Value = "LG")]
            LG = 135,

            /// <summary>
            /// Enum LE for value: LE
            /// </summary>
            [EnumMember(Value = "LE")]
            LE = 136,

            /// <summary>
            /// Enum LT for value: LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LT = 137,

            /// <summary>
            /// Enum LI for value: LI
            /// </summary>
            [EnumMember(Value = "LI")]
            LI = 138,

            /// <summary>
            /// Enum LY for value: LY
            /// </summary>
            [EnumMember(Value = "LY")]
            LY = 139,

            /// <summary>
            /// Enum LS for value: LS
            /// </summary>
            [EnumMember(Value = "LS")]
            LS = 140,

            /// <summary>
            /// Enum LH for value: LH
            /// </summary>
            [EnumMember(Value = "LH")]
            LH = 141,

            /// <summary>
            /// Enum LU for value: LU
            /// </summary>
            [EnumMember(Value = "LU")]
            LU = 142,

            /// <summary>
            /// Enum MC for value: MC
            /// </summary>
            [EnumMember(Value = "MC")]
            MC = 143,

            /// <summary>
            /// Enum MK for value: MK
            /// </summary>
            [EnumMember(Value = "MK")]
            MK = 144,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 145,

            /// <summary>
            /// Enum MI for value: MI
            /// </summary>
            [EnumMember(Value = "MI")]
            MI = 146,

            /// <summary>
            /// Enum MY for value: MY
            /// </summary>
            [EnumMember(Value = "MY")]
            MY = 147,

            /// <summary>
            /// Enum MV for value: MV
            /// </summary>
            [EnumMember(Value = "MV")]
            MV = 148,

            /// <summary>
            /// Enum ML for value: ML
            /// </summary>
            [EnumMember(Value = "ML")]
            ML = 149,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 150,

            /// <summary>
            /// Enum IM for value: IM
            /// </summary>
            [EnumMember(Value = "IM")]
            IM = 151,

            /// <summary>
            /// Enum RM for value: RM
            /// </summary>
            [EnumMember(Value = "RM")]
            RM = 152,

            /// <summary>
            /// Enum MR for value: MR
            /// </summary>
            [EnumMember(Value = "MR")]
            MR = 153,

            /// <summary>
            /// Enum MP for value: MP
            /// </summary>
            [EnumMember(Value = "MP")]
            MP = 154,

            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 155,

            /// <summary>
            /// Enum MQ for value: MQ
            /// </summary>
            [EnumMember(Value = "MQ")]
            MQ = 156,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 157,

            /// <summary>
            /// Enum MN for value: MN
            /// </summary>
            [EnumMember(Value = "MN")]
            MN = 158,

            /// <summary>
            /// Enum MG for value: MG
            /// </summary>
            [EnumMember(Value = "MG")]
            MG = 159,

            /// <summary>
            /// Enum MJ for value: MJ
            /// </summary>
            [EnumMember(Value = "MJ")]
            MJ = 160,

            /// <summary>
            /// Enum MH for value: MH
            /// </summary>
            [EnumMember(Value = "MH")]
            MH = 161,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 162,

            /// <summary>
            /// Enum MZ for value: MZ
            /// </summary>
            [EnumMember(Value = "MZ")]
            MZ = 163,

            /// <summary>
            /// Enum WA for value: WA
            /// </summary>
            [EnumMember(Value = "WA")]
            WA = 164,

            /// <summary>
            /// Enum NR for value: NR
            /// </summary>
            [EnumMember(Value = "NR")]
            NR = 165,

            /// <summary>
            /// Enum BQ for value: BQ
            /// </summary>
            [EnumMember(Value = "BQ")]
            BQ = 166,

            /// <summary>
            /// Enum NP for value: NP
            /// </summary>
            [EnumMember(Value = "NP")]
            NP = 167,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 168,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 169,

            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 170,

            /// <summary>
            /// Enum NU for value: NU
            /// </summary>
            [EnumMember(Value = "NU")]
            NU = 171,

            /// <summary>
            /// Enum NG for value: NG
            /// </summary>
            [EnumMember(Value = "NG")]
            NG = 172,

            /// <summary>
            /// Enum NI for value: NI
            /// </summary>
            [EnumMember(Value = "NI")]
            NI = 173,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 174,

            /// <summary>
            /// Enum NF for value: NF
            /// </summary>
            [EnumMember(Value = "NF")]
            NF = 175,

            /// <summary>
            /// Enum CQ for value: CQ
            /// </summary>
            [EnumMember(Value = "CQ")]
            CQ = 176,

            /// <summary>
            /// Enum NO for value: NO
            /// </summary>
            [EnumMember(Value = "NO")]
            NO = 177,

            /// <summary>
            /// Enum MU for value: MU
            /// </summary>
            [EnumMember(Value = "MU")]
            MU = 178,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 179,

            /// <summary>
            /// Enum PK for value: PK
            /// </summary>
            [EnumMember(Value = "PK")]
            PK = 180,

            /// <summary>
            /// Enum PS for value: PS
            /// </summary>
            [EnumMember(Value = "PS")]
            PS = 181,

            /// <summary>
            /// Enum LQ for value: LQ
            /// </summary>
            [EnumMember(Value = "LQ")]
            LQ = 182,

            /// <summary>
            /// Enum PM for value: PM
            /// </summary>
            [EnumMember(Value = "PM")]
            PM = 183,

            /// <summary>
            /// Enum PP for value: PP
            /// </summary>
            [EnumMember(Value = "PP")]
            PP = 184,

            /// <summary>
            /// Enum PF for value: PF
            /// </summary>
            [EnumMember(Value = "PF")]
            PF = 185,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 186,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 187,

            /// <summary>
            /// Enum RP for value: RP
            /// </summary>
            [EnumMember(Value = "RP")]
            RP = 188,

            /// <summary>
            /// Enum PC for value: PC
            /// </summary>
            [EnumMember(Value = "PC")]
            PC = 189,

            /// <summary>
            /// Enum PL for value: PL
            /// </summary>
            [EnumMember(Value = "PL")]
            PL = 190,

            /// <summary>
            /// Enum PO for value: PO
            /// </summary>
            [EnumMember(Value = "PO")]
            PO = 191,

            /// <summary>
            /// Enum RQ for value: RQ
            /// </summary>
            [EnumMember(Value = "RQ")]
            RQ = 192,

            /// <summary>
            /// Enum QA for value: QA
            /// </summary>
            [EnumMember(Value = "QA")]
            QA = 193,

            /// <summary>
            /// Enum RO for value: RO
            /// </summary>
            [EnumMember(Value = "RO")]
            RO = 194,

            /// <summary>
            /// Enum RS for value: RS
            /// </summary>
            [EnumMember(Value = "RS")]
            RS = 195,

            /// <summary>
            /// Enum RW for value: RW
            /// </summary>
            [EnumMember(Value = "RW")]
            RW = 196,

            /// <summary>
            /// Enum TB for value: TB
            /// </summary>
            [EnumMember(Value = "TB")]
            TB = 197,

            /// <summary>
            /// Enum RN for value: RN
            /// </summary>
            [EnumMember(Value = "RN")]
            RN = 198,

            /// <summary>
            /// Enum WS for value: WS
            /// </summary>
            [EnumMember(Value = "WS")]
            WS = 199,

            /// <summary>
            /// Enum SM for value: SM
            /// </summary>
            [EnumMember(Value = "SM")]
            SM = 200,

            /// <summary>
            /// Enum TP for value: TP
            /// </summary>
            [EnumMember(Value = "TP")]
            TP = 201,

            /// <summary>
            /// Enum SA for value: SA
            /// </summary>
            [EnumMember(Value = "SA")]
            SA = 202,

            /// <summary>
            /// Enum SG for value: SG
            /// </summary>
            [EnumMember(Value = "SG")]
            SG = 203,

            /// <summary>
            /// Enum RI for value: RI
            /// </summary>
            [EnumMember(Value = "RI")]
            RI = 204,

            /// <summary>
            /// Enum SE for value: SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SE = 205,

            /// <summary>
            /// Enum SL for value: SL
            /// </summary>
            [EnumMember(Value = "SL")]
            SL = 206,

            /// <summary>
            /// Enum SN for value: SN
            /// </summary>
            [EnumMember(Value = "SN")]
            SN = 207,

            /// <summary>
            /// Enum NN for value: NN
            /// </summary>
            [EnumMember(Value = "NN")]
            NN = 208,

            /// <summary>
            /// Enum LO for value: LO
            /// </summary>
            [EnumMember(Value = "LO")]
            LO = 209,

            /// <summary>
            /// Enum SI for value: SI
            /// </summary>
            [EnumMember(Value = "SI")]
            SI = 210,

            /// <summary>
            /// Enum BP for value: BP
            /// </summary>
            [EnumMember(Value = "BP")]
            BP = 211,

            /// <summary>
            /// Enum SO for value: SO
            /// </summary>
            [EnumMember(Value = "SO")]
            SO = 212,

            /// <summary>
            /// Enum SF for value: SF
            /// </summary>
            [EnumMember(Value = "SF")]
            SF = 213,

            /// <summary>
            /// Enum SX for value: SX
            /// </summary>
            [EnumMember(Value = "SX")]
            SX = 214,

            /// <summary>
            /// Enum SP for value: SP
            /// </summary>
            [EnumMember(Value = "SP")]
            SP = 215,

            /// <summary>
            /// Enum PG for value: PG
            /// </summary>
            [EnumMember(Value = "PG")]
            PG = 216,

            /// <summary>
            /// Enum CE for value: CE
            /// </summary>
            [EnumMember(Value = "CE")]
            CE = 217,

            /// <summary>
            /// Enum SH for value: SH
            /// </summary>
            [EnumMember(Value = "SH")]
            SH = 218,

            /// <summary>
            /// Enum SC for value: SC
            /// </summary>
            [EnumMember(Value = "SC")]
            SC = 219,

            /// <summary>
            /// Enum ST for value: ST
            /// </summary>
            [EnumMember(Value = "ST")]
            ST = 220,

            /// <summary>
            /// Enum SB for value: SB
            /// </summary>
            [EnumMember(Value = "SB")]
            SB = 221,

            /// <summary>
            /// Enum VC for value: VC
            /// </summary>
            [EnumMember(Value = "VC")]
            VC = 222,

            /// <summary>
            /// Enum SU for value: SU
            /// </summary>
            [EnumMember(Value = "SU")]
            SU = 223,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 224,

            /// <summary>
            /// Enum SV for value: SV
            /// </summary>
            [EnumMember(Value = "SV")]
            SV = 225,

            /// <summary>
            /// Enum WZ for value: WZ
            /// </summary>
            [EnumMember(Value = "WZ")]
            WZ = 226,

            /// <summary>
            /// Enum SW for value: SW
            /// </summary>
            [EnumMember(Value = "SW")]
            SW = 227,

            /// <summary>
            /// Enum SZ for value: SZ
            /// </summary>
            [EnumMember(Value = "SZ")]
            SZ = 228,

            /// <summary>
            /// Enum SY for value: SY
            /// </summary>
            [EnumMember(Value = "SY")]
            SY = 229,

            /// <summary>
            /// Enum TW for value: TW
            /// </summary>
            [EnumMember(Value = "TW")]
            TW = 230,

            /// <summary>
            /// Enum TI for value: TI
            /// </summary>
            [EnumMember(Value = "TI")]
            TI = 231,

            /// <summary>
            /// Enum TZ for value: TZ
            /// </summary>
            [EnumMember(Value = "TZ")]
            TZ = 232,

            /// <summary>
            /// Enum TH for value: TH
            /// </summary>
            [EnumMember(Value = "TH")]
            TH = 233,

            /// <summary>
            /// Enum TO for value: TO
            /// </summary>
            [EnumMember(Value = "TO")]
            TO = 234,

            /// <summary>
            /// Enum TL for value: TL
            /// </summary>
            [EnumMember(Value = "TL")]
            TL = 235,

            /// <summary>
            /// Enum TN for value: TN
            /// </summary>
            [EnumMember(Value = "TN")]
            TN = 236,

            /// <summary>
            /// Enum TD for value: TD
            /// </summary>
            [EnumMember(Value = "TD")]
            TD = 237,

            /// <summary>
            /// Enum TS for value: TS
            /// </summary>
            [EnumMember(Value = "TS")]
            TS = 238,

            /// <summary>
            /// Enum TU for value: TU
            /// </summary>
            [EnumMember(Value = "TU")]
            TU = 239,

            /// <summary>
            /// Enum TX for value: TX
            /// </summary>
            [EnumMember(Value = "TX")]
            TX = 240,

            /// <summary>
            /// Enum TK for value: TK
            /// </summary>
            [EnumMember(Value = "TK")]
            TK = 241,

            /// <summary>
            /// Enum TV for value: TV
            /// </summary>
            [EnumMember(Value = "TV")]
            TV = 242,

            /// <summary>
            /// Enum UG for value: UG
            /// </summary>
            [EnumMember(Value = "UG")]
            UG = 243,

            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            [EnumMember(Value = "UP")]
            UP = 244,

            /// <summary>
            /// Enum AE for value: AE
            /// </summary>
            [EnumMember(Value = "AE")]
            AE = 245,

            /// <summary>
            /// Enum UK for value: UK
            /// </summary>
            [EnumMember(Value = "UK")]
            UK = 246,

            /// <summary>
            /// Enum UY for value: UY
            /// </summary>
            [EnumMember(Value = "UY")]
            UY = 247,

            /// <summary>
            /// Enum UZ for value: UZ
            /// </summary>
            [EnumMember(Value = "UZ")]
            UZ = 248,

            /// <summary>
            /// Enum NH for value: NH
            /// </summary>
            [EnumMember(Value = "NH")]
            NH = 249,

            /// <summary>
            /// Enum VE for value: VE
            /// </summary>
            [EnumMember(Value = "VE")]
            VE = 250,

            /// <summary>
            /// Enum VM for value: VM
            /// </summary>
            [EnumMember(Value = "VM")]
            VM = 251,

            /// <summary>
            /// Enum VQ for value: VQ
            /// </summary>
            [EnumMember(Value = "VQ")]
            VQ = 252,

            /// <summary>
            /// Enum WQ for value: WQ
            /// </summary>
            [EnumMember(Value = "WQ")]
            WQ = 253,

            /// <summary>
            /// Enum WF for value: WF
            /// </summary>
            [EnumMember(Value = "WF")]
            WF = 254,

            /// <summary>
            /// Enum WI for value: WI
            /// </summary>
            [EnumMember(Value = "WI")]
            WI = 255,

            /// <summary>
            /// Enum YM for value: YM
            /// </summary>
            [EnumMember(Value = "YM")]
            YM = 256,

            /// <summary>
            /// Enum ZA for value: ZA
            /// </summary>
            [EnumMember(Value = "ZA")]
            ZA = 257,

            /// <summary>
            /// Enum ZI for value: ZI
            /// </summary>
            [EnumMember(Value = "ZI")]
            ZI = 258
        }


        /// <summary>
        /// The country of residence.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country of residence.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [DataMember(Name = "residenceCountry", IsRequired = true, EmitDefaultValue = true)]
        public ResidenceCountryEnum ResidenceCountry { get; set; }
        /// <summary>
        /// The state of the mailing address. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)
        /// </summary>
        /// <value>The state of the mailing address. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MailingStateEnum
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
            WY = 62,

            /// <summary>
            /// Enum AB for value: AB
            /// </summary>
            [EnumMember(Value = "AB")]
            AB = 63,

            /// <summary>
            /// Enum BC for value: BC
            /// </summary>
            [EnumMember(Value = "BC")]
            BC = 64,

            /// <summary>
            /// Enum MB for value: MB
            /// </summary>
            [EnumMember(Value = "MB")]
            MB = 65,

            /// <summary>
            /// Enum NB for value: NB
            /// </summary>
            [EnumMember(Value = "NB")]
            NB = 66,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 67,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 68,

            /// <summary>
            /// Enum NT for value: NT
            /// </summary>
            [EnumMember(Value = "NT")]
            NT = 69,

            /// <summary>
            /// Enum NU for value: NU
            /// </summary>
            [EnumMember(Value = "NU")]
            NU = 70,

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            [EnumMember(Value = "ON")]
            ON = 71,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 72,

            /// <summary>
            /// Enum QC for value: QC
            /// </summary>
            [EnumMember(Value = "QC")]
            QC = 73,

            /// <summary>
            /// Enum SK for value: SK
            /// </summary>
            [EnumMember(Value = "SK")]
            SK = 74,

            /// <summary>
            /// Enum YT for value: YT
            /// </summary>
            [EnumMember(Value = "YT")]
            YT = 75
        }


        /// <summary>
        /// The state of the mailing address. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)
        /// </summary>
        /// <value>The state of the mailing address. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more)</value>
        [DataMember(Name = "mailingState", EmitDefaultValue = true)]
        public MailingStateEnum? MailingState { get; set; }
        /// <summary>
        /// The country of the mailing address.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country of the mailing address.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MailingCountryEnum
        {
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 1,

            /// <summary>
            /// Enum AF for value: AF
            /// </summary>
            [EnumMember(Value = "AF")]
            AF = 2,

            /// <summary>
            /// Enum AX for value: AX
            /// </summary>
            [EnumMember(Value = "AX")]
            AX = 3,

            /// <summary>
            /// Enum AL for value: AL
            /// </summary>
            [EnumMember(Value = "AL")]
            AL = 4,

            /// <summary>
            /// Enum AG for value: AG
            /// </summary>
            [EnumMember(Value = "AG")]
            AG = 5,

            /// <summary>
            /// Enum AQ for value: AQ
            /// </summary>
            [EnumMember(Value = "AQ")]
            AQ = 6,

            /// <summary>
            /// Enum AN for value: AN
            /// </summary>
            [EnumMember(Value = "AN")]
            AN = 7,

            /// <summary>
            /// Enum AO for value: AO
            /// </summary>
            [EnumMember(Value = "AO")]
            AO = 8,

            /// <summary>
            /// Enum AV for value: AV
            /// </summary>
            [EnumMember(Value = "AV")]
            AV = 9,

            /// <summary>
            /// Enum AY for value: AY
            /// </summary>
            [EnumMember(Value = "AY")]
            AY = 10,

            /// <summary>
            /// Enum AC for value: AC
            /// </summary>
            [EnumMember(Value = "AC")]
            AC = 11,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 12,

            /// <summary>
            /// Enum AM for value: AM
            /// </summary>
            [EnumMember(Value = "AM")]
            AM = 13,

            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 14,

            /// <summary>
            /// Enum AT for value: AT
            /// </summary>
            [EnumMember(Value = "AT")]
            AT = 15,

            /// <summary>
            /// Enum AS for value: AS
            /// </summary>
            [EnumMember(Value = "AS")]
            AS = 16,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 17,

            /// <summary>
            /// Enum AJ for value: AJ
            /// </summary>
            [EnumMember(Value = "AJ")]
            AJ = 18,

            /// <summary>
            /// Enum BF for value: BF
            /// </summary>
            [EnumMember(Value = "BF")]
            BF = 19,

            /// <summary>
            /// Enum BA for value: BA
            /// </summary>
            [EnumMember(Value = "BA")]
            BA = 20,

            /// <summary>
            /// Enum FQ for value: FQ
            /// </summary>
            [EnumMember(Value = "FQ")]
            FQ = 21,

            /// <summary>
            /// Enum BG for value: BG
            /// </summary>
            [EnumMember(Value = "BG")]
            BG = 22,

            /// <summary>
            /// Enum BB for value: BB
            /// </summary>
            [EnumMember(Value = "BB")]
            BB = 23,

            /// <summary>
            /// Enum BO for value: BO
            /// </summary>
            [EnumMember(Value = "BO")]
            BO = 24,

            /// <summary>
            /// Enum BE for value: BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BE = 25,

            /// <summary>
            /// Enum BH for value: BH
            /// </summary>
            [EnumMember(Value = "BH")]
            BH = 26,

            /// <summary>
            /// Enum BN for value: BN
            /// </summary>
            [EnumMember(Value = "BN")]
            BN = 27,

            /// <summary>
            /// Enum BD for value: BD
            /// </summary>
            [EnumMember(Value = "BD")]
            BD = 28,

            /// <summary>
            /// Enum BT for value: BT
            /// </summary>
            [EnumMember(Value = "BT")]
            BT = 29,

            /// <summary>
            /// Enum BL for value: BL
            /// </summary>
            [EnumMember(Value = "BL")]
            BL = 30,

            /// <summary>
            /// Enum BK for value: BK
            /// </summary>
            [EnumMember(Value = "BK")]
            BK = 31,

            /// <summary>
            /// Enum BC for value: BC
            /// </summary>
            [EnumMember(Value = "BC")]
            BC = 32,

            /// <summary>
            /// Enum BV for value: BV
            /// </summary>
            [EnumMember(Value = "BV")]
            BV = 33,

            /// <summary>
            /// Enum BR for value: BR
            /// </summary>
            [EnumMember(Value = "BR")]
            BR = 34,

            /// <summary>
            /// Enum IO for value: IO
            /// </summary>
            [EnumMember(Value = "IO")]
            IO = 35,

            /// <summary>
            /// Enum VI for value: VI
            /// </summary>
            [EnumMember(Value = "VI")]
            VI = 36,

            /// <summary>
            /// Enum BX for value: BX
            /// </summary>
            [EnumMember(Value = "BX")]
            BX = 37,

            /// <summary>
            /// Enum BU for value: BU
            /// </summary>
            [EnumMember(Value = "BU")]
            BU = 38,

            /// <summary>
            /// Enum UV for value: UV
            /// </summary>
            [EnumMember(Value = "UV")]
            UV = 39,

            /// <summary>
            /// Enum BM for value: BM
            /// </summary>
            [EnumMember(Value = "BM")]
            BM = 40,

            /// <summary>
            /// Enum BY for value: BY
            /// </summary>
            [EnumMember(Value = "BY")]
            BY = 41,

            /// <summary>
            /// Enum CB for value: CB
            /// </summary>
            [EnumMember(Value = "CB")]
            CB = 42,

            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 43,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 44,

            /// <summary>
            /// Enum CV for value: CV
            /// </summary>
            [EnumMember(Value = "CV")]
            CV = 45,

            /// <summary>
            /// Enum CJ for value: CJ
            /// </summary>
            [EnumMember(Value = "CJ")]
            CJ = 46,

            /// <summary>
            /// Enum CT for value: CT
            /// </summary>
            [EnumMember(Value = "CT")]
            CT = 47,

            /// <summary>
            /// Enum CD for value: CD
            /// </summary>
            [EnumMember(Value = "CD")]
            CD = 48,

            /// <summary>
            /// Enum CI for value: CI
            /// </summary>
            [EnumMember(Value = "CI")]
            CI = 49,

            /// <summary>
            /// Enum CH for value: CH
            /// </summary>
            [EnumMember(Value = "CH")]
            CH = 50,

            /// <summary>
            /// Enum KT for value: KT
            /// </summary>
            [EnumMember(Value = "KT")]
            KT = 51,

            /// <summary>
            /// Enum IP for value: IP
            /// </summary>
            [EnumMember(Value = "IP")]
            IP = 52,

            /// <summary>
            /// Enum CK for value: CK
            /// </summary>
            [EnumMember(Value = "CK")]
            CK = 53,

            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            [EnumMember(Value = "CO")]
            CO = 54,

            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            [EnumMember(Value = "CN")]
            CN = 55,

            /// <summary>
            /// Enum CF for value: CF
            /// </summary>
            [EnumMember(Value = "CF")]
            CF = 56,

            /// <summary>
            /// Enum CG for value: CG
            /// </summary>
            [EnumMember(Value = "CG")]
            CG = 57,

            /// <summary>
            /// Enum CW for value: CW
            /// </summary>
            [EnumMember(Value = "CW")]
            CW = 58,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 59,

            /// <summary>
            /// Enum CS for value: CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CS = 60,

            /// <summary>
            /// Enum IV for value: IV
            /// </summary>
            [EnumMember(Value = "IV")]
            IV = 61,

            /// <summary>
            /// Enum HR for value: HR
            /// </summary>
            [EnumMember(Value = "HR")]
            HR = 62,

            /// <summary>
            /// Enum CU for value: CU
            /// </summary>
            [EnumMember(Value = "CU")]
            CU = 63,

            /// <summary>
            /// Enum UC for value: UC
            /// </summary>
            [EnumMember(Value = "UC")]
            UC = 64,

            /// <summary>
            /// Enum CY for value: CY
            /// </summary>
            [EnumMember(Value = "CY")]
            CY = 65,

            /// <summary>
            /// Enum EZ for value: EZ
            /// </summary>
            [EnumMember(Value = "EZ")]
            EZ = 66,

            /// <summary>
            /// Enum DA for value: DA
            /// </summary>
            [EnumMember(Value = "DA")]
            DA = 67,

            /// <summary>
            /// Enum DX for value: DX
            /// </summary>
            [EnumMember(Value = "DX")]
            DX = 68,

            /// <summary>
            /// Enum DJ for value: DJ
            /// </summary>
            [EnumMember(Value = "DJ")]
            DJ = 69,

            /// <summary>
            /// Enum DO for value: DO
            /// </summary>
            [EnumMember(Value = "DO")]
            DO = 70,

            /// <summary>
            /// Enum DR for value: DR
            /// </summary>
            [EnumMember(Value = "DR")]
            DR = 71,

            /// <summary>
            /// Enum TT for value: TT
            /// </summary>
            [EnumMember(Value = "TT")]
            TT = 72,

            /// <summary>
            /// Enum EC for value: EC
            /// </summary>
            [EnumMember(Value = "EC")]
            EC = 73,

            /// <summary>
            /// Enum EG for value: EG
            /// </summary>
            [EnumMember(Value = "EG")]
            EG = 74,

            /// <summary>
            /// Enum ES for value: ES
            /// </summary>
            [EnumMember(Value = "ES")]
            ES = 75,

            /// <summary>
            /// Enum EK for value: EK
            /// </summary>
            [EnumMember(Value = "EK")]
            EK = 76,

            /// <summary>
            /// Enum ER for value: ER
            /// </summary>
            [EnumMember(Value = "ER")]
            ER = 77,

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            [EnumMember(Value = "EN")]
            EN = 78,

            /// <summary>
            /// Enum ET for value: ET
            /// </summary>
            [EnumMember(Value = "ET")]
            ET = 79,

            /// <summary>
            /// Enum FK for value: FK
            /// </summary>
            [EnumMember(Value = "FK")]
            FK = 80,

            /// <summary>
            /// Enum FO for value: FO
            /// </summary>
            [EnumMember(Value = "FO")]
            FO = 81,

            /// <summary>
            /// Enum FM for value: FM
            /// </summary>
            [EnumMember(Value = "FM")]
            FM = 82,

            /// <summary>
            /// Enum FJ for value: FJ
            /// </summary>
            [EnumMember(Value = "FJ")]
            FJ = 83,

            /// <summary>
            /// Enum FI for value: FI
            /// </summary>
            [EnumMember(Value = "FI")]
            FI = 84,

            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 85,

            /// <summary>
            /// Enum FP for value: FP
            /// </summary>
            [EnumMember(Value = "FP")]
            FP = 86,

            /// <summary>
            /// Enum FS for value: FS
            /// </summary>
            [EnumMember(Value = "FS")]
            FS = 87,

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 88,

            /// <summary>
            /// Enum GA for value: GA
            /// </summary>
            [EnumMember(Value = "GA")]
            GA = 89,

            /// <summary>
            /// Enum GG for value: GG
            /// </summary>
            [EnumMember(Value = "GG")]
            GG = 90,

            /// <summary>
            /// Enum GM for value: GM
            /// </summary>
            [EnumMember(Value = "GM")]
            GM = 91,

            /// <summary>
            /// Enum GH for value: GH
            /// </summary>
            [EnumMember(Value = "GH")]
            GH = 92,

            /// <summary>
            /// Enum GI for value: GI
            /// </summary>
            [EnumMember(Value = "GI")]
            GI = 93,

            /// <summary>
            /// Enum GR for value: GR
            /// </summary>
            [EnumMember(Value = "GR")]
            GR = 94,

            /// <summary>
            /// Enum GL for value: GL
            /// </summary>
            [EnumMember(Value = "GL")]
            GL = 95,

            /// <summary>
            /// Enum GJ for value: GJ
            /// </summary>
            [EnumMember(Value = "GJ")]
            GJ = 96,

            /// <summary>
            /// Enum GQ for value: GQ
            /// </summary>
            [EnumMember(Value = "GQ")]
            GQ = 97,

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            [EnumMember(Value = "GT")]
            GT = 98,

            /// <summary>
            /// Enum GK for value: GK
            /// </summary>
            [EnumMember(Value = "GK")]
            GK = 99,

            /// <summary>
            /// Enum GV for value: GV
            /// </summary>
            [EnumMember(Value = "GV")]
            GV = 100,

            /// <summary>
            /// Enum PU for value: PU
            /// </summary>
            [EnumMember(Value = "PU")]
            PU = 101,

            /// <summary>
            /// Enum GY for value: GY
            /// </summary>
            [EnumMember(Value = "GY")]
            GY = 102,

            /// <summary>
            /// Enum HA for value: HA
            /// </summary>
            [EnumMember(Value = "HA")]
            HA = 103,

            /// <summary>
            /// Enum HM for value: HM
            /// </summary>
            [EnumMember(Value = "HM")]
            HM = 104,

            /// <summary>
            /// Enum VT for value: VT
            /// </summary>
            [EnumMember(Value = "VT")]
            VT = 105,

            /// <summary>
            /// Enum HO for value: HO
            /// </summary>
            [EnumMember(Value = "HO")]
            HO = 106,

            /// <summary>
            /// Enum HK for value: HK
            /// </summary>
            [EnumMember(Value = "HK")]
            HK = 107,

            /// <summary>
            /// Enum HQ for value: HQ
            /// </summary>
            [EnumMember(Value = "HQ")]
            HQ = 108,

            /// <summary>
            /// Enum HU for value: HU
            /// </summary>
            [EnumMember(Value = "HU")]
            HU = 109,

            /// <summary>
            /// Enum IC for value: IC
            /// </summary>
            [EnumMember(Value = "IC")]
            IC = 110,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 111,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 112,

            /// <summary>
            /// Enum IR for value: IR
            /// </summary>
            [EnumMember(Value = "IR")]
            IR = 113,

            /// <summary>
            /// Enum IZ for value: IZ
            /// </summary>
            [EnumMember(Value = "IZ")]
            IZ = 114,

            /// <summary>
            /// Enum EI for value: EI
            /// </summary>
            [EnumMember(Value = "EI")]
            EI = 115,

            /// <summary>
            /// Enum IS for value: IS
            /// </summary>
            [EnumMember(Value = "IS")]
            IS = 116,

            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 117,

            /// <summary>
            /// Enum JM for value: JM
            /// </summary>
            [EnumMember(Value = "JM")]
            JM = 118,

            /// <summary>
            /// Enum JN for value: JN
            /// </summary>
            [EnumMember(Value = "JN")]
            JN = 119,

            /// <summary>
            /// Enum JA for value: JA
            /// </summary>
            [EnumMember(Value = "JA")]
            JA = 120,

            /// <summary>
            /// Enum DQ for value: DQ
            /// </summary>
            [EnumMember(Value = "DQ")]
            DQ = 121,

            /// <summary>
            /// Enum JE for value: JE
            /// </summary>
            [EnumMember(Value = "JE")]
            JE = 122,

            /// <summary>
            /// Enum JQ for value: JQ
            /// </summary>
            [EnumMember(Value = "JQ")]
            JQ = 123,

            /// <summary>
            /// Enum JO for value: JO
            /// </summary>
            [EnumMember(Value = "JO")]
            JO = 124,

            /// <summary>
            /// Enum KZ for value: KZ
            /// </summary>
            [EnumMember(Value = "KZ")]
            KZ = 125,

            /// <summary>
            /// Enum KE for value: KE
            /// </summary>
            [EnumMember(Value = "KE")]
            KE = 126,

            /// <summary>
            /// Enum KQ for value: KQ
            /// </summary>
            [EnumMember(Value = "KQ")]
            KQ = 127,

            /// <summary>
            /// Enum KR for value: KR
            /// </summary>
            [EnumMember(Value = "KR")]
            KR = 128,

            /// <summary>
            /// Enum KN for value: KN
            /// </summary>
            [EnumMember(Value = "KN")]
            KN = 129,

            /// <summary>
            /// Enum KS for value: KS
            /// </summary>
            [EnumMember(Value = "KS")]
            KS = 130,

            /// <summary>
            /// Enum KV for value: KV
            /// </summary>
            [EnumMember(Value = "KV")]
            KV = 131,

            /// <summary>
            /// Enum KU for value: KU
            /// </summary>
            [EnumMember(Value = "KU")]
            KU = 132,

            /// <summary>
            /// Enum KG for value: KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KG = 133,

            /// <summary>
            /// Enum LA for value: LA
            /// </summary>
            [EnumMember(Value = "LA")]
            LA = 134,

            /// <summary>
            /// Enum LG for value: LG
            /// </summary>
            [EnumMember(Value = "LG")]
            LG = 135,

            /// <summary>
            /// Enum LE for value: LE
            /// </summary>
            [EnumMember(Value = "LE")]
            LE = 136,

            /// <summary>
            /// Enum LT for value: LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LT = 137,

            /// <summary>
            /// Enum LI for value: LI
            /// </summary>
            [EnumMember(Value = "LI")]
            LI = 138,

            /// <summary>
            /// Enum LY for value: LY
            /// </summary>
            [EnumMember(Value = "LY")]
            LY = 139,

            /// <summary>
            /// Enum LS for value: LS
            /// </summary>
            [EnumMember(Value = "LS")]
            LS = 140,

            /// <summary>
            /// Enum LH for value: LH
            /// </summary>
            [EnumMember(Value = "LH")]
            LH = 141,

            /// <summary>
            /// Enum LU for value: LU
            /// </summary>
            [EnumMember(Value = "LU")]
            LU = 142,

            /// <summary>
            /// Enum MC for value: MC
            /// </summary>
            [EnumMember(Value = "MC")]
            MC = 143,

            /// <summary>
            /// Enum MK for value: MK
            /// </summary>
            [EnumMember(Value = "MK")]
            MK = 144,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 145,

            /// <summary>
            /// Enum MI for value: MI
            /// </summary>
            [EnumMember(Value = "MI")]
            MI = 146,

            /// <summary>
            /// Enum MY for value: MY
            /// </summary>
            [EnumMember(Value = "MY")]
            MY = 147,

            /// <summary>
            /// Enum MV for value: MV
            /// </summary>
            [EnumMember(Value = "MV")]
            MV = 148,

            /// <summary>
            /// Enum ML for value: ML
            /// </summary>
            [EnumMember(Value = "ML")]
            ML = 149,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 150,

            /// <summary>
            /// Enum IM for value: IM
            /// </summary>
            [EnumMember(Value = "IM")]
            IM = 151,

            /// <summary>
            /// Enum RM for value: RM
            /// </summary>
            [EnumMember(Value = "RM")]
            RM = 152,

            /// <summary>
            /// Enum MR for value: MR
            /// </summary>
            [EnumMember(Value = "MR")]
            MR = 153,

            /// <summary>
            /// Enum MP for value: MP
            /// </summary>
            [EnumMember(Value = "MP")]
            MP = 154,

            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 155,

            /// <summary>
            /// Enum MQ for value: MQ
            /// </summary>
            [EnumMember(Value = "MQ")]
            MQ = 156,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 157,

            /// <summary>
            /// Enum MN for value: MN
            /// </summary>
            [EnumMember(Value = "MN")]
            MN = 158,

            /// <summary>
            /// Enum MG for value: MG
            /// </summary>
            [EnumMember(Value = "MG")]
            MG = 159,

            /// <summary>
            /// Enum MJ for value: MJ
            /// </summary>
            [EnumMember(Value = "MJ")]
            MJ = 160,

            /// <summary>
            /// Enum MH for value: MH
            /// </summary>
            [EnumMember(Value = "MH")]
            MH = 161,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 162,

            /// <summary>
            /// Enum MZ for value: MZ
            /// </summary>
            [EnumMember(Value = "MZ")]
            MZ = 163,

            /// <summary>
            /// Enum WA for value: WA
            /// </summary>
            [EnumMember(Value = "WA")]
            WA = 164,

            /// <summary>
            /// Enum NR for value: NR
            /// </summary>
            [EnumMember(Value = "NR")]
            NR = 165,

            /// <summary>
            /// Enum BQ for value: BQ
            /// </summary>
            [EnumMember(Value = "BQ")]
            BQ = 166,

            /// <summary>
            /// Enum NP for value: NP
            /// </summary>
            [EnumMember(Value = "NP")]
            NP = 167,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 168,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 169,

            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 170,

            /// <summary>
            /// Enum NU for value: NU
            /// </summary>
            [EnumMember(Value = "NU")]
            NU = 171,

            /// <summary>
            /// Enum NG for value: NG
            /// </summary>
            [EnumMember(Value = "NG")]
            NG = 172,

            /// <summary>
            /// Enum NI for value: NI
            /// </summary>
            [EnumMember(Value = "NI")]
            NI = 173,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 174,

            /// <summary>
            /// Enum NF for value: NF
            /// </summary>
            [EnumMember(Value = "NF")]
            NF = 175,

            /// <summary>
            /// Enum CQ for value: CQ
            /// </summary>
            [EnumMember(Value = "CQ")]
            CQ = 176,

            /// <summary>
            /// Enum NO for value: NO
            /// </summary>
            [EnumMember(Value = "NO")]
            NO = 177,

            /// <summary>
            /// Enum MU for value: MU
            /// </summary>
            [EnumMember(Value = "MU")]
            MU = 178,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 179,

            /// <summary>
            /// Enum PK for value: PK
            /// </summary>
            [EnumMember(Value = "PK")]
            PK = 180,

            /// <summary>
            /// Enum PS for value: PS
            /// </summary>
            [EnumMember(Value = "PS")]
            PS = 181,

            /// <summary>
            /// Enum LQ for value: LQ
            /// </summary>
            [EnumMember(Value = "LQ")]
            LQ = 182,

            /// <summary>
            /// Enum PM for value: PM
            /// </summary>
            [EnumMember(Value = "PM")]
            PM = 183,

            /// <summary>
            /// Enum PP for value: PP
            /// </summary>
            [EnumMember(Value = "PP")]
            PP = 184,

            /// <summary>
            /// Enum PF for value: PF
            /// </summary>
            [EnumMember(Value = "PF")]
            PF = 185,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 186,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 187,

            /// <summary>
            /// Enum RP for value: RP
            /// </summary>
            [EnumMember(Value = "RP")]
            RP = 188,

            /// <summary>
            /// Enum PC for value: PC
            /// </summary>
            [EnumMember(Value = "PC")]
            PC = 189,

            /// <summary>
            /// Enum PL for value: PL
            /// </summary>
            [EnumMember(Value = "PL")]
            PL = 190,

            /// <summary>
            /// Enum PO for value: PO
            /// </summary>
            [EnumMember(Value = "PO")]
            PO = 191,

            /// <summary>
            /// Enum RQ for value: RQ
            /// </summary>
            [EnumMember(Value = "RQ")]
            RQ = 192,

            /// <summary>
            /// Enum QA for value: QA
            /// </summary>
            [EnumMember(Value = "QA")]
            QA = 193,

            /// <summary>
            /// Enum RO for value: RO
            /// </summary>
            [EnumMember(Value = "RO")]
            RO = 194,

            /// <summary>
            /// Enum RS for value: RS
            /// </summary>
            [EnumMember(Value = "RS")]
            RS = 195,

            /// <summary>
            /// Enum RW for value: RW
            /// </summary>
            [EnumMember(Value = "RW")]
            RW = 196,

            /// <summary>
            /// Enum TB for value: TB
            /// </summary>
            [EnumMember(Value = "TB")]
            TB = 197,

            /// <summary>
            /// Enum RN for value: RN
            /// </summary>
            [EnumMember(Value = "RN")]
            RN = 198,

            /// <summary>
            /// Enum WS for value: WS
            /// </summary>
            [EnumMember(Value = "WS")]
            WS = 199,

            /// <summary>
            /// Enum SM for value: SM
            /// </summary>
            [EnumMember(Value = "SM")]
            SM = 200,

            /// <summary>
            /// Enum TP for value: TP
            /// </summary>
            [EnumMember(Value = "TP")]
            TP = 201,

            /// <summary>
            /// Enum SA for value: SA
            /// </summary>
            [EnumMember(Value = "SA")]
            SA = 202,

            /// <summary>
            /// Enum SG for value: SG
            /// </summary>
            [EnumMember(Value = "SG")]
            SG = 203,

            /// <summary>
            /// Enum RI for value: RI
            /// </summary>
            [EnumMember(Value = "RI")]
            RI = 204,

            /// <summary>
            /// Enum SE for value: SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SE = 205,

            /// <summary>
            /// Enum SL for value: SL
            /// </summary>
            [EnumMember(Value = "SL")]
            SL = 206,

            /// <summary>
            /// Enum SN for value: SN
            /// </summary>
            [EnumMember(Value = "SN")]
            SN = 207,

            /// <summary>
            /// Enum NN for value: NN
            /// </summary>
            [EnumMember(Value = "NN")]
            NN = 208,

            /// <summary>
            /// Enum LO for value: LO
            /// </summary>
            [EnumMember(Value = "LO")]
            LO = 209,

            /// <summary>
            /// Enum SI for value: SI
            /// </summary>
            [EnumMember(Value = "SI")]
            SI = 210,

            /// <summary>
            /// Enum BP for value: BP
            /// </summary>
            [EnumMember(Value = "BP")]
            BP = 211,

            /// <summary>
            /// Enum SO for value: SO
            /// </summary>
            [EnumMember(Value = "SO")]
            SO = 212,

            /// <summary>
            /// Enum SF for value: SF
            /// </summary>
            [EnumMember(Value = "SF")]
            SF = 213,

            /// <summary>
            /// Enum SX for value: SX
            /// </summary>
            [EnumMember(Value = "SX")]
            SX = 214,

            /// <summary>
            /// Enum SP for value: SP
            /// </summary>
            [EnumMember(Value = "SP")]
            SP = 215,

            /// <summary>
            /// Enum PG for value: PG
            /// </summary>
            [EnumMember(Value = "PG")]
            PG = 216,

            /// <summary>
            /// Enum CE for value: CE
            /// </summary>
            [EnumMember(Value = "CE")]
            CE = 217,

            /// <summary>
            /// Enum SH for value: SH
            /// </summary>
            [EnumMember(Value = "SH")]
            SH = 218,

            /// <summary>
            /// Enum SC for value: SC
            /// </summary>
            [EnumMember(Value = "SC")]
            SC = 219,

            /// <summary>
            /// Enum ST for value: ST
            /// </summary>
            [EnumMember(Value = "ST")]
            ST = 220,

            /// <summary>
            /// Enum SB for value: SB
            /// </summary>
            [EnumMember(Value = "SB")]
            SB = 221,

            /// <summary>
            /// Enum VC for value: VC
            /// </summary>
            [EnumMember(Value = "VC")]
            VC = 222,

            /// <summary>
            /// Enum SU for value: SU
            /// </summary>
            [EnumMember(Value = "SU")]
            SU = 223,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 224,

            /// <summary>
            /// Enum SV for value: SV
            /// </summary>
            [EnumMember(Value = "SV")]
            SV = 225,

            /// <summary>
            /// Enum WZ for value: WZ
            /// </summary>
            [EnumMember(Value = "WZ")]
            WZ = 226,

            /// <summary>
            /// Enum SW for value: SW
            /// </summary>
            [EnumMember(Value = "SW")]
            SW = 227,

            /// <summary>
            /// Enum SZ for value: SZ
            /// </summary>
            [EnumMember(Value = "SZ")]
            SZ = 228,

            /// <summary>
            /// Enum SY for value: SY
            /// </summary>
            [EnumMember(Value = "SY")]
            SY = 229,

            /// <summary>
            /// Enum TW for value: TW
            /// </summary>
            [EnumMember(Value = "TW")]
            TW = 230,

            /// <summary>
            /// Enum TI for value: TI
            /// </summary>
            [EnumMember(Value = "TI")]
            TI = 231,

            /// <summary>
            /// Enum TZ for value: TZ
            /// </summary>
            [EnumMember(Value = "TZ")]
            TZ = 232,

            /// <summary>
            /// Enum TH for value: TH
            /// </summary>
            [EnumMember(Value = "TH")]
            TH = 233,

            /// <summary>
            /// Enum TO for value: TO
            /// </summary>
            [EnumMember(Value = "TO")]
            TO = 234,

            /// <summary>
            /// Enum TL for value: TL
            /// </summary>
            [EnumMember(Value = "TL")]
            TL = 235,

            /// <summary>
            /// Enum TN for value: TN
            /// </summary>
            [EnumMember(Value = "TN")]
            TN = 236,

            /// <summary>
            /// Enum TD for value: TD
            /// </summary>
            [EnumMember(Value = "TD")]
            TD = 237,

            /// <summary>
            /// Enum TS for value: TS
            /// </summary>
            [EnumMember(Value = "TS")]
            TS = 238,

            /// <summary>
            /// Enum TU for value: TU
            /// </summary>
            [EnumMember(Value = "TU")]
            TU = 239,

            /// <summary>
            /// Enum TX for value: TX
            /// </summary>
            [EnumMember(Value = "TX")]
            TX = 240,

            /// <summary>
            /// Enum TK for value: TK
            /// </summary>
            [EnumMember(Value = "TK")]
            TK = 241,

            /// <summary>
            /// Enum TV for value: TV
            /// </summary>
            [EnumMember(Value = "TV")]
            TV = 242,

            /// <summary>
            /// Enum UG for value: UG
            /// </summary>
            [EnumMember(Value = "UG")]
            UG = 243,

            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            [EnumMember(Value = "UP")]
            UP = 244,

            /// <summary>
            /// Enum AE for value: AE
            /// </summary>
            [EnumMember(Value = "AE")]
            AE = 245,

            /// <summary>
            /// Enum UK for value: UK
            /// </summary>
            [EnumMember(Value = "UK")]
            UK = 246,

            /// <summary>
            /// Enum UY for value: UY
            /// </summary>
            [EnumMember(Value = "UY")]
            UY = 247,

            /// <summary>
            /// Enum UZ for value: UZ
            /// </summary>
            [EnumMember(Value = "UZ")]
            UZ = 248,

            /// <summary>
            /// Enum NH for value: NH
            /// </summary>
            [EnumMember(Value = "NH")]
            NH = 249,

            /// <summary>
            /// Enum VE for value: VE
            /// </summary>
            [EnumMember(Value = "VE")]
            VE = 250,

            /// <summary>
            /// Enum VM for value: VM
            /// </summary>
            [EnumMember(Value = "VM")]
            VM = 251,

            /// <summary>
            /// Enum VQ for value: VQ
            /// </summary>
            [EnumMember(Value = "VQ")]
            VQ = 252,

            /// <summary>
            /// Enum WQ for value: WQ
            /// </summary>
            [EnumMember(Value = "WQ")]
            WQ = 253,

            /// <summary>
            /// Enum WF for value: WF
            /// </summary>
            [EnumMember(Value = "WF")]
            WF = 254,

            /// <summary>
            /// Enum WI for value: WI
            /// </summary>
            [EnumMember(Value = "WI")]
            WI = 255,

            /// <summary>
            /// Enum YM for value: YM
            /// </summary>
            [EnumMember(Value = "YM")]
            YM = 256,

            /// <summary>
            /// Enum ZA for value: ZA
            /// </summary>
            [EnumMember(Value = "ZA")]
            ZA = 257,

            /// <summary>
            /// Enum ZI for value: ZI
            /// </summary>
            [EnumMember(Value = "ZI")]
            ZI = 258
        }


        /// <summary>
        /// The country of the mailing address.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country of the mailing address.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [DataMember(Name = "mailingCountry", IsRequired = true, EmitDefaultValue = true)]
        public MailingCountryEnum MailingCountry { get; set; }
        /// <summary>
        /// The country for which the treaty applies.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country for which the treaty applies.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TreatyCountryEnum
        {
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 1,

            /// <summary>
            /// Enum AF for value: AF
            /// </summary>
            [EnumMember(Value = "AF")]
            AF = 2,

            /// <summary>
            /// Enum AX for value: AX
            /// </summary>
            [EnumMember(Value = "AX")]
            AX = 3,

            /// <summary>
            /// Enum AL for value: AL
            /// </summary>
            [EnumMember(Value = "AL")]
            AL = 4,

            /// <summary>
            /// Enum AG for value: AG
            /// </summary>
            [EnumMember(Value = "AG")]
            AG = 5,

            /// <summary>
            /// Enum AQ for value: AQ
            /// </summary>
            [EnumMember(Value = "AQ")]
            AQ = 6,

            /// <summary>
            /// Enum AN for value: AN
            /// </summary>
            [EnumMember(Value = "AN")]
            AN = 7,

            /// <summary>
            /// Enum AO for value: AO
            /// </summary>
            [EnumMember(Value = "AO")]
            AO = 8,

            /// <summary>
            /// Enum AV for value: AV
            /// </summary>
            [EnumMember(Value = "AV")]
            AV = 9,

            /// <summary>
            /// Enum AY for value: AY
            /// </summary>
            [EnumMember(Value = "AY")]
            AY = 10,

            /// <summary>
            /// Enum AC for value: AC
            /// </summary>
            [EnumMember(Value = "AC")]
            AC = 11,

            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 12,

            /// <summary>
            /// Enum AM for value: AM
            /// </summary>
            [EnumMember(Value = "AM")]
            AM = 13,

            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 14,

            /// <summary>
            /// Enum AT for value: AT
            /// </summary>
            [EnumMember(Value = "AT")]
            AT = 15,

            /// <summary>
            /// Enum AS for value: AS
            /// </summary>
            [EnumMember(Value = "AS")]
            AS = 16,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 17,

            /// <summary>
            /// Enum AJ for value: AJ
            /// </summary>
            [EnumMember(Value = "AJ")]
            AJ = 18,

            /// <summary>
            /// Enum BF for value: BF
            /// </summary>
            [EnumMember(Value = "BF")]
            BF = 19,

            /// <summary>
            /// Enum BA for value: BA
            /// </summary>
            [EnumMember(Value = "BA")]
            BA = 20,

            /// <summary>
            /// Enum FQ for value: FQ
            /// </summary>
            [EnumMember(Value = "FQ")]
            FQ = 21,

            /// <summary>
            /// Enum BG for value: BG
            /// </summary>
            [EnumMember(Value = "BG")]
            BG = 22,

            /// <summary>
            /// Enum BB for value: BB
            /// </summary>
            [EnumMember(Value = "BB")]
            BB = 23,

            /// <summary>
            /// Enum BO for value: BO
            /// </summary>
            [EnumMember(Value = "BO")]
            BO = 24,

            /// <summary>
            /// Enum BE for value: BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BE = 25,

            /// <summary>
            /// Enum BH for value: BH
            /// </summary>
            [EnumMember(Value = "BH")]
            BH = 26,

            /// <summary>
            /// Enum BN for value: BN
            /// </summary>
            [EnumMember(Value = "BN")]
            BN = 27,

            /// <summary>
            /// Enum BD for value: BD
            /// </summary>
            [EnumMember(Value = "BD")]
            BD = 28,

            /// <summary>
            /// Enum BT for value: BT
            /// </summary>
            [EnumMember(Value = "BT")]
            BT = 29,

            /// <summary>
            /// Enum BL for value: BL
            /// </summary>
            [EnumMember(Value = "BL")]
            BL = 30,

            /// <summary>
            /// Enum BK for value: BK
            /// </summary>
            [EnumMember(Value = "BK")]
            BK = 31,

            /// <summary>
            /// Enum BC for value: BC
            /// </summary>
            [EnumMember(Value = "BC")]
            BC = 32,

            /// <summary>
            /// Enum BV for value: BV
            /// </summary>
            [EnumMember(Value = "BV")]
            BV = 33,

            /// <summary>
            /// Enum BR for value: BR
            /// </summary>
            [EnumMember(Value = "BR")]
            BR = 34,

            /// <summary>
            /// Enum IO for value: IO
            /// </summary>
            [EnumMember(Value = "IO")]
            IO = 35,

            /// <summary>
            /// Enum VI for value: VI
            /// </summary>
            [EnumMember(Value = "VI")]
            VI = 36,

            /// <summary>
            /// Enum BX for value: BX
            /// </summary>
            [EnumMember(Value = "BX")]
            BX = 37,

            /// <summary>
            /// Enum BU for value: BU
            /// </summary>
            [EnumMember(Value = "BU")]
            BU = 38,

            /// <summary>
            /// Enum UV for value: UV
            /// </summary>
            [EnumMember(Value = "UV")]
            UV = 39,

            /// <summary>
            /// Enum BM for value: BM
            /// </summary>
            [EnumMember(Value = "BM")]
            BM = 40,

            /// <summary>
            /// Enum BY for value: BY
            /// </summary>
            [EnumMember(Value = "BY")]
            BY = 41,

            /// <summary>
            /// Enum CB for value: CB
            /// </summary>
            [EnumMember(Value = "CB")]
            CB = 42,

            /// <summary>
            /// Enum CM for value: CM
            /// </summary>
            [EnumMember(Value = "CM")]
            CM = 43,

            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 44,

            /// <summary>
            /// Enum CV for value: CV
            /// </summary>
            [EnumMember(Value = "CV")]
            CV = 45,

            /// <summary>
            /// Enum CJ for value: CJ
            /// </summary>
            [EnumMember(Value = "CJ")]
            CJ = 46,

            /// <summary>
            /// Enum CT for value: CT
            /// </summary>
            [EnumMember(Value = "CT")]
            CT = 47,

            /// <summary>
            /// Enum CD for value: CD
            /// </summary>
            [EnumMember(Value = "CD")]
            CD = 48,

            /// <summary>
            /// Enum CI for value: CI
            /// </summary>
            [EnumMember(Value = "CI")]
            CI = 49,

            /// <summary>
            /// Enum CH for value: CH
            /// </summary>
            [EnumMember(Value = "CH")]
            CH = 50,

            /// <summary>
            /// Enum KT for value: KT
            /// </summary>
            [EnumMember(Value = "KT")]
            KT = 51,

            /// <summary>
            /// Enum IP for value: IP
            /// </summary>
            [EnumMember(Value = "IP")]
            IP = 52,

            /// <summary>
            /// Enum CK for value: CK
            /// </summary>
            [EnumMember(Value = "CK")]
            CK = 53,

            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            [EnumMember(Value = "CO")]
            CO = 54,

            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            [EnumMember(Value = "CN")]
            CN = 55,

            /// <summary>
            /// Enum CF for value: CF
            /// </summary>
            [EnumMember(Value = "CF")]
            CF = 56,

            /// <summary>
            /// Enum CG for value: CG
            /// </summary>
            [EnumMember(Value = "CG")]
            CG = 57,

            /// <summary>
            /// Enum CW for value: CW
            /// </summary>
            [EnumMember(Value = "CW")]
            CW = 58,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 59,

            /// <summary>
            /// Enum CS for value: CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CS = 60,

            /// <summary>
            /// Enum IV for value: IV
            /// </summary>
            [EnumMember(Value = "IV")]
            IV = 61,

            /// <summary>
            /// Enum HR for value: HR
            /// </summary>
            [EnumMember(Value = "HR")]
            HR = 62,

            /// <summary>
            /// Enum CU for value: CU
            /// </summary>
            [EnumMember(Value = "CU")]
            CU = 63,

            /// <summary>
            /// Enum UC for value: UC
            /// </summary>
            [EnumMember(Value = "UC")]
            UC = 64,

            /// <summary>
            /// Enum CY for value: CY
            /// </summary>
            [EnumMember(Value = "CY")]
            CY = 65,

            /// <summary>
            /// Enum EZ for value: EZ
            /// </summary>
            [EnumMember(Value = "EZ")]
            EZ = 66,

            /// <summary>
            /// Enum DA for value: DA
            /// </summary>
            [EnumMember(Value = "DA")]
            DA = 67,

            /// <summary>
            /// Enum DX for value: DX
            /// </summary>
            [EnumMember(Value = "DX")]
            DX = 68,

            /// <summary>
            /// Enum DJ for value: DJ
            /// </summary>
            [EnumMember(Value = "DJ")]
            DJ = 69,

            /// <summary>
            /// Enum DO for value: DO
            /// </summary>
            [EnumMember(Value = "DO")]
            DO = 70,

            /// <summary>
            /// Enum DR for value: DR
            /// </summary>
            [EnumMember(Value = "DR")]
            DR = 71,

            /// <summary>
            /// Enum TT for value: TT
            /// </summary>
            [EnumMember(Value = "TT")]
            TT = 72,

            /// <summary>
            /// Enum EC for value: EC
            /// </summary>
            [EnumMember(Value = "EC")]
            EC = 73,

            /// <summary>
            /// Enum EG for value: EG
            /// </summary>
            [EnumMember(Value = "EG")]
            EG = 74,

            /// <summary>
            /// Enum ES for value: ES
            /// </summary>
            [EnumMember(Value = "ES")]
            ES = 75,

            /// <summary>
            /// Enum EK for value: EK
            /// </summary>
            [EnumMember(Value = "EK")]
            EK = 76,

            /// <summary>
            /// Enum ER for value: ER
            /// </summary>
            [EnumMember(Value = "ER")]
            ER = 77,

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            [EnumMember(Value = "EN")]
            EN = 78,

            /// <summary>
            /// Enum ET for value: ET
            /// </summary>
            [EnumMember(Value = "ET")]
            ET = 79,

            /// <summary>
            /// Enum FK for value: FK
            /// </summary>
            [EnumMember(Value = "FK")]
            FK = 80,

            /// <summary>
            /// Enum FO for value: FO
            /// </summary>
            [EnumMember(Value = "FO")]
            FO = 81,

            /// <summary>
            /// Enum FM for value: FM
            /// </summary>
            [EnumMember(Value = "FM")]
            FM = 82,

            /// <summary>
            /// Enum FJ for value: FJ
            /// </summary>
            [EnumMember(Value = "FJ")]
            FJ = 83,

            /// <summary>
            /// Enum FI for value: FI
            /// </summary>
            [EnumMember(Value = "FI")]
            FI = 84,

            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 85,

            /// <summary>
            /// Enum FP for value: FP
            /// </summary>
            [EnumMember(Value = "FP")]
            FP = 86,

            /// <summary>
            /// Enum FS for value: FS
            /// </summary>
            [EnumMember(Value = "FS")]
            FS = 87,

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 88,

            /// <summary>
            /// Enum GA for value: GA
            /// </summary>
            [EnumMember(Value = "GA")]
            GA = 89,

            /// <summary>
            /// Enum GG for value: GG
            /// </summary>
            [EnumMember(Value = "GG")]
            GG = 90,

            /// <summary>
            /// Enum GM for value: GM
            /// </summary>
            [EnumMember(Value = "GM")]
            GM = 91,

            /// <summary>
            /// Enum GH for value: GH
            /// </summary>
            [EnumMember(Value = "GH")]
            GH = 92,

            /// <summary>
            /// Enum GI for value: GI
            /// </summary>
            [EnumMember(Value = "GI")]
            GI = 93,

            /// <summary>
            /// Enum GR for value: GR
            /// </summary>
            [EnumMember(Value = "GR")]
            GR = 94,

            /// <summary>
            /// Enum GL for value: GL
            /// </summary>
            [EnumMember(Value = "GL")]
            GL = 95,

            /// <summary>
            /// Enum GJ for value: GJ
            /// </summary>
            [EnumMember(Value = "GJ")]
            GJ = 96,

            /// <summary>
            /// Enum GQ for value: GQ
            /// </summary>
            [EnumMember(Value = "GQ")]
            GQ = 97,

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            [EnumMember(Value = "GT")]
            GT = 98,

            /// <summary>
            /// Enum GK for value: GK
            /// </summary>
            [EnumMember(Value = "GK")]
            GK = 99,

            /// <summary>
            /// Enum GV for value: GV
            /// </summary>
            [EnumMember(Value = "GV")]
            GV = 100,

            /// <summary>
            /// Enum PU for value: PU
            /// </summary>
            [EnumMember(Value = "PU")]
            PU = 101,

            /// <summary>
            /// Enum GY for value: GY
            /// </summary>
            [EnumMember(Value = "GY")]
            GY = 102,

            /// <summary>
            /// Enum HA for value: HA
            /// </summary>
            [EnumMember(Value = "HA")]
            HA = 103,

            /// <summary>
            /// Enum HM for value: HM
            /// </summary>
            [EnumMember(Value = "HM")]
            HM = 104,

            /// <summary>
            /// Enum VT for value: VT
            /// </summary>
            [EnumMember(Value = "VT")]
            VT = 105,

            /// <summary>
            /// Enum HO for value: HO
            /// </summary>
            [EnumMember(Value = "HO")]
            HO = 106,

            /// <summary>
            /// Enum HK for value: HK
            /// </summary>
            [EnumMember(Value = "HK")]
            HK = 107,

            /// <summary>
            /// Enum HQ for value: HQ
            /// </summary>
            [EnumMember(Value = "HQ")]
            HQ = 108,

            /// <summary>
            /// Enum HU for value: HU
            /// </summary>
            [EnumMember(Value = "HU")]
            HU = 109,

            /// <summary>
            /// Enum IC for value: IC
            /// </summary>
            [EnumMember(Value = "IC")]
            IC = 110,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 111,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 112,

            /// <summary>
            /// Enum IR for value: IR
            /// </summary>
            [EnumMember(Value = "IR")]
            IR = 113,

            /// <summary>
            /// Enum IZ for value: IZ
            /// </summary>
            [EnumMember(Value = "IZ")]
            IZ = 114,

            /// <summary>
            /// Enum EI for value: EI
            /// </summary>
            [EnumMember(Value = "EI")]
            EI = 115,

            /// <summary>
            /// Enum IS for value: IS
            /// </summary>
            [EnumMember(Value = "IS")]
            IS = 116,

            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 117,

            /// <summary>
            /// Enum JM for value: JM
            /// </summary>
            [EnumMember(Value = "JM")]
            JM = 118,

            /// <summary>
            /// Enum JN for value: JN
            /// </summary>
            [EnumMember(Value = "JN")]
            JN = 119,

            /// <summary>
            /// Enum JA for value: JA
            /// </summary>
            [EnumMember(Value = "JA")]
            JA = 120,

            /// <summary>
            /// Enum DQ for value: DQ
            /// </summary>
            [EnumMember(Value = "DQ")]
            DQ = 121,

            /// <summary>
            /// Enum JE for value: JE
            /// </summary>
            [EnumMember(Value = "JE")]
            JE = 122,

            /// <summary>
            /// Enum JQ for value: JQ
            /// </summary>
            [EnumMember(Value = "JQ")]
            JQ = 123,

            /// <summary>
            /// Enum JO for value: JO
            /// </summary>
            [EnumMember(Value = "JO")]
            JO = 124,

            /// <summary>
            /// Enum KZ for value: KZ
            /// </summary>
            [EnumMember(Value = "KZ")]
            KZ = 125,

            /// <summary>
            /// Enum KE for value: KE
            /// </summary>
            [EnumMember(Value = "KE")]
            KE = 126,

            /// <summary>
            /// Enum KQ for value: KQ
            /// </summary>
            [EnumMember(Value = "KQ")]
            KQ = 127,

            /// <summary>
            /// Enum KR for value: KR
            /// </summary>
            [EnumMember(Value = "KR")]
            KR = 128,

            /// <summary>
            /// Enum KN for value: KN
            /// </summary>
            [EnumMember(Value = "KN")]
            KN = 129,

            /// <summary>
            /// Enum KS for value: KS
            /// </summary>
            [EnumMember(Value = "KS")]
            KS = 130,

            /// <summary>
            /// Enum KV for value: KV
            /// </summary>
            [EnumMember(Value = "KV")]
            KV = 131,

            /// <summary>
            /// Enum KU for value: KU
            /// </summary>
            [EnumMember(Value = "KU")]
            KU = 132,

            /// <summary>
            /// Enum KG for value: KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KG = 133,

            /// <summary>
            /// Enum LA for value: LA
            /// </summary>
            [EnumMember(Value = "LA")]
            LA = 134,

            /// <summary>
            /// Enum LG for value: LG
            /// </summary>
            [EnumMember(Value = "LG")]
            LG = 135,

            /// <summary>
            /// Enum LE for value: LE
            /// </summary>
            [EnumMember(Value = "LE")]
            LE = 136,

            /// <summary>
            /// Enum LT for value: LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LT = 137,

            /// <summary>
            /// Enum LI for value: LI
            /// </summary>
            [EnumMember(Value = "LI")]
            LI = 138,

            /// <summary>
            /// Enum LY for value: LY
            /// </summary>
            [EnumMember(Value = "LY")]
            LY = 139,

            /// <summary>
            /// Enum LS for value: LS
            /// </summary>
            [EnumMember(Value = "LS")]
            LS = 140,

            /// <summary>
            /// Enum LH for value: LH
            /// </summary>
            [EnumMember(Value = "LH")]
            LH = 141,

            /// <summary>
            /// Enum LU for value: LU
            /// </summary>
            [EnumMember(Value = "LU")]
            LU = 142,

            /// <summary>
            /// Enum MC for value: MC
            /// </summary>
            [EnumMember(Value = "MC")]
            MC = 143,

            /// <summary>
            /// Enum MK for value: MK
            /// </summary>
            [EnumMember(Value = "MK")]
            MK = 144,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 145,

            /// <summary>
            /// Enum MI for value: MI
            /// </summary>
            [EnumMember(Value = "MI")]
            MI = 146,

            /// <summary>
            /// Enum MY for value: MY
            /// </summary>
            [EnumMember(Value = "MY")]
            MY = 147,

            /// <summary>
            /// Enum MV for value: MV
            /// </summary>
            [EnumMember(Value = "MV")]
            MV = 148,

            /// <summary>
            /// Enum ML for value: ML
            /// </summary>
            [EnumMember(Value = "ML")]
            ML = 149,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 150,

            /// <summary>
            /// Enum IM for value: IM
            /// </summary>
            [EnumMember(Value = "IM")]
            IM = 151,

            /// <summary>
            /// Enum RM for value: RM
            /// </summary>
            [EnumMember(Value = "RM")]
            RM = 152,

            /// <summary>
            /// Enum MR for value: MR
            /// </summary>
            [EnumMember(Value = "MR")]
            MR = 153,

            /// <summary>
            /// Enum MP for value: MP
            /// </summary>
            [EnumMember(Value = "MP")]
            MP = 154,

            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 155,

            /// <summary>
            /// Enum MQ for value: MQ
            /// </summary>
            [EnumMember(Value = "MQ")]
            MQ = 156,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 157,

            /// <summary>
            /// Enum MN for value: MN
            /// </summary>
            [EnumMember(Value = "MN")]
            MN = 158,

            /// <summary>
            /// Enum MG for value: MG
            /// </summary>
            [EnumMember(Value = "MG")]
            MG = 159,

            /// <summary>
            /// Enum MJ for value: MJ
            /// </summary>
            [EnumMember(Value = "MJ")]
            MJ = 160,

            /// <summary>
            /// Enum MH for value: MH
            /// </summary>
            [EnumMember(Value = "MH")]
            MH = 161,

            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            [EnumMember(Value = "MO")]
            MO = 162,

            /// <summary>
            /// Enum MZ for value: MZ
            /// </summary>
            [EnumMember(Value = "MZ")]
            MZ = 163,

            /// <summary>
            /// Enum WA for value: WA
            /// </summary>
            [EnumMember(Value = "WA")]
            WA = 164,

            /// <summary>
            /// Enum NR for value: NR
            /// </summary>
            [EnumMember(Value = "NR")]
            NR = 165,

            /// <summary>
            /// Enum BQ for value: BQ
            /// </summary>
            [EnumMember(Value = "BQ")]
            BQ = 166,

            /// <summary>
            /// Enum NP for value: NP
            /// </summary>
            [EnumMember(Value = "NP")]
            NP = 167,

            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 168,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 169,

            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 170,

            /// <summary>
            /// Enum NU for value: NU
            /// </summary>
            [EnumMember(Value = "NU")]
            NU = 171,

            /// <summary>
            /// Enum NG for value: NG
            /// </summary>
            [EnumMember(Value = "NG")]
            NG = 172,

            /// <summary>
            /// Enum NI for value: NI
            /// </summary>
            [EnumMember(Value = "NI")]
            NI = 173,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 174,

            /// <summary>
            /// Enum NF for value: NF
            /// </summary>
            [EnumMember(Value = "NF")]
            NF = 175,

            /// <summary>
            /// Enum CQ for value: CQ
            /// </summary>
            [EnumMember(Value = "CQ")]
            CQ = 176,

            /// <summary>
            /// Enum NO for value: NO
            /// </summary>
            [EnumMember(Value = "NO")]
            NO = 177,

            /// <summary>
            /// Enum MU for value: MU
            /// </summary>
            [EnumMember(Value = "MU")]
            MU = 178,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 179,

            /// <summary>
            /// Enum PK for value: PK
            /// </summary>
            [EnumMember(Value = "PK")]
            PK = 180,

            /// <summary>
            /// Enum PS for value: PS
            /// </summary>
            [EnumMember(Value = "PS")]
            PS = 181,

            /// <summary>
            /// Enum LQ for value: LQ
            /// </summary>
            [EnumMember(Value = "LQ")]
            LQ = 182,

            /// <summary>
            /// Enum PM for value: PM
            /// </summary>
            [EnumMember(Value = "PM")]
            PM = 183,

            /// <summary>
            /// Enum PP for value: PP
            /// </summary>
            [EnumMember(Value = "PP")]
            PP = 184,

            /// <summary>
            /// Enum PF for value: PF
            /// </summary>
            [EnumMember(Value = "PF")]
            PF = 185,

            /// <summary>
            /// Enum PA for value: PA
            /// </summary>
            [EnumMember(Value = "PA")]
            PA = 186,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 187,

            /// <summary>
            /// Enum RP for value: RP
            /// </summary>
            [EnumMember(Value = "RP")]
            RP = 188,

            /// <summary>
            /// Enum PC for value: PC
            /// </summary>
            [EnumMember(Value = "PC")]
            PC = 189,

            /// <summary>
            /// Enum PL for value: PL
            /// </summary>
            [EnumMember(Value = "PL")]
            PL = 190,

            /// <summary>
            /// Enum PO for value: PO
            /// </summary>
            [EnumMember(Value = "PO")]
            PO = 191,

            /// <summary>
            /// Enum RQ for value: RQ
            /// </summary>
            [EnumMember(Value = "RQ")]
            RQ = 192,

            /// <summary>
            /// Enum QA for value: QA
            /// </summary>
            [EnumMember(Value = "QA")]
            QA = 193,

            /// <summary>
            /// Enum RO for value: RO
            /// </summary>
            [EnumMember(Value = "RO")]
            RO = 194,

            /// <summary>
            /// Enum RS for value: RS
            /// </summary>
            [EnumMember(Value = "RS")]
            RS = 195,

            /// <summary>
            /// Enum RW for value: RW
            /// </summary>
            [EnumMember(Value = "RW")]
            RW = 196,

            /// <summary>
            /// Enum TB for value: TB
            /// </summary>
            [EnumMember(Value = "TB")]
            TB = 197,

            /// <summary>
            /// Enum RN for value: RN
            /// </summary>
            [EnumMember(Value = "RN")]
            RN = 198,

            /// <summary>
            /// Enum WS for value: WS
            /// </summary>
            [EnumMember(Value = "WS")]
            WS = 199,

            /// <summary>
            /// Enum SM for value: SM
            /// </summary>
            [EnumMember(Value = "SM")]
            SM = 200,

            /// <summary>
            /// Enum TP for value: TP
            /// </summary>
            [EnumMember(Value = "TP")]
            TP = 201,

            /// <summary>
            /// Enum SA for value: SA
            /// </summary>
            [EnumMember(Value = "SA")]
            SA = 202,

            /// <summary>
            /// Enum SG for value: SG
            /// </summary>
            [EnumMember(Value = "SG")]
            SG = 203,

            /// <summary>
            /// Enum RI for value: RI
            /// </summary>
            [EnumMember(Value = "RI")]
            RI = 204,

            /// <summary>
            /// Enum SE for value: SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SE = 205,

            /// <summary>
            /// Enum SL for value: SL
            /// </summary>
            [EnumMember(Value = "SL")]
            SL = 206,

            /// <summary>
            /// Enum SN for value: SN
            /// </summary>
            [EnumMember(Value = "SN")]
            SN = 207,

            /// <summary>
            /// Enum NN for value: NN
            /// </summary>
            [EnumMember(Value = "NN")]
            NN = 208,

            /// <summary>
            /// Enum LO for value: LO
            /// </summary>
            [EnumMember(Value = "LO")]
            LO = 209,

            /// <summary>
            /// Enum SI for value: SI
            /// </summary>
            [EnumMember(Value = "SI")]
            SI = 210,

            /// <summary>
            /// Enum BP for value: BP
            /// </summary>
            [EnumMember(Value = "BP")]
            BP = 211,

            /// <summary>
            /// Enum SO for value: SO
            /// </summary>
            [EnumMember(Value = "SO")]
            SO = 212,

            /// <summary>
            /// Enum SF for value: SF
            /// </summary>
            [EnumMember(Value = "SF")]
            SF = 213,

            /// <summary>
            /// Enum SX for value: SX
            /// </summary>
            [EnumMember(Value = "SX")]
            SX = 214,

            /// <summary>
            /// Enum SP for value: SP
            /// </summary>
            [EnumMember(Value = "SP")]
            SP = 215,

            /// <summary>
            /// Enum PG for value: PG
            /// </summary>
            [EnumMember(Value = "PG")]
            PG = 216,

            /// <summary>
            /// Enum CE for value: CE
            /// </summary>
            [EnumMember(Value = "CE")]
            CE = 217,

            /// <summary>
            /// Enum SH for value: SH
            /// </summary>
            [EnumMember(Value = "SH")]
            SH = 218,

            /// <summary>
            /// Enum SC for value: SC
            /// </summary>
            [EnumMember(Value = "SC")]
            SC = 219,

            /// <summary>
            /// Enum ST for value: ST
            /// </summary>
            [EnumMember(Value = "ST")]
            ST = 220,

            /// <summary>
            /// Enum SB for value: SB
            /// </summary>
            [EnumMember(Value = "SB")]
            SB = 221,

            /// <summary>
            /// Enum VC for value: VC
            /// </summary>
            [EnumMember(Value = "VC")]
            VC = 222,

            /// <summary>
            /// Enum SU for value: SU
            /// </summary>
            [EnumMember(Value = "SU")]
            SU = 223,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 224,

            /// <summary>
            /// Enum SV for value: SV
            /// </summary>
            [EnumMember(Value = "SV")]
            SV = 225,

            /// <summary>
            /// Enum WZ for value: WZ
            /// </summary>
            [EnumMember(Value = "WZ")]
            WZ = 226,

            /// <summary>
            /// Enum SW for value: SW
            /// </summary>
            [EnumMember(Value = "SW")]
            SW = 227,

            /// <summary>
            /// Enum SZ for value: SZ
            /// </summary>
            [EnumMember(Value = "SZ")]
            SZ = 228,

            /// <summary>
            /// Enum SY for value: SY
            /// </summary>
            [EnumMember(Value = "SY")]
            SY = 229,

            /// <summary>
            /// Enum TW for value: TW
            /// </summary>
            [EnumMember(Value = "TW")]
            TW = 230,

            /// <summary>
            /// Enum TI for value: TI
            /// </summary>
            [EnumMember(Value = "TI")]
            TI = 231,

            /// <summary>
            /// Enum TZ for value: TZ
            /// </summary>
            [EnumMember(Value = "TZ")]
            TZ = 232,

            /// <summary>
            /// Enum TH for value: TH
            /// </summary>
            [EnumMember(Value = "TH")]
            TH = 233,

            /// <summary>
            /// Enum TO for value: TO
            /// </summary>
            [EnumMember(Value = "TO")]
            TO = 234,

            /// <summary>
            /// Enum TL for value: TL
            /// </summary>
            [EnumMember(Value = "TL")]
            TL = 235,

            /// <summary>
            /// Enum TN for value: TN
            /// </summary>
            [EnumMember(Value = "TN")]
            TN = 236,

            /// <summary>
            /// Enum TD for value: TD
            /// </summary>
            [EnumMember(Value = "TD")]
            TD = 237,

            /// <summary>
            /// Enum TS for value: TS
            /// </summary>
            [EnumMember(Value = "TS")]
            TS = 238,

            /// <summary>
            /// Enum TU for value: TU
            /// </summary>
            [EnumMember(Value = "TU")]
            TU = 239,

            /// <summary>
            /// Enum TX for value: TX
            /// </summary>
            [EnumMember(Value = "TX")]
            TX = 240,

            /// <summary>
            /// Enum TK for value: TK
            /// </summary>
            [EnumMember(Value = "TK")]
            TK = 241,

            /// <summary>
            /// Enum TV for value: TV
            /// </summary>
            [EnumMember(Value = "TV")]
            TV = 242,

            /// <summary>
            /// Enum UG for value: UG
            /// </summary>
            [EnumMember(Value = "UG")]
            UG = 243,

            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            [EnumMember(Value = "UP")]
            UP = 244,

            /// <summary>
            /// Enum AE for value: AE
            /// </summary>
            [EnumMember(Value = "AE")]
            AE = 245,

            /// <summary>
            /// Enum UK for value: UK
            /// </summary>
            [EnumMember(Value = "UK")]
            UK = 246,

            /// <summary>
            /// Enum UY for value: UY
            /// </summary>
            [EnumMember(Value = "UY")]
            UY = 247,

            /// <summary>
            /// Enum UZ for value: UZ
            /// </summary>
            [EnumMember(Value = "UZ")]
            UZ = 248,

            /// <summary>
            /// Enum NH for value: NH
            /// </summary>
            [EnumMember(Value = "NH")]
            NH = 249,

            /// <summary>
            /// Enum VE for value: VE
            /// </summary>
            [EnumMember(Value = "VE")]
            VE = 250,

            /// <summary>
            /// Enum VM for value: VM
            /// </summary>
            [EnumMember(Value = "VM")]
            VM = 251,

            /// <summary>
            /// Enum VQ for value: VQ
            /// </summary>
            [EnumMember(Value = "VQ")]
            VQ = 252,

            /// <summary>
            /// Enum WQ for value: WQ
            /// </summary>
            [EnumMember(Value = "WQ")]
            WQ = 253,

            /// <summary>
            /// Enum WF for value: WF
            /// </summary>
            [EnumMember(Value = "WF")]
            WF = 254,

            /// <summary>
            /// Enum WI for value: WI
            /// </summary>
            [EnumMember(Value = "WI")]
            WI = 255,

            /// <summary>
            /// Enum YM for value: YM
            /// </summary>
            [EnumMember(Value = "YM")]
            YM = 256,

            /// <summary>
            /// Enum ZA for value: ZA
            /// </summary>
            [EnumMember(Value = "ZA")]
            ZA = 257,

            /// <summary>
            /// Enum ZI for value: ZI
            /// </summary>
            [EnumMember(Value = "ZI")]
            ZI = 258
        }


        /// <summary>
        /// The country for which the treaty applies.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)
        /// </summary>
        /// <value>The country for which the treaty applies.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more)</value>
        [DataMember(Name = "treatyCountry", EmitDefaultValue = false)]
        public TreatyCountryEnum? TreatyCountry { get; set; }
        /// <summary>
        /// The withholding rate applied as per the treaty. Must be a percentage with up to two decimals (e.g., 12.50, 0).. Allowed values: 0, 0.0, 0.00, 5, 5.5, 10, 12.50, 15, 20, 25 (and 1 more)
        /// </summary>
        /// <value>The withholding rate applied as per the treaty. Must be a percentage with up to two decimals (e.g., 12.50, 0).. Allowed values: 0, 0.0, 0.00, 5, 5.5, 10, 12.50, 15, 20, 25 (and 1 more)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WithholdingRateEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 1,

            /// <summary>
            /// Enum _00 for value: 0.0
            /// </summary>
            [EnumMember(Value = "0.0")]
            _00 = 2,

            /// <summary>
            /// Enum _000 for value: 0.00
            /// </summary>
            [EnumMember(Value = "0.00")]
            _000 = 3,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 4,

            /// <summary>
            /// Enum _55 for value: 5.5
            /// </summary>
            [EnumMember(Value = "5.5")]
            _55 = 5,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 6,

            /// <summary>
            /// Enum _1250 for value: 12.50
            /// </summary>
            [EnumMember(Value = "12.50")]
            _1250 = 7,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 8,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 9,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 10,

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30 = 11
        }


        /// <summary>
        /// The withholding rate applied as per the treaty. Must be a percentage with up to two decimals (e.g., 12.50, 0).. Allowed values: 0, 0.0, 0.00, 5, 5.5, 10, 12.50, 15, 20, 25 (and 1 more)
        /// </summary>
        /// <value>The withholding rate applied as per the treaty. Must be a percentage with up to two decimals (e.g., 12.50, 0).. Allowed values: 0, 0.0, 0.00, 5, 5.5, 10, 12.50, 15, 20, 25 (and 1 more)</value>
        [DataMember(Name = "withholdingRate", EmitDefaultValue = true)]
        public WithholdingRateEnum? WithholdingRate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="W8BenFormRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected W8BenFormRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="W8BenFormRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the individual or entity associated with the form. (required).</param>
        /// <param name="citizenshipCountry">The country of citizenship.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more) (required).</param>
        /// <param name="residenceAddress">The residential address of the individual or entity..</param>
        /// <param name="residenceCity">The city of residence..</param>
        /// <param name="residenceState">The state of residence. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more).</param>
        /// <param name="residenceZip">The ZIP code of the residence..</param>
        /// <param name="residenceCountry">The country of residence.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more) (required).</param>
        /// <param name="residenceIsMailing">Indicates whether the residence address is the mailing address..</param>
        /// <param name="mailingAddress">The mailing address..</param>
        /// <param name="mailingCity">The city of the mailing address..</param>
        /// <param name="mailingState">The state of the mailing address. Required for US and Canada.. Allowed values: AA, AE, AK, AL, AP, AR, AS, AZ, CA, CO (and 65 more).</param>
        /// <param name="mailingZip">The ZIP code of the mailing address..</param>
        /// <param name="mailingCountry">The country of the mailing address.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more) (required).</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="foreignTinNotRequired">Indicates whether a foreign TIN is not legally required..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="birthday">The birthday of the individual associated with the form..</param>
        /// <param name="treatyCountry">The country for which the treaty applies.. Allowed values: US, AF, AX, AL, AG, AQ, AN, AO, AV, AY (and 248 more).</param>
        /// <param name="treatyArticle">The specific article of the treaty being claimed..</param>
        /// <param name="treatyReasons">The reasons for claiming treaty benefits..</param>
        /// <param name="withholdingRate">The withholding rate applied as per the treaty. Must be a percentage with up to two decimals (e.g., 12.50, 0).. Allowed values: 0, 0.0, 0.00, 5, 5.5, 10, 12.50, 15, 20, 25 (and 1 more).</param>
        /// <param name="incomeType">The type of income covered by the treaty..</param>
        /// <param name="signerName">The name of the signer of the form..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="companyId">The ID of the associated company. Required when creating a form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        public W8BenFormRequest(string name = default(string), CitizenshipCountryEnum citizenshipCountry = default(CitizenshipCountryEnum), string residenceAddress = default(string), string residenceCity = default(string), ResidenceStateEnum? residenceState = default(ResidenceStateEnum?), string residenceZip = default(string), ResidenceCountryEnum residenceCountry = default(ResidenceCountryEnum), bool residenceIsMailing = default(bool), string mailingAddress = default(string), string mailingCity = default(string), MailingStateEnum? mailingState = default(MailingStateEnum?), string mailingZip = default(string), MailingCountryEnum mailingCountry = default(MailingCountryEnum), string tin = default(string), bool foreignTinNotRequired = default(bool), string foreignTin = default(string), string referenceNumber = default(string), DateTime? birthday = default(DateTime?), TreatyCountryEnum? treatyCountry = default(TreatyCountryEnum?), string treatyArticle = default(string), string treatyReasons = default(string), WithholdingRateEnum? withholdingRate = default(WithholdingRateEnum?), string incomeType = default(string), string signerName = default(string), DateTime? eDeliveryConsentedAt = default(DateTime?), string signature = default(string), string companyId = default(string), string referenceId = default(string), string email = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for W8BenFormRequest and cannot be null");
            }
            this.Name = name;
            this.CitizenshipCountry = citizenshipCountry;
            this.ResidenceCountry = residenceCountry;
            this.MailingCountry = mailingCountry;
            this.ResidenceAddress = residenceAddress;
            this.ResidenceCity = residenceCity;
            this.ResidenceState = residenceState;
            this.ResidenceZip = residenceZip;
            this.ResidenceIsMailing = residenceIsMailing;
            this.MailingAddress = mailingAddress;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingZip = mailingZip;
            this.Tin = tin;
            this.ForeignTinNotRequired = foreignTinNotRequired;
            this.ForeignTin = foreignTin;
            this.ReferenceNumber = referenceNumber;
            this.Birthday = birthday;
            this.TreatyCountry = treatyCountry;
            this.TreatyArticle = treatyArticle;
            this.TreatyReasons = treatyReasons;
            this.WithholdingRate = withholdingRate;
            this.IncomeType = incomeType;
            this.SignerName = signerName;
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
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = false)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        [DataMember(Name = "residenceCity", EmitDefaultValue = false)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The ZIP code of the residence.
        /// </summary>
        /// <value>The ZIP code of the residence.</value>
        [DataMember(Name = "residenceZip", EmitDefaultValue = false)]
        public string ResidenceZip { get; set; }

        /// <summary>
        /// Indicates whether the residence address is the mailing address.
        /// </summary>
        /// <value>Indicates whether the residence address is the mailing address.</value>
        [DataMember(Name = "residenceIsMailing", EmitDefaultValue = true)]
        public bool ResidenceIsMailing { get; set; }

        /// <summary>
        /// The mailing address.
        /// </summary>
        /// <value>The mailing address.</value>
        [DataMember(Name = "mailingAddress", EmitDefaultValue = true)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// The city of the mailing address.
        /// </summary>
        /// <value>The city of the mailing address.</value>
        [DataMember(Name = "mailingCity", EmitDefaultValue = true)]
        public string MailingCity { get; set; }

        /// <summary>
        /// The ZIP code of the mailing address.
        /// </summary>
        /// <value>The ZIP code of the mailing address.</value>
        [DataMember(Name = "mailingZip", EmitDefaultValue = true)]
        public string MailingZip { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Indicates whether a foreign TIN is not legally required.
        /// </summary>
        /// <value>Indicates whether a foreign TIN is not legally required.</value>
        [DataMember(Name = "foreignTinNotRequired", EmitDefaultValue = true)]
        public bool ForeignTinNotRequired { get; set; }

        /// <summary>
        /// The foreign taxpayer identification number (TIN).
        /// </summary>
        /// <value>The foreign taxpayer identification number (TIN).</value>
        [DataMember(Name = "foreignTin", EmitDefaultValue = true)]
        public string ForeignTin { get; set; }

        /// <summary>
        /// A reference number for the form.
        /// </summary>
        /// <value>A reference number for the form.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The birthday of the individual associated with the form.
        /// </summary>
        /// <value>The birthday of the individual associated with the form.</value>
        [DataMember(Name = "birthday", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// The specific article of the treaty being claimed.
        /// </summary>
        /// <value>The specific article of the treaty being claimed.</value>
        [DataMember(Name = "treatyArticle", EmitDefaultValue = true)]
        public string TreatyArticle { get; set; }

        /// <summary>
        /// The reasons for claiming treaty benefits.
        /// </summary>
        /// <value>The reasons for claiming treaty benefits.</value>
        [DataMember(Name = "treatyReasons", EmitDefaultValue = true)]
        public string TreatyReasons { get; set; }

        /// <summary>
        /// The type of income covered by the treaty.
        /// </summary>
        /// <value>The type of income covered by the treaty.</value>
        [DataMember(Name = "incomeType", EmitDefaultValue = true)]
        public string IncomeType { get; set; }

        /// <summary>
        /// The name of the signer of the form.
        /// </summary>
        /// <value>The name of the signer of the form.</value>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

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
            sb.Append("class W8BenFormRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
            sb.Append("  ResidenceCity: ").Append(ResidenceCity).Append("\n");
            sb.Append("  ResidenceState: ").Append(ResidenceState).Append("\n");
            sb.Append("  ResidenceZip: ").Append(ResidenceZip).Append("\n");
            sb.Append("  ResidenceCountry: ").Append(ResidenceCountry).Append("\n");
            sb.Append("  ResidenceIsMailing: ").Append(ResidenceIsMailing).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  MailingCity: ").Append(MailingCity).Append("\n");
            sb.Append("  MailingState: ").Append(MailingState).Append("\n");
            sb.Append("  MailingZip: ").Append(MailingZip).Append("\n");
            sb.Append("  MailingCountry: ").Append(MailingCountry).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  ForeignTinNotRequired: ").Append(ForeignTinNotRequired).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  TreatyCountry: ").Append(TreatyCountry).Append("\n");
            sb.Append("  TreatyArticle: ").Append(TreatyArticle).Append("\n");
            sb.Append("  TreatyReasons: ").Append(TreatyReasons).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  IncomeType: ").Append(IncomeType).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
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
