# LaunchDarkly.Api.Api.CustomerMetricsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEvaluations**](CustomerMetricsApi.md#getevaluations) | **GET** /usage/evaluations/{envId}/{flagKey} | Get events usage by event id and the feature flag key.
[**GetEvent**](CustomerMetricsApi.md#getevent) | **GET** /usage/events/{type} | Get events usage by event type.
[**GetEvents**](CustomerMetricsApi.md#getevents) | **GET** /usage/events | Get events usage endpoints.
[**GetMAU**](CustomerMetricsApi.md#getmau) | **GET** /usage/mau | Get monthly active user data.
[**GetMAUByCategory**](CustomerMetricsApi.md#getmaubycategory) | **GET** /usage/mau/bycategory | Get monthly active user data by category.
[**GetStream**](CustomerMetricsApi.md#getstream) | **GET** /usage/streams/{source} | Get a stream endpoint and return timeseries data.
[**GetStreamBySDK**](CustomerMetricsApi.md#getstreambysdk) | **GET** /usage/streams/{source}/bysdkversion | Get a stream timeseries data by source show sdk version metadata.
[**GetStreamSDKVersion**](CustomerMetricsApi.md#getstreamsdkversion) | **GET** /usage/streams/{source}/sdkversions | Get a stream timeseries data by source and show all sdk version associated.
[**GetStreams**](CustomerMetricsApi.md#getstreams) | **GET** /usage/streams | Returns a list of all streams.
[**GetUsage**](CustomerMetricsApi.md#getusage) | **GET** /usage | Returns of the usage endpoints available.


<a name="getevaluations"></a>
# **GetEvaluations**
> StreamSDKVersion GetEvaluations (string envId, string flagKey)

Get events usage by event id and the feature flag key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetEvaluationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();
            var envId = envId_example;  // string | The environment id for the flag evaluations in question.
            var flagKey = flagKey_example;  // string | The key of the flag we want metrics for.

            try
            {
                // Get events usage by event id and the feature flag key.
                StreamSDKVersion result = apiInstance.GetEvaluations(envId, flagKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetEvaluations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envId** | **string**| The environment id for the flag evaluations in question. | 
 **flagKey** | **string**| The key of the flag we want metrics for. | 

### Return type

[**StreamSDKVersion**](StreamSDKVersion.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevent"></a>
# **GetEvent**
> StreamSDKVersion GetEvent (string type)

Get events usage by event type.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();
            var type = type_example;  // string | The type of event we would like to track.

            try
            {
                // Get events usage by event type.
                StreamSDKVersion result = apiInstance.GetEvent(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The type of event we would like to track. | 

### Return type

[**StreamSDKVersion**](StreamSDKVersion.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> Events GetEvents ()

Get events usage endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();

            try
            {
                // Get events usage endpoints.
                Events result = apiInstance.GetEvents();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Events**](Events.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmau"></a>
# **GetMAU**
> MAU GetMAU ()

Get monthly active user data.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetMAUExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();

            try
            {
                // Get monthly active user data.
                MAU result = apiInstance.GetMAU();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetMAU: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MAU**](MAU.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmaubycategory"></a>
# **GetMAUByCategory**
> MAUbyCategory GetMAUByCategory ()

Get monthly active user data by category.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetMAUByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();

            try
            {
                // Get monthly active user data by category.
                MAUbyCategory result = apiInstance.GetMAUByCategory();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetMAUByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MAUbyCategory**](MAUbyCategory.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstream"></a>
# **GetStream**
> Stream GetStream (string source)

Get a stream endpoint and return timeseries data.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetStreamExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();
            var source = source_example;  // string | The source of where the stream comes from.

            try
            {
                // Get a stream endpoint and return timeseries data.
                Stream result = apiInstance.GetStream(source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| The source of where the stream comes from. | 

### Return type

[**Stream**](Stream.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstreambysdk"></a>
# **GetStreamBySDK**
> StreamBySDK GetStreamBySDK (string source)

Get a stream timeseries data by source show sdk version metadata.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetStreamBySDKExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();
            var source = source_example;  // string | The source of where the stream comes from.

            try
            {
                // Get a stream timeseries data by source show sdk version metadata.
                StreamBySDK result = apiInstance.GetStreamBySDK(source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetStreamBySDK: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| The source of where the stream comes from. | 

### Return type

[**StreamBySDK**](StreamBySDK.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstreamsdkversion"></a>
# **GetStreamSDKVersion**
> StreamSDKVersion GetStreamSDKVersion (string source)

Get a stream timeseries data by source and show all sdk version associated.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetStreamSDKVersionExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();
            var source = source_example;  // string | The source of where the stream comes from.

            try
            {
                // Get a stream timeseries data by source and show all sdk version associated.
                StreamSDKVersion result = apiInstance.GetStreamSDKVersion(source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetStreamSDKVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| The source of where the stream comes from. | 

### Return type

[**StreamSDKVersion**](StreamSDKVersion.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstreams"></a>
# **GetStreams**
> Streams GetStreams ()

Returns a list of all streams.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetStreamsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();

            try
            {
                // Returns a list of all streams.
                Streams result = apiInstance.GetStreams();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Streams**](Streams.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusage"></a>
# **GetUsage**
> Usage GetUsage ()

Returns of the usage endpoints available.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetUsageExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CustomerMetricsApi();

            try
            {
                // Returns of the usage endpoints available.
                Usage result = apiInstance.GetUsage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerMetricsApi.GetUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Usage**](Usage.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

