//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xooablockchain
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XooablockchainActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooablockchain")]
        public IWorkflowAction Create(Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = "/xldb/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["async"] = Convert.ToString(false);
            if (async != null)
                callPayload.Queries["async"] = ExpressionConverter.Convert(async);
            callPayload.Queries["timeout"] = Convert.ToString(5000);
            if (timeout != null)
                callPayload.Queries["timeout"] = ExpressionConverter.Convert(timeout);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class XooablockchainTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xooablockchain;

    public partial class WorkflowManagedActions
    {
        public XooablockchainActions Xooablockchain(string connectionId) => new XooablockchainActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XooablockchainTriggers Xooablockchain(string connectionId) => new XooablockchainTriggers(connectionId);
    }
}