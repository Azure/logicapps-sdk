//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfcross
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcrossActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> MergePDF(Expression<Func<string[]>> filesfileContent)
        {
            var apiCallPath = "/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var files = new JObject();
            var filespropCount = 0;
            filespropCount++;
            files["fileContent"] = CSharpExpressionConverter.ConvertToken(filesfileContent);
            if (filespropCount > 0)
            {
                callPayload.Body = files;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddWatermarkText(Expression<Func<string>> filefileContent, Expression<Func<string>> filewatermarkText)
        {
            var apiCallPath = "/watermark_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var file = new JObject();
            var filepropCount = 0;
            filepropCount++;
            file["fileContent"] = CSharpExpressionConverter.ConvertToken(filefileContent);
            filepropCount++;
            file["watermarkText"] = CSharpExpressionConverter.ConvertToken(filewatermarkText);
            if (filepropCount > 0)
            {
                callPayload.Body = file;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddPassword(Expression<Func<string>> filefileContent, Expression<Func<string>> filepassword)
        {
            var apiCallPath = "/password";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var file = new JObject();
            var filepropCount = 0;
            filepropCount++;
            file["fileContent"] = CSharpExpressionConverter.ConvertToken(filefileContent);
            filepropCount++;
            file["password"] = CSharpExpressionConverter.ConvertToken(filepassword);
            if (filepropCount > 0)
            {
                callPayload.Body = file;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddImage(Expression<Func<string>> filefileContent, Expression<Func<string>> fileimageContent, Expression<Func<double>> filepositionX, Expression<Func<double>> filepositionY, Expression<Func<string>> fileaddType, Expression<Func<double>> filefromPage = null, Expression<Func<double>> filetoPage = null)
        {
            var apiCallPath = "/image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var file = new JObject();
            var filepropCount = 0;
            filepropCount++;
            file["fileContent"] = CSharpExpressionConverter.ConvertToken(filefileContent);
            filepropCount++;
            file["imageContent"] = CSharpExpressionConverter.ConvertToken(fileimageContent);
            filepropCount++;
            file["positionX"] = CSharpExpressionConverter.ConvertToken(filepositionX);
            filepropCount++;
            file["positionY"] = CSharpExpressionConverter.ConvertToken(filepositionY);
            filepropCount++;
            file["addType"] = CSharpExpressionConverter.ConvertToken(fileaddType);
            if (filefromPage != null)
            {
                file["fromPage"] = CSharpExpressionConverter.ConvertToken(filefromPage);
                filepropCount++;
            }

            if (filetoPage != null)
            {
                file["toPage"] = CSharpExpressionConverter.ConvertToken(filetoPage);
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