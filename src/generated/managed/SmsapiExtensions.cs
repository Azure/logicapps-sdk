//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smsapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmsapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsapi")]
        public IBodyWorkflowAction<SendSmsResponse, ApiConnectionActionConfiguration> SendSms(Expression<Func<SendSmsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms.do";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }
    }

    public class SmsapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSmsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("list")]
        public SendSmsResponseListTypeItem[] List { get; set; }
    }

    public class SendSmsResponseListTypeItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("date_sent")]
        public int DateSent { get; set; }

        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("parts")]
        public int Parts { get; set; }

        [JsonProperty("idx")]
        public string Idx { get; set; }

        [JsonProperty("submitted_number")]
        public string SubmittedNumber { get; set; }
    }

    public class SendSmsInput
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Format { get; set; } = "json";

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Encoding { get; set; } = "utf-8";

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("fast", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Fast { get; set; } = 0;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smsapi;

    public partial class WorkflowManagedActions
    {
        public SmsapiActions Smsapi(string connectionId) => new SmsapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmsapiTriggers Smsapi(string connectionId) => new SmsapiTriggers(connectionId);
    }
}