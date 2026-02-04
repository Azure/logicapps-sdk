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
        public IWorkflowAction DeleteAProvisioningPolicyV1(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetAProvisioningPolicyV1Response> GetAProvisioningPolicyV1(Expression<Func<string>> id, Expression<Func<selectInput>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$expand"] = Convert.ToString("assignments");
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<GetAProvisioningPolicyV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction UpdateAProvisioningPolicyV1(Expression<Func<string>> id, Expression<Func<string>> bodyautopatchautopatchGroupId = null, Expression<Func<string>> bodyautopilotConfigurationdevicePreparationProfileId = null, Expression<Func<int>> bodyautopilotConfigurationapplicationTimeoutInMinutes = null, Expression<Func<bool>> bodyautopilotConfigurationonFailureDeviceAccessDenied = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<bodydomainJoinConfigurationsInputItem[]>> bodydomainJoinConfigurations = null, Expression<Func<bool>> bodyenableSingleSignOn = null, Expression<Func<string>> bodyimageDisplayName = null, Expression<Func<string>> bodyimageId = null, Expression<Func<string>> bodyimageType = null, Expression<Func<string>> bodymicrosoftManagedDesktopmanagedType = null, Expression<Func<string>> bodymicrosoftManagedDesktopprofile = null, Expression<Func<string>> bodywindowsSettinglocale = null)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var autopatchObject = new JObject();
            var autopatchObjectpropCount = 0;
            if (bodyautopatchautopatchGroupId != null)
            {
                autopatchObject["autopatchGroupId"] = ExpressionConverter.ConvertO(bodyautopatchautopatchGroupId);
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
                autopilotConfigurationObject["devicePreparationProfileId"] = ExpressionConverter.ConvertO(bodyautopilotConfigurationdevicePreparationProfileId);
                autopilotConfigurationObjectpropCount++;
            }

            if (bodyautopilotConfigurationapplicationTimeoutInMinutes != null)
            {
                autopilotConfigurationObject["applicationTimeoutInMinutes"] = ExpressionConverter.ConvertO(bodyautopilotConfigurationapplicationTimeoutInMinutes);
                autopilotConfigurationObjectpropCount++;
            }

            if (bodyautopilotConfigurationonFailureDeviceAccessDenied != null)
            {
                autopilotConfigurationObject["onFailureDeviceAccessDenied"] = ExpressionConverter.ConvertO(bodyautopilotConfigurationonFailureDeviceAccessDenied);
                autopilotConfigurationObjectpropCount++;
            }

            if (autopilotConfigurationObjectpropCount > 0)
            {
                body["autopilotConfiguration"] = autopilotConfigurationObject;
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodydomainJoinConfigurations != null)
            {
                body["domainJoinConfigurations"] = ExpressionConverter.ConvertO(bodydomainJoinConfigurations);
                bodypropCount++;
            }

            if (bodyenableSingleSignOn != null)
            {
                body["enableSingleSignOn"] = ExpressionConverter.ConvertO(bodyenableSingleSignOn);
                bodypropCount++;
            }

            if (bodyimageDisplayName != null)
            {
                body["imageDisplayName"] = ExpressionConverter.ConvertO(bodyimageDisplayName);
                bodypropCount++;
            }

            if (bodyimageId != null)
            {
                body["imageId"] = ExpressionConverter.ConvertO(bodyimageId);
                bodypropCount++;
            }

            if (bodyimageType != null)
            {
                body["imageType"] = ExpressionConverter.ConvertO(bodyimageType);
                bodypropCount++;
            }

            var microsoftManagedDesktopObject = new JObject();
            var microsoftManagedDesktopObjectpropCount = 0;
            if (bodymicrosoftManagedDesktopmanagedType != null)
            {
                microsoftManagedDesktopObject["managedType"] = ExpressionConverter.ConvertO(bodymicrosoftManagedDesktopmanagedType);
                microsoftManagedDesktopObjectpropCount++;
            }

            if (bodymicrosoftManagedDesktopprofile != null)
            {
                microsoftManagedDesktopObject["profile"] = ExpressionConverter.ConvertO(bodymicrosoftManagedDesktopprofile);
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
                windowsSettingObject["locale"] = ExpressionConverter.ConvertO(bodywindowsSettinglocale);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<CreateAProvisioningPolicyV1Response> CreateAProvisioningPolicyV1(Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription, Expression<Func<bodydomainJoinConfigurationsInputItem[]>> bodydomainJoinConfigurations, Expression<Func<string>> bodyimageId, Expression<Func<string>> bodyimageDisplayName, Expression<Func<bodyimageTypeInput>> bodyimageType, Expression<Func<bodyprovisioningTypeInput>> bodyprovisioningType, Expression<Func<bool>> bodyenableSingleSignOn = null, Expression<Func<string>> bodywindowsSettinglocale = null, Expression<Func<string>> bodymicrosoftManagedDesktopmanagedType = null, Expression<Func<string>> bodymicrosoftManagedDesktopprofile = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["domainJoinConfigurations"] = ExpressionConverter.ConvertO(bodydomainJoinConfigurations);
            var otherFieldsObject = new JObject();
            var otherFieldsObjectpropCount = 0;
            if (otherFieldsObjectpropCount > 0)
            {
                body["otherFields"] = otherFieldsObject;
                bodypropCount++;
            }

            if (bodyenableSingleSignOn != null)
            {
                body["enableSingleSignOn"] = ExpressionConverter.ConvertO(bodyenableSingleSignOn);
                bodypropCount++;
            }

            bodypropCount++;
            body["imageId"] = ExpressionConverter.ConvertO(bodyimageId);
            bodypropCount++;
            body["imageDisplayName"] = ExpressionConverter.ConvertO(bodyimageDisplayName);
            bodypropCount++;
            body["imageType"] = ExpressionConverter.ConvertO(bodyimageType);
            bodypropCount++;
            body["provisioningType"] = ExpressionConverter.ConvertO(bodyprovisioningType);
            var windowsSettingObject = new JObject();
            var windowsSettingObjectpropCount = 0;
            if (bodywindowsSettinglocale != null)
            {
                windowsSettingObject["locale"] = ExpressionConverter.ConvertO(bodywindowsSettinglocale);
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
                microsoftManagedDesktopObject["managedType"] = ExpressionConverter.ConvertO(bodymicrosoftManagedDesktopmanagedType);
                microsoftManagedDesktopObjectpropCount++;
            }

            if (bodymicrosoftManagedDesktopprofile != null)
            {
                microsoftManagedDesktopObject["profile"] = ExpressionConverter.ConvertO(bodymicrosoftManagedDesktopprofile);
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
        public IBodyWorkflowAction<GetProvisioningPoliciesV1Response> GetProvisioningPoliciesV1(Expression<Func<selectInput>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$expand"] = Convert.ToString("assignments");
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<GetProvisioningPoliciesV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction AssignAProvisioningPolicyToAGroupV1(Expression<Func<string>> id, Expression<Func<bodyassignmentsInputItem[]>> bodyassignments)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}/assign", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["assignments"] = ExpressionConverter.ConvertO(bodyassignments);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<ListCloudPCsResponse> ListCloudPCs(Expression<Func<selectInput>> select = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/beta/deviceManagement/virtualEndpoint/cloudPCs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ListCloudPCsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetACloudPCObjectResponse> GetACloudPCObject(Expression<Func<string>> cloudPcId, Expression<Func<selectInput>> select = null)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}", ExpressionConverter.ConvertWithUrlEncoding(cloudPcId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetACloudPCObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction RemoteActions(Expression<Func<string>> cloudPcId, Expression<Func<remoteActionInput>> remoteAction, Expression<Func<string>> bodycloudPcSnapshotId = null, Expression<Func<string>> bodydisplayName = null)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(cloudPcId, 1), ExpressionConverter.ConvertWithUrlEncoding(remoteAction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycloudPcSnapshotId != null)
            {
                body["cloudPcSnapshotId"] = ExpressionConverter.ConvertO(bodycloudPcSnapshotId);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
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
            callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
            callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
            callPayload.Headers["ContentType"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
            if (customHeader1 != null)
                callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
            if (customHeader2 != null)
                callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
            if (customHeader3 != null)
                callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
            if (customHeader4 != null)
                callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
            if (customHeader5 != null)
                callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
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
            body["scenario"] = ExpressionConverter.ConvertO(bodyscenario);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
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

    public enum selectInput
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

    public class bodydomainJoinConfigurationsInputItem
    {
        [JsonProperty("domainJoinType")]
        public string DomainJoinType { get; set; }

        [JsonProperty("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }

        [JsonProperty("regionGroup")]
        public string RegionGroup { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
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