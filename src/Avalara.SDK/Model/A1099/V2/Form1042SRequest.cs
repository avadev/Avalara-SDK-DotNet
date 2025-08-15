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
    /// Form1042SRequest
    /// </summary>
    [DataContract(Name = "Form1042SRequest")]
    public partial class Form1042SRequest : IValidatableObject
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
            _1095C = 8,

            /// <summary>
            /// Enum _1099INT for value: 1099-INT
            /// </summary>
            [EnumMember(Value = "1099-INT")]
            _1099INT = 9
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
        /// Initializes a new instance of the <see cref="Form1042SRequest" /> class.
        /// </summary>
        /// <param name="uniqueFormId">Unique form identifier.</param>
        /// <param name="recipientDateOfBirth">Recipient&#39;s date of birth.</param>
        /// <param name="recipientGiin">Recipient&#39;s GIIN (Global Intermediary Identification Number).</param>
        /// <param name="recipientForeignTin">Recipient&#39;s foreign TIN.</param>
        /// <param name="lobCode">Limitation on benefits code.</param>
        /// <param name="incomeCode">Income code.</param>
        /// <param name="grossIncome">Gross income.</param>
        /// <param name="withholdingIndicator">Withholding indicator.</param>
        /// <param name="taxCountryCode">Country code.</param>
        /// <param name="exemptionCodeChap3">Exemption code (Chapter 3).</param>
        /// <param name="exemptionCodeChap4">Exemption code (Chapter 4).</param>
        /// <param name="taxRateChap3">Tax rate (Chapter 3).</param>
        /// <param name="withholdingAllowance">Withholding allowance.</param>
        /// <param name="federalTaxWithheld">Federal tax withheld.</param>
        /// <param name="taxNotDepositedIndicator">Tax not deposited indicator.</param>
        /// <param name="academicIndicator">Academic indicator.</param>
        /// <param name="taxWithheldOtherAgents">Tax withheld by other agents.</param>
        /// <param name="amountRepaid">Amount repaid to recipient.</param>
        /// <param name="taxPaidAgent">Tax paid by withholding agent.</param>
        /// <param name="chap3StatusCode">Chapter 3 status code.</param>
        /// <param name="chap4StatusCode">Chapter 4 status code.</param>
        /// <param name="primaryWithholdingAgent">Primary withholding agent information.</param>
        /// <param name="intermediaryOrFlowThrough">Intermediary or flow-through entity information.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        /// <param name="type">type.</param>
        /// <param name="issuerId">Issuer ID.</param>
        /// <param name="referenceId">Reference ID.</param>
        /// <param name="recipientTin">Recipient Tax ID Number.</param>
        /// <param name="recipientName">Recipient name.</param>
        /// <param name="tinType">Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address.</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">US state. Required if CountryCode is \&quot;US\&quot;..</param>
        /// <param name="zip">Zip/postal code.</param>
        /// <param name="email">Recipient email address.</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="officeCode">Office code.</param>
        /// <param name="nonUsProvince">Foreign province.</param>
        /// <param name="countryCode">Country code, as defined at https://www.irs.gov/e-file-providers/country-codes.</param>
        /// <param name="federalEFile">Boolean indicating that federal e-filing should be scheduled for this form.</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEFile">Boolean indicating that state e-filing should be scheduled for this form.</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="noTin">Indicates whether the recipient has no TIN.</param>
        /// <param name="secondTinNotice">Second TIN notice in three years.</param>
        /// <param name="fatcaFilingRequirement">Fatca filing requirement.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        public Form1042SRequest(string uniqueFormId = default(string), DateTime? recipientDateOfBirth = default(DateTime?), string recipientGiin = default(string), string recipientForeignTin = default(string), string lobCode = default(string), string incomeCode = default(string), double grossIncome = default(double), string withholdingIndicator = default(string), string taxCountryCode = default(string), string exemptionCodeChap3 = default(string), string exemptionCodeChap4 = default(string), string taxRateChap3 = default(string), double? withholdingAllowance = default(double?), double? federalTaxWithheld = default(double?), bool? taxNotDepositedIndicator = default(bool?), bool? academicIndicator = default(bool?), double? taxWithheldOtherAgents = default(double?), double? amountRepaid = default(double?), double? taxPaidAgent = default(double?), string chap3StatusCode = default(string), string chap4StatusCode = default(string), PrimaryWithholdingAgentRequest primaryWithholdingAgent = default(PrimaryWithholdingAgentRequest), IntermediaryOrFlowThroughRequest intermediaryOrFlowThrough = default(IntermediaryOrFlowThroughRequest), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest), TypeEnum? type = default(TypeEnum?), string issuerId = default(string), string referenceId = default(string), string recipientTin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool noTin = default(bool), bool? secondTinNotice = default(bool?), bool fatcaFilingRequirement = default(bool), bool addressVerification = default(bool))
        {
            this.UniqueFormId = uniqueFormId;
            this.RecipientDateOfBirth = recipientDateOfBirth;
            this.RecipientGiin = recipientGiin;
            this.RecipientForeignTin = recipientForeignTin;
            this.LobCode = lobCode;
            this.IncomeCode = incomeCode;
            this.GrossIncome = grossIncome;
            this.WithholdingIndicator = withholdingIndicator;
            this.TaxCountryCode = taxCountryCode;
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
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.Type = type;
            this.IssuerId = issuerId;
            this.ReferenceId = referenceId;
            this.RecipientTin = recipientTin;
            this.RecipientName = recipientName;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Email = email;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.NonUsProvince = nonUsProvince;
            this.CountryCode = countryCode;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.NoTin = noTin;
            this.SecondTinNotice = secondTinNotice;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.AddressVerification = addressVerification;
        }

        /// <summary>
        /// Unique form identifier
        /// </summary>
        /// <value>Unique form identifier</value>
        [DataMember(Name = "uniqueFormId", EmitDefaultValue = false)]
        public string UniqueFormId { get; set; }

        /// <summary>
        /// Recipient&#39;s date of birth
        /// </summary>
        /// <value>Recipient&#39;s date of birth</value>
        [DataMember(Name = "recipientDateOfBirth", EmitDefaultValue = true)]
        public DateTime? RecipientDateOfBirth { get; set; }

        /// <summary>
        /// Recipient&#39;s GIIN (Global Intermediary Identification Number)
        /// </summary>
        /// <value>Recipient&#39;s GIIN (Global Intermediary Identification Number)</value>
        [DataMember(Name = "recipientGiin", EmitDefaultValue = true)]
        public string RecipientGiin { get; set; }

        /// <summary>
        /// Recipient&#39;s foreign TIN
        /// </summary>
        /// <value>Recipient&#39;s foreign TIN</value>
        [DataMember(Name = "recipientForeignTin", EmitDefaultValue = true)]
        public string RecipientForeignTin { get; set; }

        /// <summary>
        /// Limitation on benefits code
        /// </summary>
        /// <value>Limitation on benefits code</value>
        [DataMember(Name = "lobCode", EmitDefaultValue = true)]
        public string LobCode { get; set; }

        /// <summary>
        /// Income code
        /// </summary>
        /// <value>Income code</value>
        [DataMember(Name = "incomeCode", EmitDefaultValue = true)]
        public string IncomeCode { get; set; }

        /// <summary>
        /// Gross income
        /// </summary>
        /// <value>Gross income</value>
        [DataMember(Name = "grossIncome", EmitDefaultValue = false)]
        public double GrossIncome { get; set; }

        /// <summary>
        /// Withholding indicator
        /// </summary>
        /// <value>Withholding indicator</value>
        [DataMember(Name = "withholdingIndicator", EmitDefaultValue = true)]
        public string WithholdingIndicator { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name = "taxCountryCode", EmitDefaultValue = true)]
        public string TaxCountryCode { get; set; }

        /// <summary>
        /// Exemption code (Chapter 3)
        /// </summary>
        /// <value>Exemption code (Chapter 3)</value>
        [DataMember(Name = "exemptionCodeChap3", EmitDefaultValue = true)]
        public string ExemptionCodeChap3 { get; set; }

        /// <summary>
        /// Exemption code (Chapter 4)
        /// </summary>
        /// <value>Exemption code (Chapter 4)</value>
        [DataMember(Name = "exemptionCodeChap4", EmitDefaultValue = true)]
        public string ExemptionCodeChap4 { get; set; }

        /// <summary>
        /// Tax rate (Chapter 3)
        /// </summary>
        /// <value>Tax rate (Chapter 3)</value>
        [DataMember(Name = "taxRateChap3", EmitDefaultValue = true)]
        public string TaxRateChap3 { get; set; }

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
        /// Chapter 3 status code
        /// </summary>
        /// <value>Chapter 3 status code</value>
        [DataMember(Name = "chap3StatusCode", EmitDefaultValue = true)]
        public string Chap3StatusCode { get; set; }

        /// <summary>
        /// Chapter 4 status code
        /// </summary>
        /// <value>Chapter 4 status code</value>
        [DataMember(Name = "chap4StatusCode", EmitDefaultValue = true)]
        public string Chap4StatusCode { get; set; }

        /// <summary>
        /// Primary withholding agent information
        /// </summary>
        /// <value>Primary withholding agent information</value>
        [DataMember(Name = "primaryWithholdingAgent", EmitDefaultValue = false)]
        public PrimaryWithholdingAgentRequest PrimaryWithholdingAgent { get; set; }

        /// <summary>
        /// Intermediary or flow-through entity information
        /// </summary>
        /// <value>Intermediary or flow-through entity information</value>
        [DataMember(Name = "intermediaryOrFlowThrough", EmitDefaultValue = false)]
        public IntermediaryOrFlowThroughRequest IntermediaryOrFlowThrough { get; set; }

        /// <summary>
        /// State and local withholding information
        /// </summary>
        /// <value>State and local withholding information</value>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = false)]
        public StateAndLocalWithholdingRequest StateAndLocalWithholding { get; set; }

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
        [DataMember(Name = "recipientTin", EmitDefaultValue = true)]
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
        [DataMember(Name = "address", EmitDefaultValue = true)]
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
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// US state. Required if CountryCode is \&quot;US\&quot;.
        /// </summary>
        /// <value>US state. Required if CountryCode is \&quot;US\&quot;.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code
        /// </summary>
        /// <value>Zip/postal code</value>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
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
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
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
        /// Fatca filing requirement
        /// </summary>
        /// <value>Fatca filing requirement</value>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Boolean indicating that address verification should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification should be scheduled for this form</value>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1042SRequest {\n");
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
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
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
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
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
