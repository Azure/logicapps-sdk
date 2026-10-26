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
        public IWorkflowAction<ApiConnectionActionConfiguration> InvokeMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<InvokeMCPInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/runtime/webhooks/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
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
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> CreateConfigurationFromCopy(Expression<Func<CreateConfigurationFromCopyInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateConfigurationFromCopy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> UpdateConfiguration(Expression<Func<UpdateConfigurationInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> CreateConfiguration(Expression<Func<CreateConfigurationInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> CreateConfigurationFromChanges(Expression<Func<CreateConfigurationFromChangesInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateConfigurationFromChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationResponse, ApiConnectionActionConfiguration> UpdateConfigurationFromChanges(Expression<Func<UpdateConfigurationFromChangesInput>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<GetConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateConfigurationFromChanges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetModelMetadataResponse, ApiConnectionActionConfiguration> GetModelMetadata(Expression<Func<GetModelMetadataInput>> req = null)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: false);
            return new DeferredBodyAction<GetModelMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ModelMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_req != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<GetModelMetadataResponse>(callPayload);
            });
        }
    }

    public class ExperlogixcpqTriggers([ConnectionName] string connectionId)
    {
    }

    public class InvokeMCPInput
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
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

    public class CreateConfigurationFromCopyInput
    {
        [JsonProperty("targetId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetId { get; set; }

        [JsonProperty("sourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("lineItemIds")]
        public int[] LineItemIds { get; set; }
    }

    public class UpdateConfigurationInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("configurationXml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConfigurationXml { get; set; }
    }

    public class CreateConfigurationInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("configurationXml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConfigurationXml { get; set; }
    }

    public class CreateConfigurationFromChangesInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("seriesId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SeriesId { get; set; }

        [JsonProperty("modelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ModelId { get; set; }

        [JsonProperty("changes")]
        public ChangeConfig[] Changes { get; set; }

        [JsonProperty("saveConfiguration", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveConfiguration { get; set; } = true;
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

    public class UpdateConfigurationFromChangesInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("changes")]
        public ChangeConfig[] Changes { get; set; }

        [JsonProperty("saveConfiguration", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveConfiguration { get; set; } = true;
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

    public class GetModelMetadataInput
    {
        [JsonProperty("relevantCategories")]
        public string[] RelevantCategories { get; set; }
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