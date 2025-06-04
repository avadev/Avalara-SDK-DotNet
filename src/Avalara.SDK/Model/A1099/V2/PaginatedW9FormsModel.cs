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
    /// Paginated model for W9/W4/W8 forms query response data
    /// </summary>
    [DataContract(Name = "PaginatedW9FormsModel")]
    public partial class PaginatedW9FormsModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedW9FormsModel" /> class.
        /// </summary>
        /// <param name="recordsetCount">recordsetCount.</param>
        /// <param name="value">value.</param>
        /// <param name="nextLink">nextLink.</param>
        public PaginatedW9FormsModel(int recordsetCount = default(int), List<W9FormDataModelsOneOf> value = default(List<W9FormDataModelsOneOf>), string nextLink = default(string))
        {
            this.RecordsetCount = recordsetCount;
            this.Value = value;
            this.NextLink = nextLink;
        }

        /// <summary>
        /// Gets or Sets RecordsetCount
        /// </summary>
        [DataMember(Name = "@recordsetCount", EmitDefaultValue = false)]
        public int RecordsetCount { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        /// <example>[{&quot;type&quot;:&quot;w4&quot;,&quot;signedDate&quot;:&quot;2022-04-29T00:00:00Z&quot;,&quot;createdAt&quot;:&quot;2022-04-29T10:15:00Z&quot;,&quot;employeeFirstName&quot;:&quot;Jane&quot;,&quot;employeeMiddleName&quot;:&quot;A.&quot;,&quot;employeeLastName&quot;:&quot;Smith&quot;,&quot;employeeNameSuffix&quot;:&quot;Jr.&quot;,&quot;address&quot;:&quot;456 Elm St&quot;,&quot;city&quot;:&quot;Springfield&quot;,&quot;state&quot;:&quot;IL&quot;,&quot;zip&quot;:&quot;62704&quot;,&quot;typeOfTin&quot;:null,&quot;tin&quot;:&quot;98-7654321&quot;,&quot;maritalStatus&quot;:&quot;Married&quot;,&quot;lastNameDiffers&quot;:false,&quot;numAllowances&quot;:3,&quot;otherDependents&quot;:1,&quot;nonJobIncome&quot;:5000,&quot;deductions&quot;:2000,&quot;additionalWithheld&quot;:150,&quot;exemptFromWithholding&quot;:false,&quot;officeCode&quot;:&quot;OC12345&quot;,&quot;eDeliveryConsentedAt&quot;:&quot;2022-04-29T15:00:00Z&quot;,&quot;id&quot;:0,&quot;entryStatus&quot;:null,&quot;updatedAt&quot;:&quot;2022-05-01T12:00:00Z&quot;,&quot;referenceId&quot;:&quot;REF56789&quot;,&quot;companyId&quot;:2002,&quot;displayName&quot;:&quot;Jane Smith&quot;,&quot;email&quot;:&quot;janesmith@example.com&quot;,&quot;archived&quot;:false,&quot;entryStatusDate&quot;:null,&quot;pdfJson&quot;:null,&quot;pdfVersion&quot;:null,&quot;requestToken&quot;:null,&quot;signature&quot;:null,&quot;mobile&quot;:false,&quot;appVersion&quot;:null,&quot;platform&quot;:null,&quot;osVersion&quot;:null,&quot;ancestorId&quot;:null},{&quot;type&quot;:&quot;w8ben&quot;,&quot;signedDate&quot;:&quot;2023-01-15T00:00:00Z&quot;,&quot;birthday&quot;:null,&quot;foreignTinNotRequired&quot;:null,&quot;archived&quot;:false,&quot;referenceId&quot;:&quot;REF67890&quot;,&quot;companyId&quot;:4004,&quot;displayName&quot;:&quot;International Trading&quot;,&quot;email&quot;:&quot;info@internationaltrading.com&quot;,&quot;typeOfTin&quot;:null,&quot;name&quot;:&quot;International Trading Co.&quot;,&quot;residenceAddress&quot;:&quot;789 Global St&quot;,&quot;residenceCity&quot;:&quot;Capital City&quot;,&quot;residenceState&quot;:&quot;DC&quot;,&quot;residencePostalCode&quot;:&quot;20001&quot;,&quot;residenceCountry&quot;:&quot;USA&quot;,&quot;residenceIsMailing&quot;:false,&quot;mailingAddress&quot;:&quot;P.O. Box 456&quot;,&quot;mailingCity&quot;:&quot;Capital City&quot;,&quot;mailingState&quot;:&quot;DC&quot;,&quot;mailingPostalCode&quot;:&quot;20002&quot;,&quot;mailingCountry&quot;:&quot;USA&quot;,&quot;tin&quot;:&quot;34-5678901&quot;,&quot;foreignTin&quot;:&quot;FTIN56789&quot;,&quot;referenceNumber&quot;:&quot;W8BEN45678&quot;,&quot;citizenshipCountry&quot;:&quot;USA&quot;,&quot;treatyCountry&quot;:&quot;Canada&quot;,&quot;treatyArticle&quot;:&quot;Article 12&quot;,&quot;withholdingRate&quot;:&quot;15%&quot;,&quot;incomeType&quot;:&quot;Dividend&quot;,&quot;treatyReasons&quot;:&quot;Reduced withholding&quot;,&quot;signerName&quot;:&quot;Alice Johnson&quot;,&quot;signerCapacity&quot;:&quot;Authorized Representative&quot;,&quot;eDeliveryConsentedAt&quot;:&quot;2023-01-15T10:00:00Z&quot;,&quot;createdAt&quot;:&quot;2023-01-10T08:00:00Z&quot;,&quot;updatedAt&quot;:&quot;2023-02-05T09:30:00Z&quot;,&quot;id&quot;:0,&quot;entryStatus&quot;:null,&quot;entryStatusDate&quot;:null,&quot;pdfJson&quot;:null,&quot;pdfVersion&quot;:null,&quot;requestToken&quot;:null,&quot;signature&quot;:null,&quot;mobile&quot;:false,&quot;appVersion&quot;:null,&quot;platform&quot;:null,&quot;osVersion&quot;:null,&quot;ancestorId&quot;:null},{&quot;type&quot;:&quot;w8bene&quot;,&quot;signedDate&quot;:&quot;2022-04-29T00:00:00Z&quot;,&quot;disregardedEntityChapter4FatcaStatus&quot;:null,&quot;createdAt&quot;:&quot;2022-04-29T10:00:00Z&quot;,&quot;name&quot;:&quot;Global Enterprises LLC&quot;,&quot;residenceAddress&quot;:&quot;123 International Blvd&quot;,&quot;residenceCity&quot;:&quot;Metropolis&quot;,&quot;residenceState&quot;:&quot;NY&quot;,&quot;residencePostalCode&quot;:&quot;10118&quot;,&quot;residenceCountry&quot;:&quot;USA&quot;,&quot;mailingAddress&quot;:&quot;P.O. Box 123&quot;,&quot;mailingCity&quot;:&quot;Metropolis&quot;,&quot;mailingState&quot;:&quot;NY&quot;,&quot;mailingPostalCode&quot;:&quot;10119&quot;,&quot;mailingCountry&quot;:&quot;USA&quot;,&quot;disregardedAddress&quot;:null,&quot;disregardedCity&quot;:null,&quot;disregardedState&quot;:null,&quot;disregardedPostalCode&quot;:null,&quot;disregardedCountry&quot;:null,&quot;tin&quot;:&quot;12-3456789&quot;,&quot;typeOfTin&quot;:null,&quot;foreignTin&quot;:null,&quot;ftinNotRequired&quot;:null,&quot;referenceNumber&quot;:&quot;W8BENE12345&quot;,&quot;giin&quot;:&quot;GIIN12345678&quot;,&quot;chapter3EntityType&quot;:&quot;Corporation&quot;,&quot;chapter4FatcaStatus&quot;:&quot;Active&quot;,&quot;disregardedEntity&quot;:&quot;Subsidiary LLC&quot;,&quot;disregardedEntityGiin&quot;:&quot;GIIN87654321&quot;,&quot;benefitLimitation&quot;:&quot;Treaty Benefit&quot;,&quot;part4SponsoringEntity&quot;:&quot;Parent Company&quot;,&quot;part4SponsoringEntityGiin&quot;:&quot;GIIN11223344&quot;,&quot;part7SponsoringEntity&quot;:&quot;Affiliated Organization&quot;,&quot;part12IgaCountry&quot;:&quot;USA&quot;,&quot;part12IgaType&quot;:&quot;Model 1&quot;,&quot;part12FatcaStatusUnderIgaAnnexIi&quot;:&quot;Registered Deemed Compliant&quot;,&quot;part12TrusteeName&quot;:&quot;Trustee Inc.&quot;,&quot;part12TrusteeIsForeign&quot;:false,&quot;part12Model2IgaGiin&quot;:&quot;GIIN33445566&quot;,&quot;box37AExchange&quot;:&quot;NYSE&quot;,&quot;box37BExchange&quot;:&quot;NASDAQ&quot;,&quot;box37BEntity&quot;:&quot;Trading Partner&quot;,&quot;part28SponsoringEntity&quot;:&quot;Global Trust&quot;,&quot;part28SponsoringEntityGiin&quot;:&quot;GIIN99887766&quot;,&quot;signerName&quot;:&quot;John Doe&quot;,&quot;eDeliveryConsentedAt&quot;:&quot;2022-04-29T15:30:00Z&quot;,&quot;residenceIsMailing&quot;:false,&quot;citizenshipCountry&quot;:null,&quot;makingTreatyClaim&quot;:false,&quot;treatyCountry&quot;:null,&quot;treatyArticle&quot;:null,&quot;withholdingRate&quot;:null,&quot;incomeType&quot;:null,&quot;treatyReasons&quot;:null,&quot;certifyBox14A&quot;:false,&quot;certifyBox14B&quot;:false,&quot;certifyBox14C&quot;:false,&quot;certifyBox17_1&quot;:false,&quot;certifyBox17_2&quot;:false,&quot;certifyBox18&quot;:false,&quot;certifyBox19&quot;:false,&quot;certifyBox21&quot;:false,&quot;certifyBox22&quot;:false,&quot;certifyBox23&quot;:false,&quot;certifyBox24A&quot;:false,&quot;certifyBox24B&quot;:false,&quot;certifyBox24C&quot;:false,&quot;certifyBox24D&quot;:false,&quot;certifyBox25A&quot;:false,&quot;certifyBox25B&quot;:false,&quot;certifyBox25C&quot;:false,&quot;certifyBox26&quot;:false,&quot;certifyBox27&quot;:false,&quot;certifyBox28A&quot;:false,&quot;certifyBox28B&quot;:false,&quot;certifyBox29A&quot;:false,&quot;certifyBox29B&quot;:false,&quot;certifyBox29C&quot;:false,&quot;certifyBox29D&quot;:false,&quot;certifyBox29E&quot;:false,&quot;certifyBox29F&quot;:false,&quot;certifyBox30&quot;:false,&quot;certifyBox31&quot;:false,&quot;certifyBox32&quot;:false,&quot;certifyBox33&quot;:false,&quot;certifyBox34&quot;:false,&quot;certifyBox35&quot;:false,&quot;certifyBox36&quot;:false,&quot;certifyBox37A&quot;:false,&quot;certifyBox37B&quot;:false,&quot;certifyBox38&quot;:false,&quot;certifyBox39&quot;:false,&quot;certifyBox40A&quot;:false,&quot;certifyBox40B&quot;:false,&quot;certifyBox40C&quot;:false,&quot;certifyBox41&quot;:false,&quot;certifyBox43&quot;:false,&quot;certifyPart29Signature&quot;:false,&quot;part19FormationOrResolutionDate&quot;:null,&quot;part20FilingDate&quot;:null,&quot;part21DeterminationDate&quot;:null,&quot;id&quot;:0,&quot;entryStatus&quot;:null,&quot;updatedAt&quot;:&quot;2022-05-01T11:30:00Z&quot;,&quot;referenceId&quot;:&quot;REF98765&quot;,&quot;companyId&quot;:3003,&quot;displayName&quot;:&quot;Global Enterprises&quot;,&quot;email&quot;:&quot;contact@globalenterprises.com&quot;,&quot;archived&quot;:false,&quot;entryStatusDate&quot;:null,&quot;pdfJson&quot;:null,&quot;pdfVersion&quot;:null,&quot;requestToken&quot;:null,&quot;signature&quot;:null,&quot;mobile&quot;:false,&quot;appVersion&quot;:null,&quot;platform&quot;:null,&quot;osVersion&quot;:null,&quot;ancestorId&quot;:null},{&quot;type&quot;:&quot;w8imy&quot;,&quot;signedDate&quot;:&quot;2023-06-10T00:00:00Z&quot;,&quot;disregardedEntityChapter4FatcaStatus&quot;:null,&quot;createdAt&quot;:&quot;2023-06-05T09:00:00Z&quot;,&quot;updatedAt&quot;:&quot;2023-06-20T14:30:00Z&quot;,&quot;displayName&quot;:&quot;Global Financials&quot;,&quot;email&quot;:&quot;contact@globalfinancials.com&quot;,&quot;tin&quot;:null,&quot;typeOfTin&quot;:null,&quot;name&quot;:&quot;Global Financials LLC&quot;,&quot;citizenshipCountry&quot;:&quot;USA&quot;,&quot;chapter3EntityType&quot;:&quot;Partnership&quot;,&quot;chapter4FatcaStatus&quot;:&quot;Compliant&quot;,&quot;residenceAddress&quot;:&quot;321 Wealth Ave&quot;,&quot;residenceCity&quot;:&quot;Finance City&quot;,&quot;residenceState&quot;:&quot;TX&quot;,&quot;residencePostalCode&quot;:&quot;75001&quot;,&quot;residenceCountry&quot;:&quot;USA&quot;,&quot;residenceIsMailing&quot;:null,&quot;mailingAddress&quot;:&quot;P.O. Box 789&quot;,&quot;mailingCity&quot;:&quot;Finance City&quot;,&quot;mailingState&quot;:&quot;TX&quot;,&quot;mailingPostalCode&quot;:&quot;75002&quot;,&quot;mailingCountry&quot;:&quot;USA&quot;,&quot;disregardedEntity&quot;:&quot;Subsidiary Finance&quot;,&quot;disregardedAddress&quot;:null,&quot;disregardedCity&quot;:null,&quot;disregardedState&quot;:null,&quot;disregardedPostalCode&quot;:null,&quot;disregardedCountry&quot;:null,&quot;disregardedEntityGiin&quot;:&quot;GIIN78901234&quot;,&quot;ein&quot;:null,&quot;einType&quot;:null,&quot;giin&quot;:null,&quot;foreignTin&quot;:null,&quot;referenceNumber&quot;:&quot;W8IMY56789&quot;,&quot;certifyBox14&quot;:null,&quot;certifyBox15A&quot;:null,&quot;certifyBox15B&quot;:null,&quot;certifyBox15C&quot;:null,&quot;certifyBox15D&quot;:null,&quot;certifyBox15E&quot;:null,&quot;certifyBox15F&quot;:null,&quot;certifyBox15G&quot;:null,&quot;certifyBox15H&quot;:null,&quot;certifyBox15I&quot;:null,&quot;certifyBox16A&quot;:null,&quot;box16BQddCorporate&quot;:null,&quot;box16BQddPartnership&quot;:null,&quot;box16BQddDisregardedEntity&quot;:null,&quot;certifyBox17A&quot;:null,&quot;certifyBox17B&quot;:null,&quot;certifyBox17C&quot;:null,&quot;certifyBox17D&quot;:null,&quot;certifyBox17E&quot;:null,&quot;certifyBox18A&quot;:null,&quot;certifyBox18B&quot;:null,&quot;certifyBox18C&quot;:null,&quot;certifyBox18D&quot;:null,&quot;certifyBox18E&quot;:null,&quot;certifyBox18F&quot;:null,&quot;certifyBox19A&quot;:null,&quot;certifyBox19B&quot;:null,&quot;certifyBox19C&quot;:null,&quot;certifyBox19D&quot;:null,&quot;certifyBox19E&quot;:null,&quot;certifyBox19F&quot;:null,&quot;certifyBox20&quot;:null,&quot;certifyBox21A&quot;:null,&quot;certifyBox21B&quot;:null,&quot;certifyBox21C&quot;:null,&quot;certifyBox21D&quot;:null,&quot;certifyBox21E&quot;:null,&quot;certifyBox21F&quot;:null,&quot;certifyBox22&quot;:null,&quot;box23ANameSponsoringEntity&quot;:null,&quot;certifyBox23B&quot;:null,&quot;certifyBox23C&quot;:null,&quot;certifyBox24A&quot;:null,&quot;certifyBox24B&quot;:null,&quot;certifyBox24C&quot;:null,&quot;certifyBox25&quot;:null,&quot;certifyBox26&quot;:null,&quot;box27ANameSponsoringEntity&quot;:null,&quot;certifyBox27B&quot;:null,&quot;certifyBox28&quot;:null,&quot;certifyBox29&quot;:null,&quot;certifyBox30A&quot;:null,&quot;certifyBox30B&quot;:null,&quot;certifyBox30C&quot;:null,&quot;certifyBox31&quot;:null,&quot;certifyBox32&quot;:null,&quot;box32IgaCountry&quot;:null,&quot;box32IgaType&quot;:null,&quot;box32IgaTreatedAs&quot;:null,&quot;box32TrusteeOrSponsor&quot;:null,&quot;box32TrusteeIsForeign&quot;:null,&quot;certifyBox33A&quot;:null,&quot;certifyBox33B&quot;:null,&quot;certifyBox33C&quot;:null,&quot;certifyBox33D&quot;:null,&quot;certifyBox33E&quot;:null,&quot;certifyBox33F&quot;:null,&quot;certifyBox34&quot;:null,&quot;certifyBox35&quot;:null,&quot;certifyBox36&quot;:null,&quot;certifyBox37A&quot;:null,&quot;box37ASecuritiesMarket&quot;:null,&quot;certifyBox37B&quot;:null,&quot;box37BNameOfEntity&quot;:null,&quot;box37BSecuritiesMarket&quot;:null,&quot;certifyBox38&quot;:null,&quot;certifyBox39&quot;:null,&quot;certifyBox40&quot;:null,&quot;box41SponsoringEntity&quot;:null,&quot;certifyBox42&quot;:null,&quot;signerName&quot;:&quot;Richard Roe&quot;,&quot;eDeliveryConsentedAt&quot;:&quot;2023-06-10T11:00:00Z&quot;,&quot;box35FormedOnDate&quot;:null,&quot;box36FiledOnDate&quot;:null,&quot;id&quot;:0,&quot;entryStatus&quot;:null,&quot;referenceId&quot;:&quot;REF12345&quot;,&quot;companyId&quot;:5005,&quot;archived&quot;:false,&quot;entryStatusDate&quot;:null,&quot;pdfJson&quot;:null,&quot;pdfVersion&quot;:null,&quot;requestToken&quot;:null,&quot;signature&quot;:null,&quot;mobile&quot;:false,&quot;appVersion&quot;:null,&quot;platform&quot;:null,&quot;osVersion&quot;:null,&quot;ancestorId&quot;:null},{&quot;type&quot;:&quot;w9&quot;,&quot;tinMatchStatus&quot;:&quot;Match&quot;,&quot;signature&quot;:null,&quot;signedDate&quot;:&quot;2022-04-29T15:19:42Z&quot;,&quot;name&quot;:&quot;John Doe&quot;,&quot;businessClassification&quot;:&quot;LLC&quot;,&quot;businessName&quot;:&quot;Doe Enterprises&quot;,&quot;businessOther&quot;:null,&quot;exemptPayeeCode&quot;:null,&quot;exemptFatcaCode&quot;:null,&quot;typeOfTin&quot;:&quot;EIN&quot;,&quot;tin&quot;:&quot;12-3456789&quot;,&quot;address&quot;:&quot;123 Main St&quot;,&quot;city&quot;:&quot;Anytown&quot;,&quot;state&quot;:&quot;CA&quot;,&quot;zip&quot;:&quot;90210&quot;,&quot;accountNumber&quot;:&quot;ACC123456&quot;,&quot;foreignCountryIndicator&quot;:false,&quot;foreignAddress&quot;:null,&quot;backupWithholding&quot;:false,&quot;eDeliveryConsentedAt&quot;:&quot;2022-04-29T15:19:42Z&quot;,&quot;is1099able&quot;:null,&quot;foreignPartnerOwnerOrBeneficiary&quot;:false,&quot;createdAt&quot;:&quot;2022-04-29T15:19:42Z&quot;,&quot;id&quot;:0,&quot;entryStatus&quot;:null,&quot;updatedAt&quot;:&quot;2022-04-29T15:19:42Z&quot;,&quot;referenceId&quot;:&quot;REF12345&quot;,&quot;companyId&quot;:1001,&quot;displayName&quot;:&quot;John Doe&quot;,&quot;email&quot;:&quot;johndoe@example.com&quot;,&quot;archived&quot;:false,&quot;entryStatusDate&quot;:null,&quot;pdfJson&quot;:null,&quot;pdfVersion&quot;:null,&quot;requestToken&quot;:null,&quot;mobile&quot;:false,&quot;appVersion&quot;:null,&quot;platform&quot;:null,&quot;osVersion&quot;:null,&quot;ancestorId&quot;:null}]</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<W9FormDataModelsOneOf> Value { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name = "@nextLink", EmitDefaultValue = true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginatedW9FormsModel {\n");
            sb.Append("  RecordsetCount: ").Append(RecordsetCount).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
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
