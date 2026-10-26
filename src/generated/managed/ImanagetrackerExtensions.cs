//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagetracker
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanagetrackerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<GetTrackersForWorkspaceResponseBody, ApiConnectionActionConfiguration> GetTrackersForWorkspace(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<GetTrackersForWorkspaceResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getTrackersForWorkspace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Queries["showAllTrackers"] = Convert.ToString(false);
                return new ApiConnectionAction<GetTrackersForWorkspaceResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<GetStatusesForATrackerResponse, ApiConnectionActionConfiguration> GetStatusesForATracker(Expression<Func<string>> workspaceId, Expression<Func<string>> trackerId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_trackerId = WorkflowExpression.Compile(trackerId, nameof(trackerId), required: true);
            return new DeferredBodyAction<GetStatusesForATrackerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getStatusesForATracker";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Queries["trackerId"] = ExpressionConverter.Convert(__workflow_trackerId);
                return new ApiConnectionAction<GetStatusesForATrackerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<AddTaskResponse, ApiConnectionActionConfiguration> AddTask(Expression<Func<AddTaskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<UpdateSingleTaskFieldResponse, ApiConnectionActionConfiguration> UpdateSingleTaskField(Expression<Func<UpdateSingleTaskFieldInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateSingleTaskFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateSingleTaskFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<CreateTrackerResponse, ApiConnectionActionConfiguration> CreateTracker(Expression<Func<CreateTrackerInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTrackerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTrackerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<AddCustomFieldResponse, ApiConnectionActionConfiguration> AddCustomField(Expression<Func<AddCustomFieldInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddCustomFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddCustomFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ClearSingleTaskFieldResponse, ApiConnectionActionConfiguration> ClearSingleTaskField(Expression<Func<ClearSingleTaskFieldInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ClearSingleTaskFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clearSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClearSingleTaskFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ImportTrackerResponse, ApiConnectionActionConfiguration> ImportTracker(Expression<Func<ImportTrackerInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImportTrackerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/importTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImportTrackerResponse>(callPayload);
            });
        }
    }

    public class ImanagetrackerTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetTrackersForWorkspaceResponseBody
    {
        [JsonProperty("data")]
        public GetTrackersForWorkspaceResponseBodyDataType Data { get; set; }
    }

    public class GetTrackersForWorkspaceResponseBodyDataType
    {
        [JsonProperty("trackers_count")]
        public int TrackersCount { get; set; }

        [JsonProperty("trackers")]
        public ShortTrackerProfileInArray[] Trackers { get; set; }
    }

    public class ShortTrackerProfileInArray
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("context_work_id")]
        public string ContextWorkId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tracker_owner_work_id")]
        public string TrackerOwnerWorkId { get; set; }

        [JsonProperty("tracker_owner_name")]
        public string TrackerOwnerName { get; set; }

        [JsonProperty("tracker_url")]
        public string TrackerUrl { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }
    }

    public class GetStatusesForATrackerResponse
    {
        [JsonProperty("data")]
        public TrackerTaskStatus[] Data { get; set; }
    }

    public class TrackerTaskStatus
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("state_code")]
        public int StateCode { get; set; }
    }

    public class AddTaskResponse
    {
        [JsonProperty("data")]
        public TaskProfile Data { get; set; }
    }

    public class TaskProfile
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("context_work_id")]
        public string ContextWorkId { get; set; }

        [JsonProperty("context_id")]
        public string ContextId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("assignee")]
        public AssigneeInResponse Assignee { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("due_time_zone")]
        public string DueTimeZone { get; set; }

        [JsonProperty("work_object")]
        public WorkObjectInResponse WorkObject { get; set; }

        [JsonProperty("task_status")]
        public TaskStatusInResponse TaskStatus { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("parent_type")]
        public TaskProfileParentTypeType ParentType { get; set; }

        [JsonProperty("assigned_at")]
        public string AssignedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("task_url")]
        public string TaskUrl { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }
    }

    public class AssigneeInResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("work_id")]
        public string WorkId { get; set; }

        [JsonProperty("ty")]
        public string Ty { get; set; }
    }

    public class WorkObjectInResponse
    {
        [JsonProperty("w_wstype")]
        public WorkObjectInResponseWWstypeType WWstype { get; set; }

        [JsonProperty("w_id")]
        public string WId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkObjectInResponseWWstypeType
    {
        DOCUMENT,
        FOLDER
    }

    public class TaskStatusInResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskProfileParentTypeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "tracker")]
        Tracker
    }

    public class AddTaskInput
    {
        [JsonProperty("context_work_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextWorkId { get; set; }

        [JsonProperty("context_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("assignee")]
        public AssigneeInRequest Assignee { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("due_time_zone")]
        public string DueTimeZone { get; set; }

        [JsonProperty("work_object")]
        public WorkObjectInRequest WorkObject { get; set; }

        [JsonProperty("task_status")]
        public string TaskStatus { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }

    public class AssigneeInRequest
    {
        [JsonProperty("ty")]
        public AssigneeInRequestTyType Ty { get; set; }

        [JsonProperty("work_id")]
        public string WorkId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssigneeInRequestTyType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

    public class WorkObjectInRequest
    {
        [JsonProperty("w_wstype")]
        public string WWstype { get; set; }

        [JsonProperty("w_id")]
        public string WId { get; set; }
    }

    public class UpdateSingleTaskFieldResponse
    {
        [JsonProperty("data")]
        public TaskProfile Data { get; set; }
    }

    public class UpdateSingleTaskFieldInput
    {
        [JsonProperty("context_work_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextWorkId { get; set; }

        [JsonProperty("task_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("field_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldType { get; set; }

        [JsonProperty("field_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldId { get; set; }

        [JsonProperty("field_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken FieldData { get; set; }
    }

    public class CreateTrackerResponse
    {
        [JsonProperty("data")]
        public TrackerProfile Data { get; set; }
    }

    public class TrackerProfile
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("context_work_id")]
        public string ContextWorkId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tracker_owner_work_id")]
        public string TrackerOwnerWorkId { get; set; }

        [JsonProperty("tracker_owner_name")]
        public string TrackerOwnerName { get; set; }

        [JsonProperty("tracker_url")]
        public string TrackerUrl { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }
    }

    public class CreateTrackerInput
    {
        [JsonProperty("context_work_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextWorkId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("tracker_owner")]
        public string TrackerOwner { get; set; }
    }

    public class AddCustomFieldResponse
    {
        [JsonProperty("data")]
        public AddCustomFieldResponseDataType Data { get; set; }
    }

    public class AddCustomFieldResponseDataType
    {
        [JsonProperty("field_id")]
        public string FieldId { get; set; }
    }

    public class AddCustomFieldInput
    {
        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("context_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextId { get; set; }

        [JsonProperty("viewOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddCustomFieldInputViewOptionType ViewOption { get; set; } = AddCustomFieldInputViewOptionType.TableViewAndDetailsView;

        [JsonProperty("field_title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldTitle { get; set; }

        [JsonProperty("field_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldType { get; set; }

        [JsonProperty("field_data")]
        public JToken FieldData { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddCustomFieldInputViewOptionType
    {
        [EnumMember(Value = "Details View")]
        DetailsView,
        [EnumMember(Value = "Table View and Details View")]
        TableViewAndDetailsView
    }

    public class ClearSingleTaskFieldResponse
    {
        [JsonProperty("data")]
        public TaskProfile Data { get; set; }
    }

    public class ClearSingleTaskFieldInput
    {
        [JsonProperty("context_work_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextWorkId { get; set; }

        [JsonProperty("task_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("field_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldId { get; set; }
    }

    public class ImportTrackerResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class ImportTrackerInput
    {
        [JsonProperty("source_workspace_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceWorkspaceId { get; set; }

        [JsonProperty("source_tracker_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceTrackerId { get; set; }

        [JsonProperty("destination_workspace_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationWorkspaceId { get; set; }

        [JsonProperty("import_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImportType { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imanagetracker;

    public partial class WorkflowManagedActions
    {
        public ImanagetrackerActions Imanagetracker(string connectionId) => new ImanagetrackerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImanagetrackerTriggers Imanagetracker(string connectionId) => new ImanagetrackerTriggers(connectionId);
    }
}