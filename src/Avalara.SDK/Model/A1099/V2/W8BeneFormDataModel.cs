/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 API Definition
 *
 * ## Authentication Use **username/password** or **generate a license** key from: Avalara Portal → Settings → License and API Keys  More info on authentication: [Avalara Authentication Methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  Validate your credentials here: [Test Credentials](https://developer.avalara.com/avatax/test-credentials/)  ## API & SDK Docs [Avalara (C#/.NET) SDK on GitHub](https://github.com/avadev/Avalara-SDK-DotNet/tree/main#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples for 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// W-8 BEN-E form
    /// </summary>
    [DataContract(Name = "W8BeneFormDataModel")]
    public partial class W8BeneFormDataModel : IValidatableObject
    {
        /// <summary>
        /// Type of the form, always W8BENE for this model.
        /// </summary>
        /// <value>Type of the form, always W8BENE for this model.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum W9 for value: w9
            /// </summary>
            [EnumMember(Value = "w9")]
            W9 = 1,

            /// <summary>
            /// Enum W4 for value: w4
            /// </summary>
            [EnumMember(Value = "w4")]
            W4 = 2,

            /// <summary>
            /// Enum W8imy for value: w8imy
            /// </summary>
            [EnumMember(Value = "w8imy")]
            W8imy = 3,

            /// <summary>
            /// Enum W8ben for value: w8ben
            /// </summary>
            [EnumMember(Value = "w8ben")]
            W8ben = 4,

            /// <summary>
            /// Enum W8bene for value: w8bene
            /// </summary>
            [EnumMember(Value = "w8bene")]
            W8bene = 5
        }


        /// <summary>
        /// Type of the form, always W8BENE for this model.
        /// </summary>
        /// <value>Type of the form, always W8BENE for this model.</value>
        /// <example>w8bene</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="W8BeneFormDataModel" /> class.
        /// </summary>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="disregardedEntityChapter4FatcaStatus">The FATCA status for disregarded entities under Chapter 4..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="residenceAddress">The residential address of the individual or entity..</param>
        /// <param name="residenceCity">The city of residence..</param>
        /// <param name="residenceState">The state of residence..</param>
        /// <param name="residencePostalCode">The postal code of the residence..</param>
        /// <param name="residenceCountry">The country of residence..</param>
        /// <param name="mailingAddress">The mailing address..</param>
        /// <param name="mailingCity">The city of the mailing address..</param>
        /// <param name="mailingState">The state of the mailing address..</param>
        /// <param name="mailingPostalCode">The postal code of the mailing address..</param>
        /// <param name="mailingCountry">The country of the mailing address..</param>
        /// <param name="disregardedAddress">The address for disregarded entities..</param>
        /// <param name="disregardedCity">The city for disregarded entities..</param>
        /// <param name="disregardedState">The state for disregarded entities..</param>
        /// <param name="disregardedPostalCode">The postal code for disregarded entities..</param>
        /// <param name="disregardedCountry">The country for disregarded entities..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="typeOfTin">The type of TIN provided..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="ftinNotRequired">Indicates whether a foreign TIN is not required..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="giin">The global intermediary identification number (GIIN)..</param>
        /// <param name="chapter3EntityType">The Chapter 3 entity type..</param>
        /// <param name="chapter4FatcaStatus">The Chapter 4 FATCA status..</param>
        /// <param name="disregardedEntity">The disregarded entity information..</param>
        /// <param name="disregardedEntityGiin">The GIIN for disregarded entities..</param>
        /// <param name="benefitLimitation">The benefit limitation for tax treaty claims..</param>
        /// <param name="part4SponsoringEntity">The sponsoring entity information for Part 4..</param>
        /// <param name="part4SponsoringEntityGiin">The GIIN for the sponsoring entity in Part 4..</param>
        /// <param name="part7SponsoringEntity">The sponsoring entity information for Part 7..</param>
        /// <param name="part12IgaCountry">The IGA country information for Part 12..</param>
        /// <param name="part12IgaType">The IGA type information for Part 12..</param>
        /// <param name="part12FatcaStatusUnderIgaAnnexIi">The FATCA status under IGA Annex II for Part 12..</param>
        /// <param name="part12TrusteeName">The trustee name for Part 12..</param>
        /// <param name="part12TrusteeIsForeign">Indicates whether the trustee is foreign for Part 12..</param>
        /// <param name="part12Model2IgaGiin">The GIIN for Model 2 IGA in Part 12..</param>
        /// <param name="box37AExchange">The exchange information for Box 37A..</param>
        /// <param name="box37BExchange">The exchange information for Box 37B..</param>
        /// <param name="box37BEntity">The entity information for Box 37B..</param>
        /// <param name="part28SponsoringEntity">The sponsoring entity information for Part 28..</param>
        /// <param name="part28SponsoringEntityGiin">The GIIN for the sponsoring entity in Part 28..</param>
        /// <param name="signerName">The name of the signer..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="residenceIsMailing">residenceIsMailing.</param>
        /// <param name="citizenshipCountry">citizenshipCountry.</param>
        /// <param name="makingTreatyClaim">makingTreatyClaim.</param>
        /// <param name="treatyCountry">treatyCountry.</param>
        /// <param name="treatyArticle">treatyArticle.</param>
        /// <param name="withholdingRate">withholdingRate.</param>
        /// <param name="incomeType">incomeType.</param>
        /// <param name="treatyReasons">treatyReasons.</param>
        /// <param name="certifyBox14A">certifyBox14A.</param>
        /// <param name="certifyBox14B">certifyBox14B.</param>
        /// <param name="certifyBox14C">certifyBox14C.</param>
        /// <param name="certifyBox171">certifyBox171.</param>
        /// <param name="certifyBox172">certifyBox172.</param>
        /// <param name="certifyBox18">certifyBox18.</param>
        /// <param name="certifyBox19">certifyBox19.</param>
        /// <param name="certifyBox21">certifyBox21.</param>
        /// <param name="certifyBox22">certifyBox22.</param>
        /// <param name="certifyBox23">certifyBox23.</param>
        /// <param name="certifyBox24A">certifyBox24A.</param>
        /// <param name="certifyBox24B">certifyBox24B.</param>
        /// <param name="certifyBox24C">certifyBox24C.</param>
        /// <param name="certifyBox24D">certifyBox24D.</param>
        /// <param name="certifyBox25A">certifyBox25A.</param>
        /// <param name="certifyBox25B">certifyBox25B.</param>
        /// <param name="certifyBox25C">certifyBox25C.</param>
        /// <param name="certifyBox26">certifyBox26.</param>
        /// <param name="certifyBox27">certifyBox27.</param>
        /// <param name="certifyBox28A">certifyBox28A.</param>
        /// <param name="certifyBox28B">certifyBox28B.</param>
        /// <param name="certifyBox29A">certifyBox29A.</param>
        /// <param name="certifyBox29B">certifyBox29B.</param>
        /// <param name="certifyBox29C">certifyBox29C.</param>
        /// <param name="certifyBox29D">certifyBox29D.</param>
        /// <param name="certifyBox29E">certifyBox29E.</param>
        /// <param name="certifyBox29F">certifyBox29F.</param>
        /// <param name="certifyBox30">certifyBox30.</param>
        /// <param name="certifyBox31">certifyBox31.</param>
        /// <param name="certifyBox32">certifyBox32.</param>
        /// <param name="certifyBox33">certifyBox33.</param>
        /// <param name="certifyBox34">certifyBox34.</param>
        /// <param name="certifyBox35">certifyBox35.</param>
        /// <param name="certifyBox36">certifyBox36.</param>
        /// <param name="certifyBox37A">certifyBox37A.</param>
        /// <param name="certifyBox37B">certifyBox37B.</param>
        /// <param name="certifyBox38">certifyBox38.</param>
        /// <param name="certifyBox39">certifyBox39.</param>
        /// <param name="certifyBox40A">certifyBox40A.</param>
        /// <param name="certifyBox40B">certifyBox40B.</param>
        /// <param name="certifyBox40C">certifyBox40C.</param>
        /// <param name="certifyBox41">certifyBox41.</param>
        /// <param name="certifyBox43">certifyBox43.</param>
        /// <param name="certifyPart29Signature">certifyPart29Signature.</param>
        /// <param name="part19FormationOrResolutionDate">part19FormationOrResolutionDate.</param>
        /// <param name="part20FilingDate">part20FilingDate.</param>
        /// <param name="part21DeterminationDate">part21DeterminationDate.</param>
        /// <param name="id">id.</param>
        /// <param name="entryStatus">entryStatus.</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="entryStatusDate">entryStatusDate.</param>
        /// <param name="pdfJson">pdfJson.</param>
        /// <param name="pdfVersion">pdfVersion.</param>
        /// <param name="requestToken">requestToken.</param>
        /// <param name="signature">signature.</param>
        /// <param name="mobile">mobile.</param>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="platform">platform.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="ancestorId">ancestorId.</param>
        public W8BeneFormDataModel(DateTime? signedDate = default(DateTime?), string disregardedEntityChapter4FatcaStatus = default(string), DateTime? createdAt = default(DateTime?), string name = default(string), string residenceAddress = default(string), string residenceCity = default(string), string residenceState = default(string), string residencePostalCode = default(string), string residenceCountry = default(string), string mailingAddress = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingPostalCode = default(string), string mailingCountry = default(string), string disregardedAddress = default(string), string disregardedCity = default(string), string disregardedState = default(string), string disregardedPostalCode = default(string), string disregardedCountry = default(string), string tin = default(string), string typeOfTin = default(string), string foreignTin = default(string), bool? ftinNotRequired = default(bool?), string referenceNumber = default(string), string giin = default(string), string chapter3EntityType = default(string), string chapter4FatcaStatus = default(string), string disregardedEntity = default(string), string disregardedEntityGiin = default(string), string benefitLimitation = default(string), string part4SponsoringEntity = default(string), string part4SponsoringEntityGiin = default(string), string part7SponsoringEntity = default(string), string part12IgaCountry = default(string), string part12IgaType = default(string), string part12FatcaStatusUnderIgaAnnexIi = default(string), string part12TrusteeName = default(string), bool? part12TrusteeIsForeign = default(bool?), string part12Model2IgaGiin = default(string), string box37AExchange = default(string), string box37BExchange = default(string), string box37BEntity = default(string), string part28SponsoringEntity = default(string), string part28SponsoringEntityGiin = default(string), string signerName = default(string), DateTime? eDeliveryConsentedAt = default(DateTime?), bool? residenceIsMailing = default(bool?), string citizenshipCountry = default(string), bool? makingTreatyClaim = default(bool?), string treatyCountry = default(string), string treatyArticle = default(string), string withholdingRate = default(string), string incomeType = default(string), string treatyReasons = default(string), bool certifyBox14A = default(bool), bool certifyBox14B = default(bool), bool certifyBox14C = default(bool), bool certifyBox171 = default(bool), bool certifyBox172 = default(bool), bool certifyBox18 = default(bool), bool certifyBox19 = default(bool), bool certifyBox21 = default(bool), bool certifyBox22 = default(bool), bool certifyBox23 = default(bool), bool certifyBox24A = default(bool), bool certifyBox24B = default(bool), bool certifyBox24C = default(bool), bool certifyBox24D = default(bool), bool certifyBox25A = default(bool), bool certifyBox25B = default(bool), bool certifyBox25C = default(bool), bool certifyBox26 = default(bool), bool certifyBox27 = default(bool), bool certifyBox28A = default(bool), bool certifyBox28B = default(bool), bool certifyBox29A = default(bool), bool certifyBox29B = default(bool), bool certifyBox29C = default(bool), bool certifyBox29D = default(bool), bool certifyBox29E = default(bool), bool certifyBox29F = default(bool), bool certifyBox30 = default(bool), bool certifyBox31 = default(bool), bool certifyBox32 = default(bool), bool certifyBox33 = default(bool), bool certifyBox34 = default(bool), bool certifyBox35 = default(bool), bool certifyBox36 = default(bool), bool certifyBox37A = default(bool), bool certifyBox37B = default(bool), bool certifyBox38 = default(bool), bool certifyBox39 = default(bool), bool certifyBox40A = default(bool), bool certifyBox40B = default(bool), bool certifyBox40C = default(bool), bool certifyBox41 = default(bool), bool certifyBox43 = default(bool), bool certifyPart29Signature = default(bool), DateTime? part19FormationOrResolutionDate = default(DateTime?), DateTime? part20FilingDate = default(DateTime?), DateTime? part21DeterminationDate = default(DateTime?), string id = default(string), string entryStatus = default(string), DateTime? updatedAt = default(DateTime?), string referenceId = default(string), string companyId = default(string), string displayName = default(string), string email = default(string), bool? archived = default(bool?), DateTime? entryStatusDate = default(DateTime?), string pdfJson = default(string), string pdfVersion = default(string), string requestToken = default(string), string signature = default(string), bool? mobile = default(bool?), string appVersion = default(string), string platform = default(string), string osVersion = default(string), string ancestorId = default(string))
        {
            this.SignedDate = signedDate;
            this.DisregardedEntityChapter4FatcaStatus = disregardedEntityChapter4FatcaStatus;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.ResidenceAddress = residenceAddress;
            this.ResidenceCity = residenceCity;
            this.ResidenceState = residenceState;
            this.ResidencePostalCode = residencePostalCode;
            this.ResidenceCountry = residenceCountry;
            this.MailingAddress = mailingAddress;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingPostalCode = mailingPostalCode;
            this.MailingCountry = mailingCountry;
            this.DisregardedAddress = disregardedAddress;
            this.DisregardedCity = disregardedCity;
            this.DisregardedState = disregardedState;
            this.DisregardedPostalCode = disregardedPostalCode;
            this.DisregardedCountry = disregardedCountry;
            this.Tin = tin;
            this.TypeOfTin = typeOfTin;
            this.ForeignTin = foreignTin;
            this.FtinNotRequired = ftinNotRequired;
            this.ReferenceNumber = referenceNumber;
            this.Giin = giin;
            this.Chapter3EntityType = chapter3EntityType;
            this.Chapter4FatcaStatus = chapter4FatcaStatus;
            this.DisregardedEntity = disregardedEntity;
            this.DisregardedEntityGiin = disregardedEntityGiin;
            this.BenefitLimitation = benefitLimitation;
            this.Part4SponsoringEntity = part4SponsoringEntity;
            this.Part4SponsoringEntityGiin = part4SponsoringEntityGiin;
            this.Part7SponsoringEntity = part7SponsoringEntity;
            this.Part12IgaCountry = part12IgaCountry;
            this.Part12IgaType = part12IgaType;
            this.Part12FatcaStatusUnderIgaAnnexIi = part12FatcaStatusUnderIgaAnnexIi;
            this.Part12TrusteeName = part12TrusteeName;
            this.Part12TrusteeIsForeign = part12TrusteeIsForeign;
            this.Part12Model2IgaGiin = part12Model2IgaGiin;
            this.Box37AExchange = box37AExchange;
            this.Box37BExchange = box37BExchange;
            this.Box37BEntity = box37BEntity;
            this.Part28SponsoringEntity = part28SponsoringEntity;
            this.Part28SponsoringEntityGiin = part28SponsoringEntityGiin;
            this.SignerName = signerName;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.ResidenceIsMailing = residenceIsMailing;
            this.CitizenshipCountry = citizenshipCountry;
            this.MakingTreatyClaim = makingTreatyClaim;
            this.TreatyCountry = treatyCountry;
            this.TreatyArticle = treatyArticle;
            this.WithholdingRate = withholdingRate;
            this.IncomeType = incomeType;
            this.TreatyReasons = treatyReasons;
            this.CertifyBox14A = certifyBox14A;
            this.CertifyBox14B = certifyBox14B;
            this.CertifyBox14C = certifyBox14C;
            this.CertifyBox171 = certifyBox171;
            this.CertifyBox172 = certifyBox172;
            this.CertifyBox18 = certifyBox18;
            this.CertifyBox19 = certifyBox19;
            this.CertifyBox21 = certifyBox21;
            this.CertifyBox22 = certifyBox22;
            this.CertifyBox23 = certifyBox23;
            this.CertifyBox24A = certifyBox24A;
            this.CertifyBox24B = certifyBox24B;
            this.CertifyBox24C = certifyBox24C;
            this.CertifyBox24D = certifyBox24D;
            this.CertifyBox25A = certifyBox25A;
            this.CertifyBox25B = certifyBox25B;
            this.CertifyBox25C = certifyBox25C;
            this.CertifyBox26 = certifyBox26;
            this.CertifyBox27 = certifyBox27;
            this.CertifyBox28A = certifyBox28A;
            this.CertifyBox28B = certifyBox28B;
            this.CertifyBox29A = certifyBox29A;
            this.CertifyBox29B = certifyBox29B;
            this.CertifyBox29C = certifyBox29C;
            this.CertifyBox29D = certifyBox29D;
            this.CertifyBox29E = certifyBox29E;
            this.CertifyBox29F = certifyBox29F;
            this.CertifyBox30 = certifyBox30;
            this.CertifyBox31 = certifyBox31;
            this.CertifyBox32 = certifyBox32;
            this.CertifyBox33 = certifyBox33;
            this.CertifyBox34 = certifyBox34;
            this.CertifyBox35 = certifyBox35;
            this.CertifyBox36 = certifyBox36;
            this.CertifyBox37A = certifyBox37A;
            this.CertifyBox37B = certifyBox37B;
            this.CertifyBox38 = certifyBox38;
            this.CertifyBox39 = certifyBox39;
            this.CertifyBox40A = certifyBox40A;
            this.CertifyBox40B = certifyBox40B;
            this.CertifyBox40C = certifyBox40C;
            this.CertifyBox41 = certifyBox41;
            this.CertifyBox43 = certifyBox43;
            this.CertifyPart29Signature = certifyPart29Signature;
            this.Part19FormationOrResolutionDate = part19FormationOrResolutionDate;
            this.Part20FilingDate = part20FilingDate;
            this.Part21DeterminationDate = part21DeterminationDate;
            this.Id = id;
            this.EntryStatus = entryStatus;
            this.UpdatedAt = updatedAt;
            this.ReferenceId = referenceId;
            this.CompanyId = companyId;
            this.DisplayName = displayName;
            this.Email = email;
            this.Archived = archived;
            this.EntryStatusDate = entryStatusDate;
            this.PdfJson = pdfJson;
            this.PdfVersion = pdfVersion;
            this.RequestToken = requestToken;
            this.Signature = signature;
            this.Mobile = mobile;
            this.AppVersion = appVersion;
            this.Platform = platform;
            this.OsVersion = osVersion;
            this.AncestorId = ancestorId;
        }

        /// <summary>
        /// The date the form was signed.
        /// </summary>
        /// <value>The date the form was signed.</value>
        /// <example>2022-04-29T00:00Z</example>
        [DataMember(Name = "signedDate", EmitDefaultValue = true)]
        public DateTime? SignedDate { get; set; }

        /// <summary>
        /// The FATCA status for disregarded entities under Chapter 4.
        /// </summary>
        /// <value>The FATCA status for disregarded entities under Chapter 4.</value>
        [DataMember(Name = "disregardedEntityChapter4FatcaStatus", EmitDefaultValue = true)]
        public string DisregardedEntityChapter4FatcaStatus { get; set; }

        /// <summary>
        /// The creation date of the form.
        /// </summary>
        /// <value>The creation date of the form.</value>
        /// <example>2022-04-29T10:00Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>Global Enterprises LLC</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        /// <example>123 International Blvd</example>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = true)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        /// <example>Metropolis</example>
        [DataMember(Name = "residenceCity", EmitDefaultValue = true)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The state of residence.
        /// </summary>
        /// <value>The state of residence.</value>
        /// <example>NY</example>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// The postal code of the residence.
        /// </summary>
        /// <value>The postal code of the residence.</value>
        /// <example>10118</example>
        [DataMember(Name = "residencePostalCode", EmitDefaultValue = true)]
        public string ResidencePostalCode { get; set; }

        /// <summary>
        /// The country of residence.
        /// </summary>
        /// <value>The country of residence.</value>
        /// <example>USA</example>
        [DataMember(Name = "residenceCountry", EmitDefaultValue = true)]
        public string ResidenceCountry { get; set; }

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
        /// The postal code of the mailing address.
        /// </summary>
        /// <value>The postal code of the mailing address.</value>
        /// <example>10119</example>
        [DataMember(Name = "mailingPostalCode", EmitDefaultValue = true)]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// The country of the mailing address.
        /// </summary>
        /// <value>The country of the mailing address.</value>
        /// <example>USA</example>
        [DataMember(Name = "mailingCountry", EmitDefaultValue = true)]
        public string MailingCountry { get; set; }

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
        /// The postal code for disregarded entities.
        /// </summary>
        /// <value>The postal code for disregarded entities.</value>
        [DataMember(Name = "disregardedPostalCode", EmitDefaultValue = true)]
        public string DisregardedPostalCode { get; set; }

        /// <summary>
        /// The country for disregarded entities.
        /// </summary>
        /// <value>The country for disregarded entities.</value>
        [DataMember(Name = "disregardedCountry", EmitDefaultValue = true)]
        public string DisregardedCountry { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        /// <example>12-3456789</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        [DataMember(Name = "typeOfTin", EmitDefaultValue = true)]
        public string TypeOfTin { get; set; }

        /// <summary>
        /// The foreign taxpayer identification number (TIN).
        /// </summary>
        /// <value>The foreign taxpayer identification number (TIN).</value>
        [DataMember(Name = "foreignTin", EmitDefaultValue = true)]
        public string ForeignTin { get; set; }

        /// <summary>
        /// Indicates whether a foreign TIN is not required.
        /// </summary>
        /// <value>Indicates whether a foreign TIN is not required.</value>
        [DataMember(Name = "ftinNotRequired", EmitDefaultValue = true)]
        public bool? FtinNotRequired { get; set; }

        /// <summary>
        /// A reference number for the form.
        /// </summary>
        /// <value>A reference number for the form.</value>
        /// <example>W8BENE12345</example>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The global intermediary identification number (GIIN).
        /// </summary>
        /// <value>The global intermediary identification number (GIIN).</value>
        /// <example>GIIN12345678</example>
        [DataMember(Name = "giin", EmitDefaultValue = true)]
        public string Giin { get; set; }

        /// <summary>
        /// The Chapter 3 entity type.
        /// </summary>
        /// <value>The Chapter 3 entity type.</value>
        /// <example>Corporation</example>
        [DataMember(Name = "chapter3EntityType", EmitDefaultValue = true)]
        public string Chapter3EntityType { get; set; }

        /// <summary>
        /// The Chapter 4 FATCA status.
        /// </summary>
        /// <value>The Chapter 4 FATCA status.</value>
        /// <example>Active</example>
        [DataMember(Name = "chapter4FatcaStatus", EmitDefaultValue = true)]
        public string Chapter4FatcaStatus { get; set; }

        /// <summary>
        /// The disregarded entity information.
        /// </summary>
        /// <value>The disregarded entity information.</value>
        /// <example>Subsidiary LLC</example>
        [DataMember(Name = "disregardedEntity", EmitDefaultValue = true)]
        public string DisregardedEntity { get; set; }

        /// <summary>
        /// The GIIN for disregarded entities.
        /// </summary>
        /// <value>The GIIN for disregarded entities.</value>
        /// <example>GIIN87654321</example>
        [DataMember(Name = "disregardedEntityGiin", EmitDefaultValue = true)]
        public string DisregardedEntityGiin { get; set; }

        /// <summary>
        /// The benefit limitation for tax treaty claims.
        /// </summary>
        /// <value>The benefit limitation for tax treaty claims.</value>
        /// <example>Treaty Benefit</example>
        [DataMember(Name = "benefitLimitation", EmitDefaultValue = true)]
        public string BenefitLimitation { get; set; }

        /// <summary>
        /// The sponsoring entity information for Part 4.
        /// </summary>
        /// <value>The sponsoring entity information for Part 4.</value>
        /// <example>Parent Company</example>
        [DataMember(Name = "part4SponsoringEntity", EmitDefaultValue = true)]
        public string Part4SponsoringEntity { get; set; }

        /// <summary>
        /// The GIIN for the sponsoring entity in Part 4.
        /// </summary>
        /// <value>The GIIN for the sponsoring entity in Part 4.</value>
        /// <example>GIIN11223344</example>
        [DataMember(Name = "part4SponsoringEntityGiin", EmitDefaultValue = true)]
        public string Part4SponsoringEntityGiin { get; set; }

        /// <summary>
        /// The sponsoring entity information for Part 7.
        /// </summary>
        /// <value>The sponsoring entity information for Part 7.</value>
        /// <example>Affiliated Organization</example>
        [DataMember(Name = "part7SponsoringEntity", EmitDefaultValue = true)]
        public string Part7SponsoringEntity { get; set; }

        /// <summary>
        /// The IGA country information for Part 12.
        /// </summary>
        /// <value>The IGA country information for Part 12.</value>
        /// <example>USA</example>
        [DataMember(Name = "part12IgaCountry", EmitDefaultValue = true)]
        public string Part12IgaCountry { get; set; }

        /// <summary>
        /// The IGA type information for Part 12.
        /// </summary>
        /// <value>The IGA type information for Part 12.</value>
        /// <example>Model 1</example>
        [DataMember(Name = "part12IgaType", EmitDefaultValue = true)]
        public string Part12IgaType { get; set; }

        /// <summary>
        /// The FATCA status under IGA Annex II for Part 12.
        /// </summary>
        /// <value>The FATCA status under IGA Annex II for Part 12.</value>
        /// <example>Registered Deemed Compliant</example>
        [DataMember(Name = "part12FatcaStatusUnderIgaAnnexIi", EmitDefaultValue = true)]
        public string Part12FatcaStatusUnderIgaAnnexIi { get; set; }

        /// <summary>
        /// The trustee name for Part 12.
        /// </summary>
        /// <value>The trustee name for Part 12.</value>
        /// <example>Trustee Inc.</example>
        [DataMember(Name = "part12TrusteeName", EmitDefaultValue = true)]
        public string Part12TrusteeName { get; set; }

        /// <summary>
        /// Indicates whether the trustee is foreign for Part 12.
        /// </summary>
        /// <value>Indicates whether the trustee is foreign for Part 12.</value>
        /// <example>false</example>
        [DataMember(Name = "part12TrusteeIsForeign", EmitDefaultValue = true)]
        public bool? Part12TrusteeIsForeign { get; set; }

        /// <summary>
        /// The GIIN for Model 2 IGA in Part 12.
        /// </summary>
        /// <value>The GIIN for Model 2 IGA in Part 12.</value>
        /// <example>GIIN33445566</example>
        [DataMember(Name = "part12Model2IgaGiin", EmitDefaultValue = true)]
        public string Part12Model2IgaGiin { get; set; }

        /// <summary>
        /// The exchange information for Box 37A.
        /// </summary>
        /// <value>The exchange information for Box 37A.</value>
        /// <example>NYSE</example>
        [DataMember(Name = "box37AExchange", EmitDefaultValue = true)]
        public string Box37AExchange { get; set; }

        /// <summary>
        /// The exchange information for Box 37B.
        /// </summary>
        /// <value>The exchange information for Box 37B.</value>
        /// <example>NASDAQ</example>
        [DataMember(Name = "box37BExchange", EmitDefaultValue = true)]
        public string Box37BExchange { get; set; }

        /// <summary>
        /// The entity information for Box 37B.
        /// </summary>
        /// <value>The entity information for Box 37B.</value>
        /// <example>Trading Partner</example>
        [DataMember(Name = "box37BEntity", EmitDefaultValue = true)]
        public string Box37BEntity { get; set; }

        /// <summary>
        /// The sponsoring entity information for Part 28.
        /// </summary>
        /// <value>The sponsoring entity information for Part 28.</value>
        /// <example>Global Trust</example>
        [DataMember(Name = "part28SponsoringEntity", EmitDefaultValue = true)]
        public string Part28SponsoringEntity { get; set; }

        /// <summary>
        /// The GIIN for the sponsoring entity in Part 28.
        /// </summary>
        /// <value>The GIIN for the sponsoring entity in Part 28.</value>
        /// <example>GIIN99887766</example>
        [DataMember(Name = "part28SponsoringEntityGiin", EmitDefaultValue = true)]
        public string Part28SponsoringEntityGiin { get; set; }

        /// <summary>
        /// The name of the signer.
        /// </summary>
        /// <value>The name of the signer.</value>
        /// <example>John Doe</example>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        /// <example>2022-04-29T15:30Z</example>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceIsMailing
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "residenceIsMailing", EmitDefaultValue = true)]
        public bool? ResidenceIsMailing { get; set; }

        /// <summary>
        /// Gets or Sets CitizenshipCountry
        /// </summary>
        [DataMember(Name = "citizenshipCountry", EmitDefaultValue = true)]
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// Gets or Sets MakingTreatyClaim
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "makingTreatyClaim", EmitDefaultValue = true)]
        public bool? MakingTreatyClaim { get; set; }

        /// <summary>
        /// Gets or Sets TreatyCountry
        /// </summary>
        [DataMember(Name = "treatyCountry", EmitDefaultValue = true)]
        public string TreatyCountry { get; set; }

        /// <summary>
        /// Gets or Sets TreatyArticle
        /// </summary>
        [DataMember(Name = "treatyArticle", EmitDefaultValue = true)]
        public string TreatyArticle { get; set; }

        /// <summary>
        /// Gets or Sets WithholdingRate
        /// </summary>
        [DataMember(Name = "withholdingRate", EmitDefaultValue = true)]
        public string WithholdingRate { get; set; }

        /// <summary>
        /// Gets or Sets IncomeType
        /// </summary>
        [DataMember(Name = "incomeType", EmitDefaultValue = true)]
        public string IncomeType { get; set; }

        /// <summary>
        /// Gets or Sets TreatyReasons
        /// </summary>
        [DataMember(Name = "treatyReasons", EmitDefaultValue = true)]
        public string TreatyReasons { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox14A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14A", EmitDefaultValue = true)]
        public bool CertifyBox14A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox14B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14B", EmitDefaultValue = true)]
        public bool CertifyBox14B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox14C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14C", EmitDefaultValue = true)]
        public bool CertifyBox14C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox171
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17_1", EmitDefaultValue = true)]
        public bool CertifyBox171 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox172
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17_2", EmitDefaultValue = true)]
        public bool CertifyBox172 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox18
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18", EmitDefaultValue = true)]
        public bool CertifyBox18 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox19
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19", EmitDefaultValue = true)]
        public bool CertifyBox19 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox21
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21", EmitDefaultValue = true)]
        public bool CertifyBox21 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox22
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox22", EmitDefaultValue = true)]
        public bool CertifyBox22 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox23
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox23", EmitDefaultValue = true)]
        public bool CertifyBox23 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24A", EmitDefaultValue = true)]
        public bool CertifyBox24A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24B", EmitDefaultValue = true)]
        public bool CertifyBox24B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24C", EmitDefaultValue = true)]
        public bool CertifyBox24C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24D
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24D", EmitDefaultValue = true)]
        public bool CertifyBox24D { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox25A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25A", EmitDefaultValue = true)]
        public bool CertifyBox25A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox25B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25B", EmitDefaultValue = true)]
        public bool CertifyBox25B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox25C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25C", EmitDefaultValue = true)]
        public bool CertifyBox25C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox26
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox26", EmitDefaultValue = true)]
        public bool CertifyBox26 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox27
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox27", EmitDefaultValue = true)]
        public bool CertifyBox27 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox28A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox28A", EmitDefaultValue = true)]
        public bool CertifyBox28A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox28B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox28B", EmitDefaultValue = true)]
        public bool CertifyBox28B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29A", EmitDefaultValue = true)]
        public bool CertifyBox29A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29B", EmitDefaultValue = true)]
        public bool CertifyBox29B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29C", EmitDefaultValue = true)]
        public bool CertifyBox29C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29D
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29D", EmitDefaultValue = true)]
        public bool CertifyBox29D { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29E
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29E", EmitDefaultValue = true)]
        public bool CertifyBox29E { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29F
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29F", EmitDefaultValue = true)]
        public bool CertifyBox29F { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox30
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox30", EmitDefaultValue = true)]
        public bool CertifyBox30 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox31
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox31", EmitDefaultValue = true)]
        public bool CertifyBox31 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox32
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox32", EmitDefaultValue = true)]
        public bool CertifyBox32 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox33
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33", EmitDefaultValue = true)]
        public bool CertifyBox33 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox34
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox34", EmitDefaultValue = true)]
        public bool CertifyBox34 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox35
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox35", EmitDefaultValue = true)]
        public bool CertifyBox35 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox36
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox36", EmitDefaultValue = true)]
        public bool CertifyBox36 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox37A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox37A", EmitDefaultValue = true)]
        public bool CertifyBox37A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox37B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox37B", EmitDefaultValue = true)]
        public bool CertifyBox37B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox38
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox38", EmitDefaultValue = true)]
        public bool CertifyBox38 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox39
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox39", EmitDefaultValue = true)]
        public bool CertifyBox39 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox40A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40A", EmitDefaultValue = true)]
        public bool CertifyBox40A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox40B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40B", EmitDefaultValue = true)]
        public bool CertifyBox40B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox40C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40C", EmitDefaultValue = true)]
        public bool CertifyBox40C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox41
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox41", EmitDefaultValue = true)]
        public bool CertifyBox41 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox43
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox43", EmitDefaultValue = true)]
        public bool CertifyBox43 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyPart29Signature
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyPart29Signature", EmitDefaultValue = true)]
        public bool CertifyPart29Signature { get; set; }

        /// <summary>
        /// Gets or Sets Part19FormationOrResolutionDate
        /// </summary>
        [DataMember(Name = "part19FormationOrResolutionDate", EmitDefaultValue = true)]
        public DateTime? Part19FormationOrResolutionDate { get; set; }

        /// <summary>
        /// Gets or Sets Part20FilingDate
        /// </summary>
        [DataMember(Name = "part20FilingDate", EmitDefaultValue = true)]
        public DateTime? Part20FilingDate { get; set; }

        /// <summary>
        /// Gets or Sets Part21DeterminationDate
        /// </summary>
        [DataMember(Name = "part21DeterminationDate", EmitDefaultValue = true)]
        public DateTime? Part21DeterminationDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntryStatus
        /// </summary>
        [DataMember(Name = "entryStatus", EmitDefaultValue = true)]
        public string EntryStatus { get; set; }

        /// <summary>
        /// The last updated date of the form.
        /// </summary>
        /// <value>The last updated date of the form.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A reference identifier for the form.
        /// </summary>
        /// <value>A reference identifier for the form.</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The ID of the associated company.
        /// </summary>
        /// <value>The ID of the associated company.</value>
        [DataMember(Name = "companyId", EmitDefaultValue = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The display name associated with the form.
        /// </summary>
        /// <value>The display name associated with the form.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the form is archived.
        /// </summary>
        /// <value>Indicates whether the form is archived.</value>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool? Archived { get; set; }

        /// <summary>
        /// Gets or Sets EntryStatusDate
        /// </summary>
        [DataMember(Name = "entryStatusDate", EmitDefaultValue = true)]
        public DateTime? EntryStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets PdfJson
        /// </summary>
        [DataMember(Name = "pdfJson", EmitDefaultValue = true)]
        public string PdfJson { get; set; }

        /// <summary>
        /// Gets or Sets PdfVersion
        /// </summary>
        [DataMember(Name = "pdfVersion", EmitDefaultValue = true)]
        public string PdfVersion { get; set; }

        /// <summary>
        /// Gets or Sets RequestToken
        /// </summary>
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>
        [DataMember(Name = "mobile", EmitDefaultValue = true)]
        public bool? Mobile { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name = "appVersion", EmitDefaultValue = true)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = true)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets AncestorId
        /// </summary>
        [DataMember(Name = "ancestorId", EmitDefaultValue = true)]
        public string AncestorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W8BeneFormDataModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SignedDate: ").Append(SignedDate).Append("\n");
            sb.Append("  DisregardedEntityChapter4FatcaStatus: ").Append(DisregardedEntityChapter4FatcaStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
            sb.Append("  ResidenceCity: ").Append(ResidenceCity).Append("\n");
            sb.Append("  ResidenceState: ").Append(ResidenceState).Append("\n");
            sb.Append("  ResidencePostalCode: ").Append(ResidencePostalCode).Append("\n");
            sb.Append("  ResidenceCountry: ").Append(ResidenceCountry).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  MailingCity: ").Append(MailingCity).Append("\n");
            sb.Append("  MailingState: ").Append(MailingState).Append("\n");
            sb.Append("  MailingPostalCode: ").Append(MailingPostalCode).Append("\n");
            sb.Append("  MailingCountry: ").Append(MailingCountry).Append("\n");
            sb.Append("  DisregardedAddress: ").Append(DisregardedAddress).Append("\n");
            sb.Append("  DisregardedCity: ").Append(DisregardedCity).Append("\n");
            sb.Append("  DisregardedState: ").Append(DisregardedState).Append("\n");
            sb.Append("  DisregardedPostalCode: ").Append(DisregardedPostalCode).Append("\n");
            sb.Append("  DisregardedCountry: ").Append(DisregardedCountry).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  TypeOfTin: ").Append(TypeOfTin).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  FtinNotRequired: ").Append(FtinNotRequired).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Giin: ").Append(Giin).Append("\n");
            sb.Append("  Chapter3EntityType: ").Append(Chapter3EntityType).Append("\n");
            sb.Append("  Chapter4FatcaStatus: ").Append(Chapter4FatcaStatus).Append("\n");
            sb.Append("  DisregardedEntity: ").Append(DisregardedEntity).Append("\n");
            sb.Append("  DisregardedEntityGiin: ").Append(DisregardedEntityGiin).Append("\n");
            sb.Append("  BenefitLimitation: ").Append(BenefitLimitation).Append("\n");
            sb.Append("  Part4SponsoringEntity: ").Append(Part4SponsoringEntity).Append("\n");
            sb.Append("  Part4SponsoringEntityGiin: ").Append(Part4SponsoringEntityGiin).Append("\n");
            sb.Append("  Part7SponsoringEntity: ").Append(Part7SponsoringEntity).Append("\n");
            sb.Append("  Part12IgaCountry: ").Append(Part12IgaCountry).Append("\n");
            sb.Append("  Part12IgaType: ").Append(Part12IgaType).Append("\n");
            sb.Append("  Part12FatcaStatusUnderIgaAnnexIi: ").Append(Part12FatcaStatusUnderIgaAnnexIi).Append("\n");
            sb.Append("  Part12TrusteeName: ").Append(Part12TrusteeName).Append("\n");
            sb.Append("  Part12TrusteeIsForeign: ").Append(Part12TrusteeIsForeign).Append("\n");
            sb.Append("  Part12Model2IgaGiin: ").Append(Part12Model2IgaGiin).Append("\n");
            sb.Append("  Box37AExchange: ").Append(Box37AExchange).Append("\n");
            sb.Append("  Box37BExchange: ").Append(Box37BExchange).Append("\n");
            sb.Append("  Box37BEntity: ").Append(Box37BEntity).Append("\n");
            sb.Append("  Part28SponsoringEntity: ").Append(Part28SponsoringEntity).Append("\n");
            sb.Append("  Part28SponsoringEntityGiin: ").Append(Part28SponsoringEntityGiin).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
            sb.Append("  ResidenceIsMailing: ").Append(ResidenceIsMailing).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  MakingTreatyClaim: ").Append(MakingTreatyClaim).Append("\n");
            sb.Append("  TreatyCountry: ").Append(TreatyCountry).Append("\n");
            sb.Append("  TreatyArticle: ").Append(TreatyArticle).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  IncomeType: ").Append(IncomeType).Append("\n");
            sb.Append("  TreatyReasons: ").Append(TreatyReasons).Append("\n");
            sb.Append("  CertifyBox14A: ").Append(CertifyBox14A).Append("\n");
            sb.Append("  CertifyBox14B: ").Append(CertifyBox14B).Append("\n");
            sb.Append("  CertifyBox14C: ").Append(CertifyBox14C).Append("\n");
            sb.Append("  CertifyBox171: ").Append(CertifyBox171).Append("\n");
            sb.Append("  CertifyBox172: ").Append(CertifyBox172).Append("\n");
            sb.Append("  CertifyBox18: ").Append(CertifyBox18).Append("\n");
            sb.Append("  CertifyBox19: ").Append(CertifyBox19).Append("\n");
            sb.Append("  CertifyBox21: ").Append(CertifyBox21).Append("\n");
            sb.Append("  CertifyBox22: ").Append(CertifyBox22).Append("\n");
            sb.Append("  CertifyBox23: ").Append(CertifyBox23).Append("\n");
            sb.Append("  CertifyBox24A: ").Append(CertifyBox24A).Append("\n");
            sb.Append("  CertifyBox24B: ").Append(CertifyBox24B).Append("\n");
            sb.Append("  CertifyBox24C: ").Append(CertifyBox24C).Append("\n");
            sb.Append("  CertifyBox24D: ").Append(CertifyBox24D).Append("\n");
            sb.Append("  CertifyBox25A: ").Append(CertifyBox25A).Append("\n");
            sb.Append("  CertifyBox25B: ").Append(CertifyBox25B).Append("\n");
            sb.Append("  CertifyBox25C: ").Append(CertifyBox25C).Append("\n");
            sb.Append("  CertifyBox26: ").Append(CertifyBox26).Append("\n");
            sb.Append("  CertifyBox27: ").Append(CertifyBox27).Append("\n");
            sb.Append("  CertifyBox28A: ").Append(CertifyBox28A).Append("\n");
            sb.Append("  CertifyBox28B: ").Append(CertifyBox28B).Append("\n");
            sb.Append("  CertifyBox29A: ").Append(CertifyBox29A).Append("\n");
            sb.Append("  CertifyBox29B: ").Append(CertifyBox29B).Append("\n");
            sb.Append("  CertifyBox29C: ").Append(CertifyBox29C).Append("\n");
            sb.Append("  CertifyBox29D: ").Append(CertifyBox29D).Append("\n");
            sb.Append("  CertifyBox29E: ").Append(CertifyBox29E).Append("\n");
            sb.Append("  CertifyBox29F: ").Append(CertifyBox29F).Append("\n");
            sb.Append("  CertifyBox30: ").Append(CertifyBox30).Append("\n");
            sb.Append("  CertifyBox31: ").Append(CertifyBox31).Append("\n");
            sb.Append("  CertifyBox32: ").Append(CertifyBox32).Append("\n");
            sb.Append("  CertifyBox33: ").Append(CertifyBox33).Append("\n");
            sb.Append("  CertifyBox34: ").Append(CertifyBox34).Append("\n");
            sb.Append("  CertifyBox35: ").Append(CertifyBox35).Append("\n");
            sb.Append("  CertifyBox36: ").Append(CertifyBox36).Append("\n");
            sb.Append("  CertifyBox37A: ").Append(CertifyBox37A).Append("\n");
            sb.Append("  CertifyBox37B: ").Append(CertifyBox37B).Append("\n");
            sb.Append("  CertifyBox38: ").Append(CertifyBox38).Append("\n");
            sb.Append("  CertifyBox39: ").Append(CertifyBox39).Append("\n");
            sb.Append("  CertifyBox40A: ").Append(CertifyBox40A).Append("\n");
            sb.Append("  CertifyBox40B: ").Append(CertifyBox40B).Append("\n");
            sb.Append("  CertifyBox40C: ").Append(CertifyBox40C).Append("\n");
            sb.Append("  CertifyBox41: ").Append(CertifyBox41).Append("\n");
            sb.Append("  CertifyBox43: ").Append(CertifyBox43).Append("\n");
            sb.Append("  CertifyPart29Signature: ").Append(CertifyPart29Signature).Append("\n");
            sb.Append("  Part19FormationOrResolutionDate: ").Append(Part19FormationOrResolutionDate).Append("\n");
            sb.Append("  Part20FilingDate: ").Append(Part20FilingDate).Append("\n");
            sb.Append("  Part21DeterminationDate: ").Append(Part21DeterminationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryStatus: ").Append(EntryStatus).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  EntryStatusDate: ").Append(EntryStatusDate).Append("\n");
            sb.Append("  PdfJson: ").Append(PdfJson).Append("\n");
            sb.Append("  PdfVersion: ").Append(PdfVersion).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  AncestorId: ").Append(AncestorId).Append("\n");
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
