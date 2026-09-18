// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Shows the expected conversion contract for each runtime-dependent expression category.
    /// The broader regression suite exercises the same behavior across every converter surface.
    /// </summary>
    [Collection("Runtime-dependent expressions")]
    public class RuntimeDependentConversionContractTests : IDisposable
    {
        public RuntimeDependentConversionContractTests()
        {
            RuntimeValues.Reset();
        }

        public void Dispose()
        {
            RuntimeValues.Reset();
        }

        [Fact]
        public void StaticGetter_RemainsRuntimeCSharpAndObservesCurrentValue()
        {
            var expression = CSharpExpressionConverter.ConvertO(
                () => RuntimeValues.CurrentText.ToUpperInvariant());

            Assert.Equal(
                "@csharp{Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests." +
                "RuntimeFixtures.RuntimeValues.CurrentText.ToUpperInvariant()}",
                expression);

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.Text = "first";
            Assert.Equal("FIRST", compiled.Evaluate());
            RuntimeValues.Text = "second";
            Assert.Equal("SECOND", compiled.Evaluate());
        }

        [Fact]
        public void TemplateCompatibleEnum_RemainsLogicAppsExpressionWithWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");

            var expression = CSharpExpressionConverter.Convert(
                () => flag.Output ? WireChoice.First : WireChoice.Second);

            Assert.Equal("@if(outputs('Flag'), 'first /+', 'second')", expression);
        }

        [Fact]
        public void RuntimeEnum_BecomesCSharpThatReturnsWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");

            var expression = CSharpExpressionConverter.Convert(
                () => flag.Output.ToString() == "True"
                    ? WireChoice.First
                    : WireChoice.Second);

            Assert.StartsWith("@csharp{(", expression);
            Assert.Contains("outputs(\"Flag\").ToObject<bool>()", expression);
            Assert.Contains("switch", expression);
            Assert.Contains("WireChoice.First => \"first /+\"", expression);
            Assert.Contains("WireChoice.Second => \"second\"", expression);

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal(
                "first /+",
                compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal(
                "second",
                compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void CapturedAutoProperty_IsSnapshottedBeforeNativeOperation()
        {
            var model = new CapturedAutoModel
            {
                TriggerOutput = new CapturedAutoLeaf { Body = "value" },
            };

            var expression = CSharpExpressionConverter.ConvertO(
                () => model.TriggerOutput.Body.ToUpperInvariant());
            model.TriggerOutput.Body = "changed";

            Assert.Equal("@csharp{\"value\".ToUpperInvariant()}", expression);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void CapturedAutoPropertyWithoutNativeOperation_RemainsLiteral()
        {
            var model = new CapturedAutoModel
            {
                TriggerOutput = new CapturedAutoLeaf { Body = "value" },
            };

            var expression = CSharpExpressionConverter.ConvertO(
                () => model.TriggerOutput.Body);

            Assert.Equal("value", expression);
        }

        [Fact]
        public void CapturedCustomGetter_IsRejectedWithoutExecutingUserCode()
        {
            var model = new CapturedCustomGetter();

            var error = Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertO(
                    () => model.Text.ToUpperInvariant()));

            Assert.Equal(0, model.GetterCalls);
            Assert.Equal(0, model.ToStringCalls);
            Assert.Contains(nameof(CapturedCustomGetter.Text), error.Message);
        }
    }
}
