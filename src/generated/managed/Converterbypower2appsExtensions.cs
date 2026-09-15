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
        public IBodyWorkflowAction<DtoResponseV5101AddHtmlToWord> AddHtmlToWord(Expression<Func<string>> dtoRequestV5101AddHtmlToWordhTML, Expression<Func<string>> dtoRequestV5101AddHtmlToWordexistingFileContent = null)
        {
            var apiCallPath = "/V5101_AddHtmlToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5101AddHtmlToWord = new JObject();
            var dtoRequestV5101AddHtmlToWordpropCount = 0;
            if (dtoRequestV5101AddHtmlToWordexistingFileContent != null)
            {
                dtoRequestV5101AddHtmlToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5101AddHtmlToWordexistingFileContent);
                dtoRequestV5101AddHtmlToWordpropCount++;
            }

            dtoRequestV5101AddHtmlToWordpropCount++;
            dtoRequestV5101AddHtmlToWord["html"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5101AddHtmlToWordhTML);
            if (dtoRequestV5101AddHtmlToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5101AddHtmlToWord;
            }

            return new ApiConnectionAction<DtoResponseV5101AddHtmlToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5031AddImageToWord> AddImageToWord(Expression<Func<string>> dtoRequestV5031AddImageToWordimage, Expression<Func<string>> dtoRequestV5031AddImageToWordexistingFileContent = null, Expression<Func<string>> dtoRequestV5031AddImageToWordcaptionText = null, Expression<Func<int>> dtoRequestV5031AddImageToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5031AddImageToWordmaximumImageHeight = null)
        {
            var apiCallPath = "/V5031_AddImageToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5031AddImageToWord = new JObject();
            var dtoRequestV5031AddImageToWordpropCount = 0;
            if (dtoRequestV5031AddImageToWordexistingFileContent != null)
            {
                dtoRequestV5031AddImageToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordexistingFileContent);
                dtoRequestV5031AddImageToWordpropCount++;
            }

            dtoRequestV5031AddImageToWordpropCount++;
            dtoRequestV5031AddImageToWord["image"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordimage);
            if (dtoRequestV5031AddImageToWordcaptionText != null)
            {
                dtoRequestV5031AddImageToWord["imageText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordcaptionText);
                dtoRequestV5031AddImageToWordpropCount++;
            }

            if (dtoRequestV5031AddImageToWordmaximumImageWidth != null)
            {
                dtoRequestV5031AddImageToWord["maxWidth"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordmaximumImageWidth);
                dtoRequestV5031AddImageToWordpropCount++;
            }

            if (dtoRequestV5031AddImageToWordmaximumImageHeight != null)
            {
                dtoRequestV5031AddImageToWord["maxHeight"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5031AddImageToWordmaximumImageHeight);
                dtoRequestV5031AddImageToWordpropCount++;
            }

            if (dtoRequestV5031AddImageToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5031AddImageToWord;
            }

            return new ApiConnectionAction<DtoResponseV5031AddImageToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5042AddImageWithinTableToWord> AddImageWithinTableToWord(Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWordimage, Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWordexistingFileContent = null, Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWorddescriptionText = null, Expression<Func<int>> dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = null)
        {
            var apiCallPath = "/V5042_AddImageWithinTableToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5042AddImageWithinTableToWord = new JObject();
            var dtoRequestV5042AddImageWithinTableToWordpropCount = 0;
            if (dtoRequestV5042AddImageWithinTableToWordexistingFileContent != null)
            {
                dtoRequestV5042AddImageWithinTableToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordexistingFileContent);
                dtoRequestV5042AddImageWithinTableToWordpropCount++;
            }

            dtoRequestV5042AddImageWithinTableToWordpropCount++;
            dtoRequestV5042AddImageWithinTableToWord["image"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordimage);
            if (dtoRequestV5042AddImageWithinTableToWorddescriptionText != null)
            {
                dtoRequestV5042AddImageWithinTableToWord["imageText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWorddescriptionText);
                dtoRequestV5042AddImageWithinTableToWordpropCount++;
            }

            if (dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth != null)
            {
                dtoRequestV5042AddImageWithinTableToWord["maxWidth"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth);
                dtoRequestV5042AddImageWithinTableToWordpropCount++;
            }

            if (dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight != null)
            {
                dtoRequestV5042AddImageWithinTableToWord["maxHeight"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight);
                dtoRequestV5042AddImageWithinTableToWordpropCount++;
            }

            if (dtoRequestV5042AddImageWithinTableToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5042AddImageWithinTableToWord;
            }

            return new ApiConnectionAction<DtoResponseV5042AddImageWithinTableToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5052AddTableToWord> AddTableToWord(Expression<Func<string>> dtoRequestV5052AddTableToWordtableData, Expression<Func<string>> dtoRequestV5052AddTableToWordexistingFileContent = null, Expression<Func<bool>> dtoRequestV5052AddTableToWordshowHeaders = null, Expression<Func<string>> dtoRequestV5052AddTableToWordtableStyle = null, Expression<Func<string>> dtoRequestV5052AddTableToWordtableCaption = null)
        {
            var apiCallPath = "/V5052_AddTableToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5052AddTableToWord = new JObject();
            var dtoRequestV5052AddTableToWordpropCount = 0;
            if (dtoRequestV5052AddTableToWordexistingFileContent != null)
            {
                dtoRequestV5052AddTableToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordexistingFileContent);
                dtoRequestV5052AddTableToWordpropCount++;
            }

            dtoRequestV5052AddTableToWordpropCount++;
            dtoRequestV5052AddTableToWord["table"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordtableData);
            if (dtoRequestV5052AddTableToWordshowHeaders != null)
            {
                if (dtoRequestV5052AddTableToWordshowHeaders != null)
                {
                    dtoRequestV5052AddTableToWord["hasHeader"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordshowHeaders);
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
                    dtoRequestV5052AddTableToWord["tableStyle"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordtableStyle);
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
                dtoRequestV5052AddTableToWord["tableText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5052AddTableToWordtableCaption);
                dtoRequestV5052AddTableToWordpropCount++;
            }

            if (dtoRequestV5052AddTableToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5052AddTableToWord;
            }

            return new ApiConnectionAction<DtoResponseV5052AddTableToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5061AddTextToWord> AddTextToWord(Expression<Func<string>> dtoRequestAddTextToWordDatatype, Expression<Func<string>> dtoRequestAddTextToWordDatatext, Expression<Func<string>> dtoRequestAddTextToWordDataexistingFileContent = null)
        {
            var apiCallPath = "/V5061_AddTextToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestAddTextToWordData = new JObject();
            var dtoRequestAddTextToWordDatapropCount = 0;
            if (dtoRequestAddTextToWordDataexistingFileContent != null)
            {
                dtoRequestAddTextToWordData["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestAddTextToWordDataexistingFileContent);
                dtoRequestAddTextToWordDatapropCount++;
            }

            dtoRequestAddTextToWordDatapropCount++;
            dtoRequestAddTextToWordData["sectionType"] = CSharpExpressionConverter.ConvertToken(dtoRequestAddTextToWordDatatype);
            dtoRequestAddTextToWordDatapropCount++;
            dtoRequestAddTextToWordData["text"] = CSharpExpressionConverter.ConvertToken(dtoRequestAddTextToWordDatatext);
            if (dtoRequestAddTextToWordDatapropCount > 0)
            {
                callPayload.Body = dtoRequestAddTextToWordData;
            }

            return new ApiConnectionAction<DtoResponseV5061AddTextToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs> CombineCsvs(Expression<Func<string>> dtoRequestV2081CombineCsvsmainCSV, Expression<Func<string>> dtoRequestV2081CombineCsvscombineColumnName, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSV, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSVColumn = null)
        {
            var apiCallPath = "/V2081_CombineCsvs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2081CombineCsvs = new JObject();
            var dtoRequestV2081CombineCsvspropCount = 0;
            dtoRequestV2081CombineCsvspropCount++;
            dtoRequestV2081CombineCsvs["mainCsv"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvsmainCSV);
            dtoRequestV2081CombineCsvspropCount++;
            dtoRequestV2081CombineCsvs["mainCsvColumn"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvscombineColumnName);
            dtoRequestV2081CombineCsvspropCount++;
            dtoRequestV2081CombineCsvs["secondCsv"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvssecondCSV);
            if (dtoRequestV2081CombineCsvssecondCSVColumn != null)
            {
                dtoRequestV2081CombineCsvs["secondCsvColumn"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2081CombineCsvssecondCSVColumn);
                dtoRequestV2081CombineCsvspropCount++;
            }

            if (dtoRequestV2081CombineCsvspropCount > 0)
            {
                callPayload.Body = dtoRequestV2081CombineCsvs;
            }

            return new ApiConnectionAction<DtoResponseV2081CombineCsvs>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays> CombineJsonArrays(Expression<Func<string>> dtoRequestV2091CombineJsonArraysmainJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayscombinePropertyName, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
        {
            var apiCallPath = "/V2091_CombineJsonArrays";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2091CombineJsonArrays = new JObject();
            var dtoRequestV2091CombineJsonArrayspropCount = 0;
            dtoRequestV2091CombineJsonArrayspropCount++;
            dtoRequestV2091CombineJsonArrays["mainJson"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArraysmainJSON);
            dtoRequestV2091CombineJsonArrayspropCount++;
            dtoRequestV2091CombineJsonArrays["mainJsonProperty"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArrayscombinePropertyName);
            dtoRequestV2091CombineJsonArrayspropCount++;
            dtoRequestV2091CombineJsonArrays["secondJson"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArrayssecondJSON);
            if (dtoRequestV2091CombineJsonArrayssecondJSONProperty != null)
            {
                dtoRequestV2091CombineJsonArrays["secondJsonProperty"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2091CombineJsonArrayssecondJSONProperty);
                dtoRequestV2091CombineJsonArrayspropCount++;
            }

            if (dtoRequestV2091CombineJsonArrayspropCount > 0)
            {
                callPayload.Body = dtoRequestV2091CombineJsonArrays;
            }

            return new ApiConnectionAction<DtoResponseV2091CombineJsonArrays>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3041CompressImage> CompressImage(Expression<Func<string>> dtoRequestCompressImageimageFile, Expression<Func<int>> dtoRequestCompressImageimageQuality = null)
        {
            var apiCallPath = "/V3041_CompressImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestCompressImage = new JObject();
            var dtoRequestCompressImagepropCount = 0;
            dtoRequestCompressImagepropCount++;
            dtoRequestCompressImage["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestCompressImageimageFile);
            if (dtoRequestCompressImageimageQuality != null)
            {
                dtoRequestCompressImage["quality"] = CSharpExpressionConverter.ConvertToken(dtoRequestCompressImageimageQuality);
                dtoRequestCompressImagepropCount++;
            }

            if (dtoRequestCompressImagepropCount > 0)
            {
                callPayload.Body = dtoRequestCompressImage;
            }

            return new ApiConnectionAction<DtoResponseV3041CompressImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4080CompressPdf> CompressPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<bool>> dtoRequestcompressImages = null, Expression<Func<int>> dtoRequestimageQuality = null, Expression<Func<bool>> dtoRequestoptimizeFonts = null, Expression<Func<bool>> dtoRequestoptimizePageContents = null, Expression<Func<bool>> dtoRequestremoveMetadata = null)
        {
            var apiCallPath = "/V4080_CompressPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequest = new JObject();
            var dtoRequestpropCount = 0;
            dtoRequestpropCount++;
            dtoRequest["pdf"] = CSharpExpressionConverter.ConvertToken(dtoRequestpDF);
            if (dtoRequestcompressImages != null)
            {
                dtoRequest["compressImages"] = CSharpExpressionConverter.ConvertToken(dtoRequestcompressImages);
                dtoRequestpropCount++;
            }

            if (dtoRequestimageQuality != null)
            {
                dtoRequest["imageQuality"] = CSharpExpressionConverter.ConvertToken(dtoRequestimageQuality);
                dtoRequestpropCount++;
            }

            if (dtoRequestoptimizeFonts != null)
            {
                dtoRequest["optimizeFont"] = CSharpExpressionConverter.ConvertToken(dtoRequestoptimizeFonts);
                dtoRequestpropCount++;
            }

            if (dtoRequestoptimizePageContents != null)
            {
                dtoRequest["optimizePageContents"] = CSharpExpressionConverter.ConvertToken(dtoRequestoptimizePageContents);
                dtoRequestpropCount++;
            }

            if (dtoRequestremoveMetadata != null)
            {
                dtoRequest["removeMetadata"] = CSharpExpressionConverter.ConvertToken(dtoRequestremoveMetadata);
                dtoRequestpropCount++;
            }

            if (dtoRequestpropCount > 0)
            {
                callPayload.Body = dtoRequest;
            }

            return new ApiConnectionAction<DtoResponseV4080CompressPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor> ConvertColor(Expression<Func<string>> dtoRequestV2071ConvertColorcolor)
        {
            var apiCallPath = "/V2071_ConvertColor";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2071ConvertColor = new JObject();
            var dtoRequestV2071ConvertColorpropCount = 0;
            dtoRequestV2071ConvertColorpropCount++;
            dtoRequestV2071ConvertColor["color"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2071ConvertColorcolor);
            if (dtoRequestV2071ConvertColorpropCount > 0)
            {
                callPayload.Body = dtoRequestV2071ConvertColor;
            }

            return new ApiConnectionAction<DtoResponseV2071ConvertColor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1033ConvertCsvToExcel> ConvertCsvToExcel(Expression<Func<string>> dtoRequestV1033ConvertCsvToExcelcSV, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1033ConvertCsvToExcelseparator = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText = null, Expression<Func<int>> dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            var apiCallPath = "/V1033_ConvertCsvToExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1033ConvertCsvToExcel = new JObject();
            var dtoRequestV1033ConvertCsvToExcelpropCount = 0;
            dtoRequestV1033ConvertCsvToExcelpropCount++;
            dtoRequestV1033ConvertCsvToExcel["csv"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelcSV);
            if (dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
            {
                if (dtoRequestV1033ConvertCsvToExcelcSVHasHeaders != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["dataIncludesHeader"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelcSVHasHeaders);
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
                    dtoRequestV1033ConvertCsvToExcel["autoDiscoverFieldTypes"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelautoDetectFieldTypes);
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
                dtoRequestV1033ConvertCsvToExcel["maxScanRows"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelnumberOfRowsForFieldTypeDetection);
                dtoRequestV1033ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
            {
                if (dtoRequestV1033ConvertCsvToExcelremoveEmptyRows != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["ignoreEmptyLine"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelremoveEmptyRows);
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
                dtoRequestV1033ConvertCsvToExcel["skip"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelskipANumberOfRows);
                dtoRequestV1033ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow != null)
            {
                dtoRequestV1033ConvertCsvToExcel["skipLast"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelstopAtASpecificRow);
                dtoRequestV1033ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1033ConvertCsvToExcelseparator != null)
            {
                dtoRequestV1033ConvertCsvToExcel["delimiter"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelseparator);
                dtoRequestV1033ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    dtoRequestV1033ConvertCsvToExcel["mayHaveQuotedFields"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelautoDetectQuoteDelimiter);
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
                    dtoRequestV1033ConvertCsvToExcel["adjustColumnToContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExceladjustExcelColumnToContent);
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
                    dtoRequestV1033ConvertCsvToExcel["wrapColumnText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelwrapExcelColumnText);
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
                dtoRequestV1033ConvertCsvToExcel["maxColumnWidth"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1033ConvertCsvToExcelmaxExcelColumnWidth);
                dtoRequestV1033ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1033ConvertCsvToExcelpropCount > 0)
            {
                callPayload.Body = dtoRequestV1033ConvertCsvToExcel;
            }

            return new ApiConnectionAction<DtoResponseV1033ConvertCsvToExcel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertCsvToHtmlTable(Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTablecSV, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
        {
            var apiCallPath = "/V7061_ConvertCsvToHtmlTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7061ConvertCsvToHtmlTable = new JObject();
            var dtoRequestV7061ConvertCsvToHtmlTablepropCount = 0;
            dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            dtoRequestV7061ConvertCsvToHtmlTable["csv"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablecSV);
            if (dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
            {
                if (dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders);
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
                    dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes);
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
                dtoRequestV7061ConvertCsvToHtmlTable["maxScanRows"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
            {
                if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows);
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
                dtoRequestV7061ConvertCsvToHtmlTable["skip"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow != null)
            {
                dtoRequestV7061ConvertCsvToHtmlTable["skipLast"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTableseparator != null)
            {
                dtoRequestV7061ConvertCsvToHtmlTable["delimiter"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableseparator);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter != null)
                {
                    dtoRequestV7061ConvertCsvToHtmlTable["mayHaveQuotedFields"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson> ConvertCsvToJson(Expression<Func<string>> dtoRequestV1022ConvertCsvToJsoncSV, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1022ConvertCsvToJsonseparator = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
        {
            var apiCallPath = "/V1022_ConvertCsvToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1022ConvertCsvToJson = new JObject();
            var dtoRequestV1022ConvertCsvToJsonpropCount = 0;
            dtoRequestV1022ConvertCsvToJsonpropCount++;
            dtoRequestV1022ConvertCsvToJson["csv"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsoncSV);
            if (dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
            {
                if (dtoRequestV1022ConvertCsvToJsoncSVHasHeaders != null)
                {
                    dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders);
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
                    dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes);
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
                dtoRequestV1022ConvertCsvToJson["maxScanRows"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
            {
                if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
                {
                    dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows);
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
                dtoRequestV1022ConvertCsvToJson["skip"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonskipANumberOfRows);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow != null)
            {
                dtoRequestV1022ConvertCsvToJson["skipLast"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonseparator != null)
            {
                dtoRequestV1022ConvertCsvToJson["delimiter"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonseparator);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    dtoRequestV1022ConvertCsvToJson["mayHaveQuotedFields"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson> ConvertExcelToJson(Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonexcelFile, Expression<Func<bool>> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonstartCell = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonsheetName = null)
        {
            var apiCallPath = "/V1100_ConvertExcelToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1100ConvertExcelToJson = new JObject();
            var dtoRequestV1100ConvertExcelToJsonpropCount = 0;
            dtoRequestV1100ConvertExcelToJsonpropCount++;
            dtoRequestV1100ConvertExcelToJson["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonexcelFile);
            if (dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
            {
                if (dtoRequestV1100ConvertExcelToJsonexcelHasHeaders != null)
                {
                    dtoRequestV1100ConvertExcelToJson["hasHeaders"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders);
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
                dtoRequestV1100ConvertExcelToJson["startCell"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonstartCell);
                dtoRequestV1100ConvertExcelToJsonpropCount++;
            }

            if (dtoRequestV1100ConvertExcelToJsonsheetName != null)
            {
                dtoRequestV1100ConvertExcelToJson["sheetName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1100ConvertExcelToJsonsheetName);
                dtoRequestV1100ConvertExcelToJsonpropCount++;
            }

            if (dtoRequestV1100ConvertExcelToJsonpropCount > 0)
            {
                callPayload.Body = dtoRequestV1100ConvertExcelToJson;
            }

            return new ApiConnectionAction<DtoResponseV1100ConvertExcelToJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4013ConvertFileToPdf> ConvertFileToPdf(Expression<Func<string>> dtoRequestV4013FileToPdffile, Expression<Func<string>> dtoRequestV4013FileToPdforiginFileName = null, Expression<Func<string>> dtoRequestV4013FileToPdforiginFileExtension = null, Expression<Func<int>> dtoRequestV4013FileToPdfconformanceLevel = null)
        {
            var apiCallPath = "/V4013_ConvertFileToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4013FileToPdf = new JObject();
            var dtoRequestV4013FileToPdfpropCount = 0;
            dtoRequestV4013FileToPdfpropCount++;
            dtoRequestV4013FileToPdf["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4013FileToPdffile);
            if (dtoRequestV4013FileToPdforiginFileName != null)
            {
                dtoRequestV4013FileToPdf["fileName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4013FileToPdforiginFileName);
                dtoRequestV4013FileToPdfpropCount++;
            }

            if (dtoRequestV4013FileToPdforiginFileExtension != null)
            {
                dtoRequestV4013FileToPdf["fileExtension"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4013FileToPdforiginFileExtension);
                dtoRequestV4013FileToPdfpropCount++;
            }

            if (dtoRequestV4013FileToPdfconformanceLevel != null)
            {
                dtoRequestV4013FileToPdf["conformanceLevel"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4013FileToPdfconformanceLevel);
                dtoRequestV4013FileToPdfpropCount++;
            }

            if (dtoRequestV4013FileToPdfpropCount > 0)
            {
                callPayload.Body = dtoRequestV4013FileToPdf;
            }

            return new ApiConnectionAction<DtoResponseV4013ConvertFileToPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv> ConvertHtmlTableToCsv(Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
        {
            var apiCallPath = "/V7070_ConvertHtmlTableToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7070ConvertHtmlTableToCsv = new JObject();
            var dtoRequestV7070ConvertHtmlTableToCsvpropCount = 0;
            dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
            dtoRequestV7070ConvertHtmlTableToCsv["htmlTable"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7070ConvertHtmlTableToCsvhTMLTable);
            if (dtoRequestV7070ConvertHtmlTableToCsvseparator != null)
            {
                dtoRequestV7070ConvertHtmlTableToCsv["delimiter"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7070ConvertHtmlTableToCsvseparator);
                dtoRequestV7070ConvertHtmlTableToCsvpropCount++;
            }

            if (dtoRequestV7070ConvertHtmlTableToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestV7070ConvertHtmlTableToCsv;
            }

            return new ApiConnectionAction<DtoResponseV7070ConvertHtmlTableToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7080ConvertHtmlTableToExcel> ConvertHtmlTableToExcel(Expression<Func<string>> dtoRequestV7080ConvertHtmlTableToExcelhTMLTable)
        {
            var apiCallPath = "/V7080_ConvertHtmlTableToExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7080ConvertHtmlTableToExcel = new JObject();
            var dtoRequestV7080ConvertHtmlTableToExcelpropCount = 0;
            dtoRequestV7080ConvertHtmlTableToExcelpropCount++;
            dtoRequestV7080ConvertHtmlTableToExcel["htmlTable"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7080ConvertHtmlTableToExcelhTMLTable);
            if (dtoRequestV7080ConvertHtmlTableToExcelpropCount > 0)
            {
                callPayload.Body = dtoRequestV7080ConvertHtmlTableToExcel;
            }

            return new ApiConnectionAction<DtoResponseV7080ConvertHtmlTableToExcel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7012ConvertHtmlTableToJson> ConvertHtmlTableToJson(Expression<Func<string>> dtoRequestHtmlToTableDatahTMLTable)
        {
            var apiCallPath = "/V7012_ConvertHtmlTableToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestHtmlToTableData = new JObject();
            var dtoRequestHtmlToTableDatapropCount = 0;
            dtoRequestHtmlToTableDatapropCount++;
            dtoRequestHtmlToTableData["htmlTable"] = CSharpExpressionConverter.ConvertToken(dtoRequestHtmlToTableDatahTMLTable);
            if (dtoRequestHtmlToTableDatapropCount > 0)
            {
                callPayload.Body = dtoRequestHtmlToTableData;
            }

            return new ApiConnectionAction<DtoResponseV7012ConvertHtmlTableToJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7031ConvertHtmlToImage> ConvertHtmlToImage(Expression<Func<string>> dtoRequestV7031ConvertHtmlToImagehTML, Expression<Func<int>> dtoRequestV7031ConvertHtmlToImagewidth = null, Expression<Func<int>> dtoRequestV7031ConvertHtmlToImageheight = null)
        {
            var apiCallPath = "/V7031_ConvertHtmlToImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7031ConvertHtmlToImage = new JObject();
            var dtoRequestV7031ConvertHtmlToImagepropCount = 0;
            dtoRequestV7031ConvertHtmlToImagepropCount++;
            dtoRequestV7031ConvertHtmlToImage["html"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7031ConvertHtmlToImagehTML);
            if (dtoRequestV7031ConvertHtmlToImagewidth != null)
            {
                dtoRequestV7031ConvertHtmlToImage["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7031ConvertHtmlToImagewidth);
                dtoRequestV7031ConvertHtmlToImagepropCount++;
            }

            if (dtoRequestV7031ConvertHtmlToImageheight != null)
            {
                dtoRequestV7031ConvertHtmlToImage["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7031ConvertHtmlToImageheight);
                dtoRequestV7031ConvertHtmlToImagepropCount++;
            }

            if (dtoRequestV7031ConvertHtmlToImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV7031ConvertHtmlToImage;
            }

            return new ApiConnectionAction<DtoResponseV7031ConvertHtmlToImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7022ConvertHtmlToPdf> ConvertHtmlToPdf(Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfhTML, Expression<Func<bool>> dtoRequestV7022ConvertHtmlToPdflandscapeFormat = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdffooterOptions = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfheaderOptions = null, Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfpaperFormat = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdftopMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfbottomMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfleftMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfrightMargin = null, Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfpageRanges = null, Expression<Func<double>> dtoRequestV7022ConvertHtmlToPdfscale = null)
        {
            var apiCallPath = "/V7022_ConvertHtmlToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7022ConvertHtmlToPdf = new JObject();
            var dtoRequestV7022ConvertHtmlToPdfpropCount = 0;
            dtoRequestV7022ConvertHtmlToPdfpropCount++;
            dtoRequestV7022ConvertHtmlToPdf["html"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfhTML);
            if (dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
            {
                if (dtoRequestV7022ConvertHtmlToPdflandscapeFormat != null)
                {
                    dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdflandscapeFormat);
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
                dtoRequestV7022ConvertHtmlToPdf["imageQuality"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdffooterOptions != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["footerOption"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdffooterOptions);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfheaderOptions != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["headerOption"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfheaderOptions);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfpaperFormat != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["paperFormat"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfpaperFormat);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdftopMargin != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["marginTop"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdftopMargin);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfbottomMargin != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["marginBottom"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfbottomMargin);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfleftMargin != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["marginLeft"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfleftMargin);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfrightMargin != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["marginRight"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfrightMargin);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfpageRanges != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["pageRanges"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfpageRanges);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfscale != null)
            {
                dtoRequestV7022ConvertHtmlToPdf["scale"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7022ConvertHtmlToPdfscale);
                dtoRequestV7022ConvertHtmlToPdfpropCount++;
            }

            if (dtoRequestV7022ConvertHtmlToPdfpropCount > 0)
            {
                callPayload.Body = dtoRequestV7022ConvertHtmlToPdf;
            }

            return new ApiConnectionAction<DtoResponseV7022ConvertHtmlToPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> ConvertHtmlToWord(Expression<Func<string>> dtoRequestV7041ConvertHtmlToWordhTML)
        {
            var apiCallPath = "/V7041_ConvertHtmlToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7041ConvertHtmlToWord = new JObject();
            var dtoRequestV7041ConvertHtmlToWordpropCount = 0;
            dtoRequestV7041ConvertHtmlToWordpropCount++;
            dtoRequestV7041ConvertHtmlToWord["html"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7041ConvertHtmlToWordhTML);
            if (dtoRequestV7041ConvertHtmlToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV7041ConvertHtmlToWord;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> ConvertImage(Expression<Func<string>> dtoRequestV3012ConvertImageimageFile, Expression<Func<string>> dtoRequestV3012ConvertImageoutputFormat = null)
        {
            var apiCallPath = "/V3012_ConvertImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3012ConvertImage = new JObject();
            var dtoRequestV3012ConvertImagepropCount = 0;
            dtoRequestV3012ConvertImagepropCount++;
            dtoRequestV3012ConvertImage["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3012ConvertImageimageFile);
            if (dtoRequestV3012ConvertImageoutputFormat != null)
            {
                if (dtoRequestV3012ConvertImageoutputFormat != null)
                {
                    dtoRequestV3012ConvertImage["outFormat"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3012ConvertImageoutputFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv> ConvertJsonToCsv(Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvjSON, Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvseparator = null)
        {
            var apiCallPath = "/V1013_ConvertJsonToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1013ConvertJsonToCsv = new JObject();
            var dtoRequestV1013ConvertJsonToCsvpropCount = 0;
            dtoRequestV1013ConvertJsonToCsvpropCount++;
            dtoRequestV1013ConvertJsonToCsv["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1013ConvertJsonToCsvjSON);
            if (dtoRequestV1013ConvertJsonToCsvseparator != null)
            {
                dtoRequestV1013ConvertJsonToCsv["delimiter"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1013ConvertJsonToCsvseparator);
                dtoRequestV1013ConvertJsonToCsvpropCount++;
            }

            if (dtoRequestV1013ConvertJsonToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestV1013ConvertJsonToCsv;
            }

            return new ApiConnectionAction<DtoResponseV1013ConvertJsonToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1063ConvertJsonToExcel> ConvertJsonToExcel(Expression<Func<string>> dtoRequestJsonToExcelDatajSON, Expression<Func<bool>> dtoRequestJsonToExcelDataallInOneTable = null, Expression<Func<bool>> dtoRequestJsonToExcelDataadjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestJsonToExcelDatawrapExcelColumnText = null, Expression<Func<int>> dtoRequestJsonToExcelDatamaxExcelColumnWidth = null)
        {
            var apiCallPath = "/V1063_ConvertJsonToExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestJsonToExcelData = new JObject();
            var dtoRequestJsonToExcelDatapropCount = 0;
            dtoRequestJsonToExcelDatapropCount++;
            dtoRequestJsonToExcelData["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestJsonToExcelDatajSON);
            if (dtoRequestJsonToExcelDataallInOneTable != null)
            {
                if (dtoRequestJsonToExcelDataallInOneTable != null)
                {
                    dtoRequestJsonToExcelData["allInOneTable"] = CSharpExpressionConverter.ConvertToken(dtoRequestJsonToExcelDataallInOneTable);
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
                    dtoRequestJsonToExcelData["adjustColumnToContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestJsonToExcelDataadjustExcelColumnToContent);
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
                    dtoRequestJsonToExcelData["wrapColumnText"] = CSharpExpressionConverter.ConvertToken(dtoRequestJsonToExcelDatawrapExcelColumnText);
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
                dtoRequestJsonToExcelData["maxColumnWidth"] = CSharpExpressionConverter.ConvertToken(dtoRequestJsonToExcelDatamaxExcelColumnWidth);
                dtoRequestJsonToExcelDatapropCount++;
            }

            if (dtoRequestJsonToExcelDatapropCount > 0)
            {
                callPayload.Body = dtoRequestJsonToExcelData;
            }

            return new ApiConnectionAction<DtoResponseV1063ConvertJsonToExcel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> ConvertJsonToHtmlTable(Expression<Func<string>> dtoRequestV7051ConvertJsonToHtmlTablejSON)
        {
            var apiCallPath = "/V7051_ConvertJsonToHtmlTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV7051ConvertJsonToHtmlTable = new JObject();
            var dtoRequestV7051ConvertJsonToHtmlTablepropCount = 0;
            dtoRequestV7051ConvertJsonToHtmlTablepropCount++;
            dtoRequestV7051ConvertJsonToHtmlTable["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV7051ConvertJsonToHtmlTablejSON);
            if (dtoRequestV7051ConvertJsonToHtmlTablepropCount > 0)
            {
                callPayload.Body = dtoRequestV7051ConvertJsonToHtmlTable;
            }

            return new ApiConnectionAction<DtoResponseHtml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable> ConvertJsonToTextTable(Expression<Func<string>> dtoRequestV1090ConvertJsonToTextTablejSON)
        {
            var apiCallPath = "/V1090_ConvertJsonToTextTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1090ConvertJsonToTextTable = new JObject();
            var dtoRequestV1090ConvertJsonToTextTablepropCount = 0;
            dtoRequestV1090ConvertJsonToTextTablepropCount++;
            dtoRequestV1090ConvertJsonToTextTable["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1090ConvertJsonToTextTablejSON);
            if (dtoRequestV1090ConvertJsonToTextTablepropCount > 0)
            {
                callPayload.Body = dtoRequestV1090ConvertJsonToTextTable;
            }

            return new ApiConnectionAction<DtoResponseV1090ConvertJsonToTextTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml> ConvertJsonToXml(Expression<Func<string>> dtoRequestV1042ConvertJsonToXmljSON)
        {
            var apiCallPath = "/V1042_ConvertJsonToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1042ConvertJsonToXml = new JObject();
            var dtoRequestV1042ConvertJsonToXmlpropCount = 0;
            dtoRequestV1042ConvertJsonToXmlpropCount++;
            dtoRequestV1042ConvertJsonToXml["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1042ConvertJsonToXmljSON);
            if (dtoRequestV1042ConvertJsonToXmlpropCount > 0)
            {
                callPayload.Body = dtoRequestV1042ConvertJsonToXml;
            }

            return new ApiConnectionAction<DtoResponseV1042ConvertJsonToXml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml> ConvertJsonToYaml(Expression<Func<string>> dtoRequestV1081ConvertJsonToYamljSON)
        {
            var apiCallPath = "/V1081_ConvertJsonToYaml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1081ConvertJsonToYaml = new JObject();
            var dtoRequestV1081ConvertJsonToYamlpropCount = 0;
            dtoRequestV1081ConvertJsonToYamlpropCount++;
            dtoRequestV1081ConvertJsonToYaml["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1081ConvertJsonToYamljSON);
            if (dtoRequestV1081ConvertJsonToYamlpropCount > 0)
            {
                callPayload.Body = dtoRequestV1081ConvertJsonToYaml;
            }

            return new ApiConnectionAction<DtoResponseV1081ConvertJsonToYaml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4070ConvertPdfToPdfA> ConvertPdfToPdfA(Expression<Func<string>> dtoRequestV4070ConvertPdfToPdfApDF, Expression<Func<int>> dtoRequestV4070ConvertPdfToPdfAconformanceLevel = null)
        {
            var apiCallPath = "/V4070_ConvertPdfToPdfA";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4070ConvertPdfToPdfA = new JObject();
            var dtoRequestV4070ConvertPdfToPdfApropCount = 0;
            dtoRequestV4070ConvertPdfToPdfApropCount++;
            dtoRequestV4070ConvertPdfToPdfA["pdf"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4070ConvertPdfToPdfApDF);
            if (dtoRequestV4070ConvertPdfToPdfAconformanceLevel != null)
            {
                dtoRequestV4070ConvertPdfToPdfA["conformanceLevel"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4070ConvertPdfToPdfAconformanceLevel);
                dtoRequestV4070ConvertPdfToPdfApropCount++;
            }

            if (dtoRequestV4070ConvertPdfToPdfApropCount > 0)
            {
                callPayload.Body = dtoRequestV4070ConvertPdfToPdfA;
            }

            return new ApiConnectionAction<DtoResponseV4070ConvertPdfToPdfA>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults> ConvertSharePointSearchResults(Expression<Func<string>> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
        {
            var apiCallPath = "/V6011_ConvertSharePointSearchResults";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV6011ConvertSharePointSearchResults = new JObject();
            var dtoRequestV6011ConvertSharePointSearchResultspropCount = 0;
            dtoRequestV6011ConvertSharePointSearchResultspropCount++;
            dtoRequestV6011ConvertSharePointSearchResults["sharepointResult"] = CSharpExpressionConverter.ConvertToken(dtoRequestV6011ConvertSharePointSearchResultssPSearchResult);
            if (dtoRequestV6011ConvertSharePointSearchResultspropCount > 0)
            {
                callPayload.Body = dtoRequestV6011ConvertSharePointSearchResults;
            }

            return new ApiConnectionAction<DtoResponseV6011ConvertSharePointSearchResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml> ConvertWordToHtml(Expression<Func<string>> dtoRequestword, Expression<Func<bool>> dtoRequestembedImages = null, Expression<Func<bool>> dtoRequestfullHTMLDocument = null, Expression<Func<string>> dtoRequesttitle = null)
        {
            var apiCallPath = "/V5160_ConvertWordToHtml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequest = new JObject();
            var dtoRequestpropCount = 0;
            dtoRequestpropCount++;
            dtoRequest["word"] = CSharpExpressionConverter.ConvertToken(dtoRequestword);
            if (dtoRequestembedImages != null)
            {
                dtoRequest["embedImages"] = CSharpExpressionConverter.ConvertToken(dtoRequestembedImages);
                dtoRequestpropCount++;
            }

            if (dtoRequestfullHTMLDocument != null)
            {
                dtoRequest["fullHtmlDocument"] = CSharpExpressionConverter.ConvertToken(dtoRequestfullHTMLDocument);
                dtoRequestpropCount++;
            }

            if (dtoRequesttitle != null)
            {
                dtoRequest["title"] = CSharpExpressionConverter.ConvertToken(dtoRequesttitle);
                dtoRequestpropCount++;
            }

            if (dtoRequestpropCount > 0)
            {
                callPayload.Body = dtoRequest;
            }

            return new ApiConnectionAction<DtoResponseV5160ConvertWordToHtml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1052ConvertXmlToJson> ConvertXmlToJson(Expression<Func<string>> dtoRequestV1052ConvertXmlToJsonxML)
        {
            var apiCallPath = "/V1052_ConvertXmlToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1052ConvertXmlToJson = new JObject();
            var dtoRequestV1052ConvertXmlToJsonpropCount = 0;
            dtoRequestV1052ConvertXmlToJsonpropCount++;
            dtoRequestV1052ConvertXmlToJson["xml"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1052ConvertXmlToJsonxML);
            if (dtoRequestV1052ConvertXmlToJsonpropCount > 0)
            {
                callPayload.Body = dtoRequestV1052ConvertXmlToJson;
            }

            return new ApiConnectionAction<DtoResponseV1052ConvertXmlToJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8010ConvertXRechnungToPdf> ConvertXRechnungToPdf(Expression<Func<string>> dtoRequestV8010ConvertXRechnungToPdfxRechnung)
        {
            var apiCallPath = "/V8010_ConvertXRechnungToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV8010ConvertXRechnungToPdf = new JObject();
            var dtoRequestV8010ConvertXRechnungToPdfpropCount = 0;
            dtoRequestV8010ConvertXRechnungToPdfpropCount++;
            dtoRequestV8010ConvertXRechnungToPdf["xml"] = CSharpExpressionConverter.ConvertToken(dtoRequestV8010ConvertXRechnungToPdfxRechnung);
            if (dtoRequestV8010ConvertXRechnungToPdfpropCount > 0)
            {
                callPayload.Body = dtoRequestV8010ConvertXRechnungToPdf;
            }

            return new ApiConnectionAction<DtoResponseV8010ConvertXRechnungToPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson> ConvertYamlToJson(Expression<Func<string>> dtoRequestV1071YamlToJsonyAML)
        {
            var apiCallPath = "/V1071_ConvertYamlToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1071YamlToJson = new JObject();
            var dtoRequestV1071YamlToJsonpropCount = 0;
            dtoRequestV1071YamlToJsonpropCount++;
            dtoRequestV1071YamlToJson["yaml"] = CSharpExpressionConverter.ConvertToken(dtoRequestV1071YamlToJsonyAML);
            if (dtoRequestV1071YamlToJsonpropCount > 0)
            {
                callPayload.Body = dtoRequestV1071YamlToJson;
            }

            return new ApiConnectionAction<DtoResponseV1071ConvertYamlToJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3091CreateChartImage> CreateChartImage(Expression<Func<string>> dtoRequestV3091CreateChartImagetableData, Expression<Func<int>> dtoRequestV3091CreateChartImageimageWidth = null, Expression<Func<int>> dtoRequestV3091CreateChartImageimageHeight = null, Expression<Func<string>> dtoRequestV3091CreateChartImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3091CreateChartImageoutputFormat = null, Expression<Func<string>> dtoRequestV3091CreateChartImagechartType = null)
        {
            var apiCallPath = "/V3091_CreateChartImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3091CreateChartImage = new JObject();
            var dtoRequestV3091CreateChartImagepropCount = 0;
            if (dtoRequestV3091CreateChartImageimageWidth != null)
            {
                dtoRequestV3091CreateChartImage["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImageimageWidth);
                dtoRequestV3091CreateChartImagepropCount++;
            }

            if (dtoRequestV3091CreateChartImageimageHeight != null)
            {
                dtoRequestV3091CreateChartImage["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImageimageHeight);
                dtoRequestV3091CreateChartImagepropCount++;
            }

            if (dtoRequestV3091CreateChartImagebackgroundColor != null)
            {
                dtoRequestV3091CreateChartImage["backgroundColor"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImagebackgroundColor);
                dtoRequestV3091CreateChartImagepropCount++;
            }

            if (dtoRequestV3091CreateChartImageoutputFormat != null)
            {
                dtoRequestV3091CreateChartImage["format"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImageoutputFormat);
                dtoRequestV3091CreateChartImagepropCount++;
            }

            dtoRequestV3091CreateChartImagepropCount++;
            dtoRequestV3091CreateChartImage["chart"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImagetableData);
            if (dtoRequestV3091CreateChartImagechartType != null)
            {
                dtoRequestV3091CreateChartImage["type"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3091CreateChartImagechartType);
                dtoRequestV3091CreateChartImagepropCount++;
            }

            if (dtoRequestV3091CreateChartImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3091CreateChartImage;
            }

            return new ApiConnectionAction<DtoResponseV3091CreateChartImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3062CreateCode> CreateCode(Expression<Func<string>> dtoRequestV3062CreateCodecontent, Expression<Func<string>> dtoRequestV3062CreateCodecodeFormat = null, Expression<Func<int>> dtoRequestV3062CreateCodewidth = null, Expression<Func<int>> dtoRequestV3062CreateCodeheight = null, Expression<Func<string>> dtoRequestV3062CreateCodeoutputFormat = null, Expression<Func<string>> dtoRequestV3062CreateCodeembeddedImage = null, Expression<Func<double>> dtoRequestV3062CreateCodeembeddedImageOpacity = null, Expression<Func<double>> dtoRequestV3062CreateCodeembeddedImageRatio = null)
        {
            var apiCallPath = "/V3062_CreateCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3062CreateCode = new JObject();
            var dtoRequestV3062CreateCodepropCount = 0;
            dtoRequestV3062CreateCodepropCount++;
            dtoRequestV3062CreateCode["content"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodecontent);
            if (dtoRequestV3062CreateCodecodeFormat != null)
            {
                dtoRequestV3062CreateCode["codeFormat"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodecodeFormat);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodewidth != null)
            {
                dtoRequestV3062CreateCode["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodewidth);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodeheight != null)
            {
                dtoRequestV3062CreateCode["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeheight);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodeoutputFormat != null)
            {
                dtoRequestV3062CreateCode["outFormat"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeoutputFormat);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodeembeddedImage != null)
            {
                dtoRequestV3062CreateCode["image"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeembeddedImage);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodeembeddedImageOpacity != null)
            {
                dtoRequestV3062CreateCode["imageOpacity"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeembeddedImageOpacity);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodeembeddedImageRatio != null)
            {
                dtoRequestV3062CreateCode["imageRatio"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3062CreateCodeembeddedImageRatio);
                dtoRequestV3062CreateCodepropCount++;
            }

            if (dtoRequestV3062CreateCodepropCount > 0)
            {
                callPayload.Body = dtoRequestV3062CreateCode;
            }

            return new ApiConnectionAction<DtoResponseV3062CreateCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3111CreateGraphImage> CreateGraphImage(Expression<Func<string>> dtoRequestV3111CreateGraphImagegraphData, Expression<Func<int>> dtoRequestV3111CreateGraphImageimageWidth = null, Expression<Func<int>> dtoRequestV3111CreateGraphImageimageHeight = null, Expression<Func<string>> dtoRequestV3111CreateGraphImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3111CreateGraphImageoutputFormat = null)
        {
            var apiCallPath = "/V3111_CreateGraphImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3111CreateGraphImage = new JObject();
            var dtoRequestV3111CreateGraphImagepropCount = 0;
            if (dtoRequestV3111CreateGraphImageimageWidth != null)
            {
                dtoRequestV3111CreateGraphImage["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImageimageWidth);
                dtoRequestV3111CreateGraphImagepropCount++;
            }

            if (dtoRequestV3111CreateGraphImageimageHeight != null)
            {
                dtoRequestV3111CreateGraphImage["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImageimageHeight);
                dtoRequestV3111CreateGraphImagepropCount++;
            }

            if (dtoRequestV3111CreateGraphImagebackgroundColor != null)
            {
                dtoRequestV3111CreateGraphImage["backgroundColor"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImagebackgroundColor);
                dtoRequestV3111CreateGraphImagepropCount++;
            }

            if (dtoRequestV3111CreateGraphImageoutputFormat != null)
            {
                dtoRequestV3111CreateGraphImage["format"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImageoutputFormat);
                dtoRequestV3111CreateGraphImagepropCount++;
            }

            dtoRequestV3111CreateGraphImagepropCount++;
            dtoRequestV3111CreateGraphImage["graph"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3111CreateGraphImagegraphData);
            if (dtoRequestV3111CreateGraphImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3111CreateGraphImage;
            }

            return new ApiConnectionAction<DtoResponseV3111CreateGraphImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3101CreateTableImage> CreateTableImage(Expression<Func<string>> dtoRequestV3101CreateTableImagetableData, Expression<Func<int>> dtoRequestV3101CreateTableImageimageWidth = null, Expression<Func<int>> dtoRequestV3101CreateTableImageimageHeight = null, Expression<Func<string>> dtoRequestV3101CreateTableImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3101CreateTableImageoutputFormat = null, Expression<Func<string>> dtoRequestV3101CreateTableImagetitle = null, Expression<Func<bool>> dtoRequestV3101CreateTableImageshowTableBorders = null)
        {
            var apiCallPath = "/V3101_CreateTableImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3101CreateTableImage = new JObject();
            var dtoRequestV3101CreateTableImagepropCount = 0;
            if (dtoRequestV3101CreateTableImageimageWidth != null)
            {
                dtoRequestV3101CreateTableImage["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageimageWidth);
                dtoRequestV3101CreateTableImagepropCount++;
            }

            if (dtoRequestV3101CreateTableImageimageHeight != null)
            {
                dtoRequestV3101CreateTableImage["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageimageHeight);
                dtoRequestV3101CreateTableImagepropCount++;
            }

            if (dtoRequestV3101CreateTableImagebackgroundColor != null)
            {
                dtoRequestV3101CreateTableImage["backgroundColor"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImagebackgroundColor);
                dtoRequestV3101CreateTableImagepropCount++;
            }

            if (dtoRequestV3101CreateTableImageoutputFormat != null)
            {
                dtoRequestV3101CreateTableImage["format"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageoutputFormat);
                dtoRequestV3101CreateTableImagepropCount++;
            }

            dtoRequestV3101CreateTableImagepropCount++;
            dtoRequestV3101CreateTableImage["data"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImagetableData);
            if (dtoRequestV3101CreateTableImagetitle != null)
            {
                dtoRequestV3101CreateTableImage["title"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImagetitle);
                dtoRequestV3101CreateTableImagepropCount++;
            }

            if (dtoRequestV3101CreateTableImageshowTableBorders != null)
            {
                if (dtoRequestV3101CreateTableImageshowTableBorders != null)
                {
                    dtoRequestV3101CreateTableImage["hasLines"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3101CreateTableImageshowTableBorders);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3081CreateWatermarkImage> CreateWatermarkImage(Expression<Func<string>> dtoRequestV3081CreateWatermarkImagemainImage, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkImage, Expression<Func<int>> dtoRequestV3081CreateWatermarkImagewatermarkOpacity = null, Expression<Func<int>> dtoRequestV3081CreateWatermarkImagewatermarkRatio = null, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = null, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = null)
        {
            var apiCallPath = "/V3081_CreateWatermarkImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3081CreateWatermarkImage = new JObject();
            var dtoRequestV3081CreateWatermarkImagepropCount = 0;
            dtoRequestV3081CreateWatermarkImagepropCount++;
            dtoRequestV3081CreateWatermarkImage["image"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagemainImage);
            dtoRequestV3081CreateWatermarkImagepropCount++;
            dtoRequestV3081CreateWatermarkImage["watermarkImage"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkImage);
            if (dtoRequestV3081CreateWatermarkImagewatermarkOpacity != null)
            {
                dtoRequestV3081CreateWatermarkImage["opacity"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkOpacity);
                dtoRequestV3081CreateWatermarkImagepropCount++;
            }

            if (dtoRequestV3081CreateWatermarkImagewatermarkRatio != null)
            {
                dtoRequestV3081CreateWatermarkImage["ratio"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkRatio);
                dtoRequestV3081CreateWatermarkImagepropCount++;
            }

            if (dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition != null)
            {
                dtoRequestV3081CreateWatermarkImage["imagePositionHorizontal"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition);
                dtoRequestV3081CreateWatermarkImagepropCount++;
            }

            if (dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition != null)
            {
                dtoRequestV3081CreateWatermarkImage["imagePositionVertical"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition);
                dtoRequestV3081CreateWatermarkImagepropCount++;
            }

            if (dtoRequestV3081CreateWatermarkImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3081CreateWatermarkImage;
            }

            return new ApiConnectionAction<DtoResponseV3081CreateWatermarkImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5011CreateWordFile> CreateWordFile(Expression<Func<Section[]>> dtoRequestV5011CreateWordFilesection, Expression<Func<string>> dtoRequestV5011CreateWordFileexistingFileContent = null)
        {
            var apiCallPath = "/V5011_CreateWordFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5011CreateWordFile = new JObject();
            var dtoRequestV5011CreateWordFilepropCount = 0;
            if (dtoRequestV5011CreateWordFileexistingFileContent != null)
            {
                dtoRequestV5011CreateWordFile["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5011CreateWordFileexistingFileContent);
                dtoRequestV5011CreateWordFilepropCount++;
            }

            dtoRequestV5011CreateWordFilepropCount++;
            dtoRequestV5011CreateWordFile["sections"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5011CreateWordFilesection);
            if (dtoRequestV5011CreateWordFilepropCount > 0)
            {
                callPayload.Body = dtoRequestV5011CreateWordFile;
            }

            return new ApiConnectionAction<DtoResponseV5011CreateWordFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf> ExtractImagesFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<string>> dtoRequestfileNamePrefix = null, Expression<Func<bool>> dtoRequestincludeBase64String = null)
        {
            var apiCallPath = "/V4090_ExtractImagesFromPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequest = new JObject();
            var dtoRequestpropCount = 0;
            dtoRequestpropCount++;
            dtoRequest["pdf"] = CSharpExpressionConverter.ConvertToken(dtoRequestpDF);
            if (dtoRequestfromPage != null)
            {
                dtoRequest["fromPage"] = CSharpExpressionConverter.ConvertToken(dtoRequestfromPage);
                dtoRequestpropCount++;
            }

            if (dtoRequesttoPage != null)
            {
                dtoRequest["toPage"] = CSharpExpressionConverter.ConvertToken(dtoRequesttoPage);
                dtoRequestpropCount++;
            }

            if (dtoRequestfileNamePrefix != null)
            {
                dtoRequest["fileNamePrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestfileNamePrefix);
                dtoRequestpropCount++;
            }

            if (dtoRequestincludeBase64String != null)
            {
                dtoRequest["includeFileString"] = CSharpExpressionConverter.ConvertToken(dtoRequestincludeBase64String);
                dtoRequestpropCount++;
            }

            if (dtoRequestpropCount > 0)
            {
                callPayload.Body = dtoRequest;
            }

            return new ApiConnectionAction<DtoResponseV4090ExtractImagesFromPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties> ExtractJsonObjectProperties(Expression<Func<string>> dtoRequestV2100ExtractJsonObjectPropertiesjSON, Expression<Func<bool>> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
        {
            var apiCallPath = "/V2100_ExtractJsonObjectProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2100ExtractJsonObjectProperties = new JObject();
            var dtoRequestV2100ExtractJsonObjectPropertiespropCount = 0;
            dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
            dtoRequestV2100ExtractJsonObjectProperties["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2100ExtractJsonObjectPropertiesjSON);
            if (dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
            {
                if (dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties != null)
                {
                    dtoRequestV2100ExtractJsonObjectProperties["nestedPropertyExtraction"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4060ExtractPdfPages> ExtractPdfPages(Expression<Func<string>> dtoRequestV4060ExtractPdfPagespDFFile, Expression<Func<string>> dtoRequestV4060ExtractPdfPagespagesToExtract)
        {
            var apiCallPath = "/V4060_ExtractPdfPages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4060ExtractPdfPages = new JObject();
            var dtoRequestV4060ExtractPdfPagespropCount = 0;
            dtoRequestV4060ExtractPdfPagespropCount++;
            dtoRequestV4060ExtractPdfPages["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4060ExtractPdfPagespDFFile);
            dtoRequestV4060ExtractPdfPagespropCount++;
            dtoRequestV4060ExtractPdfPages["pages"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4060ExtractPdfPagespagesToExtract);
            if (dtoRequestV4060ExtractPdfPagespropCount > 0)
            {
                callPayload.Body = dtoRequestV4060ExtractPdfPages;
            }

            return new ApiConnectionAction<DtoResponseV4060ExtractPdfPages>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern> ExtractTextAccordingToPattern(Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntext, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, Expression<Func<bool>> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
        {
            var apiCallPath = "/V2140_ExtractTextAccordingToPattern";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2140ExtractTextAccordingToPattern = new JObject();
            var dtoRequestV2140ExtractTextAccordingToPatternpropCount = 0;
            dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
            dtoRequestV2140ExtractTextAccordingToPattern["inputText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatterntext);
            dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
            dtoRequestV2140ExtractTextAccordingToPattern["matchPattern"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatternmatchPattern);
            if (dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled != null)
            {
                dtoRequestV2140ExtractTextAccordingToPattern["trimEnabled"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled);
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
            }

            if (dtoRequestV2140ExtractTextAccordingToPatterntrimStrings != null)
            {
                dtoRequestV2140ExtractTextAccordingToPattern["trimStrings"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2140ExtractTextAccordingToPatterntrimStrings);
                dtoRequestV2140ExtractTextAccordingToPatternpropCount++;
            }

            if (dtoRequestV2140ExtractTextAccordingToPatternpropCount > 0)
            {
                callPayload.Body = dtoRequestV2140ExtractTextAccordingToPattern;
            }

            return new ApiConnectionAction<DtoResponseV2140ExtractTextAccordingToPattern>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf> ExtractTextFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<int>> dtoRequestfromPage = null, Expression<Func<int>> dtoRequesttoPage = null, Expression<Func<bool>> dtoRequestlayoutBased = null, Expression<Func<bool>> dtoRequestincludePages = null, Expression<Func<string>> dtoRequestpageSeparator = null, Expression<Func<bool>> dtoRequestnormalizeWhitespace = null)
        {
            var apiCallPath = "/V4100_ExtractTextFromPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequest = new JObject();
            var dtoRequestpropCount = 0;
            dtoRequestpropCount++;
            dtoRequest["pdf"] = CSharpExpressionConverter.ConvertToken(dtoRequestpDF);
            if (dtoRequestfromPage != null)
            {
                dtoRequest["fromPage"] = CSharpExpressionConverter.ConvertToken(dtoRequestfromPage);
                dtoRequestpropCount++;
            }

            if (dtoRequesttoPage != null)
            {
                dtoRequest["toPage"] = CSharpExpressionConverter.ConvertToken(dtoRequesttoPage);
                dtoRequestpropCount++;
            }

            if (dtoRequestlayoutBased != null)
            {
                dtoRequest["layoutBased"] = CSharpExpressionConverter.ConvertToken(dtoRequestlayoutBased);
                dtoRequestpropCount++;
            }

            if (dtoRequestincludePages != null)
            {
                dtoRequest["includePages"] = CSharpExpressionConverter.ConvertToken(dtoRequestincludePages);
                dtoRequestpropCount++;
            }

            if (dtoRequestpageSeparator != null)
            {
                dtoRequest["pageSeparator"] = CSharpExpressionConverter.ConvertToken(dtoRequestpageSeparator);
                dtoRequestpropCount++;
            }

            if (dtoRequestnormalizeWhitespace != null)
            {
                dtoRequest["normalizeWhitespace"] = CSharpExpressionConverter.ConvertToken(dtoRequestnormalizeWhitespace);
                dtoRequestpropCount++;
            }

            if (dtoRequestpropCount > 0)
            {
                callPayload.Body = dtoRequest;
            }

            return new ApiConnectionAction<DtoResponseV4100ExtractTextFromPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> ExtractWordBookmarks(Expression<Func<string>> dtoRequestV5021ExtractWordBookmarksfile, Expression<Func<bool>> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchName = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
        {
            var apiCallPath = "/V5021_ExtractWordBookmarks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5021ExtractWordBookmarks = new JObject();
            var dtoRequestV5021ExtractWordBookmarkspropCount = 0;
            dtoRequestV5021ExtractWordBookmarkspropCount++;
            dtoRequestV5021ExtractWordBookmarks["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarksfile);
            if (dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
            {
                if (dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks != null)
                {
                    dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks);
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
                dtoRequestV5021ExtractWordBookmarks["searchKey"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarkssearchName);
                dtoRequestV5021ExtractWordBookmarkspropCount++;
            }

            if (dtoRequestV5021ExtractWordBookmarkssearchContent != null)
            {
                dtoRequestV5021ExtractWordBookmarks["searchValue"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5021ExtractWordBookmarkssearchContent);
                dtoRequestV5021ExtractWordBookmarkspropCount++;
            }

            if (dtoRequestV5021ExtractWordBookmarkspropCount > 0)
            {
                callPayload.Body = dtoRequestV5021ExtractWordBookmarks;
            }

            return new ApiConnectionAction<DtoResponseV5021ExtractWordBookmarks>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> ExtractWordContentControls(Expression<Func<string>> dtoRequestV5120ExtractWordContentControlsfile, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTag = null, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
        {
            var apiCallPath = "/V5120_ExtractWordContentControls";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5120ExtractWordContentControls = new JObject();
            var dtoRequestV5120ExtractWordContentControlspropCount = 0;
            dtoRequestV5120ExtractWordContentControlspropCount++;
            dtoRequestV5120ExtractWordContentControls["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlsfile);
            if (dtoRequestV5120ExtractWordContentControlssearchTag != null)
            {
                dtoRequestV5120ExtractWordContentControls["searchTag"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlssearchTag);
                dtoRequestV5120ExtractWordContentControlspropCount++;
            }

            if (dtoRequestV5120ExtractWordContentControlssearchTitle != null)
            {
                dtoRequestV5120ExtractWordContentControls["searchTitle"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5120ExtractWordContentControlssearchTitle);
                dtoRequestV5120ExtractWordContentControlspropCount++;
            }

            if (dtoRequestV5120ExtractWordContentControlspropCount > 0)
            {
                callPayload.Body = dtoRequestV5120ExtractWordContentControls;
            }

            return new ApiConnectionAction<DtoResponseV5120ExtractWordContentControls>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2021IbanData> IbanData(Expression<Func<string>> dtoRequestV2021IbanDataiBAN)
        {
            var apiCallPath = "/V2021_IbanData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2021IbanData = new JObject();
            var dtoRequestV2021IbanDatapropCount = 0;
            dtoRequestV2021IbanDatapropCount++;
            dtoRequestV2021IbanData["iban"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2021IbanDataiBAN);
            if (dtoRequestV2021IbanDatapropCount > 0)
            {
                callPayload.Body = dtoRequestV2021IbanData;
            }

            return new ApiConnectionAction<DtoResponseV2021IbanData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData> ImageMetaData(Expression<Func<string>> dtoRequestV3071ImageMetaDataimageFile)
        {
            var apiCallPath = "/V3071_ImageMetaData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3071ImageMetaData = new JObject();
            var dtoRequestV3071ImageMetaDatapropCount = 0;
            dtoRequestV3071ImageMetaDatapropCount++;
            dtoRequestV3071ImageMetaData["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3071ImageMetaDataimageFile);
            if (dtoRequestV3071ImageMetaDatapropCount > 0)
            {
                callPayload.Body = dtoRequestV3071ImageMetaData;
            }

            return new ApiConnectionAction<DtoResponseV3071ImageMetaData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToPowerPoint(Expression<Func<string>> dtoRequestV9020InsertImagePowerPointexistingFileContent, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderImage, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderName = null, Expression<Func<int>> dtoRequestV9020InsertImagePowerPointmaximumImageWidth = null, Expression<Func<int>> dtoRequestV9020InsertImagePowerPointmaximumImageHeight = null, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestV9020InsertImagePowerPointplaceholderSuffix = null)
        {
            var apiCallPath = "/V9020_InsertImageToPowerPoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV9020InsertImagePowerPoint = new JObject();
            var dtoRequestV9020InsertImagePowerPointpropCount = 0;
            dtoRequestV9020InsertImagePowerPointpropCount++;
            dtoRequestV9020InsertImagePowerPoint["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointexistingFileContent);
            if (dtoRequestV9020InsertImagePowerPointplaceholderName != null)
            {
                dtoRequestV9020InsertImagePowerPoint["placeholderName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderName);
                dtoRequestV9020InsertImagePowerPointpropCount++;
            }

            dtoRequestV9020InsertImagePowerPointpropCount++;
            dtoRequestV9020InsertImagePowerPoint["placeholderImage"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderImage);
            if (dtoRequestV9020InsertImagePowerPointmaximumImageWidth != null)
            {
                dtoRequestV9020InsertImagePowerPoint["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointmaximumImageWidth);
                dtoRequestV9020InsertImagePowerPointpropCount++;
            }

            if (dtoRequestV9020InsertImagePowerPointmaximumImageHeight != null)
            {
                dtoRequestV9020InsertImagePowerPoint["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointmaximumImageHeight);
                dtoRequestV9020InsertImagePowerPointpropCount++;
            }

            if (dtoRequestV9020InsertImagePowerPointplaceholderPrefix != null)
            {
                dtoRequestV9020InsertImagePowerPoint["placeholderPrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderPrefix);
                dtoRequestV9020InsertImagePowerPointpropCount++;
            }

            if (dtoRequestV9020InsertImagePowerPointplaceholderSuffix != null)
            {
                dtoRequestV9020InsertImagePowerPoint["placeholderSuffix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9020InsertImagePowerPointplaceholderSuffix);
                dtoRequestV9020InsertImagePowerPointpropCount++;
            }

            if (dtoRequestV9020InsertImagePowerPointpropCount > 0)
            {
                callPayload.Body = dtoRequestV9020InsertImagePowerPoint;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertImageToWord(Expression<Func<string>> dtoRequestV5081InsertImageToWordexistingFileContent, Expression<Func<string>> dtoRequestV5081InsertImageToWordimage, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderName = null, Expression<Func<int>> dtoRequestV5081InsertImageToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5081InsertImageToWordmaximumImageHeight = null, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderSuffix = null)
        {
            var apiCallPath = "/V5081_InsertImageToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5081InsertImageToWord = new JObject();
            var dtoRequestV5081InsertImageToWordpropCount = 0;
            dtoRequestV5081InsertImageToWordpropCount++;
            dtoRequestV5081InsertImageToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordexistingFileContent);
            if (dtoRequestV5081InsertImageToWordplaceholderName != null)
            {
                dtoRequestV5081InsertImageToWord["placeholderName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordplaceholderName);
                dtoRequestV5081InsertImageToWordpropCount++;
            }

            dtoRequestV5081InsertImageToWordpropCount++;
            dtoRequestV5081InsertImageToWord["placeholderImage"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordimage);
            if (dtoRequestV5081InsertImageToWordmaximumImageWidth != null)
            {
                dtoRequestV5081InsertImageToWord["maxWidth"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordmaximumImageWidth);
                dtoRequestV5081InsertImageToWordpropCount++;
            }

            if (dtoRequestV5081InsertImageToWordmaximumImageHeight != null)
            {
                dtoRequestV5081InsertImageToWord["maxHeight"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordmaximumImageHeight);
                dtoRequestV5081InsertImageToWordpropCount++;
            }

            if (dtoRequestV5081InsertImageToWordplaceholderPrefix != null)
            {
                dtoRequestV5081InsertImageToWord["placeholderPrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordplaceholderPrefix);
                dtoRequestV5081InsertImageToWordpropCount++;
            }

            if (dtoRequestV5081InsertImageToWordplaceholderSuffix != null)
            {
                dtoRequestV5081InsertImageToWord["placeholderSuffix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5081InsertImageToWordplaceholderSuffix);
                dtoRequestV5081InsertImageToWordpropCount++;
            }

            if (dtoRequestV5081InsertImageToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5081InsertImageToWord;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5110InsertMultipleTextSectionsToWord> InsertMultipleTextSectionsToWord(Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, Expression<Func<InsertSection[]>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = null)
        {
            var apiCallPath = "/V5110_InsertMultipleTextSectionsToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5110InsertMultipleTextSectionsToWord = new JObject();
            var dtoRequestV5110InsertMultipleTextSectionsToWordpropCount = 0;
            dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
            dtoRequestV5110InsertMultipleTextSectionsToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent);
            dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
            dtoRequestV5110InsertMultipleTextSectionsToWord["insertSections"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder);
            if (dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix != null)
            {
                dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderPrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix);
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
            }

            if (dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix != null)
            {
                dtoRequestV5110InsertMultipleTextSectionsToWord["placeholderSuffix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix);
                dtoRequestV5110InsertMultipleTextSectionsToWordpropCount++;
            }

            if (dtoRequestV5110InsertMultipleTextSectionsToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5110InsertMultipleTextSectionsToWord;
            }

            return new ApiConnectionAction<DtoResponseV5110InsertMultipleTextSectionsToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5091InsertTableToWord> InsertTableToWord(Expression<Func<string>> dtoRequestV5091InsertTableToWordexistingFileContent, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderName = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderTable = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordtableStyle = null, Expression<Func<bool>> dtoRequestV5091InsertTableToWordshowHeaders = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderSuffix = null)
        {
            var apiCallPath = "/V5091_InsertTableToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5091InsertTableToWord = new JObject();
            var dtoRequestV5091InsertTableToWordpropCount = 0;
            dtoRequestV5091InsertTableToWordpropCount++;
            dtoRequestV5091InsertTableToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordexistingFileContent);
            if (dtoRequestV5091InsertTableToWordplaceholderName != null)
            {
                dtoRequestV5091InsertTableToWord["placeholderName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderName);
                dtoRequestV5091InsertTableToWordpropCount++;
            }

            if (dtoRequestV5091InsertTableToWordplaceholderTable != null)
            {
                dtoRequestV5091InsertTableToWord["placeholderTable"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderTable);
                dtoRequestV5091InsertTableToWordpropCount++;
            }

            if (dtoRequestV5091InsertTableToWordtableStyle != null)
            {
                if (dtoRequestV5091InsertTableToWordtableStyle != null)
                {
                    dtoRequestV5091InsertTableToWord["tableStyle"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordtableStyle);
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
                    dtoRequestV5091InsertTableToWord["hasHeader"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordshowHeaders);
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
                dtoRequestV5091InsertTableToWord["placeholderPrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderPrefix);
                dtoRequestV5091InsertTableToWordpropCount++;
            }

            if (dtoRequestV5091InsertTableToWordplaceholderSuffix != null)
            {
                dtoRequestV5091InsertTableToWord["placeholderSuffix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5091InsertTableToWordplaceholderSuffix);
                dtoRequestV5091InsertTableToWordpropCount++;
            }

            if (dtoRequestV5091InsertTableToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5091InsertTableToWord;
            }

            return new ApiConnectionAction<DtoResponseV5091InsertTableToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> InsertTextToPowerPoint(Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointexistingFileContent, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderName, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderText = null, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            var apiCallPath = "/V9010_InsertTextToPowerPoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV9010InsertTextToPowerPoint = new JObject();
            var dtoRequestV9010InsertTextToPowerPointpropCount = 0;
            dtoRequestV9010InsertTextToPowerPointpropCount++;
            dtoRequestV9010InsertTextToPowerPoint["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointexistingFileContent);
            dtoRequestV9010InsertTextToPowerPointpropCount++;
            dtoRequestV9010InsertTextToPowerPoint["placeholderName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderName);
            if (dtoRequestV9010InsertTextToPowerPointplaceholderText != null)
            {
                dtoRequestV9010InsertTextToPowerPoint["placeholderText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderText);
                dtoRequestV9010InsertTextToPowerPointpropCount++;
            }

            if (dtoRequestV9010InsertTextToPowerPointplaceholderPrefix != null)
            {
                dtoRequestV9010InsertTextToPowerPoint["placeholderPrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderPrefix);
                dtoRequestV9010InsertTextToPowerPointpropCount++;
            }

            if (dtoRequestV9010InsertTextToPowerPointplaceholderSuffix != null)
            {
                dtoRequestV9010InsertTextToPowerPoint["placeholderSuffix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV9010InsertTextToPowerPointplaceholderSuffix);
                dtoRequestV9010InsertTextToPowerPointpropCount++;
            }

            if (dtoRequestV9010InsertTextToPowerPointpropCount > 0)
            {
                callPayload.Body = dtoRequestV9010InsertTextToPowerPoint;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5071InsertTextToWord> InsertTextToWord(Expression<Func<string>> dtoRequestV5071InsertTextToWordexistingFileContent, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderName, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderText = null, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderSuffix = null)
        {
            var apiCallPath = "/V5071_InsertTextToWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5071InsertTextToWord = new JObject();
            var dtoRequestV5071InsertTextToWordpropCount = 0;
            dtoRequestV5071InsertTextToWordpropCount++;
            dtoRequestV5071InsertTextToWord["existingFileContent"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordexistingFileContent);
            dtoRequestV5071InsertTextToWordpropCount++;
            dtoRequestV5071InsertTextToWord["placeholderName"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderName);
            if (dtoRequestV5071InsertTextToWordplaceholderText != null)
            {
                dtoRequestV5071InsertTextToWord["placeholderText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderText);
                dtoRequestV5071InsertTextToWordpropCount++;
            }

            if (dtoRequestV5071InsertTextToWordplaceholderPrefix != null)
            {
                dtoRequestV5071InsertTextToWord["placeholderPrefix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderPrefix);
                dtoRequestV5071InsertTextToWordpropCount++;
            }

            if (dtoRequestV5071InsertTextToWordplaceholderSuffix != null)
            {
                dtoRequestV5071InsertTextToWord["placeholderSuffix"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5071InsertTextToWordplaceholderSuffix);
                dtoRequestV5071InsertTextToWordpropCount++;
            }

            if (dtoRequestV5071InsertTextToWordpropCount > 0)
            {
                callPayload.Body = dtoRequestV5071InsertTextToWord;
            }

            return new ApiConnectionAction<DtoResponseV5071InsertTextToWord>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4021MergePdfs> MergePdfs(Expression<Func<string>> dtoRequestV4021MergePdfsfile1, Expression<Func<string>> dtoRequestV4021MergePdfsfile2)
        {
            var apiCallPath = "/V4021_MergePdfs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4021MergePdfs = new JObject();
            var dtoRequestV4021MergePdfspropCount = 0;
            dtoRequestV4021MergePdfspropCount++;
            dtoRequestV4021MergePdfs["file1"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4021MergePdfsfile1);
            dtoRequestV4021MergePdfspropCount++;
            dtoRequestV4021MergePdfs["file2"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4021MergePdfsfile2);
            if (dtoRequestV4021MergePdfspropCount > 0)
            {
                callPayload.Body = dtoRequestV4021MergePdfs;
            }

            return new ApiConnectionAction<DtoResponseV4021MergePdfs>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck> PatternMatchCheck(Expression<Func<string>> dtoRequestV2120PatternMatchCheckinputText, Expression<Func<string>> dtoRequestV2120PatternMatchCheckmatchPattern)
        {
            var apiCallPath = "/V2120_PatternMatchCheck";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2120PatternMatchCheck = new JObject();
            var dtoRequestV2120PatternMatchCheckpropCount = 0;
            dtoRequestV2120PatternMatchCheckpropCount++;
            dtoRequestV2120PatternMatchCheck["inputText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2120PatternMatchCheckinputText);
            dtoRequestV2120PatternMatchCheckpropCount++;
            dtoRequestV2120PatternMatchCheck["matchPattern"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2120PatternMatchCheckmatchPattern);
            if (dtoRequestV2120PatternMatchCheckpropCount > 0)
            {
                callPayload.Body = dtoRequestV2120PatternMatchCheck;
            }

            return new ApiConnectionAction<DtoResponseV2120MatchPatternCheck>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> PdfMetadata(Expression<Func<string>> dtoRequestV4031PdfMetadatafile)
        {
            var apiCallPath = "/V4031_PdfMetadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4031PdfMetadata = new JObject();
            var dtoRequestV4031PdfMetadatapropCount = 0;
            dtoRequestV4031PdfMetadatapropCount++;
            dtoRequestV4031PdfMetadata["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4031PdfMetadatafile);
            if (dtoRequestV4031PdfMetadatapropCount > 0)
            {
                callPayload.Body = dtoRequestV4031PdfMetadata;
            }

            return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4041ProtectPdf> ProtectPdf(Expression<Func<string>> dtoRequestV4041ProtectPdffile, Expression<Func<string>> dtoRequestV4041ProtectPdfownerPassword = null, Expression<Func<string>> dtoRequestV4041ProtectPdfuserPassword = null)
        {
            var apiCallPath = "/V4041_ProtectPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4041ProtectPdf = new JObject();
            var dtoRequestV4041ProtectPdfpropCount = 0;
            dtoRequestV4041ProtectPdfpropCount++;
            dtoRequestV4041ProtectPdf["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4041ProtectPdffile);
            if (dtoRequestV4041ProtectPdfownerPassword != null)
            {
                dtoRequestV4041ProtectPdf["ownerPassword"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4041ProtectPdfownerPassword);
                dtoRequestV4041ProtectPdfpropCount++;
            }

            if (dtoRequestV4041ProtectPdfuserPassword != null)
            {
                dtoRequestV4041ProtectPdf["userPassword"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4041ProtectPdfuserPassword);
                dtoRequestV4041ProtectPdfpropCount++;
            }

            if (dtoRequestV4041ProtectPdfpropCount > 0)
            {
                callPayload.Body = dtoRequestV4041ProtectPdf;
            }

            return new ApiConnectionAction<DtoResponseV4041ProtectPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode> ReadCode(Expression<Func<string>> dtoRequestReadCodeDataqROrBarcode)
        {
            var apiCallPath = "/V3051_ReadCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestReadCodeData = new JObject();
            var dtoRequestReadCodeDatapropCount = 0;
            dtoRequestReadCodeDatapropCount++;
            dtoRequestReadCodeData["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestReadCodeDataqROrBarcode);
            if (dtoRequestReadCodeDatapropCount > 0)
            {
                callPayload.Body = dtoRequestReadCodeData;
            }

            return new ApiConnectionAction<DtoResponseV3051ReadCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression> RegularExpression(Expression<Func<string>> dtoRequestV2011RegularExpressiontextToMatch, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpression = null, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpressionOption = null)
        {
            var apiCallPath = "/V2011_RegularExpression";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2011RegularExpression = new JObject();
            var dtoRequestV2011RegularExpressionpropCount = 0;
            dtoRequestV2011RegularExpressionpropCount++;
            dtoRequestV2011RegularExpression["input"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2011RegularExpressiontextToMatch);
            if (dtoRequestV2011RegularExpressionregularExpression != null)
            {
                dtoRequestV2011RegularExpression["pattern"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2011RegularExpressionregularExpression);
                dtoRequestV2011RegularExpressionpropCount++;
            }

            if (dtoRequestV2011RegularExpressionregularExpressionOption != null)
            {
                dtoRequestV2011RegularExpression["option"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2011RegularExpressionregularExpressionOption);
                dtoRequestV2011RegularExpressionpropCount++;
            }

            if (dtoRequestV2011RegularExpressionpropCount > 0)
            {
                callPayload.Body = dtoRequestV2011RegularExpression;
            }

            return new ApiConnectionAction<DtoResponseV2011RegularExpression>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4110RemovePagesFromPdf> RemovePagesFromPdf(Expression<Func<string>> dtoRequestpDF, Expression<Func<string>> dtoRequestpages, Expression<Func<bool>> dtoRequestinputIs1Based = null, Expression<Func<int>> dtoRequestmode = null, Expression<Func<bool>> dtoRequestfailIfPageOutOfRange = null)
        {
            var apiCallPath = "/V4110_RemovePagesFromPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequest = new JObject();
            var dtoRequestpropCount = 0;
            dtoRequestpropCount++;
            dtoRequest["pdf"] = CSharpExpressionConverter.ConvertToken(dtoRequestpDF);
            dtoRequestpropCount++;
            dtoRequest["pages"] = CSharpExpressionConverter.ConvertToken(dtoRequestpages);
            if (dtoRequestinputIs1Based != null)
            {
                dtoRequest["oneBased"] = CSharpExpressionConverter.ConvertToken(dtoRequestinputIs1Based);
                dtoRequestpropCount++;
            }

            if (dtoRequestmode != null)
            {
                dtoRequest["mode"] = CSharpExpressionConverter.ConvertToken(dtoRequestmode);
                dtoRequestpropCount++;
            }

            if (dtoRequestfailIfPageOutOfRange != null)
            {
                dtoRequest["strict"] = CSharpExpressionConverter.ConvertToken(dtoRequestfailIfPageOutOfRange);
                dtoRequestpropCount++;
            }

            if (dtoRequestpropCount > 0)
            {
                callPayload.Body = dtoRequest;
            }

            return new ApiConnectionAction<DtoResponseV4110RemovePagesFromPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern> ReplaceTextWithPattern(Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatterninputText, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternsearchPattern, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
        {
            var apiCallPath = "/V2110_ReplaceTextWithPattern";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2110ReplaceTextWithPattern = new JObject();
            var dtoRequestV2110ReplaceTextWithPatternpropCount = 0;
            dtoRequestV2110ReplaceTextWithPatternpropCount++;
            dtoRequestV2110ReplaceTextWithPattern["inputText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2110ReplaceTextWithPatterninputText);
            dtoRequestV2110ReplaceTextWithPatternpropCount++;
            dtoRequestV2110ReplaceTextWithPattern["searchPattern"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2110ReplaceTextWithPatternsearchPattern);
            if (dtoRequestV2110ReplaceTextWithPatternreplacementText != null)
            {
                dtoRequestV2110ReplaceTextWithPattern["replacementText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2110ReplaceTextWithPatternreplacementText);
                dtoRequestV2110ReplaceTextWithPatternpropCount++;
            }

            if (dtoRequestV2110ReplaceTextWithPatternpropCount > 0)
            {
                callPayload.Body = dtoRequestV2110ReplaceTextWithPattern;
            }

            return new ApiConnectionAction<DtoResponseV2110ReplaceTextWithPattern>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3022ResizeImage> ResizeImage(Expression<Func<string>> dtoRequestV3022ResizeImageimageFile, Expression<Func<double>> dtoRequestV3022ResizeImageimageWidth = null, Expression<Func<double>> dtoRequestV3022ResizeImageimageHeight = null, Expression<Func<string>> dtoRequestV3022ResizeImageresizeBy = null)
        {
            var apiCallPath = "/V3022_ResizeImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3022ResizeImage = new JObject();
            var dtoRequestV3022ResizeImagepropCount = 0;
            dtoRequestV3022ResizeImagepropCount++;
            dtoRequestV3022ResizeImage["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageimageFile);
            if (dtoRequestV3022ResizeImageimageWidth != null)
            {
                dtoRequestV3022ResizeImage["width"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageimageWidth);
                dtoRequestV3022ResizeImagepropCount++;
            }

            if (dtoRequestV3022ResizeImageimageHeight != null)
            {
                dtoRequestV3022ResizeImage["height"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageimageHeight);
                dtoRequestV3022ResizeImagepropCount++;
            }

            if (dtoRequestV3022ResizeImageresizeBy != null)
            {
                dtoRequestV3022ResizeImage["resizeBy"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3022ResizeImageresizeBy);
                dtoRequestV3022ResizeImagepropCount++;
            }

            if (dtoRequestV3022ResizeImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3022ResizeImage;
            }

            return new ApiConnectionAction<DtoResponseV3022ResizeImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3031RotateImage> RotateImage(Expression<Func<string>> dtoRequestV3031RotateImageimageFile, Expression<Func<double>> dtoRequestV3031RotateImagerotate = null, Expression<Func<string>> dtoRequestV3031RotateImageoutputFormat = null)
        {
            var apiCallPath = "/V3031_RotateImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV3031RotateImage = new JObject();
            var dtoRequestV3031RotateImagepropCount = 0;
            dtoRequestV3031RotateImagepropCount++;
            dtoRequestV3031RotateImage["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3031RotateImageimageFile);
            if (dtoRequestV3031RotateImagerotate != null)
            {
                dtoRequestV3031RotateImage["rotate"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3031RotateImagerotate);
                dtoRequestV3031RotateImagepropCount++;
            }

            if (dtoRequestV3031RotateImageoutputFormat != null)
            {
                dtoRequestV3031RotateImage["outFormat"] = CSharpExpressionConverter.ConvertToken(dtoRequestV3031RotateImageoutputFormat);
                dtoRequestV3031RotateImagepropCount++;
            }

            if (dtoRequestV3031RotateImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3031RotateImage;
            }

            return new ApiConnectionAction<DtoResponseV3031RotateImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2151RunCode> RunCode(Expression<Func<string>> dtopythonOrJavaScriptCode, Expression<Func<int>> dtoruntime = null, Expression<Func<int>> dtotimeoutSeconds = null, Expression<Func<bool>> dtoprintLastExpression = null)
        {
            var apiCallPath = "/V2151_RunCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dto = new JObject();
            var dtopropCount = 0;
            dtopropCount++;
            dto["code"] = CSharpExpressionConverter.ConvertToken(dtopythonOrJavaScriptCode);
            if (dtoruntime != null)
            {
                dto["runtime"] = CSharpExpressionConverter.ConvertToken(dtoruntime);
                dtopropCount++;
            }

            if (dtotimeoutSeconds != null)
            {
                dto["timeoutSec"] = CSharpExpressionConverter.ConvertToken(dtotimeoutSeconds);
                dtopropCount++;
            }

            if (dtoprintLastExpression != null)
            {
                dto["printLastExpression"] = CSharpExpressionConverter.ConvertToken(dtoprintLastExpression);
                dtopropCount++;
            }

            if (dtopropCount > 0)
            {
                callPayload.Body = dto;
            }

            return new ApiConnectionAction<DtoResponseV2151RunCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit> SmartTextSplit(Expression<Func<string>> dtoRequestV2130SmartTextSplitinputText, Expression<Func<string>> dtoRequestV2130SmartTextSplitsplitPattern = null, Expression<Func<bool>> dtoRequestV2130SmartTextSplittrimEnabled = null, Expression<Func<string>> dtoRequestV2130SmartTextSplittrimStrings = null)
        {
            var apiCallPath = "/V2130_SmartTextSplit";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2130SmartTextSplit = new JObject();
            var dtoRequestV2130SmartTextSplitpropCount = 0;
            dtoRequestV2130SmartTextSplitpropCount++;
            dtoRequestV2130SmartTextSplit["inputText"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplitinputText);
            if (dtoRequestV2130SmartTextSplitsplitPattern != null)
            {
                dtoRequestV2130SmartTextSplit["splitPattern"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplitsplitPattern);
                dtoRequestV2130SmartTextSplitpropCount++;
            }

            if (dtoRequestV2130SmartTextSplittrimEnabled != null)
            {
                dtoRequestV2130SmartTextSplit["trimEnabled"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplittrimEnabled);
                dtoRequestV2130SmartTextSplitpropCount++;
            }

            if (dtoRequestV2130SmartTextSplittrimStrings != null)
            {
                dtoRequestV2130SmartTextSplit["trimStrings"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2130SmartTextSplittrimStrings);
                dtoRequestV2130SmartTextSplitpropCount++;
            }

            if (dtoRequestV2130SmartTextSplitpropCount > 0)
            {
                callPayload.Body = dtoRequestV2130SmartTextSplit;
            }

            return new ApiConnectionAction<DtoResponseV2130SmartTextSplit>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv> SortCsv(Expression<Func<string>> dtoRequestV2061SortCsvcSV, Expression<Func<bool>> dtoRequestV2061SortCsvcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV2061SortCsvremoveEmptyRows = null, Expression<Func<int>> dtoRequestV2061SortCsvskipANumberOfRows = null, Expression<Func<int>> dtoRequestV2061SortCsvstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV2061SortCsvseparator = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, Expression<Func<string>> dtoRequestV2061SortCsvsortColumn = null, Expression<Func<string>> dtoRequestV2061SortCsvfurtherSortingColumn = null, Expression<Func<bool>> dtoRequestV2061SortCsvreverseOrder = null)
        {
            var apiCallPath = "/V2061_SortCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2061SortCsv = new JObject();
            var dtoRequestV2061SortCsvpropCount = 0;
            dtoRequestV2061SortCsvpropCount++;
            dtoRequestV2061SortCsv["csv"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvcSV);
            if (dtoRequestV2061SortCsvcSVHasHeaders != null)
            {
                if (dtoRequestV2061SortCsvcSVHasHeaders != null)
                {
                    dtoRequestV2061SortCsv["dataIncludesHeader"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvcSVHasHeaders);
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
                    dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvautoDetectFieldTypes);
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
                dtoRequestV2061SortCsv["maxScanRows"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvremoveEmptyRows != null)
            {
                if (dtoRequestV2061SortCsvremoveEmptyRows != null)
                {
                    dtoRequestV2061SortCsv["ignoreEmptyLine"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvremoveEmptyRows);
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
                dtoRequestV2061SortCsv["skip"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvskipANumberOfRows);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvstopAtASpecificRow != null)
            {
                dtoRequestV2061SortCsv["skipLast"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvstopAtASpecificRow);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvseparator != null)
            {
                dtoRequestV2061SortCsv["delimiter"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvseparator);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestV2061SortCsvautoDetectQuoteDelimiter != null)
                {
                    dtoRequestV2061SortCsv["mayHaveQuotedFields"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvautoDetectQuoteDelimiter);
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
                dtoRequestV2061SortCsv["sortColumn"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvsortColumn);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvfurtherSortingColumn != null)
            {
                dtoRequestV2061SortCsv["secondSortColumn"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvfurtherSortingColumn);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvreverseOrder != null)
            {
                if (dtoRequestV2061SortCsvreverseOrder != null)
                {
                    dtoRequestV2061SortCsv["isReverse"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2061SortCsvreverseOrder);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2051SortJson> SortJson(Expression<Func<string>> dtoRequestV2051SortJsonjSON, Expression<Func<string>> dtoRequestV2051SortJsonsortProperty = null, Expression<Func<string>> dtoRequestV2051SortJsonfurtherSortingProperty = null, Expression<Func<bool>> dtoRequestV2051SortJsonreverseOrder = null)
        {
            var apiCallPath = "/V2051_SortJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2051SortJson = new JObject();
            var dtoRequestV2051SortJsonpropCount = 0;
            dtoRequestV2051SortJsonpropCount++;
            dtoRequestV2051SortJson["json"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2051SortJsonjSON);
            if (dtoRequestV2051SortJsonsortProperty != null)
            {
                dtoRequestV2051SortJson["sortProperty"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2051SortJsonsortProperty);
                dtoRequestV2051SortJsonpropCount++;
            }

            if (dtoRequestV2051SortJsonfurtherSortingProperty != null)
            {
                dtoRequestV2051SortJson["secondSortProperty"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2051SortJsonfurtherSortingProperty);
                dtoRequestV2051SortJsonpropCount++;
            }

            if (dtoRequestV2051SortJsonreverseOrder != null)
            {
                if (dtoRequestV2051SortJsonreverseOrder != null)
                {
                    dtoRequestV2051SortJson["isReverse"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2051SortJsonreverseOrder);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2041Translate> Translate(Expression<Func<string>> dtoRequestV2041Translatetext, Expression<Func<string>> dtoRequestV2041Translateto, Expression<Func<string>> dtoRequestV2041Translatefrom = null)
        {
            var apiCallPath = "/V2041_Translate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2041Translate = new JObject();
            var dtoRequestV2041TranslatepropCount = 0;
            dtoRequestV2041TranslatepropCount++;
            dtoRequestV2041Translate["text"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2041Translatetext);
            if (dtoRequestV2041Translatefrom != null)
            {
                dtoRequestV2041Translate["from"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2041Translatefrom);
                dtoRequestV2041TranslatepropCount++;
            }

            dtoRequestV2041TranslatepropCount++;
            dtoRequestV2041Translate["to"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2041Translateto);
            if (dtoRequestV2041TranslatepropCount > 0)
            {
                callPayload.Body = dtoRequestV2041Translate;
            }

            return new ApiConnectionAction<DtoResponseV2041Translate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4051UnProtectPdf> UnProtectPdf(Expression<Func<string>> dtoRequestV4051UnProtectPdffile, Expression<Func<string>> dtoRequestV4051UnProtectPdfownerPassword = null, Expression<Func<bool>> dtoRequestV4051UnProtectPdfremovePermissions = null)
        {
            var apiCallPath = "/V4051_UnProtectPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4051UnProtectPdf = new JObject();
            var dtoRequestV4051UnProtectPdfpropCount = 0;
            dtoRequestV4051UnProtectPdfpropCount++;
            dtoRequestV4051UnProtectPdf["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4051UnProtectPdffile);
            if (dtoRequestV4051UnProtectPdfownerPassword != null)
            {
                dtoRequestV4051UnProtectPdf["ownerPassword"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4051UnProtectPdfownerPassword);
                dtoRequestV4051UnProtectPdfpropCount++;
            }

            if (dtoRequestV4051UnProtectPdfremovePermissions != null)
            {
                dtoRequestV4051UnProtectPdf["removePermissions"] = CSharpExpressionConverter.ConvertToken(dtoRequestV4051UnProtectPdfremovePermissions);
                dtoRequestV4051UnProtectPdfpropCount++;
            }

            if (dtoRequestV4051UnProtectPdfpropCount > 0)
            {
                callPayload.Body = dtoRequestV4051UnProtectPdf;
            }

            return new ApiConnectionAction<DtoResponseV4051UnProtectPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> UpdateMultipleWordContentControls(Expression<Func<string>> dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent, Expression<Func<ContentControl[]>> dtoRequestV5150UpdateMultipleWordContentControlscontentControl)
        {
            var apiCallPath = "/V5150_UpdateMultipleWordContentControls";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5150UpdateMultipleWordContentControls = new JObject();
            var dtoRequestV5150UpdateMultipleWordContentControlspropCount = 0;
            dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
            dtoRequestV5150UpdateMultipleWordContentControls["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5150UpdateMultipleWordContentControlsexistingFileContent);
            dtoRequestV5150UpdateMultipleWordContentControlspropCount++;
            dtoRequestV5150UpdateMultipleWordContentControls["contentControls"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5150UpdateMultipleWordContentControlscontentControl);
            if (dtoRequestV5150UpdateMultipleWordContentControlspropCount > 0)
            {
                callPayload.Body = dtoRequestV5150UpdateMultipleWordContentControls;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> UpdateWordContentControl(Expression<Func<string>> dtoRequestV5140UpdateWordContentControlexistingFileContent, Expression<Func<string>> dtoRequestV5140UpdateWordContentControlname, Expression<Func<string>> dtoRequestV5140UpdateWordContentControlvalue = null)
        {
            var apiCallPath = "/V5140_UpdateWordContentControl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5140UpdateWordContentControl = new JObject();
            var dtoRequestV5140UpdateWordContentControlpropCount = 0;
            dtoRequestV5140UpdateWordContentControlpropCount++;
            dtoRequestV5140UpdateWordContentControl["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5140UpdateWordContentControlexistingFileContent);
            dtoRequestV5140UpdateWordContentControlpropCount++;
            dtoRequestV5140UpdateWordContentControl["name"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5140UpdateWordContentControlname);
            if (dtoRequestV5140UpdateWordContentControlvalue != null)
            {
                dtoRequestV5140UpdateWordContentControl["value"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5140UpdateWordContentControlvalue);
                dtoRequestV5140UpdateWordContentControlpropCount++;
            }

            if (dtoRequestV5140UpdateWordContentControlpropCount > 0)
            {
                callPayload.Body = dtoRequestV5140UpdateWordContentControl;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5130UpdateWordTableOfContents> UpdateWordTableOfContents(Expression<Func<string>> dtoRequestV5130UpdateWordTableOfContentsexistingFileContent)
        {
            var apiCallPath = "/V5130_UpdateWordTableOfContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV5130UpdateWordTableOfContents = new JObject();
            var dtoRequestV5130UpdateWordTableOfContentspropCount = 0;
            dtoRequestV5130UpdateWordTableOfContentspropCount++;
            dtoRequestV5130UpdateWordTableOfContents["file"] = CSharpExpressionConverter.ConvertToken(dtoRequestV5130UpdateWordTableOfContentsexistingFileContent);
            if (dtoRequestV5130UpdateWordTableOfContentspropCount > 0)
            {
                callPayload.Body = dtoRequestV5130UpdateWordTableOfContents;
            }

            return new ApiConnectionAction<DtoResponseV5130UpdateWordTableOfContents>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2031UrlToFile> UrlToFile(Expression<Func<string>> dtoRequestV2031UrlToFileuRL)
        {
            var apiCallPath = "/V2031_UrlToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2031UrlToFile = new JObject();
            var dtoRequestV2031UrlToFilepropCount = 0;
            dtoRequestV2031UrlToFilepropCount++;
            dtoRequestV2031UrlToFile["url"] = CSharpExpressionConverter.ConvertToken(dtoRequestV2031UrlToFileuRL);
            if (dtoRequestV2031UrlToFilepropCount > 0)
            {
                callPayload.Body = dtoRequestV2031UrlToFile;
            }

            return new ApiConnectionAction<DtoResponseV2031UrlToFile>(callPayload);
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