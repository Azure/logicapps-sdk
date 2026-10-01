//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Doctopdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DoctopdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doctopdf")]
        public IBodyWorkflowAction<DocToPDFResponse> DocToPDF([WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<object> bodyfileContent = null, [WorkflowExpression] Func<string> publickey = null, [WorkflowExpression] Func<string> apikey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/doctopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["publickey"] = Convert.ToString("");
                if (publickey != null)
                    callPayload.Headers["publickey"] = SourceExpressionConverter.ConvertO(publickey);
                callPayload.Headers["apikey"] = Convert.ToString("");
                if (apikey != null)
                    callPayload.Headers["apikey"] = SourceExpressionConverter.ConvertO(apikey);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileName != null)
                {
                    body["File Name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["File Content"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocToPDFResponse>(BuildSourceInput);
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