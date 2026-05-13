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
    /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("MyTrigger");
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
        /// The stored workflow trigger nodes indexed by flow name.
        /// </summary>
        private static readonly Dictionary<string, (IWorkflowTrigger Trigger, FlowKind Kind)> Workflows = new Dictionary<string, (IWorkflowTrigger, FlowKind)>();

        /// <summary>
        /// Job session service client for gRPC communication.
        /// </summary>
        private static IJobSessionService.IJobSessionServiceClient jobSessionServiceClient;

        /// <summary>
        /// The logger service.
        /// </summary>
        private static WorkflowLoggerService WorkflowLoggerService;

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
        /// Must not be a <see cref="ConversationalFlowTrigger"/>.
        /// </param>
        /// <returns>The registered <see cref="IWorkflowTrigger"/> instance.</returns>
        /// <exception cref="ArgumentException"><paramref name="flowName"/> is <see langword="null"/> or empty.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="trigger"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="trigger"/> is a <see cref="ConversationalFlowTrigger"/>.</exception>
        /// <example>
        /// <code>
        /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        /// var action = WorkflowActions.BuiltIn.Compose(inputs: () => "Hello").WithName("Greet");
        /// trigger.Then(action);
        ///
        /// WorkflowFactory.CreateStatefulWorkflow("MyStatefulWorkflow", trigger);
        /// </code>
        /// </example>
        public static IWorkflowTrigger CreateStatefulWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            if (string.IsNullOrEmpty(flowName))
            {
                throw new ArgumentException("Flow name must be provided.", nameof(flowName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            if (trigger is ConversationalFlowTrigger)
            {
                throw new InvalidOperationException("ConversationalFlowTrigger cannot be used in a stateless workflow.");
            }

            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Stateful);
            return trigger;
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
        /// <returns>The registered <see cref="IWorkflowTrigger"/> instance extracted from the chain.</returns>
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
        /// WorkflowFactory.CreateStatefulWorkflow("ChainedWorkflow", chain);
        /// </code>
        /// </example>
        public static IWorkflowTrigger CreateStatefulWorkflow(string flowName, OperationChain chain)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }
            var trigger = chain.GetRootTrigger();

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
        /// Must not be a <see cref="ConversationalFlowTrigger"/>.
        /// </param>
        /// <returns>The registered <see cref="IWorkflowTrigger"/> instance.</returns>
        /// <exception cref="ArgumentException"><paramref name="flowName"/> is <see langword="null"/> or empty.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="trigger"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="trigger"/> is a <see cref="ConversationalFlowTrigger"/>.</exception>
        public static IWorkflowTrigger CreateStatelessWorkflow(string flowName, IWorkflowTrigger trigger)
        {
            if (string.IsNullOrEmpty(flowName))
            {
                throw new ArgumentException("Flow name must be provided.", nameof(flowName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            if (trigger is ConversationalFlowTrigger)
            {
                throw new InvalidOperationException("ConversationalFlowTrigger cannot be used in a stateless workflow.");
            }

            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Stateless);
            return trigger;
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
        /// <returns>The registered <see cref="IWorkflowTrigger"/> instance extracted from the chain.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">The chain does not start with a trigger.</exception>
        public static IWorkflowTrigger CreateStatelessWorkflow(string flowName, OperationChain chain)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }
            var trigger = chain.GetRootTrigger();

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
        /// <returns>The registered <see cref="IWorkflowTrigger"/> instance.</returns>
        /// <exception cref="ArgumentException"><paramref name="flowName"/> is <see langword="null"/> or empty.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="trigger"/> is <see langword="null"/>.</exception>
        public static IWorkflowTrigger CreateAgentWorkflow(string flowName, ConversationalFlowTrigger trigger)
        {
            if (string.IsNullOrEmpty(flowName))
            {
                throw new ArgumentException("Flow name must be provided.", nameof(flowName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            WorkflowFactory.Workflows[flowName] = (trigger, FlowKind.Agent);
            return trigger;
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
        /// <returns>The registered <see cref="IWorkflowTrigger"/> instance extracted from the chain.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">The chain does not start with a trigger.</exception>
        public static IWorkflowTrigger CreateAgentWorkflow(string flowName, OperationChain chain)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }
            var trigger = chain.GetRootTrigger() as ConversationalFlowTrigger;
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
        /// Serializes all registered workflow graphs into workflow definition artifacts and deploys them
        /// to the Logic Apps extension service via gRPC. This method is called by the hosting infrastructure
        /// during workflow initialization and is not typically invoked by application code directly.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        internal static void CreateWorkflows(CancellationToken cancellationToken)
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
        /// Traverses all registered workflow graphs and produces the serializable
        /// <see cref="CodefulWorkflowsArtifacts"/> representation. This method is used by the hosting
        /// infrastructure and is not typically invoked by application code directly.
        /// </summary>
        /// <returns>
        /// A <see cref="CodefulWorkflowsArtifacts"/> containing the <see cref="FlowDefinition"/> for
        /// each registered workflow, keyed by workflow name.
        /// </returns>
        public static CodefulWorkflowsArtifacts GetCodefulWorkflowArtifacts()
        {
            WorkflowFactory.WorkflowLoggerService?.LogDebug($"Retrieving codeful workflow artifacts '{WorkflowFactory.Workflows?.Count}'");

            var codefulArtifacts = new CodefulWorkflowsArtifacts
            {
                Flows = WorkflowFactory.Workflows.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Trigger.GetFlowDefinition(flowName: kvp.Key, flowKind: kvp.Value.Kind)),
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
