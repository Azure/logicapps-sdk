//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientconverttopdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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
