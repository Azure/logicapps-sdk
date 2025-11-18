// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a conversational flow trigger for agent-based workflows.
    /// </summary>
    internal class ConversationalFlowTrigger : IWorkflowTrigger
    {
        /// <summary>
        /// Gets the name of the conversational flow trigger.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the trigger definition for the conversational flow.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateTrigger"/> configured as a request trigger for agent flows.</returns>
        public FlowTemplateTrigger GetTriggerDefinition()
        {
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.Request,
                Kind = FlowTemplateOperationKind.Agent,
            };
        }

        /// <summary>
        /// Sets the name of the conversational flow trigger.
        /// </summary>
        /// <param name="name">The name to assign.</param>
        public void WithName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Sets the recurrence of the conversational flow trigger.
        /// </summary>
        /// <param name="r">The recurrence object.</param>
        public void WithRecurrence(FlowRecurrence r)
        {
            throw new NotImplementedException();
        }
    }
}
