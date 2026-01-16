//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Youtube
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YoutubeActions([ConnectionName] string connectionId)
    {
    }

    public class YoutubeTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<VideoList> OnNewVideoInChannel(Expression<Func<string>> channelId, string triggerName = null)
        {
            var apiCallPath = "/trigger/activities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["channelId"] = ExpressionConverter.Convert(channelId);
            return new ApiConnectionTrigger<VideoList>(callPayload);
        }

        public IOutputWorkflowTrigger<VideoList> OnMyNewVideo(string triggerName = null)
        {
            var apiCallPath = "/trigger/mine";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<VideoList>(callPayload);
        }

        public IOutputWorkflowTrigger<VideoList> OnNewVideoMatchingSearch(Expression<Func<string>> q, string triggerName = null)
        {
            var apiCallPath = "/trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionTrigger<VideoList>(callPayload);
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