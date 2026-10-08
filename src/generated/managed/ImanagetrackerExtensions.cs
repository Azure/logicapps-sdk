//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagetracker
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanagetrackerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildGetTrackersForWorkspace))]
        public IBodyWorkflowAction<GetTrackersForWorkspaceResponseBody> GetTrackersForWorkspace([WorkflowExpression] Func<string> workspaceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTrackersForWorkspaceResponseBody> __BuildGetTrackersForWorkspace(WorkflowExpression<string> workspaceId)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<GetTrackersForWorkspaceResponseBody>(() =>
            {
                var apiCallPath = "/getTrackersForWorkspace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                callPayload.Queries["showAllTrackers"] = Convert.ToString(false);
                return new ApiConnectionAction<GetTrackersForWorkspaceResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatusesForATracker))]
        public IBodyWorkflowAction<GetStatusesForATrackerResponse> GetStatusesForATracker([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> trackerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStatusesForATrackerResponse> __BuildGetStatusesForATracker(WorkflowExpression<string> workspaceId, WorkflowExpression<string> trackerId)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(trackerId, nameof(trackerId), required: true);
            return new DeferredBodyAction<GetStatusesForATrackerResponse>(() =>
            {
                var apiCallPath = "/getStatusesForATracker";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
                callPayload.Queries["trackerId"] = ExpressionConverter.Convert(trackerId);
                return new ApiConnectionAction<GetStatusesForATrackerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildAddTask))]
        public IBodyWorkflowAction<AddTaskResponse> AddTask([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodycontextId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bodyassigneetyInput> bodyassigneety, [WorkflowExpression] Func<string> bodyassigneeworkId, [WorkflowExpression] Func<string> bodyworkObjectwWstype, [WorkflowExpression] Func<string> bodyworkObjectwId, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodydueTimeZone = null, [WorkflowExpression] Func<string> bodytaskStatus = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddTaskResponse> __BuildAddTask(WorkflowExpression<string> bodycontextWorkId, WorkflowExpression<string> bodycontextId, WorkflowExpression<string> bodytitle, WorkflowExpression<bodyassigneetyInput> bodyassigneety, WorkflowExpression<string> bodyassigneeworkId, WorkflowExpression<string> bodyworkObjectwWstype, WorkflowExpression<string> bodyworkObjectwId, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodydueTimeZone = null, WorkflowExpression<string> bodytaskStatus = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            WorkflowExpression.Validate(bodycontextId, nameof(bodycontextId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyassigneety, nameof(bodyassigneety), required: true);
            WorkflowExpression.Validate(bodyassigneeworkId, nameof(bodyassigneeworkId), required: true);
            WorkflowExpression.Validate(bodyworkObjectwWstype, nameof(bodyworkObjectwWstype), required: true);
            WorkflowExpression.Validate(bodyworkObjectwId, nameof(bodyworkObjectwId), required: true);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodydueTimeZone, nameof(bodydueTimeZone), required: false);
            WorkflowExpression.Validate(bodytaskStatus, nameof(bodytaskStatus), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<AddTaskResponse>(() =>
            {
                var apiCallPath = "/addTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(bodycontextWorkId);
                bodypropCount++;
                body["context_id"] = ExpressionConverter.ConvertO(bodycontextId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["ty"] = ExpressionConverter.ConvertO(bodyassigneety);
                assigneeObjectpropCount++;
                assigneeObject["work_id"] = ExpressionConverter.ConvertO(bodyassigneeworkId);
                if (assigneeObjectpropCount > 0)
                {
                    body["assignee"] = assigneeObject;
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodydueTimeZone != null)
                {
                    body["due_time_zone"] = ExpressionConverter.ConvertO(bodydueTimeZone);
                    bodypropCount++;
                }

                var workObjectObject = new JObject();
                var workObjectObjectpropCount = 0;
                workObjectObjectpropCount++;
                workObjectObject["w_wstype"] = ExpressionConverter.ConvertO(bodyworkObjectwWstype);
                workObjectObjectpropCount++;
                workObjectObject["w_id"] = ExpressionConverter.ConvertO(bodyworkObjectwId);
                if (workObjectObjectpropCount > 0)
                {
                    body["work_object"] = workObjectObject;
                    bodypropCount++;
                }

                if (bodytaskStatus != null)
                {
                    body["task_status"] = ExpressionConverter.ConvertO(bodytaskStatus);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parent_id"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSingleTaskField))]
        public IBodyWorkflowAction<UpdateSingleTaskFieldResponse> UpdateSingleTaskField([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<string> bodyfieldId, [WorkflowExpression] Func<object> bodyfieldData)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateSingleTaskFieldResponse> __BuildUpdateSingleTaskField(WorkflowExpression<string> bodycontextWorkId, WorkflowExpression<string> bodytaskId, WorkflowExpression<string> bodyfieldType, WorkflowExpression<string> bodyfieldId, WorkflowExpression<object> bodyfieldData)
        {
            WorkflowExpression.Validate(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            WorkflowExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowExpression.Validate(bodyfieldType, nameof(bodyfieldType), required: true);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: true);
            WorkflowExpression.Validate(bodyfieldData, nameof(bodyfieldData), required: true);
            return new DeferredBodyAction<UpdateSingleTaskFieldResponse>(() =>
            {
                var apiCallPath = "/updateSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(bodycontextWorkId);
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
                bodypropCount++;
                body["field_type"] = ExpressionConverter.ConvertO(bodyfieldType);
                bodypropCount++;
                body["field_id"] = ExpressionConverter.ConvertO(bodyfieldId);
                bodypropCount++;
                body["field_data"] = ExpressionConverter.ConvertO(bodyfieldData);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateSingleTaskFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTracker))]
        public IBodyWorkflowAction<CreateTrackerResponse> CreateTracker([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytrackerOwner = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTrackerResponse> __BuildCreateTracker(WorkflowExpression<string> bodycontextWorkId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodytrackerOwner = null)
        {
            WorkflowExpression.Validate(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodytrackerOwner, nameof(bodytrackerOwner), required: false);
            return new DeferredBodyAction<CreateTrackerResponse>(() =>
            {
                var apiCallPath = "/createTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(bodycontextWorkId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodytrackerOwner != null)
                {
                    body["tracker_owner"] = ExpressionConverter.ConvertO(bodytrackerOwner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTrackerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildAddCustomField))]
        public IBodyWorkflowAction<AddCustomFieldResponse> AddCustomField([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodycontextId, [WorkflowExpression] Func<bodyviewOptionInput> bodyviewOption, [WorkflowExpression] Func<string> bodyfieldTitle, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<object> bodyfieldData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddCustomFieldResponse> __BuildAddCustomField(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodycontextId, WorkflowExpression<bodyviewOptionInput> bodyviewOption, WorkflowExpression<string> bodyfieldTitle, WorkflowExpression<string> bodyfieldType, WorkflowExpression<object> bodyfieldData = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodycontextId, nameof(bodycontextId), required: true);
            WorkflowExpression.Validate(bodyviewOption, nameof(bodyviewOption), required: true);
            WorkflowExpression.Validate(bodyfieldTitle, nameof(bodyfieldTitle), required: true);
            WorkflowExpression.Validate(bodyfieldType, nameof(bodyfieldType), required: true);
            WorkflowExpression.Validate(bodyfieldData, nameof(bodyfieldData), required: false);
            return new DeferredBodyAction<AddCustomFieldResponse>(() =>
            {
                var apiCallPath = "/addCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["context_id"] = ExpressionConverter.ConvertO(bodycontextId);
                bodypropCount++;
                body["viewOption"] = ExpressionConverter.ConvertO(bodyviewOption);
                bodypropCount++;
                body["field_title"] = ExpressionConverter.ConvertO(bodyfieldTitle);
                bodypropCount++;
                body["field_type"] = ExpressionConverter.ConvertO(bodyfieldType);
                if (bodyfieldData != null)
                {
                    body["field_data"] = ExpressionConverter.ConvertO(bodyfieldData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddCustomFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildClearSingleTaskField))]
        public IBodyWorkflowAction<ClearSingleTaskFieldResponse> ClearSingleTaskField([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodyfieldId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClearSingleTaskFieldResponse> __BuildClearSingleTaskField(WorkflowExpression<string> bodycontextWorkId, WorkflowExpression<string> bodytaskId, WorkflowExpression<string> bodyfieldId)
        {
            WorkflowExpression.Validate(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            WorkflowExpression.Validate(bodytaskId, nameof(bodytaskId), required: true);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: true);
            return new DeferredBodyAction<ClearSingleTaskFieldResponse>(() =>
            {
                var apiCallPath = "/clearSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(bodycontextWorkId);
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(bodytaskId);
                bodypropCount++;
                body["field_id"] = ExpressionConverter.ConvertO(bodyfieldId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClearSingleTaskFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        [WorkflowExpressionFactory(nameof(__BuildImportTracker))]
        public IBodyWorkflowAction<ImportTrackerResponse> ImportTracker([WorkflowExpression] Func<string> bodysourceWorkspaceId, [WorkflowExpression] Func<string> bodysourceTrackerId, [WorkflowExpression] Func<string> bodydestinationWorkspaceId, [WorkflowExpression] Func<string> bodyimportType, [WorkflowExpression] Func<object> bodyoptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImportTrackerResponse> __BuildImportTracker(WorkflowExpression<string> bodysourceWorkspaceId, WorkflowExpression<string> bodysourceTrackerId, WorkflowExpression<string> bodydestinationWorkspaceId, WorkflowExpression<string> bodyimportType, WorkflowExpression<object> bodyoptions = null)
        {
            WorkflowExpression.Validate(bodysourceWorkspaceId, nameof(bodysourceWorkspaceId), required: true);
            WorkflowExpression.Validate(bodysourceTrackerId, nameof(bodysourceTrackerId), required: true);
            WorkflowExpression.Validate(bodydestinationWorkspaceId, nameof(bodydestinationWorkspaceId), required: true);
            WorkflowExpression.Validate(bodyimportType, nameof(bodyimportType), required: true);
            WorkflowExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            return new DeferredBodyAction<ImportTrackerResponse>(() =>
            {
                var apiCallPath = "/importTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source_workspace_id"] = ExpressionConverter.ConvertO(bodysourceWorkspaceId);
                bodypropCount++;
                body["source_tracker_id"] = ExpressionConverter.ConvertO(bodysourceTrackerId);
                bodypropCount++;
                body["destination_workspace_id"] = ExpressionConverter.ConvertO(bodydestinationWorkspaceId);
                bodypropCount++;
                body["import_type"] = ExpressionConverter.ConvertO(bodyimportType);
                if (bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(bodyoptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyassigneetyInput
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }

    public class UpdateSingleTaskFieldResponse
    {
        [JsonProperty("data")]
        public TaskProfile Data { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyviewOptionInput
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

    public class ImportTrackerResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
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