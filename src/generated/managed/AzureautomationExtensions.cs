//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureautomation
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetJobOutput(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> automationAccount, Expression<Func<string>> jobId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}/output", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_automationAccount.WithUrlEncoding(1), __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<CreateJobResponse, ApiConnectionActionConfiguration> GetStatusOfJob(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> automationAccount, Expression<Func<string>> jobId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<CreateJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_automationAccount.WithUrlEncoding(1), __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<CreateJobResponse, ApiConnectionActionConfiguration> CreateJob(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> automationAccount, Expression<Func<CreateJobInput>> body, Expression<Func<string>> runbookName = null, Expression<Func<bool>> wait = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_runbookName = WorkflowExpression.Compile(runbookName, nameof(runbookName), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            return new DeferredBodyAction<CreateJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_automationAccount.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                if (__workflow_runbookName != null)
                    callPayload.Queries["runbookName"] = ExpressionConverter.Convert(__workflow_runbookName);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public string ResourceId { get; set; }

        [JsonProperty("properties")]
        public CreateJobResponsePropertiesType Properties { get; set; }
    }

    public class CreateJobResponsePropertiesType
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

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

    public class CreateJobInput
    {
        [JsonProperty("properties")]
        public CreateJobInputPropertiesType Properties { get; set; }
    }

    public class CreateJobInputPropertiesType
    {
        [JsonProperty("parameters")]
        public JToken RunbookParameters { get; set; }

        [JsonProperty("runOn")]
        public string HybridAutomationWorkerGroup { get; set; }
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