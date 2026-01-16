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
            callPayload.Queries["mailagent_key"] = ExpressionConverter.Convert(mailagentKey);
            if (subject != null)
                callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
            if (from != null)
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            if (to != null)
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            if (dateFrom != null)
                callPayload.Queries["date_from"] = ExpressionConverter.Convert(dateFrom);
            if (dateTo != null)
                callPayload.Queries["date_to"] = ExpressionConverter.Convert(dateTo);
            if (requestId != null)
                callPayload.Queries["request_id"] = ExpressionConverter.Convert(requestId);
            callPayload.Queries["is_hb"] = Convert.ToString(false);
            if (isHb != null)
                callPayload.Queries["is_hb"] = ExpressionConverter.Convert(isHb);
            callPayload.Queries["is_sb"] = Convert.ToString(false);
            if (isSb != null)
                callPayload.Queries["is_sb"] = ExpressionConverter.Convert(isSb);
            return new ApiConnectionAction<GetProcessedEmailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zeptomail")]
        public IBodyWorkflowAction<ProcessedMailStatsResponse> ProcessedMailStats(Expression<Func<string>> mailagent, Expression<Func<string>> fromTime = null, Expression<Func<string>> toTime = null)
        {
            var apiCallPath = "/v1.0/stats/email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mailagent"] = ExpressionConverter.Convert(mailagent);
            if (fromTime != null)
                callPayload.Queries["from_time"] = ExpressionConverter.Convert(fromTime);
            if (toTime != null)
                callPayload.Queries["to_time"] = ExpressionConverter.Convert(toTime);
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