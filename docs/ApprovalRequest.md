# LaunchDarkly.Api.Model.ApprovalRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique resource id. | [optional] 
**Version** | **int?** |  | [optional] 
**CreationDate** | **int?** | A unix epoch time in milliseconds specifying the date the approval request was requested | [optional] 
**RequestorId** | **string** | The id of the member that requested the change | [optional] 
**ReviewStatus** | **ApprovalRequestReviewStatus** |  | [optional] 
**Status** | **string** | | Name      | Description | | - -- -- -- --:| - -- -- -- -- -- | | pending   | the approval request has not been applied yet | | completed | the approval request has been applied successfully | | scheduled | the approval request for a scheduled change has been applied successfully | | failed    | the approval request has been applied but the changes were not applied successfully |  | [optional] 
**AppliedByMemberID** | **string** | The id of the member that applied the approval request | [optional] 
**AppliedDate** | **int?** | A unix epoch time in milliseconds specifying the date the approval request was applied | [optional] 
**AllReviews** | [**List&lt;ApprovalRequestReview&gt;**](ApprovalRequestReview.md) |  | [optional] 
**NotifyMemberIds** | **List&lt;string&gt;** |  | [optional] 
**Instructions** | [**SemanticPatchInstruction**](SemanticPatchInstruction.md) |  | [optional] 
**ExecutionDate** | **long?** | Timestamp for when instructions will be executed | [optional] 
**OperatingOnId** | **string** | ID of scheduled change to edit or delete | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

