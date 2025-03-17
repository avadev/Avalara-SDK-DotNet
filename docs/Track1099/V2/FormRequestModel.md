# Avalara.SDK.Model.Track1099.V2.FormRequestModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**FormType** | **string** | \&quot;W9\&quot; is currently the only supported value | [optional] 
**CompanyId** | **int** | Track1099&#39;s ID of your company, found in the W-9 UI | [optional] 
**CompanyName** | **string** | Name of your company, set in the W-9 UI | [optional] 
**CompanyEmail** | **string** | Contact email of your company, set in the W-9 UI | [optional] 
**ReferenceId** | **string** | Your internal identifier for the vendor from whom you are requesting a form | [optional] 
**SignedAt** | **DateTime** | The timestamp this vendor (identified by your ReferenceId) last signed a complete W-9, null if you did not include a ReferenceId or the vendor has not yet signed a W-9 in Track1099 | [optional] 
**TinMatchStatus** | **string** | Result of IRS TIN match query for name and TIN in the last signed form, null if signed_at is null | [optional] 
**ExpiresAt** | **DateTime** | Timestamp when this FormRequest will expire, ttl (or 3600) seconds from creation | [optional] 
**SignedPdf** | **string** | URL of PDF representation of just-signed form, otherwise null. Integrations may use this value to offer a \&quot;download for your records\&quot; function after a vendor completes and signs a form. Link expires at the same time as this FormRequest. Treat the format of this URL as opaque and expect it to change in the future. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

