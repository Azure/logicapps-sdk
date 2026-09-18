//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobepdftoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ESealResponse> ESeal([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<providerNameInput> providerName, [WorkflowExpression] Func<string> xCredentialId, [WorkflowExpression] Func<string> xAuthPin, [WorkflowExpression] Func<string> xAuthToken, [WorkflowExpression] Func<signatureFormatInput> signatureFormat, [WorkflowExpression] Func<string> fieldName, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> topCoordinate = null, [WorkflowExpression] Func<int> leftCoordinate = null, [WorkflowExpression] Func<int> rightCoordinate = null, [WorkflowExpression] Func<int> bottomCoordinate = null, [WorkflowExpression] Func<bool> displayName = null, [WorkflowExpression] Func<bool> displayDate = null, [WorkflowExpression] Func<bool> displayLabels = null, [WorkflowExpression] Func<bool> displayDistinguishedName = null, [WorkflowExpression] Func<object> sealImageFile = null, [WorkflowExpression] Func<sealImageFormatInput> sealImageFormat = null, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(providerName, nameof(providerName), required: true);
            SourceExpression.Validate(xCredentialId, nameof(xCredentialId), required: true);
            SourceExpression.Validate(xAuthPin, nameof(xAuthPin), required: true);
            SourceExpression.Validate(xAuthToken, nameof(xAuthToken), required: true);
            SourceExpression.Validate(signatureFormat, nameof(signatureFormat), required: true);
            SourceExpression.Validate(fieldName, nameof(fieldName), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: false);
            SourceExpression.Validate(topCoordinate, nameof(topCoordinate), required: false);
            SourceExpression.Validate(leftCoordinate, nameof(leftCoordinate), required: false);
            SourceExpression.Validate(rightCoordinate, nameof(rightCoordinate), required: false);
            SourceExpression.Validate(bottomCoordinate, nameof(bottomCoordinate), required: false);
            SourceExpression.Validate(displayName, nameof(displayName), required: false);
            SourceExpression.Validate(displayDate, nameof(displayDate), required: false);
            SourceExpression.Validate(displayLabels, nameof(displayLabels), required: false);
            SourceExpression.Validate(displayDistinguishedName, nameof(displayDistinguishedName), required: false);
            SourceExpression.Validate(sealImageFile, nameof(sealImageFile), required: false);
            SourceExpression.Validate(sealImageFormat, nameof(sealImageFormat), required: false);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/eSeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-credential-id"] = SourceExpressionConverter.ConvertO(xCredentialId);
                callPayload.Headers["x-auth-pin"] = SourceExpressionConverter.ConvertO(xAuthPin);
                callPayload.Headers["x-auth-token"] = SourceExpressionConverter.ConvertO(xAuthToken);
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ESealResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromExcel([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFFromExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromPPT([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFFromPPT";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromWord([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFFromWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromImage([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFGeneric([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromDynamicHtml([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<pageSizeInput> pageSize, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<bool> includeHeaderFooter = null, [WorkflowExpression] Func<string> dataToMerge = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(includeHeaderFooter, nameof(includeHeaderFooter), required: false);
            SourceExpression.Validate(dataToMerge, nameof(dataToMerge), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFFromDynamicHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromStaticHtml([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<pageSizeInput> pageSize, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<bool> includeHeaderFooter = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(includeHeaderFooter, nameof(includeHeaderFooter), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/createPDFFromStaticHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToExcel([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/exportPDFToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ExportDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToPPT([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/exportPDFToPPT";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ExportDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToWord([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(targetFormat, nameof(targetFormat), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/exportPDFToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ExportDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToImage([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(targetFormat, nameof(targetFormat), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/exportPDFToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ExportDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExportedImages> ExportPDFToImageList([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(targetFormat, nameof(targetFormat), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/exportPDFToImageList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseExportedImages>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFGeneric([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(targetFormat, nameof(targetFormat), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/exportPDFGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ExportDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CompressPDFResponse> CompressPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<compressionLevelInput> compressionLevel = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(compressionLevel, nameof(compressionLevel), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/compressPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<CompressPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<LinearizePDFResponse> LinearizePDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/linearizePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<LinearizePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CombinePDFResponse> CombinePDF([WorkflowExpression] Func<string> filesArraymergedPDFFileName, [WorkflowExpression] Func<string[]> filesArrayfiles, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(filesArraymergedPDFFileName, nameof(filesArraymergedPDFFileName), required: true);
            SourceExpression.Validate(filesArrayfiles, nameof(filesArrayfiles), required: true);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/combinePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                var filesArray = new JObject();
                var filesArraypropCount = 0;
                filesArraypropCount++;
                filesArray["outputFileName"] = SourceExpressionConverter.ConvertToken(filesArraymergedPDFFileName);
                filesArraypropCount++;
                filesArray["files"] = SourceExpressionConverter.ConvertToken(filesArrayfiles);
                if (filesArraypropCount > 0)
                {
                    callPayload.Body = filesArray;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CombinePDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<OCRPDFResponse> OcrPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<ocrLocaleInput> ocrLocale, [WorkflowExpression] Func<ocrTypeInput> ocrType, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(ocrLocale, nameof(ocrLocale), required: true);
            SourceExpression.Validate(ocrType, nameof(ocrType), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<OCRPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectUserPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> userPassword, [WorkflowExpression] Func<contentEncryptionInput> contentEncryption, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(userPassword, nameof(userPassword), required: true);
            SourceExpression.Validate(contentEncryption, nameof(contentEncryption), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/protectUserPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ProtectPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectOwnerPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<contentEncryptionInput> contentEncryption, [WorkflowExpression] Func<bool> allowPrintLowQuality, [WorkflowExpression] Func<bool> allowPrintHighQuality, [WorkflowExpression] Func<bool> allowEditContent, [WorkflowExpression] Func<bool> allowEditDocumentAssembly, [WorkflowExpression] Func<bool> allowEditAnnotations, [WorkflowExpression] Func<bool> allowEditFillAndSignFormFields, [WorkflowExpression] Func<bool> allowCopyContent, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(ownerPassword, nameof(ownerPassword), required: true);
            SourceExpression.Validate(contentEncryption, nameof(contentEncryption), required: true);
            SourceExpression.Validate(allowPrintLowQuality, nameof(allowPrintLowQuality), required: true);
            SourceExpression.Validate(allowPrintHighQuality, nameof(allowPrintHighQuality), required: true);
            SourceExpression.Validate(allowEditContent, nameof(allowEditContent), required: true);
            SourceExpression.Validate(allowEditDocumentAssembly, nameof(allowEditDocumentAssembly), required: true);
            SourceExpression.Validate(allowEditAnnotations, nameof(allowEditAnnotations), required: true);
            SourceExpression.Validate(allowEditFillAndSignFormFields, nameof(allowEditFillAndSignFormFields), required: true);
            SourceExpression.Validate(allowCopyContent, nameof(allowCopyContent), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/protectOwnerPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ProtectPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectGenericPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> userPassword, [WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<contentEncryptionInput> contentEncryption, [WorkflowExpression] Func<bool> allowPrintLowQuality, [WorkflowExpression] Func<bool> allowPrintHighQuality, [WorkflowExpression] Func<bool> allowEditContent, [WorkflowExpression] Func<bool> allowEditDocumentAssembly, [WorkflowExpression] Func<bool> allowEditAnnotations, [WorkflowExpression] Func<bool> allowEditFillAndSignFormFields, [WorkflowExpression] Func<bool> allowCopyContent, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(userPassword, nameof(userPassword), required: true);
            SourceExpression.Validate(ownerPassword, nameof(ownerPassword), required: true);
            SourceExpression.Validate(contentEncryption, nameof(contentEncryption), required: true);
            SourceExpression.Validate(allowPrintLowQuality, nameof(allowPrintLowQuality), required: true);
            SourceExpression.Validate(allowPrintHighQuality, nameof(allowPrintHighQuality), required: true);
            SourceExpression.Validate(allowEditContent, nameof(allowEditContent), required: true);
            SourceExpression.Validate(allowEditDocumentAssembly, nameof(allowEditDocumentAssembly), required: true);
            SourceExpression.Validate(allowEditAnnotations, nameof(allowEditAnnotations), required: true);
            SourceExpression.Validate(allowEditFillAndSignFormFields, nameof(allowEditFillAndSignFormFields), required: true);
            SourceExpression.Validate(allowCopyContent, nameof(allowCopyContent), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/protectGenericPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<ProtectPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<UnProtectPDFResponse> RemovePassword([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> password, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(password, nameof(password), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/removeProtection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<UnProtectPDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseSplitDocument> SplitPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<splitByTypeInput> splitByType, [WorkflowExpression] Func<string> splitConfiguration, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(splitByType, nameof(splitByType), required: true);
            SourceExpression.Validate(splitConfiguration, nameof(splitConfiguration), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/splitPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseSplitDocument>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractImages> ExtractImagesFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/extractImagesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseExtractImages>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractTables> ExtractTablesFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/extractTablesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseExtractTables>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractJSONFile> ExtractJSONFileFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> addCharInfo = null, [WorkflowExpression] Func<bool> getStylingInfo = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(addCharInfo, nameof(addCharInfo), required: false);
            SourceExpression.Validate(getStylingInfo, nameof(getStylingInfo), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/extractJSONFileFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseExtractJSONFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractJsonObject> ExtractJSONObjectFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> addCharInfo = null, [WorkflowExpression] Func<bool> getStylingInfo = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(addCharInfo, nameof(addCharInfo), required: false);
            SourceExpression.Validate(getStylingInfo, nameof(getStylingInfo), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/extractJSONObjectFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseExtractJsonObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractDocument> ExtractJSONAndImagesAndTablesFromPDF([WorkflowExpression] Func<bool> addTables, [WorkflowExpression] Func<bool> addFigures, [WorkflowExpression] Func<pdfStructureOutputFormatInput> pdfStructureOutputFormat, [WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> addCharInfo = null, [WorkflowExpression] Func<bool> getStylingInfo = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(addTables, nameof(addTables), required: true);
            SourceExpression.Validate(addFigures, nameof(addFigures), required: true);
            SourceExpression.Validate(pdfStructureOutputFormat, nameof(pdfStructureOutputFormat), required: true);
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(addCharInfo, nameof(addCharInfo), required: false);
            SourceExpression.Validate(getStylingInfo, nameof(getStylingInfo), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/extractJSONAndImagesAndTablesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseExtractDocument>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponsePDFProperties> PDFProperties([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> pageLevel, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(pageLevel, nameof(pageLevel), required: true);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/pdfProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponsePDFProperties>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DocGenResponse> DocGen([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> jsonStringForMerge, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<string> fragments = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(jsonStringForMerge, nameof(jsonStringForMerge), required: true);
            SourceExpression.Validate(targetFormat, nameof(targetFormat), required: true);
            SourceExpression.Validate(inputFile0, nameof(inputFile0), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(fragments, nameof(fragments), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/docGen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DocGenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseAutotagPDF> AutoTag([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> fileData, [WorkflowExpression] Func<bool> generateReport, [WorkflowExpression] Func<bool> shiftHeadings, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(inputFileName, nameof(inputFileName), required: true);
            SourceExpression.Validate(fileData, nameof(fileData), required: true);
            SourceExpression.Validate(generateReport, nameof(generateReport), required: true);
            SourceExpression.Validate(shiftHeadings, nameof(shiftHeadings), required: true);
            SourceExpression.Validate(outputFileName, nameof(outputFileName), required: false);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/accessibility";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseAutotagPDF>(BuildSourceInput);
        }
    }

    public class AdobepdftoolsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ESealResponse
    {
        [JsonProperty("fileName")]
        public string OutputFileName { get; set; }

        [JsonProperty("fileContent")]
        public string OutputFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string OutputFileContentType { get; set; }
    }

    public enum providerNameInput
    {
        [EnumMember(Value = "INTESI_GROUP")]
        INTESIGROUP,
        ENTRUST,
        [EnumMember(Value = "GLOBAL_SIGN")]
        GLOBALSIGN,
        [EnumMember(Value = "TRUST_PRO")]
        TRUSTPRO
    }

    public enum signatureFormatInput
    {
        PADES,
        PKCS7
    }

    public enum sealImageFormatInput
    {
        [EnumMember(Value = "image/jpeg")]
        JPEG,
        [EnumMember(Value = "image/png")]
        PNG,
        [EnumMember(Value = "application/pdf")]
        PDF
    }

    public enum xRegionValueInput
    {
        [EnumMember(Value = "-ue1")]
        USEastNVirginia,
        [EnumMember(Value = "-ew1")]
        EuropeIreland
    }

    public class CreatePDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public enum pageSizeInput
    {
        Default,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        B4,
        B5,
        EnvelopeDL,
        Executive,
        Folio,
        Ledger,
        Legal,
        Letter,
        Quarto,
        Statement,
        Tabloid
    }

    public class ExportDocumentResponse
    {
        [JsonProperty("fileName")]
        public string OutputFileName { get; set; }

        [JsonProperty("fileContent")]
        public string OutputFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string OutputFileContentType { get; set; }
    }

    public enum targetFormatInput
    {
        PDF,
        DOCX
    }

    public class DtoResponseExportedImages
    {
        [JsonProperty("documents")]
        public ExportDocumentResponse[] ImageList { get; set; }
    }

    public class CompressPDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public enum compressionLevelInput
    {
        LOW,
        MEDIUM,
        HIGH
    }

    public class LinearizePDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public class CombinePDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public class OCRPDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public enum ocrLocaleInput
    {
        [EnumMember(Value = "BG_BG")]
        BulgarianBulgaria,
        [EnumMember(Value = "CA_CA")]
        CatalanCanada,
        [EnumMember(Value = "CS_CZ")]
        CzechCzechRepublic,
        [EnumMember(Value = "DA_DK")]
        DanishDenmark,
        [EnumMember(Value = "DE_CH")]
        GermanSwitzerland,
        [EnumMember(Value = "DE_DE")]
        GermanGermany,
        [EnumMember(Value = "EL_GR")]
        GreekGreece,
        [EnumMember(Value = "EN_GB")]
        EnglishUnitedKingdom,
        [EnumMember(Value = "EN_US")]
        EnglishUnitedStates,
        [EnumMember(Value = "ES_ES")]
        SpanishSpain,
        [EnumMember(Value = "ET_EE")]
        EstonianEstonia,
        [EnumMember(Value = "FI_FI")]
        FinnishFinland,
        [EnumMember(Value = "FR_FR")]
        FrenchFrance,
        [EnumMember(Value = "HR_HR")]
        CroatianCroatia,
        [EnumMember(Value = "HU_HU")]
        HungarianHungary,
        [EnumMember(Value = "IT_IT")]
        ItalianItaly,
        [EnumMember(Value = "IW_IL")]
        HebrewIsrael,
        [EnumMember(Value = "JA_JP")]
        JapaneseJapan,
        [EnumMember(Value = "KO_KR")]
        KoreanKorea,
        [EnumMember(Value = "LT_LT")]
        LithuanianLithuania,
        [EnumMember(Value = "LV_LV")]
        LatvianLatvia,
        [EnumMember(Value = "MK_MK")]
        MacedonianMacedonia,
        [EnumMember(Value = "MT_MT")]
        MalteseMalta,
        [EnumMember(Value = "NB_NO")]
        NorwegianBokmålNorway,
        [EnumMember(Value = "NL_NL")]
        DutchNetherlands,
        [EnumMember(Value = "NO_NO")]
        NorwegianNorway,
        [EnumMember(Value = "PL_PL")]
        PolishPoland,
        [EnumMember(Value = "PT_BR")]
        PortugueseBrazil,
        [EnumMember(Value = "RO_RO")]
        RomanianRomania,
        [EnumMember(Value = "RU_RU")]
        RussianRussia,
        [EnumMember(Value = "SK_SK")]
        SlovakSlovakia,
        [EnumMember(Value = "SL_SI")]
        SerbianSerbia,
        [EnumMember(Value = "SR_SR")]
        SlovenianSlovenia,
        [EnumMember(Value = "SV_SE")]
        SwedishSweden,
        [EnumMember(Value = "TR_TR")]
        TurkishTürkiye,
        [EnumMember(Value = "UK_UA")]
        UkrainianUkraine,
        [EnumMember(Value = "ZH_CN")]
        ChineseChina,
        [EnumMember(Value = "ZH_HK")]
        ChineseHongKong
    }

    public enum ocrTypeInput
    {
        [EnumMember(Value = "SEARCHABLE_IMAGE")]
        ModifyOriginalImage,
        [EnumMember(Value = "SEARCHABLE_IMAGE_EXACT")]
        KeepOriginalImageForMaximumFidelity
    }

    public class ProtectPDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public enum contentEncryptionInput
    {
        [EnumMember(Value = "ALL_CONTENT")]
        EncryptAllContent,
        [EnumMember(Value = "ALL_CONTENT_EXCEPT_METADATA")]
        EncryptAllContentExceptMetadata
    }

    public class UnProtectPDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public class DtoResponseSplitDocument
    {
        [JsonProperty("documents")]
        public DocumentObject[] SplitDocument { get; set; }
    }

    public class DocumentObject
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string FileContentType { get; set; }
    }

    public enum splitByTypeInput
    {
        [EnumMember(Value = "PageRangeArray")]
        ArrayOfPageRange,
        NumberOfPages,
        [EnumMember(Value = "NumberOfFiles")]
        NumberOfSplitFiles
    }

    public class DtoResponseExtractImages
    {
        [JsonProperty("images")]
        public ImageObject[] Images { get; set; }
    }

    public class ImageObject
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string FileContentType { get; set; }
    }

    public class DtoResponseExtractTables
    {
        [JsonProperty("tables")]
        public TableObject[] Tables { get; set; }
    }

    public class TableObject
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string FileContentType { get; set; }
    }

    public class DtoResponseExtractJSONFile
    {
        [JsonProperty("jsonFileName")]
        public string ExtractedFileName { get; set; }

        [JsonProperty("jsonFileContent")]
        public string ExtractedFileContent { get; set; }

        [JsonProperty("jsonFileContentType")]
        public string ExtractedFileContentType { get; set; }
    }

    public class DtoResponseExtractJsonObject
    {
        [JsonProperty("structuredJsonObject")]
        public string ExtractedPDFStructure { get; set; }
    }

    public class DtoResponseExtractDocument
    {
        [JsonProperty("jsonFileName")]
        public string ExtractedFileName { get; set; }

        [JsonProperty("jsonFileContent")]
        public string ExtractedFileContent { get; set; }

        [JsonProperty("jsonFileContentType")]
        public string ExtractedFileContentType { get; set; }

        [JsonProperty("structuredJsonObject")]
        public string ExtractedPDFStructure { get; set; }

        [JsonProperty("images")]
        public ImageObject[] Images { get; set; }

        [JsonProperty("tables")]
        public TableObject[] Tables { get; set; }
    }

    public enum pdfStructureOutputFormatInput
    {
        [EnumMember(Value = "JSON FILE")]
        JSONFILE,
        [EnumMember(Value = "JSON OBJECT")]
        JSONOBJECT
    }

    public class DtoResponsePDFProperties
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string FileContentType { get; set; }

        [JsonProperty("jsonObject")]
        public string JSONString { get; set; }

        [JsonProperty("properties")]
        public DtoResponsePDFPropertiesValueType Value { get; set; }
    }

    public class DtoResponsePDFPropertiesValueType
    {
        [JsonProperty("page_count")]
        public int PDFPageCount { get; set; }

        [JsonProperty("file_size")]
        public string FileSize { get; set; }

        [JsonProperty("linearized")]
        public bool PDFLinearized { get; set; }

        [JsonProperty("tagged")]
        public bool PDFTagged { get; set; }

        [JsonProperty("certified")]
        public bool PDFCertified { get; set; }

        [JsonProperty("compliance_level")]
        public string ComplianceLevelDeprecated { get; set; }

        [JsonProperty("xfa")]
        public bool PDFXFA { get; set; }

        [JsonProperty("portfolio")]
        public bool PDFPortfolio { get; set; }

        [JsonProperty("encrypted")]
        public bool PDFEncrypted { get; set; }

        [JsonProperty("pdfVersion")]
        public string PDFVersion { get; set; }

        [JsonProperty("hasAcroForms")]
        public bool PDFHasAcroforms { get; set; }

        [JsonProperty("signed")]
        public bool PDFSigned { get; set; }

        [JsonProperty("incrementalSaveCount")]
        public int IncrementalSaveCount { get; set; }

        [JsonProperty("hasEmbeddedFiles")]
        public bool PDFHasEmbeddedFiles { get; set; }
        public string XMP { get; set; }

        [JsonProperty("creationDate")]
        public string PDFCreationDate { get; set; }

        [JsonProperty("Producer")]
        public string PDFProducer { get; set; }

        [JsonProperty("modifiedDate")]
        public string PDFLatestModificationDate { get; set; }

        [JsonProperty("fonts")]
        public DtoResponsePDFPropertiesFonts[] Fonts { get; set; }

        [JsonProperty("pdfa_compliance_level")]
        public string PDFAComplianceLevel { get; set; }

        [JsonProperty("pdfe_compliance_level")]
        public string PDFEComplianceLevel { get; set; }

        [JsonProperty("pdfvt_compliance_level")]
        public string PDFVTComplianceLevel { get; set; }

        [JsonProperty("pdfx_compliance_level")]
        public string PDFXComplianceLevel { get; set; }

        [JsonProperty("pdfua_compliance_level")]
        public string PDFUAComplianceLevel { get; set; }

        [JsonProperty("pages")]
        public DtoResponsePDFPropertiesPages[] Page { get; set; }
    }

    public class DtoResponsePDFPropertiesFonts
    {
        [JsonProperty("name")]
        public string FontName { get; set; }

        [JsonProperty("font_type")]
        public string FontType { get; set; }

        [JsonProperty("family_name")]
        public string FontFamilyName { get; set; }
    }

    public class DtoResponsePDFPropertiesPages
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("scanned")]
        public bool PageScanned { get; set; }

        [JsonProperty("width")]
        public int PageWidth { get; set; }

        [JsonProperty("height")]
        public int PageHeight { get; set; }

        [JsonProperty("hasStructure")]
        public bool PageHasStructure { get; set; }

        [JsonProperty("numberOfImages")]
        public int NumberOfImagesInThePage { get; set; }

        [JsonProperty("onlyImages")]
        public bool OnlyImagesInThePage { get; set; }

        [JsonProperty("hasText")]
        public bool PageHasText { get; set; }

        [JsonProperty("hasImages")]
        public bool PageHasImages { get; set; }

        [JsonProperty("empty")]
        public bool PageEmpty { get; set; }
    }

    public class DocGenResponse
    {
        [JsonProperty("fileName")]
        public string OutputFileName { get; set; }

        [JsonProperty("fileContent")]
        public string OutputFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string OutputFileContentType { get; set; }
    }

    public class DtoResponseAutotagPDF
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string FileContentType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools;

    public partial class WorkflowManagedActions
    {
        public AdobepdftoolsActions Adobepdftools(string connectionId) => new AdobepdftoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobepdftoolsTriggers Adobepdftools(string connectionId) => new AdobepdftoolsTriggers(connectionId);
    }
}