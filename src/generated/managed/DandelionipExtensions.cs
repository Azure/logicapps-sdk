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
        public IBodyWorkflowAction<EntityGetResponse> EntityGet(Expression<Func<string>> text = null, Expression<Func<string>> html = null, Expression<Func<string>> htmlFragment = null, Expression<Func<string>> lang = null, Expression<Func<int>> topEntities = null, Expression<Func<int>> minConfidence = null, Expression<Func<int>> minLength = null, Expression<Func<bool>> socialHashtag = null, Expression<Func<bool>> socialMention = null, Expression<Func<string>> include = null, Expression<Func<string>> extraTypes = null, Expression<Func<string>> country = null, Expression<Func<double>> epsilon = null)
        {
            var apiCallPath = "/datatxt/nex/v1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = CSharpExpressionConverter.ConvertO(text);
            if (html != null)
                callPayload.Queries["html"] = CSharpExpressionConverter.ConvertO(html);
            if (htmlFragment != null)
                callPayload.Queries["html_fragment"] = CSharpExpressionConverter.ConvertO(htmlFragment);
            if (lang != null)
                callPayload.Queries["lang"] = CSharpExpressionConverter.ConvertO(lang);
            if (topEntities != null)
                callPayload.Queries["top_entities"] = CSharpExpressionConverter.ConvertO(topEntities);
            if (minConfidence != null)
                callPayload.Queries["min_confidence"] = CSharpExpressionConverter.ConvertO(minConfidence);
            if (minLength != null)
                callPayload.Queries["min_length"] = CSharpExpressionConverter.ConvertO(minLength);
            if (socialHashtag != null)
                callPayload.Queries["social.hashtag"] = CSharpExpressionConverter.ConvertO(socialHashtag);
            if (socialMention != null)
                callPayload.Queries["social.mention"] = CSharpExpressionConverter.ConvertO(socialMention);
            if (include != null)
                callPayload.Queries["include"] = CSharpExpressionConverter.ConvertO(include);
            if (extraTypes != null)
                callPayload.Queries["extra_types"] = CSharpExpressionConverter.ConvertO(extraTypes);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (epsilon != null)
                callPayload.Queries["epsilon"] = CSharpExpressionConverter.ConvertO(epsilon);
            return new ApiConnectionAction<EntityGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<SimilarityGetResponse> SimilarityGet(Expression<Func<string>> text1 = null, Expression<Func<string>> html1 = null, Expression<Func<string>> htmlFragment1 = null, Expression<Func<string>> text2 = null, Expression<Func<string>> html2 = null, Expression<Func<string>> htmlFragment2 = null, Expression<Func<string>> lang = null, Expression<Func<bowInput>> bow = null)
        {
            var apiCallPath = "/datatxt/sim/v1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text1 != null)
                callPayload.Queries["text1"] = CSharpExpressionConverter.ConvertO(text1);
            if (html1 != null)
                callPayload.Queries["html1"] = CSharpExpressionConverter.ConvertO(html1);
            if (htmlFragment1 != null)
                callPayload.Queries["html_fragment1"] = CSharpExpressionConverter.ConvertO(htmlFragment1);
            if (text2 != null)
                callPayload.Queries["text2"] = CSharpExpressionConverter.ConvertO(text2);
            if (html2 != null)
                callPayload.Queries["html2"] = CSharpExpressionConverter.ConvertO(html2);
            if (htmlFragment2 != null)
                callPayload.Queries["html_fragment2"] = CSharpExpressionConverter.ConvertO(htmlFragment2);
            if (lang != null)
                callPayload.Queries["lang"] = CSharpExpressionConverter.ConvertO(lang);
            if (bow != null)
                callPayload.Queries["bow"] = CSharpExpressionConverter.Convert(bow);
            return new ApiConnectionAction<SimilarityGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet(Expression<Func<string>> text = null, Expression<Func<string>> html = null, Expression<Func<string>> htmlFragment = null, Expression<Func<bool>> clean = null)
        {
            var apiCallPath = "/datatxt/li/v1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = CSharpExpressionConverter.ConvertO(text);
            if (html != null)
                callPayload.Queries["html"] = CSharpExpressionConverter.ConvertO(html);
            if (htmlFragment != null)
                callPayload.Queries["html_fragment"] = CSharpExpressionConverter.ConvertO(htmlFragment);
            if (clean != null)
                callPayload.Queries["clean"] = CSharpExpressionConverter.ConvertO(clean);
            return new ApiConnectionAction<LanguageGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<SentimentGetResponse> SentimentGet(Expression<Func<string>> text = null, Expression<Func<string>> html = null, Expression<Func<string>> htmlFragment = null, Expression<Func<string>> lang = null)
        {
            var apiCallPath = "/datatxt/sent/v1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = CSharpExpressionConverter.ConvertO(text);
            if (html != null)
                callPayload.Queries["html"] = CSharpExpressionConverter.ConvertO(html);
            if (htmlFragment != null)
                callPayload.Queries["html_fragment"] = CSharpExpressionConverter.ConvertO(htmlFragment);
            if (lang != null)
                callPayload.Queries["lang"] = CSharpExpressionConverter.ConvertO(lang);
            return new ApiConnectionAction<SentimentGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<WikipediaGetResponse> WikipediaGet(Expression<Func<string>> text, Expression<Func<langInput>> lang, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<queryInput>> query = null, Expression<Func<string>> include = null)
        {
            var apiCallPath = "/datagraph/wikisearch/v1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = CSharpExpressionConverter.ConvertO(text);
            callPayload.Queries["lang"] = CSharpExpressionConverter.Convert(lang);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (query != null)
                callPayload.Queries["query"] = CSharpExpressionConverter.Convert(query);
            if (include != null)
                callPayload.Queries["include"] = CSharpExpressionConverter.ConvertO(include);
            return new ApiConnectionAction<WikipediaGetResponse>(callPayload);
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