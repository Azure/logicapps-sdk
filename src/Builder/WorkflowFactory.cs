// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using global::Grpc.Net.Client;
    using Microsoft.Azure.Functions.Worker.Core.FunctionMetadata;
    using Microsoft.Azure.Workflows.Sdk.Agents.Services;
    using Microsoft.Azure.Workflows.Sdk.Grpc;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Factory for creating workflows from trigger node graphs.
    /// </summary>
    public static class WorkflowFactory
    {
        /// <summary>
        /// The stored workflow trigger nodes indexed by flow name.
        /// </summary>
        private static readonly Dictionary<string, (IWorkflowTrigger Trigger, FlowKind Kind)> Workflows = new Dictionary<string, (IWorkflowTrigger, FlowKind)>();

        /// <summary>
        /// The name of the conversational flow trigger.
        /// </summary>
        private static string ConversationalFlowTriggerName = "When_a_new_chat_session_starts";

        /// <summary>
        /// The environment variable name for the functions application directory.
        /// </summary>
        public static readonly string FUNCTIONS_APPLICATION_DIRECTORY = "FUNCTIONS_APPLICATION_DIRECTORY";

        /// <summary>
        /// Job session service client for gRPC communication.
        /// </summary>
        private static IJobSessionService.IJobSessionServiceClient jobSessionServiceClient;

        /// <summary>
        /// The logger service.
        /// </summary>
        private static WorkflowLoggerService WorkflowLoggerService;

        /// <summary>
        /// Creates a new conversational agent workflow with the specified flow name.
        /// </summary>
        /// <param name="flowName">The conversational flow name.</param>
        public static IWorkflowTrigger CreateConversationalAgent(string flowName)
        {
            var conversationalFlow = new ConversationalFlowTrigger();
            conversationalFlow.Name = WorkflowFactory.ConversationalFlowTriggerName;

            WorkflowFactory.Workflows[flowName] = (conversationalFlow, FlowKind.Agent);

            return conversationalFlow;
        }

        /// <summary>
        /// Creates a new stateful workflow for the specified flow name with a typed trigger output.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <typeparam name="T">The type of the trigger output.</typeparam>
        public static IOutputWorkflowTrigger<T> CreateStatefulWorkflow<T>(string flowName, IOutputWorkflowTrigger<T> trigger)
        {
            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Stateful);
            return trigger;
        }

        /// <summary>
        /// Creates a new stateful workflow for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        public static IWorkflowTrigger CreateStatefulWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Stateful);
            return trigger;
        }

        /// <summary>
        /// Creates a new stateful workflow from a workflow chain.
        /// The chain's start node must be a trigger.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="chain">The workflow chain. Its start must be an <see cref="IWorkflowTrigger"/>.</param>
        public static IWorkflowTrigger CreateStatefulWorkflow(string flowName, WorkflowChain chain)
        {
            var trigger = chain.Start as IWorkflowTrigger
                ?? throw new InvalidOperationException("WorkflowChain must start with a trigger to create a workflow.");
            return CreateStatefulWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Creates a new stateless workflow for the specified flow name with a typed trigger output.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <typeparam name="T">The type of the trigger output.</typeparam>
        public static IOutputWorkflowTrigger<T> CreateStatelessWorkflow<T>(string flowName, IOutputWorkflowTrigger<T> trigger)
        {
            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Stateless);
            return trigger;
        }

        /// <summary>
        /// Creates a new stateless workflow for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        public static IWorkflowTrigger CreateStatelessWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Stateless);
            return trigger;
        }

        /// <summary>
        /// Creates a new stateless workflow from a workflow chain.
        /// The chain's start node must be a trigger.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="chain">The workflow chain. Its start must be an <see cref="IWorkflowTrigger"/>.</param>
        public static IWorkflowTrigger CreateStatelessWorkflow(string flowName, WorkflowChain chain)
        {
            var trigger = chain.Start as IWorkflowTrigger
                ?? throw new InvalidOperationException("WorkflowChain must start with a trigger to create a workflow.");
            return CreateStatelessWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Configures services for dependency injection.
        /// </summary>
        /// <param name="services">The service collection to configure.</param>
        public static void ConfigureServices(IServiceCollection services)
        {
            var grpcEndpoint = WorkflowFactory.GetGrpcUrl();

            var jobSessionServiceClient = new IJobSessionService.IJobSessionServiceClient(GrpcChannel.ForAddress(grpcEndpoint, channelOptions: new GrpcChannelOptions() { MaxReceiveMessageSize = int.MaxValue }));
            WorkflowFactory.jobSessionServiceClient = jobSessionServiceClient;

            services.AddSingleton<IJobSessionService.IJobSessionServiceClient>(serviceProvider =>
            {
                return jobSessionServiceClient;
            });

            services.AddSingleton<WorkflowLoggerService>(serviceProvider =>
            {
                var workflowService = new WorkflowLoggerService(serviceProvider.GetRequiredService<ILoggerFactory>());
                WorkflowFactory.WorkflowLoggerService = workflowService;

                return workflowService;
            });

            services.AddSingleton<IFunctionMetadataProvider, DummyFunctionProvider>();
            services.AddHostedService<WorkflowInitializationService>();
        }

        /// <summary>
        /// Creates workflows from the stored trigger node graphs and sends them to the extension service.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public static void CreateWorkflows(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var workflowArtifacts = WorkflowFactory.GetCodefulWorkflowArtifacts();
            WorkflowFactory.WorkflowLoggerService?.LogDebug($"Creating workflows from worker '{workflowArtifacts.ToJson()}'");

            if (workflowArtifacts.Flows?.Count != 0)
            {
                var response = WorkflowFactory.jobSessionServiceClient.CreateWorkflows(new WorkflowsRequest { Workflows = workflowArtifacts.ToJson() });

                WorkflowFactory.WorkflowLoggerService?.LogDebug($"Response got from calling the extension service '{response}'");
            }
        }

        /// <summary>
        /// Gets all codeful workflow artifacts from the stored workflow graphs.
        /// </summary>
        public static CodefulWorkflowsArtifacts GetCodefulWorkflowArtifacts()
        {
            WorkflowFactory.WorkflowLoggerService?.LogDebug($"Retrieving codeful workflow artifacts '{WorkflowFactory.Workflows?.Count}'");

            var codefulArtifacts = new CodefulWorkflowsArtifacts
            {
                Flows = WorkflowFactory.Workflows.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Trigger.GetFlowDefinition(kvp.Value.Kind)),
            };

            return codefulArtifacts;
        }

        #region Private Methods.

        /// <summary>
        /// Gets the gRPC URL from command line arguments.
        /// </summary>
        private static string GetGrpcUrl()
        {
            var uri = string.Empty;

            var args = Environment.GetCommandLineArgs();
            for (var i = 0; i < args?.Length; i++)
            {
                if (args[i].Equals("--functions-uri", StringComparison.OrdinalIgnoreCase) && args.Length > i + 1)
                {
                    uri = args?[i + 1];
                }
            }

            return uri;
        }

        #endregion
    }
}
