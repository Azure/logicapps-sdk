//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fluxx
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FluxxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/model_document_download/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CustomAction(Expression<Func<string>> endpoint, Expression<Func<methodInput>> method, Expression<Func<string>> body = null)
        {
            var __workflow_endpoint = WorkflowExpression.Compile(endpoint, nameof(endpoint), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/custom_action/{0}", __workflow_endpoint.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse, ApiConnectionActionConfiguration> CreateRecord(Expression<Func<string>> typeId, Expression<Func<CreateRecordInput>> body = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ModelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}", __workflow_typeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse, ApiConnectionActionConfiguration> FindRecords(Expression<Func<string>> typeId, Expression<Func<FindRecordsInput>> body = null, Expression<Func<int>> currentPage = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_currentPage = WorkflowExpression.Compile(currentPage, nameof(currentPage), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}", __workflow_typeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Queries["current_page"] = Convert.ToString(1);
                if (__workflow_currentPage != null)
                    callPayload.Queries["current_page"] = ExpressionConverter.Convert(__workflow_currentPage);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModelArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse, ApiConnectionActionConfiguration> FindOrCreateRecord(Expression<Func<string>> typeId, Expression<Func<FindOrCreateRecordInput>> body = null, Expression<Func<int>> currentPage = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_currentPage = WorkflowExpression.Compile(currentPage, nameof(currentPage), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}", __workflow_typeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Queries["current_page"] = Convert.ToString(1);
                if (__workflow_currentPage != null)
                    callPayload.Queries["current_page"] = ExpressionConverter.Convert(__workflow_currentPage);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModelArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse, ApiConnectionActionConfiguration> FindRecord(Expression<Func<string>> typeId, Expression<Func<string>> id)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}/{1}", __workflow_typeId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                return new ApiConnectionAction<ModelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse, ApiConnectionActionConfiguration> UpdateRecord(Expression<Func<string>> typeId, Expression<Func<string>> id, Expression<Func<UpdateRecordInput>> body)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ModelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}/{1}", __workflow_typeId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModelResponse>(callPayload);
            });
        }
    }

    public class FluxxTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        PUT,
        POST
    }

    public class ModelResponse
    {
        [JsonProperty("model")]
        public JToken Model { get; set; }
    }

    public class CreateRecordInput
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class ModelArrayResponse
    {
        [JsonProperty("model")]
        public JToken[] Model { get; set; }
    }

    public class FindRecordsInput
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class FindOrCreateRecordInput
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class UpdateRecordInput
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fluxx;

    public partial class WorkflowManagedActions
    {
        public FluxxActions Fluxx(string connectionId) => new FluxxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FluxxTriggers Fluxx(string connectionId) => new FluxxTriggers(connectionId);
    }
}