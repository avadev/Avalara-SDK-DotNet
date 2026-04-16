# Avalara.SDK.Model.EInvoicing.V1.DocumentStatusResponse
Returns the current document ID and status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID for this document | [optional] 
**Status** | **string** | Document status. See the &#x60;supportedDocumentStatuses&#x60; field in the GET /mandates response for full status definitions. | [optional] 
**BusinessStatus** | **string** | Represents the document&#39;s business lifecycle state based on responses from external actors (Tax Authority, PDP, or ERP), such as acceptance, rejection, or validation. | [optional] 
**Events** | [**List&lt;StatusEvent&gt;**](StatusEvent.md) |  | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

