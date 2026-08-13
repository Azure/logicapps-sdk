// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluationTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// End-to-end tests for the <see cref="RoslynWorkflowExpressionEvaluator"/> that feed the
    /// C# expression strings produced by the converter goal suite and assert the runtime value.
    /// This closes the converter &lt;-&gt; evaluator loop: the strings we set as goals actually
    /// evaluate to the values the Logic App expressions would produce.
    ///
    /// The evaluated result is compared via JSON serialization so a single assertion handles
    /// strings, numbers, booleans, JToken, arrays and objects uniformly.
    /// </summary>
    public class EvaluatorTests
    {
        private static readonly RoslynWorkflowExpressionEvaluator Evaluator = new RoslynWorkflowExpressionEvaluator(
            additionalReferences: new[] { typeof(Poco).Assembly },
            additionalImports: new[] { typeof(Poco).Namespace, "System.Collections.Generic" });

        private static WorkflowExpressionGlobals CreateGlobals() => new WorkflowExpressionGlobals(
            triggerOutputs: new JObject { ["Body"] = "trigBody", ["body"] = "trigBodyLower" },
            actionOutputs: new Dictionary<string, JToken>
            {
                ["ComposeInput"] = new JValue("composeOut"),
                ["GetItems"] = new JObject { ["body"] = "spBody" },
            },
            variables: new Dictionary<string, JToken> { ["myVar"] = new JValue("v") },
            agentParameters: new Dictionary<string, JToken> { ["Name"] = new JValue("n") });

        public static IEnumerable<object[]> Cases => new[]
        {
            // -------------------- Literals / operators --------------------
            Row("\"hello\"", "\"hello\""),
            Row("true", "true"),
            Row("3", "3"),
            Row("1 < 2", "true"),
            Row("1 <= 2", "true"),
            Row("1 == 2", "false"),
            Row("1 != 2", "true"),
            Row("1 > 2", "false"),               // improvement: LA converter throws
            Row("1 >= 2", "false"),              // improvement: LA converter throws
            Row("true && false", "false"),
            Row("true || false", "true"),
            Row("1 + 2 == 3", "true"),
            Row("1 - 2 == 3", "false"),
            Row("1 * 2 == 3", "false"),
            Row("1 / 2 == 3", "false"),
            Row("1 % 2 == 3", "false"),
            Row("1.5 + 2.5 == 4", "true"),
            Row("1 < 2 ? \"hello\" : \"world\"", "\"hello\""),
            Row("\"hello\" + \"world\"", "\"helloworld\""),
            Row("string.Format(\"Hello {0}!\", \"world\")", "\"Hello world!\""),
            Row("string.Format(\"{0}-{1}\", \"hello\", \"world\")", "\"hello-world\""),
            Row("string.Concat(\"a\", \"b\")", "\"ab\""),
            Row("(1).ToString()", "\"1\""),      // improvement: LA converter throws
            Row("\"a\" == null", "false"),

            // -------------------- Native BCL / LINQ --------------------
            Row("\"hello\".ToUpper()", "\"HELLO\""),
            Row("\"hello\".Substring(1, 3)", "\"ell\""),
            Row("\"hello\" ?? \"fallback\"", "\"hello\""),
            Row("string.Join(\", \", new[] { \"a\", \"b\", \"c\" })", "\"a, b, c\""),
            Row("\"hello\".Contains(\"ell\")", "true"),
            Row("\"hello\".StartsWith(\"he\") && \"hello\".EndsWith(\"lo\")", "true"),
            Row("\"hello\".Length", "5"),
            Row("Math.Max(3, 7)", "7"),
            Row("new[] { 3, 1, 2 }.Max()", "3"),
            Row("3 * 7 + 2", "23"),
            Row("12 & 10", "8"),
            Row("Math.Round(3.14159, 2)", "3.14"),
            Row("Math.Pow(2, 10)", "1024.0"),
            Row("!true", "false"),

            // -------------------- Helper functions --------------------
            Row("encodeURIComponent(\"a b\")", "\"a%20b\""),
            Row("encodeURIComponent(encodeURIComponent(\"a b\"))", "\"a%2520b\""),
            Row("encodeURIComponent(42)", "\"42\""),
            Row("base64(\"hello\")", "\"aGVsbG8=\""),
            Row("json(\"{\\\"k\\\":1}\")", "{\"k\":1}"),

            // -------------------- Workflow context --------------------
            Row("variables(\"myVar\")", "\"v\""),
            Row("$\"prefix-{variables(\"myVar\")}\"", "\"prefix-v\""),
            Row("variables(\"myVar\").ToObject<string>()", "\"v\""),
            Row("variables(\"myVar\").Value<string>()", "\"v\""),   // improvement: LA converter throws
            Row("triggerOutputs()?[\"Body\"]", "\"trigBody\""),
            Row("triggerBody()", "\"trigBodyLower\""),
            Row("outputs(\"ComposeInput\")", "\"composeOut\""),
            Row("body(\"GetItems\")", "\"spBody\""),
            Row("$\"a {outputs(\"ComposeInput\")} b {body(\"GetItems\")}\"", "\"a composeOut b spBody\""),
            Row("agentparameters(\"Name\")", "\"n\""),

            // -------------------- Improvements: indexing --------------------
            Row("new[] { \"x\", \"y\" }[0]", "\"x\""),
            Row("new[] { \"x\", \"y\" }[1]", "\"y\""),
            Row("new Dictionary<string, string> { [\"k\"] = \"v\" }[\"k\"]", "\"v\""),

            // -------------------- Object payloads (round-trip to JSON) --------------------
            Row("new { a = \"x\", b = 1 }", "{\"a\":\"x\",\"b\":1}"),
            Row("new Poco { Name = \"n\", Count = 2, Tag = \"t\" }", "{\"Name\":\"n\",\"Count\":2,\"renamed\":\"t\"}"),
            Row("new[] { \"a\", \"b\" }", "[\"a\",\"b\"]"),
        };

        private static object[] Row(string expression, string expectedJson) => new object[] { expression, expectedJson };

        [Theory]
        [MemberData(nameof(Cases))]
        public async Task Evaluate_ProducesExpectedValue(string expression, string expectedJson)
        {
            var result = await Evaluator.EvaluateAsync(expression, CreateGlobals());
            Assert.Equal(expectedJson, JsonConvert.SerializeObject(result, Formatting.None));
        }

        [Fact]
        public async Task Evaluate_TypedOverload_CoercesJTokenResult()
        {
            var value = await Evaluator.EvaluateAsync<string>("variables(\"myVar\")", CreateGlobals());
            Assert.Equal("v", value);
        }

        [Fact]
        public async Task Evaluate_ObjectToJsonString_MatchesSerializerOutput()
        {
            // The object-interpolation case: converter emits a JsonConvert.SerializeObject call,
            // whose result is the JSON *string* (unset members included, JsonProperty honored).
            var value = await Evaluator.EvaluateAsync<string>(
                "JsonConvert.SerializeObject(new Poco { Name = \"n\", Count = 2 })",
                CreateGlobals());
            Assert.Equal("{\"Name\":\"n\",\"Count\":2,\"renamed\":null}", value);
        }

        [Fact]
        public async Task Evaluate_SameExpressionTwice_ReusesCompilationWithFreshGlobals()
        {
            // Demonstrates compile-once / run-many: the same cached delegate yields different
            // results for different globals.
            var a = new WorkflowExpressionGlobals(variables: new Dictionary<string, JToken> { ["myVar"] = new JValue("first") });
            var b = new WorkflowExpressionGlobals(variables: new Dictionary<string, JToken> { ["myVar"] = new JValue("second") });

            Assert.Equal("first", await Evaluator.EvaluateAsync<string>("variables(\"myVar\")", a));
            Assert.Equal("second", await Evaluator.EvaluateAsync<string>("variables(\"myVar\")", b));
        }

        [Fact]
        public async Task Evaluate_JTokenEquality_IsReferenceEquality_MotivatesDeepEquals()
        {
            // FINDING (feeds back to the converter): JToken '==' is REFERENCE equality, so two
            // value-equal tokens compare unequal. The converter should emit JToken.DeepEquals
            // for JToken operands instead of '=='.
            var globals = new WorkflowExpressionGlobals(
                triggerOutputs: new JObject { ["Body"] = "same" },
                actionOutputs: new Dictionary<string, JToken> { ["Same"] = new JValue("same") });

            var withEquals = await Evaluator.EvaluateAsync<bool>(
                "triggerOutputs()?[\"Body\"] == outputs(\"Same\")", globals);
            var withDeepEquals = await Evaluator.EvaluateAsync<bool>(
                "JToken.DeepEquals(triggerOutputs()?[\"Body\"], outputs(\"Same\"))", globals);

            Assert.False(withEquals);      // '==' is reference equality
            Assert.True(withDeepEquals);   // value equality works via DeepEquals
        }
    }
}
