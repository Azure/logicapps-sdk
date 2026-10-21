//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finra
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityWeeklySummary(Expression<Func<string>> contentType, Expression<Func<int>> limit)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/data/group/otcMarket/name/weeklySummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityMonthlySummary(Expression<Func<string>> contentType, Expression<Func<int>> limit)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/data/group/otcMarket/name/monthlySummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityOTCBlockSummary(Expression<Func<string>> contentType, Expression<Func<int>> limit)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/data/group/otcMarket/name/otcBlocksSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
