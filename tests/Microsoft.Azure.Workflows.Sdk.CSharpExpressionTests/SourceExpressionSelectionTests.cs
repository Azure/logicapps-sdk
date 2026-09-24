// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    public class SourceExpressionSelectionTests
    {
        [Fact]
        public void Compose_WithOnlyWorkflowReference_UsesCSharpInterpolation()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Received request: {trigger.TriggerOutput.Body}");

            var definition = compose.GetActionDefinition("workflow");

            Assert.Equal(
                "#{$\"Received request: {triggerBody()}\"}",
                Assert.IsAssignableFrom<JToken>(definition.Inputs).Value<string>());
        }

        [Fact]
        public void Condition_WithNativeCSharpOperation_UsesCSharpExpression()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var condition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => trigger.TriggerOutput.Body["condition"].ToString() == "foo",
                trueBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Condition true branch"),
                falseBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Condition false branch"));

            var definition = condition.GetActionDefinition("workflow");

            Assert.Equal(
                "#{triggerBody()[\"condition\"].ToString() == \"foo\"}",
                definition.Expression?.Value<string>());
        }

        [Fact]
        public void WorkflowReferenceComparison_PreservesNativeEquality()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "foo").WithName("ComposeInput");
            var condition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => trigger.TriggerOutput.Body == compose.Output,
                trueBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Condition true branch"),
                falseBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Condition false branch"));

            var definition = condition.GetActionDefinition("workflow");

            Assert.Equal("#{triggerBody() == outputs(\"ComposeInput\")}", definition.Expression.Value<string>());
        }

        [Fact]
        public void NativeMethodOnTypedWorkflowOutput_UsesTypedCSharpValue()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "site")
                .WithName("Source");
            var action = WorkflowActions.BuiltIn.Compose(() => source.Output.ToUpper());

            Assert.Equal(
                "#{outputs(\"Source\").ToObject<string>().ToUpper()}",
                Input(action).Value<string>());
        }

        [Fact]
        public void LiteralContainingTriggerSyntax_IsNotNormalized()
        {
            const string value = "literal triggerOutputs()?['Body']";

            Assert.Equal(value, Input(WorkflowActions.BuiltIn.Compose(() => value)).Value<string>());
        }

        [Fact]
        public void TriggerReferenceAndSimilarLiteral_AreRenderedIndependently()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(
                () => $"{trigger.TriggerOutput.Body} literal triggerOutputs()?['Body']");

            Assert.Equal(
                "#{$\"{triggerBody()} literal triggerOutputs()?['Body']\"}",
                Assert.IsAssignableFrom<JToken>(
                    compose.GetActionDefinition("workflow").Inputs).Value<string>());
        }

        [Fact]
        public void NativePropertyOnTypedWorkflowOutput_UsesTypedCSharpValue()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "site")
                .WithName("Source");

            Assert.Equal(
                "#{outputs(\"Source\").ToObject<string>().Length}",
                Input(WorkflowActions.BuiltIn.Compose<int>(() => source.Output.Length)).Value<string>());
        }

        [Fact]
        public void CompositeFormat_PreservesNativeCSharp()
        {
            Assert.Equal(
                "#{string.Format(\"{0:00}\", 5)}",
                Input(WorkflowActions.BuiltIn.Compose(() => string.Format("{0:00}", 5))).Value<string>());
        }

        [Fact]
        public void ScalarComposeLiterals_PreserveJsonTokenTypes()
        {
            var integer = Assert.IsAssignableFrom<JToken>(
                WorkflowActions.BuiltIn.Compose<int>(() => 5)
                    .GetActionDefinition("workflow").Inputs);
            var boolean = Assert.IsAssignableFrom<JToken>(
                WorkflowActions.BuiltIn.Compose<bool>(() => true)
                    .GetActionDefinition("workflow").Inputs);
            var number = Assert.IsAssignableFrom<JToken>(
                WorkflowActions.BuiltIn.Compose<double>(() => 2.5)
                    .GetActionDefinition("workflow").Inputs);

            Assert.Equal(JTokenType.Integer, integer.Type);
            Assert.Equal(JTokenType.Boolean, boolean.Type);
            Assert.Equal(JTokenType.Float, number.Type);
        }

        [Fact]
        public void BoxedScalarPayloads_PreserveJsonTokenTypes()
        {
            var integer = Assert.IsAssignableFrom<JToken>(
                WorkflowActions.BuiltIn.Compose<object>(() => (object)5)
                    .GetActionDefinition("workflow").Inputs);
            var boolean = Assert.IsAssignableFrom<JToken>(
                WorkflowActions.BuiltIn.Compose<object>(() => (object)true)
                    .GetActionDefinition("workflow").Inputs);
            var number = Assert.IsAssignableFrom<JToken>(
                WorkflowActions.BuiltIn.Compose<object>(() => (object)2.5)
                    .GetActionDefinition("workflow").Inputs);

            Assert.Equal(JTokenType.Integer, integer.Type);
            Assert.Equal(JTokenType.Boolean, boolean.Type);
            Assert.Equal(JTokenType.Float, number.Type);
        }

        [Fact]
        public void ClrCollectionIndexing_UsesCSharp()
        {
            var values = new[] { "first", "second" };
            var list = new List<string> { "first", "second" };
            var dictionary = new Dictionary<string, string> { ["key"] = "value" };

            using var arrayExpression = EmittedExpressionCompiler.Compile(
                Input(WorkflowActions.BuiltIn.Compose(() => values[1])).Value<string>());
            using var listExpression = EmittedExpressionCompiler.Compile(
                Input(WorkflowActions.BuiltIn.Compose(() => list[1])).Value<string>());
            using var dictionaryExpression = EmittedExpressionCompiler.Compile(
                Input(WorkflowActions.BuiltIn.Compose(() => dictionary["key"])).Value<string>());
            Assert.Equal("second", arrayExpression.Evaluate());
            Assert.Equal("second", listExpression.Evaluate());
            Assert.Equal("value", dictionaryExpression.Evaluate());
        }

        [Fact]
        public void ConditionalTypedWorkflowReceiver_IsMaterializedAndParenthesized()
        {
            var first = WorkflowActions.BuiltIn.Compose<string>(() => "a").WithName("A");
            var second = WorkflowActions.BuiltIn.Compose<string>(() => "b").WithName("B");
            var chooseFirst = false;

            Assert.Equal(
                "#{(false ? outputs(\"A\").ToObject<string>() : outputs(\"B\").ToObject<string>()).ToUpper()}",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => (chooseFirst ? first.Output : second.Output).ToUpper())).Value<string>());
        }

        [Fact]
        public void NativeEquality_DoesNotRewriteWorkflowTokensToDeepEquals()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "foo")
                .WithName("ComposeInput");

            var action = WorkflowActions.BuiltIn.Compose<bool>(
                () => trigger.TriggerOutput.Body == compose.Output && "value".ToUpper() == "VALUE");

            Assert.Equal(
                "#{triggerBody() == outputs(\"ComposeInput\") && \"value\".ToUpper() == \"VALUE\"}",
                Input(action).Value<string>());
        }

        [Fact]
        public void TypedWorkflowValues_AreMaterializedInAllCSharpOperandPositions()
        {
            var boolean = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Boolean");
            var values = WorkflowActions.BuiltIn.Compose<List<int>>(() => new List<int> { 1, 2 })
                .WithName("Values");

            Assert.Equal(
                "#{(!outputs(\"Boolean\").ToObject<bool>()).ToString().ToUpper()}",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => (!boolean.Output).ToString().ToUpper())).Value<string>());
            Assert.Equal(
                "#{outputs(\"Boolean\").ToObject<bool>() ? \"yes\".ToUpper() : \"no\"}",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => boolean.Output ? "yes".ToUpper() : "no")).Value<string>());
            Assert.Contains(
                "outputs(\"Values\").ToObject<global::System.Collections.Generic.List<int>>()",
                Input(WorkflowActions.BuiltIn.Compose<int>(() => values.Output.Count())).Value<string>());
        }

        [Fact]
        public void ObjectWorkflowEquality_PreservesNativeObjectMaterialization()
        {
            var first = WorkflowActions.BuiltIn.Compose<object>(() => new { value = 1 })
                .WithName("A");
            var second = WorkflowActions.BuiltIn.Compose<object>(() => new { value = 1 })
                .WithName("B");

            Assert.Equal(
                "#{outputs(\"A\").ToObject<object>() == outputs(\"B\").ToObject<object>() && \"value\".ToUpper() == \"VALUE\"}",
                Input(WorkflowActions.BuiltIn.Compose<bool>(
                    () => first.Output == second.Output && "value".ToUpper() == "VALUE")).Value<string>());
        }

        [Fact]
        public void UserModelNamedTriggerOutputBody_IsNotRewritten()
        {
            var model = new TriggerNamedModel
            {
                TriggerOutput = new BodyNamedModel { Body = "value" }
            };

            var expression = Input(WorkflowActions.BuiltIn.Compose(
                () => model.TriggerOutput.Body.ToUpper())).Value<string>();

            Assert.Equal("#{\"value\".ToUpper()}", expression);
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            Assert.Equal("VALUE", compiled.Evaluate());
        }

        private sealed class TriggerNamedModel
        {
            public BodyNamedModel TriggerOutput { get; set; }
        }

        private sealed class BodyNamedModel
        {
            public string Body { get; set; }
        }

        private static JToken Input(IWorkflowAction action) =>
            JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"];
    }
}
