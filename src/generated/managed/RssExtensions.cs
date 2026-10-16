//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rss
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class RssActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rss")]
        public IBodyWorkflowAction<FeedItem[]> ListFeedItems(Expression<Func<string>> feedUrl, Expression<Func<string>> since = null, Expression<Func<sincePropertyInput>> sinceProperty = null)
        {
            var __workflow_feedUrl = WorkflowExpression.Compile(feedUrl, nameof(feedUrl), required: true);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_sinceProperty = WorkflowExpression.Compile(sinceProperty, nameof(sinceProperty), required: false);
            return new DeferredBodyAction<FeedItem[]>(() =>
            {
                var apiCallPath = "/ListFeedItems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["feedUrl"] = ExpressionConverter.Convert(__workflow_feedUrl);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                callPayload.Queries["sinceProperty"] = Convert.ToString("PublishDate");
                if (__workflow_sinceProperty != null)
                    callPayload.Queries["sinceProperty"] = ExpressionConverter.Convert(__workflow_sinceProperty);
                return new ApiConnectionAction<FeedItem[]>(callPayload);
            });
        }
    }

    public class RssTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerBatchResponseFeedItem> OnNewFeed(Expression<Func<string>> feedUrl, Expression<Func<sincePropertyInput>> sinceProperty = null, FlowRecurrence recurrence = null)
        {
            var __workflow_feedUrl = WorkflowExpression.Compile(feedUrl, nameof(feedUrl), required: true);
            var __workflow_sinceProperty = WorkflowExpression.Compile(sinceProperty, nameof(sinceProperty), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseFeedItem>(() =>
            {
                var apiCallPath = "/OnNewFeed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["feedUrl"] = ExpressionConverter.Convert(__workflow_feedUrl);
                callPayload.Queries["sinceProperty"] = Convert.ToString("PublishDate");
                if (__workflow_sinceProperty != null)
                    callPayload.Queries["sinceProperty"] = ExpressionConverter.Convert(__workflow_sinceProperty);
                return new ApiConnectionTrigger<TriggerBatchResponseFeedItem>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class FeedItem
    {
        [JsonProperty("id")]
        public string FeedID { get; set; }

        [JsonProperty("title")]
        public string FeedTitle { get; set; }

        [JsonProperty("primaryLink")]
        public string PrimaryFeedLink { get; set; }

        [JsonProperty("links")]
        public string[] FeedLinks { get; set; }

        [JsonProperty("updatedOn")]
        public string FeedUpdatedOn { get; set; }

        [JsonProperty("publishDate")]
        public string FeedPublishedOn { get; set; }

        [JsonProperty("summary")]
        public string FeedSummary { get; set; }

        [JsonProperty("copyright")]
        public string FeedCopyrightInformation { get; set; }

        [JsonProperty("categories")]
        public string[] FeedCategories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sincePropertyInput
    {
        PublishDate,
        UpdatedOn
    }

    public class TriggerBatchResponseFeedItem
    {
        [JsonProperty("value")]
        public FeedItem[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rss;

    public partial class WorkflowManagedActions
    {
        public RssActions Rss(string connectionId) => new RssActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RssTriggers Rss(string connectionId) => new RssTriggers(connectionId);
    }
}
