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
        public IBodyWorkflowAction<WorkflowsGetResponse, ApiConnectionActionConfiguration> WorkflowsGet(Expression<Func<string>> workflowId, Expression<Func<int>> size = null, Expression<Func<int>> page = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<WorkflowsGetResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowPostResponse, ApiConnectionActionConfiguration> Workflow(Expression<Func<string>> workflowId, Expression<Func<WorkflowPostInput>> body = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkflowPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow/{0}/run", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkflowPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowGetResponse, ApiConnectionActionConfiguration> WorkflowGet(Expression<Func<string>> workflowId, Expression<Func<string>> runId)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<WorkflowGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow/{0}/run/{1}", __workflow_workflowId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
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

    public class WorkflowPostInput
    {
        [JsonProperty("startVariables")]
        public JToken StartVariables { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
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