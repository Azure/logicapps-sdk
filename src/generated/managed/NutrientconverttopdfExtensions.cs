//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientconverttopdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> Convert(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDataoutputFormatInput>> inputDataoutputFormat, Expression<Func<string>> inputDataoverrideSettings = null, Expression<Func<string>> inputDatatemplateFileContent = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataoutputFormat = WorkflowExpression.Compile(inputDataoutputFormat, nameof(inputDataoutputFormat), required: true);
            var __workflow_inputDataoverrideSettings = WorkflowExpression.Compile(inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            var __workflow_inputDatatemplateFileContent = WorkflowExpression.Compile(inputDatatemplateFileContent, nameof(inputDatatemplateFileContent), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertCad(Expression<Func<string>> inputCadDatasourceFileName, Expression<Func<string>> inputCadDatasourceFileContent, Expression<Func<inputCadDatapaperSizeInput>> inputCadDatapaperSize = null, Expression<Func<string>> inputCadDatapaperSizeCustom = null, Expression<Func<string>> inputCadDatapageMargins = null, Expression<Func<string>> inputCadDatabackgroundColor = null, Expression<Func<inputCadDataforegroundColorInput>> inputCadDataforegroundColor = null, Expression<Func<string>> inputCadDataforegroundColorCustom = null, Expression<Func<inputCadDataemptyLayoutDetectionInput>> inputCadDataemptyLayoutDetection = null, Expression<Func<inputCadDatalayoutSortOrderInput>> inputCadDatalayoutSortOrder = null, Expression<Func<int>> inputCadDatastartPage = null, Expression<Func<int>> inputCadDataendPage = null, Expression<Func<string>> inputCadDataoverrideSettings = null, Expression<Func<bool>> inputCadDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertEmail(Expression<Func<string>> inputEmailDatasourceFileName, Expression<Func<string>> inputEmailDatasourceFileContent, Expression<Func<bool>> inputEmailDataincludeAttachments = null, Expression<Func<inputEmailDataattachmentActionInput>> inputEmailDataattachmentAction = null, Expression<Func<bool>> inputEmailDataattachmentSummary = null, Expression<Func<inputEmailDataunsupportedAttachmentActionInput>> inputEmailDataunsupportedAttachmentAction = null, Expression<Func<string>> inputEmailDataincludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataexcludeAttachmentFilter = null, Expression<Func<string>> inputEmailDataviewportSize = null, Expression<Func<inputEmailDatapaperSizeInput>> inputEmailDatapaperSize = null, Expression<Func<string>> inputEmailDatapaperSizeCustom = null, Expression<Func<string>> inputEmailDatapageMargins = null, Expression<Func<bool>> inputEmailDataattachmentErrors = null, Expression<Func<int>> inputEmailDataminImageSize = null, Expression<Func<bool>> inputEmailDataofflineMode = null, Expression<Func<int>> inputEmailDatastartPage = null, Expression<Func<int>> inputEmailDataendPage = null, Expression<Func<inputEmailDataconversionQualityInput>> inputEmailDataconversionQuality = null, Expression<Func<string>> inputEmailDataoverrideSettings = null, Expression<Func<bool>> inputEmailDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertExcel(Expression<Func<string>> inputExcelDatasourceFileName, Expression<Func<string>> inputExcelDatasourceFileContent, Expression<Func<inputExcelDataoutputFormatInput>> inputExcelDataoutputFormat, Expression<Func<inputExcelDatarangeInput>> inputExcelDatarange = null, Expression<Func<bool>> inputExcelDatarevealHiddenRows = null, Expression<Func<bool>> inputExcelDatarevealHiddenColumns = null, Expression<Func<int>> inputExcelDatafitToPagesWide = null, Expression<Func<int>> inputExcelDatafitToPagesTall = null, Expression<Func<int>> inputExcelDatastartPage = null, Expression<Func<int>> inputExcelDataendPage = null, Expression<Func<inputExcelDataqualityInput>> inputExcelDataquality = null, Expression<Func<string>> inputExcelDataoverrideSettings = null, Expression<Func<bool>> inputExcelDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertHtml(Expression<Func<string>> inputDatasourceURLOrHTML, Expression<Func<inputDatapageOrientationInput>> inputDatapageOrientation = null, Expression<Func<inputDatamediaTypeInput>> inputDatamediaType = null, Expression<Func<inputDataauthenticationTypeInput>> inputDataauthenticationType = null, Expression<Func<string>> inputDatauserName = null, Expression<Func<string>> inputDatapassword = null, Expression<Func<string>> inputDataviewportSize = null, Expression<Func<int>> inputDataconversionDelay = null, Expression<Func<bool>> inputDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertInfopath(Expression<Func<string>> inputInfopathDatasourceFileName, Expression<Func<string>> inputInfopathDatasourceFileContent, Expression<Func<inputInfopathDataoutputFormatInput>> inputInfopathDataoutputFormat, Expression<Func<string>> inputInfopathDatatemplateFileContent = null, Expression<Func<string>> inputInfopathDataviewNames = null, Expression<Func<bool>> inputInfopathDataincludeAttachment = null, Expression<Func<inputInfopathDataattachmentActionInput>> inputInfopathDataattachmentAction = null, Expression<Func<inputInfopathDataunsupportedAttachmentActionInput>> inputInfopathDataunsupportedAttachmentAction = null, Expression<Func<bool>> inputInfopathDatabreakMergeOnError = null, Expression<Func<string>> inputInfopathDataincludeAttachmentFilter = null, Expression<Func<string>> inputInfopathDataexcludeAttachmentFilter = null, Expression<Func<inputInfopathDatadefaultPaperSizeInput>> inputInfopathDatadefaultPaperSize = null, Expression<Func<string>> inputInfopathDatadefaultPaperSizeCustom = null, Expression<Func<inputInfopathDataforcePaperSizeInput>> inputInfopathDataforcePaperSize = null, Expression<Func<string>> inputInfopathDataforcePaperSizeCustom = null, Expression<Func<inputInfopathDatadefaultPageOrientationInput>> inputInfopathDatadefaultPageOrientation = null, Expression<Func<inputInfopathDataforcePageOrientationInput>> inputInfopathDataforcePageOrientation = null, Expression<Func<int>> inputInfopathDatastartPage = null, Expression<Func<int>> inputInfopathDataendPage = null, Expression<Func<inputInfopathDataconversionQualityInput>> inputInfopathDataconversionQuality = null, Expression<Func<string>> inputInfopathDataoverrideSettings = null, Expression<Func<bool>> inputInfopathDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPdfa(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<inputPdfDatapDFProfileInput>> inputPdfDatapDFProfile, Expression<Func<string>> inputPdfDataoverrideSettings = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapDFProfile = WorkflowExpression.Compile(inputPdfDatapDFProfile, nameof(inputPdfDatapDFProfile), required: true);
            var __workflow_inputPdfDataoverrideSettings = WorkflowExpression.Compile(inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertPowerpoint(Expression<Func<string>> inputPowerpointDatasourceFileName, Expression<Func<string>> inputPowerpointDatasourceFileContent, Expression<Func<inputPowerpointDataoutputFormatInput>> inputPowerpointDataoutputFormat, Expression<Func<inputPowerpointDatarangeInput>> inputPowerpointDatarange = null, Expression<Func<inputPowerpointDataprintLayoutHandoutsInput>> inputPowerpointDataprintLayoutHandouts = null, Expression<Func<bool>> inputPowerpointDataframeSlides = null, Expression<Func<int>> inputPowerpointDatastartPage = null, Expression<Func<int>> inputPowerpointDataendPage = null, Expression<Func<inputPowerpointDataqualityInput>> inputPowerpointDataquality = null, Expression<Func<string>> inputPowerpointDataoverrideSettings = null, Expression<Func<bool>> inputPowerpointDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertVisio(Expression<Func<string>> inputVisioDatasourceFileName, Expression<Func<string>> inputVisioDatasourceFileContent, Expression<Func<inputVisioDataoutputFormatInput>> inputVisioDataoutputFormat, Expression<Func<inputVisioDatarangeInput>> inputVisioDatarange = null, Expression<Func<int>> inputVisioDatastartPage = null, Expression<Func<int>> inputVisioDataendPage = null, Expression<Func<inputVisioDataqualityInput>> inputVisioDataquality = null, Expression<Func<string>> inputVisioDataoverrideSettings = null, Expression<Func<bool>> inputVisioDatafailOnError = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse> ConvertWord(Expression<Func<string>> inputWordDatasourceFileName, Expression<Func<string>> inputWordDatasourceFileContent, Expression<Func<inputWordDataoutputFormatInput>> inputWordDataoutputFormat, Expression<Func<inputWordDatadisplayForReviewInput>> inputWordDatadisplayForReview = null, Expression<Func<inputWordDatareviewMarkupModeInput>> inputWordDatareviewMarkupMode = null, Expression<Func<inputWordDatagenerateBookmarksInput>> inputWordDatagenerateBookmarks = null, Expression<Func<int>> inputWordDatastartPage = null, Expression<Func<int>> inputWordDataendPage = null, Expression<Func<inputWordDataqualityInput>> inputWordDataquality = null, Expression<Func<string>> inputWordDataoverrideSettings = null, Expression<Func<bool>> inputWordDatafailOnError = null)
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
