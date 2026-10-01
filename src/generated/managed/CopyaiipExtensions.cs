//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Copyaiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CopyaiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowsGetResponse> WorkflowsGet([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflow/{0}/run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = Convert.ToString(10);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowPostResponse> Workflow([WorkflowExpression] Func<string> workflowId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflow/{0}/run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
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
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copyaiip")]
        public IBodyWorkflowAction<WorkflowGetResponse> WorkflowGet([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> runId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflow/{0}/run/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowGetResponse>(BuildSourceInput);
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