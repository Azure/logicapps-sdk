//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfblocksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeDocumentsArray(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/merge_documents/array";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class PdfblocksTriggers([ConnectionName] string connectionId)
    {
    }

    public class BodyInput
    {
        public BodyInput(BodyInputDocumentsTypeItem[] documents)
        {
            this.Documents = documents;
        }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class BodyInputDocumentsTypeItem
    {
        public BodyInputDocumentsTypeItem(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent)
        {
            this.FileContent = fileContent;
        }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks;

    public partial class WorkflowManagedActions
    {
        public PdfblocksActions Pdfblocks(string connectionId) => new PdfblocksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdfblocksTriggers Pdfblocks(string connectionId) => new PdfblocksTriggers(connectionId);
    }
}