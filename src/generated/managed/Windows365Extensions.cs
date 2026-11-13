//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Windows365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Windows365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<ListCloudPCsResponse, ApiConnectionActionConfiguration> ListCloudPCs(Expression<Func<GetACloudPCObjectSelectInput>> select = null, Expression<Func<string>> filter = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ListCloudPCsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/cloudPCs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ListCloudPCsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetACloudPCObjectResponse, ApiConnectionActionConfiguration> GetACloudPCObject(Expression<Func<string>> cloudPcId, Expression<Func<GetACloudPCObjectSelectInput>> select = null)
        {
            var __workflow_cloudPcId = WorkflowExpression.Compile(cloudPcId, nameof(cloudPcId), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetACloudPCObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}", __workflow_cloudPcId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GetACloudPCObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoteActions(Expression<Func<string>> cloudPcId, Expression<Func<RemoteActionInput>> remoteAction, Expression<Func<RemoteActionsBodyInput>> body = null)
        {
            var __workflow_cloudPcId = WorkflowExpression.Compile(cloudPcId, nameof(cloudPcId), required: true);
            var __workflow_remoteAction = WorkflowExpression.Compile(remoteAction, nameof(remoteAction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}/{1}", __workflow_cloudPcId.WithUrlEncoding(1), __workflow_remoteAction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> uri, Expression<Func<MethodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = WorkflowExpression.Compile(customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = WorkflowExpression.Compile(customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = WorkflowExpression.Compile(customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = WorkflowExpression.Compile(customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = WorkflowExpression.Compile(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(__workflow_uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(__workflow_customHeader1);
                if (__workflow_customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(__workflow_customHeader2);
                if (__workflow_customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(__workflow_customHeader3);
                if (__workflow_customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(__workflow_customHeader4);
                if (__workflow_customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(__workflow_customHeader5);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssignAProvisioningPolicyToAGroup(Expression<Func<string>> id, Expression<Func<AssignAProvisioningPolicyToAGroupBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}/assign", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<CreateAProvisioningPolicyResponse, ApiConnectionActionConfiguration> CreateAProvisioningPolicy(Expression<Func<CreateAProvisioningPolicyBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAProvisioningPolicyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAProvisioningPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAProvisioningPolicy(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetAProvisioningPolicyResponse, ApiConnectionActionConfiguration> GetAProvisioningPolicy(Expression<Func<string>> id, Expression<Func<GetAProvisioningPolicySelectInput>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetAProvisioningPolicyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$expand"] = Convert.ToString("assignments");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetAProvisioningPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetProvisioningPoliciesResponse, ApiConnectionActionConfiguration> GetProvisioningPolicies(Expression<Func<GetAProvisioningPolicySelectInput>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetProvisioningPoliciesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$expand"] = Convert.ToString("assignments");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetProvisioningPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAProvisioningPolicy(Expression<Func<string>> id, Expression<Func<UpdateAProvisioningPolicyBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Windows365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCloudPcProvisionedResponse, ApiConnectionPollingTriggerConfiguration> WebhookCloudPcProvisioned(Expression<Func<WebhookCloudPcProvisionedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCloudPcProvisionedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks/cloudPcProvisioned/activate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<WebhookCloudPcProvisionedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCloudPcRemoteActionTriggeredResponse, ApiConnectionPollingTriggerConfiguration> WebhookCloudPcRemoteActionTriggered(Expression<Func<WebhookCloudPcProvisionedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCloudPcRemoteActionTriggeredResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks/cloudPcRemoteActionTriggered/activate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<WebhookCloudPcRemoteActionTriggeredResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCloudPcRemoteActionCompletedResponse, ApiConnectionPollingTriggerConfiguration> WebhookCloudPcRemoteActionCompleted(Expression<Func<WebhookCloudPcProvisionedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCloudPcRemoteActionCompletedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks/cloudPcRemoteActionCompleted/activate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<WebhookCloudPcRemoteActionCompletedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookProvisioningPolicyCreatedResponse, ApiConnectionPollingTriggerConfiguration> WebhookProvisioningPolicyCreated(Expression<Func<WebhookProvisioningPolicyCreatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookProvisioningPolicyCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks/provisioningPolicyCreated/activate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<WebhookProvisioningPolicyCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookProvisioningPolicyUpdatedResponse, ApiConnectionPollingTriggerConfiguration> WebhookProvisioningPolicyUpdated(Expression<Func<WebhookProvisioningPolicyCreatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookProvisioningPolicyUpdatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks/provisioningPolicyUpdated/activate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<WebhookProvisioningPolicyUpdatedResponse>(callPayload);
            });
        }
    }

    public class ListCloudPCsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("aadDeviceId")]
        public string AadDeviceId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("imageDisplayName")]
        public string ImageDisplayName { get; set; }

        [JsonProperty("provisioningPolicyId")]
        public string ProvisioningPolicyId { get; set; }

        [JsonProperty("provisioningPolicyName")]
        public string ProvisioningPolicyName { get; set; }

        [JsonProperty("onPremisesConnectionName")]
        public string OnPremisesConnectionName { get; set; }

        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }

        [JsonProperty("servicePlanName")]
        public string ServicePlanName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("managedDeviceId")]
        public string ManagedDeviceId { get; set; }

        [JsonProperty("managedDeviceName")]
        public string ManagedDeviceName { get; set; }

        [JsonProperty("gracePeriodEndDateTime")]
        public string GracePeriodEndDateTime { get; set; }

        [JsonProperty("diskEncryptionState")]
        public string DiskEncryptionState { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }

        [JsonProperty("allotmentDisplayName")]
        public string AllotmentDisplayName { get; set; }

        [JsonProperty("statusDetail")]
        public string StatusDetail { get; set; }

        [JsonProperty("connectionSetting")]
        public ListCloudPCsResponseConnectionSettingType ConnectionSetting { get; set; }

        [JsonProperty("partnerAgentInstallResults")]
        public string[] PartnerAgentInstallResults { get; set; }
    }

    public class ListCloudPCsResponseConnectionSettingType
    {
        [JsonProperty("enableSingleSignOn")]
        public bool EnableSingleSignOn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetACloudPCObjectSelectInput
    {
        [EnumMember(Value = "allotmentDisplayName")]
        AllotmentDisplayName,
        [EnumMember(Value = "diskEncryptionState")]
        DiskEncryptionState,
        [EnumMember(Value = "displayName")]
        DisplayName,
        [EnumMember(Value = "gracePeriodEndDateTime")]
        GracePeriodEndDateTime,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "imageDisplayName")]
        ImageDisplayName,
        [EnumMember(Value = "lastModifiedDateTime")]
        LastModifiedDateTime,
        [EnumMember(Value = "managedDeviceId")]
        ManagedDeviceId,
        [EnumMember(Value = "managedDeviceName")]
        ManagedDeviceName,
        [EnumMember(Value = "onPremisesConnectionName")]
        OnPremisesConnectionName,
        [EnumMember(Value = "provisioningPolicyId")]
        ProvisioningPolicyId,
        [EnumMember(Value = "provisioningPolicyName")]
        ProvisioningPolicyName,
        [EnumMember(Value = "partnerAgentInstallResults")]
        PartnerAgentInstallResults,
        [EnumMember(Value = "provisioningType")]
        ProvisioningType,
        [EnumMember(Value = "servicePlanId")]
        ServicePlanId,
        [EnumMember(Value = "servicePlanName")]
        ServicePlanName,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "statusDetail")]
        StatusDetail,
        [EnumMember(Value = "userPrincipalName")]
        UserPrincipalName
    }

    public class GetACloudPCObjectResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("aadDeviceId")]
        public string AadDeviceId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("imageDisplayName")]
        public string ImageDisplayName { get; set; }

        [JsonProperty("provisioningPolicyId")]
        public string ProvisioningPolicyId { get; set; }

        [JsonProperty("provisioningPolicyName")]
        public string ProvisioningPolicyName { get; set; }

        [JsonProperty("onPremisesConnectionName")]
        public string OnPremisesConnectionName { get; set; }

        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }

        [JsonProperty("servicePlanName")]
        public string ServicePlanName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("managedDeviceId")]
        public string ManagedDeviceId { get; set; }

        [JsonProperty("managedDeviceName")]
        public string ManagedDeviceName { get; set; }

        [JsonProperty("gracePeriodEndDateTime")]
        public string GracePeriodEndDateTime { get; set; }

        [JsonProperty("diskEncryptionState")]
        public string DiskEncryptionState { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }

        [JsonProperty("allotmentDisplayName")]
        public string AllotmentDisplayName { get; set; }

        [JsonProperty("statusDetail")]
        public string StatusDetail { get; set; }

        [JsonProperty("connectionSetting")]
        public GetACloudPCObjectResponseConnectionSettingType ConnectionSetting { get; set; }

        [JsonProperty("partnerAgentInstallResults")]
        public string[] PartnerAgentInstallResults { get; set; }
    }

    public class GetACloudPCObjectResponseConnectionSettingType
    {
        [JsonProperty("enableSingleSignOn")]
        public bool EnableSingleSignOn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RemoteActionInput
    {
        [EnumMember(Value = "endGracePeriod")]
        EndGracePeriod,
        [EnumMember(Value = "reboot")]
        Reboot,
        [EnumMember(Value = "reprovision")]
        Reprovision,
        [EnumMember(Value = "troubleshoot")]
        Troubleshoot,
        [EnumMember(Value = "rename")]
        Rename,
        [EnumMember(Value = "restore")]
        Restore
    }

    public class RemoteActionsBodyInput
    {
        [JsonProperty("cloudPcSnapshotId")]
        public string CloudPcSnapshotId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MethodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class AssignAProvisioningPolicyToAGroupBodyInput
    {
        public AssignAProvisioningPolicyToAGroupBodyInput(BodyInputAssignmentsTypeItem[] assignments)
        {
            this.Assignments = assignments;
        }

        [JsonProperty("assignments", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAssignmentsTypeItem[] Assignments { get; set; }
    }

    public class BodyInputAssignmentsTypeItem
    {
        public BodyInputAssignmentsTypeItem(BodyInputAssignmentsTypeItemTargetType target)
        {
            this.Target = target;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAssignmentsTypeItemTargetType Target { get; set; }
    }

    public class BodyInputAssignmentsTypeItemTargetType
    {
        public BodyInputAssignmentsTypeItemTargetType(string groupId)
        {
            this.GroupId = groupId;
        }

        [JsonProperty("groupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }
    }

    public class CreateAProvisioningPolicyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        [JsonProperty("imageDisplayName")]
        public string ImageDisplayName { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("enableSingleSignOn")]
        public bool EnableSingleSignOn { get; set; }

        [JsonProperty("cloudPcNamingTemplate")]
        public string CloudPcNamingTemplate { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("scopeIds")]
        public JToken[] ScopeIds { get; set; }

        [JsonProperty("autopatch")]
        public string Autopatch { get; set; }

        [JsonProperty("autopilotConfiguration")]
        public string AutopilotConfiguration { get; set; }

        [JsonProperty("domainJoinConfigurations")]
        public CreateAProvisioningPolicyResponseDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public CreateAProvisioningPolicyResponseMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("windowsSetting")]
        public CreateAProvisioningPolicyResponseWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("windowsSettings")]
        public CreateAProvisioningPolicyResponseWindowsSettingsType WindowsSettings { get; set; }
    }

    public class CreateAProvisioningPolicyResponseDomainJoinConfigurationsTypeItem
    {
        [JsonProperty("domainJoinType")]
        public string DomainJoinType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("regionGroup")]
        public string RegionGroup { get; set; }
    }

    public class CreateAProvisioningPolicyResponseMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class CreateAProvisioningPolicyResponseWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class CreateAProvisioningPolicyResponseWindowsSettingsType
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CreateAProvisioningPolicyBodyInput
    {
        public CreateAProvisioningPolicyBodyInput(string displayName, string description, BodyInputDomainJoinConfigurationsTypeItem[] domainJoinConfigurations, string imageId, string imageDisplayName, BodyInputImageTypeType imageType, BodyInputProvisioningTypeType provisioningType, CreateAProvisioningPolicyBodyInputWindowsSettingType windowsSetting)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.DomainJoinConfigurations = domainJoinConfigurations;
            this.ImageId = imageId;
            this.ImageDisplayName = imageDisplayName;
            this.ImageType = imageType;
            this.ProvisioningType = provisioningType;
            this.WindowsSetting = windowsSetting;
        }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("domainJoinConfigurations", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("otherFields")]
        public JToken OtherFields { get; set; }

        [JsonProperty("enableSingleSignOn")]
        public bool? EnableSingleSignOn { get; set; }

        [JsonProperty("imageId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageId { get; set; }

        [JsonProperty("imageDisplayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageDisplayName { get; set; }

        [JsonProperty("imageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageTypeType ImageType { get; set; }

        [JsonProperty("provisioningType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputProvisioningTypeType ProvisioningType { get; set; }

        [JsonProperty("windowsSetting", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAProvisioningPolicyBodyInputWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public BodyInputMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }
    }

    public class BodyInputDomainJoinConfigurationsTypeItem
    {
        [JsonProperty("domainJoinType")]
        public string DomainJoinType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("regionGroup")]
        public string RegionGroup { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputImageTypeType
    {
        [EnumMember(Value = "gallery")]
        Gallery,
        [EnumMember(Value = "custom")]
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputProvisioningTypeType
    {
        [EnumMember(Value = "dedicated")]
        Dedicated,
        [EnumMember(Value = "shared")]
        Shared,
        [EnumMember(Value = "sharedByUser")]
        SharedByUser,
        [EnumMember(Value = "sharedByEntraGroup")]
        SharedByEntraGroup
    }

    public class CreateAProvisioningPolicyBodyInputWindowsSettingType
    {
        public CreateAProvisioningPolicyBodyInputWindowsSettingType(string locale)
        {
            this.Locale = locale;
        }

        [JsonProperty("locale", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locale { get; set; }
    }

    public class BodyInputMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class GetAProvisioningPolicyResponse
    {
        [JsonProperty("assignments")]
        public JToken[] Assignments { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("domainJoinConfigurations")]
        public GetAProvisioningPolicyResponseDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public GetAProvisioningPolicyResponseMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("autopatch")]
        public GetAProvisioningPolicyResponseAutopatchType Autopatch { get; set; }

        [JsonProperty("autopilotConfiguration")]
        public GetAProvisioningPolicyResponseAutopilotConfigurationType AutopilotConfiguration { get; set; }

        [JsonProperty("enableSingleSignOn")]
        public bool EnableSingleSignOn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageDisplayName")]
        public string ImageDisplayName { get; set; }

        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("windowsSetting")]
        public GetAProvisioningPolicyResponseWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }
    }

    public class GetAProvisioningPolicyResponseDomainJoinConfigurationsTypeItem
    {
        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetAProvisioningPolicyResponseMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class GetAProvisioningPolicyResponseAutopatchType
    {
        [JsonProperty("autopatchGroupId")]
        public string AutopatchGroupId { get; set; }
    }

    public class GetAProvisioningPolicyResponseAutopilotConfigurationType
    {
        [JsonProperty("devicePreparationProfileId")]
        public string DevicePreparationProfileId { get; set; }

        [JsonProperty("applicationTimeoutInMinutes")]
        public int ApplicationTimeoutInMinutes { get; set; }

        [JsonProperty("onFailureDeviceAccessDenied")]
        public bool OnFailureDeviceAccessDenied { get; set; }
    }

    public class GetAProvisioningPolicyResponseWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetAProvisioningPolicySelectInput
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "displayName")]
        DisplayName,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "imageId")]
        ImageId,
        [EnumMember(Value = "imageDisplayName")]
        ImageDisplayName,
        [EnumMember(Value = "imageType")]
        ImageType,
        [EnumMember(Value = "enableSingleSignOn")]
        EnableSingleSignOn,
        [EnumMember(Value = "provisioningType")]
        ProvisioningType,
        [EnumMember(Value = "autopatch")]
        Autopatch,
        [EnumMember(Value = "domainJoinConfigurations")]
        DomainJoinConfigurations,
        [EnumMember(Value = "microsoftManagedDesktop")]
        MicrosoftManagedDesktop,
        [EnumMember(Value = "windowsSetting")]
        WindowsSetting,
        [EnumMember(Value = "alternateResourceUrl,autopatch,cloudPcGroupDisplayName,cloudPcNamingTemplate,description,displayName,domainJoinConfigurations,enableSingleSignOn,gracePeriodInHours,id,imageDisplayName,imageId,imageType,localAdminEnabled,microsoftManagedDesktop,provisioningType,windowsSetting")]
        AlternateResourceUrlAutopatchCloudPcGroupDisplayNameCloudPcNamingTemplateDescriptionDisplayNameDomainJoinConfigurationsEnableSingleSignOnGracePeriodInHoursIdImageDisplayNameImageIdImageTypeLocalAdminEnabledMicrosoftManagedDesktopProvisioningTypeWindowsSetting
    }

    public class GetProvisioningPoliciesResponse
    {
        [JsonProperty("value")]
        public GetProvisioningPoliciesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetProvisioningPoliciesResponseValueTypeItem
    {
        [JsonProperty("assignments")]
        public JToken[] Assignments { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("domainJoinConfigurations")]
        public GetProvisioningPoliciesResponseValueTypeItemDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public GetProvisioningPoliciesResponseValueTypeItemMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("autopatch")]
        public GetProvisioningPoliciesResponseValueTypeItemAutopatchType Autopatch { get; set; }

        [JsonProperty("autopilotConfiguration")]
        public GetProvisioningPoliciesResponseValueTypeItemAutopilotConfigurationType AutopilotConfiguration { get; set; }

        [JsonProperty("enableSingleSignOn")]
        public bool EnableSingleSignOn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageDisplayName")]
        public string ImageDisplayName { get; set; }

        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("windowsSetting")]
        public GetProvisioningPoliciesResponseValueTypeItemWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }
    }

    public class GetProvisioningPoliciesResponseValueTypeItemDomainJoinConfigurationsTypeItem
    {
        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProvisioningPoliciesResponseValueTypeItemMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class GetProvisioningPoliciesResponseValueTypeItemAutopatchType
    {
        [JsonProperty("autopatchGroupId")]
        public string AutopatchGroupId { get; set; }
    }

    public class GetProvisioningPoliciesResponseValueTypeItemAutopilotConfigurationType
    {
        [JsonProperty("devicePreparationProfileId")]
        public string DevicePreparationProfileId { get; set; }

        [JsonProperty("applicationTimeoutInMinutes")]
        public int ApplicationTimeoutInMinutes { get; set; }

        [JsonProperty("onFailureDeviceAccessDenied")]
        public bool OnFailureDeviceAccessDenied { get; set; }
    }

    public class GetProvisioningPoliciesResponseValueTypeItemWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class UpdateAProvisioningPolicyBodyInput
    {
        [JsonProperty("autopatch")]
        public BodyInputAutopatchType Autopatch { get; set; }

        [JsonProperty("autopilotConfiguration")]
        public BodyInputAutopilotConfigurationType AutopilotConfiguration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("domainJoinConfigurations")]
        public BodyInputDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("enableSingleSignOn")]
        public bool? EnableSingleSignOn { get; set; }

        [JsonProperty("imageDisplayName")]
        public string ImageDisplayName { get; set; }

        [JsonProperty("imageId")]
        public string ImageId { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public BodyInputMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("windowsSetting")]
        public UpdateAProvisioningPolicyBodyInputWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("otherFields")]
        public JToken OtherFields { get; set; }
    }

    public class BodyInputAutopatchType
    {
        [JsonProperty("autopatchGroupId")]
        public string AutopatchGroupId { get; set; }
    }

    public class BodyInputAutopilotConfigurationType
    {
        [JsonProperty("devicePreparationProfileId")]
        public string DevicePreparationProfileId { get; set; }

        [JsonProperty("applicationTimeoutInMinutes")]
        public int? ApplicationTimeoutInMinutes { get; set; }

        [JsonProperty("onFailureDeviceAccessDenied")]
        public bool? OnFailureDeviceAccessDenied { get; set; }
    }

    public class UpdateAProvisioningPolicyBodyInputWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class WebhookCloudPcProvisionedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WebhookCloudPcProvisionedBodyInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("cloudPcWebhookEventFilter")]
        public WebhookCloudPcProvisionedBodyInputCloudPcWebhookEventFilterType CloudPcWebhookEventFilter { get; set; }
    }

    public class WebhookCloudPcProvisionedBodyInputCloudPcWebhookEventFilterType
    {
        [JsonProperty("provisioningTypeNames")]
        public BodyInputCloudPcWebhookEventFilterTypeProvisioningTypeNamesTypeItem[] ProvisioningTypeNames { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCloudPcWebhookEventFilterTypeProvisioningTypeNamesTypeItem
    {
        [EnumMember(Value = "Windows 365 Enterprise")]
        Windows365Enterprise,
        [EnumMember(Value = "Windows 365 Flex in Dedicated mode")]
        Windows365FlexInDedicatedMode,
        [EnumMember(Value = "Windows 365 Flex in Shared mode")]
        Windows365FlexInSharedMode,
        [EnumMember(Value = "Windows 365 Reserve")]
        Windows365Reserve
    }

    public class WebhookCloudPcRemoteActionTriggeredResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WebhookCloudPcRemoteActionCompletedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WebhookProvisioningPolicyCreatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WebhookProvisioningPolicyCreatedBodyInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("cloudPcWebhookEventFilter")]
        public WebhookProvisioningPolicyCreatedBodyInputCloudPcWebhookEventFilterType CloudPcWebhookEventFilter { get; set; }
    }

    public class WebhookProvisioningPolicyCreatedBodyInputCloudPcWebhookEventFilterType
    {
        [JsonProperty("provisioningPolicyNames")]
        public string[] ProvisioningPolicyNames { get; set; }

        [JsonProperty("provisioningPolicyIds")]
        public string[] ProvisioningPolicyIds { get; set; }

        [JsonProperty("provisioningTypeNames")]
        public BodyInputCloudPcWebhookEventFilterTypeProvisioningTypeNamesTypeItem[] ProvisioningTypeNames { get; set; }
    }

    public class WebhookProvisioningPolicyUpdatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Windows365;

    public partial class WorkflowManagedActions
    {
        public Windows365Actions Windows365(string connectionId) => new Windows365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Windows365Triggers Windows365(string connectionId) => new Windows365Triggers(connectionId);
    }
}