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
    public interface IWebhooksApi
    {
        /// <summary>
        /// Delete a webhook by ID 
        /// </summary>
        /// <param name="webhookId">The webhook ID</param>
        /// <returns></returns>
        void DeleteWebhook (string webhookId);
        /// <summary>
        /// Get a webhook by ID 
        /// </summary>
        /// <param name="webhookId">The webhook ID</param>
        /// <returns>Webhook</returns>
        Webhook GetWebhook (string webhookId);
        /// <summary>
        /// Fetch a list of all webhooks 
        /// </summary>
        /// <returns>Webhooks</returns>
        Webhooks GetWebhooks ();
        /// <summary>
        /// Modify a webhook by ID 
        /// </summary>
        /// <param name="webhookId">The webhook ID</param>
        /// <param name="patchDelta">http://jsonpatch.com/</param>
        /// <returns></returns>
        void PatchWebhook (string webhookId, List<PatchDelta> patchDelta);
        /// <summary>
        /// Create a webhook 
        /// </summary>
        /// <param name="webhookPost">New webhook</param>
        /// <returns></returns>
        void PostWebhook (WebhookPost webhookPost);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi : IWebhooksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WebhooksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi(String basePath)
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
        /// Delete a webhook by ID 
        /// </summary>
        /// <param name="webhookId">The webhook ID</param> 
        /// <returns></returns>            
        public void DeleteWebhook (string webhookId)
        {
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling DeleteWebhook");
            
    
            var path = "/webhooks/{webhookId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a webhook by ID 
        /// </summary>
        /// <param name="webhookId">The webhook ID</param> 
        /// <returns>Webhook</returns>            
        public Webhook GetWebhook (string webhookId)
        {
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling GetWebhook");
            
    
            var path = "/webhooks/{webhookId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }
    
        /// <summary>
        /// Fetch a list of all webhooks 
        /// </summary>
        /// <returns>Webhooks</returns>            
        public Webhooks GetWebhooks ()
        {
            
    
            var path = "/webhooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhooks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhooks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Webhooks) ApiClient.Deserialize(response.Content, typeof(Webhooks), response.Headers);
        }
    
        /// <summary>
        /// Modify a webhook by ID 
        /// </summary>
        /// <param name="webhookId">The webhook ID</param> 
        /// <param name="patchDelta">http://jsonpatch.com/</param> 
        /// <returns></returns>            
        public void PatchWebhook (string webhookId, List<PatchDelta> patchDelta)
        {
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling PatchWebhook");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchWebhook");
            
    
            var path = "/webhooks/{webhookId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a webhook 
        /// </summary>
        /// <param name="webhookPost">New webhook</param> 
        /// <returns></returns>            
        public void PostWebhook (WebhookPost webhookPost)
        {
            
            // verify the required parameter 'webhookPost' is set
            if (webhookPost == null) throw new ApiException(400, "Missing required parameter 'webhookPost' when calling PostWebhook");
            
    
            var path = "/webhooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(webhookPost); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
