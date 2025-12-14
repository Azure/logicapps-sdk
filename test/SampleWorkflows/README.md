# Sample Workflows

This project demonstrates how to use the **Azure Logic Apps SDK** to create workflows programmatically using C# instead of the visual designer.

## What This Does

This example creates 4 different Logic Apps workflows entirely in C# code:

1. **SimpleHttpWorkflow** - HTTP request/response with data composition
2. **WeatherLookupWorkflow** - Weather API integration using MSN Weather connector
3. **ScheduledWorkflow** - Recurrence-based scheduled execution
4. **HttpApiWorkflow** - External HTTP API calls

When you run the program, it generates standard Azure Logic Apps JSON workflow definitions that can be deployed to Azure.

## Project Structure

```
SampleWorkflows/
├── Program.cs                    # Workflow definitions in C#
├── SampleWorkflows.csproj        # Project file (references the SDK)
├── LogicApp/                     # Output directory (generated at runtime)
│   ├── SimpleHttpWorkflow/
│   │   └── workflow.json
│   ├── WeatherLookupWorkflow/
│   │   └── workflow.json
│   ├── ScheduledWorkflow/
│   │   └── workflow.json
│   ├── HttpApiWorkflow/
│   │   └── workflow.json
│   └── connections.json
├── deploy-to-azure.ps1           # PowerShell deployment script
├── deploy-to-azure.sh            # Bash deployment script
└── README.md                     # This file
```

## How to Run

### Generate Workflow Artifacts

```bash
dotnet run
```

This will:
1. Build and execute the workflow definitions
2. Generate JSON files in the `LogicApp/` directory with Azure-compatible structure
3. Automatically generate `connections.json` for any managed connectors used
4. Display a summary of created workflows

### Deploy to Azure

After generating the artifacts, deploy them to Azure using the provided deployment scripts.

#### Prerequisites
- Azure CLI installed and configured
- Logged in to Azure: `az login`
- Appropriate permissions to create resources in your subscription

#### Windows (PowerShell)

```powershell
.\deploy-to-azure.ps1 `
    -SubscriptionId "your-subscription-id" `
    -ResourceGroup "your-resource-group" `
    -LogicAppName "your-logic-app-name" `
    -Location "eastus"
```

#### Linux/Mac (Bash)

```bash
./deploy-to-azure.sh \
    --subscription-id "your-subscription-id" \
    --resource-group "your-resource-group" \
    --logic-app-name "your-logic-app-name" \
    --location "eastus"
```

**Parameters:**
- `SubscriptionId` / `--subscription-id` (required): Your Azure subscription ID
- `ResourceGroup` / `--resource-group` (required): Resource group name (will be created if doesn't exist)
- `LogicAppName` / `--logic-app-name` (required): Logic App name (will be created if doesn't exist)
- `Location` / `--location` (optional): Azure region (default: eastus)
- `ArtifactsPath` / `--artifacts-path` (optional): Path to generated artifacts (default: ./LogicApp)

**What the deployment script does:**
1. Creates resource group if it doesn't exist
2. Creates Logic App (Standard) instance if it doesn't exist
3. Creates required storage account for the Logic App
4. Creates API connections defined in connections.json
5. Deploys all workflows to the Logic App
6. Provides a portal URL to manage your Logic App

#### Post-Deployment Steps

1. **Configure API Connections**: If your workflows use managed connectors (like MSN Weather), you'll need to authenticate these connections in the Azure Portal
2. **Enable Workflows**: Enable the workflows you want to run
3. **Test**: Test your workflows using the provided endpoints

## Example Workflows Created

### 1. SimpleHttpWorkflow
**Type**: Stateful
**Trigger**: HTTP Request
**Actions**:
- Compose a greeting message with the trigger body
- Return HTTP response with the message

**Usage**: POST any JSON to the workflow endpoint

### 2. WeatherLookupWorkflow
**Type**: Stateful
**Trigger**: HTTP Request
**Actions**:
- Call MSN Weather API with location from request body
- Return weather data in response

**Usage**:
```bash
POST { "city": "Seattle" }
```

**Requirements**: Requires MSN Weather API connection named `msnweather-connection`

### 3. ScheduledWorkflow
**Type**: Stateless
**Trigger**: Recurrence (every 10 minutes)
**Actions**:
- Log execution timestamp

**Usage**: Runs automatically on schedule

### 4. HttpApiWorkflow
**Type**: Stateful
**Trigger**: HTTP Request
**Actions**:
- Make HTTP GET request to external API (JSONPlaceholder)
- Return API response

**Usage**: GET request to workflow endpoint

## Understanding the SDK

### Creating a Workflow

```csharp
// Create a stateful workflow with HTTP trigger
var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
    "MyWorkflow",
    WorkflowTriggers.BuiltIn.CreateHttpTrigger());
```

### Adding Actions

```csharp
// Add a compose action
var compose = WorkflowActions.BuiltIn.Compose(
    inputs: () => $"Hello {builder.TriggerOutput.Body}");
compose.WithName("ComposeGreeting");
builder.AddAction(compose);

// Add a response action
var response = WorkflowActions.BuiltIn.Response(
    responseBody: () => $"{compose}");
response.WithName("SendResponse");
builder.AddAction(response);
```

### Using Managed Connectors

```csharp
var weather = WorkflowActions.ManagedConnectors.Msnweather("connection-name")
    .CurrentWeather(
        location: () => "Seattle",
        units: () => CurrentWeatherunitsInput.Imperial);
builder.AddAction(weather);
```

## Key SDK Features Demonstrated

### 1. Expression Conversion
C# lambda expressions are automatically converted to Logic Apps expression syntax:

```csharp
// C# Code:
() => $"Hello {builder.TriggerOutput.Body}"

// Generated Logic Apps Expression:
"Hello! You sent: @{triggerOutputs()?['Body']}"
```

### 2. Type Safety
The SDK provides compile-time type checking:
- IntelliSense for connector operations
- Strongly-typed action outputs
- Parameter validation

### 3. Workflow Types
- **Stateful**: Maintains state, longer running, can be tracked
- **Stateless**: No state preservation, faster execution

### 4. Built-in Actions
- `Compose` - Data transformation
- `HttpAction` - HTTP requests
- `Response` - HTTP responses
- `NestedWorkflow` - Call other workflows

### 5. Triggers
- `CreateHttpTrigger()` - HTTP request trigger
- `CreateRecurrenceTrigger()` - Schedule-based trigger
- Managed connector triggers (email, calendar, etc.)

## Generated Output

The JSON files in `GeneratedWorkflows/` are standard Azure Logic Apps workflow definitions following the [Azure Workflow Definition Language schema](https://schema.management.azure.com/schemas/2016-06-01/workflowdefinition.json#).

These can be:
- Deployed to Azure Logic Apps (Standard)
- Used with Azure Functions workflow runtime
- Imported into the Logic Apps designer
- Version controlled in Git

## Experimenting Further

To create your own workflows:

1. **Modify existing workflows** in `Program.cs`
2. **Add new workflow methods** following the pattern
3. **Explore connectors**:
   - `WorkflowActions.ManagedConnectors.Office365()`
   - `WorkflowActions.ManagedConnectors.Teams()`
   - `WorkflowActions.ManagedConnectors.Outlook()`
4. **Try different triggers**:
   - Recurrence schedules
   - Different HTTP methods
   - Managed connector triggers

## SDK Reference

The SDK is located in `../src/Microsoft.Azure.Workflows.Sdk.csproj`

Key namespaces:
- `Microsoft.Azure.Workflows.Sdk` - Core builders and factories
- `Microsoft.Azure.Workflows.Sdk.Connectors` - Managed connector actions
- `Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather` - Weather connector types

## Next Steps

1. Examine the generated JSON files to understand the output
2. Modify workflow logic and re-run to see changes
3. Try adding new actions or combining multiple connectors
4. Deploy to Azure Logic Apps to see it run

## Notes

- This is a code-first approach to Logic Apps development
- Expression conversion happens at runtime during workflow generation
- The SDK generates standard Logic Apps JSON that works with all Azure tooling
- Managed connector operations require appropriate API connections to be configured in Azure
