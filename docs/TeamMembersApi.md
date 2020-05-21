# LaunchDarkly.Api.Api.TeamMembersApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMember**](TeamMembersApi.md#deletemember) | **DELETE** /members/{memberId} | Delete a team member by ID.
[**GetMe**](TeamMembersApi.md#getme) | **GET** /members/me | Get the current team member associated with the token
[**GetMember**](TeamMembersApi.md#getmember) | **GET** /members/{memberId} | Get a single team member by ID.
[**GetMembers**](TeamMembersApi.md#getmembers) | **GET** /members | Returns a list of all members in the account.
[**PatchMember**](TeamMembersApi.md#patchmember) | **PATCH** /members/{memberId} | Modify a team member by ID.
[**PostMembers**](TeamMembersApi.md#postmembers) | **POST** /members | Invite new members.


<a name="deletemember"></a>
# **DeleteMember**
> void DeleteMember (string memberId)

Delete a team member by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class DeleteMemberExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var memberId = memberId_example;  // string | The member ID.

            try
            {
                // Delete a team member by ID.
                apiInstance.DeleteMember(memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.DeleteMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **string**| The member ID. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getme"></a>
# **GetMe**
> Member GetMe ()

Get the current team member associated with the token

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetMeExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();

            try
            {
                // Get the current team member associated with the token
                Member result = apiInstance.GetMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.GetMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Member**](Member.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmember"></a>
# **GetMember**
> Member GetMember (string memberId)

Get a single team member by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetMemberExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var memberId = memberId_example;  // string | The member ID.

            try
            {
                // Get a single team member by ID.
                Member result = apiInstance.GetMember(memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.GetMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **string**| The member ID. | 

### Return type

[**Member**](Member.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembers"></a>
# **GetMembers**
> Members GetMembers (decimal? limit, decimal? offset, string filter, string sort)

Returns a list of all members in the account.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetMembersExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var limit = 8.14;  // decimal? | The number of objects to return. Defaults to -1, which returns everything. (optional) 
            var offset = 8.14;  // decimal? | Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items. (optional) 
            var filter = filter_example;  // string | A comma-separated list of filters. Each filter is of the form field:value. (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order. (optional) 

            try
            {
                // Returns a list of all members in the account.
                Members result = apiInstance.GetMembers(limit, offset, filter, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.GetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **decimal?**| The number of objects to return. Defaults to -1, which returns everything. | [optional] 
 **offset** | **decimal?**| Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items. | [optional] 
 **filter** | **string**| A comma-separated list of filters. Each filter is of the form field:value. | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order. | [optional] 

### Return type

[**Members**](Members.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchmember"></a>
# **PatchMember**
> Member PatchMember (string memberId, List<PatchOperation> patchDelta)

Modify a team member by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PatchMemberExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var memberId = memberId_example;  // string | The member ID.
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify a team member by ID.
                Member result = apiInstance.PatchMember(memberId, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.PatchMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **string**| The member ID. | 
 **patchDelta** | [**List<PatchOperation>**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**Member**](Member.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmembers"></a>
# **PostMembers**
> Members PostMembers (List<MembersBody> membersBody)

Invite new members.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostMembersExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var membersBody = new List<MembersBody>(); // List<MembersBody> | New members to invite.

            try
            {
                // Invite new members.
                Members result = apiInstance.PostMembers(membersBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.PostMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membersBody** | [**List<MembersBody>**](MembersBody.md)| New members to invite. | 

### Return type

[**Members**](Members.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

