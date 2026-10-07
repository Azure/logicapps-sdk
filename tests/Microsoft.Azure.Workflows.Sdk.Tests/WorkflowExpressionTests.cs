// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Reflection;
    using Microsoft.Azure.Workflows.Sdk.Build;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using Xunit;

    public class WorkflowExpressionTests
    {
        private int instanceOffset;
        private int InstanceAutoOffset { get; set; }
        private int InstanceComputedOffset => 5;
        private IOutputWorkflowAction<string> instanceSource;

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
            var body = ProgramBody(code);
            Assert.Equal(
                NormalizeExpression(
                    """(outputs("Prepare")).ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>()"""),
                NormalizeNode(body.Statements.OfType<LocalDeclarationStatementSyntax>().Single()
                    .Declaration.Variables.Single().Initializer.Value));
            Assert.Equal(
                NormalizeExpression("message.MessageId = message.MessageId.ToUpperInvariant()"),
                NormalizeNode(body.Statements.OfType<ExpressionStatementSyntax>().Single().Expression));
            Assert.Equal("message", NormalizeNode(body.Statements.OfType<ReturnStatementSyntax>().Single().Expression));
        }

        [Fact]
        public void BoundaryConversionPreservesRawClrSource()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "value").WithName("Source");
            var objectAction = WorkflowActions.BuiltIn.Compose(() =>
                new SendMessageInputMessageType { MessageId = previous.Output });
            var objectSource = Input(objectAction);
            Assert.DoesNotContain("JToken.FromObject", objectSource);
            Assert.DoesNotContain("JsonSerializer", objectSource);
            AssertReturnExpression(
                """new global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType { MessageId = (outputs("Source")).ToObject<string>() }""",
                objectSource);
            Assert.Equal(1, objectSource.Split("outputs(\"Source\")").Length - 1);

            var textAction = WorkflowActions.BuiltIn.Compose(() => previous.Output.ToUpperInvariant());
            var textSource = Input(textAction);
            Assert.DoesNotContain("JToken.FromObject", textSource);
            Assert.DoesNotContain("object result =", textSource);
            AssertReturnExpression("""(outputs("Source")).ToObject<string>().ToUpperInvariant()""", textSource);
            Assert.Equal(1, textSource.Split("outputs(\"Source\")").Length - 1);
        }

        [Fact]
        public void SpecialClrValuesRemainRuntimeExpressions()
        {
            var bytes = WorkflowActions.BuiltIn.Compose(() => new byte[] { 1, 2, 3 });
            var byteSource = Input(bytes);
            AssertReturnExpression("new byte[] { 1, 2, 3 }", byteSource);
            Assert.DoesNotContain("JToken.FromObject", byteSource);

            var method = WorkflowActions.BuiltIn.Compose(() => System.Net.Http.HttpMethod.Post);
            var methodSource = Input(method);
            AssertReturnExpression("System.Net.Http.HttpMethod.Post", methodSource);
            Assert.DoesNotContain("JToken.FromObject", methodSource);

            var capturedMethod = System.Net.Http.HttpMethod.Patch;
            var capturedMethodSource = Input(WorkflowActions.BuiltIn.Compose(() => capturedMethod));
            Assert.Equal(
                new[] { NormalizeExpression("""new global::System.Net.Http.HttpMethod("PATCH")""") },
                CaptureInitializers(capturedMethodSource));
            AssertReturnExpression("__capture0", capturedMethodSource);

            var enumSource = Input(WorkflowActions.BuiltIn.Compose(() => MessageRole.User));
            AssertReturnExpression("global::Microsoft.Azure.Workflows.Sdk.MessageRole.User", enumSource);
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
            var source = Input(action);
            var body = ProgramBody(source);
            Assert.Single(body.Statements.OfType<LocalFunctionStatementSyntax>());
            Assert.Single(body.Statements.OfType<ForStatementSyntax>());
            Assert.Single(body.DescendantNodes().OfType<SimpleLambdaExpressionSyntax>());
            Assert.Equal(new[] { NormalizeExpression("(global::System.Int32)(3)") }, CaptureInitializers(source));
            Assert.Equal(
                NormalizeExpression("new[] { sum }.Select(value => value + __capture0).Single()"),
                NormalizeNode(body.Statements.OfType<ReturnStatementSyntax>().Single().Expression));
            Assert.DoesNotContain("(100)", source);
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
            var source = Input(action);
            var body = ProgramBody(source);
            Assert.Equal(2, body.DescendantNodes().OfType<AssignmentExpressionSyntax>()
                .Count(assignment => assignment.Left.ToString() == "Usage"));
            Assert.Single(body.DescendantNodes().OfType<PostfixUnaryExpressionSyntax>(),
                expression => expression.Operand.ToString() == "usage.PromptTokens");
            Assert.Contains(body.DescendantNodes().OfType<AssignmentExpressionSyntax>(),
                assignment => NormalizeNode(assignment) == NormalizeExpression("output.Headers[\"X\"] = \"after\""));
            Assert.Equal(
                NormalizeExpression("""second.Usage.PromptTokens + output.Headers["X"]"""),
                NormalizeNode(body.Statements.OfType<ReturnStatementSyntax>().Single().Expression));
        }

        [Fact]
        public void SdkEnumsRetainNumericAndNullableSemantics()
        {
            var action = WorkflowActions.BuiltIn.Compose(() =>
            {
                MessageRole? role = MessageRole.User;
                return role.Value.ToString("D") + ((int)role.Value + 1);
            });
            var source = Input(action);
            var body = ProgramBody(source);
            Assert.Equal(
                NormalizeNode(SyntaxFactory.ParseStatement(
                    "global::Microsoft.Azure.Workflows.Sdk.MessageRole? role = global::Microsoft.Azure.Workflows.Sdk.MessageRole.User;")),
                NormalizeNode(body.Statements.OfType<LocalDeclarationStatementSyntax>().Single()));
            Assert.Equal(
                NormalizeExpression("""role.Value.ToString("D") + ((int)role.Value + 1)"""),
                NormalizeNode(body.Statements.OfType<ReturnStatementSyntax>().Single().Expression));
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
            var source = Input(action);
            Assert.Equal(
                new[]
                {
                    NormalizeExpression("\"!\""),
                    NormalizeExpression("""new global::System.Guid("00000000-0000-0000-0000-000000000001")"""),
                    NormalizeExpression("new global::System.DateTime(639268452000000000L, global::System.DateTimeKind.Utc)"),
                },
                CaptureInitializers(source));
            AssertReturnExpression(
                """(outputs("Late")).ToObject<string>() + __capture0 + __capture1.ToString("N") + __capture2.Kind""",
                source);
            Assert.DoesNotContain(""" = "?";""", source);
            Assert.DoesNotContain("JsonTextReader", source);
        }

        [Fact]
        public void InstanceFieldsAndAutoPropertiesAreSnapshotted()
        {
            this.instanceOffset = 2;
            this.InstanceAutoOffset = 3;
            var action = WorkflowActions.BuiltIn.Compose(() => this.instanceOffset + InstanceAutoOffset);
            this.instanceOffset = 20;
            this.InstanceAutoOffset = 30;

            var source = Input(action);
            Assert.DoesNotContain(nameof(this.instanceOffset), source);
            Assert.DoesNotContain(nameof(this.InstanceAutoOffset), source);
            Assert.Equal(
                new[] { NormalizeExpression("(global::System.Int32)(2)"), NormalizeExpression("(global::System.Int32)(3)") },
                CaptureInitializers(source));
            AssertReturnExpression("__capture0 + __capture1", source);
            Assert.DoesNotContain("(20)", source);
            Assert.DoesNotContain("(30)", source);
        }

        [Fact]
        public void InstanceWorkflowHandleRemainsALateBoundOperationBinding()
        {
            this.instanceSource = WorkflowActions.BuiltIn.Compose<string>(() => "hello");
            var action = WorkflowActions.BuiltIn.Compose(() => instanceSource.Output.ToUpperInvariant());
            this.instanceSource.WithName("InstanceSource");

            var source = Input(action);
            AssertReturnExpression("""(outputs("InstanceSource")).ToObject<string>().ToUpperInvariant()""", source);
        }

        [Theory]
        [InlineData("() => InstanceComputedOffset", "executable getter")]
        [InlineData("() => GetOffset()", "Instance method")]
        [InlineData("() => { instanceOffset++; return instanceOffset; }", "snapshots")]
        [InlineData("() => values.Count", "mutable objects")]
        public void UnsupportedInstanceDependenciesFailDuringAuthoring(string lambda, string message)
        {
            var source = $$"""
                using Microsoft.Azure.Workflows.Sdk;
                public class Consumer {
                    private int instanceOffset = 1;
                    private int InstanceComputedOffset => 2;
                    private System.Collections.Generic.List<int> values = new();
                    private int GetOffset() => 3;
                    public void Build() {
                        WorkflowActions.BuiltIn.Compose({{lambda}});
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(source, path: "Consumer.cs") },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            Assert.Contains(ExpressionCompiler.Transform(compilation).Diagnostics,
                diagnostic => diagnostic.GetMessage().Contains(message, StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ManagedActionAndTriggerPropertiesUseTypedRoots()
        {
            var email = WorkflowActions.Managed.Office365("office").GetEmail(messageId: () => "id").WithName("Email");
            var action = WorkflowActions.BuiltIn.Compose(() => email.Body.Subject.ToUpperInvariant());
            var actionSource = Input(action);
            var actionReturn = ReturnExpression(actionSource);
            Assert.Equal("ToUpperInvariant", ((InvocationExpressionSyntax)actionReturn).Expression
                .DescendantNodesAndSelf().OfType<SimpleNameSyntax>().Last().Identifier.ValueText);
            Assert.Equal("""body("Email")""", actionReturn.DescendantNodesAndSelf().OfType<InvocationExpressionSyntax>()
                .Single(invocation => invocation.Expression.ToString() == "body").ToString());
            Assert.Single(actionReturn.DescendantNodesAndSelf().OfType<GenericNameSyntax>(),
                name => name.Identifier.ValueText == "ToObject");
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var triggered = WorkflowActions.BuiltIn.Compose(() => trigger.TriggerOutput.Headers["X"]);
            var triggerSource = Input(triggered);
            var triggerReturn = ReturnExpression(triggerSource);
            Assert.Equal("triggerOutputs()", triggerReturn.DescendantNodesAndSelf().OfType<InvocationExpressionSyntax>()
                .Single(invocation => invocation.Expression.ToString() == "triggerOutputs").ToString());
            Assert.Single(triggerReturn.DescendantNodesAndSelf().OfType<GenericNameSyntax>(),
                name => name.Identifier.ValueText == "ToObject");
            Assert.Equal("\"X\"", triggerReturn.DescendantNodesAndSelf().OfType<BracketedArgumentListSyntax>().Single()
                .Arguments.Single().Expression.ToString());
        }

        [Fact]
        public void WorkflowFunctionsBecomeExistingHostCalls()
        {
            var action = WorkflowActions.BuiltIn.Compose(() => WorkflowFunctions.ToJson<SendMessageInputMessageType>("{\"messageId\":\"id\"}").MessageId);
            var source = Input(action);
            AssertReturnExpression(
                """(json("{\"messageId\":\"id\"}")).ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>().MessageId""",
                source);
            Assert.DoesNotContain("WorkflowFunctions", source);
        }

        [Fact]
        public void ExplicitSdkCastOnObjectOutputUsesTypedContextConversion()
        {
            var previous = WorkflowActions.BuiltIn.Compose<object>(() => new SendMessageInputMessageType { MessageId = "id" }).WithName("Object");
            var action = WorkflowActions.BuiltIn.Compose(() => ((SendMessageInputMessageType)previous.Output).MessageId);
            var source = Input(action);
            AssertReturnExpression(
                """((outputs("Object")).ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>()).MessageId""",
                source);
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
            var source = condition.GetActionDefinition("flow").Expression.Value<string>();
            AssertReturnExpression("""(outputs("Flag")).ToObject<bool>()""", source);
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
            var statusSource = inputs["StatusCode"].Value<string>();
            AssertReturnExpression(
                """(outputs("Flag")).ToObject<bool>() ? System.Net.HttpStatusCode.Accepted : System.Net.HttpStatusCode.BadRequest""",
                statusSource);
            var headersSource = inputs["Headers"].Value<string>();
            AssertReturnExpression(
                """new global::System.Collections.Generic.Dictionary<string, string> { ["X"] = (outputs("Flag")).ToObject<bool>() ? "yes" : "no" }""",
                headersSource);
        }

        [Fact]
        public void ReusedSourceLambdaAndAnonymousResultWork()
        {
            var suffix = "!";
            Func<string> source = () => suffix;
            var first = WorkflowActions.BuiltIn.Compose(source);
            Assert.Equal("!", ((JToken)first.GetActionDefinition("flow").Inputs).Value<string>());
            var action = WorkflowActions.BuiltIn.Compose(() => new { Value = DateTime.UtcNow.Year, Role = MessageRole.User });
            var actionSource = Input(action);
            AssertReturnExpression(
                "new { Value = global::System.DateTime.UtcNow.Year, Role = global::Microsoft.Azure.Workflows.Sdk.MessageRole.User }",
                actionSource);
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
            var readSource = Input(read);
            AssertReturnExpression("""variables("counter").Value<int>() + 1""", readSource);
            var loop = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => new[] { "hello" },
                actions: item => WorkflowActions.BuiltIn.Compose(() => item.Value<string>().ToUpperInvariant()).WithName("Upper"));
            var inner = loop.GetActionDefinition("flow").Actions["Upper"].Inputs as JToken;
            AssertReturnExpression("item().Value<string>().ToUpperInvariant()", inner.Value<string>());
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
        public void SdkEnumsDeclareTheirWireRepresentation()
        {
            var missing = typeof(WorkflowActions).Assembly.GetTypes()
                .Where(type => type.IsEnum &&
                    type.GetCustomAttribute<JsonConverterAttribute>()?.ConverterType != typeof(StringEnumConverter) &&
                    !IsGeneratedIntegerEnum(type))
                .Select(type => type.FullName)
                .OrderBy(name => name)
                .ToArray();

            Assert.True(missing.Length == 0, string.Join(Environment.NewLine, missing));
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

        internal static string Input(IWorkflowAction action)
        {
            var source = ((JToken)action.GetActionDefinition("flow").Inputs).Value<string>();
            ProgramExpression(source);
            return source;
        }
        private static ExpressionSyntax ProgramExpression(string source)
        {
            Assert.StartsWith("#{", source);
            Assert.EndsWith("}", source);
            var expression = SyntaxFactory.ParseExpression(source.Substring(2, source.Length - 3));
            Assert.DoesNotContain(expression.GetDiagnostics(), diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
            return expression;
        }
        private static BlockSyntax ProgramBody(string source) =>
            (BlockSyntax)ProgramExpression(source).DescendantNodesAndSelf()
                .OfType<ParenthesizedLambdaExpressionSyntax>()
                .First(lambda => lambda.Body is BlockSyntax).Body;
        private static ExpressionSyntax ReturnExpression(string source) =>
            ProgramBody(source).Statements.OfType<ReturnStatementSyntax>().Single().Expression;
        private static void AssertReturnExpression(string expected, string source) =>
            Assert.Equal(NormalizeExpression(expected), NormalizeNode(ReturnExpression(source)));
        private static string[] CaptureInitializers(string source) =>
            ProgramBody(source).Statements.OfType<LocalDeclarationStatementSyntax>()
                .SelectMany(statement => statement.Declaration.Variables)
                .Where(variable => variable.Identifier.ValueText.StartsWith("__capture", StringComparison.Ordinal))
                .Select(variable => NormalizeNode(variable.Initializer.Value))
                .ToArray();
        private static string NormalizeExpression(string source)
        {
            var expression = SyntaxFactory.ParseExpression(source);
            Assert.DoesNotContain(expression.GetDiagnostics(), diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
            return NormalizeNode(expression);
        }
        private static string NormalizeNode(SyntaxNode node) => node.NormalizeWhitespace().ToFullString();
        private static IEnumerable<MetadataReference> References() =>
            ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")).Split(Path.PathSeparator)
                .Append(typeof(WorkflowExpression).Assembly.Location).Append(typeof(JToken).Assembly.Location)
                .Distinct(StringComparer.OrdinalIgnoreCase).Select(path => MetadataReference.CreateFromFile(path));
        private static bool IsGeneratedIntegerEnum(Type type)
        {
            var names = Enum.GetNames(type);
            if (names.Length == 0) return false;
            var values = Enum.GetValues(type).Cast<object>().Select(value => Convert.ToInt64(value)).ToArray();
            for (var index = 0; index < names.Length; index++)
            {
                var name = names[index];
                if (name.StartsWith("_", StringComparison.Ordinal) &&
                    long.TryParse(name.Substring(1), out var positive) &&
                    values[index] == positive)
                {
                    continue;
                }
                if (name.StartsWith("Negative", StringComparison.Ordinal) &&
                    long.TryParse(name.Substring("Negative".Length), out var negative) &&
                    values[index] == -negative)
                {
                    continue;
                }
                return false;
            }
            return true;
        }
    }
}
