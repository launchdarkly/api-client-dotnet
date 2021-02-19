# LaunchDarkly.Api.Api.UsersApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{projectKey}/{environmentKey}/{userKey} | Delete a user by ID.
[**GetSearchUsers**](UsersApi.md#getsearchusers) | **GET** /user-search/{projectKey}/{environmentKey} | Search users in LaunchDarkly based on their last active date, or a search query. It should not be used to enumerate all users in LaunchDarkly- - use the List users API resource.
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{projectKey}/{environmentKey}/{userKey} | Get a user by key.
[**GetUsers**](UsersApi.md#getusers) | **GET** /users/{projectKey}/{environmentKey} | List all users in the environment. Includes the total count of users. In each page, there will be up to &#39;limit&#39; users returned (default 20). This is useful for exporting all users in the system for further analysis. Paginated collections will include a next link containing a URL with the next set of elements in the collection.


<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string projectKey, string environmentKey, string userKey)

Delete a user by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var userKey = userKey_example;  // string | The user's key.

            try
            {
                // Delete a user by ID.
                apiInstance.DeleteUser(projectKey, environmentKey, userKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **userKey** | **string**| The user&#39;s key. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearchusers"></a>
# **GetSearchUsers**
> Users GetSearchUsers (string projectKey, string environmentKey, string q, int? limit, int? offset, long? after)

Search users in LaunchDarkly based on their last active date, or a search query. It should not be used to enumerate all users in LaunchDarkly- - use the List users API resource.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetSearchUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var q = q_example;  // string | Search query. (optional) 
            var limit = 56;  // int? | Pagination limit. (optional) 
            var offset = 56;  // int? | Specifies the first item to return in the collection. (optional) 
            var after = 789;  // long? | A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have occurred after this timestamp. (optional) 

            try
            {
                // Search users in LaunchDarkly based on their last active date, or a search query. It should not be used to enumerate all users in LaunchDarkly- - use the List users API resource.
                Users result = apiInstance.GetSearchUsers(projectKey, environmentKey, q, limit, offset, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSearchUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **q** | **string**| Search query. | [optional] 
 **limit** | **int?**| Pagination limit. | [optional] 
 **offset** | **int?**| Specifies the first item to return in the collection. | [optional] 
 **after** | **long?**| A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have occurred after this timestamp. | [optional] 

### Return type

[**Users**](Users.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserRecord GetUser (string projectKey, string environmentKey, string userKey)

Get a user by key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var userKey = userKey_example;  // string | The user's key.

            try
            {
                // Get a user by key.
                UserRecord result = apiInstance.GetUser(projectKey, environmentKey, userKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **userKey** | **string**| The user&#39;s key. | 

### Return type

[**UserRecord**](UserRecord.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> Users GetUsers (string projectKey, string environmentKey, int? limit, string h, string scrollId)

List all users in the environment. Includes the total count of users. In each page, there will be up to 'limit' users returned (default 20). This is useful for exporting all users in the system for further analysis. Paginated collections will include a next link containing a URL with the next set of elements in the collection.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var limit = 56;  // int? | Pagination limit. (optional) 
            var h = h_example;  // string | This parameter is required when following \"next\" links. (optional) 
            var scrollId = scrollId_example;  // string | This parameter is required when following \"next\" links. (optional) 

            try
            {
                // List all users in the environment. Includes the total count of users. In each page, there will be up to 'limit' users returned (default 20). This is useful for exporting all users in the system for further analysis. Paginated collections will include a next link containing a URL with the next set of elements in the collection.
                Users result = apiInstance.GetUsers(projectKey, environmentKey, limit, h, scrollId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **limit** | **int?**| Pagination limit. | [optional] 
 **h** | **string**| This parameter is required when following \&quot;next\&quot; links. | [optional] 
 **scrollId** | **string**| This parameter is required when following \&quot;next\&quot; links. | [optional] 

### Return type

[**Users**](Users.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

