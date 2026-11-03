//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipedrive
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipedriveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponse, ApiConnectionActionConfiguration> GetDeal(Expression<Func<int>> dealId)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            return new DeferredBodyAction<DealResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponse, ApiConnectionActionConfiguration> UpdateDealStatus(Expression<Func<int>> dealId, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodylostReason = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodylostReason = WorkflowExpression.Compile(bodylostReason, nameof(bodylostReason), required: false);
            return new DeferredBodyAction<DealResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update_status_deal/v1/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                if (__workflow_bodylostReason != null)
                {
                    body["lost_reason"] = ExpressionConverter.ConvertO(__workflow_bodylostReason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<ActivityResponse, ApiConnectionActionConfiguration> AddActivity(Expression<Func<string>> bodytype, Expression<Func<string>> bodysubject, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodydueTime = null, Expression<Func<string>> bodyduration = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyassignedTo = null, Expression<Func<int>> bodydealId = null, Expression<Func<int>> bodycontactId = null, Expression<Func<int>> bodyorganizationId = null)
        {
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydueTime = WorkflowExpression.Compile(bodydueTime, nameof(bodydueTime), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodydealId = WorkflowExpression.Compile(bodydealId, nameof(bodydealId), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: false);
            return new DeferredBodyAction<ActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueTime != null)
                {
                    body["due_time"] = ExpressionConverter.ConvertO(__workflow_bodydueTime);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodydealId != null)
                {
                    body["deal_id"] = ExpressionConverter.ConvertO(__workflow_bodydealId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["person_id"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationId != null)
                {
                    body["org_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<StageResponse, ApiConnectionActionConfiguration> GetStage(Expression<Func<int>> stageId)
        {
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: true);
            return new DeferredBodyAction<StageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/stages/{0}", __workflow_stageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2, ApiConnectionActionConfiguration> AddDeal(Expression<Func<string>> bodytitle, Expression<Func<string>> bodypipelineId = null, Expression<Func<string>> bodystageId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<int>> bodyvalue = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodycontactId = null, Expression<Func<string>> bodyorganizationId = null, Expression<Func<string>> bodyexpectedCloseDate = null, Expression<Func<bodyvisiblityInput>> bodyvisiblity = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodypipelineId = WorkflowExpression.Compile(bodypipelineId, nameof(bodypipelineId), required: false);
            var __workflow_bodystageId = WorkflowExpression.Compile(bodystageId, nameof(bodystageId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: false);
            var __workflow_bodyexpectedCloseDate = WorkflowExpression.Compile(bodyexpectedCloseDate, nameof(bodyexpectedCloseDate), required: false);
            var __workflow_bodyvisiblity = WorkflowExpression.Compile(bodyvisiblity, nameof(bodyvisiblity), required: false);
            return new DeferredBodyAction<DealResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector-v2/v1/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodypipelineId != null)
                {
                    body["pipeline_id"] = ExpressionConverter.ConvertO(__workflow_bodypipelineId);
                    bodypropCount++;
                }

                if (__workflow_bodystageId != null)
                {
                    body["stage_id"] = ExpressionConverter.ConvertO(__workflow_bodystageId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["person_id"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationId != null)
                {
                    body["org_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedCloseDate != null)
                {
                    body["expected_close_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedCloseDate);
                    bodypropCount++;
                }

                if (__workflow_bodyvisiblity != null)
                {
                    body["visible_to"] = ExpressionConverter.ConvertO(__workflow_bodyvisiblity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DealResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2, ApiConnectionActionConfiguration> UpdateDealStage(Expression<Func<int>> dealId, Expression<Func<string>> bodypipelineId, Expression<Func<string>> bodystageId, Expression<Func<string>> bodyexpectedCloseDate = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_bodypipelineId = WorkflowExpression.Compile(bodypipelineId, nameof(bodypipelineId), required: true);
            var __workflow_bodystageId = WorkflowExpression.Compile(bodystageId, nameof(bodystageId), required: true);
            var __workflow_bodyexpectedCloseDate = WorkflowExpression.Compile(bodyexpectedCloseDate, nameof(bodyexpectedCloseDate), required: false);
            return new DeferredBodyAction<DealResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connector-v2/update_stage_deal/v1/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pipeline_id"] = ExpressionConverter.ConvertO(__workflow_bodypipelineId);
                bodypropCount++;
                body["stage_id"] = ExpressionConverter.ConvertO(__workflow_bodystageId);
                if (__workflow_bodyexpectedCloseDate != null)
                {
                    body["expected_close_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedCloseDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DealResponseV2>(callPayload);
            });
        }
    }

    public class PipedriveTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActivityResponse[], ApiConnectionTriggerConfiguration> TrigNewActivity(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ActivityResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/v1/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ActivityResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<DealResponseV2[], ApiConnectionTriggerConfiguration> TrigNewDeal(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<DealResponseV2[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/connector-v2/trigger/v1/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<DealResponseV2[]>(callPayload, recurrence: recurrence);
            });
        }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Open,
        Won,
        Lost,
        Deleted
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvisiblityInput
    {
        [EnumMember(Value = "Owner and followers")]
        OwnerAndFollowers,
        [EnumMember(Value = "Entire company")]
        EntireCompany
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