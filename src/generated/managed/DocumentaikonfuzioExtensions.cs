//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentaikonfuzio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentaikonfuzioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IBodyWorkflowAction<V2DocsCreateResponse> V2DocsCreate(Expression<Func<object>> dataFile, Expression<Func<int>> project, Expression<Func<bool>> sync = null)
        {
            var apiCallPath = "/v2/docs/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<V2DocsCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IWorkflowAction V2DocsRead(Expression<Func<string>> doc)
        {
            var apiCallPath = String.Format("/v2/docs/{0}/", ExpressionConverter.ConvertWithUrlEncoding(doc, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IWorkflowAction V2DocsDelete(Expression<Func<string>> doc)
        {
            var apiCallPath = String.Format("/v2/docs/{0}/", ExpressionConverter.ConvertWithUrlEncoding(doc, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        public IWorkflowAction V2DocsPartialUpdate(Expression<Func<string>> doc)
        {
            var apiCallPath = String.Format("/v2/docs/{0}/", ExpressionConverter.ConvertWithUrlEncoding(doc, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class DocumentaikonfuzioTriggers([ConnectionName] string connectionId)
    {
    }

    public class V2DocsCreateResponse
    {
        [JsonProperty("data_file")]
        public string DataFile { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("project")]
        public int Project { get; set; }

        [JsonProperty("data_file_name")]
        public string DataFileName { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("sync")]
        public bool Sync { get; set; }

        [JsonProperty("extraction_url")]
        public string ExtractionUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentaikonfuzio;

    public partial class WorkflowManagedActions
    {
        public DocumentaikonfuzioActions Documentaikonfuzio(string connectionId) => new DocumentaikonfuzioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentaikonfuzioTriggers Documentaikonfuzio(string connectionId) => new DocumentaikonfuzioTriggers(connectionId);
    }
}