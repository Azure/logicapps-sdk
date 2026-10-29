//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentmerge
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentmergeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentmerge")]
        public IBodyWorkflowAction<ValuesDocumentMergeResponse, ApiConnectionActionConfiguration> ValuesDocumentMerge(Expression<Func<string>> linkToItem, Expression<Func<string>> preConfigTemplate = null, Expression<Func<string>> source = null, Expression<Func<string>> destination = null, Expression<Func<bool>> saveAsPDF = null, Expression<Func<bool>> saveAsPDFOnly = null, Expression<Func<bool>> saveAsPDFA = null, Expression<Func<bool>> displayImage = null, Expression<Func<string>> outputFileName = null, Expression<Func<bool>> overWrite = null, Expression<Func<bool>> sendMail = null, Expression<Func<string>> mailTemplate = null)
        {
            var __workflow_linkToItem = WorkflowExpression.Compile(linkToItem, nameof(linkToItem), required: true);
            var __workflow_preConfigTemplate = WorkflowExpression.Compile(preConfigTemplate, nameof(preConfigTemplate), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: false);
            var __workflow_saveAsPDF = WorkflowExpression.Compile(saveAsPDF, nameof(saveAsPDF), required: false);
            var __workflow_saveAsPDFOnly = WorkflowExpression.Compile(saveAsPDFOnly, nameof(saveAsPDFOnly), required: false);
            var __workflow_saveAsPDFA = WorkflowExpression.Compile(saveAsPDFA, nameof(saveAsPDFA), required: false);
            var __workflow_displayImage = WorkflowExpression.Compile(displayImage, nameof(displayImage), required: false);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_overWrite = WorkflowExpression.Compile(overWrite, nameof(overWrite), required: false);
            var __workflow_sendMail = WorkflowExpression.Compile(sendMail, nameof(sendMail), required: false);
            var __workflow_mailTemplate = WorkflowExpression.Compile(mailTemplate, nameof(mailTemplate), required: false);
            return new DeferredBodyAction<ValuesDocumentMergeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Values";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["LinkToItem"] = ExpressionConverter.Convert(__workflow_linkToItem);
                if (__workflow_preConfigTemplate != null)
                    callPayload.Queries["PreConfigTemplate"] = ExpressionConverter.Convert(__workflow_preConfigTemplate);
                if (__workflow_source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_destination != null)
                    callPayload.Queries["Destination"] = ExpressionConverter.Convert(__workflow_destination);
                if (__workflow_saveAsPDF != null)
                    callPayload.Queries["SaveAsPDF"] = ExpressionConverter.Convert(__workflow_saveAsPDF);
                if (__workflow_saveAsPDFOnly != null)
                    callPayload.Queries["SaveAsPDFOnly"] = ExpressionConverter.Convert(__workflow_saveAsPDFOnly);
                if (__workflow_saveAsPDFA != null)
                    callPayload.Queries["SaveAsPDFA"] = ExpressionConverter.Convert(__workflow_saveAsPDFA);
                if (__workflow_displayImage != null)
                    callPayload.Queries["DisplayImage"] = ExpressionConverter.Convert(__workflow_displayImage);
                if (__workflow_outputFileName != null)
                    callPayload.Queries["OutputFileName"] = ExpressionConverter.Convert(__workflow_outputFileName);
                if (__workflow_overWrite != null)
                    callPayload.Queries["OverWrite"] = ExpressionConverter.Convert(__workflow_overWrite);
                if (__workflow_sendMail != null)
                    callPayload.Queries["SendMail"] = ExpressionConverter.Convert(__workflow_sendMail);
                if (__workflow_mailTemplate != null)
                    callPayload.Queries["MailTemplate"] = ExpressionConverter.Convert(__workflow_mailTemplate);
                return new ApiConnectionAction<ValuesDocumentMergeResponse>(callPayload);
            });
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
