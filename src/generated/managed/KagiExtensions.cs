//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kagi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KagiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<SummarizePostResponse, ApiConnectionActionConfiguration> Summarize(Expression<Func<SummarizePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SummarizePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v0/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SummarizePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<FastGPTPostResponse, ApiConnectionActionConfiguration> FastGPT(Expression<Func<FastGPTPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FastGPTPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v0/fastgpt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FastGPTPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<SearchGetResponse, ApiConnectionActionConfiguration> SearchGet(Expression<Func<string>> q, Expression<Func<int>> limit = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SearchGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v0/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<SearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<EnrichmentWebGetResponse, ApiConnectionActionConfiguration> EnrichmentWebGet(Expression<Func<string>> q)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyAction<EnrichmentWebGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v0/enrich/web";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<EnrichmentWebGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<EnrichmentNewsGetResponse, ApiConnectionActionConfiguration> EnrichmentNewsGet(Expression<Func<string>> q)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyAction<EnrichmentNewsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v0/enrich/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<EnrichmentNewsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<SmallWebGetResponse, ApiConnectionActionConfiguration> SmallWebGet(Expression<Func<int>> limit = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SmallWebGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/smallweb/feed/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<SmallWebGetResponse>(callPayload);
            });
        }
    }

    public class KagiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SummarizePostResponse
    {
        [JsonProperty("meta")]
        public SummarizePostResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public SummarizePostResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("error")]
        public SummarizePostResponseErrorTypeItem[] Error { get; set; }
    }

    public class SummarizePostResponseMetaType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("ms")]
        public int Ms { get; set; }

        [JsonProperty("api_balance")]
        public double ApiBalance { get; set; }
    }

    public class SummarizePostResponseDataTypeItem
    {
        [JsonProperty("t")]
        public int T { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }
    }

    public class SummarizePostResponseErrorTypeItem
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }
    }

    public class SummarizePostInput
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("engine", DefaultValueHandling = DefaultValueHandling.Include)]
        public SummarizePostInputEngineType? Engine { get; set; } = SummarizePostInputEngineType.Cecil;

        [JsonProperty("summary_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public SummarizePostInputSummaryTypeType? SummaryType { get; set; } = SummarizePostInputSummaryTypeType.Summary;

        [JsonProperty("target_language")]
        public SummarizePostInputTargetLanguageType? TargetLanguage { get; set; }

        [JsonProperty("cache")]
        public bool? Cache { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SummarizePostInputEngineType
    {
        [EnumMember(Value = "cecil")]
        Cecil,
        [EnumMember(Value = "agnes")]
        Agnes,
        [EnumMember(Value = "daphne")]
        Daphne,
        [EnumMember(Value = "muriel")]
        Muriel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SummarizePostInputSummaryTypeType
    {
        [EnumMember(Value = "summary")]
        Summary,
        [EnumMember(Value = "takeaway")]
        Takeaway
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SummarizePostInputTargetLanguageType
    {
        BG,
        CS,
        DA,
        DE,
        EL,
        EN,
        ES,
        ET,
        FI,
        FR,
        HU,
        [EnumMember(Value = "ID")]
        Id,
        IT,
        JA,
        KO,
        LT,
        LV,
        NB,
        NL,
        PL,
        PT,
        RO,
        RU,
        SK,
        SL,
        SV,
        TR,
        UK,
        ZH,
        [EnumMember(Value = "ZH-HANT")]
        ZHHANT
    }

    public class FastGPTPostResponse
    {
        [JsonProperty("meta")]
        public FastGPTPostResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public FastGPTPostResponseDataType Data { get; set; }
    }

    public class FastGPTPostResponseMetaType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("ms")]
        public int Ms { get; set; }
    }

    public class FastGPTPostResponseDataType
    {
        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("tokens")]
        public int Tokens { get; set; }

        [JsonProperty("references")]
        public FastGPTPostResponseDataTypeReferencesTypeItem[] References { get; set; }
    }

    public class FastGPTPostResponseDataTypeReferencesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FastGPTPostInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }
    }

    public class SearchGetResponse
    {
        [JsonProperty("meta")]
        public SearchGetResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public SearchGetResponseDataTypeItem[] Data { get; set; }
    }

    public class SearchGetResponseMetaType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("ms")]
        public int Ms { get; set; }

        [JsonProperty("api_balance")]
        public double ApiBalance { get; set; }
    }

    public class SearchGetResponseDataTypeItem
    {
        [JsonProperty("t")]
        public int T { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("thumbnail")]
        public SearchGetResponseDataTypeItemThumbnailType Thumbnail { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("list")]
        public string[] List { get; set; }
    }

    public class SearchGetResponseDataTypeItemThumbnailType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class EnrichmentWebGetResponse
    {
        [JsonProperty("meta")]
        public EnrichmentWebGetResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public EnrichmentWebGetResponseDataTypeItem[] Data { get; set; }
    }

    public class EnrichmentWebGetResponseMetaType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("ms")]
        public int Ms { get; set; }
    }

    public class EnrichmentWebGetResponseDataTypeItem
    {
        [JsonProperty("t")]
        public int T { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }
    }

    public class EnrichmentNewsGetResponse
    {
        [JsonProperty("meta")]
        public EnrichmentNewsGetResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public EnrichmentNewsGetResponseDataTypeItem[] Data { get; set; }
    }

    public class EnrichmentNewsGetResponseMetaType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("ms")]
        public int Ms { get; set; }
    }

    public class EnrichmentNewsGetResponseDataTypeItem
    {
        [JsonProperty("t")]
        public int T { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }
    }

    public class SmallWebGetResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("entries")]
        public SmallWebGetResponseEntriesTypeItem[] Entries { get; set; }
    }

    public class SmallWebGetResponseEntriesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kagi;

    public partial class WorkflowManagedActions
    {
        public KagiActions Kagi(string connectionId) => new KagiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KagiTriggers Kagi(string connectionId) => new KagiTriggers(connectionId);
    }
}