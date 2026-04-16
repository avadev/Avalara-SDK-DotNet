# Avalara.SDK.Model.EInvoicing.V1.StatusEvent
Displays when a status event occurred

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventDateTime** | **string** | The date and time when the status event occurred, displayed in the format YYYY-MM-DDThh:mm:ss | [optional] 
**Message** | **string** | A message describing the status event | [optional] 
**ResponseKey** | **string** |  The type of number or acknowledgement returned by the tax authority (if applicable). For example, it could be an identification key, acknowledgement code, or any other relevant identifier. | [optional] 
**ResponseValue** | **string** | The corresponding value associated with the response key. This value is provided by the tax authority in response to the event. | [optional] 
**Category** | **string** | Represents the functional area or process stage where the status event occurred. Useful for grouping related events such as document processing, transmission, or validation. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

