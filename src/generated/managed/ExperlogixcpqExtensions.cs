//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IWorkflowAction InvokeMCP([WorkflowExpression] Func<string> mcpSessionId = null, [WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/runtime/webhooks/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = SourceExpressionConverter.ConvertO(mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
                    queryRequestpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    queryRequest["params"] = @paramsObject;
                    queryRequestpropCount++;
                }

                var resultObject = new JObject();
                var resultObjectpropCount = 0;
                if (resultObjectpropCount > 0)
                {
                    queryRequest["result"] = resultObject;
                    queryRequestpropCount++;
                }

                var errorObject = new JObject();
                var errorObjectpropCount = 0;
                if (errorObjectpropCount > 0)
                {
                    queryRequest["error"] = errorObject;
                    queryRequestpropCount++;
                }

                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse> GetConfigurationXml([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ConfigurationXml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse> CreateConfigurationFromCopy([WorkflowExpression] Func<string> reqtargetId, [WorkflowExpression] Func<string> reqsourceId, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<int[]> reqlineItemIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateConfigurationFromCopy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["targetId"] = SourceExpressionConverter.ConvertToken(reqtargetId);
                reqpropCount++;
                req["sourceId"] = SourceExpressionConverter.ConvertToken(reqsourceId);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                if (reqlineItemIds != null)
                {
                    req["lineItemIds"] = SourceExpressionConverter.ConvertToken(reqlineItemIds);
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse> UpdateConfiguration([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqconfigurationXml)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UpdateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = SourceExpressionConverter.ConvertToken(reqid);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                reqpropCount++;
                req["configurationXml"] = SourceExpressionConverter.ConvertToken(reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse> CreateConfiguration([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqconfigurationXml)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = SourceExpressionConverter.ConvertToken(reqid);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                reqpropCount++;
                req["configurationXml"] = SourceExpressionConverter.ConvertToken(reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse> CreateConfigurationFromChanges([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqseriesId, [WorkflowExpression] Func<string> reqmodelId, [WorkflowExpression] Func<ChangeConfig[]> reqchanges = null, [WorkflowExpression] Func<bool> reqsaveConfiguration = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateConfigurationFromChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = SourceExpressionConverter.ConvertToken(reqid);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                reqpropCount++;
                req["seriesId"] = SourceExpressionConverter.ConvertToken(reqseriesId);
                reqpropCount++;
                req["modelId"] = SourceExpressionConverter.ConvertToken(reqmodelId);
                if (reqchanges != null)
                {
                    req["changes"] = SourceExpressionConverter.ConvertToken(reqchanges);
                    reqpropCount++;
                }

                if (reqsaveConfiguration != null)
                {
                    if (reqsaveConfiguration != null)
                    {
                        req["saveConfiguration"] = SourceExpressionConverter.ConvertToken(reqsaveConfiguration);
                        reqpropCount++;
                    }

                    reqpropCount++;
                }
                else
                {
                    req["saveConfiguration"] = true;
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse> UpdateConfigurationFromChanges([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<ChangeConfig[]> reqchanges = null, [WorkflowExpression] Func<bool> reqsaveConfiguration = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UpdateConfigurationFromChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = SourceExpressionConverter.ConvertToken(reqid);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                if (reqchanges != null)
                {
                    req["changes"] = SourceExpressionConverter.ConvertToken(reqchanges);
                    reqpropCount++;
                }

                if (reqsaveConfiguration != null)
                {
                    if (reqsaveConfiguration != null)
                    {
                        req["saveConfiguration"] = SourceExpressionConverter.ConvertToken(reqsaveConfiguration);
                        reqpropCount++;
                    }

                    reqpropCount++;
                }
                else
                {
                    req["saveConfiguration"] = true;
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetModelMetadataResponse> GetModelMetadata([WorkflowExpression] Func<string[]> reqrelevantCategories = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ModelMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                if (reqrelevantCategories != null)
                {
                    req["relevantCategories"] = SourceExpressionConverter.ConvertToken(reqrelevantCategories);
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetModelMetadataResponse>(BuildSourceInput);
        }
    }

    public class ExperlogixcpqTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetConfigurationResponse
    {
        [JsonProperty("configurationXml")]
        public string ConfigurationXml { get; set; }

        [JsonProperty("configureUrl")]
        public string ConfigureUrl { get; set; }

        [JsonProperty("lineItemIds")]
        public int[] LineItemIds { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }

    public class ChangeConfig
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("configLineIndex")]
        public int ConfigLineIndex { get; set; }

        [JsonProperty("changeType")]
        public string ChangeType { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("optionId")]
        public string OptionId { get; set; }

        [JsonProperty("selectionIndex")]
        public int SelectionIndex { get; set; }

        [JsonProperty("propertyId")]
        public string PropertyId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetModelMetadataResponse
    {
        public GetModelMetadataResponseCategoriesTypeItem[] Categories { get; set; }
        public JToken CategoryOptions { get; set; }
        public JToken CategoryProperties { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }

    public class GetModelMetadataResponseCategoriesTypeItem
    {
        public string CatID { get; set; }
        public string Description { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq;

    public partial class WorkflowManagedActions
    {
        public ExperlogixcpqActions Experlogixcpq(string connectionId) => new ExperlogixcpqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExperlogixcpqTriggers Experlogixcpq(string connectionId) => new ExperlogixcpqTriggers(connectionId);
    }
}