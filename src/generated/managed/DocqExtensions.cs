//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocqActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        [WorkflowExpressionFactory(nameof(__BuildExtractInformation))]
        public IBodyWorkflowAction<ExtractInformationResponse> ExtractInformation([WorkflowExpression] Func<string> bodyimageFileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtractInformationResponse> __BuildExtractInformation(WorkflowExpression<string> bodyimageFileContent = null)
        {
            WorkflowExpression.Validate(bodyimageFileContent, nameof(bodyimageFileContent), required: false);
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
                if (bodyimageFileContent != null)
                {
                    body["Image File Content"] = ExpressionConverter.ConvertO(bodyimageFileContent);
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
        [WorkflowExpressionFactory(nameof(__BuildGenerateDocument))]
        public IBodyWorkflowAction<string> GenerateDocument([WorkflowExpression] Func<string> bodydocumentInformation, [WorkflowExpression] Func<string> bodydocumentTemplateContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateDocument(WorkflowExpression<string> bodydocumentInformation, WorkflowExpression<string> bodydocumentTemplateContent)
        {
            WorkflowExpression.Validate(bodydocumentInformation, nameof(bodydocumentInformation), required: true);
            WorkflowExpression.Validate(bodydocumentTemplateContent, nameof(bodydocumentTemplateContent), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Flow/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentInformation"] = ExpressionConverter.ConvertO(bodydocumentInformation);
                bodypropCount++;
                body["templateFile"] = ExpressionConverter.ConvertO(bodydocumentTemplateContent);
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