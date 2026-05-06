// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Agents;

    /// <summary>
    /// Recurrence trigger class.
    /// </summary>
    public class RecurrenceWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the recurrence workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger();

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"test");
            trigger.Then(compose);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("RecurrenceWorkflow", trigger) };
        }
    }
}
