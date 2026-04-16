# Avalara.SDK.Model.EInvoicing.V1.CodeListVersion
Represents a versioned definition of a code list for a specific jurisdiction and date range

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VersionReasons** | **List&lt;string&gt;** | List of free-text reasons explaining why this version of the code list exists (for example, initial introduction, regulatory update, addition/deprecation of codes). Useful for audit and change tracking. | [optional] 
**JurisEffectiveDate** | **DateTime** | Date from which this version of the code list becomes legally or operationally effective in the jurisdiction. Typically corresponds to a go-live, mandate, or release date. | [optional] 
**JurisSunsetDate** | **DateTime** | Date after which this version of the code list must no longer be used in the jurisdiction. Use a far-future date (e.g., 9999-12-31) when the sunset is not yet known. | [optional] 
**Locale** | **string** | Language–region locale identifier indicating the language and regional variant for descriptions in this version of the code list. Follows BCP-47 format such as en-US, fr-FR, de-DE. | [optional] 
**Values** | [**List&lt;CodeListValue&gt;**](CodeListValue.md) | Array of code entries defined in this version of the code list. Each entry contains the machine-readable code value and its human-readable description in the given locale. | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

