//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbipdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbipdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkData, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> CompressPdf([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<inputPdfDataremoveAnnotationsInput> inputPdfDataremoveAnnotations = null, [WorkflowExpression] Func<inputPdfDataremoveBlankPagesInput> inputPdfDataremoveBlankPages = null, [WorkflowExpression] Func<inputPdfDataremoveBookmarksInput> inputPdfDataremoveBookmarks = null, [WorkflowExpression] Func<inputPdfDataremoveEmbeddedFilesInput> inputPdfDataremoveEmbeddedFiles = null, [WorkflowExpression] Func<inputPdfDataremoveFormFieldsInput> inputPdfDataremoveFormFields = null, [WorkflowExpression] Func<inputPdfDataremoveHyperlinksInput> inputPdfDataremoveHyperlinks = null, [WorkflowExpression] Func<inputPdfDataremoveJavaScriptInput> inputPdfDataremoveJavaScript = null, [WorkflowExpression] Func<inputPdfDataremoveMetadataInput> inputPdfDataremoveMetadata = null, [WorkflowExpression] Func<inputPdfDataremovePageThumbnailsInput> inputPdfDataremovePageThumbnails = null, [WorkflowExpression] Func<inputPdfDatapackFontsInput> inputPdfDatapackFonts = null, [WorkflowExpression] Func<inputPdfDatapackDocumentInput> inputPdfDatapackDocument = null, [WorkflowExpression] Func<inputPdfDatarecompressImagesInput> inputPdfDatarecompressImages = null, [WorkflowExpression] Func<inputPdfDataenableMRCInput> inputPdfDataenableMRC = null, [WorkflowExpression] Func<int> inputPdfDatadownscaleResolutionMRC = null, [WorkflowExpression] Func<inputPdfDatapreserveSmoothingInput> inputPdfDatapreserveSmoothing = null, [WorkflowExpression] Func<inputPdfDataimageQualityInput> inputPdfDataimageQuality = null, [WorkflowExpression] Func<inputPdfDatadownscaleImagesInput> inputPdfDatadownscaleImages = null, [WorkflowExpression] Func<int> inputPdfDatadownscaleResolution = null, [WorkflowExpression] Func<inputPdfDataenableColorDetectionInput> inputPdfDataenableColorDetection = null, [WorkflowExpression] Func<inputPdfDataenableCharRepairInput> inputPdfDataenableCharRepair = null, [WorkflowExpression] Func<inputPdfDataenableJPEG2000Input> inputPdfDataenableJPEG2000 = null, [WorkflowExpression] Func<inputPdfDataenableJBIG2Input> inputPdfDataenableJBIG2 = null, [WorkflowExpression] Func<int> inputPdfDatajBIG2PMSThreshold = null, [WorkflowExpression] Func<string> inputPdfDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> Convert([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDataoutputFormatInput> inputDataoutputFormat, [WorkflowExpression] Func<string> inputDataoverrideSettings = null, [WorkflowExpression] Func<string> inputDatatemplateFileContent = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertCad([WorkflowExpression] Func<string> inputCadDatasourceFileName, [WorkflowExpression] Func<string> inputCadDatasourceFileContent, [WorkflowExpression] Func<inputCadDatapaperSizeInput> inputCadDatapaperSize = null, [WorkflowExpression] Func<string> inputCadDatapaperSizeCustom = null, [WorkflowExpression] Func<string> inputCadDatapageMargins = null, [WorkflowExpression] Func<string> inputCadDatabackgroundColor = null, [WorkflowExpression] Func<inputCadDataforegroundColorInput> inputCadDataforegroundColor = null, [WorkflowExpression] Func<string> inputCadDataforegroundColorCustom = null, [WorkflowExpression] Func<inputCadDataemptyLayoutDetectionInput> inputCadDataemptyLayoutDetection = null, [WorkflowExpression] Func<inputCadDatalayoutSortOrderInput> inputCadDatalayoutSortOrder = null, [WorkflowExpression] Func<int> inputCadDatastartPage = null, [WorkflowExpression] Func<int> inputCadDataendPage = null, [WorkflowExpression] Func<string> inputCadDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputCadDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertEmail([WorkflowExpression] Func<string> inputEmailDatasourceFileName, [WorkflowExpression] Func<string> inputEmailDatasourceFileContent, [WorkflowExpression] Func<bool> inputEmailDataincludeAttachments = null, [WorkflowExpression] Func<inputEmailDataattachmentActionInput> inputEmailDataattachmentAction = null, [WorkflowExpression] Func<bool> inputEmailDataattachmentSummary = null, [WorkflowExpression] Func<inputEmailDataunsupportedAttachmentActionInput> inputEmailDataunsupportedAttachmentAction = null, [WorkflowExpression] Func<string> inputEmailDataincludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputEmailDataexcludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputEmailDataviewportSize = null, [WorkflowExpression] Func<inputEmailDatapaperSizeInput> inputEmailDatapaperSize = null, [WorkflowExpression] Func<string> inputEmailDatapaperSizeCustom = null, [WorkflowExpression] Func<string> inputEmailDatapageMargins = null, [WorkflowExpression] Func<bool> inputEmailDataattachmentErrors = null, [WorkflowExpression] Func<int> inputEmailDataminImageSize = null, [WorkflowExpression] Func<bool> inputEmailDataofflineMode = null, [WorkflowExpression] Func<int> inputEmailDatastartPage = null, [WorkflowExpression] Func<int> inputEmailDataendPage = null, [WorkflowExpression] Func<inputEmailDataconversionQualityInput> inputEmailDataconversionQuality = null, [WorkflowExpression] Func<string> inputEmailDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputEmailDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertExcel([WorkflowExpression] Func<string> inputExcelDatasourceFileName, [WorkflowExpression] Func<string> inputExcelDatasourceFileContent, [WorkflowExpression] Func<inputExcelDataoutputFormatInput> inputExcelDataoutputFormat, [WorkflowExpression] Func<inputExcelDatarangeInput> inputExcelDatarange = null, [WorkflowExpression] Func<bool> inputExcelDatarevealHiddenRows = null, [WorkflowExpression] Func<bool> inputExcelDatarevealHiddenColumns = null, [WorkflowExpression] Func<int> inputExcelDatafitToPagesWide = null, [WorkflowExpression] Func<int> inputExcelDatafitToPagesTall = null, [WorkflowExpression] Func<int> inputExcelDatastartPage = null, [WorkflowExpression] Func<int> inputExcelDataendPage = null, [WorkflowExpression] Func<inputExcelDataqualityInput> inputExcelDataquality = null, [WorkflowExpression] Func<string> inputExcelDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputExcelDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertHtml([WorkflowExpression] Func<string> inputDatasourceURLOrHTML, [WorkflowExpression] Func<inputDatapageOrientationInput> inputDatapageOrientation = null, [WorkflowExpression] Func<inputDatamediaTypeInput> inputDatamediaType = null, [WorkflowExpression] Func<inputDataauthenticationTypeInput> inputDataauthenticationType = null, [WorkflowExpression] Func<string> inputDatauserName = null, [WorkflowExpression] Func<string> inputDatapassword = null, [WorkflowExpression] Func<string> inputDataviewportSize = null, [WorkflowExpression] Func<int> inputDataconversionDelay = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertInfopath([WorkflowExpression] Func<string> inputInfopathDatasourceFileName, [WorkflowExpression] Func<string> inputInfopathDatasourceFileContent, [WorkflowExpression] Func<inputInfopathDataoutputFormatInput> inputInfopathDataoutputFormat, [WorkflowExpression] Func<string> inputInfopathDatatemplateFileContent = null, [WorkflowExpression] Func<string> inputInfopathDataviewNames = null, [WorkflowExpression] Func<bool> inputInfopathDataincludeAttachment = null, [WorkflowExpression] Func<inputInfopathDataattachmentActionInput> inputInfopathDataattachmentAction = null, [WorkflowExpression] Func<inputInfopathDataunsupportedAttachmentActionInput> inputInfopathDataunsupportedAttachmentAction = null, [WorkflowExpression] Func<bool> inputInfopathDatabreakMergeOnError = null, [WorkflowExpression] Func<string> inputInfopathDataincludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputInfopathDataexcludeAttachmentFilter = null, [WorkflowExpression] Func<inputInfopathDatadefaultPaperSizeInput> inputInfopathDatadefaultPaperSize = null, [WorkflowExpression] Func<string> inputInfopathDatadefaultPaperSizeCustom = null, [WorkflowExpression] Func<inputInfopathDataforcePaperSizeInput> inputInfopathDataforcePaperSize = null, [WorkflowExpression] Func<string> inputInfopathDataforcePaperSizeCustom = null, [WorkflowExpression] Func<inputInfopathDatadefaultPageOrientationInput> inputInfopathDatadefaultPageOrientation = null, [WorkflowExpression] Func<inputInfopathDataforcePageOrientationInput> inputInfopathDataforcePageOrientation = null, [WorkflowExpression] Func<int> inputInfopathDatastartPage = null, [WorkflowExpression] Func<int> inputInfopathDataendPage = null, [WorkflowExpression] Func<inputInfopathDataconversionQualityInput> inputInfopathDataconversionQuality = null, [WorkflowExpression] Func<string> inputInfopathDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputInfopathDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPdfa([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<inputPdfDatapDFProfileInput> inputPdfDatapDFProfile, [WorkflowExpression] Func<string> inputPdfDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPowerpoint([WorkflowExpression] Func<string> inputPowerpointDatasourceFileName, [WorkflowExpression] Func<string> inputPowerpointDatasourceFileContent, [WorkflowExpression] Func<inputPowerpointDataoutputFormatInput> inputPowerpointDataoutputFormat, [WorkflowExpression] Func<inputPowerpointDatarangeInput> inputPowerpointDatarange = null, [WorkflowExpression] Func<inputPowerpointDataprintLayoutHandoutsInput> inputPowerpointDataprintLayoutHandouts = null, [WorkflowExpression] Func<bool> inputPowerpointDataframeSlides = null, [WorkflowExpression] Func<int> inputPowerpointDatastartPage = null, [WorkflowExpression] Func<int> inputPowerpointDataendPage = null, [WorkflowExpression] Func<inputPowerpointDataqualityInput> inputPowerpointDataquality = null, [WorkflowExpression] Func<string> inputPowerpointDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPowerpointDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertVisio([WorkflowExpression] Func<string> inputVisioDatasourceFileName, [WorkflowExpression] Func<string> inputVisioDatasourceFileContent, [WorkflowExpression] Func<inputVisioDataoutputFormatInput> inputVisioDataoutputFormat, [WorkflowExpression] Func<inputVisioDatarangeInput> inputVisioDatarange = null, [WorkflowExpression] Func<int> inputVisioDatastartPage = null, [WorkflowExpression] Func<int> inputVisioDataendPage = null, [WorkflowExpression] Func<inputVisioDataqualityInput> inputVisioDataquality = null, [WorkflowExpression] Func<string> inputVisioDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputVisioDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertWord([WorkflowExpression] Func<string> inputWordDatasourceFileName, [WorkflowExpression] Func<string> inputWordDatasourceFileContent, [WorkflowExpression] Func<inputWordDataoutputFormatInput> inputWordDataoutputFormat, [WorkflowExpression] Func<inputWordDatadisplayForReviewInput> inputWordDatadisplayForReview = null, [WorkflowExpression] Func<inputWordDatareviewMarkupModeInput> inputWordDatareviewMarkupMode = null, [WorkflowExpression] Func<inputWordDatagenerateBookmarksInput> inputWordDatagenerateBookmarks = null, [WorkflowExpression] Func<int> inputWordDatastartPage = null, [WorkflowExpression] Func<int> inputWordDataendPage = null, [WorkflowExpression] Func<inputWordDataqualityInput> inputWordDataquality = null, [WorkflowExpression] Func<string> inputWordDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputWordDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponseCommon> CopyMetadata([WorkflowExpression] Func<string> inputDatasiteUrl, [WorkflowExpression] Func<string> inputDatasourceFileUrl, [WorkflowExpression] Func<string> inputDatadestinationFilePath, [WorkflowExpression] Func<string> inputDatauserName = null, [WorkflowExpression] Func<string> inputDatapassword = null, [WorkflowExpression] Func<string> inputDatafieldsToCopy = null, [WorkflowExpression] Func<string> inputDatadestinationContentType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatafillColor = null, [WorkflowExpression] Func<string> inputDatalineColor = null, [WorkflowExpression] Func<string> inputDatalineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ExportFormData([WorkflowExpression] Func<string> inputFromPdfDatasourceFileName, [WorkflowExpression] Func<string> inputFromPdfDatasourceFileContent, [WorkflowExpression] Func<inputFromPdfDataoutputDataFormatInput> inputFromPdfDataoutputDataFormat, [WorkflowExpression] Func<bool> inputFromPdfDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ExtractText([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ImageWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDataimage, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ImportFormData([WorkflowExpression] Func<string> inputXmlDatasourceFileName, [WorkflowExpression] Func<string> inputXmlDatasourceFileContent, [WorkflowExpression] Func<string> inputXmlDatapDFFormFileContent = null, [WorkflowExpression] Func<string> inputXmlDatapDFFormURL = null, [WorkflowExpression] Func<string> inputXmlDatausername = null, [WorkflowExpression] Func<string> inputXmlDatadomain = null, [WorkflowExpression] Func<string> inputXmlDatapassword = null, [WorkflowExpression] Func<inputXmlDataflattenInput> inputXmlDataflatten = null, [WorkflowExpression] Func<inputXmlDatareadOnlyInput> inputXmlDatareadOnly = null, [WorkflowExpression] Func<string> inputXmlDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputXmlDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDataoCRLanguage = null, [WorkflowExpression] Func<inputPdfDatadPIInput> inputPdfDatadPI = null, [WorkflowExpression] Func<inputPdfDatakVPOutputFormatInput> inputPdfDatakVPOutputFormat = null, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<inputPdfDataautorotateInput> inputPdfDataautorotate = null, [WorkflowExpression] Func<inputPdfDatatrimSymbolsInput> inputPdfDatatrimSymbols = null, [WorkflowExpression] Func<inputPdfDataincludeKeyBoundingBoxInput> inputPdfDataincludeKeyBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludeValueBoundingBoxInput> inputPdfDataincludeValueBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludePageNumberInput> inputPdfDataincludePageNumber = null, [WorkflowExpression] Func<inputPdfDataincludeConfidenceInput> inputPdfDataincludeConfidence = null, [WorkflowExpression] Func<int> inputPdfDataconfidenceThreshold = null, [WorkflowExpression] Func<inputPdfDataincludeTypeInput> inputPdfDataincludeType = null, [WorkflowExpression] Func<string> inputPdfDataexpectedKeys = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> LineWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDataxCoordinateStart, [WorkflowExpression] Func<string> inputDatayCoordinateStart, [WorkflowExpression] Func<string> inputDataxCoordinateEnd, [WorkflowExpression] Func<string> inputDatayCoordinateEnd, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatalineColor = null, [WorkflowExpression] Func<string> inputDatalineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatabarcodeContent, [WorkflowExpression] Func<inputDatabarcodeTypeInput> inputDatabarcodeType, [WorkflowExpression] Func<inputDatadisableCheckDigitInput> inputDatadisableCheckDigit, [WorkflowExpression] Func<inputDatashowCheckDigitInput> inputDatashowCheckDigit, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<inputDataomitEncodingOfStartStopSymbolsInput> inputDataomitEncodingOfStartStopSymbols = null, [WorkflowExpression] Func<string> inputDatamargin = null, [WorkflowExpression] Func<string> inputDatafontFamily = null, [WorkflowExpression] Func<string> inputDatafontSize = null, [WorkflowExpression] Func<string> inputDatafontStyle = null, [WorkflowExpression] Func<inputDatalabelPlacementInput> inputDatalabelPlacement = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatabarcodeBackgroundColor = null, [WorkflowExpression] Func<string> inputDatabarcodeBarColor = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> MergeToPdf([WorkflowExpression] Func<string> inputDatasourceFileName1 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent1 = null, [WorkflowExpression] Func<string> inputDatasourceFileName2 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent2 = null, [WorkflowExpression] Func<string> inputDatasourceFileName3 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent3 = null, [WorkflowExpression] Func<string> inputDatasourceFileName4 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent4 = null, [WorkflowExpression] Func<string> inputDatasourceFileName5 = null, [WorkflowExpression] Func<string> inputDatasourceFileContent5 = null, [WorkflowExpression] Func<inputDataeachDocumentInput> inputDataeachDocument = null, [WorkflowExpression] Func<MergeSourceFile[]> inputDatasourceFiles = null, [WorkflowExpression] Func<string> inputDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> OcrPdf([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<string> inputDataregions = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<string> inputDatawidth = null, [WorkflowExpression] Func<string> inputDataheight = null, [WorkflowExpression] Func<string> inputDatapageNumber = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> PdfWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatapDFWatermark, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatacontent, [WorkflowExpression] Func<inputDataversionInput> inputDataversion, [WorkflowExpression] Func<inputDatainputModeInput> inputDatainputMode, [WorkflowExpression] Func<inputDataerrorCorrectionLevelInput> inputDataerrorCorrectionLevel, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkForegroundColor = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> RtfWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> SecurePdf([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataopenPassword = null, [WorkflowExpression] Func<string> inputDataownerPassword = null, [WorkflowExpression] Func<string> inputDatapDFRestrictions = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<SplitOperationResponse> SplitPdf([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatasplitByInput> inputDatasplitBy, [WorkflowExpression] Func<int> inputDatasplitParameter, [WorkflowExpression] Func<string> inputDatafileNameTemplate = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> TextWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkContent, [WorkflowExpression] Func<string> inputDatafontFamilyName, [WorkflowExpression] Func<string> inputDatafontSize, [WorkflowExpression] Func<string> inputDatafontColor, [WorkflowExpression] Func<inputDatatextAlignmentInput> inputDatatextAlignment, [WorkflowExpression] Func<inputDatawordWrapInput> inputDatawordWrap, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatafontStyle = null, [WorkflowExpression] Func<string> inputDatafontOutlineColor = null, [WorkflowExpression] Func<string> inputDatafontOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
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