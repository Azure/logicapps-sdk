//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Finra
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityWeeklySummary(Expression<Func<string>> contentType, Expression<Func<int>> limit)
        {
            var apiCallPath = "/data/group/otcMarket/name/weeklySummary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityMonthlySummary(Expression<Func<string>> contentType, Expression<Func<int>> limit)
        {
            var apiCallPath = "/data/group/otcMarket/name/monthlySummary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityOTCBlockSummary(Expression<Func<string>> contentType, Expression<Func<int>> limit)
        {
            var apiCallPath = "/data/group/otcMarket/name/otcBlocksSummary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class FinraTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Finra;

    public partial class WorkflowManagedActions
    {
        public FinraActions Finra(string connectionId) => new FinraActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinraTriggers Finra(string connectionId) => new FinraTriggers(connectionId);
    }
}