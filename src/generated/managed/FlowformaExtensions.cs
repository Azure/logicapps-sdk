//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flowforma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlowformaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flowforma")]
        public IBodyWorkflowAction<FlowCreatedResponse> CreateForm([WorkflowExpression] Func<string> connectionUrl, [WorkflowExpression] Func<string> flows, [WorkflowExpression] Func<object> question = null)
        {
            SourceExpression.Validate(connectionUrl, nameof(connectionUrl), required: true);
            SourceExpression.Validate(flows, nameof(flows), required: true);
            SourceExpression.Validate(question, nameof(question), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/flowforma";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["connectionUrl"] = SourceExpressionConverter.ConvertO(connectionUrl);
                callPayload.Queries["flows"] = SourceExpressionConverter.ConvertO(flows);
                callPayload.Body = SourceExpressionConverter.ConvertToken(question);
                return callPayload;
            }

            return new ApiConnectionAction<FlowCreatedResponse>(BuildSourceInput);
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