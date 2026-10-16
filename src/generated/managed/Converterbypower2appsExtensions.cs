//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Converterbypower2appsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5101AddHtmlToWord> AddHtmlToWord(Expression<Func<string>> dtoRequestV5101AddHtmlToWordhTML, Expression<Func<string>> dtoRequestV5101AddHtmlToWordexistingFileContent = null)
        {
            var __workflow_dtoRequestV5101AddHtmlToWordhTML = WorkflowExpression.Compile(dtoRequestV5101AddHtmlToWordhTML, nameof(dtoRequestV5101AddHtmlToWordhTML), required: true);
            var __workflow_dtoRequestV5101AddHtmlToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5101AddHtmlToWordexistingFileContent, nameof(dtoRequestV5101AddHtmlToWordexistingFileContent), required: false);
            return new DeferredBodyAction<DtoResponseV5101AddHtmlToWord>(() =>
            {
                var apiCallPath = "/V5101_AddHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5101AddHtmlToWord = new JObject();
                var dtoRequestV5101AddHtmlToWordpropCount = 0;
                if (__workflow_dtoRequestV5101AddHtmlToWordexistingFileContent != null)
                {
                    dtoRequestV5101AddHtmlToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5101AddHtmlToWordexistingFileContent);
                    dtoRequestV5101AddHtmlToWordpropCount++;
                }

                dtoRequestV5101AddHtmlToWordpropCount++;
                dtoRequestV5101AddHtmlToWord["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5101AddHtmlToWordhTML);
                if (dtoRequestV5101AddHtmlToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5101AddHtmlToWord;
                }

                return new ApiConnectionAction<DtoResponseV5101AddHtmlToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5031AddImageToWord> AddImageToWord(Expression<Func<string>> dtoRequestV5031AddImageToWordimage, Expression<Func<string>> dtoRequestV5031AddImageToWordexistingFileContent = null, Expression<Func<string>> dtoRequestV5031AddImageToWordcaptionText = null, Expression<Func<int>> dtoRequestV5031AddImageToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5031AddImageToWordmaximumImageHeight = null)
        {
            var __workflow_dtoRequestV5031AddImageToWordimage = WorkflowExpression.Compile(dtoRequestV5031AddImageToWordimage, nameof(dtoRequestV5031AddImageToWordimage), required: true);
            var __workflow_dtoRequestV5031AddImageToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5031AddImageToWordexistingFileContent, nameof(dtoRequestV5031AddImageToWordexistingFileContent), required: false);
            var __workflow_dtoRequestV5031AddImageToWordcaptionText = WorkflowExpression.Compile(dtoRequestV5031AddImageToWordcaptionText, nameof(dtoRequestV5031AddImageToWordcaptionText), required: false);
            var __workflow_dtoRequestV5031AddImageToWordmaximumImageWidth = WorkflowExpression.Compile(dtoRequestV5031AddImageToWordmaximumImageWidth, nameof(dtoRequestV5031AddImageToWordmaximumImageWidth), required: false);
            var __workflow_dtoRequestV5031AddImageToWordmaximumImageHeight = WorkflowExpression.Compile(dtoRequestV5031AddImageToWordmaximumImageHeight, nameof(dtoRequestV5031AddImageToWordmaximumImageHeight), required: false);
            return new DeferredBodyAction<DtoResponseV5031AddImageToWord>(() =>
            {
                var apiCallPath = "/V5031_AddImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5031AddImageToWord = new JObject();
                var dtoRequestV5031AddImageToWordpropCount = 0;
                if (__workflow_dtoRequestV5031AddImageToWordexistingFileContent != null)
                {
                    dtoRequestV5031AddImageToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5031AddImageToWordexistingFileContent);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                dtoRequestV5031AddImageToWordpropCount++;
                dtoRequestV5031AddImageToWord["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5031AddImageToWordimage);
                if (__workflow_dtoRequestV5031AddImageToWordcaptionText != null)
                {
                    dtoRequestV5031AddImageToWord["imageText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5031AddImageToWordcaptionText);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (__workflow_dtoRequestV5031AddImageToWordmaximumImageWidth != null)
                {
                    dtoRequestV5031AddImageToWord["maxWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5031AddImageToWordmaximumImageWidth);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (__workflow_dtoRequestV5031AddImageToWordmaximumImageHeight != null)
                {
                    dtoRequestV5031AddImageToWord["maxHeight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5031AddImageToWordmaximumImageHeight);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (dtoRequestV5031AddImageToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5031AddImageToWord;
                }

                return new ApiConnectionAction<DtoResponseV5031AddImageToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5042AddImageWithinTableToWord> AddImageWithinTableToWord(Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWordimage, Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWordexistingFileContent = null, Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWorddescriptionText = null, Expression<Func<int>> dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = null)
        {
            var __workflow_dtoRequestV5042AddImageWithinTableToWordimage = WorkflowExpression.Compile(dtoRequestV5042AddImageWithinTableToWordimage, nameof(dtoRequestV5042AddImageWithinTableToWordimage), required: true);
            var __workflow_dtoRequestV5042AddImageWithinTableToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5042AddImageWithinTableToWordexistingFileContent, nameof(dtoRequestV5042AddImageWithinTableToWordexistingFileContent), required: false);
            var __workflow_dtoRequestV5042AddImageWithinTableToWorddescriptionText = WorkflowExpression.Compile(dtoRequestV5042AddImageWithinTableToWorddescriptionText, nameof(dtoRequestV5042AddImageWithinTableToWorddescriptionText), required: false);
            var __workflow_dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = WorkflowExpression.Compile(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth, nameof(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth), required: false);
            var __workflow_dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = WorkflowExpression.Compile(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight, nameof(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight), required: false);
            return new DeferredBodyAction<DtoResponseV5042AddImageWithinTableToWord>(() =>
            {
                var apiCallPath = "/V5042_AddImageWithinTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5042AddImageWithinTableToWord = new JObject();
                var dtoRequestV5042AddImageWithinTableToWordpropCount = 0;
                if (__workflow_dtoRequestV5042AddImageWithinTableToWordexistingFileContent != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5042AddImageWithinTableToWordexistingFileContent);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                dtoRequestV5042AddImageWithinTableToWordpropCount++;
                dtoRequestV5042AddImageWithinTableToWord["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5042AddImageWithinTableToWordimage);
                if (__workflow_dtoRequestV5042AddImageWithinTableToWorddescriptionText != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["imageText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5042AddImageWithinTableToWorddescriptionText);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["maxWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["maxHeight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (dtoRequestV5042AddImageWithinTableToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5042AddImageWithinTableToWord;
                }

                return new ApiConnectionAction<DtoResponseV5042AddImageWithinTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5052AddTableToWord> AddTableToWord(Expression<Func<string>> dtoRequestV5052AddTableToWordtableData, Expression<Func<string>> dtoRequestV5052AddTableToWordexistingFileContent = null, Expression<Func<bool>> dtoRequestV5052AddTableToWordshowHeaders = null, Expression<Func<string>> dtoRequestV5052AddTableToWordtableStyle = null, Expression<Func<string>> dtoRequestV5052AddTableToWordtableCaption = null)
        {
            var __workflow_dtoRequestV5052AddTableToWordtableData = WorkflowExpression.Compile(dtoRequestV5052AddTableToWordtableData, nameof(dtoRequestV5052AddTableToWordtableData), required: true);
            var __workflow_dtoRequestV5052AddTableToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5052AddTableToWordexistingFileContent, nameof(dtoRequestV5052AddTableToWordexistingFileContent), required: false);
            var __workflow_dtoRequestV5052AddTableToWordshowHeaders = WorkflowExpression.Compile(dtoRequestV5052AddTableToWordshowHeaders, nameof(dtoRequestV5052AddTableToWordshowHeaders), required: false);
            var __workflow_dtoRequestV5052AddTableToWordtableStyle = WorkflowExpression.Compile(dtoRequestV5052AddTableToWordtableStyle, nameof(dtoRequestV5052AddTableToWordtableStyle), required: false);
            var __workflow_dtoRequestV5052AddTableToWordtableCaption = WorkflowExpression.Compile(dtoRequestV5052AddTableToWordtableCaption, nameof(dtoRequestV5052AddTableToWordtableCaption), required: false);
            return new DeferredBodyAction<DtoResponseV5052AddTableToWord>(() =>
            {
                var apiCallPath = "/V5052_AddTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5052AddTableToWord = new JObject();
                var dtoRequestV5052AddTableToWordpropCount = 0;
                if (__workflow_dtoRequestV5052AddTableToWordexistingFileContent != null)
                {
                    dtoRequestV5052AddTableToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5052AddTableToWordexistingFileContent);
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                dtoRequestV5052AddTableToWordpropCount++;
                dtoRequestV5052AddTableToWord["table"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5052AddTableToWordtableData);
                if (__workflow_dtoRequestV5052AddTableToWordshowHeaders != null)
                {
                    if (__workflow_dtoRequestV5052AddTableToWordshowHeaders != null)
                    {
                        dtoRequestV5052AddTableToWord["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5052AddTableToWordshowHeaders);
                        dtoRequestV5052AddTableToWordpropCount++;
                    }

                    dtoRequestV5052AddTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5052AddTableToWord["hasHeader"] = true;
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5052AddTableToWordtableStyle != null)
                {
                    if (__workflow_dtoRequestV5052AddTableToWordtableStyle != null)
                    {
                        dtoRequestV5052AddTableToWord["tableStyle"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5052AddTableToWordtableStyle);
                        dtoRequestV5052AddTableToWordpropCount++;
                    }

                    dtoRequestV5052AddTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5052AddTableToWord["tableStyle"] = "GridTable1Light";
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5052AddTableToWordtableCaption != null)
                {
                    dtoRequestV5052AddTableToWord["tableText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5052AddTableToWordtableCaption);
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                if (dtoRequestV5052AddTableToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5052AddTableToWord;
                }

                return new ApiConnectionAction<DtoResponseV5052AddTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5061AddTextToWord> AddTextToWord(Expression<Func<string>> dtoRequestAddTextToWordDatatype, Expression<Func<string>> dtoRequestAddTextToWordDatatext, Expression<Func<string>> dtoRequestAddTextToWordDataexistingFileContent = null)
        {
            var __workflow_dtoRequestAddTextToWordDatatype = WorkflowExpression.Compile(dtoRequestAddTextToWordDatatype, nameof(dtoRequestAddTextToWordDatatype), required: true);
            var __workflow_dtoRequestAddTextToWordDatatext = WorkflowExpression.Compile(dtoRequestAddTextToWordDatatext, nameof(dtoRequestAddTextToWordDatatext), required: true);
            var __workflow_dtoRequestAddTextToWordDataexistingFileContent = WorkflowExpression.Compile(dtoRequestAddTextToWordDataexistingFileContent, nameof(dtoRequestAddTextToWordDataexistingFileContent), required: false);
            return new DeferredBodyAction<DtoResponseV5061AddTextToWord>(() =>
            {
                var apiCallPath = "/V5061_AddTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestAddTextToWordData = new JObject();
                var dtoRequestAddTextToWordDatapropCount = 0;
                if (__workflow_dtoRequestAddTextToWordDataexistingFileContent != null)
                {
                    dtoRequestAddTextToWordData["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestAddTextToWordDataexistingFileContent);
                    dtoRequestAddTextToWordDatapropCount++;
                }

                dtoRequestAddTextToWordDatapropCount++;
                dtoRequestAddTextToWordData["sectionType"] = ExpressionConverter.ConvertO(__workflow_dtoRequestAddTextToWordDatatype);
                dtoRequestAddTextToWordDatapropCount++;
                dtoRequestAddTextToWordData["text"] = ExpressionConverter.ConvertO(__workflow_dtoRequestAddTextToWordDatatext);
                if (dtoRequestAddTextToWordDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestAddTextToWordData;
                }

                return new ApiConnectionAction<DtoResponseV5061AddTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs> CombineCsvs(Expression<Func<string>> dtoRequestV2081CombineCsvsmainCSV, Expression<Func<string>> dtoRequestV2081CombineCsvscombineColumnName, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSV, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSVColumn = null)
        {
            var __workflow_dtoRequestV2081CombineCsvsmainCSV = WorkflowExpression.Compile(dtoRequestV2081CombineCsvsmainCSV, nameof(dtoRequestV2081CombineCsvsmainCSV), required: true);
            var __workflow_dtoRequestV2081CombineCsvscombineColumnName = WorkflowExpression.Compile(dtoRequestV2081CombineCsvscombineColumnName, nameof(dtoRequestV2081CombineCsvscombineColumnName), required: true);
            var __workflow_dtoRequestV2081CombineCsvssecondCSV = WorkflowExpression.Compile(dtoRequestV2081CombineCsvssecondCSV, nameof(dtoRequestV2081CombineCsvssecondCSV), required: true);
            var __workflow_dtoRequestV2081CombineCsvssecondCSVColumn = WorkflowExpression.Compile(dtoRequestV2081CombineCsvssecondCSVColumn, nameof(dtoRequestV2081CombineCsvssecondCSVColumn), required: false);
            return new DeferredBodyAction<DtoResponseV2081CombineCsvs>(() =>
            {
                var apiCallPath = "/V2081_CombineCsvs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2081CombineCsvs = new JObject();
                var dtoRequestV2081CombineCsvspropCount = 0;
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["mainCsv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2081CombineCsvsmainCSV);
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["mainCsvColumn"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2081CombineCsvscombineColumnName);
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["secondCsv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2081CombineCsvssecondCSV);
                if (__workflow_dtoRequestV2081CombineCsvssecondCSVColumn != null)
                {
                    dtoRequestV2081CombineCsvs["secondCsvColumn"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2081CombineCsvssecondCSVColumn);
                    dtoRequestV2081CombineCsvspropCount++;
                }

                if (dtoRequestV2081CombineCsvspropCount > 0)
                {
                    callPayload.Body = dtoRequestV2081CombineCsvs;
                }

                return new ApiConnectionAction<DtoResponseV2081CombineCsvs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays> CombineJsonArrays(Expression<Func<string>> dtoRequestV2091CombineJsonArraysmainJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayscombinePropertyName, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
        {
            var __workflow_dtoRequestV2091CombineJsonArraysmainJSON = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArraysmainJSON, nameof(dtoRequestV2091CombineJsonArraysmainJSON), required: true);
            var __workflow_dtoRequestV2091CombineJsonArrayscombinePropertyName = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrayscombinePropertyName, nameof(dtoRequestV2091CombineJsonArrayscombinePropertyName), required: true);
            var __workflow_dtoRequestV2091CombineJsonArrayssecondJSON = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrayssecondJSON, nameof(dtoRequestV2091CombineJsonArrayssecondJSON), required: true);
            var __workflow_dtoRequestV2091CombineJsonArrayssecondJSONProperty = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrayssecondJSONProperty, nameof(dtoRequestV2091CombineJsonArrayssecondJSONProperty), required: false);
            return new DeferredBodyAction<DtoResponseV2091CombineJsonArrays>(() =>
            {
                var apiCallPath = "/V2091_CombineJsonArrays";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2091CombineJsonArrays = new JObject();
                var dtoRequestV2091CombineJsonArrayspropCount = 0;
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["mainJson"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2091CombineJsonArraysmainJSON);
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["mainJsonProperty"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2091CombineJsonArrayscombinePropertyName);
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["secondJson"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2091CombineJsonArrayssecondJSON);
                if (__workflow_dtoRequestV2091CombineJsonArrayssecondJSONProperty != null)
                {
                    dtoRequestV2091CombineJsonArrays["secondJsonProperty"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2091CombineJsonArrayssecondJSONProperty);
                    dtoRequestV2091CombineJsonArrayspropCount++;
                }

                if (dtoRequestV2091CombineJsonArrayspropCount > 0)
                {
                    callPayload.Body = dtoRequestV2091CombineJsonArrays;
                }

                return new ApiConnectionAction<DtoResponseV2091CombineJsonArrays>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3041CompressImage> CompressImage(Expression<Func<string>> dtoRequestCompressImageimageFile, Expression<Func<int>> dtoRequestCompressImageimageQuality = null)
        {
            var __workflow_dtoRequestCompressImageimageFile = WorkflowExpression.Compile(dtoRequestCompressImageimageFile, nameof(dtoRequestCompressImageimageFile), required: true);
            var __workflow_dtoRequestCompressImageimageQuality = WorkflowExpression.Compile(dtoRequestCompressImageimageQuality, nameof(dtoRequestCompressImageimageQuality), required: false);
            return new DeferredBodyAction<DtoResponseV3041CompressImage>(() =>
            {
                var apiCallPath = "/V3041_CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestCompressImage = new JObject();
                var dtoRequestCompressImagepropCount = 0;
                dtoRequestCompressImagepropCount++;
                dtoRequestCompressImage["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestCompressImageimageFile);
                if (__workflow_dtoRequestCompressImageimageQuality != null)
                {
                    dtoRequestCompressImage["quality"] = ExpressionConverter.ConvertO(__workflow_dtoRequestCompressImageimageQuality);
                    dtoRequestCompressImagepropCount++;
                }

                if (dtoRequestCompressImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestCompressImage;
                }

                return new ApiConnectionAction<DtoResponseV3041CompressImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4080CompressPdf> CompressPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<bool>> dtoRequestcompressImages = null, Expression<Func<int>> dtoRequestimageQuality = null, Expression<Func<bool>> dtoRequestoptimizeFonts = null, Expression<Func<bool>> dtoRequestoptimizePageContents = null, Expression<Func<bool>> dtoRequestremoveMetadata = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestcompressImages = WorkflowExpression.Compile(dtoRequestcompressImages, nameof(dtoRequestcompressImages), required: false);
            var __workflow_dtoRequestimageQuality = WorkflowExpression.Compile(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            var __workflow_dtoRequestoptimizeFonts = WorkflowExpression.Compile(dtoRequestoptimizeFonts, nameof(dtoRequestoptimizeFonts), required: false);
            var __workflow_dtoRequestoptimizePageContents = WorkflowExpression.Compile(dtoRequestoptimizePageContents, nameof(dtoRequestoptimizePageContents), required: false);
            var __workflow_dtoRequestremoveMetadata = WorkflowExpression.Compile(dtoRequestremoveMetadata, nameof(dtoRequestremoveMetadata), required: false);
            return new DeferredBodyAction<DtoResponseV4080CompressPdf>(() =>
            {
                var apiCallPath = "/V4080_CompressPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDF);
                if (__workflow_dtoRequestcompressImages != null)
                {
                    dtoRequest["compressImages"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcompressImages);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestimageQuality != null)
                {
                    dtoRequest["imageQuality"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageQuality);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoptimizeFonts != null)
                {
                    dtoRequest["optimizeFont"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoptimizeFonts);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoptimizePageContents != null)
                {
                    dtoRequest["optimizePageContents"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoptimizePageContents);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestremoveMetadata != null)
                {
                    dtoRequest["removeMetadata"] = ExpressionConverter.ConvertO(__workflow_dtoRequestremoveMetadata);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4080CompressPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor> ConvertColor(Expression<Func<string>> dtoRequestV2071ConvertColorcolor)
        {
            var __workflow_dtoRequestV2071ConvertColorcolor = WorkflowExpression.Compile(dtoRequestV2071ConvertColorcolor, nameof(dtoRequestV2071ConvertColorcolor), required: true);
            return new DeferredBodyAction<DtoResponseV2071ConvertColor>(() =>
            {
                var apiCallPath = "/V2071_ConvertColor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2071ConvertColor = new JObject();
                var dtoRequestV2071ConvertColorpropCount = 0;
                dtoRequestV2071ConvertColorpropCount++;
                dtoRequestV2071ConvertColor["color"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2071ConvertColorcolor);
                if (dtoRequestV2071ConvertColorpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2071ConvertColor;
                }

                return new ApiConnectionAction<DtoResponseV2071ConvertColor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1033ConvertCsvToExcel> ConvertCsvToExcel(Expression<Func<string>> dtoRequestV1033ConvertCsvToExcelcSV, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1033ConvertCsvToExcelseparator = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            var __workflow_dtoRequestV1033ConvertCsvToExcelcSV = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelcSV, nameof(dtoRequestV1033ConvertCsvToExcelcSV), required: true);
            var __workflow_dtoRequestV1033ConvertCsvToExcelcSVHasHeaders = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders, nameof(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes, nameof(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelremoveEmptyRows = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows, nameof(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelskipANumberOfRows = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows, nameof(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow, nameof(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelseparator = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelseparator, nameof(dtoRequestV1033ConvertCsvToExcelseparator), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter, nameof(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent, nameof(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText, nameof(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText), required: false);
            var __workflow_dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth, nameof(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth), required: false);
            return new DeferredBodyAction<DtoResponseV1033ConvertCsvToExcel>(() =>
            {
                var apiCallPath = "/V1033_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1033ConvertCsvToExcel = new JObject();
                var dtoRequestV1033ConvertCsvToExcelpropCount = 0;
                dtoRequestV1033ConvertCsvToExcelpropCount++;
                dtoRequestV1033ConvertCsvToExcel["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelcSV);
                if (__workflow_dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelcSVHasHeaders);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["dataIncludesHeader"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["autoDiscoverFieldTypes"] = false;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["maxScanRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelremoveEmptyRows);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["ignoreEmptyLine"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelskipANumberOfRows != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["skip"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelskipANumberOfRows);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelseparator != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelseparator);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["mayHaveQuotedFields"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["adjustColumnToContent"] = true;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText);
                        dtoRequestV1033ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestV1033ConvertCsvToExcel["wrapColumnText"] = false;
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1033ConvertCsvToExcel;
                }

                return new ApiConnectionAction<DtoResponseV1033ConvertCsvToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertCsvToHtmlTable(Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTablecSV, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
        {
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTablecSV = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTablecSV, nameof(dtoRequestV7061ConvertCsvToHtmlTablecSV), required: true);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders, nameof(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes, nameof(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection, nameof(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows, nameof(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows, nameof(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow, nameof(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTableseparator = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTableseparator, nameof(dtoRequestV7061ConvertCsvToHtmlTableseparator), required: false);
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter, nameof(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter), required: false);
            return new DeferredBodyAction<DtoResponseHtml>(() =>
            {
                var apiCallPath = "/V7061_ConvertCsvToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7061ConvertCsvToHtmlTable = new JObject();
                var dtoRequestV7061ConvertCsvToHtmlTablepropCount = 0;
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                dtoRequestV7061ConvertCsvToHtmlTable["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTablecSV);
                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = true;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = false;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["maxScanRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows);
                        dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                    }

                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }
                else
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = true;
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["skip"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableseparator != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTableseparator);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter);
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

                return new ApiConnectionAction<DtoResponseHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson> ConvertCsvToJson(Expression<Func<string>> dtoRequestV1022ConvertCsvToJsoncSV, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1022ConvertCsvToJsonseparator = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
        {
            var __workflow_dtoRequestV1022ConvertCsvToJsoncSV = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsoncSV, nameof(dtoRequestV1022ConvertCsvToJsoncSV), required: true);
            var __workflow_dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders, nameof(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes, nameof(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows, nameof(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows, nameof(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow, nameof(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonseparator = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonseparator, nameof(dtoRequestV1022ConvertCsvToJsonseparator), required: false);
            var __workflow_dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter, nameof(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter), required: false);
            return new DeferredBodyAction<DtoResponseV1022ConvertCsvToJson>(() =>
            {
                var apiCallPath = "/V1022_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1022ConvertCsvToJson = new JObject();
                var dtoRequestV1022ConvertCsvToJsonpropCount = 0;
                dtoRequestV1022ConvertCsvToJsonpropCount++;
                dtoRequestV1022ConvertCsvToJson["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsoncSV);
                if (__workflow_dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsoncSVHasHeaders);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = true;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = false;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV1022ConvertCsvToJson["maxScanRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonremoveEmptyRows);
                        dtoRequestV1022ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = true;
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonskipANumberOfRows != null)
                {
                    dtoRequestV1022ConvertCsvToJson["skip"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonskipANumberOfRows);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow != null)
                {
                    dtoRequestV1022ConvertCsvToJson["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonseparator != null)
                {
                    dtoRequestV1022ConvertCsvToJson["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonseparator);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter);
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

                return new ApiConnectionAction<DtoResponseV1022ConvertCsvToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson> ConvertExcelToJson(Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonexcelFile, Expression<Func<bool>> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonstartCell = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonsheetName = null)
        {
            var __workflow_dtoRequestV1100ConvertExcelToJsonexcelFile = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonexcelFile, nameof(dtoRequestV1100ConvertExcelToJsonexcelFile), required: true);
            var __workflow_dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders, nameof(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders), required: false);
            var __workflow_dtoRequestV1100ConvertExcelToJsonstartCell = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonstartCell, nameof(dtoRequestV1100ConvertExcelToJsonstartCell), required: false);
            var __workflow_dtoRequestV1100ConvertExcelToJsonsheetName = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonsheetName, nameof(dtoRequestV1100ConvertExcelToJsonsheetName), required: false);
            return new DeferredBodyAction<DtoResponseV1100ConvertExcelToJson>(() =>
            {
                var apiCallPath = "/V1100_ConvertExcelToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1100ConvertExcelToJson = new JObject();
                var dtoRequestV1100ConvertExcelToJsonpropCount = 0;
                dtoRequestV1100ConvertExcelToJsonpropCount++;
                dtoRequestV1100ConvertExcelToJson["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1100ConvertExcelToJsonexcelFile);
                if (__workflow_dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                {
                    if (__workflow_dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                    {
                        dtoRequestV1100ConvertExcelToJson["hasHeaders"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1100ConvertExcelToJsonexcelHasHeaders);
                        dtoRequestV1100ConvertExcelToJsonpropCount++;
                    }

                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }
                else
                {
                    dtoRequestV1100ConvertExcelToJson["hasHeaders"] = true;
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1100ConvertExcelToJsonstartCell != null)
                {
                    dtoRequestV1100ConvertExcelToJson["startCell"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1100ConvertExcelToJsonstartCell);
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (__workflow_dtoRequestV1100ConvertExcelToJsonsheetName != null)
                {
                    dtoRequestV1100ConvertExcelToJson["sheetName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1100ConvertExcelToJsonsheetName);
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (dtoRequestV1100ConvertExcelToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1100ConvertExcelToJson;
                }

                return new ApiConnectionAction<DtoResponseV1100ConvertExcelToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4013ConvertFileToPdf> ConvertFileToPdf(Expression<Func<string>> dtoRequestV4013FileToPdffile, Expression<Func<string>> dtoRequestV4013FileToPdforiginFileName = null, Expression<Func<string>> dtoRequestV4013FileToPdforiginFileExtension = null, Expression<Func<int>> dtoRequestV4013FileToPdfconformanceLevel = null)
        {
            var __workflow_dtoRequestV4013FileToPdffile = WorkflowExpression.Compile(dtoRequestV4013FileToPdffile, nameof(dtoRequestV4013FileToPdffile), required: true);
            var __workflow_dtoRequestV4013FileToPdforiginFileName = WorkflowExpression.Compile(dtoRequestV4013FileToPdforiginFileName, nameof(dtoRequestV4013FileToPdforiginFileName), required: false);
            var __workflow_dtoRequestV4013FileToPdforiginFileExtension = WorkflowExpression.Compile(dtoRequestV4013FileToPdforiginFileExtension, nameof(dtoRequestV4013FileToPdforiginFileExtension), required: false);
            var __workflow_dtoRequestV4013FileToPdfconformanceLevel = WorkflowExpression.Compile(dtoRequestV4013FileToPdfconformanceLevel, nameof(dtoRequestV4013FileToPdfconformanceLevel), required: false);
            return new DeferredBodyAction<DtoResponseV4013ConvertFileToPdf>(() =>
            {
                var apiCallPath = "/V4013_ConvertFileToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4013FileToPdf = new JObject();
                var dtoRequestV4013FileToPdfpropCount = 0;
                dtoRequestV4013FileToPdfpropCount++;
                dtoRequestV4013FileToPdf["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4013FileToPdffile);
                if (__workflow_dtoRequestV4013FileToPdforiginFileName != null)
                {
                    dtoRequestV4013FileToPdf["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4013FileToPdforiginFileName);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (__workflow_dtoRequestV4013FileToPdforiginFileExtension != null)
                {
                    dtoRequestV4013FileToPdf["fileExtension"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4013FileToPdforiginFileExtension);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (__workflow_dtoRequestV4013FileToPdfconformanceLevel != null)
                {
                    dtoRequestV4013FileToPdf["conformanceLevel"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4013FileToPdfconformanceLevel);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (dtoRequestV4013FileToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV4013FileToPdf;
                }

                return new ApiConnectionAction<DtoResponseV4013ConvertFileToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv> ConvertHtmlTableToCsv(Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
        {
            var __workflow_dtoRequestV7070ConvertHtmlTableToCsvhTMLTable = WorkflowExpression.Compile(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, nameof(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable), required: true);
            var __workflow_dtoRequestV7070ConvertHtmlTableToCsvseparator = WorkflowExpression.Compile(dtoRequestV7070ConvertHtmlTableToCsvseparator, nameof(dtoRequestV7070ConvertHtmlTableToCsvseparator), required: false);
            return new DeferredBodyAction<DtoResponseV7070ConvertHtmlTableToCsv>(() =>
            {
                var apiCallPath = "/V7070_ConvertHtmlTableToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7070ConvertHtmlTableToCsv = new JObject();
                var dtoRequestV7070ConvertHtmlTableToCsvpropCount = 0;
                dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
                dtoRequestV7070ConvertHtmlTableToCsv["htmlTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7070ConvertHtmlTableToCsvhTMLTable);
                if (__workflow_dtoRequestV7070ConvertHtmlTableToCsvseparator != null)
                {
                    dtoRequestV7070ConvertHtmlTableToCsv["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7070ConvertHtmlTableToCsvseparator);
                    dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
                }

                if (dtoRequestV7070ConvertHtmlTableToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7070ConvertHtmlTableToCsv;
                }

                return new ApiConnectionAction<DtoResponseV7070ConvertHtmlTableToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7080ConvertHtmlTableToExcel> ConvertHtmlTableToExcel(Expression<Func<string>> dtoRequestV7080ConvertHtmlTableToExcelhTMLTable)
        {
            var __workflow_dtoRequestV7080ConvertHtmlTableToExcelhTMLTable = WorkflowExpression.Compile(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable, nameof(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable), required: true);
            return new DeferredBodyAction<DtoResponseV7080ConvertHtmlTableToExcel>(() =>
            {
                var apiCallPath = "/V7080_ConvertHtmlTableToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7080ConvertHtmlTableToExcel = new JObject();
                var dtoRequestV7080ConvertHtmlTableToExcelpropCount = 0;
                dtoRequestV7080ConvertHtmlTableToExcelpropCount++;
                dtoRequestV7080ConvertHtmlTableToExcel["htmlTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7080ConvertHtmlTableToExcelhTMLTable);
                if (dtoRequestV7080ConvertHtmlTableToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7080ConvertHtmlTableToExcel;
                }

                return new ApiConnectionAction<DtoResponseV7080ConvertHtmlTableToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7012ConvertHtmlTableToJson> ConvertHtmlTableToJson(Expression<Func<string>> dtoRequestHtmlToTableDatahTMLTable)
        {
            var __workflow_dtoRequestHtmlToTableDatahTMLTable = WorkflowExpression.Compile(dtoRequestHtmlToTableDatahTMLTable, nameof(dtoRequestHtmlToTableDatahTMLTable), required: true);
            return new DeferredBodyAction<DtoResponseV7012ConvertHtmlTableToJson>(() =>
            {
                var apiCallPath = "/V7012_ConvertHtmlTableToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestHtmlToTableData = new JObject();
                var dtoRequestHtmlToTableDatapropCount = 0;
                dtoRequestHtmlToTableDatapropCount++;
                dtoRequestHtmlToTableData["htmlTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestHtmlToTableDatahTMLTable);
                if (dtoRequestHtmlToTableDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestHtmlToTableData;
                }

                return new ApiConnectionAction<DtoResponseV7012ConvertHtmlTableToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7031ConvertHtmlToImage> ConvertHtmlToImage(Expression<Func<string>> dtoRequestV7031ConvertHtmlToImagehTML, Expression<Func<int>> dtoRequestV7031ConvertHtmlToImagewidth = null, Expression<Func<int>> dtoRequestV7031ConvertHtmlToImageheight = null)
        {
            var __workflow_dtoRequestV7031ConvertHtmlToImagehTML = WorkflowExpression.Compile(dtoRequestV7031ConvertHtmlToImagehTML, nameof(dtoRequestV7031ConvertHtmlToImagehTML), required: true);
            var __workflow_dtoRequestV7031ConvertHtmlToImagewidth = WorkflowExpression.Compile(dtoRequestV7031ConvertHtmlToImagewidth, nameof(dtoRequestV7031ConvertHtmlToImagewidth), required: false);
            var __workflow_dtoRequestV7031ConvertHtmlToImageheight = WorkflowExpression.Compile(dtoRequestV7031ConvertHtmlToImageheight, nameof(dtoRequestV7031ConvertHtmlToImageheight), required: false);
            return new DeferredBodyAction<DtoResponseV7031ConvertHtmlToImage>(() =>
            {
                var apiCallPath = "/V7031_ConvertHtmlToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7031ConvertHtmlToImage = new JObject();
                var dtoRequestV7031ConvertHtmlToImagepropCount = 0;
                dtoRequestV7031ConvertHtmlToImagepropCount++;
                dtoRequestV7031ConvertHtmlToImage["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7031ConvertHtmlToImagehTML);
                if (__workflow_dtoRequestV7031ConvertHtmlToImagewidth != null)
                {
                    dtoRequestV7031ConvertHtmlToImage["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7031ConvertHtmlToImagewidth);
                    dtoRequestV7031ConvertHtmlToImagepropCount++;
                }

                if (__workflow_dtoRequestV7031ConvertHtmlToImageheight != null)
                {
                    dtoRequestV7031ConvertHtmlToImage["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7031ConvertHtmlToImageheight);
                    dtoRequestV7031ConvertHtmlToImagepropCount++;
                }

                if (dtoRequestV7031ConvertHtmlToImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV7031ConvertHtmlToImage;
                }

                return new ApiConnectionAction<DtoResponseV7031ConvertHtmlToImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7022ConvertHtmlToPdf> ConvertHtmlToPdf(Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfhTML, Expression<Func<bool>> dtoRequestV7022ConvertHtmlToPdflandscapeFormat = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdffooterOptions = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfheaderOptions = null, Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfpaperFormat = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdftopMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfbottomMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfleftMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfrightMargin = null, Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfpageRanges = null, Expression<Func<double>> dtoRequestV7022ConvertHtmlToPdfscale = null)
        {
            var __workflow_dtoRequestV7022ConvertHtmlToPdfhTML = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfhTML, nameof(dtoRequestV7022ConvertHtmlToPdfhTML), required: true);
            var __workflow_dtoRequestV7022ConvertHtmlToPdflandscapeFormat = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdflandscapeFormat, nameof(dtoRequestV7022ConvertHtmlToPdflandscapeFormat), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent, nameof(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdffooterOptions = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdffooterOptions, nameof(dtoRequestV7022ConvertHtmlToPdffooterOptions), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfheaderOptions = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfheaderOptions, nameof(dtoRequestV7022ConvertHtmlToPdfheaderOptions), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfpaperFormat = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfpaperFormat, nameof(dtoRequestV7022ConvertHtmlToPdfpaperFormat), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdftopMargin = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdftopMargin, nameof(dtoRequestV7022ConvertHtmlToPdftopMargin), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfbottomMargin = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfbottomMargin, nameof(dtoRequestV7022ConvertHtmlToPdfbottomMargin), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfleftMargin = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfleftMargin, nameof(dtoRequestV7022ConvertHtmlToPdfleftMargin), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfrightMargin = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfrightMargin, nameof(dtoRequestV7022ConvertHtmlToPdfrightMargin), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfpageRanges = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfpageRanges, nameof(dtoRequestV7022ConvertHtmlToPdfpageRanges), required: false);
            var __workflow_dtoRequestV7022ConvertHtmlToPdfscale = WorkflowExpression.Compile(dtoRequestV7022ConvertHtmlToPdfscale, nameof(dtoRequestV7022ConvertHtmlToPdfscale), required: false);
            return new DeferredBodyAction<DtoResponseV7022ConvertHtmlToPdf>(() =>
            {
                var apiCallPath = "/V7022_ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7022ConvertHtmlToPdf = new JObject();
                var dtoRequestV7022ConvertHtmlToPdfpropCount = 0;
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
                dtoRequestV7022ConvertHtmlToPdf["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfhTML);
                if (__workflow_dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                {
                    if (__workflow_dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                    {
                        dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdflandscapeFormat);
                        dtoRequestV7022ConvertHtmlToPdfpropCount++;
                    }

                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }
                else
                {
                    dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = false;
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["imageQuality"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdffooterOptions != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["footerOption"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdffooterOptions);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfheaderOptions != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["headerOption"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfheaderOptions);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfpaperFormat != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["paperFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfpaperFormat);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdftopMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginTop"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdftopMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfbottomMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginBottom"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfbottomMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfleftMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginLeft"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfleftMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfrightMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginRight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfrightMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfpageRanges != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["pageRanges"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfpageRanges);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (__workflow_dtoRequestV7022ConvertHtmlToPdfscale != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["scale"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7022ConvertHtmlToPdfscale);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7022ConvertHtmlToPdf;
                }

                return new ApiConnectionAction<DtoResponseV7022ConvertHtmlToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> ConvertHtmlToWord(Expression<Func<string>> dtoRequestV7041ConvertHtmlToWordhTML)
        {
            var __workflow_dtoRequestV7041ConvertHtmlToWordhTML = WorkflowExpression.Compile(dtoRequestV7041ConvertHtmlToWordhTML, nameof(dtoRequestV7041ConvertHtmlToWordhTML), required: true);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V7041_ConvertHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7041ConvertHtmlToWord = new JObject();
                var dtoRequestV7041ConvertHtmlToWordpropCount = 0;
                dtoRequestV7041ConvertHtmlToWordpropCount++;
                dtoRequestV7041ConvertHtmlToWord["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7041ConvertHtmlToWordhTML);
                if (dtoRequestV7041ConvertHtmlToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7041ConvertHtmlToWord;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> ConvertImage(Expression<Func<string>> dtoRequestV3012ConvertImageimageFile, Expression<Func<string>> dtoRequestV3012ConvertImageoutputFormat = null)
        {
            var __workflow_dtoRequestV3012ConvertImageimageFile = WorkflowExpression.Compile(dtoRequestV3012ConvertImageimageFile, nameof(dtoRequestV3012ConvertImageimageFile), required: true);
            var __workflow_dtoRequestV3012ConvertImageoutputFormat = WorkflowExpression.Compile(dtoRequestV3012ConvertImageoutputFormat, nameof(dtoRequestV3012ConvertImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V3012_ConvertImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3012ConvertImage = new JObject();
                var dtoRequestV3012ConvertImagepropCount = 0;
                dtoRequestV3012ConvertImagepropCount++;
                dtoRequestV3012ConvertImage["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3012ConvertImageimageFile);
                if (__workflow_dtoRequestV3012ConvertImageoutputFormat != null)
                {
                    if (__workflow_dtoRequestV3012ConvertImageoutputFormat != null)
                    {
                        dtoRequestV3012ConvertImage["outFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3012ConvertImageoutputFormat);
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

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv> ConvertJsonToCsv(Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvjSON, Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvseparator = null)
        {
            var __workflow_dtoRequestV1013ConvertJsonToCsvjSON = WorkflowExpression.Compile(dtoRequestV1013ConvertJsonToCsvjSON, nameof(dtoRequestV1013ConvertJsonToCsvjSON), required: true);
            var __workflow_dtoRequestV1013ConvertJsonToCsvseparator = WorkflowExpression.Compile(dtoRequestV1013ConvertJsonToCsvseparator, nameof(dtoRequestV1013ConvertJsonToCsvseparator), required: false);
            return new DeferredBodyAction<DtoResponseV1013ConvertJsonToCsv>(() =>
            {
                var apiCallPath = "/V1013_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1013ConvertJsonToCsv = new JObject();
                var dtoRequestV1013ConvertJsonToCsvpropCount = 0;
                dtoRequestV1013ConvertJsonToCsvpropCount++;
                dtoRequestV1013ConvertJsonToCsv["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1013ConvertJsonToCsvjSON);
                if (__workflow_dtoRequestV1013ConvertJsonToCsvseparator != null)
                {
                    dtoRequestV1013ConvertJsonToCsv["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1013ConvertJsonToCsvseparator);
                    dtoRequestV1013ConvertJsonToCsvpropCount++;
                }

                if (dtoRequestV1013ConvertJsonToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1013ConvertJsonToCsv;
                }

                return new ApiConnectionAction<DtoResponseV1013ConvertJsonToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1063ConvertJsonToExcel> ConvertJsonToExcel(Expression<Func<string>> dtoRequestJsonToExcelDatajSON, Expression<Func<bool>> dtoRequestJsonToExcelDataallInOneTable = null, Expression<Func<bool>> dtoRequestJsonToExcelDataadjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestJsonToExcelDatawrapExcelColumnText = null, Expression<Func<int>> dtoRequestJsonToExcelDatamaxExcelColumnWidth = null)
        {
            var __workflow_dtoRequestJsonToExcelDatajSON = WorkflowExpression.Compile(dtoRequestJsonToExcelDatajSON, nameof(dtoRequestJsonToExcelDatajSON), required: true);
            var __workflow_dtoRequestJsonToExcelDataallInOneTable = WorkflowExpression.Compile(dtoRequestJsonToExcelDataallInOneTable, nameof(dtoRequestJsonToExcelDataallInOneTable), required: false);
            var __workflow_dtoRequestJsonToExcelDataadjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestJsonToExcelDataadjustExcelColumnToContent, nameof(dtoRequestJsonToExcelDataadjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestJsonToExcelDatawrapExcelColumnText = WorkflowExpression.Compile(dtoRequestJsonToExcelDatawrapExcelColumnText, nameof(dtoRequestJsonToExcelDatawrapExcelColumnText), required: false);
            var __workflow_dtoRequestJsonToExcelDatamaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestJsonToExcelDatamaxExcelColumnWidth, nameof(dtoRequestJsonToExcelDatamaxExcelColumnWidth), required: false);
            return new DeferredBodyAction<DtoResponseV1063ConvertJsonToExcel>(() =>
            {
                var apiCallPath = "/V1063_ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestJsonToExcelData = new JObject();
                var dtoRequestJsonToExcelDatapropCount = 0;
                dtoRequestJsonToExcelDatapropCount++;
                dtoRequestJsonToExcelData["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestJsonToExcelDatajSON);
                if (__workflow_dtoRequestJsonToExcelDataallInOneTable != null)
                {
                    if (__workflow_dtoRequestJsonToExcelDataallInOneTable != null)
                    {
                        dtoRequestJsonToExcelData["allInOneTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestJsonToExcelDataallInOneTable);
                        dtoRequestJsonToExcelDatapropCount++;
                    }

                    dtoRequestJsonToExcelDatapropCount++;
                }
                else
                {
                    dtoRequestJsonToExcelData["allInOneTable"] = true;
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (__workflow_dtoRequestJsonToExcelDataadjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestJsonToExcelDataadjustExcelColumnToContent != null)
                    {
                        dtoRequestJsonToExcelData["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestJsonToExcelDataadjustExcelColumnToContent);
                        dtoRequestJsonToExcelDatapropCount++;
                    }

                    dtoRequestJsonToExcelDatapropCount++;
                }
                else
                {
                    dtoRequestJsonToExcelData["adjustColumnToContent"] = true;
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (__workflow_dtoRequestJsonToExcelDatawrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestJsonToExcelDatawrapExcelColumnText != null)
                    {
                        dtoRequestJsonToExcelData["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestJsonToExcelDatawrapExcelColumnText);
                        dtoRequestJsonToExcelDatapropCount++;
                    }

                    dtoRequestJsonToExcelDatapropCount++;
                }
                else
                {
                    dtoRequestJsonToExcelData["wrapColumnText"] = false;
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (__workflow_dtoRequestJsonToExcelDatamaxExcelColumnWidth != null)
                {
                    dtoRequestJsonToExcelData["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestJsonToExcelDatamaxExcelColumnWidth);
                    dtoRequestJsonToExcelDatapropCount++;
                }

                if (dtoRequestJsonToExcelDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestJsonToExcelData;
                }

                return new ApiConnectionAction<DtoResponseV1063ConvertJsonToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertJsonToHtmlTable(Expression<Func<string>> dtoRequestV7051ConvertJsonToHtmlTablejSON)
        {
            var __workflow_dtoRequestV7051ConvertJsonToHtmlTablejSON = WorkflowExpression.Compile(dtoRequestV7051ConvertJsonToHtmlTablejSON, nameof(dtoRequestV7051ConvertJsonToHtmlTablejSON), required: true);
            return new DeferredBodyAction<DtoResponseHtml>(() =>
            {
                var apiCallPath = "/V7051_ConvertJsonToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7051ConvertJsonToHtmlTable = new JObject();
                var dtoRequestV7051ConvertJsonToHtmlTablepropCount = 0;
                dtoRequestV7051ConvertJsonToHtmlTablepropCount++;
                dtoRequestV7051ConvertJsonToHtmlTable["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV7051ConvertJsonToHtmlTablejSON);
                if (dtoRequestV7051ConvertJsonToHtmlTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV7051ConvertJsonToHtmlTable;
                }

                return new ApiConnectionAction<DtoResponseHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable> ConvertJsonToTextTable(Expression<Func<string>> dtoRequestV1090ConvertJsonToTextTablejSON)
        {
            var __workflow_dtoRequestV1090ConvertJsonToTextTablejSON = WorkflowExpression.Compile(dtoRequestV1090ConvertJsonToTextTablejSON, nameof(dtoRequestV1090ConvertJsonToTextTablejSON), required: true);
            return new DeferredBodyAction<DtoResponseV1090ConvertJsonToTextTable>(() =>
            {
                var apiCallPath = "/V1090_ConvertJsonToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1090ConvertJsonToTextTable = new JObject();
                var dtoRequestV1090ConvertJsonToTextTablepropCount = 0;
                dtoRequestV1090ConvertJsonToTextTablepropCount++;
                dtoRequestV1090ConvertJsonToTextTable["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1090ConvertJsonToTextTablejSON);
                if (dtoRequestV1090ConvertJsonToTextTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV1090ConvertJsonToTextTable;
                }

                return new ApiConnectionAction<DtoResponseV1090ConvertJsonToTextTable>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml> ConvertJsonToXml(Expression<Func<string>> dtoRequestV1042ConvertJsonToXmljSON)
        {
            var __workflow_dtoRequestV1042ConvertJsonToXmljSON = WorkflowExpression.Compile(dtoRequestV1042ConvertJsonToXmljSON, nameof(dtoRequestV1042ConvertJsonToXmljSON), required: true);
            return new DeferredBodyAction<DtoResponseV1042ConvertJsonToXml>(() =>
            {
                var apiCallPath = "/V1042_ConvertJsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1042ConvertJsonToXml = new JObject();
                var dtoRequestV1042ConvertJsonToXmlpropCount = 0;
                dtoRequestV1042ConvertJsonToXmlpropCount++;
                dtoRequestV1042ConvertJsonToXml["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1042ConvertJsonToXmljSON);
                if (dtoRequestV1042ConvertJsonToXmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1042ConvertJsonToXml;
                }

                return new ApiConnectionAction<DtoResponseV1042ConvertJsonToXml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml> ConvertJsonToYaml(Expression<Func<string>> dtoRequestV1081ConvertJsonToYamljSON)
        {
            var __workflow_dtoRequestV1081ConvertJsonToYamljSON = WorkflowExpression.Compile(dtoRequestV1081ConvertJsonToYamljSON, nameof(dtoRequestV1081ConvertJsonToYamljSON), required: true);
            return new DeferredBodyAction<DtoResponseV1081ConvertJsonToYaml>(() =>
            {
                var apiCallPath = "/V1081_ConvertJsonToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1081ConvertJsonToYaml = new JObject();
                var dtoRequestV1081ConvertJsonToYamlpropCount = 0;
                dtoRequestV1081ConvertJsonToYamlpropCount++;
                dtoRequestV1081ConvertJsonToYaml["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1081ConvertJsonToYamljSON);
                if (dtoRequestV1081ConvertJsonToYamlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1081ConvertJsonToYaml;
                }

                return new ApiConnectionAction<DtoResponseV1081ConvertJsonToYaml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4070ConvertPdfToPdfA> ConvertPdfToPdfA(Expression<Func<string>> dtoRequestV4070ConvertPdfToPdfApDF, Expression<Func<int>> dtoRequestV4070ConvertPdfToPdfAconformanceLevel = null)
        {
            var __workflow_dtoRequestV4070ConvertPdfToPdfApDF = WorkflowExpression.Compile(dtoRequestV4070ConvertPdfToPdfApDF, nameof(dtoRequestV4070ConvertPdfToPdfApDF), required: true);
            var __workflow_dtoRequestV4070ConvertPdfToPdfAconformanceLevel = WorkflowExpression.Compile(dtoRequestV4070ConvertPdfToPdfAconformanceLevel, nameof(dtoRequestV4070ConvertPdfToPdfAconformanceLevel), required: false);
            return new DeferredBodyAction<DtoResponseV4070ConvertPdfToPdfA>(() =>
            {
                var apiCallPath = "/V4070_ConvertPdfToPdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4070ConvertPdfToPdfA = new JObject();
                var dtoRequestV4070ConvertPdfToPdfApropCount = 0;
                dtoRequestV4070ConvertPdfToPdfApropCount++;
                dtoRequestV4070ConvertPdfToPdfA["pdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4070ConvertPdfToPdfApDF);
                if (__workflow_dtoRequestV4070ConvertPdfToPdfAconformanceLevel != null)
                {
                    dtoRequestV4070ConvertPdfToPdfA["conformanceLevel"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4070ConvertPdfToPdfAconformanceLevel);
                    dtoRequestV4070ConvertPdfToPdfApropCount++;
                }

                if (dtoRequestV4070ConvertPdfToPdfApropCount > 0)
                {
                    callPayload.Body = dtoRequestV4070ConvertPdfToPdfA;
                }

                return new ApiConnectionAction<DtoResponseV4070ConvertPdfToPdfA>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults> ConvertSharePointSearchResults(Expression<Func<string>> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
        {
            var __workflow_dtoRequestV6011ConvertSharePointSearchResultssPSearchResult = WorkflowExpression.Compile(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult, nameof(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult), required: true);
            return new DeferredBodyAction<DtoResponseV6011ConvertSharePointSearchResults>(() =>
            {
                var apiCallPath = "/V6011_ConvertSharePointSearchResults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV6011ConvertSharePointSearchResults = new JObject();
                var dtoRequestV6011ConvertSharePointSearchResultspropCount = 0;
                dtoRequestV6011ConvertSharePointSearchResultspropCount++;
                dtoRequestV6011ConvertSharePointSearchResults["sharepointResult"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV6011ConvertSharePointSearchResultssPSearchResult);
                if (dtoRequestV6011ConvertSharePointSearchResultspropCount > 0)
                {
                    callPayload.Body = dtoRequestV6011ConvertSharePointSearchResults;
                }

                return new ApiConnectionAction<DtoResponseV6011ConvertSharePointSearchResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml> ConvertWordToHtml(Expression<Func<string>> dtoRequestword, Expression<Func<bool>> dtoRequestembedImages = null, Expression<Func<bool>> dtoRequestfullHTMLDocument = null, Expression<Func<string>> dtoRequesttitle = null)
        {
            var __workflow_dtoRequestword = WorkflowExpression.Compile(dtoRequestword, nameof(dtoRequestword), required: true);
            var __workflow_dtoRequestembedImages = WorkflowExpression.Compile(dtoRequestembedImages, nameof(dtoRequestembedImages), required: false);
            var __workflow_dtoRequestfullHTMLDocument = WorkflowExpression.Compile(dtoRequestfullHTMLDocument, nameof(dtoRequestfullHTMLDocument), required: false);
            var __workflow_dtoRequesttitle = WorkflowExpression.Compile(dtoRequesttitle, nameof(dtoRequesttitle), required: false);
            return new DeferredBodyAction<DtoResponseV5160ConvertWordToHtml>(() =>
            {
                var apiCallPath = "/V5160_ConvertWordToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["word"] = ExpressionConverter.ConvertO(__workflow_dtoRequestword);
                if (__workflow_dtoRequestembedImages != null)
                {
                    dtoRequest["embedImages"] = ExpressionConverter.ConvertO(__workflow_dtoRequestembedImages);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfullHTMLDocument != null)
                {
                    dtoRequest["fullHtmlDocument"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfullHTMLDocument);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttitle != null)
                {
                    dtoRequest["title"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttitle);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5160ConvertWordToHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1052ConvertXmlToJson> ConvertXmlToJson(Expression<Func<string>> dtoRequestV1052ConvertXmlToJsonxML)
        {
            var __workflow_dtoRequestV1052ConvertXmlToJsonxML = WorkflowExpression.Compile(dtoRequestV1052ConvertXmlToJsonxML, nameof(dtoRequestV1052ConvertXmlToJsonxML), required: true);
            return new DeferredBodyAction<DtoResponseV1052ConvertXmlToJson>(() =>
            {
                var apiCallPath = "/V1052_ConvertXmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1052ConvertXmlToJson = new JObject();
                var dtoRequestV1052ConvertXmlToJsonpropCount = 0;
                dtoRequestV1052ConvertXmlToJsonpropCount++;
                dtoRequestV1052ConvertXmlToJson["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1052ConvertXmlToJsonxML);
                if (dtoRequestV1052ConvertXmlToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1052ConvertXmlToJson;
                }

                return new ApiConnectionAction<DtoResponseV1052ConvertXmlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8010ConvertXRechnungToPdf> ConvertXRechnungToPdf(Expression<Func<string>> dtoRequestV8010ConvertXRechnungToPdfxRechnung)
        {
            var __workflow_dtoRequestV8010ConvertXRechnungToPdfxRechnung = WorkflowExpression.Compile(dtoRequestV8010ConvertXRechnungToPdfxRechnung, nameof(dtoRequestV8010ConvertXRechnungToPdfxRechnung), required: true);
            return new DeferredBodyAction<DtoResponseV8010ConvertXRechnungToPdf>(() =>
            {
                var apiCallPath = "/V8010_ConvertXRechnungToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV8010ConvertXRechnungToPdf = new JObject();
                var dtoRequestV8010ConvertXRechnungToPdfpropCount = 0;
                dtoRequestV8010ConvertXRechnungToPdfpropCount++;
                dtoRequestV8010ConvertXRechnungToPdf["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV8010ConvertXRechnungToPdfxRechnung);
                if (dtoRequestV8010ConvertXRechnungToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV8010ConvertXRechnungToPdf;
                }

                return new ApiConnectionAction<DtoResponseV8010ConvertXRechnungToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson> ConvertYamlToJson(Expression<Func<string>> dtoRequestV1071YamlToJsonyAML)
        {
            var __workflow_dtoRequestV1071YamlToJsonyAML = WorkflowExpression.Compile(dtoRequestV1071YamlToJsonyAML, nameof(dtoRequestV1071YamlToJsonyAML), required: true);
            return new DeferredBodyAction<DtoResponseV1071ConvertYamlToJson>(() =>
            {
                var apiCallPath = "/V1071_ConvertYamlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1071YamlToJson = new JObject();
                var dtoRequestV1071YamlToJsonpropCount = 0;
                dtoRequestV1071YamlToJsonpropCount++;
                dtoRequestV1071YamlToJson["yaml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV1071YamlToJsonyAML);
                if (dtoRequestV1071YamlToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1071YamlToJson;
                }

                return new ApiConnectionAction<DtoResponseV1071ConvertYamlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3091CreateChartImage> CreateChartImage(Expression<Func<string>> dtoRequestV3091CreateChartImagetableData, Expression<Func<int>> dtoRequestV3091CreateChartImageimageWidth = null, Expression<Func<int>> dtoRequestV3091CreateChartImageimageHeight = null, Expression<Func<string>> dtoRequestV3091CreateChartImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3091CreateChartImageoutputFormat = null, Expression<Func<string>> dtoRequestV3091CreateChartImagechartType = null)
        {
            var __workflow_dtoRequestV3091CreateChartImagetableData = WorkflowExpression.Compile(dtoRequestV3091CreateChartImagetableData, nameof(dtoRequestV3091CreateChartImagetableData), required: true);
            var __workflow_dtoRequestV3091CreateChartImageimageWidth = WorkflowExpression.Compile(dtoRequestV3091CreateChartImageimageWidth, nameof(dtoRequestV3091CreateChartImageimageWidth), required: false);
            var __workflow_dtoRequestV3091CreateChartImageimageHeight = WorkflowExpression.Compile(dtoRequestV3091CreateChartImageimageHeight, nameof(dtoRequestV3091CreateChartImageimageHeight), required: false);
            var __workflow_dtoRequestV3091CreateChartImagebackgroundColor = WorkflowExpression.Compile(dtoRequestV3091CreateChartImagebackgroundColor, nameof(dtoRequestV3091CreateChartImagebackgroundColor), required: false);
            var __workflow_dtoRequestV3091CreateChartImageoutputFormat = WorkflowExpression.Compile(dtoRequestV3091CreateChartImageoutputFormat, nameof(dtoRequestV3091CreateChartImageoutputFormat), required: false);
            var __workflow_dtoRequestV3091CreateChartImagechartType = WorkflowExpression.Compile(dtoRequestV3091CreateChartImagechartType, nameof(dtoRequestV3091CreateChartImagechartType), required: false);
            return new DeferredBodyAction<DtoResponseV3091CreateChartImage>(() =>
            {
                var apiCallPath = "/V3091_CreateChartImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3091CreateChartImage = new JObject();
                var dtoRequestV3091CreateChartImagepropCount = 0;
                if (__workflow_dtoRequestV3091CreateChartImageimageWidth != null)
                {
                    dtoRequestV3091CreateChartImage["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3091CreateChartImageimageWidth);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (__workflow_dtoRequestV3091CreateChartImageimageHeight != null)
                {
                    dtoRequestV3091CreateChartImage["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3091CreateChartImageimageHeight);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (__workflow_dtoRequestV3091CreateChartImagebackgroundColor != null)
                {
                    dtoRequestV3091CreateChartImage["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3091CreateChartImagebackgroundColor);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (__workflow_dtoRequestV3091CreateChartImageoutputFormat != null)
                {
                    dtoRequestV3091CreateChartImage["format"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3091CreateChartImageoutputFormat);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                dtoRequestV3091CreateChartImagepropCount++;
                dtoRequestV3091CreateChartImage["chart"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3091CreateChartImagetableData);
                if (__workflow_dtoRequestV3091CreateChartImagechartType != null)
                {
                    dtoRequestV3091CreateChartImage["type"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3091CreateChartImagechartType);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3091CreateChartImage;
                }

                return new ApiConnectionAction<DtoResponseV3091CreateChartImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3062CreateCode> CreateCode(Expression<Func<string>> dtoRequestV3062CreateCodecontent, Expression<Func<string>> dtoRequestV3062CreateCodecodeFormat = null, Expression<Func<int>> dtoRequestV3062CreateCodewidth = null, Expression<Func<int>> dtoRequestV3062CreateCodeheight = null, Expression<Func<string>> dtoRequestV3062CreateCodeoutputFormat = null, Expression<Func<string>> dtoRequestV3062CreateCodeembeddedImage = null, Expression<Func<double>> dtoRequestV3062CreateCodeembeddedImageOpacity = null, Expression<Func<double>> dtoRequestV3062CreateCodeembeddedImageRatio = null)
        {
            var __workflow_dtoRequestV3062CreateCodecontent = WorkflowExpression.Compile(dtoRequestV3062CreateCodecontent, nameof(dtoRequestV3062CreateCodecontent), required: true);
            var __workflow_dtoRequestV3062CreateCodecodeFormat = WorkflowExpression.Compile(dtoRequestV3062CreateCodecodeFormat, nameof(dtoRequestV3062CreateCodecodeFormat), required: false);
            var __workflow_dtoRequestV3062CreateCodewidth = WorkflowExpression.Compile(dtoRequestV3062CreateCodewidth, nameof(dtoRequestV3062CreateCodewidth), required: false);
            var __workflow_dtoRequestV3062CreateCodeheight = WorkflowExpression.Compile(dtoRequestV3062CreateCodeheight, nameof(dtoRequestV3062CreateCodeheight), required: false);
            var __workflow_dtoRequestV3062CreateCodeoutputFormat = WorkflowExpression.Compile(dtoRequestV3062CreateCodeoutputFormat, nameof(dtoRequestV3062CreateCodeoutputFormat), required: false);
            var __workflow_dtoRequestV3062CreateCodeembeddedImage = WorkflowExpression.Compile(dtoRequestV3062CreateCodeembeddedImage, nameof(dtoRequestV3062CreateCodeembeddedImage), required: false);
            var __workflow_dtoRequestV3062CreateCodeembeddedImageOpacity = WorkflowExpression.Compile(dtoRequestV3062CreateCodeembeddedImageOpacity, nameof(dtoRequestV3062CreateCodeembeddedImageOpacity), required: false);
            var __workflow_dtoRequestV3062CreateCodeembeddedImageRatio = WorkflowExpression.Compile(dtoRequestV3062CreateCodeembeddedImageRatio, nameof(dtoRequestV3062CreateCodeembeddedImageRatio), required: false);
            return new DeferredBodyAction<DtoResponseV3062CreateCode>(() =>
            {
                var apiCallPath = "/V3062_CreateCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3062CreateCode = new JObject();
                var dtoRequestV3062CreateCodepropCount = 0;
                dtoRequestV3062CreateCodepropCount++;
                dtoRequestV3062CreateCode["content"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodecontent);
                if (__workflow_dtoRequestV3062CreateCodecodeFormat != null)
                {
                    dtoRequestV3062CreateCode["codeFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodecodeFormat);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (__workflow_dtoRequestV3062CreateCodewidth != null)
                {
                    dtoRequestV3062CreateCode["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodewidth);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (__workflow_dtoRequestV3062CreateCodeheight != null)
                {
                    dtoRequestV3062CreateCode["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodeheight);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (__workflow_dtoRequestV3062CreateCodeoutputFormat != null)
                {
                    dtoRequestV3062CreateCode["outFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodeoutputFormat);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (__workflow_dtoRequestV3062CreateCodeembeddedImage != null)
                {
                    dtoRequestV3062CreateCode["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodeembeddedImage);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (__workflow_dtoRequestV3062CreateCodeembeddedImageOpacity != null)
                {
                    dtoRequestV3062CreateCode["imageOpacity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodeembeddedImageOpacity);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (__workflow_dtoRequestV3062CreateCodeembeddedImageRatio != null)
                {
                    dtoRequestV3062CreateCode["imageRatio"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3062CreateCodeembeddedImageRatio);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3062CreateCode;
                }

                return new ApiConnectionAction<DtoResponseV3062CreateCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3111CreateGraphImage> CreateGraphImage(Expression<Func<string>> dtoRequestV3111CreateGraphImagegraphData, Expression<Func<int>> dtoRequestV3111CreateGraphImageimageWidth = null, Expression<Func<int>> dtoRequestV3111CreateGraphImageimageHeight = null, Expression<Func<string>> dtoRequestV3111CreateGraphImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3111CreateGraphImageoutputFormat = null)
        {
            var __workflow_dtoRequestV3111CreateGraphImagegraphData = WorkflowExpression.Compile(dtoRequestV3111CreateGraphImagegraphData, nameof(dtoRequestV3111CreateGraphImagegraphData), required: true);
            var __workflow_dtoRequestV3111CreateGraphImageimageWidth = WorkflowExpression.Compile(dtoRequestV3111CreateGraphImageimageWidth, nameof(dtoRequestV3111CreateGraphImageimageWidth), required: false);
            var __workflow_dtoRequestV3111CreateGraphImageimageHeight = WorkflowExpression.Compile(dtoRequestV3111CreateGraphImageimageHeight, nameof(dtoRequestV3111CreateGraphImageimageHeight), required: false);
            var __workflow_dtoRequestV3111CreateGraphImagebackgroundColor = WorkflowExpression.Compile(dtoRequestV3111CreateGraphImagebackgroundColor, nameof(dtoRequestV3111CreateGraphImagebackgroundColor), required: false);
            var __workflow_dtoRequestV3111CreateGraphImageoutputFormat = WorkflowExpression.Compile(dtoRequestV3111CreateGraphImageoutputFormat, nameof(dtoRequestV3111CreateGraphImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV3111CreateGraphImage>(() =>
            {
                var apiCallPath = "/V3111_CreateGraphImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3111CreateGraphImage = new JObject();
                var dtoRequestV3111CreateGraphImagepropCount = 0;
                if (__workflow_dtoRequestV3111CreateGraphImageimageWidth != null)
                {
                    dtoRequestV3111CreateGraphImage["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3111CreateGraphImageimageWidth);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (__workflow_dtoRequestV3111CreateGraphImageimageHeight != null)
                {
                    dtoRequestV3111CreateGraphImage["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3111CreateGraphImageimageHeight);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (__workflow_dtoRequestV3111CreateGraphImagebackgroundColor != null)
                {
                    dtoRequestV3111CreateGraphImage["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3111CreateGraphImagebackgroundColor);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (__workflow_dtoRequestV3111CreateGraphImageoutputFormat != null)
                {
                    dtoRequestV3111CreateGraphImage["format"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3111CreateGraphImageoutputFormat);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                dtoRequestV3111CreateGraphImagepropCount++;
                dtoRequestV3111CreateGraphImage["graph"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3111CreateGraphImagegraphData);
                if (dtoRequestV3111CreateGraphImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3111CreateGraphImage;
                }

                return new ApiConnectionAction<DtoResponseV3111CreateGraphImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3101CreateTableImage> CreateTableImage(Expression<Func<string>> dtoRequestV3101CreateTableImagetableData, Expression<Func<int>> dtoRequestV3101CreateTableImageimageWidth = null, Expression<Func<int>> dtoRequestV3101CreateTableImageimageHeight = null, Expression<Func<string>> dtoRequestV3101CreateTableImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3101CreateTableImageoutputFormat = null, Expression<Func<string>> dtoRequestV3101CreateTableImagetitle = null, Expression<Func<bool>> dtoRequestV3101CreateTableImageshowTableBorders = null)
        {
            var __workflow_dtoRequestV3101CreateTableImagetableData = WorkflowExpression.Compile(dtoRequestV3101CreateTableImagetableData, nameof(dtoRequestV3101CreateTableImagetableData), required: true);
            var __workflow_dtoRequestV3101CreateTableImageimageWidth = WorkflowExpression.Compile(dtoRequestV3101CreateTableImageimageWidth, nameof(dtoRequestV3101CreateTableImageimageWidth), required: false);
            var __workflow_dtoRequestV3101CreateTableImageimageHeight = WorkflowExpression.Compile(dtoRequestV3101CreateTableImageimageHeight, nameof(dtoRequestV3101CreateTableImageimageHeight), required: false);
            var __workflow_dtoRequestV3101CreateTableImagebackgroundColor = WorkflowExpression.Compile(dtoRequestV3101CreateTableImagebackgroundColor, nameof(dtoRequestV3101CreateTableImagebackgroundColor), required: false);
            var __workflow_dtoRequestV3101CreateTableImageoutputFormat = WorkflowExpression.Compile(dtoRequestV3101CreateTableImageoutputFormat, nameof(dtoRequestV3101CreateTableImageoutputFormat), required: false);
            var __workflow_dtoRequestV3101CreateTableImagetitle = WorkflowExpression.Compile(dtoRequestV3101CreateTableImagetitle, nameof(dtoRequestV3101CreateTableImagetitle), required: false);
            var __workflow_dtoRequestV3101CreateTableImageshowTableBorders = WorkflowExpression.Compile(dtoRequestV3101CreateTableImageshowTableBorders, nameof(dtoRequestV3101CreateTableImageshowTableBorders), required: false);
            return new DeferredBodyAction<DtoResponseV3101CreateTableImage>(() =>
            {
                var apiCallPath = "/V3101_CreateTableImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3101CreateTableImage = new JObject();
                var dtoRequestV3101CreateTableImagepropCount = 0;
                if (__workflow_dtoRequestV3101CreateTableImageimageWidth != null)
                {
                    dtoRequestV3101CreateTableImage["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImageimageWidth);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (__workflow_dtoRequestV3101CreateTableImageimageHeight != null)
                {
                    dtoRequestV3101CreateTableImage["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImageimageHeight);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (__workflow_dtoRequestV3101CreateTableImagebackgroundColor != null)
                {
                    dtoRequestV3101CreateTableImage["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImagebackgroundColor);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (__workflow_dtoRequestV3101CreateTableImageoutputFormat != null)
                {
                    dtoRequestV3101CreateTableImage["format"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImageoutputFormat);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                dtoRequestV3101CreateTableImagepropCount++;
                dtoRequestV3101CreateTableImage["data"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImagetableData);
                if (__workflow_dtoRequestV3101CreateTableImagetitle != null)
                {
                    dtoRequestV3101CreateTableImage["title"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImagetitle);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (__workflow_dtoRequestV3101CreateTableImageshowTableBorders != null)
                {
                    if (__workflow_dtoRequestV3101CreateTableImageshowTableBorders != null)
                    {
                        dtoRequestV3101CreateTableImage["hasLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3101CreateTableImageshowTableBorders);
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

                return new ApiConnectionAction<DtoResponseV3101CreateTableImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3081CreateWatermarkImage> CreateWatermarkImage(Expression<Func<string>> dtoRequestV3081CreateWatermarkImagemainImage, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkImage, Expression<Func<int>> dtoRequestV3081CreateWatermarkImagewatermarkOpacity = null, Expression<Func<int>> dtoRequestV3081CreateWatermarkImagewatermarkRatio = null, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = null, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = null)
        {
            var __workflow_dtoRequestV3081CreateWatermarkImagemainImage = WorkflowExpression.Compile(dtoRequestV3081CreateWatermarkImagemainImage, nameof(dtoRequestV3081CreateWatermarkImagemainImage), required: true);
            var __workflow_dtoRequestV3081CreateWatermarkImagewatermarkImage = WorkflowExpression.Compile(dtoRequestV3081CreateWatermarkImagewatermarkImage, nameof(dtoRequestV3081CreateWatermarkImagewatermarkImage), required: true);
            var __workflow_dtoRequestV3081CreateWatermarkImagewatermarkOpacity = WorkflowExpression.Compile(dtoRequestV3081CreateWatermarkImagewatermarkOpacity, nameof(dtoRequestV3081CreateWatermarkImagewatermarkOpacity), required: false);
            var __workflow_dtoRequestV3081CreateWatermarkImagewatermarkRatio = WorkflowExpression.Compile(dtoRequestV3081CreateWatermarkImagewatermarkRatio, nameof(dtoRequestV3081CreateWatermarkImagewatermarkRatio), required: false);
            var __workflow_dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = WorkflowExpression.Compile(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition, nameof(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition), required: false);
            var __workflow_dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = WorkflowExpression.Compile(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition, nameof(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition), required: false);
            return new DeferredBodyAction<DtoResponseV3081CreateWatermarkImage>(() =>
            {
                var apiCallPath = "/V3081_CreateWatermarkImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3081CreateWatermarkImage = new JObject();
                var dtoRequestV3081CreateWatermarkImagepropCount = 0;
                dtoRequestV3081CreateWatermarkImagepropCount++;
                dtoRequestV3081CreateWatermarkImage["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3081CreateWatermarkImagemainImage);
                dtoRequestV3081CreateWatermarkImagepropCount++;
                dtoRequestV3081CreateWatermarkImage["watermarkImage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3081CreateWatermarkImagewatermarkImage);
                if (__workflow_dtoRequestV3081CreateWatermarkImagewatermarkOpacity != null)
                {
                    dtoRequestV3081CreateWatermarkImage["opacity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3081CreateWatermarkImagewatermarkOpacity);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (__workflow_dtoRequestV3081CreateWatermarkImagewatermarkRatio != null)
                {
                    dtoRequestV3081CreateWatermarkImage["ratio"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3081CreateWatermarkImagewatermarkRatio);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (__workflow_dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition != null)
                {
                    dtoRequestV3081CreateWatermarkImage["imagePositionHorizontal"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (__workflow_dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition != null)
                {
                    dtoRequestV3081CreateWatermarkImage["imagePositionVertical"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3081CreateWatermarkImage;
                }

                return new ApiConnectionAction<DtoResponseV3081CreateWatermarkImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5011CreateWordFile> CreateWordFile(Expression<Func<Section[]>> dtoRequestV5011CreateWordFilesection, Expression<Func<string>> dtoRequestV5011CreateWordFileexistingFileContent = null)
        {
            var __workflow_dtoRequestV5011CreateWordFilesection = WorkflowExpression.Compile(dtoRequestV5011CreateWordFilesection, nameof(dtoRequestV5011CreateWordFilesection), required: true);
            var __workflow_dtoRequestV5011CreateWordFileexistingFileContent = WorkflowExpression.Compile(dtoRequestV5011CreateWordFileexistingFileContent, nameof(dtoRequestV5011CreateWordFileexistingFileContent), required: false);
            return new DeferredBodyAction<DtoResponseV5011CreateWordFile>(() =>
            {
                var apiCallPath = "/V5011_CreateWordFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5011CreateWordFile = new JObject();
                var dtoRequestV5011CreateWordFilepropCount = 0;
                if (__workflow_dtoRequestV5011CreateWordFileexistingFileContent != null)
                {
                    dtoRequestV5011CreateWordFile["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5011CreateWordFileexistingFileContent);
                    dtoRequestV5011CreateWordFilepropCount++;
                }

                dtoRequestV5011CreateWordFilepropCount++;
                dtoRequestV5011CreateWordFile["sections"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5011CreateWordFilesection);
                if (dtoRequestV5011CreateWordFilepropCount > 0)
                {
                    callPayload.Body = dtoRequestV5011CreateWordFile;
                }

                return new ApiConnectionAction<DtoResponseV5011CreateWordFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf> ExtractImagesFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<string>> dtoRequestfileNamePrefix = null, Expression<Func<bool>> dtoRequestincludeBase64String = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestfileNamePrefix = WorkflowExpression.Compile(dtoRequestfileNamePrefix, nameof(dtoRequestfileNamePrefix), required: false);
            var __workflow_dtoRequestincludeBase64String = WorkflowExpression.Compile(dtoRequestincludeBase64String, nameof(dtoRequestincludeBase64String), required: false);
            return new DeferredBodyAction<DtoResponseV4090ExtractImagesFromPdf>(() =>
            {
                var apiCallPath = "/V4090_ExtractImagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDF);
                if (__workflow_dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileNamePrefix != null)
                {
                    dtoRequest["fileNamePrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileNamePrefix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestincludeBase64String != null)
                {
                    dtoRequest["includeFileString"] = ExpressionConverter.ConvertO(__workflow_dtoRequestincludeBase64String);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4090ExtractImagesFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties> ExtractJsonObjectProperties(Expression<Func<string>> dtoRequestV2100ExtractJsonObjectPropertiesjSON, Expression<Func<bool>> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
        {
            var __workflow_dtoRequestV2100ExtractJsonObjectPropertiesjSON = WorkflowExpression.Compile(dtoRequestV2100ExtractJsonObjectPropertiesjSON, nameof(dtoRequestV2100ExtractJsonObjectPropertiesjSON), required: true);
            var __workflow_dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = WorkflowExpression.Compile(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties, nameof(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties), required: false);
            return new DeferredBodyAction<DtoResponseV2100ExtractJsonObjectProperties>(() =>
            {
                var apiCallPath = "/V2100_ExtractJsonObjectProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2100ExtractJsonObjectProperties = new JObject();
                var dtoRequestV2100ExtractJsonObjectPropertiespropCount = 0;
                dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
                dtoRequestV2100ExtractJsonObjectProperties["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2100ExtractJsonObjectPropertiesjSON);
                if (__workflow_dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                {
                    if (__workflow_dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                    {
                        dtoRequestV2100ExtractJsonObjectProperties["nestedPropertyExtraction"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties);
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

                return new ApiConnectionAction<DtoResponseV2100ExtractJsonObjectProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4060ExtractPdfPages> ExtractPdfPages(Expression<Func<string>> dtoRequestV4060ExtractPdfPagespDFFile, Expression<Func<string>> dtoRequestV4060ExtractPdfPagespagesToExtract)
        {
            var __workflow_dtoRequestV4060ExtractPdfPagespDFFile = WorkflowExpression.Compile(dtoRequestV4060ExtractPdfPagespDFFile, nameof(dtoRequestV4060ExtractPdfPagespDFFile), required: true);
            var __workflow_dtoRequestV4060ExtractPdfPagespagesToExtract = WorkflowExpression.Compile(dtoRequestV4060ExtractPdfPagespagesToExtract, nameof(dtoRequestV4060ExtractPdfPagespagesToExtract), required: true);
            return new DeferredBodyAction<DtoResponseV4060ExtractPdfPages>(() =>
            {
                var apiCallPath = "/V4060_ExtractPdfPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4060ExtractPdfPages = new JObject();
                var dtoRequestV4060ExtractPdfPagespropCount = 0;
                dtoRequestV4060ExtractPdfPagespropCount++;
                dtoRequestV4060ExtractPdfPages["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4060ExtractPdfPagespDFFile);
                dtoRequestV4060ExtractPdfPagespropCount++;
                dtoRequestV4060ExtractPdfPages["pages"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4060ExtractPdfPagespagesToExtract);
                if (dtoRequestV4060ExtractPdfPagespropCount > 0)
                {
                    callPayload.Body = dtoRequestV4060ExtractPdfPages;
                }

                return new ApiConnectionAction<DtoResponseV4060ExtractPdfPages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern> ExtractTextAccordingToPattern(Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntext, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, Expression<Func<bool>> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
        {
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatterntext = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatterntext, nameof(dtoRequestV2140ExtractTextAccordingToPatterntext), required: true);
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatternmatchPattern = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, nameof(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern), required: true);
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled), required: false);
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings), required: false);
            return new DeferredBodyAction<DtoResponseV2140ExtractTextAccordingToPattern>(() =>
            {
                var apiCallPath = "/V2140_ExtractTextAccordingToPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2140ExtractTextAccordingToPattern = new JObject();
                var dtoRequestV2140ExtractTextAccordingToPatternpropCount = 0;
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                dtoRequestV2140ExtractTextAccordingToPattern["inputText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2140ExtractTextAccordingToPatterntext);
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                dtoRequestV2140ExtractTextAccordingToPattern["matchPattern"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2140ExtractTextAccordingToPatternmatchPattern);
                if (__workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled != null)
                {
                    dtoRequestV2140ExtractTextAccordingToPattern["trimEnabled"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled);
                    dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                }

                if (__workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimStrings != null)
                {
                    dtoRequestV2140ExtractTextAccordingToPattern["trimStrings"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimStrings);
                    dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                }

                if (dtoRequestV2140ExtractTextAccordingToPatternpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2140ExtractTextAccordingToPattern;
                }

                return new ApiConnectionAction<DtoResponseV2140ExtractTextAccordingToPattern>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf> ExtractTextFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<bool>> dtoRequestlayoutBased = null, Expression<Func<bool>> dtoRequestincludePages = null, Expression<Func<string>> dtoRequestpageSeparator = null, Expression<Func<bool>> dtoRequestnormalizeWhitespace = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestlayoutBased = WorkflowExpression.Compile(dtoRequestlayoutBased, nameof(dtoRequestlayoutBased), required: false);
            var __workflow_dtoRequestincludePages = WorkflowExpression.Compile(dtoRequestincludePages, nameof(dtoRequestincludePages), required: false);
            var __workflow_dtoRequestpageSeparator = WorkflowExpression.Compile(dtoRequestpageSeparator, nameof(dtoRequestpageSeparator), required: false);
            var __workflow_dtoRequestnormalizeWhitespace = WorkflowExpression.Compile(dtoRequestnormalizeWhitespace, nameof(dtoRequestnormalizeWhitespace), required: false);
            return new DeferredBodyAction<DtoResponseV4100ExtractTextFromPdf>(() =>
            {
                var apiCallPath = "/V4100_ExtractTextFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDF);
                if (__workflow_dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestlayoutBased != null)
                {
                    dtoRequest["layoutBased"] = ExpressionConverter.ConvertO(__workflow_dtoRequestlayoutBased);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestincludePages != null)
                {
                    dtoRequest["includePages"] = ExpressionConverter.ConvertO(__workflow_dtoRequestincludePages);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpageSeparator != null)
                {
                    dtoRequest["pageSeparator"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpageSeparator);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestnormalizeWhitespace != null)
                {
                    dtoRequest["normalizeWhitespace"] = ExpressionConverter.ConvertO(__workflow_dtoRequestnormalizeWhitespace);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4100ExtractTextFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> ExtractWordBookmarks(Expression<Func<string>> dtoRequestV5021ExtractWordBookmarksfile, Expression<Func<bool>> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchName = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            var __workflow_dtoRequestV5021ExtractWordBookmarksfile = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarksfile, nameof(dtoRequestV5021ExtractWordBookmarksfile), required: true);
            var __workflow_dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks, nameof(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks), required: false);
            var __workflow_dtoRequestV5021ExtractWordBookmarkssearchName = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarkssearchName, nameof(dtoRequestV5021ExtractWordBookmarkssearchName), required: false);
            var __workflow_dtoRequestV5021ExtractWordBookmarkssearchContent = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarkssearchContent, nameof(dtoRequestV5021ExtractWordBookmarkssearchContent), required: false);
            return new DeferredBodyAction<DtoResponseV5021ExtractWordBookmarks>(() =>
            {
                var apiCallPath = "/V5021_ExtractWordBookmarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5021ExtractWordBookmarks = new JObject();
                var dtoRequestV5021ExtractWordBookmarkspropCount = 0;
                dtoRequestV5021ExtractWordBookmarkspropCount++;
                dtoRequestV5021ExtractWordBookmarks["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5021ExtractWordBookmarksfile);
                if (__workflow_dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                {
                    if (__workflow_dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                    {
                        dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks);
                        dtoRequestV5021ExtractWordBookmarkspropCount++;
                    }

                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }
                else
                {
                    dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = false;
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (__workflow_dtoRequestV5021ExtractWordBookmarkssearchName != null)
                {
                    dtoRequestV5021ExtractWordBookmarks["searchKey"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5021ExtractWordBookmarkssearchName);
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (__workflow_dtoRequestV5021ExtractWordBookmarkssearchContent != null)
                {
                    dtoRequestV5021ExtractWordBookmarks["searchValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5021ExtractWordBookmarkssearchContent);
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (dtoRequestV5021ExtractWordBookmarkspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5021ExtractWordBookmarks;
                }

                return new ApiConnectionAction<DtoResponseV5021ExtractWordBookmarks>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> ExtractWordContentControls(Expression<Func<string>> dtoRequestV5120ExtractWordContentControlsfile, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTag = null, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            var __workflow_dtoRequestV5120ExtractWordContentControlsfile = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControlsfile, nameof(dtoRequestV5120ExtractWordContentControlsfile), required: true);
            var __workflow_dtoRequestV5120ExtractWordContentControlssearchTag = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControlssearchTag, nameof(dtoRequestV5120ExtractWordContentControlssearchTag), required: false);
            var __workflow_dtoRequestV5120ExtractWordContentControlssearchTitle = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControlssearchTitle, nameof(dtoRequestV5120ExtractWordContentControlssearchTitle), required: false);
            return new DeferredBodyAction<DtoResponseV5120ExtractWordContentControls>(() =>
            {
                var apiCallPath = "/V5120_ExtractWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5120ExtractWordContentControls = new JObject();
                var dtoRequestV5120ExtractWordContentControlspropCount = 0;
                dtoRequestV5120ExtractWordContentControlspropCount++;
                dtoRequestV5120ExtractWordContentControls["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5120ExtractWordContentControlsfile);
                if (__workflow_dtoRequestV5120ExtractWordContentControlssearchTag != null)
                {
                    dtoRequestV5120ExtractWordContentControls["searchTag"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5120ExtractWordContentControlssearchTag);
                    dtoRequestV5120ExtractWordContentControlspropCount++;
                }

                if (__workflow_dtoRequestV5120ExtractWordContentControlssearchTitle != null)
                {
                    dtoRequestV5120ExtractWordContentControls["searchTitle"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5120ExtractWordContentControlssearchTitle);
                    dtoRequestV5120ExtractWordContentControlspropCount++;
                }

                if (dtoRequestV5120ExtractWordContentControlspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5120ExtractWordContentControls;
                }

                return new ApiConnectionAction<DtoResponseV5120ExtractWordContentControls>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2021IbanData> IbanData(Expression<Func<string>> dtoRequestV2021IbanDataiBAN)
        {
            var __workflow_dtoRequestV2021IbanDataiBAN = WorkflowExpression.Compile(dtoRequestV2021IbanDataiBAN, nameof(dtoRequestV2021IbanDataiBAN), required: true);
            return new DeferredBodyAction<DtoResponseV2021IbanData>(() =>
            {
                var apiCallPath = "/V2021_IbanData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2021IbanData = new JObject();
                var dtoRequestV2021IbanDatapropCount = 0;
                dtoRequestV2021IbanDatapropCount++;
                dtoRequestV2021IbanData["iban"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2021IbanDataiBAN);
                if (dtoRequestV2021IbanDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV2021IbanData;
                }

                return new ApiConnectionAction<DtoResponseV2021IbanData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData> ImageMetaData(Expression<Func<string>> dtoRequestV3071ImageMetaDataimageFile)
        {
            var __workflow_dtoRequestV3071ImageMetaDataimageFile = WorkflowExpression.Compile(dtoRequestV3071ImageMetaDataimageFile, nameof(dtoRequestV3071ImageMetaDataimageFile), required: true);
            return new DeferredBodyAction<DtoResponseV3071ImageMetaData>(() =>
            {
                var apiCallPath = "/V3071_ImageMetaData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3071ImageMetaData = new JObject();
                var dtoRequestV3071ImageMetaDatapropCount = 0;
                dtoRequestV3071ImageMetaDatapropCount++;
                dtoRequestV3071ImageMetaData["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3071ImageMetaDataimageFile);
                if (dtoRequestV3071ImageMetaDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV3071ImageMetaData;
                }

                return new ApiConnectionAction<DtoResponseV3071ImageMetaData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToPowerPoint(Expression<Func<string>> dtoRequestV9020InsertImagePowerPointexistingFileContent, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderImage, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderName = null, Expression<Func<int>> dtoRequestV9020InsertImagePowerPointmaximumImageWidth = null, Expression<Func<int>> dtoRequestV9020InsertImagePowerPointmaximumImageHeight = null, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV9020InsertImagePowerPointexistingFileContent = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointexistingFileContent, nameof(dtoRequestV9020InsertImagePowerPointexistingFileContent), required: true);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderImage = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderImage, nameof(dtoRequestV9020InsertImagePowerPointplaceholderImage), required: true);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderName = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderName, nameof(dtoRequestV9020InsertImagePowerPointplaceholderName), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointmaximumImageWidth = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointmaximumImageWidth, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageWidth), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointmaximumImageHeight = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointmaximumImageHeight, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageHeight), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderPrefix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderPrefix), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderSuffix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V9020_InsertImageToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV9020InsertImagePowerPoint = new JObject();
                var dtoRequestV9020InsertImagePowerPointpropCount = 0;
                dtoRequestV9020InsertImagePowerPointpropCount++;
                dtoRequestV9020InsertImagePowerPoint["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointexistingFileContent);
                if (__workflow_dtoRequestV9020InsertImagePowerPointplaceholderName != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointplaceholderName);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                dtoRequestV9020InsertImagePowerPointpropCount++;
                dtoRequestV9020InsertImagePowerPoint["placeholderImage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointplaceholderImage);
                if (__workflow_dtoRequestV9020InsertImagePowerPointmaximumImageWidth != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointmaximumImageWidth);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (__workflow_dtoRequestV9020InsertImagePowerPointmaximumImageHeight != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointmaximumImageHeight);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (__workflow_dtoRequestV9020InsertImagePowerPointplaceholderPrefix != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointplaceholderPrefix);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (__workflow_dtoRequestV9020InsertImagePowerPointplaceholderSuffix != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPointplaceholderSuffix);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointpropCount > 0)
                {
                    callPayload.Body = dtoRequestV9020InsertImagePowerPoint;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToWord(Expression<Func<string>> dtoRequestV5081InsertImageToWordexistingFileContent, Expression<Func<string>> dtoRequestV5081InsertImageToWordimage, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderName = null, Expression<Func<int>> dtoRequestV5081InsertImageToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5081InsertImageToWordmaximumImageHeight = null, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV5081InsertImageToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordexistingFileContent, nameof(dtoRequestV5081InsertImageToWordexistingFileContent), required: true);
            var __workflow_dtoRequestV5081InsertImageToWordimage = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordimage, nameof(dtoRequestV5081InsertImageToWordimage), required: true);
            var __workflow_dtoRequestV5081InsertImageToWordplaceholderName = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordplaceholderName, nameof(dtoRequestV5081InsertImageToWordplaceholderName), required: false);
            var __workflow_dtoRequestV5081InsertImageToWordmaximumImageWidth = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordmaximumImageWidth, nameof(dtoRequestV5081InsertImageToWordmaximumImageWidth), required: false);
            var __workflow_dtoRequestV5081InsertImageToWordmaximumImageHeight = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordmaximumImageHeight, nameof(dtoRequestV5081InsertImageToWordmaximumImageHeight), required: false);
            var __workflow_dtoRequestV5081InsertImageToWordplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordplaceholderPrefix, nameof(dtoRequestV5081InsertImageToWordplaceholderPrefix), required: false);
            var __workflow_dtoRequestV5081InsertImageToWordplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV5081InsertImageToWordplaceholderSuffix, nameof(dtoRequestV5081InsertImageToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V5081_InsertImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5081InsertImageToWord = new JObject();
                var dtoRequestV5081InsertImageToWordpropCount = 0;
                dtoRequestV5081InsertImageToWordpropCount++;
                dtoRequestV5081InsertImageToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordexistingFileContent);
                if (__workflow_dtoRequestV5081InsertImageToWordplaceholderName != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordplaceholderName);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                dtoRequestV5081InsertImageToWordpropCount++;
                dtoRequestV5081InsertImageToWord["placeholderImage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordimage);
                if (__workflow_dtoRequestV5081InsertImageToWordmaximumImageWidth != null)
                {
                    dtoRequestV5081InsertImageToWord["maxWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordmaximumImageWidth);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (__workflow_dtoRequestV5081InsertImageToWordmaximumImageHeight != null)
                {
                    dtoRequestV5081InsertImageToWord["maxHeight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordmaximumImageHeight);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (__workflow_dtoRequestV5081InsertImageToWordplaceholderPrefix != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordplaceholderPrefix);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (__workflow_dtoRequestV5081InsertImageToWordplaceholderSuffix != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5081InsertImageToWordplaceholderSuffix);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5081InsertImageToWord;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5110InsertMultipleTextSectionsToWord> InsertMultipleTextSectionsToWord(Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, Expression<Func<InsertSection[]>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent), required: true);
            var __workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder = WorkflowExpression.Compile(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder), required: true);
            var __workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix), required: false);
            var __workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseV5110InsertMultipleTextSectionsToWord>(() =>
            {
                var apiCallPath = "/V5110_InsertMultipleTextSectionsToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5110InsertMultipleTextSectionsToWord = new JObject();
                var dtoRequestV5110InsertMultipleTextSectionsToWordpropCount = 0;
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                dtoRequestV5110InsertMultipleTextSectionsToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent);
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                dtoRequestV5110InsertMultipleTextSectionsToWord["insertSections"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder);
                if (__workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix != null)
                {
                    dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix);
                    dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                }

                if (__workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix != null)
                {
                    dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix);
                    dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                }

                if (dtoRequestV5110InsertMultipleTextSectionsToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5110InsertMultipleTextSectionsToWord;
                }

                return new ApiConnectionAction<DtoResponseV5110InsertMultipleTextSectionsToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5091InsertTableToWord> InsertTableToWord(Expression<Func<string>> dtoRequestV5091InsertTableToWordexistingFileContent, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderName = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderTable = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordtableStyle = null, Expression<Func<bool>> dtoRequestV5091InsertTableToWordshowHeaders = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV5091InsertTableToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordexistingFileContent, nameof(dtoRequestV5091InsertTableToWordexistingFileContent), required: true);
            var __workflow_dtoRequestV5091InsertTableToWordplaceholderName = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordplaceholderName, nameof(dtoRequestV5091InsertTableToWordplaceholderName), required: false);
            var __workflow_dtoRequestV5091InsertTableToWordplaceholderTable = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordplaceholderTable, nameof(dtoRequestV5091InsertTableToWordplaceholderTable), required: false);
            var __workflow_dtoRequestV5091InsertTableToWordtableStyle = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordtableStyle, nameof(dtoRequestV5091InsertTableToWordtableStyle), required: false);
            var __workflow_dtoRequestV5091InsertTableToWordshowHeaders = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordshowHeaders, nameof(dtoRequestV5091InsertTableToWordshowHeaders), required: false);
            var __workflow_dtoRequestV5091InsertTableToWordplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordplaceholderPrefix, nameof(dtoRequestV5091InsertTableToWordplaceholderPrefix), required: false);
            var __workflow_dtoRequestV5091InsertTableToWordplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV5091InsertTableToWordplaceholderSuffix, nameof(dtoRequestV5091InsertTableToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseV5091InsertTableToWord>(() =>
            {
                var apiCallPath = "/V5091_InsertTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5091InsertTableToWord = new JObject();
                var dtoRequestV5091InsertTableToWordpropCount = 0;
                dtoRequestV5091InsertTableToWordpropCount++;
                dtoRequestV5091InsertTableToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordexistingFileContent);
                if (__workflow_dtoRequestV5091InsertTableToWordplaceholderName != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordplaceholderName);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5091InsertTableToWordplaceholderTable != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordplaceholderTable);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5091InsertTableToWordtableStyle != null)
                {
                    if (__workflow_dtoRequestV5091InsertTableToWordtableStyle != null)
                    {
                        dtoRequestV5091InsertTableToWord["tableStyle"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordtableStyle);
                        dtoRequestV5091InsertTableToWordpropCount++;
                    }

                    dtoRequestV5091InsertTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5091InsertTableToWord["tableStyle"] = "GridTable1Light";
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5091InsertTableToWordshowHeaders != null)
                {
                    if (__workflow_dtoRequestV5091InsertTableToWordshowHeaders != null)
                    {
                        dtoRequestV5091InsertTableToWord["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordshowHeaders);
                        dtoRequestV5091InsertTableToWordpropCount++;
                    }

                    dtoRequestV5091InsertTableToWordpropCount++;
                }
                else
                {
                    dtoRequestV5091InsertTableToWord["hasHeader"] = true;
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5091InsertTableToWordplaceholderPrefix != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordplaceholderPrefix);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (__workflow_dtoRequestV5091InsertTableToWordplaceholderSuffix != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5091InsertTableToWordplaceholderSuffix);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5091InsertTableToWord;
                }

                return new ApiConnectionAction<DtoResponseV5091InsertTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertTextToPowerPoint(Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointexistingFileContent, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderName, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderText = null, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV9010InsertTextToPowerPointexistingFileContent = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointexistingFileContent, nameof(dtoRequestV9010InsertTextToPowerPointexistingFileContent), required: true);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderName = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderName, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderName), required: true);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderText = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderText, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderText), required: false);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix), required: false);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V9010_InsertTextToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV9010InsertTextToPowerPoint = new JObject();
                var dtoRequestV9010InsertTextToPowerPointpropCount = 0;
                dtoRequestV9010InsertTextToPowerPointpropCount++;
                dtoRequestV9010InsertTextToPowerPoint["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9010InsertTextToPowerPointexistingFileContent);
                dtoRequestV9010InsertTextToPowerPointpropCount++;
                dtoRequestV9010InsertTextToPowerPoint["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderName);
                if (__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderText != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderText);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderPrefix != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderPrefix);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderSuffix != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV9010InsertTextToPowerPointplaceholderSuffix);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (dtoRequestV9010InsertTextToPowerPointpropCount > 0)
                {
                    callPayload.Body = dtoRequestV9010InsertTextToPowerPoint;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5071InsertTextToWord> InsertTextToWord(Expression<Func<string>> dtoRequestV5071InsertTextToWordexistingFileContent, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderName, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderText = null, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV5071InsertTextToWordexistingFileContent = WorkflowExpression.Compile(dtoRequestV5071InsertTextToWordexistingFileContent, nameof(dtoRequestV5071InsertTextToWordexistingFileContent), required: true);
            var __workflow_dtoRequestV5071InsertTextToWordplaceholderName = WorkflowExpression.Compile(dtoRequestV5071InsertTextToWordplaceholderName, nameof(dtoRequestV5071InsertTextToWordplaceholderName), required: true);
            var __workflow_dtoRequestV5071InsertTextToWordplaceholderText = WorkflowExpression.Compile(dtoRequestV5071InsertTextToWordplaceholderText, nameof(dtoRequestV5071InsertTextToWordplaceholderText), required: false);
            var __workflow_dtoRequestV5071InsertTextToWordplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV5071InsertTextToWordplaceholderPrefix, nameof(dtoRequestV5071InsertTextToWordplaceholderPrefix), required: false);
            var __workflow_dtoRequestV5071InsertTextToWordplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV5071InsertTextToWordplaceholderSuffix, nameof(dtoRequestV5071InsertTextToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseV5071InsertTextToWord>(() =>
            {
                var apiCallPath = "/V5071_InsertTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5071InsertTextToWord = new JObject();
                var dtoRequestV5071InsertTextToWordpropCount = 0;
                dtoRequestV5071InsertTextToWordpropCount++;
                dtoRequestV5071InsertTextToWord["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5071InsertTextToWordexistingFileContent);
                dtoRequestV5071InsertTextToWordpropCount++;
                dtoRequestV5071InsertTextToWord["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5071InsertTextToWordplaceholderName);
                if (__workflow_dtoRequestV5071InsertTextToWordplaceholderText != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5071InsertTextToWordplaceholderText);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (__workflow_dtoRequestV5071InsertTextToWordplaceholderPrefix != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5071InsertTextToWordplaceholderPrefix);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (__workflow_dtoRequestV5071InsertTextToWordplaceholderSuffix != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5071InsertTextToWordplaceholderSuffix);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (dtoRequestV5071InsertTextToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5071InsertTextToWord;
                }

                return new ApiConnectionAction<DtoResponseV5071InsertTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4021MergePdfs> MergePdfs(Expression<Func<string>> dtoRequestV4021MergePdfsfile1, Expression<Func<string>> dtoRequestV4021MergePdfsfile2)
        {
            var __workflow_dtoRequestV4021MergePdfsfile1 = WorkflowExpression.Compile(dtoRequestV4021MergePdfsfile1, nameof(dtoRequestV4021MergePdfsfile1), required: true);
            var __workflow_dtoRequestV4021MergePdfsfile2 = WorkflowExpression.Compile(dtoRequestV4021MergePdfsfile2, nameof(dtoRequestV4021MergePdfsfile2), required: true);
            return new DeferredBodyAction<DtoResponseV4021MergePdfs>(() =>
            {
                var apiCallPath = "/V4021_MergePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4021MergePdfs = new JObject();
                var dtoRequestV4021MergePdfspropCount = 0;
                dtoRequestV4021MergePdfspropCount++;
                dtoRequestV4021MergePdfs["file1"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4021MergePdfsfile1);
                dtoRequestV4021MergePdfspropCount++;
                dtoRequestV4021MergePdfs["file2"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4021MergePdfsfile2);
                if (dtoRequestV4021MergePdfspropCount > 0)
                {
                    callPayload.Body = dtoRequestV4021MergePdfs;
                }

                return new ApiConnectionAction<DtoResponseV4021MergePdfs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck> PatternMatchCheck(Expression<Func<string>> dtoRequestV2120PatternMatchCheckinputText, Expression<Func<string>> dtoRequestV2120PatternMatchCheckmatchPattern)
        {
            var __workflow_dtoRequestV2120PatternMatchCheckinputText = WorkflowExpression.Compile(dtoRequestV2120PatternMatchCheckinputText, nameof(dtoRequestV2120PatternMatchCheckinputText), required: true);
            var __workflow_dtoRequestV2120PatternMatchCheckmatchPattern = WorkflowExpression.Compile(dtoRequestV2120PatternMatchCheckmatchPattern, nameof(dtoRequestV2120PatternMatchCheckmatchPattern), required: true);
            return new DeferredBodyAction<DtoResponseV2120MatchPatternCheck>(() =>
            {
                var apiCallPath = "/V2120_PatternMatchCheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2120PatternMatchCheck = new JObject();
                var dtoRequestV2120PatternMatchCheckpropCount = 0;
                dtoRequestV2120PatternMatchCheckpropCount++;
                dtoRequestV2120PatternMatchCheck["inputText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2120PatternMatchCheckinputText);
                dtoRequestV2120PatternMatchCheckpropCount++;
                dtoRequestV2120PatternMatchCheck["matchPattern"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2120PatternMatchCheckmatchPattern);
                if (dtoRequestV2120PatternMatchCheckpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2120PatternMatchCheck;
                }

                return new ApiConnectionAction<DtoResponseV2120MatchPatternCheck>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> PdfMetadata(Expression<Func<string>> dtoRequestV4031PdfMetadatafile)
        {
            var __workflow_dtoRequestV4031PdfMetadatafile = WorkflowExpression.Compile(dtoRequestV4031PdfMetadatafile, nameof(dtoRequestV4031PdfMetadatafile), required: true);
            return new DeferredBodyAction<DtoResponseV4031PdfMetadata>(() =>
            {
                var apiCallPath = "/V4031_PdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4031PdfMetadata = new JObject();
                var dtoRequestV4031PdfMetadatapropCount = 0;
                dtoRequestV4031PdfMetadatapropCount++;
                dtoRequestV4031PdfMetadata["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4031PdfMetadatafile);
                if (dtoRequestV4031PdfMetadatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV4031PdfMetadata;
                }

                return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4041ProtectPdf> ProtectPdf(Expression<Func<string>> dtoRequestV4041ProtectPdffile, Expression<Func<string>> dtoRequestV4041ProtectPdfownerPassword = null, Expression<Func<string>> dtoRequestV4041ProtectPdfuserPassword = null)
        {
            var __workflow_dtoRequestV4041ProtectPdffile = WorkflowExpression.Compile(dtoRequestV4041ProtectPdffile, nameof(dtoRequestV4041ProtectPdffile), required: true);
            var __workflow_dtoRequestV4041ProtectPdfownerPassword = WorkflowExpression.Compile(dtoRequestV4041ProtectPdfownerPassword, nameof(dtoRequestV4041ProtectPdfownerPassword), required: false);
            var __workflow_dtoRequestV4041ProtectPdfuserPassword = WorkflowExpression.Compile(dtoRequestV4041ProtectPdfuserPassword, nameof(dtoRequestV4041ProtectPdfuserPassword), required: false);
            return new DeferredBodyAction<DtoResponseV4041ProtectPdf>(() =>
            {
                var apiCallPath = "/V4041_ProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4041ProtectPdf = new JObject();
                var dtoRequestV4041ProtectPdfpropCount = 0;
                dtoRequestV4041ProtectPdfpropCount++;
                dtoRequestV4041ProtectPdf["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4041ProtectPdffile);
                if (__workflow_dtoRequestV4041ProtectPdfownerPassword != null)
                {
                    dtoRequestV4041ProtectPdf["ownerPassword"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4041ProtectPdfownerPassword);
                    dtoRequestV4041ProtectPdfpropCount++;
                }

                if (__workflow_dtoRequestV4041ProtectPdfuserPassword != null)
                {
                    dtoRequestV4041ProtectPdf["userPassword"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4041ProtectPdfuserPassword);
                    dtoRequestV4041ProtectPdfpropCount++;
                }

                if (dtoRequestV4041ProtectPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV4041ProtectPdf;
                }

                return new ApiConnectionAction<DtoResponseV4041ProtectPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode> ReadCode(Expression<Func<string>> dtoRequestReadCodeDataqROrBarcode)
        {
            var __workflow_dtoRequestReadCodeDataqROrBarcode = WorkflowExpression.Compile(dtoRequestReadCodeDataqROrBarcode, nameof(dtoRequestReadCodeDataqROrBarcode), required: true);
            return new DeferredBodyAction<DtoResponseV3051ReadCode>(() =>
            {
                var apiCallPath = "/V3051_ReadCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestReadCodeData = new JObject();
                var dtoRequestReadCodeDatapropCount = 0;
                dtoRequestReadCodeDatapropCount++;
                dtoRequestReadCodeData["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestReadCodeDataqROrBarcode);
                if (dtoRequestReadCodeDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestReadCodeData;
                }

                return new ApiConnectionAction<DtoResponseV3051ReadCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression> RegularExpression(Expression<Func<string>> dtoRequestV2011RegularExpressiontextToMatch, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpression = null, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpressionOption = null)
        {
            var __workflow_dtoRequestV2011RegularExpressiontextToMatch = WorkflowExpression.Compile(dtoRequestV2011RegularExpressiontextToMatch, nameof(dtoRequestV2011RegularExpressiontextToMatch), required: true);
            var __workflow_dtoRequestV2011RegularExpressionregularExpression = WorkflowExpression.Compile(dtoRequestV2011RegularExpressionregularExpression, nameof(dtoRequestV2011RegularExpressionregularExpression), required: false);
            var __workflow_dtoRequestV2011RegularExpressionregularExpressionOption = WorkflowExpression.Compile(dtoRequestV2011RegularExpressionregularExpressionOption, nameof(dtoRequestV2011RegularExpressionregularExpressionOption), required: false);
            return new DeferredBodyAction<DtoResponseV2011RegularExpression>(() =>
            {
                var apiCallPath = "/V2011_RegularExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2011RegularExpression = new JObject();
                var dtoRequestV2011RegularExpressionpropCount = 0;
                dtoRequestV2011RegularExpressionpropCount++;
                dtoRequestV2011RegularExpression["input"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2011RegularExpressiontextToMatch);
                if (__workflow_dtoRequestV2011RegularExpressionregularExpression != null)
                {
                    dtoRequestV2011RegularExpression["pattern"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2011RegularExpressionregularExpression);
                    dtoRequestV2011RegularExpressionpropCount++;
                }

                if (__workflow_dtoRequestV2011RegularExpressionregularExpressionOption != null)
                {
                    dtoRequestV2011RegularExpression["option"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2011RegularExpressionregularExpressionOption);
                    dtoRequestV2011RegularExpressionpropCount++;
                }

                if (dtoRequestV2011RegularExpressionpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2011RegularExpression;
                }

                return new ApiConnectionAction<DtoResponseV2011RegularExpression>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4110RemovePagesFromPdf> RemovePagesFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<string>> dtoRequestpages, Expression<Func<bool>> dtoRequestinputIs1Based = null, Expression<Func<int>> dtoRequestmode = null, Expression<Func<bool>> dtoRequestfailIfPageOutOfRange = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestpages = WorkflowExpression.Compile(dtoRequestpages, nameof(dtoRequestpages), required: true);
            var __workflow_dtoRequestinputIs1Based = WorkflowExpression.Compile(dtoRequestinputIs1Based, nameof(dtoRequestinputIs1Based), required: false);
            var __workflow_dtoRequestmode = WorkflowExpression.Compile(dtoRequestmode, nameof(dtoRequestmode), required: false);
            var __workflow_dtoRequestfailIfPageOutOfRange = WorkflowExpression.Compile(dtoRequestfailIfPageOutOfRange, nameof(dtoRequestfailIfPageOutOfRange), required: false);
            return new DeferredBodyAction<DtoResponseV4110RemovePagesFromPdf>(() =>
            {
                var apiCallPath = "/V4110_RemovePagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDF);
                dtoRequestpropCount++;
                dtoRequest["pages"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpages);
                if (__workflow_dtoRequestinputIs1Based != null)
                {
                    dtoRequest["oneBased"] = ExpressionConverter.ConvertO(__workflow_dtoRequestinputIs1Based);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmode != null)
                {
                    dtoRequest["mode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmode);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfailIfPageOutOfRange != null)
                {
                    dtoRequest["strict"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfailIfPageOutOfRange);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4110RemovePagesFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern> ReplaceTextWithPattern(Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatterninputText, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternsearchPattern, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
        {
            var __workflow_dtoRequestV2110ReplaceTextWithPatterninputText = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPatterninputText, nameof(dtoRequestV2110ReplaceTextWithPatterninputText), required: true);
            var __workflow_dtoRequestV2110ReplaceTextWithPatternsearchPattern = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPatternsearchPattern, nameof(dtoRequestV2110ReplaceTextWithPatternsearchPattern), required: true);
            var __workflow_dtoRequestV2110ReplaceTextWithPatternreplacementText = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPatternreplacementText, nameof(dtoRequestV2110ReplaceTextWithPatternreplacementText), required: false);
            return new DeferredBodyAction<DtoResponseV2110ReplaceTextWithPattern>(() =>
            {
                var apiCallPath = "/V2110_ReplaceTextWithPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2110ReplaceTextWithPattern = new JObject();
                var dtoRequestV2110ReplaceTextWithPatternpropCount = 0;
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
                dtoRequestV2110ReplaceTextWithPattern["inputText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2110ReplaceTextWithPatterninputText);
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
                dtoRequestV2110ReplaceTextWithPattern["searchPattern"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2110ReplaceTextWithPatternsearchPattern);
                if (__workflow_dtoRequestV2110ReplaceTextWithPatternreplacementText != null)
                {
                    dtoRequestV2110ReplaceTextWithPattern["replacementText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2110ReplaceTextWithPatternreplacementText);
                    dtoRequestV2110ReplaceTextWithPatternpropCount++;
                }

                if (dtoRequestV2110ReplaceTextWithPatternpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2110ReplaceTextWithPattern;
                }

                return new ApiConnectionAction<DtoResponseV2110ReplaceTextWithPattern>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3022ResizeImage> ResizeImage(Expression<Func<string>> dtoRequestV3022ResizeImageimageFile, Expression<Func<double>> dtoRequestV3022ResizeImageimageWidth = null, Expression<Func<double>> dtoRequestV3022ResizeImageimageHeight = null, Expression<Func<string>> dtoRequestV3022ResizeImageresizeBy = null)
        {
            var __workflow_dtoRequestV3022ResizeImageimageFile = WorkflowExpression.Compile(dtoRequestV3022ResizeImageimageFile, nameof(dtoRequestV3022ResizeImageimageFile), required: true);
            var __workflow_dtoRequestV3022ResizeImageimageWidth = WorkflowExpression.Compile(dtoRequestV3022ResizeImageimageWidth, nameof(dtoRequestV3022ResizeImageimageWidth), required: false);
            var __workflow_dtoRequestV3022ResizeImageimageHeight = WorkflowExpression.Compile(dtoRequestV3022ResizeImageimageHeight, nameof(dtoRequestV3022ResizeImageimageHeight), required: false);
            var __workflow_dtoRequestV3022ResizeImageresizeBy = WorkflowExpression.Compile(dtoRequestV3022ResizeImageresizeBy, nameof(dtoRequestV3022ResizeImageresizeBy), required: false);
            return new DeferredBodyAction<DtoResponseV3022ResizeImage>(() =>
            {
                var apiCallPath = "/V3022_ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3022ResizeImage = new JObject();
                var dtoRequestV3022ResizeImagepropCount = 0;
                dtoRequestV3022ResizeImagepropCount++;
                dtoRequestV3022ResizeImage["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3022ResizeImageimageFile);
                if (__workflow_dtoRequestV3022ResizeImageimageWidth != null)
                {
                    dtoRequestV3022ResizeImage["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3022ResizeImageimageWidth);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (__workflow_dtoRequestV3022ResizeImageimageHeight != null)
                {
                    dtoRequestV3022ResizeImage["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3022ResizeImageimageHeight);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (__workflow_dtoRequestV3022ResizeImageresizeBy != null)
                {
                    dtoRequestV3022ResizeImage["resizeBy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3022ResizeImageresizeBy);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (dtoRequestV3022ResizeImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3022ResizeImage;
                }

                return new ApiConnectionAction<DtoResponseV3022ResizeImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3031RotateImage> RotateImage(Expression<Func<string>> dtoRequestV3031RotateImageimageFile, Expression<Func<double>> dtoRequestV3031RotateImagerotate = null, Expression<Func<string>> dtoRequestV3031RotateImageoutputFormat = null)
        {
            var __workflow_dtoRequestV3031RotateImageimageFile = WorkflowExpression.Compile(dtoRequestV3031RotateImageimageFile, nameof(dtoRequestV3031RotateImageimageFile), required: true);
            var __workflow_dtoRequestV3031RotateImagerotate = WorkflowExpression.Compile(dtoRequestV3031RotateImagerotate, nameof(dtoRequestV3031RotateImagerotate), required: false);
            var __workflow_dtoRequestV3031RotateImageoutputFormat = WorkflowExpression.Compile(dtoRequestV3031RotateImageoutputFormat, nameof(dtoRequestV3031RotateImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV3031RotateImage>(() =>
            {
                var apiCallPath = "/V3031_RotateImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3031RotateImage = new JObject();
                var dtoRequestV3031RotateImagepropCount = 0;
                dtoRequestV3031RotateImagepropCount++;
                dtoRequestV3031RotateImage["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3031RotateImageimageFile);
                if (__workflow_dtoRequestV3031RotateImagerotate != null)
                {
                    dtoRequestV3031RotateImage["rotate"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3031RotateImagerotate);
                    dtoRequestV3031RotateImagepropCount++;
                }

                if (__workflow_dtoRequestV3031RotateImageoutputFormat != null)
                {
                    dtoRequestV3031RotateImage["outFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV3031RotateImageoutputFormat);
                    dtoRequestV3031RotateImagepropCount++;
                }

                if (dtoRequestV3031RotateImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3031RotateImage;
                }

                return new ApiConnectionAction<DtoResponseV3031RotateImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2151RunCode> RunCode(Expression<Func<string>> dtopythonOrJavaScriptCode, Expression<Func<int>> dtoruntime = null, Expression<Func<int>> dtotimeoutSeconds = null, Expression<Func<bool>> dtoprintLastExpression = null)
        {
            var __workflow_dtopythonOrJavaScriptCode = WorkflowExpression.Compile(dtopythonOrJavaScriptCode, nameof(dtopythonOrJavaScriptCode), required: true);
            var __workflow_dtoruntime = WorkflowExpression.Compile(dtoruntime, nameof(dtoruntime), required: false);
            var __workflow_dtotimeoutSeconds = WorkflowExpression.Compile(dtotimeoutSeconds, nameof(dtotimeoutSeconds), required: false);
            var __workflow_dtoprintLastExpression = WorkflowExpression.Compile(dtoprintLastExpression, nameof(dtoprintLastExpression), required: false);
            return new DeferredBodyAction<DtoResponseV2151RunCode>(() =>
            {
                var apiCallPath = "/V2151_RunCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dto = new JObject();
                var dtopropCount = 0;
                dtopropCount++;
                dto["code"] = ExpressionConverter.ConvertO(__workflow_dtopythonOrJavaScriptCode);
                if (__workflow_dtoruntime != null)
                {
                    dto["runtime"] = ExpressionConverter.ConvertO(__workflow_dtoruntime);
                    dtopropCount++;
                }

                if (__workflow_dtotimeoutSeconds != null)
                {
                    dto["timeoutSec"] = ExpressionConverter.ConvertO(__workflow_dtotimeoutSeconds);
                    dtopropCount++;
                }

                if (__workflow_dtoprintLastExpression != null)
                {
                    dto["printLastExpression"] = ExpressionConverter.ConvertO(__workflow_dtoprintLastExpression);
                    dtopropCount++;
                }

                if (dtopropCount > 0)
                {
                    callPayload.Body = dto;
                }

                return new ApiConnectionAction<DtoResponseV2151RunCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit> SmartTextSplit(Expression<Func<string>> dtoRequestV2130SmartTextSplitinputText, Expression<Func<string>> dtoRequestV2130SmartTextSplitsplitPattern = null, Expression<Func<bool>> dtoRequestV2130SmartTextSplittrimEnabled = null, Expression<Func<string>> dtoRequestV2130SmartTextSplittrimStrings = null)
        {
            var __workflow_dtoRequestV2130SmartTextSplitinputText = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplitinputText, nameof(dtoRequestV2130SmartTextSplitinputText), required: true);
            var __workflow_dtoRequestV2130SmartTextSplitsplitPattern = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplitsplitPattern, nameof(dtoRequestV2130SmartTextSplitsplitPattern), required: false);
            var __workflow_dtoRequestV2130SmartTextSplittrimEnabled = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplittrimEnabled, nameof(dtoRequestV2130SmartTextSplittrimEnabled), required: false);
            var __workflow_dtoRequestV2130SmartTextSplittrimStrings = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplittrimStrings, nameof(dtoRequestV2130SmartTextSplittrimStrings), required: false);
            return new DeferredBodyAction<DtoResponseV2130SmartTextSplit>(() =>
            {
                var apiCallPath = "/V2130_SmartTextSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2130SmartTextSplit = new JObject();
                var dtoRequestV2130SmartTextSplitpropCount = 0;
                dtoRequestV2130SmartTextSplitpropCount++;
                dtoRequestV2130SmartTextSplit["inputText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2130SmartTextSplitinputText);
                if (__workflow_dtoRequestV2130SmartTextSplitsplitPattern != null)
                {
                    dtoRequestV2130SmartTextSplit["splitPattern"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2130SmartTextSplitsplitPattern);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (__workflow_dtoRequestV2130SmartTextSplittrimEnabled != null)
                {
                    dtoRequestV2130SmartTextSplit["trimEnabled"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2130SmartTextSplittrimEnabled);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (__workflow_dtoRequestV2130SmartTextSplittrimStrings != null)
                {
                    dtoRequestV2130SmartTextSplit["trimStrings"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2130SmartTextSplittrimStrings);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (dtoRequestV2130SmartTextSplitpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2130SmartTextSplit;
                }

                return new ApiConnectionAction<DtoResponseV2130SmartTextSplit>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv> SortCsv(Expression<Func<string>> dtoRequestV2061SortCsvcSV, Expression<Func<bool>> dtoRequestV2061SortCsvcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV2061SortCsvremoveEmptyRows = null, Expression<Func<int>> dtoRequestV2061SortCsvskipANumberOfRows = null, Expression<Func<int>> dtoRequestV2061SortCsvstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV2061SortCsvseparator = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, Expression<Func<string>> dtoRequestV2061SortCsvsortColumn = null, Expression<Func<string>> dtoRequestV2061SortCsvfurtherSortingColumn = null, Expression<Func<bool>> dtoRequestV2061SortCsvreverseOrder = null)
        {
            var __workflow_dtoRequestV2061SortCsvcSV = WorkflowExpression.Compile(dtoRequestV2061SortCsvcSV, nameof(dtoRequestV2061SortCsvcSV), required: true);
            var __workflow_dtoRequestV2061SortCsvcSVHasHeaders = WorkflowExpression.Compile(dtoRequestV2061SortCsvcSVHasHeaders, nameof(dtoRequestV2061SortCsvcSVHasHeaders), required: false);
            var __workflow_dtoRequestV2061SortCsvautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestV2061SortCsvautoDetectFieldTypes, nameof(dtoRequestV2061SortCsvautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = WorkflowExpression.Compile(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection), required: false);
            var __workflow_dtoRequestV2061SortCsvremoveEmptyRows = WorkflowExpression.Compile(dtoRequestV2061SortCsvremoveEmptyRows, nameof(dtoRequestV2061SortCsvremoveEmptyRows), required: false);
            var __workflow_dtoRequestV2061SortCsvskipANumberOfRows = WorkflowExpression.Compile(dtoRequestV2061SortCsvskipANumberOfRows, nameof(dtoRequestV2061SortCsvskipANumberOfRows), required: false);
            var __workflow_dtoRequestV2061SortCsvstopAtASpecificRow = WorkflowExpression.Compile(dtoRequestV2061SortCsvstopAtASpecificRow, nameof(dtoRequestV2061SortCsvstopAtASpecificRow), required: false);
            var __workflow_dtoRequestV2061SortCsvseparator = WorkflowExpression.Compile(dtoRequestV2061SortCsvseparator, nameof(dtoRequestV2061SortCsvseparator), required: false);
            var __workflow_dtoRequestV2061SortCsvautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestV2061SortCsvautoDetectQuoteDelimiter, nameof(dtoRequestV2061SortCsvautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestV2061SortCsvsortColumn = WorkflowExpression.Compile(dtoRequestV2061SortCsvsortColumn, nameof(dtoRequestV2061SortCsvsortColumn), required: false);
            var __workflow_dtoRequestV2061SortCsvfurtherSortingColumn = WorkflowExpression.Compile(dtoRequestV2061SortCsvfurtherSortingColumn, nameof(dtoRequestV2061SortCsvfurtherSortingColumn), required: false);
            var __workflow_dtoRequestV2061SortCsvreverseOrder = WorkflowExpression.Compile(dtoRequestV2061SortCsvreverseOrder, nameof(dtoRequestV2061SortCsvreverseOrder), required: false);
            return new DeferredBodyAction<DtoResponseV2061SortCsv>(() =>
            {
                var apiCallPath = "/V2061_SortCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2061SortCsv = new JObject();
                var dtoRequestV2061SortCsvpropCount = 0;
                dtoRequestV2061SortCsvpropCount++;
                dtoRequestV2061SortCsv["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvcSV);
                if (__workflow_dtoRequestV2061SortCsvcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestV2061SortCsvcSVHasHeaders != null)
                    {
                        dtoRequestV2061SortCsv["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvcSVHasHeaders);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["dataIncludesHeader"] = true;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestV2061SortCsvautoDetectFieldTypes != null)
                    {
                        dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvautoDetectFieldTypes);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = false;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequestV2061SortCsv["maxScanRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestV2061SortCsvremoveEmptyRows != null)
                    {
                        dtoRequestV2061SortCsv["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvremoveEmptyRows);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["ignoreEmptyLine"] = true;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvskipANumberOfRows != null)
                {
                    dtoRequestV2061SortCsv["skip"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvskipANumberOfRows);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvstopAtASpecificRow != null)
                {
                    dtoRequestV2061SortCsv["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvstopAtASpecificRow);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvseparator != null)
                {
                    dtoRequestV2061SortCsv["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvseparator);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV2061SortCsv["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvautoDetectQuoteDelimiter);
                        dtoRequestV2061SortCsvpropCount++;
                    }

                    dtoRequestV2061SortCsvpropCount++;
                }
                else
                {
                    dtoRequestV2061SortCsv["mayHaveQuotedFields"] = true;
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvsortColumn != null)
                {
                    dtoRequestV2061SortCsv["sortColumn"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvsortColumn);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvfurtherSortingColumn != null)
                {
                    dtoRequestV2061SortCsv["secondSortColumn"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvfurtherSortingColumn);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (__workflow_dtoRequestV2061SortCsvreverseOrder != null)
                {
                    if (__workflow_dtoRequestV2061SortCsvreverseOrder != null)
                    {
                        dtoRequestV2061SortCsv["isReverse"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsvreverseOrder);
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

                return new ApiConnectionAction<DtoResponseV2061SortCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2051SortJson> SortJson(Expression<Func<string>> dtoRequestV2051SortJsonjSON, Expression<Func<string>> dtoRequestV2051SortJsonsortProperty = null, Expression<Func<string>> dtoRequestV2051SortJsonfurtherSortingProperty = null, Expression<Func<bool>> dtoRequestV2051SortJsonreverseOrder = null)
        {
            var __workflow_dtoRequestV2051SortJsonjSON = WorkflowExpression.Compile(dtoRequestV2051SortJsonjSON, nameof(dtoRequestV2051SortJsonjSON), required: true);
            var __workflow_dtoRequestV2051SortJsonsortProperty = WorkflowExpression.Compile(dtoRequestV2051SortJsonsortProperty, nameof(dtoRequestV2051SortJsonsortProperty), required: false);
            var __workflow_dtoRequestV2051SortJsonfurtherSortingProperty = WorkflowExpression.Compile(dtoRequestV2051SortJsonfurtherSortingProperty, nameof(dtoRequestV2051SortJsonfurtherSortingProperty), required: false);
            var __workflow_dtoRequestV2051SortJsonreverseOrder = WorkflowExpression.Compile(dtoRequestV2051SortJsonreverseOrder, nameof(dtoRequestV2051SortJsonreverseOrder), required: false);
            return new DeferredBodyAction<DtoResponseV2051SortJson>(() =>
            {
                var apiCallPath = "/V2051_SortJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2051SortJson = new JObject();
                var dtoRequestV2051SortJsonpropCount = 0;
                dtoRequestV2051SortJsonpropCount++;
                dtoRequestV2051SortJson["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2051SortJsonjSON);
                if (__workflow_dtoRequestV2051SortJsonsortProperty != null)
                {
                    dtoRequestV2051SortJson["sortProperty"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2051SortJsonsortProperty);
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (__workflow_dtoRequestV2051SortJsonfurtherSortingProperty != null)
                {
                    dtoRequestV2051SortJson["secondSortProperty"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2051SortJsonfurtherSortingProperty);
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (__workflow_dtoRequestV2051SortJsonreverseOrder != null)
                {
                    if (__workflow_dtoRequestV2051SortJsonreverseOrder != null)
                    {
                        dtoRequestV2051SortJson["isReverse"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2051SortJsonreverseOrder);
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

                return new ApiConnectionAction<DtoResponseV2051SortJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2041Translate> Translate(Expression<Func<string>> dtoRequestV2041Translatetext, Expression<Func<string>> dtoRequestV2041Translateto, Expression<Func<string>> dtoRequestV2041Translatefrom = null)
        {
            var __workflow_dtoRequestV2041Translatetext = WorkflowExpression.Compile(dtoRequestV2041Translatetext, nameof(dtoRequestV2041Translatetext), required: true);
            var __workflow_dtoRequestV2041Translateto = WorkflowExpression.Compile(dtoRequestV2041Translateto, nameof(dtoRequestV2041Translateto), required: true);
            var __workflow_dtoRequestV2041Translatefrom = WorkflowExpression.Compile(dtoRequestV2041Translatefrom, nameof(dtoRequestV2041Translatefrom), required: false);
            return new DeferredBodyAction<DtoResponseV2041Translate>(() =>
            {
                var apiCallPath = "/V2041_Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2041Translate = new JObject();
                var dtoRequestV2041TranslatepropCount = 0;
                dtoRequestV2041TranslatepropCount++;
                dtoRequestV2041Translate["text"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2041Translatetext);
                if (__workflow_dtoRequestV2041Translatefrom != null)
                {
                    dtoRequestV2041Translate["from"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2041Translatefrom);
                    dtoRequestV2041TranslatepropCount++;
                }

                dtoRequestV2041TranslatepropCount++;
                dtoRequestV2041Translate["to"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2041Translateto);
                if (dtoRequestV2041TranslatepropCount > 0)
                {
                    callPayload.Body = dtoRequestV2041Translate;
                }

                return new ApiConnectionAction<DtoResponseV2041Translate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4051UnProtectPdf> UnProtectPdf(Expression<Func<string>> dtoRequestV4051UnProtectPdffile, Expression<Func<string>> dtoRequestV4051UnProtectPdfownerPassword = null, Expression<Func<bool>> dtoRequestV4051UnProtectPdfremovePermissions = null)
        {
            var __workflow_dtoRequestV4051UnProtectPdffile = WorkflowExpression.Compile(dtoRequestV4051UnProtectPdffile, nameof(dtoRequestV4051UnProtectPdffile), required: true);
            var __workflow_dtoRequestV4051UnProtectPdfownerPassword = WorkflowExpression.Compile(dtoRequestV4051UnProtectPdfownerPassword, nameof(dtoRequestV4051UnProtectPdfownerPassword), required: false);
            var __workflow_dtoRequestV4051UnProtectPdfremovePermissions = WorkflowExpression.Compile(dtoRequestV4051UnProtectPdfremovePermissions, nameof(dtoRequestV4051UnProtectPdfremovePermissions), required: false);
            return new DeferredBodyAction<DtoResponseV4051UnProtectPdf>(() =>
            {
                var apiCallPath = "/V4051_UnProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4051UnProtectPdf = new JObject();
                var dtoRequestV4051UnProtectPdfpropCount = 0;
                dtoRequestV4051UnProtectPdfpropCount++;
                dtoRequestV4051UnProtectPdf["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4051UnProtectPdffile);
                if (__workflow_dtoRequestV4051UnProtectPdfownerPassword != null)
                {
                    dtoRequestV4051UnProtectPdf["ownerPassword"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4051UnProtectPdfownerPassword);
                    dtoRequestV4051UnProtectPdfpropCount++;
                }

                if (__workflow_dtoRequestV4051UnProtectPdfremovePermissions != null)
                {
                    dtoRequestV4051UnProtectPdf["removePermissions"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4051UnProtectPdfremovePermissions);
                    dtoRequestV4051UnProtectPdfpropCount++;
                }

                if (dtoRequestV4051UnProtectPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV4051UnProtectPdf;
                }

                return new ApiConnectionAction<DtoResponseV4051UnProtectPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> UpdateMultipleWordContentControls(Expression<Func<string>> dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, Expression<Func<ContentControl[]>> dtoRequestV5150UpdateMultipleWordContentControlscontentControl)
        {
            var __workflow_dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent = WorkflowExpression.Compile(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, nameof(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent), required: true);
            var __workflow_dtoRequestV5150UpdateMultipleWordContentControlscontentControl = WorkflowExpression.Compile(dtoRequestV5150UpdateMultipleWordContentControlscontentControl, nameof(dtoRequestV5150UpdateMultipleWordContentControlscontentControl), required: true);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V5150_UpdateMultipleWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5150UpdateMultipleWordContentControls = new JObject();
                var dtoRequestV5150UpdateMultipleWordContentControlspropCount = 0;
                dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
                dtoRequestV5150UpdateMultipleWordContentControls["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent);
                dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
                dtoRequestV5150UpdateMultipleWordContentControls["contentControls"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5150UpdateMultipleWordContentControlscontentControl);
                if (dtoRequestV5150UpdateMultipleWordContentControlspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5150UpdateMultipleWordContentControls;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> UpdateWordContentControl(Expression<Func<string>> dtoRequestV5140UpdateWordContentControlexistingFileContent, Expression<Func<string>> dtoRequestV5140UpdateWordContentControlname, Expression<Func<string>> dtoRequestV5140UpdateWordContentControlvalue = null)
        {
            var __workflow_dtoRequestV5140UpdateWordContentControlexistingFileContent = WorkflowExpression.Compile(dtoRequestV5140UpdateWordContentControlexistingFileContent, nameof(dtoRequestV5140UpdateWordContentControlexistingFileContent), required: true);
            var __workflow_dtoRequestV5140UpdateWordContentControlname = WorkflowExpression.Compile(dtoRequestV5140UpdateWordContentControlname, nameof(dtoRequestV5140UpdateWordContentControlname), required: true);
            var __workflow_dtoRequestV5140UpdateWordContentControlvalue = WorkflowExpression.Compile(dtoRequestV5140UpdateWordContentControlvalue, nameof(dtoRequestV5140UpdateWordContentControlvalue), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V5140_UpdateWordContentControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5140UpdateWordContentControl = new JObject();
                var dtoRequestV5140UpdateWordContentControlpropCount = 0;
                dtoRequestV5140UpdateWordContentControlpropCount++;
                dtoRequestV5140UpdateWordContentControl["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5140UpdateWordContentControlexistingFileContent);
                dtoRequestV5140UpdateWordContentControlpropCount++;
                dtoRequestV5140UpdateWordContentControl["name"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5140UpdateWordContentControlname);
                if (__workflow_dtoRequestV5140UpdateWordContentControlvalue != null)
                {
                    dtoRequestV5140UpdateWordContentControl["value"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5140UpdateWordContentControlvalue);
                    dtoRequestV5140UpdateWordContentControlpropCount++;
                }

                if (dtoRequestV5140UpdateWordContentControlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5140UpdateWordContentControl;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5130UpdateWordTableOfContents> UpdateWordTableOfContents(Expression<Func<string>> dtoRequestV5130UpdateWordTableOfContentsexistingFileContent)
        {
            var __workflow_dtoRequestV5130UpdateWordTableOfContentsexistingFileContent = WorkflowExpression.Compile(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent, nameof(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent), required: true);
            return new DeferredBodyAction<DtoResponseV5130UpdateWordTableOfContents>(() =>
            {
                var apiCallPath = "/V5130_UpdateWordTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5130UpdateWordTableOfContents = new JObject();
                var dtoRequestV5130UpdateWordTableOfContentspropCount = 0;
                dtoRequestV5130UpdateWordTableOfContentspropCount++;
                dtoRequestV5130UpdateWordTableOfContents["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5130UpdateWordTableOfContentsexistingFileContent);
                if (dtoRequestV5130UpdateWordTableOfContentspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5130UpdateWordTableOfContents;
                }

                return new ApiConnectionAction<DtoResponseV5130UpdateWordTableOfContents>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2031UrlToFile> UrlToFile(Expression<Func<string>> dtoRequestV2031UrlToFileuRL)
        {
            var __workflow_dtoRequestV2031UrlToFileuRL = WorkflowExpression.Compile(dtoRequestV2031UrlToFileuRL, nameof(dtoRequestV2031UrlToFileuRL), required: true);
            return new DeferredBodyAction<DtoResponseV2031UrlToFile>(() =>
            {
                var apiCallPath = "/V2031_UrlToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2031UrlToFile = new JObject();
                var dtoRequestV2031UrlToFilepropCount = 0;
                dtoRequestV2031UrlToFilepropCount++;
                dtoRequestV2031UrlToFile["url"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV2031UrlToFileuRL);
                if (dtoRequestV2031UrlToFilepropCount > 0)
                {
                    callPayload.Body = dtoRequestV2031UrlToFile;
                }

                return new ApiConnectionAction<DtoResponseV2031UrlToFile>(callPayload);
            });
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
