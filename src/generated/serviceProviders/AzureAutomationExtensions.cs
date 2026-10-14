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
    using System.Linq.Expressions;

    public class AzureAutomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<CreateJobOutput> CreateJob(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> runbookName, Expression<Func<bool>> waitForJob = null, Expression<Func<object>> hybridAutomationWorkerGroup = null, Expression<Func<object>> runbookParameters = null)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroup = resourceGroup == null ? null : WorkflowExpression.Compile(resourceGroup);
            WorkflowExpression.Validate(__workflow_resourceGroup, nameof(resourceGroup), required: true);
            var __workflow_automationAccount = automationAccount == null ? null : WorkflowExpression.Compile(automationAccount);
            WorkflowExpression.Validate(__workflow_automationAccount, nameof(automationAccount), required: true);
            var __workflow_runbookName = runbookName == null ? null : WorkflowExpression.Compile(runbookName);
            WorkflowExpression.Validate(__workflow_runbookName, nameof(runbookName), required: true);
            var __workflow_waitForJob = waitForJob == null ? null : WorkflowExpression.Compile(waitForJob);
            WorkflowExpression.Validate(__workflow_waitForJob, nameof(waitForJob), required: false);
            var __workflow_hybridAutomationWorkerGroup = hybridAutomationWorkerGroup == null ? null : WorkflowExpression.Compile(hybridAutomationWorkerGroup);
            WorkflowExpression.Validate(__workflow_hybridAutomationWorkerGroup, nameof(hybridAutomationWorkerGroup), required: false);
            var __workflow_runbookParameters = runbookParameters == null ? null : WorkflowExpression.Compile(runbookParameters);
            WorkflowExpression.Validate(__workflow_runbookParameters, nameof(runbookParameters), required: false);
            return new DeferredBodyAction<CreateJobOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(__workflow_subscriptionId);
                serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(__workflow_resourceGroup);
                serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(__workflow_automationAccount);
                if (__workflow_waitForJob != null)
                {
                    serviceProviderParameters["waitForJob"] = ExpressionConverter.ConvertO(__workflow_waitForJob);
                }
                else
                {
                    serviceProviderParameters["waitForJob"] = false;
                }

                if (__workflow_hybridAutomationWorkerGroup != null)
                {
                    serviceProviderParameters["hybridAutomationWorkerGroup"] = ExpressionConverter.ConvertO(__workflow_hybridAutomationWorkerGroup);
                }

                serviceProviderParameters["runbookName"] = ExpressionConverter.ConvertO(__workflow_runbookName);
                if (__workflow_runbookParameters != null)
                {
                    serviceProviderParameters["runbookParameters"] = ExpressionConverter.ConvertO(__workflow_runbookParameters);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "createJob", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateJobOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<GetJobStatusOutput> GetJobStatus(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroup = resourceGroup == null ? null : WorkflowExpression.Compile(resourceGroup);
            WorkflowExpression.Validate(__workflow_resourceGroup, nameof(resourceGroup), required: true);
            var __workflow_automationAccount = automationAccount == null ? null : WorkflowExpression.Compile(automationAccount);
            WorkflowExpression.Validate(__workflow_automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<GetJobStatusOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(__workflow_subscriptionId);
                serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(__workflow_resourceGroup);
                serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(__workflow_automationAccount);
                serviceProviderParameters["jobId"] = ExpressionConverter.ConvertO(__workflow_jobId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "getJobStatus", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetJobStatusOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<string> GetJobOutput(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroup = resourceGroup == null ? null : WorkflowExpression.Compile(resourceGroup);
            WorkflowExpression.Validate(__workflow_resourceGroup, nameof(resourceGroup), required: true);
            var __workflow_automationAccount = automationAccount == null ? null : WorkflowExpression.Compile(automationAccount);
            WorkflowExpression.Validate(__workflow_automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["subscriptionId"] = ExpressionConverter.ConvertO(__workflow_subscriptionId);
                serviceProviderParameters["resourceGroup"] = ExpressionConverter.ConvertO(__workflow_resourceGroup);
                serviceProviderParameters["automationAccount"] = ExpressionConverter.ConvertO(__workflow_automationAccount);
                serviceProviderParameters["jobId"] = ExpressionConverter.ConvertO(__workflow_jobId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azureAutomation", operationId: "getJobOutput", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<string>(serviceProviderInput);
            });
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
