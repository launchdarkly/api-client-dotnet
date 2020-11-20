# LaunchDarkly.Api.Model.FeatureFlagChangeRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique resource id. | [optional] 
**Version** | **int?** |  | [optional] 
**CreationDate** | **int?** | A unix epoch time in milliseconds specifying the date the change request was requested | [optional] 
**RequestorId** | **string** | The id of the member that requested the change | [optional] 
**ReviewStatus** | **FeatureFlagChangeRequestReviewStatus** |  | [optional] 
**Status** | **string** | | Name     | Description | | - -- -- -- -:| - -- -- -- -- -- | | pending  | the feature flag change request has not been applied yet | | completed| the feature flag change request has been applied successfully | | failed   | the feature flag change request has been applied but the changes were not applied successfully |  | [optional] 
**AppliedByMemberID** | **string** | The id of the member that applied the change request | [optional] 
**AppliedDate** | **int?** | A unix epoch time in milliseconds specifying the date the change request was applied | [optional] 
**CurrentReviewsByMemberId** | [**FeatureFlagChangeRequestReview**](FeatureFlagChangeRequestReview.md) |  | [optional] 
**AllReviews** | [**List&lt;FeatureFlagChangeRequestReview&gt;**](FeatureFlagChangeRequestReview.md) |  | [optional] 
**NotifyMemberIds** | **List&lt;string&gt;** |  | [optional] 
**Instructions** | [**SemanticPatchInstruction**](SemanticPatchInstruction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

