//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Youtube
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YoutubeActions([ConnectionName] string connectionId)
    {
    }

    public class YoutubeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<VideoList> OnNewVideoInChannel(Expression<Func<string>> channelId, FlowRecurrence recurrence = null)
        {
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<VideoList>(() =>
            {
                var apiCallPath = "/trigger/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channelId"] = ExpressionConverter.Convert(__workflow_channelId);
                return new ApiConnectionTrigger<VideoList>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<VideoList> OnMyNewVideo(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/mine";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<VideoList>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<VideoList> OnNewVideoMatchingSearch(Expression<Func<string>> q, FlowRecurrence recurrence = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyTrigger<VideoList>(() =>
            {
                var apiCallPath = "/trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionTrigger<VideoList>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
    }

    public class VideoList
    {
        [JsonProperty("items")]
        public Video[] Videos { get; set; }
    }

    public class Video
    {
        [JsonProperty("id")]
        public string VideoId { get; set; }

        [JsonProperty("htmlLink")]
        public string WebLink { get; set; }

        [JsonProperty("snippet")]
        public VideoSnippet Snippet { get; set; }
    }

    public class VideoSnippet
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("channelTitle")]
        public string ChannelTitle { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedDateTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Youtube;

    public partial class WorkflowManagedActions
    {
        public YoutubeActions Youtube(string connectionId) => new YoutubeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YoutubeTriggers Youtube(string connectionId) => new YoutubeTriggers(connectionId);
    }
}
