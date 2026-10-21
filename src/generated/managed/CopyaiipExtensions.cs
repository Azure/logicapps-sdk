//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Copyaiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CopyaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowsGetResponse> WorkflowsGet(Expression<Func<string>> workflowId, Expression<Func<int>> size = null, Expression<Func<int>> page = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<WorkflowsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow/{0}/run", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = Convert.ToString(10);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<WorkflowsGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowPostResponse> Workflow(Expression<Func<string>> workflowId)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            return new DeferredBodyAction<WorkflowPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow/{0}/run", __workflow_workflowId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowGetResponse> WorkflowGet(Expression<Func<string>> workflowId, Expression<Func<string>> runId)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<WorkflowGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow/{0}/run/{1}", __workflow_workflowId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkflowGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
