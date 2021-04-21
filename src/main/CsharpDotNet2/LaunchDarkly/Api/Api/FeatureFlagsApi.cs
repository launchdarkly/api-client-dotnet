using System;
using System.Collections.Generic;
using RestSharp;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace LaunchDarkly.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFeatureFlagsApi
    {
        /// <summary>
        /// Copies the feature flag configuration from one environment to the same feature flag in another environment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="featureFlagCopyBody">Copy feature flag configurations between environments.</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag CopyFeatureFlag (string projectKey, string featureFlagKey, FeatureFlagCopyBody featureFlagCopyBody);
        /// <summary>
        /// Delete an approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="approvalRequestId">The approval request ID</param>
        /// <param name="approvalRequestConfigBody">Create a new approval request</param>
        /// <returns></returns>
        void DeleteApprovalRequest (string projectKey, string environmentKey, string featureFlagKey, string approvalRequestId, ApprovalRequestConfigBody approvalRequestConfigBody);
        /// <summary>
        /// Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns></returns>
        void DeleteFeatureFlag (string projectKey, string featureFlagKey);
        /// <summary>
        /// Delete a scheduled change on a feature flag in an environment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="scheduledChangeId">The id of the scheduled change</param>
        /// <returns></returns>
        void DeleteFlagConfigScheduledChanges (string projectKey, string featureFlagKey, string environmentKey, string scheduledChangeId);
        /// <summary>
        /// Get dependent flags for the flag in the environment specified in path parameters 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>DependentFlagsByEnvironment</returns>
        DependentFlagsByEnvironment FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet (string projectKey, string environmentKey, string featureFlagKey);
        /// <summary>
        /// Get dependent flags across all environments for the flag specified in the path parameters 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>MultiEnvironmentDependentFlags</returns>
        MultiEnvironmentDependentFlags FlagsProjectKeyFeatureFlagKeyDependentFlagsGet (string projectKey, string featureFlagKey);
        /// <summary>
        /// Get a single approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="approvalRequestId">The approval request ID</param>
        /// <returns>ApprovalRequests</returns>
        ApprovalRequests GetApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId);
        /// <summary>
        /// Get all approval requests for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <returns>ApprovalRequests</returns>
        ApprovalRequests GetApprovalRequests (string projectKey, string featureFlagKey, string environmentKey);
        /// <summary>
        /// Get expiring user targets for feature flag 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>UserTargetingExpirationForFlags</returns>
        UserTargetingExpirationForFlags GetExpiringUserTargets (string projectKey, string environmentKey, string featureFlagKey);
        /// <summary>
        /// Get a single feature flag by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="env">By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;[\&quot;production\&quot;] will restrict the returned configurations to just your production environment.</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag GetFeatureFlag (string projectKey, string featureFlagKey, List<string> env);
        /// <summary>
        /// Get the status for a particular feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>FeatureFlagStatus</returns>
        FeatureFlagStatus GetFeatureFlagStatus (string projectKey, string environmentKey, string featureFlagKey);
        /// <summary>
        /// Get the status for a particular feature flag across environments 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>FeatureFlagStatusAcrossEnvironments</returns>
        FeatureFlagStatusAcrossEnvironments GetFeatureFlagStatusAcrossEnvironments (string projectKey, string featureFlagKey);
        /// <summary>
        /// Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <returns>FeatureFlagStatuses</returns>
        FeatureFlagStatuses GetFeatureFlagStatuses (string projectKey, string environmentKey);
        /// <summary>
        /// Get a list of all features in the given project. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="env">By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;[\&quot;production\&quot;] will restrict the returned configurations to just your production environment.</param>
        /// <param name="summary">By default in api version &gt;&#x3D; 1, flags will _not_ include their list of prerequisites, targets or rules.  Set summary&#x3D;0 to include these fields for each flag returned.</param>
        /// <param name="archived">When set to 1, only archived flags will be included in the list of flags returned.  By default, archived flags are not included in the list of flags.</param>
        /// <param name="limit">The number of objects to return. Defaults to -1, which returns everything.</param>
        /// <param name="offset">Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items.</param>
        /// <param name="filter">A comma-separated list of filters. Each filter is of the form field:value.</param>
        /// <param name="sort">A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order.</param>
        /// <param name="tag">Filter by tag. A tag can be used to group flags across projects.</param>
        /// <returns>FeatureFlags</returns>
        FeatureFlags GetFeatureFlags (string projectKey, List<string> env, bool? summary, bool? archived, decimal? limit, decimal? offset, string filter, string sort, string tag);
        /// <summary>
        /// Get a scheduled change on a feature flag by id. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="scheduledChangeId">The id of the scheduled change</param>
        /// <returns>FeatureFlagScheduledChange</returns>
        FeatureFlagScheduledChange GetFlagConfigScheduledChange (string projectKey, string featureFlagKey, string environmentKey, string scheduledChangeId);
        /// <summary>
        /// Get all scheduled workflows for a feature flag by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <returns>FeatureFlagScheduledChanges</returns>
        FeatureFlagScheduledChanges GetFlagConfigScheduledChanges (string projectKey, string featureFlagKey, string environmentKey);
        /// <summary>
        /// Lists conflicts between the given instructions and any existing scheduled changes for the feature flag. The actual HTTP verb should be REPORT, not POST. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="flagConfigScheduledChangesConflictsBody">Used to determine if a semantic patch will result in conflicts with scheduled changes on a feature flag.</param>
        /// <returns>FeatureFlagScheduledChangesConflicts</returns>
        FeatureFlagScheduledChangesConflicts GetFlagConfigScheduledChangesConflicts (string projectKey, string featureFlagKey, string environmentKey, FlagConfigScheduledChangesConflictsBody flagConfigScheduledChangesConflictsBody);
        /// <summary>
        /// Update, add, or delete expiring user targets on feature flag 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="semanticPatchWithComment">Requires a Semantic Patch representation of the desired changes to the resource. &#39;https://apidocs.launchdarkly.com/reference#updates-via-semantic-patches&#39;. The addition of comments is also supported.</param>
        /// <returns>UserTargetingExpirationForFlags</returns>
        UserTargetingExpirationForFlags PatchExpiringUserTargets (string projectKey, string environmentKey, string featureFlagKey, Object semanticPatchWithComment);
        /// <summary>
        /// Perform a partial update to a feature. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="patchComment">Requires a JSON Patch representation of the desired changes to the project, and an optional comment. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported.</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag PatchFeatureFlag (string projectKey, string featureFlagKey, PatchComment patchComment);
        /// <summary>
        /// Updates an existing scheduled-change on a feature flag in an environment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="flagConfigScheduledChangesPatchBody">Update scheduled changes on a feature flag.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="scheduledChangeId">The id of the scheduled change</param>
        /// <returns>FeatureFlagScheduledChange</returns>
        FeatureFlagScheduledChange PatchFlagConfigScheduledChange (string projectKey, string featureFlagKey, FlagConfigScheduledChangesPatchBody flagConfigScheduledChangesPatchBody, string environmentKey, string scheduledChangeId);
        /// <summary>
        /// Apply approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="approvalRequestId">The approval request ID</param>
        /// <param name="approvalRequestApplyConfigBody">Apply an approval request</param>
        /// <returns>ApprovalRequests</returns>
        ApprovalRequests PostApplyApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId, ApprovalRequestApplyConfigBody approvalRequestApplyConfigBody);
        /// <summary>
        /// Create an approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="approvalRequestId">The approval request ID</param>
        /// <param name="approvalRequestConfigBody">Create a new approval request</param>
        /// <returns>ApprovalRequest</returns>
        ApprovalRequest PostApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId, ApprovalRequestConfigBody approvalRequestConfigBody);
        /// <summary>
        /// Creates a new feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagBody">Create a new feature flag.</param>
        /// <param name="clone">The key of the feature flag to be cloned. The key identifies the flag in your code.  For example, setting clone&#x3D;flagKey will copy the full targeting configuration for all environments (including on/off state) from the original flag to the new flag.</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody, string clone);
        /// <summary>
        /// Creates a new scheduled change for a feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="flagConfigScheduledChangesPostBody">Create scheduled changes on a feature flag.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <returns>FeatureFlagScheduledChange</returns>
        FeatureFlagScheduledChange PostFlagConfigScheduledChanges (string projectKey, FlagConfigScheduledChangesPostBody flagConfigScheduledChangesPostBody, string featureFlagKey, string environmentKey);
        /// <summary>
        /// Review approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="approvalRequestId">The approval request ID</param>
        /// <param name="approvalRequestReviewConfigBody">Review an approval request</param>
        /// <returns>ApprovalRequests</returns>
        ApprovalRequests PostReviewApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId, ApprovalRequestReviewConfigBody approvalRequestReviewConfigBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FeatureFlagsApi : IFeatureFlagsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FeatureFlagsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FeatureFlagsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Copies the feature flag configuration from one environment to the same feature flag in another environment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="featureFlagCopyBody">Copy feature flag configurations between environments.</param> 
        /// <returns>FeatureFlag</returns>            
        public FeatureFlag CopyFeatureFlag (string projectKey, string featureFlagKey, FeatureFlagCopyBody featureFlagCopyBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling CopyFeatureFlag");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling CopyFeatureFlag");
            
            // verify the required parameter 'featureFlagCopyBody' is set
            if (featureFlagCopyBody == null) throw new ApiException(400, "Missing required parameter 'featureFlagCopyBody' when calling CopyFeatureFlag");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}/copy";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(featureFlagCopyBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CopyFeatureFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CopyFeatureFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlag) ApiClient.Deserialize(response.Content, typeof(FeatureFlag), response.Headers);
        }
    
        /// <summary>
        /// Delete an approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="approvalRequestId">The approval request ID</param> 
        /// <param name="approvalRequestConfigBody">Create a new approval request</param> 
        /// <returns></returns>            
        public void DeleteApprovalRequest (string projectKey, string environmentKey, string featureFlagKey, string approvalRequestId, ApprovalRequestConfigBody approvalRequestConfigBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling DeleteApprovalRequest");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling DeleteApprovalRequest");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling DeleteApprovalRequest");
            
            // verify the required parameter 'approvalRequestId' is set
            if (approvalRequestId == null) throw new ApiException(400, "Missing required parameter 'approvalRequestId' when calling DeleteApprovalRequest");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "approvalRequestId" + "}", ApiClient.ParameterToString(approvalRequestId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(approvalRequestConfigBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApprovalRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApprovalRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns></returns>            
        public void DeleteFeatureFlag (string projectKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling DeleteFeatureFlag");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling DeleteFeatureFlag");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFeatureFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFeatureFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a scheduled change on a feature flag in an environment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="scheduledChangeId">The id of the scheduled change</param> 
        /// <returns></returns>            
        public void DeleteFlagConfigScheduledChanges (string projectKey, string featureFlagKey, string environmentKey, string scheduledChangeId)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling DeleteFlagConfigScheduledChanges");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling DeleteFlagConfigScheduledChanges");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling DeleteFlagConfigScheduledChanges");
            
            // verify the required parameter 'scheduledChangeId' is set
            if (scheduledChangeId == null) throw new ApiException(400, "Missing required parameter 'scheduledChangeId' when calling DeleteFlagConfigScheduledChanges");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes/{scheduledChangeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "scheduledChangeId" + "}", ApiClient.ParameterToString(scheduledChangeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFlagConfigScheduledChanges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFlagConfigScheduledChanges: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get dependent flags for the flag in the environment specified in path parameters 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>DependentFlagsByEnvironment</returns>            
        public DependentFlagsByEnvironment FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet (string projectKey, string environmentKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet");
            
    
            var path = "/flags/{projectKey}/{environmentKey}/{featureFlagKey}/dependent-flags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlagsProjectKeyEnvironmentKeyFeatureFlagKeyDependentFlagsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DependentFlagsByEnvironment) ApiClient.Deserialize(response.Content, typeof(DependentFlagsByEnvironment), response.Headers);
        }
    
        /// <summary>
        /// Get dependent flags across all environments for the flag specified in the path parameters 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>MultiEnvironmentDependentFlags</returns>            
        public MultiEnvironmentDependentFlags FlagsProjectKeyFeatureFlagKeyDependentFlagsGet (string projectKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling FlagsProjectKeyFeatureFlagKeyDependentFlagsGet");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling FlagsProjectKeyFeatureFlagKeyDependentFlagsGet");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}/dependent-flags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlagsProjectKeyFeatureFlagKeyDependentFlagsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlagsProjectKeyFeatureFlagKeyDependentFlagsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiEnvironmentDependentFlags) ApiClient.Deserialize(response.Content, typeof(MultiEnvironmentDependentFlags), response.Headers);
        }
    
        /// <summary>
        /// Get a single approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="approvalRequestId">The approval request ID</param> 
        /// <returns>ApprovalRequests</returns>            
        public ApprovalRequests GetApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetApprovalRequest");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetApprovalRequest");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetApprovalRequest");
            
            // verify the required parameter 'approvalRequestId' is set
            if (approvalRequestId == null) throw new ApiException(400, "Missing required parameter 'approvalRequestId' when calling GetApprovalRequest");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "approvalRequestId" + "}", ApiClient.ParameterToString(approvalRequestId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApprovalRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApprovalRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApprovalRequests) ApiClient.Deserialize(response.Content, typeof(ApprovalRequests), response.Headers);
        }
    
        /// <summary>
        /// Get all approval requests for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <returns>ApprovalRequests</returns>            
        public ApprovalRequests GetApprovalRequests (string projectKey, string featureFlagKey, string environmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetApprovalRequests");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetApprovalRequests");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetApprovalRequests");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApprovalRequests: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApprovalRequests: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApprovalRequests) ApiClient.Deserialize(response.Content, typeof(ApprovalRequests), response.Headers);
        }
    
        /// <summary>
        /// Get expiring user targets for feature flag 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>UserTargetingExpirationForFlags</returns>            
        public UserTargetingExpirationForFlags GetExpiringUserTargets (string projectKey, string environmentKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetExpiringUserTargets");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetExpiringUserTargets");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetExpiringUserTargets");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}/expiring-user-targets/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExpiringUserTargets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExpiringUserTargets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserTargetingExpirationForFlags) ApiClient.Deserialize(response.Content, typeof(UserTargetingExpirationForFlags), response.Headers);
        }
    
        /// <summary>
        /// Get a single feature flag by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="env">By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;[\&quot;production\&quot;] will restrict the returned configurations to just your production environment.</param> 
        /// <returns>FeatureFlag</returns>            
        public FeatureFlag GetFeatureFlag (string projectKey, string featureFlagKey, List<string> env)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlag");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFeatureFlag");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (env != null) queryParams.Add("env", ApiClient.ParameterToString(env)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlag) ApiClient.Deserialize(response.Content, typeof(FeatureFlag), response.Headers);
        }
    
        /// <summary>
        /// Get the status for a particular feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>FeatureFlagStatus</returns>            
        public FeatureFlagStatus GetFeatureFlagStatus (string projectKey, string environmentKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlagStatus");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFeatureFlagStatus");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFeatureFlagStatus");
            
    
            var path = "/flag-statuses/{projectKey}/{environmentKey}/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagStatus) ApiClient.Deserialize(response.Content, typeof(FeatureFlagStatus), response.Headers);
        }
    
        /// <summary>
        /// Get the status for a particular feature flag across environments 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>FeatureFlagStatusAcrossEnvironments</returns>            
        public FeatureFlagStatusAcrossEnvironments GetFeatureFlagStatusAcrossEnvironments (string projectKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlagStatusAcrossEnvironments");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFeatureFlagStatusAcrossEnvironments");
            
    
            var path = "/flag-status/{projectKey}/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatusAcrossEnvironments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatusAcrossEnvironments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagStatusAcrossEnvironments) ApiClient.Deserialize(response.Content, typeof(FeatureFlagStatusAcrossEnvironments), response.Headers);
        }
    
        /// <summary>
        /// Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <returns>FeatureFlagStatuses</returns>            
        public FeatureFlagStatuses GetFeatureFlagStatuses (string projectKey, string environmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlagStatuses");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFeatureFlagStatuses");
            
    
            var path = "/flag-statuses/{projectKey}/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatuses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagStatuses) ApiClient.Deserialize(response.Content, typeof(FeatureFlagStatuses), response.Headers);
        }
    
        /// <summary>
        /// Get a list of all features in the given project. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="env">By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;[\&quot;production\&quot;] will restrict the returned configurations to just your production environment.</param> 
        /// <param name="summary">By default in api version &gt;&#x3D; 1, flags will _not_ include their list of prerequisites, targets or rules.  Set summary&#x3D;0 to include these fields for each flag returned.</param> 
        /// <param name="archived">When set to 1, only archived flags will be included in the list of flags returned.  By default, archived flags are not included in the list of flags.</param> 
        /// <param name="limit">The number of objects to return. Defaults to -1, which returns everything.</param> 
        /// <param name="offset">Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items.</param> 
        /// <param name="filter">A comma-separated list of filters. Each filter is of the form field:value.</param> 
        /// <param name="sort">A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order.</param> 
        /// <param name="tag">Filter by tag. A tag can be used to group flags across projects.</param> 
        /// <returns>FeatureFlags</returns>            
        public FeatureFlags GetFeatureFlags (string projectKey, List<string> env, bool? summary, bool? archived, decimal? limit, decimal? offset, string filter, string sort, string tag)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlags");
            
    
            var path = "/flags/{projectKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (env != null) queryParams.Add("env", ApiClient.ParameterToString(env)); // query parameter
 if (summary != null) queryParams.Add("summary", ApiClient.ParameterToString(summary)); // query parameter
 if (archived != null) queryParams.Add("archived", ApiClient.ParameterToString(archived)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlags: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlags) ApiClient.Deserialize(response.Content, typeof(FeatureFlags), response.Headers);
        }
    
        /// <summary>
        /// Get a scheduled change on a feature flag by id. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="scheduledChangeId">The id of the scheduled change</param> 
        /// <returns>FeatureFlagScheduledChange</returns>            
        public FeatureFlagScheduledChange GetFlagConfigScheduledChange (string projectKey, string featureFlagKey, string environmentKey, string scheduledChangeId)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFlagConfigScheduledChange");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFlagConfigScheduledChange");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFlagConfigScheduledChange");
            
            // verify the required parameter 'scheduledChangeId' is set
            if (scheduledChangeId == null) throw new ApiException(400, "Missing required parameter 'scheduledChangeId' when calling GetFlagConfigScheduledChange");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes/{scheduledChangeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "scheduledChangeId" + "}", ApiClient.ParameterToString(scheduledChangeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlagConfigScheduledChange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlagConfigScheduledChange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagScheduledChange) ApiClient.Deserialize(response.Content, typeof(FeatureFlagScheduledChange), response.Headers);
        }
    
        /// <summary>
        /// Get all scheduled workflows for a feature flag by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <returns>FeatureFlagScheduledChanges</returns>            
        public FeatureFlagScheduledChanges GetFlagConfigScheduledChanges (string projectKey, string featureFlagKey, string environmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFlagConfigScheduledChanges");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFlagConfigScheduledChanges");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFlagConfigScheduledChanges");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlagConfigScheduledChanges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlagConfigScheduledChanges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagScheduledChanges) ApiClient.Deserialize(response.Content, typeof(FeatureFlagScheduledChanges), response.Headers);
        }
    
        /// <summary>
        /// Lists conflicts between the given instructions and any existing scheduled changes for the feature flag. The actual HTTP verb should be REPORT, not POST. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="flagConfigScheduledChangesConflictsBody">Used to determine if a semantic patch will result in conflicts with scheduled changes on a feature flag.</param> 
        /// <returns>FeatureFlagScheduledChangesConflicts</returns>            
        public FeatureFlagScheduledChangesConflicts GetFlagConfigScheduledChangesConflicts (string projectKey, string featureFlagKey, string environmentKey, FlagConfigScheduledChangesConflictsBody flagConfigScheduledChangesConflictsBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFlagConfigScheduledChangesConflicts");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFlagConfigScheduledChangesConflicts");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFlagConfigScheduledChangesConflicts");
            
            // verify the required parameter 'flagConfigScheduledChangesConflictsBody' is set
            if (flagConfigScheduledChangesConflictsBody == null) throw new ApiException(400, "Missing required parameter 'flagConfigScheduledChangesConflictsBody' when calling GetFlagConfigScheduledChangesConflicts");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes-conflicts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(flagConfigScheduledChangesConflictsBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlagConfigScheduledChangesConflicts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlagConfigScheduledChangesConflicts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagScheduledChangesConflicts) ApiClient.Deserialize(response.Content, typeof(FeatureFlagScheduledChangesConflicts), response.Headers);
        }
    
        /// <summary>
        /// Update, add, or delete expiring user targets on feature flag 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="semanticPatchWithComment">Requires a Semantic Patch representation of the desired changes to the resource. &#39;https://apidocs.launchdarkly.com/reference#updates-via-semantic-patches&#39;. The addition of comments is also supported.</param> 
        /// <returns>UserTargetingExpirationForFlags</returns>            
        public UserTargetingExpirationForFlags PatchExpiringUserTargets (string projectKey, string environmentKey, string featureFlagKey, Object semanticPatchWithComment)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchExpiringUserTargets");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PatchExpiringUserTargets");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PatchExpiringUserTargets");
            
            // verify the required parameter 'semanticPatchWithComment' is set
            if (semanticPatchWithComment == null) throw new ApiException(400, "Missing required parameter 'semanticPatchWithComment' when calling PatchExpiringUserTargets");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}/expiring-user-targets/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(semanticPatchWithComment); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExpiringUserTargets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExpiringUserTargets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserTargetingExpirationForFlags) ApiClient.Deserialize(response.Content, typeof(UserTargetingExpirationForFlags), response.Headers);
        }
    
        /// <summary>
        /// Perform a partial update to a feature. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="patchComment">Requires a JSON Patch representation of the desired changes to the project, and an optional comment. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported.</param> 
        /// <returns>FeatureFlag</returns>            
        public FeatureFlag PatchFeatureFlag (string projectKey, string featureFlagKey, PatchComment patchComment)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchFeatureFlag");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PatchFeatureFlag");
            
            // verify the required parameter 'patchComment' is set
            if (patchComment == null) throw new ApiException(400, "Missing required parameter 'patchComment' when calling PatchFeatureFlag");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(patchComment); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFeatureFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFeatureFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlag) ApiClient.Deserialize(response.Content, typeof(FeatureFlag), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing scheduled-change on a feature flag in an environment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="flagConfigScheduledChangesPatchBody">Update scheduled changes on a feature flag.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="scheduledChangeId">The id of the scheduled change</param> 
        /// <returns>FeatureFlagScheduledChange</returns>            
        public FeatureFlagScheduledChange PatchFlagConfigScheduledChange (string projectKey, string featureFlagKey, FlagConfigScheduledChangesPatchBody flagConfigScheduledChangesPatchBody, string environmentKey, string scheduledChangeId)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchFlagConfigScheduledChange");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PatchFlagConfigScheduledChange");
            
            // verify the required parameter 'flagConfigScheduledChangesPatchBody' is set
            if (flagConfigScheduledChangesPatchBody == null) throw new ApiException(400, "Missing required parameter 'flagConfigScheduledChangesPatchBody' when calling PatchFlagConfigScheduledChange");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PatchFlagConfigScheduledChange");
            
            // verify the required parameter 'scheduledChangeId' is set
            if (scheduledChangeId == null) throw new ApiException(400, "Missing required parameter 'scheduledChangeId' when calling PatchFlagConfigScheduledChange");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes/{scheduledChangeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "scheduledChangeId" + "}", ApiClient.ParameterToString(scheduledChangeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(flagConfigScheduledChangesPatchBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFlagConfigScheduledChange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFlagConfigScheduledChange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagScheduledChange) ApiClient.Deserialize(response.Content, typeof(FeatureFlagScheduledChange), response.Headers);
        }
    
        /// <summary>
        /// Apply approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="approvalRequestId">The approval request ID</param> 
        /// <param name="approvalRequestApplyConfigBody">Apply an approval request</param> 
        /// <returns>ApprovalRequests</returns>            
        public ApprovalRequests PostApplyApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId, ApprovalRequestApplyConfigBody approvalRequestApplyConfigBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostApplyApprovalRequest");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PostApplyApprovalRequest");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PostApplyApprovalRequest");
            
            // verify the required parameter 'approvalRequestId' is set
            if (approvalRequestId == null) throw new ApiException(400, "Missing required parameter 'approvalRequestId' when calling PostApplyApprovalRequest");
            
            // verify the required parameter 'approvalRequestApplyConfigBody' is set
            if (approvalRequestApplyConfigBody == null) throw new ApiException(400, "Missing required parameter 'approvalRequestApplyConfigBody' when calling PostApplyApprovalRequest");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}/apply";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "approvalRequestId" + "}", ApiClient.ParameterToString(approvalRequestId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(approvalRequestApplyConfigBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostApplyApprovalRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostApplyApprovalRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApprovalRequests) ApiClient.Deserialize(response.Content, typeof(ApprovalRequests), response.Headers);
        }
    
        /// <summary>
        /// Create an approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="approvalRequestId">The approval request ID</param> 
        /// <param name="approvalRequestConfigBody">Create a new approval request</param> 
        /// <returns>ApprovalRequest</returns>            
        public ApprovalRequest PostApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId, ApprovalRequestConfigBody approvalRequestConfigBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostApprovalRequest");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PostApprovalRequest");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PostApprovalRequest");
            
            // verify the required parameter 'approvalRequestId' is set
            if (approvalRequestId == null) throw new ApiException(400, "Missing required parameter 'approvalRequestId' when calling PostApprovalRequest");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "approvalRequestId" + "}", ApiClient.ParameterToString(approvalRequestId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(approvalRequestConfigBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostApprovalRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostApprovalRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApprovalRequest) ApiClient.Deserialize(response.Content, typeof(ApprovalRequest), response.Headers);
        }
    
        /// <summary>
        /// Creates a new feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagBody">Create a new feature flag.</param> 
        /// <param name="clone">The key of the feature flag to be cloned. The key identifies the flag in your code.  For example, setting clone&#x3D;flagKey will copy the full targeting configuration for all environments (including on/off state) from the original flag to the new flag.</param> 
        /// <returns>FeatureFlag</returns>            
        public FeatureFlag PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody, string clone)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostFeatureFlag");
            
            // verify the required parameter 'featureFlagBody' is set
            if (featureFlagBody == null) throw new ApiException(400, "Missing required parameter 'featureFlagBody' when calling PostFeatureFlag");
            
    
            var path = "/flags/{projectKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clone != null) queryParams.Add("clone", ApiClient.ParameterToString(clone)); // query parameter
                                    postBody = ApiClient.Serialize(featureFlagBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFeatureFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFeatureFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlag) ApiClient.Deserialize(response.Content, typeof(FeatureFlag), response.Headers);
        }
    
        /// <summary>
        /// Creates a new scheduled change for a feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="flagConfigScheduledChangesPostBody">Create scheduled changes on a feature flag.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <returns>FeatureFlagScheduledChange</returns>            
        public FeatureFlagScheduledChange PostFlagConfigScheduledChanges (string projectKey, FlagConfigScheduledChangesPostBody flagConfigScheduledChangesPostBody, string featureFlagKey, string environmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostFlagConfigScheduledChanges");
            
            // verify the required parameter 'flagConfigScheduledChangesPostBody' is set
            if (flagConfigScheduledChangesPostBody == null) throw new ApiException(400, "Missing required parameter 'flagConfigScheduledChangesPostBody' when calling PostFlagConfigScheduledChanges");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PostFlagConfigScheduledChanges");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PostFlagConfigScheduledChanges");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(flagConfigScheduledChangesPostBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFlagConfigScheduledChanges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFlagConfigScheduledChanges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagScheduledChange) ApiClient.Deserialize(response.Content, typeof(FeatureFlagScheduledChange), response.Headers);
        }
    
        /// <summary>
        /// Review approval request for a feature flag config 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="approvalRequestId">The approval request ID</param> 
        /// <param name="approvalRequestReviewConfigBody">Review an approval request</param> 
        /// <returns>ApprovalRequests</returns>            
        public ApprovalRequests PostReviewApprovalRequest (string projectKey, string featureFlagKey, string environmentKey, string approvalRequestId, ApprovalRequestReviewConfigBody approvalRequestReviewConfigBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostReviewApprovalRequest");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PostReviewApprovalRequest");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PostReviewApprovalRequest");
            
            // verify the required parameter 'approvalRequestId' is set
            if (approvalRequestId == null) throw new ApiException(400, "Missing required parameter 'approvalRequestId' when calling PostReviewApprovalRequest");
            
            // verify the required parameter 'approvalRequestReviewConfigBody' is set
            if (approvalRequestReviewConfigBody == null) throw new ApiException(400, "Missing required parameter 'approvalRequestReviewConfigBody' when calling PostReviewApprovalRequest");
            
    
            var path = "/projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}/review";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "approvalRequestId" + "}", ApiClient.ParameterToString(approvalRequestId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(approvalRequestReviewConfigBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostReviewApprovalRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostReviewApprovalRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApprovalRequests) ApiClient.Deserialize(response.Content, typeof(ApprovalRequests), response.Headers);
        }
    
    }
}
