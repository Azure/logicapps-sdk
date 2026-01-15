//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Flowforma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlowformaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flowforma")]
        public IBodyWorkflowAction<FlowCreatedResponse> CreateForm(Expression<Func<string>> connectionUrl, Expression<Func<string>> flows, Expression<Func<object>> question = null)
        {
            var apiCallPath = "/api/flowforma";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["connectionUrl"] = ExpressionConverter.Convert(connectionUrl);
            callPayload.Queries["flows"] = ExpressionConverter.Convert(flows);
            callPayload.Body = ExpressionConverter.ConvertO(question);
            return new ApiConnectionAction<FlowCreatedResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Flowforma;

    public partial class WorkflowManagedActions
    {
        public FlowformaActions Flowforma(string connectionId) => new FlowformaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlowformaTriggers Flowforma(string connectionId) => new FlowformaTriggers(connectionId);
    }
}