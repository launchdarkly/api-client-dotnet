# LaunchDarkly.Api.Model.FeatureFlagCopyBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**FeatureFlagCopyObject**](FeatureFlagCopyObject.md) |  | [optional] 
**Target** | [**FeatureFlagCopyObject**](FeatureFlagCopyObject.md) |  | [optional] 
**Comment** | **string** | comment will be included in audit log item for change. | [optional] 
**IncludedActions** | [**List&lt;CopyActions&gt;**](CopyActions.md) | Define the parts of the flag configuration that will be copied. | [optional] 
**ExcludedActions** | [**List&lt;CopyActions&gt;**](CopyActions.md) | Define the parts of the flag configuration that will not be copied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

