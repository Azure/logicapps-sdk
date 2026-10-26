//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddle
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse, ApiConnectionActionConfiguration> UploadFormSubmissionAsNewFile(Expression<Func<string>> workspaceId, Expression<Func<string>> folderId, Expression<Func<UploadFormSubmissionAsNewFileInput>> requestBody = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<UploadFormSubmissionAsNewFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/file/upload/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<UploadFormSubmissionAsNewFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/file/{0}", __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<DeleteFolderResponse, ApiConnectionActionConfiguration> DeleteFolder(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<DeleteFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<Folder, ApiConnectionActionConfiguration> CreateFolder(Expression<Func<string>> folderId, Expression<Func<CreateFolderInput>> requestBody = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<Folder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<Folder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFileResponse, ApiConnectionActionConfiguration> UploadFile(Expression<Func<string>> workspaceId, Expression<Func<string>> folderId, Expression<Func<UploadFileInput>> requestBody = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<UploadFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/folder/{0}/upload", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<UploadFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> MarkTaskComplete(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/task/{0}/markComplete", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse, ApiConnectionActionConfiguration> CreateWorkspaceTask(Expression<Func<string>> workspaceId, Expression<Func<CreateWorkspaceTaskInput>> requestBody = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<CreateWorkspaceTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/workspace/{0}/task", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<CreateWorkspaceTaskResponse>(callPayload);
            });
        }
    }

    public class HuddleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse, ApiConnectionTriggerConfiguration> PollFolderForFileUpload(Expression<Func<string>> workspaceId, Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<PollFolderForFileUploadResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/v2/poll/folder/{0}/upload", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionTrigger<PollFolderForFileUploadResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse, ApiConnectionTriggerConfiguration> PollWorkspaceForNewApproval(Expression<Func<string>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<PollWorkspaceForNewApprovalResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/v2/poll/workspace/{0}/approvals", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PollWorkspaceForNewApprovalResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UploadFormSubmissionAsNewFileResponse
    {
        [JsonProperty("file")]
        public File File { get; set; }
    }

    public class File
    {
        [JsonProperty("contentType")]
        public string Type { get; set; }

        [JsonProperty("created")]
        public string FileCreated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("id")]
        public string FileId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
    }

    public class UploadFormSubmissionAsNewFileInput
    {
        [JsonProperty("content")]
        public string TextContent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class DeleteFolderResponse
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class Folder
    {
        [JsonProperty("children")]
        public JToken[] ChildFoldersSubfolders { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("files")]
        public File[] Files { get; set; }

        [JsonProperty("id")]
        public string FolderId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateFolderInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UploadFileResponse
    {
        [JsonProperty("file")]
        public File File { get; set; }
    }

    public class UploadFileInput
    {
        [JsonProperty("content")]
        public string FileContent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
    }

    public class CreateWorkspaceTaskResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateWorkspaceTaskInput
    {
        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
    }

    public class PollFolderForFileUploadResponse
    {
        [JsonProperty("files")]
        public UploadFileTriggerOutput[] Files { get; set; }
    }

    public class UploadFileTriggerOutput
    {
        [JsonProperty("created")]
        public string FileCreated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("id")]
        public string FileId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
    }

    public class PollWorkspaceForNewApprovalResponse
    {
        [JsonProperty("approvals")]
        public NewApprovalTriggerOutput[] Approvals { get; set; }
    }

    public class NewApprovalTriggerOutput
    {
        [JsonProperty("assignees")]
        public Assignee[] ApprovalAssignees { get; set; }

        [JsonProperty("assignerName")]
        public string ApprovalRequesterName { get; set; }

        [JsonProperty("assignerEmail")]
        public string ApprovalRequesterEmail { get; set; }

        [JsonProperty("ownerName")]
        public string ApprovalTaskOwnerName { get; set; }

        [JsonProperty("ownerEmail")]
        public string ApprovalTaskOwnerEmail { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("created")]
        public string CreatedDate { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("fileTitle")]
        public string FileTitle { get; set; }

        [JsonProperty("id")]
        public string ApprovalTaskId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string TaskType { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspaceName")]
        public string WorkspaceName { get; set; }
    }

    public class Assignee
    {
        [JsonProperty("name")]
        public string AssigneeName { get; set; }

        [JsonProperty("email")]
        public string AssigneeEmail { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huddle;

    public partial class WorkflowManagedActions
    {
        public HuddleActions Huddle(string connectionId) => new HuddleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuddleTriggers Huddle(string connectionId) => new HuddleTriggers(connectionId);
    }
}