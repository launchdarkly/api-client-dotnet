This repository contains a client library for LaunchDarkly's REST API. This client was automatically
generated from our [OpenAPI specification](https://github.com/launchdarkly/ld-openapi).

This REST API is for custom integrations, data export, or automating your feature flag workflows. *DO NOT* use this client library to include feature flags in your web or mobile application. To integrate feature flags with your application, please see the [SDK documentation](https://docs.launchdarkly.com/v2.0/docs)

# LaunchDarkly.Api - the C# library for the LaunchDarkly REST API

Build custom integrations with the LaunchDarkly REST API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 5.0.1
- SDK version: 1.0.0
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
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

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

            var apiInstance = new AccessTokensApi();
            var tokenId = tokenId_example;  // string | The access token ID.

            try
            {
                // Delete an access token by ID.
                apiInstance.DeleteToken(tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.DeleteToken: " + e.Message );
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
*AccessTokensApi* | [**DeleteToken**](docs/AccessTokensApi.md#deletetoken) | **DELETE** /tokens/{tokenId} | Delete an access token by ID.
*AccessTokensApi* | [**GetToken**](docs/AccessTokensApi.md#gettoken) | **GET** /tokens/{tokenId} | Get a single access token by ID.
*AccessTokensApi* | [**GetTokens**](docs/AccessTokensApi.md#gettokens) | **GET** /tokens | Returns a list of tokens in the account.
*AccessTokensApi* | [**PatchToken**](docs/AccessTokensApi.md#patchtoken) | **PATCH** /tokens/{tokenId} | Modify an access token by ID.
*AccessTokensApi* | [**PostToken**](docs/AccessTokensApi.md#posttoken) | **POST** /tokens | Create a new token.
*AccessTokensApi* | [**ResetToken**](docs/AccessTokensApi.md#resettoken) | **POST** /tokens/{tokenId}/reset | Reset an access token's secret key with an optional expiry time for the old key.
*AuditLogApi* | [**GetAuditLogEntries**](docs/AuditLogApi.md#getauditlogentries) | **GET** /auditlog | Get a list of all audit log entries. The query parameters allow you to restrict the returned results by date ranges, resource specifiers, or a full-text search query.
*AuditLogApi* | [**GetAuditLogEntry**](docs/AuditLogApi.md#getauditlogentry) | **GET** /auditlog/{resourceId} | Use this endpoint to fetch a single audit log entry by its resouce ID.
*CustomRolesApi* | [**DeleteCustomRole**](docs/CustomRolesApi.md#deletecustomrole) | **DELETE** /roles/{customRoleKey} | Delete a custom role by key.
*CustomRolesApi* | [**GetCustomRole**](docs/CustomRolesApi.md#getcustomrole) | **GET** /roles/{customRoleKey} | Get one custom role by key.
*CustomRolesApi* | [**GetCustomRoles**](docs/CustomRolesApi.md#getcustomroles) | **GET** /roles | Return a complete list of custom roles.
*CustomRolesApi* | [**PatchCustomRole**](docs/CustomRolesApi.md#patchcustomrole) | **PATCH** /roles/{customRoleKey} | Modify a custom role by key.
*CustomRolesApi* | [**PostCustomRole**](docs/CustomRolesApi.md#postcustomrole) | **POST** /roles | Create a new custom role.
*CustomerMetricsApi* | [**GetEvaluations**](docs/CustomerMetricsApi.md#getevaluations) | **GET** /usage/evaluations/{envId}/{flagKey} | Get events usage by event id and the feature flag key.
*CustomerMetricsApi* | [**GetEvent**](docs/CustomerMetricsApi.md#getevent) | **GET** /usage/events/{type} | Get events usage by event type.
*CustomerMetricsApi* | [**GetEvents**](docs/CustomerMetricsApi.md#getevents) | **GET** /usage/events | Get events usage endpoints.
*CustomerMetricsApi* | [**GetMAU**](docs/CustomerMetricsApi.md#getmau) | **GET** /usage/mau | Get monthly active user data.
*CustomerMetricsApi* | [**GetMAUByCategory**](docs/CustomerMetricsApi.md#getmaubycategory) | **GET** /usage/mau/bycategory | Get monthly active user data by category.
*CustomerMetricsApi* | [**GetStream**](docs/CustomerMetricsApi.md#getstream) | **GET** /usage/streams/{source} | Get a stream endpoint and return timeseries data.
*CustomerMetricsApi* | [**GetStreamBySDK**](docs/CustomerMetricsApi.md#getstreambysdk) | **GET** /usage/streams/{source}/bysdkversion | Get a stream timeseries data by source show sdk version metadata.
*CustomerMetricsApi* | [**GetStreamSDKVersion**](docs/CustomerMetricsApi.md#getstreamsdkversion) | **GET** /usage/streams/{source}/sdkversions | Get a stream timeseries data by source and show all sdk version associated.
*CustomerMetricsApi* | [**GetStreams**](docs/CustomerMetricsApi.md#getstreams) | **GET** /usage/streams | Returns a list of all streams.
*CustomerMetricsApi* | [**GetUsage**](docs/CustomerMetricsApi.md#getusage) | **GET** /usage | Returns of the usage endpoints available.
*DataExportDestinationsApi* | [**DeleteDestination**](docs/DataExportDestinationsApi.md#deletedestination) | **DELETE** /destinations/{projectKey}/{environmentKey}/{destinationId} | Get a single data export destination by ID
*DataExportDestinationsApi* | [**GetDestination**](docs/DataExportDestinationsApi.md#getdestination) | **GET** /destinations/{projectKey}/{environmentKey}/{destinationId} | Get a single data export destination by ID
*DataExportDestinationsApi* | [**GetDestinations**](docs/DataExportDestinationsApi.md#getdestinations) | **GET** /destinations | Returns a list of all data export destinations.
*DataExportDestinationsApi* | [**PatchDestination**](docs/DataExportDestinationsApi.md#patchdestination) | **PATCH** /destinations/{projectKey}/{environmentKey}/{destinationId} | Perform a partial update to a data export destination.
*DataExportDestinationsApi* | [**PostDestination**](docs/DataExportDestinationsApi.md#postdestination) | **POST** /destinations/{projectKey}/{environmentKey} | Create a new data export destination
*EnvironmentsApi* | [**DeleteEnvironment**](docs/EnvironmentsApi.md#deleteenvironment) | **DELETE** /projects/{projectKey}/environments/{environmentKey} | Delete an environment in a specific project.
*EnvironmentsApi* | [**GetEnvironment**](docs/EnvironmentsApi.md#getenvironment) | **GET** /projects/{projectKey}/environments/{environmentKey} | Get an environment given a project and key.
*EnvironmentsApi* | [**PatchEnvironment**](docs/EnvironmentsApi.md#patchenvironment) | **PATCH** /projects/{projectKey}/environments/{environmentKey} | Modify an environment by ID.
*EnvironmentsApi* | [**PostEnvironment**](docs/EnvironmentsApi.md#postenvironment) | **POST** /projects/{projectKey}/environments | Create a new environment in a specified project with a given name, key, and swatch color.
*EnvironmentsApi* | [**ResetEnvironmentMobileKey**](docs/EnvironmentsApi.md#resetenvironmentmobilekey) | **POST** /projects/{projectKey}/environments/{environmentKey}/mobileKey | Reset an environment's mobile key. The optional expiry for the old key is deprecated for this endpoint, so the old key will always expire immediately.
*EnvironmentsApi* | [**ResetEnvironmentSDKKey**](docs/EnvironmentsApi.md#resetenvironmentsdkkey) | **POST** /projects/{projectKey}/environments/{environmentKey}/apiKey | Reset an environment's SDK key with an optional expiry time for the old key.
*FeatureFlagsApi* | [**CopyFeatureFlag**](docs/FeatureFlagsApi.md#copyfeatureflag) | **POST** /flags/{projectKey}/{featureFlagKey}/copy | Copies the feature flag configuration from one environment to the same feature flag in another environment.
*FeatureFlagsApi* | [**DeleteApprovalRequest**](docs/FeatureFlagsApi.md#deleteapprovalrequest) | **DELETE** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId} | Delete an approval request for a feature flag config
*FeatureFlagsApi* | [**DeleteFeatureFlag**](docs/FeatureFlagsApi.md#deletefeatureflag) | **DELETE** /flags/{projectKey}/{featureFlagKey} | Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.
*FeatureFlagsApi* | [**DeleteFlagConfigScheduledChanges**](docs/FeatureFlagsApi.md#deleteflagconfigscheduledchanges) | **DELETE** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes/{scheduledChangeId} | Delete a scheduled change on a feature flag in an environment.
*FeatureFlagsApi* | [**GetApprovalRequest**](docs/FeatureFlagsApi.md#getapprovalrequest) | **GET** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId} | Get a single approval request for a feature flag config
*FeatureFlagsApi* | [**GetApprovalRequests**](docs/FeatureFlagsApi.md#getapprovalrequests) | **GET** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests | Get all approval requests for a feature flag config
*FeatureFlagsApi* | [**GetExpiringUserTargets**](docs/FeatureFlagsApi.md#getexpiringusertargets) | **GET** /flags/{projectKey}/{featureFlagKey}/expiring-user-targets/{environmentKey} | Get expiring user targets for feature flag
*FeatureFlagsApi* | [**GetFeatureFlag**](docs/FeatureFlagsApi.md#getfeatureflag) | **GET** /flags/{projectKey}/{featureFlagKey} | Get a single feature flag by key.
*FeatureFlagsApi* | [**GetFeatureFlagStatus**](docs/FeatureFlagsApi.md#getfeatureflagstatus) | **GET** /flag-statuses/{projectKey}/{environmentKey}/{featureFlagKey} | Get the status for a particular feature flag.
*FeatureFlagsApi* | [**GetFeatureFlagStatusAcrossEnvironments**](docs/FeatureFlagsApi.md#getfeatureflagstatusacrossenvironments) | **GET** /flag-status/{projectKey}/{featureFlagKey} | Get the status for a particular feature flag across environments
*FeatureFlagsApi* | [**GetFeatureFlagStatuses**](docs/FeatureFlagsApi.md#getfeatureflagstatuses) | **GET** /flag-statuses/{projectKey}/{environmentKey} | Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.
*FeatureFlagsApi* | [**GetFeatureFlags**](docs/FeatureFlagsApi.md#getfeatureflags) | **GET** /flags/{projectKey} | Get a list of all features in the given project.
*FeatureFlagsApi* | [**GetFlagConfigScheduledChange**](docs/FeatureFlagsApi.md#getflagconfigscheduledchange) | **GET** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes/{scheduledChangeId} | Get a scheduled change on a feature flag by id.
*FeatureFlagsApi* | [**GetFlagConfigScheduledChanges**](docs/FeatureFlagsApi.md#getflagconfigscheduledchanges) | **GET** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes | Get all scheduled workflows for a feature flag by key.
*FeatureFlagsApi* | [**GetFlagConfigScheduledChangesConflicts**](docs/FeatureFlagsApi.md#getflagconfigscheduledchangesconflicts) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes-conflicts | Lists conflicts between the given instructions and any existing scheduled changes for the feature flag. The actual HTTP verb should be REPORT, not POST.
*FeatureFlagsApi* | [**PatchExpiringUserTargets**](docs/FeatureFlagsApi.md#patchexpiringusertargets) | **PATCH** /flags/{projectKey}/{featureFlagKey}/expiring-user-targets/{environmentKey} | Update, add, or delete expiring user targets on feature flag
*FeatureFlagsApi* | [**PatchFeatureFlag**](docs/FeatureFlagsApi.md#patchfeatureflag) | **PATCH** /flags/{projectKey}/{featureFlagKey} | Perform a partial update to a feature.
*FeatureFlagsApi* | [**PatchFlagConfigScheduledChange**](docs/FeatureFlagsApi.md#patchflagconfigscheduledchange) | **PATCH** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes/{scheduledChangeId} | Updates an existing scheduled-change on a feature flag in an environment.
*FeatureFlagsApi* | [**PostApplyApprovalRequest**](docs/FeatureFlagsApi.md#postapplyapprovalrequest) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}/apply | Apply approval request for a feature flag config
*FeatureFlagsApi* | [**PostApprovalRequest**](docs/FeatureFlagsApi.md#postapprovalrequest) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId} | Create an approval request for a feature flag config
*FeatureFlagsApi* | [**PostFeatureFlag**](docs/FeatureFlagsApi.md#postfeatureflag) | **POST** /flags/{projectKey} | Creates a new feature flag.
*FeatureFlagsApi* | [**PostFlagConfigScheduledChanges**](docs/FeatureFlagsApi.md#postflagconfigscheduledchanges) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/scheduled-changes | Creates a new scheduled change for a feature flag.
*FeatureFlagsApi* | [**PostReviewApprovalRequest**](docs/FeatureFlagsApi.md#postreviewapprovalrequest) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{approvalRequestId}/review | Review approval request for a feature flag config
*IntegrationsApi* | [**DeleteIntegrationSubscription**](docs/IntegrationsApi.md#deleteintegrationsubscription) | **DELETE** /integrations/{integrationKey}/{integrationId} | Delete an integration subscription by ID.
*IntegrationsApi* | [**GetIntegrationSubscription**](docs/IntegrationsApi.md#getintegrationsubscription) | **GET** /integrations/{integrationKey}/{integrationId} | Get a single integration subscription by ID.
*IntegrationsApi* | [**GetIntegrationSubscriptions**](docs/IntegrationsApi.md#getintegrationsubscriptions) | **GET** /integrations/{integrationKey} | Get a list of all configured integrations of a given kind.
*IntegrationsApi* | [**GetIntegrations**](docs/IntegrationsApi.md#getintegrations) | **GET** /integrations | Get a list of all configured audit log event integrations associated with this account.
*IntegrationsApi* | [**PatchIntegrationSubscription**](docs/IntegrationsApi.md#patchintegrationsubscription) | **PATCH** /integrations/{integrationKey}/{integrationId} | Modify an integration subscription by ID.
*IntegrationsApi* | [**PostIntegrationSubscription**](docs/IntegrationsApi.md#postintegrationsubscription) | **POST** /integrations/{integrationKey} | Create a new integration subscription of a given kind.
*ProjectsApi* | [**DeleteProject**](docs/ProjectsApi.md#deleteproject) | **DELETE** /projects/{projectKey} | Delete a project by key. Caution- - deleting a project will delete all associated environments and feature flags. You cannot delete the last project in an account.
*ProjectsApi* | [**GetProject**](docs/ProjectsApi.md#getproject) | **GET** /projects/{projectKey} | Fetch a single project by key.
*ProjectsApi* | [**GetProjects**](docs/ProjectsApi.md#getprojects) | **GET** /projects | Returns a list of all projects in the account.
*ProjectsApi* | [**PatchProject**](docs/ProjectsApi.md#patchproject) | **PATCH** /projects/{projectKey} | Modify a project by ID.
*ProjectsApi* | [**PostProject**](docs/ProjectsApi.md#postproject) | **POST** /projects | Create a new project with the given key and name.
*RelayProxyConfigurationsApi* | [**DeleteRelayProxyConfig**](docs/RelayProxyConfigurationsApi.md#deleterelayproxyconfig) | **DELETE** /account/relay-auto-configs/{id} | Delete a relay proxy configuration by ID.
*RelayProxyConfigurationsApi* | [**GetRelayProxyConfig**](docs/RelayProxyConfigurationsApi.md#getrelayproxyconfig) | **GET** /account/relay-auto-configs/{id} | Get a single relay proxy configuration by ID.
*RelayProxyConfigurationsApi* | [**GetRelayProxyConfigs**](docs/RelayProxyConfigurationsApi.md#getrelayproxyconfigs) | **GET** /account/relay-auto-configs | Returns a list of relay proxy configurations in the account.
*RelayProxyConfigurationsApi* | [**PatchRelayProxyConfig**](docs/RelayProxyConfigurationsApi.md#patchrelayproxyconfig) | **PATCH** /account/relay-auto-configs/{id} | Modify a relay proxy configuration by ID.
*RelayProxyConfigurationsApi* | [**PostRelayAutoConfig**](docs/RelayProxyConfigurationsApi.md#postrelayautoconfig) | **POST** /account/relay-auto-configs | Create a new relay proxy config.
*RelayProxyConfigurationsApi* | [**ResetRelayProxyConfig**](docs/RelayProxyConfigurationsApi.md#resetrelayproxyconfig) | **POST** /account/relay-auto-configs/{id}/reset | Reset a relay proxy configuration's secret key with an optional expiry time for the old key.
*RootApi* | [**GetRoot**](docs/RootApi.md#getroot) | **GET** / | 
*TeamMembersApi* | [**DeleteMember**](docs/TeamMembersApi.md#deletemember) | **DELETE** /members/{memberId} | Delete a team member by ID.
*TeamMembersApi* | [**GetMe**](docs/TeamMembersApi.md#getme) | **GET** /members/me | Get the current team member associated with the token
*TeamMembersApi* | [**GetMember**](docs/TeamMembersApi.md#getmember) | **GET** /members/{memberId} | Get a single team member by ID.
*TeamMembersApi* | [**GetMembers**](docs/TeamMembersApi.md#getmembers) | **GET** /members | Returns a list of all members in the account.
*TeamMembersApi* | [**PatchMember**](docs/TeamMembersApi.md#patchmember) | **PATCH** /members/{memberId} | Modify a team member by ID.
*TeamMembersApi* | [**PostMembers**](docs/TeamMembersApi.md#postmembers) | **POST** /members | Invite new members.
*UserSegmentsApi* | [**DeleteUserSegment**](docs/UserSegmentsApi.md#deleteusersegment) | **DELETE** /segments/{projectKey}/{environmentKey}/{userSegmentKey} | Delete a user segment.
*UserSegmentsApi* | [**GetExpiringUserTargetsOnSegment**](docs/UserSegmentsApi.md#getexpiringusertargetsonsegment) | **GET** /segments/{projectKey}/{userSegmentKey}/expiring-user-targets/{environmentKey} | Get expiring user targets for user segment
*UserSegmentsApi* | [**GetUserSegment**](docs/UserSegmentsApi.md#getusersegment) | **GET** /segments/{projectKey}/{environmentKey}/{userSegmentKey} | Get a single user segment by key.
*UserSegmentsApi* | [**GetUserSegments**](docs/UserSegmentsApi.md#getusersegments) | **GET** /segments/{projectKey}/{environmentKey} | Get a list of all user segments in the given project.
*UserSegmentsApi* | [**PatchExpiringUserTargetsOnSegment**](docs/UserSegmentsApi.md#patchexpiringusertargetsonsegment) | **PATCH** /segments/{projectKey}/{userSegmentKey}/expiring-user-targets/{environmentKey} | Update, add, or delete expiring user targets on user segment
*UserSegmentsApi* | [**PatchUserSegment**](docs/UserSegmentsApi.md#patchusersegment) | **PATCH** /segments/{projectKey}/{environmentKey}/{userSegmentKey} | Perform a partial update to a user segment.
*UserSegmentsApi* | [**PostUserSegment**](docs/UserSegmentsApi.md#postusersegment) | **POST** /segments/{projectKey}/{environmentKey} | Creates a new user segment.
*UserSegmentsApi* | [**UpdatedUnboundedSegmentTargets**](docs/UserSegmentsApi.md#updatedunboundedsegmenttargets) | **POST** /segments/{projectKey}/{environmentKey}/{userSegmentKey}/unbounded-users | Update targets included or excluded in an unbounded segment
*UserSettingsApi* | [**GetExpiringUserTargetsForUser**](docs/UserSettingsApi.md#getexpiringusertargetsforuser) | **GET** /users/{projectKey}/{userKey}/expiring-user-targets/{environmentKey} | Get expiring dates on flags for user
*UserSettingsApi* | [**GetUserFlagSetting**](docs/UserSettingsApi.md#getuserflagsetting) | **GET** /users/{projectKey}/{environmentKey}/{userKey}/flags/{featureFlagKey} | Fetch a single flag setting for a user by key.
*UserSettingsApi* | [**GetUserFlagSettings**](docs/UserSettingsApi.md#getuserflagsettings) | **GET** /users/{projectKey}/{environmentKey}/{userKey}/flags | Fetch a single flag setting for a user by key.
*UserSettingsApi* | [**PatchExpiringUserTargetsForFlags**](docs/UserSettingsApi.md#patchexpiringusertargetsforflags) | **PATCH** /users/{projectKey}/{userKey}/expiring-user-targets/{environmentKey} | Update, add, or delete expiring user targets for a single user on all flags
*UserSettingsApi* | [**PutFlagSetting**](docs/UserSettingsApi.md#putflagsetting) | **PUT** /users/{projectKey}/{environmentKey}/{userKey}/flags/{featureFlagKey} | Specifically enable or disable a feature flag for a user based on their key.
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{projectKey}/{environmentKey}/{userKey} | Delete a user by ID.
*UsersApi* | [**GetSearchUsers**](docs/UsersApi.md#getsearchusers) | **GET** /user-search/{projectKey}/{environmentKey} | Search users in LaunchDarkly based on their last active date, or a search query. It should not be used to enumerate all users in LaunchDarkly- - use the List users API resource.
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{projectKey}/{environmentKey}/{userKey} | Get a user by key.
*UsersApi* | [**GetUsers**](docs/UsersApi.md#getusers) | **GET** /users/{projectKey}/{environmentKey} | List all users in the environment. Includes the total count of users. In each page, there will be up to 'limit' users returned (default 20). This is useful for exporting all users in the system for further analysis. Paginated collections will include a next link containing a URL with the next set of elements in the collection.
*WebhooksApi* | [**DeleteWebhook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{resourceId} | Delete a webhook by ID.
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{resourceId} | Get a webhook by ID.
*WebhooksApi* | [**GetWebhooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhooks | Fetch a list of all webhooks.
*WebhooksApi* | [**PatchWebhook**](docs/WebhooksApi.md#patchwebhook) | **PATCH** /webhooks/{resourceId} | Modify a webhook by ID.
*WebhooksApi* | [**PostWebhook**](docs/WebhooksApi.md#postwebhook) | **POST** /webhooks | Create a webhook.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [LaunchDarkly.Api.Model.ApprovalRequest](docs/ApprovalRequest.md)
 - [LaunchDarkly.Api.Model.ApprovalRequestApplyConfigBody](docs/ApprovalRequestApplyConfigBody.md)
 - [LaunchDarkly.Api.Model.ApprovalRequestConfigBody](docs/ApprovalRequestConfigBody.md)
 - [LaunchDarkly.Api.Model.ApprovalRequestReview](docs/ApprovalRequestReview.md)
 - [LaunchDarkly.Api.Model.ApprovalRequestReviewConfigBody](docs/ApprovalRequestReviewConfigBody.md)
 - [LaunchDarkly.Api.Model.ApprovalRequestReviewStatus](docs/ApprovalRequestReviewStatus.md)
 - [LaunchDarkly.Api.Model.ApprovalRequests](docs/ApprovalRequests.md)
 - [LaunchDarkly.Api.Model.AuditLogEntries](docs/AuditLogEntries.md)
 - [LaunchDarkly.Api.Model.AuditLogEntry](docs/AuditLogEntry.md)
 - [LaunchDarkly.Api.Model.AuditLogEntryTarget](docs/AuditLogEntryTarget.md)
 - [LaunchDarkly.Api.Model.Clause](docs/Clause.md)
 - [LaunchDarkly.Api.Model.ClientSideAvailability](docs/ClientSideAvailability.md)
 - [LaunchDarkly.Api.Model.CopyActions](docs/CopyActions.md)
 - [LaunchDarkly.Api.Model.CustomProperty](docs/CustomProperty.md)
 - [LaunchDarkly.Api.Model.CustomPropertyValues](docs/CustomPropertyValues.md)
 - [LaunchDarkly.Api.Model.CustomRole](docs/CustomRole.md)
 - [LaunchDarkly.Api.Model.CustomRoleBody](docs/CustomRoleBody.md)
 - [LaunchDarkly.Api.Model.CustomRoles](docs/CustomRoles.md)
 - [LaunchDarkly.Api.Model.Defaults](docs/Defaults.md)
 - [LaunchDarkly.Api.Model.Destination](docs/Destination.md)
 - [LaunchDarkly.Api.Model.DestinationAmazonKinesis](docs/DestinationAmazonKinesis.md)
 - [LaunchDarkly.Api.Model.DestinationBody](docs/DestinationBody.md)
 - [LaunchDarkly.Api.Model.DestinationGooglePubSub](docs/DestinationGooglePubSub.md)
 - [LaunchDarkly.Api.Model.DestinationMParticle](docs/DestinationMParticle.md)
 - [LaunchDarkly.Api.Model.DestinationSegment](docs/DestinationSegment.md)
 - [LaunchDarkly.Api.Model.Destinations](docs/Destinations.md)
 - [LaunchDarkly.Api.Model.Environment](docs/Environment.md)
 - [LaunchDarkly.Api.Model.EnvironmentApprovalSettings](docs/EnvironmentApprovalSettings.md)
 - [LaunchDarkly.Api.Model.EnvironmentPost](docs/EnvironmentPost.md)
 - [LaunchDarkly.Api.Model.EvaluationUsageError](docs/EvaluationUsageError.md)
 - [LaunchDarkly.Api.Model.Events](docs/Events.md)
 - [LaunchDarkly.Api.Model.Fallthrough](docs/Fallthrough.md)
 - [LaunchDarkly.Api.Model.FeatureFlag](docs/FeatureFlag.md)
 - [LaunchDarkly.Api.Model.FeatureFlagBody](docs/FeatureFlagBody.md)
 - [LaunchDarkly.Api.Model.FeatureFlagConfig](docs/FeatureFlagConfig.md)
 - [LaunchDarkly.Api.Model.FeatureFlagCopyBody](docs/FeatureFlagCopyBody.md)
 - [LaunchDarkly.Api.Model.FeatureFlagCopyObject](docs/FeatureFlagCopyObject.md)
 - [LaunchDarkly.Api.Model.FeatureFlagScheduledChange](docs/FeatureFlagScheduledChange.md)
 - [LaunchDarkly.Api.Model.FeatureFlagScheduledChanges](docs/FeatureFlagScheduledChanges.md)
 - [LaunchDarkly.Api.Model.FeatureFlagScheduledChangesConflicts](docs/FeatureFlagScheduledChangesConflicts.md)
 - [LaunchDarkly.Api.Model.FeatureFlagScheduledChangesConflictsInstructions](docs/FeatureFlagScheduledChangesConflictsInstructions.md)
 - [LaunchDarkly.Api.Model.FeatureFlagStatus](docs/FeatureFlagStatus.md)
 - [LaunchDarkly.Api.Model.FeatureFlagStatusAcrossEnvironments](docs/FeatureFlagStatusAcrossEnvironments.md)
 - [LaunchDarkly.Api.Model.FeatureFlagStatusForQueriedEnvironment](docs/FeatureFlagStatusForQueriedEnvironment.md)
 - [LaunchDarkly.Api.Model.FeatureFlagStatuses](docs/FeatureFlagStatuses.md)
 - [LaunchDarkly.Api.Model.FeatureFlags](docs/FeatureFlags.md)
 - [LaunchDarkly.Api.Model.FlagConfigScheduledChangesConflictsBody](docs/FlagConfigScheduledChangesConflictsBody.md)
 - [LaunchDarkly.Api.Model.FlagConfigScheduledChangesPatchBody](docs/FlagConfigScheduledChangesPatchBody.md)
 - [LaunchDarkly.Api.Model.FlagConfigScheduledChangesPostBody](docs/FlagConfigScheduledChangesPostBody.md)
 - [LaunchDarkly.Api.Model.FlagListItem](docs/FlagListItem.md)
 - [LaunchDarkly.Api.Model.HierarchicalLinks](docs/HierarchicalLinks.md)
 - [LaunchDarkly.Api.Model.Id](docs/Id.md)
 - [LaunchDarkly.Api.Model.Integration](docs/Integration.md)
 - [LaunchDarkly.Api.Model.IntegrationLinks](docs/IntegrationLinks.md)
 - [LaunchDarkly.Api.Model.IntegrationSubscription](docs/IntegrationSubscription.md)
 - [LaunchDarkly.Api.Model.IntegrationSubscriptionStatus](docs/IntegrationSubscriptionStatus.md)
 - [LaunchDarkly.Api.Model.Integrations](docs/Integrations.md)
 - [LaunchDarkly.Api.Model.Link](docs/Link.md)
 - [LaunchDarkly.Api.Model.Links](docs/Links.md)
 - [LaunchDarkly.Api.Model.MAU](docs/MAU.md)
 - [LaunchDarkly.Api.Model.MAUMetadata](docs/MAUMetadata.md)
 - [LaunchDarkly.Api.Model.MAUbyCategory](docs/MAUbyCategory.md)
 - [LaunchDarkly.Api.Model.Member](docs/Member.md)
 - [LaunchDarkly.Api.Model.MemberLastSeenMetadata](docs/MemberLastSeenMetadata.md)
 - [LaunchDarkly.Api.Model.Members](docs/Members.md)
 - [LaunchDarkly.Api.Model.MembersBody](docs/MembersBody.md)
 - [LaunchDarkly.Api.Model.PatchComment](docs/PatchComment.md)
 - [LaunchDarkly.Api.Model.PatchOperation](docs/PatchOperation.md)
 - [LaunchDarkly.Api.Model.Policy](docs/Policy.md)
 - [LaunchDarkly.Api.Model.Prerequisite](docs/Prerequisite.md)
 - [LaunchDarkly.Api.Model.Project](docs/Project.md)
 - [LaunchDarkly.Api.Model.ProjectBody](docs/ProjectBody.md)
 - [LaunchDarkly.Api.Model.Projects](docs/Projects.md)
 - [LaunchDarkly.Api.Model.RelayProxyConfig](docs/RelayProxyConfig.md)
 - [LaunchDarkly.Api.Model.RelayProxyConfigBody](docs/RelayProxyConfigBody.md)
 - [LaunchDarkly.Api.Model.RelayProxyConfigs](docs/RelayProxyConfigs.md)
 - [LaunchDarkly.Api.Model.Role](docs/Role.md)
 - [LaunchDarkly.Api.Model.Rollout](docs/Rollout.md)
 - [LaunchDarkly.Api.Model.Rule](docs/Rule.md)
 - [LaunchDarkly.Api.Model.ScheduledChangesFeatureFlagConflict](docs/ScheduledChangesFeatureFlagConflict.md)
 - [LaunchDarkly.Api.Model.SemanticPatchInstruction](docs/SemanticPatchInstruction.md)
 - [LaunchDarkly.Api.Model.SemanticPatchInstructionInner](docs/SemanticPatchInstructionInner.md)
 - [LaunchDarkly.Api.Model.SemanticPatchOperation](docs/SemanticPatchOperation.md)
 - [LaunchDarkly.Api.Model.Site](docs/Site.md)
 - [LaunchDarkly.Api.Model.Statement](docs/Statement.md)
 - [LaunchDarkly.Api.Model.Stream](docs/Stream.md)
 - [LaunchDarkly.Api.Model.StreamBySDK](docs/StreamBySDK.md)
 - [LaunchDarkly.Api.Model.StreamBySDKLinks](docs/StreamBySDKLinks.md)
 - [LaunchDarkly.Api.Model.StreamBySDKLinksMetadata](docs/StreamBySDKLinksMetadata.md)
 - [LaunchDarkly.Api.Model.StreamLinks](docs/StreamLinks.md)
 - [LaunchDarkly.Api.Model.StreamSDKVersion](docs/StreamSDKVersion.md)
 - [LaunchDarkly.Api.Model.StreamSDKVersionData](docs/StreamSDKVersionData.md)
 - [LaunchDarkly.Api.Model.StreamUsageError](docs/StreamUsageError.md)
 - [LaunchDarkly.Api.Model.StreamUsageLinks](docs/StreamUsageLinks.md)
 - [LaunchDarkly.Api.Model.StreamUsageMetadata](docs/StreamUsageMetadata.md)
 - [LaunchDarkly.Api.Model.StreamUsageSeries](docs/StreamUsageSeries.md)
 - [LaunchDarkly.Api.Model.Streams](docs/Streams.md)
 - [LaunchDarkly.Api.Model.SubscriptionBody](docs/SubscriptionBody.md)
 - [LaunchDarkly.Api.Model.Target](docs/Target.md)
 - [LaunchDarkly.Api.Model.Token](docs/Token.md)
 - [LaunchDarkly.Api.Model.TokenBody](docs/TokenBody.md)
 - [LaunchDarkly.Api.Model.Tokens](docs/Tokens.md)
 - [LaunchDarkly.Api.Model.UnboundedSegmentTargetChanges](docs/UnboundedSegmentTargetChanges.md)
 - [LaunchDarkly.Api.Model.UnboundedSegmentTargetsBody](docs/UnboundedSegmentTargetsBody.md)
 - [LaunchDarkly.Api.Model.Usage](docs/Usage.md)
 - [LaunchDarkly.Api.Model.UsageError](docs/UsageError.md)
 - [LaunchDarkly.Api.Model.UsageLinks](docs/UsageLinks.md)
 - [LaunchDarkly.Api.Model.User](docs/User.md)
 - [LaunchDarkly.Api.Model.UserFlagSetting](docs/UserFlagSetting.md)
 - [LaunchDarkly.Api.Model.UserFlagSettings](docs/UserFlagSettings.md)
 - [LaunchDarkly.Api.Model.UserRecord](docs/UserRecord.md)
 - [LaunchDarkly.Api.Model.UserSegment](docs/UserSegment.md)
 - [LaunchDarkly.Api.Model.UserSegmentBody](docs/UserSegmentBody.md)
 - [LaunchDarkly.Api.Model.UserSegmentRule](docs/UserSegmentRule.md)
 - [LaunchDarkly.Api.Model.UserSegments](docs/UserSegments.md)
 - [LaunchDarkly.Api.Model.UserSettingsBody](docs/UserSettingsBody.md)
 - [LaunchDarkly.Api.Model.UserTargetingExpirationForFlag](docs/UserTargetingExpirationForFlag.md)
 - [LaunchDarkly.Api.Model.UserTargetingExpirationForFlags](docs/UserTargetingExpirationForFlags.md)
 - [LaunchDarkly.Api.Model.UserTargetingExpirationForSegment](docs/UserTargetingExpirationForSegment.md)
 - [LaunchDarkly.Api.Model.UserTargetingExpirationOnFlagsForUser](docs/UserTargetingExpirationOnFlagsForUser.md)
 - [LaunchDarkly.Api.Model.UserTargetingExpirationResourceIdForFlag](docs/UserTargetingExpirationResourceIdForFlag.md)
 - [LaunchDarkly.Api.Model.Users](docs/Users.md)
 - [LaunchDarkly.Api.Model.Variation](docs/Variation.md)
 - [LaunchDarkly.Api.Model.Webhook](docs/Webhook.md)
 - [LaunchDarkly.Api.Model.WebhookBody](docs/WebhookBody.md)
 - [LaunchDarkly.Api.Model.Webhooks](docs/Webhooks.md)
 - [LaunchDarkly.Api.Model.WeightedVariation](docs/WeightedVariation.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Token"></a>
### Token

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

