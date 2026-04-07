// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;

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
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the action definition for this scope action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
        {
            var nestedActions = ControlActionHelper.CollectActions(this.actionsRoot, flowName);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Scope,
                Actions = nestedActions,
            };
        }
    }
}
