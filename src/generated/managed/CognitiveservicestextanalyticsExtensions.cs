//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicestextanalytics
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicestextanalyticsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildEntitiesLinking))]
        public IBodyWorkflowAction<EntityLinkingResult> EntitiesLinking([WorkflowExpression] Func<MultiLanguageInputV3[]> inputdocuments, [WorkflowExpression] Func<string> modelVersion = null, [WorkflowExpression] Func<bool> showStats = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityLinkingResult> __BuildEntitiesLinking(WorkflowExpression<MultiLanguageInputV3[]> inputdocuments, WorkflowExpression<string> modelVersion = null, WorkflowExpression<bool> showStats = null)
        {
            WorkflowExpression.Validate(inputdocuments, nameof(inputdocuments), required: true);
            WorkflowExpression.Validate(modelVersion, nameof(modelVersion), required: false);
            WorkflowExpression.Validate(showStats, nameof(showStats), required: false);
            return new DeferredBodyAction<EntityLinkingResult>(() =>
            {
                var apiCallPath = "/text/analytics/v3.0/entities/linking";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (modelVersion != null)
                    callPayload.Queries["model-version"] = ExpressionConverter.Convert(modelVersion);
                if (showStats != null)
                    callPayload.Queries["showStats"] = ExpressionConverter.Convert(showStats);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["documents"] = ExpressionConverter.ConvertO(inputdocuments);
                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<EntityLinkingResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildEntitiesRecognitionGeneral))]
        public IBodyWorkflowAction<EntitiesResultV3> EntitiesRecognitionGeneral([WorkflowExpression] Func<MultiLanguageInputV3[]> inputdocuments, [WorkflowExpression] Func<string> modelVersion = null, [WorkflowExpression] Func<bool> showStats = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntitiesResultV3> __BuildEntitiesRecognitionGeneral(WorkflowExpression<MultiLanguageInputV3[]> inputdocuments, WorkflowExpression<string> modelVersion = null, WorkflowExpression<bool> showStats = null)
        {
            WorkflowExpression.Validate(inputdocuments, nameof(inputdocuments), required: true);
            WorkflowExpression.Validate(modelVersion, nameof(modelVersion), required: false);
            WorkflowExpression.Validate(showStats, nameof(showStats), required: false);
            return new DeferredBodyAction<EntitiesResultV3>(() =>
            {
                var apiCallPath = "/text/analytics/v3.0/entities/recognition/general";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (modelVersion != null)
                    callPayload.Queries["model-version"] = ExpressionConverter.Convert(modelVersion);
                if (showStats != null)
                    callPayload.Queries["showStats"] = ExpressionConverter.Convert(showStats);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["documents"] = ExpressionConverter.ConvertO(inputdocuments);
                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<EntitiesResultV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildKeyPhrase))]
        public IBodyWorkflowAction<KeyPhraseResultV3> KeyPhrase([WorkflowExpression] Func<MultiLanguageInputV3[]> inputdocuments, [WorkflowExpression] Func<string> modelVersion = null, [WorkflowExpression] Func<bool> showStats = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeyPhraseResultV3> __BuildKeyPhrase(WorkflowExpression<MultiLanguageInputV3[]> inputdocuments, WorkflowExpression<string> modelVersion = null, WorkflowExpression<bool> showStats = null)
        {
            WorkflowExpression.Validate(inputdocuments, nameof(inputdocuments), required: true);
            WorkflowExpression.Validate(modelVersion, nameof(modelVersion), required: false);
            WorkflowExpression.Validate(showStats, nameof(showStats), required: false);
            return new DeferredBodyAction<KeyPhraseResultV3>(() =>
            {
                var apiCallPath = "/text/analytics/v3.0/keyPhrases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (modelVersion != null)
                    callPayload.Queries["model-version"] = ExpressionConverter.Convert(modelVersion);
                if (showStats != null)
                    callPayload.Queries["showStats"] = ExpressionConverter.Convert(showStats);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["documents"] = ExpressionConverter.ConvertO(inputdocuments);
                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<KeyPhraseResultV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildLanguages))]
        public IBodyWorkflowAction<LanguageResultV3> Languages([WorkflowExpression] Func<LanguageInputV3[]> inputdocuments, [WorkflowExpression] Func<string> modelVersion = null, [WorkflowExpression] Func<bool> showStats = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageResultV3> __BuildLanguages(WorkflowExpression<LanguageInputV3[]> inputdocuments, WorkflowExpression<string> modelVersion = null, WorkflowExpression<bool> showStats = null)
        {
            WorkflowExpression.Validate(inputdocuments, nameof(inputdocuments), required: true);
            WorkflowExpression.Validate(modelVersion, nameof(modelVersion), required: false);
            WorkflowExpression.Validate(showStats, nameof(showStats), required: false);
            return new DeferredBodyAction<LanguageResultV3>(() =>
            {
                var apiCallPath = "/text/analytics/v3.0/languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (modelVersion != null)
                    callPayload.Queries["model-version"] = ExpressionConverter.Convert(modelVersion);
                if (showStats != null)
                    callPayload.Queries["showStats"] = ExpressionConverter.Convert(showStats);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["documents"] = ExpressionConverter.ConvertO(inputdocuments);
                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LanguageResultV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [WorkflowExpressionFactory(nameof(__BuildSentiment))]
        public IBodyWorkflowAction<SentimentResponse> Sentiment([WorkflowExpression] Func<MultiLanguageInputV3[]> inputdocuments, [WorkflowExpression] Func<string> modelVersion = null, [WorkflowExpression] Func<bool> showStats = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicestextanalytics")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SentimentResponse> __BuildSentiment(WorkflowExpression<MultiLanguageInputV3[]> inputdocuments, WorkflowExpression<string> modelVersion = null, WorkflowExpression<bool> showStats = null)
        {
            WorkflowExpression.Validate(inputdocuments, nameof(inputdocuments), required: true);
            WorkflowExpression.Validate(modelVersion, nameof(modelVersion), required: false);
            WorkflowExpression.Validate(showStats, nameof(showStats), required: false);
            return new DeferredBodyAction<SentimentResponse>(() =>
            {
                var apiCallPath = "/text/analytics/v3.0/sentiment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (modelVersion != null)
                    callPayload.Queries["model-version"] = ExpressionConverter.Convert(modelVersion);
                if (showStats != null)
                    callPayload.Queries["showStats"] = ExpressionConverter.Convert(showStats);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["documents"] = ExpressionConverter.ConvertO(inputdocuments);
                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<SentimentResponse>(callPayload);
            });
        }
    }

    public class CognitiveservicestextanalyticsTriggers([ConnectionName] string connectionId)
    {
    }

    public class EntityLinkingResult
    {
        [JsonProperty("documents")]
        public DocumentLinkedEntities[] Documents { get; set; }

        [JsonProperty("errors")]
        public DocumentError[] Errors { get; set; }

        [JsonProperty("statistics")]
        public RequestStatistics Statistics { get; set; }

        [JsonProperty("modelVersion")]
        public string ModelVersion { get; set; }
    }

    public class DocumentLinkedEntities
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("entities")]
        public LinkedEntity[] Entities { get; set; }

        [JsonProperty("warnings")]
        public TextAnalyticsWarning[] Warnings { get; set; }

        [JsonProperty("statistics")]
        public DocumentStatistics Statistics { get; set; }
    }

    public class LinkedEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("dataSource")]
        public string DataSource { get; set; }
    }

    public class Match
    {
        [JsonProperty("confidenceScore")]
        public double ConfidenceScore { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }

    public class TextAnalyticsWarning
    {
        [JsonProperty("code")]
        public TextAnalyticsWarningCodeType Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("targetRef")]
        public string TargetRef { get; set; }
    }

    public enum TextAnalyticsWarningCodeType
    {
        LongWordsInDocument,
        DocumentTruncated
    }

    public class DocumentStatistics
    {
        [JsonProperty("charactersCount")]
        public int CharactersCount { get; set; }

        [JsonProperty("transactionsCount")]
        public int TransactionsCount { get; set; }
    }

    public class DocumentError
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class RequestStatistics
    {
        [JsonProperty("documentsCount")]
        public int DocumentsCount { get; set; }

        [JsonProperty("validDocumentsCount")]
        public int ValidDocumentsCount { get; set; }

        [JsonProperty("erroneousDocumentsCount")]
        public int ErroneousDocumentsCount { get; set; }

        [JsonProperty("transactionsCount")]
        public int TransactionsCount { get; set; }
    }

    public class MultiLanguageInputV3
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class EntitiesResultV3
    {
        [JsonProperty("documents")]
        public DocumentEntities[] Documents { get; set; }

        [JsonProperty("errors")]
        public DocumentError[] Errors { get; set; }

        [JsonProperty("statistics")]
        public RequestStatistics Statistics { get; set; }

        [JsonProperty("modelVersion")]
        public string ModelVersion { get; set; }
    }

    public class DocumentEntities
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("entities")]
        public Entity[] Entities { get; set; }

        [JsonProperty("warnings")]
        public TextAnalyticsWarning[] Warnings { get; set; }

        [JsonProperty("statistics")]
        public DocumentStatistics Statistics { get; set; }
    }

    public class Entity
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("confidenceScore")]
        public double ConfidenceScore { get; set; }
    }

    public class KeyPhraseResultV3
    {
        [JsonProperty("documents")]
        public DocumentKeyPhrases[] Documents { get; set; }

        [JsonProperty("errors")]
        public DocumentError[] Errors { get; set; }

        [JsonProperty("statistics")]
        public RequestStatistics Statistics { get; set; }

        [JsonProperty("modelVersion")]
        public string ModelVersion { get; set; }
    }

    public class DocumentKeyPhrases
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("keyPhrases")]
        public string[] KeyPhrases { get; set; }

        [JsonProperty("warnings")]
        public TextAnalyticsWarning[] Warnings { get; set; }

        [JsonProperty("statistics")]
        public DocumentStatistics Statistics { get; set; }
    }

    public class LanguageResultV3
    {
        [JsonProperty("documents")]
        public DocumentLanguage[] Documents { get; set; }

        [JsonProperty("errors")]
        public DocumentError[] Errors { get; set; }

        [JsonProperty("statistics")]
        public RequestStatistics Statistics { get; set; }

        [JsonProperty("modelVersion")]
        public string ModelVersion { get; set; }
    }

    public class DocumentLanguage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("detectedLanguage")]
        public DetectedLanguage DetectedLanguage { get; set; }

        [JsonProperty("warnings")]
        public TextAnalyticsWarning[] Warnings { get; set; }

        [JsonProperty("statistics")]
        public DocumentStatistics Statistics { get; set; }
    }

    public class DetectedLanguage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iso6391Name")]
        public string Iso6391Name { get; set; }

        [JsonProperty("confidenceScore")]
        public double ConfidenceScore { get; set; }
    }

    public class LanguageInputV3
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("countryHint")]
        public string CountryHint { get; set; }
    }

    public class SentimentResponse
    {
        [JsonProperty("documents")]
        public DocumentSentiment[] Documents { get; set; }

        [JsonProperty("errors")]
        public DocumentError[] Errors { get; set; }

        [JsonProperty("statistics")]
        public RequestStatistics Statistics { get; set; }

        [JsonProperty("modelVersion")]
        public string ModelVersion { get; set; }
    }

    public class DocumentSentiment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sentiment")]
        public DocumentSentimentSentimentType Sentiment { get; set; }

        [JsonProperty("statistics")]
        public DocumentStatistics Statistics { get; set; }

        [JsonProperty("confidenceScores")]
        public SentimentConfidenceScorePerLabel ConfidenceScores { get; set; }

        [JsonProperty("sentences")]
        public SentenceSentiment[] Sentences { get; set; }

        [JsonProperty("warnings")]
        public TextAnalyticsWarning[] Warnings { get; set; }
    }

    public enum DocumentSentimentSentimentType
    {
        [EnumMember(Value = "positive")]
        Positive,
        [EnumMember(Value = "neutral")]
        Neutral,
        [EnumMember(Value = "negative")]
        Negative,
        [EnumMember(Value = "mixed")]
        Mixed
    }

    public class SentimentConfidenceScorePerLabel
    {
        [JsonProperty("positive")]
        public double Positive { get; set; }

        [JsonProperty("neutral")]
        public double Neutral { get; set; }

        [JsonProperty("negative")]
        public double Negative { get; set; }
    }

    public class SentenceSentiment
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("sentiment")]
        public SentenceSentimentSentimentType Sentiment { get; set; }

        [JsonProperty("confidenceScores")]
        public SentimentConfidenceScorePerLabel ConfidenceScores { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }

    public enum SentenceSentimentSentimentType
    {
        [EnumMember(Value = "positive")]
        Positive,
        [EnumMember(Value = "neutral")]
        Neutral,
        [EnumMember(Value = "negative")]
        Negative
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicestextanalytics;

    public partial class WorkflowManagedActions
    {
        public CognitiveservicestextanalyticsActions Cognitiveservicestextanalytics(string connectionId) => new CognitiveservicestextanalyticsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitiveservicestextanalyticsTriggers Cognitiveservicestextanalytics(string connectionId) => new CognitiveservicestextanalyticsTriggers(connectionId);
    }
}