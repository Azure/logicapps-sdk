//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Csvconverterbypower2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Csvconverterbypower2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A000AV01CV01ConvertAllFormats> T01A000AV01CV01ConvertAllFormats(Expression<Func<string>> dtoRequestT01A000AV01CV01ConvertAllFormatsinputData, Expression<Func<string>> dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat = null, Expression<Func<string>> dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats = null)
        {
            var __workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsinputData = WorkflowExpression.Compile(dtoRequestT01A000AV01CV01ConvertAllFormatsinputData, nameof(dtoRequestT01A000AV01CV01ConvertAllFormatsinputData), required: true);
            var __workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat = WorkflowExpression.Compile(dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat, nameof(dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat), required: false);
            var __workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats = WorkflowExpression.Compile(dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats, nameof(dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats), required: false);
            return new DeferredBodyAction<DtoResponseT01A000AV01CV01ConvertAllFormats>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A000_AV01_CV01_ConvertAllFormats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A000AV01CV01ConvertAllFormats = new JObject();
                var dtoRequestT01A000AV01CV01ConvertAllFormatspropCount = 0;
                dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
                dtoRequestT01A000AV01CV01ConvertAllFormats["inputData"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsinputData);
                if (__workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat != null)
                {
                    dtoRequestT01A000AV01CV01ConvertAllFormats["inputFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat);
                    dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
                }

                if (__workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats != null)
                {
                    dtoRequestT01A000AV01CV01ConvertAllFormats["outputFormat"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats);
                    dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
                }

                if (dtoRequestT01A000AV01CV01ConvertAllFormatspropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A000AV01CV01ConvertAllFormats;
                }

                return new ApiConnectionAction<DtoResponseT01A000AV01CV01ConvertAllFormats>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A001AV01CV01ConvertCsvToJson> T01A001AV01CV01ConvertCsvToJson(Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator = null, Expression<Func<bool>> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders = null, Expression<Func<bool>> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader = null, Expression<Func<int>> dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex = null, Expression<Func<bool>> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip = null, Expression<Func<int>> dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow = null, Expression<Func<bool>> dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter = null, Expression<Func<bool>> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns = null, Expression<Func<string>> dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns = null)
        {
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV), required: true);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns), required: false);
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns), required: false);
            return new DeferredBodyAction<DtoResponseT01A001AV01CV01ConvertCsvToJson>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A001_AV01_CV01_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A001AV01CV01ConvertCsvToJson = new JObject();
                var dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount = 0;
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                dtoRequestT01A001AV01CV01ConvertCsvToJson["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV);
                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter);
                        dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["mayHaveQuotedFields"] = true;
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders);
                        dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["hasHeader"] = true;
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["headerLineIndex"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes);
                        dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDiscoverFieldTypes"] = false;
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["detectionAccuracy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["nullValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["skipRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows);
                        dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                    }

                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }
                else
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["ignoreEmptyLine"] = true;
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["quoteCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["columnRenames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["columnsToInclude"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A001AV01CV01ConvertCsvToJson;
                }

                return new ApiConnectionAction<DtoResponseT01A001AV01CV01ConvertCsvToJson>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv> T01A002AV01CV01ConvertJsonToCsv(Expression<Func<string>> dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON)
        {
            var __workflow_dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON = WorkflowExpression.Compile(dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON, nameof(dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON), required: true);
            return new DeferredBodyAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A002_AV01_CV01_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A002AV01CV01ConvertJsonToCsv = new JObject();
                var dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount = 0;
                dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount++;
                dtoRequestT01A002AV01CV01ConvertJsonToCsv["json"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON);
                if (dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A002AV01CV01ConvertJsonToCsv;
                }

                return new ApiConnectionAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel> T01A003AV01CV01ConvertCsvToExcel(Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader = null, Expression<Func<int>> dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip = null, Expression<Func<int>> dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns = null, Expression<Func<string>> dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent = null, Expression<Func<bool>> dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText = null, Expression<Func<int>> dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV), required: true);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText), required: false);
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth), required: false);
            return new DeferredBodyAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A003_AV01_CV01_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A003AV01CV01ConvertCsvToExcel = new JObject();
                var dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount = 0;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV);
                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter);
                        dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["mayHaveQuotedFields"] = true;
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders);
                        dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["hasHeader"] = true;
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["headerLineIndex"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes);
                        dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDiscoverFieldTypes"] = false;
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["detectionAccuracy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["nullValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["skipRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows);
                        dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["ignoreEmptyLine"] = true;
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["quoteCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["columnRenames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["columnsToInclude"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent != null)
                {
                    if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["adjustColumnToContent"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent);
                        dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["adjustColumnToContent"] = true;
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText != null)
                {
                    if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["wrapColumnText"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText);
                        dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                    }

                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }
                else
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["wrapColumnText"] = false;
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["maxColumnWidth"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A003AV01CV01ConvertCsvToExcel;
                }

                return new ApiConnectionAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv> T01A004AV01CV01ConvertExcelToCsv(Expression<Func<string>> dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile)
        {
            var __workflow_dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile = WorkflowExpression.Compile(dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile, nameof(dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile), required: true);
            return new DeferredBodyAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A004_AV01_CV01_ConvertExcelToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A004AV01CV01ConvertExcelToCsv = new JObject();
                var dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount = 0;
                dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount++;
                dtoRequestT01A004AV01CV01ConvertExcelToCsv["excel"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile);
                if (dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A004AV01CV01ConvertExcelToCsv;
                }

                return new ApiConnectionAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml> T01A005AV01CV01ConvertCsvToHtml(Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator = null, Expression<Func<bool>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders = null, Expression<Func<bool>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader = null, Expression<Func<int>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex = null, Expression<Func<bool>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip = null, Expression<Func<int>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow = null, Expression<Func<bool>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter = null, Expression<Func<bool>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns = null, Expression<Func<string>> dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns = null)
        {
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV), required: true);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns), required: false);
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns), required: false);
            return new DeferredBodyAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A005_AV01_CV01_ConvertCsvToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A005AV01CV01ConvertCsvToHtml = new JObject();
                var dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount = 0;
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV);
                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter);
                        dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                    }

                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }
                else
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["mayHaveQuotedFields"] = true;
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders);
                        dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                    }

                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }
                else
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["hasHeader"] = true;
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["headerLineIndex"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes);
                        dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                    }

                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }
                else
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDiscoverFieldTypes"] = false;
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["detectionAccuracy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["nullValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["skipRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows);
                        dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                    }

                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }
                else
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["ignoreEmptyLine"] = true;
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["quoteCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["columnRenames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["columnsToInclude"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A005AV01CV01ConvertCsvToHtml;
                }

                return new ApiConnectionAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv> T01A006AV01CV01ConvertHtmlToCsv(Expression<Func<string>> dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable)
        {
            var __workflow_dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable = WorkflowExpression.Compile(dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable, nameof(dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable), required: true);
            return new DeferredBodyAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A006_AV01_CV01_ConvertHtmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A006AV01CV01ConvertHtmlToCsv = new JObject();
                var dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount = 0;
                dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount++;
                dtoRequestT01A006AV01CV01ConvertHtmlToCsv["html"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable);
                if (dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A006AV01CV01ConvertHtmlToCsv;
                }

                return new ApiConnectionAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A007AV01CV01ConvertCsvToXml> T01A007AV01CV01ConvertCsvToXml(Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator = null, Expression<Func<bool>> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders = null, Expression<Func<bool>> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader = null, Expression<Func<int>> dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex = null, Expression<Func<bool>> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip = null, Expression<Func<int>> dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow = null, Expression<Func<bool>> dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter = null, Expression<Func<bool>> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns = null, Expression<Func<string>> dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns = null)
        {
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV), required: true);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns), required: false);
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns), required: false);
            return new DeferredBodyAction<DtoResponseT01A007AV01CV01ConvertCsvToXml>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A007_AV01_CV01_ConvertCsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A007AV01CV01ConvertCsvToXml = new JObject();
                var dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount = 0;
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                dtoRequestT01A007AV01CV01ConvertCsvToXml["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV);
                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter);
                        dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                    }

                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }
                else
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["mayHaveQuotedFields"] = true;
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders);
                        dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                    }

                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }
                else
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["hasHeader"] = true;
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["headerLineIndex"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes);
                        dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                    }

                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }
                else
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDiscoverFieldTypes"] = false;
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["detectionAccuracy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["nullValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["skipRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows);
                        dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                    }

                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }
                else
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["ignoreEmptyLine"] = true;
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["quoteCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["columnRenames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["columnsToInclude"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A007AV01CV01ConvertCsvToXml;
                }

                return new ApiConnectionAction<DtoResponseT01A007AV01CV01ConvertCsvToXml>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv> T01A008AV01CV01ConvertXmlToCsv(Expression<Func<string>> dtoRequestT01A008AV01CV01ConvertXmlToCsvxML)
        {
            var __workflow_dtoRequestT01A008AV01CV01ConvertXmlToCsvxML = WorkflowExpression.Compile(dtoRequestT01A008AV01CV01ConvertXmlToCsvxML, nameof(dtoRequestT01A008AV01CV01ConvertXmlToCsvxML), required: true);
            return new DeferredBodyAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A008_AV01_CV01_ConvertXmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A008AV01CV01ConvertXmlToCsv = new JObject();
                var dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount = 0;
                dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount++;
                dtoRequestT01A008AV01CV01ConvertXmlToCsv["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A008AV01CV01ConvertXmlToCsvxML);
                if (dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A008AV01CV01ConvertXmlToCsv;
                }

                return new ApiConnectionAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml> T01A009AV01CV01ConvertCsvToYaml(Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator = null, Expression<Func<bool>> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders = null, Expression<Func<bool>> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader = null, Expression<Func<int>> dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex = null, Expression<Func<bool>> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip = null, Expression<Func<int>> dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow = null, Expression<Func<bool>> dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter = null, Expression<Func<bool>> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns = null, Expression<Func<string>> dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns = null)
        {
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV), required: true);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns), required: false);
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns), required: false);
            return new DeferredBodyAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A009_AV01_CV01_ConvertCsvToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A009AV01CV01ConvertCsvToYaml = new JObject();
                var dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount = 0;
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV);
                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter);
                        dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                    }

                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }
                else
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["mayHaveQuotedFields"] = true;
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders);
                        dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                    }

                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }
                else
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["hasHeader"] = true;
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["headerLineIndex"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes);
                        dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                    }

                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }
                else
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDiscoverFieldTypes"] = false;
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["detectionAccuracy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["nullValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["skipRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows);
                        dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                    }

                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }
                else
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["ignoreEmptyLine"] = true;
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["quoteCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["columnRenames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["columnsToInclude"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A009AV01CV01ConvertCsvToYaml;
                }

                return new ApiConnectionAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv> T01A010AV01CV01ConvertYamlToCsv(Expression<Func<string>> dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML)
        {
            var __workflow_dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML = WorkflowExpression.Compile(dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML, nameof(dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML), required: true);
            return new DeferredBodyAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A010_AV01_CV01_ConvertYamlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A010AV01CV01ConvertYamlToCsv = new JObject();
                var dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount = 0;
                dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount++;
                dtoRequestT01A010AV01CV01ConvertYamlToCsv["yaml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML);
                if (dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A010AV01CV01ConvertYamlToCsv;
                }

                return new ApiConnectionAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable> T01A011AV01CV01ConvertCsvToTextTable(Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator = null, Expression<Func<bool>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter = null, Expression<Func<bool>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders = null, Expression<Func<bool>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader = null, Expression<Func<int>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex = null, Expression<Func<bool>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip = null, Expression<Func<int>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow = null, Expression<Func<bool>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter = null, Expression<Func<bool>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns = null, Expression<Func<string>> dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns = null)
        {
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV), required: true);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns), required: false);
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns), required: false);
            return new DeferredBodyAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A011_AV01_CV01_ConvertCsvToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A011AV01CV01ConvertCsvToTextTable = new JObject();
                var dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount = 0;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["csv"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV);
                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["delimiter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter != null)
                {
                    if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter);
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                    }

                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }
                else
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["mayHaveQuotedFields"] = true;
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders != null)
                {
                    if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["hasHeader"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders);
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                    }

                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }
                else
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["hasHeader"] = true;
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDetectHeaderLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["headerLineIndex"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes != null)
                {
                    if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes);
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                    }

                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }
                else
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDiscoverFieldTypes"] = false;
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["detectionAccuracy"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["nullValue"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["skipRows"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["skipLast"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows != null)
                {
                    if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["ignoreEmptyLine"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows);
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                    }

                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }
                else
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["ignoreEmptyLine"] = true;
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["quoteCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["escapeCharacter"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDetectWrappedLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["columnRenames"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["columnsToInclude"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A011AV01CV01ConvertCsvToTextTable;
                }

                return new ApiConnectionAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
