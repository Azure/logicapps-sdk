// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Agents.Services
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Azure.Workflows.Sdk.Grpc;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Service that initializes workflows on application startup by collecting
    /// definitions from all registered <see cref="IWorkflowProvider"/> implementations.
    /// </summary>
    public class WorkflowInitializationService : IHostedService
    {
        private readonly IEnumerable<IWorkflowProvider> workflowProviders;
        private readonly IJobSessionService.IJobSessionServiceClient jobSessionServiceClient;
        private readonly WorkflowLoggerService loggerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInitializationService"/> class.
        /// </summary>
        /// <param name="workflowProviders">The registered workflow providers.</param>
        /// <param name="jobSessionServiceClient">The gRPC job session service client.</param>
        /// <param name="loggerService">The workflow logger service.</param>
        public WorkflowInitializationService(
            IEnumerable<IWorkflowProvider> workflowProviders,
            IJobSessionService.IJobSessionServiceClient jobSessionServiceClient,
            WorkflowLoggerService loggerService)
        {
            this.workflowProviders = workflowProviders;
            this.jobSessionServiceClient = jobSessionServiceClient;
            this.loggerService = loggerService;
        }

        /// <summary>
        /// Collects workflow definitions from all providers and sends them to the extension service.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var workflowArtifacts = this.GetCodefulWorkflowArtifacts();
            this.loggerService?.LogDebug($"Creating workflows from worker '{workflowArtifacts.ToJson()}'");

            if (workflowArtifacts?.Flows != null && workflowArtifacts.Flows.Count != 0)
            {
                var response = this.jobSessionServiceClient.CreateWorkflows(new WorkflowsRequest { Workflows = workflowArtifacts.ToJson() });
                this.loggerService?.LogDebug($"Response got from calling the extension service '{response}'");
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Executes cleanup operations when the service stops.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        /// <summary>
        /// Collects all workflow definitions from registered providers and builds the artifacts.
        /// </summary>
        private CodefulWorkflowsArtifacts GetCodefulWorkflowArtifacts()
        {
            var flows = new Dictionary<string, FlowDefinition>();

            foreach (var provider in this.workflowProviders)
            {
                var workflows = provider.GetWorkflows();

                if (workflows == null)
                {
                    continue;
                }

                foreach (var workflow in workflows)
                {
                    if (string.IsNullOrEmpty(workflow.Name))
                    {
                        throw new InvalidOperationException(
                            $"Workflow provider '{provider.GetType().FullName}' returned a workflow with a null or empty Name.");
                    }

                    if (flows.ContainsKey(workflow.Name))
                    {
                        throw new InvalidOperationException(
                            $"Duplicate workflow name '{workflow.Name}' detected. " +
                            $"Provider '{provider.GetType().FullName}' registered a workflow with a name that is already in use.");
                    }

                    flows[workflow.Name] = workflow;
                }
            }

            this.loggerService?.LogDebug($"Retrieving codeful workflow artifacts '{flows.Count}'");

            return new CodefulWorkflowsArtifacts
            {
                Flows = flows,
            };
        }
    }
}
