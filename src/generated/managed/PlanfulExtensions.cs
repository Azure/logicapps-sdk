//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planful
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PlanfulActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<GetRulesResponseItem[]> GetRules()
        {
            var apiCallPath = "/financemodel/data/rules";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRulesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<FileLoadResponse> FileLoad(Expression<Func<string>> columnDelimiter, Expression<Func<string>> dataLoadRuleName = null, Expression<Func<object>> file = null)
        {
            var __workflow_columnDelimiter = columnDelimiter == null ? null : WorkflowExpression.Compile(columnDelimiter);
            WorkflowExpression.Validate(__workflow_columnDelimiter, nameof(columnDelimiter), required: true);
            var __workflow_dataLoadRuleName = dataLoadRuleName == null ? null : WorkflowExpression.Compile(dataLoadRuleName);
            WorkflowExpression.Validate(__workflow_dataLoadRuleName, nameof(dataLoadRuleName), required: false);
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: false);
            return new DeferredBodyAction<FileLoadResponse>(() =>
            {
                var apiCallPath = "/financemodel/data/transferfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dataLoadRuleName != null)
                    callPayload.Queries["DataLoadRuleName"] = ExpressionConverter.Convert(__workflow_dataLoadRuleName);
                callPayload.Queries["ColumnDelimiter"] = ExpressionConverter.Convert(__workflow_columnDelimiter);
                return new ApiConnectionAction<FileLoadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<GetGLdataResponseItem[]> GetGLdata(Expression<Func<string>> scenario, Expression<Func<int>> fiscalYear, Expression<Func<string>> filter = null)
        {
            var __workflow_scenario = scenario == null ? null : WorkflowExpression.Compile(scenario);
            WorkflowExpression.Validate(__workflow_scenario, nameof(scenario), required: true);
            var __workflow_fiscalYear = fiscalYear == null ? null : WorkflowExpression.Compile(fiscalYear);
            WorkflowExpression.Validate(__workflow_fiscalYear, nameof(fiscalYear), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetGLdataResponseItem[]>(() =>
            {
                var apiCallPath = "/financemodel/data/extract/gldata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Scenario"] = ExpressionConverter.Convert(__workflow_scenario);
                callPayload.Queries["FiscalYear"] = ExpressionConverter.Convert(__workflow_fiscalYear);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetGLdataResponseItem[]>(callPayload);
            });
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
