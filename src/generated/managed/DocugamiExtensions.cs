//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docugami
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocugamiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugami")]
        public IBodyWorkflowAction<DocsetListResponse, ApiConnectionActionConfiguration> DocsetList(Expression<Func<string>> xDocugamiOrganizationId)
        {
            var __workflow_xDocugamiOrganizationId = WorkflowExpression.Compile(xDocugamiOrganizationId, nameof(xDocugamiOrganizationId), required: true);
            return new DeferredBodyAction<DocsetListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1preview1/docsets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-docugami-organization-id"] = ExpressionConverter.Convert(__workflow_xDocugamiOrganizationId);
                return new ApiConnectionAction<DocsetListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugami")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadArtifact(Expression<Func<string>> xDocugamiOrganizationId, Expression<Func<string>> projectId, Expression<Func<string>> artifactVersion, Expression<Func<string>> artifactId)
        {
            var __workflow_xDocugamiOrganizationId = WorkflowExpression.Compile(xDocugamiOrganizationId, nameof(xDocugamiOrganizationId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_artifactVersion = WorkflowExpression.Compile(artifactVersion, nameof(artifactVersion), required: true);
            var __workflow_artifactId = WorkflowExpression.Compile(artifactId, nameof(artifactId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1preview1/projects/{0}/artifacts/{1}/{2}/content", __workflow_projectId.WithUrlEncoding(1), __workflow_artifactVersion.WithUrlEncoding(1), __workflow_artifactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-docugami-organization-id"] = ExpressionConverter.Convert(__workflow_xDocugamiOrganizationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugami")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnregisterWebhook(Expression<Func<string>> webhookId, Expression<Func<string>> xDocugamiOrganizationId)
        {
            var __workflow_webhookId = WorkflowExpression.Compile(webhookId, nameof(webhookId), required: true);
            var __workflow_xDocugamiOrganizationId = WorkflowExpression.Compile(xDocugamiOrganizationId, nameof(xDocugamiOrganizationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1preview1/webhooks/{0}", __workflow_webhookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-docugami-organization-id"] = ExpressionConverter.Convert(__workflow_xDocugamiOrganizationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docugami")]
        public IBodyWorkflowAction<ListDocumentsResponse, ApiConnectionActionConfiguration> ListDocuments(Expression<Func<string>> xDocugamiOrganizationId, Expression<Func<string>> docsetId)
        {
            var __workflow_xDocugamiOrganizationId = WorkflowExpression.Compile(xDocugamiOrganizationId, nameof(xDocugamiOrganizationId), required: true);
            var __workflow_docsetId = WorkflowExpression.Compile(docsetId, nameof(docsetId), required: true);
            return new DeferredBodyAction<ListDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1preview1/docsets/{0}/documents", __workflow_docsetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-docugami-organization-id"] = ExpressionConverter.Convert(__workflow_xDocugamiOrganizationId);
                return new ApiConnectionAction<ListDocumentsResponse>(callPayload);
            });
        }
    }

    public class DocugamiTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RegisterWebhookResponse, ApiConnectionPollingTriggerConfiguration> RegisterWebhook(Expression<Func<string>> xDocugamiOrganizationId, Expression<Func<BodyInput>> body)
        {
            var __workflow_xDocugamiOrganizationId = WorkflowExpression.Compile(xDocugamiOrganizationId, nameof(xDocugamiOrganizationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<RegisterWebhookResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1preview1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-docugami-organization-id"] = ExpressionConverter.Convert(__workflow_xDocugamiOrganizationId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<RegisterWebhookResponse>(callPayload);
            });
        }
    }

    public class DocsetListResponse
    {
        [JsonProperty("docsets")]
        public DocsetListResponseDocsetsTypeItem[] Docsets { get; set; }
    }

    public class DocsetListResponseDocsetsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("documentCount")]
        public int DocumentCount { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class ListDocumentsResponse
    {
        [JsonProperty("documents")]
        public ListDocumentsResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class ListDocumentsResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("processedAt")]
        public string ProcessedAt { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("docset")]
        public ListDocumentsResponseDocumentsTypeItemDocsetType Docset { get; set; }
    }

    public class ListDocumentsResponseDocumentsTypeItemDocsetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("dgmlUrl")]
        public string DgmlUrl { get; set; }
    }

    public class RegisterWebhookResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookUrl { get; set; }

        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(string targetId)
        {
            this.TargetId = targetId;
        }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "Project";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("targetId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetId { get; set; }

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] Events { get; set; } = new string[]
        {
            "Project.Artifacts.Create",
            "Project.Artifacts.Modify"
        };
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docugami;

    public partial class WorkflowManagedActions
    {
        public DocugamiActions Docugami(string connectionId) => new DocugamiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocugamiTriggers Docugami(string connectionId) => new DocugamiTriggers(connectionId);
    }
}