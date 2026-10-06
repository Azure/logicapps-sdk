//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mimeautomationip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MimeautomationipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFiles))]
        public IBodyWorkflowAction<Attachment[]> ExtractFiles([WorkflowExpression] Func<string> bodycontent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Attachment[]> __BuildExtractFiles(WorkflowExpression<string> bodycontent)
        {
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            return new DeferredBodyAction<Attachment[]>(() =>
            {
                var apiCallPath = "/MimeAutomation/ExtractFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        [WorkflowExpressionFactory(nameof(__BuildExtractFilesFromEml))]
        public IBodyWorkflowAction<MimeAttachment[]> ExtractFilesFromEml([WorkflowExpression] Func<string> bodycontent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MimeAttachment[]> __BuildExtractFilesFromEml(WorkflowExpression<string> bodycontent)
        {
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            return new DeferredBodyAction<MimeAttachment[]>(() =>
            {
                var apiCallPath = "/MimeAutomation/ExtractFilesFromEml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MimeAttachment[]>(callPayload);
            });
        }
    }

    public class MimeautomationipTriggers([ConnectionName] string connectionId)
    {
    }

    public class Attachment
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class MimeAttachment
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mimeautomationip;

    public partial class WorkflowManagedActions
    {
        public MimeautomationipActions Mimeautomationip(string connectionId) => new MimeautomationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MimeautomationipTriggers Mimeautomationip(string connectionId) => new MimeautomationipTriggers(connectionId);
    }
}