//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        [WorkflowExpressionFactory(nameof(__BuildCompositeWatermark))]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkData, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildCompositeWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatawatermarkData, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatawatermarkData, nameof(inputDatawatermarkData), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/composite_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["watermark_data"] = ExpressionConverter.ConvertO(inputDatawatermarkData);
                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildCompressPdf))]
        public IBodyWorkflowAction<OperationResponse> CompressPdf([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<inputPdfDataremoveAnnotationsInput> inputPdfDataremoveAnnotations = null, [WorkflowExpression] Func<inputPdfDataremoveBlankPagesInput> inputPdfDataremoveBlankPages = null, [WorkflowExpression] Func<inputPdfDataremoveBookmarksInput> inputPdfDataremoveBookmarks = null, [WorkflowExpression] Func<inputPdfDataremoveEmbeddedFilesInput> inputPdfDataremoveEmbeddedFiles = null, [WorkflowExpression] Func<inputPdfDataremoveFormFieldsInput> inputPdfDataremoveFormFields = null, [WorkflowExpression] Func<inputPdfDataremoveHyperlinksInput> inputPdfDataremoveHyperlinks = null, [WorkflowExpression] Func<inputPdfDataremoveJavaScriptInput> inputPdfDataremoveJavaScript = null, [WorkflowExpression] Func<inputPdfDataremoveMetadataInput> inputPdfDataremoveMetadata = null, [WorkflowExpression] Func<inputPdfDataremovePageThumbnailsInput> inputPdfDataremovePageThumbnails = null, [WorkflowExpression] Func<inputPdfDatapackFontsInput> inputPdfDatapackFonts = null, [WorkflowExpression] Func<inputPdfDatapackDocumentInput> inputPdfDatapackDocument = null, [WorkflowExpression] Func<inputPdfDatarecompressImagesInput> inputPdfDatarecompressImages = null, [WorkflowExpression] Func<inputPdfDataenableMRCInput> inputPdfDataenableMRC = null, [WorkflowExpression] Func<int> inputPdfDatadownscaleResolutionMRC = null, [WorkflowExpression] Func<inputPdfDatapreserveSmoothingInput> inputPdfDatapreserveSmoothing = null, [WorkflowExpression] Func<inputPdfDataimageQualityInput> inputPdfDataimageQuality = null, [WorkflowExpression] Func<inputPdfDatadownscaleImagesInput> inputPdfDatadownscaleImages = null, [WorkflowExpression] Func<int> inputPdfDatadownscaleResolution = null, [WorkflowExpression] Func<inputPdfDataenableColorDetectionInput> inputPdfDataenableColorDetection = null, [WorkflowExpression] Func<inputPdfDataenableCharRepairInput> inputPdfDataenableCharRepair = null, [WorkflowExpression] Func<inputPdfDataenableJPEG2000Input> inputPdfDataenableJPEG2000 = null, [WorkflowExpression] Func<inputPdfDataenableJBIG2Input> inputPdfDataenableJBIG2 = null, [WorkflowExpression] Func<int> inputPdfDatajBIG2PMSThreshold = null, [WorkflowExpression] Func<string> inputPdfDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildCompressPdf(WorkflowValue<string> inputPdfDatasourceFileName, WorkflowValue<string> inputPdfDatasourceFileContent, WorkflowValue<inputPdfDataremoveAnnotationsInput> inputPdfDataremoveAnnotations = null, WorkflowValue<inputPdfDataremoveBlankPagesInput> inputPdfDataremoveBlankPages = null, WorkflowValue<inputPdfDataremoveBookmarksInput> inputPdfDataremoveBookmarks = null, WorkflowValue<inputPdfDataremoveEmbeddedFilesInput> inputPdfDataremoveEmbeddedFiles = null, WorkflowValue<inputPdfDataremoveFormFieldsInput> inputPdfDataremoveFormFields = null, WorkflowValue<inputPdfDataremoveHyperlinksInput> inputPdfDataremoveHyperlinks = null, WorkflowValue<inputPdfDataremoveJavaScriptInput> inputPdfDataremoveJavaScript = null, WorkflowValue<inputPdfDataremoveMetadataInput> inputPdfDataremoveMetadata = null, WorkflowValue<inputPdfDataremovePageThumbnailsInput> inputPdfDataremovePageThumbnails = null, WorkflowValue<inputPdfDatapackFontsInput> inputPdfDatapackFonts = null, WorkflowValue<inputPdfDatapackDocumentInput> inputPdfDatapackDocument = null, WorkflowValue<inputPdfDatarecompressImagesInput> inputPdfDatarecompressImages = null, WorkflowValue<inputPdfDataenableMRCInput> inputPdfDataenableMRC = null, WorkflowValue<int> inputPdfDatadownscaleResolutionMRC = null, WorkflowValue<inputPdfDatapreserveSmoothingInput> inputPdfDatapreserveSmoothing = null, WorkflowValue<inputPdfDataimageQualityInput> inputPdfDataimageQuality = null, WorkflowValue<inputPdfDatadownscaleImagesInput> inputPdfDatadownscaleImages = null, WorkflowValue<int> inputPdfDatadownscaleResolution = null, WorkflowValue<inputPdfDataenableColorDetectionInput> inputPdfDataenableColorDetection = null, WorkflowValue<inputPdfDataenableCharRepairInput> inputPdfDataenableCharRepair = null, WorkflowValue<inputPdfDataenableJPEG2000Input> inputPdfDataenableJPEG2000 = null, WorkflowValue<inputPdfDataenableJBIG2Input> inputPdfDataenableJBIG2 = null, WorkflowValue<int> inputPdfDatajBIG2PMSThreshold = null, WorkflowValue<string> inputPdfDataoverrideSettings = null, WorkflowValue<bool> inputPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPdfDataremoveAnnotations, nameof(inputPdfDataremoveAnnotations), required: false);
            WorkflowValue.Validate(inputPdfDataremoveBlankPages, nameof(inputPdfDataremoveBlankPages), required: false);
            WorkflowValue.Validate(inputPdfDataremoveBookmarks, nameof(inputPdfDataremoveBookmarks), required: false);
            WorkflowValue.Validate(inputPdfDataremoveEmbeddedFiles, nameof(inputPdfDataremoveEmbeddedFiles), required: false);
            WorkflowValue.Validate(inputPdfDataremoveFormFields, nameof(inputPdfDataremoveFormFields), required: false);
            WorkflowValue.Validate(inputPdfDataremoveHyperlinks, nameof(inputPdfDataremoveHyperlinks), required: false);
            WorkflowValue.Validate(inputPdfDataremoveJavaScript, nameof(inputPdfDataremoveJavaScript), required: false);
            WorkflowValue.Validate(inputPdfDataremoveMetadata, nameof(inputPdfDataremoveMetadata), required: false);
            WorkflowValue.Validate(inputPdfDataremovePageThumbnails, nameof(inputPdfDataremovePageThumbnails), required: false);
            WorkflowValue.Validate(inputPdfDatapackFonts, nameof(inputPdfDatapackFonts), required: false);
            WorkflowValue.Validate(inputPdfDatapackDocument, nameof(inputPdfDatapackDocument), required: false);
            WorkflowValue.Validate(inputPdfDatarecompressImages, nameof(inputPdfDatarecompressImages), required: false);
            WorkflowValue.Validate(inputPdfDataenableMRC, nameof(inputPdfDataenableMRC), required: false);
            WorkflowValue.Validate(inputPdfDatadownscaleResolutionMRC, nameof(inputPdfDatadownscaleResolutionMRC), required: false);
            WorkflowValue.Validate(inputPdfDatapreserveSmoothing, nameof(inputPdfDatapreserveSmoothing), required: false);
            WorkflowValue.Validate(inputPdfDataimageQuality, nameof(inputPdfDataimageQuality), required: false);
            WorkflowValue.Validate(inputPdfDatadownscaleImages, nameof(inputPdfDatadownscaleImages), required: false);
            WorkflowValue.Validate(inputPdfDatadownscaleResolution, nameof(inputPdfDatadownscaleResolution), required: false);
            WorkflowValue.Validate(inputPdfDataenableColorDetection, nameof(inputPdfDataenableColorDetection), required: false);
            WorkflowValue.Validate(inputPdfDataenableCharRepair, nameof(inputPdfDataenableCharRepair), required: false);
            WorkflowValue.Validate(inputPdfDataenableJPEG2000, nameof(inputPdfDataenableJPEG2000), required: false);
            WorkflowValue.Validate(inputPdfDataenableJBIG2, nameof(inputPdfDataenableJBIG2), required: false);
            WorkflowValue.Validate(inputPdfDatajBIG2PMSThreshold, nameof(inputPdfDatajBIG2PMSThreshold), required: false);
            WorkflowValue.Validate(inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/compress_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                if (inputPdfDataremoveAnnotations != null)
                {
                    if (inputPdfDataremoveAnnotations != null)
                    {
                        inputPdfData["remove_annotations"] = ExpressionConverter.ConvertO(inputPdfDataremoveAnnotations);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_annotations"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveBlankPages != null)
                {
                    if (inputPdfDataremoveBlankPages != null)
                    {
                        inputPdfData["remove_blank_pages"] = ExpressionConverter.ConvertO(inputPdfDataremoveBlankPages);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_blank_pages"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveBookmarks != null)
                {
                    if (inputPdfDataremoveBookmarks != null)
                    {
                        inputPdfData["remove_bookmarks"] = ExpressionConverter.ConvertO(inputPdfDataremoveBookmarks);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_bookmarks"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveEmbeddedFiles != null)
                {
                    if (inputPdfDataremoveEmbeddedFiles != null)
                    {
                        inputPdfData["remove_embedded_files"] = ExpressionConverter.ConvertO(inputPdfDataremoveEmbeddedFiles);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_embedded_files"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveFormFields != null)
                {
                    if (inputPdfDataremoveFormFields != null)
                    {
                        inputPdfData["remove_form_fields"] = ExpressionConverter.ConvertO(inputPdfDataremoveFormFields);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_form_fields"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveHyperlinks != null)
                {
                    if (inputPdfDataremoveHyperlinks != null)
                    {
                        inputPdfData["remove_hyperlinks"] = ExpressionConverter.ConvertO(inputPdfDataremoveHyperlinks);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_hyperlinks"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveJavaScript != null)
                {
                    if (inputPdfDataremoveJavaScript != null)
                    {
                        inputPdfData["remove_javascript"] = ExpressionConverter.ConvertO(inputPdfDataremoveJavaScript);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_javascript"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremoveMetadata != null)
                {
                    if (inputPdfDataremoveMetadata != null)
                    {
                        inputPdfData["remove_metadata"] = ExpressionConverter.ConvertO(inputPdfDataremoveMetadata);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_metadata"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataremovePageThumbnails != null)
                {
                    if (inputPdfDataremovePageThumbnails != null)
                    {
                        inputPdfData["remove_page_thumbnails"] = ExpressionConverter.ConvertO(inputPdfDataremovePageThumbnails);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["remove_page_thumbnails"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapackFonts != null)
                {
                    if (inputPdfDatapackFonts != null)
                    {
                        inputPdfData["pack_fonts"] = ExpressionConverter.ConvertO(inputPdfDatapackFonts);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["pack_fonts"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapackDocument != null)
                {
                    if (inputPdfDatapackDocument != null)
                    {
                        inputPdfData["pack_document"] = ExpressionConverter.ConvertO(inputPdfDatapackDocument);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["pack_document"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatarecompressImages != null)
                {
                    if (inputPdfDatarecompressImages != null)
                    {
                        inputPdfData["recompress_images"] = ExpressionConverter.ConvertO(inputPdfDatarecompressImages);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["recompress_images"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataenableMRC != null)
                {
                    if (inputPdfDataenableMRC != null)
                    {
                        inputPdfData["enable_mrc"] = ExpressionConverter.ConvertO(inputPdfDataenableMRC);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_mrc"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatadownscaleResolutionMRC != null)
                {
                    if (inputPdfDatadownscaleResolutionMRC != null)
                    {
                        inputPdfData["downscale_resolution_mrc"] = ExpressionConverter.ConvertO(inputPdfDatadownscaleResolutionMRC);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["downscale_resolution_mrc"] = 100;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapreserveSmoothing != null)
                {
                    if (inputPdfDatapreserveSmoothing != null)
                    {
                        inputPdfData["preserve_smoothing"] = ExpressionConverter.ConvertO(inputPdfDatapreserveSmoothing);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["preserve_smoothing"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataimageQuality != null)
                {
                    if (inputPdfDataimageQuality != null)
                    {
                        inputPdfData["image_quality"] = ExpressionConverter.ConvertO(inputPdfDataimageQuality);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["image_quality"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatadownscaleImages != null)
                {
                    if (inputPdfDatadownscaleImages != null)
                    {
                        inputPdfData["downscale_images"] = ExpressionConverter.ConvertO(inputPdfDatadownscaleImages);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["downscale_images"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatadownscaleResolution != null)
                {
                    if (inputPdfDatadownscaleResolution != null)
                    {
                        inputPdfData["downscale_resolution"] = ExpressionConverter.ConvertO(inputPdfDatadownscaleResolution);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["downscale_resolution"] = 200;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataenableColorDetection != null)
                {
                    if (inputPdfDataenableColorDetection != null)
                    {
                        inputPdfData["enable_color_detection"] = ExpressionConverter.ConvertO(inputPdfDataenableColorDetection);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_color_detection"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataenableCharRepair != null)
                {
                    if (inputPdfDataenableCharRepair != null)
                    {
                        inputPdfData["enable_char_repair"] = ExpressionConverter.ConvertO(inputPdfDataenableCharRepair);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_char_repair"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataenableJPEG2000 != null)
                {
                    if (inputPdfDataenableJPEG2000 != null)
                    {
                        inputPdfData["enable_jpeg2000"] = ExpressionConverter.ConvertO(inputPdfDataenableJPEG2000);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_jpeg2000"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataenableJBIG2 != null)
                {
                    if (inputPdfDataenableJBIG2 != null)
                    {
                        inputPdfData["enable_jbig2"] = ExpressionConverter.ConvertO(inputPdfDataenableJBIG2);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["enable_jbig2"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatajBIG2PMSThreshold != null)
                {
                    if (inputPdfDatajBIG2PMSThreshold != null)
                    {
                        inputPdfData["jbig2_pms_threshold"] = ExpressionConverter.ConvertO(inputPdfDatajBIG2PMSThreshold);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["jbig2_pms_threshold"] = 85;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataoverrideSettings != null)
                {
                    inputPdfData["override_settings"] = ExpressionConverter.ConvertO(inputPdfDataoverrideSettings);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvert))]
        public IBodyWorkflowAction<OperationResponse> Convert([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDataoutputFormatInput> inputDataoutputFormat, [WorkflowExpression] Func<string> inputDataoverrideSettings = null, [WorkflowExpression] Func<string> inputDatatemplateFileContent = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvert(WorkflowValue<string> inputDatasourceFileName, WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDataoutputFormatInput> inputDataoutputFormat, WorkflowValue<string> inputDataoverrideSettings = null, WorkflowValue<string> inputDatatemplateFileContent = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDataoutputFormat, nameof(inputDataoutputFormat), required: true);
            WorkflowValue.Validate(inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputDatatemplateFileContent, nameof(inputDatatemplateFileContent), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["output_format"] = ExpressionConverter.ConvertO(inputDataoutputFormat);
                inputData["copy_metadata"] = false;
                inputDatapropCount++;
                if (inputDataoverrideSettings != null)
                {
                    inputData["override_settings"] = ExpressionConverter.ConvertO(inputDataoverrideSettings);
                    inputDatapropCount++;
                }

                if (inputDatatemplateFileContent != null)
                {
                    inputData["template_file_content"] = ExpressionConverter.ConvertO(inputDatatemplateFileContent);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertCad))]
        public IBodyWorkflowAction<OperationResponse> ConvertCad([WorkflowExpression] Func<string> inputCadDatasourceFileName, [WorkflowExpression] Func<string> inputCadDatasourceFileContent, [WorkflowExpression] Func<inputCadDatapaperSizeInput> inputCadDatapaperSize = null, [WorkflowExpression] Func<string> inputCadDatapaperSizeCustom = null, [WorkflowExpression] Func<string> inputCadDatapageMargins = null, [WorkflowExpression] Func<string> inputCadDatabackgroundColor = null, [WorkflowExpression] Func<inputCadDataforegroundColorInput> inputCadDataforegroundColor = null, [WorkflowExpression] Func<string> inputCadDataforegroundColorCustom = null, [WorkflowExpression] Func<inputCadDataemptyLayoutDetectionInput> inputCadDataemptyLayoutDetection = null, [WorkflowExpression] Func<inputCadDatalayoutSortOrderInput> inputCadDatalayoutSortOrder = null, [WorkflowExpression] Func<int> inputCadDatastartPage = null, [WorkflowExpression] Func<int> inputCadDataendPage = null, [WorkflowExpression] Func<string> inputCadDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputCadDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertCad(WorkflowValue<string> inputCadDatasourceFileName, WorkflowValue<string> inputCadDatasourceFileContent, WorkflowValue<inputCadDatapaperSizeInput> inputCadDatapaperSize = null, WorkflowValue<string> inputCadDatapaperSizeCustom = null, WorkflowValue<string> inputCadDatapageMargins = null, WorkflowValue<string> inputCadDatabackgroundColor = null, WorkflowValue<inputCadDataforegroundColorInput> inputCadDataforegroundColor = null, WorkflowValue<string> inputCadDataforegroundColorCustom = null, WorkflowValue<inputCadDataemptyLayoutDetectionInput> inputCadDataemptyLayoutDetection = null, WorkflowValue<inputCadDatalayoutSortOrderInput> inputCadDatalayoutSortOrder = null, WorkflowValue<int> inputCadDatastartPage = null, WorkflowValue<int> inputCadDataendPage = null, WorkflowValue<string> inputCadDataoverrideSettings = null, WorkflowValue<bool> inputCadDatafailOnError = null)
        {
            WorkflowValue.Validate(inputCadDatasourceFileName, nameof(inputCadDatasourceFileName), required: true);
            WorkflowValue.Validate(inputCadDatasourceFileContent, nameof(inputCadDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputCadDatapaperSize, nameof(inputCadDatapaperSize), required: false);
            WorkflowValue.Validate(inputCadDatapaperSizeCustom, nameof(inputCadDatapaperSizeCustom), required: false);
            WorkflowValue.Validate(inputCadDatapageMargins, nameof(inputCadDatapageMargins), required: false);
            WorkflowValue.Validate(inputCadDatabackgroundColor, nameof(inputCadDatabackgroundColor), required: false);
            WorkflowValue.Validate(inputCadDataforegroundColor, nameof(inputCadDataforegroundColor), required: false);
            WorkflowValue.Validate(inputCadDataforegroundColorCustom, nameof(inputCadDataforegroundColorCustom), required: false);
            WorkflowValue.Validate(inputCadDataemptyLayoutDetection, nameof(inputCadDataemptyLayoutDetection), required: false);
            WorkflowValue.Validate(inputCadDatalayoutSortOrder, nameof(inputCadDatalayoutSortOrder), required: false);
            WorkflowValue.Validate(inputCadDatastartPage, nameof(inputCadDatastartPage), required: false);
            WorkflowValue.Validate(inputCadDataendPage, nameof(inputCadDataendPage), required: false);
            WorkflowValue.Validate(inputCadDataoverrideSettings, nameof(inputCadDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputCadDatafailOnError, nameof(inputCadDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_cad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputCadData = new JObject();
                var inputCadDatapropCount = 0;
                inputCadData["use_async_pattern"] = false;
                inputCadDatapropCount++;
                inputCadDatapropCount++;
                inputCadData["source_file_name"] = ExpressionConverter.ConvertO(inputCadDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputCadData["sharepoint_file"] = sharepointFileObject;
                    inputCadDatapropCount++;
                }

                inputCadDatapropCount++;
                inputCadData["source_file_content"] = ExpressionConverter.ConvertO(inputCadDatasourceFileContent);
                inputCadData["copy_metadata"] = false;
                inputCadDatapropCount++;
                if (inputCadDatapaperSize != null)
                {
                    if (inputCadDatapaperSize != null)
                    {
                        inputCadData["paper_size"] = ExpressionConverter.ConvertO(inputCadDatapaperSize);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["paper_size"] = "Letter";
                    inputCadDatapropCount++;
                }

                if (inputCadDatapaperSizeCustom != null)
                {
                    inputCadData["paper_size_custom"] = ExpressionConverter.ConvertO(inputCadDatapaperSizeCustom);
                    inputCadDatapropCount++;
                }

                if (inputCadDatapageMargins != null)
                {
                    if (inputCadDatapageMargins != null)
                    {
                        inputCadData["page_margins"] = ExpressionConverter.ConvertO(inputCadDatapageMargins);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["page_margins"] = "0.25";
                    inputCadDatapropCount++;
                }

                if (inputCadDatabackgroundColor != null)
                {
                    if (inputCadDatabackgroundColor != null)
                    {
                        inputCadData["background_color"] = ExpressionConverter.ConvertO(inputCadDatabackgroundColor);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["background_color"] = "White";
                    inputCadDatapropCount++;
                }

                if (inputCadDataforegroundColor != null)
                {
                    if (inputCadDataforegroundColor != null)
                    {
                        inputCadData["foreground_color"] = ExpressionConverter.ConvertO(inputCadDataforegroundColor);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["foreground_color"] = "GreyscaleDarken";
                    inputCadDatapropCount++;
                }

                if (inputCadDataforegroundColorCustom != null)
                {
                    inputCadData["foreground_color_custom"] = ExpressionConverter.ConvertO(inputCadDataforegroundColorCustom);
                    inputCadDatapropCount++;
                }

                if (inputCadDataemptyLayoutDetection != null)
                {
                    if (inputCadDataemptyLayoutDetection != null)
                    {
                        inputCadData["empty_layout_detection_mode"] = ExpressionConverter.ConvertO(inputCadDataemptyLayoutDetection);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["empty_layout_detection_mode"] = "SkipEmptyLayouts";
                    inputCadDatapropCount++;
                }

                if (inputCadDatalayoutSortOrder != null)
                {
                    if (inputCadDatalayoutSortOrder != null)
                    {
                        inputCadData["layout_sort_order"] = ExpressionConverter.ConvertO(inputCadDatalayoutSortOrder);
                        inputCadDatapropCount++;
                    }

                    inputCadDatapropCount++;
                }
                else
                {
                    inputCadData["layout_sort_order"] = "Ascending";
                    inputCadDatapropCount++;
                }

                if (inputCadDatastartPage != null)
                {
                    inputCadData["start_page"] = ExpressionConverter.ConvertO(inputCadDatastartPage);
                    inputCadDatapropCount++;
                }

                if (inputCadDataendPage != null)
                {
                    inputCadData["end_page"] = ExpressionConverter.ConvertO(inputCadDataendPage);
                    inputCadDatapropCount++;
                }

                if (inputCadDataoverrideSettings != null)
                {
                    inputCadData["override_settings"] = ExpressionConverter.ConvertO(inputCadDataoverrideSettings);
                    inputCadDatapropCount++;
                }

                if (inputCadDatafailOnError != null)
                {
                    if (inputCadDatafailOnError != null)
                    {
                        inputCadData["fail_on_error"] = ExpressionConverter.ConvertO(inputCadDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertEmail))]
        public IBodyWorkflowAction<OperationResponse> ConvertEmail([WorkflowExpression] Func<string> inputEmailDatasourceFileName, [WorkflowExpression] Func<string> inputEmailDatasourceFileContent, [WorkflowExpression] Func<bool> inputEmailDataincludeAttachments = null, [WorkflowExpression] Func<inputEmailDataattachmentActionInput> inputEmailDataattachmentAction = null, [WorkflowExpression] Func<bool> inputEmailDataattachmentSummary = null, [WorkflowExpression] Func<inputEmailDataunsupportedAttachmentActionInput> inputEmailDataunsupportedAttachmentAction = null, [WorkflowExpression] Func<string> inputEmailDataincludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputEmailDataexcludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputEmailDataviewportSize = null, [WorkflowExpression] Func<inputEmailDatapaperSizeInput> inputEmailDatapaperSize = null, [WorkflowExpression] Func<string> inputEmailDatapaperSizeCustom = null, [WorkflowExpression] Func<string> inputEmailDatapageMargins = null, [WorkflowExpression] Func<bool> inputEmailDataattachmentErrors = null, [WorkflowExpression] Func<int> inputEmailDataminImageSize = null, [WorkflowExpression] Func<bool> inputEmailDataofflineMode = null, [WorkflowExpression] Func<int> inputEmailDatastartPage = null, [WorkflowExpression] Func<int> inputEmailDataendPage = null, [WorkflowExpression] Func<inputEmailDataconversionQualityInput> inputEmailDataconversionQuality = null, [WorkflowExpression] Func<string> inputEmailDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputEmailDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertEmail(WorkflowValue<string> inputEmailDatasourceFileName, WorkflowValue<string> inputEmailDatasourceFileContent, WorkflowValue<bool> inputEmailDataincludeAttachments = null, WorkflowValue<inputEmailDataattachmentActionInput> inputEmailDataattachmentAction = null, WorkflowValue<bool> inputEmailDataattachmentSummary = null, WorkflowValue<inputEmailDataunsupportedAttachmentActionInput> inputEmailDataunsupportedAttachmentAction = null, WorkflowValue<string> inputEmailDataincludeAttachmentFilter = null, WorkflowValue<string> inputEmailDataexcludeAttachmentFilter = null, WorkflowValue<string> inputEmailDataviewportSize = null, WorkflowValue<inputEmailDatapaperSizeInput> inputEmailDatapaperSize = null, WorkflowValue<string> inputEmailDatapaperSizeCustom = null, WorkflowValue<string> inputEmailDatapageMargins = null, WorkflowValue<bool> inputEmailDataattachmentErrors = null, WorkflowValue<int> inputEmailDataminImageSize = null, WorkflowValue<bool> inputEmailDataofflineMode = null, WorkflowValue<int> inputEmailDatastartPage = null, WorkflowValue<int> inputEmailDataendPage = null, WorkflowValue<inputEmailDataconversionQualityInput> inputEmailDataconversionQuality = null, WorkflowValue<string> inputEmailDataoverrideSettings = null, WorkflowValue<bool> inputEmailDatafailOnError = null)
        {
            WorkflowValue.Validate(inputEmailDatasourceFileName, nameof(inputEmailDatasourceFileName), required: true);
            WorkflowValue.Validate(inputEmailDatasourceFileContent, nameof(inputEmailDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputEmailDataincludeAttachments, nameof(inputEmailDataincludeAttachments), required: false);
            WorkflowValue.Validate(inputEmailDataattachmentAction, nameof(inputEmailDataattachmentAction), required: false);
            WorkflowValue.Validate(inputEmailDataattachmentSummary, nameof(inputEmailDataattachmentSummary), required: false);
            WorkflowValue.Validate(inputEmailDataunsupportedAttachmentAction, nameof(inputEmailDataunsupportedAttachmentAction), required: false);
            WorkflowValue.Validate(inputEmailDataincludeAttachmentFilter, nameof(inputEmailDataincludeAttachmentFilter), required: false);
            WorkflowValue.Validate(inputEmailDataexcludeAttachmentFilter, nameof(inputEmailDataexcludeAttachmentFilter), required: false);
            WorkflowValue.Validate(inputEmailDataviewportSize, nameof(inputEmailDataviewportSize), required: false);
            WorkflowValue.Validate(inputEmailDatapaperSize, nameof(inputEmailDatapaperSize), required: false);
            WorkflowValue.Validate(inputEmailDatapaperSizeCustom, nameof(inputEmailDatapaperSizeCustom), required: false);
            WorkflowValue.Validate(inputEmailDatapageMargins, nameof(inputEmailDatapageMargins), required: false);
            WorkflowValue.Validate(inputEmailDataattachmentErrors, nameof(inputEmailDataattachmentErrors), required: false);
            WorkflowValue.Validate(inputEmailDataminImageSize, nameof(inputEmailDataminImageSize), required: false);
            WorkflowValue.Validate(inputEmailDataofflineMode, nameof(inputEmailDataofflineMode), required: false);
            WorkflowValue.Validate(inputEmailDatastartPage, nameof(inputEmailDatastartPage), required: false);
            WorkflowValue.Validate(inputEmailDataendPage, nameof(inputEmailDataendPage), required: false);
            WorkflowValue.Validate(inputEmailDataconversionQuality, nameof(inputEmailDataconversionQuality), required: false);
            WorkflowValue.Validate(inputEmailDataoverrideSettings, nameof(inputEmailDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputEmailDatafailOnError, nameof(inputEmailDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputEmailData = new JObject();
                var inputEmailDatapropCount = 0;
                inputEmailData["use_async_pattern"] = false;
                inputEmailDatapropCount++;
                inputEmailDatapropCount++;
                inputEmailData["source_file_name"] = ExpressionConverter.ConvertO(inputEmailDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputEmailData["sharepoint_file"] = sharepointFileObject;
                    inputEmailDatapropCount++;
                }

                inputEmailDatapropCount++;
                inputEmailData["source_file_content"] = ExpressionConverter.ConvertO(inputEmailDatasourceFileContent);
                inputEmailData["copy_metadata"] = false;
                inputEmailDatapropCount++;
                if (inputEmailDataincludeAttachments != null)
                {
                    if (inputEmailDataincludeAttachments != null)
                    {
                        inputEmailData["convert_attachments"] = ExpressionConverter.ConvertO(inputEmailDataincludeAttachments);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["convert_attachments"] = true;
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataattachmentAction != null)
                {
                    inputEmailData["attachment_merge_mode"] = ExpressionConverter.ConvertO(inputEmailDataattachmentAction);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataattachmentSummary != null)
                {
                    if (inputEmailDataattachmentSummary != null)
                    {
                        inputEmailData["display_attachment_summary"] = ExpressionConverter.ConvertO(inputEmailDataattachmentSummary);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["display_attachment_summary"] = true;
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataunsupportedAttachmentAction != null)
                {
                    if (inputEmailDataunsupportedAttachmentAction != null)
                    {
                        inputEmailData["unsupported_attachment_behaviour"] = ExpressionConverter.ConvertO(inputEmailDataunsupportedAttachmentAction);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["unsupported_attachment_behaviour"] = "Error";
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataincludeAttachmentFilter != null)
                {
                    inputEmailData["include_attachment_types"] = ExpressionConverter.ConvertO(inputEmailDataincludeAttachmentFilter);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataexcludeAttachmentFilter != null)
                {
                    inputEmailData["exclude_attachment_types"] = ExpressionConverter.ConvertO(inputEmailDataexcludeAttachmentFilter);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataviewportSize != null)
                {
                    if (inputEmailDataviewportSize != null)
                    {
                        inputEmailData["viewport_Size"] = ExpressionConverter.ConvertO(inputEmailDataviewportSize);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["viewport_Size"] = "Paper";
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatapaperSize != null)
                {
                    if (inputEmailDatapaperSize != null)
                    {
                        inputEmailData["paper_size"] = ExpressionConverter.ConvertO(inputEmailDatapaperSize);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["paper_size"] = "Letter";
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatapaperSizeCustom != null)
                {
                    inputEmailData["paper_size_custom"] = ExpressionConverter.ConvertO(inputEmailDatapaperSizeCustom);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatapageMargins != null)
                {
                    if (inputEmailDatapageMargins != null)
                    {
                        inputEmailData["page_margins"] = ExpressionConverter.ConvertO(inputEmailDatapageMargins);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["page_margins"] = "0.5,0.5,0.5,0.5";
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataattachmentErrors != null)
                {
                    inputEmailData["break_merge_on_error"] = ExpressionConverter.ConvertO(inputEmailDataattachmentErrors);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataminImageSize != null)
                {
                    if (inputEmailDataminImageSize != null)
                    {
                        inputEmailData["minimum_image_attachment_dimension"] = ExpressionConverter.ConvertO(inputEmailDataminImageSize);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["minimum_image_attachment_dimension"] = 150;
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataofflineMode != null)
                {
                    if (inputEmailDataofflineMode != null)
                    {
                        inputEmailData["enable_offline_mode"] = ExpressionConverter.ConvertO(inputEmailDataofflineMode);
                        inputEmailDatapropCount++;
                    }

                    inputEmailDatapropCount++;
                }
                else
                {
                    inputEmailData["enable_offline_mode"] = false;
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatastartPage != null)
                {
                    inputEmailData["start_page"] = ExpressionConverter.ConvertO(inputEmailDatastartPage);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataendPage != null)
                {
                    inputEmailData["end_page"] = ExpressionConverter.ConvertO(inputEmailDataendPage);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataconversionQuality != null)
                {
                    inputEmailData["quality"] = ExpressionConverter.ConvertO(inputEmailDataconversionQuality);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataoverrideSettings != null)
                {
                    inputEmailData["override_settings"] = ExpressionConverter.ConvertO(inputEmailDataoverrideSettings);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatafailOnError != null)
                {
                    if (inputEmailDatafailOnError != null)
                    {
                        inputEmailData["fail_on_error"] = ExpressionConverter.ConvertO(inputEmailDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertExcel))]
        public IBodyWorkflowAction<OperationResponse> ConvertExcel([WorkflowExpression] Func<string> inputExcelDatasourceFileName, [WorkflowExpression] Func<string> inputExcelDatasourceFileContent, [WorkflowExpression] Func<inputExcelDataoutputFormatInput> inputExcelDataoutputFormat, [WorkflowExpression] Func<inputExcelDatarangeInput> inputExcelDatarange = null, [WorkflowExpression] Func<bool> inputExcelDatarevealHiddenRows = null, [WorkflowExpression] Func<bool> inputExcelDatarevealHiddenColumns = null, [WorkflowExpression] Func<int> inputExcelDatafitToPagesWide = null, [WorkflowExpression] Func<int> inputExcelDatafitToPagesTall = null, [WorkflowExpression] Func<int> inputExcelDatastartPage = null, [WorkflowExpression] Func<int> inputExcelDataendPage = null, [WorkflowExpression] Func<inputExcelDataqualityInput> inputExcelDataquality = null, [WorkflowExpression] Func<string> inputExcelDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputExcelDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertExcel(WorkflowValue<string> inputExcelDatasourceFileName, WorkflowValue<string> inputExcelDatasourceFileContent, WorkflowValue<inputExcelDataoutputFormatInput> inputExcelDataoutputFormat, WorkflowValue<inputExcelDatarangeInput> inputExcelDatarange = null, WorkflowValue<bool> inputExcelDatarevealHiddenRows = null, WorkflowValue<bool> inputExcelDatarevealHiddenColumns = null, WorkflowValue<int> inputExcelDatafitToPagesWide = null, WorkflowValue<int> inputExcelDatafitToPagesTall = null, WorkflowValue<int> inputExcelDatastartPage = null, WorkflowValue<int> inputExcelDataendPage = null, WorkflowValue<inputExcelDataqualityInput> inputExcelDataquality = null, WorkflowValue<string> inputExcelDataoverrideSettings = null, WorkflowValue<bool> inputExcelDatafailOnError = null)
        {
            WorkflowValue.Validate(inputExcelDatasourceFileName, nameof(inputExcelDatasourceFileName), required: true);
            WorkflowValue.Validate(inputExcelDatasourceFileContent, nameof(inputExcelDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputExcelDataoutputFormat, nameof(inputExcelDataoutputFormat), required: true);
            WorkflowValue.Validate(inputExcelDatarange, nameof(inputExcelDatarange), required: false);
            WorkflowValue.Validate(inputExcelDatarevealHiddenRows, nameof(inputExcelDatarevealHiddenRows), required: false);
            WorkflowValue.Validate(inputExcelDatarevealHiddenColumns, nameof(inputExcelDatarevealHiddenColumns), required: false);
            WorkflowValue.Validate(inputExcelDatafitToPagesWide, nameof(inputExcelDatafitToPagesWide), required: false);
            WorkflowValue.Validate(inputExcelDatafitToPagesTall, nameof(inputExcelDatafitToPagesTall), required: false);
            WorkflowValue.Validate(inputExcelDatastartPage, nameof(inputExcelDatastartPage), required: false);
            WorkflowValue.Validate(inputExcelDataendPage, nameof(inputExcelDataendPage), required: false);
            WorkflowValue.Validate(inputExcelDataquality, nameof(inputExcelDataquality), required: false);
            WorkflowValue.Validate(inputExcelDataoverrideSettings, nameof(inputExcelDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputExcelDatafailOnError, nameof(inputExcelDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_excel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputExcelData = new JObject();
                var inputExcelDatapropCount = 0;
                inputExcelData["use_async_pattern"] = false;
                inputExcelDatapropCount++;
                inputExcelDatapropCount++;
                inputExcelData["source_file_name"] = ExpressionConverter.ConvertO(inputExcelDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputExcelData["sharepoint_file"] = sharepointFileObject;
                    inputExcelDatapropCount++;
                }

                inputExcelDatapropCount++;
                inputExcelData["source_file_content"] = ExpressionConverter.ConvertO(inputExcelDatasourceFileContent);
                inputExcelDatapropCount++;
                inputExcelData["output_format"] = ExpressionConverter.ConvertO(inputExcelDataoutputFormat);
                inputExcelData["copy_metadata"] = false;
                inputExcelDatapropCount++;
                if (inputExcelDatarange != null)
                {
                    inputExcelData["range"] = ExpressionConverter.ConvertO(inputExcelDatarange);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatarevealHiddenRows != null)
                {
                    if (inputExcelDatarevealHiddenRows != null)
                    {
                        inputExcelData["unhide_all_rows"] = ExpressionConverter.ConvertO(inputExcelDatarevealHiddenRows);
                        inputExcelDatapropCount++;
                    }

                    inputExcelDatapropCount++;
                }
                else
                {
                    inputExcelData["unhide_all_rows"] = false;
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatarevealHiddenColumns != null)
                {
                    if (inputExcelDatarevealHiddenColumns != null)
                    {
                        inputExcelData["unhide_all_columns"] = ExpressionConverter.ConvertO(inputExcelDatarevealHiddenColumns);
                        inputExcelDatapropCount++;
                    }

                    inputExcelDatapropCount++;
                }
                else
                {
                    inputExcelData["unhide_all_columns"] = false;
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatafitToPagesWide != null)
                {
                    inputExcelData["fit_to_pages_wide"] = ExpressionConverter.ConvertO(inputExcelDatafitToPagesWide);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatafitToPagesTall != null)
                {
                    inputExcelData["fit_to_pages_tall"] = ExpressionConverter.ConvertO(inputExcelDatafitToPagesTall);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatastartPage != null)
                {
                    inputExcelData["start_page"] = ExpressionConverter.ConvertO(inputExcelDatastartPage);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDataendPage != null)
                {
                    inputExcelData["end_page"] = ExpressionConverter.ConvertO(inputExcelDataendPage);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDataquality != null)
                {
                    inputExcelData["quality"] = ExpressionConverter.ConvertO(inputExcelDataquality);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDataoverrideSettings != null)
                {
                    inputExcelData["override_settings"] = ExpressionConverter.ConvertO(inputExcelDataoverrideSettings);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatafailOnError != null)
                {
                    if (inputExcelDatafailOnError != null)
                    {
                        inputExcelData["fail_on_error"] = ExpressionConverter.ConvertO(inputExcelDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertHtml))]
        public IBodyWorkflowAction<OperationResponse> ConvertHtml([WorkflowExpression] Func<string> inputDatasourceURLOrHTML, [WorkflowExpression] Func<inputDatapageOrientationInput> inputDatapageOrientation = null, [WorkflowExpression] Func<inputDatamediaTypeInput> inputDatamediaType = null, [WorkflowExpression] Func<inputDataauthenticationTypeInput> inputDataauthenticationType = null, [WorkflowExpression] Func<string> inputDatauserName = null, [WorkflowExpression] Func<string> inputDatapassword = null, [WorkflowExpression] Func<string> inputDataviewportSize = null, [WorkflowExpression] Func<int> inputDataconversionDelay = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertHtml(WorkflowValue<string> inputDatasourceURLOrHTML, WorkflowValue<inputDatapageOrientationInput> inputDatapageOrientation = null, WorkflowValue<inputDatamediaTypeInput> inputDatamediaType = null, WorkflowValue<inputDataauthenticationTypeInput> inputDataauthenticationType = null, WorkflowValue<string> inputDatauserName = null, WorkflowValue<string> inputDatapassword = null, WorkflowValue<string> inputDataviewportSize = null, WorkflowValue<int> inputDataconversionDelay = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceURLOrHTML, nameof(inputDatasourceURLOrHTML), required: true);
            WorkflowValue.Validate(inputDatapageOrientation, nameof(inputDatapageOrientation), required: false);
            WorkflowValue.Validate(inputDatamediaType, nameof(inputDatamediaType), required: false);
            WorkflowValue.Validate(inputDataauthenticationType, nameof(inputDataauthenticationType), required: false);
            WorkflowValue.Validate(inputDatauserName, nameof(inputDatauserName), required: false);
            WorkflowValue.Validate(inputDatapassword, nameof(inputDatapassword), required: false);
            WorkflowValue.Validate(inputDataviewportSize, nameof(inputDataviewportSize), required: false);
            WorkflowValue.Validate(inputDataconversionDelay, nameof(inputDataconversionDelay), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_url_or_html"] = ExpressionConverter.ConvertO(inputDatasourceURLOrHTML);
                if (inputDatapageOrientation != null)
                {
                    if (inputDatapageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatapageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Portrait";
                    inputDatapropCount++;
                }

                if (inputDatamediaType != null)
                {
                    if (inputDatamediaType != null)
                    {
                        inputData["media_type"] = ExpressionConverter.ConvertO(inputDatamediaType);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["media_type"] = "Screen";
                    inputDatapropCount++;
                }

                if (inputDataauthenticationType != null)
                {
                    if (inputDataauthenticationType != null)
                    {
                        inputData["authentication_type"] = ExpressionConverter.ConvertO(inputDataauthenticationType);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["authentication_type"] = "Anonymous";
                    inputDatapropCount++;
                }

                if (inputDatauserName != null)
                {
                    inputData["username"] = ExpressionConverter.ConvertO(inputDatauserName);
                    inputDatapropCount++;
                }

                if (inputDatapassword != null)
                {
                    inputData["password"] = ExpressionConverter.ConvertO(inputDatapassword);
                    inputDatapropCount++;
                }

                if (inputDataviewportSize != null)
                {
                    inputData["viewport_size"] = ExpressionConverter.ConvertO(inputDataviewportSize);
                    inputDatapropCount++;
                }

                if (inputDataconversionDelay != null)
                {
                    inputData["conversion_delay"] = ExpressionConverter.ConvertO(inputDataconversionDelay);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertInfopath))]
        public IBodyWorkflowAction<OperationResponse> ConvertInfopath([WorkflowExpression] Func<string> inputInfopathDatasourceFileName, [WorkflowExpression] Func<string> inputInfopathDatasourceFileContent, [WorkflowExpression] Func<inputInfopathDataoutputFormatInput> inputInfopathDataoutputFormat, [WorkflowExpression] Func<string> inputInfopathDatatemplateFileContent = null, [WorkflowExpression] Func<string> inputInfopathDataviewNames = null, [WorkflowExpression] Func<bool> inputInfopathDataincludeAttachment = null, [WorkflowExpression] Func<inputInfopathDataattachmentActionInput> inputInfopathDataattachmentAction = null, [WorkflowExpression] Func<inputInfopathDataunsupportedAttachmentActionInput> inputInfopathDataunsupportedAttachmentAction = null, [WorkflowExpression] Func<bool> inputInfopathDatabreakMergeOnError = null, [WorkflowExpression] Func<string> inputInfopathDataincludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputInfopathDataexcludeAttachmentFilter = null, [WorkflowExpression] Func<inputInfopathDatadefaultPaperSizeInput> inputInfopathDatadefaultPaperSize = null, [WorkflowExpression] Func<string> inputInfopathDatadefaultPaperSizeCustom = null, [WorkflowExpression] Func<inputInfopathDataforcePaperSizeInput> inputInfopathDataforcePaperSize = null, [WorkflowExpression] Func<string> inputInfopathDataforcePaperSizeCustom = null, [WorkflowExpression] Func<inputInfopathDatadefaultPageOrientationInput> inputInfopathDatadefaultPageOrientation = null, [WorkflowExpression] Func<inputInfopathDataforcePageOrientationInput> inputInfopathDataforcePageOrientation = null, [WorkflowExpression] Func<int> inputInfopathDatastartPage = null, [WorkflowExpression] Func<int> inputInfopathDataendPage = null, [WorkflowExpression] Func<inputInfopathDataconversionQualityInput> inputInfopathDataconversionQuality = null, [WorkflowExpression] Func<string> inputInfopathDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputInfopathDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertInfopath(WorkflowValue<string> inputInfopathDatasourceFileName, WorkflowValue<string> inputInfopathDatasourceFileContent, WorkflowValue<inputInfopathDataoutputFormatInput> inputInfopathDataoutputFormat, WorkflowValue<string> inputInfopathDatatemplateFileContent = null, WorkflowValue<string> inputInfopathDataviewNames = null, WorkflowValue<bool> inputInfopathDataincludeAttachment = null, WorkflowValue<inputInfopathDataattachmentActionInput> inputInfopathDataattachmentAction = null, WorkflowValue<inputInfopathDataunsupportedAttachmentActionInput> inputInfopathDataunsupportedAttachmentAction = null, WorkflowValue<bool> inputInfopathDatabreakMergeOnError = null, WorkflowValue<string> inputInfopathDataincludeAttachmentFilter = null, WorkflowValue<string> inputInfopathDataexcludeAttachmentFilter = null, WorkflowValue<inputInfopathDatadefaultPaperSizeInput> inputInfopathDatadefaultPaperSize = null, WorkflowValue<string> inputInfopathDatadefaultPaperSizeCustom = null, WorkflowValue<inputInfopathDataforcePaperSizeInput> inputInfopathDataforcePaperSize = null, WorkflowValue<string> inputInfopathDataforcePaperSizeCustom = null, WorkflowValue<inputInfopathDatadefaultPageOrientationInput> inputInfopathDatadefaultPageOrientation = null, WorkflowValue<inputInfopathDataforcePageOrientationInput> inputInfopathDataforcePageOrientation = null, WorkflowValue<int> inputInfopathDatastartPage = null, WorkflowValue<int> inputInfopathDataendPage = null, WorkflowValue<inputInfopathDataconversionQualityInput> inputInfopathDataconversionQuality = null, WorkflowValue<string> inputInfopathDataoverrideSettings = null, WorkflowValue<bool> inputInfopathDatafailOnError = null)
        {
            WorkflowValue.Validate(inputInfopathDatasourceFileName, nameof(inputInfopathDatasourceFileName), required: true);
            WorkflowValue.Validate(inputInfopathDatasourceFileContent, nameof(inputInfopathDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputInfopathDataoutputFormat, nameof(inputInfopathDataoutputFormat), required: true);
            WorkflowValue.Validate(inputInfopathDatatemplateFileContent, nameof(inputInfopathDatatemplateFileContent), required: false);
            WorkflowValue.Validate(inputInfopathDataviewNames, nameof(inputInfopathDataviewNames), required: false);
            WorkflowValue.Validate(inputInfopathDataincludeAttachment, nameof(inputInfopathDataincludeAttachment), required: false);
            WorkflowValue.Validate(inputInfopathDataattachmentAction, nameof(inputInfopathDataattachmentAction), required: false);
            WorkflowValue.Validate(inputInfopathDataunsupportedAttachmentAction, nameof(inputInfopathDataunsupportedAttachmentAction), required: false);
            WorkflowValue.Validate(inputInfopathDatabreakMergeOnError, nameof(inputInfopathDatabreakMergeOnError), required: false);
            WorkflowValue.Validate(inputInfopathDataincludeAttachmentFilter, nameof(inputInfopathDataincludeAttachmentFilter), required: false);
            WorkflowValue.Validate(inputInfopathDataexcludeAttachmentFilter, nameof(inputInfopathDataexcludeAttachmentFilter), required: false);
            WorkflowValue.Validate(inputInfopathDatadefaultPaperSize, nameof(inputInfopathDatadefaultPaperSize), required: false);
            WorkflowValue.Validate(inputInfopathDatadefaultPaperSizeCustom, nameof(inputInfopathDatadefaultPaperSizeCustom), required: false);
            WorkflowValue.Validate(inputInfopathDataforcePaperSize, nameof(inputInfopathDataforcePaperSize), required: false);
            WorkflowValue.Validate(inputInfopathDataforcePaperSizeCustom, nameof(inputInfopathDataforcePaperSizeCustom), required: false);
            WorkflowValue.Validate(inputInfopathDatadefaultPageOrientation, nameof(inputInfopathDatadefaultPageOrientation), required: false);
            WorkflowValue.Validate(inputInfopathDataforcePageOrientation, nameof(inputInfopathDataforcePageOrientation), required: false);
            WorkflowValue.Validate(inputInfopathDatastartPage, nameof(inputInfopathDatastartPage), required: false);
            WorkflowValue.Validate(inputInfopathDataendPage, nameof(inputInfopathDataendPage), required: false);
            WorkflowValue.Validate(inputInfopathDataconversionQuality, nameof(inputInfopathDataconversionQuality), required: false);
            WorkflowValue.Validate(inputInfopathDataoverrideSettings, nameof(inputInfopathDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputInfopathDatafailOnError, nameof(inputInfopathDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_infopath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputInfopathData = new JObject();
                var inputInfopathDatapropCount = 0;
                inputInfopathData["use_async_pattern"] = false;
                inputInfopathDatapropCount++;
                inputInfopathDatapropCount++;
                inputInfopathData["source_file_name"] = ExpressionConverter.ConvertO(inputInfopathDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputInfopathData["sharepoint_file"] = sharepointFileObject;
                    inputInfopathDatapropCount++;
                }

                inputInfopathDatapropCount++;
                inputInfopathData["source_file_content"] = ExpressionConverter.ConvertO(inputInfopathDatasourceFileContent);
                inputInfopathDatapropCount++;
                inputInfopathData["output_format"] = ExpressionConverter.ConvertO(inputInfopathDataoutputFormat);
                inputInfopathData["copy_metadata"] = false;
                inputInfopathDatapropCount++;
                if (inputInfopathDatatemplateFileContent != null)
                {
                    inputInfopathData["template_file_content"] = ExpressionConverter.ConvertO(inputInfopathDatatemplateFileContent);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataviewNames != null)
                {
                    inputInfopathData["views_to_convert"] = ExpressionConverter.ConvertO(inputInfopathDataviewNames);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataincludeAttachment != null)
                {
                    if (inputInfopathDataincludeAttachment != null)
                    {
                        inputInfopathData["convert_attachments"] = ExpressionConverter.ConvertO(inputInfopathDataincludeAttachment);
                        inputInfopathDatapropCount++;
                    }

                    inputInfopathDatapropCount++;
                }
                else
                {
                    inputInfopathData["convert_attachments"] = true;
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataattachmentAction != null)
                {
                    inputInfopathData["attachment_merge_mode"] = ExpressionConverter.ConvertO(inputInfopathDataattachmentAction);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataunsupportedAttachmentAction != null)
                {
                    inputInfopathData["unsupported_attachment_behaviour"] = ExpressionConverter.ConvertO(inputInfopathDataunsupportedAttachmentAction);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatabreakMergeOnError != null)
                {
                    inputInfopathData["break_merge_on_error"] = ExpressionConverter.ConvertO(inputInfopathDatabreakMergeOnError);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataincludeAttachmentFilter != null)
                {
                    inputInfopathData["include_attachment_types"] = ExpressionConverter.ConvertO(inputInfopathDataincludeAttachmentFilter);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataexcludeAttachmentFilter != null)
                {
                    inputInfopathData["exclude_attachment_types"] = ExpressionConverter.ConvertO(inputInfopathDataexcludeAttachmentFilter);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatadefaultPaperSize != null)
                {
                    inputInfopathData["default_paper_size"] = ExpressionConverter.ConvertO(inputInfopathDatadefaultPaperSize);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatadefaultPaperSizeCustom != null)
                {
                    inputInfopathData["default_paper_size_custom"] = ExpressionConverter.ConvertO(inputInfopathDatadefaultPaperSizeCustom);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataforcePaperSize != null)
                {
                    inputInfopathData["force_paper_size"] = ExpressionConverter.ConvertO(inputInfopathDataforcePaperSize);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataforcePaperSizeCustom != null)
                {
                    inputInfopathData["force_paper_size_custom"] = ExpressionConverter.ConvertO(inputInfopathDataforcePaperSizeCustom);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatadefaultPageOrientation != null)
                {
                    if (inputInfopathDatadefaultPageOrientation != null)
                    {
                        inputInfopathData["default_page_orientation"] = ExpressionConverter.ConvertO(inputInfopathDatadefaultPageOrientation);
                        inputInfopathDatapropCount++;
                    }

                    inputInfopathDatapropCount++;
                }
                else
                {
                    inputInfopathData["default_page_orientation"] = "Default";
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataforcePageOrientation != null)
                {
                    inputInfopathData["force_page_orientation"] = ExpressionConverter.ConvertO(inputInfopathDataforcePageOrientation);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatastartPage != null)
                {
                    inputInfopathData["start_page"] = ExpressionConverter.ConvertO(inputInfopathDatastartPage);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataendPage != null)
                {
                    inputInfopathData["end_page"] = ExpressionConverter.ConvertO(inputInfopathDataendPage);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataconversionQuality != null)
                {
                    inputInfopathData["quality"] = ExpressionConverter.ConvertO(inputInfopathDataconversionQuality);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataoverrideSettings != null)
                {
                    inputInfopathData["override_settings"] = ExpressionConverter.ConvertO(inputInfopathDataoverrideSettings);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatafailOnError != null)
                {
                    if (inputInfopathDatafailOnError != null)
                    {
                        inputInfopathData["fail_on_error"] = ExpressionConverter.ConvertO(inputInfopathDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertPdfa))]
        public IBodyWorkflowAction<OperationResponse> ConvertPdfa([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<inputPdfDatapDFProfileInput> inputPdfDatapDFProfile, [WorkflowExpression] Func<string> inputPdfDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertPdfa(WorkflowValue<string> inputPdfDatasourceFileName, WorkflowValue<string> inputPdfDatasourceFileContent, WorkflowValue<inputPdfDatapDFProfileInput> inputPdfDatapDFProfile, WorkflowValue<string> inputPdfDataoverrideSettings = null, WorkflowValue<bool> inputPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPdfDatapDFProfile, nameof(inputPdfDatapDFProfile), required: true);
            WorkflowValue.Validate(inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_pdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                inputPdfData["copy_metadata"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["pdf_profile"] = ExpressionConverter.ConvertO(inputPdfDatapDFProfile);
                if (inputPdfDataoverrideSettings != null)
                {
                    inputPdfData["override_settings"] = ExpressionConverter.ConvertO(inputPdfDataoverrideSettings);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertPowerpoint))]
        public IBodyWorkflowAction<OperationResponse> ConvertPowerpoint([WorkflowExpression] Func<string> inputPowerpointDatasourceFileName, [WorkflowExpression] Func<string> inputPowerpointDatasourceFileContent, [WorkflowExpression] Func<inputPowerpointDataoutputFormatInput> inputPowerpointDataoutputFormat, [WorkflowExpression] Func<inputPowerpointDatarangeInput> inputPowerpointDatarange = null, [WorkflowExpression] Func<inputPowerpointDataprintLayoutHandoutsInput> inputPowerpointDataprintLayoutHandouts = null, [WorkflowExpression] Func<bool> inputPowerpointDataframeSlides = null, [WorkflowExpression] Func<int> inputPowerpointDatastartPage = null, [WorkflowExpression] Func<int> inputPowerpointDataendPage = null, [WorkflowExpression] Func<inputPowerpointDataqualityInput> inputPowerpointDataquality = null, [WorkflowExpression] Func<string> inputPowerpointDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPowerpointDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertPowerpoint(WorkflowValue<string> inputPowerpointDatasourceFileName, WorkflowValue<string> inputPowerpointDatasourceFileContent, WorkflowValue<inputPowerpointDataoutputFormatInput> inputPowerpointDataoutputFormat, WorkflowValue<inputPowerpointDatarangeInput> inputPowerpointDatarange = null, WorkflowValue<inputPowerpointDataprintLayoutHandoutsInput> inputPowerpointDataprintLayoutHandouts = null, WorkflowValue<bool> inputPowerpointDataframeSlides = null, WorkflowValue<int> inputPowerpointDatastartPage = null, WorkflowValue<int> inputPowerpointDataendPage = null, WorkflowValue<inputPowerpointDataqualityInput> inputPowerpointDataquality = null, WorkflowValue<string> inputPowerpointDataoverrideSettings = null, WorkflowValue<bool> inputPowerpointDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPowerpointDatasourceFileName, nameof(inputPowerpointDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPowerpointDatasourceFileContent, nameof(inputPowerpointDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPowerpointDataoutputFormat, nameof(inputPowerpointDataoutputFormat), required: true);
            WorkflowValue.Validate(inputPowerpointDatarange, nameof(inputPowerpointDatarange), required: false);
            WorkflowValue.Validate(inputPowerpointDataprintLayoutHandouts, nameof(inputPowerpointDataprintLayoutHandouts), required: false);
            WorkflowValue.Validate(inputPowerpointDataframeSlides, nameof(inputPowerpointDataframeSlides), required: false);
            WorkflowValue.Validate(inputPowerpointDatastartPage, nameof(inputPowerpointDatastartPage), required: false);
            WorkflowValue.Validate(inputPowerpointDataendPage, nameof(inputPowerpointDataendPage), required: false);
            WorkflowValue.Validate(inputPowerpointDataquality, nameof(inputPowerpointDataquality), required: false);
            WorkflowValue.Validate(inputPowerpointDataoverrideSettings, nameof(inputPowerpointDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputPowerpointDatafailOnError, nameof(inputPowerpointDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPowerpointData = new JObject();
                var inputPowerpointDatapropCount = 0;
                inputPowerpointData["use_async_pattern"] = false;
                inputPowerpointDatapropCount++;
                inputPowerpointDatapropCount++;
                inputPowerpointData["source_file_name"] = ExpressionConverter.ConvertO(inputPowerpointDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPowerpointData["sharepoint_file"] = sharepointFileObject;
                    inputPowerpointDatapropCount++;
                }

                inputPowerpointDatapropCount++;
                inputPowerpointData["source_file_content"] = ExpressionConverter.ConvertO(inputPowerpointDatasourceFileContent);
                inputPowerpointDatapropCount++;
                inputPowerpointData["output_format"] = ExpressionConverter.ConvertO(inputPowerpointDataoutputFormat);
                inputPowerpointData["copy_metadata"] = false;
                inputPowerpointDatapropCount++;
                if (inputPowerpointDatarange != null)
                {
                    inputPowerpointData["range"] = ExpressionConverter.ConvertO(inputPowerpointDatarange);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataprintLayoutHandouts != null)
                {
                    if (inputPowerpointDataprintLayoutHandouts != null)
                    {
                        inputPowerpointData["print_output_type"] = ExpressionConverter.ConvertO(inputPowerpointDataprintLayoutHandouts);
                        inputPowerpointDatapropCount++;
                    }

                    inputPowerpointDatapropCount++;
                }
                else
                {
                    inputPowerpointData["print_output_type"] = "Slides";
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataframeSlides != null)
                {
                    if (inputPowerpointDataframeSlides != null)
                    {
                        inputPowerpointData["frame_slides"] = ExpressionConverter.ConvertO(inputPowerpointDataframeSlides);
                        inputPowerpointDatapropCount++;
                    }

                    inputPowerpointDatapropCount++;
                }
                else
                {
                    inputPowerpointData["frame_slides"] = true;
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDatastartPage != null)
                {
                    inputPowerpointData["start_page"] = ExpressionConverter.ConvertO(inputPowerpointDatastartPage);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataendPage != null)
                {
                    inputPowerpointData["end_page"] = ExpressionConverter.ConvertO(inputPowerpointDataendPage);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataquality != null)
                {
                    inputPowerpointData["quality"] = ExpressionConverter.ConvertO(inputPowerpointDataquality);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataoverrideSettings != null)
                {
                    inputPowerpointData["override_settings"] = ExpressionConverter.ConvertO(inputPowerpointDataoverrideSettings);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDatafailOnError != null)
                {
                    if (inputPowerpointDatafailOnError != null)
                    {
                        inputPowerpointData["fail_on_error"] = ExpressionConverter.ConvertO(inputPowerpointDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertVisio))]
        public IBodyWorkflowAction<OperationResponse> ConvertVisio([WorkflowExpression] Func<string> inputVisioDatasourceFileName, [WorkflowExpression] Func<string> inputVisioDatasourceFileContent, [WorkflowExpression] Func<inputVisioDataoutputFormatInput> inputVisioDataoutputFormat, [WorkflowExpression] Func<inputVisioDatarangeInput> inputVisioDatarange = null, [WorkflowExpression] Func<int> inputVisioDatastartPage = null, [WorkflowExpression] Func<int> inputVisioDataendPage = null, [WorkflowExpression] Func<inputVisioDataqualityInput> inputVisioDataquality = null, [WorkflowExpression] Func<string> inputVisioDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputVisioDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertVisio(WorkflowValue<string> inputVisioDatasourceFileName, WorkflowValue<string> inputVisioDatasourceFileContent, WorkflowValue<inputVisioDataoutputFormatInput> inputVisioDataoutputFormat, WorkflowValue<inputVisioDatarangeInput> inputVisioDatarange = null, WorkflowValue<int> inputVisioDatastartPage = null, WorkflowValue<int> inputVisioDataendPage = null, WorkflowValue<inputVisioDataqualityInput> inputVisioDataquality = null, WorkflowValue<string> inputVisioDataoverrideSettings = null, WorkflowValue<bool> inputVisioDatafailOnError = null)
        {
            WorkflowValue.Validate(inputVisioDatasourceFileName, nameof(inputVisioDatasourceFileName), required: true);
            WorkflowValue.Validate(inputVisioDatasourceFileContent, nameof(inputVisioDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputVisioDataoutputFormat, nameof(inputVisioDataoutputFormat), required: true);
            WorkflowValue.Validate(inputVisioDatarange, nameof(inputVisioDatarange), required: false);
            WorkflowValue.Validate(inputVisioDatastartPage, nameof(inputVisioDatastartPage), required: false);
            WorkflowValue.Validate(inputVisioDataendPage, nameof(inputVisioDataendPage), required: false);
            WorkflowValue.Validate(inputVisioDataquality, nameof(inputVisioDataquality), required: false);
            WorkflowValue.Validate(inputVisioDataoverrideSettings, nameof(inputVisioDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputVisioDatafailOnError, nameof(inputVisioDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_visio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputVisioData = new JObject();
                var inputVisioDatapropCount = 0;
                inputVisioData["use_async_pattern"] = false;
                inputVisioDatapropCount++;
                inputVisioDatapropCount++;
                inputVisioData["source_file_name"] = ExpressionConverter.ConvertO(inputVisioDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputVisioData["sharepoint_file"] = sharepointFileObject;
                    inputVisioDatapropCount++;
                }

                inputVisioDatapropCount++;
                inputVisioData["source_file_content"] = ExpressionConverter.ConvertO(inputVisioDatasourceFileContent);
                inputVisioDatapropCount++;
                inputVisioData["output_format"] = ExpressionConverter.ConvertO(inputVisioDataoutputFormat);
                inputVisioData["copy_metadata"] = false;
                inputVisioDatapropCount++;
                if (inputVisioDatarange != null)
                {
                    inputVisioData["range"] = ExpressionConverter.ConvertO(inputVisioDatarange);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDatastartPage != null)
                {
                    inputVisioData["start_page"] = ExpressionConverter.ConvertO(inputVisioDatastartPage);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDataendPage != null)
                {
                    inputVisioData["end_page"] = ExpressionConverter.ConvertO(inputVisioDataendPage);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDataquality != null)
                {
                    inputVisioData["quality"] = ExpressionConverter.ConvertO(inputVisioDataquality);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDataoverrideSettings != null)
                {
                    inputVisioData["override_settings"] = ExpressionConverter.ConvertO(inputVisioDataoverrideSettings);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDatafailOnError != null)
                {
                    if (inputVisioDatafailOnError != null)
                    {
                        inputVisioData["fail_on_error"] = ExpressionConverter.ConvertO(inputVisioDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertWord))]
        public IBodyWorkflowAction<OperationResponse> ConvertWord([WorkflowExpression] Func<string> inputWordDatasourceFileName, [WorkflowExpression] Func<string> inputWordDatasourceFileContent, [WorkflowExpression] Func<inputWordDataoutputFormatInput> inputWordDataoutputFormat, [WorkflowExpression] Func<inputWordDatadisplayForReviewInput> inputWordDatadisplayForReview = null, [WorkflowExpression] Func<inputWordDatareviewMarkupModeInput> inputWordDatareviewMarkupMode = null, [WorkflowExpression] Func<inputWordDatagenerateBookmarksInput> inputWordDatagenerateBookmarks = null, [WorkflowExpression] Func<int> inputWordDatastartPage = null, [WorkflowExpression] Func<int> inputWordDataendPage = null, [WorkflowExpression] Func<inputWordDataqualityInput> inputWordDataquality = null, [WorkflowExpression] Func<string> inputWordDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputWordDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertWord(WorkflowValue<string> inputWordDatasourceFileName, WorkflowValue<string> inputWordDatasourceFileContent, WorkflowValue<inputWordDataoutputFormatInput> inputWordDataoutputFormat, WorkflowValue<inputWordDatadisplayForReviewInput> inputWordDatadisplayForReview = null, WorkflowValue<inputWordDatareviewMarkupModeInput> inputWordDatareviewMarkupMode = null, WorkflowValue<inputWordDatagenerateBookmarksInput> inputWordDatagenerateBookmarks = null, WorkflowValue<int> inputWordDatastartPage = null, WorkflowValue<int> inputWordDataendPage = null, WorkflowValue<inputWordDataqualityInput> inputWordDataquality = null, WorkflowValue<string> inputWordDataoverrideSettings = null, WorkflowValue<bool> inputWordDatafailOnError = null)
        {
            WorkflowValue.Validate(inputWordDatasourceFileName, nameof(inputWordDatasourceFileName), required: true);
            WorkflowValue.Validate(inputWordDatasourceFileContent, nameof(inputWordDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputWordDataoutputFormat, nameof(inputWordDataoutputFormat), required: true);
            WorkflowValue.Validate(inputWordDatadisplayForReview, nameof(inputWordDatadisplayForReview), required: false);
            WorkflowValue.Validate(inputWordDatareviewMarkupMode, nameof(inputWordDatareviewMarkupMode), required: false);
            WorkflowValue.Validate(inputWordDatagenerateBookmarks, nameof(inputWordDatagenerateBookmarks), required: false);
            WorkflowValue.Validate(inputWordDatastartPage, nameof(inputWordDatastartPage), required: false);
            WorkflowValue.Validate(inputWordDataendPage, nameof(inputWordDataendPage), required: false);
            WorkflowValue.Validate(inputWordDataquality, nameof(inputWordDataquality), required: false);
            WorkflowValue.Validate(inputWordDataoverrideSettings, nameof(inputWordDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputWordDatafailOnError, nameof(inputWordDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/convert_word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputWordData = new JObject();
                var inputWordDatapropCount = 0;
                inputWordData["use_async_pattern"] = false;
                inputWordDatapropCount++;
                inputWordDatapropCount++;
                inputWordData["source_file_name"] = ExpressionConverter.ConvertO(inputWordDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputWordData["sharepoint_file"] = sharepointFileObject;
                    inputWordDatapropCount++;
                }

                inputWordDatapropCount++;
                inputWordData["source_file_content"] = ExpressionConverter.ConvertO(inputWordDatasourceFileContent);
                inputWordDatapropCount++;
                inputWordData["output_format"] = ExpressionConverter.ConvertO(inputWordDataoutputFormat);
                inputWordData["copy_metadata"] = false;
                inputWordDatapropCount++;
                if (inputWordDatadisplayForReview != null)
                {
                    if (inputWordDatadisplayForReview != null)
                    {
                        inputWordData["revisions_and_comments_display_mode"] = ExpressionConverter.ConvertO(inputWordDatadisplayForReview);
                        inputWordDatapropCount++;
                    }

                    inputWordDatapropCount++;
                }
                else
                {
                    inputWordData["revisions_and_comments_display_mode"] = "Final";
                    inputWordDatapropCount++;
                }

                if (inputWordDatareviewMarkupMode != null)
                {
                    if (inputWordDatareviewMarkupMode != null)
                    {
                        inputWordData["revisions_and_comments_markup_mode"] = ExpressionConverter.ConvertO(inputWordDatareviewMarkupMode);
                        inputWordDatapropCount++;
                    }

                    inputWordDatapropCount++;
                }
                else
                {
                    inputWordData["revisions_and_comments_markup_mode"] = "InLine";
                    inputWordDatapropCount++;
                }

                if (inputWordDatagenerateBookmarks != null)
                {
                    inputWordData["generate_bookmarks"] = ExpressionConverter.ConvertO(inputWordDatagenerateBookmarks);
                    inputWordDatapropCount++;
                }

                if (inputWordDatastartPage != null)
                {
                    inputWordData["start_page"] = ExpressionConverter.ConvertO(inputWordDatastartPage);
                    inputWordDatapropCount++;
                }

                if (inputWordDataendPage != null)
                {
                    inputWordData["end_page"] = ExpressionConverter.ConvertO(inputWordDataendPage);
                    inputWordDatapropCount++;
                }

                if (inputWordDataquality != null)
                {
                    inputWordData["quality"] = ExpressionConverter.ConvertO(inputWordDataquality);
                    inputWordDatapropCount++;
                }

                if (inputWordDataoverrideSettings != null)
                {
                    inputWordData["override_settings"] = ExpressionConverter.ConvertO(inputWordDataoverrideSettings);
                    inputWordDatapropCount++;
                }

                if (inputWordDatafailOnError != null)
                {
                    if (inputWordDatafailOnError != null)
                    {
                        inputWordData["fail_on_error"] = ExpressionConverter.ConvertO(inputWordDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildCopyMetadata))]
        public IBodyWorkflowAction<OperationResponseCommon> CopyMetadata([WorkflowExpression] Func<string> inputDatasiteUrl, [WorkflowExpression] Func<string> inputDatasourceFileUrl, [WorkflowExpression] Func<string> inputDatadestinationFilePath, [WorkflowExpression] Func<string> inputDatauserName = null, [WorkflowExpression] Func<string> inputDatapassword = null, [WorkflowExpression] Func<string> inputDatafieldsToCopy = null, [WorkflowExpression] Func<string> inputDatadestinationContentType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponseCommon> __BuildCopyMetadata(WorkflowValue<string> inputDatasiteUrl, WorkflowValue<string> inputDatasourceFileUrl, WorkflowValue<string> inputDatadestinationFilePath, WorkflowValue<string> inputDatauserName = null, WorkflowValue<string> inputDatapassword = null, WorkflowValue<string> inputDatafieldsToCopy = null, WorkflowValue<string> inputDatadestinationContentType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasiteUrl, nameof(inputDatasiteUrl), required: true);
            WorkflowValue.Validate(inputDatasourceFileUrl, nameof(inputDatasourceFileUrl), required: true);
            WorkflowValue.Validate(inputDatadestinationFilePath, nameof(inputDatadestinationFilePath), required: true);
            WorkflowValue.Validate(inputDatauserName, nameof(inputDatauserName), required: false);
            WorkflowValue.Validate(inputDatapassword, nameof(inputDatapassword), required: false);
            WorkflowValue.Validate(inputDatafieldsToCopy, nameof(inputDatafieldsToCopy), required: false);
            WorkflowValue.Validate(inputDatadestinationContentType, nameof(inputDatadestinationContentType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponseCommon>(() =>
            {
                var apiCallPath = "/v1/operations/copy_metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputDatapropCount++;
                inputData["site_url"] = ExpressionConverter.ConvertO(inputDatasiteUrl);
                inputDatapropCount++;
                inputData["source_file_url"] = ExpressionConverter.ConvertO(inputDatasourceFileUrl);
                inputDatapropCount++;
                inputData["destination_file_url"] = ExpressionConverter.ConvertO(inputDatadestinationFilePath);
                if (inputDatauserName != null)
                {
                    inputData["username"] = ExpressionConverter.ConvertO(inputDatauserName);
                    inputDatapropCount++;
                }

                if (inputDatapassword != null)
                {
                    inputData["password"] = ExpressionConverter.ConvertO(inputDatapassword);
                    inputDatapropCount++;
                }

                if (inputDatafieldsToCopy != null)
                {
                    inputData["copy_fields"] = ExpressionConverter.ConvertO(inputDatafieldsToCopy);
                    inputDatapropCount++;
                }

                if (inputDatadestinationContentType != null)
                {
                    inputData["content_type"] = ExpressionConverter.ConvertO(inputDatadestinationContentType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildEllipseWatermark))]
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatafillColor = null, [WorkflowExpression] Func<string> inputDatalineColor = null, [WorkflowExpression] Func<string> inputDatalineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildEllipseWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatafillColor = null, WorkflowValue<string> inputDatalineColor = null, WorkflowValue<string> inputDatalineWidth = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatafillColor, nameof(inputDatafillColor), required: false);
            WorkflowValue.Validate(inputDatalineColor, nameof(inputDatalineColor), required: false);
            WorkflowValue.Validate(inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/ellipse_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatafillColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatafillColor);
                    inputDatapropCount++;
                }

                if (inputDatalineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatalineColor);
                    inputDatapropCount++;
                }

                if (inputDatalineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(inputDatalineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildExportFormData))]
        public IBodyWorkflowAction<OperationResponse> ExportFormData([WorkflowExpression] Func<string> inputFromPdfDatasourceFileName, [WorkflowExpression] Func<string> inputFromPdfDatasourceFileContent, [WorkflowExpression] Func<inputFromPdfDataoutputDataFormatInput> inputFromPdfDataoutputDataFormat, [WorkflowExpression] Func<bool> inputFromPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildExportFormData(WorkflowValue<string> inputFromPdfDatasourceFileName, WorkflowValue<string> inputFromPdfDatasourceFileContent, WorkflowValue<inputFromPdfDataoutputDataFormatInput> inputFromPdfDataoutputDataFormat, WorkflowValue<bool> inputFromPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputFromPdfDatasourceFileName, nameof(inputFromPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputFromPdfDatasourceFileContent, nameof(inputFromPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputFromPdfDataoutputDataFormat, nameof(inputFromPdfDataoutputDataFormat), required: true);
            WorkflowValue.Validate(inputFromPdfDatafailOnError, nameof(inputFromPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/export_form_data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputFromPdfData = new JObject();
                var inputFromPdfDatapropCount = 0;
                inputFromPdfData["use_async_pattern"] = false;
                inputFromPdfDatapropCount++;
                inputFromPdfDatapropCount++;
                inputFromPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputFromPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputFromPdfData["sharepoint_file"] = sharepointFileObject;
                    inputFromPdfDatapropCount++;
                }

                inputFromPdfDatapropCount++;
                inputFromPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputFromPdfDatasourceFileContent);
                inputFromPdfDatapropCount++;
                inputFromPdfData["output_format"] = ExpressionConverter.ConvertO(inputFromPdfDataoutputDataFormat);
                inputFromPdfData["copy_metadata"] = false;
                inputFromPdfDatapropCount++;
                if (inputFromPdfDatafailOnError != null)
                {
                    if (inputFromPdfDatafailOnError != null)
                    {
                        inputFromPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputFromPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractText))]
        public IBodyWorkflowAction<OperationResponse> ExtractText([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildExtractText(WorkflowValue<string> inputPdfDatasourceFileName, WorkflowValue<string> inputPdfDatasourceFileContent, WorkflowValue<string> inputPdfDatapageRange = null, WorkflowValue<bool> inputPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            WorkflowValue.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/extract_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                if (inputPdfDatapageRange != null)
                {
                    if (inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildImageWatermark))]
        public IBodyWorkflowAction<OperationResponse> ImageWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDataimage, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildImageWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDataimage, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatawatermarkBackgroundColor = null, WorkflowValue<string> inputDatawatermarkOutlineColor = null, WorkflowValue<string> inputDatawatermarkOutlineWidth = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDataimage, nameof(inputDataimage), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/image_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["image_file"] = ExpressionConverter.ConvertO(inputDataimage);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildImportFormData))]
        public IBodyWorkflowAction<OperationResponse> ImportFormData([WorkflowExpression] Func<string> inputXmlDatasourceFileName, [WorkflowExpression] Func<string> inputXmlDatasourceFileContent, [WorkflowExpression] Func<string> inputXmlDatapDFFormFileContent = null, [WorkflowExpression] Func<string> inputXmlDatapDFFormURL = null, [WorkflowExpression] Func<string> inputXmlDatausername = null, [WorkflowExpression] Func<string> inputXmlDatadomain = null, [WorkflowExpression] Func<string> inputXmlDatapassword = null, [WorkflowExpression] Func<inputXmlDataflattenInput> inputXmlDataflatten = null, [WorkflowExpression] Func<inputXmlDatareadOnlyInput> inputXmlDatareadOnly = null, [WorkflowExpression] Func<string> inputXmlDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputXmlDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildImportFormData(WorkflowValue<string> inputXmlDatasourceFileName, WorkflowValue<string> inputXmlDatasourceFileContent, WorkflowValue<string> inputXmlDatapDFFormFileContent = null, WorkflowValue<string> inputXmlDatapDFFormURL = null, WorkflowValue<string> inputXmlDatausername = null, WorkflowValue<string> inputXmlDatadomain = null, WorkflowValue<string> inputXmlDatapassword = null, WorkflowValue<inputXmlDataflattenInput> inputXmlDataflatten = null, WorkflowValue<inputXmlDatareadOnlyInput> inputXmlDatareadOnly = null, WorkflowValue<string> inputXmlDataoverrideSettings = null, WorkflowValue<bool> inputXmlDatafailOnError = null)
        {
            WorkflowValue.Validate(inputXmlDatasourceFileName, nameof(inputXmlDatasourceFileName), required: true);
            WorkflowValue.Validate(inputXmlDatasourceFileContent, nameof(inputXmlDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputXmlDatapDFFormFileContent, nameof(inputXmlDatapDFFormFileContent), required: false);
            WorkflowValue.Validate(inputXmlDatapDFFormURL, nameof(inputXmlDatapDFFormURL), required: false);
            WorkflowValue.Validate(inputXmlDatausername, nameof(inputXmlDatausername), required: false);
            WorkflowValue.Validate(inputXmlDatadomain, nameof(inputXmlDatadomain), required: false);
            WorkflowValue.Validate(inputXmlDatapassword, nameof(inputXmlDatapassword), required: false);
            WorkflowValue.Validate(inputXmlDataflatten, nameof(inputXmlDataflatten), required: false);
            WorkflowValue.Validate(inputXmlDatareadOnly, nameof(inputXmlDatareadOnly), required: false);
            WorkflowValue.Validate(inputXmlDataoverrideSettings, nameof(inputXmlDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputXmlDatafailOnError, nameof(inputXmlDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/import_form_data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputXmlData = new JObject();
                var inputXmlDatapropCount = 0;
                inputXmlData["use_async_pattern"] = false;
                inputXmlDatapropCount++;
                inputXmlDatapropCount++;
                inputXmlData["source_file_name"] = ExpressionConverter.ConvertO(inputXmlDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputXmlData["sharepoint_file"] = sharepointFileObject;
                    inputXmlDatapropCount++;
                }

                inputXmlDatapropCount++;
                inputXmlData["source_file_content"] = ExpressionConverter.ConvertO(inputXmlDatasourceFileContent);
                inputXmlData["copy_metadata"] = false;
                inputXmlDatapropCount++;
                if (inputXmlDatapDFFormFileContent != null)
                {
                    inputXmlData["pdf_template_file_content"] = ExpressionConverter.ConvertO(inputXmlDatapDFFormFileContent);
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatapDFFormURL != null)
                {
                    inputXmlData["pdf_template_url"] = ExpressionConverter.ConvertO(inputXmlDatapDFFormURL);
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatausername != null)
                {
                    inputXmlData["pdf_template_username"] = ExpressionConverter.ConvertO(inputXmlDatausername);
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatadomain != null)
                {
                    inputXmlData["pdf_template_domain"] = ExpressionConverter.ConvertO(inputXmlDatadomain);
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatapassword != null)
                {
                    inputXmlData["pdf_template_password"] = ExpressionConverter.ConvertO(inputXmlDatapassword);
                    inputXmlDatapropCount++;
                }

                if (inputXmlDataflatten != null)
                {
                    if (inputXmlDataflatten != null)
                    {
                        inputXmlData["flatten"] = ExpressionConverter.ConvertO(inputXmlDataflatten);
                        inputXmlDatapropCount++;
                    }

                    inputXmlDatapropCount++;
                }
                else
                {
                    inputXmlData["flatten"] = "Default";
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatareadOnly != null)
                {
                    if (inputXmlDatareadOnly != null)
                    {
                        inputXmlData["read_only"] = ExpressionConverter.ConvertO(inputXmlDatareadOnly);
                        inputXmlDatapropCount++;
                    }

                    inputXmlDatapropCount++;
                }
                else
                {
                    inputXmlData["read_only"] = "Default";
                    inputXmlDatapropCount++;
                }

                if (inputXmlDataoverrideSettings != null)
                {
                    inputXmlData["override_settings"] = ExpressionConverter.ConvertO(inputXmlDataoverrideSettings);
                    inputXmlDatapropCount++;
                }

                if (inputXmlDatafailOnError != null)
                {
                    if (inputXmlDatafailOnError != null)
                    {
                        inputXmlData["fail_on_error"] = ExpressionConverter.ConvertO(inputXmlDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractKeyValuePairs))]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDataoCRLanguage = null, [WorkflowExpression] Func<inputPdfDatadPIInput> inputPdfDatadPI = null, [WorkflowExpression] Func<inputPdfDatakVPOutputFormatInput> inputPdfDatakVPOutputFormat = null, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<inputPdfDataautorotateInput> inputPdfDataautorotate = null, [WorkflowExpression] Func<inputPdfDatatrimSymbolsInput> inputPdfDatatrimSymbols = null, [WorkflowExpression] Func<inputPdfDataincludeKeyBoundingBoxInput> inputPdfDataincludeKeyBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludeValueBoundingBoxInput> inputPdfDataincludeValueBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludePageNumberInput> inputPdfDataincludePageNumber = null, [WorkflowExpression] Func<inputPdfDataincludeConfidenceInput> inputPdfDataincludeConfidence = null, [WorkflowExpression] Func<int> inputPdfDataconfidenceThreshold = null, [WorkflowExpression] Func<inputPdfDataincludeTypeInput> inputPdfDataincludeType = null, [WorkflowExpression] Func<string> inputPdfDataexpectedKeys = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildExtractKeyValuePairs(WorkflowValue<string> inputPdfDatasourceFileName, WorkflowValue<string> inputPdfDatasourceFileContent, WorkflowValue<string> inputPdfDataoCRLanguage = null, WorkflowValue<inputPdfDatadPIInput> inputPdfDatadPI = null, WorkflowValue<inputPdfDatakVPOutputFormatInput> inputPdfDatakVPOutputFormat = null, WorkflowValue<string> inputPdfDatapageRange = null, WorkflowValue<inputPdfDataautorotateInput> inputPdfDataautorotate = null, WorkflowValue<inputPdfDatatrimSymbolsInput> inputPdfDatatrimSymbols = null, WorkflowValue<inputPdfDataincludeKeyBoundingBoxInput> inputPdfDataincludeKeyBoundingBox = null, WorkflowValue<inputPdfDataincludeValueBoundingBoxInput> inputPdfDataincludeValueBoundingBox = null, WorkflowValue<inputPdfDataincludePageNumberInput> inputPdfDataincludePageNumber = null, WorkflowValue<inputPdfDataincludeConfidenceInput> inputPdfDataincludeConfidence = null, WorkflowValue<int> inputPdfDataconfidenceThreshold = null, WorkflowValue<inputPdfDataincludeTypeInput> inputPdfDataincludeType = null, WorkflowValue<string> inputPdfDataexpectedKeys = null, WorkflowValue<bool> inputPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            WorkflowValue.Validate(inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            WorkflowValue.Validate(inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            WorkflowValue.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            WorkflowValue.Validate(inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            WorkflowValue.Validate(inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            WorkflowValue.Validate(inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            WorkflowValue.Validate(inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            WorkflowValue.Validate(inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            WorkflowValue.Validate(inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            WorkflowValue.Validate(inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            WorkflowValue.Validate(inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            WorkflowValue.Validate(inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            WorkflowValue.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/key_value_pairs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                if (inputPdfDataoCRLanguage != null)
                {
                    if (inputPdfDataoCRLanguage != null)
                    {
                        inputPdfData["ocr_language"] = ExpressionConverter.ConvertO(inputPdfDataoCRLanguage);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["ocr_language"] = "eng";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatadPI != null)
                {
                    if (inputPdfDatadPI != null)
                    {
                        inputPdfData["dpi"] = ExpressionConverter.ConvertO(inputPdfDatadPI);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["dpi"] = "300";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatakVPOutputFormat != null)
                {
                    if (inputPdfDatakVPOutputFormat != null)
                    {
                        inputPdfData["kvp_format"] = ExpressionConverter.ConvertO(inputPdfDatakVPOutputFormat);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["kvp_format"] = "json";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapageRange != null)
                {
                    if (inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataautorotate != null)
                {
                    if (inputPdfDataautorotate != null)
                    {
                        inputPdfData["autorotate"] = ExpressionConverter.ConvertO(inputPdfDataautorotate);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["autorotate"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatatrimSymbols != null)
                {
                    if (inputPdfDatatrimSymbols != null)
                    {
                        inputPdfData["trim_symbols"] = ExpressionConverter.ConvertO(inputPdfDatatrimSymbols);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["trim_symbols"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataincludeKeyBoundingBox != null)
                {
                    if (inputPdfDataincludeKeyBoundingBox != null)
                    {
                        inputPdfData["include_key_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeKeyBoundingBox);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_key_bounding_box"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataincludeValueBoundingBox != null)
                {
                    if (inputPdfDataincludeValueBoundingBox != null)
                    {
                        inputPdfData["include_value_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeValueBoundingBox);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_value_bounding_box"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataincludePageNumber != null)
                {
                    if (inputPdfDataincludePageNumber != null)
                    {
                        inputPdfData["include_page_number"] = ExpressionConverter.ConvertO(inputPdfDataincludePageNumber);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_page_number"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataincludeConfidence != null)
                {
                    if (inputPdfDataincludeConfidence != null)
                    {
                        inputPdfData["include_confidence"] = ExpressionConverter.ConvertO(inputPdfDataincludeConfidence);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_confidence"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataconfidenceThreshold != null)
                {
                    if (inputPdfDataconfidenceThreshold != null)
                    {
                        inputPdfData["confidence_threshold"] = ExpressionConverter.ConvertO(inputPdfDataconfidenceThreshold);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["confidence_threshold"] = 50;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataincludeType != null)
                {
                    if (inputPdfDataincludeType != null)
                    {
                        inputPdfData["include_type"] = ExpressionConverter.ConvertO(inputPdfDataincludeType);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_type"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataexpectedKeys != null)
                {
                    inputPdfData["expected_keys"] = ExpressionConverter.ConvertO(inputPdfDataexpectedKeys);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildLineWatermark))]
        public IBodyWorkflowAction<OperationResponse> LineWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDataxCoordinateStart, [WorkflowExpression] Func<string> inputDatayCoordinateStart, [WorkflowExpression] Func<string> inputDataxCoordinateEnd, [WorkflowExpression] Func<string> inputDatayCoordinateEnd, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatalineColor = null, [WorkflowExpression] Func<string> inputDatalineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildLineWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDataxCoordinateStart, WorkflowValue<string> inputDatayCoordinateStart, WorkflowValue<string> inputDataxCoordinateEnd, WorkflowValue<string> inputDatayCoordinateEnd, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatalineColor = null, WorkflowValue<string> inputDatalineWidth = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDataxCoordinateStart, nameof(inputDataxCoordinateStart), required: true);
            WorkflowValue.Validate(inputDatayCoordinateStart, nameof(inputDatayCoordinateStart), required: true);
            WorkflowValue.Validate(inputDataxCoordinateEnd, nameof(inputDataxCoordinateEnd), required: true);
            WorkflowValue.Validate(inputDatayCoordinateEnd, nameof(inputDatayCoordinateEnd), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatalineColor, nameof(inputDatalineColor), required: false);
            WorkflowValue.Validate(inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/line_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinateStart);
                inputDatapropCount++;
                inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinateStart);
                inputDatapropCount++;
                inputData["end_x"] = ExpressionConverter.ConvertO(inputDataxCoordinateEnd);
                inputDatapropCount++;
                inputData["end_y"] = ExpressionConverter.ConvertO(inputDatayCoordinateEnd);
                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatalineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatalineColor);
                    inputDatapropCount++;
                }

                if (inputDatalineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(inputDatalineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildLinearBarcodeWatermark))]
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatabarcodeContent, [WorkflowExpression] Func<inputDatabarcodeTypeInput> inputDatabarcodeType, [WorkflowExpression] Func<inputDatadisableCheckDigitInput> inputDatadisableCheckDigit, [WorkflowExpression] Func<inputDatashowCheckDigitInput> inputDatashowCheckDigit, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<inputDataomitEncodingOfStartStopSymbolsInput> inputDataomitEncodingOfStartStopSymbols = null, [WorkflowExpression] Func<string> inputDatamargin = null, [WorkflowExpression] Func<string> inputDatafontFamily = null, [WorkflowExpression] Func<string> inputDatafontSize = null, [WorkflowExpression] Func<string> inputDatafontStyle = null, [WorkflowExpression] Func<inputDatalabelPlacementInput> inputDatalabelPlacement = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatabarcodeBackgroundColor = null, [WorkflowExpression] Func<string> inputDatabarcodeBarColor = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildLinearBarcodeWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatabarcodeContent, WorkflowValue<inputDatabarcodeTypeInput> inputDatabarcodeType, WorkflowValue<inputDatadisableCheckDigitInput> inputDatadisableCheckDigit, WorkflowValue<inputDatashowCheckDigitInput> inputDatashowCheckDigit, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<inputDataomitEncodingOfStartStopSymbolsInput> inputDataomitEncodingOfStartStopSymbols = null, WorkflowValue<string> inputDatamargin = null, WorkflowValue<string> inputDatafontFamily = null, WorkflowValue<string> inputDatafontSize = null, WorkflowValue<string> inputDatafontStyle = null, WorkflowValue<inputDatalabelPlacementInput> inputDatalabelPlacement = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatabarcodeBackgroundColor = null, WorkflowValue<string> inputDatabarcodeBarColor = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatabarcodeContent, nameof(inputDatabarcodeContent), required: true);
            WorkflowValue.Validate(inputDatabarcodeType, nameof(inputDatabarcodeType), required: true);
            WorkflowValue.Validate(inputDatadisableCheckDigit, nameof(inputDatadisableCheckDigit), required: true);
            WorkflowValue.Validate(inputDatashowCheckDigit, nameof(inputDatashowCheckDigit), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataomitEncodingOfStartStopSymbols, nameof(inputDataomitEncodingOfStartStopSymbols), required: false);
            WorkflowValue.Validate(inputDatamargin, nameof(inputDatamargin), required: false);
            WorkflowValue.Validate(inputDatafontFamily, nameof(inputDatafontFamily), required: false);
            WorkflowValue.Validate(inputDatafontSize, nameof(inputDatafontSize), required: false);
            WorkflowValue.Validate(inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            WorkflowValue.Validate(inputDatalabelPlacement, nameof(inputDatalabelPlacement), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatabarcodeBackgroundColor, nameof(inputDatabarcodeBackgroundColor), required: false);
            WorkflowValue.Validate(inputDatabarcodeBarColor, nameof(inputDatabarcodeBarColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/linear_barcode_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = ExpressionConverter.ConvertO(inputDatabarcodeContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["barcode_type"] = ExpressionConverter.ConvertO(inputDatabarcodeType);
                if (inputDataomitEncodingOfStartStopSymbols != null)
                {
                    if (inputDataomitEncodingOfStartStopSymbols != null)
                    {
                        inputData["omit_start_stop_symbols"] = ExpressionConverter.ConvertO(inputDataomitEncodingOfStartStopSymbols);
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
                inputData["disable_checkdigit"] = ExpressionConverter.ConvertO(inputDatadisableCheckDigit);
                inputDatapropCount++;
                inputData["show_checkdigit"] = ExpressionConverter.ConvertO(inputDatashowCheckDigit);
                if (inputDatamargin != null)
                {
                    inputData["margin"] = ExpressionConverter.ConvertO(inputDatamargin);
                    inputDatapropCount++;
                }

                if (inputDatafontFamily != null)
                {
                    inputData["font_family_name"] = ExpressionConverter.ConvertO(inputDatafontFamily);
                    inputDatapropCount++;
                }

                if (inputDatafontSize != null)
                {
                    inputData["font_size"] = ExpressionConverter.ConvertO(inputDatafontSize);
                    inputDatapropCount++;
                }

                if (inputDatafontStyle != null)
                {
                    inputData["font_style"] = ExpressionConverter.ConvertO(inputDatafontStyle);
                    inputDatapropCount++;
                }

                if (inputDatalabelPlacement != null)
                {
                    if (inputDatalabelPlacement != null)
                    {
                        inputData["label_placement"] = ExpressionConverter.ConvertO(inputDatalabelPlacement);
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
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatabarcodeBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatabarcodeBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatabarcodeBarColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatabarcodeBarColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildMergeToPdf))]
        public IBodyWorkflowAction<OperationResponse> MergeToPdf([WorkflowExpression] Func<string> inputDatasourceFileName1 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent1 = null, [WorkflowExpression] Func<string> inputDatasourceFileName2 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent2 = null, [WorkflowExpression] Func<string> inputDatasourceFileName3 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent3 = null, [WorkflowExpression] Func<string> inputDatasourceFileName4 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent4 = null, [WorkflowExpression] Func<string> inputDatasourceFileName5 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent5 = null, [WorkflowExpression] Func<inputDataeachDocumentInput> inputDataeachDocument = null, [WorkflowExpression] Func<MergeSourceFile[]> inputDatasourceFiles = null, [WorkflowExpression] Func<string> inputDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildMergeToPdf(WorkflowValue<string> inputDatasourceFileName1 = null, WorkflowValue<string> inputDatasourceFileContent1 = null, WorkflowValue<string> inputDatasourceFileName2 = null, WorkflowValue<string> inputDatasourceFileContent2 = null, WorkflowValue<string> inputDatasourceFileName3 = null, WorkflowValue<string> inputDatasourceFileContent3 = null, WorkflowValue<string> inputDatasourceFileName4 = null, WorkflowValue<string> inputDatasourceFileContent4 = null, WorkflowValue<string> inputDatasourceFileName5 = null, WorkflowValue<string> inputDatasourceFileContent5 = null, WorkflowValue<inputDataeachDocumentInput> inputDataeachDocument = null, WorkflowValue<MergeSourceFile[]> inputDatasourceFiles = null, WorkflowValue<string> inputDataoverrideSettings = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileName1, nameof(inputDatasourceFileName1), required: false);
            WorkflowValue.Validate(inputDatasourceFileContent1, nameof(inputDatasourceFileContent1), required: false);
            WorkflowValue.Validate(inputDatasourceFileName2, nameof(inputDatasourceFileName2), required: false);
            WorkflowValue.Validate(inputDatasourceFileContent2, nameof(inputDatasourceFileContent2), required: false);
            WorkflowValue.Validate(inputDatasourceFileName3, nameof(inputDatasourceFileName3), required: false);
            WorkflowValue.Validate(inputDatasourceFileContent3, nameof(inputDatasourceFileContent3), required: false);
            WorkflowValue.Validate(inputDatasourceFileName4, nameof(inputDatasourceFileName4), required: false);
            WorkflowValue.Validate(inputDatasourceFileContent4, nameof(inputDatasourceFileContent4), required: false);
            WorkflowValue.Validate(inputDatasourceFileName5, nameof(inputDatasourceFileName5), required: false);
            WorkflowValue.Validate(inputDatasourceFileContent5, nameof(inputDatasourceFileContent5), required: false);
            WorkflowValue.Validate(inputDataeachDocument, nameof(inputDataeachDocument), required: false);
            WorkflowValue.Validate(inputDatasourceFiles, nameof(inputDatasourceFiles), required: false);
            WorkflowValue.Validate(inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/merge_to_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                if (inputDatasourceFileName1 != null)
                {
                    inputData["source_file_name_1"] = ExpressionConverter.ConvertO(inputDatasourceFileName1);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileContent1 != null)
                {
                    inputData["source_file_content_1"] = ExpressionConverter.ConvertO(inputDatasourceFileContent1);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileName2 != null)
                {
                    inputData["source_file_name_2"] = ExpressionConverter.ConvertO(inputDatasourceFileName2);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileContent2 != null)
                {
                    inputData["source_file_content_2"] = ExpressionConverter.ConvertO(inputDatasourceFileContent2);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileName3 != null)
                {
                    inputData["source_file_name_3"] = ExpressionConverter.ConvertO(inputDatasourceFileName3);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileContent3 != null)
                {
                    inputData["source_file_content_3"] = ExpressionConverter.ConvertO(inputDatasourceFileContent3);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileName4 != null)
                {
                    inputData["source_file_name_4"] = ExpressionConverter.ConvertO(inputDatasourceFileName4);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileContent4 != null)
                {
                    inputData["source_file_content_4"] = ExpressionConverter.ConvertO(inputDatasourceFileContent4);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileName5 != null)
                {
                    inputData["source_file_name_5"] = ExpressionConverter.ConvertO(inputDatasourceFileName5);
                    inputDatapropCount++;
                }

                if (inputDatasourceFileContent5 != null)
                {
                    inputData["source_file_content_5"] = ExpressionConverter.ConvertO(inputDatasourceFileContent5);
                    inputDatapropCount++;
                }

                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (inputDataeachDocument != null)
                {
                    if (inputDataeachDocument != null)
                    {
                        inputData["document_start_page"] = ExpressionConverter.ConvertO(inputDataeachDocument);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["document_start_page"] = "Starts on the next page";
                    inputDatapropCount++;
                }

                if (inputDatasourceFiles != null)
                {
                    inputData["source_files"] = ExpressionConverter.ConvertO(inputDatasourceFiles);
                    inputDatapropCount++;
                }

                if (inputDataoverrideSettings != null)
                {
                    inputData["override_settings"] = ExpressionConverter.ConvertO(inputDataoverrideSettings);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildOcrPdf))]
        public IBodyWorkflowAction<OperationResponse> OcrPdf([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<string> inputDataregions = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildOcrPdf(WorkflowValue<string> inputDatasourceFileName, WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDatalanguageInput> inputDatalanguage = null, WorkflowValue<inputDataperformanceInput> inputDataperformance = null, WorkflowValue<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, WorkflowValue<string> inputDatacharacters = null, WorkflowValue<bool> inputDatausePagination = null, WorkflowValue<string> inputDataregions = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatalanguage, nameof(inputDatalanguage), required: false);
            WorkflowValue.Validate(inputDataperformance, nameof(inputDataperformance), required: false);
            WorkflowValue.Validate(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            WorkflowValue.Validate(inputDatacharacters, nameof(inputDatacharacters), required: false);
            WorkflowValue.Validate(inputDatausePagination, nameof(inputDatausePagination), required: false);
            WorkflowValue.Validate(inputDataregions, nameof(inputDataregions), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputData["copy_metadata"] = false;
                inputDatapropCount++;
                if (inputDatalanguage != null)
                {
                    if (inputDatalanguage != null)
                    {
                        inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["language"] = "English";
                    inputDatapropCount++;
                }

                if (inputDataperformance != null)
                {
                    if (inputDataperformance != null)
                    {
                        inputData["performance"] = ExpressionConverter.ConvertO(inputDataperformance);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["performance"] = "Slow but accurate";
                    inputDatapropCount++;
                }

                if (inputDatablacklistWhitelist != null)
                {
                    if (inputDatablacklistWhitelist != null)
                    {
                        inputData["characters_option"] = ExpressionConverter.ConvertO(inputDatablacklistWhitelist);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["characters_option"] = "None";
                    inputDatapropCount++;
                }

                if (inputDatacharacters != null)
                {
                    inputData["characters"] = ExpressionConverter.ConvertO(inputDatacharacters);
                    inputDatapropCount++;
                }

                if (inputDatausePagination != null)
                {
                    if (inputDatausePagination != null)
                    {
                        inputData["paginate"] = ExpressionConverter.ConvertO(inputDatausePagination);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["paginate"] = false;
                    inputDatapropCount++;
                }

                if (inputDataregions != null)
                {
                    inputData["regions"] = ExpressionConverter.ConvertO(inputDataregions);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildOcrText))]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<string> inputDatawidth = null, [WorkflowExpression] Func<string> inputDataheight = null, [WorkflowExpression] Func<string> inputDatapageNumber = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OcrOperationResponse> __BuildOcrText(WorkflowValue<string> inputDatasourceFileName, WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDatalanguageInput> inputDatalanguage = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<string> inputDatawidth = null, WorkflowValue<string> inputDataheight = null, WorkflowValue<string> inputDatapageNumber = null, WorkflowValue<inputDataperformanceInput> inputDataperformance = null, WorkflowValue<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, WorkflowValue<string> inputDatacharacters = null, WorkflowValue<bool> inputDatausePagination = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatalanguage, nameof(inputDatalanguage), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: false);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: false);
            WorkflowValue.Validate(inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            WorkflowValue.Validate(inputDataperformance, nameof(inputDataperformance), required: false);
            WorkflowValue.Validate(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            WorkflowValue.Validate(inputDatacharacters, nameof(inputDatacharacters), required: false);
            WorkflowValue.Validate(inputDatausePagination, nameof(inputDatausePagination), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OcrOperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (inputDatalanguage != null)
                {
                    if (inputDatalanguage != null)
                    {
                        inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["language"] = "English";
                    inputDatapropCount++;
                }

                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatawidth != null)
                {
                    inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                    inputDatapropCount++;
                }

                if (inputDataheight != null)
                {
                    inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                    inputDatapropCount++;
                }

                if (inputDatapageNumber != null)
                {
                    if (inputDatapageNumber != null)
                    {
                        inputData["page_number"] = ExpressionConverter.ConvertO(inputDatapageNumber);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_number"] = "";
                    inputDatapropCount++;
                }

                if (inputDataperformance != null)
                {
                    if (inputDataperformance != null)
                    {
                        inputData["performance"] = ExpressionConverter.ConvertO(inputDataperformance);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["performance"] = "Slow but accurate";
                    inputDatapropCount++;
                }

                if (inputDatablacklistWhitelist != null)
                {
                    if (inputDatablacklistWhitelist != null)
                    {
                        inputData["characters_option"] = ExpressionConverter.ConvertO(inputDatablacklistWhitelist);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["characters_option"] = "None";
                    inputDatapropCount++;
                }

                if (inputDatacharacters != null)
                {
                    inputData["characters"] = ExpressionConverter.ConvertO(inputDatacharacters);
                    inputDatapropCount++;
                }

                if (inputDatausePagination != null)
                {
                    if (inputDatausePagination != null)
                    {
                        inputData["paginate"] = ExpressionConverter.ConvertO(inputDatausePagination);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["paginate"] = false;
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildPdfWatermark))]
        public IBodyWorkflowAction<OperationResponse> PdfWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatapDFWatermark, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildPdfWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatapDFWatermark, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatapDFWatermark, nameof(inputDatapDFWatermark), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/pdf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["pdf_file"] = ExpressionConverter.ConvertO(inputDatapDFWatermark);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildQrCodeWatermark))]
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatacontent, [WorkflowExpression] Func<inputDataversionInput> inputDataversion, [WorkflowExpression] Func<inputDatainputModeInput> inputDatainputMode, [WorkflowExpression] Func<inputDataerrorCorrectionLevelInput> inputDataerrorCorrectionLevel, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkForegroundColor = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildQrCodeWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatacontent, WorkflowValue<inputDataversionInput> inputDataversion, WorkflowValue<inputDatainputModeInput> inputDatainputMode, WorkflowValue<inputDataerrorCorrectionLevelInput> inputDataerrorCorrectionLevel, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatawatermarkBackgroundColor = null, WorkflowValue<string> inputDatawatermarkForegroundColor = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatacontent, nameof(inputDatacontent), required: true);
            WorkflowValue.Validate(inputDataversion, nameof(inputDataversion), required: true);
            WorkflowValue.Validate(inputDatainputMode, nameof(inputDatainputMode), required: true);
            WorkflowValue.Validate(inputDataerrorCorrectionLevel, nameof(inputDataerrorCorrectionLevel), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkForegroundColor, nameof(inputDatawatermarkForegroundColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/qr_code_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = ExpressionConverter.ConvertO(inputDatacontent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["version"] = ExpressionConverter.ConvertO(inputDataversion);
                inputDatapropCount++;
                inputData["input_mode"] = ExpressionConverter.ConvertO(inputDatainputMode);
                inputDatapropCount++;
                inputData["error_correction_level"] = ExpressionConverter.ConvertO(inputDataerrorCorrectionLevel);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkForegroundColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatawatermarkForegroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildRectangleWatermark))]
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildRectangleWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatawatermarkBackgroundColor = null, WorkflowValue<string> inputDatawatermarkOutlineColor = null, WorkflowValue<string> inputDatawatermarkOutlineWidth = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/rectangle_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildRedact))]
        public IBodyWorkflowAction<OperationResponse> Redact([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<inputPdfDataredactionTypeInput> inputPdfDataredactionType, [WorkflowExpression] Func<string> inputPdfDataredactPattern, [WorkflowExpression] Func<bool> inputPdfDataincludeAnnotations = null, [WorkflowExpression] Func<bool> inputPdfDatacaseSensitive = null, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<string> inputPdfDataopenPassword = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildRedact(WorkflowValue<string> inputPdfDatasourceFileName, WorkflowValue<string> inputPdfDatasourceFileContent, WorkflowValue<inputPdfDataredactionTypeInput> inputPdfDataredactionType, WorkflowValue<string> inputPdfDataredactPattern, WorkflowValue<bool> inputPdfDataincludeAnnotations = null, WorkflowValue<bool> inputPdfDatacaseSensitive = null, WorkflowValue<string> inputPdfDatapageRange = null, WorkflowValue<string> inputPdfDataopenPassword = null, WorkflowValue<bool> inputPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPdfDataredactionType, nameof(inputPdfDataredactionType), required: true);
            WorkflowValue.Validate(inputPdfDataredactPattern, nameof(inputPdfDataredactPattern), required: true);
            WorkflowValue.Validate(inputPdfDataincludeAnnotations, nameof(inputPdfDataincludeAnnotations), required: false);
            WorkflowValue.Validate(inputPdfDatacaseSensitive, nameof(inputPdfDatacaseSensitive), required: false);
            WorkflowValue.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            WorkflowValue.Validate(inputPdfDataopenPassword, nameof(inputPdfDataopenPassword), required: false);
            WorkflowValue.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/redact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["redaction_type"] = ExpressionConverter.ConvertO(inputPdfDataredactionType);
                inputPdfDatapropCount++;
                inputPdfData["redact_text"] = ExpressionConverter.ConvertO(inputPdfDataredactPattern);
                if (inputPdfDataincludeAnnotations != null)
                {
                    if (inputPdfDataincludeAnnotations != null)
                    {
                        inputPdfData["include_annotations"] = ExpressionConverter.ConvertO(inputPdfDataincludeAnnotations);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_annotations"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatacaseSensitive != null)
                {
                    if (inputPdfDatacaseSensitive != null)
                    {
                        inputPdfData["case_sensitive"] = ExpressionConverter.ConvertO(inputPdfDatacaseSensitive);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["case_sensitive"] = false;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapageRange != null)
                {
                    if (inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataopenPassword != null)
                {
                    inputPdfData["open_password"] = ExpressionConverter.ConvertO(inputPdfDataopenPassword);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildRedactSmart))]
        public IBodyWorkflowAction<OperationResponse> RedactSmart([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<bool> inputPdfDataredactCreditCardNumber, [WorkflowExpression] Func<bool> inputPdfDataredactDate, [WorkflowExpression] Func<bool> inputPdfDataredactEmailAddress, [WorkflowExpression] Func<bool> inputPdfDataredactInternationalPhoneNumber, [WorkflowExpression] Func<bool> inputPdfDataredactIPv4Address, [WorkflowExpression] Func<bool> inputPdfDataredactIPv6Address, [WorkflowExpression] Func<bool> inputPdfDataredactMACAddress, [WorkflowExpression] Func<bool> inputPdfDataredactNorthAmericanPhoneNumber, [WorkflowExpression] Func<bool> inputPdfDataredactSocialSecurityNumber, [WorkflowExpression] Func<bool> inputPdfDataredactTime, [WorkflowExpression] Func<bool> inputPdfDataredactURL, [WorkflowExpression] Func<bool> inputPdfDataredactUSZipCode, [WorkflowExpression] Func<bool> inputPdfDataredactVIN, [WorkflowExpression] Func<bool> inputPdfDataincludeAnnotations = null, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<string> inputPdfDataopenPassword = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildRedactSmart(WorkflowValue<string> inputPdfDatasourceFileName, WorkflowValue<string> inputPdfDatasourceFileContent, WorkflowValue<bool> inputPdfDataredactCreditCardNumber, WorkflowValue<bool> inputPdfDataredactDate, WorkflowValue<bool> inputPdfDataredactEmailAddress, WorkflowValue<bool> inputPdfDataredactInternationalPhoneNumber, WorkflowValue<bool> inputPdfDataredactIPv4Address, WorkflowValue<bool> inputPdfDataredactIPv6Address, WorkflowValue<bool> inputPdfDataredactMACAddress, WorkflowValue<bool> inputPdfDataredactNorthAmericanPhoneNumber, WorkflowValue<bool> inputPdfDataredactSocialSecurityNumber, WorkflowValue<bool> inputPdfDataredactTime, WorkflowValue<bool> inputPdfDataredactURL, WorkflowValue<bool> inputPdfDataredactUSZipCode, WorkflowValue<bool> inputPdfDataredactVIN, WorkflowValue<bool> inputPdfDataincludeAnnotations = null, WorkflowValue<string> inputPdfDatapageRange = null, WorkflowValue<string> inputPdfDataopenPassword = null, WorkflowValue<bool> inputPdfDatafailOnError = null)
        {
            WorkflowValue.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowValue.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputPdfDataredactCreditCardNumber, nameof(inputPdfDataredactCreditCardNumber), required: true);
            WorkflowValue.Validate(inputPdfDataredactDate, nameof(inputPdfDataredactDate), required: true);
            WorkflowValue.Validate(inputPdfDataredactEmailAddress, nameof(inputPdfDataredactEmailAddress), required: true);
            WorkflowValue.Validate(inputPdfDataredactInternationalPhoneNumber, nameof(inputPdfDataredactInternationalPhoneNumber), required: true);
            WorkflowValue.Validate(inputPdfDataredactIPv4Address, nameof(inputPdfDataredactIPv4Address), required: true);
            WorkflowValue.Validate(inputPdfDataredactIPv6Address, nameof(inputPdfDataredactIPv6Address), required: true);
            WorkflowValue.Validate(inputPdfDataredactMACAddress, nameof(inputPdfDataredactMACAddress), required: true);
            WorkflowValue.Validate(inputPdfDataredactNorthAmericanPhoneNumber, nameof(inputPdfDataredactNorthAmericanPhoneNumber), required: true);
            WorkflowValue.Validate(inputPdfDataredactSocialSecurityNumber, nameof(inputPdfDataredactSocialSecurityNumber), required: true);
            WorkflowValue.Validate(inputPdfDataredactTime, nameof(inputPdfDataredactTime), required: true);
            WorkflowValue.Validate(inputPdfDataredactURL, nameof(inputPdfDataredactURL), required: true);
            WorkflowValue.Validate(inputPdfDataredactUSZipCode, nameof(inputPdfDataredactUSZipCode), required: true);
            WorkflowValue.Validate(inputPdfDataredactVIN, nameof(inputPdfDataredactVIN), required: true);
            WorkflowValue.Validate(inputPdfDataincludeAnnotations, nameof(inputPdfDataincludeAnnotations), required: false);
            WorkflowValue.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            WorkflowValue.Validate(inputPdfDataopenPassword, nameof(inputPdfDataopenPassword), required: false);
            WorkflowValue.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/redact_smart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                inputPdfDatapropCount++;
                inputPdfData["redact_credit_card_number"] = ExpressionConverter.ConvertO(inputPdfDataredactCreditCardNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_date"] = ExpressionConverter.ConvertO(inputPdfDataredactDate);
                inputPdfDatapropCount++;
                inputPdfData["redact_email_address"] = ExpressionConverter.ConvertO(inputPdfDataredactEmailAddress);
                inputPdfDatapropCount++;
                inputPdfData["redact_international_phone_number"] = ExpressionConverter.ConvertO(inputPdfDataredactInternationalPhoneNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_ipv4"] = ExpressionConverter.ConvertO(inputPdfDataredactIPv4Address);
                inputPdfDatapropCount++;
                inputPdfData["redact_ipv6"] = ExpressionConverter.ConvertO(inputPdfDataredactIPv6Address);
                inputPdfDatapropCount++;
                inputPdfData["redact_mac_address"] = ExpressionConverter.ConvertO(inputPdfDataredactMACAddress);
                inputPdfDatapropCount++;
                inputPdfData["redact_north_american_phone_number"] = ExpressionConverter.ConvertO(inputPdfDataredactNorthAmericanPhoneNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_social_security_number"] = ExpressionConverter.ConvertO(inputPdfDataredactSocialSecurityNumber);
                inputPdfDatapropCount++;
                inputPdfData["redact_time"] = ExpressionConverter.ConvertO(inputPdfDataredactTime);
                inputPdfDatapropCount++;
                inputPdfData["redact_url"] = ExpressionConverter.ConvertO(inputPdfDataredactURL);
                inputPdfDatapropCount++;
                inputPdfData["redact_us_zip_code"] = ExpressionConverter.ConvertO(inputPdfDataredactUSZipCode);
                inputPdfDatapropCount++;
                inputPdfData["redact_vin"] = ExpressionConverter.ConvertO(inputPdfDataredactVIN);
                if (inputPdfDataincludeAnnotations != null)
                {
                    if (inputPdfDataincludeAnnotations != null)
                    {
                        inputPdfData["include_annotations"] = ExpressionConverter.ConvertO(inputPdfDataincludeAnnotations);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_annotations"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapageRange != null)
                {
                    if (inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (inputPdfDataopenPassword != null)
                {
                    inputPdfData["open_password"] = ExpressionConverter.ConvertO(inputPdfDataopenPassword);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildRtfWatermark))]
        public IBodyWorkflowAction<OperationResponse> RtfWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildRtfWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatawatermarkContent, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatawatermarkBackgroundColor = null, WorkflowValue<string> inputDatawatermarkOutlineColor = null, WorkflowValue<string> inputDatawatermarkOutlineWidth = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            WorkflowValue.Validate(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/rtf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["rtf_data"] = ExpressionConverter.ConvertO(inputDatawatermarkContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkBackgroundColor != null)
                {
                    inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildSecurePdf))]
        public IBodyWorkflowAction<OperationResponse> SecurePdf([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataopenPassword = null, [WorkflowExpression] Func<string> inputDataownerPassword = null, [WorkflowExpression] Func<string> inputDatapDFRestrictions = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildSecurePdf(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataopenPassword = null, WorkflowValue<string> inputDataownerPassword = null, WorkflowValue<string> inputDatapDFRestrictions = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataopenPassword, nameof(inputDataopenPassword), required: false);
            WorkflowValue.Validate(inputDataownerPassword, nameof(inputDataownerPassword), required: false);
            WorkflowValue.Validate(inputDatapDFRestrictions, nameof(inputDatapDFRestrictions), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/secure_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (inputDataopenPassword != null)
                {
                    inputData["open_password"] = ExpressionConverter.ConvertO(inputDataopenPassword);
                    inputDatapropCount++;
                }

                if (inputDataownerPassword != null)
                {
                    inputData["owner_password"] = ExpressionConverter.ConvertO(inputDataownerPassword);
                    inputDatapropCount++;
                }

                if (inputDatapDFRestrictions != null)
                {
                    inputData["security_options"] = ExpressionConverter.ConvertO(inputDatapDFRestrictions);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildSplitPdf))]
        public IBodyWorkflowAction<SplitOperationResponse> SplitPdf([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatasplitByInput> inputDatasplitBy, [WorkflowExpression] Func<int> inputDatasplitParameter, [WorkflowExpression] Func<string> inputDatafileNameTemplate = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SplitOperationResponse> __BuildSplitPdf(WorkflowValue<string> inputDatasourceFileName, WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<inputDatasplitByInput> inputDatasplitBy, WorkflowValue<int> inputDatasplitParameter, WorkflowValue<string> inputDatafileNameTemplate = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatasplitBy, nameof(inputDatasplitBy), required: true);
            WorkflowValue.Validate(inputDatasplitParameter, nameof(inputDatasplitParameter), required: true);
            WorkflowValue.Validate(inputDatafileNameTemplate, nameof(inputDatafileNameTemplate), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<SplitOperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/split_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (inputDatafileNameTemplate != null)
                {
                    inputData["file_name_template"] = ExpressionConverter.ConvertO(inputDatafileNameTemplate);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["file_split_by"] = ExpressionConverter.ConvertO(inputDatasplitBy);
                inputDatapropCount++;
                inputData["split_parameter"] = ExpressionConverter.ConvertO(inputDatasplitParameter);
                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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
        [WorkflowExpressionFactory(nameof(__BuildTextWatermark))]
        public IBodyWorkflowAction<OperationResponse> TextWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkContent, [WorkflowExpression] Func<string> inputDatafontFamilyName, [WorkflowExpression] Func<string> inputDatafontSize, [WorkflowExpression] Func<string> inputDatafontColor, [WorkflowExpression] Func<inputDatatextAlignmentInput> inputDatatextAlignment, [WorkflowExpression] Func<inputDatawordWrapInput> inputDatawordWrap, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatafontStyle = null, [WorkflowExpression] Func<string> inputDatafontOutlineColor = null, [WorkflowExpression] Func<string> inputDatafontOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildTextWatermark(WorkflowValue<string> inputDatasourceFileContent, WorkflowValue<string> inputDatawatermarkContent, WorkflowValue<string> inputDatafontFamilyName, WorkflowValue<string> inputDatafontSize, WorkflowValue<string> inputDatafontColor, WorkflowValue<inputDatatextAlignmentInput> inputDatatextAlignment, WorkflowValue<inputDatawordWrapInput> inputDatawordWrap, WorkflowValue<inputDatapositionInput> inputDataposition, WorkflowValue<string> inputDatawidth, WorkflowValue<string> inputDataheight, WorkflowValue<string> inputDatasourceFileName = null, WorkflowValue<string> inputDataxCoordinate = null, WorkflowValue<string> inputDatayCoordinate = null, WorkflowValue<inputDatalayerInput> inputDatalayer = null, WorkflowValue<string> inputDatarotation = null, WorkflowValue<string> inputDataopacity = null, WorkflowValue<string> inputDatafontStyle = null, WorkflowValue<string> inputDatafontOutlineColor = null, WorkflowValue<string> inputDatafontOutlineWidth = null, WorkflowValue<int> inputDatawatermarkStartPage = null, WorkflowValue<int> inputDatawatermarkEndPage = null, WorkflowValue<int> inputDatawatermarkPageInterval = null, WorkflowValue<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, WorkflowValue<inputDataprintOnlyInput> inputDataprintOnly = null, WorkflowValue<int> inputDatawatermarkStartSection = null, WorkflowValue<int> inputDatawatermarkEndSection = null, WorkflowValue<string> inputDatawatermarkPageType = null, WorkflowValue<bool> inputDatafailOnError = null)
        {
            WorkflowValue.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowValue.Validate(inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            WorkflowValue.Validate(inputDatafontFamilyName, nameof(inputDatafontFamilyName), required: true);
            WorkflowValue.Validate(inputDatafontSize, nameof(inputDatafontSize), required: true);
            WorkflowValue.Validate(inputDatafontColor, nameof(inputDatafontColor), required: true);
            WorkflowValue.Validate(inputDatatextAlignment, nameof(inputDatatextAlignment), required: true);
            WorkflowValue.Validate(inputDatawordWrap, nameof(inputDatawordWrap), required: true);
            WorkflowValue.Validate(inputDataposition, nameof(inputDataposition), required: true);
            WorkflowValue.Validate(inputDatawidth, nameof(inputDatawidth), required: true);
            WorkflowValue.Validate(inputDataheight, nameof(inputDataheight), required: true);
            WorkflowValue.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            WorkflowValue.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowValue.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowValue.Validate(inputDatalayer, nameof(inputDatalayer), required: false);
            WorkflowValue.Validate(inputDatarotation, nameof(inputDatarotation), required: false);
            WorkflowValue.Validate(inputDataopacity, nameof(inputDataopacity), required: false);
            WorkflowValue.Validate(inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            WorkflowValue.Validate(inputDatafontOutlineColor, nameof(inputDatafontOutlineColor), required: false);
            WorkflowValue.Validate(inputDatafontOutlineWidth, nameof(inputDatafontOutlineWidth), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            WorkflowValue.Validate(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            WorkflowValue.Validate(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            WorkflowValue.Validate(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            WorkflowValue.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/text_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = ExpressionConverter.ConvertO(inputDatawatermarkContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["font_family_name"] = ExpressionConverter.ConvertO(inputDatafontFamilyName);
                inputDatapropCount++;
                inputData["font_size"] = ExpressionConverter.ConvertO(inputDatafontSize);
                inputDatapropCount++;
                inputData["fill_color"] = ExpressionConverter.ConvertO(inputDatafontColor);
                inputDatapropCount++;
                inputData["alignment"] = ExpressionConverter.ConvertO(inputDatatextAlignment);
                inputDatapropCount++;
                inputData["word_wrap"] = ExpressionConverter.ConvertO(inputDatawordWrap);
                inputDatapropCount++;
                inputData["position"] = ExpressionConverter.ConvertO(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["layer"] = "Foreground";
                    inputDatapropCount++;
                }

                if (inputDatarotation != null)
                {
                    inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["opacity"] = "100";
                    inputDatapropCount++;
                }

                if (inputDatafontStyle != null)
                {
                    inputData["font_style"] = ExpressionConverter.ConvertO(inputDatafontStyle);
                    inputDatapropCount++;
                }

                if (inputDatafontOutlineColor != null)
                {
                    inputData["line_color"] = ExpressionConverter.ConvertO(inputDatafontOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatafontOutlineWidth != null)
                {
                    inputData["line_width"] = ExpressionConverter.ConvertO(inputDatafontOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = ExpressionConverter.ConvertO(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = ExpressionConverter.ConvertO(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = ExpressionConverter.ConvertO(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_orientation"] = "Both";
                    inputDatapropCount++;
                }

                if (inputDataprintOnly != null)
                {
                    if (inputDataprintOnly != null)
                    {
                        inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["print_only"] = "false";
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartSection != null)
                {
                    inputData["start_section"] = ExpressionConverter.ConvertO(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = ExpressionConverter.ConvertO(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = ExpressionConverter.ConvertO(inputDatawatermarkPageType);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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

    public enum inputPdfDataremoveAnnotationsInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveBlankPagesInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveBookmarksInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveEmbeddedFilesInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveFormFieldsInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveHyperlinksInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveJavaScriptInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremoveMetadataInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataremovePageThumbnailsInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDatapackFontsInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDatapackDocumentInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDatarecompressImagesInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataenableMRCInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDatapreserveSmoothingInput
    {
        Default,
        Yes,
        No
    }

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

    public enum inputPdfDatadownscaleImagesInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataenableColorDetectionInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataenableCharRepairInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataenableJPEG2000Input
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataenableJBIG2Input
    {
        Default,
        Yes,
        No
    }

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

    public enum inputCadDatapaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

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

    public enum inputCadDataemptyLayoutDetectionInput
    {
        Default,
        SkipNone,
        SkipEmptyLayouts,
        SkipLayoutsWithoutViewports
    }

    public enum inputCadDatalayoutSortOrderInput
    {
        Default,
        Ascending,
        Descending,
        TabOrder
    }

    public enum inputEmailDataattachmentActionInput
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    public enum inputEmailDataunsupportedAttachmentActionInput
    {
        Error,
        Remove,
        AttachOriginal
    }

    public enum inputEmailDatapaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    public enum inputEmailDataconversionQualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

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

    public enum inputExcelDatarangeInput
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    public enum inputExcelDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public enum inputDatapageOrientationInput
    {
        Portrait,
        Landscape
    }

    public enum inputDatamediaTypeInput
    {
        Screen,
        Print
    }

    public enum inputDataauthenticationTypeInput
    {
        Anonymous,
        [EnumMember(Value = "SharePoint Online")]
        SharePointOnline,
        Web
    }

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

    public enum inputInfopathDataattachmentActionInput
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    public enum inputInfopathDataunsupportedAttachmentActionInput
    {
        Error,
        Remove,
        AttachOriginal
    }

    public enum inputInfopathDatadefaultPaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    public enum inputInfopathDataforcePaperSizeInput
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    public enum inputInfopathDatadefaultPageOrientationInput
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    public enum inputInfopathDataforcePageOrientationInput
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    public enum inputInfopathDataconversionQualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

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

    public enum inputPowerpointDatarangeInput
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

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

    public enum inputPowerpointDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public enum inputVisioDataoutputFormatInput
    {
        PDF,
        XPS
    }

    public enum inputVisioDatarangeInput
    {
        AllDocuments,
        ActiveDocuments
    }

    public enum inputVisioDataqualityInput
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

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

    public enum inputWordDatadisplayForReviewInput
    {
        Final,
        Original,
        FinalShowingMarkup,
        OriginalShowingMarkup
    }

    public enum inputWordDatareviewMarkupModeInput
    {
        Balloon,
        InLine,
        Mixed
    }

    public enum inputWordDatagenerateBookmarksInput
    {
        Disabled,
        Automatic,
        Custom
    }

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

    public enum inputDatalayerInput
    {
        Background,
        Foreground
    }

    public enum inputDatawatermarkPageOrientationInput
    {
        Portrait,
        Landscape,
        Both
    }

    public enum inputDataprintOnlyInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public enum inputFromPdfDataoutputDataFormatInput
    {
        XML,
        FDF,
        XFDF
    }

    public enum inputXmlDataflattenInput
    {
        Default,
        Yes,
        No
    }

    public enum inputXmlDatareadOnlyInput
    {
        Default,
        Yes,
        No
    }

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

    public enum inputPdfDatakVPOutputFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xml")]
        Xml
    }

    public enum inputPdfDataautorotateInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDatatrimSymbolsInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeKeyBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeValueBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludePageNumberInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeConfidenceInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeTypeInput
    {
        Default,
        Yes,
        No
    }

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

    public enum inputDatadisableCheckDigitInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum inputDatashowCheckDigitInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum inputDataomitEncodingOfStartStopSymbolsInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

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

    public enum inputDataperformanceInput
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

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

    public enum inputDatainputModeInput
    {
        Binary,
        Alphanumeric,
        Numeric
    }

    public enum inputDataerrorCorrectionLevelInput
    {
        Low,
        Medium,
        High,
        Quartile
    }

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

    public enum inputDatasplitByInput
    {
        [EnumMember(Value = "Number of Pages")]
        NumberOfPages,
        [EnumMember(Value = "Bookmark Level")]
        BookmarkLevel
    }

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
