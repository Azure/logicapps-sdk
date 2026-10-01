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
        public IBodyWorkflowAction<GetTrackersForWorkspaceResponseBody> GetTrackersForWorkspace([WorkflowExpression] Func<string> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getTrackersForWorkspace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                callPayload.Queries["showAllTrackers"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction<GetTrackersForWorkspaceResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<GetStatusesForATrackerResponse> GetStatusesForATracker([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> trackerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getStatusesForATracker";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                callPayload.Queries["trackerId"] = SourceExpressionConverter.ConvertO(trackerId);
                return callPayload;
            }

            return new ApiConnectionAction<GetStatusesForATrackerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<AddTaskResponse> AddTask([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodycontextId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<bodyassigneetyInput> bodyassigneety, [WorkflowExpression] Func<string> bodyassigneeworkId, [WorkflowExpression] Func<string> bodyworkObjectwWstype, [WorkflowExpression] Func<string> bodyworkObjectwId, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodydueTimeZone = null, [WorkflowExpression] Func<string> bodytaskStatus = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = SourceExpressionConverter.ConvertToken(bodycontextWorkId);
                bodypropCount++;
                body["context_id"] = SourceExpressionConverter.ConvertToken(bodycontextId);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["ty"] = SourceExpressionConverter.Convert(bodyassigneety);
                assigneeObjectpropCount++;
                assigneeObject["work_id"] = SourceExpressionConverter.ConvertToken(bodyassigneeworkId);
                if (assigneeObjectpropCount > 0)
                {
                    body["assignee"] = assigneeObject;
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodydueTimeZone != null)
                {
                    body["due_time_zone"] = SourceExpressionConverter.ConvertToken(bodydueTimeZone);
                    bodypropCount++;
                }

                var workObjectObject = new JObject();
                var workObjectObjectpropCount = 0;
                workObjectObjectpropCount++;
                workObjectObject["w_wstype"] = SourceExpressionConverter.ConvertToken(bodyworkObjectwWstype);
                workObjectObjectpropCount++;
                workObjectObject["w_id"] = SourceExpressionConverter.ConvertToken(bodyworkObjectwId);
                if (workObjectObjectpropCount > 0)
                {
                    body["work_object"] = workObjectObject;
                    bodypropCount++;
                }

                if (bodytaskStatus != null)
                {
                    body["task_status"] = SourceExpressionConverter.ConvertToken(bodytaskStatus);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<UpdateSingleTaskFieldResponse> UpdateSingleTaskField([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<string> bodyfieldId, [WorkflowExpression] Func<object> bodyfieldData)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = SourceExpressionConverter.ConvertToken(bodycontextWorkId);
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                bodypropCount++;
                body["field_type"] = SourceExpressionConverter.ConvertToken(bodyfieldType);
                bodypropCount++;
                body["field_id"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
                body["field_data"] = SourceExpressionConverter.ConvertToken(bodyfieldData);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateSingleTaskFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<CreateTrackerResponse> CreateTracker([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytrackerOwner = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = SourceExpressionConverter.ConvertToken(bodycontextWorkId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodytrackerOwner != null)
                {
                    body["tracker_owner"] = SourceExpressionConverter.ConvertToken(bodytrackerOwner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTrackerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<AddCustomFieldResponse> AddCustomField([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodycontextId, [WorkflowExpression] Func<bodyviewOptionInput> bodyviewOption, [WorkflowExpression] Func<string> bodyfieldTitle, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<object> bodyfieldData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["context_id"] = SourceExpressionConverter.ConvertToken(bodycontextId);
                bodypropCount++;
                body["viewOption"] = SourceExpressionConverter.Convert(bodyviewOption);
                bodypropCount++;
                body["field_title"] = SourceExpressionConverter.ConvertToken(bodyfieldTitle);
                bodypropCount++;
                body["field_type"] = SourceExpressionConverter.ConvertToken(bodyfieldType);
                if (bodyfieldData != null)
                {
                    body["field_data"] = SourceExpressionConverter.ConvertToken(bodyfieldData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddCustomFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ClearSingleTaskFieldResponse> ClearSingleTaskField([WorkflowExpression] Func<string> bodycontextWorkId, [WorkflowExpression] Func<string> bodytaskId, [WorkflowExpression] Func<string> bodyfieldId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/clearSingleTaskField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_work_id"] = SourceExpressionConverter.ConvertToken(bodycontextWorkId);
                bodypropCount++;
                body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                bodypropCount++;
                body["field_id"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClearSingleTaskFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagetracker")]
        public IBodyWorkflowAction<ImportTrackerResponse> ImportTracker([WorkflowExpression] Func<string> bodysourceWorkspaceId, [WorkflowExpression] Func<string> bodysourceTrackerId, [WorkflowExpression] Func<string> bodydestinationWorkspaceId, [WorkflowExpression] Func<string> bodyimportType, [WorkflowExpression] Func<object> bodyoptions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/importTracker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source_workspace_id"] = SourceExpressionConverter.ConvertToken(bodysourceWorkspaceId);
                bodypropCount++;
                body["source_tracker_id"] = SourceExpressionConverter.ConvertToken(bodysourceTrackerId);
                bodypropCount++;
                body["destination_workspace_id"] = SourceExpressionConverter.ConvertToken(bodydestinationWorkspaceId);
                bodypropCount++;
                body["import_type"] = SourceExpressionConverter.ConvertToken(bodyimportType);
                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportTrackerResponse>(BuildSourceInput);
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