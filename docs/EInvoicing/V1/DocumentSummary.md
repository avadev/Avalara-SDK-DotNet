# Avalara.SDK.Model.EInvoicing.V1.DocumentSummary
Displays a summary of information about the document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID for this document | [optional] 
**CompanyId** | **string** | Unique identifier that represents the company within the system. | [optional] 
**ProcessDateTime** | **string** | The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss | [optional] 
**Status** | **string** | The Document status | [optional] 
**BusinessStatus** | **string** | Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation. | [optional] 
**SupplierName** | **string** | The name of the supplier in the transaction | [optional] 
**CustomerName** | **string** | The name of the customer in the transaction | [optional] 
**DocumentType** | **string** | The document type | [optional] 
**DocumentVersion** | **string** | The document version | [optional] 
**DocumentNumber** | **string** | The document number | [optional] 
**DocumentDate** | **string** | The document issue date | [optional] 
**Flow** | **string** | The document direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60; | [optional] 
**CountryCode** | **string** | The two-letter ISO-3166 country code for the country where the document is being submitted | [optional] 
**CountryMandate** | **string** | The e-invoicing mandate for the specified country | [optional] 
**Interface** | **string** | The interface where the document is sent | [optional] 
**Receiver** | **string** | The document recipient based on the interface | [optional] 
**Events** | [**List&lt;StatusEvent&gt;**](StatusEvent.md) | Array of status events associated with this document. Events are included in each document in the response only when the query parameter $include&#x3D;events is passed; otherwise the events array is not populated. | [optional] 
**CreatedAt** | **string** | The date and time when the document was created in the system, displayed in ISO 8601 format with timezone | [optional] 
**LastUpdatedAt** | **string** | The date and time when the document was last updated in the system, displayed in ISO 8601 format with timezone | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

