//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asana
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsanaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ListTeamsResponseV2> ListWorkspaceTeamsV2(Expression<Func<string>> workspace)
        {
            var apiCallPath = String.Format("/v2/organizations/{0}/teams", ExpressionConverter.ConvertWithUrlEncoding(workspace, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTeamsResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ProjectResponseV2> GetProjectV2(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/v2/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2> GetTaskV2(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/v2/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2> CompleteTaskV2(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/v2/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ListUsersResponseV2> ListUsersV2(Expression<Func<string>> workspaceId)
        {
            var apiCallPath = String.Format("/v2/workspaces/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListUsersResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<UserResponseV2> GetUserV2(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/v2/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponseV2>(callPayload);
        }
    }

    public class AsanaTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ListProjectsResponseV2> OnProjectCreatedV2(Expression<Func<string>> workspace)
        {
            var apiCallPath = "/v2/new_project_trigger/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
            return new ApiConnectionTrigger<ListProjectsResponseV2>(callPayload);
        }

        public IOutputWorkflowTrigger<ListTasksResponseV2> OnTaskCreatedV2(Expression<Func<string>> workspace, Expression<Func<string>> project)
        {
            var apiCallPath = "/v2/new_task_trigger/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload);
        }

        public IOutputWorkflowTrigger<ListTasksResponseV2> OnTaskCompletedV2(Expression<Func<string>> workspace, Expression<Func<string>> project)
        {
            var apiCallPath = "/v2/complete_task_trigger/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload);
        }
    }

    public class ListTeamsResponseV2
    {
        [JsonProperty("data")]
        public ListTeamsResponseV2DataTypeItem[] Data { get; set; }
    }

    public class ListTeamsResponseV2DataTypeItem
    {
        [JsonProperty("gid")]
        public string TeamID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectResponseV2
    {
        [JsonProperty("gid")]
        public string ProjectID { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("notes")]
        public string ProjectNotes { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("modified_at")]
        public string ModifiedDate { get; set; }

        [JsonProperty("owner")]
        public OwnerV2 Owner { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("current_status")]
        public CurrentStatusV2 CurrentStatus { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("workspace")]
        public WorkSpaceV2 Workspace { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class OwnerV2
    {
        [JsonProperty("gid")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CurrentStatusV2
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("author")]
        public CurrentStatusV2AuthorType Author { get; set; }
    }

    public class CurrentStatusV2AuthorType
    {
        [JsonProperty("gid")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WorkSpaceV2
    {
        [JsonProperty("gid")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TaskResponseV2
    {
        [JsonProperty("gid")]
        public string TaskID { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("modified_at")]
        public string ModifiedDate { get; set; }

        [JsonProperty("name")]
        public string TaskName { get; set; }

        [JsonProperty("notes")]
        public string TaskNotes { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("assignee")]
        public AssigneeV2 Assignee { get; set; }

        [JsonProperty("assignee_status")]
        public string AsigneeStatus { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedDateAndTime { get; set; }

        [JsonProperty("due_on")]
        public string DueDate { get; set; }

        [JsonProperty("due_at")]
        public string DueDateAndTime { get; set; }

        [JsonProperty("workspace")]
        public WorkSpaceV2 Workspace { get; set; }

        [JsonProperty("num_hearts")]
        public int NumberOfLikes { get; set; }

        [JsonProperty("permalink_url")]
        public string PermanentUrl { get; set; }

        [JsonProperty("hearted")]
        public bool Liked { get; set; }
    }

    public class AssigneeV2
    {
        [JsonProperty("gid")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListUsersResponseV2
    {
        [JsonProperty("data")]
        public UserResponseV2[] Users { get; set; }
    }

    public class UserResponseV2
    {
        [JsonProperty("gid")]
        public string UserID { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ListProjectsResponseV2
    {
        [JsonProperty("data")]
        public ProjectResponseV2[] Projects { get; set; }
    }

    public class ListTasksResponseV2
    {
        [JsonProperty("data")]
        public TaskResponseV2[] Tasks { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asana;

    public partial class WorkflowManagedActions
    {
        public AsanaActions Asana(string connectionId) => new AsanaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsanaTriggers Asana(string connectionId) => new AsanaTriggers(connectionId);
    }
}