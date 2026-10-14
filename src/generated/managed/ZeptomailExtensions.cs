//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zeptomail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ZeptomailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<GetMailAgentResponse> GetMailAgent()
        {
            var apiCallPath = "/portal/v1.0/mailagents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMailAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<GetProcessedEmailsResponse> GetProcessedEmails(Expression<Func<string>> mailagentKey, Expression<Func<string>> subject = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null, Expression<Func<string>> requestId = null, Expression<Func<bool>> isHb = null, Expression<Func<bool>> isSb = null)
        {
            var __workflow_mailagentKey = mailagentKey == null ? null : WorkflowExpression.Compile(mailagentKey);
            WorkflowExpression.Validate(__workflow_mailagentKey, nameof(mailagentKey), required: true);
            var __workflow_subject = subject == null ? null : WorkflowExpression.Compile(subject);
            WorkflowExpression.Validate(__workflow_subject, nameof(subject), required: false);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: false);
            var __workflow_dateFrom = dateFrom == null ? null : WorkflowExpression.Compile(dateFrom);
            WorkflowExpression.Validate(__workflow_dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = dateTo == null ? null : WorkflowExpression.Compile(dateTo);
            WorkflowExpression.Validate(__workflow_dateTo, nameof(dateTo), required: false);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: false);
            var __workflow_isHb = isHb == null ? null : WorkflowExpression.Compile(isHb);
            WorkflowExpression.Validate(__workflow_isHb, nameof(isHb), required: false);
            var __workflow_isSb = isSb == null ? null : WorkflowExpression.Compile(isSb);
            WorkflowExpression.Validate(__workflow_isSb, nameof(isSb), required: false);
            return new DeferredBodyAction<GetProcessedEmailsResponse>(() =>
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
        public IBodyWorkflowAction<SuccessMessage> SendMail(Expression<Func<string>> bodymailAgent, Expression<Func<string>> bodyfromname, Expression<Func<EmailAddressItems[]>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyfromaddressprefix = null, Expression<Func<string>> bodyfromaddressdomain = null, Expression<Func<EmailAddressItems[]>> bodycC = null, Expression<Func<EmailAddressItems[]>> bodybCC = null, Expression<Func<bodymailTypeInput>> bodymailType = null, Expression<Func<string>> bodybody = null, Expression<Func<ReplyToAddresss[]>> bodyreplyTo = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var __workflow_bodymailAgent = bodymailAgent == null ? null : WorkflowExpression.Compile(bodymailAgent);
            WorkflowExpression.Validate(__workflow_bodymailAgent, nameof(bodymailAgent), required: true);
            var __workflow_bodyfromname = bodyfromname == null ? null : WorkflowExpression.Compile(bodyfromname);
            WorkflowExpression.Validate(__workflow_bodyfromname, nameof(bodyfromname), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodyfromaddressprefix = bodyfromaddressprefix == null ? null : WorkflowExpression.Compile(bodyfromaddressprefix);
            WorkflowExpression.Validate(__workflow_bodyfromaddressprefix, nameof(bodyfromaddressprefix), required: false);
            var __workflow_bodyfromaddressdomain = bodyfromaddressdomain == null ? null : WorkflowExpression.Compile(bodyfromaddressdomain);
            WorkflowExpression.Validate(__workflow_bodyfromaddressdomain, nameof(bodyfromaddressdomain), required: false);
            var __workflow_bodycC = bodycC == null ? null : WorkflowExpression.Compile(bodycC);
            WorkflowExpression.Validate(__workflow_bodycC, nameof(bodycC), required: false);
            var __workflow_bodybCC = bodybCC == null ? null : WorkflowExpression.Compile(bodybCC);
            WorkflowExpression.Validate(__workflow_bodybCC, nameof(bodybCC), required: false);
            var __workflow_bodymailType = bodymailType == null ? null : WorkflowExpression.Compile(bodymailType);
            WorkflowExpression.Validate(__workflow_bodymailType, nameof(bodymailType), required: false);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            var __workflow_bodyattachments = bodyattachments == null ? null : WorkflowExpression.Compile(bodyattachments);
            WorkflowExpression.Validate(__workflow_bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredBodyAction<SuccessMessage>(() =>
            {
                var apiCallPath = "/v1.0/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mailagent_key"] = ExpressionConverter.ConvertO(__workflow_bodymailAgent);
                var fromObject = new JObject();
                var fromObjectpropCount = 0;
                var fromDetailObject = new JObject();
                var fromDetailObjectpropCount = 0;
                if (__workflow_bodyfromaddressprefix != null)
                {
                    fromDetailObject["from-prefix"] = ExpressionConverter.ConvertO(__workflow_bodyfromaddressprefix);
                    fromDetailObjectpropCount++;
                }

                if (__workflow_bodyfromaddressdomain != null)
                {
                    fromDetailObject["from-domain"] = ExpressionConverter.ConvertO(__workflow_bodyfromaddressdomain);
                    fromDetailObjectpropCount++;
                }

                if (fromDetailObjectpropCount > 0)
                {
                    fromObject["from-detail"] = fromDetailObject;
                    fromObjectpropCount++;
                }

                fromObjectpropCount++;
                fromObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfromname);
                if (fromObjectpropCount > 0)
                {
                    body["from"] = fromObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                if (__workflow_bodycC != null)
                {
                    body["cc"] = ExpressionConverter.ConvertO(__workflow_bodycC);
                    bodypropCount++;
                }

                if (__workflow_bodybCC != null)
                {
                    body["bcc"] = ExpressionConverter.ConvertO(__workflow_bodybCC);
                    bodypropCount++;
                }

                if (__workflow_bodymailType != null)
                {
                    if (__workflow_bodymailType != null)
                    {
                        body["mailtype"] = ExpressionConverter.ConvertO(__workflow_bodymailType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["mailtype"] = "html";
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodybody != null)
                {
                    body["htmlbody"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyTo != null)
                {
                    body["reply_to"] = ExpressionConverter.ConvertO(__workflow_bodyreplyTo);
                    bodypropCount++;
                }

                if (__workflow_bodyattachments != null)
                {
                    body["attachments"] = ExpressionConverter.ConvertO(__workflow_bodyattachments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SuccessMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<SuccessMessage> SendTemplateMail(Expression<Func<string>> bodymailAgent, Expression<Func<string>> bodymailTemplate, Expression<Func<string>> bodyfromname, Expression<Func<string>> bodyfromaddressprefix = null, Expression<Func<string>> bodyfromaddressdomain = null, Expression<Func<EmailAddressItems[]>> bodyto = null, Expression<Func<EmailAddressItems[]>> bodycC = null, Expression<Func<EmailAddressItems[]>> bodybCC = null, Expression<Func<bodymergeInfoInputItem[]>> bodymergeInfo = null, Expression<Func<ReplyToAddresss[]>> bodyreplyTo = null)
        {
            var __workflow_bodymailAgent = bodymailAgent == null ? null : WorkflowExpression.Compile(bodymailAgent);
            WorkflowExpression.Validate(__workflow_bodymailAgent, nameof(bodymailAgent), required: true);
            var __workflow_bodymailTemplate = bodymailTemplate == null ? null : WorkflowExpression.Compile(bodymailTemplate);
            WorkflowExpression.Validate(__workflow_bodymailTemplate, nameof(bodymailTemplate), required: true);
            var __workflow_bodyfromname = bodyfromname == null ? null : WorkflowExpression.Compile(bodyfromname);
            WorkflowExpression.Validate(__workflow_bodyfromname, nameof(bodyfromname), required: true);
            var __workflow_bodyfromaddressprefix = bodyfromaddressprefix == null ? null : WorkflowExpression.Compile(bodyfromaddressprefix);
            WorkflowExpression.Validate(__workflow_bodyfromaddressprefix, nameof(bodyfromaddressprefix), required: false);
            var __workflow_bodyfromaddressdomain = bodyfromaddressdomain == null ? null : WorkflowExpression.Compile(bodyfromaddressdomain);
            WorkflowExpression.Validate(__workflow_bodyfromaddressdomain, nameof(bodyfromaddressdomain), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycC = bodycC == null ? null : WorkflowExpression.Compile(bodycC);
            WorkflowExpression.Validate(__workflow_bodycC, nameof(bodycC), required: false);
            var __workflow_bodybCC = bodybCC == null ? null : WorkflowExpression.Compile(bodybCC);
            WorkflowExpression.Validate(__workflow_bodybCC, nameof(bodybCC), required: false);
            var __workflow_bodymergeInfo = bodymergeInfo == null ? null : WorkflowExpression.Compile(bodymergeInfo);
            WorkflowExpression.Validate(__workflow_bodymergeInfo, nameof(bodymergeInfo), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            return new DeferredBodyAction<SuccessMessage>(() =>
            {
                var apiCallPath = "/v1.0/email/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mailagent_key"] = ExpressionConverter.ConvertO(__workflow_bodymailAgent);
                bodypropCount++;
                body["mail_template_key"] = ExpressionConverter.ConvertO(__workflow_bodymailTemplate);
                var fromObject = new JObject();
                var fromObjectpropCount = 0;
                var fromDetailObject = new JObject();
                var fromDetailObjectpropCount = 0;
                if (__workflow_bodyfromaddressprefix != null)
                {
                    fromDetailObject["from-prefix"] = ExpressionConverter.ConvertO(__workflow_bodyfromaddressprefix);
                    fromDetailObjectpropCount++;
                }

                if (__workflow_bodyfromaddressdomain != null)
                {
                    fromDetailObject["from-domain"] = ExpressionConverter.ConvertO(__workflow_bodyfromaddressdomain);
                    fromDetailObjectpropCount++;
                }

                if (fromDetailObjectpropCount > 0)
                {
                    fromObject["from-detail"] = fromDetailObject;
                    fromObjectpropCount++;
                }

                fromObjectpropCount++;
                fromObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfromname);
                if (fromObjectpropCount > 0)
                {
                    body["from"] = fromObject;
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodycC != null)
                {
                    body["cc"] = ExpressionConverter.ConvertO(__workflow_bodycC);
                    bodypropCount++;
                }

                if (__workflow_bodybCC != null)
                {
                    body["bcc"] = ExpressionConverter.ConvertO(__workflow_bodybCC);
                    bodypropCount++;
                }

                if (__workflow_bodymergeInfo != null)
                {
                    body["merge_key_detail"] = ExpressionConverter.ConvertO(__workflow_bodymergeInfo);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyTo != null)
                {
                    body["reply_to"] = ExpressionConverter.ConvertO(__workflow_bodyreplyTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SuccessMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<ProcessedMailStatsResponse> ProcessedMailStats(Expression<Func<string>> mailagent, Expression<Func<string>> fromTime = null, Expression<Func<string>> toTime = null)
        {
            var __workflow_mailagent = mailagent == null ? null : WorkflowExpression.Compile(mailagent);
            WorkflowExpression.Validate(__workflow_mailagent, nameof(mailagent), required: true);
            var __workflow_fromTime = fromTime == null ? null : WorkflowExpression.Compile(fromTime);
            WorkflowExpression.Validate(__workflow_fromTime, nameof(fromTime), required: false);
            var __workflow_toTime = toTime == null ? null : WorkflowExpression.Compile(toTime);
            WorkflowExpression.Validate(__workflow_toTime, nameof(toTime), required: false);
            return new DeferredBodyAction<ProcessedMailStatsResponse>(() =>
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
        public string RequestID { get; set; }
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
        public string RequestID { get; set; }
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
    public enum bodymailTypeInput
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

    public class bodyattachmentsInputItem
    {
        [JsonProperty("content")]
        public string Base64Content { get; set; }

        [JsonProperty("mime_type")]
        public string ContentType { get; set; }

        [JsonProperty("name")]
        public string FileName { get; set; }
    }

    public class bodymergeInfoInputItem
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
