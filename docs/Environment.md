# LaunchDarkly.Api.Model.Environment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**Links**](Links.md) |  | [optional] 
**Id** | **string** | The unique resource id. | [optional] 
**Key** | **string** | The key for the environment. | [optional] 
**Name** | **string** | The name of the environment. | [optional] 
**ApiKey** | **string** | The SDK key for backend LaunchDarkly SDKs. | [optional] 
**MobileKey** | **string** | The SDK key for mobile LaunchDarkly SDKs. | [optional] 
**Color** | **string** | The swatch color for the environment. | [optional] 
**DefaultTtl** | **decimal?** | The default TTL. | [optional] 
**SecureMode** | **bool?** | Determines if this environment is in safe mode. | [optional] 
**DefaultTrackEvents** | **bool?** | Set to true to send detailed event information for new flags. | [optional] 
**Tags** | **List&lt;string&gt;** | An array of tags for this environment. | [optional] 
**RequireComments** | **bool?** | Determines if this environment requires comments for flag and segment changes. | [optional] 
**ConfirmChanges** | **bool?** | Determines if this environment requires confirmation for flag and segment changes. | [optional] 
**ApprovalSettings** | [**EnvironmentApprovalSettings**](EnvironmentApprovalSettings.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

