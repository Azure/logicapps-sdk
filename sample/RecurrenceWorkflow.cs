// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk.Agents;

    /// <summary>
    /// Recurrence trigger class.
    /// </summary>
    public static class RecurrenceWorkflow
    {
        /// <summary>
        /// Adds the recurrence workflow.
        /// </summary>
        public static void AddRecurrenceWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger();
            WorkflowFactory.CreateStatefulWorkflow("RecurrenceWorkflow", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"test");
            trigger.Then(compose);
        }
    }
}
