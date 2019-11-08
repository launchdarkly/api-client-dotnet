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
    public interface IDataExportDestinationsApi
    {
        /// <summary>
        /// Get a single data export destination by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="destinationId">The data export destination ID.</param>
        /// <returns></returns>
        void DeleteDestination (string projectKey, string environmentKey, string destinationId);
        /// <summary>
        /// Get a single data export destination by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="destinationId">The data export destination ID.</param>
        /// <returns>Destination</returns>
        Destination GetDestination (string projectKey, string environmentKey, string destinationId);
        /// <summary>
        /// Returns a list of all data export destinations. 
        /// </summary>
        /// <returns>Destinations</returns>
        Destinations GetDestinations ();
        /// <summary>
        /// Perform a partial update to a data export destination. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="destinationId">The data export destination ID.</param>
        /// <param name="patchOnly">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported.</param>
        /// <returns>Destination</returns>
        Destination PatchDestination (string projectKey, string environmentKey, string destinationId, List<PatchOperation> patchOnly);
        /// <summary>
        /// Create a new data export destination 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param>
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param>
        /// <param name="destinationBody">Create a new data export destination.</param>
        /// <returns>Destination</returns>
        Destination PostDestination (string projectKey, string environmentKey, DestinationBody destinationBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DataExportDestinationsApi : IDataExportDestinationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExportDestinationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DataExportDestinationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExportDestinationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataExportDestinationsApi(String basePath)
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
        /// Get a single data export destination by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="destinationId">The data export destination ID.</param> 
        /// <returns></returns>            
        public void DeleteDestination (string projectKey, string environmentKey, string destinationId)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling DeleteDestination");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling DeleteDestination");
            
            // verify the required parameter 'destinationId' is set
            if (destinationId == null) throw new ApiException(400, "Missing required parameter 'destinationId' when calling DeleteDestination");
            
    
            var path = "/destinations/{projectKey}/{environmentKey}/{destinationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "destinationId" + "}", ApiClient.ParameterToString(destinationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDestination: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDestination: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single data export destination by ID 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="destinationId">The data export destination ID.</param> 
        /// <returns>Destination</returns>            
        public Destination GetDestination (string projectKey, string environmentKey, string destinationId)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling GetDestination");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling GetDestination");
            
            // verify the required parameter 'destinationId' is set
            if (destinationId == null) throw new ApiException(400, "Missing required parameter 'destinationId' when calling GetDestination");
            
    
            var path = "/destinations/{projectKey}/{environmentKey}/{destinationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "destinationId" + "}", ApiClient.ParameterToString(destinationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDestination: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDestination: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Destination) ApiClient.Deserialize(response.Content, typeof(Destination), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of all data export destinations. 
        /// </summary>
        /// <returns>Destinations</returns>            
        public Destinations GetDestinations ()
        {
            
    
            var path = "/destinations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDestinations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDestinations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Destinations) ApiClient.Deserialize(response.Content, typeof(Destinations), response.Headers);
        }
    
        /// <summary>
        /// Perform a partial update to a data export destination. 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="destinationId">The data export destination ID.</param> 
        /// <param name="patchOnly">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported.</param> 
        /// <returns>Destination</returns>            
        public Destination PatchDestination (string projectKey, string environmentKey, string destinationId, List<PatchOperation> patchOnly)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PatchDestination");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PatchDestination");
            
            // verify the required parameter 'destinationId' is set
            if (destinationId == null) throw new ApiException(400, "Missing required parameter 'destinationId' when calling PatchDestination");
            
            // verify the required parameter 'patchOnly' is set
            if (patchOnly == null) throw new ApiException(400, "Missing required parameter 'patchOnly' when calling PatchDestination");
            
    
            var path = "/destinations/{projectKey}/{environmentKey}/{destinationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
path = path.Replace("{" + "destinationId" + "}", ApiClient.ParameterToString(destinationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchDestination: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchDestination: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Destination) ApiClient.Deserialize(response.Content, typeof(Destination), response.Headers);
        }
    
        /// <summary>
        /// Create a new data export destination 
        /// </summary>
        /// <param name="projectKey">The project key, used to tie the flags together under one project so they can be managed together.</param> 
        /// <param name="environmentKey">The environment key, used to tie together flag configuration and users under one environment so they can be managed together.</param> 
        /// <param name="destinationBody">Create a new data export destination.</param> 
        /// <returns>Destination</returns>            
        public Destination PostDestination (string projectKey, string environmentKey, DestinationBody destinationBody)
        {
            
            // verify the required parameter 'projectKey' is set
            if (projectKey == null) throw new ApiException(400, "Missing required parameter 'projectKey' when calling PostDestination");
            
            // verify the required parameter 'environmentKey' is set
            if (environmentKey == null) throw new ApiException(400, "Missing required parameter 'environmentKey' when calling PostDestination");
            
            // verify the required parameter 'destinationBody' is set
            if (destinationBody == null) throw new ApiException(400, "Missing required parameter 'destinationBody' when calling PostDestination");
            
    
            var path = "/destinations/{projectKey}/{environmentKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "projectKey" + "}", ApiClient.ParameterToString(projectKey));
path = path.Replace("{" + "environmentKey" + "}", ApiClient.ParameterToString(environmentKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(destinationBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostDestination: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostDestination: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Destination) ApiClient.Deserialize(response.Content, typeof(Destination), response.Headers);
        }
    
    }
}
