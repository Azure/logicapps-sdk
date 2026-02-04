//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkData, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputPdfData["remove_annotations"] = ExpressionConverter.ConvertO(inputPdfDataremoveAnnotations);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveBlankPages != null)
            {
                inputPdfData["remove_blank_pages"] = ExpressionConverter.ConvertO(inputPdfDataremoveBlankPages);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveBookmarks != null)
            {
                inputPdfData["remove_bookmarks"] = ExpressionConverter.ConvertO(inputPdfDataremoveBookmarks);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveEmbeddedFiles != null)
            {
                inputPdfData["remove_embedded_files"] = ExpressionConverter.ConvertO(inputPdfDataremoveEmbeddedFiles);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveFormFields != null)
            {
                inputPdfData["remove_form_fields"] = ExpressionConverter.ConvertO(inputPdfDataremoveFormFields);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveHyperlinks != null)
            {
                inputPdfData["remove_hyperlinks"] = ExpressionConverter.ConvertO(inputPdfDataremoveHyperlinks);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveJavaScript != null)
            {
                inputPdfData["remove_javascript"] = ExpressionConverter.ConvertO(inputPdfDataremoveJavaScript);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremoveMetadata != null)
            {
                inputPdfData["remove_metadata"] = ExpressionConverter.ConvertO(inputPdfDataremoveMetadata);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataremovePageThumbnails != null)
            {
                inputPdfData["remove_page_thumbnails"] = ExpressionConverter.ConvertO(inputPdfDataremovePageThumbnails);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapackFonts != null)
            {
                inputPdfData["pack_fonts"] = ExpressionConverter.ConvertO(inputPdfDatapackFonts);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapackDocument != null)
            {
                inputPdfData["pack_document"] = ExpressionConverter.ConvertO(inputPdfDatapackDocument);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatarecompressImages != null)
            {
                inputPdfData["recompress_images"] = ExpressionConverter.ConvertO(inputPdfDatarecompressImages);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataenableMRC != null)
            {
                inputPdfData["enable_mrc"] = ExpressionConverter.ConvertO(inputPdfDataenableMRC);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatadownscaleResolutionMRC != null)
            {
                inputPdfData["downscale_resolution_mrc"] = ExpressionConverter.ConvertO(inputPdfDatadownscaleResolutionMRC);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapreserveSmoothing != null)
            {
                inputPdfData["preserve_smoothing"] = ExpressionConverter.ConvertO(inputPdfDatapreserveSmoothing);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataimageQuality != null)
            {
                inputPdfData["image_quality"] = ExpressionConverter.ConvertO(inputPdfDataimageQuality);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatadownscaleImages != null)
            {
                inputPdfData["downscale_images"] = ExpressionConverter.ConvertO(inputPdfDatadownscaleImages);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatadownscaleResolution != null)
            {
                inputPdfData["downscale_resolution"] = ExpressionConverter.ConvertO(inputPdfDatadownscaleResolution);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataenableColorDetection != null)
            {
                inputPdfData["enable_color_detection"] = ExpressionConverter.ConvertO(inputPdfDataenableColorDetection);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataenableCharRepair != null)
            {
                inputPdfData["enable_char_repair"] = ExpressionConverter.ConvertO(inputPdfDataenableCharRepair);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataenableJPEG2000 != null)
            {
                inputPdfData["enable_jpeg2000"] = ExpressionConverter.ConvertO(inputPdfDataenableJPEG2000);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataenableJBIG2 != null)
            {
                inputPdfData["enable_jbig2"] = ExpressionConverter.ConvertO(inputPdfDataenableJBIG2);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatajBIG2PMSThreshold != null)
            {
                inputPdfData["jbig2_pms_threshold"] = ExpressionConverter.ConvertO(inputPdfDatajBIG2PMSThreshold);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataoverrideSettings != null)
            {
                inputPdfData["override_settings"] = ExpressionConverter.ConvertO(inputPdfDataoverrideSettings);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputCadData["paper_size"] = ExpressionConverter.ConvertO(inputCadDatapaperSize);
                inputCadDatapropCount++;
            }

            if (inputCadDatapaperSizeCustom != null)
            {
                inputCadData["paper_size_custom"] = ExpressionConverter.ConvertO(inputCadDatapaperSizeCustom);
                inputCadDatapropCount++;
            }

            if (inputCadDatapageMargins != null)
            {
                inputCadData["page_margins"] = ExpressionConverter.ConvertO(inputCadDatapageMargins);
                inputCadDatapropCount++;
            }

            if (inputCadDatabackgroundColor != null)
            {
                inputCadData["background_color"] = ExpressionConverter.ConvertO(inputCadDatabackgroundColor);
                inputCadDatapropCount++;
            }

            if (inputCadDataforegroundColor != null)
            {
                inputCadData["foreground_color"] = ExpressionConverter.ConvertO(inputCadDataforegroundColor);
                inputCadDatapropCount++;
            }

            if (inputCadDataforegroundColorCustom != null)
            {
                inputCadData["foreground_color_custom"] = ExpressionConverter.ConvertO(inputCadDataforegroundColorCustom);
                inputCadDatapropCount++;
            }

            if (inputCadDataemptyLayoutDetection != null)
            {
                inputCadData["empty_layout_detection_mode"] = ExpressionConverter.ConvertO(inputCadDataemptyLayoutDetection);
                inputCadDatapropCount++;
            }

            if (inputCadDatalayoutSortOrder != null)
            {
                inputCadData["layout_sort_order"] = ExpressionConverter.ConvertO(inputCadDatalayoutSortOrder);
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
                inputCadData["fail_on_error"] = ExpressionConverter.ConvertO(inputCadDatafailOnError);
                inputCadDatapropCount++;
            }

            if (inputCadDatapropCount > 0)
            {
                callPayload.Body = inputCadData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputEmailData["convert_attachments"] = ExpressionConverter.ConvertO(inputEmailDataincludeAttachments);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataattachmentAction != null)
            {
                inputEmailData["attachment_merge_mode"] = ExpressionConverter.ConvertO(inputEmailDataattachmentAction);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataattachmentSummary != null)
            {
                inputEmailData["display_attachment_summary"] = ExpressionConverter.ConvertO(inputEmailDataattachmentSummary);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataunsupportedAttachmentAction != null)
            {
                inputEmailData["unsupported_attachment_behaviour"] = ExpressionConverter.ConvertO(inputEmailDataunsupportedAttachmentAction);
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
                inputEmailData["viewport_Size"] = ExpressionConverter.ConvertO(inputEmailDataviewportSize);
                inputEmailDatapropCount++;
            }

            if (inputEmailDatapaperSize != null)
            {
                inputEmailData["paper_size"] = ExpressionConverter.ConvertO(inputEmailDatapaperSize);
                inputEmailDatapropCount++;
            }

            if (inputEmailDatapaperSizeCustom != null)
            {
                inputEmailData["paper_size_custom"] = ExpressionConverter.ConvertO(inputEmailDatapaperSizeCustom);
                inputEmailDatapropCount++;
            }

            if (inputEmailDatapageMargins != null)
            {
                inputEmailData["page_margins"] = ExpressionConverter.ConvertO(inputEmailDatapageMargins);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataattachmentErrors != null)
            {
                inputEmailData["break_merge_on_error"] = ExpressionConverter.ConvertO(inputEmailDataattachmentErrors);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataminImageSize != null)
            {
                inputEmailData["minimum_image_attachment_dimension"] = ExpressionConverter.ConvertO(inputEmailDataminImageSize);
                inputEmailDatapropCount++;
            }

            if (inputEmailDataofflineMode != null)
            {
                inputEmailData["enable_offline_mode"] = ExpressionConverter.ConvertO(inputEmailDataofflineMode);
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
                inputEmailData["fail_on_error"] = ExpressionConverter.ConvertO(inputEmailDatafailOnError);
                inputEmailDatapropCount++;
            }

            if (inputEmailDatapropCount > 0)
            {
                callPayload.Body = inputEmailData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputExcelData["unhide_all_rows"] = ExpressionConverter.ConvertO(inputExcelDatarevealHiddenRows);
                inputExcelDatapropCount++;
            }

            if (inputExcelDatarevealHiddenColumns != null)
            {
                inputExcelData["unhide_all_columns"] = ExpressionConverter.ConvertO(inputExcelDatarevealHiddenColumns);
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
                inputExcelData["fail_on_error"] = ExpressionConverter.ConvertO(inputExcelDatafailOnError);
                inputExcelDatapropCount++;
            }

            if (inputExcelDatapropCount > 0)
            {
                callPayload.Body = inputExcelData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
            inputData["source_url_or_html"] = ExpressionConverter.ConvertO(inputDatasourceURLOrHTML);
            if (inputDatapageOrientation != null)
            {
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatapageOrientation);
                inputDatapropCount++;
            }

            if (inputDatamediaType != null)
            {
                inputData["media_type"] = ExpressionConverter.ConvertO(inputDatamediaType);
                inputDatapropCount++;
            }

            if (inputDataauthenticationType != null)
            {
                inputData["authentication_type"] = ExpressionConverter.ConvertO(inputDataauthenticationType);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputInfopathData["convert_attachments"] = ExpressionConverter.ConvertO(inputInfopathDataincludeAttachment);
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
                inputInfopathData["default_page_orientation"] = ExpressionConverter.ConvertO(inputInfopathDatadefaultPageOrientation);
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
                inputInfopathData["fail_on_error"] = ExpressionConverter.ConvertO(inputInfopathDatafailOnError);
                inputInfopathDatapropCount++;
            }

            if (inputInfopathDatapropCount > 0)
            {
                callPayload.Body = inputInfopathData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputPowerpointData["print_output_type"] = ExpressionConverter.ConvertO(inputPowerpointDataprintLayoutHandouts);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDataframeSlides != null)
            {
                inputPowerpointData["frame_slides"] = ExpressionConverter.ConvertO(inputPowerpointDataframeSlides);
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
                inputPowerpointData["fail_on_error"] = ExpressionConverter.ConvertO(inputPowerpointDatafailOnError);
                inputPowerpointDatapropCount++;
            }

            if (inputPowerpointDatapropCount > 0)
            {
                callPayload.Body = inputPowerpointData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputVisioData["fail_on_error"] = ExpressionConverter.ConvertO(inputVisioDatafailOnError);
                inputVisioDatapropCount++;
            }

            if (inputVisioDatapropCount > 0)
            {
                callPayload.Body = inputVisioData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputWordData["revisions_and_comments_display_mode"] = ExpressionConverter.ConvertO(inputWordDatadisplayForReview);
                inputWordDatapropCount++;
            }

            if (inputWordDatareviewMarkupMode != null)
            {
                inputWordData["revisions_and_comments_markup_mode"] = ExpressionConverter.ConvertO(inputWordDatareviewMarkupMode);
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
                inputWordData["fail_on_error"] = ExpressionConverter.ConvertO(inputWordDatafailOnError);
                inputWordDatapropCount++;
            }

            if (inputWordDatapropCount > 0)
            {
                callPayload.Body = inputWordData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponseCommon> CopyMetadata(Expression<Func<string>> inputDatasiteUrl, Expression<Func<string>> inputDatasourceFileUrl, Expression<Func<string>> inputDatadestinationFilePath, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDatafieldsToCopy = null, Expression<Func<string>> inputDatadestinationContentType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponseCommon>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafillColor = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputFromPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputFromPdfDatafailOnError);
                inputFromPdfDatapropCount++;
            }

            if (inputFromPdfDatapropCount > 0)
            {
                callPayload.Body = inputFromPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> ImageWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDataimage, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputXmlData["flatten"] = ExpressionConverter.ConvertO(inputXmlDataflatten);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatareadOnly != null)
            {
                inputXmlData["read_only"] = ExpressionConverter.ConvertO(inputXmlDatareadOnly);
                inputXmlDatapropCount++;
            }

            if (inputXmlDataoverrideSettings != null)
            {
                inputXmlData["override_settings"] = ExpressionConverter.ConvertO(inputXmlDataoverrideSettings);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatafailOnError != null)
            {
                inputXmlData["fail_on_error"] = ExpressionConverter.ConvertO(inputXmlDatafailOnError);
                inputXmlDatapropCount++;
            }

            if (inputXmlDatapropCount > 0)
            {
                callPayload.Body = inputXmlData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputPdfData["ocr_language"] = ExpressionConverter.ConvertO(inputPdfDataoCRLanguage);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatadPI != null)
            {
                inputPdfData["dpi"] = ExpressionConverter.ConvertO(inputPdfDatadPI);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatakVPOutputFormat != null)
            {
                inputPdfData["kvp_format"] = ExpressionConverter.ConvertO(inputPdfDatakVPOutputFormat);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapageRange != null)
            {
                inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataautorotate != null)
            {
                inputPdfData["autorotate"] = ExpressionConverter.ConvertO(inputPdfDataautorotate);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatatrimSymbols != null)
            {
                inputPdfData["trim_symbols"] = ExpressionConverter.ConvertO(inputPdfDatatrimSymbols);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeKeyBoundingBox != null)
            {
                inputPdfData["include_key_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeKeyBoundingBox);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeValueBoundingBox != null)
            {
                inputPdfData["include_value_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeValueBoundingBox);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludePageNumber != null)
            {
                inputPdfData["include_page_number"] = ExpressionConverter.ConvertO(inputPdfDataincludePageNumber);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeConfidence != null)
            {
                inputPdfData["include_confidence"] = ExpressionConverter.ConvertO(inputPdfDataincludeConfidence);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataconfidenceThreshold != null)
            {
                inputPdfData["confidence_threshold"] = ExpressionConverter.ConvertO(inputPdfDataconfidenceThreshold);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeType != null)
            {
                inputPdfData["include_type"] = ExpressionConverter.ConvertO(inputPdfDataincludeType);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataexpectedKeys != null)
            {
                inputPdfData["expected_keys"] = ExpressionConverter.ConvertO(inputPdfDataexpectedKeys);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> LineWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDataxCoordinateStart, Expression<Func<string>> inputDatayCoordinateStart, Expression<Func<string>> inputDataxCoordinateEnd, Expression<Func<string>> inputDatayCoordinateEnd, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatabarcodeContent, Expression<Func<inputDatabarcodeTypeInput>> inputDatabarcodeType, Expression<Func<inputDatadisableCheckDigitInput>> inputDatadisableCheckDigit, Expression<Func<inputDatashowCheckDigitInput>> inputDatashowCheckDigit, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDataomitEncodingOfStartStopSymbolsInput>> inputDataomitEncodingOfStartStopSymbols = null, Expression<Func<string>> inputDatamargin = null, Expression<Func<string>> inputDatafontFamily = null, Expression<Func<string>> inputDatafontSize = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<inputDatalabelPlacementInput>> inputDatalabelPlacement = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatabarcodeBackgroundColor = null, Expression<Func<string>> inputDatabarcodeBarColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["omit_start_stop_symbols"] = ExpressionConverter.ConvertO(inputDataomitEncodingOfStartStopSymbols);
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
                inputData["label_placement"] = ExpressionConverter.ConvertO(inputDatalabelPlacement);
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputData["document_start_page"] = ExpressionConverter.ConvertO(inputDataeachDocument);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
                inputDatapropCount++;
            }

            if (inputDataperformance != null)
            {
                inputData["performance"] = ExpressionConverter.ConvertO(inputDataperformance);
                inputDatapropCount++;
            }

            if (inputDatablacklistWhitelist != null)
            {
                inputData["characters_option"] = ExpressionConverter.ConvertO(inputDatablacklistWhitelist);
                inputDatapropCount++;
            }

            if (inputDatacharacters != null)
            {
                inputData["characters"] = ExpressionConverter.ConvertO(inputDatacharacters);
                inputDatapropCount++;
            }

            if (inputDatausePagination != null)
            {
                inputData["paginate"] = ExpressionConverter.ConvertO(inputDatausePagination);
                inputDatapropCount++;
            }

            if (inputDataregions != null)
            {
                inputData["regions"] = ExpressionConverter.ConvertO(inputDataregions);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
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
                inputData["page_number"] = ExpressionConverter.ConvertO(inputDatapageNumber);
                inputDatapropCount++;
            }

            if (inputDataperformance != null)
            {
                inputData["performance"] = ExpressionConverter.ConvertO(inputDataperformance);
                inputDatapropCount++;
            }

            if (inputDatablacklistWhitelist != null)
            {
                inputData["characters_option"] = ExpressionConverter.ConvertO(inputDatablacklistWhitelist);
                inputDatapropCount++;
            }

            if (inputDatacharacters != null)
            {
                inputData["characters"] = ExpressionConverter.ConvertO(inputDatacharacters);
                inputDatapropCount++;
            }

            if (inputDatausePagination != null)
            {
                inputData["paginate"] = ExpressionConverter.ConvertO(inputDatausePagination);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OcrOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> PdfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatapDFWatermark, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatacontent, Expression<Func<inputDataversionInput>> inputDataversion, Expression<Func<inputDatainputModeInput>> inputDatainputMode, Expression<Func<inputDataerrorCorrectionLevelInput>> inputDataerrorCorrectionLevel, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkForegroundColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> Redact(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDataredactionTypeInput>> inputPdfDataredactionType, Expression<Func<string>> inputPdfDataredactPattern, Expression<Func<bool>> inputPdfDataincludeAnnotations = null, Expression<Func<bool>> inputPdfDatacaseSensitive = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<string>> inputPdfDataopenPassword = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
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
                inputPdfData["include_annotations"] = ExpressionConverter.ConvertO(inputPdfDataincludeAnnotations);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatacaseSensitive != null)
            {
                inputPdfData["case_sensitive"] = ExpressionConverter.ConvertO(inputPdfDatacaseSensitive);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapageRange != null)
            {
                inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataopenPassword != null)
            {
                inputPdfData["open_password"] = ExpressionConverter.ConvertO(inputPdfDataopenPassword);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> RedactSmart(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<bool>> inputPdfDataredactCreditCardNumber, Expression<Func<bool>> inputPdfDataredactDate, Expression<Func<bool>> inputPdfDataredactEmailAddress, Expression<Func<bool>> inputPdfDataredactInternationalPhoneNumber, Expression<Func<bool>> inputPdfDataredactIPv4Address, Expression<Func<bool>> inputPdfDataredactIPv6Address, Expression<Func<bool>> inputPdfDataredactMACAddress, Expression<Func<bool>> inputPdfDataredactNorthAmericanPhoneNumber, Expression<Func<bool>> inputPdfDataredactSocialSecurityNumber, Expression<Func<bool>> inputPdfDataredactTime, Expression<Func<bool>> inputPdfDataredactURL, Expression<Func<bool>> inputPdfDataredactUSZipCode, Expression<Func<bool>> inputPdfDataredactVIN, Expression<Func<bool>> inputPdfDataincludeAnnotations = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<string>> inputPdfDataopenPassword = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
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
                inputPdfData["include_annotations"] = ExpressionConverter.ConvertO(inputPdfDataincludeAnnotations);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapageRange != null)
            {
                inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataopenPassword != null)
            {
                inputPdfData["open_password"] = ExpressionConverter.ConvertO(inputPdfDataopenPassword);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> RtfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<SplitOperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse> TextWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<string>> inputDatafontFamilyName, Expression<Func<string>> inputDatafontSize, Expression<Func<string>> inputDatafontColor, Expression<Func<inputDatatextAlignmentInput>> inputDatatextAlignment, Expression<Func<inputDatawordWrapInput>> inputDatawordWrap, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<string>> inputDatafontOutlineColor = null, Expression<Func<string>> inputDatafontOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["layer"] = ExpressionConverter.ConvertO(inputDatalayer);
                inputDatapropCount++;
            }

            if (inputDatarotation != null)
            {
                inputData["rotation"] = ExpressionConverter.ConvertO(inputDatarotation);
                inputDatapropCount++;
            }

            if (inputDataopacity != null)
            {
                inputData["opacity"] = ExpressionConverter.ConvertO(inputDataopacity);
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
                inputData["page_orientation"] = ExpressionConverter.ConvertO(inputDatawatermarkPageOrientation);
                inputDatapropCount++;
            }

            if (inputDataprintOnly != null)
            {
                inputData["print_only"] = ExpressionConverter.ConvertO(inputDataprintOnly);
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
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
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