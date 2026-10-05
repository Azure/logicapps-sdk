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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreate(WorkflowValue<bool> async = null, WorkflowValue<int> timeout = null, WorkflowValue<string[]> body = null)
        {
            WorkflowValue.Validate(async, nameof(async), required: false);
            WorkflowValue.Validate(timeout, nameof(timeout), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
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
