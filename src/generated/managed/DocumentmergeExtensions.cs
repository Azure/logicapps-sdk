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
        public IBodyWorkflowAction<ValuesDocumentMergeResponse> ValuesDocumentMerge(Expression<Func<string>> linkToItem, Expression<Func<string>> preConfigTemplate = null, Expression<Func<string>> source = null, Expression<Func<string>> destination = null, Expression<Func<bool>> saveAsPDF = null, Expression<Func<bool>> saveAsPDFOnly = null, Expression<Func<bool>> saveAsPDFA = null, Expression<Func<bool>> displayImage = null, Expression<Func<string>> outputFileName = null, Expression<Func<bool>> overWrite = null, Expression<Func<bool>> sendMail = null, Expression<Func<string>> mailTemplate = null)
        {
            var apiCallPath = "/api/Values";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["LinkToItem"] = CSharpExpressionConverter.ConvertO(linkToItem);
            if (preConfigTemplate != null)
                callPayload.Queries["PreConfigTemplate"] = CSharpExpressionConverter.ConvertO(preConfigTemplate);
            if (source != null)
                callPayload.Queries["Source"] = CSharpExpressionConverter.ConvertO(source);
            if (destination != null)
                callPayload.Queries["Destination"] = CSharpExpressionConverter.ConvertO(destination);
            if (saveAsPDF != null)
                callPayload.Queries["SaveAsPDF"] = CSharpExpressionConverter.ConvertO(saveAsPDF);
            if (saveAsPDFOnly != null)
                callPayload.Queries["SaveAsPDFOnly"] = CSharpExpressionConverter.ConvertO(saveAsPDFOnly);
            if (saveAsPDFA != null)
                callPayload.Queries["SaveAsPDFA"] = CSharpExpressionConverter.ConvertO(saveAsPDFA);
            if (displayImage != null)
                callPayload.Queries["DisplayImage"] = CSharpExpressionConverter.ConvertO(displayImage);
            if (outputFileName != null)
                callPayload.Queries["OutputFileName"] = CSharpExpressionConverter.ConvertO(outputFileName);
            if (overWrite != null)
                callPayload.Queries["OverWrite"] = CSharpExpressionConverter.ConvertO(overWrite);
            if (sendMail != null)
                callPayload.Queries["SendMail"] = CSharpExpressionConverter.ConvertO(sendMail);
            if (mailTemplate != null)
                callPayload.Queries["MailTemplate"] = CSharpExpressionConverter.ConvertO(mailTemplate);
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