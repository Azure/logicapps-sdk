//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bbcnews
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BbcnewsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        public IBodyWorkflowAction<NewsResponse, ApiConnectionActionConfiguration> GetNewsByTopic(Expression<Func<string>> lang, Expression<Func<string>> topic = null, Expression<Func<int>> limit = null)
        {
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: true);
            var __workflow_topic = WorkflowExpression.Compile(topic, nameof(topic), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<NewsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_topic != null)
                    callPayload.Queries["topic"] = ExpressionConverter.Convert(__workflow_topic);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                return new ApiConnectionAction<NewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        public IBodyWorkflowAction<NewsResponse, ApiConnectionActionConfiguration> GetLatestNews(Expression<Func<string>> lang, Expression<Func<int>> limit = null)
        {
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<NewsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                return new ApiConnectionAction<NewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bbcnews")]
        public IBodyWorkflowAction<LanguagesResponse, ApiConnectionActionConfiguration> GetLanguages()
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
