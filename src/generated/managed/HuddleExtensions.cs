//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddle
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddleActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFormSubmissionAsNewFile))]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> UploadFormSubmissionAsNewFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytextContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> __BuildUploadFormSubmissionAsNewFile(WorkflowExpression<string> workspaceId, WorkflowExpression<string> folderId, WorkflowExpression<string> requestBodytextContent = null, WorkflowExpression<string> requestBodydescription = null, WorkflowExpression<string> requestBodytitle = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(requestBodytextContent, nameof(requestBodytextContent), required: false);
            WorkflowExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            WorkflowExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: false);
            return new DeferredBodyAction<UploadFormSubmissionAsNewFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/file/upload/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodytextContent != null)
                {
                    requestBody["content"] = ExpressionConverter.ConvertO(requestBodytextContent);
                    requestBodypropCount++;
                }

                if (requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodytitle != null)
                {
                    requestBody["title"] = ExpressionConverter.ConvertO(requestBodytitle);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFile))]
        public IBodyWorkflowAction<string> GetFile([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFile(WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/file/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFolder))]
        public IBodyWorkflowAction<DeleteFolderResponse> DeleteFolder([WorkflowExpression] Func<string> folderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteFolderResponse> __BuildDeleteFolder(WorkflowExpression<string> folderId)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<DeleteFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<Folder> CreateFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Folder> __BuildCreateFolder(WorkflowExpression<string> folderId, WorkflowExpression<string> requestBodytitle, WorkflowExpression<string> requestBodydescription = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: true);
            WorkflowExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            return new DeferredBodyAction<Folder>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["title"] = ExpressionConverter.ConvertO(requestBodytitle);
                if (requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
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
        [WorkflowExpressionFactory(nameof(__BuildUploadFile))]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodyfileContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFileResponse> __BuildUploadFile(WorkflowExpression<string> workspaceId, WorkflowExpression<string> folderId, WorkflowExpression<string> requestBodyfileContent = null, WorkflowExpression<string> requestBodydescription = null, WorkflowExpression<string> requestBodytitle = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(requestBodyfileContent, nameof(requestBodyfileContent), required: false);
            WorkflowExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            WorkflowExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: false);
            return new DeferredBodyAction<UploadFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}/upload", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyfileContent != null)
                {
                    requestBody["content"] = ExpressionConverter.ConvertO(requestBodyfileContent);
                    requestBodypropCount++;
                }

                if (requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodytitle != null)
                {
                    requestBody["title"] = ExpressionConverter.ConvertO(requestBodytitle);
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
        [WorkflowExpressionFactory(nameof(__BuildMarkTaskComplete))]
        public IBodyWorkflowAction<TaskObject> MarkTaskComplete([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildMarkTaskComplete(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/task/{0}/markComplete", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceTask))]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> CreateWorkspaceTask([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodyassignee = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodydueDate = null, [WorkflowExpression] Func<string> requestBodyfileID = null, [WorkflowExpression] Func<string> requestBodytaskID = null, [WorkflowExpression] Func<string> requestBodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> __BuildCreateWorkspaceTask(WorkflowExpression<string> workspaceId, WorkflowExpression<string> requestBodytitle, WorkflowExpression<string> requestBodyassignee = null, WorkflowExpression<string> requestBodydescription = null, WorkflowExpression<string> requestBodydueDate = null, WorkflowExpression<string> requestBodyfileID = null, WorkflowExpression<string> requestBodytaskID = null, WorkflowExpression<string> requestBodystatus = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: true);
            WorkflowExpression.Validate(requestBodyassignee, nameof(requestBodyassignee), required: false);
            WorkflowExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            WorkflowExpression.Validate(requestBodydueDate, nameof(requestBodydueDate), required: false);
            WorkflowExpression.Validate(requestBodyfileID, nameof(requestBodyfileID), required: false);
            WorkflowExpression.Validate(requestBodytaskID, nameof(requestBodytaskID), required: false);
            WorkflowExpression.Validate(requestBodystatus, nameof(requestBodystatus), required: false);
            return new DeferredBodyAction<CreateWorkspaceTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workspace/{0}/task", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyassignee != null)
                {
                    requestBody["assignee"] = ExpressionConverter.ConvertO(requestBodyassignee);
                    requestBodypropCount++;
                }

                if (requestBodydescription != null)
                {
                    requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodydueDate != null)
                {
                    requestBody["dueDate"] = ExpressionConverter.ConvertO(requestBodydueDate);
                    requestBodypropCount++;
                }

                if (requestBodyfileID != null)
                {
                    requestBody["fileId"] = ExpressionConverter.ConvertO(requestBodyfileID);
                    requestBodypropCount++;
                }

                if (requestBodytaskID != null)
                {
                    requestBody["id"] = ExpressionConverter.ConvertO(requestBodytaskID);
                    requestBodypropCount++;
                }

                if (requestBodystatus != null)
                {
                    requestBody["status"] = ExpressionConverter.ConvertO(requestBodystatus);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["title"] = ExpressionConverter.ConvertO(requestBodytitle);
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

        [WorkflowExpressionFactory(nameof(__BuildPollFolderForFileUpload))]
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> PollFolderForFileUpload([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> __BuildPollFolderForFileUpload(WorkflowExpression<string> workspaceId, WorkflowExpression<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<PollFolderForFileUploadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v2/poll/folder/{0}/upload", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                return new ApiConnectionTrigger<PollFolderForFileUploadResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildPollWorkspaceForNewApproval))]
        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse> PollWorkspaceForNewApproval([WorkflowExpression] Func<string> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse> __BuildPollWorkspaceForNewApproval(WorkflowExpression<string> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<PollWorkspaceForNewApprovalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v2/poll/workspace/{0}/approvals", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PollWorkspaceForNewApprovalResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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