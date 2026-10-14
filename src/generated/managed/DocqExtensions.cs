//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DocqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<ExtractInformationResponse> ExtractInformation(Expression<Func<string>> bodyimageFileContent = null)
        {
            var __workflow_bodyimageFileContent = bodyimageFileContent == null ? null : WorkflowExpression.Compile(bodyimageFileContent);
            WorkflowExpression.Validate(__workflow_bodyimageFileContent, nameof(bodyimageFileContent), required: false);
            return new DeferredBodyAction<ExtractInformationResponse>(() =>
            {
                var apiCallPath = "/api/Flow/ExtractInformation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["Image Content Type"] = "image/jpeg";
                bodypropCount++;
                if (__workflow_bodyimageFileContent != null)
                {
                    body["Image File Content"] = ExpressionConverter.ConvertO(__workflow_bodyimageFileContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<string> GenerateDocument(Expression<Func<string>> bodydocumentInformation, Expression<Func<string>> bodydocumentTemplateContent)
        {
            var __workflow_bodydocumentInformation = bodydocumentInformation == null ? null : WorkflowExpression.Compile(bodydocumentInformation);
            WorkflowExpression.Validate(__workflow_bodydocumentInformation, nameof(bodydocumentInformation), required: true);
            var __workflow_bodydocumentTemplateContent = bodydocumentTemplateContent == null ? null : WorkflowExpression.Compile(bodydocumentTemplateContent);
            WorkflowExpression.Validate(__workflow_bodydocumentTemplateContent, nameof(bodydocumentTemplateContent), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Flow/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentInformation"] = ExpressionConverter.ConvertO(__workflow_bodydocumentInformation);
                bodypropCount++;
                body["templateFile"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTemplateContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
