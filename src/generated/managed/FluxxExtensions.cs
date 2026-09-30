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
        public IBodyWorkflowAction<object> DownloadDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rest/v2/model_document_download/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<JToken> CustomAction([WorkflowExpression] Func<string> endpoint, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(endpoint, nameof(endpoint), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/custom_action/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(endpoint, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = SourceExpressionConverter.Convert(method);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> CreateRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<object> bodydata = null)
        {
            SourceExpression.Validate(typeId, nameof(typeId), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(typeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse> FindRecords([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<object> bodydata = null, [WorkflowExpression] Func<int> currentPage = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(typeId, nameof(typeId), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            SourceExpression.Validate(currentPage, nameof(currentPage), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(typeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Queries["current_page"] = Convert.ToString(1);
                if (currentPage != null)
                    callPayload.Queries["current_page"] = SourceExpressionConverter.ConvertO(currentPage);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModelArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelArrayResponse> FindOrCreateRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<object> bodydata = null, [WorkflowExpression] Func<int> currentPage = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(typeId, nameof(typeId), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            SourceExpression.Validate(currentPage, nameof(currentPage), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(typeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                callPayload.Queries["current_page"] = Convert.ToString(1);
                if (currentPage != null)
                    callPayload.Queries["current_page"] = SourceExpressionConverter.ConvertO(currentPage);
                callPayload.Queries["per_page"] = Convert.ToString(10);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModelArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> FindRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(typeId, nameof(typeId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(typeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                return callPayload;
            }

            return new ApiConnectionAction<ModelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluxx")]
        public IBodyWorkflowAction<ModelResponse> UpdateRecord([WorkflowExpression] Func<string> typeId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> bodydata = null)
        {
            SourceExpression.Validate(typeId, nameof(typeId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rest/v2/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(typeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["all_core"] = Convert.ToString(1);
                callPayload.Queries["all_dynamic"] = Convert.ToString(1);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModelResponse>(BuildSourceInput);
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