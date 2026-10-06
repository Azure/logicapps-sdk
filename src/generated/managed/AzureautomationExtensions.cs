//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureautomation
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureautomationActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        [WorkflowExpressionFactory(nameof(__BuildGetJobOutput))]
        public IBodyWorkflowAction<string> GetJobOutput([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> automationAccount, [WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetJobOutput(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> automationAccount, WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(automationAccount, nameof(automationAccount), required: true);
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}/output", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(automationAccount, 1), ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatusOfJob))]
        public IBodyWorkflowAction<CreateJobResponse> GetStatusOfJob([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> automationAccount, [WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateJobResponse> __BuildGetStatusOfJob(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> automationAccount, WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(automationAccount, nameof(automationAccount), required: true);
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(automationAccount, 1), ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        [WorkflowExpressionFactory(nameof(__BuildCreateJob))]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> automationAccount, [WorkflowExpression] Func<string> runbookName = null, [WorkflowExpression] Func<object> bodypropertiesrunbookParameters = null, [WorkflowExpression] Func<string> bodypropertieshybridAutomationWorkerGroup = null, [WorkflowExpression] Func<bool> wait = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateJobResponse> __BuildCreateJob(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> automationAccount, WorkflowExpression<string> runbookName = null, WorkflowExpression<object> bodypropertiesrunbookParameters = null, WorkflowExpression<string> bodypropertieshybridAutomationWorkerGroup = null, WorkflowExpression<bool> wait = null)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(automationAccount, nameof(automationAccount), required: true);
            WorkflowExpression.Validate(runbookName, nameof(runbookName), required: false);
            WorkflowExpression.Validate(bodypropertiesrunbookParameters, nameof(bodypropertiesrunbookParameters), required: false);
            WorkflowExpression.Validate(bodypropertieshybridAutomationWorkerGroup, nameof(bodypropertieshybridAutomationWorkerGroup), required: false);
            WorkflowExpression.Validate(wait, nameof(wait), required: false);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(automationAccount, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                if (runbookName != null)
                    callPayload.Queries["runbookName"] = ExpressionConverter.Convert(runbookName);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(wait);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesrunbookParameters != null)
                {
                    propertiesObject["parameters"] = ExpressionConverter.ConvertO(bodypropertiesrunbookParameters);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshybridAutomationWorkerGroup != null)
                {
                    propertiesObject["runOn"] = ExpressionConverter.ConvertO(bodypropertieshybridAutomationWorkerGroup);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }
    }

    public class AzureautomationTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateJobResponse
    {
        [JsonProperty("id")]
        public string ResourceID { get; set; }

        [JsonProperty("properties")]
        public CreateJobResponsePropertiesType Properties { get; set; }
    }

    public class CreateJobResponsePropertiesType
    {
        [JsonProperty("jobId")]
        public string JobID { get; set; }

        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDetails")]
        public string StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureautomation;

    public partial class WorkflowManagedActions
    {
        public AzureautomationActions Azureautomation(string connectionId) => new AzureautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureautomationTriggers Azureautomation(string connectionId) => new AzureautomationTriggers(connectionId);
    }
}