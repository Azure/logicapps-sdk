//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zeptomail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
            var apiCallPath = "/v1.0/email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mailagent_key"] = CSharpExpressionConverter.ConvertO(mailagentKey);
            if (subject != null)
                callPayload.Queries["subject"] = CSharpExpressionConverter.ConvertO(subject);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (dateFrom != null)
                callPayload.Queries["date_from"] = CSharpExpressionConverter.ConvertO(dateFrom);
            if (dateTo != null)
                callPayload.Queries["date_to"] = CSharpExpressionConverter.ConvertO(dateTo);
            if (requestId != null)
                callPayload.Queries["request_id"] = CSharpExpressionConverter.ConvertO(requestId);
            callPayload.Queries["is_hb"] = Convert.ToString(false);
            if (isHb != null)
                callPayload.Queries["is_hb"] = CSharpExpressionConverter.ConvertO(isHb);
            callPayload.Queries["is_sb"] = Convert.ToString(false);
            if (isSb != null)
                callPayload.Queries["is_sb"] = CSharpExpressionConverter.ConvertO(isSb);
            return new ApiConnectionAction<GetProcessedEmailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<SuccessMessage> SendMail(Expression<Func<string>> bodymailAgent, Expression<Func<string>> bodyfromname, Expression<Func<EmailAddressItems[]>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyfromaddressprefix = null, Expression<Func<string>> bodyfromaddressdomain = null, Expression<Func<EmailAddressItems[]>> bodycC = null, Expression<Func<EmailAddressItems[]>> bodybCC = null, Expression<Func<bodymailTypeInput>> bodymailType = null, Expression<Func<string>> bodybody = null, Expression<Func<ReplyToAddresss[]>> bodyreplyTo = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var apiCallPath = "/v1.0/email";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["mailagent_key"] = CSharpExpressionConverter.ConvertToken(bodymailAgent);
            var fromObject = new JObject();
            var fromObjectpropCount = 0;
            var fromDetailObject = new JObject();
            var fromDetailObjectpropCount = 0;
            if (bodyfromaddressprefix != null)
            {
                fromDetailObject["from-prefix"] = CSharpExpressionConverter.ConvertToken(bodyfromaddressprefix);
                fromDetailObjectpropCount++;
            }

            if (bodyfromaddressdomain != null)
            {
                fromDetailObject["from-domain"] = CSharpExpressionConverter.ConvertToken(bodyfromaddressdomain);
                fromDetailObjectpropCount++;
            }

            if (fromDetailObjectpropCount > 0)
            {
                fromObject["from-detail"] = fromDetailObject;
                fromObjectpropCount++;
            }

            fromObjectpropCount++;
            fromObject["name"] = CSharpExpressionConverter.ConvertToken(bodyfromname);
            if (fromObjectpropCount > 0)
            {
                body["from"] = fromObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["to"] = CSharpExpressionConverter.ConvertToken(bodyto);
            if (bodycC != null)
            {
                body["cc"] = CSharpExpressionConverter.ConvertToken(bodycC);
                bodypropCount++;
            }

            if (bodybCC != null)
            {
                body["bcc"] = CSharpExpressionConverter.ConvertToken(bodybCC);
                bodypropCount++;
            }

            if (bodymailType != null)
            {
                if (bodymailType != null)
                {
                    body["mailtype"] = CSharpExpressionConverter.Convert(bodymailType);
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
            body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
            if (bodybody != null)
            {
                body["htmlbody"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodyreplyTo != null)
            {
                body["reply_to"] = CSharpExpressionConverter.ConvertToken(bodyreplyTo);
                bodypropCount++;
            }

            if (bodyattachments != null)
            {
                body["attachments"] = CSharpExpressionConverter.ConvertToken(bodyattachments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SuccessMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<SuccessMessage> SendTemplateMail(Expression<Func<string>> bodymailAgent, Expression<Func<string>> bodymailTemplate, Expression<Func<string>> bodyfromname, Expression<Func<string>> bodyfromaddressprefix = null, Expression<Func<string>> bodyfromaddressdomain = null, Expression<Func<EmailAddressItems[]>> bodyto = null, Expression<Func<EmailAddressItems[]>> bodycC = null, Expression<Func<EmailAddressItems[]>> bodybCC = null, Expression<Func<bodymergeInfoInputItem[]>> bodymergeInfo = null, Expression<Func<ReplyToAddresss[]>> bodyreplyTo = null)
        {
            var apiCallPath = "/v1.0/email/template";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["mailagent_key"] = CSharpExpressionConverter.ConvertToken(bodymailAgent);
            bodypropCount++;
            body["mail_template_key"] = CSharpExpressionConverter.ConvertToken(bodymailTemplate);
            var fromObject = new JObject();
            var fromObjectpropCount = 0;
            var fromDetailObject = new JObject();
            var fromDetailObjectpropCount = 0;
            if (bodyfromaddressprefix != null)
            {
                fromDetailObject["from-prefix"] = CSharpExpressionConverter.ConvertToken(bodyfromaddressprefix);
                fromDetailObjectpropCount++;
            }

            if (bodyfromaddressdomain != null)
            {
                fromDetailObject["from-domain"] = CSharpExpressionConverter.ConvertToken(bodyfromaddressdomain);
                fromDetailObjectpropCount++;
            }

            if (fromDetailObjectpropCount > 0)
            {
                fromObject["from-detail"] = fromDetailObject;
                fromObjectpropCount++;
            }

            fromObjectpropCount++;
            fromObject["name"] = CSharpExpressionConverter.ConvertToken(bodyfromname);
            if (fromObjectpropCount > 0)
            {
                body["from"] = fromObject;
                bodypropCount++;
            }

            if (bodyto != null)
            {
                body["to"] = CSharpExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
            }

            if (bodycC != null)
            {
                body["cc"] = CSharpExpressionConverter.ConvertToken(bodycC);
                bodypropCount++;
            }

            if (bodybCC != null)
            {
                body["bcc"] = CSharpExpressionConverter.ConvertToken(bodybCC);
                bodypropCount++;
            }

            if (bodymergeInfo != null)
            {
                body["merge_key_detail"] = CSharpExpressionConverter.ConvertToken(bodymergeInfo);
                bodypropCount++;
            }

            if (bodyreplyTo != null)
            {
                body["reply_to"] = CSharpExpressionConverter.ConvertToken(bodyreplyTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SuccessMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<ProcessedMailStatsResponse> ProcessedMailStats(Expression<Func<string>> mailagent, Expression<Func<string>> fromTime = null, Expression<Func<string>> toTime = null)
        {
            var apiCallPath = "/v1.0/stats/email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mailagent"] = CSharpExpressionConverter.ConvertO(mailagent);
            if (fromTime != null)
                callPayload.Queries["from_time"] = CSharpExpressionConverter.ConvertO(fromTime);
            if (toTime != null)
                callPayload.Queries["to_time"] = CSharpExpressionConverter.ConvertO(toTime);
            return new ApiConnectionAction<ProcessedMailStatsResponse>(callPayload);
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