//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecsms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        public IBodyWorkflowAction<SendSMSv3Response> SendSMSv3([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/sms/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    contentObject["text"] = SourceExpressionConverter.ConvertToken(bodycontenttext);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendSMSv3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck([WorkflowExpression] Func<string> messageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatusCheckV3Response>(BuildSourceInput);
        }
    }

    public class TyntecsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Incoming([WorkflowExpression] Func<string> smsSender, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/sms/phone-numbers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smsSender, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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