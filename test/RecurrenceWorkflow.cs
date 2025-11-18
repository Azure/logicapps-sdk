// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace harness
{
    using Microsoft.Azure.Workflows.Sdk;

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
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("RecurrenceWorkflow", WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger());
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"test");
            builder.AddAction(compose);
        }
    }
}
