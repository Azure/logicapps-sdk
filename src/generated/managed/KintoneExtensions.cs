//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kintone
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KintoneActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddRecord(Expression<Func<AddRecordInput>> requestBodyOfRecord = null)
        {
            var __workflow_requestBodyOfRecord = WorkflowExpression.Compile(requestBodyOfRecord, nameof(requestBodyOfRecord), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/k/v1/record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBodyOfRecord != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecord);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateRecord(Expression<Func<UpdateRecordInput>> requestBodyOfRecord = null)
        {
            var __workflow_requestBodyOfRecord = WorkflowExpression.Compile(requestBodyOfRecord, nameof(requestBodyOfRecord), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/k/v1/record.json";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBodyOfRecord != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecord);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class KintoneTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<WebhookTriggerInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForUpdatingRecord(Expression<Func<AddWebhookForUpdatingRecordInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/update_record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForDeletingRecord(Expression<Func<AddWebhookForDeletingRecordInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/delete_record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForAddingRecordComment(Expression<Func<AddWebhookForAddingRecordCommentInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/add_record_comment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForUpdatingStatus(Expression<Func<AddWebhookForUpdatingStatusInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/update_status.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddRecordInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "ACTION_POST_RECORD";

        [JsonProperty("record")]
        public JToken Record { get; set; }
    }

    public class UpdateRecordInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecordNumber { get; set; }

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "ACTION_PUT_RECORD";

        [JsonProperty("record")]
        public JToken Record { get; set; }
    }

    public class WebhookTriggerInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "ADD_RECORD";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "Added by Microsoft Flow. Settings should not be changed.";

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "TRIGGER_WEBHOOK_RECORD";
    }

    public class AddWebhookForUpdatingRecordInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "Added by Microsoft Flow. Settings should not be changed.";

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "TRIGGER_WEBHOOK_RECORD";
    }

    public class AddWebhookForDeletingRecordInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "Added by Microsoft Flow. Settings should not be changed.";

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "TRIGGER_WEBHOOK_RECORD";
    }

    public class AddWebhookForAddingRecordCommentInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "Added by Microsoft Flow. Settings should not be changed.";

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "TRIGGER_WEBHOOK_RECORD";
    }

    public class AddWebhookForUpdatingStatusInput
    {
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "Added by Microsoft Flow. Settings should not be changed.";

        [JsonProperty("schemaType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SchemaType { get; set; } = "TRIGGER_WEBHOOK_RECORD";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kintone;

    public partial class WorkflowManagedActions
    {
        public KintoneActions Kintone(string connectionId) => new KintoneActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KintoneTriggers Kintone(string connectionId) => new KintoneTriggers(connectionId);
    }
}