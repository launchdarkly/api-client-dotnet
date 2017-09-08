# IO.Swagger - the C# library for the LaunchDarkly REST API

Build custom integrations with the LaunchDarkly REST API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build date: 2017-09-08T16:05:48.570-07:00
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen
    For more information, please visit [https://support.launchdarkly.com](https://support.launchdarkly.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.IO.Swagger.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AuditLogApi();

            try
            {
                // Fetch a list of all webhooks
                AuditLogEntries result = apiInstance.GetAuditLogEntries();
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuditLogApi* | [**GetAuditLogEntries**](docs/AuditLogApi.md#getauditlogentries) | **GET** /auditlog | Fetch a list of all webhooks
*AuditLogApi* | [**GetAuditLogEntry**](docs/AuditLogApi.md#getauditlogentry) | **GET** /auditlog/{resourceId} | Get a webhook by ID
*EnvironmentsApi* | [**DeleteEnvironment**](docs/EnvironmentsApi.md#deleteenvironment) | **DELETE** /environments/{projectKey}/{environmentKey} | Delete an environment by ID
*EnvironmentsApi* | [**GetEnvironment**](docs/EnvironmentsApi.md#getenvironment) | **GET** /environments/{projectKey}/{environmentKey} | Get an environment by key.
*EnvironmentsApi* | [**PatchEnvironment**](docs/EnvironmentsApi.md#patchenvironment) | **PATCH** /environments/{projectKey}/{environmentKey} | Modify an environment by ID
*EnvironmentsApi* | [**PostEnvironment**](docs/EnvironmentsApi.md#postenvironment) | **POST** /environments/{projectKey} | Create an environment
*FlagsApi* | [**DeleteFeatureFlag**](docs/FlagsApi.md#deletefeatureflag) | **DELETE** /flags/{projectKey}/{featureFlagKey} | Delete a feature flag by ID
*FlagsApi* | [**GetFeatureFlag**](docs/FlagsApi.md#getfeatureflag) | **GET** /flags/{projectKey}/{featureFlagKey} | Get a single feature flag by key.
*FlagsApi* | [**GetFeatureFlagStatus**](docs/FlagsApi.md#getfeatureflagstatus) | **GET** /flag-statuses/{projectKey}/{environmentKey} | Get a list of statuses for all feature flags
*FlagsApi* | [**GetFeatureFlagStatuses**](docs/FlagsApi.md#getfeatureflagstatuses) | **GET** /flag-statuses/{projectKey}/{environmentKey}/{featureFlagKey} | Get a list of statuses for all feature flags
*FlagsApi* | [**GetFeatureFlags**](docs/FlagsApi.md#getfeatureflags) | **GET** /flags/{projectKey} | Get a list of all features in the given project.
*FlagsApi* | [**PatchFeatureFlag**](docs/FlagsApi.md#patchfeatureflag) | **PATCH** /flags/{projectKey}/{featureFlagKey} | Modify a feature flag by ID
*FlagsApi* | [**PostFeatureFlag**](docs/FlagsApi.md#postfeatureflag) | **POST** /flags/{projectKey}/{featureFlagKey} | Create a feature flag
*ProjectsApi* | [**DeleteProject**](docs/ProjectsApi.md#deleteproject) | **DELETE** /projects/{projectKey} | Delete a project by ID
*ProjectsApi* | [**GetProject**](docs/ProjectsApi.md#getproject) | **GET** /projects/{projectKey} | Get a project by key.
*ProjectsApi* | [**GetProjects**](docs/ProjectsApi.md#getprojects) | **GET** /projects | Returns a list of all projects in the account.
*ProjectsApi* | [**PatchProject**](docs/ProjectsApi.md#patchproject) | **PATCH** /projects/{projectKey} | Modify a project by ID
*ProjectsApi* | [**PostProject**](docs/ProjectsApi.md#postproject) | **POST** /projects | Create a project
*RootApi* | [**GetRoot**](docs/RootApi.md#getroot) | **GET** / | Get the root resource
*UserSettingsApi* | [**GetUserFlagSetting**](docs/UserSettingsApi.md#getuserflagsetting) | **GET** /users/{projectKey}/{environmentKey}/{userKey}/flags/{featureFlagKey} | Get a user by key.
*UserSettingsApi* | [**GetUserFlagSettings**](docs/UserSettingsApi.md#getuserflagsettings) | **GET** /users/{projectKey}/{environmentKey}/{userKey}/flags | Lists the current flag settings for a given user.
*UserSettingsApi* | [**PutFlagSetting**](docs/UserSettingsApi.md#putflagsetting) | **PUT** /users/{projectKey}/{environmentKey}/{userKey}/flags/{featureFlagKey} | Specifically enable or disable a feature flag for a user based on their key.
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{projectKey}/{environmentKey}/{userKey} | Delete a user by ID
*UsersApi* | [**GetSearchUsers**](docs/UsersApi.md#getsearchusers) | **GET** /user-search/{projectKey}/{environmentKey} | Search users in LaunchDarkly based on their last active date, or a search query.
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{projectKey}/{environmentKey}/{userKey} | Get a user by key.
*UsersApi* | [**GetUsers**](docs/UsersApi.md#getusers) | **GET** /users/{projectKey}/{environmentKey} | List all users in the environment.
*WebhooksApi* | [**DeleteWebhook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{resourceId} | Delete a webhook by ID
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{resourceId} | Get a webhook by ID
*WebhooksApi* | [**GetWebhooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhooks | Fetch a list of all webhooks
*WebhooksApi* | [**PatchWebhook**](docs/WebhooksApi.md#patchwebhook) | **PATCH** /webhooks/{resourceId} | Modify a webhook by ID
*WebhooksApi* | [**PostWebhook**](docs/WebhooksApi.md#postwebhook) | **POST** /webhooks | Create a webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.AuditLogEntries](docs/AuditLogEntries.md)
 - [IO.Swagger.Model.AuditLogEntry](docs/AuditLogEntry.md)
 - [IO.Swagger.Model.AuditLogEntryTarget](docs/AuditLogEntryTarget.md)
 - [IO.Swagger.Model.Clause](docs/Clause.md)
 - [IO.Swagger.Model.Environment](docs/Environment.md)
 - [IO.Swagger.Model.EnvironmentBody](docs/EnvironmentBody.md)
 - [IO.Swagger.Model.FeatureFlag](docs/FeatureFlag.md)
 - [IO.Swagger.Model.FeatureFlagBody](docs/FeatureFlagBody.md)
 - [IO.Swagger.Model.FeatureFlagConfig](docs/FeatureFlagConfig.md)
 - [IO.Swagger.Model.FeatureFlagConfigFallthrough](docs/FeatureFlagConfigFallthrough.md)
 - [IO.Swagger.Model.FeatureFlagStatus](docs/FeatureFlagStatus.md)
 - [IO.Swagger.Model.FeatureFlagStatuses](docs/FeatureFlagStatuses.md)
 - [IO.Swagger.Model.FeatureFlags](docs/FeatureFlags.md)
 - [IO.Swagger.Model.Link](docs/Link.md)
 - [IO.Swagger.Model.Links](docs/Links.md)
 - [IO.Swagger.Model.Member](docs/Member.md)
 - [IO.Swagger.Model.PatchDelta](docs/PatchDelta.md)
 - [IO.Swagger.Model.Project](docs/Project.md)
 - [IO.Swagger.Model.ProjectBody](docs/ProjectBody.md)
 - [IO.Swagger.Model.Projects](docs/Projects.md)
 - [IO.Swagger.Model.Rollout](docs/Rollout.md)
 - [IO.Swagger.Model.Rule](docs/Rule.md)
 - [IO.Swagger.Model.Target](docs/Target.md)
 - [IO.Swagger.Model.User](docs/User.md)
 - [IO.Swagger.Model.UserFlagSetting](docs/UserFlagSetting.md)
 - [IO.Swagger.Model.UserFlagSettings](docs/UserFlagSettings.md)
 - [IO.Swagger.Model.UserSettingsBody](docs/UserSettingsBody.md)
 - [IO.Swagger.Model.Users](docs/Users.md)
 - [IO.Swagger.Model.Variation](docs/Variation.md)
 - [IO.Swagger.Model.Webhook](docs/Webhook.md)
 - [IO.Swagger.Model.WebhookBody](docs/WebhookBody.md)
 - [IO.Swagger.Model.Webhooks](docs/Webhooks.md)
 - [IO.Swagger.Model.WeightedVariation](docs/WeightedVariation.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Token"></a>
### Token

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

