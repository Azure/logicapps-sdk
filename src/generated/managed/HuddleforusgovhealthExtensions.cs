//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddleforusgovhealth
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddleforusgovhealthActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFormSubmissionAsNewFile))]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> UploadFormSubmissionAsNewFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytextContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> __BuildUploadFormSubmissionAsNewFile(WorkflowValue<string> workspaceId, WorkflowValue<string> folderId, WorkflowValue<string> requestBodytextContent = null, WorkflowValue<string> requestBodydescription = null, WorkflowValue<string> requestBodytitle = null)
        {
            WorkflowValue.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(requestBodytextContent, nameof(requestBodytextContent), required: false);
            WorkflowValue.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            WorkflowValue.Validate(requestBodytitle, nameof(requestBodytitle), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildGetFile))]
        public IBodyWorkflowAction<string> GetFile([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFile(WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/file/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFolder))]
        public IBodyWorkflowAction<DeleteFolderResponse> DeleteFolder([WorkflowExpression] Func<string> folderId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteFolderResponse> __BuildDeleteFolder(WorkflowValue<string> folderId)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<DeleteFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<Folder> CreateFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodydescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Folder> __BuildCreateFolder(WorkflowValue<string> folderId, WorkflowValue<string> requestBodytitle, WorkflowValue<string> requestBodydescription = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(requestBodytitle, nameof(requestBodytitle), required: true);
            WorkflowValue.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFile))]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodyfileContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFileResponse> __BuildUploadFile(WorkflowValue<string> workspaceId, WorkflowValue<string> folderId, WorkflowValue<string> requestBodyfileContent = null, WorkflowValue<string> requestBodydescription = null, WorkflowValue<string> requestBodytitle = null)
        {
            WorkflowValue.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(requestBodyfileContent, nameof(requestBodyfileContent), required: false);
            WorkflowValue.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            WorkflowValue.Validate(requestBodytitle, nameof(requestBodytitle), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildMarkTaskComplete))]
        public IBodyWorkflowAction<TaskObject> MarkTaskComplete([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildMarkTaskComplete(WorkflowValue<string> taskId)
        {
            WorkflowValue.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/task/{0}/markComplete", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddleforusgovhealth")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceTask))]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> CreateWorkspaceTask([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodyassignee = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodydueDate = null, [WorkflowExpression] Func<string> requestBodyfileID = null, [WorkflowExpression] Func<string> requestBodytaskID = null, [WorkflowExpression] Func<string> requestBodystatus = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> __BuildCreateWorkspaceTask(WorkflowValue<string> workspaceId, WorkflowValue<string> requestBodytitle, WorkflowValue<string> requestBodyassignee = null, WorkflowValue<string> requestBodydescription = null, WorkflowValue<string> requestBodydueDate = null, WorkflowValue<string> requestBodyfileID = null, WorkflowValue<string> requestBodytaskID = null, WorkflowValue<string> requestBodystatus = null)
        {
            WorkflowValue.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowValue.Validate(requestBodytitle, nameof(requestBodytitle), required: true);
            WorkflowValue.Validate(requestBodyassignee, nameof(requestBodyassignee), required: false);
            WorkflowValue.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            WorkflowValue.Validate(requestBodydueDate, nameof(requestBodydueDate), required: false);
            WorkflowValue.Validate(requestBodyfileID, nameof(requestBodyfileID), required: false);
            WorkflowValue.Validate(requestBodytaskID, nameof(requestBodytaskID), required: false);
            WorkflowValue.Validate(requestBodystatus, nameof(requestBodystatus), required: false);
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

    public class HuddleforusgovhealthTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildPollFolderForFileUpload))]
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> PollFolderForFileUpload([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> __BuildPollFolderForFileUpload(WorkflowValue<string> workspaceId, WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse> __BuildPollWorkspaceForNewApproval(WorkflowValue<string> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(workspaceId, nameof(workspaceId), required: true);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huddleforusgovhealth;

    public partial class WorkflowManagedActions
    {
        public HuddleforusgovhealthActions Huddleforusgovhealth(string connectionId) => new HuddleforusgovhealthActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuddleforusgovhealthTriggers Huddleforusgovhealth(string connectionId) => new HuddleforusgovhealthTriggers(connectionId);
    }
}
