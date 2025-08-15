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
    /// Form1099RListItem
    /// </summary>
    [DataContract(Name = "Form1099RListItem")]
    public partial class Form1099RListItem : IValidatableObject
    {
        /// <summary>
        /// Distribution code
        /// </summary>
        /// <value>Distribution code</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistributionCodeEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 3,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 4,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 5,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 6,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 7,

            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 8,

            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 9,

            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 10,

            /// <summary>
            /// Enum B for value: B
            /// </summary>
            [EnumMember(Value = "B")]
            B = 11,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 12,

            /// <summary>
            /// Enum D for value: D
            /// </summary>
            [EnumMember(Value = "D")]
            D = 13,

            /// <summary>
            /// Enum E for value: E
            /// </summary>
            [EnumMember(Value = "E")]
            E = 14,

            /// <summary>
            /// Enum F for value: F
            /// </summary>
            [EnumMember(Value = "F")]
            F = 15,

            /// <summary>
            /// Enum G for value: G
            /// </summary>
            [EnumMember(Value = "G")]
            G = 16,

            /// <summary>
            /// Enum H for value: H
            /// </summary>
            [EnumMember(Value = "H")]
            H = 17,

            /// <summary>
            /// Enum J for value: J
            /// </summary>
            [EnumMember(Value = "J")]
            J = 18,

            /// <summary>
            /// Enum K for value: K
            /// </summary>
            [EnumMember(Value = "K")]
            K = 19,

            /// <summary>
            /// Enum L for value: L
            /// </summary>
            [EnumMember(Value = "L")]
            L = 20,

            /// <summary>
            /// Enum M for value: M
            /// </summary>
            [EnumMember(Value = "M")]
            M = 21,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 22,

            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 23,

            /// <summary>
            /// Enum Q for value: Q
            /// </summary>
            [EnumMember(Value = "Q")]
            Q = 24,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 25,

            /// <summary>
            /// Enum S for value: S
            /// </summary>
            [EnumMember(Value = "S")]
            S = 26,

            /// <summary>
            /// Enum T for value: T
            /// </summary>
            [EnumMember(Value = "T")]
            T = 27,

            /// <summary>
            /// Enum U for value: U
            /// </summary>
            [EnumMember(Value = "U")]
            U = 28,

            /// <summary>
            /// Enum W for value: W
            /// </summary>
            [EnumMember(Value = "W")]
            W = 29
        }


        /// <summary>
        /// Distribution code
        /// </summary>
        /// <value>Distribution code</value>
        /// <example>1</example>
        [DataMember(Name = "distributionCode", EmitDefaultValue = false)]
        public DistributionCodeEnum? DistributionCode { get; set; }
        /// <summary>
        /// Second distribution code
        /// </summary>
        /// <value>Second distribution code</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecondDistributionCodeEnum
        {
            /// <summary>
            /// Enum EarlyDistributionNoException for value: EarlyDistributionNoException
            /// </summary>
            [EnumMember(Value = "EarlyDistributionNoException")]
            EarlyDistributionNoException = 1,

            /// <summary>
            /// Enum EarlyDistributionWithException for value: EarlyDistributionWithException
            /// </summary>
            [EnumMember(Value = "EarlyDistributionWithException")]
            EarlyDistributionWithException = 2,

            /// <summary>
            /// Enum Disability for value: Disability
            /// </summary>
            [EnumMember(Value = "Disability")]
            Disability = 3,

            /// <summary>
            /// Enum Death for value: Death
            /// </summary>
            [EnumMember(Value = "Death")]
            Death = 4,

            /// <summary>
            /// Enum ProhibitedTransaction for value: ProhibitedTransaction
            /// </summary>
            [EnumMember(Value = "ProhibitedTransaction")]
            ProhibitedTransaction = 5,

            /// <summary>
            /// Enum Section1035Exchange for value: Section1035Exchange
            /// </summary>
            [EnumMember(Value = "Section1035Exchange")]
            Section1035Exchange = 6,

            /// <summary>
            /// Enum NormalDistribution for value: NormalDistribution
            /// </summary>
            [EnumMember(Value = "NormalDistribution")]
            NormalDistribution = 7,

            /// <summary>
            /// Enum ExcessContributionsCurrentYear for value: ExcessContributionsCurrentYear
            /// </summary>
            [EnumMember(Value = "ExcessContributionsCurrentYear")]
            ExcessContributionsCurrentYear = 8,

            /// <summary>
            /// Enum CurrentLifeInsuranceProtectionCost for value: CurrentLifeInsuranceProtectionCost
            /// </summary>
            [EnumMember(Value = "CurrentLifeInsuranceProtectionCost")]
            CurrentLifeInsuranceProtectionCost = 9,

            /// <summary>
            /// Enum TenYearTaxOption for value: TenYearTaxOption
            /// </summary>
            [EnumMember(Value = "TenYearTaxOption")]
            TenYearTaxOption = 10,

            /// <summary>
            /// Enum DesignatedRothDistribution for value: DesignatedRothDistribution
            /// </summary>
            [EnumMember(Value = "DesignatedRothDistribution")]
            DesignatedRothDistribution = 11,

            /// <summary>
            /// Enum ReportableDeathBenefits for value: ReportableDeathBenefits
            /// </summary>
            [EnumMember(Value = "ReportableDeathBenefits")]
            ReportableDeathBenefits = 12,

            /// <summary>
            /// Enum NonqualifiedAnnuityPayments for value: NonqualifiedAnnuityPayments
            /// </summary>
            [EnumMember(Value = "NonqualifiedAnnuityPayments")]
            NonqualifiedAnnuityPayments = 13,

            /// <summary>
            /// Enum EPCRSDistribution for value: EPCRSDistribution
            /// </summary>
            [EnumMember(Value = "EPCRSDistribution")]
            EPCRSDistribution = 14,

            /// <summary>
            /// Enum CharitableGiftAnnuity for value: CharitableGiftAnnuity
            /// </summary>
            [EnumMember(Value = "CharitableGiftAnnuity")]
            CharitableGiftAnnuity = 15,

            /// <summary>
            /// Enum DirectRollover for value: DirectRollover
            /// </summary>
            [EnumMember(Value = "DirectRollover")]
            DirectRollover = 16,

            /// <summary>
            /// Enum RothAccountToIRADirectRollover for value: RothAccountToIRADirectRollover
            /// </summary>
            [EnumMember(Value = "RothAccountToIRADirectRollover")]
            RothAccountToIRADirectRollover = 17,

            /// <summary>
            /// Enum EarlyRothIRADistribution for value: EarlyRothIRADistribution
            /// </summary>
            [EnumMember(Value = "EarlyRothIRADistribution")]
            EarlyRothIRADistribution = 18,

            /// <summary>
            /// Enum IRAAssetsNoFMV for value: IRAAssetsNoFMV
            /// </summary>
            [EnumMember(Value = "IRAAssetsNoFMV")]
            IRAAssetsNoFMV = 19,

            /// <summary>
            /// Enum LoansDeemedDistributions for value: LoansDeemedDistributions
            /// </summary>
            [EnumMember(Value = "LoansDeemedDistributions")]
            LoansDeemedDistributions = 20,

            /// <summary>
            /// Enum QualifiedPlanLoanOffsets for value: QualifiedPlanLoanOffsets
            /// </summary>
            [EnumMember(Value = "QualifiedPlanLoanOffsets")]
            QualifiedPlanLoanOffsets = 21,

            /// <summary>
            /// Enum RecharacterizedIRANextYear for value: RecharacterizedIRANextYear
            /// </summary>
            [EnumMember(Value = "RecharacterizedIRANextYear")]
            RecharacterizedIRANextYear = 22,

            /// <summary>
            /// Enum ExcessContributionsPreviousYear for value: ExcessContributionsPreviousYear
            /// </summary>
            [EnumMember(Value = "ExcessContributionsPreviousYear")]
            ExcessContributionsPreviousYear = 23,

            /// <summary>
            /// Enum QualifiedRothIRADistribution for value: QualifiedRothIRADistribution
            /// </summary>
            [EnumMember(Value = "QualifiedRothIRADistribution")]
            QualifiedRothIRADistribution = 24,

            /// <summary>
            /// Enum RecharacterizedIRAPreviousYear for value: RecharacterizedIRAPreviousYear
            /// </summary>
            [EnumMember(Value = "RecharacterizedIRAPreviousYear")]
            RecharacterizedIRAPreviousYear = 25,

            /// <summary>
            /// Enum EarlySimpleIRADistribution for value: EarlySimpleIRADistribution
            /// </summary>
            [EnumMember(Value = "EarlySimpleIRADistribution")]
            EarlySimpleIRADistribution = 26,

            /// <summary>
            /// Enum RothIRADistributionException for value: RothIRADistributionException
            /// </summary>
            [EnumMember(Value = "RothIRADistributionException")]
            RothIRADistributionException = 27,

            /// <summary>
            /// Enum ESOPDistribution for value: ESOPDistribution
            /// </summary>
            [EnumMember(Value = "ESOPDistribution")]
            ESOPDistribution = 28,

            /// <summary>
            /// Enum LongTermCareInsurance for value: LongTermCareInsurance
            /// </summary>
            [EnumMember(Value = "LongTermCareInsurance")]
            LongTermCareInsurance = 29
        }


        /// <summary>
        /// Second distribution code
        /// </summary>
        /// <value>Second distribution code</value>
        [DataMember(Name = "secondDistributionCode", EmitDefaultValue = true)]
        public SecondDistributionCodeEnum? SecondDistributionCode { get; set; }
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
        /// Initializes a new instance of the <see cref="Form1099RListItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099RListItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099RListItem" /> class.
        /// </summary>
        /// <param name="grossDistribution">Gross distribution.</param>
        /// <param name="taxableAmount">Taxable amount.</param>
        /// <param name="taxableAmountNotDetermined">Taxable amount not determined.</param>
        /// <param name="totalDistributionDetermined">Total distribution.</param>
        /// <param name="capitalGain">Capital gain (included in Box 2a).</param>
        /// <param name="federalIncomeTaxWithheld">Federal income tax withheld.</param>
        /// <param name="employeeContributionsOrDesignatedRothOrInsurancePremiums">Employee contributions/Designated Roth contributions or insurance premiums.</param>
        /// <param name="netUnrealizedAppreciationInEmployerSecurities">Net unrealized appreciation in employer&#39;s securities.</param>
        /// <param name="distributionCode">Distribution code.</param>
        /// <param name="secondDistributionCode">Second distribution code.</param>
        /// <param name="iraSepSimple">IRA/SEP/SIMPLE.</param>
        /// <param name="traditionalIraSepSimpleOrRothConversionAmount">Traditional IRA/SEP/SIMPLE or Roth conversion amount.</param>
        /// <param name="otherAmount">Other amount.</param>
        /// <param name="otherPercentage">Other percentage.</param>
        /// <param name="totalDistributionPercentage">Total distribution percentage.</param>
        /// <param name="totalEmployeeContributions">Total employee contributions.</param>
        /// <param name="amountAllocableToIrrWithin5Years">Amount allocable to IRR within 5 years.</param>
        /// <param name="firstYearOfDesignatedRothContribution">First year of designated Roth contribution.</param>
        /// <param name="fatcaFilingRequirement">FATCA filing requirement.</param>
        /// <param name="dateOfPayment">Date of payment.</param>
        /// <param name="issuerReferenceId">Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required..</param>
        /// <param name="issuerTin">Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required..</param>
        /// <param name="taxYear">Tax year (required).</param>
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
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        public Form1099RListItem(double grossDistribution = default(double), double taxableAmount = default(double), bool taxableAmountNotDetermined = default(bool), bool totalDistributionDetermined = default(bool), double capitalGain = default(double), double federalIncomeTaxWithheld = default(double), double employeeContributionsOrDesignatedRothOrInsurancePremiums = default(double), double netUnrealizedAppreciationInEmployerSecurities = default(double), DistributionCodeEnum? distributionCode = default(DistributionCodeEnum?), SecondDistributionCodeEnum? secondDistributionCode = default(SecondDistributionCodeEnum?), bool iraSepSimple = default(bool), double traditionalIraSepSimpleOrRothConversionAmount = default(double), double otherAmount = default(double), string otherPercentage = default(string), string totalDistributionPercentage = default(string), double totalEmployeeContributions = default(double), double amountAllocableToIrrWithin5Years = default(double), int firstYearOfDesignatedRothContribution = default(int), bool fatcaFilingRequirement = default(bool), DateTime dateOfPayment = default(DateTime), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), string issuerId = default(string), string referenceId = default(string), string recipientTin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool noTin = default(bool), bool? secondTinNotice = default(bool?), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
            this.TaxYear = taxYear;
            this.GrossDistribution = grossDistribution;
            this.TaxableAmount = taxableAmount;
            this.TaxableAmountNotDetermined = taxableAmountNotDetermined;
            this.TotalDistributionDetermined = totalDistributionDetermined;
            this.CapitalGain = capitalGain;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.EmployeeContributionsOrDesignatedRothOrInsurancePremiums = employeeContributionsOrDesignatedRothOrInsurancePremiums;
            this.NetUnrealizedAppreciationInEmployerSecurities = netUnrealizedAppreciationInEmployerSecurities;
            this.DistributionCode = distributionCode;
            this.SecondDistributionCode = secondDistributionCode;
            this.IraSepSimple = iraSepSimple;
            this.TraditionalIraSepSimpleOrRothConversionAmount = traditionalIraSepSimpleOrRothConversionAmount;
            this.OtherAmount = otherAmount;
            this.OtherPercentage = otherPercentage;
            this.TotalDistributionPercentage = totalDistributionPercentage;
            this.TotalEmployeeContributions = totalEmployeeContributions;
            this.AmountAllocableToIrrWithin5Years = amountAllocableToIrrWithin5Years;
            this.FirstYearOfDesignatedRothContribution = firstYearOfDesignatedRothContribution;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.DateOfPayment = dateOfPayment;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
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
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Gross distribution
        /// </summary>
        /// <value>Gross distribution</value>
        [DataMember(Name = "grossDistribution", EmitDefaultValue = false)]
        public double GrossDistribution { get; set; }

        /// <summary>
        /// Taxable amount
        /// </summary>
        /// <value>Taxable amount</value>
        [DataMember(Name = "taxableAmount", EmitDefaultValue = false)]
        public double TaxableAmount { get; set; }

        /// <summary>
        /// Taxable amount not determined
        /// </summary>
        /// <value>Taxable amount not determined</value>
        [DataMember(Name = "taxableAmountNotDetermined", EmitDefaultValue = true)]
        public bool TaxableAmountNotDetermined { get; set; }

        /// <summary>
        /// Total distribution
        /// </summary>
        /// <value>Total distribution</value>
        [DataMember(Name = "totalDistributionDetermined", EmitDefaultValue = true)]
        public bool TotalDistributionDetermined { get; set; }

        /// <summary>
        /// Capital gain (included in Box 2a)
        /// </summary>
        /// <value>Capital gain (included in Box 2a)</value>
        [DataMember(Name = "capitalGain", EmitDefaultValue = false)]
        public double CapitalGain { get; set; }

        /// <summary>
        /// Federal income tax withheld
        /// </summary>
        /// <value>Federal income tax withheld</value>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = false)]
        public double FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Employee contributions/Designated Roth contributions or insurance premiums
        /// </summary>
        /// <value>Employee contributions/Designated Roth contributions or insurance premiums</value>
        [DataMember(Name = "employeeContributionsOrDesignatedRothOrInsurancePremiums", EmitDefaultValue = false)]
        public double EmployeeContributionsOrDesignatedRothOrInsurancePremiums { get; set; }

        /// <summary>
        /// Net unrealized appreciation in employer&#39;s securities
        /// </summary>
        /// <value>Net unrealized appreciation in employer&#39;s securities</value>
        [DataMember(Name = "netUnrealizedAppreciationInEmployerSecurities", EmitDefaultValue = false)]
        public double NetUnrealizedAppreciationInEmployerSecurities { get; set; }

        /// <summary>
        /// IRA/SEP/SIMPLE
        /// </summary>
        /// <value>IRA/SEP/SIMPLE</value>
        [DataMember(Name = "iraSepSimple", EmitDefaultValue = true)]
        public bool IraSepSimple { get; set; }

        /// <summary>
        /// Traditional IRA/SEP/SIMPLE or Roth conversion amount
        /// </summary>
        /// <value>Traditional IRA/SEP/SIMPLE or Roth conversion amount</value>
        [DataMember(Name = "traditionalIraSepSimpleOrRothConversionAmount", EmitDefaultValue = false)]
        public double TraditionalIraSepSimpleOrRothConversionAmount { get; set; }

        /// <summary>
        /// Other amount
        /// </summary>
        /// <value>Other amount</value>
        [DataMember(Name = "otherAmount", EmitDefaultValue = false)]
        public double OtherAmount { get; set; }

        /// <summary>
        /// Other percentage
        /// </summary>
        /// <value>Other percentage</value>
        [DataMember(Name = "otherPercentage", EmitDefaultValue = false)]
        public string OtherPercentage { get; set; }

        /// <summary>
        /// Total distribution percentage
        /// </summary>
        /// <value>Total distribution percentage</value>
        [DataMember(Name = "totalDistributionPercentage", EmitDefaultValue = false)]
        public string TotalDistributionPercentage { get; set; }

        /// <summary>
        /// Total employee contributions
        /// </summary>
        /// <value>Total employee contributions</value>
        [DataMember(Name = "totalEmployeeContributions", EmitDefaultValue = false)]
        public double TotalEmployeeContributions { get; set; }

        /// <summary>
        /// Amount allocable to IRR within 5 years
        /// </summary>
        /// <value>Amount allocable to IRR within 5 years</value>
        [DataMember(Name = "amountAllocableToIrrWithin5Years", EmitDefaultValue = false)]
        public double AmountAllocableToIrrWithin5Years { get; set; }

        /// <summary>
        /// First year of designated Roth contribution
        /// </summary>
        /// <value>First year of designated Roth contribution</value>
        [DataMember(Name = "firstYearOfDesignatedRothContribution", EmitDefaultValue = false)]
        public int FirstYearOfDesignatedRothContribution { get; set; }

        /// <summary>
        /// FATCA filing requirement
        /// </summary>
        /// <value>FATCA filing requirement</value>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Date of payment
        /// </summary>
        /// <value>Date of payment</value>
        [DataMember(Name = "dateOfPayment", EmitDefaultValue = false)]
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.
        /// </summary>
        /// <value>Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.</value>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.
        /// </summary>
        /// <value>Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.</value>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax year
        /// </summary>
        /// <value>Tax year</value>
        [DataMember(Name = "taxYear", IsRequired = true, EmitDefaultValue = true)]
        public int TaxYear { get; set; }

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
            sb.Append("class Form1099RListItem {\n");
            sb.Append("  GrossDistribution: ").Append(GrossDistribution).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxableAmountNotDetermined: ").Append(TaxableAmountNotDetermined).Append("\n");
            sb.Append("  TotalDistributionDetermined: ").Append(TotalDistributionDetermined).Append("\n");
            sb.Append("  CapitalGain: ").Append(CapitalGain).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  EmployeeContributionsOrDesignatedRothOrInsurancePremiums: ").Append(EmployeeContributionsOrDesignatedRothOrInsurancePremiums).Append("\n");
            sb.Append("  NetUnrealizedAppreciationInEmployerSecurities: ").Append(NetUnrealizedAppreciationInEmployerSecurities).Append("\n");
            sb.Append("  DistributionCode: ").Append(DistributionCode).Append("\n");
            sb.Append("  SecondDistributionCode: ").Append(SecondDistributionCode).Append("\n");
            sb.Append("  IraSepSimple: ").Append(IraSepSimple).Append("\n");
            sb.Append("  TraditionalIraSepSimpleOrRothConversionAmount: ").Append(TraditionalIraSepSimpleOrRothConversionAmount).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  OtherPercentage: ").Append(OtherPercentage).Append("\n");
            sb.Append("  TotalDistributionPercentage: ").Append(TotalDistributionPercentage).Append("\n");
            sb.Append("  TotalEmployeeContributions: ").Append(TotalEmployeeContributions).Append("\n");
            sb.Append("  AmountAllocableToIrrWithin5Years: ").Append(AmountAllocableToIrrWithin5Years).Append("\n");
            sb.Append("  FirstYearOfDesignatedRothContribution: ").Append(FirstYearOfDesignatedRothContribution).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  DateOfPayment: ").Append(DateOfPayment).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
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
            yield break;
        }
    }
}
