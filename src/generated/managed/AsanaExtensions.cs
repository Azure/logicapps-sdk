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
        public IBodyWorkflowAction<AddCommentResponseV2> AddComment([WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodydatacomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/tasks/{0}/stories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatacomment != null)
                {
                    dataObject["text"] = SourceExpressionConverter.ConvertToken(bodydatacomment);
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
                return callPayload;
            }

            return new ApiConnectionAction<AddCommentResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2> CompleteTask([WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ProjectResponseV2> CreateProject([WorkflowExpression] Func<string> workspace, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> projectdataprojectName = null, [WorkflowExpression] Func<string> projectdatadueDate = null, [WorkflowExpression] Func<bool> projectdataPublic = null, [WorkflowExpression] Func<projectdataprojectColorInput> projectdataprojectColor = null, [WorkflowExpression] Func<string> projectdataprojectNotes = null, [WorkflowExpression] Func<string> projectdataowner = null, [WorkflowExpression] Func<bool> projectdataarchive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                if (team != null)
                    callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                var project = new JObject();
                var projectpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (projectdataprojectName != null)
                {
                    dataObject["name"] = SourceExpressionConverter.ConvertToken(projectdataprojectName);
                    dataObjectpropCount++;
                }

                if (projectdatadueDate != null)
                {
                    dataObject["due_date"] = SourceExpressionConverter.ConvertToken(projectdatadueDate);
                    dataObjectpropCount++;
                }

                if (projectdataPublic != null)
                {
                    if (projectdataPublic != null)
                    {
                        dataObject["public"] = SourceExpressionConverter.ConvertToken(projectdataPublic);
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
                    dataObject["color"] = SourceExpressionConverter.Convert(projectdataprojectColor);
                    dataObjectpropCount++;
                }

                if (projectdataprojectNotes != null)
                {
                    dataObject["notes"] = SourceExpressionConverter.ConvertToken(projectdataprojectNotes);
                    dataObjectpropCount++;
                }

                if (projectdataowner != null)
                {
                    dataObject["owner"] = SourceExpressionConverter.ConvertToken(projectdataowner);
                    dataObjectpropCount++;
                }

                if (projectdataarchive != null)
                {
                    if (projectdataarchive != null)
                    {
                        dataObject["archived"] = SourceExpressionConverter.ConvertToken(projectdataarchive);
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
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2> CreateTask([WorkflowExpression] Func<string> workspace, [WorkflowExpression] Func<string> projects, [WorkflowExpression] Func<string> taskdatataskName = null, [WorkflowExpression] Func<string> taskdataassignee = null, [WorkflowExpression] Func<string> taskdatadescription = null, [WorkflowExpression] Func<taskdataassigneeStatusInput> taskdataassigneeStatus = null, [WorkflowExpression] Func<bool> taskdatacompleted = null, [WorkflowExpression] Func<string> taskdatadueDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                callPayload.Queries["projects"] = SourceExpressionConverter.ConvertO(projects);
                var task = new JObject();
                var taskpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (taskdatataskName != null)
                {
                    dataObject["name"] = SourceExpressionConverter.ConvertToken(taskdatataskName);
                    dataObjectpropCount++;
                }

                if (taskdataassignee != null)
                {
                    dataObject["assignee"] = SourceExpressionConverter.ConvertToken(taskdataassignee);
                    dataObjectpropCount++;
                }

                if (taskdatadescription != null)
                {
                    dataObject["notes"] = SourceExpressionConverter.ConvertToken(taskdatadescription);
                    dataObjectpropCount++;
                }

                if (taskdataassigneeStatus != null)
                {
                    dataObject["assignee_status"] = SourceExpressionConverter.Convert(taskdataassigneeStatus);
                    dataObjectpropCount++;
                }

                if (taskdatacompleted != null)
                {
                    if (taskdatacompleted != null)
                    {
                        dataObject["completed"] = SourceExpressionConverter.ConvertToken(taskdatacompleted);
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
                    dataObject["due_on"] = SourceExpressionConverter.ConvertToken(taskdatadueDate);
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
                return callPayload;
            }

            return new ApiConnectionAction<TaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ProjectResponseV2> GetProject([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<TaskResponseV2> GetTask([WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<UserResponseV2> GetUser([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ListUsersResponseV2> ListUsers([WorkflowExpression] Func<string> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/workspaces/{0}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListUsersResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asana")]
        public IBodyWorkflowAction<ListTeamsResponseV2> ListWorkspaceTeams([WorkflowExpression] Func<string> workspace)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/organizations/{0}/teams", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspace, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTeamsResponseV2>(BuildSourceInput);
        }
    }

    public class AsanaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListProjectsResponseV2> OnProjectCreated([WorkflowExpression] Func<string> workspace, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/new_project_trigger/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListProjectsResponseV2>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskCompleted([WorkflowExpression] Func<string> workspace, [WorkflowExpression] Func<string> project, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/complete_task_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponseV2>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskCreated([WorkflowExpression] Func<string> workspace, [WorkflowExpression] Func<string> project, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/new_task_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponseV2>(BuildSourceInput, triggerName, recurrence);
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