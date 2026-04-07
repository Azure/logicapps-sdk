// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The condition (If) action evaluates an expression and executes one of two branches.
    /// </summary>
    public class ConditionAction : WorkflowActionBase
    {
        private readonly string expression;
        private readonly IWorkflowAction trueBranchRoot;
        private readonly IWorkflowAction falseBranchRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionAction"/> class.
        /// </summary>
        /// <param name="expression">The converted boolean expression string.</param>
        /// <param name="trueBranchRoot">The root node of the true branch action graph.</param>
        /// <param name="falseBranchRoot">The root node of the false branch action graph.</param>
        public ConditionAction(
            string expression,
            IWorkflowAction trueBranchRoot,
            IWorkflowAction falseBranchRoot)
        {
            this.expression = expression ?? throw new ArgumentNullException(nameof(expression));
            this.trueBranchRoot = trueBranchRoot ?? throw new ArgumentNullException(nameof(trueBranchRoot));
            this.falseBranchRoot = falseBranchRoot ?? throw new ArgumentNullException(nameof(falseBranchRoot));
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the action definition for this condition action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
        {
            var trueActions = ControlActionHelper.CollectActions(this.trueBranchRoot, flowName);
            var falseActions = ControlActionHelper.CollectActions(this.falseBranchRoot, flowName);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.If,
                Expression = new JValue(this.expression),
                Actions = trueActions,
                Else = new FlowTemplateActionBranch
                {
                    Actions = falseActions,
                },
            };
        }
    }
}
