// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The Switch action evaluates an expression and routes to one of several cases.
    /// </summary>
    public class SwitchAction : WorkflowActionBase
    {
        private readonly JToken onExpression;
        private readonly Dictionary<string, SwitchCase> cases;
        private readonly IWorkflowAction defaultCaseRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchAction"/> class.
        /// </summary>
        /// <param name="onExpression">The expression to switch on.</param>
        /// <param name="cases">A dictionary mapping case labels to their SwitchCase entries.</param>
        /// <param name="defaultCaseRoot">The root action node for the default case (optional).</param>
        public SwitchAction(
            JToken onExpression,
            Dictionary<string, SwitchCase> cases,
            IWorkflowAction defaultCaseRoot = null)
        {
            this.onExpression = onExpression ?? throw new ArgumentNullException(nameof(onExpression));
            this.cases = cases ?? throw new ArgumentNullException(nameof(cases));
            this.defaultCaseRoot = defaultCaseRoot;
        }

        /// <summary>
        /// Gets the action definition for this Switch action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            var templateCases = new Dictionary<string, FlowTemplateActionCaseBranch>();

            foreach (var kvp in this.cases)
            {
                var caseActions = ControlActionHelper.CollectActions(kvp.Value.Actions, flowName);
                templateCases[kvp.Key] = new FlowTemplateActionCaseBranch
                {
                    Case = kvp.Value.Case,
                    Actions = caseActions,
                };
            }

            var action = new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Switch,
                Expression = this.onExpression,
                Cases = templateCases,
            };

            if (this.defaultCaseRoot != null)
            {
                var defaultActions = ControlActionHelper.CollectActions(this.defaultCaseRoot, flowName);
                action.Default = new FlowTemplateActionBranch
                {
                    Actions = defaultActions,
                };
            }

            return action;
        }

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        public SwitchAction WithName(string name)
        {
            this.Name = name;
            return this;
        }
    }
}
