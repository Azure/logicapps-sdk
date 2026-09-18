//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<ExtractInformationResponse> ExtractInformation([WorkflowExpression] Func<string> bodyimageFileContent = null)
        {
            SourceExpression.Validate(bodyimageFileContent, nameof(bodyimageFileContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["Image File Content"] = SourceExpressionConverter.ConvertToken(bodyimageFileContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<string> GenerateDocument([WorkflowExpression] Func<string> bodydocumentInformation, [WorkflowExpression] Func<string> bodydocumentTemplateContent)
        {
            SourceExpression.Validate(bodydocumentInformation, nameof(bodydocumentInformation), required: true);
            SourceExpression.Validate(bodydocumentTemplateContent, nameof(bodydocumentTemplateContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Flow/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentInformation"] = SourceExpressionConverter.ConvertToken(bodydocumentInformation);
                bodypropCount++;
                body["templateFile"] = SourceExpressionConverter.ConvertToken(bodydocumentTemplateContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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