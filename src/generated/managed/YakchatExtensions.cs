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
        public IBodyWorkflowAction<SendMessageV2Response> SendMessage([WorkflowExpression] Func<string> bodyinboxEmail, [WorkflowExpression] Func<string> bodymessageText, [WorkflowExpression] Func<string> bodymessageTo)
        {
            SourceExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            SourceExpression.Validate(bodymessageText, nameof(bodymessageText), required: true);
            SourceExpression.Validate(bodymessageTo, nameof(bodymessageTo), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Automation/SendMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = SourceExpressionConverter.ConvertToken(bodyinboxEmail);
                bodypropCount++;
                body["MessageText"] = SourceExpressionConverter.ConvertToken(bodymessageText);
                bodypropCount++;
                body["MessageTo"] = SourceExpressionConverter.ConvertToken(bodymessageTo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageV2Response>(BuildSourceInput);
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger BidirectionalMessage([WorkflowExpression] Func<string> bodyinboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Automation/BidirectionalMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = SourceExpressionConverter.ConvertToken(bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger InboundMessage([WorkflowExpression] Func<string> bodyinboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Automation/InboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = SourceExpressionConverter.ConvertToken(bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OutboundMessage([WorkflowExpression] Func<string> bodyinboxEmail, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyinboxEmail, nameof(bodyinboxEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Automation/OutboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["InboxEmail"] = SourceExpressionConverter.ConvertToken(bodyinboxEmail);
                body["TargetUrl"] = "#{listCallbackUrl()}";
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