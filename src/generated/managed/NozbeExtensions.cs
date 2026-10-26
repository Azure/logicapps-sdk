//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nozbe
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NozbeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetTaskResponse, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                return new ApiConnectionAction<GetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodydueAt = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisFollowed = null, Expression<Func<string>> bodyresponsibleId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodydueAt = WorkflowExpression.Compile(bodydueAt, nameof(bodydueAt), required: false);
            var __workflow_bodyisAllDay = WorkflowExpression.Compile(bodyisAllDay, nameof(bodyisAllDay), required: false);
            var __workflow_bodyisFollowed = WorkflowExpression.Compile(bodyisFollowed, nameof(bodyisFollowed), required: false);
            var __workflow_bodyresponsibleId = WorkflowExpression.Compile(bodyresponsibleId, nameof(bodyresponsibleId), required: false);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateCommentResponse, ApiConnectionActionConfiguration> CreateComment(Expression<Func<string>> bodytaskId, Expression<Func<string>> bodybody = null, Expression<Func<bool>> bodyisPinned = null)
        {
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            var __workflow_bodyisPinned = WorkflowExpression.Compile(bodyisPinned, nameof(bodyisPinned), required: false);
            return new DeferredBodyAction<CreateCommentResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetTeamMembersResponseItem[], ApiConnectionActionConfiguration> GetTeamMembers()
        {
            return new DeferredBodyAction<GetTeamMembersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team_members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("active");
                return new ApiConnectionAction<GetTeamMembersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        public IBodyWorkflowAction<GetProjectsResponseItem[], ApiConnectionActionConfiguration> GetProjects(Expression<Func<string>> sortBy = null)
        {
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            return new DeferredBodyAction<GetProjectsResponseItem[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateReminderResponse, ApiConnectionActionConfiguration> CreateReminder(Expression<Func<string>> bodytaskId, Expression<Func<int>> bodyremindAt, Expression<Func<bool>> bodyisRelative, Expression<Func<bool>> bodyisAllDay)
        {
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodyremindAt = WorkflowExpression.Compile(bodyremindAt, nameof(bodyremindAt), required: true);
            var __workflow_bodyisRelative = WorkflowExpression.Compile(bodyisRelative, nameof(bodyisRelative), required: true);
            var __workflow_bodyisAllDay = WorkflowExpression.Compile(bodyisAllDay, nameof(bodyisAllDay), required: true);
            return new DeferredBodyAction<CreateReminderResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowTrigger<PollNewTasksResponseItem[], ApiConnectionTriggerConfiguration> PollNewTasks(Expression<Func<string>> projectId = null, Expression<Func<string>> responsibleId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_responsibleId = WorkflowExpression.Compile(responsibleId, nameof(responsibleId), required: false);
            return new DeferredBodyTrigger<PollNewTasksResponseItem[], ApiConnectionTriggerConfiguration>(() =>
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

        public IBodyWorkflowTrigger<PollUpdatedTasksResponseItem[], ApiConnectionTriggerConfiguration> PollUpdatedTasks(Expression<Func<string>> projectId = null, Expression<Func<string>> responsibleId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_responsibleId = WorkflowExpression.Compile(responsibleId, nameof(responsibleId), required: false);
            return new DeferredBodyTrigger<PollUpdatedTasksResponseItem[], ApiConnectionTriggerConfiguration>(() =>
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