//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureAutomation
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureAutomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<CreateJobOutput> CreateJob([WorkflowExpression] Func<object> subscriptionId, [WorkflowExpression] Func<object> resourceGroup, [WorkflowExpression] Func<object> automationAccount, [WorkflowExpression] Func<object> runbookName, [WorkflowExpression] Func<bool> waitForJob = null, [WorkflowExpression] Func<object> hybridAutomationWorkerGroup = null, [WorkflowExpression] Func<object> runbookParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            if (waitForJob != null)
            {
                serviceProviderParameters["waitForJob"] = ExpressionConverter.ConvertO(waitForJob);
            }
            else
            {
                serviceProviderParameters["waitForJob"] = false;
            }

            if (hybridAutomationWorkerGroup != null)
            {
                serviceProviderParameters["hybridAutomationWorkerGroup"] = ExpressionConverter.ConvertO(hybridAutomationWorkerGroup);
            }

            serviceProviderParameters["runbookName"] = ExpressionConverter.ConvertO(runbookName);
            if (runbookParameters != null)
            {
                serviceProviderParameters["runbookParameters"] = ExpressionConverter.ConvertO(runbookParameters);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "createJob", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateJobOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<GetJobStatusOutput> GetJobStatus([WorkflowExpression] Func<object> subscriptionId, [WorkflowExpression] Func<object> resourceGroup, [WorkflowExpression] Func<object> automationAccount, [WorkflowExpression] Func<object> jobId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            serviceProviderParameters["jobId"] = ExpressionConverter.ConvertO(jobId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "getJobStatus", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetJobStatusOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<string> GetJobOutput([WorkflowExpression] Func<object> subscriptionId, [WorkflowExpression] Func<object> resourceGroup, [WorkflowExpression] Func<object> automationAccount, [WorkflowExpression] Func<object> jobId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            serviceProviderParameters["jobId"] = ExpressionConverter.ConvertO(jobId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "getJobOutput", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<string>(serviceProviderInput);
        }
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
}