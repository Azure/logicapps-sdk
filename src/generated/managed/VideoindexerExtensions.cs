//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Videoindexer
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VideoindexerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildUploadVideo))]
        public IBodyWorkflowAction<string> UploadVideo([WorkflowExpression] Func<string> videoUrl, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<privacyInput> privacy, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> metadata = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUploadVideo(WorkflowValue<string> videoUrl, WorkflowValue<string> name, WorkflowValue<privacyInput> privacy, WorkflowValue<languageInput> language = null, WorkflowValue<string> externalId = null, WorkflowValue<string> metadata = null, WorkflowValue<string> description = null, WorkflowValue<string> partition = null, WorkflowValue<string> callbackUrl = null)
        {
            WorkflowValue.Validate(videoUrl, nameof(videoUrl), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(privacy, nameof(privacy), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            WorkflowValue.Validate(externalId, nameof(externalId), required: false);
            WorkflowValue.Validate(metadata, nameof(metadata), required: false);
            WorkflowValue.Validate(description, nameof(description), required: false);
            WorkflowValue.Validate(partition, nameof(partition), required: false);
            WorkflowValue.Validate(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["videoUrl"] = ExpressionConverter.Convert(videoUrl);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                if (externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
                if (metadata != null)
                    callPayload.Queries["metadata"] = ExpressionConverter.Convert(metadata);
                if (description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(description);
                if (partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(partition);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["privacy"] = ExpressionConverter.Convert(privacy);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildUploadVideoFileContent))]
        public IBodyWorkflowAction<string> UploadVideoFileContent([WorkflowExpression] Func<string> fileContent, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<privacyInput> privacy, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> metadata = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUploadVideoFileContent(WorkflowValue<string> fileContent, WorkflowValue<string> name, WorkflowValue<privacyInput> privacy, WorkflowValue<languageInput> language = null, WorkflowValue<string> externalId = null, WorkflowValue<string> metadata = null, WorkflowValue<string> description = null, WorkflowValue<string> partition = null, WorkflowValue<string> callbackUrl = null)
        {
            WorkflowValue.Validate(fileContent, nameof(fileContent), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(privacy, nameof(privacy), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            WorkflowValue.Validate(externalId, nameof(externalId), required: false);
            WorkflowValue.Validate(metadata, nameof(metadata), required: false);
            WorkflowValue.Validate(description, nameof(description), required: false);
            WorkflowValue.Validate(partition, nameof(partition), required: false);
            WorkflowValue.Validate(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns/FileContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                if (externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
                if (metadata != null)
                    callPayload.Queries["metadata"] = ExpressionConverter.Convert(metadata);
                if (description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(description);
                if (partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(partition);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["privacy"] = ExpressionConverter.Convert(privacy);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildGetProcessingState))]
        public IBodyWorkflowAction<GetProcessingStateResponse> GetProcessingState([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProcessingStateResponse> __BuildGetProcessingState(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetProcessingStateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/State", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProcessingStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> face = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> searchInPublicAccount = null, [WorkflowExpression] Func<privacyInput> privacy = null, [WorkflowExpression] Func<textScopeInput> textScope = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> owner = null, [WorkflowExpression] Func<double> pageSize = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> externalId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowValue<string> face = null, WorkflowValue<string> query = null, WorkflowValue<string> searchInPublicAccount = null, WorkflowValue<privacyInput> privacy = null, WorkflowValue<textScopeInput> textScope = null, WorkflowValue<languageInput> language = null, WorkflowValue<string> id = null, WorkflowValue<string> partition = null, WorkflowValue<string> owner = null, WorkflowValue<double> pageSize = null, WorkflowValue<double> skip = null, WorkflowValue<string> externalId = null)
        {
            WorkflowValue.Validate(face, nameof(face), required: false);
            WorkflowValue.Validate(query, nameof(query), required: false);
            WorkflowValue.Validate(searchInPublicAccount, nameof(searchInPublicAccount), required: false);
            WorkflowValue.Validate(privacy, nameof(privacy), required: false);
            WorkflowValue.Validate(textScope, nameof(textScope), required: false);
            WorkflowValue.Validate(language, nameof(language), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(partition, nameof(partition), required: false);
            WorkflowValue.Validate(owner, nameof(owner), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(externalId, nameof(externalId), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (face != null)
                    callPayload.Queries["face"] = ExpressionConverter.Convert(face);
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (searchInPublicAccount != null)
                    callPayload.Queries["searchInPublicAccount"] = ExpressionConverter.Convert(searchInPublicAccount);
                if (privacy != null)
                    callPayload.Queries["privacy"] = ExpressionConverter.Convert(privacy);
                if (textScope != null)
                    callPayload.Queries["textScope"] = ExpressionConverter.Convert(textScope);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(partition);
                if (owner != null)
                    callPayload.Queries["owner"] = ExpressionConverter.Convert(owner);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildGetBreakdown))]
        public IBodyWorkflowAction<GetBreakdownResponse> GetBreakdown([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<languageInput> language = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBreakdownResponse> __BuildGetBreakdown(WorkflowValue<string> id, WorkflowValue<languageInput> language = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<GetBreakdownResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                return new ApiConnectionAction<GetBreakdownResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteBreakdown))]
        public IBodyWorkflowAction<JToken> DeleteBreakdown([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> deleteInsights = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteBreakdown(WorkflowValue<string> id, WorkflowValue<bool> deleteInsights = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(deleteInsights, nameof(deleteInsights), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (deleteInsights != null)
                    callPayload.Queries["deleteInsights"] = ExpressionConverter.Convert(deleteInsights);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildGetInsightsWidgetUrl))]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrl([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<widgetTypeInput> widgetType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetInsightsWidgetUrl(WorkflowValue<string> id, WorkflowValue<widgetTypeInput> widgetType = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(widgetType, nameof(widgetType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/InsightsWidgetUrl", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (widgetType != null)
                    callPayload.Queries["widgetType"] = ExpressionConverter.Convert(widgetType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildGetPlayerWidgetUrl))]
        public IBodyWorkflowAction<string> GetPlayerWidgetUrl([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetPlayerWidgetUrl(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/PlayerWidgetUrl", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildGetVttUrl))]
        public IBodyWorkflowAction<string> GetVttUrl([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<languageInput> language = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetVttUrl(WorkflowValue<string> id, WorkflowValue<languageInput> language = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/{0}/VttUrl", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildGetInsightsWidgetUrlByExternalId))]
        public IBodyWorkflowAction<string> GetInsightsWidgetUrlByExternalId([WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<widgetTypeInput> widgetType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetInsightsWidgetUrlByExternalId(WorkflowValue<string> externalId, WorkflowValue<widgetTypeInput> widgetType = null)
        {
            WorkflowValue.Validate(externalId, nameof(externalId), required: true);
            WorkflowValue.Validate(widgetType, nameof(widgetType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Api/Partner/Breakdowns/GetInsightsWidgetUrlByExternalId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
                if (widgetType != null)
                    callPayload.Queries["widgetType"] = ExpressionConverter.Convert(widgetType);
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
        [WorkflowExpressionFactory(nameof(__BuildReIndexBreakdown))]
        public IBodyWorkflowAction<JToken> ReIndexBreakdown([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildReIndexBreakdown(WorkflowValue<string> id, WorkflowValue<string> callbackUrl = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindex/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildReIndexBreakdownByExternalId))]
        public IBodyWorkflowAction<JToken> ReIndexBreakdownByExternalId([WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<string> callbackUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildReIndexBreakdownByExternalId(WorkflowValue<string> externalId, WorkflowValue<string> callbackUrl = null)
        {
            WorkflowValue.Validate(externalId, nameof(externalId), required: true);
            WorkflowValue.Validate(callbackUrl, nameof(callbackUrl), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/reindexbyexternalid/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (callbackUrl != null)
                    callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFaceName))]
        public IBodyWorkflowAction<JToken> UpdateFaceName([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<double> faceId, [WorkflowExpression] Func<string> newName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateFaceName(WorkflowValue<string> id, WorkflowValue<double> faceId, WorkflowValue<string> newName)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(faceId, nameof(faceId), required: true);
            WorkflowValue.Validate(newName, nameof(newName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Api/Partner/Breakdowns/UpdateFaceName/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["faceId"] = ExpressionConverter.Convert(faceId);
                callPayload.Queries["newName"] = ExpressionConverter.Convert(newName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
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
