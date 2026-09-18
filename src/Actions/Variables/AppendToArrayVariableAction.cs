// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The AppendToArrayVariable action appends a value to an existing array workflow variable.
    /// </summary>
    public class AppendToArrayVariableAction : WorkflowActionBase, IVariableWorkflowAction
    {
        private readonly string variableName;
        private readonly JToken value;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppendToArrayVariableAction"/> class.
        /// </summary>
        /// <param name="variableName">The variable name.</param>
        /// <param name="value">The value to append to the array.</param>
        internal AppendToArrayVariableAction(string variableName, JToken value)
        {
            this.variableName = variableName;
            this.value = value;
        }

        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        public string VariableName => this.variableName;

        /// <summary>
        /// Gets the variable value placeholder for use in workflow expressions.
        /// </summary>
        public JToken Value => this.value;

        /// <summary>
        /// Gets the action definition for this append to array variable action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.AppendToArrayVariable,
                Inputs = new VariableActionInput
                {
                    Name = this.variableName,
                    Value = this.value,
                },
            };
        }
    }
}
