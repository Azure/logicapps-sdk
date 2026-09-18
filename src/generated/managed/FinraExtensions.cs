//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finra
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityWeeklySummary([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<int> limit)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/data/group/otcMarket/name/weeklySummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityMonthlySummary([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<int> limit)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/data/group/otcMarket/name/monthlySummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finra")]
        public IBodyWorkflowAction<string> EquityOTCBlockSummary([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<int> limit)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/data/group/otcMarket/name/otcBlocksSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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