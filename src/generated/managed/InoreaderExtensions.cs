//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inoreader
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InoreaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<AddSubscriptionResponse> AddSubscription([WorkflowExpression] Func<string> bodyquickadd = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscription/quickadd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquickadd != null)
                {
                    body["quickadd"] = SourceExpressionConverter.ConvertToken(bodyquickadd);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddSubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction EditSubscription([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<string> bodyt)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = SourceExpressionConverter.ConvertO(streamId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["t"] = SourceExpressionConverter.ConvertToken(bodyt);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction UnsubscribeSubscription([WorkflowExpression] Func<string> streamId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/unsubscribe/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = SourceExpressionConverter.ConvertO(streamId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction RemoveSubscriptionFromFolder([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/remove/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = SourceExpressionConverter.ConvertO(streamId);
                callPayload.Queries["tagId"] = SourceExpressionConverter.ConvertO(tagId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction AddSubscriptionToFolder([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = SourceExpressionConverter.ConvertO(streamId);
                callPayload.Queries["tagId"] = SourceExpressionConverter.ConvertO(tagId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/disable-tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagId"] = SourceExpressionConverter.ConvertO(tagId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<UnreadCount> GetUnreadCountForStream([WorkflowExpression] Func<string> streamId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/single/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = SourceExpressionConverter.ConvertO(streamId);
                return callPayload;
            }

            return new ApiConnectionAction<UnreadCount>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<UnreadCount[]> GetUnreadCount()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UnreadCount[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<StreamContentsResponseItem[]> StreamContents([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<int> n = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stream/contents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(streamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (n != null)
                    callPayload.Queries["n"] = SourceExpressionConverter.ConvertO(n);
                return callPayload;
            }

            return new ApiConnectionAction<StreamContentsResponseItem[]>(BuildSourceInput);
        }
    }

    public class InoreaderTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Subscription[]> OnNewSubscription(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/subscription/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<Subscription[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UnreadCount> OnUnreadItemCountForStreamExceedsTarget([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<int> target, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = SourceExpressionConverter.ConvertO(streamId);
                callPayload.Queries["target"] = SourceExpressionConverter.ConvertO(target);
                return callPayload;
            }

            return new ApiConnectionTrigger<UnreadCount>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class AddSubscriptionResponse
    {
        [JsonProperty("numResults")]
        public bool NumResults { get; set; }

        [JsonProperty("streamId")]
        public string StreamId { get; set; }

        [JsonProperty("streamName")]
        public string StreamName { get; set; }
    }

    public class UnreadCount
    {
        [JsonProperty("count")]
        public JToken Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class StreamContentsResponseItem
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("summary")]
        public StreamContentsResponseItemSummaryType Summary { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class StreamContentsResponseItemSummaryType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("categories")]
        public SubscriptionCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("sortid")]
        public string Sortid { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("htmlUrl")]
        public string HtmlUrl { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }
    }

    public class SubscriptionCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Inoreader;

    public partial class WorkflowManagedActions
    {
        public InoreaderActions Inoreader(string connectionId) => new InoreaderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InoreaderTriggers Inoreader(string connectionId) => new InoreaderTriggers(connectionId);
    }
}