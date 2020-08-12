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
    public interface IAccessTokensApi
    {
        /// <summary>
        /// Delete an access token by ID. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param>
        /// <returns></returns>
        void DeleteToken (string tokenId);
        /// <summary>
        /// Get a single access token by ID. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param>
        /// <returns>Token</returns>
        Token GetToken (string tokenId);
        /// <summary>
        /// Returns a list of tokens in the account. 
        /// </summary>
        /// <param name="showAll">If set to true, and the authentication access token has the \&quot;Admin\&quot; role, personal access tokens for all members will be retrieved.</param>
        /// <returns>Tokens</returns>
        Tokens GetTokens (bool? showAll);
        /// <summary>
        /// Modify an access tokenby ID. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param>
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param>
        /// <returns>Token</returns>
        Token PatchToken (string tokenId, List<PatchOperation> patchDelta);
        /// <summary>
        /// Create a new token. 
        /// </summary>
        /// <param name="tokenBody">Create a new access token.</param>
        /// <returns>Token</returns>
        Token PostToken (TokenBody tokenBody);
        /// <summary>
        /// Reset an access token&#39;s secret key with an optional expiry time for the old key. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param>
        /// <param name="expiry">An expiration time for the old token key, expressed as a Unix epoch time in milliseconds. By default, the token will expire immediately.</param>
        /// <returns>Token</returns>
        Token ResetToken (string tokenId, long? expiry);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccessTokensApi : IAccessTokensApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokensApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccessTokensApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessTokensApi(String basePath)
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
        /// Delete an access token by ID. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param> 
        /// <returns></returns>            
        public void DeleteToken (string tokenId)
        {
            
            // verify the required parameter 'tokenId' is set
            if (tokenId == null) throw new ApiException(400, "Missing required parameter 'tokenId' when calling DeleteToken");
            
    
            var path = "/tokens/{tokenId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "tokenId" + "}", ApiClient.ParameterToString(tokenId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single access token by ID. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param> 
        /// <returns>Token</returns>            
        public Token GetToken (string tokenId)
        {
            
            // verify the required parameter 'tokenId' is set
            if (tokenId == null) throw new ApiException(400, "Missing required parameter 'tokenId' when calling GetToken");
            
    
            var path = "/tokens/{tokenId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "tokenId" + "}", ApiClient.ParameterToString(tokenId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Token) ApiClient.Deserialize(response.Content, typeof(Token), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of tokens in the account. 
        /// </summary>
        /// <param name="showAll">If set to true, and the authentication access token has the \&quot;Admin\&quot; role, personal access tokens for all members will be retrieved.</param> 
        /// <returns>Tokens</returns>            
        public Tokens GetTokens (bool? showAll)
        {
            
    
            var path = "/tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showAll != null) queryParams.Add("showAll", ApiClient.ParameterToString(showAll)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Tokens) ApiClient.Deserialize(response.Content, typeof(Tokens), response.Headers);
        }
    
        /// <summary>
        /// Modify an access tokenby ID. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param> 
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param> 
        /// <returns>Token</returns>            
        public Token PatchToken (string tokenId, List<PatchOperation> patchDelta)
        {
            
            // verify the required parameter 'tokenId' is set
            if (tokenId == null) throw new ApiException(400, "Missing required parameter 'tokenId' when calling PatchToken");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchToken");
            
    
            var path = "/tokens/{tokenId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "tokenId" + "}", ApiClient.ParameterToString(tokenId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Token) ApiClient.Deserialize(response.Content, typeof(Token), response.Headers);
        }
    
        /// <summary>
        /// Create a new token. 
        /// </summary>
        /// <param name="tokenBody">Create a new access token.</param> 
        /// <returns>Token</returns>            
        public Token PostToken (TokenBody tokenBody)
        {
            
            // verify the required parameter 'tokenBody' is set
            if (tokenBody == null) throw new ApiException(400, "Missing required parameter 'tokenBody' when calling PostToken");
            
    
            var path = "/tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(tokenBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Token) ApiClient.Deserialize(response.Content, typeof(Token), response.Headers);
        }
    
        /// <summary>
        /// Reset an access token&#39;s secret key with an optional expiry time for the old key. 
        /// </summary>
        /// <param name="tokenId">The access token ID.</param> 
        /// <param name="expiry">An expiration time for the old token key, expressed as a Unix epoch time in milliseconds. By default, the token will expire immediately.</param> 
        /// <returns>Token</returns>            
        public Token ResetToken (string tokenId, long? expiry)
        {
            
            // verify the required parameter 'tokenId' is set
            if (tokenId == null) throw new ApiException(400, "Missing required parameter 'tokenId' when calling ResetToken");
            
    
            var path = "/tokens/{tokenId}/reset";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "tokenId" + "}", ApiClient.ParameterToString(tokenId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ResetToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ResetToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Token) ApiClient.Deserialize(response.Content, typeof(Token), response.Headers);
        }
    
    }
}
