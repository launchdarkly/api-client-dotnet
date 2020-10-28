# LaunchDarkly.Api.Api.IntegrationsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteIntegrationSubscription**](IntegrationsApi.md#deleteintegrationsubscription) | **DELETE** /integrations/{integrationKey}/{integrationId} | Delete an integration subscription by ID.
[**GetIntegrationSubscription**](IntegrationsApi.md#getintegrationsubscription) | **GET** /integrations/{integrationKey}/{integrationId} | Get a single integration subscription by ID.
[**GetIntegrationSubscriptions**](IntegrationsApi.md#getintegrationsubscriptions) | **GET** /integrations/{integrationKey} | Get a list of all configured integrations of a given kind.
[**GetIntegrations**](IntegrationsApi.md#getintegrations) | **GET** /integrations | Get a list of all configured audit log event integrations associated with this account.
[**PatchIntegrationSubscription**](IntegrationsApi.md#patchintegrationsubscription) | **PATCH** /integrations/{integrationKey}/{integrationId} | Modify an integration subscription by ID.
[**PostIntegrationSubscription**](IntegrationsApi.md#postintegrationsubscription) | **POST** /integrations/{integrationKey} | Create a new integration subscription of a given kind.


<a name="deleteintegrationsubscription"></a>
# **DeleteIntegrationSubscription**
> void DeleteIntegrationSubscription (string integrationKey, string integrationId)

Delete an integration subscription by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class DeleteIntegrationSubscriptionExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi();
            var integrationKey = integrationKey_example;  // string | The key used to specify the integration kind.
            var integrationId = integrationId_example;  // string | The integration ID.

            try
            {
                // Delete an integration subscription by ID.
                apiInstance.DeleteIntegrationSubscription(integrationKey, integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteIntegrationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationKey** | **string**| The key used to specify the integration kind. | 
 **integrationId** | **string**| The integration ID. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationsubscription"></a>
# **GetIntegrationSubscription**
> IntegrationSubscription GetIntegrationSubscription (string integrationKey, string integrationId)

Get a single integration subscription by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetIntegrationSubscriptionExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi();
            var integrationKey = integrationKey_example;  // string | The key used to specify the integration kind.
            var integrationId = integrationId_example;  // string | The integration ID.

            try
            {
                // Get a single integration subscription by ID.
                IntegrationSubscription result = apiInstance.GetIntegrationSubscription(integrationKey, integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationKey** | **string**| The key used to specify the integration kind. | 
 **integrationId** | **string**| The integration ID. | 

### Return type

[**IntegrationSubscription**](IntegrationSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrationsubscriptions"></a>
# **GetIntegrationSubscriptions**
> Integration GetIntegrationSubscriptions (string integrationKey)

Get a list of all configured integrations of a given kind.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetIntegrationSubscriptionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi();
            var integrationKey = integrationKey_example;  // string | The key used to specify the integration kind.

            try
            {
                // Get a list of all configured integrations of a given kind.
                Integration result = apiInstance.GetIntegrationSubscriptions(integrationKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrationSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationKey** | **string**| The key used to specify the integration kind. | 

### Return type

[**Integration**](Integration.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintegrations"></a>
# **GetIntegrations**
> Integrations GetIntegrations ()

Get a list of all configured audit log event integrations associated with this account.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetIntegrationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi();

            try
            {
                // Get a list of all configured audit log event integrations associated with this account.
                Integrations result = apiInstance.GetIntegrations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetIntegrations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Integrations**](Integrations.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchintegrationsubscription"></a>
# **PatchIntegrationSubscription**
> IntegrationSubscription PatchIntegrationSubscription (string integrationKey, string integrationId, List<PatchOperation> patchDelta)

Modify an integration subscription by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PatchIntegrationSubscriptionExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi();
            var integrationKey = integrationKey_example;  // string | The key used to specify the integration kind.
            var integrationId = integrationId_example;  // string | The integration ID.
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify an integration subscription by ID.
                IntegrationSubscription result = apiInstance.PatchIntegrationSubscription(integrationKey, integrationId, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchIntegrationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationKey** | **string**| The key used to specify the integration kind. | 
 **integrationId** | **string**| The integration ID. | 
 **patchDelta** | [**List<PatchOperation>**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**IntegrationSubscription**](IntegrationSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postintegrationsubscription"></a>
# **PostIntegrationSubscription**
> IntegrationSubscription PostIntegrationSubscription (string integrationKey, SubscriptionBody subscriptionBody)

Create a new integration subscription of a given kind.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostIntegrationSubscriptionExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi();
            var integrationKey = integrationKey_example;  // string | The key used to specify the integration kind.
            var subscriptionBody = new SubscriptionBody(); // SubscriptionBody | Create a new integration subscription.

            try
            {
                // Create a new integration subscription of a given kind.
                IntegrationSubscription result = apiInstance.PostIntegrationSubscription(integrationKey, subscriptionBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PostIntegrationSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationKey** | **string**| The key used to specify the integration kind. | 
 **subscriptionBody** | [**SubscriptionBody**](SubscriptionBody.md)| Create a new integration subscription. | 

### Return type

[**IntegrationSubscription**](IntegrationSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

