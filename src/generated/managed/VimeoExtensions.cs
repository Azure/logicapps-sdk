//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vimeo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VimeoActions([ConnectionName] string connectionId)
    {
    }

    public class VimeoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Video[], ApiConnectionPollingTriggerConfiguration> OnVideoUpload()
        {
            return new DeferredBodyTrigger<Video[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/me/videos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("user,uri,name,description,link,created_time,modified_time");
                callPayload.Queries["sort"] = Convert.ToString("date");
                return new ApiConnectionPollingTrigger<Video[]>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<VideoWithChannelId[], ApiConnectionPollingTriggerConfiguration> OnNewVideoInChannel(Expression<Func<string>> channelId)
        {
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<VideoWithChannelId[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/channels/videos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channelId"] = ExpressionConverter.Convert(__workflow_channelId);
                callPayload.Queries["fields"] = Convert.ToString("user,uri,name,description,link,created_time,modified_time");
                callPayload.Queries["sort"] = Convert.ToString("added");
                callPayload.Queries["per_page"] = Convert.ToString(50);
                return new ApiConnectionPollingTrigger<VideoWithChannelId[]>(callPayload);
            });
        }
    }

    public class Video
    {
        [JsonProperty("name")]
        public string VideoName { get; set; }

        [JsonProperty("link")]
        public string VideoLink { get; set; }

        [JsonProperty("description")]
        public string VideoDescription { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("modified_time")]
        public string ModifiedTime { get; set; }

        [JsonProperty("user")]
        public VideoUserType User { get; set; }
    }

    public class VideoUserType
    {
        [JsonProperty("name")]
        public string VideoAuthor { get; set; }

        [JsonProperty("link")]
        public string VideoAuthorLink { get; set; }
    }

    public class VideoWithChannelId
    {
        [JsonProperty("name")]
        public string VideoName { get; set; }

        [JsonProperty("link")]
        public string VideoLink { get; set; }

        [JsonProperty("description")]
        public string VideoDescription { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("modified_time")]
        public string ModifiedTime { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        [JsonProperty("user")]
        public VideoWithChannelIdUserType User { get; set; }
    }

    public class VideoWithChannelIdUserType
    {
        [JsonProperty("name")]
        public string VideoAuthor { get; set; }

        [JsonProperty("link")]
        public string VideoAuthorLink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vimeo;

    public partial class WorkflowManagedActions
    {
        public VimeoActions Vimeo(string connectionId) => new VimeoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VimeoTriggers Vimeo(string connectionId) => new VimeoTriggers(connectionId);
    }
}