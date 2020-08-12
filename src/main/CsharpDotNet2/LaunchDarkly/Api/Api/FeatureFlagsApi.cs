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
        /// Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns></returns>
        void DeleteFeatureFlag (string projectKey, string featureFlagKey);
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
        /// Creates a new feature flag. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagBody">Create a new feature flag.</param>
        /// <param name="clone">The key of the feature flag to be cloned. The key identifies the flag in your code.  For example, setting clone&#x3D;flagKey will copy the full targeting configuration for all environments (including on/off state) from the original flag to the new flag.</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody, string clone);
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
    
    }
}
