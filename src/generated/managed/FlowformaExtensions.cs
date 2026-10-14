//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flowforma
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class FlowformaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flowforma")]
        public IBodyWorkflowAction<FlowCreatedResponse> CreateForm(Expression<Func<string>> connectionUrl, Expression<Func<string>> flows, Expression<Func<object>> question = null)
        {
            var __workflow_connectionUrl = connectionUrl == null ? null : WorkflowExpression.Compile(connectionUrl);
            WorkflowExpression.Validate(__workflow_connectionUrl, nameof(connectionUrl), required: true);
            var __workflow_flows = flows == null ? null : WorkflowExpression.Compile(flows);
            WorkflowExpression.Validate(__workflow_flows, nameof(flows), required: true);
            var __workflow_question = question == null ? null : WorkflowExpression.Compile(question);
            WorkflowExpression.Validate(__workflow_question, nameof(question), required: false);
            return new DeferredBodyAction<FlowCreatedResponse>(() =>
            {
                var apiCallPath = "/api/flowforma";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["connectionUrl"] = ExpressionConverter.Convert(__workflow_connectionUrl);
                callPayload.Queries["flows"] = ExpressionConverter.Convert(__workflow_flows);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_question);
                return new ApiConnectionAction<FlowCreatedResponse>(callPayload);
            });
        }
    }

    public class FlowformaTriggers([ConnectionName] string connectionId)
    {
    }

    public class FlowCreatedResponse
    {
        [JsonProperty("Question")]
        public string Flow { get; set; }

        [JsonProperty("Message")]
        public string ResultMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flowforma;

    public partial class WorkflowManagedActions
    {
        public FlowformaActions Flowforma(string connectionId) => new FlowformaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlowformaTriggers Flowforma(string connectionId) => new FlowformaTriggers(connectionId);
    }
}
