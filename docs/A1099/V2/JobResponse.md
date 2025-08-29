# Avalara.SDK.Model.A1099.V2.JobResponse
Response model for job operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the job | [optional] 
**Type** | **string** | Job type identifier. Will always be \&quot;update_job\&quot; for bulk upsert operations | [optional] 
**Status** | **string** | Current status of the job (e.g., Success, Failed, InProgress) | [optional] 
**ErrorMessage** | **string** | Error message if the job failed, null otherwise | [optional] 
**TotalProcessed** | **int** | Total number of forms processed. Value can be 0 or another value based on what the job has available | [optional] 
**TotalRows** | **int** | Total number of forms in the request. Value can be 0 or another value based on what the job has available | [optional] 
**UpdatedValid** | **int** | Number of forms updated and valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available | [optional] 
**UpdatedNoEmail** | **int** | Number of forms updated and valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available | [optional] 
**UpdatedInvalid** | **int** | Number of forms updated but invalid for e-filing. Value can be 0 or another value based on what the job has available | [optional] 
**SkippedDuplicate** | **int** | Number of forms skipped because they would have updated a record already updated once in the request. Value can be 0 or another value based on what the job has available | [optional] 
**SkippedInvalid** | **int** | Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing. Value can be 0 or another value based on what the job has available | [optional] 
**SkippedMultipleMatches** | **int** | Number of forms skipped because they matched multiple forms. Value can be 0 or another value based on what the job has available | [optional] 
**NotFound** | **int** | Number of forms skipped because no matching form or issuer could be found. Value can be 0 or another value based on what the job has available | [optional] 
**CreatedInvalid** | **int** | Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors. Value can be 0 or another value based on what the job has available | [optional] 
**CreatedNoEmail** | **int** | Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable. Value can be 0 or another value based on what the job has available | [optional] 
**CreatedValid** | **int** | Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery. Value can be 0 or another value based on what the job has available | [optional] 
**DryRun** | **bool** | Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them. | [optional] 
**Upsert** | **bool** | Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order: Form ID, Form Reference ID and tax year, Form TIN and tax year. | [optional] 
**Link** | **string** | Link to access the job details | [optional] 
**ProcessedForms** | [**List&lt;Get1099Form200Response&gt;**](Get1099Form200Response.md) | List of processed forms returned when bulk-upsert processes ≤1000 records. Same format as GET /1099/forms response. Only available in bulk-upsert endpoint responses. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

