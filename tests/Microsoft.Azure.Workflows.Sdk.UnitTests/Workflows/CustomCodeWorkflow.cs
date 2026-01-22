// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Threading.Tasks;
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Stateful test workflow with custom code action.
    /// </summary>
    public static class CustomCodeWorkflow
    {
        /// <summary>
        /// Adds the stateful workflow with custom code.
        /// </summary>
        public static void AddStatefulWorkflowWithCustomCode()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("ManualTrigger");
            
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow(
                flowName: "TestStatefulWorkflow",
                trigger: trigger);

            // Add a compose action to process trigger input
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Processing: {trigger.TriggerOutput.Body}");
            builder.AddAction(compose, "ProcessInput");

            // Add custom code action
            var customCode = WorkflowActions.BuiltIn.CustomCode<WorkflowResult>(CustomCodeWorkflow.RunCustomCodeAsync);
            builder.AddAction(customCode, "customCode");

            // Add response action
            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{customCode.Body.Message}");
            builder.AddAction(response, "ReturnResult");
        }

        /// <summary>
        /// Executes the custom code within the workflow.
        /// </summary>
        /// <param name="context">The workflow context.</param>
        /// <returns>The workflow result.</returns>
        public static async Task<WorkflowResult> RunCustomCodeAsync(WorkflowContext context)
        {
            var triggerOutputs = (await context.GetTriggerResults().ConfigureAwait(continueOnCapturedContext: false)).Outputs;
            var name = triggerOutputs?["body"]?["name"]?.ToString();

            return new WorkflowResult
            {
                Message = !string.IsNullOrEmpty(name) 
                    ? $"Hello {name} from custom code action!" 
                    : "Hello from custom code action!",
                Timestamp = System.DateTime.UtcNow,
            };
        }
    }

    /// <summary>
    /// The workflow result class.
    /// </summary>
    public class WorkflowResult
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        public System.DateTime Timestamp { get; set; }
    }
}
