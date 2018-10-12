# IO.Swagger.Model.FeatureFlag
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** |  | [optional] 
**Name** | **string** | Name of the feature flag. | [optional] 
**Description** | **string** | Description of the feature flag. | [optional] 
**Kind** | **string** | Whether the feature flag is a boolean flag or multivariate. | [optional] 
**CreationDate** | **decimal?** | A unix epoch time in milliseconds specifying the creation time of this flag. | [optional] 
**IncludeInSnippet** | **bool?** |  | [optional] 
**Temporary** | **bool?** | Whether or not this flag is temporary. | [optional] 
**MaintainerId** | **string** | The ID of the member that should maintain this flag. | [optional] 
**Tags** | **List&lt;string&gt;** | An array of tags for this feature flag. | [optional] 
**Variations** | [**List&lt;Variation&gt;**](Variation.md) | The variations for this feature flag. | [optional] 
**CustomProperties** | [**CustomProperties**](CustomProperties.md) |  | [optional] 
**Links** | [**Links**](Links.md) |  | [optional] 
**Maintainer** | [**Member**](Member.md) |  | [optional] 
**Environments** | [**Dictionary&lt;string, FeatureFlagConfig&gt;**](FeatureFlagConfig.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

