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
    /// Form 1095-C: Employer-Provided Health Insurance Offer and Coverage
    /// </summary>
    [DataContract(Name = "Form1095C")]
    public partial class Form1095C : IValidatableObject
    {
        /// <summary>
        /// Plan start month.  The calendar month during which the plan year begins of the health plan in which the employee is offered coverage (or would be offered coverage if the employee were eligible to participate in the plan).  Available values:  - 00: None  - 01: January  - 02: February  - 03: March  - 04: April  - 05: May  - 06: June  - 07: July  - 08: August  - 09: September  - 10: October  - 11: November  - 12: December
        /// </summary>
        /// <value>Plan start month.  The calendar month during which the plan year begins of the health plan in which the employee is offered coverage (or would be offered coverage if the employee were eligible to participate in the plan).  Available values:  - 00: None  - 01: January  - 02: February  - 03: March  - 04: April  - 05: May  - 06: June  - 07: July  - 08: August  - 09: September  - 10: October  - 11: November  - 12: December</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlanStartMonthEnum
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
            _12 = 13
        }


        /// <summary>
        /// Plan start month.  The calendar month during which the plan year begins of the health plan in which the employee is offered coverage (or would be offered coverage if the employee were eligible to participate in the plan).  Available values:  - 00: None  - 01: January  - 02: February  - 03: March  - 04: April  - 05: May  - 06: June  - 07: July  - 08: August  - 09: September  - 10: October  - 11: November  - 12: December
        /// </summary>
        /// <value>Plan start month.  The calendar month during which the plan year begins of the health plan in which the employee is offered coverage (or would be offered coverage if the employee were eligible to participate in the plan).  Available values:  - 00: None  - 01: January  - 02: February  - 03: March  - 04: April  - 05: May  - 06: June  - 07: July  - 08: August  - 09: September  - 10: October  - 11: November  - 12: December</value>
        [DataMember(Name = "planStartMonth", IsRequired = true, EmitDefaultValue = true)]
        public PlanStartMonthEnum PlanStartMonth { get; set; }
        /// <summary>
        /// Form type.
        /// </summary>
        /// <value>Form type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Form1099Nec for value: Form1099Nec
            /// </summary>
            [EnumMember(Value = "Form1099Nec")]
            Form1099Nec = 1,

            /// <summary>
            /// Enum Form1099Misc for value: Form1099Misc
            /// </summary>
            [EnumMember(Value = "Form1099Misc")]
            Form1099Misc = 2,

            /// <summary>
            /// Enum Form1099Div for value: Form1099Div
            /// </summary>
            [EnumMember(Value = "Form1099Div")]
            Form1099Div = 3,

            /// <summary>
            /// Enum Form1099R for value: Form1099R
            /// </summary>
            [EnumMember(Value = "Form1099R")]
            Form1099R = 4,

            /// <summary>
            /// Enum Form1099K for value: Form1099K
            /// </summary>
            [EnumMember(Value = "Form1099K")]
            Form1099K = 5,

            /// <summary>
            /// Enum Form1095B for value: Form1095B
            /// </summary>
            [EnumMember(Value = "Form1095B")]
            Form1095B = 6,

            /// <summary>
            /// Enum Form1042S for value: Form1042S
            /// </summary>
            [EnumMember(Value = "Form1042S")]
            Form1042S = 7,

            /// <summary>
            /// Enum Form1095C for value: Form1095C
            /// </summary>
            [EnumMember(Value = "Form1095C")]
            Form1095C = 8,

            /// <summary>
            /// Enum Form1099Int for value: Form1099Int
            /// </summary>
            [EnumMember(Value = "Form1099Int")]
            Form1099Int = 9
        }


        /// <summary>
        /// Form type.
        /// </summary>
        /// <value>Form type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number</value>
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
            ATIN = 4
        }


        /// <summary>
        /// Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number
        /// </summary>
        /// <value>Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number</value>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1095C" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1095C() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1095C" /> class.
        /// </summary>
        /// <param name="employeeFirstName">Employee&#39;s first name (required).</param>
        /// <param name="employeeMiddleName">Employee&#39;s middle name.</param>
        /// <param name="employeeLastName">Employee&#39;s last name (required).</param>
        /// <param name="employeeNameSuffix">Employee&#39;s name suffix.</param>
        /// <param name="recipientDateOfBirth">Recipient&#39;s date of birth.</param>
        /// <param name="planStartMonth">Plan start month.  The calendar month during which the plan year begins of the health plan in which the employee is offered coverage (or would be offered coverage if the employee were eligible to participate in the plan).  Available values:  - 00: None  - 01: January  - 02: February  - 03: March  - 04: April  - 05: May  - 06: June  - 07: July  - 08: August  - 09: September  - 10: October  - 11: November  - 12: December (required).</param>
        /// <param name="employerProvidedSiCoverage">Employer provided self-insured coverage.</param>
        /// <param name="offerAndCoverages">Offer and coverage information (required).</param>
        /// <param name="coveredIndividuals">Covered individuals information.</param>
        /// <param name="type">Form type. (required).</param>
        /// <param name="issuerId">Issuer ID - only required when creating forms.</param>
        /// <param name="issuerReferenceId">Issuer Reference ID - only required when creating forms via $bulk-upsert.</param>
        /// <param name="issuerTin">Issuer TIN - readonly.</param>
        /// <param name="taxYear">Tax Year - only required when creating forms via $bulk-upsert.</param>
        /// <param name="referenceId">Internal reference ID. Never shown to any agency or recipient..</param>
        /// <param name="tin">Recipient&#39;s Federal Tax Identification Number (TIN)..</param>
        /// <param name="recipientName">Recipient name (required).</param>
        /// <param name="tinType">Tax Identification Number (TIN) type.  Available values: - EIN: Employer Identification Number - SSN: Social Security Number - ITIN: Individual Taxpayer Identification Number - ATIN: Adoption Taxpayer Identification Number.</param>
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
        /// <param name="federalEfileDate">Date when federal e-filing should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEfileDate">Date when state e-filing should be scheduled. Must be on or after federalEfileDate. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="recipientEdeliveryDate">Date when recipient e-delivery should be scheduled. If set between current date and beginning of blackout period, scheduled to that date. If in the past or blackout period, scheduled to next available date. For blackout period information, see https://www.track1099.com/info/IRS_info. Set to null to leave unscheduled..</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="noTin">No TIN indicator.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        /// <param name="secondTinNotice">Second TIN notice.</param>
        public Form1095C(string employeeFirstName = default(string), string employeeMiddleName = default(string), string employeeLastName = default(string), string employeeNameSuffix = default(string), DateTime? recipientDateOfBirth = default(DateTime?), PlanStartMonthEnum planStartMonth = default(PlanStartMonthEnum), bool? employerProvidedSiCoverage = default(bool?), List<OfferAndCoverage> offerAndCoverages = default(List<OfferAndCoverage>), List<CoveredIndividual> coveredIndividuals = default(List<CoveredIndividual>), TypeEnum type = default(TypeEnum), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int? taxYear = default(int?), string referenceId = default(string), string tin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), DateTime? federalEfileDate = default(DateTime?), bool? postalMail = default(bool?), DateTime? stateEfileDate = default(DateTime?), DateTime? recipientEdeliveryDate = default(DateTime?), bool? tinMatch = default(bool?), bool? noTin = default(bool?), bool? addressVerification = default(bool?), StateAndLocalWithholding stateAndLocalWithholding = default(StateAndLocalWithholding), bool? secondTinNotice = default(bool?))
        {
            // to ensure "employeeFirstName" is required (not null)
            if (employeeFirstName == null)
            {
                throw new ArgumentNullException("employeeFirstName is a required property for Form1095C and cannot be null");
            }
            this.EmployeeFirstName = employeeFirstName;
            // to ensure "employeeLastName" is required (not null)
            if (employeeLastName == null)
            {
                throw new ArgumentNullException("employeeLastName is a required property for Form1095C and cannot be null");
            }
            this.EmployeeLastName = employeeLastName;
            this.PlanStartMonth = planStartMonth;
            // to ensure "offerAndCoverages" is required (not null)
            if (offerAndCoverages == null)
            {
                throw new ArgumentNullException("offerAndCoverages is a required property for Form1095C and cannot be null");
            }
            this.OfferAndCoverages = offerAndCoverages;
            this.Type = type;
            // to ensure "recipientName" is required (not null)
            if (recipientName == null)
            {
                throw new ArgumentNullException("recipientName is a required property for Form1095C and cannot be null");
            }
            this.RecipientName = recipientName;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Form1095C and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Form1095C and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1095C and cannot be null");
            }
            this.CountryCode = countryCode;
            this.EmployeeMiddleName = employeeMiddleName;
            this.EmployeeNameSuffix = employeeNameSuffix;
            this.RecipientDateOfBirth = recipientDateOfBirth;
            this.EmployerProvidedSiCoverage = employerProvidedSiCoverage;
            this.CoveredIndividuals = coveredIndividuals;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Tin = tin;
            this.TinType = tinType;
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
        /// Employee&#39;s first name
        /// </summary>
        /// <value>Employee&#39;s first name</value>
        [DataMember(Name = "employeeFirstName", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeFirstName { get; set; }

        /// <summary>
        /// Employee&#39;s middle name
        /// </summary>
        /// <value>Employee&#39;s middle name</value>
        [DataMember(Name = "employeeMiddleName", EmitDefaultValue = true)]
        public string EmployeeMiddleName { get; set; }

        /// <summary>
        /// Employee&#39;s last name
        /// </summary>
        /// <value>Employee&#39;s last name</value>
        [DataMember(Name = "employeeLastName", IsRequired = true, EmitDefaultValue = true)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// Employee&#39;s name suffix
        /// </summary>
        /// <value>Employee&#39;s name suffix</value>
        [DataMember(Name = "employeeNameSuffix", EmitDefaultValue = true)]
        public string EmployeeNameSuffix { get; set; }

        /// <summary>
        /// Recipient&#39;s date of birth
        /// </summary>
        /// <value>Recipient&#39;s date of birth</value>
        [DataMember(Name = "recipientDateOfBirth", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? RecipientDateOfBirth { get; set; }

        /// <summary>
        /// Employer provided self-insured coverage
        /// </summary>
        /// <value>Employer provided self-insured coverage</value>
        [DataMember(Name = "employerProvidedSiCoverage", EmitDefaultValue = true)]
        public bool? EmployerProvidedSiCoverage { get; set; }

        /// <summary>
        /// Offer and coverage information
        /// </summary>
        /// <value>Offer and coverage information</value>
        [DataMember(Name = "offerAndCoverages", IsRequired = true, EmitDefaultValue = true)]
        public List<OfferAndCoverage> OfferAndCoverages { get; set; }

        /// <summary>
        /// Covered individuals information
        /// </summary>
        /// <value>Covered individuals information</value>
        [DataMember(Name = "coveredIndividuals", EmitDefaultValue = false)]
        public List<CoveredIndividual> CoveredIndividuals { get; set; }

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
        public bool? SecondTinNotice { get; set; }

        /// <summary>
        /// Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)
        /// </summary>
        /// <value>Federal e-file status.  Available values:  - unscheduled: Form has not been scheduled for federal e-filing  - scheduled: Form is scheduled for federal e-filing  - airlock: Form is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - sent: Form has been sent to the IRS  - accepted: Form was accepted by the IRS  - corrected_scheduled: Correction is scheduled to be sent  - corrected_airlock: Correction is in process of being uploaded to the IRS (forms exist in this state for a very short period and cannot be updated while in this state)  - corrected: A correction has been sent to the IRS  - corrected_accepted: Correction was accepted by the IRS  - rejected: Form was rejected by the IRS  - corrected_rejected: Correction was rejected by the IRS  - held: Form is held and will not be submitted to IRS (used for certain forms submitted only to states)</value>
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
            sb.Append("class Form1095C {\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeMiddleName: ").Append(EmployeeMiddleName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  EmployeeNameSuffix: ").Append(EmployeeNameSuffix).Append("\n");
            sb.Append("  RecipientDateOfBirth: ").Append(RecipientDateOfBirth).Append("\n");
            sb.Append("  PlanStartMonth: ").Append(PlanStartMonth).Append("\n");
            sb.Append("  EmployerProvidedSiCoverage: ").Append(EmployerProvidedSiCoverage).Append("\n");
            sb.Append("  OfferAndCoverages: ").Append(OfferAndCoverages).Append("\n");
            sb.Append("  CoveredIndividuals: ").Append(CoveredIndividuals).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
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
