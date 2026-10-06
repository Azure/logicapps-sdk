//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rss
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RssActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rss")]
        public IBodyWorkflowAction<FeedItem[]> ListFeedItems([WorkflowExpression] Func<string> feedUrl, [WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<sincePropertyInput> sinceProperty = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ListFeedItems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["feedUrl"] = SourceExpressionConverter.ConvertO(feedUrl);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                callPayload.Queries["sinceProperty"] = Convert.ToString("PublishDate");
                if (sinceProperty != null)
                    callPayload.Queries["sinceProperty"] = SourceExpressionConverter.Convert(sinceProperty);
                return callPayload;
            }

            return new ApiConnectionAction<FeedItem[]>(BuildSourceInput);
        }
    }

    public class RssTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerBatchResponseFeedItem> OnNewFeed([WorkflowExpression] Func<string> feedUrl, [WorkflowExpression] Func<sincePropertyInput> sinceProperty = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/OnNewFeed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["feedUrl"] = SourceExpressionConverter.ConvertO(feedUrl);
                callPayload.Queries["sinceProperty"] = Convert.ToString("PublishDate");
                if (sinceProperty != null)
                    callPayload.Queries["sinceProperty"] = SourceExpressionConverter.Convert(sinceProperty);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseFeedItem>(BuildSourceInput, triggerName, recurrence);
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