//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobepdftoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ESealResponse> ESeal(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<providerNameInput>> providerName, Expression<Func<string>> xCredentialId, Expression<Func<string>> xAuthPin, Expression<Func<string>> xAuthToken, Expression<Func<signatureFormatInput>> signatureFormat, Expression<Func<string>> fieldName, Expression<Func<int>> pageNumber = null, Expression<Func<int>> topCoordinate = null, Expression<Func<int>> leftCoordinate = null, Expression<Func<int>> rightCoordinate = null, Expression<Func<int>> bottomCoordinate = null, Expression<Func<bool>> displayName = null, Expression<Func<bool>> displayDate = null, Expression<Func<bool>> displayLabels = null, Expression<Func<bool>> displayDistinguishedName = null, Expression<Func<object>> sealImageFile = null, Expression<Func<sealImageFormatInput>> sealImageFormat = null, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_providerName = WorkflowExpression.Compile(providerName, nameof(providerName), required: true);
            var __workflow_xCredentialId = WorkflowExpression.Compile(xCredentialId, nameof(xCredentialId), required: true);
            var __workflow_xAuthPin = WorkflowExpression.Compile(xAuthPin, nameof(xAuthPin), required: true);
            var __workflow_xAuthToken = WorkflowExpression.Compile(xAuthToken, nameof(xAuthToken), required: true);
            var __workflow_signatureFormat = WorkflowExpression.Compile(signatureFormat, nameof(signatureFormat), required: true);
            var __workflow_fieldName = WorkflowExpression.Compile(fieldName, nameof(fieldName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_topCoordinate = WorkflowExpression.Compile(topCoordinate, nameof(topCoordinate), required: false);
            var __workflow_leftCoordinate = WorkflowExpression.Compile(leftCoordinate, nameof(leftCoordinate), required: false);
            var __workflow_rightCoordinate = WorkflowExpression.Compile(rightCoordinate, nameof(rightCoordinate), required: false);
            var __workflow_bottomCoordinate = WorkflowExpression.Compile(bottomCoordinate, nameof(bottomCoordinate), required: false);
            var __workflow_displayName = WorkflowExpression.Compile(displayName, nameof(displayName), required: false);
            var __workflow_displayDate = WorkflowExpression.Compile(displayDate, nameof(displayDate), required: false);
            var __workflow_displayLabels = WorkflowExpression.Compile(displayLabels, nameof(displayLabels), required: false);
            var __workflow_displayDistinguishedName = WorkflowExpression.Compile(displayDistinguishedName, nameof(displayDistinguishedName), required: false);
            var __workflow_sealImageFile = WorkflowExpression.Compile(sealImageFile, nameof(sealImageFile), required: false);
            var __workflow_sealImageFormat = WorkflowExpression.Compile(sealImageFormat, nameof(sealImageFormat), required: false);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ESealResponse>(() =>
            {
                var apiCallPath = "/operation/v1/eSeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-credential-id"] = ExpressionConverter.Convert(__workflow_xCredentialId);
                callPayload.Headers["x-auth-pin"] = ExpressionConverter.Convert(__workflow_xAuthPin);
                callPayload.Headers["x-auth-token"] = ExpressionConverter.Convert(__workflow_xAuthToken);
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ESealResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromExcel(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromPPT(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromPPT";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromWord(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromImage(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFGeneric(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromDynamicHtml(Expression<Func<string>> inputFileName, Expression<Func<pageSizeInput>> pageSize, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<bool>> includeHeaderFooter = null, Expression<Func<string>> dataToMerge = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_includeHeaderFooter = WorkflowExpression.Compile(includeHeaderFooter, nameof(includeHeaderFooter), required: false);
            var __workflow_dataToMerge = WorkflowExpression.Compile(dataToMerge, nameof(dataToMerge), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromDynamicHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CreatePDFResponse> CreatePDFFromStaticHtml(Expression<Func<string>> inputFileName, Expression<Func<pageSizeInput>> pageSize, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<bool>> includeHeaderFooter = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_includeHeaderFooter = WorkflowExpression.Compile(includeHeaderFooter, nameof(includeHeaderFooter), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CreatePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/createPDFFromStaticHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CreatePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToExcel(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToPPT(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToPPT";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToWord(Expression<Func<string>> inputFileName, Expression<Func<targetFormatInput>> targetFormat, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_targetFormat = WorkflowExpression.Compile(targetFormat, nameof(targetFormat), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFToImage(Expression<Func<string>> inputFileName, Expression<Func<targetFormatInput>> targetFormat, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_targetFormat = WorkflowExpression.Compile(targetFormat, nameof(targetFormat), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExportedImages> ExportPDFToImageList(Expression<Func<string>> inputFileName, Expression<Func<targetFormatInput>> targetFormat, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_targetFormat = WorkflowExpression.Compile(targetFormat, nameof(targetFormat), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExportedImages>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFToImageList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseExportedImages>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ExportDocumentResponse> ExportPDFGeneric(Expression<Func<string>> inputFileName, Expression<Func<targetFormatInput>> targetFormat, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_targetFormat = WorkflowExpression.Compile(targetFormat, nameof(targetFormat), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ExportDocumentResponse>(() =>
            {
                var apiCallPath = "/operation/v1/exportPDFGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ExportDocumentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CompressPDFResponse> CompressPDF(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<compressionLevelInput>> compressionLevel = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_compressionLevel = WorkflowExpression.Compile(compressionLevel, nameof(compressionLevel), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CompressPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/compressPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<CompressPDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<LinearizePDFResponse> LinearizePDF(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<LinearizePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/linearizePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<LinearizePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CombinePDFResponse> CombinePDF(Expression<Func<string>> filesArraymergedPDFFileName, Expression<Func<string[]>> filesArrayfiles, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_filesArraymergedPDFFileName = WorkflowExpression.Compile(filesArraymergedPDFFileName, nameof(filesArraymergedPDFFileName), required: true);
            var __workflow_filesArrayfiles = WorkflowExpression.Compile(filesArrayfiles, nameof(filesArrayfiles), required: true);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CombinePDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/combinePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                var filesArray = new JObject();
                var filesArraypropCount = 0;
                filesArraypropCount++;
                filesArray["outputFileName"] = ExpressionConverter.ConvertO(__workflow_filesArraymergedPDFFileName);
                filesArraypropCount++;
                filesArray["files"] = ExpressionConverter.ConvertO(__workflow_filesArrayfiles);
                if (filesArraypropCount > 0)
                {
                    callPayload.Body = filesArray;
                }

                return new ApiConnectionAction<CombinePDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<OCRPDFResponse> OcrPDF(Expression<Func<string>> inputFileName, Expression<Func<ocrLocaleInput>> ocrLocale, Expression<Func<ocrTypeInput>> ocrType, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_ocrLocale = WorkflowExpression.Compile(ocrLocale, nameof(ocrLocale), required: true);
            var __workflow_ocrType = WorkflowExpression.Compile(ocrType, nameof(ocrType), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<OCRPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<OCRPDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectUserPDF(Expression<Func<string>> inputFileName, Expression<Func<string>> userPassword, Expression<Func<contentEncryptionInput>> contentEncryption, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_userPassword = WorkflowExpression.Compile(userPassword, nameof(userPassword), required: true);
            var __workflow_contentEncryption = WorkflowExpression.Compile(contentEncryption, nameof(contentEncryption), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/protectUserPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ProtectPDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectOwnerPDF(Expression<Func<string>> inputFileName, Expression<Func<string>> ownerPassword, Expression<Func<contentEncryptionInput>> contentEncryption, Expression<Func<bool>> allowPrintLowQuality, Expression<Func<bool>> allowPrintHighQuality, Expression<Func<bool>> allowEditContent, Expression<Func<bool>> allowEditDocumentAssembly, Expression<Func<bool>> allowEditAnnotations, Expression<Func<bool>> allowEditFillAndSignFormFields, Expression<Func<bool>> allowCopyContent, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_ownerPassword = WorkflowExpression.Compile(ownerPassword, nameof(ownerPassword), required: true);
            var __workflow_contentEncryption = WorkflowExpression.Compile(contentEncryption, nameof(contentEncryption), required: true);
            var __workflow_allowPrintLowQuality = WorkflowExpression.Compile(allowPrintLowQuality, nameof(allowPrintLowQuality), required: true);
            var __workflow_allowPrintHighQuality = WorkflowExpression.Compile(allowPrintHighQuality, nameof(allowPrintHighQuality), required: true);
            var __workflow_allowEditContent = WorkflowExpression.Compile(allowEditContent, nameof(allowEditContent), required: true);
            var __workflow_allowEditDocumentAssembly = WorkflowExpression.Compile(allowEditDocumentAssembly, nameof(allowEditDocumentAssembly), required: true);
            var __workflow_allowEditAnnotations = WorkflowExpression.Compile(allowEditAnnotations, nameof(allowEditAnnotations), required: true);
            var __workflow_allowEditFillAndSignFormFields = WorkflowExpression.Compile(allowEditFillAndSignFormFields, nameof(allowEditFillAndSignFormFields), required: true);
            var __workflow_allowCopyContent = WorkflowExpression.Compile(allowCopyContent, nameof(allowCopyContent), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/protectOwnerPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ProtectPDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<ProtectPDFResponse> ProtectGenericPDF(Expression<Func<string>> inputFileName, Expression<Func<string>> userPassword, Expression<Func<string>> ownerPassword, Expression<Func<contentEncryptionInput>> contentEncryption, Expression<Func<bool>> allowPrintLowQuality, Expression<Func<bool>> allowPrintHighQuality, Expression<Func<bool>> allowEditContent, Expression<Func<bool>> allowEditDocumentAssembly, Expression<Func<bool>> allowEditAnnotations, Expression<Func<bool>> allowEditFillAndSignFormFields, Expression<Func<bool>> allowCopyContent, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_userPassword = WorkflowExpression.Compile(userPassword, nameof(userPassword), required: true);
            var __workflow_ownerPassword = WorkflowExpression.Compile(ownerPassword, nameof(ownerPassword), required: true);
            var __workflow_contentEncryption = WorkflowExpression.Compile(contentEncryption, nameof(contentEncryption), required: true);
            var __workflow_allowPrintLowQuality = WorkflowExpression.Compile(allowPrintLowQuality, nameof(allowPrintLowQuality), required: true);
            var __workflow_allowPrintHighQuality = WorkflowExpression.Compile(allowPrintHighQuality, nameof(allowPrintHighQuality), required: true);
            var __workflow_allowEditContent = WorkflowExpression.Compile(allowEditContent, nameof(allowEditContent), required: true);
            var __workflow_allowEditDocumentAssembly = WorkflowExpression.Compile(allowEditDocumentAssembly, nameof(allowEditDocumentAssembly), required: true);
            var __workflow_allowEditAnnotations = WorkflowExpression.Compile(allowEditAnnotations, nameof(allowEditAnnotations), required: true);
            var __workflow_allowEditFillAndSignFormFields = WorkflowExpression.Compile(allowEditFillAndSignFormFields, nameof(allowEditFillAndSignFormFields), required: true);
            var __workflow_allowCopyContent = WorkflowExpression.Compile(allowCopyContent, nameof(allowCopyContent), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<ProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/protectGenericPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<ProtectPDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<UnProtectPDFResponse> RemovePassword(Expression<Func<string>> inputFileName, Expression<Func<string>> password, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<UnProtectPDFResponse>(() =>
            {
                var apiCallPath = "/operation/v1/removeProtection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<UnProtectPDFResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseSplitDocument> SplitPDF(Expression<Func<string>> inputFileName, Expression<Func<splitByTypeInput>> splitByType, Expression<Func<string>> splitConfiguration, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_splitByType = WorkflowExpression.Compile(splitByType, nameof(splitByType), required: true);
            var __workflow_splitConfiguration = WorkflowExpression.Compile(splitConfiguration, nameof(splitConfiguration), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseSplitDocument>(() =>
            {
                var apiCallPath = "/operation/v1/splitPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseSplitDocument>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractImages> ExtractImagesFromPDF(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractImages>(() =>
            {
                var apiCallPath = "/operation/v1/extractImagesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractImages>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractTables> ExtractTablesFromPDF(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractTables>(() =>
            {
                var apiCallPath = "/operation/v1/extractTablesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractTables>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractJSONFile> ExtractJSONFileFromPDF(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<bool>> addCharInfo = null, Expression<Func<bool>> getStylingInfo = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_addCharInfo = WorkflowExpression.Compile(addCharInfo, nameof(addCharInfo), required: false);
            var __workflow_getStylingInfo = WorkflowExpression.Compile(getStylingInfo, nameof(getStylingInfo), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractJSONFile>(() =>
            {
                var apiCallPath = "/operation/v1/extractJSONFileFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractJSONFile>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractJsonObject> ExtractJSONObjectFromPDF(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<bool>> addCharInfo = null, Expression<Func<bool>> getStylingInfo = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_addCharInfo = WorkflowExpression.Compile(addCharInfo, nameof(addCharInfo), required: false);
            var __workflow_getStylingInfo = WorkflowExpression.Compile(getStylingInfo, nameof(getStylingInfo), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractJsonObject>(() =>
            {
                var apiCallPath = "/operation/v1/extractJSONObjectFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractJsonObject>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseExtractDocument> ExtractJSONAndImagesAndTablesFromPDF(Expression<Func<bool>> addTables, Expression<Func<bool>> addFigures, Expression<Func<pdfStructureOutputFormatInput>> pdfStructureOutputFormat, Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<bool>> addCharInfo = null, Expression<Func<bool>> getStylingInfo = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_addTables = WorkflowExpression.Compile(addTables, nameof(addTables), required: true);
            var __workflow_addFigures = WorkflowExpression.Compile(addFigures, nameof(addFigures), required: true);
            var __workflow_pdfStructureOutputFormat = WorkflowExpression.Compile(pdfStructureOutputFormat, nameof(pdfStructureOutputFormat), required: true);
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_addCharInfo = WorkflowExpression.Compile(addCharInfo, nameof(addCharInfo), required: false);
            var __workflow_getStylingInfo = WorkflowExpression.Compile(getStylingInfo, nameof(getStylingInfo), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseExtractDocument>(() =>
            {
                var apiCallPath = "/operation/v1/extractJSONAndImagesAndTablesFromPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseExtractDocument>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponsePDFProperties> PDFProperties(Expression<Func<string>> inputFileName, Expression<Func<object>> inputFile0, Expression<Func<bool>> pageLevel, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_pageLevel = WorkflowExpression.Compile(pageLevel, nameof(pageLevel), required: true);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponsePDFProperties>(() =>
            {
                var apiCallPath = "/operation/v1/pdfProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponsePDFProperties>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DocGenResponse> DocGen(Expression<Func<string>> inputFileName, Expression<Func<string>> jsonStringForMerge, Expression<Func<targetFormatInput>> targetFormat, Expression<Func<object>> inputFile0, Expression<Func<string>> outputFileName = null, Expression<Func<string>> fragments = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_jsonStringForMerge = WorkflowExpression.Compile(jsonStringForMerge, nameof(jsonStringForMerge), required: true);
            var __workflow_targetFormat = WorkflowExpression.Compile(targetFormat, nameof(targetFormat), required: true);
            var __workflow_inputFile0 = WorkflowExpression.Compile(inputFile0, nameof(inputFile0), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_fragments = WorkflowExpression.Compile(fragments, nameof(fragments), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DocGenResponse>(() =>
            {
                var apiCallPath = "/operation/v1/docGen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DocGenResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<DtoResponseAutotagPDF> AutoTag(Expression<Func<string>> inputFileName, Expression<Func<object>> fileData, Expression<Func<bool>> generateReport, Expression<Func<bool>> shiftHeadings, Expression<Func<string>> outputFileName = null, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_inputFileName = WorkflowExpression.Compile(inputFileName, nameof(inputFileName), required: true);
            var __workflow_fileData = WorkflowExpression.Compile(fileData, nameof(fileData), required: true);
            var __workflow_generateReport = WorkflowExpression.Compile(generateReport, nameof(generateReport), required: true);
            var __workflow_shiftHeadings = WorkflowExpression.Compile(shiftHeadings, nameof(shiftHeadings), required: true);
            var __workflow_outputFileName = WorkflowExpression.Compile(outputFileName, nameof(outputFileName), required: false);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<DtoResponseAutotagPDF>(() =>
            {
                var apiCallPath = "/operation/v1/accessibility";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                return new ApiConnectionAction<DtoResponseAutotagPDF>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum signatureFormatInput
    {
        PADES,
        PKCS7
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sealImageFormatInput
    {
        [EnumMember(Value = "image/jpeg")]
        JPEG,
        [EnumMember(Value = "image/png")]
        PNG,
        [EnumMember(Value = "application/pdf")]
        PDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
