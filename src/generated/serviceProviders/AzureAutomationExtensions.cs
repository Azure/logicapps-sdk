//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureAutomation
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureAutomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<CreateJobOutput> CreateJob(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> runbookName, Expression<Func<bool>> waitForJob = null, Expression<Func<object>> hybridAutomationWorkerGroup = null, Expression<Func<object>> runbookParameters = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            if (waitForJob != null)
            {
                serviceProviderParameters["waitForJob"] = ExpressionConverter.ConvertO(waitForJob);
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azureAutomation", "createJob", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateJobOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<GetJobStatusOutput> GetJobStatus(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            serviceProviderParameters["jobId"] = ExpressionConverter.ConvertO(jobId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azureAutomation", "getJobStatus", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetJobStatusOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<string> GetJobOutput(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(subscriptionId);
            serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(resourceGroup);
            serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(automationAccount);
            serviceProviderParameters["jobId"] = ExpressionConverter.ConvertO(jobId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azureAutomation", "getJobOutput", connectionId),
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