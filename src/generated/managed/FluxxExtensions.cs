//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fluxx
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FluxxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<object> DownloadDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/rest/v2/model_document_download/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<JToken> CustomAction(Expression<Func<string>> endpoint, Expression<Func<methodInput>> method, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/custom_action/{0}", ExpressionConverter.ConvertWithUrlEncoding(endpoint, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument(Expression<Func<object>> content, Expression<Func<string>> dataOwnerModelModelType, Expression<Func<int>> dataOwnerModelId, Expression<Func<string>> dataContentType, Expression<Func<int>> dataCreatedById)
        {
            var apiCallPath = "/api/rest/v2/model_document";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cols"] = Convert.ToString("[\"document_file_name\",\"document_content_type\",\"doc_label\"]");
            return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> CreateRecord(Expression<Func<string>> typeId, Expression<Func<object>> bodydata = null)
        {
            var apiCallPath = String.Format("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse> FindRecords(Expression<Func<string>> typeId, Expression<Func<object>> bodydata = null, Expression<Func<int>> currentPage = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse> FindOrCreateRecord(Expression<Func<string>> typeId, Expression<Func<object>> bodydata = null, Expression<Func<int>> currentPage = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/api/rest/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> FindRecord(Expression<Func<string>> typeId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/rest/v2/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["all_core"] = Convert.ToString(1);
            callPayload.Queries["all_dynamic"] = Convert.ToString(1);
            return new ApiConnectionAction<ModelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> UpdateRecord(Expression<Func<string>> typeId, Expression<Func<string>> id, Expression<Func<object>> bodydata = null)
        {
            var apiCallPath = String.Format("/api/rest/v2/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(typeId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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