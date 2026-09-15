// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class BuiltInActionSerializationTests
    {
        [Fact]
        public void HttpAction_SerializesDesignerV2Defaults()
        {
            var action = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("https://example.com/api"),
                method: () => HttpMethod.Get);

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "Http",
                  "inputs": {
                    "uri": "https://example.com/api",
                    "method": "GET"
                  },
                  "runtimeConfiguration": {
                    "contentTransfer": {
                      "transferMode": "Chunked"
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void HttpAction_SerializesPopulatedRequestEnvelopeInTheCorrectLocations()
        {
            var queries = new Dictionary<string, string> { ["mode"] = "full" };
            var headers = new Dictionary<string, string> { ["x-parity"] = "enabled" };
            var action = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("https://example.com/api"),
                method: () => HttpMethod.Post,
                requestBody: () => "payload",
                queries: () => queries,
                headers: () => headers);

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "Http",
                  "inputs": {
                    "uri": "https://example.com/api",
                    "method": "POST",
                    "headers": {
                      "x-parity": "enabled"
                    },
                    "queries": {
                      "mode": "full"
                    },
                    "body": "payload"
                  },
                  "runtimeConfiguration": {
                    "contentTransfer": {
                      "transferMode": "Chunked"
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void HttpAction_ConvertsInlineQueryAndHeaderValuesWithHybridSelection()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var action = WorkflowActions.BuiltIn.HttpAction(
                uri: () => new Uri("https://example.com/api"),
                method: () => HttpMethod.Get,
                queries: () => new Dictionary<string, string>
                {
                    { "template", source.Output },
                    { "csharp", source.Output.ToUpperInvariant() },
                },
                headers: () => new Dictionary<string, string>
                {
                    { "x-template", source.Output },
                    { "x-csharp", source.Output.ToLowerInvariant() },
                });

            var inputs = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"];

            Assert.Equal("@outputs('Source')", inputs["queries"]["template"].Value<string>());
            Assert.Equal(
                "@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}",
                inputs["queries"]["csharp"].Value<string>());
            Assert.Equal("@outputs('Source')", inputs["headers"]["x-template"].Value<string>());
            Assert.Equal(
                "@csharp{outputs(\"Source\").ToObject<string>().ToLowerInvariant()}",
                inputs["headers"]["x-csharp"].Value<string>());
        }

        [Fact]
        public void Response_SerializesDesignerV2Defaults()
        {
            var action = WorkflowActions.BuiltIn.Response();

            Assert.Equal(HttpStatusCode.OK, Assert.IsType<ResponseAction<JToken>>(action).StatusCode);

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "Response",
                  "kind": "Http",
                  "inputs": {
                    "statusCode": 200
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void ResponseActionInput_PreservesIntegerStatusCodeApiAndSerialization()
        {
            var inputs = new ResponseActionInput
            {
                StatusCode = (int)HttpStatusCode.Accepted,
            };

            Assert.Equal((int)HttpStatusCode.Accepted, inputs.StatusCode);
            Assert.Equal(
                (int)HttpStatusCode.Accepted,
                JObject.Parse(inputs.ToJson())["statusCode"].Value<int>());
        }

        [Fact]
        public void Response_UsesHybridConversionForAllExpressionInputs()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
            var schema = new JObject { ["type"] = "string" };
            var action = WorkflowActions.BuiltIn.Response(
                statusCode: () => flag.Output ? HttpStatusCode.Created : HttpStatusCode.BadRequest,
                responseBody: () => source.Output.ToUpperInvariant(),
                headers: () => new Dictionary<string, string>
                {
                    { "x-template", source.Output },
                },
                schema: () => schema);

            var inputs = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"];

            Assert.StartsWith("@csharp{", inputs["statusCode"].Value<string>());
            Assert.Equal(
                "@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}",
                inputs["body"].Value<string>());
            Assert.Equal("@outputs('Source')", inputs["headers"]["x-template"].Value<string>());
            Assert.True(JToken.DeepEquals(schema, inputs["schema"]));
        }

        [Fact]
        public void Agent_UsesHybridConversionForMessageContent()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var action = WorkflowActions.BuiltIn.Agent(
                AgentModelType.AzureOpenAI,
                "deployment",
                new AgentModelSettings(),
                "connection",
                () => new[]
                {
                    new AgentPromptMessage
                    {
                        Role = MessageRole.User,
                        Content = source.Output,
                    },
                    new AgentPromptMessage
                    {
                        Role = MessageRole.Assistant,
                        Content = source.Output.ToUpperInvariant(),
                    },
                });

            Assert.Equal("@outputs('Source')", action.Messages[0].Content);
            Assert.Equal(
                "@csharp{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}",
                action.Messages[1].Content);
        }

        [Fact]
        public void ConvertObject_DoesNotExecuteArbitraryUserCode()
        {
            var counter = new InvocationCounter();

            Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertObject(() => counter.CreateHeaders()));
            Assert.Equal(0, counter.Count);
        }

        [Fact]
        public void FlowTemplateAction_SerializesNonEmptyRunAfterWithDesignerStatusCasing()
        {
            var action = new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Compose,
                RunAfter = new Dictionary<string, FlowStatus[]>
                {
                    ["Previous_action"] = new[] { FlowStatus.Succeeded, FlowStatus.Failed },
                },
            };

            var actual = JObject.Parse(action.ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "Compose",
                  "runAfter": {
                    "Previous_action": [
                      "SUCCEEDED",
                      "FAILED"
                    ]
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void Terminate_SerializesInputStatusWithDesignerCasing()
        {
            var action = WorkflowActions.BuiltIn.Control.Terminate(
                status: () => FlowStatus.Failed,
                message: () => "Stopped");

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());

            Assert.Equal("Failed", actual["inputs"]["runStatus"].Value<string>());
        }

        [Fact]
        public void SwitchWithoutDefaultAction_SerializesEmptyDefaultBranch()
        {
            JToken switchValue = "ready";
            var action = WorkflowActions.BuiltIn.Control.Switch(
                on: () => switchValue,
                cases: () => new Dictionary<string, SwitchCase>
                {
                    ["Case"] = new SwitchCase(
                        caseValue: "ready",
                        actions: WorkflowActions.BuiltIn.Compose(() => "matched")),
                });

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());

            Assert.True(
                JToken.DeepEquals(
                    JObject.Parse("""{"actions":{}}"""),
                    actual["default"]),
                actual.ToString());
        }

        [Fact]
        public void InitializeVariable_SerializesSupportedWorkflowSchemaTypes()
        {
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "stringVariable",
                    value: () => "value"),
                "stringVariable",
                "string",
                new JValue("value"));
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "integerVariable",
                    value: () => 1),
                "integerVariable",
                "integer",
                new JValue(1));
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "floatVariable",
                    value: () => 1.5),
                "floatVariable",
                "float",
                new JValue(1.5));
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "booleanVariable",
                    value: () => true),
                "booleanVariable",
                "boolean",
                new JValue(true));
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "arrayVariable",
                    value: () => new[] { "value" }),
                "arrayVariable",
                "array",
                new JArray("value"));
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable<object>(
                    name: () => "objectVariable",
                    value: () => new { property = "value" }),
                "objectVariable",
                "object",
                new JObject { ["property"] = "value" });
            var jObject = new JObject { ["property"] = "value" };
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "jObjectVariable",
                    value: () => jObject),
                "jObjectVariable",
                "object",
                jObject);
            var jArray = new JArray("value");
            AssertVariableDefinition(
                WorkflowActions.BuiltIn.Variables.InitializeVariable(
                    name: () => "jArrayVariable",
                    value: () => jArray),
                "jArrayVariable",
                "array",
                jArray);
        }

        private sealed class InvocationCounter
        {
            public int Count { get; private set; }

            public Dictionary<string, string> CreateHeaders()
            {
                this.Count++;
                return new Dictionary<string, string>();
            }
        }

        [Fact]
        public void WorkflowFactory_SerializesTopLevelRunAfterLikeDesigner()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var root = WorkflowActions.BuiltIn.Compose(() => "root").WithName("Root_action");
            var dependent = WorkflowActions.BuiltIn.Compose(() => "dependent").WithName("Dependent_action");
            trigger.Then(root).Then(dependent);

            var actual = JObject.Parse(WorkflowFactory.CreateStatefulWorkflow("workflow", trigger).ToJson());
            var actions = (JObject)actual["definition"]["actions"];
            var expected = JObject.Parse(
                """
                {
                  "Root_action": {
                    "type": "Compose",
                    "inputs": "root",
                    "runAfter": {}
                  },
                  "Dependent_action": {
                    "type": "Compose",
                    "inputs": "dependent",
                    "runAfter": {
                      "Root_action": [
                        "SUCCEEDED"
                      ]
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actions), actions.ToString());
        }

        [Fact]
        public void WorkflowFactory_OmitsEmptyRunAfterFromNestedScopeAction()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var scope = WorkflowActions.BuiltIn.Control.Scope(
                () => WorkflowActions.BuiltIn.Compose(() => "nested").WithName("Nested_action"))
                .WithName("Scope_action");
            trigger.Then(scope);

            var actual = JObject.Parse(WorkflowFactory.CreateStatefulWorkflow("workflow", trigger).ToJson());
            var scopeDefinition = actual["definition"]["actions"]["Scope_action"];
            var expected = JObject.Parse(
                """
                {
                  "type": "Scope",
                  "actions": {
                    "Nested_action": {
                      "type": "Compose",
                      "inputs": "nested"
                    }
                  },
                  "runAfter": {}
                }
                """);

            Assert.True(JToken.DeepEquals(expected, scopeDefinition), scopeDefinition.ToString());
        }

        [Fact]
        public void WorkflowFactory_OmitsEmptyRunAfterFromNestedConditionBranches()
        {
            var conditionValue = "ready";
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var condition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => conditionValue == "ready",
                trueBranch: () => WorkflowActions.BuiltIn.Compose(() => "true").WithName("True_action"),
                falseBranch: () => WorkflowActions.BuiltIn.Compose(() => "false").WithName("False_action"))
                .WithName("Condition_action");
            trigger.Then(condition);

            var actual = JObject.Parse(WorkflowFactory.CreateStatefulWorkflow("workflow", trigger).ToJson());
            var conditionDefinition = actual["definition"]["actions"]["Condition_action"];
            var expected = JObject.Parse(
                """
                {
                  "type": "If",
                  "actions": {
                    "True_action": {
                      "type": "Compose",
                      "inputs": "true"
                    }
                  },
                  "expression": {
                    "and": [
                      {
                        "equals": [
                          "ready",
                          "ready"
                        ]
                      }
                    ]
                  },
                  "runAfter": {},
                  "else": {
                    "actions": {
                      "False_action": {
                        "type": "Compose",
                        "inputs": "false"
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, conditionDefinition), conditionDefinition.ToString());
        }

        [Fact]
        public void ForEach_PreservesLocalJsonArrayItems()
        {
            var items = new JArray("first", "second");
            var action = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => items,
                actions: _ => WorkflowActions.BuiltIn.Compose(() => "nested"));

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());

            Assert.True(JToken.DeepEquals(items, actual["foreach"]), actual.ToString());
        }

        private static void AssertVariableDefinition(
            IVariableWorkflowAction action,
            string name,
            string type,
            JToken value)
        {
            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = new JObject
            {
                ["type"] = "InitializeVariable",
                ["inputs"] = new JObject
                {
                    ["variables"] = new JArray
                    {
                        new JObject
                        {
                            ["name"] = name,
                            ["type"] = type,
                            ["value"] = value,
                        },
                    },
                },
            };

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }
    }
}
