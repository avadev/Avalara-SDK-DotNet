# Avalara.SDK.Model.A1099.V2.W4FormRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The form type (always \&quot;w4\&quot; for this model). | [optional] [readonly] 
**EmployeeFirstName** | **string** | The first name of the employee. | 
**EmployeeMiddleName** | **string** | The middle name of the employee. | [optional] 
**EmployeeLastName** | **string** | The last name of the employee. | 
**EmployeeNameSuffix** | **string** | The name suffix of the employee. | [optional] 
**TinType** | **string** | Tax Identification Number (TIN) type. | 
**Tin** | **string** | The taxpayer identification number (TIN). | 
**Address** | **string** | The address of the employee. Required unless exempt. | [optional] 
**City** | **string** | The city of residence of the employee. Required unless exempt. | [optional] 
**State** | **string** | The state of residence of the employee. Required unless exempt. | [optional] 
**Zip** | **string** | The ZIP code of residence of the employee. Required unless exempt. | [optional] 
**MaritalStatus** | **string** | The marital status of the employee. Required unless exempt.  Available values:  - Single: Single or Married filing separately  - Married: Married filing jointly or qualifying surviving spouse  - MarriedBut: Head of household. Check only if you&#39;re unmarried and pay more than half the costs of keeping up a home for yourself and a qualifying individual. | [optional] 
**LastNameDiffers** | **bool** | Indicates whether the last name differs from prior records. | [optional] 
**NumAllowances** | **int?** | The number of allowances claimed by the employee. | [optional] 
**OtherDependents** | **int?** | The number of dependents other than allowances. | [optional] 
**NonJobIncome** | **float?** | The amount of non-job income. | [optional] 
**Deductions** | **float?** | The amount of deductions claimed. | [optional] 
**AdditionalWithheld** | **float?** | The additional amount withheld. | [optional] 
**ExemptFromWithholding** | **bool** | Indicates whether the employee is exempt from withholding. | [optional] 
**OfficeCode** | **string** | The office code associated with the form. | [optional] 
**EDeliveryConsentedAt** | **DateTime?** | The date when e-delivery was consented. | [optional] 
**Signature** | **string** | The signature of the form. | [optional] 
**CompanyId** | **string** | The ID of the associated company. Required when creating a form. | [optional] 
**ReferenceId** | **string** | A reference identifier for the form. | [optional] 
**Email** | **string** | The email address of the individual associated with the form. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

