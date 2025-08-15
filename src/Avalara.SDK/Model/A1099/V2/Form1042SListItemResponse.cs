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
    /// Form1042SListItemResponse
    /// </summary>
    [DataContract(Name = "Form1042SListItemResponse")]
    public partial class Form1042SListItemResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1042SListItemResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1042SListItemResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1042SListItemResponse" /> class.
        /// </summary>
        /// <param name="uniqueFormId">Unique form identifier.</param>
        /// <param name="noTin">No TIN indicator.</param>
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
        /// <param name="type">Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC (required).</param>
        /// <param name="issuerId">Issuer ID (required).</param>
        /// <param name="issuerReferenceId">Issuer Reference ID.</param>
        /// <param name="issuerTin">Issuer TIN.</param>
        /// <param name="taxYear">Tax year.</param>
        /// <param name="federalEfile">Boolean indicating that federal e-filing has been scheduled for this form (required).</param>
        /// <param name="stateEfile">Boolean indicating that state e-filing has been scheduled for this form (required).</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient has been scheduled for this form (required).</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching has been scheduled for this form (required).</param>
        /// <param name="addressVerification">Boolean indicating that address verification has been scheduled for this form (required).</param>
        /// <param name="referenceId">Reference ID.</param>
        /// <param name="email">Recipient email address.</param>
        /// <param name="tinType">Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN.</param>
        /// <param name="tin">Recipient Tax ID Number.</param>
        /// <param name="secondTinNotice">Second Tin Notice.</param>
        /// <param name="recipientName">Recipient name.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address.</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">US state.</param>
        /// <param name="zip">Zip/postal code.</param>
        /// <param name="nonUsProvince">Foreign province.</param>
        /// <param name="countryCode">Country code, as defined at https://www.irs.gov/e-file-providers/country-codes.</param>
        /// <param name="accountNumber">Account Number.</param>
        /// <param name="officeCode">Office Code.</param>
        /// <param name="fatcaFilingRequirement">FATCA filing requirement.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1042SListItemResponse(string uniqueFormId = default(string), bool? noTin = default(bool?), DateTime? recipientDateOfBirth = default(DateTime?), string recipientGiin = default(string), string recipientForeignTin = default(string), string lobCode = default(string), string incomeCode = default(string), double grossIncome = default(double), string withholdingIndicator = default(string), string taxCountryCode = default(string), string exemptionCodeChap3 = default(string), string exemptionCodeChap4 = default(string), string taxRateChap3 = default(string), double? withholdingAllowance = default(double?), double? federalTaxWithheld = default(double?), bool? taxNotDepositedIndicator = default(bool?), bool? academicIndicator = default(bool?), double? taxWithheldOtherAgents = default(double?), double? amountRepaid = default(double?), double? taxPaidAgent = default(double?), string chap3StatusCode = default(string), string chap4StatusCode = default(string), PrimaryWithholdingAgentResponse primaryWithholdingAgent = default(PrimaryWithholdingAgentResponse), IntermediaryOrFlowThroughResponse intermediaryOrFlowThrough = default(IntermediaryOrFlowThroughResponse), string type = default(string), int issuerId = default(int), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), bool stateEfile = default(bool), bool postalMail = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), string referenceId = default(string), string email = default(string), string tinType = default(string), string tin = default(string), bool? secondTinNotice = default(bool?), string recipientName = default(string), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string nonUsProvince = default(string), string countryCode = default(string), string accountNumber = default(string), string officeCode = default(string), bool? fatcaFilingRequirement = default(bool?), StateAndLocalWithholdingResponse stateAndLocalWithholding = default(StateAndLocalWithholdingResponse))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Form1042SListItemResponse and cannot be null");
            }
            this.Type = type;
            this.IssuerId = issuerId;
            this.FederalEfile = federalEfile;
            this.StateEfile = stateEfile;
            this.PostalMail = postalMail;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.UniqueFormId = uniqueFormId;
            this.NoTin = noTin;
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
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Email = email;
            this.TinType = tinType;
            this.Tin = tin;
            this.SecondTinNotice = secondTinNotice;
            this.RecipientName = recipientName;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.NonUsProvince = nonUsProvince;
            this.CountryCode = countryCode;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Unique form identifier
        /// </summary>
        /// <value>Unique form identifier</value>
        /// <example>1234567890</example>
        [DataMember(Name = "uniqueFormId", EmitDefaultValue = false)]
        public string UniqueFormId { get; set; }

        /// <summary>
        /// No TIN indicator
        /// </summary>
        /// <value>No TIN indicator</value>
        /// <example>false</example>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool? NoTin { get; set; }

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
        /// <example>GH48-827573</example>
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
        [DataMember(Name = "incomeCode", EmitDefaultValue = false)]
        public string IncomeCode { get; set; }

        /// <summary>
        /// Gross income
        /// </summary>
        /// <value>Gross income</value>
        /// <example>0</example>
        [DataMember(Name = "grossIncome", EmitDefaultValue = false)]
        public double GrossIncome { get; set; }

        /// <summary>
        /// Withholding indicator
        /// </summary>
        /// <value>Withholding indicator</value>
        [DataMember(Name = "withholdingIndicator", EmitDefaultValue = false)]
        public string WithholdingIndicator { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name = "taxCountryCode", EmitDefaultValue = false)]
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
        public PrimaryWithholdingAgentResponse PrimaryWithholdingAgent { get; set; }

        /// <summary>
        /// Intermediary or flow-through entity information
        /// </summary>
        /// <value>Intermediary or flow-through entity information</value>
        [DataMember(Name = "intermediaryOrFlowThrough", EmitDefaultValue = false)]
        public IntermediaryOrFlowThroughResponse IntermediaryOrFlowThrough { get; set; }

        /// <summary>
        /// ID of the form
        /// </summary>
        /// <value>ID of the form</value>
        /// <example>123456789</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
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
        /// Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC
        /// </summary>
        /// <value>Type of the form. Will be one of:  * 940  * 941  * 943  * 944  * 945  * 1042  * 1042-S  * 1095-B  * 1095-C  * 1097-BTC  * 1098  * 1098-C  * 1098-E  * 1098-Q  * 1098-T  * 3921  * 3922  * 5498  * 5498-ESA  * 5498-SA  * 1099-MISC  * 1099-A  * 1099-B  * 1099-C  * 1099-CAP  * 1099-DIV  * 1099-G  * 1099-INT  * 1099-K  * 1099-LS  * 1099-LTC  * 1099-NEC  * 1099-OID  * 1099-PATR  * 1099-Q  * 1099-R  * 1099-S  * 1099-SA  * T4A  * W-2  * W-2G  * 1099-HC</value>
        /// <example>1099-NEC</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Issuer ID
        /// </summary>
        /// <value>Issuer ID</value>
        /// <example>987654321</example>
        [DataMember(Name = "issuerId", IsRequired = true, EmitDefaultValue = true)]
        public int IssuerId { get; set; }

        /// <summary>
        /// Issuer Reference ID
        /// </summary>
        /// <value>Issuer Reference ID</value>
        /// <example>R-3898734</example>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN
        /// </summary>
        /// <value>Issuer TIN</value>
        /// <example>59-387274</example>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax year
        /// </summary>
        /// <value>Tax year</value>
        /// <example>2024</example>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Boolean indicating that federal e-filing has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that federal e-filing has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "federalEfile", IsRequired = true, EmitDefaultValue = true)]
        public bool FederalEfile { get; set; }

        /// <summary>
        /// Federal e-file status
        /// </summary>
        /// <value>Federal e-file status</value>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = false)]
        public StatusDetail FederalEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as FederalEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFederalEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that state e-filing has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that state e-filing has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "stateEfile", IsRequired = true, EmitDefaultValue = true)]
        public bool StateEfile { get; set; }

        /// <summary>
        /// State e-file status
        /// </summary>
        /// <value>State e-file status</value>
        [DataMember(Name = "stateEfileStatus", EmitDefaultValue = true)]
        public List<StateEfileStatusDetailResponse> StateEfileStatus { get; private set; }

        /// <summary>
        /// Returns false as StateEfileStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStateEfileStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that postal mailing to the recipient has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that postal mailing to the recipient has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "postalMail", IsRequired = true, EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Postal mail to recipient status
        /// </summary>
        /// <value>Postal mail to recipient status</value>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public StatusDetail PostalMailStatus { get; private set; }

        /// <summary>
        /// Returns false as PostalMailStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostalMailStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that TIN Matching has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that TIN Matching has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "tinMatch", IsRequired = true, EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// TIN Match status
        /// </summary>
        /// <value>TIN Match status</value>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public StatusDetail TinMatchStatus { get; private set; }

        /// <summary>
        /// Returns false as TinMatchStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTinMatchStatus()
        {
            return false;
        }
        /// <summary>
        /// Boolean indicating that address verification has been scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification has been scheduled for this form</value>
        /// <example>false</example>
        [DataMember(Name = "addressVerification", IsRequired = true, EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Address verification status
        /// </summary>
        /// <value>Address verification status</value>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public StatusDetail AddressVerificationStatus { get; private set; }

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
        public StatusDetail EDeliveryStatus { get; private set; }

        /// <summary>
        /// Returns false as EDeliveryStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEDeliveryStatus()
        {
            return false;
        }
        /// <summary>
        /// Reference ID
        /// </summary>
        /// <value>Reference ID</value>
        /// <example>1891810-9819891</example>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        /// <value>Recipient email address</value>
        /// <example>roadrunner@acmecorp.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN
        /// </summary>
        /// <value>Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN</value>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// Recipient Tax ID Number
        /// </summary>
        /// <value>Recipient Tax ID Number</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Second Tin Notice
        /// </summary>
        /// <value>Second Tin Notice</value>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool? SecondTinNotice { get; set; }

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
        /// <example>1234 Meep Meep Blvd</example>
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
        /// <example>Tucson</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// US state
        /// </summary>
        /// <value>US state</value>
        /// <example>AZ</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code
        /// </summary>
        /// <value>Zip/postal code</value>
        /// <example>35004</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

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
        /// <example>US</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        /// <value>Account Number</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Office Code
        /// </summary>
        /// <value>Office Code</value>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// FATCA filing requirement
        /// </summary>
        /// <value>FATCA filing requirement</value>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool? FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Validation errors
        /// </summary>
        /// <value>Validation errors</value>
        [DataMember(Name = "validationErrors", EmitDefaultValue = true)]
        public List<ValidationErrorResponse> ValidationErrors { get; private set; }

        /// <summary>
        /// Returns false as ValidationErrors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationErrors()
        {
            return false;
        }
        /// <summary>
        /// Creation time
        /// </summary>
        /// <value>Creation time</value>
        /// <example>2025-08-15T15:39:30.279309800Z</example>
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
        /// Update time
        /// </summary>
        /// <value>Update time</value>
        /// <example>2025-08-15T15:39:30.279310500Z</example>
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
        /// Gets or Sets StateAndLocalWithholding
        /// </summary>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholdingResponse StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1042SListItemResponse {\n");
            sb.Append("  UniqueFormId: ").Append(UniqueFormId).Append("\n");
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
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
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  FederalEfile: ").Append(FederalEfile).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  StateEfile: ").Append(StateEfile).Append("\n");
            sb.Append("  StateEfileStatus: ").Append(StateEfileStatus).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  EDeliveryStatus: ").Append(EDeliveryStatus).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  NonUsProvince: ").Append(NonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }
}
