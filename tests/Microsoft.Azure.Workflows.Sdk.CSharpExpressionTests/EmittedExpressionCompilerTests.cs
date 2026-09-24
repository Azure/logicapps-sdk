// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures;
    using Newtonsoft.Json.Linq;
    using Xunit.Sdk;

    [Collection("Runtime-dependent expressions")]
    public class EmittedExpressionCompilerTests
    {
        [Fact]
        public void LiteralExpression_CompilesAndEvaluates()
        {
            using var compiled = EmittedExpressionCompiler.Compile("#{\"value\".ToUpperInvariant()}");
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void WorkflowAndEncodingGlobals_UseRuntimeInputs()
        {
            using var compiled = EmittedExpressionCompiler.Compile(
                "#{encodeURIComponent(outputs(\"Name\").ToObject<string>())}");
            Assert.Equal("a%20b%2F%2B", compiled.Evaluate(
                new Dictionary<string, JToken> { ["Name"] = "a b/+" }));
        }

        [Fact]
        public void QualifiedFixtureReference_CompilesWithoutFixtureNamespaceImport()
        {
            using var compiled = EmittedExpressionCompiler.Compile(
                "#{global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures.RuntimeValues.ConstantText}");
            Assert.Equal("constant", compiled.Evaluate());
        }

        [Fact]
        public void QualifiedRuntimeFixture_SharesHostStateAndInvokesGetterAtEvaluation()
        {
            RuntimeValues.Reset();
            try
            {
                using var compiled = EmittedExpressionCompiler.Compile(
                    "#{global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures.RuntimeValues.CurrentText}");
                Assert.Equal(0, RuntimeValues.GetterCalls);
                RuntimeValues.Text = "first";
                Assert.Equal("first", compiled.Evaluate());
                RuntimeValues.Text = "second";
                Assert.Equal("second", compiled.Evaluate());
                Assert.Equal(2, RuntimeValues.GetterCalls);
            }
            finally
            {
                RuntimeValues.Reset();
            }
        }

        [Fact]
        public void InvalidSource_ReportsDiagnosticsAndSource()
        {
            var error = Assert.Throws<XunitException>(() =>
                EmittedExpressionCompiler.Compile("#{MissingInstance.Text}"));
            Assert.Contains("CS0103", error.Message);
            Assert.Contains("Source:", error.Message);
            Assert.Contains("MissingInstance.Text", error.Message);
        }

        [Fact]
        public void TemplateExpression_IsNotTreatedAsCSharp()
        {
            Assert.Throws<XunitException>(() =>
                EmittedExpressionCompiler.Compile("@outputs('Name')"));
        }

        [Fact]
        public void DisposedCompilation_CannotBeExecuted()
        {
            var compiled = EmittedExpressionCompiler.Compile("#{42}");
            compiled.Dispose();
            Assert.Throws<ObjectDisposedException>(() => compiled.Evaluate());
        }
    }
}
