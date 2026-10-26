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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ModelId(Expression<Func<string>> modelId, Expression<Func<ModelIdPostInput>> body = null)
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
        public IBodyWorkflowAction<FillMaskPostResponseItem[], ApiConnectionActionConfiguration> FillMask(Expression<Func<FillMaskPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FillMaskPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bert-base-uncased";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FillMaskPostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<SummarizationPostResponseItem[], ApiConnectionActionConfiguration> Summarization(Expression<Func<SummarizationPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SummarizationPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/facebook/bart-large-cnn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SummarizationPostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<AnswerPostResponse, ApiConnectionActionConfiguration> Answer(Expression<Func<AnswerPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AnswerPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deepset/roberta-base-squad2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AnswerPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<double[], ApiConnectionActionConfiguration> SentenceSimilarity(Expression<Func<SentenceSimilarityPostInput>> body = null)
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
        public IBodyWorkflowAction<TextClassificationPostResponseItemItem[][], ApiConnectionActionConfiguration> TextClassification(Expression<Func<TextClassificationPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextClassificationPostResponseItemItem[][], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/distilbert-base-uncased-finetuned-sst-2-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextClassificationPostResponseItemItem[][]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TextGenerationPostResponseItem[], ApiConnectionActionConfiguration> TextGeneration(Expression<Func<TextGenerationPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TextGenerationPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gpt2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TextGenerationPostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TokenClassificationPostResponseItem[], ApiConnectionActionConfiguration> TokenClassification(Expression<Func<TokenClassificationPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TokenClassificationPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dbmdz/bert-large-cased-finetuned-conll03-english";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TokenClassificationPostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<TranslationPostResponseItem[], ApiConnectionActionConfiguration> Translation(Expression<Func<TranslationPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TranslationPostResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/t5-base";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TranslationPostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ZeroShotPostResponse, ApiConnectionActionConfiguration> ZeroShot(Expression<Func<ZeroShotPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ZeroShotPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/facebook/bart-large-mnli";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ZeroShotPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huggingfaceip")]
        public IBodyWorkflowAction<ConversationalPostResponse, ApiConnectionActionConfiguration> Conversational(Expression<Func<ConversationalPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ConversationalPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/microsoft/DialoGPT-large";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConversationalPostResponse>(callPayload);
            });
        }
    }

    public class HuggingfaceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ModelIdPostInput
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
        public ModelIdPostInputOptionsType Options { get; set; }
    }

    public class ModelIdPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class FillMaskPostResponseItem
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

    public class FillMaskPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("options")]
        public FillMaskPostInputOptionsType Options { get; set; }
    }

    public class FillMaskPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class SummarizationPostResponseItem
    {
        [JsonProperty("summary_text")]
        public string SummaryText { get; set; }
    }

    public class SummarizationPostInput
    {
        [JsonProperty("inputs")]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public SummarizationPostInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public SummarizationPostInputOptionsType Options { get; set; }
    }

    public class SummarizationPostInputParametersType
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

    public class SummarizationPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class AnswerPostResponse
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

    public class AnswerPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public AnswerPostInputInputsType Inputs { get; set; }
    }

    public class AnswerPostInputInputsType
    {
        [JsonProperty("question", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Question { get; set; }

        [JsonProperty("context", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Context { get; set; }
    }

    public class SentenceSimilarityPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public SentenceSimilarityPostInputInputsType Inputs { get; set; }

        [JsonProperty("options")]
        public SentenceSimilarityPostInputOptionsType Options { get; set; }
    }

    public class SentenceSimilarityPostInputInputsType
    {
        [JsonProperty("source_sentence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceSentence { get; set; }

        [JsonProperty("sentences", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Sentences { get; set; }
    }

    public class SentenceSimilarityPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class TextClassificationPostResponseItemItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class TextClassificationPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("options")]
        public TextClassificationPostInputOptionsType Options { get; set; }
    }

    public class TextClassificationPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class TextGenerationPostResponseItem
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }
    }

    public class TextGenerationPostInput
    {
        [JsonProperty("inputs")]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public TextGenerationPostInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public TextGenerationPostInputOptionsType Options { get; set; }
    }

    public class TextGenerationPostInputParametersType
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

    public class TextGenerationPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class TokenClassificationPostResponseItem
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

    public class TokenClassificationPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public TokenClassificationPostInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public TokenClassificationPostInputOptionsType Options { get; set; }
    }

    public class TokenClassificationPostInputParametersType
    {
        [JsonProperty("aggregation_strategy")]
        public string AggregationStrategy { get; set; }
    }

    public class TokenClassificationPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class TranslationPostResponseItem
    {
        [JsonProperty("translation_text")]
        public string TranslationText { get; set; }
    }

    public class TranslationPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Inputs { get; set; }

        [JsonProperty("options")]
        public TranslationPostInputOptionsType Options { get; set; }
    }

    public class TranslationPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class ZeroShotPostResponse
    {
        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("scores")]
        public double[] Scores { get; set; }
    }

    public class ZeroShotPostInput
    {
        [JsonProperty("inputs")]
        public string Inputs { get; set; }

        [JsonProperty("parameters")]
        public ZeroShotPostInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public ZeroShotPostInputOptionsType Options { get; set; }
    }

    public class ZeroShotPostInputParametersType
    {
        [JsonProperty("candidate_labels")]
        public string[] CandidateLabels { get; set; }

        [JsonProperty("multi_label")]
        public bool? MultiLabel { get; set; }
    }

    public class ZeroShotPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
    }

    public class ConversationalPostResponse
    {
        [JsonProperty("generated_text")]
        public string GeneratedText { get; set; }

        [JsonProperty("conversation")]
        public ConversationalPostResponseConversationType Conversation { get; set; }
    }

    public class ConversationalPostResponseConversationType
    {
        [JsonProperty("past_user_inputs")]
        public string[] PastUserInputs { get; set; }

        [JsonProperty("generated_responses")]
        public string[] GeneratedResponses { get; set; }
    }

    public class ConversationalPostInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConversationalPostInputInputsType Inputs { get; set; }

        [JsonProperty("parameters")]
        public ConversationalPostInputParametersType Parameters { get; set; }

        [JsonProperty("options")]
        public ConversationalPostInputOptionsType Options { get; set; }
    }

    public class ConversationalPostInputInputsType
    {
        [JsonProperty("past_user_inputs")]
        public string[] PastUserInputs { get; set; }

        [JsonProperty("generated_responses")]
        public string[] GeneratedResponses { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class ConversationalPostInputParametersType
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

    public class ConversationalPostInputOptionsType
    {
        [JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        [JsonProperty("wait_for_model")]
        public bool? WaitForModel { get; set; }
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