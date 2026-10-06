//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vimeo
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VimeoActions([ConnectionName] string connectionId)
    {
    }

    public class VimeoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Video[]> OnVideoUpload(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/me/videos";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fields"] = Convert.ToString("user,uri,name,description,link,created_time,modified_time");
            callPayload.Queries["sort"] = Convert.ToString("date");
            return new ApiConnectionTrigger<Video[]>(callPayload, triggerName, recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewVideoInChannel))]
        public IBodyWorkflowTrigger<VideoWithChannelId[]> OnNewVideoInChannel([WorkflowExpression] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VideoWithChannelId[]> __BuildOnNewVideoInChannel(WorkflowExpression<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<VideoWithChannelId[]>(() =>
            {
                var apiCallPath = "/trigger/channels/videos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channelId"] = ExpressionConverter.Convert(channelId);
                callPayload.Queries["fields"] = Convert.ToString("user,uri,name,description,link,created_time,modified_time");
                callPayload.Queries["sort"] = Convert.ToString("added");
                callPayload.Queries["per_page"] = Convert.ToString(50);
                return new ApiConnectionTrigger<VideoWithChannelId[]>(callPayload, triggerName, recurrence);
            }, triggerName);
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
        public string ChannelID { get; set; }

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