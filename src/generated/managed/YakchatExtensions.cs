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
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/SendMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }
    }

    public class YakchatTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> BidirectionalMessage(Expression<Func<BidirectionalMessageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/BidirectionalMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> InboundMessage(Expression<Func<BidirectionalMessageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/InboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> OutboundMessage(Expression<Func<BidirectionalMessageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Automation/OutboundMessageNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class SendMessageResponse
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }

    public class SendMessageBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InboxEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessageText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessageTo { get; set; }
    }

    public class BidirectionalMessageBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InboxEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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