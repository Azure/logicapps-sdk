//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dandelionip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DandelionipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<EntityGetResponse> EntityGet(Expression<Func<string>> text = null, Expression<Func<string>> html = null, Expression<Func<string>> htmlFragment = null, Expression<Func<string>> lang = null, Expression<Func<int>> topEntities = null, Expression<Func<int>> minConfidence = null, Expression<Func<int>> minLength = null, Expression<Func<bool>> socialHashtag = null, Expression<Func<bool>> socialMention = null, Expression<Func<string>> include = null, Expression<Func<string>> extraTypes = null, Expression<Func<string>> country = null, Expression<Func<double>> epsilon = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_html = WorkflowExpression.Compile(html, nameof(html), required: false);
            var __workflow_htmlFragment = WorkflowExpression.Compile(htmlFragment, nameof(htmlFragment), required: false);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: false);
            var __workflow_topEntities = WorkflowExpression.Compile(topEntities, nameof(topEntities), required: false);
            var __workflow_minConfidence = WorkflowExpression.Compile(minConfidence, nameof(minConfidence), required: false);
            var __workflow_minLength = WorkflowExpression.Compile(minLength, nameof(minLength), required: false);
            var __workflow_socialHashtag = WorkflowExpression.Compile(socialHashtag, nameof(socialHashtag), required: false);
            var __workflow_socialMention = WorkflowExpression.Compile(socialMention, nameof(socialMention), required: false);
            var __workflow_include = WorkflowExpression.Compile(include, nameof(include), required: false);
            var __workflow_extraTypes = WorkflowExpression.Compile(extraTypes, nameof(extraTypes), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_epsilon = WorkflowExpression.Compile(epsilon, nameof(epsilon), required: false);
            return new DeferredBodyAction<EntityGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/nex/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(__workflow_html);
                if (__workflow_htmlFragment != null)
                    callPayload.Queries["html_fragment"] = ExpressionConverter.Convert(__workflow_htmlFragment);
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                if (__workflow_topEntities != null)
                    callPayload.Queries["top_entities"] = ExpressionConverter.Convert(__workflow_topEntities);
                if (__workflow_minConfidence != null)
                    callPayload.Queries["min_confidence"] = ExpressionConverter.Convert(__workflow_minConfidence);
                if (__workflow_minLength != null)
                    callPayload.Queries["min_length"] = ExpressionConverter.Convert(__workflow_minLength);
                if (__workflow_socialHashtag != null)
                    callPayload.Queries["social.hashtag"] = ExpressionConverter.Convert(__workflow_socialHashtag);
                if (__workflow_socialMention != null)
                    callPayload.Queries["social.mention"] = ExpressionConverter.Convert(__workflow_socialMention);
                if (__workflow_include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(__workflow_include);
                if (__workflow_extraTypes != null)
                    callPayload.Queries["extra_types"] = ExpressionConverter.Convert(__workflow_extraTypes);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_epsilon != null)
                    callPayload.Queries["epsilon"] = ExpressionConverter.Convert(__workflow_epsilon);
                return new ApiConnectionAction<EntityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<SimilarityGetResponse> SimilarityGet(Expression<Func<string>> text1 = null, Expression<Func<string>> html1 = null, Expression<Func<string>> htmlFragment1 = null, Expression<Func<string>> text2 = null, Expression<Func<string>> html2 = null, Expression<Func<string>> htmlFragment2 = null, Expression<Func<string>> lang = null, Expression<Func<bowInput>> bow = null)
        {
            var __workflow_text1 = WorkflowExpression.Compile(text1, nameof(text1), required: false);
            var __workflow_html1 = WorkflowExpression.Compile(html1, nameof(html1), required: false);
            var __workflow_htmlFragment1 = WorkflowExpression.Compile(htmlFragment1, nameof(htmlFragment1), required: false);
            var __workflow_text2 = WorkflowExpression.Compile(text2, nameof(text2), required: false);
            var __workflow_html2 = WorkflowExpression.Compile(html2, nameof(html2), required: false);
            var __workflow_htmlFragment2 = WorkflowExpression.Compile(htmlFragment2, nameof(htmlFragment2), required: false);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: false);
            var __workflow_bow = WorkflowExpression.Compile(bow, nameof(bow), required: false);
            return new DeferredBodyAction<SimilarityGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/sim/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text1 != null)
                    callPayload.Queries["text1"] = ExpressionConverter.Convert(__workflow_text1);
                if (__workflow_html1 != null)
                    callPayload.Queries["html1"] = ExpressionConverter.Convert(__workflow_html1);
                if (__workflow_htmlFragment1 != null)
                    callPayload.Queries["html_fragment1"] = ExpressionConverter.Convert(__workflow_htmlFragment1);
                if (__workflow_text2 != null)
                    callPayload.Queries["text2"] = ExpressionConverter.Convert(__workflow_text2);
                if (__workflow_html2 != null)
                    callPayload.Queries["html2"] = ExpressionConverter.Convert(__workflow_html2);
                if (__workflow_htmlFragment2 != null)
                    callPayload.Queries["html_fragment2"] = ExpressionConverter.Convert(__workflow_htmlFragment2);
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                if (__workflow_bow != null)
                    callPayload.Queries["bow"] = ExpressionConverter.Convert(__workflow_bow);
                return new ApiConnectionAction<SimilarityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet(Expression<Func<string>> text = null, Expression<Func<string>> html = null, Expression<Func<string>> htmlFragment = null, Expression<Func<bool>> clean = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_html = WorkflowExpression.Compile(html, nameof(html), required: false);
            var __workflow_htmlFragment = WorkflowExpression.Compile(htmlFragment, nameof(htmlFragment), required: false);
            var __workflow_clean = WorkflowExpression.Compile(clean, nameof(clean), required: false);
            return new DeferredBodyAction<LanguageGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/li/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(__workflow_html);
                if (__workflow_htmlFragment != null)
                    callPayload.Queries["html_fragment"] = ExpressionConverter.Convert(__workflow_htmlFragment);
                if (__workflow_clean != null)
                    callPayload.Queries["clean"] = ExpressionConverter.Convert(__workflow_clean);
                return new ApiConnectionAction<LanguageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<SentimentGetResponse> SentimentGet(Expression<Func<string>> text = null, Expression<Func<string>> html = null, Expression<Func<string>> htmlFragment = null, Expression<Func<string>> lang = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_html = WorkflowExpression.Compile(html, nameof(html), required: false);
            var __workflow_htmlFragment = WorkflowExpression.Compile(htmlFragment, nameof(htmlFragment), required: false);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: false);
            return new DeferredBodyAction<SentimentGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/sent/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(__workflow_html);
                if (__workflow_htmlFragment != null)
                    callPayload.Queries["html_fragment"] = ExpressionConverter.Convert(__workflow_htmlFragment);
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                return new ApiConnectionAction<SentimentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        public IBodyWorkflowAction<WikipediaGetResponse> WikipediaGet(Expression<Func<string>> text, Expression<Func<langInput>> lang, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<queryInput>> query = null, Expression<Func<string>> include = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: true);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_include = WorkflowExpression.Compile(include, nameof(include), required: false);
            return new DeferredBodyAction<WikipediaGetResponse>(() =>
            {
                var apiCallPath = "/datagraph/wikisearch/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(__workflow_include);
                return new ApiConnectionAction<WikipediaGetResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
