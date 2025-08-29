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
    /// Offer and coverage information for health coverage forms
    /// </summary>
    [DataContract(Name = "OfferAndCoverage")]
    public partial class OfferAndCoverage : IValidatableObject
    {
        /// <summary>
        /// Month of coverage.  Available values:  - All: All months  - January: January  - February: February  - March: March  - April: April  - May: May  - June: June  - July: July  - August: August  - September: September  - October: October  - November: November  - December: December
        /// </summary>
        /// <value>Month of coverage.  Available values:  - All: All months  - January: January  - February: February  - March: March  - April: April  - May: May  - June: June  - July: July  - August: August  - September: September  - October: October  - November: November  - December: December</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MonthEnum
        {
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 1,

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
            _12 = 13
        }


        /// <summary>
        /// Month of coverage.  Available values:  - All: All months  - January: January  - February: February  - March: March  - April: April  - May: May  - June: June  - July: July  - August: August  - September: September  - October: October  - November: November  - December: December
        /// </summary>
        /// <value>Month of coverage.  Available values:  - All: All months  - January: January  - February: February  - March: March  - April: April  - May: May  - June: June  - July: July  - August: August  - September: September  - October: October  - November: November  - December: December</value>
        [DataMember(Name = "month", EmitDefaultValue = true)]
        public MonthEnum? Month { get; set; }
        /// <summary>
        /// Offer of Coverage Code. Required if Share has a value, including zero.  Available values:    Pre-ICHRA Codes (available before 2020):  - 1A: Qualifying offer: minimum essential coverage providing minimum value offered to full-time employee with employee required contribution ≤ 9.5% (as adjusted) of mainland single federal poverty line and at least minimum essential coverage offered to spouse and dependent(s)  - 1B: Minimum essential coverage providing minimum value offered to employee only  - 1C: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) (not spouse)  - 1D: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to spouse (not dependent(s))  - 1E: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) and spouse  - 1F: Minimum essential coverage NOT providing minimum value offered to employee; employee and spouse or dependent(s); or employee, spouse, and dependents  - 1G: Offer of coverage to an individual who was not an employee or not a full-time employee and who enrolled in self-insured coverage  - 1H: No offer of coverage (employee not offered any health coverage or employee offered coverage that is not minimum essential coverage)  - 1J: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage conditionally offered to spouse; minimum essential coverage not offered to dependent(s)  - 1K: Minimum essential coverage providing minimum value offered to employee; at least minimum essential coverage offered to dependents; and at least minimum essential coverage conditionally offered to spouse                ICHRA Codes (introduced 2020, require ZIP code):  - 1L: Individual coverage HRA offered to employee only  - 1M: Individual coverage HRA offered to employee and dependent(s) (not spouse)  - 1N: Individual coverage HRA offered to employee, spouse, and dependent(s)  - 1O: Individual coverage HRA offered to employee only using employment site ZIP code affordability safe harbor  - 1P: Individual coverage HRA offered to employee and dependent(s) (not spouse) using employment site ZIP code affordability safe harbor  - 1Q: Individual coverage HRA offered to employee, spouse, and dependent(s) using employment site ZIP code affordability safe harbor  - 1R: Individual coverage HRA that is NOT affordable  - 1S: Individual coverage HRA offered to an individual who was not a full-time employee  - 1T: Individual coverage HRA offered to employee and spouse (not dependents)  - 1U: Individual coverage HRA offered to employee and spouse (not dependents) using employment site ZIP code affordability safe harbor    Note: Codes 1B, 1C, 1D, 1E, 1J, 1K, 1L, 1M, 1N, 1O, 1P, 1Q, 1T, 1U require employee share amount (0.00 is a valid value).
        /// </summary>
        /// <value>Offer of Coverage Code. Required if Share has a value, including zero.  Available values:    Pre-ICHRA Codes (available before 2020):  - 1A: Qualifying offer: minimum essential coverage providing minimum value offered to full-time employee with employee required contribution ≤ 9.5% (as adjusted) of mainland single federal poverty line and at least minimum essential coverage offered to spouse and dependent(s)  - 1B: Minimum essential coverage providing minimum value offered to employee only  - 1C: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) (not spouse)  - 1D: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to spouse (not dependent(s))  - 1E: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) and spouse  - 1F: Minimum essential coverage NOT providing minimum value offered to employee; employee and spouse or dependent(s); or employee, spouse, and dependents  - 1G: Offer of coverage to an individual who was not an employee or not a full-time employee and who enrolled in self-insured coverage  - 1H: No offer of coverage (employee not offered any health coverage or employee offered coverage that is not minimum essential coverage)  - 1J: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage conditionally offered to spouse; minimum essential coverage not offered to dependent(s)  - 1K: Minimum essential coverage providing minimum value offered to employee; at least minimum essential coverage offered to dependents; and at least minimum essential coverage conditionally offered to spouse                ICHRA Codes (introduced 2020, require ZIP code):  - 1L: Individual coverage HRA offered to employee only  - 1M: Individual coverage HRA offered to employee and dependent(s) (not spouse)  - 1N: Individual coverage HRA offered to employee, spouse, and dependent(s)  - 1O: Individual coverage HRA offered to employee only using employment site ZIP code affordability safe harbor  - 1P: Individual coverage HRA offered to employee and dependent(s) (not spouse) using employment site ZIP code affordability safe harbor  - 1Q: Individual coverage HRA offered to employee, spouse, and dependent(s) using employment site ZIP code affordability safe harbor  - 1R: Individual coverage HRA that is NOT affordable  - 1S: Individual coverage HRA offered to an individual who was not a full-time employee  - 1T: Individual coverage HRA offered to employee and spouse (not dependents)  - 1U: Individual coverage HRA offered to employee and spouse (not dependents) using employment site ZIP code affordability safe harbor    Note: Codes 1B, 1C, 1D, 1E, 1J, 1K, 1L, 1M, 1N, 1O, 1P, 1Q, 1T, 1U require employee share amount (0.00 is a valid value).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfferCodeEnum
        {
            /// <summary>
            /// Enum _1A for value: 1A
            /// </summary>
            [EnumMember(Value = "1A")]
            _1A = 1,

            /// <summary>
            /// Enum _1B for value: 1B
            /// </summary>
            [EnumMember(Value = "1B")]
            _1B = 2,

            /// <summary>
            /// Enum _1C for value: 1C
            /// </summary>
            [EnumMember(Value = "1C")]
            _1C = 3,

            /// <summary>
            /// Enum _1D for value: 1D
            /// </summary>
            [EnumMember(Value = "1D")]
            _1D = 4,

            /// <summary>
            /// Enum _1E for value: 1E
            /// </summary>
            [EnumMember(Value = "1E")]
            _1E = 5,

            /// <summary>
            /// Enum _1F for value: 1F
            /// </summary>
            [EnumMember(Value = "1F")]
            _1F = 6,

            /// <summary>
            /// Enum _1G for value: 1G
            /// </summary>
            [EnumMember(Value = "1G")]
            _1G = 7,

            /// <summary>
            /// Enum _1H for value: 1H
            /// </summary>
            [EnumMember(Value = "1H")]
            _1H = 8,

            /// <summary>
            /// Enum _1J for value: 1J
            /// </summary>
            [EnumMember(Value = "1J")]
            _1J = 9,

            /// <summary>
            /// Enum _1K for value: 1K
            /// </summary>
            [EnumMember(Value = "1K")]
            _1K = 10,

            /// <summary>
            /// Enum _1L for value: 1L
            /// </summary>
            [EnumMember(Value = "1L")]
            _1L = 11,

            /// <summary>
            /// Enum _1M for value: 1M
            /// </summary>
            [EnumMember(Value = "1M")]
            _1M = 12,

            /// <summary>
            /// Enum _1N for value: 1N
            /// </summary>
            [EnumMember(Value = "1N")]
            _1N = 13,

            /// <summary>
            /// Enum _1O for value: 1O
            /// </summary>
            [EnumMember(Value = "1O")]
            _1O = 14,

            /// <summary>
            /// Enum _1P for value: 1P
            /// </summary>
            [EnumMember(Value = "1P")]
            _1P = 15,

            /// <summary>
            /// Enum _1Q for value: 1Q
            /// </summary>
            [EnumMember(Value = "1Q")]
            _1Q = 16,

            /// <summary>
            /// Enum _1R for value: 1R
            /// </summary>
            [EnumMember(Value = "1R")]
            _1R = 17,

            /// <summary>
            /// Enum _1S for value: 1S
            /// </summary>
            [EnumMember(Value = "1S")]
            _1S = 18,

            /// <summary>
            /// Enum _1T for value: 1T
            /// </summary>
            [EnumMember(Value = "1T")]
            _1T = 19,

            /// <summary>
            /// Enum _1U for value: 1U
            /// </summary>
            [EnumMember(Value = "1U")]
            _1U = 20
        }


        /// <summary>
        /// Offer of Coverage Code. Required if Share has a value, including zero.  Available values:    Pre-ICHRA Codes (available before 2020):  - 1A: Qualifying offer: minimum essential coverage providing minimum value offered to full-time employee with employee required contribution ≤ 9.5% (as adjusted) of mainland single federal poverty line and at least minimum essential coverage offered to spouse and dependent(s)  - 1B: Minimum essential coverage providing minimum value offered to employee only  - 1C: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) (not spouse)  - 1D: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to spouse (not dependent(s))  - 1E: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) and spouse  - 1F: Minimum essential coverage NOT providing minimum value offered to employee; employee and spouse or dependent(s); or employee, spouse, and dependents  - 1G: Offer of coverage to an individual who was not an employee or not a full-time employee and who enrolled in self-insured coverage  - 1H: No offer of coverage (employee not offered any health coverage or employee offered coverage that is not minimum essential coverage)  - 1J: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage conditionally offered to spouse; minimum essential coverage not offered to dependent(s)  - 1K: Minimum essential coverage providing minimum value offered to employee; at least minimum essential coverage offered to dependents; and at least minimum essential coverage conditionally offered to spouse                ICHRA Codes (introduced 2020, require ZIP code):  - 1L: Individual coverage HRA offered to employee only  - 1M: Individual coverage HRA offered to employee and dependent(s) (not spouse)  - 1N: Individual coverage HRA offered to employee, spouse, and dependent(s)  - 1O: Individual coverage HRA offered to employee only using employment site ZIP code affordability safe harbor  - 1P: Individual coverage HRA offered to employee and dependent(s) (not spouse) using employment site ZIP code affordability safe harbor  - 1Q: Individual coverage HRA offered to employee, spouse, and dependent(s) using employment site ZIP code affordability safe harbor  - 1R: Individual coverage HRA that is NOT affordable  - 1S: Individual coverage HRA offered to an individual who was not a full-time employee  - 1T: Individual coverage HRA offered to employee and spouse (not dependents)  - 1U: Individual coverage HRA offered to employee and spouse (not dependents) using employment site ZIP code affordability safe harbor    Note: Codes 1B, 1C, 1D, 1E, 1J, 1K, 1L, 1M, 1N, 1O, 1P, 1Q, 1T, 1U require employee share amount (0.00 is a valid value).
        /// </summary>
        /// <value>Offer of Coverage Code. Required if Share has a value, including zero.  Available values:    Pre-ICHRA Codes (available before 2020):  - 1A: Qualifying offer: minimum essential coverage providing minimum value offered to full-time employee with employee required contribution ≤ 9.5% (as adjusted) of mainland single federal poverty line and at least minimum essential coverage offered to spouse and dependent(s)  - 1B: Minimum essential coverage providing minimum value offered to employee only  - 1C: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) (not spouse)  - 1D: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to spouse (not dependent(s))  - 1E: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) and spouse  - 1F: Minimum essential coverage NOT providing minimum value offered to employee; employee and spouse or dependent(s); or employee, spouse, and dependents  - 1G: Offer of coverage to an individual who was not an employee or not a full-time employee and who enrolled in self-insured coverage  - 1H: No offer of coverage (employee not offered any health coverage or employee offered coverage that is not minimum essential coverage)  - 1J: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage conditionally offered to spouse; minimum essential coverage not offered to dependent(s)  - 1K: Minimum essential coverage providing minimum value offered to employee; at least minimum essential coverage offered to dependents; and at least minimum essential coverage conditionally offered to spouse                ICHRA Codes (introduced 2020, require ZIP code):  - 1L: Individual coverage HRA offered to employee only  - 1M: Individual coverage HRA offered to employee and dependent(s) (not spouse)  - 1N: Individual coverage HRA offered to employee, spouse, and dependent(s)  - 1O: Individual coverage HRA offered to employee only using employment site ZIP code affordability safe harbor  - 1P: Individual coverage HRA offered to employee and dependent(s) (not spouse) using employment site ZIP code affordability safe harbor  - 1Q: Individual coverage HRA offered to employee, spouse, and dependent(s) using employment site ZIP code affordability safe harbor  - 1R: Individual coverage HRA that is NOT affordable  - 1S: Individual coverage HRA offered to an individual who was not a full-time employee  - 1T: Individual coverage HRA offered to employee and spouse (not dependents)  - 1U: Individual coverage HRA offered to employee and spouse (not dependents) using employment site ZIP code affordability safe harbor    Note: Codes 1B, 1C, 1D, 1E, 1J, 1K, 1L, 1M, 1N, 1O, 1P, 1Q, 1T, 1U require employee share amount (0.00 is a valid value).</value>
        [DataMember(Name = "offerCode", EmitDefaultValue = true)]
        public OfferCodeEnum? OfferCode { get; set; }
        /// <summary>
        /// Safe harbor code - Applicable Section 4980H Safe Harbor Code.  Available values:  - 2A: Form W-2 safe harbor  - 2B: Federal poverty line safe harbor  - 2C: Rate of pay safe harbor  - 2D: Part-time employee safe harbor for employees who were not full-time for any month of the year  - 2E: Multiemployer interim rule relief  - 2F: Qualifying offer method  - 2G: Qualifying offer transition relief  - 2H: Other affordability safe harbor
        /// </summary>
        /// <value>Safe harbor code - Applicable Section 4980H Safe Harbor Code.  Available values:  - 2A: Form W-2 safe harbor  - 2B: Federal poverty line safe harbor  - 2C: Rate of pay safe harbor  - 2D: Part-time employee safe harbor for employees who were not full-time for any month of the year  - 2E: Multiemployer interim rule relief  - 2F: Qualifying offer method  - 2G: Qualifying offer transition relief  - 2H: Other affordability safe harbor</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SafeHarborCodeEnum
        {
            /// <summary>
            /// Enum _2A for value: 2A
            /// </summary>
            [EnumMember(Value = "2A")]
            _2A = 1,

            /// <summary>
            /// Enum _2B for value: 2B
            /// </summary>
            [EnumMember(Value = "2B")]
            _2B = 2,

            /// <summary>
            /// Enum _2C for value: 2C
            /// </summary>
            [EnumMember(Value = "2C")]
            _2C = 3,

            /// <summary>
            /// Enum _2D for value: 2D
            /// </summary>
            [EnumMember(Value = "2D")]
            _2D = 4,

            /// <summary>
            /// Enum _2E for value: 2E
            /// </summary>
            [EnumMember(Value = "2E")]
            _2E = 5,

            /// <summary>
            /// Enum _2F for value: 2F
            /// </summary>
            [EnumMember(Value = "2F")]
            _2F = 6,

            /// <summary>
            /// Enum _2G for value: 2G
            /// </summary>
            [EnumMember(Value = "2G")]
            _2G = 7,

            /// <summary>
            /// Enum _2H for value: 2H
            /// </summary>
            [EnumMember(Value = "2H")]
            _2H = 8
        }


        /// <summary>
        /// Safe harbor code - Applicable Section 4980H Safe Harbor Code.  Available values:  - 2A: Form W-2 safe harbor  - 2B: Federal poverty line safe harbor  - 2C: Rate of pay safe harbor  - 2D: Part-time employee safe harbor for employees who were not full-time for any month of the year  - 2E: Multiemployer interim rule relief  - 2F: Qualifying offer method  - 2G: Qualifying offer transition relief  - 2H: Other affordability safe harbor
        /// </summary>
        /// <value>Safe harbor code - Applicable Section 4980H Safe Harbor Code.  Available values:  - 2A: Form W-2 safe harbor  - 2B: Federal poverty line safe harbor  - 2C: Rate of pay safe harbor  - 2D: Part-time employee safe harbor for employees who were not full-time for any month of the year  - 2E: Multiemployer interim rule relief  - 2F: Qualifying offer method  - 2G: Qualifying offer transition relief  - 2H: Other affordability safe harbor</value>
        [DataMember(Name = "safeHarborCode", EmitDefaultValue = true)]
        public SafeHarborCodeEnum? SafeHarborCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferAndCoverage" /> class.
        /// </summary>
        /// <param name="month">Month of coverage.  Available values:  - All: All months  - January: January  - February: February  - March: March  - April: April  - May: May  - June: June  - July: July  - August: August  - September: September  - October: October  - November: November  - December: December.</param>
        /// <param name="offerCode">Offer of Coverage Code. Required if Share has a value, including zero.  Available values:    Pre-ICHRA Codes (available before 2020):  - 1A: Qualifying offer: minimum essential coverage providing minimum value offered to full-time employee with employee required contribution ≤ 9.5% (as adjusted) of mainland single federal poverty line and at least minimum essential coverage offered to spouse and dependent(s)  - 1B: Minimum essential coverage providing minimum value offered to employee only  - 1C: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) (not spouse)  - 1D: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to spouse (not dependent(s))  - 1E: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage offered to dependent(s) and spouse  - 1F: Minimum essential coverage NOT providing minimum value offered to employee; employee and spouse or dependent(s); or employee, spouse, and dependents  - 1G: Offer of coverage to an individual who was not an employee or not a full-time employee and who enrolled in self-insured coverage  - 1H: No offer of coverage (employee not offered any health coverage or employee offered coverage that is not minimum essential coverage)  - 1J: Minimum essential coverage providing minimum value offered to employee and at least minimum essential coverage conditionally offered to spouse; minimum essential coverage not offered to dependent(s)  - 1K: Minimum essential coverage providing minimum value offered to employee; at least minimum essential coverage offered to dependents; and at least minimum essential coverage conditionally offered to spouse                ICHRA Codes (introduced 2020, require ZIP code):  - 1L: Individual coverage HRA offered to employee only  - 1M: Individual coverage HRA offered to employee and dependent(s) (not spouse)  - 1N: Individual coverage HRA offered to employee, spouse, and dependent(s)  - 1O: Individual coverage HRA offered to employee only using employment site ZIP code affordability safe harbor  - 1P: Individual coverage HRA offered to employee and dependent(s) (not spouse) using employment site ZIP code affordability safe harbor  - 1Q: Individual coverage HRA offered to employee, spouse, and dependent(s) using employment site ZIP code affordability safe harbor  - 1R: Individual coverage HRA that is NOT affordable  - 1S: Individual coverage HRA offered to an individual who was not a full-time employee  - 1T: Individual coverage HRA offered to employee and spouse (not dependents)  - 1U: Individual coverage HRA offered to employee and spouse (not dependents) using employment site ZIP code affordability safe harbor    Note: Codes 1B, 1C, 1D, 1E, 1J, 1K, 1L, 1M, 1N, 1O, 1P, 1Q, 1T, 1U require employee share amount (0.00 is a valid value)..</param>
        /// <param name="share">Employee required contribution share - Employee Share of Lowest Cost Monthly Premium, for Self-Only Minimum Value Coverage - May not exceed 3499.99.</param>
        /// <param name="safeHarborCode">Safe harbor code - Applicable Section 4980H Safe Harbor Code.  Available values:  - 2A: Form W-2 safe harbor  - 2B: Federal poverty line safe harbor  - 2C: Rate of pay safe harbor  - 2D: Part-time employee safe harbor for employees who were not full-time for any month of the year  - 2E: Multiemployer interim rule relief  - 2F: Qualifying offer method  - 2G: Qualifying offer transition relief  - 2H: Other affordability safe harbor.</param>
        /// <param name="zipCode">ZIP/postal code. For coverage area (optional, unless codes 1L to 1U are used)..</param>
        public OfferAndCoverage(MonthEnum? month = default(MonthEnum?), OfferCodeEnum? offerCode = default(OfferCodeEnum?), double? share = default(double?), SafeHarborCodeEnum? safeHarborCode = default(SafeHarborCodeEnum?), string zipCode = default(string))
        {
            this.Month = month;
            this.OfferCode = offerCode;
            this.Share = share;
            this.SafeHarborCode = safeHarborCode;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Employee required contribution share - Employee Share of Lowest Cost Monthly Premium, for Self-Only Minimum Value Coverage - May not exceed 3499.99
        /// </summary>
        /// <value>Employee required contribution share - Employee Share of Lowest Cost Monthly Premium, for Self-Only Minimum Value Coverage - May not exceed 3499.99</value>
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public double? Share { get; set; }

        /// <summary>
        /// ZIP/postal code. For coverage area (optional, unless codes 1L to 1U are used).
        /// </summary>
        /// <value>ZIP/postal code. For coverage area (optional, unless codes 1L to 1U are used).</value>
        [DataMember(Name = "zipCode", EmitDefaultValue = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferAndCoverage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  OfferCode: ").Append(OfferCode).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  SafeHarborCode: ").Append(SafeHarborCode).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
