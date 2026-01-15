//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Meaningcloudip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MeaningcloudipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<SentimentAnalysisResponse> SentimentAnalysis(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<string>> lang, Expression<Func<ofInput>> of = null, Expression<Func<txtfInput>> txtf = null, Expression<Func<string>> model = null, Expression<Func<verboseInput>> verbose = null, Expression<Func<uwInput>> uw = null)
        {
            var apiCallPath = "/sentiment-2.1";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SentimentAnalysisResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<TextClassificationResponse> TextClassification(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<modelInput>> model, Expression<Func<string>> title = null, Expression<Func<debugInput>> debug = null, Expression<Func<verboseInput>> verbose = null, Expression<Func<expandHierarchyInput>> expandHierarchy = null)
        {
            var apiCallPath = "/class-2.0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextClassificationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<CorporateReputationResponse> CorporateReputation(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<string>> lang, Expression<Func<string>> model = null)
        {
            var apiCallPath = "/reputation-2.0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CorporateReputationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<SummarizationResponse> Summarization(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<string>> lang, Expression<Func<int>> sentences = null, Expression<Func<ofInput>> of = null)
        {
            var apiCallPath = "/summarization-1.0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SummarizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<DeepCategorizationResponse> DeepCategorization(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<modelInput>> model, Expression<Func<string>> title = null, Expression<Func<ofInput>> of = null, Expression<Func<debugInput>> debug = null, Expression<Func<verboseInput>> verbose = null, Expression<Func<polarityInput>> polarity = null)
        {
            var apiCallPath = "/deepcategorization-1.0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeepCategorizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<LanguageIdentificationResponse> LanguageIdentification(Expression<Func<string>> key, Expression<Func<string>> txt)
        {
            var apiCallPath = "/lang-4.0/identification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LanguageIdentificationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<TextClusteringResponse> TextClustering(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<langInput>> lang, Expression<Func<ofInput>> of = null, Expression<Func<modeInput>> mode = null, Expression<Func<swInput>> sw = null)
        {
            var apiCallPath = "/clustering-1.1";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextClusteringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "meaningcloudip")]
        public IBodyWorkflowAction<DocumentStructureResponse> DocumentStructure(Expression<Func<string>> key, Expression<Func<string>> txt, Expression<Func<ofInput>> of = null)
        {
            var apiCallPath = "/documentstructure-1.0";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentStructureResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Meaningcloudip;

    public partial class WorkflowManagedActions
    {
        public MeaningcloudipActions Meaningcloudip(string connectionId) => new MeaningcloudipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MeaningcloudipTriggers Meaningcloudip(string connectionId) => new MeaningcloudipTriggers(connectionId);
    }
}