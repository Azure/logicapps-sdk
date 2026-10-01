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
        public IBodyWorkflowAction<DealResponse> GetDeal([WorkflowExpression] Func<int> dealId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/deals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DealResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponse> UpdateDealStatus([WorkflowExpression] Func<int> dealId, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodylostReason = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update_status_deal/v1/deals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dealId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodylostReason != null)
                {
                    body["lost_reason"] = SourceExpressionConverter.ConvertToken(bodylostReason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DealResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<ActivityResponse> AddActivity([WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodydueTime = null, [WorkflowExpression] Func<string> bodyduration = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodyassignedTo = null, [WorkflowExpression] Func<int> bodydealId = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<int> bodyorganizationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodydueTime != null)
                {
                    body["due_time"] = SourceExpressionConverter.ConvertToken(bodydueTime);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodydealId != null)
                {
                    body["deal_id"] = SourceExpressionConverter.ConvertToken(bodydealId);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["person_id"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodyorganizationId != null)
                {
                    body["org_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActivityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<StageResponse> GetStage([WorkflowExpression] Func<int> stageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/stages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(stageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2> AddDeal([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodypipelineId = null, [WorkflowExpression] Func<string> bodystageId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<int> bodyvalue = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodycontactId = null, [WorkflowExpression] Func<string> bodyorganizationId = null, [WorkflowExpression] Func<string> bodyexpectedCloseDate = null, [WorkflowExpression] Func<bodyvisiblityInput> bodyvisiblity = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector-v2/v1/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypipelineId != null)
                {
                    body["pipeline_id"] = SourceExpressionConverter.ConvertToken(bodypipelineId);
                    bodypropCount++;
                }

                if (bodystageId != null)
                {
                    body["stage_id"] = SourceExpressionConverter.ConvertToken(bodystageId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    body["currency"] = SourceExpressionConverter.ConvertToken(bodycurrency);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["person_id"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodyorganizationId != null)
                {
                    body["org_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                    bodypropCount++;
                }

                if (bodyexpectedCloseDate != null)
                {
                    body["expected_close_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedCloseDate);
                    bodypropCount++;
                }

                if (bodyvisiblity != null)
                {
                    body["visible_to"] = SourceExpressionConverter.Convert(bodyvisiblity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DealResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipedrive")]
        public IBodyWorkflowAction<DealResponseV2> UpdateDealStage([WorkflowExpression] Func<int> dealId, [WorkflowExpression] Func<string> bodypipelineId, [WorkflowExpression] Func<string> bodystageId, [WorkflowExpression] Func<string> bodyexpectedCloseDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/connector-v2/update_stage_deal/v1/deals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dealId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pipeline_id"] = SourceExpressionConverter.ConvertToken(bodypipelineId);
                bodypropCount++;
                body["stage_id"] = SourceExpressionConverter.ConvertToken(bodystageId);
                if (bodyexpectedCloseDate != null)
                {
                    body["expected_close_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedCloseDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DealResponseV2>(BuildSourceInput);
        }
    }

    public class PipedriveTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActivityResponse[]> TrigNewActivity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ActivityResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DealResponseV2[]> TrigNewDeal(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector-v2/trigger/v1/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<DealResponseV2[]>(BuildSourceInput, triggerName, recurrence);
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