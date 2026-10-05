//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentaikonfuzio
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentaikonfuzioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        [WorkflowExpressionFactory(nameof(__BuildDocsCreate))]
        public IBodyWorkflowAction<V2DocsCreateResponse> DocsCreate([WorkflowExpression] Func<object> dataFile, [WorkflowExpression] Func<int> project, [WorkflowExpression] Func<bool> sync = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<V2DocsCreateResponse> __BuildDocsCreate(WorkflowValue<object> dataFile, WorkflowValue<int> project, WorkflowValue<bool> sync = null)
        {
            WorkflowValue.Validate(dataFile, nameof(dataFile), required: true);
            WorkflowValue.Validate(project, nameof(project), required: true);
            WorkflowValue.Validate(sync, nameof(sync), required: false);
            return new DeferredBodyAction<V2DocsCreateResponse>(() =>
            {
                var apiCallPath = "/v2/docs/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2DocsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        [WorkflowExpressionFactory(nameof(__BuildDocsDelete))]
        public IWorkflowAction DocsDelete([WorkflowExpression] Func<string> doc)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDocsDelete(WorkflowValue<string> doc)
        {
            WorkflowValue.Validate(doc, nameof(doc), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/docs/{0}/", ExpressionConverter.ConvertWithUrlEncoding(doc, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        [WorkflowExpressionFactory(nameof(__BuildDocsPartialUpdate))]
        public IWorkflowAction DocsPartialUpdate([WorkflowExpression] Func<string> doc)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDocsPartialUpdate(WorkflowValue<string> doc)
        {
            WorkflowValue.Validate(doc, nameof(doc), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/docs/{0}/", ExpressionConverter.ConvertWithUrlEncoding(doc, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentaikonfuzio")]
        [WorkflowExpressionFactory(nameof(__BuildDocsRead))]
        public IWorkflowAction DocsRead([WorkflowExpression] Func<string> doc)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDocsRead(WorkflowValue<string> doc)
        {
            WorkflowValue.Validate(doc, nameof(doc), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/docs/{0}/", ExpressionConverter.ConvertWithUrlEncoding(doc, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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

namespace Microsoft.Azure.Workflows.Sdk
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
