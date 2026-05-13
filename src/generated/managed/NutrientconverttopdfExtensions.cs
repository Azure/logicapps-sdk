//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientconverttopdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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
    }

    public class NutrientconverttopdfTriggers([ConnectionName] string connectionId)
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf;

    public partial class WorkflowManagedActions
    {
        public NutrientconverttopdfActions Nutrientconverttopdf(string connectionId) => new NutrientconverttopdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientconverttopdfTriggers Nutrientconverttopdf(string connectionId) => new NutrientconverttopdfTriggers(connectionId);
    }
}