// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using global::Grpc.Net.Client;
    using Microsoft.Azure.Functions.Worker.Core.FunctionMetadata;
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
        /// Create a new WorkflowBuilder for a conversational agent with the specified flow name.
        /// </summary>
        /// <param name="flowName">The conversational flow name.</param>
        public static IWorkflowBuilder CreateConversationalAgent(string flowName)
        {
            var conversationalFlow = new ConversationalFlowTrigger();
            conversationalFlow.WithName(WorkflowBuilderFactory.ConversationalFlowTriggerName);

            var workflowBuilder = new WorkflowBuilder(flowName, conversationalFlow);

            WorkflowBuilderFactory.WorkflowBuilders[flowName] = workflowBuilder;

            return workflowBuilder;
        }

        /// <summary>
        /// Creates a new stateful workflow for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
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
        /// Creates a new stateless workflow for the specified flow name.
        /// </summary>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="trigger">The trigger for the flow.</param>
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
        /// Configuring services for dependency injection.
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            var grpcEndpoint = WorkflowBuilderFactory.GetGrpcUrl();

            WorkflowBuilderFactory.jobSessionServiceClient = new IJobSessionService.IJobSessionServiceClient(GrpcChannel.ForAddress(grpcEndpoint, channelOptions: new GrpcChannelOptions() { MaxReceiveMessageSize = int.MaxValue }));

            services.AddSingleton<WorkflowLoggerService>(serviceProvider =>
            {
                var workflowService = new WorkflowLoggerService(serviceProvider.GetRequiredService<ILoggerFactory>());
                WorkflowBuilderFactory.WorkflowLoggerService = workflowService;

                return workflowService;
            });

            services.AddSingleton<IFunctionMetadataProvider, DummyFunctionProvider>();
        }

        /// <summary>
        /// Configuring services for dependency injection.
        /// </summary>
        public static void CreateWorkflows()
        {
            var workflowArtifacts = WorkflowBuilderFactory.GetCodefulWorkflowArtifacts();
            Console.WriteLine($"Creating workflows from worker '{workflowArtifacts.ToJson()}'");
            WorkflowBuilderFactory.WorkflowLoggerService?.LogDebug($"Creating workflows from worker '{workflowArtifacts.ToJson()}'");

            if (workflowArtifacts.Flows?.Count != 0)
            {
                var response = WorkflowBuilderFactory.jobSessionServiceClient.CreateWorkflows(new WorkflowsRequest { Workflows = workflowArtifacts.ToJson() });

                WorkflowBuilderFactory.WorkflowLoggerService?.LogDebug($"Response got from calling the extension service '{response}'");
            }
        }

        /// <summary>
        /// A function that returns all the workflow templates.
        /// </summary>
        public static CodefulWorkflowsArtifacts GetCodefulWorkflowArtifacts()
        {
            WorkflowBuilderFactory.WorkflowLoggerService?.LogDebug($"Retrieving codeful workflow artifacts '{WorkflowBuilderFactory.WorkflowBuilders?.Count}'");

            // Generate all flow definitions once
            var flows = WorkflowBuilderFactory.WorkflowBuilders.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.GetFlowDefinition());

            var codefulArtifacts = new CodefulWorkflowsArtifacts
            {
                Flows = flows,
                Connections = ExtractConnections(flows)
            };

            return codefulArtifacts;
        }

        /// <summary>
        /// Extracts API connections from workflow definitions.
        /// </summary>
        /// <param name="flows">Dictionary of workflow definitions</param>
        private static ConnectionsArtifacts ExtractConnections(Dictionary<string, FlowPropertiesDefinition> flows)
        {
            var connections = new ConnectionsArtifacts();
            var connectionNames = new HashSet<string>();

            // Scan all workflow definitions for API connection actions and triggers
            foreach (var flowDefinition in flows.Values)
            {

                // Scan actions
                if (flowDefinition.Definition?.Actions != null)
                {
                    foreach (var action in flowDefinition.Definition.Actions.Values)
                    {
                        if (action.Type == FlowTemplateOperationType.ApiConnection ||
                            action.Type == FlowTemplateOperationType.ApiConnectionWebhook ||
                            action.Type == FlowTemplateOperationType.ApiConnectionNotification)
                        {
                            var inputs = action.Inputs as ApiConnectionActionInput;
                            if (inputs?.Host?.Connection?.ReferenceName != null)
                            {
                                connectionNames.Add(inputs.Host.Connection.ReferenceName);
                            }
                        }
                    }
                }

                // Scan triggers
                if (flowDefinition.Definition?.Triggers != null)
                {
                    foreach (var trigger in flowDefinition.Definition.Triggers.Values)
                    {
                        if (trigger.Type == FlowTemplateOperationType.ApiConnection ||
                            trigger.Type == FlowTemplateOperationType.ApiConnectionWebhook ||
                            trigger.Type == FlowTemplateOperationType.ApiConnectionNotification)
                        {
                            var inputs = trigger.Inputs as ApiConnectionActionInput;
                            if (inputs?.Host?.Connection?.ReferenceName != null)
                            {
                                connectionNames.Add(inputs.Host.Connection.ReferenceName);
                            }
                        }
                    }
                }
            }

            // Create connection definitions for each unique connection
            foreach (var connectionName in connectionNames)
            {
                var connectorName = InferConnectorName(connectionName);
                connections.ManagedApiConnections[connectionName] = new ManagedApiConnection
                {
                    Api = new ApiInfo
                    {
                        Id = $"/subscriptions/{{subscriptionId}}/providers/Microsoft.Web/locations/{{location}}/managedApis/{connectorName}"
                    },
                    Connection = new ConnectionInfo
                    {
                        Id = $"/subscriptions/{{subscriptionId}}/resourceGroups/{{resourceGroup}}/providers/Microsoft.Web/connections/{connectionName}"
                    },
                    Authentication = new AuthenticationInfo
                    {
                        Type = "ManagedServiceIdentity"
                    }
                };
            }

            return connections;
        }

        /// <summary>
        /// Infers the connector name from a connection name.
        /// </summary>
        /// <param name="connectionName">The connection name (e.g., "msnweather-connection")</param>
        /// <returns>The inferred connector name (e.g., "msnweather")</returns>
        private static string InferConnectorName(string connectionName)
        {
            // Simple heuristic: extract connector name from connection name
            // e.g., "msnweather-connection" -> "msnweather"
            // e.g., "office365_connection" -> "office365"
            var parts = connectionName.Split(new[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            return parts[0].ToLowerInvariant();
        }

        #region Private Methods.

        /// <summary>
        /// Gets the grpc url.
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
