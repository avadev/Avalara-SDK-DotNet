# Avalara.SDK.Model.A1099.V2.W4FormResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the form. | [optional] 
**EntryStatus** | [**EntryStatusResponse**](EntryStatusResponse.md) | The entry status information for the form. | [optional] 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. | [optional] 
**DisplayName** | **string** | The display name associated with the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 
**Archived** | **bool** | Indicates whether the form is archived. | [optional] 
**AncestorId** | **string** | Form ID of previous version. | [optional] 
**Signature** | **string** | The signature of the form. | [optional] 
**SignedDate** | **DateTime?** | The date the form was signed. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**CreatedAt** | **DateTime** | The creation date of the form. | [optional] 
**UpdatedAt** | **DateTime** | The last updated date of the form. | [optional] 
**Type** | **string** | The type of the response object. | [optional] 
**EmployeeFirstName** | **string** | The first name of the employee. | [optional] 
**EmployeeMiddleName** | **string** | The middle name of the employee. | [optional] 
**EmployeeLastName** | **string** | The last name of the employee. | [optional] 
**EmployeeNameSuffix** | **string** | The name suffix of the employee. | [optional] 
**TinType** | **string** | The type of TIN provided. | [optional] 
**Tin** | **string** | The taxpayer identification number (TIN). | [optional] 
**Address** | **string** | The address of the employee. | [optional] 
**City** | **string** | The city of residence of the employee. | [optional] 
**State** | **string** | The state of residence of the employee. | [optional] 
**Zip** | **string** | The ZIP code of residence of the employee. | [optional] 
**MaritalStatus** | **string** | The marital status of the employee. | [optional] 
**LastNameDiffers** | **bool** | Indicates whether the last name differs from prior records. | [optional] 
**NumAllowances** | **int?** | The number of allowances claimed by the employee. | [optional] 
**OtherDependents** | **int?** | The number of dependents other than allowances. | [optional] 
**NonJobIncome** | **float?** | The amount of non-job income. | [optional] 
**Deductions** | **float?** | The amount of deductions claimed. | [optional] 
**AdditionalWithheld** | **float?** | The additional amount withheld. | [optional] 
**ExemptFromWithholding** | **bool** | Indicates whether the employee is exempt from withholding. | [optional] 
**OfficeCode** | **string** | The office code associated with the form. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

