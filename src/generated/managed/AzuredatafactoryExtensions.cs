//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatafactory
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatafactoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IBodyWorkflowAction<CreatePipelineRunResponse> CreatePipelineRun([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> dataFactoryName, [WorkflowExpression] Func<string> pipelineName, [WorkflowExpression] Func<string> referencePipelineRunId = null)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(dataFactoryName, nameof(dataFactoryName), required: true);
            SourceExpression.Validate(pipelineName, nameof(pipelineName), required: true);
            SourceExpression.Validate(referencePipelineRunId, nameof(referencePipelineRunId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelines/{3}/CreateRun", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataFactoryName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pipelineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (referencePipelineRunId != null)
                    callPayload.Queries["referencePipelineRunId"] = SourceExpressionConverter.ConvertO(referencePipelineRunId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                var parameters = new JObject();
                var parameterspropCount = 0;
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatePipelineRunResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IWorkflowAction CancelPipelineRun([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> dataFactoryName, [WorkflowExpression] Func<string> pipelineRunName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(dataFactoryName, nameof(dataFactoryName), required: true);
            SourceExpression.Validate(pipelineRunName, nameof(pipelineRunName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/cancelpipelineRun/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataFactoryName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pipelineRunName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatafactory")]
        public IBodyWorkflowAction<PipelineRun> GetPipelineRun([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> dataFactoryName, [WorkflowExpression] Func<string> pipelineRunName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(dataFactoryName, nameof(dataFactoryName), required: true);
            SourceExpression.Validate(pipelineRunName, nameof(pipelineRunName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.DataFactory/factories/{2}/pipelineRuns/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataFactoryName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pipelineRunName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-01-preview");
                return callPayload;
            }

            return new ApiConnectionAction<PipelineRun>(BuildSourceInput);
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