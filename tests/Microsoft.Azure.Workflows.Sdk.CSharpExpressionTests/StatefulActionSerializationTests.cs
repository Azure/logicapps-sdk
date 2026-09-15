// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Extensions.Logging.Abstractions;
    using Newtonsoft.Json.Linq;

    public class StatefulActionSerializationTests
    {
        [Fact]
        public void NestedWorkflow_SerializesPopulatedStatefulWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
            var nestedWorkflow = WorkflowActions.BuiltIn.NestedWorkflow(
                workflowReferenceName: () => "ChildWorkflow",
                requestBody: () => new
                {
                    name = "Ada",
                    attempt = 2,
                    enabled = true,
                },
                headers: () => new Dictionary<string, string>
                {
                    { "x-correlation-id", "fixed-id" },
                    { "x-mode", "strict" },
                })
                .WithName("Call_child");
            trigger.Then(nestedWorkflow);

            var actual = JObject.Parse(
                WorkflowFactory.CreateStatefulWorkflow("nested-workflow", trigger).ToJson());
            var expected = JObject.Parse(
                """
                {
                  "kind": "Stateful",
                  "definition": {
                    "$schema": "https://schema.management.azure.com/schemas/2016-06-01/workflowdefinition.json#",
                    "triggers": {
                      "manual": {
                        "type": "Request",
                        "kind": "Http"
                      }
                    },
                    "actions": {
                      "Call_child": {
                        "type": "Workflow",
                        "inputs": {
                          "host": {
                            "workflow": {
                              "id": "ChildWorkflow"
                            }
                          },
                          "body": {
                            "name": "Ada",
                            "attempt": 2,
                            "enabled": true
                          },
                          "headers": {
                            "x-correlation-id": "fixed-id",
                            "x-mode": "strict"
                          }
                        },
                        "runAfter": {}
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void GenericCompose_SerializesStatefulValueShapes()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
            var objectValue = WorkflowActions.BuiltIn.Compose<object>(
                () => new { name = "Ada", count = 2 })
                .WithName("Object_value");
            var arrayValue = WorkflowActions.BuiltIn.Compose<string[]>(
                () => new[] { "first", "second" })
                .WithName("Array_value");
            var booleanValue = WorkflowActions.BuiltIn.Compose<bool>(() => true)
                .WithName("Boolean_value");
            var integerValue = WorkflowActions.BuiltIn.Compose<int>(() => 5)
                .WithName("Integer_value");
            var floatValue = WorkflowActions.BuiltIn.Compose<double>(() => 2.5)
                .WithName("Float_value");
            var nullValue = WorkflowActions.BuiltIn.Compose<object>(() => null)
                .WithName("Null_value");
            var runtimeExpression = WorkflowActions.BuiltIn.Compose<int>(
                () => integerValue.Output + 2)
                .WithName("Runtime_expression");

            trigger.Then(objectValue);
            trigger.Then(arrayValue);
            trigger.Then(booleanValue);
            trigger.Then(integerValue).Then(runtimeExpression);
            trigger.Then(floatValue);
            trigger.Then(nullValue);

            var actual = JObject.Parse(
                WorkflowFactory.CreateStatefulWorkflow("compose-workflow", trigger).ToJson());
            var expected = JObject.Parse(
                """
                {
                  "kind": "Stateful",
                  "definition": {
                    "$schema": "https://schema.management.azure.com/schemas/2016-06-01/workflowdefinition.json#",
                    "triggers": {
                      "manual": {
                        "type": "Request",
                        "kind": "Http"
                      }
                    },
                    "actions": {
                      "Object_value": {
                        "type": "Compose",
                        "inputs": {
                          "name": "Ada",
                          "count": 2
                        },
                        "runAfter": {}
                      },
                      "Array_value": {
                        "type": "Compose",
                        "inputs": [
                          "first",
                          "second"
                        ],
                        "runAfter": {}
                      },
                      "Boolean_value": {
                        "type": "Compose",
                        "inputs": true,
                        "runAfter": {}
                      },
                      "Integer_value": {
                        "type": "Compose",
                        "inputs": 5,
                        "runAfter": {}
                      },
                      "Runtime_expression": {
                        "type": "Compose",
                        "inputs": "@add(outputs('Integer_value'), 2)",
                        "runAfter": {
                          "Integer_value": [
                            "SUCCEEDED"
                          ]
                        }
                      },
                      "Float_value": {
                        "type": "Compose",
                        "inputs": 2.5,
                        "runAfter": {}
                      },
                      "Null_value": {
                        "type": "Compose",
                        "inputs": null,
                        "runAfter": {}
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public async Task CustomCode_SerializesRegistersCallbackAndPreservesArtifactName()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
            var customCode = WorkflowActions.BuiltIn.CustomCode<CustomCodeResult>(
                ExecuteCustomCodeAsync)
                .WithName("Run_custom_code");
            trigger.Then(customCode);

            var workflow = WorkflowFactory.CreateStatefulWorkflow(
                "custom-code-workflow",
                trigger);
            var artifacts = new CodefulWorkflowsArtifacts
            {
                Flows = new Dictionary<string, FlowDefinition>
                {
                    [workflow.Name] = workflow,
                },
            };

            var actual = JObject.Parse(artifacts.ToJson());
            var expected = JObject.Parse(
                """
                {
                  "flows": {
                    "custom-code-workflow": {
                      "kind": "Stateful",
                      "definition": {
                        "$schema": "https://schema.management.azure.com/schemas/2016-06-01/workflowdefinition.json#",
                        "triggers": {
                          "manual": {
                            "type": "Request",
                            "kind": "Http"
                          }
                        },
                        "actions": {
                          "Run_custom_code": {
                            "type": "CSharpScriptCode",
                            "inputs": {
                              "userFunctionName": "ExecuteCustomCodeAsync"
                            },
                            "runAfter": {}
                          }
                        }
                      }
                    }
                  }
                }
                """);

            Assert.Equal("custom-code-workflow", workflow.Name);
            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());

            var executor = new ScriptExecutor(
                session: null,
                loggerFactory: NullLoggerFactory.Instance);
            var execution = await executor.RunScript(new InvocationDetails
            {
                ScriptFileName = Path.Combine(
                    "custom-code-workflow",
                    nameof(ExecuteCustomCodeAsync)),
                SessionId = "session",
            });

            Assert.True(execution.Succeeded, execution.Error?.Message);
            Assert.Equal(
                JObject.Parse("""{"message":"registered"}"""),
                JObject.Parse(execution.Outputs));
        }

        private static Task<CustomCodeResult> ExecuteCustomCodeAsync(
            WorkflowContext context)
        {
            return Task.FromResult(new CustomCodeResult
            {
                Message = "registered",
            });
        }

        private class CustomCodeResult
        {
            public string Message { get; set; }
        }
    }
}
