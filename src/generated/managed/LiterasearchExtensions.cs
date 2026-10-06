//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Literasearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LiterasearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction GetMatterList([WorkflowExpression] Func<string> request)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetMatterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request"] = SourceExpressionConverter.ConvertO(request);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction GetMatterNarrative([WorkflowExpression] Func<string> matterId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetMatterNarrative";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["matterId"] = SourceExpressionConverter.ConvertO(matterId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction GetMatterDetail([WorkflowExpression] Func<string> matterId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetMatterDetail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["matterId"] = SourceExpressionConverter.ConvertO(matterId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class LiterasearchTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Literasearch;

    public partial class WorkflowManagedActions
    {
        public LiterasearchActions Literasearch(string connectionId) => new LiterasearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LiterasearchTriggers Literasearch(string connectionId) => new LiterasearchTriggers(connectionId);
    }
}