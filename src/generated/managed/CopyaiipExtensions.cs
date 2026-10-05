//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Copyaiip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CopyaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        [WorkflowExpressionFactory(nameof(__BuildWorkflowsGet))]
        public IBodyWorkflowAction<WorkflowsGetResponse> WorkflowsGet([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkflowsGetResponse> __BuildWorkflowsGet(WorkflowValue<string> workflowId, WorkflowValue<int> size = null, WorkflowValue<int> page = null)
        {
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<WorkflowsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflow/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = Convert.ToString(10);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<WorkflowsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        [WorkflowExpressionFactory(nameof(__BuildWorkflow))]
        public IBodyWorkflowAction<WorkflowPostResponse> Workflow([WorkflowExpression] Func<string> workflowId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkflowPostResponse> __BuildWorkflow(WorkflowValue<string> workflowId)
        {
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            return new DeferredBodyAction<WorkflowPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflow/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startVariablesObject = new JObject();
                var startVariablesObjectpropCount = 0;
                if (startVariablesObjectpropCount > 0)
                {
                    body["startVariables"] = startVariablesObject;
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorkflowPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        [WorkflowExpressionFactory(nameof(__BuildWorkflowGet))]
        public IBodyWorkflowAction<WorkflowGetResponse> WorkflowGet([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> runId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkflowGetResponse> __BuildWorkflowGet(WorkflowValue<string> workflowId, WorkflowValue<string> runId)
        {
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowValue.Validate(runId, nameof(runId), required: true);
            return new DeferredBodyAction<WorkflowGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflow/{0}/run/{1}", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkflowGetResponse>(callPayload);
            });
        }
    }

    public class CopyaiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class WorkflowsGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public WorkflowsGetResponseDataType Data { get; set; }
    }

    public class WorkflowsGetResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("data")]
        public WorkflowsGetResponseDataTypeDataTypeItem[] Data { get; set; }
    }

    public class WorkflowsGetResponseDataTypeDataTypeItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("input")]
        public JToken Input { get; set; }

        [JsonProperty("output")]
        public JToken Output { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }
    }

    public class WorkflowPostResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public WorkflowPostResponseDataType Data { get; set; }
    }

    public class WorkflowPostResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class WorkflowGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public WorkflowGetResponseDataType Data { get; set; }
    }

    public class WorkflowGetResponseDataType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("input")]
        public JToken Input { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Copyaiip;

    public partial class WorkflowManagedActions
    {
        public CopyaiipActions Copyaiip(string connectionId) => new CopyaiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CopyaiipTriggers Copyaiip(string connectionId) => new CopyaiipTriggers(connectionId);
    }
}
