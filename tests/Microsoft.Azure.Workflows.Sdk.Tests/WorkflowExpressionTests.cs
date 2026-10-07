// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Reflection;
    using System.Runtime.ExceptionServices;
    using Microsoft.Azure.Workflows.Sdk.Build;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using Xunit;

    public class WorkflowExpressionTests
    {
        [Fact]
        public void BlockReadsSdkOutputAndMutatesItNatively()
        {
            var previous = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(() => new() { MessageId = "first" });
            var action = WorkflowActions.ServiceProviders.ServiceBus("serviceBus").SendMessage(
                entityName: () => "queue",
                message: () =>
                {
                    var message = previous.Output;
                    message.MessageId = message.MessageId.ToUpperInvariant();
                    return message;
                });
            previous.WithName("Prepare");
            var inputs = JObject.FromObject(action.GetActionDefinition("flow").Inputs);
            var code = inputs["parameters"]["message"].Value<string>();
            Assert.Contains("ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>", code);
            Assert.Equal("FIRST", Evaluate(code, JObject.Parse("""{"Prepare":{"messageId":"first"}}""")).Value<string>("messageId"));
        }

        [Fact]
        public void BoundaryConversionIsFlatAndEvaluatesSourceOnce()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "value").WithName("Source");
            var objectAction = WorkflowActions.BuiltIn.Compose(() =>
                new SendMessageInputMessageType { MessageId = previous.Output });
            var objectSource = Input(objectAction);
            Assert.Contains("JToken.FromObject((object)(", objectSource);
            Assert.DoesNotContain("Func<global::Newtonsoft.Json.Linq.JToken>", objectSource);
            Assert.Equal(1, objectSource.Split("outputs(\"Source\")").Length - 1);

            var textAction = WorkflowActions.BuiltIn.Compose(() => previous.Output.ToUpperInvariant());
            var textSource = Input(textAction);
            Assert.Contains("object result =", textSource);
            Assert.Contains("var token =", textSource);
            Assert.Equal(1, textSource.Split("outputs(\"Source\")").Length - 1);
            Assert.Equal("VALUE", Evaluate(textSource, JObject.Parse("""{"Source":"value"}""")).Value<string>());
        }

        [Fact]
        public void BlocksLoopsLocalFunctionsAndNestedLambdasRemainCSharp()
        {
            var offset = 3;
            var action = WorkflowActions.BuiltIn.Compose(() =>
            {
                int Double(int value) => value * 2;
                var sum = 0;
                for (var i = 0; i < 3; i++) sum += Double(i);
                return new[] { sum }.Select(value => value + offset).Single();
            });
            offset = 100;
            Assert.Equal(9, Evaluate(Input(action)).Value<int>());
        }

        [Fact]
        public void NestedSdkObjectsPreserveIdentityAndDictionaryMutation()
        {
            var action = WorkflowActions.BuiltIn.Compose(() =>
            {
                var usage = new Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai.GetChatCompletionsOutputUsageType { PromptTokens = 1 };
                var first = new Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai.GetChatCompletionsOutput { Usage = usage };
                var second = new Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai.GetChatCompletionsOutput { Usage = usage };
                usage.PromptTokens++;
                var output = new HttpRequestTriggerOutput { Headers = new Dictionary<string, string> { ["X"] = "before" } };
                output.Headers["X"] = "after";
                return second.Usage.PromptTokens + output.Headers["X"];
            });
            Assert.Equal("2after", Evaluate(Input(action)).Value<string>());
        }

        [Fact]
        public void SdkEnumsRetainNumericAndNullableSemantics()
        {
            var action = WorkflowActions.BuiltIn.Compose(() =>
            {
                MessageRole? role = MessageRole.User;
                return role.Value.ToString("D") + ((int)role.Value + 1);
            });
            Assert.Equal(((int)MessageRole.User).ToString() + ((int)MessageRole.User + 1), Evaluate(Input(action)).Value<string>());
        }

        [Fact]
        public void ScalarCapturesAreSnapshottedAsCSharp()
        {
            var id = Guid.Parse("00000000-0000-0000-0000-000000000001");
            var date = new DateTime(2026, 10, 6, 1, 0, 0, DateTimeKind.Utc);
            var suffix = "!";
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "hello");
            var action = WorkflowActions.BuiltIn.Compose(() => previous.Output + suffix + id.ToString("N") + date.Kind);
            suffix = "?";
            previous.WithName("Late");
            Assert.Equal("hello!00000000000000000000000000000001Utc", Evaluate(Input(action), JObject.Parse("""{"Late":"hello"}""")).Value<string>());
            Assert.DoesNotContain("JsonTextReader", Input(action));
        }

        [Fact]
        public void ManagedActionAndTriggerPropertiesUseTypedRoots()
        {
            var email = WorkflowActions.Managed.Office365("office").GetEmail(messageId: () => "id").WithName("Email");
            var action = WorkflowActions.BuiltIn.Compose(() => email.Body.Subject.ToUpperInvariant());
            Assert.Contains(".Subject", Input(action));
            Assert.Equal("HELLO", Evaluate(Input(action), JObject.Parse("""{"Email":{"subject":"hello"}}""")).Value<string>());
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var triggered = WorkflowActions.BuiltIn.Compose(() => trigger.TriggerOutput.Headers["X"]);
            Assert.Equal("value", Evaluate(Input(triggered), JObject.Parse("""{"trigger":{"headers":{"X":"value"}}}""")).Value<string>());
        }

        [Fact]
        public void WorkflowFunctionsBecomeExistingHostCalls()
        {
            var action = WorkflowActions.BuiltIn.Compose(() => WorkflowFunctions.ToJson<SendMessageInputMessageType>("{\"messageId\":\"id\"}").MessageId);
            Assert.Contains("json(", Input(action));
            Assert.DoesNotContain("WorkflowFunctions", Input(action));
            Assert.Equal("id", Evaluate(Input(action)).Value<string>());
        }

        [Fact]
        public void ExplicitSdkCastOnObjectOutputUsesTypedContextConversion()
        {
            var previous = WorkflowActions.BuiltIn.Compose<object>(() => new SendMessageInputMessageType { MessageId = "id" }).WithName("Object");
            var action = WorkflowActions.BuiltIn.Compose(() => ((SendMessageInputMessageType)previous.Output).MessageId);
            Assert.Equal("id", Evaluate(Input(action), JObject.Parse("""{"Object":{"messageId":"id"}}""")).Value<string>());
        }

        [Fact]
        public void ControlCallbacksRunOnceAndDefinitionsResolveNamesLate()
        {
            var count = 0;
            var previous = WorkflowActions.BuiltIn.Compose<bool>(() => true);
            var condition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => previous.Output,
                trueBranch: () => { count++; return WorkflowActions.BuiltIn.Compose(() => "yes"); },
                falseBranch: () => null);
            previous.WithName("Flag");
            Assert.True(Evaluate(condition.GetActionDefinition("flow").Expression.Value<string>(), JObject.Parse("""{"Flag":true}""")).Value<bool>());
            condition.GetActionDefinition("flow");
            Assert.Equal(1, count);
        }

        [Fact]
        public void DynamicHeadersAndStatusCodeRemainExpressions()
        {
            var previous = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
            var response = WorkflowActions.BuiltIn.Response(
                statusCode: () => previous.Output ? System.Net.HttpStatusCode.Accepted : System.Net.HttpStatusCode.BadRequest,
                headers: () => new Dictionary<string, string> { ["X"] = previous.Output ? "yes" : "no" });
            var inputs = JObject.FromObject(response.GetActionDefinition("flow").Inputs);
            Assert.Equal(202, Evaluate(inputs["StatusCode"].Value<string>(), JObject.Parse("""{"Flag":true}""")).Value<int>());
            Assert.Equal("yes", Evaluate(inputs["Headers"].Value<string>(), JObject.Parse("""{"Flag":true}""")).Value<string>("X"));
        }

        [Fact]
        public void ReusedSourceLambdaAndAnonymousResultWork()
        {
            var suffix = "!";
            Func<string> source = () => suffix;
            var first = WorkflowActions.BuiltIn.Compose(source);
            Assert.Equal("!", ((JToken)first.GetActionDefinition("flow").Inputs).Value<string>());
            var action = WorkflowActions.BuiltIn.Compose(() => new { Value = DateTime.UtcNow.Year, Role = MessageRole.User });
            Assert.Equal("User", Evaluate(Input(action)).Value<string>("Role"));
            var nullValue = WorkflowActions.BuiltIn.Compose<object>(() => null);
            Assert.Equal(JTokenType.Null, ((JToken)nullValue.GetActionDefinition("flow").Inputs).Type);
        }

        [Fact]
        public void VariableNamesAndRequiredDescriptorValidationRemainExplicit()
        {
            var name = "value";
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => name, value: () => 1);
            Assert.Equal("value", variable.VariableName);
            Assert.Throws<ArgumentNullException>(() => WorkflowExpression.Validate(null, "input", true));
            Assert.Throws<ArgumentException>(() => WorkflowExpression.Program<int>(new[] { "" }, new WorkflowExpressionBinding[] { null }));
        }

        [Fact]
        public void VariablesAndWorkflowForeachItemsUseContextBindings()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => "counter", value: () => 1);
            var read = WorkflowActions.BuiltIn.Compose(() => variable.Value.Value<int>() + 1);
            Assert.Equal(3, Evaluate(Input(read), JObject.Parse("""{"counter":2}""")).Value<int>());
            var loop = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => new[] { "hello" },
                actions: item => WorkflowActions.BuiltIn.Compose(() => item.Value<string>().ToUpperInvariant()).WithName("Upper"));
            var inner = loop.GetActionDefinition("flow").Actions["Upper"].Inputs as JToken;
            Assert.Equal("HELLO", Evaluate(inner.Value<string>(), JObject.Parse("""{"item":"hello"}""")).Value<string>());
        }

        [Fact]
        public void ConditionalCaptureCannotBeAssignedInsideTheValueLambda()
        {
            const string Source = """
                using Microsoft.Azure.Workflows.Sdk;
                public class Consumer {
                    public void Build() {
                        var captured = 1;
                        WorkflowActions.BuiltIn.Compose(() => { captured++; return captured; });
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(Source) },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            Assert.Contains(ExpressionCompiler.Transform(compilation).Diagnostics, diagnostic => diagnostic.GetMessage().Contains("snapshots"));
        }

        [Theory]
        [InlineData("async () => await System.Threading.Tasks.Task.FromResult(1)", "")]
        [InlineData("() => helper.Count", "var helper = new System.Collections.Generic.List<int>();")]
        [InlineData("() => Customer.Get()", "", "public static class Customer { public static int Get() => 1; }")]
        public void UnsupportedCapturesAndDependenciesFailDuringAuthoring(string lambda, string locals, string declarations = "")
        {
            var source = $"using Microsoft.Azure.Workflows.Sdk; public class Consumer {{ public void Build() {{ {locals} WorkflowActions.BuiltIn.Compose({lambda}); }} }} {declarations}";
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(source, path: "Consumer.cs") },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            Assert.Contains(ExpressionCompiler.Transform(compilation).Diagnostics, diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        }

        [Fact]
        public void AllFactoriesHaveDescriptorEntriesAndNoDelegateTransport()
        {
            var methods = typeof(WorkflowActions).Assembly.GetTypes().SelectMany(type => type.GetMethods())
                .Where(method => method.GetCustomAttribute<WorkflowExpressionFactoryAttribute>() != null).ToArray();
            Assert.True(methods.Length > 10000);
            foreach (var method in methods)
            {
                var entry = method.GetCustomAttribute<WorkflowExpressionFactoryAttribute>().EntryPoint;
                Assert.Contains(method.DeclaringType.GetMethods(), candidate => candidate.Name == entry &&
                    candidate.GetParameters().Length == method.GetParameters().Length);
            }
        }

        [Fact]
        public void GeneratedTriggersUseUniqueDefaultsAndWithNameOnly()
        {
            var managedMethod = typeof(Microsoft.Azure.Workflows.Sdk.Connectors.Office365.Office365Triggers)
                .GetMethod("OnNewEmail");
            Assert.DoesNotContain(managedMethod.GetParameters(), parameter => parameter.Name == "triggerName");
            var first = WorkflowTriggers.Managed.Office365("office").OnNewEmail();
            var second = WorkflowTriggers.Managed.Office365("office").OnNewEmail();
            Assert.NotEqual(first.Name, second.Name);
            Assert.DoesNotContain(first.Name, new[] { "ApiConnectionTrigger", "ServiceProviderTrigger" });
            first.WithName("Managed").Then(WorkflowActions.BuiltIn.Compose(() => "yes").WithName("Action"));
            var managedDefinition = WorkflowFactory.CreateStatefulWorkflow("ManagedFlow", first);
            Assert.Contains("Managed", managedDefinition.Definition.Triggers.Keys);

            var serviceFirst = WorkflowTriggers.ServiceProviders.ServiceBus("service").ReceiveQueueMessages(() => "queue");
            var serviceSecond = WorkflowTriggers.ServiceProviders.ServiceBus("service").ReceiveQueueMessages(() => "queue");
            Assert.NotEqual(serviceFirst.Name, serviceSecond.Name);
            serviceFirst.WithName("Service").Then(WorkflowActions.BuiltIn.Compose(() => "yes").WithName("Action"));
            var serviceDefinition = WorkflowFactory.CreateStatefulWorkflow("ServiceFlow", serviceFirst);
            Assert.Contains("Service", serviceDefinition.Definition.Triggers.Keys);
        }

        internal static string Input(IWorkflowAction action) => ((JToken)action.GetActionDefinition("flow").Inputs).Value<string>();
        private static IEnumerable<MetadataReference> References() =>
            ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")).Split(Path.PathSeparator)
                .Append(typeof(WorkflowExpression).Assembly.Location).Append(typeof(JToken).Assembly.Location)
                .Distinct(StringComparer.OrdinalIgnoreCase).Select(path => MetadataReference.CreateFromFile(path));
        private static JToken Evaluate(string expression, JObject values = null)
        {
            Assert.StartsWith("#{", expression);
            var source = $$"""
                using System; using System.Linq; using System.Collections.Generic; using Newtonsoft.Json.Linq;
                public static class Evaluation {
                    public static object Run(JObject values) {
                        JToken outputs(string name) => values[name];
                        JToken body(string name) => values[name];
                        JToken triggerOutputs() => values["trigger"];
                        JToken triggerBody() => values["trigger"]?["body"];
                        JToken variables(string name) => values[name];
                        JToken item() => values["item"];
                        JToken json(string value) => JToken.Parse(value);
                        return {{expression.Substring(2, expression.Length - 3)}};
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Evaluation_" + Guid.NewGuid().ToString("N"),
                new[] { CSharpSyntaxTree.ParseText(source) }, References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            using var stream = new MemoryStream();
            var result = compilation.Emit(stream);
            Assert.True(result.Success, string.Join("\n", result.Diagnostics) + "\n" + source);
            try
            {
                var value = Assembly.Load(stream.ToArray()).GetType("Evaluation").GetMethod("Run").Invoke(null, new object[] { values ?? new JObject() });
                var serializer = new JsonSerializer();
                serializer.Converters.Add(new StringEnumConverter());
                return value == null ? JValue.CreateNull() : JToken.FromObject(value, serializer);
            }
            catch (TargetInvocationException error) when (error.InnerException != null)
            {
                ExceptionDispatchInfo.Capture(error.InnerException).Throw();
                throw;
            }
        }
    }
}
