//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xooablockchain
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class XooablockchainActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooablockchain")]
        public IWorkflowAction Create(Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_async = async == null ? null : WorkflowExpression.Compile(async);
            WorkflowExpression.Validate(__workflow_async, nameof(async), required: false);
            var __workflow_timeout = timeout == null ? null : WorkflowExpression.Compile(timeout);
            WorkflowExpression.Validate(__workflow_timeout, nameof(timeout), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/xldb/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["async"] = Convert.ToString(false);
                if (__workflow_async != null)
                    callPayload.Queries["async"] = ExpressionConverter.Convert(__workflow_async);
                callPayload.Queries["timeout"] = Convert.ToString(5000);
                if (__workflow_timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
