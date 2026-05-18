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
    public class RecurrenceWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the recurrence workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger(timeZone: TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));

            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"test");
            trigger.Then(compose);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("RecurrenceWorkflow", trigger) };
        }
    }
}
