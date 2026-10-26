//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zeptomail
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZeptomailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<GetMailAgentResponse, ApiConnectionActionConfiguration> GetMailAgent()
        {
            return new DeferredBodyAction<GetMailAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/portal/v1.0/mailagents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMailAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<GetProcessedEmailsResponse, ApiConnectionActionConfiguration> GetProcessedEmails(Expression<Func<string>> mailagentKey, Expression<Func<string>> subject = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null, Expression<Func<string>> requestId = null, Expression<Func<bool>> isHb = null, Expression<Func<bool>> isSb = null)
        {
            var __workflow_mailagentKey = WorkflowExpression.Compile(mailagentKey, nameof(mailagentKey), required: true);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: false);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: false);
            var __workflow_isHb = WorkflowExpression.Compile(isHb, nameof(isHb), required: false);
            var __workflow_isSb = WorkflowExpression.Compile(isSb, nameof(isSb), required: false);
            return new DeferredBodyAction<GetProcessedEmailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailagent_key"] = ExpressionConverter.Convert(__workflow_mailagentKey);
                if (__workflow_subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_dateFrom != null)
                    callPayload.Queries["date_from"] = ExpressionConverter.Convert(__workflow_dateFrom);
                if (__workflow_dateTo != null)
                    callPayload.Queries["date_to"] = ExpressionConverter.Convert(__workflow_dateTo);
                if (__workflow_requestId != null)
                    callPayload.Queries["request_id"] = ExpressionConverter.Convert(__workflow_requestId);
                callPayload.Queries["is_hb"] = Convert.ToString(false);
                if (__workflow_isHb != null)
                    callPayload.Queries["is_hb"] = ExpressionConverter.Convert(__workflow_isHb);
                callPayload.Queries["is_sb"] = Convert.ToString(false);
                if (__workflow_isSb != null)
                    callPayload.Queries["is_sb"] = ExpressionConverter.Convert(__workflow_isSb);
                return new ApiConnectionAction<GetProcessedEmailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<SuccessMessage, ApiConnectionActionConfiguration> SendMail(Expression<Func<SendMailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SuccessMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SuccessMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<SuccessMessage, ApiConnectionActionConfiguration> SendTemplateMail(Expression<Func<SendTemplateMailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SuccessMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/email/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SuccessMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<ProcessedMailStatsResponse, ApiConnectionActionConfiguration> ProcessedMailStats(Expression<Func<string>> mailagent, Expression<Func<string>> fromTime = null, Expression<Func<string>> toTime = null)
        {
            var __workflow_mailagent = WorkflowExpression.Compile(mailagent, nameof(mailagent), required: true);
            var __workflow_fromTime = WorkflowExpression.Compile(fromTime, nameof(fromTime), required: false);
            var __workflow_toTime = WorkflowExpression.Compile(toTime, nameof(toTime), required: false);
            return new DeferredBodyAction<ProcessedMailStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/stats/email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailagent"] = ExpressionConverter.Convert(__workflow_mailagent);
                if (__workflow_fromTime != null)
                    callPayload.Queries["from_time"] = ExpressionConverter.Convert(__workflow_fromTime);
                if (__workflow_toTime != null)
                    callPayload.Queries["to_time"] = ExpressionConverter.Convert(__workflow_toTime);
                return new ApiConnectionAction<ProcessedMailStatsResponse>(callPayload);
            });
        }
    }

    public class ZeptomailTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetMailAgentResponse
    {
        [JsonProperty("data")]
        public GetMailAgentResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GetMailAgentResponseDataTypeItem
    {
        [JsonProperty("mailagent_name")]
        public string MailAgentName { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain-verification-status")]
        public string DomainVerificationStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mailagent_key")]
        public string MailAgentKey { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetProcessedEmailsResponse
    {
        [JsonProperty("data")]
        public GetProcessedEmailsResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GetProcessedEmailsResponseDataType
    {
        [JsonProperty("details")]
        public GetProcessedEmailsResponseDataTypeDetailsTypeItem[] Details { get; set; }
    }

    public class GetProcessedEmailsResponseDataTypeDetailsTypeItem
    {
        [JsonProperty("email_info")]
        public GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoType EmailInfo { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    public class GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoType
    {
        [JsonProperty("is_smtp_trigger")]
        public bool IsSMTP { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("bounce_address")]
        public string BounceAddress { get; set; }

        [JsonProperty("mailagent_key")]
        public string MailagentKey { get; set; }

        [JsonProperty("process_state")]
        public string ProcessState { get; set; }

        [JsonProperty("from")]
        public GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoTypeFromType From { get; set; }

        [JsonProperty("to")]
        public GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoTypeToTypeItem[] To { get; set; }

        [JsonProperty("processed_time")]
        public string SentTime { get; set; }

        [JsonProperty("status")]
        public string DeliveryStatus { get; set; }
    }

    public class GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoTypeFromType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoTypeToTypeItem
    {
        [JsonProperty("email_address")]
        public GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoTypeToTypeItemEmailAddressType EmailAddress { get; set; }
    }

    public class GetProcessedEmailsResponseDataTypeDetailsTypeItemEmailInfoTypeToTypeItemEmailAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SuccessMessage
    {
        [JsonProperty("data")]
        public SuccessMessageDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string StatusMessage { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    public class SuccessMessageDataTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("additional_info")]
        public JToken[] AdditionalInfo { get; set; }

        [JsonProperty("message")]
        public string DetailedMessage { get; set; }
    }

    public class SendMailInput
    {
        [JsonProperty("mailagent_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailAgent { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public FromAddress From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailAddressItems[] To { get; set; }

        [JsonProperty("cc")]
        public EmailAddressItems[] CC { get; set; }

        [JsonProperty("bcc")]
        public EmailAddressItems[] BCC { get; set; }

        [JsonProperty("mailtype", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMailInputMailTypeType? MailType { get; set; } = SendMailInputMailTypeType.Html;

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("htmlbody")]
        public string Body { get; set; }

        [JsonProperty("reply_to")]
        public ReplyToAddresss[] ReplyTo { get; set; }

        [JsonProperty("attachments")]
        public SendMailInputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class FromAddress
    {
        [JsonProperty("from-detail")]
        public FromAddressAddressType Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FromAddressAddressType
    {
        [JsonProperty("from-prefix")]
        public string Prefix { get; set; }

        [JsonProperty("from-domain")]
        public string Domain { get; set; }
    }

    public class EmailAddressItems
    {
        [JsonProperty("email_address")]
        public EmailAddress EmailAddress { get; set; }
    }

    public class EmailAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMailInputMailTypeType
    {
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    public class ReplyToAddresss
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SendMailInputAttachmentsTypeItem
    {
        [JsonProperty("content")]
        public string Base64Content { get; set; }

        [JsonProperty("mime_type")]
        public string ContentType { get; set; }

        [JsonProperty("name")]
        public string FileName { get; set; }
    }

    public class SendTemplateMailInput
    {
        [JsonProperty("mailagent_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailAgent { get; set; }

        [JsonProperty("mail_template_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailTemplate { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public FromAddress From { get; set; }

        [JsonProperty("to")]
        public EmailAddressItems[] To { get; set; }

        [JsonProperty("cc")]
        public EmailAddressItems[] CC { get; set; }

        [JsonProperty("bcc")]
        public EmailAddressItems[] BCC { get; set; }

        [JsonProperty("merge_key_detail")]
        public SendTemplateMailInputMergeInfoTypeItem[] MergeInfo { get; set; }

        [JsonProperty("reply_to")]
        public ReplyToAddresss[] ReplyTo { get; set; }
    }

    public class SendTemplateMailInputMergeInfoTypeItem
    {
        [JsonProperty("key")]
        public string Tag { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ProcessedMailStatsResponse
    {
        [JsonProperty("hb")]
        public ProcessedMailStatsResponseHardbounceType Hardbounce { get; set; }

        [JsonProperty("sb")]
        public ProcessedMailStatsResponseSoftbounceType Softbounce { get; set; }

        [JsonProperty("sent")]
        public ProcessedMailStatsResponseSentType Sent { get; set; }
    }

    public class ProcessedMailStatsResponseHardbounceType
    {
        [JsonProperty("stats")]
        public ProcessedMailStatsResponseHardbounceTypeAnalyticsTypeItem[] Analytics { get; set; }

        [JsonProperty("count")]
        public int TotalCount { get; set; }
    }

    public class ProcessedMailStatsResponseHardbounceTypeAnalyticsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("count")]
        public int DateWiseCount { get; set; }
    }

    public class ProcessedMailStatsResponseSoftbounceType
    {
        [JsonProperty("stats")]
        public ProcessedMailStatsResponseSoftbounceTypeAnalyticsTypeItem[] Analytics { get; set; }

        [JsonProperty("count")]
        public int TotalCountOfSoftbounces { get; set; }
    }

    public class ProcessedMailStatsResponseSoftbounceTypeAnalyticsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("count")]
        public int DateWiseCount { get; set; }
    }

    public class ProcessedMailStatsResponseSentType
    {
        [JsonProperty("stats")]
        public ProcessedMailStatsResponseSentTypeAnalyticsTypeItem[] Analytics { get; set; }

        [JsonProperty("count")]
        public int TotalCountOfSentEmails { get; set; }
    }

    public class ProcessedMailStatsResponseSentTypeAnalyticsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("count")]
        public int DateWiseCount { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zeptomail;

    public partial class WorkflowManagedActions
    {
        public ZeptomailActions Zeptomail(string connectionId) => new ZeptomailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZeptomailTriggers Zeptomail(string connectionId) => new ZeptomailTriggers(connectionId);
    }
}