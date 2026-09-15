//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Weavoliquidloom
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WeavoliquidloomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> CsvToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/CsvToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> CsvToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/CsvToText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> CsvToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/CsvToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> ExcelToJson(Expression<Func<string>> liquidTemplate = null, Expression<Func<string>> excelFile = null)
        {
            var apiCallPath = "/api/ExcelToJsonV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (liquidTemplate != null)
                callPayload.Queries["LiquidTemplate"] = CSharpExpressionConverter.ConvertO(liquidTemplate);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(excelFile);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> ExcelToText(Expression<Func<string>> liquidTemplate = null, Expression<Func<string>> excelFile = null)
        {
            var apiCallPath = "/api/ExcelToText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (liquidTemplate != null)
                callPayload.Queries["LiquidTemplate"] = CSharpExpressionConverter.ConvertO(liquidTemplate);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(excelFile);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> ExcelToXml(Expression<Func<string>> liquidTemplate = null, Expression<Func<string>> excelFile = null)
        {
            var apiCallPath = "/api/ExcelToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (liquidTemplate != null)
                callPayload.Queries["LiquidTemplate"] = CSharpExpressionConverter.ConvertO(liquidTemplate);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(excelFile);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> JsonToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/JsonToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> JsonToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/JsonToText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> JsonToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/JsonToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> XmlToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/XmlToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> XmlToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/XmlToText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> XmlToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/XmlToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            if (bodyliquidTemplate != null)
            {
                body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
                bodypropCount++;
            }

            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> EdiToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/EdiToJson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            bodypropCount++;
            body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> EdiToText(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/EdiToText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            bodypropCount++;
            body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> XmlToXml11(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
        {
            var apiCallPath = "/api/EdiToXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputString"] = CSharpExpressionConverter.ConvertToken(bodyinputString);
            bodypropCount++;
            body["liquidTemplate"] = CSharpExpressionConverter.ConvertToken(bodyliquidTemplate);
            if (bodylogFileName != null)
            {
                body["logFileName"] = CSharpExpressionConverter.ConvertToken(bodylogFileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
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