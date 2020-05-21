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
    public interface ITeamMembersApi
    {
        /// <summary>
        /// Delete a team member by ID. 
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <returns></returns>
        void DeleteMember (string memberId);
        /// <summary>
        /// Get the current team member associated with the token 
        /// </summary>
        /// <returns>Member</returns>
        Member GetMe ();
        /// <summary>
        /// Get a single team member by ID. 
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <returns>Member</returns>
        Member GetMember (string memberId);
        /// <summary>
        /// Returns a list of all members in the account. 
        /// </summary>
        /// <param name="limit">The number of objects to return. Defaults to -1, which returns everything.</param>
        /// <param name="offset">Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items.</param>
        /// <param name="filter">A comma-separated list of filters. Each filter is of the form field:value.</param>
        /// <param name="sort">A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order.</param>
        /// <returns>Members</returns>
        Members GetMembers (decimal? limit, decimal? offset, string filter, string sort);
        /// <summary>
        /// Modify a team member by ID. 
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param>
        /// <returns>Member</returns>
        Member PatchMember (string memberId, List<PatchOperation> patchDelta);
        /// <summary>
        /// Invite new members. 
        /// </summary>
        /// <param name="membersBody">New members to invite.</param>
        /// <returns>Members</returns>
        Members PostMembers (List<MembersBody> membersBody);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TeamMembersApi : ITeamMembersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TeamMembersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamMembersApi(String basePath)
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
        /// Delete a team member by ID. 
        /// </summary>
        /// <param name="memberId">The member ID.</param> 
        /// <returns></returns>            
        public void DeleteMember (string memberId)
        {
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling DeleteMember");
            
    
            var path = "/members/{memberId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the current team member associated with the token 
        /// </summary>
        /// <returns>Member</returns>            
        public Member GetMe ()
        {
            
    
            var path = "/members/me";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMe: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Member) ApiClient.Deserialize(response.Content, typeof(Member), response.Headers);
        }
    
        /// <summary>
        /// Get a single team member by ID. 
        /// </summary>
        /// <param name="memberId">The member ID.</param> 
        /// <returns>Member</returns>            
        public Member GetMember (string memberId)
        {
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling GetMember");
            
    
            var path = "/members/{memberId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Member) ApiClient.Deserialize(response.Content, typeof(Member), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of all members in the account. 
        /// </summary>
        /// <param name="limit">The number of objects to return. Defaults to -1, which returns everything.</param> 
        /// <param name="offset">Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items.</param> 
        /// <param name="filter">A comma-separated list of filters. Each filter is of the form field:value.</param> 
        /// <param name="sort">A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order.</param> 
        /// <returns>Members</returns>            
        public Members GetMembers (decimal? limit, decimal? offset, string filter, string sort)
        {
            
    
            var path = "/members";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Members) ApiClient.Deserialize(response.Content, typeof(Members), response.Headers);
        }
    
        /// <summary>
        /// Modify a team member by ID. 
        /// </summary>
        /// <param name="memberId">The member ID.</param> 
        /// <param name="patchDelta">Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39;</param> 
        /// <returns>Member</returns>            
        public Member PatchMember (string memberId, List<PatchOperation> patchDelta)
        {
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling PatchMember");
            
            // verify the required parameter 'patchDelta' is set
            if (patchDelta == null) throw new ApiException(400, "Missing required parameter 'patchDelta' when calling PatchMember");
            
    
            var path = "/members/{memberId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Member) ApiClient.Deserialize(response.Content, typeof(Member), response.Headers);
        }
    
        /// <summary>
        /// Invite new members. 
        /// </summary>
        /// <param name="membersBody">New members to invite.</param> 
        /// <returns>Members</returns>            
        public Members PostMembers (List<MembersBody> membersBody)
        {
            
            // verify the required parameter 'membersBody' is set
            if (membersBody == null) throw new ApiException(400, "Missing required parameter 'membersBody' when calling PostMembers");
            
    
            var path = "/members";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(membersBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Members) ApiClient.Deserialize(response.Content, typeof(Members), response.Headers);
        }
    
    }
}
