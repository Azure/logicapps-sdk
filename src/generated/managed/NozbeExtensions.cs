//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nozbe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NozbeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetTaskResponse> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                return new ApiConnectionAction<GetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodydueAt = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisFollowed = null, Expression<Func<string>> bodyresponsibleId = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodydueAt = bodydueAt == null ? null : WorkflowExpression.Compile(bodydueAt);
            WorkflowExpression.Validate(__workflow_bodydueAt, nameof(bodydueAt), required: false);
            var __workflow_bodyisAllDay = bodyisAllDay == null ? null : WorkflowExpression.Compile(bodyisAllDay);
            WorkflowExpression.Validate(__workflow_bodyisAllDay, nameof(bodyisAllDay), required: false);
            var __workflow_bodyisFollowed = bodyisFollowed == null ? null : WorkflowExpression.Compile(bodyisFollowed);
            WorkflowExpression.Validate(__workflow_bodyisFollowed, nameof(bodyisFollowed), required: false);
            var __workflow_bodyresponsibleId = bodyresponsibleId == null ? null : WorkflowExpression.Compile(bodyresponsibleId);
            WorkflowExpression.Validate(__workflow_bodyresponsibleId, nameof(bodyresponsibleId), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                body["review_reason"] = "newly_added";
                bodypropCount++;
                if (__workflow_bodydueAt != null)
                {
                    body["due_at"] = ExpressionConverter.ConvertO(__workflow_bodydueAt);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllDay != null)
                {
                    body["is_all_day"] = ExpressionConverter.ConvertO(__workflow_bodyisAllDay);
                    bodypropCount++;
                }

                if (__workflow_bodyisFollowed != null)
                {
                    body["is_followed"] = ExpressionConverter.ConvertO(__workflow_bodyisFollowed);
                    bodypropCount++;
                }

                body["review_triggered_at"] = 1;
                bodypropCount++;
                if (__workflow_bodyresponsibleId != null)
                {
                    body["responsible_id"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibleId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateCommentResponse> CreateComment(Expression<Func<string>> bodytaskId, Expression<Func<string>> bodybody = null, Expression<Func<bool>> bodyisPinned = null)
        {
            var __workflow_bodytaskId = bodytaskId == null ? null : WorkflowExpression.Compile(bodytaskId);
            WorkflowExpression.Validate(__workflow_bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: false);
            var __workflow_bodyisPinned = bodyisPinned == null ? null : WorkflowExpression.Compile(bodyisPinned);
            WorkflowExpression.Validate(__workflow_bodyisPinned, nameof(bodyisPinned), required: false);
            return new DeferredBodyAction<CreateCommentResponse>(() =>
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyisPinned != null)
                {
                    body["is_pinned"] = ExpressionConverter.ConvertO(__workflow_bodyisPinned);
                    bodypropCount++;
                }

                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCommentResponse>(callPayload);
            });
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
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            return new DeferredBodyAction<GetProjectsResponseItem[]>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ended_at"] = Convert.ToString("null");
                callPayload.Queries["sortBy"] = Convert.ToString("-created_at");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                return new ApiConnectionAction<GetProjectsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateReminderResponse> CreateReminder(Expression<Func<string>> bodytaskId, Expression<Func<int>> bodyremindAt, Expression<Func<bool>> bodyisRelative, Expression<Func<bool>> bodyisAllDay)
        {
            var __workflow_bodytaskId = bodytaskId == null ? null : WorkflowExpression.Compile(bodytaskId);
            WorkflowExpression.Validate(__workflow_bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodyremindAt = bodyremindAt == null ? null : WorkflowExpression.Compile(bodyremindAt);
            WorkflowExpression.Validate(__workflow_bodyremindAt, nameof(bodyremindAt), required: true);
            var __workflow_bodyisRelative = bodyisRelative == null ? null : WorkflowExpression.Compile(bodyisRelative);
            WorkflowExpression.Validate(__workflow_bodyisRelative, nameof(bodyisRelative), required: true);
            var __workflow_bodyisAllDay = bodyisAllDay == null ? null : WorkflowExpression.Compile(bodyisAllDay);
            WorkflowExpression.Validate(__workflow_bodyisAllDay, nameof(bodyisAllDay), required: true);
            return new DeferredBodyAction<CreateReminderResponse>(() =>
            {
                var apiCallPath = "/reminders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                bodypropCount++;
                body["remind_at"] = ExpressionConverter.ConvertO(__workflow_bodyremindAt);
                bodypropCount++;
                body["is_relative"] = ExpressionConverter.ConvertO(__workflow_bodyisRelative);
                bodypropCount++;
                body["is_all_day"] = ExpressionConverter.ConvertO(__workflow_bodyisAllDay);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateReminderResponse>(callPayload);
            });
        }
    }

    public class NozbeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PollNewTasksResponseItem[]> PollNewTasks(Expression<Func<string>> projectId = null, Expression<Func<string>> responsibleId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: false);
            var __workflow_responsibleId = responsibleId == null ? null : WorkflowExpression.Compile(responsibleId);
            WorkflowExpression.Validate(__workflow_responsibleId, nameof(responsibleId), required: false);
            return new DeferredBodyTrigger<PollNewTasksResponseItem[]>(() =>
            {
                var apiCallPath = "/poll/tasks/new";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                if (__workflow_projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_responsibleId != null)
                    callPayload.Queries["responsible_id"] = ExpressionConverter.Convert(__workflow_responsibleId);
                return new ApiConnectionTrigger<PollNewTasksResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollUpdatedTasksResponseItem[]> PollUpdatedTasks(Expression<Func<string>> projectId = null, Expression<Func<string>> responsibleId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: false);
            var __workflow_responsibleId = responsibleId == null ? null : WorkflowExpression.Compile(responsibleId);
            WorkflowExpression.Validate(__workflow_responsibleId, nameof(responsibleId), required: false);
            return new DeferredBodyTrigger<PollUpdatedTasksResponseItem[]>(() =>
            {
                var apiCallPath = "/poll/tasks/updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                if (__workflow_projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_responsibleId != null)
                    callPayload.Queries["responsible_id"] = ExpressionConverter.Convert(__workflow_responsibleId);
                return new ApiConnectionTrigger<PollUpdatedTasksResponseItem[]>(callPayload, recurrence: recurrence);
            });
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
