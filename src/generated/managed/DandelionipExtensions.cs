//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dandelionip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DandelionipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        [WorkflowExpressionFactory(nameof(__BuildEntityGet))]
        public IBodyWorkflowAction<EntityGetResponse> EntityGet([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<string> htmlFragment = null, [WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<int> topEntities = null, [WorkflowExpression] Func<int> minConfidence = null, [WorkflowExpression] Func<int> minLength = null, [WorkflowExpression] Func<bool> socialHashtag = null, [WorkflowExpression] Func<bool> socialMention = null, [WorkflowExpression] Func<string> include = null, [WorkflowExpression] Func<string> extraTypes = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<double> epsilon = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityGetResponse> __BuildEntityGet(WorkflowExpression<string> text = null, WorkflowExpression<string> html = null, WorkflowExpression<string> htmlFragment = null, WorkflowExpression<string> lang = null, WorkflowExpression<int> topEntities = null, WorkflowExpression<int> minConfidence = null, WorkflowExpression<int> minLength = null, WorkflowExpression<bool> socialHashtag = null, WorkflowExpression<bool> socialMention = null, WorkflowExpression<string> include = null, WorkflowExpression<string> extraTypes = null, WorkflowExpression<string> country = null, WorkflowExpression<double> epsilon = null)
        {
            WorkflowExpression.Validate(text, nameof(text), required: false);
            WorkflowExpression.Validate(html, nameof(html), required: false);
            WorkflowExpression.Validate(htmlFragment, nameof(htmlFragment), required: false);
            WorkflowExpression.Validate(lang, nameof(lang), required: false);
            WorkflowExpression.Validate(topEntities, nameof(topEntities), required: false);
            WorkflowExpression.Validate(minConfidence, nameof(minConfidence), required: false);
            WorkflowExpression.Validate(minLength, nameof(minLength), required: false);
            WorkflowExpression.Validate(socialHashtag, nameof(socialHashtag), required: false);
            WorkflowExpression.Validate(socialMention, nameof(socialMention), required: false);
            WorkflowExpression.Validate(include, nameof(include), required: false);
            WorkflowExpression.Validate(extraTypes, nameof(extraTypes), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(epsilon, nameof(epsilon), required: false);
            return new DeferredBodyAction<EntityGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/nex/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                if (html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(html);
                if (htmlFragment != null)
                    callPayload.Queries["html_fragment"] = ExpressionConverter.Convert(htmlFragment);
                if (lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                if (topEntities != null)
                    callPayload.Queries["top_entities"] = ExpressionConverter.Convert(topEntities);
                if (minConfidence != null)
                    callPayload.Queries["min_confidence"] = ExpressionConverter.Convert(minConfidence);
                if (minLength != null)
                    callPayload.Queries["min_length"] = ExpressionConverter.Convert(minLength);
                if (socialHashtag != null)
                    callPayload.Queries["social.hashtag"] = ExpressionConverter.Convert(socialHashtag);
                if (socialMention != null)
                    callPayload.Queries["social.mention"] = ExpressionConverter.Convert(socialMention);
                if (include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(include);
                if (extraTypes != null)
                    callPayload.Queries["extra_types"] = ExpressionConverter.Convert(extraTypes);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                if (epsilon != null)
                    callPayload.Queries["epsilon"] = ExpressionConverter.Convert(epsilon);
                return new ApiConnectionAction<EntityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        [WorkflowExpressionFactory(nameof(__BuildSimilarityGet))]
        public IBodyWorkflowAction<SimilarityGetResponse> SimilarityGet([WorkflowExpression] Func<string> text1 = null, [WorkflowExpression] Func<string> html1 = null, [WorkflowExpression] Func<string> htmlFragment1 = null, [WorkflowExpression] Func<string> text2 = null, [WorkflowExpression] Func<string> html2 = null, [WorkflowExpression] Func<string> htmlFragment2 = null, [WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<bowInput> bow = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SimilarityGetResponse> __BuildSimilarityGet(WorkflowExpression<string> text1 = null, WorkflowExpression<string> html1 = null, WorkflowExpression<string> htmlFragment1 = null, WorkflowExpression<string> text2 = null, WorkflowExpression<string> html2 = null, WorkflowExpression<string> htmlFragment2 = null, WorkflowExpression<string> lang = null, WorkflowExpression<bowInput> bow = null)
        {
            WorkflowExpression.Validate(text1, nameof(text1), required: false);
            WorkflowExpression.Validate(html1, nameof(html1), required: false);
            WorkflowExpression.Validate(htmlFragment1, nameof(htmlFragment1), required: false);
            WorkflowExpression.Validate(text2, nameof(text2), required: false);
            WorkflowExpression.Validate(html2, nameof(html2), required: false);
            WorkflowExpression.Validate(htmlFragment2, nameof(htmlFragment2), required: false);
            WorkflowExpression.Validate(lang, nameof(lang), required: false);
            WorkflowExpression.Validate(bow, nameof(bow), required: false);
            return new DeferredBodyAction<SimilarityGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/sim/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text1 != null)
                    callPayload.Queries["text1"] = ExpressionConverter.Convert(text1);
                if (html1 != null)
                    callPayload.Queries["html1"] = ExpressionConverter.Convert(html1);
                if (htmlFragment1 != null)
                    callPayload.Queries["html_fragment1"] = ExpressionConverter.Convert(htmlFragment1);
                if (text2 != null)
                    callPayload.Queries["text2"] = ExpressionConverter.Convert(text2);
                if (html2 != null)
                    callPayload.Queries["html2"] = ExpressionConverter.Convert(html2);
                if (htmlFragment2 != null)
                    callPayload.Queries["html_fragment2"] = ExpressionConverter.Convert(htmlFragment2);
                if (lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                if (bow != null)
                    callPayload.Queries["bow"] = ExpressionConverter.Convert(bow);
                return new ApiConnectionAction<SimilarityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageGet))]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<string> htmlFragment = null, [WorkflowExpression] Func<bool> clean = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageGetResponse> __BuildLanguageGet(WorkflowExpression<string> text = null, WorkflowExpression<string> html = null, WorkflowExpression<string> htmlFragment = null, WorkflowExpression<bool> clean = null)
        {
            WorkflowExpression.Validate(text, nameof(text), required: false);
            WorkflowExpression.Validate(html, nameof(html), required: false);
            WorkflowExpression.Validate(htmlFragment, nameof(htmlFragment), required: false);
            WorkflowExpression.Validate(clean, nameof(clean), required: false);
            return new DeferredBodyAction<LanguageGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/li/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                if (html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(html);
                if (htmlFragment != null)
                    callPayload.Queries["html_fragment"] = ExpressionConverter.Convert(htmlFragment);
                if (clean != null)
                    callPayload.Queries["clean"] = ExpressionConverter.Convert(clean);
                return new ApiConnectionAction<LanguageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        [WorkflowExpressionFactory(nameof(__BuildSentimentGet))]
        public IBodyWorkflowAction<SentimentGetResponse> SentimentGet([WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<string> htmlFragment = null, [WorkflowExpression] Func<string> lang = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SentimentGetResponse> __BuildSentimentGet(WorkflowExpression<string> text = null, WorkflowExpression<string> html = null, WorkflowExpression<string> htmlFragment = null, WorkflowExpression<string> lang = null)
        {
            WorkflowExpression.Validate(text, nameof(text), required: false);
            WorkflowExpression.Validate(html, nameof(html), required: false);
            WorkflowExpression.Validate(htmlFragment, nameof(htmlFragment), required: false);
            WorkflowExpression.Validate(lang, nameof(lang), required: false);
            return new DeferredBodyAction<SentimentGetResponse>(() =>
            {
                var apiCallPath = "/datatxt/sent/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                if (html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(html);
                if (htmlFragment != null)
                    callPayload.Queries["html_fragment"] = ExpressionConverter.Convert(htmlFragment);
                if (lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                return new ApiConnectionAction<SentimentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dandelionip")]
        [WorkflowExpressionFactory(nameof(__BuildWikipediaGet))]
        public IBodyWorkflowAction<WikipediaGetResponse> WikipediaGet([WorkflowExpression] Func<string> text, [WorkflowExpression] Func<langInput> lang, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<queryInput> query = null, [WorkflowExpression] Func<string> include = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WikipediaGetResponse> __BuildWikipediaGet(WorkflowExpression<string> text, WorkflowExpression<langInput> lang, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<queryInput> query = null, WorkflowExpression<string> include = null)
        {
            WorkflowExpression.Validate(text, nameof(text), required: true);
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(query, nameof(query), required: false);
            WorkflowExpression.Validate(include, nameof(include), required: false);
            return new DeferredBodyAction<WikipediaGetResponse>(() =>
            {
                var apiCallPath = "/datagraph/wikisearch/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (include != null)
                    callPayload.Queries["include"] = ExpressionConverter.Convert(include);
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