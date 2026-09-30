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
        public IBodyWorkflowAction<string> MergePDF([WorkflowExpression] Func<string[]> filesfileContent)
        {
            SourceExpression.Validate(filesfileContent, nameof(filesfileContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var files = new JObject();
                var filespropCount = 0;
                filespropCount++;
                files["fileContent"] = SourceExpressionConverter.ConvertToken(filesfileContent);
                if (filespropCount > 0)
                {
                    callPayload.Body = files;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddWatermarkText([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> filewatermarkText)
        {
            SourceExpression.Validate(filefileContent, nameof(filefileContent), required: true);
            SourceExpression.Validate(filewatermarkText, nameof(filewatermarkText), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/watermark_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var @file = new JObject();
                var @filepropCount = 0;
                @filepropCount++;
                @file["fileContent"] = SourceExpressionConverter.ConvertToken(filefileContent);
                @filepropCount++;
                @file["watermarkText"] = SourceExpressionConverter.ConvertToken(filewatermarkText);
                if (@filepropCount > 0)
                {
                    callPayload.Body = @file;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddPassword([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> filepassword)
        {
            SourceExpression.Validate(filefileContent, nameof(filefileContent), required: true);
            SourceExpression.Validate(filepassword, nameof(filepassword), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var @file = new JObject();
                var @filepropCount = 0;
                @filepropCount++;
                @file["fileContent"] = SourceExpressionConverter.ConvertToken(filefileContent);
                @filepropCount++;
                @file["password"] = SourceExpressionConverter.ConvertToken(filepassword);
                if (@filepropCount > 0)
                {
                    callPayload.Body = @file;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfcross")]
        public IBodyWorkflowAction<string> AddImage([WorkflowExpression] Func<string> filefileContent, [WorkflowExpression] Func<string> fileimageContent, [WorkflowExpression] Func<double> filepositionX, [WorkflowExpression] Func<double> filepositionY, [WorkflowExpression] Func<string> fileaddType, [WorkflowExpression] Func<double> filefromPage = null, [WorkflowExpression] Func<double> filetoPage = null)
        {
            SourceExpression.Validate(filefileContent, nameof(filefileContent), required: true);
            SourceExpression.Validate(fileimageContent, nameof(fileimageContent), required: true);
            SourceExpression.Validate(filepositionX, nameof(filepositionX), required: true);
            SourceExpression.Validate(filepositionY, nameof(filepositionY), required: true);
            SourceExpression.Validate(fileaddType, nameof(fileaddType), required: true);
            SourceExpression.Validate(filefromPage, nameof(filefromPage), required: false);
            SourceExpression.Validate(filetoPage, nameof(filetoPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var @file = new JObject();
                var @filepropCount = 0;
                @filepropCount++;
                @file["fileContent"] = SourceExpressionConverter.ConvertToken(filefileContent);
                @filepropCount++;
                @file["imageContent"] = SourceExpressionConverter.ConvertToken(fileimageContent);
                @filepropCount++;
                @file["positionX"] = SourceExpressionConverter.ConvertToken(filepositionX);
                @filepropCount++;
                @file["positionY"] = SourceExpressionConverter.ConvertToken(filepositionY);
                @filepropCount++;
                @file["addType"] = SourceExpressionConverter.ConvertToken(fileaddType);
                if (filefromPage != null)
                {
                    @file["fromPage"] = SourceExpressionConverter.ConvertToken(filefromPage);
                    @filepropCount++;
                }

                if (filetoPage != null)
                {
                    @file["toPage"] = SourceExpressionConverter.ConvertToken(filetoPage);
                    @filepropCount++;
                }

                if (@filepropCount > 0)
                {
                    callPayload.Body = @file;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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