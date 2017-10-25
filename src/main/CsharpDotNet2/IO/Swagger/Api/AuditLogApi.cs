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
    public interface IAuditLogApi
    {
        /// <summary>
        /// Fetch a list of all audit log entries 
        /// </summary>
        /// <returns>AuditLogEntries</returns>
        AuditLogEntries GetAuditLogEntries ();
        /// <summary>
        /// Get an audit log entry by ID 
        /// </summary>
        /// <param name="resourceId">The resource ID</param>
        /// <returns>AuditLogEntry</returns>
        AuditLogEntry GetAuditLogEntry (string resourceId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuditLogApi : IAuditLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuditLogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditLogApi(String basePath)
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
        /// Fetch a list of all audit log entries 
        /// </summary>
        /// <returns>AuditLogEntries</returns>            
        public AuditLogEntries GetAuditLogEntries ()
        {
            
    
            var path = "/auditlog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuditLogEntries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuditLogEntries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuditLogEntries) ApiClient.Deserialize(response.Content, typeof(AuditLogEntries), response.Headers);
        }
    
        /// <summary>
        /// Get an audit log entry by ID 
        /// </summary>
        /// <param name="resourceId">The resource ID</param> 
        /// <returns>AuditLogEntry</returns>            
        public AuditLogEntry GetAuditLogEntry (string resourceId)
        {
            
            // verify the required parameter 'resourceId' is set
            if (resourceId == null) throw new ApiException(400, "Missing required parameter 'resourceId' when calling GetAuditLogEntry");
            
    
            var path = "/auditlog/{resourceId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "resourceId" + "}", ApiClient.ParameterToString(resourceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuditLogEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuditLogEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuditLogEntry) ApiClient.Deserialize(response.Content, typeof(AuditLogEntry), response.Headers);
        }
    
    }
}
