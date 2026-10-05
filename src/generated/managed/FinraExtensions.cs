//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finra
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        [WorkflowExpressionFactory(nameof(__BuildEquityWeeklySummary))]
        public IBodyWorkflowAction<string> EquityWeeklySummary([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<int> limit)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildEquityWeeklySummary(WorkflowValue<string> contentType, WorkflowValue<int> limit)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/data/group/otcMarket/name/weeklySummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        [WorkflowExpressionFactory(nameof(__BuildEquityMonthlySummary))]
        public IBodyWorkflowAction<string> EquityMonthlySummary([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<int> limit)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildEquityMonthlySummary(WorkflowValue<string> contentType, WorkflowValue<int> limit)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/data/group/otcMarket/name/monthlySummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        [WorkflowExpressionFactory(nameof(__BuildEquityOTCBlockSummary))]
        public IBodyWorkflowAction<string> EquityOTCBlockSummary([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<int> limit)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildEquityOTCBlockSummary(WorkflowValue<string> contentType, WorkflowValue<int> limit)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/data/group/otcMarket/name/otcBlocksSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class FinraTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Finra;

    public partial class WorkflowManagedActions
    {
        public FinraActions Finra(string connectionId) => new FinraActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinraTriggers Finra(string connectionId) => new FinraTriggers(connectionId);
    }
}
