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
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument([WorkflowExpression] Func<string> parserId, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> remoteId = null)
        {
            SourceExpression.Validate(parserId, nameof(parserId), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(remoteId, nameof(remoteId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/upload/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parserId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (remoteId != null)
                    callPayload.Queries["remote_id"] = SourceExpressionConverter.ConvertO(remoteId);
                return callPayload;
            }

            return new ApiConnectionAction<UploadDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docparser")]
        public IBodyWorkflowAction<FetchDocumentResponse> FetchDocument([WorkflowExpression] Func<string> parserId, [WorkflowExpression] Func<string> url, [WorkflowExpression] Func<string> remoteId = null)
        {
            SourceExpression.Validate(parserId, nameof(parserId), required: true);
            SourceExpression.Validate(url, nameof(url), required: true);
            SourceExpression.Validate(remoteId, nameof(remoteId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/fetch/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parserId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (remoteId != null)
                    callPayload.Queries["remote_id"] = SourceExpressionConverter.ConvertO(remoteId);
                return callPayload;
            }

            return new ApiConnectionAction<FetchDocumentResponse>(BuildSourceInput);
        }
    }

    public class DocparserTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreateReponse> WebhookCreate([WorkflowExpression] Func<string> parserId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(parserId, nameof(parserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhook/subscribe/{0}/flow", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parserId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookCreateReponse>(BuildSourceInput, triggerName, recurrence);
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