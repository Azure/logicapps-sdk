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
        public IBodyWorkflowAction<string> UploadVideo([WorkflowExpression] Func<string> videoUrl, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<privacyInput> privacy, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> metadata = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Api/Partner/Breakdowns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["videoUrl"] = SourceExpressionConverter.ConvertO(videoUrl);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                if (externalId != null)
                    callPayload.Queries["externalId"] = SourceExpressionConverter.ConvertO(externalId);
                if (metadata != null)
                    callPayload.Queries["metadata"] = SourceExpressionConverter.ConvertO(metadata);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                if (partition != null)
                    callPayload.Queries["partition"] = SourceExpressionConverter.ConvertO(partition);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["privacy"] = SourceExpressionConverter.Convert(privacy);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = SourceExpressionConverter.ConvertO(callbackUrl);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetProcessingStateResponse> GetProcessingState([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/State", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProcessingStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> face = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> searchInPublicAccount = null, [WorkflowExpression] Func<privacyInput> privacy = null, [WorkflowExpression] Func<textScopeInput> textScope = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> owner = null, [WorkflowExpression] Func<double> pageSize = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> externalId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Api/Partner/Breakdowns/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (face != null)
                    callPayload.Queries["face"] = SourceExpressionConverter.ConvertO(face);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (searchInPublicAccount != null)
                    callPayload.Queries["searchInPublicAccount"] = SourceExpressionConverter.ConvertO(searchInPublicAccount);
                if (privacy != null)
                    callPayload.Queries["privacy"] = SourceExpressionConverter.Convert(privacy);
                if (textScope != null)
                    callPayload.Queries["textScope"] = SourceExpressionConverter.Convert(textScope);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (partition != null)
                    callPayload.Queries["partition"] = SourceExpressionConverter.ConvertO(partition);
                if (owner != null)
                    callPayload.Queries["owner"] = SourceExpressionConverter.ConvertO(owner);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (externalId != null)
                    callPayload.Queries["externalId"] = SourceExpressionConverter.ConvertO(externalId);
                return callPayload;
            }

            return new ApiConnectionAction<SearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetBreakdownResponse> GetBreakdown([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<languageInput> language = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<GetBreakdownResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> DeleteBreakdown([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> deleteInsights = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (deleteInsights != null)
                    callPayload.Queries["deleteInsights"] = SourceExpressionConverter.ConvertO(deleteInsights);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrl([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<widgetTypeInput> widgetType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/InsightsWidgetUrl", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (widgetType != null)
                    callPayload.Queries["widgetType"] = SourceExpressionConverter.Convert(widgetType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetPlayerWidgetUrl([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/PlayerWidgetUrl", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetVttUrl([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<languageInput> language = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/VttUrl", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrlByExternalId([WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<widgetTypeInput> widgetType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Api/Partner/Breakdowns/GetInsightsWidgetUrlByExternalId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalId"] = SourceExpressionConverter.ConvertO(externalId);
                if (widgetType != null)
                    callPayload.Queries["widgetType"] = SourceExpressionConverter.Convert(widgetType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<GetAccountsResponseItem[]> GetAccounts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Api/Partner/Accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAccountsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> ReIndexBreakdown([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindex/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = SourceExpressionConverter.ConvertO(callbackUrl);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> ReIndexBreakdownByExternalId([WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindexbyexternalid/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = SourceExpressionConverter.ConvertO(callbackUrl);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        public IBodyWorkflowAction<JToken> UpdateFaceName([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<double> faceId, [WorkflowExpression] Func<string> newName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/UpdateFaceName/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["faceId"] = SourceExpressionConverter.ConvertO(faceId);
                callPayload.Queries["newName"] = SourceExpressionConverter.ConvertO(newName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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