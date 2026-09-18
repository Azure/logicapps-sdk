//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lettria
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LettriaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lettria")]
        public IBodyWorkflowAction<ComprehendPostResponseItem[]> Comprehend([WorkflowExpression] Func<string[]> bodydocuments = null)
        {
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocuments != null)
                {
                    body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ComprehendPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lettria")]
        public IBodyWorkflowAction<ClassifyPostResponseItem[]> Classify([WorkflowExpression] Func<string[]> bodydocuments = null)
        {
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nls/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocuments != null)
                {
                    body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClassifyPostResponseItem[]>(BuildSourceInput);
        }
    }

    public class LettriaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ComprehendPostResponseItem
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
        public ComprehendPostResponseItemSentencesTypeItem[] Sentences { get; set; }

        [JsonProperty("emoticon")]
        public ComprehendPostResponseItemEmoticonType Emoticon { get; set; }

        [JsonProperty("emoticon_data")]
        public string[] EmoticonData { get; set; }

        [JsonProperty("coreference")]
        public ComprehendPostResponseItemCoreferenceType Coreference { get; set; }

        [JsonProperty("sentiment")]
        public double Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ComprehendPostResponseItemEmotionTypeItem[] Emotion { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItem
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("sentence_indexes")]
        public int[] SentenceIndexes { get; set; }

        [JsonProperty("detail")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItem[] Detail { get; set; }

        [JsonProperty("subsentences")]
        public ComprehendPostResponseItemSentencesTypeItemSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("ml_ner")]
        public ComprehendPostResponseItemSentencesTypeItemMlNerTypeItem[] MlNer { get; set; }

        [JsonProperty("ml_sentiment")]
        public ComprehendPostResponseItemSentencesTypeItemMlSentimentType MlSentiment { get; set; }

        [JsonProperty("ml_emotion")]
        public ComprehendPostResponseItemSentencesTypeItemMlEmotionType MlEmotion { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("sentiment")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentType Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionType Emotion { get; set; }

        [JsonProperty("sentence_type")]
        public string SentenceType { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItem
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
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemLemmatizerType Lemmatizer { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("meaning")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dep")]
        public string Dep { get; set; }

        [JsonProperty("ref")]
        public int Ref { get; set; }

        [JsonProperty("transform")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemTransformType Transform { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("infinit")]
        public string[] Infinit { get; set; }

        [JsonProperty("verb_meaning")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemVerbMeaningType VerbMeaning { get; set; }

        [JsonProperty("auxiliary")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemAuxiliaryType Auxiliary { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemLemmatizerType
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
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType Gender { get; set; }

        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }

        [JsonProperty("category")]
        public int[] Category { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType
    {
        [JsonProperty("male")]
        public bool Male { get; set; }

        [JsonProperty("female")]
        public bool Female { get; set; }

        [JsonProperty("plural")]
        public bool Plural { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem
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

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemMeaningTypeItem
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

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemTransformType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("meaning")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("extra")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemTransformTypeExtraType Extra { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem
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

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemTransformTypeExtraType
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

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemVerbMeaningType
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

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemAuxiliaryType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("lemmatizer")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem[][] Lemmatizer { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem
    {
        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ComprehendPostResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem
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

    public class ComprehendPostResponseItemSentencesTypeItemSubsentencesTypeItem
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

    public class ComprehendPostResponseItemSentencesTypeItemMlNerTypeItem
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

    public class ComprehendPostResponseItemSentencesTypeItemMlSentimentType
    {
        [JsonProperty("sentence")]
        public ComprehendPostResponseItemSentencesTypeItemMlSentimentTypeSentenceType Sentence { get; set; }

        [JsonProperty("subsentence")]
        public double[] Subsentence { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemMlSentimentTypeSentenceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemMlEmotionType
    {
        [JsonProperty("sentence")]
        public ComprehendPostResponseItemSentencesTypeItemMlEmotionTypeSentenceTypeItem[] Sentence { get; set; }

        [JsonProperty("subsentence")]
        public ComprehendPostResponseItemSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem[][] Subsentence { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemMlEmotionTypeSentenceTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentType
    {
        [JsonProperty("subsentences")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeValuesType Values { get; set; }

        [JsonProperty("elements")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItem
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
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType
    {
        [JsonProperty("positive")]
        public double Positive { get; set; }

        [JsonProperty("negative")]
        public int Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeValuesType
    {
        [JsonProperty("positive")]
        public int Positive { get; set; }

        [JsonProperty("negative")]
        public double Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendPostResponseItemSentencesTypeItemSentimentTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemSentimentTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionType
    {
        [JsonProperty("subsentences")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("elements")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItem
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
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType
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

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType
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

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeValuesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItemValueType Value { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ComprehendPostResponseItemSentencesTypeItemEmotionTypeElementsTypeItemValueType
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

    public class ComprehendPostResponseItemEmoticonType
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

    public class ComprehendPostResponseItemCoreferenceType
    {
        [JsonProperty("spans")]
        public ComprehendPostResponseItemCoreferenceTypeSpansTypeItem[] Spans { get; set; }

        [JsonProperty("clusters")]
        public int[][] Clusters { get; set; }
    }

    public class ComprehendPostResponseItemCoreferenceTypeSpansTypeItem
    {
        [JsonProperty("sentence_index")]
        public int SentenceIndex { get; set; }

        [JsonProperty("token_indexes")]
        public int[] TokenIndexes { get; set; }

        [JsonProperty("cluster_index")]
        public int ClusterIndex { get; set; }
    }

    public class ComprehendPostResponseItemEmotionTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyPostResponseItem
    {
        [JsonProperty("metadata")]
        public ClassifyPostResponseItemMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("nlc")]
        public ClassifyPostResponseItemNlcType Nlc { get; set; }
    }

    public class ClassifyPostResponseItemMetadataType
    {
        [JsonProperty("train_name")]
        public string TrainName { get; set; }

        [JsonProperty("train_date")]
        public string TrainDate { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }

    public class ClassifyPostResponseItemNlcType
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
        public ClassifyPostResponseItemNlcTypeSentencesTypeItem[] Sentences { get; set; }

        [JsonProperty("emoticon")]
        public ClassifyPostResponseItemNlcTypeEmoticonType Emoticon { get; set; }

        [JsonProperty("emoticon_data")]
        public string[] EmoticonData { get; set; }

        [JsonProperty("coreference")]
        public ClassifyPostResponseItemNlcTypeCoreferenceType Coreference { get; set; }

        [JsonProperty("sentiment")]
        public double Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ClassifyPostResponseItemNlcTypeEmotionTypeItem[] Emotion { get; set; }
        public ClassifyPostResponseItemNlcTypePerfsType Perfs { get; set; }

        [JsonProperty("patterns")]
        public string Patterns { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItem
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_pure")]
        public string SourcePure { get; set; }

        [JsonProperty("sentence_indexes")]
        public int[] SentenceIndexes { get; set; }

        [JsonProperty("detail")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItem[] Detail { get; set; }

        [JsonProperty("subsentences")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("ml_ner")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemMlNerTypeItem[] MlNer { get; set; }

        [JsonProperty("ml_sentiment")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemMlSentimentType MlSentiment { get; set; }

        [JsonProperty("ml_emotion")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemMlEmotionType MlEmotion { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("sentiment")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentType Sentiment { get; set; }

        [JsonProperty("emotion")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionType Emotion { get; set; }

        [JsonProperty("sentence_type")]
        public string SentenceType { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItem
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
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerType Lemmatizer { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("meaning")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dep")]
        public string Dep { get; set; }

        [JsonProperty("ref")]
        public int Ref { get; set; }

        [JsonProperty("transform")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformType Transform { get; set; }

        [JsonProperty("coreference")]
        public int[] Coreference { get; set; }

        [JsonProperty("infinit")]
        public int[] Infinit { get; set; }

        [JsonProperty("verb_meaning")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemVerbMeaningType VerbMeaning { get; set; }

        [JsonProperty("auxiliary")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryType Auxiliary { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerType
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
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType Gender { get; set; }

        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeGenderType
    {
        [JsonProperty("male")]
        public bool Male { get; set; }

        [JsonProperty("female")]
        public bool Female { get; set; }

        [JsonProperty("plural")]
        public bool Plural { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemLemmatizerTypeConjugateTypeItem
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemMeaningTypeItem
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("meaning")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem[] Meaning { get; set; }

        [JsonProperty("extra")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeExtraType Extra { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeMeaningTypeItem
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemTransformTypeExtraType
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemVerbMeaningType
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("lemmatizer")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem[][] Lemmatizer { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItem
    {
        [JsonProperty("infinit")]
        public string Infinit { get; set; }

        [JsonProperty("conjugate")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem[] Conjugate { get; set; }

        [JsonProperty("transitif")]
        public bool Transitif { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemDetailTypeItemAuxiliaryTypeLemmatizerTypeItemItemConjugateTypeItem
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSubsentencesTypeItem
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemMlNerTypeItem
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemMlSentimentType
    {
        [JsonProperty("sentence")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemMlSentimentTypeSentenceType Sentence { get; set; }

        [JsonProperty("subsentence")]
        public double[] Subsentence { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemMlSentimentTypeSentenceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemMlEmotionType
    {
        [JsonProperty("sentence")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSentenceTypeItem[] Sentence { get; set; }

        [JsonProperty("subsentence")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem[][] Subsentence { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSentenceTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemMlEmotionTypeSubsentenceTypeItemItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentType
    {
        [JsonProperty("subsentences")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeValuesType Values { get; set; }

        [JsonProperty("elements")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItem
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
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeSubsentencesTypeItemValuesType
    {
        [JsonProperty("positive")]
        public double Positive { get; set; }

        [JsonProperty("negative")]
        public int Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeValuesType
    {
        [JsonProperty("positive")]
        public int Positive { get; set; }

        [JsonProperty("negative")]
        public double Negative { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemSentimentTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionType
    {
        [JsonProperty("subsentences")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItem[] Subsentences { get; set; }

        [JsonProperty("values")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("elements")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItem[] Elements { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItem
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
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("values")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType Values { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemElementsTypeItemValueType
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeSubsentencesTypeItemValuesType
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

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeValuesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItem
    {
        [JsonProperty("target")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemTargetType Target { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("source")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemSourceType Source { get; set; }

        [JsonProperty("value")]
        public ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemValueType Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemTargetType
    {
        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemSourceType
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("lemma")]
        public string Lemma { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeSentencesTypeItemEmotionTypeElementsTypeItemValueType
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

    public class ClassifyPostResponseItemNlcTypeEmoticonType
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

    public class ClassifyPostResponseItemNlcTypeCoreferenceType
    {
        [JsonProperty("spans")]
        public ClassifyPostResponseItemNlcTypeCoreferenceTypeSpansTypeItem[] Spans { get; set; }

        [JsonProperty("clusters")]
        public int[][] Clusters { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypeCoreferenceTypeSpansTypeItem
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

    public class ClassifyPostResponseItemNlcTypeEmotionTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ClassifyPostResponseItemNlcTypePerfsType
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