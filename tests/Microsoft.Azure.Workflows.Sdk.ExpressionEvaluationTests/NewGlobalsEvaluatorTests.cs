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
    /// Tests for the new globals added to <see cref="WorkflowExpressionGlobals"/>:
    /// parameters, item, items, iterationIndexes, workflow, result.
    /// </summary>
    public class NewGlobalsEvaluatorTests
    {
        private static readonly RoslynWorkflowExpressionEvaluator Evaluator = new RoslynWorkflowExpressionEvaluator();

        // -------------------- parameters() --------------------

        [Fact]
        public async Task Evaluate_Parameters_ReturnsParameterValue()
        {
            var globals = new WorkflowExpressionGlobals(
                parameters: new Dictionary<string, JToken> { ["connString"] = new JValue("Server=db;") });

            var result = await Evaluator.EvaluateAsync("parameters(\"connString\")", globals);
            Assert.Equal("\"Server=db;\"", JsonConvert.SerializeObject(result));
        }

        [Fact]
        public async Task Evaluate_Parameters_MissingKey_ReturnsNull()
        {
            var globals = new WorkflowExpressionGlobals();

            var result = await Evaluator.EvaluateAsync("parameters(\"missing\")", globals);
            Assert.Equal("null", JsonConvert.SerializeObject(result));
        }

        // -------------------- item() --------------------

        [Fact]
        public async Task Evaluate_Item_ReturnsCurrentItem()
        {
            var globals = new WorkflowExpressionGlobals(
                currentItem: new JValue("current-item-value"));

            var result = await Evaluator.EvaluateAsync("item()", globals);
            Assert.Equal("\"current-item-value\"", JsonConvert.SerializeObject(result));
        }

        [Fact]
        public async Task Evaluate_Item_NoItem_ReturnsNull()
        {
            var globals = new WorkflowExpressionGlobals();

            var result = await Evaluator.EvaluateAsync("item()", globals);
            Assert.Equal("null", JsonConvert.SerializeObject(result));
        }

        // -------------------- items() --------------------

        [Fact]
        public async Task Evaluate_Items_ReturnsNamedForeachItem()
        {
            var globals = new WorkflowExpressionGlobals(
                items: new Dictionary<string, JToken> { ["myLoop"] = new JValue("loop-item") });

            var result = await Evaluator.EvaluateAsync("items(\"myLoop\")", globals);
            Assert.Equal("\"loop-item\"", JsonConvert.SerializeObject(result));
        }

        // -------------------- iterationIndexes() --------------------

        [Fact]
        public async Task Evaluate_IterationIndexes_ReturnsIndex()
        {
            var globals = new WorkflowExpressionGlobals(
                iterationIndexes: new Dictionary<string, JToken> { ["myLoop"] = new JValue(3) });

            var result = await Evaluator.EvaluateAsync("iterationIndexes(\"myLoop\")", globals);
            Assert.Equal("3", JsonConvert.SerializeObject(result));
        }

        // -------------------- workflow() --------------------

        [Fact]
        public async Task Evaluate_Workflow_ReturnsWorkflowMetadata()
        {
            var workflowData = new JObject { ["id"] = "/subscriptions/.../workflows/myFlow", ["name"] = "myFlow" };
            var globals = new WorkflowExpressionGlobals(workflow: workflowData);

            var result = await Evaluator.EvaluateAsync("workflow()", globals);
            Assert.Equal("myFlow", (result as JToken)?["name"]?.ToString());
        }

        // -------------------- result() --------------------

        [Fact]
        public async Task Evaluate_Result_ReturnsActionResult()
        {
            var globals = new WorkflowExpressionGlobals(
                results: new Dictionary<string, JToken>
                {
                    ["ScopeAction"] = new JObject { ["status"] = "Succeeded" }
                });

            var result = await Evaluator.EvaluateAsync("result(\"ScopeAction\")", globals);
            Assert.Equal("Succeeded", (result as JToken)?["status"]?.ToString());
        }

        // -------------------- Combined expressions with new globals --------------------

        [Fact]
        public async Task Evaluate_ItemWithStringOperation_Works()
        {
            var globals = new WorkflowExpressionGlobals(
                currentItem: new JValue("HELLO"));

            var result = await Evaluator.EvaluateAsync("item().Value<string>().ToLower()", globals);
            Assert.Equal("\"hello\"", JsonConvert.SerializeObject(result));
        }

        [Fact]
        public async Task Evaluate_ParametersInInterpolation_Works()
        {
            var globals = new WorkflowExpressionGlobals(
                parameters: new Dictionary<string, JToken> { ["env"] = new JValue("prod") });

            var result = await Evaluator.EvaluateAsync("$\"environment: {parameters(\"env\")}\"", globals);
            Assert.Equal("\"environment: prod\"", JsonConvert.SerializeObject(result));
        }
    }
}
