//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itautomate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItautomateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itautomate")]
        public IBodyWorkflowAction<JToken> RunCommand(Expression<Func<int>> id, Expression<Func<object>> commandInput = null)
        {
            var apiCallPath = "/RunCommand";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Body = ExpressionConverter.ConvertO(commandInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ItautomateTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Itautomate;

    public partial class WorkflowManagedActions
    {
        public ItautomateActions Itautomate(string connectionId) => new ItautomateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ItautomateTriggers Itautomate(string connectionId) => new ItautomateTriggers(connectionId);
    }
}