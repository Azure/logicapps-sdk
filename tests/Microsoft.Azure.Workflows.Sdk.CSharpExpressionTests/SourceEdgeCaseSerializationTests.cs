// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Newtonsoft.Json.Linq;

    public class SourceEdgeCaseSerializationTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("say \"hello\"")]
        [InlineData("C:\\path\\to\\file")]
        [InlineData("line1\nline2")]
        [InlineData("col1\tcol2\0")]
        [InlineData("literal triggerOutputs()?['Body']")]
        public void CapturedStrings_RoundTripActionJsonWithoutBecomingCode(string value)
        {
            var action = WorkflowActions.BuiltIn.Compose(() => value);

            var input = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"];

            Assert.Equal(JTokenType.String, input.Type);
            Assert.Equal(value, input.Value<string>());
        }

        [Fact]
        public void InterpolatedControlCharacters_RoundTripSourceAndRuntime()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var action = WorkflowActions.BuiltIn.Compose(() => $"line1\n{source.Output}\t\0");
            var input = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"].Value<string>();

            Assert.Equal("#{$\"line1\\n{outputs(\"Source\").ToObject<string>()}\\t\\0\"}", input);
            using var compiled = EmittedExpressionCompiler.Compile(input);
            Assert.Equal("line1\nvalue\t\0", compiled.Evaluate(
                new Dictionary<string, JToken> { ["Source"] = "value" }));
        }

        [Fact]
        public void WorkflowLookingStringReceiver_IsAnOrdinaryNativeValue()
        {
            var text = "outputs(x)";
            var action = WorkflowActions.BuiltIn.Compose<int>(() => text.Length);
            var input = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"].Value<string>();

            Assert.Equal("#{\"outputs(x)\".Length}", input);
            using var compiled = EmittedExpressionCompiler.Compile(input);
            Assert.Equal(10, compiled.Evaluate());
        }

        [Fact]
        public void CapturedNullComparison_PreservesNativeNullSemantics()
        {
            string text = null;
            var action = WorkflowActions.BuiltIn.Compose<bool>(() => text == "x");
            var input = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"].Value<string>();

            using var compiled = EmittedExpressionCompiler.Compile(input);
            Assert.False(Assert.IsType<bool>(compiled.Evaluate()));
        }

        [Fact]
        public void OptionalResponseBody_DistinguishesOmissionFromExplicitNull()
        {
            var omitted = WorkflowActions.BuiltIn.Response(responseBody: null);
            var explicitNull = WorkflowActions.BuiltIn.Response(responseBody: () => null);
            var omittedInputs = JObject.Parse(omitted.GetActionDefinition("workflow").ToJson())["inputs"];
            var nullInputs = JObject.Parse(explicitNull.GetActionDefinition("workflow").ToJson())["inputs"];

            Assert.Null(omittedInputs["body"]);
            Assert.Equal(JTokenType.Null, nullInputs["body"].Type);
        }

        [Fact]
        public void BoxedNumericCast_IsNotLostAtTheJsonBoundary()
        {
            double value = 2.75;
            var action = WorkflowActions.BuiltIn.Compose<object>(() => (int)value);
            var input = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"];

            using var compiled = EmittedExpressionCompiler.Compile(input.Value<string>());
            Assert.Equal(2, Assert.IsType<int>(compiled.Evaluate()));
        }
    }
}
