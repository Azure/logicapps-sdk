//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        public IBodyWorkflowAction<SendSMSv3Response, ApiConnectionActionConfiguration> SendSMSv3(Expression<Func<SendSMSv3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendSMSv3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/sms/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSMSv3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        public IBodyWorkflowAction<StatusCheckV3Response, ApiConnectionActionConfiguration> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/messages/{0}/status", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Incoming(Expression<Func<string>> smsSender, Expression<Func<IncomingV3Input>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_smsSender = WorkflowExpression.Compile(smsSender, nameof(smsSender), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/sms/phone-numbers/{0}", __workflow_smsSender.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendSMSv3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    public class SendSMSv3Input
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Channel { get; set; } = "sms";

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendSMSv3InputContentType Content { get; set; }
    }

    public class SendSMSv3InputContentType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "text";

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("deliveryChannel")]
        public string DeliveryChannel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class IncomingV3Input
    {
        [JsonProperty("inboundMessageUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string InboundMessageUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecsms;

    public partial class WorkflowManagedActions
    {
        public TyntecsmsActions Tyntecsms(string connectionId) => new TyntecsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TyntecsmsTriggers Tyntecsms(string connectionId) => new TyntecsmsTriggers(connectionId);
    }
}