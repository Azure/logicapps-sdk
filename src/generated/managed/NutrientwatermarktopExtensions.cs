//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientwatermarktopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> CompositeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkData, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/composite_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
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
                inputData["watermark_data"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkData);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> EllipseWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatafillColor = null, [WorkflowExpression] Func<string> inputDatalineColor = null, [WorkflowExpression] Func<string> inputDatalineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/ellipse_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatafillColor);
                    inputDatapropCount++;
                }

                if (inputDatalineColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatalineColor);
                    inputDatapropCount++;
                }

                if (inputDatalineWidth != null)
                {
                    inputData["line_width"] = SourceExpressionConverter.ConvertToken(inputDatalineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> ImageWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDataimage, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/image_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["image_file"] = SourceExpressionConverter.ConvertToken(inputDataimage);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> LineWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDataxCoordinateStart, [WorkflowExpression] Func<string> inputDatayCoordinateStart, [WorkflowExpression] Func<string> inputDataxCoordinateEnd, [WorkflowExpression] Func<string> inputDatayCoordinateEnd, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatalineColor = null, [WorkflowExpression] Func<string> inputDatalineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/line_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinateStart);
                inputDatapropCount++;
                inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinateStart);
                inputDatapropCount++;
                inputData["end_x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinateEnd);
                inputDatapropCount++;
                inputData["end_y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinateEnd);
                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatalineColor);
                    inputDatapropCount++;
                }

                if (inputDatalineWidth != null)
                {
                    inputData["line_width"] = SourceExpressionConverter.ConvertToken(inputDatalineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> LinearBarcodeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatabarcodeContent, [WorkflowExpression] Func<inputDatabarcodeTypeInput> inputDatabarcodeType, [WorkflowExpression] Func<inputDatadisableCheckDigitInput> inputDatadisableCheckDigit, [WorkflowExpression] Func<inputDatashowCheckDigitInput> inputDatashowCheckDigit, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<inputDataomitEncodingOfStartStopSymbolsInput> inputDataomitEncodingOfStartStopSymbols = null, [WorkflowExpression] Func<string> inputDatamargin = null, [WorkflowExpression] Func<string> inputDatafontFamily = null, [WorkflowExpression] Func<string> inputDatafontSize = null, [WorkflowExpression] Func<string> inputDatafontStyle = null, [WorkflowExpression] Func<inputDatalabelPlacementInput> inputDatalabelPlacement = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatabarcodeBackgroundColor = null, [WorkflowExpression] Func<string> inputDatabarcodeBarColor = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/linear_barcode_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = SourceExpressionConverter.ConvertToken(inputDatabarcodeContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["barcode_type"] = SourceExpressionConverter.Convert(inputDatabarcodeType);
                if (inputDataomitEncodingOfStartStopSymbols != null)
                {
                    if (inputDataomitEncodingOfStartStopSymbols != null)
                    {
                        inputData["omit_start_stop_symbols"] = SourceExpressionConverter.Convert(inputDataomitEncodingOfStartStopSymbols);
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
                inputData["disable_checkdigit"] = SourceExpressionConverter.Convert(inputDatadisableCheckDigit);
                inputDatapropCount++;
                inputData["show_checkdigit"] = SourceExpressionConverter.Convert(inputDatashowCheckDigit);
                if (inputDatamargin != null)
                {
                    inputData["margin"] = SourceExpressionConverter.ConvertToken(inputDatamargin);
                    inputDatapropCount++;
                }

                if (inputDatafontFamily != null)
                {
                    inputData["font_family_name"] = SourceExpressionConverter.ConvertToken(inputDatafontFamily);
                    inputDatapropCount++;
                }

                if (inputDatafontSize != null)
                {
                    inputData["font_size"] = SourceExpressionConverter.ConvertToken(inputDatafontSize);
                    inputDatapropCount++;
                }

                if (inputDatafontStyle != null)
                {
                    inputData["font_style"] = SourceExpressionConverter.ConvertToken(inputDatafontStyle);
                    inputDatapropCount++;
                }

                if (inputDatalabelPlacement != null)
                {
                    if (inputDatalabelPlacement != null)
                    {
                        inputData["label_placement"] = SourceExpressionConverter.Convert(inputDatalabelPlacement);
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
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatabarcodeBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatabarcodeBarColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatabarcodeBarColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> PdfWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatapDFWatermark, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/pdf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["pdf_file"] = SourceExpressionConverter.ConvertToken(inputDatapDFWatermark);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> QrCodeWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatacontent, [WorkflowExpression] Func<inputDataversionInput> inputDataversion, [WorkflowExpression] Func<inputDatainputModeInput> inputDatainputMode, [WorkflowExpression] Func<inputDataerrorCorrectionLevelInput> inputDataerrorCorrectionLevel, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkForegroundColor = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/qr_code_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = SourceExpressionConverter.ConvertToken(inputDatacontent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["version"] = SourceExpressionConverter.Convert(inputDataversion);
                inputDatapropCount++;
                inputData["input_mode"] = SourceExpressionConverter.Convert(inputDatainputMode);
                inputDatapropCount++;
                inputData["error_correction_level"] = SourceExpressionConverter.Convert(inputDataerrorCorrectionLevel);
                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkForegroundColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkForegroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> RectangleWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/rectangle_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> RtfWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkContent, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatawatermarkBackgroundColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineColor = null, [WorkflowExpression] Func<string> inputDatawatermarkOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/rtf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["rtf_data"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkBackgroundColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkOutlineWidth != null)
                {
                    inputData["line_width"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
        public IBodyWorkflowAction<OperationResponse> TextWatermark([WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<string> inputDatawatermarkContent, [WorkflowExpression] Func<string> inputDatafontFamilyName, [WorkflowExpression] Func<string> inputDatafontSize, [WorkflowExpression] Func<string> inputDatafontColor, [WorkflowExpression] Func<inputDatatextAlignmentInput> inputDatatextAlignment, [WorkflowExpression] Func<inputDatawordWrapInput> inputDatawordWrap, [WorkflowExpression] Func<inputDatapositionInput> inputDataposition, [WorkflowExpression] Func<string> inputDatawidth, [WorkflowExpression] Func<string> inputDataheight, [WorkflowExpression] Func<string> inputDatasourceFileName = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<inputDatalayerInput> inputDatalayer = null, [WorkflowExpression] Func<string> inputDatarotation = null, [WorkflowExpression] Func<string> inputDataopacity = null, [WorkflowExpression] Func<string> inputDatafontStyle = null, [WorkflowExpression] Func<string> inputDatafontOutlineColor = null, [WorkflowExpression] Func<string> inputDatafontOutlineWidth = null, [WorkflowExpression] Func<int> inputDatawatermarkStartPage = null, [WorkflowExpression] Func<int> inputDatawatermarkEndPage = null, [WorkflowExpression] Func<int> inputDatawatermarkPageInterval = null, [WorkflowExpression] Func<inputDatawatermarkPageOrientationInput> inputDatawatermarkPageOrientation = null, [WorkflowExpression] Func<inputDataprintOnlyInput> inputDataprintOnly = null, [WorkflowExpression] Func<int> inputDatawatermarkStartSection = null, [WorkflowExpression] Func<int> inputDatawatermarkEndSection = null, [WorkflowExpression] Func<string> inputDatawatermarkPageType = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/text_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                if (inputDatasourceFileName != null)
                {
                    inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                    inputDatapropCount++;
                }

                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
                inputDatapropCount++;
                inputData["content"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                inputDatapropCount++;
                inputData["font_family_name"] = SourceExpressionConverter.ConvertToken(inputDatafontFamilyName);
                inputDatapropCount++;
                inputData["font_size"] = SourceExpressionConverter.ConvertToken(inputDatafontSize);
                inputDatapropCount++;
                inputData["fill_color"] = SourceExpressionConverter.ConvertToken(inputDatafontColor);
                inputDatapropCount++;
                inputData["alignment"] = SourceExpressionConverter.Convert(inputDatatextAlignment);
                inputDatapropCount++;
                inputData["word_wrap"] = SourceExpressionConverter.Convert(inputDatawordWrap);
                inputDatapropCount++;
                inputData["position"] = SourceExpressionConverter.Convert(inputDataposition);
                inputDatapropCount++;
                inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
                inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                if (inputDataxCoordinate != null)
                {
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatalayer != null)
                {
                    if (inputDatalayer != null)
                    {
                        inputData["layer"] = SourceExpressionConverter.Convert(inputDatalayer);
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
                    inputData["rotation"] = SourceExpressionConverter.ConvertToken(inputDatarotation);
                    inputDatapropCount++;
                }

                if (inputDataopacity != null)
                {
                    if (inputDataopacity != null)
                    {
                        inputData["opacity"] = SourceExpressionConverter.ConvertToken(inputDataopacity);
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
                    inputData["font_style"] = SourceExpressionConverter.ConvertToken(inputDatafontStyle);
                    inputDatapropCount++;
                }

                if (inputDatafontOutlineColor != null)
                {
                    inputData["line_color"] = SourceExpressionConverter.ConvertToken(inputDatafontOutlineColor);
                    inputDatapropCount++;
                }

                if (inputDatafontOutlineWidth != null)
                {
                    inputData["line_width"] = SourceExpressionConverter.ConvertToken(inputDatafontOutlineWidth);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkStartPage != null)
                {
                    inputData["start_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndPage != null)
                {
                    inputData["end_page"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndPage);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageInterval != null)
                {
                    inputData["page_interval"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageInterval);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageOrientation != null)
                {
                    if (inputDatawatermarkPageOrientation != null)
                    {
                        inputData["page_orientation"] = SourceExpressionConverter.Convert(inputDatawatermarkPageOrientation);
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
                        inputData["print_only"] = SourceExpressionConverter.Convert(inputDataprintOnly);
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
                    inputData["start_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkStartSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkEndSection != null)
                {
                    inputData["end_section"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkEndSection);
                    inputDatapropCount++;
                }

                if (inputDatawatermarkPageType != null)
                {
                    inputData["page_type"] = SourceExpressionConverter.ConvertToken(inputDatawatermarkPageType);
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