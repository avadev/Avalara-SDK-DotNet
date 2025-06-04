/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 API Definition
 *
 * ## Authentication Use **username/password** or **generate a license** key from: Avalara Portal → Settings → License and API Keys  More info on authentication: [Avalara Authentication Methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  Validate your credentials here: [Test Credentials](https://developer.avalara.com/avatax/test-credentials/)  ## API & SDK Docs [Avalara (C#/.NET) SDK on GitHub](https://github.com/avadev/Avalara-SDK-DotNet/tree/main#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples for 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// StateEfileStatusesInner
    /// </summary>
    [DataContract(Name = "stateEfileStatuses_inner")]
    public partial class StateEfileStatusesInner : IValidatableObject
    {
        /// <summary>
        /// The jurisdiction of the state e-filing.
        /// </summary>
        /// <value>The jurisdiction of the state e-filing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JurisdictionEnum
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
        /// The jurisdiction of the state e-filing.
        /// </summary>
        /// <value>The jurisdiction of the state e-filing.</value>
        /// <example>Filed</example>
        [DataMember(Name = "jurisdiction", EmitDefaultValue = false)]
        public JurisdictionEnum? Jurisdiction { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Unscheduled for value: unscheduled
            /// </summary>
            [EnumMember(Value = "unscheduled")]
            Unscheduled = 1,

            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled = 2,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 3,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 4,

            /// <summary>
            /// Enum Accepted for value: accepted
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted = 5,

            /// <summary>
            /// Enum CorrectedScheduled for value: correctedScheduled
            /// </summary>
            [EnumMember(Value = "correctedScheduled")]
            CorrectedScheduled = 6,

            /// <summary>
            /// Enum CorrectedSent for value: correctedSent
            /// </summary>
            [EnumMember(Value = "correctedSent")]
            CorrectedSent = 7,

            /// <summary>
            /// Enum CorrectedRejected for value: correctedRejected
            /// </summary>
            [EnumMember(Value = "correctedRejected")]
            CorrectedRejected = 8,

            /// <summary>
            /// Enum CorrectedAccepted for value: correctedAccepted
            /// </summary>
            [EnumMember(Value = "correctedAccepted")]
            CorrectedAccepted = 9
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>accepted</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StateEfileStatusesInner" /> class.
        /// </summary>
        /// <param name="jurisdiction">The jurisdiction of the state e-filing..</param>
        /// <param name="date">Date time when the status was set.</param>
        /// <param name="status">status.</param>
        public StateEfileStatusesInner(JurisdictionEnum? jurisdiction = default(JurisdictionEnum?), DateTime date = default(DateTime), StatusEnum? status = default(StatusEnum?))
        {
            this.Jurisdiction = jurisdiction;
            this.Date = date;
            this.Status = status;
        }

        /// <summary>
        /// Date time when the status was set
        /// </summary>
        /// <value>Date time when the status was set</value>
        /// <example>2025-01-26T15:19:42Z</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateEfileStatusesInner {\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
