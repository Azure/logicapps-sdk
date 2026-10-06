//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Waybackmachineip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WaybackmachineipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waybackmachineip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSnapshot))]
        public IBodyWorkflowAction<GetSnapshotResponse> GetSnapshot([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<string> timestamp = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waybackmachineip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSnapshotResponse> __BuildGetSnapshot(WorkflowExpression<string> url, WorkflowExpression<string> timestamp = null)
        {
            WorkflowExpression.Validate(url, nameof(url), required: true);
            WorkflowExpression.Validate(timestamp, nameof(timestamp), required: false);
            return new DeferredBodyAction<GetSnapshotResponse>(() =>
            {
                var apiCallPath = "/wayback/available";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (timestamp != null)
                    callPayload.Queries["timestamp"] = ExpressionConverter.Convert(timestamp);
                return new ApiConnectionAction<GetSnapshotResponse>(callPayload);
            });
        }
    }

    public class WaybackmachineipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSnapshotResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("archived_snapshots")]
        public GetSnapshotResponseArchivedSnapshotsType ArchivedSnapshots { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class GetSnapshotResponseArchivedSnapshotsType
    {
        [JsonProperty("closest")]
        public GetSnapshotResponseArchivedSnapshotsTypeClosestType Closest { get; set; }
    }

    public class GetSnapshotResponseArchivedSnapshotsTypeClosestType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Waybackmachineip;

    public partial class WorkflowManagedActions
    {
        public WaybackmachineipActions Waybackmachineip(string connectionId) => new WaybackmachineipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WaybackmachineipTriggers Waybackmachineip(string connectionId) => new WaybackmachineipTriggers(connectionId);
    }
}