//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nozbe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NozbeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetTaskResponse> GetTask([WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<int> bodydueAt = null, [WorkflowExpression] Func<bool> bodyisAllDay = null, [WorkflowExpression] Func<bool> bodyisFollowed = null, [WorkflowExpression] Func<string> bodyresponsibleId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                body["review_reason"] = "newly_added";
                bodypropCount++;
                if (bodydueAt != null)
                {
                    body["due_at"] = SourceExpressionConverter.ConvertToken(bodydueAt);
                    bodypropCount++;
                }

                if (bodyisAllDay != null)
                {
                    body["is_all_day"] = SourceExpressionConverter.ConvertToken(bodyisAllDay);
                    bodypropCount++;
                }

                if (bodyisFollowed != null)
                {
                    body["is_followed"] = SourceExpressionConverter.ConvertToken(bodyisFollowed);
                    bodypropCount++;
                }

                body["review_triggered_at"] = 1;
                bodypropCount++;
                if (bodyresponsibleId != null)
                {
                    body["responsible_id"] = SourceExpressionConverter.ConvertToken(bodyresponsibleId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateCommentResponse> CreateComment([WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<bool> bodyisPinned = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodyisPinned != null)
                {
                    body["is_pinned"] = SourceExpressionConverter.ConvertToken(bodyisPinned);
                    bodypropCount++;
                }

                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetTeamMembersResponseItem[]> GetTeamMembers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/team_members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("active");
                return callPayload;
            }

            return new ApiConnectionAction<GetTeamMembersResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetProjectsResponseItem[]> GetProjects([WorkflowExpression] Func<string> sortBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ended_at"] = Convert.ToString("null");
                callPayload.Queries["sortBy"] = Convert.ToString("-created_at");
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateReminderResponse> CreateReminder([WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<int> bodyremindAt, [WorkflowExpression] Func<bool> bodyisRelative, [WorkflowExpression] Func<bool> bodyisAllDay)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reminders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                bodypropCount++;
                body["remind_at"] = SourceExpressionConverter.ConvertToken(bodyremindAt);
                bodypropCount++;
                body["is_relative"] = SourceExpressionConverter.ConvertToken(bodyisRelative);
                bodypropCount++;
                body["is_all_day"] = SourceExpressionConverter.ConvertToken(bodyisAllDay);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateReminderResponse>(BuildSourceInput);
        }
    }

    public class NozbeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollNewTasksResponseItem[]> PollNewTasks([WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> responsibleId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/poll/tasks/new";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                if (projectId != null)
                    callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                if (responsibleId != null)
                    callPayload.Queries["responsible_id"] = SourceExpressionConverter.ConvertO(responsibleId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollNewTasksResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollUpdatedTasksResponseItem[]> PollUpdatedTasks([WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> responsibleId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/poll/tasks/updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                if (projectId != null)
                    callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                if (responsibleId != null)
                    callPayload.Queries["responsible_id"] = SourceExpressionConverter.ConvertO(responsibleId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollUpdatedTasksResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class GetTaskResponse
    {
        [JsonProperty("value")]
        public GetTaskResponseValueTypeItem[] Value { get; set; }
    }

    public class GetTaskResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateCommentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class GetTeamMembersResponseItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetProjectsResponseItem
    {
        [JsonProperty("is_single_actions")]
        public bool IsSingleActions { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("extra")]
        public string Extra { get; set; }

        [JsonProperty("is_open")]
        public bool IsOpen { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("last_event_at")]
        public int LastEventAt { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("team_color")]
        public string TeamColor { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("last_seen_event_at")]
        public int LastSeenEventAt { get; set; }
    }

    public class CreateReminderResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("remind_at")]
        public int RemindAt { get; set; }

        [JsonProperty("is_relative")]
        public bool IsRelative { get; set; }

        [JsonProperty("is_all_day")]
        public bool IsAllDay { get; set; }
    }

    public class PollNewTasksResponseItem
    {
        [JsonProperty("due_at_string")]
        public string DueAtString { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("responsible_name")]
        public string ResponsibleName { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }

    public class PollUpdatedTasksResponseItem
    {
        [JsonProperty("due_at_string")]
        public string DueAtString { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("responsible_name")]
        public string ResponsibleName { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nozbe;

    public partial class WorkflowManagedActions
    {
        public NozbeActions Nozbe(string connectionId) => new NozbeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NozbeTriggers Nozbe(string connectionId) => new NozbeTriggers(connectionId);
    }
}