# LaunchDarkly.Api.Model.IntegrationSubscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**HierarchicalLinks**](HierarchicalLinks.md) |  | [optional] 
**Id** | **string** | The unique resource id. | [optional] 
**Kind** | **string** | The type of integration associated with this configuration. | [optional] 
**Name** | **string** | The user-defined name associated with this configuration. | [optional] 
**Config** | **Object** | A key-value mapping of configuration fields. | [optional] 
**Statements** | [**List&lt;Statement&gt;**](Statement.md) |  | [optional] 
**On** | **bool?** | Whether or not the integration is currently active. | [optional] 
**Tags** | **List&lt;string&gt;** | An array of tags for this integration configuration. | [optional] 
**Status** | [**IntegrationSubscriptionStatus**](IntegrationSubscriptionStatus.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

