//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatafactory
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatafactoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePipelineRun))]
        public IBodyWorkflowAction<CreatePipelineRunResponse> CreatePipelineRun([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> dataFactoryName, [WorkflowExpression] Func<string> pipelineName, [WorkflowExpression] Func<string> referencePipelineRunId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePipelineRunResponse> __BuildCreatePipelineRun(WorkflowValue<string> subscriptionId, WorkflowValue<string> resourceGroupName, WorkflowValue<string> dataFactoryName, WorkflowValue<string> pipelineName, WorkflowValue<string> referencePipelineRunId = null)
        {
            WorkflowValue.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowValue.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowValue.Validate(dataFactoryName, nameof(dataFactoryName), required: true);
            WorkflowValue.Validate(pipelineName, nameof(pipelineName), required: true);
            WorkflowValue.Validate(referencePipelineRunId, nameof(referencePipelineRunId), required: false);
            return new DeferredBodyAction<CreatePipelineRunResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelines/{3}/CreateRun", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(pipelineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (referencePipelineRunId != null)
                    callPayload.Queries["referencePipelineRunId"] = ExpressionConverter.Convert(referencePipelineRunId);
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
        [WorkflowExpressionFactory(nameof(__BuildCancelPipelineRun))]
        public IWorkflowAction CancelPipelineRun([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> dataFactoryName, [WorkflowExpression] Func<string> pipelineRunName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelPipelineRun(WorkflowValue<string> subscriptionId, WorkflowValue<string> resourceGroupName, WorkflowValue<string> dataFactoryName, WorkflowValue<string> pipelineRunName)
        {
            WorkflowValue.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowValue.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowValue.Validate(dataFactoryName, nameof(dataFactoryName), required: true);
            WorkflowValue.Validate(pipelineRunName, nameof(pipelineRunName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/cancelpipelineRun/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(pipelineRunName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        [WorkflowExpressionFactory(nameof(__BuildGetPipelineRun))]
        public IBodyWorkflowAction<PipelineRun> GetPipelineRun([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> dataFactoryName, [WorkflowExpression] Func<string> pipelineRunName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PipelineRun> __BuildGetPipelineRun(WorkflowValue<string> subscriptionId, WorkflowValue<string> resourceGroupName, WorkflowValue<string> dataFactoryName, WorkflowValue<string> pipelineRunName)
        {
            WorkflowValue.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowValue.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowValue.Validate(dataFactoryName, nameof(dataFactoryName), required: true);
            WorkflowValue.Validate(pipelineRunName, nameof(pipelineRunName), required: true);
            return new DeferredBodyAction<PipelineRun>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelineRuns/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(pipelineRunName, 1));
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
