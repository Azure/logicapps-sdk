//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calendlyv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Calendlyv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendlyv2")]
        public IBodyWorkflowAction<GetEventTypesResponse> GetEventTypes(Expression<Func<bool>> active = null, Expression<Func<int>> count = null, Expression<Func<string>> pageToken = null, Expression<Func<bool>> adminManaged = null)
        {
            var __workflow_active = active == null ? null : WorkflowExpression.Compile(active);
            WorkflowExpression.Validate(__workflow_active, nameof(active), required: false);
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: false);
            var __workflow_pageToken = pageToken == null ? null : WorkflowExpression.Compile(pageToken);
            WorkflowExpression.Validate(__workflow_pageToken, nameof(pageToken), required: false);
            var __workflow_adminManaged = adminManaged == null ? null : WorkflowExpression.Compile(adminManaged);
            WorkflowExpression.Validate(__workflow_adminManaged, nameof(adminManaged), required: false);
            return new DeferredBodyAction<GetEventTypesResponse>(() =>
            {
                var apiCallPath = "/event_types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                callPayload.Queries["count"] = Convert.ToString(20);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_pageToken != null)
                    callPayload.Queries["page_token"] = ExpressionConverter.Convert(__workflow_pageToken);
                if (__workflow_adminManaged != null)
                    callPayload.Queries["admin_managed"] = ExpressionConverter.Convert(__workflow_adminManaged);
                return new ApiConnectionAction<GetEventTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendlyv2")]
        public IBodyWorkflowAction<CreateInviteeNoShowResponse> CreateInviteeNoShow(Expression<Func<string>> bodyinvitee)
        {
            var __workflow_bodyinvitee = bodyinvitee == null ? null : WorkflowExpression.Compile(bodyinvitee);
            WorkflowExpression.Validate(__workflow_bodyinvitee, nameof(bodyinvitee), required: true);
            return new DeferredBodyAction<CreateInviteeNoShowResponse>(() =>
            {
                var apiCallPath = "/invitee_no_shows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["invitee"] = ExpressionConverter.ConvertO(__workflow_bodyinvitee);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateInviteeNoShowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendlyv2")]
        public IBodyWorkflowAction<GetEventTypeResponse> GetEventType(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = uuid == null ? null : WorkflowExpression.Compile(uuid);
            WorkflowExpression.Validate(__workflow_uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<GetEventTypeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event_types/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_uuid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEventTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendlyv2")]
        public IBodyWorkflowAction<JToken> DeleteInviteeNoShow(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = uuid == null ? null : WorkflowExpression.Compile(uuid);
            WorkflowExpression.Validate(__workflow_uuid, nameof(uuid), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invitee_no_shows/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_uuid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class Calendlyv2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateWebhookSubscriptionResponse> CreateWebhookSubscription(Expression<Func<bodyeventsInputItem[]>> bodyevents, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyevents = bodyevents == null ? null : WorkflowExpression.Compile(bodyevents);
            WorkflowExpression.Validate(__workflow_bodyevents, nameof(bodyevents), required: true);
            return new DeferredBodyTrigger<CreateWebhookSubscriptionResponse>(() =>
            {
                var apiCallPath = "/webhook_subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                body["scope"] = "organization";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateWebhookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CreateWebhookSubscriptionRoutingFormSubmissionResponse> CreateWebhookSubscriptionRoutingFormSubmission(Expression<Func<bodyeventsInputItem[]>> bodyevents, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyevents = bodyevents == null ? null : WorkflowExpression.Compile(bodyevents);
            WorkflowExpression.Validate(__workflow_bodyevents, nameof(bodyevents), required: true);
            return new DeferredBodyTrigger<CreateWebhookSubscriptionRoutingFormSubmissionResponse>(() =>
            {
                var apiCallPath = "/webhook_subscriptions/routing_form_submission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                body["scope"] = "organization";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateWebhookSubscriptionRoutingFormSubmissionResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetEventTypesResponse
    {
        [JsonProperty("collection")]
        public EventType[] Collection { get; set; }

        [JsonProperty("pagination")]
        public GetEventTypesResponsePaginationType Pagination { get; set; }
    }

    public class EventType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("name")]
        public string EventTypeName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("booking_method")]
        public string BookingMethod { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("scheduling_url")]
        public string SchedulingURL { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("pooling_type")]
        public string PoolingType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("internal_note")]
        public string InternalNote { get; set; }

        [JsonProperty("description_plain")]
        public string DescriptionPlain { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHTML { get; set; }

        [JsonProperty("profile")]
        public EventTypeProfileType Profile { get; set; }

        [JsonProperty("secret")]
        public bool Secret { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("admin_managed")]
        public bool AdminManaged { get; set; }

        [JsonProperty("custom_questions")]
        public EventTypeCustomQuestionsTypeItem[] CustomQuestions { get; set; }
    }

    public class EventTypeProfileType
    {
        [JsonProperty("type")]
        public string ProfileType { get; set; }

        [JsonProperty("name")]
        public string ProfileName { get; set; }

        [JsonProperty("owner")]
        public string ProfileOwnerURI { get; set; }
    }

    public class EventTypeCustomQuestionsTypeItem
    {
        [JsonProperty("name")]
        public string CustomQuestionName { get; set; }

        [JsonProperty("type")]
        public string CustomQuestionType { get; set; }

        [JsonProperty("position")]
        public int CustomQuestionPosition { get; set; }

        [JsonProperty("enabled")]
        public bool CustomQuestionEnabled { get; set; }

        [JsonProperty("required")]
        public bool CustomQuestionRequired { get; set; }

        [JsonProperty("answer_choices")]
        public string[] CustomQuestionAnswerChoices { get; set; }

        [JsonProperty("include_other")]
        public bool IncludeOther { get; set; }
    }

    public class GetEventTypesResponsePaginationType
    {
        [JsonProperty("count")]
        public int PaginationCount { get; set; }

        [JsonProperty("next_page")]
        public string NextPageURI { get; set; }

        [JsonProperty("previous_page")]
        public string PreviousPageURI { get; set; }

        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("previous_page_token")]
        public string PreviousPageToken { get; set; }
    }

    public class CreateInviteeNoShowResponse
    {
        [JsonProperty("resource")]
        public CreateInviteeNoShowResponseResourceType Resource { get; set; }
    }

    public class CreateInviteeNoShowResponseResourceType
    {
        [JsonProperty("uri")]
        public string NoShowURI { get; set; }

        [JsonProperty("invitee")]
        public string InviteeURI { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetEventTypeResponse
    {
        [JsonProperty("resource")]
        public EventType Resource { get; set; }
    }

    public class CreateWebhookSubscriptionResponse
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("payload")]
        public CreateWebhookSubscriptionResponsePayloadType Payload { get; set; }
    }

    public class CreateWebhookSubscriptionResponsePayloadType
    {
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("new_invitee")]
        public string NewInvitee { get; set; }

        [JsonProperty("old_invitee")]
        public string OldInvitee { get; set; }

        [JsonProperty("questions_and_answers")]
        public JToken[] QuestionsAndAnswers { get; set; }

        [JsonProperty("reschedule_url")]
        public string RescheduleUrl { get; set; }

        [JsonProperty("rescheduled")]
        public bool Rescheduled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("text_reminder_number")]
        public string TextReminderNumber { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("tracking")]
        public CreateWebhookSubscriptionResponsePayloadTypeTrackingType Tracking { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("canceled")]
        public bool Canceled { get; set; }
    }

    public class CreateWebhookSubscriptionResponsePayloadTypeTrackingType
    {
        [JsonProperty("utm_campaign")]
        public string UtmCampaign { get; set; }

        [JsonProperty("utm_source")]
        public string UtmSource { get; set; }

        [JsonProperty("utm_medium")]
        public string UtmMedium { get; set; }

        [JsonProperty("utm_content")]
        public string UtmContent { get; set; }

        [JsonProperty("utm_term")]
        public string UtmTerm { get; set; }

        [JsonProperty("salesforce_uuid")]
        public string SalesforceUuid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventsInputItem
    {
        [EnumMember(Value = "routing_form_submission.created")]
        RoutingFormSubmissionCreated
    }

    public class CreateWebhookSubscriptionRoutingFormSubmissionResponse
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("payload")]
        public CreateWebhookSubscriptionRoutingFormSubmissionResponsePayloadType Payload { get; set; }
    }

    public class CreateWebhookSubscriptionRoutingFormSubmissionResponsePayloadType
    {
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("new_invitee")]
        public string NewInvitee { get; set; }

        [JsonProperty("old_invitee")]
        public string OldInvitee { get; set; }

        [JsonProperty("questions_and_answers")]
        public JToken[] QuestionsAndAnswers { get; set; }

        [JsonProperty("reschedule_url")]
        public string RescheduleUrl { get; set; }

        [JsonProperty("rescheduled")]
        public bool Rescheduled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("text_reminder_number")]
        public string TextReminderNumber { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("tracking")]
        public CreateWebhookSubscriptionRoutingFormSubmissionResponsePayloadTypeTrackingType Tracking { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("canceled")]
        public bool Canceled { get; set; }
    }

    public class CreateWebhookSubscriptionRoutingFormSubmissionResponsePayloadTypeTrackingType
    {
        [JsonProperty("utm_campaign")]
        public string UtmCampaign { get; set; }

        [JsonProperty("utm_source")]
        public string UtmSource { get; set; }

        [JsonProperty("utm_medium")]
        public string UtmMedium { get; set; }

        [JsonProperty("utm_content")]
        public string UtmContent { get; set; }

        [JsonProperty("utm_term")]
        public string UtmTerm { get; set; }

        [JsonProperty("salesforce_uuid")]
        public string SalesforceUuid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Calendlyv2;

    public partial class WorkflowManagedActions
    {
        public Calendlyv2Actions Calendlyv2(string connectionId) => new Calendlyv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Calendlyv2Triggers Calendlyv2(string connectionId) => new Calendlyv2Triggers(connectionId);
    }
}
