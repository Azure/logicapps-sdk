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
        public IBodyWorkflowAction<SendSMSv3Response> SendSMSv3(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttext = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttext = WorkflowExpression.Compile(bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendSMSv3Response>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/sms/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                body["channel"] = "sms";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (__workflow_bodycontenttext != null)
                {
                    contentObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontenttext);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSMSv3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response>(() =>
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
        public IWorkflowTrigger Incoming(Expression<Func<string>> smsSender, FlowRecurrence recurrence = null)
        {
            var __workflow_smsSender = WorkflowExpression.Compile(smsSender, nameof(smsSender), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/sms/phone-numbers/{0}", __workflow_smsSender.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["inboundMessageUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendSMSv3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
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
