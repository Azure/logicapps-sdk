//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagetracker
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanagetrackerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<GetTrackersForWorkspaceResponseBody> GetTrackersForWorkspace(Expression<Func<string>> workspaceId)
        {
            var apiCallPath = "/getTrackersForWorkspace";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = CSharpExpressionConverter.ConvertO(workspaceId);
            callPayload.Queries["showAllTrackers"] = Convert.ToString(false);
            return new ApiConnectionAction<GetTrackersForWorkspaceResponseBody>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<GetStatusesForATrackerResponse> GetStatusesForATracker(Expression<Func<string>> workspaceId, Expression<Func<string>> trackerId)
        {
            var apiCallPath = "/getStatusesForATracker";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = CSharpExpressionConverter.ConvertO(workspaceId);
            callPayload.Queries["trackerId"] = CSharpExpressionConverter.ConvertO(trackerId);
            return new ApiConnectionAction<GetStatusesForATrackerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<AddTaskResponse> AddTask(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodycontextId, Expression<Func<string>> bodytitle, Expression<Func<bodyassigneetyInput>> bodyassigneety, Expression<Func<string>> bodyassigneeworkId, Expression<Func<string>> bodyworkObjectwWstype, Expression<Func<string>> bodyworkObjectwId, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodydueTimeZone = null, Expression<Func<string>> bodytaskStatus = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/addTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["context_work_id"] = CSharpExpressionConverter.ConvertToken(bodycontextWorkId);
            bodypropCount++;
            body["context_id"] = CSharpExpressionConverter.ConvertToken(bodycontextId);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            var assigneeObject = new JObject();
            var assigneeObjectpropCount = 0;
            assigneeObjectpropCount++;
            assigneeObject["ty"] = CSharpExpressionConverter.Convert(bodyassigneety);
            assigneeObjectpropCount++;
            assigneeObject["work_id"] = CSharpExpressionConverter.ConvertToken(bodyassigneeworkId);
            if (assigneeObjectpropCount > 0)
            {
                body["assignee"] = assigneeObject;
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["due_date"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
            }

            if (bodydueTimeZone != null)
            {
                body["due_time_zone"] = CSharpExpressionConverter.ConvertToken(bodydueTimeZone);
                bodypropCount++;
            }

            var workObjectObject = new JObject();
            var workObjectObjectpropCount = 0;
            workObjectObjectpropCount++;
            workObjectObject["w_wstype"] = CSharpExpressionConverter.ConvertToken(bodyworkObjectwWstype);
            workObjectObjectpropCount++;
            workObjectObject["w_id"] = CSharpExpressionConverter.ConvertToken(bodyworkObjectwId);
            if (workObjectObjectpropCount > 0)
            {
                body["work_object"] = workObjectObject;
                bodypropCount++;
            }

            if (bodytaskStatus != null)
            {
                body["task_status"] = CSharpExpressionConverter.ConvertToken(bodytaskStatus);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parent_id"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<UpdateSingleTaskFieldResponse> UpdateSingleTaskField(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodyfieldType, Expression<Func<string>> bodyfieldId, Expression<Func<object>> bodyfieldData)
        {
            var apiCallPath = "/updateSingleTaskField";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["context_work_id"] = CSharpExpressionConverter.ConvertToken(bodycontextWorkId);
            bodypropCount++;
            body["task_id"] = CSharpExpressionConverter.ConvertToken(bodytaskId);
            bodypropCount++;
            body["field_type"] = CSharpExpressionConverter.ConvertToken(bodyfieldType);
            bodypropCount++;
            body["field_id"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
            bodypropCount++;
            body["field_data"] = CSharpExpressionConverter.ConvertToken(bodyfieldData);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateSingleTaskFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<CreateTrackerResponse> CreateTracker(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytrackerOwner = null)
        {
            var apiCallPath = "/createTracker";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["context_work_id"] = CSharpExpressionConverter.ConvertToken(bodycontextWorkId);
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodytrackerOwner != null)
            {
                body["tracker_owner"] = CSharpExpressionConverter.ConvertToken(bodytrackerOwner);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTrackerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<AddCustomFieldResponse> AddCustomField(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodycontextId, Expression<Func<bodyviewOptionInput>> bodyviewOption, Expression<Func<string>> bodyfieldTitle, Expression<Func<string>> bodyfieldType, Expression<Func<object>> bodyfieldData = null)
        {
            var apiCallPath = "/addCustomField";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspaceId"] = CSharpExpressionConverter.ConvertToken(bodyworkspaceId);
            bodypropCount++;
            body["context_id"] = CSharpExpressionConverter.ConvertToken(bodycontextId);
            bodypropCount++;
            body["viewOption"] = CSharpExpressionConverter.Convert(bodyviewOption);
            bodypropCount++;
            body["field_title"] = CSharpExpressionConverter.ConvertToken(bodyfieldTitle);
            bodypropCount++;
            body["field_type"] = CSharpExpressionConverter.ConvertToken(bodyfieldType);
            if (bodyfieldData != null)
            {
                body["field_data"] = CSharpExpressionConverter.ConvertToken(bodyfieldData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddCustomFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ClearSingleTaskFieldResponse> ClearSingleTaskField(Expression<Func<string>> bodycontextWorkId, Expression<Func<string>> bodytaskId, Expression<Func<string>> bodyfieldId)
        {
            var apiCallPath = "/clearSingleTaskField";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["context_work_id"] = CSharpExpressionConverter.ConvertToken(bodycontextWorkId);
            bodypropCount++;
            body["task_id"] = CSharpExpressionConverter.ConvertToken(bodytaskId);
            bodypropCount++;
            body["field_id"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClearSingleTaskFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ImportTrackerResponse> ImportTracker(Expression<Func<string>> bodysourceWorkspaceId, Expression<Func<string>> bodysourceTrackerId, Expression<Func<string>> bodydestinationWorkspaceId, Expression<Func<string>> bodyimportType, Expression<Func<object>> bodyoptions = null)
        {
            var apiCallPath = "/importTracker";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["source_workspace_id"] = CSharpExpressionConverter.ConvertToken(bodysourceWorkspaceId);
            bodypropCount++;
            body["source_tracker_id"] = CSharpExpressionConverter.ConvertToken(bodysourceTrackerId);
            bodypropCount++;
            body["destination_workspace_id"] = CSharpExpressionConverter.ConvertToken(bodydestinationWorkspaceId);
            bodypropCount++;
            body["import_type"] = CSharpExpressionConverter.ConvertToken(bodyimportType);
            if (bodyoptions != null)
            {
                body["options"] = CSharpExpressionConverter.ConvertToken(bodyoptions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ImportTrackerResponse>(callPayload);
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

    public enum TaskProfileParentTypeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "tracker")]
        Tracker
    }

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