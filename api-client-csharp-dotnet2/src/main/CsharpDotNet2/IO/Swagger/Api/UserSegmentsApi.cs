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
    public interface IUserSegmentsApi
    {
        /// <summary>
        /// Delete a user segment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userSegmentKey">The user segment&#39;s key. The key identifies the user segment in your code.</param>
        /// <returns></returns>
        void DeleteUserSegment (string projectKey, string environmentKey, string userSegmentKey);
        /// <summary>
        /// Get a single user segment by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userSegmentKey">The user segment&#39;s key. The key identifies the user segment in your code.</param>
        /// <returns>UserSegment</returns>
        UserSegment GetUserSegment (string projectKey, string environmentKey, string userSegmentKey);
        /// <summary>
        /// Get a list of all user segments in the given project. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="tag">Filter by tag. A tag can be used to group flags across projects.</param>
        /// <returns>UserSegments</returns>
        UserSegments GetUserSegments (string projectKey, string environmentKey, string tag);
        /// <summary>
        /// Perform a partial update to a user segment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userSegmentKey">The user segment&#39;s key. The key identifies the user segment in your code.</param>
        /// <param name="patchOnly">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported.</param>
        /// <returns>UserSegment</returns>
        UserSegment PatchUserSegment (string projectKey, string environmentKey, string userSegmentKey, List<PatchOperation> patchOnly);
        /// <summary>
        /// Creates a new user segment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userSegmentBody">Create a new user segment.</param>
        /// <returns></returns>
        void PostUserSegment (string projectKey, string environmentKey, UserSegmentBody userSegmentBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserSegmentsApi : IUserSegmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegmentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserSegmentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserSegmentsApi(String basePath)
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
        /// Delete a user segment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userSegmentKey">The user segment&#39;s key. The key identifies the user segment in your code.</param> 
        /// <returns></returns>            
        public void DeleteUserSegment (string projectKey, string environmentKey, string userSegmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling DeleteUserSegment");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling DeleteUserSegment");
            
            // verify the required parameter 'userSegmentKey' is set
            if (userSegmentKey == null) throw new ApiException(400, "Missing required parameter 'userSegmentKey' when calling DeleteUserSegment");
            
    
            var path = "/segments/{projectKey}/{environmentKey}/{userSegmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userSegmentKey" + "}", ApiClient.ParameterToString(userSegmentKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserSegment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserSegment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single user segment by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userSegmentKey">The user segment&#39;s key. The key identifies the user segment in your code.</param> 
        /// <returns>UserSegment</returns>            
        public UserSegment GetUserSegment (string projectKey, string environmentKey, string userSegmentKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetUserSegment");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetUserSegment");
            
            // verify the required parameter 'userSegmentKey' is set
            if (userSegmentKey == null) throw new ApiException(400, "Missing required parameter 'userSegmentKey' when calling GetUserSegment");
            
    
            var path = "/segments/{projectKey}/{environmentKey}/{userSegmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userSegmentKey" + "}", ApiClient.ParameterToString(userSegmentKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserSegment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserSegment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserSegment) ApiClient.Deserialize(response.Content, typeof(UserSegment), response.Headers);
        }
    
        /// <summary>
        /// Get a list of all user segments in the given project. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="tag">Filter by tag. A tag can be used to group flags across projects.</param> 
        /// <returns>UserSegments</returns>            
        public UserSegments GetUserSegments (string projectKey, string environmentKey, string tag)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetUserSegments");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetUserSegments");
            
    
            var path = "/segments/{projectKey}/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserSegments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserSegments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserSegments) ApiClient.Deserialize(response.Content, typeof(UserSegments), response.Headers);
        }
    
        /// <summary>
        /// Perform a partial update to a user segment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userSegmentKey">The user segment&#39;s key. The key identifies the user segment in your code.</param> 
        /// <param name="patchOnly">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported.</param> 
        /// <returns>UserSegment</returns>            
        public UserSegment PatchUserSegment (string projectKey, string environmentKey, string userSegmentKey, List<PatchOperation> patchOnly)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchUserSegment");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PatchUserSegment");
            
            // verify the required parameter 'userSegmentKey' is set
            if (userSegmentKey == null) throw new ApiException(400, "Missing required parameter 'userSegmentKey' when calling PatchUserSegment");
            
            // verify the required parameter 'patchOnly' is set
            if (patchOnly == null) throw new ApiException(400, "Missing required parameter 'patchOnly' when calling PatchUserSegment");
            
    
            var path = "/segments/{projectKey}/{environmentKey}/{userSegmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "userSegmentKey" + "}", ApiClient.ParameterToString(userSegmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(patchOnly); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchUserSegment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchUserSegment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserSegment) ApiClient.Deserialize(response.Content, typeof(UserSegment), response.Headers);
        }
    
        /// <summary>
        /// Creates a new user segment. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userSegmentBody">Create a new user segment.</param> 
        /// <returns></returns>            
        public void PostUserSegment (string projectKey, string environmentKey, UserSegmentBody userSegmentBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostUserSegment");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PostUserSegment");
            
            // verify the required parameter 'userSegmentBody' is set
            if (userSegmentBody == null) throw new ApiException(400, "Missing required parameter 'userSegmentBody' when calling PostUserSegment");
            
    
            var path = "/segments/{projectKey}/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userSegmentBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserSegment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserSegment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
