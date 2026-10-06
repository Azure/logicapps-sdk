//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todoist
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoistActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildCreateItem))]
        public IBodyWorkflowAction<TaskV2> CreateItem([WorkflowExpression] Func<string> newItemtitle, [WorkflowExpression] Func<string> newItemprojectId = null, [WorkflowExpression] Func<string> newItemdueDate = null, [WorkflowExpression] Func<int> newItempriority = null, [WorkflowExpression] Func<string> newItemparentId = null, [WorkflowExpression] Func<int> newItemchildOrder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskV2> __BuildCreateItem(WorkflowExpression<string> newItemtitle, WorkflowExpression<string> newItemprojectId = null, WorkflowExpression<string> newItemdueDate = null, WorkflowExpression<int> newItempriority = null, WorkflowExpression<string> newItemparentId = null, WorkflowExpression<int> newItemchildOrder = null)
        {
            WorkflowExpression.Validate(newItemtitle, nameof(newItemtitle), required: true);
            WorkflowExpression.Validate(newItemprojectId, nameof(newItemprojectId), required: false);
            WorkflowExpression.Validate(newItemdueDate, nameof(newItemdueDate), required: false);
            WorkflowExpression.Validate(newItempriority, nameof(newItempriority), required: false);
            WorkflowExpression.Validate(newItemparentId, nameof(newItemparentId), required: false);
            WorkflowExpression.Validate(newItemchildOrder, nameof(newItemchildOrder), required: false);
            return new DeferredBodyAction<TaskV2>(() =>
            {
                var apiCallPath = "/v4/tasks/createTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newItem = new JObject();
                var newItempropCount = 0;
                newItempropCount++;
                newItem["content"] = ExpressionConverter.ConvertO(newItemtitle);
                if (newItemprojectId != null)
                {
                    newItem["project_id"] = ExpressionConverter.ConvertO(newItemprojectId);
                    newItempropCount++;
                }

                if (newItemdueDate != null)
                {
                    newItem["due_string"] = ExpressionConverter.ConvertO(newItemdueDate);
                    newItempropCount++;
                }

                if (newItempriority != null)
                {
                    newItem["priority"] = ExpressionConverter.ConvertO(newItempriority);
                    newItempropCount++;
                }

                if (newItemparentId != null)
                {
                    newItem["parent_id"] = ExpressionConverter.ConvertO(newItemparentId);
                    newItempropCount++;
                }

                if (newItemchildOrder != null)
                {
                    newItem["order"] = ExpressionConverter.ConvertO(newItemchildOrder);
                    newItempropCount++;
                }

                if (newItempropCount > 0)
                {
                    callPayload.Body = newItem;
                }

                return new ApiConnectionAction<TaskV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLabel))]
        public IBodyWorkflowAction<LabelV4> CreateLabel([WorkflowExpression] Func<string> newLabelname, [WorkflowExpression] Func<string> newLabelcolor = null, [WorkflowExpression] Func<int> newLabelorder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LabelV4> __BuildCreateLabel(WorkflowExpression<string> newLabelname, WorkflowExpression<string> newLabelcolor = null, WorkflowExpression<int> newLabelorder = null)
        {
            WorkflowExpression.Validate(newLabelname, nameof(newLabelname), required: true);
            WorkflowExpression.Validate(newLabelcolor, nameof(newLabelcolor), required: false);
            WorkflowExpression.Validate(newLabelorder, nameof(newLabelorder), required: false);
            return new DeferredBodyAction<LabelV4>(() =>
            {
                var apiCallPath = "/v4/labels/createLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newLabel = new JObject();
                var newLabelpropCount = 0;
                newLabelpropCount++;
                newLabel["name"] = ExpressionConverter.ConvertO(newLabelname);
                if (newLabelcolor != null)
                {
                    newLabel["color"] = ExpressionConverter.ConvertO(newLabelcolor);
                    newLabelpropCount++;
                }

                if (newLabelorder != null)
                {
                    newLabel["order"] = ExpressionConverter.ConvertO(newLabelorder);
                    newLabelpropCount++;
                }

                if (newLabelpropCount > 0)
                {
                    callPayload.Body = newLabel;
                }

                return new ApiConnectionAction<LabelV4>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<ProjectV4> CreateProject([WorkflowExpression] Func<string> newProjectname, [WorkflowExpression] Func<string> newProjectcolor = null, [WorkflowExpression] Func<string> newProjectparentId = null, [WorkflowExpression] Func<bool> newProjectisFavorite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectV4> __BuildCreateProject(WorkflowExpression<string> newProjectname, WorkflowExpression<string> newProjectcolor = null, WorkflowExpression<string> newProjectparentId = null, WorkflowExpression<bool> newProjectisFavorite = null)
        {
            WorkflowExpression.Validate(newProjectname, nameof(newProjectname), required: true);
            WorkflowExpression.Validate(newProjectcolor, nameof(newProjectcolor), required: false);
            WorkflowExpression.Validate(newProjectparentId, nameof(newProjectparentId), required: false);
            WorkflowExpression.Validate(newProjectisFavorite, nameof(newProjectisFavorite), required: false);
            return new DeferredBodyAction<ProjectV4>(() =>
            {
                var apiCallPath = "/v4/projects/createProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newProject = new JObject();
                var newProjectpropCount = 0;
                newProjectpropCount++;
                newProject["name"] = ExpressionConverter.ConvertO(newProjectname);
                if (newProjectcolor != null)
                {
                    newProject["color"] = ExpressionConverter.ConvertO(newProjectcolor);
                    newProjectpropCount++;
                }

                if (newProjectparentId != null)
                {
                    newProject["parent_id"] = ExpressionConverter.ConvertO(newProjectparentId);
                    newProjectpropCount++;
                }

                if (newProjectisFavorite != null)
                {
                    newProject["is_favorite"] = ExpressionConverter.ConvertO(newProjectisFavorite);
                    newProjectpropCount++;
                }

                if (newProjectpropCount > 0)
                {
                    callPayload.Body = newProject;
                }

                return new ApiConnectionAction<ProjectV4>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[]> ListItems()
        {
            var apiCallPath = "/v4/tasks/getAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildListItemsByProject))]
        public IBodyWorkflowAction<TaskV2[]> ListItemsByProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskV2[]> __BuildListItemsByProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TaskV2[]>(() =>
            {
                var apiCallPath = "/v4/tasks/getTasksByProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<TaskV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4[]> ListLabels()
        {
            var apiCallPath = "/v4/labels/getAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LabelV4[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4[]> ListProjects()
        {
            var apiCallPath = "/v4/projects/getAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectV4[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildShareProject))]
        public IBodyWorkflowAction<ProjectV4> ShareProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> shareProjectemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectV4> __BuildShareProject(WorkflowExpression<string> projectId, WorkflowExpression<string> shareProjectemail)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(shareProjectemail, nameof(shareProjectemail), required: true);
            return new DeferredBodyAction<ProjectV4>(() =>
            {
                var apiCallPath = "/v4/sync/shareProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                var shareProject = new JObject();
                var shareProjectpropCount = 0;
                shareProjectpropCount++;
                shareProject["email"] = ExpressionConverter.ConvertO(shareProjectemail);
                if (shareProjectpropCount > 0)
                {
                    callPayload.Body = shareProject;
                }

                return new ApiConnectionAction<ProjectV4>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateItem))]
        public IWorkflowAction UpdateItem([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> changeItemtitle, [WorkflowExpression] Func<int> changeItempriority = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateItem(WorkflowExpression<string> projectId, WorkflowExpression<string> id, WorkflowExpression<string> changeItemtitle, WorkflowExpression<int> changeItempriority = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(changeItemtitle, nameof(changeItemtitle), required: true);
            WorkflowExpression.Validate(changeItempriority, nameof(changeItempriority), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v4/tasks/updateTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                var changeItem = new JObject();
                var changeItempropCount = 0;
                changeItempropCount++;
                changeItem["content"] = ExpressionConverter.ConvertO(changeItemtitle);
                if (changeItempriority != null)
                {
                    changeItem["priority"] = ExpressionConverter.ConvertO(changeItempriority);
                    changeItempropCount++;
                }

                if (changeItempropCount > 0)
                {
                    callPayload.Body = changeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLabel))]
        public IWorkflowAction UpdateLabel([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> changeLabelname = null, [WorkflowExpression] Func<string> changeLabelcolor = null, [WorkflowExpression] Func<int> changeLabelorder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateLabel(WorkflowExpression<string> id, WorkflowExpression<string> changeLabelname = null, WorkflowExpression<string> changeLabelcolor = null, WorkflowExpression<int> changeLabelorder = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(changeLabelname, nameof(changeLabelname), required: false);
            WorkflowExpression.Validate(changeLabelcolor, nameof(changeLabelcolor), required: false);
            WorkflowExpression.Validate(changeLabelorder, nameof(changeLabelorder), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v4/labels/updateLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                var changeLabel = new JObject();
                var changeLabelpropCount = 0;
                if (changeLabelname != null)
                {
                    changeLabel["name"] = ExpressionConverter.ConvertO(changeLabelname);
                    changeLabelpropCount++;
                }

                if (changeLabelcolor != null)
                {
                    changeLabel["color"] = ExpressionConverter.ConvertO(changeLabelcolor);
                    changeLabelpropCount++;
                }

                if (changeLabelorder != null)
                {
                    changeLabel["order"] = ExpressionConverter.ConvertO(changeLabelorder);
                    changeLabelpropCount++;
                }

                if (changeLabelpropCount > 0)
                {
                    callPayload.Body = changeLabel;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateProject))]
        public IWorkflowAction UpdateProject([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> changeProjectname, [WorkflowExpression] Func<string> changeProjectcolor = null, [WorkflowExpression] Func<bool> changeProjectisFavorite = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateProject(WorkflowExpression<string> id, WorkflowExpression<string> changeProjectname, WorkflowExpression<string> changeProjectcolor = null, WorkflowExpression<bool> changeProjectisFavorite = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(changeProjectname, nameof(changeProjectname), required: true);
            WorkflowExpression.Validate(changeProjectcolor, nameof(changeProjectcolor), required: false);
            WorkflowExpression.Validate(changeProjectisFavorite, nameof(changeProjectisFavorite), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v4/projects/updateProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                var changeProject = new JObject();
                var changeProjectpropCount = 0;
                changeProjectpropCount++;
                changeProject["name"] = ExpressionConverter.ConvertO(changeProjectname);
                if (changeProjectcolor != null)
                {
                    changeProject["color"] = ExpressionConverter.ConvertO(changeProjectcolor);
                    changeProjectpropCount++;
                }

                if (changeProjectisFavorite != null)
                {
                    changeProject["is_favorite"] = ExpressionConverter.ConvertO(changeProjectisFavorite);
                    changeProjectpropCount++;
                }

                if (changeProjectpropCount > 0)
                {
                    callPayload.Body = changeProject;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TodoistTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnItemCompleted))]
        public IBodyWorkflowTrigger<OnItemCompletedV4Response> OnItemCompleted([WorkflowExpression] Func<string> projectId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnItemCompletedV4Response> __BuildOnItemCompleted(WorkflowExpression<string> projectId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<OnItemCompletedV4Response>(() =>
            {
                var apiCallPath = "/v4/trigger/completed/get_all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionTrigger<OnItemCompletedV4Response>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnItemCreated))]
        public IBodyWorkflowTrigger<OnItemCreatedV4Response> OnItemCreated([WorkflowExpression] Func<string> projectId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnItemCreatedV4Response> __BuildOnItemCreated(WorkflowExpression<string> projectId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyTrigger<OnItemCreatedV4Response>(() =>
            {
                var apiCallPath = "/v4/trigger/sync";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
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
        public string SectionID { get; set; }

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