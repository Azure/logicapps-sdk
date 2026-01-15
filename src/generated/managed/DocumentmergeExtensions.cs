//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Documentmerge
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentmergeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentmerge")]
        public IBodyWorkflowAction<ValuesDocumentMergeResponse> ValuesDocumentMerge(Expression<Func<string>> linkToItem, Expression<Func<string>> preConfigTemplate = null, Expression<Func<string>> source = null, Expression<Func<string>> destination = null, Expression<Func<bool>> saveAsPDF = null, Expression<Func<bool>> saveAsPDFOnly = null, Expression<Func<bool>> saveAsPDFA = null, Expression<Func<bool>> displayImage = null, Expression<Func<string>> outputFileName = null, Expression<Func<bool>> overWrite = null, Expression<Func<bool>> sendMail = null, Expression<Func<string>> mailTemplate = null)
        {
            var apiCallPath = "/api/Values";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["LinkToItem"] = ExpressionConverter.Convert(linkToItem);
            if (preConfigTemplate != null)
                callPayload.Queries["PreConfigTemplate"] = ExpressionConverter.Convert(preConfigTemplate);
            if (source != null)
                callPayload.Queries["Source"] = ExpressionConverter.Convert(source);
            if (destination != null)
                callPayload.Queries["Destination"] = ExpressionConverter.Convert(destination);
            if (saveAsPDF != null)
                callPayload.Queries["SaveAsPDF"] = ExpressionConverter.Convert(saveAsPDF);
            if (saveAsPDFOnly != null)
                callPayload.Queries["SaveAsPDFOnly"] = ExpressionConverter.Convert(saveAsPDFOnly);
            if (saveAsPDFA != null)
                callPayload.Queries["SaveAsPDFA"] = ExpressionConverter.Convert(saveAsPDFA);
            if (displayImage != null)
                callPayload.Queries["DisplayImage"] = ExpressionConverter.Convert(displayImage);
            if (outputFileName != null)
                callPayload.Queries["OutputFileName"] = ExpressionConverter.Convert(outputFileName);
            if (overWrite != null)
                callPayload.Queries["OverWrite"] = ExpressionConverter.Convert(overWrite);
            if (sendMail != null)
                callPayload.Queries["SendMail"] = ExpressionConverter.Convert(sendMail);
            if (mailTemplate != null)
                callPayload.Queries["MailTemplate"] = ExpressionConverter.Convert(mailTemplate);
            return new ApiConnectionAction<ValuesDocumentMergeResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Documentmerge;

    public partial class WorkflowManagedActions
    {
        public DocumentmergeActions Documentmerge(string connectionId) => new DocumentmergeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentmergeTriggers Documentmerge(string connectionId) => new DocumentmergeTriggers(connectionId);
    }
}