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
    /// Configures core workflow services for dependency injection and provides
    /// factory methods for creating workflow definitions.
    /// Workflow registration is handled via <see cref="IWorkflowProvider"/> implementations.
    /// </summary>
    public static class WorkflowFactory
    {
        /// <summary>
        /// The environment variable name for the functions application directory.
        /// </summary>
        public static readonly string FUNCTIONS_APPLICATION_DIRECTORY = "FUNCTIONS_APPLICATION_DIRECTORY";

        /// <summary>
        /// Creates a stateful workflow definition for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the stateful workflow.</returns>
        public static FlowPropertiesDefinition CreateStatefulWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            if (trigger is ConversationalFlowTrigger)
            {
                throw new InvalidOperationException("ConversationalFlowTrigger cannot be used in a stateful workflow.");
            }

            var definition = trigger.GetFlowDefinition(FlowKind.Stateful);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Creates a stateful workflow definition from a workflow chain.
        /// The chain's start node must be a trigger.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="chain">The workflow chain. Its start must be an <see cref="IWorkflowTrigger"/>.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the stateful workflow.</returns>
        public static FlowPropertiesDefinition CreateStatefulWorkflow(string flowName, WorkflowChain chain)
        {
            var trigger = chain.Start as IWorkflowTrigger
                ?? throw new InvalidOperationException("WorkflowChain must start with a trigger to create a workflow.");

            return CreateStatefulWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Creates a stateless workflow definition for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the stateless workflow.</returns>
        public static FlowPropertiesDefinition CreateStatelessWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            if (trigger is ConversationalFlowTrigger)
            {
                throw new InvalidOperationException("ConversationalFlowTrigger cannot be used in a stateless workflow.");
            }

            var definition = trigger.GetFlowDefinition(FlowKind.Stateless);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Creates a stateless workflow definition from a workflow chain.
        /// The chain's start node must be a trigger.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="chain">The workflow chain. Its start must be an <see cref="IWorkflowTrigger"/>.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the stateless workflow.</returns>
        public static FlowPropertiesDefinition CreateStatelessWorkflow(string flowName, WorkflowChain chain)
        {
            var trigger = chain.Start as IWorkflowTrigger
                ?? throw new InvalidOperationException("WorkflowChain must start with a trigger to create a workflow.");

            return CreateStatelessWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Creates an agent workflow definition for the specified flow name.
        /// </summary>
        /// <param name="flowName">The conversational flow name.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the agent workflow.</returns>
        public static FlowPropertiesDefinition CreateAgentWorkflow(string flowName, ConversationalFlowTrigger trigger)
        {
            var definition = trigger.GetFlowDefinition(FlowKind.Agent);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Creates an agent workflow definition for the specified flow name.
        /// </summary>
        /// <param name="flowName">The conversational flow name.</param>
        /// <param name="chain">The workflow chain.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the agent workflow.</returns>
        public static FlowPropertiesDefinition CreateAgentWorkflow(string flowName, WorkflowChain chain)
        {
            var trigger = chain.Start as ConversationalFlowTrigger
                ?? throw new InvalidOperationException("WorkflowChain must start with a trigger to create a workflow.");
            return CreateAgentWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Creates an agent workflow definition for the specified flow name using a generic trigger.
        /// </summary>
        /// <param name="flowName">The conversational flow name.</param>
        /// <param name="trigger">The trigger for the flow.</param>
        /// <returns>A <see cref="FlowPropertiesDefinition"/> representing the agent workflow.</returns>
        public static FlowPropertiesDefinition CreateAgentWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            var definition = trigger.GetFlowDefinition(FlowKind.Agent);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Configures services for dependency injection.
        /// </summary>
        /// <param name="services">The service collection to configure.</param>
        public static void ConfigureServices(IServiceCollection services)
        {
            var grpcEndpoint = WorkflowFactory.GetGrpcUrl();

            var jobSessionServiceClient = new IJobSessionService.IJobSessionServiceClient(GrpcChannel.ForAddress(grpcEndpoint, channelOptions: new GrpcChannelOptions() { MaxReceiveMessageSize = int.MaxValue }));

            services.AddSingleton<IJobSessionService.IJobSessionServiceClient>(jobSessionServiceClient);

            services.AddSingleton<WorkflowLoggerService>(serviceProvider =>
            {
                return new WorkflowLoggerService(serviceProvider.GetRequiredService<ILoggerFactory>());
            });

            services.AddSingleton<IFunctionMetadataProvider, DummyFunctionProvider>();
            services.AddHostedService<WorkflowInitializationService>();
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
