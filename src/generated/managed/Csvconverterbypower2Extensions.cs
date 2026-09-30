//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Csvconverterbypower2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Csvconverterbypower2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A000AV01CV01ConvertAllFormats> T01A000AV01CV01ConvertAllFormats([WorkflowExpression] Func<string> dtoRequestT01A000AV01CV01ConvertAllFormatsinputData, [WorkflowExpression] Func<string> dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat = null, [WorkflowExpression] Func<string> dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A000_AV01_CV01_ConvertAllFormats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A000AV01CV01ConvertAllFormats = new JObject();
            var dtoRequestT01A000AV01CV01ConvertAllFormatspropCount = 0;
            dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
            dtoRequestT01A000AV01CV01ConvertAllFormats["inputData"] = ExpressionConverter.ConvertO(dtoRequestT01A000AV01CV01ConvertAllFormatsinputData);
            if (dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat != null)
            {
                dtoRequestT01A000AV01CV01ConvertAllFormats["inputFormat"] = ExpressionConverter.ConvertO(dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat);
                dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
            }

            if (dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats != null)
            {
                dtoRequestT01A000AV01CV01ConvertAllFormats["outputFormat"] = ExpressionConverter.ConvertO(dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats);
                dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
            }

            if (dtoRequestT01A000AV01CV01ConvertAllFormatspropCount > 0)
            {
                callPayload.Body = dtoRequestT01A000AV01CV01ConvertAllFormats;
            }

            return new ApiConnectionAction<DtoResponseT01A000AV01CV01ConvertAllFormats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A001AV01CV01ConvertCsvToJson> T01A001AV01CV01ConvertCsvToJson([WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A001_AV01_CV01_ConvertCsvToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A001AV01CV01ConvertCsvToJson = new JObject();
            var dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount = 0;
            dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            dtoRequestT01A001AV01CV01ConvertCsvToJson["csv"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV);
            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["delimiter"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }
            else
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["mayHaveQuotedFields"] = true;
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders != null)
            {
                if (dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }
            else
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["hasHeader"] = true;
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["headerLineIndex"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes != null)
            {
                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }
            else
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDiscoverFieldTypes"] = false;
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["detectionAccuracy"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["nullValue"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["skipRows"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["skipLast"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows != null)
            {
                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }
            else
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["ignoreEmptyLine"] = true;
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["quoteCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["escapeCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["columnRenames"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns != null)
            {
                dtoRequestT01A001AV01CV01ConvertCsvToJson["columnsToInclude"] = ExpressionConverter.ConvertO(dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns);
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A001AV01CV01ConvertCsvToJson;
            }

            return new ApiConnectionAction<DtoResponseT01A001AV01CV01ConvertCsvToJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv> T01A002AV01CV01ConvertJsonToCsv([WorkflowExpression] Func<string> dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A002_AV01_CV01_ConvertJsonToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A002AV01CV01ConvertJsonToCsv = new JObject();
            var dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount = 0;
            dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount++;
            dtoRequestT01A002AV01CV01ConvertJsonToCsv["json"] = ExpressionConverter.ConvertO(dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON);
            if (dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A002AV01CV01ConvertJsonToCsv;
            }

            return new ApiConnectionAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel> T01A003AV01CV01ConvertCsvToExcel([WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A003_AV01_CV01_ConvertCsvToExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A003AV01CV01ConvertCsvToExcel = new JObject();
            var dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount = 0;
            dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            dtoRequestT01A003AV01CV01ConvertCsvToExcel["csv"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV);
            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["delimiter"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }
            else
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["mayHaveQuotedFields"] = true;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders != null)
            {
                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }
            else
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["hasHeader"] = true;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["headerLineIndex"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes != null)
            {
                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }
            else
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDiscoverFieldTypes"] = false;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["detectionAccuracy"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["nullValue"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["skipRows"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["skipLast"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows != null)
            {
                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }
            else
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["ignoreEmptyLine"] = true;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["quoteCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["escapeCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["columnRenames"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["columnsToInclude"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent != null)
            {
                if (dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["adjustColumnToContent"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }
            else
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["adjustColumnToContent"] = true;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText != null)
            {
                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["wrapColumnText"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }
            else
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["wrapColumnText"] = false;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth != null)
            {
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["maxColumnWidth"] = ExpressionConverter.ConvertO(dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth);
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A003AV01CV01ConvertCsvToExcel;
            }

            return new ApiConnectionAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv> T01A004AV01CV01ConvertExcelToCsv([WorkflowExpression] Func<string> dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A004_AV01_CV01_ConvertExcelToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A004AV01CV01ConvertExcelToCsv = new JObject();
            var dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount = 0;
            dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount++;
            dtoRequestT01A004AV01CV01ConvertExcelToCsv["excel"] = ExpressionConverter.ConvertO(dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile);
            if (dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A004AV01CV01ConvertExcelToCsv;
            }

            return new ApiConnectionAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml> T01A005AV01CV01ConvertCsvToHtml([WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A005_AV01_CV01_ConvertCsvToHtml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A005AV01CV01ConvertCsvToHtml = new JObject();
            var dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount = 0;
            dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            dtoRequestT01A005AV01CV01ConvertCsvToHtml["csv"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV);
            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["delimiter"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }
            else
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["mayHaveQuotedFields"] = true;
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders != null)
            {
                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }
            else
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["hasHeader"] = true;
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["headerLineIndex"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes != null)
            {
                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }
            else
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDiscoverFieldTypes"] = false;
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["detectionAccuracy"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["nullValue"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["skipRows"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["skipLast"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows != null)
            {
                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }
            else
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["ignoreEmptyLine"] = true;
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["quoteCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["escapeCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["columnRenames"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns != null)
            {
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["columnsToInclude"] = ExpressionConverter.ConvertO(dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns);
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
            }

            if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A005AV01CV01ConvertCsvToHtml;
            }

            return new ApiConnectionAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv> T01A006AV01CV01ConvertHtmlToCsv([WorkflowExpression] Func<string> dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A006_AV01_CV01_ConvertHtmlToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A006AV01CV01ConvertHtmlToCsv = new JObject();
            var dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount = 0;
            dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount++;
            dtoRequestT01A006AV01CV01ConvertHtmlToCsv["html"] = ExpressionConverter.ConvertO(dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable);
            if (dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A006AV01CV01ConvertHtmlToCsv;
            }

            return new ApiConnectionAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A007AV01CV01ConvertCsvToXml> T01A007AV01CV01ConvertCsvToXml([WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A007_AV01_CV01_ConvertCsvToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A007AV01CV01ConvertCsvToXml = new JObject();
            var dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount = 0;
            dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            dtoRequestT01A007AV01CV01ConvertCsvToXml["csv"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV);
            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["delimiter"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }
            else
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["mayHaveQuotedFields"] = true;
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders != null)
            {
                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }
            else
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["hasHeader"] = true;
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["headerLineIndex"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes != null)
            {
                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }
            else
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDiscoverFieldTypes"] = false;
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["detectionAccuracy"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["nullValue"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["skipRows"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["skipLast"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows != null)
            {
                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }
            else
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["ignoreEmptyLine"] = true;
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["quoteCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["escapeCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["columnRenames"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns != null)
            {
                dtoRequestT01A007AV01CV01ConvertCsvToXml["columnsToInclude"] = ExpressionConverter.ConvertO(dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns);
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
            }

            if (dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A007AV01CV01ConvertCsvToXml;
            }

            return new ApiConnectionAction<DtoResponseT01A007AV01CV01ConvertCsvToXml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv> T01A008AV01CV01ConvertXmlToCsv([WorkflowExpression] Func<string> dtoRequestT01A008AV01CV01ConvertXmlToCsvxML)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A008_AV01_CV01_ConvertXmlToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A008AV01CV01ConvertXmlToCsv = new JObject();
            var dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount = 0;
            dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount++;
            dtoRequestT01A008AV01CV01ConvertXmlToCsv["xml"] = ExpressionConverter.ConvertO(dtoRequestT01A008AV01CV01ConvertXmlToCsvxML);
            if (dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A008AV01CV01ConvertXmlToCsv;
            }

            return new ApiConnectionAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml> T01A009AV01CV01ConvertCsvToYaml([WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A009_AV01_CV01_ConvertCsvToYaml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A009AV01CV01ConvertCsvToYaml = new JObject();
            var dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount = 0;
            dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            dtoRequestT01A009AV01CV01ConvertCsvToYaml["csv"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV);
            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["delimiter"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }
            else
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["mayHaveQuotedFields"] = true;
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders != null)
            {
                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }
            else
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["hasHeader"] = true;
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["headerLineIndex"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes != null)
            {
                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }
            else
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDiscoverFieldTypes"] = false;
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["detectionAccuracy"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["nullValue"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["skipRows"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["skipLast"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows != null)
            {
                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }
            else
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["ignoreEmptyLine"] = true;
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["quoteCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["escapeCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["columnRenames"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns != null)
            {
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["columnsToInclude"] = ExpressionConverter.ConvertO(dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns);
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
            }

            if (dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A009AV01CV01ConvertCsvToYaml;
            }

            return new ApiConnectionAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv> T01A010AV01CV01ConvertYamlToCsv([WorkflowExpression] Func<string> dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A010_AV01_CV01_ConvertYamlToCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A010AV01CV01ConvertYamlToCsv = new JObject();
            var dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount = 0;
            dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount++;
            dtoRequestT01A010AV01CV01ConvertYamlToCsv["yaml"] = ExpressionConverter.ConvertO(dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML);
            if (dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestT01A010AV01CV01ConvertYamlToCsv;
            }

            return new ApiConnectionAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable> T01A011AV01CV01ConvertCsvToTextTable([WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns = null)
        {
            var apiCallPath = "/api/T01_Csv/V01/T01_A011_AV01_CV01_ConvertCsvToTextTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestT01A011AV01CV01ConvertCsvToTextTable = new JObject();
            var dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount = 0;
            dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            dtoRequestT01A011AV01CV01ConvertCsvToTextTable["csv"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV);
            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["delimiter"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter != null)
            {
                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }
            else
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["mayHaveQuotedFields"] = true;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders != null)
            {
                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }
            else
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["hasHeader"] = true;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["headerLineIndex"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes != null)
            {
                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }
            else
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDiscoverFieldTypes"] = false;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["detectionAccuracy"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["nullValue"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["skipRows"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["skipLast"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows != null)
            {
                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }
            else
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["ignoreEmptyLine"] = true;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["quoteCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["escapeCharacter"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["columnRenames"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns != null)
            {
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["columnsToInclude"] = ExpressionConverter.ConvertO(dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns);
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
            }

            if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount > 0)
            {
                callPayload.Body = dtoRequestT01A011AV01CV01ConvertCsvToTextTable;
            }

            return new ApiConnectionAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable>(callPayload);
        }
    }

    public class Csvconverterbypower2Triggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseT01A000AV01CV01ConvertAllFormats
    {
        [JsonProperty("detectedFormat")]
        public string DetectedFormat { get; set; }

        [JsonProperty("json")]
        public string JSONResult { get; set; }

        [JsonProperty("xml")]
        public string XMLResult { get; set; }

        [JsonProperty("yaml")]
        public string YAMLResult { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVResult { get; set; }

        [JsonProperty("csv")]
        public string[] CSVResult { get; set; }

        [JsonProperty("firstHtmlTable")]
        public string FirstHTMLTableResult { get; set; }

        [JsonProperty("htmlTable")]
        public string[] HTMLResult { get; set; }

        [JsonProperty("firstTextTable")]
        public string FirstTextTableResult { get; set; }

        [JsonProperty("textTable")]
        public string[] TextTableResult { get; set; }

        [JsonProperty("excel")]
        public string ExcelResult { get; set; }
    }

    public class DtoResponseT01A001AV01CV01ConvertCsvToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseT01A002AV01CV01ConvertJsonToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class DtoResponseT01A003AV01CV01ConvertCsvToExcel
    {
        [JsonProperty("excel")]
        public string ExcelResponse { get; set; }
    }

    public class DtoResponseT01A004AV01CV01ConvertExcelToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class DtoResponseT01A005AV01CV01ConvertCsvToHtml
    {
        [JsonProperty("html")]
        public string HTMLResponse { get; set; }

        [JsonProperty("htmlTables")]
        public string[] HTMLTableList { get; set; }

        [JsonProperty("firstHtmlTable")]
        public string FirstHTMLTable { get; set; }
    }

    public class DtoResponseT01A006AV01CV01ConvertHtmlToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class DtoResponseT01A007AV01CV01ConvertCsvToXml
    {
        [JsonProperty("xml")]
        public string XMLResponse { get; set; }
    }

    public class DtoResponseT01A008AV01CV01ConvertXmlToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class DtoResponseT01A009AV01CV01ConvertCsvToYaml
    {
        [JsonProperty("yaml")]
        public string YAMLResponse { get; set; }
    }

    public class DtoResponseT01A010AV01CV01ConvertYamlToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class DtoResponseT01A011AV01CV01ConvertCsvToTextTable
    {
        [JsonProperty("textTables")]
        public string[] TextTableList { get; set; }

        [JsonProperty("firstTextTable")]
        public string FirstTextTable { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Csvconverterbypower2;

    public partial class WorkflowManagedActions
    {
        public Csvconverterbypower2Actions Csvconverterbypower2(string connectionId) => new Csvconverterbypower2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Csvconverterbypower2Triggers Csvconverterbypower2(string connectionId) => new Csvconverterbypower2Triggers(connectionId);
    }
}