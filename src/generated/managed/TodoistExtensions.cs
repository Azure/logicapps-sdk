//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todoist
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoistActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2, ApiConnectionActionConfiguration> CreateItem(Expression<Func<CreateItemV4Input>> newItem)
        {
            var __workflow_newItem = WorkflowExpression.Compile(newItem, nameof(newItem), required: true);
            return new DeferredBodyAction<TaskV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/tasks/createTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newItem);
                return new ApiConnectionAction<TaskV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4, ApiConnectionActionConfiguration> CreateLabel(Expression<Func<CreateLabelV4Input>> newLabel)
        {
            var __workflow_newLabel = WorkflowExpression.Compile(newLabel, nameof(newLabel), required: true);
            return new DeferredBodyAction<LabelV4, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/labels/createLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newLabel);
                return new ApiConnectionAction<LabelV4>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectV4Input>> newProject)
        {
            var __workflow_newProject = WorkflowExpression.Compile(newProject, nameof(newProject), required: true);
            return new DeferredBodyAction<ProjectV4, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/projects/createProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newProject);
                return new ApiConnectionAction<ProjectV4>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[], ApiConnectionActionConfiguration> ListItems()
        {
            return new DeferredBodyAction<TaskV2[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/tasks/getAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[], ApiConnectionActionConfiguration> ListItemsByProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TaskV2[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/tasks/getTasksByProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<TaskV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4[], ApiConnectionActionConfiguration> ListLabels()
        {
            return new DeferredBodyAction<LabelV4[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/labels/getAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LabelV4[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4[], ApiConnectionActionConfiguration> ListProjects()
        {
            return new DeferredBodyAction<ProjectV4[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/projects/getAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectV4[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4, ApiConnectionActionConfiguration> ShareProject(Expression<Func<string>> projectId, Expression<Func<ShareProjectV4Input>> shareProject)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_shareProject = WorkflowExpression.Compile(shareProject, nameof(shareProject), required: true);
            return new DeferredBodyAction<ProjectV4, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/sync/shareProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_shareProject);
                return new ApiConnectionAction<ProjectV4>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateItem(Expression<Func<string>> projectId, Expression<Func<string>> id, Expression<Func<UpdateItemV4Input>> changeItem)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_changeItem = WorkflowExpression.Compile(changeItem, nameof(changeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/tasks/updateTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_changeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLabel(Expression<Func<string>> id, Expression<Func<UpdateLabelV4Input>> changeLabel)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_changeLabel = WorkflowExpression.Compile(changeLabel, nameof(changeLabel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/labels/updateLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_changeLabel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> id, Expression<Func<UpdateProjectV4Input>> changeProject)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_changeProject = WorkflowExpression.Compile(changeProject, nameof(changeProject), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/projects/updateProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_changeProject);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TodoistTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnItemCompletedV4Response, ApiConnectionTriggerConfiguration> OnItemCompleted(Expression<Func<string>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<OnItemCompletedV4Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v4/trigger/completed/get_all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionTrigger<OnItemCompletedV4Response>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnItemCreatedV4Response, ApiConnectionTriggerConfiguration> OnItemCreated(Expression<Func<string>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<OnItemCreatedV4Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v4/trigger/sync";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionTrigger<OnItemCreatedV4Response>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TaskV2
    {
        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("is_completed")]
        public bool IsTaskCompleted { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("section_id")]
        public string SectionId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("content")]
        public string TaskContent { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("priority")]
        public int TaskPriority { get; set; }

        [JsonProperty("url")]
        public string TaskURL { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due")]
        public TaskV2DueType Due { get; set; }

        [JsonProperty("creator_id")]
        public string CreatorId { get; set; }

        [JsonProperty("assignee_id ")]
        public string AssigneeId { get; set; }

        [JsonProperty("assigner_id")]
        public string AssignerId { get; set; }

        [JsonProperty("duration")]
        public TaskV2DurationType Duration { get; set; }
    }

    public class TaskV2DueType
    {
        [JsonProperty("date")]
        public string DueDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("string")]
        public string String { get; set; }

        [JsonProperty("datetime")]
        public string DateTime { get; set; }

        [JsonProperty("is_recurring")]
        public bool RecurringDate { get; set; }
    }

    public class TaskV2DurationType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class CreateItemV4Input
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("due_string")]
        public string DueDate { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("order")]
        public int? ChildOrder { get; set; }
    }

    public class LabelV4
    {
        [JsonProperty("id")]
        public string LabelId { get; set; }

        [JsonProperty("name")]
        public string LabelName { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("item_order")]
        public int ItemOrder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }
    }

    public class CreateLabelV4Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }
    }

    public class ProjectV4
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("parent_id ")]
        public string ParentId { get; set; }

        [JsonProperty("child_order ")]
        public int ChildOrder { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("collapsed")]
        public bool IsProjectCollapsed { get; set; }

        [JsonProperty("inbox_project")]
        public bool IsProjectShared { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsProjectMarkedAsDeleted { get; set; }

        [JsonProperty("is_archived")]
        public bool IsProjectArchived { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsProjectFavorite { get; set; }

        [JsonProperty("team_inbox")]
        public bool IsProjectInTeamInbox { get; set; }

        [JsonProperty("view_style")]
        public string ViewStyle { get; set; }
    }

    public class CreateProjectV4Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }
    }

    public class ShareProjectV4Input
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class UpdateItemV4Input
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }
    }

    public class UpdateLabelV4Input
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }
    }

    public class UpdateProjectV4Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }
    }

    public class OnItemCompletedV4Response
    {
        [JsonProperty("items")]
        public CompletedItemV2[] CompletedItems { get; set; }
    }

    public class CompletedItemV2
    {
        [JsonProperty("id")]
        public string TaskEntryId { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("user_id")]
        public string TaskOwner { get; set; }

        [JsonProperty("section_id")]
        public string ProjectId { get; set; }

        [JsonProperty("content")]
        public string TaskTitle { get; set; }

        [JsonProperty("completed_at")]
        public string DateCompleted { get; set; }

        [JsonProperty("note_count")]
        public int NotesCount { get; set; }

        [JsonProperty("meta_data")]
        public string Details { get; set; }

        [JsonProperty("item_object")]
        public CompletedItemV2ItemObjectType ItemObject { get; set; }
    }

    public class CompletedItemV2ItemObjectType
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class OnItemCreatedV4Response
    {
        [JsonProperty("items")]
        public ItemV3[] Items { get; set; }
    }

    public class ItemV3
    {
        [JsonProperty("content")]
        public string TaskTitle { get; set; }

        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("user_id")]
        public string TaskOwner { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due")]
        public ItemV3DueType Due { get; set; }

        [JsonProperty("assigned_by_uid")]
        public string AssignerId { get; set; }

        [JsonProperty("responsible_uid")]
        public string AssigneeId { get; set; }

        [JsonProperty("checked")]
        public bool IsTaskCompleted { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("completed_at")]
        public string DateCompleted { get; set; }

        [JsonProperty("added_at")]
        public string DateCreated { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("child_order")]
        public int ChildOrder { get; set; }

        [JsonProperty("priority")]
        public int TaskPriority { get; set; }

        [JsonProperty("day_order")]
        public int DayOrder { get; set; }

        [JsonProperty("section_id")]
        public string SectionId { get; set; }

        [JsonProperty("collapsed")]
        public bool Collapsed { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("added_by_uid")]
        public string CreatorId { get; set; }

        [JsonProperty("duration")]
        public ItemV3DurationType Duration { get; set; }
    }

    public class ItemV3DueType
    {
        [JsonProperty("date")]
        public string DueDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("string")]
        public string String { get; set; }

        [JsonProperty("lang")]
        public string DateLanguage { get; set; }

        [JsonProperty("is_recurring")]
        public bool RecurringDate { get; set; }
    }

    public class ItemV3DurationType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Todoist;

    public partial class WorkflowManagedActions
    {
        public TodoistActions Todoist(string connectionId) => new TodoistActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodoistTriggers Todoist(string connectionId) => new TodoistTriggers(connectionId);
    }
}