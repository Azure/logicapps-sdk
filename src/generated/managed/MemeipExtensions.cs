//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Memeip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MemeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "memeip")]
        public IBodyWorkflowAction<MemeRandomResponse> MemeRandom()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gimme";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemeRandomResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "memeip")]
        public IBodyWorkflowAction<MemeSubredditResponse> MemeSubreddit([WorkflowExpression] Func<string> subreddit)
        {
            SourceExpression.Validate(subreddit, nameof(subreddit), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gimme/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subreddit, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemeSubredditResponse>(BuildSourceInput);
        }
    }

    public class MemeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MemeRandomResponse
    {
        [JsonProperty("postLink")]
        public string PostLink { get; set; }

        [JsonProperty("subreddit")]
        public string Subreddit { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("spoiler")]
        public bool Spoiler { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("ups")]
        public int Ups { get; set; }

        [JsonProperty("preview")]
        public string[] Preview { get; set; }
    }

    public class MemeSubredditResponse
    {
        [JsonProperty("postLink")]
        public string PostLink { get; set; }

        [JsonProperty("subreddit")]
        public string Subreddit { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("spoiler")]
        public bool Spoiler { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("ups")]
        public int Ups { get; set; }

        [JsonProperty("preview")]
        public string[] Preview { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Memeip;

    public partial class WorkflowManagedActions
    {
        public MemeipActions Memeip(string connectionId) => new MemeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MemeipTriggers Memeip(string connectionId) => new MemeipTriggers(connectionId);
    }
}