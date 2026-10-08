//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docparser
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocparserActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docparser")]
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument([WorkflowExpression] Func<string> parserId, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> remoteId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadDocumentResponse> __BuildUploadDocument(WorkflowExpression<string> parserId, WorkflowExpression<object> file, WorkflowExpression<string> remoteId = null)
        {
            WorkflowExpression.Validate(parserId, nameof(parserId), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(remoteId, nameof(remoteId), required: false);
            return new DeferredBodyAction<UploadDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/upload/{0}", ExpressionConverter.ConvertWithUrlEncoding(parserId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (remoteId != null)
                    callPayload.Queries["remote_id"] = ExpressionConverter.Convert(remoteId);
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docparser")]
        [WorkflowExpressionFactory(nameof(__BuildFetchDocument))]
        public IBodyWorkflowAction<FetchDocumentResponse> FetchDocument([WorkflowExpression] Func<string> parserId, [WorkflowExpression] Func<string> url, [WorkflowExpression] Func<string> remoteId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchDocumentResponse> __BuildFetchDocument(WorkflowExpression<string> parserId, WorkflowExpression<string> url, WorkflowExpression<string> remoteId = null)
        {
            WorkflowExpression.Validate(parserId, nameof(parserId), required: true);
            WorkflowExpression.Validate(url, nameof(url), required: true);
            WorkflowExpression.Validate(remoteId, nameof(remoteId), required: false);
            return new DeferredBodyAction<FetchDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/fetch/{0}", ExpressionConverter.ConvertWithUrlEncoding(parserId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (remoteId != null)
                    callPayload.Queries["remote_id"] = ExpressionConverter.Convert(remoteId);
                return new ApiConnectionAction<FetchDocumentResponse>(callPayload);
            });
        }
    }

    public class DocparserTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhookCreate))]
        public IBodyWorkflowTrigger<WebhookCreateReponse> WebhookCreate([WorkflowExpression] Func<string> parserId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookCreateReponse> __BuildWebhookCreate(WorkflowExpression<string> parserId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(parserId, nameof(parserId), required: true);
            return new DeferredBodyTrigger<WebhookCreateReponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/subscribe/{0}/flow", ExpressionConverter.ConvertWithUrlEncoding(parserId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var targetUrl = new JObject();
                var targetUrlpropCount = 0;
                targetUrl["target_url"] = "#{listCallbackUrl()}";
                targetUrlpropCount++;
                if (targetUrlpropCount > 0)
                {
                    callPayload.Body = targetUrl;
                }

                return new ApiConnectionTrigger<WebhookCreateReponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UploadDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("file_size")]
        public int Size { get; set; }

        [JsonProperty("quota_used")]
        public int QuotaUsed { get; set; }

        [JsonProperty("quota_left")]
        public int QuotaLeft { get; set; }

        [JsonProperty("quota_refill")]
        public string QuotaRefill { get; set; }
    }

    public class FetchDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("file_size")]
        public int Size { get; set; }

        [JsonProperty("quota_used")]
        public int QuotaUsed { get; set; }

        [JsonProperty("quota_left")]
        public int QuotaLeft { get; set; }

        [JsonProperty("quota_refill")]
        public string QuotaRefill { get; set; }
    }

    public class WebhookCreateReponse
    {
        [JsonProperty("webhook_id")]
        public string WebhookId { get; set; }

        [JsonProperty("parser_id")]
        public string ParserId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docparser;

    public partial class WorkflowManagedActions
    {
        public DocparserActions Docparser(string connectionId) => new DocparserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocparserTriggers Docparser(string connectionId) => new DocparserTriggers(connectionId);
    }
}