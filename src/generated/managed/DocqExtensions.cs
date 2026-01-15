//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Docq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<ExtractInformationResponse> ExtractInformation(Expression<Func<string>> bodyimageFileContent = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docq")]
        public IBodyWorkflowAction<string> GenerateDocument(Expression<Func<string>> bodydocumentInformation, Expression<Func<string>> bodydocumentTemplateContent)
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
        }
    }

    public class DocqTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExtractInformationResponse
    {
        public string Summary { get; set; }
        public string Object { get; set; }
        public string ErrorDescription { get; set; }
        public bool IsSuccess { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Docq;

    public partial class WorkflowManagedActions
    {
        public DocqActions Docq(string connectionId) => new DocqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocqTriggers Docq(string connectionId) => new DocqTriggers(connectionId);
    }
}