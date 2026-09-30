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
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> UploadFormSubmissionAsNewFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytextContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            var apiCallPath = String.Format("/v2/file/upload/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<string> GetFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> fileId)
        {
            var apiCallPath = String.Format("/v2/file/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<DeleteFolderResponse> DeleteFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> folderId)
        {
            var apiCallPath = String.Format("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<Folder> CreateFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodydescription = null)
        {
            var apiCallPath = String.Format("/v2/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodyfileContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            var apiCallPath = String.Format("/v2/folder/{0}/upload", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<TaskObject> MarkTaskComplete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> taskId)
        {
            var apiCallPath = String.Format("/v2/task/{0}/markComplete", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> CreateWorkspaceTask([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodyassignee = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodydueDate = null, [WorkflowExpression] Func<string> requestBodyfileID = null, [WorkflowExpression] Func<string> requestBodytaskID = null, [WorkflowExpression] Func<string> requestBodystatus = null)
        {
            var apiCallPath = String.Format("/v2/workspace/{0}/task", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
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
        }
    }

    public class HuddleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> PollFolderForFileUpload([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/v2/poll/folder/{0}/upload", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionTrigger<PollFolderForFileUploadResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse> PollWorkspaceForNewApproval([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/v2/poll/workspace/{0}/approvals", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PollWorkspaceForNewApprovalResponse>(callPayload, triggerName, recurrence);
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