//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Agentsdk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AgentsdkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agentsdk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendActivity(Expression<Func<string>> agentEndpoint, Expression<Func<object>> activity)
        {
            var __workflow_agentEndpoint = WorkflowExpression.Compile(agentEndpoint, nameof(agentEndpoint), required: true);
            var __workflow_activity = WorkflowExpression.Compile(activity, nameof(activity), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["agentEndpoint"] = ExpressionConverter.Convert(__workflow_agentEndpoint);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AgentsdkTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Agentsdk;

    public partial class WorkflowManagedActions
    {
        public AgentsdkActions Agentsdk(string connectionId) => new AgentsdkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AgentsdkTriggers Agentsdk(string connectionId) => new AgentsdkTriggers(connectionId);
    }
}