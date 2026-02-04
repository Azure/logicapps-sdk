//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robotsforpowerbi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobotsforpowerbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        public IBodyWorkflowAction<PlaylistEnableResponse> PlaylistEnable(Expression<Func<string>> accountId, Expression<Func<string>> bodyid)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        public IBodyWorkflowAction<PlaylistDisableResponse> PlaylistDisable(Expression<Func<string>> accountId, Expression<Func<string>> bodyid)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        public IBodyWorkflowAction<PlaylistExecuteResponse> PlaylistExecute(Expression<Func<string>> accountId, Expression<Func<string>> bodyid)
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