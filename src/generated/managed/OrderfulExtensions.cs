//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Orderful
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrderfulActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListTransactions()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<object>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTransactionById(Expression<Func<int>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/transactions/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class OrderfulTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CommunicationChannelCreationResponse, ApiConnectionTriggerConfiguration> CommunicationChannel(Expression<Func<CommunicationChannelInput>> communicationChannelRequestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_communicationChannelRequestBody = WorkflowExpression.Compile(communicationChannelRequestBody, nameof(communicationChannelRequestBody), required: false);
            return new DeferredBodyTrigger<CommunicationChannelCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/destinations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_communicationChannelRequestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_communicationChannelRequestBody);
                return new ApiConnectionTrigger<CommunicationChannelCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CommunicationChannelCreationResponse
    {
        [JsonProperty("id")]
        public int WebhookCommunicationChannelId { get; set; }
    }

    public class CommunicationChannelInput
    {
        [JsonProperty("isActive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsActive { get; set; } = true;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommunicationChannelInputConfigType Config { get; set; }

        [JsonProperty("ownerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int OwnerId { get; set; }
    }

    public class CommunicationChannelInputConfigType
    {
        [JsonProperty("destinationTypeName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationTypeName { get; set; } = "http";

        [JsonProperty("guidelineFilter", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool GuidelineFilter { get; set; } = false;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Orderful;

    public partial class WorkflowManagedActions
    {
        public OrderfulActions Orderful(string connectionId) => new OrderfulActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OrderfulTriggers Orderful(string connectionId) => new OrderfulTriggers(connectionId);
    }
}