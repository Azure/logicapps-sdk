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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvert(WorkflowExpression<string> inputDatasourceFileName, WorkflowExpression<string> inputDatasourceFileContent, WorkflowExpression<inputDataoutputFormatInput> inputDataoutputFormat, WorkflowExpression<string> inputDataoverrideSettings = null, WorkflowExpression<string> inputDatatemplateFileContent = null, WorkflowExpression<bool> inputDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputDataoutputFormat, nameof(inputDataoutputFormat), required: true);
            WorkflowExpression.Validate(inputDataoverrideSettings, nameof(inputDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputDatatemplateFileContent, nameof(inputDatatemplateFileContent), required: false);
            WorkflowExpression.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertCad(WorkflowExpression<string> inputCadDatasourceFileName, WorkflowExpression<string> inputCadDatasourceFileContent, WorkflowExpression<inputCadDatapaperSizeInput> inputCadDatapaperSize = null, WorkflowExpression<string> inputCadDatapaperSizeCustom = null, WorkflowExpression<string> inputCadDatapageMargins = null, WorkflowExpression<string> inputCadDatabackgroundColor = null, WorkflowExpression<inputCadDataforegroundColorInput> inputCadDataforegroundColor = null, WorkflowExpression<string> inputCadDataforegroundColorCustom = null, WorkflowExpression<inputCadDataemptyLayoutDetectionInput> inputCadDataemptyLayoutDetection = null, WorkflowExpression<inputCadDatalayoutSortOrderInput> inputCadDatalayoutSortOrder = null, WorkflowExpression<int> inputCadDatastartPage = null, WorkflowExpression<int> inputCadDataendPage = null, WorkflowExpression<string> inputCadDataoverrideSettings = null, WorkflowExpression<bool> inputCadDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputCadDatasourceFileName, nameof(inputCadDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputCadDatasourceFileContent, nameof(inputCadDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputCadDatapaperSize, nameof(inputCadDatapaperSize), required: false);
            WorkflowExpression.Validate(inputCadDatapaperSizeCustom, nameof(inputCadDatapaperSizeCustom), required: false);
            WorkflowExpression.Validate(inputCadDatapageMargins, nameof(inputCadDatapageMargins), required: false);
            WorkflowExpression.Validate(inputCadDatabackgroundColor, nameof(inputCadDatabackgroundColor), required: false);
            WorkflowExpression.Validate(inputCadDataforegroundColor, nameof(inputCadDataforegroundColor), required: false);
            WorkflowExpression.Validate(inputCadDataforegroundColorCustom, nameof(inputCadDataforegroundColorCustom), required: false);
            WorkflowExpression.Validate(inputCadDataemptyLayoutDetection, nameof(inputCadDataemptyLayoutDetection), required: false);
            WorkflowExpression.Validate(inputCadDatalayoutSortOrder, nameof(inputCadDatalayoutSortOrder), required: false);
            WorkflowExpression.Validate(inputCadDatastartPage, nameof(inputCadDatastartPage), required: false);
            WorkflowExpression.Validate(inputCadDataendPage, nameof(inputCadDataendPage), required: false);
            WorkflowExpression.Validate(inputCadDataoverrideSettings, nameof(inputCadDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputCadDatafailOnError, nameof(inputCadDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertEmail(WorkflowExpression<string> inputEmailDatasourceFileName, WorkflowExpression<string> inputEmailDatasourceFileContent, WorkflowExpression<bool> inputEmailDataincludeAttachments = null, WorkflowExpression<inputEmailDataattachmentActionInput> inputEmailDataattachmentAction = null, WorkflowExpression<bool> inputEmailDataattachmentSummary = null, WorkflowExpression<inputEmailDataunsupportedAttachmentActionInput> inputEmailDataunsupportedAttachmentAction = null, WorkflowExpression<string> inputEmailDataincludeAttachmentFilter = null, WorkflowExpression<string> inputEmailDataexcludeAttachmentFilter = null, WorkflowExpression<string> inputEmailDataviewportSize = null, WorkflowExpression<inputEmailDatapaperSizeInput> inputEmailDatapaperSize = null, WorkflowExpression<string> inputEmailDatapaperSizeCustom = null, WorkflowExpression<string> inputEmailDatapageMargins = null, WorkflowExpression<bool> inputEmailDataattachmentErrors = null, WorkflowExpression<int> inputEmailDataminImageSize = null, WorkflowExpression<bool> inputEmailDataofflineMode = null, WorkflowExpression<int> inputEmailDatastartPage = null, WorkflowExpression<int> inputEmailDataendPage = null, WorkflowExpression<inputEmailDataconversionQualityInput> inputEmailDataconversionQuality = null, WorkflowExpression<string> inputEmailDataoverrideSettings = null, WorkflowExpression<bool> inputEmailDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputEmailDatasourceFileName, nameof(inputEmailDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputEmailDatasourceFileContent, nameof(inputEmailDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputEmailDataincludeAttachments, nameof(inputEmailDataincludeAttachments), required: false);
            WorkflowExpression.Validate(inputEmailDataattachmentAction, nameof(inputEmailDataattachmentAction), required: false);
            WorkflowExpression.Validate(inputEmailDataattachmentSummary, nameof(inputEmailDataattachmentSummary), required: false);
            WorkflowExpression.Validate(inputEmailDataunsupportedAttachmentAction, nameof(inputEmailDataunsupportedAttachmentAction), required: false);
            WorkflowExpression.Validate(inputEmailDataincludeAttachmentFilter, nameof(inputEmailDataincludeAttachmentFilter), required: false);
            WorkflowExpression.Validate(inputEmailDataexcludeAttachmentFilter, nameof(inputEmailDataexcludeAttachmentFilter), required: false);
            WorkflowExpression.Validate(inputEmailDataviewportSize, nameof(inputEmailDataviewportSize), required: false);
            WorkflowExpression.Validate(inputEmailDatapaperSize, nameof(inputEmailDatapaperSize), required: false);
            WorkflowExpression.Validate(inputEmailDatapaperSizeCustom, nameof(inputEmailDatapaperSizeCustom), required: false);
            WorkflowExpression.Validate(inputEmailDatapageMargins, nameof(inputEmailDatapageMargins), required: false);
            WorkflowExpression.Validate(inputEmailDataattachmentErrors, nameof(inputEmailDataattachmentErrors), required: false);
            WorkflowExpression.Validate(inputEmailDataminImageSize, nameof(inputEmailDataminImageSize), required: false);
            WorkflowExpression.Validate(inputEmailDataofflineMode, nameof(inputEmailDataofflineMode), required: false);
            WorkflowExpression.Validate(inputEmailDatastartPage, nameof(inputEmailDatastartPage), required: false);
            WorkflowExpression.Validate(inputEmailDataendPage, nameof(inputEmailDataendPage), required: false);
            WorkflowExpression.Validate(inputEmailDataconversionQuality, nameof(inputEmailDataconversionQuality), required: false);
            WorkflowExpression.Validate(inputEmailDataoverrideSettings, nameof(inputEmailDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputEmailDatafailOnError, nameof(inputEmailDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertExcel(WorkflowExpression<string> inputExcelDatasourceFileName, WorkflowExpression<string> inputExcelDatasourceFileContent, WorkflowExpression<inputExcelDataoutputFormatInput> inputExcelDataoutputFormat, WorkflowExpression<inputExcelDatarangeInput> inputExcelDatarange = null, WorkflowExpression<bool> inputExcelDatarevealHiddenRows = null, WorkflowExpression<bool> inputExcelDatarevealHiddenColumns = null, WorkflowExpression<int> inputExcelDatafitToPagesWide = null, WorkflowExpression<int> inputExcelDatafitToPagesTall = null, WorkflowExpression<int> inputExcelDatastartPage = null, WorkflowExpression<int> inputExcelDataendPage = null, WorkflowExpression<inputExcelDataqualityInput> inputExcelDataquality = null, WorkflowExpression<string> inputExcelDataoverrideSettings = null, WorkflowExpression<bool> inputExcelDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputExcelDatasourceFileName, nameof(inputExcelDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputExcelDatasourceFileContent, nameof(inputExcelDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputExcelDataoutputFormat, nameof(inputExcelDataoutputFormat), required: true);
            WorkflowExpression.Validate(inputExcelDatarange, nameof(inputExcelDatarange), required: false);
            WorkflowExpression.Validate(inputExcelDatarevealHiddenRows, nameof(inputExcelDatarevealHiddenRows), required: false);
            WorkflowExpression.Validate(inputExcelDatarevealHiddenColumns, nameof(inputExcelDatarevealHiddenColumns), required: false);
            WorkflowExpression.Validate(inputExcelDatafitToPagesWide, nameof(inputExcelDatafitToPagesWide), required: false);
            WorkflowExpression.Validate(inputExcelDatafitToPagesTall, nameof(inputExcelDatafitToPagesTall), required: false);
            WorkflowExpression.Validate(inputExcelDatastartPage, nameof(inputExcelDatastartPage), required: false);
            WorkflowExpression.Validate(inputExcelDataendPage, nameof(inputExcelDataendPage), required: false);
            WorkflowExpression.Validate(inputExcelDataquality, nameof(inputExcelDataquality), required: false);
            WorkflowExpression.Validate(inputExcelDataoverrideSettings, nameof(inputExcelDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputExcelDatafailOnError, nameof(inputExcelDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertHtml(WorkflowExpression<string> inputDatasourceURLOrHTML, WorkflowExpression<inputDatapageOrientationInput> inputDatapageOrientation = null, WorkflowExpression<inputDatamediaTypeInput> inputDatamediaType = null, WorkflowExpression<inputDataauthenticationTypeInput> inputDataauthenticationType = null, WorkflowExpression<string> inputDatauserName = null, WorkflowExpression<string> inputDatapassword = null, WorkflowExpression<string> inputDataviewportSize = null, WorkflowExpression<int> inputDataconversionDelay = null, WorkflowExpression<bool> inputDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputDatasourceURLOrHTML, nameof(inputDatasourceURLOrHTML), required: true);
            WorkflowExpression.Validate(inputDatapageOrientation, nameof(inputDatapageOrientation), required: false);
            WorkflowExpression.Validate(inputDatamediaType, nameof(inputDatamediaType), required: false);
            WorkflowExpression.Validate(inputDataauthenticationType, nameof(inputDataauthenticationType), required: false);
            WorkflowExpression.Validate(inputDatauserName, nameof(inputDatauserName), required: false);
            WorkflowExpression.Validate(inputDatapassword, nameof(inputDatapassword), required: false);
            WorkflowExpression.Validate(inputDataviewportSize, nameof(inputDataviewportSize), required: false);
            WorkflowExpression.Validate(inputDataconversionDelay, nameof(inputDataconversionDelay), required: false);
            WorkflowExpression.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertInfopath(WorkflowExpression<string> inputInfopathDatasourceFileName, WorkflowExpression<string> inputInfopathDatasourceFileContent, WorkflowExpression<inputInfopathDataoutputFormatInput> inputInfopathDataoutputFormat, WorkflowExpression<string> inputInfopathDatatemplateFileContent = null, WorkflowExpression<string> inputInfopathDataviewNames = null, WorkflowExpression<bool> inputInfopathDataincludeAttachment = null, WorkflowExpression<inputInfopathDataattachmentActionInput> inputInfopathDataattachmentAction = null, WorkflowExpression<inputInfopathDataunsupportedAttachmentActionInput> inputInfopathDataunsupportedAttachmentAction = null, WorkflowExpression<bool> inputInfopathDatabreakMergeOnError = null, WorkflowExpression<string> inputInfopathDataincludeAttachmentFilter = null, WorkflowExpression<string> inputInfopathDataexcludeAttachmentFilter = null, WorkflowExpression<inputInfopathDatadefaultPaperSizeInput> inputInfopathDatadefaultPaperSize = null, WorkflowExpression<string> inputInfopathDatadefaultPaperSizeCustom = null, WorkflowExpression<inputInfopathDataforcePaperSizeInput> inputInfopathDataforcePaperSize = null, WorkflowExpression<string> inputInfopathDataforcePaperSizeCustom = null, WorkflowExpression<inputInfopathDatadefaultPageOrientationInput> inputInfopathDatadefaultPageOrientation = null, WorkflowExpression<inputInfopathDataforcePageOrientationInput> inputInfopathDataforcePageOrientation = null, WorkflowExpression<int> inputInfopathDatastartPage = null, WorkflowExpression<int> inputInfopathDataendPage = null, WorkflowExpression<inputInfopathDataconversionQualityInput> inputInfopathDataconversionQuality = null, WorkflowExpression<string> inputInfopathDataoverrideSettings = null, WorkflowExpression<bool> inputInfopathDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputInfopathDatasourceFileName, nameof(inputInfopathDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputInfopathDatasourceFileContent, nameof(inputInfopathDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputInfopathDataoutputFormat, nameof(inputInfopathDataoutputFormat), required: true);
            WorkflowExpression.Validate(inputInfopathDatatemplateFileContent, nameof(inputInfopathDatatemplateFileContent), required: false);
            WorkflowExpression.Validate(inputInfopathDataviewNames, nameof(inputInfopathDataviewNames), required: false);
            WorkflowExpression.Validate(inputInfopathDataincludeAttachment, nameof(inputInfopathDataincludeAttachment), required: false);
            WorkflowExpression.Validate(inputInfopathDataattachmentAction, nameof(inputInfopathDataattachmentAction), required: false);
            WorkflowExpression.Validate(inputInfopathDataunsupportedAttachmentAction, nameof(inputInfopathDataunsupportedAttachmentAction), required: false);
            WorkflowExpression.Validate(inputInfopathDatabreakMergeOnError, nameof(inputInfopathDatabreakMergeOnError), required: false);
            WorkflowExpression.Validate(inputInfopathDataincludeAttachmentFilter, nameof(inputInfopathDataincludeAttachmentFilter), required: false);
            WorkflowExpression.Validate(inputInfopathDataexcludeAttachmentFilter, nameof(inputInfopathDataexcludeAttachmentFilter), required: false);
            WorkflowExpression.Validate(inputInfopathDatadefaultPaperSize, nameof(inputInfopathDatadefaultPaperSize), required: false);
            WorkflowExpression.Validate(inputInfopathDatadefaultPaperSizeCustom, nameof(inputInfopathDatadefaultPaperSizeCustom), required: false);
            WorkflowExpression.Validate(inputInfopathDataforcePaperSize, nameof(inputInfopathDataforcePaperSize), required: false);
            WorkflowExpression.Validate(inputInfopathDataforcePaperSizeCustom, nameof(inputInfopathDataforcePaperSizeCustom), required: false);
            WorkflowExpression.Validate(inputInfopathDatadefaultPageOrientation, nameof(inputInfopathDatadefaultPageOrientation), required: false);
            WorkflowExpression.Validate(inputInfopathDataforcePageOrientation, nameof(inputInfopathDataforcePageOrientation), required: false);
            WorkflowExpression.Validate(inputInfopathDatastartPage, nameof(inputInfopathDatastartPage), required: false);
            WorkflowExpression.Validate(inputInfopathDataendPage, nameof(inputInfopathDataendPage), required: false);
            WorkflowExpression.Validate(inputInfopathDataconversionQuality, nameof(inputInfopathDataconversionQuality), required: false);
            WorkflowExpression.Validate(inputInfopathDataoverrideSettings, nameof(inputInfopathDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputInfopathDatafailOnError, nameof(inputInfopathDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertPdfa(WorkflowExpression<string> inputPdfDatasourceFileName, WorkflowExpression<string> inputPdfDatasourceFileContent, WorkflowExpression<inputPdfDatapDFProfileInput> inputPdfDatapDFProfile, WorkflowExpression<string> inputPdfDataoverrideSettings = null, WorkflowExpression<bool> inputPdfDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputPdfDatapDFProfile, nameof(inputPdfDatapDFProfile), required: true);
            WorkflowExpression.Validate(inputPdfDataoverrideSettings, nameof(inputPdfDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertPowerpoint(WorkflowExpression<string> inputPowerpointDatasourceFileName, WorkflowExpression<string> inputPowerpointDatasourceFileContent, WorkflowExpression<inputPowerpointDataoutputFormatInput> inputPowerpointDataoutputFormat, WorkflowExpression<inputPowerpointDatarangeInput> inputPowerpointDatarange = null, WorkflowExpression<inputPowerpointDataprintLayoutHandoutsInput> inputPowerpointDataprintLayoutHandouts = null, WorkflowExpression<bool> inputPowerpointDataframeSlides = null, WorkflowExpression<int> inputPowerpointDatastartPage = null, WorkflowExpression<int> inputPowerpointDataendPage = null, WorkflowExpression<inputPowerpointDataqualityInput> inputPowerpointDataquality = null, WorkflowExpression<string> inputPowerpointDataoverrideSettings = null, WorkflowExpression<bool> inputPowerpointDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputPowerpointDatasourceFileName, nameof(inputPowerpointDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputPowerpointDatasourceFileContent, nameof(inputPowerpointDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputPowerpointDataoutputFormat, nameof(inputPowerpointDataoutputFormat), required: true);
            WorkflowExpression.Validate(inputPowerpointDatarange, nameof(inputPowerpointDatarange), required: false);
            WorkflowExpression.Validate(inputPowerpointDataprintLayoutHandouts, nameof(inputPowerpointDataprintLayoutHandouts), required: false);
            WorkflowExpression.Validate(inputPowerpointDataframeSlides, nameof(inputPowerpointDataframeSlides), required: false);
            WorkflowExpression.Validate(inputPowerpointDatastartPage, nameof(inputPowerpointDatastartPage), required: false);
            WorkflowExpression.Validate(inputPowerpointDataendPage, nameof(inputPowerpointDataendPage), required: false);
            WorkflowExpression.Validate(inputPowerpointDataquality, nameof(inputPowerpointDataquality), required: false);
            WorkflowExpression.Validate(inputPowerpointDataoverrideSettings, nameof(inputPowerpointDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputPowerpointDatafailOnError, nameof(inputPowerpointDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertVisio(WorkflowExpression<string> inputVisioDatasourceFileName, WorkflowExpression<string> inputVisioDatasourceFileContent, WorkflowExpression<inputVisioDataoutputFormatInput> inputVisioDataoutputFormat, WorkflowExpression<inputVisioDatarangeInput> inputVisioDatarange = null, WorkflowExpression<int> inputVisioDatastartPage = null, WorkflowExpression<int> inputVisioDataendPage = null, WorkflowExpression<inputVisioDataqualityInput> inputVisioDataquality = null, WorkflowExpression<string> inputVisioDataoverrideSettings = null, WorkflowExpression<bool> inputVisioDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputVisioDatasourceFileName, nameof(inputVisioDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputVisioDatasourceFileContent, nameof(inputVisioDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputVisioDataoutputFormat, nameof(inputVisioDataoutputFormat), required: true);
            WorkflowExpression.Validate(inputVisioDatarange, nameof(inputVisioDatarange), required: false);
            WorkflowExpression.Validate(inputVisioDatastartPage, nameof(inputVisioDatastartPage), required: false);
            WorkflowExpression.Validate(inputVisioDataendPage, nameof(inputVisioDataendPage), required: false);
            WorkflowExpression.Validate(inputVisioDataquality, nameof(inputVisioDataquality), required: false);
            WorkflowExpression.Validate(inputVisioDataoverrideSettings, nameof(inputVisioDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputVisioDatafailOnError, nameof(inputVisioDatafailOnError), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildConvertWord(WorkflowExpression<string> inputWordDatasourceFileName, WorkflowExpression<string> inputWordDatasourceFileContent, WorkflowExpression<inputWordDataoutputFormatInput> inputWordDataoutputFormat, WorkflowExpression<inputWordDatadisplayForReviewInput> inputWordDatadisplayForReview = null, WorkflowExpression<inputWordDatareviewMarkupModeInput> inputWordDatareviewMarkupMode = null, WorkflowExpression<inputWordDatagenerateBookmarksInput> inputWordDatagenerateBookmarks = null, WorkflowExpression<int> inputWordDatastartPage = null, WorkflowExpression<int> inputWordDataendPage = null, WorkflowExpression<inputWordDataqualityInput> inputWordDataquality = null, WorkflowExpression<string> inputWordDataoverrideSettings = null, WorkflowExpression<bool> inputWordDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputWordDatasourceFileName, nameof(inputWordDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputWordDatasourceFileContent, nameof(inputWordDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputWordDataoutputFormat, nameof(inputWordDataoutputFormat), required: true);
            WorkflowExpression.Validate(inputWordDatadisplayForReview, nameof(inputWordDatadisplayForReview), required: false);
            WorkflowExpression.Validate(inputWordDatareviewMarkupMode, nameof(inputWordDatareviewMarkupMode), required: false);
            WorkflowExpression.Validate(inputWordDatagenerateBookmarks, nameof(inputWordDatagenerateBookmarks), required: false);
            WorkflowExpression.Validate(inputWordDatastartPage, nameof(inputWordDatastartPage), required: false);
            WorkflowExpression.Validate(inputWordDataendPage, nameof(inputWordDataendPage), required: false);
            WorkflowExpression.Validate(inputWordDataquality, nameof(inputWordDataquality), required: false);
            WorkflowExpression.Validate(inputWordDataoverrideSettings, nameof(inputWordDataoverrideSettings), required: false);
            WorkflowExpression.Validate(inputWordDatafailOnError, nameof(inputWordDatafailOnError), required: false);
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