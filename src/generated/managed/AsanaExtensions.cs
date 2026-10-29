//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asana
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsanaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<AddCommentResponseV2, ApiConnectionActionConfiguration> AddComment(Expression<Func<string>> taskId, Expression<Func<string>> bodydatacomment = null)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_bodydatacomment = WorkflowExpression.Compile(bodydatacomment, nameof(bodydatacomment), required: false);
            return new DeferredBodyAction<AddCommentResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/tasks/{0}/stories", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_bodydatacomment != null)
                {
                    dataObject["text"] = ExpressionConverter.ConvertO(__workflow_bodydatacomment);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddCommentResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2, ApiConnectionActionConfiguration> CompleteTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ProjectResponseV2, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> workspace, Expression<Func<string>> team = null, Expression<Func<string>> projectdataprojectName = null, Expression<Func<string>> projectdatadueDate = null, Expression<Func<bool>> projectdataPublic = null, Expression<Func<projectdataprojectColorInput>> projectdataprojectColor = null, Expression<Func<string>> projectdataprojectNotes = null, Expression<Func<string>> projectdataowner = null, Expression<Func<bool>> projectdataarchive = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_projectdataprojectName = WorkflowExpression.Compile(projectdataprojectName, nameof(projectdataprojectName), required: false);
            var __workflow_projectdatadueDate = WorkflowExpression.Compile(projectdatadueDate, nameof(projectdatadueDate), required: false);
            var __workflow_projectdataPublic = WorkflowExpression.Compile(projectdataPublic, nameof(projectdataPublic), required: false);
            var __workflow_projectdataprojectColor = WorkflowExpression.Compile(projectdataprojectColor, nameof(projectdataprojectColor), required: false);
            var __workflow_projectdataprojectNotes = WorkflowExpression.Compile(projectdataprojectNotes, nameof(projectdataprojectNotes), required: false);
            var __workflow_projectdataowner = WorkflowExpression.Compile(projectdataowner, nameof(projectdataowner), required: false);
            var __workflow_projectdataarchive = WorkflowExpression.Compile(projectdataarchive, nameof(projectdataarchive), required: false);
            return new DeferredBodyAction<ProjectResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                var project = new JObject();
                var projectpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_projectdataprojectName != null)
                {
                    dataObject["name"] = ExpressionConverter.ConvertO(__workflow_projectdataprojectName);
                    dataObjectpropCount++;
                }

                if (__workflow_projectdatadueDate != null)
                {
                    dataObject["due_date"] = ExpressionConverter.ConvertO(__workflow_projectdatadueDate);
                    dataObjectpropCount++;
                }

                if (__workflow_projectdataPublic != null)
                {
                    if (__workflow_projectdataPublic != null)
                    {
                        dataObject["public"] = ExpressionConverter.ConvertO(__workflow_projectdataPublic);
                        dataObjectpropCount++;
                    }

                    dataObjectpropCount++;
                }
                else
                {
                    dataObject["public"] = false;
                    dataObjectpropCount++;
                }

                if (__workflow_projectdataprojectColor != null)
                {
                    dataObject["color"] = ExpressionConverter.ConvertO(__workflow_projectdataprojectColor);
                    dataObjectpropCount++;
                }

                if (__workflow_projectdataprojectNotes != null)
                {
                    dataObject["notes"] = ExpressionConverter.ConvertO(__workflow_projectdataprojectNotes);
                    dataObjectpropCount++;
                }

                if (__workflow_projectdataowner != null)
                {
                    dataObject["owner"] = ExpressionConverter.ConvertO(__workflow_projectdataowner);
                    dataObjectpropCount++;
                }

                if (__workflow_projectdataarchive != null)
                {
                    if (__workflow_projectdataarchive != null)
                    {
                        dataObject["archived"] = ExpressionConverter.ConvertO(__workflow_projectdataarchive);
                        dataObjectpropCount++;
                    }

                    dataObjectpropCount++;
                }
                else
                {
                    dataObject["archived"] = false;
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    project["data"] = dataObject;
                    projectpropCount++;
                }

                if (projectpropCount > 0)
                {
                    callPayload.Body = project;
                }

                return new ApiConnectionAction<ProjectResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> workspace, Expression<Func<string>> projects, Expression<Func<string>> taskdatataskName = null, Expression<Func<string>> taskdataassignee = null, Expression<Func<string>> taskdatadescription = null, Expression<Func<taskdataassigneeStatusInput>> taskdataassigneeStatus = null, Expression<Func<bool>> taskdatacompleted = null, Expression<Func<string>> taskdatadueDate = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: true);
            var __workflow_projects = WorkflowExpression.Compile(projects, nameof(projects), required: true);
            var __workflow_taskdatataskName = WorkflowExpression.Compile(taskdatataskName, nameof(taskdatataskName), required: false);
            var __workflow_taskdataassignee = WorkflowExpression.Compile(taskdataassignee, nameof(taskdataassignee), required: false);
            var __workflow_taskdatadescription = WorkflowExpression.Compile(taskdatadescription, nameof(taskdatadescription), required: false);
            var __workflow_taskdataassigneeStatus = WorkflowExpression.Compile(taskdataassigneeStatus, nameof(taskdataassigneeStatus), required: false);
            var __workflow_taskdatacompleted = WorkflowExpression.Compile(taskdatacompleted, nameof(taskdatacompleted), required: false);
            var __workflow_taskdatadueDate = WorkflowExpression.Compile(taskdatadueDate, nameof(taskdatadueDate), required: false);
            return new DeferredBodyAction<TaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                callPayload.Queries["projects"] = ExpressionConverter.Convert(__workflow_projects);
                var task = new JObject();
                var taskpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_taskdatataskName != null)
                {
                    dataObject["name"] = ExpressionConverter.ConvertO(__workflow_taskdatataskName);
                    dataObjectpropCount++;
                }

                if (__workflow_taskdataassignee != null)
                {
                    dataObject["assignee"] = ExpressionConverter.ConvertO(__workflow_taskdataassignee);
                    dataObjectpropCount++;
                }

                if (__workflow_taskdatadescription != null)
                {
                    dataObject["notes"] = ExpressionConverter.ConvertO(__workflow_taskdatadescription);
                    dataObjectpropCount++;
                }

                if (__workflow_taskdataassigneeStatus != null)
                {
                    dataObject["assignee_status"] = ExpressionConverter.ConvertO(__workflow_taskdataassigneeStatus);
                    dataObjectpropCount++;
                }

                if (__workflow_taskdatacompleted != null)
                {
                    if (__workflow_taskdatacompleted != null)
                    {
                        dataObject["completed"] = ExpressionConverter.ConvertO(__workflow_taskdatacompleted);
                        dataObjectpropCount++;
                    }

                    dataObjectpropCount++;
                }
                else
                {
                    dataObject["completed"] = false;
                    dataObjectpropCount++;
                }

                if (__workflow_taskdatadueDate != null)
                {
                    dataObject["due_on"] = ExpressionConverter.ConvertO(__workflow_taskdatadueDate);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    task["data"] = dataObject;
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<TaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ProjectResponseV2, ApiConnectionActionConfiguration> GetProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<UserResponseV2, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ListUsersResponseV2, ApiConnectionActionConfiguration> ListUsers(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<ListUsersResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/workspaces/{0}/users", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ListTeamsResponseV2, ApiConnectionActionConfiguration> ListWorkspaceTeams(Expression<Func<string>> workspace)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: true);
            return new DeferredBodyAction<ListTeamsResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/organizations/{0}/teams", __workflow_workspace.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTeamsResponseV2>(callPayload);
            });
        }
    }

    public class AsanaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListProjectsResponseV2, ApiConnectionTriggerConfiguration> OnProjectCreated(Expression<Func<string>> workspace, FlowRecurrence recurrence = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: true);
            return new DeferredBodyTrigger<ListProjectsResponseV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/new_project_trigger/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                return new ApiConnectionTrigger<ListProjectsResponseV2>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration> OnTaskCompleted(Expression<Func<string>> workspace, Expression<Func<string>> project, FlowRecurrence recurrence = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/complete_task_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration> OnTaskCreated(Expression<Func<string>> workspace, Expression<Func<string>> project, FlowRecurrence recurrence = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/new_task_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddCommentResponseV2
    {
        [JsonProperty("data")]
        public AddCommentResponseV2DataType Data { get; set; }
    }

    public class AddCommentResponseV2DataType
    {
        [JsonProperty("target")]
        public TargetV2 Target { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_at")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public CreatedByV2 CreatedBy { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gid")]
        public string CommentId { get; set; }
    }

    public class TargetV2
    {
        [JsonProperty("gid")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreatedByV2
    {
        [JsonProperty("gid")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TaskResponseV2
    {
        [JsonProperty("gid")]
        public string TaskId { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WorkSpaceV2
    {
        [JsonProperty("gid")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectResponseV2
    {
        [JsonProperty("gid")]
        public string ProjectId { get; set; }

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
        public string Id { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum projectdataprojectColorInput
    {
        [EnumMember(Value = "dark-pink")]
        DarkPink,
        [EnumMember(Value = "dark-green")]
        DarkGreen,
        [EnumMember(Value = "dark-blue")]
        DarkBlue,
        [EnumMember(Value = "dark-red")]
        DarkRed,
        [EnumMember(Value = "dark-teal")]
        DarkTeal,
        [EnumMember(Value = "dark-brown")]
        DarkBrown,
        [EnumMember(Value = "dark-orange")]
        DarkOrange,
        [EnumMember(Value = "dark-purple")]
        DarkPurple,
        [EnumMember(Value = "dark-warm-gray")]
        DarkWarmGray,
        [EnumMember(Value = "light-pink")]
        LightPink,
        [EnumMember(Value = "light-green")]
        LightGreen,
        [EnumMember(Value = "light-blue")]
        LightBlue,
        [EnumMember(Value = "light-red")]
        LightRed,
        [EnumMember(Value = "light-teal")]
        LightTeal,
        [EnumMember(Value = "light-yellow")]
        LightYellow,
        [EnumMember(Value = "light-orange")]
        LightOrange,
        [EnumMember(Value = "light-purple")]
        LightPurple,
        [EnumMember(Value = "light-warm-gray")]
        LightWarmGray
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum taskdataassigneeStatusInput
    {
        Inbox,
        Later,
        Today,
        Upcoming
    }

    public class UserResponseV2
    {
        [JsonProperty("gid")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ListUsersResponseV2
    {
        [JsonProperty("data")]
        public UserResponseV2[] Users { get; set; }
    }

    public class ListTeamsResponseV2
    {
        [JsonProperty("data")]
        public ListTeamsResponseV2DataTypeItem[] Data { get; set; }
    }

    public class ListTeamsResponseV2DataTypeItem
    {
        [JsonProperty("gid")]
        public string TeamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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

namespace Microsoft.Azure.Workflows.Sdk
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