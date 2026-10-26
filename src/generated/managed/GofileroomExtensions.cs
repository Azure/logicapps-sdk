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
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<string>> xAuthorization = null, Expression<Func<CreateGroupInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/creategroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetGroupDocSecurityResponse, ApiConnectionActionConfiguration> SetGroupDocSecurity(Expression<Func<string>> xAuthorization = null, Expression<Func<SetGroupDocSecurityInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SetGroupDocSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/documentsecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetGroupDocSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ModifyGroupResponse, ApiConnectionActionConfiguration> ModifyGroup(Expression<Func<string>> xAuthorization = null, Expression<Func<ModifyGroupInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ModifyGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/modifygroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModifyGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupPermissionsResponse, ApiConnectionActionConfiguration> GetGroupPermissions(Expression<Func<string>> groupName = null, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_groupName = WorkflowExpression.Compile(groupName, nameof(groupName), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupPermissionsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SetGroupPermissionsResponse, ApiConnectionActionConfiguration> SetGroupPermissions(Expression<Func<string>> xAuthorization = null, Expression<Func<SetGroupPermissionsInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SetGroupPermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/group/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetGroupPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetGroupDocumentSecurityResponse, ApiConnectionActionConfiguration> GetGroupDocumentSecurity(Expression<Func<string>> groupName, Expression<Func<string>> cabinetName, Expression<Func<string>> drawerName, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_groupName = WorkflowExpression.Compile(groupName, nameof(groupName), required: true);
            var __workflow_cabinetName = WorkflowExpression.Compile(cabinetName, nameof(cabinetName), required: true);
            var __workflow_drawerName = WorkflowExpression.Compile(drawerName, nameof(drawerName), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupDocumentSecurityResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetGroupsResponseItem[], ApiConnectionActionConfiguration> GetGroups(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetGroupsResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateUsersResponse, ApiConnectionActionConfiguration> CreateUsers(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null, Expression<Func<CreateUsersInput>> body = null)
        {
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/createuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userType"] = Convert.ToString("GFRUSERS");
                if (__workflow_userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(__workflow_userType);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteUserResponse, ApiConnectionActionConfiguration> DeleteUser(Expression<Func<string>> xAuthorization = null, Expression<Func<DeleteUserInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<SetUserDocSecurityResponse, ApiConnectionActionConfiguration> SetUserDocSecurity(Expression<Func<string>> xAuthorization = null, Expression<Func<SetUserDocSecurityInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SetUserDocSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/documentsecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetUserDocSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetLicensesResponse, ApiConnectionActionConfiguration> GetLicenses(Expression<Func<licenseInput>> license = null, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_license = WorkflowExpression.Compile(license, nameof(license), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetLicensesResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ModifyUserResponse, ApiConnectionActionConfiguration> ModifyUser(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null, Expression<Func<ModifyUserInput>> body = null)
        {
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ModifyUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/modifyuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userType != null)
                    callPayload.Queries["userType"] = ExpressionConverter.Convert(__workflow_userType);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModifyUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetPasswordPolicyResponse, ApiConnectionActionConfiguration> GetPasswordPolicy(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetPasswordPolicyResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SetUserPermissionsResponse, ApiConnectionActionConfiguration> SetUserPermissions(Expression<Func<string>> xAuthorization = null, Expression<Func<SetUserPermissionsInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SetUserPermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/administration/user/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetUserPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetListOfReportsResponse, ApiConnectionActionConfiguration> GetListOfReports(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetListOfReportsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetUploadLocationResponse, ApiConnectionActionConfiguration> GetUploadLocation(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUploadLocationResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetUserDocumentSecurityResponse, ApiConnectionActionConfiguration> GetUserDocumentSecurity(Expression<Func<string>> loginId, Expression<Func<string>> cabinetName, Expression<Func<string>> drawerName, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_loginId = WorkflowExpression.Compile(loginId, nameof(loginId), required: true);
            var __workflow_cabinetName = WorkflowExpression.Compile(cabinetName, nameof(cabinetName), required: true);
            var __workflow_drawerName = WorkflowExpression.Compile(drawerName, nameof(drawerName), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserDocumentSecurityResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetUserPermissionResponse, ApiConnectionActionConfiguration> GetUserPermission(Expression<Func<string>> login, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_login = WorkflowExpression.Compile(login, nameof(login), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUserPermissionResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetUsersResponseItem[], ApiConnectionActionConfiguration> GetUsers(Expression<Func<userTypeInput>> userType = null, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetUsersResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetLookupListResponseItem[], ApiConnectionActionConfiguration> GetLookupList(Expression<Func<string>> drawerId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_drawerId = WorkflowExpression.Compile(drawerId, nameof(drawerId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetLookupListResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateDocumentResponse, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<CreateDocumentInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<CopyDocumentResponseItem[], ApiConnectionActionConfiguration> CopyDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<CopyDocumentInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CopyDocumentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents/copy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CopyDocumentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDocumentStatusResponseItem[], ApiConnectionActionConfiguration> GetDocumentStatus(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetDocumentStatusResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetDocumentStatusResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergePDF(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents/mergePDFs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentReindexResponseItem[], ApiConnectionActionConfiguration> DocumentReindex(Expression<Func<string>> xAuthorization = null, Expression<Func<DocumentReindexInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DocumentReindexResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents/reindex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentReindexResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentSearchResponse, ApiConnectionActionConfiguration> DocumentSearch(Expression<Func<string>> xAuthorization = null, Expression<Func<DocumentSearchInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DocumentSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TaxsortDocumentResponseItem[], ApiConnectionActionConfiguration> TaxsortDocument(Expression<Func<string>> xAuthorization = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaxsortDocumentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/documents/taxsort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaxsortDocumentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DocumentDeleteResponseItem[], ApiConnectionActionConfiguration> DocumentDelete(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<DocumentDeleteResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetDocumentHistoryResponse, ApiConnectionActionConfiguration> GetDocumentHistory(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDocumentHistoryResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetDocumentIndexesResponseItem[], ApiConnectionActionConfiguration> GetDocumentIndexes(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDocumentIndexesResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<PublishDocumentStatusResponseItem[], ApiConnectionActionConfiguration> PublishDocumentStatus(Expression<Func<string>> documentId, Expression<Func<string>> xAuthorization = null, Expression<Func<PublishDocumentStatusInput>> body = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PublishDocumentStatusResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/status", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PublishDocumentStatusResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDrawersResponseItem[], ApiConnectionActionConfiguration> GetDrawers(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDrawersResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetDrawerIndexesResponseItem[], ApiConnectionActionConfiguration> GetDrawerIndexes(Expression<Func<string>> drawerId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_drawerId = WorkflowExpression.Compile(drawerId, nameof(drawerId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDrawerIndexesResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetFirmFlowDeliverableReportResponse, ApiConnectionActionConfiguration> GetFirmFlowDeliverableReport(Expression<Func<string>> xAuthorization = null, Expression<Func<GetFirmFlowDeliverableReportInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetFirmFlowDeliverableReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/firmflowreports/TrackingReportByDeliverable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetFirmFlowDeliverableReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<ValidateIndexesResponse, ApiConnectionActionConfiguration> ValidateIndexes(Expression<Func<string>> xAuthorization = null, Expression<Func<ValidateIndexesInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ValidateIndexesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/indexes/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateIndexesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetDynamicRulesForIndexResponseItem[], ApiConnectionActionConfiguration> GetDynamicRulesForIndex(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetDynamicRulesForIndexResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<IndexLookupListFindResponseItem[], ApiConnectionActionConfiguration> IndexLookupListFind(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null, Expression<Func<IndexLookupListFindInput>> body = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IndexLookupListFindResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/indexes/{0}/lookuplist", __workflow_indexId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IndexLookupListFindResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetListTypeIndexDataResponseItem[], ApiConnectionActionConfiguration> GetListTypeIndexData(Expression<Func<string>> indexId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetListTypeIndexDataResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetChildIndexesResponseItem[], ApiConnectionActionConfiguration> GetChildIndexes(Expression<Func<string>> indexId, Expression<Func<string>> listId, Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_indexId = WorkflowExpression.Compile(indexId, nameof(indexId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<GetChildIndexesResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<LoginResponse, ApiConnectionActionConfiguration> Login(Expression<Func<LoginInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoginResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/user/login";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<LogoutResponse, ApiConnectionActionConfiguration> Logout(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<LogoutResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ValidateToken(Expression<Func<string>> xAuthorization = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateWorkflowResponse, ApiConnectionActionConfiguration> CreateWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<CreateWorkflowInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/CreateWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteMasterDeliverableResponseItem[], ApiConnectionActionConfiguration> DeleteMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<DeleteMasterDeliverableInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteMasterDeliverableResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/DeleteDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteMasterDeliverableResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<DeleteWorkflowsResponse, ApiConnectionActionConfiguration> DeleteWorkflows(Expression<Func<string>> xAuthorization = null, Expression<Func<DeleteWorkflowsInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteWorkflowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/DeleteWorkflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteWorkflowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<EditMasterDeliverableResponse, ApiConnectionActionConfiguration> EditMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<EditMasterDeliverableInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EditMasterDeliverableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/UpdateDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EditMasterDeliverableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<EditWorkflowResponse, ApiConnectionActionConfiguration> EditWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<EditWorkflowInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EditWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/V1/Workflow/EditWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EditWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetMasterDeliverableResponse, ApiConnectionActionConfiguration> GetMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<GetMasterDeliverableInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetMasterDeliverableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/GetDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetMasterDeliverableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TrackingReportByWorkflowResponse, ApiConnectionActionConfiguration> TrackingReportByWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<TrackingReportByWorkflowInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TrackingReportByWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/firmflowreports/TrackingReportByWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TrackingReportByWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<AddMasterDeliverableResponse, ApiConnectionActionConfiguration> AddMasterDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<AddMasterDeliverableInput>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddMasterDeliverableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/v1/Deliverable/SaveDeliverableList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddMasterDeliverableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<GetUserInfoV2Response, ApiConnectionActionConfiguration> GetUserInfo(Expression<Func<string>> xAuthorization = null, Expression<Func<GetUserInfoV2Input>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetUserInfoV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/administration/user/getuser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetUserInfoV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<RouteWorkflowV2Response, ApiConnectionActionConfiguration> RouteWorkflow(Expression<Func<string>> xAuthorization = null, Expression<Func<RouteWorkflowV2Input>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RouteWorkflowV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/firmflow/api/V2/Route";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RouteWorkflowV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gofileroom")]
        public IBodyWorkflowAction<TrackingReportByDeliverableV2Response, ApiConnectionActionConfiguration> TrackingReportByDeliverable(Expression<Func<string>> xAuthorization = null, Expression<Func<TrackingReportByDeliverableV2Input>> body = null)
        {
            var __workflow_xAuthorization = WorkflowExpression.Compile(xAuthorization, nameof(xAuthorization), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TrackingReportByDeliverableV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/firmflowreports/TrackingReportByDeliverable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xAuthorization != null)
                    callPayload.Headers["X-Authorization"] = ExpressionConverter.Convert(__workflow_xAuthorization);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateGroupInput
    {
        public string AccessToApproveDocsOnly { get; set; }
        public string AllowAccessToReports { get; set; }
        public string Comments { get; set; }
        public string EnableMfa { get; set; }
        public string EnforceMfaForUsers { get; set; }
        public string FirmFlowRoutingNotification { get; set; }
        public string FullAccessToDocTracking { get; set; }
        public string GroupName { get; set; }
        public string MfaRequired { get; set; }
        public string PermissonToApproveDocs { get; set; }
        public CreateGroupInputReportsTypeItem[] Reports { get; set; }
        public string UploadLocation { get; set; }
        public string[] Users { get; set; }
    }

    public class CreateGroupInputReportsTypeItem
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

    public class SetGroupDocSecurityInput
    {
        public string CabinetName { get; set; }
        public SetGroupDocSecurityInputDocumentSecurityTypeItem[] DocumentSecurity { get; set; }
        public string DrawerName { get; set; }
        public string GroupName { get; set; }
    }

    public class SetGroupDocSecurityInputDocumentSecurityTypeItem
    {
        public SetGroupDocSecurityInputDocumentSecurityTypeItemDocSecurityTypeType? DocSecurityType { get; set; }
        public string IndexName { get; set; }
        public SetGroupDocSecurityInputDocumentSecurityTypeItemOperationType? Operation { get; set; }
        public string[] Values { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetGroupDocSecurityInputDocumentSecurityTypeItemDocSecurityTypeType
    {
        [EnumMember(Value = "DENY ACCESS")]
        DENYACCESS,
        [EnumMember(Value = "ALLOW ACCESS")]
        ALLOWACCESS,
        [EnumMember(Value = "NO EDIT")]
        NOEDIT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetGroupDocSecurityInputDocumentSecurityTypeItemOperationType
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

    public class ModifyGroupInput
    {
        public string AccessToApproveDocsOnly { get; set; }
        public string AllowAccessToReports { get; set; }
        public string Comments { get; set; }
        public string EnableMfa { get; set; }
        public string EnforceMfaForUsers { get; set; }
        public string FirmFlowRoutingNotification { get; set; }
        public string FullAccessToDocTracking { get; set; }
        public string GroupName { get; set; }
        public string MfaRequired { get; set; }
        public string PermissonToApproveDocs { get; set; }
        public string RenameGroup { get; set; }
        public ModifyGroupInputReportsTypeItem[] Reports { get; set; }
        public string UploadLocation { get; set; }
        public string[] Users { get; set; }
    }

    public class ModifyGroupInputReportsTypeItem
    {
        public string[] Allow { get; set; }
        public string[] Deny { get; set; }
        public string IsAllowAll { get; set; }
        public string IsDenyAll { get; set; }
        public string ReportType { get; set; }
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

    public class SetGroupPermissionsInput
    {
        public string Cabinet { get; set; }
        public SetGroupPermissionsInputCabinetPermissionType CabinetPermission { get; set; }
        public SetGroupPermissionsInputDrawerPermissionsTypeItem[] DrawerPermissions { get; set; }
        public string GroupName { get; set; }
    }

    public class SetGroupPermissionsInputCabinetPermissionType
    {
        public string Add { get; set; }
        public string Delete { get; set; }
        public string Deny { get; set; }
        public string Edit { get; set; }
        public string LookUp { get; set; }
        public string Read { get; set; }
    }

    public class SetGroupPermissionsInputDrawerPermissionsTypeItem
    {
        public string Drawer { get; set; }
        public SetGroupPermissionsInputDrawerPermissionsTypeItemPermissionType Permission { get; set; }
    }

    public class SetGroupPermissionsInputDrawerPermissionsTypeItemPermissionType
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

    public class CreateUsersInput
    {
        public string AccountExpiresDate { get; set; }
        public string DisabledComments { get; set; }
        public string FullName { get; set; }
        public string[] Groups { get; set; }
        public string IsAccountExpires { get; set; }
        public string IsAdvanceFlow { get; set; }
        public string IsAllowAccessToReports { get; set; }
        public string IsAllowOffline { get; set; }
        public string IsDisabled { get; set; }
        public string IsFirmFlow { get; set; }
        public string IsFirmFlowNotificationGroup { get; set; }
        public string IsFirmFlowNotificationUser { get; set; }
        public string IsMfa { get; set; }
        public string IsUserAdministration { get; set; }
        public string IsWorkflowManagerUser { get; set; }
        public string LicenseType { get; set; }
        public string LoginName { get; set; }
        public string ManagerEmail { get; set; }
        public string Password { get; set; }
        public CreateUsersInputReportsTypeItem[] Reports { get; set; }
        public string UploadLocation { get; set; }
    }

    public class CreateUsersInputReportsTypeItem
    {
        public string[] Allow { get; set; }
        public string[] Deny { get; set; }
        public string IsAllowAll { get; set; }
        public string IsDenyAll { get; set; }
        public string ReportType { get; set; }
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

    public class DeleteUserInput
    {
        public string LoginId { get; set; }
        public DeleteUserInputUserTypeType? UserType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteUserInputUserTypeType
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

    public class SetUserDocSecurityInput
    {
        public string CabinetName { get; set; }
        public SetUserDocSecurityInputDocumentSecurityTypeItem[] DocumentSecurity { get; set; }
        public string DrawerName { get; set; }
        public string LoginId { get; set; }
    }

    public class SetUserDocSecurityInputDocumentSecurityTypeItem
    {
        public SetUserDocSecurityInputDocumentSecurityTypeItemDocSecurityTypeType? DocSecurityType { get; set; }
        public string IndexName { get; set; }
        public SetUserDocSecurityInputDocumentSecurityTypeItemOperationType? Operation { get; set; }
        public string[] Values { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetUserDocSecurityInputDocumentSecurityTypeItemDocSecurityTypeType
    {
        [EnumMember(Value = "DENY ACCESS")]
        DENYACCESS,
        [EnumMember(Value = "ALLOW ACCESS")]
        ALLOWACCESS,
        [EnumMember(Value = "NO EDIT")]
        NOEDIT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetUserDocSecurityInputDocumentSecurityTypeItemOperationType
    {
        ADD,
        REMOVE,
        [EnumMember(Value = "CLEAR ALL")]
        CLEARALL
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

    public class ModifyUserInput
    {
        public string AccountExpiresDate { get; set; }
        public string DisabledComments { get; set; }
        public string FullName { get; set; }
        public string[] Groups { get; set; }
        public string IsAccountExpires { get; set; }
        public string IsAdvanceFlow { get; set; }
        public string IsAllowAccessToReports { get; set; }
        public string IsAllowOffline { get; set; }
        public string IsChangeNextLogin { get; set; }
        public string IsDisabled { get; set; }
        public string IsFirmFlow { get; set; }
        public string IsFirmFlowNotificationGroup { get; set; }
        public string IsFirmFlowNotificationUser { get; set; }
        public string IsMfa { get; set; }
        public string IsUserAdministration { get; set; }
        public string IsWorkflowManagerUser { get; set; }
        public string LicenseType { get; set; }
        public string LoginName { get; set; }
        public string ManagerEmail { get; set; }
        public string Password { get; set; }
        public ModifyUserInputReportsTypeItem[] Reports { get; set; }
        public string UploadLocation { get; set; }
    }

    public class ModifyUserInputReportsTypeItem
    {
        public string[] Allow { get; set; }
        public string[] Deny { get; set; }
        public string IsAllowAll { get; set; }
        public string IsDenyAll { get; set; }
        public string ReportType { get; set; }
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

    public class SetUserPermissionsInput
    {
        public string Cabinet { get; set; }
        public SetUserPermissionsInputCabinetPermissionType CabinetPermission { get; set; }
        public SetUserPermissionsInputDrawerPermissionsTypeItem[] DrawerPermissions { get; set; }
        public string LoginId { get; set; }
    }

    public class SetUserPermissionsInputCabinetPermissionType
    {
        public string Add { get; set; }
        public string Delete { get; set; }
        public string Deny { get; set; }
        public string Edit { get; set; }
        public string LookUp { get; set; }
        public string Read { get; set; }
    }

    public class SetUserPermissionsInputDrawerPermissionsTypeItem
    {
        public string Drawer { get; set; }
        public SetUserPermissionsInputDrawerPermissionsTypeItemPermissionType Permission { get; set; }
    }

    public class SetUserPermissionsInputDrawerPermissionsTypeItemPermissionType
    {
        public string Add { get; set; }
        public string Delete { get; set; }
        public string Deny { get; set; }
        public string Edit { get; set; }
        public string LookUp { get; set; }
        public string Read { get; set; }
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

    public class CreateDocumentInput
    {
        public string DrawerId { get; set; }
        public CreateDocumentInputIndexesTypeItem[] Indexes { get; set; }
    }

    public class CreateDocumentInputIndexesTypeItem
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

    public class CopyDocumentInput
    {
        public string[] DocumentIds { get; set; }
        public CopyDocumentInputIndexValuesTypeItem[] IndexValues { get; set; }
    }

    public class CopyDocumentInputIndexValuesTypeItem
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

    public class DocumentReindexInput
    {
        public string[] DocumentIds { get; set; }
        public DocumentReindexInputIndexValuesTypeItem[] IndexValues { get; set; }
    }

    public class DocumentReindexInputIndexValuesTypeItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
    }

    public class DocumentSearchResponse
    {
        [JsonProperty("documentIds")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("documentSearchCount")]
        public int DocumentSearchCount { get; set; }
    }

    public class DocumentSearchInput
    {
        public string DrawerId { get; set; }
        public DocumentSearchInputFilterType Filter { get; set; }
        public int? NumberOfRows { get; set; }
        public int? PageNumber { get; set; }
        public string SortField { get; set; }
        public DocumentSearchInputSortOrderType? SortOrder { get; set; }
    }

    public class DocumentSearchInputFilterType
    {
        public DocumentSearchInputFilterTypeIndexValuesTypeItem[] IndexValues { get; set; }
    }

    public class DocumentSearchInputFilterTypeIndexValuesTypeItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentSearchInputSortOrderType
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

    public class PublishDocumentStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IsPublished { get; set; }
    }

    public class GetDrawersResponseItem
    {
        [JsonProperty("drawerID")]
        public string DrawerId { get; set; }

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

    public class GetFirmFlowDeliverableReportInput
    {
        public string Accountable { get; set; }
        public string AssignedOn { get; set; }
        public string AssignedTo { get; set; }
        public string AssignmentHistory { get; set; }
        public string CompletedBy { get; set; }
        public string CompletedOn { get; set; }
        public string CurrentDueDate { get; set; }
        public string CurrentStep { get; set; }
        public string DateExtended { get; set; }
        public string DaysAtStep { get; set; }
        public string DaysBetweenRoutings { get; set; }
        public string DrawerId { get; set; }
        public string EngagementType { get; set; }
        public string InProcessOnly { get; set; }
        public string[] Indexes { get; set; }
        public string[] InformationFields { get; set; }
        public string OriginalDueDate { get; set; }
        public string PIC { get; set; }
        public string PageNumber { get; set; }
        public string Priority { get; set; }
        public string ReceivedFrom { get; set; }
        public string ReceivedOn { get; set; }
        public string Responsible { get; set; }
        public string RoutingDetails { get; set; }
        public string SentOn { get; set; }
        public string SentTo { get; set; }
        public string ServiceType { get; set; }
        public string Status { get; set; }
        public string TotalDaysAtStep { get; set; }
        public string TotalDaysInProcess { get; set; }
        public string Workflow { get; set; }
        public string WorkflowDescription { get; set; }
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

    public class ValidateIndexesInput
    {
        public string DrawerId { get; set; }
        public ValidateIndexesInputIndexesTypeItem[] Indexes { get; set; }
    }

    public class ValidateIndexesInputIndexesTypeItem
    {
        public string IndexId { get; set; }
        public string IndexValue { get; set; }
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

    public class IndexLookupListFindInput
    {
        public IndexLookupListFindInputActionTypeType? ActionType { get; set; }
        public int? Count { get; set; }
        public string IndexValue { get; set; }
        public IndexLookupListFindInputSearchTypeType? SearchType { get; set; }
    }

    public enum IndexLookupListFindInputActionTypeType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6
    }

    public enum IndexLookupListFindInputSearchTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
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

    public class LoginInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LoginName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
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

    public class CreateWorkflowInput
    {
        public string Drawer { get; set; }
        public string ServiceType { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("headers")]
        public CreateWorkflowInputHeadersType Headers { get; set; }

        [JsonProperty("filing", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWorkflowInputFilingType Filing { get; set; }

        [JsonProperty("deliverable")]
        public CreateWorkflowInputDeliverableType Deliverable { get; set; }
        public CreateWorkflowInputDeliveryInstructionsType DeliveryInstructions { get; set; }

        [JsonProperty("notes")]
        public CreateWorkflowInputNotesType Notes { get; set; }

        [JsonProperty("informationFields")]
        public CreateWorkflowInputInformationFieldsType InformationFields { get; set; }
        public CreateWorkflowInputRoutingSummaryType RoutingSummary { get; set; }
    }

    public class CreateWorkflowInputHeadersType
    {
        public string ClientName { get; set; }
        public string ClientNumber { get; set; }
        public string EngagementType { get; set; }
        public string PIC { get; set; }
        public string Year { get; set; }
        public string PeriodEnd { get; set; }
    }

    public class CreateWorkflowInputFilingType
    {
        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("statusName")]
        public string StatusName { get; set; }
    }

    public class CreateWorkflowInputDeliverableType
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("currentduedate")]
        public string Currentduedate { get; set; }

        [JsonProperty("originalduedate")]
        public string Originalduedate { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }
    }

    public class CreateWorkflowInputDeliveryInstructionsType
    {
        public string Delivery { get; set; }
        public string Destination { get; set; }

        [JsonProperty("sourceDocument")]
        public string SourceDocument { get; set; }
    }

    public class CreateWorkflowInputNotesType
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CreateWorkflowInputInformationFieldsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateWorkflowInputRoutingSummaryType
    {
        public string ResponsibleField { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeleteMasterDeliverableResponseItem
    {
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class DeleteMasterDeliverableInput
    {
        public string ServiceType { get; set; }
        public string DrawerName { get; set; }
        public string[] DeliverableNames { get; set; }
    }

    public class DeleteWorkflowsResponse
    {
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("filingId")]
        public string FilingId { get; set; }
    }

    public class DeleteWorkflowsInput
    {
        [JsonProperty("filingId")]
        public int[] FilingId { get; set; }
    }

    public class EditMasterDeliverableResponse
    {
        [JsonProperty("isUpdated")]
        public bool IsUpdated { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class EditMasterDeliverableInput
    {
        [JsonProperty("currentdeliverableName")]
        public string CurrentdeliverableName { get; set; }

        [JsonProperty("updatedeliverableName")]
        public string UpdatedeliverableName { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("firstExtension")]
        public string FirstExtension { get; set; }

        [JsonProperty("secondExtension")]
        public string SecondExtension { get; set; }

        [JsonProperty("thirdExtension")]
        public string ThirdExtension { get; set; }

        [JsonProperty("calenderOrFiscal")]
        public string CalenderOrFiscal { get; set; }

        [JsonProperty("extension")]
        public int? Extension { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("drawerName")]
        public string DrawerName { get; set; }
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

    public class EditWorkflowInput
    {
        [JsonProperty("filingId")]
        public int? FilingId { get; set; }
        public EditWorkflowInputHeadersType Headers { get; set; }

        [JsonProperty("deliverable")]
        public EditWorkflowInputDeliverableType Deliverable { get; set; }

        [JsonProperty("notes")]
        public EditWorkflowInputNotesType Notes { get; set; }

        [JsonProperty("informationFields")]
        public EditWorkflowInputInformationFieldsType InformationFields { get; set; }

        [JsonProperty("deliveryInstructions")]
        public EditWorkflowInputDeliveryInstructionsType DeliveryInstructions { get; set; }

        [JsonProperty("routingSummary")]
        public EditWorkflowInputRoutingSummaryType RoutingSummary { get; set; }

        [JsonProperty("reindexDocs")]
        public bool? ReindexDocs { get; set; }
    }

    public class EditWorkflowInputHeadersType
    {
        public string ClientName { get; set; }
        public string ClientNumber { get; set; }
        public string EngagementType { get; set; }
        public string PIC { get; set; }
        public string Year { get; set; }
        public string PeriodEnd { get; set; }
    }

    public class EditWorkflowInputDeliverableType
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("currentduedate")]
        public string Currentduedate { get; set; }

        [JsonProperty("originalduedate")]
        public string Originalduedate { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }
    }

    public class EditWorkflowInputNotesType
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("noteid")]
        public string[] Noteid { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class EditWorkflowInputInformationFieldsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EditWorkflowInputDeliveryInstructionsType
    {
        public string Delivery { get; set; }
        public string Destination { get; set; }

        [JsonProperty("sourceDocument")]
        public string SourceDocument { get; set; }
    }

    public class EditWorkflowInputRoutingSummaryType
    {
        [JsonProperty("responsibleField")]
        public string ResponsibleField { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
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

    public class GetMasterDeliverableInput
    {
        public int? PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int? PageSize { get; set; }
        public string ServiceType { get; set; }
        public string DrawerName { get; set; }
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
        public string FolderId { get; set; }

        [JsonProperty("filingID")]
        public string FilingId { get; set; }

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

    public class TrackingReportByWorkflowInput
    {
        public string DrawerId { get; set; }
        public string ServiceType { get; set; }
        public string EngagementType { get; set; }
        public string Workflow { get; set; }
        public string CurrentStep { get; set; }
        public string PIC { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedOn { get; set; }
        public string WorkflowDescription { get; set; }
        public string InProcessOnly { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Responsible { get; set; }
        public string AssignmentHistory { get; set; }
        public string ReceivedFrom { get; set; }
        public string ReceivedOn { get; set; }
        public string SentTo { get; set; }
        public string SentOn { get; set; }
        public string CompletedBy { get; set; }
        public string CompletedOn { get; set; }
        public string CurrentDueDate { get; set; }
        public string DaysAtStep { get; set; }
        public string TotalDaysAtStep { get; set; }
        public string DaysBetweenRoutings { get; set; }
        public string TotalDaysInProcess { get; set; }
        public string Accountable { get; set; }
        public string RoutingDetails { get; set; }
        public string LastUpdated { get; set; }
        public string[] InformationFields { get; set; }
        public string[] Indexes { get; set; }
        public string PageNumber { get; set; }
    }

    public class AddMasterDeliverableResponse
    {
        [JsonProperty("isSaved")]
        public bool IsSaved { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class AddMasterDeliverableInput
    {
        [JsonProperty("deliverableName")]
        public string DeliverableName { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("firstExtension")]
        public string FirstExtension { get; set; }

        [JsonProperty("secondExtension")]
        public string SecondExtension { get; set; }

        [JsonProperty("thirdExtension")]
        public string ThirdExtension { get; set; }

        [JsonProperty("calenderOrFiscal")]
        public string CalenderOrFiscal { get; set; }

        [JsonProperty("extension")]
        public int? Extension { get; set; }
        public string ServiceType { get; set; }
        public string DrawerName { get; set; }
    }

    public class GetUserInfoV2Response
    {
        [JsonProperty("userID")]
        public string UserId { get; set; }

        [JsonProperty("loginID")]
        public string LoginId { get; set; }

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
        public string LocationId { get; set; }

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

    public class GetUserInfoV2Input
    {
        public string LoginName { get; set; }
        public string UserType { get; set; }
    }

    public class RouteWorkflowV2Response
    {
        [JsonProperty("filingId")]
        public string FilingId { get; set; }

        [JsonProperty("isRouted")]
        public bool IsRouted { get; set; }
    }

    public class RouteWorkflowV2Input
    {
        [JsonProperty("filingId")]
        public int[] FilingId { get; set; }
        public string[] CurrentStep { get; set; }
        public bool? Complete { get; set; }
        public string CompletedDate { get; set; }
        public string NextStep { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string RoutingNote { get; set; }

        [JsonProperty("emailNotify")]
        public bool? EmailNotify { get; set; }
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
        public string FolderId { get; set; }

        [JsonProperty("filingID")]
        public string FilingId { get; set; }

        [JsonProperty("priorFilingID")]
        public string PriorFilingId { get; set; }

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

    public class TrackingReportByDeliverableV2Input
    {
        public string DrawerId { get; set; }
        public string ServiceType { get; set; }
        public string EngagementType { get; set; }
        public string Workflow { get; set; }
        public string CurrentStep { get; set; }
        public string PIC { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedOn { get; set; }
        public string WorkflowDescription { get; set; }
        public string InProcessOnly { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string ReceivedOn { get; set; }
        public string CompletedOn { get; set; }
        public string SentOn { get; set; }
        public string Responsible { get; set; }
        public string AssignmentHistory { get; set; }
        public string ReceivedFrom { get; set; }
        public string SentTo { get; set; }
        public string CompletedBy { get; set; }
        public string Accountable { get; set; }
        public string CurrentDueDate { get; set; }
        public string OriginalDueDate { get; set; }
        public string DateExtended { get; set; }
        public string DaysAtStep { get; set; }
        public string TotalDaysAtStep { get; set; }
        public string DaysBetweenRoutings { get; set; }
        public string TotalDaysInProcess { get; set; }
        public string RoutingDetails { get; set; }
        public string LastUpdated { get; set; }
        public string[] InformationFields { get; set; }
        public string[] Indexes { get; set; }
        public string PageNumber { get; set; }
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