# IO.Swagger.Model.FeatureFlagBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A human-friendly name for the feature flag. Remember to note if this flag is intended to be temporary or permanent. | 
**Key** | **string** | A unique key that will be used to reference the flag in your code. | 
**Variations** | [**List&lt;Variation&gt;**](Variation.md) | An array of possible variations for the flag. | 
**Temporary** | **bool?** | Whether or not the flag is a temporary flag. | [optional] 
**Tags** | **List&lt;string&gt;** | Tags for the feature flag. | [optional] 
**IncludeInSnippet** | **bool?** | Whether or not this flag should be made available to the client-side JavaScript SDK. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

