//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentmerge
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DocumentmergeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentmerge")]
        public IBodyWorkflowAction<ValuesDocumentMergeResponse> ValuesDocumentMerge(Expression<Func<string>> linkToItem, Expression<Func<string>> preConfigTemplate = null, Expression<Func<string>> source = null, Expression<Func<string>> destination = null, Expression<Func<bool>> saveAsPDF = null, Expression<Func<bool>> saveAsPDFOnly = null, Expression<Func<bool>> saveAsPDFA = null, Expression<Func<bool>> displayImage = null, Expression<Func<string>> outputFileName = null, Expression<Func<bool>> overWrite = null, Expression<Func<bool>> sendMail = null, Expression<Func<string>> mailTemplate = null)
        {
            var __workflow_linkToItem = linkToItem == null ? null : WorkflowExpression.Compile(linkToItem);
            WorkflowExpression.Validate(__workflow_linkToItem, nameof(linkToItem), required: true);
            var __workflow_preConfigTemplate = preConfigTemplate == null ? null : WorkflowExpression.Compile(preConfigTemplate);
            WorkflowExpression.Validate(__workflow_preConfigTemplate, nameof(preConfigTemplate), required: false);
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: false);
            var __workflow_destination = destination == null ? null : WorkflowExpression.Compile(destination);
            WorkflowExpression.Validate(__workflow_destination, nameof(destination), required: false);
            var __workflow_saveAsPDF = saveAsPDF == null ? null : WorkflowExpression.Compile(saveAsPDF);
            WorkflowExpression.Validate(__workflow_saveAsPDF, nameof(saveAsPDF), required: false);
            var __workflow_saveAsPDFOnly = saveAsPDFOnly == null ? null : WorkflowExpression.Compile(saveAsPDFOnly);
            WorkflowExpression.Validate(__workflow_saveAsPDFOnly, nameof(saveAsPDFOnly), required: false);
            var __workflow_saveAsPDFA = saveAsPDFA == null ? null : WorkflowExpression.Compile(saveAsPDFA);
            WorkflowExpression.Validate(__workflow_saveAsPDFA, nameof(saveAsPDFA), required: false);
            var __workflow_displayImage = displayImage == null ? null : WorkflowExpression.Compile(displayImage);
            WorkflowExpression.Validate(__workflow_displayImage, nameof(displayImage), required: false);
            var __workflow_outputFileName = outputFileName == null ? null : WorkflowExpression.Compile(outputFileName);
            WorkflowExpression.Validate(__workflow_outputFileName, nameof(outputFileName), required: false);
            var __workflow_overWrite = overWrite == null ? null : WorkflowExpression.Compile(overWrite);
            WorkflowExpression.Validate(__workflow_overWrite, nameof(overWrite), required: false);
            var __workflow_sendMail = sendMail == null ? null : WorkflowExpression.Compile(sendMail);
            WorkflowExpression.Validate(__workflow_sendMail, nameof(sendMail), required: false);
            var __workflow_mailTemplate = mailTemplate == null ? null : WorkflowExpression.Compile(mailTemplate);
            WorkflowExpression.Validate(__workflow_mailTemplate, nameof(mailTemplate), required: false);
            return new DeferredBodyAction<ValuesDocumentMergeResponse>(() =>
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
