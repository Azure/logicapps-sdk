//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivenlp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivenlpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<SentimentAnalysisResponse> AnalyticsSentiment([WorkflowExpression] Func<string> inputtextToAnalyze = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/analytics/sentiment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToAnalyze != null)
                {
                    input["TextToAnalyze"] = SourceExpressionConverter.ConvertToken(inputtextToAnalyze);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SentimentAnalysisResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<ProfanityAnalysisResponse> AnalyticsProfanity([WorkflowExpression] Func<string> inputtextToAnalyze = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/analytics/profanity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToAnalyze != null)
                {
                    input["TextToAnalyze"] = SourceExpressionConverter.ConvertToken(inputtextToAnalyze);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProfanityAnalysisResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<SubjectivityAnalysisResponse> AnalyticsSubjectivity([WorkflowExpression] Func<string> inputtextToAnalyze = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/analytics/subjectivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToAnalyze != null)
                {
                    input["TextToAnalyze"] = SourceExpressionConverter.ConvertToken(inputtextToAnalyze);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubjectivityAnalysisResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<ExtractEntitiesResponse> ExtractEntities([WorkflowExpression] Func<string> valueinputString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/extract-entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valueinputString != null)
                {
                    value["InputString"] = SourceExpressionConverter.ConvertToken(valueinputString);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractEntitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageDetectionResponse> LanguageDetectionGetLanguage([WorkflowExpression] Func<string> inputtextToDetect = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/language/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToDetect != null)
                {
                    input["textToDetect"] = SourceExpressionConverter.ConvertToken(inputtextToDetect);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LanguageDetectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateDeuToEng([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/translate/language/deu/to/eng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = SourceExpressionConverter.ConvertToken(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LanguageTranslationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateEngToDeu([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/translate/language/eng/to/deu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = SourceExpressionConverter.ConvertToken(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LanguageTranslationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateRusToEng([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/translate/language/rus/to/eng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = SourceExpressionConverter.ConvertToken(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LanguageTranslationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateEngToRus([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/translate/language/eng/to/rus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = SourceExpressionConverter.ConvertToken(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LanguageTranslationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<ParseResponse> ParseParseString([WorkflowExpression] Func<string> inputinputString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/parse/tree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputString != null)
                {
                    input["InputString"] = SourceExpressionConverter.ConvertToken(inputinputString);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ParseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagSentence([WorkflowExpression] Func<string> requestinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/pos/tag/sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = SourceExpressionConverter.ConvertToken(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagVerbs([WorkflowExpression] Func<string> requestinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/pos/tag/verbs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = SourceExpressionConverter.ConvertToken(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagNouns([WorkflowExpression] Func<string> requestinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/pos/tag/nouns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = SourceExpressionConverter.ConvertToken(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagAdjectives([WorkflowExpression] Func<string> requestinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/pos/tag/adjectives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = SourceExpressionConverter.ConvertToken(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagAdverbs([WorkflowExpression] Func<string> requestinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/pos/tag/adverbs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = SourceExpressionConverter.ConvertToken(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagPronouns([WorkflowExpression] Func<string> requestinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/pos/tag/pronouns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = SourceExpressionConverter.ConvertToken(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<RephraseResponse> RephraseEnglishRephraseSentenceBySentence([WorkflowExpression] Func<string> inputtextToTranslate = null, [WorkflowExpression] Func<int> inputtargetRephrasingCount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/rephrase/rephrase/eng/by-sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = SourceExpressionConverter.ConvertToken(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputtargetRephrasingCount != null)
                {
                    input["TargetRephrasingCount"] = SourceExpressionConverter.ConvertToken(inputtargetRephrasingCount);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RephraseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<SentenceSegmentationResponse> SegmentationGetSentences([WorkflowExpression] Func<string> inputinputString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/segmentation/sentences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputString != null)
                {
                    input["InputString"] = SourceExpressionConverter.ConvertToken(inputinputString);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SentenceSegmentationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<GetWordsResponse> SegmentationGetWords([WorkflowExpression] Func<string> inputinputText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/segmentation/words";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputText != null)
                {
                    input["InputText"] = SourceExpressionConverter.ConvertToken(inputinputText);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetWordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<CheckWordResponse> SpellcheckCorrectJson([WorkflowExpression] Func<string> valueword = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/spellcheck/check/word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valueword != null)
                {
                    value["Word"] = SourceExpressionConverter.ConvertToken(valueword);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CheckWordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        public IBodyWorkflowAction<CheckSentenceResponse> SpellcheckCheckSentence([WorkflowExpression] Func<string> valuesentence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nlp-v2/spellcheck/check/sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valuesentence != null)
                {
                    value["Sentence"] = SourceExpressionConverter.ConvertToken(valuesentence);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CheckSentenceResponse>(BuildSourceInput);
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

    public class ProfanityAnalysisResponse
    {
        public bool Successful { get; set; }
        public double ProfanityScoreResult { get; set; }
        public int SentenceCount { get; set; }
    }

    public class SubjectivityAnalysisResponse
    {
        public bool Successful { get; set; }
        public double SubjectivityScoreResult { get; set; }
        public int SentenceCount { get; set; }
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

    public class LanguageDetectionResponse
    {
        public bool Successful { get; set; }

        [JsonProperty("DetectedLanguage_ThreeLetterCode")]
        public string DetectedLanguageThreeLetterCode { get; set; }

        [JsonProperty("DetectedLanguage_FullName")]
        public string DetectedLanguageFullName { get; set; }
    }

    public class LanguageTranslationResponse
    {
        public bool Successful { get; set; }
        public string TranslatedTextResult { get; set; }
        public int SentenceCount { get; set; }
    }

    public class ParseResponse
    {
        public string ParseTree { get; set; }
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

    public class SentenceSegmentationResponse
    {
        public bool Successful { get; set; }
        public string[] Sentences { get; set; }
        public int SentenceCount { get; set; }
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

    public class CheckWordResponse
    {
        public bool Correct { get; set; }
        public string[] Suggestions { get; set; }
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