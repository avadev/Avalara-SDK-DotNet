# Avalara.SDK.Model.A1099.V2.AuthorizedApiRequestV2DataModel
Describes a one-time-use URL that, when accessed, executes the API request specified in path using the account and credentials you used to create this AuthorizedApiRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Path** | **string** | The path and query of the API request you want to pre-authorize | [optional] 
**ExpiresAt** | **string** | Timestamp when this AuthorizedApiRequest will expire, ttl (or 3600) seconds from creation | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

