# LaunchDarkly.Api.Model.FeatureFlagApprovalRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique resource id. | [optional] 
**Version** | **int?** |  | [optional] 
**CreationDate** | **int?** | A unix epoch time in milliseconds specifying the date the approval request was requested | [optional] 
**RequestorId** | **string** | The id of the member that requested the change | [optional] 
**ReviewStatus** | **FeatureFlagApprovalRequestReviewStatus** |  | [optional] 
**Status** | **string** | | Name     | Description | | - -- -- -- -:| - -- -- -- -- -- | | pending  | the feature flag approval request has not been applied yet | | completed| the feature flag approval request has been applied successfully | | failed   | the feature flag approval request has been applied but the changes were not applied successfully |  | [optional] 
**AppliedByMemberID** | **string** | The id of the member that applied the approval request | [optional] 
**AppliedDate** | **int?** | A unix epoch time in milliseconds specifying the date the approval request was applied | [optional] 
**AllReviews** | [**List&lt;FeatureFlagApprovalRequestReview&gt;**](FeatureFlagApprovalRequestReview.md) |  | [optional] 
**NotifyMemberIds** | **List&lt;string&gt;** |  | [optional] 
**Instructions** | [**SemanticPatchInstruction**](SemanticPatchInstruction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

