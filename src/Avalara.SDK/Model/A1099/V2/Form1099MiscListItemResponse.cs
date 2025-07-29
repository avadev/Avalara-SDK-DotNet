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
    /// Form1099MiscListItemResponse
    /// </summary>
    [DataContract(Name = "Form1099MiscListItemResponse")]
    public partial class Form1099MiscListItemResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099MiscListItemResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099MiscListItemResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099MiscListItemResponse" /> class.
        /// </summary>
        /// <param name="rents">Rents.</param>
        /// <param name="royalties">Royalties.</param>
        /// <param name="otherIncome">Other income.</param>
        /// <param name="fedIncomeTaxWithheld">Federal income tax withheld.</param>
        /// <param name="fishingBoatProceeds">Fishing boat proceeds.</param>
        /// <param name="medicalAndHealthCare">Medical and health care payments.</param>
        /// <param name="substitutePayments">Substitute payments in lieu of dividends or interest.</param>
        /// <param name="directSalesIndicator">Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale.</param>
        /// <param name="cropInsuranceProceeds">Crop insurance proceeds.</param>
        /// <param name="excessGoldenParachute">(Legacy field) Excess golden parachute payments.</param>
        /// <param name="grossAmountPaidAttorney">Gross proceeds paid to an attorney.</param>
        /// <param name="section409ADeferrals">Section 409A deferrals.</param>
        /// <param name="section409AIncome">Nonqualified deferred compensation.</param>
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
        /// <param name="recipientName">Recipient name.</param>
        /// <param name="recipientSecondName">Recipient second name.</param>
        /// <param name="address">Address.</param>
        /// <param name="address2">Address line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">US state.</param>
        /// <param name="zip">Zip/postal code.</param>
        /// <param name="foreignProvince">Foreign province.</param>
        /// <param name="countryCode">Country code, as defined at https://www.irs.gov/e-file-providers/country-codes.</param>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        public Form1099MiscListItemResponse(double? rents = default(double?), double? royalties = default(double?), double? otherIncome = default(double?), double? fedIncomeTaxWithheld = default(double?), double? fishingBoatProceeds = default(double?), double? medicalAndHealthCare = default(double?), double? substitutePayments = default(double?), bool directSalesIndicator = default(bool), double? cropInsuranceProceeds = default(double?), double? excessGoldenParachute = default(double?), double? grossAmountPaidAttorney = default(double?), double? section409ADeferrals = default(double?), double? section409AIncome = default(double?), string type = default(string), int issuerId = default(int), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), bool stateEfile = default(bool), bool postalMail = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool), string referenceId = default(string), string email = default(string), string tinType = default(string), string tin = default(string), string recipientName = default(string), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string countryCode = default(string), StateAndLocalWithholdingResponse stateAndLocalWithholding = default(StateAndLocalWithholdingResponse))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Form1099MiscListItemResponse and cannot be null");
            }
            this.Type = type;
            this.IssuerId = issuerId;
            this.FederalEfile = federalEfile;
            this.StateEfile = stateEfile;
            this.PostalMail = postalMail;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
            this.Rents = rents;
            this.Royalties = royalties;
            this.OtherIncome = otherIncome;
            this.FedIncomeTaxWithheld = fedIncomeTaxWithheld;
            this.FishingBoatProceeds = fishingBoatProceeds;
            this.MedicalAndHealthCare = medicalAndHealthCare;
            this.SubstitutePayments = substitutePayments;
            this.DirectSalesIndicator = directSalesIndicator;
            this.CropInsuranceProceeds = cropInsuranceProceeds;
            this.ExcessGoldenParachute = excessGoldenParachute;
            this.GrossAmountPaidAttorney = grossAmountPaidAttorney;
            this.Section409ADeferrals = section409ADeferrals;
            this.Section409AIncome = section409AIncome;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.Email = email;
            this.TinType = tinType;
            this.Tin = tin;
            this.RecipientName = recipientName;
            this.RecipientSecondName = recipientSecondName;
            this.Address = address;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.ForeignProvince = foreignProvince;
            this.CountryCode = countryCode;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Rents
        /// </summary>
        /// <value>Rents</value>
        [DataMember(Name = "rents", EmitDefaultValue = true)]
        public double? Rents { get; set; }

        /// <summary>
        /// Royalties
        /// </summary>
        /// <value>Royalties</value>
        [DataMember(Name = "royalties", EmitDefaultValue = true)]
        public double? Royalties { get; set; }

        /// <summary>
        /// Other income
        /// </summary>
        /// <value>Other income</value>
        /// <example>1402.71</example>
        [DataMember(Name = "otherIncome", EmitDefaultValue = true)]
        public double? OtherIncome { get; set; }

        /// <summary>
        /// Federal income tax withheld
        /// </summary>
        /// <value>Federal income tax withheld</value>
        [DataMember(Name = "fedIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FedIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Fishing boat proceeds
        /// </summary>
        /// <value>Fishing boat proceeds</value>
        [DataMember(Name = "fishingBoatProceeds", EmitDefaultValue = true)]
        public double? FishingBoatProceeds { get; set; }

        /// <summary>
        /// Medical and health care payments
        /// </summary>
        /// <value>Medical and health care payments</value>
        [DataMember(Name = "medicalAndHealthCare", EmitDefaultValue = true)]
        public double? MedicalAndHealthCare { get; set; }

        /// <summary>
        /// Substitute payments in lieu of dividends or interest
        /// </summary>
        /// <value>Substitute payments in lieu of dividends or interest</value>
        [DataMember(Name = "substitutePayments", EmitDefaultValue = true)]
        public double? SubstitutePayments { get; set; }

        /// <summary>
        /// Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale
        /// </summary>
        /// <value>Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale</value>
        /// <example>false</example>
        [DataMember(Name = "directSalesIndicator", EmitDefaultValue = true)]
        public bool DirectSalesIndicator { get; set; }

        /// <summary>
        /// Crop insurance proceeds
        /// </summary>
        /// <value>Crop insurance proceeds</value>
        [DataMember(Name = "cropInsuranceProceeds", EmitDefaultValue = true)]
        public double? CropInsuranceProceeds { get; set; }

        /// <summary>
        /// (Legacy field) Excess golden parachute payments
        /// </summary>
        /// <value>(Legacy field) Excess golden parachute payments</value>
        [DataMember(Name = "excessGoldenParachute", EmitDefaultValue = true)]
        public double? ExcessGoldenParachute { get; set; }

        /// <summary>
        /// Gross proceeds paid to an attorney
        /// </summary>
        /// <value>Gross proceeds paid to an attorney</value>
        [DataMember(Name = "grossAmountPaidAttorney", EmitDefaultValue = true)]
        public double? GrossAmountPaidAttorney { get; set; }

        /// <summary>
        /// Section 409A deferrals
        /// </summary>
        /// <value>Section 409A deferrals</value>
        [DataMember(Name = "section409ADeferrals", EmitDefaultValue = true)]
        public double? Section409ADeferrals { get; set; }

        /// <summary>
        /// Nonqualified deferred compensation
        /// </summary>
        /// <value>Nonqualified deferred compensation</value>
        [DataMember(Name = "section409AIncome", EmitDefaultValue = true)]
        public double? Section409AIncome { get; set; }

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
        public Form1099StatusDetailResponse FederalEfileStatus { get; private set; }

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
        public Form1099StatusDetailResponse PostalMailStatus { get; private set; }

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
        public Form1099StatusDetailResponse TinMatchStatus { get; private set; }

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
        public Form1099StatusDetailResponse AddressVerificationStatus { get; private set; }

        /// <summary>
        /// Returns false as AddressVerificationStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddressVerificationStatus()
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
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// Country code, as defined at https://www.irs.gov/e-file-providers/country-codes
        /// </summary>
        /// <value>Country code, as defined at https://www.irs.gov/e-file-providers/country-codes</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

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
        /// <example>2025-07-29T15:26:03.302645900Z</example>
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
        /// <example>2025-07-29T15:26:03.302646500Z</example>
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
            sb.Append("class Form1099MiscListItemResponse {\n");
            sb.Append("  Rents: ").Append(Rents).Append("\n");
            sb.Append("  Royalties: ").Append(Royalties).Append("\n");
            sb.Append("  OtherIncome: ").Append(OtherIncome).Append("\n");
            sb.Append("  FedIncomeTaxWithheld: ").Append(FedIncomeTaxWithheld).Append("\n");
            sb.Append("  FishingBoatProceeds: ").Append(FishingBoatProceeds).Append("\n");
            sb.Append("  MedicalAndHealthCare: ").Append(MedicalAndHealthCare).Append("\n");
            sb.Append("  SubstitutePayments: ").Append(SubstitutePayments).Append("\n");
            sb.Append("  DirectSalesIndicator: ").Append(DirectSalesIndicator).Append("\n");
            sb.Append("  CropInsuranceProceeds: ").Append(CropInsuranceProceeds).Append("\n");
            sb.Append("  ExcessGoldenParachute: ").Append(ExcessGoldenParachute).Append("\n");
            sb.Append("  GrossAmountPaidAttorney: ").Append(GrossAmountPaidAttorney).Append("\n");
            sb.Append("  Section409ADeferrals: ").Append(Section409ADeferrals).Append("\n");
            sb.Append("  Section409AIncome: ").Append(Section409AIncome).Append("\n");
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
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
