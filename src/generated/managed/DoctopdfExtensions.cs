//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Doctopdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DoctopdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doctopdf")]
        public IBodyWorkflowAction<DocToPDFResponse, ApiConnectionActionConfiguration> DocToPDF(Expression<Func<string>> bodyfileName = null, Expression<Func<object>> bodyfileContent = null, Expression<Func<string>> publickey = null, Expression<Func<string>> apikey = null)
        {
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_publickey = WorkflowExpression.Compile(publickey, nameof(publickey), required: false);
            var __workflow_apikey = WorkflowExpression.Compile(apikey, nameof(apikey), required: false);
            return new DeferredBodyAction<DocToPDFResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/doctopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["publickey"] = Convert.ToString("");
                if (__workflow_publickey != null)
                    callPayload.Headers["publickey"] = ExpressionConverter.Convert(__workflow_publickey);
                callPayload.Headers["apikey"] = Convert.ToString("");
                if (__workflow_apikey != null)
                    callPayload.Headers["apikey"] = ExpressionConverter.Convert(__workflow_apikey);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileName != null)
                {
                    body["File Name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileContent != null)
                {
                    body["File Content"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocToPDFResponse>(callPayload);
            });
        }
    }

    public class DoctopdfTriggers([ConnectionName] string connectionId)
    {
    }

    public class DocToPDFResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("File Name")]
        public string FileName { get; set; }

        [JsonProperty("File Content")]
        public JToken FileContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Doctopdf;

    public partial class WorkflowManagedActions
    {
        public DoctopdfActions Doctopdf(string connectionId) => new DoctopdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DoctopdfTriggers Doctopdf(string connectionId) => new DoctopdfTriggers(connectionId);
    }
}