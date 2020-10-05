# LaunchDarkly.Api.Model.RelayProxyConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique resource id. | 
**Creator** | [**Member**](Member.md) |  | 
**Name** | **string** | A human-friendly name for the relay proxy configuration | 
**Policy** | [**List&lt;Policy&gt;**](Policy.md) |  | 
**FullKey** | **string** | Full secret key. Only included if creating or resetting the relay proxy configuration | [optional] 
**DisplayKey** | **string** | The last 4 digits of the unique secret key for this relay proxy configuration | 
**CreationDate** | **long?** | A unix epoch time in milliseconds specifying the creation time of this relay proxy configuration | 
**LastModified** | **long?** | A unix epoch time in milliseconds specifying the last time this relay proxy configuration was modified | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

