# Avalara.SDK.Model.EInvoicing.V1.EventMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **Object** | Event-specific information | 
**Signature** | [**SignatureValueSignature**](SignatureValueSignature.md) |  | 
**TenantId** | **string** | Tenant ID of the event | 
**CorrelationId** | **string** | The correlation ID used by Avalara to aid in tracing through to provenance of this event massage. | [optional] 
**SystemCode** | **string** | The Avalara registered code for the system. See &lt;a href&#x3D;\&quot;https://avalara.atlassian.net/wiki/spaces/AIM/pages/637250338966/Taxonomy+Avalara+Systems\&quot;&gt;Taxonomy&amp;#58; Avalara Systems&lt;/a&gt; | 
**EventName** | **string** | Type of the event | 
**EventVersion** | **string** | Version of the included payload. | [optional] 
**ReceiptTimestamp** | **DateTime** | Timestamp when the event was received by the dispatch service. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

