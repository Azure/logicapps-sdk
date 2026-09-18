//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubdocumentreadability
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubdocumentreadabilityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubdocumentreadability")]
        public IBodyWorkflowAction<ScorePostResponse> Score([WorkflowExpression] Func<object> file, [WorkflowExpression] Func<contentTypeInput> contentType)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/extract/document/readability-score/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ScorePostResponse>(BuildSourceInput);
        }
    }

    public class ApyhubdocumentreadabilityTriggers([ConnectionName] string connectionId)
    {
    }

    public class ScorePostResponse
    {
        [JsonProperty("data")]
        public ScorePostResponseDataType Data { get; set; }
    }

    public class ScorePostResponseDataType
    {
        [JsonProperty("flesh_kincaid_reading_ease")]
        public ScorePostResponseDataTypeFleshKincaidReadingEaseType FleshKincaidReadingEase { get; set; }

        [JsonProperty("stats")]
        public ScorePostResponseDataTypeStatsType Stats { get; set; }
    }

    public class ScorePostResponseDataTypeFleshKincaidReadingEaseType
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("label")]
        public bool Label { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("class_label")]
        public string ClassLabel { get; set; }
    }

    public class ScorePostResponseDataTypeStatsType
    {
        [JsonProperty("paragraphs")]
        public int Paragraphs { get; set; }

        [JsonProperty("sentences")]
        public int Sentences { get; set; }

        [JsonProperty("words")]
        public int Words { get; set; }

        [JsonProperty("characters")]
        public int Characters { get; set; }

        [JsonProperty("reading_time")]
        public double ReadingTime { get; set; }

        [JsonProperty("speaking_time")]
        public double SpeakingTime { get; set; }

        [JsonProperty("avg_word_length")]
        public double AvgWordLength { get; set; }

        [JsonProperty("avg_sentence_length")]
        public double AvgSentenceLength { get; set; }

        [JsonProperty("avg_paragraph_length")]
        public double AvgParagraphLength { get; set; }
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf,
        [EnumMember(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
        [EnumMember(Value = "application/msword")]
        ApplicationMsword
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubdocumentreadability;

    public partial class WorkflowManagedActions
    {
        public ApyhubdocumentreadabilityActions Apyhubdocumentreadability(string connectionId) => new ApyhubdocumentreadabilityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApyhubdocumentreadabilityTriggers Apyhubdocumentreadability(string connectionId) => new ApyhubdocumentreadabilityTriggers(connectionId);
    }
}