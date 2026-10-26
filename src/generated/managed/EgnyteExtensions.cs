//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egnyte
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EgnyteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<CreateGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GroupInfoByIdResponse, ApiConnectionActionConfiguration> GroupInfoById(Expression<Func<GroupInfoByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GroupInfoByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GroupInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupInfoByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ListGroupsResponse, ApiConnectionActionConfiguration> ListGroups(Expression<Func<ListGroupsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ListGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ListGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UserInfoResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<GetUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UserListResponse, ApiConnectionActionConfiguration> GetUserList(Expression<Func<GetUserListInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetUserList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UpdateUserResponse, ApiConnectionActionConfiguration> UpdateUser(Expression<Func<UpdateUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UpdateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUser(Expression<Func<DeleteUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateFolderResponse, ApiConnectionActionConfiguration> CreateFolder(Expression<Func<CreateFolderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFileByPathResponse, ApiConnectionActionConfiguration> DeleteFileByPath(Expression<Func<DeleteFileByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteFileByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteFileByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFolderByPathResponse, ApiConnectionActionConfiguration> DeleteFolderByPath(Expression<Func<DeleteFolderByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteFolderByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteFolderByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteFolderByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFolderByIdResponse, ApiConnectionActionConfiguration> DeleteFolderById(Expression<Func<DeleteFolderByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteFolderByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteFolderById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteFolderByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFileByIdResponse, ApiConnectionActionConfiguration> DeleteFileById(Expression<Func<DeleteFileByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteFileByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteFileByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFileByPathResponse, ApiConnectionActionConfiguration> CopyFileByPath(Expression<Func<CopyFileByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CopyFileByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CopyFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CopyFileByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFolderByPathResponse, ApiConnectionActionConfiguration> CopyFolderByPath(Expression<Func<CopyFolderByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CopyFolderByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CopyFolderByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CopyFolderByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FullGroupUpdateResponse, ApiConnectionActionConfiguration> FullGroupUpdate(Expression<Func<FullGroupUpdateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FullGroupUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/FullGroupUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FullGroupUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<PartialGroupUpdateResponse, ApiConnectionActionConfiguration> PartialGroupUpdate(Expression<Func<PartialGroupUpdateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PartialGroupUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/PartialGroupUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PartialGroupUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteGroup(Expression<Func<DeleteGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFileByIdResponse, ApiConnectionActionConfiguration> CopyFileById(Expression<Func<CopyFileByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CopyFileByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CopyFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CopyFileByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFolderByIdResponse, ApiConnectionActionConfiguration> CopyFolderById(Expression<Func<CopyFolderByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CopyFolderByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CopyFolderById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CopyFolderByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFileByPathResponse, ApiConnectionActionConfiguration> MoveFileByPath(Expression<Func<MoveFileByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveFileByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/MoveFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveFileByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFolderByPathResponse, ApiConnectionActionConfiguration> MoveFolderByPath(Expression<Func<MoveFolderByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveFolderByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/MoveFolderByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveFolderByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFileByIdResponse, ApiConnectionActionConfiguration> MoveFileById(Expression<Func<MoveFileByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveFileByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/MoveFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveFileByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFolderByIdResponse, ApiConnectionActionConfiguration> MoveFolderById(Expression<Func<MoveFolderByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveFolderByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/MoveFolderById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveFolderByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShareFileResponse, ApiConnectionActionConfiguration> ShareFile(Expression<Func<ShareFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ShareFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ShareFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ShareFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShareFolderResponse, ApiConnectionActionConfiguration> ShareFolder(Expression<Func<ShareFolderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ShareFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ShareFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ShareFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FileInfoResponse, ApiConnectionActionConfiguration> FileInfoByPath(Expression<Func<FileInfoByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/FileInfoByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FolderInfoResponse, ApiConnectionActionConfiguration> FolderInfoByPath(Expression<Func<FolderInfoByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FolderInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/FolderInfoByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FolderInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ModifyFolderOptionsResponse, ApiConnectionActionConfiguration> ModifyFolderOptions(Expression<Func<ModifyFolderOptionsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ModifyFolderOptionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ModifyFolderOptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModifyFolderOptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FileInfoResponse, ApiConnectionActionConfiguration> FileInfoById(Expression<Func<FileInfoByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/FileInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FolderInfoResponse, ApiConnectionActionConfiguration> FolderInfoById(Expression<Func<FolderInfoByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FolderInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/FolderInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FolderInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<LockFileByPathResponse, ApiConnectionActionConfiguration> LockFileByPath(Expression<Func<LockFileByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LockFileByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/LockFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LockFileByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnlockFileByPath(Expression<Func<UnlockFileByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UnlockFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<LockFileByIdResponse, ApiConnectionActionConfiguration> LockFileById(Expression<Func<LockFileByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LockFileByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/LockFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LockFileByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnlockFileById(Expression<Func<UnlockFileByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UnlockFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileContentByPath(Expression<Func<GetFileContentByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DownloadFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileContentById(Expression<Func<GetFileContentByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DownloadFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateFileResponse, ApiConnectionActionConfiguration> CreateFile(Expression<Func<string>> name, Expression<Func<string>> path, Expression<Func<string>> body)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["Path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetMetadataByFileId(Expression<Func<SetMetadataByFileIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/SetMetadataByFileId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetMetadataByFolderId(Expression<Func<SetMetadataByFolderIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/SetMetadataByFolderId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem[], ApiConnectionActionConfiguration> GetAllNamespaces()
        {
            return new DeferredBodyAction<NamespaceItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetAllNamespaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NamespaceItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateNamespace(Expression<Func<CreateNamespaceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateNamespace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem, ApiConnectionActionConfiguration> UpdateNamespaceAttributes(Expression<Func<UpdateNamespaceAttributesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NamespaceItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UpdateNamespaceAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NamespaceItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UpdateNamespaceKeysResponse, ApiConnectionActionConfiguration> UpdateNamespaceKeys(Expression<Func<UpdateNamespaceKeysInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateNamespaceKeysResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UpdateNamespaceKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateNamespaceKeysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem, ApiConnectionActionConfiguration> GetNamespace(Expression<Func<GetNamespaceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NamespaceItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetNamespace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NamespaceItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteNamespace(Expression<Func<DeleteNamespaceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteNamespace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem[], ApiConnectionActionConfiguration> GetAllProjects()
        {
            return new DeferredBodyAction<ProjectItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetAllProjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MarkFolderAsProjectResponse, ApiConnectionActionConfiguration> MarkFolderAsProject(Expression<Func<MarkFolderAsProjectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MarkFolderAsProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/MarkFolderAsProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MarkFolderAsProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateProjectFromTemplateResponse, ApiConnectionActionConfiguration> CreateProjectFromTemplate(Expression<Func<CreateProjectFromTemplateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProjectFromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateProjectFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem, ApiConnectionActionConfiguration> GetProjectById(Expression<Func<GetProjectByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateProjectById(Expression<Func<UpdateProjectByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/UpdateProjectById";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteProjectById(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api-proxy/DeleteProjectById/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem[], ApiConnectionActionConfiguration> GetProjectByRootFolderId(Expression<Func<GetProjectByRootFolderIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetProjectByRootFolderId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CleanupProjectResponse, ApiConnectionActionConfiguration> CleanupProject(Expression<Func<CleanupProjectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CleanupProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CleanupProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CleanupProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateMetadataKey(Expression<Func<CreateMetadataKeyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateMetadataKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMetadataKey(Expression<Func<DeleteMetadataKeyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteMetadataKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMetadataByFileId(Expression<Func<GetMetadataByFileIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetMetadataByFileId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMetadataByFolderId(Expression<Func<GetMetadataByFolderIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetMetadataByFolderId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SearchMetadata(Expression<Func<SearchMetadataInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/SearchMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GetEffectivePermissionsResponse, ApiConnectionActionConfiguration> GetEffectivePermissions(Expression<Func<GetEffectivePermissionsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetEffectivePermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetEffectivePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetEffectivePermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetFolderPermissions(Expression<Func<SetFolderPermissionsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/SetFolderPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GetFolderPermissionsResponse, ApiConnectionActionConfiguration> GetFolderPermissions(Expression<Func<GetFolderPermissionsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetFolderPermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetFolderPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetFolderPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeepLinksByIdResponse, ApiConnectionActionConfiguration> DeepLinksById(Expression<Func<DeepLinksByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeepLinksByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeepLinksById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeepLinksByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeepLinksByPathResponse, ApiConnectionActionConfiguration> DeepLinksByPath(Expression<Func<DeepLinksByPathInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeepLinksByPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeepLinksByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeepLinksByPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShowLinkDetailsResponse, ApiConnectionActionConfiguration> ShowLinkDetails(Expression<Func<ShowLinkDetailsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ShowLinkDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ShowLinkDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ShowLinkDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateLinkResponse, ApiConnectionActionConfiguration> CreateLink(Expression<Func<CreateLinkInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CreateLink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLink(Expression<Func<DeleteLinkInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/DeleteLink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AIQuestionResponse, ApiConnectionActionConfiguration> AskDocumentQuestion(Expression<Func<AskDocumentQuestionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AIQuestionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/AskDocumentQuestion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AIQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AISummaryResponse, ApiConnectionActionConfiguration> SummarizeDocument(Expression<Func<SummarizeDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AISummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/SummarizeDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AISummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AICopilotResponse, ApiConnectionActionConfiguration> CopilotAsk(Expression<Func<CopilotAskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AICopilotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/CopilotAsk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AICopilotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AICopilotResponse, ApiConnectionActionConfiguration> AskKnowledgeBase(Expression<Func<AskKnowledgeBaseInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AICopilotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/AskKnowledgeBase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AICopilotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<KnowledgeBaseListResponse, ApiConnectionActionConfiguration> ListKnowledgeBases(Expression<Func<ListKnowledgeBasesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<KnowledgeBaseListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ListKnowledgeBases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<KnowledgeBaseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<HybridSearchResponse, ApiConnectionActionConfiguration> HybridSearch(Expression<Func<HybridSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<HybridSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/HybridSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<HybridSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AgentListResponseItem[], ApiConnectionActionConfiguration> ListAgents(Expression<Func<ListAgentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgentListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ListAgents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgentListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AskAgentResponse, ApiConnectionActionConfiguration> AskAgent(Expression<Func<AskAgentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AskAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/AskAgent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AskAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AgentExecutionStatusResponse, ApiConnectionActionConfiguration> GetAgentExecutionStatus(Expression<Func<GetAgentExecutionStatusInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgentExecutionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/GetAgentExecutionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgentExecutionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ListLinksV2Response, ApiConnectionActionConfiguration> ListLinks(Expression<Func<ListLinksV2Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ListLinksV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/ListLinksV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListLinksV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<SearchV2Response, ApiConnectionActionConfiguration> Search(Expression<Func<SearchV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-proxy/SearchV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchV2Response>(callPayload);
            });
        }
    }

    public class EgnyteTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FileLocked(Expression<Func<FileLockedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FileLocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FileUnlocked(Expression<Func<FileUnlockedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FileUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FileUpdated(Expression<Func<FileUpdatedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FileUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FileCreated(Expression<Func<FileCreatedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FileCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShareLinkCreated(Expression<Func<ShareLinkCreatedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/ShareLinkCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ShareLinkDeleted(Expression<Func<ShareLinkDeletedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/ShareLinkDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FileOrFolderPermissionChange(Expression<Func<FileOrFolderPermissionChangeInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FileOrFolderPermissionChange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FileOrFolderMetadataChange(Expression<Func<FileOrFolderMetadataChangeInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FileOrFolderMetadataChange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FolderProjectAdded(Expression<Func<FolderProjectAddedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FolderProjectAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FolderProjectUnmarked(Expression<Func<FolderProjectUnmarkedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FolderProjectUnmarked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FolderProjectUpdated(Expression<Func<FolderProjectUpdatedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/FolderProjectUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WorkflowCreated(Expression<Func<WorkflowCreatedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/WorkflowCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WorkflowCompleted(Expression<Func<WorkflowCompletedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/WorkflowCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WorkflowApprovalTaskApproved(Expression<Func<WorkflowApprovalTaskApprovedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/WorkflowApprovalTaskApproved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WorkflowApprovalTaskRejected(Expression<Func<WorkflowApprovalTaskRejectedInput>> body, Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/WorkflowApprovalTaskRejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupCreated(Expression<Func<GroupCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/GroupCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupUpdated(Expression<Func<GroupUpdatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/GroupUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupDeleted(Expression<Func<GroupDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/GroupDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollCreatedFilesResponseItem[], ApiConnectionTriggerConfiguration> PollCreatedFiles(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollCreatedFilesResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/created-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollCreatedFilesResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollCreatedFoldersResponseItem[], ApiConnectionTriggerConfiguration> PollCreatedFolders(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollCreatedFoldersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/created-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollCreatedFoldersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollDeletedFilesResponseItem[], ApiConnectionTriggerConfiguration> PollDeletedFiles(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollDeletedFilesResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/deleted-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollDeletedFilesResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollDeletedFoldersResponseItem[], ApiConnectionTriggerConfiguration> PollDeletedFolders(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollDeletedFoldersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/deleted-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollDeletedFoldersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollRenamedFilesResponseItem[], ApiConnectionTriggerConfiguration> PollRenamedFiles(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollRenamedFilesResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/renamed-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollRenamedFilesResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollRenamedFoldersResponseItem[], ApiConnectionTriggerConfiguration> PollRenamedFolders(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollRenamedFoldersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/renamed-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollRenamedFoldersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollMovedFilesResponseItem[], ApiConnectionTriggerConfiguration> PollMovedFiles(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollMovedFilesResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/moved-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollMovedFilesResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollMovedFoldersResponseItem[], ApiConnectionTriggerConfiguration> PollMovedFolders(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollMovedFoldersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/moved-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollMovedFoldersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollCopiedFilesResponseItem[], ApiConnectionTriggerConfiguration> PollCopiedFiles(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollCopiedFilesResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/copied-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollCopiedFilesResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollCopiedFoldersResponseItem[], ApiConnectionTriggerConfiguration> PollCopiedFolders(Expression<Func<string>> folderPath, FlowRecurrence recurrence = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyTrigger<PollCopiedFoldersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/copied-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<PollCopiedFoldersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public CreateGroupResponseMembersTypeItem[] Members { get; set; }
    }

    public class CreateGroupResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class CreateGroupInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public CreateGroupInputMembersTypeItem[] Members { get; set; }
    }

    public class CreateGroupInputMembersTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GroupInfoByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public GroupInfoByIdResponseMembersTypeItem[] Members { get; set; }
    }

    public class GroupInfoByIdResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GroupInfoByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class ListGroupsResponse
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("resources")]
        public ListGroupsResponseResourcesTypeItem[] Resources { get; set; }
    }

    public class ListGroupsResponseResourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ListGroupsInput
    {
        [JsonProperty("startIndex")]
        public int? StartIndex { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }
    }

    public class UserInfoResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public UserInfoResponseNameType Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("lastActiveDate")]
        public string LastActiveDate { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("language")]
        public UserInfoResponseLanguageType Language { get; set; }

        [JsonProperty("authType")]
        public UserInfoResponseAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public UserInfoResponseUserTypeType UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("isServiceAccount")]
        public bool IsServiceAccount { get; set; }

        [JsonProperty("deleteOnExpiry")]
        public string DeleteOnExpiry { get; set; }

        [JsonProperty("emailChangePending")]
        public bool EmailChangePending { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("groups")]
        public UserInfoResponseGroupsTypeItem[] Groups { get; set; }
    }

    public class UserInfoResponseNameType
    {
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserInfoResponseLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserInfoResponseAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserInfoResponseUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class UserInfoResponseGroupsTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetUserInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }
    }

    public class UserListResponse
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("resources")]
        public UserListResponseResourcesTypeItem[] Resources { get; set; }
    }

    public class UserListResponseResourcesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public UserListResponseResourcesTypeItemNameType Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("lastActiveDate")]
        public string LastActiveDate { get; set; }

        [JsonProperty("language")]
        public UserListResponseResourcesTypeItemLanguageType Language { get; set; }

        [JsonProperty("authType")]
        public UserListResponseResourcesTypeItemAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public UserListResponseResourcesTypeItemUserTypeType UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("isServiceAccount")]
        public bool IsServiceAccount { get; set; }

        [JsonProperty("deleteOnExpiry")]
        public string DeleteOnExpiry { get; set; }

        [JsonProperty("emailChangePending")]
        public bool EmailChangePending { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class UserListResponseResourcesTypeItemNameType
    {
        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserListResponseResourcesTypeItemLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserListResponseResourcesTypeItemAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserListResponseResourcesTypeItemUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class GetUserListInput
    {
        [JsonProperty("startIndex")]
        public int? StartIndex { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }
    }

    public class UpdateUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("sendInvite")]
        public bool SendInvite { get; set; }

        [JsonProperty("language")]
        public UpdateUserResponseLanguageType Language { get; set; }

        [JsonProperty("authType")]
        public UpdateUserResponseAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public UpdateUserResponseUserTypeType UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserResponseLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserResponseAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserResponseUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class UpdateUserInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public UpdateUserInputNameType Name { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("sendInvite")]
        public bool? SendInvite { get; set; }

        [JsonProperty("language")]
        public UpdateUserInputLanguageType? Language { get; set; }

        [JsonProperty("authType")]
        public UpdateUserInputAuthTypeType? AuthType { get; set; }

        [JsonProperty("userType")]
        public UpdateUserInputUserTypeType? UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class UpdateUserInputNameType
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserInputLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserInputAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserInputUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class CreateUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailChangePending")]
        public bool EmailChangePending { get; set; }

        [JsonProperty("name")]
        public CreateUserResponseNameType Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("authType")]
        public CreateUserResponseAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public CreateUserResponseUserTypeType UserType { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("lastActiveDate")]
        public string LastActiveDate { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }
    }

    public class CreateUserResponseNameType
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserResponseAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserResponseUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class CreateUserInput
    {
        [JsonProperty("userName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserInputNameType Name { get; set; }

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Active { get; set; }

        [JsonProperty("userType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserInputUserTypeType UserType { get; set; }

        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserInputAuthTypeType AuthType { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("sendInvite")]
        public bool? SendInvite { get; set; }

        [JsonProperty("isServiceAccount")]
        public bool? IsServiceAccount { get; set; }

        [JsonProperty("language")]
        public CreateUserInputLanguageType? Language { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class CreateUserInputNameType
    {
        [JsonProperty("givenName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GivenName { get; set; }

        [JsonProperty("familyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FamilyName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserInputUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserInputAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserInputLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    public class DeleteUserInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }
    }

    public class CreateFolderResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class CreateFolderInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class DeleteFileByPathResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFileByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class DeleteFolderByPathResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFolderByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class DeleteFolderByIdResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFolderByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class DeleteFileByIdResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFileByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class CopyFileByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class CopyFileByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class CopyFolderByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class CopyFolderByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class FullGroupUpdateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public FullGroupUpdateResponseMembersTypeItem[] Members { get; set; }
    }

    public class FullGroupUpdateResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class FullGroupUpdateInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public FullGroupUpdateInputMembersTypeItem[] Members { get; set; }
    }

    public class FullGroupUpdateInputMembersTypeItem
    {
        [JsonProperty("value")]
        public int? Value { get; set; }
    }

    public class PartialGroupUpdateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public PartialGroupUpdateResponseMembersTypeItem[] Members { get; set; }
    }

    public class PartialGroupUpdateResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PartialGroupUpdateInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public PartialGroupUpdateInputMembersTypeItem[] Members { get; set; }
    }

    public class PartialGroupUpdateInputMembersTypeItem
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("operation")]
        public PartialGroupUpdateInputMembersTypeItemOperationType? Operation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PartialGroupUpdateInputMembersTypeItemOperationType
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "delete")]
        Delete
    }

    public class DeleteGroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class CopyFileByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class CopyFileByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class CopyFolderByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class CopyFolderByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class MoveFileByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class MoveFileByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class MoveFolderByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class MoveFolderByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class MoveFileByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class MoveFileByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class MoveFolderByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class MoveFolderByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("destination_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationPath { get; set; }
    }

    public class ShareFileResponse
    {
        [JsonProperty("links")]
        public ShareFileResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class ShareFileResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class ShareFileInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class ShareFolderResponse
    {
        [JsonProperty("links")]
        public ShareFolderResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class ShareFolderResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class ShareFolderInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class FileInfoResponse
    {
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("num_versions")]
        public int NumVersions { get; set; }

        [JsonProperty("versions")]
        public FileInfoResponseVersionsTypeItem[] Versions { get; set; }
    }

    public class FileInfoResponseVersionsTypeItem
    {
        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public class FileInfoByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class FolderInfoResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public int LastModified { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("public_links")]
        public string PublicLinks { get; set; }

        [JsonProperty("allow_links")]
        public bool AllowLinks { get; set; }

        [JsonProperty("restrict_move_delete")]
        public bool RestrictMoveDelete { get; set; }

        [JsonProperty("folders")]
        public FolderInfoResponseFoldersTypeItem[] Folders { get; set; }

        [JsonProperty("files")]
        public FolderInfoResponseFilesTypeItem[] Files { get; set; }
    }

    public class FolderInfoResponseFoldersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public int LastModified { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }

    public class FolderInfoResponseFilesTypeItem
    {
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("num_versions")]
        public int NumVersions { get; set; }
    }

    public class FolderInfoByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class ModifyFolderOptionsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public int LastModified { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("folder_description")]
        public string FolderDescription { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("public_links")]
        public string PublicLinks { get; set; }

        [JsonProperty("restrict_move_delete")]
        public bool RestrictMoveDelete { get; set; }
    }

    public class ModifyFolderOptionsInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("folder_description")]
        public string FolderDescription { get; set; }

        [JsonProperty("allow_links")]
        public bool? AllowLinks { get; set; }

        [JsonProperty("public_links")]
        public ModifyFolderOptionsInputPublicLinksType? PublicLinks { get; set; }

        [JsonProperty("restrict_move_delete")]
        public bool? RestrictMoveDelete { get; set; }

        [JsonProperty("email_preferences")]
        public ModifyFolderOptionsInputEmailPreferencesType EmailPreferences { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ModifyFolderOptionsInputPublicLinksType
    {
        [EnumMember(Value = "files_folders")]
        FilesFolders,
        [EnumMember(Value = "files")]
        Files,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    public class ModifyFolderOptionsInputEmailPreferencesType
    {
        [JsonProperty("content_updates")]
        public bool? ContentUpdates { get; set; }

        [JsonProperty("content_accessed")]
        public bool? ContentAccessed { get; set; }
    }

    public class FileInfoByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class FolderInfoByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class LockFileByPathResponse
    {
        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("lock_token")]
        public string LockToken { get; set; }
    }

    public class LockFileByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class UnlockFileByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("lock_token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LockToken { get; set; }
    }

    public class LockFileByIdResponse
    {
        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("lock_token")]
        public string LockToken { get; set; }
    }

    public class LockFileByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class UnlockFileByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("lock_token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LockToken { get; set; }
    }

    public class GetFileContentByPathInput
    {
        [JsonProperty("filePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilePath { get; set; }

        [JsonProperty("enableAISafeguards", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableAISafeguards { get; set; } = false;
    }

    public class GetFileContentByIdInput
    {
        [JsonProperty("fileId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileId { get; set; }

        [JsonProperty("enableAISafeguards", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableAISafeguards { get; set; } = false;
    }

    public class CreateFileResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class SetMetadataByFileIdInput
    {
        [JsonProperty("fileId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileId { get; set; }

        [JsonProperty("namespaceName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NamespaceName { get; set; }

        [JsonProperty("metadataName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetadataName { get; set; }

        [JsonProperty("metadataValue")]
        public string MetadataValue { get; set; }
    }

    public class SetMetadataByFolderIdInput
    {
        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("namespaceName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NamespaceName { get; set; }

        [JsonProperty("metadataName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetadataName { get; set; }

        [JsonProperty("metadataValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetadataValue { get; set; }
    }

    public class NamespaceItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scope")]
        public NamespaceItemScopeType Scope { get; set; }

        [JsonProperty("keys")]
        public JToken Keys { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("priority")]
        public double Priority { get; set; }

        [JsonProperty("inheritable")]
        public bool Inheritable { get; set; }

        [JsonProperty("schemaSystemGenerated")]
        public bool SchemaSystemGenerated { get; set; }

        [JsonProperty("metadataScopeType")]
        public NamespaceItemMetadataScopeTypeType MetadataScopeType { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NamespaceItemScopeType
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "protected")]
        Protected,
        [EnumMember(Value = "private")]
        Private
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NamespaceItemMetadataScopeTypeType
    {
        GLOBAL,
        [EnumMember(Value = "FOLDER_SCOPE")]
        FOLDERSCOPE
    }

    public class CreateNamespaceInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateNamespaceInputScopeType Scope { get; set; }

        [JsonProperty("keys", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateNamespaceInputKeysTypeItem[] Keys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateNamespaceInputScopeType
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "protected")]
        Protected,
        [EnumMember(Value = "private")]
        Private
    }

    public class CreateNamespaceInputKeysTypeItem
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateNamespaceInputKeysTypeItemTypeType Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("helpText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HelpText { get; set; }

        [JsonProperty("priority")]
        public double? Priority { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateNamespaceInputKeysTypeItemTypeType
    {
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "decimal")]
        Decimal,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "enum")]
        Enum
    }

    public class UpdateNamespaceAttributesInput
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("priorities")]
        public JToken Priorities { get; set; }
    }

    public class UpdateNamespaceKeysResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("priority")]
        public double Priority { get; set; }
    }

    public class UpdateNamespaceKeysInput
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public UpdateNamespaceKeysInputTypeType? Type { get; set; }

        [JsonProperty("priority")]
        public double? Priority { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("helpText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HelpText { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateNamespaceKeysInputTypeType
    {
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "decimal")]
        Decimal,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "enum")]
        Enum
    }

    public class GetNamespaceInput
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }
    }

    public class DeleteNamespaceInput
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("force")]
        public bool? Force { get; set; }
    }

    public class ProjectItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rootFolderId")]
        public string RootFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public ProjectLocationItem Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdBy")]
        public double CreatedBy { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public double LastUpdatedBy { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }
    }

    public class ProjectLocationItem
    {
        [JsonProperty("streetAddress1")]
        public string StreetAddress1 { get; set; }

        [JsonProperty("streetAddress2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class MarkFolderAsProjectResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MarkFolderAsProjectInput
    {
        [JsonProperty("rootFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RootFolderId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public MarkFolderAsProjectInputStatusType Status { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MarkFolderAsProjectInputStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in-progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "on-hold")]
        OnHold,
        [EnumMember(Value = "canceled")]
        Canceled
    }

    public class CreateProjectFromTemplateResponse
    {
        [JsonProperty("groupsCreated")]
        public CreateProjectFromTemplateResponseGroupsCreatedTypeItem[] GroupsCreated { get; set; }
    }

    public class CreateProjectFromTemplateResponseGroupsCreatedTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateProjectFromTemplateInput
    {
        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }

        [JsonProperty("templateFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFolderId { get; set; }

        [JsonProperty("folderName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderName { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProjectFromTemplateInputStatusType Status { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }

        [JsonProperty("location")]
        public ProjectLocationItem Location { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateProjectFromTemplateInputStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in-progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "on-hold")]
        OnHold,
        [EnumMember(Value = "canceled")]
        Canceled
    }

    public class GetProjectByIdInput
    {
        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }
    }

    public class UpdateProjectByIdInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("customProjectId")]
        public string CustomProjectId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("location")]
        public UpdateProjectByIdInputLocationType Location { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateProjectByIdInputStatusType Status { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }
    }

    public class UpdateProjectByIdInputLocationType
    {
        [JsonProperty("streetAddress1")]
        public string StreetAddress1 { get; set; }

        [JsonProperty("streetAddress2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateProjectByIdInputStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in-progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "on-hold")]
        OnHold,
        [EnumMember(Value = "canceled")]
        Canceled
    }

    public class GetProjectByRootFolderIdInput
    {
        [JsonProperty("rootFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RootFolderId { get; set; }
    }

    public class CleanupProjectResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CleanupProjectInput
    {
        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("deleteLinks", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DeleteLinks { get; set; }

        [JsonProperty("usersToDelete")]
        public int[] UsersToDelete { get; set; }

        [JsonProperty("usersToDisable")]
        public int[] UsersToDisable { get; set; }
    }

    public class CreateMetadataKeyInput
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateMetadataKeyInputTypeType Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("priority")]
        public double? Priority { get; set; }

        [JsonProperty("helpText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HelpText { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateMetadataKeyInputTypeType
    {
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "decimal")]
        Decimal,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "enum")]
        Enum
    }

    public class DeleteMetadataKeyInput
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("force")]
        public bool? Force { get; set; }
    }

    public class GetMetadataByFileIdInput
    {
        [JsonProperty("fileId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileId { get; set; }

        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }
    }

    public class GetMetadataByFolderIdInput
    {
        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }
    }

    public class SearchMetadataInput
    {
        [JsonProperty("type")]
        public SearchMetadataInputTypeType? Type { get; set; }

        [JsonProperty("hasKey")]
        public SearchMetadataInputHasKeyTypeItem[] HasKey { get; set; }

        [JsonProperty("keyWithValue")]
        public SearchMetadataInputKeyWithValueTypeItem[] KeyWithValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchMetadataInputTypeType
    {
        ALL,
        FOLDER,
        FILE
    }

    public class SearchMetadataInputHasKeyTypeItem
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("keyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KeyName { get; set; }
    }

    public class SearchMetadataInputKeyWithValueTypeItem
    {
        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }

        [JsonProperty("keyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KeyName { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class GetEffectivePermissionsResponse
    {
        [JsonProperty("permission")]
        public GetEffectivePermissionsResponsePermissionType Permission { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEffectivePermissionsResponsePermissionType
    {
        None,
        [EnumMember(Value = "Viewer Only")]
        ViewerOnly,
        Viewer,
        Editor,
        Full,
        Owner
    }

    public class GetEffectivePermissionsInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }
    }

    public class SetFolderPermissionsInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("userPerms")]
        public JToken UserPerms { get; set; }

        [JsonProperty("groupPerms")]
        public JToken GroupPerms { get; set; }

        [JsonProperty("inheritsPermissions")]
        public bool? InheritsPermissions { get; set; }

        [JsonProperty("keepParentPermissions")]
        public bool? KeepParentPermissions { get; set; }
    }

    public class GetFolderPermissionsResponse
    {
        [JsonProperty("userPerms")]
        public JToken UserPerms { get; set; }

        [JsonProperty("groupPerms")]
        public JToken GroupPerms { get; set; }

        [JsonProperty("inheritsPermissions")]
        public bool InheritsPermissions { get; set; }

        [JsonProperty("keepParentPermissions")]
        public bool KeepParentPermissions { get; set; }
    }

    public class GetFolderPermissionsInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class DeepLinksByIdResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DeepLinksByIdInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public DeepLinksByIdInputTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeepLinksByIdInputTypeType
    {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "folder")]
        Folder
    }

    public class DeepLinksByPathResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DeepLinksByPathInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }
    }

    public class ShowLinkDetailsResponse
    {
        [JsonProperty("links")]
        public ShowLinkDetailsResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("last_accessed")]
        public string LastAccessed { get; set; }
    }

    public class ShowLinkDetailsResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class ShowLinkDetailsInput
    {
        [JsonProperty("linkId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkId { get; set; }
    }

    public class CreateLinkResponse
    {
        [JsonProperty("links")]
        public CreateLinkResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class CreateLinkResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class CreateLinkInput
    {
        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLinkInputTypeType Type { get; set; }

        [JsonProperty("accessibility")]
        public CreateLinkInputAccessibilityType? Accessibility { get; set; }

        [JsonProperty("useDefaultSettings", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseDefaultSettings { get; set; } = true;

        [JsonProperty("send_email")]
        public bool? SendEmail { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("copy_me")]
        public bool? CopyMe { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool? LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("expiry_clicks")]
        public double? ExpiryClicks { get; set; }

        [JsonProperty("add_file_name")]
        public bool? AddFileName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("protection")]
        public CreateLinkInputProtectionType? Protection { get; set; }

        [JsonProperty("folder_per_recipient")]
        public bool? FolderPerRecipient { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLinkInputTypeType
    {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "upload")]
        Upload
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLinkInputAccessibilityType
    {
        [EnumMember(Value = "anyone")]
        Anyone,
        [EnumMember(Value = "password")]
        Password,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "recipients")]
        Recipients,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLinkInputProtectionType
    {
        PREVIEW,
        NONE
    }

    public class DeleteLinkInput
    {
        [JsonProperty("linkId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkId { get; set; }
    }

    public class AIQuestionResponse
    {
        [JsonProperty("response")]
        public AIResponse Response { get; set; }

        [JsonProperty("citations")]
        public AICitation[] Citations { get; set; }
    }

    public class AIResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AICitation
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("entryId")]
        public string EntryId { get; set; }

        [JsonProperty("chunks")]
        public AICitationChunksTypeItem[] Chunks { get; set; }
    }

    public class AICitationChunksTypeItem
    {
        [JsonProperty("chunkId")]
        public string ChunkId { get; set; }

        [JsonProperty("sourceText")]
        public string SourceText { get; set; }
    }

    public class AskDocumentQuestionInput
    {
        [JsonProperty("entryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("includeCitations")]
        public bool? IncludeCitations { get; set; }

        [JsonProperty("chatHistory")]
        public AIChatHistory ChatHistory { get; set; }
    }

    public class AIChatHistory
    {
        [JsonProperty("messages")]
        public AIMessage[] Messages { get; set; }
    }

    public class AIMessage
    {
        [JsonProperty("role")]
        public AIMessageRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AIMessageRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class AISummaryResponse
    {
        [JsonProperty("response")]
        public AIResponse Response { get; set; }
    }

    public class SummarizeDocumentInput
    {
        [JsonProperty("entryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty("chatHistory")]
        public AIChatHistory ChatHistory { get; set; }
    }

    public class AICopilotResponse
    {
        [JsonProperty("response")]
        public AIResponse Response { get; set; }

        [JsonProperty("citations")]
        public AICitation[] Citations { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }
    }

    public class CopilotAskInput
    {
        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("selectedItems", DefaultValueHandling = DefaultValueHandling.Include)]
        public AISelectedItems SelectedItems { get; set; }

        [JsonProperty("includeCitations")]
        public bool? IncludeCitations { get; set; }

        [JsonProperty("chatHistory")]
        public AIChatHistory ChatHistory { get; set; }
    }

    public class AISelectedItems
    {
        [JsonProperty("folders")]
        public AISelectedItemsFoldersTypeItem[] Folders { get; set; }

        [JsonProperty("files")]
        public AISelectedItemsFilesTypeItem[] Files { get; set; }
    }

    public class AISelectedItemsFoldersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AISelectedItemsFilesTypeItem
    {
        [JsonProperty("entryId")]
        public string EntryId { get; set; }
    }

    public class AskKnowledgeBaseInput
    {
        [JsonProperty("kbId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KbId { get; set; }

        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("includeCitations")]
        public bool? IncludeCitations { get; set; }

        [JsonProperty("chatHistory")]
        public AIChatHistory ChatHistory { get; set; }
    }

    public class KnowledgeBaseListResponse
    {
        [JsonProperty("content")]
        public KnowledgeBaseListResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("fileLimit")]
        public int FileLimit { get; set; }
    }

    public class KnowledgeBaseListResponseContentTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("paths")]
        public KnowledgeBaseListResponseContentTypeItemPathsTypeItem[] Paths { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdByUser")]
        public KnowledgeBaseListResponseContentTypeItemCreatedByUserType CreatedByUser { get; set; }

        [JsonProperty("createdOn")]
        public int CreatedOn { get; set; }

        [JsonProperty("noResponseMessage")]
        public string NoResponseMessage { get; set; }

        [JsonProperty("iconName")]
        public string IconName { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("lastProcessedAt")]
        public int LastProcessedAt { get; set; }

        [JsonProperty("pathCount")]
        public int PathCount { get; set; }

        [JsonProperty("prompts")]
        public JToken[] Prompts { get; set; }
    }

    public class KnowledgeBaseListResponseContentTypeItemPathsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class KnowledgeBaseListResponseContentTypeItemCreatedByUserType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }
    }

    public class ListKnowledgeBasesInput
    {
        [JsonProperty("sortBy", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListKnowledgeBasesInputSortByType SortBy { get; set; } = ListKnowledgeBasesInputSortByType.CreatedOn;

        [JsonProperty("sortDirection", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListKnowledgeBasesInputSortDirectionType SortDirection { get; set; } = ListKnowledgeBasesInputSortDirectionType.ASC;

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListKnowledgeBasesInputStatusType Status { get; set; } = ListKnowledgeBasesInputStatusType.ACTIVE;

        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdAfter")]
        public int? CreatedAfter { get; set; }

        [JsonProperty("createdBefore")]
        public int? CreatedBefore { get; set; }

        [JsonProperty("includePlaceholderData", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludePlaceholderData { get; set; } = false;

        [JsonProperty("includeProcessingStatistics", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeProcessingStatistics { get; set; } = false;

        [JsonProperty("includePrompts", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludePrompts { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListKnowledgeBasesInputSortByType
    {
        [EnumMember(Value = "createdOn")]
        CreatedOn,
        [EnumMember(Value = "name")]
        Name
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListKnowledgeBasesInputSortDirectionType
    {
        ASC,
        DESC
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListKnowledgeBasesInputStatusType
    {
        ACTIVE,
        DELETED,
        CREATED
    }

    public class HybridSearchResponse
    {
        [JsonProperty("results")]
        public HybridSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class HybridSearchResponseResultsTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("entryId")]
        public string EntryId { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("chunks")]
        public HybridSearchResponseResultsTypeItemChunksTypeItem[] Chunks { get; set; }
    }

    public class HybridSearchResponseResultsTypeItemChunksTypeItem
    {
        [JsonProperty("chunkId")]
        public string ChunkId { get; set; }

        [JsonProperty("chunkText")]
        public string ChunkText { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class HybridSearchInput
    {
        [JsonProperty("semanticWeight", DefaultValueHandling = DefaultValueHandling.Include)]
        public double SemanticWeight { get; set; }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("folderPath")]
        public string FolderPath { get; set; }

        [JsonProperty("collectionId")]
        public string CollectionId { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdAfter")]
        public int? CreatedAfter { get; set; }

        [JsonProperty("createdBefore")]
        public int? CreatedBefore { get; set; }

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;

        [JsonProperty("preferredFolderPath")]
        public string PreferredFolderPath { get; set; }

        [JsonProperty("excludeFolderPaths")]
        public string[] ExcludeFolderPaths { get; set; }

        [JsonProperty("folderPaths")]
        public string[] FolderPaths { get; set; }

        [JsonProperty("entryIds")]
        public string[] EntryIds { get; set; }

        [JsonProperty("enableAISafeguards", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableAISafeguards { get; set; } = false;
    }

    public class AgentListResponseItem
    {
        [JsonProperty("agentId")]
        public string AgentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class ListAgentsInput
    {
        [JsonProperty("sortBy", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListAgentsInputSortByType? SortBy { get; set; } = ListAgentsInputSortByType.Name;

        [JsonProperty("sortOrder", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListAgentsInputSortOrderType? SortOrder { get; set; } = ListAgentsInputSortOrderType.Asc;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAgentsInputSortByType
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "createdOn")]
        CreatedOn
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAgentsInputSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class AskAgentResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }
    }

    public class AskAgentInput
    {
        [JsonProperty("agentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentId { get; set; }

        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }

        [JsonProperty("chatHistory")]
        public AIChatHistory ChatHistory { get; set; }

        [JsonProperty("entryIds")]
        public string[] EntryIds { get; set; }

        [JsonProperty("selectedItems")]
        public AISelectedItems SelectedItems { get; set; }
    }

    public class AgentExecutionStatusResponse
    {
        [JsonProperty("status")]
        public AgentExecutionStatusResponseStatusType Status { get; set; }

        [JsonProperty("responseText")]
        public string ResponseText { get; set; }

        [JsonProperty("citations")]
        public AgentExecutionStatusResponseCitationsTypeItem[] Citations { get; set; }

        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgentExecutionStatusResponseStatusType
    {
        PENDING,
        RUNNING,
        COMPLETED,
        FAILED
    }

    public class AgentExecutionStatusResponseCitationsTypeItem
    {
        [JsonProperty("previewUrl")]
        public string PreviewUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetAgentExecutionStatusInput
    {
        [JsonProperty("agentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentId { get; set; }

        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestId { get; set; }
    }

    public class ListLinksV2Response
    {
        [JsonProperty("links")]
        public ListLinksV2ResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }
    }

    public class ListLinksV2ResponseLinksTypeItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("protection")]
        public string Protection { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("resource_id")]
        public string ResourceId { get; set; }

        [JsonProperty("expiry_clicks")]
        public double ExpiryClicks { get; set; }

        [JsonProperty("last_accessed")]
        public string LastAccessed { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }
    }

    public class ListLinksV2Input
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("createdBefore")]
        public string CreatedBefore { get; set; }

        [JsonProperty("createdAfter")]
        public string CreatedAfter { get; set; }

        [JsonProperty("type")]
        public ListLinksV2InputTypeType? Type { get; set; }

        [JsonProperty("accessibility")]
        public ListLinksV2InputAccessibilityType? Accessibility { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListLinksV2InputTypeType
    {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "folder")]
        Folder
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListLinksV2InputAccessibilityType
    {
        [EnumMember(Value = "anyone")]
        Anyone,
        [EnumMember(Value = "password")]
        Password,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "recipients")]
        Recipients
    }

    public class SearchV2Response
    {
        [JsonProperty("results")]
        public SearchV2ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }

    public class SearchV2ResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("snippet_html")]
        public string SnippetHtml { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded_by_username")]
        public string UploadedByUsername { get; set; }

        [JsonProperty("num_versions")]
        public int NumVersions { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("custom_properties")]
        public SearchV2ResponseResultsTypeItemCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class SearchV2ResponseResultsTypeItemCustomPropertiesTypeItem
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SearchV2Input
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("enableAISafeguards", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableAISafeguards { get; set; } = false;

        [JsonProperty("offset")]
        public int? Offset { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("modifiedBefore")]
        public int? ModifiedBefore { get; set; }

        [JsonProperty("modifiedAfter")]
        public int? ModifiedAfter { get; set; }

        [JsonProperty("uploadedBefore")]
        public int? UploadedBefore { get; set; }

        [JsonProperty("uploadedAfter")]
        public int? UploadedAfter { get; set; }

        [JsonProperty("type")]
        public SearchV2InputTypeType? Type { get; set; }

        [JsonProperty("snippetRequested", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SnippetRequested { get; set; } = true;

        [JsonProperty("sortBy")]
        public SearchV2InputSortByType? SortBy { get; set; }

        [JsonProperty("sortDirection")]
        public SearchV2InputSortDirectionType? SortDirection { get; set; }

        [JsonProperty("fileQueryFields")]
        public SearchV2InputFileQueryFieldsTypeItem[] FileQueryFields { get; set; }

        [JsonProperty("folderQueryFields")]
        public SearchV2InputFolderQueryFieldsTypeItem[] FolderQueryFields { get; set; }

        [JsonProperty("queryOperator")]
        public SearchV2InputQueryOperatorType? QueryOperator { get; set; }

        [JsonProperty("mlt")]
        public string[] Mlt { get; set; }

        [JsonProperty("mltt")]
        public string[] Mltt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchV2InputTypeType
    {
        FOLDER,
        FILE,
        ALL
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchV2InputSortByType
    {
        [EnumMember(Value = "last_modified")]
        LastModified,
        [EnumMember(Value = "size")]
        Size,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "score")]
        Score
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchV2InputSortDirectionType
    {
        [EnumMember(Value = "ascending")]
        Ascending,
        [EnumMember(Value = "descending")]
        Descending
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchV2InputFileQueryFieldsTypeItem
    {
        ALL,
        FILENAME,
        COMMENTS,
        CONTENT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchV2InputFolderQueryFieldsTypeItem
    {
        ALL,
        FOLDERNAME,
        DESCRIPTION
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchV2InputQueryOperatorType
    {
        ANY,
        ALL
    }

    public class FileLockedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FileUnlockedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FileUpdatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FileCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class ShareLinkCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class ShareLinkDeletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FileOrFolderPermissionChangeInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FileOrFolderMetadataChangeInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FolderProjectAddedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FolderProjectUnmarkedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class FolderProjectUpdatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WorkflowCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WorkflowCompletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WorkflowApprovalTaskApprovedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WorkflowApprovalTaskRejectedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupUpdatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupDeletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class PollCreatedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCreatedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCreatedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollCreatedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCreatedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCreatedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollDeletedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollDeletedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }
    }

    public class PollDeletedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollDeletedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollDeletedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }
    }

    public class PollDeletedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollRenamedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollRenamedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollRenamedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollRenamedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollRenamedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollRenamedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollMovedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollMovedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollMovedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollMovedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollMovedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollMovedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollCopiedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCopiedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCopiedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("source_group_id")]
        public string SourceGroupId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollCopiedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCopiedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCopiedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Egnyte;

    public partial class WorkflowManagedActions
    {
        public EgnyteActions Egnyte(string connectionId) => new EgnyteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EgnyteTriggers Egnyte(string connectionId) => new EgnyteTriggers(connectionId);
    }
}