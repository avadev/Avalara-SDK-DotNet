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
    /// W-8 IMY form
    /// </summary>
    [DataContract(Name = "W8ImyFormDataModel")]
    public partial class W8ImyFormDataModel : IValidatableObject
    {
        /// <summary>
        /// Type of the form, always W8IMY for this model.
        /// </summary>
        /// <value>Type of the form, always W8IMY for this model.</value>
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
        /// Type of the form, always W8IMY for this model.
        /// </summary>
        /// <value>Type of the form, always W8IMY for this model.</value>
        /// <example>w8imy</example>
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
        /// Initializes a new instance of the <see cref="W8ImyFormDataModel" /> class.
        /// </summary>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="disregardedEntityChapter4FatcaStatus">The FATCA status for disregarded entities under Chapter 4..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="tin">The taxpayer identification number (TIN) of the employee..</param>
        /// <param name="typeOfTin">The type of TIN provided..</param>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="citizenshipCountry">The country of citizenship..</param>
        /// <param name="chapter3EntityType">The Chapter 3 entity type..</param>
        /// <param name="chapter4FatcaStatus">The Chapter 4 FATCA status..</param>
        /// <param name="residenceAddress">The residential address of the individual or entity..</param>
        /// <param name="residenceCity">The city of residence..</param>
        /// <param name="residenceState">The state of residence..</param>
        /// <param name="residencePostalCode">The postal code of the residence..</param>
        /// <param name="residenceCountry">The country of residence..</param>
        /// <param name="residenceIsMailing">Indicates whether the residence address is also the mailing address..</param>
        /// <param name="mailingAddress">The mailing address..</param>
        /// <param name="mailingCity">The city of the mailing address..</param>
        /// <param name="mailingState">The state of the mailing address..</param>
        /// <param name="mailingPostalCode">The postal code of the mailing address..</param>
        /// <param name="mailingCountry">The country of the mailing address..</param>
        /// <param name="disregardedEntity">The disregarded entity information..</param>
        /// <param name="disregardedAddress">The address for disregarded entities..</param>
        /// <param name="disregardedCity">The city for disregarded entities..</param>
        /// <param name="disregardedState">The state for disregarded entities..</param>
        /// <param name="disregardedPostalCode">The postal code for disregarded entities..</param>
        /// <param name="disregardedCountry">The country for disregarded entities..</param>
        /// <param name="disregardedEntityGiin">The GIIN for disregarded entities..</param>
        /// <param name="ein">The employer identification number (EIN)..</param>
        /// <param name="einType">The type of employer identification number (EIN)..</param>
        /// <param name="giin">The global intermediary identification number (GIIN)..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="certifyBox14">Indicates certification for box 14..</param>
        /// <param name="certifyBox15A">Indicates certification for box 15A..</param>
        /// <param name="certifyBox15B">Indicates certification for box 15B..</param>
        /// <param name="certifyBox15C">Indicates certification for box 15C..</param>
        /// <param name="certifyBox15D">Indicates certification for box 15D..</param>
        /// <param name="certifyBox15E">Indicates certification for box 15E..</param>
        /// <param name="certifyBox15F">Indicates certification for box 15F..</param>
        /// <param name="certifyBox15G">Indicates certification for box 15G..</param>
        /// <param name="certifyBox15H">Indicates certification for box 15H..</param>
        /// <param name="certifyBox15I">Indicates certification for box 15I..</param>
        /// <param name="certifyBox16A">Indicates certification for box 16A..</param>
        /// <param name="box16BQddCorporate">Indicates certification for box 16B as a QDD corporate entity..</param>
        /// <param name="box16BQddPartnership">Indicates certification for box 16B as a QDD partnership..</param>
        /// <param name="box16BQddDisregardedEntity">Indicates certification for box 16B as a QDD disregarded entity..</param>
        /// <param name="certifyBox17A">Indicates certification for box 17A..</param>
        /// <param name="certifyBox17B">Indicates certification for box 17B..</param>
        /// <param name="certifyBox17C">Indicates certification for box 17C..</param>
        /// <param name="certifyBox17D">Indicates certification for box 17D..</param>
        /// <param name="certifyBox17E">Indicates certification for box 17E..</param>
        /// <param name="certifyBox18A">Indicates certification for box 18A..</param>
        /// <param name="certifyBox18B">Indicates certification for box 18B..</param>
        /// <param name="certifyBox18C">Indicates certification for box 18C..</param>
        /// <param name="certifyBox18D">Indicates certification for box 18D..</param>
        /// <param name="certifyBox18E">Indicates certification for box 18E..</param>
        /// <param name="certifyBox18F">Indicates certification for box 18F..</param>
        /// <param name="certifyBox19A">Indicates certification for box 19A..</param>
        /// <param name="certifyBox19B">Indicates certification for box 19B..</param>
        /// <param name="certifyBox19C">Indicates certification for box 19C..</param>
        /// <param name="certifyBox19D">Indicates certification for box 19D..</param>
        /// <param name="certifyBox19E">Indicates certification for box 19E..</param>
        /// <param name="certifyBox19F">Indicates certification for box 19F..</param>
        /// <param name="certifyBox20">Indicates certification for box 20..</param>
        /// <param name="certifyBox21A">Indicates certification for box 21A..</param>
        /// <param name="certifyBox21B">Indicates certification for box 21B..</param>
        /// <param name="certifyBox21C">Indicates certification for box 21C..</param>
        /// <param name="certifyBox21D">Indicates certification for box 21D..</param>
        /// <param name="certifyBox21E">Indicates certification for box 21E..</param>
        /// <param name="certifyBox21F">Indicates certification for box 21F..</param>
        /// <param name="certifyBox22">Indicates certification for box 22..</param>
        /// <param name="box23ANameSponsoringEntity">The name of the sponsoring entity for box 23A..</param>
        /// <param name="certifyBox23B">Indicates certification for box 23B..</param>
        /// <param name="certifyBox23C">Indicates certification for box 23C..</param>
        /// <param name="certifyBox24A">Indicates certification for box 24A..</param>
        /// <param name="certifyBox24B">Indicates certification for box 24B..</param>
        /// <param name="certifyBox24C">Indicates certification for box 24C..</param>
        /// <param name="certifyBox25">Indicates certification for box 25..</param>
        /// <param name="certifyBox26">Indicates certification for box 26..</param>
        /// <param name="box27ANameSponsoringEntity">The name of the sponsoring entity for box 27A..</param>
        /// <param name="certifyBox27B">Indicates certification for box 27B..</param>
        /// <param name="certifyBox28">Indicates certification for box 28..</param>
        /// <param name="certifyBox29">Indicates certification for box 29..</param>
        /// <param name="certifyBox30A">Indicates certification for box 30A..</param>
        /// <param name="certifyBox30B">Indicates certification for box 30B..</param>
        /// <param name="certifyBox30C">Indicates certification for box 30C..</param>
        /// <param name="certifyBox31">Indicates certification for box 31..</param>
        /// <param name="certifyBox32">Indicates certification for box 32..</param>
        /// <param name="box32IgaCountry">The IGA country information for box 32..</param>
        /// <param name="box32IgaType">The IGA type information for box 32..</param>
        /// <param name="box32IgaTreatedAs">The IGA treatment information for box 32..</param>
        /// <param name="box32TrusteeOrSponsor">The trustee or sponsor information for box 32..</param>
        /// <param name="box32TrusteeIsForeign">Indicates whether the trustee is foreign for box 32..</param>
        /// <param name="certifyBox33A">Indicates certification for box 33A..</param>
        /// <param name="certifyBox33B">Indicates certification for box 33B..</param>
        /// <param name="certifyBox33C">Indicates certification for box 33C..</param>
        /// <param name="certifyBox33D">Indicates certification for box 33D..</param>
        /// <param name="certifyBox33E">Indicates certification for box 33E..</param>
        /// <param name="certifyBox33F">Indicates certification for box 33F..</param>
        /// <param name="certifyBox34">Indicates certification for box 34..</param>
        /// <param name="certifyBox35">Indicates certification for box 35..</param>
        /// <param name="certifyBox36">Indicates certification for box 36..</param>
        /// <param name="certifyBox37A">Indicates certification for box 37A..</param>
        /// <param name="box37ASecuritiesMarket">The securities market information for box 37A..</param>
        /// <param name="certifyBox37B">Indicates certification for box 37B..</param>
        /// <param name="box37BNameOfEntity">The name of the entity for box 37B..</param>
        /// <param name="box37BSecuritiesMarket">The securities market information for box 37B..</param>
        /// <param name="certifyBox38">Indicates certification for box 38..</param>
        /// <param name="certifyBox39">Indicates certification for box 39..</param>
        /// <param name="certifyBox40">Indicates certification for box 40..</param>
        /// <param name="box41SponsoringEntity">The sponsoring entity information for box 41..</param>
        /// <param name="certifyBox42">Indicates certification for box 42..</param>
        /// <param name="signerName">The name of the signer of the form..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="box35FormedOnDate">box35FormedOnDate.</param>
        /// <param name="box36FiledOnDate">box36FiledOnDate.</param>
        /// <param name="id">id.</param>
        /// <param name="entryStatus">entryStatus.</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
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
        public W8ImyFormDataModel(DateTime? signedDate = default(DateTime?), string disregardedEntityChapter4FatcaStatus = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), string displayName = default(string), string email = default(string), string tin = default(string), string typeOfTin = default(string), string name = default(string), string citizenshipCountry = default(string), string chapter3EntityType = default(string), string chapter4FatcaStatus = default(string), string residenceAddress = default(string), string residenceCity = default(string), string residenceState = default(string), string residencePostalCode = default(string), string residenceCountry = default(string), bool? residenceIsMailing = default(bool?), string mailingAddress = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingPostalCode = default(string), string mailingCountry = default(string), string disregardedEntity = default(string), string disregardedAddress = default(string), string disregardedCity = default(string), string disregardedState = default(string), string disregardedPostalCode = default(string), string disregardedCountry = default(string), string disregardedEntityGiin = default(string), string ein = default(string), string einType = default(string), string giin = default(string), string foreignTin = default(string), string referenceNumber = default(string), bool? certifyBox14 = default(bool?), bool? certifyBox15A = default(bool?), bool? certifyBox15B = default(bool?), bool? certifyBox15C = default(bool?), bool? certifyBox15D = default(bool?), bool? certifyBox15E = default(bool?), bool? certifyBox15F = default(bool?), bool? certifyBox15G = default(bool?), bool? certifyBox15H = default(bool?), bool? certifyBox15I = default(bool?), bool? certifyBox16A = default(bool?), bool? box16BQddCorporate = default(bool?), bool? box16BQddPartnership = default(bool?), bool? box16BQddDisregardedEntity = default(bool?), bool? certifyBox17A = default(bool?), bool? certifyBox17B = default(bool?), bool? certifyBox17C = default(bool?), bool? certifyBox17D = default(bool?), bool? certifyBox17E = default(bool?), bool? certifyBox18A = default(bool?), bool? certifyBox18B = default(bool?), bool? certifyBox18C = default(bool?), bool? certifyBox18D = default(bool?), bool? certifyBox18E = default(bool?), bool? certifyBox18F = default(bool?), bool? certifyBox19A = default(bool?), bool? certifyBox19B = default(bool?), bool? certifyBox19C = default(bool?), bool? certifyBox19D = default(bool?), bool? certifyBox19E = default(bool?), bool? certifyBox19F = default(bool?), bool? certifyBox20 = default(bool?), bool? certifyBox21A = default(bool?), bool? certifyBox21B = default(bool?), bool? certifyBox21C = default(bool?), bool? certifyBox21D = default(bool?), bool? certifyBox21E = default(bool?), bool? certifyBox21F = default(bool?), bool? certifyBox22 = default(bool?), string box23ANameSponsoringEntity = default(string), bool? certifyBox23B = default(bool?), bool? certifyBox23C = default(bool?), bool? certifyBox24A = default(bool?), bool? certifyBox24B = default(bool?), bool? certifyBox24C = default(bool?), bool? certifyBox25 = default(bool?), bool? certifyBox26 = default(bool?), string box27ANameSponsoringEntity = default(string), bool? certifyBox27B = default(bool?), bool? certifyBox28 = default(bool?), bool? certifyBox29 = default(bool?), bool? certifyBox30A = default(bool?), bool? certifyBox30B = default(bool?), bool? certifyBox30C = default(bool?), bool? certifyBox31 = default(bool?), bool? certifyBox32 = default(bool?), string box32IgaCountry = default(string), string box32IgaType = default(string), string box32IgaTreatedAs = default(string), string box32TrusteeOrSponsor = default(string), bool? box32TrusteeIsForeign = default(bool?), bool? certifyBox33A = default(bool?), bool? certifyBox33B = default(bool?), bool? certifyBox33C = default(bool?), bool? certifyBox33D = default(bool?), bool? certifyBox33E = default(bool?), bool? certifyBox33F = default(bool?), bool? certifyBox34 = default(bool?), bool? certifyBox35 = default(bool?), bool? certifyBox36 = default(bool?), bool? certifyBox37A = default(bool?), string box37ASecuritiesMarket = default(string), bool? certifyBox37B = default(bool?), string box37BNameOfEntity = default(string), string box37BSecuritiesMarket = default(string), bool? certifyBox38 = default(bool?), bool? certifyBox39 = default(bool?), bool? certifyBox40 = default(bool?), string box41SponsoringEntity = default(string), bool? certifyBox42 = default(bool?), string signerName = default(string), DateTime? eDeliveryConsentedAt = default(DateTime?), DateTime? box35FormedOnDate = default(DateTime?), DateTime? box36FiledOnDate = default(DateTime?), string id = default(string), string entryStatus = default(string), string referenceId = default(string), string companyId = default(string), bool? archived = default(bool?), DateTime? entryStatusDate = default(DateTime?), string pdfJson = default(string), string pdfVersion = default(string), string requestToken = default(string), string signature = default(string), bool? mobile = default(bool?), string appVersion = default(string), string platform = default(string), string osVersion = default(string), string ancestorId = default(string))
        {
            this.SignedDate = signedDate;
            this.DisregardedEntityChapter4FatcaStatus = disregardedEntityChapter4FatcaStatus;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DisplayName = displayName;
            this.Email = email;
            this.Tin = tin;
            this.TypeOfTin = typeOfTin;
            this.Name = name;
            this.CitizenshipCountry = citizenshipCountry;
            this.Chapter3EntityType = chapter3EntityType;
            this.Chapter4FatcaStatus = chapter4FatcaStatus;
            this.ResidenceAddress = residenceAddress;
            this.ResidenceCity = residenceCity;
            this.ResidenceState = residenceState;
            this.ResidencePostalCode = residencePostalCode;
            this.ResidenceCountry = residenceCountry;
            this.ResidenceIsMailing = residenceIsMailing;
            this.MailingAddress = mailingAddress;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingPostalCode = mailingPostalCode;
            this.MailingCountry = mailingCountry;
            this.DisregardedEntity = disregardedEntity;
            this.DisregardedAddress = disregardedAddress;
            this.DisregardedCity = disregardedCity;
            this.DisregardedState = disregardedState;
            this.DisregardedPostalCode = disregardedPostalCode;
            this.DisregardedCountry = disregardedCountry;
            this.DisregardedEntityGiin = disregardedEntityGiin;
            this.Ein = ein;
            this.EinType = einType;
            this.Giin = giin;
            this.ForeignTin = foreignTin;
            this.ReferenceNumber = referenceNumber;
            this.CertifyBox14 = certifyBox14;
            this.CertifyBox15A = certifyBox15A;
            this.CertifyBox15B = certifyBox15B;
            this.CertifyBox15C = certifyBox15C;
            this.CertifyBox15D = certifyBox15D;
            this.CertifyBox15E = certifyBox15E;
            this.CertifyBox15F = certifyBox15F;
            this.CertifyBox15G = certifyBox15G;
            this.CertifyBox15H = certifyBox15H;
            this.CertifyBox15I = certifyBox15I;
            this.CertifyBox16A = certifyBox16A;
            this.Box16BQddCorporate = box16BQddCorporate;
            this.Box16BQddPartnership = box16BQddPartnership;
            this.Box16BQddDisregardedEntity = box16BQddDisregardedEntity;
            this.CertifyBox17A = certifyBox17A;
            this.CertifyBox17B = certifyBox17B;
            this.CertifyBox17C = certifyBox17C;
            this.CertifyBox17D = certifyBox17D;
            this.CertifyBox17E = certifyBox17E;
            this.CertifyBox18A = certifyBox18A;
            this.CertifyBox18B = certifyBox18B;
            this.CertifyBox18C = certifyBox18C;
            this.CertifyBox18D = certifyBox18D;
            this.CertifyBox18E = certifyBox18E;
            this.CertifyBox18F = certifyBox18F;
            this.CertifyBox19A = certifyBox19A;
            this.CertifyBox19B = certifyBox19B;
            this.CertifyBox19C = certifyBox19C;
            this.CertifyBox19D = certifyBox19D;
            this.CertifyBox19E = certifyBox19E;
            this.CertifyBox19F = certifyBox19F;
            this.CertifyBox20 = certifyBox20;
            this.CertifyBox21A = certifyBox21A;
            this.CertifyBox21B = certifyBox21B;
            this.CertifyBox21C = certifyBox21C;
            this.CertifyBox21D = certifyBox21D;
            this.CertifyBox21E = certifyBox21E;
            this.CertifyBox21F = certifyBox21F;
            this.CertifyBox22 = certifyBox22;
            this.Box23ANameSponsoringEntity = box23ANameSponsoringEntity;
            this.CertifyBox23B = certifyBox23B;
            this.CertifyBox23C = certifyBox23C;
            this.CertifyBox24A = certifyBox24A;
            this.CertifyBox24B = certifyBox24B;
            this.CertifyBox24C = certifyBox24C;
            this.CertifyBox25 = certifyBox25;
            this.CertifyBox26 = certifyBox26;
            this.Box27ANameSponsoringEntity = box27ANameSponsoringEntity;
            this.CertifyBox27B = certifyBox27B;
            this.CertifyBox28 = certifyBox28;
            this.CertifyBox29 = certifyBox29;
            this.CertifyBox30A = certifyBox30A;
            this.CertifyBox30B = certifyBox30B;
            this.CertifyBox30C = certifyBox30C;
            this.CertifyBox31 = certifyBox31;
            this.CertifyBox32 = certifyBox32;
            this.Box32IgaCountry = box32IgaCountry;
            this.Box32IgaType = box32IgaType;
            this.Box32IgaTreatedAs = box32IgaTreatedAs;
            this.Box32TrusteeOrSponsor = box32TrusteeOrSponsor;
            this.Box32TrusteeIsForeign = box32TrusteeIsForeign;
            this.CertifyBox33A = certifyBox33A;
            this.CertifyBox33B = certifyBox33B;
            this.CertifyBox33C = certifyBox33C;
            this.CertifyBox33D = certifyBox33D;
            this.CertifyBox33E = certifyBox33E;
            this.CertifyBox33F = certifyBox33F;
            this.CertifyBox34 = certifyBox34;
            this.CertifyBox35 = certifyBox35;
            this.CertifyBox36 = certifyBox36;
            this.CertifyBox37A = certifyBox37A;
            this.Box37ASecuritiesMarket = box37ASecuritiesMarket;
            this.CertifyBox37B = certifyBox37B;
            this.Box37BNameOfEntity = box37BNameOfEntity;
            this.Box37BSecuritiesMarket = box37BSecuritiesMarket;
            this.CertifyBox38 = certifyBox38;
            this.CertifyBox39 = certifyBox39;
            this.CertifyBox40 = certifyBox40;
            this.Box41SponsoringEntity = box41SponsoringEntity;
            this.CertifyBox42 = certifyBox42;
            this.SignerName = signerName;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.Box35FormedOnDate = box35FormedOnDate;
            this.Box36FiledOnDate = box36FiledOnDate;
            this.Id = id;
            this.EntryStatus = entryStatus;
            this.ReferenceId = referenceId;
            this.CompanyId = companyId;
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
        /// <example>2023-06-10T00:00Z</example>
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
        /// <example>2023-06-05T09:00Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The last updated date of the form.
        /// </summary>
        /// <value>The last updated date of the form.</value>
        /// <example>2023-06-20T14:30Z</example>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The display name associated with the form.
        /// </summary>
        /// <value>The display name associated with the form.</value>
        /// <example>Global Financials</example>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        /// <example>contact@globalfinancials.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN) of the employee.
        /// </summary>
        /// <value>The taxpayer identification number (TIN) of the employee.</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        [DataMember(Name = "typeOfTin", EmitDefaultValue = true)]
        public string TypeOfTin { get; set; }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>Global Financials LLC</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The country of citizenship.
        /// </summary>
        /// <value>The country of citizenship.</value>
        /// <example>USA</example>
        [DataMember(Name = "citizenshipCountry", EmitDefaultValue = true)]
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// The Chapter 3 entity type.
        /// </summary>
        /// <value>The Chapter 3 entity type.</value>
        /// <example>Partnership</example>
        [DataMember(Name = "chapter3EntityType", EmitDefaultValue = true)]
        public string Chapter3EntityType { get; set; }

        /// <summary>
        /// The Chapter 4 FATCA status.
        /// </summary>
        /// <value>The Chapter 4 FATCA status.</value>
        /// <example>Compliant</example>
        [DataMember(Name = "chapter4FatcaStatus", EmitDefaultValue = true)]
        public string Chapter4FatcaStatus { get; set; }

        /// <summary>
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        /// <example>321 Wealth Ave</example>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = true)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        /// <example>Finance City</example>
        [DataMember(Name = "residenceCity", EmitDefaultValue = true)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The state of residence.
        /// </summary>
        /// <value>The state of residence.</value>
        /// <example>TX</example>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// The postal code of the residence.
        /// </summary>
        /// <value>The postal code of the residence.</value>
        /// <example>75001</example>
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
        /// Indicates whether the residence address is also the mailing address.
        /// </summary>
        /// <value>Indicates whether the residence address is also the mailing address.</value>
        [DataMember(Name = "residenceIsMailing", EmitDefaultValue = true)]
        public bool? ResidenceIsMailing { get; set; }

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
        /// The postal code of the mailing address.
        /// </summary>
        /// <value>The postal code of the mailing address.</value>
        /// <example>75002</example>
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
        /// The disregarded entity information.
        /// </summary>
        /// <value>The disregarded entity information.</value>
        /// <example>Subsidiary Finance</example>
        [DataMember(Name = "disregardedEntity", EmitDefaultValue = true)]
        public string DisregardedEntity { get; set; }

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
        /// The GIIN for disregarded entities.
        /// </summary>
        /// <value>The GIIN for disregarded entities.</value>
        /// <example>GIIN78901234</example>
        [DataMember(Name = "disregardedEntityGiin", EmitDefaultValue = true)]
        public string DisregardedEntityGiin { get; set; }

        /// <summary>
        /// The employer identification number (EIN).
        /// </summary>
        /// <value>The employer identification number (EIN).</value>
        [DataMember(Name = "ein", EmitDefaultValue = true)]
        public string Ein { get; set; }

        /// <summary>
        /// The type of employer identification number (EIN).
        /// </summary>
        /// <value>The type of employer identification number (EIN).</value>
        [DataMember(Name = "einType", EmitDefaultValue = true)]
        public string EinType { get; set; }

        /// <summary>
        /// The global intermediary identification number (GIIN).
        /// </summary>
        /// <value>The global intermediary identification number (GIIN).</value>
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
        /// Indicates certification for box 14.
        /// </summary>
        /// <value>Indicates certification for box 14.</value>
        [DataMember(Name = "certifyBox14", EmitDefaultValue = true)]
        public bool? CertifyBox14 { get; set; }

        /// <summary>
        /// Indicates certification for box 15A.
        /// </summary>
        /// <value>Indicates certification for box 15A.</value>
        [DataMember(Name = "certifyBox15A", EmitDefaultValue = true)]
        public bool? CertifyBox15A { get; set; }

        /// <summary>
        /// Indicates certification for box 15B.
        /// </summary>
        /// <value>Indicates certification for box 15B.</value>
        [DataMember(Name = "certifyBox15B", EmitDefaultValue = true)]
        public bool? CertifyBox15B { get; set; }

        /// <summary>
        /// Indicates certification for box 15C.
        /// </summary>
        /// <value>Indicates certification for box 15C.</value>
        [DataMember(Name = "certifyBox15C", EmitDefaultValue = true)]
        public bool? CertifyBox15C { get; set; }

        /// <summary>
        /// Indicates certification for box 15D.
        /// </summary>
        /// <value>Indicates certification for box 15D.</value>
        [DataMember(Name = "certifyBox15D", EmitDefaultValue = true)]
        public bool? CertifyBox15D { get; set; }

        /// <summary>
        /// Indicates certification for box 15E.
        /// </summary>
        /// <value>Indicates certification for box 15E.</value>
        [DataMember(Name = "certifyBox15E", EmitDefaultValue = true)]
        public bool? CertifyBox15E { get; set; }

        /// <summary>
        /// Indicates certification for box 15F.
        /// </summary>
        /// <value>Indicates certification for box 15F.</value>
        [DataMember(Name = "certifyBox15F", EmitDefaultValue = true)]
        public bool? CertifyBox15F { get; set; }

        /// <summary>
        /// Indicates certification for box 15G.
        /// </summary>
        /// <value>Indicates certification for box 15G.</value>
        [DataMember(Name = "certifyBox15G", EmitDefaultValue = true)]
        public bool? CertifyBox15G { get; set; }

        /// <summary>
        /// Indicates certification for box 15H.
        /// </summary>
        /// <value>Indicates certification for box 15H.</value>
        [DataMember(Name = "certifyBox15H", EmitDefaultValue = true)]
        public bool? CertifyBox15H { get; set; }

        /// <summary>
        /// Indicates certification for box 15I.
        /// </summary>
        /// <value>Indicates certification for box 15I.</value>
        [DataMember(Name = "certifyBox15I", EmitDefaultValue = true)]
        public bool? CertifyBox15I { get; set; }

        /// <summary>
        /// Indicates certification for box 16A.
        /// </summary>
        /// <value>Indicates certification for box 16A.</value>
        [DataMember(Name = "certifyBox16A", EmitDefaultValue = true)]
        public bool? CertifyBox16A { get; set; }

        /// <summary>
        /// Indicates certification for box 16B as a QDD corporate entity.
        /// </summary>
        /// <value>Indicates certification for box 16B as a QDD corporate entity.</value>
        [DataMember(Name = "box16BQddCorporate", EmitDefaultValue = true)]
        public bool? Box16BQddCorporate { get; set; }

        /// <summary>
        /// Indicates certification for box 16B as a QDD partnership.
        /// </summary>
        /// <value>Indicates certification for box 16B as a QDD partnership.</value>
        [DataMember(Name = "box16BQddPartnership", EmitDefaultValue = true)]
        public bool? Box16BQddPartnership { get; set; }

        /// <summary>
        /// Indicates certification for box 16B as a QDD disregarded entity.
        /// </summary>
        /// <value>Indicates certification for box 16B as a QDD disregarded entity.</value>
        [DataMember(Name = "box16BQddDisregardedEntity", EmitDefaultValue = true)]
        public bool? Box16BQddDisregardedEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 17A.
        /// </summary>
        /// <value>Indicates certification for box 17A.</value>
        [DataMember(Name = "certifyBox17A", EmitDefaultValue = true)]
        public bool? CertifyBox17A { get; set; }

        /// <summary>
        /// Indicates certification for box 17B.
        /// </summary>
        /// <value>Indicates certification for box 17B.</value>
        [DataMember(Name = "certifyBox17B", EmitDefaultValue = true)]
        public bool? CertifyBox17B { get; set; }

        /// <summary>
        /// Indicates certification for box 17C.
        /// </summary>
        /// <value>Indicates certification for box 17C.</value>
        [DataMember(Name = "certifyBox17C", EmitDefaultValue = true)]
        public bool? CertifyBox17C { get; set; }

        /// <summary>
        /// Indicates certification for box 17D.
        /// </summary>
        /// <value>Indicates certification for box 17D.</value>
        [DataMember(Name = "certifyBox17D", EmitDefaultValue = true)]
        public bool? CertifyBox17D { get; set; }

        /// <summary>
        /// Indicates certification for box 17E.
        /// </summary>
        /// <value>Indicates certification for box 17E.</value>
        [DataMember(Name = "certifyBox17E", EmitDefaultValue = true)]
        public bool? CertifyBox17E { get; set; }

        /// <summary>
        /// Indicates certification for box 18A.
        /// </summary>
        /// <value>Indicates certification for box 18A.</value>
        [DataMember(Name = "certifyBox18A", EmitDefaultValue = true)]
        public bool? CertifyBox18A { get; set; }

        /// <summary>
        /// Indicates certification for box 18B.
        /// </summary>
        /// <value>Indicates certification for box 18B.</value>
        [DataMember(Name = "certifyBox18B", EmitDefaultValue = true)]
        public bool? CertifyBox18B { get; set; }

        /// <summary>
        /// Indicates certification for box 18C.
        /// </summary>
        /// <value>Indicates certification for box 18C.</value>
        [DataMember(Name = "certifyBox18C", EmitDefaultValue = true)]
        public bool? CertifyBox18C { get; set; }

        /// <summary>
        /// Indicates certification for box 18D.
        /// </summary>
        /// <value>Indicates certification for box 18D.</value>
        [DataMember(Name = "certifyBox18D", EmitDefaultValue = true)]
        public bool? CertifyBox18D { get; set; }

        /// <summary>
        /// Indicates certification for box 18E.
        /// </summary>
        /// <value>Indicates certification for box 18E.</value>
        [DataMember(Name = "certifyBox18E", EmitDefaultValue = true)]
        public bool? CertifyBox18E { get; set; }

        /// <summary>
        /// Indicates certification for box 18F.
        /// </summary>
        /// <value>Indicates certification for box 18F.</value>
        [DataMember(Name = "certifyBox18F", EmitDefaultValue = true)]
        public bool? CertifyBox18F { get; set; }

        /// <summary>
        /// Indicates certification for box 19A.
        /// </summary>
        /// <value>Indicates certification for box 19A.</value>
        [DataMember(Name = "certifyBox19A", EmitDefaultValue = true)]
        public bool? CertifyBox19A { get; set; }

        /// <summary>
        /// Indicates certification for box 19B.
        /// </summary>
        /// <value>Indicates certification for box 19B.</value>
        [DataMember(Name = "certifyBox19B", EmitDefaultValue = true)]
        public bool? CertifyBox19B { get; set; }

        /// <summary>
        /// Indicates certification for box 19C.
        /// </summary>
        /// <value>Indicates certification for box 19C.</value>
        [DataMember(Name = "certifyBox19C", EmitDefaultValue = true)]
        public bool? CertifyBox19C { get; set; }

        /// <summary>
        /// Indicates certification for box 19D.
        /// </summary>
        /// <value>Indicates certification for box 19D.</value>
        [DataMember(Name = "certifyBox19D", EmitDefaultValue = true)]
        public bool? CertifyBox19D { get; set; }

        /// <summary>
        /// Indicates certification for box 19E.
        /// </summary>
        /// <value>Indicates certification for box 19E.</value>
        [DataMember(Name = "certifyBox19E", EmitDefaultValue = true)]
        public bool? CertifyBox19E { get; set; }

        /// <summary>
        /// Indicates certification for box 19F.
        /// </summary>
        /// <value>Indicates certification for box 19F.</value>
        [DataMember(Name = "certifyBox19F", EmitDefaultValue = true)]
        public bool? CertifyBox19F { get; set; }

        /// <summary>
        /// Indicates certification for box 20.
        /// </summary>
        /// <value>Indicates certification for box 20.</value>
        [DataMember(Name = "certifyBox20", EmitDefaultValue = true)]
        public bool? CertifyBox20 { get; set; }

        /// <summary>
        /// Indicates certification for box 21A.
        /// </summary>
        /// <value>Indicates certification for box 21A.</value>
        [DataMember(Name = "certifyBox21A", EmitDefaultValue = true)]
        public bool? CertifyBox21A { get; set; }

        /// <summary>
        /// Indicates certification for box 21B.
        /// </summary>
        /// <value>Indicates certification for box 21B.</value>
        [DataMember(Name = "certifyBox21B", EmitDefaultValue = true)]
        public bool? CertifyBox21B { get; set; }

        /// <summary>
        /// Indicates certification for box 21C.
        /// </summary>
        /// <value>Indicates certification for box 21C.</value>
        [DataMember(Name = "certifyBox21C", EmitDefaultValue = true)]
        public bool? CertifyBox21C { get; set; }

        /// <summary>
        /// Indicates certification for box 21D.
        /// </summary>
        /// <value>Indicates certification for box 21D.</value>
        [DataMember(Name = "certifyBox21D", EmitDefaultValue = true)]
        public bool? CertifyBox21D { get; set; }

        /// <summary>
        /// Indicates certification for box 21E.
        /// </summary>
        /// <value>Indicates certification for box 21E.</value>
        [DataMember(Name = "certifyBox21E", EmitDefaultValue = true)]
        public bool? CertifyBox21E { get; set; }

        /// <summary>
        /// Indicates certification for box 21F.
        /// </summary>
        /// <value>Indicates certification for box 21F.</value>
        [DataMember(Name = "certifyBox21F", EmitDefaultValue = true)]
        public bool? CertifyBox21F { get; set; }

        /// <summary>
        /// Indicates certification for box 22.
        /// </summary>
        /// <value>Indicates certification for box 22.</value>
        [DataMember(Name = "certifyBox22", EmitDefaultValue = true)]
        public bool? CertifyBox22 { get; set; }

        /// <summary>
        /// The name of the sponsoring entity for box 23A.
        /// </summary>
        /// <value>The name of the sponsoring entity for box 23A.</value>
        [DataMember(Name = "box23ANameSponsoringEntity", EmitDefaultValue = true)]
        public string Box23ANameSponsoringEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 23B.
        /// </summary>
        /// <value>Indicates certification for box 23B.</value>
        [DataMember(Name = "certifyBox23B", EmitDefaultValue = true)]
        public bool? CertifyBox23B { get; set; }

        /// <summary>
        /// Indicates certification for box 23C.
        /// </summary>
        /// <value>Indicates certification for box 23C.</value>
        [DataMember(Name = "certifyBox23C", EmitDefaultValue = true)]
        public bool? CertifyBox23C { get; set; }

        /// <summary>
        /// Indicates certification for box 24A.
        /// </summary>
        /// <value>Indicates certification for box 24A.</value>
        [DataMember(Name = "certifyBox24A", EmitDefaultValue = true)]
        public bool? CertifyBox24A { get; set; }

        /// <summary>
        /// Indicates certification for box 24B.
        /// </summary>
        /// <value>Indicates certification for box 24B.</value>
        [DataMember(Name = "certifyBox24B", EmitDefaultValue = true)]
        public bool? CertifyBox24B { get; set; }

        /// <summary>
        /// Indicates certification for box 24C.
        /// </summary>
        /// <value>Indicates certification for box 24C.</value>
        [DataMember(Name = "certifyBox24C", EmitDefaultValue = true)]
        public bool? CertifyBox24C { get; set; }

        /// <summary>
        /// Indicates certification for box 25.
        /// </summary>
        /// <value>Indicates certification for box 25.</value>
        [DataMember(Name = "certifyBox25", EmitDefaultValue = true)]
        public bool? CertifyBox25 { get; set; }

        /// <summary>
        /// Indicates certification for box 26.
        /// </summary>
        /// <value>Indicates certification for box 26.</value>
        [DataMember(Name = "certifyBox26", EmitDefaultValue = true)]
        public bool? CertifyBox26 { get; set; }

        /// <summary>
        /// The name of the sponsoring entity for box 27A.
        /// </summary>
        /// <value>The name of the sponsoring entity for box 27A.</value>
        [DataMember(Name = "box27ANameSponsoringEntity", EmitDefaultValue = true)]
        public string Box27ANameSponsoringEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 27B.
        /// </summary>
        /// <value>Indicates certification for box 27B.</value>
        [DataMember(Name = "certifyBox27B", EmitDefaultValue = true)]
        public bool? CertifyBox27B { get; set; }

        /// <summary>
        /// Indicates certification for box 28.
        /// </summary>
        /// <value>Indicates certification for box 28.</value>
        [DataMember(Name = "certifyBox28", EmitDefaultValue = true)]
        public bool? CertifyBox28 { get; set; }

        /// <summary>
        /// Indicates certification for box 29.
        /// </summary>
        /// <value>Indicates certification for box 29.</value>
        [DataMember(Name = "certifyBox29", EmitDefaultValue = true)]
        public bool? CertifyBox29 { get; set; }

        /// <summary>
        /// Indicates certification for box 30A.
        /// </summary>
        /// <value>Indicates certification for box 30A.</value>
        [DataMember(Name = "certifyBox30A", EmitDefaultValue = true)]
        public bool? CertifyBox30A { get; set; }

        /// <summary>
        /// Indicates certification for box 30B.
        /// </summary>
        /// <value>Indicates certification for box 30B.</value>
        [DataMember(Name = "certifyBox30B", EmitDefaultValue = true)]
        public bool? CertifyBox30B { get; set; }

        /// <summary>
        /// Indicates certification for box 30C.
        /// </summary>
        /// <value>Indicates certification for box 30C.</value>
        [DataMember(Name = "certifyBox30C", EmitDefaultValue = true)]
        public bool? CertifyBox30C { get; set; }

        /// <summary>
        /// Indicates certification for box 31.
        /// </summary>
        /// <value>Indicates certification for box 31.</value>
        [DataMember(Name = "certifyBox31", EmitDefaultValue = true)]
        public bool? CertifyBox31 { get; set; }

        /// <summary>
        /// Indicates certification for box 32.
        /// </summary>
        /// <value>Indicates certification for box 32.</value>
        [DataMember(Name = "certifyBox32", EmitDefaultValue = true)]
        public bool? CertifyBox32 { get; set; }

        /// <summary>
        /// The IGA country information for box 32.
        /// </summary>
        /// <value>The IGA country information for box 32.</value>
        [DataMember(Name = "box32IgaCountry", EmitDefaultValue = true)]
        public string Box32IgaCountry { get; set; }

        /// <summary>
        /// The IGA type information for box 32.
        /// </summary>
        /// <value>The IGA type information for box 32.</value>
        [DataMember(Name = "box32IgaType", EmitDefaultValue = true)]
        public string Box32IgaType { get; set; }

        /// <summary>
        /// The IGA treatment information for box 32.
        /// </summary>
        /// <value>The IGA treatment information for box 32.</value>
        [DataMember(Name = "box32IgaTreatedAs", EmitDefaultValue = true)]
        public string Box32IgaTreatedAs { get; set; }

        /// <summary>
        /// The trustee or sponsor information for box 32.
        /// </summary>
        /// <value>The trustee or sponsor information for box 32.</value>
        [DataMember(Name = "box32TrusteeOrSponsor", EmitDefaultValue = true)]
        public string Box32TrusteeOrSponsor { get; set; }

        /// <summary>
        /// Indicates whether the trustee is foreign for box 32.
        /// </summary>
        /// <value>Indicates whether the trustee is foreign for box 32.</value>
        [DataMember(Name = "box32TrusteeIsForeign", EmitDefaultValue = true)]
        public bool? Box32TrusteeIsForeign { get; set; }

        /// <summary>
        /// Indicates certification for box 33A.
        /// </summary>
        /// <value>Indicates certification for box 33A.</value>
        [DataMember(Name = "certifyBox33A", EmitDefaultValue = true)]
        public bool? CertifyBox33A { get; set; }

        /// <summary>
        /// Indicates certification for box 33B.
        /// </summary>
        /// <value>Indicates certification for box 33B.</value>
        [DataMember(Name = "certifyBox33B", EmitDefaultValue = true)]
        public bool? CertifyBox33B { get; set; }

        /// <summary>
        /// Indicates certification for box 33C.
        /// </summary>
        /// <value>Indicates certification for box 33C.</value>
        [DataMember(Name = "certifyBox33C", EmitDefaultValue = true)]
        public bool? CertifyBox33C { get; set; }

        /// <summary>
        /// Indicates certification for box 33D.
        /// </summary>
        /// <value>Indicates certification for box 33D.</value>
        [DataMember(Name = "certifyBox33D", EmitDefaultValue = true)]
        public bool? CertifyBox33D { get; set; }

        /// <summary>
        /// Indicates certification for box 33E.
        /// </summary>
        /// <value>Indicates certification for box 33E.</value>
        [DataMember(Name = "certifyBox33E", EmitDefaultValue = true)]
        public bool? CertifyBox33E { get; set; }

        /// <summary>
        /// Indicates certification for box 33F.
        /// </summary>
        /// <value>Indicates certification for box 33F.</value>
        [DataMember(Name = "certifyBox33F", EmitDefaultValue = true)]
        public bool? CertifyBox33F { get; set; }

        /// <summary>
        /// Indicates certification for box 34.
        /// </summary>
        /// <value>Indicates certification for box 34.</value>
        [DataMember(Name = "certifyBox34", EmitDefaultValue = true)]
        public bool? CertifyBox34 { get; set; }

        /// <summary>
        /// Indicates certification for box 35.
        /// </summary>
        /// <value>Indicates certification for box 35.</value>
        [DataMember(Name = "certifyBox35", EmitDefaultValue = true)]
        public bool? CertifyBox35 { get; set; }

        /// <summary>
        /// Indicates certification for box 36.
        /// </summary>
        /// <value>Indicates certification for box 36.</value>
        [DataMember(Name = "certifyBox36", EmitDefaultValue = true)]
        public bool? CertifyBox36 { get; set; }

        /// <summary>
        /// Indicates certification for box 37A.
        /// </summary>
        /// <value>Indicates certification for box 37A.</value>
        [DataMember(Name = "certifyBox37A", EmitDefaultValue = true)]
        public bool? CertifyBox37A { get; set; }

        /// <summary>
        /// The securities market information for box 37A.
        /// </summary>
        /// <value>The securities market information for box 37A.</value>
        [DataMember(Name = "box37ASecuritiesMarket", EmitDefaultValue = true)]
        public string Box37ASecuritiesMarket { get; set; }

        /// <summary>
        /// Indicates certification for box 37B.
        /// </summary>
        /// <value>Indicates certification for box 37B.</value>
        [DataMember(Name = "certifyBox37B", EmitDefaultValue = true)]
        public bool? CertifyBox37B { get; set; }

        /// <summary>
        /// The name of the entity for box 37B.
        /// </summary>
        /// <value>The name of the entity for box 37B.</value>
        [DataMember(Name = "box37BNameOfEntity", EmitDefaultValue = true)]
        public string Box37BNameOfEntity { get; set; }

        /// <summary>
        /// The securities market information for box 37B.
        /// </summary>
        /// <value>The securities market information for box 37B.</value>
        [DataMember(Name = "box37BSecuritiesMarket", EmitDefaultValue = true)]
        public string Box37BSecuritiesMarket { get; set; }

        /// <summary>
        /// Indicates certification for box 38.
        /// </summary>
        /// <value>Indicates certification for box 38.</value>
        [DataMember(Name = "certifyBox38", EmitDefaultValue = true)]
        public bool? CertifyBox38 { get; set; }

        /// <summary>
        /// Indicates certification for box 39.
        /// </summary>
        /// <value>Indicates certification for box 39.</value>
        [DataMember(Name = "certifyBox39", EmitDefaultValue = true)]
        public bool? CertifyBox39 { get; set; }

        /// <summary>
        /// Indicates certification for box 40.
        /// </summary>
        /// <value>Indicates certification for box 40.</value>
        [DataMember(Name = "certifyBox40", EmitDefaultValue = true)]
        public bool? CertifyBox40 { get; set; }

        /// <summary>
        /// The sponsoring entity information for box 41.
        /// </summary>
        /// <value>The sponsoring entity information for box 41.</value>
        [DataMember(Name = "box41SponsoringEntity", EmitDefaultValue = true)]
        public string Box41SponsoringEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 42.
        /// </summary>
        /// <value>Indicates certification for box 42.</value>
        [DataMember(Name = "certifyBox42", EmitDefaultValue = true)]
        public bool? CertifyBox42 { get; set; }

        /// <summary>
        /// The name of the signer of the form.
        /// </summary>
        /// <value>The name of the signer of the form.</value>
        /// <example>Richard Roe</example>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        /// <example>2023-06-10T11:00Z</example>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// Gets or Sets Box35FormedOnDate
        /// </summary>
        [DataMember(Name = "box35FormedOnDate", EmitDefaultValue = true)]
        public DateTime? Box35FormedOnDate { get; set; }

        /// <summary>
        /// Gets or Sets Box36FiledOnDate
        /// </summary>
        [DataMember(Name = "box36FiledOnDate", EmitDefaultValue = true)]
        public DateTime? Box36FiledOnDate { get; set; }

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
            sb.Append("class W8ImyFormDataModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SignedDate: ").Append(SignedDate).Append("\n");
            sb.Append("  DisregardedEntityChapter4FatcaStatus: ").Append(DisregardedEntityChapter4FatcaStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  TypeOfTin: ").Append(TypeOfTin).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  Chapter3EntityType: ").Append(Chapter3EntityType).Append("\n");
            sb.Append("  Chapter4FatcaStatus: ").Append(Chapter4FatcaStatus).Append("\n");
            sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
            sb.Append("  ResidenceCity: ").Append(ResidenceCity).Append("\n");
            sb.Append("  ResidenceState: ").Append(ResidenceState).Append("\n");
            sb.Append("  ResidencePostalCode: ").Append(ResidencePostalCode).Append("\n");
            sb.Append("  ResidenceCountry: ").Append(ResidenceCountry).Append("\n");
            sb.Append("  ResidenceIsMailing: ").Append(ResidenceIsMailing).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  MailingCity: ").Append(MailingCity).Append("\n");
            sb.Append("  MailingState: ").Append(MailingState).Append("\n");
            sb.Append("  MailingPostalCode: ").Append(MailingPostalCode).Append("\n");
            sb.Append("  MailingCountry: ").Append(MailingCountry).Append("\n");
            sb.Append("  DisregardedEntity: ").Append(DisregardedEntity).Append("\n");
            sb.Append("  DisregardedAddress: ").Append(DisregardedAddress).Append("\n");
            sb.Append("  DisregardedCity: ").Append(DisregardedCity).Append("\n");
            sb.Append("  DisregardedState: ").Append(DisregardedState).Append("\n");
            sb.Append("  DisregardedPostalCode: ").Append(DisregardedPostalCode).Append("\n");
            sb.Append("  DisregardedCountry: ").Append(DisregardedCountry).Append("\n");
            sb.Append("  DisregardedEntityGiin: ").Append(DisregardedEntityGiin).Append("\n");
            sb.Append("  Ein: ").Append(Ein).Append("\n");
            sb.Append("  EinType: ").Append(EinType).Append("\n");
            sb.Append("  Giin: ").Append(Giin).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  CertifyBox14: ").Append(CertifyBox14).Append("\n");
            sb.Append("  CertifyBox15A: ").Append(CertifyBox15A).Append("\n");
            sb.Append("  CertifyBox15B: ").Append(CertifyBox15B).Append("\n");
            sb.Append("  CertifyBox15C: ").Append(CertifyBox15C).Append("\n");
            sb.Append("  CertifyBox15D: ").Append(CertifyBox15D).Append("\n");
            sb.Append("  CertifyBox15E: ").Append(CertifyBox15E).Append("\n");
            sb.Append("  CertifyBox15F: ").Append(CertifyBox15F).Append("\n");
            sb.Append("  CertifyBox15G: ").Append(CertifyBox15G).Append("\n");
            sb.Append("  CertifyBox15H: ").Append(CertifyBox15H).Append("\n");
            sb.Append("  CertifyBox15I: ").Append(CertifyBox15I).Append("\n");
            sb.Append("  CertifyBox16A: ").Append(CertifyBox16A).Append("\n");
            sb.Append("  Box16BQddCorporate: ").Append(Box16BQddCorporate).Append("\n");
            sb.Append("  Box16BQddPartnership: ").Append(Box16BQddPartnership).Append("\n");
            sb.Append("  Box16BQddDisregardedEntity: ").Append(Box16BQddDisregardedEntity).Append("\n");
            sb.Append("  CertifyBox17A: ").Append(CertifyBox17A).Append("\n");
            sb.Append("  CertifyBox17B: ").Append(CertifyBox17B).Append("\n");
            sb.Append("  CertifyBox17C: ").Append(CertifyBox17C).Append("\n");
            sb.Append("  CertifyBox17D: ").Append(CertifyBox17D).Append("\n");
            sb.Append("  CertifyBox17E: ").Append(CertifyBox17E).Append("\n");
            sb.Append("  CertifyBox18A: ").Append(CertifyBox18A).Append("\n");
            sb.Append("  CertifyBox18B: ").Append(CertifyBox18B).Append("\n");
            sb.Append("  CertifyBox18C: ").Append(CertifyBox18C).Append("\n");
            sb.Append("  CertifyBox18D: ").Append(CertifyBox18D).Append("\n");
            sb.Append("  CertifyBox18E: ").Append(CertifyBox18E).Append("\n");
            sb.Append("  CertifyBox18F: ").Append(CertifyBox18F).Append("\n");
            sb.Append("  CertifyBox19A: ").Append(CertifyBox19A).Append("\n");
            sb.Append("  CertifyBox19B: ").Append(CertifyBox19B).Append("\n");
            sb.Append("  CertifyBox19C: ").Append(CertifyBox19C).Append("\n");
            sb.Append("  CertifyBox19D: ").Append(CertifyBox19D).Append("\n");
            sb.Append("  CertifyBox19E: ").Append(CertifyBox19E).Append("\n");
            sb.Append("  CertifyBox19F: ").Append(CertifyBox19F).Append("\n");
            sb.Append("  CertifyBox20: ").Append(CertifyBox20).Append("\n");
            sb.Append("  CertifyBox21A: ").Append(CertifyBox21A).Append("\n");
            sb.Append("  CertifyBox21B: ").Append(CertifyBox21B).Append("\n");
            sb.Append("  CertifyBox21C: ").Append(CertifyBox21C).Append("\n");
            sb.Append("  CertifyBox21D: ").Append(CertifyBox21D).Append("\n");
            sb.Append("  CertifyBox21E: ").Append(CertifyBox21E).Append("\n");
            sb.Append("  CertifyBox21F: ").Append(CertifyBox21F).Append("\n");
            sb.Append("  CertifyBox22: ").Append(CertifyBox22).Append("\n");
            sb.Append("  Box23ANameSponsoringEntity: ").Append(Box23ANameSponsoringEntity).Append("\n");
            sb.Append("  CertifyBox23B: ").Append(CertifyBox23B).Append("\n");
            sb.Append("  CertifyBox23C: ").Append(CertifyBox23C).Append("\n");
            sb.Append("  CertifyBox24A: ").Append(CertifyBox24A).Append("\n");
            sb.Append("  CertifyBox24B: ").Append(CertifyBox24B).Append("\n");
            sb.Append("  CertifyBox24C: ").Append(CertifyBox24C).Append("\n");
            sb.Append("  CertifyBox25: ").Append(CertifyBox25).Append("\n");
            sb.Append("  CertifyBox26: ").Append(CertifyBox26).Append("\n");
            sb.Append("  Box27ANameSponsoringEntity: ").Append(Box27ANameSponsoringEntity).Append("\n");
            sb.Append("  CertifyBox27B: ").Append(CertifyBox27B).Append("\n");
            sb.Append("  CertifyBox28: ").Append(CertifyBox28).Append("\n");
            sb.Append("  CertifyBox29: ").Append(CertifyBox29).Append("\n");
            sb.Append("  CertifyBox30A: ").Append(CertifyBox30A).Append("\n");
            sb.Append("  CertifyBox30B: ").Append(CertifyBox30B).Append("\n");
            sb.Append("  CertifyBox30C: ").Append(CertifyBox30C).Append("\n");
            sb.Append("  CertifyBox31: ").Append(CertifyBox31).Append("\n");
            sb.Append("  CertifyBox32: ").Append(CertifyBox32).Append("\n");
            sb.Append("  Box32IgaCountry: ").Append(Box32IgaCountry).Append("\n");
            sb.Append("  Box32IgaType: ").Append(Box32IgaType).Append("\n");
            sb.Append("  Box32IgaTreatedAs: ").Append(Box32IgaTreatedAs).Append("\n");
            sb.Append("  Box32TrusteeOrSponsor: ").Append(Box32TrusteeOrSponsor).Append("\n");
            sb.Append("  Box32TrusteeIsForeign: ").Append(Box32TrusteeIsForeign).Append("\n");
            sb.Append("  CertifyBox33A: ").Append(CertifyBox33A).Append("\n");
            sb.Append("  CertifyBox33B: ").Append(CertifyBox33B).Append("\n");
            sb.Append("  CertifyBox33C: ").Append(CertifyBox33C).Append("\n");
            sb.Append("  CertifyBox33D: ").Append(CertifyBox33D).Append("\n");
            sb.Append("  CertifyBox33E: ").Append(CertifyBox33E).Append("\n");
            sb.Append("  CertifyBox33F: ").Append(CertifyBox33F).Append("\n");
            sb.Append("  CertifyBox34: ").Append(CertifyBox34).Append("\n");
            sb.Append("  CertifyBox35: ").Append(CertifyBox35).Append("\n");
            sb.Append("  CertifyBox36: ").Append(CertifyBox36).Append("\n");
            sb.Append("  CertifyBox37A: ").Append(CertifyBox37A).Append("\n");
            sb.Append("  Box37ASecuritiesMarket: ").Append(Box37ASecuritiesMarket).Append("\n");
            sb.Append("  CertifyBox37B: ").Append(CertifyBox37B).Append("\n");
            sb.Append("  Box37BNameOfEntity: ").Append(Box37BNameOfEntity).Append("\n");
            sb.Append("  Box37BSecuritiesMarket: ").Append(Box37BSecuritiesMarket).Append("\n");
            sb.Append("  CertifyBox38: ").Append(CertifyBox38).Append("\n");
            sb.Append("  CertifyBox39: ").Append(CertifyBox39).Append("\n");
            sb.Append("  CertifyBox40: ").Append(CertifyBox40).Append("\n");
            sb.Append("  Box41SponsoringEntity: ").Append(Box41SponsoringEntity).Append("\n");
            sb.Append("  CertifyBox42: ").Append(CertifyBox42).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
            sb.Append("  Box35FormedOnDate: ").Append(Box35FormedOnDate).Append("\n");
            sb.Append("  Box36FiledOnDate: ").Append(Box36FiledOnDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryStatus: ").Append(EntryStatus).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
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
