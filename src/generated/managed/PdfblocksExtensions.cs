//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfblocks
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfblocksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfblocks")]
        public IBodyWorkflowAction<string> MergeDocumentsArray([WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments)
        {
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/merge_documents/array";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class PdfblocksTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

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