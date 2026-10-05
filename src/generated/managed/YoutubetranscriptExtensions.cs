//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Youtubetranscript
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YoutubetranscriptActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "youtubetranscript")]
        [WorkflowExpressionFactory(nameof(__BuildGetTranscript))]
        public IBodyWorkflowAction<TranscriptResponse> GetTranscript([WorkflowExpression] Func<string> bodyyouTubeVideoID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TranscriptResponse> __BuildGetTranscript(WorkflowValue<string> bodyyouTubeVideoID)
        {
            WorkflowValue.Validate(bodyyouTubeVideoID, nameof(bodyyouTubeVideoID), required: true);
            return new DeferredBodyAction<TranscriptResponse>(() =>
            {
                var apiCallPath = "/youtubei/v1/get_transcript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contextObject = new JObject();
                var contextObjectpropCount = 0;
                var clientObject = new JObject();
                var clientObjectpropCount = 0;
                clientObject["clientName"] = "WEB";
                clientObjectpropCount++;
                clientObject["clientVersion"] = "2.20250923.08.00";
                clientObjectpropCount++;
                if (clientObjectpropCount > 0)
                {
                    contextObject["client"] = clientObject;
                    contextObjectpropCount++;
                }

                if (contextObjectpropCount > 0)
                {
                    body["context"] = contextObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["externalVideoId"] = ExpressionConverter.ConvertO(bodyyouTubeVideoID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
