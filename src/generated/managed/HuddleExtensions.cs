//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddle
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFormSubmissionAsNewFileResponse> UploadFormSubmissionAsNewFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytextContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(requestBodytextContent, nameof(requestBodytextContent), required: false);
            SourceExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            SourceExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/file/upload/folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodytextContent != null)
                {
                    requestBody["content"] = SourceExpressionConverter.ConvertToken(requestBodytextContent);
                    requestBodypropCount++;
                }

                if (requestBodydescription != null)
                {
                    requestBody["description"] = SourceExpressionConverter.ConvertToken(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodytitle != null)
                {
                    requestBody["title"] = SourceExpressionConverter.ConvertToken(requestBodytitle);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadFormSubmissionAsNewFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<string> GetFile([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/file/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<DeleteFolderResponse> DeleteFolder([WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<Folder> CreateFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodydescription = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: true);
            SourceExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["title"] = SourceExpressionConverter.ConvertToken(requestBodytitle);
                if (requestBodydescription != null)
                {
                    requestBody["description"] = SourceExpressionConverter.ConvertToken(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Folder>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> requestBodyfileContent = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodytitle = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(requestBodyfileContent, nameof(requestBodyfileContent), required: false);
            SourceExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            SourceExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/folder/{0}/upload", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyfileContent != null)
                {
                    requestBody["content"] = SourceExpressionConverter.ConvertToken(requestBodyfileContent);
                    requestBodypropCount++;
                }

                if (requestBodydescription != null)
                {
                    requestBody["description"] = SourceExpressionConverter.ConvertToken(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodytitle != null)
                {
                    requestBody["title"] = SourceExpressionConverter.ConvertToken(requestBodytitle);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<TaskObject> MarkTaskComplete([WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/task/{0}/markComplete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddle")]
        public IBodyWorkflowAction<CreateWorkspaceTaskResponse> CreateWorkspaceTask([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> requestBodytitle, [WorkflowExpression] Func<string> requestBodyassignee = null, [WorkflowExpression] Func<string> requestBodydescription = null, [WorkflowExpression] Func<string> requestBodydueDate = null, [WorkflowExpression] Func<string> requestBodyfileID = null, [WorkflowExpression] Func<string> requestBodytaskID = null, [WorkflowExpression] Func<string> requestBodystatus = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(requestBodytitle, nameof(requestBodytitle), required: true);
            SourceExpression.Validate(requestBodyassignee, nameof(requestBodyassignee), required: false);
            SourceExpression.Validate(requestBodydescription, nameof(requestBodydescription), required: false);
            SourceExpression.Validate(requestBodydueDate, nameof(requestBodydueDate), required: false);
            SourceExpression.Validate(requestBodyfileID, nameof(requestBodyfileID), required: false);
            SourceExpression.Validate(requestBodytaskID, nameof(requestBodytaskID), required: false);
            SourceExpression.Validate(requestBodystatus, nameof(requestBodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/workspace/{0}/task", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyassignee != null)
                {
                    requestBody["assignee"] = SourceExpressionConverter.ConvertToken(requestBodyassignee);
                    requestBodypropCount++;
                }

                if (requestBodydescription != null)
                {
                    requestBody["description"] = SourceExpressionConverter.ConvertToken(requestBodydescription);
                    requestBodypropCount++;
                }

                if (requestBodydueDate != null)
                {
                    requestBody["dueDate"] = SourceExpressionConverter.ConvertToken(requestBodydueDate);
                    requestBodypropCount++;
                }

                if (requestBodyfileID != null)
                {
                    requestBody["fileId"] = SourceExpressionConverter.ConvertToken(requestBodyfileID);
                    requestBodypropCount++;
                }

                if (requestBodytaskID != null)
                {
                    requestBody["id"] = SourceExpressionConverter.ConvertToken(requestBodytaskID);
                    requestBodypropCount++;
                }

                if (requestBodystatus != null)
                {
                    requestBody["status"] = SourceExpressionConverter.ConvertToken(requestBodystatus);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["title"] = SourceExpressionConverter.ConvertToken(requestBodytitle);
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkspaceTaskResponse>(BuildSourceInput);
        }
    }

    public class HuddleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollFolderForFileUploadResponse> PollFolderForFileUpload([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/v2/poll/folder/{0}/upload", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollFolderForFileUploadResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollWorkspaceForNewApprovalResponse> PollWorkspaceForNewApproval([WorkflowExpression] Func<string> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/v2/poll/workspace/{0}/approvals", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollWorkspaceForNewApprovalResponse>(BuildSourceInput, triggerName, recurrence);
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