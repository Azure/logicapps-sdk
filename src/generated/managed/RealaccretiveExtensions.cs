//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Realaccretive
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RealaccretiveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "realaccretive")]
        public IBodyWorkflowAction<string> PullPricing()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pull_pricing";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "realaccretive")]
        public IBodyWorkflowAction<string> PullPortfolios()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pull_portfolios";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "realaccretive")]
        public IWorkflowAction PushPortfolios()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/push_portfolios";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class RealaccretiveTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Realaccretive;

    public partial class WorkflowManagedActions
    {
        public RealaccretiveActions Realaccretive(string connectionId) => new RealaccretiveActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RealaccretiveTriggers Realaccretive(string connectionId) => new RealaccretiveTriggers(connectionId);
    }
}