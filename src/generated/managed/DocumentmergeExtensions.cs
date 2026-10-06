//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentmerge
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentmergeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentmerge")]
        public IBodyWorkflowAction<ValuesDocumentMergeResponse> ValuesDocumentMerge([WorkflowExpression] Func<string> linkToItem, [WorkflowExpression] Func<string> preConfigTemplate = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> destination = null, [WorkflowExpression] Func<bool> saveAsPDF = null, [WorkflowExpression] Func<bool> saveAsPDFOnly = null, [WorkflowExpression] Func<bool> saveAsPDFA = null, [WorkflowExpression] Func<bool> displayImage = null, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<bool> overWrite = null, [WorkflowExpression] Func<bool> sendMail = null, [WorkflowExpression] Func<string> mailTemplate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Values";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["LinkToItem"] = SourceExpressionConverter.ConvertO(linkToItem);
                if (preConfigTemplate != null)
                    callPayload.Queries["PreConfigTemplate"] = SourceExpressionConverter.ConvertO(preConfigTemplate);
                if (source != null)
                    callPayload.Queries["Source"] = SourceExpressionConverter.ConvertO(source);
                if (destination != null)
                    callPayload.Queries["Destination"] = SourceExpressionConverter.ConvertO(destination);
                if (saveAsPDF != null)
                    callPayload.Queries["SaveAsPDF"] = SourceExpressionConverter.ConvertO(saveAsPDF);
                if (saveAsPDFOnly != null)
                    callPayload.Queries["SaveAsPDFOnly"] = SourceExpressionConverter.ConvertO(saveAsPDFOnly);
                if (saveAsPDFA != null)
                    callPayload.Queries["SaveAsPDFA"] = SourceExpressionConverter.ConvertO(saveAsPDFA);
                if (displayImage != null)
                    callPayload.Queries["DisplayImage"] = SourceExpressionConverter.ConvertO(displayImage);
                if (outputFileName != null)
                    callPayload.Queries["OutputFileName"] = SourceExpressionConverter.ConvertO(outputFileName);
                if (overWrite != null)
                    callPayload.Queries["OverWrite"] = SourceExpressionConverter.ConvertO(overWrite);
                if (sendMail != null)
                    callPayload.Queries["SendMail"] = SourceExpressionConverter.ConvertO(sendMail);
                if (mailTemplate != null)
                    callPayload.Queries["MailTemplate"] = SourceExpressionConverter.ConvertO(mailTemplate);
                return callPayload;
            }

            return new ApiConnectionAction<ValuesDocumentMergeResponse>(BuildSourceInput);
        }
    }

    public class DocumentmergeTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValuesDocumentMergeResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        public string URL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentmerge;

    public partial class WorkflowManagedActions
    {
        public DocumentmergeActions Documentmerge(string connectionId) => new DocumentmergeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentmergeTriggers Documentmerge(string connectionId) => new DocumentmergeTriggers(connectionId);
    }
}