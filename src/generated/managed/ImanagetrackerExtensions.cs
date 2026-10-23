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
        public IBodyWorkflowAction<AddTaskResponse, ApiConnectionActionConfiguration> AddTask(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodycontextId, Expression<Func<string>> bodytitle, Expression<Func<bodyassigneetyInput>> bodyassigneety, Expression<Func<string>> bodyassigneeworkId, Expression<Func<string>> bodyworkObjectwWstype, Expression<Func<string>> bodyworkObjectwId, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodydueTimeZone = null, Expression<Func<string>> bodytaskStatus = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodycontextWorkId = WorkflowExpression.Compile(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            var __workflow_bodycontextId = WorkflowExpression.Compile(bodycontextId, nameof(bodycontextId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyassigneety = WorkflowExpression.Compile(bodyassigneety, nameof(bodyassigneety), required: true);
            var __workflow_bodyassigneeworkId = WorkflowExpression.Compile(bodyassigneeworkId, nameof(bodyassigneeworkId), required: true);
            var __workflow_bodyworkObjectwWstype = WorkflowExpression.Compile(bodyworkObjectwWstype, nameof(bodyworkObjectwWstype), required: true);
            var __workflow_bodyworkObjectwId = WorkflowExpression.Compile(bodyworkObjectwId, nameof(bodyworkObjectwId), required: true);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydueTimeZone = WorkflowExpression.Compile(bodydueTimeZone, nameof(bodydueTimeZone), required: false);
            var __workflow_bodytaskStatus = WorkflowExpression.Compile(bodytaskStatus, nameof(bodytaskStatus), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<AddTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(__workflow_bodycontextWorkId);
                bodypropCount++;
                body["context_id"] = ExpressionConverter.ConvertO(__workflow_bodycontextId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["ty"] = ExpressionConverter.ConvertO(__workflow_bodyassigneety);
                assigneeObjectpropCount++;
                assigneeObject["work_id"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeworkId);
                if (assigneeObjectpropCount > 0)
                {
                    body["assignee"] = assigneeObject;
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueTimeZone != null)
                {
                    body["due_time_zone"] = ExpressionConverter.ConvertO(__workflow_bodydueTimeZone);
                    bodypropCount++;
                }

                var workObjectObject = new JObject();
                var workObjectObjectpropCount = 0;
                workObjectObjectpropCount++;
                workObjectObject["w_wstype"] = ExpressionConverter.ConvertO(__workflow_bodyworkObjectwWstype);
                workObjectObjectpropCount++;
                workObjectObject["w_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkObjectwId);
                if (workObjectObjectpropCount > 0)
                {
                    body["work_object"] = workObjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodytaskStatus != null)
                {
                    body["task_status"] = ExpressionConverter.ConvertO(__workflow_bodytaskStatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
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
        public IBodyWorkflowAction<UpdateSingleTaskFieldResponse, ApiConnectionActionConfiguration> UpdateSingleTaskField(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodyfieldType, Expression<Func<string>> bodyfieldId, Expression<Func<object>> bodyfieldData)
        {
            var __workflow_bodycontextWorkId = WorkflowExpression.Compile(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodyfieldType = WorkflowExpression.Compile(bodyfieldType, nameof(bodyfieldType), required: true);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: true);
            var __workflow_bodyfieldData = WorkflowExpression.Compile(bodyfieldData, nameof(bodyfieldData), required: true);
            return new DeferredBodyAction<UpdateSingleTaskFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(__workflow_bodycontextWorkId);
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                bodypropCount++;
                body["field_type"] = ExpressionConverter.ConvertO(__workflow_bodyfieldType);
                bodypropCount++;
                body["field_id"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                bodypropCount++;
                body["field_data"] = ExpressionConverter.ConvertO(__workflow_bodyfieldData);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateSingleTaskFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<CreateTrackerResponse, ApiConnectionActionConfiguration> CreateTracker(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytrackerOwner = null)
        {
            var __workflow_bodycontextWorkId = WorkflowExpression.Compile(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytrackerOwner = WorkflowExpression.Compile(bodytrackerOwner, nameof(bodytrackerOwner), required: false);
            return new DeferredBodyAction<CreateTrackerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(__workflow_bodycontextWorkId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodytrackerOwner != null)
                {
                    body["tracker_owner"] = ExpressionConverter.ConvertO(__workflow_bodytrackerOwner);
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
        public IBodyWorkflowAction<AddCustomFieldResponse, ApiConnectionActionConfiguration> AddCustomField(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodycontextId, Expression<Func<bodyviewOptionInput>> bodyviewOption, Expression<Func<string>> bodyfieldTitle, Expression<Func<string>> bodyfieldType, Expression<Func<object>> bodyfieldData = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodycontextId = WorkflowExpression.Compile(bodycontextId, nameof(bodycontextId), required: true);
            var __workflow_bodyviewOption = WorkflowExpression.Compile(bodyviewOption, nameof(bodyviewOption), required: true);
            var __workflow_bodyfieldTitle = WorkflowExpression.Compile(bodyfieldTitle, nameof(bodyfieldTitle), required: true);
            var __workflow_bodyfieldType = WorkflowExpression.Compile(bodyfieldType, nameof(bodyfieldType), required: true);
            var __workflow_bodyfieldData = WorkflowExpression.Compile(bodyfieldData, nameof(bodyfieldData), required: false);
            return new DeferredBodyAction<AddCustomFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["context_id"] = ExpressionConverter.ConvertO(__workflow_bodycontextId);
                bodypropCount++;
                body["viewOption"] = ExpressionConverter.ConvertO(__workflow_bodyviewOption);
                bodypropCount++;
                body["field_title"] = ExpressionConverter.ConvertO(__workflow_bodyfieldTitle);
                bodypropCount++;
                body["field_type"] = ExpressionConverter.ConvertO(__workflow_bodyfieldType);
                if (__workflow_bodyfieldData != null)
                {
                    body["field_data"] = ExpressionConverter.ConvertO(__workflow_bodyfieldData);
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
        public IBodyWorkflowAction<ClearSingleTaskFieldResponse, ApiConnectionActionConfiguration> ClearSingleTaskField(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodyfieldId)
        {
            var __workflow_bodycontextWorkId = WorkflowExpression.Compile(bodycontextWorkId, nameof(bodycontextWorkId), required: true);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: true);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: true);
            return new DeferredBodyAction<ClearSingleTaskFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clearSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = ExpressionConverter.ConvertO(__workflow_bodycontextWorkId);
                bodypropCount++;
                body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                bodypropCount++;
                body["field_id"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClearSingleTaskFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ImportTrackerResponse, ApiConnectionActionConfiguration> ImportTracker(Expression<Func<string>> bodysourceWorkspaceId, Expression<Func<string>> bodysourceTrackerId, Expression<Func<string>> bodydestinationWorkspaceId, Expression<Func<string>> bodyimportType, Expression<Func<object>> bodyoptions = null)
        {
            var __workflow_bodysourceWorkspaceId = WorkflowExpression.Compile(bodysourceWorkspaceId, nameof(bodysourceWorkspaceId), required: true);
            var __workflow_bodysourceTrackerId = WorkflowExpression.Compile(bodysourceTrackerId, nameof(bodysourceTrackerId), required: true);
            var __workflow_bodydestinationWorkspaceId = WorkflowExpression.Compile(bodydestinationWorkspaceId, nameof(bodydestinationWorkspaceId), required: true);
            var __workflow_bodyimportType = WorkflowExpression.Compile(bodyimportType, nameof(bodyimportType), required: true);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            return new DeferredBodyAction<ImportTrackerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/importTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source_workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodysourceWorkspaceId);
                bodypropCount++;
                body["source_tracker_id"] = ExpressionConverter.ConvertO(__workflow_bodysourceTrackerId);
                bodypropCount++;
                body["destination_workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodydestinationWorkspaceId);
                bodypropCount++;
                body["import_type"] = ExpressionConverter.ConvertO(__workflow_bodyimportType);
                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
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
