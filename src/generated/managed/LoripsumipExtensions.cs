//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loripsumip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoripsumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loripsumip")]
        public IBodyWorkflowAction<string> GetText([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> parameters)
        {
            var apiCallPath = String.Format("/api/{0}", ExpressionConverter.ConvertWithUrlEncoding(parameters, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class LoripsumipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Loripsumip;

    public partial class WorkflowManagedActions
    {
        public LoripsumipActions Loripsumip(string connectionId) => new LoripsumipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LoripsumipTriggers Loripsumip(string connectionId) => new LoripsumipTriggers(connectionId);
    }
}