// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk.Build;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Newtonsoft.Json.Linq;
    using Xunit;
    using static WorkflowExpressionTestSource;

    public class WorkflowExpressionCompilerTests
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
        public void InterpolationAndPropertyPatternsRemainCSharp()
        {
            var previous = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(
                () => new SendMessageInputMessageType { MessageId = "id" }).WithName("Message");
            var action = WorkflowActions.BuiltIn.Compose(() =>
                previous.Output is { MessageId: "id" } ? $"ID:{previous.Output.MessageId}" : "none");

            var expression = Assert.IsType<ConditionalExpressionSyntax>(ReturnExpression(Input(action)));
            var pattern = Assert.IsType<IsPatternExpressionSyntax>(expression.Condition);
            Assert.Equal("MessageId", pattern.Pattern.DescendantNodesAndSelf()
                .OfType<SubpatternSyntax>().Single().NameColon.Name.Identifier.ValueText);
            Assert.IsType<ParenthesizedExpressionSyntax>(
                expression.WhenTrue.DescendantNodes().OfType<InterpolationSyntax>().Single().Expression);
            Assert.Equal(2, expression.DescendantNodes().OfType<InvocationExpressionSyntax>()
                .Count(invocation => invocation.Expression.ToString() == "outputs"));
        }

        [Fact]
        public void CheckedAndUncheckedContextsRemainDistinct()
        {
            var previous = WorkflowActions.BuiltIn.Compose<int>(() => 1).WithName("Value");
            IOutputWorkflowAction<int> checkedAction;
            IOutputWorkflowAction<int> uncheckedAction;
            checked
            {
                checkedAction = WorkflowActions.BuiltIn.Compose(() => previous.Output + 1);
            }
            unchecked
            {
                uncheckedAction = WorkflowActions.BuiltIn.Compose(() => previous.Output + 1);
            }

            Assert.IsType<CheckedExpressionSyntax>(ProgramExpression(Input(checkedAction)));
            Assert.IsNotType<CheckedExpressionSyntax>(ProgramExpression(Input(uncheckedAction)));
        }

        [Fact]
        public void NameofFoldsWithoutRuntimeTypeDependency()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "value").WithName("Source");
            var action = WorkflowActions.BuiltIn.Compose(() =>
                nameof(WorkflowExpressionCompilerTests) + previous.Output);

            AssertReturnExpression(
                "\"WorkflowExpressionCompilerTests\" + (outputs(\"Source\")).ToObject<string>()",
                Input(action));
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
        public void CustomDtoLeafPathsDefaultOnlyMissingTypedTokens()
        {
            const string Source = """
                using Microsoft.Azure.Workflows.Sdk;
                using Newtonsoft.Json;
                using Newtonsoft.Json.Linq;
                public sealed class Address {
                    [JsonProperty("city_name")]
                    public string City { get; set; }
                }
                public sealed class Customer {
                    [JsonProperty("optional_name")]
                    public string OptionalName { get; set; }
                    public int Count { get; set; }
                    public JToken Token { get; set; }
                    [JsonProperty("address")]
                    public Address Address { get; set; }
                }
                public sealed class Consumer {
                    public void Build(IOutputWorkflowAction<Customer> customer) {
                        WorkflowActions.BuiltIn.Compose(() => customer.Output.OptionalName);
                        WorkflowActions.BuiltIn.Compose(() => customer.Output.Count);
                        WorkflowActions.BuiltIn.Compose(() => customer.Output.Token);
                        WorkflowActions.BuiltIn.Compose(() => customer.Output.Address.City);
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(Source, path: "Consumer.cs") },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            var result = ExpressionCompiler.Transform(compilation);
            Assert.Empty(result.Diagnostics);
            var programs = RenderPrograms(result.Sources["Consumer.cs"], """outputs("Customer")""");

            Assert.Equal(4, programs.Length);
            AssertReturnExpression(
                """(outputs("Customer")["optional_name"])?.ToObject<string>() ?? default(string)""",
                programs[0]);
            AssertReturnExpression(
                """(outputs("Customer")["Count"])?.ToObject<int>() ?? default(int)""",
                programs[1]);
            AssertReturnExpression("""outputs("Customer")["Token"]""", programs[2]);
            AssertReturnExpression(
                """(outputs("Customer")["address"]["city_name"])?.ToObject<string>() ?? default(string)""",
                programs[3]);
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

        [Theory]
        [InlineData("System.Func<int> value = () => 1;", "value = () => 2;", "")]
        [InlineData("System.Func<int> value = flag ? (() => 1) : (() => 2);", "", "private bool flag = true;")]
        [InlineData("System.Func<int> value = () => 1;", "Mutate(ref value);", "private static void Mutate(ref System.Func<int> value) { }")]
        public void StoredLambdaMustHaveOneUnmodifiedSource(
            string declaration,
            string beforeCall,
            string additionalMember)
        {
            var source = $$"""
                using Microsoft.Azure.Workflows.Sdk;
                public class Consumer {
                    {{additionalMember}}
                    public void Build() {
                        {{declaration}}
                        {{beforeCall}}
                        WorkflowActions.BuiltIn.Compose(value);
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(source, path: "Consumer.cs") },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            var diagnostic = Assert.Single(ExpressionCompiler.Transform(compilation).Diagnostics);
            Assert.Contains("inline lambda or an unreassigned source-visible local lambda", diagnostic.GetMessage());
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
    }
}
