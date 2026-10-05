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
        [WorkflowExpressionFactory(nameof(__BuildMergePDF))]
        public IBodyWorkflowAction<string> MergePDF([WorkflowExpression] Func<string[]> filesfileContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergePDF(WorkflowValue<string[]> filesfileContent)
        {
            WorkflowValue.Validate(filesfileContent, nameof(filesfileContent), required: true);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        [WorkflowExpressionFactory(nameof(__BuildAddWatermarkText))]
        public IBodyWorkflowAction<string> AddWatermarkText([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> filewatermarkText)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddWatermarkText(WorkflowValue<string> filefileContent, WorkflowValue<string> filewatermarkText)
        {
            WorkflowValue.Validate(filefileContent, nameof(filefileContent), required: true);
            WorkflowValue.Validate(filewatermarkText, nameof(filewatermarkText), required: true);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        [WorkflowExpressionFactory(nameof(__BuildAddPassword))]
        public IBodyWorkflowAction<string> AddPassword([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> filepassword)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddPassword(WorkflowValue<string> filefileContent, WorkflowValue<string> filepassword)
        {
            WorkflowValue.Validate(filefileContent, nameof(filefileContent), required: true);
            WorkflowValue.Validate(filepassword, nameof(filepassword), required: true);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        [WorkflowExpressionFactory(nameof(__BuildAddImage))]
        public IBodyWorkflowAction<string> AddImage([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> fileimageContent, [WorkflowExpression] Func<double> filepositionX, [WorkflowExpression] Func<double> filepositionY, [WorkflowExpression] Func<string> fileaddType, [WorkflowExpression] Func<double> filefromPage = null, [WorkflowExpression] Func<double> filetoPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddImage(WorkflowValue<string> filefileContent, WorkflowValue<string> fileimageContent, WorkflowValue<double> filepositionX, WorkflowValue<double> filepositionY, WorkflowValue<string> fileaddType, WorkflowValue<double> filefromPage = null, WorkflowValue<double> filetoPage = null)
        {
            WorkflowValue.Validate(filefileContent, nameof(filefileContent), required: true);
            WorkflowValue.Validate(fileimageContent, nameof(fileimageContent), required: true);
            WorkflowValue.Validate(filepositionX, nameof(filepositionX), required: true);
            WorkflowValue.Validate(filepositionY, nameof(filepositionY), required: true);
            WorkflowValue.Validate(fileaddType, nameof(fileaddType), required: true);
            WorkflowValue.Validate(filefromPage, nameof(filefromPage), required: false);
            WorkflowValue.Validate(filetoPage, nameof(filetoPage), required: false);
            return new DeferredBodyAction<string>(() =>
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
