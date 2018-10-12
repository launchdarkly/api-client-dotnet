# LaunchDarkly.Api.Api.AuditLogApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAuditLogEntries**](AuditLogApi.md#getauditlogentries) | **GET** /auditlog | Get a list of all audit log entries. The query parameters allow you to restrict the returned results by date ranges, resource specifiers, or a full-text search query.
[**GetAuditLogEntry**](AuditLogApi.md#getauditlogentry) | **GET** /auditlog/{resourceId} | Use this endpoint to fetch a single audit log entry by its resouce ID.


<a name="getauditlogentries"></a>
# **GetAuditLogEntries**
> AuditLogEntries GetAuditLogEntries (decimal? before, decimal? after, string q, decimal? limit, string spec)

Get a list of all audit log entries. The query parameters allow you to restrict the returned results by date ranges, resource specifiers, or a full-text search query.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetAuditLogEntriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AuditLogApi();
            var before = 8.14;  // decimal? | A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have before this timestamp. (optional) 
            var after = 8.14;  // decimal? | A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have occured after this timestamp. (optional) 
            var q = q_example;  // string | Text to search for. You can search for the full or partial name of the resource involved or fullpartial email address of the member who made the change. (optional) 
            var limit = 8.14;  // decimal? | A limit on the number of audit log entries to be returned, between 1 and 20. (optional) 
            var spec = spec_example;  // string | A resource specifier, allowing you to filter audit log listings by resource. (optional) 

            try
            {
                // Get a list of all audit log entries. The query parameters allow you to restrict the returned results by date ranges, resource specifiers, or a full-text search query.
                AuditLogEntries result = apiInstance.GetAuditLogEntries(before, after, q, limit, spec);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogApi.GetAuditLogEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **before** | **decimal?**| A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have before this timestamp. | [optional] 
 **after** | **decimal?**| A timestamp filter, expressed as a Unix epoch time in milliseconds. All entries returned will have occured after this timestamp. | [optional] 
 **q** | **string**| Text to search for. You can search for the full or partial name of the resource involved or fullpartial email address of the member who made the change. | [optional] 
 **limit** | **decimal?**| A limit on the number of audit log entries to be returned, between 1 and 20. | [optional] 
 **spec** | **string**| A resource specifier, allowing you to filter audit log listings by resource. | [optional] 

### Return type

[**AuditLogEntries**](AuditLogEntries.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauditlogentry"></a>
# **GetAuditLogEntry**
> AuditLogEntry GetAuditLogEntry (string resourceId)

Use this endpoint to fetch a single audit log entry by its resouce ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetAuditLogEntryExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AuditLogApi();
            var resourceId = resourceId_example;  // string | The resource ID.

            try
            {
                // Use this endpoint to fetch a single audit log entry by its resouce ID.
                AuditLogEntry result = apiInstance.GetAuditLogEntry(resourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditLogApi.GetAuditLogEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| The resource ID. | 

### Return type

[**AuditLogEntry**](AuditLogEntry.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

