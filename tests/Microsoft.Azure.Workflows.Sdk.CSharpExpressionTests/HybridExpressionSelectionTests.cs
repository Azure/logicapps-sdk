// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    public class HybridExpressionSelectionTests
    {
        [Fact]
        public void Compose_WithOnlyWorkflowReference_UsesTemplateExpression()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Received request: {trigger.TriggerOutput.Body}");

            var definition = compose.GetActionDefinition("workflow");

            Assert.Equal(
                "Received request: @{triggerBody()}",
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
                "@csharp{triggerBody()[\"condition\"].ToString() == \"foo\"}",
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

            Assert.Equal("@csharp{triggerBody() == outputs(\"ComposeInput\")}", definition.Expression.Value<string>());
        }

        [Fact]
        public void NativeMethodOnTypedWorkflowOutput_UsesTypedCSharpValue()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "site")
                .WithName("Source");
            var expression = CSharpExpressionConverter.ConvertO(
                () => source.Output.ToUpper());

            Assert.Equal(
                "@csharp{outputs(\"Source\").ToObject<string>().ToUpper()}",
                expression);
        }

        [Fact]
        public void LiteralContainingTriggerSyntax_IsNotNormalized()
        {
            const string value = "literal triggerOutputs()?['Body']";

            Assert.Equal(value, CSharpExpressionConverter.ConvertO(() => value));
        }

        [Fact]
        public void TriggerReferenceAndSimilarLiteral_AreRenderedIndependently()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(
                () => $"{trigger.TriggerOutput.Body} literal triggerOutputs()?['Body']");

            Assert.Equal(
                "@{triggerBody()} literal triggerOutputs()?['Body']",
                Assert.IsAssignableFrom<JToken>(
                    compose.GetActionDefinition("workflow").Inputs).Value<string>());
        }

        [Fact]
        public void NativePropertyOnTypedWorkflowOutput_UsesTypedCSharpValue()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "site")
                .WithName("Source");

            Assert.Equal(
                "@csharp{outputs(\"Source\").ToObject<string>().Length}",
                CSharpExpressionConverter.ConvertO(() => source.Output.Length));
        }

        [Fact]
        public void UnsupportedCompositeFormat_FallsBackToCSharp()
        {
            Assert.Equal(
                "@csharp{string.Format(\"{0:00}\", 5)}",
                CSharpExpressionConverter.ConvertO(() => string.Format("{0:00}", 5)));
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

            Assert.StartsWith("@csharp{", CSharpExpressionConverter.ConvertO(() => values[1]));
            var listExpression = CSharpExpressionConverter.ConvertO(() => list[1]);
            Assert.Contains("new List<string>", listExpression);
            Assert.DoesNotContain("`", listExpression);
            Assert.StartsWith("@csharp{", CSharpExpressionConverter.ConvertO(() => dictionary["key"]));
        }

        [Fact]
        public void ConditionalTypedWorkflowReceiver_IsMaterializedAndParenthesized()
        {
            var first = WorkflowActions.BuiltIn.Compose<string>(() => "a").WithName("A");
            var second = WorkflowActions.BuiltIn.Compose<string>(() => "b").WithName("B");
            var chooseFirst = false;

            Assert.Equal(
                "@csharp{(false ? outputs(\"A\").ToObject<string>() : outputs(\"B\").ToObject<string>()).ToUpper()}",
                CSharpExpressionConverter.ConvertO(
                    () => (chooseFirst ? first.Output : second.Output).ToUpper()));
        }

        [Fact]
        public void CSharpFallback_UsesValueEqualityForWorkflowTokens()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "foo")
                .WithName("ComposeInput");

            var expression = CSharpExpressionConverter.ConvertO(
                () => trigger.TriggerOutput.Body == compose.Output &&
                      "value".ToUpper() == "VALUE");

            Assert.Contains(
                "JToken.DeepEquals(triggerBody(), outputs(\"ComposeInput\"))",
                expression);
        }

        [Fact]
        public void TypedWorkflowValues_AreMaterializedInAllCSharpOperandPositions()
        {
            var boolean = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Boolean");
            var values = WorkflowActions.BuiltIn.Compose<List<int>>(() => new List<int> { 1, 2 })
                .WithName("Values");

            Assert.Equal(
                "@csharp{(!outputs(\"Boolean\").ToObject<bool>()).ToString().ToUpper()}",
                CSharpExpressionConverter.ConvertO(
                    () => (!boolean.Output).ToString().ToUpper()));
            Assert.Equal(
                "@csharp{outputs(\"Boolean\").ToObject<bool>() ? \"yes\".ToUpper() : \"no\"}",
                CSharpExpressionConverter.ConvertO(
                    () => boolean.Output ? "yes".ToUpper() : "no"));
            Assert.Contains(
                "outputs(\"Values\").ToObject<List<int>>()",
                CSharpExpressionConverter.ConvertO(() => values.Output.Count()));
        }

        [Fact]
        public void ObjectWorkflowEquality_UsesDeepEqualsDuringCSharpFallback()
        {
            var first = WorkflowActions.BuiltIn.Compose<object>(() => new { value = 1 })
                .WithName("A");
            var second = WorkflowActions.BuiltIn.Compose<object>(() => new { value = 1 })
                .WithName("B");

            Assert.Contains(
                "JToken.DeepEquals(outputs(\"A\"), outputs(\"B\"))",
                CSharpExpressionConverter.ConvertO(
                    () => first.Output == second.Output &&
                          "value".ToUpper() == "VALUE"));
        }

        [Fact]
        public void UserModelNamedTriggerOutputBody_IsNotRewritten()
        {
            var model = new TriggerNamedModel
            {
                TriggerOutput = new BodyNamedModel { Body = "value" }
            };

            var expression = CSharpExpressionConverter.ConvertO(
                () => model.TriggerOutput.Body.ToUpper());

            Assert.Equal("@csharp{\"value\".ToUpper()}", expression);
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
    }
}
