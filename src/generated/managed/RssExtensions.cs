//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rss
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RssActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rss")]
        public IBodyWorkflowAction<FeedItem[]> ListFeedItems([WorkflowExpression] Func<string> feedUrl, [WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<sincePropertyInput> sinceProperty = null)
        {
            var apiCallPath = "/ListFeedItems";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["feedUrl"] = ExpressionConverter.Convert(feedUrl);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            callPayload.Queries["sinceProperty"] = Convert.ToString("PublishDate");
            if (sinceProperty != null)
                callPayload.Queries["sinceProperty"] = ExpressionConverter.Convert(sinceProperty);
            return new ApiConnectionAction<FeedItem[]>(callPayload);
        }
    }

    public class RssTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerBatchResponseFeedItem> OnNewFeed([WorkflowExpression] Func<string> feedUrl, [WorkflowExpression] Func<sincePropertyInput> sinceProperty = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/OnNewFeed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["feedUrl"] = ExpressionConverter.Convert(feedUrl);
            callPayload.Queries["sinceProperty"] = Convert.ToString("PublishDate");
            if (sinceProperty != null)
                callPayload.Queries["sinceProperty"] = ExpressionConverter.Convert(sinceProperty);
            return new ApiConnectionTrigger<TriggerBatchResponseFeedItem>(callPayload, triggerName, recurrence);
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