// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
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
        public ForEachAction(
            JToken items,
            IWorkflowAction actionsRoot)
        {
            this.items = items ?? throw new ArgumentNullException(nameof(items));
            this.actionsRoot = actionsRoot ?? throw new ArgumentNullException(nameof(actionsRoot));
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the action definition for this ForEach action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
        {
            var nestedActions = ControlActionHelper.CollectActions(this.actionsRoot, flowName);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Foreach,
                Foreach = this.items,
                Actions = nestedActions,
            };
        }
    }
}
