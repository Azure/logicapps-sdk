//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inoreader
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InoreaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildAddSubscription))]
        public IBodyWorkflowAction<AddSubscriptionResponse> AddSubscription([WorkflowExpression] Func<string> bodyquickadd = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddSubscriptionResponse> __BuildAddSubscription(WorkflowValue<string> bodyquickadd = null)
        {
            WorkflowValue.Validate(bodyquickadd, nameof(bodyquickadd), required: false);
            return new DeferredBodyAction<AddSubscriptionResponse>(() =>
            {
                var apiCallPath = "/subscription/quickadd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquickadd != null)
                {
                    body["quickadd"] = ExpressionConverter.ConvertO(bodyquickadd);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddSubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildEditSubscription))]
        public IWorkflowAction EditSubscription([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<string> bodyt)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditSubscription(WorkflowValue<string> streamId, WorkflowValue<string> bodyt)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            WorkflowValue.Validate(bodyt, nameof(bodyt), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(streamId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["t"] = ExpressionConverter.ConvertO(bodyt);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildUnsubscribeSubscription))]
        public IWorkflowAction UnsubscribeSubscription([WorkflowExpression] Func<string> streamId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnsubscribeSubscription(WorkflowValue<string> streamId)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/unsubscribe/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(streamId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveSubscriptionFromFolder))]
        public IWorkflowAction RemoveSubscriptionFromFolder([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveSubscriptionFromFolder(WorkflowValue<string> streamId, WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/remove/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(streamId);
                callPayload.Queries["tagId"] = ExpressionConverter.Convert(tagId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildAddSubscriptionToFolder))]
        public IWorkflowAction AddSubscriptionToFolder([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddSubscriptionToFolder(WorkflowValue<string> streamId, WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/add/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(streamId);
                callPayload.Queries["tagId"] = ExpressionConverter.Convert(tagId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTag))]
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTag(WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/disable-tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagId"] = ExpressionConverter.Convert(tagId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildGetUnreadCountForStream))]
        public IBodyWorkflowAction<UnreadCount> GetUnreadCountForStream([WorkflowExpression] Func<string> streamId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnreadCount> __BuildGetUnreadCountForStream(WorkflowValue<string> streamId)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            return new DeferredBodyAction<UnreadCount>(() =>
            {
                var apiCallPath = "/single/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(streamId);
                return new ApiConnectionAction<UnreadCount>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<UnreadCount[]> GetUnreadCount()
        {
            var apiCallPath = "/unread-count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UnreadCount[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        [WorkflowExpressionFactory(nameof(__BuildStreamContents))]
        public IBodyWorkflowAction<StreamContentsResponseItem[]> StreamContents([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<int> n = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreamContentsResponseItem[]> __BuildStreamContents(WorkflowValue<string> streamId, WorkflowValue<int> n = null)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            WorkflowValue.Validate(n, nameof(n), required: false);
            return new DeferredBodyAction<StreamContentsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stream/contents/{0}", ExpressionConverter.ConvertWithUrlEncoding(streamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (n != null)
                    callPayload.Queries["n"] = ExpressionConverter.Convert(n);
                return new ApiConnectionAction<StreamContentsResponseItem[]>(callPayload);
            });
        }
    }

    public class InoreaderTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Subscription[]> OnNewSubscription(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/subscription/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Subscription[]>(callPayload, triggerName, recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUnreadItemCountForStreamExceedsTarget))]
        public IBodyWorkflowTrigger<UnreadCount> OnUnreadItemCountForStreamExceedsTarget([WorkflowExpression] Func<string> streamId, [WorkflowExpression] Func<int> target, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<UnreadCount> __BuildOnUnreadItemCountForStreamExceedsTarget(WorkflowValue<string> streamId, WorkflowValue<int> target, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(streamId, nameof(streamId), required: true);
            WorkflowValue.Validate(target, nameof(target), required: true);
            return new DeferredBodyTrigger<UnreadCount>(() =>
            {
                var apiCallPath = "/trigger/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(streamId);
                callPayload.Queries["target"] = ExpressionConverter.Convert(target);
                return new ApiConnectionTrigger<UnreadCount>(callPayload, triggerName, recurrence);
            }, triggerName);
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
