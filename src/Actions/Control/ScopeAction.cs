// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;

    /// <summary>
    /// The scope action groups a set of actions together.
    /// </summary>
    public class ScopeAction : WorkflowActionBase
    {
        private readonly IWorkflowAction actionsRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeAction"/> class.
        /// </summary>
        /// <param name="actionsRoot">The root node of the nested action graph.</param>
        public ScopeAction(IWorkflowAction actionsRoot)
        {
            this.actionsRoot = actionsRoot ?? throw new ArgumentNullException(nameof(actionsRoot));
        }

        /// <summary>
        /// Gets the action definition for this scope action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            var nestedActions = ControlActionHelper.CollectActions(this.actionsRoot, flowName);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Scope,
                Actions = nestedActions,
            };
        }

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        public ScopeAction WithName(string name)
        {
            this.Name = name;
            return this;
        }
    }
}
