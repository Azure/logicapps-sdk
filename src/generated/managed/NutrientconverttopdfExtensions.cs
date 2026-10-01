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
        public IBodyWorkflowAction<OperationResponse> Convert([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDataoutputFormatInput> inputDataoutputFormat, [WorkflowExpression] Func<string> inputDataoverrideSettings = null, [WorkflowExpression] Func<string> inputDatatemplateFileContent = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["output_format"] = SourceExpressionConverter.Convert(inputDataoutputFormat);
                inputData["copy_metadata"] = false;
                inputDatapropCount++;
                if (inputDataoverrideSettings != null)
                {
                    inputData["override_settings"] = SourceExpressionConverter.ConvertToken(inputDataoverrideSettings);
                    inputDatapropCount++;
                }

                if (inputDatatemplateFileContent != null)
                {
                    inputData["template_file_content"] = SourceExpressionConverter.ConvertToken(inputDatatemplateFileContent);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertCad([WorkflowExpression] Func<string> inputCadDatasourceFileName, [WorkflowExpression] Func<string> inputCadDatasourceFileContent, [WorkflowExpression] Func<inputCadDatapaperSizeInput> inputCadDatapaperSize = null, [WorkflowExpression] Func<string> inputCadDatapaperSizeCustom = null, [WorkflowExpression] Func<string> inputCadDatapageMargins = null, [WorkflowExpression] Func<string> inputCadDatabackgroundColor = null, [WorkflowExpression] Func<inputCadDataforegroundColorInput> inputCadDataforegroundColor = null, [WorkflowExpression] Func<string> inputCadDataforegroundColorCustom = null, [WorkflowExpression] Func<inputCadDataemptyLayoutDetectionInput> inputCadDataemptyLayoutDetection = null, [WorkflowExpression] Func<inputCadDatalayoutSortOrderInput> inputCadDatalayoutSortOrder = null, [WorkflowExpression] Func<int> inputCadDatastartPage = null, [WorkflowExpression] Func<int> inputCadDataendPage = null, [WorkflowExpression] Func<string> inputCadDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputCadDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_cad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputCadData = new JObject();
                var inputCadDatapropCount = 0;
                inputCadData["use_async_pattern"] = false;
                inputCadDatapropCount++;
                inputCadDatapropCount++;
                inputCadData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputCadDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputCadData["sharepoint_file"] = sharepointFileObject;
                    inputCadDatapropCount++;
                }

                inputCadDatapropCount++;
                inputCadData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputCadDatasourceFileContent);
                inputCadData["copy_metadata"] = false;
                inputCadDatapropCount++;
                if (inputCadDatapaperSize != null)
                {
                    if (inputCadDatapaperSize != null)
                    {
                        inputCadData["paper_size"] = SourceExpressionConverter.Convert(inputCadDatapaperSize);
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
                    inputCadData["paper_size_custom"] = SourceExpressionConverter.ConvertToken(inputCadDatapaperSizeCustom);
                    inputCadDatapropCount++;
                }

                if (inputCadDatapageMargins != null)
                {
                    if (inputCadDatapageMargins != null)
                    {
                        inputCadData["page_margins"] = SourceExpressionConverter.ConvertToken(inputCadDatapageMargins);
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
                        inputCadData["background_color"] = SourceExpressionConverter.ConvertToken(inputCadDatabackgroundColor);
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
                        inputCadData["foreground_color"] = SourceExpressionConverter.Convert(inputCadDataforegroundColor);
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
                    inputCadData["foreground_color_custom"] = SourceExpressionConverter.ConvertToken(inputCadDataforegroundColorCustom);
                    inputCadDatapropCount++;
                }

                if (inputCadDataemptyLayoutDetection != null)
                {
                    if (inputCadDataemptyLayoutDetection != null)
                    {
                        inputCadData["empty_layout_detection_mode"] = SourceExpressionConverter.Convert(inputCadDataemptyLayoutDetection);
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
                        inputCadData["layout_sort_order"] = SourceExpressionConverter.Convert(inputCadDatalayoutSortOrder);
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
                    inputCadData["start_page"] = SourceExpressionConverter.ConvertToken(inputCadDatastartPage);
                    inputCadDatapropCount++;
                }

                if (inputCadDataendPage != null)
                {
                    inputCadData["end_page"] = SourceExpressionConverter.ConvertToken(inputCadDataendPage);
                    inputCadDatapropCount++;
                }

                if (inputCadDataoverrideSettings != null)
                {
                    inputCadData["override_settings"] = SourceExpressionConverter.ConvertToken(inputCadDataoverrideSettings);
                    inputCadDatapropCount++;
                }

                if (inputCadDatafailOnError != null)
                {
                    if (inputCadDatafailOnError != null)
                    {
                        inputCadData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputCadDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertEmail([WorkflowExpression] Func<string> inputEmailDatasourceFileName, [WorkflowExpression] Func<string> inputEmailDatasourceFileContent, [WorkflowExpression] Func<bool> inputEmailDataincludeAttachments = null, [WorkflowExpression] Func<inputEmailDataattachmentActionInput> inputEmailDataattachmentAction = null, [WorkflowExpression] Func<bool> inputEmailDataattachmentSummary = null, [WorkflowExpression] Func<inputEmailDataunsupportedAttachmentActionInput> inputEmailDataunsupportedAttachmentAction = null, [WorkflowExpression] Func<string> inputEmailDataincludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputEmailDataexcludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputEmailDataviewportSize = null, [WorkflowExpression] Func<inputEmailDatapaperSizeInput> inputEmailDatapaperSize = null, [WorkflowExpression] Func<string> inputEmailDatapaperSizeCustom = null, [WorkflowExpression] Func<string> inputEmailDatapageMargins = null, [WorkflowExpression] Func<bool> inputEmailDataattachmentErrors = null, [WorkflowExpression] Func<int> inputEmailDataminImageSize = null, [WorkflowExpression] Func<bool> inputEmailDataofflineMode = null, [WorkflowExpression] Func<int> inputEmailDatastartPage = null, [WorkflowExpression] Func<int> inputEmailDataendPage = null, [WorkflowExpression] Func<inputEmailDataconversionQualityInput> inputEmailDataconversionQuality = null, [WorkflowExpression] Func<string> inputEmailDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputEmailDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputEmailData = new JObject();
                var inputEmailDatapropCount = 0;
                inputEmailData["use_async_pattern"] = false;
                inputEmailDatapropCount++;
                inputEmailDatapropCount++;
                inputEmailData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputEmailDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputEmailData["sharepoint_file"] = sharepointFileObject;
                    inputEmailDatapropCount++;
                }

                inputEmailDatapropCount++;
                inputEmailData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputEmailDatasourceFileContent);
                inputEmailData["copy_metadata"] = false;
                inputEmailDatapropCount++;
                if (inputEmailDataincludeAttachments != null)
                {
                    if (inputEmailDataincludeAttachments != null)
                    {
                        inputEmailData["convert_attachments"] = SourceExpressionConverter.ConvertToken(inputEmailDataincludeAttachments);
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
                    inputEmailData["attachment_merge_mode"] = SourceExpressionConverter.Convert(inputEmailDataattachmentAction);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataattachmentSummary != null)
                {
                    if (inputEmailDataattachmentSummary != null)
                    {
                        inputEmailData["display_attachment_summary"] = SourceExpressionConverter.ConvertToken(inputEmailDataattachmentSummary);
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
                        inputEmailData["unsupported_attachment_behaviour"] = SourceExpressionConverter.Convert(inputEmailDataunsupportedAttachmentAction);
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
                    inputEmailData["include_attachment_types"] = SourceExpressionConverter.ConvertToken(inputEmailDataincludeAttachmentFilter);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataexcludeAttachmentFilter != null)
                {
                    inputEmailData["exclude_attachment_types"] = SourceExpressionConverter.ConvertToken(inputEmailDataexcludeAttachmentFilter);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataviewportSize != null)
                {
                    if (inputEmailDataviewportSize != null)
                    {
                        inputEmailData["viewport_Size"] = SourceExpressionConverter.ConvertToken(inputEmailDataviewportSize);
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
                        inputEmailData["paper_size"] = SourceExpressionConverter.Convert(inputEmailDatapaperSize);
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
                    inputEmailData["paper_size_custom"] = SourceExpressionConverter.ConvertToken(inputEmailDatapaperSizeCustom);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatapageMargins != null)
                {
                    if (inputEmailDatapageMargins != null)
                    {
                        inputEmailData["page_margins"] = SourceExpressionConverter.ConvertToken(inputEmailDatapageMargins);
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
                    inputEmailData["break_merge_on_error"] = SourceExpressionConverter.ConvertToken(inputEmailDataattachmentErrors);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataminImageSize != null)
                {
                    if (inputEmailDataminImageSize != null)
                    {
                        inputEmailData["minimum_image_attachment_dimension"] = SourceExpressionConverter.ConvertToken(inputEmailDataminImageSize);
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
                        inputEmailData["enable_offline_mode"] = SourceExpressionConverter.ConvertToken(inputEmailDataofflineMode);
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
                    inputEmailData["start_page"] = SourceExpressionConverter.ConvertToken(inputEmailDatastartPage);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataendPage != null)
                {
                    inputEmailData["end_page"] = SourceExpressionConverter.ConvertToken(inputEmailDataendPage);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataconversionQuality != null)
                {
                    inputEmailData["quality"] = SourceExpressionConverter.Convert(inputEmailDataconversionQuality);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDataoverrideSettings != null)
                {
                    inputEmailData["override_settings"] = SourceExpressionConverter.ConvertToken(inputEmailDataoverrideSettings);
                    inputEmailDatapropCount++;
                }

                if (inputEmailDatafailOnError != null)
                {
                    if (inputEmailDatafailOnError != null)
                    {
                        inputEmailData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputEmailDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertExcel([WorkflowExpression] Func<string> inputExcelDatasourceFileName, [WorkflowExpression] Func<string> inputExcelDatasourceFileContent, [WorkflowExpression] Func<inputExcelDataoutputFormatInput> inputExcelDataoutputFormat, [WorkflowExpression] Func<inputExcelDatarangeInput> inputExcelDatarange = null, [WorkflowExpression] Func<bool> inputExcelDatarevealHiddenRows = null, [WorkflowExpression] Func<bool> inputExcelDatarevealHiddenColumns = null, [WorkflowExpression] Func<int> inputExcelDatafitToPagesWide = null, [WorkflowExpression] Func<int> inputExcelDatafitToPagesTall = null, [WorkflowExpression] Func<int> inputExcelDatastartPage = null, [WorkflowExpression] Func<int> inputExcelDataendPage = null, [WorkflowExpression] Func<inputExcelDataqualityInput> inputExcelDataquality = null, [WorkflowExpression] Func<string> inputExcelDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputExcelDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_excel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputExcelData = new JObject();
                var inputExcelDatapropCount = 0;
                inputExcelData["use_async_pattern"] = false;
                inputExcelDatapropCount++;
                inputExcelDatapropCount++;
                inputExcelData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputExcelDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputExcelData["sharepoint_file"] = sharepointFileObject;
                    inputExcelDatapropCount++;
                }

                inputExcelDatapropCount++;
                inputExcelData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputExcelDatasourceFileContent);
                inputExcelDatapropCount++;
                inputExcelData["output_format"] = SourceExpressionConverter.Convert(inputExcelDataoutputFormat);
                inputExcelData["copy_metadata"] = false;
                inputExcelDatapropCount++;
                if (inputExcelDatarange != null)
                {
                    inputExcelData["range"] = SourceExpressionConverter.Convert(inputExcelDatarange);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatarevealHiddenRows != null)
                {
                    if (inputExcelDatarevealHiddenRows != null)
                    {
                        inputExcelData["unhide_all_rows"] = SourceExpressionConverter.ConvertToken(inputExcelDatarevealHiddenRows);
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
                        inputExcelData["unhide_all_columns"] = SourceExpressionConverter.ConvertToken(inputExcelDatarevealHiddenColumns);
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
                    inputExcelData["fit_to_pages_wide"] = SourceExpressionConverter.ConvertToken(inputExcelDatafitToPagesWide);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatafitToPagesTall != null)
                {
                    inputExcelData["fit_to_pages_tall"] = SourceExpressionConverter.ConvertToken(inputExcelDatafitToPagesTall);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatastartPage != null)
                {
                    inputExcelData["start_page"] = SourceExpressionConverter.ConvertToken(inputExcelDatastartPage);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDataendPage != null)
                {
                    inputExcelData["end_page"] = SourceExpressionConverter.ConvertToken(inputExcelDataendPage);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDataquality != null)
                {
                    inputExcelData["quality"] = SourceExpressionConverter.Convert(inputExcelDataquality);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDataoverrideSettings != null)
                {
                    inputExcelData["override_settings"] = SourceExpressionConverter.ConvertToken(inputExcelDataoverrideSettings);
                    inputExcelDatapropCount++;
                }

                if (inputExcelDatafailOnError != null)
                {
                    if (inputExcelDatafailOnError != null)
                    {
                        inputExcelData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputExcelDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertHtml([WorkflowExpression] Func<string> inputDatasourceURLOrHTML, [WorkflowExpression] Func<inputDatapageOrientationInput> inputDatapageOrientation = null, [WorkflowExpression] Func<inputDatamediaTypeInput> inputDatamediaType = null, [WorkflowExpression] Func<inputDataauthenticationTypeInput> inputDataauthenticationType = null, [WorkflowExpression] Func<string> inputDatauserName = null, [WorkflowExpression] Func<string> inputDatapassword = null, [WorkflowExpression] Func<string> inputDataviewportSize = null, [WorkflowExpression] Func<int> inputDataconversionDelay = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_url_or_html"] = SourceExpressionConverter.ConvertToken(inputDatasourceURLOrHTML);
                if (inputDatapageOrientation != null)
                {
                    if (inputDatapageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatapageOrientation);
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
                        inputData["media_type"] = SourceExpressionConverter.Convert(inputDatamediaType);
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
                        inputData["authentication_type"] = SourceExpressionConverter.Convert(inputDataauthenticationType);
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
                    inputData["username"] = SourceExpressionConverter.ConvertToken(inputDatauserName);
                    inputDatapropCount++;
                }

                if (inputDatapassword != null)
                {
                    inputData["password"] = SourceExpressionConverter.ConvertToken(inputDatapassword);
                    inputDatapropCount++;
                }

                if (inputDataviewportSize != null)
                {
                    inputData["viewport_size"] = SourceExpressionConverter.ConvertToken(inputDataviewportSize);
                    inputDatapropCount++;
                }

                if (inputDataconversionDelay != null)
                {
                    inputData["conversion_delay"] = SourceExpressionConverter.ConvertToken(inputDataconversionDelay);
                    inputDatapropCount++;
                }

                if (inputDatafailOnError != null)
                {
                    if (inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertInfopath([WorkflowExpression] Func<string> inputInfopathDatasourceFileName, [WorkflowExpression] Func<string> inputInfopathDatasourceFileContent, [WorkflowExpression] Func<inputInfopathDataoutputFormatInput> inputInfopathDataoutputFormat, [WorkflowExpression] Func<string> inputInfopathDatatemplateFileContent = null, [WorkflowExpression] Func<string> inputInfopathDataviewNames = null, [WorkflowExpression] Func<bool> inputInfopathDataincludeAttachment = null, [WorkflowExpression] Func<inputInfopathDataattachmentActionInput> inputInfopathDataattachmentAction = null, [WorkflowExpression] Func<inputInfopathDataunsupportedAttachmentActionInput> inputInfopathDataunsupportedAttachmentAction = null, [WorkflowExpression] Func<bool> inputInfopathDatabreakMergeOnError = null, [WorkflowExpression] Func<string> inputInfopathDataincludeAttachmentFilter = null, [WorkflowExpression] Func<string> inputInfopathDataexcludeAttachmentFilter = null, [WorkflowExpression] Func<inputInfopathDatadefaultPaperSizeInput> inputInfopathDatadefaultPaperSize = null, [WorkflowExpression] Func<string> inputInfopathDatadefaultPaperSizeCustom = null, [WorkflowExpression] Func<inputInfopathDataforcePaperSizeInput> inputInfopathDataforcePaperSize = null, [WorkflowExpression] Func<string> inputInfopathDataforcePaperSizeCustom = null, [WorkflowExpression] Func<inputInfopathDatadefaultPageOrientationInput> inputInfopathDatadefaultPageOrientation = null, [WorkflowExpression] Func<inputInfopathDataforcePageOrientationInput> inputInfopathDataforcePageOrientation = null, [WorkflowExpression] Func<int> inputInfopathDatastartPage = null, [WorkflowExpression] Func<int> inputInfopathDataendPage = null, [WorkflowExpression] Func<inputInfopathDataconversionQualityInput> inputInfopathDataconversionQuality = null, [WorkflowExpression] Func<string> inputInfopathDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputInfopathDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_infopath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputInfopathData = new JObject();
                var inputInfopathDatapropCount = 0;
                inputInfopathData["use_async_pattern"] = false;
                inputInfopathDatapropCount++;
                inputInfopathDatapropCount++;
                inputInfopathData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputInfopathDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputInfopathData["sharepoint_file"] = sharepointFileObject;
                    inputInfopathDatapropCount++;
                }

                inputInfopathDatapropCount++;
                inputInfopathData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputInfopathDatasourceFileContent);
                inputInfopathDatapropCount++;
                inputInfopathData["output_format"] = SourceExpressionConverter.Convert(inputInfopathDataoutputFormat);
                inputInfopathData["copy_metadata"] = false;
                inputInfopathDatapropCount++;
                if (inputInfopathDatatemplateFileContent != null)
                {
                    inputInfopathData["template_file_content"] = SourceExpressionConverter.ConvertToken(inputInfopathDatatemplateFileContent);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataviewNames != null)
                {
                    inputInfopathData["views_to_convert"] = SourceExpressionConverter.ConvertToken(inputInfopathDataviewNames);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataincludeAttachment != null)
                {
                    if (inputInfopathDataincludeAttachment != null)
                    {
                        inputInfopathData["convert_attachments"] = SourceExpressionConverter.ConvertToken(inputInfopathDataincludeAttachment);
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
                    inputInfopathData["attachment_merge_mode"] = SourceExpressionConverter.Convert(inputInfopathDataattachmentAction);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataunsupportedAttachmentAction != null)
                {
                    inputInfopathData["unsupported_attachment_behaviour"] = SourceExpressionConverter.Convert(inputInfopathDataunsupportedAttachmentAction);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatabreakMergeOnError != null)
                {
                    inputInfopathData["break_merge_on_error"] = SourceExpressionConverter.ConvertToken(inputInfopathDatabreakMergeOnError);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataincludeAttachmentFilter != null)
                {
                    inputInfopathData["include_attachment_types"] = SourceExpressionConverter.ConvertToken(inputInfopathDataincludeAttachmentFilter);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataexcludeAttachmentFilter != null)
                {
                    inputInfopathData["exclude_attachment_types"] = SourceExpressionConverter.ConvertToken(inputInfopathDataexcludeAttachmentFilter);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatadefaultPaperSize != null)
                {
                    inputInfopathData["default_paper_size"] = SourceExpressionConverter.Convert(inputInfopathDatadefaultPaperSize);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatadefaultPaperSizeCustom != null)
                {
                    inputInfopathData["default_paper_size_custom"] = SourceExpressionConverter.ConvertToken(inputInfopathDatadefaultPaperSizeCustom);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataforcePaperSize != null)
                {
                    inputInfopathData["force_paper_size"] = SourceExpressionConverter.Convert(inputInfopathDataforcePaperSize);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataforcePaperSizeCustom != null)
                {
                    inputInfopathData["force_paper_size_custom"] = SourceExpressionConverter.ConvertToken(inputInfopathDataforcePaperSizeCustom);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatadefaultPageOrientation != null)
                {
                    if (inputInfopathDatadefaultPageOrientation != null)
                    {
                        inputInfopathData["default_page_orientation"] = SourceExpressionConverter.Convert(inputInfopathDatadefaultPageOrientation);
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
                    inputInfopathData["force_page_orientation"] = SourceExpressionConverter.Convert(inputInfopathDataforcePageOrientation);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatastartPage != null)
                {
                    inputInfopathData["start_page"] = SourceExpressionConverter.ConvertToken(inputInfopathDatastartPage);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataendPage != null)
                {
                    inputInfopathData["end_page"] = SourceExpressionConverter.ConvertToken(inputInfopathDataendPage);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataconversionQuality != null)
                {
                    inputInfopathData["quality"] = SourceExpressionConverter.Convert(inputInfopathDataconversionQuality);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDataoverrideSettings != null)
                {
                    inputInfopathData["override_settings"] = SourceExpressionConverter.ConvertToken(inputInfopathDataoverrideSettings);
                    inputInfopathDatapropCount++;
                }

                if (inputInfopathDatafailOnError != null)
                {
                    if (inputInfopathDatafailOnError != null)
                    {
                        inputInfopathData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputInfopathDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPdfa([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<inputPdfDatapDFProfileInput> inputPdfDatapDFProfile, [WorkflowExpression] Func<string> inputPdfDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_pdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
                inputPdfData["copy_metadata"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["pdf_profile"] = SourceExpressionConverter.Convert(inputPdfDatapDFProfile);
                if (inputPdfDataoverrideSettings != null)
                {
                    inputPdfData["override_settings"] = SourceExpressionConverter.ConvertToken(inputPdfDataoverrideSettings);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPowerpoint([WorkflowExpression] Func<string> inputPowerpointDatasourceFileName, [WorkflowExpression] Func<string> inputPowerpointDatasourceFileContent, [WorkflowExpression] Func<inputPowerpointDataoutputFormatInput> inputPowerpointDataoutputFormat, [WorkflowExpression] Func<inputPowerpointDatarangeInput> inputPowerpointDatarange = null, [WorkflowExpression] Func<inputPowerpointDataprintLayoutHandoutsInput> inputPowerpointDataprintLayoutHandouts = null, [WorkflowExpression] Func<bool> inputPowerpointDataframeSlides = null, [WorkflowExpression] Func<int> inputPowerpointDatastartPage = null, [WorkflowExpression] Func<int> inputPowerpointDataendPage = null, [WorkflowExpression] Func<inputPowerpointDataqualityInput> inputPowerpointDataquality = null, [WorkflowExpression] Func<string> inputPowerpointDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputPowerpointDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPowerpointData = new JObject();
                var inputPowerpointDatapropCount = 0;
                inputPowerpointData["use_async_pattern"] = false;
                inputPowerpointDatapropCount++;
                inputPowerpointDatapropCount++;
                inputPowerpointData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputPowerpointDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPowerpointData["sharepoint_file"] = sharepointFileObject;
                    inputPowerpointDatapropCount++;
                }

                inputPowerpointDatapropCount++;
                inputPowerpointData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputPowerpointDatasourceFileContent);
                inputPowerpointDatapropCount++;
                inputPowerpointData["output_format"] = SourceExpressionConverter.Convert(inputPowerpointDataoutputFormat);
                inputPowerpointData["copy_metadata"] = false;
                inputPowerpointDatapropCount++;
                if (inputPowerpointDatarange != null)
                {
                    inputPowerpointData["range"] = SourceExpressionConverter.Convert(inputPowerpointDatarange);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataprintLayoutHandouts != null)
                {
                    if (inputPowerpointDataprintLayoutHandouts != null)
                    {
                        inputPowerpointData["print_output_type"] = SourceExpressionConverter.Convert(inputPowerpointDataprintLayoutHandouts);
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
                        inputPowerpointData["frame_slides"] = SourceExpressionConverter.ConvertToken(inputPowerpointDataframeSlides);
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
                    inputPowerpointData["start_page"] = SourceExpressionConverter.ConvertToken(inputPowerpointDatastartPage);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataendPage != null)
                {
                    inputPowerpointData["end_page"] = SourceExpressionConverter.ConvertToken(inputPowerpointDataendPage);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataquality != null)
                {
                    inputPowerpointData["quality"] = SourceExpressionConverter.Convert(inputPowerpointDataquality);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDataoverrideSettings != null)
                {
                    inputPowerpointData["override_settings"] = SourceExpressionConverter.ConvertToken(inputPowerpointDataoverrideSettings);
                    inputPowerpointDatapropCount++;
                }

                if (inputPowerpointDatafailOnError != null)
                {
                    if (inputPowerpointDatafailOnError != null)
                    {
                        inputPowerpointData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputPowerpointDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertVisio([WorkflowExpression] Func<string> inputVisioDatasourceFileName, [WorkflowExpression] Func<string> inputVisioDatasourceFileContent, [WorkflowExpression] Func<inputVisioDataoutputFormatInput> inputVisioDataoutputFormat, [WorkflowExpression] Func<inputVisioDatarangeInput> inputVisioDatarange = null, [WorkflowExpression] Func<int> inputVisioDatastartPage = null, [WorkflowExpression] Func<int> inputVisioDataendPage = null, [WorkflowExpression] Func<inputVisioDataqualityInput> inputVisioDataquality = null, [WorkflowExpression] Func<string> inputVisioDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputVisioDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_visio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputVisioData = new JObject();
                var inputVisioDatapropCount = 0;
                inputVisioData["use_async_pattern"] = false;
                inputVisioDatapropCount++;
                inputVisioDatapropCount++;
                inputVisioData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputVisioDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputVisioData["sharepoint_file"] = sharepointFileObject;
                    inputVisioDatapropCount++;
                }

                inputVisioDatapropCount++;
                inputVisioData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputVisioDatasourceFileContent);
                inputVisioDatapropCount++;
                inputVisioData["output_format"] = SourceExpressionConverter.Convert(inputVisioDataoutputFormat);
                inputVisioData["copy_metadata"] = false;
                inputVisioDatapropCount++;
                if (inputVisioDatarange != null)
                {
                    inputVisioData["range"] = SourceExpressionConverter.Convert(inputVisioDatarange);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDatastartPage != null)
                {
                    inputVisioData["start_page"] = SourceExpressionConverter.ConvertToken(inputVisioDatastartPage);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDataendPage != null)
                {
                    inputVisioData["end_page"] = SourceExpressionConverter.ConvertToken(inputVisioDataendPage);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDataquality != null)
                {
                    inputVisioData["quality"] = SourceExpressionConverter.Convert(inputVisioDataquality);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDataoverrideSettings != null)
                {
                    inputVisioData["override_settings"] = SourceExpressionConverter.ConvertToken(inputVisioDataoverrideSettings);
                    inputVisioDatapropCount++;
                }

                if (inputVisioDatafailOnError != null)
                {
                    if (inputVisioDatafailOnError != null)
                    {
                        inputVisioData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputVisioDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertWord([WorkflowExpression] Func<string> inputWordDatasourceFileName, [WorkflowExpression] Func<string> inputWordDatasourceFileContent, [WorkflowExpression] Func<inputWordDataoutputFormatInput> inputWordDataoutputFormat, [WorkflowExpression] Func<inputWordDatadisplayForReviewInput> inputWordDatadisplayForReview = null, [WorkflowExpression] Func<inputWordDatareviewMarkupModeInput> inputWordDatareviewMarkupMode = null, [WorkflowExpression] Func<inputWordDatagenerateBookmarksInput> inputWordDatagenerateBookmarks = null, [WorkflowExpression] Func<int> inputWordDatastartPage = null, [WorkflowExpression] Func<int> inputWordDataendPage = null, [WorkflowExpression] Func<inputWordDataqualityInput> inputWordDataquality = null, [WorkflowExpression] Func<string> inputWordDataoverrideSettings = null, [WorkflowExpression] Func<bool> inputWordDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/convert_word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputWordData = new JObject();
                var inputWordDatapropCount = 0;
                inputWordData["use_async_pattern"] = false;
                inputWordDatapropCount++;
                inputWordDatapropCount++;
                inputWordData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputWordDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputWordData["sharepoint_file"] = sharepointFileObject;
                    inputWordDatapropCount++;
                }

                inputWordDatapropCount++;
                inputWordData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputWordDatasourceFileContent);
                inputWordDatapropCount++;
                inputWordData["output_format"] = SourceExpressionConverter.Convert(inputWordDataoutputFormat);
                inputWordData["copy_metadata"] = false;
                inputWordDatapropCount++;
                if (inputWordDatadisplayForReview != null)
                {
                    if (inputWordDatadisplayForReview != null)
                    {
                        inputWordData["revisions_and_comments_display_mode"] = SourceExpressionConverter.Convert(inputWordDatadisplayForReview);
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
                        inputWordData["revisions_and_comments_markup_mode"] = SourceExpressionConverter.Convert(inputWordDatareviewMarkupMode);
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
                    inputWordData["generate_bookmarks"] = SourceExpressionConverter.Convert(inputWordDatagenerateBookmarks);
                    inputWordDatapropCount++;
                }

                if (inputWordDatastartPage != null)
                {
                    inputWordData["start_page"] = SourceExpressionConverter.ConvertToken(inputWordDatastartPage);
                    inputWordDatapropCount++;
                }

                if (inputWordDataendPage != null)
                {
                    inputWordData["end_page"] = SourceExpressionConverter.ConvertToken(inputWordDataendPage);
                    inputWordDatapropCount++;
                }

                if (inputWordDataquality != null)
                {
                    inputWordData["quality"] = SourceExpressionConverter.Convert(inputWordDataquality);
                    inputWordDatapropCount++;
                }

                if (inputWordDataoverrideSettings != null)
                {
                    inputWordData["override_settings"] = SourceExpressionConverter.ConvertToken(inputWordDataoverrideSettings);
                    inputWordDatapropCount++;
                }

                if (inputWordDatafailOnError != null)
                {
                    if (inputWordDatafailOnError != null)
                    {
                        inputWordData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputWordDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
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