//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mandrill
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MandrillActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<UserInfo> CurrentUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/info.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<ListScheduledInfo[]> ScheduledMessageInfo([WorkflowExpression] Func<string> listScheduledRequestto = null)
        {
            SourceExpression.Validate(listScheduledRequestto, nameof(listScheduledRequestto), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages/list-scheduled.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var listScheduledRequest = new JObject();
                var listScheduledRequestpropCount = 0;
                if (listScheduledRequestto != null)
                {
                    listScheduledRequest["To"] = SourceExpressionConverter.ConvertToken(listScheduledRequestto);
                    listScheduledRequestpropCount++;
                }

                if (listScheduledRequestpropCount > 0)
                {
                    callPayload.Body = listScheduledRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListScheduledInfo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mandrill")]
        public IBodyWorkflowAction<SendMessageResponse[]> SendMessage([WorkflowExpression] Func<string> sendMessageRequestmessagesubject, [WorkflowExpression] Func<string> sendMessageRequestmessagefromEmail, [WorkflowExpression] Func<RecipientInfo[]> sendMessageRequestmessagesendTo, [WorkflowExpression] Func<string> sendMessageRequestmessagecontentOfTheMessage = null, [WorkflowExpression] Func<string> sendMessageRequestmessagefromName = null, [WorkflowExpression] Func<string> sendMessageRequestmessageextraHeaders = null, [WorkflowExpression] Func<bool> sendMessageRequestmessageisThisMessageImportantTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessagetrackWhenMessageOpensTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessagetrackClicksForThisMessageTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse = null, [WorkflowExpression] Func<bool> sendMessageRequestmessageremoveContentLoggingTrueFalse = null, [WorkflowExpression] Func<string> sendMessageRequestmessageoptionalBCCAddress = null, [WorkflowExpression] Func<string> sendMessageRequestmessagecustomDomaingForTracking = null, [WorkflowExpression] Func<string[]> sendMessageRequestmessagetags = null, [WorkflowExpression] Func<AttachmentInfo[]> sendMessageRequestmessageattachments = null, [WorkflowExpression] Func<string> sendMessageRequestsendAt = null, [WorkflowExpression] Func<bool> sendMessageRequestenableAsyncTrueFalse = null, [WorkflowExpression] Func<string> sendMessageRequestdedicatedIpPoolName = null)
        {
            SourceExpression.Validate(sendMessageRequestmessagesubject, nameof(sendMessageRequestmessagesubject), required: true);
            SourceExpression.Validate(sendMessageRequestmessagefromEmail, nameof(sendMessageRequestmessagefromEmail), required: true);
            SourceExpression.Validate(sendMessageRequestmessagesendTo, nameof(sendMessageRequestmessagesendTo), required: true);
            SourceExpression.Validate(sendMessageRequestmessagecontentOfTheMessage, nameof(sendMessageRequestmessagecontentOfTheMessage), required: false);
            SourceExpression.Validate(sendMessageRequestmessagefromName, nameof(sendMessageRequestmessagefromName), required: false);
            SourceExpression.Validate(sendMessageRequestmessageextraHeaders, nameof(sendMessageRequestmessageextraHeaders), required: false);
            SourceExpression.Validate(sendMessageRequestmessageisThisMessageImportantTrueFalse, nameof(sendMessageRequestmessageisThisMessageImportantTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessagetrackWhenMessageOpensTrueFalse, nameof(sendMessageRequestmessagetrackWhenMessageOpensTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessagetrackClicksForThisMessageTrueFalse, nameof(sendMessageRequestmessagetrackClicksForThisMessageTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse, nameof(sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse, nameof(sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse, nameof(sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse, nameof(sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessageremoveContentLoggingTrueFalse, nameof(sendMessageRequestmessageremoveContentLoggingTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestmessageoptionalBCCAddress, nameof(sendMessageRequestmessageoptionalBCCAddress), required: false);
            SourceExpression.Validate(sendMessageRequestmessagecustomDomaingForTracking, nameof(sendMessageRequestmessagecustomDomaingForTracking), required: false);
            SourceExpression.Validate(sendMessageRequestmessagetags, nameof(sendMessageRequestmessagetags), required: false);
            SourceExpression.Validate(sendMessageRequestmessageattachments, nameof(sendMessageRequestmessageattachments), required: false);
            SourceExpression.Validate(sendMessageRequestsendAt, nameof(sendMessageRequestsendAt), required: false);
            SourceExpression.Validate(sendMessageRequestenableAsyncTrueFalse, nameof(sendMessageRequestenableAsyncTrueFalse), required: false);
            SourceExpression.Validate(sendMessageRequestdedicatedIpPoolName, nameof(sendMessageRequestdedicatedIpPoolName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/messages/send.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageRequest = new JObject();
                var sendMessageRequestpropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                if (sendMessageRequestmessagecontentOfTheMessage != null)
                {
                    messageObject["html"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagecontentOfTheMessage);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
                messageObject["subject"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagesubject);
                messageObjectpropCount++;
                messageObject["from_email"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagefromEmail);
                if (sendMessageRequestmessagefromName != null)
                {
                    messageObject["from_name"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagefromName);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
                messageObject["to"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagesendTo);
                if (sendMessageRequestmessageextraHeaders != null)
                {
                    messageObject["headers"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageextraHeaders);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessageisThisMessageImportantTrueFalse != null)
                {
                    messageObject["important"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageisThisMessageImportantTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessagetrackWhenMessageOpensTrueFalse != null)
                {
                    messageObject["track_opens"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagetrackWhenMessageOpensTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessagetrackClicksForThisMessageTrueFalse != null)
                {
                    messageObject["track_clicks"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagetrackClicksForThisMessageTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse != null)
                {
                    messageObject["auto_text"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagefillTextMessageIfNotPresentTrueFalse);
                    messageObjectpropCount++;
                }

                messageObject["auto_html"] = false;
                messageObjectpropCount++;
                if (sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse != null)
                {
                    messageObject["inline_css"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageinlineCSSStylesInHtmlMessageTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse != null)
                {
                    messageObject["url_strip_qs"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagestripQueryStringFromURLInAggregatedDataTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse != null)
                {
                    messageObject["preserve_recipients"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageshowAllRecipientsInToLineTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessageremoveContentLoggingTrueFalse != null)
                {
                    messageObject["view_content_link"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageremoveContentLoggingTrueFalse);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessageoptionalBCCAddress != null)
                {
                    messageObject["bcc_address"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageoptionalBCCAddress);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessagecustomDomaingForTracking != null)
                {
                    messageObject["tracking_domain"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagecustomDomaingForTracking);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessagetags != null)
                {
                    messageObject["tags"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessagetags);
                    messageObjectpropCount++;
                }

                if (sendMessageRequestmessageattachments != null)
                {
                    messageObject["attachments"] = SourceExpressionConverter.ConvertToken(sendMessageRequestmessageattachments);
                    messageObjectpropCount++;
                }

                if (messageObjectpropCount > 0)
                {
                    sendMessageRequest["message"] = messageObject;
                    sendMessageRequestpropCount++;
                }

                if (sendMessageRequestsendAt != null)
                {
                    sendMessageRequest["send_at"] = SourceExpressionConverter.ConvertToken(sendMessageRequestsendAt);
                    sendMessageRequestpropCount++;
                }

                if (sendMessageRequestenableAsyncTrueFalse != null)
                {
                    sendMessageRequest["async"] = SourceExpressionConverter.ConvertToken(sendMessageRequestenableAsyncTrueFalse);
                    sendMessageRequestpropCount++;
                }

                if (sendMessageRequestdedicatedIpPoolName != null)
                {
                    sendMessageRequest["ip_pool"] = SourceExpressionConverter.ConvertToken(sendMessageRequestdedicatedIpPoolName);
                    sendMessageRequestpropCount++;
                }

                if (sendMessageRequestpropCount > 0)
                {
                    callPayload.Body = sendMessageRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse[]>(BuildSourceInput);
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
        public string MessageID { get; set; }
    }

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
        public string MessageID { get; set; }
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