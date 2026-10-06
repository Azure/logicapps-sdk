//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robotsforpowerbi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobotsforpowerbiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        [WorkflowExpressionFactory(nameof(__BuildPlaylistEnable))]
        public IBodyWorkflowAction<PlaylistEnableResponse> PlaylistEnable([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlaylistEnableResponse> __BuildPlaylistEnable(WorkflowExpression<string> accountId, WorkflowExpression<string> bodyid)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            return new DeferredBodyAction<PlaylistEnableResponse>(() =>
            {
                var apiCallPath = "/api/v1/playlist.enable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Account Id"] = ExpressionConverter.Convert(accountId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlaylistEnableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        [WorkflowExpressionFactory(nameof(__BuildPlaylistDisable))]
        public IBodyWorkflowAction<PlaylistDisableResponse> PlaylistDisable([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlaylistDisableResponse> __BuildPlaylistDisable(WorkflowExpression<string> accountId, WorkflowExpression<string> bodyid)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            return new DeferredBodyAction<PlaylistDisableResponse>(() =>
            {
                var apiCallPath = "/api/v1/playlist.disable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Account Id"] = ExpressionConverter.Convert(accountId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlaylistDisableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        [WorkflowExpressionFactory(nameof(__BuildPlaylistExecute))]
        public IBodyWorkflowAction<PlaylistExecuteResponse> PlaylistExecute([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlaylistExecuteResponse> __BuildPlaylistExecute(WorkflowExpression<string> accountId, WorkflowExpression<string> bodyid)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            return new DeferredBodyAction<PlaylistExecuteResponse>(() =>
            {
                var apiCallPath = "/api/v1/playlist.execute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Account Id"] = ExpressionConverter.Convert(accountId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlaylistExecuteResponse>(callPayload);
            });
        }
    }

    public class RobotsforpowerbiTriggers([ConnectionName] string connectionId)
    {
    }

    public class PlaylistEnableResponse
    {
        [JsonProperty("playlist")]
        public PlaylistEnableResponsePlaylistType Playlist { get; set; }

        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class PlaylistEnableResponsePlaylistType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("cronExpression")]
        public string CronExpression { get; set; }
    }

    public class PlaylistDisableResponse
    {
        [JsonProperty("playlist")]
        public PlaylistDisableResponsePlaylistType Playlist { get; set; }

        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class PlaylistDisableResponsePlaylistType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("cronExpression")]
        public string CronExpression { get; set; }
    }

    public class PlaylistExecuteResponse
    {
        [JsonProperty("playlist")]
        public PlaylistExecuteResponsePlaylistType Playlist { get; set; }

        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class PlaylistExecuteResponsePlaylistType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("cronExpression")]
        public string CronExpression { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Robotsforpowerbi;

    public partial class WorkflowManagedActions
    {
        public RobotsforpowerbiActions Robotsforpowerbi(string connectionId) => new RobotsforpowerbiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RobotsforpowerbiTriggers Robotsforpowerbi(string connectionId) => new RobotsforpowerbiTriggers(connectionId);
    }
}