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
    /// W8BenEFormResponse
    /// </summary>
    [DataContract(Name = "W8BenEFormResponse")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class W8BenEFormResponse : W9FormBaseResponse, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="W8BenEFormResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="citizenshipCountry">The country of citizenship..</param>
        /// <param name="disregardedEntity">The name of the disregarded entity receiving the payment (if applicable)..</param>
        /// <param name="entityType">The entity type..</param>
        /// <param name="makingTreatyClaim">Indicates whether the entity is making a treaty claim..</param>
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
        /// <param name="foreignTinNotRequired">Indicates whether a foreign TIN is not required..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="disregardedEntityFatcaStatus">The FATCA status of disregarded entity or branch receiving payment..</param>
        /// <param name="disregardedAddress">The address for disregarded entities..</param>
        /// <param name="disregardedCity">The city for disregarded entities..</param>
        /// <param name="disregardedState">The state for disregarded entities..</param>
        /// <param name="disregardedZip">The ZIP code for disregarded entities..</param>
        /// <param name="disregardedCountry">The country for disregarded entities..</param>
        /// <param name="disregardedEntityGiin">The GIIN for disregarded entities..</param>
        /// <param name="treatyCountryCertification">Certifies the beneficial owner&#39;s country under the U.S. tax treaty..</param>
        /// <param name="treatyCountry">The treaty country of the beneficial owner..</param>
        /// <param name="benefitLimitationCertification">Certifies that the beneficial owner is eligible for treaty benefits and meets any limitation on benefits requirements..</param>
        /// <param name="benefitLimitation">The benefit limitation for tax treaty claims..</param>
        /// <param name="qualifiedResidentStatusCertification">Certifies that the beneficial owner claims treaty benefits and meets the qualified resident status for specific U.S. source income..</param>
        /// <param name="treatyArticle">Indicates the specific article and paragraph of the tax treaty under which the beneficial owner is claiming benefits..</param>
        /// <param name="withholdingRate">Specifies the reduced withholding rate claimed under the applicable tax treaty..</param>
        /// <param name="incomeType">Specifies the type of income for which the reduced treaty withholding rate is being claimed..</param>
        /// <param name="treatyReasons">The additional conditions in the article the beneficial owner meets to be eligible for the rate of withholding..</param>
        /// <param name="ffiSponsoringEntity">The name of the entity that sponsors the foreign financial institution (FFI)..</param>
        /// <param name="investmentEntityCertification">Certifies that the entity is an investment entity, not a QI, WP, or WT, and has an agreement with a sponsoring entity..</param>
        /// <param name="controlledForeignCorporationCertification">Certifies that the entity is a controlled foreign corporation sponsored by a U.S. financial institution, not a QI, WP, or WT,  and shares a common electronic account system for full transparency..</param>
        /// <param name="compliantNonregisteringLocalBankCertification">Certifies that the FFI operates solely as a limited bank or credit union within its country, meets asset thresholds,  and has no foreign operations or affiliations outside its country of organization..</param>
        /// <param name="compliantFfiLowValueAccountsCertification">Certifies that the FFI is not primarily engaged in investment activities, maintains only low-value accounts,  and has limited total assets within its group..</param>
        /// <param name="sponsoredCloselyHeldEntitySponsoringEntity">The name of sponsoring entity for a certified deemed-compliant, closely held investment vehicle..</param>
        /// <param name="sponsoredCloselyHeldInvestmentVehicleCertification">Certifies that the entity is a sponsored investment entity with 20 or fewer individual owners,  and that all compliance obligations are fulfilled by the sponsoring entity..</param>
        /// <param name="compliantLimitedLifeDebtEntityCertification">Certifies that the entity qualifies as a limited life debt investment entity based on its formation date, issuance terms,  and compliance with regulatory requirements..</param>
        /// <param name="investmentEntityNoFinancialAccountsCertification">Certifies that the entity is a financial institution solely because it is an investment entity under regulations  and the entity does not maintain financial accounts..</param>
        /// <param name="ownerDocumentedFfiCertification">Certifies that the FFI meets all requirements to qualify as an owner-documented FFI, including restrictions on activities,  ownership, and account relationships..</param>
        /// <param name="ownerDocumentedFfiReportingStatementCertification">Certifies that the FFI will provide a complete owner reporting statement  and required documentation for each relevant owner or debt holder..</param>
        /// <param name="ownerDocumentedFfiAuditorLetterCertification">Certifies that the FFI will provide an auditor’s letter and required owner reporting documentation  to confirm its status as an owner-documented FFI..</param>
        /// <param name="ownerDocumentedFfiTrustBeneficiariesCertification">Certifies that the trust has no contingent or unidentified beneficiaries or designated classes of beneficiaries..</param>
        /// <param name="restrictedDistributorCertification">Certifies that the entity qualifies as a restricted distributor based on its operations, customer base, regulatory compliance,  and financial and geographic limitations..</param>
        /// <param name="restrictedDistributorAgreementCertification">Certifies that the entity is, and has been, bound by distribution agreements prohibiting sales of fund interests to  specified U.S. persons and certain non-U.S. entities..</param>
        /// <param name="restrictedDistributorPreexistingSalesComplianceCertification">Certifies that the entity complies with distribution restrictions for U.S.-linked investors  and has addressed any preexisting sales in accordance with FATCA regulations..</param>
        /// <param name="nonreportingIgaFfiCertification">Certifies that the entity meets the requirements to be considered a nonreporting financial institution to an applicable IGA..</param>
        /// <param name="igaCountry">The country for the applicable IGA with the United States..</param>
        /// <param name="igaModel">The applicable IGA model..</param>
        /// <param name="igaLegalStatusTreatment">Specifies how the applicable IGA is treated under the IGA provisions or Treasury regulations..</param>
        /// <param name="igaFfiTrusteeOrSponsor">The trustee or sponsor name for the nonreporting IGA FFI..</param>
        /// <param name="igaFfiTrusteeIsForeign">Indicates whether the trustee for the nonreporting IGA FFI is foreign..</param>
        /// <param name="nonCommercialFinancialActivityCertification">Certifies that the entity is the beneficial owner and is not engaged in commercial financial activities related  to the specified payments, accounts or obligations for which this form is submitted..</param>
        /// <param name="internationOrganizationCertification">Certifies that the entity is an international organization described in section 7701(a)(18)..</param>
        /// <param name="intergovernmentalOrganizationCertification">Certifies that the entity is an intergovernmental or supranational organization primarily comprised of foreign governments,  is the beneficial owner, and is not engaged in commercial financial activities..</param>
        /// <param name="treatyQualifiedPensionFundCertification">Certifies that the entity is a pension or retirement fund established in a treaty country  and is entitled to treaty benefits on U.S. source income..</param>
        /// <param name="qualifiedRetirementFundCertification">Certifies that the entity is a government-regulated retirement fund meeting specific requirements for contributions, tax exemption,  beneficiary limits, and distribution restrictions..</param>
        /// <param name="narrowParticipationRetirementFundCertification">Certifies that the entity is a government-regulated retirement fund with fewer than 50 participants, limited foreign ownership,  and employer sponsorship that is not from investment entities or passive NFFEs..</param>
        /// <param name="section401AEquivalentPensionPlanCertification">Certifies that the entity is formed under a pension plan meeting section 401(a) requirements, except for being U.S.-trust funded..</param>
        /// <param name="investmentEntityForRetirementFundsCertification">Certifies that the entity is established solely to earn income for the benefit of qualifying retirement funds  or accounts under applicable FATCA regulations or IGAs..</param>
        /// <param name="exemptBeneficialOwnerSponsoredRetirementFundCertification">Certifies that the entity is established and sponsored by a qualifying exempt beneficial owner to provide retirement, disability,  or death benefits to individuals based on services performed for the sponsor..</param>
        /// <param name="exemptBeneficialOwnerOwnedInvestmentEntityCertification">Certifies that the entity is an investment entity wholly owned by exempt beneficial owners and has provided complete ownership  and documentation details as required under FATCA regulations..</param>
        /// <param name="territoryFinancialInstitutionCertification">Certifies that the entity is a financial institution (other than an investment entity) that is incorporated  or organized under the laws of a possession of the United States..</param>
        /// <param name="exceptedNonfinancialGroupEntityCertification">Certifies that the entity is a holding company, treasury center, or captive finance company operating within a nonfinancial group  and not functioning as an investment or financial institution..</param>
        /// <param name="exceptedNonfinancialStartUpCertification">Certifies that the entity is a recently formed startup NFFE investing in a non-financial business  and is not operating as or presenting itself as an investment fund..</param>
        /// <param name="startupFormationOrResolutionDate">The date the start-up company was formed on (or, in case of new line of business, the date of board resolution approving the  new line of business)..</param>
        /// <param name="exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification">Certifies that the entity is in liquidation, reorganization, or bankruptcy and intends to operate as a nonfinancial entity,  with supporting documentation available if the process exceeds three years..</param>
        /// <param name="nonfinancialEntityFilingDate">The filed date for a plan of reorganization, liquidation or bankruptcy..</param>
        /// <param name="section501COrganizationCertification">Certifies that the entity is a section 501(c) organization based on a valid IRS determination letter  or a legal opinion from U.S. counsel..</param>
        /// <param name="determinationLetterDate">The date of the IRS determination letter confirming the entity’s section 501(c) status..</param>
        /// <param name="nonprofitOrganizationCertification">Certifies that the entity is a nonprofit organization established for charitable or similar purposes, exempt from income tax,  and restricted in the use and distribution of its assets under applicable law..</param>
        /// <param name="publiclyTradedNffeCertification">Certifies that the entity is a foreign corporation that is not a financial institution  and whose stock is regularly traded on an established securities market..</param>
        /// <param name="publiclyTradedNffeSecuritiesMarket">The name of the securities market where the corporation&#39;s stock is regularly traded..</param>
        /// <param name="nffeAffiliateOfPubliclyTradedEntityCertification">Certifies that the entity is a foreign corporation that is not a financial institution  and is affiliated with a publicly traded entity within the same expanded affiliated group..</param>
        /// <param name="publiclyTradedEntity">The name of the affiliated entity whose stock is regularly traded on an established securities market..</param>
        /// <param name="nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket">The name of the established securities market where the affiliated entity&#39;s stock is traded..</param>
        /// <param name="exceptedTerritoryNffeCertification">Certifies that the entity is organized in a U.S. possession, is not engaged in financial activities,  and is entirely owned by bona fide residents of that possession..</param>
        /// <param name="activeNffeCertification">Certifies that the entity is a foreign non-financial institution with less than 50% passive income  and less than 50% of its assets producing or held to produce passive income..</param>
        /// <param name="passiveNffeCertification">Certifies that the entity is a foreign non-financial entity that does not qualify for any other NFFE category  and is not a financial institution..</param>
        /// <param name="passiveNffeNoSubstantialUsOwnersCertification">Certifies that the passive NFFE has no substantial U.S. owners or controlling U.S. persons..</param>
        /// <param name="passiveNffeSubstantialUsOwnersProvidedCertification">Certifies that the passive NFFE has provided the name, address, and TIN of each substantial U.S. owner or controlling U.S. person..</param>
        /// <param name="exceptedInterAffiliateFfiCertification">Certifies that the entity is an inter-affiliate FFI meeting all conditions for exemption,  including limited account activity and payment interactions within its expanded affiliated group..</param>
        /// <param name="sponsoredDirectReportingNffeCertification">Certifies that the entity is a sponsored direct reporting NFFE..</param>
        /// <param name="directReportingNffeSponsoringEntity">The name of the entity that sponsors the direct reporting NFFE..</param>
        /// <param name="substantialUsOwners">The list of substantial U.S. owners of passive NFFE..</param>
        /// <param name="signerName">The name of the signer..</param>
        /// <param name="capacityToSignCertification">Certifies signer has the capacity to sign for the beneficial owner..</param>
        /// <param name="id">The unique identifier for the form..</param>
        /// <param name="entryStatus">The form status..</param>
        /// <param name="entryStatusDate">The timestamp for the latest status update..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="signature">The signature of the form..</param>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="type">The type of the response object. (default to &quot;W8BenEFormResponse&quot;).</param>
        public W8BenEFormResponse(string name = default(string), string citizenshipCountry = default(string), string disregardedEntity = default(string), string entityType = default(string), bool makingTreatyClaim = default(bool), string fatcaStatus = default(string), string residenceAddress = default(string), string residenceCity = default(string), string residenceState = default(string), string residenceZip = default(string), string residenceCountry = default(string), bool residenceIsMailing = default(bool), string mailingAddress = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingZip = default(string), string mailingCountry = default(string), string tinType = default(string), string tin = default(string), string giin = default(string), bool foreignTinNotRequired = default(bool), string foreignTin = default(string), string referenceNumber = default(string), string disregardedEntityFatcaStatus = default(string), string disregardedAddress = default(string), string disregardedCity = default(string), string disregardedState = default(string), string disregardedZip = default(string), string disregardedCountry = default(string), string disregardedEntityGiin = default(string), bool treatyCountryCertification = default(bool), string treatyCountry = default(string), bool benefitLimitationCertification = default(bool), string benefitLimitation = default(string), bool qualifiedResidentStatusCertification = default(bool), string treatyArticle = default(string), string withholdingRate = default(string), string incomeType = default(string), string treatyReasons = default(string), string ffiSponsoringEntity = default(string), bool investmentEntityCertification = default(bool), bool controlledForeignCorporationCertification = default(bool), bool compliantNonregisteringLocalBankCertification = default(bool), bool compliantFfiLowValueAccountsCertification = default(bool), string sponsoredCloselyHeldEntitySponsoringEntity = default(string), bool sponsoredCloselyHeldInvestmentVehicleCertification = default(bool), bool compliantLimitedLifeDebtEntityCertification = default(bool), bool investmentEntityNoFinancialAccountsCertification = default(bool), bool ownerDocumentedFfiCertification = default(bool), bool ownerDocumentedFfiReportingStatementCertification = default(bool), bool ownerDocumentedFfiAuditorLetterCertification = default(bool), bool ownerDocumentedFfiTrustBeneficiariesCertification = default(bool), bool restrictedDistributorCertification = default(bool), bool restrictedDistributorAgreementCertification = default(bool), bool restrictedDistributorPreexistingSalesComplianceCertification = default(bool), bool nonreportingIgaFfiCertification = default(bool), string igaCountry = default(string), string igaModel = default(string), string igaLegalStatusTreatment = default(string), string igaFfiTrusteeOrSponsor = default(string), bool? igaFfiTrusteeIsForeign = default(bool?), bool nonCommercialFinancialActivityCertification = default(bool), bool internationOrganizationCertification = default(bool), bool intergovernmentalOrganizationCertification = default(bool), bool treatyQualifiedPensionFundCertification = default(bool), bool qualifiedRetirementFundCertification = default(bool), bool narrowParticipationRetirementFundCertification = default(bool), bool section401AEquivalentPensionPlanCertification = default(bool), bool investmentEntityForRetirementFundsCertification = default(bool), bool exemptBeneficialOwnerSponsoredRetirementFundCertification = default(bool), bool exemptBeneficialOwnerOwnedInvestmentEntityCertification = default(bool), bool territoryFinancialInstitutionCertification = default(bool), bool exceptedNonfinancialGroupEntityCertification = default(bool), bool exceptedNonfinancialStartUpCertification = default(bool), DateTime? startupFormationOrResolutionDate = default(DateTime?), bool exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification = default(bool), DateTime? nonfinancialEntityFilingDate = default(DateTime?), bool section501COrganizationCertification = default(bool), DateTime? determinationLetterDate = default(DateTime?), bool nonprofitOrganizationCertification = default(bool), bool publiclyTradedNffeCertification = default(bool), string publiclyTradedNffeSecuritiesMarket = default(string), bool nffeAffiliateOfPubliclyTradedEntityCertification = default(bool), string publiclyTradedEntity = default(string), string nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket = default(string), bool exceptedTerritoryNffeCertification = default(bool), bool activeNffeCertification = default(bool), bool passiveNffeCertification = default(bool), bool passiveNffeNoSubstantialUsOwnersCertification = default(bool), bool passiveNffeSubstantialUsOwnersProvidedCertification = default(bool), bool exceptedInterAffiliateFfiCertification = default(bool), bool sponsoredDirectReportingNffeCertification = default(bool), string directReportingNffeSponsoringEntity = default(string), List<SubstantialUsOwnerResponse> substantialUsOwners = default(List<SubstantialUsOwnerResponse>), string signerName = default(string), bool capacityToSignCertification = default(bool), string id = default(string), string entryStatus = default(string), DateTime? entryStatusDate = default(DateTime?), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool archived = default(bool), string signature = default(string), DateTime? signedDate = default(DateTime?), DateTime? eDeliveryConsentedAt = default(DateTime?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string type = @"W8BenEFormResponse") : base(id, entryStatus, entryStatusDate, referenceId, companyId, displayName, email, archived, signature, signedDate, eDeliveryConsentedAt, createdAt, updatedAt, type)
        {
            this.Name = name;
            this.CitizenshipCountry = citizenshipCountry;
            this.DisregardedEntity = disregardedEntity;
            this.EntityType = entityType;
            this.MakingTreatyClaim = makingTreatyClaim;
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
            this.ForeignTinNotRequired = foreignTinNotRequired;
            this.ForeignTin = foreignTin;
            this.ReferenceNumber = referenceNumber;
            this.DisregardedEntityFatcaStatus = disregardedEntityFatcaStatus;
            this.DisregardedAddress = disregardedAddress;
            this.DisregardedCity = disregardedCity;
            this.DisregardedState = disregardedState;
            this.DisregardedZip = disregardedZip;
            this.DisregardedCountry = disregardedCountry;
            this.DisregardedEntityGiin = disregardedEntityGiin;
            this.TreatyCountryCertification = treatyCountryCertification;
            this.TreatyCountry = treatyCountry;
            this.BenefitLimitationCertification = benefitLimitationCertification;
            this.BenefitLimitation = benefitLimitation;
            this.QualifiedResidentStatusCertification = qualifiedResidentStatusCertification;
            this.TreatyArticle = treatyArticle;
            this.WithholdingRate = withholdingRate;
            this.IncomeType = incomeType;
            this.TreatyReasons = treatyReasons;
            this.FfiSponsoringEntity = ffiSponsoringEntity;
            this.InvestmentEntityCertification = investmentEntityCertification;
            this.ControlledForeignCorporationCertification = controlledForeignCorporationCertification;
            this.CompliantNonregisteringLocalBankCertification = compliantNonregisteringLocalBankCertification;
            this.CompliantFfiLowValueAccountsCertification = compliantFfiLowValueAccountsCertification;
            this.SponsoredCloselyHeldEntitySponsoringEntity = sponsoredCloselyHeldEntitySponsoringEntity;
            this.SponsoredCloselyHeldInvestmentVehicleCertification = sponsoredCloselyHeldInvestmentVehicleCertification;
            this.CompliantLimitedLifeDebtEntityCertification = compliantLimitedLifeDebtEntityCertification;
            this.InvestmentEntityNoFinancialAccountsCertification = investmentEntityNoFinancialAccountsCertification;
            this.OwnerDocumentedFfiCertification = ownerDocumentedFfiCertification;
            this.OwnerDocumentedFfiReportingStatementCertification = ownerDocumentedFfiReportingStatementCertification;
            this.OwnerDocumentedFfiAuditorLetterCertification = ownerDocumentedFfiAuditorLetterCertification;
            this.OwnerDocumentedFfiTrustBeneficiariesCertification = ownerDocumentedFfiTrustBeneficiariesCertification;
            this.RestrictedDistributorCertification = restrictedDistributorCertification;
            this.RestrictedDistributorAgreementCertification = restrictedDistributorAgreementCertification;
            this.RestrictedDistributorPreexistingSalesComplianceCertification = restrictedDistributorPreexistingSalesComplianceCertification;
            this.NonreportingIgaFfiCertification = nonreportingIgaFfiCertification;
            this.IgaCountry = igaCountry;
            this.IgaModel = igaModel;
            this.IgaLegalStatusTreatment = igaLegalStatusTreatment;
            this.IgaFfiTrusteeOrSponsor = igaFfiTrusteeOrSponsor;
            this.IgaFfiTrusteeIsForeign = igaFfiTrusteeIsForeign;
            this.NonCommercialFinancialActivityCertification = nonCommercialFinancialActivityCertification;
            this.InternationOrganizationCertification = internationOrganizationCertification;
            this.IntergovernmentalOrganizationCertification = intergovernmentalOrganizationCertification;
            this.TreatyQualifiedPensionFundCertification = treatyQualifiedPensionFundCertification;
            this.QualifiedRetirementFundCertification = qualifiedRetirementFundCertification;
            this.NarrowParticipationRetirementFundCertification = narrowParticipationRetirementFundCertification;
            this.Section401AEquivalentPensionPlanCertification = section401AEquivalentPensionPlanCertification;
            this.InvestmentEntityForRetirementFundsCertification = investmentEntityForRetirementFundsCertification;
            this.ExemptBeneficialOwnerSponsoredRetirementFundCertification = exemptBeneficialOwnerSponsoredRetirementFundCertification;
            this.ExemptBeneficialOwnerOwnedInvestmentEntityCertification = exemptBeneficialOwnerOwnedInvestmentEntityCertification;
            this.TerritoryFinancialInstitutionCertification = territoryFinancialInstitutionCertification;
            this.ExceptedNonfinancialGroupEntityCertification = exceptedNonfinancialGroupEntityCertification;
            this.ExceptedNonfinancialStartUpCertification = exceptedNonfinancialStartUpCertification;
            this.StartupFormationOrResolutionDate = startupFormationOrResolutionDate;
            this.ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification = exceptedNonfinancialEntityInLiquidationOrBankruptcyCertification;
            this.NonfinancialEntityFilingDate = nonfinancialEntityFilingDate;
            this.Section501COrganizationCertification = section501COrganizationCertification;
            this.DeterminationLetterDate = determinationLetterDate;
            this.NonprofitOrganizationCertification = nonprofitOrganizationCertification;
            this.PubliclyTradedNffeCertification = publiclyTradedNffeCertification;
            this.PubliclyTradedNffeSecuritiesMarket = publiclyTradedNffeSecuritiesMarket;
            this.NffeAffiliateOfPubliclyTradedEntityCertification = nffeAffiliateOfPubliclyTradedEntityCertification;
            this.PubliclyTradedEntity = publiclyTradedEntity;
            this.NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket = nffeAffiliateOfPubliclyTradedEntitySecuritiesMarket;
            this.ExceptedTerritoryNffeCertification = exceptedTerritoryNffeCertification;
            this.ActiveNffeCertification = activeNffeCertification;
            this.PassiveNffeCertification = passiveNffeCertification;
            this.PassiveNffeNoSubstantialUsOwnersCertification = passiveNffeNoSubstantialUsOwnersCertification;
            this.PassiveNffeSubstantialUsOwnersProvidedCertification = passiveNffeSubstantialUsOwnersProvidedCertification;
            this.ExceptedInterAffiliateFfiCertification = exceptedInterAffiliateFfiCertification;
            this.SponsoredDirectReportingNffeCertification = sponsoredDirectReportingNffeCertification;
            this.DirectReportingNffeSponsoringEntity = directReportingNffeSponsoringEntity;
            this.SubstantialUsOwners = substantialUsOwners;
            this.SignerName = signerName;
            this.CapacityToSignCertification = capacityToSignCertification;
        }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>Global Enterprises LLC</example>
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
        /// <example>Subsidiary LLC</example>
        [DataMember(Name = "disregardedEntity", EmitDefaultValue = true)]
        public string DisregardedEntity { get; set; }

        /// <summary>
        /// The entity type.
        /// </summary>
        /// <value>The entity type.</value>
        /// <example>Corporation</example>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Indicates whether the entity is making a treaty claim.
        /// </summary>
        /// <value>Indicates whether the entity is making a treaty claim.</value>
        /// <example>false</example>
        [DataMember(Name = "makingTreatyClaim", EmitDefaultValue = true)]
        public bool MakingTreatyClaim { get; set; }

        /// <summary>
        /// The FATCA status.
        /// </summary>
        /// <value>The FATCA status.</value>
        /// <example>Active</example>
        [DataMember(Name = "fatcaStatus", EmitDefaultValue = false)]
        public string FatcaStatus { get; set; }

        /// <summary>
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        /// <example>123 International Blvd</example>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = false)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        /// <example>Metropolis</example>
        [DataMember(Name = "residenceCity", EmitDefaultValue = false)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The state of residence.
        /// </summary>
        /// <value>The state of residence.</value>
        /// <example>NY</example>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// The ZIP code of the residence.
        /// </summary>
        /// <value>The ZIP code of the residence.</value>
        /// <example>10118</example>
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
        /// <example>P.O. Box 123</example>
        [DataMember(Name = "mailingAddress", EmitDefaultValue = true)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// The city of the mailing address.
        /// </summary>
        /// <value>The city of the mailing address.</value>
        /// <example>Metropolis</example>
        [DataMember(Name = "mailingCity", EmitDefaultValue = true)]
        public string MailingCity { get; set; }

        /// <summary>
        /// The state of the mailing address.
        /// </summary>
        /// <value>The state of the mailing address.</value>
        /// <example>NY</example>
        [DataMember(Name = "mailingState", EmitDefaultValue = true)]
        public string MailingState { get; set; }

        /// <summary>
        /// The ZIP code of the mailing address.
        /// </summary>
        /// <value>The ZIP code of the mailing address.</value>
        /// <example>10119</example>
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
        /// Indicates whether a foreign TIN is not required.
        /// </summary>
        /// <value>Indicates whether a foreign TIN is not required.</value>
        /// <example>true</example>
        [DataMember(Name = "foreignTinNotRequired", EmitDefaultValue = true)]
        public bool ForeignTinNotRequired { get; set; }

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
        /// <example>W8BENE12345</example>
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
        /// Certifies the beneficial owner&#39;s country under the U.S. tax treaty.
        /// </summary>
        /// <value>Certifies the beneficial owner&#39;s country under the U.S. tax treaty.</value>
        /// <example>false</example>
        [DataMember(Name = "treatyCountryCertification", EmitDefaultValue = true)]
        public bool TreatyCountryCertification { get; set; }

        /// <summary>
        /// The treaty country of the beneficial owner.
        /// </summary>
        /// <value>The treaty country of the beneficial owner.</value>
        [DataMember(Name = "treatyCountry", EmitDefaultValue = true)]
        public string TreatyCountry { get; set; }

        /// <summary>
        /// Certifies that the beneficial owner is eligible for treaty benefits and meets any limitation on benefits requirements.
        /// </summary>
        /// <value>Certifies that the beneficial owner is eligible for treaty benefits and meets any limitation on benefits requirements.</value>
        /// <example>false</example>
        [DataMember(Name = "benefitLimitationCertification", EmitDefaultValue = true)]
        public bool BenefitLimitationCertification { get; set; }

        /// <summary>
        /// The benefit limitation for tax treaty claims.
        /// </summary>
        /// <value>The benefit limitation for tax treaty claims.</value>
        [DataMember(Name = "benefitLimitation", EmitDefaultValue = true)]
        public string BenefitLimitation { get; set; }

        /// <summary>
        /// Certifies that the beneficial owner claims treaty benefits and meets the qualified resident status for specific U.S. source income.
        /// </summary>
        /// <value>Certifies that the beneficial owner claims treaty benefits and meets the qualified resident status for specific U.S. source income.</value>
        /// <example>false</example>
        [DataMember(Name = "qualifiedResidentStatusCertification", EmitDefaultValue = true)]
        public bool QualifiedResidentStatusCertification { get; set; }

        /// <summary>
        /// Indicates the specific article and paragraph of the tax treaty under which the beneficial owner is claiming benefits.
        /// </summary>
        /// <value>Indicates the specific article and paragraph of the tax treaty under which the beneficial owner is claiming benefits.</value>
        [DataMember(Name = "treatyArticle", EmitDefaultValue = true)]
        public string TreatyArticle { get; set; }

        /// <summary>
        /// Specifies the reduced withholding rate claimed under the applicable tax treaty.
        /// </summary>
        /// <value>Specifies the reduced withholding rate claimed under the applicable tax treaty.</value>
        [DataMember(Name = "withholdingRate", EmitDefaultValue = true)]
        public string WithholdingRate { get; set; }

        /// <summary>
        /// Specifies the type of income for which the reduced treaty withholding rate is being claimed.
        /// </summary>
        /// <value>Specifies the type of income for which the reduced treaty withholding rate is being claimed.</value>
        [DataMember(Name = "incomeType", EmitDefaultValue = true)]
        public string IncomeType { get; set; }

        /// <summary>
        /// The additional conditions in the article the beneficial owner meets to be eligible for the rate of withholding.
        /// </summary>
        /// <value>The additional conditions in the article the beneficial owner meets to be eligible for the rate of withholding.</value>
        [DataMember(Name = "treatyReasons", EmitDefaultValue = true)]
        public string TreatyReasons { get; set; }

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
        /// Certifies that the FFI will provide an auditor’s letter and required owner reporting documentation  to confirm its status as an owner-documented FFI.
        /// </summary>
        /// <value>Certifies that the FFI will provide an auditor’s letter and required owner reporting documentation  to confirm its status as an owner-documented FFI.</value>
        /// <example>false</example>
        [DataMember(Name = "ownerDocumentedFfiAuditorLetterCertification", EmitDefaultValue = true)]
        public bool OwnerDocumentedFfiAuditorLetterCertification { get; set; }

        /// <summary>
        /// Certifies that the trust has no contingent or unidentified beneficiaries or designated classes of beneficiaries.
        /// </summary>
        /// <value>Certifies that the trust has no contingent or unidentified beneficiaries or designated classes of beneficiaries.</value>
        /// <example>false</example>
        [DataMember(Name = "ownerDocumentedFfiTrustBeneficiariesCertification", EmitDefaultValue = true)]
        public bool OwnerDocumentedFfiTrustBeneficiariesCertification { get; set; }

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
        /// Certifies that the entity is the beneficial owner and is not engaged in commercial financial activities related  to the specified payments, accounts or obligations for which this form is submitted.
        /// </summary>
        /// <value>Certifies that the entity is the beneficial owner and is not engaged in commercial financial activities related  to the specified payments, accounts or obligations for which this form is submitted.</value>
        /// <example>false</example>
        [DataMember(Name = "nonCommercialFinancialActivityCertification", EmitDefaultValue = true)]
        public bool NonCommercialFinancialActivityCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is an international organization described in section 7701(a)(18).
        /// </summary>
        /// <value>Certifies that the entity is an international organization described in section 7701(a)(18).</value>
        /// <example>false</example>
        [DataMember(Name = "internationOrganizationCertification", EmitDefaultValue = true)]
        public bool InternationOrganizationCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is an intergovernmental or supranational organization primarily comprised of foreign governments,  is the beneficial owner, and is not engaged in commercial financial activities.
        /// </summary>
        /// <value>Certifies that the entity is an intergovernmental or supranational organization primarily comprised of foreign governments,  is the beneficial owner, and is not engaged in commercial financial activities.</value>
        /// <example>false</example>
        [DataMember(Name = "intergovernmentalOrganizationCertification", EmitDefaultValue = true)]
        public bool IntergovernmentalOrganizationCertification { get; set; }

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
        /// Certifies that the entity is an investment entity wholly owned by exempt beneficial owners and has provided complete ownership  and documentation details as required under FATCA regulations.
        /// </summary>
        /// <value>Certifies that the entity is an investment entity wholly owned by exempt beneficial owners and has provided complete ownership  and documentation details as required under FATCA regulations.</value>
        /// <example>false</example>
        [DataMember(Name = "exemptBeneficialOwnerOwnedInvestmentEntityCertification", EmitDefaultValue = true)]
        public bool ExemptBeneficialOwnerOwnedInvestmentEntityCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is a financial institution (other than an investment entity) that is incorporated  or organized under the laws of a possession of the United States.
        /// </summary>
        /// <value>Certifies that the entity is a financial institution (other than an investment entity) that is incorporated  or organized under the laws of a possession of the United States.</value>
        /// <example>false</example>
        [DataMember(Name = "territoryFinancialInstitutionCertification", EmitDefaultValue = true)]
        public bool TerritoryFinancialInstitutionCertification { get; set; }

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
        /// Certifies that the entity is a section 501(c) organization based on a valid IRS determination letter  or a legal opinion from U.S. counsel.
        /// </summary>
        /// <value>Certifies that the entity is a section 501(c) organization based on a valid IRS determination letter  or a legal opinion from U.S. counsel.</value>
        /// <example>false</example>
        [DataMember(Name = "section501COrganizationCertification", EmitDefaultValue = true)]
        public bool Section501COrganizationCertification { get; set; }

        /// <summary>
        /// The date of the IRS determination letter confirming the entity’s section 501(c) status.
        /// </summary>
        /// <value>The date of the IRS determination letter confirming the entity’s section 501(c) status.</value>
        [DataMember(Name = "determinationLetterDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DeterminationLetterDate { get; set; }

        /// <summary>
        /// Certifies that the entity is a nonprofit organization established for charitable or similar purposes, exempt from income tax,  and restricted in the use and distribution of its assets under applicable law.
        /// </summary>
        /// <value>Certifies that the entity is a nonprofit organization established for charitable or similar purposes, exempt from income tax,  and restricted in the use and distribution of its assets under applicable law.</value>
        /// <example>false</example>
        [DataMember(Name = "nonprofitOrganizationCertification", EmitDefaultValue = true)]
        public bool NonprofitOrganizationCertification { get; set; }

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
        /// Certifies that the passive NFFE has no substantial U.S. owners or controlling U.S. persons.
        /// </summary>
        /// <value>Certifies that the passive NFFE has no substantial U.S. owners or controlling U.S. persons.</value>
        /// <example>false</example>
        [DataMember(Name = "passiveNffeNoSubstantialUsOwnersCertification", EmitDefaultValue = true)]
        public bool PassiveNffeNoSubstantialUsOwnersCertification { get; set; }

        /// <summary>
        /// Certifies that the passive NFFE has provided the name, address, and TIN of each substantial U.S. owner or controlling U.S. person.
        /// </summary>
        /// <value>Certifies that the passive NFFE has provided the name, address, and TIN of each substantial U.S. owner or controlling U.S. person.</value>
        /// <example>false</example>
        [DataMember(Name = "passiveNffeSubstantialUsOwnersProvidedCertification", EmitDefaultValue = true)]
        public bool PassiveNffeSubstantialUsOwnersProvidedCertification { get; set; }

        /// <summary>
        /// Certifies that the entity is an inter-affiliate FFI meeting all conditions for exemption,  including limited account activity and payment interactions within its expanded affiliated group.
        /// </summary>
        /// <value>Certifies that the entity is an inter-affiliate FFI meeting all conditions for exemption,  including limited account activity and payment interactions within its expanded affiliated group.</value>
        /// <example>false</example>
        [DataMember(Name = "exceptedInterAffiliateFfiCertification", EmitDefaultValue = true)]
        public bool ExceptedInterAffiliateFfiCertification { get; set; }

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
        /// The list of substantial U.S. owners of passive NFFE.
        /// </summary>
        /// <value>The list of substantial U.S. owners of passive NFFE.</value>
        /// <example>[]</example>
        [DataMember(Name = "substantialUsOwners", EmitDefaultValue = false)]
        public List<SubstantialUsOwnerResponse> SubstantialUsOwners { get; set; }

        /// <summary>
        /// The name of the signer.
        /// </summary>
        /// <value>The name of the signer.</value>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// Certifies signer has the capacity to sign for the beneficial owner.
        /// </summary>
        /// <value>Certifies signer has the capacity to sign for the beneficial owner.</value>
        /// <example>false</example>
        [DataMember(Name = "capacityToSignCertification", EmitDefaultValue = true)]
        public bool CapacityToSignCertification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W8BenEFormResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  DisregardedEntity: ").Append(DisregardedEntity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  MakingTreatyClaim: ").Append(MakingTreatyClaim).Append("\n");
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
            sb.Append("  ForeignTinNotRequired: ").Append(ForeignTinNotRequired).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  DisregardedEntityFatcaStatus: ").Append(DisregardedEntityFatcaStatus).Append("\n");
            sb.Append("  DisregardedAddress: ").Append(DisregardedAddress).Append("\n");
            sb.Append("  DisregardedCity: ").Append(DisregardedCity).Append("\n");
            sb.Append("  DisregardedState: ").Append(DisregardedState).Append("\n");
            sb.Append("  DisregardedZip: ").Append(DisregardedZip).Append("\n");
            sb.Append("  DisregardedCountry: ").Append(DisregardedCountry).Append("\n");
            sb.Append("  DisregardedEntityGiin: ").Append(DisregardedEntityGiin).Append("\n");
            sb.Append("  TreatyCountryCertification: ").Append(TreatyCountryCertification).Append("\n");
            sb.Append("  TreatyCountry: ").Append(TreatyCountry).Append("\n");
            sb.Append("  BenefitLimitationCertification: ").Append(BenefitLimitationCertification).Append("\n");
            sb.Append("  BenefitLimitation: ").Append(BenefitLimitation).Append("\n");
            sb.Append("  QualifiedResidentStatusCertification: ").Append(QualifiedResidentStatusCertification).Append("\n");
            sb.Append("  TreatyArticle: ").Append(TreatyArticle).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  IncomeType: ").Append(IncomeType).Append("\n");
            sb.Append("  TreatyReasons: ").Append(TreatyReasons).Append("\n");
            sb.Append("  FfiSponsoringEntity: ").Append(FfiSponsoringEntity).Append("\n");
            sb.Append("  InvestmentEntityCertification: ").Append(InvestmentEntityCertification).Append("\n");
            sb.Append("  ControlledForeignCorporationCertification: ").Append(ControlledForeignCorporationCertification).Append("\n");
            sb.Append("  CompliantNonregisteringLocalBankCertification: ").Append(CompliantNonregisteringLocalBankCertification).Append("\n");
            sb.Append("  CompliantFfiLowValueAccountsCertification: ").Append(CompliantFfiLowValueAccountsCertification).Append("\n");
            sb.Append("  SponsoredCloselyHeldEntitySponsoringEntity: ").Append(SponsoredCloselyHeldEntitySponsoringEntity).Append("\n");
            sb.Append("  SponsoredCloselyHeldInvestmentVehicleCertification: ").Append(SponsoredCloselyHeldInvestmentVehicleCertification).Append("\n");
            sb.Append("  CompliantLimitedLifeDebtEntityCertification: ").Append(CompliantLimitedLifeDebtEntityCertification).Append("\n");
            sb.Append("  InvestmentEntityNoFinancialAccountsCertification: ").Append(InvestmentEntityNoFinancialAccountsCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiCertification: ").Append(OwnerDocumentedFfiCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiReportingStatementCertification: ").Append(OwnerDocumentedFfiReportingStatementCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiAuditorLetterCertification: ").Append(OwnerDocumentedFfiAuditorLetterCertification).Append("\n");
            sb.Append("  OwnerDocumentedFfiTrustBeneficiariesCertification: ").Append(OwnerDocumentedFfiTrustBeneficiariesCertification).Append("\n");
            sb.Append("  RestrictedDistributorCertification: ").Append(RestrictedDistributorCertification).Append("\n");
            sb.Append("  RestrictedDistributorAgreementCertification: ").Append(RestrictedDistributorAgreementCertification).Append("\n");
            sb.Append("  RestrictedDistributorPreexistingSalesComplianceCertification: ").Append(RestrictedDistributorPreexistingSalesComplianceCertification).Append("\n");
            sb.Append("  NonreportingIgaFfiCertification: ").Append(NonreportingIgaFfiCertification).Append("\n");
            sb.Append("  IgaCountry: ").Append(IgaCountry).Append("\n");
            sb.Append("  IgaModel: ").Append(IgaModel).Append("\n");
            sb.Append("  IgaLegalStatusTreatment: ").Append(IgaLegalStatusTreatment).Append("\n");
            sb.Append("  IgaFfiTrusteeOrSponsor: ").Append(IgaFfiTrusteeOrSponsor).Append("\n");
            sb.Append("  IgaFfiTrusteeIsForeign: ").Append(IgaFfiTrusteeIsForeign).Append("\n");
            sb.Append("  NonCommercialFinancialActivityCertification: ").Append(NonCommercialFinancialActivityCertification).Append("\n");
            sb.Append("  InternationOrganizationCertification: ").Append(InternationOrganizationCertification).Append("\n");
            sb.Append("  IntergovernmentalOrganizationCertification: ").Append(IntergovernmentalOrganizationCertification).Append("\n");
            sb.Append("  TreatyQualifiedPensionFundCertification: ").Append(TreatyQualifiedPensionFundCertification).Append("\n");
            sb.Append("  QualifiedRetirementFundCertification: ").Append(QualifiedRetirementFundCertification).Append("\n");
            sb.Append("  NarrowParticipationRetirementFundCertification: ").Append(NarrowParticipationRetirementFundCertification).Append("\n");
            sb.Append("  Section401AEquivalentPensionPlanCertification: ").Append(Section401AEquivalentPensionPlanCertification).Append("\n");
            sb.Append("  InvestmentEntityForRetirementFundsCertification: ").Append(InvestmentEntityForRetirementFundsCertification).Append("\n");
            sb.Append("  ExemptBeneficialOwnerSponsoredRetirementFundCertification: ").Append(ExemptBeneficialOwnerSponsoredRetirementFundCertification).Append("\n");
            sb.Append("  ExemptBeneficialOwnerOwnedInvestmentEntityCertification: ").Append(ExemptBeneficialOwnerOwnedInvestmentEntityCertification).Append("\n");
            sb.Append("  TerritoryFinancialInstitutionCertification: ").Append(TerritoryFinancialInstitutionCertification).Append("\n");
            sb.Append("  ExceptedNonfinancialGroupEntityCertification: ").Append(ExceptedNonfinancialGroupEntityCertification).Append("\n");
            sb.Append("  ExceptedNonfinancialStartUpCertification: ").Append(ExceptedNonfinancialStartUpCertification).Append("\n");
            sb.Append("  StartupFormationOrResolutionDate: ").Append(StartupFormationOrResolutionDate).Append("\n");
            sb.Append("  ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification: ").Append(ExceptedNonfinancialEntityInLiquidationOrBankruptcyCertification).Append("\n");
            sb.Append("  NonfinancialEntityFilingDate: ").Append(NonfinancialEntityFilingDate).Append("\n");
            sb.Append("  Section501COrganizationCertification: ").Append(Section501COrganizationCertification).Append("\n");
            sb.Append("  DeterminationLetterDate: ").Append(DeterminationLetterDate).Append("\n");
            sb.Append("  NonprofitOrganizationCertification: ").Append(NonprofitOrganizationCertification).Append("\n");
            sb.Append("  PubliclyTradedNffeCertification: ").Append(PubliclyTradedNffeCertification).Append("\n");
            sb.Append("  PubliclyTradedNffeSecuritiesMarket: ").Append(PubliclyTradedNffeSecuritiesMarket).Append("\n");
            sb.Append("  NffeAffiliateOfPubliclyTradedEntityCertification: ").Append(NffeAffiliateOfPubliclyTradedEntityCertification).Append("\n");
            sb.Append("  PubliclyTradedEntity: ").Append(PubliclyTradedEntity).Append("\n");
            sb.Append("  NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket: ").Append(NffeAffiliateOfPubliclyTradedEntitySecuritiesMarket).Append("\n");
            sb.Append("  ExceptedTerritoryNffeCertification: ").Append(ExceptedTerritoryNffeCertification).Append("\n");
            sb.Append("  ActiveNffeCertification: ").Append(ActiveNffeCertification).Append("\n");
            sb.Append("  PassiveNffeCertification: ").Append(PassiveNffeCertification).Append("\n");
            sb.Append("  PassiveNffeNoSubstantialUsOwnersCertification: ").Append(PassiveNffeNoSubstantialUsOwnersCertification).Append("\n");
            sb.Append("  PassiveNffeSubstantialUsOwnersProvidedCertification: ").Append(PassiveNffeSubstantialUsOwnersProvidedCertification).Append("\n");
            sb.Append("  ExceptedInterAffiliateFfiCertification: ").Append(ExceptedInterAffiliateFfiCertification).Append("\n");
            sb.Append("  SponsoredDirectReportingNffeCertification: ").Append(SponsoredDirectReportingNffeCertification).Append("\n");
            sb.Append("  DirectReportingNffeSponsoringEntity: ").Append(DirectReportingNffeSponsoringEntity).Append("\n");
            sb.Append("  SubstantialUsOwners: ").Append(SubstantialUsOwners).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  CapacityToSignCertification: ").Append(CapacityToSignCertification).Append("\n");
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
