Azure Logic Apps SDK
===

The **Azure Logic Apps SDK** is a code-first framework for building Azure Logic Apps workflows using C# instead of the visual designer. This SDK enables developers to define workflows programmatically with full IntelliSense support, type safety, and the ability to generate deployment-ready Azure Logic Apps (Standard) artifacts.

## Overview

This SDK allows you to:

- **Define workflows in C#** with strongly-typed actions, triggers, and connectors
- **Leverage IntelliSense** for discovering available operations and parameters
- **Automatic expression conversion** from C# lambda expressions to Logic Apps expression syntax
- **Generate deployment-ready artifacts** including workflow definitions and connections.json
- **Use managed connectors** like MSN Weather, Office 365, Teams, Outlook, and more
- **Create both stateful and stateless workflows** for different execution patterns

## Key Features

### 1. Code-First Workflow Development

Write workflows in C# instead of using the visual designer:

```csharp
var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
    "MyWorkflow",
    WorkflowTriggers.BuiltIn.CreateHttpTrigger());

var compose = WorkflowActions.BuiltIn.Compose(
    inputs: () => $"Hello {builder.TriggerOutput.Body}");
compose.WithName("ComposeGreeting");
builder.AddAction(compose);

var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => compose);
response.WithName("SendResponse");
builder.AddAction(response);
```

### 2. Automatic Expression Conversion

C# expressions are automatically converted to Logic Apps expression language:

```csharp
// C# Code:
() => $"Hello {builder.TriggerOutput.Body}"

// Generated Logic Apps Expression:
"Hello @{triggerOutputs()?['Body']}"
```

### 3. Managed Connector Support

Access to Azure's managed connectors with full type safety:

```csharp
var weather = WorkflowActions.ManagedConnectors.Msnweather("msnweather-connection")
    .CurrentWeather(
        location: () => "Seattle",
        units: () => CurrentWeatherunitsInput.Imperial);
builder.AddAction(weather);
```

### 4. Deployment-Ready Artifact Generation

Generate Azure Logic Apps (Standard) structure with a single method call:

```csharp
var artifacts = WorkflowBuilderFactory.GetCodefulWorkflowArtifacts();
WorkflowArtifactWriter.SaveAsLogicAppStandard(artifacts, "./LogicApp");
```

This creates:
```
LogicApp/
├── WorkflowName1/
│   └── workflow.json
├── WorkflowName2/
│   └── workflow.json
└── connections.json          # Automatically generated!
```

### 5. Automatic Connection Detection

The SDK automatically:
- Scans workflows for API connection references
- Extracts unique connection names
- Generates proper `connections.json` with Azure resource IDs
- Infers connector types from connection names

## Project Structure

```
logicapps-sdk/
├── src/
│   ├── Actions/              # Built-in and managed connector actions
│   ├── Triggers/             # Workflow triggers (HTTP, Recurrence, etc.)
│   ├── Builder/              # Workflow builder and factory classes
│   ├── Utils/                # Utilities for artifacts and connections
│   ├── Entities/             # Core entity definitions
│   ├── Expressions/          # Expression conversion logic
│   └── generated/            # Auto-generated connector bindings
└── test/
    └── SampleWorkflows/      # Example project demonstrating SDK usage
```

## Getting Started

### Prerequisites

- .NET SDK 6.0 or later
- Azure subscription (for deployment)

### Quick Start

1. **Create a new C# project** and reference the SDK:

```xml
<ItemGroup>
  <ProjectReference Include="..\src\Microsoft.Azure.Workflows.Sdk.csproj" />
</ItemGroup>
```

2. **Define your workflow**:

```csharp
using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.Connectors;

var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
    "HelloWorldWorkflow",
    WorkflowTriggers.BuiltIn.CreateHttpTrigger());

var compose = WorkflowActions.BuiltIn.Compose(
    inputs: () => "Hello from Logic Apps SDK!");
compose.WithName("CreateMessage");
builder.AddAction(compose);

var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => compose);
response.WithName("SendResponse");
builder.AddAction(response);
```

3. **Generate artifacts**:

```csharp
var artifacts = WorkflowBuilderFactory.GetCodefulWorkflowArtifacts();
WorkflowArtifactWriter.SaveAsLogicAppStandard(artifacts, "./LogicApp");
```

4. **Deploy to Azure** using the generated files in the `LogicApp/` directory

## Available Components

### Built-In Triggers
- `CreateHttpTrigger()` - HTTP request trigger
- `CreateRecurrenceTrigger()` - Schedule-based trigger with frequency and interval

### Built-In Actions
- `Compose()` - Data transformation and composition
- `HttpAction()` - Make HTTP requests to external APIs
- `Response()` - Return HTTP responses
- `NestedWorkflow()` - Call other workflows

### Managed Connectors
- MSN Weather (`Msnweather`)
- Office 365 (`Office365`)
- Microsoft Teams (`Teams`)
- Outlook (`Outlook`)
- Common Data Service (`Commondataservice`)
- Microsoft Forms (`Microsoftforms`)

### Workflow Types
- **Stateful** - Maintains execution history, suitable for long-running workflows
- **Stateless** - No state preservation, optimized for high-performance scenarios

## Examples

See the [test/SampleWorkflows](./test/SampleWorkflows) directory for complete working examples including:

1. Simple HTTP request/response workflow
2. Weather lookup with managed connector
3. Scheduled workflow with recurrence
4. External API integration

## Artifact Writers

The SDK provides two output formats:

### 1. Azure Logic Apps Standard Structure (Recommended)
```csharp
WorkflowArtifactWriter.SaveAsLogicAppStandard(artifacts, outputPath);
```

Generates Azure-compatible structure with each workflow in its own folder.

### 2. Flat Structure (Legacy)
```csharp
WorkflowArtifactWriter.SaveFlat(artifacts, outputPath);
```

Generates all workflow JSON files in a single directory.

## Connection Management

### Automatic Generation

The SDK automatically generates `connections.json` based on API connections used in your workflows:

```csharp
var weather = WorkflowActions.ManagedConnectors.Msnweather("msnweather-connection")
    .CurrentWeather(location: () => "Seattle", units: () => CurrentWeatherunitsInput.Imperial);
```

Generates:
```json
{
  "managedApiConnections": {
    "msnweather-connection": {
      "api": {
        "id": "/subscriptions/{subscriptionId}/providers/Microsoft.Web/locations/{location}/managedApis/msnweather"
      },
      "connection": {
        "id": "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Web/connections/msnweather-connection"
      },
      "authentication": {
        "type": "ManagedServiceIdentity"
      }
    }
  }
}
```

### Deployment

Placeholders like `{subscriptionId}`, `{resourceGroup}`, and `{location}` are automatically replaced by Azure during deployment.

## Benefits Over Visual Designer

✅ **Version Control** - Workflows are defined in code, making them easy to track in Git
✅ **Code Reusability** - Share workflow patterns and components across projects
✅ **Type Safety** - Catch errors at compile time instead of runtime
✅ **Refactoring** - Use IDE refactoring tools to update workflow logic
✅ **Testing** - Unit test workflow logic before deployment
✅ **IntelliSense** - Discover available operations and parameters as you type
✅ **CI/CD Integration** - Automate workflow generation and deployment

## Contributing

This project welcomes contributions. Please ensure:
- Code follows existing patterns and conventions
- All changes include appropriate documentation
- Tests are added for new functionality

## License

This project is under the benevolent umbrella of the [.NET Foundation](http://www.dotnetfoundation.org/) and is licensed under [the MIT License](https://github.com/Azure/azure-webjobs-sdk/blob/master/LICENSE.txt)
