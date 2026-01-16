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
        public IBodyWorkflowAction<GetTaskResponse> GetTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["resolve_ids"] = Convert.ToString(1);
            return new ApiConnectionAction<GetTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodydueAt = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisFollowed = null, Expression<Func<string>> bodyresponsibleId = null)
        {
            var apiCallPath = "/tasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            body["review_reason"] = "newly_added";
            bodypropCount++;
            if (bodydueAt != null)
            {
                body["due_at"] = ExpressionConverter.ConvertO(bodydueAt);
                bodypropCount++;
            }

            if (bodyisAllDay != null)
            {
                body["is_all_day"] = ExpressionConverter.ConvertO(bodyisAllDay);
                bodypropCount++;
            }

            if (bodyisFollowed != null)
            {
                body["is_followed"] = ExpressionConverter.ConvertO(bodyisFollowed);
                bodypropCount++;
            }

            body["review_triggered_at"] = 1;
            bodypropCount++;
            if (bodyresponsibleId != null)
            {
                body["responsible_id"] = ExpressionConverter.ConvertO(bodyresponsibleId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateCommentResponse> CreateComment(Expression<Func<string>> bodytaskId, Expression<Func<string>> bodybody = null, Expression<Func<bool>> bodyisPinned = null)
        {
            var apiCallPath = "/comments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybody != null)
            {
                body["body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
            }

            if (bodyisPinned != null)
            {
                body["is_pinned"] = ExpressionConverter.ConvertO(bodyisPinned);
                bodypropCount++;
            }

            bodypropCount++;
            body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetTeamMembersResponseItem[]> GetTeamMembers()
        {
            var apiCallPath = "/team_members";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["status"] = Convert.ToString("active");
            return new ApiConnectionAction<GetTeamMembersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetProjectsResponseItem[]> GetProjects(Expression<Func<string>> sortBy = null)
        {
            var apiCallPath = "/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ended_at"] = Convert.ToString("null");
            callPayload.Queries["sortBy"] = Convert.ToString("-created_at");
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            return new ApiConnectionAction<GetProjectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateReminderResponse> CreateReminder(Expression<Func<string>> bodytaskId, Expression<Func<int>> bodyremindAt, Expression<Func<bool>> bodyisRelative, Expression<Func<bool>> bodyisAllDay)
        {
            var apiCallPath = "/reminders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
            bodypropCount++;
            body["remind_at"] = ExpressionConverter.ConvertO(bodyremindAt);
            bodypropCount++;
            body["is_relative"] = ExpressionConverter.ConvertO(bodyisRelative);
            bodypropCount++;
            body["is_all_day"] = ExpressionConverter.ConvertO(bodyisAllDay);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateReminderResponse>(callPayload);
        }
    }

    public class NozbeTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<PollNewTasksResponseItem[]> PollNewTasks(Expression<Func<string>> projectId = null, Expression<Func<string>> responsibleId = null, string triggerName = null)
        {
            var apiCallPath = "/poll/tasks/new";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["resolve_ids"] = Convert.ToString(1);
            if (projectId != null)
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            if (responsibleId != null)
                callPayload.Queries["responsible_id"] = ExpressionConverter.Convert(responsibleId);
            return new ApiConnectionTrigger<PollNewTasksResponseItem[]>(callPayload);
        }

        public IOutputWorkflowTrigger<PollUpdatedTasksResponseItem[]> PollUpdatedTasks(Expression<Func<string>> projectId = null, Expression<Func<string>> responsibleId = null, string triggerName = null)
        {
            var apiCallPath = "/poll/tasks/updated";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["resolve_ids"] = Convert.ToString(1);
            if (projectId != null)
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            if (responsibleId != null)
                callPayload.Queries["responsible_id"] = ExpressionConverter.Convert(responsibleId);
            return new ApiConnectionTrigger<PollUpdatedTasksResponseItem[]>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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