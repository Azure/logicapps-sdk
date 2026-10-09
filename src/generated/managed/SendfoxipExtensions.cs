//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendfoxip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendfoxipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        public IBodyWorkflowAction<MeGetResponse> MeGet()
        {
            var apiCallPath = "/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MeGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        public IBodyWorkflowAction<ListsGetResponse> ListsGet()
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildList))]
        public IBodyWorkflowAction<ListPostResponse> List([WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPostResponse> __BuildList(WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<ListPostResponse>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildListGet))]
        public IBodyWorkflowAction<ListGetResponse> ListGet([WorkflowExpression] Func<string> listId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGetResponse> __BuildListGet(WorkflowExpression<string> listId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            return new DeferredBodyAction<ListGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildListContactDelete))]
        public IBodyWorkflowAction<ListContactDeleteResponse> ListContactDelete([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListContactDeleteResponse> __BuildListContactDelete(WorkflowExpression<string> listId, WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ListContactDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1), ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContactDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet()
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildContact))]
        public IBodyWorkflowAction<ContactPostResponse> Contact([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string[]> bodylists = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactPostResponse> __BuildContact(WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string[]> bodylists = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodylists, nameof(bodylists), required: false);
            return new DeferredBodyAction<ContactPostResponse>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodylists != null)
                {
                    body["lists"] = ExpressionConverter.ConvertO(bodylists);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildContactGet))]
        public IBodyWorkflowAction<ContactGetResponse> ContactGet([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactGetResponse> __BuildContactGet(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ContactGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildUnsubscribePatch))]
        public IBodyWorkflowAction<UnsubscribePatchResponse> UnsubscribePatch([WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnsubscribePatchResponse> __BuildUnsubscribePatch(WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<UnsubscribePatchResponse>(() =>
            {
                var apiCallPath = "/unsubscribe";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnsubscribePatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        public IBodyWorkflowAction<CampaignsGetResponse> CampaignsGet()
        {
            var apiCallPath = "/campaigns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendfoxip")]
        [WorkflowExpressionFactory(nameof(__BuildCampaignGet))]
        public IBodyWorkflowAction<CampaignGetResponse> CampaignGet([WorkflowExpression] Func<string> campaignId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CampaignGetResponse> __BuildCampaignGet(WorkflowExpression<string> campaignId)
        {
            WorkflowExpression.Validate(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignGetResponse>(callPayload);
            });
        }
    }

    public class SendfoxipTriggers([ConnectionName] string connectionId)
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

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("disabled_at")]
        public string DisabledAt { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("vanity_path")]
        public string VanityPath { get; set; }

        [JsonProperty("contact_referrals_enabled_at")]
        public string ContactReferralsEnabledAt { get; set; }

        [JsonProperty("google_id")]
        public string GoogleId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class ListsGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public ListsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

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

    public class ListsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subscribed_contacts_count")]
        public int SubscribedContactsCount { get; set; }
    }

    public class ListPostResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ListGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subscribed_contacts_count")]
        public int SubscribedContactsCount { get; set; }

        [JsonProperty("average_email_open_percent")]
        public string AverageEmailOpenPercent { get; set; }

        [JsonProperty("average_email_click_percent")]
        public string AverageEmailClickPercent { get; set; }
    }

    public class ListContactDeleteResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("bounced_at")]
        public string BouncedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("contact_import_id")]
        public string ContactImportId { get; set; }

        [JsonProperty("via_api")]
        public bool ViaApi { get; set; }

        [JsonProperty("last_opened_at")]
        public string LastOpenedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("first_sent_at")]
        public string FirstSentAt { get; set; }

        [JsonProperty("last_sent_at")]
        public string LastSentAt { get; set; }

        [JsonProperty("invalid_at")]
        public string InvalidAt { get; set; }

        [JsonProperty("inactive_at")]
        public string InactiveAt { get; set; }

        [JsonProperty("confirmed_at")]
        public string ConfirmedAt { get; set; }

        [JsonProperty("social_platform_id")]
        public string SocialPlatformId { get; set; }

        [JsonProperty("confirmation_sent_at")]
        public string ConfirmationSentAt { get; set; }

        [JsonProperty("confirmation_sent_count")]
        public int ConfirmationSentCount { get; set; }

        [JsonProperty("created_ago")]
        public string CreatedAgo { get; set; }

        [JsonProperty("contact_fields")]
        public string[] ContactFields { get; set; }
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

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("bounced_at")]
        public string BouncedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("contact_import_id")]
        public string ContactImportId { get; set; }

        [JsonProperty("via_api")]
        public bool ViaApi { get; set; }

        [JsonProperty("last_opened_at")]
        public string LastOpenedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("first_sent_at")]
        public string FirstSentAt { get; set; }

        [JsonProperty("last_sent_at")]
        public string LastSentAt { get; set; }

        [JsonProperty("invalid_at")]
        public string InvalidAt { get; set; }

        [JsonProperty("inactive_at")]
        public string InactiveAt { get; set; }

        [JsonProperty("confirmed_at")]
        public string ConfirmedAt { get; set; }

        [JsonProperty("social_platform_id")]
        public string SocialPlatformId { get; set; }

        [JsonProperty("confirmation_sent_at")]
        public string ConfirmationSentAt { get; set; }

        [JsonProperty("confirmation_sent_count")]
        public int ConfirmationSentCount { get; set; }

        [JsonProperty("created_ago")]
        public string CreatedAgo { get; set; }

        [JsonProperty("contact_fields")]
        public string[] ContactFields { get; set; }

        [JsonProperty("lists")]
        public ContactsGetResponseDataTypeItemListsTypeItem[] Lists { get; set; }
    }

    public class ContactsGetResponseDataTypeItemListsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class ContactPostResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("via_api")]
        public bool ViaApi { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("confirmation_sent_count")]
        public int ConfirmationSentCount { get; set; }

        [JsonProperty("created_ago")]
        public string CreatedAgo { get; set; }
    }

    public class ContactGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("bounced_at")]
        public string BouncedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("contact_import_id")]
        public string ContactImportId { get; set; }

        [JsonProperty("via_api")]
        public bool ViaApi { get; set; }

        [JsonProperty("last_opened_at")]
        public string LastOpenedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("first_sent_at")]
        public string FirstSentAt { get; set; }

        [JsonProperty("last_sent_at")]
        public string LastSentAt { get; set; }

        [JsonProperty("invalid_at")]
        public string InvalidAt { get; set; }

        [JsonProperty("inactive_at")]
        public string InactiveAt { get; set; }

        [JsonProperty("confirmed_at")]
        public string ConfirmedAt { get; set; }

        [JsonProperty("social_platform_id")]
        public string SocialPlatformId { get; set; }

        [JsonProperty("confirmation_sent_at")]
        public string ConfirmationSentAt { get; set; }

        [JsonProperty("confirmation_sent_count")]
        public int ConfirmationSentCount { get; set; }

        [JsonProperty("created_ago")]
        public string CreatedAgo { get; set; }

        [JsonProperty("contact_fields")]
        public ContactGetResponseContactFieldsTypeItem[] ContactFields { get; set; }
    }

    public class ContactGetResponseContactFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UnsubscribePatchResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("unsubscribed_at")]
        public string UnsubscribedAt { get; set; }

        [JsonProperty("bounced_at")]
        public string BouncedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("contact_import_id")]
        public string ContactImportId { get; set; }

        [JsonProperty("via_api")]
        public bool ViaApi { get; set; }

        [JsonProperty("last_opened_at")]
        public string LastOpenedAt { get; set; }

        [JsonProperty("last_clicked_at")]
        public string LastClickedAt { get; set; }

        [JsonProperty("first_sent_at")]
        public string FirstSentAt { get; set; }

        [JsonProperty("last_sent_at")]
        public string LastSentAt { get; set; }

        [JsonProperty("invalid_at")]
        public string InvalidAt { get; set; }

        [JsonProperty("inactive_at")]
        public string InactiveAt { get; set; }

        [JsonProperty("confirmed_at")]
        public string ConfirmedAt { get; set; }

        [JsonProperty("social_platform_id")]
        public string SocialPlatformId { get; set; }

        [JsonProperty("confirmation_sent_at")]
        public string ConfirmationSentAt { get; set; }

        [JsonProperty("confirmation_sent_count")]
        public int ConfirmationSentCount { get; set; }

        [JsonProperty("created_ago")]
        public string CreatedAgo { get; set; }

        [JsonProperty("contact_fields")]
        public string[] ContactFields { get; set; }
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

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("slugged_subject")]
        public string SluggedSubject { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("automation_item_id")]
        public string AutomationItemId { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("sent_at")]
        public string SentAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("attempted_send_count")]
        public int AttemptedSendCount { get; set; }

        [JsonProperty("sent_count")]
        public int SentCount { get; set; }

        [JsonProperty("unique_open_count")]
        public int UniqueOpenCount { get; set; }

        [JsonProperty("unique_click_count")]
        public int UniqueClickCount { get; set; }

        [JsonProperty("unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        [JsonProperty("bounce_count")]
        public int BounceCount { get; set; }

        [JsonProperty("spam_count")]
        public int SpamCount { get; set; }

        [JsonProperty("campaign_layout_id")]
        public string CampaignLayoutId { get; set; }

        [JsonProperty("throttled_at")]
        public string ThrottledAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("active_contacts_only")]
        public int ActiveContactsOnly { get; set; }

        [JsonProperty("smart_campaign_id")]
        public string SmartCampaignId { get; set; }

        [JsonProperty("campaign_category_id")]
        public string CampaignCategoryId { get; set; }

        [JsonProperty("preview_text")]
        public string PreviewText { get; set; }

        [JsonProperty("approval_required_at")]
        public string ApprovalRequiredAt { get; set; }

        [JsonProperty("subject_tester_results")]
        public CampaignsGetResponseDataTypeItemSubjectTesterResultsType SubjectTesterResults { get; set; }

        [JsonProperty("preview_text_auto")]
        public string PreviewTextAuto { get; set; }
    }

    public class CampaignsGetResponseDataTypeItemSubjectTesterResultsType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("words")]
        public string[] Words { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("testMethods")]
        public CampaignsGetResponseDataTypeItemSubjectTesterResultsTypeTestMethodsType TestMethods { get; set; }

        [JsonProperty("testResults")]
        public CampaignsGetResponseDataTypeItemSubjectTesterResultsTypeTestResultsType TestResults { get; set; }

        [JsonProperty("badWords")]
        public string[] BadWords { get; set; }

        [JsonProperty("spamWords")]
        public string[] SpamWords { get; set; }

        [JsonProperty("letterGrade")]
        public string LetterGrade { get; set; }
    }

    public class CampaignsGetResponseDataTypeItemSubjectTesterResultsTypeTestMethodsType
    {
        [JsonProperty("exclamationTest")]
        public int ExclamationTest { get; set; }

        [JsonProperty("tooShortTest")]
        public int TooShortTest { get; set; }

        [JsonProperty("tooLongTest")]
        public int TooLongTest { get; set; }

        [JsonProperty("fwdReTest")]
        public int FwdReTest { get; set; }

        [JsonProperty("freeTest")]
        public int FreeTest { get; set; }

        [JsonProperty("capsWordsTest")]
        public int CapsWordsTest { get; set; }

        [JsonProperty("lowercaseTest")]
        public int LowercaseTest { get; set; }

        [JsonProperty("questionTest")]
        public int QuestionTest { get; set; }

        [JsonProperty("punctuationTest")]
        public int PunctuationTest { get; set; }

        [JsonProperty("personalizationTest")]
        public int PersonalizationTest { get; set; }

        [JsonProperty("emojiTest")]
        public int EmojiTest { get; set; }

        [JsonProperty("badWordTest")]
        public int BadWordTest { get; set; }

        [JsonProperty("spamWordTest")]
        public int SpamWordTest { get; set; }
    }

    public class CampaignsGetResponseDataTypeItemSubjectTesterResultsTypeTestResultsType
    {
        [JsonProperty("exclamationTest")]
        public bool ExclamationTest { get; set; }

        [JsonProperty("tooShortTest")]
        public bool TooShortTest { get; set; }

        [JsonProperty("tooLongTest")]
        public bool TooLongTest { get; set; }

        [JsonProperty("fwdReTest")]
        public bool FwdReTest { get; set; }

        [JsonProperty("freeTest")]
        public bool FreeTest { get; set; }

        [JsonProperty("capsWordsTest")]
        public bool CapsWordsTest { get; set; }

        [JsonProperty("lowercaseTest")]
        public bool LowercaseTest { get; set; }

        [JsonProperty("questionTest")]
        public bool QuestionTest { get; set; }

        [JsonProperty("punctuationTest")]
        public bool PunctuationTest { get; set; }

        [JsonProperty("personalizationTest")]
        public bool PersonalizationTest { get; set; }

        [JsonProperty("emojiTest")]
        public bool EmojiTest { get; set; }

        [JsonProperty("badWordTest")]
        public bool BadWordTest { get; set; }

        [JsonProperty("spamWordTest")]
        public bool SpamWordTest { get; set; }
    }

    public class CampaignGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("slugged_subject")]
        public string SluggedSubject { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("automation_item_id")]
        public string AutomationItemId { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("sent_at")]
        public string SentAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("attempted_send_count")]
        public int AttemptedSendCount { get; set; }

        [JsonProperty("sent_count")]
        public int SentCount { get; set; }

        [JsonProperty("unique_open_count")]
        public int UniqueOpenCount { get; set; }

        [JsonProperty("unique_click_count")]
        public int UniqueClickCount { get; set; }

        [JsonProperty("unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        [JsonProperty("bounce_count")]
        public int BounceCount { get; set; }

        [JsonProperty("spam_count")]
        public int SpamCount { get; set; }

        [JsonProperty("campaign_layout_id")]
        public string CampaignLayoutId { get; set; }

        [JsonProperty("throttled_at")]
        public string ThrottledAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("active_contacts_only")]
        public int ActiveContactsOnly { get; set; }

        [JsonProperty("smart_campaign_id")]
        public string SmartCampaignId { get; set; }

        [JsonProperty("campaign_category_id")]
        public string CampaignCategoryId { get; set; }

        [JsonProperty("preview_text")]
        public string PreviewText { get; set; }

        [JsonProperty("approval_required_at")]
        public string ApprovalRequiredAt { get; set; }

        [JsonProperty("subject_tester_results")]
        public CampaignGetResponseSubjectTesterResultsType SubjectTesterResults { get; set; }

        [JsonProperty("preview_text_auto")]
        public string PreviewTextAuto { get; set; }
    }

    public class CampaignGetResponseSubjectTesterResultsType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("words")]
        public string[] Words { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("testMethods")]
        public CampaignGetResponseSubjectTesterResultsTypeTestMethodsType TestMethods { get; set; }

        [JsonProperty("testResults")]
        public CampaignGetResponseSubjectTesterResultsTypeTestResultsType TestResults { get; set; }

        [JsonProperty("badWords")]
        public string[] BadWords { get; set; }

        [JsonProperty("spamWords")]
        public string[] SpamWords { get; set; }

        [JsonProperty("letterGrade")]
        public string LetterGrade { get; set; }
    }

    public class CampaignGetResponseSubjectTesterResultsTypeTestMethodsType
    {
        [JsonProperty("exclamationTest")]
        public int ExclamationTest { get; set; }

        [JsonProperty("tooShortTest")]
        public int TooShortTest { get; set; }

        [JsonProperty("tooLongTest")]
        public int TooLongTest { get; set; }

        [JsonProperty("fwdReTest")]
        public int FwdReTest { get; set; }

        [JsonProperty("freeTest")]
        public int FreeTest { get; set; }

        [JsonProperty("capsWordsTest")]
        public int CapsWordsTest { get; set; }

        [JsonProperty("lowercaseTest")]
        public int LowercaseTest { get; set; }

        [JsonProperty("questionTest")]
        public int QuestionTest { get; set; }

        [JsonProperty("punctuationTest")]
        public int PunctuationTest { get; set; }

        [JsonProperty("personalizationTest")]
        public int PersonalizationTest { get; set; }

        [JsonProperty("emojiTest")]
        public int EmojiTest { get; set; }

        [JsonProperty("badWordTest")]
        public int BadWordTest { get; set; }

        [JsonProperty("spamWordTest")]
        public int SpamWordTest { get; set; }
    }

    public class CampaignGetResponseSubjectTesterResultsTypeTestResultsType
    {
        [JsonProperty("exclamationTest")]
        public bool ExclamationTest { get; set; }

        [JsonProperty("tooShortTest")]
        public bool TooShortTest { get; set; }

        [JsonProperty("tooLongTest")]
        public bool TooLongTest { get; set; }

        [JsonProperty("fwdReTest")]
        public bool FwdReTest { get; set; }

        [JsonProperty("freeTest")]
        public bool FreeTest { get; set; }

        [JsonProperty("capsWordsTest")]
        public bool CapsWordsTest { get; set; }

        [JsonProperty("lowercaseTest")]
        public bool LowercaseTest { get; set; }

        [JsonProperty("questionTest")]
        public bool QuestionTest { get; set; }

        [JsonProperty("punctuationTest")]
        public bool PunctuationTest { get; set; }

        [JsonProperty("personalizationTest")]
        public bool PersonalizationTest { get; set; }

        [JsonProperty("emojiTest")]
        public bool EmojiTest { get; set; }

        [JsonProperty("badWordTest")]
        public bool BadWordTest { get; set; }

        [JsonProperty("spamWordTest")]
        public bool SpamWordTest { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sendfoxip;

    public partial class WorkflowManagedActions
    {
        public SendfoxipActions Sendfoxip(string connectionId) => new SendfoxipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SendfoxipTriggers Sendfoxip(string connectionId) => new SendfoxipTriggers(connectionId);
    }
}