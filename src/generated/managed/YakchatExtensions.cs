//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yakchat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YakchatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yakchat")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> bodyInboxEmail, Expression<Func<string>> bodyMessageText, Expression<Func<string>> bodyMessageTo)
        {
            var apiCallPath = "/Automation/SendMessage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            bodypropCount++;
            body["MessageText"] = ExpressionConverter.ConvertO(bodyMessageText);
            bodypropCount++;
            body["MessageTo"] = ExpressionConverter.ConvertO(bodyMessageTo);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yakchat")]
        public IBodyWorkflowAction<SendMessageV2Response> SendMessageV2(Expression<Func<string>> bodyInboxEmail, Expression<Func<string>> bodyMessageText, Expression<Func<string>> bodyMessageTo)
        {
            var apiCallPath = "/v2/Automation/SendMessage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            bodypropCount++;
            body["MessageText"] = ExpressionConverter.ConvertO(bodyMessageText);
            bodypropCount++;
            body["MessageTo"] = ExpressionConverter.ConvertO(bodyMessageTo);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageV2Response>(callPayload);
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InboundMessage(Expression<Func<string>> bodyInboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Automation/InboundMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OutboundMessage(Expression<Func<string>> bodyInboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Automation/OutboundMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger BidirectionalMessage(Expression<Func<string>> bodyInboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/Automation/BidirectionalMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger InboundMessageV2(Expression<Func<string>> bodyInboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/Automation/InboundMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OutboundMessageV2(Expression<Func<string>> bodyInboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/Automation/OutboundMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyInboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class SendMessageResponse
    {
        public string Message { get; set; }
        public string Result { get; set; }
    }

    public class SendMessageV2Response
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yakchat;

    public partial class WorkflowManagedActions
    {
        public YakchatActions Yakchat(string connectionId) => new YakchatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YakchatTriggers Yakchat(string connectionId) => new YakchatTriggers(connectionId);
    }
}