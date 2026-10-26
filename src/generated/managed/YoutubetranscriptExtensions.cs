//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Youtubetranscript
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YoutubetranscriptActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "youtubetranscript")]
        public IBodyWorkflowAction<TranscriptResponse, ApiConnectionActionConfiguration> GetTranscript(Expression<Func<GetTranscriptInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TranscriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/youtubei/v1/get_transcript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TranscriptResponse>(callPayload);
            });
        }
    }

    public class YoutubetranscriptTriggers([ConnectionName] string connectionId)
    {
    }

    public class TranscriptResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("segments")]
        public TranscriptSegment[] TranscriptSegments { get; set; }

        [JsonProperty("totalSegments")]
        public int TotalSegments { get; set; }

        [JsonProperty("totalDurationMs")]
        public int TotalDurationMs { get; set; }

        [JsonProperty("totalDurationFormatted")]
        public string TotalDuration { get; set; }

        [JsonProperty("fullTranscript")]
        public string FullTranscript { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("processedAt")]
        public string ProcessedAt { get; set; }

        [JsonProperty("error")]
        public string ErrorMessage { get; set; }
    }

    public class TranscriptSegment
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("startMs")]
        public int StartTimeMs { get; set; }

        [JsonProperty("endMs")]
        public int EndTimeMs { get; set; }

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }

        [JsonProperty("startTime")]
        public string StartTimeOriginal { get; set; }

        [JsonProperty("startTimeFormatted")]
        public string StartTimeFormatted { get; set; }

        [JsonProperty("endTimeFormatted")]
        public string EndTimeFormatted { get; set; }

        [JsonProperty("durationFormatted")]
        public string DurationFormatted { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }
    }

    public class GetTranscriptInput
    {
        [JsonProperty("context", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestContext Context { get; set; }

        [JsonProperty("externalVideoId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YouTubeVideoId { get; set; }
    }

    public class RequestContext
    {
        [JsonProperty("client")]
        public ClientInfo Client { get; set; }
    }

    public class ClientInfo
    {
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientVersion")]
        public string ClientVersion { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Youtubetranscript;

    public partial class WorkflowManagedActions
    {
        public YoutubetranscriptActions Youtubetranscript(string connectionId) => new YoutubetranscriptActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YoutubetranscriptTriggers Youtubetranscript(string connectionId) => new YoutubetranscriptTriggers(connectionId);
    }
}