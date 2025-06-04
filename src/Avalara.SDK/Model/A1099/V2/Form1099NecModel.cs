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
    /// Form 1099-NEC for non-employee compensation.
    /// </summary>
    [DataContract(Name = "Form1099NecModel")]
    public partial class Form1099NecModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099NecModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form1099NecModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099NecModel" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="nonemployeeCompensation">The non-employee compensation reported in box 1..</param>
        /// <param name="forResale">Indicates if the amount was for resale purposes..</param>
        /// <param name="federalIncomeTaxWithheld">The amount of federal income tax withheld, if any..</param>
        /// <param name="stateWithholding">stateWithholding.</param>
        /// <param name="issuerId">The ID of the issuer. (required).</param>
        /// <param name="issuerReferenceId">Unique reference ID of the issuer.</param>
        /// <param name="issuerTin">The Taxpayer Identification Number of the issuer..</param>
        /// <param name="taxYear">The tax year for the form in the format CCYY.</param>
        /// <param name="federalEfile">When upserting, this declares whether or not to federal e-file this form..</param>
        /// <param name="federalEfileStatus">federalEfileStatus.</param>
        /// <param name="postalMail">When upserting, this declares whether or not to postal mail this form to the recipient..</param>
        /// <param name="postalMailStatus">postalMailStatus.</param>
        /// <param name="stateEfile">When upserting, this declares whether or not to state e-file this form..</param>
        /// <param name="stateEfileStatuses">The status of state e-filing. ONLY USED ON RESPONSES..</param>
        /// <param name="tinMatch">When upserting this declares whether or not to TIN match this form..</param>
        /// <param name="tinMatchStatus">tinMatchStatus.</param>
        /// <param name="addressVerification">When upserting, this declares whether or not to perform address verification for this form..</param>
        /// <param name="addressVerificationStatus">addressVerificationStatus.</param>
        /// <param name="referenceId">Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces. (required).</param>
        /// <param name="recipientName">Legal name of the recipient (required).</param>
        /// <param name="federalIdType">The type of federal ID provided by the recipient..</param>
        /// <param name="recipientFederalIdNo">The federal ID number of the recipient. (required).</param>
        /// <param name="recipientSecondName">The second name of the recipient, if applicable..</param>
        /// <param name="streetAddress">The street address of the recipient..</param>
        /// <param name="streetAddressLine2">The second line of the street address, if applicable..</param>
        /// <param name="city">The city of the recipient..</param>
        /// <param name="state">The state of the recipient. (required).</param>
        /// <param name="zip">The ZIP code of the recipient. (required).</param>
        /// <param name="foreignProvince">The foreign province, if applicable..</param>
        /// <param name="countryCode">The country code of the recipient. (required).</param>
        /// <param name="recipientEmail">The email address of the recipient..</param>
        /// <param name="acctNo">The account number associated with the form..</param>
        /// <param name="officeCode">The office code associated with the form..</param>
        public Form1099NecModel(Object type = default(Object), double nonemployeeCompensation = default(double), bool forResale = default(bool), double? federalIncomeTaxWithheld = default(double?), StateWithholding stateWithholding = default(StateWithholding), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), bool federalEfile = default(bool), Form1099BaseModelFederalEfileStatus federalEfileStatus = default(Form1099BaseModelFederalEfileStatus), bool postalMail = default(bool), Form1099BaseModelPostalMailStatus postalMailStatus = default(Form1099BaseModelPostalMailStatus), bool stateEfile = default(bool), List<StateEfileStatusesInner> stateEfileStatuses = default(List<StateEfileStatusesInner>), bool tinMatch = default(bool), TinMatchStatus tinMatchStatus = default(TinMatchStatus), bool addressVerification = default(bool), AddressVerificationStatus addressVerificationStatus = default(AddressVerificationStatus), string referenceId = default(string), string recipientName = default(string), string federalIdType = default(string), string recipientFederalIdNo = default(string), string recipientSecondName = default(string), string streetAddress = default(string), string streetAddressLine2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string foreignProvince = default(string), string countryCode = default(string), string recipientEmail = default(string), string acctNo = default(string), string officeCode = default(string))
        {
            // to ensure "issuerId" is required (not null)
            if (issuerId == null)
            {
                throw new ArgumentNullException("issuerId is a required property for Form1099NecModel and cannot be null");
            }
            this.IssuerId = issuerId;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
            {
                throw new ArgumentNullException("referenceId is a required property for Form1099NecModel and cannot be null");
            }
            this.ReferenceId = referenceId;
            // to ensure "recipientName" is required (not null)
            if (recipientName == null)
            {
                throw new ArgumentNullException("recipientName is a required property for Form1099NecModel and cannot be null");
            }
            this.RecipientName = recipientName;
            // to ensure "recipientFederalIdNo" is required (not null)
            if (recipientFederalIdNo == null)
            {
                throw new ArgumentNullException("recipientFederalIdNo is a required property for Form1099NecModel and cannot be null");
            }
            this.RecipientFederalIdNo = recipientFederalIdNo;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for Form1099NecModel and cannot be null");
            }
            this.State = state;
            // to ensure "zip" is required (not null)
            if (zip == null)
            {
                throw new ArgumentNullException("zip is a required property for Form1099NecModel and cannot be null");
            }
            this.Zip = zip;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Form1099NecModel and cannot be null");
            }
            this.CountryCode = countryCode;
            this.Type = type;
            this.NonemployeeCompensation = nonemployeeCompensation;
            this.ForResale = forResale;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.StateWithholding = stateWithholding;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.FederalEfile = federalEfile;
            this.FederalEfileStatus = federalEfileStatus;
            this.PostalMail = postalMail;
            this.PostalMailStatus = postalMailStatus;
            this.StateEfile = stateEfile;
            this.StateEfileStatuses = stateEfileStatuses;
            this.TinMatch = tinMatch;
            this.TinMatchStatus = tinMatchStatus;
            this.AddressVerification = addressVerification;
            this.AddressVerificationStatus = addressVerificationStatus;
            this.FederalIdType = federalIdType;
            this.RecipientSecondName = recipientSecondName;
            this.StreetAddress = streetAddress;
            this.StreetAddressLine2 = streetAddressLine2;
            this.City = city;
            this.ForeignProvince = foreignProvince;
            this.RecipientEmail = recipientEmail;
            this.AcctNo = acctNo;
            this.OfficeCode = officeCode;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>form1099nec</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public Object Type { get; set; }

        /// <summary>
        /// The non-employee compensation reported in box 1.
        /// </summary>
        /// <value>The non-employee compensation reported in box 1.</value>
        /// <example>2733.85</example>
        [DataMember(Name = "nonemployeeCompensation", EmitDefaultValue = false)]
        public double NonemployeeCompensation { get; set; }

        /// <summary>
        /// Indicates if the amount was for resale purposes.
        /// </summary>
        /// <value>Indicates if the amount was for resale purposes.</value>
        /// <example>false</example>
        [DataMember(Name = "forResale", EmitDefaultValue = true)]
        public bool ForResale { get; set; }

        /// <summary>
        /// The amount of federal income tax withheld, if any.
        /// </summary>
        /// <value>The amount of federal income tax withheld, if any.</value>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = true)]
        public double? FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets StateWithholding
        /// </summary>
        [DataMember(Name = "stateWithholding", EmitDefaultValue = false)]
        public StateWithholding StateWithholding { get; set; }

        /// <summary>
        /// The ID of the issuer.
        /// </summary>
        /// <value>The ID of the issuer.</value>
        [DataMember(Name = "issuerId", IsRequired = true, EmitDefaultValue = true)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Unique reference ID of the issuer
        /// </summary>
        /// <value>Unique reference ID of the issuer</value>
        /// <example>C-935801</example>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// The Taxpayer Identification Number of the issuer.
        /// </summary>
        /// <value>The Taxpayer Identification Number of the issuer.</value>
        /// <example>27-4598011</example>
        [DataMember(Name = "issuerTin", EmitDefaultValue = false)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// The tax year for the form in the format CCYY
        /// </summary>
        /// <value>The tax year for the form in the format CCYY</value>
        /// <example>2024</example>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// When upserting, this declares whether or not to federal e-file this form.
        /// </summary>
        /// <value>When upserting, this declares whether or not to federal e-file this form.</value>
        /// <example>true</example>
        [DataMember(Name = "federalEfile", EmitDefaultValue = true)]
        public bool FederalEfile { get; set; }

        /// <summary>
        /// Gets or Sets FederalEfileStatus
        /// </summary>
        [DataMember(Name = "federalEfileStatus", EmitDefaultValue = true)]
        public Form1099BaseModelFederalEfileStatus FederalEfileStatus { get; set; }

        /// <summary>
        /// When upserting, this declares whether or not to postal mail this form to the recipient.
        /// </summary>
        /// <value>When upserting, this declares whether or not to postal mail this form to the recipient.</value>
        /// <example>true</example>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Gets or Sets PostalMailStatus
        /// </summary>
        [DataMember(Name = "postalMailStatus", EmitDefaultValue = true)]
        public Form1099BaseModelPostalMailStatus PostalMailStatus { get; set; }

        /// <summary>
        /// When upserting, this declares whether or not to state e-file this form.
        /// </summary>
        /// <value>When upserting, this declares whether or not to state e-file this form.</value>
        /// <example>true</example>
        [DataMember(Name = "stateEfile", EmitDefaultValue = true)]
        public bool StateEfile { get; set; }

        /// <summary>
        /// The status of state e-filing. ONLY USED ON RESPONSES.
        /// </summary>
        /// <value>The status of state e-filing. ONLY USED ON RESPONSES.</value>
        [DataMember(Name = "stateEfileStatuses", EmitDefaultValue = false)]
        public List<StateEfileStatusesInner> StateEfileStatuses { get; set; }

        /// <summary>
        /// When upserting this declares whether or not to TIN match this form.
        /// </summary>
        /// <value>When upserting this declares whether or not to TIN match this form.</value>
        /// <example>true</example>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// Gets or Sets TinMatchStatus
        /// </summary>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public TinMatchStatus TinMatchStatus { get; set; }

        /// <summary>
        /// When upserting, this declares whether or not to perform address verification for this form.
        /// </summary>
        /// <value>When upserting, this declares whether or not to perform address verification for this form.</value>
        /// <example>true</example>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerificationStatus
        /// </summary>
        [DataMember(Name = "addressVerificationStatus", EmitDefaultValue = true)]
        public AddressVerificationStatus AddressVerificationStatus { get; set; }

        /// <summary>
        /// Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.
        /// </summary>
        /// <value>Optional identifier for your reference, never shown to any agency or recipient.  We will also prefix download filenames with this value, if present.  Can only include letters, numbers, dashes, underscores and spaces.</value>
        [DataMember(Name = "referenceId", IsRequired = true, EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Legal name of the recipient
        /// </summary>
        /// <value>Legal name of the recipient</value>
        /// <example>Jane Smith</example>
        [DataMember(Name = "recipientName", IsRequired = true, EmitDefaultValue = true)]
        public string RecipientName { get; set; }

        /// <summary>
        /// The type of federal ID provided by the recipient.
        /// </summary>
        /// <value>The type of federal ID provided by the recipient.</value>
        /// <example>SSN</example>
        [DataMember(Name = "federalIdType", EmitDefaultValue = false)]
        public string FederalIdType { get; set; }

        /// <summary>
        /// The federal ID number of the recipient.
        /// </summary>
        /// <value>The federal ID number of the recipient.</value>
        /// <example>555-55-2222</example>
        [DataMember(Name = "recipientFederalIdNo", IsRequired = true, EmitDefaultValue = true)]
        public string RecipientFederalIdNo { get; set; }

        /// <summary>
        /// The second name of the recipient, if applicable.
        /// </summary>
        /// <value>The second name of the recipient, if applicable.</value>
        /// <example>Rainy Days Legal</example>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// The street address of the recipient.
        /// </summary>
        /// <value>The street address of the recipient.</value>
        /// <example>79 Madison Avenue</example>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The second line of the street address, if applicable.
        /// </summary>
        /// <value>The second line of the street address, if applicable.</value>
        /// <example>Suite 47</example>
        [DataMember(Name = "streetAddressLine2", EmitDefaultValue = true)]
        public string StreetAddressLine2 { get; set; }

        /// <summary>
        /// The city of the recipient.
        /// </summary>
        /// <value>The city of the recipient.</value>
        /// <example>New York</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The state of the recipient.
        /// </summary>
        /// <value>The state of the recipient.</value>
        /// <example>NY</example>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The ZIP code of the recipient.
        /// </summary>
        /// <value>The ZIP code of the recipient.</value>
        /// <example>10016</example>
        [DataMember(Name = "zip", IsRequired = true, EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// The foreign province, if applicable.
        /// </summary>
        /// <value>The foreign province, if applicable.</value>
        [DataMember(Name = "foreignProvince", EmitDefaultValue = true)]
        public string ForeignProvince { get; set; }

        /// <summary>
        /// The country code of the recipient.
        /// </summary>
        /// <value>The country code of the recipient.</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The email address of the recipient.
        /// </summary>
        /// <value>The email address of the recipient.</value>
        /// <example>corey.green@example.com</example>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = false)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// The account number associated with the form.
        /// </summary>
        /// <value>The account number associated with the form.</value>
        [DataMember(Name = "acctNo", EmitDefaultValue = true)]
        public string AcctNo { get; set; }

        /// <summary>
        /// The office code associated with the form.
        /// </summary>
        /// <value>The office code associated with the form.</value>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099NecModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NonemployeeCompensation: ").Append(NonemployeeCompensation).Append("\n");
            sb.Append("  ForResale: ").Append(ForResale).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  StateWithholding: ").Append(StateWithholding).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  FederalEfile: ").Append(FederalEfile).Append("\n");
            sb.Append("  FederalEfileStatus: ").Append(FederalEfileStatus).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  PostalMailStatus: ").Append(PostalMailStatus).Append("\n");
            sb.Append("  StateEfile: ").Append(StateEfile).Append("\n");
            sb.Append("  StateEfileStatuses: ").Append(StateEfileStatuses).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  AddressVerificationStatus: ").Append(AddressVerificationStatus).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  FederalIdType: ").Append(FederalIdType).Append("\n");
            sb.Append("  RecipientFederalIdNo: ").Append(RecipientFederalIdNo).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  StreetAddressLine2: ").Append(StreetAddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  ForeignProvince: ").Append(ForeignProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  AcctNo: ").Append(AcctNo).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
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
            // IssuerReferenceId (string) maxLength
            if (this.IssuerReferenceId != null && this.IssuerReferenceId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for IssuerReferenceId, length must be less than 50.", new [] { "IssuerReferenceId" });
            }

            if (this.IssuerReferenceId != null) {
                // IssuerReferenceId (string) pattern
                Regex regexIssuerReferenceId = new Regex(@"[a-z\d\-_ ]*", RegexOptions.CultureInvariant);
                if (!regexIssuerReferenceId.Match(this.IssuerReferenceId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerReferenceId, must match a pattern of " + regexIssuerReferenceId, new [] { "IssuerReferenceId" });
                }
            }

            if (this.IssuerTin != null) {
                // IssuerTin (string) pattern
                Regex regexIssuerTin = new Regex(@"[\s-]*([0-9][\s-]*){9}", RegexOptions.CultureInvariant);
                if (!regexIssuerTin.Match(this.IssuerTin).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerTin, must match a pattern of " + regexIssuerTin, new [] { "IssuerTin" });
                }
            }

            // ReferenceId (string) maxLength
            if (this.ReferenceId != null && this.ReferenceId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ReferenceId, length must be less than 50.", new [] { "ReferenceId" });
            }

            if (this.ReferenceId != null) {
                // ReferenceId (string) pattern
                Regex regexReferenceId = new Regex(@"[a-z\d\-_ ]*", RegexOptions.CultureInvariant);
                if (!regexReferenceId.Match(this.ReferenceId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceId, must match a pattern of " + regexReferenceId, new [] { "ReferenceId" });
                }
            }

            // RecipientName (string) maxLength
            if (this.RecipientName != null && this.RecipientName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for RecipientName, length must be less than 40.", new [] { "RecipientName" });
            }

            // RecipientName (string) minLength
            if (this.RecipientName != null && this.RecipientName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for RecipientName, length must be greater than 1.", new [] { "RecipientName" });
            }

            // RecipientSecondName (string) maxLength
            if (this.RecipientSecondName != null && this.RecipientSecondName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for RecipientSecondName, length must be less than 40.", new [] { "RecipientSecondName" });
            }

            // RecipientSecondName (string) minLength
            if (this.RecipientSecondName != null && this.RecipientSecondName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for RecipientSecondName, length must be greater than 1.", new [] { "RecipientSecondName" });
            }

            // StreetAddress (string) maxLength
            if (this.StreetAddress != null && this.StreetAddress.Length > 60)
            {
                yield return new ValidationResult("Invalid value for StreetAddress, length must be less than 60.", new [] { "StreetAddress" });
            }

            // StreetAddress (string) minLength
            if (this.StreetAddress != null && this.StreetAddress.Length < 1)
            {
                yield return new ValidationResult("Invalid value for StreetAddress, length must be greater than 1.", new [] { "StreetAddress" });
            }

            // StreetAddressLine2 (string) maxLength
            if (this.StreetAddressLine2 != null && this.StreetAddressLine2.Length > 60)
            {
                yield return new ValidationResult("Invalid value for StreetAddressLine2, length must be less than 60.", new [] { "StreetAddressLine2" });
            }

            // StreetAddressLine2 (string) minLength
            if (this.StreetAddressLine2 != null && this.StreetAddressLine2.Length < 1)
            {
                yield return new ValidationResult("Invalid value for StreetAddressLine2, length must be greater than 1.", new [] { "StreetAddressLine2" });
            }

            if (this.RecipientEmail != null) {
                // RecipientEmail (string) pattern
                Regex regexRecipientEmail = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,3}){1,2}", RegexOptions.CultureInvariant);
                if (!regexRecipientEmail.Match(this.RecipientEmail).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientEmail, must match a pattern of " + regexRecipientEmail, new [] { "RecipientEmail" });
                }
            }

            yield break;
        }
    }
}
