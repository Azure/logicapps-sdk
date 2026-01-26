//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gofileroom
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GofileroomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyAccessToApproveDocsOnly = null, Expression<Func<string>> bodyAllowAccessToReports = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyEnableMfa = null, Expression<Func<string>> bodyEnforceMfaForUsers = null, Expression<Func<string>> bodyFirmFlowRoutingNotification = null, Expression<Func<string>> bodyFullAccessToDocTracking = null, Expression<Func<string>> bodyGroupName = null, Expression<Func<string>> bodyMfaRequired = null, Expression<Func<string>> bodyPermissonToApproveDocs = null, Expression<Func<bodyReportsInputItem[]>> bodyReports = null, Expression<Func<string>> bodyUploadLocation = null, Expression<Func<string[]>> bodyUsers = null)
        {
            var apiCallPath = "/api/v1/administration/group/creategroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccessToApproveDocsOnly != null)
            {
                body["AccessToApproveDocsOnly"] = ExpressionConverter.ConvertO(bodyAccessToApproveDocsOnly);
                bodypropCount++;
            }

            if (bodyAllowAccessToReports != null)
            {
                body["AllowAccessToReports"] = ExpressionConverter.ConvertO(bodyAllowAccessToReports);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyEnableMfa != null)
            {
                body["EnableMfa"] = ExpressionConverter.ConvertO(bodyEnableMfa);
                bodypropCount++;
            }

            if (bodyEnforceMfaForUsers != null)
            {
                body["EnforceMfaForUsers"] = ExpressionConverter.ConvertO(bodyEnforceMfaForUsers);
                bodypropCount++;
            }

            if (bodyFirmFlowRoutingNotification != null)
            {
                body["FirmFlowRoutingNotification"] = ExpressionConverter.ConvertO(bodyFirmFlowRoutingNotification);
                bodypropCount++;
            }

            if (bodyFullAccessToDocTracking != null)
            {
                body["FullAccessToDocTracking"] = ExpressionConverter.ConvertO(bodyFullAccessToDocTracking);
                bodypropCount++;
            }

            if (bodyGroupName != null)
            {
                body["GroupName"] = ExpressionConverter.ConvertO(bodyGroupName);
                bodypropCount++;
            }

            if (bodyMfaRequired != null)
            {
                body["MfaRequired"] = ExpressionConverter.ConvertO(bodyMfaRequired);
                bodypropCount++;
            }

            if (bodyPermissonToApproveDocs != null)
            {
                body["PermissonToApproveDocs"] = ExpressionConverter.ConvertO(bodyPermissonToApproveDocs);
                bodypropCount++;
            }

            if (bodyReports != null)
            {
                body["Reports"] = ExpressionConverter.ConvertO(bodyReports);
                bodypropCount++;
            }

            if (bodyUploadLocation != null)
            {
                body["UploadLocation"] = ExpressionConverter.ConvertO(bodyUploadLocation);
                bodypropCount++;
            }

            if (bodyUsers != null)
            {
                body["Users"] = ExpressionConverter.ConvertO(bodyUsers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetGroupDocSecurityResponse> SetGroupDocSecurity(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyCabinetName = null, Expression<Func<bodyDocumentSecurityInputItem[]>> bodyDocumentSecurity = null, Expression<Func<string>> bodyDrawerName = null, Expression<Func<string>> bodyGroupName = null)
        {
            var apiCallPath = "/api/v1/administration/group/documentsecurity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCabinetName != null)
            {
                body["CabinetName"] = ExpressionConverter.ConvertO(bodyCabinetName);
                bodypropCount++;
            }

            if (bodyDocumentSecurity != null)
            {
                body["DocumentSecurity"] = ExpressionConverter.ConvertO(bodyDocumentSecurity);
                bodypropCount++;
            }

            if (bodyDrawerName != null)
            {
                body["DrawerName"] = ExpressionConverter.ConvertO(bodyDrawerName);
                bodypropCount++;
            }

            if (bodyGroupName != null)
            {
                body["GroupName"] = ExpressionConverter.ConvertO(bodyGroupName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetGroupDocSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ModifyGroupResponse> ModifyGroup(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyAccessToApproveDocsOnly = null, Expression<Func<string>> bodyAllowAccessToReports = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyEnableMfa = null, Expression<Func<string>> bodyEnforceMfaForUsers = null, Expression<Func<string>> bodyFirmFlowRoutingNotification = null, Expression<Func<string>> bodyFullAccessToDocTracking = null, Expression<Func<string>> bodyGroupName = null, Expression<Func<string>> bodyMfaRequired = null, Expression<Func<string>> bodyPermissonToApproveDocs = null, Expression<Func<string>> bodyRenameGroup = null, Expression<Func<bodyReportsInputItem[]>> bodyReports = null, Expression<Func<string>> bodyUploadLocation = null, Expression<Func<string[]>> bodyUsers = null)
        {
            var apiCallPath = "/api/v1/administration/group/modifygroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccessToApproveDocsOnly != null)
            {
                body["AccessToApproveDocsOnly"] = ExpressionConverter.ConvertO(bodyAccessToApproveDocsOnly);
                bodypropCount++;
            }

            if (bodyAllowAccessToReports != null)
            {
                body["AllowAccessToReports"] = ExpressionConverter.ConvertO(bodyAllowAccessToReports);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyEnableMfa != null)
            {
                body["EnableMfa"] = ExpressionConverter.ConvertO(bodyEnableMfa);
                bodypropCount++;
            }

            if (bodyEnforceMfaForUsers != null)
            {
                body["EnforceMfaForUsers"] = ExpressionConverter.ConvertO(bodyEnforceMfaForUsers);
                bodypropCount++;
            }

            if (bodyFirmFlowRoutingNotification != null)
            {
                body["FirmFlowRoutingNotification"] = ExpressionConverter.ConvertO(bodyFirmFlowRoutingNotification);
                bodypropCount++;
            }

            if (bodyFullAccessToDocTracking != null)
            {
                body["FullAccessToDocTracking"] = ExpressionConverter.ConvertO(bodyFullAccessToDocTracking);
                bodypropCount++;
            }

            if (bodyGroupName != null)
            {
                body["GroupName"] = ExpressionConverter.ConvertO(bodyGroupName);
                bodypropCount++;
            }

            if (bodyMfaRequired != null)
            {
                body["MfaRequired"] = ExpressionConverter.ConvertO(bodyMfaRequired);
                bodypropCount++;
            }

            if (bodyPermissonToApproveDocs != null)
            {
                body["PermissonToApproveDocs"] = ExpressionConverter.ConvertO(bodyPermissonToApproveDocs);
                bodypropCount++;
            }

            if (bodyRenameGroup != null)
            {
                body["RenameGroup"] = ExpressionConverter.ConvertO(bodyRenameGroup);
                bodypropCount++;
            }

            if (bodyReports != null)
            {
                body["Reports"] = ExpressionConverter.ConvertO(bodyReports);
                bodypropCount++;
            }

            if (bodyUploadLocation != null)
            {
                body["UploadLocation"] = ExpressionConverter.ConvertO(bodyUploadLocation);
                bodypropCount++;
            }

            if (bodyUsers != null)
            {
                body["Users"] = ExpressionConverter.ConvertO(bodyUsers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ModifyGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupPermissionsResponse> GetGroupPermissions(Expression<Func<string>> groupName = null, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/group/permissions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (groupName != null)
                callPayload.Queries["groupName"] = ExpressionConverter.Convert(groupName);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetGroupPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetGroupPermissionsResponse> SetGroupPermissions(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyCabinet = null, Expression<Func<string>> bodyCabinetPermissionAdd = null, Expression<Func<string>> bodyCabinetPermissionDelete = null, Expression<Func<string>> bodyCabinetPermissionDeny = null, Expression<Func<string>> bodyCabinetPermissionEdit = null, Expression<Func<string>> bodyCabinetPermissionLookUp = null, Expression<Func<string>> bodyCabinetPermissionRead = null, Expression<Func<bodyDrawerPermissionsInputItem[]>> bodyDrawerPermissions = null, Expression<Func<string>> bodyGroupName = null)
        {
            var apiCallPath = "/api/v1/administration/group/permissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCabinet != null)
            {
                body["Cabinet"] = ExpressionConverter.ConvertO(bodyCabinet);
                bodypropCount++;
            }

            var CabinetPermissionObject = new JObject();
            var CabinetPermissionObjectpropCount = 0;
            if (bodyCabinetPermissionAdd != null)
            {
                CabinetPermissionObject["Add"] = ExpressionConverter.ConvertO(bodyCabinetPermissionAdd);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionDelete != null)
            {
                CabinetPermissionObject["Delete"] = ExpressionConverter.ConvertO(bodyCabinetPermissionDelete);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionDeny != null)
            {
                CabinetPermissionObject["Deny"] = ExpressionConverter.ConvertO(bodyCabinetPermissionDeny);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionEdit != null)
            {
                CabinetPermissionObject["Edit"] = ExpressionConverter.ConvertO(bodyCabinetPermissionEdit);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionLookUp != null)
            {
                CabinetPermissionObject["LookUp"] = ExpressionConverter.ConvertO(bodyCabinetPermissionLookUp);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionRead != null)
            {
                CabinetPermissionObject["Read"] = ExpressionConverter.ConvertO(bodyCabinetPermissionRead);
                CabinetPermissionObjectpropCount++;
            }

            if (CabinetPermissionObjectpropCount > 0)
            {
                body["CabinetPermission"] = CabinetPermissionObject;
                bodypropCount++;
            }

            if (bodyDrawerPermissions != null)
            {
                body["DrawerPermissions"] = ExpressionConverter.ConvertO(bodyDrawerPermissions);
                bodypropCount++;
            }

            if (bodyGroupName != null)
            {
                body["GroupName"] = ExpressionConverter.ConvertO(bodyGroupName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetGroupPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupDocumentSecurityResponse> GetGroupDocumentSecurity(Expression<Func<string>> groupName, Expression<Func<string>> cabinetName, Expression<Func<string>> drawerName, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/administration/group/{0}/{1}/{2}/documentsecurity", ExpressionConverter.ConvertWithUrlEncoding(groupName, 1), ExpressionConverter.ConvertWithUrlEncoding(cabinetName, 1), ExpressionConverter.ConvertWithUrlEncoding(drawerName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetGroupDocumentSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupsResponseItem[]> GetGroups(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/groups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetGroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateUsersResponse> CreateUsers(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyAccountExpiresDate = null, Expression<Func<string>> bodyDisabledComments = null, Expression<Func<string>> bodyFullName = null, Expression<Func<string[]>> bodyGroups = null, Expression<Func<string>> bodyIsAccountExpires = null, Expression<Func<string>> bodyIsAdvanceFlow = null, Expression<Func<string>> bodyIsAllowAccessToReports = null, Expression<Func<string>> bodyIsAllowOffline = null, Expression<Func<string>> bodyIsDisabled = null, Expression<Func<string>> bodyIsFirmFlow = null, Expression<Func<string>> bodyIsFirmFlowNotificationGroup = null, Expression<Func<string>> bodyIsFirmFlowNotificationUser = null, Expression<Func<string>> bodyIsMfa = null, Expression<Func<string>> bodyIsUserAdministration = null, Expression<Func<string>> bodyIsWorkflowManagerUser = null, Expression<Func<string>> bodyLicenseType = null, Expression<Func<string>> bodyLoginName = null, Expression<Func<string>> bodyManagerEmail = null, Expression<Func<string>> bodyPassword = null, Expression<Func<bodyReportsInputItem[]>> bodyReports = null, Expression<Func<string>> bodyUploadLocation = null)
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
            if (bodyAccountExpiresDate != null)
            {
                body["AccountExpiresDate"] = ExpressionConverter.ConvertO(bodyAccountExpiresDate);
                bodypropCount++;
            }

            if (bodyDisabledComments != null)
            {
                body["DisabledComments"] = ExpressionConverter.ConvertO(bodyDisabledComments);
                bodypropCount++;
            }

            if (bodyFullName != null)
            {
                body["FullName"] = ExpressionConverter.ConvertO(bodyFullName);
                bodypropCount++;
            }

            if (bodyGroups != null)
            {
                body["Groups"] = ExpressionConverter.ConvertO(bodyGroups);
                bodypropCount++;
            }

            if (bodyIsAccountExpires != null)
            {
                body["IsAccountExpires"] = ExpressionConverter.ConvertO(bodyIsAccountExpires);
                bodypropCount++;
            }

            if (bodyIsAdvanceFlow != null)
            {
                body["IsAdvanceFlow"] = ExpressionConverter.ConvertO(bodyIsAdvanceFlow);
                bodypropCount++;
            }

            if (bodyIsAllowAccessToReports != null)
            {
                body["IsAllowAccessToReports"] = ExpressionConverter.ConvertO(bodyIsAllowAccessToReports);
                bodypropCount++;
            }

            if (bodyIsAllowOffline != null)
            {
                body["IsAllowOffline"] = ExpressionConverter.ConvertO(bodyIsAllowOffline);
                bodypropCount++;
            }

            if (bodyIsDisabled != null)
            {
                body["IsDisabled"] = ExpressionConverter.ConvertO(bodyIsDisabled);
                bodypropCount++;
            }

            if (bodyIsFirmFlow != null)
            {
                body["IsFirmFlow"] = ExpressionConverter.ConvertO(bodyIsFirmFlow);
                bodypropCount++;
            }

            if (bodyIsFirmFlowNotificationGroup != null)
            {
                body["IsFirmFlowNotificationGroup"] = ExpressionConverter.ConvertO(bodyIsFirmFlowNotificationGroup);
                bodypropCount++;
            }

            if (bodyIsFirmFlowNotificationUser != null)
            {
                body["IsFirmFlowNotificationUser"] = ExpressionConverter.ConvertO(bodyIsFirmFlowNotificationUser);
                bodypropCount++;
            }

            if (bodyIsMfa != null)
            {
                body["IsMfa"] = ExpressionConverter.ConvertO(bodyIsMfa);
                bodypropCount++;
            }

            if (bodyIsUserAdministration != null)
            {
                body["IsUserAdministration"] = ExpressionConverter.ConvertO(bodyIsUserAdministration);
                bodypropCount++;
            }

            if (bodyIsWorkflowManagerUser != null)
            {
                body["IsWorkflowManagerUser"] = ExpressionConverter.ConvertO(bodyIsWorkflowManagerUser);
                bodypropCount++;
            }

            if (bodyLicenseType != null)
            {
                body["LicenseType"] = ExpressionConverter.ConvertO(bodyLicenseType);
                bodypropCount++;
            }

            if (bodyLoginName != null)
            {
                body["LoginName"] = ExpressionConverter.ConvertO(bodyLoginName);
                bodypropCount++;
            }

            if (bodyManagerEmail != null)
            {
                body["ManagerEmail"] = ExpressionConverter.ConvertO(bodyManagerEmail);
                bodypropCount++;
            }

            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyReports != null)
            {
                body["Reports"] = ExpressionConverter.ConvertO(bodyReports);
                bodypropCount++;
            }

            if (bodyUploadLocation != null)
            {
                body["UploadLocation"] = ExpressionConverter.ConvertO(bodyUploadLocation);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteUserResponse> DeleteUser(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyLoginId = null, Expression<Func<bodyUserTypeInput>> bodyUserType = null)
        {
            var apiCallPath = "/api/v1/administration/user/delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyLoginId != null)
            {
                body["LoginId"] = ExpressionConverter.ConvertO(bodyLoginId);
                bodypropCount++;
            }

            if (bodyUserType != null)
            {
                body["UserType"] = ExpressionConverter.ConvertO(bodyUserType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeleteUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetUserDocSecurityResponse> SetUserDocSecurity(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyCabinetName = null, Expression<Func<bodyDocumentSecurityInputItem2[]>> bodyDocumentSecurity = null, Expression<Func<string>> bodyDrawerName = null, Expression<Func<string>> bodyLoginId = null)
        {
            var apiCallPath = "/api/v1/administration/user/documentsecurity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCabinetName != null)
            {
                body["CabinetName"] = ExpressionConverter.ConvertO(bodyCabinetName);
                bodypropCount++;
            }

            if (bodyDocumentSecurity != null)
            {
                body["DocumentSecurity"] = ExpressionConverter.ConvertO(bodyDocumentSecurity);
                bodypropCount++;
            }

            if (bodyDrawerName != null)
            {
                body["DrawerName"] = ExpressionConverter.ConvertO(bodyDrawerName);
                bodypropCount++;
            }

            if (bodyLoginId != null)
            {
                body["LoginId"] = ExpressionConverter.ConvertO(bodyLoginId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetUserDocSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo(Expression<Func<string>> bodyLoginName, Expression<Func<string>> bodyUserType, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/user/getuser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["LoginName"] = ExpressionConverter.ConvertO(bodyLoginName);
            bodypropCount++;
            body["UserType"] = ExpressionConverter.ConvertO(bodyUserType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetUserInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetLicensesResponse> GetLicenses(Expression<Func<licenseInput>> license = null, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/user/licenses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (license != null)
                callPayload.Queries["license"] = ExpressionConverter.Convert(license);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetLicensesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ModifyUserResponse> ModifyUser(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyAccountExpiresDate = null, Expression<Func<string>> bodyDisabledComments = null, Expression<Func<string>> bodyFullName = null, Expression<Func<string[]>> bodyGroups = null, Expression<Func<string>> bodyIsAccountExpires = null, Expression<Func<string>> bodyIsAdvanceFlow = null, Expression<Func<string>> bodyIsAllowAccessToReports = null, Expression<Func<string>> bodyIsAllowOffline = null, Expression<Func<string>> bodyIsChangeNextLogin = null, Expression<Func<string>> bodyIsDisabled = null, Expression<Func<string>> bodyIsFirmFlow = null, Expression<Func<string>> bodyIsFirmFlowNotificationGroup = null, Expression<Func<string>> bodyIsFirmFlowNotificationUser = null, Expression<Func<string>> bodyIsMfa = null, Expression<Func<string>> bodyIsUserAdministration = null, Expression<Func<string>> bodyIsWorkflowManagerUser = null, Expression<Func<string>> bodyLicenseType = null, Expression<Func<string>> bodyLoginName = null, Expression<Func<string>> bodyManagerEmail = null, Expression<Func<string>> bodyPassword = null, Expression<Func<bodyReportsInputItem[]>> bodyReports = null, Expression<Func<string>> bodyUploadLocation = null)
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
            if (bodyAccountExpiresDate != null)
            {
                body["AccountExpiresDate"] = ExpressionConverter.ConvertO(bodyAccountExpiresDate);
                bodypropCount++;
            }

            if (bodyDisabledComments != null)
            {
                body["DisabledComments"] = ExpressionConverter.ConvertO(bodyDisabledComments);
                bodypropCount++;
            }

            if (bodyFullName != null)
            {
                body["FullName"] = ExpressionConverter.ConvertO(bodyFullName);
                bodypropCount++;
            }

            if (bodyGroups != null)
            {
                body["Groups"] = ExpressionConverter.ConvertO(bodyGroups);
                bodypropCount++;
            }

            if (bodyIsAccountExpires != null)
            {
                body["IsAccountExpires"] = ExpressionConverter.ConvertO(bodyIsAccountExpires);
                bodypropCount++;
            }

            if (bodyIsAdvanceFlow != null)
            {
                body["IsAdvanceFlow"] = ExpressionConverter.ConvertO(bodyIsAdvanceFlow);
                bodypropCount++;
            }

            if (bodyIsAllowAccessToReports != null)
            {
                body["IsAllowAccessToReports"] = ExpressionConverter.ConvertO(bodyIsAllowAccessToReports);
                bodypropCount++;
            }

            if (bodyIsAllowOffline != null)
            {
                body["IsAllowOffline"] = ExpressionConverter.ConvertO(bodyIsAllowOffline);
                bodypropCount++;
            }

            if (bodyIsChangeNextLogin != null)
            {
                body["IsChangeNextLogin"] = ExpressionConverter.ConvertO(bodyIsChangeNextLogin);
                bodypropCount++;
            }

            if (bodyIsDisabled != null)
            {
                body["IsDisabled"] = ExpressionConverter.ConvertO(bodyIsDisabled);
                bodypropCount++;
            }

            if (bodyIsFirmFlow != null)
            {
                body["IsFirmFlow"] = ExpressionConverter.ConvertO(bodyIsFirmFlow);
                bodypropCount++;
            }

            if (bodyIsFirmFlowNotificationGroup != null)
            {
                body["IsFirmFlowNotificationGroup"] = ExpressionConverter.ConvertO(bodyIsFirmFlowNotificationGroup);
                bodypropCount++;
            }

            if (bodyIsFirmFlowNotificationUser != null)
            {
                body["IsFirmFlowNotificationUser"] = ExpressionConverter.ConvertO(bodyIsFirmFlowNotificationUser);
                bodypropCount++;
            }

            if (bodyIsMfa != null)
            {
                body["IsMfa"] = ExpressionConverter.ConvertO(bodyIsMfa);
                bodypropCount++;
            }

            if (bodyIsUserAdministration != null)
            {
                body["IsUserAdministration"] = ExpressionConverter.ConvertO(bodyIsUserAdministration);
                bodypropCount++;
            }

            if (bodyIsWorkflowManagerUser != null)
            {
                body["IsWorkflowManagerUser"] = ExpressionConverter.ConvertO(bodyIsWorkflowManagerUser);
                bodypropCount++;
            }

            if (bodyLicenseType != null)
            {
                body["LicenseType"] = ExpressionConverter.ConvertO(bodyLicenseType);
                bodypropCount++;
            }

            if (bodyLoginName != null)
            {
                body["LoginName"] = ExpressionConverter.ConvertO(bodyLoginName);
                bodypropCount++;
            }

            if (bodyManagerEmail != null)
            {
                body["ManagerEmail"] = ExpressionConverter.ConvertO(bodyManagerEmail);
                bodypropCount++;
            }

            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyReports != null)
            {
                body["Reports"] = ExpressionConverter.ConvertO(bodyReports);
                bodypropCount++;
            }

            if (bodyUploadLocation != null)
            {
                body["UploadLocation"] = ExpressionConverter.ConvertO(bodyUploadLocation);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ModifyUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetPasswordPolicyResponse> GetPasswordPolicy(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/user/passwordpolicy";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetPasswordPolicyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetUserPermissionsResponse> SetUserPermissions(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyCabinet = null, Expression<Func<string>> bodyCabinetPermissionAdd = null, Expression<Func<string>> bodyCabinetPermissionDelete = null, Expression<Func<string>> bodyCabinetPermissionDeny = null, Expression<Func<string>> bodyCabinetPermissionEdit = null, Expression<Func<string>> bodyCabinetPermissionLookUp = null, Expression<Func<string>> bodyCabinetPermissionRead = null, Expression<Func<bodyDrawerPermissionsInputItem[]>> bodyDrawerPermissions = null, Expression<Func<string>> bodyLoginId = null)
        {
            var apiCallPath = "/api/v1/administration/user/permissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCabinet != null)
            {
                body["Cabinet"] = ExpressionConverter.ConvertO(bodyCabinet);
                bodypropCount++;
            }

            var CabinetPermissionObject = new JObject();
            var CabinetPermissionObjectpropCount = 0;
            if (bodyCabinetPermissionAdd != null)
            {
                CabinetPermissionObject["Add"] = ExpressionConverter.ConvertO(bodyCabinetPermissionAdd);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionDelete != null)
            {
                CabinetPermissionObject["Delete"] = ExpressionConverter.ConvertO(bodyCabinetPermissionDelete);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionDeny != null)
            {
                CabinetPermissionObject["Deny"] = ExpressionConverter.ConvertO(bodyCabinetPermissionDeny);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionEdit != null)
            {
                CabinetPermissionObject["Edit"] = ExpressionConverter.ConvertO(bodyCabinetPermissionEdit);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionLookUp != null)
            {
                CabinetPermissionObject["LookUp"] = ExpressionConverter.ConvertO(bodyCabinetPermissionLookUp);
                CabinetPermissionObjectpropCount++;
            }

            if (bodyCabinetPermissionRead != null)
            {
                CabinetPermissionObject["Read"] = ExpressionConverter.ConvertO(bodyCabinetPermissionRead);
                CabinetPermissionObjectpropCount++;
            }

            if (CabinetPermissionObjectpropCount > 0)
            {
                body["CabinetPermission"] = CabinetPermissionObject;
                bodypropCount++;
            }

            if (bodyDrawerPermissions != null)
            {
                body["DrawerPermissions"] = ExpressionConverter.ConvertO(bodyDrawerPermissions);
                bodypropCount++;
            }

            if (bodyLoginId != null)
            {
                body["LoginId"] = ExpressionConverter.ConvertO(bodyLoginId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetUserPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetListOfReportsResponse> GetListOfReports(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/user/reports";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetListOfReportsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUploadLocationResponse> GetUploadLocation(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/user/uploadlocations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetUploadLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserDocumentSecurityResponse> GetUserDocumentSecurity(Expression<Func<string>> loginId, Expression<Func<string>> cabinetName, Expression<Func<string>> drawerName, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/administration/user/{0}/{1}/{2}/documentsecurity", ExpressionConverter.ConvertWithUrlEncoding(loginId, 1), ExpressionConverter.ConvertWithUrlEncoding(cabinetName, 1), ExpressionConverter.ConvertWithUrlEncoding(drawerName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetUserDocumentSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserPermissionResponse> GetUserPermission(Expression<Func<string>> login, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/administration/user/{0}/permissions", ExpressionConverter.ConvertWithUrlEncoding(login, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetUserPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUsersResponseItem[]> GetUsers(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/administration/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userType != null)
                callPayload.Queries["userType"] = ExpressionConverter.Convert(userType);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetUsersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetLookupListResponseItem[]> GetLookupList(Expression<Func<string>> drawerId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/administration/{0}/clients", ExpressionConverter.ConvertWithUrlEncoding(drawerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetLookupListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyDrawerId = null, Expression<Func<bodyIndexesInputItem[]>> bodyIndexes = null)
        {
            var apiCallPath = "/api/v1/documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDrawerId != null)
            {
                body["DrawerId"] = ExpressionConverter.ConvertO(bodyDrawerId);
                bodypropCount++;
            }

            if (bodyIndexes != null)
            {
                body["Indexes"] = ExpressionConverter.ConvertO(bodyIndexes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CopyDocumentResponseItem[]> CopyDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> bodyDocumentIds = null, Expression<Func<bodyIndexValuesInputItem[]>> bodyIndexValues = null)
        {
            var apiCallPath = "/api/v1/documents/copy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDocumentIds != null)
            {
                body["DocumentIds"] = ExpressionConverter.ConvertO(bodyDocumentIds);
                bodypropCount++;
            }

            if (bodyIndexValues != null)
            {
                body["IndexValues"] = ExpressionConverter.ConvertO(bodyIndexValues);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CopyDocumentResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentStatusResponseItem[]> GetDocumentStatus(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = "/api/v1/documents/getdocumentstatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<GetDocumentStatusResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<string> MergePDF(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = "/api/v1/documents/mergePDFs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentReindexResponseItem[]> DocumentReindex(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> bodyDocumentIds = null, Expression<Func<bodyIndexValuesInputItem[]>> bodyIndexValues = null)
        {
            var apiCallPath = "/api/v1/documents/reindex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDocumentIds != null)
            {
                body["DocumentIds"] = ExpressionConverter.ConvertO(bodyDocumentIds);
                bodypropCount++;
            }

            if (bodyIndexValues != null)
            {
                body["IndexValues"] = ExpressionConverter.ConvertO(bodyIndexValues);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocumentReindexResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentSearchResponse> DocumentSearch(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyDrawerId = null, Expression<Func<bodyFilterIndexValuesInputItem[]>> bodyFilterIndexValues = null, Expression<Func<int>> bodyNumberOfRows = null, Expression<Func<int>> bodyPageNumber = null, Expression<Func<string>> bodySortField = null, Expression<Func<bodySortOrderInput>> bodySortOrder = null)
        {
            var apiCallPath = "/api/v1/documents/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDrawerId != null)
            {
                body["DrawerId"] = ExpressionConverter.ConvertO(bodyDrawerId);
                bodypropCount++;
            }

            var FilterObject = new JObject();
            var FilterObjectpropCount = 0;
            if (bodyFilterIndexValues != null)
            {
                FilterObject["IndexValues"] = ExpressionConverter.ConvertO(bodyFilterIndexValues);
                FilterObjectpropCount++;
            }

            if (FilterObjectpropCount > 0)
            {
                body["Filter"] = FilterObject;
                bodypropCount++;
            }

            if (bodyNumberOfRows != null)
            {
                body["NumberOfRows"] = ExpressionConverter.ConvertO(bodyNumberOfRows);
                bodypropCount++;
            }

            if (bodyPageNumber != null)
            {
                body["PageNumber"] = ExpressionConverter.ConvertO(bodyPageNumber);
                bodypropCount++;
            }

            if (bodySortField != null)
            {
                body["SortField"] = ExpressionConverter.ConvertO(bodySortField);
                bodypropCount++;
            }

            if (bodySortOrder != null)
            {
                body["SortOrder"] = ExpressionConverter.ConvertO(bodySortOrder);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocumentSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TaxsortDocumentResponseItem[]> TaxsortDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = "/api/v1/documents/taxsort";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<TaxsortDocumentResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentDeleteResponseItem[]> DocumentDelete(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<DocumentDeleteResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IWorkflowAction GetDocument(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/file", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentHistoryResponse> GetDocumentHistory(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetDocumentHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentIndexesResponseItem[]> GetDocumentIndexes(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/indexes", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetDocumentIndexesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<PublishDocumentStatusResponseItem[]> PublishDocumentStatus(Expression<Func<string>> documentId, Expression<Func<string>> bodyIsPublished, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["IsPublished"] = ExpressionConverter.ConvertO(bodyIsPublished);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PublishDocumentStatusResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDrawersResponseItem[]> GetDrawers(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/drawers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetDrawersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDrawerIndexesResponseItem[]> GetDrawerIndexes(Expression<Func<string>> drawerId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/drawers/{0}/indexes", ExpressionConverter.ConvertWithUrlEncoding(drawerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetDrawerIndexesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetFirmFlowDeliverableReportResponse> GetFirmFlowDeliverableReport(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyAccountable = null, Expression<Func<string>> bodyAssignedOn = null, Expression<Func<string>> bodyAssignedTo = null, Expression<Func<string>> bodyAssignmentHistory = null, Expression<Func<string>> bodyCompletedBy = null, Expression<Func<string>> bodyCompletedOn = null, Expression<Func<string>> bodyCurrentDueDate = null, Expression<Func<string>> bodyCurrentStep = null, Expression<Func<string>> bodyDateExtended = null, Expression<Func<string>> bodyDaysAtStep = null, Expression<Func<string>> bodyDaysBetweenRoutings = null, Expression<Func<string>> bodyDrawerId = null, Expression<Func<string>> bodyEngagementType = null, Expression<Func<string>> bodyInProcessOnly = null, Expression<Func<string[]>> bodyIndexes = null, Expression<Func<string[]>> bodyInformationFields = null, Expression<Func<string>> bodyOriginalDueDate = null, Expression<Func<string>> bodyPIC = null, Expression<Func<string>> bodyPageNumber = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodyReceivedFrom = null, Expression<Func<string>> bodyReceivedOn = null, Expression<Func<string>> bodyResponsible = null, Expression<Func<string>> bodyRoutingDetails = null, Expression<Func<string>> bodySentOn = null, Expression<Func<string>> bodySentTo = null, Expression<Func<string>> bodyServiceType = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyTotalDaysAtStep = null, Expression<Func<string>> bodyTotalDaysInProcess = null, Expression<Func<string>> bodyWorkflow = null, Expression<Func<string>> bodyWorkflowDescription = null)
        {
            var apiCallPath = "/api/v1/firmflowreports/TrackingReportByDeliverable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccountable != null)
            {
                body["Accountable"] = ExpressionConverter.ConvertO(bodyAccountable);
                bodypropCount++;
            }

            if (bodyAssignedOn != null)
            {
                body["AssignedOn"] = ExpressionConverter.ConvertO(bodyAssignedOn);
                bodypropCount++;
            }

            if (bodyAssignedTo != null)
            {
                body["AssignedTo"] = ExpressionConverter.ConvertO(bodyAssignedTo);
                bodypropCount++;
            }

            if (bodyAssignmentHistory != null)
            {
                body["AssignmentHistory"] = ExpressionConverter.ConvertO(bodyAssignmentHistory);
                bodypropCount++;
            }

            if (bodyCompletedBy != null)
            {
                body["CompletedBy"] = ExpressionConverter.ConvertO(bodyCompletedBy);
                bodypropCount++;
            }

            if (bodyCompletedOn != null)
            {
                body["CompletedOn"] = ExpressionConverter.ConvertO(bodyCompletedOn);
                bodypropCount++;
            }

            if (bodyCurrentDueDate != null)
            {
                body["CurrentDueDate"] = ExpressionConverter.ConvertO(bodyCurrentDueDate);
                bodypropCount++;
            }

            if (bodyCurrentStep != null)
            {
                body["CurrentStep"] = ExpressionConverter.ConvertO(bodyCurrentStep);
                bodypropCount++;
            }

            if (bodyDateExtended != null)
            {
                body["DateExtended"] = ExpressionConverter.ConvertO(bodyDateExtended);
                bodypropCount++;
            }

            if (bodyDaysAtStep != null)
            {
                body["DaysAtStep"] = ExpressionConverter.ConvertO(bodyDaysAtStep);
                bodypropCount++;
            }

            if (bodyDaysBetweenRoutings != null)
            {
                body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(bodyDaysBetweenRoutings);
                bodypropCount++;
            }

            if (bodyDrawerId != null)
            {
                body["DrawerId"] = ExpressionConverter.ConvertO(bodyDrawerId);
                bodypropCount++;
            }

            if (bodyEngagementType != null)
            {
                body["EngagementType"] = ExpressionConverter.ConvertO(bodyEngagementType);
                bodypropCount++;
            }

            if (bodyInProcessOnly != null)
            {
                body["InProcessOnly"] = ExpressionConverter.ConvertO(bodyInProcessOnly);
                bodypropCount++;
            }

            if (bodyIndexes != null)
            {
                body["Indexes"] = ExpressionConverter.ConvertO(bodyIndexes);
                bodypropCount++;
            }

            if (bodyInformationFields != null)
            {
                body["InformationFields"] = ExpressionConverter.ConvertO(bodyInformationFields);
                bodypropCount++;
            }

            if (bodyOriginalDueDate != null)
            {
                body["OriginalDueDate"] = ExpressionConverter.ConvertO(bodyOriginalDueDate);
                bodypropCount++;
            }

            if (bodyPIC != null)
            {
                body["PIC"] = ExpressionConverter.ConvertO(bodyPIC);
                bodypropCount++;
            }

            if (bodyPageNumber != null)
            {
                body["PageNumber"] = ExpressionConverter.ConvertO(bodyPageNumber);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyReceivedFrom != null)
            {
                body["ReceivedFrom"] = ExpressionConverter.ConvertO(bodyReceivedFrom);
                bodypropCount++;
            }

            if (bodyReceivedOn != null)
            {
                body["ReceivedOn"] = ExpressionConverter.ConvertO(bodyReceivedOn);
                bodypropCount++;
            }

            if (bodyResponsible != null)
            {
                body["Responsible"] = ExpressionConverter.ConvertO(bodyResponsible);
                bodypropCount++;
            }

            if (bodyRoutingDetails != null)
            {
                body["RoutingDetails"] = ExpressionConverter.ConvertO(bodyRoutingDetails);
                bodypropCount++;
            }

            if (bodySentOn != null)
            {
                body["SentOn"] = ExpressionConverter.ConvertO(bodySentOn);
                bodypropCount++;
            }

            if (bodySentTo != null)
            {
                body["SentTo"] = ExpressionConverter.ConvertO(bodySentTo);
                bodypropCount++;
            }

            if (bodyServiceType != null)
            {
                body["ServiceType"] = ExpressionConverter.ConvertO(bodyServiceType);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyTotalDaysAtStep != null)
            {
                body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(bodyTotalDaysAtStep);
                bodypropCount++;
            }

            if (bodyTotalDaysInProcess != null)
            {
                body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(bodyTotalDaysInProcess);
                bodypropCount++;
            }

            if (bodyWorkflow != null)
            {
                body["Workflow"] = ExpressionConverter.ConvertO(bodyWorkflow);
                bodypropCount++;
            }

            if (bodyWorkflowDescription != null)
            {
                body["WorkflowDescription"] = ExpressionConverter.ConvertO(bodyWorkflowDescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetFirmFlowDeliverableReportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ValidateIndexesResponse> ValidateIndexes(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyDrawerId = null, Expression<Func<bodyIndexesInputItem[]>> bodyIndexes = null)
        {
            var apiCallPath = "/api/v1/indexes/validate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDrawerId != null)
            {
                body["DrawerId"] = ExpressionConverter.ConvertO(bodyDrawerId);
                bodypropCount++;
            }

            if (bodyIndexes != null)
            {
                body["Indexes"] = ExpressionConverter.ConvertO(bodyIndexes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ValidateIndexesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDynamicRulesForIndexResponseItem[]> GetDynamicRulesForIndex(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/indexes/{0}/dynamicrules", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetDynamicRulesForIndexResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<IndexLookupListFindResponseItem[]> IndexLookupListFind(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null, Expression<Func<bodyActionTypeInput>> bodyActionType = null, Expression<Func<int>> bodyCount = null, Expression<Func<string>> bodyIndexValue = null, Expression<Func<bodySearchTypeInput>> bodySearchType = null)
        {
            var apiCallPath = String.Format("/api/v1/indexes/{0}/lookuplist", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyActionType != null)
            {
                body["ActionType"] = ExpressionConverter.ConvertO(bodyActionType);
                bodypropCount++;
            }

            if (bodyCount != null)
            {
                body["Count"] = ExpressionConverter.ConvertO(bodyCount);
                bodypropCount++;
            }

            if (bodyIndexValue != null)
            {
                body["IndexValue"] = ExpressionConverter.ConvertO(bodyIndexValue);
                bodypropCount++;
            }

            if (bodySearchType != null)
            {
                body["SearchType"] = ExpressionConverter.ConvertO(bodySearchType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IndexLookupListFindResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetListTypeIndexDataResponseItem[]> GetListTypeIndexData(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/indexes/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetListTypeIndexDataResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetChildIndexesResponseItem[]> GetChildIndexes(Expression<Func<string>> indexId, Expression<Func<string>> listId, Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = String.Format("/api/v1/indexes/{0}/values/childindexlist/{1}", ExpressionConverter.ConvertWithUrlEncoding(indexId, 1), ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<GetChildIndexesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<LoginResponse> Login(Expression<Func<string>> bodyLoginName, Expression<Func<string>> bodyPassword)
        {
            var apiCallPath = "/api/v1/user/login";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["LoginName"] = ExpressionConverter.ConvertO(bodyLoginName);
            bodypropCount++;
            body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LoginResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<LogoutResponse> Logout(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/user/logout";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<LogoutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<bool> ValidateToken(Expression<Func<string>> xAuthorization = null)
        {
            var apiCallPath = "/api/v1/user/validate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteMasterDeliverableResponseItem[]> DeleteMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyServiceType = null, Expression<Func<string>> bodyDrawerName = null, Expression<Func<string[]>> bodyDeliverableNames = null)
        {
            var apiCallPath = "/firmflow/api/v1/Deliverable/DeleteDeliverableList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyServiceType != null)
            {
                body["ServiceType"] = ExpressionConverter.ConvertO(bodyServiceType);
                bodypropCount++;
            }

            if (bodyDrawerName != null)
            {
                body["DrawerName"] = ExpressionConverter.ConvertO(bodyDrawerName);
                bodypropCount++;
            }

            if (bodyDeliverableNames != null)
            {
                body["DeliverableNames"] = ExpressionConverter.ConvertO(bodyDeliverableNames);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeleteMasterDeliverableResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteWorkflowsResponse> DeleteWorkflows(Expression<Func<string>> xAuthorization = null, Expression<Func<int[]>> bodyfilingId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<EditMasterDeliverableResponse> EditMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodycurrentdeliverableName = null, Expression<Func<string>> bodyupdatedeliverableName = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyfirstExtension = null, Expression<Func<string>> bodysecondExtension = null, Expression<Func<string>> bodythirdExtension = null, Expression<Func<string>> bodycalenderOrFiscal = null, Expression<Func<int>> bodyextension = null, Expression<Func<string>> bodyserviceType = null, Expression<Func<string>> bodydrawerName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<EditWorkflowResponse> EditWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<int>> bodyfilingId = null, Expression<Func<string>> bodyHeadersClientName = null, Expression<Func<string>> bodyHeadersClientNumber = null, Expression<Func<string>> bodyHeadersEngagementType = null, Expression<Func<string>> bodyHeadersPIC = null, Expression<Func<string>> bodyHeadersYear = null, Expression<Func<string>> bodyHeadersPeriodEnd = null, Expression<Func<string>> bodydeliverableaction = null, Expression<Func<string>> bodydeliverablecurrentduedate = null, Expression<Func<string>> bodydeliverableoriginalduedate = null, Expression<Func<string>> bodydeliverableform = null, Expression<Func<string>> bodynotesaction = null, Expression<Func<string>> bodynotesnoteType = null, Expression<Func<string[]>> bodynotesnoteid = null, Expression<Func<string>> bodynotesnote = null, Expression<Func<string>> bodyinformationFieldsname = null, Expression<Func<string>> bodyinformationFieldsvalue = null, Expression<Func<string>> bodydeliveryInstructionsDelivery = null, Expression<Func<string>> bodydeliveryInstructionsDestination = null, Expression<Func<string>> bodydeliveryInstructionssourceDocument = null, Expression<Func<string>> bodyroutingSummaryresponsibleField = null, Expression<Func<string>> bodyroutingSummaryvalue = null, Expression<Func<bool>> bodyreindexDocs = null)
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

            var HeadersObject = new JObject();
            var HeadersObjectpropCount = 0;
            if (bodyHeadersClientName != null)
            {
                HeadersObject["ClientName"] = ExpressionConverter.ConvertO(bodyHeadersClientName);
                HeadersObjectpropCount++;
            }

            if (bodyHeadersClientNumber != null)
            {
                HeadersObject["ClientNumber"] = ExpressionConverter.ConvertO(bodyHeadersClientNumber);
                HeadersObjectpropCount++;
            }

            if (bodyHeadersEngagementType != null)
            {
                HeadersObject["EngagementType"] = ExpressionConverter.ConvertO(bodyHeadersEngagementType);
                HeadersObjectpropCount++;
            }

            if (bodyHeadersPIC != null)
            {
                HeadersObject["PIC"] = ExpressionConverter.ConvertO(bodyHeadersPIC);
                HeadersObjectpropCount++;
            }

            if (bodyHeadersYear != null)
            {
                HeadersObject["Year"] = ExpressionConverter.ConvertO(bodyHeadersYear);
                HeadersObjectpropCount++;
            }

            if (bodyHeadersPeriodEnd != null)
            {
                HeadersObject["PeriodEnd"] = ExpressionConverter.ConvertO(bodyHeadersPeriodEnd);
                HeadersObjectpropCount++;
            }

            if (HeadersObjectpropCount > 0)
            {
                body["Headers"] = HeadersObject;
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
            if (bodydeliveryInstructionsDelivery != null)
            {
                deliveryInstructionsObject["Delivery"] = ExpressionConverter.ConvertO(bodydeliveryInstructionsDelivery);
                deliveryInstructionsObjectpropCount++;
            }

            if (bodydeliveryInstructionsDestination != null)
            {
                deliveryInstructionsObject["Destination"] = ExpressionConverter.ConvertO(bodydeliveryInstructionsDestination);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetMasterDeliverableResponse> GetMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<int>> bodyPageNumber = null, Expression<Func<int>> bodypageSize = null, Expression<Func<string>> bodyServiceType = null, Expression<Func<string>> bodyDrawerName = null)
        {
            var apiCallPath = "/firmflow/api/v1/Deliverable/GetDeliverableList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPageNumber != null)
            {
                body["PageNumber"] = ExpressionConverter.ConvertO(bodyPageNumber);
                bodypropCount++;
            }

            if (bodypageSize != null)
            {
                body["pageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                bodypropCount++;
            }

            if (bodyServiceType != null)
            {
                body["ServiceType"] = ExpressionConverter.ConvertO(bodyServiceType);
                bodypropCount++;
            }

            if (bodyDrawerName != null)
            {
                body["DrawerName"] = ExpressionConverter.ConvertO(bodyDrawerName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetMasterDeliverableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<RouteWorkflowV2Response> RouteWorkflowV2(Expression<Func<string>> xAuthorization = null, Expression<Func<int[]>> bodyfilingId = null, Expression<Func<string[]>> bodyCurrentStep = null, Expression<Func<bool>> bodyComplete = null, Expression<Func<string>> bodyCompletedDate = null, Expression<Func<string>> bodyNextStep = null, Expression<Func<string>> bodyAssignedTo = null, Expression<Func<string>> bodyAssignedDate = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyRoutingNote = null, Expression<Func<bool>> bodyemailNotify = null)
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

            if (bodyCurrentStep != null)
            {
                body["CurrentStep"] = ExpressionConverter.ConvertO(bodyCurrentStep);
                bodypropCount++;
            }

            if (bodyComplete != null)
            {
                body["Complete"] = ExpressionConverter.ConvertO(bodyComplete);
                bodypropCount++;
            }

            if (bodyCompletedDate != null)
            {
                body["CompletedDate"] = ExpressionConverter.ConvertO(bodyCompletedDate);
                bodypropCount++;
            }

            if (bodyNextStep != null)
            {
                body["NextStep"] = ExpressionConverter.ConvertO(bodyNextStep);
                bodypropCount++;
            }

            if (bodyAssignedTo != null)
            {
                body["AssignedTo"] = ExpressionConverter.ConvertO(bodyAssignedTo);
                bodypropCount++;
            }

            if (bodyAssignedDate != null)
            {
                body["AssignedDate"] = ExpressionConverter.ConvertO(bodyAssignedDate);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyRoutingNote != null)
            {
                body["RoutingNote"] = ExpressionConverter.ConvertO(bodyRoutingNote);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TrackingReportByWorkflowResponse> TrackingReportByWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyDrawerId = null, Expression<Func<string>> bodyServiceType = null, Expression<Func<string>> bodyEngagementType = null, Expression<Func<string>> bodyWorkflow = null, Expression<Func<string>> bodyCurrentStep = null, Expression<Func<string>> bodyPIC = null, Expression<Func<string>> bodyAssignedTo = null, Expression<Func<string>> bodyAssignedOn = null, Expression<Func<string>> bodyWorkflowDescription = null, Expression<Func<string>> bodyInProcessOnly = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodyResponsible = null, Expression<Func<string>> bodyAssignmentHistory = null, Expression<Func<string>> bodyReceivedFrom = null, Expression<Func<string>> bodyReceivedOn = null, Expression<Func<string>> bodySentTo = null, Expression<Func<string>> bodySentOn = null, Expression<Func<string>> bodyCompletedBy = null, Expression<Func<string>> bodyCompletedOn = null, Expression<Func<string>> bodyCurrentDueDate = null, Expression<Func<string>> bodyDaysAtStep = null, Expression<Func<string>> bodyTotalDaysAtStep = null, Expression<Func<string>> bodyDaysBetweenRoutings = null, Expression<Func<string>> bodyTotalDaysInProcess = null, Expression<Func<string>> bodyAccountable = null, Expression<Func<string>> bodyRoutingDetails = null, Expression<Func<string>> bodyLastUpdated = null, Expression<Func<string[]>> bodyInformationFields = null, Expression<Func<string[]>> bodyIndexes = null, Expression<Func<string>> bodyPageNumber = null)
        {
            var apiCallPath = "/api/v1/firmflowreports/TrackingReportByWorkflow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDrawerId != null)
            {
                body["DrawerId"] = ExpressionConverter.ConvertO(bodyDrawerId);
                bodypropCount++;
            }

            if (bodyServiceType != null)
            {
                body["ServiceType"] = ExpressionConverter.ConvertO(bodyServiceType);
                bodypropCount++;
            }

            if (bodyEngagementType != null)
            {
                body["EngagementType"] = ExpressionConverter.ConvertO(bodyEngagementType);
                bodypropCount++;
            }

            if (bodyWorkflow != null)
            {
                body["Workflow"] = ExpressionConverter.ConvertO(bodyWorkflow);
                bodypropCount++;
            }

            if (bodyCurrentStep != null)
            {
                body["CurrentStep"] = ExpressionConverter.ConvertO(bodyCurrentStep);
                bodypropCount++;
            }

            if (bodyPIC != null)
            {
                body["PIC"] = ExpressionConverter.ConvertO(bodyPIC);
                bodypropCount++;
            }

            if (bodyAssignedTo != null)
            {
                body["AssignedTo"] = ExpressionConverter.ConvertO(bodyAssignedTo);
                bodypropCount++;
            }

            if (bodyAssignedOn != null)
            {
                body["AssignedOn"] = ExpressionConverter.ConvertO(bodyAssignedOn);
                bodypropCount++;
            }

            if (bodyWorkflowDescription != null)
            {
                body["WorkflowDescription"] = ExpressionConverter.ConvertO(bodyWorkflowDescription);
                bodypropCount++;
            }

            if (bodyInProcessOnly != null)
            {
                body["InProcessOnly"] = ExpressionConverter.ConvertO(bodyInProcessOnly);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyResponsible != null)
            {
                body["Responsible"] = ExpressionConverter.ConvertO(bodyResponsible);
                bodypropCount++;
            }

            if (bodyAssignmentHistory != null)
            {
                body["AssignmentHistory"] = ExpressionConverter.ConvertO(bodyAssignmentHistory);
                bodypropCount++;
            }

            if (bodyReceivedFrom != null)
            {
                body["ReceivedFrom"] = ExpressionConverter.ConvertO(bodyReceivedFrom);
                bodypropCount++;
            }

            if (bodyReceivedOn != null)
            {
                body["ReceivedOn"] = ExpressionConverter.ConvertO(bodyReceivedOn);
                bodypropCount++;
            }

            if (bodySentTo != null)
            {
                body["SentTo"] = ExpressionConverter.ConvertO(bodySentTo);
                bodypropCount++;
            }

            if (bodySentOn != null)
            {
                body["SentOn"] = ExpressionConverter.ConvertO(bodySentOn);
                bodypropCount++;
            }

            if (bodyCompletedBy != null)
            {
                body["CompletedBy"] = ExpressionConverter.ConvertO(bodyCompletedBy);
                bodypropCount++;
            }

            if (bodyCompletedOn != null)
            {
                body["CompletedOn"] = ExpressionConverter.ConvertO(bodyCompletedOn);
                bodypropCount++;
            }

            if (bodyCurrentDueDate != null)
            {
                body["CurrentDueDate"] = ExpressionConverter.ConvertO(bodyCurrentDueDate);
                bodypropCount++;
            }

            if (bodyDaysAtStep != null)
            {
                body["DaysAtStep"] = ExpressionConverter.ConvertO(bodyDaysAtStep);
                bodypropCount++;
            }

            if (bodyTotalDaysAtStep != null)
            {
                body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(bodyTotalDaysAtStep);
                bodypropCount++;
            }

            if (bodyDaysBetweenRoutings != null)
            {
                body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(bodyDaysBetweenRoutings);
                bodypropCount++;
            }

            if (bodyTotalDaysInProcess != null)
            {
                body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(bodyTotalDaysInProcess);
                bodypropCount++;
            }

            if (bodyAccountable != null)
            {
                body["Accountable"] = ExpressionConverter.ConvertO(bodyAccountable);
                bodypropCount++;
            }

            if (bodyRoutingDetails != null)
            {
                body["RoutingDetails"] = ExpressionConverter.ConvertO(bodyRoutingDetails);
                bodypropCount++;
            }

            if (bodyLastUpdated != null)
            {
                body["LastUpdated"] = ExpressionConverter.ConvertO(bodyLastUpdated);
                bodypropCount++;
            }

            if (bodyInformationFields != null)
            {
                body["InformationFields"] = ExpressionConverter.ConvertO(bodyInformationFields);
                bodypropCount++;
            }

            if (bodyIndexes != null)
            {
                body["Indexes"] = ExpressionConverter.ConvertO(bodyIndexes);
                bodypropCount++;
            }

            if (bodyPageNumber != null)
            {
                body["PageNumber"] = ExpressionConverter.ConvertO(bodyPageNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TrackingReportByWorkflowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<AddMasterDeliverableResponse> AddMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodydeliverableName = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyfirstExtension = null, Expression<Func<string>> bodysecondExtension = null, Expression<Func<string>> bodythirdExtension = null, Expression<Func<string>> bodycalenderOrFiscal = null, Expression<Func<int>> bodyextension = null, Expression<Func<string>> bodyServiceType = null, Expression<Func<string>> bodyDrawerName = null)
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

            if (bodyServiceType != null)
            {
                body["ServiceType"] = ExpressionConverter.ConvertO(bodyServiceType);
                bodypropCount++;
            }

            if (bodyDrawerName != null)
            {
                body["DrawerName"] = ExpressionConverter.ConvertO(bodyDrawerName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddMasterDeliverableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserInfoV2Response> GetUserInfoV2(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyLoginName = null, Expression<Func<string>> bodyUserType = null)
        {
            var apiCallPath = "/api/v2/administration/user/getuser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyLoginName != null)
            {
                body["LoginName"] = ExpressionConverter.ConvertO(bodyLoginName);
                bodypropCount++;
            }

            if (bodyUserType != null)
            {
                body["UserType"] = ExpressionConverter.ConvertO(bodyUserType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetUserInfoV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TrackingReportByDeliverableV2Response> TrackingReportByDeliverableV2(Expression<Func<string>> xAuthorization = null, Expression<Func<string>> bodyDrawerId = null, Expression<Func<string>> bodyServiceType = null, Expression<Func<string>> bodyEngagementType = null, Expression<Func<string>> bodyWorkflow = null, Expression<Func<string>> bodyCurrentStep = null, Expression<Func<string>> bodyPIC = null, Expression<Func<string>> bodyAssignedTo = null, Expression<Func<string>> bodyAssignedOn = null, Expression<Func<string>> bodyWorkflowDescription = null, Expression<Func<string>> bodyInProcessOnly = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodyReceivedOn = null, Expression<Func<string>> bodyCompletedOn = null, Expression<Func<string>> bodySentOn = null, Expression<Func<string>> bodyResponsible = null, Expression<Func<string>> bodyAssignmentHistory = null, Expression<Func<string>> bodyReceivedFrom = null, Expression<Func<string>> bodySentTo = null, Expression<Func<string>> bodyCompletedBy = null, Expression<Func<string>> bodyAccountable = null, Expression<Func<string>> bodyCurrentDueDate = null, Expression<Func<string>> bodyOriginalDueDate = null, Expression<Func<string>> bodyDateExtended = null, Expression<Func<string>> bodyDaysAtStep = null, Expression<Func<string>> bodyTotalDaysAtStep = null, Expression<Func<string>> bodyDaysBetweenRoutings = null, Expression<Func<string>> bodyTotalDaysInProcess = null, Expression<Func<string>> bodyRoutingDetails = null, Expression<Func<string>> bodyLastUpdated = null, Expression<Func<string[]>> bodyInformationFields = null, Expression<Func<string[]>> bodyIndexes = null, Expression<Func<string>> bodyPageNumber = null)
        {
            var apiCallPath = "/api/v2/firmflowreports/TrackingReportByDeliverable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xAuthorization != null)
                callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(xAuthorization);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDrawerId != null)
            {
                body["DrawerId"] = ExpressionConverter.ConvertO(bodyDrawerId);
                bodypropCount++;
            }

            if (bodyServiceType != null)
            {
                body["ServiceType"] = ExpressionConverter.ConvertO(bodyServiceType);
                bodypropCount++;
            }

            if (bodyEngagementType != null)
            {
                body["EngagementType"] = ExpressionConverter.ConvertO(bodyEngagementType);
                bodypropCount++;
            }

            if (bodyWorkflow != null)
            {
                body["Workflow"] = ExpressionConverter.ConvertO(bodyWorkflow);
                bodypropCount++;
            }

            if (bodyCurrentStep != null)
            {
                body["CurrentStep"] = ExpressionConverter.ConvertO(bodyCurrentStep);
                bodypropCount++;
            }

            if (bodyPIC != null)
            {
                body["PIC"] = ExpressionConverter.ConvertO(bodyPIC);
                bodypropCount++;
            }

            if (bodyAssignedTo != null)
            {
                body["AssignedTo"] = ExpressionConverter.ConvertO(bodyAssignedTo);
                bodypropCount++;
            }

            if (bodyAssignedOn != null)
            {
                body["AssignedOn"] = ExpressionConverter.ConvertO(bodyAssignedOn);
                bodypropCount++;
            }

            if (bodyWorkflowDescription != null)
            {
                body["WorkflowDescription"] = ExpressionConverter.ConvertO(bodyWorkflowDescription);
                bodypropCount++;
            }

            if (bodyInProcessOnly != null)
            {
                body["InProcessOnly"] = ExpressionConverter.ConvertO(bodyInProcessOnly);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyReceivedOn != null)
            {
                body["ReceivedOn"] = ExpressionConverter.ConvertO(bodyReceivedOn);
                bodypropCount++;
            }

            if (bodyCompletedOn != null)
            {
                body["CompletedOn"] = ExpressionConverter.ConvertO(bodyCompletedOn);
                bodypropCount++;
            }

            if (bodySentOn != null)
            {
                body["SentOn"] = ExpressionConverter.ConvertO(bodySentOn);
                bodypropCount++;
            }

            if (bodyResponsible != null)
            {
                body["Responsible"] = ExpressionConverter.ConvertO(bodyResponsible);
                bodypropCount++;
            }

            if (bodyAssignmentHistory != null)
            {
                body["AssignmentHistory"] = ExpressionConverter.ConvertO(bodyAssignmentHistory);
                bodypropCount++;
            }

            if (bodyReceivedFrom != null)
            {
                body["ReceivedFrom"] = ExpressionConverter.ConvertO(bodyReceivedFrom);
                bodypropCount++;
            }

            if (bodySentTo != null)
            {
                body["SentTo"] = ExpressionConverter.ConvertO(bodySentTo);
                bodypropCount++;
            }

            if (bodyCompletedBy != null)
            {
                body["CompletedBy"] = ExpressionConverter.ConvertO(bodyCompletedBy);
                bodypropCount++;
            }

            if (bodyAccountable != null)
            {
                body["Accountable"] = ExpressionConverter.ConvertO(bodyAccountable);
                bodypropCount++;
            }

            if (bodyCurrentDueDate != null)
            {
                body["CurrentDueDate"] = ExpressionConverter.ConvertO(bodyCurrentDueDate);
                bodypropCount++;
            }

            if (bodyOriginalDueDate != null)
            {
                body["OriginalDueDate"] = ExpressionConverter.ConvertO(bodyOriginalDueDate);
                bodypropCount++;
            }

            if (bodyDateExtended != null)
            {
                body["DateExtended"] = ExpressionConverter.ConvertO(bodyDateExtended);
                bodypropCount++;
            }

            if (bodyDaysAtStep != null)
            {
                body["DaysAtStep"] = ExpressionConverter.ConvertO(bodyDaysAtStep);
                bodypropCount++;
            }

            if (bodyTotalDaysAtStep != null)
            {
                body["TotalDaysAtStep"] = ExpressionConverter.ConvertO(bodyTotalDaysAtStep);
                bodypropCount++;
            }

            if (bodyDaysBetweenRoutings != null)
            {
                body["DaysBetweenRoutings"] = ExpressionConverter.ConvertO(bodyDaysBetweenRoutings);
                bodypropCount++;
            }

            if (bodyTotalDaysInProcess != null)
            {
                body["TotalDaysInProcess"] = ExpressionConverter.ConvertO(bodyTotalDaysInProcess);
                bodypropCount++;
            }

            if (bodyRoutingDetails != null)
            {
                body["RoutingDetails"] = ExpressionConverter.ConvertO(bodyRoutingDetails);
                bodypropCount++;
            }

            if (bodyLastUpdated != null)
            {
                body["LastUpdated"] = ExpressionConverter.ConvertO(bodyLastUpdated);
                bodypropCount++;
            }

            if (bodyInformationFields != null)
            {
                body["InformationFields"] = ExpressionConverter.ConvertO(bodyInformationFields);
                bodypropCount++;
            }

            if (bodyIndexes != null)
            {
                body["Indexes"] = ExpressionConverter.ConvertO(bodyIndexes);
                bodypropCount++;
            }

            if (bodyPageNumber != null)
            {
                body["PageNumber"] = ExpressionConverter.ConvertO(bodyPageNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TrackingReportByDeliverableV2Response>(callPayload);
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

    public class bodyReportsInputItem
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

    public class bodyDocumentSecurityInputItem
    {
        public bodyDocumentSecurityInputItemDocSecurityTypeType DocSecurityType { get; set; }
        public string IndexName { get; set; }
        public bodyDocumentSecurityInputItemOperationType Operation { get; set; }
        public string[] Values { get; set; }
    }

    public enum bodyDocumentSecurityInputItemDocSecurityTypeType
    {
        [EnumMember(Value = "DENY ACCESS")]
        DENYACCESS,
        [EnumMember(Value = "ALLOW ACCESS")]
        ALLOWACCESS,
        [EnumMember(Value = "NO EDIT")]
        NOEDIT
    }

    public enum bodyDocumentSecurityInputItemOperationType
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

    public class bodyDrawerPermissionsInputItem
    {
        public string Drawer { get; set; }
        public bodyDrawerPermissionsInputItemPermissionType Permission { get; set; }
    }

    public class bodyDrawerPermissionsInputItemPermissionType
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

    public enum bodyUserTypeInput
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

    public class bodyDocumentSecurityInputItem2
    {
        public bodyDocumentSecurityInputItemDocSecurityTypeType DocSecurityType { get; set; }
        public string IndexName { get; set; }
        public bodyDocumentSecurityInputItemOperationType Operation { get; set; }
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

    public class bodyIndexesInputItem
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

    public class bodyIndexValuesInputItem
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

    public class bodyFilterIndexValuesInputItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
    }

    public enum bodySortOrderInput
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

    public enum bodyActionTypeInput
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

    public enum bodySearchTypeInput
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

    public class RouteWorkflowV2Response
    {
        [JsonProperty("filingId")]
        public string FilingId { get; set; }

        [JsonProperty("isRouted")]
        public bool IsRouted { get; set; }
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

    public class GetUserInfoV2Response
    {
        [JsonProperty("userID")]
        public string UserID { get; set; }

        [JsonProperty("loginID")]
        public string LoginID { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

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

        [JsonProperty("passwordExpireDate")]
        public string PasswordExpireDate { get; set; }

        [JsonProperty("forcePasswordChange")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("passwordChangeDate")]
        public string PasswordChangeDate { get; set; }

        [JsonProperty("passwordChangeInterval")]
        public int PasswordChangeInterval { get; set; }

        [JsonProperty("licenseType")]
        public string LicenseType { get; set; }

        [JsonProperty("offline")]
        public bool Offline { get; set; }

        [JsonProperty("reports")]
        public bool Reports { get; set; }

        [JsonProperty("systemAdmin")]
        public bool SystemAdmin { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("locationID")]
        public string LocationID { get; set; }

        [JsonProperty("hasDrawerSetupRights")]
        public string HasDrawerSetupRights { get; set; }

        [JsonProperty("taxFlow")]
        public bool TaxFlow { get; set; }

        [JsonProperty("emailNotify")]
        public bool EmailNotify { get; set; }

        [JsonProperty("emailNotifyGroup")]
        public bool EmailNotifyGroup { get; set; }

        [JsonProperty("emailNotifyEventMgmtUsers")]
        public bool EmailNotifyEventMgmtUsers { get; set; }

        [JsonProperty("emailNotifyEventMgmtGroups")]
        public bool EmailNotifyEventMgmtGroups { get; set; }

        [JsonProperty("portalUserAdministration")]
        public bool PortalUserAdministration { get; set; }

        [JsonProperty("internalUserAdministration")]
        public bool InternalUserAdministration { get; set; }

        [JsonProperty("workflowManagerUser")]
        public bool WorkflowManagerUser { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("managerLoginId")]
        public string ManagerLoginId { get; set; }

        [JsonProperty("managerFullName")]
        public string ManagerFullName { get; set; }

        [JsonProperty("isManager")]
        public int IsManager { get; set; }

        [JsonProperty("oberonUser")]
        public int OberonUser { get; set; }

        [JsonProperty("isAdmin")]
        public int IsAdmin { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("groups")]
        public string[] Groups { get; set; }
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