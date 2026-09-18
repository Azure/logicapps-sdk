// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Linq.Expressions;
    using System.Net.Http;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abortionpolicyapiip;
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures;
    using Newtonsoft.Json.Linq;

    [CollectionDefinition("Runtime-dependent expressions", DisableParallelization = true)]
    public class RuntimeDependentExpressionCollection
    {
    }

    [Collection("Runtime-dependent expressions")]
    public class RuntimeDependentExpressionTests : IDisposable
    {
        public RuntimeDependentExpressionTests()
        {
            RuntimeValues.Reset();
        }

        public void Dispose()
        {
            RuntimeValues.Reset();
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StaticUtcNow_RemainsRuntimeMember(bool token)
        {
            Expression<Func<DateTime>> input = () => DateTime.UtcNow;
            var expression = token
                ? CSharpExpressionConverter.ConvertToken(input).Value<string>()
                : CSharpExpressionConverter.ConvertO(input);

            Assert.Contains("DateTime.UtcNow", expression);
            Assert.DoesNotContain("DateTime.Parse", expression);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.IsType<DateTime>(compiled.Evaluate());
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public void StaticGetter_IsNotInvokedDuringGeneration(bool token, bool nativeSibling)
        {
            Expression<Func<string>> input = nativeSibling
                ? () => RuntimeValues.CurrentText.ToUpperInvariant()
                : () => RuntimeValues.CurrentText;
            var expression = token
                ? CSharpExpressionConverter.ConvertToken(input).Value<string>()
                : CSharpExpressionConverter.ConvertO(input);

            Assert.True(RuntimeValues.GetterCalls == 0,
                $"Generation invoked the getter {RuntimeValues.GetterCalls} time(s). Output: {expression}");
        }

        [Fact]
        public void StaticGetter_CompiledExpressionObservesChangesAfterGeneration()
        {
            var expression = CSharpExpressionConverter.ConvertO(
                () => RuntimeValues.CurrentText.ToUpperInvariant());
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.GetterCalls = 0;

            RuntimeValues.Text = "first";
            var first = compiled.Evaluate();
            RuntimeValues.Text = "second";
            var second = compiled.Evaluate();

            Assert.Equal("FIRST", first);
            Assert.Equal("SECOND", second);
            Assert.Equal(2, RuntimeValues.GetterCalls);
        }

        [Fact]
        public void StaticField_CompiledExpressionObservesChangesAfterGeneration()
        {
            var expression = CSharpExpressionConverter.ConvertO(
                () => RuntimeValues.Text.ToUpperInvariant());
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.Text = "after";

            Assert.Equal("AFTER", compiled.Evaluate());
        }

        [Fact]
        public void StaticLiteralControls_RetainExistingSerialization()
        {
            Assert.Equal("constant", CSharpExpressionConverter.ConvertO(() => RuntimeValues.ConstantText));
            Assert.Equal("GET", CSharpExpressionConverter.ConvertO(() => HttpMethod.Get));
            Assert.Equal("\"GET\"", CSharpExpressionConverter.ConvertCSharp(() => HttpMethod.Get));
        }

        [Fact]
        public void EnumConditional_ScalarRetainsTemplateWorkflowDependency()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");

            var expression = CSharpExpressionConverter.Convert(
                () => flag.Output ? WireChoice.First : WireChoice.Second);

            Assert.Equal("@if(outputs('Flag'), 'first /+', 'second')", expression);
        }

        [Fact]
        public void EnumConditional_TokenRetainsTemplateWorkflowDependency()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");

            var token = CSharpExpressionConverter.ConvertToken(
                () => flag.Output ? WireChoice.First : WireChoice.Second);

            Assert.Equal(JTokenType.String, token.Type);
            Assert.Equal("@if(outputs('Flag'), 'first /+', 'second')", token.Value<string>());
        }

        [Fact]
        public void EnumConditional_TokenPreservesPredicateWithoutGenerationExecution()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var token = CSharpExpressionConverter.ConvertToken(
                () => flag.Output ? WireChoice.First : WireChoice.Second);

            Assert.StartsWith("@if(outputs('Flag'),", token.Value<string>());
        }

        [Fact]
        public void EnumConditional_TokenReturnsWireStringWhenEmittedTypesAreResolvable()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var expression = CSharpExpressionConverter.ConvertToken(
                () => flag.Output.ToString() == "True" ? DayOfWeek.Monday : DayOfWeek.Friday).Value<string>();

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("Monday", Assert.IsType<string>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Flag"] = true })));
            Assert.Equal("Friday", Assert.IsType<string>(compiled.Evaluate(
                new Dictionary<string, JToken> { ["Flag"] = false })));
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void EnumConditional_CSharpUsesBothRuntimeBranchesAndWireValues(bool token)
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            Expression<Func<WireChoice>> input =
                () => flag.Output.ToString() == "True" ? WireChoice.First : WireChoice.Second;
            var expression = token
                ? CSharpExpressionConverter.ConvertToken(input).Value<string>()
                : CSharpExpressionConverter.Convert(input);

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("first /+", compiled.Evaluate(
                new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("second", compiled.Evaluate(
                new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Theory]
        [InlineData("scalar")]
        [InlineData("token")]
        [InlineData("url")]
        [InlineData("path")]
        public void EnumProducingMethod_IsNotInvokedDuringGeneration(string surface)
        {
            var expression = ConvertEnum(() => RuntimeValues.NextChoice(), surface);

            Assert.True(RuntimeValues.EnumCalls == 0,
                $"{surface} generation invoked the enum method {RuntimeValues.EnumCalls} time(s). Output: {expression}");
        }

        [Theory]
        [InlineData("scalar", "first /+", "second")]
        [InlineData("token", "first /+", "second")]
        [InlineData("url", "first%20%2F%2B", "second")]
        [InlineData("path", "/states/first%20%2F%2B", "/states/second")]
        public void EnumProducingMethod_IsEvaluatedOncePerRuntimeCall(
            string surface,
            string expectedFirst,
            string expectedSecond)
        {
            var expression = ConvertEnum(() => RuntimeValues.NextChoice(), surface);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.EnumCalls = 0;

            RuntimeValues.Choice = WireChoice.First;
            var first = compiled.Evaluate();
            RuntimeValues.Choice = WireChoice.Second;
            var second = compiled.Evaluate();

            Assert.Equal(expectedFirst, first);
            Assert.Equal(expectedSecond, second);
            Assert.Equal(2, RuntimeValues.EnumCalls);
        }

        [Theory]
        [InlineData(1, "/PREFIX/first%20%2F%2B")]
        [InlineData(2, "/PREFIX/first%2520%252F%252B")]
        public void RuntimeEnumMixedPath_IsOneExpressionWithCorrectEncoding(int times, string expected)
        {
            var expression = CSharpExpressionConverter.ConvertGeneratedPath(
                "/{0}/{1}",
                CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(
                    () => "prefix".ToUpperInvariant(), 1),
                CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(
                    () => RuntimeValues.NextChoice(), times));
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.EnumCalls = 0;
            RuntimeValues.Choice = WireChoice.First;

            Assert.Equal(expected, compiled.Evaluate());
            Assert.Equal(1, RuntimeValues.EnumCalls);
        }

        [Fact]
        public void GeneratedEnumQuery_PreservesWorkflowDependencyAndWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = new AbbreviationsipActions("connection").AbbrGet(
                term: () => "term",
                sortby: () => flag.Output ? sortbyInput.Popularity : sortbyInput.Alphabetically);
            var json = JObject.Parse(action.GetActionDefinition("workflow").ToJson());

            using var compiled = EmittedExpressionCompiler.Compile(json["inputs"]["queries"]["sortby"].Value<string>());
            Assert.Equal("p", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("a", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void GeneratedEnumPath_PreservesWorkflowDependencyAndEncoding()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = new AbortionpolicyapiipActions("connection").GetGestationalLimitsbyState(
                state: () => flag.Output ? stateInput.Alabama : stateInput.Alaska);
            var json = JObject.Parse(action.GetActionDefinition("workflow").ToJson());

            using var compiled = EmittedExpressionCompiler.Compile(json["inputs"]["path"].Value<string>());
            Assert.Equal("/v1/gestational_limits/states/Alabama",
                compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("/v1/gestational_limits/states/Alaska",
                compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void ServiceProviderEnumParameter_RetainsWorkflowDependencyAndWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = WorkflowActions.ServiceProviders.KeyVault("connection").EncryptDataWithKey(
                keyName: () => "key",
                algorithm: () => flag.Output
                    ? ServiceProviders.KeyVault.EncryptDataWithKeyInputAlgorithmType.RSAOAEP
                    : ServiceProviders.KeyVault.EncryptDataWithKeyInputAlgorithmType.RSAOAEP256,
                rawData: () => "payload");
            var json = JObject.Parse(action.GetActionDefinition("workflow").ToJson());

            using var compiled = EmittedExpressionCompiler.Compile(json["inputs"]["parameters"]["algorithm"].Value<string>());
            Assert.Equal("RSA-OAEP", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("RSA-OAEP-256", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void EnumConstantControls_PreserveWireValuesAndEncoding()
        {
            var captured = WireChoice.First;
            Assert.Equal("first /+", CSharpExpressionConverter.Convert(() => captured));
            Assert.Equal("second", CSharpExpressionConverter.Convert(() => WireChoice.Second));
            Assert.Equal("Unannotated", CSharpExpressionConverter.Convert(() => WireChoice.Unannotated));
            Assert.Equal("99", CSharpExpressionConverter.Convert(() => (WireChoice)99));
            Assert.Equal(
                "@{encodeURIComponent(encodeURIComponent('first /+'))}",
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => captured, 2));
        }

        [Fact]
        public void CapturedAutoPropertyChain_EmitsValidCSharp()
        {
            var model = CreateAutoModel();
            var expression = CSharpExpressionConverter.ConvertO(
                () => model.TriggerOutput.Body.ToUpperInvariant());

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void CapturedFieldChain_EmitsValidCSharp()
        {
            var model = new CapturedFieldModel { Child = new CapturedFieldLeaf { Text = "value" } };
            var expression = CSharpExpressionConverter.ConvertO(
                () => model.Child.Text.ToUpperInvariant());

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void CapturedAutoPropertyChain_PreservesGenerationSnapshot()
        {
            var model = CreateAutoModel();
            var expression = CSharpExpressionConverter.ConvertO(
                () => model.TriggerOutput.Body.ToUpperInvariant());
            model.TriggerOutput.Body = "changed";

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void CapturedFieldChain_PreservesGenerationSnapshot()
        {
            var model = new CapturedFieldModel { Child = new CapturedFieldLeaf { Text = "value" } };
            var expression = CSharpExpressionConverter.ConvertO(
                () => model.Child.Text.ToUpperInvariant());
            model.Child.Text = "changed";

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void CapturedAutoPropertyWithoutNativeOperation_RemainsLiteral(bool token)
        {
            var model = CreateAutoModel();
            var expression = token
                ? CSharpExpressionConverter.ConvertToken(() => model.TriggerOutput.Body).Value<string>()
                : CSharpExpressionConverter.ConvertO(() => model.TriggerOutput.Body);

            Assert.Equal("value", expression);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void CapturedCustomGetter_IsRejectedWithoutInvokingUserCode(bool nativeSibling)
        {
            var model = new CapturedCustomGetter();
            Expression<Func<string>> input = nativeSibling
                ? () => model.Text.ToUpperInvariant()
                : () => model.Text;

            var error = Record.Exception(() => CSharpExpressionConverter.ConvertO(input));

            Assert.True(model.GetterCalls == 0 && model.ToStringCalls == 0,
                $"Getter calls: {model.GetterCalls}; ToString calls: {model.ToStringCalls}; error: {error}");
            var unsupported = Assert.IsType<NotSupportedException>(error);
            Assert.Contains(nameof(CapturedCustomGetter.Text), unsupported.Message);
        }

        [Fact]
        public void CapturedPrimitiveControls_RetainLiteralAndSnapshotBehavior()
        {
            var value = "value";
            Assert.Equal("value", CSharpExpressionConverter.ConvertO(() => value));
            var expression = CSharpExpressionConverter.ConvertO(() => value.ToUpperInvariant());
            value = "changed";

            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void WorkflowReferenceControls_RemainSymbolic()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "placeholder").WithName("Source");
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            Assert.Equal("@outputs('Source')", CSharpExpressionConverter.ConvertO(() => source.Output));
            Assert.Equal("@triggerBody()", CSharpExpressionConverter.ConvertToken(() => trigger.TriggerOutput.Body).Value<string>());

            var expression = CSharpExpressionConverter.ConvertO(() => source.Output.ToUpperInvariant());
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("RUNTIME", compiled.Evaluate(
                new Dictionary<string, JToken> { ["Source"] = "runtime" }));
        }

        private static CapturedAutoModel CreateAutoModel() =>
            new() { TriggerOutput = new CapturedAutoLeaf { Body = "value" } };

        private static string ConvertEnum(Expression<Func<WireChoice>> expression, string surface) =>
            surface switch
            {
                "scalar" => CSharpExpressionConverter.Convert(expression),
                "token" => CSharpExpressionConverter.ConvertToken(expression).Value<string>(),
                "url" => CSharpExpressionConverter.ConvertWithUrlEncoding(expression, 1),
                "path" => CSharpExpressionConverter.ConvertGeneratedPath(
                    "/states/{0}",
                    CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(expression, 1)),
                _ => throw new ArgumentOutOfRangeException(nameof(surface)),
            };
    }
}
