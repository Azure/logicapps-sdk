//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gofileroom
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GofileroomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyaccessToApproveDocsOnly = null, Expression<Func<string>> bodyallowAccessToReports = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyenableMfa = null, Expression<Func<string>> bodyenforceMfaForUsers = null, Expression<Func<string>> bodyfirmFlowRoutingNotification = null, Expression<Func<string>> bodyfullAccessToDocTracking = null, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodymfaRequired = null, Expression<Func<string>> bodypermissonToApproveDocs = null, Expression<Func<bodyreportsInputItem[]>> bodyreports = null, Expression<Func<string>> bodyuploadLocation = null, Expression<Func<string[]>> bodyusers = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyaccessToApproveDocsOnly = WorkflowExpression.Compile(bodyaccessToApproveDocsOnly, nameof(bodyaccessToApproveDocsOnly), required: false);
            var __workflow_bodyallowAccessToReports = WorkflowExpression.Compile(bodyallowAccessToReports, nameof(bodyallowAccessToReports), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyenableMfa = WorkflowExpression.Compile(bodyenableMfa, nameof(bodyenableMfa), required: false);
            var __workflow_bodyenforceMfaForUsers = WorkflowExpression.Compile(bodyenforceMfaForUsers, nameof(bodyenforceMfaForUsers), required: false);
            var __workflow_bodyfirmFlowRoutingNotification = WorkflowExpression.Compile(bodyfirmFlowRoutingNotification, nameof(bodyfirmFlowRoutingNotification), required: false);
            var __workflow_bodyfullAccessToDocTracking = WorkflowExpression.Compile(bodyfullAccessToDocTracking, nameof(bodyfullAccessToDocTracking), required: false);
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            var __workflow_bodymfaRequired = WorkflowExpression.Compile(bodymfaRequired, nameof(bodymfaRequired), required: false);
            var __workflow_bodypermissonToApproveDocs = WorkflowExpression.Compile(bodypermissonToApproveDocs, nameof(bodypermissonToApproveDocs), required: false);
            var __workflow_bodyreports = WorkflowExpression.Compile(bodyreports, nameof(bodyreports), required: false);
            var __workflow_bodyuploadLocation = WorkflowExpression.Compile(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<CreateGroupResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/creategroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccessToApproveDocsOnly != null)
                {
                    body["AccessToApproveDocsOnly"] = ExpressionConverter.ConvertO(__workflow_bodyaccessToApproveDocsOnly);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAccessToReports != null)
                {
                    body["AllowAccessToReports"] = ExpressionConverter.ConvertO(__workflow_bodyallowAccessToReports);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyenableMfa != null)
                {
                    body["EnableMfa"] = ExpressionConverter.ConvertO(__workflow_bodyenableMfa);
                    bodypropCount++;
                }

                if (__workflow_bodyenforceMfaForUsers != null)
                {
                    body["EnforceMfaForUsers"] = ExpressionConverter.ConvertO(__workflow_bodyenforceMfaForUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyfirmFlowRoutingNotification != null)
                {
                    body["FirmFlowRoutingNotification"] = ExpressionConverter.ConvertO(__workflow_bodyfirmFlowRoutingNotification);
                    bodypropCount++;
                }

                if (__workflow_bodyfullAccessToDocTracking != null)
                {
                    body["FullAccessToDocTracking"] = ExpressionConverter.ConvertO(__workflow_bodyfullAccessToDocTracking);
                    bodypropCount++;
                }

                if (__workflow_bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (__workflow_bodymfaRequired != null)
                {
                    body["MfaRequired"] = ExpressionConverter.ConvertO(__workflow_bodymfaRequired);
                    bodypropCount++;
                }

                if (__workflow_bodypermissonToApproveDocs != null)
                {
                    body["PermissonToApproveDocs"] = ExpressionConverter.ConvertO(__workflow_bodypermissonToApproveDocs);
                    bodypropCount++;
                }

                if (__workflow_bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(__workflow_bodyreports);
                    bodypropCount++;
                }

                if (__workflow_bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(__workflow_bodyuploadLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyusers != null)
                {
                    body["Users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetGroupDocSecurityResponse> SetGroupDocSecurity(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodycabinetName = null, Expression<Func<bodydocumentSecurityInputItem[]>> bodydocumentSecurity = null, Expression<Func<string>> bodydrawerName = null, Expression<Func<string>> bodygroupName = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodycabinetName = WorkflowExpression.Compile(bodycabinetName, nameof(bodycabinetName), required: false);
            var __workflow_bodydocumentSecurity = WorkflowExpression.Compile(bodydocumentSecurity, nameof(bodydocumentSecurity), required: false);
            var __workflow_bodydrawerName = WorkflowExpression.Compile(bodydrawerName, nameof(bodydrawerName), required: false);
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            return new DeferredBodyAction<SetGroupDocSecurityResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/documentsecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycabinetName != null)
                {
                    body["CabinetName"] = ExpressionConverter.ConvertO(__workflow_bodycabinetName);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentSecurity != null)
                {
                    body["DocumentSecurity"] = ExpressionConverter.ConvertO(__workflow_bodydocumentSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(__workflow_bodydrawerName);
                    bodypropCount++;
                }

                if (__workflow_bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetGroupDocSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ModifyGroupResponse> ModifyGroup(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyaccessToApproveDocsOnly = null, Expression<Func<string>> bodyallowAccessToReports = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyenableMfa = null, Expression<Func<string>> bodyenforceMfaForUsers = null, Expression<Func<string>> bodyfirmFlowRoutingNotification = null, Expression<Func<string>> bodyfullAccessToDocTracking = null, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodymfaRequired = null, Expression<Func<string>> bodypermissonToApproveDocs = null, Expression<Func<string>> bodyrenameGroup = null, Expression<Func<bodyreportsInputItem[]>> bodyreports = null, Expression<Func<string>> bodyuploadLocation = null, Expression<Func<string[]>> bodyusers = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyaccessToApproveDocsOnly = WorkflowExpression.Compile(bodyaccessToApproveDocsOnly, nameof(bodyaccessToApproveDocsOnly), required: false);
            var __workflow_bodyallowAccessToReports = WorkflowExpression.Compile(bodyallowAccessToReports, nameof(bodyallowAccessToReports), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyenableMfa = WorkflowExpression.Compile(bodyenableMfa, nameof(bodyenableMfa), required: false);
            var __workflow_bodyenforceMfaForUsers = WorkflowExpression.Compile(bodyenforceMfaForUsers, nameof(bodyenforceMfaForUsers), required: false);
            var __workflow_bodyfirmFlowRoutingNotification = WorkflowExpression.Compile(bodyfirmFlowRoutingNotification, nameof(bodyfirmFlowRoutingNotification), required: false);
            var __workflow_bodyfullAccessToDocTracking = WorkflowExpression.Compile(bodyfullAccessToDocTracking, nameof(bodyfullAccessToDocTracking), required: false);
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            var __workflow_bodymfaRequired = WorkflowExpression.Compile(bodymfaRequired, nameof(bodymfaRequired), required: false);
            var __workflow_bodypermissonToApproveDocs = WorkflowExpression.Compile(bodypermissonToApproveDocs, nameof(bodypermissonToApproveDocs), required: false);
            var __workflow_bodyrenameGroup = WorkflowExpression.Compile(bodyrenameGroup, nameof(bodyrenameGroup), required: false);
            var __workflow_bodyreports = WorkflowExpression.Compile(bodyreports, nameof(bodyreports), required: false);
            var __workflow_bodyuploadLocation = WorkflowExpression.Compile(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<ModifyGroupResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/modifygroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccessToApproveDocsOnly != null)
                {
                    body["AccessToApproveDocsOnly"] = ExpressionConverter.ConvertO(__workflow_bodyaccessToApproveDocsOnly);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAccessToReports != null)
                {
                    body["AllowAccessToReports"] = ExpressionConverter.ConvertO(__workflow_bodyallowAccessToReports);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyenableMfa != null)
                {
                    body["EnableMfa"] = ExpressionConverter.ConvertO(__workflow_bodyenableMfa);
                    bodypropCount++;
                }

                if (__workflow_bodyenforceMfaForUsers != null)
                {
                    body["EnforceMfaForUsers"] = ExpressionConverter.ConvertO(__workflow_bodyenforceMfaForUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyfirmFlowRoutingNotification != null)
                {
                    body["FirmFlowRoutingNotification"] = ExpressionConverter.ConvertO(__workflow_bodyfirmFlowRoutingNotification);
                    bodypropCount++;
                }

                if (__workflow_bodyfullAccessToDocTracking != null)
                {
                    body["FullAccessToDocTracking"] = ExpressionConverter.ConvertO(__workflow_bodyfullAccessToDocTracking);
                    bodypropCount++;
                }

                if (__workflow_bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (__workflow_bodymfaRequired != null)
                {
                    body["MfaRequired"] = ExpressionConverter.ConvertO(__workflow_bodymfaRequired);
                    bodypropCount++;
                }

                if (__workflow_bodypermissonToApproveDocs != null)
                {
                    body["PermissonToApproveDocs"] = ExpressionConverter.ConvertO(__workflow_bodypermissonToApproveDocs);
                    bodypropCount++;
                }

                if (__workflow_bodyrenameGroup != null)
                {
                    body["RenameGroup"] = ExpressionConverter.ConvertO(__workflow_bodyrenameGroup);
                    bodypropCount++;
                }

                if (__workflow_bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(__workflow_bodyreports);
                    bodypropCount++;
                }

                if (__workflow_bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(__workflow_bodyuploadLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyusers != null)
                {
                    body["Users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModifyGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupPermissionsResponse> GetGroupPermissions(Expression<Func<string>> groupName = null, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_groupName = WorkflowExpression.Compile(groupName, nameof(groupName), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupPermissionsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/permissions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_groupName != null)
                    callPayload.Queries["groupName"] = ExpressionConverter.Convert(__workflow_groupName);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetGroupPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetGroupPermissionsResponse> SetGroupPermissions(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodycabinet = null, Expression<Func<string>> bodycabinetPermissionadd = null, Expression<Func<string>> bodycabinetPermissiondelete = null, Expression<Func<string>> bodycabinetPermissiondeny = null, Expression<Func<string>> bodycabinetPermissionedit = null, Expression<Func<string>> bodycabinetPermissionlookUp = null, Expression<Func<string>> bodycabinetPermissionread = null, Expression<Func<bodydrawerPermissionsInputItem[]>> bodydrawerPermissions = null, Expression<Func<string>> bodygroupName = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodycabinet = WorkflowExpression.Compile(bodycabinet, nameof(bodycabinet), required: false);
            var __workflow_bodycabinetPermissionadd = WorkflowExpression.Compile(bodycabinetPermissionadd, nameof(bodycabinetPermissionadd), required: false);
            var __workflow_bodycabinetPermissiondelete = WorkflowExpression.Compile(bodycabinetPermissiondelete, nameof(bodycabinetPermissiondelete), required: false);
            var __workflow_bodycabinetPermissiondeny = WorkflowExpression.Compile(bodycabinetPermissiondeny, nameof(bodycabinetPermissiondeny), required: false);
            var __workflow_bodycabinetPermissionedit = WorkflowExpression.Compile(bodycabinetPermissionedit, nameof(bodycabinetPermissionedit), required: false);
            var __workflow_bodycabinetPermissionlookUp = WorkflowExpression.Compile(bodycabinetPermissionlookUp, nameof(bodycabinetPermissionlookUp), required: false);
            var __workflow_bodycabinetPermissionread = WorkflowExpression.Compile(bodycabinetPermissionread, nameof(bodycabinetPermissionread), required: false);
            var __workflow_bodydrawerPermissions = WorkflowExpression.Compile(bodydrawerPermissions, nameof(bodydrawerPermissions), required: false);
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            return new DeferredBodyAction<SetGroupPermissionsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycabinet != null)
                {
                    body["Cabinet"] = ExpressionConverter.ConvertO(__workflow_bodycabinet);
                    bodypropCount++;
                }

                var cabinetPermissionObject = new JObject();
                var cabinetPermissionObjectpropCount = 0;
                if (__workflow_bodycabinetPermissionadd != null)
                {
                    cabinetPermissionObject["Add"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionadd);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissiondelete != null)
                {
                    cabinetPermissionObject["Delete"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissiondelete);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissiondeny != null)
                {
                    cabinetPermissionObject["Deny"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissiondeny);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissionedit != null)
                {
                    cabinetPermissionObject["Edit"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionedit);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissionlookUp != null)
                {
                    cabinetPermissionObject["LookUp"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionlookUp);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissionread != null)
                {
                    cabinetPermissionObject["Read"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionread);
                    cabinetPermissionObjectpropCount++;
                }

                if (cabinetPermissionObjectpropCount > 0)
                {
                    body["CabinetPermission"] = cabinetPermissionObject;
                    bodypropCount++;
                }

                if (__workflow_bodydrawerPermissions != null)
                {
                    body["DrawerPermissions"] = ExpressionConverter.ConvertO(__workflow_bodydrawerPermissions);
                    bodypropCount++;
                }

                if (__workflow_bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetGroupPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupDocumentSecurityResponse> GetGroupDocumentSecurity(Expression<Func<string>> groupName, Expression<Func<string>> cabinetName, Expression<Func<string>> drawerName, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_groupName = WorkflowExpression.Compile(groupName, nameof(groupName), required: true);
            var __workflow_cabinetName = WorkflowExpression.Compile(cabinetName, nameof(cabinetName), required: true);
            var __workflow_drawerName = WorkflowExpression.Compile(drawerName, nameof(drawerName), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupDocumentSecurityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/administration/group/{0}/{1}/{2}/documentsecurity", __workflow_groupName.WithUrlEncoding(1), __workflow_cabinetName.WithUrlEncoding(1), __workflow_drawerName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetGroupDocumentSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupsResponseItem[]> GetGroups(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupsResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/administration/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateUsersResponse> CreateUsers(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyaccountExpiresDate = null, Expression<Func<string>> bodydisabledComments = null, Expression<Func<string>> bodyfullName = null, Expression<Func<string[]>> bodygroups = null, Expression<Func<string>> bodyisAccountExpires = null, Expression<Func<string>> bodyisAdvanceFlow = null, Expression<Func<string>> bodyisAllowAccessToReports = null, Expression<Func<string>> bodyisAllowOffline = null, Expression<Func<string>> bodyisDisabled = null, Expression<Func<string>> bodyisFirmFlow = null, Expression<Func<string>> bodyisFirmFlowNotificationGroup = null, Expression<Func<string>> bodyisFirmFlowNotificationUser = null, Expression<Func<string>> bodyisMfa = null, Expression<Func<string>> bodyisUserAdministration = null, Expression<Func<string>> bodyisWorkflowManagerUser = null, Expression<Func<string>> bodylicenseType = null, Expression<Func<string>> bodyloginName = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<string>> bodypassword = null, Expression<Func<bodyreportsInputItem[]>> bodyreports = null, Expression<Func<string>> bodyuploadLocation = null)
        {
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyaccountExpiresDate = WorkflowExpression.Compile(bodyaccountExpiresDate, nameof(bodyaccountExpiresDate), required: false);
            var __workflow_bodydisabledComments = WorkflowExpression.Compile(bodydisabledComments, nameof(bodydisabledComments), required: false);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodyisAccountExpires = WorkflowExpression.Compile(bodyisAccountExpires, nameof(bodyisAccountExpires), required: false);
            var __workflow_bodyisAdvanceFlow = WorkflowExpression.Compile(bodyisAdvanceFlow, nameof(bodyisAdvanceFlow), required: false);
            var __workflow_bodyisAllowAccessToReports = WorkflowExpression.Compile(bodyisAllowAccessToReports, nameof(bodyisAllowAccessToReports), required: false);
            var __workflow_bodyisAllowOffline = WorkflowExpression.Compile(bodyisAllowOffline, nameof(bodyisAllowOffline), required: false);
            var __workflow_bodyisDisabled = WorkflowExpression.Compile(bodyisDisabled, nameof(bodyisDisabled), required: false);
            var __workflow_bodyisFirmFlow = WorkflowExpression.Compile(bodyisFirmFlow, nameof(bodyisFirmFlow), required: false);
            var __workflow_bodyisFirmFlowNotificationGroup = WorkflowExpression.Compile(bodyisFirmFlowNotificationGroup, nameof(bodyisFirmFlowNotificationGroup), required: false);
            var __workflow_bodyisFirmFlowNotificationUser = WorkflowExpression.Compile(bodyisFirmFlowNotificationUser, nameof(bodyisFirmFlowNotificationUser), required: false);
            var __workflow_bodyisMfa = WorkflowExpression.Compile(bodyisMfa, nameof(bodyisMfa), required: false);
            var __workflow_bodyisUserAdministration = WorkflowExpression.Compile(bodyisUserAdministration, nameof(bodyisUserAdministration), required: false);
            var __workflow_bodyisWorkflowManagerUser = WorkflowExpression.Compile(bodyisWorkflowManagerUser, nameof(bodyisWorkflowManagerUser), required: false);
            var __workflow_bodylicenseType = WorkflowExpression.Compile(bodylicenseType, nameof(bodylicenseType), required: false);
            var __workflow_bodyloginName = WorkflowExpression.Compile(bodyloginName, nameof(bodyloginName), required: false);
            var __workflow_bodymanagerEmail = WorkflowExpression.Compile(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyreports = WorkflowExpression.Compile(bodyreports, nameof(bodyreports), required: false);
            var __workflow_bodyuploadLocation = WorkflowExpression.Compile(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            return new DeferredBodyAction<CreateUsersResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/createuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userType"] = Convert.ToString("GFRUSERS");
                if (__workflow_userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(__workflow_userType);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountExpiresDate != null)
                {
                    body["AccountExpiresDate"] = ExpressionConverter.ConvertO(__workflow_bodyaccountExpiresDate);
                    bodypropCount++;
                }

                if (__workflow_bodydisabledComments != null)
                {
                    body["DisabledComments"] = ExpressionConverter.ConvertO(__workflow_bodydisabledComments);
                    bodypropCount++;
                }

                if (__workflow_bodyfullName != null)
                {
                    body["FullName"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["Groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodyisAccountExpires != null)
                {
                    body["IsAccountExpires"] = ExpressionConverter.ConvertO(__workflow_bodyisAccountExpires);
                    bodypropCount++;
                }

                if (__workflow_bodyisAdvanceFlow != null)
                {
                    body["IsAdvanceFlow"] = ExpressionConverter.ConvertO(__workflow_bodyisAdvanceFlow);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllowAccessToReports != null)
                {
                    body["IsAllowAccessToReports"] = ExpressionConverter.ConvertO(__workflow_bodyisAllowAccessToReports);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllowOffline != null)
                {
                    body["IsAllowOffline"] = ExpressionConverter.ConvertO(__workflow_bodyisAllowOffline);
                    bodypropCount++;
                }

                if (__workflow_bodyisDisabled != null)
                {
                    body["IsDisabled"] = ExpressionConverter.ConvertO(__workflow_bodyisDisabled);
                    bodypropCount++;
                }

                if (__workflow_bodyisFirmFlow != null)
                {
                    body["IsFirmFlow"] = ExpressionConverter.ConvertO(__workflow_bodyisFirmFlow);
                    bodypropCount++;
                }

                if (__workflow_bodyisFirmFlowNotificationGroup != null)
                {
                    body["IsFirmFlowNotificationGroup"] = ExpressionConverter.ConvertO(__workflow_bodyisFirmFlowNotificationGroup);
                    bodypropCount++;
                }

                if (__workflow_bodyisFirmFlowNotificationUser != null)
                {
                    body["IsFirmFlowNotificationUser"] = ExpressionConverter.ConvertO(__workflow_bodyisFirmFlowNotificationUser);
                    bodypropCount++;
                }

                if (__workflow_bodyisMfa != null)
                {
                    body["IsMfa"] = ExpressionConverter.ConvertO(__workflow_bodyisMfa);
                    bodypropCount++;
                }

                if (__workflow_bodyisUserAdministration != null)
                {
                    body["IsUserAdministration"] = ExpressionConverter.ConvertO(__workflow_bodyisUserAdministration);
                    bodypropCount++;
                }

                if (__workflow_bodyisWorkflowManagerUser != null)
                {
                    body["IsWorkflowManagerUser"] = ExpressionConverter.ConvertO(__workflow_bodyisWorkflowManagerUser);
                    bodypropCount++;
                }

                if (__workflow_bodylicenseType != null)
                {
                    body["LicenseType"] = ExpressionConverter.ConvertO(__workflow_bodylicenseType);
                    bodypropCount++;
                }

                if (__workflow_bodyloginName != null)
                {
                    body["LoginName"] = ExpressionConverter.ConvertO(__workflow_bodyloginName);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerEmail != null)
                {
                    body["ManagerEmail"] = ExpressionConverter.ConvertO(__workflow_bodymanagerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(__workflow_bodyreports);
                    bodypropCount++;
                }

                if (__workflow_bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(__workflow_bodyuploadLocation);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteUserResponse> DeleteUser(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyloginId = null, Expression<Func<bodyuserTypeInput>> bodyuserType = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyloginId = WorkflowExpression.Compile(bodyloginId, nameof(bodyloginId), required: false);
            var __workflow_bodyuserType = WorkflowExpression.Compile(bodyuserType, nameof(bodyuserType), required: false);
            return new DeferredBodyAction<DeleteUserResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyloginId != null)
                {
                    body["LoginId"] = ExpressionConverter.ConvertO(__workflow_bodyloginId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserType != null)
                {
                    body["UserType"] = ExpressionConverter.ConvertO(__workflow_bodyuserType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetUserDocSecurityResponse> SetUserDocSecurity(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodycabinetName = null, Expression<Func<bodydocumentSecurityInputItem2[]>> bodydocumentSecurity = null, Expression<Func<string>> bodydrawerName = null, Expression<Func<string>> bodyloginId = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodycabinetName = WorkflowExpression.Compile(bodycabinetName, nameof(bodycabinetName), required: false);
            var __workflow_bodydocumentSecurity = WorkflowExpression.Compile(bodydocumentSecurity, nameof(bodydocumentSecurity), required: false);
            var __workflow_bodydrawerName = WorkflowExpression.Compile(bodydrawerName, nameof(bodydrawerName), required: false);
            var __workflow_bodyloginId = WorkflowExpression.Compile(bodyloginId, nameof(bodyloginId), required: false);
            return new DeferredBodyAction<SetUserDocSecurityResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/documentsecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycabinetName != null)
                {
                    body["CabinetName"] = ExpressionConverter.ConvertO(__workflow_bodycabinetName);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentSecurity != null)
                {
                    body["DocumentSecurity"] = ExpressionConverter.ConvertO(__workflow_bodydocumentSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(__workflow_bodydrawerName);
                    bodypropCount++;
                }

                if (__workflow_bodyloginId != null)
                {
                    body["LoginId"] = ExpressionConverter.ConvertO(__workflow_bodyloginId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetUserDocSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo(Expression<Func<string>> bodyloginName, Expression<Func<string>> bodyuserType, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_bodyloginName = WorkflowExpression.Compile(bodyloginName, nameof(bodyloginName), required: true);
            var __workflow_bodyuserType = WorkflowExpression.Compile(bodyuserType, nameof(bodyuserType), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserInfoResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/getuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["LoginName"] = ExpressionConverter.ConvertO(__workflow_bodyloginName);
                bodypropCount++;
                body["UserType"] = ExpressionConverter.ConvertO(__workflow_bodyuserType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetLicensesResponse> GetLicenses(Expression<Func<licenseInput>> license = null, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_license = WorkflowExpression.Compile(license, nameof(license), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetLicensesResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/licenses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_license != null)
                    callPayload.Queries["license"] = ExpressionConverter.Convert(__workflow_license);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetLicensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ModifyUserResponse> ModifyUser(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyaccountExpiresDate = null, Expression<Func<string>> bodydisabledComments = null, Expression<Func<string>> bodyfullName = null, Expression<Func<string[]>> bodygroups = null, Expression<Func<string>> bodyisAccountExpires = null, Expression<Func<string>> bodyisAdvanceFlow = null, Expression<Func<string>> bodyisAllowAccessToReports = null, Expression<Func<string>> bodyisAllowOffline = null, Expression<Func<string>> bodyisChangeNextLogin = null, Expression<Func<string>> bodyisDisabled = null, Expression<Func<string>> bodyisFirmFlow = null, Expression<Func<string>> bodyisFirmFlowNotificationGroup = null, Expression<Func<string>> bodyisFirmFlowNotificationUser = null, Expression<Func<string>> bodyisMfa = null, Expression<Func<string>> bodyisUserAdministration = null, Expression<Func<string>> bodyisWorkflowManagerUser = null, Expression<Func<string>> bodylicenseType = null, Expression<Func<string>> bodyloginName = null, Expression<Func<string>> bodymanagerEmail = null, Expression<Func<string>> bodypassword = null, Expression<Func<bodyreportsInputItem[]>> bodyreports = null, Expression<Func<string>> bodyuploadLocation = null)
        {
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyaccountExpiresDate = WorkflowExpression.Compile(bodyaccountExpiresDate, nameof(bodyaccountExpiresDate), required: false);
            var __workflow_bodydisabledComments = WorkflowExpression.Compile(bodydisabledComments, nameof(bodydisabledComments), required: false);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodyisAccountExpires = WorkflowExpression.Compile(bodyisAccountExpires, nameof(bodyisAccountExpires), required: false);
            var __workflow_bodyisAdvanceFlow = WorkflowExpression.Compile(bodyisAdvanceFlow, nameof(bodyisAdvanceFlow), required: false);
            var __workflow_bodyisAllowAccessToReports = WorkflowExpression.Compile(bodyisAllowAccessToReports, nameof(bodyisAllowAccessToReports), required: false);
            var __workflow_bodyisAllowOffline = WorkflowExpression.Compile(bodyisAllowOffline, nameof(bodyisAllowOffline), required: false);
            var __workflow_bodyisChangeNextLogin = WorkflowExpression.Compile(bodyisChangeNextLogin, nameof(bodyisChangeNextLogin), required: false);
            var __workflow_bodyisDisabled = WorkflowExpression.Compile(bodyisDisabled, nameof(bodyisDisabled), required: false);
            var __workflow_bodyisFirmFlow = WorkflowExpression.Compile(bodyisFirmFlow, nameof(bodyisFirmFlow), required: false);
            var __workflow_bodyisFirmFlowNotificationGroup = WorkflowExpression.Compile(bodyisFirmFlowNotificationGroup, nameof(bodyisFirmFlowNotificationGroup), required: false);
            var __workflow_bodyisFirmFlowNotificationUser = WorkflowExpression.Compile(bodyisFirmFlowNotificationUser, nameof(bodyisFirmFlowNotificationUser), required: false);
            var __workflow_bodyisMfa = WorkflowExpression.Compile(bodyisMfa, nameof(bodyisMfa), required: false);
            var __workflow_bodyisUserAdministration = WorkflowExpression.Compile(bodyisUserAdministration, nameof(bodyisUserAdministration), required: false);
            var __workflow_bodyisWorkflowManagerUser = WorkflowExpression.Compile(bodyisWorkflowManagerUser, nameof(bodyisWorkflowManagerUser), required: false);
            var __workflow_bodylicenseType = WorkflowExpression.Compile(bodylicenseType, nameof(bodylicenseType), required: false);
            var __workflow_bodyloginName = WorkflowExpression.Compile(bodyloginName, nameof(bodyloginName), required: false);
            var __workflow_bodymanagerEmail = WorkflowExpression.Compile(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyreports = WorkflowExpression.Compile(bodyreports, nameof(bodyreports), required: false);
            var __workflow_bodyuploadLocation = WorkflowExpression.Compile(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            return new DeferredBodyAction<ModifyUserResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/modifyuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(__workflow_userType);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountExpiresDate != null)
                {
                    body["AccountExpiresDate"] = ExpressionConverter.ConvertO(__workflow_bodyaccountExpiresDate);
                    bodypropCount++;
                }

                if (__workflow_bodydisabledComments != null)
                {
                    body["DisabledComments"] = ExpressionConverter.ConvertO(__workflow_bodydisabledComments);
                    bodypropCount++;
                }

                if (__workflow_bodyfullName != null)
                {
                    body["FullName"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["Groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodyisAccountExpires != null)
                {
                    body["IsAccountExpires"] = ExpressionConverter.ConvertO(__workflow_bodyisAccountExpires);
                    bodypropCount++;
                }

                if (__workflow_bodyisAdvanceFlow != null)
                {
                    body["IsAdvanceFlow"] = ExpressionConverter.ConvertO(__workflow_bodyisAdvanceFlow);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllowAccessToReports != null)
                {
                    body["IsAllowAccessToReports"] = ExpressionConverter.ConvertO(__workflow_bodyisAllowAccessToReports);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllowOffline != null)
                {
                    body["IsAllowOffline"] = ExpressionConverter.ConvertO(__workflow_bodyisAllowOffline);
                    bodypropCount++;
                }

                if (__workflow_bodyisChangeNextLogin != null)
                {
                    body["IsChangeNextLogin"] = ExpressionConverter.ConvertO(__workflow_bodyisChangeNextLogin);
                    bodypropCount++;
                }

                if (__workflow_bodyisDisabled != null)
                {
                    body["IsDisabled"] = ExpressionConverter.ConvertO(__workflow_bodyisDisabled);
                    bodypropCount++;
                }

                if (__workflow_bodyisFirmFlow != null)
                {
                    body["IsFirmFlow"] = ExpressionConverter.ConvertO(__workflow_bodyisFirmFlow);
                    bodypropCount++;
                }

                if (__workflow_bodyisFirmFlowNotificationGroup != null)
                {
                    body["IsFirmFlowNotificationGroup"] = ExpressionConverter.ConvertO(__workflow_bodyisFirmFlowNotificationGroup);
                    bodypropCount++;
                }

                if (__workflow_bodyisFirmFlowNotificationUser != null)
                {
                    body["IsFirmFlowNotificationUser"] = ExpressionConverter.ConvertO(__workflow_bodyisFirmFlowNotificationUser);
                    bodypropCount++;
                }

                if (__workflow_bodyisMfa != null)
                {
                    body["IsMfa"] = ExpressionConverter.ConvertO(__workflow_bodyisMfa);
                    bodypropCount++;
                }

                if (__workflow_bodyisUserAdministration != null)
                {
                    body["IsUserAdministration"] = ExpressionConverter.ConvertO(__workflow_bodyisUserAdministration);
                    bodypropCount++;
                }

                if (__workflow_bodyisWorkflowManagerUser != null)
                {
                    body["IsWorkflowManagerUser"] = ExpressionConverter.ConvertO(__workflow_bodyisWorkflowManagerUser);
                    bodypropCount++;
                }

                if (__workflow_bodylicenseType != null)
                {
                    body["LicenseType"] = ExpressionConverter.ConvertO(__workflow_bodylicenseType);
                    bodypropCount++;
                }

                if (__workflow_bodyloginName != null)
                {
                    body["LoginName"] = ExpressionConverter.ConvertO(__workflow_bodyloginName);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerEmail != null)
                {
                    body["ManagerEmail"] = ExpressionConverter.ConvertO(__workflow_bodymanagerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(__workflow_bodyreports);
                    bodypropCount++;
                }

                if (__workflow_bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(__workflow_bodyuploadLocation);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModifyUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetPasswordPolicyResponse> GetPasswordPolicy(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetPasswordPolicyResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/passwordpolicy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetPasswordPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetUserPermissionsResponse> SetUserPermissions(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodycabinet = null, Expression<Func<string>> bodycabinetPermissionadd = null, Expression<Func<string>> bodycabinetPermissiondelete = null, Expression<Func<string>> bodycabinetPermissiondeny = null, Expression<Func<string>> bodycabinetPermissionedit = null, Expression<Func<string>> bodycabinetPermissionlookUp = null, Expression<Func<string>> bodycabinetPermissionread = null, Expression<Func<bodydrawerPermissionsInputItem[]>> bodydrawerPermissions = null, Expression<Func<string>> bodyloginId = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodycabinet = WorkflowExpression.Compile(bodycabinet, nameof(bodycabinet), required: false);
            var __workflow_bodycabinetPermissionadd = WorkflowExpression.Compile(bodycabinetPermissionadd, nameof(bodycabinetPermissionadd), required: false);
            var __workflow_bodycabinetPermissiondelete = WorkflowExpression.Compile(bodycabinetPermissiondelete, nameof(bodycabinetPermissiondelete), required: false);
            var __workflow_bodycabinetPermissiondeny = WorkflowExpression.Compile(bodycabinetPermissiondeny, nameof(bodycabinetPermissiondeny), required: false);
            var __workflow_bodycabinetPermissionedit = WorkflowExpression.Compile(bodycabinetPermissionedit, nameof(bodycabinetPermissionedit), required: false);
            var __workflow_bodycabinetPermissionlookUp = WorkflowExpression.Compile(bodycabinetPermissionlookUp, nameof(bodycabinetPermissionlookUp), required: false);
            var __workflow_bodycabinetPermissionread = WorkflowExpression.Compile(bodycabinetPermissionread, nameof(bodycabinetPermissionread), required: false);
            var __workflow_bodydrawerPermissions = WorkflowExpression.Compile(bodydrawerPermissions, nameof(bodydrawerPermissions), required: false);
            var __workflow_bodyloginId = WorkflowExpression.Compile(bodyloginId, nameof(bodyloginId), required: false);
            return new DeferredBodyAction<SetUserPermissionsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycabinet != null)
                {
                    body["Cabinet"] = ExpressionConverter.ConvertO(__workflow_bodycabinet);
                    bodypropCount++;
                }

                var cabinetPermissionObject = new JObject();
                var cabinetPermissionObjectpropCount = 0;
                if (__workflow_bodycabinetPermissionadd != null)
                {
                    cabinetPermissionObject["Add"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionadd);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissiondelete != null)
                {
                    cabinetPermissionObject["Delete"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissiondelete);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissiondeny != null)
                {
                    cabinetPermissionObject["Deny"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissiondeny);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissionedit != null)
                {
                    cabinetPermissionObject["Edit"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionedit);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissionlookUp != null)
                {
                    cabinetPermissionObject["LookUp"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionlookUp);
                    cabinetPermissionObjectpropCount++;
                }

                if (__workflow_bodycabinetPermissionread != null)
                {
                    cabinetPermissionObject["Read"] = ExpressionConverter.ConvertO(__workflow_bodycabinetPermissionread);
                    cabinetPermissionObjectpropCount++;
                }

                if (cabinetPermissionObjectpropCount > 0)
                {
                    body["CabinetPermission"] = cabinetPermissionObject;
                    bodypropCount++;
                }

                if (__workflow_bodydrawerPermissions != null)
                {
                    body["DrawerPermissions"] = ExpressionConverter.ConvertO(__workflow_bodydrawerPermissions);
                    bodypropCount++;
                }

                if (__workflow_bodyloginId != null)
                {
                    body["LoginId"] = ExpressionConverter.ConvertO(__workflow_bodyloginId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetUserPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetListOfReportsResponse> GetListOfReports(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetListOfReportsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetListOfReportsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUploadLocationResponse> GetUploadLocation(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUploadLocationResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/uploadlocations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetUploadLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserDocumentSecurityResponse> GetUserDocumentSecurity(Expression<Func<string>> loginId, Expression<Func<string>> cabinetName, Expression<Func<string>> drawerName, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_loginId = WorkflowExpression.Compile(loginId, nameof(loginId), required: true);
            var __workflow_cabinetName = WorkflowExpression.Compile(cabinetName, nameof(cabinetName), required: true);
            var __workflow_drawerName = WorkflowExpression.Compile(drawerName, nameof(drawerName), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserDocumentSecurityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/administration/user/{0}/{1}/{2}/documentsecurity", __workflow_loginId.WithUrlEncoding(1), __workflow_cabinetName.WithUrlEncoding(1), __workflow_drawerName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetUserDocumentSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserPermissionResponse> GetUserPermission(Expression<Func<string>> login, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_login = WorkflowExpression.Compile(login, nameof(login), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserPermissionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/administration/user/{0}/permissions", __workflow_login.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetUserPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUsersResponseItem[]> GetUsers(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUsersResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/administration/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(__workflow_userType);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetLookupListResponseItem[]> GetLookupList(Expression<Func<string>> drawerId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_drawerId = WorkflowExpression.Compile(drawerId, nameof(drawerId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetLookupListResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/administration/{0}/clients", __workflow_drawerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetLookupListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydrawerId = null, Expression<Func<bodyindexesInputItem[]>> bodyindexes = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydrawerId = WorkflowExpression.Compile(bodydrawerId, nameof(bodydrawerId), required: false);
            var __workflow_bodyindexes = WorkflowExpression.Compile(bodyindexes, nameof(bodyindexes), required: false);
            return new DeferredBodyAction<CreateDocumentResponse>(() =>
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(__workflow_bodydrawerId);
                    bodypropCount++;
                }

                if (__workflow_bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(__workflow_bodyindexes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CopyDocumentResponseItem[]> CopyDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> bodydocumentIds = null, Expression<Func<bodyindexValuesInputItem[]>> bodyindexValues = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydocumentIds = WorkflowExpression.Compile(bodydocumentIds, nameof(bodydocumentIds), required: false);
            var __workflow_bodyindexValues = WorkflowExpression.Compile(bodyindexValues, nameof(bodyindexValues), required: false);
            return new DeferredBodyAction<CopyDocumentResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/copy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentIds != null)
                {
                    body["DocumentIds"] = ExpressionConverter.ConvertO(__workflow_bodydocumentIds);
                    bodypropCount++;
                }

                if (__workflow_bodyindexValues != null)
                {
                    body["IndexValues"] = ExpressionConverter.ConvertO(__workflow_bodyindexValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CopyDocumentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentStatusResponseItem[]> GetDocumentStatus(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetDocumentStatusResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetDocumentStatusResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<string> MergePDF(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/v1/documents/mergePDFs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentReindexResponseItem[]> DocumentReindex(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> bodydocumentIds = null, Expression<Func<bodyindexValuesInputItem[]>> bodyindexValues = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydocumentIds = WorkflowExpression.Compile(bodydocumentIds, nameof(bodydocumentIds), required: false);
            var __workflow_bodyindexValues = WorkflowExpression.Compile(bodyindexValues, nameof(bodyindexValues), required: false);
            return new DeferredBodyAction<DocumentReindexResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/reindex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentIds != null)
                {
                    body["DocumentIds"] = ExpressionConverter.ConvertO(__workflow_bodydocumentIds);
                    bodypropCount++;
                }

                if (__workflow_bodyindexValues != null)
                {
                    body["IndexValues"] = ExpressionConverter.ConvertO(__workflow_bodyindexValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocumentReindexResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentSearchResponse> DocumentSearch(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydrawerId = null, Expression<Func<bodyfilterindexValuesInputItem[]>> bodyfilterindexValues = null, Expression<Func<int>> bodynumberOfRows = null, Expression<Func<int>> bodypageNumber = null, Expression<Func<string>> bodysortField = null, Expression<Func<bodysortOrderInput>> bodysortOrder = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydrawerId = WorkflowExpression.Compile(bodydrawerId, nameof(bodydrawerId), required: false);
            var __workflow_bodyfilterindexValues = WorkflowExpression.Compile(bodyfilterindexValues, nameof(bodyfilterindexValues), required: false);
            var __workflow_bodynumberOfRows = WorkflowExpression.Compile(bodynumberOfRows, nameof(bodynumberOfRows), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodysortField = WorkflowExpression.Compile(bodysortField, nameof(bodysortField), required: false);
            var __workflow_bodysortOrder = WorkflowExpression.Compile(bodysortOrder, nameof(bodysortOrder), required: false);
            return new DeferredBodyAction<DocumentSearchResponse>(() =>
            {
                var apiCallPath = "/api/v1/documents/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(__workflow_bodydrawerId);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterindexValues != null)
                {
                    filterObject["IndexValues"] = ExpressionConverter.ConvertO(__workflow_bodyfilterindexValues);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfRows != null)
                {
                    body["NumberOfRows"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfRows);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysortField != null)
                {
                    body["SortField"] = ExpressionConverter.ConvertO(__workflow_bodysortField);
                    bodypropCount++;
                }

                if (__workflow_bodysortOrder != null)
                {
                    body["SortOrder"] = ExpressionConverter.ConvertO(__workflow_bodysortOrder);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocumentSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TaxsortDocumentResponseItem[]> TaxsortDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaxsortDocumentResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/taxsort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaxsortDocumentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentDeleteResponseItem[]> DocumentDelete(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<DocumentDeleteResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/delete", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<DocumentDeleteResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IWorkflowAction GetDocument(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/file", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentHistoryResponse> GetDocumentHistory(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDocumentHistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/history", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetDocumentHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentIndexesResponseItem[]> GetDocumentIndexes(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDocumentIndexesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/indexes", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetDocumentIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<PublishDocumentStatusResponseItem[]> PublishDocumentStatus(Expression<Func<string>> documentId, Expression<Func<string>> bodyisPublished, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyisPublished = WorkflowExpression.Compile(bodyisPublished, nameof(bodyisPublished), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<PublishDocumentStatusResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/status", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["IsPublished"] = ExpressionConverter.ConvertO(__workflow_bodyisPublished);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PublishDocumentStatusResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDrawersResponseItem[]> GetDrawers(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDrawersResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/drawers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetDrawersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDrawerIndexesResponseItem[]> GetDrawerIndexes(Expression<Func<string>> drawerId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_drawerId = WorkflowExpression.Compile(drawerId, nameof(drawerId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDrawerIndexesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/drawers/{0}/indexes", __workflow_drawerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetDrawerIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetFirmFlowDeliverableReportResponse> GetFirmFlowDeliverableReport(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyaccountable = null, Expression<Func<string>> bodyassignedOn = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodyassignmentHistory = null, Expression<Func<string>> bodycompletedBy = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodycurrentDueDate = null, Expression<Func<string>> bodycurrentStep = null, Expression<Func<string>> bodydateExtended = null, Expression<Func<string>> bodydaysAtStep = null, Expression<Func<string>> bodydaysBetweenRoutings = null, Expression<Func<string>> bodydrawerId = null, Expression<Func<string>> bodyengagementType = null, Expression<Func<string>> bodyinProcessOnly = null, Expression<Func<string[]>> bodyindexes = null, Expression<Func<string[]>> bodyinformationFields = null, Expression<Func<string>> bodyoriginalDueDate = null, Expression<Func<string>> bodypIC = null, Expression<Func<string>> bodypageNumber = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyreceivedFrom = null, Expression<Func<string>> bodyreceivedOn = null, Expression<Func<string>> bodyresponsible = null, Expression<Func<string>> bodyroutingDetails = null, Expression<Func<string>> bodysentOn = null, Expression<Func<string>> bodysentTo = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodytotalDaysAtStep = null, Expression<Func<string>> bodytotalDaysInProcess = null, Expression<Func<string>> bodyworkflow = null, Expression<Func<string>> bodyworkflowDescription = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyaccountable = WorkflowExpression.Compile(bodyaccountable, nameof(bodyaccountable), required: false);
            var __workflow_bodyassignedOn = WorkflowExpression.Compile(bodyassignedOn, nameof(bodyassignedOn), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodyassignmentHistory = WorkflowExpression.Compile(bodyassignmentHistory, nameof(bodyassignmentHistory), required: false);
            var __workflow_bodycompletedBy = WorkflowExpression.Compile(bodycompletedBy, nameof(bodycompletedBy), required: false);
            var __workflow_bodycompletedOn = WorkflowExpression.Compile(bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodycurrentDueDate = WorkflowExpression.Compile(bodycurrentDueDate, nameof(bodycurrentDueDate), required: false);
            var __workflow_bodycurrentStep = WorkflowExpression.Compile(bodycurrentStep, nameof(bodycurrentStep), required: false);
            var __workflow_bodydateExtended = WorkflowExpression.Compile(bodydateExtended, nameof(bodydateExtended), required: false);
            var __workflow_bodydaysAtStep = WorkflowExpression.Compile(bodydaysAtStep, nameof(bodydaysAtStep), required: false);
            var __workflow_bodydaysBetweenRoutings = WorkflowExpression.Compile(bodydaysBetweenRoutings, nameof(bodydaysBetweenRoutings), required: false);
            var __workflow_bodydrawerId = WorkflowExpression.Compile(bodydrawerId, nameof(bodydrawerId), required: false);
            var __workflow_bodyengagementType = WorkflowExpression.Compile(bodyengagementType, nameof(bodyengagementType), required: false);
            var __workflow_bodyinProcessOnly = WorkflowExpression.Compile(bodyinProcessOnly, nameof(bodyinProcessOnly), required: false);
            var __workflow_bodyindexes = WorkflowExpression.Compile(bodyindexes, nameof(bodyindexes), required: false);
            var __workflow_bodyinformationFields = WorkflowExpression.Compile(bodyinformationFields, nameof(bodyinformationFields), required: false);
            var __workflow_bodyoriginalDueDate = WorkflowExpression.Compile(bodyoriginalDueDate, nameof(bodyoriginalDueDate), required: false);
            var __workflow_bodypIC = WorkflowExpression.Compile(bodypIC, nameof(bodypIC), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyreceivedFrom = WorkflowExpression.Compile(bodyreceivedFrom, nameof(bodyreceivedFrom), required: false);
            var __workflow_bodyreceivedOn = WorkflowExpression.Compile(bodyreceivedOn, nameof(bodyreceivedOn), required: false);
            var __workflow_bodyresponsible = WorkflowExpression.Compile(bodyresponsible, nameof(bodyresponsible), required: false);
            var __workflow_bodyroutingDetails = WorkflowExpression.Compile(bodyroutingDetails, nameof(bodyroutingDetails), required: false);
            var __workflow_bodysentOn = WorkflowExpression.Compile(bodysentOn, nameof(bodysentOn), required: false);
            var __workflow_bodysentTo = WorkflowExpression.Compile(bodysentTo, nameof(bodysentTo), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytotalDaysAtStep = WorkflowExpression.Compile(bodytotalDaysAtStep, nameof(bodytotalDaysAtStep), required: false);
            var __workflow_bodytotalDaysInProcess = WorkflowExpression.Compile(bodytotalDaysInProcess, nameof(bodytotalDaysInProcess), required: false);
            var __workflow_bodyworkflow = WorkflowExpression.Compile(bodyworkflow, nameof(bodyworkflow), required: false);
            var __workflow_bodyworkflowDescription = WorkflowExpression.Compile(bodyworkflowDescription, nameof(bodyworkflowDescription), required: false);
            return new DeferredBodyAction<GetFirmFlowDeliverableReportResponse>(() =>
            {
                var apiCallPath = "/api/v1/firmflowreports/TrackingReportByDeliverable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountable != null)
                {
                    body["Accountable"] = ExpressionConverter.ConvertO(__workflow_bodyaccountable);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedOn != null)
                {
                    body["AssignedOn"] = ExpressionConverter.ConvertO(__workflow_bodyassignedOn);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentHistory != null)
                {
                    body["AssignmentHistory"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentHistory);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedBy != null)
                {
                    body["CompletedBy"] = ExpressionConverter.ConvertO(__workflow_bodycompletedBy);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedOn != null)
                {
                    body["CompletedOn"] = ExpressionConverter.ConvertO(__workflow_bodycompletedOn);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentDueDate != null)
                {
                    body["CurrentDueDate"] = ExpressionConverter.ConvertO(__workflow_bodycurrentDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(__workflow_bodycurrentStep);
                    bodypropCount++;
                }

                if (__workflow_bodydateExtended != null)
                {
                    body["DateExtended"] = ExpressionConverter.ConvertO(__workflow_bodydateExtended);
                    bodypropCount++;
                }

                if (__workflow_bodydaysAtStep != null)
                {
                    body["DaysAtStep"] = ExpressionConverter.ConvertO(__workflow_bodydaysAtStep);
                    bodypropCount++;
                }

                if (__workflow_bodydaysBetweenRoutings != null)
                {
                    body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(__workflow_bodydaysBetweenRoutings);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(__workflow_bodydrawerId);
                    bodypropCount++;
                }

                if (__workflow_bodyengagementType != null)
                {
                    body["EngagementType"] = ExpressionConverter.ConvertO(__workflow_bodyengagementType);
                    bodypropCount++;
                }

                if (__workflow_bodyinProcessOnly != null)
                {
                    body["InProcessOnly"] = ExpressionConverter.ConvertO(__workflow_bodyinProcessOnly);
                    bodypropCount++;
                }

                if (__workflow_bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(__workflow_bodyindexes);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationFields != null)
                {
                    body["InformationFields"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFields);
                    bodypropCount++;
                }

                if (__workflow_bodyoriginalDueDate != null)
                {
                    body["OriginalDueDate"] = ExpressionConverter.ConvertO(__workflow_bodyoriginalDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodypIC != null)
                {
                    body["PIC"] = ExpressionConverter.ConvertO(__workflow_bodypIC);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFrom != null)
                {
                    body["ReceivedFrom"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFrom);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedOn != null)
                {
                    body["ReceivedOn"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedOn);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsible != null)
                {
                    body["Responsible"] = ExpressionConverter.ConvertO(__workflow_bodyresponsible);
                    bodypropCount++;
                }

                if (__workflow_bodyroutingDetails != null)
                {
                    body["RoutingDetails"] = ExpressionConverter.ConvertO(__workflow_bodyroutingDetails);
                    bodypropCount++;
                }

                if (__workflow_bodysentOn != null)
                {
                    body["SentOn"] = ExpressionConverter.ConvertO(__workflow_bodysentOn);
                    bodypropCount++;
                }

                if (__workflow_bodysentTo != null)
                {
                    body["SentTo"] = ExpressionConverter.ConvertO(__workflow_bodysentTo);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodytotalDaysAtStep != null)
                {
                    body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(__workflow_bodytotalDaysAtStep);
                    bodypropCount++;
                }

                if (__workflow_bodytotalDaysInProcess != null)
                {
                    body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(__workflow_bodytotalDaysInProcess);
                    bodypropCount++;
                }

                if (__workflow_bodyworkflow != null)
                {
                    body["Workflow"] = ExpressionConverter.ConvertO(__workflow_bodyworkflow);
                    bodypropCount++;
                }

                if (__workflow_bodyworkflowDescription != null)
                {
                    body["WorkflowDescription"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetFirmFlowDeliverableReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ValidateIndexesResponse> ValidateIndexes(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydrawerId = null, Expression<Func<bodyindexesInputItem[]>> bodyindexes = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydrawerId = WorkflowExpression.Compile(bodydrawerId, nameof(bodydrawerId), required: false);
            var __workflow_bodyindexes = WorkflowExpression.Compile(bodyindexes, nameof(bodyindexes), required: false);
            return new DeferredBodyAction<ValidateIndexesResponse>(() =>
            {
                var apiCallPath = "/api/v1/indexes/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(__workflow_bodydrawerId);
                    bodypropCount++;
                }

                if (__workflow_bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(__workflow_bodyindexes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidateIndexesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDynamicRulesForIndexResponseItem[]> GetDynamicRulesForIndex(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDynamicRulesForIndexResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/indexes/{0}/dynamicrules", __workflow_indexId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetDynamicRulesForIndexResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<IndexLookupListFindResponseItem[]> IndexLookupListFind(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null, Expression<Func<bodyactionTypeInput>> bodyactionType = null, Expression<Func<int>> bodycount = null, Expression<Func<string>> bodyindexValue = null, Expression<Func<bodysearchTypeInput>> bodysearchType = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyactionType = WorkflowExpression.Compile(bodyactionType, nameof(bodyactionType), required: false);
            var __workflow_bodycount = WorkflowExpression.Compile(bodycount, nameof(bodycount), required: false);
            var __workflow_bodyindexValue = WorkflowExpression.Compile(bodyindexValue, nameof(bodyindexValue), required: false);
            var __workflow_bodysearchType = WorkflowExpression.Compile(bodysearchType, nameof(bodysearchType), required: false);
            return new DeferredBodyAction<IndexLookupListFindResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/indexes/{0}/lookuplist", __workflow_indexId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyactionType != null)
                {
                    body["ActionType"] = ExpressionConverter.ConvertO(__workflow_bodyactionType);
                    bodypropCount++;
                }

                if (__workflow_bodycount != null)
                {
                    body["Count"] = ExpressionConverter.ConvertO(__workflow_bodycount);
                    bodypropCount++;
                }

                if (__workflow_bodyindexValue != null)
                {
                    body["IndexValue"] = ExpressionConverter.ConvertO(__workflow_bodyindexValue);
                    bodypropCount++;
                }

                if (__workflow_bodysearchType != null)
                {
                    body["SearchType"] = ExpressionConverter.ConvertO(__workflow_bodysearchType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IndexLookupListFindResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetListTypeIndexDataResponseItem[]> GetListTypeIndexData(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetListTypeIndexDataResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/indexes/{0}/values", __workflow_indexId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetListTypeIndexDataResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetChildIndexesResponseItem[]> GetChildIndexes(Expression<Func<string>> indexId, Expression<Func<string>> listId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetChildIndexesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/indexes/{0}/values/childindexlist/{1}", __workflow_indexId.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<GetChildIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<LoginResponse> Login(Expression<Func<string>> bodyloginName, Expression<Func<string>> bodypassword)
        {
            var __workflow_bodyloginName = WorkflowExpression.Compile(bodyloginName, nameof(bodyloginName), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            return new DeferredBodyAction<LoginResponse>(() =>
            {
                var apiCallPath = "/api/v1/user/login";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["LoginName"] = ExpressionConverter.ConvertO(__workflow_bodyloginName);
                bodypropCount++;
                body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<LogoutResponse> Logout(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<LogoutResponse>(() =>
            {
                var apiCallPath = "/api/v1/user/logout";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<LogoutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<bool> ValidateToken(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/api/v1/user/validate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateWorkflowResponse> CreateWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydrawer = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodyfolderId = null, Expression<Func<string>> bodyheadersclientName = null, Expression<Func<string>> bodyheadersclientNumber = null, Expression<Func<string>> bodyheadersengagementType = null, Expression<Func<string>> bodyheaderspIC = null, Expression<Func<string>> bodyheadersyear = null, Expression<Func<string>> bodyheadersperiodEnd = null, Expression<Func<string>> bodyfilingworkflowName = null, Expression<Func<string>> bodyfilingdescription = null, Expression<Func<string>> bodyfilingstatusName = null, Expression<Func<string>> bodydeliverableaction = null, Expression<Func<string>> bodydeliverablecurrentduedate = null, Expression<Func<string>> bodydeliverableoriginalduedate = null, Expression<Func<string>> bodydeliverableform = null, Expression<Func<string>> bodydeliveryInstructionsdelivery = null, Expression<Func<string>> bodydeliveryInstructionsdestination = null, Expression<Func<string>> bodydeliveryInstructionssourceDocument = null, Expression<Func<string>> bodynotesaction = null, Expression<Func<string>> bodynotesnoteType = null, Expression<Func<string>> bodynotesnote = null, Expression<Func<string>> bodyinformationFieldsname = null, Expression<Func<string>> bodyinformationFieldsvalue = null, Expression<Func<string>> bodyroutingSummaryresponsibleField = null, Expression<Func<string>> bodyroutingSummaryvalue = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydrawer = WorkflowExpression.Compile(bodydrawer, nameof(bodydrawer), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: false);
            var __workflow_bodyheadersclientName = WorkflowExpression.Compile(bodyheadersclientName, nameof(bodyheadersclientName), required: false);
            var __workflow_bodyheadersclientNumber = WorkflowExpression.Compile(bodyheadersclientNumber, nameof(bodyheadersclientNumber), required: false);
            var __workflow_bodyheadersengagementType = WorkflowExpression.Compile(bodyheadersengagementType, nameof(bodyheadersengagementType), required: false);
            var __workflow_bodyheaderspIC = WorkflowExpression.Compile(bodyheaderspIC, nameof(bodyheaderspIC), required: false);
            var __workflow_bodyheadersyear = WorkflowExpression.Compile(bodyheadersyear, nameof(bodyheadersyear), required: false);
            var __workflow_bodyheadersperiodEnd = WorkflowExpression.Compile(bodyheadersperiodEnd, nameof(bodyheadersperiodEnd), required: false);
            var __workflow_bodyfilingworkflowName = WorkflowExpression.Compile(bodyfilingworkflowName, nameof(bodyfilingworkflowName), required: false);
            var __workflow_bodyfilingdescription = WorkflowExpression.Compile(bodyfilingdescription, nameof(bodyfilingdescription), required: false);
            var __workflow_bodyfilingstatusName = WorkflowExpression.Compile(bodyfilingstatusName, nameof(bodyfilingstatusName), required: false);
            var __workflow_bodydeliverableaction = WorkflowExpression.Compile(bodydeliverableaction, nameof(bodydeliverableaction), required: false);
            var __workflow_bodydeliverablecurrentduedate = WorkflowExpression.Compile(bodydeliverablecurrentduedate, nameof(bodydeliverablecurrentduedate), required: false);
            var __workflow_bodydeliverableoriginalduedate = WorkflowExpression.Compile(bodydeliverableoriginalduedate, nameof(bodydeliverableoriginalduedate), required: false);
            var __workflow_bodydeliverableform = WorkflowExpression.Compile(bodydeliverableform, nameof(bodydeliverableform), required: false);
            var __workflow_bodydeliveryInstructionsdelivery = WorkflowExpression.Compile(bodydeliveryInstructionsdelivery, nameof(bodydeliveryInstructionsdelivery), required: false);
            var __workflow_bodydeliveryInstructionsdestination = WorkflowExpression.Compile(bodydeliveryInstructionsdestination, nameof(bodydeliveryInstructionsdestination), required: false);
            var __workflow_bodydeliveryInstructionssourceDocument = WorkflowExpression.Compile(bodydeliveryInstructionssourceDocument, nameof(bodydeliveryInstructionssourceDocument), required: false);
            var __workflow_bodynotesaction = WorkflowExpression.Compile(bodynotesaction, nameof(bodynotesaction), required: false);
            var __workflow_bodynotesnoteType = WorkflowExpression.Compile(bodynotesnoteType, nameof(bodynotesnoteType), required: false);
            var __workflow_bodynotesnote = WorkflowExpression.Compile(bodynotesnote, nameof(bodynotesnote), required: false);
            var __workflow_bodyinformationFieldsname = WorkflowExpression.Compile(bodyinformationFieldsname, nameof(bodyinformationFieldsname), required: false);
            var __workflow_bodyinformationFieldsvalue = WorkflowExpression.Compile(bodyinformationFieldsvalue, nameof(bodyinformationFieldsvalue), required: false);
            var __workflow_bodyroutingSummaryresponsibleField = WorkflowExpression.Compile(bodyroutingSummaryresponsibleField, nameof(bodyroutingSummaryresponsibleField), required: false);
            var __workflow_bodyroutingSummaryvalue = WorkflowExpression.Compile(bodyroutingSummaryvalue, nameof(bodyroutingSummaryvalue), required: false);
            return new DeferredBodyAction<CreateWorkflowResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/CreateWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydrawer != null)
                {
                    body["Drawer"] = ExpressionConverter.ConvertO(__workflow_bodydrawer);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodyfolderId != null)
                {
                    body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (__workflow_bodyheadersclientName != null)
                {
                    headersObject["ClientName"] = ExpressionConverter.ConvertO(__workflow_bodyheadersclientName);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersclientNumber != null)
                {
                    headersObject["ClientNumber"] = ExpressionConverter.ConvertO(__workflow_bodyheadersclientNumber);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersengagementType != null)
                {
                    headersObject["EngagementType"] = ExpressionConverter.ConvertO(__workflow_bodyheadersengagementType);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheaderspIC != null)
                {
                    headersObject["PIC"] = ExpressionConverter.ConvertO(__workflow_bodyheaderspIC);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersyear != null)
                {
                    headersObject["Year"] = ExpressionConverter.ConvertO(__workflow_bodyheadersyear);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersperiodEnd != null)
                {
                    headersObject["PeriodEnd"] = ExpressionConverter.ConvertO(__workflow_bodyheadersperiodEnd);
                    headersObjectpropCount++;
                }

                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                var filingObject = new JObject();
                var filingObjectpropCount = 0;
                if (__workflow_bodyfilingworkflowName != null)
                {
                    filingObject["workflowName"] = ExpressionConverter.ConvertO(__workflow_bodyfilingworkflowName);
                    filingObjectpropCount++;
                }

                if (__workflow_bodyfilingdescription != null)
                {
                    filingObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyfilingdescription);
                    filingObjectpropCount++;
                }

                if (__workflow_bodyfilingstatusName != null)
                {
                    filingObject["statusName"] = ExpressionConverter.ConvertO(__workflow_bodyfilingstatusName);
                    filingObjectpropCount++;
                }

                if (filingObjectpropCount > 0)
                {
                    body["filing"] = filingObject;
                    bodypropCount++;
                }

                var deliverableObject = new JObject();
                var deliverableObjectpropCount = 0;
                if (__workflow_bodydeliverableaction != null)
                {
                    deliverableObject["action"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableaction);
                    deliverableObjectpropCount++;
                }

                if (__workflow_bodydeliverablecurrentduedate != null)
                {
                    deliverableObject["currentduedate"] = ExpressionConverter.ConvertO(__workflow_bodydeliverablecurrentduedate);
                    deliverableObjectpropCount++;
                }

                if (__workflow_bodydeliverableoriginalduedate != null)
                {
                    deliverableObject["originalduedate"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableoriginalduedate);
                    deliverableObjectpropCount++;
                }

                if (__workflow_bodydeliverableform != null)
                {
                    deliverableObject["form"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableform);
                    deliverableObjectpropCount++;
                }

                if (deliverableObjectpropCount > 0)
                {
                    body["deliverable"] = deliverableObject;
                    bodypropCount++;
                }

                var deliveryInstructionsObject = new JObject();
                var deliveryInstructionsObjectpropCount = 0;
                if (__workflow_bodydeliveryInstructionsdelivery != null)
                {
                    deliveryInstructionsObject["Delivery"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryInstructionsdelivery);
                    deliveryInstructionsObjectpropCount++;
                }

                if (__workflow_bodydeliveryInstructionsdestination != null)
                {
                    deliveryInstructionsObject["Destination"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryInstructionsdestination);
                    deliveryInstructionsObjectpropCount++;
                }

                if (__workflow_bodydeliveryInstructionssourceDocument != null)
                {
                    deliveryInstructionsObject["sourceDocument"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryInstructionssourceDocument);
                    deliveryInstructionsObjectpropCount++;
                }

                if (deliveryInstructionsObjectpropCount > 0)
                {
                    body["DeliveryInstructions"] = deliveryInstructionsObject;
                    bodypropCount++;
                }

                var notesObject = new JObject();
                var notesObjectpropCount = 0;
                if (__workflow_bodynotesaction != null)
                {
                    notesObject["action"] = ExpressionConverter.ConvertO(__workflow_bodynotesaction);
                    notesObjectpropCount++;
                }

                if (__workflow_bodynotesnoteType != null)
                {
                    notesObject["noteType"] = ExpressionConverter.ConvertO(__workflow_bodynotesnoteType);
                    notesObjectpropCount++;
                }

                if (__workflow_bodynotesnote != null)
                {
                    notesObject["note"] = ExpressionConverter.ConvertO(__workflow_bodynotesnote);
                    notesObjectpropCount++;
                }

                if (notesObjectpropCount > 0)
                {
                    body["notes"] = notesObject;
                    bodypropCount++;
                }

                var informationFieldsObject = new JObject();
                var informationFieldsObjectpropCount = 0;
                if (__workflow_bodyinformationFieldsname != null)
                {
                    informationFieldsObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFieldsname);
                    informationFieldsObjectpropCount++;
                }

                if (__workflow_bodyinformationFieldsvalue != null)
                {
                    informationFieldsObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFieldsvalue);
                    informationFieldsObjectpropCount++;
                }

                if (informationFieldsObjectpropCount > 0)
                {
                    body["informationFields"] = informationFieldsObject;
                    bodypropCount++;
                }

                var routingSummaryObject = new JObject();
                var routingSummaryObjectpropCount = 0;
                if (__workflow_bodyroutingSummaryresponsibleField != null)
                {
                    routingSummaryObject["ResponsibleField"] = ExpressionConverter.ConvertO(__workflow_bodyroutingSummaryresponsibleField);
                    routingSummaryObjectpropCount++;
                }

                if (__workflow_bodyroutingSummaryvalue != null)
                {
                    routingSummaryObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyroutingSummaryvalue);
                    routingSummaryObjectpropCount++;
                }

                if (routingSummaryObjectpropCount > 0)
                {
                    body["RoutingSummary"] = routingSummaryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteMasterDeliverableResponseItem[]> DeleteMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodydrawerName = null, Expression<Func<string[]>> bodydeliverableNames = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodydrawerName = WorkflowExpression.Compile(bodydrawerName, nameof(bodydrawerName), required: false);
            var __workflow_bodydeliverableNames = WorkflowExpression.Compile(bodydeliverableNames, nameof(bodydeliverableNames), required: false);
            return new DeferredBodyAction<DeleteMasterDeliverableResponseItem[]>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/DeleteDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(__workflow_bodydrawerName);
                    bodypropCount++;
                }

                if (__workflow_bodydeliverableNames != null)
                {
                    body["DeliverableNames"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableNames);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteMasterDeliverableResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteWorkflowsResponse> DeleteWorkflows(Expression<Func<string>> xAuthorization = null, Expression<Func<int[]>> bodyfilingId = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyfilingId = WorkflowExpression.Compile(bodyfilingId, nameof(bodyfilingId), required: false);
            return new DeferredBodyAction<DeleteWorkflowsResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/DeleteWorkflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfilingId != null)
                {
                    body["filingId"] = ExpressionConverter.ConvertO(__workflow_bodyfilingId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteWorkflowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<EditMasterDeliverableResponse> EditMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodycurrentdeliverableName = null, Expression<Func<string>> bodyupdatedeliverableName = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyfirstExtension = null, Expression<Func<string>> bodysecondExtension = null, Expression<Func<string>> bodythirdExtension = null, Expression<Func<string>> bodycalenderOrFiscal = null, Expression<Func<int>> bodyextension = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodydrawerName = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodycurrentdeliverableName = WorkflowExpression.Compile(bodycurrentdeliverableName, nameof(bodycurrentdeliverableName), required: false);
            var __workflow_bodyupdatedeliverableName = WorkflowExpression.Compile(bodyupdatedeliverableName, nameof(bodyupdatedeliverableName), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyfirstExtension = WorkflowExpression.Compile(bodyfirstExtension, nameof(bodyfirstExtension), required: false);
            var __workflow_bodysecondExtension = WorkflowExpression.Compile(bodysecondExtension, nameof(bodysecondExtension), required: false);
            var __workflow_bodythirdExtension = WorkflowExpression.Compile(bodythirdExtension, nameof(bodythirdExtension), required: false);
            var __workflow_bodycalenderOrFiscal = WorkflowExpression.Compile(bodycalenderOrFiscal, nameof(bodycalenderOrFiscal), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodydrawerName = WorkflowExpression.Compile(bodydrawerName, nameof(bodydrawerName), required: false);
            return new DeferredBodyAction<EditMasterDeliverableResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/UpdateDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycurrentdeliverableName != null)
                {
                    body["currentdeliverableName"] = ExpressionConverter.ConvertO(__workflow_bodycurrentdeliverableName);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedeliverableName != null)
                {
                    body["updatedeliverableName"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedeliverableName);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstExtension != null)
                {
                    body["firstExtension"] = ExpressionConverter.ConvertO(__workflow_bodyfirstExtension);
                    bodypropCount++;
                }

                if (__workflow_bodysecondExtension != null)
                {
                    body["secondExtension"] = ExpressionConverter.ConvertO(__workflow_bodysecondExtension);
                    bodypropCount++;
                }

                if (__workflow_bodythirdExtension != null)
                {
                    body["thirdExtension"] = ExpressionConverter.ConvertO(__workflow_bodythirdExtension);
                    bodypropCount++;
                }

                if (__workflow_bodycalenderOrFiscal != null)
                {
                    body["calenderOrFiscal"] = ExpressionConverter.ConvertO(__workflow_bodycalenderOrFiscal);
                    bodypropCount++;
                }

                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["serviceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerName != null)
                {
                    body["drawerName"] = ExpressionConverter.ConvertO(__workflow_bodydrawerName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EditMasterDeliverableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<EditWorkflowResponse> EditWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<int>> bodyfilingId = null, Expression<Func<string>> bodyheadersclientName = null, Expression<Func<string>> bodyheadersclientNumber = null, Expression<Func<string>> bodyheadersengagementType = null, Expression<Func<string>> bodyheaderspIC = null, Expression<Func<string>> bodyheadersyear = null, Expression<Func<string>> bodyheadersperiodEnd = null, Expression<Func<string>> bodydeliverableaction = null, Expression<Func<string>> bodydeliverablecurrentduedate = null, Expression<Func<string>> bodydeliverableoriginalduedate = null, Expression<Func<string>> bodydeliverableform = null, Expression<Func<string>> bodynotesaction = null, Expression<Func<string>> bodynotesnoteType = null, Expression<Func<string[]>> bodynotesnoteid = null, Expression<Func<string>> bodynotesnote = null, Expression<Func<string>> bodyinformationFieldsname = null, Expression<Func<string>> bodyinformationFieldsvalue = null, Expression<Func<string>> bodydeliveryInstructionsdelivery = null, Expression<Func<string>> bodydeliveryInstructionsdestination = null, Expression<Func<string>> bodydeliveryInstructionssourceDocument = null, Expression<Func<string>> bodyroutingSummaryresponsibleField = null, Expression<Func<string>> bodyroutingSummaryvalue = null, Expression<Func<bool>> bodyreindexDocs = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyfilingId = WorkflowExpression.Compile(bodyfilingId, nameof(bodyfilingId), required: false);
            var __workflow_bodyheadersclientName = WorkflowExpression.Compile(bodyheadersclientName, nameof(bodyheadersclientName), required: false);
            var __workflow_bodyheadersclientNumber = WorkflowExpression.Compile(bodyheadersclientNumber, nameof(bodyheadersclientNumber), required: false);
            var __workflow_bodyheadersengagementType = WorkflowExpression.Compile(bodyheadersengagementType, nameof(bodyheadersengagementType), required: false);
            var __workflow_bodyheaderspIC = WorkflowExpression.Compile(bodyheaderspIC, nameof(bodyheaderspIC), required: false);
            var __workflow_bodyheadersyear = WorkflowExpression.Compile(bodyheadersyear, nameof(bodyheadersyear), required: false);
            var __workflow_bodyheadersperiodEnd = WorkflowExpression.Compile(bodyheadersperiodEnd, nameof(bodyheadersperiodEnd), required: false);
            var __workflow_bodydeliverableaction = WorkflowExpression.Compile(bodydeliverableaction, nameof(bodydeliverableaction), required: false);
            var __workflow_bodydeliverablecurrentduedate = WorkflowExpression.Compile(bodydeliverablecurrentduedate, nameof(bodydeliverablecurrentduedate), required: false);
            var __workflow_bodydeliverableoriginalduedate = WorkflowExpression.Compile(bodydeliverableoriginalduedate, nameof(bodydeliverableoriginalduedate), required: false);
            var __workflow_bodydeliverableform = WorkflowExpression.Compile(bodydeliverableform, nameof(bodydeliverableform), required: false);
            var __workflow_bodynotesaction = WorkflowExpression.Compile(bodynotesaction, nameof(bodynotesaction), required: false);
            var __workflow_bodynotesnoteType = WorkflowExpression.Compile(bodynotesnoteType, nameof(bodynotesnoteType), required: false);
            var __workflow_bodynotesnoteid = WorkflowExpression.Compile(bodynotesnoteid, nameof(bodynotesnoteid), required: false);
            var __workflow_bodynotesnote = WorkflowExpression.Compile(bodynotesnote, nameof(bodynotesnote), required: false);
            var __workflow_bodyinformationFieldsname = WorkflowExpression.Compile(bodyinformationFieldsname, nameof(bodyinformationFieldsname), required: false);
            var __workflow_bodyinformationFieldsvalue = WorkflowExpression.Compile(bodyinformationFieldsvalue, nameof(bodyinformationFieldsvalue), required: false);
            var __workflow_bodydeliveryInstructionsdelivery = WorkflowExpression.Compile(bodydeliveryInstructionsdelivery, nameof(bodydeliveryInstructionsdelivery), required: false);
            var __workflow_bodydeliveryInstructionsdestination = WorkflowExpression.Compile(bodydeliveryInstructionsdestination, nameof(bodydeliveryInstructionsdestination), required: false);
            var __workflow_bodydeliveryInstructionssourceDocument = WorkflowExpression.Compile(bodydeliveryInstructionssourceDocument, nameof(bodydeliveryInstructionssourceDocument), required: false);
            var __workflow_bodyroutingSummaryresponsibleField = WorkflowExpression.Compile(bodyroutingSummaryresponsibleField, nameof(bodyroutingSummaryresponsibleField), required: false);
            var __workflow_bodyroutingSummaryvalue = WorkflowExpression.Compile(bodyroutingSummaryvalue, nameof(bodyroutingSummaryvalue), required: false);
            var __workflow_bodyreindexDocs = WorkflowExpression.Compile(bodyreindexDocs, nameof(bodyreindexDocs), required: false);
            return new DeferredBodyAction<EditWorkflowResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/EditWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfilingId != null)
                {
                    body["filingId"] = ExpressionConverter.ConvertO(__workflow_bodyfilingId);
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (__workflow_bodyheadersclientName != null)
                {
                    headersObject["ClientName"] = ExpressionConverter.ConvertO(__workflow_bodyheadersclientName);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersclientNumber != null)
                {
                    headersObject["ClientNumber"] = ExpressionConverter.ConvertO(__workflow_bodyheadersclientNumber);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersengagementType != null)
                {
                    headersObject["EngagementType"] = ExpressionConverter.ConvertO(__workflow_bodyheadersengagementType);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheaderspIC != null)
                {
                    headersObject["PIC"] = ExpressionConverter.ConvertO(__workflow_bodyheaderspIC);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersyear != null)
                {
                    headersObject["Year"] = ExpressionConverter.ConvertO(__workflow_bodyheadersyear);
                    headersObjectpropCount++;
                }

                if (__workflow_bodyheadersperiodEnd != null)
                {
                    headersObject["PeriodEnd"] = ExpressionConverter.ConvertO(__workflow_bodyheadersperiodEnd);
                    headersObjectpropCount++;
                }

                if (headersObjectpropCount > 0)
                {
                    body["Headers"] = headersObject;
                    bodypropCount++;
                }

                var deliverableObject = new JObject();
                var deliverableObjectpropCount = 0;
                if (__workflow_bodydeliverableaction != null)
                {
                    deliverableObject["action"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableaction);
                    deliverableObjectpropCount++;
                }

                if (__workflow_bodydeliverablecurrentduedate != null)
                {
                    deliverableObject["currentduedate"] = ExpressionConverter.ConvertO(__workflow_bodydeliverablecurrentduedate);
                    deliverableObjectpropCount++;
                }

                if (__workflow_bodydeliverableoriginalduedate != null)
                {
                    deliverableObject["originalduedate"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableoriginalduedate);
                    deliverableObjectpropCount++;
                }

                if (__workflow_bodydeliverableform != null)
                {
                    deliverableObject["form"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableform);
                    deliverableObjectpropCount++;
                }

                if (deliverableObjectpropCount > 0)
                {
                    body["deliverable"] = deliverableObject;
                    bodypropCount++;
                }

                var notesObject = new JObject();
                var notesObjectpropCount = 0;
                if (__workflow_bodynotesaction != null)
                {
                    notesObject["action"] = ExpressionConverter.ConvertO(__workflow_bodynotesaction);
                    notesObjectpropCount++;
                }

                if (__workflow_bodynotesnoteType != null)
                {
                    notesObject["noteType"] = ExpressionConverter.ConvertO(__workflow_bodynotesnoteType);
                    notesObjectpropCount++;
                }

                if (__workflow_bodynotesnoteid != null)
                {
                    notesObject["noteid"] = ExpressionConverter.ConvertO(__workflow_bodynotesnoteid);
                    notesObjectpropCount++;
                }

                if (__workflow_bodynotesnote != null)
                {
                    notesObject["note"] = ExpressionConverter.ConvertO(__workflow_bodynotesnote);
                    notesObjectpropCount++;
                }

                if (notesObjectpropCount > 0)
                {
                    body["notes"] = notesObject;
                    bodypropCount++;
                }

                var informationFieldsObject = new JObject();
                var informationFieldsObjectpropCount = 0;
                if (__workflow_bodyinformationFieldsname != null)
                {
                    informationFieldsObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFieldsname);
                    informationFieldsObjectpropCount++;
                }

                if (__workflow_bodyinformationFieldsvalue != null)
                {
                    informationFieldsObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFieldsvalue);
                    informationFieldsObjectpropCount++;
                }

                if (informationFieldsObjectpropCount > 0)
                {
                    body["informationFields"] = informationFieldsObject;
                    bodypropCount++;
                }

                var deliveryInstructionsObject = new JObject();
                var deliveryInstructionsObjectpropCount = 0;
                if (__workflow_bodydeliveryInstructionsdelivery != null)
                {
                    deliveryInstructionsObject["Delivery"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryInstructionsdelivery);
                    deliveryInstructionsObjectpropCount++;
                }

                if (__workflow_bodydeliveryInstructionsdestination != null)
                {
                    deliveryInstructionsObject["Destination"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryInstructionsdestination);
                    deliveryInstructionsObjectpropCount++;
                }

                if (__workflow_bodydeliveryInstructionssourceDocument != null)
                {
                    deliveryInstructionsObject["sourceDocument"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryInstructionssourceDocument);
                    deliveryInstructionsObjectpropCount++;
                }

                if (deliveryInstructionsObjectpropCount > 0)
                {
                    body["deliveryInstructions"] = deliveryInstructionsObject;
                    bodypropCount++;
                }

                var routingSummaryObject = new JObject();
                var routingSummaryObjectpropCount = 0;
                if (__workflow_bodyroutingSummaryresponsibleField != null)
                {
                    routingSummaryObject["responsibleField"] = ExpressionConverter.ConvertO(__workflow_bodyroutingSummaryresponsibleField);
                    routingSummaryObjectpropCount++;
                }

                if (__workflow_bodyroutingSummaryvalue != null)
                {
                    routingSummaryObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyroutingSummaryvalue);
                    routingSummaryObjectpropCount++;
                }

                if (routingSummaryObjectpropCount > 0)
                {
                    body["routingSummary"] = routingSummaryObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreindexDocs != null)
                {
                    body["reindexDocs"] = ExpressionConverter.ConvertO(__workflow_bodyreindexDocs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EditWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetMasterDeliverableResponse> GetMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<int>> bodypageNumber = null, Expression<Func<int>> bodypageSize = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodydrawerName = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodydrawerName = WorkflowExpression.Compile(bodydrawerName, nameof(bodydrawerName), required: false);
            return new DeferredBodyAction<GetMasterDeliverableResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/GetDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypageSize != null)
                {
                    body["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(__workflow_bodydrawerName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetMasterDeliverableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TrackingReportByWorkflowResponse> TrackingReportByWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydrawerId = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodyengagementType = null, Expression<Func<string>> bodyworkflow = null, Expression<Func<string>> bodycurrentStep = null, Expression<Func<string>> bodypIC = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodyassignedOn = null, Expression<Func<string>> bodyworkflowDescription = null, Expression<Func<string>> bodyinProcessOnly = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyresponsible = null, Expression<Func<string>> bodyassignmentHistory = null, Expression<Func<string>> bodyreceivedFrom = null, Expression<Func<string>> bodyreceivedOn = null, Expression<Func<string>> bodysentTo = null, Expression<Func<string>> bodysentOn = null, Expression<Func<string>> bodycompletedBy = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodycurrentDueDate = null, Expression<Func<string>> bodydaysAtStep = null, Expression<Func<string>> bodytotalDaysAtStep = null, Expression<Func<string>> bodydaysBetweenRoutings = null, Expression<Func<string>> bodytotalDaysInProcess = null, Expression<Func<string>> bodyaccountable = null, Expression<Func<string>> bodyroutingDetails = null, Expression<Func<string>> bodylastUpdated = null, Expression<Func<string[]>> bodyinformationFields = null, Expression<Func<string[]>> bodyindexes = null, Expression<Func<string>> bodypageNumber = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydrawerId = WorkflowExpression.Compile(bodydrawerId, nameof(bodydrawerId), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodyengagementType = WorkflowExpression.Compile(bodyengagementType, nameof(bodyengagementType), required: false);
            var __workflow_bodyworkflow = WorkflowExpression.Compile(bodyworkflow, nameof(bodyworkflow), required: false);
            var __workflow_bodycurrentStep = WorkflowExpression.Compile(bodycurrentStep, nameof(bodycurrentStep), required: false);
            var __workflow_bodypIC = WorkflowExpression.Compile(bodypIC, nameof(bodypIC), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodyassignedOn = WorkflowExpression.Compile(bodyassignedOn, nameof(bodyassignedOn), required: false);
            var __workflow_bodyworkflowDescription = WorkflowExpression.Compile(bodyworkflowDescription, nameof(bodyworkflowDescription), required: false);
            var __workflow_bodyinProcessOnly = WorkflowExpression.Compile(bodyinProcessOnly, nameof(bodyinProcessOnly), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyresponsible = WorkflowExpression.Compile(bodyresponsible, nameof(bodyresponsible), required: false);
            var __workflow_bodyassignmentHistory = WorkflowExpression.Compile(bodyassignmentHistory, nameof(bodyassignmentHistory), required: false);
            var __workflow_bodyreceivedFrom = WorkflowExpression.Compile(bodyreceivedFrom, nameof(bodyreceivedFrom), required: false);
            var __workflow_bodyreceivedOn = WorkflowExpression.Compile(bodyreceivedOn, nameof(bodyreceivedOn), required: false);
            var __workflow_bodysentTo = WorkflowExpression.Compile(bodysentTo, nameof(bodysentTo), required: false);
            var __workflow_bodysentOn = WorkflowExpression.Compile(bodysentOn, nameof(bodysentOn), required: false);
            var __workflow_bodycompletedBy = WorkflowExpression.Compile(bodycompletedBy, nameof(bodycompletedBy), required: false);
            var __workflow_bodycompletedOn = WorkflowExpression.Compile(bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodycurrentDueDate = WorkflowExpression.Compile(bodycurrentDueDate, nameof(bodycurrentDueDate), required: false);
            var __workflow_bodydaysAtStep = WorkflowExpression.Compile(bodydaysAtStep, nameof(bodydaysAtStep), required: false);
            var __workflow_bodytotalDaysAtStep = WorkflowExpression.Compile(bodytotalDaysAtStep, nameof(bodytotalDaysAtStep), required: false);
            var __workflow_bodydaysBetweenRoutings = WorkflowExpression.Compile(bodydaysBetweenRoutings, nameof(bodydaysBetweenRoutings), required: false);
            var __workflow_bodytotalDaysInProcess = WorkflowExpression.Compile(bodytotalDaysInProcess, nameof(bodytotalDaysInProcess), required: false);
            var __workflow_bodyaccountable = WorkflowExpression.Compile(bodyaccountable, nameof(bodyaccountable), required: false);
            var __workflow_bodyroutingDetails = WorkflowExpression.Compile(bodyroutingDetails, nameof(bodyroutingDetails), required: false);
            var __workflow_bodylastUpdated = WorkflowExpression.Compile(bodylastUpdated, nameof(bodylastUpdated), required: false);
            var __workflow_bodyinformationFields = WorkflowExpression.Compile(bodyinformationFields, nameof(bodyinformationFields), required: false);
            var __workflow_bodyindexes = WorkflowExpression.Compile(bodyindexes, nameof(bodyindexes), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            return new DeferredBodyAction<TrackingReportByWorkflowResponse>(() =>
            {
                var apiCallPath = "/api/v1/firmflowreports/TrackingReportByWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(__workflow_bodydrawerId);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodyengagementType != null)
                {
                    body["EngagementType"] = ExpressionConverter.ConvertO(__workflow_bodyengagementType);
                    bodypropCount++;
                }

                if (__workflow_bodyworkflow != null)
                {
                    body["Workflow"] = ExpressionConverter.ConvertO(__workflow_bodyworkflow);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(__workflow_bodycurrentStep);
                    bodypropCount++;
                }

                if (__workflow_bodypIC != null)
                {
                    body["PIC"] = ExpressionConverter.ConvertO(__workflow_bodypIC);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedOn != null)
                {
                    body["AssignedOn"] = ExpressionConverter.ConvertO(__workflow_bodyassignedOn);
                    bodypropCount++;
                }

                if (__workflow_bodyworkflowDescription != null)
                {
                    body["WorkflowDescription"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyinProcessOnly != null)
                {
                    body["InProcessOnly"] = ExpressionConverter.ConvertO(__workflow_bodyinProcessOnly);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsible != null)
                {
                    body["Responsible"] = ExpressionConverter.ConvertO(__workflow_bodyresponsible);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentHistory != null)
                {
                    body["AssignmentHistory"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentHistory);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFrom != null)
                {
                    body["ReceivedFrom"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFrom);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedOn != null)
                {
                    body["ReceivedOn"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedOn);
                    bodypropCount++;
                }

                if (__workflow_bodysentTo != null)
                {
                    body["SentTo"] = ExpressionConverter.ConvertO(__workflow_bodysentTo);
                    bodypropCount++;
                }

                if (__workflow_bodysentOn != null)
                {
                    body["SentOn"] = ExpressionConverter.ConvertO(__workflow_bodysentOn);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedBy != null)
                {
                    body["CompletedBy"] = ExpressionConverter.ConvertO(__workflow_bodycompletedBy);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedOn != null)
                {
                    body["CompletedOn"] = ExpressionConverter.ConvertO(__workflow_bodycompletedOn);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentDueDate != null)
                {
                    body["CurrentDueDate"] = ExpressionConverter.ConvertO(__workflow_bodycurrentDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydaysAtStep != null)
                {
                    body["DaysAtStep"] = ExpressionConverter.ConvertO(__workflow_bodydaysAtStep);
                    bodypropCount++;
                }

                if (__workflow_bodytotalDaysAtStep != null)
                {
                    body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(__workflow_bodytotalDaysAtStep);
                    bodypropCount++;
                }

                if (__workflow_bodydaysBetweenRoutings != null)
                {
                    body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(__workflow_bodydaysBetweenRoutings);
                    bodypropCount++;
                }

                if (__workflow_bodytotalDaysInProcess != null)
                {
                    body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(__workflow_bodytotalDaysInProcess);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountable != null)
                {
                    body["Accountable"] = ExpressionConverter.ConvertO(__workflow_bodyaccountable);
                    bodypropCount++;
                }

                if (__workflow_bodyroutingDetails != null)
                {
                    body["RoutingDetails"] = ExpressionConverter.ConvertO(__workflow_bodyroutingDetails);
                    bodypropCount++;
                }

                if (__workflow_bodylastUpdated != null)
                {
                    body["LastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodylastUpdated);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationFields != null)
                {
                    body["InformationFields"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFields);
                    bodypropCount++;
                }

                if (__workflow_bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(__workflow_bodyindexes);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TrackingReportByWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<AddMasterDeliverableResponse> AddMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydeliverableName = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyfirstExtension = null, Expression<Func<string>> bodysecondExtension = null, Expression<Func<string>> bodythirdExtension = null, Expression<Func<string>> bodycalenderOrFiscal = null, Expression<Func<int>> bodyextension = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodydrawerName = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydeliverableName = WorkflowExpression.Compile(bodydeliverableName, nameof(bodydeliverableName), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyfirstExtension = WorkflowExpression.Compile(bodyfirstExtension, nameof(bodyfirstExtension), required: false);
            var __workflow_bodysecondExtension = WorkflowExpression.Compile(bodysecondExtension, nameof(bodysecondExtension), required: false);
            var __workflow_bodythirdExtension = WorkflowExpression.Compile(bodythirdExtension, nameof(bodythirdExtension), required: false);
            var __workflow_bodycalenderOrFiscal = WorkflowExpression.Compile(bodycalenderOrFiscal, nameof(bodycalenderOrFiscal), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodydrawerName = WorkflowExpression.Compile(bodydrawerName, nameof(bodydrawerName), required: false);
            return new DeferredBodyAction<AddMasterDeliverableResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/SaveDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydeliverableName != null)
                {
                    body["deliverableName"] = ExpressionConverter.ConvertO(__workflow_bodydeliverableName);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstExtension != null)
                {
                    body["firstExtension"] = ExpressionConverter.ConvertO(__workflow_bodyfirstExtension);
                    bodypropCount++;
                }

                if (__workflow_bodysecondExtension != null)
                {
                    body["secondExtension"] = ExpressionConverter.ConvertO(__workflow_bodysecondExtension);
                    bodypropCount++;
                }

                if (__workflow_bodythirdExtension != null)
                {
                    body["thirdExtension"] = ExpressionConverter.ConvertO(__workflow_bodythirdExtension);
                    bodypropCount++;
                }

                if (__workflow_bodycalenderOrFiscal != null)
                {
                    body["calenderOrFiscal"] = ExpressionConverter.ConvertO(__workflow_bodycalenderOrFiscal);
                    bodypropCount++;
                }

                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(__workflow_bodydrawerName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddMasterDeliverableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<RouteWorkflowV2Response> RouteWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<int[]>> bodyfilingId = null, Expression<Func<string[]>> bodycurrentStep = null, Expression<Func<bool>> bodycomplete = null, Expression<Func<string>> bodycompletedDate = null, Expression<Func<string>> bodynextStep = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodyassignedDate = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyroutingNote = null, Expression<Func<bool>> bodyemailNotify = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodyfilingId = WorkflowExpression.Compile(bodyfilingId, nameof(bodyfilingId), required: false);
            var __workflow_bodycurrentStep = WorkflowExpression.Compile(bodycurrentStep, nameof(bodycurrentStep), required: false);
            var __workflow_bodycomplete = WorkflowExpression.Compile(bodycomplete, nameof(bodycomplete), required: false);
            var __workflow_bodycompletedDate = WorkflowExpression.Compile(bodycompletedDate, nameof(bodycompletedDate), required: false);
            var __workflow_bodynextStep = WorkflowExpression.Compile(bodynextStep, nameof(bodynextStep), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodyassignedDate = WorkflowExpression.Compile(bodyassignedDate, nameof(bodyassignedDate), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyroutingNote = WorkflowExpression.Compile(bodyroutingNote, nameof(bodyroutingNote), required: false);
            var __workflow_bodyemailNotify = WorkflowExpression.Compile(bodyemailNotify, nameof(bodyemailNotify), required: false);
            return new DeferredBodyAction<RouteWorkflowV2Response>(() =>
            {
                var apiCallPath = "/firmflow/api/V2/Route";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfilingId != null)
                {
                    body["filingId"] = ExpressionConverter.ConvertO(__workflow_bodyfilingId);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(__workflow_bodycurrentStep);
                    bodypropCount++;
                }

                if (__workflow_bodycomplete != null)
                {
                    body["Complete"] = ExpressionConverter.ConvertO(__workflow_bodycomplete);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedDate != null)
                {
                    body["CompletedDate"] = ExpressionConverter.ConvertO(__workflow_bodycompletedDate);
                    bodypropCount++;
                }

                if (__workflow_bodynextStep != null)
                {
                    body["NextStep"] = ExpressionConverter.ConvertO(__workflow_bodynextStep);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedDate != null)
                {
                    body["AssignedDate"] = ExpressionConverter.ConvertO(__workflow_bodyassignedDate);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyroutingNote != null)
                {
                    body["RoutingNote"] = ExpressionConverter.ConvertO(__workflow_bodyroutingNote);
                    bodypropCount++;
                }

                if (__workflow_bodyemailNotify != null)
                {
                    body["emailNotify"] = ExpressionConverter.ConvertO(__workflow_bodyemailNotify);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RouteWorkflowV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TrackingReportByDeliverableV2Response> TrackingReportByDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydrawerId = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodyengagementType = null, Expression<Func<string>> bodyworkflow = null, Expression<Func<string>> bodycurrentStep = null, Expression<Func<string>> bodypIC = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodyassignedOn = null, Expression<Func<string>> bodyworkflowDescription = null, Expression<Func<string>> bodyinProcessOnly = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyreceivedOn = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodysentOn = null, Expression<Func<string>> bodyresponsible = null, Expression<Func<string>> bodyassignmentHistory = null, Expression<Func<string>> bodyreceivedFrom = null, Expression<Func<string>> bodysentTo = null, Expression<Func<string>> bodycompletedBy = null, Expression<Func<string>> bodyaccountable = null, Expression<Func<string>> bodycurrentDueDate = null, Expression<Func<string>> bodyoriginalDueDate = null, Expression<Func<string>> bodydateExtended = null, Expression<Func<string>> bodydaysAtStep = null, Expression<Func<string>> bodytotalDaysAtStep = null, Expression<Func<string>> bodydaysBetweenRoutings = null, Expression<Func<string>> bodytotalDaysInProcess = null, Expression<Func<string>> bodyroutingDetails = null, Expression<Func<string>> bodylastUpdated = null, Expression<Func<string[]>> bodyinformationFields = null, Expression<Func<string[]>> bodyindexes = null, Expression<Func<string>> bodypageNumber = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_bodydrawerId = WorkflowExpression.Compile(bodydrawerId, nameof(bodydrawerId), required: false);
            var __workflow_bodyserviceType = WorkflowExpression.Compile(bodyserviceType, nameof(bodyserviceType), required: false);
            var __workflow_bodyengagementType = WorkflowExpression.Compile(bodyengagementType, nameof(bodyengagementType), required: false);
            var __workflow_bodyworkflow = WorkflowExpression.Compile(bodyworkflow, nameof(bodyworkflow), required: false);
            var __workflow_bodycurrentStep = WorkflowExpression.Compile(bodycurrentStep, nameof(bodycurrentStep), required: false);
            var __workflow_bodypIC = WorkflowExpression.Compile(bodypIC, nameof(bodypIC), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodyassignedOn = WorkflowExpression.Compile(bodyassignedOn, nameof(bodyassignedOn), required: false);
            var __workflow_bodyworkflowDescription = WorkflowExpression.Compile(bodyworkflowDescription, nameof(bodyworkflowDescription), required: false);
            var __workflow_bodyinProcessOnly = WorkflowExpression.Compile(bodyinProcessOnly, nameof(bodyinProcessOnly), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyreceivedOn = WorkflowExpression.Compile(bodyreceivedOn, nameof(bodyreceivedOn), required: false);
            var __workflow_bodycompletedOn = WorkflowExpression.Compile(bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodysentOn = WorkflowExpression.Compile(bodysentOn, nameof(bodysentOn), required: false);
            var __workflow_bodyresponsible = WorkflowExpression.Compile(bodyresponsible, nameof(bodyresponsible), required: false);
            var __workflow_bodyassignmentHistory = WorkflowExpression.Compile(bodyassignmentHistory, nameof(bodyassignmentHistory), required: false);
            var __workflow_bodyreceivedFrom = WorkflowExpression.Compile(bodyreceivedFrom, nameof(bodyreceivedFrom), required: false);
            var __workflow_bodysentTo = WorkflowExpression.Compile(bodysentTo, nameof(bodysentTo), required: false);
            var __workflow_bodycompletedBy = WorkflowExpression.Compile(bodycompletedBy, nameof(bodycompletedBy), required: false);
            var __workflow_bodyaccountable = WorkflowExpression.Compile(bodyaccountable, nameof(bodyaccountable), required: false);
            var __workflow_bodycurrentDueDate = WorkflowExpression.Compile(bodycurrentDueDate, nameof(bodycurrentDueDate), required: false);
            var __workflow_bodyoriginalDueDate = WorkflowExpression.Compile(bodyoriginalDueDate, nameof(bodyoriginalDueDate), required: false);
            var __workflow_bodydateExtended = WorkflowExpression.Compile(bodydateExtended, nameof(bodydateExtended), required: false);
            var __workflow_bodydaysAtStep = WorkflowExpression.Compile(bodydaysAtStep, nameof(bodydaysAtStep), required: false);
            var __workflow_bodytotalDaysAtStep = WorkflowExpression.Compile(bodytotalDaysAtStep, nameof(bodytotalDaysAtStep), required: false);
            var __workflow_bodydaysBetweenRoutings = WorkflowExpression.Compile(bodydaysBetweenRoutings, nameof(bodydaysBetweenRoutings), required: false);
            var __workflow_bodytotalDaysInProcess = WorkflowExpression.Compile(bodytotalDaysInProcess, nameof(bodytotalDaysInProcess), required: false);
            var __workflow_bodyroutingDetails = WorkflowExpression.Compile(bodyroutingDetails, nameof(bodyroutingDetails), required: false);
            var __workflow_bodylastUpdated = WorkflowExpression.Compile(bodylastUpdated, nameof(bodylastUpdated), required: false);
            var __workflow_bodyinformationFields = WorkflowExpression.Compile(bodyinformationFields, nameof(bodyinformationFields), required: false);
            var __workflow_bodyindexes = WorkflowExpression.Compile(bodyindexes, nameof(bodyindexes), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            return new DeferredBodyAction<TrackingReportByDeliverableV2Response>(() =>
            {
                var apiCallPath = "/api/v2/firmflowreports/TrackingReportByDeliverable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(__workflow_bodydrawerId);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(__workflow_bodyserviceType);
                    bodypropCount++;
                }

                if (__workflow_bodyengagementType != null)
                {
                    body["EngagementType"] = ExpressionConverter.ConvertO(__workflow_bodyengagementType);
                    bodypropCount++;
                }

                if (__workflow_bodyworkflow != null)
                {
                    body["Workflow"] = ExpressionConverter.ConvertO(__workflow_bodyworkflow);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(__workflow_bodycurrentStep);
                    bodypropCount++;
                }

                if (__workflow_bodypIC != null)
                {
                    body["PIC"] = ExpressionConverter.ConvertO(__workflow_bodypIC);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedOn != null)
                {
                    body["AssignedOn"] = ExpressionConverter.ConvertO(__workflow_bodyassignedOn);
                    bodypropCount++;
                }

                if (__workflow_bodyworkflowDescription != null)
                {
                    body["WorkflowDescription"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyinProcessOnly != null)
                {
                    body["InProcessOnly"] = ExpressionConverter.ConvertO(__workflow_bodyinProcessOnly);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedOn != null)
                {
                    body["ReceivedOn"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedOn);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedOn != null)
                {
                    body["CompletedOn"] = ExpressionConverter.ConvertO(__workflow_bodycompletedOn);
                    bodypropCount++;
                }

                if (__workflow_bodysentOn != null)
                {
                    body["SentOn"] = ExpressionConverter.ConvertO(__workflow_bodysentOn);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsible != null)
                {
                    body["Responsible"] = ExpressionConverter.ConvertO(__workflow_bodyresponsible);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentHistory != null)
                {
                    body["AssignmentHistory"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentHistory);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFrom != null)
                {
                    body["ReceivedFrom"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFrom);
                    bodypropCount++;
                }

                if (__workflow_bodysentTo != null)
                {
                    body["SentTo"] = ExpressionConverter.ConvertO(__workflow_bodysentTo);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedBy != null)
                {
                    body["CompletedBy"] = ExpressionConverter.ConvertO(__workflow_bodycompletedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountable != null)
                {
                    body["Accountable"] = ExpressionConverter.ConvertO(__workflow_bodyaccountable);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentDueDate != null)
                {
                    body["CurrentDueDate"] = ExpressionConverter.ConvertO(__workflow_bodycurrentDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyoriginalDueDate != null)
                {
                    body["OriginalDueDate"] = ExpressionConverter.ConvertO(__workflow_bodyoriginalDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydateExtended != null)
                {
                    body["DateExtended"] = ExpressionConverter.ConvertO(__workflow_bodydateExtended);
                    bodypropCount++;
                }

                if (__workflow_bodydaysAtStep != null)
                {
                    body["DaysAtStep"] = ExpressionConverter.ConvertO(__workflow_bodydaysAtStep);
                    bodypropCount++;
                }

                if (__workflow_bodytotalDaysAtStep != null)
                {
                    body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(__workflow_bodytotalDaysAtStep);
                    bodypropCount++;
                }

                if (__workflow_bodydaysBetweenRoutings != null)
                {
                    body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(__workflow_bodydaysBetweenRoutings);
                    bodypropCount++;
                }

                if (__workflow_bodytotalDaysInProcess != null)
                {
                    body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(__workflow_bodytotalDaysInProcess);
                    bodypropCount++;
                }

                if (__workflow_bodyroutingDetails != null)
                {
                    body["RoutingDetails"] = ExpressionConverter.ConvertO(__workflow_bodyroutingDetails);
                    bodypropCount++;
                }

                if (__workflow_bodylastUpdated != null)
                {
                    body["LastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodylastUpdated);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationFields != null)
                {
                    body["InformationFields"] = ExpressionConverter.ConvertO(__workflow_bodyinformationFields);
                    bodypropCount++;
                }

                if (__workflow_bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(__workflow_bodyindexes);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TrackingReportByDeliverableV2Response>(callPayload);
            });
        }
    }

    public class GofileroomTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateGroupResponse
    {
        [JsonProperty("createGroupException")]
        public string CreateGroupException { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("isCreated")]
        public bool IsCreated { get; set; }

        [JsonProperty("mfaException")]
        public string MfaException { get; set; }
    }

    public class bodyreportsInputItem
    {
        public string[] Allow { get; set; }
        public string[] Deny { get; set; }
        public string IsAllowAll { get; set; }
        public string IsDenyAll { get; set; }
        public string ReportType { get; set; }
    }

    public class SetGroupDocSecurityResponse
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("isSetGroupDocSecurity")]
        public bool IsSetGroupDocSecurity { get; set; }

        [JsonProperty("setGroupDocSecurityException")]
        public string SetGroupDocSecurityException { get; set; }
    }

    public class bodydocumentSecurityInputItem
    {
        public bodydocumentSecurityInputItemDocSecurityTypeType DocSecurityType { get; set; }
        public string IndexName { get; set; }
        public bodydocumentSecurityInputItemOperationType Operation { get; set; }
        public string[] Values { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydocumentSecurityInputItemDocSecurityTypeType
    {
        [EnumMember(Value = "DENY ACCESS")]
        DENYACCESS,
        [EnumMember(Value = "ALLOW ACCESS")]
        ALLOWACCESS,
        [EnumMember(Value = "NO EDIT")]
        NOEDIT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydocumentSecurityInputItemOperationType
    {
        ADD,
        REMOVE,
        [EnumMember(Value = "CLEAR ALL")]
        CLEARALL
    }

    public class ModifyGroupResponse
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("isModified")]
        public bool IsModified { get; set; }

        [JsonProperty("mfaException")]
        public string MfaException { get; set; }

        [JsonProperty("modifyGroupException")]
        public string ModifyGroupException { get; set; }
    }

    public class GetGroupPermissionsResponse
    {
        [JsonProperty("cabinet")]
        public string Cabinet { get; set; }

        [JsonProperty("cabinetPermissions")]
        public GetGroupPermissionsResponseCabinetPermissionsType CabinetPermissions { get; set; }

        [JsonProperty("drawerPermissions")]
        public GetGroupPermissionsResponseDrawerPermissionsTypeItem[] DrawerPermissions { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("groupPermissionException")]
        public string GroupPermissionException { get; set; }
    }

    public class GetGroupPermissionsResponseCabinetPermissionsType
    {
        [JsonProperty("add")]
        public bool Add { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("deny")]
        public bool Deny { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("lookUp")]
        public bool LookUp { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class GetGroupPermissionsResponseDrawerPermissionsTypeItem
    {
        [JsonProperty("drawer")]
        public string Drawer { get; set; }

        [JsonProperty("permission")]
        public GetGroupPermissionsResponseDrawerPermissionsTypeItemPermissionType Permission { get; set; }
    }

    public class GetGroupPermissionsResponseDrawerPermissionsTypeItemPermissionType
    {
        [JsonProperty("add")]
        public bool Add { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("deny")]
        public bool Deny { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("lookUp")]
        public bool LookUp { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class SetGroupPermissionsResponse
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("groupPermissionException")]
        public string GroupPermissionException { get; set; }

        [JsonProperty("isSet")]
        public bool IsSet { get; set; }
    }

    public class bodydrawerPermissionsInputItem
    {
        public string Drawer { get; set; }
        public bodydrawerPermissionsInputItemPermissionType Permission { get; set; }
    }

    public class bodydrawerPermissionsInputItemPermissionType
    {
        public string Add { get; set; }
        public string Delete { get; set; }
        public string Deny { get; set; }
        public string Edit { get; set; }
        public string LookUp { get; set; }
        public string Read { get; set; }
    }

    public class GetGroupDocumentSecurityResponse
    {
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("cabinetName")]
        public string CabinetName { get; set; }

        [JsonProperty("drawerName")]
        public string DrawerName { get; set; }

        [JsonProperty("documentSecurity")]
        public GetGroupDocumentSecurityResponseDocumentSecurityTypeItem[] DocumentSecurity { get; set; }

        [JsonProperty("getGroupDocSecurityException")]
        public string GetGroupDocSecurityException { get; set; }
    }

    public class GetGroupDocumentSecurityResponseDocumentSecurityTypeItem
    {
        [JsonProperty("indexName")]
        public string IndexName { get; set; }

        [JsonProperty("docSecurityType")]
        public string DocSecurityType { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetGroupsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mfa")]
        public int Mfa { get; set; }

        [JsonProperty("mfaRequired")]
        public int MfaRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateUsersResponse
    {
        [JsonProperty("createUserException")]
        public string CreateUserException { get; set; }

        [JsonProperty("isCreated")]
        public bool IsCreated { get; set; }

        [JsonProperty("mfaException")]
        public string MfaException { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum userTypeInput
    {
        GFRUSERS,
        CLIENTFLOWUSERS
    }

    public class DeleteUserResponse
    {
        [JsonProperty("deleteUserException")]
        public string DeleteUserException { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyuserTypeInput
    {
        GFRUSERS,
        CLIENTFLOWUSERS
    }

    public class SetUserDocSecurityResponse
    {
        [JsonProperty("isSetUserDocSecurity")]
        public bool IsSetUserDocSecurity { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }

        [JsonProperty("setUserDocSecurityException")]
        public string SetUserDocSecurityException { get; set; }
    }

    public class bodydocumentSecurityInputItem2
    {
        public bodydocumentSecurityInputItemDocSecurityTypeType DocSecurityType { get; set; }
        public string IndexName { get; set; }
        public bodydocumentSecurityInputItemOperationType Operation { get; set; }
        public string[] Values { get; set; }
    }

    public class GetUserInfoResponse
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("disabled")]
        public int Disabled { get; set; }

        [JsonProperty("disabledByAdmin")]
        public bool DisabledByAdmin { get; set; }

        [JsonProperty("emailNotify")]
        public bool EmailNotify { get; set; }

        [JsonProperty("emailNotifyEventMgmtGroups")]
        public bool EmailNotifyEventMgmtGroups { get; set; }

        [JsonProperty("emailNotifyEventMgmtUsers")]
        public bool EmailNotifyEventMgmtUsers { get; set; }

        [JsonProperty("emailNotifyGroup")]
        public bool EmailNotifyGroup { get; set; }

        [JsonProperty("forcePasswordChange")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("hasDrawerSetupRights")]
        public string HasDrawerSetupRights { get; set; }

        [JsonProperty("isAdmin")]
        public int IsAdmin { get; set; }

        [JsonProperty("isManager")]
        public int IsManager { get; set; }

        [JsonProperty("licenseType")]
        public string LicenseType { get; set; }

        [JsonProperty("locationID")]
        public string LocationID { get; set; }

        [JsonProperty("loginID")]
        public string LoginID { get; set; }

        [JsonProperty("managerFullName")]
        public string ManagerFullName { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("managerLoginId")]
        public string ManagerLoginId { get; set; }

        [JsonProperty("oberonUser")]
        public int OberonUser { get; set; }

        [JsonProperty("offline")]
        public bool Offline { get; set; }

        [JsonProperty("passwordChangeDate")]
        public string PasswordChangeDate { get; set; }

        [JsonProperty("passwordChangeInterval")]
        public int PasswordChangeInterval { get; set; }

        [JsonProperty("passwordExpireDate")]
        public string PasswordExpireDate { get; set; }

        [JsonProperty("reports")]
        public bool Reports { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("systemAdmin")]
        public bool SystemAdmin { get; set; }

        [JsonProperty("taxFlow")]
        public bool TaxFlow { get; set; }

        [JsonProperty("userAdministration")]
        public int UserAdministration { get; set; }

        [JsonProperty("userID")]
        public string UserID { get; set; }

        [JsonProperty("workflowManagerUser")]
        public bool WorkflowManagerUser { get; set; }
    }

    public class GetLicensesResponse
    {
        [JsonProperty("assignedLicenses")]
        public string AssignedLicenses { get; set; }

        [JsonProperty("getLicenseException")]
        public string GetLicenseException { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("totalLicenses")]
        public string TotalLicenses { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum licenseInput
    {
        DEDICATED,
        CONCURRENT,
        FIRMFLOW
    }

    public class ModifyUserResponse
    {
        [JsonProperty("isModified")]
        public bool IsModified { get; set; }

        [JsonProperty("mfaException")]
        public string MfaException { get; set; }

        [JsonProperty("modifyUserException")]
        public string ModifyUserException { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class GetPasswordPolicyResponse
    {
        [JsonProperty("passwordPolicy")]
        public GetPasswordPolicyResponsePasswordPolicyType PasswordPolicy { get; set; }

        [JsonProperty("passwordPolicyException")]
        public string PasswordPolicyException { get; set; }
    }

    public class GetPasswordPolicyResponsePasswordPolicyType
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("forbidden_pwd_words")]
        public string[] ForbiddenPwdWords { get; set; }

        [JsonProperty("lockout_threshold")]
        public int LockoutThreshold { get; set; }

        [JsonProperty("max_length")]
        public int MaxLength { get; set; }

        [JsonProperty("max_login_similarity")]
        public string MaxLoginSimilarity { get; set; }

        [JsonProperty("max_pwd_age")]
        public int MaxPwdAge { get; set; }

        [JsonProperty("max_repeat_chars")]
        public string MaxRepeatChars { get; set; }

        [JsonProperty("max_sequential_chars")]
        public string MaxSequentialChars { get; set; }

        [JsonProperty("mfa")]
        public int Mfa { get; set; }

        [JsonProperty("min_length")]
        public int MinLength { get; set; }

        [JsonProperty("pwd_req_alpha")]
        public int PwdReqAlpha { get; set; }

        [JsonProperty("pwd_req_lower")]
        public int PwdReqLower { get; set; }

        [JsonProperty("pwd_req_number")]
        public int PwdReqNumber { get; set; }

        [JsonProperty("pwd_req_symbol")]
        public int PwdReqSymbol { get; set; }

        [JsonProperty("pwd_req_upper")]
        public int PwdReqUpper { get; set; }
    }

    public class SetUserPermissionsResponse
    {
        [JsonProperty("isSetUserPermission")]
        public bool IsSetUserPermission { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }

        [JsonProperty("setUserPermissionException")]
        public string SetUserPermissionException { get; set; }
    }

    public class GetListOfReportsResponse
    {
        [JsonProperty("reports")]
        public GetListOfReportsResponseReportsTypeItem[] Reports { get; set; }

        [JsonProperty("reportsException")]
        public string ReportsException { get; set; }
    }

    public class GetListOfReportsResponseReportsTypeItem
    {
        [JsonProperty("reportName")]
        public string[] ReportName { get; set; }

        [JsonProperty("reportType")]
        public string ReportType { get; set; }
    }

    public class GetUploadLocationResponse
    {
        [JsonProperty("uploadLocations")]
        public GetUploadLocationResponseUploadLocationsTypeItem[] UploadLocations { get; set; }

        [JsonProperty("uploadLocationsException")]
        public string UploadLocationsException { get; set; }
    }

    public class GetUploadLocationResponseUploadLocationsTypeItem
    {
        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("locationPath")]
        public string LocationPath { get; set; }
    }

    public class GetUserDocumentSecurityResponse
    {
        [JsonProperty("cabinetName")]
        public string CabinetName { get; set; }

        [JsonProperty("documentSecurity")]
        public string DocumentSecurity { get; set; }

        [JsonProperty("drawerName")]
        public string DrawerName { get; set; }

        [JsonProperty("getUserDocSecurityException")]
        public string GetUserDocSecurityException { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }
    }

    public class GetUserPermissionResponse
    {
        [JsonProperty("cabinet")]
        public string Cabinet { get; set; }

        [JsonProperty("cabinetPermission")]
        public GetUserPermissionResponseCabinetPermissionType CabinetPermission { get; set; }

        [JsonProperty("drawerPermissions")]
        public GetUserPermissionResponseDrawerPermissionsTypeItem[] DrawerPermissions { get; set; }

        [JsonProperty("getUserPermissionException")]
        public string GetUserPermissionException { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }
    }

    public class GetUserPermissionResponseCabinetPermissionType
    {
        [JsonProperty("add")]
        public bool Add { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("deny")]
        public bool Deny { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("lookUp")]
        public bool LookUp { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class GetUserPermissionResponseDrawerPermissionsTypeItem
    {
        [JsonProperty("drawer")]
        public string Drawer { get; set; }

        [JsonProperty("permission")]
        public GetUserPermissionResponseDrawerPermissionsTypeItemPermissionType Permission { get; set; }
    }

    public class GetUserPermissionResponseDrawerPermissionsTypeItemPermissionType
    {
        [JsonProperty("add")]
        public bool Add { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("deny")]
        public bool Deny { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("lookUp")]
        public bool LookUp { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class GetUsersResponseItem
    {
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }
    }

    public class GetLookupListResponseItem
    {
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientNumber")]
        public string ClientNumber { get; set; }
    }

    public class CreateDocumentResponse
    {
        [JsonProperty("documentCreate")]
        public CreateDocumentResponseDocumentCreateType DocumentCreate { get; set; }

        [JsonProperty("indexValidation")]
        public CreateDocumentResponseIndexValidationType IndexValidation { get; set; }
    }

    public class CreateDocumentResponseDocumentCreateType
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class CreateDocumentResponseIndexValidationType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }
    }

    public class bodyindexesInputItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
    }

    public class CopyDocumentResponseItem
    {
        [JsonProperty("copyDocumentException")]
        public string CopyDocumentException { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("isCopied")]
        public bool IsCopied { get; set; }

        [JsonProperty("newDocumentId")]
        public string NewDocumentId { get; set; }
    }

    public class bodyindexValuesInputItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
    }

    public class GetDocumentStatusResponseItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("documentStatusException")]
        public string DocumentStatusException { get; set; }

        [JsonProperty("drawerId")]
        public string DrawerId { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }

        [JsonProperty("isArchived")]
        public bool IsArchived { get; set; }

        [JsonProperty("isCheckedOut")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncrypted { get; set; }

        [JsonProperty("isFiled")]
        public bool IsFiled { get; set; }

        [JsonProperty("isInRedactionQueue")]
        public bool IsInRedactionQueue { get; set; }

        [JsonProperty("isInTaxsortQueue")]
        public bool IsInTaxsortQueue { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("isOfficeDocument")]
        public bool IsOfficeDocument { get; set; }

        [JsonProperty("isPublished")]
        public bool IsPublished { get; set; }

        [JsonProperty("isUndergoingMerging")]
        public bool IsUndergoingMerging { get; set; }

        [JsonProperty("localFile")]
        public string LocalFile { get; set; }

        [JsonProperty("noEdit")]
        public bool NoEdit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("reviewed")]
        public bool Reviewed { get; set; }

        [JsonProperty("taxSort")]
        public bool TaxSort { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class DocumentReindexResponseItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("isReIndexed")]
        public bool IsReIndexed { get; set; }

        [JsonProperty("reIndexDocumentException")]
        public string ReIndexDocumentException { get; set; }
    }

    public class DocumentSearchResponse
    {
        [JsonProperty("documentIds")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("documentSearchCount")]
        public int DocumentSearchCount { get; set; }
    }

    public class bodyfilterindexValuesInputItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortOrderInput
    {
        ASC,
        DESC
    }

    public class TaxsortDocumentResponseItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("isTaxSorted")]
        public bool IsTaxSorted { get; set; }

        [JsonProperty("taxsortDocumentException")]
        public string TaxsortDocumentException { get; set; }
    }

    public class DocumentDeleteResponseItem
    {
        [JsonProperty("deleteDocumentException")]
        public string DeleteDocumentException { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class GetDocumentHistoryResponse
    {
        [JsonProperty("documentAudit")]
        public JToken[] DocumentAudit { get; set; }

        [JsonProperty("documentHistoryException")]
        public string DocumentHistoryException { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("mergeDocHistory")]
        public JToken[] MergeDocHistory { get; set; }
    }

    public class GetDocumentIndexesResponseItem
    {
        [JsonProperty("indexId")]
        public string IndexId { get; set; }

        [JsonProperty("indexValue")]
        public string IndexValue { get; set; }
    }

    public class PublishDocumentStatusResponseItem
    {
        [JsonProperty("documentException")]
        public string DocumentException { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("isPublished")]
        public bool IsPublished { get; set; }
    }

    public class GetDrawersResponseItem
    {
        [JsonProperty("drawerID")]
        public string DrawerID { get; set; }

        [JsonProperty("drawerName")]
        public string DrawerName { get; set; }

        [JsonProperty("permissions")]
        public GetDrawersResponseItemPermissionsType Permissions { get; set; }
    }

    public class GetDrawersResponseItemPermissionsType
    {
        [JsonProperty("add")]
        public bool Add { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("lookupManagement")]
        public bool LookupManagement { get; set; }

        [JsonProperty("view")]
        public bool View { get; set; }
    }

    public class GetDrawerIndexesResponseItem
    {
        [JsonProperty("childIndexId")]
        public string ChildIndexId { get; set; }

        [JsonProperty("indexId")]
        public string IndexId { get; set; }

        [JsonProperty("indexName")]
        public string IndexName { get; set; }

        [JsonProperty("indexType")]
        public string IndexType { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("listId")]
        public int ListId { get; set; }

        [JsonProperty("lookupAutoUpdate")]
        public bool LookupAutoUpdate { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }

    public class GetFirmFlowDeliverableReportResponse
    {
        [JsonProperty("firmFlowReportResponse")]
        public GetFirmFlowDeliverableReportResponseFirmFlowReportResponseTypeItem[] FirmFlowReportResponse { get; set; }

        [JsonProperty("getFirmFlowException")]
        public string GetFirmFlowException { get; set; }

        [JsonProperty("pageNumber")]
        public string PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }
    }

    public class GetFirmFlowDeliverableReportResponseFirmFlowReportResponseTypeItem
    {
        [JsonProperty("accountable")]
        public string Accountable { get; set; }

        [JsonProperty("assignedOn")]
        public string AssignedOn { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("assignedToYesOrNo")]
        public string AssignedToYesOrNo { get; set; }

        [JsonProperty("assignmentHistory")]
        public string AssignmentHistory { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientNumber")]
        public string ClientNumber { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("completedOn")]
        public string CompletedOn { get; set; }

        [JsonProperty("currentDueDate")]
        public string CurrentDueDate { get; set; }

        [JsonProperty("currentStep")]
        public string CurrentStep { get; set; }

        [JsonProperty("dateExtended")]
        public string DateExtended { get; set; }

        [JsonProperty("daysAtStep")]
        public string DaysAtStep { get; set; }

        [JsonProperty("daysBetweenRoutings")]
        public string DaysBetweenRoutings { get; set; }

        [JsonProperty("deliverables")]
        public string Deliverables { get; set; }

        [JsonProperty("drawerId")]
        public string DrawerId { get; set; }

        [JsonProperty("eFileYesOrNo")]
        public string EFileYesOrNo { get; set; }

        [JsonProperty("engagementType")]
        public string EngagementType { get; set; }

        [JsonProperty("extendedYesOrNo")]
        public string ExtendedYesOrNo { get; set; }

        [JsonProperty("informationFields")]
        public GetFirmFlowDeliverableReportResponseFirmFlowReportResponseTypeItemInformationFieldsTypeItem[] InformationFields { get; set; }

        [JsonProperty("originalDueDate")]
        public string OriginalDueDate { get; set; }

        [JsonProperty("periodEnd")]
        public string PeriodEnd { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("picYesOrNo")]
        public string PicYesOrNo { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("receivedFrom")]
        public string ReceivedFrom { get; set; }

        [JsonProperty("receivedOn")]
        public string ReceivedOn { get; set; }

        [JsonProperty("responsible")]
        public string Responsible { get; set; }

        [JsonProperty("responsibleUserOrGroups")]
        public JToken[] ResponsibleUserOrGroups { get; set; }

        [JsonProperty("routingNotes")]
        public string RoutingNotes { get; set; }

        [JsonProperty("routingSummary")]
        public JToken[] RoutingSummary { get; set; }

        [JsonProperty("sentOn")]
        public string SentOn { get; set; }

        [JsonProperty("sentTo")]
        public string SentTo { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalDaysAtStep")]
        public string TotalDaysAtStep { get; set; }

        [JsonProperty("totalDaysInProcess")]
        public string TotalDaysInProcess { get; set; }

        [JsonProperty("workflow")]
        public string Workflow { get; set; }

        [JsonProperty("workflowDescription")]
        public string WorkflowDescription { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }
    }

    public class GetFirmFlowDeliverableReportResponseFirmFlowReportResponseTypeItemInformationFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ValidateIndexesResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }
    }

    public class GetDynamicRulesForIndexResponseItem
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("dependentIndexId")]
        public string DependentIndexId { get; set; }

        [JsonProperty("dynamicRuleId")]
        public string DynamicRuleId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class IndexLookupListFindResponseItem
    {
        [JsonProperty("index")]
        public IndexLookupListFindResponseItemIndexType Index { get; set; }

        [JsonProperty("linkedIndexes")]
        public IndexLookupListFindResponseItemLinkedIndexesTypeItem[] LinkedIndexes { get; set; }
    }

    public class IndexLookupListFindResponseItemIndexType
    {
        [JsonProperty("indexId")]
        public string IndexId { get; set; }

        [JsonProperty("indexValue")]
        public string IndexValue { get; set; }
    }

    public class IndexLookupListFindResponseItemLinkedIndexesTypeItem
    {
        [JsonProperty("indexId")]
        public string IndexId { get; set; }

        [JsonProperty("indexValue")]
        public string IndexValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactionTypeInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysearchTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public class GetListTypeIndexDataResponseItem
    {
        [JsonProperty("childIndexId")]
        public string ChildIndexId { get; set; }

        [JsonProperty("childListId")]
        public int ChildListId { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("listEntryId")]
        public int ListEntryId { get; set; }

        [JsonProperty("listId")]
        public int ListId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetChildIndexesResponseItem
    {
        [JsonProperty("childIndexId")]
        public string ChildIndexId { get; set; }

        [JsonProperty("childListId")]
        public int ChildListId { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("listEntryId")]
        public int ListEntryId { get; set; }

        [JsonProperty("listId")]
        public int ListId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class LoginResponse
    {
        [JsonProperty("authSuccess")]
        public bool AuthSuccess { get; set; }

        [JsonProperty("authenticationResponse")]
        public string AuthenticationResponse { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("idleSessionTimeoutMinutes")]
        public int IdleSessionTimeoutMinutes { get; set; }

        [JsonProperty("loneStarFirmId")]
        public string LoneStarFirmId { get; set; }

        [JsonProperty("loneStarValidated")]
        public bool LoneStarValidated { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }

    public class LogoutResponse
    {
        [JsonProperty("isLogoutSuccess")]
        public bool IsLogoutSuccess { get; set; }
    }

    public class CreateWorkflowResponse
    {
        [JsonProperty("filingId")]
        public int FilingId { get; set; }

        [JsonProperty("errorComment")]
        public string ErrorComment { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("errorMessage")]
        public string[] ErrorMessage { get; set; }
    }

    public class DeleteMasterDeliverableResponseItem
    {
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class DeleteWorkflowsResponse
    {
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("filingId")]
        public string FilingId { get; set; }
    }

    public class EditMasterDeliverableResponse
    {
        [JsonProperty("isUpdated")]
        public bool IsUpdated { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class EditWorkflowResponse
    {
        [JsonProperty("filingId")]
        public int FilingId { get; set; }

        [JsonProperty("errorComment")]
        public string ErrorComment { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("errorMessage")]
        public EditWorkflowResponseErrorMessageTypeItem[] ErrorMessage { get; set; }
    }

    public class EditWorkflowResponseErrorMessageTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("errorComment")]
        public string ErrorComment { get; set; }
    }

    public class GetMasterDeliverableResponse
    {
        [JsonProperty("deliverableList")]
        public GetMasterDeliverableResponseDeliverableListTypeItem[] DeliverableList { get; set; }

        [JsonProperty("totalRecords")]
        public string TotalRecords { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class GetMasterDeliverableResponseDeliverableListTypeItem
    {
        [JsonProperty("deliverableName")]
        public string DeliverableName { get; set; }

        [JsonProperty("extensionType")]
        public string ExtensionType { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("firstExtension")]
        public string FirstExtension { get; set; }

        [JsonProperty("secondExtension")]
        public string SecondExtension { get; set; }

        [JsonProperty("thirdExtension")]
        public string ThirdExtension { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("obligationId")]
        public string ObligationId { get; set; }

        [JsonProperty("firmManagedOption")]
        public string FirmManagedOption { get; set; }
    }

    public class TrackingReportByWorkflowResponse
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("pageNumber")]
        public string PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("firmFlowReportResponse")]
        public TrackingReportByWorkflowResponseFirmFlowReportResponseTypeItem[] FirmFlowReportResponse { get; set; }

        [JsonProperty("getFirmFlowException")]
        public string GetFirmFlowException { get; set; }
    }

    public class TrackingReportByWorkflowResponseFirmFlowReportResponseTypeItem
    {
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientNumber")]
        public string ClientNumber { get; set; }

        [JsonProperty("drawerId")]
        public string DrawerId { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("engagementType")]
        public string EngagementType { get; set; }

        [JsonProperty("workflow")]
        public string Workflow { get; set; }

        [JsonProperty("currentStep")]
        public string CurrentStep { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("assignedOn")]
        public string AssignedOn { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("periodEnd")]
        public string PeriodEnd { get; set; }

        [JsonProperty("workflowDescription")]
        public string WorkflowDescription { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("eFileYesOrNo")]
        public string EFileYesOrNo { get; set; }

        [JsonProperty("extendedYesOrNo")]
        public string ExtendedYesOrNo { get; set; }

        [JsonProperty("receivedOn")]
        public string ReceivedOn { get; set; }

        [JsonProperty("completedOn")]
        public string CompletedOn { get; set; }

        [JsonProperty("sentOn")]
        public string SentOn { get; set; }

        [JsonProperty("deliverables")]
        public string Deliverables { get; set; }

        [JsonProperty("responsible")]
        public string Responsible { get; set; }

        [JsonProperty("assignmentHistory")]
        public string AssignmentHistory { get; set; }

        [JsonProperty("receivedFrom")]
        public string ReceivedFrom { get; set; }

        [JsonProperty("sentTo")]
        public string SentTo { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("accountable")]
        public string Accountable { get; set; }

        [JsonProperty("currentDueDate")]
        public string CurrentDueDate { get; set; }

        [JsonProperty("originalDueDate")]
        public string OriginalDueDate { get; set; }

        [JsonProperty("routingNotes")]
        public string RoutingNotes { get; set; }

        [JsonProperty("picYesOrNo")]
        public string PicYesOrNo { get; set; }

        [JsonProperty("assignedToYesOrNo")]
        public string AssignedToYesOrNo { get; set; }

        [JsonProperty("dateExtended")]
        public string DateExtended { get; set; }

        [JsonProperty("daysAtStep")]
        public string DaysAtStep { get; set; }

        [JsonProperty("totalDaysAtStep")]
        public string TotalDaysAtStep { get; set; }

        [JsonProperty("daysBetweenRoutings")]
        public string DaysBetweenRoutings { get; set; }

        [JsonProperty("totalDaysInProcess")]
        public string TotalDaysInProcess { get; set; }

        [JsonProperty("folderID")]
        public string FolderID { get; set; }

        [JsonProperty("filingID")]
        public string FilingID { get; set; }

        [JsonProperty("workflowLastUpdated")]
        public string WorkflowLastUpdated { get; set; }

        [JsonProperty("informationFields")]
        public TrackingReportByWorkflowResponseFirmFlowReportResponseTypeItemInformationFieldsTypeItem[] InformationFields { get; set; }

        [JsonProperty("routingSummary")]
        public JToken[] RoutingSummary { get; set; }

        [JsonProperty("responsibleUserOrGroups")]
        public JToken[] ResponsibleUserOrGroups { get; set; }
    }

    public class TrackingReportByWorkflowResponseFirmFlowReportResponseTypeItemInformationFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AddMasterDeliverableResponse
    {
        [JsonProperty("isSaved")]
        public bool IsSaved { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class RouteWorkflowV2Response
    {
        [JsonProperty("filingId")]
        public string FilingId { get; set; }

        [JsonProperty("isRouted")]
        public bool IsRouted { get; set; }
    }

    public class TrackingReportByDeliverableV2Response
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("pageNumber")]
        public string PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("firmFlowReportResponse")]
        public TrackingReportByDeliverableV2ResponseFirmFlowReportResponseTypeItem[] FirmFlowReportResponse { get; set; }

        [JsonProperty("getFirmFlowException")]
        public string GetFirmFlowException { get; set; }
    }

    public class TrackingReportByDeliverableV2ResponseFirmFlowReportResponseTypeItem
    {
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientNumber")]
        public string ClientNumber { get; set; }

        [JsonProperty("drawerId")]
        public string DrawerId { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("engagementType")]
        public string EngagementType { get; set; }

        [JsonProperty("workflow")]
        public string Workflow { get; set; }

        [JsonProperty("currentStep")]
        public string CurrentStep { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("assignedOn")]
        public string AssignedOn { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("periodEnd")]
        public string PeriodEnd { get; set; }

        [JsonProperty("workflowDescription")]
        public string WorkflowDescription { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("eFileYesOrNo")]
        public string EFileYesOrNo { get; set; }

        [JsonProperty("extendedYesOrNo")]
        public string ExtendedYesOrNo { get; set; }

        [JsonProperty("receivedOn")]
        public string ReceivedOn { get; set; }

        [JsonProperty("completedOn")]
        public string CompletedOn { get; set; }

        [JsonProperty("sentOn")]
        public string SentOn { get; set; }

        [JsonProperty("deliverables")]
        public string Deliverables { get; set; }

        [JsonProperty("responsible")]
        public string Responsible { get; set; }

        [JsonProperty("assignmentHistory")]
        public string AssignmentHistory { get; set; }

        [JsonProperty("receivedFrom")]
        public string ReceivedFrom { get; set; }

        [JsonProperty("sentTo")]
        public string SentTo { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("accountable")]
        public string Accountable { get; set; }

        [JsonProperty("currentDueDate")]
        public string CurrentDueDate { get; set; }

        [JsonProperty("originalDueDate")]
        public string OriginalDueDate { get; set; }

        [JsonProperty("routingNotes")]
        public string RoutingNotes { get; set; }

        [JsonProperty("picYesOrNo")]
        public string PicYesOrNo { get; set; }

        [JsonProperty("assignedToYesOrNo")]
        public string AssignedToYesOrNo { get; set; }

        [JsonProperty("dateExtended")]
        public string DateExtended { get; set; }

        [JsonProperty("daysAtStep")]
        public string DaysAtStep { get; set; }

        [JsonProperty("totalDaysAtStep")]
        public string TotalDaysAtStep { get; set; }

        [JsonProperty("daysBetweenRoutings")]
        public string DaysBetweenRoutings { get; set; }

        [JsonProperty("totalDaysInProcess")]
        public string TotalDaysInProcess { get; set; }

        [JsonProperty("folderID")]
        public string FolderID { get; set; }

        [JsonProperty("filingID")]
        public string FilingID { get; set; }

        [JsonProperty("priorFilingID")]
        public string PriorFilingID { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("informationFields")]
        public TrackingReportByDeliverableV2ResponseFirmFlowReportResponseTypeItemInformationFieldsTypeItem[] InformationFields { get; set; }

        [JsonProperty("routingSummary")]
        public JToken[] RoutingSummary { get; set; }

        [JsonProperty("responsibleUserOrGroups")]
        public JToken[] ResponsibleUserOrGroups { get; set; }
    }

    public class TrackingReportByDeliverableV2ResponseFirmFlowReportResponseTypeItemInformationFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gofileroom;

    public partial class WorkflowManagedActions
    {
        public GofileroomActions Gofileroom(string connectionId) => new GofileroomActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GofileroomTriggers Gofileroom(string connectionId) => new GofileroomTriggers(connectionId);
    }
}
