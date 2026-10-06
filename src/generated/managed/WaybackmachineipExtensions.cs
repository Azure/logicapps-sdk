//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Waybackmachineip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WaybackmachineipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waybackmachineip")]
        public IBodyWorkflowAction<GetSnapshotResponse> GetSnapshot([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<string> timestamp = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/wayback/available";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (timestamp != null)
                    callPayload.Queries["timestamp"] = SourceExpressionConverter.ConvertO(timestamp);
                return callPayload;
            }

            return new ApiConnectionAction<GetSnapshotResponse>(BuildSourceInput);
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