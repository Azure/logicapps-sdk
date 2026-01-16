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
            var apiCallPath = "/financemodel/data/rules";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRulesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<FileLoadResponse> FileLoad(Expression<Func<string>> columnDelimiter, Expression<Func<string>> dataLoadRuleName = null, Expression<Func<object>> file = null)
        {
            var apiCallPath = "/financemodel/data/transferfile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (dataLoadRuleName != null)
                callPayload.Queries["DataLoadRuleName"] = ExpressionConverter.Convert(dataLoadRuleName);
            callPayload.Queries["ColumnDelimiter"] = ExpressionConverter.Convert(columnDelimiter);
            return new ApiConnectionAction<FileLoadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planful")]
        public IBodyWorkflowAction<GetGLdataResponseItem[]> GetGLdata(Expression<Func<string>> scenario, Expression<Func<int>> fiscalYear, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/financemodel/data/extract/gldata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Scenario"] = ExpressionConverter.Convert(scenario);
            callPayload.Queries["FiscalYear"] = ExpressionConverter.Convert(fiscalYear);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetGLdataResponseItem[]>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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