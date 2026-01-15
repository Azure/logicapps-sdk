//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Azuredatafactory
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatafactoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IBodyWorkflowAction<CreatePipelineRunResponse> CreatePipelineRun(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> dataFactoryName, Expression<Func<string>> pipelineName, Expression<Func<string>> referencePipelineRunId = null)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelines/{3}/CreateRun", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(pipelineName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IWorkflowAction CancelPipelineRun(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> dataFactoryName, Expression<Func<string>> pipelineRunName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/cancelpipelineRun/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(pipelineRunName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IBodyWorkflowAction<PipelineRun> GetPipelineRun(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> dataFactoryName, Expression<Func<string>> pipelineRunName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelineRuns/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(dataFactoryName, 1), ExpressionConverter.ConvertWithUrlEncoding(pipelineRunName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
            return new ApiConnectionAction<PipelineRun>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Azuredatafactory;

    public partial class WorkflowManagedActions
    {
        public AzuredatafactoryActions Azuredatafactory(string connectionId) => new AzuredatafactoryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredatafactoryTriggers Azuredatafactory(string connectionId) => new AzuredatafactoryTriggers(connectionId);
    }
}