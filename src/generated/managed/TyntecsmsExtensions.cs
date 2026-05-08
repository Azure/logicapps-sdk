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
        public IBodyWorkflowAction<SendSMSv3Response> SendSMSv3(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttext = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecsms")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
        }
    }

    public class TyntecsmsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Incoming(Expression<Func<string>> smsSender, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/conversations/v3/power-automate/webhooks/channels/sms/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(smsSender, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["inboundMessageUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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