//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Videoindexer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VideoindexerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> UploadVideo(Expression<Func<string>> videoUrl, Expression<Func<string>> name, Expression<Func<privacyInput>> privacy, Expression<Func<languageInput>> language = null, Expression<Func<string>> externalId = null, Expression<Func<string>> metadata = null, Expression<Func<string>> description = null, Expression<Func<string>> partition = null, Expression<Func<string>> callbackUrl = null)
        {
            var apiCallPath = "/Api/Partner/Breakdowns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["videoUrl"] = CSharpExpressionConverter.ConvertO(videoUrl);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.Convert(language);
            if (externalId != null)
                callPayload.Queries["externalId"] = CSharpExpressionConverter.ConvertO(externalId);
            if (metadata != null)
                callPayload.Queries["metadata"] = CSharpExpressionConverter.ConvertO(metadata);
            if (description != null)
                callPayload.Queries["description"] = CSharpExpressionConverter.ConvertO(description);
            if (partition != null)
                callPayload.Queries["partition"] = CSharpExpressionConverter.ConvertO(partition);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            callPayload.Queries["privacy"] = CSharpExpressionConverter.Convert(privacy);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = CSharpExpressionConverter.ConvertO(callbackUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> UploadVideoFileContent(Expression<Func<string>> fileContent, Expression<Func<string>> name, Expression<Func<privacyInput>> privacy, Expression<Func<languageInput>> language = null, Expression<Func<string>> externalId = null, Expression<Func<string>> metadata = null, Expression<Func<string>> description = null, Expression<Func<string>> partition = null, Expression<Func<string>> callbackUrl = null)
        {
            var apiCallPath = "/Api/Partner/Breakdowns/FileContent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.Convert(language);
            if (externalId != null)
                callPayload.Queries["externalId"] = CSharpExpressionConverter.ConvertO(externalId);
            if (metadata != null)
                callPayload.Queries["metadata"] = CSharpExpressionConverter.ConvertO(metadata);
            if (description != null)
                callPayload.Queries["description"] = CSharpExpressionConverter.ConvertO(description);
            if (partition != null)
                callPayload.Queries["partition"] = CSharpExpressionConverter.ConvertO(partition);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            callPayload.Queries["privacy"] = CSharpExpressionConverter.Convert(privacy);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = CSharpExpressionConverter.ConvertO(callbackUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetProcessingStateResponse> GetProcessingState(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/State", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetProcessingStateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> face = null, Expression<Func<string>> query = null, Expression<Func<string>> searchInPublicAccount = null, Expression<Func<privacyInput>> privacy = null, Expression<Func<textScopeInput>> textScope = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> id = null, Expression<Func<string>> partition = null, Expression<Func<string>> owner = null, Expression<Func<double>> pageSize = null, Expression<Func<double>> skip = null, Expression<Func<string>> externalId = null)
        {
            var apiCallPath = "/Api/Partner/Breakdowns/Search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (face != null)
                callPayload.Queries["face"] = CSharpExpressionConverter.ConvertO(face);
            if (query != null)
                callPayload.Queries["query"] = CSharpExpressionConverter.ConvertO(query);
            if (searchInPublicAccount != null)
                callPayload.Queries["searchInPublicAccount"] = CSharpExpressionConverter.ConvertO(searchInPublicAccount);
            if (privacy != null)
                callPayload.Queries["privacy"] = CSharpExpressionConverter.Convert(privacy);
            if (textScope != null)
                callPayload.Queries["textScope"] = CSharpExpressionConverter.Convert(textScope);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.Convert(language);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            if (partition != null)
                callPayload.Queries["partition"] = CSharpExpressionConverter.ConvertO(partition);
            if (owner != null)
                callPayload.Queries["owner"] = CSharpExpressionConverter.ConvertO(owner);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (externalId != null)
                callPayload.Queries["externalId"] = CSharpExpressionConverter.ConvertO(externalId);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetBreakdownResponse> GetBreakdown(Expression<Func<string>> id, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.Convert(language);
            return new ApiConnectionAction<GetBreakdownResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> DeleteBreakdown(Expression<Func<string>> id, Expression<Func<bool>> deleteInsights = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (deleteInsights != null)
                callPayload.Queries["deleteInsights"] = CSharpExpressionConverter.ConvertO(deleteInsights);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrl(Expression<Func<string>> id, Expression<Func<widgetTypeInput>> widgetType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/InsightsWidgetUrl", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (widgetType != null)
                callPayload.Queries["widgetType"] = CSharpExpressionConverter.Convert(widgetType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetPlayerWidgetUrl(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/PlayerWidgetUrl", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetVttUrl(Expression<Func<string>> id, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/VttUrl", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.Convert(language);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrlByExternalId(Expression<Func<string>> externalId, Expression<Func<widgetTypeInput>> widgetType = null)
        {
            var apiCallPath = "/Api/Partner/Breakdowns/GetInsightsWidgetUrlByExternalId";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["externalId"] = CSharpExpressionConverter.ConvertO(externalId);
            if (widgetType != null)
                callPayload.Queries["widgetType"] = CSharpExpressionConverter.Convert(widgetType);
            return new ApiConnectionAction<string>(callPayload);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindex/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = CSharpExpressionConverter.ConvertO(callbackUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> ReIndexBreakdownByExternalId(Expression<Func<string>> externalId, Expression<Func<string>> callbackUrl = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindexbyexternalid/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = CSharpExpressionConverter.ConvertO(callbackUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> UpdateFaceName(Expression<Func<string>> id, Expression<Func<double>> faceId, Expression<Func<string>> newName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/UpdateFaceName/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["faceId"] = CSharpExpressionConverter.ConvertO(faceId);
            callPayload.Queries["newName"] = CSharpExpressionConverter.ConvertO(newName);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class VideoindexerTriggers([ConnectionName] string connectionId)
    {
    }

    public enum privacyInput
    {
        Private,
        Organization,
        Public
    }

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