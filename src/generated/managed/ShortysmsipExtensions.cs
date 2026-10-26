//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shortysmsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShortysmsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<MeGetResponse, ApiConnectionActionConfiguration> MeGet()
        {
            return new DeferredBodyAction<MeGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<ContactsGetResponse, ApiConnectionActionConfiguration> ContactsGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ContactsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ContactsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<ContactsPostResponse, ApiConnectionActionConfiguration> Contacts(Expression<Func<ContactsPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ContactsPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactsPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<ContactListsGetResponse, ApiConnectionActionConfiguration> ContactListsGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ContactListsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contact-lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ContactListsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<ContactListsPostResponse, ApiConnectionActionConfiguration> ContactLists(Expression<Func<ContactListsPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ContactListsPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contact-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactListsPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<TriggersGetResponse, ApiConnectionActionConfiguration> TriggersGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<TriggersGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contact-list-triggers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<TriggersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<TriggersPostResponse, ApiConnectionActionConfiguration> Triggers(Expression<Func<TriggersPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggersPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contact-list-triggers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TriggersPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<CampaignsGetResponse, ApiConnectionActionConfiguration> CampaignsGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<CampaignsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/campaigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<CampaignsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<AutomationsGetResponse, ApiConnectionActionConfiguration> AutomationsGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<AutomationsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/automations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<AutomationsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shortysmsip")]
        public IBodyWorkflowAction<DeliverablesGetResponse, ApiConnectionActionConfiguration> DeliverablesGet(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DeliverablesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/incoming-deliverables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<DeliverablesGetResponse>(callPayload);
            });
        }
    }

    public class ShortysmsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MeGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("lifetime_subscription_plan_id")]
        public string LifetimeSubscriptionPlanId { get; set; }

        [JsonProperty("subscription_plan_id")]
        public string SubscriptionPlanId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("disabled_at")]
        public string DisabledAt { get; set; }
    }

    public class ContactsGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public ContactsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("links")]
        public ContactsGetResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ContactsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("phone_formatted")]
        public string PhoneFormatted { get; set; }
    }

    public class ContactsGetResponseLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class ContactsPostResponse
    {
        [JsonProperty("contact")]
        public ContactsPostResponseContactType Contact { get; set; }
    }

    public class ContactsPostResponseContactType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("phone_formatted")]
        public string PhoneFormatted { get; set; }
    }

    public class ContactsPostInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }

        [JsonProperty("contact_list_id")]
        public int? ContactListId { get; set; }
    }

    public class ContactListsGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public ContactListsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("links")]
        public ContactListsGetResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ContactListsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }

    public class ContactListsGetResponseLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class ContactListsPostResponse
    {
        [JsonProperty("contactList")]
        public ContactListsPostResponseContactListType ContactList { get; set; }
    }

    public class ContactListsPostResponseContactListType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ContactListsPostInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class TriggersGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public TriggersGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("links")]
        public TriggersGetResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TriggersGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("trigger_string")]
        public string TriggerString { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("contact_list")]
        public TriggersGetResponseDataTypeItemContactListType ContactList { get; set; }
    }

    public class TriggersGetResponseDataTypeItemContactListType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }

    public class TriggersGetResponseLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class TriggersPostResponse
    {
        [JsonProperty("contactListTrigger")]
        public TriggersPostResponseContactListTriggerType ContactListTrigger { get; set; }
    }

    public class TriggersPostResponseContactListTriggerType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("trigger_string")]
        public string TriggerString { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class TriggersPostInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("trigger_string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TriggerString { get; set; }

        [JsonProperty("contact_list_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ContactListId { get; set; }

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggersPostInputActiveType? Active { get; set; } = TriggersPostInputActiveType._0;
    }

    public enum TriggersPostInputActiveType
    {
        _0 = 0,
        _1 = 1
    }

    public class CampaignsGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public CampaignsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("links")]
        public CampaignsGetResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class CampaignsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("sent_at")]
        public string SentAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("click_tracking_enabled")]
        public int ClickTrackingEnabled { get; set; }

        [JsonProperty("from_phone_number")]
        public string FromPhoneNumber { get; set; }

        [JsonProperty("is_campaign")]
        public bool IsCampaign { get; set; }

        [JsonProperty("is_automation")]
        public bool IsAutomation { get; set; }

        [JsonProperty("is_direct_message")]
        public bool IsDirectMessage { get; set; }

        [JsonProperty("contact_lists")]
        public CampaignsGetResponseDataTypeItemContactListsTypeItem[] ContactLists { get; set; }
    }

    public class CampaignsGetResponseDataTypeItemContactListsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }

    public class CampaignsGetResponseLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class AutomationsGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public AutomationsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("links")]
        public AutomationsGetResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AutomationsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("contact_list_id")]
        public int ContactListId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }

    public class AutomationsGetResponseLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class DeliverablesGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public DeliverablesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("links")]
        public DeliverablesGetResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DeliverablesGetResponseDataTypeItem
    {
        [JsonProperty("twilio_sid")]
        public string TwilioSid { get; set; }

        [JsonProperty("contact_id")]
        public int ContactId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("read_at")]
        public string ReadAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_unsubscribe")]
        public bool IsUnsubscribe { get; set; }

        [JsonProperty("is_resubscribe")]
        public bool IsResubscribe { get; set; }

        [JsonProperty("contact")]
        public DeliverablesGetResponseDataTypeItemContactType Contact { get; set; }
    }

    public class DeliverablesGetResponseDataTypeItemContactType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("phone_formatted")]
        public string PhoneFormatted { get; set; }
    }

    public class DeliverablesGetResponseLinksTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shortysmsip;

    public partial class WorkflowManagedActions
    {
        public ShortysmsipActions Shortysmsip(string connectionId) => new ShortysmsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShortysmsipTriggers Shortysmsip(string connectionId) => new ShortysmsipTriggers(connectionId);
    }
}