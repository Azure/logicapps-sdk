//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureautomation
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzureautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<string> GetJobOutput(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> automationAccount, Expression<Func<string>> jobId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}/output", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_automationAccount, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<CreateJobResponse> GetStatusOfJob(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> automationAccount, Expression<Func<string>> jobId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_automationAccount, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureautomation")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> automationAccount, Expression<Func<string>> runbookName = null, Expression<Func<object>> bodypropertiesrunbookParameters = null, Expression<Func<string>> bodypropertieshybridAutomationWorkerGroup = null, Expression<Func<bool>> wait = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_runbookName = WorkflowExpression.Compile(runbookName, nameof(runbookName), required: false);
            var __workflow_bodypropertiesrunbookParameters = WorkflowExpression.Compile(bodypropertiesrunbookParameters, nameof(bodypropertiesrunbookParameters), required: false);
            var __workflow_bodypropertieshybridAutomationWorkerGroup = WorkflowExpression.Compile(bodypropertieshybridAutomationWorkerGroup, nameof(bodypropertieshybridAutomationWorkerGroup), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Automation/automationAccounts/{2}/jobs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_automationAccount, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2015-10-31");
                if (__workflow_runbookName != null)
                    callPayload.Queries["runbookName"] = ExpressionConverter.Convert(__workflow_runbookName);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesrunbookParameters != null)
                {
                    propertiesObject["parameters"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrunbookParameters);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshybridAutomationWorkerGroup != null)
                {
                    propertiesObject["runOn"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshybridAutomationWorkerGroup);
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
