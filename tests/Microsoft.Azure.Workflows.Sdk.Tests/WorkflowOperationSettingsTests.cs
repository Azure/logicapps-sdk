// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Linq;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Newtonsoft.Json.Linq;
    using Xunit;

    public class WorkflowOperationSettingsTests
    {
        [Fact]
        public void HttpRequestAndActionSettingsSerializeToWorkflowDefinition()
        {
            var schema = JObject.Parse(
                """{"type":"object","properties":{"id":{"type":"string"}},"required":["id"]}""");
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger(requestBodyJsonSchema: schema)
                .WithClientTrackingId(() => "client-123")
                .WithSchemaValidation()
                .WithConcurrency(runs: 2, maximumWaitingRuns: 10)
                .WithSecureInputs()
                .WithSecureOutputs()
                .WithName("Request");

            var action = WorkflowActions.BuiltIn.HttpAction(
                    uri: () => new Uri("https://example.com"),
                    method: () => System.Net.Http.HttpMethod.Get)
                .WithRetryPolicy(RetryPolicy.Fixed(3, TimeSpan.FromSeconds(30)))
                .WithSecureInputs()
                .WithSecureOutputs()
                .WithTrackedProperty("OrderId", () => "order-42")
                .WithName("Call");

            trigger.Then(action);
            var definition = WorkflowFactory.CreateStatefulWorkflow("Settings", trigger);
            var request = definition.Definition.Triggers["Request"];
            var call = definition.Definition.Actions["Call"];
            var callInputs = Assert.IsType<JObject>(call.Inputs);

            Assert.Equal("client-123", request.Correlation.ClientTrackingId);
            Assert.Equal(OperationOptions.EnableSchemaValidation, request.OperationOptions);
            Assert.Equal("EnableSchemaValidation", request.ToJToken()["operationOptions"].Value<string>());
            Assert.Equal(2, request.RuntimeConfiguration.Concurrency.Runs);
            Assert.Equal(10, request.RuntimeConfiguration.Concurrency.MaximumWaitingRuns);
            Assert.Equal(new[] { "inputs", "outputs" }, request.RuntimeConfiguration.SecureData.Properties);
            Assert.Equal("fixed", callInputs["retryPolicy"]["type"]);
            Assert.Equal(3, callInputs["retryPolicy"]["count"]);
            Assert.Equal("PT30S", callInputs["retryPolicy"]["interval"]);
            Assert.Equal("order-42", call.TrackedProperties["OrderId"]);
            Assert.Equal(new[] { "inputs", "outputs" }, call.RuntimeConfiguration.SecureData.Properties);
        }

        [Fact]
        public void DirectDefinitionCallsIncludeConfiguredSettings()
        {
            var schema = JObject.Parse("""{"type":"object"}""");
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger(requestBodyJsonSchema: schema)
                .WithSchemaValidation()
                .WithConcurrency(2);
            var action = WorkflowActions.BuiltIn.HttpAction(
                    uri: () => new Uri("https://example.com"),
                    method: () => System.Net.Http.HttpMethod.Get)
                .WithRetryPolicy(RetryPolicy.None())
                .WithTrackedProperty("Source", () => "direct");

            var triggerDefinition = trigger.GetTriggerDefinition(FlowKind.Stateful);
            var actionDefinition = action.GetActionDefinition("flow", FlowKind.Stateful);
            var actionInputs = Assert.IsType<JObject>(actionDefinition.Inputs);

            Assert.Equal(OperationOptions.EnableSchemaValidation, triggerDefinition.OperationOptions);
            Assert.Equal(2, triggerDefinition.RuntimeConfiguration.Concurrency.Runs);
            Assert.Equal("none", actionInputs["retryPolicy"]["type"].Value<string>());
            Assert.Equal("direct", actionDefinition.TrackedProperties["Source"].Value<string>());
        }

        [Fact]
        public void TrackedPropertyExpressionsUseFinalOperationNames()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var action = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("https://example.com"),
                method: () => System.Net.Http.HttpMethod.Get);

            action.WithTrackedProperty("Body", () => action.Body);
            action.WithName("Call");
            trigger.Then(action);

            var definition = WorkflowFactory.CreateStatefulWorkflow("TrackedPropertyBindings", trigger);

            Assert.Equal(
                """#{body("Call")}""",
                definition.Definition.Actions["Call"].TrackedProperties["Body"].Value<string>());
        }

        [Fact]
        public void ClientTrackingIdExpressionsUseFinalOperationNames()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var action = WorkflowActions.BuiltIn.Compose<string>(() => "value");

            trigger.WithClientTrackingId(() => action.Output);
            action.WithName("Source");
            trigger.Then(action);

            var definition = WorkflowFactory.CreateStatefulWorkflow("ClientTrackingBindings", trigger);

            Assert.Equal(
                """#{(outputs("Source")).ToObject<string>()}""",
                definition.Definition.Triggers[trigger.Name].Correlation.ClientTrackingId);
        }

        [Fact]
        public void LinkedSecureOutputsAreEnabledWithInputs()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(() => "value")
                .WithSecureInputs()
                .WithName("Compose");
            trigger.Then(compose);

            var definition = WorkflowFactory.CreateStatefulWorkflow("Secure", trigger);

            Assert.Equal(
                new[] { "inputs", "outputs" },
                definition.Definition.Actions["Compose"].RuntimeConfiguration.SecureData.Properties);
        }

        [Fact]
        public void ForEachConcurrencySerializesOnNestedControlAction()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var loop = WorkflowActions.BuiltIn.Control.ForEach(
                    items: () => new[] { 1, 2 },
                    actions: item => WorkflowActions.BuiltIn.Compose(() => item).WithName("Body"))
                .WithIterationConcurrency(4)
                .WithName("Loop");
            trigger.Then(loop);

            var definition = WorkflowFactory.CreateStatefulWorkflow("LoopSettings", trigger);

            Assert.Equal(4, definition.Definition.Actions["Loop"].RuntimeConfiguration.Concurrency.Repetitions);
        }

        [Fact]
        public void ContextAndCapabilityValidationRejectInvalidSettings()
        {
            var requestWithoutSchema = WorkflowTriggers.BuiltIn.CreateHttpTrigger()
                .WithSchemaValidation();
            Assert.Throws<InvalidOperationException>(
                () => WorkflowFactory.CreateStatefulWorkflow("MissingSchema", requestWithoutSchema));

            var concurrentRequest = WorkflowTriggers.BuiltIn.CreateHttpTrigger()
                .WithConcurrency(1);
            Assert.Throws<InvalidOperationException>(
                () => WorkflowFactory.CreateStatelessWorkflow("Stateless", concurrentRequest));

            var loopTrigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            loopTrigger.Then(WorkflowActions.BuiltIn.Control.ForEach(
                    items: () => new[] { 1 },
                    actions: item => WorkflowActions.BuiltIn.Compose(() => item))
                .WithIterationConcurrency(1));
            Assert.Throws<InvalidOperationException>(
                () => WorkflowFactory.CreateStatelessWorkflow("StatelessLoop", loopTrigger));

            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            Assert.Throws<ArgumentOutOfRangeException>(
                () => trigger.WithConcurrency(1, maximumWaitingRuns: 9));
            Assert.Throws<ArgumentOutOfRangeException>(
                () => trigger.WithConcurrency(1, maximumWaitingRuns: 101));

        }

        [Fact]
        public void RetryPolicyValidationRejectsInvalidShapes()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var action = WorkflowActions.BuiltIn.HttpAction(
                    uri: () => new Uri("https://example.com"),
                    method: () => System.Net.Http.HttpMethod.Get)
                .WithRetryPolicy(new RetryPolicy
                {
                    Type = RetryType.Fixed,
                    Count = 0,
                    Interval = TimeSpan.FromSeconds(1),
                });
            trigger.Then(action);

            Assert.Throws<InvalidOperationException>(
                () => WorkflowFactory.CreateStatefulWorkflow("InvalidRetry", trigger));

            var intervalTrigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            intervalTrigger.Then(WorkflowActions.BuiltIn.HttpAction(
                    uri: () => new Uri("https://example.com"),
                    method: () => System.Net.Http.HttpMethod.Get)
                .WithRetryPolicy(RetryPolicy.Fixed(1, TimeSpan.FromSeconds(1))));
            Assert.Throws<InvalidOperationException>(
                () => WorkflowFactory.CreateStatefulWorkflow("InvalidInterval", intervalTrigger));
        }

        [Fact]
        public void GeneratedManagedAndServiceProviderActionsCarrySettingsProfiles()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var managed = WorkflowActions.Managed.Office365("office")
                .GetOutlookCategoryNames()
                .WithRetryPolicy(RetryPolicy.None())
                .WithTrackedProperty("Connector", () => "managed")
                .WithName("Managed");
            var serviceProvider = WorkflowActions.ServiceProviders.ServiceBus("service")
                .SendMessage(
                    entityName: () => "orders",
                    message: () => new SendMessageInputMessageType { ContentData = "order" })
                .WithRetryPolicy(RetryPolicy.None())
                .WithSecureInputs()
                .WithSecureOutputs()
                .WithName("ServiceProvider");
            trigger.Then(managed).Then(serviceProvider);

            var definition = WorkflowFactory.CreateStatefulWorkflow("GeneratedSettings", trigger);
            var managedInputs = Assert.IsType<JObject>(definition.Definition.Actions["Managed"].Inputs);
            var serviceProviderInputs = Assert.IsType<JObject>(definition.Definition.Actions["ServiceProvider"].Inputs);

            Assert.Equal("none", managedInputs["retryPolicy"]["type"].Value<string>());
            Assert.Equal("managed", definition.Definition.Actions["Managed"].TrackedProperties["Connector"].Value<string>());
            Assert.Equal("none", serviceProviderInputs["retryPolicy"]["type"].Value<string>());
            Assert.Equal(
                new[] { "inputs", "outputs" },
                definition.Definition.Actions["ServiceProvider"].RuntimeConfiguration.SecureData.Properties);
        }

        [Fact]
        public void GeneratedServiceProviderTriggerCarriesManifestSettingsProfile()
        {
            var trigger = WorkflowTriggers.ServiceProviders.ServiceBus("service")
                .ReceiveQueueMessages(queueName: () => "orders")
                .WithConcurrency(2, maximumWaitingRuns: 10)
                .WithClientTrackingId(() => "service-bus")
                .WithName("ServiceBus");
            trigger.Then(WorkflowActions.BuiltIn.Compose(() => "received").WithName("Body"));

            var definition = WorkflowFactory.CreateStatefulWorkflow("ServiceProviderTriggerSettings", trigger);
            var generated = definition.Definition.Triggers["ServiceBus"];

            Assert.Equal(2, generated.RuntimeConfiguration.Concurrency.Runs);
            Assert.Equal(10, generated.RuntimeConfiguration.Concurrency.MaximumWaitingRuns);
            Assert.Equal("service-bus", generated.Correlation.ClientTrackingId);
        }

        [Fact]
        public void SettingsPreserveSpecializedOperationShapes()
        {
            var bodyAction = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("https://example.com"),
                method: () => System.Net.Http.HttpMethod.Get);
            IBodyWorkflowAction<JToken, HttpActionConfiguration> configuredBodyAction =
                bodyAction.WithRetryPolicy(RetryPolicy.None());

            var outputAction = WorkflowActions.BuiltIn.Compose<string>(() => "value");
            IOutputWorkflowAction<string, ComposeActionConfiguration> configuredOutputAction =
                outputAction.WithTrackedProperty("Source", () => "test");

            var outputTrigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            IOutputWorkflowTrigger<HttpRequestTriggerOutput, HttpRequestTriggerConfiguration> configuredOutputTrigger =
                outputTrigger.WithConcurrency(2);

            var agentAction = WorkflowActions.BuiltIn.Agent(
                agentModelType: AgentModelType.AzureOpenAI,
                deploymentId: "deployment",
                agentModelSettings: new AgentModelSettings(),
                connectionName: "connection",
                messages: () => Array.Empty<AgentPromptMessage>());
            IAgentWorkflowAction<AgentActionConfiguration> configuredAgentAction =
                agentAction.WithRetryPolicy(RetryPolicy.None());

            IBodyWorkflowAction<JToken, IRetryPolicyConfiguration> retryableBodyAction =
                configuredBodyAction;
            IOutputWorkflowAction<string, ITrackedPropertiesConfiguration> trackedOutputAction =
                configuredOutputAction;
            IOutputWorkflowTrigger<HttpRequestTriggerOutput, ITriggerConcurrencyConfiguration> concurrentOutputTrigger =
                configuredOutputTrigger;
            IAgentWorkflowAction<IRetryPolicyConfiguration> retryableAgentAction =
                configuredAgentAction;

            var variableAction = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "count",
                value: () => 0);
            IVariableWorkflowAction<ITrackedPropertiesConfiguration> trackedVariableAction =
                variableAction;

            Assert.Same(bodyAction, configuredBodyAction);
            Assert.Same(outputAction, configuredOutputAction);
            Assert.Same(outputTrigger, configuredOutputTrigger);
            Assert.Same(agentAction, configuredAgentAction);
            Assert.Same(configuredBodyAction, retryableBodyAction);
            Assert.Same(configuredOutputAction, trackedOutputAction);
            Assert.Same(configuredOutputTrigger, concurrentOutputTrigger);
            Assert.Same(configuredAgentAction, retryableAgentAction);
            Assert.Same(variableAction, trackedVariableAction);
        }

        [Fact]
        public void UnsupportedSettingsAreRejectedAtCompileTime()
        {
            const string Source = """
                using Microsoft.Azure.Workflows.Sdk;
                public sealed class Workflow
                {
                    public void Build()
                    {
                        var compose = WorkflowActions.BuiltIn.Compose(() => "value");
                        compose.WithRetryPolicy(RetryPolicy.None());
                        compose.WithSecureOutputs();
                    }
                }
                """;
            var compilation = CSharpCompilation.Create(
                "UnsupportedSettings",
                [CSharpSyntaxTree.ParseText(Source)],
                ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES"))
                    .Split(Path.PathSeparator)
                    .Append(typeof(WorkflowActions).Assembly.Location)
                    .Append(typeof(JToken).Assembly.Location)
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .Select(path => MetadataReference.CreateFromFile(path)),
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            var errors = compilation.GetDiagnostics()
                .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                .ToArray();

            Assert.Equal(2, errors.Length);
            Assert.All(errors, error => Assert.Equal("CS0311", error.Id));
        }

        [Fact]
        public void ConfigurationStateIsNotPubliclyMutable()
        {
            const string Source = """
                using Microsoft.Azure.Workflows.Sdk;
                public sealed class Workflow
                {
                    public void Build()
                    {
                        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
                        trigger.Configuration.ConcurrentRuns = 1;
                    }
                }
                """;
            var compilation = CSharpCompilation.Create(
                "ConfigurationState",
                [CSharpSyntaxTree.ParseText(Source)],
                ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES"))
                    .Split(Path.PathSeparator)
                    .Append(typeof(WorkflowActions).Assembly.Location)
                    .Append(typeof(JToken).Assembly.Location)
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .Select(path => MetadataReference.CreateFromFile(path)),
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            var error = Assert.Single(
                compilation.GetDiagnostics()
                    .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error));

            Assert.Equal("CS1061", error.Id);
        }
    }
}
