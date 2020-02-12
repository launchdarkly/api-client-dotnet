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
    public interface ICustomerMetricsApi
    {
        /// <summary>
        /// Get events usage by event id and the feature flag key. 
        /// </summary>
        /// <param name="envId">The environment id for the flag evaluations in question.</param>
        /// <param name="flagKey">The key of the flag we want metrics for.</param>
        /// <returns>StreamSDKVersion</returns>
        StreamSDKVersion GetEvaluations (string envId, string flagKey);
        /// <summary>
        /// Get events usage by event type. 
        /// </summary>
        /// <param name="type">The type of event we would like to track.</param>
        /// <returns>StreamSDKVersion</returns>
        StreamSDKVersion GetEvent (string type);
        /// <summary>
        /// Get events usage endpoints. 
        /// </summary>
        /// <returns>Events</returns>
        Events GetEvents ();
        /// <summary>
        /// Get monthly active user data. 
        /// </summary>
        /// <returns>MAU</returns>
        MAU GetMAU ();
        /// <summary>
        /// Get monthly active user data by category. 
        /// </summary>
        /// <returns>MAUbyCategory</returns>
        MAUbyCategory GetMAUByCategory ();
        /// <summary>
        /// Get a stream endpoint and return timeseries data. 
        /// </summary>
        /// <param name="source">The source of where the stream comes from.</param>
        /// <returns>Stream</returns>
        Stream GetStream (string source);
        /// <summary>
        /// Get a stream timeseries data by source show sdk version metadata. 
        /// </summary>
        /// <param name="source">The source of where the stream comes from.</param>
        /// <returns>StreamBySDK</returns>
        StreamBySDK GetStreamBySDK (string source);
        /// <summary>
        /// Get a stream timeseries data by source and show all sdk version associated. 
        /// </summary>
        /// <param name="source">The source of where the stream comes from.</param>
        /// <returns>StreamSDKVersion</returns>
        StreamSDKVersion GetStreamSDKVersion (string source);
        /// <summary>
        /// Returns a list of all streams. 
        /// </summary>
        /// <returns>Streams</returns>
        Streams GetStreams ();
        /// <summary>
        /// Returns of the usage endpoints available. 
        /// </summary>
        /// <returns>Usage</returns>
        Usage GetUsage ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerMetricsApi : ICustomerMetricsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMetricsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomerMetricsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMetricsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerMetricsApi(String basePath)
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
        /// Get events usage by event id and the feature flag key. 
        /// </summary>
        /// <param name="envId">The environment id for the flag evaluations in question.</param> 
        /// <param name="flagKey">The key of the flag we want metrics for.</param> 
        /// <returns>StreamSDKVersion</returns>            
        public StreamSDKVersion GetEvaluations (string envId, string flagKey)
        {
            
            // verify the required parameter 'envId' is set
            if (envId == null) throw new ApiException(400, "Missing required parameter 'envId' when calling GetEvaluations");
            
            // verify the required parameter 'flagKey' is set
            if (flagKey == null) throw new ApiException(400, "Missing required parameter 'flagKey' when calling GetEvaluations");
            
    
            var path = "/usage/evaluations/{envId}/{flagKey}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "envId" + "}", ApiClient.ParameterToString(envId));
path = path.Replace("{" + "flagKey" + "}", ApiClient.ParameterToString(flagKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvaluations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvaluations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamSDKVersion) ApiClient.Deserialize(response.Content, typeof(StreamSDKVersion), response.Headers);
        }
    
        /// <summary>
        /// Get events usage by event type. 
        /// </summary>
        /// <param name="type">The type of event we would like to track.</param> 
        /// <returns>StreamSDKVersion</returns>            
        public StreamSDKVersion GetEvent (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling GetEvent");
            
    
            var path = "/usage/events/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamSDKVersion) ApiClient.Deserialize(response.Content, typeof(StreamSDKVersion), response.Headers);
        }
    
        /// <summary>
        /// Get events usage endpoints. 
        /// </summary>
        /// <returns>Events</returns>            
        public Events GetEvents ()
        {
            
    
            var path = "/usage/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Events) ApiClient.Deserialize(response.Content, typeof(Events), response.Headers);
        }
    
        /// <summary>
        /// Get monthly active user data. 
        /// </summary>
        /// <returns>MAU</returns>            
        public MAU GetMAU ()
        {
            
    
            var path = "/usage/mau";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMAU: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMAU: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MAU) ApiClient.Deserialize(response.Content, typeof(MAU), response.Headers);
        }
    
        /// <summary>
        /// Get monthly active user data by category. 
        /// </summary>
        /// <returns>MAUbyCategory</returns>            
        public MAUbyCategory GetMAUByCategory ()
        {
            
    
            var path = "/usage/mau/bycategory";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMAUByCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMAUByCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MAUbyCategory) ApiClient.Deserialize(response.Content, typeof(MAUbyCategory), response.Headers);
        }
    
        /// <summary>
        /// Get a stream endpoint and return timeseries data. 
        /// </summary>
        /// <param name="source">The source of where the stream comes from.</param> 
        /// <returns>Stream</returns>            
        public Stream GetStream (string source)
        {
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetStream");
            
    
            var path = "/usage/streams/{source}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "source" + "}", ApiClient.ParameterToString(source));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStream: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStream: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
    
        /// <summary>
        /// Get a stream timeseries data by source show sdk version metadata. 
        /// </summary>
        /// <param name="source">The source of where the stream comes from.</param> 
        /// <returns>StreamBySDK</returns>            
        public StreamBySDK GetStreamBySDK (string source)
        {
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetStreamBySDK");
            
    
            var path = "/usage/streams/{source}/bysdkversion";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "source" + "}", ApiClient.ParameterToString(source));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStreamBySDK: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStreamBySDK: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamBySDK) ApiClient.Deserialize(response.Content, typeof(StreamBySDK), response.Headers);
        }
    
        /// <summary>
        /// Get a stream timeseries data by source and show all sdk version associated. 
        /// </summary>
        /// <param name="source">The source of where the stream comes from.</param> 
        /// <returns>StreamSDKVersion</returns>            
        public StreamSDKVersion GetStreamSDKVersion (string source)
        {
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling GetStreamSDKVersion");
            
    
            var path = "/usage/streams/{source}/sdkversions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "source" + "}", ApiClient.ParameterToString(source));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStreamSDKVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStreamSDKVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamSDKVersion) ApiClient.Deserialize(response.Content, typeof(StreamSDKVersion), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of all streams. 
        /// </summary>
        /// <returns>Streams</returns>            
        public Streams GetStreams ()
        {
            
    
            var path = "/usage/streams";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStreams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStreams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Streams) ApiClient.Deserialize(response.Content, typeof(Streams), response.Headers);
        }
    
        /// <summary>
        /// Returns of the usage endpoints available. 
        /// </summary>
        /// <returns>Usage</returns>            
        public Usage GetUsage ()
        {
            
    
            var path = "/usage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Usage) ApiClient.Deserialize(response.Content, typeof(Usage), response.Headers);
        }
    
    }
}
