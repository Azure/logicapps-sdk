//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planful
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildFileLoad))]
        public IBodyWorkflowAction<FileLoadResponse> FileLoad([WorkflowExpression] Func<string> columnDelimiter, [WorkflowExpression] Func<string> dataLoadRuleName = null, [WorkflowExpression] Func<object> file = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FileLoadResponse> __BuildFileLoad(WorkflowExpression<string> columnDelimiter, WorkflowExpression<string> dataLoadRuleName = null, WorkflowExpression<object> file = null)
        {
            WorkflowExpression.Validate(columnDelimiter, nameof(columnDelimiter), required: true);
            WorkflowExpression.Validate(dataLoadRuleName, nameof(dataLoadRuleName), required: false);
            WorkflowExpression.Validate(file, nameof(file), required: false);
            return new DeferredBodyAction<FileLoadResponse>(() =>
            {
                var apiCallPath = "/financemodel/data/transferfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dataLoadRuleName != null)
                    callPayload.Queries["DataLoadRuleName"] = ExpressionConverter.Convert(dataLoadRuleName);
                callPayload.Queries["ColumnDelimiter"] = ExpressionConverter.Convert(columnDelimiter);
                return new ApiConnectionAction<FileLoadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        [WorkflowExpressionFactory(nameof(__BuildGetGLdata))]
        public IBodyWorkflowAction<GetGLdataResponseItem[]> GetGLdata([WorkflowExpression] Func<string> scenario, [WorkflowExpression] Func<int> fiscalYear, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGLdataResponseItem[]> __BuildGetGLdata(WorkflowExpression<string> scenario, WorkflowExpression<int> fiscalYear, WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(scenario, nameof(scenario), required: true);
            WorkflowExpression.Validate(fiscalYear, nameof(fiscalYear), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetGLdataResponseItem[]>(() =>
            {
                var apiCallPath = "/financemodel/data/extract/gldata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Scenario"] = ExpressionConverter.Convert(scenario);
                callPayload.Queries["FiscalYear"] = ExpressionConverter.Convert(fiscalYear);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
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