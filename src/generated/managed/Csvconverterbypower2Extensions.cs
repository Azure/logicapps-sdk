//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Csvconverterbypower2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Csvconverterbypower2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A000AV01CV01ConvertAllFormats> T01A000AV01CV01ConvertAllFormats([WorkflowExpression] Func<string> dtoRequestT01A000AV01CV01ConvertAllFormatsinputData, [WorkflowExpression] Func<string> dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat = null, [WorkflowExpression] Func<string> dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats = null)
        {
            SourceExpression.Validate(dtoRequestT01A000AV01CV01ConvertAllFormatsinputData, nameof(dtoRequestT01A000AV01CV01ConvertAllFormatsinputData), required: true);
            SourceExpression.Validate(dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat, nameof(dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat), required: false);
            SourceExpression.Validate(dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats, nameof(dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A000_AV01_CV01_ConvertAllFormats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A000AV01CV01ConvertAllFormats = new JObject();
                var dtoRequestT01A000AV01CV01ConvertAllFormatspropCount = 0;
                dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
                dtoRequestT01A000AV01CV01ConvertAllFormats["inputData"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A000AV01CV01ConvertAllFormatsinputData);
                if (dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat != null)
                {
                    dtoRequestT01A000AV01CV01ConvertAllFormats["inputFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A000AV01CV01ConvertAllFormatsinputFormat);
                    dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
                }

                if (dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats != null)
                {
                    dtoRequestT01A000AV01CV01ConvertAllFormats["outputFormat"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A000AV01CV01ConvertAllFormatsoutputFormats);
                    dtoRequestT01A000AV01CV01ConvertAllFormatspropCount++;
                }

                if (dtoRequestT01A000AV01CV01ConvertAllFormatspropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A000AV01CV01ConvertAllFormats;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A000AV01CV01ConvertAllFormats>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A001AV01CV01ConvertCsvToJson> T01A001AV01CV01ConvertCsvToJson([WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns = null)
        {
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV), required: true);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A001_AV01_CV01_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A001AV01CV01ConvertCsvToJson = new JObject();
                var dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount = 0;
                dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                dtoRequestT01A001AV01CV01ConvertCsvToJson["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSV);
                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonseparator);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectQuoteDelimiter);
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
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsoncSVHasHeaders);
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
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDetectHeaderLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectHeader);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["headerLineIndex"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonheaderRowIndex);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes != null)
                {
                    if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectFieldTypes);
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
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["detectionAccuracy"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsondetectionAccuracy);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["nullValue"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonnullValue);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["skipRows"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonrowsToSkip);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonstopAtRow);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows != null)
                {
                    if (dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows != null)
                    {
                        dtoRequestT01A001AV01CV01ConvertCsvToJson["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonremoveEmptyRows);
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
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["quoteCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonquoteCharacter);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["escapeCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonescapeCharacter);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["autoDetectWrappedLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonautoDetectWrappedLines);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["columnRenames"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonrenameColumns);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns != null)
                {
                    dtoRequestT01A001AV01CV01ConvertCsvToJson["columnsToInclude"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A001AV01CV01ConvertCsvToJsonincludeColumns);
                    dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount++;
                }

                if (dtoRequestT01A001AV01CV01ConvertCsvToJsonpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A001AV01CV01ConvertCsvToJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A001AV01CV01ConvertCsvToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv> T01A002AV01CV01ConvertJsonToCsv([WorkflowExpression] Func<string> dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON)
        {
            SourceExpression.Validate(dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON, nameof(dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A002_AV01_CV01_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A002AV01CV01ConvertJsonToCsv = new JObject();
                var dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount = 0;
                dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount++;
                dtoRequestT01A002AV01CV01ConvertJsonToCsv["json"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A002AV01CV01ConvertJsonToCsvjSON);
                if (dtoRequestT01A002AV01CV01ConvertJsonToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A002AV01CV01ConvertJsonToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel> T01A003AV01CV01ConvertCsvToExcel([WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent = null, [WorkflowExpression] Func<bool> dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText = null, [WorkflowExpression] Func<int> dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth = null)
        {
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV), required: true);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText), required: false);
            SourceExpression.Validate(dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A003_AV01_CV01_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A003AV01CV01ConvertCsvToExcel = new JObject();
                var dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount = 0;
                dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                dtoRequestT01A003AV01CV01ConvertCsvToExcel["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSV);
                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelseparator);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectQuoteDelimiter);
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
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelcSVHasHeaders);
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
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDetectHeaderLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectHeader);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["headerLineIndex"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelheaderRowIndex);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes != null)
                {
                    if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectFieldTypes);
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
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["detectionAccuracy"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExceldetectionAccuracy);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["nullValue"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelnullValue);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["skipRows"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelrowsToSkip);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelstopAtRow);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows != null)
                {
                    if (dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelremoveEmptyRows);
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
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["quoteCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelquoteCharacter);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["escapeCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelescapeCharacter);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["autoDetectWrappedLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelautoDetectWrappedLines);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["columnRenames"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelrenameColumns);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns != null)
                {
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["columnsToInclude"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelincludeColumns);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent != null)
                {
                    if (dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent != null)
                    {
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["adjustColumnToContent"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExceladjustExcelColumnToContent);
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
                        dtoRequestT01A003AV01CV01ConvertCsvToExcel["wrapColumnText"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelwrapExcelColumnText);
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
                    dtoRequestT01A003AV01CV01ConvertCsvToExcel["maxColumnWidth"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A003AV01CV01ConvertCsvToExcelmaxExcelColumnWidth);
                    dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount++;
                }

                if (dtoRequestT01A003AV01CV01ConvertCsvToExcelpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A003AV01CV01ConvertCsvToExcel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv> T01A004AV01CV01ConvertExcelToCsv([WorkflowExpression] Func<string> dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile)
        {
            SourceExpression.Validate(dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile, nameof(dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A004_AV01_CV01_ConvertExcelToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A004AV01CV01ConvertExcelToCsv = new JObject();
                var dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount = 0;
                dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount++;
                dtoRequestT01A004AV01CV01ConvertExcelToCsv["excel"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A004AV01CV01ConvertExcelToCsvexcelFile);
                if (dtoRequestT01A004AV01CV01ConvertExcelToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A004AV01CV01ConvertExcelToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml> T01A005AV01CV01ConvertCsvToHtml([WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns = null)
        {
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV), required: true);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A005_AV01_CV01_ConvertCsvToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A005AV01CV01ConvertCsvToHtml = new JObject();
                var dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount = 0;
                dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                dtoRequestT01A005AV01CV01ConvertCsvToHtml["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSV);
                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlseparator);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectQuoteDelimiter);
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
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlcSVHasHeaders);
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
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDetectHeaderLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectHeader);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["headerLineIndex"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlheaderRowIndex);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes != null)
                {
                    if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectFieldTypes);
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
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["detectionAccuracy"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmldetectionAccuracy);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["nullValue"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlnullValue);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["skipRows"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrowsToSkip);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlstopAtRow);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows != null)
                {
                    if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows != null)
                    {
                        dtoRequestT01A005AV01CV01ConvertCsvToHtml["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlremoveEmptyRows);
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
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["quoteCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlquoteCharacter);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["escapeCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlescapeCharacter);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["autoDetectWrappedLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlautoDetectWrappedLines);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["columnRenames"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlrenameColumns);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns != null)
                {
                    dtoRequestT01A005AV01CV01ConvertCsvToHtml["columnsToInclude"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A005AV01CV01ConvertCsvToHtmlincludeColumns);
                    dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount++;
                }

                if (dtoRequestT01A005AV01CV01ConvertCsvToHtmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A005AV01CV01ConvertCsvToHtml;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv> T01A006AV01CV01ConvertHtmlToCsv([WorkflowExpression] Func<string> dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable)
        {
            SourceExpression.Validate(dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable, nameof(dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A006_AV01_CV01_ConvertHtmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A006AV01CV01ConvertHtmlToCsv = new JObject();
                var dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount = 0;
                dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount++;
                dtoRequestT01A006AV01CV01ConvertHtmlToCsv["html"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A006AV01CV01ConvertHtmlToCsvhTMLTable);
                if (dtoRequestT01A006AV01CV01ConvertHtmlToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A006AV01CV01ConvertHtmlToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A007AV01CV01ConvertCsvToXml> T01A007AV01CV01ConvertCsvToXml([WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns = null)
        {
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV), required: true);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A007_AV01_CV01_ConvertCsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A007AV01CV01ConvertCsvToXml = new JObject();
                var dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount = 0;
                dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                dtoRequestT01A007AV01CV01ConvertCsvToXml["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSV);
                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlseparator);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectQuoteDelimiter);
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
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlcSVHasHeaders);
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
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDetectHeaderLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectHeader);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["headerLineIndex"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlheaderRowIndex);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes != null)
                {
                    if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectFieldTypes);
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
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["detectionAccuracy"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmldetectionAccuracy);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["nullValue"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlnullValue);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["skipRows"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlrowsToSkip);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlstopAtRow);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows != null)
                {
                    if (dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows != null)
                    {
                        dtoRequestT01A007AV01CV01ConvertCsvToXml["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlremoveEmptyRows);
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
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["quoteCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlquoteCharacter);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["escapeCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlescapeCharacter);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["autoDetectWrappedLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlautoDetectWrappedLines);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["columnRenames"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlrenameColumns);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns != null)
                {
                    dtoRequestT01A007AV01CV01ConvertCsvToXml["columnsToInclude"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A007AV01CV01ConvertCsvToXmlincludeColumns);
                    dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount++;
                }

                if (dtoRequestT01A007AV01CV01ConvertCsvToXmlpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A007AV01CV01ConvertCsvToXml;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A007AV01CV01ConvertCsvToXml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv> T01A008AV01CV01ConvertXmlToCsv([WorkflowExpression] Func<string> dtoRequestT01A008AV01CV01ConvertXmlToCsvxML)
        {
            SourceExpression.Validate(dtoRequestT01A008AV01CV01ConvertXmlToCsvxML, nameof(dtoRequestT01A008AV01CV01ConvertXmlToCsvxML), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A008_AV01_CV01_ConvertXmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A008AV01CV01ConvertXmlToCsv = new JObject();
                var dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount = 0;
                dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount++;
                dtoRequestT01A008AV01CV01ConvertXmlToCsv["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A008AV01CV01ConvertXmlToCsvxML);
                if (dtoRequestT01A008AV01CV01ConvertXmlToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A008AV01CV01ConvertXmlToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml> T01A009AV01CV01ConvertCsvToYaml([WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns = null)
        {
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV), required: true);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A009_AV01_CV01_ConvertCsvToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A009AV01CV01ConvertCsvToYaml = new JObject();
                var dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount = 0;
                dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                dtoRequestT01A009AV01CV01ConvertCsvToYaml["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSV);
                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlseparator);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectQuoteDelimiter);
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
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlcSVHasHeaders);
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
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDetectHeaderLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectHeader);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["headerLineIndex"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlheaderRowIndex);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes != null)
                {
                    if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectFieldTypes);
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
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["detectionAccuracy"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamldetectionAccuracy);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["nullValue"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlnullValue);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["skipRows"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlrowsToSkip);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlstopAtRow);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows != null)
                {
                    if (dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows != null)
                    {
                        dtoRequestT01A009AV01CV01ConvertCsvToYaml["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlremoveEmptyRows);
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
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["quoteCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlquoteCharacter);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["escapeCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlescapeCharacter);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["autoDetectWrappedLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlautoDetectWrappedLines);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["columnRenames"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlrenameColumns);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns != null)
                {
                    dtoRequestT01A009AV01CV01ConvertCsvToYaml["columnsToInclude"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A009AV01CV01ConvertCsvToYamlincludeColumns);
                    dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount++;
                }

                if (dtoRequestT01A009AV01CV01ConvertCsvToYamlpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A009AV01CV01ConvertCsvToYaml;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv> T01A010AV01CV01ConvertYamlToCsv([WorkflowExpression] Func<string> dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML)
        {
            SourceExpression.Validate(dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML, nameof(dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A010_AV01_CV01_ConvertYamlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A010AV01CV01ConvertYamlToCsv = new JObject();
                var dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount = 0;
                dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount++;
                dtoRequestT01A010AV01CV01ConvertYamlToCsv["yaml"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A010AV01CV01ConvertYamlToCsvyAML);
                if (dtoRequestT01A010AV01CV01ConvertYamlToCsvpropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A010AV01CV01ConvertYamlToCsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable> T01A011AV01CV01ConvertCsvToTextTable([WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader = null, [WorkflowExpression] Func<int> dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip = null, [WorkflowExpression] Func<int> dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter = null, [WorkflowExpression] Func<bool> dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns = null, [WorkflowExpression] Func<string> dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns = null)
        {
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV), required: true);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns), required: false);
            SourceExpression.Validate(dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A011_AV01_CV01_ConvertCsvToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT01A011AV01CV01ConvertCsvToTextTable = new JObject();
                var dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount = 0;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                dtoRequestT01A011AV01CV01ConvertCsvToTextTable["csv"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSV);
                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["delimiter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableseparator);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter != null)
                {
                    if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["mayHaveQuotedFields"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectQuoteDelimiter);
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
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["hasHeader"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablecSVHasHeaders);
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
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDetectHeaderLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectHeader);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["headerLineIndex"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableheaderRowIndex);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes != null)
                {
                    if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDiscoverFieldTypes"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectFieldTypes);
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
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["detectionAccuracy"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTabledetectionAccuracy);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["nullValue"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablenullValue);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["skipRows"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerowsToSkip);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["skipLast"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablestopAtRow);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows != null)
                {
                    if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows != null)
                    {
                        dtoRequestT01A011AV01CV01ConvertCsvToTextTable["ignoreEmptyLine"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableremoveEmptyRows);
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
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["quoteCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablequoteCharacter);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["escapeCharacter"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableescapeCharacter);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["autoDetectWrappedLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableautoDetectWrappedLines);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["columnRenames"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTablerenameColumns);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns != null)
                {
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTable["columnsToInclude"] = SourceExpressionConverter.ConvertToken(dtoRequestT01A011AV01CV01ConvertCsvToTextTableincludeColumns);
                    dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount++;
                }

                if (dtoRequestT01A011AV01CV01ConvertCsvToTextTablepropCount > 0)
                {
                    callPayload.Body = dtoRequestT01A011AV01CV01ConvertCsvToTextTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable>(BuildSourceInput);
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