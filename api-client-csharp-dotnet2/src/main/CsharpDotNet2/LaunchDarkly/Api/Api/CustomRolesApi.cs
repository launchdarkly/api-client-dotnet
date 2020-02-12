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
    public interface ICustomRolesApi
    {
        /// <summary>
        /// Delete a custom role by key. 
        /// </summary>
        /// <param name="customRoleKey">The custom role key.</param>
        /// <returns></returns>
        void DeleteCustomRole (string customRoleKey);
        /// <summary>
        /// Get one custom role by key. 
        /// </summary>
        /// <param name="customRoleKey">The custom role key.</param>
        /// <returns>CustomRole</returns>
        CustomRole GetCustomRole (string customRoleKey);
        /// <summary>
        /// Return a complete list of custom roles. 
        /// </summary>
        /// <returns>CustomRoles</returns>
        CustomRoles GetCustomRoles ();
        /// <summary>
        /// Modify a custom role by key. 
        /// </summary>
        /// <param name="customRoleKey">The custom role key.</param>
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param>
        /// <returns>CustomRole</returns>
        CustomRole PatchCustomRole (string customRoleKey, List<PatchOperation> patchDelta);
        /// <summary>
        /// Create a new custom role. 
        /// </summary>
        /// <param name="customRoleBody">New role or roles to create.</param>
        /// <returns>CustomRole</returns>
        CustomRole PostCustomRole (CustomRoleBody customRoleBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomRolesApi : ICustomRolesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRolesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomRolesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomRolesApi(String basePath)
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
        /// Delete a custom role by key. 
        /// </summary>
        /// <param name="customRoleKey">The custom role key.</param> 
        /// <returns></returns>            
        public void DeleteCustomRole (string customRoleKey)
        {
            
            // verify the required parameter 'customRoleKey' is set
            if (customRoleKey == null) throw new ApiException(400, "Missing required parameter 'customRoleKey' when calling DeleteCustomRole");
            
    
            var path = "/roles/{customRoleKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customRoleKey" + "}", ApiClient.ParameterToString(customRoleKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCustomRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCustomRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get one custom role by key. 
        /// </summary>
        /// <param name="customRoleKey">The custom role key.</param> 
        /// <returns>CustomRole</returns>            
        public CustomRole GetCustomRole (string customRoleKey)
        {
            
            // verify the required parameter 'customRoleKey' is set
            if (customRoleKey == null) throw new ApiException(400, "Missing required parameter 'customRoleKey' when calling GetCustomRole");
            
    
            var path = "/roles/{customRoleKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customRoleKey" + "}", ApiClient.ParameterToString(customRoleKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCustomRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCustomRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CustomRole) ApiClient.Deserialize(response.Content, typeof(CustomRole), response.Headers);
        }
    
        /// <summary>
        /// Return a complete list of custom roles. 
        /// </summary>
        /// <returns>CustomRoles</returns>            
        public CustomRoles GetCustomRoles ()
        {
            
    
            var path = "/roles";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCustomRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCustomRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CustomRoles) ApiClient.Deserialize(response.Content, typeof(CustomRoles), response.Headers);
        }
    
        /// <summary>
        /// Modify a custom role by key. 
        /// </summary>
        /// <param name="customRoleKey">The custom role key.</param> 
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param> 
        /// <returns>CustomRole</returns>            
        public CustomRole PatchCustomRole (string customRoleKey, List<PatchOperation> patchDelta)
        {
            
            // verify the required parameter 'customRoleKey' is set
            if (customRoleKey == null) throw new ApiException(400, "Missing required parameter 'customRoleKey' when calling PatchCustomRole");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchCustomRole");
            
    
            var path = "/roles/{customRoleKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "customRoleKey" + "}", ApiClient.ParameterToString(customRoleKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchCustomRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchCustomRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CustomRole) ApiClient.Deserialize(response.Content, typeof(CustomRole), response.Headers);
        }
    
        /// <summary>
        /// Create a new custom role. 
        /// </summary>
        /// <param name="customRoleBody">New role or roles to create.</param> 
        /// <returns>CustomRole</returns>            
        public CustomRole PostCustomRole (CustomRoleBody customRoleBody)
        {
            
            // verify the required parameter 'customRoleBody' is set
            if (customRoleBody == null) throw new ApiException(400, "Missing required parameter 'customRoleBody' when calling PostCustomRole");
            
    
            var path = "/roles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(customRoleBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCustomRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCustomRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CustomRole) ApiClient.Deserialize(response.Content, typeof(CustomRole), response.Headers);
        }
    
    }
}
