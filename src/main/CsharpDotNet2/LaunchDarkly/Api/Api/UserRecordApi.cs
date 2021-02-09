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
    public interface IUserRecordApi
    {
        /// <summary>
        /// Get a user by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="userKey">The user&#39;s key.</param>
        /// <returns>User</returns>
        User GetUser (string projectKey, string environmentKey, string userKey);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserRecordApi : IUserRecordApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRecordApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserRecordApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRecordApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserRecordApi(String basePath)
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
        /// Get a user by key. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="userKey">The user&#39;s key.</param> 
        /// <returns>User</returns>            
        public User GetUser (string projectKey, string environmentKey, string userKey)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetUser");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetUser");
            
            // verify the required parameter 'userKey' is set
            if (userKey == null) throw new ApiException(400, "Missing required parameter 'userKey' when calling GetUser");
            
    
            var path = "/users/{projectKey}/{environmentKey}/{userKey}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
    }
}
