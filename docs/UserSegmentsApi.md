# IO.Swagger.Api.UserSegmentsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUserSegment**](UserSegmentsApi.md#deleteusersegment) | **DELETE** /segments/{projectKey}/{environmentKey}/{userSegmentKey} | Delete a user segment.
[**GetUserSegment**](UserSegmentsApi.md#getusersegment) | **GET** /segments/{projectKey}/{environmentKey}/{userSegmentKey} | Get a single user segment by key.
[**GetUserSegments**](UserSegmentsApi.md#getusersegments) | **GET** /segments/{projectKey}/{environmentKey} | Get a list of all user segments in the given project.
[**PatchUserSegment**](UserSegmentsApi.md#patchusersegment) | **PATCH** /segments/{projectKey}/{environmentKey}/{userSegmentKey} | Perform a partial update to a user segment.
[**PostUserSegment**](UserSegmentsApi.md#postusersegment) | **POST** /segments/{projectKey}/{environmentKey} | Creates a new user segment.


<a name="deleteusersegment"></a>
# **DeleteUserSegment**
> void DeleteUserSegment (string projectKey, string environmentKey, string userSegmentKey)

Delete a user segment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserSegmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserSegmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var userSegmentKey = userSegmentKey_example;  // string | The user segment's key. The key identifies the user segment in your code.

            try
            {
                // Delete a user segment.
                apiInstance.DeleteUserSegment(projectKey, environmentKey, userSegmentKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSegmentsApi.DeleteUserSegment: " + e.Message );
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
 **userSegmentKey** | **string**| The user segment&#39;s key. The key identifies the user segment in your code. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersegment"></a>
# **GetUserSegment**
> UserSegment GetUserSegment (string projectKey, string environmentKey, string userSegmentKey)

Get a single user segment by key.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserSegmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserSegmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var userSegmentKey = userSegmentKey_example;  // string | The user segment's key. The key identifies the user segment in your code.

            try
            {
                // Get a single user segment by key.
                UserSegment result = apiInstance.GetUserSegment(projectKey, environmentKey, userSegmentKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSegmentsApi.GetUserSegment: " + e.Message );
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
 **userSegmentKey** | **string**| The user segment&#39;s key. The key identifies the user segment in your code. | 

### Return type

[**UserSegment**](UserSegment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersegments"></a>
# **GetUserSegments**
> UserSegments GetUserSegments (string projectKey, string environmentKey, string tag)

Get a list of all user segments in the given project.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserSegmentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserSegmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var tag = tag_example;  // string | Filter by tag. A tag can be used to group flags across projects. (optional) 

            try
            {
                // Get a list of all user segments in the given project.
                UserSegments result = apiInstance.GetUserSegments(projectKey, environmentKey, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSegmentsApi.GetUserSegments: " + e.Message );
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
 **tag** | **string**| Filter by tag. A tag can be used to group flags across projects. | [optional] 

### Return type

[**UserSegments**](UserSegments.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchusersegment"></a>
# **PatchUserSegment**
> UserSegment PatchUserSegment (string projectKey, string environmentKey, string userSegmentKey, List<PatchOperation> patchOnly)

Perform a partial update to a user segment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchUserSegmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserSegmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var userSegmentKey = userSegmentKey_example;  // string | The user segment's key. The key identifies the user segment in your code.
            var patchOnly = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/' Feature flag patches also support JSON Merge Patch format. 'https://tools.ietf.org/html/rfc7386' The addition of comments is also supported.

            try
            {
                // Perform a partial update to a user segment.
                UserSegment result = apiInstance.PatchUserSegment(projectKey, environmentKey, userSegmentKey, patchOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSegmentsApi.PatchUserSegment: " + e.Message );
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
 **userSegmentKey** | **string**| The user segment&#39;s key. The key identifies the user segment in your code. | 
 **patchOnly** | [**List<PatchOperation>**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported. | 

### Return type

[**UserSegment**](UserSegment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusersegment"></a>
# **PostUserSegment**
> void PostUserSegment (string projectKey, string environmentKey, UserSegmentBody userSegmentBody)

Creates a new user segment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUserSegmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new UserSegmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var userSegmentBody = new UserSegmentBody(); // UserSegmentBody | Create a new user segment.

            try
            {
                // Creates a new user segment.
                apiInstance.PostUserSegment(projectKey, environmentKey, userSegmentBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSegmentsApi.PostUserSegment: " + e.Message );
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
 **userSegmentBody** | [**UserSegmentBody**](UserSegmentBody.md)| Create a new user segment. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

