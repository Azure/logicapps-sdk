//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureAutomation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureAutomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<CreateJobOutput> CreateJob(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> runbookName, Expression<Func<bool>> waitForJob = null, Expression<Func<object>> hybridAutomationWorkerGroup = null, Expression<Func<object>> runbookParameters = null)
        {
            var parameters = new JObject();
            parameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            parameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            parameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            if (waitForJob != null)
            {
                parameters["waitForJob"] = ExpressionConverter.ConvertO(waitForJob);
            }

            if (hybridAutomationWorkerGroup != null)
            {
                parameters["hybridAutomationWorkerGroup"] = ExpressionConverter.ConvertO(hybridAutomationWorkerGroup);
            }

            parameters["runbookName"] = ExpressionConverter.ConvertO(runbookName);
            if (runbookParameters != null)
            {
                parameters["runbookParameters"] = ExpressionConverter.ConvertO(runbookParameters);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "createJob", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateJobOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<GetJobStatusOutput> GetJobStatus(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var parameters = new JObject();
            parameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            parameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            parameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            parameters["jobId"] = ExpressionConverter.ConvertO(jobId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "getJobStatus", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetJobStatusOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<string> GetJobOutput(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var parameters = new JObject();
            parameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            parameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            parameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            parameters["jobId"] = ExpressionConverter.ConvertO(jobId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "getJobOutput", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<string>(input);
        }
    }

    public class AzureAutomationTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateJobOutput
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("statusDetails")]
        public string StatusDetails { get; set; }
    }

    public class GetJobStatusOutput
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("statusDetails")]
        public string StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureAutomation;

    public partial class WorkflowServiceProviderActions
    {
        public AzureAutomationActions AzureAutomation(string connectionId) => new AzureAutomationActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureAutomationTriggers AzureAutomation(string connectionId) => new AzureAutomationTriggers(connectionId);
    }
}