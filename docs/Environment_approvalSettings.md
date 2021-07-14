# LaunchDarkly.Api.Model.EnvironmentApprovalSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceKind** | **string** | The approvals system used. | [optional] 
**Required** | **bool?** | Whether any changes to flags in this environment will require approval. You may only set required or requiredApprovalTags, not both. | [optional] 
**CanReviewOwnRequest** | **bool?** | Whether requesters can approve or decline their own request. They may always comment. | [optional] 
**MinNumApprovals** | **long?** | The number of approvals required before an approval request can be applied. | [optional] 
**CanApplyDeclinedChanges** | **bool?** | Whether changes can be applied as long as minNumApprovals is met, regardless of if any reviewers have declined a request. | [optional] 
**RequiredApprovalTags** | **List&lt;string&gt;** | An array of tags used to specify which flags with those tags require approval. You may only set requiredApprovalTags or required, not both. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

