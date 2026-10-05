//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gofileroom
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GofileroomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGroup))]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyaccessToApproveDocsOnly = null, [WorkflowExpression] Func<string> bodyallowAccessToReports = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyenableMfa = null, [WorkflowExpression] Func<string> bodyenforceMfaForUsers = null, [WorkflowExpression] Func<string> bodyfirmFlowRoutingNotification = null, [WorkflowExpression] Func<string> bodyfullAccessToDocTracking = null, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodymfaRequired = null, [WorkflowExpression] Func<string> bodypermissonToApproveDocs = null, [WorkflowExpression] Func<bodyreportsInputItem[]> bodyreports = null, [WorkflowExpression] Func<string> bodyuploadLocation = null, [WorkflowExpression] Func<string[]> bodyusers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateGroupResponse> __BuildCreateGroup(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyaccessToApproveDocsOnly = null, WorkflowValue<string> bodyallowAccessToReports = null, WorkflowValue<string> bodycomments = null, WorkflowValue<string> bodyenableMfa = null, WorkflowValue<string> bodyenforceMfaForUsers = null, WorkflowValue<string> bodyfirmFlowRoutingNotification = null, WorkflowValue<string> bodyfullAccessToDocTracking = null, WorkflowValue<string> bodygroupName = null, WorkflowValue<string> bodymfaRequired = null, WorkflowValue<string> bodypermissonToApproveDocs = null, WorkflowValue<bodyreportsInputItem[]> bodyreports = null, WorkflowValue<string> bodyuploadLocation = null, WorkflowValue<string[]> bodyusers = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyaccessToApproveDocsOnly, nameof(bodyaccessToApproveDocsOnly), required: false);
            WorkflowValue.Validate(bodyallowAccessToReports, nameof(bodyallowAccessToReports), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowValue.Validate(bodyenableMfa, nameof(bodyenableMfa), required: false);
            WorkflowValue.Validate(bodyenforceMfaForUsers, nameof(bodyenforceMfaForUsers), required: false);
            WorkflowValue.Validate(bodyfirmFlowRoutingNotification, nameof(bodyfirmFlowRoutingNotification), required: false);
            WorkflowValue.Validate(bodyfullAccessToDocTracking, nameof(bodyfullAccessToDocTracking), required: false);
            WorkflowValue.Validate(bodygroupName, nameof(bodygroupName), required: false);
            WorkflowValue.Validate(bodymfaRequired, nameof(bodymfaRequired), required: false);
            WorkflowValue.Validate(bodypermissonToApproveDocs, nameof(bodypermissonToApproveDocs), required: false);
            WorkflowValue.Validate(bodyreports, nameof(bodyreports), required: false);
            WorkflowValue.Validate(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            WorkflowValue.Validate(bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<CreateGroupResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/creategroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccessToApproveDocsOnly != null)
                {
                    body["AccessToApproveDocsOnly"] = ExpressionConverter.ConvertO(bodyaccessToApproveDocsOnly);
                    bodypropCount++;
                }

                if (bodyallowAccessToReports != null)
                {
                    body["AllowAccessToReports"] = ExpressionConverter.ConvertO(bodyallowAccessToReports);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyenableMfa != null)
                {
                    body["EnableMfa"] = ExpressionConverter.ConvertO(bodyenableMfa);
                    bodypropCount++;
                }

                if (bodyenforceMfaForUsers != null)
                {
                    body["EnforceMfaForUsers"] = ExpressionConverter.ConvertO(bodyenforceMfaForUsers);
                    bodypropCount++;
                }

                if (bodyfirmFlowRoutingNotification != null)
                {
                    body["FirmFlowRoutingNotification"] = ExpressionConverter.ConvertO(bodyfirmFlowRoutingNotification);
                    bodypropCount++;
                }

                if (bodyfullAccessToDocTracking != null)
                {
                    body["FullAccessToDocTracking"] = ExpressionConverter.ConvertO(bodyfullAccessToDocTracking);
                    bodypropCount++;
                }

                if (bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                    bodypropCount++;
                }

                if (bodymfaRequired != null)
                {
                    body["MfaRequired"] = ExpressionConverter.ConvertO(bodymfaRequired);
                    bodypropCount++;
                }

                if (bodypermissonToApproveDocs != null)
                {
                    body["PermissonToApproveDocs"] = ExpressionConverter.ConvertO(bodypermissonToApproveDocs);
                    bodypropCount++;
                }

                if (bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(bodyreports);
                    bodypropCount++;
                }

                if (bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(bodyuploadLocation);
                    bodypropCount++;
                }

                if (bodyusers != null)
                {
                    body["Users"] = ExpressionConverter.ConvertO(bodyusers);
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
        [WorkflowExpressionFactory(nameof(__BuildSetGroupDocSecurity))]
        public IBodyWorkflowAction<SetGroupDocSecurityResponse> SetGroupDocSecurity([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodycabinetName = null, [WorkflowExpression] Func<bodydocumentSecurityInputItem[]> bodydocumentSecurity = null, [WorkflowExpression] Func<string> bodydrawerName = null, [WorkflowExpression] Func<string> bodygroupName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetGroupDocSecurityResponse> __BuildSetGroupDocSecurity(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodycabinetName = null, WorkflowValue<bodydocumentSecurityInputItem[]> bodydocumentSecurity = null, WorkflowValue<string> bodydrawerName = null, WorkflowValue<string> bodygroupName = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodycabinetName, nameof(bodycabinetName), required: false);
            WorkflowValue.Validate(bodydocumentSecurity, nameof(bodydocumentSecurity), required: false);
            WorkflowValue.Validate(bodydrawerName, nameof(bodydrawerName), required: false);
            WorkflowValue.Validate(bodygroupName, nameof(bodygroupName), required: false);
            return new DeferredBodyAction<SetGroupDocSecurityResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/documentsecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycabinetName != null)
                {
                    body["CabinetName"] = ExpressionConverter.ConvertO(bodycabinetName);
                    bodypropCount++;
                }

                if (bodydocumentSecurity != null)
                {
                    body["DocumentSecurity"] = ExpressionConverter.ConvertO(bodydocumentSecurity);
                    bodypropCount++;
                }

                if (bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(bodydrawerName);
                    bodypropCount++;
                }

                if (bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
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
        [WorkflowExpressionFactory(nameof(__BuildModifyGroup))]
        public IBodyWorkflowAction<ModifyGroupResponse> ModifyGroup([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyaccessToApproveDocsOnly = null, [WorkflowExpression] Func<string> bodyallowAccessToReports = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyenableMfa = null, [WorkflowExpression] Func<string> bodyenforceMfaForUsers = null, [WorkflowExpression] Func<string> bodyfirmFlowRoutingNotification = null, [WorkflowExpression] Func<string> bodyfullAccessToDocTracking = null, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodymfaRequired = null, [WorkflowExpression] Func<string> bodypermissonToApproveDocs = null, [WorkflowExpression] Func<string> bodyrenameGroup = null, [WorkflowExpression] Func<bodyreportsInputItem[]> bodyreports = null, [WorkflowExpression] Func<string> bodyuploadLocation = null, [WorkflowExpression] Func<string[]> bodyusers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModifyGroupResponse> __BuildModifyGroup(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyaccessToApproveDocsOnly = null, WorkflowValue<string> bodyallowAccessToReports = null, WorkflowValue<string> bodycomments = null, WorkflowValue<string> bodyenableMfa = null, WorkflowValue<string> bodyenforceMfaForUsers = null, WorkflowValue<string> bodyfirmFlowRoutingNotification = null, WorkflowValue<string> bodyfullAccessToDocTracking = null, WorkflowValue<string> bodygroupName = null, WorkflowValue<string> bodymfaRequired = null, WorkflowValue<string> bodypermissonToApproveDocs = null, WorkflowValue<string> bodyrenameGroup = null, WorkflowValue<bodyreportsInputItem[]> bodyreports = null, WorkflowValue<string> bodyuploadLocation = null, WorkflowValue<string[]> bodyusers = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyaccessToApproveDocsOnly, nameof(bodyaccessToApproveDocsOnly), required: false);
            WorkflowValue.Validate(bodyallowAccessToReports, nameof(bodyallowAccessToReports), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowValue.Validate(bodyenableMfa, nameof(bodyenableMfa), required: false);
            WorkflowValue.Validate(bodyenforceMfaForUsers, nameof(bodyenforceMfaForUsers), required: false);
            WorkflowValue.Validate(bodyfirmFlowRoutingNotification, nameof(bodyfirmFlowRoutingNotification), required: false);
            WorkflowValue.Validate(bodyfullAccessToDocTracking, nameof(bodyfullAccessToDocTracking), required: false);
            WorkflowValue.Validate(bodygroupName, nameof(bodygroupName), required: false);
            WorkflowValue.Validate(bodymfaRequired, nameof(bodymfaRequired), required: false);
            WorkflowValue.Validate(bodypermissonToApproveDocs, nameof(bodypermissonToApproveDocs), required: false);
            WorkflowValue.Validate(bodyrenameGroup, nameof(bodyrenameGroup), required: false);
            WorkflowValue.Validate(bodyreports, nameof(bodyreports), required: false);
            WorkflowValue.Validate(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            WorkflowValue.Validate(bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<ModifyGroupResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/modifygroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccessToApproveDocsOnly != null)
                {
                    body["AccessToApproveDocsOnly"] = ExpressionConverter.ConvertO(bodyaccessToApproveDocsOnly);
                    bodypropCount++;
                }

                if (bodyallowAccessToReports != null)
                {
                    body["AllowAccessToReports"] = ExpressionConverter.ConvertO(bodyallowAccessToReports);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyenableMfa != null)
                {
                    body["EnableMfa"] = ExpressionConverter.ConvertO(bodyenableMfa);
                    bodypropCount++;
                }

                if (bodyenforceMfaForUsers != null)
                {
                    body["EnforceMfaForUsers"] = ExpressionConverter.ConvertO(bodyenforceMfaForUsers);
                    bodypropCount++;
                }

                if (bodyfirmFlowRoutingNotification != null)
                {
                    body["FirmFlowRoutingNotification"] = ExpressionConverter.ConvertO(bodyfirmFlowRoutingNotification);
                    bodypropCount++;
                }

                if (bodyfullAccessToDocTracking != null)
                {
                    body["FullAccessToDocTracking"] = ExpressionConverter.ConvertO(bodyfullAccessToDocTracking);
                    bodypropCount++;
                }

                if (bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                    bodypropCount++;
                }

                if (bodymfaRequired != null)
                {
                    body["MfaRequired"] = ExpressionConverter.ConvertO(bodymfaRequired);
                    bodypropCount++;
                }

                if (bodypermissonToApproveDocs != null)
                {
                    body["PermissonToApproveDocs"] = ExpressionConverter.ConvertO(bodypermissonToApproveDocs);
                    bodypropCount++;
                }

                if (bodyrenameGroup != null)
                {
                    body["RenameGroup"] = ExpressionConverter.ConvertO(bodyrenameGroup);
                    bodypropCount++;
                }

                if (bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(bodyreports);
                    bodypropCount++;
                }

                if (bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(bodyuploadLocation);
                    bodypropCount++;
                }

                if (bodyusers != null)
                {
                    body["Users"] = ExpressionConverter.ConvertO(bodyusers);
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
        [WorkflowExpressionFactory(nameof(__BuildGetGroupPermissions))]
        public IBodyWorkflowAction<GetGroupPermissionsResponse> GetGroupPermissions([WorkflowExpression] Func<string> groupName = null, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupPermissionsResponse> __BuildGetGroupPermissions(WorkflowValue<string> groupName = null, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(groupName, nameof(groupName), required: false);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupPermissionsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/permissions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (groupName != null)
                    callPayload.Queries["groupName"] = ExpressionConverter.Convert(groupName);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetGroupPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildSetGroupPermissions))]
        public IBodyWorkflowAction<SetGroupPermissionsResponse> SetGroupPermissions([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodycabinet = null, [WorkflowExpression] Func<string> bodycabinetPermissionadd = null, [WorkflowExpression] Func<string> bodycabinetPermissiondelete = null, [WorkflowExpression] Func<string> bodycabinetPermissiondeny = null, [WorkflowExpression] Func<string> bodycabinetPermissionedit = null, [WorkflowExpression] Func<string> bodycabinetPermissionlookUp = null, [WorkflowExpression] Func<string> bodycabinetPermissionread = null, [WorkflowExpression] Func<bodydrawerPermissionsInputItem[]> bodydrawerPermissions = null, [WorkflowExpression] Func<string> bodygroupName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetGroupPermissionsResponse> __BuildSetGroupPermissions(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodycabinet = null, WorkflowValue<string> bodycabinetPermissionadd = null, WorkflowValue<string> bodycabinetPermissiondelete = null, WorkflowValue<string> bodycabinetPermissiondeny = null, WorkflowValue<string> bodycabinetPermissionedit = null, WorkflowValue<string> bodycabinetPermissionlookUp = null, WorkflowValue<string> bodycabinetPermissionread = null, WorkflowValue<bodydrawerPermissionsInputItem[]> bodydrawerPermissions = null, WorkflowValue<string> bodygroupName = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodycabinet, nameof(bodycabinet), required: false);
            WorkflowValue.Validate(bodycabinetPermissionadd, nameof(bodycabinetPermissionadd), required: false);
            WorkflowValue.Validate(bodycabinetPermissiondelete, nameof(bodycabinetPermissiondelete), required: false);
            WorkflowValue.Validate(bodycabinetPermissiondeny, nameof(bodycabinetPermissiondeny), required: false);
            WorkflowValue.Validate(bodycabinetPermissionedit, nameof(bodycabinetPermissionedit), required: false);
            WorkflowValue.Validate(bodycabinetPermissionlookUp, nameof(bodycabinetPermissionlookUp), required: false);
            WorkflowValue.Validate(bodycabinetPermissionread, nameof(bodycabinetPermissionread), required: false);
            WorkflowValue.Validate(bodydrawerPermissions, nameof(bodydrawerPermissions), required: false);
            WorkflowValue.Validate(bodygroupName, nameof(bodygroupName), required: false);
            return new DeferredBodyAction<SetGroupPermissionsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycabinet != null)
                {
                    body["Cabinet"] = ExpressionConverter.ConvertO(bodycabinet);
                    bodypropCount++;
                }

                var cabinetPermissionObject = new JObject();
                var cabinetPermissionObjectpropCount = 0;
                if (bodycabinetPermissionadd != null)
                {
                    cabinetPermissionObject["Add"] = ExpressionConverter.ConvertO(bodycabinetPermissionadd);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissiondelete != null)
                {
                    cabinetPermissionObject["Delete"] = ExpressionConverter.ConvertO(bodycabinetPermissiondelete);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissiondeny != null)
                {
                    cabinetPermissionObject["Deny"] = ExpressionConverter.ConvertO(bodycabinetPermissiondeny);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissionedit != null)
                {
                    cabinetPermissionObject["Edit"] = ExpressionConverter.ConvertO(bodycabinetPermissionedit);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissionlookUp != null)
                {
                    cabinetPermissionObject["LookUp"] = ExpressionConverter.ConvertO(bodycabinetPermissionlookUp);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissionread != null)
                {
                    cabinetPermissionObject["Read"] = ExpressionConverter.ConvertO(bodycabinetPermissionread);
                    cabinetPermissionObjectpropCount++;
                }

                if (cabinetPermissionObjectpropCount > 0)
                {
                    body["CabinetPermission"] = cabinetPermissionObject;
                    bodypropCount++;
                }

                if (bodydrawerPermissions != null)
                {
                    body["DrawerPermissions"] = ExpressionConverter.ConvertO(bodydrawerPermissions);
                    bodypropCount++;
                }

                if (bodygroupName != null)
                {
                    body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
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
        [WorkflowExpressionFactory(nameof(__BuildGetGroupDocumentSecurity))]
        public IBodyWorkflowAction<GetGroupDocumentSecurityResponse> GetGroupDocumentSecurity([WorkflowExpression] Func<string> groupName, [WorkflowExpression] Func<string> cabinetName, [WorkflowExpression] Func<string> drawerName, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupDocumentSecurityResponse> __BuildGetGroupDocumentSecurity(WorkflowValue<string> groupName, WorkflowValue<string> cabinetName, WorkflowValue<string> drawerName, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(groupName, nameof(groupName), required: true);
            WorkflowValue.Validate(cabinetName, nameof(cabinetName), required: true);
            WorkflowValue.Validate(drawerName, nameof(drawerName), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupDocumentSecurityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/administration/group/{0}/{1}/{2}/documentsecurity", ExpressionConverter.ConvertWithUrlEncoding(groupName, 1), ExpressionConverter.ConvertWithUrlEncoding(cabinetName, 1), ExpressionConverter.ConvertWithUrlEncoding(drawerName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetGroupDocumentSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetGroups))]
        public IBodyWorkflowAction<GetGroupsResponseItem[]> GetGroups([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupsResponseItem[]> __BuildGetGroups(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupsResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/administration/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUsers))]
        public IBodyWorkflowAction<CreateUsersResponse> CreateUsers([WorkflowExpression] Func<userTypeInput> userType = null, [WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyaccountExpiresDate = null, [WorkflowExpression] Func<string> bodydisabledComments = null, [WorkflowExpression] Func<string> bodyfullName = null, [WorkflowExpression] Func<string[]> bodygroups = null, [WorkflowExpression] Func<string> bodyisAccountExpires = null, [WorkflowExpression] Func<string> bodyisAdvanceFlow = null, [WorkflowExpression] Func<string> bodyisAllowAccessToReports = null, [WorkflowExpression] Func<string> bodyisAllowOffline = null, [WorkflowExpression] Func<string> bodyisDisabled = null, [WorkflowExpression] Func<string> bodyisFirmFlow = null, [WorkflowExpression] Func<string> bodyisFirmFlowNotificationGroup = null, [WorkflowExpression] Func<string> bodyisFirmFlowNotificationUser = null, [WorkflowExpression] Func<string> bodyisMfa = null, [WorkflowExpression] Func<string> bodyisUserAdministration = null, [WorkflowExpression] Func<string> bodyisWorkflowManagerUser = null, [WorkflowExpression] Func<string> bodylicenseType = null, [WorkflowExpression] Func<string> bodyloginName = null, [WorkflowExpression] Func<string> bodymanagerEmail = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bodyreportsInputItem[]> bodyreports = null, [WorkflowExpression] Func<string> bodyuploadLocation = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUsersResponse> __BuildCreateUsers(WorkflowValue<userTypeInput> userType = null, WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyaccountExpiresDate = null, WorkflowValue<string> bodydisabledComments = null, WorkflowValue<string> bodyfullName = null, WorkflowValue<string[]> bodygroups = null, WorkflowValue<string> bodyisAccountExpires = null, WorkflowValue<string> bodyisAdvanceFlow = null, WorkflowValue<string> bodyisAllowAccessToReports = null, WorkflowValue<string> bodyisAllowOffline = null, WorkflowValue<string> bodyisDisabled = null, WorkflowValue<string> bodyisFirmFlow = null, WorkflowValue<string> bodyisFirmFlowNotificationGroup = null, WorkflowValue<string> bodyisFirmFlowNotificationUser = null, WorkflowValue<string> bodyisMfa = null, WorkflowValue<string> bodyisUserAdministration = null, WorkflowValue<string> bodyisWorkflowManagerUser = null, WorkflowValue<string> bodylicenseType = null, WorkflowValue<string> bodyloginName = null, WorkflowValue<string> bodymanagerEmail = null, WorkflowValue<string> bodypassword = null, WorkflowValue<bodyreportsInputItem[]> bodyreports = null, WorkflowValue<string> bodyuploadLocation = null)
        {
            WorkflowValue.Validate(userType, nameof(userType), required: false);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyaccountExpiresDate, nameof(bodyaccountExpiresDate), required: false);
            WorkflowValue.Validate(bodydisabledComments, nameof(bodydisabledComments), required: false);
            WorkflowValue.Validate(bodyfullName, nameof(bodyfullName), required: false);
            WorkflowValue.Validate(bodygroups, nameof(bodygroups), required: false);
            WorkflowValue.Validate(bodyisAccountExpires, nameof(bodyisAccountExpires), required: false);
            WorkflowValue.Validate(bodyisAdvanceFlow, nameof(bodyisAdvanceFlow), required: false);
            WorkflowValue.Validate(bodyisAllowAccessToReports, nameof(bodyisAllowAccessToReports), required: false);
            WorkflowValue.Validate(bodyisAllowOffline, nameof(bodyisAllowOffline), required: false);
            WorkflowValue.Validate(bodyisDisabled, nameof(bodyisDisabled), required: false);
            WorkflowValue.Validate(bodyisFirmFlow, nameof(bodyisFirmFlow), required: false);
            WorkflowValue.Validate(bodyisFirmFlowNotificationGroup, nameof(bodyisFirmFlowNotificationGroup), required: false);
            WorkflowValue.Validate(bodyisFirmFlowNotificationUser, nameof(bodyisFirmFlowNotificationUser), required: false);
            WorkflowValue.Validate(bodyisMfa, nameof(bodyisMfa), required: false);
            WorkflowValue.Validate(bodyisUserAdministration, nameof(bodyisUserAdministration), required: false);
            WorkflowValue.Validate(bodyisWorkflowManagerUser, nameof(bodyisWorkflowManagerUser), required: false);
            WorkflowValue.Validate(bodylicenseType, nameof(bodylicenseType), required: false);
            WorkflowValue.Validate(bodyloginName, nameof(bodyloginName), required: false);
            WorkflowValue.Validate(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowValue.Validate(bodyreports, nameof(bodyreports), required: false);
            WorkflowValue.Validate(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            return new DeferredBodyAction<CreateUsersResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/createuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userType"] = Convert.ToString("GFRUSERS");
                if (userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(userType);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountExpiresDate != null)
                {
                    body["AccountExpiresDate"] = ExpressionConverter.ConvertO(bodyaccountExpiresDate);
                    bodypropCount++;
                }

                if (bodydisabledComments != null)
                {
                    body["DisabledComments"] = ExpressionConverter.ConvertO(bodydisabledComments);
                    bodypropCount++;
                }

                if (bodyfullName != null)
                {
                    body["FullName"] = ExpressionConverter.ConvertO(bodyfullName);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["Groups"] = ExpressionConverter.ConvertO(bodygroups);
                    bodypropCount++;
                }

                if (bodyisAccountExpires != null)
                {
                    body["IsAccountExpires"] = ExpressionConverter.ConvertO(bodyisAccountExpires);
                    bodypropCount++;
                }

                if (bodyisAdvanceFlow != null)
                {
                    body["IsAdvanceFlow"] = ExpressionConverter.ConvertO(bodyisAdvanceFlow);
                    bodypropCount++;
                }

                if (bodyisAllowAccessToReports != null)
                {
                    body["IsAllowAccessToReports"] = ExpressionConverter.ConvertO(bodyisAllowAccessToReports);
                    bodypropCount++;
                }

                if (bodyisAllowOffline != null)
                {
                    body["IsAllowOffline"] = ExpressionConverter.ConvertO(bodyisAllowOffline);
                    bodypropCount++;
                }

                if (bodyisDisabled != null)
                {
                    body["IsDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                    bodypropCount++;
                }

                if (bodyisFirmFlow != null)
                {
                    body["IsFirmFlow"] = ExpressionConverter.ConvertO(bodyisFirmFlow);
                    bodypropCount++;
                }

                if (bodyisFirmFlowNotificationGroup != null)
                {
                    body["IsFirmFlowNotificationGroup"] = ExpressionConverter.ConvertO(bodyisFirmFlowNotificationGroup);
                    bodypropCount++;
                }

                if (bodyisFirmFlowNotificationUser != null)
                {
                    body["IsFirmFlowNotificationUser"] = ExpressionConverter.ConvertO(bodyisFirmFlowNotificationUser);
                    bodypropCount++;
                }

                if (bodyisMfa != null)
                {
                    body["IsMfa"] = ExpressionConverter.ConvertO(bodyisMfa);
                    bodypropCount++;
                }

                if (bodyisUserAdministration != null)
                {
                    body["IsUserAdministration"] = ExpressionConverter.ConvertO(bodyisUserAdministration);
                    bodypropCount++;
                }

                if (bodyisWorkflowManagerUser != null)
                {
                    body["IsWorkflowManagerUser"] = ExpressionConverter.ConvertO(bodyisWorkflowManagerUser);
                    bodypropCount++;
                }

                if (bodylicenseType != null)
                {
                    body["LicenseType"] = ExpressionConverter.ConvertO(bodylicenseType);
                    bodypropCount++;
                }

                if (bodyloginName != null)
                {
                    body["LoginName"] = ExpressionConverter.ConvertO(bodyloginName);
                    bodypropCount++;
                }

                if (bodymanagerEmail != null)
                {
                    body["ManagerEmail"] = ExpressionConverter.ConvertO(bodymanagerEmail);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(bodyreports);
                    bodypropCount++;
                }

                if (bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(bodyuploadLocation);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteUser))]
        public IBodyWorkflowAction<DeleteUserResponse> DeleteUser([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyloginId = null, [WorkflowExpression] Func<bodyuserTypeInput> bodyuserType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteUserResponse> __BuildDeleteUser(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyloginId = null, WorkflowValue<bodyuserTypeInput> bodyuserType = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyloginId, nameof(bodyloginId), required: false);
            WorkflowValue.Validate(bodyuserType, nameof(bodyuserType), required: false);
            return new DeferredBodyAction<DeleteUserResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyloginId != null)
                {
                    body["LoginId"] = ExpressionConverter.ConvertO(bodyloginId);
                    bodypropCount++;
                }

                if (bodyuserType != null)
                {
                    body["UserType"] = ExpressionConverter.ConvertO(bodyuserType);
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
        [WorkflowExpressionFactory(nameof(__BuildSetUserDocSecurity))]
        public IBodyWorkflowAction<SetUserDocSecurityResponse> SetUserDocSecurity([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodycabinetName = null, [WorkflowExpression] Func<bodydocumentSecurityInputItem2[]> bodydocumentSecurity = null, [WorkflowExpression] Func<string> bodydrawerName = null, [WorkflowExpression] Func<string> bodyloginId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetUserDocSecurityResponse> __BuildSetUserDocSecurity(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodycabinetName = null, WorkflowValue<bodydocumentSecurityInputItem2[]> bodydocumentSecurity = null, WorkflowValue<string> bodydrawerName = null, WorkflowValue<string> bodyloginId = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodycabinetName, nameof(bodycabinetName), required: false);
            WorkflowValue.Validate(bodydocumentSecurity, nameof(bodydocumentSecurity), required: false);
            WorkflowValue.Validate(bodydrawerName, nameof(bodydrawerName), required: false);
            WorkflowValue.Validate(bodyloginId, nameof(bodyloginId), required: false);
            return new DeferredBodyAction<SetUserDocSecurityResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/documentsecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycabinetName != null)
                {
                    body["CabinetName"] = ExpressionConverter.ConvertO(bodycabinetName);
                    bodypropCount++;
                }

                if (bodydocumentSecurity != null)
                {
                    body["DocumentSecurity"] = ExpressionConverter.ConvertO(bodydocumentSecurity);
                    bodypropCount++;
                }

                if (bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(bodydrawerName);
                    bodypropCount++;
                }

                if (bodyloginId != null)
                {
                    body["LoginId"] = ExpressionConverter.ConvertO(bodyloginId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetUserInfo))]
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo([WorkflowExpression] Func<string> bodyloginName, [WorkflowExpression] Func<string> bodyuserType, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserInfoResponse> __BuildGetUserInfo(WorkflowValue<string> bodyloginName, WorkflowValue<string> bodyuserType, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(bodyloginName, nameof(bodyloginName), required: true);
            WorkflowValue.Validate(bodyuserType, nameof(bodyuserType), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserInfoResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/getuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["LoginName"] = ExpressionConverter.ConvertO(bodyloginName);
                bodypropCount++;
                body["UserType"] = ExpressionConverter.ConvertO(bodyuserType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetLicenses))]
        public IBodyWorkflowAction<GetLicensesResponse> GetLicenses([WorkflowExpression] Func<licenseInput> license = null, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLicensesResponse> __BuildGetLicenses(WorkflowValue<licenseInput> license = null, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(license, nameof(license), required: false);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetLicensesResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/licenses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (license != null)
                    callPayload.Queries["license"] = ExpressionConverter.Convert(license);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetLicensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildModifyUser))]
        public IBodyWorkflowAction<ModifyUserResponse> ModifyUser([WorkflowExpression] Func<userTypeInput> userType = null, [WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyaccountExpiresDate = null, [WorkflowExpression] Func<string> bodydisabledComments = null, [WorkflowExpression] Func<string> bodyfullName = null, [WorkflowExpression] Func<string[]> bodygroups = null, [WorkflowExpression] Func<string> bodyisAccountExpires = null, [WorkflowExpression] Func<string> bodyisAdvanceFlow = null, [WorkflowExpression] Func<string> bodyisAllowAccessToReports = null, [WorkflowExpression] Func<string> bodyisAllowOffline = null, [WorkflowExpression] Func<string> bodyisChangeNextLogin = null, [WorkflowExpression] Func<string> bodyisDisabled = null, [WorkflowExpression] Func<string> bodyisFirmFlow = null, [WorkflowExpression] Func<string> bodyisFirmFlowNotificationGroup = null, [WorkflowExpression] Func<string> bodyisFirmFlowNotificationUser = null, [WorkflowExpression] Func<string> bodyisMfa = null, [WorkflowExpression] Func<string> bodyisUserAdministration = null, [WorkflowExpression] Func<string> bodyisWorkflowManagerUser = null, [WorkflowExpression] Func<string> bodylicenseType = null, [WorkflowExpression] Func<string> bodyloginName = null, [WorkflowExpression] Func<string> bodymanagerEmail = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bodyreportsInputItem[]> bodyreports = null, [WorkflowExpression] Func<string> bodyuploadLocation = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModifyUserResponse> __BuildModifyUser(WorkflowValue<userTypeInput> userType = null, WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyaccountExpiresDate = null, WorkflowValue<string> bodydisabledComments = null, WorkflowValue<string> bodyfullName = null, WorkflowValue<string[]> bodygroups = null, WorkflowValue<string> bodyisAccountExpires = null, WorkflowValue<string> bodyisAdvanceFlow = null, WorkflowValue<string> bodyisAllowAccessToReports = null, WorkflowValue<string> bodyisAllowOffline = null, WorkflowValue<string> bodyisChangeNextLogin = null, WorkflowValue<string> bodyisDisabled = null, WorkflowValue<string> bodyisFirmFlow = null, WorkflowValue<string> bodyisFirmFlowNotificationGroup = null, WorkflowValue<string> bodyisFirmFlowNotificationUser = null, WorkflowValue<string> bodyisMfa = null, WorkflowValue<string> bodyisUserAdministration = null, WorkflowValue<string> bodyisWorkflowManagerUser = null, WorkflowValue<string> bodylicenseType = null, WorkflowValue<string> bodyloginName = null, WorkflowValue<string> bodymanagerEmail = null, WorkflowValue<string> bodypassword = null, WorkflowValue<bodyreportsInputItem[]> bodyreports = null, WorkflowValue<string> bodyuploadLocation = null)
        {
            WorkflowValue.Validate(userType, nameof(userType), required: false);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyaccountExpiresDate, nameof(bodyaccountExpiresDate), required: false);
            WorkflowValue.Validate(bodydisabledComments, nameof(bodydisabledComments), required: false);
            WorkflowValue.Validate(bodyfullName, nameof(bodyfullName), required: false);
            WorkflowValue.Validate(bodygroups, nameof(bodygroups), required: false);
            WorkflowValue.Validate(bodyisAccountExpires, nameof(bodyisAccountExpires), required: false);
            WorkflowValue.Validate(bodyisAdvanceFlow, nameof(bodyisAdvanceFlow), required: false);
            WorkflowValue.Validate(bodyisAllowAccessToReports, nameof(bodyisAllowAccessToReports), required: false);
            WorkflowValue.Validate(bodyisAllowOffline, nameof(bodyisAllowOffline), required: false);
            WorkflowValue.Validate(bodyisChangeNextLogin, nameof(bodyisChangeNextLogin), required: false);
            WorkflowValue.Validate(bodyisDisabled, nameof(bodyisDisabled), required: false);
            WorkflowValue.Validate(bodyisFirmFlow, nameof(bodyisFirmFlow), required: false);
            WorkflowValue.Validate(bodyisFirmFlowNotificationGroup, nameof(bodyisFirmFlowNotificationGroup), required: false);
            WorkflowValue.Validate(bodyisFirmFlowNotificationUser, nameof(bodyisFirmFlowNotificationUser), required: false);
            WorkflowValue.Validate(bodyisMfa, nameof(bodyisMfa), required: false);
            WorkflowValue.Validate(bodyisUserAdministration, nameof(bodyisUserAdministration), required: false);
            WorkflowValue.Validate(bodyisWorkflowManagerUser, nameof(bodyisWorkflowManagerUser), required: false);
            WorkflowValue.Validate(bodylicenseType, nameof(bodylicenseType), required: false);
            WorkflowValue.Validate(bodyloginName, nameof(bodyloginName), required: false);
            WorkflowValue.Validate(bodymanagerEmail, nameof(bodymanagerEmail), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowValue.Validate(bodyreports, nameof(bodyreports), required: false);
            WorkflowValue.Validate(bodyuploadLocation, nameof(bodyuploadLocation), required: false);
            return new DeferredBodyAction<ModifyUserResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/modifyuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(userType);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountExpiresDate != null)
                {
                    body["AccountExpiresDate"] = ExpressionConverter.ConvertO(bodyaccountExpiresDate);
                    bodypropCount++;
                }

                if (bodydisabledComments != null)
                {
                    body["DisabledComments"] = ExpressionConverter.ConvertO(bodydisabledComments);
                    bodypropCount++;
                }

                if (bodyfullName != null)
                {
                    body["FullName"] = ExpressionConverter.ConvertO(bodyfullName);
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["Groups"] = ExpressionConverter.ConvertO(bodygroups);
                    bodypropCount++;
                }

                if (bodyisAccountExpires != null)
                {
                    body["IsAccountExpires"] = ExpressionConverter.ConvertO(bodyisAccountExpires);
                    bodypropCount++;
                }

                if (bodyisAdvanceFlow != null)
                {
                    body["IsAdvanceFlow"] = ExpressionConverter.ConvertO(bodyisAdvanceFlow);
                    bodypropCount++;
                }

                if (bodyisAllowAccessToReports != null)
                {
                    body["IsAllowAccessToReports"] = ExpressionConverter.ConvertO(bodyisAllowAccessToReports);
                    bodypropCount++;
                }

                if (bodyisAllowOffline != null)
                {
                    body["IsAllowOffline"] = ExpressionConverter.ConvertO(bodyisAllowOffline);
                    bodypropCount++;
                }

                if (bodyisChangeNextLogin != null)
                {
                    body["IsChangeNextLogin"] = ExpressionConverter.ConvertO(bodyisChangeNextLogin);
                    bodypropCount++;
                }

                if (bodyisDisabled != null)
                {
                    body["IsDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                    bodypropCount++;
                }

                if (bodyisFirmFlow != null)
                {
                    body["IsFirmFlow"] = ExpressionConverter.ConvertO(bodyisFirmFlow);
                    bodypropCount++;
                }

                if (bodyisFirmFlowNotificationGroup != null)
                {
                    body["IsFirmFlowNotificationGroup"] = ExpressionConverter.ConvertO(bodyisFirmFlowNotificationGroup);
                    bodypropCount++;
                }

                if (bodyisFirmFlowNotificationUser != null)
                {
                    body["IsFirmFlowNotificationUser"] = ExpressionConverter.ConvertO(bodyisFirmFlowNotificationUser);
                    bodypropCount++;
                }

                if (bodyisMfa != null)
                {
                    body["IsMfa"] = ExpressionConverter.ConvertO(bodyisMfa);
                    bodypropCount++;
                }

                if (bodyisUserAdministration != null)
                {
                    body["IsUserAdministration"] = ExpressionConverter.ConvertO(bodyisUserAdministration);
                    bodypropCount++;
                }

                if (bodyisWorkflowManagerUser != null)
                {
                    body["IsWorkflowManagerUser"] = ExpressionConverter.ConvertO(bodyisWorkflowManagerUser);
                    bodypropCount++;
                }

                if (bodylicenseType != null)
                {
                    body["LicenseType"] = ExpressionConverter.ConvertO(bodylicenseType);
                    bodypropCount++;
                }

                if (bodyloginName != null)
                {
                    body["LoginName"] = ExpressionConverter.ConvertO(bodyloginName);
                    bodypropCount++;
                }

                if (bodymanagerEmail != null)
                {
                    body["ManagerEmail"] = ExpressionConverter.ConvertO(bodymanagerEmail);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodyreports != null)
                {
                    body["Reports"] = ExpressionConverter.ConvertO(bodyreports);
                    bodypropCount++;
                }

                if (bodyuploadLocation != null)
                {
                    body["UploadLocation"] = ExpressionConverter.ConvertO(bodyuploadLocation);
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
        [WorkflowExpressionFactory(nameof(__BuildGetPasswordPolicy))]
        public IBodyWorkflowAction<GetPasswordPolicyResponse> GetPasswordPolicy([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPasswordPolicyResponse> __BuildGetPasswordPolicy(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetPasswordPolicyResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/passwordpolicy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetPasswordPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildSetUserPermissions))]
        public IBodyWorkflowAction<SetUserPermissionsResponse> SetUserPermissions([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodycabinet = null, [WorkflowExpression] Func<string> bodycabinetPermissionadd = null, [WorkflowExpression] Func<string> bodycabinetPermissiondelete = null, [WorkflowExpression] Func<string> bodycabinetPermissiondeny = null, [WorkflowExpression] Func<string> bodycabinetPermissionedit = null, [WorkflowExpression] Func<string> bodycabinetPermissionlookUp = null, [WorkflowExpression] Func<string> bodycabinetPermissionread = null, [WorkflowExpression] Func<bodydrawerPermissionsInputItem[]> bodydrawerPermissions = null, [WorkflowExpression] Func<string> bodyloginId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetUserPermissionsResponse> __BuildSetUserPermissions(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodycabinet = null, WorkflowValue<string> bodycabinetPermissionadd = null, WorkflowValue<string> bodycabinetPermissiondelete = null, WorkflowValue<string> bodycabinetPermissiondeny = null, WorkflowValue<string> bodycabinetPermissionedit = null, WorkflowValue<string> bodycabinetPermissionlookUp = null, WorkflowValue<string> bodycabinetPermissionread = null, WorkflowValue<bodydrawerPermissionsInputItem[]> bodydrawerPermissions = null, WorkflowValue<string> bodyloginId = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodycabinet, nameof(bodycabinet), required: false);
            WorkflowValue.Validate(bodycabinetPermissionadd, nameof(bodycabinetPermissionadd), required: false);
            WorkflowValue.Validate(bodycabinetPermissiondelete, nameof(bodycabinetPermissiondelete), required: false);
            WorkflowValue.Validate(bodycabinetPermissiondeny, nameof(bodycabinetPermissiondeny), required: false);
            WorkflowValue.Validate(bodycabinetPermissionedit, nameof(bodycabinetPermissionedit), required: false);
            WorkflowValue.Validate(bodycabinetPermissionlookUp, nameof(bodycabinetPermissionlookUp), required: false);
            WorkflowValue.Validate(bodycabinetPermissionread, nameof(bodycabinetPermissionread), required: false);
            WorkflowValue.Validate(bodydrawerPermissions, nameof(bodydrawerPermissions), required: false);
            WorkflowValue.Validate(bodyloginId, nameof(bodyloginId), required: false);
            return new DeferredBodyAction<SetUserPermissionsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycabinet != null)
                {
                    body["Cabinet"] = ExpressionConverter.ConvertO(bodycabinet);
                    bodypropCount++;
                }

                var cabinetPermissionObject = new JObject();
                var cabinetPermissionObjectpropCount = 0;
                if (bodycabinetPermissionadd != null)
                {
                    cabinetPermissionObject["Add"] = ExpressionConverter.ConvertO(bodycabinetPermissionadd);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissiondelete != null)
                {
                    cabinetPermissionObject["Delete"] = ExpressionConverter.ConvertO(bodycabinetPermissiondelete);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissiondeny != null)
                {
                    cabinetPermissionObject["Deny"] = ExpressionConverter.ConvertO(bodycabinetPermissiondeny);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissionedit != null)
                {
                    cabinetPermissionObject["Edit"] = ExpressionConverter.ConvertO(bodycabinetPermissionedit);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissionlookUp != null)
                {
                    cabinetPermissionObject["LookUp"] = ExpressionConverter.ConvertO(bodycabinetPermissionlookUp);
                    cabinetPermissionObjectpropCount++;
                }

                if (bodycabinetPermissionread != null)
                {
                    cabinetPermissionObject["Read"] = ExpressionConverter.ConvertO(bodycabinetPermissionread);
                    cabinetPermissionObjectpropCount++;
                }

                if (cabinetPermissionObjectpropCount > 0)
                {
                    body["CabinetPermission"] = cabinetPermissionObject;
                    bodypropCount++;
                }

                if (bodydrawerPermissions != null)
                {
                    body["DrawerPermissions"] = ExpressionConverter.ConvertO(bodydrawerPermissions);
                    bodypropCount++;
                }

                if (bodyloginId != null)
                {
                    body["LoginId"] = ExpressionConverter.ConvertO(bodyloginId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetListOfReports))]
        public IBodyWorkflowAction<GetListOfReportsResponse> GetListOfReports([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListOfReportsResponse> __BuildGetListOfReports(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetListOfReportsResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetListOfReportsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetUploadLocation))]
        public IBodyWorkflowAction<GetUploadLocationResponse> GetUploadLocation([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUploadLocationResponse> __BuildGetUploadLocation(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUploadLocationResponse>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/uploadlocations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetUploadLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserDocumentSecurity))]
        public IBodyWorkflowAction<GetUserDocumentSecurityResponse> GetUserDocumentSecurity([WorkflowExpression] Func<string> loginId, [WorkflowExpression] Func<string> cabinetName, [WorkflowExpression] Func<string> drawerName, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserDocumentSecurityResponse> __BuildGetUserDocumentSecurity(WorkflowValue<string> loginId, WorkflowValue<string> cabinetName, WorkflowValue<string> drawerName, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(loginId, nameof(loginId), required: true);
            WorkflowValue.Validate(cabinetName, nameof(cabinetName), required: true);
            WorkflowValue.Validate(drawerName, nameof(drawerName), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserDocumentSecurityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/administration/user/{0}/{1}/{2}/documentsecurity", ExpressionConverter.ConvertWithUrlEncoding(loginId, 1), ExpressionConverter.ConvertWithUrlEncoding(cabinetName, 1), ExpressionConverter.ConvertWithUrlEncoding(drawerName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetUserDocumentSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserPermission))]
        public IBodyWorkflowAction<GetUserPermissionResponse> GetUserPermission([WorkflowExpression] Func<string> login, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserPermissionResponse> __BuildGetUserPermission(WorkflowValue<string> login, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(login, nameof(login), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserPermissionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/administration/user/{0}/permissions", ExpressionConverter.ConvertWithUrlEncoding(login, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetUserPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetUsers))]
        public IBodyWorkflowAction<GetUsersResponseItem[]> GetUsers([WorkflowExpression] Func<userTypeInput> userType = null, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUsersResponseItem[]> __BuildGetUsers(WorkflowValue<userTypeInput> userType = null, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(userType, nameof(userType), required: false);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUsersResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/administration/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(userType);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetLookupList))]
        public IBodyWorkflowAction<GetLookupListResponseItem[]> GetLookupList([WorkflowExpression] Func<string> drawerId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLookupListResponseItem[]> __BuildGetLookupList(WorkflowValue<string> drawerId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(drawerId, nameof(drawerId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetLookupListResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/administration/{0}/clients", ExpressionConverter.ConvertWithUrlEncoding(drawerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetLookupListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydrawerId = null, [WorkflowExpression] Func<bodyindexesInputItem[]> bodyindexes = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentResponse> __BuildCreateDocument(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydrawerId = null, WorkflowValue<bodyindexesInputItem[]> bodyindexes = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydrawerId, nameof(bodydrawerId), required: false);
            WorkflowValue.Validate(bodyindexes, nameof(bodyindexes), required: false);
            return new DeferredBodyAction<CreateDocumentResponse>(() =>
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(bodydrawerId);
                    bodypropCount++;
                }

                if (bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(bodyindexes);
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
        [WorkflowExpressionFactory(nameof(__BuildCopyDocument))]
        public IBodyWorkflowAction<CopyDocumentResponseItem[]> CopyDocument([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string[]> bodydocumentIds = null, [WorkflowExpression] Func<bodyindexValuesInputItem[]> bodyindexValues = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CopyDocumentResponseItem[]> __BuildCopyDocument(WorkflowValue<string> xAuthorization = null, WorkflowValue<string[]> bodydocumentIds = null, WorkflowValue<bodyindexValuesInputItem[]> bodyindexValues = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydocumentIds, nameof(bodydocumentIds), required: false);
            WorkflowValue.Validate(bodyindexValues, nameof(bodyindexValues), required: false);
            return new DeferredBodyAction<CopyDocumentResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/copy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentIds != null)
                {
                    body["DocumentIds"] = ExpressionConverter.ConvertO(bodydocumentIds);
                    bodypropCount++;
                }

                if (bodyindexValues != null)
                {
                    body["IndexValues"] = ExpressionConverter.ConvertO(bodyindexValues);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentStatus))]
        public IBodyWorkflowAction<GetDocumentStatusResponseItem[]> GetDocumentStatus([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentStatusResponseItem[]> __BuildGetDocumentStatus(WorkflowValue<string> xAuthorization = null, WorkflowValue<string[]> body = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<GetDocumentStatusResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<GetDocumentStatusResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildMergePDF))]
        public IBodyWorkflowAction<string> MergePDF([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergePDF(WorkflowValue<string> xAuthorization = null, WorkflowValue<string[]> body = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/v1/documents/mergePDFs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentReindex))]
        public IBodyWorkflowAction<DocumentReindexResponseItem[]> DocumentReindex([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string[]> bodydocumentIds = null, [WorkflowExpression] Func<bodyindexValuesInputItem[]> bodyindexValues = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentReindexResponseItem[]> __BuildDocumentReindex(WorkflowValue<string> xAuthorization = null, WorkflowValue<string[]> bodydocumentIds = null, WorkflowValue<bodyindexValuesInputItem[]> bodyindexValues = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydocumentIds, nameof(bodydocumentIds), required: false);
            WorkflowValue.Validate(bodyindexValues, nameof(bodyindexValues), required: false);
            return new DeferredBodyAction<DocumentReindexResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/reindex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentIds != null)
                {
                    body["DocumentIds"] = ExpressionConverter.ConvertO(bodydocumentIds);
                    bodypropCount++;
                }

                if (bodyindexValues != null)
                {
                    body["IndexValues"] = ExpressionConverter.ConvertO(bodyindexValues);
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
        [WorkflowExpressionFactory(nameof(__BuildDocumentSearch))]
        public IBodyWorkflowAction<DocumentSearchResponse> DocumentSearch([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydrawerId = null, [WorkflowExpression] Func<bodyfilterindexValuesInputItem[]> bodyfilterindexValues = null, [WorkflowExpression] Func<int> bodynumberOfRows = null, [WorkflowExpression] Func<int> bodypageNumber = null, [WorkflowExpression] Func<string> bodysortField = null, [WorkflowExpression] Func<bodysortOrderInput> bodysortOrder = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentSearchResponse> __BuildDocumentSearch(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydrawerId = null, WorkflowValue<bodyfilterindexValuesInputItem[]> bodyfilterindexValues = null, WorkflowValue<int> bodynumberOfRows = null, WorkflowValue<int> bodypageNumber = null, WorkflowValue<string> bodysortField = null, WorkflowValue<bodysortOrderInput> bodysortOrder = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydrawerId, nameof(bodydrawerId), required: false);
            WorkflowValue.Validate(bodyfilterindexValues, nameof(bodyfilterindexValues), required: false);
            WorkflowValue.Validate(bodynumberOfRows, nameof(bodynumberOfRows), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodysortField, nameof(bodysortField), required: false);
            WorkflowValue.Validate(bodysortOrder, nameof(bodysortOrder), required: false);
            return new DeferredBodyAction<DocumentSearchResponse>(() =>
            {
                var apiCallPath = "/api/v1/documents/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(bodydrawerId);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterindexValues != null)
                {
                    filterObject["IndexValues"] = ExpressionConverter.ConvertO(bodyfilterindexValues);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodynumberOfRows != null)
                {
                    body["NumberOfRows"] = ExpressionConverter.ConvertO(bodynumberOfRows);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodysortField != null)
                {
                    body["SortField"] = ExpressionConverter.ConvertO(bodysortField);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["SortOrder"] = ExpressionConverter.ConvertO(bodysortOrder);
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
        [WorkflowExpressionFactory(nameof(__BuildTaxsortDocument))]
        public IBodyWorkflowAction<TaxsortDocumentResponseItem[]> TaxsortDocument([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaxsortDocumentResponseItem[]> __BuildTaxsortDocument(WorkflowValue<string> xAuthorization = null, WorkflowValue<string[]> body = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<TaxsortDocumentResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/documents/taxsort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<TaxsortDocumentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentDelete))]
        public IBodyWorkflowAction<DocumentDeleteResponseItem[]> DocumentDelete([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentDeleteResponseItem[]> __BuildDocumentDelete(WorkflowValue<string> documentId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<DocumentDeleteResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<DocumentDeleteResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocument))]
        public IWorkflowAction GetDocument([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocument(WorkflowValue<string> documentId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/file", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentHistory))]
        public IBodyWorkflowAction<GetDocumentHistoryResponse> GetDocumentHistory([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentHistoryResponse> __BuildGetDocumentHistory(WorkflowValue<string> documentId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDocumentHistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetDocumentHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentIndexes))]
        public IBodyWorkflowAction<GetDocumentIndexesResponseItem[]> GetDocumentIndexes([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentIndexesResponseItem[]> __BuildGetDocumentIndexes(WorkflowValue<string> documentId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDocumentIndexesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/indexes", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetDocumentIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildPublishDocumentStatus))]
        public IBodyWorkflowAction<PublishDocumentStatusResponseItem[]> PublishDocumentStatus([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyisPublished, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PublishDocumentStatusResponseItem[]> __BuildPublishDocumentStatus(WorkflowValue<string> documentId, WorkflowValue<string> bodyisPublished, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyisPublished, nameof(bodyisPublished), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<PublishDocumentStatusResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["IsPublished"] = ExpressionConverter.ConvertO(bodyisPublished);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PublishDocumentStatusResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetDrawers))]
        public IBodyWorkflowAction<GetDrawersResponseItem[]> GetDrawers([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDrawersResponseItem[]> __BuildGetDrawers(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDrawersResponseItem[]>(() =>
            {
                var apiCallPath = "/api/v1/drawers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetDrawersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetDrawerIndexes))]
        public IBodyWorkflowAction<GetDrawerIndexesResponseItem[]> GetDrawerIndexes([WorkflowExpression] Func<string> drawerId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDrawerIndexesResponseItem[]> __BuildGetDrawerIndexes(WorkflowValue<string> drawerId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(drawerId, nameof(drawerId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDrawerIndexesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/drawers/{0}/indexes", ExpressionConverter.ConvertWithUrlEncoding(drawerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetDrawerIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetFirmFlowDeliverableReport))]
        public IBodyWorkflowAction<GetFirmFlowDeliverableReportResponse> GetFirmFlowDeliverableReport([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyaccountable = null, [WorkflowExpression] Func<string> bodyassignedOn = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodyassignmentHistory = null, [WorkflowExpression] Func<string> bodycompletedBy = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodycurrentDueDate = null, [WorkflowExpression] Func<string> bodycurrentStep = null, [WorkflowExpression] Func<string> bodydateExtended = null, [WorkflowExpression] Func<string> bodydaysAtStep = null, [WorkflowExpression] Func<string> bodydaysBetweenRoutings = null, [WorkflowExpression] Func<string> bodydrawerId = null, [WorkflowExpression] Func<string> bodyengagementType = null, [WorkflowExpression] Func<string> bodyinProcessOnly = null, [WorkflowExpression] Func<string[]> bodyindexes = null, [WorkflowExpression] Func<string[]> bodyinformationFields = null, [WorkflowExpression] Func<string> bodyoriginalDueDate = null, [WorkflowExpression] Func<string> bodypIC = null, [WorkflowExpression] Func<string> bodypageNumber = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyreceivedFrom = null, [WorkflowExpression] Func<string> bodyreceivedOn = null, [WorkflowExpression] Func<string> bodyresponsible = null, [WorkflowExpression] Func<string> bodyroutingDetails = null, [WorkflowExpression] Func<string> bodysentOn = null, [WorkflowExpression] Func<string> bodysentTo = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytotalDaysAtStep = null, [WorkflowExpression] Func<string> bodytotalDaysInProcess = null, [WorkflowExpression] Func<string> bodyworkflow = null, [WorkflowExpression] Func<string> bodyworkflowDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFirmFlowDeliverableReportResponse> __BuildGetFirmFlowDeliverableReport(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyaccountable = null, WorkflowValue<string> bodyassignedOn = null, WorkflowValue<string> bodyassignedTo = null, WorkflowValue<string> bodyassignmentHistory = null, WorkflowValue<string> bodycompletedBy = null, WorkflowValue<string> bodycompletedOn = null, WorkflowValue<string> bodycurrentDueDate = null, WorkflowValue<string> bodycurrentStep = null, WorkflowValue<string> bodydateExtended = null, WorkflowValue<string> bodydaysAtStep = null, WorkflowValue<string> bodydaysBetweenRoutings = null, WorkflowValue<string> bodydrawerId = null, WorkflowValue<string> bodyengagementType = null, WorkflowValue<string> bodyinProcessOnly = null, WorkflowValue<string[]> bodyindexes = null, WorkflowValue<string[]> bodyinformationFields = null, WorkflowValue<string> bodyoriginalDueDate = null, WorkflowValue<string> bodypIC = null, WorkflowValue<string> bodypageNumber = null, WorkflowValue<string> bodypriority = null, WorkflowValue<string> bodyreceivedFrom = null, WorkflowValue<string> bodyreceivedOn = null, WorkflowValue<string> bodyresponsible = null, WorkflowValue<string> bodyroutingDetails = null, WorkflowValue<string> bodysentOn = null, WorkflowValue<string> bodysentTo = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodytotalDaysAtStep = null, WorkflowValue<string> bodytotalDaysInProcess = null, WorkflowValue<string> bodyworkflow = null, WorkflowValue<string> bodyworkflowDescription = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyaccountable, nameof(bodyaccountable), required: false);
            WorkflowValue.Validate(bodyassignedOn, nameof(bodyassignedOn), required: false);
            WorkflowValue.Validate(bodyassignedTo, nameof(bodyassignedTo), required: false);
            WorkflowValue.Validate(bodyassignmentHistory, nameof(bodyassignmentHistory), required: false);
            WorkflowValue.Validate(bodycompletedBy, nameof(bodycompletedBy), required: false);
            WorkflowValue.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            WorkflowValue.Validate(bodycurrentDueDate, nameof(bodycurrentDueDate), required: false);
            WorkflowValue.Validate(bodycurrentStep, nameof(bodycurrentStep), required: false);
            WorkflowValue.Validate(bodydateExtended, nameof(bodydateExtended), required: false);
            WorkflowValue.Validate(bodydaysAtStep, nameof(bodydaysAtStep), required: false);
            WorkflowValue.Validate(bodydaysBetweenRoutings, nameof(bodydaysBetweenRoutings), required: false);
            WorkflowValue.Validate(bodydrawerId, nameof(bodydrawerId), required: false);
            WorkflowValue.Validate(bodyengagementType, nameof(bodyengagementType), required: false);
            WorkflowValue.Validate(bodyinProcessOnly, nameof(bodyinProcessOnly), required: false);
            WorkflowValue.Validate(bodyindexes, nameof(bodyindexes), required: false);
            WorkflowValue.Validate(bodyinformationFields, nameof(bodyinformationFields), required: false);
            WorkflowValue.Validate(bodyoriginalDueDate, nameof(bodyoriginalDueDate), required: false);
            WorkflowValue.Validate(bodypIC, nameof(bodypIC), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodyreceivedFrom, nameof(bodyreceivedFrom), required: false);
            WorkflowValue.Validate(bodyreceivedOn, nameof(bodyreceivedOn), required: false);
            WorkflowValue.Validate(bodyresponsible, nameof(bodyresponsible), required: false);
            WorkflowValue.Validate(bodyroutingDetails, nameof(bodyroutingDetails), required: false);
            WorkflowValue.Validate(bodysentOn, nameof(bodysentOn), required: false);
            WorkflowValue.Validate(bodysentTo, nameof(bodysentTo), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodytotalDaysAtStep, nameof(bodytotalDaysAtStep), required: false);
            WorkflowValue.Validate(bodytotalDaysInProcess, nameof(bodytotalDaysInProcess), required: false);
            WorkflowValue.Validate(bodyworkflow, nameof(bodyworkflow), required: false);
            WorkflowValue.Validate(bodyworkflowDescription, nameof(bodyworkflowDescription), required: false);
            return new DeferredBodyAction<GetFirmFlowDeliverableReportResponse>(() =>
            {
                var apiCallPath = "/api/v1/firmflowreports/TrackingReportByDeliverable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountable != null)
                {
                    body["Accountable"] = ExpressionConverter.ConvertO(bodyaccountable);
                    bodypropCount++;
                }

                if (bodyassignedOn != null)
                {
                    body["AssignedOn"] = ExpressionConverter.ConvertO(bodyassignedOn);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodyassignmentHistory != null)
                {
                    body["AssignmentHistory"] = ExpressionConverter.ConvertO(bodyassignmentHistory);
                    bodypropCount++;
                }

                if (bodycompletedBy != null)
                {
                    body["CompletedBy"] = ExpressionConverter.ConvertO(bodycompletedBy);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["CompletedOn"] = ExpressionConverter.ConvertO(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodycurrentDueDate != null)
                {
                    body["CurrentDueDate"] = ExpressionConverter.ConvertO(bodycurrentDueDate);
                    bodypropCount++;
                }

                if (bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(bodycurrentStep);
                    bodypropCount++;
                }

                if (bodydateExtended != null)
                {
                    body["DateExtended"] = ExpressionConverter.ConvertO(bodydateExtended);
                    bodypropCount++;
                }

                if (bodydaysAtStep != null)
                {
                    body["DaysAtStep"] = ExpressionConverter.ConvertO(bodydaysAtStep);
                    bodypropCount++;
                }

                if (bodydaysBetweenRoutings != null)
                {
                    body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(bodydaysBetweenRoutings);
                    bodypropCount++;
                }

                if (bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(bodydrawerId);
                    bodypropCount++;
                }

                if (bodyengagementType != null)
                {
                    body["EngagementType"] = ExpressionConverter.ConvertO(bodyengagementType);
                    bodypropCount++;
                }

                if (bodyinProcessOnly != null)
                {
                    body["InProcessOnly"] = ExpressionConverter.ConvertO(bodyinProcessOnly);
                    bodypropCount++;
                }

                if (bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(bodyindexes);
                    bodypropCount++;
                }

                if (bodyinformationFields != null)
                {
                    body["InformationFields"] = ExpressionConverter.ConvertO(bodyinformationFields);
                    bodypropCount++;
                }

                if (bodyoriginalDueDate != null)
                {
                    body["OriginalDueDate"] = ExpressionConverter.ConvertO(bodyoriginalDueDate);
                    bodypropCount++;
                }

                if (bodypIC != null)
                {
                    body["PIC"] = ExpressionConverter.ConvertO(bodypIC);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyreceivedFrom != null)
                {
                    body["ReceivedFrom"] = ExpressionConverter.ConvertO(bodyreceivedFrom);
                    bodypropCount++;
                }

                if (bodyreceivedOn != null)
                {
                    body["ReceivedOn"] = ExpressionConverter.ConvertO(bodyreceivedOn);
                    bodypropCount++;
                }

                if (bodyresponsible != null)
                {
                    body["Responsible"] = ExpressionConverter.ConvertO(bodyresponsible);
                    bodypropCount++;
                }

                if (bodyroutingDetails != null)
                {
                    body["RoutingDetails"] = ExpressionConverter.ConvertO(bodyroutingDetails);
                    bodypropCount++;
                }

                if (bodysentOn != null)
                {
                    body["SentOn"] = ExpressionConverter.ConvertO(bodysentOn);
                    bodypropCount++;
                }

                if (bodysentTo != null)
                {
                    body["SentTo"] = ExpressionConverter.ConvertO(bodysentTo);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodytotalDaysAtStep != null)
                {
                    body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(bodytotalDaysAtStep);
                    bodypropCount++;
                }

                if (bodytotalDaysInProcess != null)
                {
                    body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(bodytotalDaysInProcess);
                    bodypropCount++;
                }

                if (bodyworkflow != null)
                {
                    body["Workflow"] = ExpressionConverter.ConvertO(bodyworkflow);
                    bodypropCount++;
                }

                if (bodyworkflowDescription != null)
                {
                    body["WorkflowDescription"] = ExpressionConverter.ConvertO(bodyworkflowDescription);
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
        [WorkflowExpressionFactory(nameof(__BuildValidateIndexes))]
        public IBodyWorkflowAction<ValidateIndexesResponse> ValidateIndexes([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydrawerId = null, [WorkflowExpression] Func<bodyindexesInputItem[]> bodyindexes = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateIndexesResponse> __BuildValidateIndexes(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydrawerId = null, WorkflowValue<bodyindexesInputItem[]> bodyindexes = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydrawerId, nameof(bodydrawerId), required: false);
            WorkflowValue.Validate(bodyindexes, nameof(bodyindexes), required: false);
            return new DeferredBodyAction<ValidateIndexesResponse>(() =>
            {
                var apiCallPath = "/api/v1/indexes/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(bodydrawerId);
                    bodypropCount++;
                }

                if (bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(bodyindexes);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicRulesForIndex))]
        public IBodyWorkflowAction<GetDynamicRulesForIndexResponseItem[]> GetDynamicRulesForIndex([WorkflowExpression] Func<string> indexId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDynamicRulesForIndexResponseItem[]> __BuildGetDynamicRulesForIndex(WorkflowValue<string> indexId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(indexId, nameof(indexId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDynamicRulesForIndexResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/indexes/{0}/dynamicrules", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetDynamicRulesForIndexResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildIndexLookupListFind))]
        public IBodyWorkflowAction<IndexLookupListFindResponseItem[]> IndexLookupListFind([WorkflowExpression] Func<string> indexId, [WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<bodyactionTypeInput> bodyactionType = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyindexValue = null, [WorkflowExpression] Func<bodysearchTypeInput> bodysearchType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IndexLookupListFindResponseItem[]> __BuildIndexLookupListFind(WorkflowValue<string> indexId, WorkflowValue<string> xAuthorization = null, WorkflowValue<bodyactionTypeInput> bodyactionType = null, WorkflowValue<int> bodycount = null, WorkflowValue<string> bodyindexValue = null, WorkflowValue<bodysearchTypeInput> bodysearchType = null)
        {
            WorkflowValue.Validate(indexId, nameof(indexId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyactionType, nameof(bodyactionType), required: false);
            WorkflowValue.Validate(bodycount, nameof(bodycount), required: false);
            WorkflowValue.Validate(bodyindexValue, nameof(bodyindexValue), required: false);
            WorkflowValue.Validate(bodysearchType, nameof(bodysearchType), required: false);
            return new DeferredBodyAction<IndexLookupListFindResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/indexes/{0}/lookuplist", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyactionType != null)
                {
                    body["ActionType"] = ExpressionConverter.ConvertO(bodyactionType);
                    bodypropCount++;
                }

                if (bodycount != null)
                {
                    body["Count"] = ExpressionConverter.ConvertO(bodycount);
                    bodypropCount++;
                }

                if (bodyindexValue != null)
                {
                    body["IndexValue"] = ExpressionConverter.ConvertO(bodyindexValue);
                    bodypropCount++;
                }

                if (bodysearchType != null)
                {
                    body["SearchType"] = ExpressionConverter.ConvertO(bodysearchType);
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
        [WorkflowExpressionFactory(nameof(__BuildGetListTypeIndexData))]
        public IBodyWorkflowAction<GetListTypeIndexDataResponseItem[]> GetListTypeIndexData([WorkflowExpression] Func<string> indexId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListTypeIndexDataResponseItem[]> __BuildGetListTypeIndexData(WorkflowValue<string> indexId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(indexId, nameof(indexId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetListTypeIndexDataResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/indexes/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetListTypeIndexDataResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildGetChildIndexes))]
        public IBodyWorkflowAction<GetChildIndexesResponseItem[]> GetChildIndexes([WorkflowExpression] Func<string> indexId, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChildIndexesResponseItem[]> __BuildGetChildIndexes(WorkflowValue<string> indexId, WorkflowValue<string> listId, WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(indexId, nameof(indexId), required: true);
            WorkflowValue.Validate(listId, nameof(listId), required: true);
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetChildIndexesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/indexes/{0}/values/childindexlist/{1}", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1), ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<GetChildIndexesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildLogin))]
        public IBodyWorkflowAction<LoginResponse> Login([WorkflowExpression] Func<string> bodyloginName, [WorkflowExpression] Func<string> bodypassword)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LoginResponse> __BuildLogin(WorkflowValue<string> bodyloginName, WorkflowValue<string> bodypassword)
        {
            WorkflowValue.Validate(bodyloginName, nameof(bodyloginName), required: true);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: true);
            return new DeferredBodyAction<LoginResponse>(() =>
            {
                var apiCallPath = "/api/v1/user/login";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["LoginName"] = ExpressionConverter.ConvertO(bodyloginName);
                bodypropCount++;
                body["Password"] = ExpressionConverter.ConvertO(bodypassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildLogout))]
        public IBodyWorkflowAction<LogoutResponse> Logout([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LogoutResponse> __BuildLogout(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<LogoutResponse>(() =>
            {
                var apiCallPath = "/api/v1/user/logout";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<LogoutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildValidateToken))]
        public IBodyWorkflowAction<bool> ValidateToken([WorkflowExpression] Func<string> xAuthorization = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildValidateToken(WorkflowValue<string> xAuthorization = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/api/v1/user/validate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkflow))]
        public IBodyWorkflowAction<CreateWorkflowResponse> CreateWorkflow([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydrawer = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodyfolderId = null, [WorkflowExpression] Func<string> bodyheadersclientName = null, [WorkflowExpression] Func<string> bodyheadersclientNumber = null, [WorkflowExpression] Func<string> bodyheadersengagementType = null, [WorkflowExpression] Func<string> bodyheaderspIC = null, [WorkflowExpression] Func<string> bodyheadersyear = null, [WorkflowExpression] Func<string> bodyheadersperiodEnd = null, [WorkflowExpression] Func<string> bodyfilingworkflowName = null, [WorkflowExpression] Func<string> bodyfilingdescription = null, [WorkflowExpression] Func<string> bodyfilingstatusName = null, [WorkflowExpression] Func<string> bodydeliverableaction = null, [WorkflowExpression] Func<string> bodydeliverablecurrentduedate = null, [WorkflowExpression] Func<string> bodydeliverableoriginalduedate = null, [WorkflowExpression] Func<string> bodydeliverableform = null, [WorkflowExpression] Func<string> bodydeliveryInstructionsdelivery = null, [WorkflowExpression] Func<string> bodydeliveryInstructionsdestination = null, [WorkflowExpression] Func<string> bodydeliveryInstructionssourceDocument = null, [WorkflowExpression] Func<string> bodynotesaction = null, [WorkflowExpression] Func<string> bodynotesnoteType = null, [WorkflowExpression] Func<string> bodynotesnote = null, [WorkflowExpression] Func<string> bodyinformationFieldsname = null, [WorkflowExpression] Func<string> bodyinformationFieldsvalue = null, [WorkflowExpression] Func<string> bodyroutingSummaryresponsibleField = null, [WorkflowExpression] Func<string> bodyroutingSummaryvalue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkflowResponse> __BuildCreateWorkflow(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydrawer = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodyfolderId = null, WorkflowValue<string> bodyheadersclientName = null, WorkflowValue<string> bodyheadersclientNumber = null, WorkflowValue<string> bodyheadersengagementType = null, WorkflowValue<string> bodyheaderspIC = null, WorkflowValue<string> bodyheadersyear = null, WorkflowValue<string> bodyheadersperiodEnd = null, WorkflowValue<string> bodyfilingworkflowName = null, WorkflowValue<string> bodyfilingdescription = null, WorkflowValue<string> bodyfilingstatusName = null, WorkflowValue<string> bodydeliverableaction = null, WorkflowValue<string> bodydeliverablecurrentduedate = null, WorkflowValue<string> bodydeliverableoriginalduedate = null, WorkflowValue<string> bodydeliverableform = null, WorkflowValue<string> bodydeliveryInstructionsdelivery = null, WorkflowValue<string> bodydeliveryInstructionsdestination = null, WorkflowValue<string> bodydeliveryInstructionssourceDocument = null, WorkflowValue<string> bodynotesaction = null, WorkflowValue<string> bodynotesnoteType = null, WorkflowValue<string> bodynotesnote = null, WorkflowValue<string> bodyinformationFieldsname = null, WorkflowValue<string> bodyinformationFieldsvalue = null, WorkflowValue<string> bodyroutingSummaryresponsibleField = null, WorkflowValue<string> bodyroutingSummaryvalue = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydrawer, nameof(bodydrawer), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodyfolderId, nameof(bodyfolderId), required: false);
            WorkflowValue.Validate(bodyheadersclientName, nameof(bodyheadersclientName), required: false);
            WorkflowValue.Validate(bodyheadersclientNumber, nameof(bodyheadersclientNumber), required: false);
            WorkflowValue.Validate(bodyheadersengagementType, nameof(bodyheadersengagementType), required: false);
            WorkflowValue.Validate(bodyheaderspIC, nameof(bodyheaderspIC), required: false);
            WorkflowValue.Validate(bodyheadersyear, nameof(bodyheadersyear), required: false);
            WorkflowValue.Validate(bodyheadersperiodEnd, nameof(bodyheadersperiodEnd), required: false);
            WorkflowValue.Validate(bodyfilingworkflowName, nameof(bodyfilingworkflowName), required: false);
            WorkflowValue.Validate(bodyfilingdescription, nameof(bodyfilingdescription), required: false);
            WorkflowValue.Validate(bodyfilingstatusName, nameof(bodyfilingstatusName), required: false);
            WorkflowValue.Validate(bodydeliverableaction, nameof(bodydeliverableaction), required: false);
            WorkflowValue.Validate(bodydeliverablecurrentduedate, nameof(bodydeliverablecurrentduedate), required: false);
            WorkflowValue.Validate(bodydeliverableoriginalduedate, nameof(bodydeliverableoriginalduedate), required: false);
            WorkflowValue.Validate(bodydeliverableform, nameof(bodydeliverableform), required: false);
            WorkflowValue.Validate(bodydeliveryInstructionsdelivery, nameof(bodydeliveryInstructionsdelivery), required: false);
            WorkflowValue.Validate(bodydeliveryInstructionsdestination, nameof(bodydeliveryInstructionsdestination), required: false);
            WorkflowValue.Validate(bodydeliveryInstructionssourceDocument, nameof(bodydeliveryInstructionssourceDocument), required: false);
            WorkflowValue.Validate(bodynotesaction, nameof(bodynotesaction), required: false);
            WorkflowValue.Validate(bodynotesnoteType, nameof(bodynotesnoteType), required: false);
            WorkflowValue.Validate(bodynotesnote, nameof(bodynotesnote), required: false);
            WorkflowValue.Validate(bodyinformationFieldsname, nameof(bodyinformationFieldsname), required: false);
            WorkflowValue.Validate(bodyinformationFieldsvalue, nameof(bodyinformationFieldsvalue), required: false);
            WorkflowValue.Validate(bodyroutingSummaryresponsibleField, nameof(bodyroutingSummaryresponsibleField), required: false);
            WorkflowValue.Validate(bodyroutingSummaryvalue, nameof(bodyroutingSummaryvalue), required: false);
            return new DeferredBodyAction<CreateWorkflowResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/CreateWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydrawer != null)
                {
                    body["Drawer"] = ExpressionConverter.ConvertO(bodydrawer);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodyfolderId != null)
                {
                    body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (bodyheadersclientName != null)
                {
                    headersObject["ClientName"] = ExpressionConverter.ConvertO(bodyheadersclientName);
                    headersObjectpropCount++;
                }

                if (bodyheadersclientNumber != null)
                {
                    headersObject["ClientNumber"] = ExpressionConverter.ConvertO(bodyheadersclientNumber);
                    headersObjectpropCount++;
                }

                if (bodyheadersengagementType != null)
                {
                    headersObject["EngagementType"] = ExpressionConverter.ConvertO(bodyheadersengagementType);
                    headersObjectpropCount++;
                }

                if (bodyheaderspIC != null)
                {
                    headersObject["PIC"] = ExpressionConverter.ConvertO(bodyheaderspIC);
                    headersObjectpropCount++;
                }

                if (bodyheadersyear != null)
                {
                    headersObject["Year"] = ExpressionConverter.ConvertO(bodyheadersyear);
                    headersObjectpropCount++;
                }

                if (bodyheadersperiodEnd != null)
                {
                    headersObject["PeriodEnd"] = ExpressionConverter.ConvertO(bodyheadersperiodEnd);
                    headersObjectpropCount++;
                }

                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                var filingObject = new JObject();
                var filingObjectpropCount = 0;
                if (bodyfilingworkflowName != null)
                {
                    filingObject["workflowName"] = ExpressionConverter.ConvertO(bodyfilingworkflowName);
                    filingObjectpropCount++;
                }

                if (bodyfilingdescription != null)
                {
                    filingObject["description"] = ExpressionConverter.ConvertO(bodyfilingdescription);
                    filingObjectpropCount++;
                }

                if (bodyfilingstatusName != null)
                {
                    filingObject["statusName"] = ExpressionConverter.ConvertO(bodyfilingstatusName);
                    filingObjectpropCount++;
                }

                if (filingObjectpropCount > 0)
                {
                    body["filing"] = filingObject;
                    bodypropCount++;
                }

                var deliverableObject = new JObject();
                var deliverableObjectpropCount = 0;
                if (bodydeliverableaction != null)
                {
                    deliverableObject["action"] = ExpressionConverter.ConvertO(bodydeliverableaction);
                    deliverableObjectpropCount++;
                }

                if (bodydeliverablecurrentduedate != null)
                {
                    deliverableObject["currentduedate"] = ExpressionConverter.ConvertO(bodydeliverablecurrentduedate);
                    deliverableObjectpropCount++;
                }

                if (bodydeliverableoriginalduedate != null)
                {
                    deliverableObject["originalduedate"] = ExpressionConverter.ConvertO(bodydeliverableoriginalduedate);
                    deliverableObjectpropCount++;
                }

                if (bodydeliverableform != null)
                {
                    deliverableObject["form"] = ExpressionConverter.ConvertO(bodydeliverableform);
                    deliverableObjectpropCount++;
                }

                if (deliverableObjectpropCount > 0)
                {
                    body["deliverable"] = deliverableObject;
                    bodypropCount++;
                }

                var deliveryInstructionsObject = new JObject();
                var deliveryInstructionsObjectpropCount = 0;
                if (bodydeliveryInstructionsdelivery != null)
                {
                    deliveryInstructionsObject["Delivery"] = ExpressionConverter.ConvertO(bodydeliveryInstructionsdelivery);
                    deliveryInstructionsObjectpropCount++;
                }

                if (bodydeliveryInstructionsdestination != null)
                {
                    deliveryInstructionsObject["Destination"] = ExpressionConverter.ConvertO(bodydeliveryInstructionsdestination);
                    deliveryInstructionsObjectpropCount++;
                }

                if (bodydeliveryInstructionssourceDocument != null)
                {
                    deliveryInstructionsObject["sourceDocument"] = ExpressionConverter.ConvertO(bodydeliveryInstructionssourceDocument);
                    deliveryInstructionsObjectpropCount++;
                }

                if (deliveryInstructionsObjectpropCount > 0)
                {
                    body["DeliveryInstructions"] = deliveryInstructionsObject;
                    bodypropCount++;
                }

                var notesObject = new JObject();
                var notesObjectpropCount = 0;
                if (bodynotesaction != null)
                {
                    notesObject["action"] = ExpressionConverter.ConvertO(bodynotesaction);
                    notesObjectpropCount++;
                }

                if (bodynotesnoteType != null)
                {
                    notesObject["noteType"] = ExpressionConverter.ConvertO(bodynotesnoteType);
                    notesObjectpropCount++;
                }

                if (bodynotesnote != null)
                {
                    notesObject["note"] = ExpressionConverter.ConvertO(bodynotesnote);
                    notesObjectpropCount++;
                }

                if (notesObjectpropCount > 0)
                {
                    body["notes"] = notesObject;
                    bodypropCount++;
                }

                var informationFieldsObject = new JObject();
                var informationFieldsObjectpropCount = 0;
                if (bodyinformationFieldsname != null)
                {
                    informationFieldsObject["name"] = ExpressionConverter.ConvertO(bodyinformationFieldsname);
                    informationFieldsObjectpropCount++;
                }

                if (bodyinformationFieldsvalue != null)
                {
                    informationFieldsObject["value"] = ExpressionConverter.ConvertO(bodyinformationFieldsvalue);
                    informationFieldsObjectpropCount++;
                }

                if (informationFieldsObjectpropCount > 0)
                {
                    body["informationFields"] = informationFieldsObject;
                    bodypropCount++;
                }

                var routingSummaryObject = new JObject();
                var routingSummaryObjectpropCount = 0;
                if (bodyroutingSummaryresponsibleField != null)
                {
                    routingSummaryObject["ResponsibleField"] = ExpressionConverter.ConvertO(bodyroutingSummaryresponsibleField);
                    routingSummaryObjectpropCount++;
                }

                if (bodyroutingSummaryvalue != null)
                {
                    routingSummaryObject["value"] = ExpressionConverter.ConvertO(bodyroutingSummaryvalue);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteMasterDeliverable))]
        public IBodyWorkflowAction<DeleteMasterDeliverableResponseItem[]> DeleteMasterDeliverable([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodydrawerName = null, [WorkflowExpression] Func<string[]> bodydeliverableNames = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteMasterDeliverableResponseItem[]> __BuildDeleteMasterDeliverable(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodydrawerName = null, WorkflowValue<string[]> bodydeliverableNames = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodydrawerName, nameof(bodydrawerName), required: false);
            WorkflowValue.Validate(bodydeliverableNames, nameof(bodydeliverableNames), required: false);
            return new DeferredBodyAction<DeleteMasterDeliverableResponseItem[]>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/DeleteDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(bodydrawerName);
                    bodypropCount++;
                }

                if (bodydeliverableNames != null)
                {
                    body["DeliverableNames"] = ExpressionConverter.ConvertO(bodydeliverableNames);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkflows))]
        public IBodyWorkflowAction<DeleteWorkflowsResponse> DeleteWorkflows([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<int[]> bodyfilingId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteWorkflowsResponse> __BuildDeleteWorkflows(WorkflowValue<string> xAuthorization = null, WorkflowValue<int[]> bodyfilingId = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyfilingId, nameof(bodyfilingId), required: false);
            return new DeferredBodyAction<DeleteWorkflowsResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/DeleteWorkflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilingId != null)
                {
                    body["filingId"] = ExpressionConverter.ConvertO(bodyfilingId);
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
        [WorkflowExpressionFactory(nameof(__BuildEditMasterDeliverable))]
        public IBodyWorkflowAction<EditMasterDeliverableResponse> EditMasterDeliverable([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodycurrentdeliverableName = null, [WorkflowExpression] Func<string> bodyupdatedeliverableName = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyfirstExtension = null, [WorkflowExpression] Func<string> bodysecondExtension = null, [WorkflowExpression] Func<string> bodythirdExtension = null, [WorkflowExpression] Func<string> bodycalenderOrFiscal = null, [WorkflowExpression] Func<int> bodyextension = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodydrawerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EditMasterDeliverableResponse> __BuildEditMasterDeliverable(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodycurrentdeliverableName = null, WorkflowValue<string> bodyupdatedeliverableName = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<string> bodyfirstExtension = null, WorkflowValue<string> bodysecondExtension = null, WorkflowValue<string> bodythirdExtension = null, WorkflowValue<string> bodycalenderOrFiscal = null, WorkflowValue<int> bodyextension = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodydrawerName = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodycurrentdeliverableName, nameof(bodycurrentdeliverableName), required: false);
            WorkflowValue.Validate(bodyupdatedeliverableName, nameof(bodyupdatedeliverableName), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodyfirstExtension, nameof(bodyfirstExtension), required: false);
            WorkflowValue.Validate(bodysecondExtension, nameof(bodysecondExtension), required: false);
            WorkflowValue.Validate(bodythirdExtension, nameof(bodythirdExtension), required: false);
            WorkflowValue.Validate(bodycalenderOrFiscal, nameof(bodycalenderOrFiscal), required: false);
            WorkflowValue.Validate(bodyextension, nameof(bodyextension), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodydrawerName, nameof(bodydrawerName), required: false);
            return new DeferredBodyAction<EditMasterDeliverableResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/UpdateDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycurrentdeliverableName != null)
                {
                    body["currentdeliverableName"] = ExpressionConverter.ConvertO(bodycurrentdeliverableName);
                    bodypropCount++;
                }

                if (bodyupdatedeliverableName != null)
                {
                    body["updatedeliverableName"] = ExpressionConverter.ConvertO(bodyupdatedeliverableName);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodyfirstExtension != null)
                {
                    body["firstExtension"] = ExpressionConverter.ConvertO(bodyfirstExtension);
                    bodypropCount++;
                }

                if (bodysecondExtension != null)
                {
                    body["secondExtension"] = ExpressionConverter.ConvertO(bodysecondExtension);
                    bodypropCount++;
                }

                if (bodythirdExtension != null)
                {
                    body["thirdExtension"] = ExpressionConverter.ConvertO(bodythirdExtension);
                    bodypropCount++;
                }

                if (bodycalenderOrFiscal != null)
                {
                    body["calenderOrFiscal"] = ExpressionConverter.ConvertO(bodycalenderOrFiscal);
                    bodypropCount++;
                }

                if (bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["serviceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodydrawerName != null)
                {
                    body["drawerName"] = ExpressionConverter.ConvertO(bodydrawerName);
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
        [WorkflowExpressionFactory(nameof(__BuildEditWorkflow))]
        public IBodyWorkflowAction<EditWorkflowResponse> EditWorkflow([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<int> bodyfilingId = null, [WorkflowExpression] Func<string> bodyheadersclientName = null, [WorkflowExpression] Func<string> bodyheadersclientNumber = null, [WorkflowExpression] Func<string> bodyheadersengagementType = null, [WorkflowExpression] Func<string> bodyheaderspIC = null, [WorkflowExpression] Func<string> bodyheadersyear = null, [WorkflowExpression] Func<string> bodyheadersperiodEnd = null, [WorkflowExpression] Func<string> bodydeliverableaction = null, [WorkflowExpression] Func<string> bodydeliverablecurrentduedate = null, [WorkflowExpression] Func<string> bodydeliverableoriginalduedate = null, [WorkflowExpression] Func<string> bodydeliverableform = null, [WorkflowExpression] Func<string> bodynotesaction = null, [WorkflowExpression] Func<string> bodynotesnoteType = null, [WorkflowExpression] Func<string[]> bodynotesnoteid = null, [WorkflowExpression] Func<string> bodynotesnote = null, [WorkflowExpression] Func<string> bodyinformationFieldsname = null, [WorkflowExpression] Func<string> bodyinformationFieldsvalue = null, [WorkflowExpression] Func<string> bodydeliveryInstructionsdelivery = null, [WorkflowExpression] Func<string> bodydeliveryInstructionsdestination = null, [WorkflowExpression] Func<string> bodydeliveryInstructionssourceDocument = null, [WorkflowExpression] Func<string> bodyroutingSummaryresponsibleField = null, [WorkflowExpression] Func<string> bodyroutingSummaryvalue = null, [WorkflowExpression] Func<bool> bodyreindexDocs = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EditWorkflowResponse> __BuildEditWorkflow(WorkflowValue<string> xAuthorization = null, WorkflowValue<int> bodyfilingId = null, WorkflowValue<string> bodyheadersclientName = null, WorkflowValue<string> bodyheadersclientNumber = null, WorkflowValue<string> bodyheadersengagementType = null, WorkflowValue<string> bodyheaderspIC = null, WorkflowValue<string> bodyheadersyear = null, WorkflowValue<string> bodyheadersperiodEnd = null, WorkflowValue<string> bodydeliverableaction = null, WorkflowValue<string> bodydeliverablecurrentduedate = null, WorkflowValue<string> bodydeliverableoriginalduedate = null, WorkflowValue<string> bodydeliverableform = null, WorkflowValue<string> bodynotesaction = null, WorkflowValue<string> bodynotesnoteType = null, WorkflowValue<string[]> bodynotesnoteid = null, WorkflowValue<string> bodynotesnote = null, WorkflowValue<string> bodyinformationFieldsname = null, WorkflowValue<string> bodyinformationFieldsvalue = null, WorkflowValue<string> bodydeliveryInstructionsdelivery = null, WorkflowValue<string> bodydeliveryInstructionsdestination = null, WorkflowValue<string> bodydeliveryInstructionssourceDocument = null, WorkflowValue<string> bodyroutingSummaryresponsibleField = null, WorkflowValue<string> bodyroutingSummaryvalue = null, WorkflowValue<bool> bodyreindexDocs = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyfilingId, nameof(bodyfilingId), required: false);
            WorkflowValue.Validate(bodyheadersclientName, nameof(bodyheadersclientName), required: false);
            WorkflowValue.Validate(bodyheadersclientNumber, nameof(bodyheadersclientNumber), required: false);
            WorkflowValue.Validate(bodyheadersengagementType, nameof(bodyheadersengagementType), required: false);
            WorkflowValue.Validate(bodyheaderspIC, nameof(bodyheaderspIC), required: false);
            WorkflowValue.Validate(bodyheadersyear, nameof(bodyheadersyear), required: false);
            WorkflowValue.Validate(bodyheadersperiodEnd, nameof(bodyheadersperiodEnd), required: false);
            WorkflowValue.Validate(bodydeliverableaction, nameof(bodydeliverableaction), required: false);
            WorkflowValue.Validate(bodydeliverablecurrentduedate, nameof(bodydeliverablecurrentduedate), required: false);
            WorkflowValue.Validate(bodydeliverableoriginalduedate, nameof(bodydeliverableoriginalduedate), required: false);
            WorkflowValue.Validate(bodydeliverableform, nameof(bodydeliverableform), required: false);
            WorkflowValue.Validate(bodynotesaction, nameof(bodynotesaction), required: false);
            WorkflowValue.Validate(bodynotesnoteType, nameof(bodynotesnoteType), required: false);
            WorkflowValue.Validate(bodynotesnoteid, nameof(bodynotesnoteid), required: false);
            WorkflowValue.Validate(bodynotesnote, nameof(bodynotesnote), required: false);
            WorkflowValue.Validate(bodyinformationFieldsname, nameof(bodyinformationFieldsname), required: false);
            WorkflowValue.Validate(bodyinformationFieldsvalue, nameof(bodyinformationFieldsvalue), required: false);
            WorkflowValue.Validate(bodydeliveryInstructionsdelivery, nameof(bodydeliveryInstructionsdelivery), required: false);
            WorkflowValue.Validate(bodydeliveryInstructionsdestination, nameof(bodydeliveryInstructionsdestination), required: false);
            WorkflowValue.Validate(bodydeliveryInstructionssourceDocument, nameof(bodydeliveryInstructionssourceDocument), required: false);
            WorkflowValue.Validate(bodyroutingSummaryresponsibleField, nameof(bodyroutingSummaryresponsibleField), required: false);
            WorkflowValue.Validate(bodyroutingSummaryvalue, nameof(bodyroutingSummaryvalue), required: false);
            WorkflowValue.Validate(bodyreindexDocs, nameof(bodyreindexDocs), required: false);
            return new DeferredBodyAction<EditWorkflowResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/EditWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilingId != null)
                {
                    body["filingId"] = ExpressionConverter.ConvertO(bodyfilingId);
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (bodyheadersclientName != null)
                {
                    headersObject["ClientName"] = ExpressionConverter.ConvertO(bodyheadersclientName);
                    headersObjectpropCount++;
                }

                if (bodyheadersclientNumber != null)
                {
                    headersObject["ClientNumber"] = ExpressionConverter.ConvertO(bodyheadersclientNumber);
                    headersObjectpropCount++;
                }

                if (bodyheadersengagementType != null)
                {
                    headersObject["EngagementType"] = ExpressionConverter.ConvertO(bodyheadersengagementType);
                    headersObjectpropCount++;
                }

                if (bodyheaderspIC != null)
                {
                    headersObject["PIC"] = ExpressionConverter.ConvertO(bodyheaderspIC);
                    headersObjectpropCount++;
                }

                if (bodyheadersyear != null)
                {
                    headersObject["Year"] = ExpressionConverter.ConvertO(bodyheadersyear);
                    headersObjectpropCount++;
                }

                if (bodyheadersperiodEnd != null)
                {
                    headersObject["PeriodEnd"] = ExpressionConverter.ConvertO(bodyheadersperiodEnd);
                    headersObjectpropCount++;
                }

                if (headersObjectpropCount > 0)
                {
                    body["Headers"] = headersObject;
                    bodypropCount++;
                }

                var deliverableObject = new JObject();
                var deliverableObjectpropCount = 0;
                if (bodydeliverableaction != null)
                {
                    deliverableObject["action"] = ExpressionConverter.ConvertO(bodydeliverableaction);
                    deliverableObjectpropCount++;
                }

                if (bodydeliverablecurrentduedate != null)
                {
                    deliverableObject["currentduedate"] = ExpressionConverter.ConvertO(bodydeliverablecurrentduedate);
                    deliverableObjectpropCount++;
                }

                if (bodydeliverableoriginalduedate != null)
                {
                    deliverableObject["originalduedate"] = ExpressionConverter.ConvertO(bodydeliverableoriginalduedate);
                    deliverableObjectpropCount++;
                }

                if (bodydeliverableform != null)
                {
                    deliverableObject["form"] = ExpressionConverter.ConvertO(bodydeliverableform);
                    deliverableObjectpropCount++;
                }

                if (deliverableObjectpropCount > 0)
                {
                    body["deliverable"] = deliverableObject;
                    bodypropCount++;
                }

                var notesObject = new JObject();
                var notesObjectpropCount = 0;
                if (bodynotesaction != null)
                {
                    notesObject["action"] = ExpressionConverter.ConvertO(bodynotesaction);
                    notesObjectpropCount++;
                }

                if (bodynotesnoteType != null)
                {
                    notesObject["noteType"] = ExpressionConverter.ConvertO(bodynotesnoteType);
                    notesObjectpropCount++;
                }

                if (bodynotesnoteid != null)
                {
                    notesObject["noteid"] = ExpressionConverter.ConvertO(bodynotesnoteid);
                    notesObjectpropCount++;
                }

                if (bodynotesnote != null)
                {
                    notesObject["note"] = ExpressionConverter.ConvertO(bodynotesnote);
                    notesObjectpropCount++;
                }

                if (notesObjectpropCount > 0)
                {
                    body["notes"] = notesObject;
                    bodypropCount++;
                }

                var informationFieldsObject = new JObject();
                var informationFieldsObjectpropCount = 0;
                if (bodyinformationFieldsname != null)
                {
                    informationFieldsObject["name"] = ExpressionConverter.ConvertO(bodyinformationFieldsname);
                    informationFieldsObjectpropCount++;
                }

                if (bodyinformationFieldsvalue != null)
                {
                    informationFieldsObject["value"] = ExpressionConverter.ConvertO(bodyinformationFieldsvalue);
                    informationFieldsObjectpropCount++;
                }

                if (informationFieldsObjectpropCount > 0)
                {
                    body["informationFields"] = informationFieldsObject;
                    bodypropCount++;
                }

                var deliveryInstructionsObject = new JObject();
                var deliveryInstructionsObjectpropCount = 0;
                if (bodydeliveryInstructionsdelivery != null)
                {
                    deliveryInstructionsObject["Delivery"] = ExpressionConverter.ConvertO(bodydeliveryInstructionsdelivery);
                    deliveryInstructionsObjectpropCount++;
                }

                if (bodydeliveryInstructionsdestination != null)
                {
                    deliveryInstructionsObject["Destination"] = ExpressionConverter.ConvertO(bodydeliveryInstructionsdestination);
                    deliveryInstructionsObjectpropCount++;
                }

                if (bodydeliveryInstructionssourceDocument != null)
                {
                    deliveryInstructionsObject["sourceDocument"] = ExpressionConverter.ConvertO(bodydeliveryInstructionssourceDocument);
                    deliveryInstructionsObjectpropCount++;
                }

                if (deliveryInstructionsObjectpropCount > 0)
                {
                    body["deliveryInstructions"] = deliveryInstructionsObject;
                    bodypropCount++;
                }

                var routingSummaryObject = new JObject();
                var routingSummaryObjectpropCount = 0;
                if (bodyroutingSummaryresponsibleField != null)
                {
                    routingSummaryObject["responsibleField"] = ExpressionConverter.ConvertO(bodyroutingSummaryresponsibleField);
                    routingSummaryObjectpropCount++;
                }

                if (bodyroutingSummaryvalue != null)
                {
                    routingSummaryObject["value"] = ExpressionConverter.ConvertO(bodyroutingSummaryvalue);
                    routingSummaryObjectpropCount++;
                }

                if (routingSummaryObjectpropCount > 0)
                {
                    body["routingSummary"] = routingSummaryObject;
                    bodypropCount++;
                }

                if (bodyreindexDocs != null)
                {
                    body["reindexDocs"] = ExpressionConverter.ConvertO(bodyreindexDocs);
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
        [WorkflowExpressionFactory(nameof(__BuildGetMasterDeliverable))]
        public IBodyWorkflowAction<GetMasterDeliverableResponse> GetMasterDeliverable([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<int> bodypageNumber = null, [WorkflowExpression] Func<int> bodypageSize = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodydrawerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMasterDeliverableResponse> __BuildGetMasterDeliverable(WorkflowValue<string> xAuthorization = null, WorkflowValue<int> bodypageNumber = null, WorkflowValue<int> bodypageSize = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodydrawerName = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowValue.Validate(bodypageSize, nameof(bodypageSize), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodydrawerName, nameof(bodydrawerName), required: false);
            return new DeferredBodyAction<GetMasterDeliverableResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/GetDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                if (bodypageSize != null)
                {
                    body["pageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(bodydrawerName);
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
        [WorkflowExpressionFactory(nameof(__BuildTrackingReportByWorkflow))]
        public IBodyWorkflowAction<TrackingReportByWorkflowResponse> TrackingReportByWorkflow([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydrawerId = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodyengagementType = null, [WorkflowExpression] Func<string> bodyworkflow = null, [WorkflowExpression] Func<string> bodycurrentStep = null, [WorkflowExpression] Func<string> bodypIC = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodyassignedOn = null, [WorkflowExpression] Func<string> bodyworkflowDescription = null, [WorkflowExpression] Func<string> bodyinProcessOnly = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyresponsible = null, [WorkflowExpression] Func<string> bodyassignmentHistory = null, [WorkflowExpression] Func<string> bodyreceivedFrom = null, [WorkflowExpression] Func<string> bodyreceivedOn = null, [WorkflowExpression] Func<string> bodysentTo = null, [WorkflowExpression] Func<string> bodysentOn = null, [WorkflowExpression] Func<string> bodycompletedBy = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodycurrentDueDate = null, [WorkflowExpression] Func<string> bodydaysAtStep = null, [WorkflowExpression] Func<string> bodytotalDaysAtStep = null, [WorkflowExpression] Func<string> bodydaysBetweenRoutings = null, [WorkflowExpression] Func<string> bodytotalDaysInProcess = null, [WorkflowExpression] Func<string> bodyaccountable = null, [WorkflowExpression] Func<string> bodyroutingDetails = null, [WorkflowExpression] Func<string> bodylastUpdated = null, [WorkflowExpression] Func<string[]> bodyinformationFields = null, [WorkflowExpression] Func<string[]> bodyindexes = null, [WorkflowExpression] Func<string> bodypageNumber = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TrackingReportByWorkflowResponse> __BuildTrackingReportByWorkflow(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydrawerId = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodyengagementType = null, WorkflowValue<string> bodyworkflow = null, WorkflowValue<string> bodycurrentStep = null, WorkflowValue<string> bodypIC = null, WorkflowValue<string> bodyassignedTo = null, WorkflowValue<string> bodyassignedOn = null, WorkflowValue<string> bodyworkflowDescription = null, WorkflowValue<string> bodyinProcessOnly = null, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodypriority = null, WorkflowValue<string> bodyresponsible = null, WorkflowValue<string> bodyassignmentHistory = null, WorkflowValue<string> bodyreceivedFrom = null, WorkflowValue<string> bodyreceivedOn = null, WorkflowValue<string> bodysentTo = null, WorkflowValue<string> bodysentOn = null, WorkflowValue<string> bodycompletedBy = null, WorkflowValue<string> bodycompletedOn = null, WorkflowValue<string> bodycurrentDueDate = null, WorkflowValue<string> bodydaysAtStep = null, WorkflowValue<string> bodytotalDaysAtStep = null, WorkflowValue<string> bodydaysBetweenRoutings = null, WorkflowValue<string> bodytotalDaysInProcess = null, WorkflowValue<string> bodyaccountable = null, WorkflowValue<string> bodyroutingDetails = null, WorkflowValue<string> bodylastUpdated = null, WorkflowValue<string[]> bodyinformationFields = null, WorkflowValue<string[]> bodyindexes = null, WorkflowValue<string> bodypageNumber = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydrawerId, nameof(bodydrawerId), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodyengagementType, nameof(bodyengagementType), required: false);
            WorkflowValue.Validate(bodyworkflow, nameof(bodyworkflow), required: false);
            WorkflowValue.Validate(bodycurrentStep, nameof(bodycurrentStep), required: false);
            WorkflowValue.Validate(bodypIC, nameof(bodypIC), required: false);
            WorkflowValue.Validate(bodyassignedTo, nameof(bodyassignedTo), required: false);
            WorkflowValue.Validate(bodyassignedOn, nameof(bodyassignedOn), required: false);
            WorkflowValue.Validate(bodyworkflowDescription, nameof(bodyworkflowDescription), required: false);
            WorkflowValue.Validate(bodyinProcessOnly, nameof(bodyinProcessOnly), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodyresponsible, nameof(bodyresponsible), required: false);
            WorkflowValue.Validate(bodyassignmentHistory, nameof(bodyassignmentHistory), required: false);
            WorkflowValue.Validate(bodyreceivedFrom, nameof(bodyreceivedFrom), required: false);
            WorkflowValue.Validate(bodyreceivedOn, nameof(bodyreceivedOn), required: false);
            WorkflowValue.Validate(bodysentTo, nameof(bodysentTo), required: false);
            WorkflowValue.Validate(bodysentOn, nameof(bodysentOn), required: false);
            WorkflowValue.Validate(bodycompletedBy, nameof(bodycompletedBy), required: false);
            WorkflowValue.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            WorkflowValue.Validate(bodycurrentDueDate, nameof(bodycurrentDueDate), required: false);
            WorkflowValue.Validate(bodydaysAtStep, nameof(bodydaysAtStep), required: false);
            WorkflowValue.Validate(bodytotalDaysAtStep, nameof(bodytotalDaysAtStep), required: false);
            WorkflowValue.Validate(bodydaysBetweenRoutings, nameof(bodydaysBetweenRoutings), required: false);
            WorkflowValue.Validate(bodytotalDaysInProcess, nameof(bodytotalDaysInProcess), required: false);
            WorkflowValue.Validate(bodyaccountable, nameof(bodyaccountable), required: false);
            WorkflowValue.Validate(bodyroutingDetails, nameof(bodyroutingDetails), required: false);
            WorkflowValue.Validate(bodylastUpdated, nameof(bodylastUpdated), required: false);
            WorkflowValue.Validate(bodyinformationFields, nameof(bodyinformationFields), required: false);
            WorkflowValue.Validate(bodyindexes, nameof(bodyindexes), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            return new DeferredBodyAction<TrackingReportByWorkflowResponse>(() =>
            {
                var apiCallPath = "/api/v1/firmflowreports/TrackingReportByWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(bodydrawerId);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodyengagementType != null)
                {
                    body["EngagementType"] = ExpressionConverter.ConvertO(bodyengagementType);
                    bodypropCount++;
                }

                if (bodyworkflow != null)
                {
                    body["Workflow"] = ExpressionConverter.ConvertO(bodyworkflow);
                    bodypropCount++;
                }

                if (bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(bodycurrentStep);
                    bodypropCount++;
                }

                if (bodypIC != null)
                {
                    body["PIC"] = ExpressionConverter.ConvertO(bodypIC);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodyassignedOn != null)
                {
                    body["AssignedOn"] = ExpressionConverter.ConvertO(bodyassignedOn);
                    bodypropCount++;
                }

                if (bodyworkflowDescription != null)
                {
                    body["WorkflowDescription"] = ExpressionConverter.ConvertO(bodyworkflowDescription);
                    bodypropCount++;
                }

                if (bodyinProcessOnly != null)
                {
                    body["InProcessOnly"] = ExpressionConverter.ConvertO(bodyinProcessOnly);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyresponsible != null)
                {
                    body["Responsible"] = ExpressionConverter.ConvertO(bodyresponsible);
                    bodypropCount++;
                }

                if (bodyassignmentHistory != null)
                {
                    body["AssignmentHistory"] = ExpressionConverter.ConvertO(bodyassignmentHistory);
                    bodypropCount++;
                }

                if (bodyreceivedFrom != null)
                {
                    body["ReceivedFrom"] = ExpressionConverter.ConvertO(bodyreceivedFrom);
                    bodypropCount++;
                }

                if (bodyreceivedOn != null)
                {
                    body["ReceivedOn"] = ExpressionConverter.ConvertO(bodyreceivedOn);
                    bodypropCount++;
                }

                if (bodysentTo != null)
                {
                    body["SentTo"] = ExpressionConverter.ConvertO(bodysentTo);
                    bodypropCount++;
                }

                if (bodysentOn != null)
                {
                    body["SentOn"] = ExpressionConverter.ConvertO(bodysentOn);
                    bodypropCount++;
                }

                if (bodycompletedBy != null)
                {
                    body["CompletedBy"] = ExpressionConverter.ConvertO(bodycompletedBy);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["CompletedOn"] = ExpressionConverter.ConvertO(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodycurrentDueDate != null)
                {
                    body["CurrentDueDate"] = ExpressionConverter.ConvertO(bodycurrentDueDate);
                    bodypropCount++;
                }

                if (bodydaysAtStep != null)
                {
                    body["DaysAtStep"] = ExpressionConverter.ConvertO(bodydaysAtStep);
                    bodypropCount++;
                }

                if (bodytotalDaysAtStep != null)
                {
                    body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(bodytotalDaysAtStep);
                    bodypropCount++;
                }

                if (bodydaysBetweenRoutings != null)
                {
                    body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(bodydaysBetweenRoutings);
                    bodypropCount++;
                }

                if (bodytotalDaysInProcess != null)
                {
                    body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(bodytotalDaysInProcess);
                    bodypropCount++;
                }

                if (bodyaccountable != null)
                {
                    body["Accountable"] = ExpressionConverter.ConvertO(bodyaccountable);
                    bodypropCount++;
                }

                if (bodyroutingDetails != null)
                {
                    body["RoutingDetails"] = ExpressionConverter.ConvertO(bodyroutingDetails);
                    bodypropCount++;
                }

                if (bodylastUpdated != null)
                {
                    body["LastUpdated"] = ExpressionConverter.ConvertO(bodylastUpdated);
                    bodypropCount++;
                }

                if (bodyinformationFields != null)
                {
                    body["InformationFields"] = ExpressionConverter.ConvertO(bodyinformationFields);
                    bodypropCount++;
                }

                if (bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(bodyindexes);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(bodypageNumber);
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
        [WorkflowExpressionFactory(nameof(__BuildAddMasterDeliverable))]
        public IBodyWorkflowAction<AddMasterDeliverableResponse> AddMasterDeliverable([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydeliverableName = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyfirstExtension = null, [WorkflowExpression] Func<string> bodysecondExtension = null, [WorkflowExpression] Func<string> bodythirdExtension = null, [WorkflowExpression] Func<string> bodycalenderOrFiscal = null, [WorkflowExpression] Func<int> bodyextension = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodydrawerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddMasterDeliverableResponse> __BuildAddMasterDeliverable(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydeliverableName = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<string> bodyfirstExtension = null, WorkflowValue<string> bodysecondExtension = null, WorkflowValue<string> bodythirdExtension = null, WorkflowValue<string> bodycalenderOrFiscal = null, WorkflowValue<int> bodyextension = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodydrawerName = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydeliverableName, nameof(bodydeliverableName), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodyfirstExtension, nameof(bodyfirstExtension), required: false);
            WorkflowValue.Validate(bodysecondExtension, nameof(bodysecondExtension), required: false);
            WorkflowValue.Validate(bodythirdExtension, nameof(bodythirdExtension), required: false);
            WorkflowValue.Validate(bodycalenderOrFiscal, nameof(bodycalenderOrFiscal), required: false);
            WorkflowValue.Validate(bodyextension, nameof(bodyextension), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodydrawerName, nameof(bodydrawerName), required: false);
            return new DeferredBodyAction<AddMasterDeliverableResponse>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/SaveDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydeliverableName != null)
                {
                    body["deliverableName"] = ExpressionConverter.ConvertO(bodydeliverableName);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodyfirstExtension != null)
                {
                    body["firstExtension"] = ExpressionConverter.ConvertO(bodyfirstExtension);
                    bodypropCount++;
                }

                if (bodysecondExtension != null)
                {
                    body["secondExtension"] = ExpressionConverter.ConvertO(bodysecondExtension);
                    bodypropCount++;
                }

                if (bodythirdExtension != null)
                {
                    body["thirdExtension"] = ExpressionConverter.ConvertO(bodythirdExtension);
                    bodypropCount++;
                }

                if (bodycalenderOrFiscal != null)
                {
                    body["calenderOrFiscal"] = ExpressionConverter.ConvertO(bodycalenderOrFiscal);
                    bodypropCount++;
                }

                if (bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodydrawerName != null)
                {
                    body["DrawerName"] = ExpressionConverter.ConvertO(bodydrawerName);
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
        [WorkflowExpressionFactory(nameof(__BuildRouteWorkflow))]
        public IBodyWorkflowAction<RouteWorkflowV2Response> RouteWorkflow([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<int[]> bodyfilingId = null, [WorkflowExpression] Func<string[]> bodycurrentStep = null, [WorkflowExpression] Func<bool> bodycomplete = null, [WorkflowExpression] Func<string> bodycompletedDate = null, [WorkflowExpression] Func<string> bodynextStep = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodyassignedDate = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyroutingNote = null, [WorkflowExpression] Func<bool> bodyemailNotify = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RouteWorkflowV2Response> __BuildRouteWorkflow(WorkflowValue<string> xAuthorization = null, WorkflowValue<int[]> bodyfilingId = null, WorkflowValue<string[]> bodycurrentStep = null, WorkflowValue<bool> bodycomplete = null, WorkflowValue<string> bodycompletedDate = null, WorkflowValue<string> bodynextStep = null, WorkflowValue<string> bodyassignedTo = null, WorkflowValue<string> bodyassignedDate = null, WorkflowValue<string> bodypriority = null, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodyroutingNote = null, WorkflowValue<bool> bodyemailNotify = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodyfilingId, nameof(bodyfilingId), required: false);
            WorkflowValue.Validate(bodycurrentStep, nameof(bodycurrentStep), required: false);
            WorkflowValue.Validate(bodycomplete, nameof(bodycomplete), required: false);
            WorkflowValue.Validate(bodycompletedDate, nameof(bodycompletedDate), required: false);
            WorkflowValue.Validate(bodynextStep, nameof(bodynextStep), required: false);
            WorkflowValue.Validate(bodyassignedTo, nameof(bodyassignedTo), required: false);
            WorkflowValue.Validate(bodyassignedDate, nameof(bodyassignedDate), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyroutingNote, nameof(bodyroutingNote), required: false);
            WorkflowValue.Validate(bodyemailNotify, nameof(bodyemailNotify), required: false);
            return new DeferredBodyAction<RouteWorkflowV2Response>(() =>
            {
                var apiCallPath = "/firmflow/api/V2/Route";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfilingId != null)
                {
                    body["filingId"] = ExpressionConverter.ConvertO(bodyfilingId);
                    bodypropCount++;
                }

                if (bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(bodycurrentStep);
                    bodypropCount++;
                }

                if (bodycomplete != null)
                {
                    body["Complete"] = ExpressionConverter.ConvertO(bodycomplete);
                    bodypropCount++;
                }

                if (bodycompletedDate != null)
                {
                    body["CompletedDate"] = ExpressionConverter.ConvertO(bodycompletedDate);
                    bodypropCount++;
                }

                if (bodynextStep != null)
                {
                    body["NextStep"] = ExpressionConverter.ConvertO(bodynextStep);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodyassignedDate != null)
                {
                    body["AssignedDate"] = ExpressionConverter.ConvertO(bodyassignedDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyroutingNote != null)
                {
                    body["RoutingNote"] = ExpressionConverter.ConvertO(bodyroutingNote);
                    bodypropCount++;
                }

                if (bodyemailNotify != null)
                {
                    body["emailNotify"] = ExpressionConverter.ConvertO(bodyemailNotify);
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
        [WorkflowExpressionFactory(nameof(__BuildTrackingReportByDeliverable))]
        public IBodyWorkflowAction<TrackingReportByDeliverableV2Response> TrackingReportByDeliverable([WorkflowExpression] Func<string> xAuthorization = null, [WorkflowExpression] Func<string> bodydrawerId = null, [WorkflowExpression] Func<string> bodyserviceType = null, [WorkflowExpression] Func<string> bodyengagementType = null, [WorkflowExpression] Func<string> bodyworkflow = null, [WorkflowExpression] Func<string> bodycurrentStep = null, [WorkflowExpression] Func<string> bodypIC = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodyassignedOn = null, [WorkflowExpression] Func<string> bodyworkflowDescription = null, [WorkflowExpression] Func<string> bodyinProcessOnly = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyreceivedOn = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodysentOn = null, [WorkflowExpression] Func<string> bodyresponsible = null, [WorkflowExpression] Func<string> bodyassignmentHistory = null, [WorkflowExpression] Func<string> bodyreceivedFrom = null, [WorkflowExpression] Func<string> bodysentTo = null, [WorkflowExpression] Func<string> bodycompletedBy = null, [WorkflowExpression] Func<string> bodyaccountable = null, [WorkflowExpression] Func<string> bodycurrentDueDate = null, [WorkflowExpression] Func<string> bodyoriginalDueDate = null, [WorkflowExpression] Func<string> bodydateExtended = null, [WorkflowExpression] Func<string> bodydaysAtStep = null, [WorkflowExpression] Func<string> bodytotalDaysAtStep = null, [WorkflowExpression] Func<string> bodydaysBetweenRoutings = null, [WorkflowExpression] Func<string> bodytotalDaysInProcess = null, [WorkflowExpression] Func<string> bodyroutingDetails = null, [WorkflowExpression] Func<string> bodylastUpdated = null, [WorkflowExpression] Func<string[]> bodyinformationFields = null, [WorkflowExpression] Func<string[]> bodyindexes = null, [WorkflowExpression] Func<string> bodypageNumber = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TrackingReportByDeliverableV2Response> __BuildTrackingReportByDeliverable(WorkflowValue<string> xAuthorization = null, WorkflowValue<string> bodydrawerId = null, WorkflowValue<string> bodyserviceType = null, WorkflowValue<string> bodyengagementType = null, WorkflowValue<string> bodyworkflow = null, WorkflowValue<string> bodycurrentStep = null, WorkflowValue<string> bodypIC = null, WorkflowValue<string> bodyassignedTo = null, WorkflowValue<string> bodyassignedOn = null, WorkflowValue<string> bodyworkflowDescription = null, WorkflowValue<string> bodyinProcessOnly = null, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodypriority = null, WorkflowValue<string> bodyreceivedOn = null, WorkflowValue<string> bodycompletedOn = null, WorkflowValue<string> bodysentOn = null, WorkflowValue<string> bodyresponsible = null, WorkflowValue<string> bodyassignmentHistory = null, WorkflowValue<string> bodyreceivedFrom = null, WorkflowValue<string> bodysentTo = null, WorkflowValue<string> bodycompletedBy = null, WorkflowValue<string> bodyaccountable = null, WorkflowValue<string> bodycurrentDueDate = null, WorkflowValue<string> bodyoriginalDueDate = null, WorkflowValue<string> bodydateExtended = null, WorkflowValue<string> bodydaysAtStep = null, WorkflowValue<string> bodytotalDaysAtStep = null, WorkflowValue<string> bodydaysBetweenRoutings = null, WorkflowValue<string> bodytotalDaysInProcess = null, WorkflowValue<string> bodyroutingDetails = null, WorkflowValue<string> bodylastUpdated = null, WorkflowValue<string[]> bodyinformationFields = null, WorkflowValue<string[]> bodyindexes = null, WorkflowValue<string> bodypageNumber = null)
        {
            WorkflowValue.Validate(xAuthorization, nameof(xAuthorization), required: false);
            WorkflowValue.Validate(bodydrawerId, nameof(bodydrawerId), required: false);
            WorkflowValue.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            WorkflowValue.Validate(bodyengagementType, nameof(bodyengagementType), required: false);
            WorkflowValue.Validate(bodyworkflow, nameof(bodyworkflow), required: false);
            WorkflowValue.Validate(bodycurrentStep, nameof(bodycurrentStep), required: false);
            WorkflowValue.Validate(bodypIC, nameof(bodypIC), required: false);
            WorkflowValue.Validate(bodyassignedTo, nameof(bodyassignedTo), required: false);
            WorkflowValue.Validate(bodyassignedOn, nameof(bodyassignedOn), required: false);
            WorkflowValue.Validate(bodyworkflowDescription, nameof(bodyworkflowDescription), required: false);
            WorkflowValue.Validate(bodyinProcessOnly, nameof(bodyinProcessOnly), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodyreceivedOn, nameof(bodyreceivedOn), required: false);
            WorkflowValue.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            WorkflowValue.Validate(bodysentOn, nameof(bodysentOn), required: false);
            WorkflowValue.Validate(bodyresponsible, nameof(bodyresponsible), required: false);
            WorkflowValue.Validate(bodyassignmentHistory, nameof(bodyassignmentHistory), required: false);
            WorkflowValue.Validate(bodyreceivedFrom, nameof(bodyreceivedFrom), required: false);
            WorkflowValue.Validate(bodysentTo, nameof(bodysentTo), required: false);
            WorkflowValue.Validate(bodycompletedBy, nameof(bodycompletedBy), required: false);
            WorkflowValue.Validate(bodyaccountable, nameof(bodyaccountable), required: false);
            WorkflowValue.Validate(bodycurrentDueDate, nameof(bodycurrentDueDate), required: false);
            WorkflowValue.Validate(bodyoriginalDueDate, nameof(bodyoriginalDueDate), required: false);
            WorkflowValue.Validate(bodydateExtended, nameof(bodydateExtended), required: false);
            WorkflowValue.Validate(bodydaysAtStep, nameof(bodydaysAtStep), required: false);
            WorkflowValue.Validate(bodytotalDaysAtStep, nameof(bodytotalDaysAtStep), required: false);
            WorkflowValue.Validate(bodydaysBetweenRoutings, nameof(bodydaysBetweenRoutings), required: false);
            WorkflowValue.Validate(bodytotalDaysInProcess, nameof(bodytotalDaysInProcess), required: false);
            WorkflowValue.Validate(bodyroutingDetails, nameof(bodyroutingDetails), required: false);
            WorkflowValue.Validate(bodylastUpdated, nameof(bodylastUpdated), required: false);
            WorkflowValue.Validate(bodyinformationFields, nameof(bodyinformationFields), required: false);
            WorkflowValue.Validate(bodyindexes, nameof(bodyindexes), required: false);
            WorkflowValue.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            return new DeferredBodyAction<TrackingReportByDeliverableV2Response>(() =>
            {
                var apiCallPath = "/api/v2/firmflowreports/TrackingReportByDeliverable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydrawerId != null)
                {
                    body["DrawerId"] = ExpressionConverter.ConvertO(bodydrawerId);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["ServiceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                    bodypropCount++;
                }

                if (bodyengagementType != null)
                {
                    body["EngagementType"] = ExpressionConverter.ConvertO(bodyengagementType);
                    bodypropCount++;
                }

                if (bodyworkflow != null)
                {
                    body["Workflow"] = ExpressionConverter.ConvertO(bodyworkflow);
                    bodypropCount++;
                }

                if (bodycurrentStep != null)
                {
                    body["CurrentStep"] = ExpressionConverter.ConvertO(bodycurrentStep);
                    bodypropCount++;
                }

                if (bodypIC != null)
                {
                    body["PIC"] = ExpressionConverter.ConvertO(bodypIC);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["AssignedTo"] = ExpressionConverter.ConvertO(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodyassignedOn != null)
                {
                    body["AssignedOn"] = ExpressionConverter.ConvertO(bodyassignedOn);
                    bodypropCount++;
                }

                if (bodyworkflowDescription != null)
                {
                    body["WorkflowDescription"] = ExpressionConverter.ConvertO(bodyworkflowDescription);
                    bodypropCount++;
                }

                if (bodyinProcessOnly != null)
                {
                    body["InProcessOnly"] = ExpressionConverter.ConvertO(bodyinProcessOnly);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodyreceivedOn != null)
                {
                    body["ReceivedOn"] = ExpressionConverter.ConvertO(bodyreceivedOn);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["CompletedOn"] = ExpressionConverter.ConvertO(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodysentOn != null)
                {
                    body["SentOn"] = ExpressionConverter.ConvertO(bodysentOn);
                    bodypropCount++;
                }

                if (bodyresponsible != null)
                {
                    body["Responsible"] = ExpressionConverter.ConvertO(bodyresponsible);
                    bodypropCount++;
                }

                if (bodyassignmentHistory != null)
                {
                    body["AssignmentHistory"] = ExpressionConverter.ConvertO(bodyassignmentHistory);
                    bodypropCount++;
                }

                if (bodyreceivedFrom != null)
                {
                    body["ReceivedFrom"] = ExpressionConverter.ConvertO(bodyreceivedFrom);
                    bodypropCount++;
                }

                if (bodysentTo != null)
                {
                    body["SentTo"] = ExpressionConverter.ConvertO(bodysentTo);
                    bodypropCount++;
                }

                if (bodycompletedBy != null)
                {
                    body["CompletedBy"] = ExpressionConverter.ConvertO(bodycompletedBy);
                    bodypropCount++;
                }

                if (bodyaccountable != null)
                {
                    body["Accountable"] = ExpressionConverter.ConvertO(bodyaccountable);
                    bodypropCount++;
                }

                if (bodycurrentDueDate != null)
                {
                    body["CurrentDueDate"] = ExpressionConverter.ConvertO(bodycurrentDueDate);
                    bodypropCount++;
                }

                if (bodyoriginalDueDate != null)
                {
                    body["OriginalDueDate"] = ExpressionConverter.ConvertO(bodyoriginalDueDate);
                    bodypropCount++;
                }

                if (bodydateExtended != null)
                {
                    body["DateExtended"] = ExpressionConverter.ConvertO(bodydateExtended);
                    bodypropCount++;
                }

                if (bodydaysAtStep != null)
                {
                    body["DaysAtStep"] = ExpressionConverter.ConvertO(bodydaysAtStep);
                    bodypropCount++;
                }

                if (bodytotalDaysAtStep != null)
                {
                    body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(bodytotalDaysAtStep);
                    bodypropCount++;
                }

                if (bodydaysBetweenRoutings != null)
                {
                    body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(bodydaysBetweenRoutings);
                    bodypropCount++;
                }

                if (bodytotalDaysInProcess != null)
                {
                    body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(bodytotalDaysInProcess);
                    bodypropCount++;
                }

                if (bodyroutingDetails != null)
                {
                    body["RoutingDetails"] = ExpressionConverter.ConvertO(bodyroutingDetails);
                    bodypropCount++;
                }

                if (bodylastUpdated != null)
                {
                    body["LastUpdated"] = ExpressionConverter.ConvertO(bodylastUpdated);
                    bodypropCount++;
                }

                if (bodyinformationFields != null)
                {
                    body["InformationFields"] = ExpressionConverter.ConvertO(bodyinformationFields);
                    bodypropCount++;
                }

                if (bodyindexes != null)
                {
                    body["Indexes"] = ExpressionConverter.ConvertO(bodyindexes);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    body["PageNumber"] = ExpressionConverter.ConvertO(bodypageNumber);
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

    public enum bodydocumentSecurityInputItemDocSecurityTypeType
    {
        [EnumMember(Value = "DENY ACCESS")]
        DENYACCESS,
        [EnumMember(Value = "ALLOW ACCESS")]
        ALLOWACCESS,
        [EnumMember(Value = "NO EDIT")]
        NOEDIT
    }

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
