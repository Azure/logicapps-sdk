//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fluxx
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class FluxxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<object> DownloadDocument(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/model_document_download/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<JToken> CustomAction(Expression<Func<string>> endpoint, Expression<Func<methodInput>> method, Expression<Func<string>> body = null)
        {
            var __workflow_endpoint = endpoint == null ? null : WorkflowExpression.Compile(endpoint);
            WorkflowExpression.Validate(__workflow_endpoint, nameof(endpoint), required: true);
            var __workflow_method = method == null ? null : WorkflowExpression.Compile(method);
            WorkflowExpression.Validate(__workflow_method, nameof(method), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/custom_action/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_endpoint, 1));
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
            var __workflow_content = content == null ? null : WorkflowExpression.Compile(content);
            WorkflowExpression.Validate(__workflow_content, nameof(content), required: true);
            var __workflow_dataOwnerModelModelType = dataOwnerModelModelType == null ? null : WorkflowExpression.Compile(dataOwnerModelModelType);
            WorkflowExpression.Validate(__workflow_dataOwnerModelModelType, nameof(dataOwnerModelModelType), required: true);
            var __workflow_dataOwnerModelId = dataOwnerModelId == null ? null : WorkflowExpression.Compile(dataOwnerModelId);
            WorkflowExpression.Validate(__workflow_dataOwnerModelId, nameof(dataOwnerModelId), required: true);
            var __workflow_dataContentType = dataContentType == null ? null : WorkflowExpression.Compile(dataContentType);
            WorkflowExpression.Validate(__workflow_dataContentType, nameof(dataContentType), required: true);
            var __workflow_dataCreatedById = dataCreatedById == null ? null : WorkflowExpression.Compile(dataCreatedById);
            WorkflowExpression.Validate(__workflow_dataCreatedById, nameof(dataCreatedById), required: true);
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
            var __workflow_typeId = typeId == null ? null : WorkflowExpression.Compile(typeId);
            WorkflowExpression.Validate(__workflow_typeId, nameof(typeId), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_typeId, 1));
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
            var __workflow_typeId = typeId == null ? null : WorkflowExpression.Compile(typeId);
            WorkflowExpression.Validate(__workflow_typeId, nameof(typeId), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: false);
            var __workflow_currentPage = currentPage == null ? null : WorkflowExpression.Compile(currentPage);
            WorkflowExpression.Validate(__workflow_currentPage, nameof(currentPage), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_typeId, 1));
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
            var __workflow_typeId = typeId == null ? null : WorkflowExpression.Compile(typeId);
            WorkflowExpression.Validate(__workflow_typeId, nameof(typeId), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: false);
            var __workflow_currentPage = currentPage == null ? null : WorkflowExpression.Compile(currentPage);
            WorkflowExpression.Validate(__workflow_currentPage, nameof(currentPage), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_typeId, 1));
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
            var __workflow_typeId = typeId == null ? null : WorkflowExpression.Compile(typeId);
            WorkflowExpression.Validate(__workflow_typeId, nameof(typeId), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_typeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
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
            var __workflow_typeId = typeId == null ? null : WorkflowExpression.Compile(typeId);
            WorkflowExpression.Validate(__workflow_typeId, nameof(typeId), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_typeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
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
