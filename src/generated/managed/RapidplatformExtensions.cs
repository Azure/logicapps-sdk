//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rapidplatform
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RapidplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAllItems(Expression<Func<string>> listNameDynamic, Expression<Func<string>> skip = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> linkedTo = null)
        {
            var __workflow_listNameDynamic = WorkflowExpression.Compile(listNameDynamic, nameof(listNameDynamic), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_linkedTo = WorkflowExpression.Compile(linkedTo, nameof(linkedTo), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/All/items", __workflow_listNameDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_linkedTo != null)
                    callPayload.Queries["linkedTo"] = ExpressionConverter.Convert(__workflow_linkedTo);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> CreateListItem(Expression<Func<string>> listNameDynamic, Expression<Func<object>> dynamicListSchema = null)
        {
            var __workflow_listNameDynamic = WorkflowExpression.Compile(listNameDynamic, nameof(listNameDynamic), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/All/items", __workflow_listNameDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicListSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId)
        {
            var __workflow_listNameDynamic = WorkflowExpression.Compile(listNameDynamic, nameof(listNameDynamic), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/items/{1}", __workflow_listNameDynamic.WithUrlEncoding(1), __workflow_itemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateListItem(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId, Expression<Func<object>> dynamicListSchema = null)
        {
            var __workflow_listNameDynamic = WorkflowExpression.Compile(listNameDynamic, nameof(listNameDynamic), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/items/{1}", __workflow_listNameDynamic.WithUrlEncoding(1), __workflow_itemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicListSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetInheritLinks(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId, Expression<Func<string>> type)
        {
            var __workflow_listNameDynamic = WorkflowExpression.Compile(listNameDynamic, nameof(listNameDynamic), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/items/{1}/inherited-links", __workflow_listNameDynamic.WithUrlEncoding(1), __workflow_itemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SetAttachments(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId, Expression<Func<attachmentsInputItem[]>> attachments)
        {
            var __workflow_listNameDynamic = WorkflowExpression.Compile(listNameDynamic, nameof(listNameDynamic), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_attachments = WorkflowExpression.Compile(attachments, nameof(attachments), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/items/{1}/attachments", __workflow_listNameDynamic.WithUrlEncoding(1), __workflow_itemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_attachments);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class RapidplatformTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ListHookTrigger(Expression<Func<ListHookTriggerInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class attachmentsInputItem
    {
        [JsonProperty("drive_id")]
        public string DriveId { get; set; }

        [JsonProperty("drive_item_id")]
        public string DriveItemId { get; set; }
    }

    public class ListHookTriggerInput
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListHookTriggerInputConfigType Config { get; set; }
    }

    public class ListHookTriggerInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("list", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Table { get; set; }

        [JsonProperty("trigger", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListHookTriggerInputConfigTypeTriggerTypeType TriggerType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListHookTriggerInputConfigTypeTriggerTypeType
    {
        [EnumMember(Value = "Item Created")]
        ItemCreated,
        [EnumMember(Value = "Item Updated")]
        ItemUpdated,
        [EnumMember(Value = "Item Deleted")]
        ItemDeleted
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rapidplatform;

    public partial class WorkflowManagedActions
    {
        public RapidplatformActions Rapidplatform(string connectionId) => new RapidplatformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RapidplatformTriggers Rapidplatform(string connectionId) => new RapidplatformTriggers(connectionId);
    }
}