//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robotsforpowerbi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobotsforpowerbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        public IBodyWorkflowAction<PlaylistEnableResponse, ApiConnectionActionConfiguration> PlaylistEnable(Expression<Func<string>> accountId, Expression<Func<PlaylistEnableInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlaylistEnableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/playlist.enable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Account Id"] = ExpressionConverter.Convert(__workflow_accountId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlaylistEnableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        public IBodyWorkflowAction<PlaylistDisableResponse, ApiConnectionActionConfiguration> PlaylistDisable(Expression<Func<string>> accountId, Expression<Func<PlaylistDisableInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlaylistDisableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/playlist.disable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Account Id"] = ExpressionConverter.Convert(__workflow_accountId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlaylistDisableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robotsforpowerbi")]
        public IBodyWorkflowAction<PlaylistExecuteResponse, ApiConnectionActionConfiguration> PlaylistExecute(Expression<Func<string>> accountId, Expression<Func<PlaylistExecuteInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlaylistExecuteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/playlist.execute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Account Id"] = ExpressionConverter.Convert(__workflow_accountId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class PlaylistEnableInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
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

    public class PlaylistDisableInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
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

    public class PlaylistExecuteInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
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