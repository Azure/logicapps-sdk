//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbipdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MuhimbipdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkData, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkData = inputDatawatermarkData == null ? null : WorkflowExpression.Compile(inputDatawatermarkData);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkData, nameof(inputDatawatermarkData), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> CompressPdf(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDataremoveAnnotationsInput>> inputPdfDataremoveAnnotations = null, Expression<Func<inputPdfDataremoveBlankPagesInput>> inputPdfDataremoveBlankPages = null, Expression<Func<inputPdfDataremoveBookmarksInput>> inputPdfDataremoveBookmarks = null, Expression<Func<inputPdfDataremoveEmbeddedFilesInput>> inputPdfDataremoveEmbeddedFiles = null, Expression<Func<inputPdfDataremoveFormFieldsInput>> inputPdfDataremoveFormFields = null, Expression<Func<inputPdfDataremoveHyperlinksInput>> inputPdfDataremoveHyperlinks = null, Expression<Func<inputPdfDataremoveJavaScriptInput>> inputPdfDataremoveJavaScript = null, Expression<Func<inputPdfDataremoveMetadataInput>> inputPdfDataremoveMetadata = null, Expression<Func<inputPdfDataremovePageThumbnailsInput>> inputPdfDataremovePageThumbnails = null, Expression<Func<inputPdfDatapackFontsInput>> inputPdfDatapackFonts = null, Expression<Func<inputPdfDatapackDocumentInput>> inputPdfDatapackDocument = null, Expression<Func<inputPdfDatarecompressImagesInput>> inputPdfDatarecompressImages = null, Expression<Func<inputPdfDataenableMRCInput>> inputPdfDataenableMRC = null, Expression<Func<int>> inputPdfDatadownscaleResolutionMRC = null, Expression<Func<inputPdfDatapreserveSmoothingInput>> inputPdfDatapreserveSmoothing = null, Expression<Func<inputPdfDataimageQualityInput>> inputPdfDataimageQuality = null, Expression<Func<inputPdfDatadownscaleImagesInput>> inputPdfDatadownscaleImages = null, Expression<Func<int>> inputPdfDatadownscaleResolution = null, Expression<Func<inputPdfDataenableColorDetectionInput>> inputPdfDataenableColorDetection = null, Expression<Func<inputPdfDataenableCharRepairInput>> inputPdfDataenableCharRepair = null, Expression<Func<inputPdfDataenableJPEG2000Input>> inputPdfDataenableJPEG2000 = null, Expression<Func<inputPdfDataenableJBIG2Input>> inputPdfDataenableJBIG2 = null, Expression<Func<int>> inputPdfDatajBIG2PMSThreshold = null, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = inputPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = inputPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataremoveAnnotations = inputPdfDataremoveAnnotations == null ? null : WorkflowExpression.Compile(inputPdfDataremoveAnnotations);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveAnnotations, nameof(inputPdfDataremoveAnnotations), required: false);
            var __workflow_inputPdfDataremoveBlankPages = inputPdfDataremoveBlankPages == null ? null : WorkflowExpression.Compile(inputPdfDataremoveBlankPages);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveBlankPages, nameof(inputPdfDataremoveBlankPages), required: false);
            var __workflow_inputPdfDataremoveBookmarks = inputPdfDataremoveBookmarks == null ? null : WorkflowExpression.Compile(inputPdfDataremoveBookmarks);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveBookmarks, nameof(inputPdfDataremoveBookmarks), required: false);
            var __workflow_inputPdfDataremoveEmbeddedFiles = inputPdfDataremoveEmbeddedFiles == null ? null : WorkflowExpression.Compile(inputPdfDataremoveEmbeddedFiles);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveEmbeddedFiles, nameof(inputPdfDataremoveEmbeddedFiles), required: false);
            var __workflow_inputPdfDataremoveFormFields = inputPdfDataremoveFormFields == null ? null : WorkflowExpression.Compile(inputPdfDataremoveFormFields);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveFormFields, nameof(inputPdfDataremoveFormFields), required: false);
            var __workflow_inputPdfDataremoveHyperlinks = inputPdfDataremoveHyperlinks == null ? null : WorkflowExpression.Compile(inputPdfDataremoveHyperlinks);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveHyperlinks, nameof(inputPdfDataremoveHyperlinks), required: false);
            var __workflow_inputPdfDataremoveJavaScript = inputPdfDataremoveJavaScript == null ? null : WorkflowExpression.Compile(inputPdfDataremoveJavaScript);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveJavaScript, nameof(inputPdfDataremoveJavaScript), required: false);
            var __workflow_inputPdfDataremoveMetadata = inputPdfDataremoveMetadata == null ? null : WorkflowExpression.Compile(inputPdfDataremoveMetadata);
            WorkflowExpression.Validate(__workflow_inputPdfDataremoveMetadata, nameof(inputPdfDataremoveMetadata), required: false);
            var __workflow_inputPdfDataremovePageThumbnails = inputPdfDataremovePageThumbnails == null ? null : WorkflowExpression.Compile(inputPdfDataremovePageThumbnails);
            WorkflowExpression.Validate(__workflow_inputPdfDataremovePageThumbnails, nameof(inputPdfDataremovePageThumbnails), required: false);
            var __workflow_inputPdfDatapackFonts = inputPdfDatapackFonts == null ? null : WorkflowExpression.Compile(inputPdfDatapackFonts);
            WorkflowExpression.Validate(__workflow_inputPdfDatapackFonts, nameof(inputPdfDatapackFonts), required: false);
            var __workflow_inputPdfDatapackDocument = inputPdfDatapackDocument == null ? null : WorkflowExpression.Compile(inputPdfDatapackDocument);
            WorkflowExpression.Validate(__workflow_inputPdfDatapackDocument, nameof(inputPdfDatapackDocument), required: false);
            var __workflow_inputPdfDatarecompressImages = inputPdfDatarecompressImages == null ? null : WorkflowExpression.Compile(inputPdfDatarecompressImages);
            WorkflowExpression.Validate(__workflow_inputPdfDatarecompressImages, nameof(inputPdfDatarecompressImages), required: false);
            var __workflow_inputPdfDataenableMRC = inputPdfDataenableMRC == null ? null : WorkflowExpression.Compile(inputPdfDataenableMRC);
            WorkflowExpression.Validate(__workflow_inputPdfDataenableMRC, nameof(inputPdfDataenableMRC), required: false);
            var __workflow_inputPdfDatadownscaleResolutionMRC = inputPdfDatadownscaleResolutionMRC == null ? null : WorkflowExpression.Compile(inputPdfDatadownscaleResolutionMRC);
            WorkflowExpression.Validate(__workflow_inputPdfDatadownscaleResolutionMRC, nameof(inputPdfDatadownscaleResolutionMRC), required: false);
            var __workflow_inputPdfDatapreserveSmoothing = inputPdfDatapreserveSmoothing == null ? null : WorkflowExpression.Compile(inputPdfDatapreserveSmoothing);
            WorkflowExpression.Validate(__workflow_inputPdfDatapreserveSmoothing, nameof(inputPdfDatapreserveSmoothing), required: false);
            var __workflow_inputPdfDataimageQuality = inputPdfDataimageQuality == null ? null : WorkflowExpression.Compile(inputPdfDataimageQuality);
            WorkflowExpression.Validate(__workflow_inputPdfDataimageQuality, nameof(inputPdfDataimageQuality), required: false);
            var __workflow_inputPdfDatadownscaleImages = inputPdfDatadownscaleImages == null ? null : WorkflowExpression.Compile(inputPdfDatadownscaleImages);
            WorkflowExpression.Validate(__workflow_inputPdfDatadownscaleImages, nameof(inputPdfDatadownscaleImages), required: false);
            var __workflow_inputPdfDatadownscaleResolution = inputPdfDatadownscaleResolution == null ? null : WorkflowExpression.Compile(inputPdfDatadownscaleResolution);
            WorkflowExpression.Validate(__workflow_inputPdfDatadownscaleResolution, nameof(inputPdfDatadownscaleResolution), required: false);
            var __workflow_inputPdfDataenableColorDetection = inputPdfDataenableColorDetection == null ? null : WorkflowExpression.Compile(inputPdfDataenableColorDetection);
            WorkflowExpression.Validate(__workflow_inputPdfDataenableColorDetection, nameof(inputPdfDataenableColorDetection), required: false);
            var __workflow_inputPdfDataenableCharRepair = inputPdfDataenableCharRepair == null ? null : WorkflowExpression.Compile(inputPdfDataenableCharRepair);
            WorkflowExpression.Validate(__workflow_inputPdfDataenableCharRepair, nameof(inputPdfDataenableCharRepair), required: false);
            var __workflow_inputPdfDataenableJPEG2000 = inputPdfDataenableJPEG2000 == null ? null : WorkflowExpression.Compile(inputPdfDataenableJPEG2000);
            WorkflowExpression.Validate(__workflow_inputPdfDataenableJPEG2000, nameof(inputPdfDataenableJPEG2000), required: false);
            var __workflow_inputPdfDataenableJBIG2 = inputPdfDataenableJBIG2 == null ? null : WorkflowExpression.Compile(inputPdfDataenableJBIG2);
            WorkflowExpression.Validate(__workflow_inputPdfDataenableJBIG2, nameof(inputPdfDataenableJBIG2), required: false);
            var __workflow_inputPdfDatajBIG2PMSThreshold = inputPdfDatajBIG2PMSThreshold == null ? null : WorkflowExpression.Compile(inputPdfDatajBIG2PMSThreshold);
            WorkflowExpression.Validate(__workflow_inputPdfDatajBIG2PMSThreshold, nameof(inputPdfDatajBIG2PMSThreshold), required: false);
            var __workflow_inputPdfDataoverrideSettings = inputPdfDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputPdfDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            var __workflow_inputPdfDatafailOnError = inputPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> Convert(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDataoutputFormatInput>> inputDataoutputFormat, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<string>> inputDatatemplateFileContent = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataoutputFormat = inputDataoutputFormat == null ? null : WorkflowExpression.Compile(inputDataoutputFormat);
            WorkflowExpression.Validate(__workflow_inputDataoutputFormat, nameof(inputDataoutputFormat), required: true);
            var __workflow_inputDataoverrideSettings = inputDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            var __workflow_inputDatatemplateFileContent = inputDatatemplateFileContent == null ? null : WorkflowExpression.Compile(inputDatatemplateFileContent);
            WorkflowExpression.Validate(__workflow_inputDatatemplateFileContent, nameof(inputDatatemplateFileContent), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertCad(Expression<Func<string>> inputCadDatasourceFileName, Expression<Func<string>> inputCadDatasourceFileContent, Expression<Func<inputCadDatapaperSizeInput>> inputCadDatapaperSize = null, Expression<Func<string>> inputCadDatapaperSizeCustom = null, Expression<Func<string>> inputCadDatapageMargins = null, Expression<Func<string>> inputCadDatabackgroundColor = null, Expression<Func<inputCadDataforegroundColorInput>> inputCadDataforegroundColor = null, Expression<Func<string>> inputCadDataforegroundColorCustom = null, Expression<Func<inputCadDataemptyLayoutDetectionInput>> inputCadDataemptyLayoutDetection = null, Expression<Func<inputCadDatalayoutSortOrderInput>> inputCadDatalayoutSortOrder = null, Expression<Func<int>> inputCadDatastartPage = null, Expression<Func<int>> inputCadDataendPage = null, Expression<Func<string>> inputCadDataoverrideSettings = null, Expression<Func<bool>> inputCadDatafailOnError = null)
        {
            var __workflow_inputCadDatasourceFileName = inputCadDatasourceFileName == null ? null : WorkflowExpression.Compile(inputCadDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputCadDatasourceFileName, nameof(inputCadDatasourceFileName), required: true);
            var __workflow_inputCadDatasourceFileContent = inputCadDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputCadDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputCadDatasourceFileContent, nameof(inputCadDatasourceFileContent), required: true);
            var __workflow_inputCadDatapaperSize = inputCadDatapaperSize == null ? null : WorkflowExpression.Compile(inputCadDatapaperSize);
            WorkflowExpression.Validate(__workflow_inputCadDatapaperSize, nameof(inputCadDatapaperSize), required: false);
            var __workflow_inputCadDatapaperSizeCustom = inputCadDatapaperSizeCustom == null ? null : WorkflowExpression.Compile(inputCadDatapaperSizeCustom);
            WorkflowExpression.Validate(__workflow_inputCadDatapaperSizeCustom, nameof(inputCadDatapaperSizeCustom), required: false);
            var __workflow_inputCadDatapageMargins = inputCadDatapageMargins == null ? null : WorkflowExpression.Compile(inputCadDatapageMargins);
            WorkflowExpression.Validate(__workflow_inputCadDatapageMargins, nameof(inputCadDatapageMargins), required: false);
            var __workflow_inputCadDatabackgroundColor = inputCadDatabackgroundColor == null ? null : WorkflowExpression.Compile(inputCadDatabackgroundColor);
            WorkflowExpression.Validate(__workflow_inputCadDatabackgroundColor, nameof(inputCadDatabackgroundColor), required: false);
            var __workflow_inputCadDataforegroundColor = inputCadDataforegroundColor == null ? null : WorkflowExpression.Compile(inputCadDataforegroundColor);
            WorkflowExpression.Validate(__workflow_inputCadDataforegroundColor, nameof(inputCadDataforegroundColor), required: false);
            var __workflow_inputCadDataforegroundColorCustom = inputCadDataforegroundColorCustom == null ? null : WorkflowExpression.Compile(inputCadDataforegroundColorCustom);
            WorkflowExpression.Validate(__workflow_inputCadDataforegroundColorCustom, nameof(inputCadDataforegroundColorCustom), required: false);
            var __workflow_inputCadDataemptyLayoutDetection = inputCadDataemptyLayoutDetection == null ? null : WorkflowExpression.Compile(inputCadDataemptyLayoutDetection);
            WorkflowExpression.Validate(__workflow_inputCadDataemptyLayoutDetection, nameof(inputCadDataemptyLayoutDetection), required: false);
            var __workflow_inputCadDatalayoutSortOrder = inputCadDatalayoutSortOrder == null ? null : WorkflowExpression.Compile(inputCadDatalayoutSortOrder);
            WorkflowExpression.Validate(__workflow_inputCadDatalayoutSortOrder, nameof(inputCadDatalayoutSortOrder), required: false);
            var __workflow_inputCadDatastartPage = inputCadDatastartPage == null ? null : WorkflowExpression.Compile(inputCadDatastartPage);
            WorkflowExpression.Validate(__workflow_inputCadDatastartPage, nameof(inputCadDatastartPage), required: false);
            var __workflow_inputCadDataendPage = inputCadDataendPage == null ? null : WorkflowExpression.Compile(inputCadDataendPage);
            WorkflowExpression.Validate(__workflow_inputCadDataendPage, nameof(inputCadDataendPage), required: false);
            var __workflow_inputCadDataoverrideSettings = inputCadDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputCadDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputCadDataoverrideSettings, nameof(inputCadDataoverrideSettings), required: false);
            var __workflow_inputCadDatafailOnError = inputCadDatafailOnError == null ? null : WorkflowExpression.Compile(inputCadDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputCadDatafailOnError, nameof(inputCadDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertEmail(Expression<Func<string>> inputEmailDatasourceFileName, Expression<Func<string>> inputEmailDatasourceFileContent, Expression<Func<bool>> inputEmailDataincludeAttachments = null, Expression<Func<inputEmailDataattachmentActionInput>> inputEmailDataattachmentAction = null, Expression<Func<bool>> inputEmailDataattachmentSummary = null, Expression<Func<inputEmailDataunsupportedAttachmentActionInput>> inputEmailDataunsupportedAttachmentAction = null, Expression<Func<string>> inputEmailDataincludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataexcludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataviewportSize = null, Expression<Func<inputEmailDatapaperSizeInput>> inputEmailDatapaperSize = null, Expression<Func<string>> inputEmailDatapaperSizeCustom = null, Expression<Func<string>> inputEmailDatapageMargins = null, Expression<Func<bool>> inputEmailDataattachmentErrors = null, Expression<Func<int>> inputEmailDataminImageSize = null, Expression<Func<bool>> inputEmailDataofflineMode = null, Expression<Func<int>> inputEmailDatastartPage = null, Expression<Func<int>> inputEmailDataendPage = null, Expression<Func<inputEmailDataconversionQualityInput>> inputEmailDataconversionQuality = null, Expression<Func<string>> inputEmailDataoverrideSettings = null, Expression<Func<bool>> inputEmailDatafailOnError = null)
        {
            var __workflow_inputEmailDatasourceFileName = inputEmailDatasourceFileName == null ? null : WorkflowExpression.Compile(inputEmailDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputEmailDatasourceFileName, nameof(inputEmailDatasourceFileName), required: true);
            var __workflow_inputEmailDatasourceFileContent = inputEmailDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputEmailDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputEmailDatasourceFileContent, nameof(inputEmailDatasourceFileContent), required: true);
            var __workflow_inputEmailDataincludeAttachments = inputEmailDataincludeAttachments == null ? null : WorkflowExpression.Compile(inputEmailDataincludeAttachments);
            WorkflowExpression.Validate(__workflow_inputEmailDataincludeAttachments, nameof(inputEmailDataincludeAttachments), required: false);
            var __workflow_inputEmailDataattachmentAction = inputEmailDataattachmentAction == null ? null : WorkflowExpression.Compile(inputEmailDataattachmentAction);
            WorkflowExpression.Validate(__workflow_inputEmailDataattachmentAction, nameof(inputEmailDataattachmentAction), required: false);
            var __workflow_inputEmailDataattachmentSummary = inputEmailDataattachmentSummary == null ? null : WorkflowExpression.Compile(inputEmailDataattachmentSummary);
            WorkflowExpression.Validate(__workflow_inputEmailDataattachmentSummary, nameof(inputEmailDataattachmentSummary), required: false);
            var __workflow_inputEmailDataunsupportedAttachmentAction = inputEmailDataunsupportedAttachmentAction == null ? null : WorkflowExpression.Compile(inputEmailDataunsupportedAttachmentAction);
            WorkflowExpression.Validate(__workflow_inputEmailDataunsupportedAttachmentAction, nameof(inputEmailDataunsupportedAttachmentAction), required: false);
            var __workflow_inputEmailDataincludeAttachmentFilter = inputEmailDataincludeAttachmentFilter == null ? null : WorkflowExpression.Compile(inputEmailDataincludeAttachmentFilter);
            WorkflowExpression.Validate(__workflow_inputEmailDataincludeAttachmentFilter, nameof(inputEmailDataincludeAttachmentFilter), required: false);
            var __workflow_inputEmailDataexcludeAttachmentFilter = inputEmailDataexcludeAttachmentFilter == null ? null : WorkflowExpression.Compile(inputEmailDataexcludeAttachmentFilter);
            WorkflowExpression.Validate(__workflow_inputEmailDataexcludeAttachmentFilter, nameof(inputEmailDataexcludeAttachmentFilter), required: false);
            var __workflow_inputEmailDataviewportSize = inputEmailDataviewportSize == null ? null : WorkflowExpression.Compile(inputEmailDataviewportSize);
            WorkflowExpression.Validate(__workflow_inputEmailDataviewportSize, nameof(inputEmailDataviewportSize), required: false);
            var __workflow_inputEmailDatapaperSize = inputEmailDatapaperSize == null ? null : WorkflowExpression.Compile(inputEmailDatapaperSize);
            WorkflowExpression.Validate(__workflow_inputEmailDatapaperSize, nameof(inputEmailDatapaperSize), required: false);
            var __workflow_inputEmailDatapaperSizeCustom = inputEmailDatapaperSizeCustom == null ? null : WorkflowExpression.Compile(inputEmailDatapaperSizeCustom);
            WorkflowExpression.Validate(__workflow_inputEmailDatapaperSizeCustom, nameof(inputEmailDatapaperSizeCustom), required: false);
            var __workflow_inputEmailDatapageMargins = inputEmailDatapageMargins == null ? null : WorkflowExpression.Compile(inputEmailDatapageMargins);
            WorkflowExpression.Validate(__workflow_inputEmailDatapageMargins, nameof(inputEmailDatapageMargins), required: false);
            var __workflow_inputEmailDataattachmentErrors = inputEmailDataattachmentErrors == null ? null : WorkflowExpression.Compile(inputEmailDataattachmentErrors);
            WorkflowExpression.Validate(__workflow_inputEmailDataattachmentErrors, nameof(inputEmailDataattachmentErrors), required: false);
            var __workflow_inputEmailDataminImageSize = inputEmailDataminImageSize == null ? null : WorkflowExpression.Compile(inputEmailDataminImageSize);
            WorkflowExpression.Validate(__workflow_inputEmailDataminImageSize, nameof(inputEmailDataminImageSize), required: false);
            var __workflow_inputEmailDataofflineMode = inputEmailDataofflineMode == null ? null : WorkflowExpression.Compile(inputEmailDataofflineMode);
            WorkflowExpression.Validate(__workflow_inputEmailDataofflineMode, nameof(inputEmailDataofflineMode), required: false);
            var __workflow_inputEmailDatastartPage = inputEmailDatastartPage == null ? null : WorkflowExpression.Compile(inputEmailDatastartPage);
            WorkflowExpression.Validate(__workflow_inputEmailDatastartPage, nameof(inputEmailDatastartPage), required: false);
            var __workflow_inputEmailDataendPage = inputEmailDataendPage == null ? null : WorkflowExpression.Compile(inputEmailDataendPage);
            WorkflowExpression.Validate(__workflow_inputEmailDataendPage, nameof(inputEmailDataendPage), required: false);
            var __workflow_inputEmailDataconversionQuality = inputEmailDataconversionQuality == null ? null : WorkflowExpression.Compile(inputEmailDataconversionQuality);
            WorkflowExpression.Validate(__workflow_inputEmailDataconversionQuality, nameof(inputEmailDataconversionQuality), required: false);
            var __workflow_inputEmailDataoverrideSettings = inputEmailDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputEmailDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputEmailDataoverrideSettings, nameof(inputEmailDataoverrideSettings), required: false);
            var __workflow_inputEmailDatafailOnError = inputEmailDatafailOnError == null ? null : WorkflowExpression.Compile(inputEmailDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputEmailDatafailOnError, nameof(inputEmailDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertExcel(Expression<Func<string>> inputExcelDatasourceFileName, Expression<Func<string>> inputExcelDatasourceFileContent, Expression<Func<inputExcelDataoutputFormatInput>> inputExcelDataoutputFormat, Expression<Func<inputExcelDatarangeInput>> inputExcelDatarange = null, Expression<Func<bool>> inputExcelDatarevealHiddenRows = null, Expression<Func<bool>> inputExcelDatarevealHiddenColumns = null, Expression<Func<int>> inputExcelDatafitToPagesWide = null, Expression<Func<int>> inputExcelDatafitToPagesTall = null, Expression<Func<int>> inputExcelDatastartPage = null, Expression<Func<int>> inputExcelDataendPage = null, Expression<Func<inputExcelDataqualityInput>> inputExcelDataquality = null, Expression<Func<string>> inputExcelDataoverrideSettings = null, Expression<Func<bool>> inputExcelDatafailOnError = null)
        {
            var __workflow_inputExcelDatasourceFileName = inputExcelDatasourceFileName == null ? null : WorkflowExpression.Compile(inputExcelDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputExcelDatasourceFileName, nameof(inputExcelDatasourceFileName), required: true);
            var __workflow_inputExcelDatasourceFileContent = inputExcelDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputExcelDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputExcelDatasourceFileContent, nameof(inputExcelDatasourceFileContent), required: true);
            var __workflow_inputExcelDataoutputFormat = inputExcelDataoutputFormat == null ? null : WorkflowExpression.Compile(inputExcelDataoutputFormat);
            WorkflowExpression.Validate(__workflow_inputExcelDataoutputFormat, nameof(inputExcelDataoutputFormat), required: true);
            var __workflow_inputExcelDatarange = inputExcelDatarange == null ? null : WorkflowExpression.Compile(inputExcelDatarange);
            WorkflowExpression.Validate(__workflow_inputExcelDatarange, nameof(inputExcelDatarange), required: false);
            var __workflow_inputExcelDatarevealHiddenRows = inputExcelDatarevealHiddenRows == null ? null : WorkflowExpression.Compile(inputExcelDatarevealHiddenRows);
            WorkflowExpression.Validate(__workflow_inputExcelDatarevealHiddenRows, nameof(inputExcelDatarevealHiddenRows), required: false);
            var __workflow_inputExcelDatarevealHiddenColumns = inputExcelDatarevealHiddenColumns == null ? null : WorkflowExpression.Compile(inputExcelDatarevealHiddenColumns);
            WorkflowExpression.Validate(__workflow_inputExcelDatarevealHiddenColumns, nameof(inputExcelDatarevealHiddenColumns), required: false);
            var __workflow_inputExcelDatafitToPagesWide = inputExcelDatafitToPagesWide == null ? null : WorkflowExpression.Compile(inputExcelDatafitToPagesWide);
            WorkflowExpression.Validate(__workflow_inputExcelDatafitToPagesWide, nameof(inputExcelDatafitToPagesWide), required: false);
            var __workflow_inputExcelDatafitToPagesTall = inputExcelDatafitToPagesTall == null ? null : WorkflowExpression.Compile(inputExcelDatafitToPagesTall);
            WorkflowExpression.Validate(__workflow_inputExcelDatafitToPagesTall, nameof(inputExcelDatafitToPagesTall), required: false);
            var __workflow_inputExcelDatastartPage = inputExcelDatastartPage == null ? null : WorkflowExpression.Compile(inputExcelDatastartPage);
            WorkflowExpression.Validate(__workflow_inputExcelDatastartPage, nameof(inputExcelDatastartPage), required: false);
            var __workflow_inputExcelDataendPage = inputExcelDataendPage == null ? null : WorkflowExpression.Compile(inputExcelDataendPage);
            WorkflowExpression.Validate(__workflow_inputExcelDataendPage, nameof(inputExcelDataendPage), required: false);
            var __workflow_inputExcelDataquality = inputExcelDataquality == null ? null : WorkflowExpression.Compile(inputExcelDataquality);
            WorkflowExpression.Validate(__workflow_inputExcelDataquality, nameof(inputExcelDataquality), required: false);
            var __workflow_inputExcelDataoverrideSettings = inputExcelDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputExcelDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputExcelDataoverrideSettings, nameof(inputExcelDataoverrideSettings), required: false);
            var __workflow_inputExcelDatafailOnError = inputExcelDatafailOnError == null ? null : WorkflowExpression.Compile(inputExcelDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputExcelDatafailOnError, nameof(inputExcelDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertHtml(Expression<Func<string>> inputDatasourceURLOrHTML, Expression<Func<inputDatapageOrientationInput>> inputDatapageOrientation = null, Expression<Func<inputDatamediaTypeInput>> inputDatamediaType = null, Expression<Func<inputDataauthenticationTypeInput>> inputDataauthenticationType = null, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDataviewportSize = null, Expression<Func<int>> inputDataconversionDelay = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceURLOrHTML = inputDatasourceURLOrHTML == null ? null : WorkflowExpression.Compile(inputDatasourceURLOrHTML);
            WorkflowExpression.Validate(__workflow_inputDatasourceURLOrHTML, nameof(inputDatasourceURLOrHTML), required: true);
            var __workflow_inputDatapageOrientation = inputDatapageOrientation == null ? null : WorkflowExpression.Compile(inputDatapageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatapageOrientation, nameof(inputDatapageOrientation), required: false);
            var __workflow_inputDatamediaType = inputDatamediaType == null ? null : WorkflowExpression.Compile(inputDatamediaType);
            WorkflowExpression.Validate(__workflow_inputDatamediaType, nameof(inputDatamediaType), required: false);
            var __workflow_inputDataauthenticationType = inputDataauthenticationType == null ? null : WorkflowExpression.Compile(inputDataauthenticationType);
            WorkflowExpression.Validate(__workflow_inputDataauthenticationType, nameof(inputDataauthenticationType), required: false);
            var __workflow_inputDatauserName = inputDatauserName == null ? null : WorkflowExpression.Compile(inputDatauserName);
            WorkflowExpression.Validate(__workflow_inputDatauserName, nameof(inputDatauserName), required: false);
            var __workflow_inputDatapassword = inputDatapassword == null ? null : WorkflowExpression.Compile(inputDatapassword);
            WorkflowExpression.Validate(__workflow_inputDatapassword, nameof(inputDatapassword), required: false);
            var __workflow_inputDataviewportSize = inputDataviewportSize == null ? null : WorkflowExpression.Compile(inputDataviewportSize);
            WorkflowExpression.Validate(__workflow_inputDataviewportSize, nameof(inputDataviewportSize), required: false);
            var __workflow_inputDataconversionDelay = inputDataconversionDelay == null ? null : WorkflowExpression.Compile(inputDataconversionDelay);
            WorkflowExpression.Validate(__workflow_inputDataconversionDelay, nameof(inputDataconversionDelay), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertInfopath(Expression<Func<string>> inputInfopathDatasourceFileName, Expression<Func<string>> inputInfopathDatasourceFileContent, Expression<Func<inputInfopathDataoutputFormatInput>> inputInfopathDataoutputFormat, Expression<Func<string>> inputInfopathDatatemplateFileContent = null, Expression<Func<string>> inputInfopathDataviewNames = null, Expression<Func<bool>> inputInfopathDataincludeAttachment = null, Expression<Func<inputInfopathDataattachmentActionInput>> inputInfopathDataattachmentAction = null, Expression<Func<inputInfopathDataunsupportedAttachmentActionInput>> inputInfopathDataunsupportedAttachmentAction = null, Expression<Func<bool>> inputInfopathDatabreakMergeOnError = null, Expression<Func<string>> inputInfopathDataincludeAttachmentFilter = null, Expression<Func<string>> inputInfopathDataexcludeAttachmentFilter = null, Expression<Func<inputInfopathDatadefaultPaperSizeInput>> inputInfopathDatadefaultPaperSize = null, Expression<Func<string>> inputInfopathDatadefaultPaperSizeCustom = null, Expression<Func<inputInfopathDataforcePaperSizeInput>> inputInfopathDataforcePaperSize = null, Expression<Func<string>> inputInfopathDataforcePaperSizeCustom = null, Expression<Func<inputInfopathDatadefaultPageOrientationInput>> inputInfopathDatadefaultPageOrientation = null, Expression<Func<inputInfopathDataforcePageOrientationInput>> inputInfopathDataforcePageOrientation = null, Expression<Func<int>> inputInfopathDatastartPage = null, Expression<Func<int>> inputInfopathDataendPage = null, Expression<Func<inputInfopathDataconversionQualityInput>> inputInfopathDataconversionQuality = null, Expression<Func<string>> inputInfopathDataoverrideSettings = null, Expression<Func<bool>> inputInfopathDatafailOnError = null)
        {
            var __workflow_inputInfopathDatasourceFileName = inputInfopathDatasourceFileName == null ? null : WorkflowExpression.Compile(inputInfopathDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputInfopathDatasourceFileName, nameof(inputInfopathDatasourceFileName), required: true);
            var __workflow_inputInfopathDatasourceFileContent = inputInfopathDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputInfopathDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputInfopathDatasourceFileContent, nameof(inputInfopathDatasourceFileContent), required: true);
            var __workflow_inputInfopathDataoutputFormat = inputInfopathDataoutputFormat == null ? null : WorkflowExpression.Compile(inputInfopathDataoutputFormat);
            WorkflowExpression.Validate(__workflow_inputInfopathDataoutputFormat, nameof(inputInfopathDataoutputFormat), required: true);
            var __workflow_inputInfopathDatatemplateFileContent = inputInfopathDatatemplateFileContent == null ? null : WorkflowExpression.Compile(inputInfopathDatatemplateFileContent);
            WorkflowExpression.Validate(__workflow_inputInfopathDatatemplateFileContent, nameof(inputInfopathDatatemplateFileContent), required: false);
            var __workflow_inputInfopathDataviewNames = inputInfopathDataviewNames == null ? null : WorkflowExpression.Compile(inputInfopathDataviewNames);
            WorkflowExpression.Validate(__workflow_inputInfopathDataviewNames, nameof(inputInfopathDataviewNames), required: false);
            var __workflow_inputInfopathDataincludeAttachment = inputInfopathDataincludeAttachment == null ? null : WorkflowExpression.Compile(inputInfopathDataincludeAttachment);
            WorkflowExpression.Validate(__workflow_inputInfopathDataincludeAttachment, nameof(inputInfopathDataincludeAttachment), required: false);
            var __workflow_inputInfopathDataattachmentAction = inputInfopathDataattachmentAction == null ? null : WorkflowExpression.Compile(inputInfopathDataattachmentAction);
            WorkflowExpression.Validate(__workflow_inputInfopathDataattachmentAction, nameof(inputInfopathDataattachmentAction), required: false);
            var __workflow_inputInfopathDataunsupportedAttachmentAction = inputInfopathDataunsupportedAttachmentAction == null ? null : WorkflowExpression.Compile(inputInfopathDataunsupportedAttachmentAction);
            WorkflowExpression.Validate(__workflow_inputInfopathDataunsupportedAttachmentAction, nameof(inputInfopathDataunsupportedAttachmentAction), required: false);
            var __workflow_inputInfopathDatabreakMergeOnError = inputInfopathDatabreakMergeOnError == null ? null : WorkflowExpression.Compile(inputInfopathDatabreakMergeOnError);
            WorkflowExpression.Validate(__workflow_inputInfopathDatabreakMergeOnError, nameof(inputInfopathDatabreakMergeOnError), required: false);
            var __workflow_inputInfopathDataincludeAttachmentFilter = inputInfopathDataincludeAttachmentFilter == null ? null : WorkflowExpression.Compile(inputInfopathDataincludeAttachmentFilter);
            WorkflowExpression.Validate(__workflow_inputInfopathDataincludeAttachmentFilter, nameof(inputInfopathDataincludeAttachmentFilter), required: false);
            var __workflow_inputInfopathDataexcludeAttachmentFilter = inputInfopathDataexcludeAttachmentFilter == null ? null : WorkflowExpression.Compile(inputInfopathDataexcludeAttachmentFilter);
            WorkflowExpression.Validate(__workflow_inputInfopathDataexcludeAttachmentFilter, nameof(inputInfopathDataexcludeAttachmentFilter), required: false);
            var __workflow_inputInfopathDatadefaultPaperSize = inputInfopathDatadefaultPaperSize == null ? null : WorkflowExpression.Compile(inputInfopathDatadefaultPaperSize);
            WorkflowExpression.Validate(__workflow_inputInfopathDatadefaultPaperSize, nameof(inputInfopathDatadefaultPaperSize), required: false);
            var __workflow_inputInfopathDatadefaultPaperSizeCustom = inputInfopathDatadefaultPaperSizeCustom == null ? null : WorkflowExpression.Compile(inputInfopathDatadefaultPaperSizeCustom);
            WorkflowExpression.Validate(__workflow_inputInfopathDatadefaultPaperSizeCustom, nameof(inputInfopathDatadefaultPaperSizeCustom), required: false);
            var __workflow_inputInfopathDataforcePaperSize = inputInfopathDataforcePaperSize == null ? null : WorkflowExpression.Compile(inputInfopathDataforcePaperSize);
            WorkflowExpression.Validate(__workflow_inputInfopathDataforcePaperSize, nameof(inputInfopathDataforcePaperSize), required: false);
            var __workflow_inputInfopathDataforcePaperSizeCustom = inputInfopathDataforcePaperSizeCustom == null ? null : WorkflowExpression.Compile(inputInfopathDataforcePaperSizeCustom);
            WorkflowExpression.Validate(__workflow_inputInfopathDataforcePaperSizeCustom, nameof(inputInfopathDataforcePaperSizeCustom), required: false);
            var __workflow_inputInfopathDatadefaultPageOrientation = inputInfopathDatadefaultPageOrientation == null ? null : WorkflowExpression.Compile(inputInfopathDatadefaultPageOrientation);
            WorkflowExpression.Validate(__workflow_inputInfopathDatadefaultPageOrientation, nameof(inputInfopathDatadefaultPageOrientation), required: false);
            var __workflow_inputInfopathDataforcePageOrientation = inputInfopathDataforcePageOrientation == null ? null : WorkflowExpression.Compile(inputInfopathDataforcePageOrientation);
            WorkflowExpression.Validate(__workflow_inputInfopathDataforcePageOrientation, nameof(inputInfopathDataforcePageOrientation), required: false);
            var __workflow_inputInfopathDatastartPage = inputInfopathDatastartPage == null ? null : WorkflowExpression.Compile(inputInfopathDatastartPage);
            WorkflowExpression.Validate(__workflow_inputInfopathDatastartPage, nameof(inputInfopathDatastartPage), required: false);
            var __workflow_inputInfopathDataendPage = inputInfopathDataendPage == null ? null : WorkflowExpression.Compile(inputInfopathDataendPage);
            WorkflowExpression.Validate(__workflow_inputInfopathDataendPage, nameof(inputInfopathDataendPage), required: false);
            var __workflow_inputInfopathDataconversionQuality = inputInfopathDataconversionQuality == null ? null : WorkflowExpression.Compile(inputInfopathDataconversionQuality);
            WorkflowExpression.Validate(__workflow_inputInfopathDataconversionQuality, nameof(inputInfopathDataconversionQuality), required: false);
            var __workflow_inputInfopathDataoverrideSettings = inputInfopathDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputInfopathDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputInfopathDataoverrideSettings, nameof(inputInfopathDataoverrideSettings), required: false);
            var __workflow_inputInfopathDatafailOnError = inputInfopathDatafailOnError == null ? null : WorkflowExpression.Compile(inputInfopathDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputInfopathDatafailOnError, nameof(inputInfopathDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPdfa(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDatapDFProfileInput>> inputPdfDatapDFProfile, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = inputPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = inputPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapDFProfile = inputPdfDatapDFProfile == null ? null : WorkflowExpression.Compile(inputPdfDatapDFProfile);
            WorkflowExpression.Validate(__workflow_inputPdfDatapDFProfile, nameof(inputPdfDatapDFProfile), required: true);
            var __workflow_inputPdfDataoverrideSettings = inputPdfDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputPdfDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            var __workflow_inputPdfDatafailOnError = inputPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPowerpoint(Expression<Func<string>> inputPowerpointDatasourceFileName, Expression<Func<string>> inputPowerpointDatasourceFileContent, Expression<Func<inputPowerpointDataoutputFormatInput>> inputPowerpointDataoutputFormat, Expression<Func<inputPowerpointDatarangeInput>> inputPowerpointDatarange = null, Expression<Func<inputPowerpointDataprintLayoutHandoutsInput>> inputPowerpointDataprintLayoutHandouts = null, Expression<Func<bool>> inputPowerpointDataframeSlides = null, Expression<Func<int>> inputPowerpointDatastartPage = null, Expression<Func<int>> inputPowerpointDataendPage = null, Expression<Func<inputPowerpointDataqualityInput>> inputPowerpointDataquality = null, Expression<Func<string>> inputPowerpointDataoverrideSettings = null, Expression<Func<bool>> inputPowerpointDatafailOnError = null)
        {
            var __workflow_inputPowerpointDatasourceFileName = inputPowerpointDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPowerpointDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPowerpointDatasourceFileName, nameof(inputPowerpointDatasourceFileName), required: true);
            var __workflow_inputPowerpointDatasourceFileContent = inputPowerpointDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPowerpointDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPowerpointDatasourceFileContent, nameof(inputPowerpointDatasourceFileContent), required: true);
            var __workflow_inputPowerpointDataoutputFormat = inputPowerpointDataoutputFormat == null ? null : WorkflowExpression.Compile(inputPowerpointDataoutputFormat);
            WorkflowExpression.Validate(__workflow_inputPowerpointDataoutputFormat, nameof(inputPowerpointDataoutputFormat), required: true);
            var __workflow_inputPowerpointDatarange = inputPowerpointDatarange == null ? null : WorkflowExpression.Compile(inputPowerpointDatarange);
            WorkflowExpression.Validate(__workflow_inputPowerpointDatarange, nameof(inputPowerpointDatarange), required: false);
            var __workflow_inputPowerpointDataprintLayoutHandouts = inputPowerpointDataprintLayoutHandouts == null ? null : WorkflowExpression.Compile(inputPowerpointDataprintLayoutHandouts);
            WorkflowExpression.Validate(__workflow_inputPowerpointDataprintLayoutHandouts, nameof(inputPowerpointDataprintLayoutHandouts), required: false);
            var __workflow_inputPowerpointDataframeSlides = inputPowerpointDataframeSlides == null ? null : WorkflowExpression.Compile(inputPowerpointDataframeSlides);
            WorkflowExpression.Validate(__workflow_inputPowerpointDataframeSlides, nameof(inputPowerpointDataframeSlides), required: false);
            var __workflow_inputPowerpointDatastartPage = inputPowerpointDatastartPage == null ? null : WorkflowExpression.Compile(inputPowerpointDatastartPage);
            WorkflowExpression.Validate(__workflow_inputPowerpointDatastartPage, nameof(inputPowerpointDatastartPage), required: false);
            var __workflow_inputPowerpointDataendPage = inputPowerpointDataendPage == null ? null : WorkflowExpression.Compile(inputPowerpointDataendPage);
            WorkflowExpression.Validate(__workflow_inputPowerpointDataendPage, nameof(inputPowerpointDataendPage), required: false);
            var __workflow_inputPowerpointDataquality = inputPowerpointDataquality == null ? null : WorkflowExpression.Compile(inputPowerpointDataquality);
            WorkflowExpression.Validate(__workflow_inputPowerpointDataquality, nameof(inputPowerpointDataquality), required: false);
            var __workflow_inputPowerpointDataoverrideSettings = inputPowerpointDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputPowerpointDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputPowerpointDataoverrideSettings, nameof(inputPowerpointDataoverrideSettings), required: false);
            var __workflow_inputPowerpointDatafailOnError = inputPowerpointDatafailOnError == null ? null : WorkflowExpression.Compile(inputPowerpointDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPowerpointDatafailOnError, nameof(inputPowerpointDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertVisio(Expression<Func<string>> inputVisioDatasourceFileName, Expression<Func<string>> inputVisioDatasourceFileContent, Expression<Func<inputVisioDataoutputFormatInput>> inputVisioDataoutputFormat, Expression<Func<inputVisioDatarangeInput>> inputVisioDatarange = null, Expression<Func<int>> inputVisioDatastartPage = null, Expression<Func<int>> inputVisioDataendPage = null, Expression<Func<inputVisioDataqualityInput>> inputVisioDataquality = null, Expression<Func<string>> inputVisioDataoverrideSettings = null, Expression<Func<bool>> inputVisioDatafailOnError = null)
        {
            var __workflow_inputVisioDatasourceFileName = inputVisioDatasourceFileName == null ? null : WorkflowExpression.Compile(inputVisioDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputVisioDatasourceFileName, nameof(inputVisioDatasourceFileName), required: true);
            var __workflow_inputVisioDatasourceFileContent = inputVisioDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputVisioDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputVisioDatasourceFileContent, nameof(inputVisioDatasourceFileContent), required: true);
            var __workflow_inputVisioDataoutputFormat = inputVisioDataoutputFormat == null ? null : WorkflowExpression.Compile(inputVisioDataoutputFormat);
            WorkflowExpression.Validate(__workflow_inputVisioDataoutputFormat, nameof(inputVisioDataoutputFormat), required: true);
            var __workflow_inputVisioDatarange = inputVisioDatarange == null ? null : WorkflowExpression.Compile(inputVisioDatarange);
            WorkflowExpression.Validate(__workflow_inputVisioDatarange, nameof(inputVisioDatarange), required: false);
            var __workflow_inputVisioDatastartPage = inputVisioDatastartPage == null ? null : WorkflowExpression.Compile(inputVisioDatastartPage);
            WorkflowExpression.Validate(__workflow_inputVisioDatastartPage, nameof(inputVisioDatastartPage), required: false);
            var __workflow_inputVisioDataendPage = inputVisioDataendPage == null ? null : WorkflowExpression.Compile(inputVisioDataendPage);
            WorkflowExpression.Validate(__workflow_inputVisioDataendPage, nameof(inputVisioDataendPage), required: false);
            var __workflow_inputVisioDataquality = inputVisioDataquality == null ? null : WorkflowExpression.Compile(inputVisioDataquality);
            WorkflowExpression.Validate(__workflow_inputVisioDataquality, nameof(inputVisioDataquality), required: false);
            var __workflow_inputVisioDataoverrideSettings = inputVisioDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputVisioDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputVisioDataoverrideSettings, nameof(inputVisioDataoverrideSettings), required: false);
            var __workflow_inputVisioDatafailOnError = inputVisioDatafailOnError == null ? null : WorkflowExpression.Compile(inputVisioDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputVisioDatafailOnError, nameof(inputVisioDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertWord(Expression<Func<string>> inputWordDatasourceFileName, Expression<Func<string>> inputWordDatasourceFileContent, Expression<Func<inputWordDataoutputFormatInput>> inputWordDataoutputFormat, Expression<Func<inputWordDatadisplayForReviewInput>> inputWordDatadisplayForReview = null, Expression<Func<inputWordDatareviewMarkupModeInput>> inputWordDatareviewMarkupMode = null, Expression<Func<inputWordDatagenerateBookmarksInput>> inputWordDatagenerateBookmarks = null, Expression<Func<int>> inputWordDatastartPage = null, Expression<Func<int>> inputWordDataendPage = null, Expression<Func<inputWordDataqualityInput>> inputWordDataquality = null, Expression<Func<string>> inputWordDataoverrideSettings = null, Expression<Func<bool>> inputWordDatafailOnError = null)
        {
            var __workflow_inputWordDatasourceFileName = inputWordDatasourceFileName == null ? null : WorkflowExpression.Compile(inputWordDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputWordDatasourceFileName, nameof(inputWordDatasourceFileName), required: true);
            var __workflow_inputWordDatasourceFileContent = inputWordDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputWordDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputWordDatasourceFileContent, nameof(inputWordDatasourceFileContent), required: true);
            var __workflow_inputWordDataoutputFormat = inputWordDataoutputFormat == null ? null : WorkflowExpression.Compile(inputWordDataoutputFormat);
            WorkflowExpression.Validate(__workflow_inputWordDataoutputFormat, nameof(inputWordDataoutputFormat), required: true);
            var __workflow_inputWordDatadisplayForReview = inputWordDatadisplayForReview == null ? null : WorkflowExpression.Compile(inputWordDatadisplayForReview);
            WorkflowExpression.Validate(__workflow_inputWordDatadisplayForReview, nameof(inputWordDatadisplayForReview), required: false);
            var __workflow_inputWordDatareviewMarkupMode = inputWordDatareviewMarkupMode == null ? null : WorkflowExpression.Compile(inputWordDatareviewMarkupMode);
            WorkflowExpression.Validate(__workflow_inputWordDatareviewMarkupMode, nameof(inputWordDatareviewMarkupMode), required: false);
            var __workflow_inputWordDatagenerateBookmarks = inputWordDatagenerateBookmarks == null ? null : WorkflowExpression.Compile(inputWordDatagenerateBookmarks);
            WorkflowExpression.Validate(__workflow_inputWordDatagenerateBookmarks, nameof(inputWordDatagenerateBookmarks), required: false);
            var __workflow_inputWordDatastartPage = inputWordDatastartPage == null ? null : WorkflowExpression.Compile(inputWordDatastartPage);
            WorkflowExpression.Validate(__workflow_inputWordDatastartPage, nameof(inputWordDatastartPage), required: false);
            var __workflow_inputWordDataendPage = inputWordDataendPage == null ? null : WorkflowExpression.Compile(inputWordDataendPage);
            WorkflowExpression.Validate(__workflow_inputWordDataendPage, nameof(inputWordDataendPage), required: false);
            var __workflow_inputWordDataquality = inputWordDataquality == null ? null : WorkflowExpression.Compile(inputWordDataquality);
            WorkflowExpression.Validate(__workflow_inputWordDataquality, nameof(inputWordDataquality), required: false);
            var __workflow_inputWordDataoverrideSettings = inputWordDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputWordDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputWordDataoverrideSettings, nameof(inputWordDataoverrideSettings), required: false);
            var __workflow_inputWordDatafailOnError = inputWordDatafailOnError == null ? null : WorkflowExpression.Compile(inputWordDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputWordDatafailOnError, nameof(inputWordDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponseCommon> CopyMetadata(Expression<Func<string>> inputDatasiteUrl, Expression<Func<string>> inputDatasourceFileUrl, Expression<Func<string>> inputDatadestinationFilePath, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDatafieldsToCopy = null, Expression<Func<string>> inputDatadestinationContentType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasiteUrl = inputDatasiteUrl == null ? null : WorkflowExpression.Compile(inputDatasiteUrl);
            WorkflowExpression.Validate(__workflow_inputDatasiteUrl, nameof(inputDatasiteUrl), required: true);
            var __workflow_inputDatasourceFileUrl = inputDatasourceFileUrl == null ? null : WorkflowExpression.Compile(inputDatasourceFileUrl);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileUrl, nameof(inputDatasourceFileUrl), required: true);
            var __workflow_inputDatadestinationFilePath = inputDatadestinationFilePath == null ? null : WorkflowExpression.Compile(inputDatadestinationFilePath);
            WorkflowExpression.Validate(__workflow_inputDatadestinationFilePath, nameof(inputDatadestinationFilePath), required: true);
            var __workflow_inputDatauserName = inputDatauserName == null ? null : WorkflowExpression.Compile(inputDatauserName);
            WorkflowExpression.Validate(__workflow_inputDatauserName, nameof(inputDatauserName), required: false);
            var __workflow_inputDatapassword = inputDatapassword == null ? null : WorkflowExpression.Compile(inputDatapassword);
            WorkflowExpression.Validate(__workflow_inputDatapassword, nameof(inputDatapassword), required: false);
            var __workflow_inputDatafieldsToCopy = inputDatafieldsToCopy == null ? null : WorkflowExpression.Compile(inputDatafieldsToCopy);
            WorkflowExpression.Validate(__workflow_inputDatafieldsToCopy, nameof(inputDatafieldsToCopy), required: false);
            var __workflow_inputDatadestinationContentType = inputDatadestinationContentType == null ? null : WorkflowExpression.Compile(inputDatadestinationContentType);
            WorkflowExpression.Validate(__workflow_inputDatadestinationContentType, nameof(inputDatadestinationContentType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponseCommon>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafillColor = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatafillColor = inputDatafillColor == null ? null : WorkflowExpression.Compile(inputDatafillColor);
            WorkflowExpression.Validate(__workflow_inputDatafillColor, nameof(inputDatafillColor), required: false);
            var __workflow_inputDatalineColor = inputDatalineColor == null ? null : WorkflowExpression.Compile(inputDatalineColor);
            WorkflowExpression.Validate(__workflow_inputDatalineColor, nameof(inputDatalineColor), required: false);
            var __workflow_inputDatalineWidth = inputDatalineWidth == null ? null : WorkflowExpression.Compile(inputDatalineWidth);
            WorkflowExpression.Validate(__workflow_inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ExportFormData(Expression<Func<string>> inputFromPdfDatasourceFileName, Expression<Func<string>> inputFromPdfDatasourceFileContent, Expression<Func<inputFromPdfDataoutputDataFormatInput>> inputFromPdfDataoutputDataFormat, Expression<Func<bool>> inputFromPdfDatafailOnError = null)
        {
            var __workflow_inputFromPdfDatasourceFileName = inputFromPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputFromPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputFromPdfDatasourceFileName, nameof(inputFromPdfDatasourceFileName), required: true);
            var __workflow_inputFromPdfDatasourceFileContent = inputFromPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputFromPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputFromPdfDatasourceFileContent, nameof(inputFromPdfDatasourceFileContent), required: true);
            var __workflow_inputFromPdfDataoutputDataFormat = inputFromPdfDataoutputDataFormat == null ? null : WorkflowExpression.Compile(inputFromPdfDataoutputDataFormat);
            WorkflowExpression.Validate(__workflow_inputFromPdfDataoutputDataFormat, nameof(inputFromPdfDataoutputDataFormat), required: true);
            var __workflow_inputFromPdfDatafailOnError = inputFromPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputFromPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputFromPdfDatafailOnError, nameof(inputFromPdfDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ExtractText(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = inputPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = inputPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapageRange = inputPdfDatapageRange == null ? null : WorkflowExpression.Compile(inputPdfDatapageRange);
            WorkflowExpression.Validate(__workflow_inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDatafailOnError = inputPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ImageWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDataimage, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataimage = inputDataimage == null ? null : WorkflowExpression.Compile(inputDataimage);
            WorkflowExpression.Validate(__workflow_inputDataimage, nameof(inputDataimage), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = inputDatawatermarkBackgroundColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkBackgroundColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = inputDatawatermarkOutlineColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkOutlineColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = inputDatawatermarkOutlineWidth == null ? null : WorkflowExpression.Compile(inputDatawatermarkOutlineWidth);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ImportFormData(Expression<Func<string>> inputXmlDatasourceFileName, Expression<Func<string>> inputXmlDatasourceFileContent, Expression<Func<string>> inputXmlDatapDFFormFileContent = null, Expression<Func<string>> inputXmlDatapDFFormURL = null, Expression<Func<string>> inputXmlDatausername = null, Expression<Func<string>> inputXmlDatadomain = null, Expression<Func<string>> inputXmlDatapassword = null, Expression<Func<inputXmlDataflattenInput>> inputXmlDataflatten = null, Expression<Func<inputXmlDatareadOnlyInput>> inputXmlDatareadOnly = null, Expression<Func<string>> inputXmlDataoverrideSettings = null, Expression<Func<bool>> inputXmlDatafailOnError = null)
        {
            var __workflow_inputXmlDatasourceFileName = inputXmlDatasourceFileName == null ? null : WorkflowExpression.Compile(inputXmlDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputXmlDatasourceFileName, nameof(inputXmlDatasourceFileName), required: true);
            var __workflow_inputXmlDatasourceFileContent = inputXmlDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputXmlDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputXmlDatasourceFileContent, nameof(inputXmlDatasourceFileContent), required: true);
            var __workflow_inputXmlDatapDFFormFileContent = inputXmlDatapDFFormFileContent == null ? null : WorkflowExpression.Compile(inputXmlDatapDFFormFileContent);
            WorkflowExpression.Validate(__workflow_inputXmlDatapDFFormFileContent, nameof(inputXmlDatapDFFormFileContent), required: false);
            var __workflow_inputXmlDatapDFFormURL = inputXmlDatapDFFormURL == null ? null : WorkflowExpression.Compile(inputXmlDatapDFFormURL);
            WorkflowExpression.Validate(__workflow_inputXmlDatapDFFormURL, nameof(inputXmlDatapDFFormURL), required: false);
            var __workflow_inputXmlDatausername = inputXmlDatausername == null ? null : WorkflowExpression.Compile(inputXmlDatausername);
            WorkflowExpression.Validate(__workflow_inputXmlDatausername, nameof(inputXmlDatausername), required: false);
            var __workflow_inputXmlDatadomain = inputXmlDatadomain == null ? null : WorkflowExpression.Compile(inputXmlDatadomain);
            WorkflowExpression.Validate(__workflow_inputXmlDatadomain, nameof(inputXmlDatadomain), required: false);
            var __workflow_inputXmlDatapassword = inputXmlDatapassword == null ? null : WorkflowExpression.Compile(inputXmlDatapassword);
            WorkflowExpression.Validate(__workflow_inputXmlDatapassword, nameof(inputXmlDatapassword), required: false);
            var __workflow_inputXmlDataflatten = inputXmlDataflatten == null ? null : WorkflowExpression.Compile(inputXmlDataflatten);
            WorkflowExpression.Validate(__workflow_inputXmlDataflatten, nameof(inputXmlDataflatten), required: false);
            var __workflow_inputXmlDatareadOnly = inputXmlDatareadOnly == null ? null : WorkflowExpression.Compile(inputXmlDatareadOnly);
            WorkflowExpression.Validate(__workflow_inputXmlDatareadOnly, nameof(inputXmlDatareadOnly), required: false);
            var __workflow_inputXmlDataoverrideSettings = inputXmlDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputXmlDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputXmlDataoverrideSettings, nameof(inputXmlDataoverrideSettings), required: false);
            var __workflow_inputXmlDatafailOnError = inputXmlDatafailOnError == null ? null : WorkflowExpression.Compile(inputXmlDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputXmlDatafailOnError, nameof(inputXmlDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDataoCRLanguage = null, Expression<Func<inputPdfDatadPIInput>> inputPdfDatadPI = null, Expression<Func<inputPdfDatakVPOutputFormatInput>> inputPdfDatakVPOutputFormat = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<inputPdfDataautorotateInput>> inputPdfDataautorotate = null, Expression<Func<inputPdfDatatrimSymbolsInput>> inputPdfDatatrimSymbols = null, Expression<Func<inputPdfDataincludeKeyBoundingBoxInput>> inputPdfDataincludeKeyBoundingBox = null, Expression<Func<inputPdfDataincludeValueBoundingBoxInput>> inputPdfDataincludeValueBoundingBox = null, Expression<Func<inputPdfDataincludePageNumberInput>> inputPdfDataincludePageNumber = null, Expression<Func<inputPdfDataincludeConfidenceInput>> inputPdfDataincludeConfidence = null, Expression<Func<int>> inputPdfDataconfidenceThreshold = null, Expression<Func<inputPdfDataincludeTypeInput>> inputPdfDataincludeType = null, Expression<Func<string>> inputPdfDataexpectedKeys = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = inputPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = inputPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataoCRLanguage = inputPdfDataoCRLanguage == null ? null : WorkflowExpression.Compile(inputPdfDataoCRLanguage);
            WorkflowExpression.Validate(__workflow_inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            var __workflow_inputPdfDatadPI = inputPdfDatadPI == null ? null : WorkflowExpression.Compile(inputPdfDatadPI);
            WorkflowExpression.Validate(__workflow_inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            var __workflow_inputPdfDatakVPOutputFormat = inputPdfDatakVPOutputFormat == null ? null : WorkflowExpression.Compile(inputPdfDatakVPOutputFormat);
            WorkflowExpression.Validate(__workflow_inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            var __workflow_inputPdfDatapageRange = inputPdfDatapageRange == null ? null : WorkflowExpression.Compile(inputPdfDatapageRange);
            WorkflowExpression.Validate(__workflow_inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDataautorotate = inputPdfDataautorotate == null ? null : WorkflowExpression.Compile(inputPdfDataautorotate);
            WorkflowExpression.Validate(__workflow_inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            var __workflow_inputPdfDatatrimSymbols = inputPdfDatatrimSymbols == null ? null : WorkflowExpression.Compile(inputPdfDatatrimSymbols);
            WorkflowExpression.Validate(__workflow_inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            var __workflow_inputPdfDataincludeKeyBoundingBox = inputPdfDataincludeKeyBoundingBox == null ? null : WorkflowExpression.Compile(inputPdfDataincludeKeyBoundingBox);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            var __workflow_inputPdfDataincludeValueBoundingBox = inputPdfDataincludeValueBoundingBox == null ? null : WorkflowExpression.Compile(inputPdfDataincludeValueBoundingBox);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            var __workflow_inputPdfDataincludePageNumber = inputPdfDataincludePageNumber == null ? null : WorkflowExpression.Compile(inputPdfDataincludePageNumber);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            var __workflow_inputPdfDataincludeConfidence = inputPdfDataincludeConfidence == null ? null : WorkflowExpression.Compile(inputPdfDataincludeConfidence);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            var __workflow_inputPdfDataconfidenceThreshold = inputPdfDataconfidenceThreshold == null ? null : WorkflowExpression.Compile(inputPdfDataconfidenceThreshold);
            WorkflowExpression.Validate(__workflow_inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            var __workflow_inputPdfDataincludeType = inputPdfDataincludeType == null ? null : WorkflowExpression.Compile(inputPdfDataincludeType);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            var __workflow_inputPdfDataexpectedKeys = inputPdfDataexpectedKeys == null ? null : WorkflowExpression.Compile(inputPdfDataexpectedKeys);
            WorkflowExpression.Validate(__workflow_inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            var __workflow_inputPdfDatafailOnError = inputPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> LineWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDataxCoordinateStart, Expression<Func<string>> inputDatayCoordinateStart, Expression<Func<string>> inputDataxCoordinateEnd, Expression<Func<string>> inputDatayCoordinateEnd, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDataxCoordinateStart = inputDataxCoordinateStart == null ? null : WorkflowExpression.Compile(inputDataxCoordinateStart);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinateStart, nameof(inputDataxCoordinateStart), required: true);
            var __workflow_inputDatayCoordinateStart = inputDatayCoordinateStart == null ? null : WorkflowExpression.Compile(inputDatayCoordinateStart);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinateStart, nameof(inputDatayCoordinateStart), required: true);
            var __workflow_inputDataxCoordinateEnd = inputDataxCoordinateEnd == null ? null : WorkflowExpression.Compile(inputDataxCoordinateEnd);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinateEnd, nameof(inputDataxCoordinateEnd), required: true);
            var __workflow_inputDatayCoordinateEnd = inputDatayCoordinateEnd == null ? null : WorkflowExpression.Compile(inputDatayCoordinateEnd);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinateEnd, nameof(inputDatayCoordinateEnd), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatalineColor = inputDatalineColor == null ? null : WorkflowExpression.Compile(inputDatalineColor);
            WorkflowExpression.Validate(__workflow_inputDatalineColor, nameof(inputDatalineColor), required: false);
            var __workflow_inputDatalineWidth = inputDatalineWidth == null ? null : WorkflowExpression.Compile(inputDatalineWidth);
            WorkflowExpression.Validate(__workflow_inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatabarcodeContent, Expression<Func<inputDatabarcodeTypeInput>> inputDatabarcodeType, Expression<Func<inputDatadisableCheckDigitInput>> inputDatadisableCheckDigit, Expression<Func<inputDatashowCheckDigitInput>> inputDatashowCheckDigit, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDataomitEncodingOfStartStopSymbolsInput>> inputDataomitEncodingOfStartStopSymbols = null, Expression<Func<string>> inputDatamargin = null, Expression<Func<string>> inputDatafontFamily = null, Expression<Func<string>> inputDatafontSize = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<inputDatalabelPlacementInput>> inputDatalabelPlacement = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatabarcodeBackgroundColor = null, Expression<Func<string>> inputDatabarcodeBarColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatabarcodeContent = inputDatabarcodeContent == null ? null : WorkflowExpression.Compile(inputDatabarcodeContent);
            WorkflowExpression.Validate(__workflow_inputDatabarcodeContent, nameof(inputDatabarcodeContent), required: true);
            var __workflow_inputDatabarcodeType = inputDatabarcodeType == null ? null : WorkflowExpression.Compile(inputDatabarcodeType);
            WorkflowExpression.Validate(__workflow_inputDatabarcodeType, nameof(inputDatabarcodeType), required: true);
            var __workflow_inputDatadisableCheckDigit = inputDatadisableCheckDigit == null ? null : WorkflowExpression.Compile(inputDatadisableCheckDigit);
            WorkflowExpression.Validate(__workflow_inputDatadisableCheckDigit, nameof(inputDatadisableCheckDigit), required: true);
            var __workflow_inputDatashowCheckDigit = inputDatashowCheckDigit == null ? null : WorkflowExpression.Compile(inputDatashowCheckDigit);
            WorkflowExpression.Validate(__workflow_inputDatashowCheckDigit, nameof(inputDatashowCheckDigit), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataomitEncodingOfStartStopSymbols = inputDataomitEncodingOfStartStopSymbols == null ? null : WorkflowExpression.Compile(inputDataomitEncodingOfStartStopSymbols);
            WorkflowExpression.Validate(__workflow_inputDataomitEncodingOfStartStopSymbols, nameof(inputDataomitEncodingOfStartStopSymbols), required: false);
            var __workflow_inputDatamargin = inputDatamargin == null ? null : WorkflowExpression.Compile(inputDatamargin);
            WorkflowExpression.Validate(__workflow_inputDatamargin, nameof(inputDatamargin), required: false);
            var __workflow_inputDatafontFamily = inputDatafontFamily == null ? null : WorkflowExpression.Compile(inputDatafontFamily);
            WorkflowExpression.Validate(__workflow_inputDatafontFamily, nameof(inputDatafontFamily), required: false);
            var __workflow_inputDatafontSize = inputDatafontSize == null ? null : WorkflowExpression.Compile(inputDatafontSize);
            WorkflowExpression.Validate(__workflow_inputDatafontSize, nameof(inputDatafontSize), required: false);
            var __workflow_inputDatafontStyle = inputDatafontStyle == null ? null : WorkflowExpression.Compile(inputDatafontStyle);
            WorkflowExpression.Validate(__workflow_inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            var __workflow_inputDatalabelPlacement = inputDatalabelPlacement == null ? null : WorkflowExpression.Compile(inputDatalabelPlacement);
            WorkflowExpression.Validate(__workflow_inputDatalabelPlacement, nameof(inputDatalabelPlacement), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatabarcodeBackgroundColor = inputDatabarcodeBackgroundColor == null ? null : WorkflowExpression.Compile(inputDatabarcodeBackgroundColor);
            WorkflowExpression.Validate(__workflow_inputDatabarcodeBackgroundColor, nameof(inputDatabarcodeBackgroundColor), required: false);
            var __workflow_inputDatabarcodeBarColor = inputDatabarcodeBarColor == null ? null : WorkflowExpression.Compile(inputDatabarcodeBarColor);
            WorkflowExpression.Validate(__workflow_inputDatabarcodeBarColor, nameof(inputDatabarcodeBarColor), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> MergeToPdf(Expression<Func<string>> inputDatasourceFileName1 = null, Expression<Func<string>> inputDatasourceFileContent1 = null, Expression<Func<string>> inputDatasourceFileName2 = null, Expression<Func<string>> inputDatasourceFileContent2 = null, Expression<Func<string>> inputDatasourceFileName3 = null, Expression<Func<string>> inputDatasourceFileContent3 = null, Expression<Func<string>> inputDatasourceFileName4 = null, Expression<Func<string>> inputDatasourceFileContent4 = null, Expression<Func<string>> inputDatasourceFileName5 = null, Expression<Func<string>> inputDatasourceFileContent5 = null, Expression<Func<inputDataeachDocumentInput>> inputDataeachDocument = null, Expression<Func<MergeSourceFile[]>> inputDatasourceFiles = null, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName1 = inputDatasourceFileName1 == null ? null : WorkflowExpression.Compile(inputDatasourceFileName1);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName1, nameof(inputDatasourceFileName1), required: false);
            var __workflow_inputDatasourceFileContent1 = inputDatasourceFileContent1 == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent1);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent1, nameof(inputDatasourceFileContent1), required: false);
            var __workflow_inputDatasourceFileName2 = inputDatasourceFileName2 == null ? null : WorkflowExpression.Compile(inputDatasourceFileName2);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName2, nameof(inputDatasourceFileName2), required: false);
            var __workflow_inputDatasourceFileContent2 = inputDatasourceFileContent2 == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent2);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent2, nameof(inputDatasourceFileContent2), required: false);
            var __workflow_inputDatasourceFileName3 = inputDatasourceFileName3 == null ? null : WorkflowExpression.Compile(inputDatasourceFileName3);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName3, nameof(inputDatasourceFileName3), required: false);
            var __workflow_inputDatasourceFileContent3 = inputDatasourceFileContent3 == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent3);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent3, nameof(inputDatasourceFileContent3), required: false);
            var __workflow_inputDatasourceFileName4 = inputDatasourceFileName4 == null ? null : WorkflowExpression.Compile(inputDatasourceFileName4);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName4, nameof(inputDatasourceFileName4), required: false);
            var __workflow_inputDatasourceFileContent4 = inputDatasourceFileContent4 == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent4);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent4, nameof(inputDatasourceFileContent4), required: false);
            var __workflow_inputDatasourceFileName5 = inputDatasourceFileName5 == null ? null : WorkflowExpression.Compile(inputDatasourceFileName5);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName5, nameof(inputDatasourceFileName5), required: false);
            var __workflow_inputDatasourceFileContent5 = inputDatasourceFileContent5 == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent5);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent5, nameof(inputDatasourceFileContent5), required: false);
            var __workflow_inputDataeachDocument = inputDataeachDocument == null ? null : WorkflowExpression.Compile(inputDataeachDocument);
            WorkflowExpression.Validate(__workflow_inputDataeachDocument, nameof(inputDataeachDocument), required: false);
            var __workflow_inputDatasourceFiles = inputDatasourceFiles == null ? null : WorkflowExpression.Compile(inputDatasourceFiles);
            WorkflowExpression.Validate(__workflow_inputDatasourceFiles, nameof(inputDatasourceFiles), required: false);
            var __workflow_inputDataoverrideSettings = inputDataoverrideSettings == null ? null : WorkflowExpression.Compile(inputDataoverrideSettings);
            WorkflowExpression.Validate(__workflow_inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> OcrPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<string>> inputDataregions = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = inputDatalanguage == null ? null : WorkflowExpression.Compile(inputDatalanguage);
            WorkflowExpression.Validate(__workflow_inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataperformance = inputDataperformance == null ? null : WorkflowExpression.Compile(inputDataperformance);
            WorkflowExpression.Validate(__workflow_inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = inputDatablacklistWhitelist == null ? null : WorkflowExpression.Compile(inputDatablacklistWhitelist);
            WorkflowExpression.Validate(__workflow_inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = inputDatacharacters == null ? null : WorkflowExpression.Compile(inputDatacharacters);
            WorkflowExpression.Validate(__workflow_inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = inputDatausePagination == null ? null : WorkflowExpression.Compile(inputDatausePagination);
            WorkflowExpression.Validate(__workflow_inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDataregions = inputDataregions == null ? null : WorkflowExpression.Compile(inputDataregions);
            WorkflowExpression.Validate(__workflow_inputDataregions, nameof(inputDataregions), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<string>> inputDatawidth = null, Expression<Func<string>> inputDataheight = null, Expression<Func<string>> inputDatapageNumber = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = inputDatalanguage == null ? null : WorkflowExpression.Compile(inputDatalanguage);
            WorkflowExpression.Validate(__workflow_inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: false);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: false);
            var __workflow_inputDatapageNumber = inputDatapageNumber == null ? null : WorkflowExpression.Compile(inputDatapageNumber);
            WorkflowExpression.Validate(__workflow_inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            var __workflow_inputDataperformance = inputDataperformance == null ? null : WorkflowExpression.Compile(inputDataperformance);
            WorkflowExpression.Validate(__workflow_inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = inputDatablacklistWhitelist == null ? null : WorkflowExpression.Compile(inputDatablacklistWhitelist);
            WorkflowExpression.Validate(__workflow_inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = inputDatacharacters == null ? null : WorkflowExpression.Compile(inputDatacharacters);
            WorkflowExpression.Validate(__workflow_inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = inputDatausePagination == null ? null : WorkflowExpression.Compile(inputDatausePagination);
            WorkflowExpression.Validate(__workflow_inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> PdfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatapDFWatermark, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatapDFWatermark = inputDatapDFWatermark == null ? null : WorkflowExpression.Compile(inputDatapDFWatermark);
            WorkflowExpression.Validate(__workflow_inputDatapDFWatermark, nameof(inputDatapDFWatermark), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatacontent, Expression<Func<inputDataversionInput>> inputDataversion, Expression<Func<inputDatainputModeInput>> inputDatainputMode, Expression<Func<inputDataerrorCorrectionLevelInput>> inputDataerrorCorrectionLevel, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkForegroundColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatacontent = inputDatacontent == null ? null : WorkflowExpression.Compile(inputDatacontent);
            WorkflowExpression.Validate(__workflow_inputDatacontent, nameof(inputDatacontent), required: true);
            var __workflow_inputDataversion = inputDataversion == null ? null : WorkflowExpression.Compile(inputDataversion);
            WorkflowExpression.Validate(__workflow_inputDataversion, nameof(inputDataversion), required: true);
            var __workflow_inputDatainputMode = inputDatainputMode == null ? null : WorkflowExpression.Compile(inputDatainputMode);
            WorkflowExpression.Validate(__workflow_inputDatainputMode, nameof(inputDatainputMode), required: true);
            var __workflow_inputDataerrorCorrectionLevel = inputDataerrorCorrectionLevel == null ? null : WorkflowExpression.Compile(inputDataerrorCorrectionLevel);
            WorkflowExpression.Validate(__workflow_inputDataerrorCorrectionLevel, nameof(inputDataerrorCorrectionLevel), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = inputDatawatermarkBackgroundColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkBackgroundColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkForegroundColor = inputDatawatermarkForegroundColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkForegroundColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkForegroundColor, nameof(inputDatawatermarkForegroundColor), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = inputDatawatermarkBackgroundColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkBackgroundColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = inputDatawatermarkOutlineColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkOutlineColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = inputDatawatermarkOutlineWidth == null ? null : WorkflowExpression.Compile(inputDatawatermarkOutlineWidth);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> RtfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkContent = inputDatawatermarkContent == null ? null : WorkflowExpression.Compile(inputDatawatermarkContent);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = inputDatawatermarkBackgroundColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkBackgroundColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = inputDatawatermarkOutlineColor == null ? null : WorkflowExpression.Compile(inputDatawatermarkOutlineColor);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = inputDatawatermarkOutlineWidth == null ? null : WorkflowExpression.Compile(inputDatawatermarkOutlineWidth);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> SecurePdf(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataopenPassword = null, Expression<Func<string>> inputDataownerPassword = null, Expression<Func<string>> inputDatapDFRestrictions = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataopenPassword = inputDataopenPassword == null ? null : WorkflowExpression.Compile(inputDataopenPassword);
            WorkflowExpression.Validate(__workflow_inputDataopenPassword, nameof(inputDataopenPassword), required: false);
            var __workflow_inputDataownerPassword = inputDataownerPassword == null ? null : WorkflowExpression.Compile(inputDataownerPassword);
            WorkflowExpression.Validate(__workflow_inputDataownerPassword, nameof(inputDataownerPassword), required: false);
            var __workflow_inputDatapDFRestrictions = inputDatapDFRestrictions == null ? null : WorkflowExpression.Compile(inputDatapDFRestrictions);
            WorkflowExpression.Validate(__workflow_inputDatapDFRestrictions, nameof(inputDatapDFRestrictions), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<SplitOperationResponse> SplitPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatasplitByInput>> inputDatasplitBy, Expression<Func<int>> inputDatasplitParameter, Expression<Func<string>> inputDatafileNameTemplate = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatasplitBy = inputDatasplitBy == null ? null : WorkflowExpression.Compile(inputDatasplitBy);
            WorkflowExpression.Validate(__workflow_inputDatasplitBy, nameof(inputDatasplitBy), required: true);
            var __workflow_inputDatasplitParameter = inputDatasplitParameter == null ? null : WorkflowExpression.Compile(inputDatasplitParameter);
            WorkflowExpression.Validate(__workflow_inputDatasplitParameter, nameof(inputDatasplitParameter), required: true);
            var __workflow_inputDatafileNameTemplate = inputDatafileNameTemplate == null ? null : WorkflowExpression.Compile(inputDatafileNameTemplate);
            WorkflowExpression.Validate(__workflow_inputDatafileNameTemplate, nameof(inputDatafileNameTemplate), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> TextWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<string>> inputDatafontFamilyName, Expression<Func<string>> inputDatafontSize, Expression<Func<string>> inputDatafontColor, Expression<Func<inputDatatextAlignmentInput>> inputDatatextAlignment, Expression<Func<inputDatawordWrapInput>> inputDatawordWrap, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<string>> inputDatafontOutlineColor = null, Expression<Func<string>> inputDatafontOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkContent = inputDatawatermarkContent == null ? null : WorkflowExpression.Compile(inputDatawatermarkContent);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            var __workflow_inputDatafontFamilyName = inputDatafontFamilyName == null ? null : WorkflowExpression.Compile(inputDatafontFamilyName);
            WorkflowExpression.Validate(__workflow_inputDatafontFamilyName, nameof(inputDatafontFamilyName), required: true);
            var __workflow_inputDatafontSize = inputDatafontSize == null ? null : WorkflowExpression.Compile(inputDatafontSize);
            WorkflowExpression.Validate(__workflow_inputDatafontSize, nameof(inputDatafontSize), required: true);
            var __workflow_inputDatafontColor = inputDatafontColor == null ? null : WorkflowExpression.Compile(inputDatafontColor);
            WorkflowExpression.Validate(__workflow_inputDatafontColor, nameof(inputDatafontColor), required: true);
            var __workflow_inputDatatextAlignment = inputDatatextAlignment == null ? null : WorkflowExpression.Compile(inputDatatextAlignment);
            WorkflowExpression.Validate(__workflow_inputDatatextAlignment, nameof(inputDatatextAlignment), required: true);
            var __workflow_inputDatawordWrap = inputDatawordWrap == null ? null : WorkflowExpression.Compile(inputDatawordWrap);
            WorkflowExpression.Validate(__workflow_inputDatawordWrap, nameof(inputDatawordWrap), required: true);
            var __workflow_inputDataposition = inputDataposition == null ? null : WorkflowExpression.Compile(inputDataposition);
            WorkflowExpression.Validate(__workflow_inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = inputDatalayer == null ? null : WorkflowExpression.Compile(inputDatalayer);
            WorkflowExpression.Validate(__workflow_inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = inputDatarotation == null ? null : WorkflowExpression.Compile(inputDatarotation);
            WorkflowExpression.Validate(__workflow_inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = inputDataopacity == null ? null : WorkflowExpression.Compile(inputDataopacity);
            WorkflowExpression.Validate(__workflow_inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatafontStyle = inputDatafontStyle == null ? null : WorkflowExpression.Compile(inputDatafontStyle);
            WorkflowExpression.Validate(__workflow_inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            var __workflow_inputDatafontOutlineColor = inputDatafontOutlineColor == null ? null : WorkflowExpression.Compile(inputDatafontOutlineColor);
            WorkflowExpression.Validate(__workflow_inputDatafontOutlineColor, nameof(inputDatafontOutlineColor), required: false);
            var __workflow_inputDatafontOutlineWidth = inputDatafontOutlineWidth == null ? null : WorkflowExpression.Compile(inputDatafontOutlineWidth);
            WorkflowExpression.Validate(__workflow_inputDatafontOutlineWidth, nameof(inputDatafontOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = inputDatawatermarkStartPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = inputDatawatermarkEndPage == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndPage);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = inputDatawatermarkPageInterval == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageInterval);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = inputDatawatermarkPageOrientation == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageOrientation);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = inputDataprintOnly == null ? null : WorkflowExpression.Compile(inputDataprintOnly);
            WorkflowExpression.Validate(__workflow_inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = inputDatawatermarkStartSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkStartSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = inputDatawatermarkEndSection == null ? null : WorkflowExpression.Compile(inputDatawatermarkEndSection);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = inputDatawatermarkPageType == null ? null : WorkflowExpression.Compile(inputDatawatermarkPageType);
            WorkflowExpression.Validate(__workflow_inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
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

    public class MuhimbipdfTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbipdf;

    public partial class WorkflowManagedActions
    {
        public MuhimbipdfActions Muhimbipdf(string connectionId) => new MuhimbipdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MuhimbipdfTriggers Muhimbipdf(string connectionId) => new MuhimbipdfTriggers(connectionId);
    }
}
