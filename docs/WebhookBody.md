# LaunchDarkly.Api.Model.WebhookBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The URL of the remote webhook. | 
**Secret** | **string** | If sign is true, and the secret attribute is omitted, LaunchDarkly will automatically generate a secret for you. | [optional] 
**Sign** | **bool?** | If sign is false, the webhook will not include a signature header, and the secret can be omitted. | 
**On** | **bool?** | Whether this webhook is enabled or not. | 
**Name** | **string** | The name of the webhook. | [optional] 
**Statements** | [**List&lt;Statement&gt;**](Statement.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | Tags for the webhook. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

