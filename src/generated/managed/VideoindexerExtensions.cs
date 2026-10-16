//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Videoindexer
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VideoindexerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> UploadVideo(Expression<Func<string>> videoUrl, Expression<Func<string>> name, Expression<Func<privacyInput>> privacy, Expression<Func<languageInput>> language = null, Expression<Func<string>> externalId = null, Expression<Func<string>> metadata = null, Expression<Func<string>> description = null, Expression<Func<string>> partition = null, Expression<Func<string>> callbackUrl = null)
        {
            var __workflow_videoUrl = WorkflowExpression.Compile(videoUrl, nameof(videoUrl), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_privacy = WorkflowExpression.Compile(privacy, nameof(privacy), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_partition = WorkflowExpression.Compile(partition, nameof(partition), required: false);
            var __workflow_callbackUrl = WorkflowExpression.Compile(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["videoUrl"] = ExpressionConverter.Convert(__workflow_videoUrl);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(__workflow_externalId);
                if (__workflow_metadata != null)
                    callPayload.Queries["metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(__workflow_partition);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["privacy"] = ExpressionConverter.Convert(__workflow_privacy);
                if (__workflow_callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(__workflow_callbackUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> UploadVideoFileContent(Expression<Func<string>> fileContent, Expression<Func<string>> name, Expression<Func<privacyInput>> privacy, Expression<Func<languageInput>> language = null, Expression<Func<string>> externalId = null, Expression<Func<string>> metadata = null, Expression<Func<string>> description = null, Expression<Func<string>> partition = null, Expression<Func<string>> callbackUrl = null)
        {
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_privacy = WorkflowExpression.Compile(privacy, nameof(privacy), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_partition = WorkflowExpression.Compile(partition, nameof(partition), required: false);
            var __workflow_callbackUrl = WorkflowExpression.Compile(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns/FileContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(__workflow_externalId);
                if (__workflow_metadata != null)
                    callPayload.Queries["metadata"] = ExpressionConverter.Convert(__workflow_metadata);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(__workflow_partition);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["privacy"] = ExpressionConverter.Convert(__workflow_privacy);
                if (__workflow_callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(__workflow_callbackUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetProcessingStateResponse> GetProcessingState(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetProcessingStateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/State", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProcessingStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> face = null, Expression<Func<string>> query = null, Expression<Func<string>> searchInPublicAccount = null, Expression<Func<privacyInput>> privacy = null, Expression<Func<textScopeInput>> textScope = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> id = null, Expression<Func<string>> partition = null, Expression<Func<string>> owner = null, Expression<Func<double>> pageSize = null, Expression<Func<double>> skip = null, Expression<Func<string>> externalId = null)
        {
            var __workflow_face = WorkflowExpression.Compile(face, nameof(face), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_searchInPublicAccount = WorkflowExpression.Compile(searchInPublicAccount, nameof(searchInPublicAccount), required: false);
            var __workflow_privacy = WorkflowExpression.Compile(privacy, nameof(privacy), required: false);
            var __workflow_textScope = WorkflowExpression.Compile(textScope, nameof(textScope), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_partition = WorkflowExpression.Compile(partition, nameof(partition), required: false);
            var __workflow_owner = WorkflowExpression.Compile(owner, nameof(owner), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_face != null)
                    callPayload.Queries["face"] = ExpressionConverter.Convert(__workflow_face);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_searchInPublicAccount != null)
                    callPayload.Queries["searchInPublicAccount"] = ExpressionConverter.Convert(__workflow_searchInPublicAccount);
                if (__workflow_privacy != null)
                    callPayload.Queries["privacy"] = ExpressionConverter.Convert(__workflow_privacy);
                if (__workflow_textScope != null)
                    callPayload.Queries["textScope"] = ExpressionConverter.Convert(__workflow_textScope);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(__workflow_partition);
                if (__workflow_owner != null)
                    callPayload.Queries["owner"] = ExpressionConverter.Convert(__workflow_owner);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(__workflow_externalId);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetBreakdownResponse> GetBreakdown(Expression<Func<string>> id, Expression<Func<languageInput>> language = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<GetBreakdownResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<GetBreakdownResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> DeleteBreakdown(Expression<Func<string>> id, Expression<Func<bool>> deleteInsights = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_deleteInsights = WorkflowExpression.Compile(deleteInsights, nameof(deleteInsights), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deleteInsights != null)
                    callPayload.Queries["deleteInsights"] = ExpressionConverter.Convert(__workflow_deleteInsights);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrl(Expression<Func<string>> id, Expression<Func<widgetTypeInput>> widgetType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_widgetType = WorkflowExpression.Compile(widgetType, nameof(widgetType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/InsightsWidgetUrl", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_widgetType != null)
                    callPayload.Queries["widgetType"] = ExpressionConverter.Convert(__workflow_widgetType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetPlayerWidgetUrl(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/PlayerWidgetUrl", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetVttUrl(Expression<Func<string>> id, Expression<Func<languageInput>> language = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/VttUrl", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrlByExternalId(Expression<Func<string>> externalId, Expression<Func<widgetTypeInput>> widgetType = null)
        {
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            var __workflow_widgetType = WorkflowExpression.Compile(widgetType, nameof(widgetType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns/GetInsightsWidgetUrlByExternalId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalId"] = ExpressionConverter.Convert(__workflow_externalId);
                if (__workflow_widgetType != null)
                    callPayload.Queries["widgetType"] = ExpressionConverter.Convert(__workflow_widgetType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetAccountsResponseItem[]> GetAccounts()
        {
            var apiCallPath = "/Api/Partner/Accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAccountsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> ReIndexBreakdown(Expression<Func<string>> id, Expression<Func<string>> callbackUrl = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_callbackUrl = WorkflowExpression.Compile(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindex/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(__workflow_callbackUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> ReIndexBreakdownByExternalId(Expression<Func<string>> externalId, Expression<Func<string>> callbackUrl = null)
        {
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            var __workflow_callbackUrl = WorkflowExpression.Compile(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindexbyexternalid/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(__workflow_callbackUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> UpdateFaceName(Expression<Func<string>> id, Expression<Func<double>> faceId, Expression<Func<string>> newName)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_faceId = WorkflowExpression.Compile(faceId, nameof(faceId), required: true);
            var __workflow_newName = WorkflowExpression.Compile(newName, nameof(newName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/UpdateFaceName/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["faceId"] = ExpressionConverter.Convert(__workflow_faceId);
                callPayload.Queries["newName"] = ExpressionConverter.Convert(__workflow_newName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class VideoindexerTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum privacyInput
    {
        Private,
        Organization,
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum languageInput
    {
        English,
        Spanish,
        Russian,
        Japanese,
        German,
        French,
        Portuguese,
        Italian,
        Chinese
    }

    public class GetProcessingStateResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("results")]
        public SearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("nextPage")]
        public SearchResponseNextPageType NextPage { get; set; }
    }

    public class SearchResponseResultsTypeItem
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("partition")]
        public string Partition { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("privacyMode")]
        public string PrivacyMode { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("isOwned")]
        public bool IsOwned { get; set; }

        [JsonProperty("isBase")]
        public bool IsBase { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("processingProgress")]
        public string ProcessingProgress { get; set; }

        [JsonProperty("durationInSeconds")]
        public int DurationInSeconds { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("social")]
        public SearchResponseResultsTypeItemSocialType Social { get; set; }

        [JsonProperty("searchMatches")]
        public string SearchMatches { get; set; }
    }

    public class SearchResponseResultsTypeItemSocialType
    {
        [JsonProperty("likedByUser")]
        public bool LikedByUser { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }
    }

    public class SearchResponseNextPageType
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum textScopeInput
    {
        Transcript,
        Ocr
    }

    public class GetBreakdownResponse
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("partition")]
        public string Partition { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("privacyMode")]
        public string PrivacyMode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("isOwned")]
        public bool IsOwned { get; set; }

        [JsonProperty("isBase")]
        public bool IsBase { get; set; }

        [JsonProperty("durationInSeconds")]
        public int DurationInSeconds { get; set; }

        [JsonProperty("summarizedInsights")]
        public string SummarizedInsights { get; set; }

        [JsonProperty("breakdowns")]
        public string Breakdowns { get; set; }

        [JsonProperty("social")]
        public GetBreakdownResponseSocialType Social { get; set; }
    }

    public class GetBreakdownResponseSocialType
    {
        [JsonProperty("likedByUser")]
        public bool LikedByUser { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum widgetTypeInput
    {
        People,
        Sentiments,
        Keywords,
        Search
    }

    public class GetAccountsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Videoindexer;

    public partial class WorkflowManagedActions
    {
        public VideoindexerActions Videoindexer(string connectionId) => new VideoindexerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VideoindexerTriggers Videoindexer(string connectionId) => new VideoindexerTriggers(connectionId);
    }
}
