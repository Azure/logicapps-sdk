//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobepdftoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildESeal))]
        public IBodyWorkflowAction<ESealResponse> ESeal([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<providerNameInput> providerName, [WorkflowExpression] Func<string> xCredentialId, [WorkflowExpression] Func<string> xAuthPin, [WorkflowExpression] Func<string> xAuthToken, [WorkflowExpression] Func<signatureFormatInput> signatureFormat, [WorkflowExpression] Func<string> fieldName, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> topCoordinate = null, [WorkflowExpression] Func<int> leftCoordinate = null, [WorkflowExpression] Func<int> rightCoordinate = null, [WorkflowExpression] Func<int> bottomCoordinate = null, [WorkflowExpression] Func<bool> displayName = null, [WorkflowExpression] Func<bool> displayDate = null, [WorkflowExpression] Func<bool> displayLabels = null, [WorkflowExpression] Func<bool> displayDistinguishedName = null, [WorkflowExpression] Func<object> sealImageFile = null, [WorkflowExpression] Func<sealImageFormatInput> sealImageFormat = null, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ESealResponse> __BuildESeal(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<providerNameInput> providerName, WorkflowValue<string> xCredentialId, WorkflowValue<string> xAuthPin, WorkflowValue<string> xAuthToken, WorkflowValue<signatureFormatInput> signatureFormat, WorkflowValue<string> fieldName, WorkflowValue<int> pageNumber = null, WorkflowValue<int> topCoordinate = null, WorkflowValue<int> leftCoordinate = null, WorkflowValue<int> rightCoordinate = null, WorkflowValue<int> bottomCoordinate = null, WorkflowValue<bool> displayName = null, WorkflowValue<bool> displayDate = null, WorkflowValue<bool> displayLabels = null, WorkflowValue<bool> displayDistinguishedName = null, WorkflowValue<object> sealImageFile = null, WorkflowValue<sealImageFormatInput> sealImageFormat = null, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(providerName, nameof(providerName), required: true);
            WorkflowValue.Validate(xCredentialId, nameof(xCredentialId), required: true);
            WorkflowValue.Validate(xAuthPin, nameof(xAuthPin), required: true);
            WorkflowValue.Validate(xAuthToken, nameof(xAuthToken), required: true);
            WorkflowValue.Validate(signatureFormat, nameof(signatureFormat), required: true);
            WorkflowValue.Validate(fieldName, nameof(fieldName), required: true);
            WorkflowValue.Validate(pageNumber, nameof(pageNumber), required: false);
            WorkflowValue.Validate(topCoordinate, nameof(topCoordinate), required: false);
            WorkflowValue.Validate(leftCoordinate, nameof(leftCoordinate), required: false);
            WorkflowValue.Validate(rightCoordinate, nameof(rightCoordinate), required: false);
            WorkflowValue.Validate(bottomCoordinate, nameof(bottomCoordinate), required: false);
            WorkflowValue.Validate(displayName, nameof(displayName), required: false);
            WorkflowValue.Validate(displayDate, nameof(displayDate), required: false);
            WorkflowValue.Validate(displayLabels, nameof(displayLabels), required: false);
            WorkflowValue.Validate(displayDistinguishedName, nameof(displayDistinguishedName), required: false);
            WorkflowValue.Validate(sealImageFile, nameof(sealImageFile), required: false);
            WorkflowValue.Validate(sealImageFormat, nameof(sealImageFormat), required: false);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ESealResponse>(() =>
            {
                var apiCallPath = "/operation/v1/eSeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-credential-id"] = ExpressionConverter.Convert(xCredentialId);
                callPayload.Headers["x-auth-pin"] = ExpressionConverter.Convert(xAuthPin);
                callPayload.Headers["x-auth-token"] = ExpressionConverter.Convert(xAuthToken);
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ESealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFFromExcel))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromExcel([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFFromExcel(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFFromPPT))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromPPT([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFFromPPT(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromPPT";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFFromWord))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromWord([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFFromWord(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFFromImage))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromImage([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFFromImage(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFGeneric))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFGeneric([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFGeneric(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFFromDynamicHtml))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromDynamicHtml([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<pageSizeInput> pageSize, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<bool> includeHeaderFooter = null, [WorkflowExpression] Func<string> dataToMerge = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFFromDynamicHtml(WorkflowValue<string> inputFileName, WorkflowValue<pageSizeInput> pageSize, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<bool> includeHeaderFooter = null, WorkflowValue<string> dataToMerge = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(includeHeaderFooter, nameof(includeHeaderFooter), required: false);
            WorkflowValue.Validate(dataToMerge, nameof(dataToMerge), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromDynamicHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDFFromStaticHtml))]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromStaticHtml([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<pageSizeInput> pageSize, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<bool> includeHeaderFooter = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePDFResponse> __BuildCreatePDFFromStaticHtml(WorkflowValue<string> inputFileName, WorkflowValue<pageSizeInput> pageSize, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<bool> includeHeaderFooter = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(includeHeaderFooter, nameof(includeHeaderFooter), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromStaticHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExportPDFToExcel))]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToExcel([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportDocumentResponse> __BuildExportPDFToExcel(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExportPDFToPPT))]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToPPT([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportDocumentResponse> __BuildExportPDFToPPT(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToPPT";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExportPDFToWord))]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToWord([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportDocumentResponse> __BuildExportPDFToWord(WorkflowValue<string> inputFileName, WorkflowValue<targetFormatInput> targetFormat, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(targetFormat, nameof(targetFormat), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExportPDFToImage))]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToImage([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportDocumentResponse> __BuildExportPDFToImage(WorkflowValue<string> inputFileName, WorkflowValue<targetFormatInput> targetFormat, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(targetFormat, nameof(targetFormat), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExportPDFToImageList))]
        public IBodyWorkflowAction<DtoResponseExportedImages> ExportPDFToImageList([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseExportedImages> __BuildExportPDFToImageList(WorkflowValue<string> inputFileName, WorkflowValue<targetFormatInput> targetFormat, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(targetFormat, nameof(targetFormat), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExportedImages>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToImageList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseExportedImages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExportPDFGeneric))]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFGeneric([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportDocumentResponse> __BuildExportPDFGeneric(WorkflowValue<string> inputFileName, WorkflowValue<targetFormatInput> targetFormat, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(targetFormat, nameof(targetFormat), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCompressPDF))]
        public IBodyWorkflowAction<CompressPDFResponse> CompressPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<compressionLevelInput> compressionLevel = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompressPDFResponse> __BuildCompressPDF(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<compressionLevelInput> compressionLevel = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(compressionLevel, nameof(compressionLevel), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CompressPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/compressPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<CompressPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildLinearizePDF))]
        public IBodyWorkflowAction<LinearizePDFResponse> LinearizePDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinearizePDFResponse> __BuildLinearizePDF(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<LinearizePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/linearizePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<LinearizePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildCombinePDF))]
        public IBodyWorkflowAction<CombinePDFResponse> CombinePDF([WorkflowExpression] Func<string> filesArraymergedPDFFileName, [WorkflowExpression] Func<string[]> filesArrayfiles, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CombinePDFResponse> __BuildCombinePDF(WorkflowValue<string> filesArraymergedPDFFileName, WorkflowValue<string[]> filesArrayfiles, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(filesArraymergedPDFFileName, nameof(filesArraymergedPDFFileName), required: true);
            WorkflowValue.Validate(filesArrayfiles, nameof(filesArrayfiles), required: true);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CombinePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/combinePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                var filesArray = new JObject();
                var filesArraypropCount = 0;
                filesArraypropCount++;
                filesArray["outputFileName"] = ExpressionConverter.ConvertO(filesArraymergedPDFFileName);
                filesArraypropCount++;
                filesArray["files"] = ExpressionConverter.ConvertO(filesArrayfiles);
                if (filesArraypropCount > 0)
                {
                    callPayload.Body = filesArray;
                }

                return new ApiConnectionAction<CombinePDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildOcrPDF))]
        public IBodyWorkflowAction<OCRPDFResponse> OcrPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<ocrLocaleInput> ocrLocale, [WorkflowExpression] Func<ocrTypeInput> ocrType, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OCRPDFResponse> __BuildOcrPDF(WorkflowValue<string> inputFileName, WorkflowValue<ocrLocaleInput> ocrLocale, WorkflowValue<ocrTypeInput> ocrType, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(ocrLocale, nameof(ocrLocale), required: true);
            WorkflowValue.Validate(ocrType, nameof(ocrType), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<OCRPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<OCRPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildProtectUserPDF))]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectUserPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> userPassword, [WorkflowExpression] Func<contentEncryptionInput> contentEncryption, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProtectPDFResponse> __BuildProtectUserPDF(WorkflowValue<string> inputFileName, WorkflowValue<string> userPassword, WorkflowValue<contentEncryptionInput> contentEncryption, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(userPassword, nameof(userPassword), required: true);
            WorkflowValue.Validate(contentEncryption, nameof(contentEncryption), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/protectUserPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ProtectPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildProtectOwnerPDF))]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectOwnerPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<contentEncryptionInput> contentEncryption, [WorkflowExpression] Func<bool> allowPrintLowQuality, [WorkflowExpression] Func<bool> allowPrintHighQuality, [WorkflowExpression] Func<bool> allowEditContent, [WorkflowExpression] Func<bool> allowEditDocumentAssembly, [WorkflowExpression] Func<bool> allowEditAnnotations, [WorkflowExpression] Func<bool> allowEditFillAndSignFormFields, [WorkflowExpression] Func<bool> allowCopyContent, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProtectPDFResponse> __BuildProtectOwnerPDF(WorkflowValue<string> inputFileName, WorkflowValue<string> ownerPassword, WorkflowValue<contentEncryptionInput> contentEncryption, WorkflowValue<bool> allowPrintLowQuality, WorkflowValue<bool> allowPrintHighQuality, WorkflowValue<bool> allowEditContent, WorkflowValue<bool> allowEditDocumentAssembly, WorkflowValue<bool> allowEditAnnotations, WorkflowValue<bool> allowEditFillAndSignFormFields, WorkflowValue<bool> allowCopyContent, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(ownerPassword, nameof(ownerPassword), required: true);
            WorkflowValue.Validate(contentEncryption, nameof(contentEncryption), required: true);
            WorkflowValue.Validate(allowPrintLowQuality, nameof(allowPrintLowQuality), required: true);
            WorkflowValue.Validate(allowPrintHighQuality, nameof(allowPrintHighQuality), required: true);
            WorkflowValue.Validate(allowEditContent, nameof(allowEditContent), required: true);
            WorkflowValue.Validate(allowEditDocumentAssembly, nameof(allowEditDocumentAssembly), required: true);
            WorkflowValue.Validate(allowEditAnnotations, nameof(allowEditAnnotations), required: true);
            WorkflowValue.Validate(allowEditFillAndSignFormFields, nameof(allowEditFillAndSignFormFields), required: true);
            WorkflowValue.Validate(allowCopyContent, nameof(allowCopyContent), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/protectOwnerPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ProtectPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildProtectGenericPDF))]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectGenericPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> userPassword, [WorkflowExpression] Func<string> ownerPassword, [WorkflowExpression] Func<contentEncryptionInput> contentEncryption, [WorkflowExpression] Func<bool> allowPrintLowQuality, [WorkflowExpression] Func<bool> allowPrintHighQuality, [WorkflowExpression] Func<bool> allowEditContent, [WorkflowExpression] Func<bool> allowEditDocumentAssembly, [WorkflowExpression] Func<bool> allowEditAnnotations, [WorkflowExpression] Func<bool> allowEditFillAndSignFormFields, [WorkflowExpression] Func<bool> allowCopyContent, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProtectPDFResponse> __BuildProtectGenericPDF(WorkflowValue<string> inputFileName, WorkflowValue<string> userPassword, WorkflowValue<string> ownerPassword, WorkflowValue<contentEncryptionInput> contentEncryption, WorkflowValue<bool> allowPrintLowQuality, WorkflowValue<bool> allowPrintHighQuality, WorkflowValue<bool> allowEditContent, WorkflowValue<bool> allowEditDocumentAssembly, WorkflowValue<bool> allowEditAnnotations, WorkflowValue<bool> allowEditFillAndSignFormFields, WorkflowValue<bool> allowCopyContent, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(userPassword, nameof(userPassword), required: true);
            WorkflowValue.Validate(ownerPassword, nameof(ownerPassword), required: true);
            WorkflowValue.Validate(contentEncryption, nameof(contentEncryption), required: true);
            WorkflowValue.Validate(allowPrintLowQuality, nameof(allowPrintLowQuality), required: true);
            WorkflowValue.Validate(allowPrintHighQuality, nameof(allowPrintHighQuality), required: true);
            WorkflowValue.Validate(allowEditContent, nameof(allowEditContent), required: true);
            WorkflowValue.Validate(allowEditDocumentAssembly, nameof(allowEditDocumentAssembly), required: true);
            WorkflowValue.Validate(allowEditAnnotations, nameof(allowEditAnnotations), required: true);
            WorkflowValue.Validate(allowEditFillAndSignFormFields, nameof(allowEditFillAndSignFormFields), required: true);
            WorkflowValue.Validate(allowCopyContent, nameof(allowCopyContent), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/protectGenericPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<ProtectPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildRemovePassword))]
        public IBodyWorkflowAction<UnProtectPDFResponse> RemovePassword([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> password, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnProtectPDFResponse> __BuildRemovePassword(WorkflowValue<string> inputFileName, WorkflowValue<string> password, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(password, nameof(password), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<UnProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/removeProtection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<UnProtectPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildSplitPDF))]
        public IBodyWorkflowAction<DtoResponseSplitDocument> SplitPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<splitByTypeInput> splitByType, [WorkflowExpression] Func<string> splitConfiguration, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseSplitDocument> __BuildSplitPDF(WorkflowValue<string> inputFileName, WorkflowValue<splitByTypeInput> splitByType, WorkflowValue<string> splitConfiguration, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(splitByType, nameof(splitByType), required: true);
            WorkflowValue.Validate(splitConfiguration, nameof(splitConfiguration), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseSplitDocument>(() =>
            {
                var apiCallPath = "/operation/v1/splitPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseSplitDocument>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExtractImagesFromPDF))]
        public IBodyWorkflowAction<DtoResponseExtractImages> ExtractImagesFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseExtractImages> __BuildExtractImagesFromPDF(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractImages>(() =>
            {
                var apiCallPath = "/operation/v1/extractImagesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractImages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExtractTablesFromPDF))]
        public IBodyWorkflowAction<DtoResponseExtractTables> ExtractTablesFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseExtractTables> __BuildExtractTablesFromPDF(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractTables>(() =>
            {
                var apiCallPath = "/operation/v1/extractTablesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractTables>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExtractJSONFileFromPDF))]
        public IBodyWorkflowAction<DtoResponseExtractJSONFile> ExtractJSONFileFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> addCharInfo = null, [WorkflowExpression] Func<bool> getStylingInfo = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseExtractJSONFile> __BuildExtractJSONFileFromPDF(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<bool> addCharInfo = null, WorkflowValue<bool> getStylingInfo = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(addCharInfo, nameof(addCharInfo), required: false);
            WorkflowValue.Validate(getStylingInfo, nameof(getStylingInfo), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractJSONFile>(() =>
            {
                var apiCallPath = "/operation/v1/extractJSONFileFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractJSONFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExtractJSONObjectFromPDF))]
        public IBodyWorkflowAction<DtoResponseExtractJsonObject> ExtractJSONObjectFromPDF([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> addCharInfo = null, [WorkflowExpression] Func<bool> getStylingInfo = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseExtractJsonObject> __BuildExtractJSONObjectFromPDF(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<bool> addCharInfo = null, WorkflowValue<bool> getStylingInfo = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(addCharInfo, nameof(addCharInfo), required: false);
            WorkflowValue.Validate(getStylingInfo, nameof(getStylingInfo), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractJsonObject>(() =>
            {
                var apiCallPath = "/operation/v1/extractJSONObjectFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractJsonObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildExtractJSONAndImagesAndTablesFromPDF))]
        public IBodyWorkflowAction<DtoResponseExtractDocument> ExtractJSONAndImagesAndTablesFromPDF([WorkflowExpression] Func<bool> addTables, [WorkflowExpression] Func<bool> addFigures, [WorkflowExpression] Func<pdfStructureOutputFormatInput> pdfStructureOutputFormat, [WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> addCharInfo = null, [WorkflowExpression] Func<bool> getStylingInfo = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseExtractDocument> __BuildExtractJSONAndImagesAndTablesFromPDF(WorkflowValue<bool> addTables, WorkflowValue<bool> addFigures, WorkflowValue<pdfStructureOutputFormatInput> pdfStructureOutputFormat, WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<bool> addCharInfo = null, WorkflowValue<bool> getStylingInfo = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(addTables, nameof(addTables), required: true);
            WorkflowValue.Validate(addFigures, nameof(addFigures), required: true);
            WorkflowValue.Validate(pdfStructureOutputFormat, nameof(pdfStructureOutputFormat), required: true);
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(addCharInfo, nameof(addCharInfo), required: false);
            WorkflowValue.Validate(getStylingInfo, nameof(getStylingInfo), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractDocument>(() =>
            {
                var apiCallPath = "/operation/v1/extractJSONAndImagesAndTablesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractDocument>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildPDFProperties))]
        public IBodyWorkflowAction<DtoResponsePDFProperties> PDFProperties([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<bool> pageLevel, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponsePDFProperties> __BuildPDFProperties(WorkflowValue<string> inputFileName, WorkflowValue<object> inputFile0, WorkflowValue<bool> pageLevel, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(pageLevel, nameof(pageLevel), required: true);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponsePDFProperties>(() =>
            {
                var apiCallPath = "/operation/v1/pdfProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponsePDFProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildDocGen))]
        public IBodyWorkflowAction<DocGenResponse> DocGen([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<string> jsonStringForMerge, [WorkflowExpression] Func<targetFormatInput> targetFormat, [WorkflowExpression] Func<object> inputFile0, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<string> fragments = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocGenResponse> __BuildDocGen(WorkflowValue<string> inputFileName, WorkflowValue<string> jsonStringForMerge, WorkflowValue<targetFormatInput> targetFormat, WorkflowValue<object> inputFile0, WorkflowValue<string> outputFileName = null, WorkflowValue<string> fragments = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(jsonStringForMerge, nameof(jsonStringForMerge), required: true);
            WorkflowValue.Validate(targetFormat, nameof(targetFormat), required: true);
            WorkflowValue.Validate(inputFile0, nameof(inputFile0), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(fragments, nameof(fragments), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DocGenResponse>(() =>
            {
                var apiCallPath = "/operation/v1/docGen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DocGenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        [WorkflowExpressionFactory(nameof(__BuildAutoTag))]
        public IBodyWorkflowAction<DtoResponseAutotagPDF> AutoTag([WorkflowExpression] Func<string> inputFileName, [WorkflowExpression] Func<object> fileData, [WorkflowExpression] Func<bool> generateReport, [WorkflowExpression] Func<bool> shiftHeadings, [WorkflowExpression] Func<string> outputFileName = null, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseAutotagPDF> __BuildAutoTag(WorkflowValue<string> inputFileName, WorkflowValue<object> fileData, WorkflowValue<bool> generateReport, WorkflowValue<bool> shiftHeadings, WorkflowValue<string> outputFileName = null, WorkflowValue<xRegionValueInput> xRegionValue = null)
        {
            WorkflowValue.Validate(inputFileName, nameof(inputFileName), required: true);
            WorkflowValue.Validate(fileData, nameof(fileData), required: true);
            WorkflowValue.Validate(generateReport, nameof(generateReport), required: true);
            WorkflowValue.Validate(shiftHeadings, nameof(shiftHeadings), required: true);
            WorkflowValue.Validate(outputFileName, nameof(outputFileName), required: false);
            WorkflowValue.Validate(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseAutotagPDF>(() =>
            {
                var apiCallPath = "/operation/v1/accessibility";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(xRegionValue);
                return new ApiConnectionAction<DtoResponseAutotagPDF>(callPayload);
            });
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
