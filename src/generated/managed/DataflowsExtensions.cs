//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataflows
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflows")]
        public IBodyWorkflowAction<DataflowModel> RefreshDataflow([WorkflowExpression] Func<workspaceTypeInput> workspaceType, [WorkflowExpression] Func<string> groupIdForRefreshDataflow, [WorkflowExpression] Func<string> dataflowIdForRefreshDataflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/groups/{0}/dataflows/{1}/refreshdataflow", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdForRefreshDataflow, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataflowIdForRefreshDataflow, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = SourceExpressionConverter.Convert(workspaceType);
                return callPayload;
            }

            return new ApiConnectionAction<DataflowModel>(BuildSourceInput);
        }
    }

    public class DataflowsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RefreshModel> OnRefreshComplete([WorkflowExpression] Func<workspaceTypeInput> workspaceType, [WorkflowExpression] Func<string> groupIdForOnRefreshComplete, [WorkflowExpression] Func<string> dataflowIdForOnRefreshComplete, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/groups/{0}/dataflows/{1}/onrefreshcomplete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupIdForOnRefreshComplete, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataflowIdForOnRefreshComplete, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = SourceExpressionConverter.Convert(workspaceType);
                return callPayload;
            }

            return new ApiConnectionTrigger<RefreshModel>(BuildSourceInput, triggerName, recurrence);
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