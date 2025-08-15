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
    /// FormRequestListItemBase
    /// </summary>
    [DataContract(Name = "FormRequestListItemBase")]
    public partial class FormRequestListItemBase : IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="FormRequestListItemBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormRequestListItemBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRequestListItemBase" /> class.
        /// </summary>
        /// <param name="issuerReferenceId">Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required..</param>
        /// <param name="issuerTin">Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required..</param>
        /// <param name="taxYear">Tax year (required).</param>
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
        /// <param name="noTin">Indicates whether the recipient has no TIN.</param>
        /// <param name="secondTinNotice">Second TIN notice in three years.</param>
        /// <param name="fatcaFilingRequirement">Fatca filing requirement.</param>
        /// <param name="addressVerification">Boolean indicating that address verification should be scheduled for this form.</param>
        /// <param name="stateAndLocalWithholding">State and local withholding information.</param>
        public FormRequestListItemBase(string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), string issuerId = default(string), string referenceId = default(string), string recipientTin = default(string), string recipientName = default(string), TinTypeEnum? tinType = default(TinTypeEnum?), string recipientSecondName = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string email = default(string), string accountNumber = default(string), string officeCode = default(string), string nonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool noTin = default(bool), bool? secondTinNotice = default(bool?), bool fatcaFilingRequirement = default(bool), bool addressVerification = default(bool), StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest))
        {
            this.TaxYear = taxYear;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
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
            this.NoTin = noTin;
            this.SecondTinNotice = secondTinNotice;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.AddressVerification = addressVerification;
            this.StateAndLocalWithholding = stateAndLocalWithholding;
        }

        /// <summary>
        /// Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.
        /// </summary>
        /// <value>Issuer Reference ID. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.</value>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = true)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.
        /// </summary>
        /// <value>Issuer TIN. One of &#x60;issuerReferenceId&#x60; or &#x60;issuerTin&#x60; is required.</value>
        [DataMember(Name = "issuerTin", EmitDefaultValue = true)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Tax year
        /// </summary>
        /// <value>Tax year</value>
        [DataMember(Name = "taxYear", IsRequired = true, EmitDefaultValue = true)]
        public int TaxYear { get; set; }

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
        /// Indicates whether the recipient has no TIN
        /// </summary>
        /// <value>Indicates whether the recipient has no TIN</value>
        [DataMember(Name = "noTin", EmitDefaultValue = true)]
        public bool NoTin { get; set; }

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
            sb.Append("class FormRequestListItemBase {\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
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
            sb.Append("  NoTin: ").Append(NoTin).Append("\n");
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
