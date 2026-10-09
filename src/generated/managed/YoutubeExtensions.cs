//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Youtube
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YoutubeActions([ConnectionName] string connectionId)
    {
    }

    public class YoutubeTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewVideoInChannel))]
        public IBodyWorkflowTrigger<VideoList> OnNewVideoInChannel([WorkflowExpression] Func<string> channelId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VideoList> __BuildOnNewVideoInChannel(WorkflowExpression<string> channelId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<VideoList>(() =>
            {
                var apiCallPath = "/trigger/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channelId"] = ExpressionConverter.Convert(channelId);
                return new ApiConnectionTrigger<VideoList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VideoList> OnMyNewVideo(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/mine";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<VideoList>(callPayload, recurrence: recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewVideoMatchingSearch))]
        public IBodyWorkflowTrigger<VideoList> OnNewVideoMatchingSearch([WorkflowExpression] Func<string> q,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VideoList> __BuildOnNewVideoMatchingSearch(WorkflowExpression<string> q,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyTrigger<VideoList>(() =>
            {
                var apiCallPath = "/trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionTrigger<VideoList>(callPayload, recurrence: recurrence);
            });
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