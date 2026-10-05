// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Reflection;
    using System.Runtime.ExceptionServices;
    using Microsoft.Azure.Workflows.Sdk.Build;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Newtonsoft.Json.Linq;
    using Xunit;

    public class WorkflowExpressionTests
    {
        [Fact]
        public void BlockBodyReadsTypedOutputAndPreservesSdkModels()
        {
            var previous = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(() =>
                new SendMessageInputMessageType { ContentData = "hello", MessageId = "first" });
            var action = WorkflowActions.ServiceProviders.ServiceBus("serviceBus").SendMessage(
                entityName: () => "queue",
                message: () =>
                {
                    var inputMessage = previous.Output;
                    inputMessage.MessageId = inputMessage.MessageId.ToUpperInvariant();
                    return inputMessage;
                });
            previous.WithName("Prepare");
            var inputs = JObject.FromObject(action.GetActionDefinition("flow").Inputs);
            var source = inputs["parameters"]["message"].Value<string>();
            var result = Evaluate(source, JObject.Parse("""{"Prepare":{"contentData":"hello","messageId":"first"}}"""));
            Assert.Equal("FIRST", result.Value<string>("messageId"));
            Assert.Equal("hello", result.Value<string>("contentData"));
        }

        [Fact]
        public void BlocksSupportLocalsLoopsAndNestedLambdas()
        {
            var offset = 3;
            var action = WorkflowActions.BuiltIn.Compose(() =>
            {
                var sum = 0;
                foreach (var number in new[] { 1, 2, 3 })
                    sum += number;
                var values = new[] { sum }.Select(number => number + offset).ToArray();
                return values[0];
            });
            offset = 100;
            Assert.Equal(9, Evaluate(Input(action)).Value<int>());
        }

        [Fact]
        public void SnapshotsPrecedeLaterArgumentEvaluationAndNamesResolveLate()
        {
            var suffix = "!";
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "hello");
            var action = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => previous.Output + suffix == "hello!",
                trueBranch: () =>
                {
                    suffix = "?";
                    return WorkflowActions.BuiltIn.Compose(() => "yes");
                },
                falseBranch: () => WorkflowActions.BuiltIn.Compose(() => "no"));
            previous.WithName("LateName");
            var definition = action.GetActionDefinition("flow");
            Assert.True(Evaluate(definition.Expression.Value<string>(), JObject.Parse("""{"LateName":"hello"}""")).Value<bool>());
        }

        [Fact]
        public void CapturedCollectionsAreRestoredOncePerEvaluation()
        {
            var values = new List<int> { 1 };
            var action = WorkflowActions.BuiltIn.Compose(() =>
            {
                values.Add(2);
                return values.Count;
            });
            values.Add(99);
            Assert.Equal(2, Evaluate(Input(action)).Value<int>());
            Assert.Equal(2, Evaluate(Input(action)).Value<int>());
        }

        [Fact]
        public void ScalarsRetainTheirTypes()
        {
            var id = Guid.Parse("00000000-0000-0000-0000-000000000001");
            var date = new DateTime(2026, 10, 3, 1, 0, 0, DateTimeKind.Utc);
            var uri = new Uri("https://example.com/a");
            var action = WorkflowActions.BuiltIn.Compose(() => id.ToString("N") + date.Kind + uri.Host);
            Assert.Equal("00000000000000000000000000000001Utcexample.com", Evaluate(Input(action)).Value<string>());
        }

        [Fact]
        public void TargetTypedNewAndImplicitReturnConversionsArePreserved()
        {
            var action = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(() => new() { MessageId = "id" });
            Assert.Equal("id", Evaluate(Input(action)).Value<string>("messageId"));
            var wide = WorkflowActions.BuiltIn.Compose<long>(() => DateTime.UtcNow.Year);
            Assert.Equal(JTokenType.Integer, Evaluate(Input(wide)).Type);
            var nullAction = WorkflowActions.BuiltIn.Compose<object>(() => null);
            Assert.Equal(JTokenType.Null, ((JToken)nullAction.GetActionDefinition("flow").Inputs).Type);
        }

        [Fact]
        public void QualifiedTypesInsideInterpolationAndCapturedVariableNamesWork()
        {
            var action = WorkflowActions.BuiltIn.Compose(() => $"{Guid.Empty}");
            Assert.Equal(Guid.Empty.ToString(), Evaluate(Input(action)).Value<string>());
            var name = "variable";
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => name, value: () => 2);
            Assert.Equal(name, variable.VariableName);
        }

        [Fact]
        public void AllFactoriesHaveTypedEntryPoints()
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
        public void DecimalConstantsAndEscapedCaptureNamesArePreserved()
        {
            var literal = WorkflowActions.BuiltIn.Compose(() => 0.1234567890123456789012345678m);
            Assert.Equal(0.1234567890123456789012345678m, ((JToken)literal.GetActionDefinition("flow").Inputs).Value<decimal>());
            var @event = "capture";
            var action = WorkflowActions.BuiltIn.Compose(() => @event.ToUpperInvariant());
            Assert.Equal("CAPTURE", Evaluate(Input(action)).Value<string>());
        }

        [Fact]
        public void CapturedAndRuntimeBinaryValuesUseTheSameEnvelope()
        {
            var bytes = new byte[] { 1, 2, 3 };
            var captured = WorkflowActions.BuiltIn.Compose(() => bytes);
            var runtime = WorkflowActions.BuiltIn.Compose(() => new byte[] { 1, 2, 3 });
            Assert.True(JToken.DeepEquals((JToken)captured.GetActionDefinition("flow").Inputs, Evaluate(Input(runtime))));
        }

        [Fact]
        public void NativeSdkTypeCollectionsAndDefaultsExecuteInRoslyn()
        {
            var action = WorkflowActions.BuiltIn.Compose(() =>
                new List<Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai.GetChatCompletionsInputMessagesTypeItem>
                {
                    new() { Content = "hello" },
                }.Select(message => message.Role.ToString() + message.Content).ToArray());
            Assert.Equal("Userhello", Evaluate(Input(action))[0].Value<string>());
        }

        [Fact]
        public void RuntimeHeaderDictionaryIsNotEvaluatedDuringAuthoring()
        {
            var previous = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
            var response = WorkflowActions.BuiltIn.Response(
                headers: () => previous.Output
                    ? new Dictionary<string, string> { ["X"] = "yes" }
                    : new Dictionary<string, string> { ["X"] = "no" });
            var inputs = JObject.FromObject(response.GetActionDefinition("flow").Inputs);
            Assert.Equal("yes", Evaluate(inputs["Headers"]?.Value<string>() ?? inputs["headers"].Value<string>(),
                JObject.Parse("""{"Flag":true}""")).Value<string>("X"));
        }

        [Fact]
        public void EncodedConnectorPathsRemainSingleExpressions()
        {
            var site = "https://example.com";
            var action = WorkflowActions.Managed.Sharepointonline("sharepoint").GetItems(
                dataset: () => site,
                table: () => { var table = "a/b"; return table; });
            var inputs = JObject.FromObject(action.GetActionDefinition("flow").Inputs);
            var path = inputs["Path"]?.Value<string>() ?? inputs["path"].Value<string>();
            Assert.Equal("/datasets/https%253A%252F%252Fexample.com/tables/a%252Fb/items", Evaluate(path).Value<string>());
        }

        [Fact]
        public void DefinitionsAreSnapshotsAndRawDelegatesFail()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "value").WithName("First");
            var action = WorkflowActions.BuiltIn.Compose(() => previous.Output.ToUpperInvariant());
            var first = Input(action);
            previous.WithName("Second");
            Assert.Contains("First", first);
            Assert.Contains("Second", Input(action));
            var method = typeof(WorkflowBuiltInActions).GetMethods().Single(candidate => candidate.Name == "Compose" && !candidate.IsGenericMethod);
            var error = Assert.Throws<TargetInvocationException>(() => method.Invoke(WorkflowActions.BuiltIn, new object[] { (Func<string>)(() => throw new Exception("Must not run")) }));
            Assert.IsType<NotSupportedException>(error.InnerException);
        }

        [Theory]
        [InlineData("() => CustomerHelper.Read()", "public static class CustomerHelper { public static int Read() => 1; }")]
        [InlineData("async () => await System.Threading.Tasks.Task.FromResult(1)", "")]
        public void UnsupportedDependenciesFailDuringSourceCompilation(string lambda, string declarations)
        {
            var source = $"using Microsoft.Azure.Workflows.Sdk; public static class Workflow {{ public static void Build() {{ WorkflowActions.BuiltIn.Compose({lambda}); }} }} {declarations}";
            var compilation = CSharpCompilation.Create("Consumer", new[] { CSharpSyntaxTree.ParseText(source, path: "Consumer.cs") },
                References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            var result = ExpressionCompiler.Transform(compilation);
            Assert.Contains(result.Diagnostics, diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        }

        private static string Input(IWorkflowAction action) => ((JToken)action.GetActionDefinition("flow").Inputs).Value<string>();

        private static IEnumerable<MetadataReference> References() =>
            ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")).Split(Path.PathSeparator)
                .Append(typeof(WorkflowValue).Assembly.Location)
                .Append(typeof(JToken).Assembly.Location)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Select(path => MetadataReference.CreateFromFile(path));

        private static JToken Evaluate(string expression, JObject values = null)
        {
            Assert.StartsWith("#{", expression);
            var source = $$"""
                using System;
                using System.Linq;
                using System.Collections.Generic;
                using Newtonsoft.Json.Linq;
                public static class Evaluation
                {
                    public static object Run(JObject values)
                    {
                        JToken outputs(string name) => values[name];
                        JToken body(string name) => values[name];
                        string encodeURIComponent(object value) => Uri.EscapeDataString(Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture));
                        return {{expression.Substring(2, expression.Length - 3)}};
                    }
                }
                """;
            var compilation = CSharpCompilation.Create("Expression_" + Guid.NewGuid().ToString("N"),
                new[] { CSharpSyntaxTree.ParseText(source) }, References(), new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            using var stream = new MemoryStream();
            var result = compilation.Emit(stream);
            Assert.True(result.Success, string.Join(Environment.NewLine, result.Diagnostics) + Environment.NewLine + source);
            var assembly = Assembly.Load(stream.ToArray());
            try
            {
                return JToken.FromObject(assembly.GetType("Evaluation").GetMethod("Run").Invoke(null, new object[] { values ?? new JObject() }));
            }
            catch (TargetInvocationException error) when (error.InnerException != null)
            {
                ExceptionDispatchInfo.Capture(error.InnerException).Throw();
                throw;
            }
        }
    }
}
