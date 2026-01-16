//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docparser
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocparserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docparser")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument(Expression<Func<string>> parserId, Expression<Func<object>> file, Expression<Func<string>> remoteId = null)
        {
            var apiCallPath = String.Format("/document/upload/{0}", ExpressionConverter.ConvertWithUrlEncoding(parserId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (remoteId != null)
                callPayload.Queries["remote_id"] = ExpressionConverter.Convert(remoteId);
            return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docparser")]
        public IBodyWorkflowAction<FetchDocumentResponse> FetchDocument(Expression<Func<string>> parserId, Expression<Func<string>> url, Expression<Func<string>> remoteId = null)
        {
            var apiCallPath = String.Format("/document/fetch/{0}", ExpressionConverter.ConvertWithUrlEncoding(parserId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = ExpressionConverter.Convert(url);
            if (remoteId != null)
                callPayload.Queries["remote_id"] = ExpressionConverter.Convert(remoteId);
            return new ApiConnectionAction<FetchDocumentResponse>(callPayload);
        }
    }

    public class DocparserTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<WebhookCreateReponse> WebhookCreate(Expression<Func<string>> parserId, string triggerName = null)
        {
            var apiCallPath = String.Format("/webhook/subscribe/{0}/flow", ExpressionConverter.ConvertWithUrlEncoding(parserId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var targetUrl = new JObject();
            var targetUrlpropCount = 0;
            targetUrl["target_url"] = "@listcallbackurl()";
            targetUrlpropCount++;
            if (targetUrlpropCount > 0)
            {
                callPayload.Body = targetUrl;
            }

            return new ApiConnectionTrigger<WebhookCreateReponse>(callPayload);
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