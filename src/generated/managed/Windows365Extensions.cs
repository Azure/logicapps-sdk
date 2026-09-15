//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Windows365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Windows365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<ListCloudPCsResponse> ListCloudPCs(Expression<Func<selectInput>> select = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/cloudPCs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.Convert(select);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            return new ApiConnectionAction<ListCloudPCsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetACloudPCObjectResponse> GetACloudPCObject(Expression<Func<string>> cloudPcId, Expression<Func<selectInput>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cloudPcId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetACloudPCObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction RemoteActions(Expression<Func<string>> cloudPcId, Expression<Func<remoteActionInput>> remoteAction, Expression<Func<string>> bodycloudPcSnapshotId = null, Expression<Func<string>> bodydisplayName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cloudPcId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(remoteAction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycloudPcSnapshotId != null)
            {
                body["cloudPcSnapshotId"] = CSharpExpressionConverter.ConvertToken(bodycloudPcSnapshotId);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["displayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var apiCallPath = "/httprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Uri"] = CSharpExpressionConverter.ConvertO(uri);
            callPayload.Headers["Method"] = CSharpExpressionConverter.Convert(method);
            callPayload.Headers["ContentType"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["ContentType"] = CSharpExpressionConverter.ConvertO(contentType);
            if (customHeader1 != null)
                callPayload.Headers["CustomHeader1"] = CSharpExpressionConverter.ConvertO(customHeader1);
            if (customHeader2 != null)
                callPayload.Headers["CustomHeader2"] = CSharpExpressionConverter.ConvertO(customHeader2);
            if (customHeader3 != null)
                callPayload.Headers["CustomHeader3"] = CSharpExpressionConverter.ConvertO(customHeader3);
            if (customHeader4 != null)
                callPayload.Headers["CustomHeader4"] = CSharpExpressionConverter.ConvertO(customHeader4);
            if (customHeader5 != null)
                callPayload.Headers["CustomHeader5"] = CSharpExpressionConverter.ConvertO(customHeader5);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction AssignAProvisioningPolicyToAGroup(Expression<Func<string>> id, Expression<Func<bodyassignmentsInputItem[]>> bodyassignments)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}/assign", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["assignments"] = CSharpExpressionConverter.ConvertToken(bodyassignments);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<CreateAProvisioningPolicyV1Response> CreateAProvisioningPolicy(Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription, Expression<Func<bodydomainJoinConfigurationsInputItem[]>> bodydomainJoinConfigurations, Expression<Func<string>> bodyimageId, Expression<Func<string>> bodyimageDisplayName, Expression<Func<bodyimageTypeInput>> bodyimageType, Expression<Func<bodyprovisioningTypeInput>> bodyprovisioningType, Expression<Func<bool>> bodyenableSingleSignOn = null, Expression<Func<string>> bodywindowsSettinglocale = null, Expression<Func<string>> bodymicrosoftManagedDesktopmanagedType = null, Expression<Func<string>> bodymicrosoftManagedDesktopprofile = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["displayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            bodypropCount++;
            body["domainJoinConfigurations"] = CSharpExpressionConverter.ConvertToken(bodydomainJoinConfigurations);
            var otherFieldsObject = new JObject();
            var otherFieldsObjectpropCount = 0;
            if (otherFieldsObjectpropCount > 0)
            {
                body["otherFields"] = otherFieldsObject;
                bodypropCount++;
            }

            if (bodyenableSingleSignOn != null)
            {
                body["enableSingleSignOn"] = CSharpExpressionConverter.ConvertToken(bodyenableSingleSignOn);
                bodypropCount++;
            }

            bodypropCount++;
            body["imageId"] = CSharpExpressionConverter.ConvertToken(bodyimageId);
            bodypropCount++;
            body["imageDisplayName"] = CSharpExpressionConverter.ConvertToken(bodyimageDisplayName);
            bodypropCount++;
            body["imageType"] = CSharpExpressionConverter.Convert(bodyimageType);
            bodypropCount++;
            body["provisioningType"] = CSharpExpressionConverter.Convert(bodyprovisioningType);
            var windowsSettingObject = new JObject();
            var windowsSettingObjectpropCount = 0;
            if (bodywindowsSettinglocale != null)
            {
                windowsSettingObject["locale"] = CSharpExpressionConverter.ConvertToken(bodywindowsSettinglocale);
                windowsSettingObjectpropCount++;
            }

            if (windowsSettingObjectpropCount > 0)
            {
                body["windowsSetting"] = windowsSettingObject;
                bodypropCount++;
            }

            var microsoftManagedDesktopObject = new JObject();
            var microsoftManagedDesktopObjectpropCount = 0;
            if (bodymicrosoftManagedDesktopmanagedType != null)
            {
                microsoftManagedDesktopObject["managedType"] = CSharpExpressionConverter.ConvertToken(bodymicrosoftManagedDesktopmanagedType);
                microsoftManagedDesktopObjectpropCount++;
            }

            if (bodymicrosoftManagedDesktopprofile != null)
            {
                microsoftManagedDesktopObject["profile"] = CSharpExpressionConverter.ConvertToken(bodymicrosoftManagedDesktopprofile);
                microsoftManagedDesktopObjectpropCount++;
            }

            if (microsoftManagedDesktopObjectpropCount > 0)
            {
                body["microsoftManagedDesktop"] = microsoftManagedDesktopObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAProvisioningPolicyV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction DeleteAProvisioningPolicy(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetAProvisioningPolicyV1Response> GetAProvisioningPolicy(Expression<Func<string>> id, Expression<Func<selectInput>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.Convert(select);
            callPayload.Queries["$expand"] = Convert.ToString("assignments");
            if (expand != null)
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            return new ApiConnectionAction<GetAProvisioningPolicyV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetProvisioningPoliciesV1Response> GetProvisioningPolicies(Expression<Func<selectInput>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.Convert(select);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            callPayload.Queries["$expand"] = Convert.ToString("assignments");
            if (expand != null)
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            return new ApiConnectionAction<GetProvisioningPoliciesV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction UpdateAProvisioningPolicy(Expression<Func<string>> id, Expression<Func<string>> bodyautopatchautopatchGroupId = null, Expression<Func<string>> bodyautopilotConfigurationdevicePreparationProfileId = null, Expression<Func<int>> bodyautopilotConfigurationapplicationTimeoutInMinutes = null, Expression<Func<bool>> bodyautopilotConfigurationonFailureDeviceAccessDenied = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<bodydomainJoinConfigurationsInputItem[]>> bodydomainJoinConfigurations = null, Expression<Func<bool>> bodyenableSingleSignOn = null, Expression<Func<string>> bodyimageDisplayName = null, Expression<Func<string>> bodyimageId = null, Expression<Func<string>> bodyimageType = null, Expression<Func<string>> bodymicrosoftManagedDesktopmanagedType = null, Expression<Func<string>> bodymicrosoftManagedDesktopprofile = null, Expression<Func<string>> bodywindowsSettinglocale = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var autopatchObject = new JObject();
            var autopatchObjectpropCount = 0;
            if (bodyautopatchautopatchGroupId != null)
            {
                autopatchObject["autopatchGroupId"] = CSharpExpressionConverter.ConvertToken(bodyautopatchautopatchGroupId);
                autopatchObjectpropCount++;
            }

            if (autopatchObjectpropCount > 0)
            {
                body["autopatch"] = autopatchObject;
                bodypropCount++;
            }

            var autopilotConfigurationObject = new JObject();
            var autopilotConfigurationObjectpropCount = 0;
            if (bodyautopilotConfigurationdevicePreparationProfileId != null)
            {
                autopilotConfigurationObject["devicePreparationProfileId"] = CSharpExpressionConverter.ConvertToken(bodyautopilotConfigurationdevicePreparationProfileId);
                autopilotConfigurationObjectpropCount++;
            }

            if (bodyautopilotConfigurationapplicationTimeoutInMinutes != null)
            {
                autopilotConfigurationObject["applicationTimeoutInMinutes"] = CSharpExpressionConverter.ConvertToken(bodyautopilotConfigurationapplicationTimeoutInMinutes);
                autopilotConfigurationObjectpropCount++;
            }

            if (bodyautopilotConfigurationonFailureDeviceAccessDenied != null)
            {
                autopilotConfigurationObject["onFailureDeviceAccessDenied"] = CSharpExpressionConverter.ConvertToken(bodyautopilotConfigurationonFailureDeviceAccessDenied);
                autopilotConfigurationObjectpropCount++;
            }

            if (autopilotConfigurationObjectpropCount > 0)
            {
                body["autopilotConfiguration"] = autopilotConfigurationObject;
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["displayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
            }

            if (bodydomainJoinConfigurations != null)
            {
                body["domainJoinConfigurations"] = CSharpExpressionConverter.ConvertToken(bodydomainJoinConfigurations);
                bodypropCount++;
            }

            if (bodyenableSingleSignOn != null)
            {
                body["enableSingleSignOn"] = CSharpExpressionConverter.ConvertToken(bodyenableSingleSignOn);
                bodypropCount++;
            }

            if (bodyimageDisplayName != null)
            {
                body["imageDisplayName"] = CSharpExpressionConverter.ConvertToken(bodyimageDisplayName);
                bodypropCount++;
            }

            if (bodyimageId != null)
            {
                body["imageId"] = CSharpExpressionConverter.ConvertToken(bodyimageId);
                bodypropCount++;
            }

            if (bodyimageType != null)
            {
                body["imageType"] = CSharpExpressionConverter.ConvertToken(bodyimageType);
                bodypropCount++;
            }

            var microsoftManagedDesktopObject = new JObject();
            var microsoftManagedDesktopObjectpropCount = 0;
            if (bodymicrosoftManagedDesktopmanagedType != null)
            {
                microsoftManagedDesktopObject["managedType"] = CSharpExpressionConverter.ConvertToken(bodymicrosoftManagedDesktopmanagedType);
                microsoftManagedDesktopObjectpropCount++;
            }

            if (bodymicrosoftManagedDesktopprofile != null)
            {
                microsoftManagedDesktopObject["profile"] = CSharpExpressionConverter.ConvertToken(bodymicrosoftManagedDesktopprofile);
                microsoftManagedDesktopObjectpropCount++;
            }

            if (microsoftManagedDesktopObjectpropCount > 0)
            {
                body["microsoftManagedDesktop"] = microsoftManagedDesktopObject;
                bodypropCount++;
            }

            var windowsSettingObject = new JObject();
            var windowsSettingObjectpropCount = 0;
            if (bodywindowsSettinglocale != null)
            {
                windowsSettingObject["locale"] = CSharpExpressionConverter.ConvertToken(bodywindowsSettinglocale);
                windowsSettingObjectpropCount++;
            }

            if (windowsSettingObjectpropCount > 0)
            {
                body["windowsSetting"] = windowsSettingObject;
                bodypropCount++;
            }

            var otherFieldsObject = new JObject();
            var otherFieldsObjectpropCount = 0;
            if (otherFieldsObjectpropCount > 0)
            {
                body["otherFields"] = otherFieldsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class Windows365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Webhook(Expression<Func<bodyscenarioInput>> bodyscenario, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["scenario"] = CSharpExpressionConverter.Convert(bodyscenario);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public enum selectInput
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

    public enum remoteActionInput
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

    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class bodyassignmentsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("target")]
        public bodyassignmentsInputItemTargetType Target { get; set; }
    }

    public class bodyassignmentsInputItemTargetType
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }
    }

    public class CreateAProvisioningPolicyV1Response
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
        public CreateAProvisioningPolicyV1ResponseDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public CreateAProvisioningPolicyV1ResponseMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("windowsSetting")]
        public CreateAProvisioningPolicyV1ResponseWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("windowsSettings")]
        public CreateAProvisioningPolicyV1ResponseWindowsSettingsType WindowsSettings { get; set; }
    }

    public class CreateAProvisioningPolicyV1ResponseDomainJoinConfigurationsTypeItem
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

    public class CreateAProvisioningPolicyV1ResponseMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class CreateAProvisioningPolicyV1ResponseWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class CreateAProvisioningPolicyV1ResponseWindowsSettingsType
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class bodydomainJoinConfigurationsInputItem
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

    public enum bodyimageTypeInput
    {
        [EnumMember(Value = "gallery")]
        Gallery,
        [EnumMember(Value = "custom")]
        Custom
    }

    public enum bodyprovisioningTypeInput
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

    public class GetAProvisioningPolicyV1Response
    {
        [JsonProperty("assignments")]
        public JToken[] Assignments { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("domainJoinConfigurations")]
        public GetAProvisioningPolicyV1ResponseDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public GetAProvisioningPolicyV1ResponseMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("autopatch")]
        public GetAProvisioningPolicyV1ResponseAutopatchType Autopatch { get; set; }

        [JsonProperty("autopilotConfiguration")]
        public GetAProvisioningPolicyV1ResponseAutopilotConfigurationType AutopilotConfiguration { get; set; }

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
        public GetAProvisioningPolicyV1ResponseWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }
    }

    public class GetAProvisioningPolicyV1ResponseDomainJoinConfigurationsTypeItem
    {
        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetAProvisioningPolicyV1ResponseMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class GetAProvisioningPolicyV1ResponseAutopatchType
    {
        [JsonProperty("autopatchGroupId")]
        public string AutopatchGroupId { get; set; }
    }

    public class GetAProvisioningPolicyV1ResponseAutopilotConfigurationType
    {
        [JsonProperty("devicePreparationProfileId")]
        public string DevicePreparationProfileId { get; set; }

        [JsonProperty("applicationTimeoutInMinutes")]
        public int ApplicationTimeoutInMinutes { get; set; }

        [JsonProperty("onFailureDeviceAccessDenied")]
        public bool OnFailureDeviceAccessDenied { get; set; }
    }

    public class GetAProvisioningPolicyV1ResponseWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class GetProvisioningPoliciesV1Response
    {
        [JsonProperty("value")]
        public GetProvisioningPoliciesV1ResponseValueTypeItem[] Value { get; set; }
    }

    public class GetProvisioningPoliciesV1ResponseValueTypeItem
    {
        [JsonProperty("assignments")]
        public JToken[] Assignments { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("domainJoinConfigurations")]
        public GetProvisioningPoliciesV1ResponseValueTypeItemDomainJoinConfigurationsTypeItem[] DomainJoinConfigurations { get; set; }

        [JsonProperty("microsoftManagedDesktop")]
        public GetProvisioningPoliciesV1ResponseValueTypeItemMicrosoftManagedDesktopType MicrosoftManagedDesktop { get; set; }

        [JsonProperty("autopatch")]
        public GetProvisioningPoliciesV1ResponseValueTypeItemAutopatchType Autopatch { get; set; }

        [JsonProperty("autopilotConfiguration")]
        public GetProvisioningPoliciesV1ResponseValueTypeItemAutopilotConfigurationType AutopilotConfiguration { get; set; }

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
        public GetProvisioningPoliciesV1ResponseValueTypeItemWindowsSettingType WindowsSetting { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("provisioningType")]
        public string ProvisioningType { get; set; }
    }

    public class GetProvisioningPoliciesV1ResponseValueTypeItemDomainJoinConfigurationsTypeItem
    {
        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProvisioningPoliciesV1ResponseValueTypeItemMicrosoftManagedDesktopType
    {
        [JsonProperty("managedType")]
        public string ManagedType { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class GetProvisioningPoliciesV1ResponseValueTypeItemAutopatchType
    {
        [JsonProperty("autopatchGroupId")]
        public string AutopatchGroupId { get; set; }
    }

    public class GetProvisioningPoliciesV1ResponseValueTypeItemAutopilotConfigurationType
    {
        [JsonProperty("devicePreparationProfileId")]
        public string DevicePreparationProfileId { get; set; }

        [JsonProperty("applicationTimeoutInMinutes")]
        public int ApplicationTimeoutInMinutes { get; set; }

        [JsonProperty("onFailureDeviceAccessDenied")]
        public bool OnFailureDeviceAccessDenied { get; set; }
    }

    public class GetProvisioningPoliciesV1ResponseValueTypeItemWindowsSettingType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public enum bodyscenarioInput
    {
        [EnumMember(Value = "When a new provisioning policy is created")]
        WhenANewProvisioningPolicyIsCreated,
        [EnumMember(Value = "When a provisioning policy is updated")]
        WhenAProvisioningPolicyIsUpdated,
        [EnumMember(Value = "When a Cloud PC is created")]
        WhenACloudPCIsCreated,
        [EnumMember(Value = "When a remote action on a Cloud PC is triggered")]
        WhenARemoteActionOnACloudPCIsTriggered,
        [EnumMember(Value = "When a remote action on a Cloud PC completes")]
        WhenARemoteActionOnACloudPCCompletes
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