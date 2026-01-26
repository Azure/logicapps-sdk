//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pivotaltracker
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PivotaltrackerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pivotaltracker")]
        public IBodyWorkflowAction<StoryResponse> CreateStory(Expression<Func<int>> projectId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<bodystateInput>> bodystate = null, Expression<Func<int>> bodypoints = null, Expression<Func<string>> bodyacceptanceDateTime = null, Expression<Func<string>> bodydueDateTime = null, Expression<Func<int>> bodyrequestorId = null)
        {
            var apiCallPath = String.Format("/services/v5/projects/{0}/stories", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["story_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["current_state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypoints != null)
            {
                body["estimate"] = ExpressionConverter.ConvertO(bodypoints);
                bodypropCount++;
            }

            if (bodyacceptanceDateTime != null)
            {
                body["accepted_at"] = ExpressionConverter.ConvertO(bodyacceptanceDateTime);
                bodypropCount++;
            }

            if (bodydueDateTime != null)
            {
                body["deadline"] = ExpressionConverter.ConvertO(bodydueDateTime);
                bodypropCount++;
            }

            if (bodyrequestorId != null)
            {
                body["requested_by_id"] = ExpressionConverter.ConvertO(bodyrequestorId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pivotaltracker")]
        public IBodyWorkflowAction<ListprojectsResponseItem[]> ListProjects()
        {
            var apiCallPath = "/services/v5/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListprojectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pivotaltracker")]
        public IBodyWorkflowAction<StoryResponse> GetStory(Expression<Func<int>> projectId, Expression<Func<string>> storyId)
        {
            var apiCallPath = String.Format("/services/v5/projects/{0}/stories/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(storyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pivotaltracker")]
        public IBodyWorkflowAction<StoryResponse> UpdateStory(Expression<Func<int>> projectId, Expression<Func<string>> storyId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<bodystateInput>> bodystate = null, Expression<Func<int>> bodypoints = null, Expression<Func<string>> bodyacceptanceDateTime = null, Expression<Func<string>> bodydueDateTime = null, Expression<Func<int>> bodyrequestorId = null)
        {
            var apiCallPath = String.Format("/services/v5/projects/{0}/stories/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(storyId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["story_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["current_state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypoints != null)
            {
                body["estimate"] = ExpressionConverter.ConvertO(bodypoints);
                bodypropCount++;
            }

            if (bodyacceptanceDateTime != null)
            {
                body["accepted_at"] = ExpressionConverter.ConvertO(bodyacceptanceDateTime);
                bodypropCount++;
            }

            if (bodydueDateTime != null)
            {
                body["deadline"] = ExpressionConverter.ConvertO(bodydueDateTime);
                bodypropCount++;
            }

            if (bodyrequestorId != null)
            {
                body["requested_by_id"] = ExpressionConverter.ConvertO(bodyrequestorId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pivotaltracker")]
        public IWorkflowAction DeleteStory(Expression<Func<int>> projectId, Expression<Func<string>> storyId)
        {
            var apiCallPath = String.Format("/services/v5/projects/{0}/stories/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(storyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class PivotaltrackerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<StoryResponse[]> TrigStoryCreated(Expression<Func<int>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/create_story_trigger/services/v5/projects/{0}/stories", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<StoryResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<StoryResponse[]> TrigStoryCompleted(Expression<Func<int>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/complete_story_trigger/services/v5/projects/{0}/stories", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["with_state"] = Convert.ToString("finished");
            return new ApiConnectionTrigger<StoryResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<StoryResponse[]> TrigStoryUpdated(Expression<Func<int>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/update_story_trigger/services/v5/projects/{0}/stories", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<StoryResponse[]>(callPayload, triggerName, recurrence);
        }
    }

    public class StoryResponse
    {
        [JsonProperty("accepted_at")]
        public string AcceptanceDateTime { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("current_state")]
        public string State { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimate")]
        public int Points { get; set; }

        [JsonProperty("id")]
        public int StoryId { get; set; }

        [JsonProperty("labels")]
        public StoryResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("owner_ids")]
        public int[] OwnerIds { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("requested_by_id")]
        public int RequestorId { get; set; }

        [JsonProperty("story_type")]
        public string StoryType { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class StoryResponseLabelsTypeItem
    {
        [JsonProperty("id")]
        public int LabelId { get; set; }

        [JsonProperty("name")]
        public string LabelName { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "feature")]
        Feature,
        [EnumMember(Value = "bug")]
        Bug,
        [EnumMember(Value = "chore")]
        Chore,
        [EnumMember(Value = "release")]
        Release
    }

    public enum bodystateInput
    {
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "rejected")]
        Rejected,
        [EnumMember(Value = "planned")]
        Planned,
        [EnumMember(Value = "unstarted")]
        Unstarted,
        [EnumMember(Value = "unscheduled")]
        Unscheduled
    }

    public class ListprojectsResponseItem
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("current_iteration_number")]
        public int CurrentIterationNumber { get; set; }

        [JsonProperty("enable_following")]
        public bool EnableFollowing { get; set; }

        [JsonProperty("enable_incoming_emails")]
        public bool EnableIncomingEmails { get; set; }

        [JsonProperty("enable_tasks")]
        public bool EnableTasks { get; set; }

        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("initial_velocity")]
        public int InitialVelocity { get; set; }

        [JsonProperty("iteration_length")]
        public int IterationLength { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("point_scale")]
        public string PointScale { get; set; }

        [JsonProperty("project_type")]
        public string ProjectType { get; set; }

        [JsonProperty("public")]
        public bool IsPublic { get; set; }

        [JsonProperty("start_time")]
        public string StartDateTime { get; set; }

        [JsonProperty("updated_at")]
        public string UpdateDateTime { get; set; }

        [JsonProperty("velocity_averaged_over")]
        public int VelocityAveragedOver { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("week_start_day")]
        public string WeekStartDay { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pivotaltracker;

    public partial class WorkflowManagedActions
    {
        public PivotaltrackerActions Pivotaltracker(string connectionId) => new PivotaltrackerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PivotaltrackerTriggers Pivotaltracker(string connectionId) => new PivotaltrackerTriggers(connectionId);
    }
}