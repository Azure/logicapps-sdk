// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a conversational flow trigger for agent-based workflows.
    /// </summary>
    internal class ConversationalFlowTrigger : WorkflowTriggerBase
    {
        /// <summary>
        /// Gets the name of the conversational flow trigger.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the trigger definition for the conversational flow.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateTrigger"/> configured as a request trigger for agent flows.</returns>
        public override FlowTemplateTrigger GetTriggerDefinition()
        {
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.Request,
                Kind = FlowTemplateOperationKind.Agent,
            };
        }
    }
}
