//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfcross
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcrossActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> MergePDF([WorkflowExpression] Func<string[]> filesfileContent)
        {
            var apiCallPath = "/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var files = new JObject();
            var filespropCount = 0;
            filespropCount++;
            files["fileContent"] = ExpressionConverter.ConvertO(filesfileContent);
            if (filespropCount > 0)
            {
                callPayload.Body = files;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddWatermarkText([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> filewatermarkText)
        {
            var apiCallPath = "/watermark_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var file = new JObject();
            var filepropCount = 0;
            filepropCount++;
            file["fileContent"] = ExpressionConverter.ConvertO(filefileContent);
            filepropCount++;
            file["watermarkText"] = ExpressionConverter.ConvertO(filewatermarkText);
            if (filepropCount > 0)
            {
                callPayload.Body = file;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddPassword([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> filepassword)
        {
            var apiCallPath = "/password";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var file = new JObject();
            var filepropCount = 0;
            filepropCount++;
            file["fileContent"] = ExpressionConverter.ConvertO(filefileContent);
            filepropCount++;
            file["password"] = ExpressionConverter.ConvertO(filepassword);
            if (filepropCount > 0)
            {
                callPayload.Body = file;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddImage([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> fileimageContent, [WorkflowExpression] Func<double> filepositionX, [WorkflowExpression] Func<double> filepositionY, [WorkflowExpression] Func<string> fileaddType, [WorkflowExpression] Func<double> filefromPage = null, [WorkflowExpression] Func<double> filetoPage = null)
        {
            var apiCallPath = "/image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var file = new JObject();
            var filepropCount = 0;
            filepropCount++;
            file["fileContent"] = ExpressionConverter.ConvertO(filefileContent);
            filepropCount++;
            file["imageContent"] = ExpressionConverter.ConvertO(fileimageContent);
            filepropCount++;
            file["positionX"] = ExpressionConverter.ConvertO(filepositionX);
            filepropCount++;
            file["positionY"] = ExpressionConverter.ConvertO(filepositionY);
            filepropCount++;
            file["addType"] = ExpressionConverter.ConvertO(fileaddType);
            if (filefromPage != null)
            {
                file["fromPage"] = ExpressionConverter.ConvertO(filefromPage);
                filepropCount++;
            }

            if (filetoPage != null)
            {
                file["toPage"] = ExpressionConverter.ConvertO(filetoPage);
                filepropCount++;
            }

            if (filepropCount > 0)
            {
                callPayload.Body = file;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class PdfcrossTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfcross;

    public partial class WorkflowManagedActions
    {
        public PdfcrossActions Pdfcross(string connectionId) => new PdfcrossActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdfcrossTriggers Pdfcross(string connectionId) => new PdfcrossTriggers(connectionId);
    }
}