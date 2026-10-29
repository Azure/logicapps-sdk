//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Weavoliquidloom
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WeavoliquidloomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CsvToJson(Expression<Func<CsvToJsonInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CsvToText(Expression<Func<CsvToTextInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CsvToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CsvToXml(Expression<Func<CsvToXmlInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExcelToJson(Expression<Func<string>> excelFile, Expression<Func<string>> liquidTemplate = null)
        {
            var __workflow_excelFile = WorkflowExpression.Compile(excelFile, nameof(excelFile), required: true);
            var __workflow_liquidTemplate = WorkflowExpression.Compile(liquidTemplate, nameof(liquidTemplate), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ExcelToJsonV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = ExpressionConverter.Convert(__workflow_liquidTemplate);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_excelFile);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExcelToText(Expression<Func<string>> excelFile, Expression<Func<string>> liquidTemplate = null)
        {
            var __workflow_excelFile = WorkflowExpression.Compile(excelFile, nameof(excelFile), required: true);
            var __workflow_liquidTemplate = WorkflowExpression.Compile(liquidTemplate, nameof(liquidTemplate), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ExcelToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = ExpressionConverter.Convert(__workflow_liquidTemplate);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_excelFile);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExcelToXml(Expression<Func<string>> excelFile, Expression<Func<string>> liquidTemplate = null)
        {
            var __workflow_excelFile = WorkflowExpression.Compile(excelFile, nameof(excelFile), required: true);
            var __workflow_liquidTemplate = WorkflowExpression.Compile(liquidTemplate, nameof(liquidTemplate), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ExcelToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = ExpressionConverter.Convert(__workflow_liquidTemplate);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_excelFile);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> JsonToJson(Expression<Func<JsonToJsonInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/JsonToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> JsonToText(Expression<Func<JsonToTextInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> JsonToXml(Expression<Func<JsonToXmlInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/JsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToJson(Expression<Func<XmlToJsonInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> XmlToText(Expression<Func<XmlToTextInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/XmlToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToXml(Expression<Func<XmlToXmlInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/XmlToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EdiToJson(Expression<Func<EdiToJsonInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EdiToText(Expression<Func<EdiToTextInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToXml11(Expression<Func<XmlToXml11Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WeavoliquidloomTriggers([ConnectionName] string connectionId)
    {
    }

    public class CsvToJsonInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class CsvToTextInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class CsvToXmlInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class JsonToJsonInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class JsonToTextInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class JsonToXmlInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class XmlToJsonInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class XmlToTextInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class XmlToXmlInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class EdiToJsonInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class EdiToTextInput
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
    }

    public class XmlToXml11Input
    {
        [JsonProperty("inputString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty("liquidTemplate")]
        public string LiquidTemplate { get; set; }

        [JsonProperty("logFileName")]
        public string LogFileName { get; set; }
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