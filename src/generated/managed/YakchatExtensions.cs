//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yakchat
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class YakchatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yakchat")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> bodyinboxEmail, Expression<Func<string>> bodymessageText, Expression<Func<string>> bodymessageTo)
        {
            var __workflow_bodyinboxEmail = bodyinboxEmail == null ? null : WorkflowExpression.Compile(bodyinboxEmail);
            WorkflowExpression.Validate(__workflow_bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            var __workflow_bodymessageText = bodymessageText == null ? null : WorkflowExpression.Compile(bodymessageText);
            WorkflowExpression.Validate(__workflow_bodymessageText, nameof(bodymessageText), required: true);
            var __workflow_bodymessageTo = bodymessageTo == null ? null : WorkflowExpression.Compile(bodymessageTo);
            WorkflowExpression.Validate(__workflow_bodymessageTo, nameof(bodymessageTo), required: true);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = "/Automation/SendMessage";
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

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InboundMessage(Expression<Func<string>> bodyinboxEmail, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyinboxEmail = bodyinboxEmail == null ? null : WorkflowExpression.Compile(bodyinboxEmail);
            WorkflowExpression.Validate(__workflow_bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/Automation/InboundMessageNotification";
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

        public IWorkflowTrigger OutboundMessage(Expression<Func<string>> bodyinboxEmail, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyinboxEmail = bodyinboxEmail == null ? null : WorkflowExpression.Compile(bodyinboxEmail);
            WorkflowExpression.Validate(__workflow_bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/Automation/OutboundMessageNotification";
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

        public IWorkflowTrigger BidirectionalMessage(Expression<Func<string>> bodyinboxEmail, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyinboxEmail = bodyinboxEmail == null ? null : WorkflowExpression.Compile(bodyinboxEmail);
            WorkflowExpression.Validate(__workflow_bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            return new DeferredWorkflowTrigger(() =>
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
