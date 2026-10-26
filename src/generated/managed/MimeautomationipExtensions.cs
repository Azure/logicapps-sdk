//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mimeautomationip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MimeautomationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> ExtractFiles(Expression<Func<ExtractFilesInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MimeAutomation/ExtractFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        public IBodyWorkflowAction<MimeAttachment[], ApiConnectionActionConfiguration> ExtractFilesFromEml(Expression<Func<ExtractFilesFromEmlInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MimeAttachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MimeAutomation/ExtractFilesFromEml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class ExtractFilesInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class ExtractFilesFromEmlInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
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