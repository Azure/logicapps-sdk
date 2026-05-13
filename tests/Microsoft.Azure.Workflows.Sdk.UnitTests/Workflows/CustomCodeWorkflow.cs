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
            WorkflowFactory.CreateStatefulWorkflow(flowName: "TestStatefulWorkflow", trigger: trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Processing: {trigger.TriggerOutput.Body}").WithName("ProcessInput");

            var customCode = WorkflowActions.BuiltIn.CustomCode<WorkflowResult>(CustomCodeWorkflow.RunCustomCodeAsync).WithName("customCode");

            var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{customCode.Body.Message}").WithName("ReturnResult");

            trigger
                .Then(compose)
                .Then(customCode)
                .Then(response);
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
