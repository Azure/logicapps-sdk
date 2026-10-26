//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivenlp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivenlpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<SentimentAnalysisResponse, ApiConnectionActionConfiguration> AnalyticsSentiment(Expression<Func<AnalyticsSentimentInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<SentimentAnalysisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/analytics/sentiment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SentimentAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<ProfanityAnalysisResponse, ApiConnectionActionConfiguration> AnalyticsProfanity(Expression<Func<AnalyticsProfanityInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ProfanityAnalysisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/analytics/profanity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ProfanityAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<SubjectivityAnalysisResponse, ApiConnectionActionConfiguration> AnalyticsSubjectivity(Expression<Func<AnalyticsSubjectivityInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<SubjectivityAnalysisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/analytics/subjectivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SubjectivityAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<ExtractEntitiesResponse, ApiConnectionActionConfiguration> ExtractEntities(Expression<Func<ExtractEntitiesPostInput>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<ExtractEntitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/extract-entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<ExtractEntitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageDetectionResponse, ApiConnectionActionConfiguration> LanguageDetectionGetLanguage(Expression<Func<LanguageDetectionGetLanguageInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<LanguageDetectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/language/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<LanguageDetectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse, ApiConnectionActionConfiguration> LanguageTranslationTranslateDeuToEng(Expression<Func<LanguageTranslationTranslateDeuToEngInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<LanguageTranslationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/deu/to/eng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse, ApiConnectionActionConfiguration> LanguageTranslationTranslateEngToDeu(Expression<Func<LanguageTranslationTranslateEngToDeuInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<LanguageTranslationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/eng/to/deu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse, ApiConnectionActionConfiguration> LanguageTranslationTranslateRusToEng(Expression<Func<LanguageTranslationTranslateRusToEngInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<LanguageTranslationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/rus/to/eng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse, ApiConnectionActionConfiguration> LanguageTranslationTranslateEngToRus(Expression<Func<LanguageTranslationTranslateEngToRusInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<LanguageTranslationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/eng/to/rus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<ParseResponse, ApiConnectionActionConfiguration> ParseParseString(Expression<Func<ParseParseStringInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ParseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/parse/tree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ParseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse, ApiConnectionActionConfiguration> PosTaggerTagSentence(Expression<Func<PosTaggerTagSentenceInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<PosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse, ApiConnectionActionConfiguration> PosTaggerTagVerbs(Expression<Func<PosTaggerTagVerbsInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<PosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/verbs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse, ApiConnectionActionConfiguration> PosTaggerTagNouns(Expression<Func<PosTaggerTagNounsInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<PosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/nouns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse, ApiConnectionActionConfiguration> PosTaggerTagAdjectives(Expression<Func<PosTaggerTagAdjectivesInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<PosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/adjectives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse, ApiConnectionActionConfiguration> PosTaggerTagAdverbs(Expression<Func<PosTaggerTagAdverbsInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<PosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/adverbs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse, ApiConnectionActionConfiguration> PosTaggerTagPronouns(Expression<Func<PosTaggerTagPronounsInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<PosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/pronouns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<RephraseResponse, ApiConnectionActionConfiguration> RephraseEnglishRephraseSentenceBySentence(Expression<Func<RephraseEnglishRephraseSentenceBySentenceInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<RephraseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/rephrase/rephrase/eng/by-sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<RephraseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<SentenceSegmentationResponse, ApiConnectionActionConfiguration> SegmentationGetSentences(Expression<Func<SegmentationGetSentencesInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<SentenceSegmentationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/segmentation/sentences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SentenceSegmentationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<GetWordsResponse, ApiConnectionActionConfiguration> SegmentationGetWords(Expression<Func<SegmentationGetWordsInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetWordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/segmentation/words";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetWordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<CheckWordResponse, ApiConnectionActionConfiguration> SpellcheckCorrectJson(Expression<Func<SpellcheckCorrectJsonInput>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<CheckWordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/spellcheck/check/word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<CheckWordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<CheckSentenceResponse, ApiConnectionActionConfiguration> SpellcheckCheckSentence(Expression<Func<SpellcheckCheckSentenceInput>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<CheckSentenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nlp-v2/spellcheck/check/sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<CheckSentenceResponse>(callPayload);
            });
        }
    }

    public class CloudmersivenlpTriggers([ConnectionName] string connectionId)
    {
    }

    public class SentimentAnalysisResponse
    {
        public bool Successful { get; set; }
        public string SentimentClassificationResult { get; set; }
        public double SentimentScoreResult { get; set; }
        public int SentenceCount { get; set; }
    }

    public class AnalyticsSentimentInput
    {
        public string TextToAnalyze { get; set; }
    }

    public class ProfanityAnalysisResponse
    {
        public bool Successful { get; set; }
        public double ProfanityScoreResult { get; set; }
        public int SentenceCount { get; set; }
    }

    public class AnalyticsProfanityInput
    {
        public string TextToAnalyze { get; set; }
    }

    public class SubjectivityAnalysisResponse
    {
        public bool Successful { get; set; }
        public double SubjectivityScoreResult { get; set; }
        public int SentenceCount { get; set; }
    }

    public class AnalyticsSubjectivityInput
    {
        public string TextToAnalyze { get; set; }
    }

    public class ExtractEntitiesResponse
    {
        public bool Successful { get; set; }
        public Entity[] Entities { get; set; }
    }

    public class Entity
    {
        public string EntityType { get; set; }
        public string EntityText { get; set; }
    }

    public class ExtractEntitiesPostInput
    {
        public string InputString { get; set; }
    }

    public class LanguageDetectionResponse
    {
        public bool Successful { get; set; }

        [JsonProperty("DetectedLanguage_ThreeLetterCode")]
        public string DetectedLanguageThreeLetterCode { get; set; }

        [JsonProperty("DetectedLanguage_FullName")]
        public string DetectedLanguageFullName { get; set; }
    }

    public class LanguageDetectionGetLanguageInput
    {
        [JsonProperty("textToDetect")]
        public string TextToDetect { get; set; }
    }

    public class LanguageTranslationResponse
    {
        public bool Successful { get; set; }
        public string TranslatedTextResult { get; set; }
        public int SentenceCount { get; set; }
    }

    public class LanguageTranslationTranslateDeuToEngInput
    {
        public string TextToTranslate { get; set; }
    }

    public class LanguageTranslationTranslateEngToDeuInput
    {
        public string TextToTranslate { get; set; }
    }

    public class LanguageTranslationTranslateRusToEngInput
    {
        public string TextToTranslate { get; set; }
    }

    public class LanguageTranslationTranslateEngToRusInput
    {
        public string TextToTranslate { get; set; }
    }

    public class ParseResponse
    {
        public string ParseTree { get; set; }
    }

    public class ParseParseStringInput
    {
        public string InputString { get; set; }
    }

    public class PosResponse
    {
        public PosSentence[] TaggedSentences { get; set; }
    }

    public class PosSentence
    {
        public PosTaggedWord[] Words { get; set; }
    }

    public class PosTaggedWord
    {
        public JToken Word { get; set; }
        public JToken Tag { get; set; }
    }

    public class PosTaggerTagSentenceInput
    {
        public string InputText { get; set; }
    }

    public class PosTaggerTagVerbsInput
    {
        public string InputText { get; set; }
    }

    public class PosTaggerTagNounsInput
    {
        public string InputText { get; set; }
    }

    public class PosTaggerTagAdjectivesInput
    {
        public string InputText { get; set; }
    }

    public class PosTaggerTagAdverbsInput
    {
        public string InputText { get; set; }
    }

    public class PosTaggerTagPronounsInput
    {
        public string InputText { get; set; }
    }

    public class RephraseResponse
    {
        public bool Successful { get; set; }
        public RephrasedSentence[] RephrasedResults { get; set; }
        public int SentenceCount { get; set; }
    }

    public class RephrasedSentence
    {
        public int SentenceIndex { get; set; }
        public string OriginalSentenceText { get; set; }
        public RephrasedSentenceOption[] Rephrasings { get; set; }
    }

    public class RephrasedSentenceOption
    {
        public int RephrasedOptionIndex { get; set; }
        public string RephrasedSentenceText { get; set; }
    }

    public class RephraseEnglishRephraseSentenceBySentenceInput
    {
        public string TextToTranslate { get; set; }
        public int? TargetRephrasingCount { get; set; }
    }

    public class SentenceSegmentationResponse
    {
        public bool Successful { get; set; }
        public string[] Sentences { get; set; }
        public int SentenceCount { get; set; }
    }

    public class SegmentationGetSentencesInput
    {
        public string InputString { get; set; }
    }

    public class GetWordsResponse
    {
        public WordPosition[] Words { get; set; }
    }

    public class WordPosition
    {
        public string Word { get; set; }
        public int WordIndex { get; set; }
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
    }

    public class SegmentationGetWordsInput
    {
        public string InputText { get; set; }
    }

    public class CheckWordResponse
    {
        public bool Correct { get; set; }
        public string[] Suggestions { get; set; }
    }

    public class SpellcheckCorrectJsonInput
    {
        public string Word { get; set; }
    }

    public class CheckSentenceResponse
    {
        public int IncorrectCount { get; set; }
        public CorrectWordInSentence[] Words { get; set; }
    }

    public class CorrectWordInSentence
    {
        public WordPosition Word { get; set; }
        public bool Correct { get; set; }
        public string[] Suggestions { get; set; }
    }

    public class SpellcheckCheckSentenceInput
    {
        public string Sentence { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivenlp;

    public partial class WorkflowManagedActions
    {
        public CloudmersivenlpActions Cloudmersivenlp(string connectionId) => new CloudmersivenlpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivenlpTriggers Cloudmersivenlp(string connectionId) => new CloudmersivenlpTriggers(connectionId);
    }
}