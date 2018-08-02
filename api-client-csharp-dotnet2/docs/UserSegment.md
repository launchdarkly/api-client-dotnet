# IO.Swagger.Model.UserSegment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Unique identifier for the user segment. | 
**Name** | **string** | Name of the user segment. | 
**Description** | **string** | Description of the user segment. | [optional] 
**Tags** | **List&lt;string&gt;** | An array of tags for this user segment. | [optional] 
**CreationDate** | **decimal?** | A unix epoch time in milliseconds specifying the creation time of this flag. | 
**Included** | **List&lt;string&gt;** | An array of user keys that are included in this segment. | [optional] 
**Excluded** | **List&lt;string&gt;** | An array of user keys that should not be included in this segment, unless they are also listed in \&quot;included\&quot;. | [optional] 
**Rules** | [**List&lt;UserSegmentRule&gt;**](UserSegmentRule.md) | An array of rules that can cause a user to be included in this segment. | [optional] 
**Version** | **int?** |  | [optional] 
**Links** | [**Links**](Links.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

