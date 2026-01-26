//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Orderful
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrderfulActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction ListTransactions()
        {
            var apiCallPath = "/v2/transactions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction CreateTransaction()
        {
            var apiCallPath = "/v2/transactions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction GetTransactionById(Expression<Func<int>> transactionId)
        {
            var apiCallPath = String.Format("/v2/transactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class OrderfulTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Orderful;

    public partial class WorkflowManagedActions
    {
        public OrderfulActions Orderful(string connectionId) => new OrderfulActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OrderfulTriggers Orderful(string connectionId) => new OrderfulTriggers(connectionId);
    }
}