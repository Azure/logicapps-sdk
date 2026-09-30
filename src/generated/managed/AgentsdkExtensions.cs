//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Agentsdk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AgentsdkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agentsdk")]
        public IBodyWorkflowAction<JToken> SendActivity([WorkflowExpression] Func<string> agentEndpoint)
        {
            SourceExpression.Validate(agentEndpoint, nameof(agentEndpoint), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["agentEndpoint"] = SourceExpressionConverter.ConvertO(agentEndpoint);
                var activity = new JObject();
                var activitypropCount = 0;
                if (activitypropCount > 0)
                {
                    callPayload.Body = activity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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