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
    /// The primary entry point for defining and registering Azure Logic Apps workflows using code.
    /// <see cref="WorkflowFactory"/> provides static methods to create stateful, stateless, and
    /// conversational agent workflows from trigger-rooted operation graphs built with the fluent
    /// chaining API.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <b>Workflow lifecycle:</b>
    /// <list type="number">
    ///   <item><description>Create triggers and actions using <see cref="WorkflowTriggers"/> and <see cref="WorkflowActions"/>.</description></item>
    ///   <item><description>Chain them together using <c>.Then()</c> to build the workflow graph.</description></item>
    ///   <item><description>Register the workflow using one of the <c>Create*Workflow</c> methods on this class.</description></item>
    ///   <item><description>Call <see cref="ConfigureServices"/> in your host setup to register required services.</description></item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <example>
    /// Create and register a complete stateful HTTP workflow:
    /// <code>
    /// // 1. Create a trigger
    /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("MyTrigger");
    ///
    /// // 2. Create actions
    /// var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Hello: {trigger.TriggerOutput.Body}").WithName("FormatInput");
    /// var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{compose.Output}").WithName("SendResponse");
    ///
    /// // 3. Chain them together
    /// trigger.Then(compose).Then(response);
    ///
    /// // 4. Register the workflow
    /// WorkflowFactory.CreateStatefulWorkflow("MyHttpWorkflow", trigger);
    /// </code>
    /// </example>
    /// <seealso cref="WorkflowTriggers"/>
    /// <seealso cref="WorkflowActions"/>
    /// <seealso cref="IChainableNode"/>
    public static class WorkflowFactory
    {
        /// <summary>
        /// Creates and registers a new stateful workflow with the specified name and trigger.
        /// Stateful workflows persist their run state and history, making them suitable for
        /// long-running, durable workflows that require reliability and replay capabilities.
        /// </summary>
        /// <param name="flowName">
        /// The unique name for this workflow. Used as the key in workflow registration and deployment.
        /// Must not be <see langword="null"/> or empty.
        /// </param>
        /// <param name="trigger">
        /// The root trigger node of the workflow graph. Chain actions onto this trigger using
        /// <c>.Then()</c> before or after calling this method.
        /// </param>
        /// <returns>The <see cref="FlowDefinition"/> representing the stateful workflow.</returns>
        /// <exception cref="ArgumentException"><paramref name="flowName"/> is <see langword="null"/> or empty.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="trigger"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="trigger"/> is a <see cref="ConversationalFlowTrigger"/>.</exception>
        /// <example>
        /// <code>
        /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        /// var action = WorkflowActions.BuiltIn.Compose(inputs: () => "Hello").WithName("Greet");
        /// trigger.Then(action);
        ///
        /// var flowDefinition = WorkflowFactory.CreateStatefulWorkflow("MyStatefulWorkflow", trigger);
        /// </code>
        /// </example>
        public static FlowDefinition CreateStatefulWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            if (string.IsNullOrEmpty(flowName))
            {
                throw new ArgumentException("Workflow name must be provided.", nameof(flowName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            if (trigger is ConversationalFlowTrigger)
            {
                throw new InvalidOperationException("A conversational agent trigger cannot be used in a stateful workflow. Use CreateAgentWorkflow instead.");
            }

            var definition = trigger.GetFlowDefinition(flowName: flowName, flowKind: FlowKind.Stateful);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Creates and registers a new stateful workflow from an <see cref="OperationChain"/>.
        /// The chain's start node must be an <see cref="IWorkflowTrigger"/>.
        /// </summary>
        /// <param name="flowName">
        /// The unique name for this workflow. Must not be <see langword="null"/> or empty.
        /// </param>
        /// <param name="chain">
        /// The workflow chain built using the fluent chaining API. Its <see cref="OperationChain.Start"/>
        /// must be an <see cref="IWorkflowTrigger"/>.
        /// </param>
        /// <returns>The <see cref="FlowDefinition"/> representing the stateful workflow.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">The chain does not start with a trigger.</exception>
        /// <example>
        /// Build the workflow inline and register it using the chain overload:
        /// <code>
        /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        /// var chain = trigger
        ///     .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Step 1").WithName("Step1"))
        ///     .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Step 2").WithName("Step2"));
        ///
        /// var flowDefinition = WorkflowFactory.CreateStatefulWorkflow("ChainedWorkflow", chain);
        /// </code>
        /// </example>
        public static FlowDefinition CreateStatefulWorkflow(string flowName, OperationChain chain)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }
            var trigger = chain.GetRootOperation() as IWorkflowTrigger
                ?? throw new InvalidOperationException("The operation chain must start with a trigger to create a workflow. Ensure the first operation in the chain is a trigger, not an action.");

            return WorkflowFactory.CreateStatefulWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Creates and registers a new stateless workflow with the specified name and trigger.
        /// Stateless workflows do not persist run state or history, making them suitable for
        /// lightweight, high-throughput scenarios where durability is not required.
        /// </summary>
        /// <param name="flowName">
        /// The unique name for this workflow. Must not be <see langword="null"/> or empty.
        /// </param>
        /// <param name="trigger">
        /// The root trigger node of the workflow graph.
        /// </param>
        /// <returns>The <see cref="FlowDefinition"/> representing the stateless workflow.</returns>
        /// <exception cref="ArgumentException"><paramref name="flowName"/> is <see langword="null"/> or empty.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="trigger"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="trigger"/> is a <see cref="ConversationalFlowTrigger"/>.</exception>
        public static FlowDefinition CreateStatelessWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            if (string.IsNullOrEmpty(flowName))
            {
                throw new ArgumentException("Workflow name must be provided.", nameof(flowName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            if (trigger is ConversationalFlowTrigger)
            {
                throw new InvalidOperationException("A conversational agent trigger cannot be used in a stateless workflow. Use CreateAgentWorkflow instead.");
            }

            var definition = trigger.GetFlowDefinition(flowName: flowName, flowKind: FlowKind.Stateless);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Creates and registers a new stateless workflow from an <see cref="OperationChain"/>.
        /// The chain's start node must be an <see cref="IWorkflowTrigger"/>.
        /// </summary>
        /// <param name="flowName">
        /// The unique name for this workflow. Must not be <see langword="null"/> or empty.
        /// </param>
        /// <param name="chain">
        /// The workflow chain built using the fluent chaining API. Its <see cref="OperationChain.Start"/>
        /// must be an <see cref="IWorkflowTrigger"/>.
        /// </param>
        /// <returns>The <see cref="FlowDefinition"/> representing the stateless workflow.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">The chain does not start with a trigger.</exception>
        public static FlowDefinition CreateStatelessWorkflow(string flowName, OperationChain chain)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }
            var trigger = chain.GetRootOperation() as IWorkflowTrigger
                ?? throw new InvalidOperationException("The operation chain must start with a trigger to create a workflow. Ensure the first operation in the chain is a trigger, not an action.");

            return WorkflowFactory.CreateStatelessWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Creates and registers a new conversational agent workflow with the specified name and trigger.
        /// Agent workflows are designed for AI-powered chat experiences that process user messages
        /// through a series of actions.
        /// </summary>
        /// <param name="flowName">
        /// The unique name for this conversational workflow. Must not be <see langword="null"/> or empty.
        /// </param>
        /// <param name="trigger">
        /// A <see cref="ConversationalFlowTrigger"/> that initiates the agent workflow when a new
        /// chat session starts.
        /// </param>
        /// <returns>The <see cref="FlowDefinition"/> representing the agent workflow.</returns>
        /// <exception cref="ArgumentException"><paramref name="flowName"/> is <see langword="null"/> or empty.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="trigger"/> is <see langword="null"/>.</exception>
        public static FlowDefinition CreateAgentWorkflow(string flowName, ConversationalFlowTrigger trigger)
        {
            if (string.IsNullOrEmpty(flowName))
            {
                throw new ArgumentException("Workflow name must be provided.", nameof(flowName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            var definition = trigger.GetFlowDefinition(flowName: flowName, flowKind: FlowKind.Agent);
            definition.Name = flowName;
            return definition;
        }

        /// <summary>
        /// Creates and registers a new conversational agent workflow from an <see cref="OperationChain"/>.
        /// The chain's start node must be a <see cref="ConversationalFlowTrigger"/>.
        /// </summary>
        /// <param name="flowName">
        /// The unique name for this conversational workflow. Must not be <see langword="null"/> or empty.
        /// </param>
        /// <param name="chain">
        /// The workflow chain built using the fluent chaining API. Its start must be a
        /// <see cref="ConversationalFlowTrigger"/>.
        /// </param>
        /// <returns>The <see cref="FlowDefinition"/> representing the agent workflow.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">The chain does not start with a trigger.</exception>
        public static FlowDefinition CreateAgentWorkflow(string flowName, OperationChain chain)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }
            var trigger = chain.GetRootOperation() as ConversationalFlowTrigger
                ?? throw new InvalidOperationException("An agent workflow must start with a conversational agent trigger. For workflows that use other trigger types, use CreateStatefulWorkflow or CreateStatelessWorkflow.");
            
            return WorkflowFactory.CreateAgentWorkflow(flowName, trigger);
        }

        /// <summary>
        /// Configures the required services for the Logic Apps SDK runtime in the dependency injection container.
        /// Call this method during host startup to register gRPC communication clients, logging services,
        /// and workflow initialization infrastructure.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register services with.</param>
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
