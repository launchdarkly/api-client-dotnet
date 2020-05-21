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
    public interface IUserSettingsApi
    {
        /// <summary>
        /// Get expiring dates on flags for user 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userKey">The user&#39;s key.</param>
        /// <returns>UserTargetingExpirationOnFlagsForUser</returns>
        UserTargetingExpirationOnFlagsForUser GetExpiringUserTargetsForUser (string projectKey, string environmentKey, string userKey);
        /// <summary>
        /// Fetch a single flag setting for a user by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userKey">The user&#39;s key.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <returns>UserFlagSetting</returns>
        UserFlagSetting GetUserFlagSetting (string projectKey, string environmentKey, string userKey, string featureFlagKey);
        /// <summary>
        /// Fetch a single flag setting for a user by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userKey">The user&#39;s key.</param>
        /// <returns>UserFlagSettings</returns>
        UserFlagSettings GetUserFlagSettings (string projectKey, string environmentKey, string userKey);
        /// <summary>
        /// Update, add, or delete expiring user targets for a single user on all flags 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userKey">The user&#39;s key.</param>
        /// <param name="semanticPatchWithComment">Requires a Semantic Patch representation of the desired changes to the resource. &#39;https://apidocs.launchdarkly.com/reference#updates-via-semantic-patches&#39;. The addition of comments is also supported.</param>
        /// <returns>UserTargetingExpirationOnFlagsForUser</returns>
        UserTargetingExpirationOnFlagsForUser PatchExpiringUserTargetsForFlags (string projectKey, string environmentKey, string userKey, Object semanticPatchWithComment);
        /// <summary>
        /// Specifically enable or disable a feature flag for a user based on their key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userKey">The user&#39;s key.</param>
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param>
        /// <param name="userSettingsBody"></param>
        /// <returns></returns>
        void PutFlagSetting (string projectKey, string environmentKey, string userKey, string featureFlagKey, UserSettingsBody userSettingsBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserSettingsApi : IUserSettingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserSettingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserSettingsApi(String basePath)
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
        /// Get expiring dates on flags for user 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userKey">The user&#39;s key.</param> 
        /// <returns>UserTargetingExpirationOnFlagsForUser</returns>            
        public UserTargetingExpirationOnFlagsForUser GetExpiringUserTargetsForUser (string projectKey, string environmentKey, string userKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetExpiringUserTargetsForUser");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetExpiringUserTargetsForUser");
            
            // verify the required parameter 'userKey' is set
            if (userKey == null) throw new ApiException(400, "Missing required parameter 'userKey' when calling GetExpiringUserTargetsForUser");
            
    
            var path = "/users/{projectKey}/{userKey}/expiring-user-targets/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userKey" + "}", ApiClient.ParameterToString(userKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetExpiringUserTargetsForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExpiringUserTargetsForUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserTargetingExpirationOnFlagsForUser) ApiClient.Deserialize(response.Content, typeof(UserTargetingExpirationOnFlagsForUser), response.Headers);
        }
    
        /// <summary>
        /// Fetch a single flag setting for a user by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userKey">The user&#39;s key.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <returns>UserFlagSetting</returns>            
        public UserFlagSetting GetUserFlagSetting (string projectKey, string environmentKey, string userKey, string featureFlagKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetUserFlagSetting");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetUserFlagSetting");
            
            // verify the required parameter 'userKey' is set
            if (userKey == null) throw new ApiException(400, "Missing required parameter 'userKey' when calling GetUserFlagSetting");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling GetUserFlagSetting");
            
    
            var path = "/users/{projectKey}/{environmentKey}/{userKey}/flags/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userKey" + "}", ApiClient.ParameterToString(userKey));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFlagSetting: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFlagSetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserFlagSetting) ApiClient.Deserialize(response.Content, typeof(UserFlagSetting), response.Headers);
        }
    
        /// <summary>
        /// Fetch a single flag setting for a user by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userKey">The user&#39;s key.</param> 
        /// <returns>UserFlagSettings</returns>            
        public UserFlagSettings GetUserFlagSettings (string projectKey, string environmentKey, string userKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetUserFlagSettings");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetUserFlagSettings");
            
            // verify the required parameter 'userKey' is set
            if (userKey == null) throw new ApiException(400, "Missing required parameter 'userKey' when calling GetUserFlagSettings");
            
    
            var path = "/users/{projectKey}/{environmentKey}/{userKey}/flags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userKey" + "}", ApiClient.ParameterToString(userKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFlagSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserFlagSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserFlagSettings) ApiClient.Deserialize(response.Content, typeof(UserFlagSettings), response.Headers);
        }
    
        /// <summary>
        /// Update, add, or delete expiring user targets for a single user on all flags 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userKey">The user&#39;s key.</param> 
        /// <param name="semanticPatchWithComment">Requires a Semantic Patch representation of the desired changes to the resource. &#39;https://apidocs.launchdarkly.com/reference#updates-via-semantic-patches&#39;. The addition of comments is also supported.</param> 
        /// <returns>UserTargetingExpirationOnFlagsForUser</returns>            
        public UserTargetingExpirationOnFlagsForUser PatchExpiringUserTargetsForFlags (string projectKey, string environmentKey, string userKey, Object semanticPatchWithComment)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchExpiringUserTargetsForFlags");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PatchExpiringUserTargetsForFlags");
            
            // verify the required parameter 'userKey' is set
            if (userKey == null) throw new ApiException(400, "Missing required parameter 'userKey' when calling PatchExpiringUserTargetsForFlags");
            
            // verify the required parameter 'semanticPatchWithComment' is set
            if (semanticPatchWithComment == null) throw new ApiException(400, "Missing required parameter 'semanticPatchWithComment' when calling PatchExpiringUserTargetsForFlags");
            
    
            var path = "/users/{projectKey}/{userKey}/expiring-user-targets/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userKey" + "}", ApiClient.ParameterToString(userKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExpiringUserTargetsForFlags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExpiringUserTargetsForFlags: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserTargetingExpirationOnFlagsForUser) ApiClient.Deserialize(response.Content, typeof(UserTargetingExpirationOnFlagsForUser), response.Headers);
        }
    
        /// <summary>
        /// Specifically enable or disable a feature flag for a user based on their key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userKey">The user&#39;s key.</param> 
        /// <param name="featureFlagKey">The feature flag&#39;s key. The key identifies the flag in your code.</param> 
        /// <param name="userSettingsBody"></param> 
        /// <returns></returns>            
        public void PutFlagSetting (string projectKey, string environmentKey, string userKey, string featureFlagKey, UserSettingsBody userSettingsBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PutFlagSetting");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PutFlagSetting");
            
            // verify the required parameter 'userKey' is set
            if (userKey == null) throw new ApiException(400, "Missing required parameter 'userKey' when calling PutFlagSetting");
            
            // verify the required parameter 'featureFlagKey' is set
            if (featureFlagKey == null) throw new ApiException(400, "Missing required parameter 'featureFlagKey' when calling PutFlagSetting");
            
            // verify the required parameter 'userSettingsBody' is set
            if (userSettingsBody == null) throw new ApiException(400, "Missing required parameter 'userSettingsBody' when calling PutFlagSetting");
            
    
            var path = "/users/{projectKey}/{environmentKey}/{userKey}/flags/{featureFlagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userKey" + "}", ApiClient.ParameterToString(userKey));
path = path.Replace("{" + "featureFlagKey" + "}", ApiClient.ParameterToString(featureFlagKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userSettingsBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFlagSetting: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFlagSetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
