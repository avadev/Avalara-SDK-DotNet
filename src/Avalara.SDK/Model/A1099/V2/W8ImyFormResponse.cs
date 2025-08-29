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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// W8ImyFormResponse
    /// </summary>
    [DataContract(Name = "W8ImyFormResponse")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class W8ImyFormResponse : W9FormBaseResponse, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="W8ImyFormResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="citizenshipCountry">The country of citizenship..</param>
        /// <param name="disregardedEntity">The name of the disregarded entity receiving the payment (if applicable)..</param>
        /// <param name="entityType">The entity type..</param>
        /// <param name="fatcaStatus">The FATCA status..</param>
        /// <param name="residenceAddress">The residential address of the individual or entity..</param>
        /// <param name="residenceCity">The city of residence..</param>
        /// <param name="residenceState">The state of residence..</param>
        /// <param name="residenceZip">The ZIP code of the residence..</param>
        /// <param name="residenceCountry">The country of residence..</param>
        /// <param name="residenceIsMailing">Indicates whether the residence address is also the mailing address..</param>
        /// <param name="mailingAddress">The mailing address..</param>
        /// <param name="mailingCity">The city of the mailing address..</param>
        /// <param name="mailingState">The state of the mailing address..</param>
        /// <param name="mailingZip">The ZIP code of the mailing address..</param>
        /// <param name="mailingCountry">The country of the mailing address..</param>
        /// <param name="tinType">The type of TIN provided..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="giin">The global intermediary identification number (GIIN)..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="disregardedEntityFatcaStatus">The FATCA status of disregarded entity or branch receiving payment..</param>
        /// <param name="disregardedAddress">The address for disregarded entities..</param>
        /// <param name="disregardedCity">The city for disregarded entities..</param>
        /// <param name="disregardedState">The state for disregarded entities..</param>
        /// <param name="disregardedZip">The ZIP code for disregarded entities..</param>
        /// <param name="disregardedCountry">The country for disregarded entities..</param>
        /// <param name="disregardedEntityGiin">The GIIN for disregarded entities..</param>
        /// <param name="qualifiedIntermediaryCertification">Certifies that the entity is a Qualified Intermediary (QI) acting in accordance with its QI Agreement,  providing required withholding statements and documentation for relevant tax withholding purposes..</param>
        /// <param name="qiPrimaryWithholdingResponsibilityCertification">Certifies that the Qualified Intermediary assumes primary withholding responsibility  under chapters 3 and 4 for the specified accounts..</param>
        /// <param name="qiWithholdingResponsibilityForPtpSalesCertification">Certifies that the Qualified Intermediary assumes primary withholding and reporting responsibility under section 1446(f)  for amounts realized from sales of interests in publicly traded partnerships..</param>
        /// <param name="qiNomineeWithholdingResponsibilityForPtpDistributionsCertification">Certifies that the Qualified Intermediary assumes primary withholding responsibility as a nominee  under Regulations section 1.1446-4(b)(3) for publicly traded partnership distributions..</param>
        /// <param name="qiSecuritiesLenderSubstituteDividendWithholdingCertification">Certifies that the Qualified Intermediary is acting as a qualified securities lender and assumes primary withholding  and reporting responsibilities for U.S. source substitute dividend payments..</param>
        /// <param name="qiWithholdingAnd1099ReportingResponsibilityCertification">Certifies that the Qualified Intermediary assumes primary withholding under chapters 3 and 4, and primary Form 1099 reporting  and backup withholding responsibility for U.S. source interest and substitute interest payments..</param>
        /// <param name="qiForm1099OrFatcaReportingResponsibilityCertification">Certifies that the Qualified Intermediary assumes Form 1099 reporting and backup withholding responsibility,  or FATCA reporting responsibility as a participating or registered deemed-compliant FFI,  for accounts held by specified U.S. persons..</param>
        /// <param name="qiOptOutOfForm1099ReportingCertification">Certifies that the Qualified Intermediary does not assume primary Form 1099 reporting  and backup withholding responsibility for the accounts associated with this form..</param>
        /// <param name="qiWithholdingRatePoolCertification">Certifies that the Qualified Intermediary meets the requirements for allocating payments  to a chapter 4 withholding rate pool of U.S. payees under Regulations section 1.6049-4(c)(4)(iii)..</param>
        /// <param name="qiIntermediaryOrFlowThroughEntityDocumentationCertification">Certifies that the Qualified Intermediary has obtained or will obtain documentation confirming the status of any intermediary  or flow-through entity as a participating FFI, registered deemed-compliant FFI,  or QI for U.S. payees in a chapter 4 withholding rate pool..</param>
        /// <param name="qualifiedDerivativesDealerCertification">Certifies that the Qualified Derivatives Dealer (QDD) is approved by the IRS and assumes primary withholding  and reporting responsibilities for payments related to potential section 871(m) transactions..</param>
        /// <param name="qddCorporation">Indicates QDD classification is Corporation..</param>
        /// <param name="qddPartnership">Indicates QDD classification is Partnership..</param>
        /// <param name="qddDisregardedEntity">Indicates QDD classification is Disregarded Entity..</param>
        /// <param name="nonqualifiedIntermediaryCertification">Certifies that the entity is not acting as a Qualified Intermediary  and is not acting for its own account for the accounts covered by this form..</param>
        /// <param name="nqiWithholdingStatementTransmissionCertification">Certifies that the nonqualified intermediary is submitting this form to transmit withholding certificates  and/or other required documentation along with a withholding statement..</param>
        /// <param name="nqiWithholdingRatePoolComplianceCertification">Certifies that the nonqualified intermediary meets the requirements of Regulations section 1.6049-4(c)(4)(iii)  for U.S. payees included in a withholding rate pool, excluding publicly traded partnership distributions..</param>
        /// <param name="nqiQualifiedSecuritiesLenderCertification">Certifies that the nonqualified intermediary is acting as a qualified securities lender (not as a QI)  and assumes primary withholding and reporting responsibilities for U.S. source substitute dividend payments..</param>
        /// <param name="nqiAlternativeWithholdingStatementVerificationCertification">Certifies that the nonqualified intermediary has verified, or will verify,  all information on alternative withholding statements for consistency with account data to determine the correct withholding rate,  as required under sections 1441 or 1471..</param>
        /// <param name="territoryFinancialInstitutionCertification">Certifies that the entity is a financial institution (other than an investment entity) that is incorporated  or organized under the laws of a possession of the United States..</param>
        /// <param name="tfiTreatedAsUsPersonCertification">Certifies that the territory financial institution agrees to be treated as a U.S. person  for chapters 3 and 4 purposes concerning reportable amounts and withholdable payments..</param>
        /// <param name="tfiWithholdingStatementTransmissionCertification">Certifies that the territory financial institution is transmitting withholding certificates or other required documentation  and has provided or will provide a withholding statement for reportable or withholdable payments..</param>
        /// <param name="tfiTreatedAsUsPersonForPtpSalesCertification">Certifies that the territory financial institution agrees to be treated as a U.S. person  under Regulations section 1.1446(f)-4(a)(2)(i)(B) for amounts realized from sales of publicly traded partnership interests..</param>
        /// <param name="tfiNomineeUsPersonForPtpDistributionsCertification">Certifies that the territory financial institution agrees to be treated as a U.S. person  and as a nominee for purposes of publicly traded partnership distributions under the applicable regulations..</param>
        /// <param name="tfiNotNomineeForPtpDistributionsCertification">Certifies that the territory financial institution is not acting as a nominee for publicly traded partnership distributions  and is providing withholding statements for those distributions..</param>
        /// <param name="usBranchNonEffectivelyConnectedIncomeCertification">Certifies that the U.S. branch is receiving reportable or withholdable payments  that are not effectively connected income, PTP distributions, or proceeds from PTP sales..</param>
        /// <param name="usBranchAgreementToBeTreatedAsUsPersonCertification">Certifies that the U.S. branch of a foreign bank or insurance company agrees to be treated as a U.S. person  for reportable amounts or withholdable payments under the applicable regulations..</param>
        /// <param name="usBranchWithholdingStatementAndComplianceCertification">Certifies that the U.S. branch is transmitting required documentation  and withholding statements for reportable or withholdable payments and is applying the appropriate FATCA regulations..</param>
        /// <param name="usBranchActingAsUsPersonForPtpSalesCertification">Certifies that the U.S. branch is acting as a U.S. person  for purposes of amounts realized from sales of publicly traded partnership interests under the applicable regulations..</param>
        /// <param name="usBranchNomineeForPtpDistributionsCertification">Certifies that the U.S. branch is treated as a U.S. person  and as a nominee for publicly traded partnership distributions under the applicable regulations..</param>
        /// <param name="usBranchNotNomineeForPtpDistributionsCertification">Certifies that the U.S. branch is not acting as a nominee for publicly traded partnership distributions  and is providing the required withholding statements..</param>
        /// <param name="withholdingForeignPartnershipOrTrustCertification">Certifies that the entity is a withholding foreign partnership (WP) or a withholding foreign trust (WT)  that is compliant with the terms of its WP or WT agreement..</param>
        /// <param name="nonwithholdingForeignEntityWithholdingStatementCertification">Certifies that the entity is a nonwithholding foreign partnership or trust,  providing the form for non-effectively connected payments and transmitting required withholding documentation for chapters 3 and 4..</param>
        /// <param name="foreignEntityPartnerInLowerTierPartnershipCertification">Certifies that the entity is a foreign partnership or grantor trust acting as a partner in a lower-tier partnership  and is submitting the form for purposes of section 1446(a)..</param>
        /// <param name="foreignPartnershipAmountRealizedSection1446FCertification">Certifies that the entity is a foreign partnership receiving an amount realized  from the transfer of a partnership interest for purposes of section 1446(f)..</param>
        /// <param name="foreignPartnershipModifiedAmountRealizedCertification">Certifies that the foreign partnership is providing a withholding statement for a modified amount realized  from the transfer of a partnership interest, when applicable..</param>
        /// <param name="foreignGrantorTrustAmountRealizedAllocationCertification">Certifies that the foreign grantor trust is submitting the form on behalf of each grantor or owner  and providing a withholding statement to allocate the amount realized in accordance with the regulations..</param>
        /// <param name="alternativeWithholdingStatementRelianceCertification">Certifies that the entity may rely on the information in all associated withholding certificates  under the applicable standards of knowledge in sections 1441 or 1471 when providing an alternative withholding statement..</param>
        /// <param name="npFfiWithExemptBeneficialOwnersCertification">Certifies that the nonparticipating FFI is transmitting withholding documentation  and providing a statement allocating payment portions to exempt beneficial owners..</param>
        /// <param name="ffiSponsoringEntity">The name of the entity that sponsors the foreign financial institution (FFI)..</param>
        /// <param name="investmentEntityCertification">Certifies that the entity is an investment entity, not a QI, WP, or WT, and has an agreement with a sponsoring entity..</param>
        /// <param name="controlledForeignCorporationCertification">Certifies that the entity is a controlled foreign corporation sponsored by a U.S. financial institution, not a QI, WP, or WT,  and shares a common electronic account system for full transparency..</param>
        /// <param name="ownerDocumentedFfiCertification">Certifies that the FFI meets all requirements to qualify as an owner-documented FFI, including restrictions on activities,  ownership, and account relationships..</param>
        /// <param name="ownerDocumentedFfiReportingStatementCertification">Certifies that the FFI will provide a complete owner reporting statement  and required documentation for each relevant owner or debt holder..</param>
        /// <param name="ownerDocumentedFfiAuditorLetterCertification">Certifies that the FFI has provided or will provide an auditor’s letter and required owner documentation,  including a reporting statement and Form W-9s, to meet owner-documented FFI requirements under the regulations..</param>
        /// <param name="compliantNonregisteringLocalBankCertification">Certifies that the FFI operates solely as a limited bank or credit union within its country, meets asset thresholds,  and has no foreign operations or affiliations outside its country of organization..</param>
        /// <param name="compliantFfiLowValueAccountsCertification">Certifies that the FFI is not primarily engaged in investment activities, maintains only low-value accounts,  and has limited total assets within its group..</param>
        /// <param name="sponsoredCloselyHeldEntitySponsoringEntity">The name of sponsoring entity for a certified deemed-compliant, closely held investment vehicle..</param>
        /// <param name="sponsoredCloselyHeldInvestmentVehicleCertification">Certifies that the entity is a sponsored investment entity with 20 or fewer individual owners,  and that all compliance obligations are fulfilled by the sponsoring entity..</param>
        /// <param name="compliantLimitedLifeDebtEntityCertification">Certifies that the entity qualifies as a limited life debt investment entity based on its formation date, issuance terms,  and compliance with regulatory requirements..</param>
        /// <param name="investmentEntityNoFinancialAccountsCertification">Certifies that the entity is a financial institution solely because it is an investment entity under regulations  and the entity does not maintain financial accounts..</param>
        /// <param name="restrictedDistributorCertification">Certifies that the entity qualifies as a restricted distributor based on its operations, customer base, regulatory compliance,  and financial and geographic limitations..</param>
        /// <param name="restrictedDistributorAgreementCertification">Certifies that the entity is, and has been, bound by distribution agreements prohibiting sales of fund interests to  specified U.S. persons and certain non-U.S. entities..</param>
        /// <param name="restrictedDistributorPreexistingSalesComplianceCertification">Certifies that the entity complies with distribution restrictions for U.S.-linked investors  and has addressed any preexisting sales in accordance with FATCA regulations..</param>
        /// <param name="foreignCentralBankOfIssueCertification">Certifies that the entity is treated as the beneficial owner of the payment solely  for purposes of chapter 4 under Regulations section 1.1471-6(d)(4)..</param>
        /// <param name="nonreportingIgaFfiCertification">Certifies that the entity meets the requirements to be considered a nonreporting financial institution to an applicable IGA..</param>
        /// <param name="igaCountry">The country for the applicable IGA with the United States..</param>
        /// <param name="igaModel">The applicable IGA model..</param>
        /// <param name="igaLegalStatusTreatment">Specifies how the applicable IGA is treated under the IGA provisions or Treasury regulations..</param>
        /// <param name="igaFfiTrusteeOrSponsor">The trustee or sponsor name for the nonreporting IGA FFI..</param>
        /// <param name="igaFfiTrusteeIsForeign">Indicates whether the trustee for the nonreporting IGA FFI is foreign..</param>
        /// <param name="treatyQualifiedPensionFundCertification">Certifies that the entity is a pension or retirement fund established in a treaty country  and is entitled to treaty benefits on U.S. source income..</param>
        /// <param name="qualifiedRetirementFundCertification">Certifies that the entity is a government-regulated retirement fund meeting specific requirements for contributions, tax exemption,  beneficiary limits, and distribution restrictions..</param>
        /// <param name="narrowParticipationRetirementFundCertification">Certifies that the entity is a government-regulated retirement fund with fewer than 50 participants, limited foreign ownership,  and employer sponsorship that is not from investment entities or passive NFFEs..</param>
        /// <param name="section401AEquivalentPensionPlanCertification">Certifies that the entity is formed under a pension plan meeting section 401(a) requirements, except for being U.S.-trust funded..</param>
        /// <param name="investmentEntityForRetirementFundsCertification">Certifies that the entity is established solely to earn income for the benefit of qualifying retirement funds  or accounts under applicable FATCA regulations or IGAs..</param>
        /// <param name="exemptBeneficialOwnerSponsoredRetirementFundCertification">Certifies that the entity is established and sponsored by a qualifying exempt beneficial owner to provide retirement, disability,  or death benefits to individuals based on services performed for the sponsor..</param>
        /// <param name="exceptedNonfinancialGroupEntityCertification">Certifies that the entity is a holding company, treasury center, or captive finance company operating within a nonfinancial group  and not functioning as an investment or financial institution..</param>
        /// <param name="exceptedNonfinancialStartUpCertification">Certifies that the entity is a recently formed startup NFFE investing in a non-financial business  and is not operating as or presenting itself as an investment fund..</param>
        /// <param name="startupFormationOrResolutionDate">The date the start-up company was formed on (or, in case of new line of business, the date of board resolution approving the  new line of business)..</param>
        /// <param name="exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification">Certifies that the entity is in liquidation, reorganization, or bankruptcy and intends to operate as a nonfinancial entity,  with supporting documentation available if the process exceeds three years..</param>
        /// <param name="nonfinancialEntityFilingDate">The filed date for a plan of reorganization, liquidation or bankruptcy..</param>
        /// <param name="publiclyTradedNffeCertification">Certifies that the entity is a foreign corporation that is not a financial institution  and whose stock is regularly traded on an established securities market..</param>
        /// <param name="publiclyTradedNffeSecuritiesMarket">The name of the securities market where the corporation&#39;s stock is regularly traded..</param>
        /// <param name="nffeAffiliateOfPubliclyTradedEntityCertification">Certifies that the entity is a foreign corporation that is not a financial institution  and is affiliated with a publicly traded entity within the same expanded affiliated group..</param>
        /// <param name="publiclyTradedEntity">The name of the affiliated entity whose stock is regularly traded on an established securities market..</param>
        /// <param name="nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket">The name of the established securities market where the affiliated entity&#39;s stock is traded..</param>
        /// <param name="exceptedTerritoryNffeCertification">Certifies that the entity is organized in a U.S. possession, is not engaged in financial activities,  and is entirely owned by bona fide residents of that possession..</param>
        /// <param name="activeNffeCertification">Certifies that the entity is a foreign non-financial institution with less than 50% passive income  and less than 50% of its assets producing or held to produce passive income..</param>
        /// <param name="passiveNffeCertification">Certifies that the entity is a foreign non-financial entity that does not qualify for any other NFFE category  and is not a financial institution..</param>
        /// <param name="sponsoredDirectReportingNffeCertification">Certifies that the entity is a sponsored direct reporting NFFE..</param>
        /// <param name="directReportingNffeSponsoringEntity">The name of the entity that sponsors the direct reporting NFFE..</param>
        /// <param name="signerName">The name of the signer..</param>
        /// <param name="id">The unique identifier for the form..</param>
        /// <param name="entryStatus">The entry status information for the form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="ancestorId">Form ID of previous version..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="type">The type of the response object. (default to &quot;W8ImyFormResponse&quot;).</param>
        public W8ImyFormResponse(string name = default(string), string citizenshipCountry = default(string), string disregardedEntity = default(string), string entityType = default(string), string fatcaStatus = default(string), string residenceAddress = default(string), string residenceCity = default(string), string residenceState = default(string), string residenceZip = default(string), string residenceCountry = default(string), bool residenceIsMailing = default(bool), string mailingAddress = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingZip = default(string), string mailingCountry = default(string), string tinType = default(string), string tin = default(string), string giin = default(string), string foreignTin = default(string), string referenceNumber = default(string), string disregardedEntityFatcaStatus = default(string), string disregardedAddress = default(string), string disregardedCity = default(string), string disregardedState = default(string), string disregardedZip = default(string), string disregardedCountry = default(string), string disregardedEntityGiin = default(string), bool qualifiedIntermediaryCertification = default(bool), bool qiPrimaryWithholdingResponsibilityCertification = default(bool), bool qiWithholdingResponsibilityForPtpSalesCertification = default(bool), bool qiNomineeWithholdingResponsibilityForPtpDistributionsCertification = default(bool), bool qiSecuritiesLenderSubstituteDividendWithholdingCertification = default(bool), bool qiWithholdingAnd1099ReportingResponsibilityCertification = default(bool), bool qiForm1099OrFatcaReportingResponsibilityCertification = default(bool), bool qiOptOutOfForm1099ReportingCertification = default(bool), bool qiWithholdingRatePoolCertification = default(bool), bool qiIntermediaryOrFlowThroughEntityDocumentationCertification = default(bool), bool qualifiedDerivativesDealerCertification = default(bool), bool qddCorporation = default(bool), bool qddPartnership = default(bool), bool qddDisregardedEntity = default(bool), bool nonqualifiedIntermediaryCertification = default(bool), bool nqiWithholdingStatementTransmissionCertification = default(bool), bool nqiWithholdingRatePoolComplianceCertification = default(bool), bool nqiQualifiedSecuritiesLenderCertification = default(bool), bool nqiAlternativeWithholdingStatementVerificationCertification = default(bool), bool territoryFinancialInstitutionCertification = default(bool), bool tfiTreatedAsUsPersonCertification = default(bool), bool tfiWithholdingStatementTransmissionCertification = default(bool), bool tfiTreatedAsUsPersonForPtpSalesCertification = default(bool), bool tfiNomineeUsPersonForPtpDistributionsCertification = default(bool), bool tfiNotNomineeForPtpDistributionsCertification = default(bool), bool usBranchNonEffectivelyConnectedIncomeCertification = default(bool), bool usBranchAgreementToBeTreatedAsUsPersonCertification = default(bool), bool usBranchWithholdingStatementAndComplianceCertification = default(bool), bool usBranchActingAsUsPersonForPtpSalesCertification = default(bool), bool usBranchNomineeForPtpDistributionsCertification = default(bool), bool usBranchNotNomineeForPtpDistributionsCertification = default(bool), bool withholdingForeignPartnershipOrTrustCertification = default(bool), bool nonwithholdingForeignEntityWithholdingStatementCertification = default(bool), bool foreignEntityPartnerInLowerTierPartnershipCertification = default(bool), bool foreignPartnershipAmountRealizedSection1446FCertification = default(bool), bool foreignPartnershipModifiedAmountRealizedCertification = default(bool), bool foreignGrantorTrustAmountRealizedAllocationCertification = default(bool), bool alternativeWithholdingStatementRelianceCertification = default(bool), bool npFfiWithExemptBeneficialOwnersCertification = default(bool), string ffiSponsoringEntity = default(string), bool investmentEntityCertification = default(bool), bool controlledForeignCorporationCertification = default(bool), bool ownerDocumentedFfiCertification = default(bool), bool ownerDocumentedFfiReportingStatementCertification = default(bool), bool ownerDocumentedFfiAuditorLetterCertification = default(bool), bool compliantNonregisteringLocalBankCertification = default(bool), bool compliantFfiLowValueAccountsCertification = default(bool), string sponsoredCloselyHeldEntitySponsoringEntity = default(string), bool sponsoredCloselyHeldInvestmentVehicleCertification = default(bool), bool compliantLimitedLifeDebtEntityCertification = default(bool), bool investmentEntityNoFinancialAccountsCertification = default(bool), bool restrictedDistributorCertification = default(bool), bool restrictedDistributorAgreementCertification = default(bool), bool restrictedDistributorPreexistingSalesComplianceCertification = default(bool), bool foreignCentralBankOfIssueCertification = default(bool), bool nonreportingIgaFfiCertification = default(bool), string igaCountry = default(string), string igaModel = default(string), string igaLegalStatusTreatment = default(string), string igaFfiTrusteeOrSponsor = default(string), bool? igaFfiTrusteeIsForeign = default(bool?), bool treatyQualifiedPensionFundCertification = default(bool), bool qualifiedRetirementFundCertification = default(bool), bool narrowParticipationRetirementFundCertification = default(bool), bool section401AEquivalentPensionPlanCertification = default(bool), bool investmentEntityForRetirementFundsCertification = default(bool), bool exemptBeneficialOwnerSponsoredRetirementFundCertification = default(bool), bool exceptedNonfinancialGroupEntityCertification = default(bool), bool exceptedNonfinancialStartUpCertification = default(bool), DateTime? startupFormationOrResolutionDate = default(DateTime?), bool exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification = default(bool), DateTime? nonfinancialEntityFilingDate = default(DateTime?), bool publiclyTradedNffeCertification = default(bool), string publiclyTradedNffeSecuritiesMarket = default(string), bool nffeAffiliateOfPubliclyTradedEntityCertification = default(bool), string publiclyTradedEntity = default(string), string nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket = default(string), bool exceptedTerritoryNffeCertification = default(bool), bool activeNffeCertification = default(bool), bool passiveNffeCertification = default(bool), bool sponsoredDirectReportingNffeCertification = default(bool), string directReportingNffeSponsoringEntity = default(string), string signerName = default(string), string id = default(string), EntryStatusResponse entryStatus = default(EntryStatusResponse), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool archived = default(bool), string ancestorId = default(string), string signature = default(string), DateTime? signedDate = default(DateTime?), DateTime? eDeliveryConsentedAt = default(DateTime?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string type = @"W8ImyFormResponse") : base(id, entryStatus, referenceId, companyId, displayName, email, archived, ancestorId, signature, signedDate, eDeliveryConsentedAt, createdAt, updatedAt, type)
        {
            this.Name = name;
            this.CitizenshipCountry = citizenshipCountry;
            this.DisregardedEntity = disregardedEntity;
            this.EntityType = entityType;
            this.FatcaStatus = fatcaStatus;
            this.ResidenceAddress = residenceAddress;
            this.ResidenceCity = residenceCity;
            this.ResidenceState = residenceState;
            this.ResidenceZip = residenceZip;
            this.ResidenceCountry = residenceCountry;
            this.ResidenceIsMailing = residenceIsMailing;
            this.MailingAddress = mailingAddress;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingZip = mailingZip;
            this.MailingCountry = mailingCountry;
            this.TinType = tinType;
            this.Tin = tin;
            this.Giin = giin;
            this.ForeignTin = foreignTin;
            this.ReferenceNumber = referenceNumber;
            this.DisregardedEntityFatcaStatus = disregardedEntityFatcaStatus;
            this.DisregardedAddress = disregardedAddress;
            this.DisregardedCity = disregardedCity;
            this.DisregardedState = disregardedState;
            this.DisregardedZip = disregardedZip;
            this.DisregardedCountry = disregardedCountry;
            this.DisregardedEntityGiin = disregardedEntityGiin;
            this.QualifiedIntermediaryCertification = qualifiedIntermediaryCertification;
            this.QiPrimaryWithholdingResponsibilityCertification = qiPrimaryWithholdingResponsibilityCertification;
            this.QiWithholdingResponsibilityForPtpSalesCertification = qiWithholdingResponsibilityForPtpSalesCertification;
            this.QiNomineeWithholdingResponsibilityForPtpDistributionsCertification = qiNomineeWithholdingResponsibilityForPtpDistributionsCertification;
            this.QiSecuritiesLenderSubstituteDividendWithholdingCertification = qiSecuritiesLenderSubstituteDividendWithholdingCertification;
            this.QiWithholdingAnd1099ReportingResponsibilityCertification = qiWithholdingAnd1099ReportingResponsibilityCertification;
            this.QiForm1099OrFatcaReportingResponsibilityCertification = qiForm1099OrFatcaReportingResponsibilityCertification;
            this.QiOptOutOfForm1099ReportingCertification = qiOptOutOfForm1099ReportingCertification;
            this.QiWithholdingRatePoolCertification = qiWithholdingRatePoolCertification;
            this.QiIntermediaryOrFlowThroughEntityDocumentationCertification = qiIntermediaryOrFlowThroughEntityDocumentationCertification;
            this.QualifiedDerivativesDealerCertification = qualifiedDerivativesDealerCertification;
            this.QddCorporation = qddCorporation;
            this.QddPartnership = qddPartnership;
            this.QddDisregardedEntity = qddDisregardedEntity;
            this.NonqualifiedIntermediaryCertification = nonqualifiedIntermediaryCertification;
            this.NqiWithholdingStatementTransmissionCertification = nqiWithholdingStatementTransmissionCertification;
            this.NqiWithholdingRatePoolComplianceCertification = nqiWithholdingRatePoolComplianceCertification;
            this.NqiQualifiedSecuritiesLenderCertification = nqiQualifiedSecuritiesLenderCertification;
            this.NqiAlternativeWithholdingStatementVerificationCertification = nqiAlternativeWithholdingStatementVerificationCertification;
            this.TerritoryFinancialInstitutionCertification = territoryFinancialInstitutionCertification;
            this.TfiTreatedAsUsPersonCertification = tfiTreatedAsUsPersonCertification;
            this.TfiWithholdingStatementTransmissionCertification = tfiWithholdingStatementTransmissionCertification;
            this.TfiTreatedAsUsPersonForPtpSalesCertification = tfiTreatedAsUsPersonForPtpSalesCertification;
            this.TfiNomineeUsPersonForPtpDistributionsCertification = tfiNomineeUsPersonForPtpDistributionsCertification;
            this.TfiNotNomineeForPtpDistributionsCertification = tfiNotNomineeForPtpDistributionsCertification;
            this.UsBranchNonEffectivelyConnectedIncomeCertification = usBranchNonEffectivelyConnectedIncomeCertification;
            this.UsBranchAgreementToBeTreatedAsUsPersonCertification = usBranchAgreementToBeTreatedAsUsPersonCertification;
            this.UsBranchWithholdingStatementAndComplianceCertification = usBranchWithholdingStatementAndComplianceCertification;
            this.UsBranchActingAsUsPersonForPtpSalesCertification = usBranchActingAsUsPersonForPtpSalesCertification;
            this.UsBranchNomineeForPtpDistributionsCertification = usBranchNomineeForPtpDistributionsCertification;
            this.UsBranchNotNomineeForPtpDistributionsCertification = usBranchNotNomineeForPtpDistributionsCertification;
            this.WithholdingForeignPartnershipOrTrustCertification = withholdingForeignPartnershipOrTrustCertification;
            this.NonwithholdingForeignEntityWithholdingStatementCertification = nonwithholdingForeignEntityWithholdingStatementCertification;
            this.ForeignEntityPartnerInLowerTierPartnershipCertification = foreignEntityPartnerInLowerTierPartnershipCertification;
            this.ForeignPartnershipAmountRealizedSection1446FCertification = foreignPartnershipAmountRealizedSection1446FCertification;
            this.ForeignPartnershipModifiedAmountRealizedCertification = foreignPartnershipModifiedAmountRealizedCertification;
            this.ForeignGrantorTrustAmountRealizedAllocationCertification = foreignGrantorTrustAmountRealizedAllocationCertification;
            this.AlternativeWithholdingStatementRelianceCertification = alternativeWithholdingStatementRelianceCertification;
            this.NpFfiWithExemptBeneficialOwnersCertification = npFfiWithExemptBeneficialOwnersCertification;
            this.FfiSponsoringEntity = ffiSponsoringEntity;
            this.InvestmentEntityCertification = investmentEntityCertification;
            this.ControlledForeignCorporationCertification = controlledForeignCorporationCertification;
            this.OwnerDocumentedFfiCertification = ownerDocumentedFfiCertification;
            this.OwnerDocumentedFfiReportingStatementCertification = ownerDocumentedFfiReportingStatementCertification;
            this.OwnerDocumentedFfiAuditorLetterCertification = ownerDocumentedFfiAuditorLetterCertification;
            this.CompliantNonregisteringLocalBankCertification = compliantNonregisteringLocalBankCertification;
            this.CompliantFfiLowValueAccountsCertification = compliantFfiLowValueAccountsCertification;
            this.SponsoredCloselyHeldEntitySponsoringEntity = sponsoredCloselyHeldEntitySponsoringEntity;
            this.SponsoredCloselyHeldInvestmentVehicleCertification = sponsoredCloselyHeldInvestmentVehicleCertification;
            this.CompliantLimitedLifeDebtEntityCertification = compliantLimitedLifeDebtEntityCertification;
            this.InvestmentEntityNoFinancialAccountsCertification = investmentEntityNoFinancialAccountsCertification;
            this.RestrictedDistributorCertification = restrictedDistributorCertification;
            this.RestrictedDistributorAgreementCertification = restrictedDistributorAgreementCertification;
            this.RestrictedDistributorPreexistingSalesComplianceCertification = restrictedDistributorPreexistingSalesComplianceCertification;
            this.ForeignCentralBankOfIssueCertification = foreignCentralBankOfIssueCertification;
            this.NonreportingIgaFfiCertification = nonreportingIgaFfiCertification;
            this.IgaCountry = igaCountry;
            this.IgaModel = igaModel;
            this.IgaLegalStatusTreatment = igaLegalStatusTreatment;
            this.IgaFfiTrusteeOrSponsor = igaFfiTrusteeOrSponsor;
            this.IgaFfiTrusteeIsForeign = igaFfiTrusteeIsForeign;
            this.TreatyQualifiedPensionFundCertification = treatyQualifiedPensionFundCertification;
            this.QualifiedRetirementFundCertification = qualifiedRetirementFundCertification;
            this.NarrowParticipationRetirementFundCertification = narrowParticipationRetirementFundCertification;
            this.Section401AEquivalentPensionPlanCertification = section401AEquivalentPensionPlanCertification;
            this.InvestmentEntityForRetirementFundsCertification = investmentEntityForRetirementFundsCertification;
            this.ExemptBeneficialOwnerSponsoredRetirementFundCertification = exemptBeneficialOwnerSponsoredRetirementFundCertification;
            this.ExceptedNonfinancialGroupEntityCertification = exceptedNonfinancialGroupEntityCertification;
            this.ExceptedNonfinancialStartUpCertification = exceptedNonfinancialStartUpCertification;
            this.StartupFormationOrResolutionDate = startupFormationOrResolutionDate;
            this.ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification = exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification;
            this.NonfinancialEntityFilingDate = nonfinancialEntityFilingDate;
            this.PubliclyTradedNffeCertification = publiclyTradedNffeCertification;
            this.PubliclyTradedNffeSecuritiesMarket = publiclyTradedNffeSecuritiesMarket;
            this.NffeAffiliateOfPubliclyTradedEntityCertification = nffeAffiliateOfPubliclyTradedEntityCertification;
            this.PubliclyTradedEntity = publiclyTradedEntity;
            this.NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket = nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket;
            this.ExceptedTerritoryNffeCertification = exceptedTerritoryNffeCertification;
            this.ActiveNffeCertification = activeNffeCertification;
            this.PassiveNffeCertification = passiveNffeCertification;
            this.SponsoredDirectReportingNffeCertification = sponsoredDirectReportingNffeCertification;
            this.DirectReportingNffeSponsoringEntity = directReportingNffeSponsoringEntity;
            this.SignerName = signerName;
        }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>Global Financials LLC</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The country of citizenship.
        /// </summary>
        /// <value>The country of citizenship.</value>
        /// <example>USA</example>
        [DataMember(Name = "citizenshipCountry", EmitDefaultValue = false)]
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// The name of the disregarded entity receiving the payment (if applicable).
        /// </summary>
        /// <value>The name of the disregarded entity receiving the payment (if applicable).</value>
        [DataMember(Name = "disregardedEntity", EmitDefaultValue = true)]
        public string DisregardedEntity { get; set; }

        /// <summary>
        /// The entity type.
        /// </summary>
        /// <value>The entity type.</value>
        /// <example>Partnership</example>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The FATCA status.
        /// </summary>
        /// <value>The FATCA status.</value>
        /// <example>Compliant</example>
        [DataMember(Name = "fatcaStatus", EmitDefaultValue = false)]
        public string FatcaStatus { get; set; }

        /// <summary>
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        /// <example>321 Wealth Ave</example>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = false)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        /// <example>Finance City</example>
        [DataMember(Name = "residenceCity", EmitDefaultValue = false)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The state of residence.
        /// </summary>
        /// <value>The state of residence.</value>
        /// <example>TX</example>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// The ZIP code of the residence.
        /// </summary>
        /// <value>The ZIP code of the residence.</value>
        /// <example>75001</example>
        [DataMember(Name = "residenceZip", EmitDefaultValue = false)]
        public string ResidenceZip { get; set; }

        /// <summary>
        /// The country of residence.
        /// </summary>
        /// <value>The country of residence.</value>
        /// <example>USA</example>
        [DataMember(Name = "residenceCountry", EmitDefaultValue = false)]
        public string ResidenceCountry { get; set; }

        /// <summary>
        /// Indicates whether the residence address is also the mailing address.
        /// </summary>
        /// <value>Indicates whether the residence address is also the mailing address.</value>
        /// <example>false</example>
        [DataMember(Name = "residenceIsMailing", EmitDefaultValue = true)]
        public bool ResidenceIsMailing { get; set; }

        /// <summary>
        /// The mailing address.
        /// </summary>
        /// <value>The mailing address.</value>
        /// <example>P.O. Box 789</example>
        [DataMember(Name = "mailingAddress", EmitDefaultValue = true)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// The city of the mailing address.
        /// </summary>
        /// <value>The city of the mailing address.</value>
        /// <example>Finance City</example>
        [DataMember(Name = "mailingCity", EmitDefaultValue = true)]
        public string MailingCity { get; set; }

        /// <summary>
        /// The state of the mailing address.
        /// </summary>
        /// <value>The state of the mailing address.</value>
        /// <example>TX</example>
        [DataMember(Name = "mailingState", EmitDefaultValue = true)]
        public string MailingState { get; set; }

        /// <summary>
        /// The ZIP code of the mailing address.
        /// </summary>
        /// <value>The ZIP code of the mailing address.</value>
        /// <example>75002</example>
        [DataMember(Name = "mailingZip", EmitDefaultValue = true)]
        public string MailingZip { get; set; }

        /// <summary>
        /// The country of the mailing address.
        /// </summary>
        /// <value>The country of the mailing address.</value>
        /// <example>USA</example>
        [DataMember(Name = "mailingCountry", EmitDefaultValue = true)]
        public string MailingCountry { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        /// <example>EIN</example>
        [DataMember(Name = "tinType", EmitDefaultValue = true)]
        public string TinType { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        /// <example>123-45-6789</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The global intermediary identification number (GIIN).
        /// </summary>
        /// <value>The global intermediary identification number (GIIN).</value>
        /// <example>GIIN12345678</example>
        [DataMember(Name = "giin", EmitDefaultValue = true)]
        public string Giin { get; set; }

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
        /// <example>W8IMY56789</example>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The FATCA status of disregarded entity or branch receiving payment.
        /// </summary>
        /// <value>The FATCA status of disregarded entity or branch receiving payment.</value>
        [DataMember(Name = "disregardedEntityFatcaStatus", EmitDefaultValue = true)]
        public string DisregardedEntityFatcaStatus { get; set; }

        /// <summary>
        /// The address for disregarded entities.
        /// </summary>
        /// <value>The address for disregarded entities.</value>
        [DataMember(Name = "disregardedAddress", EmitDefaultValue = true)]
        public string DisregardedAddress { get; set; }

        /// <summary>
        /// The city for disregarded entities.
        /// </summary>
        /// <value>The city for disregarded entities.</value>
        [DataMember(Name = "disregardedCity", EmitDefaultValue = true)]
        public string DisregardedCity { get; set; }

        /// <summary>
        /// The state for disregarded entities.
        /// </summary>
        /// <value>The state for disregarded entities.</value>
        [DataMember(Name = "disregardedState", EmitDefaultValue = true)]
        public string DisregardedState { get; set; }

        /// <summary>
        /// The ZIP code for disregarded entities.
        /// </summary>
        /// <value>The ZIP code for disregarded entities.</value>
        [DataMember(Name = "disregardedZip", EmitDefaultValue = true)]
        public string DisregardedZip { get; set; }

        /// <summary>
        /// The country for disregarded entities.
        /// </summary>
        /// <value>The country for disregarded entities.</value>
        [DataMember(Name = "disregardedCountry", EmitDefaultValue = true)]
        public string DisregardedCountry { get; set; }

        /// <summary>
        /// The GIIN for disregarded entities.
        /// </summary>
        /// <value>The GIIN for disregarded entities.</value>
        [DataMember(Name = "disregardedEntityGiin", EmitDefaultValue = true)]
        public string DisregardedEntityGiin { get; set; }

        /// <summary>
        /// Certifies that the entity is a Qualified Intermediary (QI) acting in accordance with its QI Agreement,  providing required withholding statements and documentation for relevant tax withholding purposes.
        /// </summary>
        /// <value>Certifies that the entity is a Qualified Intermediary (QI) acting in accordance with its QI Agreement,  providing required withholding statements and documentation for relevant tax withholding purposes.</value>
        /// <example>false</example>
        [DataMember(Name = "qualifiedIntermediaryCertification", EmitDefaultValue = true)]
        public bool QualifiedIntermediaryCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary assumes primary withholding responsibility  under chapters 3 and 4 for the specified accounts.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary assumes primary withholding responsibility  under chapters 3 and 4 for the specified accounts.</value>
        /// <example>false</example>
        [DataMember(Name = "qiPrimaryWithholdingResponsibilityCertification", EmitDefaultValue = true)]
        public bool QiPrimaryWithholdingResponsibilityCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary assumes primary withholding and reporting responsibility under section 1446(f)  for amounts realized from sales of interests in publicly traded partnerships.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary assumes primary withholding and reporting responsibility under section 1446(f)  for amounts realized from sales of interests in publicly traded partnerships.</value>
        /// <example>false</example>
        [DataMember(Name = "qiWithholdingResponsibilityForPtpSalesCertification", EmitDefaultValue = true)]
        public bool QiWithholdingResponsibilityForPtpSalesCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary assumes primary withholding responsibility as a nominee  under Regulations section 1.1446-4(b)(3) for publicly traded partnership distributions.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary assumes primary withholding responsibility as a nominee  under Regulations section 1.1446-4(b)(3) for publicly traded partnership distributions.</value>
        /// <example>false</example>
        [DataMember(Name = "qiNomineeWithholdingResponsibilityForPtpDistributionsCertification", EmitDefaultValue = true)]
        public bool QiNomineeWithholdingResponsibilityForPtpDistributionsCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary is acting as a qualified securities lender and assumes primary withholding  and reporting responsibilities for U.S. source substitute dividend payments.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary is acting as a qualified securities lender and assumes primary withholding  and reporting responsibilities for U.S. source substitute dividend payments.</value>
        /// <example>false</example>
        [DataMember(Name = "qiSecuritiesLenderSubstituteDividendWithholdingCertification", EmitDefaultValue = true)]
        public bool QiSecuritiesLenderSubstituteDividendWithholdingCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary assumes primary withholding under chapters 3 and 4, and primary Form 1099 reporting  and backup withholding responsibility for U.S. source interest and substitute interest payments.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary assumes primary withholding under chapters 3 and 4, and primary Form 1099 reporting  and backup withholding responsibility for U.S. source interest and substitute interest payments.</value>
        /// <example>false</example>
        [DataMember(Name = "qiWithholdingAnd1099ReportingResponsibilityCertification", EmitDefaultValue = true)]
        public bool QiWithholdingAnd1099ReportingResponsibilityCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary assumes Form 1099 reporting and backup withholding responsibility,  or FATCA reporting responsibility as a participating or registered deemed-compliant FFI,  for accounts held by specified U.S. persons.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary assumes Form 1099 reporting and backup withholding responsibility,  or FATCA reporting responsibility as a participating or registered deemed-compliant FFI,  for accounts held by specified U.S. persons.</value>
        /// <example>false</example>
        [DataMember(Name = "qiForm1099OrFatcaReportingResponsibilityCertification", EmitDefaultValue = true)]
        public bool QiForm1099OrFatcaReportingResponsibilityCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary does not assume primary Form 1099 reporting  and backup withholding responsibility for the accounts associated with this form.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary does not assume primary Form 1099 reporting  and backup withholding responsibility for the accounts associated with this form.</value>
        /// <example>false</example>
        [DataMember(Name = "qiOptOutOfForm1099ReportingCertification", EmitDefaultValue = true)]
        public bool QiOptOutOfForm1099ReportingCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary meets the requirements for allocating payments  to a chapter 4 withholding rate pool of U.S. payees under Regulations section 1.6049-4(c)(4)(iii).
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary meets the requirements for allocating payments  to a chapter 4 withholding rate pool of U.S. payees under Regulations section 1.6049-4(c)(4)(iii).</value>
        /// <example>false</example>
        [DataMember(Name = "qiWithholdingRatePoolCertification", EmitDefaultValue = true)]
        public bool QiWithholdingRatePoolCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Intermediary has obtained or will obtain documentation confirming the status of any intermediary  or flow-through entity as a participating FFI, registered deemed-compliant FFI,  or QI for U.S. payees in a chapter 4 withholding rate pool.
        /// </summary>
        /// <value>Certifies that the Qualified Intermediary has obtained or will obtain documentation confirming the status of any intermediary  or flow-through entity as a participating FFI, registered deemed-compliant FFI,  or QI for U.S. payees in a chapter 4 withholding rate pool.</value>
        /// <example>false</example>
        [DataMember(Name = "qiIntermediaryOrFlowThroughEntityDocumentationCertification", EmitDefaultValue = true)]
        public bool QiIntermediaryOrFlowThroughEntityDocumentationCertification { get; set; }

        /// <summary>
        /// Certifies that the Qualified Derivatives Dealer (QDD) is approved by the IRS and assumes primary withholding  and reporting responsibilities for payments related to potential section 871(m) transactions.
        /// </summary>
        /// <value>Certifies that the Qualified Derivatives Dealer (QDD) is approved by the IRS and assumes primary withholding  and reporting responsibilities for payments related to potential section 871(m) transactions.</value>
        /// <example>false</example>
        [DataMember(Name = "qualifiedDerivativesDealerCertification", EmitDefaultValue = true)]
        public bool QualifiedDerivativesDealerCertification { get; set; }

        /// <summary>
        /// Indicates QDD classification is Corporation.
        /// </summary>
        /// <value>Indicates QDD classification is Corporation.</value>
        /// <example>false</example>
        [DataMember(Name = "qddCorporation", EmitDefaultValue = true)]
        public bool QddCorporation { get; set; }

        /// <summary>
        /// Indicates QDD classification is Partnership.
        /// </summary>
        /// <value>Indicates QDD classification is Partnership.</value>
        /// <example>false</example>
        [DataMember(Name = "qddPartnership", EmitDefaultValue = true)]
        public bool QddPartnership { get; set; }

        /// <summary>
        /// Indicates QDD classification is Disregarded Entity.
        /// </summary>
        /// <value>Indicates QDD classification is Disregarded Entity.</value>
        /// <example>false</example>
        [DataMember(Name = "qddDisregardedEntity", EmitDefaultValue = true)]
        public bool QddDisregardedEntity { get; set; }

        /// <summary>
        /// Certifies that the entity is not acting as a Qualified Intermediary  and is not acting for its own account for the accounts covered by this form.
        /// </summary>
        /// <value>Certifies that the entity is not acting as a Qualified Intermediary  and is not acting for its own account for the accounts covered by this form.</value>
        /// <example>false</example>
        [DataMember(Name = "nonqualifiedIntermediaryCertification", EmitDefaultValue = true)]
        public bool NonqualifiedIntermediaryCertification { get; set; }

        /// <summary>
        /// Certifies that the nonqualified intermediary is submitting this form to transmit withholding certificates  and/or other required documentation along with a withholding statement.
        /// </summary>
        /// <value>Certifies that the nonqualified intermediary is submitting this form to transmit withholding certificates  and/or other required documentation along with a withholding statement.</value>
        /// <example>false</example>
        [DataMember(Name = "nqiWithholdingStatementTransmissionCertification", EmitDefaultValue = true)]
        public bool NqiWithholdingStatementTransmissionCertification { get; set; }

        /// <summary>
        /// Certifies that the nonqualified intermediary meets the requirements of Regulations section 1.6049-4(c)(4)(iii)  for U.S. payees included in a withholding rate pool, excluding publicly traded partnership distributions.
        /// </summary>
        /// <value>Certifies that the nonqualified intermediary meets the requirements of Regulations section 1.6049-4(c)(4)(iii)  for U.S. payees included in a withholding rate pool, excluding publicly traded partnership distributions.</value>
        /// <example>false</example>
        [DataMember(Name = "nqiWithholdingRatePoolComplianceCertification", EmitDefaultValue = true)]
        public bool NqiWithholdingRatePoolComplianceCertification { get; set; }

        /// <summary>
        /// Certifies that the nonqualified intermediary is acting as a qualified securities lender (not as a QI)  and assumes primary withholding and reporting responsibilities for U.S. source substitute dividend payments.
        /// </summary>
        /// <value>Certifies that the nonqualified intermediary is acting as a qualified securities lender (not as a QI)  and assumes primary withholding and reporting responsibilities for U.S. source substitute dividend payments.</value>
        /// <example>false</example>
        [DataMember(Name = "nqiQualifiedSecuritiesLenderCertification", EmitDefaultValue = true)]
        public bool NqiQualifiedSecuritiesLenderCertification { get; set; }

        /// <summary>
        /// Certifies that the nonqualified intermediary has verified, or will verify,  all information on alternative withholding statements for consistency with account data to determine the correct withholding rate,  as required under sections 1441 or 1471.
        /// </summary>
        /// <value>Certifies that the nonqualified intermediary has verified, or will verify,  all information on alternative withholding statements for consistency with account data to determine the correct withholding rate,  as required under sections 1441 or 1471.</value>
        /// <example>false</example>
        [DataMember(Name = "nqiAlternativeWithholdingStatementVerificationCertification", EmitDefaultValue = true)]
        public bool NqiAlternativeWithholdingStatementVerificationCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a financial institution (other than an investment entity) that is incorporated  or organized under the laws of a possession of the United States.
        /// </summary>
        /// <value>Certifies that the entity is a financial institution (other than an investment entity) that is incorporated  or organized under the laws of a possession of the United States.</value>
        /// <example>false</example>
        [DataMember(Name = "territoryFinancialInstitutionCertification", EmitDefaultValue = true)]
        public bool TerritoryFinancialInstitutionCertification { get; set; }

        /// <summary>
        /// Certifies that the territory financial institution agrees to be treated as a U.S. person  for chapters 3 and 4 purposes concerning reportable amounts and withholdable payments.
        /// </summary>
        /// <value>Certifies that the territory financial institution agrees to be treated as a U.S. person  for chapters 3 and 4 purposes concerning reportable amounts and withholdable payments.</value>
        /// <example>false</example>
        [DataMember(Name = "tfiTreatedAsUsPersonCertification", EmitDefaultValue = true)]
        public bool TfiTreatedAsUsPersonCertification { get; set; }

        /// <summary>
        /// Certifies that the territory financial institution is transmitting withholding certificates or other required documentation  and has provided or will provide a withholding statement for reportable or withholdable payments.
        /// </summary>
        /// <value>Certifies that the territory financial institution is transmitting withholding certificates or other required documentation  and has provided or will provide a withholding statement for reportable or withholdable payments.</value>
        /// <example>false</example>
        [DataMember(Name = "tfiWithholdingStatementTransmissionCertification", EmitDefaultValue = true)]
        public bool TfiWithholdingStatementTransmissionCertification { get; set; }

        /// <summary>
        /// Certifies that the territory financial institution agrees to be treated as a U.S. person  under Regulations section 1.1446(f)-4(a)(2)(i)(B) for amounts realized from sales of publicly traded partnership interests.
        /// </summary>
        /// <value>Certifies that the territory financial institution agrees to be treated as a U.S. person  under Regulations section 1.1446(f)-4(a)(2)(i)(B) for amounts realized from sales of publicly traded partnership interests.</value>
        /// <example>false</example>
        [DataMember(Name = "tfiTreatedAsUsPersonForPtpSalesCertification", EmitDefaultValue = true)]
        public bool TfiTreatedAsUsPersonForPtpSalesCertification { get; set; }

        /// <summary>
        /// Certifies that the territory financial institution agrees to be treated as a U.S. person  and as a nominee for purposes of publicly traded partnership distributions under the applicable regulations.
        /// </summary>
        /// <value>Certifies that the territory financial institution agrees to be treated as a U.S. person  and as a nominee for purposes of publicly traded partnership distributions under the applicable regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "tfiNomineeUsPersonForPtpDistributionsCertification", EmitDefaultValue = true)]
        public bool TfiNomineeUsPersonForPtpDistributionsCertification { get; set; }

        /// <summary>
        /// Certifies that the territory financial institution is not acting as a nominee for publicly traded partnership distributions  and is providing withholding statements for those distributions.
        /// </summary>
        /// <value>Certifies that the territory financial institution is not acting as a nominee for publicly traded partnership distributions  and is providing withholding statements for those distributions.</value>
        /// <example>false</example>
        [DataMember(Name = "tfiNotNomineeForPtpDistributionsCertification", EmitDefaultValue = true)]
        public bool TfiNotNomineeForPtpDistributionsCertification { get; set; }

        /// <summary>
        /// Certifies that the U.S. branch is receiving reportable or withholdable payments  that are not effectively connected income, PTP distributions, or proceeds from PTP sales.
        /// </summary>
        /// <value>Certifies that the U.S. branch is receiving reportable or withholdable payments  that are not effectively connected income, PTP distributions, or proceeds from PTP sales.</value>
        /// <example>false</example>
        [DataMember(Name = "usBranchNonEffectivelyConnectedIncomeCertification", EmitDefaultValue = true)]
        public bool UsBranchNonEffectivelyConnectedIncomeCertification { get; set; }

        /// <summary>
        /// Certifies that the U.S. branch of a foreign bank or insurance company agrees to be treated as a U.S. person  for reportable amounts or withholdable payments under the applicable regulations.
        /// </summary>
        /// <value>Certifies that the U.S. branch of a foreign bank or insurance company agrees to be treated as a U.S. person  for reportable amounts or withholdable payments under the applicable regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "usBranchAgreementToBeTreatedAsUsPersonCertification", EmitDefaultValue = true)]
        public bool UsBranchAgreementToBeTreatedAsUsPersonCertification { get; set; }

        /// <summary>
        /// Certifies that the U.S. branch is transmitting required documentation  and withholding statements for reportable or withholdable payments and is applying the appropriate FATCA regulations.
        /// </summary>
        /// <value>Certifies that the U.S. branch is transmitting required documentation  and withholding statements for reportable or withholdable payments and is applying the appropriate FATCA regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "usBranchWithholdingStatementAndComplianceCertification", EmitDefaultValue = true)]
        public bool UsBranchWithholdingStatementAndComplianceCertification { get; set; }

        /// <summary>
        /// Certifies that the U.S. branch is acting as a U.S. person  for purposes of amounts realized from sales of publicly traded partnership interests under the applicable regulations.
        /// </summary>
        /// <value>Certifies that the U.S. branch is acting as a U.S. person  for purposes of amounts realized from sales of publicly traded partnership interests under the applicable regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "usBranchActingAsUsPersonForPtpSalesCertification", EmitDefaultValue = true)]
        public bool UsBranchActingAsUsPersonForPtpSalesCertification { get; set; }

        /// <summary>
        /// Certifies that the U.S. branch is treated as a U.S. person  and as a nominee for publicly traded partnership distributions under the applicable regulations.
        /// </summary>
        /// <value>Certifies that the U.S. branch is treated as a U.S. person  and as a nominee for publicly traded partnership distributions under the applicable regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "usBranchNomineeForPtpDistributionsCertification", EmitDefaultValue = true)]
        public bool UsBranchNomineeForPtpDistributionsCertification { get; set; }

        /// <summary>
        /// Certifies that the U.S. branch is not acting as a nominee for publicly traded partnership distributions  and is providing the required withholding statements.
        /// </summary>
        /// <value>Certifies that the U.S. branch is not acting as a nominee for publicly traded partnership distributions  and is providing the required withholding statements.</value>
        /// <example>false</example>
        [DataMember(Name = "usBranchNotNomineeForPtpDistributionsCertification", EmitDefaultValue = true)]
        public bool UsBranchNotNomineeForPtpDistributionsCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a withholding foreign partnership (WP) or a withholding foreign trust (WT)  that is compliant with the terms of its WP or WT agreement.
        /// </summary>
        /// <value>Certifies that the entity is a withholding foreign partnership (WP) or a withholding foreign trust (WT)  that is compliant with the terms of its WP or WT agreement.</value>
        /// <example>false</example>
        [DataMember(Name = "withholdingForeignPartnershipOrTrustCertification", EmitDefaultValue = true)]
        public bool WithholdingForeignPartnershipOrTrustCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a nonwithholding foreign partnership or trust,  providing the form for non-effectively connected payments and transmitting required withholding documentation for chapters 3 and 4.
        /// </summary>
        /// <value>Certifies that the entity is a nonwithholding foreign partnership or trust,  providing the form for non-effectively connected payments and transmitting required withholding documentation for chapters 3 and 4.</value>
        /// <example>false</example>
        [DataMember(Name = "nonwithholdingForeignEntityWithholdingStatementCertification", EmitDefaultValue = true)]
        public bool NonwithholdingForeignEntityWithholdingStatementCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a foreign partnership or grantor trust acting as a partner in a lower-tier partnership  and is submitting the form for purposes of section 1446(a).
        /// </summary>
        /// <value>Certifies that the entity is a foreign partnership or grantor trust acting as a partner in a lower-tier partnership  and is submitting the form for purposes of section 1446(a).</value>
        /// <example>false</example>
        [DataMember(Name = "foreignEntityPartnerInLowerTierPartnershipCertification", EmitDefaultValue = true)]
        public bool ForeignEntityPartnerInLowerTierPartnershipCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a foreign partnership receiving an amount realized  from the transfer of a partnership interest for purposes of section 1446(f).
        /// </summary>
        /// <value>Certifies that the entity is a foreign partnership receiving an amount realized  from the transfer of a partnership interest for purposes of section 1446(f).</value>
        /// <example>false</example>
        [DataMember(Name = "foreignPartnershipAmountRealizedSection1446FCertification", EmitDefaultValue = true)]
        public bool ForeignPartnershipAmountRealizedSection1446FCertification { get; set; }

        /// <summary>
        /// Certifies that the foreign partnership is providing a withholding statement for a modified amount realized  from the transfer of a partnership interest, when applicable.
        /// </summary>
        /// <value>Certifies that the foreign partnership is providing a withholding statement for a modified amount realized  from the transfer of a partnership interest, when applicable.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignPartnershipModifiedAmountRealizedCertification", EmitDefaultValue = true)]
        public bool ForeignPartnershipModifiedAmountRealizedCertification { get; set; }

        /// <summary>
        /// Certifies that the foreign grantor trust is submitting the form on behalf of each grantor or owner  and providing a withholding statement to allocate the amount realized in accordance with the regulations.
        /// </summary>
        /// <value>Certifies that the foreign grantor trust is submitting the form on behalf of each grantor or owner  and providing a withholding statement to allocate the amount realized in accordance with the regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignGrantorTrustAmountRealizedAllocationCertification", EmitDefaultValue = true)]
        public bool ForeignGrantorTrustAmountRealizedAllocationCertification { get; set; }

        /// <summary>
        /// Certifies that the entity may rely on the information in all associated withholding certificates  under the applicable standards of knowledge in sections 1441 or 1471 when providing an alternative withholding statement.
        /// </summary>
        /// <value>Certifies that the entity may rely on the information in all associated withholding certificates  under the applicable standards of knowledge in sections 1441 or 1471 when providing an alternative withholding statement.</value>
        /// <example>false</example>
        [DataMember(Name = "alternativeWithholdingStatementRelianceCertification", EmitDefaultValue = true)]
        public bool AlternativeWithholdingStatementRelianceCertification { get; set; }

        /// <summary>
        /// Certifies that the nonparticipating FFI is transmitting withholding documentation  and providing a statement allocating payment portions to exempt beneficial owners.
        /// </summary>
        /// <value>Certifies that the nonparticipating FFI is transmitting withholding documentation  and providing a statement allocating payment portions to exempt beneficial owners.</value>
        /// <example>false</example>
        [DataMember(Name = "npFfiWithExemptBeneficialOwnersCertification", EmitDefaultValue = true)]
        public bool NpFfiWithExemptBeneficialOwnersCertification { get; set; }

        /// <summary>
        /// The name of the entity that sponsors the foreign financial institution (FFI).
        /// </summary>
        /// <value>The name of the entity that sponsors the foreign financial institution (FFI).</value>
        [DataMember(Name = "ffiSponsoringEntity", EmitDefaultValue = true)]
        public string FfiSponsoringEntity { get; set; }

        /// <summary>
        /// Certifies that the entity is an investment entity, not a QI, WP, or WT, and has an agreement with a sponsoring entity.
        /// </summary>
        /// <value>Certifies that the entity is an investment entity, not a QI, WP, or WT, and has an agreement with a sponsoring entity.</value>
        /// <example>false</example>
        [DataMember(Name = "investmentEntityCertification", EmitDefaultValue = true)]
        public bool InvestmentEntityCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a controlled foreign corporation sponsored by a U.S. financial institution, not a QI, WP, or WT,  and shares a common electronic account system for full transparency.
        /// </summary>
        /// <value>Certifies that the entity is a controlled foreign corporation sponsored by a U.S. financial institution, not a QI, WP, or WT,  and shares a common electronic account system for full transparency.</value>
        /// <example>false</example>
        [DataMember(Name = "controlledForeignCorporationCertification", EmitDefaultValue = true)]
        public bool ControlledForeignCorporationCertification { get; set; }

        /// <summary>
        /// Certifies that the FFI meets all requirements to qualify as an owner-documented FFI, including restrictions on activities,  ownership, and account relationships.
        /// </summary>
        /// <value>Certifies that the FFI meets all requirements to qualify as an owner-documented FFI, including restrictions on activities,  ownership, and account relationships.</value>
        /// <example>false</example>
        [DataMember(Name = "ownerDocumentedFfiCertification", EmitDefaultValue = true)]
        public bool OwnerDocumentedFfiCertification { get; set; }

        /// <summary>
        /// Certifies that the FFI will provide a complete owner reporting statement  and required documentation for each relevant owner or debt holder.
        /// </summary>
        /// <value>Certifies that the FFI will provide a complete owner reporting statement  and required documentation for each relevant owner or debt holder.</value>
        /// <example>false</example>
        [DataMember(Name = "ownerDocumentedFfiReportingStatementCertification", EmitDefaultValue = true)]
        public bool OwnerDocumentedFfiReportingStatementCertification { get; set; }

        /// <summary>
        /// Certifies that the FFI has provided or will provide an auditor’s letter and required owner documentation,  including a reporting statement and Form W-9s, to meet owner-documented FFI requirements under the regulations.
        /// </summary>
        /// <value>Certifies that the FFI has provided or will provide an auditor’s letter and required owner documentation,  including a reporting statement and Form W-9s, to meet owner-documented FFI requirements under the regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "ownerDocumentedFfiAuditorLetterCertification", EmitDefaultValue = true)]
        public bool OwnerDocumentedFfiAuditorLetterCertification { get; set; }

        /// <summary>
        /// Certifies that the FFI operates solely as a limited bank or credit union within its country, meets asset thresholds,  and has no foreign operations or affiliations outside its country of organization.
        /// </summary>
        /// <value>Certifies that the FFI operates solely as a limited bank or credit union within its country, meets asset thresholds,  and has no foreign operations or affiliations outside its country of organization.</value>
        /// <example>false</example>
        [DataMember(Name = "compliantNonregisteringLocalBankCertification", EmitDefaultValue = true)]
        public bool CompliantNonregisteringLocalBankCertification { get; set; }

        /// <summary>
        /// Certifies that the FFI is not primarily engaged in investment activities, maintains only low-value accounts,  and has limited total assets within its group.
        /// </summary>
        /// <value>Certifies that the FFI is not primarily engaged in investment activities, maintains only low-value accounts,  and has limited total assets within its group.</value>
        /// <example>false</example>
        [DataMember(Name = "compliantFfiLowValueAccountsCertification", EmitDefaultValue = true)]
        public bool CompliantFfiLowValueAccountsCertification { get; set; }

        /// <summary>
        /// The name of sponsoring entity for a certified deemed-compliant, closely held investment vehicle.
        /// </summary>
        /// <value>The name of sponsoring entity for a certified deemed-compliant, closely held investment vehicle.</value>
        [DataMember(Name = "sponsoredCloselyHeldEntitySponsoringEntity", EmitDefaultValue = true)]
        public string SponsoredCloselyHeldEntitySponsoringEntity { get; set; }

        /// <summary>
        /// Certifies that the entity is a sponsored investment entity with 20 or fewer individual owners,  and that all compliance obligations are fulfilled by the sponsoring entity.
        /// </summary>
        /// <value>Certifies that the entity is a sponsored investment entity with 20 or fewer individual owners,  and that all compliance obligations are fulfilled by the sponsoring entity.</value>
        /// <example>false</example>
        [DataMember(Name = "sponsoredCloselyHeldInvestmentVehicleCertification", EmitDefaultValue = true)]
        public bool SponsoredCloselyHeldInvestmentVehicleCertification { get; set; }

        /// <summary>
        /// Certifies that the entity qualifies as a limited life debt investment entity based on its formation date, issuance terms,  and compliance with regulatory requirements.
        /// </summary>
        /// <value>Certifies that the entity qualifies as a limited life debt investment entity based on its formation date, issuance terms,  and compliance with regulatory requirements.</value>
        /// <example>false</example>
        [DataMember(Name = "compliantLimitedLifeDebtEntityCertification", EmitDefaultValue = true)]
        public bool CompliantLimitedLifeDebtEntityCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a financial institution solely because it is an investment entity under regulations  and the entity does not maintain financial accounts.
        /// </summary>
        /// <value>Certifies that the entity is a financial institution solely because it is an investment entity under regulations  and the entity does not maintain financial accounts.</value>
        /// <example>false</example>
        [DataMember(Name = "investmentEntityNoFinancialAccountsCertification", EmitDefaultValue = true)]
        public bool InvestmentEntityNoFinancialAccountsCertification { get; set; }

        /// <summary>
        /// Certifies that the entity qualifies as a restricted distributor based on its operations, customer base, regulatory compliance,  and financial and geographic limitations.
        /// </summary>
        /// <value>Certifies that the entity qualifies as a restricted distributor based on its operations, customer base, regulatory compliance,  and financial and geographic limitations.</value>
        /// <example>false</example>
        [DataMember(Name = "restrictedDistributorCertification", EmitDefaultValue = true)]
        public bool RestrictedDistributorCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is, and has been, bound by distribution agreements prohibiting sales of fund interests to  specified U.S. persons and certain non-U.S. entities.
        /// </summary>
        /// <value>Certifies that the entity is, and has been, bound by distribution agreements prohibiting sales of fund interests to  specified U.S. persons and certain non-U.S. entities.</value>
        /// <example>false</example>
        [DataMember(Name = "restrictedDistributorAgreementCertification", EmitDefaultValue = true)]
        public bool RestrictedDistributorAgreementCertification { get; set; }

        /// <summary>
        /// Certifies that the entity complies with distribution restrictions for U.S.-linked investors  and has addressed any preexisting sales in accordance with FATCA regulations.
        /// </summary>
        /// <value>Certifies that the entity complies with distribution restrictions for U.S.-linked investors  and has addressed any preexisting sales in accordance with FATCA regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "restrictedDistributorPreexistingSalesComplianceCertification", EmitDefaultValue = true)]
        public bool RestrictedDistributorPreexistingSalesComplianceCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is treated as the beneficial owner of the payment solely  for purposes of chapter 4 under Regulations section 1.1471-6(d)(4).
        /// </summary>
        /// <value>Certifies that the entity is treated as the beneficial owner of the payment solely  for purposes of chapter 4 under Regulations section 1.1471-6(d)(4).</value>
        /// <example>false</example>
        [DataMember(Name = "foreignCentralBankOfIssueCertification", EmitDefaultValue = true)]
        public bool ForeignCentralBankOfIssueCertification { get; set; }

        /// <summary>
        /// Certifies that the entity meets the requirements to be considered a nonreporting financial institution to an applicable IGA.
        /// </summary>
        /// <value>Certifies that the entity meets the requirements to be considered a nonreporting financial institution to an applicable IGA.</value>
        /// <example>false</example>
        [DataMember(Name = "nonreportingIgaFfiCertification", EmitDefaultValue = true)]
        public bool NonreportingIgaFfiCertification { get; set; }

        /// <summary>
        /// The country for the applicable IGA with the United States.
        /// </summary>
        /// <value>The country for the applicable IGA with the United States.</value>
        [DataMember(Name = "igaCountry", EmitDefaultValue = true)]
        public string IgaCountry { get; set; }

        /// <summary>
        /// The applicable IGA model.
        /// </summary>
        /// <value>The applicable IGA model.</value>
        [DataMember(Name = "igaModel", EmitDefaultValue = true)]
        public string IgaModel { get; set; }

        /// <summary>
        /// Specifies how the applicable IGA is treated under the IGA provisions or Treasury regulations.
        /// </summary>
        /// <value>Specifies how the applicable IGA is treated under the IGA provisions or Treasury regulations.</value>
        [DataMember(Name = "igaLegalStatusTreatment", EmitDefaultValue = true)]
        public string IgaLegalStatusTreatment { get; set; }

        /// <summary>
        /// The trustee or sponsor name for the nonreporting IGA FFI.
        /// </summary>
        /// <value>The trustee or sponsor name for the nonreporting IGA FFI.</value>
        [DataMember(Name = "igaFfiTrusteeOrSponsor", EmitDefaultValue = true)]
        public string IgaFfiTrusteeOrSponsor { get; set; }

        /// <summary>
        /// Indicates whether the trustee for the nonreporting IGA FFI is foreign.
        /// </summary>
        /// <value>Indicates whether the trustee for the nonreporting IGA FFI is foreign.</value>
        [DataMember(Name = "igaFfiTrusteeIsForeign", EmitDefaultValue = true)]
        public bool? IgaFfiTrusteeIsForeign { get; set; }

        /// <summary>
        /// Certifies that the entity is a pension or retirement fund established in a treaty country  and is entitled to treaty benefits on U.S. source income.
        /// </summary>
        /// <value>Certifies that the entity is a pension or retirement fund established in a treaty country  and is entitled to treaty benefits on U.S. source income.</value>
        /// <example>false</example>
        [DataMember(Name = "treatyQualifiedPensionFundCertification", EmitDefaultValue = true)]
        public bool TreatyQualifiedPensionFundCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a government-regulated retirement fund meeting specific requirements for contributions, tax exemption,  beneficiary limits, and distribution restrictions.
        /// </summary>
        /// <value>Certifies that the entity is a government-regulated retirement fund meeting specific requirements for contributions, tax exemption,  beneficiary limits, and distribution restrictions.</value>
        /// <example>false</example>
        [DataMember(Name = "qualifiedRetirementFundCertification", EmitDefaultValue = true)]
        public bool QualifiedRetirementFundCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a government-regulated retirement fund with fewer than 50 participants, limited foreign ownership,  and employer sponsorship that is not from investment entities or passive NFFEs.
        /// </summary>
        /// <value>Certifies that the entity is a government-regulated retirement fund with fewer than 50 participants, limited foreign ownership,  and employer sponsorship that is not from investment entities or passive NFFEs.</value>
        /// <example>false</example>
        [DataMember(Name = "narrowParticipationRetirementFundCertification", EmitDefaultValue = true)]
        public bool NarrowParticipationRetirementFundCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is formed under a pension plan meeting section 401(a) requirements, except for being U.S.-trust funded.
        /// </summary>
        /// <value>Certifies that the entity is formed under a pension plan meeting section 401(a) requirements, except for being U.S.-trust funded.</value>
        /// <example>false</example>
        [DataMember(Name = "section401AEquivalentPensionPlanCertification", EmitDefaultValue = true)]
        public bool Section401AEquivalentPensionPlanCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is established solely to earn income for the benefit of qualifying retirement funds  or accounts under applicable FATCA regulations or IGAs.
        /// </summary>
        /// <value>Certifies that the entity is established solely to earn income for the benefit of qualifying retirement funds  or accounts under applicable FATCA regulations or IGAs.</value>
        /// <example>false</example>
        [DataMember(Name = "investmentEntityForRetirementFundsCertification", EmitDefaultValue = true)]
        public bool InvestmentEntityForRetirementFundsCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is established and sponsored by a qualifying exempt beneficial owner to provide retirement, disability,  or death benefits to individuals based on services performed for the sponsor.
        /// </summary>
        /// <value>Certifies that the entity is established and sponsored by a qualifying exempt beneficial owner to provide retirement, disability,  or death benefits to individuals based on services performed for the sponsor.</value>
        /// <example>false</example>
        [DataMember(Name = "exemptBeneficialOwnerSponsoredRetirementFundCertification", EmitDefaultValue = true)]
        public bool ExemptBeneficialOwnerSponsoredRetirementFundCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a holding company, treasury center, or captive finance company operating within a nonfinancial group  and not functioning as an investment or financial institution.
        /// </summary>
        /// <value>Certifies that the entity is a holding company, treasury center, or captive finance company operating within a nonfinancial group  and not functioning as an investment or financial institution.</value>
        /// <example>false</example>
        [DataMember(Name = "exceptedNonfinancialGroupEntityCertification", EmitDefaultValue = true)]
        public bool ExceptedNonfinancialGroupEntityCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a recently formed startup NFFE investing in a non-financial business  and is not operating as or presenting itself as an investment fund.
        /// </summary>
        /// <value>Certifies that the entity is a recently formed startup NFFE investing in a non-financial business  and is not operating as or presenting itself as an investment fund.</value>
        /// <example>false</example>
        [DataMember(Name = "exceptedNonfinancialStartUpCertification", EmitDefaultValue = true)]
        public bool ExceptedNonfinancialStartUpCertification { get; set; }

        /// <summary>
        /// The date the start-up company was formed on (or, in case of new line of business, the date of board resolution approving the  new line of business).
        /// </summary>
        /// <value>The date the start-up company was formed on (or, in case of new line of business, the date of board resolution approving the  new line of business).</value>
        [DataMember(Name = "startupFormationOrResolutionDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartupFormationOrResolutionDate { get; set; }

        /// <summary>
        /// Certifies that the entity is in liquidation, reorganization, or bankruptcy and intends to operate as a nonfinancial entity,  with supporting documentation available if the process exceeds three years.
        /// </summary>
        /// <value>Certifies that the entity is in liquidation, reorganization, or bankruptcy and intends to operate as a nonfinancial entity,  with supporting documentation available if the process exceeds three years.</value>
        /// <example>false</example>
        [DataMember(Name = "exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification", EmitDefaultValue = true)]
        public bool ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification { get; set; }

        /// <summary>
        /// The filed date for a plan of reorganization, liquidation or bankruptcy.
        /// </summary>
        /// <value>The filed date for a plan of reorganization, liquidation or bankruptcy.</value>
        [DataMember(Name = "nonfinancialEntityFilingDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? NonfinancialEntityFilingDate { get; set; }

        /// <summary>
        /// Certifies that the entity is a foreign corporation that is not a financial institution  and whose stock is regularly traded on an established securities market.
        /// </summary>
        /// <value>Certifies that the entity is a foreign corporation that is not a financial institution  and whose stock is regularly traded on an established securities market.</value>
        /// <example>false</example>
        [DataMember(Name = "publiclyTradedNffeCertification", EmitDefaultValue = true)]
        public bool PubliclyTradedNffeCertification { get; set; }

        /// <summary>
        /// The name of the securities market where the corporation&#39;s stock is regularly traded.
        /// </summary>
        /// <value>The name of the securities market where the corporation&#39;s stock is regularly traded.</value>
        [DataMember(Name = "publiclyTradedNffeSecuritiesMarket", EmitDefaultValue = true)]
        public string PubliclyTradedNffeSecuritiesMarket { get; set; }

        /// <summary>
        /// Certifies that the entity is a foreign corporation that is not a financial institution  and is affiliated with a publicly traded entity within the same expanded affiliated group.
        /// </summary>
        /// <value>Certifies that the entity is a foreign corporation that is not a financial institution  and is affiliated with a publicly traded entity within the same expanded affiliated group.</value>
        /// <example>false</example>
        [DataMember(Name = "nffeAffiliateOfPubliclyTradedEntityCertification", EmitDefaultValue = true)]
        public bool NffeAffiliateOfPubliclyTradedEntityCertification { get; set; }

        /// <summary>
        /// The name of the affiliated entity whose stock is regularly traded on an established securities market.
        /// </summary>
        /// <value>The name of the affiliated entity whose stock is regularly traded on an established securities market.</value>
        [DataMember(Name = "publiclyTradedEntity", EmitDefaultValue = true)]
        public string PubliclyTradedEntity { get; set; }

        /// <summary>
        /// The name of the established securities market where the affiliated entity&#39;s stock is traded.
        /// </summary>
        /// <value>The name of the established securities market where the affiliated entity&#39;s stock is traded.</value>
        [DataMember(Name = "nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket", EmitDefaultValue = true)]
        public string NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket { get; set; }

        /// <summary>
        /// Certifies that the entity is organized in a U.S. possession, is not engaged in financial activities,  and is entirely owned by bona fide residents of that possession.
        /// </summary>
        /// <value>Certifies that the entity is organized in a U.S. possession, is not engaged in financial activities,  and is entirely owned by bona fide residents of that possession.</value>
        /// <example>false</example>
        [DataMember(Name = "exceptedTerritoryNffeCertification", EmitDefaultValue = true)]
        public bool ExceptedTerritoryNffeCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a foreign non-financial institution with less than 50% passive income  and less than 50% of its assets producing or held to produce passive income.
        /// </summary>
        /// <value>Certifies that the entity is a foreign non-financial institution with less than 50% passive income  and less than 50% of its assets producing or held to produce passive income.</value>
        /// <example>false</example>
        [DataMember(Name = "activeNffeCertification", EmitDefaultValue = true)]
        public bool ActiveNffeCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a foreign non-financial entity that does not qualify for any other NFFE category  and is not a financial institution.
        /// </summary>
        /// <value>Certifies that the entity is a foreign non-financial entity that does not qualify for any other NFFE category  and is not a financial institution.</value>
        /// <example>false</example>
        [DataMember(Name = "passiveNffeCertification", EmitDefaultValue = true)]
        public bool PassiveNffeCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a sponsored direct reporting NFFE.
        /// </summary>
        /// <value>Certifies that the entity is a sponsored direct reporting NFFE.</value>
        /// <example>false</example>
        [DataMember(Name = "sponsoredDirectReportingNffeCertification", EmitDefaultValue = true)]
        public bool SponsoredDirectReportingNffeCertification { get; set; }

        /// <summary>
        /// The name of the entity that sponsors the direct reporting NFFE.
        /// </summary>
        /// <value>The name of the entity that sponsors the direct reporting NFFE.</value>
        [DataMember(Name = "directReportingNffeSponsoringEntity", EmitDefaultValue = true)]
        public string DirectReportingNffeSponsoringEntity { get; set; }

        /// <summary>
        /// The name of the signer.
        /// </summary>
        /// <value>The name of the signer.</value>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W8ImyFormResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  DisregardedEntity: ").Append(DisregardedEntity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  FatcaStatus: ").Append(FatcaStatus).Append("\n");
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
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  Giin: ").Append(Giin).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  DisregardedEntityFatcaStatus: ").Append(DisregardedEntityFatcaStatus).Append("\n");
            sb.Append("  DisregardedAddress: ").Append(DisregardedAddress).Append("\n");
            sb.Append("  DisregardedCity: ").Append(DisregardedCity).Append("\n");
            sb.Append("  DisregardedState: ").Append(DisregardedState).Append("\n");
            sb.Append("  DisregardedZip: ").Append(DisregardedZip).Append("\n");
            sb.Append("  DisregardedCountry: ").Append(DisregardedCountry).Append("\n");
            sb.Append("  DisregardedEntityGiin: ").Append(DisregardedEntityGiin).Append("\n");
            sb.Append("  QualifiedIntermediaryCertification: ").Append(QualifiedIntermediaryCertification).Append("\n");
            sb.Append("  QiPrimaryWithholdingResponsibilityCertification: ").Append(QiPrimaryWithholdingResponsibilityCertification).Append("\n");
            sb.Append("  QiWithholdingResponsibilityForPtpSalesCertification: ").Append(QiWithholdingResponsibilityForPtpSalesCertification).Append("\n");
            sb.Append("  QiNomineeWithholdingResponsibilityForPtpDistributionsCertification: ").Append(QiNomineeWithholdingResponsibilityForPtpDistributionsCertification).Append("\n");
            sb.Append("  QiSecuritiesLenderSubstituteDividendWithholdingCertification: ").Append(QiSecuritiesLenderSubstituteDividendWithholdingCertification).Append("\n");
            sb.Append("  QiWithholdingAnd1099ReportingResponsibilityCertification: ").Append(QiWithholdingAnd1099ReportingResponsibilityCertification).Append("\n");
            sb.Append("  QiForm1099OrFatcaReportingResponsibilityCertification: ").Append(QiForm1099OrFatcaReportingResponsibilityCertification).Append("\n");
            sb.Append("  QiOptOutOfForm1099ReportingCertification: ").Append(QiOptOutOfForm1099ReportingCertification).Append("\n");
            sb.Append("  QiWithholdingRatePoolCertification: ").Append(QiWithholdingRatePoolCertification).Append("\n");
            sb.Append("  QiIntermediaryOrFlowThroughEntityDocumentationCertification: ").Append(QiIntermediaryOrFlowThroughEntityDocumentationCertification).Append("\n");
            sb.Append("  QualifiedDerivativesDealerCertification: ").Append(QualifiedDerivativesDealerCertification).Append("\n");
            sb.Append("  QddCorporation: ").Append(QddCorporation).Append("\n");
            sb.Append("  QddPartnership: ").Append(QddPartnership).Append("\n");
            sb.Append("  QddDisregardedEntity: ").Append(QddDisregardedEntity).Append("\n");
            sb.Append("  NonqualifiedIntermediaryCertification: ").Append(NonqualifiedIntermediaryCertification).Append("\n");
            sb.Append("  NqiWithholdingStatementTransmissionCertification: ").Append(NqiWithholdingStatementTransmissionCertification).Append("\n");
            sb.Append("  NqiWithholdingRatePoolComplianceCertification: ").Append(NqiWithholdingRatePoolComplianceCertification).Append("\n");
            sb.Append("  NqiQualifiedSecuritiesLenderCertification: ").Append(NqiQualifiedSecuritiesLenderCertification).Append("\n");
            sb.Append("  NqiAlternativeWithholdingStatementVerificationCertification: ").Append(NqiAlternativeWithholdingStatementVerificationCertification).Append("\n");
            sb.Append("  TerritoryFinancialInstitutionCertification: ").Append(TerritoryFinancialInstitutionCertification).Append("\n");
            sb.Append("  TfiTreatedAsUsPersonCertification: ").Append(TfiTreatedAsUsPersonCertification).Append("\n");
            sb.Append("  TfiWithholdingStatementTransmissionCertification: ").Append(TfiWithholdingStatementTransmissionCertification).Append("\n");
            sb.Append("  TfiTreatedAsUsPersonForPtpSalesCertification: ").Append(TfiTreatedAsUsPersonForPtpSalesCertification).Append("\n");
            sb.Append("  TfiNomineeUsPersonForPtpDistributionsCertification: ").Append(TfiNomineeUsPersonForPtpDistributionsCertification).Append("\n");
            sb.Append("  TfiNotNomineeForPtpDistributionsCertification: ").Append(TfiNotNomineeForPtpDistributionsCertification).Append("\n");
            sb.Append("  UsBranchNonEffectivelyConnectedIncomeCertification: ").Append(UsBranchNonEffectivelyConnectedIncomeCertification).Append("\n");
            sb.Append("  UsBranchAgreementToBeTreatedAsUsPersonCertification: ").Append(UsBranchAgreementToBeTreatedAsUsPersonCertification).Append("\n");
            sb.Append("  UsBranchWithholdingStatementAndComplianceCertification: ").Append(UsBranchWithholdingStatementAndComplianceCertification).Append("\n");
            sb.Append("  UsBranchActingAsUsPersonForPtpSalesCertification: ").Append(UsBranchActingAsUsPersonForPtpSalesCertification).Append("\n");
            sb.Append("  UsBranchNomineeForPtpDistributionsCertification: ").Append(UsBranchNomineeForPtpDistributionsCertification).Append("\n");
            sb.Append("  UsBranchNotNomineeForPtpDistributionsCertification: ").Append(UsBranchNotNomineeForPtpDistributionsCertification).Append("\n");
            sb.Append("  WithholdingForeignPartnershipOrTrustCertification: ").Append(WithholdingForeignPartnershipOrTrustCertification).Append("\n");
            sb.Append("  NonwithholdingForeignEntityWithholdingStatementCertification: ").Append(NonwithholdingForeignEntityWithholdingStatementCertification).Append("\n");
            sb.Append("  ForeignEntityPartnerInLowerTierPartnershipCertification: ").Append(ForeignEntityPartnerInLowerTierPartnershipCertification).Append("\n");
            sb.Append("  ForeignPartnershipAmountRealizedSection1446FCertification: ").Append(ForeignPartnershipAmountRealizedSection1446FCertification).Append("\n");
            sb.Append("  ForeignPartnershipModifiedAmountRealizedCertification: ").Append(ForeignPartnershipModifiedAmountRealizedCertification).Append("\n");
            sb.Append("  ForeignGrantorTrustAmountRealizedAllocationCertification: ").Append(ForeignGrantorTrustAmountRealizedAllocationCertification).Append("\n");
            sb.Append("  AlternativeWithholdingStatementRelianceCertification: ").Append(AlternativeWithholdingStatementRelianceCertification).Append("\n");
            sb.Append("  NpFfiWithExemptBeneficialOwnersCertification: ").Append(NpFfiWithExemptBeneficialOwnersCertification).Append("\n");
            sb.Append("  FfiSponsoringEntity: ").Append(FfiSponsoringEntity).Append("\n");
            sb.Append("  InvestmentEntityCertification: ").Append(InvestmentEntityCertification).Append("\n");
            sb.Append("  ControlledForeignCorporationCertification: ").Append(ControlledForeignCorporationCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiCertification: ").Append(OwnerDocumentedFfiCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiReportingStatementCertification: ").Append(OwnerDocumentedFfiReportingStatementCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiAuditorLetterCertification: ").Append(OwnerDocumentedFfiAuditorLetterCertification).Append("\n");
            sb.Append("  CompliantNonregisteringLocalBankCertification: ").Append(CompliantNonregisteringLocalBankCertification).Append("\n");
            sb.Append("  CompliantFfiLowValueAccountsCertification: ").Append(CompliantFfiLowValueAccountsCertification).Append("\n");
            sb.Append("  SponsoredCloselyHeldEntitySponsoringEntity: ").Append(SponsoredCloselyHeldEntitySponsoringEntity).Append("\n");
            sb.Append("  SponsoredCloselyHeldInvestmentVehicleCertification: ").Append(SponsoredCloselyHeldInvestmentVehicleCertification).Append("\n");
            sb.Append("  CompliantLimitedLifeDebtEntityCertification: ").Append(CompliantLimitedLifeDebtEntityCertification).Append("\n");
            sb.Append("  InvestmentEntityNoFinancialAccountsCertification: ").Append(InvestmentEntityNoFinancialAccountsCertification).Append("\n");
            sb.Append("  RestrictedDistributorCertification: ").Append(RestrictedDistributorCertification).Append("\n");
            sb.Append("  RestrictedDistributorAgreementCertification: ").Append(RestrictedDistributorAgreementCertification).Append("\n");
            sb.Append("  RestrictedDistributorPreexistingSalesComplianceCertification: ").Append(RestrictedDistributorPreexistingSalesComplianceCertification).Append("\n");
            sb.Append("  ForeignCentralBankOfIssueCertification: ").Append(ForeignCentralBankOfIssueCertification).Append("\n");
            sb.Append("  NonreportingIgaFfiCertification: ").Append(NonreportingIgaFfiCertification).Append("\n");
            sb.Append("  IgaCountry: ").Append(IgaCountry).Append("\n");
            sb.Append("  IgaModel: ").Append(IgaModel).Append("\n");
            sb.Append("  IgaLegalStatusTreatment: ").Append(IgaLegalStatusTreatment).Append("\n");
            sb.Append("  IgaFfiTrusteeOrSponsor: ").Append(IgaFfiTrusteeOrSponsor).Append("\n");
            sb.Append("  IgaFfiTrusteeIsForeign: ").Append(IgaFfiTrusteeIsForeign).Append("\n");
            sb.Append("  TreatyQualifiedPensionFundCertification: ").Append(TreatyQualifiedPensionFundCertification).Append("\n");
            sb.Append("  QualifiedRetirementFundCertification: ").Append(QualifiedRetirementFundCertification).Append("\n");
            sb.Append("  NarrowParticipationRetirementFundCertification: ").Append(NarrowParticipationRetirementFundCertification).Append("\n");
            sb.Append("  Section401AEquivalentPensionPlanCertification: ").Append(Section401AEquivalentPensionPlanCertification).Append("\n");
            sb.Append("  InvestmentEntityForRetirementFundsCertification: ").Append(InvestmentEntityForRetirementFundsCertification).Append("\n");
            sb.Append("  ExemptBeneficialOwnerSponsoredRetirementFundCertification: ").Append(ExemptBeneficialOwnerSponsoredRetirementFundCertification).Append("\n");
            sb.Append("  ExceptedNonfinancialGroupEntityCertification: ").Append(ExceptedNonfinancialGroupEntityCertification).Append("\n");
            sb.Append("  ExceptedNonfinancialStartUpCertification: ").Append(ExceptedNonfinancialStartUpCertification).Append("\n");
            sb.Append("  StartupFormationOrResolutionDate: ").Append(StartupFormationOrResolutionDate).Append("\n");
            sb.Append("  ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification: ").Append(ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification).Append("\n");
            sb.Append("  NonfinancialEntityFilingDate: ").Append(NonfinancialEntityFilingDate).Append("\n");
            sb.Append("  PubliclyTradedNffeCertification: ").Append(PubliclyTradedNffeCertification).Append("\n");
            sb.Append("  PubliclyTradedNffeSecuritiesMarket: ").Append(PubliclyTradedNffeSecuritiesMarket).Append("\n");
            sb.Append("  NffeAffiliateOfPubliclyTradedEntityCertification: ").Append(NffeAffiliateOfPubliclyTradedEntityCertification).Append("\n");
            sb.Append("  PubliclyTradedEntity: ").Append(PubliclyTradedEntity).Append("\n");
            sb.Append("  NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket: ").Append(NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket).Append("\n");
            sb.Append("  ExceptedTerritoryNffeCertification: ").Append(ExceptedTerritoryNffeCertification).Append("\n");
            sb.Append("  ActiveNffeCertification: ").Append(ActiveNffeCertification).Append("\n");
            sb.Append("  PassiveNffeCertification: ").Append(PassiveNffeCertification).Append("\n");
            sb.Append("  SponsoredDirectReportingNffeCertification: ").Append(SponsoredDirectReportingNffeCertification).Append("\n");
            sb.Append("  DirectReportingNffeSponsoringEntity: ").Append(DirectReportingNffeSponsoringEntity).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }
}
