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
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv> V1013ConvertJsonToCsv(Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvjSON, Expression<Func<string>> dtoRequestV1013ConvertJsonToCsvseparator = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson> V1022ConvertCsvToJson(Expression<Func<string>> dtoRequestV1022ConvertCsvToJsoncSV, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsoncSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1022ConvertCsvToJsonstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1022ConvertCsvToJsonseparator = null, Expression<Func<bool>> dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter = null)
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
                dtoRequestV1022ConvertCsvToJson["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsoncSVHasHeaders);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes != null)
            {
                dtoRequestV1022ConvertCsvToJson["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonautoDetectFieldTypes);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection != null)
            {
                dtoRequestV1022ConvertCsvToJson["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonnumberOfRowsForFieldTypeDetection);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonremoveEmptyRows != null)
            {
                dtoRequestV1022ConvertCsvToJson["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonremoveEmptyRows);
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
                dtoRequestV1022ConvertCsvToJson["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV1022ConvertCsvToJsonautoDetectQuoteDelimiter);
                dtoRequestV1022ConvertCsvToJsonpropCount++;
            }

            if (dtoRequestV1022ConvertCsvToJsonpropCount > 0)
            {
                callPayload.Body = dtoRequestV1022ConvertCsvToJson;
            }

            return new ApiConnectionAction<DtoResponseV1022ConvertCsvToJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1032ConvertCsvToExcel> V1032ConvertCsvToExcel(Expression<Func<string>> dtoRequestV1032ConvertCsvToExcelcSV, Expression<Func<bool>> dtoRequestV1032ConvertCsvToExcelcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV1032ConvertCsvToExcelautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV1032ConvertCsvToExcelnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV1032ConvertCsvToExcelremoveEmptyRows = null, Expression<Func<int>> dtoRequestV1032ConvertCsvToExcelskipANumberOfRows = null, Expression<Func<int>> dtoRequestV1032ConvertCsvToExcelstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV1032ConvertCsvToExcelseparator = null, Expression<Func<bool>> dtoRequestV1032ConvertCsvToExcelautoDetectQuoteDelimiter = null)
        {
            var apiCallPath = "/V1032_ConvertCsvToExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV1032ConvertCsvToExcel = new JObject();
            var dtoRequestV1032ConvertCsvToExcelpropCount = 0;
            dtoRequestV1032ConvertCsvToExcelpropCount++;
            dtoRequestV1032ConvertCsvToExcel["csv"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelcSV);
            if (dtoRequestV1032ConvertCsvToExcelcSVHasHeaders != null)
            {
                dtoRequestV1032ConvertCsvToExcel["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelcSVHasHeaders);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelautoDetectFieldTypes != null)
            {
                dtoRequestV1032ConvertCsvToExcel["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelautoDetectFieldTypes);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelnumberOfRowsForFieldTypeDetection != null)
            {
                dtoRequestV1032ConvertCsvToExcel["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelnumberOfRowsForFieldTypeDetection);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelremoveEmptyRows != null)
            {
                dtoRequestV1032ConvertCsvToExcel["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelremoveEmptyRows);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelskipANumberOfRows != null)
            {
                dtoRequestV1032ConvertCsvToExcel["skip"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelskipANumberOfRows);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelstopAtASpecificRow != null)
            {
                dtoRequestV1032ConvertCsvToExcel["skipLast"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelstopAtASpecificRow);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelseparator != null)
            {
                dtoRequestV1032ConvertCsvToExcel["delimiter"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelseparator);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelautoDetectQuoteDelimiter != null)
            {
                dtoRequestV1032ConvertCsvToExcel["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV1032ConvertCsvToExcelautoDetectQuoteDelimiter);
                dtoRequestV1032ConvertCsvToExcelpropCount++;
            }

            if (dtoRequestV1032ConvertCsvToExcelpropCount > 0)
            {
                callPayload.Body = dtoRequestV1032ConvertCsvToExcel;
            }

            return new ApiConnectionAction<DtoResponseV1032ConvertCsvToExcel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml> V1042ConvertJsonToXml(Expression<Func<string>> dtoRequestV1042ConvertJsonToXmljSON)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1052ConvertXmlToJson> V1052ConvertXmlToJson(Expression<Func<string>> dtoRequestV1052ConvertXmlToJsonxML)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1062ConvertJsonToExcel> V1062ConvertJsonToExcel(Expression<Func<string>> dtoRequestJsonToExcelDatajSON, Expression<Func<bool>> dtoRequestJsonToExcelDataallInOneTable = null)
        {
            var apiCallPath = "/V1062_ConvertJsonToExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestJsonToExcelData = new JObject();
            var dtoRequestJsonToExcelDatapropCount = 0;
            dtoRequestJsonToExcelDatapropCount++;
            dtoRequestJsonToExcelData["json"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDatajSON);
            if (dtoRequestJsonToExcelDataallInOneTable != null)
            {
                dtoRequestJsonToExcelData["allInOneTable"] = ExpressionConverter.ConvertO(dtoRequestJsonToExcelDataallInOneTable);
                dtoRequestJsonToExcelDatapropCount++;
            }

            if (dtoRequestJsonToExcelDatapropCount > 0)
            {
                callPayload.Body = dtoRequestJsonToExcelData;
            }

            return new ApiConnectionAction<DtoResponseV1062ConvertJsonToExcel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson> V1071ConvertYamlToJson(Expression<Func<string>> dtoRequestV1071YamlToJsonyAML)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml> V1081ConvertJsonToYaml(Expression<Func<string>> dtoRequestV1081ConvertJsonToYamljSON)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable> V1090ConvertJsonToTextTable(Expression<Func<string>> dtoRequestV1090ConvertJsonToTextTablejSON)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson> V1100ConvertExcelToJson(Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonexcelFile, Expression<Func<bool>> dtoRequestV1100ConvertExcelToJsonexcelHasHeaders = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonstartCell = null, Expression<Func<string>> dtoRequestV1100ConvertExcelToJsonsheetName = null)
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
                dtoRequestV1100ConvertExcelToJson["hasHeaders"] = ExpressionConverter.ConvertO(dtoRequestV1100ConvertExcelToJsonexcelHasHeaders);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression> V2011RegularExpression(Expression<Func<string>> dtoRequestV2011RegularExpressiontextToMatch, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpression = null, Expression<Func<string>> dtoRequestV2011RegularExpressionregularExpressionOption = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2021IbanData> V2021IbanData(Expression<Func<string>> dtoRequestV2021IbanDataiBAN)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2031UrlToFile> V2031UrlToFile(Expression<Func<string>> dtoRequestV2031UrlToFileuRL)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2041Translate> V2041Translate(Expression<Func<string>> dtoRequestV2041Translatetext, Expression<Func<string>> dtoRequestV2041Translateto, Expression<Func<string>> dtoRequestV2041Translatefrom = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2051SortJson> V2051SortJson(Expression<Func<string>> dtoRequestV2051SortJsonjSON, Expression<Func<string>> dtoRequestV2051SortJsonsortProperty = null, Expression<Func<string>> dtoRequestV2051SortJsonfurtherSortingProperty = null, Expression<Func<bool>> dtoRequestV2051SortJsonreverseOrder = null)
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
                dtoRequestV2051SortJson["isReverse"] = ExpressionConverter.ConvertO(dtoRequestV2051SortJsonreverseOrder);
                dtoRequestV2051SortJsonpropCount++;
            }

            if (dtoRequestV2051SortJsonpropCount > 0)
            {
                callPayload.Body = dtoRequestV2051SortJson;
            }

            return new ApiConnectionAction<DtoResponseV2051SortJson>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv> V2061SortCsv(Expression<Func<string>> dtoRequestV2061SortCsvcSV, Expression<Func<bool>> dtoRequestV2061SortCsvcSVHasHeaders = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV2061SortCsvremoveEmptyRows = null, Expression<Func<int>> dtoRequestV2061SortCsvskipANumberOfRows = null, Expression<Func<int>> dtoRequestV2061SortCsvstopAtASpecificRow = null, Expression<Func<string>> dtoRequestV2061SortCsvseparator = null, Expression<Func<bool>> dtoRequestV2061SortCsvautoDetectQuoteDelimiter = null, Expression<Func<string>> dtoRequestV2061SortCsvsortColumn = null, Expression<Func<string>> dtoRequestV2061SortCsvfurtherSortingColumn = null, Expression<Func<bool>> dtoRequestV2061SortCsvreverseOrder = null)
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
                dtoRequestV2061SortCsv["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvcSVHasHeaders);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvautoDetectFieldTypes != null)
            {
                dtoRequestV2061SortCsv["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvautoDetectFieldTypes);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection != null)
            {
                dtoRequestV2061SortCsv["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvnumberOfRowsForFieldTypeDetection);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvremoveEmptyRows != null)
            {
                dtoRequestV2061SortCsv["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvremoveEmptyRows);
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
                dtoRequestV2061SortCsv["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvautoDetectQuoteDelimiter);
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
                dtoRequestV2061SortCsv["isReverse"] = ExpressionConverter.ConvertO(dtoRequestV2061SortCsvreverseOrder);
                dtoRequestV2061SortCsvpropCount++;
            }

            if (dtoRequestV2061SortCsvpropCount > 0)
            {
                callPayload.Body = dtoRequestV2061SortCsv;
            }

            return new ApiConnectionAction<DtoResponseV2061SortCsv>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor> V2071ConvertColor(Expression<Func<string>> dtoRequestV2071ConvertColorcolor)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs> V2081CombineCsvs(Expression<Func<string>> dtoRequestV2081CombineCsvsmainCSV, Expression<Func<string>> dtoRequestV2081CombineCsvscombineColumnName, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSV, Expression<Func<string>> dtoRequestV2081CombineCsvssecondCSVColumn = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays> V2091CombineJsonArrays(Expression<Func<string>> dtoRequestV2091CombineJsonArraysmainJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayscombinePropertyName, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSON, Expression<Func<string>> dtoRequestV2091CombineJsonArrayssecondJSONProperty = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties> V2100ExtractJsonObjectProperties(Expression<Func<string>> dtoRequestV2100ExtractJsonObjectPropertiesjSON, Expression<Func<bool>> dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties = null)
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
                dtoRequestV2100ExtractJsonObjectProperties["nestedPropertyExtraction"] = ExpressionConverter.ConvertO(dtoRequestV2100ExtractJsonObjectPropertiesextractNestedProperties);
                dtoRequestV2100ExtractJsonObjectPropertiespropCount++;
            }

            if (dtoRequestV2100ExtractJsonObjectPropertiespropCount > 0)
            {
                callPayload.Body = dtoRequestV2100ExtractJsonObjectProperties;
            }

            return new ApiConnectionAction<DtoResponseV2100ExtractJsonObjectProperties>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern> V2110ReplaceTextWithPattern(Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatterninputText, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternsearchPattern, Expression<Func<string>> dtoRequestV2110ReplaceTextWithPatternreplacementText = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck> V2120PatternMatchCheck(Expression<Func<string>> dtoRequestV2120PatternMatchCheckinputText, Expression<Func<string>> dtoRequestV2120PatternMatchCheckmatchPattern)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit> V2130SmartTextSplit(Expression<Func<string>> dtoRequestV2130SmartTextSplitinputText, Expression<Func<string>> dtoRequestV2130SmartTextSplitsplitPattern = null, Expression<Func<bool>> dtoRequestV2130SmartTextSplittrimEnabled = null, Expression<Func<string>> dtoRequestV2130SmartTextSplittrimStrings = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern> V2140ExtractTextAccordingToPattern(Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntext, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatternmatchPattern, Expression<Func<bool>> dtoRequestV2140ExtractTextAccordingToPatterntrimEnabled = null, Expression<Func<string>> dtoRequestV2140ExtractTextAccordingToPatterntrimStrings = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2150RunCode> V2150RunCode(Expression<Func<string>> dtoRequestV2150RunCodejavaScriptCode)
        {
            var apiCallPath = "/V2150_RunCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV2150RunCode = new JObject();
            var dtoRequestV2150RunCodepropCount = 0;
            dtoRequestV2150RunCodepropCount++;
            dtoRequestV2150RunCode["code"] = ExpressionConverter.ConvertO(dtoRequestV2150RunCodejavaScriptCode);
            if (dtoRequestV2150RunCodepropCount > 0)
            {
                callPayload.Body = dtoRequestV2150RunCode;
            }

            return new ApiConnectionAction<DtoResponseV2150RunCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> V3012ConvertImage(Expression<Func<string>> dtoRequestV3012ConvertImageimageFile, Expression<Func<string>> dtoRequestV3012ConvertImageoutputFormat = null)
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
                dtoRequestV3012ConvertImage["outFormat"] = ExpressionConverter.ConvertO(dtoRequestV3012ConvertImageoutputFormat);
                dtoRequestV3012ConvertImagepropCount++;
            }

            if (dtoRequestV3012ConvertImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3012ConvertImage;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3022ResizeImage> V3022ResizeImage(Expression<Func<string>> dtoRequestV3022ResizeImageimageFile, Expression<Func<double>> dtoRequestV3022ResizeImageimageWidth = null, Expression<Func<double>> dtoRequestV3022ResizeImageimageHeight = null, Expression<Func<string>> dtoRequestV3022ResizeImageresizeBy = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3031RotateImage> V3031RotateImage(Expression<Func<string>> dtoRequestV3031RotateImageimageFile, Expression<Func<double>> dtoRequestV3031RotateImagerotate = null, Expression<Func<string>> dtoRequestV3031RotateImageoutputFormat = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3041CompressImage> V3041CompressImage(Expression<Func<string>> dtoRequestCompressImageimageFile, Expression<Func<int>> dtoRequestCompressImageimageQuality = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode> V3051ReadCode(Expression<Func<string>> dtoRequestReadCodeDataqROrBarcode)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3062CreateCode> V3062CreateCode(Expression<Func<string>> dtoRequestV3062CreateCodecontent, Expression<Func<string>> dtoRequestV3062CreateCodecodeFormat = null, Expression<Func<int>> dtoRequestV3062CreateCodewidth = null, Expression<Func<int>> dtoRequestV3062CreateCodeheight = null, Expression<Func<string>> dtoRequestV3062CreateCodeoutputFormat = null, Expression<Func<string>> dtoRequestV3062CreateCodeembeddedImage = null, Expression<Func<double>> dtoRequestV3062CreateCodeembeddedImageOpacity = null, Expression<Func<double>> dtoRequestV3062CreateCodeembeddedImageRatio = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData> V3071ImageMetaData(Expression<Func<string>> dtoRequestV3071ImageMetaDataimageFile)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3081CreateWatermarkImage> V3081CreateWatermarkImage(Expression<Func<string>> dtoRequestV3081CreateWatermarkImagemainImage, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkImage, Expression<Func<int>> dtoRequestV3081CreateWatermarkImagewatermarkOpacity = null, Expression<Func<int>> dtoRequestV3081CreateWatermarkImagewatermarkRatio = null, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkHorizontalPosition = null, Expression<Func<string>> dtoRequestV3081CreateWatermarkImagewatermarkVerticalPosition = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3091CreateChartImage> V3091CreateChartImage(Expression<Func<string>> dtoRequestV3091CreateChartImagetableData, Expression<Func<int>> dtoRequestV3091CreateChartImageimageWidth = null, Expression<Func<int>> dtoRequestV3091CreateChartImageimageHeight = null, Expression<Func<string>> dtoRequestV3091CreateChartImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3091CreateChartImageoutputFormat = null, Expression<Func<string>> dtoRequestV3091CreateChartImagechartType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3101CreateTableImage> V3101CreateTableImage(Expression<Func<string>> dtoRequestV3101CreateTableImagetableData, Expression<Func<int>> dtoRequestV3101CreateTableImageimageWidth = null, Expression<Func<int>> dtoRequestV3101CreateTableImageimageHeight = null, Expression<Func<string>> dtoRequestV3101CreateTableImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3101CreateTableImageoutputFormat = null, Expression<Func<string>> dtoRequestV3101CreateTableImagetitle = null, Expression<Func<bool>> dtoRequestV3101CreateTableImageshowTableBorders = null)
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
                dtoRequestV3101CreateTableImage["hasLines"] = ExpressionConverter.ConvertO(dtoRequestV3101CreateTableImageshowTableBorders);
                dtoRequestV3101CreateTableImagepropCount++;
            }

            if (dtoRequestV3101CreateTableImagepropCount > 0)
            {
                callPayload.Body = dtoRequestV3101CreateTableImage;
            }

            return new ApiConnectionAction<DtoResponseV3101CreateTableImage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3111CreateGraphImage> V3111CreateGraphImage(Expression<Func<string>> dtoRequestV3111CreateGraphImagegraphData, Expression<Func<int>> dtoRequestV3111CreateGraphImageimageWidth = null, Expression<Func<int>> dtoRequestV3111CreateGraphImageimageHeight = null, Expression<Func<string>> dtoRequestV3111CreateGraphImagebackgroundColor = null, Expression<Func<string>> dtoRequestV3111CreateGraphImageoutputFormat = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4012ConvertFileToPdf> V4012ConvertFileToPdf(Expression<Func<string>> dtoRequestV4012FileToPdffile, Expression<Func<string>> dtoRequestV4012FileToPdforiginFileName = null, Expression<Func<string>> dtoRequestV4012FileToPdforiginFileExtension = null)
        {
            var apiCallPath = "/V4012_ConvertFileToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestV4012FileToPdf = new JObject();
            var dtoRequestV4012FileToPdfpropCount = 0;
            dtoRequestV4012FileToPdfpropCount++;
            dtoRequestV4012FileToPdf["file"] = ExpressionConverter.ConvertO(dtoRequestV4012FileToPdffile);
            if (dtoRequestV4012FileToPdforiginFileName != null)
            {
                dtoRequestV4012FileToPdf["fileName"] = ExpressionConverter.ConvertO(dtoRequestV4012FileToPdforiginFileName);
                dtoRequestV4012FileToPdfpropCount++;
            }

            if (dtoRequestV4012FileToPdforiginFileExtension != null)
            {
                dtoRequestV4012FileToPdf["fileExtension"] = ExpressionConverter.ConvertO(dtoRequestV4012FileToPdforiginFileExtension);
                dtoRequestV4012FileToPdfpropCount++;
            }

            if (dtoRequestV4012FileToPdfpropCount > 0)
            {
                callPayload.Body = dtoRequestV4012FileToPdf;
            }

            return new ApiConnectionAction<DtoResponseV4012ConvertFileToPdf>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4021MergePdfs> V4021MergePdfs(Expression<Func<string>> dtoRequestV4021MergePdfsfile1, Expression<Func<string>> dtoRequestV4021MergePdfsfile2)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata> V4031PdfMetadata(Expression<Func<string>> dtoRequestV4031PdfMetadatafile)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4041ProtectPdf> V4041ProtectPdf(Expression<Func<string>> dtoRequestV4041ProtectPdffile, Expression<Func<string>> dtoRequestV4041ProtectPdfownerPassword = null, Expression<Func<string>> dtoRequestV4041ProtectPdfuserPassword = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4051UnProtectPdf> V4051UnProtectPdf(Expression<Func<string>> dtoRequestV4051UnProtectPdffile, Expression<Func<string>> dtoRequestV4051UnProtectPdfownerPassword = null, Expression<Func<bool>> dtoRequestV4051UnProtectPdfremovePermissions = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5011CreateWordFile> V5011CreateWordFile(Expression<Func<Section[]>> dtoRequestV5011CreateWordFilesection, Expression<Func<string>> dtoRequestV5011CreateWordFileexistingFileContent = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks> V5021ExtractWordBookmarks(Expression<Func<string>> dtoRequestV5021ExtractWordBookmarksfile, Expression<Func<bool>> dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchName = null, Expression<Func<string>> dtoRequestV5021ExtractWordBookmarkssearchContent = null)
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
                dtoRequestV5021ExtractWordBookmarks["includeHiddenBookmarks"] = ExpressionConverter.ConvertO(dtoRequestV5021ExtractWordBookmarksincludeHiddenBookmarks);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5031AddImageToWord> V5031AddImageToWord(Expression<Func<string>> dtoRequestV5031AddImageToWordimage, Expression<Func<string>> dtoRequestV5031AddImageToWordexistingFileContent = null, Expression<Func<string>> dtoRequestV5031AddImageToWordcaptionText = null, Expression<Func<int>> dtoRequestV5031AddImageToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5031AddImageToWordmaximumImageHeight = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5042AddImageWithinTableToWord> V5042AddImageWithinTableToWord(Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWordimage, Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWordexistingFileContent = null, Expression<Func<string>> dtoRequestV5042AddImageWithinTableToWorddescriptionText = null, Expression<Func<int>> dtoRequestV5042AddImageWithinTableToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5042AddImageWithinTableToWordmaximumImageHeight = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5052AddTableToWord> V5052AddTableToWord(Expression<Func<string>> dtoRequestV5052AddTableToWordtableData, Expression<Func<string>> dtoRequestV5052AddTableToWordexistingFileContent = null, Expression<Func<bool>> dtoRequestV5052AddTableToWordshowHeaders = null, Expression<Func<string>> dtoRequestV5052AddTableToWordtableStyle = null, Expression<Func<string>> dtoRequestV5052AddTableToWordtableCaption = null)
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
                dtoRequestV5052AddTableToWord["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordshowHeaders);
                dtoRequestV5052AddTableToWordpropCount++;
            }

            if (dtoRequestV5052AddTableToWordtableStyle != null)
            {
                dtoRequestV5052AddTableToWord["tableStyle"] = ExpressionConverter.ConvertO(dtoRequestV5052AddTableToWordtableStyle);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5061AddTextToWord> V5061AddTextToWord(Expression<Func<string>> dtoRequestAddTextToWordDatatype, Expression<Func<string>> dtoRequestAddTextToWordDatatext, Expression<Func<string>> dtoRequestAddTextToWordDataexistingFileContent = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5071InsertTextToWord> V5071InsertTextToWord(Expression<Func<string>> dtoRequestV5071InsertTextToWordexistingFileContent, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderName, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderText = null, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5071InsertTextToWordplaceholderSuffix = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> V5081InsertImageToWord(Expression<Func<string>> dtoRequestV5081InsertImageToWordexistingFileContent, Expression<Func<string>> dtoRequestV5081InsertImageToWordimage, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderName = null, Expression<Func<int>> dtoRequestV5081InsertImageToWordmaximumImageWidth = null, Expression<Func<int>> dtoRequestV5081InsertImageToWordmaximumImageHeight = null, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5081InsertImageToWordplaceholderSuffix = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5091InsertTableToWord> V5091InsertTableToWord(Expression<Func<string>> dtoRequestV5091InsertTableToWordexistingFileContent, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderName = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderTable = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordtableStyle = null, Expression<Func<bool>> dtoRequestV5091InsertTableToWordshowHeaders = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5091InsertTableToWordplaceholderSuffix = null)
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
                dtoRequestV5091InsertTableToWord["tableStyle"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordtableStyle);
                dtoRequestV5091InsertTableToWordpropCount++;
            }

            if (dtoRequestV5091InsertTableToWordshowHeaders != null)
            {
                dtoRequestV5091InsertTableToWord["hasHeader"] = ExpressionConverter.ConvertO(dtoRequestV5091InsertTableToWordshowHeaders);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5101AddHtmlToWord> V5101AddHtmlToWord(Expression<Func<string>> dtoRequestV5101AddHtmlToWordhTML, Expression<Func<string>> dtoRequestV5101AddHtmlToWordexistingFileContent = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5110InsertMultipleTextSectionsToWord> V5110InsertMultipleTextSectionsToWord(Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordexistingFileContent, Expression<Func<InsertSection[]>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholder, Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderPrefix = null, Expression<Func<string>> dtoRequestV5110InsertMultipleTextSectionsToWordplaceholderSuffix = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls> V5120ExtractWordContentControls(Expression<Func<string>> dtoRequestV5120ExtractWordContentControlsfile, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTag = null, Expression<Func<string>> dtoRequestV5120ExtractWordContentControlssearchTitle = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5130UpdateWordTableOfContents> V5130UpdateWordTableOfContents(Expression<Func<string>> dtoRequestV5130UpdateWordTableOfContentsexistingFileContent)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> V5140UpdateWordContentControl(Expression<Func<string>> dtoRequestV5140UpdateWordContentControlexistingFileContent, Expression<Func<string>> dtoRequestV5140UpdateWordContentControlname, Expression<Func<string>> dtoRequestV5140UpdateWordContentControlvalue = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults> V6011ConvertSharePointSearchResults(Expression<Func<string>> dtoRequestV6011ConvertSharePointSearchResultssPSearchResult)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7012ConvertHtmlTableToJson> V7012ConvertHtmlTableToJson(Expression<Func<string>> dtoRequestHtmlToTableDatahTMLTable)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7022ConvertHtmlToPdf> V7022ConvertHtmlToPdf(Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfhTML, Expression<Func<bool>> dtoRequestV7022ConvertHtmlToPdflandscapeFormat = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfqualityOfImageContent = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdffooterOptions = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfheaderOptions = null, Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfpaperFormat = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdftopMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfbottomMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfleftMargin = null, Expression<Func<int>> dtoRequestV7022ConvertHtmlToPdfrightMargin = null, Expression<Func<string>> dtoRequestV7022ConvertHtmlToPdfpageRanges = null, Expression<Func<double>> dtoRequestV7022ConvertHtmlToPdfscale = null)
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
                dtoRequestV7022ConvertHtmlToPdf["isLandscape"] = ExpressionConverter.ConvertO(dtoRequestV7022ConvertHtmlToPdflandscapeFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7031ConvertHtmlToImage> V7031ConvertHtmlToImage(Expression<Func<string>> dtoRequestV7031ConvertHtmlToImagehTML, Expression<Func<int>> dtoRequestV7031ConvertHtmlToImagewidth = null, Expression<Func<int>> dtoRequestV7031ConvertHtmlToImageheight = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> V7041ConvertHtmlToWord(Expression<Func<string>> dtoRequestV7041ConvertHtmlToWordhTML)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> V7051ConvertJsonToHtmlTable(Expression<Func<string>> dtoRequestV7051ConvertJsonToHtmlTablejSON)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml> V7061ConvertCsvToHtmlTable(Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTablecSV, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTableskipANumberOfRows = null, Expression<Func<int>> dtoRequestV7061ConvertCsvToHtmlTablestopAtASpecificRow = null, Expression<Func<string>> dtoRequestV7061ConvertCsvToHtmlTableseparator = null, Expression<Func<bool>> dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter = null)
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
                dtoRequestV7061ConvertCsvToHtmlTable["dataIncludesHeader"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTablecSVHasHeaders);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes != null)
            {
                dtoRequestV7061ConvertCsvToHtmlTable["autoDiscoverFieldTypes"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableautoDetectFieldTypes);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection != null)
            {
                dtoRequestV7061ConvertCsvToHtmlTable["maxScanRows"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTablenumberOfRowsForFieldTypeDetection);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows != null)
            {
                dtoRequestV7061ConvertCsvToHtmlTable["ignoreEmptyLine"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableremoveEmptyRows);
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
                dtoRequestV7061ConvertCsvToHtmlTable["mayHaveQuotedFields"] = ExpressionConverter.ConvertO(dtoRequestV7061ConvertCsvToHtmlTableautoDetectQuoteDelimiter);
                dtoRequestV7061ConvertCsvToHtmlTablepropCount++;
            }

            if (dtoRequestV7061ConvertCsvToHtmlTablepropCount > 0)
            {
                callPayload.Body = dtoRequestV7061ConvertCsvToHtmlTable;
            }

            return new ApiConnectionAction<DtoResponseHtml>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv> V7070ConvertHtmlTableToCsv(Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvhTMLTable, Expression<Func<string>> dtoRequestV7070ConvertHtmlTableToCsvseparator = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7080ConvertHtmlTableToExcel> V7080ConvertHtmlTableToExcel(Expression<Func<string>> dtoRequestV7080ConvertHtmlTableToExcelhTMLTable)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8010ConvertXRechnungToPdf> V8010ConvertXRechnungToPdf(Expression<Func<string>> dtoRequestV8010ConvertXRechnungToPdfxRechnung)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile> V9010InsertTextToPowerPoint(Expression<Func<string>> dtoRequestIV9010InsertTextToPowerPointexistingFileContent, Expression<Func<string>> dtoRequestIV9010InsertTextToPowerPointplaceholderName, Expression<Func<string>> dtoRequestIV9010InsertTextToPowerPointplaceholderText = null, Expression<Func<string>> dtoRequestIV9010InsertTextToPowerPointplaceholderPrefix = null, Expression<Func<string>> dtoRequestIV9010InsertTextToPowerPointplaceholderSuffix = null)
        {
            var apiCallPath = "/V9010_InsertTextToPowerPoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dtoRequestIV9010InsertTextToPowerPoint = new JObject();
            var dtoRequestIV9010InsertTextToPowerPointpropCount = 0;
            dtoRequestIV9010InsertTextToPowerPointpropCount++;
            dtoRequestIV9010InsertTextToPowerPoint["existingFileContent"] = ExpressionConverter.ConvertO(dtoRequestIV9010InsertTextToPowerPointexistingFileContent);
            dtoRequestIV9010InsertTextToPowerPointpropCount++;
            dtoRequestIV9010InsertTextToPowerPoint["placeholderName"] = ExpressionConverter.ConvertO(dtoRequestIV9010InsertTextToPowerPointplaceholderName);
            if (dtoRequestIV9010InsertTextToPowerPointplaceholderText != null)
            {
                dtoRequestIV9010InsertTextToPowerPoint["placeholderText"] = ExpressionConverter.ConvertO(dtoRequestIV9010InsertTextToPowerPointplaceholderText);
                dtoRequestIV9010InsertTextToPowerPointpropCount++;
            }

            if (dtoRequestIV9010InsertTextToPowerPointplaceholderPrefix != null)
            {
                dtoRequestIV9010InsertTextToPowerPoint["placeholderPrefix"] = ExpressionConverter.ConvertO(dtoRequestIV9010InsertTextToPowerPointplaceholderPrefix);
                dtoRequestIV9010InsertTextToPowerPointpropCount++;
            }

            if (dtoRequestIV9010InsertTextToPowerPointplaceholderSuffix != null)
            {
                dtoRequestIV9010InsertTextToPowerPoint["placeholderSuffix"] = ExpressionConverter.ConvertO(dtoRequestIV9010InsertTextToPowerPointplaceholderSuffix);
                dtoRequestIV9010InsertTextToPowerPointpropCount++;
            }

            if (dtoRequestIV9010InsertTextToPowerPointpropCount > 0)
            {
                callPayload.Body = dtoRequestIV9010InsertTextToPowerPoint;
            }

            return new ApiConnectionAction<DtoResponseFile>(callPayload);
        }
    }

    public class Converterbypower2appsTriggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseV1013ConvertJsonToCsv
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoResponseV1022ConvertCsvToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV1032ConvertCsvToExcel
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

    public class DtoResponseV1042ConvertJsonToXml
    {
        [JsonProperty("xml")]
        public string XMLResponse { get; set; }
    }

    public class DtoResponseV1052ConvertXmlToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV1062ConvertJsonToExcel
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

    public class DtoResponseV1081ConvertJsonToYaml
    {
        [JsonProperty("yaml")]
        public string YAMLResponse { get; set; }
    }

    public class DtoResponseV1090ConvertJsonToTextTable
    {
        [JsonProperty("text")]
        public string TextResponse { get; set; }
    }

    public class DtoResponseV1100ConvertExcelToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }

        [JsonProperty("schema")]
        public string JSONSchemaResponse { get; set; }
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

    public class DtoResponseV2041Translate
    {
        [JsonProperty("firstTranslation")]
        public string FirstTranslationResponse { get; set; }

        [JsonProperty("translations")]
        public string[] TranslationsResponse { get; set; }
    }

    public class DtoResponseV2051SortJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoResponseV2061SortCsv
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
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

    public class DtoResponseV2110ReplaceTextWithPattern
    {
        [JsonProperty("text")]
        public string ReplacedText { get; set; }
    }

    public class DtoResponseV2120MatchPatternCheck
    {
        [JsonProperty("success")]
        public bool MatchSuccess { get; set; }
    }

    public class DtoResponseV2130SmartTextSplit
    {
        [JsonProperty("textSegments")]
        public string[] TextSegmentsAsList { get; set; }
    }

    public class DtoResponseV2140ExtractTextAccordingToPattern
    {
        [JsonProperty("matches")]
        public string[] TextMatchesAsList { get; set; }
    }

    public class DtoResponseV2150RunCode
    {
        [JsonProperty("result")]
        public string ResultResponse { get; set; }
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

    public class DtoResponseV3051ReadCode
    {
        [JsonProperty("codeValue")]
        public string CodeValue { get; set; }

        [JsonProperty("codeType")]
        public string CodeType { get; set; }
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

    public class DtoResponseV4012ConvertFileToPdf
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

    public class DtoResponseV7012ConvertHtmlTableToJson
    {
        [JsonProperty("firstTable")]
        public string FirstJSONTableResponse { get; set; }

        [JsonProperty("tables")]
        public string[] AllJSONTablesResponse { get; set; }
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

    public class DtoResponseHtml
    {
        [JsonProperty("html")]
        public string HTMLResponse { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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