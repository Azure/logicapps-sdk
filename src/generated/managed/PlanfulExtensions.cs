//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planful
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlanfulActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<GetRulesResponseItem[]> GetRules()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/financemodel/data/rules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRulesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<FileLoadResponse> FileLoad([WorkflowExpression] Func<string> columnDelimiter, [WorkflowExpression] Func<string> dataLoadRuleName = null, [WorkflowExpression] Func<object> file = null)
        {
            SourceExpression.Validate(columnDelimiter, nameof(columnDelimiter), required: true);
            SourceExpression.Validate(dataLoadRuleName, nameof(dataLoadRuleName), required: false);
            SourceExpression.Validate(file, nameof(file), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/financemodel/data/transferfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dataLoadRuleName != null)
                    callPayload.Queries["DataLoadRuleName"] = SourceExpressionConverter.ConvertO(dataLoadRuleName);
                callPayload.Queries["ColumnDelimiter"] = SourceExpressionConverter.ConvertO(columnDelimiter);
                return callPayload;
            }

            return new ApiConnectionAction<FileLoadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<GetGLdataResponseItem[]> GetGLdata([WorkflowExpression] Func<string> scenario, [WorkflowExpression] Func<int> fiscalYear, [WorkflowExpression] Func<string> filter = null)
        {
            SourceExpression.Validate(scenario, nameof(scenario), required: true);
            SourceExpression.Validate(fiscalYear, nameof(fiscalYear), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/financemodel/data/extract/gldata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Scenario"] = SourceExpressionConverter.ConvertO(scenario);
                callPayload.Queries["FiscalYear"] = SourceExpressionConverter.ConvertO(fiscalYear);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<GetGLdataResponseItem[]>(BuildSourceInput);
        }
    }

    public class PlanfulTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRulesResponseItem
    {
        public int DataLoadRuleId { get; set; }
        public string Name { get; set; }
        public string LoadItem { get; set; }
    }

    public class FileLoadResponse
    {
        public int DataLoadRuleId { get; set; }
        public string ExcecutionId { get; set; }
        public bool RunAsynchronously { get; set; }
        public int Attempts { get; set; }
        public FileLoadResponseTransferResponseType TransferResponse { get; set; }
    }

    public class FileLoadResponseTransferResponseType
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class GetGLdataResponseItem
    {
        public string Scenario { get; set; }
        public int FiscalYear { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Planful;

    public partial class WorkflowManagedActions
    {
        public PlanfulActions Planful(string connectionId) => new PlanfulActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlanfulTriggers Planful(string connectionId) => new PlanfulTriggers(connectionId);
    }
}