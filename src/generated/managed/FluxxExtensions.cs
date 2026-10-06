//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fluxx
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FluxxActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadDocument))]
        public IBodyWorkflowAction<object> DownloadDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildDownloadDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/model_document_download/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [WorkflowExpressionFactory(nameof(__BuildCustomAction))]
        public IBodyWorkflowAction<JToken> CustomAction([WorkflowExpression] Func<string> endpoint, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCustomAction(WorkflowExpression<string> endpoint, WorkflowExpression<methodInput> method, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(endpoint, nameof(endpoint), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/custom_action/{0}", ExpressionConverter.ConvertWithUrlEncoding(endpoint, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument([WorkflowExpression] Func<object> content, [WorkflowExpression] Func<string> dataOwnerModelModelType, [WorkflowExpression] Func<int> dataOwnerModelId, [WorkflowExpression] Func<string> dataContentType, [WorkflowExpression] Func<int> dataCreatedById)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadDocumentResponse> __BuildUploadDocument(WorkflowExpression<object> content, WorkflowExpression<string> dataOwnerModelModelType, WorkflowExpression<int> dataOwnerModelId, WorkflowExpression<string> dataContentType, WorkflowExpression<int> dataCreatedById)
        {
            WorkflowExpression.Validate(content, nameof(content), required: true);
            WorkflowExpression.Validate(dataOwnerModelModelType, nameof(dataOwnerModelModelType), required: true);
            WorkflowExpression.Validate(dataOwnerModelId, nameof(dataOwnerModelId), required: true);
            WorkflowExpression.Validate(dataContentType, nameof(dataContentType), required: true);
            WorkflowExpression.Validate(dataCreatedById, nameof(dataCreatedById), required: true);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateRecord))]
        public IBodyWorkflowAction<ModelResponse> CreateRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<object> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelResponse> __BuildCreateRecord(WorkflowExpression<string> typeId, WorkflowExpression<object> bodydata = null)
        {
            WorkflowExpression.Validate(typeId, nameof(typeId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
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
        [WorkflowExpressionFactory(nameof(__BuildFindRecords))]
        public IBodyWorkflowAction<ModelArrayResponse> FindRecords([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<object> bodydata = null, [WorkflowExpression] Func<int> currentPage = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelArrayResponse> __BuildFindRecords(WorkflowExpression<string> typeId, WorkflowExpression<object> bodydata = null, WorkflowExpression<int> currentPage = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(typeId, nameof(typeId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            WorkflowExpression.Validate(currentPage, nameof(currentPage), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Queries["current_page"] = Convert.ToString(1);
                if (currentPage != null)
                    callPayload.Queries["current_page"] = ExpressionConverter.Convert(currentPage);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
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
        [WorkflowExpressionFactory(nameof(__BuildFindOrCreateRecord))]
        public IBodyWorkflowAction<ModelArrayResponse> FindOrCreateRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<object> bodydata = null, [WorkflowExpression] Func<int> currentPage = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelArrayResponse> __BuildFindOrCreateRecord(WorkflowExpression<string> typeId, WorkflowExpression<object> bodydata = null, WorkflowExpression<int> currentPage = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(typeId, nameof(typeId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            WorkflowExpression.Validate(currentPage, nameof(currentPage), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ModelArrayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Queries["current_page"] = Convert.ToString(1);
                if (currentPage != null)
                    callPayload.Queries["current_page"] = ExpressionConverter.Convert(currentPage);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
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
        [WorkflowExpressionFactory(nameof(__BuildFindRecord))]
        public IBodyWorkflowAction<ModelResponse> FindRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelResponse> __BuildFindRecord(WorkflowExpression<string> typeId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(typeId, nameof(typeId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                return new ApiConnectionAction<ModelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRecord))]
        public IBodyWorkflowAction<ModelResponse> UpdateRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelResponse> __BuildUpdateRecord(WorkflowExpression<string> typeId, WorkflowExpression<string> id, WorkflowExpression<object> bodydata = null)
        {
            WorkflowExpression.Validate(typeId, nameof(typeId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<ModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
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