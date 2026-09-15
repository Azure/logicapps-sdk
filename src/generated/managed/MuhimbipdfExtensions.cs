//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbipdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbipdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkData, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/composite_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["watermark_data"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkData);
            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> CompressPdf(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDataremoveAnnotationsInput>> inputPdfDataremoveAnnotations = null, Expression<Func<inputPdfDataremoveBlankPagesInput>> inputPdfDataremoveBlankPages = null, Expression<Func<inputPdfDataremoveBookmarksInput>> inputPdfDataremoveBookmarks = null, Expression<Func<inputPdfDataremoveEmbeddedFilesInput>> inputPdfDataremoveEmbeddedFiles = null, Expression<Func<inputPdfDataremoveFormFieldsInput>> inputPdfDataremoveFormFields = null, Expression<Func<inputPdfDataremoveHyperlinksInput>> inputPdfDataremoveHyperlinks = null, Expression<Func<inputPdfDataremoveJavaScriptInput>> inputPdfDataremoveJavaScript = null, Expression<Func<inputPdfDataremoveMetadataInput>> inputPdfDataremoveMetadata = null, Expression<Func<inputPdfDataremovePageThumbnailsInput>> inputPdfDataremovePageThumbnails = null, Expression<Func<inputPdfDatapackFontsInput>> inputPdfDatapackFonts = null, Expression<Func<inputPdfDatapackDocumentInput>> inputPdfDatapackDocument = null, Expression<Func<inputPdfDatarecompressImagesInput>> inputPdfDatarecompressImages = null, Expression<Func<inputPdfDataenableMRCInput>> inputPdfDataenableMRC = null, Expression<Func<int>> inputPdfDatadownscaleResolutionMRC = null, Expression<Func<inputPdfDatapreserveSmoothingInput>> inputPdfDatapreserveSmoothing = null, Expression<Func<inputPdfDataimageQualityInput>> inputPdfDataimageQuality = null, Expression<Func<inputPdfDatadownscaleImagesInput>> inputPdfDatadownscaleImages = null, Expression<Func<int>> inputPdfDatadownscaleResolution = null, Expression<Func<inputPdfDataenableColorDetectionInput>> inputPdfDataenableColorDetection = null, Expression<Func<inputPdfDataenableCharRepairInput>> inputPdfDataenableCharRepair = null, Expression<Func<inputPdfDataenableJPEG2000Input>> inputPdfDataenableJPEG2000 = null, Expression<Func<inputPdfDataenableJBIG2Input>> inputPdfDataenableJBIG2 = null, Expression<Func<int>> inputPdfDatajBIG2PMSThreshold = null, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/compress_pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPdfData = new JObject();
            var inputPdfDatapropCount = 0;
            inputPdfData["use_async_pattern"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepointFileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
            if (inputPdfDataremoveAnnotations != null)
            {
                if (inputPdfDataremoveAnnotations != null)
                {
                    inputPdfData["remove_annotations"] = CSharpExpressionConverter.Convert(inputPdfDataremoveAnnotations);
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
                    inputPdfData["remove_blank_pages"] = CSharpExpressionConverter.Convert(inputPdfDataremoveBlankPages);
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
                    inputPdfData["remove_bookmarks"] = CSharpExpressionConverter.Convert(inputPdfDataremoveBookmarks);
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
                    inputPdfData["remove_embedded_files"] = CSharpExpressionConverter.Convert(inputPdfDataremoveEmbeddedFiles);
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
                    inputPdfData["remove_form_fields"] = CSharpExpressionConverter.Convert(inputPdfDataremoveFormFields);
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
                    inputPdfData["remove_hyperlinks"] = CSharpExpressionConverter.Convert(inputPdfDataremoveHyperlinks);
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
                    inputPdfData["remove_javascript"] = CSharpExpressionConverter.Convert(inputPdfDataremoveJavaScript);
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
                    inputPdfData["remove_metadata"] = CSharpExpressionConverter.Convert(inputPdfDataremoveMetadata);
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
                    inputPdfData["remove_page_thumbnails"] = CSharpExpressionConverter.Convert(inputPdfDataremovePageThumbnails);
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
                    inputPdfData["pack_fonts"] = CSharpExpressionConverter.Convert(inputPdfDatapackFonts);
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
                    inputPdfData["pack_document"] = CSharpExpressionConverter.Convert(inputPdfDatapackDocument);
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
                    inputPdfData["recompress_images"] = CSharpExpressionConverter.Convert(inputPdfDatarecompressImages);
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
                    inputPdfData["enable_mrc"] = CSharpExpressionConverter.Convert(inputPdfDataenableMRC);
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
                    inputPdfData["downscale_resolution_mrc"] = CSharpExpressionConverter.ConvertToken(inputPdfDatadownscaleResolutionMRC);
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
                    inputPdfData["preserve_smoothing"] = CSharpExpressionConverter.Convert(inputPdfDatapreserveSmoothing);
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
                    inputPdfData["image_quality"] = CSharpExpressionConverter.Convert(inputPdfDataimageQuality);
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
                    inputPdfData["downscale_images"] = CSharpExpressionConverter.Convert(inputPdfDatadownscaleImages);
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
                    inputPdfData["downscale_resolution"] = CSharpExpressionConverter.ConvertToken(inputPdfDatadownscaleResolution);
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
                    inputPdfData["enable_color_detection"] = CSharpExpressionConverter.Convert(inputPdfDataenableColorDetection);
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
                    inputPdfData["enable_char_repair"] = CSharpExpressionConverter.Convert(inputPdfDataenableCharRepair);
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
                    inputPdfData["enable_jpeg2000"] = CSharpExpressionConverter.Convert(inputPdfDataenableJPEG2000);
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
                    inputPdfData["enable_jbig2"] = CSharpExpressionConverter.Convert(inputPdfDataenableJBIG2);
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
                    inputPdfData["jbig2_pms_threshold"] = CSharpExpressionConverter.ConvertToken(inputPdfDatajBIG2PMSThreshold);
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
                inputPdfData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputPdfDataoverrideSettings);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                if (inputPdfDatafailOnError != null)
                {
                    inputPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> Convert(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDataoutputFormatInput>> inputDataoutputFormat, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<string>> inputDatatemplateFileContent = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["output_format"] = CSharpExpressionConverter.Convert(inputDataoutputFormat);
            inputData["copy_metadata"] = false;
            inputDatapropCount++;
            if (inputDataoverrideSettings != null)
            {
                inputData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputDataoverrideSettings);
                inputDatapropCount++;
            }

            if (inputDatatemplateFileContent != null)
            {
                inputData["template_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatatemplateFileContent);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertCad(Expression<Func<string>> inputCadDatasourceFileName, Expression<Func<string>> inputCadDatasourceFileContent, Expression<Func<inputCadDatapaperSizeInput>> inputCadDatapaperSize = null, Expression<Func<string>> inputCadDatapaperSizeCustom = null, Expression<Func<string>> inputCadDatapageMargins = null, Expression<Func<string>> inputCadDatabackgroundColor = null, Expression<Func<inputCadDataforegroundColorInput>> inputCadDataforegroundColor = null, Expression<Func<string>> inputCadDataforegroundColorCustom = null, Expression<Func<inputCadDataemptyLayoutDetectionInput>> inputCadDataemptyLayoutDetection = null, Expression<Func<inputCadDatalayoutSortOrderInput>> inputCadDatalayoutSortOrder = null, Expression<Func<int>> inputCadDatastartPage = null, Expression<Func<int>> inputCadDataendPage = null, Expression<Func<string>> inputCadDataoverrideSettings = null, Expression<Func<bool>> inputCadDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_cad";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputCadData = new JObject();
            var inputCadDatapropCount = 0;
            inputCadData["use_async_pattern"] = false;
            inputCadDatapropCount++;
            inputCadDatapropCount++;
            inputCadData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputCadDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputCadData["sharepoint_file"] = sharepointFileObject;
                inputCadDatapropCount++;
            }

            inputCadDatapropCount++;
            inputCadData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputCadDatasourceFileContent);
            inputCadData["copy_metadata"] = false;
            inputCadDatapropCount++;
            if (inputCadDatapaperSize != null)
            {
                if (inputCadDatapaperSize != null)
                {
                    inputCadData["paper_size"] = CSharpExpressionConverter.Convert(inputCadDatapaperSize);
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
                inputCadData["paper_size_custom"] = CSharpExpressionConverter.ConvertToken(inputCadDatapaperSizeCustom);
                inputCadDatapropCount++;
            }

            if (inputCadDatapageMargins != null)
            {
                if (inputCadDatapageMargins != null)
                {
                    inputCadData["page_margins"] = CSharpExpressionConverter.ConvertToken(inputCadDatapageMargins);
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
                    inputCadData["background_color"] = CSharpExpressionConverter.ConvertToken(inputCadDatabackgroundColor);
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
                    inputCadData["foreground_color"] = CSharpExpressionConverter.Convert(inputCadDataforegroundColor);
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
                inputCadData["foreground_color_custom"] = CSharpExpressionConverter.ConvertToken(inputCadDataforegroundColorCustom);
                inputCadDatapropCount++;
            }

            if (inputCadDataemptyLayoutDetection != null)
            {
                if (inputCadDataemptyLayoutDetection != null)
                {
                    inputCadData["empty_layout_detection_mode"] = CSharpExpressionConverter.Convert(inputCadDataemptyLayoutDetection);
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
                    inputCadData["layout_sort_order"] = CSharpExpressionConverter.Convert(inputCadDatalayoutSortOrder);
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
                inputCadData["start_page"] = CSharpExpressionConverter.ConvertToken(inputCadDatastartPage);
                inputCadDatapropCount++;
            }

            if (inputCadDataendPage != null)
            {
                inputCadData["end_page"] = CSharpExpressionConverter.ConvertToken(inputCadDataendPage);
                inputCadDatapropCount++;
            }

            if (inputCadDataoverrideSettings != null)
            {
                inputCadData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputCadDataoverrideSettings);
                inputCadDatapropCount++;
            }

            if (inputCadDatafailOnError != null)
            {
                if (inputCadDatafailOnError != null)
                {
                    inputCadData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputCadDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertEmail(Expression<Func<string>> inputEmailDatasourceFileName, Expression<Func<string>> inputEmailDatasourceFileContent, Expression<Func<bool>> inputEmailDataincludeAttachments = null, Expression<Func<inputEmailDataattachmentActionInput>> inputEmailDataattachmentAction = null, Expression<Func<bool>> inputEmailDataattachmentSummary = null, Expression<Func<inputEmailDataunsupportedAttachmentActionInput>> inputEmailDataunsupportedAttachmentAction = null, Expression<Func<string>> inputEmailDataincludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataexcludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataviewportSize = null, Expression<Func<inputEmailDatapaperSizeInput>> inputEmailDatapaperSize = null, Expression<Func<string>> inputEmailDatapaperSizeCustom = null, Expression<Func<string>> inputEmailDatapageMargins = null, Expression<Func<bool>> inputEmailDataattachmentErrors = null, Expression<Func<int>> inputEmailDataminImageSize = null, Expression<Func<bool>> inputEmailDataofflineMode = null, Expression<Func<int>> inputEmailDatastartPage = null, Expression<Func<int>> inputEmailDataendPage = null, Expression<Func<inputEmailDataconversionQualityInput>> inputEmailDataconversionQuality = null, Expression<Func<string>> inputEmailDataoverrideSettings = null, Expression<Func<bool>> inputEmailDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_email";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputEmailData = new JObject();
            var inputEmailDatapropCount = 0;
            inputEmailData["use_async_pattern"] = false;
            inputEmailDatapropCount++;
            inputEmailDatapropCount++;
            inputEmailData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputEmailDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputEmailData["sharepoint_file"] = sharepointFileObject;
                inputEmailDatapropCount++;
            }

            inputEmailDatapropCount++;
            inputEmailData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputEmailDatasourceFileContent);
            inputEmailData["copy_metadata"] = false;
            inputEmailDatapropCount++;
            if (inputEmailDataincludeAttachments != null)
            {
                if (inputEmailDataincludeAttachments != null)
                {
                    inputEmailData["convert_attachments"] = CSharpExpressionConverter.ConvertToken(inputEmailDataincludeAttachments);
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
                inputEmailData["attachment_merge_mode"] = CSharpExpressionConverter.Convert(inputEmailDataattachmentAction);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataattachmentSummary != null)
            {
                if (inputEmailDataattachmentSummary != null)
                {
                    inputEmailData["display_attachment_summary"] = CSharpExpressionConverter.ConvertToken(inputEmailDataattachmentSummary);
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
                    inputEmailData["unsupported_attachment_behaviour"] = CSharpExpressionConverter.Convert(inputEmailDataunsupportedAttachmentAction);
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
                inputEmailData["include_attachment_types"] = CSharpExpressionConverter.ConvertToken(inputEmailDataincludeAttachmentFilter);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataexcludeAttachmentFilter != null)
            {
                inputEmailData["exclude_attachment_types"] = CSharpExpressionConverter.ConvertToken(inputEmailDataexcludeAttachmentFilter);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataviewportSize != null)
            {
                if (inputEmailDataviewportSize != null)
                {
                    inputEmailData["viewport_Size"] = CSharpExpressionConverter.ConvertToken(inputEmailDataviewportSize);
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
                    inputEmailData["paper_size"] = CSharpExpressionConverter.Convert(inputEmailDatapaperSize);
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
                inputEmailData["paper_size_custom"] = CSharpExpressionConverter.ConvertToken(inputEmailDatapaperSizeCustom);
                inputEmailDatapropCount++;
            }

            if (inputEmailDatapageMargins != null)
            {
                if (inputEmailDatapageMargins != null)
                {
                    inputEmailData["page_margins"] = CSharpExpressionConverter.ConvertToken(inputEmailDatapageMargins);
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
                inputEmailData["break_merge_on_error"] = CSharpExpressionConverter.ConvertToken(inputEmailDataattachmentErrors);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataminImageSize != null)
            {
                if (inputEmailDataminImageSize != null)
                {
                    inputEmailData["minimum_image_attachment_dimension"] = CSharpExpressionConverter.ConvertToken(inputEmailDataminImageSize);
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
                    inputEmailData["enable_offline_mode"] = CSharpExpressionConverter.ConvertToken(inputEmailDataofflineMode);
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
                inputEmailData["start_page"] = CSharpExpressionConverter.ConvertToken(inputEmailDatastartPage);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataendPage != null)
            {
                inputEmailData["end_page"] = CSharpExpressionConverter.ConvertToken(inputEmailDataendPage);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataconversionQuality != null)
            {
                inputEmailData["quality"] = CSharpExpressionConverter.Convert(inputEmailDataconversionQuality);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataoverrideSettings != null)
            {
                inputEmailData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputEmailDataoverrideSettings);
                inputEmailDatapropCount++;
            }

            if (inputEmailDatafailOnError != null)
            {
                if (inputEmailDatafailOnError != null)
                {
                    inputEmailData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputEmailDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertExcel(Expression<Func<string>> inputExcelDatasourceFileName, Expression<Func<string>> inputExcelDatasourceFileContent, Expression<Func<inputExcelDataoutputFormatInput>> inputExcelDataoutputFormat, Expression<Func<inputExcelDatarangeInput>> inputExcelDatarange = null, Expression<Func<bool>> inputExcelDatarevealHiddenRows = null, Expression<Func<bool>> inputExcelDatarevealHiddenColumns = null, Expression<Func<int>> inputExcelDatafitToPagesWide = null, Expression<Func<int>> inputExcelDatafitToPagesTall = null, Expression<Func<int>> inputExcelDatastartPage = null, Expression<Func<int>> inputExcelDataendPage = null, Expression<Func<inputExcelDataqualityInput>> inputExcelDataquality = null, Expression<Func<string>> inputExcelDataoverrideSettings = null, Expression<Func<bool>> inputExcelDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_excel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputExcelData = new JObject();
            var inputExcelDatapropCount = 0;
            inputExcelData["use_async_pattern"] = false;
            inputExcelDatapropCount++;
            inputExcelDatapropCount++;
            inputExcelData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputExcelDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputExcelData["sharepoint_file"] = sharepointFileObject;
                inputExcelDatapropCount++;
            }

            inputExcelDatapropCount++;
            inputExcelData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputExcelDatasourceFileContent);
            inputExcelDatapropCount++;
            inputExcelData["output_format"] = CSharpExpressionConverter.Convert(inputExcelDataoutputFormat);
            inputExcelData["copy_metadata"] = false;
            inputExcelDatapropCount++;
            if (inputExcelDatarange != null)
            {
                inputExcelData["range"] = CSharpExpressionConverter.Convert(inputExcelDatarange);
                inputExcelDatapropCount++;
            }

            if (inputExcelDatarevealHiddenRows != null)
            {
                if (inputExcelDatarevealHiddenRows != null)
                {
                    inputExcelData["unhide_all_rows"] = CSharpExpressionConverter.ConvertToken(inputExcelDatarevealHiddenRows);
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
                    inputExcelData["unhide_all_columns"] = CSharpExpressionConverter.ConvertToken(inputExcelDatarevealHiddenColumns);
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
                inputExcelData["fit_to_pages_wide"] = CSharpExpressionConverter.ConvertToken(inputExcelDatafitToPagesWide);
                inputExcelDatapropCount++;
            }

            if (inputExcelDatafitToPagesTall != null)
            {
                inputExcelData["fit_to_pages_tall"] = CSharpExpressionConverter.ConvertToken(inputExcelDatafitToPagesTall);
                inputExcelDatapropCount++;
            }

            if (inputExcelDatastartPage != null)
            {
                inputExcelData["start_page"] = CSharpExpressionConverter.ConvertToken(inputExcelDatastartPage);
                inputExcelDatapropCount++;
            }

            if (inputExcelDataendPage != null)
            {
                inputExcelData["end_page"] = CSharpExpressionConverter.ConvertToken(inputExcelDataendPage);
                inputExcelDatapropCount++;
            }

            if (inputExcelDataquality != null)
            {
                inputExcelData["quality"] = CSharpExpressionConverter.Convert(inputExcelDataquality);
                inputExcelDatapropCount++;
            }

            if (inputExcelDataoverrideSettings != null)
            {
                inputExcelData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputExcelDataoverrideSettings);
                inputExcelDatapropCount++;
            }

            if (inputExcelDatafailOnError != null)
            {
                if (inputExcelDatafailOnError != null)
                {
                    inputExcelData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputExcelDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertHtml(Expression<Func<string>> inputDatasourceURLOrHTML, Expression<Func<inputDatapageOrientationInput>> inputDatapageOrientation = null, Expression<Func<inputDatamediaTypeInput>> inputDatamediaType = null, Expression<Func<inputDataauthenticationTypeInput>> inputDataauthenticationType = null, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDataviewportSize = null, Expression<Func<int>> inputDataconversionDelay = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_html";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_url_or_html"] = CSharpExpressionConverter.ConvertToken(inputDatasourceURLOrHTML);
            if (inputDatapageOrientation != null)
            {
                if (inputDatapageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatapageOrientation);
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
                    inputData["media_type"] = CSharpExpressionConverter.Convert(inputDatamediaType);
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
                    inputData["authentication_type"] = CSharpExpressionConverter.Convert(inputDataauthenticationType);
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
                inputData["username"] = CSharpExpressionConverter.ConvertToken(inputDatauserName);
                inputDatapropCount++;
            }

            if (inputDatapassword != null)
            {
                inputData["password"] = CSharpExpressionConverter.ConvertToken(inputDatapassword);
                inputDatapropCount++;
            }

            if (inputDataviewportSize != null)
            {
                inputData["viewport_size"] = CSharpExpressionConverter.ConvertToken(inputDataviewportSize);
                inputDatapropCount++;
            }

            if (inputDataconversionDelay != null)
            {
                inputData["conversion_delay"] = CSharpExpressionConverter.ConvertToken(inputDataconversionDelay);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertInfopath(Expression<Func<string>> inputInfopathDatasourceFileName, Expression<Func<string>> inputInfopathDatasourceFileContent, Expression<Func<inputInfopathDataoutputFormatInput>> inputInfopathDataoutputFormat, Expression<Func<string>> inputInfopathDatatemplateFileContent = null, Expression<Func<string>> inputInfopathDataviewNames = null, Expression<Func<bool>> inputInfopathDataincludeAttachment = null, Expression<Func<inputInfopathDataattachmentActionInput>> inputInfopathDataattachmentAction = null, Expression<Func<inputInfopathDataunsupportedAttachmentActionInput>> inputInfopathDataunsupportedAttachmentAction = null, Expression<Func<bool>> inputInfopathDatabreakMergeOnError = null, Expression<Func<string>> inputInfopathDataincludeAttachmentFilter = null, Expression<Func<string>> inputInfopathDataexcludeAttachmentFilter = null, Expression<Func<inputInfopathDatadefaultPaperSizeInput>> inputInfopathDatadefaultPaperSize = null, Expression<Func<string>> inputInfopathDatadefaultPaperSizeCustom = null, Expression<Func<inputInfopathDataforcePaperSizeInput>> inputInfopathDataforcePaperSize = null, Expression<Func<string>> inputInfopathDataforcePaperSizeCustom = null, Expression<Func<inputInfopathDatadefaultPageOrientationInput>> inputInfopathDatadefaultPageOrientation = null, Expression<Func<inputInfopathDataforcePageOrientationInput>> inputInfopathDataforcePageOrientation = null, Expression<Func<int>> inputInfopathDatastartPage = null, Expression<Func<int>> inputInfopathDataendPage = null, Expression<Func<inputInfopathDataconversionQualityInput>> inputInfopathDataconversionQuality = null, Expression<Func<string>> inputInfopathDataoverrideSettings = null, Expression<Func<bool>> inputInfopathDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_infopath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputInfopathData = new JObject();
            var inputInfopathDatapropCount = 0;
            inputInfopathData["use_async_pattern"] = false;
            inputInfopathDatapropCount++;
            inputInfopathDatapropCount++;
            inputInfopathData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputInfopathData["sharepoint_file"] = sharepointFileObject;
                inputInfopathDatapropCount++;
            }

            inputInfopathDatapropCount++;
            inputInfopathData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatasourceFileContent);
            inputInfopathDatapropCount++;
            inputInfopathData["output_format"] = CSharpExpressionConverter.Convert(inputInfopathDataoutputFormat);
            inputInfopathData["copy_metadata"] = false;
            inputInfopathDatapropCount++;
            if (inputInfopathDatatemplateFileContent != null)
            {
                inputInfopathData["template_file_content"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatatemplateFileContent);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataviewNames != null)
            {
                inputInfopathData["views_to_convert"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataviewNames);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataincludeAttachment != null)
            {
                if (inputInfopathDataincludeAttachment != null)
                {
                    inputInfopathData["convert_attachments"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataincludeAttachment);
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
                inputInfopathData["attachment_merge_mode"] = CSharpExpressionConverter.Convert(inputInfopathDataattachmentAction);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataunsupportedAttachmentAction != null)
            {
                inputInfopathData["unsupported_attachment_behaviour"] = CSharpExpressionConverter.Convert(inputInfopathDataunsupportedAttachmentAction);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatabreakMergeOnError != null)
            {
                inputInfopathData["break_merge_on_error"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatabreakMergeOnError);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataincludeAttachmentFilter != null)
            {
                inputInfopathData["include_attachment_types"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataincludeAttachmentFilter);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataexcludeAttachmentFilter != null)
            {
                inputInfopathData["exclude_attachment_types"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataexcludeAttachmentFilter);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatadefaultPaperSize != null)
            {
                inputInfopathData["default_paper_size"] = CSharpExpressionConverter.Convert(inputInfopathDatadefaultPaperSize);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatadefaultPaperSizeCustom != null)
            {
                inputInfopathData["default_paper_size_custom"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatadefaultPaperSizeCustom);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataforcePaperSize != null)
            {
                inputInfopathData["force_paper_size"] = CSharpExpressionConverter.Convert(inputInfopathDataforcePaperSize);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataforcePaperSizeCustom != null)
            {
                inputInfopathData["force_paper_size_custom"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataforcePaperSizeCustom);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatadefaultPageOrientation != null)
            {
                if (inputInfopathDatadefaultPageOrientation != null)
                {
                    inputInfopathData["default_page_orientation"] = CSharpExpressionConverter.Convert(inputInfopathDatadefaultPageOrientation);
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
                inputInfopathData["force_page_orientation"] = CSharpExpressionConverter.Convert(inputInfopathDataforcePageOrientation);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatastartPage != null)
            {
                inputInfopathData["start_page"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatastartPage);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataendPage != null)
            {
                inputInfopathData["end_page"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataendPage);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataconversionQuality != null)
            {
                inputInfopathData["quality"] = CSharpExpressionConverter.Convert(inputInfopathDataconversionQuality);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDataoverrideSettings != null)
            {
                inputInfopathData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputInfopathDataoverrideSettings);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatafailOnError != null)
            {
                if (inputInfopathDatafailOnError != null)
                {
                    inputInfopathData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputInfopathDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertPdfa(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDatapDFProfileInput>> inputPdfDatapDFProfile, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_pdfa";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPdfData = new JObject();
            var inputPdfDatapropCount = 0;
            inputPdfData["use_async_pattern"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepointFileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
            inputPdfData["copy_metadata"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["pdf_profile"] = CSharpExpressionConverter.Convert(inputPdfDatapDFProfile);
            if (inputPdfDataoverrideSettings != null)
            {
                inputPdfData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputPdfDataoverrideSettings);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                if (inputPdfDatafailOnError != null)
                {
                    inputPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertPowerpoint(Expression<Func<string>> inputPowerpointDatasourceFileName, Expression<Func<string>> inputPowerpointDatasourceFileContent, Expression<Func<inputPowerpointDataoutputFormatInput>> inputPowerpointDataoutputFormat, Expression<Func<inputPowerpointDatarangeInput>> inputPowerpointDatarange = null, Expression<Func<inputPowerpointDataprintLayoutHandoutsInput>> inputPowerpointDataprintLayoutHandouts = null, Expression<Func<bool>> inputPowerpointDataframeSlides = null, Expression<Func<int>> inputPowerpointDatastartPage = null, Expression<Func<int>> inputPowerpointDataendPage = null, Expression<Func<inputPowerpointDataqualityInput>> inputPowerpointDataquality = null, Expression<Func<string>> inputPowerpointDataoverrideSettings = null, Expression<Func<bool>> inputPowerpointDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_powerpoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPowerpointData = new JObject();
            var inputPowerpointDatapropCount = 0;
            inputPowerpointData["use_async_pattern"] = false;
            inputPowerpointDatapropCount++;
            inputPowerpointDatapropCount++;
            inputPowerpointData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPowerpointData["sharepoint_file"] = sharepointFileObject;
                inputPowerpointDatapropCount++;
            }

            inputPowerpointDatapropCount++;
            inputPowerpointData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDatasourceFileContent);
            inputPowerpointDatapropCount++;
            inputPowerpointData["output_format"] = CSharpExpressionConverter.Convert(inputPowerpointDataoutputFormat);
            inputPowerpointData["copy_metadata"] = false;
            inputPowerpointDatapropCount++;
            if (inputPowerpointDatarange != null)
            {
                inputPowerpointData["range"] = CSharpExpressionConverter.Convert(inputPowerpointDatarange);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDataprintLayoutHandouts != null)
            {
                if (inputPowerpointDataprintLayoutHandouts != null)
                {
                    inputPowerpointData["print_output_type"] = CSharpExpressionConverter.Convert(inputPowerpointDataprintLayoutHandouts);
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
                    inputPowerpointData["frame_slides"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDataframeSlides);
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
                inputPowerpointData["start_page"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDatastartPage);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDataendPage != null)
            {
                inputPowerpointData["end_page"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDataendPage);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDataquality != null)
            {
                inputPowerpointData["quality"] = CSharpExpressionConverter.Convert(inputPowerpointDataquality);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDataoverrideSettings != null)
            {
                inputPowerpointData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDataoverrideSettings);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDatafailOnError != null)
            {
                if (inputPowerpointDatafailOnError != null)
                {
                    inputPowerpointData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPowerpointDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertVisio(Expression<Func<string>> inputVisioDatasourceFileName, Expression<Func<string>> inputVisioDatasourceFileContent, Expression<Func<inputVisioDataoutputFormatInput>> inputVisioDataoutputFormat, Expression<Func<inputVisioDatarangeInput>> inputVisioDatarange = null, Expression<Func<int>> inputVisioDatastartPage = null, Expression<Func<int>> inputVisioDataendPage = null, Expression<Func<inputVisioDataqualityInput>> inputVisioDataquality = null, Expression<Func<string>> inputVisioDataoverrideSettings = null, Expression<Func<bool>> inputVisioDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_visio";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputVisioData = new JObject();
            var inputVisioDatapropCount = 0;
            inputVisioData["use_async_pattern"] = false;
            inputVisioDatapropCount++;
            inputVisioDatapropCount++;
            inputVisioData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputVisioDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputVisioData["sharepoint_file"] = sharepointFileObject;
                inputVisioDatapropCount++;
            }

            inputVisioDatapropCount++;
            inputVisioData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputVisioDatasourceFileContent);
            inputVisioDatapropCount++;
            inputVisioData["output_format"] = CSharpExpressionConverter.Convert(inputVisioDataoutputFormat);
            inputVisioData["copy_metadata"] = false;
            inputVisioDatapropCount++;
            if (inputVisioDatarange != null)
            {
                inputVisioData["range"] = CSharpExpressionConverter.Convert(inputVisioDatarange);
                inputVisioDatapropCount++;
            }

            if (inputVisioDatastartPage != null)
            {
                inputVisioData["start_page"] = CSharpExpressionConverter.ConvertToken(inputVisioDatastartPage);
                inputVisioDatapropCount++;
            }

            if (inputVisioDataendPage != null)
            {
                inputVisioData["end_page"] = CSharpExpressionConverter.ConvertToken(inputVisioDataendPage);
                inputVisioDatapropCount++;
            }

            if (inputVisioDataquality != null)
            {
                inputVisioData["quality"] = CSharpExpressionConverter.Convert(inputVisioDataquality);
                inputVisioDatapropCount++;
            }

            if (inputVisioDataoverrideSettings != null)
            {
                inputVisioData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputVisioDataoverrideSettings);
                inputVisioDatapropCount++;
            }

            if (inputVisioDatafailOnError != null)
            {
                if (inputVisioDatafailOnError != null)
                {
                    inputVisioData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputVisioDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ConvertWord(Expression<Func<string>> inputWordDatasourceFileName, Expression<Func<string>> inputWordDatasourceFileContent, Expression<Func<inputWordDataoutputFormatInput>> inputWordDataoutputFormat, Expression<Func<inputWordDatadisplayForReviewInput>> inputWordDatadisplayForReview = null, Expression<Func<inputWordDatareviewMarkupModeInput>> inputWordDatareviewMarkupMode = null, Expression<Func<inputWordDatagenerateBookmarksInput>> inputWordDatagenerateBookmarks = null, Expression<Func<int>> inputWordDatastartPage = null, Expression<Func<int>> inputWordDataendPage = null, Expression<Func<inputWordDataqualityInput>> inputWordDataquality = null, Expression<Func<string>> inputWordDataoverrideSettings = null, Expression<Func<bool>> inputWordDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/convert_word";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputWordData = new JObject();
            var inputWordDatapropCount = 0;
            inputWordData["use_async_pattern"] = false;
            inputWordDatapropCount++;
            inputWordDatapropCount++;
            inputWordData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputWordDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputWordData["sharepoint_file"] = sharepointFileObject;
                inputWordDatapropCount++;
            }

            inputWordDatapropCount++;
            inputWordData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputWordDatasourceFileContent);
            inputWordDatapropCount++;
            inputWordData["output_format"] = CSharpExpressionConverter.Convert(inputWordDataoutputFormat);
            inputWordData["copy_metadata"] = false;
            inputWordDatapropCount++;
            if (inputWordDatadisplayForReview != null)
            {
                if (inputWordDatadisplayForReview != null)
                {
                    inputWordData["revisions_and_comments_display_mode"] = CSharpExpressionConverter.Convert(inputWordDatadisplayForReview);
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
                    inputWordData["revisions_and_comments_markup_mode"] = CSharpExpressionConverter.Convert(inputWordDatareviewMarkupMode);
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
                inputWordData["generate_bookmarks"] = CSharpExpressionConverter.Convert(inputWordDatagenerateBookmarks);
                inputWordDatapropCount++;
            }

            if (inputWordDatastartPage != null)
            {
                inputWordData["start_page"] = CSharpExpressionConverter.ConvertToken(inputWordDatastartPage);
                inputWordDatapropCount++;
            }

            if (inputWordDataendPage != null)
            {
                inputWordData["end_page"] = CSharpExpressionConverter.ConvertToken(inputWordDataendPage);
                inputWordDatapropCount++;
            }

            if (inputWordDataquality != null)
            {
                inputWordData["quality"] = CSharpExpressionConverter.Convert(inputWordDataquality);
                inputWordDatapropCount++;
            }

            if (inputWordDataoverrideSettings != null)
            {
                inputWordData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputWordDataoverrideSettings);
                inputWordDatapropCount++;
            }

            if (inputWordDatafailOnError != null)
            {
                if (inputWordDatafailOnError != null)
                {
                    inputWordData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputWordDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponseCommon> CopyMetadata(Expression<Func<string>> inputDatasiteUrl, Expression<Func<string>> inputDatasourceFileUrl, Expression<Func<string>> inputDatadestinationFilePath, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDatafieldsToCopy = null, Expression<Func<string>> inputDatadestinationContentType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/copy_metadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputDatapropCount++;
            inputData["site_url"] = CSharpExpressionConverter.ConvertToken(inputDatasiteUrl);
            inputDatapropCount++;
            inputData["source_file_url"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileUrl);
            inputDatapropCount++;
            inputData["destination_file_url"] = CSharpExpressionConverter.ConvertToken(inputDatadestinationFilePath);
            if (inputDatauserName != null)
            {
                inputData["username"] = CSharpExpressionConverter.ConvertToken(inputDatauserName);
                inputDatapropCount++;
            }

            if (inputDatapassword != null)
            {
                inputData["password"] = CSharpExpressionConverter.ConvertToken(inputDatapassword);
                inputDatapropCount++;
            }

            if (inputDatafieldsToCopy != null)
            {
                inputData["copy_fields"] = CSharpExpressionConverter.ConvertToken(inputDatafieldsToCopy);
                inputDatapropCount++;
            }

            if (inputDatadestinationContentType != null)
            {
                inputData["content_type"] = CSharpExpressionConverter.ConvertToken(inputDatadestinationContentType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafillColor = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/ellipse_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatafillColor);
                inputDatapropCount++;
            }

            if (inputDatalineColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatalineColor);
                inputDatapropCount++;
            }

            if (inputDatalineWidth != null)
            {
                inputData["line_width"] = CSharpExpressionConverter.ConvertToken(inputDatalineWidth);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ExportFormData(Expression<Func<string>> inputFromPdfDatasourceFileName, Expression<Func<string>> inputFromPdfDatasourceFileContent, Expression<Func<inputFromPdfDataoutputDataFormatInput>> inputFromPdfDataoutputDataFormat, Expression<Func<bool>> inputFromPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/export_form_data";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputFromPdfData = new JObject();
            var inputFromPdfDatapropCount = 0;
            inputFromPdfData["use_async_pattern"] = false;
            inputFromPdfDatapropCount++;
            inputFromPdfDatapropCount++;
            inputFromPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputFromPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputFromPdfData["sharepoint_file"] = sharepointFileObject;
                inputFromPdfDatapropCount++;
            }

            inputFromPdfDatapropCount++;
            inputFromPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputFromPdfDatasourceFileContent);
            inputFromPdfDatapropCount++;
            inputFromPdfData["output_format"] = CSharpExpressionConverter.Convert(inputFromPdfDataoutputDataFormat);
            inputFromPdfData["copy_metadata"] = false;
            inputFromPdfDatapropCount++;
            if (inputFromPdfDatafailOnError != null)
            {
                if (inputFromPdfDatafailOnError != null)
                {
                    inputFromPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputFromPdfDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ExtractText(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/extract_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPdfData = new JObject();
            var inputPdfDatapropCount = 0;
            inputPdfData["use_async_pattern"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepointFileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
            if (inputPdfDatapageRange != null)
            {
                if (inputPdfDatapageRange != null)
                {
                    inputPdfData["page_range"] = CSharpExpressionConverter.ConvertToken(inputPdfDatapageRange);
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
                    inputPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ImageWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDataimage, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/image_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["image_file"] = CSharpExpressionConverter.ConvertToken(inputDataimage);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkOutlineColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkOutlineColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkOutlineWidth != null)
            {
                inputData["line_width"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkOutlineWidth);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ImportFormData(Expression<Func<string>> inputXmlDatasourceFileName, Expression<Func<string>> inputXmlDatasourceFileContent, Expression<Func<string>> inputXmlDatapDFFormFileContent = null, Expression<Func<string>> inputXmlDatapDFFormURL = null, Expression<Func<string>> inputXmlDatausername = null, Expression<Func<string>> inputXmlDatadomain = null, Expression<Func<string>> inputXmlDatapassword = null, Expression<Func<inputXmlDataflattenInput>> inputXmlDataflatten = null, Expression<Func<inputXmlDatareadOnlyInput>> inputXmlDatareadOnly = null, Expression<Func<string>> inputXmlDataoverrideSettings = null, Expression<Func<bool>> inputXmlDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/import_form_data";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputXmlData = new JObject();
            var inputXmlDatapropCount = 0;
            inputXmlData["use_async_pattern"] = false;
            inputXmlDatapropCount++;
            inputXmlDatapropCount++;
            inputXmlData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputXmlDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputXmlData["sharepoint_file"] = sharepointFileObject;
                inputXmlDatapropCount++;
            }

            inputXmlDatapropCount++;
            inputXmlData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputXmlDatasourceFileContent);
            inputXmlData["copy_metadata"] = false;
            inputXmlDatapropCount++;
            if (inputXmlDatapDFFormFileContent != null)
            {
                inputXmlData["pdf_template_file_content"] = CSharpExpressionConverter.ConvertToken(inputXmlDatapDFFormFileContent);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatapDFFormURL != null)
            {
                inputXmlData["pdf_template_url"] = CSharpExpressionConverter.ConvertToken(inputXmlDatapDFFormURL);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatausername != null)
            {
                inputXmlData["pdf_template_username"] = CSharpExpressionConverter.ConvertToken(inputXmlDatausername);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatadomain != null)
            {
                inputXmlData["pdf_template_domain"] = CSharpExpressionConverter.ConvertToken(inputXmlDatadomain);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatapassword != null)
            {
                inputXmlData["pdf_template_password"] = CSharpExpressionConverter.ConvertToken(inputXmlDatapassword);
                inputXmlDatapropCount++;
            }

            if (inputXmlDataflatten != null)
            {
                if (inputXmlDataflatten != null)
                {
                    inputXmlData["flatten"] = CSharpExpressionConverter.Convert(inputXmlDataflatten);
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
                    inputXmlData["read_only"] = CSharpExpressionConverter.Convert(inputXmlDatareadOnly);
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
                inputXmlData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputXmlDataoverrideSettings);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatafailOnError != null)
            {
                if (inputXmlDatafailOnError != null)
                {
                    inputXmlData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputXmlDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDataoCRLanguage = null, Expression<Func<inputPdfDatadPIInput>> inputPdfDatadPI = null, Expression<Func<inputPdfDatakVPOutputFormatInput>> inputPdfDatakVPOutputFormat = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<inputPdfDataautorotateInput>> inputPdfDataautorotate = null, Expression<Func<inputPdfDatatrimSymbolsInput>> inputPdfDatatrimSymbols = null, Expression<Func<inputPdfDataincludeKeyBoundingBoxInput>> inputPdfDataincludeKeyBoundingBox = null, Expression<Func<inputPdfDataincludeValueBoundingBoxInput>> inputPdfDataincludeValueBoundingBox = null, Expression<Func<inputPdfDataincludePageNumberInput>> inputPdfDataincludePageNumber = null, Expression<Func<inputPdfDataincludeConfidenceInput>> inputPdfDataincludeConfidence = null, Expression<Func<int>> inputPdfDataconfidenceThreshold = null, Expression<Func<inputPdfDataincludeTypeInput>> inputPdfDataincludeType = null, Expression<Func<string>> inputPdfDataexpectedKeys = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/key_value_pairs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPdfData = new JObject();
            var inputPdfDatapropCount = 0;
            inputPdfData["use_async_pattern"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepointFileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
            if (inputPdfDataoCRLanguage != null)
            {
                if (inputPdfDataoCRLanguage != null)
                {
                    inputPdfData["ocr_language"] = CSharpExpressionConverter.ConvertToken(inputPdfDataoCRLanguage);
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
                    inputPdfData["dpi"] = CSharpExpressionConverter.Convert(inputPdfDatadPI);
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
                    inputPdfData["kvp_format"] = CSharpExpressionConverter.Convert(inputPdfDatakVPOutputFormat);
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
                    inputPdfData["page_range"] = CSharpExpressionConverter.ConvertToken(inputPdfDatapageRange);
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
                    inputPdfData["autorotate"] = CSharpExpressionConverter.Convert(inputPdfDataautorotate);
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
                    inputPdfData["trim_symbols"] = CSharpExpressionConverter.Convert(inputPdfDatatrimSymbols);
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
                    inputPdfData["include_key_bounding_box"] = CSharpExpressionConverter.Convert(inputPdfDataincludeKeyBoundingBox);
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
                    inputPdfData["include_value_bounding_box"] = CSharpExpressionConverter.Convert(inputPdfDataincludeValueBoundingBox);
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
                    inputPdfData["include_page_number"] = CSharpExpressionConverter.Convert(inputPdfDataincludePageNumber);
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
                    inputPdfData["include_confidence"] = CSharpExpressionConverter.Convert(inputPdfDataincludeConfidence);
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
                    inputPdfData["confidence_threshold"] = CSharpExpressionConverter.ConvertToken(inputPdfDataconfidenceThreshold);
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
                    inputPdfData["include_type"] = CSharpExpressionConverter.Convert(inputPdfDataincludeType);
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
                inputPdfData["expected_keys"] = CSharpExpressionConverter.ConvertToken(inputPdfDataexpectedKeys);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                if (inputPdfDatafailOnError != null)
                {
                    inputPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> LineWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDataxCoordinateStart, Expression<Func<string>> inputDatayCoordinateStart, Expression<Func<string>> inputDataxCoordinateEnd, Expression<Func<string>> inputDatayCoordinateEnd, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/line_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinateStart);
            inputDatapropCount++;
            inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinateStart);
            inputDatapropCount++;
            inputData["end_x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinateEnd);
            inputDatapropCount++;
            inputData["end_y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinateEnd);
            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatalineColor);
                inputDatapropCount++;
            }

            if (inputDatalineWidth != null)
            {
                inputData["line_width"] = CSharpExpressionConverter.ConvertToken(inputDatalineWidth);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatabarcodeContent, Expression<Func<inputDatabarcodeTypeInput>> inputDatabarcodeType, Expression<Func<inputDatadisableCheckDigitInput>> inputDatadisableCheckDigit, Expression<Func<inputDatashowCheckDigitInput>> inputDatashowCheckDigit, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDataomitEncodingOfStartStopSymbolsInput>> inputDataomitEncodingOfStartStopSymbols = null, Expression<Func<string>> inputDatamargin = null, Expression<Func<string>> inputDatafontFamily = null, Expression<Func<string>> inputDatafontSize = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<inputDatalabelPlacementInput>> inputDatalabelPlacement = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatabarcodeBackgroundColor = null, Expression<Func<string>> inputDatabarcodeBarColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/linear_barcode_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["content"] = CSharpExpressionConverter.ConvertToken(inputDatabarcodeContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["barcode_type"] = CSharpExpressionConverter.Convert(inputDatabarcodeType);
            if (inputDataomitEncodingOfStartStopSymbols != null)
            {
                if (inputDataomitEncodingOfStartStopSymbols != null)
                {
                    inputData["omit_start_stop_symbols"] = CSharpExpressionConverter.Convert(inputDataomitEncodingOfStartStopSymbols);
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
            inputData["disable_checkdigit"] = CSharpExpressionConverter.Convert(inputDatadisableCheckDigit);
            inputDatapropCount++;
            inputData["show_checkdigit"] = CSharpExpressionConverter.Convert(inputDatashowCheckDigit);
            if (inputDatamargin != null)
            {
                inputData["margin"] = CSharpExpressionConverter.ConvertToken(inputDatamargin);
                inputDatapropCount++;
            }

            if (inputDatafontFamily != null)
            {
                inputData["font_family_name"] = CSharpExpressionConverter.ConvertToken(inputDatafontFamily);
                inputDatapropCount++;
            }

            if (inputDatafontSize != null)
            {
                inputData["font_size"] = CSharpExpressionConverter.ConvertToken(inputDatafontSize);
                inputDatapropCount++;
            }

            if (inputDatafontStyle != null)
            {
                inputData["font_style"] = CSharpExpressionConverter.ConvertToken(inputDatafontStyle);
                inputDatapropCount++;
            }

            if (inputDatalabelPlacement != null)
            {
                if (inputDatalabelPlacement != null)
                {
                    inputData["label_placement"] = CSharpExpressionConverter.Convert(inputDatalabelPlacement);
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
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatabarcodeBackgroundColor);
                inputDatapropCount++;
            }

            if (inputDatabarcodeBarColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatabarcodeBarColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> MergeToPdf(Expression<Func<string>> inputDatasourceFileName1 = null, Expression<Func<string>> inputDatasourceFileContent1 = null, Expression<Func<string>> inputDatasourceFileName2 = null, Expression<Func<string>> inputDatasourceFileContent2 = null, Expression<Func<string>> inputDatasourceFileName3 = null, Expression<Func<string>> inputDatasourceFileContent3 = null, Expression<Func<string>> inputDatasourceFileName4 = null, Expression<Func<string>> inputDatasourceFileContent4 = null, Expression<Func<string>> inputDatasourceFileName5 = null, Expression<Func<string>> inputDatasourceFileContent5 = null, Expression<Func<inputDataeachDocumentInput>> inputDataeachDocument = null, Expression<Func<MergeSourceFile[]>> inputDatasourceFiles = null, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["source_file_name_1"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName1);
                inputDatapropCount++;
            }

            if (inputDatasourceFileContent1 != null)
            {
                inputData["source_file_content_1"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent1);
                inputDatapropCount++;
            }

            if (inputDatasourceFileName2 != null)
            {
                inputData["source_file_name_2"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName2);
                inputDatapropCount++;
            }

            if (inputDatasourceFileContent2 != null)
            {
                inputData["source_file_content_2"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent2);
                inputDatapropCount++;
            }

            if (inputDatasourceFileName3 != null)
            {
                inputData["source_file_name_3"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName3);
                inputDatapropCount++;
            }

            if (inputDatasourceFileContent3 != null)
            {
                inputData["source_file_content_3"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent3);
                inputDatapropCount++;
            }

            if (inputDatasourceFileName4 != null)
            {
                inputData["source_file_name_4"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName4);
                inputDatapropCount++;
            }

            if (inputDatasourceFileContent4 != null)
            {
                inputData["source_file_content_4"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent4);
                inputDatapropCount++;
            }

            if (inputDatasourceFileName5 != null)
            {
                inputData["source_file_name_5"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName5);
                inputDatapropCount++;
            }

            if (inputDatasourceFileContent5 != null)
            {
                inputData["source_file_content_5"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent5);
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
                    inputData["document_start_page"] = CSharpExpressionConverter.Convert(inputDataeachDocument);
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
                inputData["source_files"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFiles);
                inputDatapropCount++;
            }

            if (inputDataoverrideSettings != null)
            {
                inputData["override_settings"] = CSharpExpressionConverter.ConvertToken(inputDataoverrideSettings);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> OcrPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<string>> inputDataregions = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/ocr_pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
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
                    inputData["language"] = CSharpExpressionConverter.Convert(inputDatalanguage);
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
                    inputData["performance"] = CSharpExpressionConverter.Convert(inputDataperformance);
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
                    inputData["characters_option"] = CSharpExpressionConverter.Convert(inputDatablacklistWhitelist);
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
                inputData["characters"] = CSharpExpressionConverter.ConvertToken(inputDatacharacters);
                inputDatapropCount++;
            }

            if (inputDatausePagination != null)
            {
                if (inputDatausePagination != null)
                {
                    inputData["paginate"] = CSharpExpressionConverter.ConvertToken(inputDatausePagination);
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
                inputData["regions"] = CSharpExpressionConverter.ConvertToken(inputDataregions);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OcrOperationResponse> OcrText(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<string>> inputDatawidth = null, Expression<Func<string>> inputDataheight = null, Expression<Func<string>> inputDatapageNumber = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/ocr_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
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
                    inputData["language"] = CSharpExpressionConverter.Convert(inputDatalanguage);
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
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatawidth != null)
            {
                inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
            }

            if (inputDataheight != null)
            {
                inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
                inputDatapropCount++;
            }

            if (inputDatapageNumber != null)
            {
                if (inputDatapageNumber != null)
                {
                    inputData["page_number"] = CSharpExpressionConverter.ConvertToken(inputDatapageNumber);
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
                    inputData["performance"] = CSharpExpressionConverter.Convert(inputDataperformance);
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
                    inputData["characters_option"] = CSharpExpressionConverter.Convert(inputDatablacklistWhitelist);
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
                inputData["characters"] = CSharpExpressionConverter.ConvertToken(inputDatacharacters);
                inputDatapropCount++;
            }

            if (inputDatausePagination != null)
            {
                if (inputDatausePagination != null)
                {
                    inputData["paginate"] = CSharpExpressionConverter.ConvertToken(inputDatausePagination);
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
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> PdfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatapDFWatermark, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/pdf_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["pdf_file"] = CSharpExpressionConverter.ConvertToken(inputDatapDFWatermark);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatacontent, Expression<Func<inputDataversionInput>> inputDataversion, Expression<Func<inputDatainputModeInput>> inputDatainputMode, Expression<Func<inputDataerrorCorrectionLevelInput>> inputDataerrorCorrectionLevel, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkForegroundColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/qr_code_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["content"] = CSharpExpressionConverter.ConvertToken(inputDatacontent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["version"] = CSharpExpressionConverter.Convert(inputDataversion);
            inputDatapropCount++;
            inputData["input_mode"] = CSharpExpressionConverter.Convert(inputDatainputMode);
            inputDatapropCount++;
            inputData["error_correction_level"] = CSharpExpressionConverter.Convert(inputDataerrorCorrectionLevel);
            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkForegroundColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkForegroundColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/rectangle_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkOutlineColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkOutlineColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkOutlineWidth != null)
            {
                inputData["line_width"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkOutlineWidth);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> RtfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/rtf_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["rtf_data"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkOutlineColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkOutlineColor);
                inputDatapropCount++;
            }

            if (inputDatawatermarkOutlineWidth != null)
            {
                inputData["line_width"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkOutlineWidth);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> SecurePdf(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataopenPassword = null, Expression<Func<string>> inputDataownerPassword = null, Expression<Func<string>> inputDatapDFRestrictions = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            if (inputDataopenPassword != null)
            {
                inputData["open_password"] = CSharpExpressionConverter.ConvertToken(inputDataopenPassword);
                inputDatapropCount++;
            }

            if (inputDataownerPassword != null)
            {
                inputData["owner_password"] = CSharpExpressionConverter.ConvertToken(inputDataownerPassword);
                inputDatapropCount++;
            }

            if (inputDatapDFRestrictions != null)
            {
                inputData["security_options"] = CSharpExpressionConverter.ConvertToken(inputDatapDFRestrictions);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<SplitOperationResponse> SplitPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatasplitByInput>> inputDatasplitBy, Expression<Func<int>> inputDatasplitParameter, Expression<Func<string>> inputDatafileNameTemplate = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/split_pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            if (inputDatafileNameTemplate != null)
            {
                inputData["file_name_template"] = CSharpExpressionConverter.ConvertToken(inputDatafileNameTemplate);
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["file_split_by"] = CSharpExpressionConverter.Convert(inputDatasplitBy);
            inputDatapropCount++;
            inputData["split_parameter"] = CSharpExpressionConverter.ConvertToken(inputDatasplitParameter);
            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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
        public IBodyWorkflowAction<OperationResponse> TextWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<string>> inputDatafontFamilyName, Expression<Func<string>> inputDatafontSize, Expression<Func<string>> inputDatafontColor, Expression<Func<inputDatatextAlignmentInput>> inputDatatextAlignment, Expression<Func<inputDatawordWrapInput>> inputDatawordWrap, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<string>> inputDatafontOutlineColor = null, Expression<Func<string>> inputDatafontOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/text_watermark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            if (inputDatasourceFileName != null)
            {
                inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
            }

            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            inputDatapropCount++;
            inputData["content"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            inputDatapropCount++;
            inputData["font_family_name"] = CSharpExpressionConverter.ConvertToken(inputDatafontFamilyName);
            inputDatapropCount++;
            inputData["font_size"] = CSharpExpressionConverter.ConvertToken(inputDatafontSize);
            inputDatapropCount++;
            inputData["fill_color"] = CSharpExpressionConverter.ConvertToken(inputDatafontColor);
            inputDatapropCount++;
            inputData["alignment"] = CSharpExpressionConverter.Convert(inputDatatextAlignment);
            inputDatapropCount++;
            inputData["word_wrap"] = CSharpExpressionConverter.Convert(inputDatawordWrap);
            inputDatapropCount++;
            inputData["position"] = CSharpExpressionConverter.Convert(inputDataposition);
            inputDatapropCount++;
            inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
            inputDatapropCount++;
            inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatalayer != null)
            {
                if (inputDatalayer != null)
                {
                    inputData["layer"] = CSharpExpressionConverter.Convert(inputDatalayer);
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
                inputData["rotation"] = CSharpExpressionConverter.ConvertToken(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                if (inputDataopacity != null)
                {
                    inputData["opacity"] = CSharpExpressionConverter.ConvertToken(inputDataopacity);
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
                inputData["font_style"] = CSharpExpressionConverter.ConvertToken(inputDatafontStyle);
                inputDatapropCount++;
            }

            if (inputDatafontOutlineColor != null)
            {
                inputData["line_color"] = CSharpExpressionConverter.ConvertToken(inputDatafontOutlineColor);
                inputDatapropCount++;
            }

            if (inputDatafontOutlineWidth != null)
            {
                inputData["line_width"] = CSharpExpressionConverter.ConvertToken(inputDatafontOutlineWidth);
                inputDatapropCount++;
            }

            if (inputDatawatermarkStartPage != null)
            {
                inputData["start_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndPage != null)
            {
                inputData["end_page"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageInterval != null)
            {
                inputData["page_interval"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageOrientation != null)
            {
                if (inputDatawatermarkPageOrientation != null)
                {
                    inputData["page_orientation"] = CSharpExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                    inputData["print_only"] = CSharpExpressionConverter.Convert(inputDataprintOnly);
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
                inputData["start_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkEndSection != null)
            {
                inputData["end_section"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                inputDatapropCount++;
            }

            if (inputDatawatermarkPageType != null)
            {
                inputData["page_type"] = CSharpExpressionConverter.ConvertToken(inputDatawatermarkPageType);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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