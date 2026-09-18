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
        public IBodyWorkflowAction<JToken> CsvToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> CsvToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CsvToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> CsvToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CsvToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> ExcelToJson([WorkflowExpression] Func<string> liquidTemplate = null, [WorkflowExpression] Func<string> excelFile = null)
        {
            SourceExpression.Validate(liquidTemplate, nameof(liquidTemplate), required: false);
            SourceExpression.Validate(excelFile, nameof(excelFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ExcelToJsonV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = SourceExpressionConverter.ConvertO(liquidTemplate);
                callPayload.Body = SourceExpressionConverter.ConvertToken(excelFile);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> ExcelToText([WorkflowExpression] Func<string> liquidTemplate = null, [WorkflowExpression] Func<string> excelFile = null)
        {
            SourceExpression.Validate(liquidTemplate, nameof(liquidTemplate), required: false);
            SourceExpression.Validate(excelFile, nameof(excelFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ExcelToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = SourceExpressionConverter.ConvertO(liquidTemplate);
                callPayload.Body = SourceExpressionConverter.ConvertToken(excelFile);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> ExcelToXml([WorkflowExpression] Func<string> liquidTemplate = null, [WorkflowExpression] Func<string> excelFile = null)
        {
            SourceExpression.Validate(liquidTemplate, nameof(liquidTemplate), required: false);
            SourceExpression.Validate(excelFile, nameof(excelFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ExcelToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (liquidTemplate != null)
                    callPayload.Queries["LiquidTemplate"] = SourceExpressionConverter.ConvertO(liquidTemplate);
                callPayload.Body = SourceExpressionConverter.ConvertToken(excelFile);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> JsonToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/JsonToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> JsonToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> JsonToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/JsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> XmlToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> XmlToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/XmlToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> XmlToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate = null, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/XmlToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                if (bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                    bodypropCount++;
                }

                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> EdiToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<string> EdiToText([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/EdiToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weavoliquidloom")]
        public IBodyWorkflowAction<JToken> XmlToXml11([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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