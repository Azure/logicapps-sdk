//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yakchat
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YakchatActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yakchat")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> bodyinboxEmail, [WorkflowExpression] Func<string> bodymessageText, [WorkflowExpression] Func<string> bodymessageTo)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowExpression<string> bodyinboxEmail, WorkflowExpression<string> bodymessageText, WorkflowExpression<string> bodymessageTo)
        {
            WorkflowExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            WorkflowExpression.Validate(bodymessageText, nameof(bodymessageText), required: true);
            WorkflowExpression.Validate(bodymessageTo, nameof(bodymessageTo), required: true);
            return new DeferredBodyAction<SendMessageResponse>(() =>
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
            });
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildInboundMessage))]
        public IWorkflowTrigger InboundMessage([WorkflowExpression] Func<string> bodyinboxEmail,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildInboundMessage(WorkflowExpression<string> bodyinboxEmail,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/Automation/InboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOutboundMessage))]
        public IWorkflowTrigger OutboundMessage([WorkflowExpression] Func<string> bodyinboxEmail,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOutboundMessage(WorkflowExpression<string> bodyinboxEmail,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/Automation/OutboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildBidirectionalMessage))]
        public IWorkflowTrigger BidirectionalMessage([WorkflowExpression] Func<string> bodyinboxEmail,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBidirectionalMessage(WorkflowExpression<string> bodyinboxEmail,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v2/Automation/BidirectionalMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = ExpressionConverter.ConvertO(bodyinboxEmail);
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