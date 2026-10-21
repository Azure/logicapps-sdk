//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inoreader
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InoreaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<AddSubscriptionResponse> AddSubscription(Expression<Func<string>> bodyquickadd = null)
        {
            var __workflow_bodyquickadd = WorkflowExpression.Compile(bodyquickadd, nameof(bodyquickadd), required: false);
            return new DeferredBodyAction<AddSubscriptionResponse>(() =>
            {
                var apiCallPath = "/subscription/quickadd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquickadd != null)
                {
                    body["quickadd"] = ExpressionConverter.ConvertO(__workflow_bodyquickadd);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddSubscriptionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction EditSubscription(Expression<Func<string>> streamId, Expression<Func<string>> bodyt)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            var __workflow_bodyt = WorkflowExpression.Compile(bodyt, nameof(bodyt), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(__workflow_streamId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["t"] = ExpressionConverter.ConvertO(__workflow_bodyt);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction UnsubscribeSubscription(Expression<Func<string>> streamId)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/unsubscribe/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(__workflow_streamId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction RemoveSubscriptionFromFolder(Expression<Func<string>> streamId, Expression<Func<string>> tagId)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/remove/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(__workflow_streamId);
                callPayload.Queries["tagId"] = ExpressionConverter.Convert(__workflow_tagId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction AddSubscriptionToFolder(Expression<Func<string>> streamId, Expression<Func<string>> tagId)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/add/subscription/edit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(__workflow_streamId);
                callPayload.Queries["tagId"] = ExpressionConverter.Convert(__workflow_tagId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IWorkflowAction DeleteTag(Expression<Func<string>> tagId)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/disable-tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagId"] = ExpressionConverter.Convert(__workflow_tagId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inoreader")]
        public IBodyWorkflowAction<UnreadCount> GetUnreadCountForStream(Expression<Func<string>> streamId)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            return new DeferredBodyAction<UnreadCount>(() =>
            {
                var apiCallPath = "/single/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(__workflow_streamId);
                return new ApiConnectionAction<UnreadCount>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
        public IBodyWorkflowAction<StreamContentsResponseItem[]> StreamContents(Expression<Func<string>> streamId, Expression<Func<int>> n = null)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            var __workflow_n = WorkflowExpression.Compile(n, nameof(n), required: false);
            return new DeferredBodyAction<StreamContentsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stream/contents/{0}", __workflow_streamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_n != null)
                    callPayload.Queries["n"] = ExpressionConverter.Convert(__workflow_n);
                return new ApiConnectionAction<StreamContentsResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class InoreaderTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Subscription[]> OnNewSubscription(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/subscription/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Subscription[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<UnreadCount> OnUnreadItemCountForStreamExceedsTarget(Expression<Func<string>> streamId, Expression<Func<int>> target, FlowRecurrence recurrence = null)
        {
            var __workflow_streamId = WorkflowExpression.Compile(streamId, nameof(streamId), required: true);
            var __workflow_target = WorkflowExpression.Compile(target, nameof(target), required: true);
            return new DeferredBodyTrigger<UnreadCount>(() =>
            {
                var apiCallPath = "/trigger/unread-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["streamId"] = ExpressionConverter.Convert(__workflow_streamId);
                callPayload.Queries["target"] = ExpressionConverter.Convert(__workflow_target);
                return new ApiConnectionTrigger<UnreadCount>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
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
