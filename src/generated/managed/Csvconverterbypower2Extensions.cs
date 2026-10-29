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
        public IBodyWorkflowAction<DtoResponseT01A000AV01CV01ConvertAllFormats, ApiConnectionActionConfiguration> T01A000AV01CV01ConvertAllFormats(Expression<Func<T01A000AV01CV01ConvertAllFormatsInput>> dtoRequestT01A000AV01CV01ConvertAllFormats)
        {
            var __workflow_dtoRequestT01A000AV01CV01ConvertAllFormats = WorkflowExpression.Compile(dtoRequestT01A000AV01CV01ConvertAllFormats, nameof(dtoRequestT01A000AV01CV01ConvertAllFormats), required: true);
            return new DeferredBodyAction<DtoResponseT01A000AV01CV01ConvertAllFormats, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A000_AV01_CV01_ConvertAllFormats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A000AV01CV01ConvertAllFormats);
                return new ApiConnectionAction<DtoResponseT01A000AV01CV01ConvertAllFormats>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A001AV01CV01ConvertCsvToJson, ApiConnectionActionConfiguration> T01A001AV01CV01ConvertCsvToJson(Expression<Func<T01A001AV01CV01ConvertCsvToJsonInput>> dtoRequestT01A001AV01CV01ConvertCsvToJson)
        {
            var __workflow_dtoRequestT01A001AV01CV01ConvertCsvToJson = WorkflowExpression.Compile(dtoRequestT01A001AV01CV01ConvertCsvToJson, nameof(dtoRequestT01A001AV01CV01ConvertCsvToJson), required: true);
            return new DeferredBodyAction<DtoResponseT01A001AV01CV01ConvertCsvToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A001_AV01_CV01_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A001AV01CV01ConvertCsvToJson);
                return new ApiConnectionAction<DtoResponseT01A001AV01CV01ConvertCsvToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv, ApiConnectionActionConfiguration> T01A002AV01CV01ConvertJsonToCsv(Expression<Func<T01A002AV01CV01ConvertJsonToCsvInput>> dtoRequestT01A002AV01CV01ConvertJsonToCsv)
        {
            var __workflow_dtoRequestT01A002AV01CV01ConvertJsonToCsv = WorkflowExpression.Compile(dtoRequestT01A002AV01CV01ConvertJsonToCsv, nameof(dtoRequestT01A002AV01CV01ConvertJsonToCsv), required: true);
            return new DeferredBodyAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A002_AV01_CV01_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A002AV01CV01ConvertJsonToCsv);
                return new ApiConnectionAction<DtoResponseT01A002AV01CV01ConvertJsonToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel, ApiConnectionActionConfiguration> T01A003AV01CV01ConvertCsvToExcel(Expression<Func<T01A003AV01CV01ConvertCsvToExcelInput>> dtoRequestT01A003AV01CV01ConvertCsvToExcel)
        {
            var __workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcel = WorkflowExpression.Compile(dtoRequestT01A003AV01CV01ConvertCsvToExcel, nameof(dtoRequestT01A003AV01CV01ConvertCsvToExcel), required: true);
            return new DeferredBodyAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A003_AV01_CV01_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A003AV01CV01ConvertCsvToExcel);
                return new ApiConnectionAction<DtoResponseT01A003AV01CV01ConvertCsvToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv, ApiConnectionActionConfiguration> T01A004AV01CV01ConvertExcelToCsv(Expression<Func<T01A004AV01CV01ConvertExcelToCsvInput>> dtoRequestT01A004AV01CV01ConvertExcelToCsv)
        {
            var __workflow_dtoRequestT01A004AV01CV01ConvertExcelToCsv = WorkflowExpression.Compile(dtoRequestT01A004AV01CV01ConvertExcelToCsv, nameof(dtoRequestT01A004AV01CV01ConvertExcelToCsv), required: true);
            return new DeferredBodyAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A004_AV01_CV01_ConvertExcelToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A004AV01CV01ConvertExcelToCsv);
                return new ApiConnectionAction<DtoResponseT01A004AV01CV01ConvertExcelToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml, ApiConnectionActionConfiguration> T01A005AV01CV01ConvertCsvToHtml(Expression<Func<T01A005AV01CV01ConvertCsvToHtmlInput>> dtoRequestT01A005AV01CV01ConvertCsvToHtml)
        {
            var __workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtml = WorkflowExpression.Compile(dtoRequestT01A005AV01CV01ConvertCsvToHtml, nameof(dtoRequestT01A005AV01CV01ConvertCsvToHtml), required: true);
            return new DeferredBodyAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A005_AV01_CV01_ConvertCsvToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A005AV01CV01ConvertCsvToHtml);
                return new ApiConnectionAction<DtoResponseT01A005AV01CV01ConvertCsvToHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv, ApiConnectionActionConfiguration> T01A006AV01CV01ConvertHtmlToCsv(Expression<Func<T01A006AV01CV01ConvertHtmlToCsvInput>> dtoRequestT01A006AV01CV01ConvertHtmlToCsv)
        {
            var __workflow_dtoRequestT01A006AV01CV01ConvertHtmlToCsv = WorkflowExpression.Compile(dtoRequestT01A006AV01CV01ConvertHtmlToCsv, nameof(dtoRequestT01A006AV01CV01ConvertHtmlToCsv), required: true);
            return new DeferredBodyAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A006_AV01_CV01_ConvertHtmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A006AV01CV01ConvertHtmlToCsv);
                return new ApiConnectionAction<DtoResponseT01A006AV01CV01ConvertHtmlToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A007AV01CV01ConvertCsvToXml, ApiConnectionActionConfiguration> T01A007AV01CV01ConvertCsvToXml(Expression<Func<T01A007AV01CV01ConvertCsvToXmlInput>> dtoRequestT01A007AV01CV01ConvertCsvToXml)
        {
            var __workflow_dtoRequestT01A007AV01CV01ConvertCsvToXml = WorkflowExpression.Compile(dtoRequestT01A007AV01CV01ConvertCsvToXml, nameof(dtoRequestT01A007AV01CV01ConvertCsvToXml), required: true);
            return new DeferredBodyAction<DtoResponseT01A007AV01CV01ConvertCsvToXml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A007_AV01_CV01_ConvertCsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A007AV01CV01ConvertCsvToXml);
                return new ApiConnectionAction<DtoResponseT01A007AV01CV01ConvertCsvToXml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv, ApiConnectionActionConfiguration> T01A008AV01CV01ConvertXmlToCsv(Expression<Func<T01A008AV01CV01ConvertXmlToCsvInput>> dtoRequestT01A008AV01CV01ConvertXmlToCsv)
        {
            var __workflow_dtoRequestT01A008AV01CV01ConvertXmlToCsv = WorkflowExpression.Compile(dtoRequestT01A008AV01CV01ConvertXmlToCsv, nameof(dtoRequestT01A008AV01CV01ConvertXmlToCsv), required: true);
            return new DeferredBodyAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A008_AV01_CV01_ConvertXmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A008AV01CV01ConvertXmlToCsv);
                return new ApiConnectionAction<DtoResponseT01A008AV01CV01ConvertXmlToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml, ApiConnectionActionConfiguration> T01A009AV01CV01ConvertCsvToYaml(Expression<Func<T01A009AV01CV01ConvertCsvToYamlInput>> dtoRequestT01A009AV01CV01ConvertCsvToYaml)
        {
            var __workflow_dtoRequestT01A009AV01CV01ConvertCsvToYaml = WorkflowExpression.Compile(dtoRequestT01A009AV01CV01ConvertCsvToYaml, nameof(dtoRequestT01A009AV01CV01ConvertCsvToYaml), required: true);
            return new DeferredBodyAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A009_AV01_CV01_ConvertCsvToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A009AV01CV01ConvertCsvToYaml);
                return new ApiConnectionAction<DtoResponseT01A009AV01CV01ConvertCsvToYaml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv, ApiConnectionActionConfiguration> T01A010AV01CV01ConvertYamlToCsv(Expression<Func<T01A010AV01CV01ConvertYamlToCsvInput>> dtoRequestT01A010AV01CV01ConvertYamlToCsv)
        {
            var __workflow_dtoRequestT01A010AV01CV01ConvertYamlToCsv = WorkflowExpression.Compile(dtoRequestT01A010AV01CV01ConvertYamlToCsv, nameof(dtoRequestT01A010AV01CV01ConvertYamlToCsv), required: true);
            return new DeferredBodyAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A010_AV01_CV01_ConvertYamlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A010AV01CV01ConvertYamlToCsv);
                return new ApiConnectionAction<DtoResponseT01A010AV01CV01ConvertYamlToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "csvconverterbypower2")]
        public IBodyWorkflowAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable, ApiConnectionActionConfiguration> T01A011AV01CV01ConvertCsvToTextTable(Expression<Func<T01A011AV01CV01ConvertCsvToTextTableInput>> dtoRequestT01A011AV01CV01ConvertCsvToTextTable)
        {
            var __workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTable = WorkflowExpression.Compile(dtoRequestT01A011AV01CV01ConvertCsvToTextTable, nameof(dtoRequestT01A011AV01CV01ConvertCsvToTextTable), required: true);
            return new DeferredBodyAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T01_Csv/V01/T01_A011_AV01_CV01_ConvertCsvToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT01A011AV01CV01ConvertCsvToTextTable);
                return new ApiConnectionAction<DtoResponseT01A011AV01CV01ConvertCsvToTextTable>(callPayload);
            });
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

    public class T01A000AV01CV01ConvertAllFormatsInput
    {
        [JsonProperty("inputData", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputData { get; set; }

        [JsonProperty("inputFormat")]
        public string InputFormat { get; set; }

        [JsonProperty("outputFormat")]
        public string OutputFormats { get; set; }
    }

    public class DtoResponseT01A001AV01CV01ConvertCsvToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class T01A001AV01CV01ConvertCsvToJsonInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDetectHeaderLine")]
        public bool? AutoDetectHeader { get; set; }

        [JsonProperty("headerLineIndex")]
        public int? HeaderRowIndex { get; set; }

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("detectionAccuracy")]
        public string DetectionAccuracy { get; set; }

        [JsonProperty("nullValue")]
        public string NullValue { get; set; }

        [JsonProperty("skipRows")]
        public string RowsToSkip { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtRow { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("quoteCharacter")]
        public string QuoteCharacter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("autoDetectWrappedLines")]
        public bool? AutoDetectWrappedLines { get; set; }

        [JsonProperty("columnRenames")]
        public string RenameColumns { get; set; }

        [JsonProperty("columnsToInclude")]
        public string IncludeColumns { get; set; }
    }

    public class DtoResponseT01A002AV01CV01ConvertJsonToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class T01A002AV01CV01ConvertJsonToCsvInput
    {
        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }
    }

    public class DtoResponseT01A003AV01CV01ConvertCsvToExcel
    {
        [JsonProperty("excel")]
        public string ExcelResponse { get; set; }
    }

    public class T01A003AV01CV01ConvertCsvToExcelInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDetectHeaderLine")]
        public bool? AutoDetectHeader { get; set; }

        [JsonProperty("headerLineIndex")]
        public int? HeaderRowIndex { get; set; }

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("detectionAccuracy")]
        public string DetectionAccuracy { get; set; }

        [JsonProperty("nullValue")]
        public string NullValue { get; set; }

        [JsonProperty("skipRows")]
        public string RowsToSkip { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtRow { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("quoteCharacter")]
        public string QuoteCharacter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("autoDetectWrappedLines")]
        public bool? AutoDetectWrappedLines { get; set; }

        [JsonProperty("columnRenames")]
        public string RenameColumns { get; set; }

        [JsonProperty("columnsToInclude")]
        public string IncludeColumns { get; set; }

        [JsonProperty("adjustColumnToContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AdjustExcelColumnToContent { get; set; } = true;

        [JsonProperty("wrapColumnText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WrapExcelColumnText { get; set; } = false;

        [JsonProperty("maxColumnWidth")]
        public int? MaxExcelColumnWidth { get; set; }
    }

    public class DtoResponseT01A004AV01CV01ConvertExcelToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class T01A004AV01CV01ConvertExcelToCsvInput
    {
        [JsonProperty("excel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExcelFile { get; set; }
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

    public class T01A005AV01CV01ConvertCsvToHtmlInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDetectHeaderLine")]
        public bool? AutoDetectHeader { get; set; }

        [JsonProperty("headerLineIndex")]
        public int? HeaderRowIndex { get; set; }

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("detectionAccuracy")]
        public string DetectionAccuracy { get; set; }

        [JsonProperty("nullValue")]
        public string NullValue { get; set; }

        [JsonProperty("skipRows")]
        public string RowsToSkip { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtRow { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("quoteCharacter")]
        public string QuoteCharacter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("autoDetectWrappedLines")]
        public bool? AutoDetectWrappedLines { get; set; }

        [JsonProperty("columnRenames")]
        public string RenameColumns { get; set; }

        [JsonProperty("columnsToInclude")]
        public string IncludeColumns { get; set; }
    }

    public class DtoResponseT01A006AV01CV01ConvertHtmlToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class T01A006AV01CV01ConvertHtmlToCsvInput
    {
        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTMLTable { get; set; }
    }

    public class DtoResponseT01A007AV01CV01ConvertCsvToXml
    {
        [JsonProperty("xml")]
        public string XMLResponse { get; set; }
    }

    public class T01A007AV01CV01ConvertCsvToXmlInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDetectHeaderLine")]
        public bool? AutoDetectHeader { get; set; }

        [JsonProperty("headerLineIndex")]
        public int? HeaderRowIndex { get; set; }

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("detectionAccuracy")]
        public string DetectionAccuracy { get; set; }

        [JsonProperty("nullValue")]
        public string NullValue { get; set; }

        [JsonProperty("skipRows")]
        public string RowsToSkip { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtRow { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("quoteCharacter")]
        public string QuoteCharacter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("autoDetectWrappedLines")]
        public bool? AutoDetectWrappedLines { get; set; }

        [JsonProperty("columnRenames")]
        public string RenameColumns { get; set; }

        [JsonProperty("columnsToInclude")]
        public string IncludeColumns { get; set; }
    }

    public class DtoResponseT01A008AV01CV01ConvertXmlToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class T01A008AV01CV01ConvertXmlToCsvInput
    {
        [JsonProperty("xml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XML { get; set; }
    }

    public class DtoResponseT01A009AV01CV01ConvertCsvToYaml
    {
        [JsonProperty("yaml")]
        public string YAMLResponse { get; set; }
    }

    public class T01A009AV01CV01ConvertCsvToYamlInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDetectHeaderLine")]
        public bool? AutoDetectHeader { get; set; }

        [JsonProperty("headerLineIndex")]
        public int? HeaderRowIndex { get; set; }

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("detectionAccuracy")]
        public string DetectionAccuracy { get; set; }

        [JsonProperty("nullValue")]
        public string NullValue { get; set; }

        [JsonProperty("skipRows")]
        public string RowsToSkip { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtRow { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("quoteCharacter")]
        public string QuoteCharacter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("autoDetectWrappedLines")]
        public bool? AutoDetectWrappedLines { get; set; }

        [JsonProperty("columnRenames")]
        public string RenameColumns { get; set; }

        [JsonProperty("columnsToInclude")]
        public string IncludeColumns { get; set; }
    }

    public class DtoResponseT01A010AV01CV01ConvertYamlToCsv
    {
        [JsonProperty("csvs")]
        public string[] CSVTableList { get; set; }

        [JsonProperty("firstCsv")]
        public string FirstCSVTable { get; set; }
    }

    public class T01A010AV01CV01ConvertYamlToCsvInput
    {
        [JsonProperty("yaml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YAML { get; set; }
    }

    public class DtoResponseT01A011AV01CV01ConvertCsvToTextTable
    {
        [JsonProperty("textTables")]
        public string[] TextTableList { get; set; }

        [JsonProperty("firstTextTable")]
        public string FirstTextTable { get; set; }
    }

    public class T01A011AV01CV01ConvertCsvToTextTableInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDetectHeaderLine")]
        public bool? AutoDetectHeader { get; set; }

        [JsonProperty("headerLineIndex")]
        public int? HeaderRowIndex { get; set; }

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("detectionAccuracy")]
        public string DetectionAccuracy { get; set; }

        [JsonProperty("nullValue")]
        public string NullValue { get; set; }

        [JsonProperty("skipRows")]
        public string RowsToSkip { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtRow { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("quoteCharacter")]
        public string QuoteCharacter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("autoDetectWrappedLines")]
        public bool? AutoDetectWrappedLines { get; set; }

        [JsonProperty("columnRenames")]
        public string RenameColumns { get; set; }

        [JsonProperty("columnsToInclude")]
        public string IncludeColumns { get; set; }
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