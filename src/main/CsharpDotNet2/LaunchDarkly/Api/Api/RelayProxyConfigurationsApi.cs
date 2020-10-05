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
    public interface IRelayProxyConfigurationsApi
    {
        /// <summary>
        /// Delete a relay proxy configuration by ID. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param>
        /// <returns></returns>
        void DeleteRelayProxyConfig (string id);
        /// <summary>
        /// Get a single relay proxy configuration by ID. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param>
        /// <returns>RelayProxyConfig</returns>
        RelayProxyConfig GetRelayProxyConfig (string id);
        /// <summary>
        /// Returns a list of relay proxy configurations in the account. 
        /// </summary>
        /// <returns>RelayProxyConfigs</returns>
        RelayProxyConfigs GetRelayProxyConfigs ();
        /// <summary>
        /// Modify a relay proxy configuration by ID. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param>
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param>
        /// <returns>RelayProxyConfig</returns>
        RelayProxyConfig PatchRelayProxyConfig (string id, List<PatchOperation> patchDelta);
        /// <summary>
        /// Create a new relay proxy config. 
        /// </summary>
        /// <param name="relayProxyConfigBody">Create a new relay proxy configuration</param>
        /// <returns>RelayProxyConfig</returns>
        RelayProxyConfig PostRelayAutoConfig (RelayProxyConfigBody relayProxyConfigBody);
        /// <summary>
        /// Reset a relay proxy configuration&#39;s secret key with an optional expiry time for the old key. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param>
        /// <param name="expiry">An expiration time for the old relay proxy configuration key, expressed as a Unix epoch time in milliseconds. By default, the relay proxy configuration will expire immediately</param>
        /// <returns>RelayProxyConfig</returns>
        RelayProxyConfig ResetRelayProxyConfig (string id, long? expiry);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RelayProxyConfigurationsApi : IRelayProxyConfigurationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelayProxyConfigurationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RelayProxyConfigurationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RelayProxyConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RelayProxyConfigurationsApi(String basePath)
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
        /// Delete a relay proxy configuration by ID. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param> 
        /// <returns></returns>            
        public void DeleteRelayProxyConfig (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteRelayProxyConfig");
            
    
            var path = "/account/relay-auto-configs/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRelayProxyConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRelayProxyConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single relay proxy configuration by ID. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param> 
        /// <returns>RelayProxyConfig</returns>            
        public RelayProxyConfig GetRelayProxyConfig (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRelayProxyConfig");
            
    
            var path = "/account/relay-auto-configs/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRelayProxyConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRelayProxyConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RelayProxyConfig) ApiClient.Deserialize(response.Content, typeof(RelayProxyConfig), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of relay proxy configurations in the account. 
        /// </summary>
        /// <returns>RelayProxyConfigs</returns>            
        public RelayProxyConfigs GetRelayProxyConfigs ()
        {
            
    
            var path = "/account/relay-auto-configs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRelayProxyConfigs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRelayProxyConfigs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RelayProxyConfigs) ApiClient.Deserialize(response.Content, typeof(RelayProxyConfigs), response.Headers);
        }
    
        /// <summary>
        /// Modify a relay proxy configuration by ID. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param> 
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param> 
        /// <returns>RelayProxyConfig</returns>            
        public RelayProxyConfig PatchRelayProxyConfig (string id, List<PatchOperation> patchDelta)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PatchRelayProxyConfig");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchRelayProxyConfig");
            
    
            var path = "/account/relay-auto-configs/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchRelayProxyConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchRelayProxyConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RelayProxyConfig) ApiClient.Deserialize(response.Content, typeof(RelayProxyConfig), response.Headers);
        }
    
        /// <summary>
        /// Create a new relay proxy config. 
        /// </summary>
        /// <param name="relayProxyConfigBody">Create a new relay proxy configuration</param> 
        /// <returns>RelayProxyConfig</returns>            
        public RelayProxyConfig PostRelayAutoConfig (RelayProxyConfigBody relayProxyConfigBody)
        {
            
            // verify the required parameter 'relayProxyConfigBody' is set
            if (relayProxyConfigBody == null) throw new ApiException(400, "Missing required parameter 'relayProxyConfigBody' when calling PostRelayAutoConfig");
            
    
            var path = "/account/relay-auto-configs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(relayProxyConfigBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRelayAutoConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRelayAutoConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RelayProxyConfig) ApiClient.Deserialize(response.Content, typeof(RelayProxyConfig), response.Headers);
        }
    
        /// <summary>
        /// Reset a relay proxy configuration&#39;s secret key with an optional expiry time for the old key. 
        /// </summary>
        /// <param name="id">The relay proxy configuration ID</param> 
        /// <param name="expiry">An expiration time for the old relay proxy configuration key, expressed as a Unix epoch time in milliseconds. By default, the relay proxy configuration will expire immediately</param> 
        /// <returns>RelayProxyConfig</returns>            
        public RelayProxyConfig ResetRelayProxyConfig (string id, long? expiry)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ResetRelayProxyConfig");
            
    
            var path = "/account/relay-auto-configs/{id}/reset";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (expiry != null) queryParams.Add("expiry", ApiClient.ParameterToString(expiry)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ResetRelayProxyConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ResetRelayProxyConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RelayProxyConfig) ApiClient.Deserialize(response.Content, typeof(RelayProxyConfig), response.Headers);
        }
    
    }
}
