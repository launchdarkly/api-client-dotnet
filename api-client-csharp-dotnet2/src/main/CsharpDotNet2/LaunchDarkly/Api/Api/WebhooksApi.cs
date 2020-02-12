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
    public interface IWebhooksApi
    {
        /// <summary>
        /// Delete a webhook by ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param>
        /// <returns></returns>
        void DeleteWebhook (string resourceId);
        /// <summary>
        /// Get a webhook by ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param>
        /// <returns>Webhook</returns>
        Webhook GetWebhook (string resourceId);
        /// <summary>
        /// Fetch a list of all webhooks. 
        /// </summary>
        /// <returns>Webhooks</returns>
        Webhooks GetWebhooks ();
        /// <summary>
        /// Modify a webhook by ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param>
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param>
        /// <returns>Webhook</returns>
        Webhook PatchWebhook (string resourceId, List<PatchOperation> patchDelta);
        /// <summary>
        /// Create a webhook. 
        /// </summary>
        /// <param name="webhookBody">New webhook.</param>
        /// <returns>Webhook</returns>
        Webhook PostWebhook (WebhookBody webhookBody);
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
        /// Delete a webhook by ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param> 
        /// <returns></returns>            
        public void DeleteWebhook (string resourceId)
        {
            
            // verify the required parameter 'resourceId' is set
            if (resourceId == null) throw new ApiException(400, "Missing required parameter 'resourceId' when calling DeleteWebhook");
            
    
            var path = "/webhooks/{resourceId}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a webhook by ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param> 
        /// <returns>Webhook</returns>            
        public Webhook GetWebhook (string resourceId)
        {
            
            // verify the required parameter 'resourceId' is set
            if (resourceId == null) throw new ApiException(400, "Missing required parameter 'resourceId' when calling GetWebhook");
            
    
            var path = "/webhooks/{resourceId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }
    
        /// <summary>
        /// Fetch a list of all webhooks. 
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
        /// Modify a webhook by ID. 
        /// </summary>
        /// <param name="resourceId">The resource ID.</param> 
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param> 
        /// <returns>Webhook</returns>            
        public Webhook PatchWebhook (string resourceId, List<PatchOperation> patchDelta)
        {
            
            // verify the required parameter 'resourceId' is set
            if (resourceId == null) throw new ApiException(400, "Missing required parameter 'resourceId' when calling PatchWebhook");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchWebhook");
            
    
            var path = "/webhooks/{resourceId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "resourceId" + "}", ApiClient.ParameterToString(resourceId));
    
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
    
            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }
    
        /// <summary>
        /// Create a webhook. 
        /// </summary>
        /// <param name="webhookBody">New webhook.</param> 
        /// <returns>Webhook</returns>            
        public Webhook PostWebhook (WebhookBody webhookBody)
        {
            
            // verify the required parameter 'webhookBody' is set
            if (webhookBody == null) throw new ApiException(400, "Missing required parameter 'webhookBody' when calling PostWebhook");
            
    
            var path = "/webhooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(webhookBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }
    
    }
}
