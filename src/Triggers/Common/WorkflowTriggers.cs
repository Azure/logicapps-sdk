// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides the top-level entry point for creating workflow triggers. Use the <see cref="BuiltIn"/>
    /// property to access built-in trigger types (HTTP Request, Recurrence, Conversational Agent) and the
    /// <see cref="Managed"/> property to access triggers provided by managed API connectors.
    /// </summary>
    /// <example>
    /// <code>
    /// // Create a built-in HTTP trigger
    /// var httpTrigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("MyTrigger");
    ///
    /// // Create a built-in recurrence trigger
    /// var timerTrigger = WorkflowTriggers.BuiltIn.CreateRecurrenceTrigger(frequency: FlowRecurrenceFrequency.Hour, interval: 1);
    /// </code>
    /// </example>
    /// <seealso cref="WorkflowBuiltInTriggers"/>
    /// <seealso cref="WorkflowManagedTriggers"/>
    public static class WorkflowTriggers
    {
        /// <summary>
        /// Gets the factory for built-in workflow triggers such as HTTP Request, Recurrence,
        /// and Conversational Agent triggers.
        /// </summary>
        public static WorkflowBuiltInTriggers BuiltIn = new WorkflowBuiltInTriggers();

        /// <summary>
        /// Gets the factory for managed connector triggers (e.g., Service Bus, Event Grid).
        /// Managed connector triggers are auto-generated from connector definitions and available as
        /// extension methods on this instance.
        /// </summary>
        public static WorkflowManagedTriggers Managed = new WorkflowManagedTriggers();
    }
}
