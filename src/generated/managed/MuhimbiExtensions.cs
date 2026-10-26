//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> CompositeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkData, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkData = WorkflowExpression.Compile(inputDatawatermarkData, nameof(inputDatawatermarkData), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/composite_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["watermark_data"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkData);
                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> CompressPdf(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDataremoveAnnotationsInput>> inputPdfDataremoveAnnotations = null, Expression<Func<inputPdfDataremoveBlankPagesInput>> inputPdfDataremoveBlankPages = null, Expression<Func<inputPdfDataremoveBookmarksInput>> inputPdfDataremoveBookmarks = null, Expression<Func<inputPdfDataremoveEmbeddedFilesInput>> inputPdfDataremoveEmbeddedFiles = null, Expression<Func<inputPdfDataremoveFormFieldsInput>> inputPdfDataremoveFormFields = null, Expression<Func<inputPdfDataremoveHyperlinksInput>> inputPdfDataremoveHyperlinks = null, Expression<Func<inputPdfDataremoveJavaScriptInput>> inputPdfDataremoveJavaScript = null, Expression<Func<inputPdfDataremoveMetadataInput>> inputPdfDataremoveMetadata = null, Expression<Func<inputPdfDataremovePageThumbnailsInput>> inputPdfDataremovePageThumbnails = null, Expression<Func<inputPdfDatapackFontsInput>> inputPdfDatapackFonts = null, Expression<Func<inputPdfDatapackDocumentInput>> inputPdfDatapackDocument = null, Expression<Func<inputPdfDatarecompressImagesInput>> inputPdfDatarecompressImages = null, Expression<Func<inputPdfDataenableMRCInput>> inputPdfDataenableMRC = null, Expression<Func<int>> inputPdfDatadownscaleResolutionMRC = null, Expression<Func<inputPdfDatapreserveSmoothingInput>> inputPdfDatapreserveSmoothing = null, Expression<Func<inputPdfDataimageQualityInput>> inputPdfDataimageQuality = null, Expression<Func<inputPdfDatadownscaleImagesInput>> inputPdfDatadownscaleImages = null, Expression<Func<int>> inputPdfDatadownscaleResolution = null, Expression<Func<inputPdfDataenableColorDetectionInput>> inputPdfDataenableColorDetection = null, Expression<Func<inputPdfDataenableCharRepairInput>> inputPdfDataenableCharRepair = null, Expression<Func<inputPdfDataenableJPEG2000Input>> inputPdfDataenableJPEG2000 = null, Expression<Func<inputPdfDataenableJBIG2Input>> inputPdfDataenableJBIG2 = null, Expression<Func<int>> inputPdfDatajBIG2PMSThreshold = null, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataremoveAnnotations = WorkflowExpression.Compile(inputPdfDataremoveAnnotations, nameof(inputPdfDataremoveAnnotations), required: false);
            var __workflow_inputPdfDataremoveBlankPages = WorkflowExpression.Compile(inputPdfDataremoveBlankPages, nameof(inputPdfDataremoveBlankPages), required: false);
            var __workflow_inputPdfDataremoveBookmarks = WorkflowExpression.Compile(inputPdfDataremoveBookmarks, nameof(inputPdfDataremoveBookmarks), required: false);
            var __workflow_inputPdfDataremoveEmbeddedFiles = WorkflowExpression.Compile(inputPdfDataremoveEmbeddedFiles, nameof(inputPdfDataremoveEmbeddedFiles), required: false);
            var __workflow_inputPdfDataremoveFormFields = WorkflowExpression.Compile(inputPdfDataremoveFormFields, nameof(inputPdfDataremoveFormFields), required: false);
            var __workflow_inputPdfDataremoveHyperlinks = WorkflowExpression.Compile(inputPdfDataremoveHyperlinks, nameof(inputPdfDataremoveHyperlinks), required: false);
            var __workflow_inputPdfDataremoveJavaScript = WorkflowExpression.Compile(inputPdfDataremoveJavaScript, nameof(inputPdfDataremoveJavaScript), required: false);
            var __workflow_inputPdfDataremoveMetadata = WorkflowExpression.Compile(inputPdfDataremoveMetadata, nameof(inputPdfDataremoveMetadata), required: false);
            var __workflow_inputPdfDataremovePageThumbnails = WorkflowExpression.Compile(inputPdfDataremovePageThumbnails, nameof(inputPdfDataremovePageThumbnails), required: false);
            var __workflow_inputPdfDatapackFonts = WorkflowExpression.Compile(inputPdfDatapackFonts, nameof(inputPdfDatapackFonts), required: false);
            var __workflow_inputPdfDatapackDocument = WorkflowExpression.Compile(inputPdfDatapackDocument, nameof(inputPdfDatapackDocument), required: false);
            var __workflow_inputPdfDatarecompressImages = WorkflowExpression.Compile(inputPdfDatarecompressImages, nameof(inputPdfDatarecompressImages), required: false);
            var __workflow_inputPdfDataenableMRC = WorkflowExpression.Compile(inputPdfDataenableMRC, nameof(inputPdfDataenableMRC), required: false);
            var __workflow_inputPdfDatadownscaleResolutionMRC = WorkflowExpression.Compile(inputPdfDatadownscaleResolutionMRC, nameof(inputPdfDatadownscaleResolutionMRC), required: false);
            var __workflow_inputPdfDatapreserveSmoothing = WorkflowExpression.Compile(inputPdfDatapreserveSmoothing, nameof(inputPdfDatapreserveSmoothing), required: false);
            var __workflow_inputPdfDataimageQuality = WorkflowExpression.Compile(inputPdfDataimageQuality, nameof(inputPdfDataimageQuality), required: false);
            var __workflow_inputPdfDatadownscaleImages = WorkflowExpression.Compile(inputPdfDatadownscaleImages, nameof(inputPdfDatadownscaleImages), required: false);
            var __workflow_inputPdfDatadownscaleResolution = WorkflowExpression.Compile(inputPdfDatadownscaleResolution, nameof(inputPdfDatadownscaleResolution), required: false);
            var __workflow_inputPdfDataenableColorDetection = WorkflowExpression.Compile(inputPdfDataenableColorDetection, nameof(inputPdfDataenableColorDetection), required: false);
            var __workflow_inputPdfDataenableCharRepair = WorkflowExpression.Compile(inputPdfDataenableCharRepair, nameof(inputPdfDataenableCharRepair), required: false);
            var __workflow_inputPdfDataenableJPEG2000 = WorkflowExpression.Compile(inputPdfDataenableJPEG2000, nameof(inputPdfDataenableJPEG2000), required: false);
            var __workflow_inputPdfDataenableJBIG2 = WorkflowExpression.Compile(inputPdfDataenableJBIG2, nameof(inputPdfDataenableJBIG2), required: false);
            var __workflow_inputPdfDatajBIG2PMSThreshold = WorkflowExpression.Compile(inputPdfDatajBIG2PMSThreshold, nameof(inputPdfDatajBIG2PMSThreshold), required: false);
            var __workflow_inputPdfDataoverrideSettings = WorkflowExpression.Compile(inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/compress_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                if (__workflow_inputPdfDataremoveAnnotations != null)
                {
                    if (__workflow_inputPdfDataremoveAnnotations != null)
                    {
                        inputPdfData["remove_annotations"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveAnnotations);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_annotations"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveBlankPages != null)
                {
                    if (__workflow_inputPdfDataremoveBlankPages != null)
                    {
                        inputPdfData["remove_blank_pages"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveBlankPages);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_blank_pages"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveBookmarks != null)
                {
                    if (__workflow_inputPdfDataremoveBookmarks != null)
                    {
                        inputPdfData["remove_bookmarks"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveBookmarks);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_bookmarks"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveEmbeddedFiles != null)
                {
                    if (__workflow_inputPdfDataremoveEmbeddedFiles != null)
                    {
                        inputPdfData["remove_embedded_files"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveEmbeddedFiles);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_embedded_files"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveFormFields != null)
                {
                    if (__workflow_inputPdfDataremoveFormFields != null)
                    {
                        inputPdfData["remove_form_fields"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveFormFields);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_form_fields"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveHyperlinks != null)
                {
                    if (__workflow_inputPdfDataremoveHyperlinks != null)
                    {
                        inputPdfData["remove_hyperlinks"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveHyperlinks);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_hyperlinks"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveJavaScript != null)
                {
                    if (__workflow_inputPdfDataremoveJavaScript != null)
                    {
                        inputPdfData["remove_javascript"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveJavaScript);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_javascript"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremoveMetadata != null)
                {
                    if (__workflow_inputPdfDataremoveMetadata != null)
                    {
                        inputPdfData["remove_metadata"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremoveMetadata);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_metadata"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataremovePageThumbnails != null)
                {
                    if (__workflow_inputPdfDataremovePageThumbnails != null)
                    {
                        inputPdfData["remove_page_thumbnails"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataremovePageThumbnails);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_page_thumbnails"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapackFonts != null)
                {
                    if (__workflow_inputPdfDatapackFonts != null)
                    {
                        inputPdfData["pack_fonts"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapackFonts);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["pack_fonts"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapackDocument != null)
                {
                    if (__workflow_inputPdfDatapackDocument != null)
                    {
                        inputPdfData["pack_document"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapackDocument);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["pack_document"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatarecompressImages != null)
                {
                    if (__workflow_inputPdfDatarecompressImages != null)
                    {
                        inputPdfData["recompress_images"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatarecompressImages);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["recompress_images"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataenableMRC != null)
                {
                    if (__workflow_inputPdfDataenableMRC != null)
                    {
                        inputPdfData["enable_mrc"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataenableMRC);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_mrc"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatadownscaleResolutionMRC != null)
                {
                    if (__workflow_inputPdfDatadownscaleResolutionMRC != null)
                    {
                        inputPdfData["downscale_resolution_mrc"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatadownscaleResolutionMRC);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["downscale_resolution_mrc"] = 100;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapreserveSmoothing != null)
                {
                    if (__workflow_inputPdfDatapreserveSmoothing != null)
                    {
                        inputPdfData["preserve_smoothing"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapreserveSmoothing);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["preserve_smoothing"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataimageQuality != null)
                {
                    if (__workflow_inputPdfDataimageQuality != null)
                    {
                        inputPdfData["image_quality"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataimageQuality);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["image_quality"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatadownscaleImages != null)
                {
                    if (__workflow_inputPdfDatadownscaleImages != null)
                    {
                        inputPdfData["downscale_images"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatadownscaleImages);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["downscale_images"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatadownscaleResolution != null)
                {
                    if (__workflow_inputPdfDatadownscaleResolution != null)
                    {
                        inputPdfData["downscale_resolution"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatadownscaleResolution);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["downscale_resolution"] = 200;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataenableColorDetection != null)
                {
                    if (__workflow_inputPdfDataenableColorDetection != null)
                    {
                        inputPdfData["enable_color_detection"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataenableColorDetection);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_color_detection"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataenableCharRepair != null)
                {
                    if (__workflow_inputPdfDataenableCharRepair != null)
                    {
                        inputPdfData["enable_char_repair"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataenableCharRepair);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_char_repair"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataenableJPEG2000 != null)
                {
                    if (__workflow_inputPdfDataenableJPEG2000 != null)
                    {
                        inputPdfData["enable_jpeg2000"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataenableJPEG2000);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_jpeg2000"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataenableJBIG2 != null)
                {
                    if (__workflow_inputPdfDataenableJBIG2 != null)
                    {
                        inputPdfData["enable_jbig2"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataenableJBIG2);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_jbig2"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatajBIG2PMSThreshold != null)
                {
                    if (__workflow_inputPdfDatajBIG2PMSThreshold != null)
                    {
                        inputPdfData["jbig2_pms_threshold"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatajBIG2PMSThreshold);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["jbig2_pms_threshold"] = 85;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataoverrideSettings != null)
                {
                    inputPdfData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataoverrideSettings);
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> Convert(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDataoutputFormatInput>> inputDataoutputFormat, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<string>> inputDatatemplateFileContent = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataoutputFormat = WorkflowExpression.Compile(inputDataoutputFormat, nameof(inputDataoutputFormat), required: true);
            var __workflow_inputDataoverrideSettings = WorkflowExpression.Compile(inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            var __workflow_inputDatatemplateFileContent = WorkflowExpression.Compile(inputDatatemplateFileContent, nameof(inputDatatemplateFileContent), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputDataoutputFormat);
                inputData["copy_metadata"] = false;
                inputDatapropCount++;
                if (__workflow_inputDataoverrideSettings != null)
                {
                    inputData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputDataoverrideSettings);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatatemplateFileContent != null)
                {
                    inputData["template_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatatemplateFileContent);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertCad(Expression<Func<string>> inputCadDatasourceFileName, Expression<Func<string>> inputCadDatasourceFileContent, Expression<Func<inputCadDatapaperSizeInput>> inputCadDatapaperSize = null, Expression<Func<string>> inputCadDatapaperSizeCustom = null, Expression<Func<string>> inputCadDatapageMargins = null, Expression<Func<string>> inputCadDatabackgroundColor = null, Expression<Func<inputCadDataforegroundColorInput>> inputCadDataforegroundColor = null, Expression<Func<string>> inputCadDataforegroundColorCustom = null, Expression<Func<inputCadDataemptyLayoutDetectionInput>> inputCadDataemptyLayoutDetection = null, Expression<Func<inputCadDatalayoutSortOrderInput>> inputCadDatalayoutSortOrder = null, Expression<Func<int>> inputCadDatastartPage = null, Expression<Func<int>> inputCadDataendPage = null, Expression<Func<string>> inputCadDataoverrideSettings = null, Expression<Func<bool>> inputCadDatafailOnError = null)
        {
            var __workflow_inputCadDatasourceFileName = WorkflowExpression.Compile(inputCadDatasourceFileName, nameof(inputCadDatasourceFileName), required: true);
            var __workflow_inputCadDatasourceFileContent = WorkflowExpression.Compile(inputCadDatasourceFileContent, nameof(inputCadDatasourceFileContent), required: true);
            var __workflow_inputCadDatapaperSize = WorkflowExpression.Compile(inputCadDatapaperSize, nameof(inputCadDatapaperSize), required: false);
            var __workflow_inputCadDatapaperSizeCustom = WorkflowExpression.Compile(inputCadDatapaperSizeCustom, nameof(inputCadDatapaperSizeCustom), required: false);
            var __workflow_inputCadDatapageMargins = WorkflowExpression.Compile(inputCadDatapageMargins, nameof(inputCadDatapageMargins), required: false);
            var __workflow_inputCadDatabackgroundColor = WorkflowExpression.Compile(inputCadDatabackgroundColor, nameof(inputCadDatabackgroundColor), required: false);
            var __workflow_inputCadDataforegroundColor = WorkflowExpression.Compile(inputCadDataforegroundColor, nameof(inputCadDataforegroundColor), required: false);
            var __workflow_inputCadDataforegroundColorCustom = WorkflowExpression.Compile(inputCadDataforegroundColorCustom, nameof(inputCadDataforegroundColorCustom), required: false);
            var __workflow_inputCadDataemptyLayoutDetection = WorkflowExpression.Compile(inputCadDataemptyLayoutDetection, nameof(inputCadDataemptyLayoutDetection), required: false);
            var __workflow_inputCadDatalayoutSortOrder = WorkflowExpression.Compile(inputCadDatalayoutSortOrder, nameof(inputCadDatalayoutSortOrder), required: false);
            var __workflow_inputCadDatastartPage = WorkflowExpression.Compile(inputCadDatastartPage, nameof(inputCadDatastartPage), required: false);
            var __workflow_inputCadDataendPage = WorkflowExpression.Compile(inputCadDataendPage, nameof(inputCadDataendPage), required: false);
            var __workflow_inputCadDataoverrideSettings = WorkflowExpression.Compile(inputCadDataoverrideSettings, nameof(inputCadDataoverrideSettings), required: false);
            var __workflow_inputCadDatafailOnError = WorkflowExpression.Compile(inputCadDatafailOnError, nameof(inputCadDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_cad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputCadData = new JObject();
                var inputCadDatapropCount = 0;
                inputCadData["use_async_pattern"] = false;
                inputCadDatapropCount++;
                inputCadDatapropCount++;
                inputCadData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputCadDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputCadData["sharepoint_file"] = sharepointFileObject;
                    inputCadDatapropCount++;
                }

                inputCadDatapropCount++;
                inputCadData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputCadDatasourceFileContent);
                inputCadData["copy_metadata"] = false;
                inputCadDatapropCount++;
                if (__workflow_inputCadDatapaperSize != null)
                {
                    if (__workflow_inputCadDatapaperSize != null)
                    {
                        inputCadData["paper_size"] = ExpressionConverter.ConvertO(__workflow_inputCadDatapaperSize);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["paper_size"] = "Letter";
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDatapaperSizeCustom != null)
                {
                    inputCadData["paper_size_custom"] = ExpressionConverter.ConvertO(__workflow_inputCadDatapaperSizeCustom);
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDatapageMargins != null)
                {
                    if (__workflow_inputCadDatapageMargins != null)
                    {
                        inputCadData["page_margins"] = ExpressionConverter.ConvertO(__workflow_inputCadDatapageMargins);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["page_margins"] = "0.25";
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDatabackgroundColor != null)
                {
                    if (__workflow_inputCadDatabackgroundColor != null)
                    {
                        inputCadData["background_color"] = ExpressionConverter.ConvertO(__workflow_inputCadDatabackgroundColor);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["background_color"] = "White";
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDataforegroundColor != null)
                {
                    if (__workflow_inputCadDataforegroundColor != null)
                    {
                        inputCadData["foreground_color"] = ExpressionConverter.ConvertO(__workflow_inputCadDataforegroundColor);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["foreground_color"] = "GreyscaleDarken";
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDataforegroundColorCustom != null)
                {
                    inputCadData["foreground_color_custom"] = ExpressionConverter.ConvertO(__workflow_inputCadDataforegroundColorCustom);
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDataemptyLayoutDetection != null)
                {
                    if (__workflow_inputCadDataemptyLayoutDetection != null)
                    {
                        inputCadData["empty_layout_detection_mode"] = ExpressionConverter.ConvertO(__workflow_inputCadDataemptyLayoutDetection);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["empty_layout_detection_mode"] = "SkipEmptyLayouts";
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDatalayoutSortOrder != null)
                {
                    if (__workflow_inputCadDatalayoutSortOrder != null)
                    {
                        inputCadData["layout_sort_order"] = ExpressionConverter.ConvertO(__workflow_inputCadDatalayoutSortOrder);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["layout_sort_order"] = "Ascending";
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDatastartPage != null)
                {
                    inputCadData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputCadDatastartPage);
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDataendPage != null)
                {
                    inputCadData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputCadDataendPage);
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDataoverrideSettings != null)
                {
                    inputCadData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputCadDataoverrideSettings);
                    inputCadDatapropCount++;
                }

                if (__workflow_inputCadDatafailOnError != null)
                {
                    if (__workflow_inputCadDatafailOnError != null)
                    {
                        inputCadData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputCadDatafailOnError);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["fail_on_error"] = true;
                    inputCadDatapropCount++;
                }

                if (inputCadDatapropCount > 0)
                {
                    callPayload.Body = inputCadData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertEmail(Expression<Func<string>> inputEmailDatasourceFileName, Expression<Func<string>> inputEmailDatasourceFileContent, Expression<Func<bool>> inputEmailDataincludeAttachments = null, Expression<Func<inputEmailDataattachmentActionInput>> inputEmailDataattachmentAction = null, Expression<Func<bool>> inputEmailDataattachmentSummary = null, Expression<Func<inputEmailDataunsupportedAttachmentActionInput>> inputEmailDataunsupportedAttachmentAction = null, Expression<Func<string>> inputEmailDataincludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataexcludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataviewportSize = null, Expression<Func<inputEmailDatapaperSizeInput>> inputEmailDatapaperSize = null, Expression<Func<string>> inputEmailDatapaperSizeCustom = null, Expression<Func<string>> inputEmailDatapageMargins = null, Expression<Func<bool>> inputEmailDataattachmentErrors = null, Expression<Func<int>> inputEmailDataminImageSize = null, Expression<Func<bool>> inputEmailDataofflineMode = null, Expression<Func<int>> inputEmailDatastartPage = null, Expression<Func<int>> inputEmailDataendPage = null, Expression<Func<inputEmailDataconversionQualityInput>> inputEmailDataconversionQuality = null, Expression<Func<string>> inputEmailDataoverrideSettings = null, Expression<Func<bool>> inputEmailDatafailOnError = null)
        {
            var __workflow_inputEmailDatasourceFileName = WorkflowExpression.Compile(inputEmailDatasourceFileName, nameof(inputEmailDatasourceFileName), required: true);
            var __workflow_inputEmailDatasourceFileContent = WorkflowExpression.Compile(inputEmailDatasourceFileContent, nameof(inputEmailDatasourceFileContent), required: true);
            var __workflow_inputEmailDataincludeAttachments = WorkflowExpression.Compile(inputEmailDataincludeAttachments, nameof(inputEmailDataincludeAttachments), required: false);
            var __workflow_inputEmailDataattachmentAction = WorkflowExpression.Compile(inputEmailDataattachmentAction, nameof(inputEmailDataattachmentAction), required: false);
            var __workflow_inputEmailDataattachmentSummary = WorkflowExpression.Compile(inputEmailDataattachmentSummary, nameof(inputEmailDataattachmentSummary), required: false);
            var __workflow_inputEmailDataunsupportedAttachmentAction = WorkflowExpression.Compile(inputEmailDataunsupportedAttachmentAction, nameof(inputEmailDataunsupportedAttachmentAction), required: false);
            var __workflow_inputEmailDataincludeAttachmentFilter = WorkflowExpression.Compile(inputEmailDataincludeAttachmentFilter, nameof(inputEmailDataincludeAttachmentFilter), required: false);
            var __workflow_inputEmailDataexcludeAttachmentFilter = WorkflowExpression.Compile(inputEmailDataexcludeAttachmentFilter, nameof(inputEmailDataexcludeAttachmentFilter), required: false);
            var __workflow_inputEmailDataviewportSize = WorkflowExpression.Compile(inputEmailDataviewportSize, nameof(inputEmailDataviewportSize), required: false);
            var __workflow_inputEmailDatapaperSize = WorkflowExpression.Compile(inputEmailDatapaperSize, nameof(inputEmailDatapaperSize), required: false);
            var __workflow_inputEmailDatapaperSizeCustom = WorkflowExpression.Compile(inputEmailDatapaperSizeCustom, nameof(inputEmailDatapaperSizeCustom), required: false);
            var __workflow_inputEmailDatapageMargins = WorkflowExpression.Compile(inputEmailDatapageMargins, nameof(inputEmailDatapageMargins), required: false);
            var __workflow_inputEmailDataattachmentErrors = WorkflowExpression.Compile(inputEmailDataattachmentErrors, nameof(inputEmailDataattachmentErrors), required: false);
            var __workflow_inputEmailDataminImageSize = WorkflowExpression.Compile(inputEmailDataminImageSize, nameof(inputEmailDataminImageSize), required: false);
            var __workflow_inputEmailDataofflineMode = WorkflowExpression.Compile(inputEmailDataofflineMode, nameof(inputEmailDataofflineMode), required: false);
            var __workflow_inputEmailDatastartPage = WorkflowExpression.Compile(inputEmailDatastartPage, nameof(inputEmailDatastartPage), required: false);
            var __workflow_inputEmailDataendPage = WorkflowExpression.Compile(inputEmailDataendPage, nameof(inputEmailDataendPage), required: false);
            var __workflow_inputEmailDataconversionQuality = WorkflowExpression.Compile(inputEmailDataconversionQuality, nameof(inputEmailDataconversionQuality), required: false);
            var __workflow_inputEmailDataoverrideSettings = WorkflowExpression.Compile(inputEmailDataoverrideSettings, nameof(inputEmailDataoverrideSettings), required: false);
            var __workflow_inputEmailDatafailOnError = WorkflowExpression.Compile(inputEmailDatafailOnError, nameof(inputEmailDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputEmailData = new JObject();
                var inputEmailDatapropCount = 0;
                inputEmailData["use_async_pattern"] = false;
                inputEmailDatapropCount++;
                inputEmailDatapropCount++;
                inputEmailData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputEmailData["sharepoint_file"] = sharepointFileObject;
                    inputEmailDatapropCount++;
                }

                inputEmailDatapropCount++;
                inputEmailData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatasourceFileContent);
                inputEmailData["copy_metadata"] = false;
                inputEmailDatapropCount++;
                if (__workflow_inputEmailDataincludeAttachments != null)
                {
                    if (__workflow_inputEmailDataincludeAttachments != null)
                    {
                        inputEmailData["convert_attachments"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataincludeAttachments);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["convert_attachments"] = true;
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataattachmentAction != null)
                {
                    inputEmailData["attachment_merge_mode"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataattachmentAction);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataattachmentSummary != null)
                {
                    if (__workflow_inputEmailDataattachmentSummary != null)
                    {
                        inputEmailData["display_attachment_summary"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataattachmentSummary);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["display_attachment_summary"] = true;
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataunsupportedAttachmentAction != null)
                {
                    if (__workflow_inputEmailDataunsupportedAttachmentAction != null)
                    {
                        inputEmailData["unsupported_attachment_behaviour"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataunsupportedAttachmentAction);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["unsupported_attachment_behaviour"] = "Error";
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataincludeAttachmentFilter != null)
                {
                    inputEmailData["include_attachment_types"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataincludeAttachmentFilter);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataexcludeAttachmentFilter != null)
                {
                    inputEmailData["exclude_attachment_types"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataexcludeAttachmentFilter);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataviewportSize != null)
                {
                    if (__workflow_inputEmailDataviewportSize != null)
                    {
                        inputEmailData["viewport_Size"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataviewportSize);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["viewport_Size"] = "Paper";
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDatapaperSize != null)
                {
                    if (__workflow_inputEmailDatapaperSize != null)
                    {
                        inputEmailData["paper_size"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatapaperSize);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["paper_size"] = "Letter";
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDatapaperSizeCustom != null)
                {
                    inputEmailData["paper_size_custom"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatapaperSizeCustom);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDatapageMargins != null)
                {
                    if (__workflow_inputEmailDatapageMargins != null)
                    {
                        inputEmailData["page_margins"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatapageMargins);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["page_margins"] = "0.5,0.5,0.5,0.5";
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataattachmentErrors != null)
                {
                    inputEmailData["break_merge_on_error"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataattachmentErrors);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataminImageSize != null)
                {
                    if (__workflow_inputEmailDataminImageSize != null)
                    {
                        inputEmailData["minimum_image_attachment_dimension"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataminImageSize);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["minimum_image_attachment_dimension"] = 150;
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataofflineMode != null)
                {
                    if (__workflow_inputEmailDataofflineMode != null)
                    {
                        inputEmailData["enable_offline_mode"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataofflineMode);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["enable_offline_mode"] = false;
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDatastartPage != null)
                {
                    inputEmailData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatastartPage);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataendPage != null)
                {
                    inputEmailData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataendPage);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataconversionQuality != null)
                {
                    inputEmailData["quality"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataconversionQuality);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDataoverrideSettings != null)
                {
                    inputEmailData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputEmailDataoverrideSettings);
                    inputEmailDatapropCount++;
                }

                if (__workflow_inputEmailDatafailOnError != null)
                {
                    if (__workflow_inputEmailDatafailOnError != null)
                    {
                        inputEmailData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputEmailDatafailOnError);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["fail_on_error"] = true;
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatapropCount > 0)
                {
                    callPayload.Body = inputEmailData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertExcel(Expression<Func<string>> inputExcelDatasourceFileName, Expression<Func<string>> inputExcelDatasourceFileContent, Expression<Func<inputExcelDataoutputFormatInput>> inputExcelDataoutputFormat, Expression<Func<inputExcelDatarangeInput>> inputExcelDatarange = null, Expression<Func<bool>> inputExcelDatarevealHiddenRows = null, Expression<Func<bool>> inputExcelDatarevealHiddenColumns = null, Expression<Func<int>> inputExcelDatafitToPagesWide = null, Expression<Func<int>> inputExcelDatafitToPagesTall = null, Expression<Func<int>> inputExcelDatastartPage = null, Expression<Func<int>> inputExcelDataendPage = null, Expression<Func<inputExcelDataqualityInput>> inputExcelDataquality = null, Expression<Func<string>> inputExcelDataoverrideSettings = null, Expression<Func<bool>> inputExcelDatafailOnError = null)
        {
            var __workflow_inputExcelDatasourceFileName = WorkflowExpression.Compile(inputExcelDatasourceFileName, nameof(inputExcelDatasourceFileName), required: true);
            var __workflow_inputExcelDatasourceFileContent = WorkflowExpression.Compile(inputExcelDatasourceFileContent, nameof(inputExcelDatasourceFileContent), required: true);
            var __workflow_inputExcelDataoutputFormat = WorkflowExpression.Compile(inputExcelDataoutputFormat, nameof(inputExcelDataoutputFormat), required: true);
            var __workflow_inputExcelDatarange = WorkflowExpression.Compile(inputExcelDatarange, nameof(inputExcelDatarange), required: false);
            var __workflow_inputExcelDatarevealHiddenRows = WorkflowExpression.Compile(inputExcelDatarevealHiddenRows, nameof(inputExcelDatarevealHiddenRows), required: false);
            var __workflow_inputExcelDatarevealHiddenColumns = WorkflowExpression.Compile(inputExcelDatarevealHiddenColumns, nameof(inputExcelDatarevealHiddenColumns), required: false);
            var __workflow_inputExcelDatafitToPagesWide = WorkflowExpression.Compile(inputExcelDatafitToPagesWide, nameof(inputExcelDatafitToPagesWide), required: false);
            var __workflow_inputExcelDatafitToPagesTall = WorkflowExpression.Compile(inputExcelDatafitToPagesTall, nameof(inputExcelDatafitToPagesTall), required: false);
            var __workflow_inputExcelDatastartPage = WorkflowExpression.Compile(inputExcelDatastartPage, nameof(inputExcelDatastartPage), required: false);
            var __workflow_inputExcelDataendPage = WorkflowExpression.Compile(inputExcelDataendPage, nameof(inputExcelDataendPage), required: false);
            var __workflow_inputExcelDataquality = WorkflowExpression.Compile(inputExcelDataquality, nameof(inputExcelDataquality), required: false);
            var __workflow_inputExcelDataoverrideSettings = WorkflowExpression.Compile(inputExcelDataoverrideSettings, nameof(inputExcelDataoverrideSettings), required: false);
            var __workflow_inputExcelDatafailOnError = WorkflowExpression.Compile(inputExcelDatafailOnError, nameof(inputExcelDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_excel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputExcelData = new JObject();
                var inputExcelDatapropCount = 0;
                inputExcelData["use_async_pattern"] = false;
                inputExcelDatapropCount++;
                inputExcelDatapropCount++;
                inputExcelData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputExcelData["sharepoint_file"] = sharepointFileObject;
                    inputExcelDatapropCount++;
                }

                inputExcelDatapropCount++;
                inputExcelData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatasourceFileContent);
                inputExcelDatapropCount++;
                inputExcelData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputExcelDataoutputFormat);
                inputExcelData["copy_metadata"] = false;
                inputExcelDatapropCount++;
                if (__workflow_inputExcelDatarange != null)
                {
                    inputExcelData["range"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatarange);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDatarevealHiddenRows != null)
                {
                    if (__workflow_inputExcelDatarevealHiddenRows != null)
                    {
                        inputExcelData["unhide_all_rows"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatarevealHiddenRows);
                        inputExcelDatapropCount++;
                    }

                    inputExcelDatapropCount++;
                }
                else
                {
                    inputExcelData["unhide_all_rows"] = false;
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDatarevealHiddenColumns != null)
                {
                    if (__workflow_inputExcelDatarevealHiddenColumns != null)
                    {
                        inputExcelData["unhide_all_columns"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatarevealHiddenColumns);
                        inputExcelDatapropCount++;
                    }

                    inputExcelDatapropCount++;
                }
                else
                {
                    inputExcelData["unhide_all_columns"] = false;
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDatafitToPagesWide != null)
                {
                    inputExcelData["fit_to_pages_wide"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatafitToPagesWide);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDatafitToPagesTall != null)
                {
                    inputExcelData["fit_to_pages_tall"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatafitToPagesTall);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDatastartPage != null)
                {
                    inputExcelData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatastartPage);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDataendPage != null)
                {
                    inputExcelData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputExcelDataendPage);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDataquality != null)
                {
                    inputExcelData["quality"] = ExpressionConverter.ConvertO(__workflow_inputExcelDataquality);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDataoverrideSettings != null)
                {
                    inputExcelData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputExcelDataoverrideSettings);
                    inputExcelDatapropCount++;
                }

                if (__workflow_inputExcelDatafailOnError != null)
                {
                    if (__workflow_inputExcelDatafailOnError != null)
                    {
                        inputExcelData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputExcelDatafailOnError);
                        inputExcelDatapropCount++;
                    }

                    inputExcelDatapropCount++;
                }
                else
                {
                    inputExcelData["fail_on_error"] = true;
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatapropCount > 0)
                {
                    callPayload.Body = inputExcelData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertHtml(Expression<Func<string>> inputDatasourceURLOrHTML, Expression<Func<inputDatapageOrientationInput>> inputDatapageOrientation = null, Expression<Func<inputDatamediaTypeInput>> inputDatamediaType = null, Expression<Func<inputDataauthenticationTypeInput>> inputDataauthenticationType = null, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDataviewportSize = null, Expression<Func<int>> inputDataconversionDelay = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceURLOrHTML = WorkflowExpression.Compile(inputDatasourceURLOrHTML, nameof(inputDatasourceURLOrHTML), required: true);
            var __workflow_inputDatapageOrientation = WorkflowExpression.Compile(inputDatapageOrientation, nameof(inputDatapageOrientation), required: false);
            var __workflow_inputDatamediaType = WorkflowExpression.Compile(inputDatamediaType, nameof(inputDatamediaType), required: false);
            var __workflow_inputDataauthenticationType = WorkflowExpression.Compile(inputDataauthenticationType, nameof(inputDataauthenticationType), required: false);
            var __workflow_inputDatauserName = WorkflowExpression.Compile(inputDatauserName, nameof(inputDatauserName), required: false);
            var __workflow_inputDatapassword = WorkflowExpression.Compile(inputDatapassword, nameof(inputDatapassword), required: false);
            var __workflow_inputDataviewportSize = WorkflowExpression.Compile(inputDataviewportSize, nameof(inputDataviewportSize), required: false);
            var __workflow_inputDataconversionDelay = WorkflowExpression.Compile(inputDataconversionDelay, nameof(inputDataconversionDelay), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_url_or_html"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceURLOrHTML);
                if (__workflow_inputDatapageOrientation != null)
                {
                    if (__workflow_inputDatapageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatapageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Portrait";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatamediaType != null)
                {
                    if (__workflow_inputDatamediaType != null)
                    {
                        inputData["media_type"] = ExpressionConverter.ConvertO(__workflow_inputDatamediaType);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["media_type"] = "Screen";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataauthenticationType != null)
                {
                    if (__workflow_inputDataauthenticationType != null)
                    {
                        inputData["authentication_type"] = ExpressionConverter.ConvertO(__workflow_inputDataauthenticationType);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["authentication_type"] = "Anonymous";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatauserName != null)
                {
                    inputData["username"] = ExpressionConverter.ConvertO(__workflow_inputDatauserName);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatapassword != null)
                {
                    inputData["password"] = ExpressionConverter.ConvertO(__workflow_inputDatapassword);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataviewportSize != null)
                {
                    inputData["viewport_size"] = ExpressionConverter.ConvertO(__workflow_inputDataviewportSize);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataconversionDelay != null)
                {
                    inputData["conversion_delay"] = ExpressionConverter.ConvertO(__workflow_inputDataconversionDelay);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertInfopath(Expression<Func<string>> inputInfopathDatasourceFileName, Expression<Func<string>> inputInfopathDatasourceFileContent, Expression<Func<inputInfopathDataoutputFormatInput>> inputInfopathDataoutputFormat, Expression<Func<string>> inputInfopathDatatemplateFileContent = null, Expression<Func<string>> inputInfopathDataviewNames = null, Expression<Func<bool>> inputInfopathDataincludeAttachment = null, Expression<Func<inputInfopathDataattachmentActionInput>> inputInfopathDataattachmentAction = null, Expression<Func<inputInfopathDataunsupportedAttachmentActionInput>> inputInfopathDataunsupportedAttachmentAction = null, Expression<Func<bool>> inputInfopathDatabreakMergeOnError = null, Expression<Func<string>> inputInfopathDataincludeAttachmentFilter = null, Expression<Func<string>> inputInfopathDataexcludeAttachmentFilter = null, Expression<Func<inputInfopathDatadefaultPaperSizeInput>> inputInfopathDatadefaultPaperSize = null, Expression<Func<string>> inputInfopathDatadefaultPaperSizeCustom = null, Expression<Func<inputInfopathDataforcePaperSizeInput>> inputInfopathDataforcePaperSize = null, Expression<Func<string>> inputInfopathDataforcePaperSizeCustom = null, Expression<Func<inputInfopathDatadefaultPageOrientationInput>> inputInfopathDatadefaultPageOrientation = null, Expression<Func<inputInfopathDataforcePageOrientationInput>> inputInfopathDataforcePageOrientation = null, Expression<Func<int>> inputInfopathDatastartPage = null, Expression<Func<int>> inputInfopathDataendPage = null, Expression<Func<inputInfopathDataconversionQualityInput>> inputInfopathDataconversionQuality = null, Expression<Func<string>> inputInfopathDataoverrideSettings = null, Expression<Func<bool>> inputInfopathDatafailOnError = null)
        {
            var __workflow_inputInfopathDatasourceFileName = WorkflowExpression.Compile(inputInfopathDatasourceFileName, nameof(inputInfopathDatasourceFileName), required: true);
            var __workflow_inputInfopathDatasourceFileContent = WorkflowExpression.Compile(inputInfopathDatasourceFileContent, nameof(inputInfopathDatasourceFileContent), required: true);
            var __workflow_inputInfopathDataoutputFormat = WorkflowExpression.Compile(inputInfopathDataoutputFormat, nameof(inputInfopathDataoutputFormat), required: true);
            var __workflow_inputInfopathDatatemplateFileContent = WorkflowExpression.Compile(inputInfopathDatatemplateFileContent, nameof(inputInfopathDatatemplateFileContent), required: false);
            var __workflow_inputInfopathDataviewNames = WorkflowExpression.Compile(inputInfopathDataviewNames, nameof(inputInfopathDataviewNames), required: false);
            var __workflow_inputInfopathDataincludeAttachment = WorkflowExpression.Compile(inputInfopathDataincludeAttachment, nameof(inputInfopathDataincludeAttachment), required: false);
            var __workflow_inputInfopathDataattachmentAction = WorkflowExpression.Compile(inputInfopathDataattachmentAction, nameof(inputInfopathDataattachmentAction), required: false);
            var __workflow_inputInfopathDataunsupportedAttachmentAction = WorkflowExpression.Compile(inputInfopathDataunsupportedAttachmentAction, nameof(inputInfopathDataunsupportedAttachmentAction), required: false);
            var __workflow_inputInfopathDatabreakMergeOnError = WorkflowExpression.Compile(inputInfopathDatabreakMergeOnError, nameof(inputInfopathDatabreakMergeOnError), required: false);
            var __workflow_inputInfopathDataincludeAttachmentFilter = WorkflowExpression.Compile(inputInfopathDataincludeAttachmentFilter, nameof(inputInfopathDataincludeAttachmentFilter), required: false);
            var __workflow_inputInfopathDataexcludeAttachmentFilter = WorkflowExpression.Compile(inputInfopathDataexcludeAttachmentFilter, nameof(inputInfopathDataexcludeAttachmentFilter), required: false);
            var __workflow_inputInfopathDatadefaultPaperSize = WorkflowExpression.Compile(inputInfopathDatadefaultPaperSize, nameof(inputInfopathDatadefaultPaperSize), required: false);
            var __workflow_inputInfopathDatadefaultPaperSizeCustom = WorkflowExpression.Compile(inputInfopathDatadefaultPaperSizeCustom, nameof(inputInfopathDatadefaultPaperSizeCustom), required: false);
            var __workflow_inputInfopathDataforcePaperSize = WorkflowExpression.Compile(inputInfopathDataforcePaperSize, nameof(inputInfopathDataforcePaperSize), required: false);
            var __workflow_inputInfopathDataforcePaperSizeCustom = WorkflowExpression.Compile(inputInfopathDataforcePaperSizeCustom, nameof(inputInfopathDataforcePaperSizeCustom), required: false);
            var __workflow_inputInfopathDatadefaultPageOrientation = WorkflowExpression.Compile(inputInfopathDatadefaultPageOrientation, nameof(inputInfopathDatadefaultPageOrientation), required: false);
            var __workflow_inputInfopathDataforcePageOrientation = WorkflowExpression.Compile(inputInfopathDataforcePageOrientation, nameof(inputInfopathDataforcePageOrientation), required: false);
            var __workflow_inputInfopathDatastartPage = WorkflowExpression.Compile(inputInfopathDatastartPage, nameof(inputInfopathDatastartPage), required: false);
            var __workflow_inputInfopathDataendPage = WorkflowExpression.Compile(inputInfopathDataendPage, nameof(inputInfopathDataendPage), required: false);
            var __workflow_inputInfopathDataconversionQuality = WorkflowExpression.Compile(inputInfopathDataconversionQuality, nameof(inputInfopathDataconversionQuality), required: false);
            var __workflow_inputInfopathDataoverrideSettings = WorkflowExpression.Compile(inputInfopathDataoverrideSettings, nameof(inputInfopathDataoverrideSettings), required: false);
            var __workflow_inputInfopathDatafailOnError = WorkflowExpression.Compile(inputInfopathDatafailOnError, nameof(inputInfopathDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_infopath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputInfopathData = new JObject();
                var inputInfopathDatapropCount = 0;
                inputInfopathData["use_async_pattern"] = false;
                inputInfopathDatapropCount++;
                inputInfopathDatapropCount++;
                inputInfopathData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputInfopathData["sharepoint_file"] = sharepointFileObject;
                    inputInfopathDatapropCount++;
                }

                inputInfopathDatapropCount++;
                inputInfopathData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatasourceFileContent);
                inputInfopathDatapropCount++;
                inputInfopathData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataoutputFormat);
                inputInfopathData["copy_metadata"] = false;
                inputInfopathDatapropCount++;
                if (__workflow_inputInfopathDatatemplateFileContent != null)
                {
                    inputInfopathData["template_file_content"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatatemplateFileContent);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataviewNames != null)
                {
                    inputInfopathData["views_to_convert"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataviewNames);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataincludeAttachment != null)
                {
                    if (__workflow_inputInfopathDataincludeAttachment != null)
                    {
                        inputInfopathData["convert_attachments"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataincludeAttachment);
                        inputInfopathDatapropCount++;
                    }

                    inputInfopathDatapropCount++;
                }
                else
                {
                    inputInfopathData["convert_attachments"] = true;
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataattachmentAction != null)
                {
                    inputInfopathData["attachment_merge_mode"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataattachmentAction);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataunsupportedAttachmentAction != null)
                {
                    inputInfopathData["unsupported_attachment_behaviour"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataunsupportedAttachmentAction);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDatabreakMergeOnError != null)
                {
                    inputInfopathData["break_merge_on_error"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatabreakMergeOnError);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataincludeAttachmentFilter != null)
                {
                    inputInfopathData["include_attachment_types"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataincludeAttachmentFilter);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataexcludeAttachmentFilter != null)
                {
                    inputInfopathData["exclude_attachment_types"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataexcludeAttachmentFilter);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDatadefaultPaperSize != null)
                {
                    inputInfopathData["default_paper_size"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatadefaultPaperSize);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDatadefaultPaperSizeCustom != null)
                {
                    inputInfopathData["default_paper_size_custom"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatadefaultPaperSizeCustom);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataforcePaperSize != null)
                {
                    inputInfopathData["force_paper_size"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataforcePaperSize);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataforcePaperSizeCustom != null)
                {
                    inputInfopathData["force_paper_size_custom"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataforcePaperSizeCustom);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDatadefaultPageOrientation != null)
                {
                    if (__workflow_inputInfopathDatadefaultPageOrientation != null)
                    {
                        inputInfopathData["default_page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatadefaultPageOrientation);
                        inputInfopathDatapropCount++;
                    }

                    inputInfopathDatapropCount++;
                }
                else
                {
                    inputInfopathData["default_page_orientation"] = "Default";
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataforcePageOrientation != null)
                {
                    inputInfopathData["force_page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataforcePageOrientation);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDatastartPage != null)
                {
                    inputInfopathData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatastartPage);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataendPage != null)
                {
                    inputInfopathData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataendPage);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataconversionQuality != null)
                {
                    inputInfopathData["quality"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataconversionQuality);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDataoverrideSettings != null)
                {
                    inputInfopathData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDataoverrideSettings);
                    inputInfopathDatapropCount++;
                }

                if (__workflow_inputInfopathDatafailOnError != null)
                {
                    if (__workflow_inputInfopathDatafailOnError != null)
                    {
                        inputInfopathData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputInfopathDatafailOnError);
                        inputInfopathDatapropCount++;
                    }

                    inputInfopathDatapropCount++;
                }
                else
                {
                    inputInfopathData["fail_on_error"] = true;
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatapropCount > 0)
                {
                    callPayload.Body = inputInfopathData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPdfa(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDatapDFProfileInput>> inputPdfDatapDFProfile, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapDFProfile = WorkflowExpression.Compile(inputPdfDatapDFProfile, nameof(inputPdfDatapDFProfile), required: true);
            var __workflow_inputPdfDataoverrideSettings = WorkflowExpression.Compile(inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_pdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                inputPdfData["copy_metadata"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["pdf_profile"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapDFProfile);
                if (__workflow_inputPdfDataoverrideSettings != null)
                {
                    inputPdfData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataoverrideSettings);
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPowerpoint(Expression<Func<string>> inputPowerpointDatasourceFileName, Expression<Func<string>> inputPowerpointDatasourceFileContent, Expression<Func<inputPowerpointDataoutputFormatInput>> inputPowerpointDataoutputFormat, Expression<Func<inputPowerpointDatarangeInput>> inputPowerpointDatarange = null, Expression<Func<inputPowerpointDataprintLayoutHandoutsInput>> inputPowerpointDataprintLayoutHandouts = null, Expression<Func<bool>> inputPowerpointDataframeSlides = null, Expression<Func<int>> inputPowerpointDatastartPage = null, Expression<Func<int>> inputPowerpointDataendPage = null, Expression<Func<inputPowerpointDataqualityInput>> inputPowerpointDataquality = null, Expression<Func<string>> inputPowerpointDataoverrideSettings = null, Expression<Func<bool>> inputPowerpointDatafailOnError = null)
        {
            var __workflow_inputPowerpointDatasourceFileName = WorkflowExpression.Compile(inputPowerpointDatasourceFileName, nameof(inputPowerpointDatasourceFileName), required: true);
            var __workflow_inputPowerpointDatasourceFileContent = WorkflowExpression.Compile(inputPowerpointDatasourceFileContent, nameof(inputPowerpointDatasourceFileContent), required: true);
            var __workflow_inputPowerpointDataoutputFormat = WorkflowExpression.Compile(inputPowerpointDataoutputFormat, nameof(inputPowerpointDataoutputFormat), required: true);
            var __workflow_inputPowerpointDatarange = WorkflowExpression.Compile(inputPowerpointDatarange, nameof(inputPowerpointDatarange), required: false);
            var __workflow_inputPowerpointDataprintLayoutHandouts = WorkflowExpression.Compile(inputPowerpointDataprintLayoutHandouts, nameof(inputPowerpointDataprintLayoutHandouts), required: false);
            var __workflow_inputPowerpointDataframeSlides = WorkflowExpression.Compile(inputPowerpointDataframeSlides, nameof(inputPowerpointDataframeSlides), required: false);
            var __workflow_inputPowerpointDatastartPage = WorkflowExpression.Compile(inputPowerpointDatastartPage, nameof(inputPowerpointDatastartPage), required: false);
            var __workflow_inputPowerpointDataendPage = WorkflowExpression.Compile(inputPowerpointDataendPage, nameof(inputPowerpointDataendPage), required: false);
            var __workflow_inputPowerpointDataquality = WorkflowExpression.Compile(inputPowerpointDataquality, nameof(inputPowerpointDataquality), required: false);
            var __workflow_inputPowerpointDataoverrideSettings = WorkflowExpression.Compile(inputPowerpointDataoverrideSettings, nameof(inputPowerpointDataoverrideSettings), required: false);
            var __workflow_inputPowerpointDatafailOnError = WorkflowExpression.Compile(inputPowerpointDatafailOnError, nameof(inputPowerpointDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPowerpointData = new JObject();
                var inputPowerpointDatapropCount = 0;
                inputPowerpointData["use_async_pattern"] = false;
                inputPowerpointDatapropCount++;
                inputPowerpointDatapropCount++;
                inputPowerpointData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPowerpointData["sharepoint_file"] = sharepointFileObject;
                    inputPowerpointDatapropCount++;
                }

                inputPowerpointDatapropCount++;
                inputPowerpointData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDatasourceFileContent);
                inputPowerpointDatapropCount++;
                inputPowerpointData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDataoutputFormat);
                inputPowerpointData["copy_metadata"] = false;
                inputPowerpointDatapropCount++;
                if (__workflow_inputPowerpointDatarange != null)
                {
                    inputPowerpointData["range"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDatarange);
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDataprintLayoutHandouts != null)
                {
                    if (__workflow_inputPowerpointDataprintLayoutHandouts != null)
                    {
                        inputPowerpointData["print_output_type"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDataprintLayoutHandouts);
                        inputPowerpointDatapropCount++;
                    }

                    inputPowerpointDatapropCount++;
                }
                else
                {
                    inputPowerpointData["print_output_type"] = "Slides";
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDataframeSlides != null)
                {
                    if (__workflow_inputPowerpointDataframeSlides != null)
                    {
                        inputPowerpointData["frame_slides"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDataframeSlides);
                        inputPowerpointDatapropCount++;
                    }

                    inputPowerpointDatapropCount++;
                }
                else
                {
                    inputPowerpointData["frame_slides"] = true;
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDatastartPage != null)
                {
                    inputPowerpointData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDatastartPage);
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDataendPage != null)
                {
                    inputPowerpointData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDataendPage);
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDataquality != null)
                {
                    inputPowerpointData["quality"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDataquality);
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDataoverrideSettings != null)
                {
                    inputPowerpointData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDataoverrideSettings);
                    inputPowerpointDatapropCount++;
                }

                if (__workflow_inputPowerpointDatafailOnError != null)
                {
                    if (__workflow_inputPowerpointDatafailOnError != null)
                    {
                        inputPowerpointData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPowerpointDatafailOnError);
                        inputPowerpointDatapropCount++;
                    }

                    inputPowerpointDatapropCount++;
                }
                else
                {
                    inputPowerpointData["fail_on_error"] = true;
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDatapropCount > 0)
                {
                    callPayload.Body = inputPowerpointData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<string>> inputVisioDatasourceFileName, Expression<Func<string>> inputVisioDatasourceFileContent, Expression<Func<inputVisioDataoutputFormatInput>> inputVisioDataoutputFormat, Expression<Func<inputVisioDatarangeInput>> inputVisioDatarange = null, Expression<Func<int>> inputVisioDatastartPage = null, Expression<Func<int>> inputVisioDataendPage = null, Expression<Func<inputVisioDataqualityInput>> inputVisioDataquality = null, Expression<Func<string>> inputVisioDataoverrideSettings = null, Expression<Func<bool>> inputVisioDatafailOnError = null)
        {
            var __workflow_inputVisioDatasourceFileName = WorkflowExpression.Compile(inputVisioDatasourceFileName, nameof(inputVisioDatasourceFileName), required: true);
            var __workflow_inputVisioDatasourceFileContent = WorkflowExpression.Compile(inputVisioDatasourceFileContent, nameof(inputVisioDatasourceFileContent), required: true);
            var __workflow_inputVisioDataoutputFormat = WorkflowExpression.Compile(inputVisioDataoutputFormat, nameof(inputVisioDataoutputFormat), required: true);
            var __workflow_inputVisioDatarange = WorkflowExpression.Compile(inputVisioDatarange, nameof(inputVisioDatarange), required: false);
            var __workflow_inputVisioDatastartPage = WorkflowExpression.Compile(inputVisioDatastartPage, nameof(inputVisioDatastartPage), required: false);
            var __workflow_inputVisioDataendPage = WorkflowExpression.Compile(inputVisioDataendPage, nameof(inputVisioDataendPage), required: false);
            var __workflow_inputVisioDataquality = WorkflowExpression.Compile(inputVisioDataquality, nameof(inputVisioDataquality), required: false);
            var __workflow_inputVisioDataoverrideSettings = WorkflowExpression.Compile(inputVisioDataoverrideSettings, nameof(inputVisioDataoverrideSettings), required: false);
            var __workflow_inputVisioDatafailOnError = WorkflowExpression.Compile(inputVisioDatafailOnError, nameof(inputVisioDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_visio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputVisioData = new JObject();
                var inputVisioDatapropCount = 0;
                inputVisioData["use_async_pattern"] = false;
                inputVisioDatapropCount++;
                inputVisioDatapropCount++;
                inputVisioData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputVisioDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputVisioData["sharepoint_file"] = sharepointFileObject;
                    inputVisioDatapropCount++;
                }

                inputVisioDatapropCount++;
                inputVisioData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputVisioDatasourceFileContent);
                inputVisioDatapropCount++;
                inputVisioData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputVisioDataoutputFormat);
                inputVisioData["copy_metadata"] = false;
                inputVisioDatapropCount++;
                if (__workflow_inputVisioDatarange != null)
                {
                    inputVisioData["range"] = ExpressionConverter.ConvertO(__workflow_inputVisioDatarange);
                    inputVisioDatapropCount++;
                }

                if (__workflow_inputVisioDatastartPage != null)
                {
                    inputVisioData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputVisioDatastartPage);
                    inputVisioDatapropCount++;
                }

                if (__workflow_inputVisioDataendPage != null)
                {
                    inputVisioData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputVisioDataendPage);
                    inputVisioDatapropCount++;
                }

                if (__workflow_inputVisioDataquality != null)
                {
                    inputVisioData["quality"] = ExpressionConverter.ConvertO(__workflow_inputVisioDataquality);
                    inputVisioDatapropCount++;
                }

                if (__workflow_inputVisioDataoverrideSettings != null)
                {
                    inputVisioData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputVisioDataoverrideSettings);
                    inputVisioDatapropCount++;
                }

                if (__workflow_inputVisioDatafailOnError != null)
                {
                    if (__workflow_inputVisioDatafailOnError != null)
                    {
                        inputVisioData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputVisioDatafailOnError);
                        inputVisioDatapropCount++;
                    }

                    inputVisioDatapropCount++;
                }
                else
                {
                    inputVisioData["fail_on_error"] = true;
                    inputVisioDatapropCount++;
                }

                if (inputVisioDatapropCount > 0)
                {
                    callPayload.Body = inputVisioData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertWord(Expression<Func<string>> inputWordDatasourceFileName, Expression<Func<string>> inputWordDatasourceFileContent, Expression<Func<inputWordDataoutputFormatInput>> inputWordDataoutputFormat, Expression<Func<inputWordDatadisplayForReviewInput>> inputWordDatadisplayForReview = null, Expression<Func<inputWordDatareviewMarkupModeInput>> inputWordDatareviewMarkupMode = null, Expression<Func<inputWordDatagenerateBookmarksInput>> inputWordDatagenerateBookmarks = null, Expression<Func<int>> inputWordDatastartPage = null, Expression<Func<int>> inputWordDataendPage = null, Expression<Func<inputWordDataqualityInput>> inputWordDataquality = null, Expression<Func<string>> inputWordDataoverrideSettings = null, Expression<Func<bool>> inputWordDatafailOnError = null)
        {
            var __workflow_inputWordDatasourceFileName = WorkflowExpression.Compile(inputWordDatasourceFileName, nameof(inputWordDatasourceFileName), required: true);
            var __workflow_inputWordDatasourceFileContent = WorkflowExpression.Compile(inputWordDatasourceFileContent, nameof(inputWordDatasourceFileContent), required: true);
            var __workflow_inputWordDataoutputFormat = WorkflowExpression.Compile(inputWordDataoutputFormat, nameof(inputWordDataoutputFormat), required: true);
            var __workflow_inputWordDatadisplayForReview = WorkflowExpression.Compile(inputWordDatadisplayForReview, nameof(inputWordDatadisplayForReview), required: false);
            var __workflow_inputWordDatareviewMarkupMode = WorkflowExpression.Compile(inputWordDatareviewMarkupMode, nameof(inputWordDatareviewMarkupMode), required: false);
            var __workflow_inputWordDatagenerateBookmarks = WorkflowExpression.Compile(inputWordDatagenerateBookmarks, nameof(inputWordDatagenerateBookmarks), required: false);
            var __workflow_inputWordDatastartPage = WorkflowExpression.Compile(inputWordDatastartPage, nameof(inputWordDatastartPage), required: false);
            var __workflow_inputWordDataendPage = WorkflowExpression.Compile(inputWordDataendPage, nameof(inputWordDataendPage), required: false);
            var __workflow_inputWordDataquality = WorkflowExpression.Compile(inputWordDataquality, nameof(inputWordDataquality), required: false);
            var __workflow_inputWordDataoverrideSettings = WorkflowExpression.Compile(inputWordDataoverrideSettings, nameof(inputWordDataoverrideSettings), required: false);
            var __workflow_inputWordDatafailOnError = WorkflowExpression.Compile(inputWordDatafailOnError, nameof(inputWordDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputWordData = new JObject();
                var inputWordDatapropCount = 0;
                inputWordData["use_async_pattern"] = false;
                inputWordDatapropCount++;
                inputWordDatapropCount++;
                inputWordData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputWordDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputWordData["sharepoint_file"] = sharepointFileObject;
                    inputWordDatapropCount++;
                }

                inputWordDatapropCount++;
                inputWordData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputWordDatasourceFileContent);
                inputWordDatapropCount++;
                inputWordData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputWordDataoutputFormat);
                inputWordData["copy_metadata"] = false;
                inputWordDatapropCount++;
                if (__workflow_inputWordDatadisplayForReview != null)
                {
                    if (__workflow_inputWordDatadisplayForReview != null)
                    {
                        inputWordData["revisions_and_comments_display_mode"] = ExpressionConverter.ConvertO(__workflow_inputWordDatadisplayForReview);
                        inputWordDatapropCount++;
                    }

                    inputWordDatapropCount++;
                }
                else
                {
                    inputWordData["revisions_and_comments_display_mode"] = "Final";
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDatareviewMarkupMode != null)
                {
                    if (__workflow_inputWordDatareviewMarkupMode != null)
                    {
                        inputWordData["revisions_and_comments_markup_mode"] = ExpressionConverter.ConvertO(__workflow_inputWordDatareviewMarkupMode);
                        inputWordDatapropCount++;
                    }

                    inputWordDatapropCount++;
                }
                else
                {
                    inputWordData["revisions_and_comments_markup_mode"] = "InLine";
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDatagenerateBookmarks != null)
                {
                    inputWordData["generate_bookmarks"] = ExpressionConverter.ConvertO(__workflow_inputWordDatagenerateBookmarks);
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDatastartPage != null)
                {
                    inputWordData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputWordDatastartPage);
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDataendPage != null)
                {
                    inputWordData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputWordDataendPage);
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDataquality != null)
                {
                    inputWordData["quality"] = ExpressionConverter.ConvertO(__workflow_inputWordDataquality);
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDataoverrideSettings != null)
                {
                    inputWordData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputWordDataoverrideSettings);
                    inputWordDatapropCount++;
                }

                if (__workflow_inputWordDatafailOnError != null)
                {
                    if (__workflow_inputWordDatafailOnError != null)
                    {
                        inputWordData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputWordDatafailOnError);
                        inputWordDatapropCount++;
                    }

                    inputWordDatapropCount++;
                }
                else
                {
                    inputWordData["fail_on_error"] = true;
                    inputWordDatapropCount++;
                }

                if (inputWordDatapropCount > 0)
                {
                    callPayload.Body = inputWordData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponseCommon, ApiConnectionActionConfiguration> CopyMetadata(Expression<Func<string>> inputDatasiteUrl, Expression<Func<string>> inputDatasourceFileUrl, Expression<Func<string>> inputDatadestinationFilePath, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDatafieldsToCopy = null, Expression<Func<string>> inputDatadestinationContentType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasiteUrl = WorkflowExpression.Compile(inputDatasiteUrl, nameof(inputDatasiteUrl), required: true);
            var __workflow_inputDatasourceFileUrl = WorkflowExpression.Compile(inputDatasourceFileUrl, nameof(inputDatasourceFileUrl), required: true);
            var __workflow_inputDatadestinationFilePath = WorkflowExpression.Compile(inputDatadestinationFilePath, nameof(inputDatadestinationFilePath), required: true);
            var __workflow_inputDatauserName = WorkflowExpression.Compile(inputDatauserName, nameof(inputDatauserName), required: false);
            var __workflow_inputDatapassword = WorkflowExpression.Compile(inputDatapassword, nameof(inputDatapassword), required: false);
            var __workflow_inputDatafieldsToCopy = WorkflowExpression.Compile(inputDatafieldsToCopy, nameof(inputDatafieldsToCopy), required: false);
            var __workflow_inputDatadestinationContentType = WorkflowExpression.Compile(inputDatadestinationContentType, nameof(inputDatadestinationContentType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponseCommon, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/copy_metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputDatapropCount++;
                inputData["site_url"] = ExpressionConverter.ConvertO(__workflow_inputDatasiteUrl);
                inputDatapropCount++;
                inputData["source_file_url"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileUrl);
                inputDatapropCount++;
                inputData["destination_file_url"] = ExpressionConverter.ConvertO(__workflow_inputDatadestinationFilePath);
                if (__workflow_inputDatauserName != null)
                {
                    inputData["username"] = ExpressionConverter.ConvertO(__workflow_inputDatauserName);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatapassword != null)
                {
                    inputData["password"] = ExpressionConverter.ConvertO(__workflow_inputDatapassword);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafieldsToCopy != null)
                {
                    inputData["copy_fields"] = ExpressionConverter.ConvertO(__workflow_inputDatafieldsToCopy);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatadestinationContentType != null)
                {
                    inputData["content_type"] = ExpressionConverter.ConvertO(__workflow_inputDatadestinationContentType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponseCommon>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> EllipseWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafillColor = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatafillColor = WorkflowExpression.Compile(inputDatafillColor, nameof(inputDatafillColor), required: false);
            var __workflow_inputDatalineColor = WorkflowExpression.Compile(inputDatalineColor, nameof(inputDatalineColor), required: false);
            var __workflow_inputDatalineWidth = WorkflowExpression.Compile(inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/ellipse_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafillColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatafillColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatalineColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(__workflow_inputDatalineWidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExportFormData(Expression<Func<string>> inputFromPdfDatasourceFileName, Expression<Func<string>> inputFromPdfDatasourceFileContent, Expression<Func<inputFromPdfDataoutputDataFormatInput>> inputFromPdfDataoutputDataFormat, Expression<Func<bool>> inputFromPdfDatafailOnError = null)
        {
            var __workflow_inputFromPdfDatasourceFileName = WorkflowExpression.Compile(inputFromPdfDatasourceFileName, nameof(inputFromPdfDatasourceFileName), required: true);
            var __workflow_inputFromPdfDatasourceFileContent = WorkflowExpression.Compile(inputFromPdfDatasourceFileContent, nameof(inputFromPdfDatasourceFileContent), required: true);
            var __workflow_inputFromPdfDataoutputDataFormat = WorkflowExpression.Compile(inputFromPdfDataoutputDataFormat, nameof(inputFromPdfDataoutputDataFormat), required: true);
            var __workflow_inputFromPdfDatafailOnError = WorkflowExpression.Compile(inputFromPdfDatafailOnError, nameof(inputFromPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/export_form_data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputFromPdfData = new JObject();
                var inputFromPdfDatapropCount = 0;
                inputFromPdfData["use_async_pattern"] = false;
                inputFromPdfDatapropCount++;
                inputFromPdfDatapropCount++;
                inputFromPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputFromPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputFromPdfData["sharepoint_file"] = sharepointFileObject;
                    inputFromPdfDatapropCount++;
                }

                inputFromPdfDatapropCount++;
                inputFromPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputFromPdfDatasourceFileContent);
                inputFromPdfDatapropCount++;
                inputFromPdfData["output_format"] = ExpressionConverter.ConvertO(__workflow_inputFromPdfDataoutputDataFormat);
                inputFromPdfData["copy_metadata"] = false;
                inputFromPdfDatapropCount++;
                if (__workflow_inputFromPdfDatafailOnError != null)
                {
                    if (__workflow_inputFromPdfDatafailOnError != null)
                    {
                        inputFromPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputFromPdfDatafailOnError);
                        inputFromPdfDatapropCount++;
                    }

                    inputFromPdfDatapropCount++;
                }
                else
                {
                    inputFromPdfData["fail_on_error"] = true;
                    inputFromPdfDatapropCount++;
                }

                if (inputFromPdfDatapropCount > 0)
                {
                    callPayload.Body = inputFromPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExtractText(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapageRange = WorkflowExpression.Compile(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/extract_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                if (__workflow_inputPdfDatapageRange != null)
                {
                    if (__workflow_inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ImageWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDataimage, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataimage = WorkflowExpression.Compile(inputDataimage, nameof(inputDataimage), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = WorkflowExpression.Compile(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = WorkflowExpression.Compile(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/image_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["image_file"] = ExpressionConverter.ConvertO(__workflow_inputDataimage);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ImportFormData(Expression<Func<string>> inputXmlDatasourceFileName, Expression<Func<string>> inputXmlDatasourceFileContent, Expression<Func<string>> inputXmlDatapDFFormFileContent = null, Expression<Func<string>> inputXmlDatapDFFormURL = null, Expression<Func<string>> inputXmlDatausername = null, Expression<Func<string>> inputXmlDatadomain = null, Expression<Func<string>> inputXmlDatapassword = null, Expression<Func<inputXmlDataflattenInput>> inputXmlDataflatten = null, Expression<Func<inputXmlDatareadOnlyInput>> inputXmlDatareadOnly = null, Expression<Func<string>> inputXmlDataoverrideSettings = null, Expression<Func<bool>> inputXmlDatafailOnError = null)
        {
            var __workflow_inputXmlDatasourceFileName = WorkflowExpression.Compile(inputXmlDatasourceFileName, nameof(inputXmlDatasourceFileName), required: true);
            var __workflow_inputXmlDatasourceFileContent = WorkflowExpression.Compile(inputXmlDatasourceFileContent, nameof(inputXmlDatasourceFileContent), required: true);
            var __workflow_inputXmlDatapDFFormFileContent = WorkflowExpression.Compile(inputXmlDatapDFFormFileContent, nameof(inputXmlDatapDFFormFileContent), required: false);
            var __workflow_inputXmlDatapDFFormURL = WorkflowExpression.Compile(inputXmlDatapDFFormURL, nameof(inputXmlDatapDFFormURL), required: false);
            var __workflow_inputXmlDatausername = WorkflowExpression.Compile(inputXmlDatausername, nameof(inputXmlDatausername), required: false);
            var __workflow_inputXmlDatadomain = WorkflowExpression.Compile(inputXmlDatadomain, nameof(inputXmlDatadomain), required: false);
            var __workflow_inputXmlDatapassword = WorkflowExpression.Compile(inputXmlDatapassword, nameof(inputXmlDatapassword), required: false);
            var __workflow_inputXmlDataflatten = WorkflowExpression.Compile(inputXmlDataflatten, nameof(inputXmlDataflatten), required: false);
            var __workflow_inputXmlDatareadOnly = WorkflowExpression.Compile(inputXmlDatareadOnly, nameof(inputXmlDatareadOnly), required: false);
            var __workflow_inputXmlDataoverrideSettings = WorkflowExpression.Compile(inputXmlDataoverrideSettings, nameof(inputXmlDataoverrideSettings), required: false);
            var __workflow_inputXmlDatafailOnError = WorkflowExpression.Compile(inputXmlDatafailOnError, nameof(inputXmlDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/import_form_data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputXmlData = new JObject();
                var inputXmlDatapropCount = 0;
                inputXmlData["use_async_pattern"] = false;
                inputXmlDatapropCount++;
                inputXmlDatapropCount++;
                inputXmlData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputXmlData["sharepoint_file"] = sharepointFileObject;
                    inputXmlDatapropCount++;
                }

                inputXmlDatapropCount++;
                inputXmlData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatasourceFileContent);
                inputXmlData["copy_metadata"] = false;
                inputXmlDatapropCount++;
                if (__workflow_inputXmlDatapDFFormFileContent != null)
                {
                    inputXmlData["pdf_template_file_content"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatapDFFormFileContent);
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDatapDFFormURL != null)
                {
                    inputXmlData["pdf_template_url"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatapDFFormURL);
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDatausername != null)
                {
                    inputXmlData["pdf_template_username"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatausername);
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDatadomain != null)
                {
                    inputXmlData["pdf_template_domain"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatadomain);
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDatapassword != null)
                {
                    inputXmlData["pdf_template_password"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatapassword);
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDataflatten != null)
                {
                    if (__workflow_inputXmlDataflatten != null)
                    {
                        inputXmlData["flatten"] = ExpressionConverter.ConvertO(__workflow_inputXmlDataflatten);
                        inputXmlDatapropCount++;
                    }

                    inputXmlDatapropCount++;
                }
                else
                {
                    inputXmlData["flatten"] = "Default";
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDatareadOnly != null)
                {
                    if (__workflow_inputXmlDatareadOnly != null)
                    {
                        inputXmlData["read_only"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatareadOnly);
                        inputXmlDatapropCount++;
                    }

                    inputXmlDatapropCount++;
                }
                else
                {
                    inputXmlData["read_only"] = "Default";
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDataoverrideSettings != null)
                {
                    inputXmlData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputXmlDataoverrideSettings);
                    inputXmlDatapropCount++;
                }

                if (__workflow_inputXmlDatafailOnError != null)
                {
                    if (__workflow_inputXmlDatafailOnError != null)
                    {
                        inputXmlData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputXmlDatafailOnError);
                        inputXmlDatapropCount++;
                    }

                    inputXmlDatapropCount++;
                }
                else
                {
                    inputXmlData["fail_on_error"] = true;
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatapropCount > 0)
                {
                    callPayload.Body = inputXmlData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExtractKeyValuePairs(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDataoCRLanguage = null, Expression<Func<inputPdfDatadPIInput>> inputPdfDatadPI = null, Expression<Func<inputPdfDatakVPOutputFormatInput>> inputPdfDatakVPOutputFormat = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<inputPdfDataautorotateInput>> inputPdfDataautorotate = null, Expression<Func<inputPdfDatatrimSymbolsInput>> inputPdfDatatrimSymbols = null, Expression<Func<inputPdfDataincludeKeyBoundingBoxInput>> inputPdfDataincludeKeyBoundingBox = null, Expression<Func<inputPdfDataincludeValueBoundingBoxInput>> inputPdfDataincludeValueBoundingBox = null, Expression<Func<inputPdfDataincludePageNumberInput>> inputPdfDataincludePageNumber = null, Expression<Func<inputPdfDataincludeConfidenceInput>> inputPdfDataincludeConfidence = null, Expression<Func<int>> inputPdfDataconfidenceThreshold = null, Expression<Func<inputPdfDataincludeTypeInput>> inputPdfDataincludeType = null, Expression<Func<string>> inputPdfDataexpectedKeys = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataoCRLanguage = WorkflowExpression.Compile(inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            var __workflow_inputPdfDatadPI = WorkflowExpression.Compile(inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            var __workflow_inputPdfDatakVPOutputFormat = WorkflowExpression.Compile(inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            var __workflow_inputPdfDatapageRange = WorkflowExpression.Compile(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDataautorotate = WorkflowExpression.Compile(inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            var __workflow_inputPdfDatatrimSymbols = WorkflowExpression.Compile(inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            var __workflow_inputPdfDataincludeKeyBoundingBox = WorkflowExpression.Compile(inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            var __workflow_inputPdfDataincludeValueBoundingBox = WorkflowExpression.Compile(inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            var __workflow_inputPdfDataincludePageNumber = WorkflowExpression.Compile(inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            var __workflow_inputPdfDataincludeConfidence = WorkflowExpression.Compile(inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            var __workflow_inputPdfDataconfidenceThreshold = WorkflowExpression.Compile(inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            var __workflow_inputPdfDataincludeType = WorkflowExpression.Compile(inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            var __workflow_inputPdfDataexpectedKeys = WorkflowExpression.Compile(inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/key_value_pairs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                if (__workflow_inputPdfDataoCRLanguage != null)
                {
                    if (__workflow_inputPdfDataoCRLanguage != null)
                    {
                        inputPdfData["ocr_language"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataoCRLanguage);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["ocr_language"] = "eng";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatadPI != null)
                {
                    if (__workflow_inputPdfDatadPI != null)
                    {
                        inputPdfData["dpi"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatadPI);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["dpi"] = "300";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatakVPOutputFormat != null)
                {
                    if (__workflow_inputPdfDatakVPOutputFormat != null)
                    {
                        inputPdfData["kvp_format"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatakVPOutputFormat);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["kvp_format"] = "json";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapageRange != null)
                {
                    if (__workflow_inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataautorotate != null)
                {
                    if (__workflow_inputPdfDataautorotate != null)
                    {
                        inputPdfData["autorotate"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataautorotate);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["autorotate"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatatrimSymbols != null)
                {
                    if (__workflow_inputPdfDatatrimSymbols != null)
                    {
                        inputPdfData["trim_symbols"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatatrimSymbols);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["trim_symbols"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeKeyBoundingBox != null)
                {
                    if (__workflow_inputPdfDataincludeKeyBoundingBox != null)
                    {
                        inputPdfData["include_key_bounding_box"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeKeyBoundingBox);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_key_bounding_box"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeValueBoundingBox != null)
                {
                    if (__workflow_inputPdfDataincludeValueBoundingBox != null)
                    {
                        inputPdfData["include_value_bounding_box"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeValueBoundingBox);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_value_bounding_box"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludePageNumber != null)
                {
                    if (__workflow_inputPdfDataincludePageNumber != null)
                    {
                        inputPdfData["include_page_number"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludePageNumber);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_page_number"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeConfidence != null)
                {
                    if (__workflow_inputPdfDataincludeConfidence != null)
                    {
                        inputPdfData["include_confidence"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeConfidence);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_confidence"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataconfidenceThreshold != null)
                {
                    if (__workflow_inputPdfDataconfidenceThreshold != null)
                    {
                        inputPdfData["confidence_threshold"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataconfidenceThreshold);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["confidence_threshold"] = 50;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeType != null)
                {
                    if (__workflow_inputPdfDataincludeType != null)
                    {
                        inputPdfData["include_type"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeType);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_type"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataexpectedKeys != null)
                {
                    inputPdfData["expected_keys"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataexpectedKeys);
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> LineWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDataxCoordinateStart, Expression<Func<string>> inputDatayCoordinateStart, Expression<Func<string>> inputDataxCoordinateEnd, Expression<Func<string>> inputDatayCoordinateEnd, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDataxCoordinateStart = WorkflowExpression.Compile(inputDataxCoordinateStart, nameof(inputDataxCoordinateStart), required: true);
            var __workflow_inputDatayCoordinateStart = WorkflowExpression.Compile(inputDatayCoordinateStart, nameof(inputDatayCoordinateStart), required: true);
            var __workflow_inputDataxCoordinateEnd = WorkflowExpression.Compile(inputDataxCoordinateEnd, nameof(inputDataxCoordinateEnd), required: true);
            var __workflow_inputDatayCoordinateEnd = WorkflowExpression.Compile(inputDatayCoordinateEnd, nameof(inputDatayCoordinateEnd), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatalineColor = WorkflowExpression.Compile(inputDatalineColor, nameof(inputDatalineColor), required: false);
            var __workflow_inputDatalineWidth = WorkflowExpression.Compile(inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/line_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinateStart);
                inputDatapropCount++;
                inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinateStart);
                inputDatapropCount++;
                inputData["end_x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinateEnd);
                inputDatapropCount++;
                inputData["end_y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinateEnd);
                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatalineColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(__workflow_inputDatalineWidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> LinearBarcodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatabarcodeContent, Expression<Func<inputDatabarcodeTypeInput>> inputDatabarcodeType, Expression<Func<inputDatadisableCheckDigitInput>> inputDatadisableCheckDigit, Expression<Func<inputDatashowCheckDigitInput>> inputDatashowCheckDigit, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDataomitEncodingOfStartStopSymbolsInput>> inputDataomitEncodingOfStartStopSymbols = null, Expression<Func<string>> inputDatamargin = null, Expression<Func<string>> inputDatafontFamily = null, Expression<Func<string>> inputDatafontSize = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<inputDatalabelPlacementInput>> inputDatalabelPlacement = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatabarcodeBackgroundColor = null, Expression<Func<string>> inputDatabarcodeBarColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatabarcodeContent = WorkflowExpression.Compile(inputDatabarcodeContent, nameof(inputDatabarcodeContent), required: true);
            var __workflow_inputDatabarcodeType = WorkflowExpression.Compile(inputDatabarcodeType, nameof(inputDatabarcodeType), required: true);
            var __workflow_inputDatadisableCheckDigit = WorkflowExpression.Compile(inputDatadisableCheckDigit, nameof(inputDatadisableCheckDigit), required: true);
            var __workflow_inputDatashowCheckDigit = WorkflowExpression.Compile(inputDatashowCheckDigit, nameof(inputDatashowCheckDigit), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataomitEncodingOfStartStopSymbols = WorkflowExpression.Compile(inputDataomitEncodingOfStartStopSymbols, nameof(inputDataomitEncodingOfStartStopSymbols), required: false);
            var __workflow_inputDatamargin = WorkflowExpression.Compile(inputDatamargin, nameof(inputDatamargin), required: false);
            var __workflow_inputDatafontFamily = WorkflowExpression.Compile(inputDatafontFamily, nameof(inputDatafontFamily), required: false);
            var __workflow_inputDatafontSize = WorkflowExpression.Compile(inputDatafontSize, nameof(inputDatafontSize), required: false);
            var __workflow_inputDatafontStyle = WorkflowExpression.Compile(inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            var __workflow_inputDatalabelPlacement = WorkflowExpression.Compile(inputDatalabelPlacement, nameof(inputDatalabelPlacement), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatabarcodeBackgroundColor = WorkflowExpression.Compile(inputDatabarcodeBackgroundColor, nameof(inputDatabarcodeBackgroundColor), required: false);
            var __workflow_inputDatabarcodeBarColor = WorkflowExpression.Compile(inputDatabarcodeBarColor, nameof(inputDatabarcodeBarColor), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/linear_barcode_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = ExpressionConverter.ConvertO(__workflow_inputDatabarcodeContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["barcode_type"] = ExpressionConverter.ConvertO(__workflow_inputDatabarcodeType);
                if (__workflow_inputDataomitEncodingOfStartStopSymbols != null)
                {
                    if (__workflow_inputDataomitEncodingOfStartStopSymbols != null)
                    {
                        inputData["omit_start_stop_symbols"] = ExpressionConverter.ConvertO(__workflow_inputDataomitEncodingOfStartStopSymbols);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["omit_start_stop_symbols"] = "false";
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["disable_checkdigit"] = ExpressionConverter.ConvertO(__workflow_inputDatadisableCheckDigit);
                inputDatapropCount++;
                inputData["show_checkdigit"] = ExpressionConverter.ConvertO(__workflow_inputDatashowCheckDigit);
                if (__workflow_inputDatamargin != null)
                {
                    inputData["margin"] = ExpressionConverter.ConvertO(__workflow_inputDatamargin);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafontFamily != null)
                {
                    inputData["font_family_name"] = ExpressionConverter.ConvertO(__workflow_inputDatafontFamily);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafontSize != null)
                {
                    inputData["font_size"] = ExpressionConverter.ConvertO(__workflow_inputDatafontSize);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafontStyle != null)
                {
                    inputData["font_style"] = ExpressionConverter.ConvertO(__workflow_inputDatafontStyle);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalabelPlacement != null)
                {
                    if (__workflow_inputDatalabelPlacement != null)
                    {
                        inputData["label_placement"] = ExpressionConverter.ConvertO(__workflow_inputDatalabelPlacement);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["label_placement"] = "Bottom Center";
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatabarcodeBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatabarcodeBackgroundColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatabarcodeBarColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatabarcodeBarColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> MergeToPdf(Expression<Func<string>> inputDatasourceFileName1 = null, Expression<Func<string>> inputDatasourceFileContent1 = null, Expression<Func<string>> inputDatasourceFileName2 = null, Expression<Func<string>> inputDatasourceFileContent2 = null, Expression<Func<string>> inputDatasourceFileName3 = null, Expression<Func<string>> inputDatasourceFileContent3 = null, Expression<Func<string>> inputDatasourceFileName4 = null, Expression<Func<string>> inputDatasourceFileContent4 = null, Expression<Func<string>> inputDatasourceFileName5 = null, Expression<Func<string>> inputDatasourceFileContent5 = null, Expression<Func<inputDataeachDocumentInput>> inputDataeachDocument = null, Expression<Func<MergeSourceFile[]>> inputDatasourceFiles = null, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName1 = WorkflowExpression.Compile(inputDatasourceFileName1, nameof(inputDatasourceFileName1), required: false);
            var __workflow_inputDatasourceFileContent1 = WorkflowExpression.Compile(inputDatasourceFileContent1, nameof(inputDatasourceFileContent1), required: false);
            var __workflow_inputDatasourceFileName2 = WorkflowExpression.Compile(inputDatasourceFileName2, nameof(inputDatasourceFileName2), required: false);
            var __workflow_inputDatasourceFileContent2 = WorkflowExpression.Compile(inputDatasourceFileContent2, nameof(inputDatasourceFileContent2), required: false);
            var __workflow_inputDatasourceFileName3 = WorkflowExpression.Compile(inputDatasourceFileName3, nameof(inputDatasourceFileName3), required: false);
            var __workflow_inputDatasourceFileContent3 = WorkflowExpression.Compile(inputDatasourceFileContent3, nameof(inputDatasourceFileContent3), required: false);
            var __workflow_inputDatasourceFileName4 = WorkflowExpression.Compile(inputDatasourceFileName4, nameof(inputDatasourceFileName4), required: false);
            var __workflow_inputDatasourceFileContent4 = WorkflowExpression.Compile(inputDatasourceFileContent4, nameof(inputDatasourceFileContent4), required: false);
            var __workflow_inputDatasourceFileName5 = WorkflowExpression.Compile(inputDatasourceFileName5, nameof(inputDatasourceFileName5), required: false);
            var __workflow_inputDatasourceFileContent5 = WorkflowExpression.Compile(inputDatasourceFileContent5, nameof(inputDatasourceFileContent5), required: false);
            var __workflow_inputDataeachDocument = WorkflowExpression.Compile(inputDataeachDocument, nameof(inputDataeachDocument), required: false);
            var __workflow_inputDatasourceFiles = WorkflowExpression.Compile(inputDatasourceFiles, nameof(inputDatasourceFiles), required: false);
            var __workflow_inputDataoverrideSettings = WorkflowExpression.Compile(inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/merge_to_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                if (__workflow_inputDatasourceFileName1 != null)
                {
                    inputData["source_file_name_1"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName1);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileContent1 != null)
                {
                    inputData["source_file_content_1"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent1);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileName2 != null)
                {
                    inputData["source_file_name_2"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName2);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileContent2 != null)
                {
                    inputData["source_file_content_2"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent2);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileName3 != null)
                {
                    inputData["source_file_name_3"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName3);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileContent3 != null)
                {
                    inputData["source_file_content_3"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent3);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileName4 != null)
                {
                    inputData["source_file_name_4"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName4);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileContent4 != null)
                {
                    inputData["source_file_content_4"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent4);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileName5 != null)
                {
                    inputData["source_file_name_5"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName5);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFileContent5 != null)
                {
                    inputData["source_file_content_5"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent5);
                    inputDatapropCount++;
                }

                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (__workflow_inputDataeachDocument != null)
                {
                    if (__workflow_inputDataeachDocument != null)
                    {
                        inputData["document_start_page"] = ExpressionConverter.ConvertO(__workflow_inputDataeachDocument);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["document_start_page"] = "Starts on the next page";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatasourceFiles != null)
                {
                    inputData["source_files"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFiles);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataoverrideSettings != null)
                {
                    inputData["override_settings"] = ExpressionConverter.ConvertO(__workflow_inputDataoverrideSettings);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> OcrPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<string>> inputDataregions = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = WorkflowExpression.Compile(inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataperformance = WorkflowExpression.Compile(inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = WorkflowExpression.Compile(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = WorkflowExpression.Compile(inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = WorkflowExpression.Compile(inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDataregions = WorkflowExpression.Compile(inputDataregions, nameof(inputDataregions), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputData["copy_metadata"] = false;
                inputDatapropCount++;
                if (__workflow_inputDatalanguage != null)
                {
                    if (__workflow_inputDatalanguage != null)
                    {
                        inputData["language"] = ExpressionConverter.ConvertO(__workflow_inputDatalanguage);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["language"] = "English";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataperformance != null)
                {
                    if (__workflow_inputDataperformance != null)
                    {
                        inputData["performance"] = ExpressionConverter.ConvertO(__workflow_inputDataperformance);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["performance"] = "Slow but accurate";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatablacklistWhitelist != null)
                {
                    if (__workflow_inputDatablacklistWhitelist != null)
                    {
                        inputData["characters_option"] = ExpressionConverter.ConvertO(__workflow_inputDatablacklistWhitelist);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["characters_option"] = "None";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatacharacters != null)
                {
                    inputData["characters"] = ExpressionConverter.ConvertO(__workflow_inputDatacharacters);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatausePagination != null)
                {
                    if (__workflow_inputDatausePagination != null)
                    {
                        inputData["paginate"] = ExpressionConverter.ConvertO(__workflow_inputDatausePagination);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["paginate"] = false;
                    inputDatapropCount++;
                }

                if (__workflow_inputDataregions != null)
                {
                    inputData["regions"] = ExpressionConverter.ConvertO(__workflow_inputDataregions);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OcrOperationResponse, ApiConnectionActionConfiguration> OcrText(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<string>> inputDatawidth = null, Expression<Func<string>> inputDataheight = null, Expression<Func<string>> inputDatapageNumber = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = WorkflowExpression.Compile(inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: false);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: false);
            var __workflow_inputDatapageNumber = WorkflowExpression.Compile(inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            var __workflow_inputDataperformance = WorkflowExpression.Compile(inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = WorkflowExpression.Compile(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = WorkflowExpression.Compile(inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = WorkflowExpression.Compile(inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OcrOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalanguage != null)
                {
                    if (__workflow_inputDatalanguage != null)
                    {
                        inputData["language"] = ExpressionConverter.ConvertO(__workflow_inputDatalanguage);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["language"] = "English";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawidth != null)
                {
                    inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataheight != null)
                {
                    inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatapageNumber != null)
                {
                    if (__workflow_inputDatapageNumber != null)
                    {
                        inputData["page_number"] = ExpressionConverter.ConvertO(__workflow_inputDatapageNumber);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_number"] = "";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataperformance != null)
                {
                    if (__workflow_inputDataperformance != null)
                    {
                        inputData["performance"] = ExpressionConverter.ConvertO(__workflow_inputDataperformance);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["performance"] = "Slow but accurate";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatablacklistWhitelist != null)
                {
                    if (__workflow_inputDatablacklistWhitelist != null)
                    {
                        inputData["characters_option"] = ExpressionConverter.ConvertO(__workflow_inputDatablacklistWhitelist);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["characters_option"] = "None";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatacharacters != null)
                {
                    inputData["characters"] = ExpressionConverter.ConvertO(__workflow_inputDatacharacters);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatausePagination != null)
                {
                    if (__workflow_inputDatausePagination != null)
                    {
                        inputData["paginate"] = ExpressionConverter.ConvertO(__workflow_inputDatausePagination);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["paginate"] = false;
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OcrOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> PdfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatapDFWatermark, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatapDFWatermark = WorkflowExpression.Compile(inputDatapDFWatermark, nameof(inputDatapDFWatermark), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/pdf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["pdf_file"] = ExpressionConverter.ConvertO(__workflow_inputDatapDFWatermark);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> QrCodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatacontent, Expression<Func<inputDataversionInput>> inputDataversion, Expression<Func<inputDatainputModeInput>> inputDatainputMode, Expression<Func<inputDataerrorCorrectionLevelInput>> inputDataerrorCorrectionLevel, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkForegroundColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatacontent = WorkflowExpression.Compile(inputDatacontent, nameof(inputDatacontent), required: true);
            var __workflow_inputDataversion = WorkflowExpression.Compile(inputDataversion, nameof(inputDataversion), required: true);
            var __workflow_inputDatainputMode = WorkflowExpression.Compile(inputDatainputMode, nameof(inputDatainputMode), required: true);
            var __workflow_inputDataerrorCorrectionLevel = WorkflowExpression.Compile(inputDataerrorCorrectionLevel, nameof(inputDataerrorCorrectionLevel), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkForegroundColor = WorkflowExpression.Compile(inputDatawatermarkForegroundColor, nameof(inputDatawatermarkForegroundColor), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/qr_code_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = ExpressionConverter.ConvertO(__workflow_inputDatacontent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["version"] = ExpressionConverter.ConvertO(__workflow_inputDataversion);
                inputDatapropCount++;
                inputData["input_mode"] = ExpressionConverter.ConvertO(__workflow_inputDatainputMode);
                inputDatapropCount++;
                inputData["error_correction_level"] = ExpressionConverter.ConvertO(__workflow_inputDataerrorCorrectionLevel);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkForegroundColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkForegroundColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RectangleWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = WorkflowExpression.Compile(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = WorkflowExpression.Compile(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/rectangle_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> Redact(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDataredactionTypeInput>> inputPdfDataredactionType, Expression<Func<string>> inputPdfDataredactPattern, Expression<Func<bool>> inputPdfDataincludeAnnotations = null, Expression<Func<bool>> inputPdfDatacaseSensitive = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<string>> inputPdfDataopenPassword = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataredactionType = WorkflowExpression.Compile(inputPdfDataredactionType, nameof(inputPdfDataredactionType), required: true);
            var __workflow_inputPdfDataredactPattern = WorkflowExpression.Compile(inputPdfDataredactPattern, nameof(inputPdfDataredactPattern), required: true);
            var __workflow_inputPdfDataincludeAnnotations = WorkflowExpression.Compile(inputPdfDataincludeAnnotations, nameof(inputPdfDataincludeAnnotations), required: false);
            var __workflow_inputPdfDatacaseSensitive = WorkflowExpression.Compile(inputPdfDatacaseSensitive, nameof(inputPdfDatacaseSensitive), required: false);
            var __workflow_inputPdfDatapageRange = WorkflowExpression.Compile(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDataopenPassword = WorkflowExpression.Compile(inputPdfDataopenPassword, nameof(inputPdfDataopenPassword), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/redact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["redaction_type"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactionType);
                inputPdfDatapropCount++;
                inputPdfData["redact_text"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactPattern);
                if (__workflow_inputPdfDataincludeAnnotations != null)
                {
                    if (__workflow_inputPdfDataincludeAnnotations != null)
                    {
                        inputPdfData["include_annotations"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeAnnotations);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_annotations"] = true;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatacaseSensitive != null)
                {
                    if (__workflow_inputPdfDatacaseSensitive != null)
                    {
                        inputPdfData["case_sensitive"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatacaseSensitive);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["case_sensitive"] = false;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapageRange != null)
                {
                    if (__workflow_inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataopenPassword != null)
                {
                    inputPdfData["open_password"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataopenPassword);
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RedactSmart(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<bool>> inputPdfDataredactCreditCardNumber, Expression<Func<bool>> inputPdfDataredactDate, Expression<Func<bool>> inputPdfDataredactEmailAddress, Expression<Func<bool>> inputPdfDataredactInternationalPhoneNumber, Expression<Func<bool>> inputPdfDataredactIPv4Address, Expression<Func<bool>> inputPdfDataredactIPv6Address, Expression<Func<bool>> inputPdfDataredactMACAddress, Expression<Func<bool>> inputPdfDataredactNorthAmericanPhoneNumber, Expression<Func<bool>> inputPdfDataredactSocialSecurityNumber, Expression<Func<bool>> inputPdfDataredactTime, Expression<Func<bool>> inputPdfDataredactURL, Expression<Func<bool>> inputPdfDataredactUSZipCode, Expression<Func<bool>> inputPdfDataredactVIN, Expression<Func<bool>> inputPdfDataincludeAnnotations = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<string>> inputPdfDataopenPassword = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataredactCreditCardNumber = WorkflowExpression.Compile(inputPdfDataredactCreditCardNumber, nameof(inputPdfDataredactCreditCardNumber), required: true);
            var __workflow_inputPdfDataredactDate = WorkflowExpression.Compile(inputPdfDataredactDate, nameof(inputPdfDataredactDate), required: true);
            var __workflow_inputPdfDataredactEmailAddress = WorkflowExpression.Compile(inputPdfDataredactEmailAddress, nameof(inputPdfDataredactEmailAddress), required: true);
            var __workflow_inputPdfDataredactInternationalPhoneNumber = WorkflowExpression.Compile(inputPdfDataredactInternationalPhoneNumber, nameof(inputPdfDataredactInternationalPhoneNumber), required: true);
            var __workflow_inputPdfDataredactIPv4Address = WorkflowExpression.Compile(inputPdfDataredactIPv4Address, nameof(inputPdfDataredactIPv4Address), required: true);
            var __workflow_inputPdfDataredactIPv6Address = WorkflowExpression.Compile(inputPdfDataredactIPv6Address, nameof(inputPdfDataredactIPv6Address), required: true);
            var __workflow_inputPdfDataredactMACAddress = WorkflowExpression.Compile(inputPdfDataredactMACAddress, nameof(inputPdfDataredactMACAddress), required: true);
            var __workflow_inputPdfDataredactNorthAmericanPhoneNumber = WorkflowExpression.Compile(inputPdfDataredactNorthAmericanPhoneNumber, nameof(inputPdfDataredactNorthAmericanPhoneNumber), required: true);
            var __workflow_inputPdfDataredactSocialSecurityNumber = WorkflowExpression.Compile(inputPdfDataredactSocialSecurityNumber, nameof(inputPdfDataredactSocialSecurityNumber), required: true);
            var __workflow_inputPdfDataredactTime = WorkflowExpression.Compile(inputPdfDataredactTime, nameof(inputPdfDataredactTime), required: true);
            var __workflow_inputPdfDataredactURL = WorkflowExpression.Compile(inputPdfDataredactURL, nameof(inputPdfDataredactURL), required: true);
            var __workflow_inputPdfDataredactUSZipCode = WorkflowExpression.Compile(inputPdfDataredactUSZipCode, nameof(inputPdfDataredactUSZipCode), required: true);
            var __workflow_inputPdfDataredactVIN = WorkflowExpression.Compile(inputPdfDataredactVIN, nameof(inputPdfDataredactVIN), required: true);
            var __workflow_inputPdfDataincludeAnnotations = WorkflowExpression.Compile(inputPdfDataincludeAnnotations, nameof(inputPdfDataincludeAnnotations), required: false);
            var __workflow_inputPdfDatapageRange = WorkflowExpression.Compile(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDataopenPassword = WorkflowExpression.Compile(inputPdfDataopenPassword, nameof(inputPdfDataopenPassword), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/redact_smart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                inputPdfDatapropCount++;
                inputPdfData["redact_credit_card_number"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactCreditCardNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_date"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactDate);
                inputPdfDatapropCount++;
                inputPdfData["redact_email_address"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactEmailAddress);
                inputPdfDatapropCount++;
                inputPdfData["redact_international_phone_number"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactInternationalPhoneNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_ipv4"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactIPv4Address);
                inputPdfDatapropCount++;
                inputPdfData["redact_ipv6"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactIPv6Address);
                inputPdfDatapropCount++;
                inputPdfData["redact_mac_address"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactMACAddress);
                inputPdfDatapropCount++;
                inputPdfData["redact_north_american_phone_number"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactNorthAmericanPhoneNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_social_security_number"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactSocialSecurityNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_time"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactTime);
                inputPdfDatapropCount++;
                inputPdfData["redact_url"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactURL);
                inputPdfDatapropCount++;
                inputPdfData["redact_us_zip_code"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactUSZipCode);
                inputPdfDatapropCount++;
                inputPdfData["redact_vin"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataredactVIN);
                if (__workflow_inputPdfDataincludeAnnotations != null)
                {
                    if (__workflow_inputPdfDataincludeAnnotations != null)
                    {
                        inputPdfData["include_annotations"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeAnnotations);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_annotations"] = true;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapageRange != null)
                {
                    if (__workflow_inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataopenPassword != null)
                {
                    inputPdfData["open_password"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataopenPassword);
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RtfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkContent = WorkflowExpression.Compile(inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = WorkflowExpression.Compile(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = WorkflowExpression.Compile(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/rtf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["rtf_data"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> SecurePdf(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataopenPassword = null, Expression<Func<string>> inputDataownerPassword = null, Expression<Func<string>> inputDatapDFRestrictions = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataopenPassword = WorkflowExpression.Compile(inputDataopenPassword, nameof(inputDataopenPassword), required: false);
            var __workflow_inputDataownerPassword = WorkflowExpression.Compile(inputDataownerPassword, nameof(inputDataownerPassword), required: false);
            var __workflow_inputDatapDFRestrictions = WorkflowExpression.Compile(inputDatapDFRestrictions, nameof(inputDatapDFRestrictions), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/secure_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopenPassword != null)
                {
                    inputData["open_password"] = ExpressionConverter.ConvertO(__workflow_inputDataopenPassword);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataownerPassword != null)
                {
                    inputData["owner_password"] = ExpressionConverter.ConvertO(__workflow_inputDataownerPassword);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatapDFRestrictions != null)
                {
                    inputData["security_options"] = ExpressionConverter.ConvertO(__workflow_inputDatapDFRestrictions);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<SplitOperationResponse, ApiConnectionActionConfiguration> SplitPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatasplitByInput>> inputDatasplitBy, Expression<Func<int>> inputDatasplitParameter, Expression<Func<string>> inputDatafileNameTemplate = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatasplitBy = WorkflowExpression.Compile(inputDatasplitBy, nameof(inputDatasplitBy), required: true);
            var __workflow_inputDatasplitParameter = WorkflowExpression.Compile(inputDatasplitParameter, nameof(inputDatasplitParameter), required: true);
            var __workflow_inputDatafileNameTemplate = WorkflowExpression.Compile(inputDatafileNameTemplate, nameof(inputDatafileNameTemplate), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<SplitOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/split_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafileNameTemplate != null)
                {
                    inputData["file_name_template"] = ExpressionConverter.ConvertO(__workflow_inputDatafileNameTemplate);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["file_split_by"] = ExpressionConverter.ConvertO(__workflow_inputDatasplitBy);
                inputDatapropCount++;
                inputData["split_parameter"] = ExpressionConverter.ConvertO(__workflow_inputDatasplitParameter);
                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<SplitOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> TextWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<string>> inputDatafontFamilyName, Expression<Func<string>> inputDatafontSize, Expression<Func<string>> inputDatafontColor, Expression<Func<inputDatatextAlignmentInput>> inputDatatextAlignment, Expression<Func<inputDatawordWrapInput>> inputDatawordWrap, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<string>> inputDatafontOutlineColor = null, Expression<Func<string>> inputDatafontOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkContent = WorkflowExpression.Compile(inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            var __workflow_inputDatafontFamilyName = WorkflowExpression.Compile(inputDatafontFamilyName, nameof(inputDatafontFamilyName), required: true);
            var __workflow_inputDatafontSize = WorkflowExpression.Compile(inputDatafontSize, nameof(inputDatafontSize), required: true);
            var __workflow_inputDatafontColor = WorkflowExpression.Compile(inputDatafontColor, nameof(inputDatafontColor), required: true);
            var __workflow_inputDatatextAlignment = WorkflowExpression.Compile(inputDatatextAlignment, nameof(inputDatatextAlignment), required: true);
            var __workflow_inputDatawordWrap = WorkflowExpression.Compile(inputDatawordWrap, nameof(inputDatawordWrap), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatafontStyle = WorkflowExpression.Compile(inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            var __workflow_inputDatafontOutlineColor = WorkflowExpression.Compile(inputDatafontOutlineColor, nameof(inputDatafontOutlineColor), required: false);
            var __workflow_inputDatafontOutlineWidth = WorkflowExpression.Compile(inputDatafontOutlineWidth, nameof(inputDatafontOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/text_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (__workflow_inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["font_family_name"] = ExpressionConverter.ConvertO(__workflow_inputDatafontFamilyName);
                inputDatapropCount++;
                inputData["font_size"] = ExpressionConverter.ConvertO(__workflow_inputDatafontSize);
                inputDatapropCount++;
                inputData["fill_color"] = ExpressionConverter.ConvertO(__workflow_inputDatafontColor);
                inputDatapropCount++;
                inputData["alignment"] = ExpressionConverter.ConvertO(__workflow_inputDatatextAlignment);
                inputDatapropCount++;
                inputData["word_wrap"] = ExpressionConverter.ConvertO(__workflow_inputDatawordWrap);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(__workflow_inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalayer != null)
                {
                    if (__workflow_inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(__workflow_inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(__workflow_inputDatarotation);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataopacity != null)
                {
                    if (__workflow_inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(__workflow_inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafontStyle != null)
                {
                    inputData["font_style"] = ExpressionConverter.ConvertO(__workflow_inputDatafontStyle);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafontOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(__workflow_inputDatafontOutlineColor);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafontOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(__workflow_inputDatafontOutlineWidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageOrientation != null)
                {
                    if (__workflow_inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataprintOnly != null)
                {
                    if (__workflow_inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(__workflow_inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(__workflow_inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }
    }

    public class MuhimbiTriggers([ConnectionName] string connectionId)
    {
    }

    public class OperationResponse
    {
        [JsonProperty("processed_file_content")]
        public string ProcessedFileContent { get; set; }

        [JsonProperty("base_file_name")]
        public string BaseFileName { get; set; }

        [JsonProperty("result_code")]
        public OperationResponseResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationResponseResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveAnnotationsInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveBlankPagesInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveBookmarksInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveEmbeddedFilesInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveFormFieldsInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveHyperlinksInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveJavaScriptInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremoveMetadataInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataremovePageThumbnailsInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatapackFontsInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatapackDocumentInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatarecompressImagesInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataenableMRCInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatapreserveSmoothingInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataimageQualityInput
    {
        Default,
        [EnumMember(Value = "Very Very High")]
        VeryVeryHigh,
        [EnumMember(Value = "Very High")]
        VeryHigh,
        High,
        Medium,
        Low,
        [EnumMember(Value = "Very Low")]
        VeryLow
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatadownscaleImagesInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataenableColorDetectionInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataenableCharRepairInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataenableJPEG2000Input
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataenableJBIG2Input
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataoutputFormatInput
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS,
        PPT,
        PPTX,
        ODP,
        PPS,
        PPSX,
        TIFF,
        PNG,
        GIF,
        JPG,
        BMP,
        PS,
        PCL,
        EPS,
        FDF,
        XFDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputCadDatapaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputCadDataforegroundColorInput
    {
        Default,
        CorrectForBackground,
        Greyscale,
        GreyscaleDarken,
        GreyscaleLighten,
        Darken,
        Lighten,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputCadDataemptyLayoutDetectionInput
    {
        Default,
        SkipNone,
        SkipEmptyLayouts,
        SkipLayoutsWithoutViewports
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputCadDatalayoutSortOrderInput
    {
        Default,
        Ascending,
        Descending,
        TabOrder
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputEmailDataattachmentActionInput
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputEmailDataunsupportedAttachmentActionInput
    {
        Error,
        Remove,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputEmailDatapaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputEmailDataconversionQualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputExcelDataoutputFormatInput
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputExcelDatarangeInput
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputExcelDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatapageOrientationInput
    {
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatamediaTypeInput
    {
        Screen,
        Print
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataauthenticationTypeInput
    {
        Anonymous,
        [EnumMember(Value = "SharePoint Online")]
        SharePointOnline,
        Web
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDataoutputFormatInput
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDataattachmentActionInput
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDataunsupportedAttachmentActionInput
    {
        Error,
        Remove,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDatadefaultPaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDataforcePaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDatadefaultPageOrientationInput
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDataforcePageOrientationInput
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInfopathDataconversionQualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatapDFProfileInput
    {
        Default,
        [EnumMember(Value = "PDF_1_5")]
        PDF15,
        [EnumMember(Value = "PDF_A1B")]
        PDFA1B,
        [EnumMember(Value = "PDF_A2B")]
        PDFA2B,
        [EnumMember(Value = "PDF_A2U")]
        PDFA2U,
        [EnumMember(Value = "PDF_A3B")]
        PDFA3B,
        [EnumMember(Value = "PDF_A3U")]
        PDFA3U,
        [EnumMember(Value = "PDF_1_1")]
        PDF11,
        [EnumMember(Value = "PDF_1_2")]
        PDF12,
        [EnumMember(Value = "PDF_1_3")]
        PDF13,
        [EnumMember(Value = "PDF_1_4")]
        PDF14,
        [EnumMember(Value = "PDF_1_6")]
        PDF16,
        [EnumMember(Value = "PDF_1_7")]
        PDF17
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPowerpointDataoutputFormatInput
    {
        PDF,
        XPS,
        MHT,
        XML,
        PPT,
        PPTX,
        ODP,
        PPS,
        PPSX
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPowerpointDatarangeInput
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPowerpointDataprintLayoutHandoutsInput
    {
        Slides,
        OneSlideHandouts,
        TwoSlideHandouts,
        ThreeSlideHandouts,
        FourSlideHandouts,
        SixSlideHandouts,
        NineSlideHandouts,
        NotesPages,
        Outline
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPowerpointDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputVisioDataoutputFormatInput
    {
        PDF,
        XPS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputVisioDatarangeInput
    {
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputVisioDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputWordDataoutputFormatInput
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputWordDatadisplayForReviewInput
    {
        Final,
        Original,
        FinalShowingMarkup,
        OriginalShowingMarkup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputWordDatareviewMarkupModeInput
    {
        Balloon,
        InLine,
        Mixed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputWordDatagenerateBookmarksInput
    {
        Disabled,
        Automatic,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputWordDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class OperationResponseCommon
    {
        [JsonProperty("base_file_name")]
        public string BaseFileName { get; set; }

        [JsonProperty("result_code")]
        public OperationResponseCommonResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationResponseCommonResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatapositionInput
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Middle Left")]
        MiddleLeft,
        [EnumMember(Value = "Middle Center")]
        MiddleCenter,
        [EnumMember(Value = "Middle Right")]
        MiddleRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight,
        Absolute,
        Random
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatalayerInput
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatawatermarkPageOrientationInput
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataprintOnlyInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputFromPdfDataoutputDataFormatInput
    {
        XML,
        FDF,
        XFDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputXmlDataflattenInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputXmlDatareadOnlyInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatadPIInput
    {
        [EnumMember(Value = "500")]
        _500,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "150")]
        _150
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatakVPOutputFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataautorotateInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatatrimSymbolsInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeKeyBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeValueBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludePageNumberInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeConfidenceInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeTypeInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatabarcodeTypeInput
    {
        Codabar,
        Code11,
        Code32,
        Code39,
        Code39Extended,
        Code93,
        Code93Extended,
        Code128,
        Code128A,
        Code128B,
        Code128C,
        GS1Code128,
        [EnumMember(Value = "UPC_A")]
        UPCA
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatadisableCheckDigitInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatashowCheckDigitInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataomitEncodingOfStartStopSymbolsInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatalabelPlacementInput
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        None,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataeachDocumentInput
    {
        [EnumMember(Value = "Starts on the default page")]
        StartsOnTheDefaultPage,
        [EnumMember(Value = "Starts on the next page")]
        StartsOnTheNextPage,
        [EnumMember(Value = "Starts on the next odd page")]
        StartsOnTheNextOddPage,
        [EnumMember(Value = "Starts on the next even page")]
        StartsOnTheNextEvenPage
    }

    public class MergeSourceFile
    {
        [JsonProperty("source_file_name")]
        public string Name { get; set; }

        [JsonProperty("source_file_content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatalanguageInput
    {
        English,
        Arabic,
        Danish,
        German,
        Dutch,
        Finnish,
        French,
        Hebrew,
        Hungarian,
        Italian,
        Norwegian,
        Portuguese,
        Spanish,
        Swedish,
        Russian
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataperformanceInput
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatablacklistWhitelistInput
    {
        None,
        Whitelist,
        Blacklist
    }

    public class OcrOperationResponse
    {
        [JsonProperty("out_text")]
        public string OutText { get; set; }

        [JsonProperty("base_file_name")]
        public string BaseFileName { get; set; }

        [JsonProperty("result_code")]
        public OcrOperationResponseResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrOperationResponseResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataversionInput
    {
        Auto,
        [EnumMember(Value = "Version 1")]
        Version1,
        [EnumMember(Value = "Version 2")]
        Version2,
        [EnumMember(Value = "Version 3")]
        Version3,
        [EnumMember(Value = "Version 4")]
        Version4,
        [EnumMember(Value = "Version 5")]
        Version5,
        [EnumMember(Value = "Version 6")]
        Version6,
        [EnumMember(Value = "Version 7")]
        Version7,
        [EnumMember(Value = "Version 8")]
        Version8,
        [EnumMember(Value = "Version 9")]
        Version9,
        [EnumMember(Value = "Version 10")]
        Version10,
        [EnumMember(Value = "Version 11")]
        Version11,
        [EnumMember(Value = "Version 12")]
        Version12,
        [EnumMember(Value = "Version 13")]
        Version13,
        [EnumMember(Value = "Version 14")]
        Version14,
        [EnumMember(Value = "Version 15")]
        Version15,
        [EnumMember(Value = "Version 16")]
        Version16,
        [EnumMember(Value = "Version 17")]
        Version17,
        [EnumMember(Value = "Version 18")]
        Version18,
        [EnumMember(Value = "Version 19")]
        Version19,
        [EnumMember(Value = "Version 20")]
        Version20,
        [EnumMember(Value = "Version 21")]
        Version21,
        [EnumMember(Value = "Version 22")]
        Version22,
        [EnumMember(Value = "Version 23")]
        Version23,
        [EnumMember(Value = "Version 24")]
        Version24,
        [EnumMember(Value = "Version 25")]
        Version25,
        [EnumMember(Value = "Version 26")]
        Version26,
        [EnumMember(Value = "Version 27")]
        Version27,
        [EnumMember(Value = "Version 28")]
        Version28,
        [EnumMember(Value = "Version 29")]
        Version29,
        [EnumMember(Value = "Version 30")]
        Version30,
        [EnumMember(Value = "Version 31")]
        Version31,
        [EnumMember(Value = "Version 32")]
        Version32,
        [EnumMember(Value = "Version 33")]
        Version33,
        [EnumMember(Value = "Version 34")]
        Version34,
        [EnumMember(Value = "Version 35")]
        Version35,
        [EnumMember(Value = "Version 36")]
        Version36,
        [EnumMember(Value = "Version 37")]
        Version37,
        [EnumMember(Value = "Version 38")]
        Version38,
        [EnumMember(Value = "Version 39")]
        Version39,
        [EnumMember(Value = "Version 40")]
        Version40
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatainputModeInput
    {
        Binary,
        Alphanumeric,
        Numeric
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDataerrorCorrectionLevelInput
    {
        Low,
        Medium,
        High,
        Quartile
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataredactionTypeInput
    {
        Text,
        Regex
    }

    public class SplitOperationResponse
    {
        [JsonProperty("processed_files")]
        public ProcessedFiles[] ProcessedFiles { get; set; }

        [JsonProperty("result_code")]
        public SplitOperationResponseResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    public class ProcessedFiles
    {
        [JsonProperty("processed_file_name")]
        public string ProcessedFileName { get; set; }

        [JsonProperty("processed_file_content")]
        public string ProcessedFileContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitOperationResponseResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatasplitByInput
    {
        [EnumMember(Value = "Number of Pages")]
        NumberOfPages,
        [EnumMember(Value = "Bookmark Level")]
        BookmarkLevel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatatextAlignmentInput
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Top Justfiy")]
        TopJustfiy,
        [EnumMember(Value = "Middle Left")]
        MiddleLeft,
        [EnumMember(Value = "Middle Center")]
        MiddleCenter,
        [EnumMember(Value = "Middle Right")]
        MiddleRight,
        [EnumMember(Value = "Middle Justfiy")]
        MiddleJustfiy,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight,
        [EnumMember(Value = "Bottom Justfiy")]
        BottomJustfiy
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatawordWrapInput
    {
        WordOnly,
        Character,
        None,
        Word
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi;

    public partial class WorkflowManagedActions
    {
        public MuhimbiActions Muhimbi(string connectionId) => new MuhimbiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MuhimbiTriggers Muhimbi(string connectionId) => new MuhimbiTriggers(connectionId);
    }
}