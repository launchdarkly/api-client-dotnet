# LaunchDarkly.Api.Api.RelayProxyConfigurationsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRelayProxyConfig**](RelayProxyConfigurationsApi.md#deleterelayproxyconfig) | **DELETE** /account/relay-auto-configs/{id} | Delete a relay proxy configuration by ID.
[**GetRelayProxyConfig**](RelayProxyConfigurationsApi.md#getrelayproxyconfig) | **GET** /account/relay-auto-configs/{id} | Get a single relay proxy configuration by ID.
[**GetRelayProxyConfigs**](RelayProxyConfigurationsApi.md#getrelayproxyconfigs) | **GET** /account/relay-auto-configs | Returns a list of relay proxy configurations in the account.
[**PatchRelayProxyConfig**](RelayProxyConfigurationsApi.md#patchrelayproxyconfig) | **PATCH** /account/relay-auto-configs/{id} | Modify a relay proxy configuration by ID.
[**PostRelayAutoConfig**](RelayProxyConfigurationsApi.md#postrelayautoconfig) | **POST** /account/relay-auto-configs | Create a new relay proxy config.
[**ResetRelayProxyConfig**](RelayProxyConfigurationsApi.md#resetrelayproxyconfig) | **POST** /account/relay-auto-configs/{id}/reset | Reset a relay proxy configuration&#39;s secret key with an optional expiry time for the old key.


<a name="deleterelayproxyconfig"></a>
# **DeleteRelayProxyConfig**
> void DeleteRelayProxyConfig (string id)

Delete a relay proxy configuration by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class DeleteRelayProxyConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RelayProxyConfigurationsApi();
            var id = id_example;  // string | The relay proxy configuration ID

            try
            {
                // Delete a relay proxy configuration by ID.
                apiInstance.DeleteRelayProxyConfig(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelayProxyConfigurationsApi.DeleteRelayProxyConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The relay proxy configuration ID | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelayproxyconfig"></a>
# **GetRelayProxyConfig**
> RelayProxyConfig GetRelayProxyConfig (string id)

Get a single relay proxy configuration by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetRelayProxyConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RelayProxyConfigurationsApi();
            var id = id_example;  // string | The relay proxy configuration ID

            try
            {
                // Get a single relay proxy configuration by ID.
                RelayProxyConfig result = apiInstance.GetRelayProxyConfig(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelayProxyConfigurationsApi.GetRelayProxyConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The relay proxy configuration ID | 

### Return type

[**RelayProxyConfig**](RelayProxyConfig.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelayproxyconfigs"></a>
# **GetRelayProxyConfigs**
> RelayProxyConfigs GetRelayProxyConfigs ()

Returns a list of relay proxy configurations in the account.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetRelayProxyConfigsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RelayProxyConfigurationsApi();

            try
            {
                // Returns a list of relay proxy configurations in the account.
                RelayProxyConfigs result = apiInstance.GetRelayProxyConfigs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelayProxyConfigurationsApi.GetRelayProxyConfigs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RelayProxyConfigs**](RelayProxyConfigs.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchrelayproxyconfig"></a>
# **PatchRelayProxyConfig**
> RelayProxyConfig PatchRelayProxyConfig (string id, List<PatchOperation> patchDelta)

Modify a relay proxy configuration by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PatchRelayProxyConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RelayProxyConfigurationsApi();
            var id = id_example;  // string | The relay proxy configuration ID
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify a relay proxy configuration by ID.
                RelayProxyConfig result = apiInstance.PatchRelayProxyConfig(id, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelayProxyConfigurationsApi.PatchRelayProxyConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The relay proxy configuration ID | 
 **patchDelta** | [**List<PatchOperation>**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**RelayProxyConfig**](RelayProxyConfig.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrelayautoconfig"></a>
# **PostRelayAutoConfig**
> RelayProxyConfig PostRelayAutoConfig (RelayProxyConfigBody relayProxyConfigBody)

Create a new relay proxy config.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostRelayAutoConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RelayProxyConfigurationsApi();
            var relayProxyConfigBody = new RelayProxyConfigBody(); // RelayProxyConfigBody | Create a new relay proxy configuration

            try
            {
                // Create a new relay proxy config.
                RelayProxyConfig result = apiInstance.PostRelayAutoConfig(relayProxyConfigBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelayProxyConfigurationsApi.PostRelayAutoConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **relayProxyConfigBody** | [**RelayProxyConfigBody**](RelayProxyConfigBody.md)| Create a new relay proxy configuration | 

### Return type

[**RelayProxyConfig**](RelayProxyConfig.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetrelayproxyconfig"></a>
# **ResetRelayProxyConfig**
> RelayProxyConfig ResetRelayProxyConfig (string id, long? expiry)

Reset a relay proxy configuration's secret key with an optional expiry time for the old key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class ResetRelayProxyConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RelayProxyConfigurationsApi();
            var id = id_example;  // string | The relay proxy configuration ID
            var expiry = 789;  // long? | An expiration time for the old relay proxy configuration key, expressed as a Unix epoch time in milliseconds. By default, the relay proxy configuration will expire immediately (optional) 

            try
            {
                // Reset a relay proxy configuration's secret key with an optional expiry time for the old key.
                RelayProxyConfig result = apiInstance.ResetRelayProxyConfig(id, expiry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelayProxyConfigurationsApi.ResetRelayProxyConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The relay proxy configuration ID | 
 **expiry** | **long?**| An expiration time for the old relay proxy configuration key, expressed as a Unix epoch time in milliseconds. By default, the relay proxy configuration will expire immediately | [optional] 

### Return type

[**RelayProxyConfig**](RelayProxyConfig.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

