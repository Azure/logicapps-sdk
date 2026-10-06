//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xooablockchain
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XooablockchainActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooablockchain")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IWorkflowAction Create([WorkflowExpression] Func<bool> async = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooablockchain")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreate(WorkflowExpression<bool> async = null, WorkflowExpression<int> timeout = null, WorkflowExpression<string[]> body = null)
        {
            WorkflowExpression.Validate(async, nameof(async), required: false);
            WorkflowExpression.Validate(timeout, nameof(timeout), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }
    }

    public class XooablockchainTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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