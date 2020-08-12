# LaunchDarkly.Api.Model.TokenBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A human-friendly name for the access token | [optional] 
**Role** | **string** | The name of a built-in role for the token | [optional] 
**CustomRoleIds** | **List&lt;string&gt;** | A list of custom role IDs to use as access limits for the access token | [optional] 
**InlineRole** | [**List&lt;Statement&gt;**](Statement.md) |  | [optional] 
**ServiceToken** | **bool?** | Whether the token will be a service token https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens | [optional] 
**DefaultApiVersion** | **int?** | The default API version for this token | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

