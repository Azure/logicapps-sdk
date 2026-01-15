//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Harnesspdfx
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HarnesspdfxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "harnesspdfx")]
        public IBodyWorkflowAction<PostPdfResponse> PostPdf(Expression<Func<object>> fileToProcess = null)
        {
            var apiCallPath = "/pdfs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PostPdfResponse>(callPayload);
        }
    }

    public class HarnesspdfxTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostPdfResponse
    {
        [JsonProperty("data")]
        public PostPdfResponseDataType Data { get; set; }
    }

    public class PostPdfResponseDataType
    {
        [JsonProperty("job_token")]
        public string JobToken { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Harnesspdfx;

    public partial class WorkflowManagedActions
    {
        public HarnesspdfxActions Harnesspdfx(string connectionId) => new HarnesspdfxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HarnesspdfxTriggers Harnesspdfx(string connectionId) => new HarnesspdfxTriggers(connectionId);
    }
}