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
    /// Form1099DivRequest
    /// </summary>
    [DataContract(Name = "Form1099DivRequest")]
    public partial class Form1099DivRequest : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
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
            _1095C = 8
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>1099-NEC</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN
        /// </summary>
        /// <value>Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN</value>
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
        /// Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN
        /// </summary>
        /// <value>Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN</value>
        /// <example>EIN</example>
        [DataMember(Name = "tinType", EmitDefaultValue = false)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099DivRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099DivRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099DivRequest" /> class.
        /// </summary>
        /// <param name="totalOrdinaryDividends">Total ordinary dividends.</param>
        /// <param name="qualifiedDividends">Qualified dividends.</param>
        /// <param name="totalCapitalGainDistributions">Total capital gain distributions.</param>
        /// <param name="unrecapturedSection1250Gain">Unrecaptured Section 1250 gain.</param>
        /// <param name="section1202Gain">Section 1202 gain.</param>
        /// <param name="collectiblesGain">Collectibles (28%) gain.</param>
        /// <param name="section897OrdinaryDividends">Section 897 ordinary dividends.</param>
        /// <param name="section897CapitalGain">Section 897 capital gain.</param>
        /// <param name="nondividendDistributions">Nondividend distributions.</param>
        /// <param name="federalIncomeTaxWithheld">Federal income tax withheld.</param>
        /// <param name="section199ADividends">Section 199A dividends.</param>
        /// <param name="investmentExpenses">Investment expenses.</param>
        /// <param name="foreignTaxPaid">Foreign tax paid.</param>
        /// <param name="foreignCountryOrUSPossession">Foreign country or U.S. possession.</param>
        /// <param name="cashLiquidationDistributions">Cash liquidation distributions.</param>
        /// <param name="noncashLiquidationDistributions">Noncash liquidation distributions.</param>
        /// <param name="exemptInterestDividends">Exempt-interest dividends.</param>
        /// <param name="specifiedPrivateActivityBondInterestDividends">Specified private activity bond interest dividends.</param>
        /// <param name="fatcaFilingRequirement">FATCA filing requirement.</param>
        /// <param name="type">type.</param>
        /// <param name="issuerId">Issuer ID.</param>
        /// <param name="referenceId">Reference ID.</param>
        /// <param name="recipientTin">Recipient Tax ID Number.</param>
        /// <param name="recipientName">Recipient name.</param>
        /// <param name="tinType">Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address (required).</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="city">City (required).</param>
        /// <param name="state">US state. Required if CountryCode is \&quot;US\&quot;..</param>
        /// <param name="zip">Zip/postal code.</param>
        /// <param name="email">Recipient email address.</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="officeCode">Office code.</param>
        /// <param name="nonUsProvince">Foreign province.</param>
        /// <param name="countryCode">Country code, as defined at https://www.irs.gov/e-file-providers/country-codes (required).</param>
        /// <param name="federalEFile">Boolean indicating that federal e-filing should be scheduled for this form.</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEFile">Boolean indicating that state e-filing should be scheduled for this form.</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="noTin">Indicates whether the recipient has no TIN.</param>
        /// <param name="secondTinNotice">Second TIN notice in three years.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        public Form1099DivRequest(string totalOrdinaryDividends = default(string), string qualifiedDividends = default(string), string totalCapitalGainDistributions = default(string), string unrecapturedSection1250Gain = default(string), string section1202Gain = default(string), string collectiblesGain = default(string), string section897OrdinaryDividends = default(string), string section897CapitalGain = default(string), string nondividendDistributions = default(string), string federalIncomeTaxWithheld = default(string), string section199ADividends = default(string), string investmentExpenses = default(string), string foreignTaxPaid = default(string), string foreignCountryOrUSPossession = default(string), string cashLiquidationDistributions = default(string), string noncashLiquidationDistributions = default(string), string exemptInterestDividends = default(string), string specifiedPrivateActivityBondInterestDividends = default(string), bool? fatcaFilingRequirement = default(bool?), TypeEnum? type = default(TypeEnum?), string issuerId = default(string), string referenceId = default(string), string recipientTin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool noTin = default(bool), bool? secondTinNotice = default(bool?), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Form1099DivRequest and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Form1099DivRequest and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1099DivRequest and cannot be null");
            }
            this.CountryCode = countryCode;
            this.TotalOrdinaryDividends = totalOrdinaryDividends;
            this.QualifiedDividends = qualifiedDividends;
            this.TotalCapitalGainDistributions = totalCapitalGainDistributions;
            this.UnrecapturedSection1250Gain = unrecapturedSection1250Gain;
            this.Section1202Gain = section1202Gain;
            this.CollectiblesGain = collectiblesGain;
            this.Section897OrdinaryDividends = section897OrdinaryDividends;
            this.Section897CapitalGain = section897CapitalGain;
            this.NondividendDistributions = nondividendDistributions;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.Section199ADividends = section199ADividends;
            this.InvestmentExpenses = investmentExpenses;
            this.ForeignTaxPaid = foreignTaxPaid;
            this.ForeignCountryOrUSPossession = foreignCountryOrUSPossession;
            this.CashLiquidationDistributions = cashLiquidationDistributions;
            this.NoncashLiquidationDistributions = noncashLiquidationDistributions;
            this.ExemptInterestDividends = exemptInterestDividends;
            this.SpecifiedPrivateActivityBondInterestDividends = specifiedPrivateActivityBondInterestDividends;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.Type = type;
            this.IssuerId = issuerId;
            this.ReferenceId = referenceId;
            this.RecipientTin = recipientTin;
            this.RecipientName = recipientName;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.Address2 = address2;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.NonUsProvince = nonUsProvince;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.NoTin = noTin;
            this.SecondTinNotice = secondTinNotice;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Total ordinary dividends
        /// </summary>
        /// <value>Total ordinary dividends</value>
        [DataMember(Name = "totalOrdinaryDividends", EmitDefaultValue = true)]
        public string TotalOrdinaryDividends { get; set; }

        /// <summary>
        /// Qualified dividends
        /// </summary>
        /// <value>Qualified dividends</value>
        [DataMember(Name = "qualifiedDividends", EmitDefaultValue = true)]
        public string QualifiedDividends { get; set; }

        /// <summary>
        /// Total capital gain distributions
        /// </summary>
        /// <value>Total capital gain distributions</value>
        [DataMember(Name = "totalCapitalGainDistributions", EmitDefaultValue = true)]
        public string TotalCapitalGainDistributions { get; set; }

        /// <summary>
        /// Unrecaptured Section 1250 gain
        /// </summary>
        /// <value>Unrecaptured Section 1250 gain</value>
        [DataMember(Name = "unrecapturedSection1250Gain", EmitDefaultValue = true)]
        public string UnrecapturedSection1250Gain { get; set; }

        /// <summary>
        /// Section 1202 gain
        /// </summary>
        /// <value>Section 1202 gain</value>
        [DataMember(Name = "section1202Gain", EmitDefaultValue = true)]
        public string Section1202Gain { get; set; }

        /// <summary>
        /// Collectibles (28%) gain
        /// </summary>
        /// <value>Collectibles (28%) gain</value>
        [DataMember(Name = "collectiblesGain", EmitDefaultValue = true)]
        public string CollectiblesGain { get; set; }

        /// <summary>
        /// Section 897 ordinary dividends
        /// </summary>
        /// <value>Section 897 ordinary dividends</value>
        [DataMember(Name = "section897OrdinaryDividends", EmitDefaultValue = true)]
        public string Section897OrdinaryDividends { get; set; }

        /// <summary>
        /// Section 897 capital gain
        /// </summary>
        /// <value>Section 897 capital gain</value>
        [DataMember(Name = "section897CapitalGain", EmitDefaultValue = true)]
        public string Section897CapitalGain { get; set; }

        /// <summary>
        /// Nondividend distributions
        /// </summary>
        /// <value>Nondividend distributions</value>
        [DataMember(Name = "nondividendDistributions", EmitDefaultValue = true)]
        public string NondividendDistributions { get; set; }

        /// <summary>
        /// Federal income tax withheld
        /// </summary>
        /// <value>Federal income tax withheld</value>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = true)]
        public string FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Section 199A dividends
        /// </summary>
        /// <value>Section 199A dividends</value>
        [DataMember(Name = "section199ADividends", EmitDefaultValue = true)]
        public string Section199ADividends { get; set; }

        /// <summary>
        /// Investment expenses
        /// </summary>
        /// <value>Investment expenses</value>
        [DataMember(Name = "investmentExpenses", EmitDefaultValue = true)]
        public string InvestmentExpenses { get; set; }

        /// <summary>
        /// Foreign tax paid
        /// </summary>
        /// <value>Foreign tax paid</value>
        [DataMember(Name = "foreignTaxPaid", EmitDefaultValue = true)]
        public string ForeignTaxPaid { get; set; }

        /// <summary>
        /// Foreign country or U.S. possession
        /// </summary>
        /// <value>Foreign country or U.S. possession</value>
        [DataMember(Name = "foreignCountryOrUSPossession", EmitDefaultValue = true)]
        public string ForeignCountryOrUSPossession { get; set; }

        /// <summary>
        /// Cash liquidation distributions
        /// </summary>
        /// <value>Cash liquidation distributions</value>
        [DataMember(Name = "cashLiquidationDistributions", EmitDefaultValue = true)]
        public string CashLiquidationDistributions { get; set; }

        /// <summary>
        /// Noncash liquidation distributions
        /// </summary>
        /// <value>Noncash liquidation distributions</value>
        [DataMember(Name = "noncashLiquidationDistributions", EmitDefaultValue = true)]
        public string NoncashLiquidationDistributions { get; set; }

        /// <summary>
        /// Exempt-interest dividends
        /// </summary>
        /// <value>Exempt-interest dividends</value>
        [DataMember(Name = "exemptInterestDividends", EmitDefaultValue = true)]
        public string ExemptInterestDividends { get; set; }

        /// <summary>
        /// Specified private activity bond interest dividends
        /// </summary>
        /// <value>Specified private activity bond interest dividends</value>
        [DataMember(Name = "specifiedPrivateActivityBondInterestDividends", EmitDefaultValue = true)]
        public string SpecifiedPrivateActivityBondInterestDividends { get; set; }

        /// <summary>
        /// FATCA filing requirement
        /// </summary>
        /// <value>FATCA filing requirement</value>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool? FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Issuer ID
        /// </summary>
        /// <value>Issuer ID</value>
        [DataMember(Name = "issuerId", EmitDefaultValue = true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Reference ID
        /// </summary>
        /// <value>Reference ID</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Recipient Tax ID Number
        /// </summary>
        /// <value>Recipient Tax ID Number</value>
        [DataMember(Name = "recipientTin", EmitDefaultValue = false)]
        public string RecipientTin { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        /// <value>Recipient name</value>
        [DataMember(Name = "recipientName", EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Recipient second name
        /// </summary>
        /// <value>Recipient second name</value>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <value>Address line 2</value>
        [DataMember(Name = "address2", EmitDefaultValue = true)]
        public string Address2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// US state. Required if CountryCode is \&quot;US\&quot;.
        /// </summary>
        /// <value>US state. Required if CountryCode is \&quot;US\&quot;.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code
        /// </summary>
        /// <value>Zip/postal code</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        /// <value>Recipient email address</value>
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
        /// Foreign province
        /// </summary>
        /// <value>Foreign province</value>
        [DataMember(Name = "nonUsProvince", EmitDefaultValue = true)]
        public string NonUsProvince { get; set; }

        /// <summary>
        /// Country code, as defined at https://www.irs.gov/e-file-providers/country-codes
        /// </summary>
        /// <value>Country code, as defined at https://www.irs.gov/e-file-providers/country-codes</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Boolean indicating that federal e-filing should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that federal e-filing should be scheduled for this form</value>
        [DataMember(Name = "federalEFile", EmitDefaultValue = true)]
        public bool FederalEFile { get; set; }

        /// <summary>
        /// Boolean indicating that postal mailing to the recipient should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that postal mailing to the recipient should be scheduled for this form</value>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Boolean indicating that state e-filing should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that state e-filing should be scheduled for this form</value>
        [DataMember(Name = "stateEFile", EmitDefaultValue = true)]
        public bool StateEFile { get; set; }

        /// <summary>
        /// Boolean indicating that TIN Matching should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that TIN Matching should be scheduled for this form</value>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// Indicates whether the recipient has no TIN
        /// </summary>
        /// <value>Indicates whether the recipient has no TIN</value>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool NoTin { get; set; }

        /// <summary>
        /// Second TIN notice in three years
        /// </summary>
        /// <value>Second TIN notice in three years</value>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool? SecondTinNotice { get; set; }

        /// <summary>
        /// Boolean indicating that address verification should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification should be scheduled for this form</value>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// State and local withholding information
        /// </summary>
        /// <value>State and local withholding information</value>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholdingRequest StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099DivRequest {\n");
            sb.Append("  TotalOrdinaryDividends: ").Append(TotalOrdinaryDividends).Append("\n");
            sb.Append("  QualifiedDividends: ").Append(QualifiedDividends).Append("\n");
            sb.Append("  TotalCapitalGainDistributions: ").Append(TotalCapitalGainDistributions).Append("\n");
            sb.Append("  UnrecapturedSection1250Gain: ").Append(UnrecapturedSection1250Gain).Append("\n");
            sb.Append("  Section1202Gain: ").Append(Section1202Gain).Append("\n");
            sb.Append("  CollectiblesGain: ").Append(CollectiblesGain).Append("\n");
            sb.Append("  Section897OrdinaryDividends: ").Append(Section897OrdinaryDividends).Append("\n");
            sb.Append("  Section897CapitalGain: ").Append(Section897CapitalGain).Append("\n");
            sb.Append("  NondividendDistributions: ").Append(NondividendDistributions).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  Section199ADividends: ").Append(Section199ADividends).Append("\n");
            sb.Append("  InvestmentExpenses: ").Append(InvestmentExpenses).Append("\n");
            sb.Append("  ForeignTaxPaid: ").Append(ForeignTaxPaid).Append("\n");
            sb.Append("  ForeignCountryOrUSPossession: ").Append(ForeignCountryOrUSPossession).Append("\n");
            sb.Append("  CashLiquidationDistributions: ").Append(CashLiquidationDistributions).Append("\n");
            sb.Append("  NoncashLiquidationDistributions: ").Append(NoncashLiquidationDistributions).Append("\n");
            sb.Append("  ExemptInterestDividends: ").Append(ExemptInterestDividends).Append("\n");
            sb.Append("  SpecifiedPrivateActivityBondInterestDividends: ").Append(SpecifiedPrivateActivityBondInterestDividends).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  RecipientTin: ").Append(RecipientTin).Append("\n");
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
            sb.Append("  FederalEFile: ").Append(FederalEFile).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEFile: ").Append(StateEFile).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
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
            // Address (string) minLength
            if (this.Address != null && this.Address.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Address, length must be greater than 1.", new [] { "Address" });
            }

            // City (string) minLength
            if (this.City != null && this.City.Length < 1)
            {
                yield return new ValidationResult("Invalid value for City, length must be greater than 1.", new [] { "City" });
            }

            // CountryCode (string) minLength
            if (this.CountryCode != null && this.CountryCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be greater than 1.", new [] { "CountryCode" });
            }

            yield break;
        }
    }
}
