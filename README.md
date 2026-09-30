Azure LogicApps SDK
===

The **Azure Logic Apps SDK** is a framework that simplifies authoring Logic Apps workflows using code.

## Quick start

> See the official documentation: [Create Standard workflow projects with the SDK](https://learn.microsoft.com/en-us/azure/logic-apps/standard-sdk/create-workflows-with-csharp). Code-first (codeful) workflows are currently in preview.

### Creating a codeful logic app project

The easiest way to get started is to scaffold a codeful Logic Apps project using the **Azure Logic Apps (Standard)** extension for VS Code (`ms-azuretools.vscode-azurelogicapps`):

1. Install the [Azure Logic Apps (Standard)](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurelogicapps) extension from the VS Code Marketplace.
2. In the **Azure** window, on the **Workspace** toolbar, open the **Azure Logic Apps** menu and select **Create new logic app workspace**.
3. For **Logic app project and workflow type**, choose **Logic app (codeful)**, then pick a **Workflow type**: **Stateful**, **Conversational agents**, or **Autonomous agents**.
4. When prompted, choose **Use connectors from Azure** to enable Azure-hosted managed connectors, then select a subscription, resource group, and authentication type (connection keys, or managed identity where supported).
5. The extension scaffolds a C# project that references the `Microsoft.Azure.Workflows.Sdk` NuGet package, with a `Program.cs` (builds, configures, and starts the host) and a `<workflow_name>.cs` file (defines the trigger and actions for that workflow).
6. Press **F5** to build, run, and debug the workflow locally. The **Overview** page shows run history and lets you trigger the workflow.
7. To add another workflow to the project, open the project's shortcut menu in the Explorer and select **Create workflow**.

> **Note:** During preview, only Azure-hosted managed connectors are supported end-to-end for triggers and actions; built-in service provider operations, dynamic schemas, and managed identity authentication for connectors aren't yet available. Connections are recorded in `connections.json`, and secrets are stored in `local.settings.json` — don't commit `local.settings.json` to source control.

You can also reference the `Microsoft.Azure.Workflows.Sdk` NuGet package from an existing project:

```xml
<PackageReference Include="Microsoft.Azure.Workflows.Sdk" Version="<latest>" />
```

## Example workflow definitions

A codeful workflow is defined by implementing `IWorkflowProvider` and returning one or more `FlowDefinition`s built from triggers and actions. Register each provider at startup so `WorkflowInitializationService` can discover it:

> **Note:** The examples below include built-in service provider actions (e.g., Azure Queues) to show the SDK's full action surface. Per the [official documentation](https://learn.microsoft.com/en-us/azure/logic-apps/standard-sdk/create-workflows-with-csharp), only Azure-hosted managed connectors are supported end-to-end in code-first workflows during the current preview; service provider actions are planned for a future release.

```csharp
var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        WorkflowFactory.ConfigureServices(services);
        services.AddWorkflowProvider<MinimalOrderWorkflow>();
        services.AddWorkflowProvider<ApprovalWorkflow>();
        services.AddWorkflowProvider<WeatherAgentWorkflow>();
    })
    .Build();
```

### 1. Minimal workflow with trigger/action

An HTTP trigger feeds a service provider action (built-in Azure Queues connector) and returns the result:

```csharp
public class MinimalOrderWorkflow : IWorkflowProvider
{
    public FlowDefinition[] GetWorkflows()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("HttpTrigger");

        var sendMessage = WorkflowActions.ServiceProviders.Azurequeues("azureQueuesConnection")
            .PutMessage(
                queueName: () => "orders",
                message: () => $"New order received: {trigger.TriggerOutput.Body}")
            .WithName("Send_Queue_Message");

        var response = WorkflowActions.BuiltIn.Response(
            responseBody: () => $"Order queued with message Id: {sendMessage.Output.MessageId}")
            .WithName("HttpResponse");

        trigger.Then(sendMessage).Then(response);

        return new[] { WorkflowFactory.CreateStatefulWorkflow("MinimalOrderWorkflow", trigger) };
    }
}
```

### 2. Workflow with control flow and branching

A `Condition` action branches on the request body, routing to a managed connector (Office 365 Outlook) in one branch and a service provider action (Azure Queues) in the other. The condition's own completion status then fans out into a `runAfter` branch: a success path (Office 365 Outlook) and a failure/time-out path (Azure Queues):

```csharp
public class ApprovalWorkflow : IWorkflowProvider
{
    public FlowDefinition[] GetWorkflows()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("HttpTrigger");

        // Branch on the request body.
        var condition = WorkflowActions.BuiltIn.Control.Condition(
            expression: () => trigger.TriggerOutput.Body["amount"].ToObject<int>() > 1000,
            trueBranch: () => WorkflowActions.Managed.Office365("outlook").SendEmail(
                emailMessageto: () => "manager@contoso.com",
                emailMessagesubject: () => "Approval required",
                emailMessagebody: () => $"Approval needed for request: {trigger.TriggerOutput.Body}")
                .WithName("Request_Manager_Approval"),
            falseBranch: () => WorkflowActions.ServiceProviders.Azurequeues("azureQueuesConnection")
                .PutMessage(
                    queueName: () => "auto-approved",
                    message: () => $"Auto-approved request: {trigger.TriggerOutput.Body}")
                .WithName("Queue_Auto_Approval"))
            .WithName("Check_Approval_Amount");

        var notifySuccess = WorkflowActions.Managed.Office365("outlook").SendEmail(
            emailMessageto: () => "requester@contoso.com",
            emailMessagesubject: () => "Request processed",
            emailMessagebody: () => "Your request was processed successfully.")
            .WithName("Notify_Requester");

        var notifyFailure = WorkflowActions.ServiceProviders.Azurequeues("azureQueuesConnection")
            .PutMessage(
                queueName: () => "failed-approvals",
                message: () => $"Approval processing failed for request: {trigger.TriggerOutput.Body}")
            .WithName("Queue_Failure_Alert");

        // Branch on the Condition action's own completion status.
        trigger
            .Then(condition)
            .Then(parent => new[]
            {
                parent.Then(notifySuccess, runAfter: new[] { FlowStatus.Succeeded }),
                parent.Then(notifyFailure, runAfter: new[] { FlowStatus.Failed, FlowStatus.TimedOut }),
            });

        return new[] { WorkflowFactory.CreateStatefulWorkflow("ApprovalWorkflow", trigger) };
    }
}
```

### 3. Agent workflow

A conversational agent trigger drives an `Agent` action whose tools call managed connectors (MSN Weather and Office 365 Outlook):

```csharp
public class WeatherAgentWorkflow : IWorkflowProvider
{
    public FlowDefinition[] GetWorkflows()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateConversationalAgentTrigger();

        var agent = WorkflowActions.BuiltIn.Agent(
            agentModelType: AgentModelType.AzureOpenAI,
            deploymentId: "gpt-4.1",
            agentModelSettings: new AgentModelSettings
            {
                AgentChatCompletionSettings = new AgentChatCompletionSettings { MaxTokens = 3000, Temperature = 0.7 },
                DeploymentModelProperties = new AgentDeploymentModelProperties { Name = "gpt-4o", Format = "OpenAI", Version = "2024-11-20" }
            },
            connectionName: "agent",
            messages: () => new AgentPromptMessage[]
            {
                new AgentPromptMessage { Role = MessageRole.System, Content = "You are an agent to respond with the weather and send an email." }
            }
        ).WithName("WeatherAgent");

        agent.AddTool(toolContext =>
            {
                return WorkflowActions.Managed.Msnweather("msnweather").CurrentWeather(
                    location: () => toolContext.Parameters.Location,
                    units: () => unitsInput.Imperial);
            },
            description: "This tool gets the weather",
            parameters: new WeatherParameters());

        agent.AddTool(toolContext =>
            {
                return WorkflowActions.Managed.Office365("outlook").SendEmail(
                    emailMessageto: () => toolContext.Parameters.Recipient,
                    emailMessagesubject: () => toolContext.Parameters.Subject,
                    emailMessagebody: () => toolContext.Parameters.Body);
            },
            description: "This tool will send an email",
            parameters: new EmailParameters());

        var workflow = trigger.Then(agent);

        return new[] { WorkflowFactory.CreateAgentWorkflow("WeatherAgentWorkflow", workflow) };
    }

    private class WeatherParameters
    {
        public string Location { get; set; }
    }

    private class EmailParameters
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
```

More sample workflows (control flow, agents, managed connectors, and service providers) are available under [tests/Microsoft.Azure.Workflows.Sdk.UnitTests/Workflows](tests/Microsoft.Azure.Workflows.Sdk.UnitTests/Workflows).

## Repository structure

- **src/** – The `Microsoft.Azure.Workflows.Sdk` library source.
  - `Actions/` – Typed definitions for Logic Apps actions.
  - `Entities/` – Data models for flows, agents, recurrences, and related workflow constructs.
  - `Expressions/` – Logic Apps expression parsing, rendering, and conversion.
  - `Extensions/` – Extension methods for workflows, triggers, providers, and JSON handling.
  - `Factory/` – The workflow factory and provider abstractions used to build workflows.
  - `Grpc/` – gRPC contracts and context types used to communicate with the Logic Apps runtime host.
  - `Runtime/` – Runtime support, including type generation.
  - `ScriptExecutor/` – Compilation and execution of custom C# script code within a workflow.
  - `Services/` – Workflow initialization and supporting services.
  - `Triggers/` – Typed definitions for Logic Apps triggers.
  - `Utils/` – Shared utilities such as connector types, converters, and workflow functions.
- **tests/** – Unit and worker test projects for the SDK.
- **eng/** – Shared MSBuild engineering, versioning, and release infrastructure.
- **.github/** – Repository automation and policies.

## Contributing

Most contributions require a [Contributor License Agreement](https://cla.opensource.microsoft.com). This project follows the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).

## CI packaging

The repository includes an initial .NET tool for producing an environment-neutral
Logic App Standard ZIP from an SDK-based project. See
[`tools/Microsoft.Azure.Workflows.Sdk.Packager/README.md`](tools/Microsoft.Azure.Workflows.Sdk.Packager/README.md)
for installation, usage, assumptions, and current limitations.

## License

This project is under the benevolent umbrella of the [.NET Foundation](http://www.dotnetfoundation.org/) and is licensed under [the MIT License](https://github.com/Azure/azure-webjobs-sdk/blob/master/LICENSE.txt)
