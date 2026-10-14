//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddle
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HuddleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> UploadFormSubmissionAsNewFile(Expression<Func<string>> workspaceId, Expression<Func<string>> folderId, Expression<Func<string>> requestBodytextContent = null, Expression<Func<string>> requestBodydescription = null, Expression<Func<string>> requestBodytitle = null)
        {
            var __workflow_workspaceId = workspaceId == null ? null : WorkflowExpression.Compile(workspaceId);
            WorkflowExpression.Validate(__workflow_workspaceId, nameof(workspaceId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_requestBodytextContent = requestBodytextContent == null ? null : WorkflowExpression.Compile(requestBodytextContent);
            WorkflowExpression.Validate(__workflow_requestBodytextContent, nameof(requestBodytextContent), required: false);
            var __workflow_requestBodydescription = requestBodydescription == null ? null : WorkflowExpression.Compile(requestBodydescription);
            WorkflowExpression.Validate(__workflow_requestBodydescription, nameof(requestBodydescription), required: false);
            var __workflow_requestBodytitle = requestBodytitle == null ? null : WorkflowExpression.Compile(requestBodytitle);
            WorkflowExpression.Validate(__workflow_requestBodytitle, nameof(requestBodytitle), required: false);
            return new DeferredBodyAction<UploadFormSubmissionAsNewFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/file/upload/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodytextContent != null)
                {
                    requestBody["content"] = ExpressionConverter.ConvertO(__workflow_requestBodytextContent);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(__workflow_requestBodydescription);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytitle != null)
                {
                    requestBody["title"] = ExpressionConverter.ConvertO(__workflow_requestBodytitle);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<UploadFormSubmissionAsNewFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<string> GetFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/file/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<DeleteFolderResponse> DeleteFolder(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<DeleteFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<Folder> CreateFolder(Expression<Func<string>> folderId, Expression<Func<string>> requestBodytitle, Expression<Func<string>> requestBodydescription = null)
        {
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_requestBodytitle = requestBodytitle == null ? null : WorkflowExpression.Compile(requestBodytitle);
            WorkflowExpression.Validate(__workflow_requestBodytitle, nameof(requestBodytitle), required: true);
            var __workflow_requestBodydescription = requestBodydescription == null ? null : WorkflowExpression.Compile(requestBodydescription);
            WorkflowExpression.Validate(__workflow_requestBodydescription, nameof(requestBodydescription), required: false);
            return new DeferredBodyAction<Folder>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["title"] = ExpressionConverter.ConvertO(__workflow_requestBodytitle);
                if (__workflow_requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(__workflow_requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<Folder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile(Expression<Func<string>> workspaceId, Expression<Func<string>> folderId, Expression<Func<string>> requestBodyfileContent = null, Expression<Func<string>> requestBodydescription = null, Expression<Func<string>> requestBodytitle = null)
        {
            var __workflow_workspaceId = workspaceId == null ? null : WorkflowExpression.Compile(workspaceId);
            WorkflowExpression.Validate(__workflow_workspaceId, nameof(workspaceId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_requestBodyfileContent = requestBodyfileContent == null ? null : WorkflowExpression.Compile(requestBodyfileContent);
            WorkflowExpression.Validate(__workflow_requestBodyfileContent, nameof(requestBodyfileContent), required: false);
            var __workflow_requestBodydescription = requestBodydescription == null ? null : WorkflowExpression.Compile(requestBodydescription);
            WorkflowExpression.Validate(__workflow_requestBodydescription, nameof(requestBodydescription), required: false);
            var __workflow_requestBodytitle = requestBodytitle == null ? null : WorkflowExpression.Compile(requestBodytitle);
            WorkflowExpression.Validate(__workflow_requestBodytitle, nameof(requestBodytitle), required: false);
            return new DeferredBodyAction<UploadFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}/upload", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodyfileContent != null)
                {
                    requestBody["content"] = ExpressionConverter.ConvertO(__workflow_requestBodyfileContent);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(__workflow_requestBodydescription);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytitle != null)
                {
                    requestBody["title"] = ExpressionConverter.ConvertO(__workflow_requestBodytitle);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<UploadFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<TaskObject> MarkTaskComplete(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/task/{0}/markComplete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> CreateWorkspaceTask(Expression<Func<string>> workspaceId, Expression<Func<string>> requestBodytitle, Expression<Func<string>> requestBodyassignee = null, Expression<Func<string>> requestBodydescription = null, Expression<Func<string>> requestBodydueDate = null, Expression<Func<string>> requestBodyfileID = null, Expression<Func<string>> requestBodytaskID = null, Expression<Func<string>> requestBodystatus = null)
        {
            var __workflow_workspaceId = workspaceId == null ? null : WorkflowExpression.Compile(workspaceId);
            WorkflowExpression.Validate(__workflow_workspaceId, nameof(workspaceId), required: true);
            var __workflow_requestBodytitle = requestBodytitle == null ? null : WorkflowExpression.Compile(requestBodytitle);
            WorkflowExpression.Validate(__workflow_requestBodytitle, nameof(requestBodytitle), required: true);
            var __workflow_requestBodyassignee = requestBodyassignee == null ? null : WorkflowExpression.Compile(requestBodyassignee);
            WorkflowExpression.Validate(__workflow_requestBodyassignee, nameof(requestBodyassignee), required: false);
            var __workflow_requestBodydescription = requestBodydescription == null ? null : WorkflowExpression.Compile(requestBodydescription);
            WorkflowExpression.Validate(__workflow_requestBodydescription, nameof(requestBodydescription), required: false);
            var __workflow_requestBodydueDate = requestBodydueDate == null ? null : WorkflowExpression.Compile(requestBodydueDate);
            WorkflowExpression.Validate(__workflow_requestBodydueDate, nameof(requestBodydueDate), required: false);
            var __workflow_requestBodyfileID = requestBodyfileID == null ? null : WorkflowExpression.Compile(requestBodyfileID);
            WorkflowExpression.Validate(__workflow_requestBodyfileID, nameof(requestBodyfileID), required: false);
            var __workflow_requestBodytaskID = requestBodytaskID == null ? null : WorkflowExpression.Compile(requestBodytaskID);
            WorkflowExpression.Validate(__workflow_requestBodytaskID, nameof(requestBodytaskID), required: false);
            var __workflow_requestBodystatus = requestBodystatus == null ? null : WorkflowExpression.Compile(requestBodystatus);
            WorkflowExpression.Validate(__workflow_requestBodystatus, nameof(requestBodystatus), required: false);
            return new DeferredBodyAction<CreateWorkspaceTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workspace/{0}/task", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodyassignee != null)
                {
                    requestBody["assignee"] = ExpressionConverter.ConvertO(__workflow_requestBodyassignee);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(__workflow_requestBodydescription);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydueDate != null)
                {
                    requestBody["dueDate"] = ExpressionConverter.ConvertO(__workflow_requestBodydueDate);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyfileID != null)
                {
                    requestBody["fileId"] = ExpressionConverter.ConvertO(__workflow_requestBodyfileID);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytaskID != null)
                {
                    requestBody["id"] = ExpressionConverter.ConvertO(__workflow_requestBodytaskID);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodystatus != null)
                {
                    requestBody["status"] = ExpressionConverter.ConvertO(__workflow_requestBodystatus);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["title"] = ExpressionConverter.ConvertO(__workflow_requestBodytitle);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<CreateWorkspaceTaskResponse>(callPayload);
            });
        }
    }

    public class HuddleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> PollFolderForFileUpload(Expression<Func<string>> workspaceId, Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = workspaceId == null ? null : WorkflowExpression.Compile(workspaceId);
            WorkflowExpression.Validate(__workflow_workspaceId, nameof(workspaceId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<PollFolderForFileUploadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v2/poll/folder/{0}/upload", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionTrigger<PollFolderForFileUploadResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse> PollWorkspaceForNewApproval(Expression<Func<string>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = workspaceId == null ? null : WorkflowExpression.Compile(workspaceId);
            WorkflowExpression.Validate(__workflow_workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<PollWorkspaceForNewApprovalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v2/poll/workspace/{0}/approvals", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceId, 1));
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
        public string FolderID { get; set; }

        [JsonProperty("id")]
        public string FileID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceID { get; set; }
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
        public string FolderID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class UploadFileResponse
    {
        [JsonProperty("file")]
        public File File { get; set; }
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
        public string FileID { get; set; }

        [JsonProperty("id")]
        public string TaskID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceID { get; set; }
    }

    public class CreateWorkspaceTaskResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        public string FolderID { get; set; }

        [JsonProperty("id")]
        public string FileID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceID { get; set; }
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
        public string FileID { get; set; }

        [JsonProperty("fileTitle")]
        public string FileTitle { get; set; }

        [JsonProperty("id")]
        public string ApprovalTaskID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string TaskType { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceID { get; set; }

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
