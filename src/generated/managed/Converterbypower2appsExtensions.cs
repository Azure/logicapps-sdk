//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Converterbypower2appsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5102AddHtmlToWord, ApiConnectionActionConfiguration> AddHtmlToWord(Expression<Func<string>> dtoRequesthTML, Expression<Func<string>> dtoRequestexistingFileContent = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesthTML = WorkflowExpression.Compile(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5102AddHtmlToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5102_AddHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTML);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5102AddHtmlToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5032AddImageToWord, ApiConnectionActionConfiguration> AddImageToWord(Expression<Func<string>> dtoRequestimage, Expression<Func<string>> dtoRequestexistingFileContent = null, Expression<Func<string>> dtoRequestcaptionText = null, Expression<Func<int>> dtoRequestmaximumImageWidth = null, Expression<Func<int>> dtoRequestmaximumImageHeight = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestimage = WorkflowExpression.Compile(dtoRequestimage, nameof(dtoRequestimage), required: true);
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            var __workflow_dtoRequestcaptionText = WorkflowExpression.Compile(dtoRequestcaptionText, nameof(dtoRequestcaptionText), required: false);
            var __workflow_dtoRequestmaximumImageWidth = WorkflowExpression.Compile(dtoRequestmaximumImageWidth, nameof(dtoRequestmaximumImageWidth), required: false);
            var __workflow_dtoRequestmaximumImageHeight = WorkflowExpression.Compile(dtoRequestmaximumImageHeight, nameof(dtoRequestmaximumImageHeight), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5032AddImageToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5032_AddImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimage);
                if (__workflow_dtoRequestcaptionText != null)
                {
                    dtoRequest["imageText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcaptionText);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaximumImageWidth != null)
                {
                    dtoRequest["maxWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaximumImageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaximumImageHeight != null)
                {
                    dtoRequest["maxHeight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaximumImageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5032AddImageToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5043AddImageWithinTableToWord, ApiConnectionActionConfiguration> AddImageWithinTableToWord(Expression<Func<string>> dtoRequestimage, Expression<Func<string>> dtoRequestexistingFileContent = null, Expression<Func<string>> dtoRequestdescriptionText = null, Expression<Func<int>> dtoRequestmaximumImageWidth = null, Expression<Func<int>> dtoRequestmaximumImageHeight = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestimage = WorkflowExpression.Compile(dtoRequestimage, nameof(dtoRequestimage), required: true);
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            var __workflow_dtoRequestdescriptionText = WorkflowExpression.Compile(dtoRequestdescriptionText, nameof(dtoRequestdescriptionText), required: false);
            var __workflow_dtoRequestmaximumImageWidth = WorkflowExpression.Compile(dtoRequestmaximumImageWidth, nameof(dtoRequestmaximumImageWidth), required: false);
            var __workflow_dtoRequestmaximumImageHeight = WorkflowExpression.Compile(dtoRequestmaximumImageHeight, nameof(dtoRequestmaximumImageHeight), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5043AddImageWithinTableToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5043_AddImageWithinTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimage);
                if (__workflow_dtoRequestdescriptionText != null)
                {
                    dtoRequest["imageText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestdescriptionText);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaximumImageWidth != null)
                {
                    dtoRequest["maxWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaximumImageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaximumImageHeight != null)
                {
                    dtoRequest["maxHeight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaximumImageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5043AddImageWithinTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5053AddTableToWord, ApiConnectionActionConfiguration> AddTableToWord(Expression<Func<string>> dtoRequesttableData, Expression<Func<string>> dtoRequestexistingFileContent = null, Expression<Func<bool>> dtoRequestshowHeaders = null, Expression<Func<string>> dtoRequesttableStyle = null, Expression<Func<string>> dtoRequesttableCaption = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesttableData = WorkflowExpression.Compile(dtoRequesttableData, nameof(dtoRequesttableData), required: true);
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            var __workflow_dtoRequestshowHeaders = WorkflowExpression.Compile(dtoRequestshowHeaders, nameof(dtoRequestshowHeaders), required: false);
            var __workflow_dtoRequesttableStyle = WorkflowExpression.Compile(dtoRequesttableStyle, nameof(dtoRequesttableStyle), required: false);
            var __workflow_dtoRequesttableCaption = WorkflowExpression.Compile(dtoRequesttableCaption, nameof(dtoRequesttableCaption), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5053AddTableToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5053_AddTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["table"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttableData);
                if (__workflow_dtoRequestshowHeaders != null)
                {
                    if (__workflow_dtoRequestshowHeaders != null)
                    {
                        dtoRequest["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestshowHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["hasHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttableStyle != null)
                {
                    if (__workflow_dtoRequesttableStyle != null)
                    {
                        dtoRequest["tableStyle"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttableStyle);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["tableStyle"] = "GridTable1Light";
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttableCaption != null)
                {
                    dtoRequest["tableText"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttableCaption);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5053AddTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5062AddTextToWord, ApiConnectionActionConfiguration> AddTextToWord(Expression<Func<string>> dtoRequesttype, Expression<Func<string>> dtoRequesttext, Expression<Func<string>> dtoRequestexistingFileContent = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesttype = WorkflowExpression.Compile(dtoRequesttype, nameof(dtoRequesttype), required: true);
            var __workflow_dtoRequesttext = WorkflowExpression.Compile(dtoRequesttext, nameof(dtoRequesttext), required: true);
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5062AddTextToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5062_AddTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["sectionType"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttype);
                dtoRequestpropCount++;
                dtoRequest["text"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttext);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5062AddTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs, ApiConnectionActionConfiguration> CombineCsvs(Expression<Func<string>> dtoRequestV2081CombineCsvsmainCSV, Expression<Func<string>> dtoRequestV2081CombineCsvscombineColumnName, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSV, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSVColumn = null)
        {
            var __workflow_dtoRequestV2081CombineCsvsmainCSV = WorkflowExpression.Compile(dtoRequestV2081CombineCsvsmainCSV, nameof(dtoRequestV2081CombineCsvsmainCSV), required: true);
            var __workflow_dtoRequestV2081CombineCsvscombineColumnName = WorkflowExpression.Compile(dtoRequestV2081CombineCsvscombineColumnName, nameof(dtoRequestV2081CombineCsvscombineColumnName), required: true);
            var __workflow_dtoRequestV2081CombineCsvssecondCSV = WorkflowExpression.Compile(dtoRequestV2081CombineCsvssecondCSV, nameof(dtoRequestV2081CombineCsvssecondCSV), required: true);
            var __workflow_dtoRequestV2081CombineCsvssecondCSVColumn = WorkflowExpression.Compile(dtoRequestV2081CombineCsvssecondCSVColumn, nameof(dtoRequestV2081CombineCsvssecondCSVColumn), required: false);
            return new DeferredBodyAction<DtoResponseV2081CombineCsvs, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays, ApiConnectionActionConfiguration> CombineJsonArrays(Expression<Func<string>> dtoRequestV2091CombineJsonArraysmainJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayscombinePropertyName, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
        {
            var __workflow_dtoRequestV2091CombineJsonArraysmainJSON = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArraysmainJSON, nameof(dtoRequestV2091CombineJsonArraysmainJSON), required: true);
            var __workflow_dtoRequestV2091CombineJsonArrayscombinePropertyName = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrayscombinePropertyName, nameof(dtoRequestV2091CombineJsonArrayscombinePropertyName), required: true);
            var __workflow_dtoRequestV2091CombineJsonArrayssecondJSON = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrayssecondJSON, nameof(dtoRequestV2091CombineJsonArrayssecondJSON), required: true);
            var __workflow_dtoRequestV2091CombineJsonArrayssecondJSONProperty = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrayssecondJSONProperty, nameof(dtoRequestV2091CombineJsonArrayssecondJSONProperty), required: false);
            return new DeferredBodyAction<DtoResponseV2091CombineJsonArrays, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV3042CompressImage, ApiConnectionActionConfiguration> CompressImage(Expression<Func<string>> dtoRequestimageFile, Expression<Func<int>> dtoRequestimageQuality = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestimageFile = WorkflowExpression.Compile(dtoRequestimageFile, nameof(dtoRequestimageFile), required: true);
            var __workflow_dtoRequestimageQuality = WorkflowExpression.Compile(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3042CompressImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3042_CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageFile);
                if (__workflow_dtoRequestimageQuality != null)
                {
                    dtoRequest["quality"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageQuality);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3042CompressImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4081CompressPdf, ApiConnectionActionConfiguration> CompressPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<bool>> dtoRequestcompressImages = null, Expression<Func<int>> dtoRequestimageQuality = null, Expression<Func<bool>> dtoRequestoptimizeFonts = null, Expression<Func<bool>> dtoRequestoptimizePageContents = null, Expression<Func<bool>> dtoRequestremoveMetadata = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestcompressImages = WorkflowExpression.Compile(dtoRequestcompressImages, nameof(dtoRequestcompressImages), required: false);
            var __workflow_dtoRequestimageQuality = WorkflowExpression.Compile(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            var __workflow_dtoRequestoptimizeFonts = WorkflowExpression.Compile(dtoRequestoptimizeFonts, nameof(dtoRequestoptimizeFonts), required: false);
            var __workflow_dtoRequestoptimizePageContents = WorkflowExpression.Compile(dtoRequestoptimizePageContents, nameof(dtoRequestoptimizePageContents), required: false);
            var __workflow_dtoRequestremoveMetadata = WorkflowExpression.Compile(dtoRequestremoveMetadata, nameof(dtoRequestremoveMetadata), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4081CompressPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4081_CompressPdf";
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

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4081CompressPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor, ApiConnectionActionConfiguration> ConvertColor(Expression<Func<string>> dtoRequestV2071ConvertColorcolor)
        {
            var __workflow_dtoRequestV2071ConvertColorcolor = WorkflowExpression.Compile(dtoRequestV2071ConvertColorcolor, nameof(dtoRequestV2071ConvertColorcolor), required: true);
            return new DeferredBodyAction<DtoResponseV2071ConvertColor, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1035ConvertCsvToExcel, ApiConnectionActionConfiguration> ConvertCsvToExcel(Expression<Func<string>> dtoRequestcSV, Expression<Func<bool>> dtoRequestcSVHasHeaders = null, Expression<Func<bool>> dtoRequestautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestremoveEmptyRows = null, Expression<Func<int>> dtoRequestskipANumberOfRows = null, Expression<Func<int>> dtoRequeststopAtASpecificRow = null, Expression<Func<string>> dtoRequestseparator = null, Expression<Func<bool>> dtoRequestautoDetectQuoteDelimiter = null, Expression<Func<int>> dtoRequestcSVInputEncoding = null, Expression<Func<bool>> dtoRequestadjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestwrapExcelColumnText = null, Expression<Func<int>> dtoRequestmaxExcelColumnWidth = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestcSV = WorkflowExpression.Compile(dtoRequestcSV, nameof(dtoRequestcSV), required: true);
            var __workflow_dtoRequestcSVHasHeaders = WorkflowExpression.Compile(dtoRequestcSVHasHeaders, nameof(dtoRequestcSVHasHeaders), required: false);
            var __workflow_dtoRequestautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestautoDetectFieldTypes, nameof(dtoRequestautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestnumberOfRowsForFieldTypeDetection = WorkflowExpression.Compile(dtoRequestnumberOfRowsForFieldTypeDetection, nameof(dtoRequestnumberOfRowsForFieldTypeDetection), required: false);
            var __workflow_dtoRequestremoveEmptyRows = WorkflowExpression.Compile(dtoRequestremoveEmptyRows, nameof(dtoRequestremoveEmptyRows), required: false);
            var __workflow_dtoRequestskipANumberOfRows = WorkflowExpression.Compile(dtoRequestskipANumberOfRows, nameof(dtoRequestskipANumberOfRows), required: false);
            var __workflow_dtoRequeststopAtASpecificRow = WorkflowExpression.Compile(dtoRequeststopAtASpecificRow, nameof(dtoRequeststopAtASpecificRow), required: false);
            var __workflow_dtoRequestseparator = WorkflowExpression.Compile(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            var __workflow_dtoRequestautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestautoDetectQuoteDelimiter, nameof(dtoRequestautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestcSVInputEncoding = WorkflowExpression.Compile(dtoRequestcSVInputEncoding, nameof(dtoRequestcSVInputEncoding), required: false);
            var __workflow_dtoRequestadjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestwrapExcelColumnText = WorkflowExpression.Compile(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            var __workflow_dtoRequestmaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV1035ConvertCsvToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1035_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSV);
                if (__workflow_dtoRequestcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestcSVHasHeaders != null)
                    {
                        dtoRequest["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSVHasHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["dataIncludesHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestautoDetectFieldTypes != null)
                    {
                        dtoRequest["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestautoDetectFieldTypes);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["autoDiscoverFieldTypes"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequest["maxScanRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestnumberOfRowsForFieldTypeDetection);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestremoveEmptyRows != null)
                    {
                        dtoRequest["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestremoveEmptyRows);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreEmptyLine"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestskipANumberOfRows != null)
                {
                    dtoRequest["skip"] = ExpressionConverter.ConvertO(__workflow_dtoRequestskipANumberOfRows);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequeststopAtASpecificRow != null)
                {
                    dtoRequest["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequeststopAtASpecificRow);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestautoDetectQuoteDelimiter != null)
                    {
                        dtoRequest["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestautoDetectQuoteDelimiter);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["mayHaveQuotedFields"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestcSVInputEncoding != null)
                {
                    dtoRequest["encoding"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSVInputEncoding);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1035ConvertCsvToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml, ApiConnectionActionConfiguration> ConvertCsvToHtmlTable(Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTablecSV, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
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
            return new DeferredBodyAction<DtoResponseHtml, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson, ApiConnectionActionConfiguration> ConvertCsvToJson(Expression<Func<string>> dtoRequestV1022ConvertCsvToJsoncSV, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1022ConvertCsvToJsonseparator = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
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
            return new DeferredBodyAction<DtoResponseV1022ConvertCsvToJson, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1150ConvertCsvToMarkdown, ApiConnectionActionConfiguration> ConvertCsvToMarkdown(Expression<Func<string>> dtoRequestcSV, Expression<Func<bool>> dtoRequestfirstRowIsTheHeader = null, Expression<Func<string>> dtoRequestseparator = null, Expression<Func<bool>> dtoRequestvaluesMayBeInQuotes = null, Expression<Func<bool>> dtoRequestskipEmptyLines = null, Expression<Func<string>> dtoRequestfileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestcSV = WorkflowExpression.Compile(dtoRequestcSV, nameof(dtoRequestcSV), required: true);
            var __workflow_dtoRequestfirstRowIsTheHeader = WorkflowExpression.Compile(dtoRequestfirstRowIsTheHeader, nameof(dtoRequestfirstRowIsTheHeader), required: false);
            var __workflow_dtoRequestseparator = WorkflowExpression.Compile(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            var __workflow_dtoRequestvaluesMayBeInQuotes = WorkflowExpression.Compile(dtoRequestvaluesMayBeInQuotes, nameof(dtoRequestvaluesMayBeInQuotes), required: false);
            var __workflow_dtoRequestskipEmptyLines = WorkflowExpression.Compile(dtoRequestskipEmptyLines, nameof(dtoRequestskipEmptyLines), required: false);
            var __workflow_dtoRequestfileName = WorkflowExpression.Compile(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV1150ConvertCsvToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1150_ConvertCsvToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSV);
                if (__workflow_dtoRequestfirstRowIsTheHeader != null)
                {
                    dtoRequest["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfirstRowIsTheHeader);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestvaluesMayBeInQuotes != null)
                {
                    dtoRequest["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestvaluesMayBeInQuotes);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestskipEmptyLines != null)
                {
                    dtoRequest["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestskipEmptyLines);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1150ConvertCsvToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson, ApiConnectionActionConfiguration> ConvertExcelToJson(Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonexcelFile, Expression<Func<bool>> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonstartCell = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonsheetName = null)
        {
            var __workflow_dtoRequestV1100ConvertExcelToJsonexcelFile = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonexcelFile, nameof(dtoRequestV1100ConvertExcelToJsonexcelFile), required: true);
            var __workflow_dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders, nameof(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders), required: false);
            var __workflow_dtoRequestV1100ConvertExcelToJsonstartCell = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonstartCell, nameof(dtoRequestV1100ConvertExcelToJsonstartCell), required: false);
            var __workflow_dtoRequestV1100ConvertExcelToJsonsheetName = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJsonsheetName, nameof(dtoRequestV1100ConvertExcelToJsonsheetName), required: false);
            return new DeferredBodyAction<DtoResponseV1100ConvertExcelToJson, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1140ConvertExcelToMarkdown, ApiConnectionActionConfiguration> ConvertExcelToMarkdown(Expression<Func<string>> dtoRequestexcel, Expression<Func<bool>> dtoRequestfirstRowIsTheHeader = null, Expression<Func<bool>> dtoRequestaddSheetNames = null, Expression<Func<string>> dtoRequestfileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestexcel = WorkflowExpression.Compile(dtoRequestexcel, nameof(dtoRequestexcel), required: true);
            var __workflow_dtoRequestfirstRowIsTheHeader = WorkflowExpression.Compile(dtoRequestfirstRowIsTheHeader, nameof(dtoRequestfirstRowIsTheHeader), required: false);
            var __workflow_dtoRequestaddSheetNames = WorkflowExpression.Compile(dtoRequestaddSheetNames, nameof(dtoRequestaddSheetNames), required: false);
            var __workflow_dtoRequestfileName = WorkflowExpression.Compile(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV1140ConvertExcelToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1140_ConvertExcelToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["excel"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexcel);
                if (__workflow_dtoRequestfirstRowIsTheHeader != null)
                {
                    dtoRequest["firstRowIsHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfirstRowIsTheHeader);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestaddSheetNames != null)
                {
                    dtoRequest["includeSheetNames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestaddSheetNames);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1140ConvertExcelToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4014ConvertFileToPdf, ApiConnectionActionConfiguration> ConvertFileToPdf(Expression<Func<string>> dtoRequestFile, Expression<Func<string>> dtoRequestoriginFileName = null, Expression<Func<string>> dtoRequestoriginFileExtension = null, Expression<Func<int>> dtoRequestconformanceLevel = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestFile = WorkflowExpression.Compile(dtoRequestFile, nameof(dtoRequestFile), required: true);
            var __workflow_dtoRequestoriginFileName = WorkflowExpression.Compile(dtoRequestoriginFileName, nameof(dtoRequestoriginFileName), required: false);
            var __workflow_dtoRequestoriginFileExtension = WorkflowExpression.Compile(dtoRequestoriginFileExtension, nameof(dtoRequestoriginFileExtension), required: false);
            var __workflow_dtoRequestconformanceLevel = WorkflowExpression.Compile(dtoRequestconformanceLevel, nameof(dtoRequestconformanceLevel), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4014ConvertFileToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4014_ConvertFileToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestFile);
                if (__workflow_dtoRequestoriginFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoriginFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoriginFileExtension != null)
                {
                    dtoRequest["fileExtension"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoriginFileExtension);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestconformanceLevel != null)
                {
                    dtoRequest["conformanceLevel"] = ExpressionConverter.ConvertO(__workflow_dtoRequestconformanceLevel);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4014ConvertFileToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv, ApiConnectionActionConfiguration> ConvertHtmlTableToCsv(Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
        {
            var __workflow_dtoRequestV7070ConvertHtmlTableToCsvhTMLTable = WorkflowExpression.Compile(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, nameof(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable), required: true);
            var __workflow_dtoRequestV7070ConvertHtmlTableToCsvseparator = WorkflowExpression.Compile(dtoRequestV7070ConvertHtmlTableToCsvseparator, nameof(dtoRequestV7070ConvertHtmlTableToCsvseparator), required: false);
            return new DeferredBodyAction<DtoResponseV7070ConvertHtmlTableToCsv, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV7082ConvertHtmlTableToExcel, ApiConnectionActionConfiguration> ConvertHtmlTableToExcel(Expression<Func<string>> dtoRequesthTMLTable, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesthTMLTable = WorkflowExpression.Compile(dtoRequesthTMLTable, nameof(dtoRequesthTMLTable), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV7082ConvertHtmlTableToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7082_ConvertHtmlTableToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["htmlTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTMLTable);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV7082ConvertHtmlTableToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7013ConvertHtmlTableToJson, ApiConnectionActionConfiguration> ConvertHtmlTableToJson(Expression<Func<string>> dtoRequesthTMLTable)
        {
            var __workflow_dtoRequesthTMLTable = WorkflowExpression.Compile(dtoRequesthTMLTable, nameof(dtoRequesthTMLTable), required: true);
            return new DeferredBodyAction<DtoResponseV7013ConvertHtmlTableToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7013_ConvertHtmlTableToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["htmlTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTMLTable);
                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV7013ConvertHtmlTableToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7032ConvertHtmlToImage, ApiConnectionActionConfiguration> ConvertHtmlToImage(Expression<Func<string>> dtoRequesthTML, Expression<Func<int>> dtoRequestwidth = null, Expression<Func<int>> dtoRequestheight = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesthTML = WorkflowExpression.Compile(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            var __workflow_dtoRequestwidth = WorkflowExpression.Compile(dtoRequestwidth, nameof(dtoRequestwidth), required: false);
            var __workflow_dtoRequestheight = WorkflowExpression.Compile(dtoRequestheight, nameof(dtoRequestheight), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV7032ConvertHtmlToImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7032_ConvertHtmlToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTML);
                if (__workflow_dtoRequestwidth != null)
                {
                    dtoRequest["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestheight != null)
                {
                    dtoRequest["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV7032ConvertHtmlToImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7090ConvertHtmlToMarkdown, ApiConnectionActionConfiguration> ConvertHtmlToMarkdown(Expression<Func<string>> dtoRequesthTML, Expression<Func<bool>> dtoRequestremoveMenusAndExtras = null, Expression<Func<bool>> dtoRequestkeepImagePlaceholders = null, Expression<Func<string>> dtoRequestfileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequesthTML = WorkflowExpression.Compile(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            var __workflow_dtoRequestremoveMenusAndExtras = WorkflowExpression.Compile(dtoRequestremoveMenusAndExtras, nameof(dtoRequestremoveMenusAndExtras), required: false);
            var __workflow_dtoRequestkeepImagePlaceholders = WorkflowExpression.Compile(dtoRequestkeepImagePlaceholders, nameof(dtoRequestkeepImagePlaceholders), required: false);
            var __workflow_dtoRequestfileName = WorkflowExpression.Compile(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV7090ConvertHtmlToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7090_ConvertHtmlToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTML);
                if (__workflow_dtoRequestremoveMenusAndExtras != null)
                {
                    dtoRequest["removeClutter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestremoveMenusAndExtras);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestkeepImagePlaceholders != null)
                {
                    dtoRequest["keepImagePlaceholders"] = ExpressionConverter.ConvertO(__workflow_dtoRequestkeepImagePlaceholders);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV7090ConvertHtmlToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7023ConvertHtmlToPdf, ApiConnectionActionConfiguration> ConvertHtmlToPdf(Expression<Func<string>> dtoRequesthTML, Expression<Func<bool>> dtoRequestlandscapeFormat = null, Expression<Func<int>> dtoRequestqualityOfImageContent = null, Expression<Func<int>> dtoRequestfooterOptions = null, Expression<Func<int>> dtoRequestheaderOptions = null, Expression<Func<string>> dtoRequestpaperFormat = null, Expression<Func<int>> dtoRequesttopMargin = null, Expression<Func<int>> dtoRequestbottomMargin = null, Expression<Func<int>> dtoRequestleftMargin = null, Expression<Func<int>> dtoRequestrightMargin = null, Expression<Func<string>> dtoRequestpageRanges = null, Expression<Func<double>> dtoRequestscale = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesthTML = WorkflowExpression.Compile(dtoRequesthTML, nameof(dtoRequesthTML), required: true);
            var __workflow_dtoRequestlandscapeFormat = WorkflowExpression.Compile(dtoRequestlandscapeFormat, nameof(dtoRequestlandscapeFormat), required: false);
            var __workflow_dtoRequestqualityOfImageContent = WorkflowExpression.Compile(dtoRequestqualityOfImageContent, nameof(dtoRequestqualityOfImageContent), required: false);
            var __workflow_dtoRequestfooterOptions = WorkflowExpression.Compile(dtoRequestfooterOptions, nameof(dtoRequestfooterOptions), required: false);
            var __workflow_dtoRequestheaderOptions = WorkflowExpression.Compile(dtoRequestheaderOptions, nameof(dtoRequestheaderOptions), required: false);
            var __workflow_dtoRequestpaperFormat = WorkflowExpression.Compile(dtoRequestpaperFormat, nameof(dtoRequestpaperFormat), required: false);
            var __workflow_dtoRequesttopMargin = WorkflowExpression.Compile(dtoRequesttopMargin, nameof(dtoRequesttopMargin), required: false);
            var __workflow_dtoRequestbottomMargin = WorkflowExpression.Compile(dtoRequestbottomMargin, nameof(dtoRequestbottomMargin), required: false);
            var __workflow_dtoRequestleftMargin = WorkflowExpression.Compile(dtoRequestleftMargin, nameof(dtoRequestleftMargin), required: false);
            var __workflow_dtoRequestrightMargin = WorkflowExpression.Compile(dtoRequestrightMargin, nameof(dtoRequestrightMargin), required: false);
            var __workflow_dtoRequestpageRanges = WorkflowExpression.Compile(dtoRequestpageRanges, nameof(dtoRequestpageRanges), required: false);
            var __workflow_dtoRequestscale = WorkflowExpression.Compile(dtoRequestscale, nameof(dtoRequestscale), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV7023ConvertHtmlToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7023_ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTML);
                if (__workflow_dtoRequestlandscapeFormat != null)
                {
                    if (__workflow_dtoRequestlandscapeFormat != null)
                    {
                        dtoRequest["isLandscape"] = ExpressionConverter.ConvertO(__workflow_dtoRequestlandscapeFormat);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["isLandscape"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestqualityOfImageContent != null)
                {
                    dtoRequest["imageQuality"] = ExpressionConverter.ConvertO(__workflow_dtoRequestqualityOfImageContent);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfooterOptions != null)
                {
                    dtoRequest["footerOption"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfooterOptions);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestheaderOptions != null)
                {
                    dtoRequest["headerOption"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheaderOptions);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpaperFormat != null)
                {
                    dtoRequest["paperFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpaperFormat);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttopMargin != null)
                {
                    dtoRequest["marginTop"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttopMargin);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestbottomMargin != null)
                {
                    dtoRequest["marginBottom"] = ExpressionConverter.ConvertO(__workflow_dtoRequestbottomMargin);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestleftMargin != null)
                {
                    dtoRequest["marginLeft"] = ExpressionConverter.ConvertO(__workflow_dtoRequestleftMargin);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestrightMargin != null)
                {
                    dtoRequest["marginRight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestrightMargin);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpageRanges != null)
                {
                    dtoRequest["pageRanges"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpageRanges);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestscale != null)
                {
                    dtoRequest["scale"] = ExpressionConverter.ConvertO(__workflow_dtoRequestscale);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV7023ConvertHtmlToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> ConvertHtmlToWord(Expression<Func<string>> dtoRequestV7041ConvertHtmlToWordhTML)
        {
            var __workflow_dtoRequestV7041ConvertHtmlToWordhTML = WorkflowExpression.Compile(dtoRequestV7041ConvertHtmlToWordhTML, nameof(dtoRequestV7041ConvertHtmlToWordhTML), required: true);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> ConvertImage(Expression<Func<string>> dtoRequestV3012ConvertImageimageFile, Expression<Func<string>> dtoRequestV3012ConvertImageoutputFormat = null)
        {
            var __workflow_dtoRequestV3012ConvertImageimageFile = WorkflowExpression.Compile(dtoRequestV3012ConvertImageimageFile, nameof(dtoRequestV3012ConvertImageimageFile), required: true);
            var __workflow_dtoRequestV3012ConvertImageoutputFormat = WorkflowExpression.Compile(dtoRequestV3012ConvertImageoutputFormat, nameof(dtoRequestV3012ConvertImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv, ApiConnectionActionConfiguration> ConvertJsonToCsv(Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvjSON, Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvseparator = null)
        {
            var __workflow_dtoRequestV1013ConvertJsonToCsvjSON = WorkflowExpression.Compile(dtoRequestV1013ConvertJsonToCsvjSON, nameof(dtoRequestV1013ConvertJsonToCsvjSON), required: true);
            var __workflow_dtoRequestV1013ConvertJsonToCsvseparator = WorkflowExpression.Compile(dtoRequestV1013ConvertJsonToCsvseparator, nameof(dtoRequestV1013ConvertJsonToCsvseparator), required: false);
            return new DeferredBodyAction<DtoResponseV1013ConvertJsonToCsv, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1064ConvertJsonToExcel, ApiConnectionActionConfiguration> ConvertJsonToExcel(Expression<Func<string>> dtoRequestjSON, Expression<Func<bool>> dtoRequestallInOneTable = null, Expression<Func<bool>> dtoRequestadjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestwrapExcelColumnText = null, Expression<Func<int>> dtoRequestmaxExcelColumnWidth = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestjSON = WorkflowExpression.Compile(dtoRequestjSON, nameof(dtoRequestjSON), required: true);
            var __workflow_dtoRequestallInOneTable = WorkflowExpression.Compile(dtoRequestallInOneTable, nameof(dtoRequestallInOneTable), required: false);
            var __workflow_dtoRequestadjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestwrapExcelColumnText = WorkflowExpression.Compile(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            var __workflow_dtoRequestmaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV1064ConvertJsonToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1064_ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestjSON);
                if (__workflow_dtoRequestallInOneTable != null)
                {
                    if (__workflow_dtoRequestallInOneTable != null)
                    {
                        dtoRequest["allInOneTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestallInOneTable);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["allInOneTable"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1064ConvertJsonToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml, ApiConnectionActionConfiguration> ConvertJsonToHtmlTable(Expression<Func<string>> dtoRequestV7051ConvertJsonToHtmlTablejSON)
        {
            var __workflow_dtoRequestV7051ConvertJsonToHtmlTablejSON = WorkflowExpression.Compile(dtoRequestV7051ConvertJsonToHtmlTablejSON, nameof(dtoRequestV7051ConvertJsonToHtmlTablejSON), required: true);
            return new DeferredBodyAction<DtoResponseHtml, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable, ApiConnectionActionConfiguration> ConvertJsonToTextTable(Expression<Func<string>> dtoRequestV1090ConvertJsonToTextTablejSON)
        {
            var __workflow_dtoRequestV1090ConvertJsonToTextTablejSON = WorkflowExpression.Compile(dtoRequestV1090ConvertJsonToTextTablejSON, nameof(dtoRequestV1090ConvertJsonToTextTablejSON), required: true);
            return new DeferredBodyAction<DtoResponseV1090ConvertJsonToTextTable, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml, ApiConnectionActionConfiguration> ConvertJsonToXml(Expression<Func<string>> dtoRequestV1042ConvertJsonToXmljSON)
        {
            var __workflow_dtoRequestV1042ConvertJsonToXmljSON = WorkflowExpression.Compile(dtoRequestV1042ConvertJsonToXmljSON, nameof(dtoRequestV1042ConvertJsonToXmljSON), required: true);
            return new DeferredBodyAction<DtoResponseV1042ConvertJsonToXml, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml, ApiConnectionActionConfiguration> ConvertJsonToYaml(Expression<Func<string>> dtoRequestV1081ConvertJsonToYamljSON)
        {
            var __workflow_dtoRequestV1081ConvertJsonToYamljSON = WorkflowExpression.Compile(dtoRequestV1081ConvertJsonToYamljSON, nameof(dtoRequestV1081ConvertJsonToYamljSON), required: true);
            return new DeferredBodyAction<DtoResponseV1081ConvertJsonToYaml, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV1110ConvertMultiCsvToExcel, ApiConnectionActionConfiguration> ConvertMultiCsvToExcel(Expression<Func<CsvSheetItem[]>> dtoRequestsheet, Expression<Func<bool>> dtoRequestcSVHasHeaders = null, Expression<Func<bool>> dtoRequestautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestremoveEmptyRows = null, Expression<Func<int>> dtoRequestskipANumberOfRows = null, Expression<Func<int>> dtoRequeststopAtASpecificRow = null, Expression<Func<string>> dtoRequestseparator = null, Expression<Func<bool>> dtoRequestautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestadjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestwrapExcelColumnText = null, Expression<Func<int>> dtoRequestmaxExcelColumnWidth = null, Expression<Func<string>> dtoRequestexcelFileName = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestsheet = WorkflowExpression.Compile(dtoRequestsheet, nameof(dtoRequestsheet), required: true);
            var __workflow_dtoRequestcSVHasHeaders = WorkflowExpression.Compile(dtoRequestcSVHasHeaders, nameof(dtoRequestcSVHasHeaders), required: false);
            var __workflow_dtoRequestautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestautoDetectFieldTypes, nameof(dtoRequestautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestnumberOfRowsForFieldTypeDetection = WorkflowExpression.Compile(dtoRequestnumberOfRowsForFieldTypeDetection, nameof(dtoRequestnumberOfRowsForFieldTypeDetection), required: false);
            var __workflow_dtoRequestremoveEmptyRows = WorkflowExpression.Compile(dtoRequestremoveEmptyRows, nameof(dtoRequestremoveEmptyRows), required: false);
            var __workflow_dtoRequestskipANumberOfRows = WorkflowExpression.Compile(dtoRequestskipANumberOfRows, nameof(dtoRequestskipANumberOfRows), required: false);
            var __workflow_dtoRequeststopAtASpecificRow = WorkflowExpression.Compile(dtoRequeststopAtASpecificRow, nameof(dtoRequeststopAtASpecificRow), required: false);
            var __workflow_dtoRequestseparator = WorkflowExpression.Compile(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            var __workflow_dtoRequestautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestautoDetectQuoteDelimiter, nameof(dtoRequestautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestadjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestwrapExcelColumnText = WorkflowExpression.Compile(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            var __workflow_dtoRequestmaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            var __workflow_dtoRequestexcelFileName = WorkflowExpression.Compile(dtoRequestexcelFileName, nameof(dtoRequestexcelFileName), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV1110ConvertMultiCsvToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1110_ConvertMultiCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["csvSheets"] = ExpressionConverter.ConvertO(__workflow_dtoRequestsheet);
                if (__workflow_dtoRequestcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestcSVHasHeaders != null)
                    {
                        dtoRequest["dataIncludesHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSVHasHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["dataIncludesHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestautoDetectFieldTypes != null)
                    {
                        dtoRequest["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestautoDetectFieldTypes);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["autoDiscoverFieldTypes"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestnumberOfRowsForFieldTypeDetection != null)
                {
                    dtoRequest["maxScanRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestnumberOfRowsForFieldTypeDetection);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestremoveEmptyRows != null)
                    {
                        dtoRequest["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestremoveEmptyRows);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreEmptyLine"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestskipANumberOfRows != null)
                {
                    dtoRequest["skip"] = ExpressionConverter.ConvertO(__workflow_dtoRequestskipANumberOfRows);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequeststopAtASpecificRow != null)
                {
                    dtoRequest["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequeststopAtASpecificRow);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestautoDetectQuoteDelimiter != null)
                    {
                        dtoRequest["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestautoDetectQuoteDelimiter);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["mayHaveQuotedFields"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestexcelFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexcelFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1110ConvertMultiCsvToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4130ConvertPdfToMarkdown, ApiConnectionActionConfiguration> ConvertPdfToMarkdown(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<bool>> dtoRequestkeepReadingOrder = null, Expression<Func<bool>> dtoRequestmarkHeadings = null, Expression<Func<bool>> dtoRequestaddPageMarkers = null, Expression<Func<string>> dtoRequestfileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestkeepReadingOrder = WorkflowExpression.Compile(dtoRequestkeepReadingOrder, nameof(dtoRequestkeepReadingOrder), required: false);
            var __workflow_dtoRequestmarkHeadings = WorkflowExpression.Compile(dtoRequestmarkHeadings, nameof(dtoRequestmarkHeadings), required: false);
            var __workflow_dtoRequestaddPageMarkers = WorkflowExpression.Compile(dtoRequestaddPageMarkers, nameof(dtoRequestaddPageMarkers), required: false);
            var __workflow_dtoRequestfileName = WorkflowExpression.Compile(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV4130ConvertPdfToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4130_ConvertPdfToMarkdown";
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

                if (__workflow_dtoRequestkeepReadingOrder != null)
                {
                    dtoRequest["layoutBased"] = ExpressionConverter.ConvertO(__workflow_dtoRequestkeepReadingOrder);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmarkHeadings != null)
                {
                    dtoRequest["detectHeadings"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmarkHeadings);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestaddPageMarkers != null)
                {
                    dtoRequest["addPageMarkers"] = ExpressionConverter.ConvertO(__workflow_dtoRequestaddPageMarkers);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4130ConvertPdfToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4071ConvertPdfToPdfA, ApiConnectionActionConfiguration> ConvertPdfToPdfA(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestconformanceLevel = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestconformanceLevel = WorkflowExpression.Compile(dtoRequestconformanceLevel, nameof(dtoRequestconformanceLevel), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4071ConvertPdfToPdfA, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4071_ConvertPdfToPdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDF);
                if (__workflow_dtoRequestconformanceLevel != null)
                {
                    dtoRequest["conformanceLevel"] = ExpressionConverter.ConvertO(__workflow_dtoRequestconformanceLevel);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4071ConvertPdfToPdfA>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults, ApiConnectionActionConfiguration> ConvertSharePointSearchResults(Expression<Func<string>> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
        {
            var __workflow_dtoRequestV6011ConvertSharePointSearchResultssPSearchResult = WorkflowExpression.Compile(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult, nameof(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult), required: true);
            return new DeferredBodyAction<DtoResponseV6011ConvertSharePointSearchResults, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml, ApiConnectionActionConfiguration> ConvertWordToHtml(Expression<Func<string>> dtoRequestword, Expression<Func<bool>> dtoRequestembedImages = null, Expression<Func<bool>> dtoRequestfullHTMLDocument = null, Expression<Func<string>> dtoRequesttitle = null)
        {
            var __workflow_dtoRequestword = WorkflowExpression.Compile(dtoRequestword, nameof(dtoRequestword), required: true);
            var __workflow_dtoRequestembedImages = WorkflowExpression.Compile(dtoRequestembedImages, nameof(dtoRequestembedImages), required: false);
            var __workflow_dtoRequestfullHTMLDocument = WorkflowExpression.Compile(dtoRequestfullHTMLDocument, nameof(dtoRequestfullHTMLDocument), required: false);
            var __workflow_dtoRequesttitle = WorkflowExpression.Compile(dtoRequesttitle, nameof(dtoRequesttitle), required: false);
            return new DeferredBodyAction<DtoResponseV5160ConvertWordToHtml, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV5170ConvertWordToMarkdown, ApiConnectionActionConfiguration> ConvertWordToMarkdown(Expression<Func<string>> dtoRequestword, Expression<Func<bool>> dtoRequestkeepImagePlaceholders = null, Expression<Func<string>> dtoRequestfileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestword = WorkflowExpression.Compile(dtoRequestword, nameof(dtoRequestword), required: true);
            var __workflow_dtoRequestkeepImagePlaceholders = WorkflowExpression.Compile(dtoRequestkeepImagePlaceholders, nameof(dtoRequestkeepImagePlaceholders), required: false);
            var __workflow_dtoRequestfileName = WorkflowExpression.Compile(dtoRequestfileName, nameof(dtoRequestfileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV5170ConvertWordToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5170_ConvertWordToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["word"] = ExpressionConverter.ConvertO(__workflow_dtoRequestword);
                if (__workflow_dtoRequestkeepImagePlaceholders != null)
                {
                    dtoRequest["keepImagePlaceholders"] = ExpressionConverter.ConvertO(__workflow_dtoRequestkeepImagePlaceholders);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5170ConvertWordToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1130ConvertXmlToCsv, ApiConnectionActionConfiguration> ConvertXmlToCsv(Expression<Func<string>> dtoRequestxML, Expression<Func<string>> dtoRequestseparator = null, Expression<Func<bool>> dtoRequestignoreXMLFormatting = null, Expression<Func<string>> dtoRequestcSVFileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestxML = WorkflowExpression.Compile(dtoRequestxML, nameof(dtoRequestxML), required: true);
            var __workflow_dtoRequestseparator = WorkflowExpression.Compile(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            var __workflow_dtoRequestignoreXMLFormatting = WorkflowExpression.Compile(dtoRequestignoreXMLFormatting, nameof(dtoRequestignoreXMLFormatting), required: false);
            var __workflow_dtoRequestcSVFileName = WorkflowExpression.Compile(dtoRequestcSVFileName, nameof(dtoRequestcSVFileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV1130ConvertXmlToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1130_ConvertXmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestxML);
                if (__workflow_dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestignoreXMLFormatting != null)
                {
                    if (__workflow_dtoRequestignoreXMLFormatting != null)
                    {
                        dtoRequest["ignoreXmlFormatting"] = ExpressionConverter.ConvertO(__workflow_dtoRequestignoreXMLFormatting);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreXmlFormatting"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestcSVFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSVFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1130ConvertXmlToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1120ConvertXmlToExcel, ApiConnectionActionConfiguration> ConvertXmlToExcel(Expression<Func<string>> dtoRequestxML, Expression<Func<bool>> dtoRequestignoreXMLFormatting = null, Expression<Func<bool>> dtoRequestallInOneTable = null, Expression<Func<bool>> dtoRequestadjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestwrapExcelColumnText = null, Expression<Func<int>> dtoRequestmaxExcelColumnWidth = null, Expression<Func<string>> dtoRequestexcelFileName = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestxML = WorkflowExpression.Compile(dtoRequestxML, nameof(dtoRequestxML), required: true);
            var __workflow_dtoRequestignoreXMLFormatting = WorkflowExpression.Compile(dtoRequestignoreXMLFormatting, nameof(dtoRequestignoreXMLFormatting), required: false);
            var __workflow_dtoRequestallInOneTable = WorkflowExpression.Compile(dtoRequestallInOneTable, nameof(dtoRequestallInOneTable), required: false);
            var __workflow_dtoRequestadjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestadjustExcelColumnToContent, nameof(dtoRequestadjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestwrapExcelColumnText = WorkflowExpression.Compile(dtoRequestwrapExcelColumnText, nameof(dtoRequestwrapExcelColumnText), required: false);
            var __workflow_dtoRequestmaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestmaxExcelColumnWidth, nameof(dtoRequestmaxExcelColumnWidth), required: false);
            var __workflow_dtoRequestexcelFileName = WorkflowExpression.Compile(dtoRequestexcelFileName, nameof(dtoRequestexcelFileName), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV1120ConvertXmlToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1120_ConvertXmlToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestxML);
                if (__workflow_dtoRequestignoreXMLFormatting != null)
                {
                    if (__workflow_dtoRequestignoreXMLFormatting != null)
                    {
                        dtoRequest["ignoreXmlFormatting"] = ExpressionConverter.ConvertO(__workflow_dtoRequestignoreXMLFormatting);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["ignoreXmlFormatting"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestallInOneTable != null)
                {
                    if (__workflow_dtoRequestallInOneTable != null)
                    {
                        dtoRequest["allInOneTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestallInOneTable);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["allInOneTable"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestadjustExcelColumnToContent != null)
                    {
                        dtoRequest["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestadjustExcelColumnToContent);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["adjustColumnToContent"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestwrapExcelColumnText != null)
                    {
                        dtoRequest["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwrapExcelColumnText);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["wrapColumnText"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaxExcelColumnWidth != null)
                {
                    dtoRequest["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaxExcelColumnWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestexcelFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexcelFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1120ConvertXmlToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1053ConvertXmlToJson, ApiConnectionActionConfiguration> ConvertXmlToJson(Expression<Func<string>> dtoRequestxML, Expression<Func<bool>> dtoRequestignoreXMLFormatting = null)
        {
            var __workflow_dtoRequestxML = WorkflowExpression.Compile(dtoRequestxML, nameof(dtoRequestxML), required: true);
            var __workflow_dtoRequestignoreXMLFormatting = WorkflowExpression.Compile(dtoRequestignoreXMLFormatting, nameof(dtoRequestignoreXMLFormatting), required: false);
            return new DeferredBodyAction<DtoResponseV1053ConvertXmlToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1053_ConvertXmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestxML);
                if (__workflow_dtoRequestignoreXMLFormatting != null)
                {
                    dtoRequest["ignoreXmlFormatting"] = ExpressionConverter.ConvertO(__workflow_dtoRequestignoreXMLFormatting);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV1053ConvertXmlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8011ConvertXRechnungToPdf, ApiConnectionActionConfiguration> ConvertXRechnungToPdf(Expression<Func<string>> dtoRequestxRechnung, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestxRechnung = WorkflowExpression.Compile(dtoRequestxRechnung, nameof(dtoRequestxRechnung), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV8011ConvertXRechnungToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V8011_ConvertXRechnungToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestxRechnung);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV8011ConvertXRechnungToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson, ApiConnectionActionConfiguration> ConvertYamlToJson(Expression<Func<string>> dtoRequestV1071YamlToJsonyAML)
        {
            var __workflow_dtoRequestV1071YamlToJsonyAML = WorkflowExpression.Compile(dtoRequestV1071YamlToJsonyAML, nameof(dtoRequestV1071YamlToJsonyAML), required: true);
            return new DeferredBodyAction<DtoResponseV1071ConvertYamlToJson, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV3092CreateChartImage, ApiConnectionActionConfiguration> CreateChartImage(Expression<Func<string>> dtoRequesttableData, Expression<Func<int>> dtoRequestimageWidth = null, Expression<Func<int>> dtoRequestimageHeight = null, Expression<Func<string>> dtoRequestbackgroundColor = null, Expression<Func<string>> dtoRequestoutputFormat = null, Expression<Func<string>> dtoRequestchartType = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesttableData = WorkflowExpression.Compile(dtoRequesttableData, nameof(dtoRequesttableData), required: true);
            var __workflow_dtoRequestimageWidth = WorkflowExpression.Compile(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            var __workflow_dtoRequestimageHeight = WorkflowExpression.Compile(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            var __workflow_dtoRequestbackgroundColor = WorkflowExpression.Compile(dtoRequestbackgroundColor, nameof(dtoRequestbackgroundColor), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            var __workflow_dtoRequestchartType = WorkflowExpression.Compile(dtoRequestchartType, nameof(dtoRequestchartType), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3092CreateChartImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3092_CreateChartImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestbackgroundColor != null)
                {
                    dtoRequest["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestbackgroundColor);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["format"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["chart"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttableData);
                if (__workflow_dtoRequestchartType != null)
                {
                    dtoRequest["type"] = ExpressionConverter.ConvertO(__workflow_dtoRequestchartType);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3092CreateChartImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3063CreateCode, ApiConnectionActionConfiguration> CreateCode(Expression<Func<string>> dtoRequestcontent, Expression<Func<string>> dtoRequestcodeFormat = null, Expression<Func<int>> dtoRequestwidth = null, Expression<Func<int>> dtoRequestheight = null, Expression<Func<string>> dtoRequestoutputFormat = null, Expression<Func<string>> dtoRequestembeddedImage = null, Expression<Func<double>> dtoRequestembeddedImageOpacity = null, Expression<Func<double>> dtoRequestembeddedImageRatio = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestcontent = WorkflowExpression.Compile(dtoRequestcontent, nameof(dtoRequestcontent), required: true);
            var __workflow_dtoRequestcodeFormat = WorkflowExpression.Compile(dtoRequestcodeFormat, nameof(dtoRequestcodeFormat), required: false);
            var __workflow_dtoRequestwidth = WorkflowExpression.Compile(dtoRequestwidth, nameof(dtoRequestwidth), required: false);
            var __workflow_dtoRequestheight = WorkflowExpression.Compile(dtoRequestheight, nameof(dtoRequestheight), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            var __workflow_dtoRequestembeddedImage = WorkflowExpression.Compile(dtoRequestembeddedImage, nameof(dtoRequestembeddedImage), required: false);
            var __workflow_dtoRequestembeddedImageOpacity = WorkflowExpression.Compile(dtoRequestembeddedImageOpacity, nameof(dtoRequestembeddedImageOpacity), required: false);
            var __workflow_dtoRequestembeddedImageRatio = WorkflowExpression.Compile(dtoRequestembeddedImageRatio, nameof(dtoRequestembeddedImageRatio), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3063CreateCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3063_CreateCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["content"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcontent);
                if (__workflow_dtoRequestcodeFormat != null)
                {
                    dtoRequest["codeFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcodeFormat);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwidth != null)
                {
                    dtoRequest["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestheight != null)
                {
                    dtoRequest["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["outFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestembeddedImage != null)
                {
                    dtoRequest["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestembeddedImage);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestembeddedImageOpacity != null)
                {
                    dtoRequest["imageOpacity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestembeddedImageOpacity);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestembeddedImageRatio != null)
                {
                    dtoRequest["imageRatio"] = ExpressionConverter.ConvertO(__workflow_dtoRequestembeddedImageRatio);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3063CreateCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3112CreateGraphImage, ApiConnectionActionConfiguration> CreateGraphImage(Expression<Func<string>> dtoRequestgraphData, Expression<Func<int>> dtoRequestimageWidth = null, Expression<Func<int>> dtoRequestimageHeight = null, Expression<Func<string>> dtoRequestbackgroundColor = null, Expression<Func<string>> dtoRequestoutputFormat = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestgraphData = WorkflowExpression.Compile(dtoRequestgraphData, nameof(dtoRequestgraphData), required: true);
            var __workflow_dtoRequestimageWidth = WorkflowExpression.Compile(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            var __workflow_dtoRequestimageHeight = WorkflowExpression.Compile(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            var __workflow_dtoRequestbackgroundColor = WorkflowExpression.Compile(dtoRequestbackgroundColor, nameof(dtoRequestbackgroundColor), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3112CreateGraphImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3112_CreateGraphImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestbackgroundColor != null)
                {
                    dtoRequest["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestbackgroundColor);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["format"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["graph"] = ExpressionConverter.ConvertO(__workflow_dtoRequestgraphData);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3112CreateGraphImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3102CreateTableImage, ApiConnectionActionConfiguration> CreateTableImage(Expression<Func<string>> dtoRequesttableData, Expression<Func<int>> dtoRequestimageWidth = null, Expression<Func<int>> dtoRequestimageHeight = null, Expression<Func<string>> dtoRequestbackgroundColor = null, Expression<Func<string>> dtoRequestoutputFormat = null, Expression<Func<string>> dtoRequesttitle = null, Expression<Func<bool>> dtoRequestshowTableBorders = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequesttableData = WorkflowExpression.Compile(dtoRequesttableData, nameof(dtoRequesttableData), required: true);
            var __workflow_dtoRequestimageWidth = WorkflowExpression.Compile(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            var __workflow_dtoRequestimageHeight = WorkflowExpression.Compile(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            var __workflow_dtoRequestbackgroundColor = WorkflowExpression.Compile(dtoRequestbackgroundColor, nameof(dtoRequestbackgroundColor), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            var __workflow_dtoRequesttitle = WorkflowExpression.Compile(dtoRequesttitle, nameof(dtoRequesttitle), required: false);
            var __workflow_dtoRequestshowTableBorders = WorkflowExpression.Compile(dtoRequestshowTableBorders, nameof(dtoRequestshowTableBorders), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3102CreateTableImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3102_CreateTableImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestbackgroundColor != null)
                {
                    dtoRequest["backgroundColor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestbackgroundColor);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["format"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["data"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttableData);
                if (__workflow_dtoRequesttitle != null)
                {
                    dtoRequest["title"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttitle);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestshowTableBorders != null)
                {
                    if (__workflow_dtoRequestshowTableBorders != null)
                    {
                        dtoRequest["hasLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestshowTableBorders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["hasLines"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3102CreateTableImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3082CreateWatermarkImage, ApiConnectionActionConfiguration> CreateWatermarkImage(Expression<Func<string>> dtoRequestmainImage, Expression<Func<string>> dtoRequestwatermarkImage, Expression<Func<int>> dtoRequestwatermarkOpacity = null, Expression<Func<int>> dtoRequestwatermarkRatio = null, Expression<Func<string>> dtoRequestwatermarkHorizontalPosition = null, Expression<Func<string>> dtoRequestwatermarkVerticalPosition = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestmainImage = WorkflowExpression.Compile(dtoRequestmainImage, nameof(dtoRequestmainImage), required: true);
            var __workflow_dtoRequestwatermarkImage = WorkflowExpression.Compile(dtoRequestwatermarkImage, nameof(dtoRequestwatermarkImage), required: true);
            var __workflow_dtoRequestwatermarkOpacity = WorkflowExpression.Compile(dtoRequestwatermarkOpacity, nameof(dtoRequestwatermarkOpacity), required: false);
            var __workflow_dtoRequestwatermarkRatio = WorkflowExpression.Compile(dtoRequestwatermarkRatio, nameof(dtoRequestwatermarkRatio), required: false);
            var __workflow_dtoRequestwatermarkHorizontalPosition = WorkflowExpression.Compile(dtoRequestwatermarkHorizontalPosition, nameof(dtoRequestwatermarkHorizontalPosition), required: false);
            var __workflow_dtoRequestwatermarkVerticalPosition = WorkflowExpression.Compile(dtoRequestwatermarkVerticalPosition, nameof(dtoRequestwatermarkVerticalPosition), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3082CreateWatermarkImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3082_CreateWatermarkImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["image"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmainImage);
                dtoRequestpropCount++;
                dtoRequest["watermarkImage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwatermarkImage);
                if (__workflow_dtoRequestwatermarkOpacity != null)
                {
                    dtoRequest["opacity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwatermarkOpacity);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwatermarkRatio != null)
                {
                    dtoRequest["ratio"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwatermarkRatio);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwatermarkHorizontalPosition != null)
                {
                    dtoRequest["imagePositionHorizontal"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwatermarkHorizontalPosition);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestwatermarkVerticalPosition != null)
                {
                    dtoRequest["imagePositionVertical"] = ExpressionConverter.ConvertO(__workflow_dtoRequestwatermarkVerticalPosition);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3082CreateWatermarkImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5012CreateWordFile, ApiConnectionActionConfiguration> CreateWordFile(Expression<Func<Section[]>> dtoRequestsection, Expression<Func<string>> dtoRequestexistingFileContent = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestsection = WorkflowExpression.Compile(dtoRequestsection, nameof(dtoRequestsection), required: true);
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5012CreateWordFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5012_CreateWordFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                if (__workflow_dtoRequestexistingFileContent != null)
                {
                    dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["sections"] = ExpressionConverter.ConvertO(__workflow_dtoRequestsection);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5012CreateWordFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf, ApiConnectionActionConfiguration> ExtractImagesFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<string>> dtoRequestfileNamePrefix = null, Expression<Func<bool>> dtoRequestincludeBase64String = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestfileNamePrefix = WorkflowExpression.Compile(dtoRequestfileNamePrefix, nameof(dtoRequestfileNamePrefix), required: false);
            var __workflow_dtoRequestincludeBase64String = WorkflowExpression.Compile(dtoRequestincludeBase64String, nameof(dtoRequestincludeBase64String), required: false);
            return new DeferredBodyAction<DtoResponseV4090ExtractImagesFromPdf, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties, ApiConnectionActionConfiguration> ExtractJsonObjectProperties(Expression<Func<string>> dtoRequestV2100ExtractJsonObjectPropertiesjSON, Expression<Func<bool>> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
        {
            var __workflow_dtoRequestV2100ExtractJsonObjectPropertiesjSON = WorkflowExpression.Compile(dtoRequestV2100ExtractJsonObjectPropertiesjSON, nameof(dtoRequestV2100ExtractJsonObjectPropertiesjSON), required: true);
            var __workflow_dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = WorkflowExpression.Compile(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties, nameof(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties), required: false);
            return new DeferredBodyAction<DtoResponseV2100ExtractJsonObjectProperties, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV4061ExtractPdfPages, ApiConnectionActionConfiguration> ExtractPdfPages(Expression<Func<string>> dtoRequestpDFFile, Expression<Func<string>> dtoRequestpagesToExtract, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestpDFFile = WorkflowExpression.Compile(dtoRequestpDFFile, nameof(dtoRequestpDFFile), required: true);
            var __workflow_dtoRequestpagesToExtract = WorkflowExpression.Compile(dtoRequestpagesToExtract, nameof(dtoRequestpagesToExtract), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4061ExtractPdfPages, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4061_ExtractPdfPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDFFile);
                dtoRequestpropCount++;
                dtoRequest["pages"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpagesToExtract);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4061ExtractPdfPages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4160ExtractPdfTablesToCsv, ApiConnectionActionConfiguration> ExtractPdfTablesToCsv(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<int>> dtoRequestheaderRow = null, Expression<Func<string>> dtoRequestseparator = null, Expression<Func<string>> dtoRequestcSVFileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestheaderRow = WorkflowExpression.Compile(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            var __workflow_dtoRequestseparator = WorkflowExpression.Compile(dtoRequestseparator, nameof(dtoRequestseparator), required: false);
            var __workflow_dtoRequestcSVFileName = WorkflowExpression.Compile(dtoRequestcSVFileName, nameof(dtoRequestcSVFileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV4160ExtractPdfTablesToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4160_ExtractPdfTablesToCsv";
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

                if (__workflow_dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestseparator != null)
                {
                    dtoRequest["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestseparator);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestcSVFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcSVFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4160ExtractPdfTablesToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4150ExtractPdfTablesToExcel, ApiConnectionActionConfiguration> ExtractPdfTablesToExcel(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<int>> dtoRequestheaderRow = null, Expression<Func<string>> dtoRequestexcelFileName = null, Expression<Func<int>> dtoRequestfileResponse = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestheaderRow = WorkflowExpression.Compile(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            var __workflow_dtoRequestexcelFileName = WorkflowExpression.Compile(dtoRequestexcelFileName, nameof(dtoRequestexcelFileName), required: false);
            var __workflow_dtoRequestfileResponse = WorkflowExpression.Compile(dtoRequestfileResponse, nameof(dtoRequestfileResponse), required: false);
            return new DeferredBodyAction<DtoResponseV4150ExtractPdfTablesToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4150_ExtractPdfTablesToExcel";
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

                if (__workflow_dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestexcelFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexcelFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestfileResponse != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfileResponse);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4150ExtractPdfTablesToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4170ExtractPdfTablesToHtml, ApiConnectionActionConfiguration> ExtractPdfTablesToHtml(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<int>> dtoRequestheaderRow = null, Expression<Func<string>> dtoRequesthTMLFileName = null, Expression<Func<int>> dtoRequestoutputFormat = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestheaderRow = WorkflowExpression.Compile(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            var __workflow_dtoRequesthTMLFileName = WorkflowExpression.Compile(dtoRequesthTMLFileName, nameof(dtoRequesthTMLFileName), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV4170ExtractPdfTablesToHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4170_ExtractPdfTablesToHtml";
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

                if (__workflow_dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesthTMLFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequesthTMLFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["textOutputMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4170ExtractPdfTablesToHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4140ExtractPdfTablesToJson, ApiConnectionActionConfiguration> ExtractPdfTablesToJson(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<int>> dtoRequestheaderRow = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestheaderRow = WorkflowExpression.Compile(dtoRequestheaderRow, nameof(dtoRequestheaderRow), required: false);
            return new DeferredBodyAction<DtoResponseV4140ExtractPdfTablesToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4140_ExtractPdfTablesToJson";
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

                if (__workflow_dtoRequestheaderRow != null)
                {
                    dtoRequest["headerMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestheaderRow);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4140ExtractPdfTablesToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern, ApiConnectionActionConfiguration> ExtractTextAccordingToPattern(Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntext, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, Expression<Func<bool>> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
        {
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatterntext = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatterntext, nameof(dtoRequestV2140ExtractTextAccordingToPatterntext), required: true);
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatternmatchPattern = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, nameof(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern), required: true);
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled), required: false);
            var __workflow_dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings), required: false);
            return new DeferredBodyAction<DtoResponseV2140ExtractTextAccordingToPattern, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf, ApiConnectionActionConfiguration> ExtractTextFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<bool>> dtoRequestlayoutBased = null, Expression<Func<bool>> dtoRequestincludePages = null, Expression<Func<string>> dtoRequestpageSeparator = null, Expression<Func<bool>> dtoRequestnormalizeWhitespace = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestfromPage = WorkflowExpression.Compile(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            var __workflow_dtoRequesttoPage = WorkflowExpression.Compile(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            var __workflow_dtoRequestlayoutBased = WorkflowExpression.Compile(dtoRequestlayoutBased, nameof(dtoRequestlayoutBased), required: false);
            var __workflow_dtoRequestincludePages = WorkflowExpression.Compile(dtoRequestincludePages, nameof(dtoRequestincludePages), required: false);
            var __workflow_dtoRequestpageSeparator = WorkflowExpression.Compile(dtoRequestpageSeparator, nameof(dtoRequestpageSeparator), required: false);
            var __workflow_dtoRequestnormalizeWhitespace = WorkflowExpression.Compile(dtoRequestnormalizeWhitespace, nameof(dtoRequestnormalizeWhitespace), required: false);
            return new DeferredBodyAction<DtoResponseV4100ExtractTextFromPdf, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks, ApiConnectionActionConfiguration> ExtractWordBookmarks(Expression<Func<string>> dtoRequestV5021ExtractWordBookmarksFile, Expression<Func<bool>> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchName = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            var __workflow_dtoRequestV5021ExtractWordBookmarksFile = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarksFile, nameof(dtoRequestV5021ExtractWordBookmarksFile), required: true);
            var __workflow_dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks, nameof(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks), required: false);
            var __workflow_dtoRequestV5021ExtractWordBookmarkssearchName = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarkssearchName, nameof(dtoRequestV5021ExtractWordBookmarkssearchName), required: false);
            var __workflow_dtoRequestV5021ExtractWordBookmarkssearchContent = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarkssearchContent, nameof(dtoRequestV5021ExtractWordBookmarkssearchContent), required: false);
            return new DeferredBodyAction<DtoResponseV5021ExtractWordBookmarks, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5021_ExtractWordBookmarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5021ExtractWordBookmarks = new JObject();
                var dtoRequestV5021ExtractWordBookmarkspropCount = 0;
                dtoRequestV5021ExtractWordBookmarkspropCount++;
                dtoRequestV5021ExtractWordBookmarks["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5021ExtractWordBookmarksFile);
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
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls, ApiConnectionActionConfiguration> ExtractWordContentControls(Expression<Func<string>> dtoRequestV5120ExtractWordContentControlsFile, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTag = null, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            var __workflow_dtoRequestV5120ExtractWordContentControlsFile = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControlsFile, nameof(dtoRequestV5120ExtractWordContentControlsFile), required: true);
            var __workflow_dtoRequestV5120ExtractWordContentControlssearchTag = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControlssearchTag, nameof(dtoRequestV5120ExtractWordContentControlssearchTag), required: false);
            var __workflow_dtoRequestV5120ExtractWordContentControlssearchTitle = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControlssearchTitle, nameof(dtoRequestV5120ExtractWordContentControlssearchTitle), required: false);
            return new DeferredBodyAction<DtoResponseV5120ExtractWordContentControls, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5120_ExtractWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5120ExtractWordContentControls = new JObject();
                var dtoRequestV5120ExtractWordContentControlspropCount = 0;
                dtoRequestV5120ExtractWordContentControlspropCount++;
                dtoRequestV5120ExtractWordContentControls["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV5120ExtractWordContentControlsFile);
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
        public IBodyWorkflowAction<DtoResponseV2021IbanData, ApiConnectionActionConfiguration> IbanData(Expression<Func<string>> dtoRequestV2021IbanDataiBAN)
        {
            var __workflow_dtoRequestV2021IbanDataiBAN = WorkflowExpression.Compile(dtoRequestV2021IbanDataiBAN, nameof(dtoRequestV2021IbanDataiBAN), required: true);
            return new DeferredBodyAction<DtoResponseV2021IbanData, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData, ApiConnectionActionConfiguration> ImageMetaData(Expression<Func<string>> dtoRequestV3071ImageMetaDataimageFile)
        {
            var __workflow_dtoRequestV3071ImageMetaDataimageFile = WorkflowExpression.Compile(dtoRequestV3071ImageMetaDataimageFile, nameof(dtoRequestV3071ImageMetaDataimageFile), required: true);
            return new DeferredBodyAction<DtoResponseV3071ImageMetaData, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> InsertImageToPowerPoint(Expression<Func<string>> dtoRequestV9020InsertImagePowerPointexistingFileContent, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderImage, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderName = null, Expression<Func<int>> dtoRequestV9020InsertImagePowerPointmaximumImageWidth = null, Expression<Func<int>> dtoRequestV9020InsertImagePowerPointmaximumImageHeight = null, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV9020InsertImagePowerPointexistingFileContent = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointexistingFileContent, nameof(dtoRequestV9020InsertImagePowerPointexistingFileContent), required: true);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderImage = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderImage, nameof(dtoRequestV9020InsertImagePowerPointplaceholderImage), required: true);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderName = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderName, nameof(dtoRequestV9020InsertImagePowerPointplaceholderName), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointmaximumImageWidth = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointmaximumImageWidth, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageWidth), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointmaximumImageHeight = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointmaximumImageHeight, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageHeight), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderPrefix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderPrefix), required: false);
            var __workflow_dtoRequestV9020InsertImagePowerPointplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPointplaceholderSuffix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV5082InsertImageToWord, ApiConnectionActionConfiguration> InsertImageToWord(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<string>> dtoRequestimage, Expression<Func<string>> dtoRequestplaceholderName = null, Expression<Func<int>> dtoRequestmaximumImageWidth = null, Expression<Func<int>> dtoRequestmaximumImageHeight = null, Expression<Func<string>> dtoRequestplaceholderPrefix = null, Expression<Func<string>> dtoRequestplaceholderSuffix = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestimage = WorkflowExpression.Compile(dtoRequestimage, nameof(dtoRequestimage), required: true);
            var __workflow_dtoRequestplaceholderName = WorkflowExpression.Compile(dtoRequestplaceholderName, nameof(dtoRequestplaceholderName), required: false);
            var __workflow_dtoRequestmaximumImageWidth = WorkflowExpression.Compile(dtoRequestmaximumImageWidth, nameof(dtoRequestmaximumImageWidth), required: false);
            var __workflow_dtoRequestmaximumImageHeight = WorkflowExpression.Compile(dtoRequestmaximumImageHeight, nameof(dtoRequestmaximumImageHeight), required: false);
            var __workflow_dtoRequestplaceholderPrefix = WorkflowExpression.Compile(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            var __workflow_dtoRequestplaceholderSuffix = WorkflowExpression.Compile(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5082InsertImageToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5082_InsertImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                if (__workflow_dtoRequestplaceholderName != null)
                {
                    dtoRequest["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderName);
                    dtoRequestpropCount++;
                }

                dtoRequestpropCount++;
                dtoRequest["placeholderImage"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimage);
                if (__workflow_dtoRequestmaximumImageWidth != null)
                {
                    dtoRequest["maxWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaximumImageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestmaximumImageHeight != null)
                {
                    dtoRequest["maxHeight"] = ExpressionConverter.ConvertO(__workflow_dtoRequestmaximumImageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5082InsertImageToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5111InsertMultipleTextSectionsToWord, ApiConnectionActionConfiguration> InsertMultipleTextSectionsToWord(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<InsertSection[]>> dtoRequestplaceholder, Expression<Func<string>> dtoRequestplaceholderPrefix = null, Expression<Func<string>> dtoRequestplaceholderSuffix = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestplaceholder = WorkflowExpression.Compile(dtoRequestplaceholder, nameof(dtoRequestplaceholder), required: true);
            var __workflow_dtoRequestplaceholderPrefix = WorkflowExpression.Compile(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            var __workflow_dtoRequestplaceholderSuffix = WorkflowExpression.Compile(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5111InsertMultipleTextSectionsToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5111_InsertMultipleTextSectionsToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["insertSections"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholder);
                if (__workflow_dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5111InsertMultipleTextSectionsToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5092InsertTableToWord, ApiConnectionActionConfiguration> InsertTableToWord(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<string>> dtoRequestplaceholderName = null, Expression<Func<string>> dtoRequestplaceholderTable = null, Expression<Func<string>> dtoRequesttableStyle = null, Expression<Func<bool>> dtoRequestshowHeaders = null, Expression<Func<string>> dtoRequestplaceholderPrefix = null, Expression<Func<string>> dtoRequestplaceholderSuffix = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestplaceholderName = WorkflowExpression.Compile(dtoRequestplaceholderName, nameof(dtoRequestplaceholderName), required: false);
            var __workflow_dtoRequestplaceholderTable = WorkflowExpression.Compile(dtoRequestplaceholderTable, nameof(dtoRequestplaceholderTable), required: false);
            var __workflow_dtoRequesttableStyle = WorkflowExpression.Compile(dtoRequesttableStyle, nameof(dtoRequesttableStyle), required: false);
            var __workflow_dtoRequestshowHeaders = WorkflowExpression.Compile(dtoRequestshowHeaders, nameof(dtoRequestshowHeaders), required: false);
            var __workflow_dtoRequestplaceholderPrefix = WorkflowExpression.Compile(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            var __workflow_dtoRequestplaceholderSuffix = WorkflowExpression.Compile(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5092InsertTableToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5092_InsertTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                if (__workflow_dtoRequestplaceholderName != null)
                {
                    dtoRequest["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderTable != null)
                {
                    dtoRequest["placeholderTable"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderTable);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequesttableStyle != null)
                {
                    if (__workflow_dtoRequesttableStyle != null)
                    {
                        dtoRequest["tableStyle"] = ExpressionConverter.ConvertO(__workflow_dtoRequesttableStyle);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["tableStyle"] = "GridTable1Light";
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestshowHeaders != null)
                {
                    if (__workflow_dtoRequestshowHeaders != null)
                    {
                        dtoRequest["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestshowHeaders);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["hasHeader"] = true;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5092InsertTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> InsertTextToPowerPoint(Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointexistingFileContent, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderName, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderText = null, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            var __workflow_dtoRequestV9010InsertTextToPowerPointexistingFileContent = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointexistingFileContent, nameof(dtoRequestV9010InsertTextToPowerPointexistingFileContent), required: true);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderName = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderName, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderName), required: true);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderText = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderText, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderText), required: false);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix), required: false);
            var __workflow_dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV5072InsertTextToWord, ApiConnectionActionConfiguration> InsertTextToWord(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<string>> dtoRequestplaceholderName, Expression<Func<string>> dtoRequestplaceholderText = null, Expression<Func<string>> dtoRequestplaceholderPrefix = null, Expression<Func<string>> dtoRequestplaceholderSuffix = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestplaceholderName = WorkflowExpression.Compile(dtoRequestplaceholderName, nameof(dtoRequestplaceholderName), required: true);
            var __workflow_dtoRequestplaceholderText = WorkflowExpression.Compile(dtoRequestplaceholderText, nameof(dtoRequestplaceholderText), required: false);
            var __workflow_dtoRequestplaceholderPrefix = WorkflowExpression.Compile(dtoRequestplaceholderPrefix, nameof(dtoRequestplaceholderPrefix), required: false);
            var __workflow_dtoRequestplaceholderSuffix = WorkflowExpression.Compile(dtoRequestplaceholderSuffix, nameof(dtoRequestplaceholderSuffix), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5072InsertTextToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5072_InsertTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["existingFileContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["placeholderName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderName);
                if (__workflow_dtoRequestplaceholderText != null)
                {
                    dtoRequest["placeholderText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderText);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderPrefix != null)
                {
                    dtoRequest["placeholderPrefix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderPrefix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestplaceholderSuffix != null)
                {
                    dtoRequest["placeholderSuffix"] = ExpressionConverter.ConvertO(__workflow_dtoRequestplaceholderSuffix);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5072InsertTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4120MergeMultiplePdfs, ApiConnectionActionConfiguration> MergeMultiplePdfs(Expression<Func<PdfMergeItem[]>> dtoRequestpDF, Expression<Func<bool>> dtoRequestaddPageNumbers = null, Expression<Func<int>> dtoRequestpageNumberFormat = null, Expression<Func<int>> dtoRequestpageNumberPosition = null, Expression<Func<bool>> dtoRequestaddBookmarks = null, Expression<Func<string>> dtoRequestpDFTitle = null, Expression<Func<string>> dtoRequestpDFAuthor = null, Expression<Func<string>> dtoRequestpDFFileName = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestaddPageNumbers = WorkflowExpression.Compile(dtoRequestaddPageNumbers, nameof(dtoRequestaddPageNumbers), required: false);
            var __workflow_dtoRequestpageNumberFormat = WorkflowExpression.Compile(dtoRequestpageNumberFormat, nameof(dtoRequestpageNumberFormat), required: false);
            var __workflow_dtoRequestpageNumberPosition = WorkflowExpression.Compile(dtoRequestpageNumberPosition, nameof(dtoRequestpageNumberPosition), required: false);
            var __workflow_dtoRequestaddBookmarks = WorkflowExpression.Compile(dtoRequestaddBookmarks, nameof(dtoRequestaddBookmarks), required: false);
            var __workflow_dtoRequestpDFTitle = WorkflowExpression.Compile(dtoRequestpDFTitle, nameof(dtoRequestpDFTitle), required: false);
            var __workflow_dtoRequestpDFAuthor = WorkflowExpression.Compile(dtoRequestpDFAuthor, nameof(dtoRequestpDFAuthor), required: false);
            var __workflow_dtoRequestpDFFileName = WorkflowExpression.Compile(dtoRequestpDFFileName, nameof(dtoRequestpDFFileName), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4120MergeMultiplePdfs, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4120_MergeMultiplePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdfFiles"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDF);
                if (__workflow_dtoRequestaddPageNumbers != null)
                {
                    if (__workflow_dtoRequestaddPageNumbers != null)
                    {
                        dtoRequest["addPageNumbers"] = ExpressionConverter.ConvertO(__workflow_dtoRequestaddPageNumbers);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["addPageNumbers"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpageNumberFormat != null)
                {
                    dtoRequest["pageNumberFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpageNumberFormat);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpageNumberPosition != null)
                {
                    dtoRequest["pageNumberPosition"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpageNumberPosition);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestaddBookmarks != null)
                {
                    if (__workflow_dtoRequestaddBookmarks != null)
                    {
                        dtoRequest["addBookmarks"] = ExpressionConverter.ConvertO(__workflow_dtoRequestaddBookmarks);
                        dtoRequestpropCount++;
                    }

                    dtoRequestpropCount++;
                }
                else
                {
                    dtoRequest["addBookmarks"] = false;
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpDFTitle != null)
                {
                    dtoRequest["pdfTitle"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDFTitle);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpDFAuthor != null)
                {
                    dtoRequest["pdfAuthor"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDFAuthor);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestpDFFileName != null)
                {
                    dtoRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestpDFFileName);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4120MergeMultiplePdfs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4022MergePdfs, ApiConnectionActionConfiguration> MergePdfs(Expression<Func<string>> dtoRequestfile1, Expression<Func<string>> dtoRequestfile2, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestfile1 = WorkflowExpression.Compile(dtoRequestfile1, nameof(dtoRequestfile1), required: true);
            var __workflow_dtoRequestfile2 = WorkflowExpression.Compile(dtoRequestfile2, nameof(dtoRequestfile2), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4022MergePdfs, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4022_MergePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file1"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfile1);
                dtoRequestpropCount++;
                dtoRequest["file2"] = ExpressionConverter.ConvertO(__workflow_dtoRequestfile2);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4022MergePdfs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck, ApiConnectionActionConfiguration> PatternMatchCheck(Expression<Func<string>> dtoRequestV2120PatternMatchCheckinputText, Expression<Func<string>> dtoRequestV2120PatternMatchCheckmatchPattern)
        {
            var __workflow_dtoRequestV2120PatternMatchCheckinputText = WorkflowExpression.Compile(dtoRequestV2120PatternMatchCheckinputText, nameof(dtoRequestV2120PatternMatchCheckinputText), required: true);
            var __workflow_dtoRequestV2120PatternMatchCheckmatchPattern = WorkflowExpression.Compile(dtoRequestV2120PatternMatchCheckmatchPattern, nameof(dtoRequestV2120PatternMatchCheckmatchPattern), required: true);
            return new DeferredBodyAction<DtoResponseV2120MatchPatternCheck, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata, ApiConnectionActionConfiguration> PdfMetadata(Expression<Func<string>> dtoRequestV4031PdfMetadataFile)
        {
            var __workflow_dtoRequestV4031PdfMetadataFile = WorkflowExpression.Compile(dtoRequestV4031PdfMetadataFile, nameof(dtoRequestV4031PdfMetadataFile), required: true);
            return new DeferredBodyAction<DtoResponseV4031PdfMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4031_PdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4031PdfMetadata = new JObject();
                var dtoRequestV4031PdfMetadatapropCount = 0;
                dtoRequestV4031PdfMetadatapropCount++;
                dtoRequestV4031PdfMetadata["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestV4031PdfMetadataFile);
                if (dtoRequestV4031PdfMetadatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV4031PdfMetadata;
                }

                return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4042ProtectPdf, ApiConnectionActionConfiguration> ProtectPdf(Expression<Func<string>> dtoRequestFile, Expression<Func<string>> dtoRequestownerPassword = null, Expression<Func<string>> dtoRequestuserPassword = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestFile = WorkflowExpression.Compile(dtoRequestFile, nameof(dtoRequestFile), required: true);
            var __workflow_dtoRequestownerPassword = WorkflowExpression.Compile(dtoRequestownerPassword, nameof(dtoRequestownerPassword), required: false);
            var __workflow_dtoRequestuserPassword = WorkflowExpression.Compile(dtoRequestuserPassword, nameof(dtoRequestuserPassword), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4042ProtectPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4042_ProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestFile);
                if (__workflow_dtoRequestownerPassword != null)
                {
                    dtoRequest["ownerPassword"] = ExpressionConverter.ConvertO(__workflow_dtoRequestownerPassword);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestuserPassword != null)
                {
                    dtoRequest["userPassword"] = ExpressionConverter.ConvertO(__workflow_dtoRequestuserPassword);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4042ProtectPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode, ApiConnectionActionConfiguration> ReadCode(Expression<Func<string>> dtoRequestReadCodeDataqROrBarcode)
        {
            var __workflow_dtoRequestReadCodeDataqROrBarcode = WorkflowExpression.Compile(dtoRequestReadCodeDataqROrBarcode, nameof(dtoRequestReadCodeDataqROrBarcode), required: true);
            return new DeferredBodyAction<DtoResponseV3051ReadCode, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression, ApiConnectionActionConfiguration> RegularExpression(Expression<Func<string>> dtoRequestV2011RegularExpressiontextToMatch, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpression = null, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpressionOption = null)
        {
            var __workflow_dtoRequestV2011RegularExpressiontextToMatch = WorkflowExpression.Compile(dtoRequestV2011RegularExpressiontextToMatch, nameof(dtoRequestV2011RegularExpressiontextToMatch), required: true);
            var __workflow_dtoRequestV2011RegularExpressionregularExpression = WorkflowExpression.Compile(dtoRequestV2011RegularExpressionregularExpression, nameof(dtoRequestV2011RegularExpressionregularExpression), required: false);
            var __workflow_dtoRequestV2011RegularExpressionregularExpressionOption = WorkflowExpression.Compile(dtoRequestV2011RegularExpressionregularExpressionOption, nameof(dtoRequestV2011RegularExpressionregularExpressionOption), required: false);
            return new DeferredBodyAction<DtoResponseV2011RegularExpression, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV4111RemovePagesFromPdf, ApiConnectionActionConfiguration> RemovePagesFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<string>> dtoRequestpages, Expression<Func<bool>> dtoRequestinputIs1Based = null, Expression<Func<int>> dtoRequestmode = null, Expression<Func<bool>> dtoRequestfailIfPageOutOfRange = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestpDF = WorkflowExpression.Compile(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            var __workflow_dtoRequestpages = WorkflowExpression.Compile(dtoRequestpages, nameof(dtoRequestpages), required: true);
            var __workflow_dtoRequestinputIs1Based = WorkflowExpression.Compile(dtoRequestinputIs1Based, nameof(dtoRequestinputIs1Based), required: false);
            var __workflow_dtoRequestmode = WorkflowExpression.Compile(dtoRequestmode, nameof(dtoRequestmode), required: false);
            var __workflow_dtoRequestfailIfPageOutOfRange = WorkflowExpression.Compile(dtoRequestfailIfPageOutOfRange, nameof(dtoRequestfailIfPageOutOfRange), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4111RemovePagesFromPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4111_RemovePagesFromPdf";
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

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4111RemovePagesFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern, ApiConnectionActionConfiguration> ReplaceTextWithPattern(Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatterninputText, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternsearchPattern, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
        {
            var __workflow_dtoRequestV2110ReplaceTextWithPatterninputText = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPatterninputText, nameof(dtoRequestV2110ReplaceTextWithPatterninputText), required: true);
            var __workflow_dtoRequestV2110ReplaceTextWithPatternsearchPattern = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPatternsearchPattern, nameof(dtoRequestV2110ReplaceTextWithPatternsearchPattern), required: true);
            var __workflow_dtoRequestV2110ReplaceTextWithPatternreplacementText = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPatternreplacementText, nameof(dtoRequestV2110ReplaceTextWithPatternreplacementText), required: false);
            return new DeferredBodyAction<DtoResponseV2110ReplaceTextWithPattern, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV3023ResizeImage, ApiConnectionActionConfiguration> ResizeImage(Expression<Func<string>> dtoRequestimageFile, Expression<Func<double>> dtoRequestimageWidth = null, Expression<Func<double>> dtoRequestimageHeight = null, Expression<Func<string>> dtoRequestresizeBy = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestimageFile = WorkflowExpression.Compile(dtoRequestimageFile, nameof(dtoRequestimageFile), required: true);
            var __workflow_dtoRequestimageWidth = WorkflowExpression.Compile(dtoRequestimageWidth, nameof(dtoRequestimageWidth), required: false);
            var __workflow_dtoRequestimageHeight = WorkflowExpression.Compile(dtoRequestimageHeight, nameof(dtoRequestimageHeight), required: false);
            var __workflow_dtoRequestresizeBy = WorkflowExpression.Compile(dtoRequestresizeBy, nameof(dtoRequestresizeBy), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3023ResizeImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3023_ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageFile);
                if (__workflow_dtoRequestimageWidth != null)
                {
                    dtoRequest["width"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageWidth);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestimageHeight != null)
                {
                    dtoRequest["height"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageHeight);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestresizeBy != null)
                {
                    dtoRequest["resizeBy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestresizeBy);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3023ResizeImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3032RotateImage, ApiConnectionActionConfiguration> RotateImage(Expression<Func<string>> dtoRequestimageFile, Expression<Func<double>> dtoRequestrotate = null, Expression<Func<string>> dtoRequestoutputFormat = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestimageFile = WorkflowExpression.Compile(dtoRequestimageFile, nameof(dtoRequestimageFile), required: true);
            var __workflow_dtoRequestrotate = WorkflowExpression.Compile(dtoRequestrotate, nameof(dtoRequestrotate), required: false);
            var __workflow_dtoRequestoutputFormat = WorkflowExpression.Compile(dtoRequestoutputFormat, nameof(dtoRequestoutputFormat), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV3032RotateImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3032_RotateImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestimageFile);
                if (__workflow_dtoRequestrotate != null)
                {
                    dtoRequest["rotate"] = ExpressionConverter.ConvertO(__workflow_dtoRequestrotate);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestoutputFormat != null)
                {
                    dtoRequest["outFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestoutputFormat);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV3032RotateImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2151RunCode, ApiConnectionActionConfiguration> RunCode(Expression<Func<string>> dtopythonOrJavaScriptCode, Expression<Func<int>> dtoruntime = null, Expression<Func<int>> dtotimeoutSeconds = null, Expression<Func<bool>> dtoprintLastExpression = null)
        {
            var __workflow_dtopythonOrJavaScriptCode = WorkflowExpression.Compile(dtopythonOrJavaScriptCode, nameof(dtopythonOrJavaScriptCode), required: true);
            var __workflow_dtoruntime = WorkflowExpression.Compile(dtoruntime, nameof(dtoruntime), required: false);
            var __workflow_dtotimeoutSeconds = WorkflowExpression.Compile(dtotimeoutSeconds, nameof(dtotimeoutSeconds), required: false);
            var __workflow_dtoprintLastExpression = WorkflowExpression.Compile(dtoprintLastExpression, nameof(dtoprintLastExpression), required: false);
            return new DeferredBodyAction<DtoResponseV2151RunCode, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit, ApiConnectionActionConfiguration> SmartTextSplit(Expression<Func<string>> dtoRequestV2130SmartTextSplitinputText, Expression<Func<string>> dtoRequestV2130SmartTextSplitsplitPattern = null, Expression<Func<bool>> dtoRequestV2130SmartTextSplittrimEnabled = null, Expression<Func<string>> dtoRequestV2130SmartTextSplittrimStrings = null)
        {
            var __workflow_dtoRequestV2130SmartTextSplitinputText = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplitinputText, nameof(dtoRequestV2130SmartTextSplitinputText), required: true);
            var __workflow_dtoRequestV2130SmartTextSplitsplitPattern = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplitsplitPattern, nameof(dtoRequestV2130SmartTextSplitsplitPattern), required: false);
            var __workflow_dtoRequestV2130SmartTextSplittrimEnabled = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplittrimEnabled, nameof(dtoRequestV2130SmartTextSplittrimEnabled), required: false);
            var __workflow_dtoRequestV2130SmartTextSplittrimStrings = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplittrimStrings, nameof(dtoRequestV2130SmartTextSplittrimStrings), required: false);
            return new DeferredBodyAction<DtoResponseV2130SmartTextSplit, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2061SortCsv, ApiConnectionActionConfiguration> SortCsv(Expression<Func<string>> dtoRequestV2061SortCsvcSV, Expression<Func<bool>> dtoRequestV2061SortCsvcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV2061SortCsvremoveEmptyRows = null, Expression<Func<int>> dtoRequestV2061SortCsvskipANumberOfRows = null, Expression<Func<int>> dtoRequestV2061SortCsvstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV2061SortCsvseparator = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, Expression<Func<string>> dtoRequestV2061SortCsvsortColumn = null, Expression<Func<string>> dtoRequestV2061SortCsvfurtherSortingColumn = null, Expression<Func<bool>> dtoRequestV2061SortCsvreverseOrder = null)
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
            return new DeferredBodyAction<DtoResponseV2061SortCsv, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2051SortJson, ApiConnectionActionConfiguration> SortJson(Expression<Func<string>> dtoRequestV2051SortJsonjSON, Expression<Func<string>> dtoRequestV2051SortJsonsortProperty = null, Expression<Func<string>> dtoRequestV2051SortJsonfurtherSortingProperty = null, Expression<Func<bool>> dtoRequestV2051SortJsonreverseOrder = null)
        {
            var __workflow_dtoRequestV2051SortJsonjSON = WorkflowExpression.Compile(dtoRequestV2051SortJsonjSON, nameof(dtoRequestV2051SortJsonjSON), required: true);
            var __workflow_dtoRequestV2051SortJsonsortProperty = WorkflowExpression.Compile(dtoRequestV2051SortJsonsortProperty, nameof(dtoRequestV2051SortJsonsortProperty), required: false);
            var __workflow_dtoRequestV2051SortJsonfurtherSortingProperty = WorkflowExpression.Compile(dtoRequestV2051SortJsonfurtherSortingProperty, nameof(dtoRequestV2051SortJsonfurtherSortingProperty), required: false);
            var __workflow_dtoRequestV2051SortJsonreverseOrder = WorkflowExpression.Compile(dtoRequestV2051SortJsonreverseOrder, nameof(dtoRequestV2051SortJsonreverseOrder), required: false);
            return new DeferredBodyAction<DtoResponseV2051SortJson, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV2041Translate, ApiConnectionActionConfiguration> Translate(Expression<Func<string>> dtoRequestV2041Translatetext, Expression<Func<string>> dtoRequestV2041Translateto, Expression<Func<string>> dtoRequestV2041Translatefrom = null)
        {
            var __workflow_dtoRequestV2041Translatetext = WorkflowExpression.Compile(dtoRequestV2041Translatetext, nameof(dtoRequestV2041Translatetext), required: true);
            var __workflow_dtoRequestV2041Translateto = WorkflowExpression.Compile(dtoRequestV2041Translateto, nameof(dtoRequestV2041Translateto), required: true);
            var __workflow_dtoRequestV2041Translatefrom = WorkflowExpression.Compile(dtoRequestV2041Translatefrom, nameof(dtoRequestV2041Translatefrom), required: false);
            return new DeferredBodyAction<DtoResponseV2041Translate, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DtoResponseV4052UnProtectPdf, ApiConnectionActionConfiguration> UnProtectPdf(Expression<Func<string>> dtoRequestFile, Expression<Func<string>> dtoRequestownerPassword = null, Expression<Func<bool>> dtoRequestremovePermissions = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestFile = WorkflowExpression.Compile(dtoRequestFile, nameof(dtoRequestFile), required: true);
            var __workflow_dtoRequestownerPassword = WorkflowExpression.Compile(dtoRequestownerPassword, nameof(dtoRequestownerPassword), required: false);
            var __workflow_dtoRequestremovePermissions = WorkflowExpression.Compile(dtoRequestremovePermissions, nameof(dtoRequestremovePermissions), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV4052UnProtectPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4052_UnProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestFile);
                if (__workflow_dtoRequestownerPassword != null)
                {
                    dtoRequest["ownerPassword"] = ExpressionConverter.ConvertO(__workflow_dtoRequestownerPassword);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestremovePermissions != null)
                {
                    dtoRequest["removePermissions"] = ExpressionConverter.ConvertO(__workflow_dtoRequestremovePermissions);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV4052UnProtectPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5151UpdateMultipleWordContentControls, ApiConnectionActionConfiguration> UpdateMultipleWordContentControls(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<ContentControl[]>> dtoRequestcontentControl, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestcontentControl = WorkflowExpression.Compile(dtoRequestcontentControl, nameof(dtoRequestcontentControl), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5151UpdateMultipleWordContentControls, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5151_UpdateMultipleWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["contentControls"] = ExpressionConverter.ConvertO(__workflow_dtoRequestcontentControl);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5151UpdateMultipleWordContentControls>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5141UpdateWordContentControl, ApiConnectionActionConfiguration> UpdateWordContentControl(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<string>> dtoRequestname, Expression<Func<string>> dtoRequestvalue = null, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestname = WorkflowExpression.Compile(dtoRequestname, nameof(dtoRequestname), required: true);
            var __workflow_dtoRequestvalue = WorkflowExpression.Compile(dtoRequestvalue, nameof(dtoRequestvalue), required: false);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5141UpdateWordContentControl, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5141_UpdateWordContentControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                dtoRequestpropCount++;
                dtoRequest["name"] = ExpressionConverter.ConvertO(__workflow_dtoRequestname);
                if (__workflow_dtoRequestvalue != null)
                {
                    dtoRequest["value"] = ExpressionConverter.ConvertO(__workflow_dtoRequestvalue);
                    dtoRequestpropCount++;
                }

                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5141UpdateWordContentControl>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5131UpdateWordTableOfContents, ApiConnectionActionConfiguration> UpdateWordTableOfContents(Expression<Func<string>> dtoRequestexistingFileContent, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestexistingFileContent = WorkflowExpression.Compile(dtoRequestexistingFileContent, nameof(dtoRequestexistingFileContent), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV5131UpdateWordTableOfContents, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5131_UpdateWordTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["file"] = ExpressionConverter.ConvertO(__workflow_dtoRequestexistingFileContent);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV5131UpdateWordTableOfContents>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2032UrlToFile, ApiConnectionActionConfiguration> UrlToFile(Expression<Func<string>> dtoRequestuRL, Expression<Func<int>> dtoRequestreduceResponseSize = null)
        {
            var __workflow_dtoRequestuRL = WorkflowExpression.Compile(dtoRequestuRL, nameof(dtoRequestuRL), required: true);
            var __workflow_dtoRequestreduceResponseSize = WorkflowExpression.Compile(dtoRequestreduceResponseSize, nameof(dtoRequestreduceResponseSize), required: false);
            return new DeferredBodyAction<DtoResponseV2032UrlToFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2032_UrlToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["url"] = ExpressionConverter.ConvertO(__workflow_dtoRequestuRL);
                if (__workflow_dtoRequestreduceResponseSize != null)
                {
                    dtoRequest["fileResponseMode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestreduceResponseSize);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpropCount > 0)
                {
                    callPayload.Body = dtoRequest;
                }

                return new ApiConnectionAction<DtoResponseV2032UrlToFile>(callPayload);
            });
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