//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/webhooks/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> GetConfigurationXml(Expression<Func<string>> type, Expression<Func<string>> id)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ConfigurationXml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> CreateConfigurationFromCopy(Expression<Func<string>> reqtargetId, Expression<Func<string>> reqsourceId, Expression<Func<string>> reqtype, Expression<Func<int[]>> reqlineItemIds = null)
        {
            var __workflow_reqtargetId = WorkflowExpression.Compile(reqtargetId, nameof(reqtargetId), required: true);
            var __workflow_reqsourceId = WorkflowExpression.Compile(reqsourceId, nameof(reqsourceId), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqlineItemIds = WorkflowExpression.Compile(reqlineItemIds, nameof(reqlineItemIds), required: false);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateConfigurationFromCopy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["targetId"] = ExpressionConverter.ConvertO(__workflow_reqtargetId);
                reqpropCount++;
                req["sourceId"] = ExpressionConverter.ConvertO(__workflow_reqsourceId);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                if (__workflow_reqlineItemIds != null)
                {
                    req["lineItemIds"] = ExpressionConverter.ConvertO(__workflow_reqlineItemIds);
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> UpdateConfiguration(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqconfigurationXml)
        {
            var __workflow_reqid = WorkflowExpression.Compile(reqid, nameof(reqid), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqconfigurationXml = WorkflowExpression.Compile(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = ExpressionConverter.ConvertO(__workflow_reqid);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                reqpropCount++;
                req["configurationXml"] = ExpressionConverter.ConvertO(__workflow_reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> CreateConfiguration(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqconfigurationXml)
        {
            var __workflow_reqid = WorkflowExpression.Compile(reqid, nameof(reqid), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqconfigurationXml = WorkflowExpression.Compile(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = ExpressionConverter.ConvertO(__workflow_reqid);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                reqpropCount++;
                req["configurationXml"] = ExpressionConverter.ConvertO(__workflow_reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> CreateConfigurationFromChanges(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqseriesId, Expression<Func<string>> reqmodelId, Expression<Func<ChangeConfig[]>> reqchanges = null, Expression<Func<bool>> reqsaveConfiguration = null)
        {
            var __workflow_reqid = WorkflowExpression.Compile(reqid, nameof(reqid), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqseriesId = WorkflowExpression.Compile(reqseriesId, nameof(reqseriesId), required: true);
            var __workflow_reqmodelId = WorkflowExpression.Compile(reqmodelId, nameof(reqmodelId), required: true);
            var __workflow_reqchanges = WorkflowExpression.Compile(reqchanges, nameof(reqchanges), required: false);
            var __workflow_reqsaveConfiguration = WorkflowExpression.Compile(reqsaveConfiguration, nameof(reqsaveConfiguration), required: false);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateConfigurationFromChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = ExpressionConverter.ConvertO(__workflow_reqid);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                reqpropCount++;
                req["seriesId"] = ExpressionConverter.ConvertO(__workflow_reqseriesId);
                reqpropCount++;
                req["modelId"] = ExpressionConverter.ConvertO(__workflow_reqmodelId);
                if (__workflow_reqchanges != null)
                {
                    req["changes"] = ExpressionConverter.ConvertO(__workflow_reqchanges);
                    reqpropCount++;
                }

                if (__workflow_reqsaveConfiguration != null)
                {
                    if (__workflow_reqsaveConfiguration != null)
                    {
                        req["saveConfiguration"] = ExpressionConverter.ConvertO(__workflow_reqsaveConfiguration);
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

                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> UpdateConfigurationFromChanges(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<ChangeConfig[]>> reqchanges = null, Expression<Func<bool>> reqsaveConfiguration = null)
        {
            var __workflow_reqid = WorkflowExpression.Compile(reqid, nameof(reqid), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqchanges = WorkflowExpression.Compile(reqchanges, nameof(reqchanges), required: false);
            var __workflow_reqsaveConfiguration = WorkflowExpression.Compile(reqsaveConfiguration, nameof(reqsaveConfiguration), required: false);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateConfigurationFromChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = ExpressionConverter.ConvertO(__workflow_reqid);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                if (__workflow_reqchanges != null)
                {
                    req["changes"] = ExpressionConverter.ConvertO(__workflow_reqchanges);
                    reqpropCount++;
                }

                if (__workflow_reqsaveConfiguration != null)
                {
                    if (__workflow_reqsaveConfiguration != null)
                    {
                        req["saveConfiguration"] = ExpressionConverter.ConvertO(__workflow_reqsaveConfiguration);
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

                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetModelMetadataResponse, ApiConnectionActionConfiguration> GetModelMetadata(Expression<Func<string[]>> reqrelevantCategories = null)
        {
            var __workflow_reqrelevantCategories = WorkflowExpression.Compile(reqrelevantCategories, nameof(reqrelevantCategories), required: false);
            return new DeferredBodyAction<GetModelMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ModelMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                if (__workflow_reqrelevantCategories != null)
                {
                    req["relevantCategories"] = ExpressionConverter.ConvertO(__workflow_reqrelevantCategories);
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetModelMetadataResponse>(callPayload);
            });
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
        [JsonProperty("CatID")]
        public string CatId { get; set; }
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