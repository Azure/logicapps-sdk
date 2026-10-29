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
        public IBodyWorkflowAction<DealResponse, ApiConnectionActionConfiguration> UpdateDealStatus(Expression<Func<int>> dealId, Expression<Func<UpdateDealStatusInput>> body)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DealResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update_status_deal/v1/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<ActivityResponse, ApiConnectionActionConfiguration> AddActivity(Expression<Func<AddActivityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<DealResponseV2, ApiConnectionActionConfiguration> AddDeal(Expression<Func<AddDealV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DealResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector-v2/v1/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DealResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2, ApiConnectionActionConfiguration> UpdateDealStage(Expression<Func<int>> dealId, Expression<Func<UpdateDealStageV2Input>> body)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DealResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connector-v2/update_stage_deal/v1/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class UpdateDealStatusInput
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateDealStatusInputStatusType Status { get; set; }

        [JsonProperty("lost_reason")]
        public string LostReason { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateDealStatusInputStatusType
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

    public class AddActivityInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("due_time")]
        public string DueTime { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("note")]
        public string Notes { get; set; }

        [JsonProperty("user_id")]
        public int? AssignedTo { get; set; }

        [JsonProperty("deal_id")]
        public int? DealId { get; set; }

        [JsonProperty("person_id")]
        public int? ContactId { get; set; }

        [JsonProperty("org_id")]
        public int? OrganizationId { get; set; }
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

    public class AddDealV2Input
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("pipeline_id")]
        public string PipelineId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("status")]
        public AddDealV2InputStatusType? Status { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("person_id")]
        public string ContactId { get; set; }

        [JsonProperty("org_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("expected_close_date")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("visible_to")]
        public AddDealV2InputVisiblityType? Visiblity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddDealV2InputStatusType
    {
        Open,
        Won,
        Lost,
        Deleted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddDealV2InputVisiblityType
    {
        [EnumMember(Value = "Owner and followers")]
        OwnerAndFollowers,
        [EnumMember(Value = "Entire company")]
        EntireCompany
    }

    public class UpdateDealStageV2Input
    {
        [JsonProperty("pipeline_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PipelineId { get; set; }

        [JsonProperty("stage_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StageId { get; set; }

        [JsonProperty("expected_close_date")]
        public string ExpectedCloseDate { get; set; }
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