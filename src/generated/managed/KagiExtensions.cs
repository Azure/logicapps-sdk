//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kagi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KagiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<SummarizePostResponse> Summarize([WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<bodyengineInput> bodyengine = null, [WorkflowExpression] Func<bodysummaryTypeInput> bodysummaryType = null, [WorkflowExpression] Func<bodytargetLanguageInput> bodytargetLanguage = null, [WorkflowExpression] Func<bool> bodycache = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyengine, nameof(bodyengine), required: false);
            SourceExpression.Validate(bodysummaryType, nameof(bodysummaryType), required: false);
            SourceExpression.Validate(bodytargetLanguage, nameof(bodytargetLanguage), required: false);
            SourceExpression.Validate(bodycache, nameof(bodycache), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyengine != null)
                {
                    if (bodyengine != null)
                    {
                        body["engine"] = SourceExpressionConverter.Convert(bodyengine);
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
                        body["summary_type"] = SourceExpressionConverter.Convert(bodysummaryType);
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
                    body["target_language"] = SourceExpressionConverter.Convert(bodytargetLanguage);
                    bodypropCount++;
                }

                if (bodycache != null)
                {
                    body["cache"] = SourceExpressionConverter.ConvertToken(bodycache);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SummarizePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<FastGPTPostResponse> FastGPT([WorkflowExpression] Func<string> bodyquery)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/fastgpt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FastGPTPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<SearchGetResponse> SearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<SearchGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<EnrichmentWebGetResponse> EnrichmentWebGet([WorkflowExpression] Func<string> q)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/enrich/web";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentWebGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<EnrichmentNewsGetResponse> EnrichmentNewsGet([WorkflowExpression] Func<string> q)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/enrich/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentNewsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kagi")]
        public IBodyWorkflowAction<SmallWebGetResponse> SmallWebGet([WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/smallweb/feed/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<SmallWebGetResponse>(BuildSourceInput);
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

    public enum bodysummaryTypeInput
    {
        [EnumMember(Value = "summary")]
        Summary,
        [EnumMember(Value = "takeaway")]
        Takeaway
    }

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