//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Weavoliquidloom
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WeavoliquidloomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildCsvToJson))]
        public IBodyWorkflowAction<JToken> CsvToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCsvToJson(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildCsvToText))]
        public IBodyWorkflowAction<string> CsvToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCsvToText(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/CsvToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildCsvToXml))]
        public IBodyWorkflowAction<JToken> CsvToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCsvToXml(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/CsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildExcelToJson))]
        public IBodyWorkflowAction<JToken> ExcelToJson([WorkflowExpression] Func<string> liquidTemplate = null, [WorkflowExpression] Func<string> excelFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExcelToJson(WorkflowValue<string> liquidTemplate = null, WorkflowValue<string> excelFile = null)
        {
            WorkflowValue.Validate(liquidTemplate, nameof(liquidTemplate), required: false);
            WorkflowValue.Validate(excelFile, nameof(excelFile), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/ExcelToJsonV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = ExpressionConverter.Convert(liquidTemplate);
                callPayload.Body = ExpressionConverter.ConvertO(excelFile);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildExcelToText))]
        public IBodyWorkflowAction<string> ExcelToText([WorkflowExpression] Func<string> liquidTemplate = null, [WorkflowExpression] Func<string> excelFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExcelToText(WorkflowValue<string> liquidTemplate = null, WorkflowValue<string> excelFile = null)
        {
            WorkflowValue.Validate(liquidTemplate, nameof(liquidTemplate), required: false);
            WorkflowValue.Validate(excelFile, nameof(excelFile), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/ExcelToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = ExpressionConverter.Convert(liquidTemplate);
                callPayload.Body = ExpressionConverter.ConvertO(excelFile);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildExcelToXml))]
        public IBodyWorkflowAction<JToken> ExcelToXml([WorkflowExpression] Func<string> liquidTemplate = null, [WorkflowExpression] Func<string> excelFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExcelToXml(WorkflowValue<string> liquidTemplate = null, WorkflowValue<string> excelFile = null)
        {
            WorkflowValue.Validate(liquidTemplate, nameof(liquidTemplate), required: false);
            WorkflowValue.Validate(excelFile, nameof(excelFile), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/ExcelToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = ExpressionConverter.Convert(liquidTemplate);
                callPayload.Body = ExpressionConverter.ConvertO(excelFile);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildJsonToJson))]
        public IBodyWorkflowAction<JToken> JsonToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildJsonToJson(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/JsonToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildJsonToText))]
        public IBodyWorkflowAction<string> JsonToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildJsonToText(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildJsonToXml))]
        public IBodyWorkflowAction<JToken> JsonToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildJsonToXml(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/JsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildXmlToJson))]
        public IBodyWorkflowAction<JToken> XmlToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildXmlToJson(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildXmlToText))]
        public IBodyWorkflowAction<string> XmlToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildXmlToText(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/XmlToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildXmlToXml))]
        public IBodyWorkflowAction<JToken> XmlToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildXmlToXml(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate = null, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/XmlToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildEdiToJson))]
        public IBodyWorkflowAction<JToken> EdiToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildEdiToJson(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildEdiToText))]
        public IBodyWorkflowAction<string> EdiToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildEdiToText(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/EdiToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        [WorkflowExpressionFactory(nameof(__BuildXmlToXml11))]
        public IBodyWorkflowAction<JToken> XmlToXml11([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildXmlToXml11(WorkflowValue<string> bodyinputString, WorkflowValue<string> bodyliquidTemplate, WorkflowValue<string> bodylogFileName = null)
        {
            WorkflowValue.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowValue.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            WorkflowValue.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WeavoliquidloomTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Weavoliquidloom;

    public partial class WorkflowManagedActions
    {
        public WeavoliquidloomActions Weavoliquidloom(string connectionId) => new WeavoliquidloomActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WeavoliquidloomTriggers Weavoliquidloom(string connectionId) => new WeavoliquidloomTriggers(connectionId);
    }
}
