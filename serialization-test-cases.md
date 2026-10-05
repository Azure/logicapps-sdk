# Workflow Serialization Test Cases

Each test case below shows the C# expression under test and the JSON it was
serialized to. Generated action names vary between runs, so the action
identifiers shown are examples from the captured output.

## Test Setup

```csharp
// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using System.Runtime.Serialization;

namespace logicapp
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;

    /// <summary>
    /// "statefule" Stateful Workflow.
    /// </summary>
    public class Statefule : IWorkflowProvider
    {
        /// <summary>
        /// Gets the HTTP request/response workflow definition.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            var getCurrentWeatherAction = WorkflowActions.Managed.Msnweather("msnweather").CurrentWeather(
                location: () => "98058",
                units: () => unitsInput.Imperial);

            var response = WorkflowActions.BuiltIn.Response(
                responseBody: () => $"{getCurrentWeatherAction.Body}" + "something");
            var workflow = trigger.Then(getCurrentWeatherAction).Then(response);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("statefule", workflow) };
        }
    }
}
```

## Weather Response Body Test Cases

### Test Case 1: Interpolated body followed by concatenation

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => $"{getCurrentWeatherAction.Body}" + "something");
```

**Serialized JSON**

```json
{
  "type": "Response",
  "kind": "Http",
  "inputs": {
    "statusCode": 200,
    "body": "#{$\"{body(\"action_47912037\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create())}\" + \"something\"}"
  },
  "runAfter": {
    "action_47912037": [
      "Succeeded"
    ]
  }
}
```

### Test Case 2: Explicit `ToString` followed by concatenation

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => getCurrentWeatherAction.Body.ToString() + "something");
```

**Serialized body**

```json
{
  "body": "#{body(\"action_08868488\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create()).ToString() + \"something\"}"
}
```

### Test Case 3: Direct body concatenation

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => getCurrentWeatherAction.Body + "something");
```

**Serialized body**

```json
{
  "body": "#{body(\"action_91690006\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create()) + \"something\"}"
}
```

### Test Case 4: `string.Format`

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => string.Format("{0}something", getCurrentWeatherAction.Body));
```

**Serialized body**

```json
{
  "body": "#{string.Format(\"{0}something\", body(\"action_46315370\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create()))}"
}
```

### Test Case 5: `string.Concat` with separate arguments

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => string.Concat(getCurrentWeatherAction.Body, "something"));
```

**Serialized body**

```json
{
  "body": "#{string.Concat(body(\"action_12030610\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create()), \"something\")}"
}
```

### Test Case 6: `string.Concat` with an object array

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => string.Concat(
        new object[] { getCurrentWeatherAction.Body, "something" }));
```

**Serialized body**

```json
{
  "body": "#{string.Concat(new object[] { body(\"action_47019554\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create()), \"something\" })}"
}
```

### Test Case 7: `Convert.ToString` followed by concatenation

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => System.Convert.ToString(getCurrentWeatherAction.Body) + "something");
```

**Serialized body**

```json
{
  "body": "#{global::System.Convert.ToString(body(\"action_66157306\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create())) + \"something\"}"
}
```

### Test Case 8: `StringBuilder`

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => new System.Text.StringBuilder()
        .Append(getCurrentWeatherAction.Body)
        .Append("something")
        .ToString());
```

**Serialized body**

```json
{
  "body": "#{new global::System.Text.StringBuilder().Append(body(\"action_45880015\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create())).Append(\"something\").ToString()}"
}
```

### Test Case 9: Nested body property

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => getCurrentWeatherAction.Body.Responses.Source);
```

**Serialized body**

```json
{
  "body": "#{body(\"action_31453183\")[\"responses\"][\"source\"]}"
}
```

### Test Case 10: JSON serialization

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => Newtonsoft.Json.JsonConvert.SerializeObject(
        getCurrentWeatherAction.Body));
```

**Serialized body**

```json
{
  "body": "#{global::Newtonsoft.Json.JsonConvert.SerializeObject(body(\"action_23688359\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create()))}"
}
```

### Test Case 11: Direct body reference

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => getCurrentWeatherAction.Body);
```

**Serialized body**

```json
{
  "body": "#{body(\"action_37670454\")}"
}
```

## Compose Array Output Test Cases

The following examples use this compose action:

```csharp
var values = WorkflowActions.BuiltIn.Compose<int[]>(
    inputs: () => new[] { 1, 2, 3 });
```

### Test Case 12: Interpolated array output

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => $"{values.Output}");

var workflow = trigger.Then(values).Then(response);
```

**Serialized body**

```json
{
  "body": "#{$\"{outputs(\"action_10678293\").ToObject<object>(global::Newtonsoft.Json.JsonSerializer.Create())}\"}"
}
```

**Observed body output**

```text
[
  1,
  2,
  3
]
```

### Test Case 13: `string.Join`

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => string.Join(",", values.Output));
```

**Serialized body**

```json
{
  "body": "#{string.Join(\",\", outputs(\"action_17636918\").ToObject<int[]>())}"
}
```

**Observed output**

```text
1,2,3
```

### Test Case 14: `string.Concat`

**Test case**

```csharp
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => string.Concat(values.Output));
```

**Serialized body**

```json
{
  "body": "#{string.Concat(outputs(\"action_92543078\").ToObject<int[]>())}"
}
```

**Observed output**

```text
123
```
