//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataflows
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflows")]
        public IBodyWorkflowAction<DataflowModel> RefreshDataflow([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<workspaceTypeInput> workspaceType, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupIdForRefreshDataflow, [WorkflowExpression] Func<string> dataflowIdForRefreshDataflow)
        {
            var apiCallPath = String.Format("/api/groups/{0}/dataflows/{1}/refreshdataflow", ExpressionConverter.ConvertWithUrlEncoding(groupIdForRefreshDataflow, 1), ExpressionConverter.ConvertWithUrlEncoding(dataflowIdForRefreshDataflow, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(workspaceType);
            return new ApiConnectionAction<DataflowModel>(callPayload);
        }
    }

    public class DataflowsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RefreshModel> OnRefreshComplete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<workspaceTypeInput> workspaceType, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupIdForOnRefreshComplete, [WorkflowExpression] Func<string> dataflowIdForOnRefreshComplete, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/groups/{0}/dataflows/{1}/onrefreshcomplete", ExpressionConverter.ConvertWithUrlEncoding(groupIdForOnRefreshComplete, 1), ExpressionConverter.ConvertWithUrlEncoding(dataflowIdForOnRefreshComplete, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(workspaceType);
            return new ApiConnectionTrigger<RefreshModel>(callPayload, triggerName, recurrence);
        }
    }

    public class DataflowModel
    {
        [JsonProperty("dataflowName")]
        public string DataflowName { get; set; }

        [JsonProperty("dataflowId")]
        public string DataflowId { get; set; }
    }

    public enum workspaceTypeInput
    {
        Workspace,
        Environment
    }

    public class RefreshModel
    {
        [JsonProperty("dataflowId")]
        public string DataflowId { get; set; }

        [JsonProperty("dataflowName")]
        public string DataflowName { get; set; }

        [JsonProperty("refreshType")]
        public string RefreshType { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("status")]
        public string RefreshStatus { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dataflows;

    public partial class WorkflowManagedActions
    {
        public DataflowsActions Dataflows(string connectionId) => new DataflowsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DataflowsTriggers Dataflows(string connectionId) => new DataflowsTriggers(connectionId);
    }
}