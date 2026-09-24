// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Newtonsoft.Json.Linq;

    public class NativeMethodSerializationTests
    {
        [Fact]
        public void StringPredicates_PreserveNativeMethodsAndBooleanResult()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var action = WorkflowActions.BuiltIn.Compose<bool>(
                () => source.Output.Contains("ell") &&
                    source.Output.StartsWith("he") && source.Output.EndsWith("lo"));

            using var compiled = CompileInput(action);
            Assert.True(Assert.IsType<bool>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Source"] = "hello" })));
            Assert.False(Assert.IsType<bool>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Source"] = "world" })));
        }

        [Fact]
        public void MathMax_PreservesRuntimeIntegerArguments()
        {
            var source = WorkflowActions.BuiltIn.Compose<int>(() => 0).WithName("Count");
            var action = WorkflowActions.BuiltIn.Compose<int>(() => Math.Max(source.Output, 7));

            using var compiled = CompileInput(action);
            Assert.Equal(7, compiled.Evaluate(new Dictionary<string, JToken> { ["Count"] = 3 }));
            Assert.Equal(9, compiled.Evaluate(new Dictionary<string, JToken> { ["Count"] = 9 }));
        }

        [Fact]
        public void MathPow_PreservesRuntimeDoubleArguments()
        {
            var source = WorkflowActions.BuiltIn.Compose<double>(() => 0).WithName("Exponent");
            var action = WorkflowActions.BuiltIn.Compose<double>(() => Math.Pow(2, source.Output));

            using var compiled = CompileInput(action);
            Assert.Equal(1024d, compiled.Evaluate(new Dictionary<string, JToken> { ["Exponent"] = 10 }));
        }

        [Fact]
        public void LinqMax_PreservesArrayAndIntegerResult()
        {
            var action = WorkflowActions.BuiltIn.Compose<int>(() => new[] { 3, 1, 2 }.Max());

            using var compiled = CompileInput(action);
            Assert.Equal(3, compiled.Evaluate());
        }

        [Fact]
        public void StaticGenericMethod_PreservesTypeArguments()
        {
            var action = WorkflowActions.BuiltIn.Compose<IEnumerable<int>>(() => Enumerable.Empty<int>());

            using var compiled = CompileInput(action);
            Assert.Empty(Assert.IsAssignableFrom<IEnumerable<int>>(compiled.Evaluate()));
        }

        [Fact]
        public void StringConcatAndFormat_PreserveArrayOverloads()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var concatenation = WorkflowActions.BuiltIn.Compose(
                () => string.Concat(new[] { "a", source.Output, "c" }));
            var formatting = WorkflowActions.BuiltIn.Compose(
                () => string.Format("{0}{1}{2}", new object[] { "a", source.Output, "c" }));

            using var concat = CompileInput(concatenation);
            using var format = CompileInput(formatting);
            var values = new Dictionary<string, JToken> { ["Source"] = "b" };
            Assert.Equal("abc", concat.Evaluate(values));
            Assert.Equal("abc", format.Evaluate(values));
        }

        [Fact]
        public void DateTimeInput_PreservesKindTicksAndNativeEquality()
        {
            var source = WorkflowActions.BuiltIn.Compose<DateTime>(() => DateTime.UtcNow).WithName("Date");
            var expected = new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            var expectedTicks = expected.Ticks;
            var action = WorkflowActions.BuiltIn.Compose<bool>(
                () => source.Output == new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc) &&
                    source.Output.Kind == DateTimeKind.Utc && source.Output.Ticks == expectedTicks);

            using var compiled = CompileInput(action);
            Assert.True(Assert.IsType<bool>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Date"] = new JValue(expected) })));
            Assert.False(Assert.IsType<bool>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Date"] = new JValue(expected.AddSeconds(1)) })));
        }

        [Fact]
        public void GuidInput_PreservesNativeEquality()
        {
            var source = WorkflowActions.BuiltIn.Compose<Guid>(() => Guid.Empty).WithName("Guid");
            var action = WorkflowActions.BuiltIn.Compose<bool>(
                () => source.Output == new Guid("16a135c5-1ec3-44b9-b91e-b9a976803736") &&
                    source.Output != Guid.Empty);

            using var compiled = CompileInput(action);
            Assert.True(Assert.IsType<bool>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Guid"] = "16a135c5-1ec3-44b9-b91e-b9a976803736" })));
            Assert.False(Assert.IsType<bool>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Guid"] = Guid.Empty.ToString() })));
        }

        private static EmittedExpressionCompiler.CompiledExpression CompileInput(IWorkflowAction action) =>
            EmittedExpressionCompiler.Compile(
                JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"].Value<string>());
    }
}
