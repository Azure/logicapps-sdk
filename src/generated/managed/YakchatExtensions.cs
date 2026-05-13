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
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> bodyinboxEmail, Expression<Func<string>> bodymessageText, Expression<Func<string>> bodymessageTo)
        {
            var apiCallPath = "/Automation/SendMessage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
            bodypropCount++;
            body["MessageText"] = ExpressionConverter.ConvertO(bodymessageText);
            bodypropCount++;
            body["MessageTo"] = ExpressionConverter.ConvertO(bodymessageTo);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InboundMessage(Expression<Func<string>> bodyinboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Automation/InboundMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OutboundMessage(Expression<Func<string>> bodyinboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Automation/OutboundMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
            body["TargetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger BidirectionalMessage(Expression<Func<string>> bodyinboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/Automation/BidirectionalMessageNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
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