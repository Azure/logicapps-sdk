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
    /// Factory for creating WorkflowBuilder instances.
    /// </summary>
    public static class WorkflowBuilderFactory
    {
        /// <summary>
        /// The flow templates dictionary that holds all flow templates.
        /// </summary>
        private static readonly Dictionary<string, IWorkflowBuilder> WorkflowBuilders = new Dictionary<string, IWorkflowBuilder>();

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
        public static IWorkflowBuilder CreateConversationalAgent(string flowName)
        {
            var conversationalFlow = new ConversationalFlowTrigger();
            conversationalFlow.Name = WorkflowBuilderFactory.ConversationalFlowTriggerName;

            var workflowBuilder = new WorkflowBuilder(flowName, conversationalFlow);

            WorkflowBuilderFactory.WorkflowBuilders[flowName] = workflowBuilder;

            return workflowBuilder;
        }

        /// <summary>
        /// Creates a new stateful workflow for the specified flow name with a typed trigger output.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <typeparam name="T">The type of the trigger output.</typeparam>
        public static WorkflowBuilder<T> CreateStatefulWorkflow<T>(string flowName, IOutputWorkflowTrigger<T> trigger)
        {
            var workflowBuilder = new WorkflowBuilder<T>(flowName, trigger, FlowKind.Stateful);

            WorkflowBuilderFactory.WorkflowBuilders[flowName] = workflowBuilder;

            return workflowBuilder;
        }

        /// <summary>
        /// Creates a new stateful workflow for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        public static WorkflowBuilder CreateStatefulWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            var workflowBuilder = new WorkflowBuilder(flowName, trigger, FlowKind.Stateful);

            WorkflowBuilderFactory.WorkflowBuilders[flowName] = workflowBuilder;

            return workflowBuilder;
        }

        /// <summary>
        /// Creates a new stateless workflow for the specified flow name with a typed trigger output.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <typeparam name="T">The type of the trigger output.</typeparam>
        public static WorkflowBuilder<T> CreateStatelessWorkflow<T>(string flowName, IOutputWorkflowTrigger<T> trigger)
        {
            var workflowBuilder = new WorkflowBuilder<T>(flowName, trigger, FlowKind.Stateless);

            WorkflowBuilderFactory.WorkflowBuilders[flowName] = workflowBuilder;

            return workflowBuilder;
        }

        /// <summary>
        /// Creates a new stateless workflow for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        public static WorkflowBuilder CreateStatelessWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            var workflowBuilder = new WorkflowBuilder(flowName, trigger, FlowKind.Stateless);

            WorkflowBuilderFactory.WorkflowBuilders[flowName] = workflowBuilder;

            return workflowBuilder;
        }

        /// <summary>
        /// Configures services for dependency injection.
        /// </summary>
        /// <param name="services">The service collection to configure.</param>
        public static void ConfigureServices(IServiceCollection services)
        {
            var grpcEndpoint = WorkflowBuilderFactory.GetGrpcUrl();

            var jobSessionServiceClient = new IJobSessionService.IJobSessionServiceClient(GrpcChannel.ForAddress(grpcEndpoint, channelOptions: new GrpcChannelOptions() { MaxReceiveMessageSize = int.MaxValue }));
            WorkflowBuilderFactory.jobSessionServiceClient = jobSessionServiceClient;

            services.AddSingleton<IJobSessionService.IJobSessionServiceClient>(serviceProvider =>
            {
                return jobSessionServiceClient;
            });

            services.AddSingleton<WorkflowLoggerService>(serviceProvider =>
            {
                var workflowService = new WorkflowLoggerService(serviceProvider.GetRequiredService<ILoggerFactory>());
                WorkflowBuilderFactory.WorkflowLoggerService = workflowService;

                return workflowService;
            });

            services.AddSingleton<IFunctionMetadataProvider, DummyFunctionProvider>();
            services.AddHostedService<WorkflowInitializationService>();
        }

        /// <summary>
        /// Creates workflows from the workflow builders and sends them to the extension service.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public static void CreateWorkflows(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var workflowArtifacts = WorkflowBuilderFactory.GetCodefulWorkflowArtifacts();
            WorkflowBuilderFactory.WorkflowLoggerService?.LogDebug($"Creating workflows from worker '{workflowArtifacts.ToJson()}'");

            if (workflowArtifacts.Flows?.Count != 0)
            {
                var response = WorkflowBuilderFactory.jobSessionServiceClient.CreateWorkflows(new WorkflowsRequest { Workflows = workflowArtifacts.ToJson() });

                WorkflowBuilderFactory.WorkflowLoggerService?.LogDebug($"Response got from calling the extension service '{response}'");
            }
        }

        /// <summary>
        /// Gets all codeful workflow artifacts from the registered workflow builders.
        /// </summary>
        public static CodefulWorkflowsArtifacts GetCodefulWorkflowArtifacts()
        {
            WorkflowBuilderFactory.WorkflowLoggerService?.LogDebug($"Retrieving codeful workflow artifacts '{WorkflowBuilderFactory.WorkflowBuilders?.Count}'");

            var codefulArtifacts = new CodefulWorkflowsArtifacts
            {
                Flows = WorkflowBuilderFactory.WorkflowBuilders.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.GetFlowDefinition()),
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
