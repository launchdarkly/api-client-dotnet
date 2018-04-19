# IO.Swagger.Model.Webhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**Links**](Links.md) |  | [optional] 
**Id** | [**Id**](Id.md) |  | [optional] 
**Url** | **string** | The URL of the remote webhook. | [optional] 
**Secret** | **string** | If defined, the webhooks post request will include a X-LD-Signature header whose value will contain an HMAC SHA256 hex digest of the webhook payload, using the secret as the key. | [optional] 
**On** | **bool?** | Whether this webhook is enabled or not. | [optional] 
**Tags** | **List&lt;string&gt;** | Tags assigned to this webhook. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

