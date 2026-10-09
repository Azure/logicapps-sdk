//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Converterbypower2appsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildAddHtmlToWord))]
        public IBodyWorkflowAction<DtoResponseV5101AddHtmlToWord> AddHtmlToWord([WorkflowExpression] Func<string> dtoRequestV5101AddHtmlToWordhTML, [WorkflowExpression] Func<string> dtoRequestV5101AddHtmlToWordexistingFileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5101AddHtmlToWord> __BuildAddHtmlToWord(WorkflowExpression<string> dtoRequestV5101AddHtmlToWordhTML, WorkflowExpression<string> dtoRequestV5101AddHtmlToWordexistingFileContent = null)
        {
            WorkflowExpression.Validate(dtoRequestV5101AddHtmlToWordhTML, nameof(dtoRequestV5101AddHtmlToWordhTML), required: true);
            WorkflowExpression.Validate(dtoRequestV5101AddHtmlToWordexistingFileContent, nameof(dtoRequestV5101AddHtmlToWordexistingFileContent), required: false);
            return new DeferredBodyAction<DtoResponseV5101AddHtmlToWord>(() =>
            {
                var apiCallPath = "/V5101_AddHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5101AddHtmlToWord = new JObject();
                var dtoRequestV5101AddHtmlToWordpropCount = 0;
                if (dtoRequestV5101AddHtmlToWordexistingFileContent != null)
                {
                    dtoRequestV5101AddHtmlToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5101AddHtmlToWordexistingFileContent);
                    dtoRequestV5101AddHtmlToWordpropCount++;
                }

                dtoRequestV5101AddHtmlToWordpropCount++;
                dtoRequestV5101AddHtmlToWord["html"] = ExpressionConverter.ConvertO(dtoRequestV5101AddHtmlToWordhTML);
                if (dtoRequestV5101AddHtmlToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV5101AddHtmlToWord;
                }

                return new ApiConnectionAction<DtoResponseV5101AddHtmlToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildAddImageToWord))]
        public IBodyWorkflowAction<DtoResponseV5031AddImageToWord> AddImageToWord([WorkflowExpression] Func<string> dtoRequestV5031AddImageToWordimage, [WorkflowExpression] Func<string> dtoRequestV5031AddImageToWordexistingFileContent = null, [WorkflowExpression] Func<string> dtoRequestV5031AddImageToWordcaptionText = null, [WorkflowExpression] Func<int> dtoRequestV5031AddImageToWordmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV5031AddImageToWordmaximumImageHeight = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5031AddImageToWord> __BuildAddImageToWord(WorkflowExpression<string> dtoRequestV5031AddImageToWordimage, WorkflowExpression<string> dtoRequestV5031AddImageToWordexistingFileContent = null, WorkflowExpression<string> dtoRequestV5031AddImageToWordcaptionText = null, WorkflowExpression<int> dtoRequestV5031AddImageToWordmaximumImageWidth = null, WorkflowExpression<int> dtoRequestV5031AddImageToWordmaximumImageHeight = null)
        {
            WorkflowExpression.Validate(dtoRequestV5031AddImageToWordimage, nameof(dtoRequestV5031AddImageToWordimage), required: true);
            WorkflowExpression.Validate(dtoRequestV5031AddImageToWordexistingFileContent, nameof(dtoRequestV5031AddImageToWordexistingFileContent), required: false);
            WorkflowExpression.Validate(dtoRequestV5031AddImageToWordcaptionText, nameof(dtoRequestV5031AddImageToWordcaptionText), required: false);
            WorkflowExpression.Validate(dtoRequestV5031AddImageToWordmaximumImageWidth, nameof(dtoRequestV5031AddImageToWordmaximumImageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV5031AddImageToWordmaximumImageHeight, nameof(dtoRequestV5031AddImageToWordmaximumImageHeight), required: false);
            return new DeferredBodyAction<DtoResponseV5031AddImageToWord>(() =>
            {
                var apiCallPath = "/V5031_AddImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5031AddImageToWord = new JObject();
                var dtoRequestV5031AddImageToWordpropCount = 0;
                if (dtoRequestV5031AddImageToWordexistingFileContent != null)
                {
                    dtoRequestV5031AddImageToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5031AddImageToWordexistingFileContent);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                dtoRequestV5031AddImageToWordpropCount++;
                dtoRequestV5031AddImageToWord["image"] = ExpressionConverter.ConvertO(dtoRequestV5031AddImageToWordimage);
                if (dtoRequestV5031AddImageToWordcaptionText != null)
                {
                    dtoRequestV5031AddImageToWord["imageText"] = ExpressionConverter.ConvertO(dtoRequestV5031AddImageToWordcaptionText);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (dtoRequestV5031AddImageToWordmaximumImageWidth != null)
                {
                    dtoRequestV5031AddImageToWord["maxWidth"] = ExpressionConverter.ConvertO(dtoRequestV5031AddImageToWordmaximumImageWidth);
                    dtoRequestV5031AddImageToWordpropCount++;
                }

                if (dtoRequestV5031AddImageToWordmaximumImageHeight != null)
                {
                    dtoRequestV5031AddImageToWord["maxHeight"] = ExpressionConverter.ConvertO(dtoRequestV5031AddImageToWordmaximumImageHeight);
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
        [WorkflowExpressionFactory(nameof(__BuildAddImageWithinTableToWord))]
        public IBodyWorkflowAction<DtoResponseV5042AddImageWithinTableToWord> AddImageWithinTableToWord([WorkflowExpression] Func<string> dtoRequestV5042AddImageWithinTableToWordimage, [WorkflowExpression] Func<string> dtoRequestV5042AddImageWithinTableToWordexistingFileContent = null, [WorkflowExpression] Func<string> dtoRequestV5042AddImageWithinTableToWorddescriptionText = null, [WorkflowExpression] Func<int> dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5042AddImageWithinTableToWord> __BuildAddImageWithinTableToWord(WorkflowExpression<string> dtoRequestV5042AddImageWithinTableToWordimage, WorkflowExpression<string> dtoRequestV5042AddImageWithinTableToWordexistingFileContent = null, WorkflowExpression<string> dtoRequestV5042AddImageWithinTableToWorddescriptionText = null, WorkflowExpression<int> dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = null, WorkflowExpression<int> dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = null)
        {
            WorkflowExpression.Validate(dtoRequestV5042AddImageWithinTableToWordimage, nameof(dtoRequestV5042AddImageWithinTableToWordimage), required: true);
            WorkflowExpression.Validate(dtoRequestV5042AddImageWithinTableToWordexistingFileContent, nameof(dtoRequestV5042AddImageWithinTableToWordexistingFileContent), required: false);
            WorkflowExpression.Validate(dtoRequestV5042AddImageWithinTableToWorddescriptionText, nameof(dtoRequestV5042AddImageWithinTableToWorddescriptionText), required: false);
            WorkflowExpression.Validate(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth, nameof(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight, nameof(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight), required: false);
            return new DeferredBodyAction<DtoResponseV5042AddImageWithinTableToWord>(() =>
            {
                var apiCallPath = "/V5042_AddImageWithinTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5042AddImageWithinTableToWord = new JObject();
                var dtoRequestV5042AddImageWithinTableToWordpropCount = 0;
                if (dtoRequestV5042AddImageWithinTableToWordexistingFileContent != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5042AddImageWithinTableToWordexistingFileContent);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                dtoRequestV5042AddImageWithinTableToWordpropCount++;
                dtoRequestV5042AddImageWithinTableToWord["image"] = ExpressionConverter.ConvertO(dtoRequestV5042AddImageWithinTableToWordimage);
                if (dtoRequestV5042AddImageWithinTableToWorddescriptionText != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["imageText"] = ExpressionConverter.ConvertO(dtoRequestV5042AddImageWithinTableToWorddescriptionText);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["maxWidth"] = ExpressionConverter.ConvertO(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth);
                    dtoRequestV5042AddImageWithinTableToWordpropCount++;
                }

                if (dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight != null)
                {
                    dtoRequestV5042AddImageWithinTableToWord["maxHeight"] = ExpressionConverter.ConvertO(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight);
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
        [WorkflowExpressionFactory(nameof(__BuildAddTableToWord))]
        public IBodyWorkflowAction<DtoResponseV5052AddTableToWord> AddTableToWord([WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordtableData, [WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordexistingFileContent = null, [WorkflowExpression] Func<bool> dtoRequestV5052AddTableToWordshowHeaders = null, [WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordtableStyle = null, [WorkflowExpression] Func<string> dtoRequestV5052AddTableToWordtableCaption = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5052AddTableToWord> __BuildAddTableToWord(WorkflowExpression<string> dtoRequestV5052AddTableToWordtableData, WorkflowExpression<string> dtoRequestV5052AddTableToWordexistingFileContent = null, WorkflowExpression<bool> dtoRequestV5052AddTableToWordshowHeaders = null, WorkflowExpression<string> dtoRequestV5052AddTableToWordtableStyle = null, WorkflowExpression<string> dtoRequestV5052AddTableToWordtableCaption = null)
        {
            WorkflowExpression.Validate(dtoRequestV5052AddTableToWordtableData, nameof(dtoRequestV5052AddTableToWordtableData), required: true);
            WorkflowExpression.Validate(dtoRequestV5052AddTableToWordexistingFileContent, nameof(dtoRequestV5052AddTableToWordexistingFileContent), required: false);
            WorkflowExpression.Validate(dtoRequestV5052AddTableToWordshowHeaders, nameof(dtoRequestV5052AddTableToWordshowHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV5052AddTableToWordtableStyle, nameof(dtoRequestV5052AddTableToWordtableStyle), required: false);
            WorkflowExpression.Validate(dtoRequestV5052AddTableToWordtableCaption, nameof(dtoRequestV5052AddTableToWordtableCaption), required: false);
            return new DeferredBodyAction<DtoResponseV5052AddTableToWord>(() =>
            {
                var apiCallPath = "/V5052_AddTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5052AddTableToWord = new JObject();
                var dtoRequestV5052AddTableToWordpropCount = 0;
                if (dtoRequestV5052AddTableToWordexistingFileContent != null)
                {
                    dtoRequestV5052AddTableToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordexistingFileContent);
                    dtoRequestV5052AddTableToWordpropCount++;
                }

                dtoRequestV5052AddTableToWordpropCount++;
                dtoRequestV5052AddTableToWord["table"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordtableData);
                if (dtoRequestV5052AddTableToWordshowHeaders != null)
                {
                    if (dtoRequestV5052AddTableToWordshowHeaders != null)
                    {
                        dtoRequestV5052AddTableToWord["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordshowHeaders);
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
                        dtoRequestV5052AddTableToWord["tableStyle"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordtableStyle);
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
                    dtoRequestV5052AddTableToWord["tableText"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordtableCaption);
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
        [WorkflowExpressionFactory(nameof(__BuildAddTextToWord))]
        public IBodyWorkflowAction<DtoResponseV5061AddTextToWord> AddTextToWord([WorkflowExpression] Func<string> dtoRequestAddTextToWordDatatype, [WorkflowExpression] Func<string> dtoRequestAddTextToWordDatatext, [WorkflowExpression] Func<string> dtoRequestAddTextToWordDataexistingFileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5061AddTextToWord> __BuildAddTextToWord(WorkflowExpression<string> dtoRequestAddTextToWordDatatype, WorkflowExpression<string> dtoRequestAddTextToWordDatatext, WorkflowExpression<string> dtoRequestAddTextToWordDataexistingFileContent = null)
        {
            WorkflowExpression.Validate(dtoRequestAddTextToWordDatatype, nameof(dtoRequestAddTextToWordDatatype), required: true);
            WorkflowExpression.Validate(dtoRequestAddTextToWordDatatext, nameof(dtoRequestAddTextToWordDatatext), required: true);
            WorkflowExpression.Validate(dtoRequestAddTextToWordDataexistingFileContent, nameof(dtoRequestAddTextToWordDataexistingFileContent), required: false);
            return new DeferredBodyAction<DtoResponseV5061AddTextToWord>(() =>
            {
                var apiCallPath = "/V5061_AddTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestAddTextToWordData = new JObject();
                var dtoRequestAddTextToWordDatapropCount = 0;
                if (dtoRequestAddTextToWordDataexistingFileContent != null)
                {
                    dtoRequestAddTextToWordData["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestAddTextToWordDataexistingFileContent);
                    dtoRequestAddTextToWordDatapropCount++;
                }

                dtoRequestAddTextToWordDatapropCount++;
                dtoRequestAddTextToWordData["sectionType"] = ExpressionConverter.ConvertO(dtoRequestAddTextToWordDatatype);
                dtoRequestAddTextToWordDatapropCount++;
                dtoRequestAddTextToWordData["text"] = ExpressionConverter.ConvertO(dtoRequestAddTextToWordDatatext);
                if (dtoRequestAddTextToWordDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestAddTextToWordData;
                }

                return new ApiConnectionAction<DtoResponseV5061AddTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildCombineCsvs))]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs> CombineCsvs([WorkflowExpression] Func<string> dtoRequestV2081CombineCsvsmainCSV, [WorkflowExpression] Func<string> dtoRequestV2081CombineCsvscombineColumnName, [WorkflowExpression] Func<string> dtoRequestV2081CombineCsvssecondCSV, [WorkflowExpression] Func<string> dtoRequestV2081CombineCsvssecondCSVColumn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs> __BuildCombineCsvs(WorkflowExpression<string> dtoRequestV2081CombineCsvsmainCSV, WorkflowExpression<string> dtoRequestV2081CombineCsvscombineColumnName, WorkflowExpression<string> dtoRequestV2081CombineCsvssecondCSV, WorkflowExpression<string> dtoRequestV2081CombineCsvssecondCSVColumn = null)
        {
            WorkflowExpression.Validate(dtoRequestV2081CombineCsvsmainCSV, nameof(dtoRequestV2081CombineCsvsmainCSV), required: true);
            WorkflowExpression.Validate(dtoRequestV2081CombineCsvscombineColumnName, nameof(dtoRequestV2081CombineCsvscombineColumnName), required: true);
            WorkflowExpression.Validate(dtoRequestV2081CombineCsvssecondCSV, nameof(dtoRequestV2081CombineCsvssecondCSV), required: true);
            WorkflowExpression.Validate(dtoRequestV2081CombineCsvssecondCSVColumn, nameof(dtoRequestV2081CombineCsvssecondCSVColumn), required: false);
            return new DeferredBodyAction<DtoResponseV2081CombineCsvs>(() =>
            {
                var apiCallPath = "/V2081_CombineCsvs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2081CombineCsvs = new JObject();
                var dtoRequestV2081CombineCsvspropCount = 0;
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["mainCsv"] = ExpressionConverter.ConvertO(dtoRequestV2081CombineCsvsmainCSV);
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["mainCsvColumn"] = ExpressionConverter.ConvertO(dtoRequestV2081CombineCsvscombineColumnName);
                dtoRequestV2081CombineCsvspropCount++;
                dtoRequestV2081CombineCsvs["secondCsv"] = ExpressionConverter.ConvertO(dtoRequestV2081CombineCsvssecondCSV);
                if (dtoRequestV2081CombineCsvssecondCSVColumn != null)
                {
                    dtoRequestV2081CombineCsvs["secondCsvColumn"] = ExpressionConverter.ConvertO(dtoRequestV2081CombineCsvssecondCSVColumn);
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
        [WorkflowExpressionFactory(nameof(__BuildCombineJsonArrays))]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays> CombineJsonArrays([WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArraysmainJSON, [WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArrayscombinePropertyName, [WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArrayssecondJSON, [WorkflowExpression] Func<string> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays> __BuildCombineJsonArrays(WorkflowExpression<string> dtoRequestV2091CombineJsonArraysmainJSON, WorkflowExpression<string> dtoRequestV2091CombineJsonArrayscombinePropertyName, WorkflowExpression<string> dtoRequestV2091CombineJsonArrayssecondJSON, WorkflowExpression<string> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
        {
            WorkflowExpression.Validate(dtoRequestV2091CombineJsonArraysmainJSON, nameof(dtoRequestV2091CombineJsonArraysmainJSON), required: true);
            WorkflowExpression.Validate(dtoRequestV2091CombineJsonArrayscombinePropertyName, nameof(dtoRequestV2091CombineJsonArrayscombinePropertyName), required: true);
            WorkflowExpression.Validate(dtoRequestV2091CombineJsonArrayssecondJSON, nameof(dtoRequestV2091CombineJsonArrayssecondJSON), required: true);
            WorkflowExpression.Validate(dtoRequestV2091CombineJsonArrayssecondJSONProperty, nameof(dtoRequestV2091CombineJsonArrayssecondJSONProperty), required: false);
            return new DeferredBodyAction<DtoResponseV2091CombineJsonArrays>(() =>
            {
                var apiCallPath = "/V2091_CombineJsonArrays";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2091CombineJsonArrays = new JObject();
                var dtoRequestV2091CombineJsonArrayspropCount = 0;
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["mainJson"] = ExpressionConverter.ConvertO(dtoRequestV2091CombineJsonArraysmainJSON);
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["mainJsonProperty"] = ExpressionConverter.ConvertO(dtoRequestV2091CombineJsonArrayscombinePropertyName);
                dtoRequestV2091CombineJsonArrayspropCount++;
                dtoRequestV2091CombineJsonArrays["secondJson"] = ExpressionConverter.ConvertO(dtoRequestV2091CombineJsonArrayssecondJSON);
                if (dtoRequestV2091CombineJsonArrayssecondJSONProperty != null)
                {
                    dtoRequestV2091CombineJsonArrays["secondJsonProperty"] = ExpressionConverter.ConvertO(dtoRequestV2091CombineJsonArrayssecondJSONProperty);
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
        [WorkflowExpressionFactory(nameof(__BuildCompressImage))]
        public IBodyWorkflowAction<DtoResponseV3041CompressImage> CompressImage([WorkflowExpression] Func<string> dtoRequestCompressImageimageFile, [WorkflowExpression] Func<int> dtoRequestCompressImageimageQuality = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3041CompressImage> __BuildCompressImage(WorkflowExpression<string> dtoRequestCompressImageimageFile, WorkflowExpression<int> dtoRequestCompressImageimageQuality = null)
        {
            WorkflowExpression.Validate(dtoRequestCompressImageimageFile, nameof(dtoRequestCompressImageimageFile), required: true);
            WorkflowExpression.Validate(dtoRequestCompressImageimageQuality, nameof(dtoRequestCompressImageimageQuality), required: false);
            return new DeferredBodyAction<DtoResponseV3041CompressImage>(() =>
            {
                var apiCallPath = "/V3041_CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestCompressImage = new JObject();
                var dtoRequestCompressImagepropCount = 0;
                dtoRequestCompressImagepropCount++;
                dtoRequestCompressImage["file"] = ExpressionConverter.ConvertO(dtoRequestCompressImageimageFile);
                if (dtoRequestCompressImageimageQuality != null)
                {
                    dtoRequestCompressImage["quality"] = ExpressionConverter.ConvertO(dtoRequestCompressImageimageQuality);
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
        [WorkflowExpressionFactory(nameof(__BuildCompressPdf))]
        public IBodyWorkflowAction<DtoResponseV4080CompressPdf> CompressPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<bool> dtoRequestcompressImages = null, [WorkflowExpression] Func<int> dtoRequestimageQuality = null, [WorkflowExpression] Func<bool> dtoRequestoptimizeFonts = null, [WorkflowExpression] Func<bool> dtoRequestoptimizePageContents = null, [WorkflowExpression] Func<bool> dtoRequestremoveMetadata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4080CompressPdf> __BuildCompressPdf(WorkflowExpression<string> dtoRequestpDF, WorkflowExpression<bool> dtoRequestcompressImages = null, WorkflowExpression<int> dtoRequestimageQuality = null, WorkflowExpression<bool> dtoRequestoptimizeFonts = null, WorkflowExpression<bool> dtoRequestoptimizePageContents = null, WorkflowExpression<bool> dtoRequestremoveMetadata = null)
        {
            WorkflowExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            WorkflowExpression.Validate(dtoRequestcompressImages, nameof(dtoRequestcompressImages), required: false);
            WorkflowExpression.Validate(dtoRequestimageQuality, nameof(dtoRequestimageQuality), required: false);
            WorkflowExpression.Validate(dtoRequestoptimizeFonts, nameof(dtoRequestoptimizeFonts), required: false);
            WorkflowExpression.Validate(dtoRequestoptimizePageContents, nameof(dtoRequestoptimizePageContents), required: false);
            WorkflowExpression.Validate(dtoRequestremoveMetadata, nameof(dtoRequestremoveMetadata), required: false);
            return new DeferredBodyAction<DtoResponseV4080CompressPdf>(() =>
            {
                var apiCallPath = "/V4080_CompressPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(dtoRequestpDF);
                if (dtoRequestcompressImages != null)
                {
                    dtoRequest["compressImages"] = ExpressionConverter.ConvertO(dtoRequestcompressImages);
                    dtoRequestpropCount++;
                }

                if (dtoRequestimageQuality != null)
                {
                    dtoRequest["imageQuality"] = ExpressionConverter.ConvertO(dtoRequestimageQuality);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoptimizeFonts != null)
                {
                    dtoRequest["optimizeFont"] = ExpressionConverter.ConvertO(dtoRequestoptimizeFonts);
                    dtoRequestpropCount++;
                }

                if (dtoRequestoptimizePageContents != null)
                {
                    dtoRequest["optimizePageContents"] = ExpressionConverter.ConvertO(dtoRequestoptimizePageContents);
                    dtoRequestpropCount++;
                }

                if (dtoRequestremoveMetadata != null)
                {
                    dtoRequest["removeMetadata"] = ExpressionConverter.ConvertO(dtoRequestremoveMetadata);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertColor))]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor> ConvertColor([WorkflowExpression] Func<string> dtoRequestV2071ConvertColorcolor)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor> __BuildConvertColor(WorkflowExpression<string> dtoRequestV2071ConvertColorcolor)
        {
            WorkflowExpression.Validate(dtoRequestV2071ConvertColorcolor, nameof(dtoRequestV2071ConvertColorcolor), required: true);
            return new DeferredBodyAction<DtoResponseV2071ConvertColor>(() =>
            {
                var apiCallPath = "/V2071_ConvertColor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2071ConvertColor = new JObject();
                var dtoRequestV2071ConvertColorpropCount = 0;
                dtoRequestV2071ConvertColorpropCount++;
                dtoRequestV2071ConvertColor["color"] = ExpressionConverter.ConvertO(dtoRequestV2071ConvertColorcolor);
                if (dtoRequestV2071ConvertColorpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2071ConvertColor;
                }

                return new ApiConnectionAction<DtoResponseV2071ConvertColor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertCsvToExcel))]
        public IBodyWorkflowAction<DtoResponseV1033ConvertCsvToExcel> ConvertCsvToExcel([WorkflowExpression] Func<string> dtoRequestV1033ConvertCsvToExcelcSV, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV1033ConvertCsvToExcelseparator = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1033ConvertCsvToExcel> __BuildConvertCsvToExcel(WorkflowExpression<string> dtoRequestV1033ConvertCsvToExcelcSV, WorkflowExpression<bool> dtoRequestV1033ConvertCsvToExcelcSVHasHeaders = null, WorkflowExpression<bool> dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes = null, WorkflowExpression<int> dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = null, WorkflowExpression<bool> dtoRequestV1033ConvertCsvToExcelremoveEmptyRows = null, WorkflowExpression<int> dtoRequestV1033ConvertCsvToExcelskipANumberOfRows = null, WorkflowExpression<int> dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow = null, WorkflowExpression<string> dtoRequestV1033ConvertCsvToExcelseparator = null, WorkflowExpression<bool> dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter = null, WorkflowExpression<bool> dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent = null, WorkflowExpression<bool> dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText = null, WorkflowExpression<int> dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelcSV, nameof(dtoRequestV1033ConvertCsvToExcelcSV), required: true);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders, nameof(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes, nameof(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows, nameof(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows, nameof(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow, nameof(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelseparator, nameof(dtoRequestV1033ConvertCsvToExcelseparator), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter, nameof(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent, nameof(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText, nameof(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText), required: false);
            WorkflowExpression.Validate(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth, nameof(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth), required: false);
            return new DeferredBodyAction<DtoResponseV1033ConvertCsvToExcel>(() =>
            {
                var apiCallPath = "/V1033_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1033ConvertCsvToExcel = new JObject();
                var dtoRequestV1033ConvertCsvToExcelpropCount = 0;
                dtoRequestV1033ConvertCsvToExcelpropCount++;
                dtoRequestV1033ConvertCsvToExcel["csv"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelcSV);
                if (dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders);
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
                        dtoRequestV1033ConvertCsvToExcel["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes);
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
                    dtoRequestV1033ConvertCsvToExcel["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows);
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
                    dtoRequestV1033ConvertCsvToExcel["skip"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["skipLast"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelseparator != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelseparator);
                    dtoRequestV1033ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV1033ConvertCsvToExcel["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter);
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
                        dtoRequestV1033ConvertCsvToExcel["adjustColumnToContent"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent);
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
                        dtoRequestV1033ConvertCsvToExcel["wrapColumnText"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText);
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
                    dtoRequestV1033ConvertCsvToExcel["maxColumnWidth"] = ExpressionConverter.ConvertO(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertCsvToHtmlTable))]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertCsvToHtmlTable([WorkflowExpression] Func<string> dtoRequestV7061ConvertCsvToHtmlTablecSV, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, [WorkflowExpression] Func<bool> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseHtml> __BuildConvertCsvToHtmlTable(WorkflowExpression<string> dtoRequestV7061ConvertCsvToHtmlTablecSV, WorkflowExpression<bool> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, WorkflowExpression<bool> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, WorkflowExpression<int> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, WorkflowExpression<bool> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, WorkflowExpression<int> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, WorkflowExpression<int> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, WorkflowExpression<string> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, WorkflowExpression<bool> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
        {
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablecSV, nameof(dtoRequestV7061ConvertCsvToHtmlTablecSV), required: true);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders, nameof(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes, nameof(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection, nameof(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows, nameof(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows, nameof(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow, nameof(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableseparator, nameof(dtoRequestV7061ConvertCsvToHtmlTableseparator), required: false);
            WorkflowExpression.Validate(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter, nameof(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter), required: false);
            return new DeferredBodyAction<DtoResponseHtml>(() =>
            {
                var apiCallPath = "/V7061_ConvertCsvToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7061ConvertCsvToHtmlTable = new JObject();
                var dtoRequestV7061ConvertCsvToHtmlTablepropCount = 0;
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                dtoRequestV7061ConvertCsvToHtmlTable["csv"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTablecSV);
                if (dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders);
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
                        dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes);
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
                    dtoRequestV7061ConvertCsvToHtmlTable["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows);
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
                    dtoRequestV7061ConvertCsvToHtmlTable["skip"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["skipLast"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableseparator != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableseparator);
                    dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
                }

                if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV7061ConvertCsvToHtmlTable["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertCsvToJson))]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson> ConvertCsvToJson([WorkflowExpression] Func<string> dtoRequestV1022ConvertCsvToJsoncSV, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV1022ConvertCsvToJsonseparator = null, [WorkflowExpression] Func<bool> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson> __BuildConvertCsvToJson(WorkflowExpression<string> dtoRequestV1022ConvertCsvToJsoncSV, WorkflowExpression<bool> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, WorkflowExpression<bool> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, WorkflowExpression<int> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, WorkflowExpression<bool> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, WorkflowExpression<int> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, WorkflowExpression<int> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, WorkflowExpression<string> dtoRequestV1022ConvertCsvToJsonseparator = null, WorkflowExpression<bool> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
        {
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsoncSV, nameof(dtoRequestV1022ConvertCsvToJsoncSV), required: true);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders, nameof(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes, nameof(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows, nameof(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows, nameof(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow, nameof(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonseparator, nameof(dtoRequestV1022ConvertCsvToJsonseparator), required: false);
            WorkflowExpression.Validate(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter, nameof(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter), required: false);
            return new DeferredBodyAction<DtoResponseV1022ConvertCsvToJson>(() =>
            {
                var apiCallPath = "/V1022_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1022ConvertCsvToJson = new JObject();
                var dtoRequestV1022ConvertCsvToJsonpropCount = 0;
                dtoRequestV1022ConvertCsvToJsonpropCount++;
                dtoRequestV1022ConvertCsvToJson["csv"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsoncSV);
                if (dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders);
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
                        dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes);
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
                    dtoRequestV1022ConvertCsvToJson["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows);
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
                    dtoRequestV1022ConvertCsvToJson["skip"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow != null)
                {
                    dtoRequestV1022ConvertCsvToJson["skipLast"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonseparator != null)
                {
                    dtoRequestV1022ConvertCsvToJson["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonseparator);
                    dtoRequestV1022ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV1022ConvertCsvToJson["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertExcelToJson))]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson> ConvertExcelToJson([WorkflowExpression] Func<string> dtoRequestV1100ConvertExcelToJsonexcelFile, [WorkflowExpression] Func<bool> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, [WorkflowExpression] Func<string> dtoRequestV1100ConvertExcelToJsonstartCell = null, [WorkflowExpression] Func<string> dtoRequestV1100ConvertExcelToJsonsheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson> __BuildConvertExcelToJson(WorkflowExpression<string> dtoRequestV1100ConvertExcelToJsonexcelFile, WorkflowExpression<bool> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, WorkflowExpression<string> dtoRequestV1100ConvertExcelToJsonstartCell = null, WorkflowExpression<string> dtoRequestV1100ConvertExcelToJsonsheetName = null)
        {
            WorkflowExpression.Validate(dtoRequestV1100ConvertExcelToJsonexcelFile, nameof(dtoRequestV1100ConvertExcelToJsonexcelFile), required: true);
            WorkflowExpression.Validate(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders, nameof(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV1100ConvertExcelToJsonstartCell, nameof(dtoRequestV1100ConvertExcelToJsonstartCell), required: false);
            WorkflowExpression.Validate(dtoRequestV1100ConvertExcelToJsonsheetName, nameof(dtoRequestV1100ConvertExcelToJsonsheetName), required: false);
            return new DeferredBodyAction<DtoResponseV1100ConvertExcelToJson>(() =>
            {
                var apiCallPath = "/V1100_ConvertExcelToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1100ConvertExcelToJson = new JObject();
                var dtoRequestV1100ConvertExcelToJsonpropCount = 0;
                dtoRequestV1100ConvertExcelToJsonpropCount++;
                dtoRequestV1100ConvertExcelToJson["file"] = ExpressionConverter.ConvertO(dtoRequestV1100ConvertExcelToJsonexcelFile);
                if (dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                {
                    if (dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                    {
                        dtoRequestV1100ConvertExcelToJson["hasHeaders"] = ExpressionConverter.ConvertO(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders);
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
                    dtoRequestV1100ConvertExcelToJson["startCell"] = ExpressionConverter.ConvertO(dtoRequestV1100ConvertExcelToJsonstartCell);
                    dtoRequestV1100ConvertExcelToJsonpropCount++;
                }

                if (dtoRequestV1100ConvertExcelToJsonsheetName != null)
                {
                    dtoRequestV1100ConvertExcelToJson["sheetName"] = ExpressionConverter.ConvertO(dtoRequestV1100ConvertExcelToJsonsheetName);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertFileToPdf))]
        public IBodyWorkflowAction<DtoResponseV4013ConvertFileToPdf> ConvertFileToPdf([WorkflowExpression] Func<string> dtoRequestV4013FileToPdffile, [WorkflowExpression] Func<string> dtoRequestV4013FileToPdforiginFileName = null, [WorkflowExpression] Func<string> dtoRequestV4013FileToPdforiginFileExtension = null, [WorkflowExpression] Func<int> dtoRequestV4013FileToPdfconformanceLevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4013ConvertFileToPdf> __BuildConvertFileToPdf(WorkflowExpression<string> dtoRequestV4013FileToPdffile, WorkflowExpression<string> dtoRequestV4013FileToPdforiginFileName = null, WorkflowExpression<string> dtoRequestV4013FileToPdforiginFileExtension = null, WorkflowExpression<int> dtoRequestV4013FileToPdfconformanceLevel = null)
        {
            WorkflowExpression.Validate(dtoRequestV4013FileToPdffile, nameof(dtoRequestV4013FileToPdffile), required: true);
            WorkflowExpression.Validate(dtoRequestV4013FileToPdforiginFileName, nameof(dtoRequestV4013FileToPdforiginFileName), required: false);
            WorkflowExpression.Validate(dtoRequestV4013FileToPdforiginFileExtension, nameof(dtoRequestV4013FileToPdforiginFileExtension), required: false);
            WorkflowExpression.Validate(dtoRequestV4013FileToPdfconformanceLevel, nameof(dtoRequestV4013FileToPdfconformanceLevel), required: false);
            return new DeferredBodyAction<DtoResponseV4013ConvertFileToPdf>(() =>
            {
                var apiCallPath = "/V4013_ConvertFileToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4013FileToPdf = new JObject();
                var dtoRequestV4013FileToPdfpropCount = 0;
                dtoRequestV4013FileToPdfpropCount++;
                dtoRequestV4013FileToPdf["file"] = ExpressionConverter.ConvertO(dtoRequestV4013FileToPdffile);
                if (dtoRequestV4013FileToPdforiginFileName != null)
                {
                    dtoRequestV4013FileToPdf["fileName"] = ExpressionConverter.ConvertO(dtoRequestV4013FileToPdforiginFileName);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (dtoRequestV4013FileToPdforiginFileExtension != null)
                {
                    dtoRequestV4013FileToPdf["fileExtension"] = ExpressionConverter.ConvertO(dtoRequestV4013FileToPdforiginFileExtension);
                    dtoRequestV4013FileToPdfpropCount++;
                }

                if (dtoRequestV4013FileToPdfconformanceLevel != null)
                {
                    dtoRequestV4013FileToPdf["conformanceLevel"] = ExpressionConverter.ConvertO(dtoRequestV4013FileToPdfconformanceLevel);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlTableToCsv))]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv> ConvertHtmlTableToCsv([WorkflowExpression] Func<string> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, [WorkflowExpression] Func<string> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv> __BuildConvertHtmlTableToCsv(WorkflowExpression<string> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, WorkflowExpression<string> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
        {
            WorkflowExpression.Validate(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, nameof(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable), required: true);
            WorkflowExpression.Validate(dtoRequestV7070ConvertHtmlTableToCsvseparator, nameof(dtoRequestV7070ConvertHtmlTableToCsvseparator), required: false);
            return new DeferredBodyAction<DtoResponseV7070ConvertHtmlTableToCsv>(() =>
            {
                var apiCallPath = "/V7070_ConvertHtmlTableToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7070ConvertHtmlTableToCsv = new JObject();
                var dtoRequestV7070ConvertHtmlTableToCsvpropCount = 0;
                dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
                dtoRequestV7070ConvertHtmlTableToCsv["htmlTable"] = ExpressionConverter.ConvertO(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable);
                if (dtoRequestV7070ConvertHtmlTableToCsvseparator != null)
                {
                    dtoRequestV7070ConvertHtmlTableToCsv["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV7070ConvertHtmlTableToCsvseparator);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlTableToExcel))]
        public IBodyWorkflowAction<DtoResponseV7080ConvertHtmlTableToExcel> ConvertHtmlTableToExcel([WorkflowExpression] Func<string> dtoRequestV7080ConvertHtmlTableToExcelhTMLTable)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV7080ConvertHtmlTableToExcel> __BuildConvertHtmlTableToExcel(WorkflowExpression<string> dtoRequestV7080ConvertHtmlTableToExcelhTMLTable)
        {
            WorkflowExpression.Validate(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable, nameof(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable), required: true);
            return new DeferredBodyAction<DtoResponseV7080ConvertHtmlTableToExcel>(() =>
            {
                var apiCallPath = "/V7080_ConvertHtmlTableToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7080ConvertHtmlTableToExcel = new JObject();
                var dtoRequestV7080ConvertHtmlTableToExcelpropCount = 0;
                dtoRequestV7080ConvertHtmlTableToExcelpropCount++;
                dtoRequestV7080ConvertHtmlTableToExcel["htmlTable"] = ExpressionConverter.ConvertO(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable);
                if (dtoRequestV7080ConvertHtmlTableToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7080ConvertHtmlTableToExcel;
                }

                return new ApiConnectionAction<DtoResponseV7080ConvertHtmlTableToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlTableToJson))]
        public IBodyWorkflowAction<DtoResponseV7012ConvertHtmlTableToJson> ConvertHtmlTableToJson([WorkflowExpression] Func<string> dtoRequestHtmlToTableDatahTMLTable)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV7012ConvertHtmlTableToJson> __BuildConvertHtmlTableToJson(WorkflowExpression<string> dtoRequestHtmlToTableDatahTMLTable)
        {
            WorkflowExpression.Validate(dtoRequestHtmlToTableDatahTMLTable, nameof(dtoRequestHtmlToTableDatahTMLTable), required: true);
            return new DeferredBodyAction<DtoResponseV7012ConvertHtmlTableToJson>(() =>
            {
                var apiCallPath = "/V7012_ConvertHtmlTableToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestHtmlToTableData = new JObject();
                var dtoRequestHtmlToTableDatapropCount = 0;
                dtoRequestHtmlToTableDatapropCount++;
                dtoRequestHtmlToTableData["htmlTable"] = ExpressionConverter.ConvertO(dtoRequestHtmlToTableDatahTMLTable);
                if (dtoRequestHtmlToTableDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestHtmlToTableData;
                }

                return new ApiConnectionAction<DtoResponseV7012ConvertHtmlTableToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlToImage))]
        public IBodyWorkflowAction<DtoResponseV7031ConvertHtmlToImage> ConvertHtmlToImage([WorkflowExpression] Func<string> dtoRequestV7031ConvertHtmlToImagehTML, [WorkflowExpression] Func<int> dtoRequestV7031ConvertHtmlToImagewidth = null, [WorkflowExpression] Func<int> dtoRequestV7031ConvertHtmlToImageheight = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV7031ConvertHtmlToImage> __BuildConvertHtmlToImage(WorkflowExpression<string> dtoRequestV7031ConvertHtmlToImagehTML, WorkflowExpression<int> dtoRequestV7031ConvertHtmlToImagewidth = null, WorkflowExpression<int> dtoRequestV7031ConvertHtmlToImageheight = null)
        {
            WorkflowExpression.Validate(dtoRequestV7031ConvertHtmlToImagehTML, nameof(dtoRequestV7031ConvertHtmlToImagehTML), required: true);
            WorkflowExpression.Validate(dtoRequestV7031ConvertHtmlToImagewidth, nameof(dtoRequestV7031ConvertHtmlToImagewidth), required: false);
            WorkflowExpression.Validate(dtoRequestV7031ConvertHtmlToImageheight, nameof(dtoRequestV7031ConvertHtmlToImageheight), required: false);
            return new DeferredBodyAction<DtoResponseV7031ConvertHtmlToImage>(() =>
            {
                var apiCallPath = "/V7031_ConvertHtmlToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7031ConvertHtmlToImage = new JObject();
                var dtoRequestV7031ConvertHtmlToImagepropCount = 0;
                dtoRequestV7031ConvertHtmlToImagepropCount++;
                dtoRequestV7031ConvertHtmlToImage["html"] = ExpressionConverter.ConvertO(dtoRequestV7031ConvertHtmlToImagehTML);
                if (dtoRequestV7031ConvertHtmlToImagewidth != null)
                {
                    dtoRequestV7031ConvertHtmlToImage["width"] = ExpressionConverter.ConvertO(dtoRequestV7031ConvertHtmlToImagewidth);
                    dtoRequestV7031ConvertHtmlToImagepropCount++;
                }

                if (dtoRequestV7031ConvertHtmlToImageheight != null)
                {
                    dtoRequestV7031ConvertHtmlToImage["height"] = ExpressionConverter.ConvertO(dtoRequestV7031ConvertHtmlToImageheight);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlToPdf))]
        public IBodyWorkflowAction<DtoResponseV7022ConvertHtmlToPdf> ConvertHtmlToPdf([WorkflowExpression] Func<string> dtoRequestV7022ConvertHtmlToPdfhTML, [WorkflowExpression] Func<bool> dtoRequestV7022ConvertHtmlToPdflandscapeFormat = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdffooterOptions = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfheaderOptions = null, [WorkflowExpression] Func<string> dtoRequestV7022ConvertHtmlToPdfpaperFormat = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdftopMargin = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfbottomMargin = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfleftMargin = null, [WorkflowExpression] Func<int> dtoRequestV7022ConvertHtmlToPdfrightMargin = null, [WorkflowExpression] Func<string> dtoRequestV7022ConvertHtmlToPdfpageRanges = null, [WorkflowExpression] Func<double> dtoRequestV7022ConvertHtmlToPdfscale = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV7022ConvertHtmlToPdf> __BuildConvertHtmlToPdf(WorkflowExpression<string> dtoRequestV7022ConvertHtmlToPdfhTML, WorkflowExpression<bool> dtoRequestV7022ConvertHtmlToPdflandscapeFormat = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdffooterOptions = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdfheaderOptions = null, WorkflowExpression<string> dtoRequestV7022ConvertHtmlToPdfpaperFormat = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdftopMargin = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdfbottomMargin = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdfleftMargin = null, WorkflowExpression<int> dtoRequestV7022ConvertHtmlToPdfrightMargin = null, WorkflowExpression<string> dtoRequestV7022ConvertHtmlToPdfpageRanges = null, WorkflowExpression<double> dtoRequestV7022ConvertHtmlToPdfscale = null)
        {
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfhTML, nameof(dtoRequestV7022ConvertHtmlToPdfhTML), required: true);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdflandscapeFormat, nameof(dtoRequestV7022ConvertHtmlToPdflandscapeFormat), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent, nameof(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdffooterOptions, nameof(dtoRequestV7022ConvertHtmlToPdffooterOptions), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfheaderOptions, nameof(dtoRequestV7022ConvertHtmlToPdfheaderOptions), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfpaperFormat, nameof(dtoRequestV7022ConvertHtmlToPdfpaperFormat), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdftopMargin, nameof(dtoRequestV7022ConvertHtmlToPdftopMargin), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfbottomMargin, nameof(dtoRequestV7022ConvertHtmlToPdfbottomMargin), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfleftMargin, nameof(dtoRequestV7022ConvertHtmlToPdfleftMargin), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfrightMargin, nameof(dtoRequestV7022ConvertHtmlToPdfrightMargin), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfpageRanges, nameof(dtoRequestV7022ConvertHtmlToPdfpageRanges), required: false);
            WorkflowExpression.Validate(dtoRequestV7022ConvertHtmlToPdfscale, nameof(dtoRequestV7022ConvertHtmlToPdfscale), required: false);
            return new DeferredBodyAction<DtoResponseV7022ConvertHtmlToPdf>(() =>
            {
                var apiCallPath = "/V7022_ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7022ConvertHtmlToPdf = new JObject();
                var dtoRequestV7022ConvertHtmlToPdfpropCount = 0;
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
                dtoRequestV7022ConvertHtmlToPdf["html"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfhTML);
                if (dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                {
                    if (dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                    {
                        dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdflandscapeFormat);
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
                    dtoRequestV7022ConvertHtmlToPdf["imageQuality"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdffooterOptions != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["footerOption"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdffooterOptions);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfheaderOptions != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["headerOption"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfheaderOptions);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfpaperFormat != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["paperFormat"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfpaperFormat);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdftopMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginTop"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdftopMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfbottomMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginBottom"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfbottomMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfleftMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginLeft"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfleftMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfrightMargin != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["marginRight"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfrightMargin);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfpageRanges != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["pageRanges"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfpageRanges);
                    dtoRequestV7022ConvertHtmlToPdfpropCount++;
                }

                if (dtoRequestV7022ConvertHtmlToPdfscale != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["scale"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdfscale);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlToWord))]
        public IBodyWorkflowAction<DtoResponseFile> ConvertHtmlToWord([WorkflowExpression] Func<string> dtoRequestV7041ConvertHtmlToWordhTML)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildConvertHtmlToWord(WorkflowExpression<string> dtoRequestV7041ConvertHtmlToWordhTML)
        {
            WorkflowExpression.Validate(dtoRequestV7041ConvertHtmlToWordhTML, nameof(dtoRequestV7041ConvertHtmlToWordhTML), required: true);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V7041_ConvertHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7041ConvertHtmlToWord = new JObject();
                var dtoRequestV7041ConvertHtmlToWordpropCount = 0;
                dtoRequestV7041ConvertHtmlToWordpropCount++;
                dtoRequestV7041ConvertHtmlToWord["html"] = ExpressionConverter.ConvertO(dtoRequestV7041ConvertHtmlToWordhTML);
                if (dtoRequestV7041ConvertHtmlToWordpropCount > 0)
                {
                    callPayload.Body = dtoRequestV7041ConvertHtmlToWord;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertImage))]
        public IBodyWorkflowAction<DtoResponseFile> ConvertImage([WorkflowExpression] Func<string> dtoRequestV3012ConvertImageimageFile, [WorkflowExpression] Func<string> dtoRequestV3012ConvertImageoutputFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildConvertImage(WorkflowExpression<string> dtoRequestV3012ConvertImageimageFile, WorkflowExpression<string> dtoRequestV3012ConvertImageoutputFormat = null)
        {
            WorkflowExpression.Validate(dtoRequestV3012ConvertImageimageFile, nameof(dtoRequestV3012ConvertImageimageFile), required: true);
            WorkflowExpression.Validate(dtoRequestV3012ConvertImageoutputFormat, nameof(dtoRequestV3012ConvertImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V3012_ConvertImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3012ConvertImage = new JObject();
                var dtoRequestV3012ConvertImagepropCount = 0;
                dtoRequestV3012ConvertImagepropCount++;
                dtoRequestV3012ConvertImage["file"] = ExpressionConverter.ConvertO(dtoRequestV3012ConvertImageimageFile);
                if (dtoRequestV3012ConvertImageoutputFormat != null)
                {
                    if (dtoRequestV3012ConvertImageoutputFormat != null)
                    {
                        dtoRequestV3012ConvertImage["outFormat"] = ExpressionConverter.ConvertO(dtoRequestV3012ConvertImageoutputFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToCsv))]
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv> ConvertJsonToCsv([WorkflowExpression] Func<string> dtoRequestV1013ConvertJsonToCsvjSON, [WorkflowExpression] Func<string> dtoRequestV1013ConvertJsonToCsvseparator = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv> __BuildConvertJsonToCsv(WorkflowExpression<string> dtoRequestV1013ConvertJsonToCsvjSON, WorkflowExpression<string> dtoRequestV1013ConvertJsonToCsvseparator = null)
        {
            WorkflowExpression.Validate(dtoRequestV1013ConvertJsonToCsvjSON, nameof(dtoRequestV1013ConvertJsonToCsvjSON), required: true);
            WorkflowExpression.Validate(dtoRequestV1013ConvertJsonToCsvseparator, nameof(dtoRequestV1013ConvertJsonToCsvseparator), required: false);
            return new DeferredBodyAction<DtoResponseV1013ConvertJsonToCsv>(() =>
            {
                var apiCallPath = "/V1013_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1013ConvertJsonToCsv = new JObject();
                var dtoRequestV1013ConvertJsonToCsvpropCount = 0;
                dtoRequestV1013ConvertJsonToCsvpropCount++;
                dtoRequestV1013ConvertJsonToCsv["json"] = ExpressionConverter.ConvertO(dtoRequestV1013ConvertJsonToCsvjSON);
                if (dtoRequestV1013ConvertJsonToCsvseparator != null)
                {
                    dtoRequestV1013ConvertJsonToCsv["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV1013ConvertJsonToCsvseparator);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToExcel))]
        public IBodyWorkflowAction<DtoResponseV1063ConvertJsonToExcel> ConvertJsonToExcel([WorkflowExpression] Func<string> dtoRequestJsonToExcelDatajSON, [WorkflowExpression] Func<bool> dtoRequestJsonToExcelDataallInOneTable = null, [WorkflowExpression] Func<bool> dtoRequestJsonToExcelDataadjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestJsonToExcelDatawrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestJsonToExcelDatamaxExcelColumnWidth = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1063ConvertJsonToExcel> __BuildConvertJsonToExcel(WorkflowExpression<string> dtoRequestJsonToExcelDatajSON, WorkflowExpression<bool> dtoRequestJsonToExcelDataallInOneTable = null, WorkflowExpression<bool> dtoRequestJsonToExcelDataadjustExcelColumnToContent = null, WorkflowExpression<bool> dtoRequestJsonToExcelDatawrapExcelColumnText = null, WorkflowExpression<int> dtoRequestJsonToExcelDatamaxExcelColumnWidth = null)
        {
            WorkflowExpression.Validate(dtoRequestJsonToExcelDatajSON, nameof(dtoRequestJsonToExcelDatajSON), required: true);
            WorkflowExpression.Validate(dtoRequestJsonToExcelDataallInOneTable, nameof(dtoRequestJsonToExcelDataallInOneTable), required: false);
            WorkflowExpression.Validate(dtoRequestJsonToExcelDataadjustExcelColumnToContent, nameof(dtoRequestJsonToExcelDataadjustExcelColumnToContent), required: false);
            WorkflowExpression.Validate(dtoRequestJsonToExcelDatawrapExcelColumnText, nameof(dtoRequestJsonToExcelDatawrapExcelColumnText), required: false);
            WorkflowExpression.Validate(dtoRequestJsonToExcelDatamaxExcelColumnWidth, nameof(dtoRequestJsonToExcelDatamaxExcelColumnWidth), required: false);
            return new DeferredBodyAction<DtoResponseV1063ConvertJsonToExcel>(() =>
            {
                var apiCallPath = "/V1063_ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestJsonToExcelData = new JObject();
                var dtoRequestJsonToExcelDatapropCount = 0;
                dtoRequestJsonToExcelDatapropCount++;
                dtoRequestJsonToExcelData["json"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDatajSON);
                if (dtoRequestJsonToExcelDataallInOneTable != null)
                {
                    if (dtoRequestJsonToExcelDataallInOneTable != null)
                    {
                        dtoRequestJsonToExcelData["allInOneTable"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDataallInOneTable);
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
                        dtoRequestJsonToExcelData["adjustColumnToContent"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDataadjustExcelColumnToContent);
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
                        dtoRequestJsonToExcelData["wrapColumnText"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDatawrapExcelColumnText);
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
                    dtoRequestJsonToExcelData["maxColumnWidth"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDatamaxExcelColumnWidth);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToHtmlTable))]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertJsonToHtmlTable([WorkflowExpression] Func<string> dtoRequestV7051ConvertJsonToHtmlTablejSON)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseHtml> __BuildConvertJsonToHtmlTable(WorkflowExpression<string> dtoRequestV7051ConvertJsonToHtmlTablejSON)
        {
            WorkflowExpression.Validate(dtoRequestV7051ConvertJsonToHtmlTablejSON, nameof(dtoRequestV7051ConvertJsonToHtmlTablejSON), required: true);
            return new DeferredBodyAction<DtoResponseHtml>(() =>
            {
                var apiCallPath = "/V7051_ConvertJsonToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV7051ConvertJsonToHtmlTable = new JObject();
                var dtoRequestV7051ConvertJsonToHtmlTablepropCount = 0;
                dtoRequestV7051ConvertJsonToHtmlTablepropCount++;
                dtoRequestV7051ConvertJsonToHtmlTable["json"] = ExpressionConverter.ConvertO(dtoRequestV7051ConvertJsonToHtmlTablejSON);
                if (dtoRequestV7051ConvertJsonToHtmlTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV7051ConvertJsonToHtmlTable;
                }

                return new ApiConnectionAction<DtoResponseHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToTextTable))]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable> ConvertJsonToTextTable([WorkflowExpression] Func<string> dtoRequestV1090ConvertJsonToTextTablejSON)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable> __BuildConvertJsonToTextTable(WorkflowExpression<string> dtoRequestV1090ConvertJsonToTextTablejSON)
        {
            WorkflowExpression.Validate(dtoRequestV1090ConvertJsonToTextTablejSON, nameof(dtoRequestV1090ConvertJsonToTextTablejSON), required: true);
            return new DeferredBodyAction<DtoResponseV1090ConvertJsonToTextTable>(() =>
            {
                var apiCallPath = "/V1090_ConvertJsonToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1090ConvertJsonToTextTable = new JObject();
                var dtoRequestV1090ConvertJsonToTextTablepropCount = 0;
                dtoRequestV1090ConvertJsonToTextTablepropCount++;
                dtoRequestV1090ConvertJsonToTextTable["json"] = ExpressionConverter.ConvertO(dtoRequestV1090ConvertJsonToTextTablejSON);
                if (dtoRequestV1090ConvertJsonToTextTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestV1090ConvertJsonToTextTable;
                }

                return new ApiConnectionAction<DtoResponseV1090ConvertJsonToTextTable>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToXml))]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml> ConvertJsonToXml([WorkflowExpression] Func<string> dtoRequestV1042ConvertJsonToXmljSON)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml> __BuildConvertJsonToXml(WorkflowExpression<string> dtoRequestV1042ConvertJsonToXmljSON)
        {
            WorkflowExpression.Validate(dtoRequestV1042ConvertJsonToXmljSON, nameof(dtoRequestV1042ConvertJsonToXmljSON), required: true);
            return new DeferredBodyAction<DtoResponseV1042ConvertJsonToXml>(() =>
            {
                var apiCallPath = "/V1042_ConvertJsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1042ConvertJsonToXml = new JObject();
                var dtoRequestV1042ConvertJsonToXmlpropCount = 0;
                dtoRequestV1042ConvertJsonToXmlpropCount++;
                dtoRequestV1042ConvertJsonToXml["json"] = ExpressionConverter.ConvertO(dtoRequestV1042ConvertJsonToXmljSON);
                if (dtoRequestV1042ConvertJsonToXmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1042ConvertJsonToXml;
                }

                return new ApiConnectionAction<DtoResponseV1042ConvertJsonToXml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToYaml))]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml> ConvertJsonToYaml([WorkflowExpression] Func<string> dtoRequestV1081ConvertJsonToYamljSON)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml> __BuildConvertJsonToYaml(WorkflowExpression<string> dtoRequestV1081ConvertJsonToYamljSON)
        {
            WorkflowExpression.Validate(dtoRequestV1081ConvertJsonToYamljSON, nameof(dtoRequestV1081ConvertJsonToYamljSON), required: true);
            return new DeferredBodyAction<DtoResponseV1081ConvertJsonToYaml>(() =>
            {
                var apiCallPath = "/V1081_ConvertJsonToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1081ConvertJsonToYaml = new JObject();
                var dtoRequestV1081ConvertJsonToYamlpropCount = 0;
                dtoRequestV1081ConvertJsonToYamlpropCount++;
                dtoRequestV1081ConvertJsonToYaml["json"] = ExpressionConverter.ConvertO(dtoRequestV1081ConvertJsonToYamljSON);
                if (dtoRequestV1081ConvertJsonToYamlpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1081ConvertJsonToYaml;
                }

                return new ApiConnectionAction<DtoResponseV1081ConvertJsonToYaml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertPdfToPdfA))]
        public IBodyWorkflowAction<DtoResponseV4070ConvertPdfToPdfA> ConvertPdfToPdfA([WorkflowExpression] Func<string> dtoRequestV4070ConvertPdfToPdfApDF, [WorkflowExpression] Func<int> dtoRequestV4070ConvertPdfToPdfAconformanceLevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4070ConvertPdfToPdfA> __BuildConvertPdfToPdfA(WorkflowExpression<string> dtoRequestV4070ConvertPdfToPdfApDF, WorkflowExpression<int> dtoRequestV4070ConvertPdfToPdfAconformanceLevel = null)
        {
            WorkflowExpression.Validate(dtoRequestV4070ConvertPdfToPdfApDF, nameof(dtoRequestV4070ConvertPdfToPdfApDF), required: true);
            WorkflowExpression.Validate(dtoRequestV4070ConvertPdfToPdfAconformanceLevel, nameof(dtoRequestV4070ConvertPdfToPdfAconformanceLevel), required: false);
            return new DeferredBodyAction<DtoResponseV4070ConvertPdfToPdfA>(() =>
            {
                var apiCallPath = "/V4070_ConvertPdfToPdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4070ConvertPdfToPdfA = new JObject();
                var dtoRequestV4070ConvertPdfToPdfApropCount = 0;
                dtoRequestV4070ConvertPdfToPdfApropCount++;
                dtoRequestV4070ConvertPdfToPdfA["pdf"] = ExpressionConverter.ConvertO(dtoRequestV4070ConvertPdfToPdfApDF);
                if (dtoRequestV4070ConvertPdfToPdfAconformanceLevel != null)
                {
                    dtoRequestV4070ConvertPdfToPdfA["conformanceLevel"] = ExpressionConverter.ConvertO(dtoRequestV4070ConvertPdfToPdfAconformanceLevel);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertSharePointSearchResults))]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults> ConvertSharePointSearchResults([WorkflowExpression] Func<string> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults> __BuildConvertSharePointSearchResults(WorkflowExpression<string> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
        {
            WorkflowExpression.Validate(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult, nameof(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult), required: true);
            return new DeferredBodyAction<DtoResponseV6011ConvertSharePointSearchResults>(() =>
            {
                var apiCallPath = "/V6011_ConvertSharePointSearchResults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV6011ConvertSharePointSearchResults = new JObject();
                var dtoRequestV6011ConvertSharePointSearchResultspropCount = 0;
                dtoRequestV6011ConvertSharePointSearchResultspropCount++;
                dtoRequestV6011ConvertSharePointSearchResults["sharepointResult"] = ExpressionConverter.ConvertO(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult);
                if (dtoRequestV6011ConvertSharePointSearchResultspropCount > 0)
                {
                    callPayload.Body = dtoRequestV6011ConvertSharePointSearchResults;
                }

                return new ApiConnectionAction<DtoResponseV6011ConvertSharePointSearchResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertWordToHtml))]
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml> ConvertWordToHtml([WorkflowExpression] Func<string> dtoRequestword, [WorkflowExpression] Func<bool> dtoRequestembedImages = null, [WorkflowExpression] Func<bool> dtoRequestfullHTMLDocument = null, [WorkflowExpression] Func<string> dtoRequesttitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml> __BuildConvertWordToHtml(WorkflowExpression<string> dtoRequestword, WorkflowExpression<bool> dtoRequestembedImages = null, WorkflowExpression<bool> dtoRequestfullHTMLDocument = null, WorkflowExpression<string> dtoRequesttitle = null)
        {
            WorkflowExpression.Validate(dtoRequestword, nameof(dtoRequestword), required: true);
            WorkflowExpression.Validate(dtoRequestembedImages, nameof(dtoRequestembedImages), required: false);
            WorkflowExpression.Validate(dtoRequestfullHTMLDocument, nameof(dtoRequestfullHTMLDocument), required: false);
            WorkflowExpression.Validate(dtoRequesttitle, nameof(dtoRequesttitle), required: false);
            return new DeferredBodyAction<DtoResponseV5160ConvertWordToHtml>(() =>
            {
                var apiCallPath = "/V5160_ConvertWordToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["word"] = ExpressionConverter.ConvertO(dtoRequestword);
                if (dtoRequestembedImages != null)
                {
                    dtoRequest["embedImages"] = ExpressionConverter.ConvertO(dtoRequestembedImages);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfullHTMLDocument != null)
                {
                    dtoRequest["fullHtmlDocument"] = ExpressionConverter.ConvertO(dtoRequestfullHTMLDocument);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttitle != null)
                {
                    dtoRequest["title"] = ExpressionConverter.ConvertO(dtoRequesttitle);
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
        [WorkflowExpressionFactory(nameof(__BuildConvertXmlToJson))]
        public IBodyWorkflowAction<DtoResponseV1052ConvertXmlToJson> ConvertXmlToJson([WorkflowExpression] Func<string> dtoRequestV1052ConvertXmlToJsonxML)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1052ConvertXmlToJson> __BuildConvertXmlToJson(WorkflowExpression<string> dtoRequestV1052ConvertXmlToJsonxML)
        {
            WorkflowExpression.Validate(dtoRequestV1052ConvertXmlToJsonxML, nameof(dtoRequestV1052ConvertXmlToJsonxML), required: true);
            return new DeferredBodyAction<DtoResponseV1052ConvertXmlToJson>(() =>
            {
                var apiCallPath = "/V1052_ConvertXmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1052ConvertXmlToJson = new JObject();
                var dtoRequestV1052ConvertXmlToJsonpropCount = 0;
                dtoRequestV1052ConvertXmlToJsonpropCount++;
                dtoRequestV1052ConvertXmlToJson["xml"] = ExpressionConverter.ConvertO(dtoRequestV1052ConvertXmlToJsonxML);
                if (dtoRequestV1052ConvertXmlToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1052ConvertXmlToJson;
                }

                return new ApiConnectionAction<DtoResponseV1052ConvertXmlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertXRechnungToPdf))]
        public IBodyWorkflowAction<DtoResponseV8010ConvertXRechnungToPdf> ConvertXRechnungToPdf([WorkflowExpression] Func<string> dtoRequestV8010ConvertXRechnungToPdfxRechnung)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV8010ConvertXRechnungToPdf> __BuildConvertXRechnungToPdf(WorkflowExpression<string> dtoRequestV8010ConvertXRechnungToPdfxRechnung)
        {
            WorkflowExpression.Validate(dtoRequestV8010ConvertXRechnungToPdfxRechnung, nameof(dtoRequestV8010ConvertXRechnungToPdfxRechnung), required: true);
            return new DeferredBodyAction<DtoResponseV8010ConvertXRechnungToPdf>(() =>
            {
                var apiCallPath = "/V8010_ConvertXRechnungToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV8010ConvertXRechnungToPdf = new JObject();
                var dtoRequestV8010ConvertXRechnungToPdfpropCount = 0;
                dtoRequestV8010ConvertXRechnungToPdfpropCount++;
                dtoRequestV8010ConvertXRechnungToPdf["xml"] = ExpressionConverter.ConvertO(dtoRequestV8010ConvertXRechnungToPdfxRechnung);
                if (dtoRequestV8010ConvertXRechnungToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestV8010ConvertXRechnungToPdf;
                }

                return new ApiConnectionAction<DtoResponseV8010ConvertXRechnungToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildConvertYamlToJson))]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson> ConvertYamlToJson([WorkflowExpression] Func<string> dtoRequestV1071YamlToJsonyAML)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson> __BuildConvertYamlToJson(WorkflowExpression<string> dtoRequestV1071YamlToJsonyAML)
        {
            WorkflowExpression.Validate(dtoRequestV1071YamlToJsonyAML, nameof(dtoRequestV1071YamlToJsonyAML), required: true);
            return new DeferredBodyAction<DtoResponseV1071ConvertYamlToJson>(() =>
            {
                var apiCallPath = "/V1071_ConvertYamlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV1071YamlToJson = new JObject();
                var dtoRequestV1071YamlToJsonpropCount = 0;
                dtoRequestV1071YamlToJsonpropCount++;
                dtoRequestV1071YamlToJson["yaml"] = ExpressionConverter.ConvertO(dtoRequestV1071YamlToJsonyAML);
                if (dtoRequestV1071YamlToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestV1071YamlToJson;
                }

                return new ApiConnectionAction<DtoResponseV1071ConvertYamlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChartImage))]
        public IBodyWorkflowAction<DtoResponseV3091CreateChartImage> CreateChartImage([WorkflowExpression] Func<string> dtoRequestV3091CreateChartImagetableData, [WorkflowExpression] Func<int> dtoRequestV3091CreateChartImageimageWidth = null, [WorkflowExpression] Func<int> dtoRequestV3091CreateChartImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3091CreateChartImagebackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestV3091CreateChartImageoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestV3091CreateChartImagechartType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3091CreateChartImage> __BuildCreateChartImage(WorkflowExpression<string> dtoRequestV3091CreateChartImagetableData, WorkflowExpression<int> dtoRequestV3091CreateChartImageimageWidth = null, WorkflowExpression<int> dtoRequestV3091CreateChartImageimageHeight = null, WorkflowExpression<string> dtoRequestV3091CreateChartImagebackgroundColor = null, WorkflowExpression<string> dtoRequestV3091CreateChartImageoutputFormat = null, WorkflowExpression<string> dtoRequestV3091CreateChartImagechartType = null)
        {
            WorkflowExpression.Validate(dtoRequestV3091CreateChartImagetableData, nameof(dtoRequestV3091CreateChartImagetableData), required: true);
            WorkflowExpression.Validate(dtoRequestV3091CreateChartImageimageWidth, nameof(dtoRequestV3091CreateChartImageimageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV3091CreateChartImageimageHeight, nameof(dtoRequestV3091CreateChartImageimageHeight), required: false);
            WorkflowExpression.Validate(dtoRequestV3091CreateChartImagebackgroundColor, nameof(dtoRequestV3091CreateChartImagebackgroundColor), required: false);
            WorkflowExpression.Validate(dtoRequestV3091CreateChartImageoutputFormat, nameof(dtoRequestV3091CreateChartImageoutputFormat), required: false);
            WorkflowExpression.Validate(dtoRequestV3091CreateChartImagechartType, nameof(dtoRequestV3091CreateChartImagechartType), required: false);
            return new DeferredBodyAction<DtoResponseV3091CreateChartImage>(() =>
            {
                var apiCallPath = "/V3091_CreateChartImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3091CreateChartImage = new JObject();
                var dtoRequestV3091CreateChartImagepropCount = 0;
                if (dtoRequestV3091CreateChartImageimageWidth != null)
                {
                    dtoRequestV3091CreateChartImage["width"] = ExpressionConverter.ConvertO(dtoRequestV3091CreateChartImageimageWidth);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImageimageHeight != null)
                {
                    dtoRequestV3091CreateChartImage["height"] = ExpressionConverter.ConvertO(dtoRequestV3091CreateChartImageimageHeight);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImagebackgroundColor != null)
                {
                    dtoRequestV3091CreateChartImage["backgroundColor"] = ExpressionConverter.ConvertO(dtoRequestV3091CreateChartImagebackgroundColor);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                if (dtoRequestV3091CreateChartImageoutputFormat != null)
                {
                    dtoRequestV3091CreateChartImage["format"] = ExpressionConverter.ConvertO(dtoRequestV3091CreateChartImageoutputFormat);
                    dtoRequestV3091CreateChartImagepropCount++;
                }

                dtoRequestV3091CreateChartImagepropCount++;
                dtoRequestV3091CreateChartImage["chart"] = ExpressionConverter.ConvertO(dtoRequestV3091CreateChartImagetableData);
                if (dtoRequestV3091CreateChartImagechartType != null)
                {
                    dtoRequestV3091CreateChartImage["type"] = ExpressionConverter.ConvertO(dtoRequestV3091CreateChartImagechartType);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateCode))]
        public IBodyWorkflowAction<DtoResponseV3062CreateCode> CreateCode([WorkflowExpression] Func<string> dtoRequestV3062CreateCodecontent, [WorkflowExpression] Func<string> dtoRequestV3062CreateCodecodeFormat = null, [WorkflowExpression] Func<int> dtoRequestV3062CreateCodewidth = null, [WorkflowExpression] Func<int> dtoRequestV3062CreateCodeheight = null, [WorkflowExpression] Func<string> dtoRequestV3062CreateCodeoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestV3062CreateCodeembeddedImage = null, [WorkflowExpression] Func<double> dtoRequestV3062CreateCodeembeddedImageOpacity = null, [WorkflowExpression] Func<double> dtoRequestV3062CreateCodeembeddedImageRatio = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3062CreateCode> __BuildCreateCode(WorkflowExpression<string> dtoRequestV3062CreateCodecontent, WorkflowExpression<string> dtoRequestV3062CreateCodecodeFormat = null, WorkflowExpression<int> dtoRequestV3062CreateCodewidth = null, WorkflowExpression<int> dtoRequestV3062CreateCodeheight = null, WorkflowExpression<string> dtoRequestV3062CreateCodeoutputFormat = null, WorkflowExpression<string> dtoRequestV3062CreateCodeembeddedImage = null, WorkflowExpression<double> dtoRequestV3062CreateCodeembeddedImageOpacity = null, WorkflowExpression<double> dtoRequestV3062CreateCodeembeddedImageRatio = null)
        {
            WorkflowExpression.Validate(dtoRequestV3062CreateCodecontent, nameof(dtoRequestV3062CreateCodecontent), required: true);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodecodeFormat, nameof(dtoRequestV3062CreateCodecodeFormat), required: false);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodewidth, nameof(dtoRequestV3062CreateCodewidth), required: false);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodeheight, nameof(dtoRequestV3062CreateCodeheight), required: false);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodeoutputFormat, nameof(dtoRequestV3062CreateCodeoutputFormat), required: false);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodeembeddedImage, nameof(dtoRequestV3062CreateCodeembeddedImage), required: false);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodeembeddedImageOpacity, nameof(dtoRequestV3062CreateCodeembeddedImageOpacity), required: false);
            WorkflowExpression.Validate(dtoRequestV3062CreateCodeembeddedImageRatio, nameof(dtoRequestV3062CreateCodeembeddedImageRatio), required: false);
            return new DeferredBodyAction<DtoResponseV3062CreateCode>(() =>
            {
                var apiCallPath = "/V3062_CreateCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3062CreateCode = new JObject();
                var dtoRequestV3062CreateCodepropCount = 0;
                dtoRequestV3062CreateCodepropCount++;
                dtoRequestV3062CreateCode["content"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodecontent);
                if (dtoRequestV3062CreateCodecodeFormat != null)
                {
                    dtoRequestV3062CreateCode["codeFormat"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodecodeFormat);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodewidth != null)
                {
                    dtoRequestV3062CreateCode["width"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodewidth);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeheight != null)
                {
                    dtoRequestV3062CreateCode["height"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodeheight);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeoutputFormat != null)
                {
                    dtoRequestV3062CreateCode["outFormat"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodeoutputFormat);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeembeddedImage != null)
                {
                    dtoRequestV3062CreateCode["image"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodeembeddedImage);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeembeddedImageOpacity != null)
                {
                    dtoRequestV3062CreateCode["imageOpacity"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodeembeddedImageOpacity);
                    dtoRequestV3062CreateCodepropCount++;
                }

                if (dtoRequestV3062CreateCodeembeddedImageRatio != null)
                {
                    dtoRequestV3062CreateCode["imageRatio"] = ExpressionConverter.ConvertO(dtoRequestV3062CreateCodeembeddedImageRatio);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateGraphImage))]
        public IBodyWorkflowAction<DtoResponseV3111CreateGraphImage> CreateGraphImage([WorkflowExpression] Func<string> dtoRequestV3111CreateGraphImagegraphData, [WorkflowExpression] Func<int> dtoRequestV3111CreateGraphImageimageWidth = null, [WorkflowExpression] Func<int> dtoRequestV3111CreateGraphImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3111CreateGraphImagebackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestV3111CreateGraphImageoutputFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3111CreateGraphImage> __BuildCreateGraphImage(WorkflowExpression<string> dtoRequestV3111CreateGraphImagegraphData, WorkflowExpression<int> dtoRequestV3111CreateGraphImageimageWidth = null, WorkflowExpression<int> dtoRequestV3111CreateGraphImageimageHeight = null, WorkflowExpression<string> dtoRequestV3111CreateGraphImagebackgroundColor = null, WorkflowExpression<string> dtoRequestV3111CreateGraphImageoutputFormat = null)
        {
            WorkflowExpression.Validate(dtoRequestV3111CreateGraphImagegraphData, nameof(dtoRequestV3111CreateGraphImagegraphData), required: true);
            WorkflowExpression.Validate(dtoRequestV3111CreateGraphImageimageWidth, nameof(dtoRequestV3111CreateGraphImageimageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV3111CreateGraphImageimageHeight, nameof(dtoRequestV3111CreateGraphImageimageHeight), required: false);
            WorkflowExpression.Validate(dtoRequestV3111CreateGraphImagebackgroundColor, nameof(dtoRequestV3111CreateGraphImagebackgroundColor), required: false);
            WorkflowExpression.Validate(dtoRequestV3111CreateGraphImageoutputFormat, nameof(dtoRequestV3111CreateGraphImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV3111CreateGraphImage>(() =>
            {
                var apiCallPath = "/V3111_CreateGraphImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3111CreateGraphImage = new JObject();
                var dtoRequestV3111CreateGraphImagepropCount = 0;
                if (dtoRequestV3111CreateGraphImageimageWidth != null)
                {
                    dtoRequestV3111CreateGraphImage["width"] = ExpressionConverter.ConvertO(dtoRequestV3111CreateGraphImageimageWidth);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (dtoRequestV3111CreateGraphImageimageHeight != null)
                {
                    dtoRequestV3111CreateGraphImage["height"] = ExpressionConverter.ConvertO(dtoRequestV3111CreateGraphImageimageHeight);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (dtoRequestV3111CreateGraphImagebackgroundColor != null)
                {
                    dtoRequestV3111CreateGraphImage["backgroundColor"] = ExpressionConverter.ConvertO(dtoRequestV3111CreateGraphImagebackgroundColor);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                if (dtoRequestV3111CreateGraphImageoutputFormat != null)
                {
                    dtoRequestV3111CreateGraphImage["format"] = ExpressionConverter.ConvertO(dtoRequestV3111CreateGraphImageoutputFormat);
                    dtoRequestV3111CreateGraphImagepropCount++;
                }

                dtoRequestV3111CreateGraphImagepropCount++;
                dtoRequestV3111CreateGraphImage["graph"] = ExpressionConverter.ConvertO(dtoRequestV3111CreateGraphImagegraphData);
                if (dtoRequestV3111CreateGraphImagepropCount > 0)
                {
                    callPayload.Body = dtoRequestV3111CreateGraphImage;
                }

                return new ApiConnectionAction<DtoResponseV3111CreateGraphImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTableImage))]
        public IBodyWorkflowAction<DtoResponseV3101CreateTableImage> CreateTableImage([WorkflowExpression] Func<string> dtoRequestV3101CreateTableImagetableData, [WorkflowExpression] Func<int> dtoRequestV3101CreateTableImageimageWidth = null, [WorkflowExpression] Func<int> dtoRequestV3101CreateTableImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3101CreateTableImagebackgroundColor = null, [WorkflowExpression] Func<string> dtoRequestV3101CreateTableImageoutputFormat = null, [WorkflowExpression] Func<string> dtoRequestV3101CreateTableImagetitle = null, [WorkflowExpression] Func<bool> dtoRequestV3101CreateTableImageshowTableBorders = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3101CreateTableImage> __BuildCreateTableImage(WorkflowExpression<string> dtoRequestV3101CreateTableImagetableData, WorkflowExpression<int> dtoRequestV3101CreateTableImageimageWidth = null, WorkflowExpression<int> dtoRequestV3101CreateTableImageimageHeight = null, WorkflowExpression<string> dtoRequestV3101CreateTableImagebackgroundColor = null, WorkflowExpression<string> dtoRequestV3101CreateTableImageoutputFormat = null, WorkflowExpression<string> dtoRequestV3101CreateTableImagetitle = null, WorkflowExpression<bool> dtoRequestV3101CreateTableImageshowTableBorders = null)
        {
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImagetableData, nameof(dtoRequestV3101CreateTableImagetableData), required: true);
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImageimageWidth, nameof(dtoRequestV3101CreateTableImageimageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImageimageHeight, nameof(dtoRequestV3101CreateTableImageimageHeight), required: false);
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImagebackgroundColor, nameof(dtoRequestV3101CreateTableImagebackgroundColor), required: false);
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImageoutputFormat, nameof(dtoRequestV3101CreateTableImageoutputFormat), required: false);
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImagetitle, nameof(dtoRequestV3101CreateTableImagetitle), required: false);
            WorkflowExpression.Validate(dtoRequestV3101CreateTableImageshowTableBorders, nameof(dtoRequestV3101CreateTableImageshowTableBorders), required: false);
            return new DeferredBodyAction<DtoResponseV3101CreateTableImage>(() =>
            {
                var apiCallPath = "/V3101_CreateTableImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3101CreateTableImage = new JObject();
                var dtoRequestV3101CreateTableImagepropCount = 0;
                if (dtoRequestV3101CreateTableImageimageWidth != null)
                {
                    dtoRequestV3101CreateTableImage["width"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImageimageWidth);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImageimageHeight != null)
                {
                    dtoRequestV3101CreateTableImage["height"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImageimageHeight);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImagebackgroundColor != null)
                {
                    dtoRequestV3101CreateTableImage["backgroundColor"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImagebackgroundColor);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImageoutputFormat != null)
                {
                    dtoRequestV3101CreateTableImage["format"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImageoutputFormat);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                dtoRequestV3101CreateTableImagepropCount++;
                dtoRequestV3101CreateTableImage["data"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImagetableData);
                if (dtoRequestV3101CreateTableImagetitle != null)
                {
                    dtoRequestV3101CreateTableImage["title"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImagetitle);
                    dtoRequestV3101CreateTableImagepropCount++;
                }

                if (dtoRequestV3101CreateTableImageshowTableBorders != null)
                {
                    if (dtoRequestV3101CreateTableImageshowTableBorders != null)
                    {
                        dtoRequestV3101CreateTableImage["hasLines"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImageshowTableBorders);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateWatermarkImage))]
        public IBodyWorkflowAction<DtoResponseV3081CreateWatermarkImage> CreateWatermarkImage([WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagemainImage, [WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagewatermarkImage, [WorkflowExpression] Func<int> dtoRequestV3081CreateWatermarkImagewatermarkOpacity = null, [WorkflowExpression] Func<int> dtoRequestV3081CreateWatermarkImagewatermarkRatio = null, [WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = null, [WorkflowExpression] Func<string> dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3081CreateWatermarkImage> __BuildCreateWatermarkImage(WorkflowExpression<string> dtoRequestV3081CreateWatermarkImagemainImage, WorkflowExpression<string> dtoRequestV3081CreateWatermarkImagewatermarkImage, WorkflowExpression<int> dtoRequestV3081CreateWatermarkImagewatermarkOpacity = null, WorkflowExpression<int> dtoRequestV3081CreateWatermarkImagewatermarkRatio = null, WorkflowExpression<string> dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = null, WorkflowExpression<string> dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = null)
        {
            WorkflowExpression.Validate(dtoRequestV3081CreateWatermarkImagemainImage, nameof(dtoRequestV3081CreateWatermarkImagemainImage), required: true);
            WorkflowExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkImage, nameof(dtoRequestV3081CreateWatermarkImagewatermarkImage), required: true);
            WorkflowExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkOpacity, nameof(dtoRequestV3081CreateWatermarkImagewatermarkOpacity), required: false);
            WorkflowExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkRatio, nameof(dtoRequestV3081CreateWatermarkImagewatermarkRatio), required: false);
            WorkflowExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition, nameof(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition), required: false);
            WorkflowExpression.Validate(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition, nameof(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition), required: false);
            return new DeferredBodyAction<DtoResponseV3081CreateWatermarkImage>(() =>
            {
                var apiCallPath = "/V3081_CreateWatermarkImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3081CreateWatermarkImage = new JObject();
                var dtoRequestV3081CreateWatermarkImagepropCount = 0;
                dtoRequestV3081CreateWatermarkImagepropCount++;
                dtoRequestV3081CreateWatermarkImage["image"] = ExpressionConverter.ConvertO(dtoRequestV3081CreateWatermarkImagemainImage);
                dtoRequestV3081CreateWatermarkImagepropCount++;
                dtoRequestV3081CreateWatermarkImage["watermarkImage"] = ExpressionConverter.ConvertO(dtoRequestV3081CreateWatermarkImagewatermarkImage);
                if (dtoRequestV3081CreateWatermarkImagewatermarkOpacity != null)
                {
                    dtoRequestV3081CreateWatermarkImage["opacity"] = ExpressionConverter.ConvertO(dtoRequestV3081CreateWatermarkImagewatermarkOpacity);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagewatermarkRatio != null)
                {
                    dtoRequestV3081CreateWatermarkImage["ratio"] = ExpressionConverter.ConvertO(dtoRequestV3081CreateWatermarkImagewatermarkRatio);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition != null)
                {
                    dtoRequestV3081CreateWatermarkImage["imagePositionHorizontal"] = ExpressionConverter.ConvertO(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition);
                    dtoRequestV3081CreateWatermarkImagepropCount++;
                }

                if (dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition != null)
                {
                    dtoRequestV3081CreateWatermarkImage["imagePositionVertical"] = ExpressionConverter.ConvertO(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateWordFile))]
        public IBodyWorkflowAction<DtoResponseV5011CreateWordFile> CreateWordFile([WorkflowExpression] Func<Section[]> dtoRequestV5011CreateWordFilesection, [WorkflowExpression] Func<string> dtoRequestV5011CreateWordFileexistingFileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5011CreateWordFile> __BuildCreateWordFile(WorkflowExpression<Section[]> dtoRequestV5011CreateWordFilesection, WorkflowExpression<string> dtoRequestV5011CreateWordFileexistingFileContent = null)
        {
            WorkflowExpression.Validate(dtoRequestV5011CreateWordFilesection, nameof(dtoRequestV5011CreateWordFilesection), required: true);
            WorkflowExpression.Validate(dtoRequestV5011CreateWordFileexistingFileContent, nameof(dtoRequestV5011CreateWordFileexistingFileContent), required: false);
            return new DeferredBodyAction<DtoResponseV5011CreateWordFile>(() =>
            {
                var apiCallPath = "/V5011_CreateWordFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5011CreateWordFile = new JObject();
                var dtoRequestV5011CreateWordFilepropCount = 0;
                if (dtoRequestV5011CreateWordFileexistingFileContent != null)
                {
                    dtoRequestV5011CreateWordFile["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5011CreateWordFileexistingFileContent);
                    dtoRequestV5011CreateWordFilepropCount++;
                }

                dtoRequestV5011CreateWordFilepropCount++;
                dtoRequestV5011CreateWordFile["sections"] = ExpressionConverter.ConvertO(dtoRequestV5011CreateWordFilesection);
                if (dtoRequestV5011CreateWordFilepropCount > 0)
                {
                    callPayload.Body = dtoRequestV5011CreateWordFile;
                }

                return new ApiConnectionAction<DtoResponseV5011CreateWordFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildExtractImagesFromPdf))]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf> ExtractImagesFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<string> dtoRequestfileNamePrefix = null, [WorkflowExpression] Func<bool> dtoRequestincludeBase64String = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf> __BuildExtractImagesFromPdf(WorkflowExpression<string> dtoRequestpDF, WorkflowExpression<int> dtoRequestfromPage = null, WorkflowExpression<int> dtoRequesttoPage = null, WorkflowExpression<string> dtoRequestfileNamePrefix = null, WorkflowExpression<bool> dtoRequestincludeBase64String = null)
        {
            WorkflowExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            WorkflowExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            WorkflowExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            WorkflowExpression.Validate(dtoRequestfileNamePrefix, nameof(dtoRequestfileNamePrefix), required: false);
            WorkflowExpression.Validate(dtoRequestincludeBase64String, nameof(dtoRequestincludeBase64String), required: false);
            return new DeferredBodyAction<DtoResponseV4090ExtractImagesFromPdf>(() =>
            {
                var apiCallPath = "/V4090_ExtractImagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = ExpressionConverter.ConvertO(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = ExpressionConverter.ConvertO(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfileNamePrefix != null)
                {
                    dtoRequest["fileNamePrefix"] = ExpressionConverter.ConvertO(dtoRequestfileNamePrefix);
                    dtoRequestpropCount++;
                }

                if (dtoRequestincludeBase64String != null)
                {
                    dtoRequest["includeFileString"] = ExpressionConverter.ConvertO(dtoRequestincludeBase64String);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractJsonObjectProperties))]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties> ExtractJsonObjectProperties([WorkflowExpression] Func<string> dtoRequestV2100ExtractJsonObjectPropertiesjSON, [WorkflowExpression] Func<bool> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties> __BuildExtractJsonObjectProperties(WorkflowExpression<string> dtoRequestV2100ExtractJsonObjectPropertiesjSON, WorkflowExpression<bool> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
        {
            WorkflowExpression.Validate(dtoRequestV2100ExtractJsonObjectPropertiesjSON, nameof(dtoRequestV2100ExtractJsonObjectPropertiesjSON), required: true);
            WorkflowExpression.Validate(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties, nameof(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties), required: false);
            return new DeferredBodyAction<DtoResponseV2100ExtractJsonObjectProperties>(() =>
            {
                var apiCallPath = "/V2100_ExtractJsonObjectProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2100ExtractJsonObjectProperties = new JObject();
                var dtoRequestV2100ExtractJsonObjectPropertiespropCount = 0;
                dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
                dtoRequestV2100ExtractJsonObjectProperties["json"] = ExpressionConverter.ConvertO(dtoRequestV2100ExtractJsonObjectPropertiesjSON);
                if (dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                {
                    if (dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                    {
                        dtoRequestV2100ExtractJsonObjectProperties["nestedPropertyExtraction"] = ExpressionConverter.ConvertO(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractPdfPages))]
        public IBodyWorkflowAction<DtoResponseV4060ExtractPdfPages> ExtractPdfPages([WorkflowExpression] Func<string> dtoRequestV4060ExtractPdfPagespDFFile, [WorkflowExpression] Func<string> dtoRequestV4060ExtractPdfPagespagesToExtract)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4060ExtractPdfPages> __BuildExtractPdfPages(WorkflowExpression<string> dtoRequestV4060ExtractPdfPagespDFFile, WorkflowExpression<string> dtoRequestV4060ExtractPdfPagespagesToExtract)
        {
            WorkflowExpression.Validate(dtoRequestV4060ExtractPdfPagespDFFile, nameof(dtoRequestV4060ExtractPdfPagespDFFile), required: true);
            WorkflowExpression.Validate(dtoRequestV4060ExtractPdfPagespagesToExtract, nameof(dtoRequestV4060ExtractPdfPagespagesToExtract), required: true);
            return new DeferredBodyAction<DtoResponseV4060ExtractPdfPages>(() =>
            {
                var apiCallPath = "/V4060_ExtractPdfPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4060ExtractPdfPages = new JObject();
                var dtoRequestV4060ExtractPdfPagespropCount = 0;
                dtoRequestV4060ExtractPdfPagespropCount++;
                dtoRequestV4060ExtractPdfPages["file"] = ExpressionConverter.ConvertO(dtoRequestV4060ExtractPdfPagespDFFile);
                dtoRequestV4060ExtractPdfPagespropCount++;
                dtoRequestV4060ExtractPdfPages["pages"] = ExpressionConverter.ConvertO(dtoRequestV4060ExtractPdfPagespagesToExtract);
                if (dtoRequestV4060ExtractPdfPagespropCount > 0)
                {
                    callPayload.Body = dtoRequestV4060ExtractPdfPages;
                }

                return new ApiConnectionAction<DtoResponseV4060ExtractPdfPages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildExtractTextAccordingToPattern))]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern> ExtractTextAccordingToPattern([WorkflowExpression] Func<string> dtoRequestV2140ExtractTextAccordingToPatterntext, [WorkflowExpression] Func<string> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, [WorkflowExpression] Func<bool> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, [WorkflowExpression] Func<string> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern> __BuildExtractTextAccordingToPattern(WorkflowExpression<string> dtoRequestV2140ExtractTextAccordingToPatterntext, WorkflowExpression<string> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, WorkflowExpression<bool> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, WorkflowExpression<string> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
        {
            WorkflowExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatterntext, nameof(dtoRequestV2140ExtractTextAccordingToPatterntext), required: true);
            WorkflowExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, nameof(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern), required: true);
            WorkflowExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled), required: false);
            WorkflowExpression.Validate(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings, nameof(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings), required: false);
            return new DeferredBodyAction<DtoResponseV2140ExtractTextAccordingToPattern>(() =>
            {
                var apiCallPath = "/V2140_ExtractTextAccordingToPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2140ExtractTextAccordingToPattern = new JObject();
                var dtoRequestV2140ExtractTextAccordingToPatternpropCount = 0;
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                dtoRequestV2140ExtractTextAccordingToPattern["inputText"] = ExpressionConverter.ConvertO(dtoRequestV2140ExtractTextAccordingToPatterntext);
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                dtoRequestV2140ExtractTextAccordingToPattern["matchPattern"] = ExpressionConverter.ConvertO(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern);
                if (dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled != null)
                {
                    dtoRequestV2140ExtractTextAccordingToPattern["trimEnabled"] = ExpressionConverter.ConvertO(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled);
                    dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
                }

                if (dtoRequestV2140ExtractTextAccordingToPatterntrimStrings != null)
                {
                    dtoRequestV2140ExtractTextAccordingToPattern["trimStrings"] = ExpressionConverter.ConvertO(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractTextFromPdf))]
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf> ExtractTextFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<int> dtoRequestfromPage = null, [WorkflowExpression] Func<int> dtoRequesttoPage = null, [WorkflowExpression] Func<bool> dtoRequestlayoutBased = null, [WorkflowExpression] Func<bool> dtoRequestincludePages = null, [WorkflowExpression] Func<string> dtoRequestpageSeparator = null, [WorkflowExpression] Func<bool> dtoRequestnormalizeWhitespace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf> __BuildExtractTextFromPdf(WorkflowExpression<string> dtoRequestpDF, WorkflowExpression<int> dtoRequestfromPage = null, WorkflowExpression<int> dtoRequesttoPage = null, WorkflowExpression<bool> dtoRequestlayoutBased = null, WorkflowExpression<bool> dtoRequestincludePages = null, WorkflowExpression<string> dtoRequestpageSeparator = null, WorkflowExpression<bool> dtoRequestnormalizeWhitespace = null)
        {
            WorkflowExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            WorkflowExpression.Validate(dtoRequestfromPage, nameof(dtoRequestfromPage), required: false);
            WorkflowExpression.Validate(dtoRequesttoPage, nameof(dtoRequesttoPage), required: false);
            WorkflowExpression.Validate(dtoRequestlayoutBased, nameof(dtoRequestlayoutBased), required: false);
            WorkflowExpression.Validate(dtoRequestincludePages, nameof(dtoRequestincludePages), required: false);
            WorkflowExpression.Validate(dtoRequestpageSeparator, nameof(dtoRequestpageSeparator), required: false);
            WorkflowExpression.Validate(dtoRequestnormalizeWhitespace, nameof(dtoRequestnormalizeWhitespace), required: false);
            return new DeferredBodyAction<DtoResponseV4100ExtractTextFromPdf>(() =>
            {
                var apiCallPath = "/V4100_ExtractTextFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(dtoRequestpDF);
                if (dtoRequestfromPage != null)
                {
                    dtoRequest["fromPage"] = ExpressionConverter.ConvertO(dtoRequestfromPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequesttoPage != null)
                {
                    dtoRequest["toPage"] = ExpressionConverter.ConvertO(dtoRequesttoPage);
                    dtoRequestpropCount++;
                }

                if (dtoRequestlayoutBased != null)
                {
                    dtoRequest["layoutBased"] = ExpressionConverter.ConvertO(dtoRequestlayoutBased);
                    dtoRequestpropCount++;
                }

                if (dtoRequestincludePages != null)
                {
                    dtoRequest["includePages"] = ExpressionConverter.ConvertO(dtoRequestincludePages);
                    dtoRequestpropCount++;
                }

                if (dtoRequestpageSeparator != null)
                {
                    dtoRequest["pageSeparator"] = ExpressionConverter.ConvertO(dtoRequestpageSeparator);
                    dtoRequestpropCount++;
                }

                if (dtoRequestnormalizeWhitespace != null)
                {
                    dtoRequest["normalizeWhitespace"] = ExpressionConverter.ConvertO(dtoRequestnormalizeWhitespace);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractWordBookmarks))]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> ExtractWordBookmarks([WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarksfile, [WorkflowExpression] Func<bool> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, [WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarkssearchName = null, [WorkflowExpression] Func<string> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> __BuildExtractWordBookmarks(WorkflowExpression<string> dtoRequestV5021ExtractWordBookmarksfile, WorkflowExpression<bool> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, WorkflowExpression<string> dtoRequestV5021ExtractWordBookmarkssearchName = null, WorkflowExpression<string> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            WorkflowExpression.Validate(dtoRequestV5021ExtractWordBookmarksfile, nameof(dtoRequestV5021ExtractWordBookmarksfile), required: true);
            WorkflowExpression.Validate(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks, nameof(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks), required: false);
            WorkflowExpression.Validate(dtoRequestV5021ExtractWordBookmarkssearchName, nameof(dtoRequestV5021ExtractWordBookmarkssearchName), required: false);
            WorkflowExpression.Validate(dtoRequestV5021ExtractWordBookmarkssearchContent, nameof(dtoRequestV5021ExtractWordBookmarkssearchContent), required: false);
            return new DeferredBodyAction<DtoResponseV5021ExtractWordBookmarks>(() =>
            {
                var apiCallPath = "/V5021_ExtractWordBookmarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5021ExtractWordBookmarks = new JObject();
                var dtoRequestV5021ExtractWordBookmarkspropCount = 0;
                dtoRequestV5021ExtractWordBookmarkspropCount++;
                dtoRequestV5021ExtractWordBookmarks["file"] = ExpressionConverter.ConvertO(dtoRequestV5021ExtractWordBookmarksfile);
                if (dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                {
                    if (dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                    {
                        dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = ExpressionConverter.ConvertO(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks);
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
                    dtoRequestV5021ExtractWordBookmarks["searchKey"] = ExpressionConverter.ConvertO(dtoRequestV5021ExtractWordBookmarkssearchName);
                    dtoRequestV5021ExtractWordBookmarkspropCount++;
                }

                if (dtoRequestV5021ExtractWordBookmarkssearchContent != null)
                {
                    dtoRequestV5021ExtractWordBookmarks["searchValue"] = ExpressionConverter.ConvertO(dtoRequestV5021ExtractWordBookmarkssearchContent);
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
        [WorkflowExpressionFactory(nameof(__BuildExtractWordContentControls))]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> ExtractWordContentControls([WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlsfile, [WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlssearchTag = null, [WorkflowExpression] Func<string> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> __BuildExtractWordContentControls(WorkflowExpression<string> dtoRequestV5120ExtractWordContentControlsfile, WorkflowExpression<string> dtoRequestV5120ExtractWordContentControlssearchTag = null, WorkflowExpression<string> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            WorkflowExpression.Validate(dtoRequestV5120ExtractWordContentControlsfile, nameof(dtoRequestV5120ExtractWordContentControlsfile), required: true);
            WorkflowExpression.Validate(dtoRequestV5120ExtractWordContentControlssearchTag, nameof(dtoRequestV5120ExtractWordContentControlssearchTag), required: false);
            WorkflowExpression.Validate(dtoRequestV5120ExtractWordContentControlssearchTitle, nameof(dtoRequestV5120ExtractWordContentControlssearchTitle), required: false);
            return new DeferredBodyAction<DtoResponseV5120ExtractWordContentControls>(() =>
            {
                var apiCallPath = "/V5120_ExtractWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5120ExtractWordContentControls = new JObject();
                var dtoRequestV5120ExtractWordContentControlspropCount = 0;
                dtoRequestV5120ExtractWordContentControlspropCount++;
                dtoRequestV5120ExtractWordContentControls["file"] = ExpressionConverter.ConvertO(dtoRequestV5120ExtractWordContentControlsfile);
                if (dtoRequestV5120ExtractWordContentControlssearchTag != null)
                {
                    dtoRequestV5120ExtractWordContentControls["searchTag"] = ExpressionConverter.ConvertO(dtoRequestV5120ExtractWordContentControlssearchTag);
                    dtoRequestV5120ExtractWordContentControlspropCount++;
                }

                if (dtoRequestV5120ExtractWordContentControlssearchTitle != null)
                {
                    dtoRequestV5120ExtractWordContentControls["searchTitle"] = ExpressionConverter.ConvertO(dtoRequestV5120ExtractWordContentControlssearchTitle);
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
        [WorkflowExpressionFactory(nameof(__BuildIbanData))]
        public IBodyWorkflowAction<DtoResponseV2021IbanData> IbanData([WorkflowExpression] Func<string> dtoRequestV2021IbanDataiBAN)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2021IbanData> __BuildIbanData(WorkflowExpression<string> dtoRequestV2021IbanDataiBAN)
        {
            WorkflowExpression.Validate(dtoRequestV2021IbanDataiBAN, nameof(dtoRequestV2021IbanDataiBAN), required: true);
            return new DeferredBodyAction<DtoResponseV2021IbanData>(() =>
            {
                var apiCallPath = "/V2021_IbanData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2021IbanData = new JObject();
                var dtoRequestV2021IbanDatapropCount = 0;
                dtoRequestV2021IbanDatapropCount++;
                dtoRequestV2021IbanData["iban"] = ExpressionConverter.ConvertO(dtoRequestV2021IbanDataiBAN);
                if (dtoRequestV2021IbanDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV2021IbanData;
                }

                return new ApiConnectionAction<DtoResponseV2021IbanData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildImageMetaData))]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData> ImageMetaData([WorkflowExpression] Func<string> dtoRequestV3071ImageMetaDataimageFile)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData> __BuildImageMetaData(WorkflowExpression<string> dtoRequestV3071ImageMetaDataimageFile)
        {
            WorkflowExpression.Validate(dtoRequestV3071ImageMetaDataimageFile, nameof(dtoRequestV3071ImageMetaDataimageFile), required: true);
            return new DeferredBodyAction<DtoResponseV3071ImageMetaData>(() =>
            {
                var apiCallPath = "/V3071_ImageMetaData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3071ImageMetaData = new JObject();
                var dtoRequestV3071ImageMetaDatapropCount = 0;
                dtoRequestV3071ImageMetaDatapropCount++;
                dtoRequestV3071ImageMetaData["file"] = ExpressionConverter.ConvertO(dtoRequestV3071ImageMetaDataimageFile);
                if (dtoRequestV3071ImageMetaDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV3071ImageMetaData;
                }

                return new ApiConnectionAction<DtoResponseV3071ImageMetaData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildInsertImageToPowerPoint))]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToPowerPoint([WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderImage, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderName = null, [WorkflowExpression] Func<int> dtoRequestV9020InsertImagePowerPointmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV9020InsertImagePowerPointmaximumImageHeight = null, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV9020InsertImagePowerPointplaceholderSuffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildInsertImageToPowerPoint(WorkflowExpression<string> dtoRequestV9020InsertImagePowerPointexistingFileContent, WorkflowExpression<string> dtoRequestV9020InsertImagePowerPointplaceholderImage, WorkflowExpression<string> dtoRequestV9020InsertImagePowerPointplaceholderName = null, WorkflowExpression<int> dtoRequestV9020InsertImagePowerPointmaximumImageWidth = null, WorkflowExpression<int> dtoRequestV9020InsertImagePowerPointmaximumImageHeight = null, WorkflowExpression<string> dtoRequestV9020InsertImagePowerPointplaceholderPrefix = null, WorkflowExpression<string> dtoRequestV9020InsertImagePowerPointplaceholderSuffix = null)
        {
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointexistingFileContent, nameof(dtoRequestV9020InsertImagePowerPointexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderImage, nameof(dtoRequestV9020InsertImagePowerPointplaceholderImage), required: true);
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderName, nameof(dtoRequestV9020InsertImagePowerPointplaceholderName), required: false);
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointmaximumImageWidth, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointmaximumImageHeight, nameof(dtoRequestV9020InsertImagePowerPointmaximumImageHeight), required: false);
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderPrefix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderPrefix), required: false);
            WorkflowExpression.Validate(dtoRequestV9020InsertImagePowerPointplaceholderSuffix, nameof(dtoRequestV9020InsertImagePowerPointplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V9020_InsertImageToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV9020InsertImagePowerPoint = new JObject();
                var dtoRequestV9020InsertImagePowerPointpropCount = 0;
                dtoRequestV9020InsertImagePowerPointpropCount++;
                dtoRequestV9020InsertImagePowerPoint["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointexistingFileContent);
                if (dtoRequestV9020InsertImagePowerPointplaceholderName != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderName"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointplaceholderName);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                dtoRequestV9020InsertImagePowerPointpropCount++;
                dtoRequestV9020InsertImagePowerPoint["placeholderImage"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointplaceholderImage);
                if (dtoRequestV9020InsertImagePowerPointmaximumImageWidth != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["width"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointmaximumImageWidth);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointmaximumImageHeight != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["height"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointmaximumImageHeight);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointplaceholderPrefix != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointplaceholderPrefix);
                    dtoRequestV9020InsertImagePowerPointpropCount++;
                }

                if (dtoRequestV9020InsertImagePowerPointplaceholderSuffix != null)
                {
                    dtoRequestV9020InsertImagePowerPoint["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestV9020InsertImagePowerPointplaceholderSuffix);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertImageToWord))]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToWord([WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordimage, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordplaceholderName = null, [WorkflowExpression] Func<int> dtoRequestV5081InsertImageToWordmaximumImageWidth = null, [WorkflowExpression] Func<int> dtoRequestV5081InsertImageToWordmaximumImageHeight = null, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5081InsertImageToWordplaceholderSuffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildInsertImageToWord(WorkflowExpression<string> dtoRequestV5081InsertImageToWordexistingFileContent, WorkflowExpression<string> dtoRequestV5081InsertImageToWordimage, WorkflowExpression<string> dtoRequestV5081InsertImageToWordplaceholderName = null, WorkflowExpression<int> dtoRequestV5081InsertImageToWordmaximumImageWidth = null, WorkflowExpression<int> dtoRequestV5081InsertImageToWordmaximumImageHeight = null, WorkflowExpression<string> dtoRequestV5081InsertImageToWordplaceholderPrefix = null, WorkflowExpression<string> dtoRequestV5081InsertImageToWordplaceholderSuffix = null)
        {
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordexistingFileContent, nameof(dtoRequestV5081InsertImageToWordexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordimage, nameof(dtoRequestV5081InsertImageToWordimage), required: true);
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordplaceholderName, nameof(dtoRequestV5081InsertImageToWordplaceholderName), required: false);
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordmaximumImageWidth, nameof(dtoRequestV5081InsertImageToWordmaximumImageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordmaximumImageHeight, nameof(dtoRequestV5081InsertImageToWordmaximumImageHeight), required: false);
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordplaceholderPrefix, nameof(dtoRequestV5081InsertImageToWordplaceholderPrefix), required: false);
            WorkflowExpression.Validate(dtoRequestV5081InsertImageToWordplaceholderSuffix, nameof(dtoRequestV5081InsertImageToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V5081_InsertImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5081InsertImageToWord = new JObject();
                var dtoRequestV5081InsertImageToWordpropCount = 0;
                dtoRequestV5081InsertImageToWordpropCount++;
                dtoRequestV5081InsertImageToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordexistingFileContent);
                if (dtoRequestV5081InsertImageToWordplaceholderName != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderName"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordplaceholderName);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                dtoRequestV5081InsertImageToWordpropCount++;
                dtoRequestV5081InsertImageToWord["placeholderImage"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordimage);
                if (dtoRequestV5081InsertImageToWordmaximumImageWidth != null)
                {
                    dtoRequestV5081InsertImageToWord["maxWidth"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordmaximumImageWidth);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordmaximumImageHeight != null)
                {
                    dtoRequestV5081InsertImageToWord["maxHeight"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordmaximumImageHeight);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordplaceholderPrefix != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordplaceholderPrefix);
                    dtoRequestV5081InsertImageToWordpropCount++;
                }

                if (dtoRequestV5081InsertImageToWordplaceholderSuffix != null)
                {
                    dtoRequestV5081InsertImageToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestV5081InsertImageToWordplaceholderSuffix);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertMultipleTextSectionsToWord))]
        public IBodyWorkflowAction<DtoResponseV5110InsertMultipleTextSectionsToWord> InsertMultipleTextSectionsToWord([WorkflowExpression] Func<string> dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, [WorkflowExpression] Func<InsertSection[]> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, [WorkflowExpression] Func<string> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5110InsertMultipleTextSectionsToWord> __BuildInsertMultipleTextSectionsToWord(WorkflowExpression<string> dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, WorkflowExpression<InsertSection[]> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, WorkflowExpression<string> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = null, WorkflowExpression<string> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = null)
        {
            WorkflowExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder), required: true);
            WorkflowExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix), required: false);
            WorkflowExpression.Validate(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix, nameof(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseV5110InsertMultipleTextSectionsToWord>(() =>
            {
                var apiCallPath = "/V5110_InsertMultipleTextSectionsToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5110InsertMultipleTextSectionsToWord = new JObject();
                var dtoRequestV5110InsertMultipleTextSectionsToWordpropCount = 0;
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                dtoRequestV5110InsertMultipleTextSectionsToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent);
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                dtoRequestV5110InsertMultipleTextSectionsToWord["insertSections"] = ExpressionConverter.ConvertO(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder);
                if (dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix != null)
                {
                    dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix);
                    dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
                }

                if (dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix != null)
                {
                    dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertTableToWord))]
        public IBodyWorkflowAction<DtoResponseV5091InsertTableToWord> InsertTableToWord([WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderName = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderTable = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordtableStyle = null, [WorkflowExpression] Func<bool> dtoRequestV5091InsertTableToWordshowHeaders = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5091InsertTableToWordplaceholderSuffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5091InsertTableToWord> __BuildInsertTableToWord(WorkflowExpression<string> dtoRequestV5091InsertTableToWordexistingFileContent, WorkflowExpression<string> dtoRequestV5091InsertTableToWordplaceholderName = null, WorkflowExpression<string> dtoRequestV5091InsertTableToWordplaceholderTable = null, WorkflowExpression<string> dtoRequestV5091InsertTableToWordtableStyle = null, WorkflowExpression<bool> dtoRequestV5091InsertTableToWordshowHeaders = null, WorkflowExpression<string> dtoRequestV5091InsertTableToWordplaceholderPrefix = null, WorkflowExpression<string> dtoRequestV5091InsertTableToWordplaceholderSuffix = null)
        {
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordexistingFileContent, nameof(dtoRequestV5091InsertTableToWordexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderName, nameof(dtoRequestV5091InsertTableToWordplaceholderName), required: false);
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderTable, nameof(dtoRequestV5091InsertTableToWordplaceholderTable), required: false);
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordtableStyle, nameof(dtoRequestV5091InsertTableToWordtableStyle), required: false);
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordshowHeaders, nameof(dtoRequestV5091InsertTableToWordshowHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderPrefix, nameof(dtoRequestV5091InsertTableToWordplaceholderPrefix), required: false);
            WorkflowExpression.Validate(dtoRequestV5091InsertTableToWordplaceholderSuffix, nameof(dtoRequestV5091InsertTableToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseV5091InsertTableToWord>(() =>
            {
                var apiCallPath = "/V5091_InsertTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5091InsertTableToWord = new JObject();
                var dtoRequestV5091InsertTableToWordpropCount = 0;
                dtoRequestV5091InsertTableToWordpropCount++;
                dtoRequestV5091InsertTableToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordexistingFileContent);
                if (dtoRequestV5091InsertTableToWordplaceholderName != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderName"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordplaceholderName);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordplaceholderTable != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderTable"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordplaceholderTable);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordtableStyle != null)
                {
                    if (dtoRequestV5091InsertTableToWordtableStyle != null)
                    {
                        dtoRequestV5091InsertTableToWord["tableStyle"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordtableStyle);
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
                        dtoRequestV5091InsertTableToWord["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordshowHeaders);
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
                    dtoRequestV5091InsertTableToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordplaceholderPrefix);
                    dtoRequestV5091InsertTableToWordpropCount++;
                }

                if (dtoRequestV5091InsertTableToWordplaceholderSuffix != null)
                {
                    dtoRequestV5091InsertTableToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordplaceholderSuffix);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertTextToPowerPoint))]
        public IBodyWorkflowAction<DtoResponseFile> InsertTextToPowerPoint([WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderName, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderText = null, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildInsertTextToPowerPoint(WorkflowExpression<string> dtoRequestV9010InsertTextToPowerPointexistingFileContent, WorkflowExpression<string> dtoRequestV9010InsertTextToPowerPointplaceholderName, WorkflowExpression<string> dtoRequestV9010InsertTextToPowerPointplaceholderText = null, WorkflowExpression<string> dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = null, WorkflowExpression<string> dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            WorkflowExpression.Validate(dtoRequestV9010InsertTextToPowerPointexistingFileContent, nameof(dtoRequestV9010InsertTextToPowerPointexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderName, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderName), required: true);
            WorkflowExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderText, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderText), required: false);
            WorkflowExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix), required: false);
            WorkflowExpression.Validate(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix, nameof(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V9010_InsertTextToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV9010InsertTextToPowerPoint = new JObject();
                var dtoRequestV9010InsertTextToPowerPointpropCount = 0;
                dtoRequestV9010InsertTextToPowerPointpropCount++;
                dtoRequestV9010InsertTextToPowerPoint["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV9010InsertTextToPowerPointexistingFileContent);
                dtoRequestV9010InsertTextToPowerPointpropCount++;
                dtoRequestV9010InsertTextToPowerPoint["placeholderName"] = ExpressionConverter.ConvertO(dtoRequestV9010InsertTextToPowerPointplaceholderName);
                if (dtoRequestV9010InsertTextToPowerPointplaceholderText != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderText"] = ExpressionConverter.ConvertO(dtoRequestV9010InsertTextToPowerPointplaceholderText);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (dtoRequestV9010InsertTextToPowerPointplaceholderPrefix != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix);
                    dtoRequestV9010InsertTextToPowerPointpropCount++;
                }

                if (dtoRequestV9010InsertTextToPowerPointplaceholderSuffix != null)
                {
                    dtoRequestV9010InsertTextToPowerPoint["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertTextToWord))]
        public IBodyWorkflowAction<DtoResponseV5071InsertTextToWord> InsertTextToWord([WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderName, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderText = null, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderPrefix = null, [WorkflowExpression] Func<string> dtoRequestV5071InsertTextToWordplaceholderSuffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5071InsertTextToWord> __BuildInsertTextToWord(WorkflowExpression<string> dtoRequestV5071InsertTextToWordexistingFileContent, WorkflowExpression<string> dtoRequestV5071InsertTextToWordplaceholderName, WorkflowExpression<string> dtoRequestV5071InsertTextToWordplaceholderText = null, WorkflowExpression<string> dtoRequestV5071InsertTextToWordplaceholderPrefix = null, WorkflowExpression<string> dtoRequestV5071InsertTextToWordplaceholderSuffix = null)
        {
            WorkflowExpression.Validate(dtoRequestV5071InsertTextToWordexistingFileContent, nameof(dtoRequestV5071InsertTextToWordexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderName, nameof(dtoRequestV5071InsertTextToWordplaceholderName), required: true);
            WorkflowExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderText, nameof(dtoRequestV5071InsertTextToWordplaceholderText), required: false);
            WorkflowExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderPrefix, nameof(dtoRequestV5071InsertTextToWordplaceholderPrefix), required: false);
            WorkflowExpression.Validate(dtoRequestV5071InsertTextToWordplaceholderSuffix, nameof(dtoRequestV5071InsertTextToWordplaceholderSuffix), required: false);
            return new DeferredBodyAction<DtoResponseV5071InsertTextToWord>(() =>
            {
                var apiCallPath = "/V5071_InsertTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5071InsertTextToWord = new JObject();
                var dtoRequestV5071InsertTextToWordpropCount = 0;
                dtoRequestV5071InsertTextToWordpropCount++;
                dtoRequestV5071InsertTextToWord["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestV5071InsertTextToWordexistingFileContent);
                dtoRequestV5071InsertTextToWordpropCount++;
                dtoRequestV5071InsertTextToWord["placeholderName"] = ExpressionConverter.ConvertO(dtoRequestV5071InsertTextToWordplaceholderName);
                if (dtoRequestV5071InsertTextToWordplaceholderText != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderText"] = ExpressionConverter.ConvertO(dtoRequestV5071InsertTextToWordplaceholderText);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (dtoRequestV5071InsertTextToWordplaceholderPrefix != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestV5071InsertTextToWordplaceholderPrefix);
                    dtoRequestV5071InsertTextToWordpropCount++;
                }

                if (dtoRequestV5071InsertTextToWordplaceholderSuffix != null)
                {
                    dtoRequestV5071InsertTextToWord["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestV5071InsertTextToWordplaceholderSuffix);
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
        [WorkflowExpressionFactory(nameof(__BuildMergePdfs))]
        public IBodyWorkflowAction<DtoResponseV4021MergePdfs> MergePdfs([WorkflowExpression] Func<string> dtoRequestV4021MergePdfsfile1, [WorkflowExpression] Func<string> dtoRequestV4021MergePdfsfile2)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4021MergePdfs> __BuildMergePdfs(WorkflowExpression<string> dtoRequestV4021MergePdfsfile1, WorkflowExpression<string> dtoRequestV4021MergePdfsfile2)
        {
            WorkflowExpression.Validate(dtoRequestV4021MergePdfsfile1, nameof(dtoRequestV4021MergePdfsfile1), required: true);
            WorkflowExpression.Validate(dtoRequestV4021MergePdfsfile2, nameof(dtoRequestV4021MergePdfsfile2), required: true);
            return new DeferredBodyAction<DtoResponseV4021MergePdfs>(() =>
            {
                var apiCallPath = "/V4021_MergePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4021MergePdfs = new JObject();
                var dtoRequestV4021MergePdfspropCount = 0;
                dtoRequestV4021MergePdfspropCount++;
                dtoRequestV4021MergePdfs["file1"] = ExpressionConverter.ConvertO(dtoRequestV4021MergePdfsfile1);
                dtoRequestV4021MergePdfspropCount++;
                dtoRequestV4021MergePdfs["file2"] = ExpressionConverter.ConvertO(dtoRequestV4021MergePdfsfile2);
                if (dtoRequestV4021MergePdfspropCount > 0)
                {
                    callPayload.Body = dtoRequestV4021MergePdfs;
                }

                return new ApiConnectionAction<DtoResponseV4021MergePdfs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildPatternMatchCheck))]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck> PatternMatchCheck([WorkflowExpression] Func<string> dtoRequestV2120PatternMatchCheckinputText, [WorkflowExpression] Func<string> dtoRequestV2120PatternMatchCheckmatchPattern)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck> __BuildPatternMatchCheck(WorkflowExpression<string> dtoRequestV2120PatternMatchCheckinputText, WorkflowExpression<string> dtoRequestV2120PatternMatchCheckmatchPattern)
        {
            WorkflowExpression.Validate(dtoRequestV2120PatternMatchCheckinputText, nameof(dtoRequestV2120PatternMatchCheckinputText), required: true);
            WorkflowExpression.Validate(dtoRequestV2120PatternMatchCheckmatchPattern, nameof(dtoRequestV2120PatternMatchCheckmatchPattern), required: true);
            return new DeferredBodyAction<DtoResponseV2120MatchPatternCheck>(() =>
            {
                var apiCallPath = "/V2120_PatternMatchCheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2120PatternMatchCheck = new JObject();
                var dtoRequestV2120PatternMatchCheckpropCount = 0;
                dtoRequestV2120PatternMatchCheckpropCount++;
                dtoRequestV2120PatternMatchCheck["inputText"] = ExpressionConverter.ConvertO(dtoRequestV2120PatternMatchCheckinputText);
                dtoRequestV2120PatternMatchCheckpropCount++;
                dtoRequestV2120PatternMatchCheck["matchPattern"] = ExpressionConverter.ConvertO(dtoRequestV2120PatternMatchCheckmatchPattern);
                if (dtoRequestV2120PatternMatchCheckpropCount > 0)
                {
                    callPayload.Body = dtoRequestV2120PatternMatchCheck;
                }

                return new ApiConnectionAction<DtoResponseV2120MatchPatternCheck>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildPdfMetadata))]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> PdfMetadata([WorkflowExpression] Func<string> dtoRequestV4031PdfMetadatafile)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> __BuildPdfMetadata(WorkflowExpression<string> dtoRequestV4031PdfMetadatafile)
        {
            WorkflowExpression.Validate(dtoRequestV4031PdfMetadatafile, nameof(dtoRequestV4031PdfMetadatafile), required: true);
            return new DeferredBodyAction<DtoResponseV4031PdfMetadata>(() =>
            {
                var apiCallPath = "/V4031_PdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4031PdfMetadata = new JObject();
                var dtoRequestV4031PdfMetadatapropCount = 0;
                dtoRequestV4031PdfMetadatapropCount++;
                dtoRequestV4031PdfMetadata["file"] = ExpressionConverter.ConvertO(dtoRequestV4031PdfMetadatafile);
                if (dtoRequestV4031PdfMetadatapropCount > 0)
                {
                    callPayload.Body = dtoRequestV4031PdfMetadata;
                }

                return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildProtectPdf))]
        public IBodyWorkflowAction<DtoResponseV4041ProtectPdf> ProtectPdf([WorkflowExpression] Func<string> dtoRequestV4041ProtectPdffile, [WorkflowExpression] Func<string> dtoRequestV4041ProtectPdfownerPassword = null, [WorkflowExpression] Func<string> dtoRequestV4041ProtectPdfuserPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4041ProtectPdf> __BuildProtectPdf(WorkflowExpression<string> dtoRequestV4041ProtectPdffile, WorkflowExpression<string> dtoRequestV4041ProtectPdfownerPassword = null, WorkflowExpression<string> dtoRequestV4041ProtectPdfuserPassword = null)
        {
            WorkflowExpression.Validate(dtoRequestV4041ProtectPdffile, nameof(dtoRequestV4041ProtectPdffile), required: true);
            WorkflowExpression.Validate(dtoRequestV4041ProtectPdfownerPassword, nameof(dtoRequestV4041ProtectPdfownerPassword), required: false);
            WorkflowExpression.Validate(dtoRequestV4041ProtectPdfuserPassword, nameof(dtoRequestV4041ProtectPdfuserPassword), required: false);
            return new DeferredBodyAction<DtoResponseV4041ProtectPdf>(() =>
            {
                var apiCallPath = "/V4041_ProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4041ProtectPdf = new JObject();
                var dtoRequestV4041ProtectPdfpropCount = 0;
                dtoRequestV4041ProtectPdfpropCount++;
                dtoRequestV4041ProtectPdf["file"] = ExpressionConverter.ConvertO(dtoRequestV4041ProtectPdffile);
                if (dtoRequestV4041ProtectPdfownerPassword != null)
                {
                    dtoRequestV4041ProtectPdf["ownerPassword"] = ExpressionConverter.ConvertO(dtoRequestV4041ProtectPdfownerPassword);
                    dtoRequestV4041ProtectPdfpropCount++;
                }

                if (dtoRequestV4041ProtectPdfuserPassword != null)
                {
                    dtoRequestV4041ProtectPdf["userPassword"] = ExpressionConverter.ConvertO(dtoRequestV4041ProtectPdfuserPassword);
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
        [WorkflowExpressionFactory(nameof(__BuildReadCode))]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode> ReadCode([WorkflowExpression] Func<string> dtoRequestReadCodeDataqROrBarcode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode> __BuildReadCode(WorkflowExpression<string> dtoRequestReadCodeDataqROrBarcode)
        {
            WorkflowExpression.Validate(dtoRequestReadCodeDataqROrBarcode, nameof(dtoRequestReadCodeDataqROrBarcode), required: true);
            return new DeferredBodyAction<DtoResponseV3051ReadCode>(() =>
            {
                var apiCallPath = "/V3051_ReadCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestReadCodeData = new JObject();
                var dtoRequestReadCodeDatapropCount = 0;
                dtoRequestReadCodeDatapropCount++;
                dtoRequestReadCodeData["file"] = ExpressionConverter.ConvertO(dtoRequestReadCodeDataqROrBarcode);
                if (dtoRequestReadCodeDatapropCount > 0)
                {
                    callPayload.Body = dtoRequestReadCodeData;
                }

                return new ApiConnectionAction<DtoResponseV3051ReadCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildRegularExpression))]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression> RegularExpression([WorkflowExpression] Func<string> dtoRequestV2011RegularExpressiontextToMatch, [WorkflowExpression] Func<string> dtoRequestV2011RegularExpressionregularExpression = null, [WorkflowExpression] Func<string> dtoRequestV2011RegularExpressionregularExpressionOption = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression> __BuildRegularExpression(WorkflowExpression<string> dtoRequestV2011RegularExpressiontextToMatch, WorkflowExpression<string> dtoRequestV2011RegularExpressionregularExpression = null, WorkflowExpression<string> dtoRequestV2011RegularExpressionregularExpressionOption = null)
        {
            WorkflowExpression.Validate(dtoRequestV2011RegularExpressiontextToMatch, nameof(dtoRequestV2011RegularExpressiontextToMatch), required: true);
            WorkflowExpression.Validate(dtoRequestV2011RegularExpressionregularExpression, nameof(dtoRequestV2011RegularExpressionregularExpression), required: false);
            WorkflowExpression.Validate(dtoRequestV2011RegularExpressionregularExpressionOption, nameof(dtoRequestV2011RegularExpressionregularExpressionOption), required: false);
            return new DeferredBodyAction<DtoResponseV2011RegularExpression>(() =>
            {
                var apiCallPath = "/V2011_RegularExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2011RegularExpression = new JObject();
                var dtoRequestV2011RegularExpressionpropCount = 0;
                dtoRequestV2011RegularExpressionpropCount++;
                dtoRequestV2011RegularExpression["input"] = ExpressionConverter.ConvertO(dtoRequestV2011RegularExpressiontextToMatch);
                if (dtoRequestV2011RegularExpressionregularExpression != null)
                {
                    dtoRequestV2011RegularExpression["pattern"] = ExpressionConverter.ConvertO(dtoRequestV2011RegularExpressionregularExpression);
                    dtoRequestV2011RegularExpressionpropCount++;
                }

                if (dtoRequestV2011RegularExpressionregularExpressionOption != null)
                {
                    dtoRequestV2011RegularExpression["option"] = ExpressionConverter.ConvertO(dtoRequestV2011RegularExpressionregularExpressionOption);
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
        [WorkflowExpressionFactory(nameof(__BuildRemovePagesFromPdf))]
        public IBodyWorkflowAction<DtoResponseV4110RemovePagesFromPdf> RemovePagesFromPdf([WorkflowExpression] Func<string> dtoRequestpDF, [WorkflowExpression] Func<string> dtoRequestpages, [WorkflowExpression] Func<bool> dtoRequestinputIs1Based = null, [WorkflowExpression] Func<int> dtoRequestmode = null, [WorkflowExpression] Func<bool> dtoRequestfailIfPageOutOfRange = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4110RemovePagesFromPdf> __BuildRemovePagesFromPdf(WorkflowExpression<string> dtoRequestpDF, WorkflowExpression<string> dtoRequestpages, WorkflowExpression<bool> dtoRequestinputIs1Based = null, WorkflowExpression<int> dtoRequestmode = null, WorkflowExpression<bool> dtoRequestfailIfPageOutOfRange = null)
        {
            WorkflowExpression.Validate(dtoRequestpDF, nameof(dtoRequestpDF), required: true);
            WorkflowExpression.Validate(dtoRequestpages, nameof(dtoRequestpages), required: true);
            WorkflowExpression.Validate(dtoRequestinputIs1Based, nameof(dtoRequestinputIs1Based), required: false);
            WorkflowExpression.Validate(dtoRequestmode, nameof(dtoRequestmode), required: false);
            WorkflowExpression.Validate(dtoRequestfailIfPageOutOfRange, nameof(dtoRequestfailIfPageOutOfRange), required: false);
            return new DeferredBodyAction<DtoResponseV4110RemovePagesFromPdf>(() =>
            {
                var apiCallPath = "/V4110_RemovePagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequest = new JObject();
                var dtoRequestpropCount = 0;
                dtoRequestpropCount++;
                dtoRequest["pdf"] = ExpressionConverter.ConvertO(dtoRequestpDF);
                dtoRequestpropCount++;
                dtoRequest["pages"] = ExpressionConverter.ConvertO(dtoRequestpages);
                if (dtoRequestinputIs1Based != null)
                {
                    dtoRequest["oneBased"] = ExpressionConverter.ConvertO(dtoRequestinputIs1Based);
                    dtoRequestpropCount++;
                }

                if (dtoRequestmode != null)
                {
                    dtoRequest["mode"] = ExpressionConverter.ConvertO(dtoRequestmode);
                    dtoRequestpropCount++;
                }

                if (dtoRequestfailIfPageOutOfRange != null)
                {
                    dtoRequest["strict"] = ExpressionConverter.ConvertO(dtoRequestfailIfPageOutOfRange);
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
        [WorkflowExpressionFactory(nameof(__BuildReplaceTextWithPattern))]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern> ReplaceTextWithPattern([WorkflowExpression] Func<string> dtoRequestV2110ReplaceTextWithPatterninputText, [WorkflowExpression] Func<string> dtoRequestV2110ReplaceTextWithPatternsearchPattern, [WorkflowExpression] Func<string> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern> __BuildReplaceTextWithPattern(WorkflowExpression<string> dtoRequestV2110ReplaceTextWithPatterninputText, WorkflowExpression<string> dtoRequestV2110ReplaceTextWithPatternsearchPattern, WorkflowExpression<string> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
        {
            WorkflowExpression.Validate(dtoRequestV2110ReplaceTextWithPatterninputText, nameof(dtoRequestV2110ReplaceTextWithPatterninputText), required: true);
            WorkflowExpression.Validate(dtoRequestV2110ReplaceTextWithPatternsearchPattern, nameof(dtoRequestV2110ReplaceTextWithPatternsearchPattern), required: true);
            WorkflowExpression.Validate(dtoRequestV2110ReplaceTextWithPatternreplacementText, nameof(dtoRequestV2110ReplaceTextWithPatternreplacementText), required: false);
            return new DeferredBodyAction<DtoResponseV2110ReplaceTextWithPattern>(() =>
            {
                var apiCallPath = "/V2110_ReplaceTextWithPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2110ReplaceTextWithPattern = new JObject();
                var dtoRequestV2110ReplaceTextWithPatternpropCount = 0;
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
                dtoRequestV2110ReplaceTextWithPattern["inputText"] = ExpressionConverter.ConvertO(dtoRequestV2110ReplaceTextWithPatterninputText);
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
                dtoRequestV2110ReplaceTextWithPattern["searchPattern"] = ExpressionConverter.ConvertO(dtoRequestV2110ReplaceTextWithPatternsearchPattern);
                if (dtoRequestV2110ReplaceTextWithPatternreplacementText != null)
                {
                    dtoRequestV2110ReplaceTextWithPattern["replacementText"] = ExpressionConverter.ConvertO(dtoRequestV2110ReplaceTextWithPatternreplacementText);
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
        [WorkflowExpressionFactory(nameof(__BuildResizeImage))]
        public IBodyWorkflowAction<DtoResponseV3022ResizeImage> ResizeImage([WorkflowExpression] Func<string> dtoRequestV3022ResizeImageimageFile, [WorkflowExpression] Func<double> dtoRequestV3022ResizeImageimageWidth = null, [WorkflowExpression] Func<double> dtoRequestV3022ResizeImageimageHeight = null, [WorkflowExpression] Func<string> dtoRequestV3022ResizeImageresizeBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3022ResizeImage> __BuildResizeImage(WorkflowExpression<string> dtoRequestV3022ResizeImageimageFile, WorkflowExpression<double> dtoRequestV3022ResizeImageimageWidth = null, WorkflowExpression<double> dtoRequestV3022ResizeImageimageHeight = null, WorkflowExpression<string> dtoRequestV3022ResizeImageresizeBy = null)
        {
            WorkflowExpression.Validate(dtoRequestV3022ResizeImageimageFile, nameof(dtoRequestV3022ResizeImageimageFile), required: true);
            WorkflowExpression.Validate(dtoRequestV3022ResizeImageimageWidth, nameof(dtoRequestV3022ResizeImageimageWidth), required: false);
            WorkflowExpression.Validate(dtoRequestV3022ResizeImageimageHeight, nameof(dtoRequestV3022ResizeImageimageHeight), required: false);
            WorkflowExpression.Validate(dtoRequestV3022ResizeImageresizeBy, nameof(dtoRequestV3022ResizeImageresizeBy), required: false);
            return new DeferredBodyAction<DtoResponseV3022ResizeImage>(() =>
            {
                var apiCallPath = "/V3022_ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3022ResizeImage = new JObject();
                var dtoRequestV3022ResizeImagepropCount = 0;
                dtoRequestV3022ResizeImagepropCount++;
                dtoRequestV3022ResizeImage["file"] = ExpressionConverter.ConvertO(dtoRequestV3022ResizeImageimageFile);
                if (dtoRequestV3022ResizeImageimageWidth != null)
                {
                    dtoRequestV3022ResizeImage["width"] = ExpressionConverter.ConvertO(dtoRequestV3022ResizeImageimageWidth);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (dtoRequestV3022ResizeImageimageHeight != null)
                {
                    dtoRequestV3022ResizeImage["height"] = ExpressionConverter.ConvertO(dtoRequestV3022ResizeImageimageHeight);
                    dtoRequestV3022ResizeImagepropCount++;
                }

                if (dtoRequestV3022ResizeImageresizeBy != null)
                {
                    dtoRequestV3022ResizeImage["resizeBy"] = ExpressionConverter.ConvertO(dtoRequestV3022ResizeImageresizeBy);
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
        [WorkflowExpressionFactory(nameof(__BuildRotateImage))]
        public IBodyWorkflowAction<DtoResponseV3031RotateImage> RotateImage([WorkflowExpression] Func<string> dtoRequestV3031RotateImageimageFile, [WorkflowExpression] Func<double> dtoRequestV3031RotateImagerotate = null, [WorkflowExpression] Func<string> dtoRequestV3031RotateImageoutputFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV3031RotateImage> __BuildRotateImage(WorkflowExpression<string> dtoRequestV3031RotateImageimageFile, WorkflowExpression<double> dtoRequestV3031RotateImagerotate = null, WorkflowExpression<string> dtoRequestV3031RotateImageoutputFormat = null)
        {
            WorkflowExpression.Validate(dtoRequestV3031RotateImageimageFile, nameof(dtoRequestV3031RotateImageimageFile), required: true);
            WorkflowExpression.Validate(dtoRequestV3031RotateImagerotate, nameof(dtoRequestV3031RotateImagerotate), required: false);
            WorkflowExpression.Validate(dtoRequestV3031RotateImageoutputFormat, nameof(dtoRequestV3031RotateImageoutputFormat), required: false);
            return new DeferredBodyAction<DtoResponseV3031RotateImage>(() =>
            {
                var apiCallPath = "/V3031_RotateImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV3031RotateImage = new JObject();
                var dtoRequestV3031RotateImagepropCount = 0;
                dtoRequestV3031RotateImagepropCount++;
                dtoRequestV3031RotateImage["file"] = ExpressionConverter.ConvertO(dtoRequestV3031RotateImageimageFile);
                if (dtoRequestV3031RotateImagerotate != null)
                {
                    dtoRequestV3031RotateImage["rotate"] = ExpressionConverter.ConvertO(dtoRequestV3031RotateImagerotate);
                    dtoRequestV3031RotateImagepropCount++;
                }

                if (dtoRequestV3031RotateImageoutputFormat != null)
                {
                    dtoRequestV3031RotateImage["outFormat"] = ExpressionConverter.ConvertO(dtoRequestV3031RotateImageoutputFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildRunCode))]
        public IBodyWorkflowAction<DtoResponseV2151RunCode> RunCode([WorkflowExpression] Func<string> dtopythonOrJavaScriptCode, [WorkflowExpression] Func<int> dtoruntime = null, [WorkflowExpression] Func<int> dtotimeoutSeconds = null, [WorkflowExpression] Func<bool> dtoprintLastExpression = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2151RunCode> __BuildRunCode(WorkflowExpression<string> dtopythonOrJavaScriptCode, WorkflowExpression<int> dtoruntime = null, WorkflowExpression<int> dtotimeoutSeconds = null, WorkflowExpression<bool> dtoprintLastExpression = null)
        {
            WorkflowExpression.Validate(dtopythonOrJavaScriptCode, nameof(dtopythonOrJavaScriptCode), required: true);
            WorkflowExpression.Validate(dtoruntime, nameof(dtoruntime), required: false);
            WorkflowExpression.Validate(dtotimeoutSeconds, nameof(dtotimeoutSeconds), required: false);
            WorkflowExpression.Validate(dtoprintLastExpression, nameof(dtoprintLastExpression), required: false);
            return new DeferredBodyAction<DtoResponseV2151RunCode>(() =>
            {
                var apiCallPath = "/V2151_RunCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dto = new JObject();
                var dtopropCount = 0;
                dtopropCount++;
                dto["code"] = ExpressionConverter.ConvertO(dtopythonOrJavaScriptCode);
                if (dtoruntime != null)
                {
                    dto["runtime"] = ExpressionConverter.ConvertO(dtoruntime);
                    dtopropCount++;
                }

                if (dtotimeoutSeconds != null)
                {
                    dto["timeoutSec"] = ExpressionConverter.ConvertO(dtotimeoutSeconds);
                    dtopropCount++;
                }

                if (dtoprintLastExpression != null)
                {
                    dto["printLastExpression"] = ExpressionConverter.ConvertO(dtoprintLastExpression);
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
        [WorkflowExpressionFactory(nameof(__BuildSmartTextSplit))]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit> SmartTextSplit([WorkflowExpression] Func<string> dtoRequestV2130SmartTextSplitinputText, [WorkflowExpression] Func<string> dtoRequestV2130SmartTextSplitsplitPattern = null, [WorkflowExpression] Func<bool> dtoRequestV2130SmartTextSplittrimEnabled = null, [WorkflowExpression] Func<string> dtoRequestV2130SmartTextSplittrimStrings = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit> __BuildSmartTextSplit(WorkflowExpression<string> dtoRequestV2130SmartTextSplitinputText, WorkflowExpression<string> dtoRequestV2130SmartTextSplitsplitPattern = null, WorkflowExpression<bool> dtoRequestV2130SmartTextSplittrimEnabled = null, WorkflowExpression<string> dtoRequestV2130SmartTextSplittrimStrings = null)
        {
            WorkflowExpression.Validate(dtoRequestV2130SmartTextSplitinputText, nameof(dtoRequestV2130SmartTextSplitinputText), required: true);
            WorkflowExpression.Validate(dtoRequestV2130SmartTextSplitsplitPattern, nameof(dtoRequestV2130SmartTextSplitsplitPattern), required: false);
            WorkflowExpression.Validate(dtoRequestV2130SmartTextSplittrimEnabled, nameof(dtoRequestV2130SmartTextSplittrimEnabled), required: false);
            WorkflowExpression.Validate(dtoRequestV2130SmartTextSplittrimStrings, nameof(dtoRequestV2130SmartTextSplittrimStrings), required: false);
            return new DeferredBodyAction<DtoResponseV2130SmartTextSplit>(() =>
            {
                var apiCallPath = "/V2130_SmartTextSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2130SmartTextSplit = new JObject();
                var dtoRequestV2130SmartTextSplitpropCount = 0;
                dtoRequestV2130SmartTextSplitpropCount++;
                dtoRequestV2130SmartTextSplit["inputText"] = ExpressionConverter.ConvertO(dtoRequestV2130SmartTextSplitinputText);
                if (dtoRequestV2130SmartTextSplitsplitPattern != null)
                {
                    dtoRequestV2130SmartTextSplit["splitPattern"] = ExpressionConverter.ConvertO(dtoRequestV2130SmartTextSplitsplitPattern);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (dtoRequestV2130SmartTextSplittrimEnabled != null)
                {
                    dtoRequestV2130SmartTextSplit["trimEnabled"] = ExpressionConverter.ConvertO(dtoRequestV2130SmartTextSplittrimEnabled);
                    dtoRequestV2130SmartTextSplitpropCount++;
                }

                if (dtoRequestV2130SmartTextSplittrimStrings != null)
                {
                    dtoRequestV2130SmartTextSplit["trimStrings"] = ExpressionConverter.ConvertO(dtoRequestV2130SmartTextSplittrimStrings);
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
        [WorkflowExpressionFactory(nameof(__BuildSortCsv))]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv> SortCsv([WorkflowExpression] Func<string> dtoRequestV2061SortCsvcSV, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvautoDetectFieldTypes = null, [WorkflowExpression] Func<int> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvremoveEmptyRows = null, [WorkflowExpression] Func<int> dtoRequestV2061SortCsvskipANumberOfRows = null, [WorkflowExpression] Func<int> dtoRequestV2061SortCsvstopAtASpecificRow = null, [WorkflowExpression] Func<string> dtoRequestV2061SortCsvseparator = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<string> dtoRequestV2061SortCsvsortColumn = null, [WorkflowExpression] Func<string> dtoRequestV2061SortCsvfurtherSortingColumn = null, [WorkflowExpression] Func<bool> dtoRequestV2061SortCsvreverseOrder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv> __BuildSortCsv(WorkflowExpression<string> dtoRequestV2061SortCsvcSV, WorkflowExpression<bool> dtoRequestV2061SortCsvcSVHasHeaders = null, WorkflowExpression<bool> dtoRequestV2061SortCsvautoDetectFieldTypes = null, WorkflowExpression<int> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, WorkflowExpression<bool> dtoRequestV2061SortCsvremoveEmptyRows = null, WorkflowExpression<int> dtoRequestV2061SortCsvskipANumberOfRows = null, WorkflowExpression<int> dtoRequestV2061SortCsvstopAtASpecificRow = null, WorkflowExpression<string> dtoRequestV2061SortCsvseparator = null, WorkflowExpression<bool> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, WorkflowExpression<string> dtoRequestV2061SortCsvsortColumn = null, WorkflowExpression<string> dtoRequestV2061SortCsvfurtherSortingColumn = null, WorkflowExpression<bool> dtoRequestV2061SortCsvreverseOrder = null)
        {
            WorkflowExpression.Validate(dtoRequestV2061SortCsvcSV, nameof(dtoRequestV2061SortCsvcSV), required: true);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvcSVHasHeaders, nameof(dtoRequestV2061SortCsvcSVHasHeaders), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvautoDetectFieldTypes, nameof(dtoRequestV2061SortCsvautoDetectFieldTypes), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection, nameof(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvremoveEmptyRows, nameof(dtoRequestV2061SortCsvremoveEmptyRows), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvskipANumberOfRows, nameof(dtoRequestV2061SortCsvskipANumberOfRows), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvstopAtASpecificRow, nameof(dtoRequestV2061SortCsvstopAtASpecificRow), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvseparator, nameof(dtoRequestV2061SortCsvseparator), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvautoDetectQuoteDelimiter, nameof(dtoRequestV2061SortCsvautoDetectQuoteDelimiter), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvsortColumn, nameof(dtoRequestV2061SortCsvsortColumn), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvfurtherSortingColumn, nameof(dtoRequestV2061SortCsvfurtherSortingColumn), required: false);
            WorkflowExpression.Validate(dtoRequestV2061SortCsvreverseOrder, nameof(dtoRequestV2061SortCsvreverseOrder), required: false);
            return new DeferredBodyAction<DtoResponseV2061SortCsv>(() =>
            {
                var apiCallPath = "/V2061_SortCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2061SortCsv = new JObject();
                var dtoRequestV2061SortCsvpropCount = 0;
                dtoRequestV2061SortCsvpropCount++;
                dtoRequestV2061SortCsv["csv"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvcSV);
                if (dtoRequestV2061SortCsvcSVHasHeaders != null)
                {
                    if (dtoRequestV2061SortCsvcSVHasHeaders != null)
                    {
                        dtoRequestV2061SortCsv["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvcSVHasHeaders);
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
                        dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvautoDetectFieldTypes);
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
                    dtoRequestV2061SortCsv["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvremoveEmptyRows != null)
                {
                    if (dtoRequestV2061SortCsvremoveEmptyRows != null)
                    {
                        dtoRequestV2061SortCsv["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvremoveEmptyRows);
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
                    dtoRequestV2061SortCsv["skip"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvskipANumberOfRows);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvstopAtASpecificRow != null)
                {
                    dtoRequestV2061SortCsv["skipLast"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvstopAtASpecificRow);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvseparator != null)
                {
                    dtoRequestV2061SortCsv["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvseparator);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestV2061SortCsv["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvautoDetectQuoteDelimiter);
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
                    dtoRequestV2061SortCsv["sortColumn"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvsortColumn);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvfurtherSortingColumn != null)
                {
                    dtoRequestV2061SortCsv["secondSortColumn"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvfurtherSortingColumn);
                    dtoRequestV2061SortCsvpropCount++;
                }

                if (dtoRequestV2061SortCsvreverseOrder != null)
                {
                    if (dtoRequestV2061SortCsvreverseOrder != null)
                    {
                        dtoRequestV2061SortCsv["isReverse"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvreverseOrder);
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
        [WorkflowExpressionFactory(nameof(__BuildSortJson))]
        public IBodyWorkflowAction<DtoResponseV2051SortJson> SortJson([WorkflowExpression] Func<string> dtoRequestV2051SortJsonjSON, [WorkflowExpression] Func<string> dtoRequestV2051SortJsonsortProperty = null, [WorkflowExpression] Func<string> dtoRequestV2051SortJsonfurtherSortingProperty = null, [WorkflowExpression] Func<bool> dtoRequestV2051SortJsonreverseOrder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2051SortJson> __BuildSortJson(WorkflowExpression<string> dtoRequestV2051SortJsonjSON, WorkflowExpression<string> dtoRequestV2051SortJsonsortProperty = null, WorkflowExpression<string> dtoRequestV2051SortJsonfurtherSortingProperty = null, WorkflowExpression<bool> dtoRequestV2051SortJsonreverseOrder = null)
        {
            WorkflowExpression.Validate(dtoRequestV2051SortJsonjSON, nameof(dtoRequestV2051SortJsonjSON), required: true);
            WorkflowExpression.Validate(dtoRequestV2051SortJsonsortProperty, nameof(dtoRequestV2051SortJsonsortProperty), required: false);
            WorkflowExpression.Validate(dtoRequestV2051SortJsonfurtherSortingProperty, nameof(dtoRequestV2051SortJsonfurtherSortingProperty), required: false);
            WorkflowExpression.Validate(dtoRequestV2051SortJsonreverseOrder, nameof(dtoRequestV2051SortJsonreverseOrder), required: false);
            return new DeferredBodyAction<DtoResponseV2051SortJson>(() =>
            {
                var apiCallPath = "/V2051_SortJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2051SortJson = new JObject();
                var dtoRequestV2051SortJsonpropCount = 0;
                dtoRequestV2051SortJsonpropCount++;
                dtoRequestV2051SortJson["json"] = ExpressionConverter.ConvertO(dtoRequestV2051SortJsonjSON);
                if (dtoRequestV2051SortJsonsortProperty != null)
                {
                    dtoRequestV2051SortJson["sortProperty"] = ExpressionConverter.ConvertO(dtoRequestV2051SortJsonsortProperty);
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (dtoRequestV2051SortJsonfurtherSortingProperty != null)
                {
                    dtoRequestV2051SortJson["secondSortProperty"] = ExpressionConverter.ConvertO(dtoRequestV2051SortJsonfurtherSortingProperty);
                    dtoRequestV2051SortJsonpropCount++;
                }

                if (dtoRequestV2051SortJsonreverseOrder != null)
                {
                    if (dtoRequestV2051SortJsonreverseOrder != null)
                    {
                        dtoRequestV2051SortJson["isReverse"] = ExpressionConverter.ConvertO(dtoRequestV2051SortJsonreverseOrder);
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
        [WorkflowExpressionFactory(nameof(__BuildTranslate))]
        public IBodyWorkflowAction<DtoResponseV2041Translate> Translate([WorkflowExpression] Func<string> dtoRequestV2041Translatetext, [WorkflowExpression] Func<string> dtoRequestV2041Translateto, [WorkflowExpression] Func<string> dtoRequestV2041Translatefrom = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2041Translate> __BuildTranslate(WorkflowExpression<string> dtoRequestV2041Translatetext, WorkflowExpression<string> dtoRequestV2041Translateto, WorkflowExpression<string> dtoRequestV2041Translatefrom = null)
        {
            WorkflowExpression.Validate(dtoRequestV2041Translatetext, nameof(dtoRequestV2041Translatetext), required: true);
            WorkflowExpression.Validate(dtoRequestV2041Translateto, nameof(dtoRequestV2041Translateto), required: true);
            WorkflowExpression.Validate(dtoRequestV2041Translatefrom, nameof(dtoRequestV2041Translatefrom), required: false);
            return new DeferredBodyAction<DtoResponseV2041Translate>(() =>
            {
                var apiCallPath = "/V2041_Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2041Translate = new JObject();
                var dtoRequestV2041TranslatepropCount = 0;
                dtoRequestV2041TranslatepropCount++;
                dtoRequestV2041Translate["text"] = ExpressionConverter.ConvertO(dtoRequestV2041Translatetext);
                if (dtoRequestV2041Translatefrom != null)
                {
                    dtoRequestV2041Translate["from"] = ExpressionConverter.ConvertO(dtoRequestV2041Translatefrom);
                    dtoRequestV2041TranslatepropCount++;
                }

                dtoRequestV2041TranslatepropCount++;
                dtoRequestV2041Translate["to"] = ExpressionConverter.ConvertO(dtoRequestV2041Translateto);
                if (dtoRequestV2041TranslatepropCount > 0)
                {
                    callPayload.Body = dtoRequestV2041Translate;
                }

                return new ApiConnectionAction<DtoResponseV2041Translate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildUnProtectPdf))]
        public IBodyWorkflowAction<DtoResponseV4051UnProtectPdf> UnProtectPdf([WorkflowExpression] Func<string> dtoRequestV4051UnProtectPdffile, [WorkflowExpression] Func<string> dtoRequestV4051UnProtectPdfownerPassword = null, [WorkflowExpression] Func<bool> dtoRequestV4051UnProtectPdfremovePermissions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV4051UnProtectPdf> __BuildUnProtectPdf(WorkflowExpression<string> dtoRequestV4051UnProtectPdffile, WorkflowExpression<string> dtoRequestV4051UnProtectPdfownerPassword = null, WorkflowExpression<bool> dtoRequestV4051UnProtectPdfremovePermissions = null)
        {
            WorkflowExpression.Validate(dtoRequestV4051UnProtectPdffile, nameof(dtoRequestV4051UnProtectPdffile), required: true);
            WorkflowExpression.Validate(dtoRequestV4051UnProtectPdfownerPassword, nameof(dtoRequestV4051UnProtectPdfownerPassword), required: false);
            WorkflowExpression.Validate(dtoRequestV4051UnProtectPdfremovePermissions, nameof(dtoRequestV4051UnProtectPdfremovePermissions), required: false);
            return new DeferredBodyAction<DtoResponseV4051UnProtectPdf>(() =>
            {
                var apiCallPath = "/V4051_UnProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV4051UnProtectPdf = new JObject();
                var dtoRequestV4051UnProtectPdfpropCount = 0;
                dtoRequestV4051UnProtectPdfpropCount++;
                dtoRequestV4051UnProtectPdf["file"] = ExpressionConverter.ConvertO(dtoRequestV4051UnProtectPdffile);
                if (dtoRequestV4051UnProtectPdfownerPassword != null)
                {
                    dtoRequestV4051UnProtectPdf["ownerPassword"] = ExpressionConverter.ConvertO(dtoRequestV4051UnProtectPdfownerPassword);
                    dtoRequestV4051UnProtectPdfpropCount++;
                }

                if (dtoRequestV4051UnProtectPdfremovePermissions != null)
                {
                    dtoRequestV4051UnProtectPdf["removePermissions"] = ExpressionConverter.ConvertO(dtoRequestV4051UnProtectPdfremovePermissions);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateMultipleWordContentControls))]
        public IBodyWorkflowAction<DtoResponseFile> UpdateMultipleWordContentControls([WorkflowExpression] Func<string> dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, [WorkflowExpression] Func<ContentControl[]> dtoRequestV5150UpdateMultipleWordContentControlscontentControl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildUpdateMultipleWordContentControls(WorkflowExpression<string> dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, WorkflowExpression<ContentControl[]> dtoRequestV5150UpdateMultipleWordContentControlscontentControl)
        {
            WorkflowExpression.Validate(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, nameof(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV5150UpdateMultipleWordContentControlscontentControl, nameof(dtoRequestV5150UpdateMultipleWordContentControlscontentControl), required: true);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V5150_UpdateMultipleWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5150UpdateMultipleWordContentControls = new JObject();
                var dtoRequestV5150UpdateMultipleWordContentControlspropCount = 0;
                dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
                dtoRequestV5150UpdateMultipleWordContentControls["file"] = ExpressionConverter.ConvertO(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent);
                dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
                dtoRequestV5150UpdateMultipleWordContentControls["contentControls"] = ExpressionConverter.ConvertO(dtoRequestV5150UpdateMultipleWordContentControlscontentControl);
                if (dtoRequestV5150UpdateMultipleWordContentControlspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5150UpdateMultipleWordContentControls;
                }

                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWordContentControl))]
        public IBodyWorkflowAction<DtoResponseFile> UpdateWordContentControl([WorkflowExpression] Func<string> dtoRequestV5140UpdateWordContentControlexistingFileContent, [WorkflowExpression] Func<string> dtoRequestV5140UpdateWordContentControlname, [WorkflowExpression] Func<string> dtoRequestV5140UpdateWordContentControlvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseFile> __BuildUpdateWordContentControl(WorkflowExpression<string> dtoRequestV5140UpdateWordContentControlexistingFileContent, WorkflowExpression<string> dtoRequestV5140UpdateWordContentControlname, WorkflowExpression<string> dtoRequestV5140UpdateWordContentControlvalue = null)
        {
            WorkflowExpression.Validate(dtoRequestV5140UpdateWordContentControlexistingFileContent, nameof(dtoRequestV5140UpdateWordContentControlexistingFileContent), required: true);
            WorkflowExpression.Validate(dtoRequestV5140UpdateWordContentControlname, nameof(dtoRequestV5140UpdateWordContentControlname), required: true);
            WorkflowExpression.Validate(dtoRequestV5140UpdateWordContentControlvalue, nameof(dtoRequestV5140UpdateWordContentControlvalue), required: false);
            return new DeferredBodyAction<DtoResponseFile>(() =>
            {
                var apiCallPath = "/V5140_UpdateWordContentControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5140UpdateWordContentControl = new JObject();
                var dtoRequestV5140UpdateWordContentControlpropCount = 0;
                dtoRequestV5140UpdateWordContentControlpropCount++;
                dtoRequestV5140UpdateWordContentControl["file"] = ExpressionConverter.ConvertO(dtoRequestV5140UpdateWordContentControlexistingFileContent);
                dtoRequestV5140UpdateWordContentControlpropCount++;
                dtoRequestV5140UpdateWordContentControl["name"] = ExpressionConverter.ConvertO(dtoRequestV5140UpdateWordContentControlname);
                if (dtoRequestV5140UpdateWordContentControlvalue != null)
                {
                    dtoRequestV5140UpdateWordContentControl["value"] = ExpressionConverter.ConvertO(dtoRequestV5140UpdateWordContentControlvalue);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateWordTableOfContents))]
        public IBodyWorkflowAction<DtoResponseV5130UpdateWordTableOfContents> UpdateWordTableOfContents([WorkflowExpression] Func<string> dtoRequestV5130UpdateWordTableOfContentsexistingFileContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV5130UpdateWordTableOfContents> __BuildUpdateWordTableOfContents(WorkflowExpression<string> dtoRequestV5130UpdateWordTableOfContentsexistingFileContent)
        {
            WorkflowExpression.Validate(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent, nameof(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent), required: true);
            return new DeferredBodyAction<DtoResponseV5130UpdateWordTableOfContents>(() =>
            {
                var apiCallPath = "/V5130_UpdateWordTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV5130UpdateWordTableOfContents = new JObject();
                var dtoRequestV5130UpdateWordTableOfContentspropCount = 0;
                dtoRequestV5130UpdateWordTableOfContentspropCount++;
                dtoRequestV5130UpdateWordTableOfContents["file"] = ExpressionConverter.ConvertO(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent);
                if (dtoRequestV5130UpdateWordTableOfContentspropCount > 0)
                {
                    callPayload.Body = dtoRequestV5130UpdateWordTableOfContents;
                }

                return new ApiConnectionAction<DtoResponseV5130UpdateWordTableOfContents>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        [WorkflowExpressionFactory(nameof(__BuildUrlToFile))]
        public IBodyWorkflowAction<DtoResponseV2031UrlToFile> UrlToFile([WorkflowExpression] Func<string> dtoRequestV2031UrlToFileuRL)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DtoResponseV2031UrlToFile> __BuildUrlToFile(WorkflowExpression<string> dtoRequestV2031UrlToFileuRL)
        {
            WorkflowExpression.Validate(dtoRequestV2031UrlToFileuRL, nameof(dtoRequestV2031UrlToFileuRL), required: true);
            return new DeferredBodyAction<DtoResponseV2031UrlToFile>(() =>
            {
                var apiCallPath = "/V2031_UrlToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestV2031UrlToFile = new JObject();
                var dtoRequestV2031UrlToFilepropCount = 0;
                dtoRequestV2031UrlToFilepropCount++;
                dtoRequestV2031UrlToFile["url"] = ExpressionConverter.ConvertO(dtoRequestV2031UrlToFileuRL);
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