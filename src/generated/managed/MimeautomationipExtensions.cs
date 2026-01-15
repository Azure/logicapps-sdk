//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Mimeautomationip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MimeautomationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        public IBodyWorkflowAction<Attachment[]> ExtractFiles(Expression<Func<string>> bodycontent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mimeautomationip")]
        public IBodyWorkflowAction<MimeAttachment[]> ExtractFilesFromEml(Expression<Func<string>> bodycontent)
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
    using Microsoft.Azure.Workflows.Sdk.Mimeautomationip;

    public partial class WorkflowManagedActions
    {
        public MimeautomationipActions Mimeautomationip(string connectionId) => new MimeautomationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MimeautomationipTriggers Mimeautomationip(string connectionId) => new MimeautomationipTriggers(connectionId);
    }
}