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
    /// Form1099MiscRequest
    /// </summary>
    [DataContract(Name = "Form1099MiscRequest")]
    public partial class Form1099MiscRequest : IValidatableObject
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
            _1042S = 7
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
        /// Initializes a new instance of the <see cref="Form1099MiscRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099MiscRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099MiscRequest" /> class.
        /// </summary>
        /// <param name="secondTinNotice">Second TIN notice.</param>
        /// <param name="rents">Rents.</param>
        /// <param name="royalties">Royalties.</param>
        /// <param name="otherIncome">Other income.</param>
        /// <param name="fedIncomeTaxWithheld">Federal income tax withheld.</param>
        /// <param name="fishingBoatProceeds">Fishing boat proceeds.</param>
        /// <param name="medicalHealthCarePayments">Medical and health care payments.</param>
        /// <param name="directSalesIndicator">Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale.</param>
        /// <param name="substitutePayments">Substitute payments in lieu of dividends or interest.</param>
        /// <param name="cropInsuranceProceeds">Crop insurance proceeds.</param>
        /// <param name="grossProceedsPaidToAttorney">Gross proceeds paid to an attorney.</param>
        /// <param name="fishPurchasedForResale">Fish purchased for resale.</param>
        /// <param name="section409ADeferrals">Section 409A deferrals.</param>
        /// <param name="fatcaFilingRequirement">FATCA filing requirement.</param>
        /// <param name="excessGoldenParachutePayments">(Legacy field) Excess golden parachute payments.</param>
        /// <param name="nonqualifiedDeferredCompensation">Nonqualified deferred compensation.</param>
        /// <param name="type">type.</param>
        /// <param name="issuerId">Issuer ID.</param>
        /// <param name="referenceId">Reference ID.</param>
        /// <param name="recipientTin">Recipient Tax ID Number.</param>
        /// <param name="recipientName">Recipient name (required).</param>
        /// <param name="tinType">Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address (required).</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="city">City (required).</param>
        /// <param name="state">US state. Required if CountryCode is \&quot;US\&quot;..</param>
        /// <param name="zip">Zip/postal code.</param>
        /// <param name="recipientEmail">Recipient email address.</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="officeCode">Office code.</param>
        /// <param name="recipientNonUsProvince">Foreign province.</param>
        /// <param name="countryCode">Country code, as defined at https://www.irs.gov/e-file-providers/country-codes (required).</param>
        /// <param name="federalEFile">Boolean indicating that federal e-filing should be scheduled for this form.</param>
        /// <param name="postalMail">Boolean indicating that postal mailing to the recipient should be scheduled for this form.</param>
        /// <param name="stateEFile">Boolean indicating that state e-filing should be scheduled for this form.</param>
        /// <param name="tinMatch">Boolean indicating that TIN Matching should be scheduled for this form.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        public Form1099MiscRequest(bool secondTinNotice = default(bool), double rents = default(double), double royalties = default(double), double otherIncome = default(double), double fedIncomeTaxWithheld = default(double), double fishingBoatProceeds = default(double), double medicalHealthCarePayments = default(double), bool directSalesIndicator = default(bool), double substitutePayments = default(double), double cropInsuranceProceeds = default(double), double grossProceedsPaidToAttorney = default(double), double fishPurchasedForResale = default(double), double section409ADeferrals = default(double), bool fatcaFilingRequirement = default(bool), double excessGoldenParachutePayments = default(double), double nonqualifiedDeferredCompensation = default(double), TypeEnum? type = default(TypeEnum?), string issuerId = default(string), string referenceId = default(string), string recipientTin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string recipientEmail = default(string), string accountNumber = default(string), string officeCode = default(string), string recipientNonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
            // to ensure "recipientName" is required (not null)
            if (recipientName == null)
            {
                throw new ArgumentNullException("recipientName is a required property for Form1099MiscRequest and cannot be null");
            }
            this.RecipientName = recipientName;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Form1099MiscRequest and cannot be null");
            }
            this.Address = address;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Form1099MiscRequest and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1099MiscRequest and cannot be null");
            }
            this.CountryCode = countryCode;
            this.SecondTinNotice = secondTinNotice;
            this.Rents = rents;
            this.Royalties = royalties;
            this.OtherIncome = otherIncome;
            this.FedIncomeTaxWithheld = fedIncomeTaxWithheld;
            this.FishingBoatProceeds = fishingBoatProceeds;
            this.MedicalHealthCarePayments = medicalHealthCarePayments;
            this.DirectSalesIndicator = directSalesIndicator;
            this.SubstitutePayments = substitutePayments;
            this.CropInsuranceProceeds = cropInsuranceProceeds;
            this.GrossProceedsPaidToAttorney = grossProceedsPaidToAttorney;
            this.FishPurchasedForResale = fishPurchasedForResale;
            this.Section409ADeferrals = section409ADeferrals;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.ExcessGoldenParachutePayments = excessGoldenParachutePayments;
            this.NonqualifiedDeferredCompensation = nonqualifiedDeferredCompensation;
            this.Type = type;
            this.IssuerId = issuerId;
            this.ReferenceId = referenceId;
            this.RecipientTin = recipientTin;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.Address2 = address2;
            this.State = state;
            this.Zip = zip;
            this.RecipientEmail = recipientEmail;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.RecipientNonUsProvince = recipientNonUsProvince;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Second TIN notice
        /// </summary>
        /// <value>Second TIN notice</value>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool SecondTinNotice { get; set; }

        /// <summary>
        /// Rents
        /// </summary>
        /// <value>Rents</value>
        [DataMember(Name = "rents", EmitDefaultValue = false)]
        public double Rents { get; set; }

        /// <summary>
        /// Royalties
        /// </summary>
        /// <value>Royalties</value>
        [DataMember(Name = "royalties", EmitDefaultValue = false)]
        public double Royalties { get; set; }

        /// <summary>
        /// Other income
        /// </summary>
        /// <value>Other income</value>
        [DataMember(Name = "otherIncome", EmitDefaultValue = false)]
        public double OtherIncome { get; set; }

        /// <summary>
        /// Federal income tax withheld
        /// </summary>
        /// <value>Federal income tax withheld</value>
        [DataMember(Name = "fedIncomeTaxWithheld", EmitDefaultValue = false)]
        public double FedIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Fishing boat proceeds
        /// </summary>
        /// <value>Fishing boat proceeds</value>
        [DataMember(Name = "fishingBoatProceeds", EmitDefaultValue = false)]
        public double FishingBoatProceeds { get; set; }

        /// <summary>
        /// Medical and health care payments
        /// </summary>
        /// <value>Medical and health care payments</value>
        [DataMember(Name = "medicalHealthCarePayments", EmitDefaultValue = false)]
        public double MedicalHealthCarePayments { get; set; }

        /// <summary>
        /// Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale
        /// </summary>
        /// <value>Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale</value>
        [DataMember(Name = "directSalesIndicator", EmitDefaultValue = true)]
        public bool DirectSalesIndicator { get; set; }

        /// <summary>
        /// Substitute payments in lieu of dividends or interest
        /// </summary>
        /// <value>Substitute payments in lieu of dividends or interest</value>
        [DataMember(Name = "substitutePayments", EmitDefaultValue = false)]
        public double SubstitutePayments { get; set; }

        /// <summary>
        /// Crop insurance proceeds
        /// </summary>
        /// <value>Crop insurance proceeds</value>
        [DataMember(Name = "cropInsuranceProceeds", EmitDefaultValue = false)]
        public double CropInsuranceProceeds { get; set; }

        /// <summary>
        /// Gross proceeds paid to an attorney
        /// </summary>
        /// <value>Gross proceeds paid to an attorney</value>
        [DataMember(Name = "grossProceedsPaidToAttorney", EmitDefaultValue = false)]
        public double GrossProceedsPaidToAttorney { get; set; }

        /// <summary>
        /// Fish purchased for resale
        /// </summary>
        /// <value>Fish purchased for resale</value>
        [DataMember(Name = "fishPurchasedForResale", EmitDefaultValue = false)]
        public double FishPurchasedForResale { get; set; }

        /// <summary>
        /// Section 409A deferrals
        /// </summary>
        /// <value>Section 409A deferrals</value>
        [DataMember(Name = "section409ADeferrals", EmitDefaultValue = false)]
        public double Section409ADeferrals { get; set; }

        /// <summary>
        /// FATCA filing requirement
        /// </summary>
        /// <value>FATCA filing requirement</value>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool FatcaFilingRequirement { get; set; }

        /// <summary>
        /// (Legacy field) Excess golden parachute payments
        /// </summary>
        /// <value>(Legacy field) Excess golden parachute payments</value>
        [DataMember(Name = "excessGoldenParachutePayments", EmitDefaultValue = false)]
        public double ExcessGoldenParachutePayments { get; set; }

        /// <summary>
        /// Nonqualified deferred compensation
        /// </summary>
        /// <value>Nonqualified deferred compensation</value>
        [DataMember(Name = "nonqualifiedDeferredCompensation", EmitDefaultValue = false)]
        public double NonqualifiedDeferredCompensation { get; set; }

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
        [DataMember(Name = "recipientTin", EmitDefaultValue = false)]
        public string RecipientTin { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        /// <value>Recipient name</value>
        [DataMember(Name = "recipientName", IsRequired = true, EmitDefaultValue = true)]
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
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
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
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// US state. Required if CountryCode is \&quot;US\&quot;.
        /// </summary>
        /// <value>US state. Required if CountryCode is \&quot;US\&quot;.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code
        /// </summary>
        /// <value>Zip/postal code</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        /// <value>Recipient email address</value>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = true)]
        public string RecipientEmail { get; set; }

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
        [DataMember(Name = "recipientNonUsProvince", EmitDefaultValue = true)]
        public string RecipientNonUsProvince { get; set; }

        /// <summary>
        /// Country code, as defined at https://www.irs.gov/e-file-providers/country-codes
        /// </summary>
        /// <value>Country code, as defined at https://www.irs.gov/e-file-providers/country-codes</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
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
        /// Boolean indicating that address verification should be scheduled for this form
        /// </summary>
        /// <value>Boolean indicating that address verification should be scheduled for this form</value>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// State and local withholding information
        /// </summary>
        /// <value>State and local withholding information</value>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = false)]
        public StateAndLocalWithholdingRequest StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099MiscRequest {\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  Rents: ").Append(Rents).Append("\n");
            sb.Append("  Royalties: ").Append(Royalties).Append("\n");
            sb.Append("  OtherIncome: ").Append(OtherIncome).Append("\n");
            sb.Append("  FedIncomeTaxWithheld: ").Append(FedIncomeTaxWithheld).Append("\n");
            sb.Append("  FishingBoatProceeds: ").Append(FishingBoatProceeds).Append("\n");
            sb.Append("  MedicalHealthCarePayments: ").Append(MedicalHealthCarePayments).Append("\n");
            sb.Append("  DirectSalesIndicator: ").Append(DirectSalesIndicator).Append("\n");
            sb.Append("  SubstitutePayments: ").Append(SubstitutePayments).Append("\n");
            sb.Append("  CropInsuranceProceeds: ").Append(CropInsuranceProceeds).Append("\n");
            sb.Append("  GrossProceedsPaidToAttorney: ").Append(GrossProceedsPaidToAttorney).Append("\n");
            sb.Append("  FishPurchasedForResale: ").Append(FishPurchasedForResale).Append("\n");
            sb.Append("  Section409ADeferrals: ").Append(Section409ADeferrals).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  ExcessGoldenParachutePayments: ").Append(ExcessGoldenParachutePayments).Append("\n");
            sb.Append("  NonqualifiedDeferredCompensation: ").Append(NonqualifiedDeferredCompensation).Append("\n");
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
            // RecipientName (string) minLength
            if (this.RecipientName != null && this.RecipientName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for RecipientName, length must be greater than 1.", new [] { "RecipientName" });
            }

            // Address (string) minLength
            if (this.Address != null && this.Address.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Address, length must be greater than 1.", new [] { "Address" });
            }

            // City (string) minLength
            if (this.City != null && this.City.Length < 1)
            {
                yield return new ValidationResult("Invalid value for City, length must be greater than 1.", new [] { "City" });
            }

            // CountryCode (string) minLength
            if (this.CountryCode != null && this.CountryCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for CountryCode, length must be greater than 1.", new [] { "CountryCode" });
            }

            yield break;
        }
    }
}
