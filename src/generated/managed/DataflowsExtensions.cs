//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataflows
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataflowsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflows")]
        public IBodyWorkflowAction<DataflowModel> RefreshDataflow(Expression<Func<workspaceTypeInput>> workspaceType, Expression<Func<string>> groupIdForRefreshDataflow, Expression<Func<string>> dataflowIdForRefreshDataflow)
        {
            var __workflow_workspaceType = WorkflowExpression.Compile(workspaceType, nameof(workspaceType), required: true);
            var __workflow_groupIdForRefreshDataflow = WorkflowExpression.Compile(groupIdForRefreshDataflow, nameof(groupIdForRefreshDataflow), required: true);
            var __workflow_dataflowIdForRefreshDataflow = WorkflowExpression.Compile(dataflowIdForRefreshDataflow, nameof(dataflowIdForRefreshDataflow), required: true);
            return new DeferredBodyAction<DataflowModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/groups/{0}/dataflows/{1}/refreshdataflow", __workflow_groupIdForRefreshDataflow.WithUrlEncoding(1), __workflow_dataflowIdForRefreshDataflow.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(__workflow_workspaceType);
                return new ApiConnectionAction<DataflowModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class DataflowsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RefreshModel> OnRefreshComplete(Expression<Func<workspaceTypeInput>> workspaceType, Expression<Func<string>> groupIdForOnRefreshComplete, Expression<Func<string>> dataflowIdForOnRefreshComplete, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceType = WorkflowExpression.Compile(workspaceType, nameof(workspaceType), required: true);
            var __workflow_groupIdForOnRefreshComplete = WorkflowExpression.Compile(groupIdForOnRefreshComplete, nameof(groupIdForOnRefreshComplete), required: true);
            var __workflow_dataflowIdForOnRefreshComplete = WorkflowExpression.Compile(dataflowIdForOnRefreshComplete, nameof(dataflowIdForOnRefreshComplete), required: true);
            return new DeferredBodyTrigger<RefreshModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/groups/{0}/dataflows/{1}/onrefreshcomplete", __workflow_groupIdForOnRefreshComplete.WithUrlEncoding(1), __workflow_dataflowIdForOnRefreshComplete.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(__workflow_workspaceType);
                return new ApiConnectionTrigger<RefreshModel>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
