# IO.Swagger..EnvironmentsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEnvironment**](EnvironmentsApi.md#deleteenvironment) | **DELETE** /environments/{projectKey}/{environmentKey} | Delete an environment by ID
[**GetEnvironment**](EnvironmentsApi.md#getenvironment) | **GET** /environments/{projectKey}/{environmentKey} | Get an environment given a project and key.
[**PatchEnvironment**](EnvironmentsApi.md#patchenvironment) | **PATCH** /environments/{projectKey}/{environmentKey} | Modify an environment by ID
[**PostEnvironment**](EnvironmentsApi.md#postenvironment) | **POST** /environments/{projectKey} | Create a new environment in a specified project with a given name, key, and swatch color.


<a name="deleteenvironment"></a>
# **DeleteEnvironment**
> void DeleteEnvironment (string projectKey, string environmentKey)

Delete an environment by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var environmentKey = environmentKey_example;  // string | The environment key

            try
            {
                // Delete an environment by ID
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
 **environmentKey** | **string**| The environment key | 

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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var environmentKey = environmentKey_example;  // string | The environment key

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
 **environmentKey** | **string**| The environment key | 

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
> void PatchEnvironment (string projectKey, string environmentKey, List<PatchDelta> patchDelta)

Modify an environment by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var environmentKey = environmentKey_example;  // string | The environment key
            var patchDelta = new List<PatchDelta>(); // List<PatchDelta> | http://jsonpatch.com/

            try
            {
                // Modify an environment by ID
                apiInstance.PatchEnvironment(projectKey, environmentKey, patchDelta);
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
 **environmentKey** | **string**| The environment key | 
 **patchDelta** | [**List<PatchDelta>**](PatchDelta.md)| http://jsonpatch.com/ | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postenvironment"></a>
# **PostEnvironment**
> void PostEnvironment (string projectKey, EnvironmentBody environmentBody)

Create a new environment in a specified project with a given name, key, and swatch color.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var environmentBody = new EnvironmentBody(); // EnvironmentBody | New environment

            try
            {
                // Create a new environment in a specified project with a given name, key, and swatch color.
                apiInstance.PostEnvironment(projectKey, environmentBody);
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
 **environmentBody** | [**EnvironmentBody**](EnvironmentBody.md)| New environment | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

