//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipedrive
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipedriveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2> AddDealV2(Expression<Func<string>> bodytitle, Expression<Func<string>> bodypipelineId = null, Expression<Func<string>> bodystageId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<int>> bodyvalue = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodycontactId = null, Expression<Func<string>> bodyorganizationId = null, Expression<Func<string>> bodyexpectedCloseDate = null, Expression<Func<bodyvisiblityInput>> bodyvisiblity = null)
        {
            var apiCallPath = "/connector-v2/v1/deals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypipelineId != null)
            {
                body["pipeline_id"] = ExpressionConverter.ConvertO(bodypipelineId);
                bodypropCount++;
            }

            if (bodystageId != null)
            {
                body["stage_id"] = ExpressionConverter.ConvertO(bodystageId);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["currency"] = ExpressionConverter.ConvertO(bodycurrency);
                bodypropCount++;
            }

            if (bodycontactId != null)
            {
                body["person_id"] = ExpressionConverter.ConvertO(bodycontactId);
                bodypropCount++;
            }

            if (bodyorganizationId != null)
            {
                body["org_id"] = ExpressionConverter.ConvertO(bodyorganizationId);
                bodypropCount++;
            }

            if (bodyexpectedCloseDate != null)
            {
                body["expected_close_date"] = ExpressionConverter.ConvertO(bodyexpectedCloseDate);
                bodypropCount++;
            }

            if (bodyvisiblity != null)
            {
                body["visible_to"] = ExpressionConverter.ConvertO(bodyvisiblity);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DealResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponse> GetDeal(Expression<Func<int>> dealId)
        {
            var apiCallPath = String.Format("/v1/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DealResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2> UpdateDealStageV2(Expression<Func<int>> dealId, Expression<Func<string>> bodypipelineId, Expression<Func<string>> bodystageId, Expression<Func<string>> bodyexpectedCloseDate = null)
        {
            var apiCallPath = String.Format("/connector-v2/update_stage_deal/v1/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pipeline_id"] = ExpressionConverter.ConvertO(bodypipelineId);
            bodypropCount++;
            body["stage_id"] = ExpressionConverter.ConvertO(bodystageId);
            if (bodyexpectedCloseDate != null)
            {
                body["expected_close_date"] = ExpressionConverter.ConvertO(bodyexpectedCloseDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DealResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponse> UpdateDealStatus(Expression<Func<int>> dealId, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodylostReason = null)
        {
            var apiCallPath = String.Format("/update_status_deal/v1/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodylostReason != null)
            {
                body["lost_reason"] = ExpressionConverter.ConvertO(bodylostReason);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DealResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<ActivityResponse> AddActivity(Expression<Func<string>> bodytype, Expression<Func<string>> bodysubject, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodydueTime = null, Expression<Func<string>> bodyduration = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyassignedTo = null, Expression<Func<int>> bodydealId = null, Expression<Func<int>> bodycontactId = null, Expression<Func<int>> bodyorganizationId = null)
        {
            var apiCallPath = "/v1/activities";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            if (bodydueDate != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodydueTime != null)
            {
                body["due_time"] = ExpressionConverter.ConvertO(bodydueTime);
                bodypropCount++;
            }

            if (bodyduration != null)
            {
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyassignedTo != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyassignedTo);
                bodypropCount++;
            }

            if (bodydealId != null)
            {
                body["deal_id"] = ExpressionConverter.ConvertO(bodydealId);
                bodypropCount++;
            }

            if (bodycontactId != null)
            {
                body["person_id"] = ExpressionConverter.ConvertO(bodycontactId);
                bodypropCount++;
            }

            if (bodyorganizationId != null)
            {
                body["org_id"] = ExpressionConverter.ConvertO(bodyorganizationId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ActivityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<StageResponse> GetStage(Expression<Func<int>> stageId)
        {
            var apiCallPath = String.Format("/v1/stages/{0}", ExpressionConverter.ConvertWithUrlEncoding(stageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StageResponse>(callPayload);
        }
    }

    public class PipedriveTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActivityResponse[]> TrigNewActivity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/activities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ActivityResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DealResponseV2[]> TrigNewDealV2(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/connector-v2/trigger/v1/deals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<DealResponseV2[]>(callPayload, triggerName, recurrence);
        }
    }

    public class DealResponseV2
    {
        [JsonProperty("id")]
        public int DealId { get; set; }

        [JsonProperty("creator_user_id")]
        public DealResponseV2CreatorType Creator { get; set; }

        [JsonProperty("user_id")]
        public DealResponseV2UserType User { get; set; }

        [JsonProperty("person_id")]
        public DealResponseV2ContactType Contact { get; set; }

        [JsonProperty("org_id")]
        public DealResponseV2OrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string DealTitle { get; set; }

        [JsonProperty("value")]
        public double DealValue { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("add_time")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("update_time")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("stage_id")]
        public int StageId { get; set; }

        [JsonProperty("stage_change_time")]
        public string StageUodatedDateTime { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        [JsonProperty("deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("next_activity_date")]
        public string NextActivityDate { get; set; }

        [JsonProperty("next_activity_time")]
        public string NextActivityTime { get; set; }

        [JsonProperty("next_activity_id")]
        public int NextActivityId { get; set; }

        [JsonProperty("last_activity_id")]
        public int LastActivityId { get; set; }

        [JsonProperty("last_activity_date")]
        public string LastActivityDate { get; set; }

        [JsonProperty("lost_reason")]
        public string LostReason { get; set; }

        [JsonProperty("visible_to")]
        public string Visiblity { get; set; }

        [JsonProperty("close_time")]
        public string ClosedDateTime { get; set; }

        [JsonProperty("pipeline_id")]
        public int PipelineId { get; set; }

        [JsonProperty("products_count")]
        public int ProductsCount { get; set; }

        [JsonProperty("files_count")]
        public int FilesCount { get; set; }

        [JsonProperty("notes_count")]
        public int NotesCount { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("email_messages_count")]
        public int EmailMessageCount { get; set; }

        [JsonProperty("activities_count")]
        public int ActivitiesCount { get; set; }

        [JsonProperty("done_activities_count")]
        public int DoneActivitiesCount { get; set; }

        [JsonProperty("undone_activities_count")]
        public int UndoneActivitiesCount { get; set; }

        [JsonProperty("reference_activities_count")]
        public int ReferencedActivitiesCount { get; set; }

        [JsonProperty("participants_count")]
        public int ParticipantsCount { get; set; }

        [JsonProperty("expected_close_date")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("next_activity_subject")]
        public string NextActivitySubject { get; set; }

        [JsonProperty("next_activity_type")]
        public string NextActivityType { get; set; }

        [JsonProperty("next_activity_duration")]
        public string NextActivityDuration { get; set; }

        [JsonProperty("next_activity_note")]
        public string NextActivityNote { get; set; }
    }

    public class DealResponseV2CreatorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class DealResponseV2UserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class DealResponseV2ContactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Id { get; set; }
    }

    public class DealResponseV2OrganizationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Id { get; set; }
    }

    public enum bodystatusInput
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "won")]
        Won,
        [EnumMember(Value = "lost")]
        Lost,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    public enum bodyvisiblityInput
    {
        [EnumMember(Value = "Owner and followers")]
        OwnerAndFollowers,
        [EnumMember(Value = "Entire company")]
        EntireCompany
    }

    public class DealResponse
    {
        [JsonProperty("id")]
        public int DealId { get; set; }

        [JsonProperty("creator_user_id")]
        public DealResponseCreatorType Creator { get; set; }

        [JsonProperty("user_id")]
        public DealResponseUserType User { get; set; }

        [JsonProperty("person_id")]
        public DealResponseContactType Contact { get; set; }

        [JsonProperty("org_id")]
        public DealResponseOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string DealTitle { get; set; }

        [JsonProperty("value")]
        public double DealValue { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("add_time")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("update_time")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("stage_id")]
        public int StageId { get; set; }

        [JsonProperty("stage_name")]
        public string StageName { get; set; }

        [JsonProperty("stage_change_time")]
        public string StageUodatedDateTime { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        [JsonProperty("deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("next_activity_date")]
        public string NextActivityDate { get; set; }

        [JsonProperty("next_activity_time")]
        public string NextActivityTime { get; set; }

        [JsonProperty("next_activity_id")]
        public int NextActivityId { get; set; }

        [JsonProperty("last_activity_id")]
        public int LastActivityId { get; set; }

        [JsonProperty("last_activity_date")]
        public string LastActivityDate { get; set; }

        [JsonProperty("lost_reason")]
        public string LostReason { get; set; }

        [JsonProperty("visible_to")]
        public string Visiblity { get; set; }

        [JsonProperty("close_time")]
        public string ClosedDateTime { get; set; }

        [JsonProperty("pipeline_id")]
        public int PipelineId { get; set; }

        [JsonProperty("products_count")]
        public int ProductsCount { get; set; }

        [JsonProperty("files_count")]
        public int FilesCount { get; set; }

        [JsonProperty("notes_count")]
        public int NotesCount { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("email_messages_count")]
        public int EmailMessageCount { get; set; }

        [JsonProperty("activities_count")]
        public int ActivitiesCount { get; set; }

        [JsonProperty("done_activities_count")]
        public int DoneActivitiesCount { get; set; }

        [JsonProperty("undone_activities_count")]
        public int UndoneActivitiesCount { get; set; }

        [JsonProperty("reference_activities_count")]
        public int ReferencedActivitiesCount { get; set; }

        [JsonProperty("participants_count")]
        public int ParticipantsCount { get; set; }

        [JsonProperty("expected_close_date")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("next_activity_subject")]
        public string NextActivitySubject { get; set; }

        [JsonProperty("next_activity_type")]
        public string NextActivityType { get; set; }

        [JsonProperty("next_activity_duration")]
        public string NextActivityDuration { get; set; }

        [JsonProperty("next_activity_note")]
        public string NextActivityNote { get; set; }
    }

    public class DealResponseCreatorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class DealResponseUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class DealResponseContactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Id { get; set; }
    }

    public class DealResponseOrganizationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Id { get; set; }
    }

    public class ActivityResponse
    {
        [JsonProperty("id")]
        public int ActivityId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("done")]
        public bool IsDone { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("due_time")]
        public string DueTime { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("deal_id")]
        public int DealId { get; set; }

        [JsonProperty("deal_title")]
        public string DealTitle { get; set; }

        [JsonProperty("org_id")]
        public int OrganizationId { get; set; }

        [JsonProperty("org_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("person_id")]
        public int ContactId { get; set; }

        [JsonProperty("person_name")]
        public string ContactName { get; set; }

        [JsonProperty("add_time")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("update_time")]
        public string UpdatesDateTime { get; set; }

        [JsonProperty("marked_as_done_time")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("gcal_event_id")]
        public string GoogleCalendarEventId { get; set; }

        [JsonProperty("google_calendar_id")]
        public string GoogleCalendarId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("assigned_to_user_id")]
        public int AssignedTo { get; set; }

        [JsonProperty("created_by_user_id")]
        public int CreatedBy { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }
    }

    public class StageResponse
    {
        [JsonProperty("id")]
        public int StageId { get; set; }

        [JsonProperty("name")]
        public string StageName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pipedrive;

    public partial class WorkflowManagedActions
    {
        public PipedriveActions Pipedrive(string connectionId) => new PipedriveActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PipedriveTriggers Pipedrive(string connectionId) => new PipedriveTriggers(connectionId);
    }
}