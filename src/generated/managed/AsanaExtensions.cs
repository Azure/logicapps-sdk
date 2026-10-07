//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asana
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsanaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [WorkflowExpressionFactory(nameof(__BuildAddComment))]
        public IBodyWorkflowAction<AddCommentResponseV2> AddComment([WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodydatacomment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddCommentResponseV2> __BuildAddComment(WorkflowExpression<string> taskId, WorkflowExpression<string> bodydatacomment = null)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            WorkflowExpression.Validate(bodydatacomment, nameof(bodydatacomment), required: false);
            return new DeferredBodyAction<AddCommentResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/tasks/{0}/stories", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatacomment != null)
                {
                    dataObject["text"] = ExpressionConverter.ConvertO(bodydatacomment);
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
        [WorkflowExpressionFactory(nameof(__BuildCompleteTask))]
        public IBodyWorkflowAction<TaskResponseV2> CompleteTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskResponseV2> __BuildCompleteTask(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<ProjectResponseV2> CreateProject([WorkflowExpression] Func<string> workspace, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> projectdataprojectName = null, [WorkflowExpression] Func<string> projectdatadueDate = null, [WorkflowExpression] Func<bool> projectdatapublic = null, [WorkflowExpression] Func<projectdataprojectColorInput> projectdataprojectColor = null, [WorkflowExpression] Func<string> projectdataprojectNotes = null, [WorkflowExpression] Func<string> projectdataowner = null, [WorkflowExpression] Func<bool> projectdataarchive = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectResponseV2> __BuildCreateProject(WorkflowExpression<string> workspace, WorkflowExpression<string> team = null, WorkflowExpression<string> projectdataprojectName = null, WorkflowExpression<string> projectdatadueDate = null, WorkflowExpression<bool> projectdatapublic = null, WorkflowExpression<projectdataprojectColorInput> projectdataprojectColor = null, WorkflowExpression<string> projectdataprojectNotes = null, WorkflowExpression<string> projectdataowner = null, WorkflowExpression<bool> projectdataarchive = null)
        {
            WorkflowExpression.Validate(workspace, nameof(workspace), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: false);
            WorkflowExpression.Validate(projectdataprojectName, nameof(projectdataprojectName), required: false);
            WorkflowExpression.Validate(projectdatadueDate, nameof(projectdatadueDate), required: false);
            WorkflowExpression.Validate(projectdatapublic, nameof(projectdatapublic), required: false);
            WorkflowExpression.Validate(projectdataprojectColor, nameof(projectdataprojectColor), required: false);
            WorkflowExpression.Validate(projectdataprojectNotes, nameof(projectdataprojectNotes), required: false);
            WorkflowExpression.Validate(projectdataowner, nameof(projectdataowner), required: false);
            WorkflowExpression.Validate(projectdataarchive, nameof(projectdataarchive), required: false);
            return new DeferredBodyAction<ProjectResponseV2>(() =>
            {
                var apiCallPath = "/v2/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
                if (team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                var project = new JObject();
                var projectpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (projectdataprojectName != null)
                {
                    dataObject["name"] = ExpressionConverter.ConvertO(projectdataprojectName);
                    dataObjectpropCount++;
                }

                if (projectdatadueDate != null)
                {
                    dataObject["due_date"] = ExpressionConverter.ConvertO(projectdatadueDate);
                    dataObjectpropCount++;
                }

                if (projectdatapublic != null)
                {
                    if (projectdatapublic != null)
                    {
                        dataObject["public"] = ExpressionConverter.ConvertO(projectdatapublic);
                        dataObjectpropCount++;
                    }

                    dataObjectpropCount++;
                }
                else
                {
                    dataObject["public"] = false;
                    dataObjectpropCount++;
                }

                if (projectdataprojectColor != null)
                {
                    dataObject["color"] = ExpressionConverter.ConvertO(projectdataprojectColor);
                    dataObjectpropCount++;
                }

                if (projectdataprojectNotes != null)
                {
                    dataObject["notes"] = ExpressionConverter.ConvertO(projectdataprojectNotes);
                    dataObjectpropCount++;
                }

                if (projectdataowner != null)
                {
                    dataObject["owner"] = ExpressionConverter.ConvertO(projectdataowner);
                    dataObjectpropCount++;
                }

                if (projectdataarchive != null)
                {
                    if (projectdataarchive != null)
                    {
                        dataObject["archived"] = ExpressionConverter.ConvertO(projectdataarchive);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<TaskResponseV2> CreateTask([WorkflowExpression] Func<string> workspace, [WorkflowExpression] Func<string> projects, [WorkflowExpression] Func<string> taskdatataskName = null, [WorkflowExpression] Func<string> taskdataassignee = null, [WorkflowExpression] Func<string> taskdatadescription = null, [WorkflowExpression] Func<taskdataassigneeStatusInput> taskdataassigneeStatus = null, [WorkflowExpression] Func<bool> taskdatacompleted = null, [WorkflowExpression] Func<string> taskdatadueDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskResponseV2> __BuildCreateTask(WorkflowExpression<string> workspace, WorkflowExpression<string> projects, WorkflowExpression<string> taskdatataskName = null, WorkflowExpression<string> taskdataassignee = null, WorkflowExpression<string> taskdatadescription = null, WorkflowExpression<taskdataassigneeStatusInput> taskdataassigneeStatus = null, WorkflowExpression<bool> taskdatacompleted = null, WorkflowExpression<string> taskdatadueDate = null)
        {
            WorkflowExpression.Validate(workspace, nameof(workspace), required: true);
            WorkflowExpression.Validate(projects, nameof(projects), required: true);
            WorkflowExpression.Validate(taskdatataskName, nameof(taskdatataskName), required: false);
            WorkflowExpression.Validate(taskdataassignee, nameof(taskdataassignee), required: false);
            WorkflowExpression.Validate(taskdatadescription, nameof(taskdatadescription), required: false);
            WorkflowExpression.Validate(taskdataassigneeStatus, nameof(taskdataassigneeStatus), required: false);
            WorkflowExpression.Validate(taskdatacompleted, nameof(taskdatacompleted), required: false);
            WorkflowExpression.Validate(taskdatadueDate, nameof(taskdatadueDate), required: false);
            return new DeferredBodyAction<TaskResponseV2>(() =>
            {
                var apiCallPath = "/v2/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
                callPayload.Queries["projects"] = ExpressionConverter.Convert(projects);
                var task = new JObject();
                var taskpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (taskdatataskName != null)
                {
                    dataObject["name"] = ExpressionConverter.ConvertO(taskdatataskName);
                    dataObjectpropCount++;
                }

                if (taskdataassignee != null)
                {
                    dataObject["assignee"] = ExpressionConverter.ConvertO(taskdataassignee);
                    dataObjectpropCount++;
                }

                if (taskdatadescription != null)
                {
                    dataObject["notes"] = ExpressionConverter.ConvertO(taskdatadescription);
                    dataObjectpropCount++;
                }

                if (taskdataassigneeStatus != null)
                {
                    dataObject["assignee_status"] = ExpressionConverter.ConvertO(taskdataassigneeStatus);
                    dataObjectpropCount++;
                }

                if (taskdatacompleted != null)
                {
                    if (taskdatacompleted != null)
                    {
                        dataObject["completed"] = ExpressionConverter.ConvertO(taskdatacompleted);
                        dataObjectpropCount++;
                    }

                    dataObjectpropCount++;
                }
                else
                {
                    dataObject["completed"] = false;
                    dataObjectpropCount++;
                }

                if (taskdatadueDate != null)
                {
                    dataObject["due_on"] = ExpressionConverter.ConvertO(taskdatadueDate);
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
        [WorkflowExpressionFactory(nameof(__BuildGetProject))]
        public IBodyWorkflowAction<ProjectResponseV2> GetProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectResponseV2> __BuildGetProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [WorkflowExpressionFactory(nameof(__BuildGetTask))]
        public IBodyWorkflowAction<TaskResponseV2> GetTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskResponseV2> __BuildGetTask(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<UserResponseV2> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponseV2> __BuildGetUser(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [WorkflowExpressionFactory(nameof(__BuildListUsers))]
        public IBodyWorkflowAction<ListUsersResponseV2> ListUsers([WorkflowExpression] Func<string> workspaceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListUsersResponseV2> __BuildListUsers(WorkflowExpression<string> workspaceId)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<ListUsersResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workspaces/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [WorkflowExpressionFactory(nameof(__BuildListWorkspaceTeams))]
        public IBodyWorkflowAction<ListTeamsResponseV2> ListWorkspaceTeams([WorkflowExpression] Func<string> workspace)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTeamsResponseV2> __BuildListWorkspaceTeams(WorkflowExpression<string> workspace)
        {
            WorkflowExpression.Validate(workspace, nameof(workspace), required: true);
            return new DeferredBodyAction<ListTeamsResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/organizations/{0}/teams", ExpressionConverter.ConvertWithUrlEncoding(workspace, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTeamsResponseV2>(callPayload);
            });
        }
    }

    public class AsanaTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnProjectCreated))]
        public IBodyWorkflowTrigger<ListProjectsResponseV2> OnProjectCreated([WorkflowExpression] Func<string> workspace,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListProjectsResponseV2> __BuildOnProjectCreated(WorkflowExpression<string> workspace,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(workspace, nameof(workspace), required: true);
            return new DeferredBodyTrigger<ListProjectsResponseV2>(() =>
            {
                var apiCallPath = "/v2/new_project_trigger/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
                return new ApiConnectionTrigger<ListProjectsResponseV2>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTaskCompleted))]
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskCompleted([WorkflowExpression] Func<string> workspace,[WorkflowExpression] Func<string> project,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListTasksResponseV2> __BuildOnTaskCompleted(WorkflowExpression<string> workspace,WorkflowExpression<string> project,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(workspace, nameof(workspace), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2>(() =>
            {
                var apiCallPath = "/v2/complete_task_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTaskCreated))]
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskCreated([WorkflowExpression] Func<string> workspace,[WorkflowExpression] Func<string> project,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListTasksResponseV2> __BuildOnTaskCreated(WorkflowExpression<string> workspace,WorkflowExpression<string> project,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(workspace, nameof(workspace), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2>(() =>
            {
                var apiCallPath = "/v2/new_task_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = ExpressionConverter.Convert(workspace);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
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
        public string CommentID { get; set; }
    }

    public class TargetV2
    {
        [JsonProperty("gid")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreatedByV2
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

    public class WorkSpaceV2
    {
        [JsonProperty("gid")]
        public string ID { get; set; }

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
        public string UserID { get; set; }

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
        public string TeamID { get; set; }

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