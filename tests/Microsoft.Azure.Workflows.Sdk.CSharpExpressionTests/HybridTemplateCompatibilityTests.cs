// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Newtonsoft.Json.Linq;

    public class HybridTemplateCompatibilityTests
    {
        public static IEnumerable<object[]> BooleanCases()
        {
            // Captures prevent constant folding, so these exercise the expression visitors.
            int left = 2, right = 3;
            bool yes = true, no = false;
            yield return Case(() => left == right, "@equals(2, 3)");
            yield return Case(() => left != right, "@not(equals(2, 3))");
            yield return Case(() => left < right, "@less(2, 3)");
            yield return Case(() => left <= right, "@lessOrEquals(2, 3)");
            yield return Case(() => yes && no, "@and(true, false)");
            yield return Case(() => yes || no, "@or(true, false)");
            yield return Case(() => !yes, "@not(true)");
            yield return Case(() => left + right == 5, "@equals(add(2, 3), 5)");
            yield return Case(() => left - right == 5, "@equals(subtract(2, 3), 5)");
            yield return Case(() => left * right == 5, "@equals(multiply(2, 3), 5)");
            yield return Case(() => left / right == 5, "@equals(divide(2, 3), 5)");
            yield return Case(() => left % right == 5, "@equals(mod(2, 3), 5)");
        }

        [Theory]
        [MemberData(nameof(BooleanCases))]
        public void SupportedBooleanOperations_StayTemplateInBothApis(
            Expression<Func<bool>> expression, string expected)
        {
            Assert.Equal(expected, CSharpExpressionConverter.ConvertO(expression));
            var token = CSharpExpressionConverter.ConvertToken(expression);
            Assert.Equal(JTokenType.String, token.Type);
            Assert.Equal(expected, token.Value<string>());
        }

        [Fact]
        public void TypedWorkflowArithmetic_StaysTemplateInBothApis()
        {
            var count = WorkflowActions.BuiltIn.Compose<int>(() => 0).WithName("Count");
            Expression<Func<int>> expression = () => count.Output + 2;

            Assert.Equal("@add(outputs('Count'), 2)", CSharpExpressionConverter.ConvertO(expression));
            Assert.Equal("@add(outputs('Count'), 2)",
                CSharpExpressionConverter.ConvertToken(expression).Value<string>());
        }

        [Fact]
        public void NestedWorkflowArithmeticAndLogic_StayTemplateInBothApis()
        {
            var count = WorkflowActions.BuiltIn.Compose<int>(() => 0).WithName("Count");
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            Expression<Func<bool>> expression = () => (count.Output + 2) * 3 == 9 && flag.Output;
            const string expected = "@and(equals(multiply(add(outputs('Count'), 2), 3), 9), outputs('Flag'))";

            Assert.Equal(expected, CSharpExpressionConverter.ConvertO(expression));
            Assert.Equal(expected, CSharpExpressionConverter.ConvertToken(expression).Value<string>());
        }

        [Fact]
        public void TypedWorkflowConditional_StaysTemplateInBothApis()
        {
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            Expression<Func<string>> expression = () => flag.Output ? "yes" : "no";
            const string expected = "@if(outputs('Flag'), 'yes', 'no')";

            Assert.Equal(expected, CSharpExpressionConverter.ConvertO(expression));
            Assert.Equal(expected, CSharpExpressionConverter.ConvertToken(expression).Value<string>());
        }

        [Fact]
        public void MultipleWorkflowReferences_StayTemplateInInterpolation()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var action = WorkflowActions.BuiltIn.Compose(inputs: () => "unused").WithName("Previous");
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "message", value: () => "unused");
            Expression<Func<string>> expression =
                () => $"body={trigger.TriggerOutput.Body}; output={action.Output}; variable={variable.Value}";
            const string expected =
                "body=@{triggerBody()}; output=@{outputs('Previous')}; variable=@{variables('message')}";

            Assert.Equal(expected, CSharpExpressionConverter.ConvertO(expression));
            Assert.Equal(expected, CSharpExpressionConverter.ConvertToken(expression).Value<string>());
        }

        [Fact]
        public void WorkflowJsonIndexer_StaysTemplateWithoutNativeTokenMethods()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            Expression<Func<JToken>> expression = () => trigger.TriggerOutput.Body["condition"];

            Assert.Equal("@triggerBody()['condition']", CSharpExpressionConverter.ConvertO(expression));
            Assert.Equal("@triggerBody()['condition']",
                CSharpExpressionConverter.ConvertToken(expression).Value<string>());
        }

        [Fact]
        public void StructuredPayloadWithReferences_PreservesJsonShape()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var action = WorkflowActions.BuiltIn.Compose(() => "unused").WithName("Previous");
            var payload = CSharpExpressionConverter.ConvertToken(() => new
            {
                enabled = true,
                count = 3,
                nested = new { body = trigger.TriggerOutput.Body },
                labels = new[] { "literal", $"value={action.Output}" }
            });
            var expected = new JObject
            {
                ["enabled"] = true,
                ["count"] = 3,
                ["nested"] = new JObject { ["body"] = "@triggerBody()" },
                ["labels"] = new JArray("literal", "value=@{outputs('Previous')}")
            };

            Assert.True(JToken.DeepEquals(expected, payload), payload.ToString());
        }

        [Theory]
        [InlineData(1, "@{encodeURIComponent(outputs('Source'))}",
            "@csharp{encodeURIComponent(outputs(\"Source\").ToObject<string>().ToUpperInvariant())}")]
        [InlineData(2, "@{encodeURIComponent(encodeURIComponent(outputs('Source')))}",
            "@csharp{encodeURIComponent(encodeURIComponent(outputs(\"Source\").ToObject<string>().ToUpperInvariant()))}")]
        public void UrlEncoding_SelectsTemplateOrCSharpForSameWorkflowSource(
            int times, string template, string csharp)
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");

            Assert.Equal(template,
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => source.Output, times));
            Assert.Equal(csharp,
                CSharpExpressionConverter.ConvertWithUrlEncoding(() => source.Output.ToUpperInvariant(), times));
        }

        [Fact]
        public void Base64_SelectsTemplateOrCSharpForSameWorkflowSource()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");

            Assert.Equal("@base64(outputs('Source'))",
                CSharpExpressionConverter.ConvertOWithBase64(() => source.Output));
            Assert.Equal("@csharp{base64(outputs(\"Source\").ToObject<string>().ToUpperInvariant())}",
                CSharpExpressionConverter.ConvertOWithBase64(() => source.Output.ToUpperInvariant()));
        }

        [Theory]
        [InlineData("")]
        [InlineData("literal triggerOutputs()?['Body']")]
        [InlineData("quotes \" and ' with \\ and {braces}")]
        public void StringLiterals_RemainUnchanged(string value)
        {
            Assert.Equal(value, CSharpExpressionConverter.ConvertO(() => value));
            Assert.Equal(value, CSharpExpressionConverter.ConvertToken(() => value).Value<string>());
        }

        [Fact]
        public void NullLambdaAndExplicitNull_AreDistinct()
        {
            Assert.Null(CSharpExpressionConverter.ConvertToken<string>(null));
            Assert.Equal(JTokenType.Null, CSharpExpressionConverter.ConvertToken<string>(() => null).Type);
            Assert.Equal(string.Empty, CSharpExpressionConverter.ConvertO<string>(null));
        }

        [Fact]
        public void CapturedBoxedPrimitives_PreserveTypesAndValues()
        {
            int count = 7;
            bool enabled = false;
            double amount = 1.25;

            Assert.Equal(new JValue(count), CSharpExpressionConverter.ConvertToken<object>(() => count));
            Assert.Equal(new JValue(enabled), CSharpExpressionConverter.ConvertToken<object>(() => enabled));
            Assert.Equal(new JValue(amount), CSharpExpressionConverter.ConvertToken<object>(() => amount));
        }

        [Fact]
        public void BoxedNativeCall_IsNotExecutedDuringConversion()
        {
            var counter = new InvocationCounter();

            var result = CSharpExpressionConverter.ConvertToken<object>(() => counter.Next());

            Assert.Equal(0, counter.Calls);
            Assert.StartsWith("@csharp{", result.Value<string>());
        }

        [Fact]
        public void BoxedNumericConversion_PreservesTheRequestedCast()
        {
            double value = 2.75;
            var result = CSharpExpressionConverter.ConvertToken<object>(() => (int)value);

            Assert.Equal(JTokenType.Integer, result.Type);
            Assert.Equal(2, result.Value<int>());
        }

        private static object[] Case(Expression<Func<bool>> expression, string expected) =>
            new object[] { expression, expected };

        public sealed class InvocationCounter
        {
            public int Calls { get; private set; }

            public int Next() => ++this.Calls;
        }
    }
}
