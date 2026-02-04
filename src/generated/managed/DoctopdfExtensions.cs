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
        public IBodyWorkflowAction<DocToPDFResponse> DocToPDF(Expression<Func<string>> bodyfileName = null, Expression<Func<object>> bodyfileContent = null, Expression<Func<string>> publickey = null, Expression<Func<string>> apikey = null)
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