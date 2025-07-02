

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Avalara.SDK.Api.A1099.V2
{
    /// <summary>
    /// Represents the Request object for the BulkUpsert1099Forms API
    /// </summary>
    public class BulkUpsert1099FormsRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// 
        /// </summary>
        public bool? DryRun { get; set; }
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BulkUpsert1099FormsRequest BulkUpsert1099FormsRequest { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Create1099Form API
    /// </summary>
    public class Create1099FormRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICreateForm1099Request ICreateForm1099Request { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Delete1099Form API
    /// </summary>
    public class Delete1099FormRequestSdk {
        /// <summary>
        /// The unique identifier of the desired form to delete.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Get1099Form API
    /// </summary>
    public class Get1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Get1099FormPdf API
    /// </summary>
    public class Get1099FormPdfRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// The parameter for marked e-delivered
        /// </summary>
        public bool? MarkEdelivered { get; set; }
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the List1099Forms API
    /// </summary>
    public class List1099FormsRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.    Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.    Supported filtering fields are as follows:        issuerId      issuerReferenceId      taxYear      addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified      createdAt      edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted      email      federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held      recipientName      mailStatus - possible values are: sent, unscheduled, pending, delivered      referenceId      tinMatchStatus - possible values are: none, pending, matched, failed      type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC      updatedAt      validity - possible values are: true, false
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// If nonzero, return no more than this number of results.     Used with skip to provide pagination for large datasets.     Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records.
        /// </summary>
        public int? Top { get; set; }
        /// <summary>
        /// If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets.
        /// </summary>
        public int? Skip { get; set; }
        /// <summary>
        /// A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example issuerReferenceId ASC.    Supported sorting fields are:         issuerReferenceId       taxYear       createdAt       recipientName      updatedAt
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Update1099Form API
    /// </summary>
    public class Update1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// Identifies the software you are using to call this API. For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) .
        /// </summary>
        public string XAvalaraClient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IUpdateForm1099Request IUpdateForm1099Request { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IForms1099ApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates or updates multiple 1099 forms.
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;1099-MISC\&quot;,     \&quot;forms\&quot;: [         {             \&quot;IssuerId\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceId\&quot;: \&quot;REF123\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2023,             \&quot;ReferenceId\&quot;: \&quot;FORM123456\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientTin\&quot;: \&quot;987-65-4321\&quot;,             \&quot;TinType\&quot;: \&quot;IEN\&quot;,             \&quot;RecipientSecondName\&quot;: \&quot;Jane Doe\&quot;,             \&quot;Address\&quot;: \&quot;123 Main Street\&quot;,             \&quot;Address2\&quot;: \&quot;Apt 4B\&quot;,             \&quot;City\&quot;: \&quot;New York\&quot;,             \&quot;State\&quot;: \&quot;NY\&quot;,             \&quot;Zip\&quot;: \&quot;10001\&quot;,             \&quot;RecipientEmail\&quot;: \&quot;john.doe@email.com\&quot;,             \&quot;AccountNumber\&quot;: \&quot;ACC123456\&quot;,             \&quot;OfficeCode\&quot;: \&quot;NYC01\&quot;,             \&quot;SecondTinNotice\&quot;: false,             \&quot;RecipientNonUsProvince\&quot;: \&quot;\&quot;,             \&quot;CountryCode\&quot;: \&quot;US\&quot;,             \&quot;Rents\&quot;: 12000.00,             \&quot;Royalties\&quot;: 5000.00,             \&quot;OtherIncome\&quot;: 3000.00,             \&quot;FishingBoatProceeds\&quot;: 0.00,             \&quot;MedicalHealthCarePayments\&quot;: 15000.00,             \&quot;SubstitutePayments\&quot;: 1000.00,             \&quot;CropInsuranceProceeds\&quot;: 0.00,             \&quot;GrossProceedsPaidToAttorney\&quot;: 7500.00,             \&quot;FishPurchasedForResale\&quot;: 0.00,             \&quot;FedIncomeTaxWithheld\&quot;: 5000.00,             \&quot;Section409ADeferrals\&quot;: 0.00,             \&quot;ExcessGoldenParachutePayments\&quot;: 0.00,             \&quot;NonqualifiedDeferredCompensation\&quot;: 0.00,             \&quot;PayerMadeDirectSales\&quot;: false,             \&quot;FatcaFilingRequirement\&quot;: false,             \&quot;StateAndLocalWithholding\&quot;: {               \&quot;StateTaxWithheld\&quot;: 2500.00,               \&quot;LocalTaxWithheld\&quot;: 1000.00,               \&quot;State\&quot;: \&quot;NY\&quot;,               \&quot;StateIdNumber\&quot;: \&quot;NY123456\&quot;,               \&quot;Locality\&quot;: \&quot;New York City\&quot;,               \&quot;StateIncome\&quot;: 35000.00,               \&quot;LocalIncome\&quot;: 35000.00             }         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {    \&quot;formType\&quot;: \&quot;1099-NEC\&quot;,    \&quot;forms\&quot;: [      {        \&quot;issuerID\&quot;: \&quot;180337282\&quot;,        \&quot;issuerReferenceId\&quot;: \&quot;ISS123\&quot;,        \&quot;issuerTin\&quot;: \&quot;12-3000000\&quot;,        \&quot;taxYear\&quot;: 2024,        \&quot;referenceID\&quot;: \&quot;REF-002\&quot;,        \&quot;recipientName\&quot;: \&quot;Jane Smith\&quot;,        \&quot;recipientSecondName\&quot;: \&quot;\&quot;,        \&quot;recipientTin\&quot;: \&quot;987-65-4321\&quot;,        \&quot;tinType\&quot;: \&quot;IEN\&quot;,        \&quot;address\&quot;: \&quot;123 Center St\&quot;,        \&quot;address2\&quot;: \&quot;\&quot;,        \&quot;city\&quot;: \&quot;Santa Monica\&quot;,        \&quot;state\&quot;: \&quot;CA\&quot;,        \&quot;zip\&quot;: \&quot;90401\&quot;,        \&quot;countryCode\&quot;: \&quot;US\&quot;,        \&quot;recipientNonUsProvince\&quot;: \&quot;\&quot;,        \&quot;recipientEmail\&quot;: \&quot;\&quot;,        \&quot;accountNumber\&quot;: \&quot;\&quot;,        \&quot;officeCode\&quot;: \&quot;\&quot;,        \&quot;secondTinNotice\&quot;: false,        \&quot;nonemployeeCompensation\&quot;: 123.45,        \&quot;payerMadeDirectSales\&quot;: false,        \&quot;federalIncomeTaxWithheld\&quot;: 12.34,        \&quot;stateAndLocalWithholding\&quot;: {          \&quot;state\&quot;: \&quot;CA\&quot;,          \&quot;stateIdNumber\&quot;: \&quot;123123123\&quot;          \&quot;stateIncome\&quot;: 123.45,          \&quot;stateTaxWithheld\&quot;: 12.34,          \&quot;locality\&quot;: \&quot;Santa Monica\&quot;,          \&quot;localityIdNumber\&quot;: \&quot;456456\&quot;,          \&quot;localTaxWithheld\&quot;: 12.34          \&quot;localIncome\&quot;: 50000.00         },        \&quot;federalEFile\&quot;: true,        \&quot;postalMail\&quot;: true,        \&quot;stateEFile\&quot;: true,        \&quot;tinMatch\&quot;: true,        \&quot;addressVerification\&quot;: true       }     ]   }  &#x60;&#x60;&#x60;  For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099ProccessResult</returns>
        Form1099ProccessResult BulkUpsert1099Forms(BulkUpsert1099FormsRequestSdk requestParameters);

        /// <summary>
        /// Creates a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        Get1099Form200Response Create1099Form(Create1099FormRequestSdk requestParameters);

        /// <summary>
        /// Deletes a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void Delete1099Form(Delete1099FormRequestSdk requestParameters);

        /// <summary>
        /// Retrieves a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        Get1099Form200Response Get1099Form(Get1099FormRequestSdk requestParameters);

        /// <summary>
        /// Retrieves the PDF file for a single 1099 by form id.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Update1099Form200Response</returns>
        Update1099Form200Response Get1099FormPdf(Get1099FormPdfRequestSdk requestParameters);

        /// <summary>
        /// Retrieves a list of 1099 forms based on query parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099List</returns>
        Form1099List List1099Forms(List1099FormsRequestSdk requestParameters);

        /// <summary>
        /// Updates a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Update1099Form200Response</returns>
        Update1099Form200Response Update1099Form(Update1099FormRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IForms1099ApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Creates or updates multiple 1099 forms.
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;1099-MISC\&quot;,     \&quot;forms\&quot;: [         {             \&quot;IssuerId\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceId\&quot;: \&quot;REF123\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2023,             \&quot;ReferenceId\&quot;: \&quot;FORM123456\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientTin\&quot;: \&quot;987-65-4321\&quot;,             \&quot;TinType\&quot;: \&quot;IEN\&quot;,             \&quot;RecipientSecondName\&quot;: \&quot;Jane Doe\&quot;,             \&quot;Address\&quot;: \&quot;123 Main Street\&quot;,             \&quot;Address2\&quot;: \&quot;Apt 4B\&quot;,             \&quot;City\&quot;: \&quot;New York\&quot;,             \&quot;State\&quot;: \&quot;NY\&quot;,             \&quot;Zip\&quot;: \&quot;10001\&quot;,             \&quot;RecipientEmail\&quot;: \&quot;john.doe@email.com\&quot;,             \&quot;AccountNumber\&quot;: \&quot;ACC123456\&quot;,             \&quot;OfficeCode\&quot;: \&quot;NYC01\&quot;,             \&quot;SecondTinNotice\&quot;: false,             \&quot;RecipientNonUsProvince\&quot;: \&quot;\&quot;,             \&quot;CountryCode\&quot;: \&quot;US\&quot;,             \&quot;Rents\&quot;: 12000.00,             \&quot;Royalties\&quot;: 5000.00,             \&quot;OtherIncome\&quot;: 3000.00,             \&quot;FishingBoatProceeds\&quot;: 0.00,             \&quot;MedicalHealthCarePayments\&quot;: 15000.00,             \&quot;SubstitutePayments\&quot;: 1000.00,             \&quot;CropInsuranceProceeds\&quot;: 0.00,             \&quot;GrossProceedsPaidToAttorney\&quot;: 7500.00,             \&quot;FishPurchasedForResale\&quot;: 0.00,             \&quot;FedIncomeTaxWithheld\&quot;: 5000.00,             \&quot;Section409ADeferrals\&quot;: 0.00,             \&quot;ExcessGoldenParachutePayments\&quot;: 0.00,             \&quot;NonqualifiedDeferredCompensation\&quot;: 0.00,             \&quot;PayerMadeDirectSales\&quot;: false,             \&quot;FatcaFilingRequirement\&quot;: false,             \&quot;StateAndLocalWithholding\&quot;: {               \&quot;StateTaxWithheld\&quot;: 2500.00,               \&quot;LocalTaxWithheld\&quot;: 1000.00,               \&quot;State\&quot;: \&quot;NY\&quot;,               \&quot;StateIdNumber\&quot;: \&quot;NY123456\&quot;,               \&quot;Locality\&quot;: \&quot;New York City\&quot;,               \&quot;StateIncome\&quot;: 35000.00,               \&quot;LocalIncome\&quot;: 35000.00             }         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {    \&quot;formType\&quot;: \&quot;1099-NEC\&quot;,    \&quot;forms\&quot;: [      {        \&quot;issuerID\&quot;: \&quot;180337282\&quot;,        \&quot;issuerReferenceId\&quot;: \&quot;ISS123\&quot;,        \&quot;issuerTin\&quot;: \&quot;12-3000000\&quot;,        \&quot;taxYear\&quot;: 2024,        \&quot;referenceID\&quot;: \&quot;REF-002\&quot;,        \&quot;recipientName\&quot;: \&quot;Jane Smith\&quot;,        \&quot;recipientSecondName\&quot;: \&quot;\&quot;,        \&quot;recipientTin\&quot;: \&quot;987-65-4321\&quot;,        \&quot;tinType\&quot;: \&quot;IEN\&quot;,        \&quot;address\&quot;: \&quot;123 Center St\&quot;,        \&quot;address2\&quot;: \&quot;\&quot;,        \&quot;city\&quot;: \&quot;Santa Monica\&quot;,        \&quot;state\&quot;: \&quot;CA\&quot;,        \&quot;zip\&quot;: \&quot;90401\&quot;,        \&quot;countryCode\&quot;: \&quot;US\&quot;,        \&quot;recipientNonUsProvince\&quot;: \&quot;\&quot;,        \&quot;recipientEmail\&quot;: \&quot;\&quot;,        \&quot;accountNumber\&quot;: \&quot;\&quot;,        \&quot;officeCode\&quot;: \&quot;\&quot;,        \&quot;secondTinNotice\&quot;: false,        \&quot;nonemployeeCompensation\&quot;: 123.45,        \&quot;payerMadeDirectSales\&quot;: false,        \&quot;federalIncomeTaxWithheld\&quot;: 12.34,        \&quot;stateAndLocalWithholding\&quot;: {          \&quot;state\&quot;: \&quot;CA\&quot;,          \&quot;stateIdNumber\&quot;: \&quot;123123123\&quot;          \&quot;stateIncome\&quot;: 123.45,          \&quot;stateTaxWithheld\&quot;: 12.34,          \&quot;locality\&quot;: \&quot;Santa Monica\&quot;,          \&quot;localityIdNumber\&quot;: \&quot;456456\&quot;,          \&quot;localTaxWithheld\&quot;: 12.34          \&quot;localIncome\&quot;: 50000.00         },        \&quot;federalEFile\&quot;: true,        \&quot;postalMail\&quot;: true,        \&quot;stateEFile\&quot;: true,        \&quot;tinMatch\&quot;: true,        \&quot;addressVerification\&quot;: true       }     ]   }  &#x60;&#x60;&#x60;  For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099ProccessResult</returns>
        System.Threading.Tasks.Task<Form1099ProccessResult> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        System.Threading.Tasks.Task<Get1099Form200Response> Create1099FormAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        System.Threading.Tasks.Task<Get1099Form200Response> Get1099FormAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the PDF file for a single 1099 by form id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Update1099Form200Response</returns>
        System.Threading.Tasks.Task<Update1099Form200Response> Get1099FormPdfAsync(Get1099FormPdfRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves a list of 1099 forms based on query parameters.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099List</returns>
        System.Threading.Tasks.Task<Form1099List> List1099FormsAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Updates a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Update1099Form200Response</returns>
        System.Threading.Tasks.Task<Update1099Form200Response> Update1099FormAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Forms1099Api : IForms1099ApiSync, IForms1099ApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Forms1099Api"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public Forms1099Api(Avalara.SDK.Client.IApiClient client)
        {
             SetConfiguration(client);
             this.ExceptionFactory = Avalara.SDK.Client.Configuration.DefaultExceptionFactory;
        }       

        /// <summary>
        /// The client for accessing this underlying API.
        /// </summary>
        private Avalara.SDK.Client.IInternalApiClient Client { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        private Avalara.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Creates or updates multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;1099-MISC\&quot;,     \&quot;forms\&quot;: [         {             \&quot;IssuerId\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceId\&quot;: \&quot;REF123\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2023,             \&quot;ReferenceId\&quot;: \&quot;FORM123456\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientTin\&quot;: \&quot;987-65-4321\&quot;,             \&quot;TinType\&quot;: \&quot;IEN\&quot;,             \&quot;RecipientSecondName\&quot;: \&quot;Jane Doe\&quot;,             \&quot;Address\&quot;: \&quot;123 Main Street\&quot;,             \&quot;Address2\&quot;: \&quot;Apt 4B\&quot;,             \&quot;City\&quot;: \&quot;New York\&quot;,             \&quot;State\&quot;: \&quot;NY\&quot;,             \&quot;Zip\&quot;: \&quot;10001\&quot;,             \&quot;RecipientEmail\&quot;: \&quot;john.doe@email.com\&quot;,             \&quot;AccountNumber\&quot;: \&quot;ACC123456\&quot;,             \&quot;OfficeCode\&quot;: \&quot;NYC01\&quot;,             \&quot;SecondTinNotice\&quot;: false,             \&quot;RecipientNonUsProvince\&quot;: \&quot;\&quot;,             \&quot;CountryCode\&quot;: \&quot;US\&quot;,             \&quot;Rents\&quot;: 12000.00,             \&quot;Royalties\&quot;: 5000.00,             \&quot;OtherIncome\&quot;: 3000.00,             \&quot;FishingBoatProceeds\&quot;: 0.00,             \&quot;MedicalHealthCarePayments\&quot;: 15000.00,             \&quot;SubstitutePayments\&quot;: 1000.00,             \&quot;CropInsuranceProceeds\&quot;: 0.00,             \&quot;GrossProceedsPaidToAttorney\&quot;: 7500.00,             \&quot;FishPurchasedForResale\&quot;: 0.00,             \&quot;FedIncomeTaxWithheld\&quot;: 5000.00,             \&quot;Section409ADeferrals\&quot;: 0.00,             \&quot;ExcessGoldenParachutePayments\&quot;: 0.00,             \&quot;NonqualifiedDeferredCompensation\&quot;: 0.00,             \&quot;PayerMadeDirectSales\&quot;: false,             \&quot;FatcaFilingRequirement\&quot;: false,             \&quot;StateAndLocalWithholding\&quot;: {               \&quot;StateTaxWithheld\&quot;: 2500.00,               \&quot;LocalTaxWithheld\&quot;: 1000.00,               \&quot;State\&quot;: \&quot;NY\&quot;,               \&quot;StateIdNumber\&quot;: \&quot;NY123456\&quot;,               \&quot;Locality\&quot;: \&quot;New York City\&quot;,               \&quot;StateIncome\&quot;: 35000.00,               \&quot;LocalIncome\&quot;: 35000.00             }         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {    \&quot;formType\&quot;: \&quot;1099-NEC\&quot;,    \&quot;forms\&quot;: [      {        \&quot;issuerID\&quot;: \&quot;180337282\&quot;,        \&quot;issuerReferenceId\&quot;: \&quot;ISS123\&quot;,        \&quot;issuerTin\&quot;: \&quot;12-3000000\&quot;,        \&quot;taxYear\&quot;: 2024,        \&quot;referenceID\&quot;: \&quot;REF-002\&quot;,        \&quot;recipientName\&quot;: \&quot;Jane Smith\&quot;,        \&quot;recipientSecondName\&quot;: \&quot;\&quot;,        \&quot;recipientTin\&quot;: \&quot;987-65-4321\&quot;,        \&quot;tinType\&quot;: \&quot;IEN\&quot;,        \&quot;address\&quot;: \&quot;123 Center St\&quot;,        \&quot;address2\&quot;: \&quot;\&quot;,        \&quot;city\&quot;: \&quot;Santa Monica\&quot;,        \&quot;state\&quot;: \&quot;CA\&quot;,        \&quot;zip\&quot;: \&quot;90401\&quot;,        \&quot;countryCode\&quot;: \&quot;US\&quot;,        \&quot;recipientNonUsProvince\&quot;: \&quot;\&quot;,        \&quot;recipientEmail\&quot;: \&quot;\&quot;,        \&quot;accountNumber\&quot;: \&quot;\&quot;,        \&quot;officeCode\&quot;: \&quot;\&quot;,        \&quot;secondTinNotice\&quot;: false,        \&quot;nonemployeeCompensation\&quot;: 123.45,        \&quot;payerMadeDirectSales\&quot;: false,        \&quot;federalIncomeTaxWithheld\&quot;: 12.34,        \&quot;stateAndLocalWithholding\&quot;: {          \&quot;state\&quot;: \&quot;CA\&quot;,          \&quot;stateIdNumber\&quot;: \&quot;123123123\&quot;          \&quot;stateIncome\&quot;: 123.45,          \&quot;stateTaxWithheld\&quot;: 12.34,          \&quot;locality\&quot;: \&quot;Santa Monica\&quot;,          \&quot;localityIdNumber\&quot;: \&quot;456456\&quot;,          \&quot;localTaxWithheld\&quot;: 12.34          \&quot;localIncome\&quot;: 50000.00         },        \&quot;federalEFile\&quot;: true,        \&quot;postalMail\&quot;: true,        \&quot;stateEFile\&quot;: true,        \&quot;tinMatch\&quot;: true,        \&quot;addressVerification\&quot;: true       }     ]   }  &#x60;&#x60;&#x60;  For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099ProccessResult</returns>
        public Form1099ProccessResult BulkUpsert1099Forms(BulkUpsert1099FormsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Form1099ProccessResult> localVarResponse = BulkUpsert1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates or updates multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;1099-MISC\&quot;,     \&quot;forms\&quot;: [         {             \&quot;IssuerId\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceId\&quot;: \&quot;REF123\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2023,             \&quot;ReferenceId\&quot;: \&quot;FORM123456\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientTin\&quot;: \&quot;987-65-4321\&quot;,             \&quot;TinType\&quot;: \&quot;IEN\&quot;,             \&quot;RecipientSecondName\&quot;: \&quot;Jane Doe\&quot;,             \&quot;Address\&quot;: \&quot;123 Main Street\&quot;,             \&quot;Address2\&quot;: \&quot;Apt 4B\&quot;,             \&quot;City\&quot;: \&quot;New York\&quot;,             \&quot;State\&quot;: \&quot;NY\&quot;,             \&quot;Zip\&quot;: \&quot;10001\&quot;,             \&quot;RecipientEmail\&quot;: \&quot;john.doe@email.com\&quot;,             \&quot;AccountNumber\&quot;: \&quot;ACC123456\&quot;,             \&quot;OfficeCode\&quot;: \&quot;NYC01\&quot;,             \&quot;SecondTinNotice\&quot;: false,             \&quot;RecipientNonUsProvince\&quot;: \&quot;\&quot;,             \&quot;CountryCode\&quot;: \&quot;US\&quot;,             \&quot;Rents\&quot;: 12000.00,             \&quot;Royalties\&quot;: 5000.00,             \&quot;OtherIncome\&quot;: 3000.00,             \&quot;FishingBoatProceeds\&quot;: 0.00,             \&quot;MedicalHealthCarePayments\&quot;: 15000.00,             \&quot;SubstitutePayments\&quot;: 1000.00,             \&quot;CropInsuranceProceeds\&quot;: 0.00,             \&quot;GrossProceedsPaidToAttorney\&quot;: 7500.00,             \&quot;FishPurchasedForResale\&quot;: 0.00,             \&quot;FedIncomeTaxWithheld\&quot;: 5000.00,             \&quot;Section409ADeferrals\&quot;: 0.00,             \&quot;ExcessGoldenParachutePayments\&quot;: 0.00,             \&quot;NonqualifiedDeferredCompensation\&quot;: 0.00,             \&quot;PayerMadeDirectSales\&quot;: false,             \&quot;FatcaFilingRequirement\&quot;: false,             \&quot;StateAndLocalWithholding\&quot;: {               \&quot;StateTaxWithheld\&quot;: 2500.00,               \&quot;LocalTaxWithheld\&quot;: 1000.00,               \&quot;State\&quot;: \&quot;NY\&quot;,               \&quot;StateIdNumber\&quot;: \&quot;NY123456\&quot;,               \&quot;Locality\&quot;: \&quot;New York City\&quot;,               \&quot;StateIncome\&quot;: 35000.00,               \&quot;LocalIncome\&quot;: 35000.00             }         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {    \&quot;formType\&quot;: \&quot;1099-NEC\&quot;,    \&quot;forms\&quot;: [      {        \&quot;issuerID\&quot;: \&quot;180337282\&quot;,        \&quot;issuerReferenceId\&quot;: \&quot;ISS123\&quot;,        \&quot;issuerTin\&quot;: \&quot;12-3000000\&quot;,        \&quot;taxYear\&quot;: 2024,        \&quot;referenceID\&quot;: \&quot;REF-002\&quot;,        \&quot;recipientName\&quot;: \&quot;Jane Smith\&quot;,        \&quot;recipientSecondName\&quot;: \&quot;\&quot;,        \&quot;recipientTin\&quot;: \&quot;987-65-4321\&quot;,        \&quot;tinType\&quot;: \&quot;IEN\&quot;,        \&quot;address\&quot;: \&quot;123 Center St\&quot;,        \&quot;address2\&quot;: \&quot;\&quot;,        \&quot;city\&quot;: \&quot;Santa Monica\&quot;,        \&quot;state\&quot;: \&quot;CA\&quot;,        \&quot;zip\&quot;: \&quot;90401\&quot;,        \&quot;countryCode\&quot;: \&quot;US\&quot;,        \&quot;recipientNonUsProvince\&quot;: \&quot;\&quot;,        \&quot;recipientEmail\&quot;: \&quot;\&quot;,        \&quot;accountNumber\&quot;: \&quot;\&quot;,        \&quot;officeCode\&quot;: \&quot;\&quot;,        \&quot;secondTinNotice\&quot;: false,        \&quot;nonemployeeCompensation\&quot;: 123.45,        \&quot;payerMadeDirectSales\&quot;: false,        \&quot;federalIncomeTaxWithheld\&quot;: 12.34,        \&quot;stateAndLocalWithholding\&quot;: {          \&quot;state\&quot;: \&quot;CA\&quot;,          \&quot;stateIdNumber\&quot;: \&quot;123123123\&quot;          \&quot;stateIncome\&quot;: 123.45,          \&quot;stateTaxWithheld\&quot;: 12.34,          \&quot;locality\&quot;: \&quot;Santa Monica\&quot;,          \&quot;localityIdNumber\&quot;: \&quot;456456\&quot;,          \&quot;localTaxWithheld\&quot;: 12.34          \&quot;localIncome\&quot;: 50000.00         },        \&quot;federalEFile\&quot;: true,        \&quot;postalMail\&quot;: true,        \&quot;stateEFile\&quot;: true,        \&quot;tinMatch\&quot;: true,        \&quot;addressVerification\&quot;: true       }     ]   }  &#x60;&#x60;&#x60;  For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Form1099ProccessResult</returns>
        private Avalara.SDK.Client.ApiResponse<Form1099ProccessResult> BulkUpsert1099FormsWithHttpInfo(BulkUpsert1099FormsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->BulkUpsert1099Forms");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.DryRun != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "dryRun", requestParameters.DryRun));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.BulkUpsert1099FormsRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Form1099ProccessResult>("/1099/forms/$bulk-upsert", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Creates or updates multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;1099-MISC\&quot;,     \&quot;forms\&quot;: [         {             \&quot;IssuerId\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceId\&quot;: \&quot;REF123\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2023,             \&quot;ReferenceId\&quot;: \&quot;FORM123456\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientTin\&quot;: \&quot;987-65-4321\&quot;,             \&quot;TinType\&quot;: \&quot;IEN\&quot;,             \&quot;RecipientSecondName\&quot;: \&quot;Jane Doe\&quot;,             \&quot;Address\&quot;: \&quot;123 Main Street\&quot;,             \&quot;Address2\&quot;: \&quot;Apt 4B\&quot;,             \&quot;City\&quot;: \&quot;New York\&quot;,             \&quot;State\&quot;: \&quot;NY\&quot;,             \&quot;Zip\&quot;: \&quot;10001\&quot;,             \&quot;RecipientEmail\&quot;: \&quot;john.doe@email.com\&quot;,             \&quot;AccountNumber\&quot;: \&quot;ACC123456\&quot;,             \&quot;OfficeCode\&quot;: \&quot;NYC01\&quot;,             \&quot;SecondTinNotice\&quot;: false,             \&quot;RecipientNonUsProvince\&quot;: \&quot;\&quot;,             \&quot;CountryCode\&quot;: \&quot;US\&quot;,             \&quot;Rents\&quot;: 12000.00,             \&quot;Royalties\&quot;: 5000.00,             \&quot;OtherIncome\&quot;: 3000.00,             \&quot;FishingBoatProceeds\&quot;: 0.00,             \&quot;MedicalHealthCarePayments\&quot;: 15000.00,             \&quot;SubstitutePayments\&quot;: 1000.00,             \&quot;CropInsuranceProceeds\&quot;: 0.00,             \&quot;GrossProceedsPaidToAttorney\&quot;: 7500.00,             \&quot;FishPurchasedForResale\&quot;: 0.00,             \&quot;FedIncomeTaxWithheld\&quot;: 5000.00,             \&quot;Section409ADeferrals\&quot;: 0.00,             \&quot;ExcessGoldenParachutePayments\&quot;: 0.00,             \&quot;NonqualifiedDeferredCompensation\&quot;: 0.00,             \&quot;PayerMadeDirectSales\&quot;: false,             \&quot;FatcaFilingRequirement\&quot;: false,             \&quot;StateAndLocalWithholding\&quot;: {               \&quot;StateTaxWithheld\&quot;: 2500.00,               \&quot;LocalTaxWithheld\&quot;: 1000.00,               \&quot;State\&quot;: \&quot;NY\&quot;,               \&quot;StateIdNumber\&quot;: \&quot;NY123456\&quot;,               \&quot;Locality\&quot;: \&quot;New York City\&quot;,               \&quot;StateIncome\&quot;: 35000.00,               \&quot;LocalIncome\&quot;: 35000.00             }         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {    \&quot;formType\&quot;: \&quot;1099-NEC\&quot;,    \&quot;forms\&quot;: [      {        \&quot;issuerID\&quot;: \&quot;180337282\&quot;,        \&quot;issuerReferenceId\&quot;: \&quot;ISS123\&quot;,        \&quot;issuerTin\&quot;: \&quot;12-3000000\&quot;,        \&quot;taxYear\&quot;: 2024,        \&quot;referenceID\&quot;: \&quot;REF-002\&quot;,        \&quot;recipientName\&quot;: \&quot;Jane Smith\&quot;,        \&quot;recipientSecondName\&quot;: \&quot;\&quot;,        \&quot;recipientTin\&quot;: \&quot;987-65-4321\&quot;,        \&quot;tinType\&quot;: \&quot;IEN\&quot;,        \&quot;address\&quot;: \&quot;123 Center St\&quot;,        \&quot;address2\&quot;: \&quot;\&quot;,        \&quot;city\&quot;: \&quot;Santa Monica\&quot;,        \&quot;state\&quot;: \&quot;CA\&quot;,        \&quot;zip\&quot;: \&quot;90401\&quot;,        \&quot;countryCode\&quot;: \&quot;US\&quot;,        \&quot;recipientNonUsProvince\&quot;: \&quot;\&quot;,        \&quot;recipientEmail\&quot;: \&quot;\&quot;,        \&quot;accountNumber\&quot;: \&quot;\&quot;,        \&quot;officeCode\&quot;: \&quot;\&quot;,        \&quot;secondTinNotice\&quot;: false,        \&quot;nonemployeeCompensation\&quot;: 123.45,        \&quot;payerMadeDirectSales\&quot;: false,        \&quot;federalIncomeTaxWithheld\&quot;: 12.34,        \&quot;stateAndLocalWithholding\&quot;: {          \&quot;state\&quot;: \&quot;CA\&quot;,          \&quot;stateIdNumber\&quot;: \&quot;123123123\&quot;          \&quot;stateIncome\&quot;: 123.45,          \&quot;stateTaxWithheld\&quot;: 12.34,          \&quot;locality\&quot;: \&quot;Santa Monica\&quot;,          \&quot;localityIdNumber\&quot;: \&quot;456456\&quot;,          \&quot;localTaxWithheld\&quot;: 12.34          \&quot;localIncome\&quot;: 50000.00         },        \&quot;federalEFile\&quot;: true,        \&quot;postalMail\&quot;: true,        \&quot;stateEFile\&quot;: true,        \&quot;tinMatch\&quot;: true,        \&quot;addressVerification\&quot;: true       }     ]   }  &#x60;&#x60;&#x60;  For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099ProccessResult</returns>
        public async System.Threading.Tasks.Task<Form1099ProccessResult> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Form1099ProccessResult> localVarResponse = await BulkUpsert1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates or updates multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;1099-MISC\&quot;,     \&quot;forms\&quot;: [         {             \&quot;IssuerId\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceId\&quot;: \&quot;REF123\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2023,             \&quot;ReferenceId\&quot;: \&quot;FORM123456\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientTin\&quot;: \&quot;987-65-4321\&quot;,             \&quot;TinType\&quot;: \&quot;IEN\&quot;,             \&quot;RecipientSecondName\&quot;: \&quot;Jane Doe\&quot;,             \&quot;Address\&quot;: \&quot;123 Main Street\&quot;,             \&quot;Address2\&quot;: \&quot;Apt 4B\&quot;,             \&quot;City\&quot;: \&quot;New York\&quot;,             \&quot;State\&quot;: \&quot;NY\&quot;,             \&quot;Zip\&quot;: \&quot;10001\&quot;,             \&quot;RecipientEmail\&quot;: \&quot;john.doe@email.com\&quot;,             \&quot;AccountNumber\&quot;: \&quot;ACC123456\&quot;,             \&quot;OfficeCode\&quot;: \&quot;NYC01\&quot;,             \&quot;SecondTinNotice\&quot;: false,             \&quot;RecipientNonUsProvince\&quot;: \&quot;\&quot;,             \&quot;CountryCode\&quot;: \&quot;US\&quot;,             \&quot;Rents\&quot;: 12000.00,             \&quot;Royalties\&quot;: 5000.00,             \&quot;OtherIncome\&quot;: 3000.00,             \&quot;FishingBoatProceeds\&quot;: 0.00,             \&quot;MedicalHealthCarePayments\&quot;: 15000.00,             \&quot;SubstitutePayments\&quot;: 1000.00,             \&quot;CropInsuranceProceeds\&quot;: 0.00,             \&quot;GrossProceedsPaidToAttorney\&quot;: 7500.00,             \&quot;FishPurchasedForResale\&quot;: 0.00,             \&quot;FedIncomeTaxWithheld\&quot;: 5000.00,             \&quot;Section409ADeferrals\&quot;: 0.00,             \&quot;ExcessGoldenParachutePayments\&quot;: 0.00,             \&quot;NonqualifiedDeferredCompensation\&quot;: 0.00,             \&quot;PayerMadeDirectSales\&quot;: false,             \&quot;FatcaFilingRequirement\&quot;: false,             \&quot;StateAndLocalWithholding\&quot;: {               \&quot;StateTaxWithheld\&quot;: 2500.00,               \&quot;LocalTaxWithheld\&quot;: 1000.00,               \&quot;State\&quot;: \&quot;NY\&quot;,               \&quot;StateIdNumber\&quot;: \&quot;NY123456\&quot;,               \&quot;Locality\&quot;: \&quot;New York City\&quot;,               \&quot;StateIncome\&quot;: 35000.00,               \&quot;LocalIncome\&quot;: 35000.00             }         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {    \&quot;formType\&quot;: \&quot;1099-NEC\&quot;,    \&quot;forms\&quot;: [      {        \&quot;issuerID\&quot;: \&quot;180337282\&quot;,        \&quot;issuerReferenceId\&quot;: \&quot;ISS123\&quot;,        \&quot;issuerTin\&quot;: \&quot;12-3000000\&quot;,        \&quot;taxYear\&quot;: 2024,        \&quot;referenceID\&quot;: \&quot;REF-002\&quot;,        \&quot;recipientName\&quot;: \&quot;Jane Smith\&quot;,        \&quot;recipientSecondName\&quot;: \&quot;\&quot;,        \&quot;recipientTin\&quot;: \&quot;987-65-4321\&quot;,        \&quot;tinType\&quot;: \&quot;IEN\&quot;,        \&quot;address\&quot;: \&quot;123 Center St\&quot;,        \&quot;address2\&quot;: \&quot;\&quot;,        \&quot;city\&quot;: \&quot;Santa Monica\&quot;,        \&quot;state\&quot;: \&quot;CA\&quot;,        \&quot;zip\&quot;: \&quot;90401\&quot;,        \&quot;countryCode\&quot;: \&quot;US\&quot;,        \&quot;recipientNonUsProvince\&quot;: \&quot;\&quot;,        \&quot;recipientEmail\&quot;: \&quot;\&quot;,        \&quot;accountNumber\&quot;: \&quot;\&quot;,        \&quot;officeCode\&quot;: \&quot;\&quot;,        \&quot;secondTinNotice\&quot;: false,        \&quot;nonemployeeCompensation\&quot;: 123.45,        \&quot;payerMadeDirectSales\&quot;: false,        \&quot;federalIncomeTaxWithheld\&quot;: 12.34,        \&quot;stateAndLocalWithholding\&quot;: {          \&quot;state\&quot;: \&quot;CA\&quot;,          \&quot;stateIdNumber\&quot;: \&quot;123123123\&quot;          \&quot;stateIncome\&quot;: 123.45,          \&quot;stateTaxWithheld\&quot;: 12.34,          \&quot;locality\&quot;: \&quot;Santa Monica\&quot;,          \&quot;localityIdNumber\&quot;: \&quot;456456\&quot;,          \&quot;localTaxWithheld\&quot;: 12.34          \&quot;localIncome\&quot;: 50000.00         },        \&quot;federalEFile\&quot;: true,        \&quot;postalMail\&quot;: true,        \&quot;stateEFile\&quot;: true,        \&quot;tinMatch\&quot;: true,        \&quot;addressVerification\&quot;: true       }     ]   }  &#x60;&#x60;&#x60;  For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Form1099ProccessResult)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Form1099ProccessResult>> BulkUpsert1099FormsWithHttpInfoAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->BulkUpsert1099Forms");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.DryRun != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "dryRun", requestParameters.DryRun));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.BulkUpsert1099FormsRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Form1099ProccessResult>("/1099/forms/$bulk-upsert", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Creates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        public Get1099Form200Response Create1099Form(Create1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = Create1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Get1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Get1099Form200Response> Create1099FormWithHttpInfo(Create1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Create1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.ICreateForm1099Request;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Get1099Form200Response>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Creates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Get1099Form200Response> Create1099FormAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = await Create1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Get1099Form200Response>> Create1099FormWithHttpInfoAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Create1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.ICreateForm1099Request;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Get1099Form200Response>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletes a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void Delete1099Form(Delete1099FormRequestSdk requestParameters)
        {
            Delete1099FormWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Deletes a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> Delete1099FormWithHttpInfo(Delete1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Delete1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Delete1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletes a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await Delete1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> Delete1099FormWithHttpInfoAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Delete1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Delete1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Get1099Form200Response</returns>
        public Get1099Form200Response Get1099Form(Get1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = Get1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Get1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Get1099Form200Response> Get1099FormWithHttpInfo(Get1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Get1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Get1099Form200Response> Get1099FormAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Get1099Form200Response> localVarResponse = await Get1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Get1099Form200Response>> Get1099FormWithHttpInfoAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Get1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the PDF file for a single 1099 by form id. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Update1099Form200Response</returns>
        public Update1099Form200Response Get1099FormPdf(Get1099FormPdfRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Update1099Form200Response> localVarResponse = Get1099FormPdfWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the PDF file for a single 1099 by form id. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Update1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Update1099Form200Response> Get1099FormPdfWithHttpInfo(Get1099FormPdfRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099FormPdf");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099FormPdf");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            if (requestParameters.MarkEdelivered != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "markEdelivered", requestParameters.MarkEdelivered));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Update1099Form200Response>("/1099/forms/{id}/pdf", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099FormPdf", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the PDF file for a single 1099 by form id. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Update1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Update1099Form200Response> Get1099FormPdfAsync(Get1099FormPdfRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Update1099Form200Response> localVarResponse = await Get1099FormPdfWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the PDF file for a single 1099 by form id. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Update1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Update1099Form200Response>> Get1099FormPdfWithHttpInfoAsync(Get1099FormPdfRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Get1099FormPdf");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Get1099FormPdf");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            if (requestParameters.MarkEdelivered != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "markEdelivered", requestParameters.MarkEdelivered));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Update1099Form200Response>("/1099/forms/{id}/pdf", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099FormPdf", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099List</returns>
        public Form1099List List1099Forms(List1099FormsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Form1099List> localVarResponse = List1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Form1099List</returns>
        private Avalara.SDK.Client.ApiResponse<Form1099List> List1099FormsWithHttpInfo(List1099FormsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->List1099Forms");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.Filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", requestParameters.Filter));
            }
            if (requestParameters.Top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", requestParameters.Top));
            }
            if (requestParameters.Skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", requestParameters.Skip));
            }
            if (requestParameters.OrderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", requestParameters.OrderBy));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Form1099List>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099List</returns>
        public async System.Threading.Tasks.Task<Form1099List> List1099FormsAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Form1099List> localVarResponse = await List1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Form1099List)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Form1099List>> List1099FormsWithHttpInfoAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->List1099Forms");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.Filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", requestParameters.Filter));
            }
            if (requestParameters.Top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", requestParameters.Top));
            }
            if (requestParameters.Skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", requestParameters.Skip));
            }
            if (requestParameters.OrderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", requestParameters.OrderBy));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Form1099List>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Updates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Update1099Form200Response</returns>
        public Update1099Form200Response Update1099Form(Update1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Update1099Form200Response> localVarResponse = Update1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Update1099Form200Response</returns>
        private Avalara.SDK.Client.ApiResponse<Update1099Form200Response> Update1099FormWithHttpInfo(Update1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Update1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Update1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.IUpdateForm1099Request;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Update1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Updates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Update1099Form200Response</returns>
        public async System.Threading.Tasks.Task<Update1099Form200Response> Update1099FormAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Update1099Form200Response> localVarResponse = await Update1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Update1099Form200Response)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Update1099Form200Response>> Update1099FormWithHttpInfoAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Forms1099Api->Update1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Forms1099Api->Update1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            if (requestParameters.XCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            }
            if (requestParameters.XAvalaraClient != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XAvalaraClient)); // header parameter
            }
            localVarRequestOptions.Data = requestParameters.IUpdateForm1099Request;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Update1099Form200Response>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the configuration object in APIClient
        /// </summary>        
        private void SetConfiguration(IApiClient client)
        {
            if (client == null) throw new ArgumentNullException("ApiClient");
            if (client.Configuration == null) throw new ArgumentNullException("ApiClient.Configuration");

            this.Client = (IInternalApiClient)client;
            this.Client.SdkVersion = "25.7.0";
        }
        
    }

    
}
