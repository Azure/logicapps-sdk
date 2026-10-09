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
        [WorkflowExpressionFactory(nameof(__BuildRefreshDataflow))]
        public IBodyWorkflowAction<DataflowModel> RefreshDataflow([WorkflowExpression] Func<workspaceTypeInput> workspaceType, [WorkflowExpression] Func<string> groupIdForRefreshDataflow, [WorkflowExpression] Func<string> dataflowIdForRefreshDataflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataflowModel> __BuildRefreshDataflow(WorkflowExpression<workspaceTypeInput> workspaceType, WorkflowExpression<string> groupIdForRefreshDataflow, WorkflowExpression<string> dataflowIdForRefreshDataflow)
        {
            WorkflowExpression.Validate(workspaceType, nameof(workspaceType), required: true);
            WorkflowExpression.Validate(groupIdForRefreshDataflow, nameof(groupIdForRefreshDataflow), required: true);
            WorkflowExpression.Validate(dataflowIdForRefreshDataflow, nameof(dataflowIdForRefreshDataflow), required: true);
            return new DeferredBodyAction<DataflowModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/groups/{0}/dataflows/{1}/refreshdataflow", ExpressionConverter.ConvertWithUrlEncoding(groupIdForRefreshDataflow, 1), ExpressionConverter.ConvertWithUrlEncoding(dataflowIdForRefreshDataflow, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(workspaceType);
                return new ApiConnectionAction<DataflowModel>(callPayload);
            });
        }
    }

    public class DataflowsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnRefreshComplete))]
        public IBodyWorkflowTrigger<RefreshModel> OnRefreshComplete([WorkflowExpression] Func<workspaceTypeInput> workspaceType,[WorkflowExpression] Func<string> groupIdForOnRefreshComplete,[WorkflowExpression] Func<string> dataflowIdForOnRefreshComplete,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<RefreshModel> __BuildOnRefreshComplete(WorkflowExpression<workspaceTypeInput> workspaceType,WorkflowExpression<string> groupIdForOnRefreshComplete,WorkflowExpression<string> dataflowIdForOnRefreshComplete,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(workspaceType, nameof(workspaceType), required: true);
            WorkflowExpression.Validate(groupIdForOnRefreshComplete, nameof(groupIdForOnRefreshComplete), required: true);
            WorkflowExpression.Validate(dataflowIdForOnRefreshComplete, nameof(dataflowIdForOnRefreshComplete), required: true);
            return new DeferredBodyTrigger<RefreshModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/groups/{0}/dataflows/{1}/onrefreshcomplete", ExpressionConverter.ConvertWithUrlEncoding(groupIdForOnRefreshComplete, 1), ExpressionConverter.ConvertWithUrlEncoding(dataflowIdForOnRefreshComplete, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(workspaceType);
                return new ApiConnectionTrigger<RefreshModel>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class DataflowModel
    {
        [JsonProperty("dataflowName")]
        public string DataflowName { get; set; }

        [JsonProperty("dataflowId")]
        public string DataflowId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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