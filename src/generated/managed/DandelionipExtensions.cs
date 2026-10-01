//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dandelionip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DandelionipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<EntityGetResponse> EntityGet([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<string> htmlFragment = null, [WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<int> topEntities = null, [WorkflowExpression] Func<int> minConfidence = null, [WorkflowExpression] Func<int> minLength = null, [WorkflowExpression] Func<bool> socialHashtag = null, [WorkflowExpression] Func<bool> socialMention = null, [WorkflowExpression] Func<string> include = null, [WorkflowExpression] Func<string> extraTypes = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<double> epsilon = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datatxt/nex/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                if (html != null)
                    callPayload.Queries["html"] = SourceExpressionConverter.ConvertO(html);
                if (htmlFragment != null)
                    callPayload.Queries["html_fragment"] = SourceExpressionConverter.ConvertO(htmlFragment);
                if (lang != null)
                    callPayload.Queries["lang"] = SourceExpressionConverter.ConvertO(lang);
                if (topEntities != null)
                    callPayload.Queries["top_entities"] = SourceExpressionConverter.ConvertO(topEntities);
                if (minConfidence != null)
                    callPayload.Queries["min_confidence"] = SourceExpressionConverter.ConvertO(minConfidence);
                if (minLength != null)
                    callPayload.Queries["min_length"] = SourceExpressionConverter.ConvertO(minLength);
                if (socialHashtag != null)
                    callPayload.Queries["social.hashtag"] = SourceExpressionConverter.ConvertO(socialHashtag);
                if (socialMention != null)
                    callPayload.Queries["social.mention"] = SourceExpressionConverter.ConvertO(socialMention);
                if (include != null)
                    callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                if (extraTypes != null)
                    callPayload.Queries["extra_types"] = SourceExpressionConverter.ConvertO(extraTypes);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (epsilon != null)
                    callPayload.Queries["epsilon"] = SourceExpressionConverter.ConvertO(epsilon);
                return callPayload;
            }

            return new ApiConnectionAction<EntityGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<SimilarityGetResponse> SimilarityGet([WorkflowExpression] Func<string> text1 = null, [WorkflowExpression] Func<string> html1 = null, [WorkflowExpression] Func<string> htmlFragment1 = null, [WorkflowExpression] Func<string> text2 = null, [WorkflowExpression] Func<string> html2 = null, [WorkflowExpression] Func<string> htmlFragment2 = null, [WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<bowInput> bow = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datatxt/sim/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text1 != null)
                    callPayload.Queries["text1"] = SourceExpressionConverter.ConvertO(text1);
                if (html1 != null)
                    callPayload.Queries["html1"] = SourceExpressionConverter.ConvertO(html1);
                if (htmlFragment1 != null)
                    callPayload.Queries["html_fragment1"] = SourceExpressionConverter.ConvertO(htmlFragment1);
                if (text2 != null)
                    callPayload.Queries["text2"] = SourceExpressionConverter.ConvertO(text2);
                if (html2 != null)
                    callPayload.Queries["html2"] = SourceExpressionConverter.ConvertO(html2);
                if (htmlFragment2 != null)
                    callPayload.Queries["html_fragment2"] = SourceExpressionConverter.ConvertO(htmlFragment2);
                if (lang != null)
                    callPayload.Queries["lang"] = SourceExpressionConverter.ConvertO(lang);
                if (bow != null)
                    callPayload.Queries["bow"] = SourceExpressionConverter.Convert(bow);
                return callPayload;
            }

            return new ApiConnectionAction<SimilarityGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<string> htmlFragment = null, [WorkflowExpression] Func<bool> clean = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datatxt/li/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                if (html != null)
                    callPayload.Queries["html"] = SourceExpressionConverter.ConvertO(html);
                if (htmlFragment != null)
                    callPayload.Queries["html_fragment"] = SourceExpressionConverter.ConvertO(htmlFragment);
                if (clean != null)
                    callPayload.Queries["clean"] = SourceExpressionConverter.ConvertO(clean);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<SentimentGetResponse> SentimentGet([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<string> htmlFragment = null, [WorkflowExpression] Func<string> lang = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datatxt/sent/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                if (html != null)
                    callPayload.Queries["html"] = SourceExpressionConverter.ConvertO(html);
                if (htmlFragment != null)
                    callPayload.Queries["html_fragment"] = SourceExpressionConverter.ConvertO(htmlFragment);
                if (lang != null)
                    callPayload.Queries["lang"] = SourceExpressionConverter.ConvertO(lang);
                return callPayload;
            }

            return new ApiConnectionAction<SentimentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<WikipediaGetResponse> WikipediaGet([WorkflowExpression] Func<string> text, [WorkflowExpression] Func<langInput> lang, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<queryInput> query = null, [WorkflowExpression] Func<string> include = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datagraph/wikisearch/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                callPayload.Queries["lang"] = SourceExpressionConverter.Convert(lang);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.Convert(query);
                if (include != null)
                    callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                return callPayload;
            }

            return new ApiConnectionAction<WikipediaGetResponse>(BuildSourceInput);
        }
    }

    public class DandelionipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EntityGetResponse
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("annotations")]
        public EntityGetResponseAnnotationsTypeItem[] Annotations { get; set; }
    }

    public class EntityGetResponseAnnotationsTypeItem
    {
        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("lod")]
        public EntityGetResponseAnnotationsTypeItemLodType Lod { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("spot")]
        public string Spot { get; set; }
    }

    public class EntityGetResponseAnnotationsTypeItemLodType
    {
        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("dbpedia")]
        public string Dbpedia { get; set; }
    }

    public class SimilarityGetResponse
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("langConfidence")]
        public double LangConfidence { get; set; }

        [JsonProperty("text1")]
        public string Text1 { get; set; }

        [JsonProperty("text2")]
        public string Text2 { get; set; }

        [JsonProperty("similarity")]
        public double Similarity { get; set; }
    }

    public enum bowInput
    {
        [EnumMember(Value = "never")]
        Never,
        [EnumMember(Value = "always")]
        Always,
        [EnumMember(Value = "one_empty")]
        OneEmpty,
        [EnumMember(Value = "both_empty")]
        BothEmpty
    }

    public class LanguageGetResponse
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("detectedLangs")]
        public LanguageGetResponseDetectedLangsTypeItem[] DetectedLangs { get; set; }
    }

    public class LanguageGetResponseDetectedLangsTypeItem
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class SentimentGetResponse
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("sentiment")]
        public SentimentGetResponseSentimentType Sentiment { get; set; }
    }

    public class SentimentGetResponseSentimentType
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WikipediaGetResponse
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("entities")]
        public WikipediaGetResponseEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class WikipediaGetResponseEntitiesTypeItem
    {
        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public enum langInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "ru")]
        Ru
    }

    public enum queryInput
    {
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "prefix")]
        Prefix
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dandelionip;

    public partial class WorkflowManagedActions
    {
        public DandelionipActions Dandelionip(string connectionId) => new DandelionipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DandelionipTriggers Dandelionip(string connectionId) => new DandelionipTriggers(connectionId);
    }
}