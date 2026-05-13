// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The ForEach action iterates over a collection and executes actions for each item.
    /// </summary>
    public class ForEachAction : WorkflowActionBase
    {
        private readonly JToken items;
        private readonly IWorkflowAction actionsRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForEachAction"/> class.
        /// </summary>
        /// <param name="items">The items collection.</param>
        /// <param name="actionsRoot">The root node of the nested action graph.</param>
        internal ForEachAction(
            JToken items,
            IWorkflowAction actionsRoot)
        {
            this.items = items ?? throw new ArgumentNullException(nameof(items));
            this.actionsRoot = actionsRoot ?? throw new ArgumentNullException(nameof(actionsRoot));
        }

        /// <summary>
        /// Gets the action definition for this ForEach action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            var nestedActions = ControlActionHelper.CollectActions(this.actionsRoot, flowName, flowKind);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Foreach,
                Foreach = this.items,
                Actions = nestedActions,
            };
        }
    }
}
