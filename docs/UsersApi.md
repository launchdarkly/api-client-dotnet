# IO.Swagger..UsersApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{projectKey}/{environmentKey}/{userKey} | Delete a user by ID
[**GetSearchUsers**](UsersApi.md#getsearchusers) | **GET** /user-search/{projectKey}/{environmentKey} | Search users in LaunchDarkly based on their last active date, or a search query.
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{projectKey}/{environmentKey}/{userKey} | Get a user by key.
[**GetUsers**](UsersApi.md#getusers) | **GET** /users/{projectKey}/{environmentKey} | List all users in the environment.


<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string projectKey, string environmentKey, string userKey)

Delete a user by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var projectKey = projectKey_example;  // string | The project key
            var environmentKey = environmentKey_example;  // string | The environment key
            var userKey = userKey_example;  // string | The user's key

            try
            {
                // Delete a user by ID
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
 **projectKey** | **string**| The project key | 
 **environmentKey** | **string**| The environment key | 
 **userKey** | **string**| The user&#39;s key | 

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
> Users GetSearchUsers (string projectKey, string environmentKey, string q, decimal? limit, decimal? offset, decimal? after)

Search users in LaunchDarkly based on their last active date, or a search query.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var projectKey = projectKey_example;  // string | The project key
            var environmentKey = environmentKey_example;  // string | The environment key
            var q = q_example;  // string | Search query (optional) 
            var limit = 3.4;  // decimal? | Pagination limit (optional) 
            var offset = 3.4;  // decimal? | Specifies the first item to return in the collection (optional) 
            var after = 3.4;  // decimal? | A unix epoch time in milliseconds specifying the maximum last time a user requested a feature flag (optional) 

            try
            {
                // Search users in LaunchDarkly based on their last active date, or a search query.
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
 **projectKey** | **string**| The project key | 
 **environmentKey** | **string**| The environment key | 
 **q** | **string**| Search query | [optional] 
 **limit** | **decimal?**| Pagination limit | [optional] 
 **offset** | **decimal?**| Specifies the first item to return in the collection | [optional] 
 **after** | **decimal?**| A unix epoch time in milliseconds specifying the maximum last time a user requested a feature flag | [optional] 

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
> User GetUser (string projectKey, string environmentKey, string userKey)

Get a user by key.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var projectKey = projectKey_example;  // string | The project key
            var environmentKey = environmentKey_example;  // string | The environment key
            var userKey = userKey_example;  // string | The user's key

            try
            {
                // Get a user by key.
                User result = apiInstance.GetUser(projectKey, environmentKey, userKey);
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
 **projectKey** | **string**| The project key | 
 **environmentKey** | **string**| The environment key | 
 **userKey** | **string**| The user&#39;s key | 

### Return type

[**User**](User.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> Users GetUsers (string projectKey, string environmentKey, decimal? limit)

List all users in the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var projectKey = projectKey_example;  // string | The project key
            var environmentKey = environmentKey_example;  // string | The environment key
            var limit = 3.4;  // decimal? | Pagination limit (optional) 

            try
            {
                // List all users in the environment.
                Users result = apiInstance.GetUsers(projectKey, environmentKey, limit);
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
 **projectKey** | **string**| The project key | 
 **environmentKey** | **string**| The environment key | 
 **limit** | **decimal?**| Pagination limit | [optional] 

### Return type

[**Users**](Users.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

