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
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
        /// Defines DistributionCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistributionCodeEnum
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
        /// Gets or Sets DistributionCode
        /// </summary>
        /// <example>EarlyDistributionNoException</example>
        [DataMember(Name = "distributionCode", EmitDefaultValue = false)]
        public DistributionCodeEnum? DistributionCode { get; set; }
        /// <summary>
        /// Defines SecondDistributionCode
        /// </summary>
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
        /// Gets or Sets SecondDistributionCode
        /// </summary>
        [DataMember(Name = "secondDistributionCode", EmitDefaultValue = true)]
        public SecondDistributionCodeEnum? SecondDistributionCode { get; set; }
        /// <summary>
        /// Defines TinType
        /// </summary>
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
        /// Gets or Sets TinType
        /// </summary>
        /// <example>EIN</example>
        [DataMember(Name = "tinType", EmitDefaultValue = false)]
        public TinTypeEnum? TinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099RListItem" /> class.
        /// </summary>
        /// <param name="grossDistribution">grossDistribution.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxableAmountNotDetermined">taxableAmountNotDetermined.</param>
        /// <param name="totalDistributionDetermined">totalDistributionDetermined.</param>
        /// <param name="capitalGain">capitalGain.</param>
        /// <param name="federalIncomeTaxWithheld">federalIncomeTaxWithheld.</param>
        /// <param name="employeeContributionsOrDesignatedRothOrInsurancePremiums">employeeContributionsOrDesignatedRothOrInsurancePremiums.</param>
        /// <param name="netUnrealizedAppreciationInEmployerSecurities">netUnrealizedAppreciationInEmployerSecurities.</param>
        /// <param name="distributionCode">distributionCode.</param>
        /// <param name="secondDistributionCode">secondDistributionCode.</param>
        /// <param name="iraSepSimple">iraSepSimple.</param>
        /// <param name="traditionalIraSepSimpleOrRothConversionAmount">traditionalIraSepSimpleOrRothConversionAmount.</param>
        /// <param name="otherAmount">otherAmount.</param>
        /// <param name="otherPercentage">otherPercentage.</param>
        /// <param name="totalDistributionPercentage">totalDistributionPercentage.</param>
        /// <param name="totalEmployeeContributions">totalEmployeeContributions.</param>
        /// <param name="amountAllocableToIrrWithin5Years">amountAllocableToIrrWithin5Years.</param>
        /// <param name="firstYearOfDesignatedRothContribution">firstYearOfDesignatedRothContribution.</param>
        /// <param name="fatcaFilingRequirement">fatcaFilingRequirement.</param>
        /// <param name="dateOfPayment">dateOfPayment.</param>
        /// <param name="issuerReferenceId">issuerReferenceId.</param>
        /// <param name="issuerTin">issuerTin.</param>
        /// <param name="taxYear">taxYear.</param>
        /// <param name="issuerId">issuerId.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="recipientName">recipientName.</param>
        /// <param name="recipientTin">recipientTin.</param>
        /// <param name="tinType">tinType.</param>
        /// <param name="recipientSecondName">recipientSecondName.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="recipientEmail">recipientEmail.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="officeCode">officeCode.</param>
        /// <param name="recipientNonUsProvince">recipientNonUsProvince.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="federalEFile">federalEFile.</param>
        /// <param name="postalMail">postalMail.</param>
        /// <param name="stateEFile">stateEFile.</param>
        /// <param name="tinMatch">tinMatch.</param>
        /// <param name="addressVerification">addressVerification.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1099RListItem(double grossDistribution = default(double), double taxableAmount = default(double), bool taxableAmountNotDetermined = default(bool), bool totalDistributionDetermined = default(bool), double capitalGain = default(double), double federalIncomeTaxWithheld = default(double), double employeeContributionsOrDesignatedRothOrInsurancePremiums = default(double), double netUnrealizedAppreciationInEmployerSecurities = default(double), DistributionCodeEnum? distributionCode = default(DistributionCodeEnum?), SecondDistributionCodeEnum? secondDistributionCode = default(SecondDistributionCodeEnum?), bool iraSepSimple = default(bool), double traditionalIraSepSimpleOrRothConversionAmount = default(double), double otherAmount = default(double), string otherPercentage = default(string), string totalDistributionPercentage = default(string), double totalEmployeeContributions = default(double), double amountAllocableToIrrWithin5Years = default(double), int firstYearOfDesignatedRothContribution = default(int), bool fatcaFilingRequirement = default(bool), DateTime dateOfPayment = default(DateTime), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), string issuerId = default(string), string referenceId = default(string), string recipientName = default(string), string recipientTin = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string recipientEmail = default(string), string accountNumber = default(string), string officeCode = default(string), string recipientNonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
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
            this.TaxYear = taxYear;
            this.IssuerId = issuerId;
            this.ReferenceId = referenceId;
            this.RecipientName = recipientName;
            this.RecipientTin = recipientTin;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.RecipientEmail = recipientEmail;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.RecipientNonUsProvince = recipientNonUsProvince;
            this.CountryCode = countryCode;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Gets or Sets GrossDistribution
        /// </summary>
        [DataMember(Name = "grossDistribution", EmitDefaultValue = false)]
        public double GrossDistribution { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name = "taxableAmount", EmitDefaultValue = false)]
        public double TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmountNotDetermined
        /// </summary>
        [DataMember(Name = "taxableAmountNotDetermined", EmitDefaultValue = true)]
        public bool TaxableAmountNotDetermined { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistributionDetermined
        /// </summary>
        [DataMember(Name = "totalDistributionDetermined", EmitDefaultValue = true)]
        public bool TotalDistributionDetermined { get; set; }

        /// <summary>
        /// Gets or Sets CapitalGain
        /// </summary>
        [DataMember(Name = "capitalGain", EmitDefaultValue = false)]
        public double CapitalGain { get; set; }

        /// <summary>
        /// Gets or Sets FederalIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = false)]
        public double FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeContributionsOrDesignatedRothOrInsurancePremiums
        /// </summary>
        [DataMember(Name = "employeeContributionsOrDesignatedRothOrInsurancePremiums", EmitDefaultValue = false)]
        public double EmployeeContributionsOrDesignatedRothOrInsurancePremiums { get; set; }

        /// <summary>
        /// Gets or Sets NetUnrealizedAppreciationInEmployerSecurities
        /// </summary>
        [DataMember(Name = "netUnrealizedAppreciationInEmployerSecurities", EmitDefaultValue = false)]
        public double NetUnrealizedAppreciationInEmployerSecurities { get; set; }

        /// <summary>
        /// Gets or Sets IraSepSimple
        /// </summary>
        [DataMember(Name = "iraSepSimple", EmitDefaultValue = true)]
        public bool IraSepSimple { get; set; }

        /// <summary>
        /// Gets or Sets TraditionalIraSepSimpleOrRothConversionAmount
        /// </summary>
        [DataMember(Name = "traditionalIraSepSimpleOrRothConversionAmount", EmitDefaultValue = false)]
        public double TraditionalIraSepSimpleOrRothConversionAmount { get; set; }

        /// <summary>
        /// Gets or Sets OtherAmount
        /// </summary>
        [DataMember(Name = "otherAmount", EmitDefaultValue = false)]
        public double OtherAmount { get; set; }

        /// <summary>
        /// Gets or Sets OtherPercentage
        /// </summary>
        [DataMember(Name = "otherPercentage", EmitDefaultValue = false)]
        public string OtherPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistributionPercentage
        /// </summary>
        [DataMember(Name = "totalDistributionPercentage", EmitDefaultValue = false)]
        public string TotalDistributionPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalEmployeeContributions
        /// </summary>
        [DataMember(Name = "totalEmployeeContributions", EmitDefaultValue = false)]
        public double TotalEmployeeContributions { get; set; }

        /// <summary>
        /// Gets or Sets AmountAllocableToIrrWithin5Years
        /// </summary>
        [DataMember(Name = "amountAllocableToIrrWithin5Years", EmitDefaultValue = false)]
        public double AmountAllocableToIrrWithin5Years { get; set; }

        /// <summary>
        /// Gets or Sets FirstYearOfDesignatedRothContribution
        /// </summary>
        [DataMember(Name = "firstYearOfDesignatedRothContribution", EmitDefaultValue = false)]
        public int FirstYearOfDesignatedRothContribution { get; set; }

        /// <summary>
        /// Gets or Sets FatcaFilingRequirement
        /// </summary>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Gets or Sets DateOfPayment
        /// </summary>
        [DataMember(Name = "dateOfPayment", EmitDefaultValue = false)]
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Gets or Sets IssuerReferenceId
        /// </summary>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = false)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerTin
        /// </summary>
        [DataMember(Name = "issuerTin", EmitDefaultValue = false)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Gets or Sets TaxYear
        /// </summary>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Gets or Sets IssuerId
        /// </summary>
        [DataMember(Name = "issuerId", EmitDefaultValue = true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets RecipientName
        /// </summary>
        [DataMember(Name = "recipientName", EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or Sets RecipientTin
        /// </summary>
        [DataMember(Name = "recipientTin", EmitDefaultValue = false)]
        public string RecipientTin { get; set; }

        /// <summary>
        /// Gets or Sets RecipientSecondName
        /// </summary>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = false)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = true)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets RecipientEmail
        /// </summary>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = true)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets OfficeCode
        /// </summary>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Gets or Sets RecipientNonUsProvince
        /// </summary>
        [DataMember(Name = "recipientNonUsProvince", EmitDefaultValue = true)]
        public string RecipientNonUsProvince { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets FederalEFile
        /// </summary>
        [DataMember(Name = "federalEFile", EmitDefaultValue = true)]
        public bool FederalEFile { get; set; }

        /// <summary>
        /// Gets or Sets PostalMail
        /// </summary>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Gets or Sets StateEFile
        /// </summary>
        [DataMember(Name = "stateEFile", EmitDefaultValue = true)]
        public bool StateEFile { get; set; }

        /// <summary>
        /// Gets or Sets TinMatch
        /// </summary>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerification
        /// </summary>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Gets or Sets StateAndLocalWithholding
        /// </summary>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = false)]
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
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientTin: ").Append(RecipientTin).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  RecipientNonUsProvince: ").Append(RecipientNonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FederalEFile: ").Append(FederalEFile).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEFile: ").Append(StateEFile).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
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
