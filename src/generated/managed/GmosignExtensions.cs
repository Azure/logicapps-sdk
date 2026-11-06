//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gmosign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GmosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmosign")]
        public IBodyWorkflowAction<GetDocumentsResponse, ApiConnectionActionConfiguration> GetDocuments(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customer/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["download_type"] = Convert.ToString(2);
                callPayload.Queries["operation"] = Convert.ToString(1);
                return new ApiConnectionAction<GetDocumentsResponse>(callPayload);
            });
        }
    }

    public class GmosignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateHookEnvelopeResponse, ApiConnectionPollingTriggerConfiguration> CreateHookEnvelope(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CreateHookEnvelopeResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/customer/connect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<CreateHookEnvelopeResponse>(callPayload);
            });
        }
    }

    public class GetDocumentsResponse
    {
        [JsonProperty("downloadedDocument")]
        public string DownloadedDocument { get; set; }
    }

    public class CreateHookEnvelopeResponse
    {
        [JsonProperty("cus_id")]
        public string CustomerId { get; set; }

        [JsonProperty("connect_id")]
        public string ConnectionId { get; set; }

        [JsonProperty("envelopeEvents")]
        public string EnvelopeStatus { get; set; }

        [JsonProperty("urlToPublishTo")]
        public string WebhookURL { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("updated_at")]
        public string LastUpdate { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionTitle { get; set; }

        [JsonProperty("urlToPublishTo", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("envelopeEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EnvelopeStatus { get; set; } = "Completed";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gmosign;

    public partial class WorkflowManagedActions
    {
        public GmosignActions Gmosign(string connectionId) => new GmosignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GmosignTriggers Gmosign(string connectionId) => new GmosignTriggers(connectionId);
    }
}