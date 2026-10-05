//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecsms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMSv3))]
        public IBodyWorkflowAction<SendSMSv3Response> SendSMSv3([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttext = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSMSv3Response> __BuildSendSMSv3(WorkflowValue<string> bodyfrom = null, WorkflowValue<string> bodyto = null, WorkflowValue<string> bodycontenttext = null)
        {
            WorkflowValue.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowValue.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowValue.Validate(bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendSMSv3Response>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/sms/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "sms";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (bodycontenttext != null)
                {
                    contentObject["text"] = ExpressionConverter.ConvertO(bodycontenttext);
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
        [WorkflowExpressionFactory(nameof(__BuildStatusCheck))]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatusCheckV3Response> __BuildStatusCheck(WorkflowValue<string> messageId)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecsmsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildIncoming))]
        public IWorkflowTrigger Incoming([WorkflowExpression] Func<string> smsSender, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildIncoming(WorkflowValue<string> smsSender, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(smsSender, nameof(smsSender), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/sms/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(smsSender, 1));
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
