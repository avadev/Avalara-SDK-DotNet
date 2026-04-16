# Avalara.SDK.Model.EInvoicing.V1.ReportListResponse
Returns the requested list of reports matching the query parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordsetCount** | **string** | Count of reports matching the filter for the given query. Present when the request includes $count&#x3D;true. | [optional] 
**NextLink** | **string** | URL to retrieve the next page of results when more items match the query. Omitted or null when there is no next page. | [optional] 
**Value** | [**List&lt;ReportItem&gt;**](ReportItem.md) | Array of reports matching the query parameters. | 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

