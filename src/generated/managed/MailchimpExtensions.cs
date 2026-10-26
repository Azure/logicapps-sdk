//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailchimp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailchimpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetCampaignsResponse, ApiConnectionActionConfiguration> GetCampaigns()
        {
            return new DeferredBodyAction<GetCampaignsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/campaigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCampaignsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Sendcampaign(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/actions/send", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetListsResponseModel, ApiConnectionActionConfiguration> GetLists(Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<GetListsResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<GetListsResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CreateNewListResponseModel, ApiConnectionActionConfiguration> Newlist(Expression<Func<NewlistInput>> newListRequest)
        {
            var __workflow_newListRequest = WorkflowExpression.Compile(newListRequest, nameof(newListRequest), required: true);
            return new DeferredBodyAction<CreateNewListResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newListRequest);
                return new ApiConnectionAction<CreateNewListResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel, ApiConnectionActionConfiguration> AddMembers(Expression<Func<string>> listId, Expression<Func<AddMembersInput>> body, Expression<Func<bool>> skipMergeValidation = null, Expression<Func<bool>> skipDuplicateCheck = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_skipMergeValidation = WorkflowExpression.Compile(skipMergeValidation, nameof(skipMergeValidation), required: false);
            var __workflow_skipDuplicateCheck = WorkflowExpression.Compile(skipDuplicateCheck, nameof(skipDuplicateCheck), required: false);
            return new DeferredBodyAction<GetAddMembersBatchResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_skipMergeValidation != null)
                    callPayload.Queries["skip_merge_validation"] = ExpressionConverter.Convert(__workflow_skipMergeValidation);
                if (__workflow_skipDuplicateCheck != null)
                    callPayload.Queries["skip_duplicate_check"] = ExpressionConverter.Convert(__workflow_skipDuplicateCheck);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAddMembersBatchResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAllMembersResponseModel, ApiConnectionActionConfiguration> GetListMembers(Expression<Func<string>> listId, Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<GetAllMembersResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/members", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<GetAllMembersResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel, ApiConnectionActionConfiguration> Addmember(Expression<Func<string>> listId, Expression<Func<AddmemberInput>> newMemberInList)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_newMemberInList = WorkflowExpression.Compile(newMemberInList, nameof(newMemberInList), required: true);
            return new DeferredBodyAction<MemberResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/members", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newMemberInList);
                return new ApiConnectionAction<MemberResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CampaignResponseModel, ApiConnectionActionConfiguration> Newcampaign(Expression<Func<NewcampaignV2Input>> newCampaignRequest)
        {
            var __workflow_newCampaignRequest = WorkflowExpression.Compile(newCampaignRequest, nameof(newCampaignRequest), required: true);
            return new DeferredBodyAction<CampaignResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_newCampaignRequest);
                return new ApiConnectionAction<CampaignResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Removemember(Expression<Func<string>> listId, Expression<Func<string>> memberEmail)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_memberEmail = WorkflowExpression.Compile(memberEmail, nameof(memberEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/replacemailwithhash/{0}/members", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = ExpressionConverter.Convert(__workflow_memberEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel, ApiConnectionActionConfiguration> Updatemember(Expression<Func<string>> listId, Expression<Func<string>> memberEmail, Expression<Func<UpdatememberV2Input>> updateMemberInListRequest)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_memberEmail = WorkflowExpression.Compile(memberEmail, nameof(memberEmail), required: true);
            var __workflow_updateMemberInListRequest = WorkflowExpression.Compile(updateMemberInListRequest, nameof(updateMemberInListRequest), required: true);
            return new DeferredBodyAction<MemberResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/replacemailwithhash/{0}/members", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = ExpressionConverter.Convert(__workflow_memberEmail);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequest);
                return new ApiConnectionAction<MemberResponseModel>(callPayload);
            });
        }
    }

    public class MailchimpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetMembersResponseModel, ApiConnectionTriggerConfiguration> OnMemberSubscribed(Expression<Func<string>> listId, FlowRecurrence recurrence = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<GetMembersResponseModel, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/lists/{0}/members", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetMembersResponseModel>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetListsResponseModel, ApiConnectionTriggerConfiguration> OnCreateList(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<GetListsResponseModel, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetListsResponseModel>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetCampaignsResponse
    {
        [JsonProperty("campaigns")]
        public CampaignResponseModel[] Campaigns { get; set; }
    }

    public class CampaignResponseModel
    {
        [JsonProperty("id")]
        public string CampaignId { get; set; }

        [JsonProperty("type")]
        public CampaignResponseModelCampaignTypeType CampaignType { get; set; }

        [JsonProperty("create_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveURL { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("send_time")]
        public string SendTime { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("recipient")]
        public Recipient[] List { get; set; }

        [JsonProperty("settings")]
        public SettingsV2 Settings { get; set; }

        [JsonProperty("variate_settings")]
        public VariateSettings VariateSettings { get; set; }

        [JsonProperty("tracking")]
        public Tracking Tracking { get; set; }

        [JsonProperty("rss_opts")]
        public RSSOpts RssOpts { get; set; }

        [JsonProperty("ab_split_opts")]
        public ABSplitOpts AbSplitOpts { get; set; }

        [JsonProperty("social_card")]
        public SocialCard SocialCard { get; set; }

        [JsonProperty("report_summary")]
        public ReportSummary ReportSummary { get; set; }

        [JsonProperty("delivery_status")]
        public DeliveryStatus DeliveryStatus { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CampaignResponseModelCampaignTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "plaintext")]
        Plaintext,
        [EnumMember(Value = "absplit")]
        Absplit,
        [EnumMember(Value = "rss")]
        Rss,
        [EnumMember(Value = "variate")]
        Variate
    }

    public class Recipient
    {
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("segment_opts")]
        public SegmentOpts SegmentOpts { get; set; }
    }

    public class SegmentOpts
    {
        [JsonProperty("saved_segment_id")]
        public int SavedSegmentId { get; set; }

        [JsonProperty("match")]
        public string MatchType { get; set; }
    }

    public class SettingsV2
    {
        [JsonProperty("subject_line")]
        public string CampaignSubjectLine { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyToAddress { get; set; }

        [JsonProperty("use_conversation")]
        public bool Conversation { get; set; }

        [JsonProperty("to_name")]
        public string ToName { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("authenticate")]
        public bool Authentication { get; set; }

        [JsonProperty("auto_footer")]
        public bool AutoFooter { get; set; }

        [JsonProperty("inline_css")]
        public bool InlineCSS { get; set; }

        [JsonProperty("auto_tweet")]
        public bool AutoTweet { get; set; }

        [JsonProperty("auto_fb_post")]
        public int[] AutoPostToFacebook { get; set; }

        [JsonProperty("fb_comments")]
        public bool FacebookComments { get; set; }
    }

    public class VariateSettings
    {
        [JsonProperty("winner_criteria")]
        public string WinningCriteria { get; set; }

        [JsonProperty("wait_time")]
        public int WaitTime { get; set; }

        [JsonProperty("test_size")]
        public int TestSize { get; set; }

        [JsonProperty("subject_lines")]
        public string[] SubjectLines { get; set; }

        [JsonProperty("send_times")]
        public string[] SendTimes { get; set; }

        [JsonProperty("from_names")]
        public string[] FromNames { get; set; }

        [JsonProperty("reply_to_addresses")]
        public string[] ReplyToAddresses { get; set; }
    }

    public class Tracking
    {
        [JsonProperty("opens")]
        public bool Opens { get; set; }

        [JsonProperty("html_clicks")]
        public bool HTMLClickTracking { get; set; }

        [JsonProperty("text_clicks")]
        public bool PlainTextClickTracking { get; set; }

        [JsonProperty("goal_tracking")]
        public bool MailChimpGoalTracking { get; set; }

        [JsonProperty("ecomm360")]
        public bool ECommerce360Tracking { get; set; }

        [JsonProperty("google_analytics")]
        public string GoogleAnalyticsTracking { get; set; }

        [JsonProperty("clicktale")]
        public string ClickTaleAnalyticsTracking { get; set; }

        [JsonProperty("salesforce")]
        public Salesforce Salesforce { get; set; }

        [JsonProperty("highrise")]
        public Highrise Highrise { get; set; }

        [JsonProperty("capsule")]
        public Capsule Capsule { get; set; }
    }

    public class Salesforce
    {
        [JsonProperty("campaign")]
        public bool SalesforceCampaign { get; set; }

        [JsonProperty("notes")]
        public bool SalesforceNote { get; set; }
    }

    public class Highrise
    {
        [JsonProperty("campaign")]
        public bool HighriseCampaign { get; set; }

        [JsonProperty("notes")]
        public bool HighriseNote { get; set; }
    }

    public class Capsule
    {
        [JsonProperty("notes")]
        public bool CapsuleNote { get; set; }
    }

    public class RSSOpts
    {
        [JsonProperty("feed_url")]
        public string FeedURL { get; set; }

        [JsonProperty("frequency")]
        public RSSOptsFrequencyType Frequency { get; set; }

        [JsonProperty("constrain_rss_img")]
        public string ConstrainRSSImages { get; set; }

        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RSSOptsFrequencyType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "monthly")]
        Monthly
    }

    public class Schedule
    {
        [JsonProperty("hour")]
        public int SendingHour { get; set; }

        [JsonProperty("daily_send")]
        public DailySend DailySend { get; set; }

        [JsonProperty("weekly_send_day")]
        public ScheduleWeeklySendingDayType WeeklySendingDay { get; set; }

        [JsonProperty("monthly_send_date")]
        public double MonthlySendingDay { get; set; }
    }

    public class DailySend
    {
        [JsonProperty("sunday")]
        public bool Sunday { get; set; }

        [JsonProperty("monday")]
        public bool Monday { get; set; }

        [JsonProperty("tuesday")]
        public bool Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public bool Wednesday { get; set; }

        [JsonProperty("thursday")]
        public bool Thursday { get; set; }

        [JsonProperty("friday")]
        public bool Friday { get; set; }

        [JsonProperty("saturday")]
        public bool Saturday { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScheduleWeeklySendingDayType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "sunday")]
        Sunday,
        [EnumMember(Value = "monday")]
        Monday,
        [EnumMember(Value = "tuesday")]
        Tuesday,
        [EnumMember(Value = "wednesday")]
        Wednesday,
        [EnumMember(Value = "thursday")]
        Thursday,
        [EnumMember(Value = "friday")]
        Friday,
        [EnumMember(Value = "saturday")]
        Saturday
    }

    public class ABSplitOpts
    {
        [JsonProperty("split_test")]
        public string SplitTest { get; set; }

        [JsonProperty("pick_winner")]
        public string PickWinner { get; set; }

        [JsonProperty("wait_time")]
        public int WaitTime { get; set; }

        [JsonProperty("split_size")]
        public int SplitSize { get; set; }

        [JsonProperty("from_name_a")]
        public string FromNameGroupA { get; set; }

        [JsonProperty("from_name_b")]
        public string FromNameGroupB { get; set; }

        [JsonProperty("reply_email_a")]
        public string ReplyEmailGroupA { get; set; }

        [JsonProperty("reply_email_b")]
        public string ReplyEmailGroupB { get; set; }

        [JsonProperty("subject_a")]
        public string SubjectLineGroupA { get; set; }

        [JsonProperty("subject_b")]
        public string SubjectLineGroupB { get; set; }

        [JsonProperty("send_time_a")]
        public string SendTimeGroupA { get; set; }

        [JsonProperty("send_time_b")]
        public string SendTimeGroupB { get; set; }

        [JsonProperty("send_time_winner")]
        public string SendTimeWinner { get; set; }
    }

    public class SocialCard
    {
        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("description")]
        public string CampaignDescription { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ReportSummary
    {
        [JsonProperty("opens")]
        public int AutomationOpens { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("clicks")]
        public int TotalClicks { get; set; }

        [JsonProperty("subscriber_clicks")]
        public double UniqueSubscriberClicks { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }
    }

    public class DeliveryStatus
    {
        [JsonProperty("enabled")]
        public bool DeliveryStautEnabled { get; set; }

        [JsonProperty("can_cancel")]
        public bool CampaignCancelable { get; set; }

        [JsonProperty("status")]
        public string CampaignDeliveryStatus { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("emails_canceled")]
        public int EmailsCanceled { get; set; }
    }

    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("targetSchema")]
        public string TargetSchema { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class GetListsResponseModel
    {
        [JsonProperty("lists")]
        public CreateNewListResponseModel[] Lists { get; set; }

        [JsonProperty("total_items")]
        public int ItemCount { get; set; }
    }

    public class CreateNewListResponseModel
    {
        [JsonProperty("id")]
        public string ListId { get; set; }

        [JsonProperty("name")]
        public string ListName { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("permission_reminder")]
        public string PermissionReminder { get; set; }

        [JsonProperty("use_archive_bar")]
        public bool UseArchiveBar { get; set; }

        [JsonProperty("campaign_defaults")]
        public CampaignDefaults CampaignDefaults { get; set; }

        [JsonProperty("notify_on_subscribe")]
        public string NotifyOnSubscribe { get; set; }

        [JsonProperty("notify_on_unsubscribe")]
        public string NotifyOnUnsubscribe { get; set; }

        [JsonProperty("date_created")]
        public string CreationDate { get; set; }

        [JsonProperty("list_rating")]
        public int ListRating { get; set; }

        [JsonProperty("email_type_option")]
        public bool EmailTypeOption { get; set; }

        [JsonProperty("subscribe_url_short")]
        public string SubscribeURLShort { get; set; }

        [JsonProperty("subscribe_url_long")]
        public string SubscribeURLLong { get; set; }

        [JsonProperty("beamer_address")]
        public string BeamerAddress { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("modules")]
        public string[] Modules { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    public class Contact
    {
        [JsonProperty("company")]
        public string CompanyName { get; set; }

        [JsonProperty("address1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string PhoneNumber { get; set; }
    }

    public class CampaignDefaults
    {
        [JsonProperty("from_name")]
        public string SenderSName { get; set; }

        [JsonProperty("from_email")]
        public string SenderSEmailAddress { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("language")]
        public CampaignDefaultsLanguageType Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CampaignDefaultsLanguageType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "af")]
        Af,
        [EnumMember(Value = "be")]
        Be,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh")]
        Zh,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fa")]
        Fa,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "fr_CA")]
        FrCA,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "el")]
        El,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "ga")]
        Ga,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "km")]
        Km,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "mt")]
        Mt,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "mk")]
        Mk,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "pt_PT")]
        PtPT,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sr")]
        Sr,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "es_ES")]
        EsES,
        [EnumMember(Value = "sw")]
        Sw,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi
    }

    public class Stats
    {
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        [JsonProperty("cleaned_count")]
        public int CleanedCount { get; set; }

        [JsonProperty("member_count_since_send")]
        public int MemberCountSinceSend { get; set; }

        [JsonProperty("unsubscribe_count_since_send")]
        public int UnsubscribeCountSinceSend { get; set; }

        [JsonProperty("cleaned_count_since_send")]
        public int CleanedCountSinceSend { get; set; }

        [JsonProperty("campaign_count")]
        public int CampaignCount { get; set; }

        [JsonProperty("campaign_last_sent")]
        public string CampaignLastSent { get; set; }

        [JsonProperty("merge_field_count")]
        public int MergeVarCount { get; set; }

        [JsonProperty("avg_sub_rate")]
        public double AverageSubscriptionRate { get; set; }

        [JsonProperty("avg_unsub_rate")]
        public double AverageUnsubscriptionRate { get; set; }

        [JsonProperty("target_sub_rate")]
        public double TargetSubscriptionRate { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        [JsonProperty("last_sub_date")]
        public string DateOfLastListSubscribe { get; set; }

        [JsonProperty("last_unsub_date")]
        public string DateOfLastListUnsubscribe { get; set; }
    }

    public class NewlistInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Include)]
        public Contact Contact { get; set; }

        [JsonProperty("permission_reminder", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PermissionReminder { get; set; }

        [JsonProperty("use_archive_bar")]
        public bool? UseArchiveBar { get; set; }

        [JsonProperty("campaign_defaults", DefaultValueHandling = DefaultValueHandling.Include)]
        public CampaignDefaults CampaignDefaults { get; set; }

        [JsonProperty("notify_on_subscribe")]
        public string NotifyOnSubscribe { get; set; }

        [JsonProperty("notify_on_unsubscribe")]
        public string NotifyOnUnsubscribe { get; set; }

        [JsonProperty("email_type_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EmailTypeOption { get; set; } = true;

        [JsonProperty("visibility")]
        public NewlistInputVisibilityType? Visibility { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewlistInputVisibilityType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "pub")]
        Pub,
        [EnumMember(Value = "prv")]
        Prv
    }

    public class GetAddMembersBatchResponseModel
    {
        [JsonProperty("total_created")]
        public int TotalCreated { get; set; }

        [JsonProperty("total_updated")]
        public int TotalUpdated { get; set; }

        [JsonProperty("error_count")]
        public int ErrorCount { get; set; }
    }

    public class AddMembersInput
    {
        [JsonProperty("members", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewMemberInListRequest[] Members { get; set; }

        [JsonProperty("update_existing")]
        public bool? UpdateExisting { get; set; }
    }

    public class NewMemberInListRequest
    {
        [JsonProperty("email_type")]
        public NewMemberInListRequestEmailTypeType EmailType { get; set; }

        [JsonProperty("status")]
        public NewMemberInListRequestStatusType Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool VIP { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewMemberInListRequestEmailTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewMemberInListRequestStatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "subscribed")]
        Subscribed,
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,
        [EnumMember(Value = "cleaned")]
        Cleaned,
        [EnumMember(Value = "pending")]
        Pending
    }

    public class FirstAndLastName
    {
        [JsonProperty("FNAME")]
        public string FirstName { get; set; }

        [JsonProperty("LNAME")]
        public string LastName { get; set; }
    }

    public class Location
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class GetAllMembersResponseModel
    {
        [JsonProperty("members")]
        public MemberResponseModel[] Members { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class MemberResponseModel
    {
        [JsonProperty("id")]
        public string EmailId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("unique_email_id")]
        public string UniqueEmailId { get; set; }

        [JsonProperty("email_type")]
        public string EmailType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ip_signup")]
        public string SignupIP { get; set; }

        [JsonProperty("timestamp_signup")]
        public string SignupTimestamp { get; set; }

        [JsonProperty("ip_opt")]
        public string OptInIP { get; set; }

        [JsonProperty("timestamp_opt")]
        public string OptInTimestamp { get; set; }

        [JsonProperty("member_rating")]
        public int MemberRating { get; set; }

        [JsonProperty("last_changed")]
        public string LastChangedDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool VIP { get; set; }

        [JsonProperty("email_client")]
        public string EmailClient { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("last_note")]
        public LastNote LastNote { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    public class LastNote
    {
        [JsonProperty("note_id")]
        public int NoteId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedTime { get; set; }

        [JsonProperty("created_by")]
        public string Author { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class AddmemberInput
    {
        [JsonProperty("email_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddmemberInputEmailTypeType? EmailType { get; set; } = AddmemberInputEmailTypeType.Html;

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddmemberInputStatusType Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool? VIP { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("email_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddmemberInputEmailTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddmemberInputStatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "subscribed")]
        Subscribed,
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,
        [EnumMember(Value = "cleaned")]
        Cleaned,
        [EnumMember(Value = "pending")]
        Pending
    }

    public class NewcampaignV2Input
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewcampaignV2InputCampaignTypeType CampaignType { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public Recipient Recipients { get; set; }

        [JsonProperty("settings", DefaultValueHandling = DefaultValueHandling.Include)]
        public SettingsV2 Settings { get; set; }

        [JsonProperty("variate_settings")]
        public VariateSettings VariateSettings { get; set; }

        [JsonProperty("tracking")]
        public Tracking Tracking { get; set; }

        [JsonProperty("rss_opts")]
        public RSSOpts RssOpts { get; set; }

        [JsonProperty("social_card")]
        public SocialCard SocialCard { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewcampaignV2InputCampaignTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "plaintext")]
        Plaintext,
        [EnumMember(Value = "absplit")]
        Absplit,
        [EnumMember(Value = "rss")]
        Rss,
        [EnumMember(Value = "variate")]
        Variate
    }

    public class UpdatememberV2Input
    {
        [JsonProperty("email_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdatememberV2InputEmailTypeType? EmailType { get; set; } = UpdatememberV2InputEmailTypeType.Html;

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdatememberV2InputStatusType Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool? VIP { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatememberV2InputEmailTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatememberV2InputStatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "subscribed")]
        Subscribed,
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,
        [EnumMember(Value = "cleaned")]
        Cleaned,
        [EnumMember(Value = "pending")]
        Pending
    }

    public class GetMembersResponseModel
    {
        [JsonProperty("members")]
        public AddUserResponseModel[] Members { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("total_items")]
        public int ItemCount { get; set; }
    }

    public class AddUserResponseModel
    {
        [JsonProperty("id")]
        public string EmailId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("unique_email_id")]
        public string UniqueEmailId { get; set; }

        [JsonProperty("email_type")]
        public string EmailType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ip_signup")]
        public string SignupIP { get; set; }

        [JsonProperty("timestamp_signup")]
        public string SignupTimestamp { get; set; }

        [JsonProperty("ip_opt")]
        public string OptInIP { get; set; }

        [JsonProperty("timestamp_opt")]
        public string OptInTimestamp { get; set; }

        [JsonProperty("member_rating")]
        public int MemberRating { get; set; }

        [JsonProperty("last_changed")]
        public string LastChangedDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool VIP { get; set; }

        [JsonProperty("email_client")]
        public string EmailClient { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("last_note")]
        public LastNote LastNote { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailchimp;

    public partial class WorkflowManagedActions
    {
        public MailchimpActions Mailchimp(string connectionId) => new MailchimpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailchimpTriggers Mailchimp(string connectionId) => new MailchimpTriggers(connectionId);
    }
}