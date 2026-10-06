//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bbcnews
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BbcnewsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        [WorkflowExpressionFactory(nameof(__BuildGetNewsByTopic))]
        public IBodyWorkflowAction<NewsResponse> GetNewsByTopic([WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> topic = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewsResponse> __BuildGetNewsByTopic(WorkflowExpression<string> lang, WorkflowExpression<string> topic = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(topic, nameof(topic), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<NewsResponse>(() =>
            {
                var apiCallPath = "/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (topic != null)
                    callPayload.Queries["topic"] = ExpressionConverter.Convert(topic);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                return new ApiConnectionAction<NewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        [WorkflowExpressionFactory(nameof(__BuildGetLatestNews))]
        public IBodyWorkflowAction<NewsResponse> GetLatestNews([WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewsResponse> __BuildGetLatestNews(WorkflowExpression<string> lang, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(lang, nameof(lang), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<NewsResponse>(() =>
            {
                var apiCallPath = "/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                return new ApiConnectionAction<NewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        public IBodyWorkflowAction<LanguagesResponse> GetLanguages()
        {
            var apiCallPath = "/languages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LanguagesResponse>(callPayload);
        }
    }

    public class BbcnewsTriggers([ConnectionName] string connectionId)
    {
    }

    public class NewsResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("results")]
        public NewsItem[] Results { get; set; }
    }

    public class NewsItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class LanguagesResponse
    {
        [JsonProperty("languages")]
        public LanguagesResponseLanguagesTypeItem[] Languages { get; set; }
    }

    public class LanguagesResponseLanguagesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bbcnews;

    public partial class WorkflowManagedActions
    {
        public BbcnewsActions Bbcnews(string connectionId) => new BbcnewsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BbcnewsTriggers Bbcnews(string connectionId) => new BbcnewsTriggers(connectionId);
    }
}