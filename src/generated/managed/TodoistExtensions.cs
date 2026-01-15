//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Todoist
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoistActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4> ShareProjectV4(Expression<Func<string>> projectId, Expression<Func<string>> shareProjectemail)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4[]> ListProjectsV4()
        {
            var apiCallPath = "/v4/projects/getAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectV4[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[]> ListItemsV4()
        {
            var apiCallPath = "/v4/tasks/getAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[]> ListItemsByProjectV4(Expression<Func<string>> projectId)
        {
            var apiCallPath = "/v4/tasks/getTasksByProject";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<TaskV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2> CreateItemV4(Expression<Func<string>> newItemtitle, Expression<Func<string>> newItemprojectId = null, Expression<Func<string>> newItemdueDate = null, Expression<Func<int>> newItempriority = null, Expression<Func<string>> newItemparentId = null, Expression<Func<int>> newItemchildOrder = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction UpdateItemV4(Expression<Func<string>> projectId, Expression<Func<string>> id, Expression<Func<string>> changeItemtitle, Expression<Func<int>> changeItempriority = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4> CreateProjectV4(Expression<Func<string>> newProjectname, Expression<Func<string>> newProjectcolor = null, Expression<Func<string>> newProjectparentId = null, Expression<Func<bool>> newProjectisFavorite = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction UpdateProjectV4(Expression<Func<string>> id, Expression<Func<string>> changeProjectname, Expression<Func<string>> changeProjectcolor = null, Expression<Func<bool>> changeProjectisFavorite = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4[]> ListLabelsV4()
        {
            var apiCallPath = "/v4/labels/getAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LabelV4[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4> CreateLabelV4(Expression<Func<string>> newLabelname, Expression<Func<string>> newLabelcolor = null, Expression<Func<int>> newLabelorder = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction UpdateLabelV4(Expression<Func<string>> id, Expression<Func<string>> changeLabelname = null, Expression<Func<string>> changeLabelcolor = null, Expression<Func<int>> changeLabelorder = null)
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
        }
    }

    public class TodoistTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<OnItemCompletedV4Response> OnItemCompletedV4(Expression<Func<string>> projectId)
        {
            var apiCallPath = "/v4/trigger/completed/get_all";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionTrigger<OnItemCompletedV4Response>(callPayload);
        }

        public IOutputWorkflowTrigger<OnItemCreatedV4Response> OnItemCreatedV4(Expression<Func<string>> projectId)
        {
            var apiCallPath = "/v4/trigger/sync";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionTrigger<OnItemCreatedV4Response>(callPayload);
        }
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
    using Microsoft.Azure.Workflows.Sdk.Todoist;

    public partial class WorkflowManagedActions
    {
        public TodoistActions Todoist(string connectionId) => new TodoistActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodoistTriggers Todoist(string connectionId) => new TodoistTriggers(connectionId);
    }
}