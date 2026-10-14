//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfcross
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PdfcrossActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> MergePDF(Expression<Func<string[]>> filesfileContent)
        {
            var __workflow_filesfileContent = filesfileContent == null ? null : WorkflowExpression.Compile(filesfileContent);
            WorkflowExpression.Validate(__workflow_filesfileContent, nameof(filesfileContent), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var files = new JObject();
                var filespropCount = 0;
                filespropCount++;
                files["fileContent"] = ExpressionConverter.ConvertO(__workflow_filesfileContent);
                if (filespropCount > 0)
                {
                    callPayload.Body = files;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddWatermarkText(Expression<Func<string>> filefileContent, Expression<Func<string>> filewatermarkText)
        {
            var __workflow_filefileContent = filefileContent == null ? null : WorkflowExpression.Compile(filefileContent);
            WorkflowExpression.Validate(__workflow_filefileContent, nameof(filefileContent), required: true);
            var __workflow_filewatermarkText = filewatermarkText == null ? null : WorkflowExpression.Compile(filewatermarkText);
            WorkflowExpression.Validate(__workflow_filewatermarkText, nameof(filewatermarkText), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/watermark_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var file = new JObject();
                var filepropCount = 0;
                filepropCount++;
                file["fileContent"] = ExpressionConverter.ConvertO(__workflow_filefileContent);
                filepropCount++;
                file["watermarkText"] = ExpressionConverter.ConvertO(__workflow_filewatermarkText);
                if (filepropCount > 0)
                {
                    callPayload.Body = file;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddPassword(Expression<Func<string>> filefileContent, Expression<Func<string>> filepassword)
        {
            var __workflow_filefileContent = filefileContent == null ? null : WorkflowExpression.Compile(filefileContent);
            WorkflowExpression.Validate(__workflow_filefileContent, nameof(filefileContent), required: true);
            var __workflow_filepassword = filepassword == null ? null : WorkflowExpression.Compile(filepassword);
            WorkflowExpression.Validate(__workflow_filepassword, nameof(filepassword), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var file = new JObject();
                var filepropCount = 0;
                filepropCount++;
                file["fileContent"] = ExpressionConverter.ConvertO(__workflow_filefileContent);
                filepropCount++;
                file["password"] = ExpressionConverter.ConvertO(__workflow_filepassword);
                if (filepropCount > 0)
                {
                    callPayload.Body = file;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddImage(Expression<Func<string>> filefileContent, Expression<Func<string>> fileimageContent, Expression<Func<double>> filepositionX, Expression<Func<double>> filepositionY, Expression<Func<string>> fileaddType, Expression<Func<double>> filefromPage = null, Expression<Func<double>> filetoPage = null)
        {
            var __workflow_filefileContent = filefileContent == null ? null : WorkflowExpression.Compile(filefileContent);
            WorkflowExpression.Validate(__workflow_filefileContent, nameof(filefileContent), required: true);
            var __workflow_fileimageContent = fileimageContent == null ? null : WorkflowExpression.Compile(fileimageContent);
            WorkflowExpression.Validate(__workflow_fileimageContent, nameof(fileimageContent), required: true);
            var __workflow_filepositionX = filepositionX == null ? null : WorkflowExpression.Compile(filepositionX);
            WorkflowExpression.Validate(__workflow_filepositionX, nameof(filepositionX), required: true);
            var __workflow_filepositionY = filepositionY == null ? null : WorkflowExpression.Compile(filepositionY);
            WorkflowExpression.Validate(__workflow_filepositionY, nameof(filepositionY), required: true);
            var __workflow_fileaddType = fileaddType == null ? null : WorkflowExpression.Compile(fileaddType);
            WorkflowExpression.Validate(__workflow_fileaddType, nameof(fileaddType), required: true);
            var __workflow_filefromPage = filefromPage == null ? null : WorkflowExpression.Compile(filefromPage);
            WorkflowExpression.Validate(__workflow_filefromPage, nameof(filefromPage), required: false);
            var __workflow_filetoPage = filetoPage == null ? null : WorkflowExpression.Compile(filetoPage);
            WorkflowExpression.Validate(__workflow_filetoPage, nameof(filetoPage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var file = new JObject();
                var filepropCount = 0;
                filepropCount++;
                file["fileContent"] = ExpressionConverter.ConvertO(__workflow_filefileContent);
                filepropCount++;
                file["imageContent"] = ExpressionConverter.ConvertO(__workflow_fileimageContent);
                filepropCount++;
                file["positionX"] = ExpressionConverter.ConvertO(__workflow_filepositionX);
                filepropCount++;
                file["positionY"] = ExpressionConverter.ConvertO(__workflow_filepositionY);
                filepropCount++;
                file["addType"] = ExpressionConverter.ConvertO(__workflow_fileaddType);
                if (__workflow_filefromPage != null)
                {
                    file["fromPage"] = ExpressionConverter.ConvertO(__workflow_filefromPage);
                    filepropCount++;
                }

                if (__workflow_filetoPage != null)
                {
                    file["toPage"] = ExpressionConverter.ConvertO(__workflow_filetoPage);
                    filepropCount++;
                }

                if (filepropCount > 0)
                {
                    callPayload.Body = file;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
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
