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
        public IBodyWorkflowAction<object> DownloadDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/model_document_download/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<JToken> CustomAction(Expression<Func<string>> endpoint, Expression<Func<methodInput>> method, Expression<Func<string>> body = null)
        {
            var __workflow_endpoint = WorkflowExpression.Compile(endpoint, nameof(endpoint), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/custom_action/{0}", __workflow_endpoint.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument(Expression<Func<object>> content, Expression<Func<string>> dataOwnerModelModelType, Expression<Func<int>> dataOwnerModelId, Expression<Func<string>> dataContentType, Expression<Func<int>> dataCreatedById)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            var __workflow_dataOwnerModelModelType = WorkflowExpression.Compile(dataOwnerModelModelType, nameof(dataOwnerModelModelType), required: true);
            var __workflow_dataOwnerModelId = WorkflowExpression.Compile(dataOwnerModelId, nameof(dataOwnerModelId), required: true);
            var __workflow_dataContentType = WorkflowExpression.Compile(dataContentType, nameof(dataContentType), required: true);
            var __workflow_dataCreatedById = WorkflowExpression.Compile(dataCreatedById, nameof(dataCreatedById), required: true);
            return new DeferredBodyAction<UploadDocumentResponse>(() =>
            {
                var apiCallPath = "/api/rest/v2/model_document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cols"] = Convert.ToString("[\"document_file_name\",\"document_content_type\",\"doc_label\"]");
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> CreateRecord(Expression<Func<string>> typeId, Expression<Func<object>> bodydata = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}", __workflow_typeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse> FindRecords(Expression<Func<string>> typeId, Expression<Func<object>> bodydata = null, Expression<Func<int>> currentPage = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            var __workflow_currentPage = WorkflowExpression.Compile(currentPage, nameof(currentPage), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse>(() =>
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
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModelArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse> FindOrCreateRecord(Expression<Func<string>> typeId, Expression<Func<object>> bodydata = null, Expression<Func<int>> currentPage = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            var __workflow_currentPage = WorkflowExpression.Compile(currentPage, nameof(currentPage), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse>(() =>
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
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModelArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> FindRecord(Expression<Func<string>> typeId, Expression<Func<string>> id)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelResponse>(() =>
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
        public IBodyWorkflowAction<ModelResponse> UpdateRecord(Expression<Func<string>> typeId, Expression<Func<string>> id, Expression<Func<object>> bodydata = null)
        {
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rest/v2/{0}/{1}", __workflow_typeId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class UploadDocumentResponse
    {
        [JsonProperty("document_file_name")]
        public string DocumentFileName { get; set; }

        [JsonProperty("document_content_type")]
        public string DocumentContentType { get; set; }

        [JsonProperty("doc_label")]
        public string DocLabel { get; set; }
    }

    public class ModelResponse
    {
        [JsonProperty("model")]
        public JToken Model { get; set; }
    }

    public class ModelArrayResponse
    {
        [JsonProperty("model")]
        public JToken[] Model { get; set; }
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
