//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mandrill
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MandrillActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<UserInfo, ApiConnectionActionConfiguration> CurrentUser()
        {
            return new DeferredBodyAction<UserInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users/info.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<ListScheduledInfo[], ApiConnectionActionConfiguration> ScheduledMessageInfo(Expression<Func<ScheduledMessageInfoInput>> listScheduledRequest)
        {
            var __workflow_listScheduledRequest = WorkflowExpression.Compile(listScheduledRequest, nameof(listScheduledRequest), required: true);
            return new DeferredBodyAction<ListScheduledInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/list-scheduled.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_listScheduledRequest);
                return new ApiConnectionAction<ListScheduledInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<SendMessageResponse[], ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageV2Input>> sendMessageRequest)
        {
            var __workflow_sendMessageRequest = WorkflowExpression.Compile(sendMessageRequest, nameof(sendMessageRequest), required: true);
            return new DeferredBodyAction<SendMessageResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/messages/send.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendMessageRequest);
                return new ApiConnectionAction<SendMessageResponse[]>(callPayload);
            });
        }
    }

    public class MandrillTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserInfo
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("public_id")]
        public string PublicId { get; set; }

        [JsonProperty("reputation")]
        public int Reputation { get; set; }

        [JsonProperty("hourly_quota")]
        public int HourlyQuota { get; set; }

        [JsonProperty("backlog")]
        public int Backlog { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }

    public class Stats
    {
        [JsonProperty("today")]
        public StatStruct Today { get; set; }

        [JsonProperty("last_7_days")]
        public StatStruct Last7Days { get; set; }

        [JsonProperty("last_30_days")]
        public StatStruct Last30Days { get; set; }

        [JsonProperty("last_60_days")]
        public StatStruct Last60Days { get; set; }

        [JsonProperty("last_90_days")]
        public StatStruct Last90Days { get; set; }

        [JsonProperty("all_time")]
        public StatStruct AllTime { get; set; }
    }

    public class StatStruct
    {
        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("hard_bounces")]
        public int HardBounces { get; set; }

        [JsonProperty("soft_bounces")]
        public int SoftBounces { get; set; }

        [JsonProperty("rejects")]
        public int Rejects { get; set; }

        [JsonProperty("complaints")]
        public int Complaints { get; set; }

        [JsonProperty("unsubs")]
        public int Unsubscribes { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }
    }

    public class ListScheduledInfo
    {
        [JsonProperty("email")]
        public string RecipientSEmail { get; set; }

        [JsonProperty("status")]
        public ListScheduledInfoRecipientSStatusType RecipientSStatus { get; set; }

        [JsonProperty("reject_reason")]
        public ListScheduledInfoRejectionReasonType RejectionReason { get; set; }

        [JsonProperty("_id")]
        public string MessageId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListScheduledInfoRecipientSStatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "scheduled")]
        Scheduled,
        [EnumMember(Value = "rejected")]
        Rejected,
        [EnumMember(Value = "or invalid")]
        OrInvalid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListScheduledInfoRejectionReasonType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "hard-bounce")]
        HardBounce,
        [EnumMember(Value = "soft-bounce")]
        SoftBounce,
        [EnumMember(Value = "spam")]
        Spam,
        [EnumMember(Value = "unsub")]
        Unsub,
        [EnumMember(Value = "custom")]
        Custom,
        [EnumMember(Value = "invalid-sender")]
        InvalidSender,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "test-mode-limit")]
        TestModeLimit,
        [EnumMember(Value = "unsigned")]
        Unsigned,
        [EnumMember(Value = "or rule")]
        OrRule
    }

    public class ScheduledMessageInfoInput
    {
        public string To { get; set; }
    }

    public class SendMessageResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string SendingStatus { get; set; }

        [JsonProperty("reject_reason")]
        public string RejectReason { get; set; }

        [JsonProperty("_id")]
        public string MessageId { get; set; }
    }

    public class SendMessageV2Input
    {
        [JsonProperty("message")]
        public SendMessageInfoV2 Message { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("async")]
        public bool? EnableAsyncTrueFalse { get; set; }

        [JsonProperty("ip_pool")]
        public string DedicatedIpPoolName { get; set; }
    }

    public class SendMessageInfoV2
    {
        [JsonProperty("html")]
        public string ContentOfTheMessage { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("to")]
        public RecipientInfo[] SendTo { get; set; }

        [JsonProperty("headers")]
        public string ExtraHeaders { get; set; }

        [JsonProperty("important")]
        public bool IsThisMessageImportantTrueFalse { get; set; }

        [JsonProperty("track_opens")]
        public bool TrackWhenMessageOpensTrueFalse { get; set; }

        [JsonProperty("track_clicks")]
        public bool TrackClicksForThisMessageTrueFalse { get; set; }

        [JsonProperty("auto_text")]
        public bool FillTextMessageIfNotPresentTrueFalse { get; set; }

        [JsonProperty("auto_html")]
        public bool FillHTMLMessageIfNotPresentTrueFalse { get; set; }

        [JsonProperty("inline_css")]
        public bool InlineCSSStylesInHtmlMessageTrueFalse { get; set; }

        [JsonProperty("url_strip_qs")]
        public bool StripQueryStringFromURLInAggregatedDataTrueFalse { get; set; }

        [JsonProperty("preserve_recipients")]
        public bool ShowAllRecipientsInToLineTrueFalse { get; set; }

        [JsonProperty("view_content_link")]
        public bool RemoveContentLoggingTrueFalse { get; set; }

        [JsonProperty("bcc_address")]
        public string OptionalBCCAddress { get; set; }

        [JsonProperty("tracking_domain")]
        public string CustomDomaingForTracking { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("attachments")]
        public AttachmentInfo[] Attachments { get; set; }
    }

    public class RecipientInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public RecipientInfoSendAsType SendAs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecipientInfoSendAsType
    {
        [EnumMember(Value = "to")]
        To,
        [EnumMember(Value = "cc")]
        Cc,
        [EnumMember(Value = "bcc")]
        Bcc
    }

    public class AttachmentInfo
    {
        [JsonProperty("type")]
        public string MIMEType { get; set; }

        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mandrill;

    public partial class WorkflowManagedActions
    {
        public MandrillActions Mandrill(string connectionId) => new MandrillActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MandrillTriggers Mandrill(string connectionId) => new MandrillTriggers(connectionId);
    }
}