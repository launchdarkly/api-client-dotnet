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
    public interface IAuditLogApi
    {
        /// <summary>
        /// Get a list of all audit log entries. The query parameters allow you to restrict the returned results by date ranges, resource specifiers, or a full-text search query. 
        /// </summary>
        /// <param name="before">A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have before this timestamp.</param>
        /// <param name="after">A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have occurred after this timestamp.</param>
        /// <param name="q">Text to search for. You can search for the full or partial name of the resource involved or full or partial email address of the member who made the change.</param>
        /// <param name="limit">A limit on the number of audit log entries to be returned, between 1 and 20.</param>
        /// <param name="spec">A resource specifier, allowing you to filter audit log listings by resource.</param>
        /// <returns>AuditLogEntries</returns>
        AuditLogEntries GetAuditLogEntries (long? before, long? after, string q, decimal? limit, string spec);
        /// <summary>
        /// Use this endpoint to fetch a single audit log entry by its resouce ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param>
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
        /// Get a list of all audit log entries. The query parameters allow you to restrict the returned results by date ranges, resource specifiers, or a full-text search query. 
        /// </summary>
        /// <param name="before">A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have before this timestamp.</param> 
        /// <param name="after">A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have occurred after this timestamp.</param> 
        /// <param name="q">Text to search for. You can search for the full or partial name of the resource involved or full or partial email address of the member who made the change.</param> 
        /// <param name="limit">A limit on the number of audit log entries to be returned, between 1 and 20.</param> 
        /// <param name="spec">A resource specifier, allowing you to filter audit log listings by resource.</param> 
        /// <returns>AuditLogEntries</returns>            
        public AuditLogEntries GetAuditLogEntries (long? before, long? after, string q, decimal? limit, string spec)
        {
            
    
            var path = "/auditlog";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (spec != null) queryParams.Add("spec", ApiClient.ParameterToString(spec)); // query parameter
                                        
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
        /// Use this endpoint to fetch a single audit log entry by its resouce ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param> 
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
