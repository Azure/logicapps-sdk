// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abortionpolicyapiip;
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures;
    using Newtonsoft.Json.Linq;

    [CollectionDefinition("Runtime-dependent expressions", DisableParallelization = true)]
    public class RuntimeDependentExpressionCollection
    {
    }

    [Collection("Runtime-dependent expressions")]
    public class RuntimeSourceSerializationTests : IDisposable
    {
        public RuntimeSourceSerializationTests() => RuntimeValues.Reset();

        public void Dispose() => RuntimeValues.Reset();

        [Fact]
        public void StaticGetter_IsDeferredAndObservesChangesAfterSerialization()
        {
            var action = WorkflowActions.BuiltIn.Compose(
                () => RuntimeValues.CurrentText.ToUpperInvariant());
            var expression = Input(action).Value<string>();

            Assert.Equal(0, RuntimeValues.GetterCalls);
            Assert.Contains("RuntimeValues.CurrentText.ToUpperInvariant()", expression);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.Text = "first";
            Assert.Equal("FIRST", compiled.Evaluate());
            RuntimeValues.Text = "second";
            Assert.Equal("SECOND", compiled.Evaluate());
            Assert.Equal(2, RuntimeValues.GetterCalls);
        }

        [Fact]
        public void StaticGetterWithoutNativeSibling_IsStillDeferred()
        {
            var action = WorkflowActions.BuiltIn.Compose(() => RuntimeValues.CurrentText);
            var expression = Input(action).Value<string>();

            Assert.Equal(0, RuntimeValues.GetterCalls);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.Text = "after";
            Assert.Equal("after", compiled.Evaluate());
            Assert.Equal(1, RuntimeValues.GetterCalls);
        }

        [Fact]
        public void StaticField_ObservesChangesAfterSerialization()
        {
            var action = WorkflowActions.BuiltIn.Compose(() => RuntimeValues.Text.ToUpperInvariant());
            using var compiled = EmittedExpressionCompiler.Compile(Input(action).Value<string>());
            RuntimeValues.Text = "after";

            Assert.Equal("AFTER", compiled.Evaluate());
        }

        [Fact]
        public void BoxedNativeCall_IsNotExecutedDuringDefinitionGeneration()
        {
            var action = WorkflowActions.BuiltIn.Compose<object>(() => RuntimeValues.NextNumber());
            var expression = Input(action).Value<string>();

            Assert.Equal(0, RuntimeValues.NumberCalls);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal(1, Assert.IsType<int>(compiled.Evaluate()));
            Assert.Equal(2, Assert.IsType<int>(compiled.Evaluate()));
            Assert.Equal(2, RuntimeValues.NumberCalls);
        }

        [Fact]
        public void EnumConditional_UsesBothRuntimeBranchesAndWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = WorkflowActions.BuiltIn.Compose<WireChoice>(
                () => flag.Output ? WireChoice.First : WireChoice.Second);
            var expression = Input(action).Value<string>();

            Assert.Equal("#{outputs(\"Flag\").ToObject<bool>() ? \"first /+\" : \"second\"}", expression);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("first /+", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("second", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void EnumProducingMethod_IsEvaluatedOncePerRuntimeCall()
        {
            var action = WorkflowActions.BuiltIn.Compose<WireChoice>(() => RuntimeValues.NextChoice());
            var expression = Input(action).Value<string>();

            Assert.Equal(0, RuntimeValues.EnumCalls);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.Choice = WireChoice.First;
            Assert.Equal("first /+", compiled.Evaluate());
            RuntimeValues.Choice = WireChoice.Second;
            Assert.Equal("second", compiled.Evaluate());
            Assert.Equal(2, RuntimeValues.EnumCalls);
        }

        [Fact]
        public void GeneratedEnumQuery_PreservesWorkflowDependencyAndWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = new AbbreviationsipActions("connection").AbbrGet(
                term: () => "term",
                sortby: () => flag.Output ? sortbyInput.Popularity : sortbyInput.Alphabetically);

            using var compiled = EmittedExpressionCompiler.Compile(Input(action)["queries"]["sortby"].Value<string>());
            Assert.Equal("p", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("a", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void GeneratedEnumPath_PreservesWorkflowDependencyAndEncoding()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = new AbortionpolicyapiipActions("connection").GetGestationalLimitsbyState(
                state: () => flag.Output ? stateInput.Alabama : stateInput.Alaska);

            using var compiled = EmittedExpressionCompiler.Compile(Input(action)["path"].Value<string>());
            Assert.Equal("/v1/gestational_limits/states/Alabama",
                compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("/v1/gestational_limits/states/Alaska",
                compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void GeneratedEnumPath_MapsAndEncodesRuntimeMethodExactlyOnce()
        {
            var action = new AbortionpolicyapiipActions("connection").GetGestationalLimitsbyState(
                state: () => RuntimeValues.NextState());
            var expression = Input(action)["path"].Value<string>();

            Assert.Equal(0, RuntimeValues.EnumCalls);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.State = stateInput.NewYork;
            Assert.Equal("/v1/gestational_limits/states/New%20York", compiled.Evaluate());
            RuntimeValues.State = stateInput.NewJersey;
            Assert.Equal("/v1/gestational_limits/states/New%20Jersey", compiled.Evaluate());
            Assert.Equal(2, RuntimeValues.EnumCalls);
        }

        [Fact]
        public void ServiceProviderEnumParameter_PreservesWorkflowDependencyAndWireValues()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var action = WorkflowActions.ServiceProviders.KeyVault("connection").EncryptDataWithKey(
                keyName: () => "key",
                algorithm: () => flag.Output
                    ? ServiceProviders.KeyVault.EncryptDataWithKeyInputAlgorithmType.RSAOAEP
                    : ServiceProviders.KeyVault.EncryptDataWithKeyInputAlgorithmType.RSAOAEP256,
                rawData: () => "payload");

            using var compiled = EmittedExpressionCompiler.Compile(Input(action)["parameters"]["algorithm"].Value<string>());
            Assert.Equal("RSA-OAEP", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true }));
            Assert.Equal("RSA-OAEP-256", compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false }));
        }

        [Fact]
        public void CapturedAutoProperty_IsFrozenAtActionConstruction()
        {
            var model = new CapturedAutoModel { TriggerOutput = new CapturedAutoLeaf { Body = "value" } };
            var action = WorkflowActions.BuiltIn.Compose(() => model.TriggerOutput.Body.ToUpperInvariant());
            model.TriggerOutput.Body = "changed";
            var expression = Input(action).Value<string>();

            Assert.Equal("#{\"value\".ToUpperInvariant()}", expression);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void CapturedFieldChain_IsFrozenAtActionConstruction()
        {
            var model = new CapturedFieldModel { Child = new CapturedFieldLeaf { Text = "value" } };
            var action = WorkflowActions.BuiltIn.Compose(() => model.Child.Text.ToUpperInvariant());
            model.Child.Text = "changed";

            using var compiled = EmittedExpressionCompiler.Compile(Input(action).Value<string>());
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        [Fact]
        public void CapturedAutoPropertyWithoutNativeOperation_RemainsLiteral()
        {
            var model = new CapturedAutoModel { TriggerOutput = new CapturedAutoLeaf { Body = "value" } };
            var action = WorkflowActions.BuiltIn.Compose(() => model.TriggerOutput.Body);
            model.TriggerOutput.Body = "changed";

            Assert.Equal("value", Input(action).Value<string>());
        }

        private static JToken Input(IWorkflowAction action) =>
            JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"];
    }
}
