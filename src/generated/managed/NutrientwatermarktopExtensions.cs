//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientwatermarktopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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