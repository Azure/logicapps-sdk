// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The Until action repeatedly executes actions until a condition is met.
    /// </summary>
    public class UntilAction : WorkflowActionBase
    {
        private readonly string expression;
        private readonly IWorkflowAction actionsRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="UntilAction"/> class.
        /// </summary>
        /// <param name="expression">The converted boolean expression string for the exit condition.</param>
        /// <param name="actionsRoot">The root node of the action graph to repeat.</param>
        public UntilAction(
            string expression,
            IWorkflowAction actionsRoot)
        {
            this.expression = expression ?? throw new ArgumentNullException(nameof(expression));
            this.actionsRoot = actionsRoot ?? throw new ArgumentNullException(nameof(actionsRoot));
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the action definition for this Until action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
        {
            var nestedActions = ControlActionHelper.CollectActions(this.actionsRoot, flowName);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Until,
                Expression = new JValue(this.expression),
                Actions = nestedActions,
                Limit = JToken.FromObject(new { count = 60, timeout = "PT1H" }),
            };
        }
    }
}
