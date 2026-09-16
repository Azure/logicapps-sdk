// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures;
    using Newtonsoft.Json.Linq;

    [Collection("Runtime-dependent expressions")]
    public class RuntimeDependentExpectedValueTests : IDisposable
    {
        public RuntimeDependentExpectedValueTests()
        {
            RuntimeValues.Reset();
        }

        public void Dispose()
        {
            RuntimeValues.Reset();
        }

        // Reference expressions demonstrate semantics, not a required spelling of generated C#.
        public static TheoryData<string, string, string, string> ExpectedValues => new()
        {
            {
                "static-getter",
                "@csharp{Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures.RuntimeValues.CurrentText.ToUpperInvariant()}",
                "FIRST",
                "SECOND"
            },
            {
                "static-field",
                "@csharp{Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures.RuntimeValues.Text.ToUpperInvariant()}",
                "FIRST",
                "SECOND"
            },
            {
                "enum-scalar",
                "@csharp{outputs(\"Flag\").ToString() == \"True\" ? \"first /+\" : \"second\"}",
                "first /+",
                "second"
            },
            {
                "enum-token",
                "@csharp{outputs(\"Flag\").ToString() == \"True\" ? \"first /+\" : \"second\"}",
                "first /+",
                "second"
            },
            {
                "enum-bcl-token",
                "@csharp{outputs(\"Flag\").ToString() == \"True\" ? \"Monday\" : \"Friday\"}",
                "Monday",
                "Friday"
            },
            {
                "captured-property-scalar",
                "@csharp{\"value\".ToUpperInvariant()}",
                "VALUE",
                "VALUE"
            },
            {
                "captured-property-token",
                "@csharp{\"value\".ToUpperInvariant()}",
                "VALUE",
                "VALUE"
            },
            {
                "captured-field-scalar",
                "@csharp{\"value\".ToUpperInvariant()}",
                "VALUE",
                "VALUE"
            },
            {
                "captured-field-token",
                "@csharp{\"value\".ToUpperInvariant()}",
                "VALUE",
                "VALUE"
            },
        };

        [Theory]
        [MemberData(nameof(ExpectedValues))]
        public void ReferenceExpression_ProducesExpectedValues(
            string scenario,
            string referenceExpression,
            string expectedFirst,
            string expectedSecond)
        {
            AssertExpectedValues(scenario, referenceExpression, expectedFirst, expectedSecond);
        }

        [Theory]
        [MemberData(nameof(ExpectedValues))]
        public void ConvertedExpression_ProducesExpectedValues(
            string scenario,
            string referenceExpression,
            string expectedFirst,
            string expectedSecond)
        {
            AssertExpectedValues(scenario, referenceExpression, expectedFirst, expectedSecond);
            RuntimeValues.Reset();

            var expression = ConvertScenario(scenario);

            AssertExpectedValues(scenario, expression, expectedFirst, expectedSecond);
        }

        private static void AssertExpectedValues(
            string scenario,
            string expression,
            string expectedFirst,
            string expectedSecond)
        {
            using var compiled = EmittedExpressionCompiler.Compile(expression);
            RuntimeValues.Text = "first";
            var first = compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = true });
            RuntimeValues.Text = "second";
            var second = compiled.Evaluate(new Dictionary<string, JToken> { ["Flag"] = false });

            Assert.True(first is string && second is string,
                $"{scenario} must return strings, not {first?.GetType().FullName} and {second?.GetType().FullName}.");
            Assert.Equal(
                new[] { expectedFirst, expectedSecond },
                new[] { Assert.IsType<string>(first), Assert.IsType<string>(second) });
        }

        private static string ConvertScenario(string scenario)
        {
            switch (scenario)
            {
                case "static-getter":
                    return CSharpExpressionConverter.ConvertO(() => RuntimeValues.CurrentText.ToUpperInvariant());
                case "static-field":
                    return CSharpExpressionConverter.ConvertO(() => RuntimeValues.Text.ToUpperInvariant());
                case "enum-scalar":
                case "enum-token":
                case "enum-bcl-token":
                {
                    var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
                    if (scenario == "enum-bcl-token")
                    {
                        return CSharpExpressionConverter.ConvertToken(
                            () => flag.Output.ToString() == "True" ? DayOfWeek.Monday : DayOfWeek.Friday).Value<string>();
                    }

                    Expression<Func<WireChoice>> input =
                        () => flag.Output.ToString() == "True" ? WireChoice.First : WireChoice.Second;
                    return scenario == "enum-token"
                        ? CSharpExpressionConverter.ConvertToken(input).Value<string>()
                        : CSharpExpressionConverter.Convert(input);
                }
                case "captured-property-scalar":
                case "captured-property-token":
                {
                    var model = new CapturedAutoModel
                    {
                        TriggerOutput = new CapturedAutoLeaf { Body = "value" },
                    };
                    Expression<Func<string>> input = () => model.TriggerOutput.Body.ToUpperInvariant();
                    var expression = scenario == "captured-property-token"
                        ? CSharpExpressionConverter.ConvertToken(input).Value<string>()
                        : CSharpExpressionConverter.ConvertO(input);
                    model.TriggerOutput.Body = "changed";
                    return expression;
                }
                case "captured-field-scalar":
                case "captured-field-token":
                {
                    var model = new CapturedFieldModel { Child = new CapturedFieldLeaf { Text = "value" } };
                    Expression<Func<string>> input = () => model.Child.Text.ToUpperInvariant();
                    var expression = scenario == "captured-field-token"
                        ? CSharpExpressionConverter.ConvertToken(input).Value<string>()
                        : CSharpExpressionConverter.ConvertO(input);
                    model.Child.Text = "changed";
                    return expression;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(scenario), scenario, "Unknown expected-value scenario.");
            }
        }
    }
}
