//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yakchat
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YakchatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yakchat")]
        public IBodyWorkflowAction<SendMessageV2Response, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> bodyinboxEmail, Expression<Func<string>> bodymessageText, Expression<Func<string>> bodymessageTo)
        {
            var __workflow_bodyinboxEmail = WorkflowExpression.Compile(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            var __workflow_bodymessageText = WorkflowExpression.Compile(bodymessageText, nameof(bodymessageText), required: true);
            var __workflow_bodymessageTo = WorkflowExpression.Compile(bodymessageTo, nameof(bodymessageTo), required: true);
            return new DeferredBodyAction<SendMessageV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/SendMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(__workflow_bodyinboxEmail);
                bodypropCount++;
                body["MessageText"] = ExpressionConverter.ConvertO(__workflow_bodymessageText);
                bodypropCount++;
                body["MessageTo"] = ExpressionConverter.ConvertO(__workflow_bodymessageTo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageV2Response>(callPayload);
            });
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> BidirectionalMessage(Expression<Func<string>> bodyinboxEmail, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyinboxEmail = WorkflowExpression.Compile(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/BidirectionalMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(__workflow_bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> InboundMessage(Expression<Func<string>> bodyinboxEmail, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyinboxEmail = WorkflowExpression.Compile(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/InboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(__workflow_bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OutboundMessage(Expression<Func<string>> bodyinboxEmail, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyinboxEmail = WorkflowExpression.Compile(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/OutboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(__workflow_bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
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