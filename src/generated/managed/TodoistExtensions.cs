//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todoist
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoistActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2> CreateItem([WorkflowExpression] Func<string> newItemtitle, [WorkflowExpression] Func<string> newItemprojectId = null, [WorkflowExpression] Func<string> newItemdueDate = null, [WorkflowExpression] Func<int> newItempriority = null, [WorkflowExpression] Func<string> newItemparentId = null, [WorkflowExpression] Func<int> newItemchildOrder = null)
        {
            SourceExpression.Validate(newItemtitle, nameof(newItemtitle), required: true);
            SourceExpression.Validate(newItemprojectId, nameof(newItemprojectId), required: false);
            SourceExpression.Validate(newItemdueDate, nameof(newItemdueDate), required: false);
            SourceExpression.Validate(newItempriority, nameof(newItempriority), required: false);
            SourceExpression.Validate(newItemparentId, nameof(newItemparentId), required: false);
            SourceExpression.Validate(newItemchildOrder, nameof(newItemchildOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/tasks/createTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newItem = new JObject();
                var newItempropCount = 0;
                newItempropCount++;
                newItem["content"] = SourceExpressionConverter.ConvertToken(newItemtitle);
                if (newItemprojectId != null)
                {
                    newItem["project_id"] = SourceExpressionConverter.ConvertToken(newItemprojectId);
                    newItempropCount++;
                }

                if (newItemdueDate != null)
                {
                    newItem["due_string"] = SourceExpressionConverter.ConvertToken(newItemdueDate);
                    newItempropCount++;
                }

                if (newItempriority != null)
                {
                    newItem["priority"] = SourceExpressionConverter.ConvertToken(newItempriority);
                    newItempropCount++;
                }

                if (newItemparentId != null)
                {
                    newItem["parent_id"] = SourceExpressionConverter.ConvertToken(newItemparentId);
                    newItempropCount++;
                }

                if (newItemchildOrder != null)
                {
                    newItem["order"] = SourceExpressionConverter.ConvertToken(newItemchildOrder);
                    newItempropCount++;
                }

                if (newItempropCount > 0)
                {
                    callPayload.Body = newItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4> CreateLabel([WorkflowExpression] Func<string> newLabelname, [WorkflowExpression] Func<string> newLabelcolor = null, [WorkflowExpression] Func<int> newLabelorder = null)
        {
            SourceExpression.Validate(newLabelname, nameof(newLabelname), required: true);
            SourceExpression.Validate(newLabelcolor, nameof(newLabelcolor), required: false);
            SourceExpression.Validate(newLabelorder, nameof(newLabelorder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/labels/createLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newLabel = new JObject();
                var newLabelpropCount = 0;
                newLabelpropCount++;
                newLabel["name"] = SourceExpressionConverter.ConvertToken(newLabelname);
                if (newLabelcolor != null)
                {
                    newLabel["color"] = SourceExpressionConverter.ConvertToken(newLabelcolor);
                    newLabelpropCount++;
                }

                if (newLabelorder != null)
                {
                    newLabel["order"] = SourceExpressionConverter.ConvertToken(newLabelorder);
                    newLabelpropCount++;
                }

                if (newLabelpropCount > 0)
                {
                    callPayload.Body = newLabel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LabelV4>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4> CreateProject([WorkflowExpression] Func<string> newProjectname, [WorkflowExpression] Func<string> newProjectcolor = null, [WorkflowExpression] Func<string> newProjectparentId = null, [WorkflowExpression] Func<bool> newProjectisFavorite = null)
        {
            SourceExpression.Validate(newProjectname, nameof(newProjectname), required: true);
            SourceExpression.Validate(newProjectcolor, nameof(newProjectcolor), required: false);
            SourceExpression.Validate(newProjectparentId, nameof(newProjectparentId), required: false);
            SourceExpression.Validate(newProjectisFavorite, nameof(newProjectisFavorite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/projects/createProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newProject = new JObject();
                var newProjectpropCount = 0;
                newProjectpropCount++;
                newProject["name"] = SourceExpressionConverter.ConvertToken(newProjectname);
                if (newProjectcolor != null)
                {
                    newProject["color"] = SourceExpressionConverter.ConvertToken(newProjectcolor);
                    newProjectpropCount++;
                }

                if (newProjectparentId != null)
                {
                    newProject["parent_id"] = SourceExpressionConverter.ConvertToken(newProjectparentId);
                    newProjectpropCount++;
                }

                if (newProjectisFavorite != null)
                {
                    newProject["is_favorite"] = SourceExpressionConverter.ConvertToken(newProjectisFavorite);
                    newProjectpropCount++;
                }

                if (newProjectpropCount > 0)
                {
                    callPayload.Body = newProject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectV4>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[]> ListItems()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/tasks/getAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskV2[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<TaskV2[]> ListItemsByProject([WorkflowExpression] Func<string> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/tasks/getTasksByProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskV2[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<LabelV4[]> ListLabels()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/labels/getAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LabelV4[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4[]> ListProjects()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/projects/getAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectV4[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IBodyWorkflowAction<ProjectV4> ShareProject([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> shareProjectemail)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(shareProjectemail, nameof(shareProjectemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/sync/shareProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                var shareProject = new JObject();
                var shareProjectpropCount = 0;
                shareProjectpropCount++;
                shareProject["email"] = SourceExpressionConverter.ConvertToken(shareProjectemail);
                if (shareProjectpropCount > 0)
                {
                    callPayload.Body = shareProject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectV4>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction UpdateItem([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> changeItemtitle, [WorkflowExpression] Func<int> changeItempriority = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(changeItemtitle, nameof(changeItemtitle), required: true);
            SourceExpression.Validate(changeItempriority, nameof(changeItempriority), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/tasks/updateTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var changeItem = new JObject();
                var changeItempropCount = 0;
                changeItempropCount++;
                changeItem["content"] = SourceExpressionConverter.ConvertToken(changeItemtitle);
                if (changeItempriority != null)
                {
                    changeItem["priority"] = SourceExpressionConverter.ConvertToken(changeItempriority);
                    changeItempropCount++;
                }

                if (changeItempropCount > 0)
                {
                    callPayload.Body = changeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction UpdateLabel([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> changeLabelname = null, [WorkflowExpression] Func<string> changeLabelcolor = null, [WorkflowExpression] Func<int> changeLabelorder = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(changeLabelname, nameof(changeLabelname), required: false);
            SourceExpression.Validate(changeLabelcolor, nameof(changeLabelcolor), required: false);
            SourceExpression.Validate(changeLabelorder, nameof(changeLabelorder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/labels/updateLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var changeLabel = new JObject();
                var changeLabelpropCount = 0;
                if (changeLabelname != null)
                {
                    changeLabel["name"] = SourceExpressionConverter.ConvertToken(changeLabelname);
                    changeLabelpropCount++;
                }

                if (changeLabelcolor != null)
                {
                    changeLabel["color"] = SourceExpressionConverter.ConvertToken(changeLabelcolor);
                    changeLabelpropCount++;
                }

                if (changeLabelorder != null)
                {
                    changeLabel["order"] = SourceExpressionConverter.ConvertToken(changeLabelorder);
                    changeLabelpropCount++;
                }

                if (changeLabelpropCount > 0)
                {
                    callPayload.Body = changeLabel;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoist")]
        public IWorkflowAction UpdateProject([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> changeProjectname, [WorkflowExpression] Func<string> changeProjectcolor = null, [WorkflowExpression] Func<bool> changeProjectisFavorite = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(changeProjectname, nameof(changeProjectname), required: true);
            SourceExpression.Validate(changeProjectcolor, nameof(changeProjectcolor), required: false);
            SourceExpression.Validate(changeProjectisFavorite, nameof(changeProjectisFavorite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/projects/updateProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var changeProject = new JObject();
                var changeProjectpropCount = 0;
                changeProjectpropCount++;
                changeProject["name"] = SourceExpressionConverter.ConvertToken(changeProjectname);
                if (changeProjectcolor != null)
                {
                    changeProject["color"] = SourceExpressionConverter.ConvertToken(changeProjectcolor);
                    changeProjectpropCount++;
                }

                if (changeProjectisFavorite != null)
                {
                    changeProject["is_favorite"] = SourceExpressionConverter.ConvertToken(changeProjectisFavorite);
                    changeProjectpropCount++;
                }

                if (changeProjectpropCount > 0)
                {
                    callPayload.Body = changeProject;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class TodoistTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnItemCompletedV4Response> OnItemCompleted([WorkflowExpression] Func<string> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/trigger/completed/get_all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnItemCompletedV4Response>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnItemCreatedV4Response> OnItemCreated([WorkflowExpression] Func<string> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/trigger/sync";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnItemCreatedV4Response>(BuildSourceInput, triggerName, recurrence);
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