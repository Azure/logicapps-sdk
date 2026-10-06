// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The condition (If) action evaluates an expression and executes one of two branches.
    /// </summary>
    public class ConditionAction : WorkflowActionBase
    {
        private readonly JToken expression;
        private readonly IWorkflowAction trueBranchRoot;
        private readonly IWorkflowAction falseBranchRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionAction"/> class.
        /// </summary>
        /// <param name="expression">The converted boolean expression.</param>
        /// <param name="trueBranchRoot">The root node of the true branch action graph.</param>
        /// <param name="falseBranchRoot">The root node of the false branch action graph.</param>
        internal ConditionAction(
            JToken expression,
            IWorkflowAction trueBranchRoot,
            IWorkflowAction falseBranchRoot)
        {
            if (trueBranchRoot == null && falseBranchRoot == null)
            {
                throw new ArgumentException("Condition action requires at least one non-null branch.");
            }
            this.expression = expression ?? throw new ArgumentNullException(nameof(expression));
            this.trueBranchRoot = trueBranchRoot;
            this.falseBranchRoot = falseBranchRoot;
        }

        /// <summary>
        /// Gets the action definition for this condition action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            var trueActions = ControlActionHelper.CollectActions(this.trueBranchRoot, flowName, flowKind);
            var falseActions = ControlActionHelper.CollectActions(this.falseBranchRoot, flowName, flowKind);

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.If,
                Expression = this.expression,
                Actions = trueActions,
                Else = new FlowTemplateActionBranch
                {
                    Actions = falseActions,
                },
            };
        }
    }
}
