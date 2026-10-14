//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatafactory
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzuredatafactoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IBodyWorkflowAction<CreatePipelineRunResponse> CreatePipelineRun(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> dataFactoryName, Expression<Func<string>> pipelineName, Expression<Func<string>> referencePipelineRunId = null)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_dataFactoryName = dataFactoryName == null ? null : WorkflowExpression.Compile(dataFactoryName);
            WorkflowExpression.Validate(__workflow_dataFactoryName, nameof(dataFactoryName), required: true);
            var __workflow_pipelineName = pipelineName == null ? null : WorkflowExpression.Compile(pipelineName);
            WorkflowExpression.Validate(__workflow_pipelineName, nameof(pipelineName), required: true);
            var __workflow_referencePipelineRunId = referencePipelineRunId == null ? null : WorkflowExpression.Compile(referencePipelineRunId);
            WorkflowExpression.Validate(__workflow_referencePipelineRunId, nameof(referencePipelineRunId), required: false);
            return new DeferredBodyAction<CreatePipelineRunResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelines/{3}/CreateRun", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_pipelineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_referencePipelineRunId != null)
                    callPayload.Queries["referencePipelineRunId"] = ExpressionConverter.Convert(__workflow_referencePipelineRunId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                var parameters = new JObject();
                var parameterspropCount = 0;
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<CreatePipelineRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IWorkflowAction CancelPipelineRun(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> dataFactoryName, Expression<Func<string>> pipelineRunName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_dataFactoryName = dataFactoryName == null ? null : WorkflowExpression.Compile(dataFactoryName);
            WorkflowExpression.Validate(__workflow_dataFactoryName, nameof(dataFactoryName), required: true);
            var __workflow_pipelineRunName = pipelineRunName == null ? null : WorkflowExpression.Compile(pipelineRunName);
            WorkflowExpression.Validate(__workflow_pipelineRunName, nameof(pipelineRunName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/cancelpipelineRun/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_pipelineRunName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IBodyWorkflowAction<PipelineRun> GetPipelineRun(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> dataFactoryName, Expression<Func<string>> pipelineRunName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_dataFactoryName = dataFactoryName == null ? null : WorkflowExpression.Compile(dataFactoryName);
            WorkflowExpression.Validate(__workflow_dataFactoryName, nameof(dataFactoryName), required: true);
            var __workflow_pipelineRunName = pipelineRunName == null ? null : WorkflowExpression.Compile(pipelineRunName);
            WorkflowExpression.Validate(__workflow_pipelineRunName, nameof(pipelineRunName), required: true);
            return new DeferredBodyAction<PipelineRun>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelineRuns/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_pipelineRunName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                return new ApiConnectionAction<PipelineRun>(callPayload);
            });
        }
    }

    public class AzuredatafactoryTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreatePipelineRunResponse
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }
    }

    public class PipelineRun
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }

        [JsonProperty("pipelineName")]
        public string PipelineName { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }

        [JsonProperty("invokedBy")]
        public PipelineRunInvokedByType InvokedBy { get; set; }

        [JsonProperty("runStart")]
        public string RunStart { get; set; }

        [JsonProperty("runEnd")]
        public string RunEnd { get; set; }

        [JsonProperty("durationInMs")]
        public int Duration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("annotations")]
        public string[] Annotations { get; set; }
    }

    public class PipelineRunInvokedByType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatafactory;

    public partial class WorkflowManagedActions
    {
        public AzuredatafactoryActions Azuredatafactory(string connectionId) => new AzuredatafactoryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredatafactoryTriggers Azuredatafactory(string connectionId) => new AzuredatafactoryTriggers(connectionId);
    }
}
