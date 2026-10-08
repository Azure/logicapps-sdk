//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivenlp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivenlpActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyticsSentiment))]
        public IBodyWorkflowAction<SentimentAnalysisResponse> AnalyticsSentiment([WorkflowExpression] Func<string> inputtextToAnalyze = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SentimentAnalysisResponse> __BuildAnalyticsSentiment(WorkflowExpression<string> inputtextToAnalyze = null)
        {
            WorkflowExpression.Validate(inputtextToAnalyze, nameof(inputtextToAnalyze), required: false);
            return new DeferredBodyAction<SentimentAnalysisResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/analytics/sentiment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToAnalyze != null)
                {
                    input["TextToAnalyze"] = ExpressionConverter.ConvertO(inputtextToAnalyze);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<SentimentAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyticsProfanity))]
        public IBodyWorkflowAction<ProfanityAnalysisResponse> AnalyticsProfanity([WorkflowExpression] Func<string> inputtextToAnalyze = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProfanityAnalysisResponse> __BuildAnalyticsProfanity(WorkflowExpression<string> inputtextToAnalyze = null)
        {
            WorkflowExpression.Validate(inputtextToAnalyze, nameof(inputtextToAnalyze), required: false);
            return new DeferredBodyAction<ProfanityAnalysisResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/analytics/profanity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToAnalyze != null)
                {
                    input["TextToAnalyze"] = ExpressionConverter.ConvertO(inputtextToAnalyze);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<ProfanityAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyticsSubjectivity))]
        public IBodyWorkflowAction<SubjectivityAnalysisResponse> AnalyticsSubjectivity([WorkflowExpression] Func<string> inputtextToAnalyze = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubjectivityAnalysisResponse> __BuildAnalyticsSubjectivity(WorkflowExpression<string> inputtextToAnalyze = null)
        {
            WorkflowExpression.Validate(inputtextToAnalyze, nameof(inputtextToAnalyze), required: false);
            return new DeferredBodyAction<SubjectivityAnalysisResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/analytics/subjectivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToAnalyze != null)
                {
                    input["TextToAnalyze"] = ExpressionConverter.ConvertO(inputtextToAnalyze);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<SubjectivityAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildExtractEntities))]
        public IBodyWorkflowAction<ExtractEntitiesResponse> ExtractEntities([WorkflowExpression] Func<string> valueinputString = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractEntitiesResponse> __BuildExtractEntities(WorkflowExpression<string> valueinputString = null)
        {
            WorkflowExpression.Validate(valueinputString, nameof(valueinputString), required: false);
            return new DeferredBodyAction<ExtractEntitiesResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/extract-entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valueinputString != null)
                {
                    value["InputString"] = ExpressionConverter.ConvertO(valueinputString);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }

                return new ApiConnectionAction<ExtractEntitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageDetectionGetLanguage))]
        public IBodyWorkflowAction<LanguageDetectionResponse> LanguageDetectionGetLanguage([WorkflowExpression] Func<string> inputtextToDetect = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageDetectionResponse> __BuildLanguageDetectionGetLanguage(WorkflowExpression<string> inputtextToDetect = null)
        {
            WorkflowExpression.Validate(inputtextToDetect, nameof(inputtextToDetect), required: false);
            return new DeferredBodyAction<LanguageDetectionResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/language/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToDetect != null)
                {
                    input["textToDetect"] = ExpressionConverter.ConvertO(inputtextToDetect);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LanguageDetectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageTranslationTranslateDeuToEng))]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateDeuToEng([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageTranslationResponse> __BuildLanguageTranslationTranslateDeuToEng(WorkflowExpression<string> inputtextToTranslate = null)
        {
            WorkflowExpression.Validate(inputtextToTranslate, nameof(inputtextToTranslate), required: false);
            return new DeferredBodyAction<LanguageTranslationResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/deu/to/eng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = ExpressionConverter.ConvertO(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageTranslationTranslateEngToDeu))]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateEngToDeu([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageTranslationResponse> __BuildLanguageTranslationTranslateEngToDeu(WorkflowExpression<string> inputtextToTranslate = null)
        {
            WorkflowExpression.Validate(inputtextToTranslate, nameof(inputtextToTranslate), required: false);
            return new DeferredBodyAction<LanguageTranslationResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/eng/to/deu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = ExpressionConverter.ConvertO(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageTranslationTranslateRusToEng))]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateRusToEng([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageTranslationResponse> __BuildLanguageTranslationTranslateRusToEng(WorkflowExpression<string> inputtextToTranslate = null)
        {
            WorkflowExpression.Validate(inputtextToTranslate, nameof(inputtextToTranslate), required: false);
            return new DeferredBodyAction<LanguageTranslationResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/rus/to/eng";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = ExpressionConverter.ConvertO(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageTranslationTranslateEngToRus))]
        public IBodyWorkflowAction<LanguageTranslationResponse> LanguageTranslationTranslateEngToRus([WorkflowExpression] Func<string> inputtextToTranslate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageTranslationResponse> __BuildLanguageTranslationTranslateEngToRus(WorkflowExpression<string> inputtextToTranslate = null)
        {
            WorkflowExpression.Validate(inputtextToTranslate, nameof(inputtextToTranslate), required: false);
            return new DeferredBodyAction<LanguageTranslationResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/translate/language/eng/to/rus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = ExpressionConverter.ConvertO(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LanguageTranslationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildParseParseString))]
        public IBodyWorkflowAction<ParseResponse> ParseParseString([WorkflowExpression] Func<string> inputinputString = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseResponse> __BuildParseParseString(WorkflowExpression<string> inputinputString = null)
        {
            WorkflowExpression.Validate(inputinputString, nameof(inputinputString), required: false);
            return new DeferredBodyAction<ParseResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/parse/tree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputString != null)
                {
                    input["InputString"] = ExpressionConverter.ConvertO(inputinputString);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<ParseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildPosTaggerTagSentence))]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagSentence([WorkflowExpression] Func<string> requestinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosResponse> __BuildPosTaggerTagSentence(WorkflowExpression<string> requestinputText = null)
        {
            WorkflowExpression.Validate(requestinputText, nameof(requestinputText), required: false);
            return new DeferredBodyAction<PosResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = ExpressionConverter.ConvertO(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildPosTaggerTagVerbs))]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagVerbs([WorkflowExpression] Func<string> requestinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosResponse> __BuildPosTaggerTagVerbs(WorkflowExpression<string> requestinputText = null)
        {
            WorkflowExpression.Validate(requestinputText, nameof(requestinputText), required: false);
            return new DeferredBodyAction<PosResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/verbs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = ExpressionConverter.ConvertO(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildPosTaggerTagNouns))]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagNouns([WorkflowExpression] Func<string> requestinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosResponse> __BuildPosTaggerTagNouns(WorkflowExpression<string> requestinputText = null)
        {
            WorkflowExpression.Validate(requestinputText, nameof(requestinputText), required: false);
            return new DeferredBodyAction<PosResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/nouns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = ExpressionConverter.ConvertO(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildPosTaggerTagAdjectives))]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagAdjectives([WorkflowExpression] Func<string> requestinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosResponse> __BuildPosTaggerTagAdjectives(WorkflowExpression<string> requestinputText = null)
        {
            WorkflowExpression.Validate(requestinputText, nameof(requestinputText), required: false);
            return new DeferredBodyAction<PosResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/adjectives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = ExpressionConverter.ConvertO(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildPosTaggerTagAdverbs))]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagAdverbs([WorkflowExpression] Func<string> requestinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosResponse> __BuildPosTaggerTagAdverbs(WorkflowExpression<string> requestinputText = null)
        {
            WorkflowExpression.Validate(requestinputText, nameof(requestinputText), required: false);
            return new DeferredBodyAction<PosResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/adverbs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = ExpressionConverter.ConvertO(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildPosTaggerTagPronouns))]
        public IBodyWorkflowAction<PosResponse> PosTaggerTagPronouns([WorkflowExpression] Func<string> requestinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosResponse> __BuildPosTaggerTagPronouns(WorkflowExpression<string> requestinputText = null)
        {
            WorkflowExpression.Validate(requestinputText, nameof(requestinputText), required: false);
            return new DeferredBodyAction<PosResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/pos/tag/pronouns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestinputText != null)
                {
                    request["InputText"] = ExpressionConverter.ConvertO(requestinputText);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildRephraseEnglishRephraseSentenceBySentence))]
        public IBodyWorkflowAction<RephraseResponse> RephraseEnglishRephraseSentenceBySentence([WorkflowExpression] Func<string> inputtextToTranslate = null, [WorkflowExpression] Func<int> inputtargetRephrasingCount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RephraseResponse> __BuildRephraseEnglishRephraseSentenceBySentence(WorkflowExpression<string> inputtextToTranslate = null, WorkflowExpression<int> inputtargetRephrasingCount = null)
        {
            WorkflowExpression.Validate(inputtextToTranslate, nameof(inputtextToTranslate), required: false);
            WorkflowExpression.Validate(inputtargetRephrasingCount, nameof(inputtargetRephrasingCount), required: false);
            return new DeferredBodyAction<RephraseResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/rephrase/rephrase/eng/by-sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputtextToTranslate != null)
                {
                    input["TextToTranslate"] = ExpressionConverter.ConvertO(inputtextToTranslate);
                    inputpropCount++;
                }

                if (inputtargetRephrasingCount != null)
                {
                    input["TargetRephrasingCount"] = ExpressionConverter.ConvertO(inputtargetRephrasingCount);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<RephraseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildSegmentationGetSentences))]
        public IBodyWorkflowAction<SentenceSegmentationResponse> SegmentationGetSentences([WorkflowExpression] Func<string> inputinputString = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SentenceSegmentationResponse> __BuildSegmentationGetSentences(WorkflowExpression<string> inputinputString = null)
        {
            WorkflowExpression.Validate(inputinputString, nameof(inputinputString), required: false);
            return new DeferredBodyAction<SentenceSegmentationResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/segmentation/sentences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputString != null)
                {
                    input["InputString"] = ExpressionConverter.ConvertO(inputinputString);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<SentenceSegmentationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildSegmentationGetWords))]
        public IBodyWorkflowAction<GetWordsResponse> SegmentationGetWords([WorkflowExpression] Func<string> inputinputText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWordsResponse> __BuildSegmentationGetWords(WorkflowExpression<string> inputinputText = null)
        {
            WorkflowExpression.Validate(inputinputText, nameof(inputinputText), required: false);
            return new DeferredBodyAction<GetWordsResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/segmentation/words";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputText != null)
                {
                    input["InputText"] = ExpressionConverter.ConvertO(inputinputText);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<GetWordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildSpellcheckCorrectJson))]
        public IBodyWorkflowAction<CheckWordResponse> SpellcheckCorrectJson([WorkflowExpression] Func<string> valueword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckWordResponse> __BuildSpellcheckCorrectJson(WorkflowExpression<string> valueword = null)
        {
            WorkflowExpression.Validate(valueword, nameof(valueword), required: false);
            return new DeferredBodyAction<CheckWordResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/spellcheck/check/word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valueword != null)
                {
                    value["Word"] = ExpressionConverter.ConvertO(valueword);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }

                return new ApiConnectionAction<CheckWordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivenlp")]
        [WorkflowExpressionFactory(nameof(__BuildSpellcheckCheckSentence))]
        public IBodyWorkflowAction<CheckSentenceResponse> SpellcheckCheckSentence([WorkflowExpression] Func<string> valuesentence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckSentenceResponse> __BuildSpellcheckCheckSentence(WorkflowExpression<string> valuesentence = null)
        {
            WorkflowExpression.Validate(valuesentence, nameof(valuesentence), required: false);
            return new DeferredBodyAction<CheckSentenceResponse>(() =>
            {
                var apiCallPath = "/nlp-v2/spellcheck/check/sentence";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valuesentence != null)
                {
                    value["Sentence"] = ExpressionConverter.ConvertO(valuesentence);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }

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