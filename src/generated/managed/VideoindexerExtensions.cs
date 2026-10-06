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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUploadVideo(WorkflowExpression<string> videoUrl, WorkflowExpression<string> name, WorkflowExpression<privacyInput> privacy, WorkflowExpression<languageInput> language = null, WorkflowExpression<string> externalId = null, WorkflowExpression<string> metadata = null, WorkflowExpression<string> description = null, WorkflowExpression<string> partition = null, WorkflowExpression<string> callbackUrl = null)
        {
            WorkflowExpression.Validate(videoUrl, nameof(videoUrl), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(privacy, nameof(privacy), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(externalId, nameof(externalId), required: false);
            WorkflowExpression.Validate(metadata, nameof(metadata), required: false);
            WorkflowExpression.Validate(description, nameof(description), required: false);
            WorkflowExpression.Validate(partition, nameof(partition), required: false);
            WorkflowExpression.Validate(callbackUrl, nameof(callbackUrl), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUploadVideoFileContent(WorkflowExpression<string> fileContent, WorkflowExpression<string> name, WorkflowExpression<privacyInput> privacy, WorkflowExpression<languageInput> language = null, WorkflowExpression<string> externalId = null, WorkflowExpression<string> metadata = null, WorkflowExpression<string> description = null, WorkflowExpression<string> partition = null, WorkflowExpression<string> callbackUrl = null)
        {
            WorkflowExpression.Validate(fileContent, nameof(fileContent), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(privacy, nameof(privacy), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(externalId, nameof(externalId), required: false);
            WorkflowExpression.Validate(metadata, nameof(metadata), required: false);
            WorkflowExpression.Validate(description, nameof(description), required: false);
            WorkflowExpression.Validate(partition, nameof(partition), required: false);
            WorkflowExpression.Validate(callbackUrl, nameof(callbackUrl), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProcessingStateResponse> __BuildGetProcessingState(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowExpression<string> face = null, WorkflowExpression<string> query = null, WorkflowExpression<string> searchInPublicAccount = null, WorkflowExpression<privacyInput> privacy = null, WorkflowExpression<textScopeInput> textScope = null, WorkflowExpression<languageInput> language = null, WorkflowExpression<string> id = null, WorkflowExpression<string> partition = null, WorkflowExpression<string> owner = null, WorkflowExpression<double> pageSize = null, WorkflowExpression<double> skip = null, WorkflowExpression<string> externalId = null)
        {
            WorkflowExpression.Validate(face, nameof(face), required: false);
            WorkflowExpression.Validate(query, nameof(query), required: false);
            WorkflowExpression.Validate(searchInPublicAccount, nameof(searchInPublicAccount), required: false);
            WorkflowExpression.Validate(privacy, nameof(privacy), required: false);
            WorkflowExpression.Validate(textScope, nameof(textScope), required: false);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(partition, nameof(partition), required: false);
            WorkflowExpression.Validate(owner, nameof(owner), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(externalId, nameof(externalId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBreakdownResponse> __BuildGetBreakdown(WorkflowExpression<string> id, WorkflowExpression<languageInput> language = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteBreakdown(WorkflowExpression<string> id, WorkflowExpression<bool> deleteInsights = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(deleteInsights, nameof(deleteInsights), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetInsightsWidgetUrl(WorkflowExpression<string> id, WorkflowExpression<widgetTypeInput> widgetType = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(widgetType, nameof(widgetType), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetPlayerWidgetUrl(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetVttUrl(WorkflowExpression<string> id, WorkflowExpression<languageInput> language = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetInsightsWidgetUrlByExternalId(WorkflowExpression<string> externalId, WorkflowExpression<widgetTypeInput> widgetType = null)
        {
            WorkflowExpression.Validate(externalId, nameof(externalId), required: true);
            WorkflowExpression.Validate(widgetType, nameof(widgetType), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildReIndexBreakdown(WorkflowExpression<string> id, WorkflowExpression<string> callbackUrl = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(callbackUrl, nameof(callbackUrl), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildReIndexBreakdownByExternalId(WorkflowExpression<string> externalId, WorkflowExpression<string> callbackUrl = null)
        {
            WorkflowExpression.Validate(externalId, nameof(externalId), required: true);
            WorkflowExpression.Validate(callbackUrl, nameof(callbackUrl), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateFaceName(WorkflowExpression<string> id, WorkflowExpression<double> faceId, WorkflowExpression<string> newName)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(faceId, nameof(faceId), required: true);
            WorkflowExpression.Validate(newName, nameof(newName), required: true);
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