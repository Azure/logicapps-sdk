//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lettria
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LettriaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lettria")]
        public IBodyWorkflowAction<ComprehendResponseItem[], ApiConnectionActionConfiguration> Comprehend(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ComprehendResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComprehendResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lettria")]
        public IBodyWorkflowAction<ClassifyResponseItem[], ApiConnectionActionConfiguration> Classify(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassifyResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nls/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassifyResponseItem[]>(callPayload);
            });
        }
    }

    public class LettriaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ComprehendResponseItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("escapeHtml")]
        public bool EscapeHtml { get; set; }

        [JsonProperty("splitNewLine")]
        public bool SplitNewLine { get; set; }

        [JsonProperty("modules")]
        public string[] Modules { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("sentences")]
        public ComprehendResponseItemSentencesTypeItem[] Sentences { get; set; }

        [JsonProperty("emoticon")]
        public ComprehendResponseItemEmoticonType Emoticon { get; set; }

        [JsonProperty("emoticon_data")]
        public string[] EmoticonData { get; set; }

        [JsonProperty("coreference")]
        public ComprehendResponseItemCoreferenceType Coreference { get; set; }

        [JsonProperty("sentiment")]
        public double Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ComprehendResponseItemEmotionTypeItem[] Emotion { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItem
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("sentence_indexes")]
        public int[] SentenceIndexes { get; set; }

        [JsonProperty("detail")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItem[] Detail { get; set; }

        [JsonProperty("subsentences")]
        public ComprehendResponseItemSentencesTypeItemSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("ml_ner")]
        public ComprehendResponseItemSentencesTypeItemMlNerTypeItem[] MlNer { get; set; }

        [JsonProperty("ml_sentiment")]
        public ComprehendResponseItemSentencesTypeItemMlSentimentType MlSentiment { get; set; }

        [JsonProperty("ml_emotion")]
        public ComprehendResponseItemSentencesTypeItemMlEmotionType MlEmotion { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("sentiment")]
        public ComprehendResponseItemSentencesTypeItemSentimentType Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ComprehendResponseItemSentencesTypeItemEmotionType Emotion { get; set; }

        [JsonProperty("sentence_type")]
        public string SentenceType { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItem
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("indexes")]
        public int[] Indexes { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("len")]
        public int Len { get; set; }

        [JsonProperty("lemmatizer")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemLemmatizerType Lemmatizer { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("meaning")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dep")]
        public string Dep { get; set; }

        [JsonProperty("ref")]
        public int Ref { get; set; }

        [JsonProperty("transform")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemTransformType Transform { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("infinit")]
        public string[] Infinit { get; set; }

        [JsonProperty("verb_meaning")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemVerbMeaningType VerbMeaning { get; set; }

        [JsonProperty("auxiliary")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemAuxiliaryType Auxiliary { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemLemmatizerType
    {
        [JsonProperty("sens")]
        public int[] Sens { get; set; }

        [JsonProperty("pronom")]
        public int Pronom { get; set; }

        [JsonProperty("designation")]
        public string[] Designation { get; set; }

        [JsonProperty("possessing")]
        public int Possessing { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("gender")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType Gender { get; set; }

        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }

        [JsonProperty("category")]
        public int[] Category { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType
    {
        [JsonProperty("male")]
        public bool Male { get; set; }

        [JsonProperty("female")]
        public bool Female { get; set; }

        [JsonProperty("plural")]
        public bool Plural { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("temps")]
        public string Temps { get; set; }

        [JsonProperty("pronom")]
        public int Pronom { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemMeaningTypeItem
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("super")]
        public string Super { get; set; }

        [JsonProperty("intensity")]
        public int Intensity { get; set; }

        [JsonProperty("negation")]
        public bool Negation { get; set; }

        [JsonProperty("origin")]
        public string[] Origin { get; set; }

        [JsonProperty("Inclusion_Exclusion|Addition")]
        public int InclusionExclusionAddition { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemTransformType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("meaning")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("extra")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemTransformTypeExtraType Extra { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("super")]
        public string Super { get; set; }

        [JsonProperty("intensity")]
        public int Intensity { get; set; }

        [JsonProperty("negation")]
        public bool Negation { get; set; }

        [JsonProperty("origin")]
        public string[] Origin { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemTransformTypeExtraType
    {
        [JsonProperty("transitif")]
        public bool Transitif { get; set; }

        [JsonProperty("subj")]
        public string Subj { get; set; }

        [JsonProperty("obj")]
        public int Obj { get; set; }

        [JsonProperty("obl")]
        public string Obl { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemVerbMeaningType
    {
        [JsonProperty("know")]
        public int[] Know { get; set; }

        [JsonProperty("say")]
        public int[] Say { get; set; }

        [JsonProperty("look")]
        public int[] Look { get; set; }

        [JsonProperty("be")]
        public int[] Be { get; set; }

        [JsonProperty("force")]
        public int[] Force { get; set; }

        [JsonProperty("fall")]
        public int[] Fall { get; set; }

        [JsonProperty("paus")]
        public int[] Paus { get; set; }

        [JsonProperty("reflect")]
        public int[] Reflect { get; set; }

        [JsonProperty("think")]
        public int[] Think { get; set; }

        [JsonProperty("grapple")]
        public int[] Grapple { get; set; }

        [JsonProperty("unnerve")]
        public int[] Unnerve { get; set; }

        [JsonProperty("crowd")]
        public int[] Crowd { get; set; }

        [JsonProperty("ponder")]
        public int[] Ponder { get; set; }

        [JsonProperty("hang")]
        public int[] Hang { get; set; }

        [JsonProperty("pervad")]
        public int[] Pervad { get; set; }

        [JsonProperty("receive")]
        public int[] Receive { get; set; }

        [JsonProperty("torture")]
        public int[] Torture { get; set; }

        [JsonProperty("have")]
        public int[] Have { get; set; }

        [JsonProperty("modify")]
        public int[] Modify { get; set; }

        [JsonProperty("pass")]
        public int[] Pass { get; set; }

        [JsonProperty("annihilate")]
        public int[] Annihilate { get; set; }

        [JsonProperty("lie")]
        public int[] Lie { get; set; }

        [JsonProperty("find")]
        public int[] Find { get; set; }

        [JsonProperty("rein")]
        public int[] Rein { get; set; }

        [JsonProperty("draw")]
        public int[] Draw { get; set; }

        [JsonProperty("compare")]
        public int[] Compare { get; set; }

        [JsonProperty("gaze")]
        public int[] Gaze { get; set; }

        [JsonProperty("re-modell")]
        public int[] ReModell { get; set; }

        [JsonProperty("invert")]
        public int[] Invert { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemAuxiliaryType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("lemmatizer")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem[][] Lemmatizer { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem
    {
        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ComprehendResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("temps")]
        public string Temps { get; set; }

        [JsonProperty("pronom")]
        public int Pronom { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSubsentencesTypeItem
    {
        [JsonProperty("start_id")]
        public int StartId { get; set; }

        [JsonProperty("end_id")]
        public int EndId { get; set; }

        [JsonProperty("start_indexes")]
        public int StartIndexes { get; set; }

        [JsonProperty("end_indexes")]
        public int EndIndexes { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemMlNerTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemMlSentimentType
    {
        [JsonProperty("sentence")]
        public ComprehendResponseItemSentencesTypeItemMlSentimentTypeSentenceType Sentence { get; set; }

        [JsonProperty("subsentence")]
        public double[] Subsentence { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemMlSentimentTypeSentenceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemMlEmotionType
    {
        [JsonProperty("sentence")]
        public ComprehendResponseItemSentencesTypeItemMlEmotionTypeSentenceTypeItem[] Sentence { get; set; }

        [JsonProperty("subsentence")]
        public ComprehendResponseItemSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem[][] Subsentence { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemMlEmotionTypeSentenceTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentType
    {
        [JsonProperty("subsentences")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeValuesType Values { get; set; }

        [JsonProperty("elements")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItem
    {
        [JsonProperty("start_id")]
        public int StartId { get; set; }

        [JsonProperty("end_id")]
        public int EndId { get; set; }

        [JsonProperty("start_indexes")]
        public int StartIndexes { get; set; }

        [JsonProperty("end_indexes")]
        public int EndIndexes { get; set; }

        [JsonProperty("elements")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType
    {
        [JsonProperty("positive")]
        public double Positive { get; set; }

        [JsonProperty("negative")]
        public int Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeValuesType
    {
        [JsonProperty("positive")]
        public int Positive { get; set; }

        [JsonProperty("negative")]
        public double Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendResponseItemSentencesTypeItemSentimentTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemSentimentTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionType
    {
        [JsonProperty("subsentences")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("elements")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItem
    {
        [JsonProperty("start_id")]
        public int StartId { get; set; }

        [JsonProperty("end_id")]
        public int EndId { get; set; }

        [JsonProperty("start_indexes")]
        public int StartIndexes { get; set; }

        [JsonProperty("end_indexes")]
        public int EndIndexes { get; set; }

        [JsonProperty("elements")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType
    {
        [JsonProperty("nervousness")]
        public int Nervousness { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("disappointment")]
        public int Disappointment { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("realization")]
        public int Realization { get; set; }

        [JsonProperty("sadness")]
        public int Sadness { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }

        [JsonProperty("optimism")]
        public int Optimism { get; set; }

        [JsonProperty("curiosity")]
        public int Curiosity { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType
    {
        [JsonProperty("nervousness")]
        public int Nervousness { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("anger")]
        public int Anger { get; set; }

        [JsonProperty("curiosity")]
        public int Curiosity { get; set; }

        [JsonProperty("disappointment")]
        public int Disappointment { get; set; }

        [JsonProperty("desire")]
        public int Desire { get; set; }

        [JsonProperty("optimism")]
        public int Optimism { get; set; }

        [JsonProperty("realization")]
        public int Realization { get; set; }

        [JsonProperty("grief")]
        public int Grief { get; set; }

        [JsonProperty("remorse")]
        public int Remorse { get; set; }

        [JsonProperty("sadness")]
        public int Sadness { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeValuesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItemValueType Value { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendResponseItemSentencesTypeItemEmotionTypeElementsTypeItemValueType
    {
        [JsonProperty("nervousness")]
        public int Nervousness { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("disappointment")]
        public int Disappointment { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("realization")]
        public int Realization { get; set; }

        [JsonProperty("sadness")]
        public int Sadness { get; set; }

        [JsonProperty("curiosity")]
        public int Curiosity { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }

        [JsonProperty("optimism")]
        public int Optimism { get; set; }
    }

    public class ComprehendResponseItemEmoticonType
    {
        [JsonProperty("happy")]
        public int Happy { get; set; }

        [JsonProperty("very_happy")]
        public int VeryHappy { get; set; }

        [JsonProperty("laugh")]
        public int Laugh { get; set; }

        [JsonProperty("sad")]
        public int Sad { get; set; }

        [JsonProperty("very_sad")]
        public int VerySad { get; set; }

        [JsonProperty("lol")]
        public int Lol { get; set; }

        [JsonProperty("cry")]
        public int Cry { get; set; }

        [JsonProperty("horror")]
        public int Horror { get; set; }

        [JsonProperty("surprise")]
        public int Surprise { get; set; }

        [JsonProperty("kiss")]
        public int Kiss { get; set; }

        [JsonProperty("wink")]
        public int Wink { get; set; }

        [JsonProperty("playful")]
        public int Playful { get; set; }

        [JsonProperty("hesitant")]
        public int Hesitant { get; set; }

        [JsonProperty("indecision")]
        public int Indecision { get; set; }

        [JsonProperty("embarrassed")]
        public int Embarrassed { get; set; }

        [JsonProperty("muted")]
        public int Muted { get; set; }

        [JsonProperty("angel")]
        public int Angel { get; set; }

        [JsonProperty("devil")]
        public int Devil { get; set; }

        [JsonProperty("love")]
        public int Love { get; set; }

        [JsonProperty("notlove")]
        public int Notlove { get; set; }
    }

    public class ComprehendResponseItemCoreferenceType
    {
        [JsonProperty("spans")]
        public ComprehendResponseItemCoreferenceTypeSpansTypeItem[] Spans { get; set; }

        [JsonProperty("clusters")]
        public int[][] Clusters { get; set; }
    }

    public class ComprehendResponseItemCoreferenceTypeSpansTypeItem
    {
        [JsonProperty("sentence_index")]
        public int SentenceIndex { get; set; }

        [JsonProperty("token_indexes")]
        public int[] TokenIndexes { get; set; }

        [JsonProperty("cluster_index")]
        public int ClusterIndex { get; set; }
    }

    public class ComprehendResponseItemEmotionTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("documents")]
        public string[] Documents { get; set; }
    }

    public class ClassifyResponseItem
    {
        [JsonProperty("metadata")]
        public ClassifyResponseItemMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("nlc")]
        public ClassifyResponseItemNlcType Nlc { get; set; }
    }

    public class ClassifyResponseItemMetadataType
    {
        [JsonProperty("train_name")]
        public string TrainName { get; set; }

        [JsonProperty("train_date")]
        public string TrainDate { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }

    public class ClassifyResponseItemNlcType
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("escapeHtml")]
        public bool EscapeHtml { get; set; }

        [JsonProperty("splitNewLine")]
        public bool SplitNewLine { get; set; }

        [JsonProperty("modules")]
        public string[] Modules { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sentences")]
        public ClassifyResponseItemNlcTypeSentencesTypeItem[] Sentences { get; set; }

        [JsonProperty("emoticon")]
        public ClassifyResponseItemNlcTypeEmoticonType Emoticon { get; set; }

        [JsonProperty("emoticon_data")]
        public string[] EmoticonData { get; set; }

        [JsonProperty("coreference")]
        public ClassifyResponseItemNlcTypeCoreferenceType Coreference { get; set; }

        [JsonProperty("sentiment")]
        public double Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ClassifyResponseItemNlcTypeEmotionTypeItem[] Emotion { get; set; }
        public ClassifyResponseItemNlcTypePerfsType Perfs { get; set; }

        [JsonProperty("patterns")]
        public string Patterns { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItem
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("sentence_indexes")]
        public int[] SentenceIndexes { get; set; }

        [JsonProperty("detail")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItem[] Detail { get; set; }

        [JsonProperty("subsentences")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("ml_ner")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemMlNerTypeItem[] MlNer { get; set; }

        [JsonProperty("ml_sentiment")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemMlSentimentType MlSentiment { get; set; }

        [JsonProperty("ml_emotion")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemMlEmotionType MlEmotion { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("sentiment")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentType Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionType Emotion { get; set; }

        [JsonProperty("sentence_type")]
        public string SentenceType { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItem
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("indexes")]
        public int[] Indexes { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("len")]
        public int Len { get; set; }

        [JsonProperty("lemmatizer")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerType Lemmatizer { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("meaning")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dep")]
        public string Dep { get; set; }

        [JsonProperty("ref")]
        public int Ref { get; set; }

        [JsonProperty("transform")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformType Transform { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("infinit")]
        public int[] Infinit { get; set; }

        [JsonProperty("verb_meaning")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemVerbMeaningType VerbMeaning { get; set; }

        [JsonProperty("auxiliary")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryType Auxiliary { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerType
    {
        [JsonProperty("sens")]
        public string[] Sens { get; set; }

        [JsonProperty("pronom")]
        public int Pronom { get; set; }

        [JsonProperty("designation")]
        public string[] Designation { get; set; }

        [JsonProperty("possessing")]
        public int Possessing { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("gender")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType Gender { get; set; }

        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType
    {
        [JsonProperty("male")]
        public bool Male { get; set; }

        [JsonProperty("female")]
        public bool Female { get; set; }

        [JsonProperty("plural")]
        public bool Plural { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("temps")]
        public string Temps { get; set; }

        [JsonProperty("pronom")]
        public int Pronom { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemMeaningTypeItem
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("super")]
        public string Super { get; set; }

        [JsonProperty("intensity")]
        public int Intensity { get; set; }

        [JsonProperty("negation")]
        public bool Negation { get; set; }

        [JsonProperty("origin")]
        public string[] Origin { get; set; }

        [JsonProperty("Inclusion_Exclusion|Addition")]
        public int InclusionExclusionAddition { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("meaning")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("extra")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeExtraType Extra { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("super")]
        public string Super { get; set; }

        [JsonProperty("intensity")]
        public int Intensity { get; set; }

        [JsonProperty("negation")]
        public bool Negation { get; set; }

        [JsonProperty("origin")]
        public string[] Origin { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeExtraType
    {
        [JsonProperty("transitif")]
        public bool Transitif { get; set; }

        [JsonProperty("subj")]
        public string Subj { get; set; }

        [JsonProperty("obj")]
        public int Obj { get; set; }

        [JsonProperty("obl")]
        public string Obl { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemVerbMeaningType
    {
        [JsonProperty("know")]
        public string[] Know { get; set; }

        [JsonProperty("say")]
        public string[] Say { get; set; }

        [JsonProperty("look")]
        public string[] Look { get; set; }

        [JsonProperty("be")]
        public string[] Be { get; set; }

        [JsonProperty("force")]
        public string[] Force { get; set; }

        [JsonProperty("fall")]
        public string[] Fall { get; set; }

        [JsonProperty("paus")]
        public string[] Paus { get; set; }

        [JsonProperty("reflect")]
        public string[] Reflect { get; set; }

        [JsonProperty("think")]
        public string[] Think { get; set; }

        [JsonProperty("grapple")]
        public string[] Grapple { get; set; }

        [JsonProperty("unnerve")]
        public string[] Unnerve { get; set; }

        [JsonProperty("crowd")]
        public string[] Crowd { get; set; }

        [JsonProperty("ponder")]
        public string[] Ponder { get; set; }

        [JsonProperty("hang")]
        public string[] Hang { get; set; }

        [JsonProperty("pervad")]
        public string[] Pervad { get; set; }

        [JsonProperty("receive")]
        public string[] Receive { get; set; }

        [JsonProperty("torture")]
        public string[] Torture { get; set; }

        [JsonProperty("have")]
        public string[] Have { get; set; }

        [JsonProperty("modify")]
        public string[] Modify { get; set; }

        [JsonProperty("pass")]
        public string[] Pass { get; set; }

        [JsonProperty("annihilate")]
        public string[] Annihilate { get; set; }

        [JsonProperty("lie")]
        public string[] Lie { get; set; }

        [JsonProperty("find")]
        public string[] Find { get; set; }

        [JsonProperty("rein")]
        public string[] Rein { get; set; }

        [JsonProperty("draw")]
        public string[] Draw { get; set; }

        [JsonProperty("compare")]
        public string[] Compare { get; set; }

        [JsonProperty("lay")]
        public string[] Lay { get; set; }

        [JsonProperty("gaze")]
        public string[] Gaze { get; set; }

        [JsonProperty("re-modell")]
        public string[] ReModell { get; set; }

        [JsonProperty("invert")]
        public string[] Invert { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("lemmatizer")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem[][] Lemmatizer { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem
    {
        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("temps")]
        public string Temps { get; set; }

        [JsonProperty("pronom")]
        public int Pronom { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSubsentencesTypeItem
    {
        [JsonProperty("start_id")]
        public int StartId { get; set; }

        [JsonProperty("end_id")]
        public int EndId { get; set; }

        [JsonProperty("start_indexes")]
        public int StartIndexes { get; set; }

        [JsonProperty("end_indexes")]
        public int EndIndexes { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemMlNerTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemMlSentimentType
    {
        [JsonProperty("sentence")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemMlSentimentTypeSentenceType Sentence { get; set; }

        [JsonProperty("subsentence")]
        public double[] Subsentence { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemMlSentimentTypeSentenceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemMlEmotionType
    {
        [JsonProperty("sentence")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSentenceTypeItem[] Sentence { get; set; }

        [JsonProperty("subsentence")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem[][] Subsentence { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSentenceTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentType
    {
        [JsonProperty("subsentences")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeValuesType Values { get; set; }

        [JsonProperty("elements")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItem
    {
        [JsonProperty("start_id")]
        public int StartId { get; set; }

        [JsonProperty("end_id")]
        public int EndId { get; set; }

        [JsonProperty("start_indexes")]
        public int StartIndexes { get; set; }

        [JsonProperty("end_indexes")]
        public int EndIndexes { get; set; }

        [JsonProperty("elements")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType
    {
        [JsonProperty("positive")]
        public double Positive { get; set; }

        [JsonProperty("negative")]
        public int Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeValuesType
    {
        [JsonProperty("positive")]
        public int Positive { get; set; }

        [JsonProperty("negative")]
        public double Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionType
    {
        [JsonProperty("subsentences")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("elements")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItem
    {
        [JsonProperty("start_id")]
        public int StartId { get; set; }

        [JsonProperty("end_id")]
        public int EndId { get; set; }

        [JsonProperty("start_indexes")]
        public int StartIndexes { get; set; }

        [JsonProperty("end_indexes")]
        public int EndIndexes { get; set; }

        [JsonProperty("elements")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType
    {
        [JsonProperty("nervousness")]
        public int Nervousness { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("disappointment")]
        public int Disappointment { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("realization")]
        public int Realization { get; set; }

        [JsonProperty("sadness")]
        public int Sadness { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }

        [JsonProperty("optimism")]
        public int Optimism { get; set; }

        [JsonProperty("curiosity")]
        public int Curiosity { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType
    {
        [JsonProperty("nervousness")]
        public int Nervousness { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("anger")]
        public int Anger { get; set; }

        [JsonProperty("curiosity")]
        public int Curiosity { get; set; }

        [JsonProperty("disappointment")]
        public int Disappointment { get; set; }

        [JsonProperty("desire")]
        public int Desire { get; set; }

        [JsonProperty("optimism")]
        public int Optimism { get; set; }

        [JsonProperty("realization")]
        public int Realization { get; set; }

        [JsonProperty("grief")]
        public int Grief { get; set; }

        [JsonProperty("remorse")]
        public int Remorse { get; set; }

        [JsonProperty("sadness")]
        public int Sadness { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeValuesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemValueType Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemValueType
    {
        [JsonProperty("nervousness")]
        public int Nervousness { get; set; }

        [JsonProperty("neutral")]
        public int Neutral { get; set; }

        [JsonProperty("confusion")]
        public int Confusion { get; set; }

        [JsonProperty("disappointment")]
        public int Disappointment { get; set; }

        [JsonProperty("fear")]
        public int Fear { get; set; }

        [JsonProperty("realization")]
        public int Realization { get; set; }

        [JsonProperty("sadness")]
        public int Sadness { get; set; }

        [JsonProperty("curiosity")]
        public int Curiosity { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }

        [JsonProperty("optimism")]
        public int Optimism { get; set; }
    }

    public class ClassifyResponseItemNlcTypeEmoticonType
    {
        [JsonProperty("happy")]
        public int Happy { get; set; }

        [JsonProperty("very_happy")]
        public int VeryHappy { get; set; }

        [JsonProperty("laugh")]
        public int Laugh { get; set; }

        [JsonProperty("sad")]
        public int Sad { get; set; }

        [JsonProperty("very_sad")]
        public int VerySad { get; set; }

        [JsonProperty("lol")]
        public int Lol { get; set; }

        [JsonProperty("cry")]
        public int Cry { get; set; }

        [JsonProperty("horror")]
        public int Horror { get; set; }

        [JsonProperty("surprise")]
        public int Surprise { get; set; }

        [JsonProperty("kiss")]
        public int Kiss { get; set; }

        [JsonProperty("wink")]
        public int Wink { get; set; }

        [JsonProperty("playful")]
        public int Playful { get; set; }

        [JsonProperty("hesitant")]
        public int Hesitant { get; set; }

        [JsonProperty("indecision")]
        public int Indecision { get; set; }

        [JsonProperty("embarrassed")]
        public int Embarrassed { get; set; }

        [JsonProperty("muted")]
        public int Muted { get; set; }

        [JsonProperty("angel")]
        public int Angel { get; set; }

        [JsonProperty("devil")]
        public int Devil { get; set; }

        [JsonProperty("love")]
        public int Love { get; set; }

        [JsonProperty("notlove")]
        public int Notlove { get; set; }
    }

    public class ClassifyResponseItemNlcTypeCoreferenceType
    {
        [JsonProperty("spans")]
        public ClassifyResponseItemNlcTypeCoreferenceTypeSpansTypeItem[] Spans { get; set; }

        [JsonProperty("clusters")]
        public int[][] Clusters { get; set; }
    }

    public class ClassifyResponseItemNlcTypeCoreferenceTypeSpansTypeItem
    {
        [JsonProperty("sentence_index")]
        public int SentenceIndex { get; set; }

        [JsonProperty("token_indexes")]
        public int[] TokenIndexes { get; set; }

        [JsonProperty("cluster_index")]
        public int ClusterIndex { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }
    }

    public class ClassifyResponseItemNlcTypeEmotionTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyResponseItemNlcTypePerfsType
    {
        [JsonProperty("api_call")]
        public int ApiCall { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lettria;

    public partial class WorkflowManagedActions
    {
        public LettriaActions Lettria(string connectionId) => new LettriaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LettriaTriggers Lettria(string connectionId) => new LettriaTriggers(connectionId);
    }
}