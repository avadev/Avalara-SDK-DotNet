# Avalara.SDK.Model.EInvoicing.V1.WebhookInvocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique identifier of this specific resource. | 
**RetryCount** | **int** | The number of invocation attempts. | [optional] 
**RetryMax** | **int** | The maximum retries that may be attempted in total. | [optional] 
**InvocationTimestamp** | **DateTime** | Initial timestamp of the first invocation attempt. | 
**RetryTimestamp** | **DateTime** | Timestamp of this invocation attempt. | [optional] 
**Items** | [**List&lt;EventMessage&gt;**](EventMessage.md) | Array of events being delivered in the webhook | 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

