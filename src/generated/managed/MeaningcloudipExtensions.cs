//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Meaningcloudip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeaningcloudipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildSentimentAnalysis))]
        public IBodyWorkflowAction<SentimentAnalysisResponse> SentimentAnalysis([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<ofInput> of = null, [WorkflowExpression] Func<txtfInput> txtf = null, [WorkflowExpression] Func<string> model = null, [WorkflowExpression] Func<verboseInput> verbose = null, [WorkflowExpression] Func<uwInput> uw = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SentimentAnalysisResponse> __BuildSentimentAnalysis(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<string> lang, WorkflowExpression<ofInput> of = null, WorkflowExpression<txtfInput> txtf = null, WorkflowExpression<string> model = null, WorkflowExpression<verboseInput> verbose = null, WorkflowExpression<uwInput> uw = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(of, nameof(of), required: false);
            WorkflowExpression.Validate(txtf, nameof(txtf), required: false);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            WorkflowExpression.Validate(verbose, nameof(verbose), required: false);
            WorkflowExpression.Validate(uw, nameof(uw), required: false);
            return new DeferredBodyAction<SentimentAnalysisResponse>(() =>
            {
                var apiCallPath = "/sentiment-2.1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SentimentAnalysisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildTextClassification))]
        public IBodyWorkflowAction<TextClassificationResponse> TextClassification([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<modelInput> model, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<debugInput> debug = null, [WorkflowExpression] Func<verboseInput> verbose = null, [WorkflowExpression] Func<expandHierarchyInput> expandHierarchy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextClassificationResponse> __BuildTextClassification(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<modelInput> model, WorkflowExpression<string> title = null, WorkflowExpression<debugInput> debug = null, WorkflowExpression<verboseInput> verbose = null, WorkflowExpression<expandHierarchyInput> expandHierarchy = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(debug, nameof(debug), required: false);
            WorkflowExpression.Validate(verbose, nameof(verbose), required: false);
            WorkflowExpression.Validate(expandHierarchy, nameof(expandHierarchy), required: false);
            return new DeferredBodyAction<TextClassificationResponse>(() =>
            {
                var apiCallPath = "/class-2.0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TextClassificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildCorporateReputation))]
        public IBodyWorkflowAction<CorporateReputationResponse> CorporateReputation([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> model = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CorporateReputationResponse> __BuildCorporateReputation(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<string> lang, WorkflowExpression<string> model = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            return new DeferredBodyAction<CorporateReputationResponse>(() =>
            {
                var apiCallPath = "/reputation-2.0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CorporateReputationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildSummarization))]
        public IBodyWorkflowAction<SummarizationResponse> Summarization([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<int> sentences = null, [WorkflowExpression] Func<ofInput> of = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SummarizationResponse> __BuildSummarization(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<string> lang, WorkflowExpression<int> sentences = null, WorkflowExpression<ofInput> of = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(sentences, nameof(sentences), required: false);
            WorkflowExpression.Validate(of, nameof(of), required: false);
            return new DeferredBodyAction<SummarizationResponse>(() =>
            {
                var apiCallPath = "/summarization-1.0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SummarizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildDeepCategorization))]
        public IBodyWorkflowAction<DeepCategorizationResponse> DeepCategorization([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<modelInput> model, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<ofInput> of = null, [WorkflowExpression] Func<debugInput> debug = null, [WorkflowExpression] Func<verboseInput> verbose = null, [WorkflowExpression] Func<polarityInput> polarity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeepCategorizationResponse> __BuildDeepCategorization(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<modelInput> model, WorkflowExpression<string> title = null, WorkflowExpression<ofInput> of = null, WorkflowExpression<debugInput> debug = null, WorkflowExpression<verboseInput> verbose = null, WorkflowExpression<polarityInput> polarity = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(of, nameof(of), required: false);
            WorkflowExpression.Validate(debug, nameof(debug), required: false);
            WorkflowExpression.Validate(verbose, nameof(verbose), required: false);
            WorkflowExpression.Validate(polarity, nameof(polarity), required: false);
            return new DeferredBodyAction<DeepCategorizationResponse>(() =>
            {
                var apiCallPath = "/deepcategorization-1.0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeepCategorizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageIdentification))]
        public IBodyWorkflowAction<LanguageIdentificationResponse> LanguageIdentification([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageIdentificationResponse> __BuildLanguageIdentification(WorkflowExpression<string> key, WorkflowExpression<string> txt)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            return new DeferredBodyAction<LanguageIdentificationResponse>(() =>
            {
                var apiCallPath = "/lang-4.0/identification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LanguageIdentificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildTextClustering))]
        public IBodyWorkflowAction<TextClusteringResponse> TextClustering([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<langInput> lang, [WorkflowExpression] Func<ofInput> of = null, [WorkflowExpression] Func<modeInput> mode = null, [WorkflowExpression] Func<swInput> sw = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextClusteringResponse> __BuildTextClustering(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<langInput> lang, WorkflowExpression<ofInput> of = null, WorkflowExpression<modeInput> mode = null, WorkflowExpression<swInput> sw = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(of, nameof(of), required: false);
            WorkflowExpression.Validate(mode, nameof(mode), required: false);
            WorkflowExpression.Validate(sw, nameof(sw), required: false);
            return new DeferredBodyAction<TextClusteringResponse>(() =>
            {
                var apiCallPath = "/clustering-1.1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TextClusteringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentStructure))]
        public IBodyWorkflowAction<DocumentStructureResponse> DocumentStructure([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> txt, [WorkflowExpression] Func<ofInput> of = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentStructureResponse> __BuildDocumentStructure(WorkflowExpression<string> key, WorkflowExpression<string> txt, WorkflowExpression<ofInput> of = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(txt, nameof(txt), required: true);
            WorkflowExpression.Validate(of, nameof(of), required: false);
            return new DeferredBodyAction<DocumentStructureResponse>(() =>
            {
                var apiCallPath = "/documentstructure-1.0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentStructureResponse>(callPayload);
            });
        }
    }

    public class MeaningcloudipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SentimentAnalysisResponse
    {
        [JsonProperty("agreement")]
        public string Agreement { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("irony")]
        public string Irony { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("score_tag")]
        public string ScoreTag { get; set; }

        [JsonProperty("sentence_list")]
        public SentimentAnalysisResponseSentenceListTypeItem[] SentenceList { get; set; }

        [JsonProperty("sentimented_concept_list")]
        public SentimentConceptListResponse[] SentimentedConceptList { get; set; }

        [JsonProperty("sentimented_entity_list")]
        public SentimentConceptListResponse[] SentimentedEntityList { get; set; }

        [JsonProperty("status")]
        public SentimentAnalysisResponseStatusType Status { get; set; }

        [JsonProperty("subjectivity")]
        public string Subjectivity { get; set; }
    }

    public class SentimentAnalysisResponseSentenceListTypeItem
    {
        [JsonProperty("agreement")]
        public string Agreement { get; set; }

        [JsonProperty("bop")]
        public string Bop { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("endp")]
        public string Endp { get; set; }

        [JsonProperty("inip")]
        public string Inip { get; set; }

        [JsonProperty("score_tag")]
        public string ScoreTag { get; set; }

        [JsonProperty("segment_list")]
        public SentimentAnalysisResponseSentenceListTypeItemSegmentListTypeItem[] SegmentList { get; set; }

        [JsonProperty("sentimented_concept_list")]
        public SentimentConceptListResponse[] SentimentedConceptList { get; set; }

        [JsonProperty("sentimented_entity_list")]
        public SentimentConceptListResponse[] SentimentedEntityList { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SentimentAnalysisResponseSentenceListTypeItemSegmentListTypeItem
    {
        [JsonProperty("agreement")]
        public string Agreement { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("endp")]
        public string Endp { get; set; }

        [JsonProperty("inip")]
        public string Inip { get; set; }

        [JsonProperty("polarity_term_list")]
        public SentimentAnalysisResponseSentenceListTypeItemSegmentListTypeItemPolarityTermListTypeItem[] PolarityTermList { get; set; }

        [JsonProperty("score_tag")]
        public string ScoreTag { get; set; }

        [JsonProperty("segment_type")]
        public string SegmentType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SentimentAnalysisResponseSentenceListTypeItemSegmentListTypeItemPolarityTermListTypeItem
    {
        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("endp")]
        public string Endp { get; set; }

        [JsonProperty("inip")]
        public string Inip { get; set; }

        [JsonProperty("score_tag")]
        public string ScoreTag { get; set; }

        [JsonProperty("sentimented_concept_list")]
        public SentimentConceptListResponse[] SentimentedConceptList { get; set; }

        [JsonProperty("tag_stack")]
        public string TagStack { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SentimentConceptListResponse
    {
        [JsonProperty("endp")]
        public string Endp { get; set; }

        [JsonProperty("inip")]
        public string Inip { get; set; }

        [JsonProperty("score_tag")]
        public string ScoreTag { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }
    }

    public class SentimentAnalysisResponseStatusType
    {
        [JsonProperty("code")]
        public string StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public string RemainingCredits { get; set; }
    }

    public enum ofInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public enum txtfInput
    {
        [EnumMember(Value = "plain")]
        Plain,
        [EnumMember(Value = "markup")]
        Markup
    }

    public enum verboseInput
    {
        [EnumMember(Value = "y")]
        Y,
        [EnumMember(Value = "n")]
        N
    }

    public enum uwInput
    {
        [EnumMember(Value = "y")]
        Y,
        [EnumMember(Value = "n")]
        N
    }

    public class TextClassificationResponse
    {
        [JsonProperty("category_list")]
        public TextClassificationResponseCategoryListTypeItem[] CategoryList { get; set; }

        [JsonProperty("status")]
        public TextClassificationResponseStatusType Status { get; set; }
    }

    public class TextClassificationResponseCategoryListTypeItem
    {
        [JsonProperty("abs_relevance")]
        public string AbsRelevance { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("relevance")]
        public string Relevance { get; set; }
    }

    public class TextClassificationResponseStatusType
    {
        [JsonProperty("code")]
        public string StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public string RemainingCredits { get; set; }
    }

    public enum modelInput
    {
        [EnumMember(Value = "IAB_2.0")]
        IAB20,
        [EnumMember(Value = "IAB_2.0-tier3")]
        IAB20Tier3,
        [EnumMember(Value = "IAB_2.0-tier4")]
        IAB20Tier4,
        Emotion,
        IntentionAnalysis,
        [EnumMember(Value = "VoC-Generic")]
        VoCGeneric,
        [EnumMember(Value = "VoC-Banking")]
        VoCBanking,
        [EnumMember(Value = "VoC-Insurance")]
        VoCInsurance,
        [EnumMember(Value = "VoC-Retail")]
        VoCRetail,
        [EnumMember(Value = "VoC-Telco")]
        VoCTelco,
        [EnumMember(Value = "VoE-Performance")]
        VoEPerformance,
        [EnumMember(Value = "VoE-Organization")]
        VoEOrganization,
        [EnumMember(Value = "VoE-ExitInterview")]
        VoEExitInterview
    }

    public enum debugInput
    {
        [EnumMember(Value = "y")]
        Y,
        [EnumMember(Value = "n")]
        N
    }

    public enum expandHierarchyInput
    {
        [EnumMember(Value = "n")]
        N,
        [EnumMember(Value = "p")]
        P,
        [EnumMember(Value = "a")]
        A
    }

    public class CorporateReputationResponse
    {
        [JsonProperty("status")]
        public CorporateReputationResponseStatusType Status { get; set; }

        [JsonProperty("entity_list")]
        public CorporateReputationResponseEntityListTypeItem[] EntityList { get; set; }
    }

    public class CorporateReputationResponseStatusType
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public int RemainingCredits { get; set; }
    }

    public class CorporateReputationResponseEntityListTypeItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("polarity")]
        public string Polarity { get; set; }

        [JsonProperty("category_list")]
        public CorporateReputationResponseEntityListTypeItemCategoryListTypeItem[] CategoryList { get; set; }
    }

    public class CorporateReputationResponseEntityListTypeItemCategoryListTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("polarity")]
        public string Polarity { get; set; }

        [JsonProperty("abs_relevance")]
        public int AbsoluteRelevance { get; set; }

        [JsonProperty("relat_relevance")]
        public int RelativeRelevance { get; set; }

        [JsonProperty("sentence_list")]
        public CorporateReputationResponseEntityListTypeItemCategoryListTypeItemSentenceListTypeItem[] SentenceList { get; set; }
    }

    public class CorporateReputationResponseEntityListTypeItemCategoryListTypeItemSentenceListTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("inip")]
        public string Inip { get; set; }

        [JsonProperty("endp")]
        public string Endp { get; set; }
    }

    public class SummarizationResponse
    {
        [JsonProperty("status")]
        public SummarizationResponseStatusType Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class SummarizationResponseStatusType
    {
        [JsonProperty("code")]
        public string StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public string RemainingCredits { get; set; }
    }

    public class DeepCategorizationResponse
    {
        [JsonProperty("status")]
        public DeepCategorizationResponseStatusType Status { get; set; }

        [JsonProperty("category_list")]
        public DeepCategorizationResponseCategoryListTypeItem[] CategoryList { get; set; }
    }

    public class DeepCategorizationResponseStatusType
    {
        [JsonProperty("code")]
        public string StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public string RemainingCredits { get; set; }
    }

    public class DeepCategorizationResponseCategoryListTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("abs_relevance")]
        public string AbsoluteRelevance { get; set; }

        [JsonProperty("relevance")]
        public string Relevance { get; set; }
    }

    public enum polarityInput
    {
        [EnumMember(Value = "y")]
        Y,
        [EnumMember(Value = "n")]
        N
    }

    public class LanguageIdentificationResponse
    {
        [JsonProperty("status")]
        public LanguageIdentificationResponseStatusType Status { get; set; }

        [JsonProperty("language_list")]
        public LanguageIdentificationResponseLanguageListTypeItem[] LanguageList { get; set; }

        [JsonProperty("deepTime")]
        public double DeepTime { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }
    }

    public class LanguageIdentificationResponseStatusType
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public int RemainingCredits { get; set; }
    }

    public class LanguageIdentificationResponseLanguageListTypeItem
    {
        [JsonProperty("iso-639-1")]
        public string ISO6391 { get; set; }

        [JsonProperty("iso-639-2")]
        public string ISO6392 { get; set; }

        [JsonProperty("iso-639-3")]
        public string ISO6393 { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("relevance")]
        public int Relevance { get; set; }
    }

    public class TextClusteringResponse
    {
        [JsonProperty("status")]
        public TextClusteringResponseStatusType Status { get; set; }

        [JsonProperty("cluster_list")]
        public TextClusteringResponseClusterListTypeItem[] ClusterList { get; set; }
    }

    public class TextClusteringResponseStatusType
    {
        [JsonProperty("code")]
        public string StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public string RemainingCredits { get; set; }
    }

    public class TextClusteringResponseClusterListTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("document_list")]
        public TextClusteringResponseClusterListTypeItemDocumentListType DocumentList { get; set; }
    }

    public class TextClusteringResponseClusterListTypeItemDocumentListType
    {
        [JsonProperty("1")]
        public string Document1 { get; set; }

        [JsonProperty("2")]
        public string Document2 { get; set; }

        [JsonProperty("3")]
        public string Document3 { get; set; }

        [JsonProperty("4")]
        public string Document4 { get; set; }

        [JsonProperty("5")]
        public string Document5 { get; set; }

        [JsonProperty("6")]
        public string Document6 { get; set; }

        [JsonProperty("7")]
        public string Document7 { get; set; }

        [JsonProperty("8")]
        public string Document8 { get; set; }

        [JsonProperty("9")]
        public string Document9 { get; set; }

        [JsonProperty("10")]
        public string Document10 { get; set; }
    }

    public enum langInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "zh")]
        Zh,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "ar")]
        Ar
    }

    public enum modeInput
    {
        [EnumMember(Value = "tm")]
        Tm,
        [EnumMember(Value = "dg")]
        Dg
    }

    public enum swInput
    {
        [EnumMember(Value = "y")]
        Y,
        [EnumMember(Value = "n")]
        N
    }

    public class DocumentStructureResponse
    {
        [JsonProperty("status")]
        public DocumentStructureResponseStatusType Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("abstract_list")]
        public JToken[] AbstractList { get; set; }

        [JsonProperty("heading_list")]
        public string[] HeadingList { get; set; }

        [JsonProperty("emails_info")]
        public DocumentStructureResponseEmailsInfoType EmailsInfo { get; set; }
    }

    public class DocumentStructureResponseStatusType
    {
        [JsonProperty("code")]
        public string StatusCode { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("credits")]
        public string Credits { get; set; }

        [JsonProperty("remaining_credits")]
        public string RemainingCredits { get; set; }
    }

    public class DocumentStructureResponseEmailsInfoType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public JToken[] To { get; set; }

        [JsonProperty("cc")]
        public JToken[] CC { get; set; }

        [JsonProperty("subject")]
        public JToken[] Subject { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Meaningcloudip;

    public partial class WorkflowManagedActions
    {
        public MeaningcloudipActions Meaningcloudip(string connectionId) => new MeaningcloudipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MeaningcloudipTriggers Meaningcloudip(string connectionId) => new MeaningcloudipTriggers(connectionId);
    }
}