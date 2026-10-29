//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<ExtractInformationResponse, ApiConnectionActionConfiguration> ExtractInformation(Expression<Func<ExtractInformationInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Flow/ExtractInformation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocument(Expression<Func<GenerateDocumentInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Flow/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class DocqTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExtractInformationResponse
    {
        public string Summary { get; set; }

        [JsonProperty("Object")]
        public string ObjectEntity { get; set; }
        public string ErrorDescription { get; set; }
        public bool IsSuccess { get; set; }
    }

    public class ExtractInformationInput
    {
        [JsonProperty("Image Content Type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ImageContentType { get; set; } = "image/jpeg";

        [JsonProperty("Image File Content")]
        public string ImageFileContent { get; set; }
    }

    public class GenerateDocumentInput
    {
        [JsonProperty("documentInformation", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentInformation { get; set; }

        [JsonProperty("templateFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentTemplateContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docq;

    public partial class WorkflowManagedActions
    {
        public DocqActions Docq(string connectionId) => new DocqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocqTriggers Docq(string connectionId) => new DocqTriggers(connectionId);
    }
}