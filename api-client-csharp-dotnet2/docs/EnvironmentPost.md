# LaunchDarkly.Api.Model.EnvironmentPost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the new environment. | 
**Key** | **string** | A project-unique key for the new environment. | 
**Color** | **string** | A color swatch (as an RGB hex value with no leading &#39;#&#39;, e.g. C8C8C8). | 
**DefaultTtl** | **decimal?** | The default TTL for the new environment. | [optional] 
**SecureMode** | **bool?** | Determines whether the environment is in secure mode. | [optional] 
**DefaultTrackEvents** | **bool?** | Set to true to send detailed event information for newly created flags. | [optional] 
**Tags** | **List&lt;string&gt;** | An array of tags for this environment. | [optional] 
**RequireComments** | **bool?** | Determines if this environment requires comments for flag and segment changes. | [optional] 
**ConfirmChanges** | **bool?** | Determines if this environment requires confirmation for flag and segment changes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

