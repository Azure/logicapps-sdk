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
        public IBodyWorkflowAction<DtoResponseV5101AddHtmlToWord> AddHtmlToWord([WorkflowExpression] Func<string> dtoRequestV5101AddHtmlToWordhTML, [WorkflowExpression] Func<string> dtoRequestV5101AddHtmlToWordexistingFileContent = null)
        {
            SourceExpression.Validate(dtoRequestV5101AddHtmlToWordhTML, nameof(dtoRequestV5101AddHtmlToWordhTML), required: true);
            SourceExpression.Validate(dtoRequestV5101AddHtmlToWordexistingFileContent, nameof(dtoRequestV5101AddHtmlToWordexistingFileContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5101_AddHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5101AddHtmlToWord = new JObject();
                var dtoRequestV5101AddHtmlToWordpropCount = 0;
                if (dtoRequestV5101AddHtmlToWordexistingFileContent != null)
                {
                    dtoRequestV5101AddHtmlToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5101AddHtmlToWordexistingFileContent);
                    dtoRequestV5101AddHtmlToWordpropCount++;
                }

                dtoRequestV5101AddHtmlToWordpropCount++;
                dtoRequestV5101AddHtmlToWord["html"] = SourceExpressionConverter.ConvertToken(dtoRequestV5101AddHtmlToWordhTML);
                if (dtoRequestV5101AddHtmlToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5101AddHtmlToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5101AddHtmlToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5031AddImageToWord> AddImageToWord([WorkflowExpression] Func<string> dtoRequestV5031AddImageToWordimage, [WorkflowExpression] Func<string> dtoRequestV5031AddImageToWordexistingFileContent = null, [WorkflowExpression] Func<string> dtoRequestV5031AddImageToWordcaptionText = null, [WorkflowExpression] Func<int> dtoRequestV5031AddImageToWordmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV5031AddImageToWordmaximumImageHeight = null)
        {
            SourceExpression.Validate(dtoRequestV5031AddImageToWordimage, nameof(dtoRequestV5031AddImageToWordimage), required: true);
            SourceExpression.Validate(dtoRequestV5031AddImageToWordexistingFileContent, nameof(dtoRequestV5031AddImageToWordexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestV5031AddImageToWordcaptionText, nameof(dtoRequestV5031AddImageToWordcaptionText), required: false);
            SourceExpression.Validate(dtoRequestV5031AddImageToWordmaximumImageWidth, nameof(dtoRequestV5031AddImageToWordmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestV5031AddImageToWordmaximumImageHeight, nameof(dtoRequestV5031AddImageToWordmaximumImageHeight), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5031_AddImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5031AddImageToWord = new JObject();
                var dtoRequestV5031AddImageToWordpropCount = 0;
                if (dtoRequestV5031AddImageToWordexistingFileContent != null)
                {
                    dtoRequestV5031AddImageToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordexistingFileContent);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                dtoRequestV5031AddImageToWordpropCount++;
                dtoRequestV5031AddImageToWord["image"] = SourceExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordimage);
                if (dtoRequestV5031AddImageToWordcaptionText != null)
                {
                    dtoRequestV5031AddImageToWord["imageText"] = SourceExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordcaptionText);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (dtoRequestV5031AddImageToWordmaximumImageWidth != null)
                {
                    dtoRequestV5031AddImageToWord["maxWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordmaximumImageWidth);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (dtoRequestV5031AddImageToWordmaximumImageHeight != null)
                {
                    dtoRequestV5031AddImageToWord["maxHeight"] = SourceExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordmaximumImageHeight);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (dtoRequestV5031AddImageToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5031AddImageToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5031AddImageToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5042AddImageWithinTableToWord> AddImageWithinTableToWord([WorkflowExpression] Func<string> dtoRequestV5042AddImageWithinTableToWordimage, [WorkflowExpression] Func<string> dtoRequestV5042AddImageWithinTableToWordexistingFileContent = null, [WorkflowExpression] Func<string> dtoRequestV5042AddImageWithinTableToWorddescriptionText = null, [WorkflowExpression] Func<int> dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = null)
        {
            SourceExpression.Validate(dtoRequestV5042AddImageWithinTableToWordimage, nameof(dtoRequestV5042AddImageWithinTableToWordimage), required: true);
            SourceExpression.Validate(dtoRequestV5042AddImageWithinTableToWordexistingFileContent, nameof(dtoRequestV5042AddImageWithinTableToWordexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestV5042AddImageWithinTableToWorddescriptionText, nameof(dtoRequestV5042AddImageWithinTableToWorddescriptionText), required: false);
            SourceExpression.Validate(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth, nameof(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight, nameof(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5042_AddImageWithinTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5042AddImageWithinTableToWord = new JObject();
                var dtoRequestV5042AddImageWithinTableToWordpropCount = 0;
                if (dtoRequestV5042AddImageWithinTableToWordexistingFileContent != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordexistingFileContent);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                dtoRequestV5042AddImageWithinTableToWordpropCount++;
                dtoRequestV5042AddImageWithinTableToWord["image"] = SourceExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordimage);
                if (dtoRequestV5042AddImageWithinTableToWorddescriptionText != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["imageText"] = SourceExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWorddescriptionText);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["maxWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["maxHeight"] = SourceExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (dtoRequestV5042AddImageWithinTableToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5042AddImageWithinTableToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5042AddImageWithinTableToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5052AddTableToWord> AddTableToWord([WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordtableData, [WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordexistingFileContent = null, [WorkflowExpression] Func<bool> dtoRequestV5052AddTableToWordshowHeaders = null, [WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordtableStyle = null, [WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordtableCaption = null)
        {
            SourceExpression.Validate(dtoRequestV5052AddTableToWordtableData, nameof(dtoRequestV5052AddTableToWordtableData), required: true);
            SourceExpression.Validate(dtoRequestV5052AddTableToWordexistingFileContent, nameof(dtoRequestV5052AddTableToWordexistingFileContent), required: false);
            SourceExpression.Validate(dtoRequestV5052AddTableToWordshowHeaders, nameof(dtoRequestV5052AddTableToWordshowHeaders), required: false);
            SourceExpression.Validate(dtoRequestV5052AddTableToWordtableStyle, nameof(dtoRequestV5052AddTableToWordtableStyle), required: false);
            SourceExpression.Validate(dtoRequestV5052AddTableToWordtableCaption, nameof(dtoRequestV5052AddTableToWordtableCaption), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5052_AddTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5052AddTableToWord = new JObject();
                var dtoRequestV5052AddTableToWordpropCount = 0;
                if (dtoRequestV5052AddTableToWordexistingFileContent != null)
                {
                    dtoRequestV5052AddTableToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordexistingFileContent);
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                dtoRequestV5052AddTableToWordpropCount++;
                dtoRequestV5052AddTableToWord["table"] = SourceExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordtableData);
                if (dtoRequestV5052AddTableToWordshowHeaders != null)
                {
                    if (dtoRequestV5052AddTableToWordshowHeaders != null)
                    {
                        dtoRequestV5052AddTableToWord["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordshowHeaders);
                        dtoRequestV5052AddTableToWordpropCount++;
                    }

                    dtoRequestV5052AddTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5052AddTableToWord["hasHeader"] = true;
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                if (dtoRequestV5052AddTableToWordtableStyle != null)
                {
                    if (dtoRequestV5052AddTableToWordtableStyle != null)
                    {
                        dtoRequestV5052AddTableToWord["tableStyle"] = SourceExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordtableStyle);
                        dtoRequestV5052AddTableToWordpropCount++;
                    }

                    dtoRequestV5052AddTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5052AddTableToWord["tableStyle"] = "GridTable1Light";
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                if (dtoRequestV5052AddTableToWordtableCaption != null)
                {
                    dtoRequestV5052AddTableToWord["tableText"] = SourceExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordtableCaption);
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                if (dtoRequestV5052AddTableToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5052AddTableToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5052AddTableToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5061AddTextToWord> AddTextToWord([WorkflowExpression] Func<string> dtoRequestAddTextToWordDatatype, [WorkflowExpression] Func<string> dtoRequestAddTextToWordDatatext, [WorkflowExpression] Func<string> dtoRequestAddTextToWordDataexistingFileContent = null)
        {
            SourceExpression.Validate(dtoRequestAddTextToWordDatatype, nameof(dtoRequestAddTextToWordDatatype), required: true);
            SourceExpression.Validate(dtoRequestAddTextToWordDatatext, nameof(dtoRequestAddTextToWordDatatext), required: true);
            SourceExpression.Validate(dtoRequestAddTextToWordDataexistingFileContent, nameof(dtoRequestAddTextToWordDataexistingFileContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5061_AddTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestAddTextToWordData = new JObject();
                var dtoRequestAddTextToWordDatapropCount = 0;
                if (dtoRequestAddTextToWordDataexistingFileContent != null)
                {
                    dtoRequestAddTextToWordData["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestAddTextToWordDataexistingFileContent);
                    dtoRequestAddTextToWordDatapropCount++;
                }

                dtoRequestAddTextToWordDatapropCount++;
                dtoRequestAddTextToWordData["sectionType"] = SourceExpressionConverter.ConvertToken(dtoRequestAddTextToWordDatatype);
                dtoRequestAddTextToWordDatapropCount++;
                dtoRequestAddTextToWordData["text"] = SourceExpressionConverter.ConvertToken(dtoRequestAddTextToWordDatatext);
                if (dtoRequestAddTextToWordDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestAddTextToWordData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5061AddTextToWord>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV3041CompressImage> CompressImage([WorkflowExpression] Func<string> dtoRequestCompressImageimageFile, [WorkflowExpression] Func<int> dtoRequestCompressImageimageQuality = null)
        {
            SourceExpression.Validate(dtoRequestCompressImageimageFile, nameof(dtoRequestCompressImageimageFile), required: true);
            SourceExpression.Validate(dtoRequestCompressImageimageQuality, nameof(dtoRequestCompressImageimageQuality), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3041_CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestCompressImage = new JObject();
                var dtoRequestCompressImagepropCount = 0;
                dtoRequestCompressImagepropCount++;
                dtoRequestCompressImage["file"] = SourceExpressionConverter.ConvertToken(dtoRequestCompressImageimageFile);
                if (dtoRequestCompressImageimageQuality != null)
                {
                    dtoRequestCompressImage["quality"] = SourceExpressionConverter.ConvertToken(dtoRequestCompressImageimageQuality);
                    dtoRequestCompressImagepropCount++;
                }

                if (dtoRequestCompressImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestCompressImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3041CompressImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4080CompressPdf> CompressPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<bool> dtoRequestcompressImages = null, [WorkflowExpression] Func<int> dtoRequestimageQuality = null, [WorkflowExpression] Func<bool> dtoRequestoptimizeFonts = null, [WorkflowExpression] Func<bool> dtoRequestoptimizePageContents = null, [WorkflowExpression] Func<bool> dtoRequestremoveMetadata = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestcompressImages, nameof(dtoRequestcompressImages), required: false);
            SourceExpression.Validate(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            SourceExpression.Validate(dtoRequestoptimizeFonts, nameof(dtoRequestoptimizeFonts), required: false);
            SourceExpression.Validate(dtoRequestoptimizePageContents, nameof(dtoRequestoptimizePageContents), required: false);
            SourceExpression.Validate(dtoRequestremoveMetadata, nameof(dtoRequestremoveMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4080_CompressPdf";
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

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4080CompressPdf>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV1033ConvertCsvToExcel> ConvertCsvToExcel([WorkflowExpression] Func<string> dtoRequestV1033ConvertCsvToExcelcSV, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV1033ConvertCsvToExcelseparator = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelcSV, nameof(dtoRequestV1033ConvertCsvToExcelcSV), required: true);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders, nameof(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes, nameof(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows, nameof(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows, nameof(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow, nameof(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelseparator, nameof(dtoRequestV1033ConvertCsvToExcelseparator), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter, nameof(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent, nameof(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText, nameof(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth, nameof(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1033_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1033ConvertCsvToExcel = new JObject();
                var dtoRequestV1033ConvertCsvToExcelpropCount = 0;
                dtoRequestV1033ConvertCsvToExcelpropCount++;
                dtoRequestV1033ConvertCsvToExcel["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelcSV);
                if (dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["dataIncludesHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["dataIncludesHeader"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["autoDiscoverFieldTypes"] = false;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["maxScanRows"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["ignoreEmptyLine"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelskipANumberOfRows != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["skip"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelseparator != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelseparator);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["mayHaveQuotedFields"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent != null)
                {
                    if (dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["adjustColumnToContent"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["wrapColumnText"] = false;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1033ConvertCsvToExcel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1033ConvertCsvToExcel>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV4013ConvertFileToPdf> ConvertFileToPdf([WorkflowExpression] Func<string> dtoRequestV4013FileToPdffile, [WorkflowExpression] Func<string> dtoRequestV4013FileToPdforiginFileName = null, [WorkflowExpression] Func<string> dtoRequestV4013FileToPdforiginFileExtension = null, [WorkflowExpression] Func<int> dtoRequestV4013FileToPdfconformanceLevel = null)
        {
            SourceExpression.Validate(dtoRequestV4013FileToPdffile, nameof(dtoRequestV4013FileToPdffile), required: true);
            SourceExpression.Validate(dtoRequestV4013FileToPdforiginFileName, nameof(dtoRequestV4013FileToPdforiginFileName), required: false);
            SourceExpression.Validate(dtoRequestV4013FileToPdforiginFileExtension, nameof(dtoRequestV4013FileToPdforiginFileExtension), required: false);
            SourceExpression.Validate(dtoRequestV4013FileToPdfconformanceLevel, nameof(dtoRequestV4013FileToPdfconformanceLevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4013_ConvertFileToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4013FileToPdf = new JObject();
                var dtoRequestV4013FileToPdfpropCount = 0;
                dtoRequestV4013FileToPdfpropCount++;
                dtoRequestV4013FileToPdf["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV4013FileToPdffile);
                if (dtoRequestV4013FileToPdforiginFileName != null)
                {
                    dtoRequestV4013FileToPdf["fileName"] = SourceExpressionConverter.ConvertToken(dtoRequestV4013FileToPdforiginFileName);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (dtoRequestV4013FileToPdforiginFileExtension != null)
                {
                    dtoRequestV4013FileToPdf["fileExtension"] = SourceExpressionConverter.ConvertToken(dtoRequestV4013FileToPdforiginFileExtension);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (dtoRequestV4013FileToPdfconformanceLevel != null)
                {
                    dtoRequestV4013FileToPdf["conformanceLevel"] = SourceExpressionConverter.ConvertToken(dtoRequestV4013FileToPdfconformanceLevel);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (dtoRequestV4013FileToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV4013FileToPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4013ConvertFileToPdf>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV7080ConvertHtmlTableToExcel> ConvertHtmlTableToExcel([WorkflowExpression] Func<string> dtoRequestV7080ConvertHtmlTableToExcelhTMLTable)
        {
            SourceExpression.Validate(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable, nameof(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7080_ConvertHtmlTableToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7080ConvertHtmlTableToExcel = new JObject();
                var dtoRequestV7080ConvertHtmlTableToExcelpropCount = 0;
                dtoRequestV7080ConvertHtmlTableToExcelpropCount++;
                dtoRequestV7080ConvertHtmlTableToExcel["htmlTable"] = SourceExpressionConverter.ConvertToken(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable);
                if (dtoRequestV7080ConvertHtmlTableToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7080ConvertHtmlTableToExcel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7080ConvertHtmlTableToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7012ConvertHtmlTableToJson> ConvertHtmlTableToJson([WorkflowExpression] Func<string> dtoRequestHtmlToTableDatahTMLTable)
        {
            SourceExpression.Validate(dtoRequestHtmlToTableDatahTMLTable, nameof(dtoRequestHtmlToTableDatahTMLTable), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7012_ConvertHtmlTableToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestHtmlToTableData = new JObject();
                var dtoRequestHtmlToTableDatapropCount = 0;
                dtoRequestHtmlToTableDatapropCount++;
                dtoRequestHtmlToTableData["htmlTable"] = SourceExpressionConverter.ConvertToken(dtoRequestHtmlToTableDatahTMLTable);
                if (dtoRequestHtmlToTableDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestHtmlToTableData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7012ConvertHtmlTableToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7031ConvertHtmlToImage> ConvertHtmlToImage([WorkflowExpression] Func<string> dtoRequestV7031ConvertHtmlToImagehTML, [WorkflowExpression] Func<int> dtoRequestV7031ConvertHtmlToImagewidth = null, [WorkflowExpression] Func<int> dtoRequestV7031ConvertHtmlToImageheight = null)
        {
            SourceExpression.Validate(dtoRequestV7031ConvertHtmlToImagehTML, nameof(dtoRequestV7031ConvertHtmlToImagehTML), required: true);
            SourceExpression.Validate(dtoRequestV7031ConvertHtmlToImagewidth, nameof(dtoRequestV7031ConvertHtmlToImagewidth), required: false);
            SourceExpression.Validate(dtoRequestV7031ConvertHtmlToImageheight, nameof(dtoRequestV7031ConvertHtmlToImageheight), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7031_ConvertHtmlToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7031ConvertHtmlToImage = new JObject();
                var dtoRequestV7031ConvertHtmlToImagepropCount = 0;
                dtoRequestV7031ConvertHtmlToImagepropCount++;
                dtoRequestV7031ConvertHtmlToImage["html"] = SourceExpressionConverter.ConvertToken(dtoRequestV7031ConvertHtmlToImagehTML);
                if (dtoRequestV7031ConvertHtmlToImagewidth != null)
                {
                    dtoRequestV7031ConvertHtmlToImage["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV7031ConvertHtmlToImagewidth);
                    dtoRequestV7031ConvertHtmlToImagepropCount++;
                }

                if (dtoRequestV7031ConvertHtmlToImageheight != null)
                {
                    dtoRequestV7031ConvertHtmlToImage["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV7031ConvertHtmlToImageheight);
                    dtoRequestV7031ConvertHtmlToImagepropCount++;
                }

                if (dtoRequestV7031ConvertHtmlToImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV7031ConvertHtmlToImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7031ConvertHtmlToImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7022ConvertHtmlToPdf> ConvertHtmlToPdf([WorkflowExpression] Func<string> dtoRequestV7022ConvertHtmlToPdfhTML, [WorkflowExpression] Func<bool> dtoRequestV7022ConvertHtmlToPdflandscapeFormat = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdffooterOptions = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfheaderOptions = null, [WorkflowExpression] Func<string> dtoRequestV7022ConvertHtmlToPdfpaperFormat = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdftopMargin = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfbottomMargin = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfleftMargin = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfrightMargin = null, [WorkflowExpression] Func<string> dtoRequestV7022ConvertHtmlToPdfpageRanges = null, [WorkflowExpression] Func<double> dtoRequestV7022ConvertHtmlToPdfscale = null)
        {
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfhTML, nameof(dtoRequestV7022ConvertHtmlToPdfhTML), required: true);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdflandscapeFormat, nameof(dtoRequestV7022ConvertHtmlToPdflandscapeFormat), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent, nameof(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdffooterOptions, nameof(dtoRequestV7022ConvertHtmlToPdffooterOptions), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfheaderOptions, nameof(dtoRequestV7022ConvertHtmlToPdfheaderOptions), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfpaperFormat, nameof(dtoRequestV7022ConvertHtmlToPdfpaperFormat), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdftopMargin, nameof(dtoRequestV7022ConvertHtmlToPdftopMargin), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfbottomMargin, nameof(dtoRequestV7022ConvertHtmlToPdfbottomMargin), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfleftMargin, nameof(dtoRequestV7022ConvertHtmlToPdfleftMargin), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfrightMargin, nameof(dtoRequestV7022ConvertHtmlToPdfrightMargin), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfpageRanges, nameof(dtoRequestV7022ConvertHtmlToPdfpageRanges), required: false);
            SourceExpression.Validate(dtoRequestV7022ConvertHtmlToPdfscale, nameof(dtoRequestV7022ConvertHtmlToPdfscale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V7022_ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7022ConvertHtmlToPdf = new JObject();
                var dtoRequestV7022ConvertHtmlToPdfpropCount = 0;
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
                dtoRequestV7022ConvertHtmlToPdf["html"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfhTML);
                if (dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                {
                    if (dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                    {
                        dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdflandscapeFormat);
                        dtoRequestV7022ConvertHtmlToPdfpropCount++;
                    }

                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }
                else
                {
                    dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = false;
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["imageQuality"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdffooterOptions != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["footerOption"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdffooterOptions);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfheaderOptions != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["headerOption"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfheaderOptions);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfpaperFormat != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["paperFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfpaperFormat);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdftopMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginTop"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdftopMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfbottomMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginBottom"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfbottomMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfleftMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginLeft"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfleftMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfrightMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginRight"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfrightMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfpageRanges != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["pageRanges"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfpageRanges);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfscale != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["scale"] = SourceExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfscale);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7022ConvertHtmlToPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV7022ConvertHtmlToPdf>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV1063ConvertJsonToExcel> ConvertJsonToExcel([WorkflowExpression] Func<string> dtoRequestJsonToExcelDatajSON, [WorkflowExpression] Func<bool> dtoRequestJsonToExcelDataallInOneTable = null, [WorkflowExpression] Func<bool> dtoRequestJsonToExcelDataadjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestJsonToExcelDatawrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestJsonToExcelDatamaxExcelColumnWidth = null)
        {
            SourceExpression.Validate(dtoRequestJsonToExcelDatajSON, nameof(dtoRequestJsonToExcelDatajSON), required: true);
            SourceExpression.Validate(dtoRequestJsonToExcelDataallInOneTable, nameof(dtoRequestJsonToExcelDataallInOneTable), required: false);
            SourceExpression.Validate(dtoRequestJsonToExcelDataadjustExcelColumnToContent, nameof(dtoRequestJsonToExcelDataadjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestJsonToExcelDatawrapExcelColumnText, nameof(dtoRequestJsonToExcelDatawrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestJsonToExcelDatamaxExcelColumnWidth, nameof(dtoRequestJsonToExcelDatamaxExcelColumnWidth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1063_ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestJsonToExcelData = new JObject();
                var dtoRequestJsonToExcelDatapropCount = 0;
                dtoRequestJsonToExcelDatapropCount++;
                dtoRequestJsonToExcelData["json"] = SourceExpressionConverter.ConvertToken(dtoRequestJsonToExcelDatajSON);
                if (dtoRequestJsonToExcelDataallInOneTable != null)
                {
                    if (dtoRequestJsonToExcelDataallInOneTable != null)
                    {
                        dtoRequestJsonToExcelData["allInOneTable"] = SourceExpressionConverter.ConvertToken(dtoRequestJsonToExcelDataallInOneTable);
                        dtoRequestJsonToExcelDatapropCount++;
                    }

                    dtoRequestJsonToExcelDatapropCount++;
                }
                else
                {
                    dtoRequestJsonToExcelData["allInOneTable"] = true;
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (dtoRequestJsonToExcelDataadjustExcelColumnToContent != null)
                {
                    if (dtoRequestJsonToExcelDataadjustExcelColumnToContent != null)
                    {
                        dtoRequestJsonToExcelData["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestJsonToExcelDataadjustExcelColumnToContent);
                        dtoRequestJsonToExcelDatapropCount++;
                    }

                    dtoRequestJsonToExcelDatapropCount++;
                }
                else
                {
                    dtoRequestJsonToExcelData["adjustColumnToContent"] = true;
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (dtoRequestJsonToExcelDatawrapExcelColumnText != null)
                {
                    if (dtoRequestJsonToExcelDatawrapExcelColumnText != null)
                    {
                        dtoRequestJsonToExcelData["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestJsonToExcelDatawrapExcelColumnText);
                        dtoRequestJsonToExcelDatapropCount++;
                    }

                    dtoRequestJsonToExcelDatapropCount++;
                }
                else
                {
                    dtoRequestJsonToExcelData["wrapColumnText"] = false;
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (dtoRequestJsonToExcelDatamaxExcelColumnWidth != null)
                {
                    dtoRequestJsonToExcelData["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestJsonToExcelDatamaxExcelColumnWidth);
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (dtoRequestJsonToExcelDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestJsonToExcelData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1063ConvertJsonToExcel>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV4070ConvertPdfToPdfA> ConvertPdfToPdfA([WorkflowExpression] Func<string> dtoRequestV4070ConvertPdfToPdfApDF, [WorkflowExpression] Func<int> dtoRequestV4070ConvertPdfToPdfAconformanceLevel = null)
        {
            SourceExpression.Validate(dtoRequestV4070ConvertPdfToPdfApDF, nameof(dtoRequestV4070ConvertPdfToPdfApDF), required: true);
            SourceExpression.Validate(dtoRequestV4070ConvertPdfToPdfAconformanceLevel, nameof(dtoRequestV4070ConvertPdfToPdfAconformanceLevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4070_ConvertPdfToPdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4070ConvertPdfToPdfA = new JObject();
                var dtoRequestV4070ConvertPdfToPdfApropCount = 0;
                dtoRequestV4070ConvertPdfToPdfApropCount++;
                dtoRequestV4070ConvertPdfToPdfA["pdf"] = SourceExpressionConverter.ConvertToken(dtoRequestV4070ConvertPdfToPdfApDF);
                if (dtoRequestV4070ConvertPdfToPdfAconformanceLevel != null)
                {
                    dtoRequestV4070ConvertPdfToPdfA["conformanceLevel"] = SourceExpressionConverter.ConvertToken(dtoRequestV4070ConvertPdfToPdfAconformanceLevel);
                    dtoRequestV4070ConvertPdfToPdfApropCount++;
                }

                if (dtoRequestV4070ConvertPdfToPdfApropCount > 0)
                {
                    callPayload.Body = dtoRequestV4070ConvertPdfToPdfA;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4070ConvertPdfToPdfA>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV1052ConvertXmlToJson> ConvertXmlToJson([WorkflowExpression] Func<string> dtoRequestV1052ConvertXmlToJsonxML)
        {
            SourceExpression.Validate(dtoRequestV1052ConvertXmlToJsonxML, nameof(dtoRequestV1052ConvertXmlToJsonxML), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V1052_ConvertXmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1052ConvertXmlToJson = new JObject();
                var dtoRequestV1052ConvertXmlToJsonpropCount = 0;
                dtoRequestV1052ConvertXmlToJsonpropCount++;
                dtoRequestV1052ConvertXmlToJson["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestV1052ConvertXmlToJsonxML);
                if (dtoRequestV1052ConvertXmlToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1052ConvertXmlToJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV1052ConvertXmlToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8010ConvertXRechnungToPdf> ConvertXRechnungToPdf([WorkflowExpression] Func<string> dtoRequestV8010ConvertXRechnungToPdfxRechnung)
        {
            SourceExpression.Validate(dtoRequestV8010ConvertXRechnungToPdfxRechnung, nameof(dtoRequestV8010ConvertXRechnungToPdfxRechnung), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V8010_ConvertXRechnungToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV8010ConvertXRechnungToPdf = new JObject();
                var dtoRequestV8010ConvertXRechnungToPdfpropCount = 0;
                dtoRequestV8010ConvertXRechnungToPdfpropCount++;
                dtoRequestV8010ConvertXRechnungToPdf["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestV8010ConvertXRechnungToPdfxRechnung);
                if (dtoRequestV8010ConvertXRechnungToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV8010ConvertXRechnungToPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV8010ConvertXRechnungToPdf>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV3091CreateChartImage> CreateChartImage([WorkflowExpression] Func<string> dtoRequestV3091CreateChartImagetableData, [WorkflowExpression] Func<int> dtoRequestV3091CreateChartImageimageWidth = null, [WorkflowExpression] Func<int> dtoRequestV3091CreateChartImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3091CreateChartImagebackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestV3091CreateChartImageoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestV3091CreateChartImagechartType = null)
        {
            SourceExpression.Validate(dtoRequestV3091CreateChartImagetableData, nameof(dtoRequestV3091CreateChartImagetableData), required: true);
            SourceExpression.Validate(dtoRequestV3091CreateChartImageimageWidth, nameof(dtoRequestV3091CreateChartImageimageWidth), required: false);
            SourceExpression.Validate(dtoRequestV3091CreateChartImageimageHeight, nameof(dtoRequestV3091CreateChartImageimageHeight), required: false);
            SourceExpression.Validate(dtoRequestV3091CreateChartImagebackgroundColor, nameof(dtoRequestV3091CreateChartImagebackgroundColor), required: false);
            SourceExpression.Validate(dtoRequestV3091CreateChartImageoutputFormat, nameof(dtoRequestV3091CreateChartImageoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestV3091CreateChartImagechartType, nameof(dtoRequestV3091CreateChartImagechartType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3091_CreateChartImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3091CreateChartImage = new JObject();
                var dtoRequestV3091CreateChartImagepropCount = 0;
                if (dtoRequestV3091CreateChartImageimageWidth != null)
                {
                    dtoRequestV3091CreateChartImage["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImageimageWidth);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImageimageHeight != null)
                {
                    dtoRequestV3091CreateChartImage["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImageimageHeight);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImagebackgroundColor != null)
                {
                    dtoRequestV3091CreateChartImage["backgroundColor"] = SourceExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImagebackgroundColor);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImageoutputFormat != null)
                {
                    dtoRequestV3091CreateChartImage["format"] = SourceExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImageoutputFormat);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                dtoRequestV3091CreateChartImagepropCount++;
                dtoRequestV3091CreateChartImage["chart"] = SourceExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImagetableData);
                if (dtoRequestV3091CreateChartImagechartType != null)
                {
                    dtoRequestV3091CreateChartImage["type"] = SourceExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImagechartType);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3091CreateChartImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3091CreateChartImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3062CreateCode> CreateCode([WorkflowExpression] Func<string> dtoRequestV3062CreateCodecontent, [WorkflowExpression] Func<string> dtoRequestV3062CreateCodecodeFormat = null, [WorkflowExpression] Func<int> dtoRequestV3062CreateCodewidth = null, [WorkflowExpression] Func<int> dtoRequestV3062CreateCodeheight = null, [WorkflowExpression] Func<string> dtoRequestV3062CreateCodeoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestV3062CreateCodeembeddedImage = null, [WorkflowExpression] Func<double> dtoRequestV3062CreateCodeembeddedImageOpacity = null, [WorkflowExpression] Func<double> dtoRequestV3062CreateCodeembeddedImageRatio = null)
        {
            SourceExpression.Validate(dtoRequestV3062CreateCodecontent, nameof(dtoRequestV3062CreateCodecontent), required: true);
            SourceExpression.Validate(dtoRequestV3062CreateCodecodeFormat, nameof(dtoRequestV3062CreateCodecodeFormat), required: false);
            SourceExpression.Validate(dtoRequestV3062CreateCodewidth, nameof(dtoRequestV3062CreateCodewidth), required: false);
            SourceExpression.Validate(dtoRequestV3062CreateCodeheight, nameof(dtoRequestV3062CreateCodeheight), required: false);
            SourceExpression.Validate(dtoRequestV3062CreateCodeoutputFormat, nameof(dtoRequestV3062CreateCodeoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestV3062CreateCodeembeddedImage, nameof(dtoRequestV3062CreateCodeembeddedImage), required: false);
            SourceExpression.Validate(dtoRequestV3062CreateCodeembeddedImageOpacity, nameof(dtoRequestV3062CreateCodeembeddedImageOpacity), required: false);
            SourceExpression.Validate(dtoRequestV3062CreateCodeembeddedImageRatio, nameof(dtoRequestV3062CreateCodeembeddedImageRatio), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3062_CreateCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3062CreateCode = new JObject();
                var dtoRequestV3062CreateCodepropCount = 0;
                dtoRequestV3062CreateCodepropCount++;
                dtoRequestV3062CreateCode["content"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodecontent);
                if (dtoRequestV3062CreateCodecodeFormat != null)
                {
                    dtoRequestV3062CreateCode["codeFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodecodeFormat);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodewidth != null)
                {
                    dtoRequestV3062CreateCode["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodewidth);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeheight != null)
                {
                    dtoRequestV3062CreateCode["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeheight);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeoutputFormat != null)
                {
                    dtoRequestV3062CreateCode["outFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeoutputFormat);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeembeddedImage != null)
                {
                    dtoRequestV3062CreateCode["image"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeembeddedImage);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeembeddedImageOpacity != null)
                {
                    dtoRequestV3062CreateCode["imageOpacity"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeembeddedImageOpacity);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeembeddedImageRatio != null)
                {
                    dtoRequestV3062CreateCode["imageRatio"] = SourceExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeembeddedImageRatio);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3062CreateCode;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3062CreateCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3111CreateGraphImage> CreateGraphImage([WorkflowExpression] Func<string> dtoRequestV3111CreateGraphImagegraphData, [WorkflowExpression] Func<int> dtoRequestV3111CreateGraphImageimageWidth = null, [WorkflowExpression] Func<int> dtoRequestV3111CreateGraphImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3111CreateGraphImagebackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestV3111CreateGraphImageoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestV3111CreateGraphImagegraphData, nameof(dtoRequestV3111CreateGraphImagegraphData), required: true);
            SourceExpression.Validate(dtoRequestV3111CreateGraphImageimageWidth, nameof(dtoRequestV3111CreateGraphImageimageWidth), required: false);
            SourceExpression.Validate(dtoRequestV3111CreateGraphImageimageHeight, nameof(dtoRequestV3111CreateGraphImageimageHeight), required: false);
            SourceExpression.Validate(dtoRequestV3111CreateGraphImagebackgroundColor, nameof(dtoRequestV3111CreateGraphImagebackgroundColor), required: false);
            SourceExpression.Validate(dtoRequestV3111CreateGraphImageoutputFormat, nameof(dtoRequestV3111CreateGraphImageoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3111_CreateGraphImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3111CreateGraphImage = new JObject();
                var dtoRequestV3111CreateGraphImagepropCount = 0;
                if (dtoRequestV3111CreateGraphImageimageWidth != null)
                {
                    dtoRequestV3111CreateGraphImage["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImageimageWidth);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (dtoRequestV3111CreateGraphImageimageHeight != null)
                {
                    dtoRequestV3111CreateGraphImage["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImageimageHeight);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (dtoRequestV3111CreateGraphImagebackgroundColor != null)
                {
                    dtoRequestV3111CreateGraphImage["backgroundColor"] = SourceExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImagebackgroundColor);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (dtoRequestV3111CreateGraphImageoutputFormat != null)
                {
                    dtoRequestV3111CreateGraphImage["format"] = SourceExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImageoutputFormat);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                dtoRequestV3111CreateGraphImagepropCount++;
                dtoRequestV3111CreateGraphImage["graph"] = SourceExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImagegraphData);
                if (dtoRequestV3111CreateGraphImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3111CreateGraphImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3111CreateGraphImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3101CreateTableImage> CreateTableImage([WorkflowExpression] Func<string> dtoRequestV3101CreateTableImagetableData, [WorkflowExpression] Func<int> dtoRequestV3101CreateTableImageimageWidth = null, [WorkflowExpression] Func<int> dtoRequestV3101CreateTableImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3101CreateTableImagebackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestV3101CreateTableImageoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestV3101CreateTableImagetitle = null, [WorkflowExpression] Func<bool> dtoRequestV3101CreateTableImageshowTableBorders = null)
        {
            SourceExpression.Validate(dtoRequestV3101CreateTableImagetableData, nameof(dtoRequestV3101CreateTableImagetableData), required: true);
            SourceExpression.Validate(dtoRequestV3101CreateTableImageimageWidth, nameof(dtoRequestV3101CreateTableImageimageWidth), required: false);
            SourceExpression.Validate(dtoRequestV3101CreateTableImageimageHeight, nameof(dtoRequestV3101CreateTableImageimageHeight), required: false);
            SourceExpression.Validate(dtoRequestV3101CreateTableImagebackgroundColor, nameof(dtoRequestV3101CreateTableImagebackgroundColor), required: false);
            SourceExpression.Validate(dtoRequestV3101CreateTableImageoutputFormat, nameof(dtoRequestV3101CreateTableImageoutputFormat), required: false);
            SourceExpression.Validate(dtoRequestV3101CreateTableImagetitle, nameof(dtoRequestV3101CreateTableImagetitle), required: false);
            SourceExpression.Validate(dtoRequestV3101CreateTableImageshowTableBorders, nameof(dtoRequestV3101CreateTableImageshowTableBorders), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3101_CreateTableImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3101CreateTableImage = new JObject();
                var dtoRequestV3101CreateTableImagepropCount = 0;
                if (dtoRequestV3101CreateTableImageimageWidth != null)
                {
                    dtoRequestV3101CreateTableImage["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageimageWidth);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImageimageHeight != null)
                {
                    dtoRequestV3101CreateTableImage["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageimageHeight);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImagebackgroundColor != null)
                {
                    dtoRequestV3101CreateTableImage["backgroundColor"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImagebackgroundColor);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImageoutputFormat != null)
                {
                    dtoRequestV3101CreateTableImage["format"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageoutputFormat);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                dtoRequestV3101CreateTableImagepropCount++;
                dtoRequestV3101CreateTableImage["data"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImagetableData);
                if (dtoRequestV3101CreateTableImagetitle != null)
                {
                    dtoRequestV3101CreateTableImage["title"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImagetitle);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImageshowTableBorders != null)
                {
                    if (dtoRequestV3101CreateTableImageshowTableBorders != null)
                    {
                        dtoRequestV3101CreateTableImage["hasLines"] = SourceExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageshowTableBorders);
                        dtoRequestV3101CreateTableImagepropCount++;
                    }

                    dtoRequestV3101CreateTableImagepropCount++;
                }
                else
                {
                    dtoRequestV3101CreateTableImage["hasLines"] = true;
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3101CreateTableImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3101CreateTableImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3081CreateWatermarkImage> CreateWatermarkImage([WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagemainImage, [WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagewatermarkImage, [WorkflowExpression] Func<int> dtoRequestV3081CreateWatermarkImagewatermarkOpacity = null, [WorkflowExpression] Func<int> dtoRequestV3081CreateWatermarkImagewatermarkRatio = null, [WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = null, [WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = null)
        {
            SourceExpression.Validate(dtoRequestV3081CreateWatermarkImagemainImage, nameof(dtoRequestV3081CreateWatermarkImagemainImage), required: true);
            SourceExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkImage, nameof(dtoRequestV3081CreateWatermarkImagewatermarkImage), required: true);
            SourceExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkOpacity, nameof(dtoRequestV3081CreateWatermarkImagewatermarkOpacity), required: false);
            SourceExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkRatio, nameof(dtoRequestV3081CreateWatermarkImagewatermarkRatio), required: false);
            SourceExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition, nameof(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition), required: false);
            SourceExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition, nameof(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3081_CreateWatermarkImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3081CreateWatermarkImage = new JObject();
                var dtoRequestV3081CreateWatermarkImagepropCount = 0;
                dtoRequestV3081CreateWatermarkImagepropCount++;
                dtoRequestV3081CreateWatermarkImage["image"] = SourceExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagemainImage);
                dtoRequestV3081CreateWatermarkImagepropCount++;
                dtoRequestV3081CreateWatermarkImage["watermarkImage"] = SourceExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkImage);
                if (dtoRequestV3081CreateWatermarkImagewatermarkOpacity != null)
                {
                    dtoRequestV3081CreateWatermarkImage["opacity"] = SourceExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkOpacity);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagewatermarkRatio != null)
                {
                    dtoRequestV3081CreateWatermarkImage["ratio"] = SourceExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkRatio);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition != null)
                {
                    dtoRequestV3081CreateWatermarkImage["imagePositionHorizontal"] = SourceExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition != null)
                {
                    dtoRequestV3081CreateWatermarkImage["imagePositionVertical"] = SourceExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3081CreateWatermarkImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3081CreateWatermarkImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5011CreateWordFile> CreateWordFile([WorkflowExpression] Func<Section[]> dtoRequestV5011CreateWordFilesection, [WorkflowExpression] Func<string> dtoRequestV5011CreateWordFileexistingFileContent = null)
        {
            SourceExpression.Validate(dtoRequestV5011CreateWordFilesection, nameof(dtoRequestV5011CreateWordFilesection), required: true);
            SourceExpression.Validate(dtoRequestV5011CreateWordFileexistingFileContent, nameof(dtoRequestV5011CreateWordFileexistingFileContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5011_CreateWordFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5011CreateWordFile = new JObject();
                var dtoRequestV5011CreateWordFilepropCount = 0;
                if (dtoRequestV5011CreateWordFileexistingFileContent != null)
                {
                    dtoRequestV5011CreateWordFile["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5011CreateWordFileexistingFileContent);
                    dtoRequestV5011CreateWordFilepropCount++;
                }

                dtoRequestV5011CreateWordFilepropCount++;
                dtoRequestV5011CreateWordFile["sections"] = SourceExpressionConverter.ConvertToken(dtoRequestV5011CreateWordFilesection);
                if (dtoRequestV5011CreateWordFilepropCount > 0)
                {
                    callPayload.Body = dtoRequestV5011CreateWordFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5011CreateWordFile>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV4060ExtractPdfPages> ExtractPdfPages([WorkflowExpression] Func<string> dtoRequestV4060ExtractPdfPagespDFFile, [WorkflowExpression] Func<string> dtoRequestV4060ExtractPdfPagespagesToExtract)
        {
            SourceExpression.Validate(dtoRequestV4060ExtractPdfPagespDFFile, nameof(dtoRequestV4060ExtractPdfPagespDFFile), required: true);
            SourceExpression.Validate(dtoRequestV4060ExtractPdfPagespagesToExtract, nameof(dtoRequestV4060ExtractPdfPagespagesToExtract), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4060_ExtractPdfPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4060ExtractPdfPages = new JObject();
                var dtoRequestV4060ExtractPdfPagespropCount = 0;
                dtoRequestV4060ExtractPdfPagespropCount++;
                dtoRequestV4060ExtractPdfPages["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV4060ExtractPdfPagespDFFile);
                dtoRequestV4060ExtractPdfPagespropCount++;
                dtoRequestV4060ExtractPdfPages["pages"] = SourceExpressionConverter.ConvertToken(dtoRequestV4060ExtractPdfPagespagesToExtract);
                if (dtoRequestV4060ExtractPdfPagespropCount > 0)
                {
                    callPayload.Body = dtoRequestV4060ExtractPdfPages;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4060ExtractPdfPages>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> ExtractWordBookmarks([WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarksfile, [WorkflowExpression] Func<bool> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, [WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarkssearchName = null, [WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            SourceExpression.Validate(dtoRequestV5021ExtractWordBookmarksfile, nameof(dtoRequestV5021ExtractWordBookmarksfile), required: true);
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
                dtoRequestV5021ExtractWordBookmarks["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarksfile);
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
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> ExtractWordContentControls([WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlsfile, [WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlssearchTag = null, [WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            SourceExpression.Validate(dtoRequestV5120ExtractWordContentControlsfile, nameof(dtoRequestV5120ExtractWordContentControlsfile), required: true);
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
                dtoRequestV5120ExtractWordContentControls["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlsfile);
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
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToWord([WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordimage, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordplaceholderName = null, [WorkflowExpression] Func<int> dtoRequestV5081InsertImageToWordmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV5081InsertImageToWordmaximumImageHeight = null, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordplaceholderSuffix = null)
        {
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordexistingFileContent, nameof(dtoRequestV5081InsertImageToWordexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordimage, nameof(dtoRequestV5081InsertImageToWordimage), required: true);
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordplaceholderName, nameof(dtoRequestV5081InsertImageToWordplaceholderName), required: false);
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordmaximumImageWidth, nameof(dtoRequestV5081InsertImageToWordmaximumImageWidth), required: false);
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordmaximumImageHeight, nameof(dtoRequestV5081InsertImageToWordmaximumImageHeight), required: false);
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordplaceholderPrefix, nameof(dtoRequestV5081InsertImageToWordplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestV5081InsertImageToWordplaceholderSuffix, nameof(dtoRequestV5081InsertImageToWordplaceholderSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5081_InsertImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5081InsertImageToWord = new JObject();
                var dtoRequestV5081InsertImageToWordpropCount = 0;
                dtoRequestV5081InsertImageToWordpropCount++;
                dtoRequestV5081InsertImageToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordexistingFileContent);
                if (dtoRequestV5081InsertImageToWordplaceholderName != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordplaceholderName);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                dtoRequestV5081InsertImageToWordpropCount++;
                dtoRequestV5081InsertImageToWord["placeholderImage"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordimage);
                if (dtoRequestV5081InsertImageToWordmaximumImageWidth != null)
                {
                    dtoRequestV5081InsertImageToWord["maxWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordmaximumImageWidth);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordmaximumImageHeight != null)
                {
                    dtoRequestV5081InsertImageToWord["maxHeight"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordmaximumImageHeight);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordplaceholderPrefix != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordplaceholderPrefix);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordplaceholderSuffix != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordplaceholderSuffix);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5081InsertImageToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5110InsertMultipleTextSectionsToWord> InsertMultipleTextSectionsToWord([WorkflowExpression] Func<string> dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, [WorkflowExpression] Func<InsertSection[]> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, [WorkflowExpression] Func<string> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = null)
        {
            SourceExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder), required: true);
            SourceExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5110_InsertMultipleTextSectionsToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5110InsertMultipleTextSectionsToWord = new JObject();
                var dtoRequestV5110InsertMultipleTextSectionsToWordpropCount = 0;
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                dtoRequestV5110InsertMultipleTextSectionsToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent);
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                dtoRequestV5110InsertMultipleTextSectionsToWord["insertSections"] = SourceExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder);
                if (dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix != null)
                {
                    dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix);
                    dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                }

                if (dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix != null)
                {
                    dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix);
                    dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                }

                if (dtoRequestV5110InsertMultipleTextSectionsToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5110InsertMultipleTextSectionsToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5110InsertMultipleTextSectionsToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5091InsertTableToWord> InsertTableToWord([WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderName = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderTable = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordtableStyle = null, [WorkflowExpression] Func<bool> dtoRequestV5091InsertTableToWordshowHeaders = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderSuffix = null)
        {
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordexistingFileContent, nameof(dtoRequestV5091InsertTableToWordexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderName, nameof(dtoRequestV5091InsertTableToWordplaceholderName), required: false);
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderTable, nameof(dtoRequestV5091InsertTableToWordplaceholderTable), required: false);
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordtableStyle, nameof(dtoRequestV5091InsertTableToWordtableStyle), required: false);
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordshowHeaders, nameof(dtoRequestV5091InsertTableToWordshowHeaders), required: false);
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderPrefix, nameof(dtoRequestV5091InsertTableToWordplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderSuffix, nameof(dtoRequestV5091InsertTableToWordplaceholderSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5091_InsertTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5091InsertTableToWord = new JObject();
                var dtoRequestV5091InsertTableToWordpropCount = 0;
                dtoRequestV5091InsertTableToWordpropCount++;
                dtoRequestV5091InsertTableToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordexistingFileContent);
                if (dtoRequestV5091InsertTableToWordplaceholderName != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderName);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordplaceholderTable != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderTable"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderTable);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordtableStyle != null)
                {
                    if (dtoRequestV5091InsertTableToWordtableStyle != null)
                    {
                        dtoRequestV5091InsertTableToWord["tableStyle"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordtableStyle);
                        dtoRequestV5091InsertTableToWordpropCount++;
                    }

                    dtoRequestV5091InsertTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5091InsertTableToWord["tableStyle"] = "GridTable1Light";
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordshowHeaders != null)
                {
                    if (dtoRequestV5091InsertTableToWordshowHeaders != null)
                    {
                        dtoRequestV5091InsertTableToWord["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordshowHeaders);
                        dtoRequestV5091InsertTableToWordpropCount++;
                    }

                    dtoRequestV5091InsertTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5091InsertTableToWord["hasHeader"] = true;
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordplaceholderPrefix != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderPrefix);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordplaceholderSuffix != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderSuffix);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5091InsertTableToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5091InsertTableToWord>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV5071InsertTextToWord> InsertTextToWord([WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderName, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderText = null, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderSuffix = null)
        {
            SourceExpression.Validate(dtoRequestV5071InsertTextToWordexistingFileContent, nameof(dtoRequestV5071InsertTextToWordexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderName, nameof(dtoRequestV5071InsertTextToWordplaceholderName), required: true);
            SourceExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderText, nameof(dtoRequestV5071InsertTextToWordplaceholderText), required: false);
            SourceExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderPrefix, nameof(dtoRequestV5071InsertTextToWordplaceholderPrefix), required: false);
            SourceExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderSuffix, nameof(dtoRequestV5071InsertTextToWordplaceholderSuffix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5071_InsertTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5071InsertTextToWord = new JObject();
                var dtoRequestV5071InsertTextToWordpropCount = 0;
                dtoRequestV5071InsertTextToWordpropCount++;
                dtoRequestV5071InsertTextToWord["existingFileContent"] = SourceExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordexistingFileContent);
                dtoRequestV5071InsertTextToWordpropCount++;
                dtoRequestV5071InsertTextToWord["placeholderName"] = SourceExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderName);
                if (dtoRequestV5071InsertTextToWordplaceholderText != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderText"] = SourceExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderText);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (dtoRequestV5071InsertTextToWordplaceholderPrefix != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderPrefix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderPrefix);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (dtoRequestV5071InsertTextToWordplaceholderSuffix != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderSuffix"] = SourceExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderSuffix);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (dtoRequestV5071InsertTextToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5071InsertTextToWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5071InsertTextToWord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4021MergePdfs> MergePdfs([WorkflowExpression] Func<string> dtoRequestV4021MergePdfsfile1, [WorkflowExpression] Func<string> dtoRequestV4021MergePdfsfile2)
        {
            SourceExpression.Validate(dtoRequestV4021MergePdfsfile1, nameof(dtoRequestV4021MergePdfsfile1), required: true);
            SourceExpression.Validate(dtoRequestV4021MergePdfsfile2, nameof(dtoRequestV4021MergePdfsfile2), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4021_MergePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4021MergePdfs = new JObject();
                var dtoRequestV4021MergePdfspropCount = 0;
                dtoRequestV4021MergePdfspropCount++;
                dtoRequestV4021MergePdfs["file1"] = SourceExpressionConverter.ConvertToken(dtoRequestV4021MergePdfsfile1);
                dtoRequestV4021MergePdfspropCount++;
                dtoRequestV4021MergePdfs["file2"] = SourceExpressionConverter.ConvertToken(dtoRequestV4021MergePdfsfile2);
                if (dtoRequestV4021MergePdfspropCount > 0)
                {
                    callPayload.Body = dtoRequestV4021MergePdfs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4021MergePdfs>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> PdfMetadata([WorkflowExpression] Func<string> dtoRequestV4031PdfMetadatafile)
        {
            SourceExpression.Validate(dtoRequestV4031PdfMetadatafile, nameof(dtoRequestV4031PdfMetadatafile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4031_PdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4031PdfMetadata = new JObject();
                var dtoRequestV4031PdfMetadatapropCount = 0;
                dtoRequestV4031PdfMetadatapropCount++;
                dtoRequestV4031PdfMetadata["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV4031PdfMetadatafile);
                if (dtoRequestV4031PdfMetadatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV4031PdfMetadata;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4041ProtectPdf> ProtectPdf([WorkflowExpression] Func<string> dtoRequestV4041ProtectPdffile, [WorkflowExpression] Func<string> dtoRequestV4041ProtectPdfownerPassword = null, [WorkflowExpression] Func<string> dtoRequestV4041ProtectPdfuserPassword = null)
        {
            SourceExpression.Validate(dtoRequestV4041ProtectPdffile, nameof(dtoRequestV4041ProtectPdffile), required: true);
            SourceExpression.Validate(dtoRequestV4041ProtectPdfownerPassword, nameof(dtoRequestV4041ProtectPdfownerPassword), required: false);
            SourceExpression.Validate(dtoRequestV4041ProtectPdfuserPassword, nameof(dtoRequestV4041ProtectPdfuserPassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4041_ProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4041ProtectPdf = new JObject();
                var dtoRequestV4041ProtectPdfpropCount = 0;
                dtoRequestV4041ProtectPdfpropCount++;
                dtoRequestV4041ProtectPdf["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV4041ProtectPdffile);
                if (dtoRequestV4041ProtectPdfownerPassword != null)
                {
                    dtoRequestV4041ProtectPdf["ownerPassword"] = SourceExpressionConverter.ConvertToken(dtoRequestV4041ProtectPdfownerPassword);
                    dtoRequestV4041ProtectPdfpropCount++;
                }

                if (dtoRequestV4041ProtectPdfuserPassword != null)
                {
                    dtoRequestV4041ProtectPdf["userPassword"] = SourceExpressionConverter.ConvertToken(dtoRequestV4041ProtectPdfuserPassword);
                    dtoRequestV4041ProtectPdfpropCount++;
                }

                if (dtoRequestV4041ProtectPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV4041ProtectPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4041ProtectPdf>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV4110RemovePagesFromPdf> RemovePagesFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<string> dtoRequestpages, [WorkflowExpression] Func<bool> dtoRequestinputIs1Based = null, [WorkflowExpression] Func<int> dtoRequestmode = null, [WorkflowExpression] Func<bool> dtoRequestfailIfPageOutOfRange = null)
        {
            SourceExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            SourceExpression.Validate(dtoRequestpages, nameof(dtoRequestpages), required: true);
            SourceExpression.Validate(dtoRequestinputIs1Based, nameof(dtoRequestinputIs1Based), required: false);
            SourceExpression.Validate(dtoRequestmode, nameof(dtoRequestmode), required: false);
            SourceExpression.Validate(dtoRequestfailIfPageOutOfRange, nameof(dtoRequestfailIfPageOutOfRange), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4110_RemovePagesFromPdf";
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

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4110RemovePagesFromPdf>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV3022ResizeImage> ResizeImage([WorkflowExpression] Func<string> dtoRequestV3022ResizeImageimageFile, [WorkflowExpression] Func<double> dtoRequestV3022ResizeImageimageWidth = null, [WorkflowExpression] Func<double> dtoRequestV3022ResizeImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3022ResizeImageresizeBy = null)
        {
            SourceExpression.Validate(dtoRequestV3022ResizeImageimageFile, nameof(dtoRequestV3022ResizeImageimageFile), required: true);
            SourceExpression.Validate(dtoRequestV3022ResizeImageimageWidth, nameof(dtoRequestV3022ResizeImageimageWidth), required: false);
            SourceExpression.Validate(dtoRequestV3022ResizeImageimageHeight, nameof(dtoRequestV3022ResizeImageimageHeight), required: false);
            SourceExpression.Validate(dtoRequestV3022ResizeImageresizeBy, nameof(dtoRequestV3022ResizeImageresizeBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3022_ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3022ResizeImage = new JObject();
                var dtoRequestV3022ResizeImagepropCount = 0;
                dtoRequestV3022ResizeImagepropCount++;
                dtoRequestV3022ResizeImage["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageimageFile);
                if (dtoRequestV3022ResizeImageimageWidth != null)
                {
                    dtoRequestV3022ResizeImage["width"] = SourceExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageimageWidth);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (dtoRequestV3022ResizeImageimageHeight != null)
                {
                    dtoRequestV3022ResizeImage["height"] = SourceExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageimageHeight);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (dtoRequestV3022ResizeImageresizeBy != null)
                {
                    dtoRequestV3022ResizeImage["resizeBy"] = SourceExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageresizeBy);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (dtoRequestV3022ResizeImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3022ResizeImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3022ResizeImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3031RotateImage> RotateImage([WorkflowExpression] Func<string> dtoRequestV3031RotateImageimageFile, [WorkflowExpression] Func<double> dtoRequestV3031RotateImagerotate = null, [WorkflowExpression] Func<string> dtoRequestV3031RotateImageoutputFormat = null)
        {
            SourceExpression.Validate(dtoRequestV3031RotateImageimageFile, nameof(dtoRequestV3031RotateImageimageFile), required: true);
            SourceExpression.Validate(dtoRequestV3031RotateImagerotate, nameof(dtoRequestV3031RotateImagerotate), required: false);
            SourceExpression.Validate(dtoRequestV3031RotateImageoutputFormat, nameof(dtoRequestV3031RotateImageoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V3031_RotateImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3031RotateImage = new JObject();
                var dtoRequestV3031RotateImagepropCount = 0;
                dtoRequestV3031RotateImagepropCount++;
                dtoRequestV3031RotateImage["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV3031RotateImageimageFile);
                if (dtoRequestV3031RotateImagerotate != null)
                {
                    dtoRequestV3031RotateImage["rotate"] = SourceExpressionConverter.ConvertToken(dtoRequestV3031RotateImagerotate);
                    dtoRequestV3031RotateImagepropCount++;
                }

                if (dtoRequestV3031RotateImageoutputFormat != null)
                {
                    dtoRequestV3031RotateImage["outFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestV3031RotateImageoutputFormat);
                    dtoRequestV3031RotateImagepropCount++;
                }

                if (dtoRequestV3031RotateImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3031RotateImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV3031RotateImage>(BuildSourceInput);
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
        public IBodyWorkflowAction<DtoResponseV4051UnProtectPdf> UnProtectPdf([WorkflowExpression] Func<string> dtoRequestV4051UnProtectPdffile, [WorkflowExpression] Func<string> dtoRequestV4051UnProtectPdfownerPassword = null, [WorkflowExpression] Func<bool> dtoRequestV4051UnProtectPdfremovePermissions = null)
        {
            SourceExpression.Validate(dtoRequestV4051UnProtectPdffile, nameof(dtoRequestV4051UnProtectPdffile), required: true);
            SourceExpression.Validate(dtoRequestV4051UnProtectPdfownerPassword, nameof(dtoRequestV4051UnProtectPdfownerPassword), required: false);
            SourceExpression.Validate(dtoRequestV4051UnProtectPdfremovePermissions, nameof(dtoRequestV4051UnProtectPdfremovePermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V4051_UnProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4051UnProtectPdf = new JObject();
                var dtoRequestV4051UnProtectPdfpropCount = 0;
                dtoRequestV4051UnProtectPdfpropCount++;
                dtoRequestV4051UnProtectPdf["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV4051UnProtectPdffile);
                if (dtoRequestV4051UnProtectPdfownerPassword != null)
                {
                    dtoRequestV4051UnProtectPdf["ownerPassword"] = SourceExpressionConverter.ConvertToken(dtoRequestV4051UnProtectPdfownerPassword);
                    dtoRequestV4051UnProtectPdfpropCount++;
                }

                if (dtoRequestV4051UnProtectPdfremovePermissions != null)
                {
                    dtoRequestV4051UnProtectPdf["removePermissions"] = SourceExpressionConverter.ConvertToken(dtoRequestV4051UnProtectPdfremovePermissions);
                    dtoRequestV4051UnProtectPdfpropCount++;
                }

                if (dtoRequestV4051UnProtectPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV4051UnProtectPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV4051UnProtectPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> UpdateMultipleWordContentControls([WorkflowExpression] Func<string> dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, [WorkflowExpression] Func<ContentControl[]> dtoRequestV5150UpdateMultipleWordContentControlscontentControl)
        {
            SourceExpression.Validate(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, nameof(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV5150UpdateMultipleWordContentControlscontentControl, nameof(dtoRequestV5150UpdateMultipleWordContentControlscontentControl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5150_UpdateMultipleWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5150UpdateMultipleWordContentControls = new JObject();
                var dtoRequestV5150UpdateMultipleWordContentControlspropCount = 0;
                dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
                dtoRequestV5150UpdateMultipleWordContentControls["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent);
                dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
                dtoRequestV5150UpdateMultipleWordContentControls["contentControls"] = SourceExpressionConverter.ConvertToken(dtoRequestV5150UpdateMultipleWordContentControlscontentControl);
                if (dtoRequestV5150UpdateMultipleWordContentControlspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5150UpdateMultipleWordContentControls;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> UpdateWordContentControl([WorkflowExpression] Func<string> dtoRequestV5140UpdateWordContentControlexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5140UpdateWordContentControlname, [WorkflowExpression] Func<string> dtoRequestV5140UpdateWordContentControlvalue = null)
        {
            SourceExpression.Validate(dtoRequestV5140UpdateWordContentControlexistingFileContent, nameof(dtoRequestV5140UpdateWordContentControlexistingFileContent), required: true);
            SourceExpression.Validate(dtoRequestV5140UpdateWordContentControlname, nameof(dtoRequestV5140UpdateWordContentControlname), required: true);
            SourceExpression.Validate(dtoRequestV5140UpdateWordContentControlvalue, nameof(dtoRequestV5140UpdateWordContentControlvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5140_UpdateWordContentControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5140UpdateWordContentControl = new JObject();
                var dtoRequestV5140UpdateWordContentControlpropCount = 0;
                dtoRequestV5140UpdateWordContentControlpropCount++;
                dtoRequestV5140UpdateWordContentControl["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5140UpdateWordContentControlexistingFileContent);
                dtoRequestV5140UpdateWordContentControlpropCount++;
                dtoRequestV5140UpdateWordContentControl["name"] = SourceExpressionConverter.ConvertToken(dtoRequestV5140UpdateWordContentControlname);
                if (dtoRequestV5140UpdateWordContentControlvalue != null)
                {
                    dtoRequestV5140UpdateWordContentControl["value"] = SourceExpressionConverter.ConvertToken(dtoRequestV5140UpdateWordContentControlvalue);
                    dtoRequestV5140UpdateWordContentControlpropCount++;
                }

                if (dtoRequestV5140UpdateWordContentControlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5140UpdateWordContentControl;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseFile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5130UpdateWordTableOfContents> UpdateWordTableOfContents([WorkflowExpression] Func<string> dtoRequestV5130UpdateWordTableOfContentsexistingFileContent)
        {
            SourceExpression.Validate(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent, nameof(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V5130_UpdateWordTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5130UpdateWordTableOfContents = new JObject();
                var dtoRequestV5130UpdateWordTableOfContentspropCount = 0;
                dtoRequestV5130UpdateWordTableOfContentspropCount++;
                dtoRequestV5130UpdateWordTableOfContents["file"] = SourceExpressionConverter.ConvertToken(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent);
                if (dtoRequestV5130UpdateWordTableOfContentspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5130UpdateWordTableOfContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV5130UpdateWordTableOfContents>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2031UrlToFile> UrlToFile([WorkflowExpression] Func<string> dtoRequestV2031UrlToFileuRL)
        {
            SourceExpression.Validate(dtoRequestV2031UrlToFileuRL, nameof(dtoRequestV2031UrlToFileuRL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/V2031_UrlToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2031UrlToFile = new JObject();
                var dtoRequestV2031UrlToFilepropCount = 0;
                dtoRequestV2031UrlToFilepropCount++;
                dtoRequestV2031UrlToFile["url"] = SourceExpressionConverter.ConvertToken(dtoRequestV2031UrlToFileuRL);
                if (dtoRequestV2031UrlToFilepropCount > 0)
                {
                    callPayload.Body = dtoRequestV2031UrlToFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseV2031UrlToFile>(BuildSourceInput);
        }
    }

    public class Converterbypower2appsTriggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseV5101AddHtmlToWord
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

    public class DtoResponseV5031AddImageToWord
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

    public class DtoResponseV5042AddImageWithinTableToWord
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

    public class DtoResponseV5052AddTableToWord
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

    public class DtoResponseV5061AddTextToWord
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

    public class DtoResponseV3041CompressImage
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

    public class DtoResponseV4080CompressPdf
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

    public class DtoResponseV1033ConvertCsvToExcel
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

    public class DtoResponseV1100ConvertExcelToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }

        [JsonProperty("schema")]
        public string JSONSchemaResponse { get; set; }
    }

    public class DtoResponseV4013ConvertFileToPdf
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

    public class DtoResponseV7080ConvertHtmlTableToExcel
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

    public class DtoResponseV7012ConvertHtmlTableToJson
    {
        [JsonProperty("firstTable")]
        public string FirstJSONTableResponse { get; set; }

        [JsonProperty("tables")]
        public string[] AllJSONTablesResponse { get; set; }
    }

    public class DtoResponseV7031ConvertHtmlToImage
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

    public class DtoResponseV7022ConvertHtmlToPdf
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

    public class DtoResponseV1063ConvertJsonToExcel
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

    public class DtoResponseV4070ConvertPdfToPdfA
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

    public class DtoResponseV1052ConvertXmlToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV8010ConvertXRechnungToPdf
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

    public class DtoResponseV3091CreateChartImage
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

    public class DtoResponseV3062CreateCode
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

    public class DtoResponseV3111CreateGraphImage
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

    public class DtoResponseV3101CreateTableImage
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

    public class DtoResponseV3081CreateWatermarkImage
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

    public class DtoResponseV5011CreateWordFile
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

    public class DtoResponseV4060ExtractPdfPages
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

    public class DtoResponseV5110InsertMultipleTextSectionsToWord
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

    public class DtoResponseV5091InsertTableToWord
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

    public class DtoResponseV5071InsertTextToWord
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

    public class DtoResponseV4021MergePdfs
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

    public class DtoResponseV4041ProtectPdf
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

    public class DtoResponseV4110RemovePagesFromPdf
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

    public class DtoResponseV3022ResizeImage
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

    public class DtoResponseV3031RotateImage
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

    public class DtoResponseV4051UnProtectPdf
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

    public class DtoResponseV5130UpdateWordTableOfContents
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

    public class DtoResponseV2031UrlToFile
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