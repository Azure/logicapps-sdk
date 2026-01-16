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
        public IWorkflowAction GetMatterList(Expression<Func<string>> request)
        {
            var apiCallPath = "/GetMatterList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["request"] = ExpressionConverter.Convert(request);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction GetMatterNarrative(Expression<Func<string>> matterId)
        {
            var apiCallPath = "/GetMatterNarrative";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["matterId"] = ExpressionConverter.Convert(matterId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "literasearch")]
        public IWorkflowAction GetMatterDetail(Expression<Func<string>> matterId)
        {
            var apiCallPath = "/GetMatterDetail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["matterId"] = ExpressionConverter.Convert(matterId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class LiterasearchTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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