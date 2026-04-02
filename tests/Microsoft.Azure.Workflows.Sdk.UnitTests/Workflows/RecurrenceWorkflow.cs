// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System;
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
            var trigger = WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger(timeZone: TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            WorkflowFactory.CreateStatefulWorkflow("RecurrenceWorkflow", trigger);

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"test");
            trigger.Then(compose);
        }
    }
}
