//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maqtextanalytics
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaqtextanalyticsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<SentimentClassifierResponseItem[], ApiConnectionActionConfiguration> SentimentClassifier(Expression<Func<SentimentClassifierInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SentimentClassifierResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/SentimentClassifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SentimentClassifierResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<PIIScrubberResponse, ApiConnectionActionConfiguration> PIIScrubber(Expression<Func<PIIScrubberInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PIIScrubberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/PIIScrubber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PIIScrubberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maqtextanalytics")]
        public IBodyWorkflowAction<KeyPhraseExtractorResponseItem[], ApiConnectionActionConfiguration> KeyPhraseExtractor(Expression<Func<KeyPhraseExtractorInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<KeyPhraseExtractorResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/KeyPhrase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<KeyPhraseExtractorResponseItem[]>(callPayload);
            });
        }
    }

    public class MaqtextanalyticsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SentimentClassifierResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sentiment")]
        public double Sentiment { get; set; }
    }

    public class SentimentClassifierInput
    {
        [JsonProperty("data")]
        public SentimentClassifierInputDataTypeItem[] Data { get; set; }
    }

    public class SentimentClassifierInputDataTypeItem
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PIIScrubberResponse
    {
        [JsonProperty("scrubbed_text")]
        public string ScrubbedText { get; set; }
    }

    public class PIIScrubberInput
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("entity_list")]
        public string EntityList { get; set; }
    }

    public class KeyPhraseExtractorResponseItem
    {
        public string KeyPhrase { get; set; }
        public double Score { get; set; }
        public string[] Similar { get; set; }
    }

    public class KeyPhraseExtractorInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("keyphrases_count")]
        public int? KeyphrasesCount { get; set; }

        [JsonProperty("diversity_threshold")]
        public double? DiversityThreshold { get; set; }

        [JsonProperty("alias_threshold")]
        public double? AliasThreshold { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Maqtextanalytics;

    public partial class WorkflowManagedActions
    {
        public MaqtextanalyticsActions Maqtextanalytics(string connectionId) => new MaqtextanalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaqtextanalyticsTriggers Maqtextanalytics(string connectionId) => new MaqtextanalyticsTriggers(connectionId);
    }
}