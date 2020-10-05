# LaunchDarkly.Api.Model.UserSegmentBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A human-friendly name for the user segment. | 
**Key** | **string** | A unique key that will be used to reference the user segment in feature flags. | 
**Description** | **string** | A description for the user segment. | [optional] 
**Unbounded** | **bool?** | Controls whether this segment can support unlimited numbers of users. Requires the beta API and additional setup. Include/exclude lists in this payload are not used in unbounded segments. | [optional] 
**Tags** | **List&lt;string&gt;** | Tags for the user segment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

