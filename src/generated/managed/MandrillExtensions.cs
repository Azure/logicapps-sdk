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
        public IBodyWorkflowAction<ListScheduledInfo[], ApiConnectionActionConfiguration> ScheduledMessageInfo(Expression<Func<string>> listScheduledRequestto = null)
        {
            var __workflow_listScheduledRequestto = WorkflowExpression.Compile(listScheduledRequestto, nameof(listScheduledRequestto), required: false);
            return new DeferredBodyAction<ListScheduledInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/list-scheduled.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var listScheduledRequest = new JObject();
                var listScheduledRequestpropCount = 0;
                if (__workflow_listScheduledRequestto != null)
                {
                    listScheduledRequest["To"] = ExpressionConverter.ConvertO(__workflow_listScheduledRequestto);
                    listScheduledRequestpropCount++;
                }

                if (listScheduledRequestpropCount > 0)
                {
                    callPayload.Body = listScheduledRequest;
                }

                return new ApiConnectionAction<ListScheduledInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<SendMessageResponse[], ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> sendMessageRequestmessagesubject, Expression<Func<string>> sendMessageRequestmessagefromEmail, Expression<Func<RecipientInfo[]>> sendMessageRequestmessagesendTo, Expression<Func<string>> sendMessageRequestmessagecontentOfTheMessage = null, Expression<Func<string>> sendMessageRequestmessagefromName = null, Expression<Func<string>> sendMessageRequestmessageextraHeaders = null, Expression<Func<bool>> sendMessageRequestmessageisThisMessageImportantTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessagetrackWhenMessageOpensTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessagetrackClicksForThisMessageTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse = null, Expression<Func<bool>> sendMessageRequestmessageremoveContentLoggingTrueFalse = null, Expression<Func<string>> sendMessageRequestmessageoptionalBCCAddress = null, Expression<Func<string>> sendMessageRequestmessagecustomDomaingForTracking = null, Expression<Func<string[]>> sendMessageRequestmessagetags = null, Expression<Func<AttachmentInfo[]>> sendMessageRequestmessageattachments = null, Expression<Func<string>> sendMessageRequestsendAt = null, Expression<Func<bool>> sendMessageRequestenableAsyncTrueFalse = null, Expression<Func<string>> sendMessageRequestdedicatedIpPoolName = null)
        {
            var __workflow_sendMessageRequestmessagesubject = WorkflowExpression.Compile(sendMessageRequestmessagesubject, nameof(sendMessageRequestmessagesubject), required: true);
            var __workflow_sendMessageRequestmessagefromEmail = WorkflowExpression.Compile(sendMessageRequestmessagefromEmail, nameof(sendMessageRequestmessagefromEmail), required: true);
            var __workflow_sendMessageRequestmessagesendTo = WorkflowExpression.Compile(sendMessageRequestmessagesendTo, nameof(sendMessageRequestmessagesendTo), required: true);
            var __workflow_sendMessageRequestmessagecontentOfTheMessage = WorkflowExpression.Compile(sendMessageRequestmessagecontentOfTheMessage, nameof(sendMessageRequestmessagecontentOfTheMessage), required: false);
            var __workflow_sendMessageRequestmessagefromName = WorkflowExpression.Compile(sendMessageRequestmessagefromName, nameof(sendMessageRequestmessagefromName), required: false);
            var __workflow_sendMessageRequestmessageextraHeaders = WorkflowExpression.Compile(sendMessageRequestmessageextraHeaders, nameof(sendMessageRequestmessageextraHeaders), required: false);
            var __workflow_sendMessageRequestmessageisThisMessageImportantTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessageisThisMessageImportantTrueFalse, nameof(sendMessageRequestmessageisThisMessageImportantTrueFalse), required: false);
            var __workflow_sendMessageRequestmessagetrackWhenMessageOpensTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessagetrackWhenMessageOpensTrueFalse, nameof(sendMessageRequestmessagetrackWhenMessageOpensTrueFalse), required: false);
            var __workflow_sendMessageRequestmessagetrackClicksForThisMessageTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessagetrackClicksForThisMessageTrueFalse, nameof(sendMessageRequestmessagetrackClicksForThisMessageTrueFalse), required: false);
            var __workflow_sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse, nameof(sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse), required: false);
            var __workflow_sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse, nameof(sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse), required: false);
            var __workflow_sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse, nameof(sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse), required: false);
            var __workflow_sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse, nameof(sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse), required: false);
            var __workflow_sendMessageRequestmessageremoveContentLoggingTrueFalse = WorkflowExpression.Compile(sendMessageRequestmessageremoveContentLoggingTrueFalse, nameof(sendMessageRequestmessageremoveContentLoggingTrueFalse), required: false);
            var __workflow_sendMessageRequestmessageoptionalBCCAddress = WorkflowExpression.Compile(sendMessageRequestmessageoptionalBCCAddress, nameof(sendMessageRequestmessageoptionalBCCAddress), required: false);
            var __workflow_sendMessageRequestmessagecustomDomaingForTracking = WorkflowExpression.Compile(sendMessageRequestmessagecustomDomaingForTracking, nameof(sendMessageRequestmessagecustomDomaingForTracking), required: false);
            var __workflow_sendMessageRequestmessagetags = WorkflowExpression.Compile(sendMessageRequestmessagetags, nameof(sendMessageRequestmessagetags), required: false);
            var __workflow_sendMessageRequestmessageattachments = WorkflowExpression.Compile(sendMessageRequestmessageattachments, nameof(sendMessageRequestmessageattachments), required: false);
            var __workflow_sendMessageRequestsendAt = WorkflowExpression.Compile(sendMessageRequestsendAt, nameof(sendMessageRequestsendAt), required: false);
            var __workflow_sendMessageRequestenableAsyncTrueFalse = WorkflowExpression.Compile(sendMessageRequestenableAsyncTrueFalse, nameof(sendMessageRequestenableAsyncTrueFalse), required: false);
            var __workflow_sendMessageRequestdedicatedIpPoolName = WorkflowExpression.Compile(sendMessageRequestdedicatedIpPoolName, nameof(sendMessageRequestdedicatedIpPoolName), required: false);
            return new DeferredBodyAction<SendMessageResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/messages/send.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageRequest = new JObject();
                var sendMessageRequestpropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                if (__workflow_sendMessageRequestmessagecontentOfTheMessage != null)
                {
                    messageObject["html"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagecontentOfTheMessage);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
                messageObject["subject"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagesubject);
                messageObjectpropCount++;
                messageObject["from_email"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagefromEmail);
                if (__workflow_sendMessageRequestmessagefromName != null)
                {
                    messageObject["from_name"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagefromName);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
                messageObject["to"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagesendTo);
                if (__workflow_sendMessageRequestmessageextraHeaders != null)
                {
                    messageObject["headers"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageextraHeaders);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessageisThisMessageImportantTrueFalse != null)
                {
                    messageObject["important"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageisThisMessageImportantTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessagetrackWhenMessageOpensTrueFalse != null)
                {
                    messageObject["track_opens"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagetrackWhenMessageOpensTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessagetrackClicksForThisMessageTrueFalse != null)
                {
                    messageObject["track_clicks"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagetrackClicksForThisMessageTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse != null)
                {
                    messageObject["auto_text"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse);
                    messageObjectpropCount++;
                }

                messageObject["auto_html"] = false;
                messageObjectpropCount++;
                if (__workflow_sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse != null)
                {
                    messageObject["inline_css"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse != null)
                {
                    messageObject["url_strip_qs"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse != null)
                {
                    messageObject["preserve_recipients"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessageremoveContentLoggingTrueFalse != null)
                {
                    messageObject["view_content_link"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageremoveContentLoggingTrueFalse);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessageoptionalBCCAddress != null)
                {
                    messageObject["bcc_address"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageoptionalBCCAddress);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessagecustomDomaingForTracking != null)
                {
                    messageObject["tracking_domain"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagecustomDomaingForTracking);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessagetags != null)
                {
                    messageObject["tags"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessagetags);
                    messageObjectpropCount++;
                }

                if (__workflow_sendMessageRequestmessageattachments != null)
                {
                    messageObject["attachments"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestmessageattachments);
                    messageObjectpropCount++;
                }

                if (messageObjectpropCount > 0)
                {
                    sendMessageRequest["message"] = messageObject;
                    sendMessageRequestpropCount++;
                }

                if (__workflow_sendMessageRequestsendAt != null)
                {
                    sendMessageRequest["send_at"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestsendAt);
                    sendMessageRequestpropCount++;
                }

                if (__workflow_sendMessageRequestenableAsyncTrueFalse != null)
                {
                    sendMessageRequest["async"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestenableAsyncTrueFalse);
                    sendMessageRequestpropCount++;
                }

                if (__workflow_sendMessageRequestdedicatedIpPoolName != null)
                {
                    sendMessageRequest["ip_pool"] = ExpressionConverter.ConvertO(__workflow_sendMessageRequestdedicatedIpPoolName);
                    sendMessageRequestpropCount++;
                }

                if (sendMessageRequestpropCount > 0)
                {
                    callPayload.Body = sendMessageRequest;
                }

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