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
    /// Form1042SListItem
    /// </summary>
    [DataContract(Name = "Form1042SListItem")]
    public partial class Form1042SListItem : IValidatableObject
    {
        /// <summary>
        /// Limitation on benefits code
        /// </summary>
        /// <value>Limitation on benefits code</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LobCodeEnum
        {
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 1,

            /// <summary>
            /// Enum GovernmentContractingState for value: GovernmentContractingState
            /// </summary>
            [EnumMember(Value = "GovernmentContractingState")]
            GovernmentContractingState = 2,

            /// <summary>
            /// Enum TaxExemptPensionTrust for value: TaxExemptPensionTrust
            /// </summary>
            [EnumMember(Value = "TaxExemptPensionTrust")]
            TaxExemptPensionTrust = 3,

            /// <summary>
            /// Enum TaxExemptCharitableOrganization for value: TaxExemptCharitableOrganization
            /// </summary>
            [EnumMember(Value = "TaxExemptCharitableOrganization")]
            TaxExemptCharitableOrganization = 4,

            /// <summary>
            /// Enum PubliclyTradedCorporation for value: PubliclyTradedCorporation
            /// </summary>
            [EnumMember(Value = "PubliclyTradedCorporation")]
            PubliclyTradedCorporation = 5,

            /// <summary>
            /// Enum SubsidiaryOfPubliclyTradedCorporation for value: SubsidiaryOfPubliclyTradedCorporation
            /// </summary>
            [EnumMember(Value = "SubsidiaryOfPubliclyTradedCorporation")]
            SubsidiaryOfPubliclyTradedCorporation = 6,

            /// <summary>
            /// Enum CompanyOwnershipBaseErosionTest for value: CompanyOwnershipBaseErosionTest
            /// </summary>
            [EnumMember(Value = "CompanyOwnershipBaseErosionTest")]
            CompanyOwnershipBaseErosionTest = 7,

            /// <summary>
            /// Enum CompanyDerivativeBenefitsTest for value: CompanyDerivativeBenefitsTest
            /// </summary>
            [EnumMember(Value = "CompanyDerivativeBenefitsTest")]
            CompanyDerivativeBenefitsTest = 8,

            /// <summary>
            /// Enum CompanyActiveTradeOrBusinessTest for value: CompanyActiveTradeOrBusinessTest
            /// </summary>
            [EnumMember(Value = "CompanyActiveTradeOrBusinessTest")]
            CompanyActiveTradeOrBusinessTest = 9,

            /// <summary>
            /// Enum DiscretionaryDetermination for value: DiscretionaryDetermination
            /// </summary>
            [EnumMember(Value = "DiscretionaryDetermination")]
            DiscretionaryDetermination = 10,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 11,

            /// <summary>
            /// Enum NoLobArticleInTreaty for value: NoLobArticleInTreaty
            /// </summary>
            [EnumMember(Value = "NoLobArticleInTreaty")]
            NoLobArticleInTreaty = 12
        }


        /// <summary>
        /// Limitation on benefits code
        /// </summary>
        /// <value>Limitation on benefits code</value>
        [DataMember(Name = "lobCode", EmitDefaultValue = true)]
        public LobCodeEnum? LobCode { get; set; }
        /// <summary>
        /// Exemption code (Chapter 3)
        /// </summary>
        /// <value>Exemption code (Chapter 3)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExemptionCodeChap3Enum
        {
            /// <summary>
            /// Enum TaxRateDueToBackupWithholding for value: TaxRateDueToBackupWithholding
            /// </summary>
            [EnumMember(Value = "TaxRateDueToBackupWithholding")]
            TaxRateDueToBackupWithholding = 1,

            /// <summary>
            /// Enum EffectivelyConnectedIncome for value: EffectivelyConnectedIncome
            /// </summary>
            [EnumMember(Value = "EffectivelyConnectedIncome")]
            EffectivelyConnectedIncome = 2,

            /// <summary>
            /// Enum ExemptUnderIrc for value: ExemptUnderIrc
            /// </summary>
            [EnumMember(Value = "ExemptUnderIrc")]
            ExemptUnderIrc = 3,

            /// <summary>
            /// Enum IncomeNotFromUsSources for value: IncomeNotFromUsSources
            /// </summary>
            [EnumMember(Value = "IncomeNotFromUsSources")]
            IncomeNotFromUsSources = 4,

            /// <summary>
            /// Enum ExemptUnderTaxTreaty for value: ExemptUnderTaxTreaty
            /// </summary>
            [EnumMember(Value = "ExemptUnderTaxTreaty")]
            ExemptUnderTaxTreaty = 5,

            /// <summary>
            /// Enum PortfolioInterestExemptUnderIrc for value: PortfolioInterestExemptUnderIrc
            /// </summary>
            [EnumMember(Value = "PortfolioInterestExemptUnderIrc")]
            PortfolioInterestExemptUnderIrc = 6,

            /// <summary>
            /// Enum QiThatAssumesPrimaryWithholdingResponsibility for value: QiThatAssumesPrimaryWithholdingResponsibility
            /// </summary>
            [EnumMember(Value = "QiThatAssumesPrimaryWithholdingResponsibility")]
            QiThatAssumesPrimaryWithholdingResponsibility = 7,

            /// <summary>
            /// Enum WfPorWft for value: WfPorWft
            /// </summary>
            [EnumMember(Value = "WfPorWft")]
            WfPorWft = 8,

            /// <summary>
            /// Enum UsBranchTreatedAsUsPerson for value: UsBranchTreatedAsUsPerson
            /// </summary>
            [EnumMember(Value = "UsBranchTreatedAsUsPerson")]
            UsBranchTreatedAsUsPerson = 9,

            /// <summary>
            /// Enum TerritoryFiTreatedAsUsPerson for value: TerritoryFiTreatedAsUsPerson
            /// </summary>
            [EnumMember(Value = "TerritoryFiTreatedAsUsPerson")]
            TerritoryFiTreatedAsUsPerson = 10,

            /// <summary>
            /// Enum QiRepresentsIncomeExempt for value: QiRepresentsIncomeExempt
            /// </summary>
            [EnumMember(Value = "QiRepresentsIncomeExempt")]
            QiRepresentsIncomeExempt = 11,

            /// <summary>
            /// Enum QslThatAssumesPrimaryWithholdingResponsibility for value: QslThatAssumesPrimaryWithholdingResponsibility
            /// </summary>
            [EnumMember(Value = "QslThatAssumesPrimaryWithholdingResponsibility")]
            QslThatAssumesPrimaryWithholdingResponsibility = 12,

            /// <summary>
            /// Enum PayeeSubjectedToChapter4Withholding for value: PayeeSubjectedToChapter4Withholding
            /// </summary>
            [EnumMember(Value = "PayeeSubjectedToChapter4Withholding")]
            PayeeSubjectedToChapter4Withholding = 13,

            /// <summary>
            /// Enum QddThatAssumesPrimaryWithholdingResponsibility for value: QddThatAssumesPrimaryWithholdingResponsibility
            /// </summary>
            [EnumMember(Value = "QddThatAssumesPrimaryWithholdingResponsibility")]
            QddThatAssumesPrimaryWithholdingResponsibility = 14,

            /// <summary>
            /// Enum ExemptUnderSection897L for value: ExemptUnderSection897L
            /// </summary>
            [EnumMember(Value = "ExemptUnderSection897L")]
            ExemptUnderSection897L = 15,

            /// <summary>
            /// Enum ExemptUnderSection892 for value: ExemptUnderSection892
            /// </summary>
            [EnumMember(Value = "ExemptUnderSection892")]
            ExemptUnderSection892 = 16
        }


        /// <summary>
        /// Exemption code (Chapter 3)
        /// </summary>
        /// <value>Exemption code (Chapter 3)</value>
        [DataMember(Name = "exemptionCodeChap3", EmitDefaultValue = true)]
        public ExemptionCodeChap3Enum? ExemptionCodeChap3 { get; set; }
        /// <summary>
        /// Exemption code (Chapter 4)
        /// </summary>
        /// <value>Exemption code (Chapter 4)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExemptionCodeChap4Enum
        {
            /// <summary>
            /// Enum NotExempt for value: NotExempt
            /// </summary>
            [EnumMember(Value = "NotExempt")]
            NotExempt = 1,

            /// <summary>
            /// Enum GrandfatheredPayment for value: GrandfatheredPayment
            /// </summary>
            [EnumMember(Value = "GrandfatheredPayment")]
            GrandfatheredPayment = 2,

            /// <summary>
            /// Enum EffectivelyConnectedIncome for value: EffectivelyConnectedIncome
            /// </summary>
            [EnumMember(Value = "EffectivelyConnectedIncome")]
            EffectivelyConnectedIncome = 3,

            /// <summary>
            /// Enum PayeeNotSubjectToChapter4Withholding for value: PayeeNotSubjectToChapter4Withholding
            /// </summary>
            [EnumMember(Value = "PayeeNotSubjectToChapter4Withholding")]
            PayeeNotSubjectToChapter4Withholding = 4,

            /// <summary>
            /// Enum ExcludedNonfinancialPayment for value: ExcludedNonfinancialPayment
            /// </summary>
            [EnumMember(Value = "ExcludedNonfinancialPayment")]
            ExcludedNonfinancialPayment = 5,

            /// <summary>
            /// Enum ForeignEntityThatAssumesPrimaryWithholdingResponsibility for value: ForeignEntityThatAssumesPrimaryWithholdingResponsibility
            /// </summary>
            [EnumMember(Value = "ForeignEntityThatAssumesPrimaryWithholdingResponsibility")]
            ForeignEntityThatAssumesPrimaryWithholdingResponsibility = 6,

            /// <summary>
            /// Enum UsPayeesOfParticipatingFfi for value: UsPayeesOfParticipatingFfi
            /// </summary>
            [EnumMember(Value = "UsPayeesOfParticipatingFfi")]
            UsPayeesOfParticipatingFfi = 7,

            /// <summary>
            /// Enum ExemptFromWithholdingUnderIga for value: ExemptFromWithholdingUnderIga
            /// </summary>
            [EnumMember(Value = "ExemptFromWithholdingUnderIga")]
            ExemptFromWithholdingUnderIga = 8,

            /// <summary>
            /// Enum DormantAccount for value: DormantAccount
            /// </summary>
            [EnumMember(Value = "DormantAccount")]
            DormantAccount = 9,

            /// <summary>
            /// Enum OtherPaymentNotSubjectToChapter4Withholding for value: OtherPaymentNotSubjectToChapter4Withholding
            /// </summary>
            [EnumMember(Value = "OtherPaymentNotSubjectToChapter4Withholding")]
            OtherPaymentNotSubjectToChapter4Withholding = 10
        }


        /// <summary>
        /// Exemption code (Chapter 4)
        /// </summary>
        /// <value>Exemption code (Chapter 4)</value>
        [DataMember(Name = "exemptionCodeChap4", EmitDefaultValue = true)]
        public ExemptionCodeChap4Enum? ExemptionCodeChap4 { get; set; }
        /// <summary>
        /// Chapter 3 status code
        /// </summary>
        /// <value>Chapter 3 status code</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Chap3StatusCodeEnum
        {
            /// <summary>
            /// Enum USWithholdingAgentFI for value: USWithholdingAgentFI
            /// </summary>
            [EnumMember(Value = "USWithholdingAgentFI")]
            USWithholdingAgentFI = 1,

            /// <summary>
            /// Enum USWithholdingAgentOther for value: USWithholdingAgentOther
            /// </summary>
            [EnumMember(Value = "USWithholdingAgentOther")]
            USWithholdingAgentOther = 2,

            /// <summary>
            /// Enum TerritoryFITreatedAsUSPerson for value: TerritoryFITreatedAsUSPerson
            /// </summary>
            [EnumMember(Value = "TerritoryFITreatedAsUSPerson")]
            TerritoryFITreatedAsUSPerson = 3,

            /// <summary>
            /// Enum TerritoryFINotTreatedAsUSPerson for value: TerritoryFINotTreatedAsUSPerson
            /// </summary>
            [EnumMember(Value = "TerritoryFINotTreatedAsUSPerson")]
            TerritoryFINotTreatedAsUSPerson = 4,

            /// <summary>
            /// Enum USBranchTreatedAsUSPerson for value: USBranchTreatedAsUSPerson
            /// </summary>
            [EnumMember(Value = "USBranchTreatedAsUSPerson")]
            USBranchTreatedAsUSPerson = 5,

            /// <summary>
            /// Enum USBranchNotTreatedAsUSPerson for value: USBranchNotTreatedAsUSPerson
            /// </summary>
            [EnumMember(Value = "USBranchNotTreatedAsUSPerson")]
            USBranchNotTreatedAsUSPerson = 6,

            /// <summary>
            /// Enum USBranchECIPresumptionApplied for value: USBranchECIPresumptionApplied
            /// </summary>
            [EnumMember(Value = "USBranchECIPresumptionApplied")]
            USBranchECIPresumptionApplied = 7,

            /// <summary>
            /// Enum PartnershipOtherThanWithholdingForeignPartnership for value: PartnershipOtherThanWithholdingForeignPartnership
            /// </summary>
            [EnumMember(Value = "PartnershipOtherThanWithholdingForeignPartnership")]
            PartnershipOtherThanWithholdingForeignPartnership = 8,

            /// <summary>
            /// Enum WithholdingForeignPartnership for value: WithholdingForeignPartnership
            /// </summary>
            [EnumMember(Value = "WithholdingForeignPartnership")]
            WithholdingForeignPartnership = 9,

            /// <summary>
            /// Enum TrustOtherThanWithholdingForeignTrust for value: TrustOtherThanWithholdingForeignTrust
            /// </summary>
            [EnumMember(Value = "TrustOtherThanWithholdingForeignTrust")]
            TrustOtherThanWithholdingForeignTrust = 10,

            /// <summary>
            /// Enum WithholdingForeignTrust for value: WithholdingForeignTrust
            /// </summary>
            [EnumMember(Value = "WithholdingForeignTrust")]
            WithholdingForeignTrust = 11,

            /// <summary>
            /// Enum QualifiedIntermediary for value: QualifiedIntermediary
            /// </summary>
            [EnumMember(Value = "QualifiedIntermediary")]
            QualifiedIntermediary = 12,

            /// <summary>
            /// Enum QualifiedSecuritiesLenderQualifiedIntermediary for value: QualifiedSecuritiesLenderQualifiedIntermediary
            /// </summary>
            [EnumMember(Value = "QualifiedSecuritiesLenderQualifiedIntermediary")]
            QualifiedSecuritiesLenderQualifiedIntermediary = 13,

            /// <summary>
            /// Enum QualifiedSecuritiesLenderOther for value: QualifiedSecuritiesLenderOther
            /// </summary>
            [EnumMember(Value = "QualifiedSecuritiesLenderOther")]
            QualifiedSecuritiesLenderOther = 14,

            /// <summary>
            /// Enum Corporation for value: Corporation
            /// </summary>
            [EnumMember(Value = "Corporation")]
            Corporation = 15,

            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 16,

            /// <summary>
            /// Enum Estate for value: Estate
            /// </summary>
            [EnumMember(Value = "Estate")]
            Estate = 17,

            /// <summary>
            /// Enum PrivateFoundation for value: PrivateFoundation
            /// </summary>
            [EnumMember(Value = "PrivateFoundation")]
            PrivateFoundation = 18,

            /// <summary>
            /// Enum GovernmentOrInternationalOrganization for value: GovernmentOrInternationalOrganization
            /// </summary>
            [EnumMember(Value = "GovernmentOrInternationalOrganization")]
            GovernmentOrInternationalOrganization = 19,

            /// <summary>
            /// Enum TaxExemptOrganizationSection501cEntities for value: TaxExemptOrganizationSection501cEntities
            /// </summary>
            [EnumMember(Value = "TaxExemptOrganizationSection501cEntities")]
            TaxExemptOrganizationSection501cEntities = 20,

            /// <summary>
            /// Enum UnknownRecipient for value: UnknownRecipient
            /// </summary>
            [EnumMember(Value = "UnknownRecipient")]
            UnknownRecipient = 21,

            /// <summary>
            /// Enum ArtistOrAthlete for value: ArtistOrAthlete
            /// </summary>
            [EnumMember(Value = "ArtistOrAthlete")]
            ArtistOrAthlete = 22,

            /// <summary>
            /// Enum Pension for value: Pension
            /// </summary>
            [EnumMember(Value = "Pension")]
            Pension = 23,

            /// <summary>
            /// Enum ForeignCentralBankOfIssue for value: ForeignCentralBankOfIssue
            /// </summary>
            [EnumMember(Value = "ForeignCentralBankOfIssue")]
            ForeignCentralBankOfIssue = 24,

            /// <summary>
            /// Enum NonqualifiedIntermediary for value: NonqualifiedIntermediary
            /// </summary>
            [EnumMember(Value = "NonqualifiedIntermediary")]
            NonqualifiedIntermediary = 25,

            /// <summary>
            /// Enum HybridEntityMakingTreatyClaim for value: HybridEntityMakingTreatyClaim
            /// </summary>
            [EnumMember(Value = "HybridEntityMakingTreatyClaim")]
            HybridEntityMakingTreatyClaim = 26,

            /// <summary>
            /// Enum WithholdingRatePoolGeneral for value: WithholdingRatePoolGeneral
            /// </summary>
            [EnumMember(Value = "WithholdingRatePoolGeneral")]
            WithholdingRatePoolGeneral = 27,

            /// <summary>
            /// Enum WithholdingRatePoolExemptOrganization for value: WithholdingRatePoolExemptOrganization
            /// </summary>
            [EnumMember(Value = "WithholdingRatePoolExemptOrganization")]
            WithholdingRatePoolExemptOrganization = 28,

            /// <summary>
            /// Enum PAIWithholdingRatePoolGeneral for value: PAIWithholdingRatePoolGeneral
            /// </summary>
            [EnumMember(Value = "PAIWithholdingRatePoolGeneral")]
            PAIWithholdingRatePoolGeneral = 29,

            /// <summary>
            /// Enum PAIWithholdingRatePoolExemptOrganization for value: PAIWithholdingRatePoolExemptOrganization
            /// </summary>
            [EnumMember(Value = "PAIWithholdingRatePoolExemptOrganization")]
            PAIWithholdingRatePoolExemptOrganization = 30,

            /// <summary>
            /// Enum AgencyWithholdingRatePoolGeneral for value: AgencyWithholdingRatePoolGeneral
            /// </summary>
            [EnumMember(Value = "AgencyWithholdingRatePoolGeneral")]
            AgencyWithholdingRatePoolGeneral = 31,

            /// <summary>
            /// Enum AgencyWithholdingRatePoolExemptOrganization for value: AgencyWithholdingRatePoolExemptOrganization
            /// </summary>
            [EnumMember(Value = "AgencyWithholdingRatePoolExemptOrganization")]
            AgencyWithholdingRatePoolExemptOrganization = 32,

            /// <summary>
            /// Enum USWithholdingAgentForeignBranchOfFI for value: USWithholdingAgentForeignBranchOfFI
            /// </summary>
            [EnumMember(Value = "USWithholdingAgentForeignBranchOfFI")]
            USWithholdingAgentForeignBranchOfFI = 33,

            /// <summary>
            /// Enum QualifiedDerivativesDealer for value: QualifiedDerivativesDealer
            /// </summary>
            [EnumMember(Value = "QualifiedDerivativesDealer")]
            QualifiedDerivativesDealer = 34,

            /// <summary>
            /// Enum ForeignGovernmentIntegralPart for value: ForeignGovernmentIntegralPart
            /// </summary>
            [EnumMember(Value = "ForeignGovernmentIntegralPart")]
            ForeignGovernmentIntegralPart = 35,

            /// <summary>
            /// Enum ForeignGovernmentControlledEntity for value: ForeignGovernmentControlledEntity
            /// </summary>
            [EnumMember(Value = "ForeignGovernmentControlledEntity")]
            ForeignGovernmentControlledEntity = 36,

            /// <summary>
            /// Enum PubliclyTradedPartnership for value: PubliclyTradedPartnership
            /// </summary>
            [EnumMember(Value = "PubliclyTradedPartnership")]
            PubliclyTradedPartnership = 37,

            /// <summary>
            /// Enum DisclosingQualifiedIntermediary for value: DisclosingQualifiedIntermediary
            /// </summary>
            [EnumMember(Value = "DisclosingQualifiedIntermediary")]
            DisclosingQualifiedIntermediary = 38
        }


        /// <summary>
        /// Chapter 3 status code
        /// </summary>
        /// <value>Chapter 3 status code</value>
        [DataMember(Name = "chap3StatusCode", EmitDefaultValue = true)]
        public Chap3StatusCodeEnum? Chap3StatusCode { get; set; }
        /// <summary>
        /// Chapter 4 status code
        /// </summary>
        /// <value>Chapter 4 status code</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Chap4StatusCodeEnum
        {
            /// <summary>
            /// Enum UsWithholdingAgentFi for value: UsWithholdingAgentFi
            /// </summary>
            [EnumMember(Value = "UsWithholdingAgentFi")]
            UsWithholdingAgentFi = 1,

            /// <summary>
            /// Enum UsWithholdingAgentOther for value: UsWithholdingAgentOther
            /// </summary>
            [EnumMember(Value = "UsWithholdingAgentOther")]
            UsWithholdingAgentOther = 2,

            /// <summary>
            /// Enum TerritoryFiNotTreatedAsUsPerson for value: TerritoryFiNotTreatedAsUsPerson
            /// </summary>
            [EnumMember(Value = "TerritoryFiNotTreatedAsUsPerson")]
            TerritoryFiNotTreatedAsUsPerson = 3,

            /// <summary>
            /// Enum TerritoryFiTreatedAsUsPerson for value: TerritoryFiTreatedAsUsPerson
            /// </summary>
            [EnumMember(Value = "TerritoryFiTreatedAsUsPerson")]
            TerritoryFiTreatedAsUsPerson = 4,

            /// <summary>
            /// Enum ParticipatingFfiOther for value: ParticipatingFfiOther
            /// </summary>
            [EnumMember(Value = "ParticipatingFfiOther")]
            ParticipatingFfiOther = 5,

            /// <summary>
            /// Enum ParticipatingFfiReportingModel2Ffi for value: ParticipatingFfiReportingModel2Ffi
            /// </summary>
            [EnumMember(Value = "ParticipatingFfiReportingModel2Ffi")]
            ParticipatingFfiReportingModel2Ffi = 6,

            /// <summary>
            /// Enum RegisteredDeemedCompliantFfiReportingModel1Ffi for value: RegisteredDeemedCompliantFfiReportingModel1Ffi
            /// </summary>
            [EnumMember(Value = "RegisteredDeemedCompliantFfiReportingModel1Ffi")]
            RegisteredDeemedCompliantFfiReportingModel1Ffi = 7,

            /// <summary>
            /// Enum RegisteredDeemedCompliantFfiSponsoredEntity for value: RegisteredDeemedCompliantFfiSponsoredEntity
            /// </summary>
            [EnumMember(Value = "RegisteredDeemedCompliantFfiSponsoredEntity")]
            RegisteredDeemedCompliantFfiSponsoredEntity = 8,

            /// <summary>
            /// Enum RegisteredDeemedCompliantFfiOther for value: RegisteredDeemedCompliantFfiOther
            /// </summary>
            [EnumMember(Value = "RegisteredDeemedCompliantFfiOther")]
            RegisteredDeemedCompliantFfiOther = 9,

            /// <summary>
            /// Enum CertifiedDeemedCompliantFfiOther for value: CertifiedDeemedCompliantFfiOther
            /// </summary>
            [EnumMember(Value = "CertifiedDeemedCompliantFfiOther")]
            CertifiedDeemedCompliantFfiOther = 10,

            /// <summary>
            /// Enum CertifiedDeemedCompliantFfiffiWithLowValueAccounts for value: CertifiedDeemedCompliantFfiffiWithLowValueAccounts
            /// </summary>
            [EnumMember(Value = "CertifiedDeemedCompliantFfiffiWithLowValueAccounts")]
            CertifiedDeemedCompliantFfiffiWithLowValueAccounts = 11,

            /// <summary>
            /// Enum CertifiedDeemedCompliantFfiNonRegisteringLocalBank for value: CertifiedDeemedCompliantFfiNonRegisteringLocalBank
            /// </summary>
            [EnumMember(Value = "CertifiedDeemedCompliantFfiNonRegisteringLocalBank")]
            CertifiedDeemedCompliantFfiNonRegisteringLocalBank = 12,

            /// <summary>
            /// Enum CertifiedDeemedCompliantFfiSponsoredEntity for value: CertifiedDeemedCompliantFfiSponsoredEntity
            /// </summary>
            [EnumMember(Value = "CertifiedDeemedCompliantFfiSponsoredEntity")]
            CertifiedDeemedCompliantFfiSponsoredEntity = 13,

            /// <summary>
            /// Enum CertifiedDeemedCompliantFfiInvestmentAdvisorOrManager for value: CertifiedDeemedCompliantFfiInvestmentAdvisorOrManager
            /// </summary>
            [EnumMember(Value = "CertifiedDeemedCompliantFfiInvestmentAdvisorOrManager")]
            CertifiedDeemedCompliantFfiInvestmentAdvisorOrManager = 14,

            /// <summary>
            /// Enum NonparticipatingFfi for value: NonparticipatingFfi
            /// </summary>
            [EnumMember(Value = "NonparticipatingFfi")]
            NonparticipatingFfi = 15,

            /// <summary>
            /// Enum OwnerDocumentedFfi for value: OwnerDocumentedFfi
            /// </summary>
            [EnumMember(Value = "OwnerDocumentedFfi")]
            OwnerDocumentedFfi = 16,

            /// <summary>
            /// Enum UsBranchTreatedAsUsPerson for value: UsBranchTreatedAsUsPerson
            /// </summary>
            [EnumMember(Value = "UsBranchTreatedAsUsPerson")]
            UsBranchTreatedAsUsPerson = 17,

            /// <summary>
            /// Enum UsBranchNotTreatedAsUsPerson for value: UsBranchNotTreatedAsUsPerson
            /// </summary>
            [EnumMember(Value = "UsBranchNotTreatedAsUsPerson")]
            UsBranchNotTreatedAsUsPerson = 18,

            /// <summary>
            /// Enum PassiveNffeIdentifyingSubstantialUsOwners for value: PassiveNffeIdentifyingSubstantialUsOwners
            /// </summary>
            [EnumMember(Value = "PassiveNffeIdentifyingSubstantialUsOwners")]
            PassiveNffeIdentifyingSubstantialUsOwners = 19,

            /// <summary>
            /// Enum PassiveNffeWithNoSubstantialUsOwners for value: PassiveNffeWithNoSubstantialUsOwners
            /// </summary>
            [EnumMember(Value = "PassiveNffeWithNoSubstantialUsOwners")]
            PassiveNffeWithNoSubstantialUsOwners = 20,

            /// <summary>
            /// Enum PubliclyTradedNffeOrAffiliate for value: PubliclyTradedNffeOrAffiliate
            /// </summary>
            [EnumMember(Value = "PubliclyTradedNffeOrAffiliate")]
            PubliclyTradedNffeOrAffiliate = 21,

            /// <summary>
            /// Enum ActiveNffe for value: ActiveNffe
            /// </summary>
            [EnumMember(Value = "ActiveNffe")]
            ActiveNffe = 22,

            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 23,

            /// <summary>
            /// Enum Section501CEntities for value: Section501CEntities
            /// </summary>
            [EnumMember(Value = "Section501CEntities")]
            Section501CEntities = 24,

            /// <summary>
            /// Enum ExceptedTerritoryNffe for value: ExceptedTerritoryNffe
            /// </summary>
            [EnumMember(Value = "ExceptedTerritoryNffe")]
            ExceptedTerritoryNffe = 25,

            /// <summary>
            /// Enum ExceptedNffeOther for value: ExceptedNffeOther
            /// </summary>
            [EnumMember(Value = "ExceptedNffeOther")]
            ExceptedNffeOther = 26,

            /// <summary>
            /// Enum ExemptBeneficialOwner for value: ExemptBeneficialOwner
            /// </summary>
            [EnumMember(Value = "ExemptBeneficialOwner")]
            ExemptBeneficialOwner = 27,

            /// <summary>
            /// Enum EntityWhollyOwnedByExemptBeneficialOwners for value: EntityWhollyOwnedByExemptBeneficialOwners
            /// </summary>
            [EnumMember(Value = "EntityWhollyOwnedByExemptBeneficialOwners")]
            EntityWhollyOwnedByExemptBeneficialOwners = 28,

            /// <summary>
            /// Enum UnknownRecipient for value: UnknownRecipient
            /// </summary>
            [EnumMember(Value = "UnknownRecipient")]
            UnknownRecipient = 29,

            /// <summary>
            /// Enum RecalcitrantAccountHolder for value: RecalcitrantAccountHolder
            /// </summary>
            [EnumMember(Value = "RecalcitrantAccountHolder")]
            RecalcitrantAccountHolder = 30,

            /// <summary>
            /// Enum NonreportingIgafii for value: NonreportingIgafii
            /// </summary>
            [EnumMember(Value = "NonreportingIgafii")]
            NonreportingIgafii = 31,

            /// <summary>
            /// Enum DirectReportingNffe for value: DirectReportingNffe
            /// </summary>
            [EnumMember(Value = "DirectReportingNffe")]
            DirectReportingNffe = 32,

            /// <summary>
            /// Enum UsReportableAccount for value: UsReportableAccount
            /// </summary>
            [EnumMember(Value = "UsReportableAccount")]
            UsReportableAccount = 33,

            /// <summary>
            /// Enum NonConsentingUsAccount for value: NonConsentingUsAccount
            /// </summary>
            [EnumMember(Value = "NonConsentingUsAccount")]
            NonConsentingUsAccount = 34,

            /// <summary>
            /// Enum SponsoredDirectReportingNffe for value: SponsoredDirectReportingNffe
            /// </summary>
            [EnumMember(Value = "SponsoredDirectReportingNffe")]
            SponsoredDirectReportingNffe = 35,

            /// <summary>
            /// Enum ExceptedInterAffiliateFfi for value: ExceptedInterAffiliateFfi
            /// </summary>
            [EnumMember(Value = "ExceptedInterAffiliateFfi")]
            ExceptedInterAffiliateFfi = 36,

            /// <summary>
            /// Enum UndocumentedPreexistingObligation for value: UndocumentedPreexistingObligation
            /// </summary>
            [EnumMember(Value = "UndocumentedPreexistingObligation")]
            UndocumentedPreexistingObligation = 37,

            /// <summary>
            /// Enum UsBranchEciPresumptionApplied for value: UsBranchEciPresumptionApplied
            /// </summary>
            [EnumMember(Value = "UsBranchEciPresumptionApplied")]
            UsBranchEciPresumptionApplied = 38,

            /// <summary>
            /// Enum AccountHolderOfExcludedFinancialAccount for value: AccountHolderOfExcludedFinancialAccount
            /// </summary>
            [EnumMember(Value = "AccountHolderOfExcludedFinancialAccount")]
            AccountHolderOfExcludedFinancialAccount = 39,

            /// <summary>
            /// Enum PassiveNffeReportedByFfi for value: PassiveNffeReportedByFfi
            /// </summary>
            [EnumMember(Value = "PassiveNffeReportedByFfi")]
            PassiveNffeReportedByFfi = 40,

            /// <summary>
            /// Enum NffeSubjectTo1472Withholding for value: NffeSubjectTo1472Withholding
            /// </summary>
            [EnumMember(Value = "NffeSubjectTo1472Withholding")]
            NffeSubjectTo1472Withholding = 41,

            /// <summary>
            /// Enum RecalcitrantPoolNoUsIndicia for value: RecalcitrantPoolNoUsIndicia
            /// </summary>
            [EnumMember(Value = "RecalcitrantPoolNoUsIndicia")]
            RecalcitrantPoolNoUsIndicia = 42,

            /// <summary>
            /// Enum RecalcitrantPoolUsIndicia for value: RecalcitrantPoolUsIndicia
            /// </summary>
            [EnumMember(Value = "RecalcitrantPoolUsIndicia")]
            RecalcitrantPoolUsIndicia = 43,

            /// <summary>
            /// Enum RecalcitrantPoolDormantAccount for value: RecalcitrantPoolDormantAccount
            /// </summary>
            [EnumMember(Value = "RecalcitrantPoolDormantAccount")]
            RecalcitrantPoolDormantAccount = 44,

            /// <summary>
            /// Enum RecalcitrantPoolUsPersons for value: RecalcitrantPoolUsPersons
            /// </summary>
            [EnumMember(Value = "RecalcitrantPoolUsPersons")]
            RecalcitrantPoolUsPersons = 45,

            /// <summary>
            /// Enum RecalcitrantPoolPassiveNffEs for value: RecalcitrantPoolPassiveNffEs
            /// </summary>
            [EnumMember(Value = "RecalcitrantPoolPassiveNffEs")]
            RecalcitrantPoolPassiveNffEs = 46,

            /// <summary>
            /// Enum NonparticipatingFfiPool for value: NonparticipatingFfiPool
            /// </summary>
            [EnumMember(Value = "NonparticipatingFfiPool")]
            NonparticipatingFfiPool = 47,

            /// <summary>
            /// Enum UsPayeesPool for value: UsPayeesPool
            /// </summary>
            [EnumMember(Value = "UsPayeesPool")]
            UsPayeesPool = 48,

            /// <summary>
            /// Enum QiRecalcitrantPoolGeneral for value: QiRecalcitrantPoolGeneral
            /// </summary>
            [EnumMember(Value = "QiRecalcitrantPoolGeneral")]
            QiRecalcitrantPoolGeneral = 49,

            /// <summary>
            /// Enum UsWithholdingAgentForeignBranchOfFi for value: UsWithholdingAgentForeignBranchOfFi
            /// </summary>
            [EnumMember(Value = "UsWithholdingAgentForeignBranchOfFi")]
            UsWithholdingAgentForeignBranchOfFi = 50
        }


        /// <summary>
        /// Chapter 4 status code
        /// </summary>
        /// <value>Chapter 4 status code</value>
        [DataMember(Name = "chap4StatusCode", EmitDefaultValue = true)]
        public Chap4StatusCodeEnum? Chap4StatusCode { get; set; }
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
        /// Initializes a new instance of the <see cref="Form1042SListItem" /> class.
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
        /// <param name="secondTinNotice">Second TIN notice in three years.</param>
        /// <param name="fatcaFilingRequirement">Fatca filing requirement.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        public Form1042SListItem(string uniqueFormId = default(string), bool? noTin = default(bool?), DateTime? recipientDateOfBirth = default(DateTime?), string recipientGiin = default(string), string recipientForeignTin = default(string), LobCodeEnum? lobCode = default(LobCodeEnum?), string incomeCode = default(string), double grossIncome = default(double), string withholdingIndicator = default(string), string taxCountryCode = default(string), ExemptionCodeChap3Enum? exemptionCodeChap3 = default(ExemptionCodeChap3Enum?), ExemptionCodeChap4Enum? exemptionCodeChap4 = default(ExemptionCodeChap4Enum?), string taxRateChap3 = default(string), double? withholdingAllowance = default(double?), double? federalTaxWithheld = default(double?), bool? taxNotDepositedIndicator = default(bool?), bool? academicIndicator = default(bool?), double? taxWithheldOtherAgents = default(double?), double? amountRepaid = default(double?), double? taxPaidAgent = default(double?), Chap3StatusCodeEnum? chap3StatusCode = default(Chap3StatusCodeEnum?), Chap4StatusCodeEnum? chap4StatusCode = default(Chap4StatusCodeEnum?), PrimaryWithholdingAgent primaryWithholdingAgent = default(PrimaryWithholdingAgent), IntermediaryOrFlowThrough intermediaryOrFlowThrough = default(IntermediaryOrFlowThrough), string issuerId = default(string), string referenceId = default(string), string recipientTin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool? secondTinNotice = default(bool?), bool fatcaFilingRequirement = default(bool), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
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
            this.SecondTinNotice = secondTinNotice;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Unique form identifier
        /// </summary>
        /// <value>Unique form identifier</value>
        [DataMember(Name = "uniqueFormId", EmitDefaultValue = false)]
        public string UniqueFormId { get; set; }

        /// <summary>
        /// No TIN indicator
        /// </summary>
        /// <value>No TIN indicator</value>
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
        [DataMember(Name = "recipientForeignTin", EmitDefaultValue = true)]
        public string RecipientForeignTin { get; set; }

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
        /// Primary withholding agent information
        /// </summary>
        /// <value>Primary withholding agent information</value>
        [DataMember(Name = "primaryWithholdingAgent", EmitDefaultValue = false)]
        public PrimaryWithholdingAgent PrimaryWithholdingAgent { get; set; }

        /// <summary>
        /// Intermediary or flow-through entity information
        /// </summary>
        /// <value>Intermediary or flow-through entity information</value>
        [DataMember(Name = "intermediaryOrFlowThrough", EmitDefaultValue = false)]
        public IntermediaryOrFlowThrough IntermediaryOrFlowThrough { get; set; }

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
            sb.Append("class Form1042SListItem {\n");
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
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
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
