//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Converterbypower2appsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5102AddHtmlToWord> AddHtmlToWord([WorkflowExpression] Func<string> dtoRequesthTML, [WorkflowExpression] Func<string> dtoRequestexistingFileContent = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5102_AddHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["html"] = SourceExpressionConverter.ConvertToken(dtoRequesthTML);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5102AddHtmlToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5032AddImageToWord> AddImageToWord([WorkflowExpression] Func<string> dtoRequestimage, [WorkflowExpression] Func<string> dtoRequestexistingFileContent = null, [WorkflowExpression] Func<string> dtoRequestcaptionText = null, [WorkflowExpression] Func<int> dtoRequestmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestmaximumImageHeight = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestimage, nameof(dtoRequestimage), required: true);
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestcaptionText, nameof(dtoRequestcaptionText), required: false);
            SourceExpression.Validate(dtoRequestmaximumImageWidth, nameof(dtoRequestmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestmaximumImageHeight, nameof(dtoRequestmaximumImageHeight), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5032_AddImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["image"] = SourceExpressionConverter.ConvertToken(dtoRequestimage);
                if (dtoRequestcaptionText != null)
                {
                    dtoRequest["imageText"] = SourceExpressionConverter.ConvertToken(dtoRequestcaptionText);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaximumImageWidth != null)
                {
                    dtoRequest["maxWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaximumImageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaximumImageHeight != null)
                {
                    dtoRequest["maxHeight"] = SourceExpressionConverter.ConvertToken(dtoRequestmaximumImageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5032AddImageToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5043AddImageWithinTableToWord> AddImageWithinTableToWord([WorkflowExpression] Func<string> dtoRequestimage, [WorkflowExpression] Func<string> dtoRequestexistingFileContent = null, [WorkflowExpression] Func<string> dtoRequestdescriptionText = null, [WorkflowExpression] Func<int> dtoRequestmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestmaximumImageHeight = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestimage, nameof(dtoRequestimage), required: true);
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestdescriptionText, nameof(dtoRequestdescriptionText), required: false);
            SourceExpression.Validate(dtoRequestmaximumImageWidth, nameof(dtoRequestmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestmaximumImageHeight, nameof(dtoRequestmaximumImageHeight), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5043_AddImageWithinTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["image"] = SourceExpressionConverter.ConvertToken(dtoRequestimage);
                if (dtoRequestdescriptionText != null)
                {
                    dtoRequest["imageText"] = SourceExpressionConverter.ConvertToken(dtoRequestdescriptionText);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaximumImageWidth != null)
                {
                    dtoRequest["maxWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaximumImageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaximumImageHeight != null)
                {
                    dtoRequest["maxHeight"] = SourceExpressionConverter.ConvertToken(dtoRequestmaximumImageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5043AddImageWithinTableToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5053AddTableToWord> AddTableToWord([WorkflowExpression] Func<string> dtoRequesttableData, [WorkflowExpression] Func<string> dtoRequestexistingFileContent = null, [WorkflowExpression] Func<bool> dtoRequestshowHeaders = null, [WorkflowExpression] Func<string> dtoRequesttableStyle = null, [WorkflowExpression] Func<string> dtoRequesttableCaption = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesttableData, nameof(dtoRequesttableData), required: true);
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestshowHeaders, nameof(dtoRequestshowHeaders), required: false);
            SourceExpression.Validate(dtoRequesttableStyle, nameof(dtoRequesttableStyle), required: false);
            SourceExpression.Validate(dtoRequesttableCaption, nameof(dtoRequesttableCaption), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5053_AddTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["table"] = SourceExpressionConverter.ConvertToken(dtoRequesttableData);
                if (dtoRequestshowHeaders != null)
                {
                    if (dtoRequestshowHeaders != null)
                    {
                        dtoRequest["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestshowHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["hasHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequesttableStyle != null)
                {
                    if (dtoRequesttableStyle != null)
                    {
                        dtoRequest["tableStyle"] = SourceExpressionConverter.ConvertToken(dtoRequesttableStyle);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["tableStyle"] = "GridTable1Light";
                    dtoRequestpropCount++;
                }

                if (dtoRequesttableCaption != null)
                {
                    dtoRequest["tableText"] = SourceExpressionConverter.ConvertToken(dtoRequesttableCaption);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5053AddTableToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5062AddTextToWord> AddTextToWord([WorkflowExpression] Func<string> dtoRequesttype, [WorkflowExpression] Func<string> dtoRequesttext, [WorkflowExpression] Func<string> dtoRequestexistingFileContent = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesttype, nameof(dtoRequesttype), required: true);
            SourceExpression.Validate(dtoRequesttext, nameof(dtoRequesttext), required: true);
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5062_AddTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["sectionType"] = SourceExpressionConverter.ConvertToken(dtoRequesttype);
                dtoRequestpropCount++;
                dtoRequest["text"] = SourceExpressionConverter.ConvertToken(dtoRequesttext);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5062AddTextToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs> CombineCsvs([WorkflowExpression] Func<string> dtoRequestV2081CombineCsvsmainCSV, [WorkflowExpression] Func<string> dtoRequestV2081CombineCsvscombineColumnName, [WorkflowExpression] Func<string> dtoRequestV2081CombineCsvssecondCSV, [WorkflowExpression] Func<string> dtoRequestV2081CombineCsvssecondCSVColumn = null)
        {
            SourceExpression.Validate(dtoRequestV2081CombineCsvsmainCSV, nameof(dtoRequestV2081CombineCsvsmainCSV), required: true);
            SourceExpression.Validate(dtoRequestV2081CombineCsvscombineColumnName, nameof(dtoRequestV2081CombineCsvscombineColumnName), required: true);
            SourceExpression.Validate(dtoRequestV2081CombineCsvssecondCSV, nameof(dtoRequestV2081CombineCsvssecondCSV), required: true);
            SourceExpression.Validate(dtoRequestV2081CombineCsvssecondCSVColumn, nameof(dtoRequestV2081CombineCsvssecondCSVColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2081_CombineCsvs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2081CombineCsvs = new JObject();
                var dtoRequestV2081CombineCsvspropCount = 0;
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["mainCsv"] = SourceExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvsmainCSV);
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["mainCsvColumn"] = SourceExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvscombineColumnName);
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["secondCsv"] = SourceExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvssecondCSV);
                if (dtoRequestV2081CombineCsvssecondCSVColumn != null)
                {
                    dtoRequestV2081CombineCsvs["secondCsvColumn"] = SourceExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvssecondCSVColumn);
                    dtoRequestV2081CombineCsvspropCount++;
                }

                if (dtoRequestV2081CombineCsvspropCount > 0)
                {
                    callPayload.Body = dtoRequestV2081CombineCsvs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2081CombineCsvs>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays> CombineJsonArrays([WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArraysmainJSON, [WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArrayscombinePropertyName, [WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArrayssecondJSON, [WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
        {
            SourceExpression.Validate(dtoRequestV2091CombineJsonArraysmainJSON, nameof(dtoRequestV2091CombineJsonArraysmainJSON), required: true);
            SourceExpression.Validate(dtoRequestV2091CombineJsonArrayscombinePropertyName, nameof(dtoRequestV2091CombineJsonArrayscombinePropertyName), required: true);
            SourceExpression.Validate(dtoRequestV2091CombineJsonArrayssecondJSON, nameof(dtoRequestV2091CombineJsonArrayssecondJSON), required: true);
            SourceExpression.Validate(dtoRequestV2091CombineJsonArrayssecondJSONProperty, nameof(dtoRequestV2091CombineJsonArrayssecondJSONProperty), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2091_CombineJsonArrays";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2091CombineJsonArrays = new JObject();
                var dtoRequestV2091CombineJsonArrayspropCount = 0;
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["mainJson"] = SourceExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArraysmainJSON);
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["mainJsonProperty"] = SourceExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArrayscombinePropertyName);
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["secondJson"] = SourceExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArrayssecondJSON);
                if (dtoRequestV2091CombineJsonArrayssecondJSONProperty != null)
                {
                    dtoRequestV2091CombineJsonArrays["secondJsonProperty"] = SourceExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArrayssecondJSONProperty);
                    dtoRequestV2091CombineJsonArrayspropCount++;
                }

                if (dtoRequestV2091CombineJsonArrayspropCount > 0)
                {
                    callPayload.Body = dtoRequestV2091CombineJsonArrays;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2091CombineJsonArrays>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3042CompressImage> CompressImage([WorkflowExpression] Func<string> dtoRequestimageFile, [WorkflowExpression] Func<int> dtoRequestimageQuality = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestimageFile, nameof(dtoRequestimageFile), required: true);
            SourceExpression.Validate(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3042_CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestimageFile);
                if (dtoRequestimageQuality != null)
                {
                    dtoRequest["quality"] = SourceExpressionConverter.ConvertToken(dtoRequestimageQuality);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3042CompressImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4081CompressPdf> CompressPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<bool> dtoRequestcompressImages = null, [WorkflowExpression] Func<int> dtoRequestimageQuality = null, [WorkflowExpression] Func<bool> dtoRequestoptimizeFonts = null, [WorkflowExpression] Func<bool> dtoRequestoptimizePageContents = null, [WorkflowExpression] Func<bool> dtoRequestremoveMetadata = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestcompressImages, nameof(dtoRequestcompressImages), required: false);
            SourceExpression.Validate(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            SourceExpression.Validate(dtoRequestoptimizeFonts, nameof(dtoRequestoptimizeFonts), required: false);
            SourceExpression.Validate(dtoRequestoptimizePageContents, nameof(dtoRequestoptimizePageContents), required: false);
            SourceExpression.Validate(dtoRequestremoveMetadata, nameof(dtoRequestremoveMetadata), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4081_CompressPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestcompressImages != null)
                {
                    dtoRequest["compressImages"] = SourceExpressionConverter.ConvertToken(dtoRequestcompressImages);
                    dtoRequestpropCount++;
                }

                if (dtoRequestimageQuality != null)
                {
                    dtoRequest["imageQuality"] = SourceExpressionConverter.ConvertToken(dtoRequestimageQuality);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoptimizeFonts != null)
                {
                    dtoRequest["optimizeFont"] = SourceExpressionConverter.ConvertToken(dtoRequestoptimizeFonts);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoptimizePageContents != null)
                {
                    dtoRequest["optimizePageContents"] = SourceExpressionConverter.ConvertToken(dtoRequestoptimizePageContents);
                    dtoRequestpropCount++;
                }

                if (dtoRequestremoveMetadata != null)
                {
                    dtoRequest["removeMetadata"] = SourceExpressionConverter.ConvertToken(dtoRequestremoveMetadata);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4081CompressPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor> ConvertColor([WorkflowExpression] Func<string> dtoRequestV2071ConvertColorcolor)
        {
            SourceExpression.Validate(dtoRequestV2071ConvertColorcolor, nameof(dtoRequestV2071ConvertColorcolor), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2071_ConvertColor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2071ConvertColor = new JObject();
                var dtoRequestV2071ConvertColorpropCount = 0;
                dtoRequestV2071ConvertColorpropCount++;
                dtoRequestV2071ConvertColor["color"] = SourceExpressionConverter.ConvertToken(dtoRequestV2071ConvertColorcolor);
                if (dtoRequestV2071ConvertColorpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2071ConvertColor;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2071ConvertColor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1035ConvertCsvToExcel> ConvertCsvToExcel([WorkflowExpression] Func<string> dtoRequestcSV, [WorkflowExpression] Func<bool> dtoRequestcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequeststopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestseparator = null, [WorkflowExpression] Func<bool> dtoRequestautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<int> dtoRequestcSVInputEncoding = null, [WorkflowExpression] Func<bool> dtoRequestadjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestmaxExcelColumnWidth = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestcSV, nameof(dtoRequestcSV), required: true);
            SourceExpression.Validate(dtoRequestcSVHasHeaders, nameof(dtoRequestcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestautoDetectFieldTypes, nameof(dtoRequestautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestnumberOfRowsForFieldTypeDetection, nameof(dtoRequestnumberOfRowsForFieldTypeDetection), required: false);
            SourceExpression.Validate(dtoRequestremoveEmptyRows, nameof(dtoRequestremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestskipANumberOfRows, nameof(dtoRequestskipANumberOfRows), required: false);
            SourceExpression.Validate(dtoRequeststopAtASpecificRow, nameof(dtoRequeststopAtASpecificRow), required: false);
            SourceExpression.Validate(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            SourceExpression.Validate(dtoRequestautoDetectQuoteDelimiter, nameof(dtoRequestautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestcSVInputEncoding, nameof(dtoRequestcSVInputEncoding), required: false);
            SourceExpression.Validate(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1035_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestcSV);
                if (dtoRequestcSVHasHeaders != null)
                {
                    if (dtoRequestcSVHasHeaders != null)
                    {
                        dtoRequest["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestcSVHasHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["dataIncludesHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestautoDetectFieldTypes != null)
                {
                    if (dtoRequestautoDetectFieldTypes != null)
                    {
                        dtoRequest["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestautoDetectFieldTypes);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["autoDiscoverFieldTypes"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequest["maxScanRows"] = SourceExpressionConverter.ConvertToken(dtoRequestnumberOfRowsForFieldTypeDetection);
                    dtoRequestpropCount++;
                }

                if (dtoRequestremoveEmptyRows != null)
                {
                    if (dtoRequestremoveEmptyRows != null)
                    {
                        dtoRequest["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestremoveEmptyRows);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreEmptyLine"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestskipANumberOfRows != null)
                {
                    dtoRequest["skip"] = SourceExpressionConverter.ConvertToken(dtoRequestskipANumberOfRows);
                    dtoRequestpropCount++;
                }

                if (dtoRequeststopAtASpecificRow != null)
                {
                    dtoRequest["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequeststopAtASpecificRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestautoDetectQuoteDelimiter != null)
                    {
                        dtoRequest["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestautoDetectQuoteDelimiter);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["mayHaveQuotedFields"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestcSVInputEncoding != null)
                {
                    dtoRequest["encoding"] = SourceExpressionConverter.ConvertToken(dtoRequestcSVInputEncoding);
                    dtoRequestpropCount++;
                }

                if (dtoRequestadjustExcelColumnToContent != null)
                {
                    if (dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestwrapExcelColumnText != null)
                {
                    if (dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1035ConvertCsvToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertCsvToHtmlTable([WorkflowExpression] Func<string> dtoRequestV7061ConvertCsvToHtmlTablecSV, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
        {
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablecSV, nameof(dtoRequestV7061ConvertCsvToHtmlTablecSV), required: true);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders, nameof(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes, nameof(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection, nameof(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows, nameof(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows, nameof(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow, nameof(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableseparator, nameof(dtoRequestV7061ConvertCsvToHtmlTableseparator), required: false);
            SourceExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter, nameof(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7061_ConvertCsvToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7061ConvertCsvToHtmlTable = new JObject();
                var dtoRequestV7061ConvertCsvToHtmlTablepropCount = 0;
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                dtoRequestV7061ConvertCsvToHtmlTable["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablecSV);
                if (dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = true;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = false;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["maxScanRows"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = true;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["skip"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableseparator != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableseparator);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["mayHaveQuotedFields"] = true;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV7061ConvertCsvToHtmlTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseHtml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson> ConvertCsvToJson([WorkflowExpression] Func<string> dtoRequestV1022ConvertCsvToJsoncSV, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV1022ConvertCsvToJsonseparator = null, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
        {
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsoncSV, nameof(dtoRequestV1022ConvertCsvToJsoncSV), required: true);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders, nameof(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes, nameof(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows, nameof(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows, nameof(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow, nameof(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonseparator, nameof(dtoRequestV1022ConvertCsvToJsonseparator), required: false);
            SourceExpression.Validate(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter, nameof(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1022_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1022ConvertCsvToJson = new JObject();
                var dtoRequestV1022ConvertCsvToJsonpropCount = 0;
                dtoRequestV1022ConvertCsvToJsonpropCount++;
                dtoRequestV1022ConvertCsvToJson["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsoncSV);
                if (dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = true;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = false;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV1022ConvertCsvToJson["maxScanRows"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = true;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonskipANumberOfRows != null)
                {
                    dtoRequestV1022ConvertCsvToJson["skip"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow != null)
                {
                    dtoRequestV1022ConvertCsvToJson["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonseparator != null)
                {
                    dtoRequestV1022ConvertCsvToJson["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonseparator);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["mayHaveQuotedFields"] = true;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1022ConvertCsvToJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1022ConvertCsvToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1150ConvertCsvToMarkdown> ConvertCsvToMarkdown([WorkflowExpression] Func<string> dtoRequestcSV, [WorkflowExpression] Func<bool> dtoRequestfirstRowIsTheHeader = null, [WorkflowExpression] Func<string> dtoRequestseparator = null, [WorkflowExpression] Func<bool> dtoRequestvaluesMayBeInQuotes = null, [WorkflowExpression] Func<bool> dtoRequestskipEmptyLines = null, [WorkflowExpression] Func<string> dtoRequestfileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestcSV, nameof(dtoRequestcSV), required: true);
            SourceExpression.Validate(dtoRequestfirstRowIsTheHeader, nameof(dtoRequestfirstRowIsTheHeader), required: false);
            SourceExpression.Validate(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            SourceExpression.Validate(dtoRequestvaluesMayBeInQuotes, nameof(dtoRequestvaluesMayBeInQuotes), required: false);
            SourceExpression.Validate(dtoRequestskipEmptyLines, nameof(dtoRequestskipEmptyLines), required: false);
            SourceExpression.Validate(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1150_ConvertCsvToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestcSV);
                if (dtoRequestfirstRowIsTheHeader != null)
                {
                    dtoRequest["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestfirstRowIsTheHeader);
                    dtoRequestpropCount++;
                }

                if (dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestvaluesMayBeInQuotes != null)
                {
                    dtoRequest["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestvaluesMayBeInQuotes);
                    dtoRequestpropCount++;
                }

                if (dtoRequestskipEmptyLines != null)
                {
                    dtoRequest["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestskipEmptyLines);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1150ConvertCsvToMarkdown>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson> ConvertExcelToJson([WorkflowExpression] Func<string> dtoRequestV1100ConvertExcelToJsonexcelFile, [WorkflowExpression] Func<bool> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, [WorkflowExpression] Func<string> dtoRequestV1100ConvertExcelToJsonstartCell = null, [WorkflowExpression] Func<string> dtoRequestV1100ConvertExcelToJsonsheetName = null)
        {
            SourceExpression.Validate(dtoRequestV1100ConvertExcelToJsonexcelFile, nameof(dtoRequestV1100ConvertExcelToJsonexcelFile), required: true);
            SourceExpression.Validate(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders, nameof(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestV1100ConvertExcelToJsonstartCell, nameof(dtoRequestV1100ConvertExcelToJsonstartCell), required: false);
            SourceExpression.Validate(dtoRequestV1100ConvertExcelToJsonsheetName, nameof(dtoRequestV1100ConvertExcelToJsonsheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1100_ConvertExcelToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1100ConvertExcelToJson = new JObject();
                var dtoRequestV1100ConvertExcelToJsonpropCount = 0;
                dtoRequestV1100ConvertExcelToJsonpropCount++;
                dtoRequestV1100ConvertExcelToJson["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonexcelFile);
                if (dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                {
                    if (dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                    {
                        dtoRequestV1100ConvertExcelToJson["hasHeaders"] = SourceExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders);
                        dtoRequestV1100ConvertExcelToJsonpropCount++;
                    }

                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1100ConvertExcelToJson["hasHeaders"] = true;
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (dtoRequestV1100ConvertExcelToJsonstartCell != null)
                {
                    dtoRequestV1100ConvertExcelToJson["startCell"] = SourceExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonstartCell);
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (dtoRequestV1100ConvertExcelToJsonsheetName != null)
                {
                    dtoRequestV1100ConvertExcelToJson["sheetName"] = SourceExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonsheetName);
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (dtoRequestV1100ConvertExcelToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1100ConvertExcelToJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1100ConvertExcelToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1140ConvertExcelToMarkdown> ConvertExcelToMarkdown([WorkflowExpression] Func<string> dtoRequestexcel, [WorkflowExpression] Func<bool> dtoRequestfirstRowIsTheHeader = null, [WorkflowExpression] Func<bool> dtoRequestaddSheetNames = null, [WorkflowExpression] Func<string> dtoRequestfileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestexcel, nameof(dtoRequestexcel), required: true);
            SourceExpression.Validate(dtoRequestfirstRowIsTheHeader, nameof(dtoRequestfirstRowIsTheHeader), required: false);
            SourceExpression.Validate(dtoRequestaddSheetNames, nameof(dtoRequestaddSheetNames), required: false);
            SourceExpression.Validate(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1140_ConvertExcelToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["excel"] = SourceExpressionConverter.ConvertToken(dtoRequestexcel);
                if (dtoRequestfirstRowIsTheHeader != null)
                {
                    dtoRequest["firstRowIsHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestfirstRowIsTheHeader);
                    dtoRequestpropCount++;
                }

                if (dtoRequestaddSheetNames != null)
                {
                    dtoRequest["includeSheetNames"] = SourceExpressionConverter.ConvertToken(dtoRequestaddSheetNames);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1140ConvertExcelToMarkdown>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4014ConvertFileToPdf> ConvertFileToPdf([WorkflowExpression] Func<string> dtoRequestFile, [WorkflowExpression] Func<string> dtoRequestoriginFileName = null, [WorkflowExpression] Func<string> dtoRequestoriginFileExtension = null, [WorkflowExpression] Func<int> dtoRequestconformanceLevel = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestFile, nameof(dtoRequestFile), required: true);
            SourceExpression.Validate(dtoRequestoriginFileName, nameof(dtoRequestoriginFileName), required: false);
            SourceExpression.Validate(dtoRequestoriginFileExtension, nameof(dtoRequestoriginFileExtension), required: false);
            SourceExpression.Validate(dtoRequestconformanceLevel, nameof(dtoRequestconformanceLevel), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4014_ConvertFileToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestFile);
                if (dtoRequestoriginFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestoriginFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoriginFileExtension != null)
                {
                    dtoRequest["fileExtension"] = SourceExpressionConverter.ConvertToken(dtoRequestoriginFileExtension);
                    dtoRequestpropCount++;
                }

                if (dtoRequestconformanceLevel != null)
                {
                    dtoRequest["conformanceLevel"] = SourceExpressionConverter.ConvertToken(dtoRequestconformanceLevel);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4014ConvertFileToPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv> ConvertHtmlTableToCsv([WorkflowExpression] Func<string> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, [WorkflowExpression] Func<string> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
        {
            SourceExpression.Validate(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, nameof(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable), required: true);
            SourceExpression.Validate(dtoRequestV7070ConvertHtmlTableToCsvseparator, nameof(dtoRequestV7070ConvertHtmlTableToCsvseparator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7070_ConvertHtmlTableToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7070ConvertHtmlTableToCsv = new JObject();
                var dtoRequestV7070ConvertHtmlTableToCsvpropCount = 0;
                dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
                dtoRequestV7070ConvertHtmlTableToCsv["htmlTable"] = SourceExpressionConverter.ConvertToken(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable);
                if (dtoRequestV7070ConvertHtmlTableToCsvseparator != null)
                {
                    dtoRequestV7070ConvertHtmlTableToCsv["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestV7070ConvertHtmlTableToCsvseparator);
                    dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
                }

                if (dtoRequestV7070ConvertHtmlTableToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7070ConvertHtmlTableToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7070ConvertHtmlTableToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7082ConvertHtmlTableToExcel> ConvertHtmlTableToExcel([WorkflowExpression] Func<string> dtoRequesthTMLTable, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesthTMLTable, nameof(dtoRequesthTMLTable), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7082_ConvertHtmlTableToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["htmlTable"] = SourceExpressionConverter.ConvertToken(dtoRequesthTMLTable);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7082ConvertHtmlTableToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7013ConvertHtmlTableToJson> ConvertHtmlTableToJson([WorkflowExpression] Func<string> dtoRequesthTMLTable)
        {
            SourceExpression.Validate(dtoRequesthTMLTable, nameof(dtoRequesthTMLTable), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7013_ConvertHtmlTableToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["htmlTable"] = SourceExpressionConverter.ConvertToken(dtoRequesthTMLTable);
                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7013ConvertHtmlTableToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7032ConvertHtmlToImage> ConvertHtmlToImage([WorkflowExpression] Func<string> dtoRequesthTML, [WorkflowExpression] Func<int> dtoRequestwidth = null, [WorkflowExpression] Func<int> dtoRequestheight = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            SourceExpression.Validate(dtoRequestwidth, nameof(dtoRequestwidth), required: false);
            SourceExpression.Validate(dtoRequestheight, nameof(dtoRequestheight), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7032_ConvertHtmlToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["html"] = SourceExpressionConverter.ConvertToken(dtoRequesthTML);
                if (dtoRequestwidth != null)
                {
                    dtoRequest["width"] = SourceExpressionConverter.ConvertToken(dtoRequestwidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheight != null)
                {
                    dtoRequest["height"] = SourceExpressionConverter.ConvertToken(dtoRequestheight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7032ConvertHtmlToImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7090ConvertHtmlToMarkdown> ConvertHtmlToMarkdown([WorkflowExpression] Func<string> dtoRequesthTML, [WorkflowExpression] Func<bool> dtoRequestremoveMenusAndExtras = null, [WorkflowExpression] Func<bool> dtoRequestkeepImagePlaceholders = null, [WorkflowExpression] Func<string> dtoRequestfileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            SourceExpression.Validate(dtoRequestremoveMenusAndExtras, nameof(dtoRequestremoveMenusAndExtras), required: false);
            SourceExpression.Validate(dtoRequestkeepImagePlaceholders, nameof(dtoRequestkeepImagePlaceholders), required: false);
            SourceExpression.Validate(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7090_ConvertHtmlToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["html"] = SourceExpressionConverter.ConvertToken(dtoRequesthTML);
                if (dtoRequestremoveMenusAndExtras != null)
                {
                    dtoRequest["removeClutter"] = SourceExpressionConverter.ConvertToken(dtoRequestremoveMenusAndExtras);
                    dtoRequestpropCount++;
                }

                if (dtoRequestkeepImagePlaceholders != null)
                {
                    dtoRequest["keepImagePlaceholders"] = SourceExpressionConverter.ConvertToken(dtoRequestkeepImagePlaceholders);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7090ConvertHtmlToMarkdown>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7023ConvertHtmlToPdf> ConvertHtmlToPdf([WorkflowExpression] Func<string> dtoRequesthTML, [WorkflowExpression] Func<bool> dtoRequestlandscapeFormat = null, [WorkflowExpression] Func<int> dtoRequestqualityOfImageContent = null, [WorkflowExpression] Func<int> dtoRequestfooterOptions = null, [WorkflowExpression] Func<int> dtoRequestheaderOptions = null, [WorkflowExpression] Func<string> dtoRequestpaperFormat = null, [WorkflowExpression] Func<int> dtoRequesttopMargin = null, [WorkflowExpression] Func<int> dtoRequestbottomMargin = null, [WorkflowExpression] Func<int> dtoRequestleftMargin = null, [WorkflowExpression] Func<int> dtoRequestrightMargin = null, [WorkflowExpression] Func<string> dtoRequestpageRanges = null, [WorkflowExpression] Func<double> dtoRequestscale = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            SourceExpression.Validate(dtoRequestlandscapeFormat, nameof(dtoRequestlandscapeFormat), required: false);
            SourceExpression.Validate(dtoRequestqualityOfImageContent, nameof(dtoRequestqualityOfImageContent), required: false);
            SourceExpression.Validate(dtoRequestfooterOptions, nameof(dtoRequestfooterOptions), required: false);
            SourceExpression.Validate(dtoRequestheaderOptions, nameof(dtoRequestheaderOptions), required: false);
            SourceExpression.Validate(dtoRequestpaperFormat, nameof(dtoRequestpaperFormat), required: false);
            SourceExpression.Validate(dtoRequesttopMargin, nameof(dtoRequesttopMargin), required: false);
            SourceExpression.Validate(dtoRequestbottomMargin, nameof(dtoRequestbottomMargin), required: false);
            SourceExpression.Validate(dtoRequestleftMargin, nameof(dtoRequestleftMargin), required: false);
            SourceExpression.Validate(dtoRequestrightMargin, nameof(dtoRequestrightMargin), required: false);
            SourceExpression.Validate(dtoRequestpageRanges, nameof(dtoRequestpageRanges), required: false);
            SourceExpression.Validate(dtoRequestscale, nameof(dtoRequestscale), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7023_ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["html"] = SourceExpressionConverter.ConvertToken(dtoRequesthTML);
                if (dtoRequestlandscapeFormat != null)
                {
                    if (dtoRequestlandscapeFormat != null)
                    {
                        dtoRequest["isLandscape"] = SourceExpressionConverter.ConvertToken(dtoRequestlandscapeFormat);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["isLandscape"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestqualityOfImageContent != null)
                {
                    dtoRequest["imageQuality"] = SourceExpressionConverter.ConvertToken(dtoRequestqualityOfImageContent);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfooterOptions != null)
                {
                    dtoRequest["footerOption"] = SourceExpressionConverter.ConvertToken(dtoRequestfooterOptions);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheaderOptions != null)
                {
                    dtoRequest["headerOption"] = SourceExpressionConverter.ConvertToken(dtoRequestheaderOptions);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpaperFormat != null)
                {
                    dtoRequest["paperFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestpaperFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttopMargin != null)
                {
                    dtoRequest["marginTop"] = SourceExpressionConverter.ConvertToken(dtoRequesttopMargin);
                    dtoRequestpropCount++;
                }

                if (dtoRequestbottomMargin != null)
                {
                    dtoRequest["marginBottom"] = SourceExpressionConverter.ConvertToken(dtoRequestbottomMargin);
                    dtoRequestpropCount++;
                }

                if (dtoRequestleftMargin != null)
                {
                    dtoRequest["marginLeft"] = SourceExpressionConverter.ConvertToken(dtoRequestleftMargin);
                    dtoRequestpropCount++;
                }

                if (dtoRequestrightMargin != null)
                {
                    dtoRequest["marginRight"] = SourceExpressionConverter.ConvertToken(dtoRequestrightMargin);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpageRanges != null)
                {
                    dtoRequest["pageRanges"] = SourceExpressionConverter.ConvertToken(dtoRequestpageRanges);
                    dtoRequestpropCount++;
                }

                if (dtoRequestscale != null)
                {
                    dtoRequest["scale"] = SourceExpressionConverter.ConvertToken(dtoRequestscale);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7023ConvertHtmlToPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> ConvertHtmlToWord([WorkflowExpression] Func<string> dtoRequestV7041ConvertHtmlToWordhTML)
        {
            SourceExpression.Validate(dtoRequestV7041ConvertHtmlToWordhTML, nameof(dtoRequestV7041ConvertHtmlToWordhTML), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7041_ConvertHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7041ConvertHtmlToWord = new JObject();
                var dtoRequestV7041ConvertHtmlToWordpropCount = 0;
                dtoRequestV7041ConvertHtmlToWordpropCount++;
                dtoRequestV7041ConvertHtmlToWord["html"] = SourceExpressionConverter.ConvertToken(dtoRequestV7041ConvertHtmlToWordhTML);
                if (dtoRequestV7041ConvertHtmlToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7041ConvertHtmlToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> ConvertImage([WorkflowExpression] Func<string> dtoRequestV3012ConvertImageimageFile, [WorkflowExpression] Func<string> dtoRequestV3012ConvertImageoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestV3012ConvertImageimageFile, nameof(dtoRequestV3012ConvertImageimageFile), required: true);
            SourceExpression.Validate(dtoRequestV3012ConvertImageoutputFormat, nameof(dtoRequestV3012ConvertImageoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3012_ConvertImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3012ConvertImage = new JObject();
                var dtoRequestV3012ConvertImagepropCount = 0;
                dtoRequestV3012ConvertImagepropCount++;
                dtoRequestV3012ConvertImage["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV3012ConvertImageimageFile);
                if (dtoRequestV3012ConvertImageoutputFormat != null)
                {
                    if (dtoRequestV3012ConvertImageoutputFormat != null)
                    {
                        dtoRequestV3012ConvertImage["outFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestV3012ConvertImageoutputFormat);
                        dtoRequestV3012ConvertImagepropCount++;
                    }

                    dtoRequestV3012ConvertImagepropCount++;
                }
                else
                {
                    dtoRequestV3012ConvertImage["outFormat"] = "JPEG";
                    dtoRequestV3012ConvertImagepropCount++;
                }

                if (dtoRequestV3012ConvertImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3012ConvertImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv> ConvertJsonToCsv([WorkflowExpression] Func<string> dtoRequestV1013ConvertJsonToCsvjSON, [WorkflowExpression] Func<string> dtoRequestV1013ConvertJsonToCsvseparator = null)
        {
            SourceExpression.Validate(dtoRequestV1013ConvertJsonToCsvjSON, nameof(dtoRequestV1013ConvertJsonToCsvjSON), required: true);
            SourceExpression.Validate(dtoRequestV1013ConvertJsonToCsvseparator, nameof(dtoRequestV1013ConvertJsonToCsvseparator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1013_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1013ConvertJsonToCsv = new JObject();
                var dtoRequestV1013ConvertJsonToCsvpropCount = 0;
                dtoRequestV1013ConvertJsonToCsvpropCount++;
                dtoRequestV1013ConvertJsonToCsv["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV1013ConvertJsonToCsvjSON);
                if (dtoRequestV1013ConvertJsonToCsvseparator != null)
                {
                    dtoRequestV1013ConvertJsonToCsv["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestV1013ConvertJsonToCsvseparator);
                    dtoRequestV1013ConvertJsonToCsvpropCount++;
                }

                if (dtoRequestV1013ConvertJsonToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1013ConvertJsonToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1013ConvertJsonToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1064ConvertJsonToExcel> ConvertJsonToExcel([WorkflowExpression] Func<string> dtoRequestjSON, [WorkflowExpression] Func<bool> dtoRequestallInOneTable = null, [WorkflowExpression] Func<bool> dtoRequestadjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestmaxExcelColumnWidth = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestjSON, nameof(dtoRequestjSON), required: true);
            SourceExpression.Validate(dtoRequestallInOneTable, nameof(dtoRequestallInOneTable), required: false);
            SourceExpression.Validate(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1064_ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["json"] = SourceExpressionConverter.ConvertToken(dtoRequestjSON);
                if (dtoRequestallInOneTable != null)
                {
                    if (dtoRequestallInOneTable != null)
                    {
                        dtoRequest["allInOneTable"] = SourceExpressionConverter.ConvertToken(dtoRequestallInOneTable);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["allInOneTable"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestadjustExcelColumnToContent != null)
                {
                    if (dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestwrapExcelColumnText != null)
                {
                    if (dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1064ConvertJsonToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertJsonToHtmlTable([WorkflowExpression] Func<string> dtoRequestV7051ConvertJsonToHtmlTablejSON)
        {
            SourceExpression.Validate(dtoRequestV7051ConvertJsonToHtmlTablejSON, nameof(dtoRequestV7051ConvertJsonToHtmlTablejSON), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7051_ConvertJsonToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7051ConvertJsonToHtmlTable = new JObject();
                var dtoRequestV7051ConvertJsonToHtmlTablepropCount = 0;
                dtoRequestV7051ConvertJsonToHtmlTablepropCount++;
                dtoRequestV7051ConvertJsonToHtmlTable["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV7051ConvertJsonToHtmlTablejSON);
                if (dtoRequestV7051ConvertJsonToHtmlTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV7051ConvertJsonToHtmlTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseHtml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable> ConvertJsonToTextTable([WorkflowExpression] Func<string> dtoRequestV1090ConvertJsonToTextTablejSON)
        {
            SourceExpression.Validate(dtoRequestV1090ConvertJsonToTextTablejSON, nameof(dtoRequestV1090ConvertJsonToTextTablejSON), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1090_ConvertJsonToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1090ConvertJsonToTextTable = new JObject();
                var dtoRequestV1090ConvertJsonToTextTablepropCount = 0;
                dtoRequestV1090ConvertJsonToTextTablepropCount++;
                dtoRequestV1090ConvertJsonToTextTable["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV1090ConvertJsonToTextTablejSON);
                if (dtoRequestV1090ConvertJsonToTextTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV1090ConvertJsonToTextTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1090ConvertJsonToTextTable>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml> ConvertJsonToXml([WorkflowExpression] Func<string> dtoRequestV1042ConvertJsonToXmljSON)
        {
            SourceExpression.Validate(dtoRequestV1042ConvertJsonToXmljSON, nameof(dtoRequestV1042ConvertJsonToXmljSON), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1042_ConvertJsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1042ConvertJsonToXml = new JObject();
                var dtoRequestV1042ConvertJsonToXmlpropCount = 0;
                dtoRequestV1042ConvertJsonToXmlpropCount++;
                dtoRequestV1042ConvertJsonToXml["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV1042ConvertJsonToXmljSON);
                if (dtoRequestV1042ConvertJsonToXmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1042ConvertJsonToXml;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1042ConvertJsonToXml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml> ConvertJsonToYaml([WorkflowExpression] Func<string> dtoRequestV1081ConvertJsonToYamljSON)
        {
            SourceExpression.Validate(dtoRequestV1081ConvertJsonToYamljSON, nameof(dtoRequestV1081ConvertJsonToYamljSON), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1081_ConvertJsonToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1081ConvertJsonToYaml = new JObject();
                var dtoRequestV1081ConvertJsonToYamlpropCount = 0;
                dtoRequestV1081ConvertJsonToYamlpropCount++;
                dtoRequestV1081ConvertJsonToYaml["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV1081ConvertJsonToYamljSON);
                if (dtoRequestV1081ConvertJsonToYamlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1081ConvertJsonToYaml;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1081ConvertJsonToYaml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1110ConvertMultiCsvToExcel> ConvertMultiCsvToExcel([WorkflowExpression] Func<CsvSheetItem[]> dtoRequestsheet, [WorkflowExpression] Func<bool> dtoRequestcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequeststopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestseparator = null, [WorkflowExpression] Func<bool> dtoRequestautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestadjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestmaxExcelColumnWidth = null, [WorkflowExpression] Func<string> dtoRequestexcelFileName = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestsheet, nameof(dtoRequestsheet), required: true);
            SourceExpression.Validate(dtoRequestcSVHasHeaders, nameof(dtoRequestcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestautoDetectFieldTypes, nameof(dtoRequestautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestnumberOfRowsForFieldTypeDetection, nameof(dtoRequestnumberOfRowsForFieldTypeDetection), required: false);
            SourceExpression.Validate(dtoRequestremoveEmptyRows, nameof(dtoRequestremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestskipANumberOfRows, nameof(dtoRequestskipANumberOfRows), required: false);
            SourceExpression.Validate(dtoRequeststopAtASpecificRow, nameof(dtoRequeststopAtASpecificRow), required: false);
            SourceExpression.Validate(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            SourceExpression.Validate(dtoRequestautoDetectQuoteDelimiter, nameof(dtoRequestautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            SourceExpression.Validate(dtoRequestexcelFileName, nameof(dtoRequestexcelFileName), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1110_ConvertMultiCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["csvSheets"] = SourceExpressionConverter.ConvertToken(dtoRequestsheet);
                if (dtoRequestcSVHasHeaders != null)
                {
                    if (dtoRequestcSVHasHeaders != null)
                    {
                        dtoRequest["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestcSVHasHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["dataIncludesHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestautoDetectFieldTypes != null)
                {
                    if (dtoRequestautoDetectFieldTypes != null)
                    {
                        dtoRequest["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestautoDetectFieldTypes);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["autoDiscoverFieldTypes"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequest["maxScanRows"] = SourceExpressionConverter.ConvertToken(dtoRequestnumberOfRowsForFieldTypeDetection);
                    dtoRequestpropCount++;
                }

                if (dtoRequestremoveEmptyRows != null)
                {
                    if (dtoRequestremoveEmptyRows != null)
                    {
                        dtoRequest["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestremoveEmptyRows);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreEmptyLine"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestskipANumberOfRows != null)
                {
                    dtoRequest["skip"] = SourceExpressionConverter.ConvertToken(dtoRequestskipANumberOfRows);
                    dtoRequestpropCount++;
                }

                if (dtoRequeststopAtASpecificRow != null)
                {
                    dtoRequest["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequeststopAtASpecificRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestautoDetectQuoteDelimiter != null)
                    {
                        dtoRequest["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestautoDetectQuoteDelimiter);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["mayHaveQuotedFields"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestadjustExcelColumnToContent != null)
                {
                    if (dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestwrapExcelColumnText != null)
                {
                    if (dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestexcelFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestexcelFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1110ConvertMultiCsvToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4130ConvertPdfToMarkdown> ConvertPdfToMarkdown([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<bool> dtoRequestkeepReadingOrder = null, [WorkflowExpression] Func<bool> dtoRequestmarkHeadings = null, [WorkflowExpression] Func<bool> dtoRequestaddPageMarkers = null, [WorkflowExpression] Func<string> dtoRequestfileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestkeepReadingOrder, nameof(dtoRequestkeepReadingOrder), required: false);
            SourceExpression.Validate(dtoRequestmarkHeadings, nameof(dtoRequestmarkHeadings), required: false);
            SourceExpression.Validate(dtoRequestaddPageMarkers, nameof(dtoRequestaddPageMarkers), required: false);
            SourceExpression.Validate(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4130_ConvertPdfToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestkeepReadingOrder != null)
                {
                    dtoRequest["layoutBased"] = SourceExpressionConverter.ConvertToken(dtoRequestkeepReadingOrder);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmarkHeadings != null)
                {
                    dtoRequest["detectHeadings"] = SourceExpressionConverter.ConvertToken(dtoRequestmarkHeadings);
                    dtoRequestpropCount++;
                }

                if (dtoRequestaddPageMarkers != null)
                {
                    dtoRequest["addPageMarkers"] = SourceExpressionConverter.ConvertToken(dtoRequestaddPageMarkers);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4130ConvertPdfToMarkdown>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4071ConvertPdfToPdfA> ConvertPdfToPdfA([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestconformanceLevel = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestconformanceLevel, nameof(dtoRequestconformanceLevel), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4071_ConvertPdfToPdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestconformanceLevel != null)
                {
                    dtoRequest["conformanceLevel"] = SourceExpressionConverter.ConvertToken(dtoRequestconformanceLevel);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4071ConvertPdfToPdfA>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults> ConvertSharePointSearchResults([WorkflowExpression] Func<string> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
        {
            SourceExpression.Validate(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult, nameof(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V6011_ConvertSharePointSearchResults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV6011ConvertSharePointSearchResults = new JObject();
                var dtoRequestV6011ConvertSharePointSearchResultspropCount = 0;
                dtoRequestV6011ConvertSharePointSearchResultspropCount++;
                dtoRequestV6011ConvertSharePointSearchResults["sharepointResult"] = SourceExpressionConverter.ConvertToken(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult);
                if (dtoRequestV6011ConvertSharePointSearchResultspropCount > 0)
                {
                    callPayload.Body = dtoRequestV6011ConvertSharePointSearchResults;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV6011ConvertSharePointSearchResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml> ConvertWordToHtml([WorkflowExpression] Func<string> dtoRequestword, [WorkflowExpression] Func<bool> dtoRequestembedImages = null, [WorkflowExpression] Func<bool> dtoRequestfullHTMLDocument = null, [WorkflowExpression] Func<string> dtoRequesttitle = null)
        {
            SourceExpression.Validate(dtoRequestword, nameof(dtoRequestword), required: true);
            SourceExpression.Validate(dtoRequestembedImages, nameof(dtoRequestembedImages), required: false);
            SourceExpression.Validate(dtoRequestfullHTMLDocument, nameof(dtoRequestfullHTMLDocument), required: false);
            SourceExpression.Validate(dtoRequesttitle, nameof(dtoRequesttitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5160_ConvertWordToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["word"] = SourceExpressionConverter.ConvertToken(dtoRequestword);
                if (dtoRequestembedImages != null)
                {
                    dtoRequest["embedImages"] = SourceExpressionConverter.ConvertToken(dtoRequestembedImages);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfullHTMLDocument != null)
                {
                    dtoRequest["fullHtmlDocument"] = SourceExpressionConverter.ConvertToken(dtoRequestfullHTMLDocument);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttitle != null)
                {
                    dtoRequest["title"] = SourceExpressionConverter.ConvertToken(dtoRequesttitle);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5160ConvertWordToHtml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5170ConvertWordToMarkdown> ConvertWordToMarkdown([WorkflowExpression] Func<string> dtoRequestword, [WorkflowExpression] Func<bool> dtoRequestkeepImagePlaceholders = null, [WorkflowExpression] Func<string> dtoRequestfileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestword, nameof(dtoRequestword), required: true);
            SourceExpression.Validate(dtoRequestkeepImagePlaceholders, nameof(dtoRequestkeepImagePlaceholders), required: false);
            SourceExpression.Validate(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5170_ConvertWordToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["word"] = SourceExpressionConverter.ConvertToken(dtoRequestword);
                if (dtoRequestkeepImagePlaceholders != null)
                {
                    dtoRequest["keepImagePlaceholders"] = SourceExpressionConverter.ConvertToken(dtoRequestkeepImagePlaceholders);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5170ConvertWordToMarkdown>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1130ConvertXmlToCsv> ConvertXmlToCsv([WorkflowExpression] Func<string> dtoRequestxML, [WorkflowExpression] Func<string> dtoRequestseparator = null, [WorkflowExpression] Func<bool> dtoRequestignoreXMLFormatting = null, [WorkflowExpression] Func<string> dtoRequestcSVFileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestxML, nameof(dtoRequestxML), required: true);
            SourceExpression.Validate(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            SourceExpression.Validate(dtoRequestignoreXMLFormatting, nameof(dtoRequestignoreXMLFormatting), required: false);
            SourceExpression.Validate(dtoRequestcSVFileName, nameof(dtoRequestcSVFileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1130_ConvertXmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestxML);
                if (dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestignoreXMLFormatting != null)
                {
                    if (dtoRequestignoreXMLFormatting != null)
                    {
                        dtoRequest["ignoreXmlFormatting"] = SourceExpressionConverter.ConvertToken(dtoRequestignoreXMLFormatting);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreXmlFormatting"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestcSVFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestcSVFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1130ConvertXmlToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1120ConvertXmlToExcel> ConvertXmlToExcel([WorkflowExpression] Func<string> dtoRequestxML, [WorkflowExpression] Func<bool> dtoRequestignoreXMLFormatting = null, [WorkflowExpression] Func<bool> dtoRequestallInOneTable = null, [WorkflowExpression] Func<bool> dtoRequestadjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestmaxExcelColumnWidth = null, [WorkflowExpression] Func<string> dtoRequestexcelFileName = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestxML, nameof(dtoRequestxML), required: true);
            SourceExpression.Validate(dtoRequestignoreXMLFormatting, nameof(dtoRequestignoreXMLFormatting), required: false);
            SourceExpression.Validate(dtoRequestallInOneTable, nameof(dtoRequestallInOneTable), required: false);
            SourceExpression.Validate(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            SourceExpression.Validate(dtoRequestexcelFileName, nameof(dtoRequestexcelFileName), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1120_ConvertXmlToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestxML);
                if (dtoRequestignoreXMLFormatting != null)
                {
                    if (dtoRequestignoreXMLFormatting != null)
                    {
                        dtoRequest["ignoreXmlFormatting"] = SourceExpressionConverter.ConvertToken(dtoRequestignoreXMLFormatting);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreXmlFormatting"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestallInOneTable != null)
                {
                    if (dtoRequestallInOneTable != null)
                    {
                        dtoRequest["allInOneTable"] = SourceExpressionConverter.ConvertToken(dtoRequestallInOneTable);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["allInOneTable"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestadjustExcelColumnToContent != null)
                {
                    if (dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestwrapExcelColumnText != null)
                {
                    if (dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestexcelFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestexcelFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1120ConvertXmlToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1053ConvertXmlToJson> ConvertXmlToJson([WorkflowExpression] Func<string> dtoRequestxML, [WorkflowExpression] Func<bool> dtoRequestignoreXMLFormatting = null)
        {
            SourceExpression.Validate(dtoRequestxML, nameof(dtoRequestxML), required: true);
            SourceExpression.Validate(dtoRequestignoreXMLFormatting, nameof(dtoRequestignoreXMLFormatting), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1053_ConvertXmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestxML);
                if (dtoRequestignoreXMLFormatting != null)
                {
                    dtoRequest["ignoreXmlFormatting"] = SourceExpressionConverter.ConvertToken(dtoRequestignoreXMLFormatting);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1053ConvertXmlToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8011ConvertXRechnungToPdf> ConvertXRechnungToPdf([WorkflowExpression] Func<string> dtoRequestxRechnung, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestxRechnung, nameof(dtoRequestxRechnung), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V8011_ConvertXRechnungToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestxRechnung);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV8011ConvertXRechnungToPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson> ConvertYamlToJson([WorkflowExpression] Func<string> dtoRequestV1071YamlToJsonyAML)
        {
            SourceExpression.Validate(dtoRequestV1071YamlToJsonyAML, nameof(dtoRequestV1071YamlToJsonyAML), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1071_ConvertYamlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1071YamlToJson = new JObject();
                var dtoRequestV1071YamlToJsonpropCount = 0;
                dtoRequestV1071YamlToJsonpropCount++;
                dtoRequestV1071YamlToJson["yaml"] = SourceExpressionConverter.ConvertToken(dtoRequestV1071YamlToJsonyAML);
                if (dtoRequestV1071YamlToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1071YamlToJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1071ConvertYamlToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3092CreateChartImage> CreateChartImage([WorkflowExpression] Func<string> dtoRequesttableData, [WorkflowExpression] Func<int> dtoRequestimageWidth = null, [WorkflowExpression] Func<int> dtoRequestimageHeight = null, [WorkflowExpression] Func<string> dtoRequestbackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestchartType = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesttableData, nameof(dtoRequesttableData), required: true);
            SourceExpression.Validate(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            SourceExpression.Validate(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            SourceExpression.Validate(dtoRequestbackgroundColor, nameof(dtoRequestbackgroundColor), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestchartType, nameof(dtoRequestchartType), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3092_CreateChartImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = SourceExpressionConverter.ConvertToken(dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = SourceExpressionConverter.ConvertToken(dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestbackgroundColor != null)
                {
                    dtoRequest["backgroundColor"] = SourceExpressionConverter.ConvertToken(dtoRequestbackgroundColor);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["format"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["chart"] = SourceExpressionConverter.ConvertToken(dtoRequesttableData);
                if (dtoRequestchartType != null)
                {
                    dtoRequest["type"] = SourceExpressionConverter.ConvertToken(dtoRequestchartType);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3092CreateChartImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3063CreateCode> CreateCode([WorkflowExpression] Func<string> dtoRequestcontent, [WorkflowExpression] Func<string> dtoRequestcodeFormat = null, [WorkflowExpression] Func<int> dtoRequestwidth = null, [WorkflowExpression] Func<int> dtoRequestheight = null, [WorkflowExpression] Func<string> dtoRequestoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestembeddedImage = null, [WorkflowExpression] Func<double> dtoRequestembeddedImageOpacity = null, [WorkflowExpression] Func<double> dtoRequestembeddedImageRatio = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestcontent, nameof(dtoRequestcontent), required: true);
            SourceExpression.Validate(dtoRequestcodeFormat, nameof(dtoRequestcodeFormat), required: false);
            SourceExpression.Validate(dtoRequestwidth, nameof(dtoRequestwidth), required: false);
            SourceExpression.Validate(dtoRequestheight, nameof(dtoRequestheight), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestembeddedImage, nameof(dtoRequestembeddedImage), required: false);
            SourceExpression.Validate(dtoRequestembeddedImageOpacity, nameof(dtoRequestembeddedImageOpacity), required: false);
            SourceExpression.Validate(dtoRequestembeddedImageRatio, nameof(dtoRequestembeddedImageRatio), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3063_CreateCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["content"] = SourceExpressionConverter.ConvertToken(dtoRequestcontent);
                if (dtoRequestcodeFormat != null)
                {
                    dtoRequest["codeFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestcodeFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestwidth != null)
                {
                    dtoRequest["width"] = SourceExpressionConverter.ConvertToken(dtoRequestwidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheight != null)
                {
                    dtoRequest["height"] = SourceExpressionConverter.ConvertToken(dtoRequestheight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["outFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestembeddedImage != null)
                {
                    dtoRequest["image"] = SourceExpressionConverter.ConvertToken(dtoRequestembeddedImage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestembeddedImageOpacity != null)
                {
                    dtoRequest["imageOpacity"] = SourceExpressionConverter.ConvertToken(dtoRequestembeddedImageOpacity);
                    dtoRequestpropCount++;
                }

                if (dtoRequestembeddedImageRatio != null)
                {
                    dtoRequest["imageRatio"] = SourceExpressionConverter.ConvertToken(dtoRequestembeddedImageRatio);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3063CreateCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3112CreateGraphImage> CreateGraphImage([WorkflowExpression] Func<string> dtoRequestgraphData, [WorkflowExpression] Func<int> dtoRequestimageWidth = null, [WorkflowExpression] Func<int> dtoRequestimageHeight = null, [WorkflowExpression] Func<string> dtoRequestbackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestoutputFormat = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestgraphData, nameof(dtoRequestgraphData), required: true);
            SourceExpression.Validate(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            SourceExpression.Validate(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            SourceExpression.Validate(dtoRequestbackgroundColor, nameof(dtoRequestbackgroundColor), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3112_CreateGraphImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = SourceExpressionConverter.ConvertToken(dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = SourceExpressionConverter.ConvertToken(dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestbackgroundColor != null)
                {
                    dtoRequest["backgroundColor"] = SourceExpressionConverter.ConvertToken(dtoRequestbackgroundColor);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["format"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["graph"] = SourceExpressionConverter.ConvertToken(dtoRequestgraphData);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3112CreateGraphImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3102CreateTableImage> CreateTableImage([WorkflowExpression] Func<string> dtoRequesttableData, [WorkflowExpression] Func<int> dtoRequestimageWidth = null, [WorkflowExpression] Func<int> dtoRequestimageHeight = null, [WorkflowExpression] Func<string> dtoRequestbackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestoutputFormat = null, [WorkflowExpression] Func<string> dtoRequesttitle = null, [WorkflowExpression] Func<bool> dtoRequestshowTableBorders = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequesttableData, nameof(dtoRequesttableData), required: true);
            SourceExpression.Validate(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            SourceExpression.Validate(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            SourceExpression.Validate(dtoRequestbackgroundColor, nameof(dtoRequestbackgroundColor), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            SourceExpression.Validate(dtoRequesttitle, nameof(dtoRequesttitle), required: false);
            SourceExpression.Validate(dtoRequestshowTableBorders, nameof(dtoRequestshowTableBorders), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3102_CreateTableImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = SourceExpressionConverter.ConvertToken(dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = SourceExpressionConverter.ConvertToken(dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestbackgroundColor != null)
                {
                    dtoRequest["backgroundColor"] = SourceExpressionConverter.ConvertToken(dtoRequestbackgroundColor);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["format"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["data"] = SourceExpressionConverter.ConvertToken(dtoRequesttableData);
                if (dtoRequesttitle != null)
                {
                    dtoRequest["title"] = SourceExpressionConverter.ConvertToken(dtoRequesttitle);
                    dtoRequestpropCount++;
                }

                if (dtoRequestshowTableBorders != null)
                {
                    if (dtoRequestshowTableBorders != null)
                    {
                        dtoRequest["hasLines"] = SourceExpressionConverter.ConvertToken(dtoRequestshowTableBorders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["hasLines"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3102CreateTableImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3082CreateWatermarkImage> CreateWatermarkImage([WorkflowExpression] Func<string> dtoRequestmainImage, [WorkflowExpression] Func<string> dtoRequestwatermarkImage, [WorkflowExpression] Func<int> dtoRequestwatermarkOpacity = null, [WorkflowExpression] Func<int> dtoRequestwatermarkRatio = null, [WorkflowExpression] Func<string> dtoRequestwatermarkHorizontalPosition = null, [WorkflowExpression] Func<string> dtoRequestwatermarkVerticalPosition = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestmainImage, nameof(dtoRequestmainImage), required: true);
            SourceExpression.Validate(dtoRequestwatermarkImage, nameof(dtoRequestwatermarkImage), required: true);
            SourceExpression.Validate(dtoRequestwatermarkOpacity, nameof(dtoRequestwatermarkOpacity), required: false);
            SourceExpression.Validate(dtoRequestwatermarkRatio, nameof(dtoRequestwatermarkRatio), required: false);
            SourceExpression.Validate(dtoRequestwatermarkHorizontalPosition, nameof(dtoRequestwatermarkHorizontalPosition), required: false);
            SourceExpression.Validate(dtoRequestwatermarkVerticalPosition, nameof(dtoRequestwatermarkVerticalPosition), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3082_CreateWatermarkImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["image"] = SourceExpressionConverter.ConvertToken(dtoRequestmainImage);
                dtoRequestpropCount++;
                dtoRequest["watermarkImage"] = SourceExpressionConverter.ConvertToken(dtoRequestwatermarkImage);
                if (dtoRequestwatermarkOpacity != null)
                {
                    dtoRequest["opacity"] = SourceExpressionConverter.ConvertToken(dtoRequestwatermarkOpacity);
                    dtoRequestpropCount++;
                }

                if (dtoRequestwatermarkRatio != null)
                {
                    dtoRequest["ratio"] = SourceExpressionConverter.ConvertToken(dtoRequestwatermarkRatio);
                    dtoRequestpropCount++;
                }

                if (dtoRequestwatermarkHorizontalPosition != null)
                {
                    dtoRequest["imagePositionHorizontal"] = SourceExpressionConverter.ConvertToken(dtoRequestwatermarkHorizontalPosition);
                    dtoRequestpropCount++;
                }

                if (dtoRequestwatermarkVerticalPosition != null)
                {
                    dtoRequest["imagePositionVertical"] = SourceExpressionConverter.ConvertToken(dtoRequestwatermarkVerticalPosition);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3082CreateWatermarkImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5012CreateWordFile> CreateWordFile([WorkflowExpression] Func<Section[]> dtoRequestsection, [WorkflowExpression] Func<string> dtoRequestexistingFileContent = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestsection, nameof(dtoRequestsection), required: true);
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5012_CreateWordFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["sections"] = SourceExpressionConverter.ConvertToken(dtoRequestsection);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5012CreateWordFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf> ExtractImagesFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<string> dtoRequestfileNamePrefix = null, [WorkflowExpression] Func<bool> dtoRequestincludeBase64String = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestfileNamePrefix, nameof(dtoRequestfileNamePrefix), required: false);
            SourceExpression.Validate(dtoRequestincludeBase64String, nameof(dtoRequestincludeBase64String), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4090_ExtractImagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileNamePrefix != null)
                {
                    dtoRequest["fileNamePrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestfileNamePrefix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestincludeBase64String != null)
                {
                    dtoRequest["includeFileString"] = SourceExpressionConverter.ConvertToken(dtoRequestincludeBase64String);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4090ExtractImagesFromPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties> ExtractJsonObjectProperties([WorkflowExpression] Func<string> dtoRequestV2100ExtractJsonObjectPropertiesjSON, [WorkflowExpression] Func<bool> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
        {
            SourceExpression.Validate(dtoRequestV2100ExtractJsonObjectPropertiesjSON, nameof(dtoRequestV2100ExtractJsonObjectPropertiesjSON), required: true);
            SourceExpression.Validate(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties, nameof(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2100_ExtractJsonObjectProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2100ExtractJsonObjectProperties = new JObject();
                var dtoRequestV2100ExtractJsonObjectPropertiespropCount = 0;
                dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
                dtoRequestV2100ExtractJsonObjectProperties["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV2100ExtractJsonObjectPropertiesjSON);
                if (dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                {
                    if (dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                    {
                        dtoRequestV2100ExtractJsonObjectProperties["nestedPropertyExtraction"] = SourceExpressionConverter.ConvertToken(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties);
                        dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
                    }

                    dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
                }
                else
                {
                    dtoRequestV2100ExtractJsonObjectProperties["nestedPropertyExtraction"] = true;
                    dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
                }

                if (dtoRequestV2100ExtractJsonObjectPropertiespropCount > 0)
                {
                    callPayload.Body = dtoRequestV2100ExtractJsonObjectProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2100ExtractJsonObjectProperties>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4061ExtractPdfPages> ExtractPdfPages([WorkflowExpression] Func<string> dtoRequestpDFFile, [WorkflowExpression] Func<string> dtoRequestpagesToExtract, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestpDFFile, nameof(dtoRequestpDFFile), required: true);
            SourceExpression.Validate(dtoRequestpagesToExtract, nameof(dtoRequestpagesToExtract), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4061_ExtractPdfPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestpDFFile);
                dtoRequestpropCount++;
                dtoRequest["pages"] = SourceExpressionConverter.ConvertToken(dtoRequestpagesToExtract);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4061ExtractPdfPages>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4160ExtractPdfTablesToCsv> ExtractPdfTablesToCsv([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<int> dtoRequestheaderRow = null, [WorkflowExpression] Func<string> dtoRequestseparator = null, [WorkflowExpression] Func<string> dtoRequestcSVFileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            SourceExpression.Validate(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            SourceExpression.Validate(dtoRequestcSVFileName, nameof(dtoRequestcSVFileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4160_ExtractPdfTablesToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = SourceExpressionConverter.ConvertToken(dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestcSVFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestcSVFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4160ExtractPdfTablesToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4150ExtractPdfTablesToExcel> ExtractPdfTablesToExcel([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<int> dtoRequestheaderRow = null, [WorkflowExpression] Func<string> dtoRequestexcelFileName = null, [WorkflowExpression] Func<int> dtoRequestfileResponse = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            SourceExpression.Validate(dtoRequestexcelFileName, nameof(dtoRequestexcelFileName), required: false);
            SourceExpression.Validate(dtoRequestfileResponse, nameof(dtoRequestfileResponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4150_ExtractPdfTablesToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = SourceExpressionConverter.ConvertToken(dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequestexcelFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestexcelFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileResponse != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestfileResponse);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4150ExtractPdfTablesToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4170ExtractPdfTablesToHtml> ExtractPdfTablesToHtml([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<int> dtoRequestheaderRow = null, [WorkflowExpression] Func<string> dtoRequesthTMLFileName = null, [WorkflowExpression] Func<int> dtoRequestoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            SourceExpression.Validate(dtoRequesthTMLFileName, nameof(dtoRequesthTMLFileName), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4170_ExtractPdfTablesToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = SourceExpressionConverter.ConvertToken(dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequesthTMLFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequesthTMLFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4170ExtractPdfTablesToHtml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4140ExtractPdfTablesToJson> ExtractPdfTablesToJson([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<int> dtoRequestheaderRow = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4140_ExtractPdfTablesToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = SourceExpressionConverter.ConvertToken(dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4140ExtractPdfTablesToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern> ExtractTextAccordingToPattern([WorkflowExpression] Func<string> dtoRequestV2140ExtractTextAccordingToPatterntext, [WorkflowExpression] Func<string> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, [WorkflowExpression] Func<bool> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, [WorkflowExpression] Func<string> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
        {
            SourceExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatterntext, nameof(dtoRequestV2140ExtractTextAccordingToPatterntext), required: true);
            SourceExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, nameof(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern), required: true);
            SourceExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled), required: false);
            SourceExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2140_ExtractTextAccordingToPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2140ExtractTextAccordingToPattern = new JObject();
                var dtoRequestV2140ExtractTextAccordingToPatternpropCount = 0;
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                dtoRequestV2140ExtractTextAccordingToPattern["inputText"] = SourceExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatterntext);
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                dtoRequestV2140ExtractTextAccordingToPattern["matchPattern"] = SourceExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern);
                if (dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled != null)
                {
                    dtoRequestV2140ExtractTextAccordingToPattern["trimEnabled"] = SourceExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled);
                    dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                }

                if (dtoRequestV2140ExtractTextAccordingToPatterntrimStrings != null)
                {
                    dtoRequestV2140ExtractTextAccordingToPattern["trimStrings"] = SourceExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings);
                    dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                }

                if (dtoRequestV2140ExtractTextAccordingToPatternpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2140ExtractTextAccordingToPattern;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2140ExtractTextAccordingToPattern>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf> ExtractTextFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<bool> dtoRequestlayoutBased = null, [WorkflowExpression] Func<bool> dtoRequestincludePages = null, [WorkflowExpression] Func<string> dtoRequestpageSeparator = null, [WorkflowExpression] Func<bool> dtoRequestnormalizeWhitespace = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            SourceExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            SourceExpression.Validate(dtoRequestlayoutBased, nameof(dtoRequestlayoutBased), required: false);
            SourceExpression.Validate(dtoRequestincludePages, nameof(dtoRequestincludePages), required: false);
            SourceExpression.Validate(dtoRequestpageSeparator, nameof(dtoRequestpageSeparator), required: false);
            SourceExpression.Validate(dtoRequestnormalizeWhitespace, nameof(dtoRequestnormalizeWhitespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4100_ExtractTextFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = SourceExpressionConverter.ConvertToken(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = SourceExpressionConverter.ConvertToken(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestlayoutBased != null)
                {
                    dtoRequest["layoutBased"] = SourceExpressionConverter.ConvertToken(dtoRequestlayoutBased);
                    dtoRequestpropCount++;
                }

                if (dtoRequestincludePages != null)
                {
                    dtoRequest["includePages"] = SourceExpressionConverter.ConvertToken(dtoRequestincludePages);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpageSeparator != null)
                {
                    dtoRequest["pageSeparator"] = SourceExpressionConverter.ConvertToken(dtoRequestpageSeparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestnormalizeWhitespace != null)
                {
                    dtoRequest["normalizeWhitespace"] = SourceExpressionConverter.ConvertToken(dtoRequestnormalizeWhitespace);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4100ExtractTextFromPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> ExtractWordBookmarks([WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarksFile, [WorkflowExpression] Func<bool> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, [WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarkssearchName = null, [WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            SourceExpression.Validate(dtoRequestV5021ExtractWordBookmarksFile, nameof(dtoRequestV5021ExtractWordBookmarksFile), required: true);
            SourceExpression.Validate(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks, nameof(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks), required: false);
            SourceExpression.Validate(dtoRequestV5021ExtractWordBookmarkssearchName, nameof(dtoRequestV5021ExtractWordBookmarkssearchName), required: false);
            SourceExpression.Validate(dtoRequestV5021ExtractWordBookmarkssearchContent, nameof(dtoRequestV5021ExtractWordBookmarkssearchContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5021_ExtractWordBookmarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5021ExtractWordBookmarks = new JObject();
                var dtoRequestV5021ExtractWordBookmarkspropCount = 0;
                dtoRequestV5021ExtractWordBookmarkspropCount++;
                dtoRequestV5021ExtractWordBookmarks["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarksFile);
                if (dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                {
                    if (dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                    {
                        dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = SourceExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks);
                        dtoRequestV5021ExtractWordBookmarkspropCount++;
                    }

                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }
                else
                {
                    dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = false;
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (dtoRequestV5021ExtractWordBookmarkssearchName != null)
                {
                    dtoRequestV5021ExtractWordBookmarks["searchKey"] = SourceExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarkssearchName);
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (dtoRequestV5021ExtractWordBookmarkssearchContent != null)
                {
                    dtoRequestV5021ExtractWordBookmarks["searchValue"] = SourceExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarkssearchContent);
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (dtoRequestV5021ExtractWordBookmarkspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5021ExtractWordBookmarks;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5021ExtractWordBookmarks>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> ExtractWordContentControls([WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlsFile, [WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlssearchTag = null, [WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            SourceExpression.Validate(dtoRequestV5120ExtractWordContentControlsFile, nameof(dtoRequestV5120ExtractWordContentControlsFile), required: true);
            SourceExpression.Validate(dtoRequestV5120ExtractWordContentControlssearchTag, nameof(dtoRequestV5120ExtractWordContentControlssearchTag), required: false);
            SourceExpression.Validate(dtoRequestV5120ExtractWordContentControlssearchTitle, nameof(dtoRequestV5120ExtractWordContentControlssearchTitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5120_ExtractWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5120ExtractWordContentControls = new JObject();
                var dtoRequestV5120ExtractWordContentControlspropCount = 0;
                dtoRequestV5120ExtractWordContentControlspropCount++;
                dtoRequestV5120ExtractWordContentControls["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlsFile);
                if (dtoRequestV5120ExtractWordContentControlssearchTag != null)
                {
                    dtoRequestV5120ExtractWordContentControls["searchTag"] = SourceExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlssearchTag);
                    dtoRequestV5120ExtractWordContentControlspropCount++;
                }

                if (dtoRequestV5120ExtractWordContentControlssearchTitle != null)
                {
                    dtoRequestV5120ExtractWordContentControls["searchTitle"] = SourceExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlssearchTitle);
                    dtoRequestV5120ExtractWordContentControlspropCount++;
                }

                if (dtoRequestV5120ExtractWordContentControlspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5120ExtractWordContentControls;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5120ExtractWordContentControls>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2021IbanData> IbanData([WorkflowExpression] Func<string> dtoRequestV2021IbanDataiBAN)
        {
            SourceExpression.Validate(dtoRequestV2021IbanDataiBAN, nameof(dtoRequestV2021IbanDataiBAN), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2021_IbanData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2021IbanData = new JObject();
                var dtoRequestV2021IbanDatapropCount = 0;
                dtoRequestV2021IbanDatapropCount++;
                dtoRequestV2021IbanData["iban"] = SourceExpressionConverter.ConvertToken(dtoRequestV2021IbanDataiBAN);
                if (dtoRequestV2021IbanDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV2021IbanData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2021IbanData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData> ImageMetaData([WorkflowExpression] Func<string> dtoRequestV3071ImageMetaDataimageFile)
        {
            SourceExpression.Validate(dtoRequestV3071ImageMetaDataimageFile, nameof(dtoRequestV3071ImageMetaDataimageFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3071_ImageMetaData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3071ImageMetaData = new JObject();
                var dtoRequestV3071ImageMetaDatapropCount = 0;
                dtoRequestV3071ImageMetaDatapropCount++;
                dtoRequestV3071ImageMetaData["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV3071ImageMetaDataimageFile);
                if (dtoRequestV3071ImageMetaDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV3071ImageMetaData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3071ImageMetaData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToPowerPoint([WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderImage, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderName = null, [WorkflowExpression] Func<int> dtoRequestV9020InsertImagePowerPointmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV9020InsertImagePowerPointmaximumImageHeight = null, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderSuffix = null)
        {
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointexistingFileContent, nameof(dtoRequestV9020InsertImagePowerPointexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderImage, nameof(dtoRequestV9020InsertImagePowerPointplaceholderImage), required: true);
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderName, nameof(dtoRequestV9020InsertImagePowerPointplaceholderName), required: false);
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointmaximumImageWidth, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointmaximumImageHeight, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageHeight), required: false);
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderPrefix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderSuffix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V9020_InsertImageToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV9020InsertImagePowerPoint = new JObject();
                var dtoRequestV9020InsertImagePowerPointpropCount = 0;
                dtoRequestV9020InsertImagePowerPointpropCount++;
                dtoRequestV9020InsertImagePowerPoint["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointexistingFileContent);
                if (dtoRequestV9020InsertImagePowerPointplaceholderName != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderName);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                dtoRequestV9020InsertImagePowerPointpropCount++;
                dtoRequestV9020InsertImagePowerPoint["placeholderImage"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderImage);
                if (dtoRequestV9020InsertImagePowerPointmaximumImageWidth != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointmaximumImageWidth);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointmaximumImageHeight != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointmaximumImageHeight);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointplaceholderPrefix != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderPrefix);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointplaceholderSuffix != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderSuffix);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointpropCount > 0)
                {
                    callPayload.Body = dtoRequestV9020InsertImagePowerPoint;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5082InsertImageToWord> InsertImageToWord([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<string> dtoRequestimage, [WorkflowExpression] Func<string> dtoRequestplaceholderName = null, [WorkflowExpression] Func<int> dtoRequestmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestmaximumImageHeight = null, [WorkflowExpression] Func<string> dtoRequestplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestplaceholderSuffix = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestimage, nameof(dtoRequestimage), required: true);
            SourceExpression.Validate(dtoRequestplaceholderName, nameof(dtoRequestplaceholderName), required: false);
            SourceExpression.Validate(dtoRequestmaximumImageWidth, nameof(dtoRequestmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestmaximumImageHeight, nameof(dtoRequestmaximumImageHeight), required: false);
            SourceExpression.Validate(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5082_InsertImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                if (dtoRequestplaceholderName != null)
                {
                    dtoRequest["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderName);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["placeholderImage"] = SourceExpressionConverter.ConvertToken(dtoRequestimage);
                if (dtoRequestmaximumImageWidth != null)
                {
                    dtoRequest["maxWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestmaximumImageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmaximumImageHeight != null)
                {
                    dtoRequest["maxHeight"] = SourceExpressionConverter.ConvertToken(dtoRequestmaximumImageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5082InsertImageToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5111InsertMultipleTextSectionsToWord> InsertMultipleTextSectionsToWord([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<InsertSection[]> dtoRequestplaceholder, [WorkflowExpression] Func<string> dtoRequestplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestplaceholderSuffix = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestplaceholder, nameof(dtoRequestplaceholder), required: true);
            SourceExpression.Validate(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5111_InsertMultipleTextSectionsToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["insertSections"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholder);
                if (dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5111InsertMultipleTextSectionsToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5092InsertTableToWord> InsertTableToWord([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<string> dtoRequestplaceholderName = null, [WorkflowExpression] Func<string> dtoRequestplaceholderTable = null, [WorkflowExpression] Func<string> dtoRequesttableStyle = null, [WorkflowExpression] Func<bool> dtoRequestshowHeaders = null, [WorkflowExpression] Func<string> dtoRequestplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestplaceholderSuffix = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestplaceholderName, nameof(dtoRequestplaceholderName), required: false);
            SourceExpression.Validate(dtoRequestplaceholderTable, nameof(dtoRequestplaceholderTable), required: false);
            SourceExpression.Validate(dtoRequesttableStyle, nameof(dtoRequesttableStyle), required: false);
            SourceExpression.Validate(dtoRequestshowHeaders, nameof(dtoRequestshowHeaders), required: false);
            SourceExpression.Validate(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5092_InsertTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                if (dtoRequestplaceholderName != null)
                {
                    dtoRequest["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderTable != null)
                {
                    dtoRequest["placeholderTable"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderTable);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttableStyle != null)
                {
                    if (dtoRequesttableStyle != null)
                    {
                        dtoRequest["tableStyle"] = SourceExpressionConverter.ConvertToken(dtoRequesttableStyle);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["tableStyle"] = "GridTable1Light";
                    dtoRequestpropCount++;
                }

                if (dtoRequestshowHeaders != null)
                {
                    if (dtoRequestshowHeaders != null)
                    {
                        dtoRequest["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestshowHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["hasHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5092InsertTableToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertTextToPowerPoint([WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderName, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderText = null, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            SourceExpression.Validate(dtoRequestV9010InsertTextToPowerPointexistingFileContent, nameof(dtoRequestV9010InsertTextToPowerPointexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderName, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderName), required: true);
            SourceExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderText, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderText), required: false);
            SourceExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V9010_InsertTextToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV9010InsertTextToPowerPoint = new JObject();
                var dtoRequestV9010InsertTextToPowerPointpropCount = 0;
                dtoRequestV9010InsertTextToPowerPointpropCount++;
                dtoRequestV9010InsertTextToPowerPoint["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointexistingFileContent);
                dtoRequestV9010InsertTextToPowerPointpropCount++;
                dtoRequestV9010InsertTextToPowerPoint["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderName);
                if (dtoRequestV9010InsertTextToPowerPointplaceholderText != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderText"] = SourceExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderText);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (dtoRequestV9010InsertTextToPowerPointplaceholderPrefix != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (dtoRequestV9010InsertTextToPowerPointplaceholderSuffix != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (dtoRequestV9010InsertTextToPowerPointpropCount > 0)
                {
                    callPayload.Body = dtoRequestV9010InsertTextToPowerPoint;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5072InsertTextToWord> InsertTextToWord([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<string> dtoRequestplaceholderName, [WorkflowExpression] Func<string> dtoRequestplaceholderText = null, [WorkflowExpression] Func<string> dtoRequestplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestplaceholderSuffix = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestplaceholderName, nameof(dtoRequestplaceholderName), required: true);
            SourceExpression.Validate(dtoRequestplaceholderText, nameof(dtoRequestplaceholderText), required: false);
            SourceExpression.Validate(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5072_InsertTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderName);
                if (dtoRequestplaceholderText != null)
                {
                    dtoRequest["placeholderText"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderText);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5072InsertTextToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4120MergeMultiplePdfs> MergeMultiplePdfs([WorkflowExpression] Func<PdfMergeItem[]> dtoRequestpDF, [WorkflowExpression] Func<bool> dtoRequestaddPageNumbers = null, [WorkflowExpression] Func<int> dtoRequestpageNumberFormat = null, [WorkflowExpression] Func<int> dtoRequestpageNumberPosition = null, [WorkflowExpression] Func<bool> dtoRequestaddBookmarks = null, [WorkflowExpression] Func<string> dtoRequestpDFTitle = null, [WorkflowExpression] Func<string> dtoRequestpDFAuthor = null, [WorkflowExpression] Func<string> dtoRequestpDFFileName = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestaddPageNumbers, nameof(dtoRequestaddPageNumbers), required: false);
            SourceExpression.Validate(dtoRequestpageNumberFormat, nameof(dtoRequestpageNumberFormat), required: false);
            SourceExpression.Validate(dtoRequestpageNumberPosition, nameof(dtoRequestpageNumberPosition), required: false);
            SourceExpression.Validate(dtoRequestaddBookmarks, nameof(dtoRequestaddBookmarks), required: false);
            SourceExpression.Validate(dtoRequestpDFTitle, nameof(dtoRequestpDFTitle), required: false);
            SourceExpression.Validate(dtoRequestpDFAuthor, nameof(dtoRequestpDFAuthor), required: false);
            SourceExpression.Validate(dtoRequestpDFFileName, nameof(dtoRequestpDFFileName), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4120_MergeMultiplePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdfFiles"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                if (dtoRequestaddPageNumbers != null)
                {
                    if (dtoRequestaddPageNumbers != null)
                    {
                        dtoRequest["addPageNumbers"] = SourceExpressionConverter.ConvertToken(dtoRequestaddPageNumbers);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["addPageNumbers"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestpageNumberFormat != null)
                {
                    dtoRequest["pageNumberFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestpageNumberFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpageNumberPosition != null)
                {
                    dtoRequest["pageNumberPosition"] = SourceExpressionConverter.ConvertToken(dtoRequestpageNumberPosition);
                    dtoRequestpropCount++;
                }

                if (dtoRequestaddBookmarks != null)
                {
                    if (dtoRequestaddBookmarks != null)
                    {
                        dtoRequest["addBookmarks"] = SourceExpressionConverter.ConvertToken(dtoRequestaddBookmarks);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["addBookmarks"] = false;
                    dtoRequestpropCount++;
                }

                if (dtoRequestpDFTitle != null)
                {
                    dtoRequest["pdfTitle"] = SourceExpressionConverter.ConvertToken(dtoRequestpDFTitle);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpDFAuthor != null)
                {
                    dtoRequest["pdfAuthor"] = SourceExpressionConverter.ConvertToken(dtoRequestpDFAuthor);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpDFFileName != null)
                {
                    dtoRequest["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestpDFFileName);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4120MergeMultiplePdfs>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4022MergePdfs> MergePdfs([WorkflowExpression] Func<string> dtoRequestfile1, [WorkflowExpression] Func<string> dtoRequestfile2, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestfile1, nameof(dtoRequestfile1), required: true);
            SourceExpression.Validate(dtoRequestfile2, nameof(dtoRequestfile2), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4022_MergePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file1"] = SourceExpressionConverter.ConvertToken(dtoRequestfile1);
                dtoRequestpropCount++;
                dtoRequest["file2"] = SourceExpressionConverter.ConvertToken(dtoRequestfile2);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4022MergePdfs>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck> PatternMatchCheck([WorkflowExpression] Func<string> dtoRequestV2120PatternMatchCheckinputText, [WorkflowExpression] Func<string> dtoRequestV2120PatternMatchCheckmatchPattern)
        {
            SourceExpression.Validate(dtoRequestV2120PatternMatchCheckinputText, nameof(dtoRequestV2120PatternMatchCheckinputText), required: true);
            SourceExpression.Validate(dtoRequestV2120PatternMatchCheckmatchPattern, nameof(dtoRequestV2120PatternMatchCheckmatchPattern), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2120_PatternMatchCheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2120PatternMatchCheck = new JObject();
                var dtoRequestV2120PatternMatchCheckpropCount = 0;
                dtoRequestV2120PatternMatchCheckpropCount++;
                dtoRequestV2120PatternMatchCheck["inputText"] = SourceExpressionConverter.ConvertToken(dtoRequestV2120PatternMatchCheckinputText);
                dtoRequestV2120PatternMatchCheckpropCount++;
                dtoRequestV2120PatternMatchCheck["matchPattern"] = SourceExpressionConverter.ConvertToken(dtoRequestV2120PatternMatchCheckmatchPattern);
                if (dtoRequestV2120PatternMatchCheckpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2120PatternMatchCheck;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2120MatchPatternCheck>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> PdfMetadata([WorkflowExpression] Func<string> dtoRequestV4031PdfMetadataFile)
        {
            SourceExpression.Validate(dtoRequestV4031PdfMetadataFile, nameof(dtoRequestV4031PdfMetadataFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4031_PdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4031PdfMetadata = new JObject();
                var dtoRequestV4031PdfMetadatapropCount = 0;
                dtoRequestV4031PdfMetadatapropCount++;
                dtoRequestV4031PdfMetadata["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV4031PdfMetadataFile);
                if (dtoRequestV4031PdfMetadatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV4031PdfMetadata;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4042ProtectPdf> ProtectPdf([WorkflowExpression] Func<string> dtoRequestFile, [WorkflowExpression] Func<string> dtoRequestownerPassword = null, [WorkflowExpression] Func<string> dtoRequestuserPassword = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestFile, nameof(dtoRequestFile), required: true);
            SourceExpression.Validate(dtoRequestownerPassword, nameof(dtoRequestownerPassword), required: false);
            SourceExpression.Validate(dtoRequestuserPassword, nameof(dtoRequestuserPassword), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4042_ProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestFile);
                if (dtoRequestownerPassword != null)
                {
                    dtoRequest["ownerPassword"] = SourceExpressionConverter.ConvertToken(dtoRequestownerPassword);
                    dtoRequestpropCount++;
                }

                if (dtoRequestuserPassword != null)
                {
                    dtoRequest["userPassword"] = SourceExpressionConverter.ConvertToken(dtoRequestuserPassword);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4042ProtectPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode> ReadCode([WorkflowExpression] Func<string> dtoRequestReadCodeDataqROrBarcode)
        {
            SourceExpression.Validate(dtoRequestReadCodeDataqROrBarcode, nameof(dtoRequestReadCodeDataqROrBarcode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3051_ReadCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestReadCodeData = new JObject();
                var dtoRequestReadCodeDatapropCount = 0;
                dtoRequestReadCodeDatapropCount++;
                dtoRequestReadCodeData["file"] = SourceExpressionConverter.ConvertToken(dtoRequestReadCodeDataqROrBarcode);
                if (dtoRequestReadCodeDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestReadCodeData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3051ReadCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression> RegularExpression([WorkflowExpression] Func<string> dtoRequestV2011RegularExpressiontextToMatch, [WorkflowExpression] Func<string> dtoRequestV2011RegularExpressionregularExpression = null, [WorkflowExpression] Func<string> dtoRequestV2011RegularExpressionregularExpressionOption = null)
        {
            SourceExpression.Validate(dtoRequestV2011RegularExpressiontextToMatch, nameof(dtoRequestV2011RegularExpressiontextToMatch), required: true);
            SourceExpression.Validate(dtoRequestV2011RegularExpressionregularExpression, nameof(dtoRequestV2011RegularExpressionregularExpression), required: false);
            SourceExpression.Validate(dtoRequestV2011RegularExpressionregularExpressionOption, nameof(dtoRequestV2011RegularExpressionregularExpressionOption), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2011_RegularExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2011RegularExpression = new JObject();
                var dtoRequestV2011RegularExpressionpropCount = 0;
                dtoRequestV2011RegularExpressionpropCount++;
                dtoRequestV2011RegularExpression["input"] = SourceExpressionConverter.ConvertToken(dtoRequestV2011RegularExpressiontextToMatch);
                if (dtoRequestV2011RegularExpressionregularExpression != null)
                {
                    dtoRequestV2011RegularExpression["pattern"] = SourceExpressionConverter.ConvertToken(dtoRequestV2011RegularExpressionregularExpression);
                    dtoRequestV2011RegularExpressionpropCount++;
                }

                if (dtoRequestV2011RegularExpressionregularExpressionOption != null)
                {
                    dtoRequestV2011RegularExpression["option"] = SourceExpressionConverter.ConvertToken(dtoRequestV2011RegularExpressionregularExpressionOption);
                    dtoRequestV2011RegularExpressionpropCount++;
                }

                if (dtoRequestV2011RegularExpressionpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2011RegularExpression;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2011RegularExpression>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4111RemovePagesFromPdf> RemovePagesFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<string> dtoRequestpages, [WorkflowExpression] Func<bool> dtoRequestinputIs1Based = null, [WorkflowExpression] Func<int> dtoRequestmode = null, [WorkflowExpression] Func<bool> dtoRequestfailIfPageOutOfRange = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestpages, nameof(dtoRequestpages), required: true);
            SourceExpression.Validate(dtoRequestinputIs1Based, nameof(dtoRequestinputIs1Based), required: false);
            SourceExpression.Validate(dtoRequestmode, nameof(dtoRequestmode), required: false);
            SourceExpression.Validate(dtoRequestfailIfPageOutOfRange, nameof(dtoRequestfailIfPageOutOfRange), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4111_RemovePagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestpDF);
                dtoRequestpropCount++;
                dtoRequest["pages"] = SourceExpressionConverter.ConvertToken(dtoRequestpages);
                if (dtoRequestinputIs1Based != null)
                {
                    dtoRequest["oneBased"] = SourceExpressionConverter.ConvertToken(dtoRequestinputIs1Based);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmode != null)
                {
                    dtoRequest["mode"] = SourceExpressionConverter.ConvertToken(dtoRequestmode);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfailIfPageOutOfRange != null)
                {
                    dtoRequest["strict"] = SourceExpressionConverter.ConvertToken(dtoRequestfailIfPageOutOfRange);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4111RemovePagesFromPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern> ReplaceTextWithPattern([WorkflowExpression] Func<string> dtoRequestV2110ReplaceTextWithPatterninputText, [WorkflowExpression] Func<string> dtoRequestV2110ReplaceTextWithPatternsearchPattern, [WorkflowExpression] Func<string> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
        {
            SourceExpression.Validate(dtoRequestV2110ReplaceTextWithPatterninputText, nameof(dtoRequestV2110ReplaceTextWithPatterninputText), required: true);
            SourceExpression.Validate(dtoRequestV2110ReplaceTextWithPatternsearchPattern, nameof(dtoRequestV2110ReplaceTextWithPatternsearchPattern), required: true);
            SourceExpression.Validate(dtoRequestV2110ReplaceTextWithPatternreplacementText, nameof(dtoRequestV2110ReplaceTextWithPatternreplacementText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2110_ReplaceTextWithPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2110ReplaceTextWithPattern = new JObject();
                var dtoRequestV2110ReplaceTextWithPatternpropCount = 0;
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
                dtoRequestV2110ReplaceTextWithPattern["inputText"] = SourceExpressionConverter.ConvertToken(dtoRequestV2110ReplaceTextWithPatterninputText);
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
                dtoRequestV2110ReplaceTextWithPattern["searchPattern"] = SourceExpressionConverter.ConvertToken(dtoRequestV2110ReplaceTextWithPatternsearchPattern);
                if (dtoRequestV2110ReplaceTextWithPatternreplacementText != null)
                {
                    dtoRequestV2110ReplaceTextWithPattern["replacementText"] = SourceExpressionConverter.ConvertToken(dtoRequestV2110ReplaceTextWithPatternreplacementText);
                    dtoRequestV2110ReplaceTextWithPatternpropCount++;
                }

                if (dtoRequestV2110ReplaceTextWithPatternpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2110ReplaceTextWithPattern;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2110ReplaceTextWithPattern>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3023ResizeImage> ResizeImage([WorkflowExpression] Func<string> dtoRequestimageFile, [WorkflowExpression] Func<double> dtoRequestimageWidth = null, [WorkflowExpression] Func<double> dtoRequestimageHeight = null, [WorkflowExpression] Func<string> dtoRequestresizeBy = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestimageFile, nameof(dtoRequestimageFile), required: true);
            SourceExpression.Validate(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            SourceExpression.Validate(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            SourceExpression.Validate(dtoRequestresizeBy, nameof(dtoRequestresizeBy), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3023_ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestimageFile);
                if (dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = SourceExpressionConverter.ConvertToken(dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = SourceExpressionConverter.ConvertToken(dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (dtoRequestresizeBy != null)
                {
                    dtoRequest["resizeBy"] = SourceExpressionConverter.ConvertToken(dtoRequestresizeBy);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3023ResizeImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3032RotateImage> RotateImage([WorkflowExpression] Func<string> dtoRequestimageFile, [WorkflowExpression] Func<double> dtoRequestrotate = null, [WorkflowExpression] Func<string> dtoRequestoutputFormat = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestimageFile, nameof(dtoRequestimageFile), required: true);
            SourceExpression.Validate(dtoRequestrotate, nameof(dtoRequestrotate), required: false);
            SourceExpression.Validate(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3032_RotateImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestimageFile);
                if (dtoRequestrotate != null)
                {
                    dtoRequest["rotate"] = SourceExpressionConverter.ConvertToken(dtoRequestrotate);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoutputFormat != null)
                {
                    dtoRequest["outFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3032RotateImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2151RunCode> RunCode([WorkflowExpression] Func<string> dtopythonOrJavaScriptCode, [WorkflowExpression] Func<int> dtoruntime = null, [WorkflowExpression] Func<int> dtotimeoutSeconds = null, [WorkflowExpression] Func<bool> dtoprintLastExpression = null)
        {
            SourceExpression.Validate(dtopythonOrJavaScriptCode, nameof(dtopythonOrJavaScriptCode), required: true);
            SourceExpression.Validate(dtoruntime, nameof(dtoruntime), required: false);
            SourceExpression.Validate(dtotimeoutSeconds, nameof(dtotimeoutSeconds), required: false);
            SourceExpression.Validate(dtoprintLastExpression, nameof(dtoprintLastExpression), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2151_RunCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dto = new JObject();
                var dtopropCount = 0;
                dtopropCount++;
                dto["code"] = SourceExpressionConverter.ConvertToken(dtopythonOrJavaScriptCode);
                if (dtoruntime != null)
                {
                    dto["runtime"] = SourceExpressionConverter.ConvertToken(dtoruntime);
                    dtopropCount++;
                }

                if (dtotimeoutSeconds != null)
                {
                    dto["timeoutSec"] = SourceExpressionConverter.ConvertToken(dtotimeoutSeconds);
                    dtopropCount++;
                }

                if (dtoprintLastExpression != null)
                {
                    dto["printLastExpression"] = SourceExpressionConverter.ConvertToken(dtoprintLastExpression);
                    dtopropCount++;
                }

                if (dtopropCount > 0)
                {
                    callPayload.Body = dto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2151RunCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit> SmartTextSplit([WorkflowExpression] Func<string> dtoRequestV2130SmartTextSplitinputText, [WorkflowExpression] Func<string> dtoRequestV2130SmartTextSplitsplitPattern = null, [WorkflowExpression] Func<bool> dtoRequestV2130SmartTextSplittrimEnabled = null, [WorkflowExpression] Func<string> dtoRequestV2130SmartTextSplittrimStrings = null)
        {
            SourceExpression.Validate(dtoRequestV2130SmartTextSplitinputText, nameof(dtoRequestV2130SmartTextSplitinputText), required: true);
            SourceExpression.Validate(dtoRequestV2130SmartTextSplitsplitPattern, nameof(dtoRequestV2130SmartTextSplitsplitPattern), required: false);
            SourceExpression.Validate(dtoRequestV2130SmartTextSplittrimEnabled, nameof(dtoRequestV2130SmartTextSplittrimEnabled), required: false);
            SourceExpression.Validate(dtoRequestV2130SmartTextSplittrimStrings, nameof(dtoRequestV2130SmartTextSplittrimStrings), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2130_SmartTextSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2130SmartTextSplit = new JObject();
                var dtoRequestV2130SmartTextSplitpropCount = 0;
                dtoRequestV2130SmartTextSplitpropCount++;
                dtoRequestV2130SmartTextSplit["inputText"] = SourceExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplitinputText);
                if (dtoRequestV2130SmartTextSplitsplitPattern != null)
                {
                    dtoRequestV2130SmartTextSplit["splitPattern"] = SourceExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplitsplitPattern);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (dtoRequestV2130SmartTextSplittrimEnabled != null)
                {
                    dtoRequestV2130SmartTextSplit["trimEnabled"] = SourceExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplittrimEnabled);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (dtoRequestV2130SmartTextSplittrimStrings != null)
                {
                    dtoRequestV2130SmartTextSplit["trimStrings"] = SourceExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplittrimStrings);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (dtoRequestV2130SmartTextSplitpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2130SmartTextSplit;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2130SmartTextSplit>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv> SortCsv([WorkflowExpression] Func<string> dtoRequestV2061SortCsvcSV, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV2061SortCsvskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV2061SortCsvstopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV2061SortCsvseparator = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<string> dtoRequestV2061SortCsvsortColumn = null, [WorkflowExpression] Func<string> dtoRequestV2061SortCsvfurtherSortingColumn = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvreverseOrder = null)
        {
            SourceExpression.Validate(dtoRequestV2061SortCsvcSV, nameof(dtoRequestV2061SortCsvcSV), required: true);
            SourceExpression.Validate(dtoRequestV2061SortCsvcSVHasHeaders, nameof(dtoRequestV2061SortCsvcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvautoDetectFieldTypes, nameof(dtoRequestV2061SortCsvautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvremoveEmptyRows, nameof(dtoRequestV2061SortCsvremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvskipANumberOfRows, nameof(dtoRequestV2061SortCsvskipANumberOfRows), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvstopAtASpecificRow, nameof(dtoRequestV2061SortCsvstopAtASpecificRow), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvseparator, nameof(dtoRequestV2061SortCsvseparator), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvautoDetectQuoteDelimiter, nameof(dtoRequestV2061SortCsvautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvsortColumn, nameof(dtoRequestV2061SortCsvsortColumn), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvfurtherSortingColumn, nameof(dtoRequestV2061SortCsvfurtherSortingColumn), required: false);
            SourceExpression.Validate(dtoRequestV2061SortCsvreverseOrder, nameof(dtoRequestV2061SortCsvreverseOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2061_SortCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2061SortCsv = new JObject();
                var dtoRequestV2061SortCsvpropCount = 0;
                dtoRequestV2061SortCsvpropCount++;
                dtoRequestV2061SortCsv["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvcSV);
                if (dtoRequestV2061SortCsvcSVHasHeaders != null)
                {
                    if (dtoRequestV2061SortCsvcSVHasHeaders != null)
                    {
                        dtoRequestV2061SortCsv["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvcSVHasHeaders);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["dataIncludesHeader"] = true;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvautoDetectFieldTypes != null)
                {
                    if (dtoRequestV2061SortCsvautoDetectFieldTypes != null)
                    {
                        dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvautoDetectFieldTypes);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = false;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV2061SortCsv["maxScanRows"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvremoveEmptyRows != null)
                {
                    if (dtoRequestV2061SortCsvremoveEmptyRows != null)
                    {
                        dtoRequestV2061SortCsv["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvremoveEmptyRows);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["ignoreEmptyLine"] = true;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvskipANumberOfRows != null)
                {
                    dtoRequestV2061SortCsv["skip"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvskipANumberOfRows);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvstopAtASpecificRow != null)
                {
                    dtoRequestV2061SortCsv["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvstopAtASpecificRow);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvseparator != null)
                {
                    dtoRequestV2061SortCsv["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvseparator);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV2061SortCsv["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvautoDetectQuoteDelimiter);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["mayHaveQuotedFields"] = true;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvsortColumn != null)
                {
                    dtoRequestV2061SortCsv["sortColumn"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvsortColumn);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvfurtherSortingColumn != null)
                {
                    dtoRequestV2061SortCsv["secondSortColumn"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvfurtherSortingColumn);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvreverseOrder != null)
                {
                    if (dtoRequestV2061SortCsvreverseOrder != null)
                    {
                        dtoRequestV2061SortCsv["isReverse"] = SourceExpressionConverter.ConvertToken(dtoRequestV2061SortCsvreverseOrder);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["isReverse"] = false;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2061SortCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2061SortCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2051SortJson> SortJson([WorkflowExpression] Func<string> dtoRequestV2051SortJsonjSON, [WorkflowExpression] Func<string> dtoRequestV2051SortJsonsortProperty = null, [WorkflowExpression] Func<string> dtoRequestV2051SortJsonfurtherSortingProperty = null, [WorkflowExpression] Func<bool> dtoRequestV2051SortJsonreverseOrder = null)
        {
            SourceExpression.Validate(dtoRequestV2051SortJsonjSON, nameof(dtoRequestV2051SortJsonjSON), required: true);
            SourceExpression.Validate(dtoRequestV2051SortJsonsortProperty, nameof(dtoRequestV2051SortJsonsortProperty), required: false);
            SourceExpression.Validate(dtoRequestV2051SortJsonfurtherSortingProperty, nameof(dtoRequestV2051SortJsonfurtherSortingProperty), required: false);
            SourceExpression.Validate(dtoRequestV2051SortJsonreverseOrder, nameof(dtoRequestV2051SortJsonreverseOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2051_SortJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2051SortJson = new JObject();
                var dtoRequestV2051SortJsonpropCount = 0;
                dtoRequestV2051SortJsonpropCount++;
                dtoRequestV2051SortJson["json"] = SourceExpressionConverter.ConvertToken(dtoRequestV2051SortJsonjSON);
                if (dtoRequestV2051SortJsonsortProperty != null)
                {
                    dtoRequestV2051SortJson["sortProperty"] = SourceExpressionConverter.ConvertToken(dtoRequestV2051SortJsonsortProperty);
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (dtoRequestV2051SortJsonfurtherSortingProperty != null)
                {
                    dtoRequestV2051SortJson["secondSortProperty"] = SourceExpressionConverter.ConvertToken(dtoRequestV2051SortJsonfurtherSortingProperty);
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (dtoRequestV2051SortJsonreverseOrder != null)
                {
                    if (dtoRequestV2051SortJsonreverseOrder != null)
                    {
                        dtoRequestV2051SortJson["isReverse"] = SourceExpressionConverter.ConvertToken(dtoRequestV2051SortJsonreverseOrder);
                        dtoRequestV2051SortJsonpropCount++;
                    }

                    dtoRequestV2051SortJsonpropCount++;
                }
                else
                {
                    dtoRequestV2051SortJson["isReverse"] = false;
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (dtoRequestV2051SortJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2051SortJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2051SortJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2041Translate> Translate([WorkflowExpression] Func<string> dtoRequestV2041Translatetext, [WorkflowExpression] Func<string> dtoRequestV2041Translateto, [WorkflowExpression] Func<string> dtoRequestV2041Translatefrom = null)
        {
            SourceExpression.Validate(dtoRequestV2041Translatetext, nameof(dtoRequestV2041Translatetext), required: true);
            SourceExpression.Validate(dtoRequestV2041Translateto, nameof(dtoRequestV2041Translateto), required: true);
            SourceExpression.Validate(dtoRequestV2041Translatefrom, nameof(dtoRequestV2041Translatefrom), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2041_Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2041Translate = new JObject();
                var dtoRequestV2041TranslatepropCount = 0;
                dtoRequestV2041TranslatepropCount++;
                dtoRequestV2041Translate["text"] = SourceExpressionConverter.ConvertToken(dtoRequestV2041Translatetext);
                if (dtoRequestV2041Translatefrom != null)
                {
                    dtoRequestV2041Translate["from"] = SourceExpressionConverter.ConvertToken(dtoRequestV2041Translatefrom);
                    dtoRequestV2041TranslatepropCount++;
                }

                dtoRequestV2041TranslatepropCount++;
                dtoRequestV2041Translate["to"] = SourceExpressionConverter.ConvertToken(dtoRequestV2041Translateto);
                if (dtoRequestV2041TranslatepropCount > 0)
                {
                    callPayload.Body = dtoRequestV2041Translate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2041Translate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4052UnProtectPdf> UnProtectPdf([WorkflowExpression] Func<string> dtoRequestFile, [WorkflowExpression] Func<string> dtoRequestownerPassword = null, [WorkflowExpression] Func<bool> dtoRequestremovePermissions = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestFile, nameof(dtoRequestFile), required: true);
            SourceExpression.Validate(dtoRequestownerPassword, nameof(dtoRequestownerPassword), required: false);
            SourceExpression.Validate(dtoRequestremovePermissions, nameof(dtoRequestremovePermissions), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4052_UnProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestFile);
                if (dtoRequestownerPassword != null)
                {
                    dtoRequest["ownerPassword"] = SourceExpressionConverter.ConvertToken(dtoRequestownerPassword);
                    dtoRequestpropCount++;
                }

                if (dtoRequestremovePermissions != null)
                {
                    dtoRequest["removePermissions"] = SourceExpressionConverter.ConvertToken(dtoRequestremovePermissions);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4052UnProtectPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5151UpdateMultipleWordContentControls> UpdateMultipleWordContentControls([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<ContentControl[]> dtoRequestcontentControl, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestcontentControl, nameof(dtoRequestcontentControl), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5151_UpdateMultipleWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["contentControls"] = SourceExpressionConverter.ConvertToken(dtoRequestcontentControl);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5151UpdateMultipleWordContentControls>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5141UpdateWordContentControl> UpdateWordContentControl([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<string> dtoRequestname, [WorkflowExpression] Func<string> dtoRequestvalue = null, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestname, nameof(dtoRequestname), required: true);
            SourceExpression.Validate(dtoRequestvalue, nameof(dtoRequestvalue), required: false);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5141_UpdateWordContentControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["name"] = SourceExpressionConverter.ConvertToken(dtoRequestname);
                if (dtoRequestvalue != null)
                {
                    dtoRequest["value"] = SourceExpressionConverter.ConvertToken(dtoRequestvalue);
                    dtoRequestpropCount++;
                }

                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5141UpdateWordContentControl>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5131UpdateWordTableOfContents> UpdateWordTableOfContents([WorkflowExpression] Func<string> dtoRequestexistingFileContent, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5131_UpdateWordTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = SourceExpressionConverter.ConvertToken(dtoRequestexistingFileContent);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5131UpdateWordTableOfContents>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2032UrlToFile> UrlToFile([WorkflowExpression] Func<string> dtoRequestuRL, [WorkflowExpression] Func<int> dtoRequestreduceResponseSize = null)
        {
            SourceExpression.Validate(dtoRequestuRL, nameof(dtoRequestuRL), required: true);
            SourceExpression.Validate(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2032_UrlToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["url"] = SourceExpressionConverter.ConvertToken(dtoRequestuRL);
                if (dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = SourceExpressionConverter.ConvertToken(dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2032UrlToFile>(BuildSourceInput);
        }
    }

    public class Converterbypower2appsTriggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseV5102AddHtmlToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5032AddImageToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5043AddImageWithinTableToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5053AddTableToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5062AddTextToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV2081CombineCsvs
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoResponseV2091CombineJsonArrays
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV3042CompressImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV4081CompressPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV2071ConvertColor
    {
        [JsonProperty("rgb")]
        public string RGB { get; set; }

        [JsonProperty("hex")]
        public string HEX { get; set; }

        [JsonProperty("cmyk")]
        public string CMYK { get; set; }

        [JsonProperty("hsl")]
        public string HSL { get; set; }

        [JsonProperty("hsv")]
        public string HSV { get; set; }

        [JsonProperty("xyz")]
        public string XYZ { get; set; }

        [JsonProperty("yiq")]
        public string YIQ { get; set; }

        [JsonProperty("yuv")]
        public string YUV { get; set; }

        [JsonProperty("colorName")]
        public string ColorName { get; set; }
    }

    public class DtoResponseV1035ConvertCsvToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("detectedEncoding")]
        public string DetectedEncoding { get; set; }

        [JsonProperty("detectedDelimiter")]
        public string DetectedDelimiter { get; set; }
    }

    public class DtoResponseHtml
    {
        [JsonProperty("html")]
        public string HTMLResponse { get; set; }
    }

    public class DtoResponseV1022ConvertCsvToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV1150ConvertCsvToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV1100ConvertExcelToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }

        [JsonProperty("schema")]
        public string JSONSchemaResponse { get; set; }
    }

    public class DtoResponseV1140ConvertExcelToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV4014ConvertFileToPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV7070ConvertHtmlTableToCsv
    {
        [JsonProperty("firstCsvTable")]
        public string FirstCSVTableResponse { get; set; }

        [JsonProperty("csvTables")]
        public string[] AllCSVTablesResponse { get; set; }
    }

    public class DtoResponseV7082ConvertHtmlTableToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class DtoResponseV7013ConvertHtmlTableToJson
    {
        [JsonProperty("firstTable")]
        public string FirstJSONTableResponse { get; set; }

        [JsonProperty("tables")]
        public string[] AllJSONTablesResponse { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class DtoResponseV7032ConvertHtmlToImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV7090ConvertHtmlToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV7023ConvertHtmlToPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseFile
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileContent")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV1013ConvertJsonToCsv
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoResponseV1064ConvertJsonToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV1090ConvertJsonToTextTable
    {
        [JsonProperty("text")]
        public string TextResponse { get; set; }
    }

    public class DtoResponseV1042ConvertJsonToXml
    {
        [JsonProperty("xml")]
        public string XMLResponse { get; set; }
    }

    public class DtoResponseV1081ConvertJsonToYaml
    {
        [JsonProperty("yaml")]
        public string YAMLResponse { get; set; }
    }

    public class DtoResponseV1110ConvertMultiCsvToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class CsvSheetItem
    {
        [JsonProperty("csv")]
        public string CSV { get; set; }

        [JsonProperty("sheetName")]
        public string Name { get; set; }
    }

    public class DtoResponseV4130ConvertPdfToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV4071ConvertPdfToPdfA
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV6011ConvertSharePointSearchResults
    {
        [JsonProperty("sharePointSearchResults")]
        public SharePointSearchResultResponse[] CodeValue { get; set; }
    }

    public class SharePointSearchResultResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class DtoResponseV5160ConvertWordToHtml
    {
        [JsonProperty("html")]
        public string HTMLResponse { get; set; }
    }

    public class DtoResponseV5170ConvertWordToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV1130ConvertXmlToCsv
    {
        [JsonProperty("csv")]
        public string CSV { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV1120ConvertXmlToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class DtoResponseV1053ConvertXmlToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV8011ConvertXRechnungToPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV1071ConvertYamlToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV3092CreateChartImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV3063CreateCode
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV3112CreateGraphImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV3102CreateTableImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV3082CreateWatermarkImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5012CreateWordFile
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class Section
    {
        [JsonProperty("sectionType")]
        public string Type { get; set; }

        [JsonProperty("sectionContent")]
        public string Text { get; set; }
    }

    public class DtoResponseV4090ExtractImagesFromPdf
    {
        [JsonProperty("images")]
        public DtoResponseV4090ExtractedImageItem[] Images { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class DtoResponseV4090ExtractedImageItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("file")]
        public string FileBytes { get; set; }

        [JsonProperty("fileString")]
        public string FileAsBase64String { get; set; }
    }

    public class DtoResponseV2100ExtractJsonObjectProperties
    {
        [JsonProperty("propertyNames")]
        public string[] PropertyNamesAsList { get; set; }

        [JsonProperty("properties")]
        public JsonPropertyDetail[] PropertiesAsList { get; set; }
    }

    public class JsonPropertyDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class DtoResponseV4061ExtractPdfPages
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV4160ExtractPdfTablesToCsv
    {
        [JsonProperty("firstTable")]
        public string FirstTable { get; set; }

        [JsonProperty("tables")]
        public string[] Tables { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class DtoResponseV4150ExtractPdfTablesToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string Base64String { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class DtoResponseV4170ExtractPdfTablesToHtml
    {
        [JsonProperty("html")]
        public string HTML { get; set; }

        [JsonProperty("firstTable")]
        public string FirstTable { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class DtoResponseV4140ExtractPdfTablesToJson
    {
        [JsonProperty("firstTable")]
        public string FirstTable { get; set; }

        [JsonProperty("tables")]
        public string[] Tables { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class DtoResponseV2140ExtractTextAccordingToPattern
    {
        [JsonProperty("matches")]
        public string[] TextMatchesAsList { get; set; }
    }

    public class DtoResponseV4100ExtractTextFromPdf
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("pages")]
        public DtoResponseV4100PageText[] Pages { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
    }

    public class DtoResponseV4100PageText
    {
        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DtoResponseV5021ExtractWordBookmarks
    {
        [JsonProperty("wordBookmarks")]
        public KeyValPair[] WordBookmarks { get; set; }
    }

    public class KeyValPair
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DtoResponseV5120ExtractWordContentControls
    {
        [JsonProperty("wordControls")]
        public WordControl[] WordContentControls { get; set; }
    }

    public class WordControl
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lock")]
        public string Lock { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DtoResponseV2021IbanData
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("isSepaCountry")]
        public bool IsValidSEPACountry { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("bban")]
        public string BBAN { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("formattedIban")]
        public string FormattedIBAN { get; set; }

        [JsonProperty("unformattedIban")]
        public string UnformattedIBAN { get; set; }

        [JsonProperty("swift_code")]
        public string SWIFTCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bank_city")]
        public string BankCity { get; set; }

        [JsonProperty("bank_zip")]
        public string BankZIP { get; set; }

        [JsonProperty("bank_adress")]
        public string BankAddress { get; set; }
    }

    public class DtoResponseV3071ImageMetaData
    {
        [JsonProperty("imageFormat")]
        public string ImageFormat { get; set; }

        [JsonProperty("imageSize")]
        public double ImageSize { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("orientation")]
        public string Orientation { get; set; }

        [JsonProperty("bits")]
        public int BitsPerPixel { get; set; }

        [JsonProperty("recordingDate")]
        public string DateOfRecording { get; set; }

        [JsonProperty("horizontalResolution")]
        public double HorizontalResolution { get; set; }

        [JsonProperty("verticalResolution")]
        public double VerticalResolution { get; set; }

        [JsonProperty("hasEXIFData")]
        public bool HasEXIFData { get; set; }

        [JsonProperty("exifData")]
        public string EXIFData { get; set; }

        [JsonProperty("hasXMPData")]
        public bool HasXMPData { get; set; }
    }

    public class DtoResponseV5082InsertImageToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5111InsertMultipleTextSectionsToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class InsertSection
    {
        [JsonProperty("placeholderName")]
        public string Name { get; set; }

        [JsonProperty("placeholderText")]
        public string Text { get; set; }
    }

    public class DtoResponseV5092InsertTableToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5072InsertTextToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV4120MergeMultiplePdfs
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class PdfMergeItem
    {
        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class DtoResponseV4022MergePdfs
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV2120MatchPatternCheck
    {
        [JsonProperty("success")]
        public bool MatchSuccess { get; set; }
    }

    public class DtoResponseV4031PdfMetadata
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("creationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("modificationDate")]
        public int ModificationDate { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("pdfVersion")]
        public int PDFVersion { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }
    }

    public class DtoResponseV4042ProtectPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV3051ReadCode
    {
        [JsonProperty("codeValue")]
        public string CodeValue { get; set; }

        [JsonProperty("codeType")]
        public string CodeType { get; set; }
    }

    public class DtoResponseV2011RegularExpression
    {
        [JsonProperty("isMatch")]
        public bool IsMatch { get; set; }

        [JsonProperty("matches")]
        public JToken[] Matches { get; set; }

        [JsonProperty("firstMatch")]
        public JToken FirstMatch { get; set; }

        [JsonProperty("firstMatchValue")]
        public string FirstMatchValue { get; set; }
    }

    public class DtoResponseV4111RemovePagesFromPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV2110ReplaceTextWithPattern
    {
        [JsonProperty("text")]
        public string ReplacedText { get; set; }
    }

    public class DtoResponseV3023ResizeImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV3032RotateImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV2151RunCode
    {
        [JsonProperty("result")]
        public string ResultResponse { get; set; }

        [JsonProperty("error")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }
    }

    public class DtoResponseV2130SmartTextSplit
    {
        [JsonProperty("textSegments")]
        public string[] TextSegmentsAsList { get; set; }
    }

    public class DtoResponseV2061SortCsv
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoResponseV2051SortJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV2041Translate
    {
        [JsonProperty("firstTranslation")]
        public string FirstTranslationResponse { get; set; }

        [JsonProperty("translations")]
        public string[] TranslationsResponse { get; set; }
    }

    public class DtoResponseV4052UnProtectPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5151UpdateMultipleWordContentControls
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ContentControl
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("searchBy")]
        public int SearchBy { get; set; }
    }

    public class DtoResponseV5141UpdateWordContentControl
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV5131UpdateWordTableOfContents
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoResponseV2032UrlToFile
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps;

    public partial class WorkflowManagedActions
    {
        public Converterbypower2appsActions Converterbypower2apps(string connectionId) => new Converterbypower2appsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Converterbypower2appsTriggers Converterbypower2apps(string connectionId) => new Converterbypower2appsTriggers(connectionId);
    }
}