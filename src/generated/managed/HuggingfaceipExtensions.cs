//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huggingfaceip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuggingfaceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ModelId(Expression<Func<string>> modelId, Expression<Func<ModelIdBodyInput>> body = null)
        {
            var __workflow_modelId = WorkflowExpression.Compile(modelId, nameof(modelId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_modelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<FillMaskResponseItem[], ApiConnectionActionConfiguration> FillMask(Expression<Func<FillMaskBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FillMaskResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bert-base-uncased";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FillMaskResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<SummarizationResponseItem[], ApiConnectionActionConfiguration> Summarization(Expression<Func<SummarizationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SummarizationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/facebook/bart-large-cnn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SummarizationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<AnswerResponse, ApiConnectionActionConfiguration> Answer(Expression<Func<AnswerBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AnswerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deepset/roberta-base-squad2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AnswerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<double[], ApiConnectionActionConfiguration> SentenceSimilarity(Expression<Func<SentenceSimilarityBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<double[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sentence-transformers/all-MiniLM-L6-v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<double[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextClassificationResponseItemItem[][], ApiConnectionActionConfiguration> TextClassification(Expression<Func<FillMaskBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextClassificationResponseItemItem[][], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/distilbert-base-uncased-finetuned-sst-2-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextClassificationResponseItemItem[][]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextGenerationResponseItem[], ApiConnectionActionConfiguration> TextGeneration(Expression<Func<SummarizationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextGenerationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gpt2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextGenerationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TokenClassificationResponseItem[], ApiConnectionActionConfiguration> TokenClassification(Expression<Func<TokenClassificationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TokenClassificationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dbmdz/bert-large-cased-finetuned-conll03-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TokenClassificationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TranslationResponseItem[], ApiConnectionActionConfiguration> Translation(Expression<Func<FillMaskBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TranslationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/t5-base";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TranslationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ZeroShotResponse, ApiConnectionActionConfiguration> ZeroShot(Expression<Func<ZeroShotBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ZeroShotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/facebook/bart-large-mnli";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ZeroShotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ConversationalResponse, ApiConnectionActionConfiguration> Conversational(Expression<Func<ConversationalBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ConversationalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/microsoft/DialoGPT-large";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConversationalResponse>(callPayload);
            });
        }
    }

    public class HuggingfaceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ModelIdBodyInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("table")]
        public JToken Table { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class BodyInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class FillMaskResponseItem
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("token")]
        public int Token { get; set; }

        [JsonProperty("token_str")]
        public string TokenStr { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class FillMaskBodyInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class SummarizationResponseItem
    {
        [JsonProperty("summary_text")]
        public string SummaryText { get; set; }
    }

    public class SummarizationBodyInput
    {
        [JsonProperty("inputs")]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public SummarizationBodyInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class SummarizationBodyInputParametersType
    {
        [JsonProperty("do_sample")]
        public bool? DoSample { get; set; }

        [JsonProperty("min_length")]
        public int? MinLength { get; set; }

        [JsonProperty("max_length")]
        public int? MaxLength { get; set; }

        [JsonProperty("top_k")]
        public int? TopK { get; set; }

        [JsonProperty("top_p")]
        public int? TopP { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        [JsonProperty("max_time")]
        public double? MaxTime { get; set; }
    }

    public class AnswerResponse
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }

    public class AnswerBodyInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public AnswerBodyInputInputsType Inputs { get; set; }
    }

    public class AnswerBodyInputInputsType
    {
        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("context", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Context { get; set; }
    }

    public class SentenceSimilarityBodyInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public SentenceSimilarityBodyInputInputsType Inputs { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class SentenceSimilarityBodyInputInputsType
    {
        [JsonProperty("source_sentence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceSentence { get; set; }

        [JsonProperty("sentences", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Sentences { get; set; }
    }

    public class TextClassificationResponseItemItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class TextGenerationResponseItem
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }
    }

    public class TokenClassificationResponseItem
    {
        [JsonProperty("entity_group")]
        public string EntityGroup { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class TokenClassificationBodyInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public TokenClassificationBodyInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class TokenClassificationBodyInputParametersType
    {
        [JsonProperty("aggregation_strategy")]
        public string AggregationStrategy { get; set; }
    }

    public class TranslationResponseItem
    {
        [JsonProperty("translation_text")]
        public string TranslationText { get; set; }
    }

    public class ZeroShotResponse
    {
        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("scores")]
        public double[] Scores { get; set; }
    }

    public class ZeroShotBodyInput
    {
        [JsonProperty("inputs")]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public ZeroShotBodyInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class ZeroShotBodyInputParametersType
    {
        [JsonProperty("candidate_labels")]
        public string[] CandidateLabels { get; set; }

        [JsonProperty("multi_label")]
        public bool? MultiLabel { get; set; }
    }

    public class ConversationalResponse
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }

        [JsonProperty("conversation")]
        public ConversationalResponseConversationType Conversation { get; set; }
    }

    public class ConversationalResponseConversationType
    {
        [JsonProperty("past_user_inputs")]
        public string[] PastUserInputs { get; set; }

        [JsonProperty("generated_responses")]
        public string[] GeneratedResponses { get; set; }
    }

    public class ConversationalBodyInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConversationalBodyInputInputsType Inputs { get; set; }

        [JsonProperty("parameters")]
        public ConversationalBodyInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public BodyInputOptionsType Options { get; set; }
    }

    public class ConversationalBodyInputInputsType
    {
        [JsonProperty("past_user_inputs")]
        public string[] PastUserInputs { get; set; }

        [JsonProperty("generated_responses")]
        public string[] GeneratedResponses { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class ConversationalBodyInputParametersType
    {
        [JsonProperty("min_length")]
        public int? MinLength { get; set; }

        [JsonProperty("max_length")]
        public int? MaxLength { get; set; }

        [JsonProperty("top_k")]
        public int? TopK { get; set; }

        [JsonProperty("top_p")]
        public int? TopP { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        [JsonProperty("max_time")]
        public double? MaxTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huggingfaceip;

    public partial class WorkflowManagedActions
    {
        public HuggingfaceipActions Huggingfaceip(string connectionId) => new HuggingfaceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuggingfaceipTriggers Huggingfaceip(string connectionId) => new HuggingfaceipTriggers(connectionId);
    }
}