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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CsvToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CsvToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CsvToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CsvToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExcelToJson(Expression<Func<string>> liquidTemplate = null, Expression<Func<string>> excelFile = null)
        {
            var __workflow_liquidTemplate = WorkflowExpression.Compile(liquidTemplate, nameof(liquidTemplate), required: false);
            var __workflow_excelFile = WorkflowExpression.Compile(excelFile, nameof(excelFile), required: false);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExcelToText(Expression<Func<string>> liquidTemplate = null, Expression<Func<string>> excelFile = null)
        {
            var __workflow_liquidTemplate = WorkflowExpression.Compile(liquidTemplate, nameof(liquidTemplate), required: false);
            var __workflow_excelFile = WorkflowExpression.Compile(excelFile, nameof(excelFile), required: false);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExcelToXml(Expression<Func<string>> liquidTemplate = null, Expression<Func<string>> excelFile = null)
        {
            var __workflow_liquidTemplate = WorkflowExpression.Compile(liquidTemplate, nameof(liquidTemplate), required: false);
            var __workflow_excelFile = WorkflowExpression.Compile(excelFile, nameof(excelFile), required: false);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> JsonToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/JsonToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> JsonToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> JsonToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/JsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> XmlToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/XmlToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/XmlToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EdiToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EdiToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToXml11(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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