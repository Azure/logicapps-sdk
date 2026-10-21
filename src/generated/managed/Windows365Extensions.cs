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
        public IBodyWorkflowAction<ListCloudPCsResponse> ListCloudPCs(Expression<Func<selectInput>> select = null, Expression<Func<string>> filter = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ListCloudPCsResponse>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/cloudPCs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<ListCloudPCsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetACloudPCObjectResponse> GetACloudPCObject(Expression<Func<string>> cloudPcId, Expression<Func<selectInput>> select = null)
        {
            var __workflow_cloudPcId = WorkflowExpression.Compile(cloudPcId, nameof(cloudPcId), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetACloudPCObjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}", __workflow_cloudPcId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GetACloudPCObjectResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction RemoteActions(Expression<Func<string>> cloudPcId, Expression<Func<remoteActionInput>> remoteAction, Expression<Func<string>> bodycloudPcSnapshotId = null, Expression<Func<string>> bodydisplayName = null)
        {
            var __workflow_cloudPcId = WorkflowExpression.Compile(cloudPcId, nameof(cloudPcId), required: true);
            var __workflow_remoteAction = WorkflowExpression.Compile(remoteAction, nameof(remoteAction), required: true);
            var __workflow_bodycloudPcSnapshotId = WorkflowExpression.Compile(bodycloudPcSnapshotId, nameof(bodycloudPcSnapshotId), required: false);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/cloudPCs/{0}/{1}", __workflow_cloudPcId.WithUrlEncoding(1), __workflow_remoteAction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycloudPcSnapshotId != null)
                {
                    body["cloudPcSnapshotId"] = ExpressionConverter.ConvertO(__workflow_bodycloudPcSnapshotId);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
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
            return new DeferredBodyAction<JToken>(() =>
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
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction AssignAProvisioningPolicyToAGroup(Expression<Func<string>> id, Expression<Func<bodyassignmentsInputItem[]>> bodyassignments)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyassignments = WorkflowExpression.Compile(bodyassignments, nameof(bodyassignments), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}/assign", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = ExpressionConverter.ConvertO(__workflow_bodyassignments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<CreateAProvisioningPolicyV1Response> CreateAProvisioningPolicy(Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription, Expression<Func<bodydomainJoinConfigurationsInputItem[]>> bodydomainJoinConfigurations, Expression<Func<string>> bodyimageId, Expression<Func<string>> bodyimageDisplayName, Expression<Func<bodyimageTypeInput>> bodyimageType, Expression<Func<bodyprovisioningTypeInput>> bodyprovisioningType, Expression<Func<bool>> bodyenableSingleSignOn = null, Expression<Func<string>> bodywindowsSettinglocale = null, Expression<Func<string>> bodymicrosoftManagedDesktopmanagedType = null, Expression<Func<string>> bodymicrosoftManagedDesktopprofile = null)
        {
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodydomainJoinConfigurations = WorkflowExpression.Compile(bodydomainJoinConfigurations, nameof(bodydomainJoinConfigurations), required: true);
            var __workflow_bodyimageId = WorkflowExpression.Compile(bodyimageId, nameof(bodyimageId), required: true);
            var __workflow_bodyimageDisplayName = WorkflowExpression.Compile(bodyimageDisplayName, nameof(bodyimageDisplayName), required: true);
            var __workflow_bodyimageType = WorkflowExpression.Compile(bodyimageType, nameof(bodyimageType), required: true);
            var __workflow_bodyprovisioningType = WorkflowExpression.Compile(bodyprovisioningType, nameof(bodyprovisioningType), required: true);
            var __workflow_bodyenableSingleSignOn = WorkflowExpression.Compile(bodyenableSingleSignOn, nameof(bodyenableSingleSignOn), required: false);
            var __workflow_bodywindowsSettinglocale = WorkflowExpression.Compile(bodywindowsSettinglocale, nameof(bodywindowsSettinglocale), required: false);
            var __workflow_bodymicrosoftManagedDesktopmanagedType = WorkflowExpression.Compile(bodymicrosoftManagedDesktopmanagedType, nameof(bodymicrosoftManagedDesktopmanagedType), required: false);
            var __workflow_bodymicrosoftManagedDesktopprofile = WorkflowExpression.Compile(bodymicrosoftManagedDesktopprofile, nameof(bodymicrosoftManagedDesktopprofile), required: false);
            return new DeferredBodyAction<CreateAProvisioningPolicyV1Response>(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/provisioningPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["domainJoinConfigurations"] = ExpressionConverter.ConvertO(__workflow_bodydomainJoinConfigurations);
                var otherFieldsObject = new JObject();
                var otherFieldsObjectpropCount = 0;
                if (otherFieldsObjectpropCount > 0)
                {
                    body["otherFields"] = otherFieldsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyenableSingleSignOn != null)
                {
                    body["enableSingleSignOn"] = ExpressionConverter.ConvertO(__workflow_bodyenableSingleSignOn);
                    bodypropCount++;
                }

                bodypropCount++;
                body["imageId"] = ExpressionConverter.ConvertO(__workflow_bodyimageId);
                bodypropCount++;
                body["imageDisplayName"] = ExpressionConverter.ConvertO(__workflow_bodyimageDisplayName);
                bodypropCount++;
                body["imageType"] = ExpressionConverter.ConvertO(__workflow_bodyimageType);
                bodypropCount++;
                body["provisioningType"] = ExpressionConverter.ConvertO(__workflow_bodyprovisioningType);
                var windowsSettingObject = new JObject();
                var windowsSettingObjectpropCount = 0;
                if (__workflow_bodywindowsSettinglocale != null)
                {
                    windowsSettingObject["locale"] = ExpressionConverter.ConvertO(__workflow_bodywindowsSettinglocale);
                    windowsSettingObjectpropCount++;
                }

                if (windowsSettingObjectpropCount > 0)
                {
                    body["windowsSetting"] = windowsSettingObject;
                    bodypropCount++;
                }

                var microsoftManagedDesktopObject = new JObject();
                var microsoftManagedDesktopObjectpropCount = 0;
                if (__workflow_bodymicrosoftManagedDesktopmanagedType != null)
                {
                    microsoftManagedDesktopObject["managedType"] = ExpressionConverter.ConvertO(__workflow_bodymicrosoftManagedDesktopmanagedType);
                    microsoftManagedDesktopObjectpropCount++;
                }

                if (__workflow_bodymicrosoftManagedDesktopprofile != null)
                {
                    microsoftManagedDesktopObject["profile"] = ExpressionConverter.ConvertO(__workflow_bodymicrosoftManagedDesktopprofile);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction DeleteAProvisioningPolicy(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetAProvisioningPolicyV1Response> GetAProvisioningPolicy(Expression<Func<string>> id, Expression<Func<selectInput>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetAProvisioningPolicyV1Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$expand"] = Convert.ToString("assignments");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<GetAProvisioningPolicyV1Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IBodyWorkflowAction<GetProvisioningPoliciesV1Response> GetProvisioningPolicies(Expression<Func<selectInput>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<GetProvisioningPoliciesV1Response>(() =>
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
                return new ApiConnectionAction<GetProvisioningPoliciesV1Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "windows365")]
        public IWorkflowAction UpdateAProvisioningPolicy(Expression<Func<string>> id, Expression<Func<string>> bodyautopatchautopatchGroupId = null, Expression<Func<string>> bodyautopilotConfigurationdevicePreparationProfileId = null, Expression<Func<int>> bodyautopilotConfigurationapplicationTimeoutInMinutes = null, Expression<Func<bool>> bodyautopilotConfigurationonFailureDeviceAccessDenied = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<bodydomainJoinConfigurationsInputItem[]>> bodydomainJoinConfigurations = null, Expression<Func<bool>> bodyenableSingleSignOn = null, Expression<Func<string>> bodyimageDisplayName = null, Expression<Func<string>> bodyimageId = null, Expression<Func<string>> bodyimageType = null, Expression<Func<string>> bodymicrosoftManagedDesktopmanagedType = null, Expression<Func<string>> bodymicrosoftManagedDesktopprofile = null, Expression<Func<string>> bodywindowsSettinglocale = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyautopatchautopatchGroupId = WorkflowExpression.Compile(bodyautopatchautopatchGroupId, nameof(bodyautopatchautopatchGroupId), required: false);
            var __workflow_bodyautopilotConfigurationdevicePreparationProfileId = WorkflowExpression.Compile(bodyautopilotConfigurationdevicePreparationProfileId, nameof(bodyautopilotConfigurationdevicePreparationProfileId), required: false);
            var __workflow_bodyautopilotConfigurationapplicationTimeoutInMinutes = WorkflowExpression.Compile(bodyautopilotConfigurationapplicationTimeoutInMinutes, nameof(bodyautopilotConfigurationapplicationTimeoutInMinutes), required: false);
            var __workflow_bodyautopilotConfigurationonFailureDeviceAccessDenied = WorkflowExpression.Compile(bodyautopilotConfigurationonFailureDeviceAccessDenied, nameof(bodyautopilotConfigurationonFailureDeviceAccessDenied), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodydomainJoinConfigurations = WorkflowExpression.Compile(bodydomainJoinConfigurations, nameof(bodydomainJoinConfigurations), required: false);
            var __workflow_bodyenableSingleSignOn = WorkflowExpression.Compile(bodyenableSingleSignOn, nameof(bodyenableSingleSignOn), required: false);
            var __workflow_bodyimageDisplayName = WorkflowExpression.Compile(bodyimageDisplayName, nameof(bodyimageDisplayName), required: false);
            var __workflow_bodyimageId = WorkflowExpression.Compile(bodyimageId, nameof(bodyimageId), required: false);
            var __workflow_bodyimageType = WorkflowExpression.Compile(bodyimageType, nameof(bodyimageType), required: false);
            var __workflow_bodymicrosoftManagedDesktopmanagedType = WorkflowExpression.Compile(bodymicrosoftManagedDesktopmanagedType, nameof(bodymicrosoftManagedDesktopmanagedType), required: false);
            var __workflow_bodymicrosoftManagedDesktopprofile = WorkflowExpression.Compile(bodymicrosoftManagedDesktopprofile, nameof(bodymicrosoftManagedDesktopprofile), required: false);
            var __workflow_bodywindowsSettinglocale = WorkflowExpression.Compile(bodywindowsSettinglocale, nameof(bodywindowsSettinglocale), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var autopatchObject = new JObject();
                var autopatchObjectpropCount = 0;
                if (__workflow_bodyautopatchautopatchGroupId != null)
                {
                    autopatchObject["autopatchGroupId"] = ExpressionConverter.ConvertO(__workflow_bodyautopatchautopatchGroupId);
                    autopatchObjectpropCount++;
                }

                if (autopatchObjectpropCount > 0)
                {
                    body["autopatch"] = autopatchObject;
                    bodypropCount++;
                }

                var autopilotConfigurationObject = new JObject();
                var autopilotConfigurationObjectpropCount = 0;
                if (__workflow_bodyautopilotConfigurationdevicePreparationProfileId != null)
                {
                    autopilotConfigurationObject["devicePreparationProfileId"] = ExpressionConverter.ConvertO(__workflow_bodyautopilotConfigurationdevicePreparationProfileId);
                    autopilotConfigurationObjectpropCount++;
                }

                if (__workflow_bodyautopilotConfigurationapplicationTimeoutInMinutes != null)
                {
                    autopilotConfigurationObject["applicationTimeoutInMinutes"] = ExpressionConverter.ConvertO(__workflow_bodyautopilotConfigurationapplicationTimeoutInMinutes);
                    autopilotConfigurationObjectpropCount++;
                }

                if (__workflow_bodyautopilotConfigurationonFailureDeviceAccessDenied != null)
                {
                    autopilotConfigurationObject["onFailureDeviceAccessDenied"] = ExpressionConverter.ConvertO(__workflow_bodyautopilotConfigurationonFailureDeviceAccessDenied);
                    autopilotConfigurationObjectpropCount++;
                }

                if (autopilotConfigurationObjectpropCount > 0)
                {
                    body["autopilotConfiguration"] = autopilotConfigurationObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodydomainJoinConfigurations != null)
                {
                    body["domainJoinConfigurations"] = ExpressionConverter.ConvertO(__workflow_bodydomainJoinConfigurations);
                    bodypropCount++;
                }

                if (__workflow_bodyenableSingleSignOn != null)
                {
                    body["enableSingleSignOn"] = ExpressionConverter.ConvertO(__workflow_bodyenableSingleSignOn);
                    bodypropCount++;
                }

                if (__workflow_bodyimageDisplayName != null)
                {
                    body["imageDisplayName"] = ExpressionConverter.ConvertO(__workflow_bodyimageDisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodyimageId != null)
                {
                    body["imageId"] = ExpressionConverter.ConvertO(__workflow_bodyimageId);
                    bodypropCount++;
                }

                if (__workflow_bodyimageType != null)
                {
                    body["imageType"] = ExpressionConverter.ConvertO(__workflow_bodyimageType);
                    bodypropCount++;
                }

                var microsoftManagedDesktopObject = new JObject();
                var microsoftManagedDesktopObjectpropCount = 0;
                if (__workflow_bodymicrosoftManagedDesktopmanagedType != null)
                {
                    microsoftManagedDesktopObject["managedType"] = ExpressionConverter.ConvertO(__workflow_bodymicrosoftManagedDesktopmanagedType);
                    microsoftManagedDesktopObjectpropCount++;
                }

                if (__workflow_bodymicrosoftManagedDesktopprofile != null)
                {
                    microsoftManagedDesktopObject["profile"] = ExpressionConverter.ConvertO(__workflow_bodymicrosoftManagedDesktopprofile);
                    microsoftManagedDesktopObjectpropCount++;
                }

                if (microsoftManagedDesktopObjectpropCount > 0)
                {
                    body["microsoftManagedDesktop"] = microsoftManagedDesktopObject;
                    bodypropCount++;
                }

                var windowsSettingObject = new JObject();
                var windowsSettingObjectpropCount = 0;
                if (__workflow_bodywindowsSettinglocale != null)
                {
                    windowsSettingObject["locale"] = ExpressionConverter.ConvertO(__workflow_bodywindowsSettinglocale);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class Windows365Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Webhook(Expression<Func<bodyscenarioInput>> bodyscenario, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyscenario = WorkflowExpression.Compile(bodyscenario, nameof(bodyscenario), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/beta/deviceManagement/virtualEndpoint/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["scenario"] = ExpressionConverter.ConvertO(__workflow_bodyscenario);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyimageTypeInput
    {
        [EnumMember(Value = "gallery")]
        Gallery,
        [EnumMember(Value = "custom")]
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
