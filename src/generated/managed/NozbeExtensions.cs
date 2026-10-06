//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nozbe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NozbeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [WorkflowExpressionFactory(nameof(__BuildGetTask))]
        public IBodyWorkflowAction<GetTaskResponse> GetTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponse> __BuildGetTask(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                return new ApiConnectionAction<GetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<int> bodydueAt = null, [WorkflowExpression] Func<bool> bodyisAllDay = null, [WorkflowExpression] Func<bool> bodyisFollowed = null, [WorkflowExpression] Func<string> bodyresponsibleId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyprojectId = null, WorkflowExpression<int> bodydueAt = null, WorkflowExpression<bool> bodyisAllDay = null, WorkflowExpression<bool> bodyisFollowed = null, WorkflowExpression<string> bodyresponsibleId = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            WorkflowExpression.Validate(bodydueAt, nameof(bodydueAt), required: false);
            WorkflowExpression.Validate(bodyisAllDay, nameof(bodyisAllDay), required: false);
            WorkflowExpression.Validate(bodyisFollowed, nameof(bodyisFollowed), required: false);
            WorkflowExpression.Validate(bodyresponsibleId, nameof(bodyresponsibleId), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [WorkflowExpressionFactory(nameof(__BuildCreateComment))]
        public IBodyWorkflowAction<CreateCommentResponse> CreateComment([WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<bool> bodyisPinned = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCommentResponse> __BuildCreateComment(WorkflowExpression<string> bodytaskId, WorkflowExpression<string> bodybody = null, WorkflowExpression<bool> bodyisPinned = null)
        {
            WorkflowExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyisPinned, nameof(bodyisPinned), required: false);
            return new DeferredBodyAction<CreateCommentResponse>(() =>
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
        [WorkflowExpressionFactory(nameof(__BuildGetProjects))]
        public IBodyWorkflowAction<GetProjectsResponseItem[]> GetProjects([WorkflowExpression] Func<string> sortBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectsResponseItem[]> __BuildGetProjects(WorkflowExpression<string> sortBy = null)
        {
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            return new DeferredBodyAction<GetProjectsResponseItem[]>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ended_at"] = Convert.ToString("null");
                callPayload.Queries["sortBy"] = Convert.ToString("-created_at");
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                return new ApiConnectionAction<GetProjectsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [WorkflowExpressionFactory(nameof(__BuildCreateReminder))]
        public IBodyWorkflowAction<CreateReminderResponse> CreateReminder([WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<int> bodyremindAt, [WorkflowExpression] Func<bool> bodyisRelative, [WorkflowExpression] Func<bool> bodyisAllDay)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nozbe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateReminderResponse> __BuildCreateReminder(WorkflowExpression<string> bodytaskId, WorkflowExpression<int> bodyremindAt, WorkflowExpression<bool> bodyisRelative, WorkflowExpression<bool> bodyisAllDay)
        {
            WorkflowExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowExpression.Validate(bodyremindAt, nameof(bodyremindAt), required: true);
            WorkflowExpression.Validate(bodyisRelative, nameof(bodyisRelative), required: true);
            WorkflowExpression.Validate(bodyisAllDay, nameof(bodyisAllDay), required: true);
            return new DeferredBodyAction<CreateReminderResponse>(() =>
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
            });
        }
    }

    public class NozbeTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildPollNewTasks))]
        public IBodyWorkflowTrigger<PollNewTasksResponseItem[]> PollNewTasks([WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> responsibleId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollNewTasksResponseItem[]> __BuildPollNewTasks(WorkflowExpression<string> projectId = null, WorkflowExpression<string> responsibleId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            WorkflowExpression.Validate(responsibleId, nameof(responsibleId), required: false);
            return new DeferredBodyTrigger<PollNewTasksResponseItem[]>(() =>
            {
                var apiCallPath = "/poll/tasks/new";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                if (projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                if (responsibleId != null)
                    callPayload.Queries["responsible_id"] = ExpressionConverter.Convert(responsibleId);
                return new ApiConnectionTrigger<PollNewTasksResponseItem[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildPollUpdatedTasks))]
        public IBodyWorkflowTrigger<PollUpdatedTasksResponseItem[]> PollUpdatedTasks([WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> responsibleId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PollUpdatedTasksResponseItem[]> __BuildPollUpdatedTasks(WorkflowExpression<string> projectId = null, WorkflowExpression<string> responsibleId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            WorkflowExpression.Validate(responsibleId, nameof(responsibleId), required: false);
            return new DeferredBodyTrigger<PollUpdatedTasksResponseItem[]>(() =>
            {
                var apiCallPath = "/poll/tasks/updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolve_ids"] = Convert.ToString(1);
                if (projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                if (responsibleId != null)
                    callPayload.Queries["responsible_id"] = ExpressionConverter.Convert(responsibleId);
                return new ApiConnectionTrigger<PollUpdatedTasksResponseItem[]>(callPayload, triggerName, recurrence);
            }, triggerName);
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