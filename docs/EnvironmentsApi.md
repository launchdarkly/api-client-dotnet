# LaunchDarkly.Api.Api.EnvironmentsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEnvironment**](EnvironmentsApi.md#deleteenvironment) | **DELETE** /projects/{projectKey}/environments/{environmentKey} | Delete an environment in a specific project.
[**GetEnvironment**](EnvironmentsApi.md#getenvironment) | **GET** /projects/{projectKey}/environments/{environmentKey} | Get an environment given a project and key.
[**PatchEnvironment**](EnvironmentsApi.md#patchenvironment) | **PATCH** /projects/{projectKey}/environments/{environmentKey} | Modify an environment by ID. If you try to patch the environment by setting both required and requiredApprovalTags, it will result in an error. Users can specify either required approvals for all flags in an environment or those with specific tags, but not both. Only customers on an Enterprise plan can require approval for flag updates with either mechanism.
[**PostEnvironment**](EnvironmentsApi.md#postenvironment) | **POST** /projects/{projectKey}/environments | Create a new environment in a specified project with a given name, key, and swatch color.
[**ResetEnvironmentMobileKey**](EnvironmentsApi.md#resetenvironmentmobilekey) | **POST** /projects/{projectKey}/environments/{environmentKey}/mobileKey | Reset an environment&#39;s mobile key. The optional expiry for the old key is deprecated for this endpoint, so the old key will always expire immediately.
[**ResetEnvironmentSDKKey**](EnvironmentsApi.md#resetenvironmentsdkkey) | **POST** /projects/{projectKey}/environments/{environmentKey}/apiKey | Reset an environment&#39;s SDK key with an optional expiry time for the old key.


<a name="deleteenvironment"></a>
# **DeleteEnvironment**
> void DeleteEnvironment (string projectKey, string environmentKey)

Delete an environment in a specific project.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class DeleteEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.

            try
            {
                // Delete an environment in a specific project.
                apiInstance.DeleteEnvironment(projectKey, environmentKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsApi.DeleteEnvironment: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenvironment"></a>
# **GetEnvironment**
> Environment GetEnvironment (string projectKey, string environmentKey)

Get an environment given a project and key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.

            try
            {
                // Get an environment given a project and key.
                Environment result = apiInstance.GetEnvironment(projectKey, environmentKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsApi.GetEnvironment: " + e.Message );
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

### Return type

[**Environment**](Environment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchenvironment"></a>
# **PatchEnvironment**
> Environment PatchEnvironment (string projectKey, string environmentKey, List<PatchOperation> patchDelta)

Modify an environment by ID. If you try to patch the environment by setting both required and requiredApprovalTags, it will result in an error. Users can specify either required approvals for all flags in an environment or those with specific tags, but not both. Only customers on an Enterprise plan can require approval for flag updates with either mechanism.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PatchEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify an environment by ID. If you try to patch the environment by setting both required and requiredApprovalTags, it will result in an error. Users can specify either required approvals for all flags in an environment or those with specific tags, but not both. Only customers on an Enterprise plan can require approval for flag updates with either mechanism.
                Environment result = apiInstance.PatchEnvironment(projectKey, environmentKey, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsApi.PatchEnvironment: " + e.Message );
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
 **patchDelta** | [**List<PatchOperation>**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**Environment**](Environment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postenvironment"></a>
# **PostEnvironment**
> Environment PostEnvironment (string projectKey, EnvironmentPost environmentBody)

Create a new environment in a specified project with a given name, key, and swatch color.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostEnvironmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentBody = new EnvironmentPost(); // EnvironmentPost | New environment.

            try
            {
                // Create a new environment in a specified project with a given name, key, and swatch color.
                Environment result = apiInstance.PostEnvironment(projectKey, environmentBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsApi.PostEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentBody** | [**EnvironmentPost**](EnvironmentPost.md)| New environment. | 

### Return type

[**Environment**](Environment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetenvironmentmobilekey"></a>
# **ResetEnvironmentMobileKey**
> Environment ResetEnvironmentMobileKey (string projectKey, string environmentKey, long? expiry)

Reset an environment's mobile key. The optional expiry for the old key is deprecated for this endpoint, so the old key will always expire immediately.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class ResetEnvironmentMobileKeyExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var expiry = 789;  // long? | The expiry parameter is deprecated for this endpoint, so the old mobile key will always expire immediately. This parameter will be removed in an upcoming major API client version. (optional) 

            try
            {
                // Reset an environment's mobile key. The optional expiry for the old key is deprecated for this endpoint, so the old key will always expire immediately.
                Environment result = apiInstance.ResetEnvironmentMobileKey(projectKey, environmentKey, expiry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsApi.ResetEnvironmentMobileKey: " + e.Message );
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
 **expiry** | **long?**| The expiry parameter is deprecated for this endpoint, so the old mobile key will always expire immediately. This parameter will be removed in an upcoming major API client version. | [optional] 

### Return type

[**Environment**](Environment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetenvironmentsdkkey"></a>
# **ResetEnvironmentSDKKey**
> Environment ResetEnvironmentSDKKey (string projectKey, string environmentKey, long? expiry)

Reset an environment's SDK key with an optional expiry time for the old key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class ResetEnvironmentSDKKeyExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EnvironmentsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var expiry = 789;  // long? | An expiration time for the old environment SDK key, expressed as a Unix epoch time in milliseconds. By default, the key will expire immediately. (optional) 

            try
            {
                // Reset an environment's SDK key with an optional expiry time for the old key.
                Environment result = apiInstance.ResetEnvironmentSDKKey(projectKey, environmentKey, expiry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsApi.ResetEnvironmentSDKKey: " + e.Message );
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
 **expiry** | **long?**| An expiration time for the old environment SDK key, expressed as a Unix epoch time in milliseconds. By default, the key will expire immediately. | [optional] 

### Return type

[**Environment**](Environment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

