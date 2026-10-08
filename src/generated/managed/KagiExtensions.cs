//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kagi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KagiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        [WorkflowExpressionFactory(nameof(__BuildSummarize))]
        public IBodyWorkflowAction<SummarizePostResponse> Summarize([WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<bodyengineInput> bodyengine = null, [WorkflowExpression] Func<bodysummaryTypeInput> bodysummaryType = null, [WorkflowExpression] Func<bodytargetLanguageInput> bodytargetLanguage = null, [WorkflowExpression] Func<bool> bodycache = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SummarizePostResponse> __BuildSummarize(WorkflowExpression<string> bodyurl = null, WorkflowExpression<string> bodytext = null, WorkflowExpression<bodyengineInput> bodyengine = null, WorkflowExpression<bodysummaryTypeInput> bodysummaryType = null, WorkflowExpression<bodytargetLanguageInput> bodytargetLanguage = null, WorkflowExpression<bool> bodycache = null)
        {
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodyengine, nameof(bodyengine), required: false);
            WorkflowExpression.Validate(bodysummaryType, nameof(bodysummaryType), required: false);
            WorkflowExpression.Validate(bodytargetLanguage, nameof(bodytargetLanguage), required: false);
            WorkflowExpression.Validate(bodycache, nameof(bodycache), required: false);
            return new DeferredBodyAction<SummarizePostResponse>(() =>
            {
                var apiCallPath = "/v0/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodyengine != null)
                {
                    if (bodyengine != null)
                    {
                        body["engine"] = ExpressionConverter.ConvertO(bodyengine);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["engine"] = "cecil";
                    bodypropCount++;
                }

                if (bodysummaryType != null)
                {
                    if (bodysummaryType != null)
                    {
                        body["summary_type"] = ExpressionConverter.ConvertO(bodysummaryType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["summary_type"] = "summary";
                    bodypropCount++;
                }

                if (bodytargetLanguage != null)
                {
                    body["target_language"] = ExpressionConverter.ConvertO(bodytargetLanguage);
                    bodypropCount++;
                }

                if (bodycache != null)
                {
                    body["cache"] = ExpressionConverter.ConvertO(bodycache);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SummarizePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        [WorkflowExpressionFactory(nameof(__BuildFastGPT))]
        public IBodyWorkflowAction<FastGPTPostResponse> FastGPT([WorkflowExpression] Func<string> bodyquery)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FastGPTPostResponse> __BuildFastGPT(WorkflowExpression<string> bodyquery)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            return new DeferredBodyAction<FastGPTPostResponse>(() =>
            {
                var apiCallPath = "/v0/fastgpt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FastGPTPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        [WorkflowExpressionFactory(nameof(__BuildSearchGet))]
        public IBodyWorkflowAction<SearchGetResponse> SearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchGetResponse> __BuildSearchGet(WorkflowExpression<string> q, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SearchGetResponse>(() =>
            {
                var apiCallPath = "/v0/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<SearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        [WorkflowExpressionFactory(nameof(__BuildEnrichmentWebGet))]
        public IBodyWorkflowAction<EnrichmentWebGetResponse> EnrichmentWebGet([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnrichmentWebGetResponse> __BuildEnrichmentWebGet(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<EnrichmentWebGetResponse>(() =>
            {
                var apiCallPath = "/v0/enrich/web";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<EnrichmentWebGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        [WorkflowExpressionFactory(nameof(__BuildEnrichmentNewsGet))]
        public IBodyWorkflowAction<EnrichmentNewsGetResponse> EnrichmentNewsGet([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnrichmentNewsGetResponse> __BuildEnrichmentNewsGet(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<EnrichmentNewsGetResponse>(() =>
            {
                var apiCallPath = "/v0/enrich/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<EnrichmentNewsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        [WorkflowExpressionFactory(nameof(__BuildSmallWebGet))]
        public IBodyWorkflowAction<SmallWebGetResponse> SmallWebGet([WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SmallWebGetResponse> __BuildSmallWebGet(WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SmallWebGetResponse>(() =>
            {
                var apiCallPath = "/v1/smallweb/feed/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyengineInput
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
    public enum bodysummaryTypeInput
    {
        [EnumMember(Value = "summary")]
        Summary,
        [EnumMember(Value = "takeaway")]
        Takeaway
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytargetLanguageInput
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
        ID,
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