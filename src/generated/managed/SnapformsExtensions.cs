//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Snapforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SnapformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "snapforms")]
        public IBodyWorkflowAction<TemporaryUrl, ApiConnectionActionConfiguration> TemporaryFileUrl(Expression<Func<string>> formSlug, Expression<Func<string>> responseId, Expression<Func<string>> fileKey)
        {
            var __workflow_formSlug = WorkflowExpression.Compile(formSlug, nameof(formSlug), required: true);
            var __workflow_responseId = WorkflowExpression.Compile(responseId, nameof(responseId), required: true);
            var __workflow_fileKey = WorkflowExpression.Compile(fileKey, nameof(fileKey), required: true);
            return new DeferredBodyAction<TemporaryUrl, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forms/{0}/responses/{1}/temporary-file-url/{2}", __workflow_formSlug.WithUrlEncoding(1), __workflow_responseId.WithUrlEncoding(1), __workflow_fileKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemporaryUrl>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "snapforms")]
        public IBodyWorkflowAction<TemporaryUrl, ApiConnectionActionConfiguration> TemporaryPdfUrl(Expression<Func<string>> formSlug, Expression<Func<string>> responseId)
        {
            var __workflow_formSlug = WorkflowExpression.Compile(formSlug, nameof(formSlug), required: true);
            var __workflow_responseId = WorkflowExpression.Compile(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<TemporaryUrl, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forms/{0}/responses/{1}/temporary-pdf-url", __workflow_formSlug.WithUrlEncoding(1), __workflow_responseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemporaryUrl>(callPayload);
            });
        }
    }

    public class SnapformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResource, ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<string>> formSlug, Expression<Func<WebhookTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formSlug = WorkflowExpression.Compile(formSlug, nameof(formSlug), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreationResource, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/forms/{0}/responses/hooks", __workflow_formSlug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreationResource>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TemporaryUrl
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("url")]
        public string FileURL { get; set; }
    }

    public class WebhookCreationResource
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class WebhookTriggerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "responses";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Snapforms;

    public partial class WorkflowManagedActions
    {
        public SnapformsActions Snapforms(string connectionId) => new SnapformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SnapformsTriggers Snapforms(string connectionId) => new SnapformsTriggers(connectionId);
    }
}