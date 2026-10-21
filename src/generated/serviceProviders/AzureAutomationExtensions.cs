//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureAutomation
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureAutomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<CreateJobOutput> CreateJob(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> runbookName, Expression<Func<bool>> waitForJob = null, Expression<Func<object>> hybridAutomationWorkerGroup = null, Expression<Func<object>> runbookParameters = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroup = WorkflowExpression.Compile(resourceGroup, nameof(resourceGroup), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_runbookName = WorkflowExpression.Compile(runbookName, nameof(runbookName), required: true);
            var __workflow_waitForJob = WorkflowExpression.Compile(waitForJob, nameof(waitForJob), required: false);
            var __workflow_hybridAutomationWorkerGroup = WorkflowExpression.Compile(hybridAutomationWorkerGroup, nameof(hybridAutomationWorkerGroup), required: false);
            var __workflow_runbookParameters = WorkflowExpression.Compile(runbookParameters, nameof(runbookParameters), required: false);
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
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<GetJobStatusOutput> GetJobStatus(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroup = WorkflowExpression.Compile(resourceGroup, nameof(resourceGroup), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
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
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azureAutomation")]
        public IBodyWorkflowAction<string> GetJobOutput(Expression<Func<object>> subscriptionId, Expression<Func<object>> resourceGroup, Expression<Func<object>> automationAccount, Expression<Func<object>> jobId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroup = WorkflowExpression.Compile(resourceGroup, nameof(resourceGroup), required: true);
            var __workflow_automationAccount = WorkflowExpression.Compile(automationAccount, nameof(automationAccount), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
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
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
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