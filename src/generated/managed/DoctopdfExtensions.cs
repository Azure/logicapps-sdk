//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Doctopdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DoctopdfActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doctopdf")]
        [WorkflowExpressionFactory(nameof(__BuildDocToPDF))]
        public IBodyWorkflowAction<DocToPDFResponse> DocToPDF([WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<object> bodyfileContent = null, [WorkflowExpression] Func<string> publickey = null, [WorkflowExpression] Func<string> apikey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doctopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocToPDFResponse> __BuildDocToPDF(WorkflowExpression<string> bodyfileName = null, WorkflowExpression<object> bodyfileContent = null, WorkflowExpression<string> publickey = null, WorkflowExpression<string> apikey = null)
        {
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            WorkflowExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowExpression.Validate(publickey, nameof(publickey), required: false);
            WorkflowExpression.Validate(apikey, nameof(apikey), required: false);
            return new DeferredBodyAction<DocToPDFResponse>(() =>
            {
                var apiCallPath = "/api/doctopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["publickey"] = Convert.ToString("");
                if (publickey != null)
                    callPayload.Headers["publickey"] = ExpressionConverter.Convert(publickey);
                callPayload.Headers["apikey"] = Convert.ToString("");
                if (apikey != null)
                    callPayload.Headers["apikey"] = ExpressionConverter.Convert(apikey);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileName != null)
                {
                    body["File Name"] = ExpressionConverter.ConvertO(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["File Content"] = ExpressionConverter.ConvertO(bodyfileContent);
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