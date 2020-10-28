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
    public interface IIntegrationsApi
    {
        /// <summary>
        /// Delete an integration subscription by ID. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param>
        /// <param name="integrationId">The integration ID.</param>
        /// <returns></returns>
        void DeleteIntegrationSubscription (string integrationKey, string integrationId);
        /// <summary>
        /// Get a single integration subscription by ID. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param>
        /// <param name="integrationId">The integration ID.</param>
        /// <returns>IntegrationSubscription</returns>
        IntegrationSubscription GetIntegrationSubscription (string integrationKey, string integrationId);
        /// <summary>
        /// Get a list of all configured integrations of a given kind. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param>
        /// <returns>Integration</returns>
        Integration GetIntegrationSubscriptions (string integrationKey);
        /// <summary>
        /// Get a list of all configured audit log event integrations associated with this account. 
        /// </summary>
        /// <returns>Integrations</returns>
        Integrations GetIntegrations ();
        /// <summary>
        /// Modify an integration subscription by ID. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param>
        /// <param name="integrationId">The integration ID.</param>
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param>
        /// <returns>IntegrationSubscription</returns>
        IntegrationSubscription PatchIntegrationSubscription (string integrationKey, string integrationId, List<PatchOperation> patchDelta);
        /// <summary>
        /// Create a new integration subscription of a given kind. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param>
        /// <param name="subscriptionBody">Create a new integration subscription.</param>
        /// <returns>IntegrationSubscription</returns>
        IntegrationSubscription PostIntegrationSubscription (string integrationKey, SubscriptionBody subscriptionBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IntegrationsApi : IIntegrationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IntegrationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntegrationsApi(String basePath)
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
        /// Delete an integration subscription by ID. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param> 
        /// <param name="integrationId">The integration ID.</param> 
        /// <returns></returns>            
        public void DeleteIntegrationSubscription (string integrationKey, string integrationId)
        {
            
            // verify the required parameter 'integrationKey' is set
            if (integrationKey == null) throw new ApiException(400, "Missing required parameter 'integrationKey' when calling DeleteIntegrationSubscription");
            
            // verify the required parameter 'integrationId' is set
            if (integrationId == null) throw new ApiException(400, "Missing required parameter 'integrationId' when calling DeleteIntegrationSubscription");
            
    
            var path = "/integrations/{integrationKey}/{integrationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "integrationKey" + "}", ApiClient.ParameterToString(integrationKey));
path = path.Replace("{" + "integrationId" + "}", ApiClient.ParameterToString(integrationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIntegrationSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIntegrationSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single integration subscription by ID. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param> 
        /// <param name="integrationId">The integration ID.</param> 
        /// <returns>IntegrationSubscription</returns>            
        public IntegrationSubscription GetIntegrationSubscription (string integrationKey, string integrationId)
        {
            
            // verify the required parameter 'integrationKey' is set
            if (integrationKey == null) throw new ApiException(400, "Missing required parameter 'integrationKey' when calling GetIntegrationSubscription");
            
            // verify the required parameter 'integrationId' is set
            if (integrationId == null) throw new ApiException(400, "Missing required parameter 'integrationId' when calling GetIntegrationSubscription");
            
    
            var path = "/integrations/{integrationKey}/{integrationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "integrationKey" + "}", ApiClient.ParameterToString(integrationKey));
path = path.Replace("{" + "integrationId" + "}", ApiClient.ParameterToString(integrationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntegrationSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntegrationSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IntegrationSubscription) ApiClient.Deserialize(response.Content, typeof(IntegrationSubscription), response.Headers);
        }
    
        /// <summary>
        /// Get a list of all configured integrations of a given kind. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param> 
        /// <returns>Integration</returns>            
        public Integration GetIntegrationSubscriptions (string integrationKey)
        {
            
            // verify the required parameter 'integrationKey' is set
            if (integrationKey == null) throw new ApiException(400, "Missing required parameter 'integrationKey' when calling GetIntegrationSubscriptions");
            
    
            var path = "/integrations/{integrationKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "integrationKey" + "}", ApiClient.ParameterToString(integrationKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntegrationSubscriptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntegrationSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Integration) ApiClient.Deserialize(response.Content, typeof(Integration), response.Headers);
        }
    
        /// <summary>
        /// Get a list of all configured audit log event integrations associated with this account. 
        /// </summary>
        /// <returns>Integrations</returns>            
        public Integrations GetIntegrations ()
        {
            
    
            var path = "/integrations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntegrations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIntegrations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Integrations) ApiClient.Deserialize(response.Content, typeof(Integrations), response.Headers);
        }
    
        /// <summary>
        /// Modify an integration subscription by ID. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param> 
        /// <param name="integrationId">The integration ID.</param> 
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param> 
        /// <returns>IntegrationSubscription</returns>            
        public IntegrationSubscription PatchIntegrationSubscription (string integrationKey, string integrationId, List<PatchOperation> patchDelta)
        {
            
            // verify the required parameter 'integrationKey' is set
            if (integrationKey == null) throw new ApiException(400, "Missing required parameter 'integrationKey' when calling PatchIntegrationSubscription");
            
            // verify the required parameter 'integrationId' is set
            if (integrationId == null) throw new ApiException(400, "Missing required parameter 'integrationId' when calling PatchIntegrationSubscription");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchIntegrationSubscription");
            
    
            var path = "/integrations/{integrationKey}/{integrationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "integrationKey" + "}", ApiClient.ParameterToString(integrationKey));
path = path.Replace("{" + "integrationId" + "}", ApiClient.ParameterToString(integrationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchIntegrationSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchIntegrationSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IntegrationSubscription) ApiClient.Deserialize(response.Content, typeof(IntegrationSubscription), response.Headers);
        }
    
        /// <summary>
        /// Create a new integration subscription of a given kind. 
        /// </summary>
        /// <param name="integrationKey">The key used to specify the integration kind.</param> 
        /// <param name="subscriptionBody">Create a new integration subscription.</param> 
        /// <returns>IntegrationSubscription</returns>            
        public IntegrationSubscription PostIntegrationSubscription (string integrationKey, SubscriptionBody subscriptionBody)
        {
            
            // verify the required parameter 'integrationKey' is set
            if (integrationKey == null) throw new ApiException(400, "Missing required parameter 'integrationKey' when calling PostIntegrationSubscription");
            
            // verify the required parameter 'subscriptionBody' is set
            if (subscriptionBody == null) throw new ApiException(400, "Missing required parameter 'subscriptionBody' when calling PostIntegrationSubscription");
            
    
            var path = "/integrations/{integrationKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "integrationKey" + "}", ApiClient.ParameterToString(integrationKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscriptionBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostIntegrationSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostIntegrationSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IntegrationSubscription) ApiClient.Deserialize(response.Content, typeof(IntegrationSubscription), response.Headers);
        }
    
    }
}
