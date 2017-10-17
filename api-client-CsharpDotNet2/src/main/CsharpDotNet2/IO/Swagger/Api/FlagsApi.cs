using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFlagsApi
    {
        /// <summary>
        /// Delete a feature flag by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns></returns>
        void DeleteFeatureFlag (string projectKey, string featureFlagKey);
        /// <summary>
        /// Get a single feature flag by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="environmentKeyQuery">The environment key</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag GetFeatureFlag (string projectKey, string featureFlagKey, string environmentKeyQuery);
        /// <summary>
        /// Get a list of statuses for all feature flags 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key</param>
        /// <returns>FeatureFlagStatuses</returns>
        FeatureFlagStatuses GetFeatureFlagStatus (string projectKey, string environmentKey);
        /// <summary>
        /// Get a list of statuses for all feature flags 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>FeatureFlagStatus</returns>
        FeatureFlagStatus GetFeatureFlagStatuses (string projectKey, string environmentKey, string featureFlagKey);
        /// <summary>
        /// Get a list of all features in the given project. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKeyQuery">The environment key</param>
        /// <param name="tag">Filter by tag. A tag can be used to group flags across projects.</param>
        /// <returns>FeatureFlags</returns>
        FeatureFlags GetFeatureFlags (string projectKey, string environmentKeyQuery, string tag);
        /// <summary>
        /// Modify a feature flag by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="patchDelta">http://jsonpatch.com/</param>
        /// <returns>FeatureFlag</returns>
        FeatureFlag PatchFeatureFlag (string projectKey, string featureFlagKey, List<PatchDelta> patchDelta);
        /// <summary>
        /// Create a feature flag 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="featureFlagBody">Create a new feature flag</param>
        /// <returns></returns>
        void PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FlagsApi : IFlagsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlagsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FlagsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlagsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FlagsApi(String basePath)
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
        /// Delete a feature flag by ID 
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
        /// Get a single feature flag by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="environmentKeyQuery">The environment key</param> 
        /// <returns>FeatureFlag</returns>            
        public FeatureFlag GetFeatureFlag (string projectKey, string featureFlagKey, string environmentKeyQuery)
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
    
             if (environmentKeyQuery != null) queryParams.Add("environmentKeyQuery", ApiClient.ParameterToString(environmentKeyQuery)); // query parameter
                                        
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
        /// Get a list of statuses for all feature flags 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key</param> 
        /// <returns>FeatureFlagStatuses</returns>            
        public FeatureFlagStatuses GetFeatureFlagStatus (string projectKey, string environmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlagStatus");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFeatureFlagStatus");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagStatuses) ApiClient.Deserialize(response.Content, typeof(FeatureFlagStatuses), response.Headers);
        }
    
        /// <summary>
        /// Get a list of statuses for all feature flags 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>FeatureFlagStatus</returns>            
        public FeatureFlagStatus GetFeatureFlagStatuses (string projectKey, string environmentKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetFeatureFlagStatuses");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetFeatureFlagStatuses");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetFeatureFlagStatuses");
            
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureFlagStatuses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeatureFlagStatus) ApiClient.Deserialize(response.Content, typeof(FeatureFlagStatus), response.Headers);
        }
    
        /// <summary>
        /// Get a list of all features in the given project. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKeyQuery">The environment key</param> 
        /// <param name="tag">Filter by tag. A tag can be used to group flags across projects.</param> 
        /// <returns>FeatureFlags</returns>            
        public FeatureFlags GetFeatureFlags (string projectKey, string environmentKeyQuery, string tag)
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
    
             if (environmentKeyQuery != null) queryParams.Add("environmentKeyQuery", ApiClient.ParameterToString(environmentKeyQuery)); // query parameter
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
        /// Modify a feature flag by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="patchDelta">http://jsonpatch.com/</param> 
        /// <returns>FeatureFlag</returns>            
        public FeatureFlag PatchFeatureFlag (string projectKey, string featureFlagKey, List<PatchDelta> patchDelta)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchFeatureFlag");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PatchFeatureFlag");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchFeatureFlag");
            
    
            var path = "/flags/{projectKey}/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(patchDelta); // http body (model) parameter
    
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
        /// Create a feature flag 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="featureFlagBody">Create a new feature flag</param> 
        /// <returns></returns>            
        public void PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody)
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
    
                                                postBody = ApiClient.Serialize(featureFlagBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFeatureFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFeatureFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
