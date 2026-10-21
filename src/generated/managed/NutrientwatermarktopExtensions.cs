//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientwatermarktopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkData, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkData = WorkflowExpression.Compile(inputDatawatermarkData, nameof(inputDatawatermarkData), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafillColor = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatafillColor = WorkflowExpression.Compile(inputDatafillColor, nameof(inputDatafillColor), required: false);
            var __workflow_inputDatalineColor = WorkflowExpression.Compile(inputDatalineColor, nameof(inputDatalineColor), required: false);
            var __workflow_inputDatalineWidth = WorkflowExpression.Compile(inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> ImageWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDataimage, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataimage = WorkflowExpression.Compile(inputDataimage, nameof(inputDataimage), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = WorkflowExpression.Compile(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = WorkflowExpression.Compile(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> LineWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDataxCoordinateStart, Expression<Func<string>> inputDatayCoordinateStart, Expression<Func<string>> inputDataxCoordinateEnd, Expression<Func<string>> inputDatayCoordinateEnd, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatalineColor = null, Expression<Func<string>> inputDatalineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDataxCoordinateStart = WorkflowExpression.Compile(inputDataxCoordinateStart, nameof(inputDataxCoordinateStart), required: true);
            var __workflow_inputDatayCoordinateStart = WorkflowExpression.Compile(inputDatayCoordinateStart, nameof(inputDatayCoordinateStart), required: true);
            var __workflow_inputDataxCoordinateEnd = WorkflowExpression.Compile(inputDataxCoordinateEnd, nameof(inputDataxCoordinateEnd), required: true);
            var __workflow_inputDatayCoordinateEnd = WorkflowExpression.Compile(inputDatayCoordinateEnd, nameof(inputDatayCoordinateEnd), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatalineColor = WorkflowExpression.Compile(inputDatalineColor, nameof(inputDatalineColor), required: false);
            var __workflow_inputDatalineWidth = WorkflowExpression.Compile(inputDatalineWidth, nameof(inputDatalineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatabarcodeContent, Expression<Func<inputDatabarcodeTypeInput>> inputDatabarcodeType, Expression<Func<inputDatadisableCheckDigitInput>> inputDatadisableCheckDigit, Expression<Func<inputDatashowCheckDigitInput>> inputDatashowCheckDigit, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<inputDataomitEncodingOfStartStopSymbolsInput>> inputDataomitEncodingOfStartStopSymbols = null, Expression<Func<string>> inputDatamargin = null, Expression<Func<string>> inputDatafontFamily = null, Expression<Func<string>> inputDatafontSize = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<inputDatalabelPlacementInput>> inputDatalabelPlacement = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatabarcodeBackgroundColor = null, Expression<Func<string>> inputDatabarcodeBarColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatabarcodeContent = WorkflowExpression.Compile(inputDatabarcodeContent, nameof(inputDatabarcodeContent), required: true);
            var __workflow_inputDatabarcodeType = WorkflowExpression.Compile(inputDatabarcodeType, nameof(inputDatabarcodeType), required: true);
            var __workflow_inputDatadisableCheckDigit = WorkflowExpression.Compile(inputDatadisableCheckDigit, nameof(inputDatadisableCheckDigit), required: true);
            var __workflow_inputDatashowCheckDigit = WorkflowExpression.Compile(inputDatashowCheckDigit, nameof(inputDatashowCheckDigit), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataomitEncodingOfStartStopSymbols = WorkflowExpression.Compile(inputDataomitEncodingOfStartStopSymbols, nameof(inputDataomitEncodingOfStartStopSymbols), required: false);
            var __workflow_inputDatamargin = WorkflowExpression.Compile(inputDatamargin, nameof(inputDatamargin), required: false);
            var __workflow_inputDatafontFamily = WorkflowExpression.Compile(inputDatafontFamily, nameof(inputDatafontFamily), required: false);
            var __workflow_inputDatafontSize = WorkflowExpression.Compile(inputDatafontSize, nameof(inputDatafontSize), required: false);
            var __workflow_inputDatafontStyle = WorkflowExpression.Compile(inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            var __workflow_inputDatalabelPlacement = WorkflowExpression.Compile(inputDatalabelPlacement, nameof(inputDatalabelPlacement), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatabarcodeBackgroundColor = WorkflowExpression.Compile(inputDatabarcodeBackgroundColor, nameof(inputDatabarcodeBackgroundColor), required: false);
            var __workflow_inputDatabarcodeBarColor = WorkflowExpression.Compile(inputDatabarcodeBarColor, nameof(inputDatabarcodeBarColor), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> PdfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatapDFWatermark, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatapDFWatermark = WorkflowExpression.Compile(inputDatapDFWatermark, nameof(inputDatapDFWatermark), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatacontent, Expression<Func<inputDataversionInput>> inputDataversion, Expression<Func<inputDatainputModeInput>> inputDatainputMode, Expression<Func<inputDataerrorCorrectionLevelInput>> inputDataerrorCorrectionLevel, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkForegroundColor = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatacontent = WorkflowExpression.Compile(inputDatacontent, nameof(inputDatacontent), required: true);
            var __workflow_inputDataversion = WorkflowExpression.Compile(inputDataversion, nameof(inputDataversion), required: true);
            var __workflow_inputDatainputMode = WorkflowExpression.Compile(inputDatainputMode, nameof(inputDatainputMode), required: true);
            var __workflow_inputDataerrorCorrectionLevel = WorkflowExpression.Compile(inputDataerrorCorrectionLevel, nameof(inputDataerrorCorrectionLevel), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkForegroundColor = WorkflowExpression.Compile(inputDatawatermarkForegroundColor, nameof(inputDatawatermarkForegroundColor), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = WorkflowExpression.Compile(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = WorkflowExpression.Compile(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> RtfWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatawatermarkBackgroundColor = null, Expression<Func<string>> inputDatawatermarkOutlineColor = null, Expression<Func<string>> inputDatawatermarkOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkContent = WorkflowExpression.Compile(inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatawatermarkBackgroundColor = WorkflowExpression.Compile(inputDatawatermarkBackgroundColor, nameof(inputDatawatermarkBackgroundColor), required: false);
            var __workflow_inputDatawatermarkOutlineColor = WorkflowExpression.Compile(inputDatawatermarkOutlineColor, nameof(inputDatawatermarkOutlineColor), required: false);
            var __workflow_inputDatawatermarkOutlineWidth = WorkflowExpression.Compile(inputDatawatermarkOutlineWidth, nameof(inputDatawatermarkOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> TextWatermark(Expression<Func<string>> inputDatasourceFileContent, Expression<Func<string>> inputDatawatermarkContent, Expression<Func<string>> inputDatafontFamilyName, Expression<Func<string>> inputDatafontSize, Expression<Func<string>> inputDatafontColor, Expression<Func<inputDatatextAlignmentInput>> inputDatatextAlignment, Expression<Func<inputDatawordWrapInput>> inputDatawordWrap, Expression<Func<inputDatapositionInput>> inputDataposition, Expression<Func<string>> inputDatawidth, Expression<Func<string>> inputDataheight, Expression<Func<string>> inputDatasourceFileName = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<inputDatalayerInput>> inputDatalayer = null, Expression<Func<string>> inputDatarotation = null, Expression<Func<string>> inputDataopacity = null, Expression<Func<string>> inputDatafontStyle = null, Expression<Func<string>> inputDatafontOutlineColor = null, Expression<Func<string>> inputDatafontOutlineWidth = null, Expression<Func<int>> inputDatawatermarkStartPage = null, Expression<Func<int>> inputDatawatermarkEndPage = null, Expression<Func<int>> inputDatawatermarkPageInterval = null, Expression<Func<inputDatawatermarkPageOrientationInput>> inputDatawatermarkPageOrientation = null, Expression<Func<inputDataprintOnlyInput>> inputDataprintOnly = null, Expression<Func<int>> inputDatawatermarkStartSection = null, Expression<Func<int>> inputDatawatermarkEndSection = null, Expression<Func<string>> inputDatawatermarkPageType = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatawatermarkContent = WorkflowExpression.Compile(inputDatawatermarkContent, nameof(inputDatawatermarkContent), required: true);
            var __workflow_inputDatafontFamilyName = WorkflowExpression.Compile(inputDatafontFamilyName, nameof(inputDatafontFamilyName), required: true);
            var __workflow_inputDatafontSize = WorkflowExpression.Compile(inputDatafontSize, nameof(inputDatafontSize), required: true);
            var __workflow_inputDatafontColor = WorkflowExpression.Compile(inputDatafontColor, nameof(inputDatafontColor), required: true);
            var __workflow_inputDatatextAlignment = WorkflowExpression.Compile(inputDatatextAlignment, nameof(inputDatatextAlignment), required: true);
            var __workflow_inputDatawordWrap = WorkflowExpression.Compile(inputDatawordWrap, nameof(inputDatawordWrap), required: true);
            var __workflow_inputDataposition = WorkflowExpression.Compile(inputDataposition, nameof(inputDataposition), required: true);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: true);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: true);
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatalayer = WorkflowExpression.Compile(inputDatalayer, nameof(inputDatalayer), required: false);
            var __workflow_inputDatarotation = WorkflowExpression.Compile(inputDatarotation, nameof(inputDatarotation), required: false);
            var __workflow_inputDataopacity = WorkflowExpression.Compile(inputDataopacity, nameof(inputDataopacity), required: false);
            var __workflow_inputDatafontStyle = WorkflowExpression.Compile(inputDatafontStyle, nameof(inputDatafontStyle), required: false);
            var __workflow_inputDatafontOutlineColor = WorkflowExpression.Compile(inputDatafontOutlineColor, nameof(inputDatafontOutlineColor), required: false);
            var __workflow_inputDatafontOutlineWidth = WorkflowExpression.Compile(inputDatafontOutlineWidth, nameof(inputDatafontOutlineWidth), required: false);
            var __workflow_inputDatawatermarkStartPage = WorkflowExpression.Compile(inputDatawatermarkStartPage, nameof(inputDatawatermarkStartPage), required: false);
            var __workflow_inputDatawatermarkEndPage = WorkflowExpression.Compile(inputDatawatermarkEndPage, nameof(inputDatawatermarkEndPage), required: false);
            var __workflow_inputDatawatermarkPageInterval = WorkflowExpression.Compile(inputDatawatermarkPageInterval, nameof(inputDatawatermarkPageInterval), required: false);
            var __workflow_inputDatawatermarkPageOrientation = WorkflowExpression.Compile(inputDatawatermarkPageOrientation, nameof(inputDatawatermarkPageOrientation), required: false);
            var __workflow_inputDataprintOnly = WorkflowExpression.Compile(inputDataprintOnly, nameof(inputDataprintOnly), required: false);
            var __workflow_inputDatawatermarkStartSection = WorkflowExpression.Compile(inputDatawatermarkStartSection, nameof(inputDatawatermarkStartSection), required: false);
            var __workflow_inputDatawatermarkEndSection = WorkflowExpression.Compile(inputDatawatermarkEndSection, nameof(inputDatawatermarkEndSection), required: false);
            var __workflow_inputDatawatermarkPageType = WorkflowExpression.Compile(inputDatawatermarkPageType, nameof(inputDatawatermarkPageType), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class NutrientwatermarktopTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop;

    public partial class WorkflowManagedActions
    {
        public NutrientwatermarktopActions Nutrientwatermarktop(string connectionId) => new NutrientwatermarktopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientwatermarktopTriggers Nutrientwatermarktop(string connectionId) => new NutrientwatermarktopTriggers(connectionId);
    }
}
